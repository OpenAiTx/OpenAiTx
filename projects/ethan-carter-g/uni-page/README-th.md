
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

# Uni-Page กรอบงานแบ่งหน้า

Uni-Page คือกรอบงานแบ่งหน้าทั่วไปที่พัฒนาบน Java โดยออกแบบเชิงนามธรรมเพื่อให้บริการอินเทอร์เฟซการค้นหาข้อมูลแบบแบ่งหน้าที่統一สำหรับแหล่งข้อมูลต่าง ๆ กรอบงานนี้ใช้โครงสร้างแบบโมดูล และในขณะนี้ได้ผนวก JDBC, Mybatis, MongoDB, Elasticsearch และแหล่งข้อมูลอื่น ๆ รวมถึงมีระบบขยายที่ยืดหยุ่น

## การออกแบบหลัก

การออกแบบหลักของกรอบงานนี้เน้นไปที่สี่องค์ประกอบสำคัญ:

1. **คำสั่งแบ่งหน้า (PaginationStatement)**
    - รองรับการกำหนดคำสั่งแบ่งหน้าสำหรับภาษาใดก็ได้
    - มีอินเทอร์เฟซสำหรับพารามิเตอร์แบ่งหน้าแบบเดียวกัน
    - อนุญาตให้ปรับแต่งตรรกะแบ่งหน้าเอง

2. **ตัวดำเนินการแบ่งหน้า (PaginationStatementExecutor)**
    - รับผิดชอบในการดำเนินการแบ่งหน้าคำสั่งค้นหา
    - ให้ฟังก์ชันการสอบถามข้อมูลแบ่งหน้า
    - มีกลไกตัวดำเนินการที่ขยายได้

3. **ชุดผลลัพธ์แบ่งหน้า (PaginationResultSet)**
    - อินเทอร์เฟซชุดผลลัพธ์แบบเดียวกัน
    - รองรับการเข้าถึงข้อมูลตามชื่อคอลัมน์และดัชนี
    - มีฟังก์ชันแปลงประเภทข้อมูล
    - ออกแบบคล้ายกับ JDBC ResultSet

4. **ตัวจัดการชุดผลลัพธ์ (PaginationResultSetHandler)**
    - รองรับการปรับแต่งการแปลงชุดผลลัพธ์เอง
    - มีฟังก์ชันแมปข้อมูลเป็นอ็อบเจ็กต์


## เป้าหมายการออกแบบ

1. **ความเป็นหนึ่งเดียว**
    - ให้บริการอินเทอร์เฟซแบ่งหน้าค้นหาแบบเดียวกัน
    - ซ่อนความแตกต่างของการใช้งานระหว่างแหล่งข้อมูลต่าง ๆ
    - ทำให้การใช้งานแบ่งหน้าค้นหาง่ายขึ้น

2. **ความยืดหยุ่น**
    - รองรับการปรับแต่งคำสั่งแบ่งหน้า
    - อนุญาตให้ขยายตัวดำเนินการได้
    - มีวิธีจัดการชุดผลลัพธ์ที่หลากหลาย

3. **ความสามารถในการขยาย**
    - การออกแบบแบบโมดูล
    - รองรับการเชื่อมต่อแหล่งข้อมูลใหม่ได้อย่างรวดเร็ว
    - มีกลไกขยายจุดต่อเติม

4. **ความง่ายในการใช้งาน**
    - API ที่เรียบง่ายและเข้าใจง่าย
    - การแปลงประเภทที่สมบูรณ์แบบ
    - สนับสนุนคลาสเครื่องมือที่หลากหลาย
## สถานการณ์การใช้งาน

- โครงการที่ต้องการจัดการการแบ่งหน้าแบบหลายแหล่งข้อมูลอย่างเป็นเอกภาพ
- แอปพลิเคชันระดับองค์กรที่ต้องการรองรับการแบ่งหน้าหลายแหล่งข้อมูล

## โมดูลหลัก

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
ไลบรารีการแบ่งหน้าหลัก ให้บริการอินเทอร์เฟซและการใช้งานแบบนามธรรมสำหรับการแบ่งหน้า

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
โมดูลสนับสนุนแหล่งข้อมูล JDBC ให้บริการการแบ่งหน้าตาม JDBC

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
โมดูลบูรณาการ MyBatis ให้บริการการบูรณาการกับเฟรมเวิร์ก MyBatis
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
โมดูลสนับสนุนแหล่งข้อมูล MongoDB ให้บริการการแบ่งหน้าตาม MongoDB

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
โมดูลสนับสนุนแหล่งข้อมูล Elasticsearch ให้บริการการแบ่งหน้าตาม ES

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
โมดูลสนับสนุนการแบ่งหน้าในสภาพแวดล้อม Spring MVC ให้การบูรณาการกับ Spring MVC ได้อย่างง่ายดายเหมือนกับการเขียนคอนโทรลเลอร์ทั่วไป
- ผูกพารามิเตอร์การแบ่งหน้าโดยอัตโนมัติ
- แปลงผลลัพธ์การแบ่งหน้าโดยอัตโนมัติ

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
โมดูลทดสอบการแบ่งหน้าในสภาพแวดล้อม Spring Boot Web ให้บริการทดสอบการบูรณาการฟังก์ชั่นแบ่งหน้า


## เริ่มต้นอย่างรวดเร็ว โดยใช้ uni-page-jdbc เป็นตัวอย่าง

### การเพิ่ม Maven Dependency

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### ตัวอย่างง่าย

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
## ขอขอบคุณ

ในการพัฒนาเฟรมเวิร์กนี้ ผมได้รับอิทธิพลและแรงบันดาลใจอย่างมากจากชุมชนโอเพ่นซอร์ส ขอขอบคุณผู้ที่แบ่งปันประสบการณ์ทางเทคนิคอย่างไม่เห็นแก่ตัว เป็นความรู้และการมีส่วนร่วมของพวกคุณที่ทำให้เฟรมเวิร์กนี้เกิดขึ้นได้ โดยเฉพาะอย่างยิ่งต้องขอขอบคุณโปรเจกต์โอเพ่นซอร์สยอดเยี่ยมที่นำเสนอแรงบันดาลใจในการออกแบบและแนวคิดการพัฒนา ประสบการณ์อันล้ำค่าเหล่านี้ทำให้ผมสามารถก้าวต่อไปบนบ่าของยักษ์ใหญ่

ขอขอบคุณผู้เชี่ยวชาญทางเทคนิคทุกท่านที่มีส่วนร่วมกับชุมชนโอเพ่นซอร์ส!

## 🌟 สนับสนุนโปรเจกต์
หากคุณคิดว่าโปรเจกต์นี้เป็นประโยชน์สำหรับคุณ ยินดีต้อนรับให้กด ⭐Star ที่มุมขวาบนเพื่อสนับสนุนผม!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---