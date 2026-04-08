<div align="center">

<img src="https://media.giphy.com/media/Pt2yOXUALOhpB5dpiM/giphy.gif" alt="Meteor Devtool Evolved Gif" />

<p style="font-size: 30px">
Meteor Devtools 拡張機能
</p>
Meteor DevTools の進化をご覧ください。</p>

Meteor Devtools Evolved は現在、Google Chrome と Mozilla Firefox で利用可能です。

</div>

<p align="center" >
    <a href="https://chrome.google.com/webstore/detail/meteor-devtools-evolved/ibniinmoafhgbifjojidlagmggecmpgf">
    <img width="120" src="https://img.shields.io/badge/%20-Chrome-orange?logo=google-chrome&logoColor=white" alt="Chrome用ダウンロード" />
    </a>
    <a href="https://addons.mozilla.org/en-US/firefox/addon/meteor-devtools-evolved/">
    <img width="110" src="https://img.shields.io/badge/%20-Firefox-red?logo=mozilla&logoColor=white" alt="Firefox用ダウンロード" />
    </a>
</p>

[Harder, Better, Faster, Stronger](https://www.youtube.com/watch?v=gAjR4_CbPpQ) :rocket:

Meteor を始めたばかりですか？「何が起きているのか」を把握したり、Meteor アプリを最適化したいですか？それならこのツールが最適です。

:point_right: [変更履歴](https://raw.githubusercontent.com/leonardoventurini/meteor-devtools-evolved/development/CHANGELOG.md)

### 分散データプロトコル (DDP)

Meteor アプリケーションの内部で何が起きているのかを追跡し理解するために必要なすべて。拡張機能は任意の DDP メッセージをフィルタリングおよび検索でき、何千ものメッセージを問題なく処理できます。

### ブックマーク

DDP の検査は一時的ですが、後で検索および取得できるように任意の DDP メッセージをホストを問わず保存できます。ただし、IndexedDB に保存されるので注意してください。

### ミニモンゴ

どのデータがどこに属しているかわかりませんか？ミニモンゴのデータから何でも素早く検索でき、超高速のカスタムオブジェクトツリーネーターでドキュメントを簡単に可視化できます。

---

## 開発

> 免責事項: 本作業は部分的に The Bakery による [Meteor DevTools](https://github.com/bakery/meteor-devtools) 拡張機能に基づいています。残念ながら現在はメンテナンスされていません。必ずしもフォークではありませんが、有用な知識やアーキテクチャの決定を利用し、いくつかの点は自然に最も実用的な解決策へと収束しました。これが「進化した」所以です。

拡張機能はほぼ完全に TypeScript で記述されており、一部の Chrome 固有コードは実用的な理由で省かれています。状態管理には MobX を使用し、スタイルには SASS を用いています。また、Palantir の [Blueprint](https://github.com/palantir/blueprint) ライブラリのコンポーネントも使用しています。すべては Webpack でまとめられています。

> どなたでも貢献を歓迎します。詳細は [こちら](https://raw.githubusercontent.com/leonardoventurini/meteor-devtools-evolved/development/CONTRIBUTING.md) をご覧ください。

## Firefox

拡張機能の Firefox ポートは [@nilooy](https://github.com/nilooy) による貢献です。ありがとうございます！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-08

---