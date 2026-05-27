# nx-serverless-monorepo

[![serverless](http://public.serverless.com/badges/v3.svg)](http://www.serverless.com)
[![](https://img.shields.io/badge/monorepo-Nx-blue)](https://nx.dev/)
![esbuild](https://badges.aleen42.com/src/esbuild.svg)
![npm peer dependency version (scoped)](https://img.shields.io/npm/dependency-version/eslint-config-prettier/peer/eslint)
![code style: prettier](https://img.shields.io/badge/code_style-prettier-ff69b4.svg?style=flat-square)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/sudokar/nx-serverless/blob/master/LICENSE)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/Naereen/badges.svg)](http://isitmaintained.com/project/Naereen/badges 'Percentage of issues still open')
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://github.com/sudokar/nx-serverless)
![Maintained](https://img.shields.io/maintenance/yes/2024.svg)

![TypeScript](https://img.shields.io/badge/typescript-%23007ACC.svg?style=for-the-badge&logo=typescript&logoColor=white)
![GitHub Actions](https://img.shields.io/badge/github%20actions-%232671E5.svg?style=for-the-badge&logo=githubactions&logoColor=white)

[Nx](https://nx.dev) 모노레포 툴킷 🛠 과 `aws-nodejs-typescript` 서버리스 템플릿을 사용한 [Serverless framework](https://www.serverless.com/)용 모노레포 스타일의 최신 보일러플레이트 또는 템플릿 프로젝트

## 목차

- [포함된 내용](#whats-included)
- [템플릿 구조](#template-layout)
- [필수 조건](#prerequisites)
- [사용법](#usage)
- [추가 도움말](#further-help)
- [Nx 클라우드](#nx-cloud)
- [기여](#contribution)
- [지원](#support)
- [유지 관리자](#maintainer)
- [라이선스](#license)

## 포함된 내용

- 최신 버전의 Nx와 Serverless 프레임워크를 사용한 템플릿 프로젝트 구조
- Serverless 프레임워크 파일과 관련 Nx 구성을 생성하는 손쉬운 워크스페이스 생성기
- AWS 프로바이더로 구성되어 있으며, 다른 클라우드 프로바이더에도 쉽게 적용 가능

## 템플릿 구조

```shell
.
├── stacks/    # stack for each serverless configuration/template and its associated files
├── libs/      # shared libraries
├── tools/
├── README.md
├── jest.config.js
├── jest.preset.js
├── nx.json
├── package.json
├── serverless.base.ts  # base configuration for serverless
├── tsconfig.base.json
├── workspace.json
├── .editorconfig
├── .eslintrc.json
├── .gitignore
├── .husky              # git hooks
├── .nvmrc
├── .prettierignore
├── .prettierrc
```
## 전제 조건

- [Nodejs](https://nodejs.org/) `protip: nvm 사용`

  > :warning: **버전**: `lts/iron (v20)`. [nvm](https://github.com/nvm-sh/nvm)을 사용하는 경우, `nvm use`를 실행하여 로컬과 람다 런타임에서 동일한 Node 버전을 사용하고 있는지 확인하세요.

- :package: 패키지 관리자

  - [Yarn](https://yarnpkg.com)

- 💅 코드 포맷 플러그인

  - [Eslint](https://eslint.org/)
  - [Prettier](https://prettier.io/)
  - [EditorConfig](https://editorconfig.org/)

  > 선호하는 코드 편집기에서 위 도구 목록에 대한 플러그인을 설치하세요.

## 사용법

선호하는 패키지 관리자에 따라 아래 지침을 따라 서버리스 스택을 빌드하고 배포하세요.

- **프로젝트 의존성 설치**


  ```shell
  yarn install
  ```
- **새 스택 생성**


  ```shell
  nx g serverless <STACK_NAME>
  ```

  > `-d` 또는 `--dry-run` 플래그를 사용하여 시뮬레이션 실행

- **새 라이브러리 생성**

  ```shell
  nx g @nx/node:lib --skipBabelrc --tags lib <LIBRARY_NAME>
  ```
  > `-d` 또는 `--dry-run` 플래그를 사용하여 실행하면 dry run을 수행합니다.

- **스택 패키징**

  - 단일 스택을 패키징하려면


    ```shell
    nx run <STACK_NAME>:build --stage=<STAGE_NAME>
    ```

  - 변경으로 인해 영향을 받는 패키지 스택을 패키징하기 위해서

    ```shell
    nx affected:build --stage=<STAGE_NAME>
    ```

  - 모든 스택을 패키징하려면

    ```shell
    nx run-many --target=build --stage=<STAGE_NAME>
    ```
- **클라우드에 스택 배포**

  - 단일 스택을 배포하려면


    ```shell
    nx run <STACK_NAME>:deploy --stage=<STAGE_NAME>
    ```
  - 변경 사항의 영향을 받는 스택을 배포하려면


    ```shell
    nx affected:deploy --stage=<STAGE_NAME>
    ```
  - 모든 스택을 배포하려면


    ```shell
    nx run-many --target=deploy --all --stage=<STAGE_NAME>
    ```

- **클라우드에서 스택 제거**

  - 단일 스택을 제거하려면

    ```shell
    nx run <STACK_NAME>:remove --stage=<STAGE_NAME>
    ```

  - 변경으로 영향을 받은 스택을 제거하려면

    ```shell
    nx affected:remove --stage=<STAGE_NAME>
    ```
  - 모든 스택 제거하기


    ```shell
    nx run-many --target=remove --all --stage=<STAGE_NAME>
    ```

- **테스트 실행**

  - 단일 스택에서 테스트 실행하기

    ```shell
    nx run <STACK_NAME>:test --stage=<STAGE_NAME>
    ```

  - 변경에 의해 영향을 받는 테스트를 실행하려면

    ```shell
    nx affected:test --stage=<STAGE_NAME>
    ```

  - 모든 스택에서 테스트를 실행하려면

    ```shell
    nx run-many --target=test --all --stage=<STAGE_NAME>
    ```

- **오프라인 / 로컬 실행**

  - 오프라인으로 실행하려면, 문서화된 대로 `serverless-offline` 플러그인을 구성하고 [여기](https://github.com/dherault/serverless-offline)에서 확인한 후 아래 명령어를 실행하세요

    ```shell
    nx run <STACK_NAME>:serve --stage=<STAGE_NAME>
    ```

- **작업 공간을 이해하세요**

  ```
  nx dep-graph
  ```
## 추가 도움말

- Serverless 프레임워크에 대해 더 알아보려면 [Serverless Documentation](https://www.serverless.com/framework/docs/)을 방문하세요
- Nx 개발 도구에 대해 더 알아보려면 [Nx Documentation](https://nx.dev)을 방문하세요
- 왜 NX인가, Lerna가 아닌가? Lerna는 더 이상 유지보수되지 않습니다

## Nx Cloud

##### 클라우드에서의 계산 메모이제이션

​ Nx Cloud는 Nx와 결합하여 최대 10배 더 빠르게 코드 빌드 및 테스트를 가능하게 합니다.

​ 자세한 내용과 활성화를 위해 [Nx Cloud](https://nx.app/)를 방문하세요

## 기여

문제를 발견하셨나요? 재현 정보를 포함하여 이슈를 자유롭게 제기하세요.

개선할 풀 리퀘스트도 환영합니다.

## 지원

템플릿이 마음에 드시나요?

<a href="https://www.buymeacoffee.com/sudokar" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="50" width="250"></a> 클릭하세요

또는, 저장소에 별 :star: 을 추가해 주세요

## 유지 관리자

이 템플릿은 [sudokar](https://github.com/sudokar)가 작성하고 유지합니다

## 라이선스

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-27

---