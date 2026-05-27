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

一个采用 [Nx](https://nx.dev) monorepo 工具包 🛠 和 `aws-nodejs-typescript` serverless 模板，基于 [Serverless framework](https://www.serverless.com/) 的 monorepo 风格现代样板或模板项目

## 目录

- [包含内容](#whats-included)
- [模板布局](#template-layout)
- [先决条件](#prerequisites)
- [使用说明](#usage)
- [进一步帮助](#further-help)
- [Nx Cloud](#nx-cloud)
- [贡献](#contribution)
- [支持](#support)
- [维护者](#maintainer)
- [许可证](#license)

## 包含内容

- 使用最新版本的 Nx 和 Serverless framework 的模板项目布局
- 一个易于使用的工作区生成器，用于生成包含 Serverless framework 文件及相关 Nx 配置的模板/堆栈
- 配置了 AWS 提供者，并且可以轻松适配任何云提供者

## 模板布局

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

- [Nodejs](https://nodejs.org/) `技巧提示：使用 nvm`

  > :warning: **版本**：`lts/iron (v20)`。如果你使用的是 [nvm](https://github.com/nvm-sh/nvm)，运行 `nvm use` 确保本地和你的 lambda 运行时使用相同的 Node 版本。

- :package: 包管理器

  - [Yarn](https://yarnpkg.com)

- 💅 代码格式插件

  - [Eslint](https://eslint.org/)
  - [Prettier](https://prettier.io/)
  - [EditorConfig](https://editorconfig.org/)

  > 在你喜欢的代码编辑器中，安装上述工具列表的插件

## 使用方法

根据你喜欢的包管理器，按照以下说明构建和部署无服务器堆栈。

- **安装项目依赖**


  ```shell
  yarn install
  ```

- **生成一个新的堆栈**

  ```shell
  nx g serverless <STACK_NAME>
  ```

  > 使用 `-d` 或 `--dry-run` 标志进行模拟运行

- **生成一个新的库**

  ```shell
  nx g @nx/node:lib --skipBabelrc --tags lib <LIBRARY_NAME>
  ```

  > 使用 `-d` 或 `--dry-run` 标志进行模拟运行

- **打包堆栈**

  - 打包单个堆栈

    ```shell
    nx run <STACK_NAME>:build --stage=<STAGE_NAME>
    ```

  - 对受更改影响的包堆进行打包

    ```shell
    nx affected:build --stage=<STAGE_NAME>
    ```

  - 打包所有堆栈

    ```shell
    nx run-many --target=build --stage=<STAGE_NAME>
    ```

- **将堆栈部署到云端**

  - 部署单个堆栈

    ```shell
    nx run <STACK_NAME>:deploy --stage=<STAGE_NAME>
    ```
  - 部署受更改影响的堆栈


    ```shell
    nx affected:deploy --stage=<STAGE_NAME>
    ```
  - 部署所有堆栈


    ```shell
    nx run-many --target=deploy --all --stage=<STAGE_NAME>
    ```

- **从云中移除堆栈**

  - 移除单个堆栈

    ```shell
    nx run <STACK_NAME>:remove --stage=<STAGE_NAME>
    ```
  - 删除受更改影响的堆栈


    ```shell
    nx affected:remove --stage=<STAGE_NAME>
    ```
  - 删除所有堆栈


    ```shell
    nx run-many --target=remove --all --stage=<STAGE_NAME>
    ```

- **运行测试**

  - 在单个堆栈中运行测试

    ```shell
    nx run <STACK_NAME>:test --stage=<STAGE_NAME>
    ```
  - 运行受更改影响的测试  


    ```shell
    nx affected:test --stage=<STAGE_NAME>
    ```

  - 在所有堆栈中运行测试

    ```shell
    nx run-many --target=test --all --stage=<STAGE_NAME>
    ```

- **离线 / 本地运行**

  - 要离线运行，请按照[这里](https://github.com/dherault/serverless-offline)的文档配置 `serverless-offline` 插件，然后运行以下命令

    ```shell
    nx run <STACK_NAME>:serve --stage=<STAGE_NAME>
    ```

- **了解您的工作区**

  ```
  nx dep-graph
  ```
## 进一步帮助

- 访问 [Serverless 文档](https://www.serverless.com/framework/docs/) 以了解更多 Serverless 框架信息  
- 访问 [Nx 文档](https://nx.dev) 以了解更多 Nx 开发工具包信息  
- 为什么选择 NX 而不是 Lerna？Lerna 已不再维护

## Nx Cloud

##### 云端计算备忘

​ Nx Cloud 与 Nx 配合使用，使您能够更快地构建和测试代码，速度提升可达 10 倍。

​ 访问 [Nx Cloud](https://nx.app/) 了解更多并启用它

## 贡献

发现问题？欢迎提交包含复现信息的问题。

欢迎通过拉取请求进行改进。

## 支持

喜欢此模板？

点击 <a href="https://www.buymeacoffee.com/sudokar" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="50" width="250"></a>

或者，为仓库添加一个星标 :star:

## 维护者

此模板由 [sudokar](https://github.com/sudokar) 编写并维护

## 许可证

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-27

---