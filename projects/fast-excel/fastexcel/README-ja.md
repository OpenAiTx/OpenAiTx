<p align="center">
    <img src="https://raw.githubusercontent.com/fast-excel/fastexcel/main/logo.svg"/>
</p>

<p align="center">
    <a href="README.md">English</a> | <a href="README_ZH.md">中文</a> | <a href="README_JP.md">日本語</a>
</p>

<p align="center">
    <a href="https://github.com/fast-excel/fastexcel/actions/workflows/ci.yml"><img alt="GitHub Actions Workflow Status" src="https://img.shields.io/github/actions/workflow/status/fast-excel/fastexcel/ci.yml?style=flat-square&logo=github"></a>
    <a href="https://github.com/fast-excel/fastexcel/actions/workflows/nightly.yml"><img alt="GitHub Actions Workflow Status" src="https://img.shields.io/github/actions/workflow/status/fast-excel/fastexcel/nightly.yml?style=flat-square&logo=github&label=nightly"></a>
    <a href="https://github.com/fast-excel/fastexcel/blob/main/LICENSE"><img alt="GitHub License" src="https://img.shields.io/github/license/fast-excel/fastexcel?logo=apache&style=flat-square"></a>
    <a href="https://mvnrepository.com/artifact/cn.idev.excel/fastexcel"><img alt="Maven Central Version" src="https://img.shields.io/maven-central/v/cn.idev.excel/fastexcel?logo=apachemaven&style=flat-square"></a>
</p>

<p align="center">
    <a href="https://fast-excel.github.io/fastexcel/"><img alt="Document" src="https://img.shields.io/github/actions/workflow/status/fast-excel/fastexcel/ci.yml?style=flat-square&logo=read-the-docs&label=Document"></a>
    <a href="https://deepwiki.com/fast-excel/fastexcel"><img src="https://img.shields.io/badge/DeepWiki-fast--excel%2Ffastexcel-blue.svg?logo=data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACwAAAAyCAYAAAAnWDnqAAAAAXNSR0IArs4c6QAAA05JREFUaEPtmUtyEzEQhtWTQyQLHNak2AB7ZnyXZMEjXMGeK/AIi+QuHrMnbChYY7MIh8g01fJoopFb0uhhEqqcbWTp06/uv1saEDv4O3n3dV60RfP947Mm9/SQc0ICFQgzfc4CYZoTPAswgSJCCUJUnAAoRHOAUOcATwbmVLWdGoH//PB8mnKqScAhsD0kYP3j/Yt5LPQe2KvcXmGvRHcDnpxfL2zOYJ1mFwrryWTz0advv1Ut4CJgf5uhDuDj5eUcAUoahrdY/56ebRWeraTjMt/00Sh3UDtjgHtQNHwcRGOC98BJEAEymycmYcWwOprTgcB6VZ5JK5TAJ+fXGLBm3FDAmn6oPPjR4rKCAoJCal2eAiQp2x0vxTPB3ALO2CRkwmDy5WohzBDwSEFKRwPbknEggCPB/imwrycgxX2NzoMCHhPkDwqYMr9tRcP5qNrMZHkVnOjRMWwLCcr8ohBVb1OMjxLwGCvjTikrsBOiA6fNyCrm8V1rP93iVPpwaE+gO0SsWmPiXB+jikdf6SizrT5qKasx5j8ABbHpFTx+vFXp9EnYQmLx02h1QTTrl6eDqxLnGjporxl3NL3agEvXdT0WmEost648sQOYAeJS9Q7bfUVoMGnjo4AZdUMQku50McDcMWcBPvr0SzbTAFDfvJqwLzgxwATnCgnp4wDl6Aa+Ax283gghmj+vj7feE2KBBRMW3FzOpLOADl0Isb5587h/U4gGvkt5v60Z1VLG8BhYjbzRwyQZemwAd6cCR5/XFWLYZRIMpX39AR0tjaGGiGzLVyhse5C9RKC6ai42ppWPKiBagOvaYk8lO7DajerabOZP46Lby5wKjw1HCRx7p9sVMOWGzb/vA1hwiWc6jm3MvQDTogQkiqIhJV0nBQBTU+3okKCFDy9WwferkHjtxib7t3xIUQtHxnIwtx4mpg26/HfwVNVDb4oI9RHmx5WGelRVlrtiw43zboCLaxv46AZeB3IlTkwouebTr1y2NjSpHz68WNFjHvupy3q8TFn3Hos2IAk4Ju5dCo8B3wP7VPr/FGaKiG+T+v+TQqIrOqMTL1VdWV1DdmcbO8KXBz6esmYWYKPwDL5b5FA1a0hwapHiom0r/cKaoqr+27/XcrS5UwSMbQAAAABJRU5ErkJggg==" alt="DeepWiki"></a>
    <a href="https://readmex.com/fast-excel/fastexcel"><img src="https://raw.githubusercontent.com/CodePhiliaX/resource-trusteeship/main/readmex.svg" alt="ReadmeX"></a>
</p>

## FastExcelとは

大規模ファイルでのメモリオーバーフロー問題を解決する、高速で簡潔なJava製Excelファイル処理ツールです。

FastExcelは常に無料かつオープンソースで提供され、ビジネスに適したApacheライセンスを採用しているため、
あらゆる商用シナリオに適しています。これにより、開発者や企業に大きな自由度と柔軟性を提供します。
今後も新機能を導入し続け、ユーザー体験とツールの使いやすさを向上させる予定です。
FastExcelの開発状況は「プログラマー小蓝」の公式アカウントで随時更新しています。
FastExcelはExcelファイル処理の最良の選択肢となることを目指しています。

## 特徴

- **高性能な読み書き**：FastExcelはパフォーマンス最適化に注力しており、大規模なExcelデータを効率的に処理可能です。
  従来のExcel処理ライブラリと比較して、メモリ消費を大幅に削減できます。
- **シンプルで使いやすい**：シンプルで直感的なAPIを提供し、簡単なExcel操作から複雑なデータ処理まで、
  開発者が容易にプロジェクトへ統合できます。
- **ストリーム処理対応**：大量のデータを一度に読み込む問題を最小限に抑えるストリーム読み込みをサポート。
  数十万行、数百万行のデータを扱う場合に特に重要な設計です。

## インストール

以下の表はFastExcelライブラリ各バージョンの最低Java言語バージョン要件を示しています：

| バージョン | JDKバージョンサポート範囲 | 備考 |
|---------|:-------------------------:|-------|
| 1.2.x   |       JDK8 - JDK21        |       |
| 1.1.x   |       JDK8 - JDK21        |       |
| 1.0.x   |       JDK8 - JDK21        |       |

FastExcelの最新バージョンの使用を強く推奨します。最新バージョンにはパフォーマンス最適化、
バグ修正、新機能が含まれており、より良い体験が可能です。

> 現在、FastExcelは内部的にPOIを利用しています。もしプロジェクトに既にPOI関連コンポーネントが含まれている場合、
> POI関連のjarファイルを手動で除外する必要があります。

### バージョンアップデート


詳細な更新ログについては、[バージョンアップデートの詳細](https://raw.githubusercontent.com/fast-excel/fastexcel/main/./CHANGELOG.md)を参照してください。すべての利用可能なバージョンは、[Maven Central Repository](https://mvnrepository.com/artifact/cn.idev.excel/fastexcel)でも確認できます。

### Maven

プロジェクトのビルドにMavenを使用している場合は、`pom.xml`ファイルに次の設定を追加してください：


```xml

<dependency>
    <groupId>cn.idev.excel</groupId>
    <artifactId>fastexcel</artifactId>
    <version>version</version>
</dependency>
```

### Gradle

プロジェクトのビルドにGradleを使用している場合は、build.gradleファイルに以下の設定を追加してください:

```gradle
dependencies {
    implementation 'cn.idev.excel:fastexcel:version'
}
```

## 例

### Excelファイルの読み込み

以下はExcelドキュメントを読み込む例です：

```java
// Implement the ReadListener interface to set up operations for reading data
public class DemoDataListener implements ReadListener<DemoData> {
    
    @Override
    public void invoke(DemoData data, AnalysisContext context) {
        System.out.println("Parsed a data entry" + JSON.toJSONString(data));
    }
    
    @Override
    public void doAfterAllAnalysed(AnalysisContext context) {
        System.out.println("All data parsed!");
    }
}

public static void main(String[] args) {
    String fileName = "demo.xlsx";
    // Read Excel file
    FastExcel.read(fileName, DemoData.class, new DemoDataListener()).sheet().doRead();
}
```

### Excelファイルの作成

以下はExcelドキュメントを作成する簡単な例です：

```java
// Sample data class
public class DemoData {
    
    @ExcelProperty("String Title")
    private String string;
    
    @ExcelProperty("Date Title")
    private Date date;
    
    @ExcelProperty("Number Title")
    private Double doubleData;
    
    @ExcelIgnore
    private String ignore;
}

// Prepare data to write
private static List<DemoData> data() {
    List<DemoData> list = new ArrayList<>();
    for (int i = 0; i < 10; i++) {
        DemoData data = new DemoData();
        data.setString("String" + i);
        data.setDate(new Date());
        data.setDoubleData(0.56);
        list.add(data);
    }
    return list;
}

public static void main(String[] args) {
    String fileName = "demo.xlsx";
    // Create a "Template" sheet and write data
    FastExcel.write(fileName, DemoData.class).sheet("Template").doWrite(data());
}
```
## 貢献について

FastExcelプロジェクトへの貢献者を歓迎します。貢献方法については[貢献ガイド](https://raw.githubusercontent.com/fast-excel/fastexcel/main/./CONTRIBUTING.md)を参照してください。

FastExcelにすでに貢献してくださったすべての方に感謝します！

<a href="https://github.com/fast-excel/fastexcel/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=fast-excel/fastexcel"/>
</a>

> 注: GitHubの画像サイズ制限により最初の100人の貢献者のみ表示しています

## スター履歴

[![スター履歴チャート](https://api.star-history.com/svg?repos=fast-excel/fastexcel&type=Date)](https://www.star-history.com/#fast-excel/fastexcel&Date)

## ライセンス

本プロジェクトは[Apache License 2.0](LICENSE)のもとでライセンスされています。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---