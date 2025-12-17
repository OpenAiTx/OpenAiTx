
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

# Uni-Pagination Pagination Framework

Uni Pagination is a Java-based universal pagination framework that provides a unified pagination query interface for different data sources through an abstracted design. The framework adopts a modular architecture and currently integrates various data sources such as JDBC, Mybatis, MongoDB, Elasticsearch, and offers a flexible extension mechanism.

## Core Design

The core design of the framework revolves around four key components:

1. **PaginationStatement**
    - Supports pagination query statement definitions for any language
    - Provides a unified pagination parameter interface
    - Allows custom pagination logic

2. **PaginationStatementExecutor**
    - Responsible for executing pagination query statements
    - Provides pagination information query functionality
    - Extensible executor mechanism

3. **PaginationResultSet**
    - Unified result set interface
    - Supports data access by column name and index
    - Provides type conversion functionality
    - Designed similarly to JDBC ResultSet

4. **PaginationResultSetHandler**
    - Supports custom result set transformations
    - Provides object mapping capabilities


## Design Goals

1. **Uniformity**
    - Provides a unified pagination query interface
    - Shields implementation differences of different data sources
    - Simplifies the usage of pagination queries

2. **Flexibility**
    - Supports custom pagination statements
    - Allows executor extensions
    - Provides rich result set handling methods

3. **Extensibility**
    - Modular design
    - Supports rapid integration of new data sources
    - Provides extension points mechanism

4. **Ease of Use**
    - Simple and intuitive API
    - Complete type conversion
    - Rich utility class support
## Applicable Scenarios

- Projects that need unified management of multiple data source pagination queries
- Enterprise applications that require support for multiple data source pagination

## Core Modules

### [uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination)
Core pagination library, providing basic pagination interfaces and abstract implementations.

### [uni-pagination-jdbc](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-jdbc)
JDBC data source support module, providing JDBC-based pagination implementation.

### [uni-pagination-jdbc-mybatis](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mybatis)
MyBatis integration module, providing integration support with the MyBatis framework.

### [uni-pagination-mongodb](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mongodb)
MongoDB integration component, used to support pagination queries for MongoDB.

### [spring-boot-starter-web-uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/spring-boot-starter-web-uni-pagination)
Pagination support module under Spring MVC environment, providing integration support with Spring MVC, as simple as writing ordinary controllers.
- Automatic binding of pagination parameters
- Automatic conversion of pagination results

### [web-uni-pagination-test](https://github.com/taoganio/uni-pagination/tree/main/web-uni-pagination-test)
Pagination test module under Spring Boot Web environment, providing integration tests for pagination functionality.


## Quick Start, using uni-pagination-jdbc as an example

### Maven Dependency

```xml
<dependency>
   <groupId>io.github.taoganio</groupId>
   <artifactId>uni-pagination-jdbc</artifactId>
   <version>1.0.0</version>
</dependency>
```

### Simple Example

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


## Acknowledgments

During the development of this framework, I was deeply influenced and inspired by the open-source community. Thanks to those experts who selflessly share their technical experience; it is your wisdom and contributions that made this framework possible. Special thanks to the excellent open-source projects that provided design inspiration and implementation ideas; these valuable experiences allow me to stand on the shoulders of giants and keep moving forward.

Thanks to all the technical experts who have contributed to the open-source community!

## 🌟 Support the Project
If you find this project helpful, please click the ⭐Star at the top right to support me!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-17

---