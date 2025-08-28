
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# إطار Uni-Page للصفحات

Uni-Page هو إطار عمل عام للصفحات مبني على لغة Java، ويقدم واجهة موحدة لاستعلامات الصفحات لمصادر البيانات المختلفة من خلال تصميم تجريدي. يعتمد الإطار على بنية معيارية، وقد تم دمج JDBC وMybatis وMongoDB وElasticsearch وغيرها من مصادر البيانات المتعددة، كما يوفر آلية توسعة مرنة.

## التصميم الأساسي

يرتكز التصميم الأساسي للإطار على أربعة مكونات رئيسية:

1. **جملة التصفّح (PaginationStatement)**
    - دعم تعريف جمل التصفّح لأي لغة
    - توفير واجهة موحّدة لمعلمات التصفّح
    - السماح بتخصيص منطق التصفّح

2. **منفّذ جملة التصفّح (PaginationStatementExecutor)**
    - مسؤول عن تنفيذ جمل التصفّح
    - يوفر وظيفة استعلام معلومات التصفّح
    - آلية منفّذ قابلة للتوسعة

3. **مجموعة نتائج التصفّح (PaginationResultSet)**
    - واجهة موحّدة لمجموعة النتائج
    - دعم الوصول إلى البيانات حسب اسم العمود والفهرس
    - توفير وظيفة تحويل النوع
    - تصميم مشابه لـ JDBC ResultSet

4. **معالج مجموعة النتائج (PaginationResultSetHandler)**
    - دعم تحويل مجموعة النتائج المخصص
    - توفير وظيفة تحويل الكائنات


## أهداف التصميم

1. **التوحيد**
    - توفير واجهة موحّدة لاستعلامات التصفّح
    - إخفاء اختلافات التنفيذ بين مصادر البيانات المختلفة
    - تبسيط طريقة استخدام استعلامات التصفّح

2. **المرونة**
    - دعم جمل التصفّح المخصصة
    - السماح بتوسعة المنفّذ
    - تقديم طرق معالجة متنوعة لمجموعات النتائج

3. **قابلية التوسعة**
    - تصميم معياري
    - دعم الانضمام السريع لمصادر البيانات الجديدة
    - توفير آلية نقاط التوسعة

4. **سهولة الاستخدام**
    - واجهة برمجة تطبيقات بسيطة وواضحة
    - تحويل أنواع متكامل
    - دعم غني للأدوات المساعدة
## سيناريوهات الاستخدام

- المشاريع التي تحتاج إلى إدارة موحدة لاستعلامات التصفّح عبر مصادر بيانات متعددة
- التطبيقات المؤسسية التي تحتاج إلى دعم التصفح عبر مصادر بيانات متنوعة

## الوحدات الأساسية

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
مكتبة التصفح الأساسية، توفر واجهات التصفح الأساسية وتنفيذات مجردة.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
وحدة دعم مصدر بيانات JDBC، توفر تنفيذ التصفح المعتمد على JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
وحدة تكامل MyBatis، توفر دعم التكامل مع إطار عمل MyBatis.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
وحدة دعم مصدر بيانات MongoDB، توفر تنفيذ التصفح المعتمد على MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
وحدة دعم مصدر بيانات Elasticsearch، توفر تنفيذ التصفح المعتمد على ES.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
وحدة دعم التصفح في بيئة Spring MVC، توفر تكامل مع Spring MVC، مثل كتابة وحدة تحكم عادية ببساطة.
- ربط تلقائي لمعلمات التصفح
- تحويل تلقائي لنتائج التصفح

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
وحدة اختبار التصفح في بيئة Spring Boot Web، توفر اختبارات تكاملية لوظائف التصفح.


## بداية سريعة، باستخدام uni-page-jdbc كمثال

### اعتماد Maven

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### مثال بسيط

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
## الشكر والتقدير

خلال تطوير هذا الإطار، تأثرت كثيراً واستلهمت من مجتمع المصادر المفتوحة. أشكر أولئك الخبراء الذين يشاركون خبراتهم التقنية دون مقابل، فبفضل حكمتكم ومساهماتكم وُلد هذا الإطار. وأشكر بشكل خاص المشاريع المفتوحة المصدر الرائعة التي قدمت لي الإلهام في التصميم وأفكار التنفيذ، فهذه الخبرات الثمينة مكنتني من مواصلة المسير على أكتاف العمالقة.

شكراً لجميع الخبراء التقنيين الذين قدموا مساهمات لمجتمع المصادر المفتوحة!

## 🌟 دعم المشروع
إذا وجدت أن هذا المشروع مفيد لك، لا تتردد في الضغط على زر ⭐Star في الأعلى لدعمي!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---