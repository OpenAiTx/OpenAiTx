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

[Serverless framework](https://www.serverless.com/) と [Nx](https://nx.dev) モノレポツールキット 🛠、および `aws-nodejs-typescript` サーバーレステンプレートを使用したモノレポスタイルのモダンなボイラープレートまたはテンプレートプロジェクト

## 目次

- [含まれているもの](#whats-included)
- [テンプレートレイアウト](#template-layout)
- [前提条件](#prerequisites)
- [使用方法](#usage)
- [さらなるヘルプ](#further-help)
- [Nx Cloud](#nx-cloud)
- [貢献](#contribution)
- [サポート](#support)
- [メンテナ](#maintainer)
- [ライセンス](#license)

## 含まれているもの

- 最新バージョンの Nx と Serverless framework を使用したテンプレートプロジェクトレイアウト
- Serverless framework ファイルと関連する Nx 設定を持つテンプレート/スタックを生成する使いやすいワークスペースジェネレーター
- AWS プロバイダーで設定されており、任意のクラウドプロバイダーに簡単に適応可能

## テンプレートレイアウト

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
## 前提条件

- [Nodejs](https://nodejs.org/) `プロのヒント: nvmを使用してください`

  > :warning: **バージョン**: `lts/iron (v20)`。[nvm](https://github.com/nvm-sh/nvm)を使用している場合は、`nvm use`を実行して、ローカルとLambdaのランタイムで同じNodeバージョンを使用していることを確認してください。

- :package: パッケージマネージャー

  - [Yarn](https://yarnpkg.com)

- 💅 コードフォーマットプラグイン

  - [Eslint](https://eslint.org/)
  - [Prettier](https://prettier.io/)
  - [EditorConfig](https://editorconfig.org/)

  > お好みのコードエディタに、上記ツールのプラグインをインストールしてください

## 使用法

お好みのパッケージマネージャーに応じて、以下の指示に従いサーバーレススタックをビルドおよびデプロイしてください。

- **プロジェクトの依存関係をインストールする**


  ```shell
  yarn install
  ```

- **新しいスタックを生成する**

  ```shell
  nx g serverless <STACK_NAME>
  ```

  > `-d` または `--dry-run` フラグを付けて実行するとドライランになります

- **新しいライブラリを生成する**

  ```shell
  nx g @nx/node:lib --skipBabelrc --tags lib <LIBRARY_NAME>
  ```

  > `-d` または `--dry-run` フラグを付けて実行するとドライランになります

- **スタックのパッケージ**

  - 単一のスタックをパッケージするには

    ```shell
    nx run <STACK_NAME>:build --stage=<STAGE_NAME>
    ```
  - 変更の影響を受けるスタックをパッケージ化するために


    ```shell
    nx affected:build --stage=<STAGE_NAME>
    ```
  - すべてのスタックをパッケージ化するために


    ```shell
    nx run-many --target=build --stage=<STAGE_NAME>
    ```

- **クラウドへのスタックのデプロイ**

  - 単一スタックをデプロイするには

    ```shell
    nx run <STACK_NAME>:deploy --stage=<STAGE_NAME>
    ```
  - 変更の影響を受けたスタックをデプロイするために


    ```shell
    nx affected:deploy --stage=<STAGE_NAME>
    ```
  - すべてのスタックをデプロイするために


    ```shell
    nx run-many --target=deploy --all --stage=<STAGE_NAME>
    ```

- **クラウドからスタックを削除する**

  - 単一のスタックを削除するために

    ```shell
    nx run <STACK_NAME>:remove --stage=<STAGE_NAME>
    ```

  - 変更によって影響を受けたスタックを削除するために

    ```shell
    nx affected:remove --stage=<STAGE_NAME>
    ```

  - すべてのスタックを削除するために

    ```shell
    nx run-many --target=remove --all --stage=<STAGE_NAME>
    ```

- **テストを実行する**

  - 単一スタックでテストを実行するために

    ```shell
    nx run <STACK_NAME>:test --stage=<STAGE_NAME>
    ```

  - 変更によって影響を受けるテストを実行するために

    ```shell
    nx affected:test --stage=<STAGE_NAME>
    ```
  - すべてのスタックでテストを実行するために


    ```shell
    nx run-many --target=test --all --stage=<STAGE_NAME>
    ```

- **オフライン／ローカルで実行する**

  - オフラインで実行するには、`serverless-offline` プラグインを[こちら](https://github.com/dherault/serverless-offline)のドキュメントに従って設定し、以下のコマンドを実行します

    ```shell
    nx run <STACK_NAME>:serve --stage=<STAGE_NAME>
    ```

- **作業スペースを理解する**

  ```
  nx dep-graph
  ```
## さらにサポート

- Serverlessフレームワークについて詳しくは[Serverless Documentation](https://www.serverless.com/framework/docs/)をご覧ください
- Nx開発ツールキットについて詳しくは[Nx Documentation](https://nx.dev)をご覧ください
- なぜLernaではなくNXなのか？ Lernaはもはやメンテナンスされていません

## Nx Cloud

##### クラウドでの計算メモ化

​ Nx CloudはNxと連携して、コードのビルドとテストを最大10倍高速化します。

​ 詳しくは[Nx Cloud](https://nx.app/)をご覧いただき、有効化してください

## 貢献

問題を見つけましたか？ 再現情報とともにIssueを投稿してください。

プルリクエストも歓迎します。

## サポート

このテンプレートが気に入りましたか？

クリックして<a href="https://www.buymeacoffee.com/sudokar" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="50" width="250"></a>

または、リポジトリにスター :star: を付けてください

## メンテナー

このテンプレートは[sudokar](https://github.com/sudokar)によって作成および維持されています

## ライセンス

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-27

---