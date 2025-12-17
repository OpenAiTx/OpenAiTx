
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=taoganio&project=uni-pagination&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# Uni-Pagination Framework de Paginación

Uni Pagination es un framework de paginación genérico basado en Java que, mediante un diseño abstracto, ofrece una interfaz unificada de consulta de paginación para diferentes fuentes de datos. El framework adopta una arquitectura modular, actualmente integrando múltiples fuentes de datos como JDBC, Mybatis, MongoDB, Elasticsearch, y proporciona un mecanismo flexible de extensión.

## Diseño Central

El diseño central del framework gira en torno a cuatro componentes clave:

1. **Declaración de Paginación (PaginationStatement)**  
    - Soporta la definición de sentencias de consulta paginadas en cualquier lenguaje  
    - Proporciona una interfaz unificada para parámetros de paginación  
    - Permite la lógica de paginación personalizada  

2. **Ejecutor de Declaración de Paginación (PaginationStatementExecutor)**  
    - Responsable de ejecutar sentencias de consulta paginadas  
    - Proporciona funcionalidad para consulta de información de paginación  
    - Mecanismo de ejecutor extensible  

3. **Conjunto de Resultados de Paginación (PaginationResultSet)**  
    - Interfaz unificada para conjuntos de resultados  
    - Soporta acceso a datos por nombre de columna e índice  
    - Proporciona funcionalidad de conversión de tipos  
    - Diseño similar a JDBC ResultSet  

4. **Procesador de Conjunto de Resultados (PaginationResultSetHandler)**  
    - Soporta conversión personalizada de conjuntos de resultados  
    - Proporciona funcionalidad de mapeo de objetos  


## Objetivos de Diseño  

1. **Uniformidad**  
    - Proporcionar una interfaz unificada para consultas paginadas  
    - Ocultar las diferencias de implementación entre distintas fuentes de datos  
    - Simplificar el uso de consultas paginadas  

2. **Flexibilidad**  
    - Soportar sentencias de paginación personalizadas  
    - Permitir la extensión del ejecutor  
    - Proporcionar diversas formas de procesamiento de conjuntos de resultados  

3. **Escalabilidad**  
    - Diseño modular  
    - Soportar la integración rápida de nuevas fuentes de datos  
    - Proporcionar mecanismos de puntos de extensión  

4. **Facilidad de uso**  
    - API simple e intuitiva
    - Conversión de tipos mejorada
    - Amplio soporte de clases utilitarias
## Escenarios de aplicación

- Proyectos que requieren gestionar de forma unificada la paginación de múltiples fuentes de datos
- Aplicaciones empresariales que necesitan soportar paginación en varias fuentes de datos

## Módulos principales

### [uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination)
Biblioteca principal de paginación, que proporciona interfaces básicas de paginación e implementaciones abstractas.

### [uni-pagination-jdbc](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-jdbc)
Módulo de soporte para fuentes de datos JDBC, que ofrece una implementación de paginación basada en JDBC.

### [uni-pagination-jdbc-mybatis](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mybatis)
Módulo de integración con MyBatis, que proporciona soporte para integración con el framework MyBatis.

### [uni-pagination-mongodb](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mongodb)
Componente de integración con MongoDB, usado para soportar consultas de paginación en MongoDB.

### [spring-boot-starter-web-uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/spring-boot-starter-web-uni-pagination)
Módulo de soporte para paginación en entornos Spring MVC, que ofrece integración con Spring MVC, tan sencillo como escribir un controlador normal.
- Enlace automático de parámetros de paginación
- Conversión automática de resultados de paginación

### [web-uni-pagination-test](https://github.com/taoganio/uni-pagination/tree/main/web-uni-pagination-test)
Módulo de pruebas de paginación para entornos Spring Boot Web, que proporciona pruebas de integración para funcionalidades de paginación.


## Inicio rápido, tomando uni-pagination-jdbc como ejemplo

### Dependencia Maven

```xml
<dependency>
   <groupId>io.github.taoganio</groupId>
   <artifactId>uni-pagination-jdbc</artifactId>
   <version>1.0.0</version>
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

Durante el desarrollo de este marco, me vi profundamente influenciado e inspirado por la comunidad de código abierto. Gracias a aquellos expertos que comparten desinteresadamente su experiencia técnica, es su sabiduría y contribución lo que ha permitido el nacimiento de este marco. Un agradecimiento especial a los excelentes proyectos de código abierto que aportaron inspiración en diseño y enfoques de implementación; estas valiosas experiencias me permiten avanzar sobre los hombros de gigantes.

¡Gracias a todos los expertos que contribuyen a la comunidad de código abierto!

## 🌟 Apoya el proyecto
Si crees que este proyecto te ha sido útil, ¡te invitamos a hacer clic en la ⭐Estrella en la esquina superior derecha para apoyarme!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-17

---