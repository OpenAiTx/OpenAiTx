<p align="center">
<img src="https://user-images.githubusercontent.com/8291514/213727234-cda046d6-28c6-491a-b284-b86c5cede25d.png#gh-light-mode-only">
<img src="https://user-images.githubusercontent.com/8291514/213727225-56186826-bee8-43b5-9b15-86e839d89393.png#gh-dark-mode-only">
</p>

# Supabase

[Supabase](https://supabase.com) คือทางเลือกโอเพ่นซอร์สสำหรับ Firebase เรากำลังสร้างฟีเจอร์ต่าง ๆ ของ Firebase โดยใช้เครื่องมือโอเพ่นซอร์สระดับองค์กร

- [x] ฐานข้อมูล Postgres แบบโฮสต์ [เอกสาร](https://supabase.com/docs/guides/database)
- [x] การยืนยันตัวตนและการอนุญาต [เอกสาร](https://supabase.com/docs/guides/auth)
- [x] API ที่ถูกสร้างขึ้นอัตโนมัติ
  - [x] REST [เอกสาร](https://supabase.com/docs/guides/api)
  - [x] GraphQL [เอกสาร](https://supabase.com/docs/guides/graphql)
  - [x] การสมัครใช้งานแบบ Realtime [เอกสาร](https://supabase.com/docs/guides/realtime)
- [x] ฟังก์ชัน
  - [x] ฟังก์ชันฐานข้อมูล [เอกสาร](https://supabase.com/docs/guides/database/functions)
  - [x] Edge Functions [เอกสาร](https://supabase.com/docs/guides/functions)
- [x] การจัดเก็บไฟล์ [เอกสาร](https://supabase.com/docs/guides/storage)
- [x] เครื่องมือ AI + Vector/Embeddings [เอกสาร](https://supabase.com/docs/guides/ai)
- [x] แดชบอร์ด

![แดชบอร์ด Supabase](https://raw.githubusercontent.com/supabase/supabase/master/apps/www/public/images/github/supabase-dashboard.png)

ติดตาม "releases" ของ repo นี้เพื่อรับการแจ้งเตือนการอัปเดตสำคัญ

<kbd><img src="https://raw.githubusercontent.com/supabase/supabase/d5f7f413ab356dc1a92075cb3cee4e40a957d5b1/web/static/watch-repo.gif" alt="Watch this repo"/></kbd>

## เอกสาร

สำหรับเอกสารฉบับเต็ม เยี่ยมชม [supabase.com/docs](https://supabase.com/docs)

ดูวิธีการมีส่วนร่วมได้ที่ [เริ่มต้นใช้งาน](./DEVELOPERS.md)

## ชุมชน & การสนับสนุน

- [ฟอรัมชุมชน](https://github.com/supabase/supabase/discussions) เหมาะสำหรับ: ความช่วยเหลือในการสร้าง การสนทนาเกี่ยวกับแนวปฏิบัติที่ดีที่สุดของฐานข้อมูล
- [GitHub Issues](https://github.com/supabase/supabase/issues) เหมาะสำหรับ: รายงานบั๊กและข้อผิดพลาดที่คุณพบขณะใช้ Supabase
- [อีเมลซัพพอร์ต](https://supabase.com/docs/support#business-support) เหมาะสำหรับ: ปัญหาเกี่ยวกับฐานข้อมูลหรือโครงสร้างพื้นฐานของคุณ
- [Discord](https://discord.supabase.com) เหมาะสำหรับ: แชร์แอปพลิเคชันของคุณและพูดคุยกับชุมชน

## วิธีการทำงาน

Supabase คือการรวมเครื่องมือโอเพ่นซอร์สหลายตัว เรากำลังสร้างฟีเจอร์ต่าง ๆ ของ Firebase โดยใช้ผลิตภัณฑ์โอเพ่นซอร์สระดับองค์กร หากมีเครื่องมือและชุมชนที่ใช้ไลเซนส์ MIT, Apache 2 หรือโอเพ่นไลเซนส์ที่เทียบเท่า เราจะใช้และสนับสนุนเครื่องมือนั้น หากไม่มีเครื่องมือดังกล่าว เราจะสร้างและเปิดซอร์สด้วยตนเอง Supabase ไม่ใช่การเทียบเท่าแบบ 1-ต่อ-1 กับ Firebase เป้าหมายของเราคือมอบประสบการณ์นักพัฒนาคล้าย Firebase ด้วยเครื่องมือโอเพ่นซอร์ส

**สถาปัตยกรรม**

Supabase คือ [แพลตฟอร์มแบบโฮสต์](https://supabase.com/dashboard) คุณสามารถลงทะเบียนและเริ่มใช้ Supabase ได้โดยไม่ต้องติดตั้งอะไร
คุณยังสามารถ [โฮสต์เอง](https://supabase.com/docs/guides/hosting/overview) และ [พัฒนาแบบโลคอล](https://supabase.com/docs/guides/local-development) ได้เช่นกัน

![Architecture](apps/docs/public/img/supabase-architecture.svg)

- [Postgres](https://www.postgresql.org/) เป็นระบบฐานข้อมูลออปเจ็กต์-รีเลชันนัลที่มีการพัฒนามากกว่า 30 ปี ได้รับชื่อเสียงด้านความน่าเชื่อถือ ความแข็งแกร่งของฟีเจอร์ และประสิทธิภาพ
- [Realtime](https://github.com/supabase/realtime) เป็นเซิร์ฟเวอร์ Elixir ที่ช่วยให้คุณสามารถฟังการแทรก อัปเดต และลบข้อมูลใน PostgreSQL ผ่าน websockets โดย Realtime จะสำรวจฟังก์ชัน replication ที่มีอยู่ใน Postgres สำหรับการเปลี่ยนแปลงในฐานข้อมูล แปลงการเปลี่ยนแปลงเป็น JSON และส่งออก JSON ผ่าน websockets ไปยังไคลเอนต์ที่ได้รับอนุญาต
- [PostgREST](http://postgrest.org/) เป็นเว็บเซิร์ฟเวอร์ที่เปลี่ยนฐานข้อมูล PostgreSQL ของคุณให้เป็น RESTful API โดยตรง
- [GoTrue](https://github.com/supabase/gotrue) คือ API การยืนยันตัวตนแบบ JWT ที่ช่วยให้ง่ายต่อการสมัครสมาชิก ล็อกอิน และจัดการเซสชันในแอปพลิเคชันของคุณ
- [Storage](https://github.com/supabase/storage-api) คือ RESTful API สำหรับจัดการไฟล์ใน S3 โดย Postgres ดูแลสิทธิ์ในการเข้าถึง
- [pg_graphql](http://github.com/supabase/pg_graphql/) เป็นส่วนเสริมของ PostgreSQL ที่เปิดเผย GraphQL API
- [postgres-meta](https://github.com/supabase/postgres-meta) คือ RESTful API สำหรับจัดการ Postgres ของคุณ ช่วยให้คุณดึงตาราง เพิ่มบทบาท และรันคำสั่ง query ฯลฯ
- [Kong](https://github.com/Kong/kong) คือ cloud-native API gateway

#### ไลบรารีไคลเอนต์

แนวทางของเราสำหรับไลบรารีไคลเอนต์คือแบบโมดูลาร์ ไลบรารีย่อยแต่ละตัวเป็นการติดตั้งแบบ standalone สำหรับระบบภายนอกแต่ละระบบ นี่คือหนึ่งในวิธีที่เราสนับสนุนเครื่องมือที่มีอยู่

<table style="table-layout:fixed; white-space: nowrap;">
  <tr>
    <th>ภาษา</th>
    <th>ไคลเอนต์</th>
    <th colspan="5">Feature-Clients (ถูกรวมใน Supabase client)</th>
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
  <th colspan="7">⚡️ Official ⚡️</th>
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
  <th colspan="7">💚 ชุมชน 💚</th>
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

<!--- Remove this list if you're translating to another language, it's hard to keep updated across multiple files-->
<!--- Keep only the link to the list of translation files-->

## ป้าย (Badges)

![สร้างด้วย Supabase](./apps/www/public/badge-made-with-supabase.svg)

```md
[![Made with Supabase](https://supabase.com/badge-made-with-supabase.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase.svg"
    alt="Made with Supabase"
  />
</a>
```

![สร้างด้วย Supabase (dark)](./apps/www/public/badge-made-with-supabase-dark.svg)

```md
[![Made with Supabase](https://supabase.com/badge-made-with-supabase-dark.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase-dark.svg"
    alt="Made with Supabase"
  />
</a>
```

## การแปลภาษา

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
- [รายการการแปลภาษา](/i18n/languages.md) <!--- Keep only this -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---