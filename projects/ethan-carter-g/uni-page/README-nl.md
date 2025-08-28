
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Uni-Page Paginatie Framework

Uni-Page is een algemeen paginatieframework gebaseerd op Java, dat via een abstract ontwerp een uniforme paginatie-queryinterface biedt voor verschillende databronnen. Het framework gebruikt een modulaire architectuur en integreert momenteel meerdere databronnen zoals JDBC, Mybatis, MongoDB, Elasticsearch, en biedt een flexibele uitbreidingsmechanisme.

## Kernontwerp

Het kernontwerp van het framework draait om vier sleutelcomponenten:

1. **Paginatie-instructie (PaginationStatement)**
    - Ondersteunt paginatie-querydefinities in elke taal
    - Biedt een uniforme interface voor paginatieparameters
    - Staat aangepaste paginatielogica toe

2. **Paginatie-uitvoerder (PaginationStatementExecutor)**
    - Verantwoordelijk voor het uitvoeren van paginatie-query's
    - Biedt functie voor het opvragen van paginatie-informatie
    - Uitbreidbaar uitvoerdersmechanisme

3. **Paginatieresultaatset (PaginationResultSet)**
    - Uniforme resultaatsetinterface
    - Ondersteunt toegang tot data via kolomnaam en index
    - Biedt typeconversiefunctie
    - Ontwerp vergelijkbaar met JDBC ResultSet

4. **Resultaatsetverwerker (PaginationResultSetHandler)**
    - Ondersteunt aangepaste resultaatsetconversie
    - Biedt objectmappingfunctie


## Ontwerpdoelen

1. **Uniformiteit**
    - Biedt een uniforme paginatie-queryinterface
    - Verbergt implementatieverschillen tussen verschillende gegevensbronnen
    - Vereenvoudigt het gebruik van paginatie-query's

2. **Flexibiliteit**
    - Ondersteunt aangepaste paginatie-instructies
    - Staat uitbreiding van uitvoerders toe
    - Biedt uitgebreide verwerkingsmethoden voor resultaatsets

3. **Uitbreidbaarheid**
    - Modulair ontwerp
    - Ondersteunt snelle integratie van nieuwe gegevensbronnen
    - Biedt uitbreidingsmechanisme

4. **Gebruiksgemak**
    - Eenvoudige en intuïtieve API
    - Volledige typeconversie
    - Uitgebreide ondersteuning voor hulpprogrammaclasses
## Toepassingsscenario's

- Projecten die uniforme beheer van paginagegevens uit meerdere gegevensbronnen vereisen
- Enterprise-applicaties die paginering van meerdere gegevensbronnen moeten ondersteunen

## Kernmodules

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Kernpaginabibliotheek, biedt basisinterface en abstracte implementatie voor paginering.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
JDBC-gegevensbronomodule, biedt een pagineringsimplementatie op basis van JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
MyBatis-integratiemodule, biedt ondersteuning voor integratie met het MyBatis-framework.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
MongoDB-gegevensbronomodule, biedt een pagineringsimplementatie op basis van MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Elasticsearch-gegevensbronomodule, biedt een pagineringsimplementatie op basis van ES.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Paginamodule voor Spring MVC-omgeving, biedt integratie met Spring MVC, net zo eenvoudig als het schrijven van een gewone controller.
- Automatische binding van paginaparameters
- Automatische conversie van pagineresultaten

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Pagineringstestmodule voor Spring Boot Web-omgeving, biedt integratietests voor pagineringsfunctionaliteit.


## Snel starten, voorbeeld met uni-page-jdbc

### Maven-afhankelijkheid

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Eenvoudig voorbeeld

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


## Dankwoord

Tijdens de ontwikkeling van dit framework ben ik sterk beïnvloed en geïnspireerd door de open source gemeenschap. Dank aan de experts die hun technische ervaring onbaatzuchtig delen; het is dankzij jullie wijsheid en bijdragen dat dit framework tot stand kon komen. In het bijzonder dank aan de uitstekende open source projecten die ontwerpinspiratie en implementatie-ideeën hebben gebracht; deze waardevolle ervaringen stellen mij in staat om verder te bouwen op de schouders van reuzen.

Dank aan alle technische experts die bijdragen leveren aan de open source gemeenschap!

## 🌟 Project ondersteunen
Als je vindt dat dit project je heeft geholpen, klik dan rechtsboven op ⭐Star om mij te steunen!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---