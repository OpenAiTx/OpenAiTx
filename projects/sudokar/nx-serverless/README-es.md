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

Un proyecto plantilla o boilerplate moderno, estilo monorepo para el [framework Serverless](https://www.serverless.com/) usando la herramienta monorepo [Nx](https://nx.dev) 🛠 y la plantilla serverless `aws-nodejs-typescript`

## Tabla de contenidos

- [Qué incluye](#whats-included)
- [Estructura de la plantilla](#template-layout)
- [Requisitos previos](#prerequisites)
- [Uso](#usage)
- [Ayuda adicional](#further-help)
- [Nx Cloud](#nx-cloud)
- [Contribución](#contribution)
- [Soporte](#support)
- [Mantenedor](#maintainer)
- [Licencia](#license)

## Qué incluye

- Un proyecto plantilla con la versión más reciente de Nx y el framework Serverless
- Un generador de espacio de trabajo fácil de usar para crear una plantilla/pila con archivos del framework Serverless y configuración relacionada de Nx
- Configurado con el proveedor AWS y que puede adaptarse fácilmente a cualquier proveedor en la nube

## Estructura de la plantilla

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
## Requisitos previos

- [Nodejs](https://nodejs.org/) `protip: usa nvm`

  > :warning: **Versión**: `lts/iron (v20)`. Si estás usando [nvm](https://github.com/nvm-sh/nvm), ejecuta `nvm use` para asegurarte de que usas la misma versión de Node localmente y en el entorno de ejecución de tu lambda.

- :package: Gestor de paquetes

  - [Yarn](https://yarnpkg.com)

- 💅 Plugins de formato de código

  - [Eslint](https://eslint.org/)
  - [Prettier](https://prettier.io/)
  - [EditorConfig](https://editorconfig.org/)

  > En tu editor de código preferido, instala los plugins para las herramientas listadas arriba

## Uso

Dependiendo de tu gestor de paquetes preferido, sigue las instrucciones a continuación para construir y desplegar la(s) pila(s) serverless.

- **Instalar dependencias del proyecto**


  ```shell
  yarn install
  ```

- **Generar una nueva pila**

  ```shell
  nx g serverless <STACK_NAME>
  ```

  > Ejecutar con la bandera `-d` o `--dry-run` para una ejecución en seco

- **Generar una nueva biblioteca**

  ```shell
  nx g @nx/node:lib --skipBabelrc --tags lib <LIBRARY_NAME>
  ```

  > Ejecutar con la opción `-d` o `--dry-run` para una ejecución de prueba

- **Empaquetar stack**

  - Para empaquetar un solo stack

    ```shell
    nx run <STACK_NAME>:build --stage=<STAGE_NAME>
    ```
  - Empaquetar la pila afectada por un cambio


    ```shell
    nx affected:build --stage=<STAGE_NAME>
    ```
  - Para empaquetar todas las pilas


    ```shell
    nx run-many --target=build --stage=<STAGE_NAME>
    ```

- **Desplegar pila en la nube**

  - Para desplegar una sola pila

    ```shell
    nx run <STACK_NAME>:deploy --stage=<STAGE_NAME>
    ```

  - Para desplegar la pila afectada por un cambio

    ```shell
    nx affected:deploy --stage=<STAGE_NAME>
    ```
  - Para desplegar todas las pilas


    ```shell
    nx run-many --target=deploy --all --stage=<STAGE_NAME>
    ```

- **Eliminar pila de la nube**

  - Para eliminar una sola pila

    ```shell
    nx run <STACK_NAME>:remove --stage=<STAGE_NAME>
    ```

  - Para eliminar la pila afectada por un cambio

    ```shell
    nx affected:remove --stage=<STAGE_NAME>
    ```
  - Para eliminar todas las pilas


    ```shell
    nx run-many --target=remove --all --stage=<STAGE_NAME>
    ```

- **Ejecutar pruebas**

  - Para ejecutar pruebas en una sola pila

    ```shell
    nx run <STACK_NAME>:test --stage=<STAGE_NAME>
    ```

  - Para ejecutar pruebas afectadas por un cambio

    ```shell
    nx affected:test --stage=<STAGE_NAME>
    ```
  - Para ejecutar pruebas en todas las pilas


    ```shell
    nx run-many --target=test --all --stage=<STAGE_NAME>
    ```

- **Ejecutar sin conexión / localmente**

  - Para ejecutar sin conexión, configure el plugin `serverless-offline` como se documenta [aquí](https://github.com/dherault/serverless-offline) y ejecute el siguiente comando

    ```shell
    nx run <STACK_NAME>:serve --stage=<STAGE_NAME>
    ```

- **Entiende tu espacio de trabajo**

  ```
  nx dep-graph
  ```

## Ayuda adicional

- Visita [Documentación de Serverless](https://www.serverless.com/framework/docs/) para aprender más sobre el framework Serverless
- Visita [Documentación de Nx](https://nx.dev) para aprender más sobre la herramienta de desarrollo Nx
- ¿Por qué NX y no Lerna? Lerna ya no se mantiene

## Nx Cloud

##### Memoización de Cómputos en la Nube

​ Nx Cloud se integra con Nx para permitirte construir y probar código más rápidamente, hasta 10 veces más rápido.

​ Visita [Nx Cloud](https://nx.app/) para aprender más y habilitarlo

## Contribución

¿Encontraste un problema? siéntete libre de crear un issue con información para reproducirlo.

Se aceptan pull requests para mejorar.

## Soporte

¿Te gusta la plantilla?

Haz clic en <a href="https://www.buymeacoffee.com/sudokar" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="50" width="250"></a>

O, añade una estrella :star: al repositorio

## Mantenedor

Esta plantilla fue creada y es mantenida por [sudokar](https://github.com/sudokar)

## Licencia

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-27

---