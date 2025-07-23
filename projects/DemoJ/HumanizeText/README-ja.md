
# 人話翻訳器

## プロジェクト概要

人話翻訳器は、Chromeブラウザ拡張機能で、ユーザーがウェブページ上のテキストを迅速に翻訳するのを支援します。美しくドラッグ可能なポップアップインターフェースを提供し、リアルタイム翻訳とコピー機能をサポートしています。  

現在、主要なブラウザのプラグイン市場に公開されており、「人話翻訳器」で検索するか、以下のリンクからアクセスしてダウンロード・ご利用いただけます。  
Chromeブラウザ：[chromeウェブストア](https://chromewebstore.google.com/detail/genddacnaonloeecodkncflhpcdbcmdh)  
Edgeブラウザ：[Edgeアドオンストア](https://microsoftedge.microsoft.com/addons/detail/%E4%BA%BA%E8%AF%9D%E7%BF%BB%E8%AF%91%E5%99%A8/nfcgnclfgdeocdakoconadlbonnjaglj)  
Firefoxブラウザ：[Firefoxアドオンストア](https://addons.mozilla.org/zh-CN/firefox/addon/%E4%BA%BA%E8%AF%9D%E7%BF%BB%E8%AF%91%E5%99%A8/)  

## 主な機能

- **テキスト選択翻訳**：ウェブページ上のテキストを選択すると翻訳が起動
- **リアルタイム翻訳表示**：翻訳結果をポップアップ内にリアルタイム表示
- **思考過程表示**：翻訳の思考プロセスを表示可能
- **ドラッグ可能なインターフェース**：ポップアップはドラッグ対応で位置調整が簡単
- **コピー機能**：ワンクリックで翻訳結果をコピー
- **Markdown対応**：翻訳結果はMarkdown形式のレンダリングをサポート

## 使用方法

1. Chromeブラウザで拡張機能をインストール
2. 拡張機能アイコンをクリックし設定画面でAPI情報を入力
3. 任意のウェブページで翻訳したいテキストを選択
4. 右クリックメニューまたはショートカットキーで翻訳を起動
5. 表示された翻訳ウィンドウで結果を確認
6. タイトルバーをドラッグしてポップアップの位置を移動可能
7. 「訳文をコピー」ボタンをクリックして翻訳結果をコピー
8. 右上の「✕」ボタンをクリックしてポップアップを閉じる

## 技術的実装

### フロントエンドインターフェース

- 純粋なJavaScriptで構築されたポップアップインターフェース
- CSSデザインは美しく、スクロールやドラッグなどの操作に対応
- カスタムMarkdownパーサーを使ってテキストを整形

### 通信メカニズム

- Chrome拡張のメッセージ伝達機構（`chrome.runtime.onMessage`）を使用
- 以下のメッセージタイプをサポート：
  - `showTranslationPopup`：翻訳ポップアップを表示
  - `translate`：翻訳リクエストを送信
  - `updateTranslation`：翻訳結果を更新
  - `cleanup`：リソースをクリーンアップ

### 特徴的な設計

- **スタイル競合防止**：全てのCSSクラス名に`translator-`プレフィックスを付与
- **スマートスクロール**：ユーザーが手動スクロールしていない場合のみ自動で最下部までスクロール
- **エラーハンドリング**：充実したエラー処理機構で親切なエラーメッセージを提供
- **シングルトンパターン**：同時に翻訳ポップアップは一つだけ存在することを保証

## プロジェクト構造


```
├── content/
│   └── content.js    # 内容脚本，负责弹窗创建和交互
├── background/
│   └── background.js # 后台脚本，处理翻译请求和API调用
├── popup/
│   ├── popup.html    # 扩展弹出窗口HTML
│   ├── popup.js      # 扩展弹出窗口脚本
│   └── popup.css     # 扩展弹出窗口样式
├── options/
│   ├── options.html  # 选项页面HTML
│   ├── options.js    # 选项页面脚本
│   └── options.css   # 选项页面样式
├── assets/
│   ├── icon.png      # 扩展图标目录
├── manifest.json     # 扩展配置文件
└── README.md         # 项目说明文档
```
## 開発上の注意点

- 拡張機能は Chrome 拡張 API を使用しており、manifest.json にて権限を正しく設定する必要があります
- 翻訳機能はバックエンド API に依存しており、API キーの設定が正しいことを確認してください
- スタイル設計はウェブページの既存スタイルと分離することを考慮しており、競合を避けます


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---