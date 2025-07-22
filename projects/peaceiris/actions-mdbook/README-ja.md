<h2 align="center">
mdBook 用 GitHub Actions
</h2>

<div align="center">
  <img src="https://raw.githubusercontent.com/peaceiris/actions-mdbook/main/images/ogp.jpg" alt="mdBook 用 GitHub Actions サムネイル" width="500px">
</div>

[![license](https://img.shields.io/github/license/peaceiris/actions-mdbook.svg)](https://github.com/peaceiris/actions-mdbook/blob/main/LICENSE)
[![release](https://img.shields.io/github/release/peaceiris/actions-mdbook.svg)](https://github.com/peaceiris/actions-mdbook/releases/latest)
[![GitHub release date](https://img.shields.io/github/release-date/peaceiris/actions-mdbook.svg)](https://github.com/peaceiris/actions-mdbook/releases)
![Test](https://github.com/peaceiris/actions-mdbook/workflows/Test/badge.svg?branch=main&event=push)
[![CodeFactor](https://www.codefactor.io/repository/github/peaceiris/actions-mdbook/badge)](https://www.codefactor.io/repository/github/peaceiris/actions-mdbook)
[![codecov](https://codecov.io/gh/peaceiris/actions-mdbook/branch/main/graph/badge.svg)](https://codecov.io/gh/peaceiris/actions-mdbook)
[![Release Feed](https://img.shields.io/badge/release-feed-yellow)](https://github.com/peaceiris/actions-mdbook/releases.atom)

[rust-lang/mdBook] セットアップアクション。

[rust-lang/mdBook]: https://github.com/rust-lang/mdBook

この mdBook アクションにより、**GitHub Actions** の仮想マシン上で **mdBook** を実行できます。
Linux、macOS、Windows がサポートされています。

| OS (runs-on) | ubuntu-20.04, ubuntu-22.04 | macos-latest | windows-2019 |
|---|:---:|:---:|:---:|
| サポート | ✅️ | ✅️ | ✅️ |



## 目次

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->


- [はじめに](#getting-started)
  - [⭐️ ワークフローを作成する](#%EF%B8%8F-create-your-workflow)
- [オプション](#options)
  - [⭐️ mdBook の最新バージョンを使う](#%EF%B8%8F-use-the-latest-version-of-mdbook)
- [ヒント](#tips)
  - [⭐️ ファイルから mdBook バージョンを読み取る](#%EF%B8%8F-read-mdbook-version-from-file)
- [変更履歴](#changelog)
- [ライセンス](#license)
- [メンテナについて](#about-maintainer)
- [メンテナノート](#maintainer-notes)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->



## はじめに

### ⭐️ ワークフローを作成する

[GitHub Pages 用 GitHub Actions] を使ったサンプルワークフロー `.github/workflows/gh-pages.yml`。
初回デプロイでは、次の操作が必要です：[First Deployment with `GITHUB_TOKEN` - peaceiris/actions-gh-pages](https://github.com/peaceiris/actions-gh-pages#%EF%B8%8F-first-deployment-with-github_token)

[GitHub Pages 用 GitHub Actions]: https://github.com/peaceiris/actions-gh-pages

[![peaceiris/actions-gh-pages - GitHub](https://gh-card.dev/repos/peaceiris/actions-gh-pages.svg?fullname)](https://github.com/peaceiris/actions-gh-pages)

```yaml
name: github pages

on:
  push:
    branches:
      - main
  pull_request:

jobs:
  deploy:
    runs-on: ubuntu-20.04
    concurrency:
      group: ${{ github.workflow }}-${{ github.ref }}
    steps:
      - uses: actions/checkout@v2

      - name: Setup mdBook
        uses: peaceiris/actions-mdbook@v2
        with:
          mdbook-version: '0.4.10'
          # mdbook-version: 'latest'

      - run: mdbook build

      - name: Deploy
        uses: peaceiris/actions-gh-pages@v3
        if: ${{ github.ref == 'refs/heads/main' }}
        with:
          github_token: ${{ secrets.GITHUB_TOKEN }}
          publish_dir: ./book
```
<div align="right">
<a href="#table-of-contents">目次に戻る ☝️</a>
</div>



## オプション

### ⭐️ 最新バージョンの mdBook を使う

`mdbook-version: 'latest'` を設定すると最新バージョンの mdBook を使用します。


```yaml
- name: Setup mdBook
  uses: peaceiris/actions-mdbook@v2
  with:
    mdbook-version: 'latest'
```
<translate-content>
このアクションは[mdbook — Homebrew Formulae](https://formulae.brew.sh/formula/mdbook)から最新バージョンのmdBookを取得します。

<div align="right">
<a href="#table-of-contents">目次へ戻る ☝️</a>
</div>



## ヒント

### ⭐️ ファイルからmdBookのバージョンを読み取る

`.env`ファイルを介して、Docker ComposeとGitHub Actionsワークフロー間でmdBookのバージョンを同期する方法。

以下のように`MDBOOK_VERSION`を`.env`ファイルに書き込み、リモートブランチにプッシュします。
</translate-content>
```sh
MDBOOK_VERSION=0.4.10
```
次に、`.env` ファイルから mdBook のバージョンを読み取るステップを追加します。


```yaml
    - name: Read .env
      id: mdbook-version
      run: |
        . ./.env
        echo "::set-output name=MDBOOK_VERSION::${MDBOOK_VERSION}"

    - name: Setup mdBook
      uses: peaceiris/actions-mdbook@v2
      with:
        mdbook-version: '${{ steps.mdbook-version.outputs.MDBOOK_VERSION }}'
```
<translate-content>
ここに `docker-compose.yml` の例があります。
</translate-content>
```yaml
version: '3'

services:
  mdbook:
    container_name: mdbook
    image: "peaceiris/mdbook:v${MDBOOK_VERSION}"
    # image: "peaceiris/mdbook:v${MDBOOK_VERSION}-rust"  # Large image including Rust compiler
    stdin_open: true
    tty: true
    ports:
      - 3000:3000
      - 3001:3001
    volumes:
      - ${PWD}:/book
    command:
      - serve
      - --hostname
      - '0.0.0.0'
```
The alpine base mdBook Docker image is provided on the following repository.

> [peaceiris/docker-mdbook: mdBook Alpine Base Docker Image.](https://github.com/peaceiris/docker-mdbook)

<div align="right">
<a href="#table-of-contents">Back to TOC ☝️</a>
</div>



## CHANGELOG

- [CHANGELOG.md](https://raw.githubusercontent.com/peaceiris/actions-mdbook/main/CHANGELOG.md)



## License

- [MIT License - peaceiris/actions-mdbook]

[MIT License - peaceiris/actions-mdbook]: https://github.com/peaceiris/actions-mdbook/blob/main/LICENSE



## About Maintainer

- [peaceiris ホームページ](https://peaceiris.com/)
- [GitHub Action Hero: Shohei Ueda - The GitHub Blog](https://github.blog/2020-03-22-github-action-hero-shohei-ueda/)



## Maintainer Notes

コンテナ上で `npm` と `git commit` コマンドを実行します。

**ホスト上で**


```sh
# Docker
make build
make run
make run cmd="env"
make test
make commit msg="chore: Add Makefile"

# Release
./release.sh
```



<div align="right">
<a href="#table-of-contents">Back to TOC ☝️</a>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---