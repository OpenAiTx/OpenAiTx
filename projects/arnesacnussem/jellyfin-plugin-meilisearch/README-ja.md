# Jellyfin用Meilisearchプラグイン

Meilisearchを検索エンジンとして利用し、検索速度と結果を改善しようとするJellyfin用プラグイン。

このプラグインは検索ロジックをMeilisearchにオフロードし、Jellyfinからのレスポンスを修正します。

クライアントが検索に`/Items`エンドポイントを使用している限り、シームレスにサポートされるはずです。

[JellySearch](https://gitlab.com/DomiStyle/jellysearch)に触発されました。

---

### 使用方法

1. Meilisearchインスタンスをセットアップします（クラウド上のホスティングも動作するかもしれませんが、お勧めしません）。
2. 以下のリポジトリを追加し、Meilisearchプラグインをインストールします。
    ```
    https://raw.githubusercontent.com/arnesacnussem/jellyfin-plugin-meilisearch/refs/heads/master/manifest.json
    ```
3. プラグイン設定にMeilisearchインスタンスのURLを入力してください。Meilisearchの設定によってはAPIキーも必要になる場合があります。  
4. 複数のJellyfinインスタンスで1つのMeilisearchインスタンスを共有したい場合は、`Meilisearch Index Name`を入力してください。空欄の場合はサーバー名が使用されます。  
5. `Save`をクリックし、ステータスが`ok`と表示されていることを確認してください。  
6. 検索ページで何か入力してみてください。  

    ---  

インデックスは以下のイベントで更新されます：  
- サーバー起動時  
- 設定変更時  
- ライブラリスキャン完了時  
- インデックス更新タスクがトリガーされた時  

---  

### 動作の仕組み  

検索リクエストを変更するコア機能は、[`ActionFilter`](https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-8.0#action-filters) を注入することで実現しています。  
そのため、サポートされるJellyfinのバージョンは限られる可能性があります。現在は`Jellyfin 10.10.0`を使用していますが、`/Items`エンドポイントの必要なパラメーター名が変わらなければ他のバージョンでも動作するはずです。  

---  
###  

JellySearchという素晴らしいプロジェクトもありますが、リバースプロキシの設定やその他の面倒な作業は好みではありませんでした。  

そこでこのプラグインを書きましたが、それでもMeilisearchインスタンスは必要です。  

現時点では`/Items`エンドポイントのみがこのプラグインの影響を受けますが、20万アイテムのライブラリで大幅に改善されました。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---