<div align="center">

![kirsch](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/header.png)

</div>

## 目次

- [目次](#table-of-contents)
- [概要](#overview)
- [ギャラリー](#gallery)
- [インストール／使用方法](#installation/usage)
  - [Nerd Fonts](#nerd-fonts)
  - [Propo](#propo)
  - [Nixpkgs](#nixpkgs)
  - [Nix Flakes](#nix-flakes)
  - [Web](#web)
- [デザインノート](#design-notes)
  - [装飾](#flourishes)
  - [間隔](#gaps)
- [貢献](#contributing)
- [クレジット](#credits)
- [ライセンス](#licensing)

## 概要

**kirsch** /ˈkɪərʃ/ _名詞_

1. _(ドイツ語)_ サクランボ。

1. _(ラッセル・A・カース、1929 - 2020)_ 初のデジタル画像スキャナの開発者であり、ピクセルの発明者として知られるアメリカの技術者。

1. 6x16のバウンディングボックス（平均幅5px、ベースラインからの下がり4px、上昇12px、x-ハイト5px、キャップハイト9px）を持つ等幅ビットマップフォント。様々な書体やモチーフから引き出し、小さなサイズで独特のヒューマニスト感を作り出しています。

   一部のグリフは[Cozette](https://github.com/slavfox/Cozette)由来で、kirschのデザインに合わせてしばしば修正されています。





## ギャラリー

<details>
<summary><strong>グリフ</strong></summary>
<div align="center">

![kirsch glyphs](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/chars.png)

</div>
</details>

<details>
<summary><strong>グリフマップ</strong></summary>
<div align="center">

![kirsch glyph map](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/map.png)

</div>
</details>

<details open>
<summary><strong>サンプル</strong></summary>
<div align="center">

![kirsch sample](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/sample.png)

</div>
</details>

## インストール／使用方法

[Releases](https://github.com/molarmanful/kirsch/releases) からダウンロードしてください。  
含まれているのはビットマップ形式のOTB、BDF、PCF、DFONT（Macユーザー向け）と  
TTFです。HiDPI画面用に2倍サイズのバージョンもあります。PCFはU+FFFF以降の  
グリフを含まないことに注意してください。

最も鮮明な表示を得るには、可能な限りビットマップ形式を使用してください。  
プラットフォームでビットマップフォントがサポートされていない場合（例：Windows、VSCode）  
は、16pxの倍数のフォントサイズでTTFを使用してください。

> [!TIP]
> フォントサイズをptで指定する必要がある場合は、以下の変換式を使用してください：
>
> `pt = px * 72 / dpi`
>
> 例：96dpiの画面で16pxは `16px * 72 / 96dpi = 12pt` となります。

### Nerd Fonts

kirschにはカスタムNerd Fontsのグリフが含まれています。サポートはまだ作業中です。
視覚的な明瞭さのために、kirschのNerd Fontsグリフは幅を大きく超えてはみ出す傾向があります。
これらのグリフは、前後にスペースを1つずつ入れてパディングすると最も見栄えが良くなるように設計されています。

Nerd Fontsの残りをカバーするパッチ済みNerd Fontsも利用可能です。
"Mono"バリアントはより小さなグリフ（幅がダブルではなくシングル）を使用し、
幅が混在できない端末でも動作します。

### Propo

部分的にはみ出すfootのような端末向けに、kirschのPropoバリアントがあります。
このバリアントはグリフを調整し、端末のフォントレンダラーでセルが切り取られないようにします。

### Nixpkgs

[@ejiektpobehuk](https://github.com/ejiektpobehuk)のおかげで、kirschは
Nixpkgsで `kirsch` として利用可能です。

### Nix Flakes

kirschのリリースは
[FlakeHub](https://flakehub.com/flake/molarmanful/kirsch)にもプッシュされています。
`kirsch`（`default`のエイリアス）は基本パッケージで、
`kirsch-nerd`はNerd Fontsのパッチを含みます。

### Web

ビットマップ対応がないため、一般的にはWebでのkirschの使用は推奨しません。
しかし、頑固で勇敢な方のためにWOFF2が利用可能です。
また、[CDNホストのスタイルシート](https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css)もあります。

便宜のため。

```html
<link
  rel="stylesheet"
  href="https://cdn.jsdelivr.net/npm/kirsch@latest/kirsch.css"
/>
```
## デザインノート

前作のフォント [eldur](https://github.com/molarmanful/eldur) は平均文字幅がわずか4pxだったのに対し、kirsch は平均文字幅が5pxです。その1pxの余裕がデザインに驚くほどの柔軟性をもたらします。5px幅に快適に収まるグリフがはるかに多く、例えば「m」や「w」などはカーニングを壊すことなく隣接グリフのスペースに侵入しません。5px幅に収まらないグリフは7px幅で扱うことができ、バランスと判読性を維持しつつカーニングに悪影響を及ぼしません。

### フローリッシュ

![rogue fijian xylophone](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-flourishes.png)

フローリッシュ（例えば「i」や「f」の飾り）はスタイリスティックな選択ですが、機能的な役割も果たします。フローリッシュがなければ「i」は1px幅しか使わず、4pxの中途半端な空白が残ります。「i」の両側に2pxずつのフローリッシュを付けることで5px幅となり、スタイリッシュにカーニング問題を解決します。

「l」の場合は、スクリプトスタイルのフローリッシュが他の縦長文字（`1I|`など）との差別化をさらに強化します。

### ギャップ

![bad queen peg 69](https://raw.githubusercontent.com/molarmanful/kirsch/main/./img/design-gaps.png)

kirsch の特徴的な要素の一つは文字のボウル部分にギャップがあることです。ギャップを埋めると文字が四角くなりすぎたり詰まりすぎたりしますが、ギャップを開けておくことで文字の形状がすっきりします。このギャップはスクリプトスタイルのストロークの終端も想起させます。

## 貢献

イシュー、機能やグリフのリクエスト、プルリクエストは大歓迎です！フォントファイルは [bited](https://github.com/molarmanful/bited) を使って編集しています。

## クレジット

これらのプロジェクトはkirschの作成にインスピレーションや助けを与えてくれたものであり、完全に価値があります















チェックアウト中。

- [Bits'n'Picas](https://github.com/kreativekorp/bitsnpicas)
- [Cozette](https://github.com/slavfox/Cozette)
- [Cyreal フォントテストページ](http://www.cyreal.org/Font-Testing-Page/)
- [W3 UTF-8 デモ](https://www.w3.org/2001/06/utf-8-test/UTF-8-demo.html) /
  [Markus Kuhn UTF-8 デモ](https://antofthy.gitlab.io/info/data/utf8-demo.txt)
- [APL386](https://abrudz.github.io/APL386)

## ライセンス

♥ を込めて [the kirsch Project Authors](AUTHORS) によって作成されました。OFL-1.1
ライセンスの下で公開されています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---