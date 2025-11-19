# Flares 🔥

FlaresはCloudFlareのDNSバックアップツールで、DNSテーブルを画面に表示したり、BIND形式のゾーンファイルとしてエクスポートします。

[![BSD License](https://img.shields.io/badge/license-BSD-blue.svg?style=flat)](LICENSE)
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Flfaoro%2Fflares.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Flfaoro%2Fflares?ref=badge_shield)
[![Go Report Card](https://goreportcard.com/badge/github.com/lfaoro/flares)](https://goreportcard.com/report/github.com/lfaoro/flares)

![Docker Pulls](https://img.shields.io/docker/pulls/lfaoro/flares.svg?logo=docker&style=popout-square)
[![PayPal](https://img.shields.io/badge/paypal-contribute-blue.svg?style=popout-square&logo=paypal)](https://www.paypal.com/pools/c/8fm4OKBYMa)

## クイックスタート

### [ビデオチュートリアル](https://asciinema.org/a/NLVa6TyQzvTEhnzZDdH1q79lO)

### Docker

```bash
# Fetch your CloudFlare API token from here:
# https://dash.cloudflare.com/profile/api-tokens
# -> Create Token
# -> Edit zone DNS
# -> Permission: read
# -> Zone resources: Include -> All zones

$ export CF_API_TOKEN="KClp4y8BgD2LQiz2..."

$ docker run -it --rm \
-e CF_API_TOKEN="$CF_API_TOKEN" \
lfaoro/flares domain1.tld domain2.tld
```
### macOS

```bash
brew install lfaoro/tap/flares
```
### Linux/BSD

```bash
curl https://raw.githubusercontent.com/lfaoro/flares/master/install.sh | bash
```

### 開発者
> Go インストーラー: https://golang.org/dl/
```bash
go get -u github.com/lfaoro/flares
make install
flares -h

make test
```

## 例示

```bash
$ make install
$ flares -h

$ flares domain1.tld
;;
;; Domain:     domain1.tld
;; Exported:   2019-06-03 06:31:29
...continued

$ flares --export domain1.tld domain2.tld
BIND table for domain1.tld successfully exported
BIND table for domain2.tld successfully exported
$ ls
domain1.tld domain2.tld
```

## 自動化

### GitLab CI/CD

- リポジトリ内に [.gitlab-ci.yml](.gitlab-ci.yml) をコピーする
- [パイプラインスケジュール](https://gitlab.com/help/user/project/pipelines/schedules) 機能を使用する
- タスクの各実行で、ダウンロード可能なアーティファクトとして保存されるDNSバックアップが生成される

# 貢献

> どんな助けや提案も大歓迎で感謝します。まずは [issue](https://github.com/lfaoro/flares/issues/new) を開いてください。

- プロジェクトをフォークする
- 新しい機能ブランチを作成する `git checkout -b my-new-feature`
- 変更をコミットする `git commit -am 'Add my feature'`
- ブランチにプッシュする `git push origin my-new-feature`
- マスターブランチに対してプルリクエストを作成する


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-19

---