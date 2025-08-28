
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Uni-Page Paging-Framework

Uni-Page ist ein allgemeines Paging-Framework auf Basis von Java, das durch ein abstrahiertes Design eine einheitliche Schnittstelle für die Paginierung unterschiedlicher Datenquellen bereitstellt. Das Framework verwendet eine modulare Architektur und integriert derzeit verschiedene Datenquellen wie JDBC, Mybatis, MongoDB und Elasticsearch. Es bietet zudem einen flexiblen Erweiterungsmechanismus.

## Kerndesign

Das Kerndesign des Frameworks konzentriert sich auf vier Schlüsselkomponenten:

1. **Paging-Anweisung (PaginationStatement)**
    - Unterstützt die Definition von Paging-Abfrageanweisungen in beliebigen Sprachen
    - Bietet einheitliche Schnittstellen für Paging-Parameter
    - Erlaubt benutzerdefinierte Paging-Logik

2. **Paging-Ausführer (PaginationStatementExecutor)**
    - Verantwortlich für die Ausführung von Paging-Abfragen
    - Bietet Funktion zur Abfrage von Paging-Informationen
    - Erweiterbarer Ausführungsmechanismus

3. **Paging-Ergebnismenge (PaginationResultSet)**
    - Einheitliche Ergebnismengen-Schnittstelle
    - Unterstützt Datenzugriff nach Spaltenname und Index
    - Bietet Typkonvertierungsfunktion
    - Design ähnlich wie JDBC ResultSet

4. **Ergebnismengen-Handler (PaginationResultSetHandler)**
    - Unterstützt benutzerdefinierte Ergebnismengen-Konvertierung
    - Bietet Objekt-Mapping-Funktion


## Designziele

1. **Einheitlichkeit**
    - Bietet einheitliche Schnittstelle für Paging-Abfragen
    - Verschleiert Implementierungsunterschiede verschiedener Datenquellen
    - Vereinfacht die Nutzung von Paging-Abfragen

2. **Flexibilität**
    - Unterstützt benutzerdefinierte Paging-Anweisungen
    - Erlaubt Erweiterung des Ausführers
    - Bietet vielfältige Möglichkeiten zur Ergebnismengen-Verarbeitung

3. **Erweiterbarkeit**
    - Modularer Aufbau
    - Schnelle Einbindung neuer Datenquellen möglich
    - Bietet Erweiterungspunkte

4. **Benutzerfreundlichkeit**
    - Einfaches und intuitives API
    - Vollständige Typkonvertierung
    - Umfangreiche Unterstützung durch Hilfsklassen
## Anwendungsbereiche

- Projekte, die eine einheitliche Verwaltung von Seitenabfragen über mehrere Datenquellen benötigen
- Unternehmensanwendungen, die die Paginierung für verschiedene Datenquellen unterstützen müssen

## Kernmodule

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Kern-Paginierungsbibliothek, bietet grundlegende Paginierungsschnittstellen und abstrakte Implementierungen.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
JDBC-Datenquellen-Unterstützungsmodul, bietet eine auf JDBC basierende Paginierungsimplementierung.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
MyBatis-Integrationsmodul, bietet Unterstützung für die Integration in das MyBatis-Framework.

### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
MongoDB-Datenquellen-Unterstützungsmodul, bietet eine auf MongoDB basierende Paginierungsimplementierung.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Elasticsearch-Datenquellen-Unterstützungsmodul, bietet eine auf ES basierende Paginierungsimplementierung.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Paginierungsunterstützungsmodul für Spring MVC-Umgebungen, bietet Integration mit Spring MVC und ist so einfach wie das Schreiben eines normalen Controllers.
- Automatische Bindung der Paginierungsparameter
- Automatische Umwandlung der Paginierungsergebnisse

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Paginierungstestmodul für Spring Boot Web-Umgebungen, bietet Integrationstests für die Paginierungsfunktion.

## Schnellstart am Beispiel von uni-page-jdbc

### Maven-Abhängigkeiten


```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Einfaches Beispiel

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


## Danksagung

Während der Entwicklung dieses Frameworks wurde ich stark von der Open-Source-Community beeinflusst und inspiriert. Ich danke all den Experten, die ihre technischen Erfahrungen selbstlos geteilt haben – eure Weisheit und Beiträge haben die Entstehung dieses Frameworks ermöglicht. Besonderer Dank gilt den hervorragenden Open-Source-Projekten für ihre Design-Inspirationen und Implementierungsansätze; diese wertvollen Erfahrungen erlauben es mir, auf den Schultern von Giganten weiterzugehen.

Danke an alle Technik-Experten, die zur Open-Source-Community beigetragen haben!

## 🌟 Projekt unterstützen
Wenn dir dieses Projekt geholfen hat, klicke gerne oben rechts auf ⭐Star, um mich zu unterstützen!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---