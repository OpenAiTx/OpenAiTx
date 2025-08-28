
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

# Uni-Page Фреймворк пагинации

Uni-Page — это универсальный фреймворк пагинации на основе Java, который благодаря абстрактному дизайну предоставляет единый интерфейс для постраничного запроса к различным источникам данных. Фреймворк использует модульную архитектуру и в настоящее время интегрирует такие источники данных, как JDBC, Mybatis, MongoDB, Elasticsearch, а также предлагает гибкий механизм расширения.

## Основной дизайн

Основной дизайн фреймворка строится вокруг четырех ключевых компонентов:

1. **Постраничный оператор (PaginationStatement)**
    - Поддержка определения постраничных запросов на любом языке
    - Предоставление единого интерфейса для параметров пагинации
    - Возможность настройки логики пагинации

2. **Исполнитель постраничных операторов (PaginationStatementExecutor)**
    - Отвечает за выполнение постраничных запросов
    - Предоставляет функционал запроса информации о пагинации
    - Расширяемый механизм исполнителя

3. **Постраничный результирующий набор (PaginationResultSet)**
    - Единый интерфейс для работы с результатами
    - Поддержка доступа к данным по имени столбца и индексу
    - Предоставление функции преобразования типов
    - Дизайн, аналогичный JDBC ResultSet

4. **Обработчик результирующего набора (PaginationResultSetHandler)**
    - Поддержка пользовательского преобразования результатов
    - Предоставление функционала отображения объектов


## Цели проектирования

1. **Унификация**
    - Предоставление единого интерфейса для постраничных запросов
    - Сокрытие различий в реализациях разных источников данных
    - Упрощение способа использования постраничных запросов

2. **Гибкость**
    - Поддержка пользовательских операторов пагинации
    - Возможность расширения исполнителя
    - Предоставление разнообразных способов обработки результирующего набора

3. **Масштабируемость**
    - Модульный дизайн
    - Быстрое подключение новых источников данных
    - Механизм точек расширения

4. **Простота использования**
    - Простой и понятный API
    - Совершенное преобразование типов
    - Широкая поддержка утилитарных классов
## Сценарии применения

- Проекты, требующие единого управления постраничным запросом с нескольких источников данных
- Корпоративные приложения, поддерживающие пагинацию для различных источников данных

## Основные модули

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Основная библиотека пагинации, предоставляющая базовые интерфейсы и абстрактные реализации для пагинации.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
Модуль поддержки источников данных JDBC, реализующий пагинацию на основе JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
Модуль интеграции с MyBatis, обеспечивающий поддержку работы с фреймворком MyBatis.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
Модуль поддержки источников данных MongoDB, реализующий пагинацию на основе MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Модуль поддержки источников данных Elasticsearch, реализующий пагинацию на основе Elasticsearch.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Модуль поддержки пагинации в среде Spring MVC, обеспечивающий интеграцию со Spring MVC, так же просто, как написание обычного контроллера.
- Автоматическая привязка параметров пагинации
- Автоматическое преобразование результатов пагинации

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Модуль тестирования пагинации в среде Spring Boot Web, предоставляющий интеграционные тесты функционала пагинации.


## Быстрый старт, пример на uni-page-jdbc

### Зависимость Maven

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Простой пример

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


## Благодарности

В процессе разработки этого фреймворка я был сильно вдохновлен и поддержан сообществом с открытым исходным кодом. Благодарю тех, кто бескорыстно делился техническим опытом — именно ваша мудрость и вклад позволили появиться этому фреймворку. Особенно признателен выдающимся проектам с открытым исходным кодом за вдохновение в дизайне и реализации, эти ценные знания позволили мне двигаться вперед, стоя на плечах гигантов.

Благодарю всех технических специалистов, внесших вклад в сообщество open source!

## 🌟 Поддержите проект
Если этот проект оказался для вас полезным, буду благодарен за ⭐Star в правом верхнем углу!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---