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

## FastExcel이란 무엇인가

대용량 파일의 메모리 오버플로우 문제를 해결하는 빠르고 간결한 자바 엑셀 처리 도구입니다.

FastExcel은 항상 무료이자 오픈 소스이며, 비즈니스 친화적인 Apache 라이선스를 사용하여 모든
상업적 시나리오에 적합합니다. 이는 개발자와 기업에게 큰 자유와 유연성을 제공합니다.
앞으로도 사용자 경험과 도구 사용성을 지속적으로 향상시키기 위해 새로운 기능을 도입할 계획입니다. FastExcel의 개발 소식은 "프로그래머 샤오란" 공식 계정을 통해 확인하세요. FastExcel은
엑셀 파일 처리에 있어 최선의 선택이 되기 위해 최선을 다하고 있습니다.

## 특징

- **고성능 읽기 및 쓰기**: FastExcel은 성능 최적화에 중점을 두어 대규모 엑셀 데이터를 효율적으로
  처리할 수 있습니다. 일부 전통적인 엑셀 처리 라이브러리와 비교했을 때 메모리 소비를 크게 줄일 수 있습니다.
- **간단하고 사용하기 쉬움**: 라이브러리는 간단하고 직관적인 API를 제공하여, 개발자가 프로젝트에 쉽게
  통합할 수 있게 하며, 단순한 엑셀 작업부터 복잡한 데이터 처리까지 모두 지원합니다.
- **스트림 작업 지원**: FastExcel은 스트림 읽기를 지원하여, 대량의 데이터를 한 번에 로드하는 문제를 최소화합니다. 수십만, 수백만 행의 데이터를 다룰 때 특히 중요한 설계입니다.

## 설치

아래 표는 FastExcel 라이브러리 각 버전별 최소 자바 언어 버전 요구 사항을 나타냅니다:

| 버전    | JDK 버전 지원 범위         | 비고  |
|---------|:-------------------------:|-------|
| 1.2.x   |       JDK8 - JDK21        |       |
| 1.1.x   |       JDK8 - JDK21        |       |
| 1.0.x   |       JDK8 - JDK21        |       |

최신 버전의 FastExcel 사용을 강력히 권장합니다. 최신 버전의 성능 최적화, 버그 수정, 신규 기능들이
사용자 경험을 향상시킬 것입니다.

> 현재 FastExcel은 POI를 기반 패키지로 사용합니다. 프로젝트에 이미 POI 관련 컴포넌트가 포함되어 있다면,
> POI 관련 jar 파일을 수동으로 제외해야 합니다.

### 버전 업데이트




자세한 업데이트 로그는 [버전 업데이트 세부 정보](https://raw.githubusercontent.com/fast-excel/fastexcel/main/./CHANGELOG.md)를 참조하세요. 사용 가능한 모든 버전은 [Maven 중앙 저장소](https://mvnrepository.com/artifact/cn.idev.excel/fastexcel)에서도 확인할 수 있습니다.

### Maven

프로젝트 빌드에 Maven을 사용하는 경우, `pom.xml` 파일에 다음 구성을 추가하세요:


```xml

<dependency>
    <groupId>cn.idev.excel</groupId>
    <artifactId>fastexcel</artifactId>
    <version>version</version>
</dependency>
```

### Gradle

프로젝트 빌드에 Gradle을 사용하는 경우, build.gradle 파일에 다음 구성을 추가하세요:

```gradle
dependencies {
    implementation 'cn.idev.excel:fastexcel:version'
}
```

## 예제

### 엑셀 파일 읽기

아래는 엑셀 문서를 읽는 예제입니다:

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

### 엑셀 파일 생성하기

아래는 엑셀 문서를 생성하는 간단한 예제입니다:

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
## 기여하기

FastExcel 프로젝트에 기여자를 환영합니다. 이 프로젝트에 어떻게 기여할 수 있는지에 대해서는 [기여 가이드](https://raw.githubusercontent.com/fast-excel/fastexcel/main/./CONTRIBUTING.md)를 확인해 주세요.

이미 FastExcel에 기여해 주신 모든 분들께 감사드립니다!

<a href="https://github.com/fast-excel/fastexcel/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=fast-excel/fastexcel"/>
</a>

> 참고: GitHub 이미지 크기 제한으로 인해 처음 100명의 기여자만 표시됩니다

## 스타 히스토리

[![Star History Chart](https://api.star-history.com/svg?repos=fast-excel/fastexcel&type=Date)](https://www.star-history.com/#fast-excel/fastexcel&Date)

## 라이선스

이 프로젝트는 [Apache License 2.0](LICENSE) 하에 라이선스가 부여되었습니다.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---