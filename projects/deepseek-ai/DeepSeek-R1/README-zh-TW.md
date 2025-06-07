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

## 1. 簡介

我們推出了首代推理模型 DeepSeek-R1-Zero 及 DeepSeek-R1。
DeepSeek-R1-Zero 是一個透過大規模強化學習（RL）訓練、且未經監督微調（SFT）作為前置步驟的模型，在推理任務上展現了卓越的表現。
藉由 RL，DeepSeek-R1-Zero 自然湧現出眾多強大且有趣的推理行為。
然而，DeepSeek-R1-Zero 也面臨無窮重複、可讀性差、語言混用等挑戰。為解決這些問題並進一步提升推理表現，
我們引入了在 RL 前加入冷啟動資料的 DeepSeek-R1。
DeepSeek-R1 在數學、程式碼和推理任務上達到與 OpenAI-o1 相當的表現。
為支持研究社群，我們開源了 DeepSeek-R1-Zero、DeepSeek-R1，以及六個基於 Llama 和 Qwen、由 DeepSeek-R1 蒸餾而來的稠密模型。DeepSeek-R1-Distill-Qwen-32B 在多項基準測試中超越了 OpenAI-o1-mini，創下稠密模型的新紀錄。

**注意：在本地運行 DeepSeek-R1 系列模型前，建議先閱讀 [使用建議](#usage-recommendations) 章節。**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. 模型總結

---

**後訓練：於基礎模型上進行大規模強化學習**

-  我們直接在基礎模型上應用強化學習（RL），不依賴監督微調（SFT）作為前置步驟。此方法讓模型能探索解決複雜問題的思維鏈（CoT），最終發展出 DeepSeek-R1-Zero。DeepSeek-R1-Zero 展現了自我驗證、反思和生成長思維鏈等能力，為研究社群樹立了重要里程碑。值得注意的是，這是首個驗證 LLM 推理能力可僅靠 RL 激勵、無需 SFT 的開源研究。此突破為未來的進展鋪平了道路。

-   我們提出了開發 DeepSeek-R1 的訓練流程。該流程包含兩階段的 RL，用於發掘更優的推理模式並對齊人類偏好，以及兩階段的 SFT，作為模型推理與非推理能力的種子。
    我們相信此流程將為產業帶來更優模型。

---

**蒸餾：小模型也能很強大**

-  我們證明大型模型的推理模式可以蒸餾到小型模型中，且表現優於直接以 RL 訓練的小模型推理模式。開源的 DeepSeek-R1 及其 API，將有助於研究社群未來蒸餾出更優的小模型。
- 利用 DeepSeek-R1 生成的推理資料，我們微調了多個廣泛用於研究社群的稠密模型。評估結果顯示，蒸餾後的小型稠密模型在基準測試上表現極佳。我們基於 Qwen2.5 與 Llama3 系列，向社群開源蒸餾後的 1.5B、7B、8B、14B、32B、70B 權重檔案。

## 3. 模型下載

### DeepSeek-R1 模型

<div align="center">

| **模型** | **參數總數** | **激活參數數** | **上下文長度** | **下載連結** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero 與 DeepSeek-R1 均基於 DeepSeek-V3-Base 訓練。
有關模型架構的更多資訊，請參閱 [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) 儲存庫。

### DeepSeek-R1-Distill 蒸餾模型

<div align="center">

| **模型** | **基礎模型** | **下載連結** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

DeepSeek-R1-Distill 模型是基於開源模型，利用 DeepSeek-R1 產生的資料微調而成。
我們對其 config 與 tokenizer 做了微調。請務必使用我們的設置來運行這些模型。

## 4. 評測結果

### DeepSeek-R1-評測

對所有模型，最大生成長度設為 32,768 tokens。對於需要取樣的基準測試，我們溫度設為 $0.6$，top-p 設為 $0.95$，每個查詢生成 64 個回應以估算 pass@1。
<div align="center">


| 類別 | 基準（指標） | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | 架構 | - | - | MoE | - | - | MoE |
| | 啟用參數 | - | - | 37B | - | - | 37B |
| | 參數總數 | - | - | 671B | - | - | 671B |
| 英文 | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
| | MMLU-Redux (EM) | 88.9 | 88.0 | 89.1 | 86.7 | - | **92.9** |
| | MMLU-Pro (EM) | 78.0 | 72.6 | 75.9 | 80.3 | - | **84.0** |
| | DROP (3-shot F1) | 88.3 | 83.7 | 91.6 | 83.9 | 90.2 | **92.2** |
| | IF-Eval (Prompt Strict) | **86.5** | 84.3 | 86.1 | 84.8 | - | 83.3 |
| | GPQA-Diamond (Pass@1) | 65.0 | 49.9 | 59.1 | 60.0 | **75.7** | 71.5 |
| | SimpleQA (Correct) | 28.4 | 38.2 | 24.9 | 7.0 | **47.0** | 30.1 |
| | FRAMES (Acc.) | 72.5 | 80.5 | 73.3 | 76.9 | - | **82.5** |
| | AlpacaEval2.0 (LC-winrate) | 52.0 | 51.1 | 70.0 | 57.8 | - | **87.6** |
| | ArenaHard (GPT-4-1106) | 85.2 | 80.4 | 85.5 | 92.0 | - | **92.3** |
| 程式 | LiveCodeBench (Pass@1-COT) | 33.8 | 34.2 | - | 53.8 | 63.4 | **65.9** |
| | Codeforces (Percentile) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Resolved) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| 數學 | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| 中文 | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### 蒸餾模型評測


<div align="center">

| 模型                                    | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
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


## 5. 聊天網站與 API 平台

你可以在 DeepSeek 官方網站 [chat.deepseek.com](https://chat.deepseek.com) 與 DeepSeek-R1 聊天，並開啟「DeepThink」按鈕。

我們也在 DeepSeek 平台提供 OpenAI 相容的 API：[platform.deepseek.com](https://platform.deepseek.com/)

## 6. 本地運行方式

### DeepSeek-R1 模型

請參考 [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) 倉庫獲取更多本地運行 DeepSeek-R1 的資訊。

**注意：目前尚未直接支援 Hugging Face 的 Transformers。**

### DeepSeek-R1-Distill 蒸餾模型

DeepSeek-R1-Distill 蒸餾模型可與 Qwen 或 Llama 模型一樣使用。

例如，你可以使用 [vLLM](https://github.com/vllm-project/vllm) 輕鬆啟動服務：

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

你也可以使用 [SGLang](https://github.com/sgl-project/sglang) 啟動服務：

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### 使用建議

**建議在使用 DeepSeek-R1 系列模型（包括評測）時，遵循以下配置以獲得預期表現：**

1. 溫度設定於 0.5-0.7 範圍（建議 0.6），以避免無窮重複或不連貫的輸出。
2. **請勿新增 system prompt，所有指令皆應包含於 user prompt 內。**
3. 對於數學問題，建議在提示中加入：「請逐步推理，並將最終答案放於 \boxed{} 中。」
4. 評估模型表現時，建議多次測試並取平均值。

此外，我們觀察到 DeepSeek-R1 系列模型在回應部分查詢時，可能會跳過思考模式（即輸出 "\<think\>\n\n\</think\>"），這會影響模型表現。
**為確保模型充分推理，建議強制要求模型於每次輸出開頭以 "\<think\>\n" 起始。**

### 官方提示詞（Prompts）

在官方 DeepSeek 網頁/應用中，我們不使用 system prompt，而是針對檔案上傳與網路搜尋設計了兩個專用提示詞，以提升用戶體驗。此外，網頁/應用中的溫度設為 0.6。

對於檔案上傳，請依據下列模板建立提示詞，其中 {file_name}、{file_content} 和 {question} 為參數：
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

對於網路搜尋，{search_results}、{cur_date} 及 {question} 為參數。

中文查詢使用下列提示詞：
```
search_answer_zh_template = \
'''# 以下內容是基於用户發送的消息的搜索結果:
{search_results}
在我給你的搜索結果中，每個結果都是[webpage X begin]...[webpage X end]格式的，X代表每篇文章的數字索引。請在適當的情況下在句子末尾引用上下文。請按照引用編號[citation:X]的格式在答案中對應部分引用上下文。如果一句話源自多個上下文，請列出所有相關的引用編號，例如[citation:3][citation:5]，切記不要將引用集中在最後返回引用編號，而是在答案對應部分列出。
在回答時，請注意以下幾點：
- 今天是{cur_date}。
- 並非搜索結果的所有內容都與用戶的問題密切相關，你需要結合問題，對搜索結果進行甄別、篩選。
- 對於列舉類的問題（如列舉所有航班資訊），盡量將答案控制在10個要點以內，並告訴用戶可以查看搜索來源、獲得完整資訊。優先提供資訊完整、最相關的列舉項；如非必要，不要主動告訴用戶搜索結果未提供的內容。
- 對於創作類的問題（如寫論文），請務必在正文的段落中引用對應的參考編號，例如[citation:3][citation:5]，不能只在文章末尾引用。你需要解讀並概括用戶的題目要求，選擇合適的格式，充分利用搜索結果並抽取重要資訊，生成符合用戶要求、極具思想深度、富有創造力與專業性的答案。你的創作篇幅需要盡可能延長，對於每一個要點的論述要推測用戶的意圖，給出盡可能多角度的回答要點，且務必資訊量大、論述詳盡。
- 如果回答很長，請盡量結構化、分段落總結。如果需要分點作答，盡量控制在5個點以內，並合併相關的內容。
- 對於客觀類的問答，如果問題的答案非常簡短，可以適當補充一到兩句相關資訊，以豐富內容。
- 你需要根據用戶要求和回答內容選擇合適、美觀的回答格式，確保可讀性強。
- 你的回答應該綜合多個相關網頁來回答，不能重複引用一個網頁。
- 除非用戶要求，否則你回答的語言需要和用戶提問的語言保持一致。

# 用戶消息為：
{question}'''
```

英文查詢使用下列提示詞：
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

## 7. 授權

本程式碼倉庫及模型權重依 [MIT License](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE) 授權。
DeepSeek-R1 系列支持商業用途，允許任何修改與衍生作品，包括但不限於用於蒸餾訓練其他 LLM。請注意：
- DeepSeek-R1-Distill-Qwen-1.5B、DeepSeek-R1-Distill-Qwen-7B、DeepSeek-R1-Distill-Qwen-14B 與 DeepSeek-R1-Distill-Qwen-32B 均源自 [Qwen-2.5 系列](https://github.com/QwenLM/Qwen2.5)，原始授權為 [Apache 2.0 License](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE)，現以 DeepSeek-R1 精選的 80 萬條樣本微調。
- DeepSeek-R1-Distill-Llama-8B 源自 Llama3.1-8B-Base，原始授權為 [Llama3.1 license](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE)。
- DeepSeek-R1-Distill-Llama-70B 源自 Llama3.3-70B-Instruct，原始授權為 [Llama3.3 license](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE)。

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

## 9. 聯絡方式

如有任何問題，歡迎提交 issue 或聯繫我們：[service@deepseek.com](mailto:service@deepseek.com)。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---