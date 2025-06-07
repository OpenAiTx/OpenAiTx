# DeepSeek-R1
<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-R1" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/" target="_blank"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/" target="_blank"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20R1-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai" target="_blank"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5" target="_blank"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true" target="_blank"><img alt="WeChat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai" target="_blank"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE"><img alt="License"
    src="https://img.shields.io/badge/License-MIT-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/DeepSeek_R1.pdf"><b>Paper Link</b>👁️</a>
</div>

## 1. はじめに

私たちは、初代推論モデルである DeepSeek-R1-Zero および DeepSeek-R1 を紹介します。
DeepSeek-R1-Zero は、大規模強化学習（RL）によって訓練され、教師ありファインチューニング（SFT）を予備段階として用いないモデルであり、推論において顕著な性能を示しました。
RLによって、DeepSeek-R1-Zero は多くの強力かつ興味深い推論行動を自然に獲得しました。
しかし、DeepSeek-R1-Zero は、無限ループ、可読性の低下、言語混合などの課題に直面しています。これらの課題に対処し、さらに推論性能を強化するために、
RLの前にコールドスタートデータを導入した DeepSeek-R1 をご紹介します。
DeepSeek-R1 は、数学、コード、推論タスクにおいて OpenAI-o1 と同等の性能を達成しています。
研究コミュニティを支援するために、DeepSeek-R1-Zero、DeepSeek-R1、および DeepSeek-R1 から蒸留された6つの高密度モデル（Llama および Qwen ベース）をオープンソース化しました。DeepSeek-R1-Distill-Qwen-32B は、様々なベンチマークで OpenAI-o1-mini を上回り、高密度モデルとして新たな最先端性能を達成しています。

**注意：DeepSeek-R1シリーズモデルをローカルで実行する前に、[使用推奨](#usage-recommendations) セクションを必ずご確認ください。**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. モデル概要

---

**ポストトレーニング：ベースモデルへの大規模強化学習適用**

-  教師ありファインチューニング（SFT）を予備段階として用いることなく、ベースモデルに直接強化学習（RL）を適用します。このアプローチにより、モデルは複雑な問題を解決するための思考の連鎖（CoT）を自発的に探索できるようになり、DeepSeek-R1-Zero が誕生しました。DeepSeek-R1-Zero は、自己検証、内省、長いCoTの生成といった能力を示し、研究コミュニティにとって重要なマイルストーンとなりました。特に、本研究はLLMの推論能力がSFTなしで純粋にRLによって促進されることを実証した最初の公開研究です。このブレークスルーは今後の発展に道を開きます。

-  DeepSeek-R1 の開発パイプラインを導入します。このパイプラインには、より良い推論パターンの発見と人間の好みに整合するための2つのRL段階、およびモデルの推論・非推論能力の種となる2つのSFT段階が含まれています。
    このパイプラインは、より優れたモデルを生み出すことで業界に貢献できると考えています。

---

**蒸留：小型モデルも強力になりうる**

-  大型モデルの推論パターンが小型モデルに蒸留されることで、小型モデルがRLで発見した推論パターンよりも高い性能を発揮できることを示しました。オープンソースのDeepSeek-R1およびそのAPIは、将来的により良い小型モデルの蒸留に役立ちます。
-  DeepSeek-R1が生成した推論データを活用し、研究コミュニティで広く使用されている複数の高密度モデルをファインチューニングしました。評価結果は、蒸留された小型高密度モデルがベンチマークで卓越した性能を発揮することを示しています。Qwen2.5 および Llama3 シリーズをベースとした 1.5B、7B、8B、14B、32B、70B の蒸留チェックポイントをコミュニティに公開します。

## 3. モデルダウンロード

### DeepSeek-R1 モデル

<div align="center">

| **モデル** | **総パラメータ数** | **有効パラメータ数** | **コンテキスト長** | **ダウンロード** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero および DeepSeek-R1 は DeepSeek-V3-Base をベースに訓練されています。
モデルアーキテクチャの詳細については、[DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) リポジトリをご参照ください。

### DeepSeek-R1-Distill モデル

<div align="center">

| **モデル** | **ベースモデル** | **ダウンロード** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

DeepSeek-R1-Distill モデルは、DeepSeek-R1 が生成したサンプルを用いてオープンソースモデルをベースにファインチューニングされています。
設定やトークナイザーを一部変更しています。必ず当方の設定でご利用ください。

## 4. 評価結果

### DeepSeek-R1-評価
すべてのモデルで最大生成長は 32,768 トークンに設定しています。サンプリングを必要とするベンチマークでは、温度を $0.6$、top-p 値を $0.95$ に設定し、クエリごとに64件の応答を生成して pass@1 を推定します。
<div align="center">


| 分類 | ベンチマーク（指標） | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | アーキテクチャ | - | - | MoE | - | - | MoE |
| | 有効パラメータ数 | - | - | 37B | - | - | 37B |
| | 総パラメータ数 | - | - | 671B | - | - | 671B |
| 英語 | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
| | MMLU-Redux (EM) | 88.9 | 88.0 | 89.1 | 86.7 | - | **92.9** |
| | MMLU-Pro (EM) | 78.0 | 72.6 | 75.9 | 80.3 | - | **84.0** |
| | DROP (3-shot F1) | 88.3 | 83.7 | 91.6 | 83.9 | 90.2 | **92.2** |
| | IF-Eval (Prompt Strict) | **86.5** | 84.3 | 86.1 | 84.8 | - | 83.3 |
| | GPQA-Diamond (Pass@1) | 65.0 | 49.9 | 59.1 | 60.0 | **75.7** | 71.5 |
| | SimpleQA (Correct) | 28.4 | 38.2 | 24.9 | 7.0 | **47.0** | 30.1 |
| | FRAMES (Acc.) | 72.5 | 80.5 | 73.3 | 76.9 | - | **82.5** |
| | AlpacaEval2.0 (LC-winrate) | 52.0 | 51.1 | 70.0 | 57.8 | - | **87.6** |
| | ArenaHard (GPT-4-1106) | 85.2 | 80.4 | 85.5 | 92.0 | - | **92.3** |
| コード | LiveCodeBench (Pass@1-COT) | 33.8 | 34.2 | - | 53.8 | 63.4 | **65.9** |
| | Codeforces (Percentile) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Resolved) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| 数学 | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| 中国語 | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### 蒸留モデル評価


<div align="center">

| モデル                                    | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
|------------------------------------------|------------------|-------------------|-----------------|----------------------|----------------------|-------------------|
| GPT-4o-0513                          | 9.3              | 13.4              | 74.6            | 49.9                 | 32.9                 | 759               |
| Claude-3.5-Sonnet-1022             | 16.0             | 26.7                 | 78.3            | 65.0                 | 38.9                 | 717               |
| o1-mini                              | 63.6             | 80.0              | 90.0            | 60.0                 | 53.8                 | **1820**          |
| QwQ-32B-Preview                              | 44.0             | 60.0                 | 90.6            | 54.5               | 41.9                 | 1316              |
| DeepSeek-R1-Distill-Qwen-1.5B       | 28.9             | 52.7              | 83.9            | 33.8                 | 16.9                 | 954               |
| DeepSeek-R1-Distill-Qwen-7B          | 55.5             | 83.3              | 92.8            | 49.1                 | 37.6                 | 1189              |
| DeepSeek-R1-Distill-Qwen-14B         | 69.7             | 80.0              | 93.9            | 59.1                 | 53.1                 | 1481              |
| DeepSeek-R1-Distill-Qwen-32B        | **72.6**         | 83.3              | 94.3            | 62.1                 | 57.2                 | 1691              |
| DeepSeek-R1-Distill-Llama-8B         | 50.4             | 80.0              | 89.1            | 49.0                 | 39.6                 | 1205              |
| DeepSeek-R1-Distill-Llama-70B        | 70.0             | **86.7**          | **94.5**        | **65.2**             | **57.5**             | 1633              |

</div>


## 5. チャットウェブサイト & API プラットフォーム
DeepSeek の公式ウェブサイト [chat.deepseek.com](https://chat.deepseek.com) で DeepSeek-R1 とチャットが可能です。「DeepThink」ボタンをオンにしてください。

また、DeepSeek Platform では OpenAI互換API も提供しています：[platform.deepseek.com](https://platform.deepseek.com/)

## 6. ローカルでの実行方法

### DeepSeek-R1 モデル

DeepSeek-R1 をローカルで実行する方法については、[DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) リポジトリをご覧ください。

**注意：Hugging Face の Transformers にはまだ直接対応していません。**

### DeepSeek-R1-Distill モデル

DeepSeek-R1-Distill モデルは、Qwen や Llama モデルと同様にご利用いただけます。

例えば、[vLLM](https://github.com/vllm-project/vllm) を使用してサービスを簡単に起動できます。

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

また、[SGLang](https://github.com/sgl-project/sglang) を使っても簡単にサービスを開始できます。

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### 使用推奨

**DeepSeek-R1シリーズモデル（ベンチマーク含む）を期待通りの性能でご利用いただくには、以下の設定を推奨します：**

1. 温度を0.5～0.7の範囲（推奨は0.6）に設定し、無限ループや不自然な出力を防いでください。
2. **システムプロンプトは追加せず、すべての指示をユーザープロンプト内に含めてください。**
3. 数学問題の場合、「順を追って推論し、最終解答を \boxed{} 内に記入してください。」のような指示をプロンプトに追加してください。
4. モデル性能評価時は、複数回テストして平均を取ることを推奨します。

また、DeepSeek-R1シリーズモデルは特定のクエリに対して思考パターン（例："\<think\>\n\n\</think\>" の出力）を省略しがちであり、これが性能に悪影響を与える場合があります。
**モデルが十分な推論を行うよう、すべての出力の冒頭で "\<think\>\n" から開始するよう強制することを推奨します。**

### 公式プロンプト
公式DeepSeekウェブ/アプリではシステムプロンプトを使わず、ファイルアップロードおよびウェブ検索用に2種類の専用プロンプトを設計しています。さらに、ウェブ/アプリでの温度は0.6です。

ファイルアップロード用では、{file_name}、{file_content}、{question} を引数として下記テンプレートを使います。
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

ウェブ検索用では、{search_results}、{cur_date}、{question} を引数とします。

中国語クエリの場合のプロンプトは以下です：
```
search_answer_zh_template = \
'''# 以下内容是基于用户发送的消息的搜索结果:
{search_results}
在我给你的搜索结果中，每个结果都是[webpage X begin]...[webpage X end]格式的，X代表每篇文章的数字索引。请在适当的情况下在句子末尾引用上下文。请按照引用编号[citation:X]的格式在答案中对应部分引用上下文。如果一句话源自多个上下文，请列出所有相关的引用编号，例如[citation:3][citation:5]，切记不要将引用集中在最后返回引用编号，而是在答案对应部分列出。
在回答时，请注意以下几点：
- 今天是{cur_date}。
- 并非搜索结果的所有内容都与用户的问题密切相关，你需要结合问题，对搜索结果进行甄别、筛选。
- 对于列举类的问题（如列举所有航班信息），尽量将答案控制在10个要点以内，并告诉用户可以查看搜索来源、获得完整信息。优先提供信息完整、最相关的列举项；如非必要，不要主动告诉用户搜索结果未提供的内容。
- 对于创作类的问题（如写论文），请务必在正文的段落中引用对应的参考编号，例如[citation:3][citation:5]，不能只在文章末尾引用。你需要解读并概括用户的题目要求，选择合适的格式，充分利用搜索结果并抽取重要信息，生成符合用户要求、极具思想深度、富有创造力与专业性的答案。你的创作篇幅需要尽可能延长，对于每一个要点的论述要推测用户的意图，给出尽可能多角度的回答要点，且务必信息量大、论述详尽。
- 如果回答很长，请尽量结构化、分段落总结。如果需要分点作答，尽量控制在5个点以内，并合并相关的内容。
- 对于客观类的问答，如果问题的答案非常简短，可以适当补充一到两句相关信息，以丰富内容。
- 你需要根据用户要求和回答内容选择合适、美观的回答格式，确保可读性强。
- 你的回答应该综合多个相关网页来回答，不能重复引用一个网页。
- 除非用户要求，否则你回答的语言需要和用户提问的语言保持一致。

# 用户消息为：
{question}'''
```

英語クエリの場合のプロンプトは以下です：
```
search_answer_en_template = \
'''# The following contents are the search results related to the user's message:
{search_results}
In the search results I provide to you, each result is formatted as [webpage X begin]...[webpage X end], where X represents the numerical index of each article. Please cite the context at the end of the relevant sentence when appropriate. Use the citation format [citation:X] in the corresponding part of your answer. If a sentence is derived from multiple contexts, list all relevant citation numbers, such as [citation:3][citation:5]. Be sure not to cluster all citations at the end; instead, include them in the corresponding parts of the answer.
When responding, please keep the following points in mind:
- Today is {cur_date}.
- Not all content in the search results is closely related to the user's question. You need to evaluate and filter the search results based on the question.
- For listing-type questions (e.g., listing all flight information), try to limit the answer to 10 key points and inform the user that they can refer to the search sources for complete information. Prioritize providing the most complete and relevant items in the list. Avoid mentioning content not provided in the search results unless necessary.
- For creative tasks (e.g., writing an essay), ensure that references are cited within the body of the text, such as [citation:3][citation:5], rather than only at the end of the text. You need to interpret and summarize the user's requirements, choose an appropriate format, fully utilize the search results, extract key information, and generate an answer that is insightful, creative, and professional. Extend the length of your response as much as possible, addressing each point in detail and from multiple perspectives, ensuring the content is rich and thorough.
- If the response is lengthy, structure it well and summarize it in paragraphs. If a point-by-point format is needed, try to limit it to 5 points and merge related content.
- For objective Q&A, if the answer is very brief, you may add one or two related sentences to enrich the content.
- Choose an appropriate and visually appealing format for your response based on the user's requirements and the content of the answer, ensuring strong readability.
- Your answer should synthesize information from multiple relevant webpages and avoid repeatedly citing the same webpage.
- Unless the user requests otherwise, your response should be in the same language as the user's question.

# The user's message is:
{question}'''
```

## 7. ライセンス
このコードリポジトリおよびモデルウェイトは、[MIT License](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE) のもとでライセンスされています。
DeepSeek-R1シリーズは商用利用をサポートし、他のLLMの蒸留など、あらゆる修正や派生的な利用が可能です。ご注意ください：
- DeepSeek-R1-Distill-Qwen-1.5B、DeepSeek-R1-Distill-Qwen-7B、DeepSeek-R1-Distill-Qwen-14B、DeepSeek-R1-Distill-Qwen-32B は [Qwen-2.5 series](https://github.com/QwenLM/Qwen2.5) に由来し、元は [Apache 2.0 License](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE) でライセンスされ、DeepSeek-R1 により精選された 80 万サンプルでファインチューニングされています。
- DeepSeek-R1-Distill-Llama-8B は Llama3.1-8B-Base に由来し、元は [Llama3.1 license](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE) でライセンスされています。
- DeepSeek-R1-Distill-Llama-70B は Llama3.3-70B-Instruct に由来し、元は [Llama3.3 license](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE) でライセンスされています。

## 8. 引用
```bibtex
@misc{deepseekai2025deepseekr1incentivizingreasoningcapability,
      title={DeepSeek-R1: Incentivizing Reasoning Capability in LLMs via Reinforcement Learning}, 
      author={DeepSeek-AI},
      year={2025},
      eprint={2501.12948},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2501.12948}, 
}
```

## 9. お問い合わせ
ご質問がある場合は、Issueを立てるか [service@deepseek.com](mailto:service@deepseek.com) までご連絡ください。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---