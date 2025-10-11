<center>
  <h1>ChinaTravel：中国語旅行計画における言語エージェントの実世界ベンチマーク
</h1>
</center>

論文「ChinaTravel：中国語旅行計画における言語エージェントの実世界ベンチマーク」の公式コードベース。

<!-- | [Webpage](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Paper](https://arxiv.org/abs/2412.13682) | [Dataset(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Webpage](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Paper](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Dataset(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Competition(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Competition(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Overview](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 IJCAI 2025 旅行計画チャレンジ (TPC@IJCAI)

ChinaTravelが**Travel Planning Challenge (TPC) @ IJCAI 2025**の公式ベンチマークに選ばれたことを誇りに思います！

**公式コンペティションサイト**：
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

参加者は複雑な制約下で実世界の旅行計画シナリオに対応できる新規エージェントの開発を招待されています。本コンペティションは言語エージェント研究における最先端のアプローチを披露します。

## 📝 変更履歴

### 2025.09
1. TPC@IJCAI2025 DSLトラックのチャンピオンソリューションをアップロードしました。貢献いただいた[@evergreenee](https://github.com/evergreenee)に感謝します。  


### 2025.06

1. コモンセンス評価コードのエラー収集を修正しました。 
2. ピュアニューロエージェントのパイプラインを修正しました。
3. huggingfaceからのデータセット読み込みを修正しました。
4. 構文検証の例外処理を更新しました。


### 2025.05

1. 最新バージョンの更新ログ。
2. TPCの評価コードを提供。

### 2025.04

1. ローカルデータローダーを追加。ユーザーはカスタムクエリをローカルで読み込むことが可能に。"run_exp.py"でデフォルト以外のsplits_name値（例："abc"）を指定すると、システムは自動的にevaluation/default_splits/abc.txtから対応ファイルを読み込みます。このTXTファイルには対象のクエリファイル名が含まれます。
2. 詳細な制約分類。詳細は[Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)を参照。
3. LLM-moduloベースラインを導入
   グラウンドトゥルースのシンボリック検証器を用いたLLM-moduloパイプラインを実装。
   方法論のベースは以下:
   論文: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   コードベース: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. Qwen3-8B/4BによるローカルLLM推論をサポート。

## 🚀 クイックスタート

### ⚙️ セットアップ

1. conda環境を作成し、依存関係をインストール：

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. データベースをダウンロードし、「chinatravel/environment/」ディレクトリに解凍してください

ダウンロードリンク：[Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. オープンソースのLLMをダウンロードします（任意）。

```bash
bash download_llm.sh
```

4. トークナイザーをダウンロードします。

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ 実行

私たちは deepseek（deepseek公式API）、gpt-4o（chatgpt-4o-latest）、glm4-plus、Qwen（Qwen3-8B）、llama、mistral（Mistral-7B-Instruct-v0.3）などのローカル推論をサポートしています。

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**注意**:

- `--oracle_translation` フラグは、注釈付きの正解データへのアクセスを可能にします:

  - `hard_logic_py`: 実行可能な検証DSLコード
  - `hard_logic_nl`: 対応する制約の説明
  - 注釈例の構造:

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- LLM-modulo メソッドは、その記号的洗練プロセスにおいて **oracle_translation** モードを**必要とします**

### 📊 評価

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```
TPC@IJCAI2025では、評価コードが`eval_tpc.py`ファイルに提供されています。評価コードは以下のように実行できます：


```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 ドキュメント

[環境](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[制約](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ 高度な開発

### 1. 独自のエージェントアルゴリズムの開発

独自のエージェントアルゴリズムを開発するには、`chinatravel/agent/base.py` の `BaseAgent` クラスを継承し、`chinatravel/agent/load_model.py` の `init_agent` 関数にアルゴリズムのロジックを追加する必要があります。空のエージェント例として `TPCAgent` を提供しています。

手順：

- **`BaseAgent` クラスを継承する**: `chinatravel/agent` ディレクトリに新しいPythonファイルを作成し、`BaseAgent` を継承した独自のエージェントクラスを定義します。

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```

- **init_agent関数にコードを追加する**: chinatravel/agent/load_model.pyファイルを開き、init_agent関数に新しいエージェントのサポートを追加してください。

```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### 2. 独自のローカルLLMを開発する

独自のローカル大規模言語モデル（LLM）を開発するには、chinatravel/agent/llms.py の AbstractLLM クラスを継承し、llms.py に対応するローカルLLM推論コードを追加する必要があります。空のLLM例としてTPCLLMを提供しています。
手順：

- **AbstractLLMクラスを継承する**: chinatravel/agent/llms.pyファイルでAbstractLLMを継承した独自のLLMクラスを定義します。

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **init_agent関数にコードを追加する**: chinatravel/agent/load_model.pyファイルを開き、init_llm関数に新しいllmのサポートを追加します。

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. 実験スクリプトを使ってコードを実行する

上記の開発が完了したら、実験スクリプトを使ってコードを実行できます。

実行例:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```
結果は `results/YourMethodName_YourLLMName_xxx` ディレクトリに保存されます。例：`results/TPCAgent_TPCLLM`。

## ✉️ お問い合わせ

問題がある場合は、[Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn)、[Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn)、[Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn) にご連絡ください。

## 📌 引用

当論文または関連リソースが研究に役立った場合は、引用をお願いいたします。


```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-11

---