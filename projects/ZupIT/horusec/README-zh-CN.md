<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="version">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="activity">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="contributors">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="security">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="coverage">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="build">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="license">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **目录**
### 1. [**关于**](#about)
### 2. [**快速开始**](#getting-started)
>#### 2.1.   [**系统要求**](#requirements)
>#### 2.2.  [**安装**](#installing-horusec)
### 3. [**使用方法**](#usage)
>#### 3.1. [**CLI 使用**](#cli-usage)
>#### 3.2. [**使用 Docker**](#using-docker)
>#### 3.3. [**旧版本**](#older-versions)
>#### 3.4. [**使用 Horusec-Web 应用程序**](#using-horusec-web-application)
>#### 3.5.  [**使用 Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**在流水线中使用**](#using-the-pipeline)
### 4. [**文档**](#documentation)       
### 5. [**路线图**](#roadmap)
### 6. [**贡献**](#contributing)
### 7. [**行为准则**](#code-of-conduct)
### 8. [**许可证**](#license)
### 9. [**社区**](#community)



<br>
<br>
<br>

# **关于**
Horusec 是一个开源工具，在开发过程中执行静态代码分析以识别安全漏洞。目前支持分析的语言包括 C#、Java、Kotlin、Python、Ruby、Golang、Terraform、Javascript、Typescript、Kubernetes、PHP、C、HTML、JSON、Dart、Elixir、Shell、Nginx。
该工具可以在您项目的所有文件以及 Git 历史中搜索密钥泄露和安全漏洞。Horusec 可供开发者通过 CLI 使用，也可供 DevSecOps 团队在 CI/CD 流水线中使用。

查看我们的[**文档**](https://docs.horusec.io/docs/overview/)，您可以看到 Horusec 支持分析的完整工具和语言列表。

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **输出示例：**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **快速开始**

## **系统要求**

- Docker

你需要在本地安装 Docker 才能运行 Horusec 及其所用的全部工具。
如果你没有安装 Docker，我们提供了一个[**参数**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` 用于禁用此依赖，但这样会损失大部分分析能力。
我们推荐使用 Docker。

如果你启用了提交作者 `-G true`，还需要依赖 `git`。

## **安装 Horusec**
### **Mac 或 Linux**
```
make install
```

或

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **检查安装情况**
```bash
horusec version
```

### **Windows**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **检查安装情况**
```bash
./horusec.exe version
```

### **更多安装方式**

- 你可以在我们的[**发布页面**](https://github.com/ZupIT/horusec/releases)找到所有版本的二进制文件。

- 有关安装的更多细节，请查看[**文档**](https://docs.horusec.io/docs/cli/installation)。


## **使用方法**
### **CLI 使用**
要使用 horusec-cli 检查应用程序的漏洞，请使用以下命令：
```bash
horusec start -p .
```
> 当 horusec 开始分析时，会创建一个名为 **`.horusec`** 的文件夹。这个文件夹的作用是避免更改你的代码。我们建议你在 **`.gitignore`** 文件中添加 **`.horusec`**，以便该文件夹无需提交到你的 git 服务器。

### **使用 Docker**
可以通过 docker 镜像 **`horuszup/horusec-cli:latest`** 来使用 Horusec。

运行以下命令：
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- 我们创建了一个包含项目的卷 `-v $(pwd):/src`。

使用 docker 镜像时，项目会有两个路径。

`-p` 参数表示容器内的项目路径，本例中为 `/src`。
`-P` 参数表示容器外的项目路径，本例为 `$(pwd)`，
同时需要将项目路径挂载到卷 `-v $(pwd):/src`。

### **旧版本**

Horusec 的 v1 版本仍然可用。

**警告：** v1 相关端点即将废弃，请升级 CLI 至 v2。详情请查看[**文档**](https://docs.horusec.io/docs/migrate-v1-to-v2/)。 

### **Mac 或 Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- 旧版本二进制文件可在此端点获取，包括 v1 的最新版 **`v1.10.3`**。
- 从 v2 起，二进制文件将不再由此端点分发，你可以在[**发布页面**](https://github.com/ZupIT/horusec/releases)获取。

### **使用 Horusec-Web 应用程序**
通过我们的网页界面管理你的漏洞。你可以查看关于漏洞的各类指标、管理误报、授权令牌、漏洞更新等。
查看[**Web 应用程序**](https://github.com/ZupIT/horusec-platform)部分了解更多。

参见下面示例，将分析结果发送到 Horusec web 服务：
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

参见[**如何通过 Horusec Manager Web Service 创建授权令牌的教程**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token)。

**警告：** 我们的 web 服务已迁移至[**新仓库**](https://github.com/ZupIT/horusec-platform)。你需要升级到 v2，详见[**如何从 v1 升级到 v2**](https://docs.horusec.io/docs/migrate-v1-to-v2)。

### **使用 Visual Studio Code**
你可以通过 Horusec 的 Visual Studio Code 扩展分析你的项目。
详情请[**参见文档**](https://docs.horusec.io/docs/extensions/visual-studio-code/)。

### **在流水线中使用**
你可以在部署前分析你的项目，以确保组织的最大安全性。
详情请[**参见文档**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline)：

### **功能**
如下所示：
- 同时分析 18 种语言，集成 20 种不同的安全工具以提升准确性；
- 在 git 历史中查找敏感信息和其他暴露内容；
- 分析过程完全可配置，[**查看所有 CLI 可用参数**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags)。

## **文档**
你可以在我们的[**网站**](https://docs.horusec.io/docs/overview/)上找到 Horusec 的相关文档。

## **路线图**
我们有项目[**路线图**](ROADMAP.md)，欢迎你的贡献！

Horusec 还有其他仓库，欢迎查看：

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **贡献指南**

欢迎自由使用、推荐改进建议，或为新功能做出贡献。

请查阅我们的[**贡献指南**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md)，了解我们的开发流程，以及如何提出错误修复和改进建议。

### **开发者原产地证书 - DCO**

这是对项目和开发者的安全保障措施。此项为强制要求。

请通过以下两种方法之一为您的提交添加 DCO：

**1. 命令行方式**  
请按以下步骤操作：  
**步骤 1：** 配置本地 git 环境，添加与您 GitHub 账户相同的姓名和邮箱。这有助于在代码审查和建议时手动签署提交。

```
git config --global user.name “Name”
git config --global user.email “email@domain.com.br”
```
**步骤 2：** 在 git commit 命令中使用 `'-s'` 标志添加 Signed-off-by 行：

```
$ git commit -s -m "This is my commit message"
```
**2. GitHub 网站方式**

您也可以在 GitHub 代码审查和建议时手动签署提交，请按以下步骤操作：

**步骤 1：** 当提交变更框打开时，在评论框中手动输入或粘贴您的签名，示例如下：

```
Signed-off-by: Name < e-mail address >
```

采用此方法时，您的姓名和邮箱必须与您在 GitHub 上注册的信息一致。

## **行为准则**
请在与本项目所有互动中遵守[**行为准则**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md)。

## **许可证**  
[**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE)。

## **社区**

欢迎通过以下方式联系我们：

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- 如果您有任何问题或想法，欢迎在我们的 [**Zup 开源论坛**](https://forum.zup.com.br) 交流。

本项目因所有贡献者而存在。你们太棒了！❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---