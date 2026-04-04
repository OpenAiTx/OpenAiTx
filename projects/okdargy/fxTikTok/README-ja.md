# fxTikTok

Discord上でTikTokの動画やスライドショーを `s/i/n` だけで埋め込み表示

> [!NOTE]  
> fxTikTokに欲しい機能やバグの報告がありますか？Issueを作成してください！皆さんのフィードバックをお待ちしています。

## 📸 スクリーンショット

<details>
  <summary>fxTikTokの動作イメージをプレビューするにはここをクリック</summary>

| <img src="/.github/readme/compare.png" alt="Video Preview" height="400px" /> |
| :--------------------------------------------------------------------------: |
|          Discord上での `tiktok.com` と `tnktok.com` 埋め込みの比較           |

| <img src="/.github/readme/slideshow.png" alt="Slideshow Preview" /> |
| :-----------------------------------------------------------------: |
|                          スライドショーの埋め込み表示                          |

| <img src="/.github/readme/direct.png" alt="Direct Preview" height="400px" /> |
| :--------------------------------------------------------------------------: |
|                          直接画像/動画のサポート                           |

</details>

## 📖 使い方

DiscordでのfxTikTokの使用は簡単です。醜くて反応しない埋め込みを直すには、TikTokリンクを送信してから `s/i/n` と入力してください。

<details>
  <summary>👁️ 視覚的に学びたい？GIFチュートリアルを見るにはここをクリック</summary>

  <img src="https://raw.githubusercontent.com/okdargy/fxTikTok/hono-rewrite/.github/readme/introduction.gif" alt="Introduction GIF" height="500px" style="border-radius:2%" />
</details>

### これはどう動くの？

Discordで `s/i/n` を送信すると、[sed](https://www.gnu.org/software/sed/manual/sed.html)形式を使って直近のメッセージを修正します。具体的には、メッセージ内で2番目のパラメータ（`i`）の最初の出現を3番目のパラメータ（`n`）に置き換えます。

|     変更前     |     変更後      |
| :------------: | :------------: |
| t**i**ktok.com | t**n**ktok.com |

> [!TIP]
> Discordサーバーを運営している場合は、[FixTweetBot](https://github.com/Kyrela/FixTweetBot)をサーバーに追加することを強くお勧めします。これはリンクを自動的にfxTikTokのような埋め込み修正ツールに変更し、高度にカスタマイズ可能です。

### 直接埋め込みを使う

統計情報のゴチャゴチャが埋め込みに表示されるのを避けて、動画や画像だけを表示したいですか？単にURLを `d.tnktok.com` に変更してください。

|         変更前         |        変更後         |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **d**.t**n**ktok.com |

> または、URLのクエリパラメータで `?isDirect=true` を追加して `isDirect` をtrueに設定することもできます。

### 「動画のキャプションが見えません！」

デフォルトでは、説明文を `og:description` タグに入れていますが、Discordは埋め込み内に動画がある場合、そのタグを埋め込みから削除します。[tfxktok.com](https://tfxktok.com)がやっているように、ハッシュタグで埋め込みが煩雑になるのを防ぐために上部に追加しないことにしました。

しかし、動画に追加の文脈を与える場合があるため、ユーザーが説明文を追加するオプションを提供したいと思います。URLを `a.tnktok.com` に変更すると説明文を上部に追加できます。

|         変更前         |        変更後         |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **a**.t**n**ktok.com |

> または、URLのクエリパラメータで `?addDesc=true` を追加して `addDesc` をtrueに設定することもできます。

### 高画質に変更する

TikTokはH.265/HEVC（高効率ビデオコーディング）をサポートしており、同じファイルサイズでH.264よりもはるかに高い画質を提供しますが、互換性の問題があります。多くのユーザーからH.265で埋め込みが壊れる問題が報告されているため、デフォルトではH.264画質を使用していますが、H.265を有効にすることも可能です。

高画質のH.265再生を有効にするには、`?hq=true` を追加するか、`hq.tnktok.com` を使用してください：
| 変更前 | 変更後 |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **hq**.t**n**ktok.com |

### モードの組み合わせ

異なるモードを特定のホスト名やURLクエリパラメータを使って組み合わせることができます。例えば、H.265を有効にしてキャプションも表示したい場合は、`hq.a.tnktok.com` を使うか、URLに `?hq=true&addDesc=true` を追加してください。

> 直接モードとキャプションモードは相反するため、同時に使用することはできません。

### なぜ tnktok.com を使うのか？

私たちは多くの機能を備えた最高のTikTok埋め込みサービスの一つとして、全ての項目を満たしています。他のTikTok埋め込みサービスやTikTokのデフォルト埋め込みと比較した表を以下に示します。

|                                        | [fxTikTok](https://www.tnktok.com) | デフォルトTikTok | [kkScript](https://kktiktok.com/) | [tfxktok.com](https://tfxktok.com) | [EmbedEZ](https://tiktokez.com) |
| -------------------------------------- | ---------------------------------- | -------------- | --------------------------------- | ---------------------------------- | ------------------------------- |
| 再生可能な動画を埋め込む               | ☑️                                 | ☑️             | ☑️                                | ☑️                                 | ☑️                              |
| 複数画像のスライドショーを埋め込む     | ☑️                                 | ❌             | ❌                                | ☑️                                 | ☑️                              |
| オープンソース                        | ☑️                                 | ❌             | ❔                                | ❌                                 | ❌                              |
| 直接埋め込みをサポート                | ☑️                                 | ❌             | ❔                                | ❌                                 | ❌                              |
| いいね、シェア、コメントを表示        | ☑️                                 | ☑️             | ❌                                | ☑️                                 | ☑️                              |
| リダイレクトのトラッキングを除去      | ☑️                                 | ❌             | ❌                                | ☑️                                 | ☑️                              |
| 複数大陸対応のショートURLをサポート   | ☑️                                 | ☑️             | ❌                                | ❌                                 | ☑️                              |
| h265/高画質対応                     | ☑️                                 | ❌             | ❌                                | ❌                                 | ❌                              |
| 最終コミット                         | [![][tnk]][tnkc]                   | N/A            | [![][kkt]][kktc]                  | N/A                                | N/A                             |

[tnk]: https://img.shields.io/github/last-commit/okdargy/fxTikTok?label  
[tnkc]: https://github.com/okdargy/fxTikTok/commits  
[kkt]: https://img.shields.io/github/last-commit/kkscript/kk?label  
[kktc]: https://github.com/kkscript/kk/commits  

以下の埋め込みサービスはメンテナンスされていないか、正常に動作しないためリストに含まれていません：

- [tiktxk.com](https://tiktxk.com)  
- [vxtiktok.com](https://vxtiktok.com)（kkScriptへリダイレクト）

## 💻 セルフホスティング

新しいfxTikTokインスタンスをセットアップする際、デフォルトのオフロードサーバーは `offload.tnktok.com` です。  
独自にセットアップするには、[`offload.ts`](/src/offload.ts) をコンパイルして実行するだけで、ポート **8787** で起動します。

```bash
# Install all necessary dependencies
pnpm install
# Start your server
bun run src/offload.ts
```

> これを独自ドメインに設定し、[nginx](https://nginx.org) のようなリバースプロキシとCloudflareの保護の上に構築することをお勧めします。

次に、下のボタンでWorkerをデプロイし、指示に従ってください。

[![Cloudflare Workersにデプロイ](https://deploy.workers.cloudflare.com/button)](https://deploy.workers.cloudflare.com/?url=https://github.com/okdargy/fxtiktok)

完了したら、「Settings」に移動し、「Variables and Secrets」の下でオフロードサーバーを変更してください：

<img src="https://raw.githubusercontent.com/okdargy/fxTikTok/hono-rewrite/.github/readme/settings.png" alt="設定ページ、オフロードサーバーを変更する場所を示す" height="300px" style="border-radius:2%" />

#### 🎉 以上です！これで、いつでもどこでも使えるあなた専用のfxTikTokインスタンスが手に入りました。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---