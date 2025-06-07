![Banner image](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - 為技術團隊打造的安全工作流程自動化

n8n 是一個工作流程自動化平台，為技術團隊提供了結合程式碼彈性與無程式碼速度的解決方案。擁有 400+ 種整合、原生 AI 能力，以及公平授權（fair-code）協議，n8n 讓你在完全掌控資料與部署的同時，打造強大的自動化流程。

![n8n.io - Screenshot](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## 主要功能

- **需要時可寫程式碼**：可撰寫 JavaScript/Python、加入 npm 套件，或使用視覺化介面
- **AI 原生平台**：以 LangChain 為基礎，結合你自己的資料與模型，打造 AI 代理人工作流程
- **完全掌控**：可依公平授權自架，或使用我們的 [雲端服務](https://app.n8n.cloud/login)
- **企業級準備**：進階權限、SSO、隔離部署
- **活躍社群**：400+ 整合與 900+ 即用型 [範本](https://n8n.io/workflows)

## 快速開始

立即透過 [npx](https://docs.n8n.io/hosting/installation/npm/) 試用 n8n（需先安裝 [Node.js](https://nodejs.org/en/)）：

```
npx n8n
```

或用 [Docker](https://docs.n8n.io/hosting/installation/docker/) 部署：

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

透過瀏覽器存取 http://localhost:5678 編輯器

## 資源

- 📚 [文件](https://docs.n8n.io)
- 🔧 [400+ 整合](https://n8n.io/integrations)
- 💡 [範例工作流程](https://n8n.io/workflows)
- 🤖 [AI 與 LangChain 指南](https://docs.n8n.io/langchain/)
- 👥 [社群論壇](https://community.n8n.io)
- 📖 [社群教學](https://community.n8n.io/c/tutorials/28)

## 支援

需要協助嗎？我們的社群論壇是獲得支援並與其他使用者交流的最佳場所：
[community.n8n.io](https://community.n8n.io)

## 授權

n8n 採用 [fair-code](https://faircode.io) 授權，並依 [Sustainable Use License](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) 及 [n8n Enterprise License](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md) 發布。

- **原始碼可見**：始終可檢視原始碼
- **可自行部署**：可在任何地方部署
- **可擴充**：可新增自訂節點與功能

如需額外功能與支援，歡迎洽詢 [企業授權](mailto:license@n8n.io)。

關於授權模式的更多資訊，請參閱 [文件](https://docs.n8n.io/reference/license/)。

## 貢獻

發現 bug 🐛 或有新功能想法 ✨？請參考我們的 [貢獻指南](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md) 開始參與。

## 加入團隊

想要一同引領自動化的未來？歡迎瀏覽我們的 [職缺](https://n8n.io/careers) 並加入我們的團隊！

## n8n 是什麼意思？

**簡短答案：** 代表 "nodemation"，發音為 n-eight-n。

**完整說明：** 「這個問題我經常被問到（比我預期的還要頻繁），所以我決定在這裡做個說明。在為這個專案尋找一個好名字並希望有可用的網域時，我很快發現所有我能想到的好名字都已經被註冊了。最後我選擇了 nodemation。‘node-’ 是指它使用 Node-View，也使用 Node.js，而 ‘-mation’ 則來自 ‘automation’，這正是這個專案要解決的問題。不過，我不喜歡這個名字太長，也無法想像每次在 CLI 輸入這麼長的名稱。於是我最終選擇了 ‘n8n’。」- **Jan Oberhauser，n8n.io 創辦人暨執行長**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---