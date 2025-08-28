
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

# Uni-Page Framework di Paginazione

Uni-Page è un framework di paginazione universale basato su Java che, grazie a un design astratto, fornisce un'interfaccia unificata per le query di paginazione su diverse fonti di dati. Il framework adotta un'architettura modulare e attualmente integra JDBC, Mybatis, MongoDB, Elasticsearch e molte altre fonti di dati, offrendo inoltre meccanismi di estensione flessibili.

## Progettazione Core

Il design centrale del framework ruota attorno a quattro componenti chiave:

1. **Istruzione di Paginazione (PaginationStatement)**
    - Supporta la definizione di istruzioni di paginazione per qualsiasi linguaggio
    - Fornisce un’interfaccia unificata per i parametri di paginazione
    - Consente la logica di paginazione personalizzata

2. **Esecutore di Istruzione di Paginazione (PaginationStatementExecutor)**
    - Responsabile dell’esecuzione delle istruzioni di paginazione
    - Fornisce funzionalità di interrogazione delle informazioni di paginazione
    - Meccanismo di esecutore estensibile

3. **Set di Risultati di Paginazione (PaginationResultSet)**
    - Interfaccia unificata per il set di risultati
    - Supporta l’accesso ai dati per nome colonna e indice
    - Fornisce funzionalità di conversione dei tipi
    - Design simile a JDBC ResultSet

4. **Gestore del Set di Risultati di Paginazione (PaginationResultSetHandler)**
    - Supporta la conversione personalizzata del set di risultati
    - Fornisce funzionalità di mapping degli oggetti


## Obiettivi di progettazione

1. **Unificazione**
    - Fornire un’interfaccia unificata per le query di paginazione
    - Nascondere le differenze di implementazione tra le diverse fonti dati
    - Semplificare il modo d’uso delle query di paginazione

2. **Flessibilità**
    - Supporta istruzioni di paginazione personalizzate
    - Consente di estendere l’esecutore
    - Offre metodi ricchi di gestione del set di risultati

3. **Estendibilità**
    - Design modulare
    - Supporta l’integrazione rapida di nuove fonti dati
    - Fornisce un meccanismo di punti di estensione

4. **Facilità d’uso**
    - API semplice e intuitiva
    - Conversione dei tipi completa
    - Ricco supporto di classi di utilità
## Scenari di applicazione

- Progetti che richiedono la gestione unificata della paginazione su più sorgenti dati
- Applicazioni enterprise che necessitano il supporto della paginazione su diversi tipi di sorgenti dati

## Moduli principali

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Libreria core per la paginazione, fornisce interfacce di base e implementazioni astratte per la paginazione.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
Modulo di supporto per sorgenti dati JDBC, fornisce un'implementazione della paginazione basata su JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
Modulo di integrazione MyBatis, fornisce il supporto all'integrazione con il framework MyBatis.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
Modulo di supporto per sorgenti dati MongoDB, fornisce un'implementazione della paginazione basata su MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Modulo di supporto per sorgenti dati Elasticsearch, fornisce un'implementazione della paginazione basata su ES.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Modulo di supporto alla paginazione in ambiente Spring MVC, offre integrazione con Spring MVC, rendendo la scrittura dei controller semplice come per i controller normali.
- Binding automatico dei parametri di paginazione
- Conversione automatica dei risultati della paginazione

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Modulo di test per la paginazione in ambiente Spring Boot Web, fornisce test di integrazione per le funzionalità di paginazione.


## Guida rapida, prendendo uni-page-jdbc come esempio

### Dipendenza Maven

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Esempio semplice

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


## Ringraziamenti

Durante lo sviluppo di questo framework, sono stato profondamente influenzato e ispirato dalla comunità open source. Grazie a tutti coloro che hanno condiviso generosamente la propria esperienza tecnica: è grazie alla vostra saggezza e ai vostri contributi che questo framework ha potuto vedere la luce. Un ringraziamento speciale ai progetti open source eccellenti che hanno offerto ispirazione per il design e soluzioni tecniche: queste preziose esperienze mi hanno permesso di proseguire sulle spalle dei giganti.

Grazie a tutti i grandi tecnici che contribuiscono alla comunità open source!

## 🌟 Supporta il progetto
Se pensi che questo progetto ti sia stato utile, ti invito a cliccare sulla ⭐Star in alto a destra per supportarmi!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---