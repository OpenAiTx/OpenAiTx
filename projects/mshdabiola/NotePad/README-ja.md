[![Contributors](https://img.shields.io/github/contributors/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/graphs/contributors)
[![Forks](https://img.shields.io/github/forks/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/metworks/members)
[![Stargazers](https://img.shields.io/github/stars/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/stargazers)
[![Issues](https://img.shields.io/github/issues/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/Wladefant/mshdabiola/Play_NotePad/issues)
[![License](https://img.shields.io/github/license/mshdabiola/Play_NotePad.svg?style=for-the-badge)](https://github.com/mshdabiola/Play_NotePad/master/LICENSE)

# NotePad

[<img src="/images/ic_launcher-playstore.png" align="left"
width="200" hspace="10" vspace="10">](/images/ic_launcher-playstore.png)

Notepadは、簡単に思考、アイデア、タスクをキャプチャして整理できる多用途のメモアプリです。さまざまな機能を備えたPlay Notepadは、メモを管理しやすく、整理整頓を助けます。

Play NotePadはGoogle Playストアで利用可能です：

<p align="left">
<a href="https://play.google.com/store/apps/details?id=com.mshdabiola.playnotepad">
    <img alt="Get it on Google Play"
        height="70"
        src="https://play.google.com/intl/en_us/badges/images/generic/en_badge_web_generic.png" />
</a>

<a href="https://f-droid.org/packages/com.mshdabiola.playnotepad.foss/">
    <img alt="Get it on F-Droid"
        height="70"
        src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png" />
</a>

<a href="https://github.com/mshdabiola/NotePad/releases">
    <img alt="Get it on GitHub"
        height="70"
        src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/github_image.png" />
</a>  



<a href="https://github.com/mshdabiola/Play_NotePad">デモを見る</a>
·


<a href="https://github.com/mshdabiola/Play_NotePad/issues">バグを報告する</a>
·
<a href="https://github.com/mshdabiola/Play_NotePad/issues">機能をリクエストする</a>
  </p>

## プロジェクトについて

[<img src="/images/screenshot1.png" align="left"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot1.png)
[<img src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot2.png" align="center"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot2.png)
[<img src="https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot3.png" align="center"
width="200"
hspace="10" vspace="10">](https://raw.githubusercontent.com/mshdabiola/NotePad/develop/images/screenshot3.png)

主な特徴:

- レイジーモード: 投稿の自動スクロールにより、親指を動かさずに素晴らしい投稿を楽しめます
- テキストノートを簡単に作成および編集できます。
- 写真を撮影するか、カメラロールから選んでノートに添付できます。
- 手書きのスケッチや図を描いてノートに注釈を付けられます。
- 音声ノートを録音し、後で再生できます。
- 重要なノートをリストの上部に固定して簡単にアクセスできます。
- チェックリストを作成し、チェックボックスでタスクを管理できます。
- ラベルでノートをタグ付けして整理できます。
- ノートを複製して簡単に参照できます。
- ノートをメールやメッセージで他の人と共有できます。
- ノートのリマインダーを設定して重要なタスクやイベントを忘れません。
- もう必要ないノートを削除できます。
- 古いまたは完了したタスクをアーカイブしてノートを整理できます。
- ノートに色を付けて視覚的に魅力的にできます。
- ノートの背景に画像を追加してよりパーソナルな外観にできます。
- ノートをリストまたはカラム形式で表示し、読みやすく編集しやすくします。
- キーワード、ラベル、タイプでノートを検索できます。
- オフラインでアプリを使用し、いつでもノートにアクセスできます。

## 使用技術

## 3つの主要モジュールによるクリーンアーキテクチャ

[//]: # (<img src="/images/AndroidTemplate-CleanArchitecture.jpeg" alt="ArchiTecture logo"/>)

- 宣言型UI（[Jetpack Compose](https://developer.android.com/jetpack/compose)使用）
    - Compose Navigation（
      [Hiltサポート](https://developer.android.com/jetpack/compose/libraries#hilt-navigation)
      とアシストインジェクトの例付き）
- データ（データベース、API、プリファレンスのコード用）
- ドメイン（ビジネスロジックとモデル用）
- AndroidApp（UIロジック用、MVVMパターン採用）
- このバージョンは[モジュラー化](https://developer.android.com/topic/modularization)を導入
- バージョン管理（
  [バージョンカタログ](https://docs.gradle.org/current/userguide/platforms.html)使用）
- 共有ビルドロジック（
  [コンベンションプラグイン](https://docs.gradle.org/current/samples/sample_convention_plugins.html)使用）
- 依存性注入（[Hilt](http://google.github.io/hilt/)使用）
- リアクティブプログラミング（
  [Kotlin Flows](https://kotlinlang.org/docs/reference/coroutines/flow.html)使用）
- Androidアーキテクチャコンポーネントにより、設定変更時にViewModelを共有
- [スプラッシュスクリーン](https://developer.android.com/develop/ui/views/launch/splash-screen)対応
- Google Material 3の[マテリアルデザイン](https://material.io/blog/android-material-theme-color)ライブラリ

- エッジ・トゥ・エッジ設定

[//]: # (## テスト)

[//]: # (- [Mockk]&#40;https://mockk.io/&#41; ライブラリ)

[//]: # (- ユニットテスト)

[//]: # (- アプリケーションテスト)

[//]: # (    - テストの使い方の例)

[//]: # (- アクティビティテスト（[Compose Testing]&#40;https://developer.android.com/jetpack/compose/testing&#41;使用）)

[//]: # (    - テスト内でのコルーチンスコープの使い方の例)


## 貢献

1. 貢献こそがオープンソースコミュニティを学び、刺激を受け、創造する素晴らしい場所にしています。あなたの貢献は**大変感謝されます**。

2. バグ修正、ドキュメントの改善、情報の拡散など、どのような形でもGatsbyコミュニティの一員として参加していただけると嬉しいです！

3. 貢献に興味を持っていただきありがとうございます！このプロジェクトには様々な貢献方法があります。ここから始めてください（Contributing.mdへのリンク）

### フィードバック

プロジェクトにスターを付けるのも忘れずに！改めてありがとうございます！

アプリについての議論や一般的な質問には[Github Discussions](https://github.com/mshdabiola/Play_NotePad/discussions)をご利用ください。ここでは機能リクエストの提出も可能です（機能リクエストの提出方法を先にお読みください！）。また開発者の方はこのプロジェクトをフォークし、プルリクエストを作成してください。

1. プロジェクトをフォークする
2. 新しい機能ブランチを作成する（`git checkout -b feature/AmazingFeature`）
3. 変更をコミットする（`git commit -m 'Add some AmazingFeature'`）
4. ブランチにプッシュする（`git push origin feature/AmazingFeature`）
5. プルリクエストを作成する

他にも支援できる方法は以下の通りです：

* [バグを報告する](https://github.com/mshdabiola/Play_NotePad/issues)

* [アプリを翻訳する](https://poeditor.com/join/project/rdWI3SpnSW)

## 開発

## ライセンス

Play NotepadはGNU一般公衆利用許諾契約書（GPL-3.0）でライセンスされています。ライセンス文は`LICENSE`ファイルにあります。

## 連絡先








mshdabiola - [@Mshdabiola](https://twitter.com/mshdabiola) - mshdabiola@gmail.com

## 謝辞


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---