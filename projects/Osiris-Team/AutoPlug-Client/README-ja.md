<div align="center">
   <img src="https://i.imgur.com/BMpvtWP.png">
</div>

 AutoPlug-Clientはスタンドアロンの実行可能なJavaプログラムで、複数の実行モード（サーバーラッパー、CLIツール、バックグラウンドサービス）を持ちます。主な目的は、サーバー関連のソフトウェアの自動更新と、サーバーのメンテナンスを簡素化することです。すべてのサーバータイプ（Steamゲームサーバーを含む）に対応していますが、その機能の大部分は、世界で最も売れているゲームであり、非常に広範なモッディングコミュニティを持つMinecraftに特化しています。
 
## リンク

- 安定版/ベータ版は[AutoPlug-Releases](https://github.com/Osiris-Team/AutoPlug-Releases)リポジトリからダウンロードできます。
- [AutoPlug-Client-Development](https://bit.ly/acprogress)をフォローして、現在の開発状況を確認してください。
- [寄付](https://www.paypal.com/donate?hosted_button_id=JNXQCWF2TF9W4)で開発を支援してください。
- 問題や質問がありますか？ [FAQ](/docs/FAQ.md)をチェックするか、ライブチャット/ボイスサポートのために[Discord](https://discord.com/invite/GGNmtCC)に参加してください。

## 何ができるのか？

- 自動化された自己更新、サーバーソフトウェア、プラグイン、モッド、およびJRE（Javaランタイム環境）の更新
- スケジュールされたサーバー再起動
- 自動化されたモジュール化バックアップ作成
- 高速、非同期、マルチスレッドのタスク実行
- 同期（共有）フォルダの利用
- サーバーの起動、停止、再起動および最新の更新結果の概要を表示するWebパネル

プレミアム[AutoPlug-Web](https://autoplug.one)機能：

- [オンラインコンソール](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/online-console.gif)
- [オンラインファイルマネージャー](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/file-manager.gif)
- スタッフアクセス
- プラグイン詳細データベース

## ステータス
安定かつ機能完備のため、コミュニティ主導の開発となっており、リード開発者は新機能の開発を行わず、他者からのプルリクエストに依存します。ただし、セキュリティ問題や重大なバグについては例外です。

## コミュニティプロジェクト

- Dockerサポート: https://github.com/lkkuma/AutoPlug-Client-Docker
- Pterodactlyパネルサポート: https://github.com/ImLunaUwU/PteroPlug

開発者: 


また、[Maven/Gradle/Sbt/Leinigen](https://jitpack.io/#Osiris-Team/AutoPlug-Client/-SNAPSHOT) を通じて依存関係として追加することで、プロジェクトにAutoPlugを組み込むこともできます。便利なクラスの一つにAutoPlugConsoleがあり、これを使うとAutoPlugコマンドをプログラムから実行できます。



```java
AutoPlugConsole.executeCommand(".check plugins");
AutoPlugConsole.executeCommand(".check server");
// etc...
```
## Contribute ![Build test](https://github.com/Osiris-Team/AutoPlug-Client/workflows/build/badge.svg)

ご協力いただきありがとうございます、コミュニティは💙それを歓迎します！以下の点にご注意ください：
- 大きな変更を行いたい場合は、まずIssueを作成して議論しましょう。
- 大きな変更はテストの作成も必要です。
- オープンなIssueは自由に選んで作業できます。作業中であることを知らせてください。
- メモリ使用量を最小限にするために、staticメソッド/フィールド/クラスの使用と作成は避けてください。

初心者向け：

- [プロジェクトへの貢献方法](https://www.jetbrains.com/help/idea/contribute-to-projects.html)
- [GitHubからのプロジェクトのクローン方法](https://blog.jetbrains.com/idea/2020/10/clone-a-project-from-github/)

報酬制度：

一部のオープンIssueにはこのようなタグ/ラベルが付けられています：`bounty: 15€`（[リストを見る](https://github.com/Osiris-Team/AutoPlug-Client/labels/bounty%3A%2015%E2%82%AC)）。これは、そのIssueを修正・解決するプルリクエストを最初に作成した人に報酬（15€）が支払われることを意味します。実装した修正や機能が動作することを示すテストが少なくとも1つ必要です。また、支払いはPayPalのみで行われるため、プルリクエストにコミットするGitHubの公開プロフィールにPayPalのメールアドレスがどこかに記載されていることを確認してください。報酬付きIssueにコミットすることでこれらの条件に同意したことになります。

詳細：

- [Java](https://java.com/)（[JDK 8](https://www.oracle.com/java/technologies/javase/javase-jdk8-downloads.html)）で記述され、[IntelliJ IDEA](https://www.jetbrains.com/idea/)内で開発。
- [1JPM](https://github.com/Osiris-Team/1JPM)でビルド。コマンド：`java ./src/main/java/JPM.java`
（直接実行したい場合は末尾に`andRun`を追加）。

## ライブラリ

このリストは古くなっている可能性があります。現在の依存関係は[build.gradle](/build.gradle)ファイルを確認してください。
- [AutoPlug-Core](https://github.com/Osiris-Team/AutoPlug-Core)は、すべてのAutoPlugプロジェクトで頻繁に使われるコードを1つのjarにまとめています。
- [Dream-Yaml](https://github.com/Osiris-Team/Dream-Yaml)はYAMLファイルの処理に使用されます。
- [Better-Thread](https://github.com/Osiris-Team/Better-Thread)は「ライブタスク」の表示を可能にします。
- コンソールのカラーリングとタスク表示には[Jansi](https://github.com/fusesource/jansi)と[Jline](https://github.com/jline/jline3)を使用。
- [Zip4j](https://github.com/srikanth-lingala/zip4j)はjar/zipの解凍と処理に使用。
- サーバーの再起動は[Quartz](http://www.quartz-scheduler.org/)でスケジューリングされます。








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---