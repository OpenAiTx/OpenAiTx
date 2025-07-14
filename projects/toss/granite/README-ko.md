# Granite &middot; [![Apache 2.0 License](https://img.shields.io/badge/license-Apache-blue.svg)](https://github.com/toss/slash/blob/main/LICENSE) [![NPM badge](https://img.shields.io/npm/v/@granite-js/react-native?logo=npm)](https://www.npmjs.com/package/@granite-js/react-native) [![codecov](https://codecov.io/gh/toss/granite/graph/badge.svg?token=LCP519I5BN)](https://codecov.io/gh/toss/granite)

Granite는 브라운필드 통합, 200KB 번들 크기, AWS 준비 인프라를 갖춘 엔터프라이즈급 React Native 마이크로서비스 앱 프레임워크입니다.

- **기존 앱에 React Native 추가** - 현재 iOS 및 Android 앱에 React Native 화면을 쉽게 통합하세요.
- **작은 번들** - 번들 분할과 스마트 최적화를 통해 200KB의 작은 마이크로서비스 번들을 만드세요.
- **빠른 빌드** - ESBuild를 사용하여 JavaScript 번들 빌드 시간을 단 몇 초로 유지하세요.
- **완전한 AWS 설정** - 전체 배포 제어가 가능한 인프라 구성 완성.
- **원클릭 인프라** - 단일 CLI 명령으로 CDN 및 인프라를 설정하세요.
- **간단한 기본값** - 사전 구성된 설정으로 구축에 집중하고 설정에 신경 쓰지 마세요.
- **포괄적인 종단 간 테스트** - 모든 기능에 종단 간 테스트가 포함되어 있습니다.
- **빠른 네이티브 빌드** - 사전 빌드된 프레임워크로 네이티브 빌드 시간을 빠르게 유지하세요. (작업 중)

## 시작하기

Granite 시작은 간단합니다. 먼저, CLI를 사용하여 새 Granite 앱을 만드세요:

```sh
npx create-granite-app@latest
```
React Native 컴포넌트를 작성했으면, 한 번의 명령어로 앱을 빌드하세요:


```sh
npm run granite build
```
### 인프라 설정

Granite는 인프라 설정을 간단하게 하기 위해 [Pulumi](https://www.pulumi.com/)를 사용합니다. `@granite-js/pulumi-aws`를 사용한 몇 줄의 코드만으로 전체 React Native 인프라를 AWS에 배포할 수 있습니다:


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
### 앱 배포

한 번의 명령어로 앱을 프로덕션에 배포하세요. 우리의 Forge가 나머지를 처리합니다 - 번들을 업로드하고 CDN에 올리는 작업을요.


```sh
npm run granite-forge deploy --bucket your-s3-bucket-name
```
간단한 단계별 가이드는 [시작 가이드](https://granite.run/guides/quick-start/create-your-app.html)에서 확인하세요. 

## 기여하기

커뮤니티 모든 분들의 기여를 환영합니다. 자세한 기여 가이드는 아래를 참고하세요.

[CONTRIBUTING](https://github.com/toss/granite/blob/main/.github/CONTRIBUTING.md)

## 라이선스

Apache 2.0 © Viva Republica, Inc. 자세한 내용은 [LICENSE](./LICENSE)를 참조하세요.

<a title="Toss" href="https://toss.im">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://static.toss.im/logos/png/4x/logo-toss-reverse.png">
    <img alt="Toss" src="https://static.toss.im/logos/png/4x/logo-toss.png" width="100">
  </picture>
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---