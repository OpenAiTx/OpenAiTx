<p align="center">
<img src="https://user-images.githubusercontent.com/8291514/213727234-cda046d6-28c6-491a-b284-b86c5cede25d.png#gh-light-mode-only">
<img src="https://user-images.githubusercontent.com/8291514/213727225-56186826-bee8-43b5-9b15-86e839d89393.png#gh-dark-mode-only">
</p>

# Supabase

[Supabase](https://supabase.com), açık kaynaklı bir Firebase alternatifidir. Firebase’in özelliklerini kurumsal düzeyde açık kaynaklı araçlarla geliştiriyoruz.

- [x] Barındırılan Postgres Veritabanı. [Dokümantasyon](https://supabase.com/docs/guides/database)
- [x] Kimlik Doğrulama ve Yetkilendirme. [Dokümantasyon](https://supabase.com/docs/guides/auth)
- [x] Otomatik oluşturulan API’lar.
  - [x] REST. [Dokümantasyon](https://supabase.com/docs/guides/api)
  - [x] GraphQL. [Dokümantasyon](https://supabase.com/docs/guides/graphql)
  - [x] Gerçek zamanlı abonelikler. [Dokümantasyon](https://supabase.com/docs/guides/realtime)
- [x] Fonksiyonlar.
  - [x] Veritabanı Fonksiyonları. [Dokümantasyon](https://supabase.com/docs/guides/database/functions)
  - [x] Edge Fonksiyonlar [Dokümantasyon](https://supabase.com/docs/guides/functions)
- [x] Dosya Depolama. [Dokümantasyon](https://supabase.com/docs/guides/storage)
- [x] AI + Vektör/Gömme Araç Seti. [Dokümantasyon](https://supabase.com/docs/guides/ai)
- [x] Kontrol Paneli

![Supabase Dashboard](https://raw.githubusercontent.com/supabase/supabase/master/apps/www/public/images/github/supabase-dashboard.png)

Büyük güncellemelerden haberdar olmak için bu depodaki "releases"ları izleyin.

<kbd><img src="https://raw.githubusercontent.com/supabase/supabase/d5f7f413ab356dc1a92075cb3cee4e40a957d5b1/web/static/watch-repo.gif" alt="Watch this repo"/></kbd>

## Dokümantasyon

Tüm dokümantasyon için [supabase.com/docs](https://supabase.com/docs) adresini ziyaret edin.

Katkıda bulunmak için [Başlangıç Rehberi](./DEVELOPERS.md) sayfasına bakın.

## Topluluk & Destek

- [Topluluk Forumu](https://github.com/supabase/supabase/discussions). En iyisi: geliştirme yardımı, veritabanı en iyi uygulamaları hakkında tartışmalar.
- [GitHub Sorunları](https://github.com/supabase/supabase/issues). En iyisi: Supabase kullanırken karşılaşılan hata ve sorunlar.
- [E-posta Desteği](https://supabase.com/docs/support#business-support). En iyisi: veritabanı veya altyapı ile ilgili problemler.
- [Discord](https://discord.supabase.com). En iyisi: uygulamalarınızı paylaşmak ve toplulukla takılmak.

## Nasıl çalışır?

Supabase, açık kaynaklı araçların birleşimidir. Firebase’in özelliklerini kurumsal düzeyde, açık kaynaklı ürünler kullanarak geliştiriyoruz. Eğer araçlar ve topluluklar MIT, Apache 2 veya eşdeğer açık lisans ile mevcutsa, o aracı kullanır ve destekleriz. Araç yoksa, kendimiz geliştirip açık kaynak olarak sunarız. Supabase, Firebase’in birebir karşılığı değildir. Amacımız, geliştiricilere açık kaynak araçlarla Firebase benzeri bir deneyim sunmaktır.

**Mimari**

Supabase bir [barındırılan platformdur](https://supabase.com/dashboard). Hiçbir şey yüklemeden kaydolup Supabase’i kullanmaya başlayabilirsiniz.
Ayrıca [kendi sunucunuzda barındırabilir](https://supabase.com/docs/guides/hosting/overview) ve [lokal geliştirme yapabilirsiniz](https://supabase.com/docs/guides/local-development).

![Architecture](apps/docs/public/img/supabase-architecture.svg)

- [Postgres](https://www.postgresql.org/), 30 yılı aşkın aktif geliştirmeye sahip, güvenilirlik, özellik zenginliği ve performans açısından güçlü bir üne sahip nesne-ilişkisel bir veritabanı sistemidir.
- [Realtime](https://github.com/supabase/realtime), PostgreSQL ekleme, güncelleme ve silme işlemlerini websockets ile dinlemenizi sağlayan bir Elixir sunucusudur. Realtime, Postgres’in yerleşik çoğaltma işlevini veritabanı değişiklikleri için tarar, değişiklikleri JSON’a dönüştürür ve ardından yetkili istemcilere websockets üzerinden iletir.
- [PostgREST](http://postgrest.org/), PostgreSQL veritabanınızı doğrudan RESTful bir API'ye dönüştüren bir web sunucusudur.
- [GoTrue](https://github.com/supabase/gotrue), uygulamalarınızda kullanıcı kaydı, giriş ve oturum yönetimini kolaylaştıran JWT tabanlı bir kimlik doğrulama API'sidir.
- [Storage](https://github.com/supabase/storage-api), S3'teki dosyaları yönetmek için RESTful bir API'dir ve izinleri Postgres yönetir.
- [pg_graphql](http://github.com/supabase/pg_graphql/), bir GraphQL API'si sunan PostgreSQL uzantısıdır.
- [postgres-meta](https://github.com/supabase/postgres-meta), Postgres'i yönetmek için RESTful bir API'dir; tabloları getirme, rol ekleme ve sorgu çalıştırma gibi işlemleri yapmanızı sağlar.
- [Kong](https://github.com/Kong/kong), bulut tabanlı bir API ağ geçididir.

#### İstemci kütüphaneleri

İstemci kütüphanelerine yaklaşımımız modülerdir. Her alt kütüphane, tek bir harici sistem için bağımsız bir uygulamadır. Bu, mevcut araçları destekleme yollarımızdan biridir.

<table style="table-layout:fixed; white-space: nowrap;">
  <tr>
    <th>Dil</th>
    <th>İstemci</th>
    <th colspan="5">Özellik-İstemcileri (Supabase istemcisine dahil)</th>
  </tr>
  <!-- notranslate -->
  <tr>
    <th></th>
    <th>Supabase</th>
    <th><a href="https://github.com/postgrest/postgrest" target="_blank" rel="noopener noreferrer">PostgREST</a></th>
    <th><a href="https://github.com/supabase/gotrue" target="_blank" rel="noopener noreferrer">GoTrue</a></th>
    <th><a href="https://github.com/supabase/realtime" target="_blank" rel="noopener noreferrer">Realtime</a></th>
    <th><a href="https://github.com/supabase/storage-api" target="_blank" rel="noopener noreferrer">Storage</a></th>
    <th>Fonksiyonlar</th>
  </tr>
  <!-- TEMPLATE FOR NEW ROW -->
  <!-- START ROW
  <tr>
    <td>lang</td>
    <td><a href="https://github.com/supabase-community/supabase-lang" target="_blank" rel="noopener noreferrer">supabase-lang</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-lang" target="_blank" rel="noopener noreferrer">postgrest-lang</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-lang" target="_blank" rel="noopener noreferrer">gotrue-lang</a></td>
    <td><a href="https://github.com/supabase-community/realtime-lang" target="_blank" rel="noopener noreferrer">realtime-lang</a></td>
    <td><a href="https://github.com/supabase-community/storage-lang" target="_blank" rel="noopener noreferrer">storage-lang</a></td>
  </tr>
  END ROW -->
  <!-- /notranslate -->
  <th colspan="7">⚡️ Resmi ⚡️</th>
  <!-- notranslate -->
  <tr>
    <td>JavaScript (TypeScript)</td>
    <td><a href="https://github.com/supabase/supabase-js" target="_blank" rel="noopener noreferrer">supabase-js</a></td>
    <td><a href="https://github.com/supabase/postgrest-js" target="_blank" rel="noopener noreferrer">postgrest-js</a></td>
    <td><a href="https://github.com/supabase/gotrue-js" target="_blank" rel="noopener noreferrer">gotrue-js</a></td>
    <td><a href="https://github.com/supabase/realtime-js" target="_blank" rel="noopener noreferrer">realtime-js</a></td>
    <td><a href="https://github.com/supabase/storage-js" target="_blank" rel="noopener noreferrer">storage-js</a></td>
    <td><a href="https://github.com/supabase/functions-js" target="_blank" rel="noopener noreferrer">functions-js</a></td>
  </tr>
    <tr>
    <td>Flutter</td>
    <td><a href="https://github.com/supabase/supabase-flutter" target="_blank" rel="noopener noreferrer">supabase-flutter</a></td>
    <td><a href="https://github.com/supabase/postgrest-dart" target="_blank" rel="noopener noreferrer">postgrest-dart</a></td>
    <td><a href="https://github.com/supabase/gotrue-dart" target="_blank" rel="noopener noreferrer">gotrue-dart</a></td>
    <td><a href="https://github.com/supabase/realtime-dart" target="_blank" rel="noopener noreferrer">realtime-dart</a></td>
    <td><a href="https://github.com/supabase/storage-dart" target="_blank" rel="noopener noreferrer">storage-dart</a></td>
    <td><a href="https://github.com/supabase/functions-dart" target="_blank" rel="noopener noreferrer">functions-dart</a></td>
  </tr>
  <tr>
    <td>Swift</td>
    <td><a href="https://github.com/supabase/supabase-swift" target="_blank" rel="noopener noreferrer">supabase-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/PostgREST" target="_blank" rel="noopener noreferrer">postgrest-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Auth" target="_blank" rel="noopener noreferrer">auth-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Realtime" target="_blank" rel="noopener noreferrer">realtime-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Storage" target="_blank" rel="noopener noreferrer">storage-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Functions" target="_blank" rel="noopener noreferrer">functions-swift</a></td>
  </tr>
  <tr>
    <td>Python</td>
    <td><a href="https://github.com/supabase/supabase-py" target="_blank" rel="noopener noreferrer">supabase-py</a></td>
    <td><a href="https://github.com/supabase/postgrest-py" target="_blank" rel="noopener noreferrer">postgrest-py</a></td>
    <td><a href="https://github.com/supabase/gotrue-py" target="_blank" rel="noopener noreferrer">gotrue-py</a></td>
    <td><a href="https://github.com/supabase/realtime-py" target="_blank" rel="noopener noreferrer">realtime-py</a></td>
    <td><a href="https://github.com/supabase/storage-py" target="_blank" rel="noopener noreferrer">storage-py</a></td>
    <td><a href="https://github.com/supabase/functions-py" target="_blank" rel="noopener noreferrer">functions-py</a></td>
  </tr>
  <!-- /notranslate -->
  <th colspan="7">💚 Topluluk 💚</th>
  <!-- notranslate -->
  <tr>
    <td>C#</td>
    <td><a href="https://github.com/supabase-community/supabase-csharp" target="_blank" rel="noopener noreferrer">supabase-csharp</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-csharp" target="_blank" rel="noopener noreferrer">postgrest-csharp</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-csharp" target="_blank" rel="noopener noreferrer">gotrue-csharp</a></td>
    <td><a href="https://github.com/supabase-community/realtime-csharp" target="_blank" rel="noopener noreferrer">realtime-csharp</a></td>
    <td><a href="https://github.com/supabase-community/storage-csharp" target="_blank" rel="noopener noreferrer">storage-csharp</a></td>
    <td><a href="https://github.com/supabase-community/functions-csharp" target="_blank" rel="noopener noreferrer">functions-csharp</a></td>
  </tr>
  <tr>
    <td>Go</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/postgrest-go" target="_blank" rel="noopener noreferrer">postgrest-go</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-go" target="_blank" rel="noopener noreferrer">gotrue-go</a></td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/storage-go" target="_blank" rel="noopener noreferrer">storage-go</a></td>
    <td><a href="https://github.com/supabase-community/functions-go" target="_blank" rel="noopener noreferrer">functions-go</a></td>
  </tr>
  <tr>
    <td>Java</td>
    <td>-</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/gotrue-java" target="_blank" rel="noopener noreferrer">gotrue-java</a></td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/storage-java" target="_blank" rel="noopener noreferrer">storage-java</a></td>
    <td>-</td>
  </tr>
  <tr>
    <td>Kotlin</td>
    <td><a href="https://github.com/supabase-community/supabase-kt" target="_blank" rel="noopener noreferrer">supabase-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Postgrest" target="_blank" rel="noopener noreferrer">postgrest-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Auth" target="_blank" rel="noopener noreferrer">auth-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Realtime" target="_blank" rel="noopener noreferrer">realtime-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Storage" target="_blank" rel="noopener noreferrer">storage-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Functions" target="_blank" rel="noopener noreferrer">functions-kt</a></td>
  </tr>
  <tr>
    <td>Ruby</td>
    <td><a href="https://github.com/supabase-community/supabase-rb" target="_blank" rel="noopener noreferrer">supabase-rb</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-rb" target="_blank" rel="noopener noreferrer">postgrest-rb</a></td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
  </tr>
  <tr>
    <td>Rust</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/postgrest-rs" target="_blank" rel="noopener noreferrer">postgrest-rs</a></td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
  </tr>
  <tr>
    <td>Godot Engine (GDScript)</td>
    <td><a href="https://github.com/supabase-community/godot-engine.supabase" target="_blank" rel="noopener noreferrer">supabase-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-gdscript" target="_blank" rel="noopener noreferrer">postgrest-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-gdscript" target="_blank" rel="noopener noreferrer">gotrue-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/realtime-gdscript" target="_blank" rel="noopener noreferrer">realtime-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/storage-gdscript" target="_blank" rel="noopener noreferrer">storage-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/functions-gdscript" target="_blank" rel="noopener noreferrer">functions-gdscript</a></td>
  </tr>
  <!-- /notranslate -->
</table>

<!--- Başka bir dile çeviriyorsanız bu listeyi kaldırın, birden çok dosyada güncel tutmak zordur -->
<!--- Sadece çeviri dosyaları listesinin bağlantısını bırakın -->

## Rozetler

![Supabase ile yapıldı](./apps/www/public/badge-made-with-supabase.svg)

```md
[![Supabase ile yapıldı](https://supabase.com/badge-made-with-supabase.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase.svg"
    alt="Supabase ile yapıldı"
  />
</a>
```

![Supabase ile yapıldı (dark)](./apps/www/public/badge-made-with-supabase-dark.svg)

```md
[![Supabase ile yapıldı](https://supabase.com/badge-made-with-supabase-dark.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase-dark.svg"
    alt="Supabase ile yapıldı"
  />
</a>
```

## Çeviriler

- [Arabic | العربية](/i18n/README.ar.md)
- [Albanian / Shqip](/i18n/README.sq.md)
- [Bangla / বাংলা](/i18n/README.bn.md)
- [Bulgarian / Български](/i18n/README.bg.md)
- [Catalan / Català](/i18n/README.ca.md)
- [Czech / čeština](/i18n/README.cs.md)
- [Danish / Dansk](/i18n/README.da.md)
- [Dutch / Nederlands](/i18n/README.nl.md)
- [English](https://github.com/supabase/supabase)
- [Estonian / eesti keel](/i18n/README.et.md)
- [Finnish / Suomalainen](/i18n/README.fi.md)
- [French / Français](/i18n/README.fr.md)
- [German / Deutsch](/i18n/README.de.md)
- [Greek / Ελληνικά](/i18n/README.el.md)
- [Gujarati / ગુજરાતી](/i18n/README.gu.md)
- [Hebrew / עברית](/i18n/README.he.md)
- [Hindi / हिंदी](/i18n/README.hi.md)
- [Hungarian / Magyar](/i18n/README.hu.md)
- [Nepali / नेपाली](/i18n/README.ne.md)
- [Indonesian / Bahasa Indonesia](/i18n/README.id.md)
- [Italiano / Italian](/i18n/README.it.md)
- [Japanese / 日本語](/i18n/README.jp.md)
- [Korean / 한국어](/i18n/README.ko.md)
- [Lithuanian / lietuvių](/i18n/README.lt.md)
- [Latvian / latviski](/i18n/README.lv.md)
- [Malay / Bahasa Malaysia](/i18n/README.ms.md)
- [Norwegian (Bokmål) / Norsk (Bokmål)](/i18n/README.nb.md)
- [Persian / فارسی](/i18n/README.fa.md)
- [Polish / Polski](/i18n/README.pl.md)
- [Portuguese / Português](/i18n/README.pt.md)
- [Portuguese (Brazilian) / Português Brasileiro](/i18n/README.pt-br.md)
- [Romanian / Română](/i18n/README.ro.md)
- [Russian / Pусский](/i18n/README.ru.md)
- [Serbian / Srpski](/i18n/README.sr.md)
- [Sinhala / සිංහල](/i18n/README.si.md)
- [Slovak / slovenský](/i18n/README.sk.md)
- [Slovenian / Slovenščina](/i18n/README.sl.md)
- [Spanish / Español](/i18n/README.es.md)
- [Simplified Chinese / 简体中文](/i18n/README.zh-cn.md)
- [Swedish / Svenska](/i18n/README.sv.md)
- [Thai / ไทย](/i18n/README.th.md)
- [Traditional Chinese / 繁體中文](/i18n/README.zh-tw.md)
- [Turkish / Türkçe](/i18n/README.tr.md)
- [Ukrainian / Українська](/i18n/README.uk.md)
- [Vietnamese / Tiếng Việt](/i18n/README.vi-vn.md)
- [Çeviri listesi](/i18n/languages.md) <!--- Sadece bunu bırakın -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---