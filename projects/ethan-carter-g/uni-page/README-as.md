
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

# Uni-Page পৃষ্ঠাবিভাজন ফ্ৰেমৱৰ্ক

Uni-Page এটা Java-ভিত্তিত সাধাৰণ পৃষ্ঠাবিভাজন ফ্ৰেমৱৰ্ক, যি বিমূর্ত ডিজাইনৰে বিভিন্ন তথ্য উৎসৰ বাবে একেটা পৃষ্ঠাবিভাজন অনুসন্ধান ইণ্টাৰফেচ প্ৰদান কৰে। ফ্ৰেমৱৰ্কটোৱে মডুলাৰ স্থাপত্য গ্ৰহণ কৰিছে, বৰ্তমান JDBC, Mybatis, MongoDB, Elasticsearch আদি বহু তথ্য উৎসৰ সৈতে সংহত কৰা হৈছে আৰু এটা নমনীয় বিস্তাৰণ প্ৰণালী প্ৰদান কৰিছে।

## মূল ডিজাইন

ফ্ৰেমৱৰ্কৰ মূল ডিজাইন চাৰিটা মুখ্য উপাদানক কেন্দ্ৰ কৰি বিকাশ কৰা হৈছে:

1. **পৃষ্ঠা বিভাজন বাক্য (PaginationStatement)**
    - যিকোনো ভাষাৰ পৃষ্ঠা বিভাজন অনুসন্ধান বাক্য সংজ্ঞা সমৰ্থন কৰে
    - এক ৰূপ paging parameter interface প্ৰদান কৰে
    - কাষ্টম paging logic অনুমতি দিয়ে

2. **পৃষ্ঠা বিভাজন এক্সিকিউটৰ (PaginationStatementExecutor)**
    - পৃষ্ঠা বিভাজন অনুসন্ধান বাক্য সম্পাদন কৰিবলৈ দায়িত্ববান
    - পৃষ্ঠা তথ্য অনুসন্ধানৰ কাৰ্যক্ষমতা প্ৰদান কৰে
    - বিস্তৃতযোগ্য এক্সিকিউটৰ ব্যৱস্থা

3. **পৃষ্ঠা ফলাফল সমষ্টি (PaginationResultSet)**
    - এক ৰূপ ফলাফল সমষ্টি ইণ্টাৰফেইচ
    - কলাম নাম আৰু সূচক অনুসৰি তথ্য প্ৰৱেশ সমৰ্থন কৰে
    - টাইপ ৰূপান্তৰ কাৰ্যক্ষমতা প্ৰদান কৰে
    - JDBC ResultSet সদৃশ ডিজাইন

4. **ফলাফল সমষ্টি হেণ্ডলাৰ (PaginationResultSetHandler)**
    - কাষ্টম ফলাফল সমষ্টি ৰূপান্তৰ সমৰ্থন
    - অবজেক্ট ম্যাপিং কাৰ্যক্ষমতা প্ৰদান


## ডিজাইনৰ লক্ষ্য

1. **এক ৰূপতা**
    - এক ৰূপ paging অনুসন্ধান ইণ্টাৰফেইচ প্ৰদান
    - বিভিন্ন তথ্য উৎসৰ কাৰ্যান্বয়ৰ পাৰ্থক্য গোপন কৰে
    - paging অনুসন্ধান ব্যৱহাৰ সহজ কৰে

2. **লচিলতা**
    - কাষ্টম paging বাক্য সমৰ্থন
    - এক্সিকিউটৰ বিস্তৃত কৰাৰ অনুমতি
    - সমৃদ্ধ ফলাফল সমষ্টি প্ৰক্ৰিয়া প্ৰদান

3. **বিস্তৃতযোগ্যতা**
    - মডুলাৰ ডিজাইন
    - নতুন তথ্য উৎস সোনকালে সংযোগ সমৰ্থন
    - বিস্তৃতি বিন্দু ব্যৱস্থা প্ৰদান

4. **সহজ ব্যৱহাৰযোগ্যতা**
    - সহজ আৰু স্পষ্ট API
    - সম্পূৰ্ণ ৰূপে টাইপ ৰূপান্তৰ
    - সমৃদ্ধ টুল ক্লাছ সমৰ্থন
## প্ৰযোজ্য ক্ষেত্ৰ

- একাধিক ডাটা উৎসৰ পৃষ্ঠা অনুসন্ধান একত্ৰিতভাৱে পৰিচালনা কৰিব লগা প্ৰকল্প
- বহুবিধ ডাটা উৎসৰ পৃষ্ঠা অনুসন্ধান সমৰ্থন কৰিব লগা উদ্যোগিক ব্যৱহাৰ

## মূল অংশ

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
মূল পৃষ্ঠা লাইব্ৰেৰী, আধাৰভূত পৃষ্ঠা ইন্টাৰফেচ আৰু বিমূর্ত বাস্তবায়ন প্ৰদান কৰে।

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
JDBC ডাটা উৎস সমৰ্থন অংশ, JDBC ভিত্তিক পৃষ্ঠা বাস্তবায়ন প্ৰদান কৰে।

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
MyBatis সংহত অংশ, MyBatis ফ্ৰেমৱৰ্কৰ সৈতে সংহতি সমৰ্থন প্ৰদান কৰে।
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
MongoDB ডাটা উৎস সমৰ্থন অংশ, MongoDB ভিত্তিক পৃষ্ঠা বাস্তবায়ন প্ৰদান কৰে।

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Elasticsearch ডাটা উৎস সমৰ্থন অংশ, ES ভিত্তিক পৃষ্ঠা বাস্তবায়ন প্ৰদান কৰে।

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Spring MVC পৰিৱেশত পৃষ্ঠা সমৰ্থন অংশ, Spring MVCৰ সৈতে সংহতি সমৰ্থন প্ৰদান কৰে, সাধাৰণ কণ্ট্ৰোলাৰ লিখাৰ দৰে সহজ।
- পৃষ্ঠা পৰামিতি স্বয়ংক্ৰিয়ভাৱে বাইন্ডিং
- পৃষ্ঠা ফলাফল স্বয়ংক্ৰিয়ভাৱে ৰূপান্তৰ

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Spring Boot Web পৰিৱেশত পৃষ্ঠা পৰীক্ষা অংশ, পৃষ্ঠা ফিচাৰৰ সংহত পৰীক্ষা প্ৰদান কৰে।


## তৎকালিক আৰম্ভণি, uni-page-jdbc উদাহৰণ হিচাপে

### Maven নির্ভৰতা

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### সৰল উদাহৰণ

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


## ধন্যবাদ জ্ঞাপন

এই ফ্ৰেমৱৰ্কৰ বিকাশৰ সময়ত, মই মুক্ত উৎস সমাজৰ পৰা গভীৰভাৱে প্ৰভাৱিত আৰু অনুপ্ৰাণিত হৈছিলোঁ। সেইসকল নিঃস্বার্থভাৱে প্ৰযুক্তি অভিজ্ঞতা ভাগ-বতৰা কৰা বিশিষ্ট ব্যক্তিসকলক ধন্যবাদ, আপোনালোকৰ বুদ্ধি আৰু অৱদানেই এই ফ্ৰেমৱৰ্কৰ জন্ম হ’বলৈ সক্ষম কৰিলে। বিশেষকৈ সেইসকল উৎকৃষ্ট মুক্ত উৎস প্ৰকল্পৰ পৰা আহৰা ডিজাইন অনুপ্ৰেৰণা আৰু কাৰ্য্য-ধাৰণা, এই মূল্যবান অভিজ্ঞতাসমূহে মোক দেৱ-মানুহৰ কঁকালত থিয় হ’বলৈ সহায় কৰিছে।

মুক্ত উৎস সমাজত অৱদান ৰখা সকলো বিশিষ্ট প্ৰযুক্তি ব্যক্তিসকলক ধন্যবাদ!

## 🌟 পৰিয়োজনাক সমৰ্থন কৰক
যদি আপুনি এই পৰিয়োজনাটো আপোনাৰ বাবে সহায়ক বুলি ভাবেন, অনুগ্ৰহ কৰি সোঁ-ওপৰৰ ⭐Star ক্লিক কৰি মোক সমৰ্থন কৰক!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---