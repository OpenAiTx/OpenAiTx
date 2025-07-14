# Granite &middot; [![Apache 2.0 License](https://img.shields.io/badge/license-Apache-blue.svg)](https://github.com/toss/slash/blob/main/LICENSE) [![NPM badge](https://img.shields.io/npm/v/@granite-js/react-native?logo=npm)](https://www.npmjs.com/package/@granite-js/react-native) [![codecov](https://codecov.io/gh/toss/granite/graph/badge.svg?token=LCP519I5BN)](https://codecov.io/gh/toss/granite)

Granite 是一個企業級的 React Native 框架，適用於具備棕地整合的微服務應用，具備 200KB 的包大小以及 AWS 準備好的基礎設施。

- **將 React Native 添加至現有應用** - 輕鬆將 React Native 畫面整合進您現有的 iOS 和 Android 應用。
- **極小的包大小** - 使用包拆分和智慧優化，打造僅 200KB 的微服務包。
- **快速構建** - 利用 ESBuild 將 JavaScript 包的構建時間保持在數秒內。
- **完整的 AWS 設定** - 提供完整的基礎設施設定與部署控制。
- **一鍵基礎設施** - 使用單一 CLI 指令即可設定 CDN 和基礎設施。
- **簡單的預設值** - 預先配置的設定讓您專注於開發，而非設定。
- **全面的端對端測試** - 每項功能皆附帶端對端測試。
- **快速原生構建** - 利用預建框架保持原生構建時間快速。(進行中)

## 開始使用

開始使用 Granite 非常簡單。首先，使用我們的 CLI 建立一個新的 Granite 應用：

```sh
npx create-granite-app@latest
```
一旦你完成了 React Native 元件的編寫，只需一個指令即可建置你的應用程式：


```sh
npm run granite build
```
### 基礎設施設置

Granite 使用 [Pulumi](https://www.pulumi.com/) 來簡化基礎設施設置。只需使用 `@granite-js/pulumi-aws` 撰寫幾行程式碼，即可將整個 React Native 基礎設施部署到 AWS：


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
### 部署您的應用程式

只需一條命令即可將您的應用程式部署到生產環境。我們的 Forge 會處理其餘工作——上傳您的套件並將其放到您的 CDN 上。


```sh
npm run granite-forge deploy --bucket your-s3-bucket-name
```
欲獲得簡單的逐步指南，請參閱我們的 [快速入門指南](https://granite.run/guides/quick-start/create-your-app.html)。

## 貢獻指南

我們歡迎社群中每個人的貢獻。請參閱下方詳細的貢獻指南。

[CONTRIBUTING](https://github.com/toss/granite/blob/main/.github/CONTRIBUTING.md)

## 授權條款

Apache 2.0 © Viva Republica, Inc. 詳情請見 [LICENSE](./LICENSE)。

<a title="Toss" href="https://toss.im">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://static.toss.im/logos/png/4x/logo-toss-reverse.png">
    <img alt="Toss" src="https://static.toss.im/logos/png/4x/logo-toss.png" width="100">
  </picture>
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---