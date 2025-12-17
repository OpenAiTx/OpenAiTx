
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

# Uni-Pagination 分页框架

Uni Pagination 是一个基于 Java 的通用分页框架，它通过抽象化的设计，为不同数据源提供统一的分页查询接口。框架采用模块化架构，现目前集成 JDBC、Mybatis、MongoDB、Elasticsearch 等多种数据源，并提供了灵活的扩展机制。

## 核心设计

框架的核心设计围绕四个关键组件展开：

1. **分页语句（PaginationStatement）**
    - 支持任意语言的分页查询语句定义
    - 提供统一的分页参数接口
    - 允许自定义分页逻辑

2. **分页执行器（PaginationStatementExecutor）**
    - 负责执行分页查询语句
    - 提供分页信息查询功能
    - 可扩展的执行器机制

3. **分页结果集（PaginationResultSet）**
    - 统一的结果集接口
    - 支持按列名和索引访问数据
    - 提供类型转换功能
    - 类似 JDBC ResultSet 的设计

4. **结果集处理器（PaginationResultSetHandler）**
    - 支持自定义结果集转换
    - 提供对象映射功能


## 设计目标

1. **统一性**
    - 提供统一的分页查询接口
    - 屏蔽不同数据源的实现差异
    - 简化分页查询的使用方式

2. **灵活性**
    - 支持自定义分页语句
    - 允许扩展执行器
    - 提供丰富的结果集处理方式

3. **可扩展性**
    - 模块化设计
    - 支持新数据源的快速接入
    - 提供扩展点机制

4. **易用性**
    - 简单直观的 API
    - 完善的类型转换
    - 丰富的工具类支持
## 适用场景

- 需要统一管理多个数据源分页查询的项目
- 需要支持多种数据源分页的企业级应用

## 核心模块

### [uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination)
核心分页库，提供基础的分页接口和抽象实现。

### [uni-pagination-jdbc](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-jdbc)
JDBC 数据源支持模块，提供基于 JDBC 的分页实现。

### [uni-pagination-jdbc-mybatis](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mybatis)
MyBatis 集成模块，提供与 MyBatis 框架的集成支持。

### [uni-pagination-mongodb](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mongodb)
MongoDB 集成组件，用于支持 MongoDB 的分页查询。

### [spring-boot-starter-web-uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/spring-boot-starter-web-uni-pagination)
Spring MVC 环境下的分页支持模块，提供与 Spring MVC 的集成支持，就像编写普通的控制器一样简单。
- 分页参数自动绑定
- 分页结果自动转换

### [web-uni-pagination-test](https://github.com/taoganio/uni-pagination/tree/main/web-uni-pagination-test)
Spring Boot Web 环境下的分页测试模块，提供分页功能的集成测试。


## 快速开始, 以uni-pagination-jdbc为例

### Maven 依赖

```xml
<dependency>
   <groupId>io.github.taoganio</groupId>
   <artifactId>uni-pagination-jdbc</artifactId>
   <version>1.0.0</version>
</dependency>
```

### 简单示例

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


## 致谢

在开发这个框架的过程中，我深受开源社区的影响和启发。感谢那些无私分享技术经验的大佬们，是你们的智慧和贡献让这个框架得以诞生。特别感谢那些优秀开源项目带来的设计灵感和实现思路，这些宝贵的经验让我能够站在巨人的肩膀上继续前行。

感谢所有为开源社区做出贡献的技术大佬们！

## 🌟 支持项目
如果你觉得这个项目对你有帮助，欢迎点击右上角的 ⭐Star 支持我！
