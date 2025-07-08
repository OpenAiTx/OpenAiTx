本項目的 CDN 加速與安全防護由騰訊雲 EdgeOne 贊助。

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

本項目作者為 colin1114。

# 🚀 Clash 訂閱轉換器

一個美觀且功能強大的線上工具，用於將各種代理訂閱連結轉換為 Clash 配置格式。支援透過 Cloudflare Workers & Pages 自動部署，提供快速、可靠的訂閱轉換服務。

## ✨ 功能特性

- 🎨 **美觀的現代化介面** - 採用漸變背景與卡片式設計
- 🔄 **多協議支援** - 支援 V2Ray、VLESS、Shadowsocks、Trojan 等主流協議
- ☁️ **雲端部署** - 透過 Cloudflare Workers 實現全球 CDN 加速
- 📱 **響應式設計** - 完美適配桌面端與行動端
- ⚡ **快速轉換** - 即時將訂閱連結轉換為 Clash 配置
- 📋 **智慧複製** - 支援一鍵複製生成的 YAML 配置，兼容各種瀏覽器
- 📡 **訂閱連結生成** - 自動生成可直接導入 Clash 的訂閱連結
- 🌐 **線上 YAML 存取** - 提供多種 YAML 檔案存取方式：
  - 📡 訂閱連結：支援 Clash 客戶端自動更新
  - 🔗 線上檢視：直接於瀏覽器檢視配置內容
  - 💾 檔案下載：下載 .yaml 檔案至本地
  - ⚡ 快速存取：簡化的下載連結
- 🔧 **UTF-8 支援** - 完美支援中文節點名稱與配置
- 🆓 **完全免費** - 基於 Cloudflare 免費服務，無使用限制

## 📁 專案結構

```
clash/
├── index.html              # 前端頁面
├── worker.js               # Cloudflare Worker 後端程式碼
├── wrangler.jsonc          # Wrangler 配置檔
├── _headers                # Cloudflare Pages HTTP 標頭配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 專案說明文件
└── package.json           # 專案配置檔
```

## 🚀 快速開始

### 方法一：本地執行

1. **複製專案**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **啟動本地伺服器**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **存取應用程式**
   - 打開瀏覽器並訪問 `http://localhost:8000`
   - 本地環境下會顯示範例配置

### 方法二：Cloudflare Workers 部署

#### 步驟1：建立 Worker

1. 進入 [Cloudflare Workers](https://workers.cloudflare.com/)
2. 註冊/登入 Cloudflare 帳號
3. 點擊「Create a Worker」
4. 將 `worker.js` 的程式碼完整複製到編輯器中
5. 點擊「Save and Deploy」

#### 步驟2：使用 Wrangler CLI 部署

```bash
# 安裝 Wrangler CLI
npm install -g wrangler

# 登入 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### 步驟3：設定網域名稱（選用）

1. 在 Worker 設定中新增自訂網域名稱
2. 或使用 Cloudflare 提供的預設網域

### 方法三：Cloudflare Pages 部署

#### 選項A：GitHub 整合（推薦）

1. **準備倉庫**
   - 將程式碼推送至 GitHub 倉庫
   - 確保包含所有必要檔案
2. **建立 Pages 專案**
   - 訪問 [Cloudflare Pages](https://pages.cloudflare.com/)
   - 連接你的 GitHub 儲存庫
   - 選擇專案儲存庫

3. **建構設定**
   - 建構指令：留空或填寫 `echo "No build required"`
   - 建構輸出目錄：`/`（根目錄）
   - 環境變數：無需設定

#### 選項B：直接上傳

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ 技術架構

### 前端技術棧
- **HTML5** - 現代化標記語言
- **CSS3** - 響應式設計和動畫效果
- **Vanilla JavaScript** - 輕量級前端互動

### 後端技術棧
- **Cloudflare Workers** - 邊緣運算平台
- **Web APIs** - 標準的 Fetch API 與回應處理

### 支援的協議格式
- **VMess** - V2Ray 標準協議
- **VLESS** - V2Ray 輕量協議（支援 Reality）
- **Shadowsocks** - 經典代理協議
- **Trojan** - 新興的代理協議

### API 端點
- `GET /` - 主頁面
- `POST /convert` - 訂閱轉換 API
- `GET /clash/{config-id}` - 取得 YAML 配置檔（訂閱連結）
- `GET /yaml/{config-id}` - 下載 YAML 配置檔
- `OPTIONS /*` - CORS 預檢請求

## 📖 使用指南

### 基本使用

1. **輸入訂閱連結**
   - 將你的代理訂閱連結貼到輸入框中
   - 支援 Base64 編碼的訂閱連結

2. **設定配置名稱**
   - 可選擇性地為配置檔設定自訂名稱
   - 預設為 "My Clash Config"

3. **轉換配置**
   - 點擊「轉換訂閱」按鈕
   - 等待轉換完成

4. **使用配置**
   - 複製生成的 YAML 配置
   - 匯入到 Clash 客戶端中使用

5. **使用訂閱連結（推薦）**
   - 複製生成的訂閱連結
   - 在 Clash 客戶端中新增訂閱
   - 配置會自動同步，無需手動更新

### 進階配置

生成的 Clash 配置包含以下特性：

- **代理群組策略**
  - 🚀 節點選擇 - 手動選擇代理
  - ♻️ 自動選擇 - 延遲測試自動選擇
  - 🎯 全球直連 - 直接連線

- **DNS 配置**
  - 啟用 DNS 解析
  - 支援 fake-ip 模式
  - 中國內外 DNS 分流

- **路由規則**
  - 本地位址直連
  - 中國 IP 直連
  - 其他流量走代理

## 🔧 部署疑難排解

### 常見問題

#### 1. Wrangler 找不到進入點
**錯誤訊息**: `Missing entry-point to Worker script`

**解決方案**: 
- 確認專案根目錄有 `wrangler.jsonc` 檔案
- 檢查 `wrangler.jsonc` 中的 `main` 欄位是否指向 `worker.js`

#### 2. GitHub Actions 部署失敗
**解決方案**:
- 在 GitHub 儲存庫設定中新增以下 Secrets:
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API 金鑰
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare 帳戶 ID

#### 3. Pages 構建失敗
**解決方案**:
- 將構建命令設為空或 `echo "No build required"`
- 確保構建輸出目錄設為 `/`

### 部署配置文件說明

- **`wrangler.jsonc`**: Wrangler CLI 配置，用於 Worker 部署
- **`_headers`**: Cloudflare Pages HTTP 標頭配置
- **`.github/workflows/deploy.yml`**: GitHub Actions 自動部署配置

## 🔧 自訂配置

### 修改代理組

可以編輯 `worker.js` 中的 `convertToClash` 函數來自訂代理組：

```javascript
'proxy-groups': [
  {
    name: '🚀 節點選擇',
    type: 'select',
    proxies: ['♻️ 自動選擇', '🎯 全球直連', ...proxyNames]
  },
  // 添加更多代理組...
]
```

### 自訂路由規則

修改 `rules` 陣列來添加自訂路由規則：

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 節點選擇',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多規則...
]
```

## 📊 效能特性

- **全球 CDN** - Cloudflare 覆蓋全球的邊緣節點
- **快速回應** - 平均回應時間 < 100ms
- **高可用性** - 99.9% 服務可用性
- **免費額度** - 每天 100,000 次請求

## 🔒 安全說明

- **資料隱私** - 訂閱資料僅於轉換過程中使用，不會被儲存
- **HTTPS 加密** - 所有通訊皆經由 HTTPS 加密
- **開源透明** - 完整原始碼公開，可自行審查

## 🤝 貢獻指南

歡迎提交 Issue 與 Pull Request！

1. Fork 本倉庫
2. 建立功能分支 (`git checkout -b feature/AmazingFeature`)
3. 提交更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 發起 Pull Request

## 📝 更新日誌

### v1.1.0
- ✅ 新增 VLESS 協議支援（包含 Reality 安全傳輸）
- ✅ 改進協議相容性

### v1.0.0
- ✅ 基礎訂閱轉換功能
- ✅ 美觀的使用者介面
- ✅ Cloudflare Workers 支援
- ✅ 多協議支援（VMess、Shadowsocks、Trojan）
- ✅ 響應式設計
- ✅ 一鍵複製功能

## 📞 支援與回饋

如果你在使用過程中遇到問題或有建議，請：

1. 查看本 README 文件
2. 提交 [Issue](../../issues)
3. 發起 [Discussion](../../discussions)

## 📄 授權條款

本專案採用 MIT 授權條款 - 詳見 [LICENSE](LICENSE) 文件

## 🙏 致謝

- [Cloudflare Workers](https://workers.cloudflare.com/) - 提供邊緣運算平台
- [Clash](https://github.com/Dreamacro/clash) - 優秀的代理客戶端
- 所有貢獻者與使用者的支持

---
⭐ 如果這個項目對你有幫助，請給它一個 Star！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---