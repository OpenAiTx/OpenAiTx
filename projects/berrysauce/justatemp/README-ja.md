<h1 align="center">📮 Just a Temp</h1>
<p align="center">Cloudflareが提供する無料の使い捨てメールサービス
  <br>
  </br>
  <img alt="CodeQL" src="https://github.com/berrysauce/justatemp/actions/workflows/github-code-scanning/codeql/badge.svg">
  <img alt="GitHub release (latest by date including pre-releases)" src="https://img.shields.io/github/v/release/berrysauce/junk.boats?color=blue&include_prereleases&label=latest%20release">
</p>

> ℹ️ このサービスは100% [Cloudflare](https://www.cloudflare.com/) によって運営されています

> [!IMPORTANT]
> このプロジェクトは以前「junk.boats」というドメインで提供されていました。

### justatemp.comとは？
justatemp.comは、また新たな、無料で使える、オープンソースで、もちろんプライバシーに配慮した使い捨てメール生成サービスです。justatemp.comを使うことで、本当にメールアドレスを教えたくないサイトからのメールを受け取ることができます。受信したメールはすべて2時間公開保存され、その後完全に削除されます。

<img alt="Just A Temp Screenshot" src="https://public-cdn.berrysauce.me/shared/justatemp-screenshot-yWtqO.png">

### プライバシーについては？
justatemp.comは受信したメールのみを保存します。他のユーザーデータは保存しません。メールは2時間後に自動的に削除されます。その間、この受信アドレスを知っている誰でも受信メールを閲覧可能です。解析にはCloudflareの匿名ウェブ解析を使用しています。

### collector、postmaster、postofficeとは？
- 📮 `mailbox` はすべての受信メールを受け取り保存するCloudflareのメールワーカーです
- 🚚 `postservice` はHonoJS Cloudflareワーカーで動作するAPI形式のメール配信サービスです
- 🏤 `frontend` は受信メールをユーザーに表示するSvelteKitのフロントエンドです

### justatemp.comはどのように動作するのか？
受信メールは`mailbox`メールワーカーに届きます。メールはCloudflareのKVデータベースに保存されます。Svelteフロントエンドはランダムなメールアドレスを生成し、そのアドレスのすべてのメールを`postservice`にリクエストします。メールがあれば、KVエントリに含まれるUNIXタイムスタンプ順に並べて表示します。

### 開発について
詳細は近日公開予定です


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---