<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 開源、輕量級的 Trello 替代方案，專為創客與獨立駭客設計。

專注於簡單、快速與高擴展性。
採用現代技術棧構建：Tailwind CSS、shadcn/ui、Supabase、Stripe 集成。
支援無限專案、團隊協作、深色/淺色模式，以及流暢的用戶體驗。
非常適合想要完全掌控且不需繁瑣功能的獨立開發者與小型團隊。

## 🌟 如果你覺得這個專案有用，請考慮給它一顆星！這也能幫助更多人發現它。

# 部署指南

## 概覽
本應用現在使用本地 Next.js API 路由來取代 Supabase Edge Functions 進行 Stripe 集成。這讓部署更簡單，且可直接使用標準 .env 檔案進行設定。

## 環境變數設置

### 1. 建立 .env.local 檔案
複製 `.env.example` 為 `.env.local` 並填入你的實際值：


```bash
cp .env.example .env.local
```
### 2. 必需的環境變數

#### Supabase 設定
- `NEXT_PUBLIC_SUPABASE_URL` - 您的 Supabase 專案網址
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - 您的 Supabase 匿名金鑰
- `SUPABASE_SERVICE_ROLE_KEY` - 您的 Supabase 服務角色金鑰（僅限伺服器端）

#### Stripe 設定（可選）
- `STRIPE_SECRET_KEY` - 您的 Stripe 密鑰（僅限伺服器端）
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - 您的 Stripe 公開金鑰
- `STRIPE_WEBHOOK_SECRET` - 您的 Stripe webhook 密鑰

#### 網站設定
- `NEXT_PUBLIC_SITE_URL` - 您的網站網址（用於生產環境）
- `NEXTAUTH_URL` - 您的網站網址（與上方相同）
- `NEXTAUTH_SECRET` - 一組隨機的 NextAuth 密鑰

## 本地開發

1. 安裝相依套件：

```bash
npm install
```
2. 在 `.env.local` 中設置你的環境變數

3. 啟動開發伺服器：

```bash
npm run dev
```
4. 使用 Stripe CLI 在本地測試 Stripe webhook：

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## 生產部署


### Vercel 部署

1. **部署到 Vercel：**

```bash
npx vercel
```
2. **環境變數：**
   透過 Vercel 儀表板或 CLI 新增所有環境變數

3. **Stripe Webhook 設定：**
   - 將 webhook 指向：`https://your-domain.vercel.app/api/stripe/webhook`

## API 端點

應用程式現在使用以下本地 API 路由：

- `POST /api/stripe/checkout` - 建立 Stripe 結帳會話
- `POST /api/stripe/webhook` - 處理 Stripe webhook 事件

## 本地 API 路由的優點

1. **更簡單的部署** - 無需部署額外的 edge functions
2. **環境變數** - 標準 .env 檔案支援
3. **更佳除錯** - 更容易在本地除錯
4. **框架整合** - 與 Next.js 更好整合
5. **無廠商綁定** - 可部署至任何支援 Next.js 的平台

## 疑難排解

1. **Webhook 問題：**
   - 確保 `STRIPE_WEBHOOK_SECRET` 與你的 Stripe webhook 端點相符
   - 檢查 Stripe 儀表板中的 webhook 日誌
   - 確認 webhook URL 正確

2. **環境變數：**
   - 確保所有必要變數已設置
   - 檢查變數名稱是否有拼寫錯誤
   - 確認 Supabase 服務角色金鑰有正確權限

3. **CORS 問題：**
   - API 路由包含正確的 CORS 標頭
   - 如有需要，確保你的網域已列入白名單

## 安全注意事項

- 絕對不要將 `STRIPE_SECRET_KEY` 或 `SUPABASE_SERVICE_ROLE_KEY` 暴露給前端
- 僅對客戶端變數使用 `NEXT_PUBLIC_` 前綴
- 定期輪替你的 webhook 密鑰
- 在 Stripe 儀表板監控 webhook 傳送情況



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---