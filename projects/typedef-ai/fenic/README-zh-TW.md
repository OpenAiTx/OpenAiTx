<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic：為 LLM 推理 (重新)打造的 dataframe

[![PyPI version](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Python versions](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![License](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **文件**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic 是來自 typedef.ai 的一款具有主見、受 PySpark 啟發的 DataFrame 框架，用於構建 AI 及代理型應用。利用增強語意智能的熟悉 DataFrame 操作，將非結構化與結構化資料轉化為洞見。對 markdown、逐字稿與語意運算子提供一流支援，並可高效進行跨任意模型供應商的批次推理。
## 安裝

fenic 支援 Python `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### LLM 供應商設置

fenic 需要至少一個 LLM 供應商的 API 金鑰。請為您選擇的供應商設置相應的環境變數：

```bash
# 對於 OpenAI
export OPENAI_API_KEY="your-openai-api-key"

# 對於 Anthropic
export ANTHROPIC_API_KEY="your-anthropic-api-key"

# 對於 Google
export GEMINI_API_KEY="your-google-api-key"
```

## 快速入門

學習 fenic 最快的方法是查看範例。

以下是此資料庫中的範例快速清單：

| 範例                                                                       | 說明                                                                                                                                |
| -------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                       | 透過錯誤日誌分析，介紹如何使用 fenic 的核心運算子進行語意萃取與分類。                                                              |
| [Enrichment](examples/enrichment)                                          | 以日誌增強為例，展示多階段 DataFrame、基於模板的文字萃取、表格聯結與 LLM 驅動的轉換。                                              |
| [Meeting Transcript Processing](examples/meeting_transcript_processing)    | 透過會議分析，展示原生逐字稿解析、Pydantic 結構整合與複雜彙總運算。                                                               |
| [News Analysis](examples/news_analysis)                                    | 使用語意運算子與結構化資料處理，分析並萃取新聞文章的見解。                                                                          |
| [Podcast Summarization](examples/podcast_summarization)                    | 以說話者為單位分析並萃取重點，處理與摘要 Podcast 逐字稿。                                                                           |
| [Semantic Join](examples/semantic_joins)                                   | 不只是模糊比對，使用 fenic 強大的語意聯結功能跨表比對資料。                                                                         |
| [Named Entity Recognition](examples/named_entity_recognition)              | 利用語意萃取與分類，從文本中擷取並分類命名實體。                                                                                    |
| [Markdown Processing](examples/markdown_processing)                        | 以結構化資料萃取與格式轉換來處理與轉換 Markdown 文件。                                                                              |
| [JSON Processing](examples/json_processing)                                | 透過語意操作與結構驗證處理複雜的 JSON 資料結構。                                                                                    |
| [Feedback Clustering](examples/feedback_clustering)                        | 透過語意相似性與分群操作，分組並分析回饋意見。                                                                                      |
| [Document Extraction](examples/document_extraction)                        | 使用語意運算子，從各種文件格式中萃取結構化資訊。                                                                                    |

（歡迎點擊上方任一範例，直接跳轉到其資料夾。）
## 為什麼使用 fenic？

fenic 是一個具有明確主張、受 PySpark 啟發的 DataFrame 框架，用於構建生產級 AI 與智能代理應用。

與為 LLMs 臨時修改的傳統數據工具不同，fenic 的查詢引擎從零開始設計，專為推理任務打造。

使用增強語意智能的熟悉 DataFrame 操作，將結構化與非結構化數據轉化為洞見。fenic 原生支援 markdown、逐字稿與語意運算子，並可在任意模型供應商之間高效批量推理。

fenic 將傳統數據管道的可靠性帶入 AI 工作負載。

### 主要特點

#### 專為 LLM 推理打造

- 查詢引擎從零設計，專為 AI 工作負載，非臨時拼湊
- API 調用自動批次優化
- 內建重試邏輯與速率限制
- 支援 token 計數與成本追蹤

#### 語意運算子為一等公民
- `semantic.analyze_sentiment` - 內建情感分析
- `semantic.classify` - 使用少量範例對文本進行分類
- `semantic.extract` - 以結構化資料模式轉換非結構化文本
- `semantic.group_by` - 依語意相似性分組資料
- `semantic.join` - 依語意合併資料框，而不僅僅是值
- `semantic.map` - 應用自然語言轉換
- `semantic.predicate` - 使用自然語言建立謂詞以篩選資料列
- `semantic.reduce` - 以LLM操作彙總分組資料

#### 原生非結構化資料支援

超越一般多模態資料類型（音訊、影像），針對以文本為主的工作負載創建專門類型：

- Markdown剖析與擷取作為一級資料類型
- 具備說話者與時間戳辨識的逐字稿處理（SRT、通用格式）
- 使用JQ表示式處理巢狀資料的JSON操作
- 可配置重疊的自動文本分段，適用於長文件

#### 生產等級基礎設施
- 多供應商支援（OpenAI、Anthropic、Gemini）
- 本地與雲端執行後端
- 全面性的錯誤處理與日誌記錄
- Pydantic 型別安全整合

#### 熟悉的 DataFrame API

- 相容於 PySpark 的操作
- 延遲評估與查詢最佳化
- 支援複雜查詢的 SQL
- 可無縫整合現有資料管道

### 為什麼在 LLM 與智能代理應用中使用 DataFrame？

AI 與智能代理應用本質上是管道與工作流程——這正是 DataFrame API 設計來處理的場景。fenic 不必重新發明資料轉換、過濾與聚合的模式，而是善用數十年來經過驗證的工程實踐。

#### 解耦式架構以實現更佳代理

fenic 在繁重的推論任務與即時代理互動之間建立明確分隔。將批次處理移出代理執行時環境後，您將獲得：

- 更可預期且具回應性的代理
- 透過批次 LLM 呼叫達到更佳資源利用率
- 將規劃／協調與執行做出更清楚的分離
#### 為所有工程師打造

DataFrame 不僅僅是為資料工作者設計的。其流暢且可組合的 API 設計讓任何工程師都能輕鬆上手：

- 自然串接操作：`df.filter(...).semantic.group_by(...)`
- 無縫混用命令式與宣告式風格
- 透過來自 pandas/PySpark 或 SQL 的熟悉模式快速上手

## 支援

歡迎加入我們的 [Discord 社群](https://discord.gg/GdqF3J7huR)，在那裡你可以與其他用戶交流、提問，並獲得有關 fenic 專案的協助。我們的社群非常歡迎新朋友加入！

如果你覺得 fenic 有幫助，請考慮在本倉庫頂部給我們一個 ⭐。你的支持有助於我們成長並為大家改進這個框架！

## 貢獻

我們歡迎各種形式的貢獻！無論你有興趣撰寫程式碼、改善文件、測試功能，或是提出新想法，你的幫助對我們都非常寶貴。

對於計劃提交程式碼更動的開發者，我們建議你先開一個 Issue 與我們討論你的想法，再建立 Pull Request。這有助於確保專案方向的一致性，並避免重複工作。

請參閱我們的[貢獻指南](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md)，以獲得有關開發流程和專案設置的詳細資訊。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---