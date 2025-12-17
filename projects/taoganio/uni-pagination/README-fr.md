
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

# Uni-Pagination cadre de pagination

Uni Pagination est un cadre de pagination universel basé sur Java, qui, grâce à une conception abstraite, offre une interface de requête de pagination unifiée pour différentes sources de données. Le cadre adopte une architecture modulaire, intégrant actuellement plusieurs sources de données telles que JDBC, Mybatis, MongoDB, Elasticsearch, et propose un mécanisme d’extension flexible.

## Conception principale

La conception principale du cadre s’articule autour de quatre composants clés :

1. **Instruction de pagination (PaginationStatement)**  
    - Supporte la définition d'instructions de requête de pagination pour n'importe quel langage  
    - Fournit une interface unifiée pour les paramètres de pagination  
    - Permet une logique de pagination personnalisée  

2. **Exécuteur d'instruction de pagination (PaginationStatementExecutor)**  
    - Responsable de l'exécution des instructions de requête de pagination  
    - Fournit une fonction de consultation des informations de pagination  
    - Mécanisme d'exécuteur extensible  

3. **Ensemble de résultats de pagination (PaginationResultSet)**  
    - Interface unifiée pour l'ensemble des résultats  
    - Supporte l'accès aux données par nom de colonne et index  
    - Offre une fonction de conversion de type  
    - Conception similaire à JDBC ResultSet  

4. **Gestionnaire d'ensemble de résultats (PaginationResultSetHandler)**  
    - Supporte la conversion personnalisée de l'ensemble des résultats  
    - Fournit une fonction de mapping d'objet  


## Objectifs de conception  

1. **Unification**  
    - Fournir une interface unifiée pour les requêtes de pagination  
    - Masquer les différences d'implémentation des différentes sources de données  
    - Simplifier l'utilisation des requêtes de pagination  

2. **Flexibilité**  
    - Supporter les instructions de pagination personnalisées  
    - Permettre l'extension des exécuteurs  
    - Fournir des méthodes riches de traitement des ensembles de résultats  

3. **Extensibilité**  
    - Conception modulaire  
    - Supporter l'intégration rapide de nouvelles sources de données  
    - Fournir un mécanisme de points d'extension  

4. **Facilité d'utilisation**  
    - API simple et intuitive
    - Conversion de type complète
    - Support riche des classes utilitaires
## Scénarios d'application

- Projets nécessitant une gestion unifiée des requêtes paginées sur plusieurs sources de données
- Applications d'entreprise nécessitant la prise en charge de la pagination sur plusieurs sources de données

## Modules principaux

### [uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination)
Bibliothèque de pagination principale, fournissant des interfaces de pagination de base et des implémentations abstraites.

### [uni-pagination-jdbc](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-jdbc)
Module de support des sources de données JDBC, fournissant une implémentation de pagination basée sur JDBC.

### [uni-pagination-jdbc-mybatis](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mybatis)
Module d'intégration MyBatis, offrant un support d'intégration avec le framework MyBatis.

### [uni-pagination-mongodb](https://github.com/taoganio/uni-pagination/tree/main/uni-pagination-mongodb)
Composant d'intégration MongoDB, destiné à supporter les requêtes paginées sur MongoDB.

### [spring-boot-starter-web-uni-pagination](https://github.com/taoganio/uni-pagination/tree/main/spring-boot-starter-web-uni-pagination)
Module de support de pagination dans l'environnement Spring MVC, offrant un support d'intégration avec Spring MVC, aussi simple que d'écrire un contrôleur classique.
- Liaison automatique des paramètres de pagination
- Conversion automatique des résultats de pagination

### [web-uni-pagination-test](https://github.com/taoganio/uni-pagination/tree/main/web-uni-pagination-test)
Module de test de pagination dans l'environnement Spring Boot Web, fournissant des tests d'intégration des fonctionnalités de pagination.


## Démarrage rapide, avec uni-pagination-jdbc en exemple

### Dépendance Maven

```xml
<dependency>
   <groupId>io.github.taoganio</groupId>
   <artifactId>uni-pagination-jdbc</artifactId>
   <version>1.0.0</version>
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

Lors du développement de ce cadre, j'ai été profondément influencé et inspiré par la communauté open source.  
Merci à tous les experts qui partagent généreusement leurs expériences techniques, c’est grâce à votre sagesse et vos contributions que ce cadre a pu voir le jour.  
Un remerciement particulier aux excellents projets open source qui ont apporté des inspirations de conception et des idées de mise en œuvre, ces expériences précieuses m’ont permis de continuer à avancer en m’appuyant sur les épaules des géants.  

Merci à tous les experts qui contribuent à la communauté open source !  

## 🌟 Soutenir le projet  
Si vous trouvez ce projet utile, n’hésitez pas à cliquer sur l’étoile ⭐ en haut à droite pour me soutenir !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-17

---