<p align="center">
<img src="https://user-images.githubusercontent.com/8291514/213727234-cda046d6-28c6-491a-b284-b86c5cede25d.png#gh-light-mode-only">
<img src="https://user-images.githubusercontent.com/8291514/213727225-56186826-bee8-43b5-9b15-86e839d89393.png#gh-dark-mode-only">
</p>

# सुपाबेस

[Supabase](https://supabase.com) एक ओपन सोर्स Firebase विकल्प है। हम Firebase की सुविधाओं को एंटरप्राइज-ग्रेड ओपन सोर्स टूल्स का उपयोग करके बना रहे हैं।

- [x] होस्टेड Postgres डेटाबेस। [Docs](https://supabase.com/docs/guides/database)
- [x] प्रमाणीकरण और प्राधिकरण। [Docs](https://supabase.com/docs/guides/auth)
- [x] ऑटो-जनरेटेड APIs।
  - [x] REST। [Docs](https://supabase.com/docs/guides/api)
  - [x] GraphQL। [Docs](https://supabase.com/docs/guides/graphql)
  - [x] रियलटाइम सब्सक्रिप्शन। [Docs](https://supabase.com/docs/guides/realtime)
- [x] फंक्शन्स।
  - [x] डेटाबेस फंक्शन्स। [Docs](https://supabase.com/docs/guides/database/functions)
  - [x] एज फंक्शन्स [Docs](https://supabase.com/docs/guides/functions)
- [x] फाइल स्टोरेज। [Docs](https://supabase.com/docs/guides/storage)
- [x] एआई + वेक्टर/एम्बेडिंग्स टूलकिट। [Docs](https://supabase.com/docs/guides/ai)
- [x] डैशबोर्ड

![Supabase Dashboard](https://raw.githubusercontent.com/supabase/supabase/master/apps/www/public/images/github/supabase-dashboard.png)

इस रिपॉजिटरी के "releases" को वॉच करें ताकि आपको मुख्य अपडेट्स की सूचना मिल सके।

<kbd><img src="https://raw.githubusercontent.com/supabase/supabase/d5f7f413ab356dc1a92075cb3cee4e40a957d5b1/web/static/watch-repo.gif" alt="Watch this repo"/></kbd>

## प्रलेखन (Documentation)

पूर्ण दस्तावेज़ के लिए, [supabase.com/docs](https://supabase.com/docs) पर जाएँ

योगदान कैसे करें जानने के लिए, [Getting Started](./DEVELOPERS.md) देखें

## समुदाय और सहायता

- [कम्युनिटी फोरम](https://github.com/supabase/supabase/discussions)। सर्वोत्तम: निर्माण में सहायता, डेटाबेस सर्वोत्तम प्रथाओं पर चर्चा।
- [GitHub Issues](https://github.com/supabase/supabase/issues)। सर्वोत्तम: Supabase का उपयोग करते समय आए बग्स और त्रुटियाँ।
- [ईमेल सहायता](https://supabase.com/docs/support#business-support)। सर्वोत्तम: आपके डेटाबेस या इन्फ्रास्ट्रक्चर की समस्याएँ।
- [Discord](https://discord.supabase.com)। सर्वोत्तम: अपने अनुप्रयोग साझा करना और समुदाय के साथ जुड़ना।

## यह कैसे काम करता है

Supabase ओपन सोर्स टूल्स का एक संयोजन है। हम एंटरप्राइज-ग्रेड, ओपन सोर्स उत्पादों का उपयोग करके Firebase की सुविधाएँ बना रहे हैं। यदि उपकरण और समुदाय MIT, Apache 2, या समान ओपन लाइसेंस के साथ मौजूद हैं, तो हम उस टूल का उपयोग और समर्थन करेंगे। यदि टूल मौजूद नहीं है, तो हम उसे स्वयं बनाते हैं और ओपन सोर्स करते हैं। Supabase, Firebase का 1-से-1 मैपिंग नहीं है। हमारा उद्देश्य डेवलपर्स को ओपन सोर्स टूल्स का उपयोग करते हुए Firebase जैसा डेवलपर अनुभव देना है।

**आर्किटेक्चर**

Supabase एक [होस्टेड प्लेटफ़ॉर्म](https://supabase.com/dashboard) है। आप साइन अप करके Supabase का उपयोग शुरू कर सकते हैं, बिना कुछ इंस्टॉल किए।
आप [स्व-होस्टिंग](https://supabase.com/docs/guides/hosting/overview) और [स्थानीय रूप से विकास](https://supabase.com/docs/guides/local-development) भी कर सकते हैं।

![Architecture](apps/docs/public/img/supabase-architecture.svg)

- [Postgres](https://www.postgresql.org/) एक ऑब्जेक्ट-रिलेशनल डेटाबेस सिस्टम है, जिसमें 30 वर्षों से अधिक का सक्रिय विकास हुआ है, जिससे इसे विश्वसनीयता, फीचर मजबूती और प्रदर्शन के लिए मजबूत प्रतिष्ठा मिली है।
- [Realtime](https://github.com/supabase/realtime) एक Elixir सर्वर है जो आपको PostgreSQL में insert, update, और delete को वेब-सॉकेट्स के माध्यम से सुनने की अनुमति देता है। Realtime, Postgres की बिल्ट-इन रेप्लिकेशन कार्यक्षमता से बदलावों को प्राप्त करता है, बदलावों को JSON में बदलता है, फिर अधिकृत क्लाइंट्स को वेब-सॉकेट्स के माध्यम से JSON प्रसारित करता है।
- [PostgREST](http://postgrest.org/) एक वेब सर्वर है जो आपके PostgreSQL डेटाबेस को सीधे RESTful API में बदल देता है।
- [GoTrue](https://github.com/supabase/gotrue) एक JWT आधारित प्रमाणीकरण API है, जो आपके अनुप्रयोगों में उपयोगकर्ता साइन-अप, लॉगिन और सत्र प्रबंधन को सरल बनाता है।
- [Storage](https://github.com/supabase/storage-api) S3 में फाइल्स प्रबंधित करने के लिए एक RESTful API है, जिसमें अनुमति प्रबंधन Postgres द्वारा किया जाता है।
- [pg_graphql](http://github.com/supabase/pg_graphql/) एक PostgreSQL एक्सटेंशन है जो GraphQL API प्रदान करता है।
- [postgres-meta](https://github.com/supabase/postgres-meta) आपके Postgres को प्रबंधित करने के लिए एक RESTful API है, जिससे आप टेबल्स प्राप्त कर सकते हैं, रोल्स जोड़ सकते हैं, क्वेरी चला सकते हैं आदि।
- [Kong](https://github.com/Kong/kong) एक क्लाउड-नेटिव API गेटवे है।

#### क्लाइंट लाइब्रेरीज़

हमारा क्लाइंट लाइब्रेरीज़ के लिए दृष्टिकोण मॉड्यूलर है। प्रत्येक सब-लाइब्रेरी एकल बाहरी सिस्टम के लिए स्वतंत्र कार्यान्वयन है। यह मौजूदा टूल्स को समर्थन देने के हमारे तरीकों में से एक है।

<table style="table-layout:fixed; white-space: nowrap;">
  <tr>
    <th>भाषा</th>
    <th>क्लाइंट</th>
    <th colspan="5">फीचर-क्लाइंट्स (Supabase क्लाइंट में बंडल्ड)</th>
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
  <th colspan="7">⚡️ आधिकारिक ⚡️</th>
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
  <th colspan="7">💚 समुदाय 💚</th>
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

## बैजेस

![Made with Supabase](./apps/www/public/badge-made-with-supabase.svg)

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

![Made with Supabase (dark)](./apps/www/public/badge-made-with-supabase-dark.svg)

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

## अनुवाद

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
- [List of translations](/i18n/languages.md) <!--- Keep only this -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---