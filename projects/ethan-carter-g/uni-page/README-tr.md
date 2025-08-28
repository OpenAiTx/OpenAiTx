
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

# Uni-Page Sayfalama Çerçevesi

Uni-Page, Java tabanlı bir genel sayfalama çerçevesidir ve farklı veri kaynakları için birleşik bir sayfa sorgulama arayüzü sunar. Çerçeve, modüler mimariyi benimser ve şu anda JDBC, Mybatis, MongoDB, Elasticsearch gibi çeşitli veri kaynaklarıyla entegredir; ayrıca esnek bir genişletme mekanizması sağlar.

## Temel Tasarım

Çerçevenin temel tasarımı dört ana bileşenin etrafında şekillenmiştir:

1. **Sayfalama İfadesi (PaginationStatement)**
    - Herhangi bir dilde sayfalama sorgusu tanımını destekler
    - Birleşik sayfalama parametreleri arayüzü sağlar
    - Özelleştirilmiş sayfalama mantığına izin verir

2. **Sayfalama Yürütücüsü (PaginationStatementExecutor)**
    - Sayfalama sorgularını yürütmekten sorumludur
    - Sayfalama bilgisi sorgulama fonksiyonu sağlar
    - Genişletilebilir yürütücü mekanizması

3. **Sayfalama Sonuç Kümesi (PaginationResultSet)**
    - Birleşik sonuç kümesi arayüzü
    - Sütun adı ve indeks ile veri erişimini destekler
    - Tip dönüştürme fonksiyonu sağlar
    - JDBC ResultSet’e benzer tasarım

4. **Sonuç Kümesi İşleyicisi (PaginationResultSetHandler)**
    - Özelleştirilmiş sonuç kümesi dönüşümünü destekler
    - Nesne eşleme fonksiyonu sağlar


## Tasarım Hedefleri

1. **Birlik**
    - Birleşik sayfalama sorgu arayüzü sağlar
    - Farklı veri kaynaklarının uygulama farklarını gizler
    - Sayfalama sorgusu kullanımını basitleştirir

2. **Esneklik**
    - Özelleştirilmiş sayfalama ifadelerini destekler
    - Yürütücünün genişletilmesine izin verir
    - Zengin sonuç kümesi işleme yöntemleri sağlar

3. **Genişletilebilirlik**
    - Modüler tasarım
    - Yeni veri kaynaklarının hızlı entegrasyonunu destekler
    - Genişletme noktası mekanizması sağlar

4. **Kullanım Kolaylığı**
    - Basit ve anlaşılır API
    - Gelişmiş tip dönüşümü
    - Zengin yardımcı sınıf desteği
## Uygun Kullanım Senaryoları

- Birden fazla veri kaynağının sayfalandırılmış sorgularının merkezi olarak yönetilmesi gereken projeler
- Birden çok veri kaynağının sayfalandırılmasını destekleyen kurumsal uygulamalar

## Temel Modüller

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Temel sayfalama kütüphanesi, temel sayfalama arayüzleri ve soyut uygulamalar sunar.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
JDBC veri kaynağı destek modülü, JDBC tabanlı sayfalama uygulamaları sağlar.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
MyBatis entegrasyon modülü, MyBatis çerçevesi ile entegrasyon desteği sağlar.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
MongoDB veri kaynağı destek modülü, MongoDB tabanlı sayfalama uygulamaları sağlar.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Elasticsearch veri kaynağı destek modülü, ES tabanlı sayfalama uygulamaları sağlar.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Spring MVC ortamında sayfalama destek modülü, Spring MVC ile entegrasyon desteği sunar; tıpkı sıradan bir kontrolör yazmak kadar kolay.
- Sayfalama parametreleri otomatik olarak bağlanır
- Sayfa sonuçları otomatik olarak dönüştürülür

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Spring Boot Web ortamında sayfalama test modülü, sayfalama işlevinin entegrasyon testini sağlar.


## Hızlı Başlangıç, uni-page-jdbc örneği ile

### Maven Bağımlılığı

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Basit Örnek

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


## Teşekkürler

Bu çerçeveyi geliştirirken, açık kaynak topluluğundan büyük ölçüde etkilendim ve ilham aldım. Teknik deneyimlerini özveriyle paylaşan tüm uzmanlara teşekkür ederim; sizin bilginiz ve katkılarınız sayesinde bu çerçeve ortaya çıkabildi. Özellikle, harika açık kaynak projelerinin sunduğu tasarım ilhamı ve uygulama fikirleri için minnettarım; bu değerli deneyimler sayesinde devlerin omuzlarında ilerleyebildim.

Açık kaynak topluluğuna katkı sağlayan tüm teknik uzmanlara teşekkürler!

## 🌟 Projeyi Destekle
Eğer bu projenin size faydalı olduğunu düşünüyorsanız, sağ üst köşedeki ⭐Star butonuna tıklayarak bana destek olabilirsiniz!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---