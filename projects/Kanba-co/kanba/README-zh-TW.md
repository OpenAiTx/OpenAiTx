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

<div align="center">
  <br />
<br />
<a href="https://kanba.co">
  <img alt="Kanba" src="https://www.kanba.co/dark-hero.png" style=" width: 800px " />
</a>
    <br />
<br />
</div>

<div align="center">
  <br />
<br />
<a href="https://vercel.com/oss">
  <img alt="Vercel OSS Program" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# 開源、輕量級的 Trello 替代方案，專為創作者與獨立駭客打造。

專注於簡單、快速及可擴展性。
採用現代技術棧構建：Tailwind CSS、shadcn/ui、Supabase、Stripe 整合。
支援無限專案、團隊協作、深色／淺色模式，並提供無縫的用戶體驗。
非常適合希望完全掌控而不需多餘複雜性的個人開發者及小型團隊。

## 🌟 如果你覺得這個專案有用，請幫忙點顆星！讓更多人可以發現它。

# 部署指南

## 概述
本應用現已採用本地 Next.js API 路由來取代 Supabase Edge Functions 以整合 Stripe。這使得部署更簡單，並可直接使用標準 .env 檔案進行設定。

## 環境變數設置

### 1. 建立 .env.local 檔案
將 `.env.example` 複製為 `.env.local`，並填入你的實際值：


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
- `NEXT_PUBLIC_SITE_URL` - 您的網站網址（用於正式環境）
- `NEXTAUTH_URL` - 您的網站網址（同上）
- `NEXTAUTH_SECRET` - NextAuth 用的隨機密鑰

## 本地開發

1. 安裝相依套件：
```bash
npm install
```

2. 在 `.env.local` 中設置您的環境變數

3. 運行開發伺服器：
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
   透過 Vercel 控制台或 CLI 新增所有環境變數

3. **Stripe Webhook 設定：**
   - Webhook 指向：`https://your-domain.vercel.app/api/stripe/webhook`

## API 端點

應用程式現在使用以下本地 API 路由：

- `POST /api/stripe/checkout` - 建立 Stripe 結帳會話
- `POST /api/stripe/webhook` - 處理 Stripe webhook 事件

## 本地 API 路由的好處

1. **更簡單的部署** - 無需部署獨立的邊緣函式
2. **環境變數** - 標準 .env 檔案支援
3. **更好的除錯** - 更容易在本地除錯
4. **框架整合** - 與 Next.js 更佳整合
5. **無廠商綁定** - 可部署至任何支援 Next.js 的平台

## 疑難排解

1. **Webhook 問題：**
   - 確保 `STRIPE_WEBHOOK_SECRET` 與 Stripe webhook 端點一致
   - 檢查 Stripe 控制台中的 webhook 日誌
   - 驗證 webhook URL 是否正確

2. **環境變數：**
   - 確保所有必要變數均已設定
   - 檢查變數名稱有無拼寫錯誤
   - 驗證 Supabase 服務角色金鑰權限正確

3. **CORS 問題：**
   - API 路由包含正確的 CORS 標頭
   - 如有需要，確保您的網域已列入白名單

## 安全注意事項

- 絕不可將 `STRIPE_SECRET_KEY` 或 `SUPABASE_SERVICE_ROLE_KEY` 暴露給用戶端
- 僅對用戶端變數使用 `NEXT_PUBLIC_` 前綴
- 定期輪替 webhook 密鑰
- 在 Stripe 控制台監控 webhook 傳遞



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---