<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve 標誌">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Docker 下載次數" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="GitHub 星標數" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="在 X（Twitter）上關注" />
  </a>
</p>

---
# 將任何裝置變成協作點歌機

**Jukebox** 讓你能夠與朋友即時建立共享音樂播放清單——無需安裝應用程式、無需登入、無廣告。只要創建一個盒子，分享連結，就能一起加入歌曲。非常適合派對、旅行或任何團體聚會！

- 🌐 **開源的 Spotify 協作播放清單替代方案**
- 🕵️ **無需帳號**：可匿名使用——無需註冊或電子郵件
- ✨ **分享連結，一起加歌**：每個人都能即時貢獻歌曲
- 🚀 **無需下載應用程式**：任何裝置皆可於瀏覽器使用
- 🎵 **YouTube 整合**：幾乎能即時搜尋並播放任何歌曲
- 📱 **行動裝置友善**：適用於手機、平板與桌上型電腦
- ⚖️ **公平排隊**：歌曲自動排序，確保每個人都有機會
- 🆓 **完全免費，無廣告**

---

## 立即試用

1. **建立 Jukebox**：造訪首頁並創建新盒子
2. **分享連結**：將邀請連結發送給朋友
3. **新增歌曲**：搜尋 YouTube 或手動加入歌曲
4. **播放音樂**：使用內建播放器一起串流音樂

---
## 功能特色

- 協作播放清單：可共同新增、排隊及播放歌曲
- 匿名使用：無需登入或帳號
- YouTube 搜尋與播放：存取龐大音樂庫
- 行動優先、響應式介面
- 開放原始碼（MIT 授權）
- 以 Docker 輕鬆部署

### Docker Compose 部署

啟動所有服務：

```bash
docker-compose up -d
```

更新映像檔後，無縫重新部署服務：

```bash
bash ./redeploy.sh
```
---

## 入門指南

### 先決條件

- Node.js 16+
- npm 或 yarn
- YouTube Data API v3 金鑰（可從 Google 免費取得）

### YouTube API 設定

1. 前往 [Google Cloud Console](https://console.cloud.google.com/)
2. 建立新專案或選擇現有專案
3. 啟用 **YouTube Data API v3**
4. 建立憑證（API 金鑰）
5. 複製您的 API 金鑰

### 安裝
```bash
# 複製儲存庫
git clone <your-repo-url>
cd jukebox

# 安裝伺服器端相依套件
cd server
yarn install

# 安裝前端相依套件
cd ../frontend
yarn install

# 設定環境變數
cd ../server
cp .env.example .env
# 編輯 .env 並新增你的 YouTube API 金鑰

# 執行資料庫遷移
```
yarn migrate

# 啟動開發伺服器
# 後端：
cd server
yarn dev
# Worker：
cd server
yarn dev:worker
# 前端（在新終端機中）：
cd frontend
yarn dev
```

---

## 授權條款

MIT

---
## 貢獻與反饋

- 在 [GitHub](https://github.com/skeptrunedev/jukebox) 上提交 issue 或 pull request
- 功能請求？請私訊 [@skeptrune 在 X (Twitter)](https://twitter.com/skeptrune)

---

## 更新日誌

請參閱 [更新日誌](https://jukebox.skeptrune.com#changelog) 以獲取最新的更新和功能。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---