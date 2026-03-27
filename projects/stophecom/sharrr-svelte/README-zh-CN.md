# sharrr

**一次性端到端加密文件传输。**

以异步且最安全的方式传输文件（几乎不限大小）。

了解更多关于[技术实现](https://sharrr.com/about)。查看[sharrr与其他服务的比较](https://github.com/stophecom/sharrr-svelte/blob/main/src/routes/about/comparison.md)。

网站：[www.sharrr.com](https://sharrr.com)

帮助维持项目运行：[捐赠支持](https://donate.stripe.com/28oeV1gKP3bv4b6144)

## 开发

开始之前，在项目根目录添加一个 `.env` 文件。见下文。

```bash
# Initial installation
pnpm i

# Run dev server
pnpm run dev

# or start the server and open the app in a new browser tab
pnpm run dev -- --open
```

### DB

#### Prisma ORM

```bash
# Init primsa
npx prisma init

# Push schema to Postgres
npx prisma db push

# Open prisma studio locally
npx prisma studio

# After changes in DB are made. Should not be necessary.
# https://www.prisma.io/docs/concepts/components/prisma-client#4-evolving-your-application
npx prisma generate
```
#### Postgres 数据库

当前使用 Vercel Postgres 数据库，但也可以使用任何兼容 Prisma 的数据库。

### 测试


```bash
# Run unit tests with vitest
# Important: Node 19+ is required (Support for crypto modules)
pnpm run test:unit


# E2E tests with playwright
pnpm run test

```

### 构建

要创建应用程序的生产版本：

```bash
pnpm run build
```

你可以使用 `pnpm run preview` 预览生产版本。

### 维护

有一个名为 `cron-cleanup-files.yml` 的 Github 工作流，每天运行一次以清理旧文件。
更多信息请参见 `src/routes/api/v1/cron/+server.ts`。

你可以在本地触发该定时任务：

```bash
curl --request POST \
     --url 'http://localhost:3000/api/v1/cron' \
     --header 'Authorization: Bearer API_SECRET_KEY'

```

## 自托管

> **注意**
> 该项目当前运行在 Vercel，使用 S3 进行存储和 Vercel Postgres 数据库。自托管需要您替换这些第三方解决方案。

### 当前设置

#### 环境变量

```bash
# Postgres
POSTGRES_PRISMA_URL='postgres://'
POSTGRES_URL_NON_POOLING='postgres://' # Direct Connection

# S3 compatible object storage e.g. AWS
S3_ENDPOINT='<string>'
S3_ACCESS_KEY='<string>'
S3_SECRET_KEY='<string>'
PUBLIC_S3_BUCKET='<string>'

# Vercel specific, but can be easily replaced.
VERCEL_URL='http://localhost:3000'
PUBLIC_ENV='development' # preview/production

# Only used for cron jobs that run using Github Actions.
API_SECRET_KEY='<string>'
```

### 使用 Docker（开发中）

你需要编辑 `.env` 文件中的环境变量。

> **注意**
> 要在 Docker 中运行应用程序，你仍然需要连接你自己的数据库。如果你想运行自己的 S3 存储解决方案，也是如此。这部分尚未涵盖。

完成后，你可以执行以下操作：

```bash
# to start the docker container
sudo docker compose up -d

# to stop the docker container
sudo docker compose down

# to check logs
sudo docker logs sharrr
```
## 关于

关于作者：[stophe.com](https://stophe.com)

需要额外的隐私和安全选项？查看 [scrt.link](https://scrt.link)。

### 技术栈

- SvelteKit
- Tailwind CSS
- PostgreSQL（数据库）
- Prisma（ORM）
- Doppler（环境变量管理）

本项目已通过 BrowserStack 测试。

### 基础设施

- 网站和 Postgres 部署于 [Vercel](https://vercel.com/)
- 使用 [flow.swiss](https://flow.swiss) 的 S3 对象存储

### 许可

[MIT](https://opensource.org/license/mit/)（代码）

[CC BY-NC-ND](https://creativecommons.org/licenses/by-nc-nd/4.0/)（创意内容）



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---