
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# چارچوب صفحه‌بندی Uni-Page

Uni-Page یک چارچوب صفحه‌بندی عمومی مبتنی بر Java است که با طراحی انتزاعی، واسط یکپارچه‌ای برای پرس‌وجوی صفحه‌بندی داده‌ها از منابع مختلف ارائه می‌دهد. این چارچوب دارای معماری ماژولار بوده و تاکنون از منابع داده‌ای متعددی مانند JDBC، Mybatis، MongoDB، Elasticsearch پشتیبانی می‌کند و همچنین مکانیسم توسعه‌پذیری انعطاف‌پذیری را فراهم می‌سازد.

## طراحی اصلی

هسته طراحی این چارچوب حول چهار مؤلفه کلیدی متمرکز شده است:

1. **عبارت صفحه‌بندی (PaginationStatement)**
    - پشتیبانی از تعریف عبارت صفحه‌بندی برای هر زبان
    - ارائه رابط یکپارچه پارامترهای صفحه‌بندی
    - امکان سفارشی‌سازی منطق صفحه‌بندی

2. **اجراکننده صفحه‌بندی (PaginationStatementExecutor)**
    - مسئول اجرای عبارت صفحه‌بندی
    - ارائه قابلیت جستجو اطلاعات صفحه‌بندی
    - مکانیزم اجراکننده قابل توسعه

3. **مجموعه نتایج صفحه‌بندی (PaginationResultSet)**
    - رابط یکپارچه مجموعه نتایج
    - پشتیبانی از دسترسی به داده‌ها براساس نام ستون و اندیس
    - ارائه قابلیت تبدیل نوع داده
    - طراحی مشابه JDBC ResultSet

4. **پردازشگر مجموعه نتایج (PaginationResultSetHandler)**
    - پشتیبانی از تبدیل سفارشی مجموعه نتایج
    - ارائه قابلیت نگاشت شیء


## اهداف طراحی

1. **یکپارچگی**
    - ارائه رابط یکپارچه برای صفحه‌بندی
    - پوشش تفاوت‌های پیاده‌سازی منابع داده مختلف
    - ساده‌سازی روش استفاده از صفحه‌بندی

2. **انعطاف‌پذیری**
    - پشتیبانی از عبارات صفحه‌بندی سفارشی
    - امکان توسعه اجراکننده‌ها
    - ارائه روش‌های متنوع پردازش مجموعه نتایج

3. **قابلیت توسعه**
    - طراحی ماژولار
    - پشتیبانی از اتصال سریع منابع داده جدید
    - ارائه مکانیزم نقاط توسعه

4. **سهولت استفاده**
    - API ساده و قابل فهم
    - تبدیل نوع کامل و بی‌نقص
    - پشتیبانی از کلاس‌های ابزار غنی
## سناریوهای کاربرد

- پروژه‌هایی که نیاز به مدیریت یکپارچه جستجوی صفحه‌ای چندین منبع داده دارند
- برنامه‌های سازمانی که نیاز به پشتیبانی از صفحه‌بندی چند منبع داده دارند

## ماژول‌های اصلی

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
هسته کتابخانه صفحه‌بندی، ارائه‌دهنده رابط پایه صفحه‌بندی و پیاده‌سازی انتزاعی.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
ماژول پشتیبانی از منبع داده JDBC، ارائه‌دهنده پیاده‌سازی صفحه‌بندی مبتنی بر JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
ماژول یکپارچه‌سازی MyBatis، ارائه‌دهنده پشتیبانی از یکپارچه‌سازی با فریمورک MyBatis.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
ماژول پشتیبانی از منبع داده MongoDB، ارائه‌دهنده پیاده‌سازی صفحه‌بندی مبتنی بر MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
ماژول پشتیبانی از منبع داده Elasticsearch، ارائه‌دهنده پیاده‌سازی صفحه‌بندی مبتنی بر ES.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
ماژول پشتیبانی از صفحه‌بندی در محیط Spring MVC، ارائه‌دهنده یکپارچه‌سازی با Spring MVC، به سادگی نوشتن یک کنترلر عادی.
- اتصال خودکار پارامترهای صفحه‌بندی
- تبدیل خودکار نتایج صفحه‌بندی

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
ماژول تست صفحه‌بندی در محیط Spring Boot Web، ارائه‌دهنده تست یکپارچه عملکرد صفحه‌بندی.


## شروع سریع، به عنوان مثال uni-page-jdbc

### وابستگی Maven

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### مثال ساده

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
## تقدیر و تشکر

در فرآیند توسعه این فریم‌ورک، من بسیار تحت تأثیر و الهام جامعه متن‌باز قرار گرفتم. از اساتیدی که تجربیات فنی خود را بی‌دریغ به اشتراک گذاشتند سپاسگزارم؛ خرد و مشارکت شما باعث شد این فریم‌ورک متولد شود. به طور خاص، از پروژه‌های متن‌باز برجسته که ایده‌های طراحی و راهکارهای اجرایی را ارائه دادند، قدردانی می‌کنم؛ این تجربیات ارزشمند به من امکان داد تا بر شانه‌های غول‌ها حرکت کنم.

از تمامی اساتید فنی که به جامعه متن‌باز کمک کرده‌اند سپاسگزارم!

## 🌟 حمایت از پروژه
اگر این پروژه برای شما مفید بوده است، خوشحال می‌شوم با کلیک روی ستاره ⭐ در بالا سمت راست از من حمایت کنید!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---