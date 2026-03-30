![image](https://user-images.githubusercontent.com/693717/210183526-1708c821-172e-4c71-9b02-2a9885654505.svg)

# QuickLook.Plugin.WebViewPlus

[QuickLook](https://github.com/QL-Win/QuickLook) 用のプラグインで、[WebViewPlus](https://github.com/mooflu/WebViewPlus) を使って様々なファイルタイプをプレビューします。

## お試し

1. [リリースページ](https://github.com/mooflu/QuickLook.Plugin.WebViewPlus/releases)にアクセスし、最新バージョンをダウンロードしてください。
2. QuickLookがバックグラウンドで起動していることを確認してください。ダウンロードフォルダに移動し、ダウンロードした `.qlplugin` ファイル上で <key>Spacebar</key> を押します。
3. ポップアップウィンドウの「インストール」ボタンをクリックします。
4. QuickLookを再起動します。
5. WebViewPlusでプレビューするファイルタイプを設定するには、htmlファイルを開き、右下の歯車ボタンをクリックしてください。

## 開発

 1. このプロジェクトをクローンします。サブモジュールの更新を忘れないでください。
 2. WebViewPlusのWebアプリを `webApp` にコピーするか、プラグイン設定の `WebAppUrl` を設定してください - `WebpagePanel.cs` を参照。
 3. `Debug` 設定の `Output path` を `..\QuickLook.upstream\Build\Debug\QuickLook.Plugin\QuickLook.Plugin.WebViewPlus\` のように設定します。
 4. `Debug` プロファイルでプラグインプロジェクトをビルドします。
 5. `Debug` プロファイルで上流の QuickLook をビルドして実行します。

 # リリース
 1. `Release` プロファイルでプロジェクトをビルドします。
 2. `Scripts\pack-zip.ps1` を実行します。
 3. プロジェクトディレクトリに `QuickLook.Plugin.WebViewPlus.qlplugin` というファイルが生成されているはずです。

## ライセンス

MITライセンス。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---