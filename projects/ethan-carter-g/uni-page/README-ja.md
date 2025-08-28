
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

# Uni-Page ページネーションフレームワーク

Uni-Page は Java ベースの汎用ページネーションフレームワークであり、抽象化設計により、異なるデータソースに対して統一されたページングクエリインターフェースを提供します。フレームワークはモジュール化アーキテクチャを採用し、現在 JDBC、Mybatis、MongoDB、Elasticsearch など様々なデータソースを統合しており、柔軟な拡張メカニズムも備えています。

## コア設計

フレームワークのコア設計は、4 つの主要コンポーネントを中心に展開されます：

1. **ページネーション文（PaginationStatement）**
    - 任意の言語によるページネーションクエリ文定義をサポート
    - 統一されたページネーションパラメータインターフェースを提供
    - カスタムページネーションロジックの定義を許可

2. **ページネーション実行器（PaginationStatementExecutor）**
    - ページネーションクエリ文の実行を担当
    - ページネーション情報の照会機能を提供
    - 拡張可能な実行器メカニズム

3. **ページネーション結果セット（PaginationResultSet）**
    - 統一された結果セットインターフェース
    - 列名やインデックスによるデータアクセスをサポート
    - 型変換機能を提供
    - JDBC ResultSet に似た設計

4. **結果セットハンドラ（PaginationResultSetHandler）**
    - カスタム結果セット変換をサポート
    - オブジェクトマッピング機能を提供


## 設計目標

1. **統一性**
    - 統一されたページネーションクエリインターフェースを提供
    - 異なるデータソースの実装差異を隠蔽
    - ページネーションクエリの利用方法を簡素化

2. **柔軟性**
    - カスタムページネーションクエリ文をサポート
    - 実行器の拡張を許可
    - 豊富な結果セット処理方式を提供

3. **拡張性**
    - モジュール化設計
    - 新しいデータソースの迅速な導入をサポート
    - 拡張ポイントメカニズムを提供

4. **使いやすさ**
    - シンプルで直感的な API
    - 完全な型変換機能
    - 豊富なユーティリティクラスのサポート
## 適用シーン

- 複数のデータソースのページングクエリを一元管理する必要があるプロジェクト
- 多様なデータソースのページングをサポートするエンタープライズ向けアプリケーション

## コアモジュール

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
コアページングライブラリであり、基本的なページングインターフェースと抽象実装を提供します。

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
JDBCデータソースサポートモジュールで、JDBCベースのページング実装を提供します。

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
MyBatis統合モジュールで、MyBatisフレームワークとの統合サポートを提供します。
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
MongoDBデータソースサポートモジュールで、MongoDBベースのページング実装を提供します。

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Elasticsearchデータソースサポートモジュールで、ESベースのページング実装を提供します。

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Spring MVC環境でのページングサポートモジュールで、Spring MVCとの統合サポートを提供し、通常のコントローラーのように簡単に記述できます。
- ページングパラメータの自動バインディング
- ページング結果の自動変換

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Spring Boot Web環境でのページングテストモジュールで、ページング機能の統合テストを提供します。


## クイックスタート：uni-page-jdbcを例に

### Maven依存

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```
### 簡単な例


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

このフレームワークの開発過程で、私はオープンソースコミュニティから多大な影響と啓発を受けました。技術経験を惜しみなく共有してくださった皆様に感謝します。皆様の知恵と貢献があってこそ、このフレームワークが誕生しました。特に優れたオープンソースプロジェクトがもたらした設計のインスピレーションと実装のアイデアに感謝します。これらの貴重な経験により、巨人の肩の上に立って前進し続けることができました。

オープンソースコミュニティに貢献するすべての技術者の皆様に感謝します！

## 🌟 プロジェクト支援
このプロジェクトが役に立ったと思われたら、右上の⭐Starをクリックして応援してください！




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---