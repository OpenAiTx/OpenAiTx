
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

一個容器化的 Node.js 應用程式，可從 **Last.fm** 同步 scrobbles，將其儲存於本地 **SQLite** 資料庫，並提供網頁儀表板服務。

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## 專案

**Your LastFM** 是一個設計用於**自動同步 Last.fm 音樂 scrobble**的 Node.js 應用程式。它將您的收聽歷史保存於本地 SQLite 資料庫，並提供網頁介面以進行資料視覺化。

該專案完全以 **Docker** 容器化，使用自動入口點來處理資料庫初始化及序列執行（先同步，後啟動 Web API）。容器內同時採用 **PM2** 作為程序管理員，確保網路服務持續運作且具備彈性。

## 功能
### 互動式網頁儀表板

- 乾淨且現代化的網頁介面，視覺化您的音樂活動。

### Last.fm Scrobble 自動同步

- 定期從 Last.fm 擷取並儲存您的收聽歷史（scrobble）。
- 保證您的資料隨時保持最新，無需手動操作。

### 本地音樂歷史資料庫

- 所有 scrobble 都儲存在本地 SQLite 資料庫。
- 提供快速查詢及離線存取歷史收聽資料。

### 最近 Scrobble 檢視

- 顯示您最近收聽的曲目。
- 具備智慧圖片備援邏輯，適用於曲目、專輯和藝人。

### 朋友比較（相容性檢視）

- 與 Last.fm 朋友比較您的音樂品味。
- 顯示相容性等級（極低 → 超高）。
- 展示共同的熱門藝人、專輯及曲目。
- 根據真實收聽資料計算並標準化相容性。

### 可分享音樂卡片

- 根據您的收聽資料生成動態圖片。
- 為動態貼文及 instagram 限時動態（9:16）優化版面設計。

- 使用 node-canvas 進行伺服器端圖像渲染。

## 先決條件

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## 安裝

### 建立 `.env` 檔案

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm：請在[此處](https://www.last.fm/api/account/create)建立 API 帳戶以取得您的 API 金鑰。

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```
在終端機上：
`docker compose up -d`

然後訪問：

```
http://localhost:1533
```
（或將 `localhost` 替換為您的伺服器 IP）

## 授權條款

本專案採用 MIT 授權條款。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---