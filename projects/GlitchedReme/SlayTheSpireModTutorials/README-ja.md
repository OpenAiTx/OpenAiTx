殺戮の尖塔mod制作チュートリアル
=====================

「殺戮の尖塔2」モッド制作チュートリアル更新中： https://github.com/GlitchedReme/SlayTheSpire2ModdingTutorials

<b>本チュートリアルではJavaプログラミング知識は解説しません。あらかじめ基本的なプログラミングを理解してから学習することを推奨します。</b>

<b>読者が本チュートリアルを読んで誤りや不合理な点を発見した場合は、issuesを提出してチュートリアルの改善にご協力ください。</b>

<b>わからないことがあれば、以下の交流グループに参加するか、上部のdiscussionsで質問を投稿してください。</b>

<b>上部のTutorialsフォルダーまたは右側の[チュートリアルサイト](https://glitchedreme.github.io/SlayTheSpireModTutorials/)をクリックしてすべてのチュートリアルを確認できます。</b>

個人交流グループ：542370192

# いくつかの便利なツール/サイト

## 目次
* [サイト](#サイト)
* [ツール](#ツール)
* [modテンプレート](mod样板)
* [アニメーション](#动画)

## サイト
* [ModTheSpire Wiki](https://github.com/kiooeht/ModTheSpire/wiki)<br>
<b>ModTheSpire</b>（略称MTS）は、基本ゲームファイルを変更せずにSlay the Spireに外部モッドを読み込むツールで、同時にモッドが自分のコードをゲームコードにパッチできる仕組みを提供します。<br>
MTS Wikiにはグローバルセーブやpatchの方法が記載されています。


* [BaseMod Wiki](https://github.com/daviscook477/BaseMod/wiki)<br>
<b>BaseMod</b>はモッドの基礎APIで、mod作者がゲームに自分のカードなどのコンテンツを簡単に追加し、それらを一元管理できるようにします。<br>
WikiにはAutoAdd（すべてのカードを自動登録）、CardModifier（カード修飾子）、CustomSavable（一局内セーブ）などの便利なツールが紹介されています。BaseModの作者によるmod制作チュートリアルも含まれています。

## ツール
* [JD-GUI](http://java-decompiler.github.io/)<br>
Java逆コンパイルツールでGUIインターフェース付き。<br>
ゲームや他のmodの再構築されたソースコードを見ることができ、他者のコードを~~コピー~~学習しやすくします。<br>
patchのために必要な行数を調べるのにも使えます。（IDEA付属の逆コンパイラは正確でないことがあります）

* [sts裁图器](https://github.com/JohnnyBazooka89/StSModdingToolCardImagesCreator)<br>
画像を尖塔カードに必要な形状とサイズにトリミングします。<br>
私はこれを使ったことがありませんが、グループ内には同じ機能を持つ別のツールを自作している方がいます。

## modサンプル
* [ウォーロードエンブレムmod](https://github.com/Rita-Bernstein/Warlord-Emblem)<br>
~~Rita推薦、間違いなく高品質~~<br>
比較的標準化されたmodの例です。

## アニメーション
* [DragonBones](https://dragonbones.github.io/cn/index.html)<br>
spineアニメーションをエクスポートできるソフトで、通常はこちらで十分です。利用可能なバージョンを自分で探すこともできます。

*アニメーション制作には基礎知識が必要ですが、実際ほとんどのmodは1枚の画像だけで足ります。*
* [Spine](http://zh.esotericsoftware.com/)<br>
尖塔で使用されている2Dアニメーションソフトです。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---