<p align="center">
<img src="https://user-images.githubusercontent.com/8291514/213727234-cda046d6-28c6-491a-b284-b86c5cede25d.png#gh-light-mode-only">
<img src="https://user-images.githubusercontent.com/8291514/213727225-56186826-bee8-43b5-9b15-86e839d89393.png#gh-dark-mode-only">
</p>

# Supabase

[Supabase](https://supabase.com) is een open source alternatief voor Firebase. Wij bouwen de functionaliteiten van Firebase met behulp van open source tools van ondernemingsniveau.

- [x] Gehoste Postgres Database. [Docs](https://supabase.com/docs/guides/database)
- [x] Authenticatie en Autorisatie. [Docs](https://supabase.com/docs/guides/auth)
- [x] Automatisch gegenereerde API’s.
  - [x] REST. [Docs](https://supabase.com/docs/guides/api)
  - [x] GraphQL. [Docs](https://supabase.com/docs/guides/graphql)
  - [x] Realtime abonnementen. [Docs](https://supabase.com/docs/guides/realtime)
- [x] Functies.
  - [x] Databasefuncties. [Docs](https://supabase.com/docs/guides/database/functions)
  - [x] Edge Functies [Docs](https://supabase.com/docs/guides/functions)
- [x] Bestandsopslag. [Docs](https://supabase.com/docs/guides/storage)
- [x] AI + Vector/Embeddings Toolkit. [Docs](https://supabase.com/docs/guides/ai)
- [x] Dashboard

![Supabase Dashboard](https://raw.githubusercontent.com/supabase/supabase/master/apps/www/public/images/github/supabase-dashboard.png)

Volg de "releases" van deze repository om op de hoogte te blijven van belangrijke updates.

<kbd><img src="https://raw.githubusercontent.com/supabase/supabase/d5f7f413ab356dc1a92075cb3cee4e40a957d5b1/web/static/watch-repo.gif" alt="Watch this repo"/></kbd>

## Documentatie

Voor de volledige documentatie, bezoek [supabase.com/docs](https://supabase.com/docs)

Wil je bijdragen? Bekijk dan [Aan de slag](./DEVELOPERS.md)

## Community & Ondersteuning

- [Community Forum](https://github.com/supabase/supabase/discussions). Beste voor: hulp bij het bouwen, discussie over database best practices.
- [GitHub Issues](https://github.com/supabase/supabase/issues). Beste voor: bugs en fouten die je tegenkomt bij het gebruik van Supabase.
- [E-mailondersteuning](https://supabase.com/docs/support#business-support). Beste voor: problemen met je database of infrastructuur.
- [Discord](https://discord.supabase.com). Beste voor: het delen van je applicaties en contact met de community.

## Hoe het werkt

Supabase is een combinatie van open source tools. Wij bouwen de functionaliteiten van Firebase met open source producten van ondernemingsniveau. Als de tools en communities bestaan met een MIT-, Apache 2- of een gelijkwaardige open licentie, gebruiken en ondersteunen we die tool. Als de tool niet bestaat, bouwen en open-sourcen we deze zelf. Supabase is geen 1-op-1 kopie van Firebase. Ons doel is ontwikkelaars een Firebase-achtige ervaring te bieden met open source tools.

**Architectuur**

Supabase is een [gehost platform](https://supabase.com/dashboard). Je kunt je aanmelden en Supabase direct gebruiken zonder iets te installeren.
Je kunt ook [zelf hosten](https://supabase.com/docs/guides/hosting/overview) en [lokaal ontwikkelen](https://supabase.com/docs/guides/local-development).

![Architectuur](apps/docs/public/img/supabase-architecture.svg)

- [Postgres](https://www.postgresql.org/) is een object-relationeel databasesysteem met meer dan 30 jaar actieve ontwikkeling, bekend om zijn betrouwbaarheid, uitgebreide functionaliteit en prestaties.
- [Realtime](https://github.com/supabase/realtime) is een Elixir-server waarmee je kunt luisteren naar PostgreSQL-inserts, -updates en -deletes via websockets. Realtime gebruikt de ingebouwde replicatiefunctie van Postgres om databasewijzigingen te volgen, converteert deze naar JSON en verstuurt de JSON via websockets naar geautoriseerde clients.
- [PostgREST](http://postgrest.org/) is een webserver die je PostgreSQL-database direct omzet in een RESTful API.
- [GoTrue](https://github.com/supabase/gotrue) is een op JWT gebaseerde authenticatie-API die het aanmelden, inloggen en sessiebeheer in je applicaties vereenvoudigt.
- [Storage](https://github.com/supabase/storage-api) is een RESTful API voor het beheren van bestanden in S3, waarbij Postgres de permissies beheert.
- [pg_graphql](http://github.com/supabase/pg_graphql/) is een PostgreSQL-extensie die een GraphQL API biedt.
- [postgres-meta](https://github.com/supabase/postgres-meta) is een RESTful API voor het beheren van je Postgres, waarmee je tabellen kunt ophalen, rollen toevoegen, queries uitvoeren, enz.
- [Kong](https://github.com/Kong/kong) is een cloud-native API-gateway.

#### Clientbibliotheken

Onze aanpak voor clientbibliotheken is modulair. Elke subbibliotheek is een zelfstandige implementatie voor een enkel extern systeem. Dit is één van de manieren waarop we bestaande tools ondersteunen.

<table style="table-layout:fixed; white-space: nowrap;">
  <tr>
    <th>Taal</th>
    <th>Client</th>
    <th colspan="5">Feature-Clients (meegeleverd in Supabase client)</th>
  </tr>
  <!-- notranslate -->
  <tr>
    <th></th>
    <th>Supabase</th>
    <th><a href="https://github.com/postgrest/postgrest" target="_blank" rel="noopener noreferrer">PostgREST</a></th>
    <th><a href="https://github.com/supabase/gotrue" target="_blank" rel="noopener noreferrer">GoTrue</a></th>
    <th><a href="https://github.com/supabase/realtime" target="_blank" rel="noopener noreferrer">Realtime</a></th>
    <th><a href="https://github.com/supabase/storage-api" target="_blank" rel="noopener noreferrer">Storage</a></th>
    <th>Functies</th>
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
  <th colspan="7">⚡️ Officieel ⚡️</th>
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
  <th colspan="7">💚 Community 💚</th>
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

<!--- Verwijder deze lijst als je naar een andere taal vertaalt, het is lastig om deze up-to-date te houden in meerdere bestanden-->
<!--- Behoud alleen de link naar de lijst met vertaalbestanden-->

## Badges

![Gemaakt met Supabase](./apps/www/public/badge-made-with-supabase.svg)

```md
[![Gemaakt met Supabase](https://supabase.com/badge-made-with-supabase.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase.svg"
    alt="Gemaakt met Supabase"
  />
</a>
```

![Gemaakt met Supabase (donker)](./apps/www/public/badge-made-with-supabase-dark.svg)

```md
[![Gemaakt met Supabase](https://supabase.com/badge-made-with-supabase-dark.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase-dark.svg"
    alt="Gemaakt met Supabase"
  />
</a>
```

## Vertalingen

- [Arabic | العربية](/i18n/README.ar.md)
- [Albanees / Shqip](/i18n/README.sq.md)
- [Bengaals / বাংলা](/i18n/README.bn.md)
- [Bulgaars / Български](/i18n/README.bg.md)
- [Catalaans / Català](/i18n/README.ca.md)
- [Tsjechisch / čeština](/i18n/README.cs.md)
- [Deens / Dansk](/i18n/README.da.md)
- [Nederlands](/i18n/README.nl.md)
- [Engels](https://github.com/supabase/supabase)
- [Ests / eesti keel](/i18n/README.et.md)
- [Fins / Suomalainen](/i18n/README.fi.md)
- [Frans / Français](/i18n/README.fr.md)
- [Duits / Deutsch](/i18n/README.de.md)
- [Grieks / Ελληνικά](/i18n/README.el.md)
- [Gujarati / ગુજરાતી](/i18n/README.gu.md)
- [Hebreeuws / עברית](/i18n/README.he.md)
- [Hindi / हिंदी](/i18n/README.hi.md)
- [Hongaars / Magyar](/i18n/README.hu.md)
- [Nepalees / नेपाली](/i18n/README.ne.md)
- [Indonesisch / Bahasa Indonesia](/i18n/README.id.md)
- [Italiaans / Italiano](/i18n/README.it.md)
- [Japans / 日本語](/i18n/README.jp.md)
- [Koreaans / 한국어](/i18n/README.ko.md)
- [Litouws / lietuvių](/i18n/README.lt.md)
- [Lets / latviski](/i18n/README.lv.md)
- [Maleis / Bahasa Malaysia](/i18n/README.ms.md)
- [Noors (Bokmål) / Norsk (Bokmål)](/i18n/README.nb.md)
- [Perzisch / فارسی](/i18n/README.fa.md)
- [Pools / Polski](/i18n/README.pl.md)
- [Portugees / Português](/i18n/README.pt.md)
- [Braziliaans Portugees / Português Brasileiro](/i18n/README.pt-br.md)
- [Roemeens / Română](/i18n/README.ro.md)
- [Russisch / Pусский](/i18n/README.ru.md)
- [Servisch / Srpski](/i18n/README.sr.md)
- [Singalees / සිංහල](/i18n/README.si.md)
- [Slowaaks / slovenský](/i18n/README.sk.md)
- [Sloveens / Slovenščina](/i18n/README.sl.md)
- [Spaans / Español](/i18n/README.es.md)
- [Vereenvoudigd Chinees / 简体中文](/i18n/README.zh-cn.md)
- [Zweeds / Svenska](/i18n/README.sv.md)
- [Thais / ไทย](/i18n/README.th.md)
- [Traditioneel Chinees / 繁體中文](/i18n/README.zh-tw.md)
- [Turks / Türkçe](/i18n/README.tr.md)
- [Oekraïens / Українська](/i18n/README.uk.md)
- [Vietnamees / Tiếng Việt](/i18n/README.vi-vn.md)
- [Lijst van vertalingen](/i18n/languages.md) <!--- Alleen deze behouden -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---