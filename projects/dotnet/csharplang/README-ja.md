# C# 言語設計

[![https://gitter.im/dotnet/csharplang でチャットに参加する](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Discord でチャット](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

C# 言語設計の公式リポジトリへようこそ。ここでは新しい C# 言語機能が開発、採用、仕様策定されています。

C# は [Roslyn](https://github.com/dotnet/roslyn) プロジェクトと密接に連携しながら、C# 言語設計チーム (LDT) によって設計されています。

以下のものが見つかります：

- [proposals フォルダー](proposals) にあるアクティブな C# 言語機能提案
- [meetings フォルダー](meetings) にある C# 言語設計会議のメモ
- [言語バージョン履歴の概要はこちら](Language-Version-History.md)

上記にバグや不備を発見した場合は、issue を立てて報告してください。さらに良いのは、それを修正する pull request を送ることです。

*新機能提案* については、[ディスカッション](https://github.com/dotnet/csharplang/labels/Discussion) で提起し、言語設計チームのメンバー（「チャンピオン」）から招待された場合のみ、issue や pull request として提案書を提出してください。

完全な設計プロセスは[こちら](Design-Process.md)に記載されています。簡単な概要は以下の通りです。

## ディスカッション

言語機能に関する議論は、このリポジトリの [Discussions](https://github.com/dotnet/csharplang/discussions) という形で行われます。

機能の提案、現在の設計メモや提案について議論したい場合は、[新しいディスカッション トピックを立てて](https://github.com/dotnet/csharplang/discussions/new)ください。

短く、話題から逸れないディスカッションは読まれやすくなります。50 番目のコメントを残しても、読んでくれる人は少数です。ディスカッションをナビゲートしやすくし、有益にするために、次のルールを守ってください：

- ディスカッションは C# の言語設計に関係するものであるべきです。そうでない場合は即座にクローズされます。
- 議論の範囲を明確に伝える記述的なトピックを選んでください。
- 議論の話題に集中してください。コメントが本題から逸れていたり、サブトピックの詳細に踏み込む場合は、新しいディスカッションを始めてリンクを貼ってください。
- あなたのコメントは他の人が読むのに有用ですか？それとも既存コメントへの絵文字リアクションで十分表現できますか？

特定の構文の出現を防ぐ言語提案は [Roslyn アナライザー](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers) で実現できます。既存の構文をオプションで違法にするだけの提案は、言語の複雑化を防ぐため、言語設計委員会によって却下されます。

## 提案

C# LDM のメンバーが、提案がチーム全体で検討に値すると判断した場合、[Champion](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22) としてチャンピオンし、C# 言語設計会議に持ち込みます。提案は常にリンクされたディスカッションで議論され、チャンピオン issue で議論は行いません。以前はこの方針に従っていなかったため、多くのチャンピオン issue にはディスカッションがありますが、現在は新たな議論が発生しないよう issue をロックしています。各チャンピオン issue にはディスカッションへのリンクがあります。

## 設計プロセス

[提案](proposals) は、[言語設計会議](meetings) での決定、[ディスカッション](https://github.com/dotnet/csharplang/discussions)、実験、オフライン設計作業の結果として進化します。

多くの場合、正しい設計にたどり着き、最終的に機能を採用するかどうかを判断するためには、機能のプロトタイプを実装して共有する必要があります。プロトタイプは、機能の実装や使い勝手の課題を発見するのに役立ちます。プロトタイプは [Roslyn リポジトリ](https://github.com/dotnet/roslyn) のフォークで実装し、次の基準を満たす必要があります：

- （該当する場合）パース処理は実験に対して堅牢であること：入力操作でクラッシュしないこと。
- 機能がエンドツーエンドで動作することを示す最小限のテストを含むこと。
- 最小限の IDE サポート（キーワードの色付け、フォーマット、補完）を含むこと。

承認されたら、機能は [Roslyn](https://github.com/dotnet/roslyn) で完全に実装され、[言語仕様](spec) で完全に記述され、提案は完了した機能用の適切なフォルダー、例：[C# 7.1 proposals](proposals/csharp-7.1) に移動されます。

**免責事項**：アクティブな提案は、C# プログラミング言語の将来のバージョンに含まれることが検討されていますが、次期バージョンまたは将来のいかなるバージョンにも最終的に含まれることが保証されるものではありません。提案は、上記プロセスのいかなる段階でも、設計チーム、コミュニティ、コードレビュアー、テストなどからのフィードバックに基づき、延期または却下される場合があります。

### マイルストーン

このリポジトリの issue にはいくつかのマイルストーンがあります：
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) は、現在積極的に作業中のチャンピオン提案のセットです。このマイルストーン内のすべてが次期 C# バージョンに入るわけではありませんが、次のリリース期間中に設計作業が行われます。
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) は、トリアージ済みだが現在積極的に作業されていないチャンピオン提案のセットです。これらの提案に関するコミュニティからの議論やアイデアは歓迎されますが、設計作業や実装レビューのコストが高いため、我々が準備できるまでコミュニティによる実装は考慮されません。
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) は、トリアージ済みだが現在積極的に作業されていない、コミュニティ実装が可能なチャンピオン提案のセットです。このマイルストーンの issue には「仕様の承認が必要」、「実装が必要」の2つの状態があります。仕様が必要なものは LDM で仕様承認を受ける必要がありますが、できるだけ早いタイミングで時間を取る意向です。
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) は、LDM によって言語から却下された提案のセットです。強いニーズやコミュニティからのフィードバックがない限り、将来的にこれらの提案が再検討されることはありません。
* ナンバリングされたマイルストーンは、その特定の言語バージョンで実装された機能のセットです。クローズされたマイルストーンは、そのリリースと共に出荷されたものです。オープンなマイルストーンは、リリース直前に互換性やその他の問題が見つかった場合、後で機能が除外される可能性があります。

## 言語設計会議

言語設計会議 (LDM) は LDT と時折招待されたゲストによって開催され、[meetings](meetings) フォルダーの設計会議メモとして文書化され、年ごとのフォルダーに整理されています。設計会議メモのライフサイクルは [meetings/README.md](meetings/README.md) に記載されています。LDM では、今後の C# バージョンに関する決定（どの提案に取り組むか、提案をどう進化させるか、採用の可否と時期など）が行われます。

## 言語仕様

現行の ECMA-334 仕様は、[C# Language Standard](https://github.com/dotnet/csharpstandard/) リポジトリで markdown 形式で参照できます。

## 実装

C# 言語のリファレンス実装は [Roslyn リポジトリ](https://github.com/dotnet/roslyn) にあります。このリポジトリでは[言語機能の実装状況](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md) も追跡しています。最近まで、言語設計の成果物もここで管理されていました。現在、アクティブな提案の移行作業中のため、少しお時間をいただく場合があります。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---