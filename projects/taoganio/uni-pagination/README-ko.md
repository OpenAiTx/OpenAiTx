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

# Uni-Pagination 페이징 프레임워크

Uni Pagination은 Java 기반의 범용 페이징 프레임워크로, 추상화된 설계를 통해 다양한 데이터 소스에 대해 통일된 페이징 쿼리 인터페이스를 제공합니다. 프레임워크는 모듈화 아키텍처를 채택하여 현재 JDBC, Mybatis, MongoDB, Elasticsearch 등 여러 데이터 소스를 통합하고 유연한 확장 메커니즘을 제공합니다.

## 핵심 설계

프레임워크의 핵심 설계는 네 가지 주요 컴포넌트를 중심으로 전개됩니다:


1. **페이징 문장(PaginationStatement)**
    - 모든 언어의 페이징 쿼리 문장 정의 지원
    - 통일된 페이징 파라미터 인터페이스 제공
    - 커스텀 페이징 로직 허용

2. **페이징 실행기(PaginationStatementExecutor)**
    - 페이징 쿼리 문장 실행 담당
    - 페이징 정보 조회 기능 제공
    - 확장 가능한 실행기 메커니즘

3. **페이징 결과 집합(PaginationResultSet)**
    - 통일된 결과 집합 인터페이스
    - 컬럼명 및 인덱스로 데이터 접근 지원
    - 타입 변환 기능 제공
    - JDBC ResultSet과 유사한 설계

4. **결과 집합 처리기(PaginationResultSetHandler)**
    - 커스텀 결과 집합 변환 지원
    - 객체 매핑 기능 제공


## 설계 목표

1. **통일성**
    - 통일된 페이징 쿼리 인터페이스 제공
    - 서로 다른 데이터 소스 구현 차이 감추기
    - 페이징 쿼리 사용 방식 단순화

2. **유연성**
    - 커스텀 페이징 문장 지원
    - 실행기 확장 허용
    - 풍부한 결과 집합 처리 방식 제공

3. **확장성**
    - 모듈화 설계
    - 신규 데이터 소스 빠른 접속 지원
    - 확장 포인트 메커니즘 제공

4. **사용 편의성**
    - 간단하고 직관적인 API
    - 완벽한 타입 변환
    - 풍부한 유틸리티 클래스 지원
## 적용 시나리오

- 여러 데이터 소스의 페이징 쿼리를 통합 관리해야 하는 프로젝트
- 다양한 데이터 소스 페이징을 지원해야 하는 엔터프라이즈 애플리케이션

## 핵심 모듈

### [uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination)
핵심 페이징 라이브러리로, 기본 페이징 인터페이스와 추상 구현을 제공.

### [uni-pagination-jdbc](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-jdbc)
JDBC 데이터 소스 지원 모듈로, JDBC 기반 페이징 구현 제공.

### [uni-pagination-jdbc-mybatis](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mybatis)
MyBatis 통합 모듈로, MyBatis 프레임워크와의 통합 지원 제공.

### [uni-pagination-mongodb](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mongodb)
MongoDB 통합 컴포넌트로, MongoDB 페이징 쿼리 지원.

### [spring-boot-starter-web-uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/spring-boot-starter-web-uni-pagination)
Spring MVC 환경에서의 페이징 지원 모듈로, Spring MVC와의 통합 지원을 제공하며 일반 컨트롤러 작성처럼 간단함.
- 페이징 파라미터 자동 바인딩
- 페이징 결과 자동 변환

### [web-uni-pagination-test](https://github.com/taoganio/uni-pagination/tree/main/web-uni-pagination-test)
Spring Boot Web 환경에서의 페이징 테스트 모듈로, 페이징 기능 통합 테스트 제공.


## 빠른 시작, uni-pagination-jdbc를 예로

### Maven 의존성

```xml
<dependency>
   <groupId>io.github.taoganio</groupId>
   <artifactId>uni-pagination-jdbc</artifactId>
   <version>1.0.0</version>
</dependency>
```

### 간단한 예제

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
## 감사의 말

이 프레임워크를 개발하는 과정에서 저는 오픈 소스 커뮤니티의 영향과 영감을 많이 받았습니다. 기술 경험을 아낌없이 공유해 주신 고수분들께 감사드리며, 여러분의 지혜와 기여 덕분에 이 프레임워크가 탄생할 수 있었습니다. 특히 뛰어난 오픈 소스 프로젝트들이 제공한 디자인 영감과 구현 아이디어에 특별히 감사드립니다. 이 소중한 경험 덕분에 거인의 어깨 위에 서서 계속 나아갈 수 있었습니다.

오픈 소스 커뮤니티에 기여한 모든 기술 고수분들께 감사드립니다!

## 🌟 프로젝트 지원
이 프로젝트가 도움이 되었다면, 우측 상단의 ⭐Star 를 클릭하여 저를 응원해 주세요!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-17

---