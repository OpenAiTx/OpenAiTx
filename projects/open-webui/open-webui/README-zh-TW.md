# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI 是一個[可擴展](https://docs.openwebui.com/features/plugin/)、功能豐富且用戶友善的自架 AI 平台，設計用於完全離線運作。** 它支援多種 LLM 執行器，例如 **Ollama** 和 **相容 OpenAI 的 API**，並內建 RAG 推論引擎，使其成為一個**強大的 AI 部署解決方案**。

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **正在尋找[企業方案](https://docs.openwebui.com/enterprise)？** – **[立即聯繫我們的銷售團隊！](mailto:sales@openwebui.com)**
>
> 獲得**增強功能**，包括**自訂主題與品牌**、**服務級協議（SLA）支援**、**長期支援（LTS）版本**等更多功能！

欲瞭解更多資訊，請務必參閱我們的 [Open WebUI 文件](https://docs.openwebui.com/)。

## Open WebUI 主要特點 ⭐

- 🚀 **輕鬆安裝**：使用 Docker 或 Kubernetes（kubectl、kustomize 或 helm）無縫安裝，支援 `:ollama` 與 `:cuda` 標記映像，安裝過程無煩惱。

- 🤝 **Ollama/OpenAI API 整合**：無縫整合相容 OpenAI 的 API，讓 Ollama 模型與多種聊天體驗共存。可自訂 OpenAI API URL，連結至 **LMStudio、GroqCloud、Mistral、OpenRouter 等**。

- 🛡️ **細緻權限與用戶群組**：管理員可建立詳細的用戶角色與權限，確保安全的用戶環境。這種細緻劃分不僅提升安全性，也能打造客製化的用戶體驗，增強用戶的歸屬感與責任感。

- 📱 **響應式設計**：在桌上型電腦、筆電與行動裝置上皆有無縫體驗。

- 📱 **行動裝置專屬 PWA**：透過 PWA，在行動裝置上享有接近原生應用的體驗，於本地主機提供離線存取及流暢介面。

- ✒️🔢 **完整 Markdown 與 LaTeX 支援**：全方位的 Markdown 與 LaTeX 功能，提升 LLM 的互動體驗。

- 🎤📹 **免持語音/視訊通話**：內建免持語音與視訊通話，讓聊天更具動態與互動性。

- 🛠️ **模型建構器**：可直接透過 Web UI 建立 Ollama 模型。新增自訂角色/代理、調整聊天元素，並透過 [Open WebUI 社群](https://openwebui.com/) 整合輕鬆匯入模型。

- 🐍 **原生 Python 函式調用工具**：於工具工作區內支援內建程式碼編輯器，只需新增純 Python 函式即可 BYOF（自帶函式），無縫整合 LLM 與自訂程式碼。

- 📚 **本地 RAG 整合**：率先支援檢索增強生成（RAG），將文件互動無縫整合進聊天體驗。可將文件直接載入聊天或加入文件庫，使用 `#` 指令即可存取。

- 🔍 **RAG 網路搜尋**：支援 `SearXNG`、`Google PSE`、`Brave Search`、`serpstack`、`serper`、`Serply`、`DuckDuckGo`、`TavilySearch`、`SearchApi` 及 `Bing` 等搜尋引擎，直接將搜尋結果注入聊天。

- 🌐 **網頁瀏覽功能**：於聊天中使用 `#` 指令加上網址，將網站內容無縫納入對話，豐富互動層次。

- 🎨 **圖像生成整合**：可選擇 AUTOMATIC1111 API、ComfyUI（本地）、OpenAI 的 DALL-E（外部）等工具，為聊天體驗增添動態視覺內容。

- ⚙️ **多模型同時對話**：同時與多個模型互動，發揮各自優勢，獲得最佳回應。可並行運用多組模型提升體驗。

- 🔐 **基於角色的存取控制（RBAC）**：確保存取安全，僅授權人員能存取 Ollama，只有管理員擁有模型建立/拉取權限。

- 🌐🌍 **多語言支援**：支援國際化（i18n），可用偏好語言體驗 Open WebUI。歡迎參與翻譯，持續徵求貢獻者！

- 🧩 **Pipelines、Open WebUI 外掛支援**：利用 [Pipelines Plugin Framework](https://github.com/open-webui/pipelines) 整合自訂邏輯與 Python 函式庫。啟動 Pipelines 實例，將 OpenAI URL 設為 Pipelines URL，開啟無限可能。[範例](https://github.com/open-webui/pipelines/tree/main/examples) 包含 **函式調用**、用戶 **速率限制**、**使用監控**（如 Langfuse）、**LibreTranslate 實時翻譯**、**有害訊息過濾**等多項功能。

- 🌟 **持續更新**：我們承諾定期為 Open WebUI 提供更新、修正及新功能。

想更深入了解 Open WebUI 的功能嗎？請參考我們的 [Open WebUI 文件](https://docs.openwebui.com/features) 以獲取完整介紹！

## 贊助商 🙌

#### 綠寶石級

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • 你的介面有後端了嗎？<br>試試 <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • 開發者的智慧終端機
    </td>
  </tr>
</table>

---

我們非常感謝贊助商的慷慨支持。他們的貢獻幫助我們維護並改進專案，確保能持續為社群提供高品質成果。謝謝！

## 安裝方式 🚀

### 透過 Python pip 安裝 🐍

可使用 Python 套件管理器 pip 安裝 Open WebUI。安裝前請確保使用 **Python 3.11** 以避免相容性問題。

1. **安裝 Open WebUI**：
   開啟終端機並執行以下指令安裝：

   ```bash
   pip install open-webui
   ```

2. **啟動 Open WebUI**：
   安裝完成後，執行以下指令啟動：

   ```bash
   open-webui serve
   ```

這將啟動 Open WebUI 伺服器，您可於 [http://localhost:8080](http://localhost:8080) 存取。

### 使用 Docker 快速啟動 🐳

> [!NOTE]  
> 某些 Docker 環境可能需額外設定。若遇連線問題，請參閱我們的 [Open WebUI 文件](https://docs.openwebui.com/)。

> [!WARNING]
> 使用 Docker 安裝 Open WebUI 時，請務必在指令中加入 `-v open-webui:/app/backend/data`。此步驟能確保資料庫正確掛載，避免資料遺失。

> [!TIP]  
> 若需包含 Ollama 或啟用 CUDA 加速，建議使用官方標記為 `:cuda` 或 `:ollama` 的映像。啟用 CUDA 前請於 Linux/WSL 系統安裝 [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/)。

### 預設設定安裝

- **若 Ollama 在本機**，請使用下列指令：

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **若 Ollama 在其他伺服器**，請使用下列指令：

  若需連接其他伺服器上的 Ollama，請將 `OLLAMA_BASE_URL` 改為該伺服器 URL：

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **若需 Nvidia GPU 支援**，請使用下列指令：

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### 僅使用 OpenAI API 的安裝方式

- **若僅使用 OpenAI API**，請使用下列指令：

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### 安裝包含 Ollama 的 Open WebUI

此方法使用單一容器映像，將 Open WebUI 與 Ollama 打包，僅需一行指令即可安裝。請依照硬體選擇適合的指令：

- **支援 GPU**：
  若需運用 GPU 資源，請執行下列指令：

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **僅用 CPU**：
  若無 GPU，請改用下列指令：

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

兩種指令皆可一併安裝 Open WebUI 與 Ollama，輕鬆快速完成設定。

安裝完成後，您可於 [http://localhost:3000](http://localhost:3000) 存取 Open WebUI。祝您使用愉快！😄

### 其他安裝方式

我們也提供多種安裝選擇，包括非 Docker 原生安裝、Docker Compose、Kustomize 及 Helm。請參閱 [Open WebUI 文件](https://docs.openwebui.com/getting-started/) 或加入 [Discord 社群](https://discord.gg/5rJgQTnV4s) 取得完整指引。

### 疑難排解

遇到連線問題嗎？請參閱 [Open WebUI 文件](https://docs.openwebui.com/troubleshooting/)。如需更多協助及參與熱絡社群，歡迎前往 [Open WebUI Discord](https://discord.gg/5rJgQTnV4s)。

#### Open WebUI：伺服器連線錯誤

若遇連線問題，常見原因為 WebUI Docker 容器無法連接至容器內的 Ollama 伺服器（127.0.0.1:11434 或 host.docker.internal:11434）。請於 docker 指令中加入 `--network=host` 參數解決。需注意此時埠號將由 3000 改為 8080，連結為：`http://localhost:8080`。

**範例 Docker 指令**：

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### 保持 Docker 安裝為最新版本

若欲升級本地 Docker 安裝版本，可使用 [Watchtower](https://containrrr.dev/watchtower/)：

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

如有更改容器名稱，請將指令最後的 `open-webui` 替換為您的容器名稱。

請參考我們的升級指南：[Open WebUI 文件](https://docs.openwebui.com/getting-started/updating)。

### 使用 Dev 開發分支 🌙

> [!WARNING]
> `:dev` 分支包含最新但尚未穩定的功能及變更，使用時請自行承擔風險，可能會有 bug 或功能不完整。

若想嘗鮮最新功能且可接受偶爾不穩定，可用 `:dev` 標記啟動：

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### 離線模式

若在離線環境運行 Open WebUI，可設定環境變數 `HF_HUB_OFFLINE` 為 `1`，避免從網路下載模型。

```bash
export HF_HUB_OFFLINE=1
```

## 接下來？🌟

探索即將推出的功能，請見 [Open WebUI 路線圖](https://docs.openwebui.com/roadmap/)。

## 授權 📜

本專案採用 [Open WebUI License](LICENSE)，即 BSD-3-Clause 修正版授權。您將獲得與經典 BSD-3 授權相同的權利：可自由使用、修改、發行（包括專有與商業產品），僅有極少的限制。唯一額外要求是保留「Open WebUI」品牌標示，詳見 LICENSE 檔案。完整條款請參閱 [LICENSE](LICENSE) 文件。📄

## 支援 💬

如有任何問題、建議或需協助，請開啟 issue 或加入我們的
[Open WebUI Discord 社群](https://discord.gg/5rJgQTnV4s) 與我們聯繫！🤝

## 星標歷史

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

由 [Timothy Jaeryang Baek](https://github.com/tjbck) 建立——讓我們一起讓 Open WebUI 更加精彩！💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---