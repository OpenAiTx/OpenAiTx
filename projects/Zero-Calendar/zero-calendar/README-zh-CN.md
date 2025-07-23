
# Zero Calendar

[![使用 Vercel 部署](https://vercel.com/button)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FZero-Calendar%2Fzero-calendar)

**一个面向未来调度的开源 AI 驱动日历**

## 什么是 Zero Calendar？
Zero Calendar 是一个开源 AI 日历解决方案，赋予用户智能管理日程的能力，同时集成 Google 日历及其他日历服务。我们的目标是通过 AI 代理现代化并改进调度，真正革新我们管理时间的方式。

## 为什么选择 Zero Calendar？
如今大多数日历服务要么是闭源的、数据需求庞大，要么缺乏智能功能。Zero Calendar 与众不同：

✅ **开源** – 无隐藏议程，完全透明。  
🦾 **AI 驱动** – 通过 AI 助手与大型语言模型提升调度体验。  
🔒 **数据隐私优先** – 您的日程，您的数据。Zero Calendar 不追踪、不收集、不出售您的数据。  
⚙️ **自托管自由** – 轻松运行属于您自己的日历应用。  
📅 **统一日历** – 连接多个日历服务，如 Google 日历、Outlook 等。  
🎨 **可定制的界面与功能** – 按照您的需求定制日历体验。  
🚀 **开发者友好** – 设计时考虑到扩展性和集成能力。  

## 技术栈
Zero Calendar 采用现代且可靠的技术构建：

- **前端**：Next.js、React、TypeScript、TailwindCSS、Shadcn UI  
- **后端**：Next.js API 路由，Server Actions  
- **数据库**：Vercel KV（Redis）  
- **认证**：NextAuth.js，Google OAuth  
- **AI**：AI SDK，Groq  

## 快速开始

### 先决条件
所需版本：  
- Node.js（v18 或更高）  
- npm（v9 或更高）或 pnpm（v8 或更高）  

运行应用前，您需要设置服务并配置环境变量。有关环境变量的详细信息，请参见环境变量部分。

### 安装选项

#### 快速入门指南

1. **克隆并安装**

```bash
# Clone the repository
git clone https://github.com/Zero-Calendar/zero-calendar.git
cd zero-calendar

# Install dependencies
npm install
# or
pnpm install
```
2. **设置环境**
- 将项目根目录下的 `.env.example` 复制为 `.env.local`

```bash
cp .env.example .env.local
```
- 配置您的环境变量（见下文）

3. **启动应用程序**
```bash
npm run dev
# or
pnpm dev
```
4. **在浏览器中打开**  
- 访问 http://localhost:3000  

### 环境变量  
在项目根目录下创建一个 `.env.local` 文件，并配置以下变量：


```
# NextAuth
NEXTAUTH_SECRET=     # Required: Secret key for authentication (generate with `openssl rand -hex 32`)
NEXTAUTH_URL=        # Required: URL of your application (http://localhost:3000 for local dev)

# Google OAuth (Required for Google Calendar integration)
GOOGLE_CLIENT_ID=    # Required for Google Calendar integration
GOOGLE_CLIENT_SECRET=# Required for Google Calendar integration

# Vercel KV (Redis)
KV_URL=              # Required: Vercel KV URL
KV_REST_API_URL=     # Required: Vercel KV REST API URL
KV_REST_API_TOKEN=   # Required: Vercel KV REST API token
KV_REST_API_READ_ONLY_TOKEN= # Required: Vercel KV REST API read-only token

# AI Integration
GROQ_API_KEY=        # Required for AI features
```


### Google OAuth 设置（Google 日历集成必需）

1. 访问 [Google Cloud Console](https://console.cloud.google.com/)
2. 创建一个新项目
3. 在您的 Google Cloud 项目中添加以下 API：
   - Google 日历 API
   - Google People API
4. 启用 Google OAuth2 API
5. 创建 OAuth 2.0 凭据（Web 应用类型）
6. 添加授权重定向 URI：
   - 开发环境：`http://localhost:3000/api/auth/callback/google`
   - 生产环境：`https://your-production-url/api/auth/callback/google`
7. 添加到 `.env.local`：

```
GOOGLE_CLIENT_ID=your_client_id
GOOGLE_CLIENT_SECRET=your_client_secret
```
8. 将自己添加为测试用户：
   - 进入 OAuth 同意屏幕
   - 在“测试用户”下点击“添加用户”
   - 添加你的邮箱并点击“保存”

> **警告**
>
> Google Cloud Console 中授权的重定向 URI 必须与你在 `.env.local` 中配置的完全匹配，包括协议（http/https）、域名和路径。

### Vercel KV 设置

1. 如果没有，创建一个 Vercel 账号
2. 安装 Vercel CLI：`npm i -g vercel`
3. 登录 Vercel：`vercel login`
4. 关联你的项目：`vercel link`
5. 从 Vercel 仪表盘创建一个 KV 数据库
6. 将 KV 环境变量添加到项目中：`vercel env pull .env.local`

## 功能

- 🤖 **AI 助手**：使用自然语言与日历互动
- 🔄 **谷歌日历集成**：与现有谷歌日历同步
- 🎨 **可定制界面**：暗模式和个性化设置
- 🔄 **重复事件**：全面支持带例外的重复事件
- 🌐 **时区管理**：全球调度的完整时区支持
- 📤 **导入/导出**：以 ICS 和 CSV 格式导入导出日历数据
- ⌨️ **键盘快捷键**：高效日历管理的高级用户快捷键
- 🔔 **事件管理**：轻松创建、编辑和删除事件
- 🔒 **安全认证**：支持邮箱/密码或谷歌 OAuth 登录

### 键盘快捷键

Zero Calendar 为高级用户提供键盘快捷键：

| 快捷键 | 操作 |
|----------|--------|
| `←` | 上个月 |
| `→` | 下个月 |
| `T` | 跳转到今天 |
| `N` | 新建事件 |
| `?` | 显示快捷键 |
| `/` | 聚焦搜索 |
| `M` | 切换到月视图 |
| `W` | 切换到周视图 |
| `D` | 切换到日视图 |
| `A` | 切换 AI 助手 |
| `S` | 进入设置 |
| `Esc` | 关闭对话框 |

## 贡献
请参考[贡献指南](https://raw.githubusercontent.com/Zero-Calendar/zero-calendar/main/.github/CONTRIBUTING.md)。

## 许可证

Zero Calendar 是开源软件，基于[GPLv3 许可证](https://raw.githubusercontent.com/Zero-Calendar/zero-calendar/main/LICENSE.md)授权。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---