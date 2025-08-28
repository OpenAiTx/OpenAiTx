
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

# Uni-Page Pagination Framework

Uni-Page is a general-purpose pagination framework based on Java. Through abstracted design, it provides a unified pagination query interface for different data sources. The framework adopts a modular architecture and currently integrates multiple data sources such as JDBC, Mybatis, MongoDB, and Elasticsearch, offering a flexible extension mechanism.

## Core Design

The core design of the framework revolves around four key components:

1. **PaginationStatement**
    - Supports pagination query statement definitions in any language
    - Provides a unified pagination parameter interface
    - Allows custom pagination logic

2. **PaginationStatementExecutor**
    - Responsible for executing pagination query statements
    - Provides pagination information query functionality
    - Extensible executor mechanism

3. **PaginationResultSet**
    - Unified result set interface
    - Supports accessing data by column name and index
    - Provides type conversion functionality
    - Design similar to JDBC ResultSet

4. **PaginationResultSetHandler**
    - Supports custom result set transformation
    - Provides object mapping functionality


## Design Objectives

1. **Uniformity**
    - Provides a unified pagination query interface
    - Shields implementation differences of various data sources
    - Simplifies the usage of pagination queries

2. **Flexibility**
    - Supports custom pagination statements
    - Allows executor extension
    - Provides a variety of result set handling methods

3. **Scalability**
    - Modular design
    - Supports quick access to new data sources
    - Provides extension point mechanism

4. **Ease of Use**
    - Simple and intuitive API
    - Complete type conversion
    - Rich utility class support
## Application Scenarios

- Projects that require unified management of pagination queries for multiple data sources
- Enterprise-level applications that need to support pagination for multiple data sources

## Core Modules

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Core pagination library, providing basic pagination interfaces and abstract implementations.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
JDBC data source support module, providing JDBC-based pagination implementation.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
MyBatis integration module, providing integration support with the MyBatis framework.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
MongoDB data source support module, providing MongoDB-based pagination implementation.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Elasticsearch data source support module, providing ES-based pagination implementation.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Pagination support module for Spring MVC environments, providing integration support with Spring MVC, making it as simple as writing a regular controller.
- Automatic pagination parameter binding
- Automatic pagination result conversion

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Pagination test module for Spring Boot Web environments, providing integrated tests for pagination functionality.


## Quick Start, using uni-page-jdbc as an example

### Maven Dependency

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
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

During the development of this framework, I was deeply influenced and inspired by the open-source community. Thanks to those experts who selflessly share their technical experiences; it is your wisdom and contributions that made this framework possible. Special thanks to the excellent open-source projects that provided design inspiration and implementation ideas; these valuable experiences have allowed me to stand on the shoulders of giants and keep moving forward.

Thanks to all the technical experts who contribute to the open-source community!

## 🌟 Support the Project
If you find this project helpful, please click the ⭐Star at the top right to support me!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---