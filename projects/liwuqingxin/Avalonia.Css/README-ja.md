<div align="left">
  <a href="https://github.com/microsoft/dotnet">
    <img src="https://img.shields.io/badge/-.NET-red">
  </a>
  <a href="https://avaloniaui.net/">
    <img src="https://img.shields.io/badge/Avalonia-8245A9">
  </a>
  <a href="https://dotnet.microsoft.com/zh-cn/languages/csharp">
    <img src="https://img.shields.io/badge/-C%23-yellow">
  </a>
  <a href="http://www.gnu.org/licenses/mit.en.html">
    <img src="https://img.shields.io/badge/License-MIT-green">
  </a>
</div>
<br/><br/>

![acss-brand](https://raw.githubusercontent.com/liwuqingxin/Avalonia.Css/main/img/AcssText.svg)

Avalonia Css、略してAcssは、標準のCSS（カスケーディングスタイルシート）には従いません。Avalonia UIの**構造的定義と視覚的定義を分離し**、Avaloniaにスタイルを**動的に素早く変更する能力を付与する**ことを目的としています。

そう、**Html+CSS**に似たパターンに従っています。

# プロモーション

最近、Ant Designスタイルに準拠したAvaloniaコントロールライブラリを発見しました—非常に優れた作りです。コア開発者と話した結果、お互いに相互プロモーションで支援し合うことに合意しました。興味があれば、[こちら](https://github.com/chinware/AtomUI)でご覧ください。

![](https://github.com/chinware/AtomUI/blob/develop/resources/images/readme/AtomUIOSS.png)


![](https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.svg)

Jet Brainsの[無料開発者ツール](https://www.jetbrains.com/community/opensource/?utm_campaign=opensource&utm_content=approved&utm_medium=email&utm_source=newsletter&utm_term=jblogo#support)に大変感謝しています。

# 特徴

- 構造とスタイルの分離
- 構造の再利用
- 動的読み込み
- ホットロード
- インターセプトとフィルター
- 振る舞いの拡張  
- 構文の拡張  
- スタイルのデバッグ  
- カスタム描画  

# ドキュメント  

ドキュメントは[こちら](https://docs.en.avalonia.css.nlnet.net/documentation/readme)でご覧いただけます。英語ドキュメントはDeepLによる中国語からの翻訳です。問題がある場合は、GitHubでの編集を歓迎します。  

> 中文文档请参考 [这里](https://docs.avalonia.css.nlnet.net/documentation/readme)。  

# 使い方  

Acssの使用方法については[こちら](https://docs.en.avalonia.css.nlnet.net/documentation/zhu-ti-bang-zhu/ru-he-shi-yong-acss)をご覧ください。  

# 貢献  

より多くの関心あるパートナーがAcssの作成に参加し、より活気に満ちた強力なものにしていくことを期待しています。  

参加に興味がある方やアイデア、提案、フィードバックがある方は、yangqi1990917@163.com までメールをお送りください。  

# ショーケース  

Acssによって動作するAvaloniaコントロール用のFluentテーマを提供しています。テーマの詳細は[Acss.Fluent](https://docs.en.avalonia.css.nlnet.net/documentation/zhu-ti-bang-zhu/ru-he-shi-yong-acss.fluent)をご覧ください。  

Acssのショーケースの詳細は[bilibili](https://space.bilibili.com/1117754194/channel/seriesdetail?sid=3739599)または[youtube](https://www.youtube.com/channel/UCYvEgvGj-JVYZrOrup3aoBQ)でご覧いただけます。  

<br/>  

![fluent ui](https://raw.githubusercontent.com/liwuqingxin/Avalonia.Css/main/./img/fluent-ui.png)  

# なぜAcssを使うのか  

> テーマ = 構造 + スタイル  

標準のコントロールライブラリがあり、そのコントロールの機能はテンプレート内の構造に依存していると想像してください。コントロールの見た目を変更したい場合、通常はすべてのControlThemeを書き換える必要があります。つまり、コントロールの構造とスタイル、さらにはリソースまでも書き直さなければならず、非常に手間のかかる作業です。  

Acssパターンでは、標準テーマからスタイルを抽出し、骨格となるControlTemplateのみを保持します。どのライブラリでも標準構造をベースにして、自身のAcssライブラリを定義し、コントロールの望む見た目を実現できます。ライブラリの制作者は既存のControlThemeコードを苦労してコピーして修正する必要はありません。コントロールテンプレートが正しいかどうかを心配する必要もありません。関心を持つべきはUIデザインに基づくスタイルの調整だけです！  

> 継続的な集中が、私たちの作業をよりスムーズに、より優雅に、より効果的にします。
別のケースとして、新しいページを作成する場合があります。従来のワークフローは通常、レイアウト、コンテンツの配置、ビジネスロジックの記述、スタイル調整、UIデザインに基づく微調整を含みます。これは一般的に開発者の作業であり、ページが完成するまで継続的な注意が必要です。現在、Acssパターンでは、機能担当者がページのコンテンツを配置し、ビジネスロジックを記述し、その後、ビジュアルに焦点を当てる担当者に引き継いで視覚スタイルを調和させるアプローチとなります。

# 提供しているパッケージ

- **Nlnet.Avalonia.Css**。これはAcssのコアです。

- **Nlnet.Avalonia.Css.Controls**。このライブラリはAvalonia.Controlsのコントロールのための純粋な構造を提供します。

- **Nlnet.Avalonia.Css.Fluent**。このライブラリはAvalonia.Controls、Nlnet.Avalonia.Senior、Nlnet.Avalonia.MessageBox向けのFluent UIを提供します。

- **Nlnet.Avalonia.Css.Behaviors**。このライブラリはAcssの拡張ビヘイビアを提供します。
- **Nlnet.Avalonia.Senior**。このライブラリは**スムーススクロール**など、Avalonia.Controlsが提供できないいくつかの拡張機能を提供します。
- **Nlnet.Avalonia.MessageBox**。これはWPF標準またはAvalonia標準に準拠したMessageBoxコントロールを提供します。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---