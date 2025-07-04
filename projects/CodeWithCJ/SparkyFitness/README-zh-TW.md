# SparkyFitness - MyFitnessPal 的自架替代方案

SparkyFitness 是一款全面的健身追蹤與管理應用程式，設計用於協助使用者監控其營養攝取、運動及身體數據。它提供每日進度追蹤、目標設定及深度報告等工具，以支持健康的生活方式。

## ✨ 功能特色

### 🍎 營養追蹤

* **記錄你的每日餐點**
* **建立及管理自訂食物與分類**
* **透過互動圖表檢視摘要並分析趨勢**

### 💪 運動紀錄

* **記錄你的運動內容**
* **瀏覽與搜尋完整的運動資料庫**
* **追蹤健身進展隨時間變化**

### 💧 飲水量監控

* **追蹤每日飲水目標**
* **簡單快速的飲水紀錄**

### 📏 身體數據

* **記錄身體指標**（例如體重、腰圍、手臂等）
* **新增自訂量測類型**
* **透過圖表視覺化進度**

### 🎯 目標設定

* **設定與管理健身及營養目標**
* **隨時間追蹤進度**

### 🗓️ 每日簽到

* **監控每日活動**
* **透過習慣追蹤保持一致性**

### 🤖 AI 營養教練（SparkyAI）

* **透過聊天紀錄食物、運動、身體數據及步數**
* **上傳食物照片自動記錄餐點**
* **包含聊天歷史及個人化指導**

### 🔒 使用者認證與個人檔案

* **安全的登入系統**
* **在不同使用者檔案間切換**
* **支援家庭存取與管理**

### 📊 全面報告

* **產生營養與身體指標的摘要報告**
* **追蹤每週或每月的長期趨勢**

### 🎨 主題自訂

* **切換明亮與深色模式**
* **設計簡潔、無干擾介面**

### 需要幫助？
* **加入 Discord**
  https://discord.gg/vcnMT5cPEA
* **在討論區發文**

![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)

## 🚀 快速開始

若要在本地機器上執行 SparkyFitness 應用程式，請按照以下步驟操作：

### 先決條件

*   **Supabase 專案**：你需要設立一個 Supabase 專案。
    *   **在 Supabase 建立新專案**：前往 [Supabase](https://app.supabase.com/) 並建立新專案。（如果需要也可嘗試設置本地 Supabase 專案。）
    *   從專案設定（API 區段）取得你的 Supabase 專案 URL 及 Anon Key。
    *   **關於 Supabase 認證的重要說明：**請在 Supabase 認證設定中更新你的 URL 配置，以符合你的網域。這對你的網域正常運作及收到註冊邀請郵件至關重要。Supabase 提供豐富的安全功能及第三方 SSO 選項，請根據專案需求進行配置。
    *   如果你使用 Supabase 免費版，Supabase 的自動資料庫部署不支援 IPV4。你需要將網路配置為使用 IPV6 連線，否則資料庫遷移會失敗，且需手動部署。

### 安裝步驟

1.  **設定環境變數：**
    在 private 資料夾下建立 `.env` 檔案。如果你使用 Portainer，可以直接在那裡建立。
    新增你的 Supabase 憑證：
    ```
    VITE_SUPABASE_URL="YOUR_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="YOUR_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="YOUR_SUPABASE_PROJECT_REF"    
    ```

2.  **使用 Docker Compose 執行：**
    下載 Docker 映像檔並啟動服務：
    ```sh
    docker compose pull
    docker compose up -d
    ```

3.  **存取應用程式：**
    當服務啟動並運行後，請在您的網頁瀏覽器中進入 SparkyFitness：
    ```
    http://localhost:3000
    ```

4.  **AI 聊天機器人－可選設定：**
    若要啟用 AI 聊天機器人的完整功能，包括安全的 API 金鑰儲存與資料庫存取，請依照以下步驟操作：

    *   **設定 `AI_API_ENCRYPTION_KEY`：** 在「Supabase -> Edge Functions」->「Environment Variables」中產生一組密鑰。此密鑰用於加密您儲存在 Supabase 內的 AI 金鑰。

    *   **產生 `SUPABASE_ACCESS_TOKEN`：**
        1.  進入您的 Docker 控制台。
        2.  執行 `supabase login` 並使用提供的網址進行認證。
        3.  執行 `cat ~/.supabase/access-token` 以取得存取權杖。
        4.  將此權杖更新到您的 `docker-compose.yml` 或 Portainer 設定中，然後重新部署。
        5.  重新部署後，登入 SparkyFitness 並以您偏好的供應商設定 AI 服務。
     

### 手動部署資料庫與函數至 Supabase
**方法一：**  
**如果您沒有啟用 IPV6 網路連線，資料庫遷移將會失敗，因為 Supabase 免費版不支援直接的 IPV4 連線。**

   1. 下載最新釋出檔並解壓縮至您的電腦。
   2. 進入專案資料夾。Docker 必須已啟動並運行。
   3. 執行以下指令（functions deploy 僅在需要 AI 設定時使用，如果不需要 ChatBOT，可以略過）：
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
重新執行 Docker compose。前端應用程式將開始運作。

**方法二：**  
   1. 下載最新釋出檔並解壓縮至您的電腦。  
   2. 進入專案資料夾。  
   3. 前往 supabase/migrations。複製 SQL 指令，並依照 ASC 順序逐一在 Supabase-->Project-->SQL Editor 中執行。  
   4. 【可選】若需要 AI ChatBOT，同樣操作 supabase/functions/chat。複製 index.js 並在 Supabase-->Project-->Edge Function-->Deploy new function 中執行。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---