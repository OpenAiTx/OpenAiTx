# Kelp

HTMLを愛する人々のためのUIライブラリ。モダンなCSSとWeb Componentsによって動作します。

**[ドキュメントを読む &rarr;](https://kelpui.com)**

_**注意:** Kelpは現在アルファ版で開発中です。ご自由にご利用・実験・バグ報告をしていただいて構いませんが、今後変更が加えられる可能性があることをご理解ください。_



## クイックスタート

Kelpはビルドステップなしで動作します。

[CDN](https://cdn.jsdelivr.net/npm/kelpui/)が最も素早く、簡単な導入方法ですが、[GitHubからファイルをダウンロード](https://github.com/cferdinandi/kelp)することもできます。

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelpはセマンティックバージョニングを採用しています。CDNで`@1.2.3`のような表記でメジャー・マイナー・パッチバージョンを指定できます。利用可能なすべてのバージョンは[リリース一覧](https://github.com/cferdinandi/kelp/tags)で確認できます。



## デモ

同梱の`index.html`ファイルは、Kelpの機能をすべて盛り込んだキッチンシンクデモです。全ての機能とコンポーネントが一つの大きなファイルに含まれています。

ベータ版の間、Kelpにはコンパイルステップはありません。WebコンポーネントはESインポートを使用しており、ローカルサーバーでの実行が必要です。

お好きなサーバーを使用するか、同梱の`http-server`を使う場合は`npm run dev`を実行してください。

```bash
npm install
npm run dev
```

Kelpがv1に近づくにつれ、この手順が不要となるようコンパイルステップが追加される予定です。



## テスト

Kelpは以下を使用しています...

- テスト用に [Playwright](https://playwright.dev)
- リンティングとフォーマット用に [Biome](https://biomejs.dev)
- デプロイとPR時の継続的インテグレーションプロセス

```bash
# テスト実行
npm run test

# リンター実行
npm run lint
```



## ライセンス

[Kelp Commons License](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md)のもとで無料でご利用いただけます。[商用ライセンスオプション](/license/)もご用意しています。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---