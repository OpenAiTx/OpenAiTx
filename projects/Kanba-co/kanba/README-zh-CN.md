<div align="right">
  <details>
    <summary >🌐 语言</summary>
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
# 一个为创作者和独立黑客设计的开源、轻量级 Trello 替代品。

专注于简洁、速度和可扩展性。
采用现代技术栈构建：Tailwind CSS、shadcn/ui、Supabase、Stripe 集成。
支持无限项目、团队协作、深色/浅色模式和无缝用户体验。
非常适合希望完全掌控、无需复杂性的独立开发者和小团队。

## 🌟 如果你觉得这个项目有用，请考虑为它加个星！这样也能帮助更多人发现它。

# 部署指南

## 概述
本应用现已采用本地 Next.js API 路由来替代 Supabase Edge Functions 进行 Stripe 集成。这让部署更简单，并允许你使用标准的 .env 文件进行配置。

## 环境变量配置

### 1. 创建 .env.local 文件
将 `.env.example` 复制为 `.env.local`，并填写你的实际值：


```bash
cp .env.example .env.local
```
### 2. 必需的环境变量

#### Supabase 配置
- `NEXT_PUBLIC_SUPABASE_URL` - 你的 Supabase 项目 URL
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - 你的 Supabase 匿名密钥
- `SUPABASE_SERVICE_ROLE_KEY` - 你的 Supabase 服务角色密钥（仅服务器端）

#### Stripe 配置（可选）
- `STRIPE_SECRET_KEY` - 你的 Stripe 秘密密钥（仅服务器端）
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - 你的 Stripe 可发布密钥
- `STRIPE_WEBHOOK_SECRET` - 你的 Stripe webhook 秘密

#### 站点配置
- `NEXT_PUBLIC_SITE_URL` - 你的站点 URL（生产环境）
- `NEXTAUTH_URL` - 你的站点 URL（同上）
- `NEXTAUTH_SECRET` - 用于 NextAuth 的随机密钥

## 本地开发

1. 安装依赖项：

```bash
npm install
```
2. 在 `.env.local` 中设置你的环境变量

3. 运行开发服务器：

```bash
npm run dev
```


4. 使用 Stripe CLI 在本地测试 Stripe webhook：

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```


## 生产部署


### Vercel 部署

1. **部署到 Vercel：**

```bash
npx vercel
```
2. **环境变量：**  
   通过 Vercel 控制面板或 CLI 添加所有环境变量  

3. **Stripe Webhook 设置：**  
   - 将 webhook 指向：`https://your-domain.vercel.app/api/stripe/webhook`  

## API 端点  

应用现在使用以下本地 API 路由：  

- `POST /api/stripe/checkout` - 创建 Stripe 结账会话  
- `POST /api/stripe/webhook` - 处理 Stripe webhook 事件  

## 本地 API 路由的优点  

1. **部署更简单** - 无需部署独立的边缘函数  
2. **环境变量** - 支持标准的 .env 文件  
3. **更好的调试** - 本地调试更方便  
4. **框架集成** - 与 Next.js 集成更好  
5. **无供应商锁定** - 可部署到支持 Next.js 的任何平台  

## 故障排除  

1. **Webhook 问题：**  
   - 确保 `STRIPE_WEBHOOK_SECRET` 与你的 Stripe webhook 端点匹配  
   - 在 Stripe 控制面板检查 webhook 日志  
   - 验证 webhook URL 是否正确  

2. **环境变量：**  
   - 确保所有必需变量均已设置  
   - 检查变量名是否有拼写错误  
   - 验证 Supabase 服务角色密钥具有适当权限  

3. **CORS 问题：**  
   - API 路由包含正确的 CORS 头  
   - 如有需要，确保你的域名已列入白名单  

## 安全注意事项  

- 切勿向客户端暴露 `STRIPE_SECRET_KEY` 或 `SUPABASE_SERVICE_ROLE_KEY`  
- 仅对客户端变量使用 `NEXT_PUBLIC_` 前缀  
- 定期更换 webhook 密钥  
- 在 Stripe 控制面板监控 webhook 发送情况  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---