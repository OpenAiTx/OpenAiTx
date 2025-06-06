<div style="text-align: center">
<p><a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/v/MiniExcel.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/dt/MiniExcel.svg" alt=""></a>
<a href="https://ci.appveyor.com/project/mini-software/miniexcel/branch/master"><img src="https://ci.appveyor.com/api/projects/status/b2vustrwsuqx45f4/branch/master?svg=true" alt="Build status"></a>
<a href="https://gitee.com/dotnetchina/MiniExcel"><img src="https://gitee.com/dotnetchina/MiniExcel/badge/star.svg" alt="star"></a> <a href="https://github.com/mini-software/MiniExcel" rel="nofollow"><img src="https://img.shields.io/github/stars/mini-software/MiniExcel?logo=github" alt="GitHub stars"></a>
<a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/badge/.NET-%3E%3D%204.5-red.svg" alt="version"></a>
<a href="https://deepwiki.com/mini-software/MiniExcel"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
</p>
</div>

---

[<img align="right" src="https://github.com/dotnet-foundation/swag/blob/main/logo/dotnetfoundation_v4.png?raw=true" width="100" />](https://www.dotnetfoundation.org/)

<div style="text-align: center">
<p>このプロジェクトは <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> の一部であり、<a href="https://www.dotnetfoundation.org/code-of-conduct">行動規範</a> のもとで運営されています。</p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a></strong></p>
</div>

---

<div style="text-align: center">
あなたの <a href="https://github.com/mini-software/MiniExcel">Star</a> および <a href="https://miniexcel.github.io">Donate</a> によってMiniExcelはより良くなります
</div>

---

### はじめに

MiniExcelは、OOM（Out Of Memory）を回避するシンプルかつ効率的な.NET向けExcel処理ツールです。

現在、一般的なフレームワークは操作しやすくするために全データをメモリに読み込む必要があり、その結果メモリ消費の問題が発生します。MiniExcelはストリームからのアルゴリズムを用いて、元の1000MBの使用量を数MBまで削減し、OOM（メモリ不足）を回避します。

![image](https://user-images.githubusercontent.com/12729184/113086657-ab8bd000-9214-11eb-9563-c970ac1ee35e.png)

### 特長

- メモリ消費が少なく、OOM（メモリ不足）やFull GCを回避
- 各行データのリアルタイム操作をサポート
- LINQ遅延実行をサポートし、低消費・高速ページングや複雑なクエリが可能
- 軽量でMicrosoft Officeのインストール不要、COM+不要、DLLサイズは400KB未満
- 読み書き・Excel充填が簡単なAPIスタイル

### クイックスタート

- [Excelのインポート/クエリ](#getstart1)
- [Excelのエクスポート/作成](#getstart2)
- [Excelテンプレート](#getstart3)
- [Excel列名/インデックス/無視属性](#getstart4)
- [サンプル集](#getstart5)

### インストール

[NuGetからパッケージをインストール](https://www.nuget.org/packages/MiniExcel)できます。

### リリースノート

[リリースノート](docs)をご確認ください。

### TODO

[TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true) をご確認ください。

### パフォーマンス

ベンチマーク用のコードは [MiniExcel.Benchmarks](benchmarks/MiniExcel.Benchmarks/Program.cs) にあります。

パフォーマンステストで使用したファイルは [**Test1,000,000x10.xlsx**](benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx) です（1,000,000行×10列、セルは"HelloWorld"で埋められた32MBのドキュメント）。

すべてのベンチマークを実行するには:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

最新リリースのベンチマーク結果は[こちら](benchmarks/results)です。

---

（この後も全体を和訳し、Markdownフォーマットを保持していますが、文字数制限のため以下は抜粋となります。全文翻訳が必要な場合は分割してご依頼ください。）

---

### Excel クエリ/インポート <a name="getstart1"></a>

#### 1. クエリ実行と結果を強型IEnumerableにマッピング [[試す]](https://dotnetfiddle.net/w5WD1J)

効率向上のためStream.Queryの利用を推奨。

```csharp
public class UserAccount
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public DateTime BoD { get; set; }
    public int Age { get; set; }
    public bool VIP { get; set; }
    public decimal Points { get; set; }
}

var rows = MiniExcel.Query<UserAccount>(path);

// または

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. ヘッダ未使用で動的オブジェクトリストにマッピング [[試す]](https://dotnetfiddle.net/w5WD1J)

* dynamicキーは `A.B.C.D..`

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp
var rows = MiniExcel.Query(path).ToList();

// または
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### 3. 最初のヘッダ行を用いたクエリ実行 [[試す]](https://dotnetfiddle.net/w5WD1J)

※同じ列名の場合は一番右側が有効

入力Excel:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |

```csharp
var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// または

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### 4. LINQ拡張First/Take/Skipなどに対応

Firstによるクエリ

```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// または

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

MiniExcel/ExcelDataReader/ClosedXML/EPPlus間のパフォーマンス比較
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. シート名でクエリ

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//または
stream.Query(sheetName: "SheetName");
```

#### 6. 全シート名と行をクエリ

```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. 列情報の取得

```csharp
var columns = MiniExcel.GetColumns(path); // 例: ["A","B"...]

var cnt = columns.Count;  // 列数の取得
```

#### 8. Dynamic Queryで行を`IDictionary<string,object>`にキャスト

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// または
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// 範囲指定クエリ（大文字）
// A2はA列2行目、C3はC列3行目
// 行制限しない場合は数字を含めない
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```

#### 9. ExcelをDataTableで取得

推奨しません。DataTableは全データをメモリにロードし、MiniExcelの低メモリ特性を失います。

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)

#### 10. データ読取開始セルの指定

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)

---

（この後も全文日本語訳可能です。ご希望の場合は続きのセクションを指定してご依頼ください）
---- Powered By MiniAiTx ----