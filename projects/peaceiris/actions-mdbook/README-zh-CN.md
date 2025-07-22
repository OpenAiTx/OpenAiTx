<h2 align="center">
mdBook 的 GitHub Actions
</h2>

<div align="center">
  <img src="https://raw.githubusercontent.com/peaceiris/actions-mdbook/main/images/ogp.jpg" alt="mdBook 的 GitHub Actions 缩略图" width="500px">
</div>

[![license](https://img.shields.io/github/license/peaceiris/actions-mdbook.svg)](https://github.com/peaceiris/actions-mdbook/blob/main/LICENSE)
[![release](https://img.shields.io/github/release/peaceiris/actions-mdbook.svg)](https://github.com/peaceiris/actions-mdbook/releases/latest)
[![GitHub release date](https://img.shields.io/github/release-date/peaceiris/actions-mdbook.svg)](https://github.com/peaceiris/actions-mdbook/releases)
![Test](https://github.com/peaceiris/actions-mdbook/workflows/Test/badge.svg?branch=main&event=push)
[![CodeFactor](https://www.codefactor.io/repository/github/peaceiris/actions-mdbook/badge)](https://www.codefactor.io/repository/github/peaceiris/actions-mdbook)
[![codecov](https://codecov.io/gh/peaceiris/actions-mdbook/branch/main/graph/badge.svg)](https://codecov.io/gh/peaceiris/actions-mdbook)
[![Release Feed](https://img.shields.io/badge/release-feed-yellow)](https://github.com/peaceiris/actions-mdbook/releases.atom)

[rust-lang/mdBook] 设置 Action。

[rust-lang/mdBook]: https://github.com/rust-lang/mdBook

我们可以通过此 mdBook Action 在 **GitHub Actions** 的虚拟机上运行 **mdBook**。
支持 Linux、macOS 和 Windows。

| 操作系统 (runs-on) | ubuntu-20.04, ubuntu-22.04 | macos-latest | windows-2019 |
|---|:---:|:---:|:---:|
| 支持 | ✅️ | ✅️ | ✅️ |



## 目录

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->


- [快速开始](#getting-started)
  - [⭐️ 创建你的工作流](#%EF%B8%8F-create-your-workflow)
- [选项](#options)
  - [⭐️ 使用最新版本的 mdBook](#%EF%B8%8F-use-the-latest-version-of-mdbook)
- [技巧](#tips)
  - [⭐️ 从文件读取 mdBook 版本](#%EF%B8%8F-read-mdbook-version-from-file)
- [更新日志](#changelog)
- [许可证](#license)
- [关于维护者](#about-maintainer)
- [维护者备注](#maintainer-notes)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->



## 快速开始

### ⭐️ 创建你的工作流

一个示例工作流 `.github/workflows/gh-pages.yml`，使用 [GitHub Actions for GitHub Pages]。
首次部署时，我们必须执行此操作：[使用 `GITHUB_TOKEN` 的首次部署 - peaceiris/actions-gh-pages](https://github.com/peaceiris/actions-gh-pages#%EF%B8%8F-first-deployment-with-github_token)

[GitHub Actions for GitHub Pages]: https://github.com/peaceiris/actions-gh-pages

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
<a href="#table-of-contents">返回目录 ☝️</a>
</div>



## 选项

### ⭐️ 使用最新版本的 mdBook

设置 `mdbook-version: 'latest'` 以使用最新版本的 mdBook。


```yaml
- name: Setup mdBook
  uses: peaceiris/actions-mdbook@v2
  with:
    mdbook-version: 'latest'
```
<translate-content>
此操作通过 [mdbook — Homebrew Formulae](https://formulae.brew.sh/formula/mdbook) 获取 mdBook 的最新版本

<div align="right">
<a href="#table-of-contents">返回目录 ☝️</a>
</div>



## 小贴士

### ⭐️ 从文件读取 mdBook 版本

如何通过 `.env` 文件在 Docker Compose 和 GitHub Actions 工作流之间同步 mdBook 版本。

将 `MDBOOK_VERSION` 写入 `.env` 文件，如下所示，并推送到远程分支。
</translate-content>
```sh
MDBOOK_VERSION=0.4.10
```
接下来，添加一个步骤，从 `.env` 文件中读取 mdBook 版本。


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
这里是一个 `docker-compose.yml` 示例。


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
<a href="#table-of-contents">返回目录 ☝️</a>
</div>



## 更新日志

- [CHANGELOG.md](https://raw.githubusercontent.com/peaceiris/actions-mdbook/main/CHANGELOG.md)



## 许可证

- [MIT 许可证 - peaceiris/actions-mdbook]

[MIT 许可证 - peaceiris/actions-mdbook]: https://github.com/peaceiris/actions-mdbook/blob/main/LICENSE



## 关于维护者

- [peaceiris 主页](https://peaceiris.com/)
- [GitHub Action 英雄：Shohei Ueda - The GitHub Blog](https://github.blog/2020-03-22-github-action-hero-shohei-ueda/)



## 维护者备注

在容器中运行 `npm` 和 `git commit` 命令。

**在主机上**


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