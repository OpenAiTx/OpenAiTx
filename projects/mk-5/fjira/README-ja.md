# Fjira - JiraのためのファジーファインダーおよびTUIアプリケーション。

<img src="https://raw.githubusercontent.com/mk-5/fjira/master/fjira.png" alt="drawing" width="256"/>

[![Mentioned in Awesome Go](https://awesome.re/badge-flat.svg)](https://github.com/avelino/awesome-go)
![Test](https://github.com/mk-5/fjira/actions/workflows/tests.yml/badge.svg)
[![License: AGPL v3](https://img.shields.io/badge/License-AGPL%20v3-blue.svg)](https://github.com/mk-5/fjira/blob/master/LICENSE)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/mk-5/fjira)
[![Go Report Card](https://goreportcard.com/badge/github.com/mk-5/fjira)](https://goreportcard.com/report/github.com/mk-5/fjira)
[![Go Reference](https://pkg.go.dev/badge/github.com/mk-5/fjira.svg)](https://pkg.go.dev/github.com/mk-5/fjira)
[![codecov](https://codecov.io/gh/mk-5/fjira/branch/master/graph/badge.svg?token=MJBTMYGQQW)](https://codecov.io/gh/mk-5/fjira)

## はじめに

Fjiraは、Jiraとのやり取りを簡素化するために設計された強力なコマンドラインツールです。開発者、
プロジェクトマネージャー、または単なるJira愛好家のいずれであっても、Fjiraはワークフローを効率化し、
Jiraのタスクをこれまで以上に効率的にします。

![Fjira Demo](https://raw.githubusercontent.com/mk-5/fjira/master/demo.gif)

## 主な特徴

- **ファジーファインドのようなインターフェース：** Jiraプロジェクトや課題を簡単に検索。
- **担当者の管理：** Jiraのインターフェースを操作せずに課題の担当者を迅速に変更。
- **ステータス更新：** ターミナルから直接Jira課題のステータスを更新。
- **効率的なコメント：** Jira課題に簡単にコメントを追加。
- **マルチワークスペース対応：** 複数のJiraワークスペースを簡単に管理。
- **カスタム検索：** Jira Query Language (JQL) を使ったカスタマイズ検索。
- **直接CLIアクセス：** コマンドラインから直接Jira課題にアクセス。
- **クロスプラットフォーム対応：** macOS、Linux、Windowsでシームレスに動作。

## インストール

### macOS

```shell
brew tap mk-5/mk-5
brew install fjira
```

### Linux

#### Ubuntu/Snap

```shell
snap install fjira
```
#### Deb

[https://github.com/mk-5/fjira/releases/latest](https://github.com/mk-5/fjira/releases/latest) を訪問し、  
最新のリリースバージョンを取得してください。


```shell
sudo dpkg -i fjira_0.4.0_linux_amd64.deb
```

#### AUR

```sh
yay -S fjira
```

#### バイナリ

```shell
tar -xvzf fjira_0.4.0_Linux_x86_64.tar.gz
cp fjira /usr/local/bin/fjira
```

### Windows

```shell
choco install fjira
```

### ソースからのビルド

```shell
make
./out/bin/fjira
```

## 使用方法

```text
Usage:
  fjira [flags]
  fjira [command]

Available Commands:
  [issueKey]  Open a Jira issue directly from the CLI
  completion  Generate the autocompletion script for the specified shell
  filters     Search using Jira filters
  help        Help about any command
  jql         Search using custom JQL queries
  version     Print the version number of fjira
  workspace   Switch to a different workspace

Flags:
  -h, --help             help for fjira
  -p, --project string   Open a project directly from CLI

Additional help topics:
  fjira            Open a fuzzy finder for projects as a default action

Use "fjira [command] --help" for more information about a command.
```

## はじめに

Fjira CLIの使用は簡単です。ターミナルで単にfjiraを実行してください。

```shell
fjira
```

## ワークスペース

Fjiraを初めて実行すると、JiraのAPI URLとトークンの入力を求められます。

![Fjira 初回実行](https://raw.githubusercontent.com/mk-5/fjira/master/demo_first_run.gif)

Fjiraのワークスペースは、`~/.fjira`にあるシンプルなYAMLファイルにJiraの設定データを保存します。  
`fjira workspace`コマンドを使って複数のワークスペースを切り替えることができます。

```shell
fjira workspace
```
新しいワークスペースを作成するには、次のコマンドを使用します：


```shell
fjira workspace --new abc
```

`--edit` フラグを使用して既存のワークスペースを編集できます：

```shell
fjira workspace --edit abc
```

### Jira トークンタイプ

Fjira は Jira Server と Jira Cloud の両方をサポートしており、認証には異なるトークンタイプを使用します。ツールは
ワークスペースの設定中に適切なトークンタイプを選択するよう促します。

```shell
? Jira Token Type:

1. api token
2. personal token

Enter a number (Default is 1):
```

### YAML 設定

手動で設定したい場合は、`~/.fjira/` ディレクトリに `fjira.yaml` ファイルを作成してワークスペース設定を追加することができます。  
参考までに、設定ファイルの例はこちらにあります: [fjira.yml](https://raw.githubusercontent.com/mk-5/fjira/master/assets/fjira.yaml)

## プロジェクト検索

`fjira` を実行したときのデフォルト画面はプロジェクト検索画面です。

```shell
fjira
```

## 特定のプロジェクトを開く

CLIから直接プロジェクトを開くことができます：

```shell
fjira --project=PROJ
```

これにより、プロジェクト検索画面をスキップして、直接課題検索画面に移動します。

## 課題を直接開く

CLIから直接課題を開くには：

```shell
fjira PROJ-123
```
Fjiraはすべての中間画面をスキップし、直接課題ビューに移動します。

![Fjira Issue View](https://raw.githubusercontent.com/mk-5/fjira/master/demo_issue.png)

## ボードビュー

Fjiraはボードのようなビューも提供します。プロジェクトを開いた後、F4キーを押してこのビューにアクセスします。

![Fjira Board View](https://raw.githubusercontent.com/mk-5/fjira/master/demo_board_view.png)

## カスタムJQLクエリ

FjiraではカスタムJQLクエリを作成して実行できます：


```shell
fjira jql
```

![Fjira Custom JQL](https://raw.githubusercontent.com/mk-5/fjira/master/demo_custom_jql.png)

## My Jira Filters

You can search using your stored (favourites) Jira Filters:

```shell
fjira filters
```

![Fjira フィルター](https://raw.githubusercontent.com/mk-5/fjira/master/demo_filters.png)

## カスタムカラースキーム

カスタムの `~/.fjira/colors.yml` ファイルを作成して、fjira のカラースキームをお好みに合わせて調整してください。  
このファイルを使うことで、あなたのスタイルに合わせて色をパーソナライズできます。  
例ファイルは以下の場所にあります: [colors.yml](https://raw.githubusercontent.com/mk-5/fjira/master/assets/colors.yml)

## ロードマップ（TODO）

- ドキュメントの拡充
- Jira フィルターの作成＆削除
- 追加の Linux パッケージマネージャーのサポート（Apt、AUR、YUM）
- さらなる Jira 機能の導入

## モチベーション

Fjira は個人の利便性のために設計され、効率性への欲求とターミナルツールへの愛から生まれました。  
よくあるのは「問題123を次のステータスに移したいだけ」という状況です。Jira を開き、  
ボード上のチケットを見つけ、Jira の課題モーダルを操作するのは全く問題ありませんが、  
それにはかなりの時間がかかります。

Fjira は、すでに作業しているであろうターミナルから直接そのような操作を実行できる力を与えてくれます！😄

もし Fjira が私と同様にあなたの Jira 体験を向上させたなら、GitHub でスターをつけてください。🌟  
それが今後の開発の力になります。

このプロジェクトへの貢献や将来を形作る手助けもぜひお願いします！  
あなたのフィードバックや貢献は非常に感謝されます。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---