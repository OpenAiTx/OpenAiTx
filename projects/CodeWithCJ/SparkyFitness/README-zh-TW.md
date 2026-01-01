
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">簡體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">韓國語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">印地語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">泰語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">法語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">德語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">西班牙語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">義大利語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">俄語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">葡萄牙語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">荷蘭語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">波蘭語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">阿拉伯語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">波斯語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">土耳其語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">越南語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">印尼語</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness - MyFitnessPal 的自架替代方案

SparkyFitness 是一套全面的健身追蹤與管理應用程式，設計用於協助使用者監控營養、運動及身體數據。它提供每日進度追蹤、目標設定及詳細報告工具，助你維持健康生活方式。

文件： https://codewithcj.github.io/SparkyFitness

## ✨ 功能

### 🍎 營養追蹤

* **記錄您的每日餐點**
* **建立並管理自訂食物和分類**
* **透過互動式圖表檢視摘要並分析趨勢**

### 💪 運動紀錄

* **記錄您的運動活動**
* **瀏覽並搜尋完整的運動資料庫**
* **追蹤健身進展**

### 💧 飲水攝取監控

* **追蹤每日飲水目標**
* **簡單快速地記錄飲水量**

### 📏 身體測量

* **記錄身體指標**（例如體重、腰圍、手臂）
* **新增自訂測量類型**
* **以圖表視覺化進展**

### 🎯 目標設定

* **設定並管理健身與營養目標**
* **長期追蹤進度**

### 🗓️ 每日簽到

* **監控每日活動**
* **透過習慣追蹤保持一致**

### 🤖 AI 營養教練（SparkyAI）

* **透過聊天記錄食物、運動、身體數據及步數**
* **上傳食物圖片自動記錄餐點**
* **包含聊天紀錄及個人化指導**

### 🔒 使用者驗證與個人檔案

* **安全登入系統**
* **切換使用者個人檔案**
* **支援家庭存取與管理**

### 📊 全面性報告

* **產生營養與身體指標摘要**
* **追蹤數週或數月的長期趨勢**

### 🎨 可自訂主題

* **切換明亮與深色模式**
* **以極簡、無干擾介面設計**

### 需要協助嗎？
* **加入 Discord**
  https://discord.gg/vcnMT5cPEA
* **在討論區發文**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)

## � 快速開始

幾分鐘內即可啟動 SparkyFitness：

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -o docker-compose.yml https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/docker-compose.prod.yml
curl -o .env https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/.env.example

# 3. (Optional) Edit .env to customize your setup
# e.g., update database credentials, ports, etc.
# if you require Gamrin integration, uncomment Garmin section from compose file.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 📖 文件說明

完整的安裝指南、開發設置及使用說明，請參閱我們的詳細文件：

**👉 [SparkyFitness 文件網站](https://codewithcj.github.io/SparkyFitness)**

### 快速連結

- **[🚀 新手入門](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - 開發及正式環境的完整設置指南
- **[🐳 Docker 指南](https://codewithcj.github.io/SparkyFitness/developer/docker)** - Docker 部署與設定
- **[🔧 開發流程](https://codewithcj.github.io/SparkyFitness/developer/workflow)** - 開發人員指南與貢獻流程  
- **[📊 功能總覽](https://codewithcj.github.io/SparkyFitness/features/)** - 完整功能文件
- **[🏗️ 架構設計](https://codewithcj.github.io/SparkyFitness/app-overview)** - 技術架構與設計
- 請參閱 Wiki 以取得範例環境設置和行動應用程式配置。


## 星標歷史

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="星標歷史圖表" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## 翻譯

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="翻譯狀態" />
</a>

## 程式庫活動

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats 分析圖")


## 貢獻者

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

### ⚠️ 已知問題 / 測試版功能 ⚠️

以下功能目前為測試版，可能尚未經過充分測試。請預期可能出現錯誤或功能不完整：

*   AI 聊天機器人
*   多用戶支援
*   家人與朋友存取
*   Apple Health 資料整合

本應用程式正在密集開發中。由於 Supabase 正在遷移至 PostgreSQL，可能有些功能無法如預期運作。直到應用程式穩定前，可能會引入重大變更（BREAKING CHANGES）。
每次新版本發佈時，可能需要修改 Docker／環境變數。因此，不建議使用 Watchtower 或類似應用程式自動升級。請閱讀發佈說明以了解任何重大變更（BREAKING CHANGES）。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---