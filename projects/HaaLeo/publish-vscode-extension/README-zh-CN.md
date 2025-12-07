# 发布 VS Code 扩展 — GitHub Action

[![构建、代码检查、测试和部署](https://img.shields.io/github/actions/workflow/status/HaaLeo/publish-vscode-extension/CI.yml?style=flat-square&label=Lint%2C%20Build%2C%20Test%20and%20Deploy)](https://github.com/HaaLeo/publish-vscode-extension/actions?query=workflow%3A%22Build%2C+Lint%2C+Test+and+Deploy%22) [![覆盖率状态](https://img.shields.io/coveralls/github/HaaLeo/publish-vscode-extension?style=flat-square)](https://coveralls.io/github/HaaLeo/publish-vscode-extension)  
[![许可证](https://img.shields.io/badge/license-MIT-brightgreen.svg?style=flat-square)](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/LICENSE.txt) [![星标](https://img.shields.io/github/stars/HaaLeo/publish-vscode-extension.svg?label=Stars&logo=github&style=flat-square)](https://github.com/HaaLeo/publish-vscode-extension/stargazers)  
[![捐赠](https://img.shields.io/badge/☕️-请我喝咖啡-blue.svg?&style=flat-square)](https://www.paypal.me/LeoHanisch/3eur)

GitHub Action 用于将您的 VS Code 扩展发布到 [Open VSX Registry](https://open-vsx.org/) 或 [Visual Studio Marketplace](https://marketplace.visualstudio.com)。

> **v2** 版本的所有重大变更列在 [更新日志](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/CHANGELOG.md#changelog) 中

## 使用方法

要使用该 GitHub Action，只需在您的工作流文件中[引用该 Action](https://help.github.com/en/actions/configuring-and-managing-workflows/configuring-a-workflow#referencing-actions-in-your-workflow)。

### 示例

下面的示例展示了一个工作流，当创建新标签时，将扩展发布到 Open VSX Registry 以及 Visual Studio Marketplace：

```yaml
on:
  push:
    tags:
      - "*"

name: Deploy Extension
jobs:
  deploy:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: actions/setup-node@v4
        with:
          node-version: 20
      - run: npm ci
      - name: Publish to Open VSX Registry
        uses: HaaLeo/publish-vscode-extension@v2
        with:
          pat: ${{ secrets.OPEN_VSX_TOKEN }}
      - name: Publish to Visual Studio Marketplace
        uses: HaaLeo/publish-vscode-extension@v2
        with:
          pat: ${{ secrets.VS_MARKETPLACE_TOKEN }}
          registryUrl: https://marketplace.visualstudio.com
```
要只打包扩展一次并将**相同的** `.vsix` 文件发布到两个注册表，可以改用以下两个步骤：


```yaml
- name: Publish to Open VSX Registry
  uses: HaaLeo/publish-vscode-extension@v2
  id: publishToOpenVSX
  with:
    pat: ${{ secrets.OPEN_VSX_TOKEN }}
- name: Publish to Visual Studio Marketplace
  uses: HaaLeo/publish-vscode-extension@v2
  with:
    pat: ${{ secrets.VS_MARKETPLACE_TOKEN }}
    registryUrl: https://marketplace.visualstudio.com
    extensionFile: ${{ steps.publishToOpenVSX.outputs.vsixPath }}
```

有关更完整和复杂的示例，可以查看 [`HaaLeo/vscode-timing`](https://github.com/HaaLeo/vscode-timing/blob/master/.github/workflows/cicd.yml#L1) 的工作流程。

### Open VSX 注册表

要发布到 Open VSX 注册表，请确保您的 [扩展命名空间](https://github.com/eclipse/openvsx/wiki/Publishing-Extensions#2-create-the-namespace) **已提前**创建。  
您需要将 `pat` 参数设置为您的 [Open VSX 访问令牌](https://github.com/eclipse/openvsx/wiki/Publishing-Extensions#1-create-an-access-token)。  
此外，您应确保只发布有许可证的扩展。  
有关 Open VSX 时间线及其扩展许可的更多信息，请查看 [Brian King 的博客](https://blogs.eclipse.org/post/brian-king/open-vsx-registry-under-new-management)（章节“Licensing”和“Timeline”）。

目前，此 GitHub 操作允许您发布未声明许可条款的扩展。  
然而，此行为已被弃用，未来版本的此操作将拒绝无许可扩展。  
因此，我强烈建议您使用（宽松的）许可证发布扩展，例如 [MIT 许可证](https://choosealicense.com/licenses/mit/)。

### Visual Studio 市场

为了将您的扩展上传到 VS 市场，您需要将 `pat` 选项设置为相应的 [访问令牌](https://code.visualstudio.com/api/working-with-extensions/publishing-extension#get-a-personal-access-token)。  
此外，`registryUrl` 必须设置为 `https://marketplace.visualstudio.com`。

## 输入参数

您可以设置以下任意或所有输入参数：

|名称 |类型 |必需？ |默认值 |描述
|-|-|-|-|-
|`pat` |string  |是 |-|对应注册表的个人访问令牌。
|`extensionFile` |string  |否 | - |要发布的 vsix 文件路径。与 `packagePath` 一起设置时此选项优先。
|`registryUrl` |string  |否 |`https://open-vsx.org` |使用此基础 URL 的注册表 API
|`packagePath` |string |否 | `./` |要打包和发布的扩展路径。当同时设置了 `extensionFile` 时，忽略 `packagePath`。
|`baseContentUrl` |string |否 | - |为 README.md 中的所有相对链接添加此 URL 前缀。
|`baseImagesUrl` |string |否 | - |为 README.md 中的所有相对图片链接添加此 URL 前缀。
|`yarn` |boolean |否 | `false` |打包扩展文件时使用 yarn 替代 npm。
|`dryRun` |boolean |否 | `false` |将此选项设置为 `true` 以打包扩展但不发布。使用此选项时，`pat` 需设置为占位值。
|`noVerify` |boolean| 否 |`false` |允许发布使用提议 API（enableProposedApi: true）的扩展到 Visual Studio 市场。类似 vsce 的 `--noVerify` 命令行参数。
|`preRelease` |boolean| 否 |`false` |将扩展发布标记为预发布。仅在打包扩展时考虑。
|`dependencies` |boolean| 否 |`true` |检查 `package.json` 中定义的依赖是否存在于 `node_modules`。使用 pnpm 或 yarn v2+ 的 PnP 时设置为 `false`。
|`skipDuplicate` |boolean| 否 |`false` |如果市场上已存在相同版本，则静默失败。等同于 vsce CLI 的 `--skip-duplicate` 选项。
|`target` |string| 否 | - |扩展应运行的目标架构。多个目标用空格分隔。例如：`'win32-x64 linux-x64'`


## 输出

该操作公开以下输出：

|名称 |类型 |描述
|-|-|-
|`vsixPath` |string |已打包并发布的 VSIX 文件路径。

## 贡献

如果您发现了错误或缺少功能，请不要犹豫，[提交问题](https://github.com/HaaLeo/publish-vscode-extension/issues/new/choose)。  
欢迎提交 Pull Request！  
要开始提交代码更改，请先查看 [CONTRIBUTING.md](https://raw.githubusercontent.com/HaaLeo/publish-vscode-extension/master/./CONTRIBUTING.md) 文件。

## 支持

如果您喜欢此扩展，请务必[给仓库加星](https://github.com/HaaLeo/publish-vscode-extension/stargazers)。我一直在寻找新的想法和反馈。  
此外，也可以通过 [paypal 捐赠](https://www.paypal.me/LeoHanisch/3eur)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---