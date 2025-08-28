
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

# Uni-Page – uniwersalny framework stronicowania

Uni-Page to uniwersalny framework do stronicowania oparty na języku Java, który dzięki abstrakcyjnemu projektowi zapewnia jednolity interfejs zapytań stronicowanych dla różnych źródeł danych. Framework posiada architekturę modułową i obecnie integruje takie źródła jak JDBC, Mybatis, MongoDB, Elasticsearch, oferując jednocześnie elastyczny mechanizm rozszerzania.

## Kluczowe założenia projektowe

Rdzeń frameworka opiera się na czterech kluczowych komponentach:

1. **Instrukcja paginacji (PaginationStatement)**
    - Obsługuje definicję instrukcji paginacji w dowolnym języku
    - Zapewnia jednolity interfejs parametrów paginacji
    - Pozwala na definiowanie własnej logiki paginacji

2. **Egzekutor instrukcji paginacji (PaginationStatementExecutor)**
    - Odpowiada za wykonywanie instrukcji paginacji
    - Zapewnia funkcję pobierania informacji o paginacji
    - Rozszerzalny mechanizm egzekutora

3. **Zbiór wyników paginacji (PaginationResultSet)**
    - Jednolity interfejs zbioru wyników
    - Obsługuje dostęp do danych według nazwy kolumny i indeksu
    - Zapewnia funkcjonalność konwersji typów
    - Projekt podobny do JDBC ResultSet

4. **Handler zbioru wyników (PaginationResultSetHandler)**
    - Obsługuje własne przekształcanie zbioru wyników
    - Zapewnia funkcję mapowania obiektów


## Cele projektowe

1. **Jednolitość**
    - Zapewnia jednolity interfejs paginacji
    - Ukrywa różnice implementacji różnych źródeł danych
    - Upraszcza sposób użycia paginacji

2. **Elastyczność**
    - Obsługuje definiowanie własnych instrukcji paginacji
    - Pozwala na rozszerzanie egzekutora
    - Zapewnia bogate metody obsługi zbiorów wyników

3. **Rozszerzalność**
    - Projekt modułowy
    - Umożliwia szybkie podłączenie nowych źródeł danych
    - Zapewnia mechanizm punktów rozszerzeń

4. **Łatwość użycia**
    - Prosty i intuicyjny interfejs API
    - Zaawansowana konwersja typów
    - Bogate wsparcie dla klas narzędziowych
## Zastosowanie

- Projekty wymagające jednolitego zarządzania paginacją dla wielu źródeł danych
- Aplikacje korporacyjne wymagające wsparcia paginacji dla różnych źródeł danych

## Moduły podstawowe

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Podstawowa biblioteka paginacji, zapewniająca podstawowe interfejsy i abstrakcyjne implementacje paginacji.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
Moduł wsparcia dla źródeł danych JDBC, oferujący implementację paginacji opartą na JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
Moduł integracji z MyBatis, zapewniający wsparcie dla integracji z frameworkiem MyBatis.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
Moduł wsparcia dla źródeł danych MongoDB, oferujący implementację paginacji opartą na MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Moduł wsparcia dla źródeł danych Elasticsearch, oferujący implementację paginacji opartą na ES.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Moduł wsparcia paginacji w środowisku Spring MVC, zapewniający integrację ze Spring MVC – tak łatwą jak pisanie zwykłego kontrolera.
- Automatyczne wiązanie parametrów paginacji
- Automatyczna konwersja wyników paginacji

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Moduł testowy paginacji w środowisku Spring Boot Web, oferujący testy integracyjne funkcjonalności paginacji.


## Szybki start, na przykładzie uni-page-jdbc

### Zależności Maven

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Prosty przykład

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


## Podziękowania

Podczas opracowywania tego frameworka czerpałem ogromną inspirację z społeczności open source. Dziękuję wszystkim ekspertom, którzy bezinteresownie dzielą się swoją wiedzą techniczną — to właśnie wasza mądrość i wkład pozwoliły powstać temu frameworkowi. Szczególne podziękowania należą się świetnym projektom open source, które dostarczyły inspiracji projektowych i pomysłów na realizację; te cenne doświadczenia pozwoliły mi iść dalej, stojąc na ramionach gigantów.

Dziękuję wszystkim specjalistom, którzy przyczyniają się do rozwoju społeczności open source!

## 🌟 Wsparcie projektu
Jeśli uważasz, że ten projekt jest dla Ciebie pomocny, zapraszam do kliknięcia ⭐Star w prawym górnym rogu, by mnie wesprzeć!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---