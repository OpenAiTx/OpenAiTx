# shimmer - sidebery対応の魅力的なFirefoxユーザークローム (v2.37)
![STAR BUTTON](https://github.com/user-attachments/assets/227bfd9e-ce3a-4d76-b8b7-24ad55dc128a)[![ISSUE](https://github.com/user-attachments/assets/648d41c3-4812-47fd-9696-38d76a2a0a5a)](https://github.com/nuclearcodecat/shimmer/issues)[![MONEY BUTTON](https://github.com/user-attachments/assets/18d7f816-f784-46b2-97b1-89173f68e227)](https://ko-fi.com/nuclearcodecat)

変更履歴は[changelog](https://raw.githubusercontent.com/nuclearcodecat/shimmer/main/CHANGELOG.md)をご覧ください

### こんにちは、このプロジェクトはほぼ完成と考えています。新機能の追加は予定していません。今はこの作業をする気がなく、現在取り組んでいる大きなプロジェクトがあるためです。shimmerは素晴らしく見えるので、このままにします。リクエストは自由にどうぞ、ただし追加するとは約束できません。たくさんの温かい言葉とスターをありがとうございます :333

## デモンストレーション
<!--
![sidebarcollapse](https://github.com/user-attachments/assets/be8cb062-19f6-40b5-b26d-6a4fe8ceff7b)
-->
![out](https://github.com/user-attachments/assets/41ca27e6-701b-4049-8e38-76bcb300cd85)


| sideberyを使用                                                                                  | ネイティブタブ                                                                                                |
|-------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------|
| ![y](https://github.com/user-attachments/assets/6c8ce4d2-a9a8-478c-b427-77417f6a27a5) | ![x](https://github.com/user-attachments/assets/7b523c33-bec6-482a-9f01-3e478e75902e) |
<!-- | ![lightsidebery](https://github.com/user-attachments/assets/dd26f273-438e-42be-b77a-5d0df96b70bf) | ![greennative](https://github.com/user-attachments/assets/a60e6432-c919-4766-8353-609f1296315d)              | -->



| メニュー                                                                                     | ポップオーバーURLバー                                                                       |
|---------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------|
| ![ctxmenu](https://github.com/user-attachments/assets/7da9bdff-d247-4680-ad20-70d12c886272) | ![urlbar](https://github.com/user-attachments/assets/8b328ecf-0297-4e8c-8cb6-8826040c7916) |

### 折りたたみ可能なサイドバー
デモでご覧の通り

### コンパクトな検索バー
![findbar](https://github.com/user-attachments/assets/198c5ec8-6e59-46fb-8624-0baa90506c86)

### 生活の質の向上
![longtab](https://github.com/user-attachments/assets/6ab029f9-1b67-4545-a898-bd680bd40000)

### コンパクトでMacOS風のウィンドウコントロールボタン
![winctr](https://github.com/user-attachments/assets/934849bd-19ba-4617-8bfe-f5b41508a872)

## 特徴
 - 折りたたみ可能なサイドバー
 - ポップオーバーURLバー（デモのアニメーション画像参照）
 - カスタムテーマに対応
 - ブラウザ/サイドバーの角を丸く
 - コンテキストメニューを最小化
 - 控えめで邪魔にならないトランジション
 - 検索バーを最小化
 - サイドバーを右側に移動する設定あり
 - カスタマイズ用の設定プロパティ
 - Firefox Nightlyに対応
 - ネイティブ縦型タブに半対応
 - 浮動ステータスパネル

## インストール
 - GitHubからコードをクローンまたはダウンロード（緑色の「code」ボタン）し解凍
 - 必要ならMozillaアドオンからSideberyをダウンロード
 - Sideberyの設定を開き、一番下のヘルプセクションまでスクロール
 - 「アドオンデータをインポート」をクリック
 - ダウンロードしたアーカイブ内の「sidebery.json」を選択
 - トグルはデフォルトのまま「インポート」をクリック
 - about:configを開く
 - `toolkit.legacyUserProfileCustomizations.stylesheets` をtrueに切り替え
 - `svg.context-properties.content.enabled` をtrueに切り替え
 - `sidebar.revamp` をfalseに切り替え
 - about:profilesを開き、自分のプロファイルを見つけてルートフォルダを開く
 - `chrome`フォルダがなければ作成
 - `userChrome.css`、`userContent.css`ファイルと`assets`フォルダを`chrome`フォルダに移動
 - Firefoxを再起動
 - 完了！ :3
 - 最新バージョンをダウンロードするために時々このGitHubページを必ず訪れてください。このREADMEの「更新」セクションを参照
 - カスタマイズオプションはこのREADMEの「カスタマイズ」セクションを参照

## 更新
 時々このGitHubページをチェックし、新しいバージョンがあるか確認してください。インストール中のバージョンは新しいタブの設定メニューの閉じるボタン横（新しいタブの右下）に表示されます。
### 更新方法：
 インストール手順に従い、ファイルエクスプローラーでファイルの置き換えを求められたら許可してください（Sideberyのスタイルも更新するのを忘れずに）

## カスタマイズ
 `userChrome.css`の先頭にカスタマイズ可能なCSS変数があります。タブのサイズオプション、角の丸み、特定の項目間の間隔などが含まれます。これらの変数の下には右クリックコンテキストメニューの除外設定もあります。使いたいオプションのコメントアウトを外し、使いたくないものはコメントアウトしてください。
 
 また、いくつかのカスタム`about:config`のブール値も実装しています。変更可能です。
 - `shimmer.disable-collapsing-sidebar` – trueに切り替えるとサイドバーの折りたたみを無効化（残念ながらSideberyの設定内スタイルエディタでマークされたスタイルの一部もコメントアウトする必要があります）
 - `shimmer.remove-winctr-buttons` – ウィンドウコントロールボタンを削除するには true に切り替え
 - `shimmer.remove-firefox-view-button` – Firefox ビューボタンを削除するには true に切り替え
 - `shimmer.disable-popover-transition` – URLバーのポップオーバー遷移を削除するには true に切り替え
 - `shimmer.disable-urlbar-background-transition` – ポップオーバーアニメーション中に発生するURLバー背景の微妙な遷移を削除するには true に切り替え
 - `shimmer.disable-popover-urlbar` – URLバーのポップオーバー効果を削除するには true に切り替え
 - `shimmer.native-vertical-tabs` – SideberyではなくFirefoxの縦型タブを使用する場合は true に切り替え。*水平*タブを使用している場合は true にしないでください。タブが消えます
 - `shimmer.show-sidebar-header` – サイドバーのヘッダーを表示するには true に切り替え
 - `shimmer.show-sidebar-header-close-button` - ヘッダーを有効にしても閉じるボタンは自動的に非表示になります。これを再表示するには true に切り替え
 - `shimmer.sidebar-right-side` – Sideberyを右側で使用する場合は true に切り替え。まずFirefoxのサイドバーヘッダーでサイドバーを移動し、設定で再有効化する必要があります
 - `shimmer.reverse-winctr-buttons-side` – ウィンドウコントロールボタンを左側に移動するには true に切り替え
 - `shimmer.taller-tabs` – タブをデフォルトのFirefoxタブと同じ高さにするには true に切り替え
 - `shimmer.shorter-navbar` – ナビゲーションバーを未変更のFirefoxと同じ高さにするには true に切り替え（Firefoxの再起動が必要な場合があります）
 - `shimmer.disable-compact-winctr-buttons` – コンパクトなウィンドウコントロールボタンをデフォルトに戻すには true に切り替え
 - `shimmer.dont-expand-selected-tab` – 多数のタブが開いているときにアクティブなタブが拡大する効果を無効にするには true に切り替え
 - `shimmer.enable-theme-aware-wallpapers` – Firefoxにユーザー選択の壁紙を表示させるには true に切り替え。壁紙を変更するにはchromeディレクトリを開き、*walls*ディレクトリの*light*と*dark*ファイルを希望の画像に置き換え、`makewalls.sh`を実行してください。これはbashスクリプトです。壁紙が機能しない場合はサイズを小さくしてください。大きなファイルは壊れやすいです。安全な上限は1MiB未満です。

## メンテナンス
 新しいFirefoxのバージョンで発生した問題をすぐに修正できない場合があります。プルリクエストを作成したい場合は自由にどうぞ。問題を見つけた場合はGitHubの「issues」タブで報告してください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---