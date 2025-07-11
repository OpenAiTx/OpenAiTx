# 🎫 BiliTickerStorm

## ⚙️ 服務說明

| 服務名稱              | 說明                   | 備註      |
| ----------------- | -------------------- | ------- |
| `ticket-master`   | 主控服務，負責調度任務         | 單實例部署  |
| `ticket-worker`   | 搶票 worker，可橫向擴展       | 支援多實例  |
| `gt-python`       | 圖形驗證碼處理服務            | 單實例部署  |

---

## 🚀 快速部署步驟

> 集群搭建可參考 [集群搭建指南](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md)。

<details> <summary><strong>📦 遠端倉庫安裝（推薦）</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. 安裝 Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` 是搶票配置文件目錄，掛載給 `ticket-master` 容器用。搶票配置文件生成請使用 https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` 是 plusplus 推送配置，設置後可以接收搶票結果通知。
> - `ticketWorker.ticketInterval` 是搶票間隔秒數，預設 300 毫秒。
> - `ticketWorker.ticketTimeStart` 是定時啟動時間，格式為 `2025-05-20T13:14`，不填預設為啟動容器即直接開始搶票。

### 3. 升級 Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 本地 Chart 安裝</strong></summary>


### 1. 安裝 Chart

```bash
# 克隆倉庫
git clone https://github.com/mikumifa/biliTickerStorm
# 使用本地 Chart 套件
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. 升級 Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 通用命令</strong></summary>

### ⏹ 卸載
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 免責聲明

本專案遵循 MIT License 授權協議，僅供個人學習與研究使用。請勿將本專案用於任何商業牟利行為，亦嚴禁用於任何形式的代搶、違法行為或違反相關平台規則的用途。由此產生的一切後果均由使用者自行承擔，與本人無關。

若您 fork 或使用本專案，請務必遵守相關法律法規與目標平台規則。

## 💡 關於訪問頻率與並發控制
本專案在設計時嚴格遵循「非侵入式」原則，避免對目標伺服器（如 Bilibili）造成任何干擾。

所有網路請求的時間間隔均由使用者自行配置，預設值模擬正常使用者的手動操作速度。程式預設單執行緒運行，無並發任務。遇到請求失敗時，程式會進行有限次數的重試，並在重試之間加入適當的延遲，避免形成高頻打點。專案完全依賴平台公開介面及網頁結構，不含風控規避、API 劫持等破壞性手段。

## 🛡️ 平台尊重聲明

本程式設計時已盡可能控制請求頻率，避免對 Bilibili 伺服器造成任何明顯負載或影響。專案僅作為學習用途，不具備大規模、高併發的能力，亦無任何惡意行為或干擾服務的企圖。

如本專案中存在侵犯 Bilibili 公司合法權益的內容，請通過郵箱 [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com) 與我聯繫，我將第一時間下架相關內容並刪除此倉庫。對此造成的不便，我深表歉意，感謝您的理解與包容。

## 📄 License

[MIT License](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---