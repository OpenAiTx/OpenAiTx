<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# Uni-Page पेजिनेशन फ्रेमवर्क

Uni-Page एक जावा आधारित सामान्य पेजिनेशन फ्रेमवर्क है, जो अमूर्त डिजाइन के माध्यम से विभिन्न डेटा स्रोतों के लिए एकीकृत पेजिनेशन क्वेरी इंटरफेस प्रदान करता है। यह फ्रेमवर्क मॉड्यूलर आर्किटेक्चर को अपनाता है, और वर्तमान में JDBC, Mybatis, MongoDB, Elasticsearch आदि कई डेटा स्रोतों के साथ एकीकृत है, साथ ही लचीला विस्तार तंत्र भी प्रदान करता है।

## मुख्य डिजाइन

फ्रेमवर्क का मुख्य डिजाइन चार प्रमुख घटकों के इर्द-गिर्द केंद्रित है:


1. **पेजिनेशन स्टेटमेंट (PaginationStatement)**
    - किसी भी भाषा के पेजिनेशन क्वेरी स्टेटमेंट की परिभाषा का समर्थन करता है
    - एकीकृत पेजिनेशन पैरामीटर इंटरफेस प्रदान करता है
    - कस्टम पेजिनेशन लॉजिक की अनुमति देता है

2. **पेजिनेशन निष्पादक (PaginationStatementExecutor)**
    - पेजिनेशन क्वेरी स्टेटमेंट को निष्पादित करने के लिए जिम्मेदार
    - पेजिनेशन जानकारी क्वेरी करने की सुविधा प्रदान करता है
    - विस्तारयोग्य निष्पादक तंत्र

3. **पेजिनेशन परिणाम सेट (PaginationResultSet)**
    - एकीकृत परिणाम सेट इंटरफेस
    - कॉलम नाम और इंडेक्स द्वारा डेटा एक्सेस का समर्थन करता है
    - टाइप कन्वर्ज़न सुविधा प्रदान करता है
    - JDBC ResultSet जैसी डिज़ाइन

4. **परिणाम सेट प्रोसेसर (PaginationResultSetHandler)**
    - कस्टम परिणाम सेट रूपांतरण का समर्थन करता है
    - ऑब्जेक्ट मैपिंग सुविधा प्रदान करता है


## डिज़ाइन लक्ष्य

1. **एकरूपता**
    - एकीकृत पेजिनेशन क्वेरी इंटरफेस प्रदान करता है
    - विभिन्न डेटा स्रोतों के कार्यान्वयन भिन्नताओं को छुपाता है
    - पेजिनेशन क्वेरी के उपयोग को सरल बनाता है

2. **लचीलापन**
    - कस्टम पेजिनेशन स्टेटमेंट का समर्थन करता है
    - निष्पादक के विस्तार की अनुमति देता है
    - समृद्ध परिणाम सेट प्रोसेसिंग विधियाँ प्रदान करता है

3. **विस्तारशीलता**
    - मॉड्यूलर डिज़ाइन
    - नए डेटा स्रोतों के त्वरित एकीकरण का समर्थन करता है
    - एक्सटेंशन पॉइंट तंत्र प्रदान करता है

4. **सरलता**
    - सरल और सहज API
    - पूर्ण प्रकार रूपांतरण
    - समृद्ध टूल क्लास समर्थन
## उपयुक्त परिदृश्य

- ऐसे प्रोजेक्ट जिनमें कई डेटा स्रोतों की पेजिनेशन क्वेरी का統一 प्रबंधन आवश्यक है
- ऐसे एंटरप्राइज एप्लिकेशन जिन्हें कई प्रकार के डेटा स्रोतों की पेजिनेशन का समर्थन चाहिए

## कोर मॉड्यूल

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
कोर पेजिनेशन लाइब्रेरी, जो मूल पेजिनेशन इंटरफेस और अमूर्त कार्यान्वयन प्रदान करती है।

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
JDBC डेटा स्रोत समर्थन मॉड्यूल, जो JDBC आधारित पेजिनेशन कार्यान्वयन प्रदान करता है।

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
MyBatis एकीकरण मॉड्यूल, जो MyBatis फ्रेमवर्क के साथ एकीकरण समर्थन प्रदान करता है।
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
MongoDB डेटा स्रोत समर्थन मॉड्यूल, जो MongoDB आधारित पेजिनेशन कार्यान्वयन प्रदान करता है।

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Elasticsearch डेटा स्रोत समर्थन मॉड्यूल, जो ES आधारित पेजिनेशन कार्यान्वयन प्रदान करता है।

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Spring MVC वातावरण के लिए पेजिनेशन समर्थन मॉड्यूल, जो Spring MVC के साथ एकीकरण प्रदान करता है, बिल्कुल सामान्य नियंत्रक लिखने जितना आसान।
- पेजिनेशन पैरामीटर स्वतः बाइंडिंग
- पेजिनेशन परिणाम स्वतः रूपांतरण

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Spring Boot Web वातावरण के लिए पेजिनेशन परीक्षण मॉड्यूल, जो पेजिनेशन फीचर का एकीकृत परीक्षण प्रदान करता है।


## त्वरित आरंभ, uni-page-jdbc को उदाहरण के रूप में लें

### Maven निर्भरता

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### सरल उदाहरण

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
  
## आभार

इस फ्रेमवर्क के विकास के दौरान, मैं ओपन सोर्स समुदाय से बहुत प्रभावित और प्रेरित हुआ हूँ। उन तकनीकी विशेषज्ञों का धन्यवाद जिन्होंने अपने अनुभव बिना स्वार्थ साझा किए, उन्हीं की बुद्धिमत्ता और योगदान से यह फ्रेमवर्क संभव हो पाया। विशेष आभार उन उत्कृष्ट ओपन सोर्स प्रोजेक्ट्स का, जिनसे डिजाइन की प्रेरणा और कार्यान्वयन के विचार मिले, इन अनमोल अनुभवों ने मुझे महान व्यक्तित्वों के कंधों पर आगे बढ़ने का अवसर दिया।

ओपन सोर्स समुदाय में योगदान देने वाले सभी तकनीकी विशेषज्ञों का धन्यवाद!

## 🌟 परियोजना का समर्थन करें
यदि आपको यह परियोजना उपयोगी लगी हो, तो कृपया ऊपर दाईं ओर ⭐Star पर क्लिक कर मेरा समर्थन करें!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---