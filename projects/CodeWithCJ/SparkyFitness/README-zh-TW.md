<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

一個自架、隱私優先的 MyFitnessPal 替代方案。記錄營養、運動、身體指標和健康數據，同時完全掌控您的數據。

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness 是一個自架的健身追蹤平台，由以下組成：

- 後端伺服器（API + 數據儲存）
- 基於網頁的前端
- 原生行動應用程式適用於 iOS 和 Android

它在您控制的基礎設施上儲存並管理健康資料，無需依賴第三方服務。

## 核心功能

- 營養、運動、補水、睡眠、斷食、心情與身體測量追蹤
- 設定目標與每日檢查
- 互動式圖表與長期報告
- 多用戶檔案與家庭存取
- 明亮與暗黑主題
- OIDC、TOTP、Passkey、多重驗證等

## 健康與設備整合

SparkyFitness 可從多個健康與健身平台同步資料：

- **Apple Health**（iOS）
- **Google Health Connect**（Android）
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow**（部分測試）
- **Hevy**（未測試）
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava**（部分測試）

整合功能會自動將活動資料（如步數、運動、睡眠）及健康指標（如體重與身體測量）同步到您的 SparkyFitness 伺服器。

## 選用 AI 功能（測試版）

SparkyAI 提供對話介面以記錄資料與檢視進度。

- 透過聊天記錄食物、運動、身體數據與步數
- 上傳食物圖片以自動記錄餐點
- 保留對話歷史以便後續追蹤

注意：AI 功能目前處於測試階段。

## 快速開始（伺服器）

使用 Docker Compose 可於數分鐘內啟動 SparkyFitness 伺服器。

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```


## 🎥 視頻教學

[![觀看視頻](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

快速 2 分鐘教學，展示如何安裝 SparkyFitness（自架健身追蹤器）。


## 文件

完整安裝指南、配置選項及開發文件，請參閱我們的 [文件網站](https://codewithcj.github.io/SparkyFitness/)。

### 快速連結

- **[安裝指南](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - 部署與配置
- **[功能總覽](https://codewithcj.github.io/SparkyFitness/features)** - 完整功能文件
- **[開發流程](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - 開發者指南與貢獻流程
- **[iOS 應用資訊](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** 及 **[Android 應用資訊](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### 需要協助？

- 在 Github 問題/討論區發帖。
- 若需更快回應並獲得其他社群成員幫助，請 **[加入我們的 Discord](https://discord.gg/vcnMT5cPEA)**

## 星標歷史

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="星標歷史圖表" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## 翻譯

**[Weblate 翻譯](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="翻譯狀態" />
</a>

## 儲存庫活動

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats 分析圖像")

## 貢獻者

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ 已知問題 / 測試功能 ⚠️

SparkyFitness 正在積極開發中。
版本間可能會發生重大變更。

- 不建議自動更新容器
- 升級前請務必檢查發行說明

以下功能目前處於測試階段，可能尚未徹底測試。請預期可能有錯誤或功能不完整：

- AI 聊天機器人
- 家庭與朋友存取
- API 文件


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---