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
    <a href="https://fast-excel.github.io/fastexcel/"><img alt="Document" src="https://img.shields.io/github/actions/workflow/status/fast-excel/fastexcel/ci.yml?style=flat-square&logo=read-the-docs&label=Documento"></a>
    <a href="https://deepwiki.com/fast-excel/fastexcel"><img src="https://img.shields.io/badge/DeepWiki-fast--excel%2Ffastexcel-blue.svg?logo=data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACwAAAAyCAYAAAAnWDnqAAAAAXNSR0IArs4c6QAAA05JREFUaEPtmUtyEzEQhtWTQyQLHNak2AB7ZnyXZMEjXMGeK/AIi+QuHrMnbChYY7MIh8g01fJoopFb0uhhEqqcbWTp06/uv1saEDv4O3n3dV60RfP947Mm9/SQc0ICFQgzfc4CYZoTPAswgSJCCUJUnAAoRHOAUOcATwbmVLWdGoH//PB8mnKqScAhsD0kYP3j/Yt5LPQe2KvcXmGvRHcDnpxfL2zOYJ1mFwrryWTz0advv1Ut4CJgf5uhDuDj5eUcAUoahrdY/56ebRWeraTjMt/00Sh3UDtjgHtQNHwcRGOC98BJEAEymycmYcWwOprTgcB6VZ5JK5TAJ+fXGLBm3FDAmn6oPPjR4rKCAoJCal2eAiQp2x0vxTPB3ALO2CRkwmDy5WohzBDwSEFKRwPbknEggCPB/imwrycgxX2NzoMCHhPkDwqYMr9tRcP5qNrMZHkVnOjRMWwLCcr8ohBVb1OMjxLwGCvjTikrsBOiA6fNyCrm8V1rP93iVPpwaE+gO0SsWmPiXB+jikdf6SizrT5qKasx5j8ABbHpFTx+vFXp9EnYQmLx02h1QTTrl6eDqxLnGjporxl3NL3agEvXdT0WmEost648sQOYAeJS9Q7bfUVoMGnjo4AZdUMQku50McDcMWcBPvr0SzbTAFDfvJqwLzgxwATnCgnp4wDl6Aa+Ax283gghmj+vj7feE2KBBRMW3FzOpLOADl0Isb5587h/U4gGvkt5v60Z1VLG8BhYjbzRwyQZemwAd6cCR5/XFWLYZRIMpX39AR0tjaGGiGzLVyhse5C9RKC6ai42ppWPKiBagOvaYk8lO7DajerabOZP46Lby5wKjw1HCRx7p9sVMOWGzb/vA1hwiWc6jm3MvQDTogQkiqIhJV0nBQBTU+3okKCFDy9WwferkHjtxib7t3xIUQtHxnIwtx4mpg26/HfwVNVDb4oI9RHmx5WGelRVlrtiw43zboCLaxv46AZeB3IlTkwouebTr1y2NjSpHz68WNFjHvupy3q8TFn3Hos2IAk4Ju5dCo8B3wP7VPr/FGaKiG+T+v+TQqIrOqMTL1VdWV1DdmcbO8KXBz6esmYWYKPwDL5b5FA1a0hwapHiom0r/cKaoqr+27/XcrS5UwSMbQAAAABJRU5ErkJggg==" alt="DeepWiki"></a>
    <a href="https://readmex.com/fast-excel/fastexcel"><img src="https://raw.githubusercontent.com/CodePhiliaX/resource-trusteeship/main/readmex.svg" alt="ReadmeX"></a>
</p>

## Qué es FastExcel

Herramienta rápida, concisa y en Java para procesar archivos Excel que resuelve problemas de desbordamiento de memoria con archivos grandes.

FastExcel siempre será gratuito y de código abierto, utiliza la licencia Apache amigable para negocios, lo que lo hace adecuado para cualquier escenario comercial. Esto brinda a desarrolladores y empresas gran libertad y flexibilidad.
Planeamos introducir más características nuevas en el futuro para mejorar continuamente la experiencia del usuario y la usabilidad de la herramienta. Mantente atento a la cuenta pública de "Programador Xiao Lan" para actualizaciones sobre el desarrollo de FastExcel. FastExcel está comprometido a ser tu mejor opción para manejar archivos Excel.

## Características

- **Lectura y escritura de alto rendimiento**: FastExcel se enfoca en la optimización del rendimiento, capaz de manejar eficientemente datos Excel a gran escala. En comparación con algunas librerías tradicionales de procesamiento Excel, puede reducir significativamente el consumo de memoria.
- **Simplicidad y facilidad de uso**: La biblioteca ofrece una API simple e intuitiva, permitiendo a los desarrolladores integrarla fácilmente en proyectos, ya sea para operaciones simples de Excel o procesamiento de datos complejo.
- **Operaciones en streaming**: FastExcel soporta lectura en flujo, minimizando el problema de cargar grandes cantidades de datos de una sola vez. Este diseño es especialmente importante al tratar con cientos de miles o incluso millones de filas de datos.

## Instalación

La siguiente tabla enumera los requisitos mínimos de versión del lenguaje Java para cada versión de la biblioteca FastExcel:

| Versión | Rango de soporte de versión JDK | Notas |
|---------|:-------------------------------:|-------|
| 1.2.x   |       JDK8 - JDK21              |       |
| 1.1.x   |       JDK8 - JDK21              |       |
| 1.0.x   |       JDK8 - JDK21              |       |

Recomendamos encarecidamente usar la última versión de FastExcel, ya que las optimizaciones de rendimiento, correcciones de errores y nuevas características en la versión más reciente mejorarán tu experiencia.

> Actualmente, FastExcel utiliza POI como su paquete subyacente. Si tu proyecto ya incluye componentes relacionados con POI,
> necesitarás excluir manualmente los archivos jar relacionados con POI.

### Actualización de versión









Para registros detallados de actualizaciones, consulte [Detalles de las actualizaciones de versión](https://raw.githubusercontent.com/fast-excel/fastexcel/main/./CHANGELOG.md). También puede encontrar todas las versiones disponibles en el [Repositorio Central de Maven](https://mvnrepository.com/artifact/cn.idev.excel/fastexcel).

### Maven

Si utiliza Maven para la construcción del proyecto, agregue la siguiente configuración en el archivo `pom.xml`:


```xml

<dependency>
    <groupId>cn.idev.excel</groupId>
    <artifactId>fastexcel</artifactId>
    <version>version</version>
</dependency>
```

### Gradle

Si está utilizando Gradle para la construcción del proyecto, agregue la siguiente configuración en el archivo build.gradle:

```gradle
dependencies {
    implementation 'cn.idev.excel:fastexcel:version'
}
```

## Ejemplo

### Leyendo archivos Excel

A continuación se muestra un ejemplo de cómo leer un documento Excel:

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

### Creación de archivos Excel

A continuación se muestra un ejemplo sencillo de cómo crear un documento Excel:

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

## Contribuir

Se da la bienvenida a los colaboradores para unirse al proyecto FastExcel. Por favor consulte la [Guía de Contribución](https://raw.githubusercontent.com/fast-excel/fastexcel/main/./CONTRIBUTING.md) sobre cómo
contribuir a este proyecto.

¡Gracias a todas las personas que ya han contribuido a FastExcel!

<a href="https://github.com/fast-excel/fastexcel/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=fast-excel/fastexcel"/>
</a>

> Nota: Se muestran solo los primeros 100 colaboradores debido a limitaciones en el tamaño de la imagen de GitHub

## Historial de Estrellas

[![Gráfico del Historial de Estrellas](https://api.star-history.com/svg?repos=fast-excel/fastexcel&type=Date)](https://www.star-history.com/#fast-excel/fastexcel&Date)

## Licencia

El proyecto está licenciado bajo la [Licencia Apache 2.0](LICENSE).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---