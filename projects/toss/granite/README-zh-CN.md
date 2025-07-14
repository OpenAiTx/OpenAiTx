# Granite &middot; [![Apache 2.0 License](https://img.shields.io/badge/license-Apache-blue.svg)](https://github.com/toss/slash/blob/main/LICENSE) [![NPM badge](https://img.shields.io/npm/v/@granite-js/react-native?logo=npm)](https://www.npmjs.com/package/@granite-js/react-native) [![codecov](https://codecov.io/gh/toss/granite/graph/badge.svg?token=LCP519I5BN)](https://codecov.io/gh/toss/granite)

Granite 是一个企业级的 React Native 框架，适用于带有棕地集成的微服务应用，拥有 200KB 的包大小和 AWS 就绪的基础设施。

- **向现有应用添加 React Native** - 轻松将 React Native 界面集成到您当前的 iOS 和 Android 应用中。
- **超小包体积** - 通过包拆分和智能优化创建 200KB 的微服务小包。
- **快速构建** - 使用 ESBuild 将 JavaScript 包构建时间控制在几秒内。
- **完整的 AWS 配置** - 完整的基础设施配置和全面的部署控制。
- **一键基础设施搭建** - 通过单个 CLI 命令设置 CDN 和基础设施。
- **简单的默认配置** - 预配置设置让您专注于开发，而非环境搭建。
- **全面的端到端测试** - 每个功能都包含端到端测试。
- **快速的原生构建** - 使用预构建框架保持原生构建时间短。（进行中）

## 快速开始

开始使用 Granite 很简单。首先，使用我们的 CLI 创建一个新的 Granite 应用：

```sh
npx create-granite-app@latest
```
一旦编写完您的 React Native 组件，使用一个命令构建您的应用：


```sh
npm run granite build
```
### 基础设施设置

Granite 使用 [Pulumi](https://www.pulumi.com/) 来简化基础设施的搭建。只需使用 `@granite-js/pulumi-aws` 编写几行代码，您就可以将整个 React Native 基础设施部署到 AWS：


```typescript
import * as pulumi from '@pulumi/pulumi';
import * as aws from '@pulumi/aws';
import { ReactNativeBundleCDN } from '@granite-js/pulumi-aws';

const config = new pulumi.Config();

new ReactNativeBundleCDN('myReactNativeBundleCDN', {
  bucketName: config.require('bucketName'),
  region: config.require('region'),
});
```
### 部署您的应用

只需一个命令即可将您的应用部署到生产环境。我们的 Forge 会处理剩下的工作——上传您的包并将其放到您的 CDN 上。


```sh
npm run granite-forge deploy --bucket your-s3-bucket-name
```
对于简单的分步指南，请访问我们的[快速入门指南](https://granite.run/guides/quick-start/create-your-app.html)。

## 贡献

我们欢迎社区中每个人的贡献。请阅读以下详细贡献指南。

[贡献指南](https://github.com/toss/granite/blob/main/.github/CONTRIBUTING.md)

## 许可证

Apache 2.0 © Viva Republica, Inc. 详情请参阅[许可证](./LICENSE)。

<a title="Toss" href="https://toss.im">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://static.toss.im/logos/png/4x/logo-toss-reverse.png">
    <img alt="Toss" src="https://static.toss.im/logos/png/4x/logo-toss.png" width="100">
  </picture>
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---