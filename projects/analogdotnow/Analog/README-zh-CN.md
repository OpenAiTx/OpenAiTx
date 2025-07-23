
<p align="center">
  <h1 align="center">Analog</h1>
  <p align="center">改变一切的开源日历</p>
</p>

## 快速开始

要在本地机器上运行 Analog，请按照以下步骤操作：

### 前提条件

确保已安装以下内容：

- **Bun**：一个快速的 JavaScript 运行时、包管理器、打包器和测试运行器。
  - [安装指南](https://bun.sh/docs/installation)
- **Docker Desktop**：用于运行 PostgreSQL 数据库。
  - [安装指南](https://www.docker.com/products/docker-desktop/)

### 设置

1.  **克隆代码库**：


    ```bash
    git clone https://github.com/jeanmeijer/analog.git
    cd analog
    ```
2.  **安装依赖项**：


    ```bash
    bun install
    ```
3.  **配置环境变量**：
    复制示例环境文件：


    ```bash
    cp .env.example .env
    ```
    然后，打开新创建的 `.env` 文件。您将看到 `DATABASE_URL` 和 `BETTER_AUTH_URL` 的默认值。您需要设置以下内容：
    - `BETTER_AUTH_SECRET`：通过在终端运行 `openssl rand -hex 32` 生成一个安全的密钥。
      <br/><br/>

4.  **设置 Google OAuth**：

- `GOOGLE_CLIENT_ID` 和 `GOOGLE_CLIENT_SECRET`：
  1. 在 [Google Cloud Console](https://console.cloud.google.com/) 创建一个 Google 项目。
  2. 按照 [Better Auth 文档中的第 1 步](https://www.better-auth.com/docs/authentication/google) 设置 Google OAuth 凭据。
  3. 通过访问 [Google Cloud Console APIs](https://console.cloud.google.com/apis/library/calendar-json.googleapis.com) 并为项目启用 Google Calendar API。
  4. 将自己添加为测试用户：
     - 找到 Google OAuth 的 [`Audience`](https://console.cloud.google.com/auth/audience) 标签页。
     - 在“测试用户”下，点击“添加用户”。
     - 在文本框中添加您的邮箱地址，然后点击“保存”。

5. **设置 Microsoft OAuth**（可选）：

- `MICROSOFT_CLIENT_ID` 和 `MICROSOFT_CLIENT_SECRET`：
  1. 访问 [Microsoft Azure 门户](https://portal.azure.com/)，然后导航至 Microsoft Entra ID → 应用注册。
  2. 注册一个新应用并设置重定向 URI（`http://localhost:3000/api/auth/callback/microsoft`）。
  3. 复制应用程序（客户端）ID，并在“证书和密钥”下创建新的客户端密钥。
  4. 前往 API 权限，点击 + 添加权限，选择 Microsoft Graph → 委托的权限，添加：
     - `Calendars.Read`，`Calendars.ReadWrite`，`User.Read`，`offline_access`

### 数据库设置

Analog 使用 PostgreSQL 和 Drizzle ORM。您可以使用 Docker 运行数据库：

1.  **启动 PostgreSQL 数据库容器**：


    ```bash
    bun run docker:up
    ```


    此命令使用 `docker-compose.yml` 启动一个 PostgreSQL 容器。

2.  **初始化数据库**：
    一旦数据库容器运行且状态良好，初始化数据库：


    ```bash
    bun run db:push
    ```
### 运行应用程序

在设置好环境和数据库后，您可以启动开发服务器：


```bash
bun run dev
```


该应用现已可通过浏览器访问，网址为 [http://localhost:3000](http://localhost:3000)。

## 技术栈

- **Web**：Next.js、TypeScript、Tailwind v4、Bun、tRPC、TanStack Query、shadcn/ui
- **数据库**：Drizzle 与 PostgreSQL
- **认证**：Better Auth 用于 Google OAuth

## 路线图

进行中。

## 贡献

有关如何为此项目做出贡献的详细信息，请参阅 [CONTRIBUTING.md](https://raw.githubusercontent.com/analogdotnow/Analog/main/./CONTRIBUTING.md)。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---