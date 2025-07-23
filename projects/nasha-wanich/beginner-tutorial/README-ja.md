
# 画像チェンジャーポップアップ

ボタンをクリックすると画像が切り替わるカスタマイズ可能なインタラクティブなポップアップ


## プロジェクト概要

このプロジェクトは、一連の画像を表示するスタイリッシュなポップアップウィンドウを作成します。  
ユーザーがボタンをクリックするたびに画像が次のものに切り替わります。最後の画像に達すると、ボタンは消え、最終メッセージが表示されます。

## 学べること

* 簡単カスタマイズのためのCSS変数
* 基本的なHTMLのフレックス構造
* JavaScriptのイベント処理
* DOM操作

## 特徴

- CSS変数によるカスタマイズ可能な色、フォント、スタイリング
- カスタマイズ可能な背景画像、メイン画像のシーケンス、全テキスト
- 画像間のスムーズなフェードトランジション
- モバイル対応デザイン
- 装飾的なUI要素（閉じるボタンと縮小ボタン）

## 📁 プロジェクト構成

```
image-changer-popup/
├── assets/
│   ├── image-content/
│   │   ├── image-1.png
│   │   ├── image-2.png
│   │   ├── image-3.png
│   │   ├── image-4.png
│   │   ├── image-5.png
│   │   └── image-6.png
│   ├── close-icon.png
│   ├── favicon.png
│   ├── main-bg.png
│   └── shrink-icon.png
├── index.html
├── style.css
└── index.js
```
## 動作の仕組み

1. スタイライズされたポップアップコンテナがページに読み込まれます
2. 最初の画像が自動的に表示されます
3. ユーザーがボタンをクリックすると：
   - 現在の画像がフェードアウトします
   - 次の画像がプリロードされます
   - 読み込みが完了すると、新しい画像がフェードインします
4. 最終画像に達すると：
   - ボタンが消えます
   - 最終メッセージが表示されます
  
## このプロジェクトの再現方法 
1. GitHubからプロジェクトをクローンします
2. お好みのテキストエディタ（VScodeやその他のテキストエディタ）でプロジェクトを開きます
3. プロジェクトの構造とファイルを確認します：
   - `index.html`：ポップアップの基本構造を含みます
   - `style.css`：すべてのスタイリングとビジュアルカスタマイズオプションを含みます
   - `index.js`：画像切り替えの機能を担当します
4. ブラウザで`index.html`を開き、プロジェクトを表示します：
   - ファイルエクスプローラーでファイルをダブルクリックします
5. コード内の指示に従ってプロジェクトをカスタマイズします：
   - `style.css`のCSS変数を変更して色、フォント、スタイルを調整します
   - `assets`フォルダー内の画像を置き換えます（上記のアートワーク画像要件を参照）
   - HTMLファイル内のテキスト内容を更新します
6. JavaScriptの機能について：
   - 各行の機能にコメントを付けているので、自分で再作成してみることをお勧めします :)
7. ブラウザをリフレッシュして変更をリアルタイムでテストします
8. デプロイについては、以下のNetlifyホスティングの指示に従ってください

*プロジェクトの構造とファイル名が現在の名前と一致していることを確認するか、コード内で名前を変更してください。

## カスタマイズオプション

### アートワーク画像の要件
- アニメーションシーケンス（4～8枚の画像）：300 x 360px - 透過背景のpng推奨
- 背景画像：2093 x 1132 px
- ファビコン：サイズは柔軟、私のは238 x 279px - 透過背景のpng推奨
- クローズおよび縮小アイコン：正方形のアスペクト比ならサイズは柔軟、私のは287 x 287px

**プロジェクトの構造とファイル名が現在の名前と一致していることを確認するか、コード内で名前を変更してください。

このプロジェクトの画像の寸法を変更したい場合は、CSS内の対応するアスペクト比も更新する必要があります。変更が必要な具体的なセクションは以下の通りです：

画像コンテンツ（アニメーションエリア）について：

```css
.image-content {
  /* ... other properties ... */
  height: 65%;
  aspect-ratio: 142.5 / 171; /* Change these values to match your animation dimensions (300x360px) */
}
``` 


背景画像のサイズ設定について：

```css
body {
  /* ... other properties ... */
  background-size: 100% auto; /* Adjust based on your background image dimensions (2093x1132px) */
}
```
### 色とスタイリング

すべての視覚要素は、`style.css`の`:root`セクション内のCSS変数を通じてカスタマイズ可能です：



```css
:root {
  /* Colors */
  --color-page-background: #50AFC9;
  --color-main-container-background: #FF5B70;
  --color-inner-container-background: #FFF7F4;
  --color-border: #9E0E2B;
  --color-button-background: #FFF;
  --color-heading-text: #FFF;
  --color-button-text: #9E0E2B;
  --color-message-text: #9E0E2B;
  
  /* Images */
  --image-path-background: url('assets/main-bg.png');
  --image-path-content: url('assets/image-content/image-1.png');
  
  /* Fonts */
  --font-family-main: "Pixelify Sans", sans-serif;
  /* ... and more variables ... */
}
```
### テキストコンテンツ

HTMLファイル内の以下を変更してください：

- ページタイトル：`<title>For you &lt;3</title>`
- ヘッダーテキスト：`<h1>For you &lt;3</h1>`
- ボタンテキスト：`<button id="waterButton">Grow!</button>`
- 最終メッセージ：`<div class="final-message">Have a good day!</div>`

### 画像

1. `assets/image-content/`ディレクトリ内の画像を自身のものに置き換えてください
2. 同じファイル名を保持するか、JavaScript配列内のパスを更新してください
3. 配列にエントリを追加することで、画像を増やすことができます


```javascript
const images = [
  './assets/image-content/image-1.png',
  './assets/image-content/image-2.png',
  // Add more images here...
];
```
## 🌐 Netlifyでのホスティング

このプロジェクトはNetlifyの無料プランでデプロイできます：

**プロジェクトの準備**：
* ファイル名が正しいことを確認してください：`index.html` と `index.js`（名前を変更した場合）
* すべてのファイルパスが正しいことを確認してください（大文字小文字を区別）

**Netlifyにサインアップ**：
* netlify.com にアクセスし、無料アカウントを作成してください
* GitHub、GitLab、Bitbucket、またはメールでサインアップできます

**サイトのデプロイ**：
* プロジェクトフォルダをNetlifyのダッシュボードにドラッグ＆ドロップするだけです
* Netlifyが自動的にサイトをデプロイします

**サイトの設定**：
* デプロイ後、サイト名をカスタマイズできます
* 「Site settings」→「Change site name」に移動してください
* サイトは `your-site-name.netlify.app` で利用可能になります

**サイトの更新**：
* ドラッグ＆ドロップ方式を使った場合は、フォルダを再度ドラッグ＆ドロップしてください
* Gitと連携している場合は、リポジトリに変更をプッシュするだけです


## プロジェクト拡張アイデア

- 閉じるアイコンと縮小アイコンにクリック機能を追加する
- 最後の画像に到達した後、再起動ボタンを実装する
- ボタンクリックや画面遷移の効果音を追加する




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---