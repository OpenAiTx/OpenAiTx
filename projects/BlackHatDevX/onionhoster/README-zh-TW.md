<details align="right">
<summary>🌐 語言</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)
</details>

# OnionHoster v2.2

> **終極 Tor 隱藏服務託管工具** - 只需數分鐘即可將您的網頁專案部署到暗網！
> 
[![Version](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

<img width="1023" height="551" alt="ChatGPT Image Aug 27, 2025, 03_32_08 PM (1)-modified" src="https://github.com/user-attachments/assets/92b6e834-2d4f-4cc7-8f77-82b9bafba8a5" />


---

## 🚀 什麼是 OnionHoster？

OnionHoster 是一個強大的跨平台 bash 腳本，僅需一行指令即可將任何網頁專案轉變為 Tor 隱藏服務。無論您是託管 Next.js 應用、Flask 後端或靜態網站，OnionHoster 都會自動處理所有複雜的 Tor 設定。

### ✨ 為什麼選擇 OnionHoster？

- **🔧 零設定** - 可直接用於任何網頁專案
- **🌍 跨平台** - 支援 Linux、macOS 及主流發行版
- **⚡ 一鍵安裝** - 2 分鐘內從零到隱藏服務
- **🔄 自動更新** - 內建更新檢查器，保持最新
- **💾 備份與還原** - 不再遺失您的 onion 地址
- **🎯 專業 UI** - 美觀彩色介面、直覺選單

---
## 預覽

[![IMAGE ALT TEXT HERE](https://github.com/user-attachments/assets/4b35dfb0-0059-4cc5-99c7-a5b9467a385d)](https://www.youtube.com/watch?v=oPvhA54Tp8w)


# ⚠️ 警告：OnionHoster 並非萬能匿名工具 —— 請遵循最佳實踐，否則有去匿名風險

**系統強化**

* 請在虛擬機或容器中運行服務以確保隔離。

* 保持作業系統與套件為最新狀態。
* 停用不必要的服務/埠，確保只有 Tor 流量進出。

**作業安全（OpSec）實踐**

* 不要在同一台機器上使用個人帳號或進行個人活動。
* 避免暴露可識別的元資料（檔案名稱、標頭、錯誤訊息）。
* 注意日誌紀錄 — 記錄什麼、保留多久，以及是否會洩漏資訊。

**網路衛生**

* 不要將您的隱藏服務與明網身份或網域橋接。
* 使用防火牆以確保沒有意外的流量洩漏到 Tor 之外。
* 可考慮反向代理以增加隔離。

**測試與監控**

* 使用 torsocks 或 Tor 瀏覽器來驗證您的服務僅可透過其 `.onion` 位址存取。
* 定期測試是否有洩漏（例如，您的應用程式是否嘗試從明網抓取資料）。

**使用情境意識**

* 用於休閒/測試/教育目的：上述措施通常已足夠。
* 若需高度風險、真正的匿名（記者、吹哨者、行動者）：則需更深入的作業安全與威脅建模，因為一次失誤就可能讓您去匿名化。


---
## 🎯 適合對象

- **開發者** 想在 Tor 上測試其應用程式
- **隱私倡導者** 主持匿名服務 (
- **研究人員** 研究暗網技術
- **企業** 需求匿名主機解決方案
- **愛好者** 探索 Tor 網路

---

## 🚀 快速入門

### 先決條件
- Root/sudo 權限
- 網際網路連線
- 任何網頁專案（HTML、Next.js、Flask 等）

### 安裝與使用

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```
**就這樣！** 🎉

您將獲得完整的 OnionHoster 專案，包括：
- 主要的 `onionhoster.sh` 腳本
- 專業的 `index.html` 範本供託管使用
- 所有文件及範例

此腳本會自動：
- 偵測您的作業系統
- 安裝所有必要的依賴套件（Tor、Apache 等）
- 設定 Tor 服務
- 提供直覺式選單介面

---

## 🎮 功能總覽

### 🌐 託管選項
- **靜態 HTML** - 託管任何 `index.html` 檔案
- **埠轉發** - 轉發至任何本地應用程式埠口
- **動態應用程式** - 支援 Next.js、Flask、Node.js 及更多

### 🛠️ 管理工具
- **服務控制** - 啟動、停止及管理您的隱藏服務
- **備份與還原** - 安全備份與還原您的洋蔥網域
- **URL 更新** - 需要時產生新的洋蔥位址
- **狀態監控** - 檢查服務健康狀態與運作情況

### 🔄 智慧更新
- **自動偵測** - 自動尋找最新版本
- **一鍵更新** - 只需一個選項即可更新
- **安全更新** - 不會遺失您的設定

---

## 📱 支援的作業系統

| 作業系統 | 套件管理器 | 狀態 |
|----|----------------|---------|

| **Ubuntu/Debian** | `apt-get` | ✅ 完整支援 |
| **CentOS/RHEL** | `yum` | ✅ 完整支援 |
| **Fedora** | `dnf` | ✅ 完整支援 |
| **Arch Linux** | `pacman` | ✅ 完整支援 |
| **macOS** | `brew` | ✅ 完整支援 |

---

## 🎯 使用情境

### 🏠 個人專案
- 匿名託管您的作品集
- 私下測試網頁應用程式
- 分享內容而不暴露您的身份

### 🏢 商業應用
- 匿名客戶支援入口網站
- 安全的內部溝通系統
- 注重隱私的企業網站

### 🔬 研究與開發
- 暗網技術研究
- 隱私工具開發
- 匿名服務測試

---

## 📖 詳細使用說明

### 主選單選項

1. **託管 index.html** - 提供靜態 HTML 檔案服務
2. **轉發至應用程式埠口** - 代理至任何本地服務
3. **備份 tor 網域** - 儲存您的 onion 設定
4. **還原 tor 網域** - 從備份還原
5. **檢視目前 tor 網域** - 查看您目前的 onion 位址
6. **重新整理 tor 網域** - 產生新的 onion 位址
7. **檢查更新** - 升級至最新版本
8. **網頁伺服器狀態** - 監控服務健康狀況
9. **關於 OnionHoster** - 版本及功能資訊

### 範例工作流程

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 進階設定

### 自訂埠轉發
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### 備份管理
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```
---

## 🛡️ 安全功能

- **自動 Tor 設定** - 預設即安全
- **正確的檔案權限** - 檔案擁有權及存取安全
- **服務隔離** - 每個隱藏服務獨立運行
- **不記錄資料** - 您的活動保持隱私

---

## 🚨 重要注意事項

- **需要 Root 權限** - Tor 服務需系統層級設定
- **Tor 網路** - 您的服務可透過 Tor 瀏覽器存取
- **Onion 位址** - 每個服務分配唯一 `.onion` 位址
- **定期備份** - Onion 位址於重新整理時會變更

---

## 🤝 貢獻方式

歡迎各種貢獻！包括：
- 🐛 回報錯誤
- 💡 功能建議
- 📝 改善文件
- 🔧 程式碼貢獻

**開始貢獻步驟：**
1. 分支專案倉庫
2. 創建功能分支
3. 進行修改
4. 提交 Pull Request

---

## 📄 授權條款

本專案採用 MIT 授權條款 - 詳情請參閱 [LICENSE](LICENSE) 檔案。

---

## 🙏 致謝

- **Tor 專案** - 提供出色的匿名網路
- **開源社群** - 持續推動改進
- **用戶與貢獻者** - 提供反饋及建議

---

## 🔗 相關連結

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)
- **問題回報**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)
- **討論區**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)

---

## ⭐ 歡迎為本專案加星

如果 OnionHoster 對你有幫助，請給我們一個星標！這將激勵我們不斷改進，也能幫助更多人發現這個工具。

---

**準備好匿名上網了嗎？** 🕵️‍♂️


```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```

*您的匿名主機之旅現在開始！* 🚀


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---