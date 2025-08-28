
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-CN">簡體中文</a>
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

# Uni-Page 分頁框架

Uni-Page 是一個基於 Java 的通用分頁框架，透過抽象化設計，為不同資料來源提供統一的分頁查詢介面。該框架採用模組化架構，目前已整合 JDBC、Mybatis、MongoDB、Elasticsearch 等多種資料來源，並且提供了彈性的擴充機制。

## 核心設計

框架的核心設計圍繞四個關鍵元件展開：

1. **分頁語句（PaginationStatement）**
    - 支援任意語言的分頁查詢語句定義
    - 提供統一的分頁參數介面
    - 允許自訂分頁邏輯

2. **分頁執行器（PaginationStatementExecutor）**
    - 負責執行分頁查詢語句
    - 提供分頁資訊查詢功能
    - 可擴展的執行器機制

3. **分頁結果集（PaginationResultSet）**
    - 統一的結果集介面
    - 支援依欄位名稱和索引存取資料
    - 提供型別轉換功能
    - 類似 JDBC ResultSet 的設計

4. **結果集處理器（PaginationResultSetHandler）**
    - 支援自訂結果集轉換
    - 提供物件映射功能


## 設計目標

1. **統一性**
    - 提供統一的分頁查詢介面
    - 隱蔽不同資料來源的實作差異
    - 簡化分頁查詢的使用方式

2. **靈活性**
    - 支援自訂分頁語句
    - 允許擴展執行器
    - 提供豐富的結果集處理方式

3. **可擴展性**
    - 模組化設計
    - 支援新資料來源的快速接入
    - 提供擴展點機制

4. **易用性**
    - 簡單直觀的 API
    - 完善的型別轉換
    - 豐富的工具類支援
## 適用場景

- 需要統一管理多個資料來源分頁查詢的專案
- 需要支援多種資料來源分頁的企業級應用

## 核心模組

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
核心分頁庫，提供基礎的分頁介面和抽象實現。

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
JDBC 資料來源支援模組，提供基於 JDBC 的分頁實現。

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
MyBatis 整合模組，提供與 MyBatis 框架的整合支援。
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
MongoDB 資料來源支援模組，提供基於 MongoDB 的分頁實現。

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Elasticsearch 資料來源支援模組，提供基於 ES 的分頁實現。

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Spring MVC 環境下的分頁支援模組，提供與 Spring MVC 的整合支援，就像編寫普通的控制器一樣簡單。
- 分頁參數自動綁定
- 分頁結果自動轉換

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Spring Boot Web 環境下的分頁測試模組，提供分頁功能的整合測試。


## 快速開始，以 uni-page-jdbc 為例

### Maven 依賴

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### 簡單範例

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


## 致謝

在開發這個框架的過程中，我深受開源社群的影響和啟發。感謝那些無私分享技術經驗的大佬們，是你們的智慧和貢獻讓這個框架得以誕生。特別感謝那些優秀開源項目帶來的設計靈感和實現思路，這些寶貴的經驗讓我能夠站在巨人的肩膀上繼續前行。

感謝所有為開源社群做出貢獻的技術大佬們！

## 🌟 支持專案
如果你覺得這個專案對你有幫助，歡迎點擊右上角的 ⭐Star 支持我！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---