
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> 簡單易用的自架狀態監控工具

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 線上示範

試試看。

示範伺服器（地點：新加坡）：[https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

使用者名稱：`demo`
密碼：`demodemo`

## ⭐ 功能特色

目前還需要更多功能，但目前有……

- 監控 HTTP(s) 的運作狀態
- 狀態與延遲圖表
- 透過 Discord 通知
- 60 秒間隔
- 華麗、即時且快速的 UI/UX
- 支援多個狀態頁面
- 可將狀態頁面對應至特定網域
- Ping 圖表
- 憑證資訊
- PWA
- 支援 Sqlite 與 Postgres 資料庫

還會新增數十項小功能。

## 🔧 安裝方式

### 🐳 Docker

適用於 Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

針對 Postgres

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat 現已在 http://localhost:3000 執行

> [!IMPORTANT]
> 在部署之前，請確保更改環境變數的值。

### 💪🏻 非 Docker

需求：

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres（可選）

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## 技術堆疊

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 貢獻指南

歡迎貢獻！貢獻讓開源社群成為一個絕佳的學習、啟發與創造的地方。您所做的任何貢獻都將被**高度感謝**。

如果您有任何建議可以讓這個專案更好，請 fork 此儲存庫，進行更改並建立 Pull Request。您也可以簡單地開一個標記為 "enhancement" 的 issue。
別忘了幫本專案加顆星！再次感謝！

1. Fork 此專案
2. 建立您的功能分支（`git checkout -b feature/AmazingFeature`）
3. 提交您的更改（`git commit -m 'Add some AmazingFeature'`）
4. Push 到分支（`git push origin feature/AmazingFeature`）
5. 開啟 Pull Request

## 貢獻者

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 授權條款

本專案採用 [MIT 授權條款](https://opensource.org/license/mit/) 授權。

## 🖼 更多螢幕截圖

建立監控項目

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

監控頁面

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---