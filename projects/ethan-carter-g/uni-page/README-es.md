
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Uni-Page Marco de Paginación

Uni-Page es un marco de paginación universal basado en Java, que mediante un diseño abstracto, proporciona una interfaz de consulta de paginación unificada para diferentes fuentes de datos. El marco adopta una arquitectura modular, integrando actualmente JDBC, Mybatis, MongoDB, Elasticsearch y otras fuentes de datos, y ofrece un mecanismo de extensión flexible.

## Diseño Central

El diseño central del marco gira en torno a cuatro componentes clave:

1. **Sentencia de paginación (PaginationStatement)**
    - Soporta la definición de sentencias de paginación en cualquier lenguaje
    - Proporciona una interfaz unificada de parámetros de paginación
    - Permite personalizar la lógica de paginación

2. **Ejecutor de sentencia de paginación (PaginationStatementExecutor)**
    - Responsable de ejecutar la sentencia de consulta paginada
    - Proporciona funcionalidad de consulta de información de paginación
    - Mecanismo de ejecutor extensible

3. **Conjunto de resultados de paginación (PaginationResultSet)**
    - Interfaz de conjunto de resultados unificada
    - Soporta acceso a datos por nombre de columna e índice
    - Proporciona funcionalidad de conversión de tipos
    - Diseño similar al JDBC ResultSet

4. **Procesador de conjunto de resultados (PaginationResultSetHandler)**
    - Soporta conversión personalizada de conjunto de resultados
    - Proporciona funcionalidad de mapeo de objetos


## Objetivos de diseño

1. **Unificación**
    - Proporciona una interfaz de consulta de paginación unificada
    - Oculta las diferencias de implementación entre distintas fuentes de datos
    - Simplifica el uso de consultas paginadas

2. **Flexibilidad**
    - Soporta sentencias de paginación personalizadas
    - Permite extender los ejecutores
    - Ofrece diversas formas de procesamiento de conjuntos de resultados

3. **Escalabilidad**
    - Diseño modular
    - Soporta la rápida integración de nuevas fuentes de datos
    - Proporciona un mecanismo de puntos de extensión

4. **Facilidad de uso**
    - API simple e intuitiva
    - Conversión de tipos completa
    - Soporte de clases utilitarias enriquecido
## Escenarios de uso

- Proyectos que requieren gestión unificada de consultas paginadas en múltiples fuentes de datos
- Aplicaciones empresariales que necesitan soporte de paginación para varias fuentes de datos

## Módulos principales

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Biblioteca central de paginación, proporciona interfaces básicas de paginación y una implementación abstracta.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
Módulo de soporte para fuentes de datos JDBC, ofrece una implementación de paginación basada en JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
Módulo de integración con MyBatis, proporciona soporte de integración con el framework MyBatis.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
Módulo de soporte para fuentes de datos MongoDB, ofrece una implementación de paginación basada en MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Módulo de soporte para fuentes de datos Elasticsearch, ofrece una implementación de paginación basada en ES.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Módulo de soporte de paginación para entornos Spring MVC, proporciona integración con Spring MVC, tan simple como escribir un controlador común.
- Enlace automático de parámetros de paginación
- Conversión automática de resultados de paginación

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Módulo de pruebas de paginación en entorno Spring Boot Web, proporciona pruebas de integración de la funcionalidad de paginación.


## Inicio rápido, usando uni-page-jdbc como ejemplo

### Dependencia Maven

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Ejemplo sencillo

```java
public class PaginationTest {
   
    public void page() {
        PaginationStatementTemplate operations = new PaginationStatementTemplate();
        operations.addStatementExecutor(new Sql2oPaginationNamedParameterStatementExecutor(dataSource));
        
        // 1. 创建分页语句
        PaginationStatement statement = of(b -> b
                .sql("SELECT * FROM user WHERE username LIKE :username")
                .paramMap("username", "%admin%")
                .pageable(0, 10)
                .sort("id", Sort.Direction.DESC));
        
        // 2. 执行查询
        PageInformation information = operations.queryForInformation(statement);
        Page<User> page = operations.queryForResultSet(statement, new JdbcBeanPropertyPaginationRowMapper<>(User.class));
    }

    // User实体类
    class User {
        private Long id;
        private String username;
        // getters and setters
    }
}
```
## Agradecimientos

Durante el desarrollo de este marco, he sido profundamente influenciado e inspirado por la comunidad de código abierto. Gracias a esos expertos que comparten desinteresadamente sus experiencias técnicas, es vuestra sabiduría y contribución lo que ha permitido el nacimiento de este marco. Un agradecimiento especial a los excelentes proyectos de código abierto que han aportado inspiración en el diseño y enfoques de implementación; estas valiosas experiencias me han permitido avanzar apoyándome en los hombros de gigantes.

¡Gracias a todos los expertos que contribuyen a la comunidad de código abierto!

## 🌟 Apoya el proyecto  
Si crees que este proyecto te ha sido útil, ¡te invito a hacer clic en la ⭐Star en la esquina superior derecha para apoyarme!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---