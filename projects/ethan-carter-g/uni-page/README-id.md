
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

# Kerangka Paging Uni-Page

Uni-Page adalah kerangka kerja paging universal berbasis Java yang melalui desain abstraksi, menyediakan antarmuka query paging yang seragam untuk berbagai sumber data. Kerangka kerja ini menggunakan arsitektur modular, saat ini telah terintegrasi dengan berbagai sumber data seperti JDBC, Mybatis, MongoDB, Elasticsearch, dan juga menyediakan mekanisme ekstensi yang fleksibel.

## Desain Inti

Desain inti kerangka kerja berpusat pada empat komponen kunci:

1. **Pernyataan Paginasi (PaginationStatement)**
    - Mendukung definisi pernyataan query paginasi untuk berbagai bahasa
    - Menyediakan antarmuka parameter paginasi yang seragam
    - Mengizinkan logika paginasi yang dapat disesuaikan

2. **Eksekutor Pernyataan Paginasi (PaginationStatementExecutor)**
    - Bertanggung jawab mengeksekusi pernyataan query paginasi
    - Menyediakan fungsi pencarian informasi paginasi
    - Mekanisme eksekutor yang dapat diperluas

3. **Himpunan Hasil Paginasi (PaginationResultSet)**
    - Antarmuka himpunan hasil yang seragam
    - Mendukung akses data berdasarkan nama kolom dan indeks
    - Menyediakan fungsi konversi tipe data
    - Desain mirip dengan JDBC ResultSet

4. **Pengolah Himpunan Hasil (PaginationResultSetHandler)**
    - Mendukung konversi himpunan hasil secara kustom
    - Menyediakan fungsi pemetaan objek


## Tujuan Desain

1. **Keseragaman**
    - Menyediakan antarmuka query paginasi yang seragam
    - Menyembunyikan perbedaan implementasi antar sumber data
    - Menyederhanakan cara penggunaan query paginasi

2. **Fleksibilitas**
    - Mendukung pernyataan paginasi yang dapat disesuaikan
    - Mengizinkan eksekutor yang dapat diperluas
    - Menyediakan berbagai cara pengolahan himpunan hasil

3. **Ekstensibilitas**
    - Desain modular
    - Mendukung integrasi cepat sumber data baru
    - Menyediakan mekanisme titik ekstensi

4. **Kemudahan Penggunaan**
    - API yang sederhana dan intuitif
    - Konversi tipe yang lengkap
    - Dukungan kelas utilitas yang kaya
## Skenario Penggunaan

- Proyek yang membutuhkan manajemen terpusat untuk kueri paginasi pada beberapa sumber data
- Aplikasi tingkat perusahaan yang membutuhkan dukungan paginasi untuk berbagai sumber data

## Modul Inti

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Pustaka paginasi inti, menyediakan antarmuka dasar paginasi dan implementasi abstrak.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
Modul dukungan sumber data JDBC, menyediakan implementasi paginasi berbasis JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
Modul integrasi MyBatis, menyediakan dukungan integrasi dengan framework MyBatis.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
Modul dukungan sumber data MongoDB, menyediakan implementasi paginasi berbasis MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Modul dukungan sumber data Elasticsearch, menyediakan implementasi paginasi berbasis ES.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Modul dukungan paginasi di lingkungan Spring MVC, menyediakan integrasi dengan Spring MVC, semudah menulis controller biasa.
- Parameter paginasi terikat otomatis
- Hasil paginasi dikonversi otomatis

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Modul pengujian paginasi di lingkungan Spring Boot Web, menyediakan pengujian integrasi untuk fitur paginasi.


## Mulai Cepat, menggunakan uni-page-jdbc sebagai contoh

### Ketergantungan Maven

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Contoh Sederhana

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
## Ucapan Terima Kasih

Dalam proses pengembangan kerangka kerja ini, saya sangat terpengaruh dan terinspirasi oleh komunitas open source. Terima kasih kepada para ahli yang dengan sukarela membagikan pengalaman teknis mereka; kebijaksanaan dan kontribusi kalianlah yang memungkinkan lahirnya kerangka kerja ini. Secara khusus, terima kasih atas inspirasi desain dan ide implementasi dari proyek open source yang luar biasa, pengalaman berharga ini memungkinkan saya untuk terus melangkah lebih jauh di atas bahu para raksasa.

Terima kasih kepada semua ahli teknologi yang telah berkontribusi untuk komunitas open source!

## 🌟 Dukung Proyek
Jika menurutmu proyek ini bermanfaat, silakan klik ⭐Star di pojok kanan atas untuk mendukung saya!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---