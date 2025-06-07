![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Windows Terminal、コンソール、およびコマンドライン リポジトリへようこそ

<details>
  <summary><strong>目次</strong></summary>

- [Windows Terminal のインストールと実行](#installing-and-running-windows-terminal)
  - [Microsoft Store【推奨】](#microsoft-store-recommended)
  - [その他のインストール方法](#other-install-methods)
    - [GitHub 経由](#via-github)
    - [Windows Package Manager CLI（winget）経由](#via-windows-package-manager-cli-aka-winget)
    - [Chocolatey 経由（非公式）](#via-chocolatey-unofficial)
    - [Scoop 経由（非公式）](#via-scoop-unofficial)
- [Windows Terminal Canary のインストール](#installing-windows-terminal-canary)
- [Windows Terminal ロードマップ](#windows-terminal-roadmap)
- [ターミナル & コンソールの概要](#terminal--console-overview)
  - [Windows Terminal](#windows-terminal)
  - [Windows コンソールホスト](#the-windows-console-host)
  - [共有コンポーネント](#shared-components)
  - [新しい Windows Terminal の作成](#creating-the-new-windows-terminal)
- [リソース](#resources)
- [FAQ](#faq)
  - [新しい Terminal をビルドして実行したが、古いコンソールと同じに見える](#i-built-and-ran-the-new-terminal-but-it-looks-just-like-the-old-console)
- [ドキュメント](#documentation)
- [コントリビューション](#contributing)
- [チームとのコミュニケーション](#communicating-with-the-team)
- [開発者向けガイダンス](#developer-guidance)
- [前提条件](#prerequisites)
- [コードのビルド](#building-the-code)
  - [PowerShell でのビルド](#building-in-powershell)
  - [Cmd でのビルド](#building-in-cmd)
- [実行 & デバッグ](#running--debugging)
  - [コーディングガイダンス](#coding-guidance)
- [行動規範](#code-of-conduct)

</details>

<br />

このリポジトリには、以下のソースコードが含まれています：

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Windows コンソールホスト (`conhost.exe`)
* 上記2つのプロジェクト間で共有されるコンポーネント
* [ColorTool](./src/tools/ColorTool)
* [サンプルプロジェクト](./samples)
  （Windows コンソール API の利用例）

関連リポジトリ：

* [Windows Terminal ドキュメント](https://docs.microsoft.com/windows/terminal)
  （[ドキュメント貢献リポジトリ](https://github.com/MicrosoftDocs/terminal)）
* [コンソール API ドキュメント](https://github.com/MicrosoftDocs/Console-Docs)
* [Cascadia Code フォント](https://github.com/Microsoft/Cascadia-Code)

## Windows Terminal のインストールと実行

> [!NOTE]
> Windows Terminal には Windows 10 2004（ビルド 19041）以降が必要です

### Microsoft Store【推奨】

[Microsoft Store から Windows Terminal をインストール][store-install-link] してください。
新しいビルドがリリースされるたびに自動アップグレードで常に最新バージョンを利用できます。

これが推奨インストール方法です。

### その他のインストール方法

#### GitHub 経由

Microsoft Store からインストールできない場合は、
このリポジトリの [リリースページ](https://github.com/microsoft/terminal/releases) からビルド済みバージョンを手動でダウンロードできます。

**Assets** セクションから `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` ファイルをダウンロードしてください。インストールは `.msixbundle` ファイルをダブルクリックするだけで自動的にインストーラーが起動します。もしうまくいかない場合は、PowerShell プロンプトで次のコマンドを試してください：

```powershell
# 注意: PowerShell 7 以降を使用している場合は、
# Add-AppxPackage を使う前に
# Import-Module Appx -UseWindowsPowerShell
# を実行してください。

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> 手動で Terminal をインストールした場合：
>
> * [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages) のインストールが必要な場合があります。
>   これは古い Windows 10 ビルドで、フレームワークパッケージが不足しているときのみ必要です。
> * 手動インストールでは自動アップデートされません。新しいビルドのたびに最新版をインストールしてください。

#### Windows Package Manager CLI（winget）経由

[winget](https://github.com/microsoft/winget-cli) 利用者は
`Microsoft.WindowsTerminal` パッケージをインストールすることで
最新の Terminal をインストールできます：

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> 依存関係サポートは WinGet バージョン [1.6.2631 以降](https://github.com/microsoft/winget-cli/releases) で利用可能です。Terminal 安定版 1.18 以降をインストールするには、WinGet クライアントが最新であることを確認してください。

#### Chocolatey 経由（非公式）

[Chocolatey](https://chocolatey.org) 利用者は
`microsoft-windows-terminal` パッケージをインストールすることで
最新の Terminal を導入できます：

```powershell
choco install microsoft-windows-terminal
```

Chocolatey で Windows Terminal をアップグレードするには、次のコマンドを実行してください：

```powershell
choco upgrade microsoft-windows-terminal
```

インストールやアップグレード時に問題が発生した場合は、
[Windows Terminal パッケージページ](https://chocolatey.org/packages/microsoft-windows-terminal) で
[Chocolatey トリアージプロセス](https://chocolatey.org/docs/package-triage-process) に従ってください。

#### Scoop 経由（非公式）

[Scoop](https://scoop.sh) 利用者は
`windows-terminal` パッケージをインストールすることで
最新の Terminal を導入できます：

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Scoop で Windows Terminal を更新するには、次のコマンドを実行してください：

```powershell
scoop update windows-terminal
```

インストールや更新時に問題が発生した場合は、
Scoop Extras バケットリポジトリの [issues ページ](https://github.com/lukesampson/scoop-extras/issues) で
検索または報告してください。

---

## Windows Terminal Canary のインストール

Windows Terminal Canary は Windows Terminal のナイトリービルドです。このビルドは `main` ブランチの最新コードが含まれており、Windows Terminal Preview に機能が取り込まれる前にお試しいただけます。

Windows Terminal Canary は最も安定性が低いバージョンであり、私たちがまだ発見していないバグが見つかることがあります。

Windows Terminal Canary には App Installer 配布形式とポータブル ZIP 配布形式があります。

App Installer 配布形式は自動アップデートをサポートしています。プラットフォームの制限により、このインストーラーは Windows 11 でのみ動作します。

ポータブル ZIP 配布形式はポータブルアプリケーションです。自動アップデートや自動更新チェックは行われません。このポータブル ZIP 配布形式は Windows 10（19041 以降）および Windows 11 で動作します。

| 配布形式         | アーキテクチャ    | リンク                                                 |
|------------------|:----------------:|--------------------------------------------------------|
| App Installer    | x64, arm64, x86  | [ダウンロード](https://aka.ms/terminal-canary-installer) |
| Portable ZIP     | x64              | [ダウンロード](https://aka.ms/terminal-canary-zip-x64)   |
| Portable ZIP     | ARM64            | [ダウンロード](https://aka.ms/terminal-canary-zip-arm64) |
| Portable ZIP     | x86              | [ダウンロード](https://aka.ms/terminal-canary-zip-x86)   |

_[Windows Terminal の配布形式の種類について詳しくはこちら](https://learn.microsoft.com/windows/terminal/distributions)。_

---

## Windows Terminal ロードマップ

Windows Terminal の計画は[こちら](/doc/roadmap-2023.md)で説明されており、
プロジェクトの進行に応じて随時更新されます。

## ターミナル & コンソールの概要

コードを読み始める前に、以下の概要に数分目を通してください：

### Windows Terminal

Windows Terminal はコマンドラインユーザー向けの新しい、モダンで多機能な生産性向上ターミナルアプリケーションです。タブ、リッチテキスト、グローバリゼーション、カスタマイズ性、テーマ・スタイリングなど、Windows コマンドラインコミュニティから最も要望の多かった機能を多数搭載しています。

Terminal は、速度と効率を維持し、メモリや電力を大量消費しないよう、目標と基準も満たす必要があります。

### Windows コンソールホスト

Windows コンソールホスト `conhost.exe` は、Windows の元祖コマンドラインユーザー体験です。また、Windows のコマンドライン基盤や Windows コンソール API サーバー、入力エンジン、描画エンジン、ユーザー設定などもホストします。このリポジトリのコンソールホストコードが Windows 自体の `conhost.exe` のビルド元となっています。

2014 年に Windows コマンドラインの管理を引き継いでから、チームはコンソールに多数の新機能を追加しました。たとえば、背景の透過、行単位の選択、[ANSI / 仮想ターミナルシーケンス](https://en.wikipedia.org/wiki/ANSI_escape_code) 対応、[24 ビットカラー](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/)、[擬似コンソール（ConPTY）](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) などです。

しかし、Windows コンソールの主目的が後方互換性の維持であるため、コミュニティ（およびチーム）が長年望んできた多くの機能（タブ、Unicode テキスト、絵文字など）は追加できませんでした。

これらの制約から新しい Windows Terminal を開発するに至りました。

> コマンドラインの進化や Windows コマンドラインの詳細は、
> [このブログ連載](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
> でご覧いただけます。

### 共有コンポーネント

Windows コンソールを刷新する際、コードベースを大幅にモダン化し、論理的な要素をモジュールやクラスに分離、重要な拡張ポイントを導入し、独自実装のコレクションやコンテナをより安全で効率的な [STL コンテナ](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) に置き換えました。また、Microsoft の [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) を活用し、コードをよりシンプルかつ安全にしました。

この刷新により、コンソールの主要なコンポーネントのいくつかが、Windows 上の任意のターミナル実装で再利用できるようになりました。たとえば、DirectWrite ベースの新しいテキストレイアウト・描画エンジン、UTF-16/UTF-8 両対応のテキストバッファ、VT パーサー／エミッターなどです。

### 新しい Windows Terminal の作成

新しい Windows Terminal アプリケーションの計画開始時、私たちは複数のアプローチと技術スタックを検討しました。最終的には、C++ コードベースへの投資を継続することが、既存コンソールと新しい Terminal の両方で先述のモダン化コンポーネントを再利用できるため、最善と判断しました。さらに、この選択により Terminal のコア部分を再利用可能な UI コントロールとして実装し、他のアプリケーションにも組み込めるようにしました。

この成果は本リポジトリに収められており、Microsoft Store から、または[リリースページ](https://github.com/microsoft/terminal/releases)から直接ダウンロードできます。

---

## リソース

Windows Terminal に関する詳細情報は、以下のリソースが参考になる場合があります：

* [コマンドラインブログ](https://devblogs.microsoft.com/commandline)
* [コマンドライン背景解説ブログ連載](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Windows Terminal ローンチ: [Terminal "Sizzle Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Windows Terminal ローンチ: [Build 2019 セッション](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal with Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [エピソード 54 - Kayla Cinnamon & Rich Turner on DevOps on the Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 セッション: [The Modern Windows Command Line: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### 新しい Terminal をビルドして実行したが、古いコンソールと同じに見える

原因：Visual Studio で誤ったソリューションを起動しています。

解決策：Visual Studio で `CascadiaPackage` プロジェクトをビルド＆デプロイしていることを確認してください。

> [!NOTE]
> `OpenConsole.exe` はローカルでビルドした `conhost.exe`（従来の Windows コンソール）です。OpenConsole は Windows Terminal がコマンドラインアプリケーション（[ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) 経由）と接続・通信するために使用されます。

---

## ドキュメント

すべてのプロジェクトドキュメントは [aka.ms/terminal-docs](https://aka.ms/terminal-docs) にあります。ドキュメントに貢献したい場合は、[Windows Terminal ドキュメントリポジトリ](https://github.com/MicrosoftDocs/terminal) にプルリクエストを送ってください。

---

## コントリビューション

私たちは素晴らしいコミュニティの皆さんと共に Windows Terminal の構築・改善を進めることを楽しみにしています！

***機能追加/修正作業を始める前に***、[コントリビューターガイド](./CONTRIBUTING.md) を必ずお読みいただき、重複や無駄な作業を避けてください。

## チームとのコミュニケーション

チームと連絡を取る最も簡単な方法は GitHub Issues です。

新しい Issue、機能要望や提案はぜひ投稿してください。ただし、**新しい Issue を作成する前に、類似のオープン/クローズ済み Issue がないか必ず検索してください。**

質問があり Issue を立てるほどではない場合は、Twitter でご連絡ください：

* Christopher Nguyen, プロダクトマネージャー: [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, エンジニアリングリード: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, シニアデベロッパー: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, デベロッパー: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, デベロッパー
* Leonard Hecker, デベロッパー: [@LeonardHecker](https://twitter.com/LeonardHecker)

## 開発者向けガイダンス

## 前提条件

Terminal をビルドするための環境は、次の2通りで構成できます：

### WinGet 構成ファイルを使う場合

リポジトリをクローンした後、[WinGet 構成ファイル](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine) を使って環境をセットアップできます。[デフォルトの構成ファイル](.config/configuration.winget) は Visual Studio 2022 Community と必要なツールをインストールします。.config ディレクトリには Visual Studio 2022 Enterprise & Professional エディション用の構成ファイルもあります。デフォルト構成ファイルを実行するには、エクスプローラーでダブルクリックするか、次のコマンドを実行してください：

```powershell
winget configure .config\configuration.winget
```

### 手動構成

* Windows 10 2004（ビルド >= 10.0.19041.0）以降が必要です
* [Windows 設定アプリで開発者モードを有効化](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development) してください
* [PowerShell 7 以降](https://github.com/PowerShell/PowerShell/releases/latest) をインストールしてください
* [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/) をインストールしてください
* [VS 2022](https://visualstudio.microsoft.com/downloads/) をインストールしてください
* VS インストーラーで下記のワークロードをインストールしてください。注：VS 2022 でソリューションを開くと[不足コンポーネントの自動インストールを促されます](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/)。
  * C++ によるデスクトップ開発
  * ユニバーサル Windows プラットフォーム開発
  * **以下の個別コンポーネント**
    * C++ (v143) ユニバーサル Windows プラットフォーム ツール
* テストプロジェクトをビルドするには [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) をインストールしてください

## コードのビルド

OpenConsole.sln は Visual Studio から、または **/tools** ディレクトリ内のスクリプト・ツールを使ってコマンドラインからビルドできます：

### PowerShell でのビルド

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Cmd でのビルド

```shell
.\tools\razzle.cmd
bcz
```

## 実行 & デバッグ

VS で Windows Terminal をデバッグするには、`CascadiaPackage`（ソリューションエクスプローラー内）を右クリックしてプロパティを開きます。デバッグメニューで「アプリケーションプロセス」と「バックグラウンドタスクプロセス」を「ネイティブのみ」に変更します。

その後、<kbd>F5</kbd> で Terminal プロジェクトのビルド＆デバッグが可能です。プラットフォームは「x64」または「x86」を選択してください（Terminal は C++ アプリのため "Any Cpu" ではビルドできません）。

> 👉 WindowsTerminal.exe を直接実行して Terminal を起動することはできません。理由の詳細は
> [#926](https://github.com/microsoft/terminal/issues/926)、
> [#4043](https://github.com/microsoft/terminal/issues/4043)
> をご覧ください。

### コーディングガイダンス

コーディング規約については、以下の簡単なドキュメントをご確認ください。

> 👉 ドキュメントに不足があれば、リポジトリ内のドキュメントファイルへの貢献（または新規作成）を歓迎します！

プロジェクトに貢献するために必要な情報を随時整理・追加していきます。

* [コーディングスタイル](./doc/STYLE.md)
* [コード構成](./doc/ORGANIZATION.md)
* [レガシーコードベースにおける例外](./doc/EXCEPTIONS.md)
* [WIL で Windows とやり取りするための便利なスマートポインタとマクロ](./doc/WIL.md)

---

## 行動規範

このプロジェクトは [Microsoft オープンソース行動規範][conduct-code] を採用しています。詳細は [行動規範 FAQ][conduct-FAQ] または [opencode@microsoft.com][conduct-email] までご連絡ください。

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---