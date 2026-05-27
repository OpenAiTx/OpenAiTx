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

A monrepo style, modern boilerplate or template project for [Serverless framework](https://www.serverless.com/) using [Nx](https://nx.dev) monorepo toolkit 🛠 and `aws-nodejs-typescript` serverless template

## Table of contents

- [Whats Included](#whats-included)
- [Template Layout](#template-layout)
- [Prerequisites](#prerequisites)
- [Usage](#usage)
- [Further help](#further-help)
- [Nx Cloud](#nx-cloud)
- [Contribution](#contribution)
- [Support](#support)
- [Maintainer](#maintainer)
- [License](#license)

## Whats Included

- A template project layout using latest version of Nx and Servrless framework
- An easy to use workspace generator to generate a template/stack with Serverless framework files and related Nx configuration
- Configured with AWS provider and it can be easily adopted to any cloud provider

## Template Layout

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

## Prerequisites

- [Nodejs](https://nodejs.org/) `protip: use nvm`

  > :warning: **Version**: `lts/iron (v20)`. If you're using [nvm](https://github.com/nvm-sh/nvm), run `nvm use` to ensure you're using the same Node version in local and in your lambda's runtime.

- :package: Package Manager

  - [Yarn](https://yarnpkg.com)

- 💅 Code format plugins

  - [Eslint](https://eslint.org/)
  - [Prettier](https://prettier.io/)
  - [EditorConfig](https://editorconfig.org/)

  > On your preferred code editor, Install plugins for the above list of tools

## Usage

Depending on your prefrered package manager, follow the instructions below to build and deploy serverless stack(s).

- **Install project dependencies**

  ```shell
  yarn install
  ```

- **Generate a new stack**

  ```shell
  nx g serverless <STACK_NAME>
  ```

  > Run with `-d` or `--dry-run` flag for dry run

- **Generate a new library**

  ```shell
  nx g @nx/node:lib --skipBabelrc --tags lib <LIBRARY_NAME>
  ```

  > Run with `-d` or `--dry-run` flag for dry run

- **Package stack**

  - To package single stack

    ```shell
    nx run <STACK_NAME>:build --stage=<STAGE_NAME>
    ```

  - To package stack affected by a change

    ```shell
    nx affected:build --stage=<STAGE_NAME>
    ```

  - To package all stacks

    ```shell
    nx run-many --target=build --stage=<STAGE_NAME>
    ```

- **Deploy stack to cloud**

  - To deploy single stack

    ```shell
    nx run <STACK_NAME>:deploy --stage=<STAGE_NAME>
    ```

  - To deploy stack affected by a change

    ```shell
    nx affected:deploy --stage=<STAGE_NAME>
    ```

  - To deploy all stacks

    ```shell
    nx run-many --target=deploy --all --stage=<STAGE_NAME>
    ```

- **Remove stack from cloud**

  - To remove single stack

    ```shell
    nx run <STACK_NAME>:remove --stage=<STAGE_NAME>
    ```

  - To remove stack affected by a change

    ```shell
    nx affected:remove --stage=<STAGE_NAME>
    ```

  - To remove all stacks

    ```shell
    nx run-many --target=remove --all --stage=<STAGE_NAME>
    ```

- **Run tests**

  - To run tests in single stack

    ```shell
    nx run <STACK_NAME>:test --stage=<STAGE_NAME>
    ```

  - To run tests affected by a change

    ```shell
    nx affected:test --stage=<STAGE_NAME>
    ```

  - To run tests in all stacks

    ```shell
    nx run-many --target=test --all --stage=<STAGE_NAME>
    ```

- **Run offline / locally**

  - To run offlline, configure `serverless-offline` plugin as documented [here](https://github.com/dherault/serverless-offline) and run below command

    ```shell
    nx run <STACK_NAME>:serve --stage=<STAGE_NAME>
    ```

- **Understand your workspace**

  ```
  nx dep-graph
  ```

## Further help

- Visit [Serverless Documentation](https://www.serverless.com/framework/docs/) to learn more about Serverless framework
- Visit [Nx Documentation](https://nx.dev) to learn more about Nx dev toolkit
- Why NX, not Lerna? Lerna is no longer maintained

## Nx Cloud

##### Computation Memoization in the Cloud

​ Nx Cloud pairs with Nx in order to enable you to build and test code more rapidly, by up to 10 times.

​ Visit [Nx Cloud](https://nx.app/) to learn more and enable it

## Contribution

Found an issue? feel free to raise an issue with information to reproduce.

Pull requests are welcome to improve.

## Support

Like the template?

Click to <a href="https://www.buymeacoffee.com/sudokar" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="50" width="250"></a>

Or, Add a star :star: to the repository

## Maintainer

This template is authored and maintained by [sudokar](https://github.com/sudokar)

## License

MIT
