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

## **目錄**
### 1. [**關於**](#about)
### 2. [**快速開始**](#getting-started)
>#### 2.1.   [**系統需求**](#requirements)
>#### 2.2.  [**安裝方式**](#installing-horusec)
### 3. [**使用方式**](#usage)
>#### 3.1. [**CLI 使用方式**](#cli-usage)
>#### 3.2. [**使用 Docker**](#using-docker)
>#### 3.3. [**舊版說明**](#older-versions)
>#### 3.4. [**使用 Horusec-Web 應用程式**](#using-horusec-web-application)
>#### 3.5.  [**在 Visual Studio Code 中使用**](#using-visual-studio-code)
>#### 3.6. [**在流水線中使用**](#using-the-pipeline)
### 4. [**文件**](#documentation)       
### 5. [**產品藍圖**](#roadmap)
### 6. [**貢獻指南**](#contributing)
### 7. [**行為準則**](#code-of-conduct)
### 8. [**授權**](#license)
### 9. [**社群**](#community)



<br>
<br>
<br>

# **關於**
Horusec 是一個開源工具，可在開發過程中執行靜態程式碼分析，以識別安全漏洞。目前支援的語言包括 C#、Java、Kotlin、Python、Ruby、Golang、Terraform、Javascript、Typescript、Kubernetes、PHP、C、HTML、JSON、Dart、Elixir、Shell、Nginx。
本工具可搜尋所有專案檔案中的金鑰洩漏與安全漏洞，也支援 Git 歷史紀錄分析。Horusec 可由開發者透過 CLI 使用，也可由 DevSecOps 團隊在 CI / CD 環境中執行。

請參閱我們的 [**文件**](https://docs.horusec.io/docs/overview/)，可查看 Horusec 支援分析的完整工具與語言列表。

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **輸出範例：**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **快速開始**

## **系統需求**

- Docker

你需要在本機安裝 Docker 以便執行 Horusec 及其所有分析工具。
若尚未安裝 Docker，我們提供了[**參數**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` 可關閉此依賴，但將降低分析能力。
建議搭配 Docker 一同使用。

若啟用 Commit 作者分析 `-G true`，則還需安裝 `git`。

## **安裝 Horusec**
### **Mac 或 Linux**
```
make install
```

或

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/main/deployments/scripts/install.sh | bash -s latest
```

#### **驗證安裝**
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

#### **驗證安裝**
```bash
./horusec.exe version
```

### **更多安裝方式**

- 你可以在我們的 [**發佈頁面**](https://github.com/ZupIT/horusec/releases) 取得所有版本的執行檔。

- 更多安裝細節請參閱 [**文件**](https://docs.horusec.io/docs/cli/installation) 


## **使用方式**
### **CLI 使用方式**
要使用 horusec-cli 並檢查應用程式的漏洞，請執行下列指令：
```bash
horusec start -p .
```
> 當 horusec 開始分析時，會建立一個名為 **`.horusec`** 的資料夾。此資料夾為分析暫存，不會更動你的程式碼。我們建議將 **`.horusec`** 加入 **`.gitignore`**，以避免此資料夾被提交到 git 伺服器。

### **使用 Docker**
你也可以透過 Docker 映像檔 **`horuszup/horusec-cli:latest`** 使用 Horusec。

執行下列指令：
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- 我們建立了一個包含專案的掛載點 `-v $(pwd):/src`。

在 Docker 映像檔中，專案會出現在兩個不同的路徑。

`-p` 參數代表容器內的專案路徑，在此例為 `/src`。
`-P` 參數代表容器外部的專案路徑，在此例為 `$(pwd)`，
同時需將專案路徑掛載到 `-v $(pwd):/src`。

### **舊版說明**

Horusec v1 仍然可用。

**注意：** v1 相關端點將會淘汰，請升級 CLI 至 v2。詳情請參閱 [**文件**](https://docs.horusec.io/docs/migrate-v1-to-v2/)。

### **Mac 或 Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- 舊版執行檔可於此端點取得，包括 v1 最新版本 **`v1.10.3`**。 
- 自 v2 起，執行檔將不再於此端點釋出，請至 [**發佈頁面**](https://github.com/ZupIT/horusec/releases) 下載。

### **使用 Horusec-Web 應用程式**
透過我們的網頁介面管理你的漏洞。你可以查看漏洞儀表板、管理誤報、授權令牌、更新漏洞等功能。
詳情請參閱 [**Web 應用程式**](https://github.com/ZupIT/horusec-platform) 章節。

以下範例展示如何將分析結果送出至 Horusec Web 服務：
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

參閱 [**如何透過 Horusec Manager Web Service 建立授權令牌教學**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token)。

**注意：** 我們的 Web 服務已移至 [**新儲存庫**](https://github.com/ZupIT/horusec-platform)。你需要升級至 v2，詳見 [**如何從 v1 遷移至 v2**](https://docs.horusec.io/docs/migrate-v1-to-v2)。

### **在 Visual Studio Code 中使用**
你可以透過 Horusec 的 Visual Studio Code 擴充套件分析你的專案。
更多資訊請參閱 [**文件**](https://docs.horusec.io/docs/extensions/visual-studio-code/)。

### **在流水線中使用**
你可以在部署前分析專案，確保組織資訊安全。
詳情請參閱 [**文件**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **功能特色**
如下：
- 同時支援 18 種語言分析，整合 20 種安全工具，提高準確度；
- 搜尋 git 歷史紀錄中的金鑰與其他敏感資訊；
- 分析完全可自訂，[**查看所有 CLI 可用參數**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags)。

## **文件**
你可以在我們的 [**網站**](https://docs.horusec.io/docs/overview/) 查看 Horusec 的完整文件。

## **產品藍圖**
我們有專案 [**藍圖**](https://raw.githubusercontent.com/ZupIT/horusec/main/ROADMAP.md)，歡迎一起貢獻！

Horusec 還有其他儲存庫，歡迎參考：

- [**Horusec 平台**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **貢獻指南**

歡迎使用本專案，並建議改進或貢獻新的實作功能。

請參閱我們的[**貢獻指南**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md)，了解我們的開發流程，以及如何提出錯誤修正與改進建議。

### **開發者原則證明 - DCO**

這是專案與開發人員的安全防護層。此項為強制要求。

請依照以下兩種方法之一，將 DCO 加入您的提交紀錄：

**1. 命令列**
請依照以下步驟操作：
**步驟 1：** 設定本地 git 環境，新增與您 GitHub 帳號相同的名稱與電子郵件。這有助於在審查與建議時手動簽署提交。

```
git config --global user.name “Name”
git config --global user.email “email@domain.com.br”
```
**步驟 2：** 在 git commit 指令中加入 `'-s'` 參數，新增 Signed-off-by 行：

```
$ git commit -s -m "This is my commit message"
```
**2. GitHub 網站**

您也可以在 GitHub 審查與建議時，手動為您的提交簽名，請依下列步驟操作：

**步驟 1：** 當出現提交變更的對話框時，請在評論區手動輸入或貼上您的簽名，範例如下：

```
Signed-off-by: Name < e-mail address >
```

此方法下，您的姓名與電子郵件必須與您在 GitHub 帳號註冊的資訊一致。

## **行為守則**
請於所有與本專案互動時遵守[**行為守則**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md)。

## **授權條款**
[**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE)。

## **社群**

歡迎透過以下方式聯繫我們：

- [**GitHub 問題回報**](https://github.com/ZupIT/horusec/issues)
- 若您有任何疑問或想法，歡迎於我們的[**Zup 開源論壇**](https://forum.zup.com.br)討論。

本專案能夠持續發展，感謝所有貢獻者。你們最棒了！❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---