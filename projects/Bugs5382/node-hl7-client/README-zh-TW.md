# Node HL7 Client

> 一個純 TypeScript 的 HL7 客戶端，讓 Node.js 能與 HL7 伺服器無縫通訊。

`node-hl7-client` 是一個輕量、無依賴的函式庫，專為與 HL7 中介/伺服器進行高效能通訊而打造。它支援傳送格式正確的 HL7 訊息、處理回應，以及同時處理單一與批次 HL7 訊息格式（MSH、BHS 和 FHS）。

## ✨ 特色

* ⚡ **零外部依賴** – 超高速效能，無多餘負擔。
* 🔁 **自動重連與重試** – 自動處理連線中斷。
* 🧠 **TypeScript + 型別定義** – 完整型別化，適合現代開發環境。
* 🤝 **搭配套件可用** – 可與 [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) 一同使用，實現完整 HL7 解決方案。
* 💻 **跨平台支援** – 適用於 Windows、macOS 和 Linux。
* 🧭 **標準導向** – 型別建構器確保 MSH、BHS 及 FHS 段落皆遵循 HL7.org 規範。

## 📦 安裝

```bash
npm install node-hl7-client
```

## 📚 內容包含？

* **HL7 客戶端** – 連接至遠端 HL7 伺服器，傳送訊息並處理回應。
* **HL7 解析器** – 將原始 HL7 訊息字串解析為可存取的段落。
* **HL7 建構器** – 建構有效的 HL7 訊息、批次或完整 HL7 批次檔案。

## 🧾 目錄

1. [關鍵詞定義](#keyword-definitions)
2. [文件](#documentation)
3. [致謝](#acknowledgements)
4. [授權](#license)

## 關鍵詞定義

此 NPM 套件旨在支援對病患照護和診斷有潛在影響的醫療應用。本文件及其配套套件 [node-hl7-server](https://www.npmjs.com/package/node-hl7-server) 為了清晰性與互通性，採用下列標準化定義：

如 **「MUST」**、**「MUST NOT」**、**「REQUIRED」**、**「SHALL」**、**「SHALL NOT」**、**「SHOULD」**、**「SHOULD NOT」**、**「RECOMMENDED」**、**「MAY」** 及 **「OPTIONAL」** 等關鍵詞在本文檔中均一致使用。即使這些詞語未大寫，仍保有其原有含義。

* **MUST** – 此詞或 **「REQUIRED」**、**「SHALL」** 表示規範的絕對要求。
* **MUST NOT** – 此詞語或 **「SHALL NOT」** 表示規範的絕對禁止。
* **SHOULD** – 此詞或 **「RECOMMENDED」** 形容詞，表示在特定情況下可能有充分理由忽略某項目，但必須充分理解並仔細權衡其全部影響後方可這麼做。
* **SHOULD NOT** – 此詞語或 **「NOT RECOMMENDED」**，表示在特定情況下此行為可能是可接受甚至有用的。實施前應充分理解其全部影響並仔細權衡。
* **MAY** – 此詞或 **「OPTIONAL」** 形容詞，表示該項目為真正的選擇性項目。不包含特定選項的實作仍**必須**能與包含該選項的實作互通（但功能可能較少）。同樣地，包含某選項的實作也**必須**能與未包含該選項的互通（當然，除了該選項所提供的特定功能外）。

## 📖 文件

完整 API 文件、使用範例及進階設定，請參閱專案網站：
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 致謝

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – 連線邏輯靈感來源。
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – 解析器與建構器設計參考。
* 我的妻子和女兒 —— 感謝她們的愛、耐心與啟發。

## 📄 授權

MIT © [LICENSE](https://raw.githubusercontent.com/Bugs5382/node-hl7-client/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---