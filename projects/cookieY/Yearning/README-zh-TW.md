<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

一個強大、可本地部署的平台，專為無縫 SQL 檢測與查詢稽核而設計，特別針對 DBA 和開發人員量身打造。注重隱私與效率，提供直觀且安全的 MYSQL 稽核環境。

---
[![OSCS 狀態](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![平台支援](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![下載次數](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ 特色功能

- **AI 助手**：我們的 AI 助手提供即時 SQL 優化建議，提升 SQL 效能。也支援文字轉 SQL，讓用戶可輸入自然語言並獲得優化後的 SQL 語句。
  
- **SQL 稽核**：建立帶有審核流程和自動語法檢查的 SQL 稽核單。驗證 SQL 語句的正確性、安全性與合規性。對 DDL/DML 操作自動生成回滾語句，並提供完整歷史紀錄以便追蹤。

- **查詢稽核**：稽核用戶查詢，限制資料來源和資料庫，並對敏感欄位進行匿名化處理。查詢紀錄將被保存以供日後查閱。

- **檢查規則**：我們的自動語法檢查器支援多種檢查規則，適用於大多數自動檢查場景。

- **注重隱私**：Yearning 是可本地部署的開源解決方案，確保您的資料庫及 SQL 語句的安全。包含加密機制保護敏感資料，即使未經授權存取也能確保安全。

- **RBAC（基於角色的存取控制）**：創建並管理具有特定權限的角色，根據用戶角色限制對查詢工單、稽核功能及其他敏感操作的存取。

> \[!TIP]
> 欲了解更多詳細資訊，請參閱我們的 [Yearning 指南](https://next.yearning.io)


## ⚙️ 安裝方式

下載 [最新發佈版](https://github.com/cookieY/Yearning/releases/latest) 並解壓縮。請確保在繼續操作前已配置好 `./config.toml`。

### 手動安裝

```bash
## 初始化資料庫
./Yearning install

## 啟動 Yearning
./Yearning run

## 說明
./Yearning --help
```

### 🚀 使用 Docker 部署
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## 初始化資料庫
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## 啟動 Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 AI 協助

我們的 AI 助手運用大型語言模型，提供 SQL 優化建議及文字轉 SQL 功能。不論是使用預設或自訂提示詞，AI 助手皆能優化 SQL 語句並將自然語言輸入轉換為 SQL 查詢。

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 自動 SQL 檢查器

自動 SQL 檢查器會依據預先定義的規則與語法評估 SQL 語句。可確保語句符合特定編碼標準、最佳實踐與安全需求，提供堅實的驗證層。

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 SQL 語法高亮與自動補全

透過 SQL 語法高亮與自動補全功能，提升您的查詢編寫效率。這些功能協助用戶視覺上區分 SQL 查詢的不同元件，如關鍵字、資料表名稱、欄位名稱及運算子，使查詢結構更易於閱讀和理解。

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ 工單/查詢紀錄

本平台支援用戶工單及查詢語句的稽核。此功能可追蹤並記錄所有查詢操作，包括資料來源、資料庫及敏感欄位的處理，確保合規並提供查詢歷史的可追溯性。

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Yearning 專注於上述關鍵功能，提升用戶體驗、優化 SQL 效能，並確保資料庫操作的強大合規性與可追溯性。

## 🛠️ 推薦工具

- [Spug - 開源輕量級自動化運維平台](https://github.com/openspug/spug)

## ☎️ 聯絡方式

如有諮詢，請發送電子郵件至：henry@yearning.io
## 📋 授權條款

Yearning 採用 AGPL 授權條款。詳情請參閱 [LICENSE](LICENSE)。

2024 © Henry Yee

---

使用 Yearning，體驗更簡化、安全且高效的 SQL 審計與優化流程。


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---