# OfficeIMO - Microsoft Word .NET ライブラリ

OfficeIMO はギャラリーから NuGet パッケージとして利用可能で、推奨されるインストール方法です。

[![nuget downloads](https://img.shields.io/nuget/dt/officeIMO.Word?label=nuget%20downloads)](https://www.nuget.org/packages/OfficeIMO.Word)
[![nuget version](https://img.shields.io/nuget/v/OfficeIMO.Word)](https://www.nuget.org/packages/OfficeIMO.Word)
[![license](https://img.shields.io/github/license/EvotecIT/OfficeIMO.svg)](#)
[![CI](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master)](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml)
[![codecov](https://codecov.io/gh/EvotecIT/OfficeIMO/branch/master/graph/badge.svg)](https://codecov.io/gh/EvotecIT/OfficeIMO)

ご連絡は Twitter または LinkedIn で可能です。

[![twitter](https://img.shields.io/twitter/follow/PrzemyslawKlys.svg?label=Twitter%20%40PrzemyslawKlys&style=social)](https://twitter.com/PrzemyslawKlys)
[![blog](https://img.shields.io/badge/Blog-evotec.xyz-2A6496.svg)](https://evotec.xyz/hub)
[![linked](https://img.shields.io/badge/LinkedIn-pklys-0077B5.svg?logo=LinkedIn)](https://www.linkedin.com/in/pklys)
[![discord](https://img.shields.io/discord/508328927853281280?style=flat-square&label=discord%20chat)](https://evo.yt/discord)

## 何についてのものか

これは Microsoft Word ドキュメント（.docx）を .NET を使って作成できる小さなプロジェクト（開発中）です。  
内部的には [OpenXML SDK](https://github.com/OfficeDev/Open-XML-SDK) を使用していますが、大幅に簡素化しています。  
OpenXML の扱いは私にとって非常に難しく時間がかかるため、このプロジェクトを作成しました。  
PowerShell モジュールの [PSWriteOffice](https://github.com/EvotecIT/PSWriteOffice) 内で使うために作りましたが、  
.NET コミュニティの他の方にも役立つかもしれないと思いました。  
このリポジトリには簡単なスプレッドシート作成用の実験的な **OfficeIMO.Excel** コンポーネントも含まれています。

どんなことができるか見たい方はこの [ブログ記事](https://evotec.xyz/officeimo-free-cross-platform-microsoft-word-net-library/) をご覧ください。

以前は DocX ライブラリ（Xceed に引き継がれる前に共著・メンテナンスしていました）を使って Microsoft Word ドキュメントを作成していましたが、  
.NET Framework のみ対応で、最新のコミュニティライセンスによりプロジェクトが使えなくなりました。

*私はあまり開発者ではなく、何をしているかよくわからないので、もし協力できる方がいれば是非お願いします。*

- 悪いプラクティスを見かけたら、イシューを開くかプルリクエストを送ってください。
- OpenXML でこのプロジェクトに役立つ方法を知っていれば、イシューを開くかプルリクエストを送ってください。
- もっと良くできそうなことを見つけたら、イシューを開くかプルリクエストを送ってください。
- 私が馬鹿なことをしていたら、イシューを開くかプルリクエストを送ってください。
- 思っている動作と違う動きをしていたら、イシューを開くかプルリクエストを送ってください。

問題に気づいたり改善案があれば、ぜひイシューを開くかプルリクエストを送ってください。  
主な条件は .NET Framework 4.7.2、.NET Standard 2.0 等で動作することです。

**このプロジェクトは開発中であり、多くの部分が変わる可能性があります。特に誰かが協力してくれればなおさらです。**


| プラットフォーム | 状態 | コードカバレッジ | .NET |
| -------- | ------ | ------------- | ---- |
| Windows  | ![Windows](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `netstandard2.0`, `net472`, `net8.0`, `net9.0`; OfficeIMO.Excel: `netstandard2.0`, `net472`, `net48`, `net8.0`, `net9.0` |
| Linux    | ![Linux](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `net8.0`; OfficeIMO.Excel: `net8.0`, `net9.0` |
| MacOs    | ![macOS](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `net8.0`; OfficeIMO.Excel: `net8.0`, `net9.0` |
## このプロジェクトをサポートする

このプロジェクトが役に立った場合は、開発支援をご検討ください。  
スポンサーになることでメンテナがより多くの時間をメンテナンスや新機能開発に割けるようになります。

このプロジェクトの作成と維持には多大な時間と労力がかかっています。  
スポンサーになることで、必要なすべての人が無料で利用できる状態を維持するのに役立ちます。

スポンサーになるには、以下のオプションから選択できます：

- [GitHub Sponsors でスポンサーになる :heart:](https://github.com/sponsors/PrzemyslawKlys)
- [PayPal でスポンサーになる :heart:](https://paypal.me/PrzemyslawKlys)

スポンサーは完全に任意であり、このプロジェクトの利用に必須ではありません。  
私たちはこのプロジェクトをオープンソースのまま、誰でも無料で使える状態にしたいと考えています。  
スポンサーの有無にかかわらず利用可能です。

もしあなたが .NET ライブラリや PowerShell モジュールを使う企業に勤めている場合は、  
上司やマーケティングチームにこのプロジェクトの支援を検討してもらうようお願いしてください。  
企業の支援はこのプロジェクトの継続的な維持・改善に役立ちます。

ご検討いただきありがとうございます！

## コミュニティと共有してください

OfficeIMO の価値を伝える投稿の共有をご検討ください。とても助かります！

[![Share on reddit](https://img.shields.io/badge/share%20on-reddit-red?logo=reddit)](https://reddit.com/submit?url=https://github.com/EvotecIT/OfficeIMO&title=OfficeIMO)
[![Share on hacker news](https://img.shields.io/badge/share%20on-hacker%20news-orange?logo=ycombinator)](https://news.ycombinator.com/submitlink?u=https://github.com/EvotecIT/OfficeIMO)
[![Share on twitter](https://img.shields.io/badge/share%20on-twitter-03A9F4?logo=twitter)](https://twitter.com/share?url=https://github.com/EvotecIT/OfficeIMO&t=OfficeIMO)
[![Share on facebook](https://img.shields.io/badge/share%20on-facebook-1976D2?logo=facebook)](https://www.facebook.com/sharer/sharer.php?u=https://github.com/EvotecIT/OfficeIMO)
[![Share on linkedin](https://img.shields.io/badge/share%20on-linkedin-3949AB?logo=linkedin)](https://www.linkedin.com/shareArticle?url=https://github.com/EvotecIT/OfficeIMO&title=OfficeIMO)

## 機能

現在サポートされている（おそらく忘れているものも多い）機能と、計画中の機能の一覧です。  
これはクローズドなリストではなく、TODO のようなもので、もっとたくさんあります：

- ☑️ Word 基本機能
    - ☑️ 作成
    - ☑️ 読み込み
    - ☑️ 保存（保存時に自動で開くオプション付き）
    - ☑️ 名前を付けて保存（保存時に自動で開くオプション付き）
- ☑️ Word プロパティ
    - ☑️ 基本プロパティとカスタムプロパティの読み込み
    - ☑️ 基本プロパティとカスタムプロパティの設定
- ☑️ セクション
    - ☑️ 段落の追加
    - ☑️ ヘッダーとフッターの追加（奇数／偶数／最初）
    - ☑️ ヘッダーとフッターの削除（奇数／偶数／最初）
    - ☑️ 段落の削除
    - ☑️ セクションの削除
- ☑️ ドキュメント内のヘッダーとフッター（セクションは含まない）
    - ☑️ デフォルト、奇数ページ、偶数ページ、最初のページを追加
    - ☑️ デフォルト、奇数ページ、偶数ページ、最初のページを削除
- ☑️ 段落/テキストの編集（太字、下線、色付けなど）
    - ☑️ `WordParagraphStyle` を使ったカスタム段落スタイル
- ☑️ 段落の配置変更
- ☑️ 段落のインデント（前、後、最初の行、ぶら下げ）
- ☑️ 行間の設定（ツイップおよびポイント単位対応）
- ☑️ 表
    - ☑️ [表スタイルの追加・変更（105種類の組み込みスタイルのいずれか）](https://evotec.xyz/docs/adding-tables-with-built-in-styles-managing-borders/)
    - ☑️ 行と列の追加
    - ☑️ セルの追加
    - ☑️ セルのプロパティ追加
    - ☑️ [表セルの罫線の追加・変更](https://evotec.xyz/docs/adding-tables-with-built-in-styles-managing-borders/)
    - ☑️ 行の削除
    - ☑️ セルの削除
    - ☑️ その他
        - ☑️ セルの結合（縦、横）
        - ☑️ セルの分割（縦）
        - ☑️ セルの分割（横）
        - ☑️ 結合セルの検出（縦、横）
        - ☑️ ネストした表
        - ☑️ 各ページでヘッダー行を繰り返し表示
        - ☑️ 行のページ区切り制御
        - ☑️ 行の高さと表の幅の設定
- ☑️ 画像/ピクチャ（BMP、GIF、JPEG、PNG、TIFF、EMF対応、各種テキスト折り返しオプションあり）
    - ☑️ ファイルからWordへ画像を追加
    - ☑️ Base64文字列から画像を追加
    - ☑️ Wordから画像をファイルに保存
    - ☑️ 画像のトリミングと透過設定
    - ☑️ 画像の位置指定と位置情報の取得
    - ◼️ その他の位置タイプ
- ☑️ ハイパーリンク
    - ☑️ ハイパーリンクの追加
    - ☑️ ハイパーリンクの読み取り
    - ☑️ ハイパーリンクの削除
    - ☑️ ハイパーリンクの変更
- ☑️ 改ページ
    - ☑️ 改ページの追加
    - ☑️ 改ページの読み取り
    - ☑️ 改ページの削除
    - ☑️ 改ページの変更
- ☑️ ページ番号
    - ☑️ ヘッダーまたはフッターへのページ番号挿入
    - ☑️ `WordPageNumberStyle` でスタイル選択
- ☑️ ブックマーク
    - ☑️ ブックマークの追加
    - ☑️ ブックマークの読み取り
    - ☑️ ブックマークの削除
    - ☑️ ブックマークの変更
- ☑️ 文字列の検索と置換
  - ☑️ コメント
      - ☑️ コメントの追加
      - ☑️ コメントの読み取り
      - ☑️ コメントの削除（一つまたは全て）
      - ☑️ コメントの追跡
      - ☑️ スレッド形式の返信
- ☑️ フィールド
    - ☑️ フィールドの追加
    - ☑️ フィールドの読み取り
    - ☑️ フィールドの削除
    - ☑️ フィールドの変更
- ☑️ 脚注
    - ☑️ 新規脚注の追加
    - ☑️ 脚注の読み取り
    - ☑️ 脚注の削除
- ☑️ 末尾脚注
    - ☑️ 新規末尾脚注の追加
    - ☑️ 末尾脚注の読み取り
    - ☑️ 末尾脚注の削除
- ☑️ ドキュメント変数
    - ☑️ ドキュメント内に保存された変数の設定・読み取り
    - ☑️ 名前またはインデックスによる変数の削除
- ☑️ マクロ
    - ☑️ VBAプロジェクトの追加または抽出
    - ☑️ マクロモジュールの削除
- ☑️ 差し込み印刷
    - ☑️ `MERGEFIELD` の値を置換
    - ☑️ フィールドコードの保持オプション
- ☑️ コンテンツコントロール
    - ☑️ コントロールの追加
    - ☑️ コントロールの読み取り
    - ☑️ コントロールテキストの更新
    - ☑️ コントロールの削除
    - ☑️ チェックボックスフォームコントロール
    - ☑️ 日付選択フォームコントロール
    - ☑️ ドロップダウンリストフォームコントロール
    - ☑️ コンボボックスフォームコントロール
    - ☑️ 画像フォームコントロール
    - ☑️ 繰り返しセクションフォームコントロール
- ☑️ 図形
    - ☑️ 長方形の追加
    - ☑️ 楕円の追加
    - ☑️ 線の追加
    - ☑️ 多角形の追加
    - ☑️ 塗りつぶしと線の色の設定
    - ☑️ 図形の削除
- ☑️ チャート
    - ☑️ チャートの追加
        - ☑️ 円グラフおよび3D円グラフ
        - ☑️ 棒グラフおよび3D棒グラフ
        - ☑️ 折れ線グラフおよび3D折れ線グラフ
        - ☑️ コンボグラフ（棒＋折れ線）
        - ☑️ 面グラフおよび3D面グラフ
        - ☑️ 散布図
        - ☑️ レーダーチャート
    - ☑️ カテゴリと凡例の追加
    - ☑️ 軸の設定
    - ☑️ 複数系列の追加
    - ⚠️ 棒グラフと折れ線グラフを混在させる場合は、両方のグラフタイプが同じカテゴリ軸を共有するように、データ追加前に `AddChartAxisX` を呼び出してください。
- ☑️ 数式
    - ☑️ OMMLからOffice数式を挿入
    - ☑️ 必要に応じて数式を削除
- ☑️ リスト
    - ☑️ リストの追加
    - ☑️ リストの削除
    - ☑️ 番号設定を保持したリストの複製
    - ☑️ 画像の箇条書きリストの追加
    - ☑️ カスタム箇条書きおよび番号付きリストの作成
    - ☑️ 既存段落からリストスタイルの検出
- ☑️ 目次
    - ☑️ 目次の追加
    - ☑️ 開いた時に目次フィールドを更新
- ☑️ 枠線
    - ☑️ 組み込みスタイルまたはカスタム設定
    - ☑️ サイズ、色、スタイル、間隔の変更
- ☑️ 背景
    - ☑️ 背景色の設定
- ☑️ 透かし
    - ☑️ テキストまたは画像透かしの追加
    - ☑️ `WordWatermarkStyle` によるテキストまたは画像スタイルの選択
    - ☑️ 回転、幅、高さの設定
    - ☑️ 透かしの削除

- ☑️ 表紙ページ
    - ☑️ 組み込み表紙ページの追加

- ☑️ フォント
    - ☑️ `WordDocument.EmbedFont` を使ったフォント埋め込み

- ☑️ 埋め込みコンテンツ
    - ☑️ 埋め込み文書の追加（RTF、HTML、TXT）
    - ☑️ HTMLフラグメントの追加
    - ☑️ 段落後にHTMLフラグメントを挿入
    - ☑️ テキストをHTMLフラグメントで置換
    - ☑️ 埋め込み文書の削除
    - ☑️ カスタムアイコンとサイズでオブジェクトを埋め込み
 - ☑️ [デジタル署名と文書セキュリティ](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.DigitalSignature.cs)
 - ☑️ [文書保護オプション](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Settings.cs)（最終文書、読み取り専用推奨、読み取り専用強制）
 - ☑️ [変更履歴の承認/拒否](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Revisions.cs)
 - ☑️ [非同期保存/読み込みAPI](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Async.cs)
 - ☑️ [複数文書のマージ](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.MergeDocuments.cs)
 - ☑️ [配置オプション付きテキストボックス](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.TextBox.cs)
 - ☑️ [ページの向き、ページサイズ、余白プリセット](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.PageSettings.cs) ([余白](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Sections.cs))
 - ☑️ [タブ文字とカスタムタブストップ](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.TabStops.cs)
 - ☑️ [文書検証ユーティリティ](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Validation.cs)
 - ☑️ [CleanupDocumentメソッド](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Cleanup.cs) は同一のランを統合
 - ☑️ [段落のXMLシリアル化](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Examples/Word/XmlSerialization/XmlSerialization.Basic.cs)
 - ☑️ [測定単位変換ヘルパー](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.HelpersConversions.cs)

- ☑️ 実験的Excelコンポーネント
    - ☑️ ブックの作成と読み込み
    - ☑️ ワークシートの追加
    - ☑️ 非同期保存および読み込みAPI


## 機能一覧（一行説明）:

この機能一覧は、フル機能を使うよりも迅速に修正したい場合に役立ちます。
これらの機能は `WordHelpers` クラスの一部として利用可能です。

- ☑️ ファイルからヘッダーとフッターを削除
- ☑️ DOTXテンプレートをDOCXに変換

## サンプル

### 少数の文書プロパティと段落を持つ基本的な文書

この短い例は、1つの段落テキストと少数の文書プロパティを持つWord文書の作成方法を示します。


```csharp
string filePath = System.IO.Path.Combine(
    "Support",
    "GitHub",
    "PSWriteOffice",
    "Examples",
    "Documents",
    "BasicDocument.docx");

using (WordDocument document = WordDocument.Create(filePath)) {
    document.BuiltinDocumentProperties.Title = "This is my title";
    document.BuiltinDocumentProperties.Creator = "Przemysław Kłys";
    document.BuiltinDocumentProperties.Keywords = "word, docx, test";

    var paragraph = document.AddParagraph("Basic paragraph");
    paragraph.ParagraphAlignment = JustificationValues.Center;
    paragraph.Color = SixLabors.ImageSharp.Color.Red;

document.Save(true);
}
```

### ストリーム内で直接ドキュメントを作成する

このオーバーロードは、ドキュメントを完全にメモリ内または任意の指定されたストリーム上で生成することを可能にします。

```csharp
using var stream = new MemoryStream();
using (var document = WordDocument.Create(stream)) {
    document.AddParagraph("Stream based document");
    document.Save(stream);
}
stream.Position = 0;
using (var loaded = WordDocument.Load(stream)) {
    Console.WriteLine(loaded.Paragraphs[0].Text);
}
```

### 新しいドキュメントとして保存

`SaveAs` は現在のドキュメントを新しいパスにクローンし、元の `FilePath` を変更せずに新しい `WordDocument` インスタンスを返します。

```csharp
using (WordDocument document = WordDocument.Create()) {
    document.AddParagraph("Some text");
    using var copy = document.SaveAs(filePath);
    // document.FilePath is still null
    // copy.FilePath equals filePath
}
```

### バイト配列およびストリームへの保存

`SaveAsByteArray` と `SaveAsMemoryStream` はすべてをメモリ内に保持します。`SaveAs(Stream)` はドキュメントを指定されたストリームに複製し、そこから読み込んだ新しいインスタンスを返します。

```csharp
using (WordDocument document = WordDocument.Create()) {
    document.AddParagraph("In memory");
    byte[] data = document.SaveAsByteArray();
    using MemoryStream stream = document.SaveAsMemoryStream();
    using var clone = document.SaveAs(stream);
}
```

### フォントの埋め込み

`EmbedFont` は TrueType または OpenType フォントファイルをドキュメントに追加し、どのマシンでも使用できるようにします。

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("This document uses an embedded font.");
    document.Save();
}
```

`EmbedFont` には段落スタイルを自動的に登録できるオーバーロードがあります：

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath, "DejaVuStyle", "DejaVu Style");
    document.AddParagraph("Styled paragraph").SetStyleId("DejaVuStyle");
    document.Save();
}
```

### 組み込みフォントと埋め込みフォントの混在

フォントを埋め込んだ後は、標準フォントとともに名前で参照できます。

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("Builtin Arial").SetFontFamily("Arial");
    document.AddParagraph("Embedded DejaVu Sans").SetFontFamily("DejaVu Sans");
    var mixed = document.AddParagraph("Mix: ");
    mixed.AddText("Arial, ").SetFontFamily("Arial");
    mixed.AddText("DejaVu").SetFontFamily("DejaVu Sans");
    document.Save();
}
```
組み込みフォントを使用する段落スタイルを作成することもできます。


```csharp
var style = new Style { Type = StyleValues.Paragraph, StyleId = "EmbeddedStyle" };
style.Append(new StyleName { Val = "EmbeddedStyle" });
style.Append(new StyleRunProperties(new RunFonts { Ascii = "DejaVu Sans" }));
WordParagraphStyle.RegisterCustomStyle("EmbeddedStyle", style);

using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("Paragraph with embedded style").SetStyleId("EmbeddedStyle");
    document.AddParagraph("Built-in style example").Style = WordParagraphStyles.Normal;
    document.Save();
}
```

### ヘッダー/フッター付き基本ドキュメント（最初、奇数、偶数）

この短い例は、Wordドキュメントにヘッダーとフッターを追加する方法を示しています。

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.Sections[0].PageOrientation = PageOrientationValues.Landscape;
    document.AddParagraph("Test Section0");
    document.AddHeadersAndFooters();
    document.DifferentFirstPage = true;
    document.DifferentOddAndEvenPages = true;

    document.Sections[0].Header.First.AddParagraph().SetText("Test Section 0 - First Header");
    document.Sections[0].Header.Default.AddParagraph().SetText("Test Section 0 - Header");
    document.Sections[0].Header.Even.AddParagraph().SetText("Test Section 0 - Even");

    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();

    var section1 = document.AddSection();
    section1.PageOrientation = PageOrientationValues.Portrait;
    section1.AddParagraph("Test Section1");
    section1.AddHeadersAndFooters();
    section1.Header.Default.AddParagraph().SetText("Test Section 1 - Header");
    section1.DifferentFirstPage = true;
    section1.Header.First.AddParagraph().SetText("Test Section 1 - First Header");

    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();

    var section2 = document.AddSection();
    section2.AddParagraph("Test Section2");
    section2.PageOrientation = PageOrientationValues.Landscape;
    section2.AddHeadersAndFooters();
    section2.Header.Default.AddParagraph().SetText("Test Section 2 - Header");

    document.AddParagraph("Test Section2 - Paragraph 1");

    var section3 = document.AddSection();
    section3.AddParagraph("Test Section3");
    section3.AddHeadersAndFooters();
    section3.Header.Default.AddParagraph().SetText("Test Section 3 - Header");

    Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
    Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 1: " + document.Sections[2].Paragraphs[1].Text);
    Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Paragraphs[0].Text);

    Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Header.Default.Paragraphs[0].Text);
    document.Save(true);
}
```

### コンテンツコントロールの追加

この例では、シンプルなコンテンツコントロールを追加および更新し、その後タグで取得する方法を示します。

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    var sdt = document.AddStructuredDocumentTag("Hello", "MyAlias", "MyTag");
    sdt.Text = "Changed";
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    var tag = document.GetStructuredDocumentTagByTag("MyTag");
Console.WriteLine(tag.Text);
}
```

### 複数のコンテンツコントロール

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.AddStructuredDocumentTag("First", "Alias1", "Tag1");
    document.AddStructuredDocumentTag("Second", "Alias2", "Tag2");
    document.AddStructuredDocumentTag("Third", "Alias3", "Tag3");
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    foreach (var control in document.StructuredDocumentTags) {
        Console.WriteLine(control.Tag + ": " + control.Text);
    }
}
```

### 高度なコンテンツ制御の使用法

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.AddStructuredDocumentTag("First", "Alias1", "Tag1");
    document.AddStructuredDocumentTag("Second", "Alias2", "Tag2");
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    var alias = document.GetStructuredDocumentTagByAlias("Alias2");
    alias.Text = "Updated";
    var tag = document.GetStructuredDocumentTagByTag("Tag1");
    Console.WriteLine(tag.Text);
}
```

### OfficeIMOの高度な使用法

この短い例は、`OfficeIMO.Word`の複数の機能を示しています。

```csharp
string filePath = System.IO.Path.Combine(folderPath, "AdvancedDocument.docx");
using (WordDocument document = WordDocument.Create(filePath)) {
    // lets add some properties to the document
    document.BuiltinDocumentProperties.Title = "Cover Page Templates";
    document.BuiltinDocumentProperties.Subject = "How to use Cover Pages with TOC";
    document.ApplicationProperties.Company = "Evotec Services";

    // we force document to update fields on open, this will be used by TOC
    document.Settings.UpdateFieldsOnOpen = true;

    // lets add one of multiple added Cover Pages
    document.AddCoverPage(CoverPageTemplate.IonDark);

    // lets add Table of Content (1 of 2)
    document.AddTableOfContent(TableOfContentStyle.Template1);

    // lets add page break
    document.AddPageBreak();

    // lets create a list that will be binded to TOC
    var wordListToc = document.AddTableOfContentList(WordListStyle.Headings111);

    wordListToc.AddItem("How to add a table to document?");

    document.AddParagraph("In the first paragraph I would like to show you how to add a table to the document using one of the 105 built-in styles:");

    // adding a table and modifying content
    var table = document.AddTable(5, 4, WordTableStyle.GridTable5DarkAccent5);
    table.Rows[3].Cells[2].Paragraphs[0].Text = "Adding text to cell";
    table.Rows[3].Cells[2].Paragraphs[0].Color = Color.Blue; ;
    table.Rows[3].Cells[3].Paragraphs[0].Text = "Different cell";

    document.AddParagraph("As you can see adding a table with some style, and adding content to it ").SetBold().SetUnderline(UnderlineValues.Dotted).AddText("is not really complicated").SetColor(Color.OrangeRed);

    wordListToc.AddItem("How to add a list to document?");

    var paragraph = document.AddParagraph("Adding lists is similar to ading a table. Just define a list and add list items to it. ").SetText("Remember that you can add anything between list items! ");
    paragraph.SetColor(Color.Blue).SetText("For example TOC List is just another list, but defining a specific style.");

    var list = document.AddList(WordListStyle.Bulleted);
    list.AddItem("First element of list", 0);
    list.AddItem("Second element of list", 1);

    var paragraphWithHyperlink = document.AddHyperLink("Go to Evotec Blogs", new Uri("https://evotec.xyz"), true, "URL with tooltip");
    // you can also change the hyperlink text, uri later on using properties
    paragraphWithHyperlink.Hyperlink.Uri = new Uri("https://evotec.xyz/hub");
    paragraphWithHyperlink.ParagraphAlignment = JustificationValues.Center;

    list.AddItem("3rd element of list, but added after hyperlink", 0);
    list.AddItem("4th element with hyperlink ").AddHyperLink("included.", new Uri("https://evotec.xyz/hub"), addStyle: true);

    document.AddParagraph();

    // create a custom bullet list
    var custom = document.AddCustomBulletList(WordListLevelKind.BulletSquareSymbol, "Courier New", SixLabors.ImageSharp.Color.Red, fontSize: 16);
    custom.AddItem("Custom bullet item");

    // create a list using an image as the bullet
    var pictureList = document.AddPictureBulletList(Path.Combine(folderPath, "Images", "Kulek.jpg"));
    pictureList.AddItem("Image bullet 1");
    pictureList.AddItem("Image bullet 2");

    // create a multi-level custom list
    var builder = document.AddCustomList()
        .AddListLevel(1, WordListLevelKind.BulletSquareSymbol, "Courier New", SixLabors.ImageSharp.Color.Red, fontSize: 14)
        .AddListLevel(5, WordListLevelKind.BulletBlackCircle, "Arial", colorHex: "#00ff00", fontSize: 10);
    builder.AddItem("First");
    builder.AddItem("Fifth", 4);

    // Note: use AddCustomList() rather than AddList(WordListStyle.Custom)
    // when you want to build lists with your own levels.
    // See [Custom Lists](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/Docs/custom-lists.md) for details on configuring levels.

    var listNumbered = document.AddList(WordListStyle.Heading1ai);
    listNumbered.AddItem("Different list number 1");
    listNumbered.AddItem("Different list number 2", 1);
    listNumbered.AddItem("Different list number 3", 1);
    listNumbered.AddItem("Different list number 4", 1);

    var section = document.AddSection();
    section.PageOrientation = PageOrientationValues.Landscape;
    section.PageSettings.PageSize = WordPageSize.A4;

    wordListToc.AddItem("Adding headers / footers");

    // lets add headers and footers
    document.AddHeadersAndFooters();

    // adding text to default header
    document.Header.Default.AddParagraph("Text added to header - Default");

    var section1 = document.AddSection();
    section1.PageOrientation = PageOrientationValues.Portrait;
    section1.PageSettings.PageSize = WordPageSize.A5;

    wordListToc.AddItem("Adding custom properties to document");

    document.CustomDocumentProperties.Add("TestProperty", new WordCustomProperty { Value = DateTime.Today });
    document.CustomDocumentProperties.Add("MyName", new WordCustomProperty("Some text"));
    document.CustomDocumentProperties.Add("IsTodayGreatDay", new WordCustomProperty(true));

    // document variables available via DocVariable fields
    document.SetDocumentVariable("Project", "OfficeIMO");
    document.SetDocumentVariable("Year", DateTime.Now.Year.ToString());

    if (document.HasDocumentVariables) {
        foreach (var pair in document.DocumentVariables) {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    document.Save(openWord);
}
```

## テスト

`OfficeIMO.Word` がユニットテストを使用していることに加えて、[Characterization Tests](https://en.wikipedia.org/wiki/Characterization_test) も使用されています。
Characterization test は動作を壊す変更を見落とさないために追加されました。これらのテストは [Verify](https://github.com/VerifyTests/Verify) （["Snapshot Testing in .NET with Verify"](https://youtu.be/wA7oJDyvn4c)）に基づいています。
検証済みスナップショットを追加または更新する必要がある場合は、powershell スクリプトを使用できます:
```bash
$ pwsh -c ./Build/ApproveVerifyTests.ps1
```
Verifyテストが失敗したときにコンソール出力の代わりにグラフィカルな差分を表示するには、  
テストを実行する前に環境変数 `DiffEngine_Disabled=false` を設定してください。  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---