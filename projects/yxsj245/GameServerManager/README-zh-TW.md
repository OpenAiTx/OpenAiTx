# 項目介紹
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**讓遊戲伺服器的部署、管理與維護變得簡單高效**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 文件站](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 官方網站](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 QQ群](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 項目簡介

GameServerManager（簡稱GSManager）是一個基於 **Docker** 技術的現代化遊戲伺服器管理平台，專為簡化遊戲伺服器的部署、管理與維護而設計。

### ✨ 核心特性

- 🐳 **Docker 容器化** - 完全基於Docker運行，環境隔離，相容性極佳
- 🎯 **一鍵部署** - 支援多款熱門遊戲的快速部署
- 🌐 **Web 管理介面** - 現代化的React前端，直觀易用
- 🔧 **即時終端機** - 內建Web終端機，支援即時命令執行
- 📊 **資源監控** - 即時監控伺服器資源使用情況
- 🔐 **權限管理** - 完善的用戶認證和權限控制系統
- 🎮 **多遊戲支援** - 支援Steam平台多款熱門遊戲伺服器
- 💾 **資料持久化** - 遊戲資料與配置檔案外部映射，安全可靠

![容器資訊面板](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 快速開始

### 一鍵安裝腳本

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> debian（docker請自行安裝）與centos請使用手動安裝，詳見文件站

---

## 🎮 支援的遊戲

| 遊戲名稱 | 中文名 | Steam ID | 匿名下載 | 狀態 |
|---------|--------|----------|----------|------|
| **熱門遊戲** | | | | |
| Palworld | 幻獸帕魯 | 2394010 | ✅ | 🟢 完全支援 |
| Rust | 腐蝕 | 258550 | ✅ | 🟢 完全支援 |
| Satisfactory | 幸福工廠 | 1690800 | ✅ | 🟢 完全支援 |
| Valheim | 英靈神殿 | 896660 | ✅ | 🟢 完全支援 |
| 7 Days to Die | 七日殺 | 294420 | ✅ | 🟢 完全支援 |
| Project Zomboid | 殭屍毀滅工程 | 380870 | ✅ | 🟢 完全支援 |
| ARK: Survival Evolved | 方舟：生存進化 | 376030 | ✅ | 🟢 完全支援 |
| **射擊遊戲** | | | | |
| Left 4 Dead 2 | 求生之路2 | 222860 | ❌ | 🟡 需要正版 |
| Team Fortress 2 | 軍團要塞2 | 232250 | ✅ | 🟢 完全支援 |
| Squad | 戰術小隊 | 403240 | ✅ | 🟢 完全支援 |
| Insurgency: Sandstorm | 叛亂：沙漠風暴 | 581330 | ✅ | 🟢 完全支援 |
| Killing Floor 2 | 殺戮空間2 | 232130 | ✅ | 🟢 完全支援 |
| Insurgency (2014) | 叛亂2 | 237410 | ✅ | 🟢 完全支援 |
| MORDHAU | 雷霆一擊 | 629800 | ✅ | 🟢 完全支援 |
| No More Room in Hell | 地獄已滿 | 317670 | ✅ | 🟢 完全支援 |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 完全支援 |
| Half-Life | 半條命 | 90 | ✅ | 🟢 完全支援 |
| Half-Life 2: Deathmatch | 半條命2 | 232370 | ✅ | 🟢 完全支援 |
| Operation: Harsh Doorstop | 行動代號：殘酷之門 | 950900 | ✅ | 🟢 完全支援 |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 需要配置 |
| **獨立遊戲** | | | | |
| Unturned | 未轉變者 | 1110390 | ✅ | 🟢 完全支援 |
| Don't Starve Together | 饑荒聯機版 | 343050 | ✅ | 🟡 需要配置 |
| Last Oasis | 最後的綠洲 | 920720 | ✅ | 🟢 完全支援 |
| Hurtworld | 傷害世界 | 405100 | ✅ | 🟢 完全支援 |
| Soulmask | 靈魂面甲 | 3017300 | ✅ | 🟢 完全支援 |
| **模擬遊戲** | | | | |
| Euro Truck Simulator 2 | 歐洲卡車模擬2 | 1948160 | ✅ | 🟡 需要配置 |
| American Truck Simulator | 美國卡車模擬 | 2239530 | ✅ | 🟡 需要配置 |
| ECO | 生態生存 | 739590 | ✅ | 🟡 需要配置 |

> 更多遊戲支援持續新增中...

---

## 🏗️ 技術架構

### 前端技術棧
- **React 18** - 現代化前端框架
- **Ant Design** - 企業級UI元件庫
- **Monaco Editor** - 程式碼編輯器
- **Xterm.js** - Web終端機模擬器
- **Vite** - 快速建構工具

### 後端技術棧
- **Python 3.13** - 主要開發語言
- **Flask** - Web框架
- **Gunicorn** - WSGI伺服器
- **Docker** - 容器化技術
- **SteamCMD** - Steam命令列工具
- **Aria2** - 多協議下載器

---

## 📁 專案結構

```
GameServerManager/
├── app/                    # 前端應用
│   ├── src/               # React原始碼
│   ├── public/            # 靜態資源
│   └── package.json       # 前端依賴
├── server/                # 後端服務
│   ├── api_server.py      # 主API伺服器
│   ├── game_installer.py  # 遊戲安裝器
│   ├── pty_manager.py     # 終端管理器
│   ├── auth_middleware.py # 驗證中介軟體
│   └── installgame.json   # 遊戲設定檔
├── docker-compose.yml     # Docker編排檔案
├── Dockerfile            # Docker映像建置檔案
└── README.md             # 專案說明文件
```

---

## 🔧 設定說明

### 連接埠設定
- **5000** - Web管理介面
- **27015-27020** - Steam遊戲伺服器連接埠範圍

### 資料卷對應
- `./game_data` → `/home/steam/games` - 遊戲資料目錄
- `./game_file` → `/home/steam/.config` - 遊戲設定目錄
- `./game_file` → `/home/steam/.local` - 遊戲存檔目錄

### 環境變數
- `TZ=Asia/Shanghai` - 時區設定
- `USE_GUNICORN=true` - 啟用Gunicorn
- `GUNICORN_TIMEOUT=120` - 請求逾時時間
- `GUNICORN_PORT=5000` - 伺服器連接埠

---

## 🤝 貢獻指南

我們歡迎所有形式的貢獻！

1. **Fork** 本專案
2. 建立你的功能分支 (`git checkout -b feature/AmazingFeature`)
3. 提交你的更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 開啟一個 **Pull Request**

---

## 📞 支援與回饋

- 🐛 **問題回報**：[GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **QQ交流群**：1040201322
- 📖 **詳細文件**：[查看文件](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 開源授權

本專案採用 [AGPL-3.0 license](LICENSE) 開源授權。

---

## 👨‍💻 關於作者

此專案由 **又菜又愛玩的小朱** 獨立開發維護。

如果這個專案對你有幫助，請給個 ⭐ Star 支持一下！

---

## 📈 專案統計

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 讓遊戲伺服器管理變得簡單有趣！**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---