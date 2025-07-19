<translate-content># Fastgen

**高スループットな密なトランスフォーマーからの推論。**

Fastgenは、最先端の技術を備えたLLM推論ライブラリです：
バッチ推論、CUDAグラフ、ページドアテンション、
チャンク化されたプリフィル、ホスト側kvキャッシュ、テンソル並列、
CPU/GPUプロファイリング。

これは、ミニマルな（約3kloc）vLLMと見なすことができ、
RLループや合成データ生成パイプラインなどの
大規模システムに簡単に組み込むことができます。

以下のHuggingFaceモデルがサポートされていることが知られています：
Llama 3.1 8B、Mistral 7B、Ministral 8B、R1-Llama 8Bおよび70B、
R1-Qwen 14B、Qwen2.5 7Bおよび14B；その他も動作する可能性があります。

## ベンチマーク

|                       | Fastgen      | vLLM (0.8.4) |
| --------------------- | ------------ | -----------  |
| Mistral 7B / 1x H100  | 3430 toks/s  | 3390 toks/s  |
| Qwen2.5 14B / 1x H100 | 1700 toks/s  | 1700 toks/s  |
| Llama 70B / 8x H100   | 2260 toks/s  | 2230 toks/s  |

この表に示されたスループットは
`fgserve`（下記参照）と`vllm serve`を使用して収集され、
128ステップのデコード負荷を512プロンプト（各1024トークン）に適用したものです。
以下の図は、Mistral 7Bモデルの
様々な生成負荷にわたる詳細な結果を示しています。

![Mistral 7B Benchmark](https://raw.githubusercontent.com/facebookresearch/fastgen/main/scripts/data/mistral7-perf.png)

> [!注意]
> `fgserve`でテストを実行すると
> 短いプロンプトでパフォーマンスが低下する場合があります。
> この低下は、最適化されていないスレッドHTTPサーバーコードによるもので、
> Fastgenが小さな（非効率な）バッチで動作するためです。
> Fastgenを使用する本番環境アプリケーションでは
> プロセスベースの並列処理を採用すべきです。

## デモツール

ライブラリには2つのツールが付属しています：`fgchat`と`fgserve`。
最初のツールはコマンドラインチャットを実装した基本的なデモです。
2つ目は最小限のOpenAIチャットAPIを提供します。

### fgchat

```
$ # on an RTX A5000
$ # accelerate inference with '--tensor-parallel N' if you have N GPUs
$ fgchat mistralai/Mistral-7B-Instruct-v0.3  
loading: 100%|███████████████████████▉| 14.5G/14.5G [00:00<00:00, 75.9GB/s]
Ready to chat!
  Available commands:
    /r <N> -- reset conversation before round N
    /m     -- input a multiline message, end your input
              with a single line containing '.'
    /q     -- quit

---
1> hello
Hello! How can I help you today? [...]
--- [33 tokens, 26.554toks/s]
2> can you give me some makeup advice?
Of course! Here are some general makeup tips that might be helpful:

[...]
--- [489 tokens, 34.715toks/s]
3> /q
```
### fgserve


```
$ fgserve mistralai/Mistral-7B-Instruct-v0.3  
...
$ cat test.py
from openai import OpenAI
client = OpenAI(base_url="http://localhost:5678", api_key="foo")

completion = client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[
        {"role": "system", "content": "You are a helpful assistant."},
    ] + [
        {
            "role": "user",
            "content": "Write a haiku about recursion in programming."
        }
    ]
)
print(completion.choices[0].message.content)

$ python test.py
Code dives within,
Echoes of self repeat,
Solving the unseen.
```
## 謝辞

感謝：
- [vLLMプロジェクト](https://github.com/vllm-project/vllm)に対して、
  インスピレーションとFastgenで活用されている多くの革新（ページドアテンション、
  チャンクドプリフィルなど）を提供してくれたことに感謝します。
- Daniel Haziza（[@danthe3rd](https://github.com/danthe3rd)）には、
  建設的な初期設計の議論および高いGPU利用率を達成するための継続的な
  アドバイスに感謝します。

## ライセンス

FastgenはBSD 3-Clauseライセンスで提供されており、詳細はLICENSEファイルに記載されています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---