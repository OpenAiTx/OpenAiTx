# アトランティス <!-- omit in toc -->

[![最新リリース](https://img.shields.io/github/release/runatlantis/atlantis.svg)](https://github.com/runatlantis/atlantis/releases/latest)
[![SuperDopeBadge](https://raw.githubusercontent.com/runatlantis/atlantis/main/./runatlantis.io/public/hightower-super-dope.svg)](https://twitter.com/kelseyhightower/status/893260922222813184)
[![Go Report Card](https://goreportcard.com/badge/github.com/runatlantis/atlantis)](https://goreportcard.com/report/github.com/runatlantis/atlantis)
[![Go Reference](https://pkg.go.dev/badge/github.com/runatlantis/atlantis.svg)](https://pkg.go.dev/github.com/runatlantis/atlantis)
[![Slack](https://img.shields.io/badge/Join-Atlantis%20Community%20Slack-red)](https://slack.cncf.io/)
[![OpenSSF Scorecard](https://api.scorecard.dev/projects/github.com/runatlantis/atlantis/badge)](https://scorecard.dev/viewer/?uri=github.com/runatlantis/atlantis)
[![OpenSSF Best Practices](https://www.bestpractices.dev/projects/9428/badge)](https://www.bestpractices.dev/projects/9428)

<p align="center">
  <img src="https://raw.githubusercontent.com/runatlantis/atlantis/main/./runatlantis.io/public/hero.png" alt="Atlantis Logo"/><br><br>
  <b>Terraform プルリクエスト自動化ツール</b>
</p>

- [リソース](#resources)
- [Atlantisとは？](#what-is-atlantis)
- [何をするのか？](#what-does-it-do)
- [なぜ使うべきか？](#why-should-you-use-it)
- [スター数の推移](#stargazers-over-time)

## リソース
* はじめ方: [www.runatlantis.io/guide](https://www.runatlantis.io/guide)
* 完全なドキュメント: [www.runatlantis.io/docs](https://www.runatlantis.io/docs)
* 最新リリースのダウンロード: [github.com/runatlantis/atlantis/releases/latest](https://github.com/runatlantis/atlantis/releases/latest)
* [Slackチャンネル](https://slack.cncf.io/)の #atlantis および開発用の #atlantis-contributors でサポートを受ける
* 貢献を始める: [CONTRIBUTING.md](https://raw.githubusercontent.com/runatlantis/atlantis/main/CONTRIBUTING.md)

## Atlantisとは？
TerraformのプルリクエストイベントをWebhook経由で監視するセルフホスト型のGolangアプリケーション。

## 何をするのか？
`terraform plan`、`import`、`apply` をリモートで実行し、プルリクエストに実行結果をコメントとして返します。

## なぜ使うべきか？
* Terraformの変更をチーム全体に見えるようにする。
* 非オペレーションエンジニアでもTerraformに協力できるようにする。
* Terraformのワークフローを標準化する。

## スター数の推移

[![Stargazers over time](https://starchart.cc/runatlantis/atlantis.svg)](https://starchart.cc/runatlantis/atlantis)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-07

---