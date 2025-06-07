<p align="center">
<img src="https://user-images.githubusercontent.com/8291514/213727234-cda046d6-28c6-491a-b284-b86c5cede25d.png#gh-light-mode-only">
<img src="https://user-images.githubusercontent.com/8291514/213727225-56186826-bee8-43b5-9b15-86e839d89393.png#gh-dark-mode-only">
</p>

# سوپ‌بیس

[سوپ‌بیس](https://supabase.com) یک جایگزین متن‌باز برای Firebase است. ما در حال ساخت ویژگی‌های Firebase با استفاده از ابزارهای متن‌باز در سطح سازمانی هستیم.

- [x] پایگاه داده میزبانی‌شده Postgres. [مستندات](https://supabase.com/docs/guides/database)
- [x] احراز هویت و مجوزدهی. [مستندات](https://supabase.com/docs/guides/auth)
- [x] APIهای خودکار تولید شده.
  - [x] REST. [مستندات](https://supabase.com/docs/guides/api)
  - [x] GraphQL. [مستندات](https://supabase.com/docs/guides/graphql)
  - [x] اشتراک‌های بلادرنگ. [مستندات](https://supabase.com/docs/guides/realtime)
- [x] توابع.
  - [x] توابع پایگاه داده. [مستندات](https://supabase.com/docs/guides/database/functions)
  - [x] توابع Edge [مستندات](https://supabase.com/docs/guides/functions)
- [x] ذخیره‌سازی فایل. [مستندات](https://supabase.com/docs/guides/storage)
- [x] جعبه‌ابزار هوش مصنوعی + وکتور/جاسازی. [مستندات](https://supabase.com/docs/guides/ai)
- [x] داشبورد

![داشبورد سوپ‌بیس](https://raw.githubusercontent.com/supabase/supabase/master/apps/www/public/images/github/supabase-dashboard.png)

برای دریافت اعلان به‌روزرسانی‌های مهم، "releases" این مخزن را دنبال کنید.

<kbd><img src="https://raw.githubusercontent.com/supabase/supabase/d5f7f413ab356dc1a92075cb3cee4e40a957d5b1/web/static/watch-repo.gif" alt="Watch this repo"/></kbd>

## مستندات

برای مشاهده مستندات کامل، به [supabase.com/docs](https://supabase.com/docs) مراجعه کنید.

برای مشاهده نحوه مشارکت، به [شروع کار](./DEVELOPERS.md) مراجعه کنید.

## جامعه و پشتیبانی

- [فروم جامعه](https://github.com/supabase/supabase/discussions). بهترین برای: کمک در توسعه، گفتگو درباره بهترین شیوه‌های پایگاه داده.
- [مسائل گیت‌هاب](https://github.com/supabase/supabase/issues). بهترین برای: خطاها و باگ‌هایی که هنگام استفاده از سوپ‌بیس با آن مواجه می‌شوید.
- [پشتیبانی ایمیلی](https://supabase.com/docs/support#business-support). بهترین برای: مشکلات مربوط به پایگاه داده یا زیرساخت شما.
- [دیسکورد](https://discord.supabase.com). بهترین برای: اشتراک‌گذاری برنامه‌های خود و تعامل با جامعه.

## چگونه کار می‌کند

سوپ‌بیس ترکیبی از ابزارهای متن‌باز است. ما ویژگی‌های Firebase را با محصولات متن‌باز در سطح سازمانی می‌سازیم. اگر ابزارها و جوامع مربوطه با مجوز MIT، Apache 2 یا مشابه وجود داشته باشند، آن ابزار را استفاده و پشتیبانی می‌کنیم. اگر ابزار وجود نداشته باشد، خودمان آن را می‌سازیم و متن‌باز می‌کنیم. سوپ‌بیس معادل یک‌به‌یک Firebase نیست. هدف ما ارائه تجربه توسعه‌ای مشابه Firebase با استفاده از ابزارهای متن‌باز است.

**معماری**

سوپ‌بیس یک [پلتفرم میزبانی‌شده](https://supabase.com/dashboard) است. شما می‌توانید ثبت‌نام کنید و بدون نیاز به نصب چیزی، از سوپ‌بیس استفاده کنید.
همچنین می‌توانید [خود میزبانی](https://supabase.com/docs/guides/hosting/overview) کنید و [به‌صورت محلی توسعه دهید](https://supabase.com/docs/guides/local-development).

![معماری](apps/docs/public/img/supabase-architecture.svg)

- [Postgres](https://www.postgresql.org/) یک سیستم پایگاه داده شی‌ء-رابطه‌ای است با بیش از ۳۰ سال توسعه فعال که اعتبار زیادی در پایداری، غنای ویژگی‌ها و عملکرد کسب کرده است.
- [Realtime](https://github.com/supabase/realtime) یک سرور Elixir است که به شما امکان می‌دهد با استفاده از websockets به درج، به‌روزرسانی و حذف‌های PostgreSQL گوش دهید. Realtime از قابلیت replication داخلی Postgres برای پیگیری تغییرات پایگاه داده استفاده می‌کند، تغییرات را به JSON تبدیل کرده و آن را از طریق websockets به مشتریان مجاز ارسال می‌کند.
- [PostgREST](http://postgrest.org/) یک سرور وب است که پایگاه داده PostgreSQL شما را مستقیماً به یک API RESTful تبدیل می‌کند.
- [GoTrue](https://github.com/supabase/gotrue) یک API احراز هویت مبتنی بر JWT است که ثبت‌نام، ورود و مدیریت نشست کاربران در برنامه‌های شما را ساده می‌کند.
- [Storage](https://github.com/supabase/storage-api) یک API RESTful برای مدیریت فایل‌ها در S3 است که مجوزها را Postgres مدیریت می‌کند.
- [pg_graphql](http://github.com/supabase/pg_graphql/) یک افزونه PostgreSQL که یک API GraphQL ارائه می‌دهد.
- [postgres-meta](https://github.com/supabase/postgres-meta) یک API RESTful برای مدیریت Postgres است که امکان دریافت جداول، افزودن نقش‌ها، اجرای کوئری و غیره را فراهم می‌کند.
- [Kong](https://github.com/Kong/kong) یک دروازه API بومی ابری است.

#### کتابخانه‌های کلاینت

رویکرد ما برای کتابخانه‌های کلاینت ماژولار است. هر زیرکتابخانه یک پیاده‌سازی مستقل برای یک سیستم خارجی است. این یکی از روش‌های پشتیبانی ما از ابزارهای موجود است.

<table style="table-layout:fixed; white-space: nowrap;">
  <tr>
    <th>زبان</th>
    <th>کلاینت</th>
    <th colspan="5">کلاینت‌های ویژگی (در کلاینت Supabase تجمیع شده)</th>
  </tr>
  <!-- notranslate -->
  <tr>
    <th></th>
    <th>Supabase</th>
    <th><a href="https://github.com/postgrest/postgrest" target="_blank" rel="noopener noreferrer">PostgREST</a></th>
    <th><a href="https://github.com/supabase/gotrue" target="_blank" rel="noopener noreferrer">GoTrue</a></th>
    <th><a href="https://github.com/supabase/realtime" target="_blank" rel="noopener noreferrer">Realtime</a></th>
    <th><a href="https://github.com/supabase/storage-api" target="_blank" rel="noopener noreferrer">Storage</a></th>
    <th>Functions</th>
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
  <th colspan="7">⚡️ رسمی ⚡️</th>
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
  <th colspan="7">💚 جامعه 💚</th>
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

<!--- این فهرست را اگر به زبان دیگری ترجمه می‌کنید حذف کنید، به‌روزرسانی آن در چندین فایل دشوار است-->
<!--- فقط پیوند به فهرست فایل‌های ترجمه را نگه دارید-->

## نشان‌ها

![ساخته شده با سوپ‌بیس](./apps/www/public/badge-made-with-supabase.svg)

```md
[![ساخته شده با سوپ‌بیس](https://supabase.com/badge-made-with-supabase.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase.svg"
    alt="ساخته شده با سوپ‌بیس"
  />
</a>
```

![ساخته شده با سوپ‌بیس (تیره)](./apps/www/public/badge-made-with-supabase-dark.svg)

```md
[![ساخته شده با سوپ‌بیس](https://supabase.com/badge-made-with-supabase-dark.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase-dark.svg"
    alt="ساخته شده با سوپ‌بیس"
  />
</a>
```

## ترجمه‌ها

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
- [فهرست ترجمه‌ها](/i18n/languages.md) <!--- فقط این را نگه دارید -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---