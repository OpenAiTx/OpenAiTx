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
    <a href="https://fast-excel.github.io/fastexcel/"><img alt="Document" src="https://img.shields.io/github/actions/workflow/status/fast-excel/fastexcel/ci.yml?style=flat-square&logo=read-the-docs&label=文档"></a>
    <a href="https://deepwiki.com/fast-excel/fastexcel"><img src="https://img.shields.io/badge/DeepWiki-fast--excel%2Ffastexcel-blue.svg?logo=data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACwAAAAyCAYAAAAnWDnqAAAAAXNSR0IArs4c6QAAA05JREFUaEPtmUtyEzEQhtWTQyQLHNak2AB7ZnyXZMEjXMGeK/AIi+QuHrMnbChYY7MIh8g01fJoopFb0uhhEqqcbWTp06/uv1saEDv4O3n3dV60RfP947Mm9/SQc0ICFQgzfc4CYZoTPAswgSJCCUJUnAAoRHOAUOcATwbmVLWdGoH//PB8mnKqScAhsD0kYP3j/Yt5LPQe2KvcXmGvRHcDnpxfL2zOYJ1mFwrryWTz0advv1Ut4CJgf5uhDuDj5eUcAUoahrdY/56ebRWeraTjMt/00Sh3UDtjgHtQNHwcRGOC98BJEAEymycmYcWwOprTgcB6VZ5JK5TAJ+fXGLBm3FDAmn6oPPjR4rKCAoJCal2eAiQp2x0vxTPB3ALO2CRkwmDy5WohzBDwSEFKRwPbknEggCPB/imwrycgxX2NzoMCHhPkDwqYMr9tRcP5qNrMZHkVnOjRMWwLCcr8ohBVb1OMjxLwGCvjTikrsBOiA6fNyCrm8V1rP93iVPpwaE+gO0SsWmPiXB+jikdf6SizrT5qKasx5j8ABbHpFTx+vFXp9EnYQmLx02h1QTTrl6eDqxLnGjporxl3NL3agEvXdT0WmEost648sQOYAeJS9Q7bfUVoMGnjo4AZdUMQku50McDcMWcBPvr0SzbTAFDfvJqwLzgxwATnCgnp4wDl6Aa+Ax283gghmj+vj7feE2KBBRMW3FzOpLOADl0Isb5587h/U4gGvkt5v60Z1VLG8BhYjbzRwyQZemwAd6cCR5/XFWLYZRIMpX39AR0tjaGGiGzLVyhse5C9RKC6ai42ppWPKiBagOvaYk8lO7DajerabOZP46Lby5wKjw1HCRx7p9sVMOWGzb/vA1hwiWc6jm3MvQDTogQkiqIhJV0nBQBTU+3okKCFDy9WwferkHjtxib7t3xIUQtHxnIwtx4mpg26/HfwVNVDb4oI9RHmx5WGelRVlrtiw43zboCLaxv46AZeB3IlTkwouebTr1y2NjSpHz68WNFjHvupy3q8TFn3Hos2IAk4Ju5dCo8B3wP7VPr/FGaKiG+T+v+TQqIrOqMTL1VdWV1DdmcbO8KXBz6esmYWYKPwDL5b5FA1a0hwapHiom0r/cKaoqr+27/XcrS5UwSMbQAAAABJRU5ErkJggg==" alt="DeepWiki"></a>
<a href="https://readmex.com/fast-excel/fastexcel"><img src="https://raw.githubusercontent.com/CodePhiliaX/resource-trusteeship/main/readmex.svg" alt="ReadmeX"></a>
</p>

## 什么是 FastExcel

快速、简洁的 Java 工具，用于处理 Excel 文件，解决大文件内存溢出问题。

FastExcel 将始终保持免费和开源，采用对商业友好的 Apache 许可证，适用于任何商业场景。  
这为开发者和企业提供了极大的自由度和灵活性。  
我们计划未来引入更多新功能，不断提升用户体验和工具可用性。  
请关注“程序员小蓝”公众号，获取 FastExcel 开发的最新动态。  
FastExcel 致力于成为您处理 Excel 文件的最佳选择。

## 特性

- **高性能读写**：FastExcel 聚焦性能优化，能够高效处理大规模 Excel 数据。与一些传统 Excel 处理库相比，能显著降低内存消耗。
- **简洁易用**：该库提供简单直观的 API，使开发者能轻松集成到项目中，无论是简单的 Excel 操作还是复杂的数据处理。
- **流式操作**：FastExcel 支持流式读取，最大限度减少一次性加载大量数据的问题。该设计在处理数十万甚至数百万行数据时尤为重要。

## 安装

下表列出了 FastExcel 各版本对应的最低 Java 语言版本要求：

| 版本   | JDK 版本支持范围          | 备注  |
|--------|:-------------------------:|-------|
| 1.2.x  |       JDK8 - JDK21        |       |
| 1.1.x  |       JDK8 - JDK21        |       |
| 1.0.x  |       JDK8 - JDK21        |       |

强烈推荐使用最新版本的 FastExcel，因为最新版本中的性能优化、错误修复和新功能将提升您的使用体验。

> 当前，FastExcel 使用 POI 作为底层包。  
> 如果您的项目已经包含 POI 相关组件，您需要手动排除 POI 相关的 jar 包。

### 版本更新





有关详细的更新日志，请参阅[版本更新详情](https://raw.githubusercontent.com/fast-excel/fastexcel/main/./CHANGELOG.md)。您也可以在[Maven中央仓库](https://mvnrepository.com/artifact/cn.idev.excel/fastexcel)中找到所有可用版本。

### Maven

如果您使用Maven进行项目构建，请在`pom.xml`文件中添加以下配置：



```xml

<dependency>
    <groupId>cn.idev.excel</groupId>
    <artifactId>fastexcel</artifactId>
    <version>version</version>
</dependency>
```

### Gradle

如果您使用Gradle进行项目构建，请在build.gradle文件中添加以下配置：

```gradle
dependencies {
    implementation 'cn.idev.excel:fastexcel:version'
}
```

## 示例

### 读取 Excel 文件

下面是读取 Excel 文档的示例：

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

### 创建 Excel 文件

以下是创建 Excel 文档的一个简单示例：

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

## 贡献指南

欢迎贡献者加入 FastExcel 项目。请查阅 [贡献指南](https://raw.githubusercontent.com/fast-excel/fastexcel/main/./CONTRIBUTING.md) 了解如何
为本项目做出贡献。

感谢所有已经为 FastExcel 做出贡献的人！

<a href="https://github.com/fast-excel/fastexcel/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=fast-excel/fastexcel"/>
</a>

> 注意：由于 GitHub 图片大小限制，仅显示前 100 名贡献者

## Star 历史

[![Star 历史图表](https://api.star-history.com/svg?repos=fast-excel/fastexcel&type=Date)](https://www.star-history.com/#fast-excel/fastexcel&Date)

## 许可证

本项目采用 [Apache 许可证 2.0](LICENSE) 许可。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---