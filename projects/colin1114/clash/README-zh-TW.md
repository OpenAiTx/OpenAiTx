
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">簡體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">韓國語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">印地語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">泰語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">法語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">德語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">西班牙語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">義大利語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">俄語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">葡萄牙語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">荷蘭語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">波蘭語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">阿拉伯語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">波斯語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">土耳其語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">越南語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">印尼語</a></p>
      </div>
    </div>
  </details>
</div>

本專案的 CDN 加速與安全防護由騰訊 EdgeOne 贊助。

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

本專案作者為 colin1114。

# 🚀 Clash 訂閱轉換器

一個美觀且功能強大的線上工具，用於將各種代理訂閱連結轉換為 Clash 配置格式。支援透過 Cloudflare Workers & Pages 自動部署，提供快速、可靠的訂閱轉換服務。

## ✨ 功能特色

- 🎨 **美觀的現代化介面** - 採用漸層背景與卡片式設計
- 🔄 **多協議支援** - 支援 V2Ray、VLESS、Shadowsocks、Trojan 等主流協議
- ☁️ **雲端部署** - 透過 Cloudflare Workers 實現全球 CDN 加速
- 📱 **響應式設計** - 完美適配桌面端與行動端
- ⚡ **快速轉換** - 即時將訂閱連結轉換為 Clash 設定
- 📋 **智慧複製** - 支援一鍵複製產生的 YAML 設定，兼容各類瀏覽器
- 📡 **訂閱連結生成** - 自動生成可直接匯入 Clash 的訂閱連結
- 🌐 **線上 YAML 存取** - 提供多種 YAML 檔案存取方式：
  - 📡 訂閱連結：支援 Clash 客戶端自動更新
  - 🔗 線上檢視：瀏覽器直接檢視設定內容
  - 💾 檔案下載：下載 .yaml 檔案至本機
  - ⚡ 快速存取：簡化的下載連結
- 🔧 **UTF-8 支援** - 完美支援中文節點名稱與設定
- 🆓 **完全免費** - 基於 Cloudflare 免費服務，無使用限制

## 📁 專案結構

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
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

3. **訪問應用程式**
   - 打開瀏覽器訪問 `http://localhost:8000`
   - 在本地環境下會顯示範例配置

### 方法二：Cloudflare Workers 部署

#### 步驟1：建立 Worker

1. 訪問 [Cloudflare Workers](https://workers.cloudflare.com/)
2. 註冊/登入 Cloudflare 帳戶
3. 點擊「Create a Worker」
4. 將 `worker.js` 中的程式碼完整複製到編輯器中
5. 點擊「Save and Deploy」

#### 步驟2：使用 Wrangler CLI 部署

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### 步驟3：配置網域（可選）

1. 在 Worker 設定中新增自訂網域
2. 或使用 Cloudflare 提供的預設網域

### 方法三：Cloudflare Pages 部署

#### 選項A：GitHub 整合（推薦）

1. **準備倉庫**
   - 將程式碼推送到 GitHub 倉庫
   - 確保包含所有必要檔案

2. **建立 Pages 專案**
   - 造訪 [Cloudflare Pages](https://pages.cloudflare.com/)
   - 連接你的 GitHub 倉庫
   - 選擇專案倉庫

3. **建置設定**
   - 建置指令：留空或 `echo "No build required"`
   - 建置輸出目錄：`/`（根目錄）
   - 環境變數：無需設定

#### 選項B：直接上傳

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ 技術架構

### 前端技術棧
- **HTML5** - 現代化標記語言
- **CSS3** - 響應式設計與動畫效果
- **Vanilla JavaScript** - 輕量級前端互動

### 後端技術棧
- **Cloudflare Workers** - 邊緣運算平台
- **Web APIs** - 標準的 Fetch API 與回應處理

### 支援的協議格式
- **VMess** - V2Ray 標準協議
- **VLESS** - V2Ray 輕量協議（支援Reality）
- **Shadowsocks** - 經典代理協議
- **Trojan** - 新興代理協議

### API 端點
- `GET /` - 主頁面
- `POST /convert` - 訂閱轉換API
- `GET /clash/{config-id}` - 取得YAML設定檔（訂閱連結）
- `GET /yaml/{config-id}` - 下載YAML設定檔
- `OPTIONS /*` - CORS預先檢查請求

## 📖 使用指南

### 基本使用

1. **輸入訂閱連結**
   - 將你的代理訂閱連結貼到輸入框中
   - 支援 Base64 編碼的訂閱連結

2. **設定設定檔名稱**
   - 可選擇性地為設定檔設置自訂名稱
   - 預設為 "My Clash Config"

3. **轉換設定**
   - 點擊 "轉換訂閱" 按鈕
   - 等待轉換完成
4. **使用配置**
   - 複製產生的 YAML 配置
   - 匯入至 Clash 客戶端中使用

5. **使用訂閱連結（推薦）**
   - 複製產生的訂閱連結
   - 在 Clash 客戶端中新增訂閱
   - 配置會自動同步，無需手動更新

### 高級配置

產生的 Clash 配置包含以下特性：

- **代理組策略**
  - 🚀 節點選擇 - 手動選擇代理
  - ♻️ 自動選擇 - 延遲測試自動選擇
  - 🎯 全球直連 - 直接連線

- **DNS 配置**
  - 啟用 DNS 解析
  - 支援 fake-ip 模式
  - 國內外 DNS 分流

- **路由規則**
  - 本地地址直連
  - 國內 IP 直連
  - 其他流量走代理

## 🔧 部署故障排除

### 常見問題

#### 1. Wrangler 找不到入口點
**錯誤資訊**: `Missing entry-point to Worker script`

**解決方案**: 
- 確保專案根目錄有 `wrangler.jsonc` 檔案
- 檢查 `wrangler.jsonc` 中的 `main` 欄位指向 `worker.js`


#### 2. GitHub Actions 部署失敗
**解決方案**：
- 在 GitHub 倉庫設置中新增以下 Secrets：
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API 令牌
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare 帳戶 ID

#### 3. Pages 建置失敗
**解決方案**：
- 將建置指令設為空或 `echo "No build required"`
- 確保建置輸出目錄設為 `/`

### 部署配置檔案說明

- **`wrangler.jsonc`**：Wrangler CLI 配置，用於 Worker 部署
- **`_headers`**：Cloudflare Pages HTTP 標頭配置
- **`.github/workflows/deploy.yml`**：GitHub Actions 自動部署配置

## 🔧 自訂配置

### 修改代理組

可編輯 `worker.js` 中的 `convertToClash` 函數來自訂代理組：

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### 自訂路由規則

修改 `rules` 陣列以新增自訂路由規則：

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 性能特性

- **全球 CDN** - Cloudflare 覆蓋全球的邊緣節點
- **快速響應** - 平均響應時間 < 100 毫秒
- **高可用性** - 99.9% 服務可用性
- **免費額度** - 每天 100,000 次請求

## 🔒 安全說明

- **資料隱私** - 訂閱資料僅在轉換過程中使用，不會被儲存
- **HTTPS 加密** - 所有通訊均通過 HTTPS 加密
- **開源透明** - 完整源碼公開，可自行審查

## 🤝 貢獻指南

歡迎提交 Issue 和 Pull Request！

1. Fork 本倉庫
2. 建立特性分支 (`git checkout -b feature/AmazingFeature`)
3. 提交更改 (`git commit -m 'Add some AmazingFeature'`)
4. 推送到分支 (`git push origin feature/AmazingFeature`)
5. 開啟 Pull Request

## 📝 更新日誌

### v1.1.0
- ✅ 新增 VLESS 協議支援（包括 Reality 安全傳輸）
- ✅ 改進協議相容性

### v1.0.0
- ✅ 基礎訂閱轉換功能
- ✅ 美觀的使用者介面
- ✅ Cloudflare Workers 支援
- ✅ 多協議支援（VMess、Shadowsocks、Trojan）
- ✅ 響應式設計
- ✅ 一鍵複製功能

## 📞 支援與回饋

如果您在使用過程中遇到問題或有建議，請：

1. 查看本 README 文件
2. 提交 [Issue](../../issues)
3. 發起 [Discussion](../../discussions)

## 📄 授權條款

本專案採用 MIT 授權條款 - 詳見 [LICENSE](LICENSE) 文件

## 🙏 感謝

- [Cloudflare Workers](https://workers.cloudflare.com/) - 提供邊緣運算平台
- [Clash](https://github.com/Dreamacro/clash) - 優秀的代理用戶端
- 所有貢獻者及使用者的支持

---

⭐ 如果這個專案對您有幫助，請給它一個 Star！ 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---