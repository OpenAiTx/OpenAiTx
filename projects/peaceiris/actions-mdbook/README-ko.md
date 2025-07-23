<h2 align="center">
mdBook용 GitHub Actions
</h2>

<div align="center">
  <img src="https://raw.githubusercontent.com/peaceiris/actions-mdbook/main/images/ogp.jpg" alt="mdBook용 GitHub Actions 썸네일" width="500px">
</div>

[![license](https://img.shields.io/github/license/peaceiris/actions-mdbook.svg)](https://github.com/peaceiris/actions-mdbook/blob/main/LICENSE)
[![release](https://img.shields.io/github/release/peaceiris/actions-mdbook.svg)](https://github.com/peaceiris/actions-mdbook/releases/latest)
[![GitHub release date](https://img.shields.io/github/release-date/peaceiris/actions-mdbook.svg)](https://github.com/peaceiris/actions-mdbook/releases)
![Test](https://github.com/peaceiris/actions-mdbook/workflows/Test/badge.svg?branch=main&event=push)
[![CodeFactor](https://www.codefactor.io/repository/github/peaceiris/actions-mdbook/badge)](https://www.codefactor.io/repository/github/peaceiris/actions-mdbook)
[![codecov](https://codecov.io/gh/peaceiris/actions-mdbook/branch/main/graph/badge.svg)](https://codecov.io/gh/peaceiris/actions-mdbook)
[![Release Feed](https://img.shields.io/badge/release-feed-yellow)](https://github.com/peaceiris/actions-mdbook/releases.atom)

[rust-lang/mdBook] 설정 액션.

[rust-lang/mdBook]: https://github.com/rust-lang/mdBook

이 mdBook 액션을 통해 **GitHub Actions**의 가상 머신에서 **mdBook**을 실행할 수 있습니다.
Linux, macOS, Windows를 지원합니다.

| OS (runs-on) | ubuntu-20.04, ubuntu-22.04 | macos-latest | windows-2019 |
|---|:---:|:---:|:---:|
| 지원 | ✅️ | ✅️ | ✅️ |



## 목차

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->


- [시작하기](#getting-started)
  - [⭐️ 워크플로우 생성하기](#%EF%B8%8F-create-your-workflow)
- [옵션](#options)
  - [⭐️ 최신 mdBook 버전 사용하기](#%EF%B8%8F-use-the-latest-version-of-mdbook)
- [팁](#tips)
  - [⭐️ 파일에서 mdBook 버전 읽기](#%EF%B8%8F-read-mdbook-version-from-file)
- [변경 로그](#changelog)
- [라이선스](#license)
- [유지 관리자 정보](#about-maintainer)
- [유지 관리자 노트](#maintainer-notes)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->



## 시작하기

### ⭐️ 워크플로우 생성하기

[GitHub Pages용 GitHub Actions]를 사용한 예제 워크플로우 `.github/workflows/gh-pages.yml`.
첫 배포 시에는 다음 작업을 수행해야 합니다: [GITHUB_TOKEN을 사용한 첫 배포 - peaceiris/actions-gh-pages](https://github.com/peaceiris/actions-gh-pages#%EF%B8%8F-first-deployment-with-github_token)

[GitHub Pages용 GitHub Actions]: https://github.com/peaceiris/actions-gh-pages

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
<a href="#table-of-contents">목차로 돌아가기 ☝️</a>
</div>



## 옵션

### ⭐️ 최신 버전의 mdBook 사용하기

`mdbook-version: 'latest'`로 설정하여 최신 버전의 mdBook을 사용하세요.


```yaml
- name: Setup mdBook
  uses: peaceiris/actions-mdbook@v2
  with:
    mdbook-version: 'latest'
```
이 작업은 [mdbook — Homebrew Formulae](https://formulae.brew.sh/formula/mdbook)에서 mdBook의 최신 버전을 가져옵니다.

<div align="right">
<a href="#table-of-contents">목차로 돌아가기 ☝️</a>
</div>



## 팁

### ⭐️ 파일에서 mdBook 버전 읽기

`.env` 파일을 통해 Docker Compose와 GitHub Actions 워크플로 간에 mdBook 버전을 동기화하는 방법입니다.

`MDBOOK_VERSION`을 다음과 같이 `.env` 파일에 작성하고 원격 브랜치에 푸시합니다.


```sh
MDBOOK_VERSION=0.4.10
```
다음으로, `.env` 파일에서 mdBook 버전을 읽는 단계를 추가하세요.


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


다음은 `docker-compose.yml` 예제입니다.


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


알파인 베이스 mdBook Docker 이미지는 다음 저장소에서 제공됩니다.

> [peaceiris/docker-mdbook: mdBook Alpine Base Docker Image.](https://github.com/peaceiris/docker-mdbook)

<div align="right">
<a href="#table-of-contents">목차로 돌아가기 ☝️</a>
</div>



## 변경 로그

- [CHANGELOG.md](https://raw.githubusercontent.com/peaceiris/actions-mdbook/main/CHANGELOG.md)



## 라이선스

- [MIT 라이선스 - peaceiris/actions-mdbook]

[MIT 라이선스 - peaceiris/actions-mdbook]: https://github.com/peaceiris/actions-mdbook/blob/main/LICENSE



## 유지 관리자 정보

- [peaceiris 홈페이지](https://peaceiris.com/)
- [GitHub Action Hero: Shohei Ueda - The GitHub Blog](https://github.blog/2020-03-22-github-action-hero-shohei-ueda/)



## 유지 관리자 노트

컨테이너에서 `npm` 및 `git commit` 명령어를 실행하세요.

**호스트에서**


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