![Envoy ロゴ](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[クラウドネイティブな高性能エッジ/ミドル/サービスプロキシ](https://www.envoyproxy.io/)

Envoy は [Cloud Native Computing Foundation](https://cncf.io)（CNCF）によってホストされています。コンテナパッケージ化され、動的にスケジューリングされ、マイクロサービス指向の技術の進化に貢献したい企業の方は、CNCF への参加をご検討ください。参加企業や Envoy の役割についての詳細は、CNCF の[発表](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/)をご覧ください。

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## ドキュメント

* [公式ドキュメント](https://www.envoyproxy.io/)
* [FAQ](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [サンプルドキュメント](https://github.com/envoyproxy/examples/)
* スレッドモデルに関する[ブログ](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310)
* ホットリスタートに関する[ブログ](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5)
* 統計アーキテクチャに関する[ブログ](https://medium.com/@mattklein123/envoy-stats-b65c7f363342)
* ユニバーサルデータプレーン API に関する[ブログ](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a)
* Lyft の Envoy ダッシュボードに関する[ブログ](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1)

## 関連

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): v2 API 定義のスタンドアロンリポジトリ。[api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/) の読み取り専用ミラーです。
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): パフォーマンステストフレームワーク。
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): 新しいフィルタの追加方法およびメインリポジトリへのリンク例。

## 連絡先

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): お知らせのみを配信する低頻度メーリングリスト。
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): セキュリティ関連のお知らせのみを配信する低頻度メーリングリスト。
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): 一般ユーザー向けディスカッション。
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): Envoy 開発者ディスカッション（API、機能設計など）。
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): すべてのコア Envoy メンテナーへの連絡用リスト。
* [Twitter](https://twitter.com/EnvoyProxy/): Twitter でフォローしてください！
* [Slack](https://envoyproxy.slack.com/): Slack への招待は[こちら](https://communityinviter.com/apps/envoyproxy/envoy)から。
  * 注意: Slack でのユーザー質問への対応はベストエフォートです。「確実な」回答が必要な場合は、以下のスレッドで案内している通り envoy-users@ へメールしてください。

メールリストの利用については[この](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY)スレッドをご覧ください。

## コントリビューション

Envoy への貢献は楽しく、モダンな C++ は未経験でも思っているほど難しくありません。始めるには：

* [コントリビューションガイド](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [初心者向け課題](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [Docker を使ったビルド/テストクイックスタート](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [開発者ガイド](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* 開発プロセス（特にコードレビュー関連）を自動化する Envoy [開発サポートツールチェーン](https://github.com/envoyproxy/envoy/blob/main/support/README.md) の導入を検討してください。
* 作業中の課題があれば必ずご連絡ください。重複作業を防ぐためです！

## コミュニティミーティング

Envoy チームは毎月 2 回、火曜日午前 9 時（PT）に定例ミーティングを開催しています。公開 Google カレンダーは[こちら](https://goo.gl/PkDijT)です。議題が[議事録](https://goo.gl/5Cergb)に記載されている場合のみミーティングが開催されます。コミュニティのどなたでも議事録に議題を追加できます。メンテナーが議題の追加を確認するか、確認された議題がなければ 24 時間前までにミーティングをキャンセルします。

## セキュリティ

### セキュリティ監査

Envoy セキュリティに関するいくつかのサードパーティ監査が実施されています：
* 2018 年に Cure53 がセキュリティ監査を実施、[完全レポート](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf)。
* 2021 年に Ada Logics がファジングインフラに関する監査と改善提案を実施、[完全レポート](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf)。

### セキュリティ脆弱性の報告

Envoy に脆弱性またはその可能性を発見した場合は、[envoy-security](mailto:envoy-security@googlegroups.com) までご連絡ください。報告を受領した旨の確認メールと、問題の特定ができ次第（肯定・否定いずれの場合も）追加でご連絡いたします。

詳細については、完全な[セキュリティリリースプロセス](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md)をご覧ください。

### ppc64le ビルド

ppc64le アーキテクチャまたは aws-lc を使用したビルドは envoy セキュリティポリシーの対象外です。ppc64le アーキテクチャは現在ベストエフォートであり、Envoy メンテナーによる保守対象ではありません。

## リリース

詳細については、[リリースプロセス](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md)をご覧ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---