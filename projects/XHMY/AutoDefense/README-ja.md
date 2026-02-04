# AutoDefense: ジェイルブレイク攻撃に対するマルチエージェントLLM防御

[**ブログ**](https://microsoft.github.io/autogen/0.2/blog/2024/03/11/AutoDefense/Defending%20LLMs%20Against%20Jailbreak%20Attacks%20with%20AutoDefense/)

## インストール

```bash
pip install vllm autogen pandas retry openai
```

## [vLLM](https://docs.vllm.ai/) を使用した推論サービスの準備

vLLM は、効率的な推論と複数GPU間の組み込みロードバランシングを備えた OpenAI 互換の API サーバーを提供します。

### vLLM サーバーの起動

希望のモデルで vLLM サーバーを起動します。マルチGPU環境では、`--data-parallel-size` を使用して自動ロードバランシングを有効にします：

**単一GPU：**
```bash
vllm serve Qwen/Qwen3-1.7B --port 8000
```

**複数GPU（例：データ並列処理による2GPU）：**
```bash
vllm serve Qwen/Qwen3-1.7B --port 8000 --data-parallel-size 2
```

**より大きなモデルのためのテンソル並列処理:**
```bash
vllm serve <your-large-model> --port 8000 --tensor-parallel-size 4
```

**テンソル並列とデータ並列の組み合わせ（8 GPU、2ウェイTP × 4ウェイDP）：**
```bash
vllm serve <your-large-model> --port 8000 --tensor-parallel-size 2 --data-parallel-size 4
```

内部ロードバランシングを用いたデータ並列展開の詳細については、[vLLMドキュメント](https://docs.vllm.ai/en/latest/serving/data_parallel_deployment/)を参照してください。

### サーバーの確認

モデルエンドポイントをチェックして、サーバーが稼働していることを確認できます：

```bash
curl http://localhost:8000/v1/models
```

## 応答生成

応答はvLLMによって提供されるターゲットモデル（デフォルト：`Qwen/Qwen3-1.7B`）によって生成されます。以下のコマンドを実行する前に、vLLMサーバーが稼働していることを確認してください。

### 攻撃プロンプト（有害）

```bash
python attack/attack.py --model Qwen/Qwen3-1.7B --host 127.0.0.1 --port 8000
```

このコマンドは、`data/prompt/attack_prompt_template.json`から読み込まれた攻撃プロンプトテンプレート（デフォルト：`--template v1`）を使用して応答を生成します。  
複数回繰り返す場合は、スクリプトを複数回呼び出し、`--output-suffix`および/または`--cache-seed`を変更してください。  

### 安全なプロンプト（無害）

安全なプロンプト（誤検知評価に使用）で応答を生成するには：

```bash
python attack/attack.py \
    --model Qwen/Qwen3-1.7B \
    --template placeholder \
    --prompts data/prompt/safe_prompts.json \
    --output-prefix safe
```

`placeholder` テンプレートは攻撃フレーミングなしでプロンプトをそのまま渡しますが、`v1` は脱獄指示でプロンプトをラップします。

## 防御実験の実行

以下のコマンドは、1エージェント、2エージェント、3エージェントの防御実験を実行します。`--chat-file` は `attack/attack.py` によって生成された有害な出力を指す必要があります（デフォルトでは `data/harmful_output/<model_dir>/` に保存されます。例：`data/harmful_output/Qwen-Qwen3-1.7B/attack-dan_0.json`）。

```bash
export AUTOGEN_USE_DOCKER=0

python defense/run_defense_exp.py \
  --model Qwen/Qwen3-1.7B \
  --chat-file data/harmful_output/Qwen-Qwen3-1.7B/attack-dan_0.json
```

### コマンドライン引数

| 引数 | 説明 | デフォルト |
|----------|-------------|---------|
| `--model` | vLLMが提供する対象モデル | `Qwen/Qwen3-1.7B` |
| `--chat-file` | 有害な出力を含むチャットファイルのパス | 必須 |
| `--port` | vLLMサーバーが動作するポート | `8000` |
| `--host` | vLLMサーバーのホスト名 | `127.0.0.1` |
| `--output-dir` | 出力ディレクトリ | `data/defense_output/<model_dir>` |
| `--output-suffix` | 出力ディレクトリのサフィックス | `""` |
| `--strategies` | 実行する防御戦略 | `ex-2 ex-3 ex-cot` |
| `--workers` | 並列ワーカー数 | `128` |
| `--frequency_penalty` | 生成時の頻度ペナルティ | `0.0` |
| `--presence_penalty` | 生成時の存在ペナルティ | `0.0` |
| `--temperature` | 生成時の温度パラメータ | `0.7` |

防御実験が終了すると、出力は `data/defense_output/<model_dir>/`（例: `data/defense_output/Qwen-Qwen3-1.7B/`）に表示されます。

## GPT評価（論文ではGPT-4を使用）

有害な出力防御の評価:

```bash
python evaluator/gpt4_evaluator.py \
--defense_output_dir data/defense_output/Qwen-Qwen3-1.7B \
--ori_prompt_file_name prompt_dan.json
```
評価が終了すると、出力は `data/defense_output/Qwen-Qwen3-1.7B/asr.csv` に表示されます。  
各防御出力に対して、出力の `json` ファイルに `score` 値も表示されます。  
`evaluator/gpt4_evaluator.py` は評価者としてGPTモデルを使用します（元の論文ではGPT-4を使用）。  
環境変数（またはCLIフラグ）を通じてOpenAIの認証情報を設定し、`--model` オプションで評価者を新しいGPTモデル（例：GPT-5）に切り替えることができます。  

```bash
export OPENAI_API_KEY=...
# optional (only if you use an OpenAI-compatible endpoint):
# export OPENAI_BASE_URL=...

python evaluator/gpt4_evaluator.py \
  --defense_output_dir data/defense_output/Qwen-Qwen3-1.7B \
  --ori_prompt_file_name prompt_dan.json \
  --model gpt-4-1106-preview
```

GPTベースの評価はコストがかかるため、繰り返し評価を避けるためにキャッシュ機能を有効にしています。

安全な応答評価のために、GPT-4を使用しない効率的な方法があります。データセット内のすべてのプロンプトが通常のユーザープロンプトであり、拒否されるべきでないことが分かっている場合、次のコマンドを使用して防御出力の偽陽性率（FPR）を評価できます。

```bash
python evaluator/evaluate_safe.py
```

これは、`data/defense_output` 内のキーワード `-safe` を含むすべての出力フォルダを見つけ、誤検知率（FPR）を評価します。  
FPR は `data/defense_output/defense_fp.csv` ファイルに保存されます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-04

---