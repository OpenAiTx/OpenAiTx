# httpc
httpc 是一个用于构建基于函数的 API 的 JavaScript/TypeScript 框架，具有最少的代码量和端到端的类型安全。
- [文档和教程](https://httpc.dev/docs)
- [社区](https://httpc.dev/discord)
- [问题和功能请求](https://httpc.dev/issues)

## 快速浏览
你只需编写函数并导出它们。无需担心服务器如何执行它们。
```ts
function add(a: number, b: number) {
    return a + b;
}

function greet(name: string) {
    return `Hello ${name}`;
}

export default {
    add,
    greet,
}
```

从客户端你可以像调用普通的 JavaScript 函数一样调用服务器函数，语法自然。
```ts
import createClient from "@your-package/api-client";

const client = createClient({
    endpoint: "http://api.domain.com"
});

let result = await client.add(1, 2);
// result: 3

let message = await client.greet("Edith");
// message: "Hello Edith"
```

## 关键原则
**httpc** 是对标准 HTTP 协议的抽象。使用 **httpc**，您可以构建一个使用函数、参数和返回值进行交互的 API，而不是使用 HTTP 动词、头信息、资源路径、数据序列化……

**httpc** 框架隐藏了底层 HTTP 的所有复杂性，同时让您专注于重要的内容：函数逻辑。

## 主要特性
### 中间件
通过中间件运行公共逻辑。

```ts
import { httpCall } from "@httpc/server";

const getPostById = httpCall(
    Authenticated(),    // <-- authentication check
    Validate(String),   // <-- parameters validation
    Cache("5m"),        // <-- result caching
    async (postId: string) => {
        const post = await db.select("posts").where("id", postId);
        if (!post) {
            throw new NotFoundError();
        }

        return post;
    }
);
```

### 上下文无处不在
在应用程序的任何地方访问请求上下文。无论是在处理程序、中间件还是服务逻辑中，上下文始终可用，无需传递参数。
```ts
async function getPosts() {
    const { user } = useContext();

    let category = "news";
    if (user) {
        category = user.preferredCategory;
        trace("Getting user preferred posts");
    }
    
    return await db.select("posts").where("category", category);
}

function trace(message: string) {
    const { requestId } = useContext();
    console.log(`[req:${requestId}] ${message}`);
}
```

### Hooks
Hooks 封装了围绕请求上下文的通用逻辑。根据惯例，hooks 采用 `use` 前缀。
```ts
async function addNewComment(postId: string, message: string) {
    const user = useUser();

    if (!useIsAuthorized("comment:create")) {
        throw new ForbiddenError("Cannot add comments");
    }

    return await db.createComment({
        userId: user.id,
        postId,
        message
    });
}
```
**@httpc/kit** 提供了多个内置钩子，用于缓存数据、执行授权检查、进行事务处理等…

### 无服务器
您可以在无服务器环境中托管完整的 **httpc** API，例如 Vercel、AWS Lambda 或 Netlify 函数。
这带来了部署单个无服务器函数以处理整个 API 的优势。

例如，使用 Vercel，您可以公开所有的 API 函数：
```ts
//file: api/index.ts

import { createHttpCVercelAdapter } from "@httpc/adapter-vercel";
import calls from "../calls";

export default createHttpCVercelAdapter({
    calls,
    log: "info"
});
```

然后，您可以从页面调用 API 函数，具备完整的类型检查：
```ts
//file: pages/home.tsx

import { createClient, ClientDef } from "@httpc/client";
import { useQuery, useMutation } from "react-query";
import type calls from "../calls"; // <-- import calls definition

// create a typed client
const client = createClient<ClientDef<typeof calls>>();

export default function Home() {
  const posts = useQuery(["posts"], () => client.posts.getLatest());

  return (
    <div class="container">
      {posts.data.map(post =>
        <div class="post">
          <h2>{post.title}</h2>
          <p>{post.text}</p>
        </div>
      )}
    </div>
  );
}
```    

### 广泛的类型安全
自定义内置对象以满足您的需求，同时保持自动完成和类型检查的正常工作。

您可以扩展请求上下文：
```ts
/// <reference types="@httpc/kit/env" />

interface IHttpCContext {
    // example custom property
    environment: string

    // other custom properties here
    // ...
}
```
有许多实体可供扩展。例如，您可以通过自定义属性重新定义用户对象：
```ts
interface IUser {
    firstName: string
    lastName: string
}
```
内置函数和钩子将获取自定义定义，并允许您在类型检查下使用它们。
```ts
const { firstName } = useUser();
```

### 自定义客户端生成
使用 **@httpc/cli**，您可以为您的 API 生成特定的客户端。生成的客户端确保类型安全，并提供开发者熟悉的自然语法，带来流畅的体验。
```ts
const user = await client.users.search("some@email.com");
const posts = await client.posts.getByUser(user.id);
const newComment = await client.posts.addComment(posts[0].id, {
    text: "Hello",
    userId: user.id
});
```

### 超越 httpc
httpc 服务器不仅限于函数调用。它可以处理浏览器表单提交、Webhook 回调、标准重定向……以及一般的任何 http 请求。通过使用 `Parsers`（内置了许多），你可以自定义服务器如何处理请求。

处理标准 http 请求在你无法控制客户端的场景中至关重要。一个 **httpc 服务器** 允许你响应函数调用和常见的 http 请求。


## httpc 生态
**@httpc/server**：httpc 核心组件，允许通过标准 http 协议进行函数调用

**@httpc/client**：供消费者安全地与 httpc 服务器暴露的函数交互的类型化接口

**@httpc/kit**：丰富的内置组件工具箱，用于管理常见用例和业务关注点，如认证、验证、缓存和日志

**@httpc/cli**：用于设置项目、生成客户端、管理版本和辅助常见任务的命令行工具

**@httpc/adapter-\***：各种[适配器](https://httpc.dev/docs/adapters)，可在 vercel、netlify functions、aws lambda 等环境中托管 httpc API



## 项目状态
**httpc** 处于实验阶段。它还处于初期阶段。你可以尝试使用，或在业余项目中采用。但尚未准备好用于生产环境。
<br />
API 尚不稳定。将会有破坏性变更。
<br />
**httpc** 正在积极开发中。你可以查看[更新日志](https://httpc.dev/changelog)和[路线图](https://httpc.dev/roadmap)了解未来功能。


## 参与方式
### 社区
你可以加入[Discord](https://httpc.dev/discord)，关注开发动态，讨论贡献，获得支持或请求帮助。参与[Github 讨论](https://httpc.dev/discuss)也很不错。

### 提交问题
对于任何错误、功能请求或建议，你可以[提交问题](https://httpc.dev/issues/new)。所有问题均可在[Github](https://httpc.dev/issues)查看。

### 贡献代码
欢迎所有贡献。任何 PR、问题和反馈都受到欢迎。查看[贡献指南](https://httpc.dev/contribute)。


## 许可证
MIT © [Giuseppe La Torre](https://github.com/giuseppelt)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---