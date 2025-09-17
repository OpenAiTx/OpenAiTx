# Obsidian プロジェクトブラウザ  
[Obsidian](https://obsidian.md) 用のプラグインで、新しいタブウィンドウを各フォルダ内のファイルを状態別に整理したカードレイアウトに置き換えます。ビューは組み込みの検索フィールドでフィルタリング可能（文字を入力し始めるだけ！）、ファイルにはノート内の目立つメニューから状態を割り当てることができます。  

<img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/readme_hero-shot.png" alt="Project Browserプラグインのスクリーンショット">  

## 📓 開発日誌  
定期的に開発日誌を記録しています。[購読してフォロー](https://www.youtube.com/@designdebtclub) すれば開発中の機能を見ることができます。  

<p align="center">  
    <a href="https://youtube.com/playlist?list=PLAiv7XV4xFx3_JUHGUp_vrqturMTsoBUZ&si=7-XnA3NEq6OBNzhW" target="_blank">  
        <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/devdiary-screenshot.jpg" width="60%" alt="開発日誌動画のスクリーンショット"><br/>  
        開発日誌を見るにはクリック  
    </a>  
</p>  

<p align="center">  
  <a href="https://twitter.com/daledesilva" target="_blank_">  
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/twitter-btn.svg" height="40px" alt="TwitterのDale de Silva">  
  </a>  
  <a href="https://indieweb.social/@daledesilva" target="_blank">  
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/mastodon-btn.svg" height="40px" alt="MastodonのDale de Silva">  
  </a>  
  <a href="https://www.threads.net/@daledesilva" target="_blank">  
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/threads-btn.svg" height="40px" alt="ThreadsのDale de Silva">  
  </a>  
  <a href="https://bsky.app/profile/daledesilva.bsky.social" target="_blank">  
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/bluesky-btn.svg" height="40px" alt="BlueskyのDale de Silva">  
  </a>  
</p>  

## 🗺️ 大まかなロードマップ  
このプラグインは2023年3月から開発を続けており、今も定期的に機能追加を行い、自分でも毎日使っています。<br/>  
以下は現在の開発計画にある高レベルの機能と、それらが実装される見込みの時期です。  

<details>  
<summary>過去の実装</summary>  

- ✅ ファイルをカードとして表示。  
- ✅ フォルダのナビゲーション。  
- ✅ 状態による整理。
- ✅ 簡単なノート状態メニュー。
- ✅ メモリ付きの戻る/進むナビゲーション。
- ✅ ライト/ダークモードに対応。
- ✅ 状態のカスタマイズを可能に。
- ✅ 右クリックアクション。
- ✅ 個別フォルダーの非表示。
- ✅ 起動フォルダーのカスタマイズ。
</details>

<details open>
<summary>現在の機能フォーカス</summary>

- [ ] フォルダーをプロジェクトとして扱う。
- [ ] マルチページプロジェクトのサポート。
- [ ] ノートの並べ替え。
- [ ] ノートの優先順位付け。
</details>

## ⚠️ 注意してください
> 多くのObsidianプラグインと同様に、これはコミュニティへの無料の贈り物で、「現状のまま」提供されています。最高のものにしようと最善を尽くしています（フィードバックも大歓迎です）が、動作が完全でない可能性も常にあります。安全のために、**必ずファイルのバックアップを取ってください**。

## 🪳 バグ報告
何か正常に動作していないことを見つけた、または機能リクエストがありますか？遠慮せずに[GitHub Issues](https://github.com/daledesilva/obsidian_project-browser/issues)ページで声を上げてください。ただし、同じ問題が既に投稿されているか確認し、あればそのコメントに参加してください。

## 💾 インストール
このプラグインはObsidian内のプラグインディレクトリで見つけることができます。
<details>
<summary>プラグインのインストール方法はこちら</summary>

1. Obsidianのボールトを開き、**設定**に移動します。

2. サイドバーの**コミュニティプラグイン**をクリックします。

3. まだであれば、コミュニティプラグインを有効にする必要があります。

4. 「Dale de Silva」を検索し、**Project Browser**をインストールします。
</details>

もしまだテスト中の新しいバージョンをインストールしたい場合は、代わりにBRATを使ってインストールすることもできます。  
BRATはベータ版をインストールできる別のコミュニティプラグインです。新機能はまずベータ版としてリリースされ、標準版に反映されるまで数日から1か月かかることがあります。
<details>
<summary>ベータ版インストール手順を表示</summary>

1. Obsidianのボールトを開き、**設定**に移動します。
2. サイドバーの**コミュニティプラグイン**をクリックします。
3. コミュニティプラグインを有効にし、**参照**をクリックします。
4. **BRAT**を検索してインストールします。
5. 下にスクロールしてBRATを**有効化**します。
6. サイドペインのBRATメニューで**Add Beta Plugin**を選択します。
7. 表示される指示に従ってください。
8. URLが要求されたら、次を使用してください：`https://github.com/daledesilva/obsidian_project-browser/`

</details>
<details>
<summary>ベータ版アップデート手順を表示</summary>

- BRATは起動時にデフォルトでベータプラグインを更新するよう設定されていますが、これには時間がかかることがあります。
- 強制的に更新するには、BRATのObsidianコマンド「Choose a single plugin to update」を実行し、Project Browserを選択してください。
</details>

## ❤️ サポート
このプラグインがあなたの時間を節約したり、何らかの形で役立つと感じた場合は、私のプラグイン開発やこのような無料のコミュニティ資料の支援をご検討ください。

<p>
  <a href="https://twitter.com/daledesilva" target="_blank_">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/twitter-btn.svg" height="40px" alt="Dale de Silva のTwitter">
  </a>
  <a href="https://indieweb.social/@daledesilva" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/mastodon-btn.svg" height="40px" alt="Dale de Silva のMastodon">
  </a>
  <a href="https://www.threads.net/@daledesilva" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/threads-btn.svg" height="40px" alt="Dale de Silva のThreads">
  </a>
  <a href="https://bsky.app/profile/daledesilva.bsky.social" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/bluesky-btn.svg" height="40px" alt="Dale de Silva のBluesky">
  </a>
  <a href="https://ko-fi.com/N4N3JLUCW" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/support-btn.svg" height="40px" alt="Ko-fiで支援する">
  </a>
</p>

## 🤖 My other work
You can find links to my other projects on [designdebt.club](https://designdebt.club), where I blog about design and development, as well as release other plugins like this one. You can also find my writing at at [falterinresolute.com](https://falterinresolute.com) where I combine philosophy and animation.

<p>
  <a href="https://designdebt.club" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/design-debt-club-btn.svg" height="50px" alt="Design Debt Club">
  </a>
  <a href="https://falterinresolute.com" target="_blank">
    <img src="https://raw.githubusercontent.com/daledesilva/obsidian_project-browser/main/docs/media/falter-in-resolute-btn.svg" height="50px" alt="Falter In Resolute Blog">
  </a>
</p>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-17

---