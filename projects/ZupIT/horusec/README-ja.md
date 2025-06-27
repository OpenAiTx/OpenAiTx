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

## **目次**
### 1. [**概要**](#about)
### 2. [**はじめに**](#getting-started)
>#### 2.1.   [**要件**](#requirements)
>#### 2.2.  [**インストール**](#installing-horusec)
### 3. [**使い方**](#usage)
>#### 3.1. [**CLIの使用方法**](#cli-usage)
>#### 3.2. [**Dockerの使用**](#using-docker)
>#### 3.3. [**旧バージョンの利用**](#older-versions)
>#### 3.4. [**Horusec-Webアプリケーションの利用**](#using-horusec-web-application)
>#### 3.5.  [**Visual Studio Codeの利用**](#using-visual-studio-code)
>#### 3.6. [**パイプラインでの利用**](#using-the-pipeline)
### 4. [**ドキュメント**](#documentation)       
### 5. [**ロードマップ**](#roadmap)
### 6. [**貢献方法**](#contributing)
### 7. [**行動規範**](#code-of-conduct)
### 8. [**ライセンス**](#license)
### 9. [**コミュニティ**](#community)



<br>
<br>
<br>

# **概要**
Horusecは、開発プロセス中にセキュリティの欠陥を特定するための静的コード解析を実行するオープンソースツールです。現在、解析対象の言語は C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx です。
このツールには、すべてのプロジェクトファイルやGit履歴内のキー漏洩やセキュリティ脆弱性を検索するオプションがあります。Horusecは、CLIを通じて開発者が利用したり、CI/CDマット上でDevSecOpsチームが利用できます。

[**ドキュメント**](https://docs.horusec.io/docs/overview/) をご覧ください。Horusecが解析を行うツールと対応言語の完全リストを確認できます。

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **出力例をご覧ください:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **はじめに**

## **要件**

- Docker

Horusecをすべてのツールと共に実行するには、マシンにDockerがインストールされている必要があります。
Dockerがない場合は、[**フラグ**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` で依存関係を無効にできますが、解析の精度も大きく低下します。
Dockerでの使用を推奨します。

コミット作者を有効にする場合（`-G true`）、`git` も必要です。

## **Horusecのインストール**
### **MacまたはLinux**
```
make install
```

または

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/main/deployments/scripts/install.sh | bash -s latest
```

#### **インストール確認**
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

#### **インストール確認**
```bash
./horusec.exe version
```

### **その他**

- すべてのバージョン付きバイナリは [**リリースページ**](https://github.com/ZupIT/horusec/releases) で入手できます。

- インストール方法の詳細は [**ドキュメント**](https://docs.horusec.io/docs/cli/installation) をご覧ください。


## **使い方**
### **CLIの使用方法**
horusec-cliを使用してアプリケーションの脆弱性を確認するには、次のコマンドを実行します:
```bash
horusec start -p .
```
> horusecが解析を開始すると、**`.horusec`** というフォルダが作成されます。このフォルダはコードを変更しないための基盤です。**`.horusec`** を **`.gitignore`** ファイルに追加し、このフォルダがgitサーバーに送信されないようにしてください。

### **Dockerの使用**
Horusecはdockerイメージ **`horuszup/horusec-cli:latest`** を通じて利用できます。

以下のコマンドを実行してください:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- プロジェクトを含むボリュームを作成しています `-v $(pwd):/src`。

dockerイメージを利用することで、プロジェクトは2つのパスで見つけることができます。

`-p` フラグはコンテナ内でのプロジェクトパス（例: `/src`）を表します。
`-P` フラグはコンテナ外（ローカル）のプロジェクトパス（例: `$(pwd)`）を表し、ボリュームマウントのために必要です `-v $(pwd):/src`。

### **旧バージョンの利用**

Horusec v1は依然として利用可能です。

**警告:** v1のエンドポイントは廃止予定です。CLIをv2へアップグレードしてください。詳細は [**ドキュメント**](https://docs.horusec.io/docs/migrate-v1-to-v2/) を参照してください。

### **MacまたはLinux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- 古いバイナリはこのエンドポイントにあり、v1の最新バージョン **`v1.10.3`** も含まれます。
- v2以降は、このエンドポイントでバイナリの配布はなくなり、[**リリースページ**](https://github.com/ZupIT/horusec/releases)で入手できます。

### **Horusec-Webアプリケーションの利用**
ウェブインターフェースを通じて脆弱性を管理できます。ダッシュボードで脆弱性のメトリクスを確認したり、偽陽性管理、認可トークン、脆弱性の更新などが可能です。
[**Webアプリケーション**](https://github.com/ZupIT/horusec-platform) セクションもご覧ください。

下記はHorusecウェブサービスに解析結果を送信する例です:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

[**Horusec Manager Web Serviceで認可トークンを作成するチュートリアル**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token) をご覧ください。

**警告:** Webサービスは [**新しいリポジトリ**](https://github.com/ZupIT/horusec-platform) へ移動しました。v2へのアップグレードが必要です。[**v1からv2への移行方法**](https://docs.horusec.io/docs/migrate-v1-to-v2) をご確認ください。

### **Visual Studio Codeの利用**
HorusecのVisual Studio Code拡張機能を使用してプロジェクトを解析できます。
詳細は [**ドキュメント**](https://docs.horusec.io/docs/extensions/visual-studio-code/) をご覧ください。

### **パイプラインでの利用**
デプロイ前にプロジェクトを解析し、組織のセキュリティを最大限に高めることができます。
詳細は [**ドキュメント**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline) をご覧ください:

### **機能一覧**
下記の通りです:
- 18言語を同時に20種類のセキュリティツールで解析し、精度を向上
- Gitの履歴からシークレットやその他の公開コンテンツを検索
- 解析は完全に設定可能、[**CLIですべての利用可能なリソースを見る**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags)。

## **ドキュメント**
Horusecのドキュメントは [**ウェブサイト**](https://docs.horusec.io/docs/overview/) で参照できます。

## **ロードマップ**
プロジェクトの[**ロードマップ**](https://raw.githubusercontent.com/ZupIT/horusec/main/ROADMAP.md)があります。ぜひご協力ください！

Horusecには他にもリポジトリがあります。ご覧ください:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **コントリビューションについて**

ご自由にご利用いただき、改善提案や新しい実装への貢献も歓迎しています。

当プロジェクトの開発プロセスやバグ修正・改善提案の方法については、[**コントリビューションガイド**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md)をご覧ください。

### **開発者証明書 - DCO**

これはプロジェクトおよび開発者のためのセキュリティレイヤーです。必須となります。

コミットにDCOを追加するには、以下の2つの方法のいずれかに従ってください。

**1. コマンドラインの場合**  
以下の手順に従ってください:  
**ステップ1:** お使いのGitHubアカウントと同じ名前とメールアドレスをローカルのgit環境に設定してください。レビューや提案時にコミットへ手動で署名する際に役立ちます。

```
git config --global user.name “Name”
git config --global user.email “email@domain.com.br”
```
**ステップ2:** git commitコマンドで `'-s'` フラグを付けてSigned-off-by行を追加します:

```
$ git commit -s -m "This is my commit message"
```
**2. GitHubウェブサイトの場合**

GitHub上でのレビューや提案時にも手動でコミットに署名できます。以下の手順に従ってください:

**ステップ1:** コミット変更ボックスが開いたら、コメント欄に署名を手動で入力または貼り付けてください。例:

```
Signed-off-by: Name < e-mail address >
```

この方法の場合も、氏名とメールアドレスはGitHubアカウントに登録されているものと同じである必要があります。

## **行動規範**
本プロジェクトとのあらゆるやり取りにおいて、[**行動規範**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md)に従ってください。

## **ライセンス**
[**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE)。

## **コミュニティ**

お気軽にご連絡ください:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- ご質問やアイデアがありましたら、[**Zup Open Source Forum**](https://forum.zup.com.br)でお話ししましょう。

このプロジェクトはすべての貢献者のおかげで成り立っています。皆さん、最高です！❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---