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

# Uni-Pagination 分頁フレームワーク

Uni Pagination は Java ベースの汎用ページネーションフレームワークであり、抽象化設計により異なるデータソースに統一されたページネーションクエリインターフェースを提供します。フレームワークはモジュール化アーキテクチャを採用し、現在 JDBC、Mybatis、MongoDB、Elasticsearch など複数のデータソースを統合し、柔軟な拡張機構も提供しています。

## コア設計

フレームワークのコア設計は4つの主要コンポーネントを中心に展開しています：


1. **分页文（PaginationStatement）**
    - 任意言語のページネーションクエリ文の定義をサポート
    - 統一されたページネーションパラメータインターフェースを提供
    - カスタムページネーションロジックを許可

2. **ページネーション実行器（PaginationStatementExecutor）**
    - ページネーションクエリ文の実行を担当
    - ページネーション情報の照会機能を提供
    - 拡張可能な実行器メカニズム

3. **ページネーション結果セット（PaginationResultSet）**
    - 統一された結果セットインターフェース
    - 列名およびインデックスによるデータアクセスをサポート
    - 型変換機能を提供
    - JDBC ResultSet に類似した設計

4. **結果セットハンドラ（PaginationResultSetHandler）**
    - カスタム結果セット変換をサポート
    - オブジェクトマッピング機能を提供


## 設計目標

1. **統一性**
    - 統一されたページネーションクエリインターフェースを提供
    - 異なるデータソースの実装差異を隠蔽
    - ページネーションクエリの使用方法を簡素化

2. **柔軟性**
    - カスタムページネーション文をサポート
    - 実行器の拡張を許可
    - 豊富な結果セット処理方法を提供

3. **拡張性**
    - モジュール化設計
    - 新データソースの迅速な接続をサポート
    - 拡張ポイントメカニズムを提供

4. **使いやすさ**
    - シンプルで直感的な API
    - 完璧な型変換
    - 豊富なユーティリティクラスのサポート
## 適用シーン

- 複数のデータソースのページングクエリを統一管理する必要があるプロジェクト
- 複数のデータソースのページングをサポートするエンタープライズアプリケーション

## コアモジュール

### [uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination)
コアページングライブラリで、基本的なページングインターフェースと抽象実装を提供。

### [uni-pagination-jdbc](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-jdbc)
JDBCデータソースサポートモジュールで、JDBCベースのページング実装を提供。

### [uni-pagination-jdbc-mybatis](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mybatis)
MyBatis統合モジュールで、MyBatisフレームワークとの統合サポートを提供。

### [uni-pagination-mongodb](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mongodb)
MongoDB統合コンポーネントで、MongoDBのページングクエリをサポート。

### [spring-boot-starter-web-uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/spring-boot-starter-web-uni-pagination)
Spring MVC環境下のページングサポートモジュールで、Spring MVCとの統合サポートを提供し、通常のコントローラーを作成するのと同じくらい簡単。
- ページングパラメータの自動バインド
- ページング結果の自動変換

### [web-uni-pagination-test](https://github.com/taoganio/uni-pagination/tree/main/web-uni-pagination-test)
Spring Boot Web環境下のページングテストモジュールで、ページング機能の統合テストを提供。


## クイックスタート、uni-pagination-jdbcを例に

### Maven依存関係

```xml
<dependency>
   <groupId>io.github.taoganio</groupId>
   <artifactId>uni-pagination-jdbc</artifactId>
   <version>1.0.0</version>
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

このフレームワークの開発過程で、私はオープンソースコミュニティから多大な影響とインスピレーションを受けました。技術経験を惜しみなく共有してくださった皆様に感謝します。皆様の知恵と貢献があってこそ、このフレームワークは誕生しました。特に、優れたオープンソースプロジェクトから得た設計のインスピレーションや実装のアイデアに感謝します。これら貴重な経験により、巨人の肩の上に立って前進し続けることができました。

オープンソースコミュニティに貢献するすべての技術者の皆様に感謝します！

## 🌟 プロジェクトを支援する
このプロジェクトが役立ったと感じたら、右上の⭐Starをクリックして応援してください！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-17

---