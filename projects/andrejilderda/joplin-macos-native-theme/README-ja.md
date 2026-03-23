# Joplin用macOSテーマ

メモアプリ[Joplin](https://joplinapp.org/) v2.2.4以降向けのネイティブ風macOSテーマ。macOS以外のデバイスでも動作します。

![Joplin用macOSテーマ](/images/macos-theme-for-joplin.png)

- ✨ 全てのコントロールを含む完全なUIスタイル、
- 🌜 ライト、ダーク、ダークサイドバー付きライト、または自動（システム設定に基づくライト/ダーク）を選択可能、
- 👌 ネイティブアイコン（macOSのみ）またはPhosphorアイコンファミリーを使用可能、
- 👨‍🎨 Joplinの設定から簡単にカスタマイズ可能。

## インストール

- Joplinの設定 › 「プラグイン」を開き、「macOS theme」を検索してテーマをインストール。
- Joplinを再起動。お楽しみください！

「外観 › テーマ」を「ライト」または「ダーク」に設定してください。ノートブック切り替え時にフラッシュが発生する場合は、「外観 › テーマ」のライト/ダーク設定と「macOS theme › 外観」で選択した値を同期させてください。さらにカスタマイズしたい場合は以下を参照。

## カスタマイズ

インストール後、Joplinの設定に「macOS theme」という項目が追加されます。変更を反映するにはJoplinを再起動してください。

**Macユーザー**：ネイティブアイコンを使用したい場合は、[Apple公式サイト](https://developer.apple.com/fonts/)からSF Proをダウンロードしてインストールしてください。

## アイコンが表示されない？

**Windowsユーザー**：アイコンが空白の四角や欠落している場合は、Phosphorフォントを手動でインストールする必要があります。[phosphoricons.com](https://phosphoricons.com/)からダウンロード（[直接ダウンロード](https://phosphoricons.com/assets/phosphor-icons.zip)）、解凍し、`Fonts/regular/Phosphor.ttf`をインストールしてからJoplinを再起動してください。

**Macユーザー**： ‘Icon family’設定が「macOS native (SF Pro)」になっている場合、[Apple公式サイト](https://developer.apple.com/fonts/)からSF Proをインストールする必要があります。これはmacOSデバイスでのみ動作します。

## 免責事項

⚠️ Joplinはstyled-componentsでスタイリングされており、テーマの適用が非常に困難です。多くのハック的なCSS回避策や`!important`が使用されています。これにより将来のJoplinリリースでUIに問題が生じる可能性があります。CSSのみの変更なのでデータは安全で、スタイルは簡単に元に戻せます。

問題があれば[Issueを作成](https://github.com/ajilderda/joplin-macos-native-theme/issues)するか、[フォーラム](https://discourse.joplinapp.org/t/plugin-macos-theme-for-joplin)に投稿してください。

## プラグインインストール後に画面が真っ白になる場合の対処法

プラグインインストール後に画面が真っ白になる場合、これは絵文字処理の問題が原因である可能性が高いです。以下の方法で修正してください：

1. まず、Joplinの設定ディレクトリを見つけます：

   - macOS: `~/.config/joplin-desktop`
   - Windows: `%APPDATA%\Joplin`
   - Linux: `~/.config/Joplin`

2. `plugins`フォルダに移動し、macOSテーマプラグインの`.jpl`ファイルを削除します。
3. Joplinを再起動します。

### 予防策

この問題の発生を防ぐには：

- Joplinの「絵文字を選択...」ダイアログを使う代わりに、ノートブックタイトルのテキストボックスに直接絵文字を追加してください（視覚的な参考は[こちらのディスカッション](https://github.com/andrejilderda/joplin-macos-native-theme/issues/96#issuecomment-1553517708)を参照）。
- その後、プラグインを再インストールできます。

## 開発

Joplinの設定からテーマを調整できます。より徹底的にカスタマイズしたい場合は、以下の手順に従って独自のビルドを作成してください。

依存関係をインストール：

```sh
npm install
```
プラグインをビルドするには：


```sh
npm run dist
```
プラグインフレームワークを更新するには：


```sh
npm run update
```

CSSをビルドし、変更を監視するには：

```sh
npm run dev
```

生成されたCSSは以下で利用可能です: http://localhost:8080/macos-theme-for-joplin.css

## コントリビューション

コントリビューション（特に修正）は大歓迎です！

### 開発ワークフロー

変更のたびにJoplinを再起動するのは少し面倒です。作業を高速化しフィードバックループを短縮するために：

1. `npm run dev` を実行します。これにより .scss ファイルの変更を監視し、CSSを再構築します。
2. Joplinの開発者ツールを切り替えます（**ヘルプ › 開発者ツールの切り替え**）
3. [このgist](https://gist.github.com/andrejilderda/f6673f1b1a986b2dc0cd01607acbff26) の2つのリフレッシュ方法のどちらかを選択します。
4. 開発者ツールのコンソールにスクリプトを貼り付けて実行し、自動的にCSSをリフレッシュします。

これは大抵の場合うまく動作しますが、変更したスタイルがインストール済みプラグインのスタイルと干渉することもあります。そうした場合を確認するにはクリーンな環境を確保するために：

1. すでにmacOSテーマプラグインがインストールされている場合はアンインストールします。
2. ビルドを実行します：`npm run build`
3. Joplinで **プラグイン › 詳細設定を表示** に移動します。
4. **開発プラグイン** の下に `dist` フォルダのパスを貼り付けます。
5. ローカルビルドのプラグインを読み込むためにJoplinを再起動します。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---