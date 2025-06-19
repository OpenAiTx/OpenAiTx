# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## .NET Aspireとは？

.NET Aspireは、観測可能で本番対応可能な分散アプリケーションを構築するための、意見のあるクラウド対応スタックです。.NET Aspireは、特定のクラウドネイティブな課題に対応するNuGetパッケージのコレクションとして提供されます。クラウドネイティブアプリは、単一のモノリシックなコードベースではなく、小さく相互接続されたマイクロサービスなどの構成要素から成ることが一般的です。また、クラウドネイティブアプリは、データベース、メッセージング、キャッシュなど多くのサービスを利用します。

.NET Aspireは以下を支援します:

[オーケストレーション](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspireは、複数プロジェクトのアプリケーションおよびその依存関係を実行・接続するための機能を提供します。

[インテグレーション](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): .NET Aspireのインテグレーションは、RedisやPostgresなど一般的なサービス用のNuGetパッケージで、標準化されたインターフェースにより、アプリと一貫してシームレスに接続できることを保証します。

[ツーリング](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspireは、Visual Studioおよびdotnet CLI用のプロジェクトテンプレートやツーリング体験を提供し、.NET Aspireアプリの作成や操作を支援します。

詳細については、[.NET Aspireの概要とドキュメント](https://learn.microsoft.com/dotnet/aspire/)を参照してください。サンプルは[.NET Aspire サンプルリポジトリ](https://github.com/dotnet/aspire-samples)で利用可能です。[eShopサンプルはこちら](https://github.com/dotnet/eshop)、[Azureバージョンはこちら](https://github.com/Azure-Samples/eShopOnAzure)です。

## このリポジトリには何が含まれていますか？

.NET Aspireのアプリケーションホスト、ダッシュボード、サービスディスカバリ基盤、およびすべての.NET Aspireインテグレーションが含まれています。また、プロジェクトテンプレートも含まれています。

## 最新のデイリービルドの利用

[docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md)の手順に従って、最新のデイリービルドで.NET Aspireの利用を開始してください。

## 貢献するには？

私たちは貢献を歓迎します！世界中の多くの人々が.NETの向上に協力しています。

このリポジトリのコード作業については、[docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md)の手順に従ってください。

## セキュリティ問題やバグの報告

セキュリティの問題やバグは、Microsoft Security Response Center (MSRC) <secure@microsoft.com> までプライベートにメールで報告してください。24時間以内に返信が届くはずです。万が一返信がない場合は、元のメッセージが届いているか確認するため再度メールでご連絡ください。詳細やMSRCのPGPキーは[Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue)でご確認いただけます。これらの手順は、このリポジトリの[Security doc](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md)にも記載されています。

また、関連する[Microsoft .NET CoreおよびASP.NET Core バグバウンティプログラム](https://www.microsoft.com/msrc/bounty-dot-net-core)についての情報もご覧ください。

### .NET Aspireリソースおよびクライアントインテグレーションで使用されるコンテナについての注意

.NETチームは、APIサポートしているサードパーティ製コンテナの基盤部分が、特定のお客様要件に適合するかどうかを評価することはできません。

Aspireで組み合わせて自動化するコンテナは、セキュリティや安全性、暗号規制、その他の規制や企業基準など、ご自身・雇用者・政府の要件を満たしているかご自身で評価してください。

## .NET Foundation

.NET Aspireは[.NET Foundation](https://www.dotnetfoundation.org/projects)プロジェクトです。

GitHubには多くの.NET関連プロジェクトがあります。

* [.NET home repo](https://github.com/Microsoft/dotnet) - Microsoftおよびコミュニティによる数百の.NETプロジェクトへのリンク。
* [ASP.NET Core home](https://docs.microsoft.com/aspnet/core) - ASP.NET Coreについて学ぶ最適なスタート地点。

このプロジェクトは、[Contributor Covenant](https://contributor-covenant.org)で定義される行動規範を採用しており、コミュニティで期待される振る舞いを明確にしています。詳細は[.NET Foundation行動規範](https://www.dotnetfoundation.org/code-of-conduct)をご覧ください。

## ライセンス

このリポジトリのコードは[MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT)ライセンスで提供されています。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---