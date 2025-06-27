# ASP.NET SignalR

**重要**: この製品には新機能が追加されることはありません。現在はメンテナンスモードであり、重大な問題のみ修正しています。詳細は[弊社ブログ記事](https://devblogs.microsoft.com/aspnet/the-future-of-asp-net-signalr/)をご覧ください。  
このリポジトリは、System.Web または Katana を使用した .NET Framework アプリケーション向けの ASP.NET SignalR のコードとプロジェクト管理をホストしています。ASP.NET Core SignalR に関する情報をお探しの場合は、https://github.com/aspnet/AspNetCore/tree/main/src/SignalR リポジトリをご覧ください。

ASP.NET SignalR は、ASP.NET 開発者向けのライブラリで、リアルタイム Web 機能をアプリケーションに非常に簡単に追加できます。「リアルタイム Web」機能とは何でしょうか？それは、サーバーサイドのコードが、発生した内容をリアルタイムで接続されているクライアントにプッシュできる能力です。

## 何に使えるのか？
サーバーからクライアント（ブラウザクライアントだけでなく）へのデータプッシュは、常に難しい問題でした。SignalR はそれを非常に簡単にし、すべての煩雑な作業を代わりに行ってくれます。

## ドキュメント
[ドキュメント](https://docs.microsoft.com/aspnet/signalr/overview/getting-started/introduction-to-signalr)をご覧ください。

## NuGet で入手！

    Install-Package Microsoft.AspNet.SignalR

## NuGet でサンプルをアプリに直接インストール！

    Install-Package Microsoft.AspNet.SignalR.Sample

## ライセンス
[Apache 2.0 License](https://raw.githubusercontent.com/SignalR/SignalR/main/LICENSE.txt)

## コントリビューション

[コントリビューションガイドライン](https://raw.githubusercontent.com/SignalR/SignalR/main/CONTRIBUTING.md)をご覧ください。

## ソースのビルド

```
git clone git@github.com:SignalR/SignalR.git (または https をご利用の場合は https)
```

### Windows
リポジトリをクローンした後、`build.cmd` を実行してください。

**注意:** ソリューションのオープンには VS 2017 が必要です。

## 質問がありますか？
* [signalr](https://stackoverflow.com/questions/tagged/signalr) タグを付けて StackOverflow で質問する
* [Issue Tracker](https://github.com/SignalR/SignalR/issues) にイシューを投稿する

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---