# Browserslist DB を更新する

<img width="120" height="120" alt="Browserslist logo by Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

[Browserslist](https://github.com/browserslist/browserslist/) の設定から、ブラウザーデータベース付きの `caniuse-lite` を更新する CLI ツールです。

`last 2 versions` や `>1%` などのクエリは、実際の `caniuse-lite` のデータに依存しています。

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Sponsored by Evil Martians" width="236" height="54">
</a>

## 定期的に実行する必要がある理由

`npx update-browserslist-db@latest` は、npm、yarn、または pnpm のロックファイル内の `caniuse-lite` のバージョンを更新します。

この更新により、Autoprefixer や Babel などのポリフィルツールに最新のブラウザーデータがもたらされ、不要なポリフィルを減らすことができます。

定期的に実行する必要がある理由は3つあります:

1. `last 2 versions` や `>1%` などのクエリで最新のブラウザーのバージョンと統計情報を利用できるようにするため。例えば、2年前にプロジェクトを作成し依存関係を更新していない場合、`last 1 version` は2年前のブラウザーを返します。
2. 実際のブラウザーデータを利用することで、ポリフィルの数を減らすことができます。これにより、JS や CSS ファイルのサイズが小さくなり、ウェブサイトのパフォーマンスが向上します。
3. `caniuse-lite` の重複排除: 異なるツール間でバージョンを同期させるためです。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---