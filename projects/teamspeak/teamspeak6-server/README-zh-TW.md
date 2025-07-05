# TeamSpeak 6 Server - Beta Release README

歡迎使用 TeamSpeak 6 Server 的 Beta 版本！我們很高興您加入我們，一同探索新一代的 TeamSpeak。本文件將引導您開始使用，並說明本次 Beta 版本的重要細節。

由於這是 Beta 版本，部分功能仍在開發中，您可能會遇到錯誤。您的回饋對我們至關重要，將協助我們打造更穩定、完整的最終版本。

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;關於 TeamSpeak</h2>

經過近 25 年的測試與驗證，我們有一個適合每個人需求的解決方案。TeamSpeak 提供理想的語音通訊，適用於遊戲、教育與訓練、企業內部溝通，以及與親友保持聯繫。我們的主要目標是提供易於使用、高安全標準、卓越語音品質，並且系統與頻寬佔用低的解決方案。

## ℹ️ Beta 狀態與已知問題
**這是一個 Beta 版本，主要目的是收集多元回饋並在正式版推出前找出潛在問題。**

**自架伺服器檔案：** TeamSpeak 6 的專用伺服器軟體仍在積極開發中，尚未完全具備所有功能。我們致力於為自架伺服器提供完整的 TS6 體驗。

**功能不穩定性：** 部分新功能可能尚不穩定，或在我們持續優化過程中有所變動。

**回饋至關重要：** 您的使用經驗非常寶貴，您的意見對我們至關重要。請在我們的 [社群論壇](https://community.teamspeak.com/c/teamspeak-6-server/45) 或 [GitHub](https://github.com/teamspeak/teamspeak6-server/issues) 直接回報問題或提供建議。

**限制事項：** 請注意，**TeamSpeak 3 伺服器授權無法與 TeamSpeak 6 伺服器相容**，目前兩個版本之間**尚無遷移路徑**。

**預覽授權：** 為回應您的回饋，伺服器現在提供**臨時**的 32 人數預覽授權，讓您在評估期間有更大的彈性。請注意，此授權**僅有效兩個月**。

此外，目前**尚無法取得或升級更大型的 TeamSpeak 6 授權**。

感謝您的耐心與理解，我們將持續努力，未來提供更完善的支援解決方案。

## 👇 TS6 快速開始
若要開始使用 TeamSpeak 6 用戶端，請前往我們的 [下載頁面](https://teamspeak.com/en/downloads/)。

有關自架伺服器的資訊，請參閱下方簡要指南。欲獲得最新消息、公告，或與 TeamSpeak 社群互動，請務必瀏覽我們的 [社群論壇](https://community.teamspeak.com/)，並關注我們的 [Twitter](https://x.com/teamspeak)。

不想自架，或只想用更簡單的方式開始使用 TeamSpeak 6？您可直接透過我們於 [TeamSpeak Communities](https://www.myteamspeak.com/communities) 租用可靠且官方的 TeamSpeak 6 伺服器。

## ⚙️ 設定
### 您可以透過三種主要方式設定您的伺服器：

1. **命令列參數**：啟動伺服器時直接傳入選項（例如：./tsserver --default-voice-port 9987）。適合臨時變更或腳本化使用。

2. **環境變數：** 在啟動伺服器前設定環境變數。適用於 Docker 或避免命令列混亂時。

3. **YAML 設定檔：** 若需持久性設定，強烈建議使用 tsserver.yaml 檔案。可使用 --write-config-file 旗標產生預設設定檔。

您可以控管的主要設定包含網路連接埠（語音、檔案傳輸）、資料庫連線（支援 SQLite 與 MariaDB）、IP 綁定及日誌選項。

如需完整選項列表，請以 `--help` 旗標執行伺服器，或參閱 [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md)。

### 使用二進位檔啟動伺服器
若不使用 Docker，您可以直接在作業系統上運行伺服器。

<h2><img width="22" src="/icons/linux.svg">&nbsp;在 Linux 上：</h2>

將伺服器二進位檔設為可執行：
```sh
chmod +x tsserver
```

從終端機運行伺服器，並確保接受授權條款：

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;在 Windows 上：</h2>

開啟命令提示字元或 PowerShell，並切換至解壓縮後的伺服器檔案目錄。

執行伺服器主程式，並確保接受授權條款：
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;使用 Docker 執行伺服器（推薦）：</h2>
Docker 是在隔離且易於管理的環境中運行 TeamSpeak 6 伺服器的最簡單方式。

### 1. 簡單的 docker run 指令：

若要快速啟動，可以使用 docker run 指令。

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. 使用 docker-compose.yaml（適用於長期運行）：
若您打算長期運行伺服器，這是最佳做法。建立 docker-compose.yaml 檔案：

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # 語音連接埠
      - "30033:30033/tcp" # 檔案傳輸
      # - "10080:10080/tcp" # Web 查詢
    environment:
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 有用連結
[官方網站](https://teamspeak.com/en/)<br>
[社群論壇](https://community.teamspeak.com)<br>
[GitHub 問題回報](https://github.com/teamspeak/teamspeak6-server/issues)<br>

您的參與與回饋將幫助我們塑造 TeamSpeak 的未來！💙<br>
感謝您成為 TeamSpeak 6 Beta 計畫的一份子，並為其發展作出貢獻！🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---