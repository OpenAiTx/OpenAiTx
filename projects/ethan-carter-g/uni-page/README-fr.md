
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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

# Cadre de pagination Uni-Page

Uni-Page est un cadre de pagination universel basé sur Java, qui offre une interface unifiée de requête paginée pour différentes sources de données grâce à une conception abstraite. Le cadre adopte une architecture modulaire et intègre actuellement plusieurs sources de données telles que JDBC, Mybatis, MongoDB, Elasticsearch, tout en fournissant un mécanisme d’extension flexible.

## Conception centrale

La conception centrale du cadre s’articule autour de quatre composants clés :

1. **Instruction de pagination (PaginationStatement)**
    - Prise en charge de la définition de requêtes paginées dans n'importe quel langage
    - Fournit une interface unifiée pour les paramètres de pagination
    - Permet la personnalisation de la logique de pagination

2. **Exécuteur de pagination (PaginationStatementExecutor)**
    - Responsable de l'exécution des requêtes de pagination
    - Fournit une fonctionnalité de consultation des informations de pagination
    - Mécanisme d'exécuteur extensible

3. **Ensemble de résultats paginés (PaginationResultSet)**
    - Interface de résultats unifiée
    - Prise en charge de l'accès aux données par nom de colonne et par index
    - Offre une fonctionnalité de conversion de type
    - Conception similaire à JDBC ResultSet

4. **Gestionnaire de résultats paginés (PaginationResultSetHandler)**
    - Prise en charge de la conversion personnalisée des résultats
    - Fournit une fonctionnalité de mappage d'objets


## Objectifs de conception

1. **Uniformité**
    - Fournir une interface de requête paginée unifiée
    - Masquer les différences d'implémentation entre sources de données
    - Simplifier l'utilisation des requêtes paginées

2. **Flexibilité**
    - Prise en charge des instructions de pagination personnalisées
    - Permettre l'extension de l'exécuteur
    - Fournir des méthodes variées pour le traitement des résultats

3. **Extensibilité**
    - Conception modulaire
    - Prise en charge d'une intégration rapide de nouvelles sources de données
    - Fournit un mécanisme de points d'extension

4. **Facilité d'utilisation**
    - API simple et intuitive
    - Conversion de types complète
    - Prise en charge d'une riche collection de classes utilitaires
## Scénarios d'application

- Projets nécessitant une gestion unifiée de la pagination sur plusieurs sources de données
- Applications d'entreprise nécessitant la pagination sur divers types de sources de données

## Modules principaux

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Bibliothèque centrale de pagination, fournissant des interfaces de pagination de base et des implémentations abstraites.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
Module de prise en charge des sources de données JDBC, proposant une implémentation de la pagination basée sur JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
Module d'intégration MyBatis, offrant un support pour l'intégration avec le framework MyBatis.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
Module de prise en charge des sources de données MongoDB, proposant une implémentation de la pagination basée sur MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Module de prise en charge des sources de données Elasticsearch, proposant une pagination basée sur ES.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Module de prise en charge de la pagination dans les environnements Spring MVC, offrant une intégration transparente avec Spring MVC, aussi simple que d'écrire un contrôleur ordinaire.
- Liaison automatique des paramètres de pagination
- Conversion automatique des résultats paginés

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Module de test de la pagination dans l'environnement Spring Boot Web, fournissant des tests d'intégration pour la fonctionnalité de pagination.


## Démarrage rapide, exemple avec uni-page-jdbc

### Dépendance Maven

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Exemple simple

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
## Remerciements

Au cours du développement de ce cadre, j'ai été profondément influencé et inspiré par la communauté open source. Merci aux experts qui partagent généreusement leurs expériences techniques, c’est grâce à votre sagesse et vos contributions que ce cadre a pu voir le jour. Un merci tout particulier aux excellents projets open source qui ont apporté des inspirations de design et des idées de mise en œuvre, ces précieuses expériences me permettant de marcher sur les épaules des géants pour avancer.

Merci à tous les experts techniques qui contribuent à la communauté open source !

## 🌟 Soutenir le projet  
Si ce projet vous a été utile, n’hésitez pas à cliquer sur le ⭐Star en haut à droite pour me soutenir !




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---