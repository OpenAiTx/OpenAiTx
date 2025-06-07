<p align="center">
<img src="https://user-images.githubusercontent.com/8291514/213727234-cda046d6-28c6-491a-b284-b86c5cede25d.png#gh-light-mode-only">
<img src="https://user-images.githubusercontent.com/8291514/213727225-56186826-bee8-43b5-9b15-86e839d89393.png#gh-dark-mode-only">
</p>

# Supabase

[Supabase](https://supabase.com) ist eine Open-Source-Alternative zu Firebase. Wir entwickeln die Funktionen von Firebase unter Verwendung von Enterprise-tauglichen Open-Source-Tools.

- [x] Gehostete Postgres-Datenbank. [Dokumentation](https://supabase.com/docs/guides/database)
- [x] Authentifizierung und Autorisierung. [Dokumentation](https://supabase.com/docs/guides/auth)
- [x] Automatisch generierte APIs.
  - [x] REST. [Dokumentation](https://supabase.com/docs/guides/api)
  - [x] GraphQL. [Dokumentation](https://supabase.com/docs/guides/graphql)
  - [x] Realtime-Abonnements. [Dokumentation](https://supabase.com/docs/guides/realtime)
- [x] Funktionen.
  - [x] Datenbankfunktionen. [Dokumentation](https://supabase.com/docs/guides/database/functions)
  - [x] Edge Functions [Dokumentation](https://supabase.com/docs/guides/functions)
- [x] Dateispeicherung. [Dokumentation](https://supabase.com/docs/guides/storage)
- [x] KI + Vektor/Embeddings-Toolkit. [Dokumentation](https://supabase.com/docs/guides/ai)
- [x] Dashboard

![Supabase Dashboard](https://raw.githubusercontent.com/supabase/supabase/master/apps/www/public/images/github/supabase-dashboard.png)

Beobachten Sie die "Releases" dieses Repos, um über wichtige Updates benachrichtigt zu werden.

<kbd><img src="https://raw.githubusercontent.com/supabase/supabase/d5f7f413ab356dc1a92075cb3cee4e40a957d5b1/web/static/watch-repo.gif" alt="Watch this repo"/></kbd>

## Dokumentation

Für die vollständige Dokumentation besuchen Sie [supabase.com/docs](https://supabase.com/docs)

Informationen zur Mitwirkung finden Sie unter [Erste Schritte](./DEVELOPERS.md)

## Community & Support

- [Community-Forum](https://github.com/supabase/supabase/discussions). Am besten geeignet für: Hilfe beim Entwickeln, Diskussionen über Best Practices für Datenbanken.
- [GitHub-Issues](https://github.com/supabase/supabase/issues). Am besten geeignet für: Fehler und Probleme, die bei der Nutzung von Supabase auftreten.
- [E-Mail-Support](https://supabase.com/docs/support#business-support). Am besten geeignet für: Probleme mit Ihrer Datenbank oder Infrastruktur.
- [Discord](https://discord.supabase.com). Am besten geeignet für: das Teilen Ihrer Anwendungen und Austausch mit der Community.

## Funktionsweise

Supabase ist eine Kombination aus Open-Source-Tools. Wir entwickeln die Funktionen von Firebase mit Enterprise-tauglichen Open-Source-Produkten. Wenn die Tools und Communities mit einer MIT-, Apache 2- oder einer vergleichbaren Open-Source-Lizenz existieren, verwenden und unterstützen wir dieses Tool. Falls das Tool nicht existiert, entwickeln und veröffentlichen wir es selbst als Open Source. Supabase ist kein 1-zu-1-Abbild von Firebase. Unser Ziel ist es, Entwicklern ein Firebase-ähnliches Entwicklungserlebnis mit Open-Source-Tools zu bieten.

**Architektur**

Supabase ist eine [gehostete Plattform](https://supabase.com/dashboard). Sie können sich anmelden und Supabase nutzen, ohne etwas installieren zu müssen.
Sie können Supabase auch [selbst hosten](https://supabase.com/docs/guides/hosting/overview) und [lokal entwickeln](https://supabase.com/docs/guides/local-development).

![Architektur](apps/docs/public/img/supabase-architecture.svg)

- [Postgres](https://www.postgresql.org/) ist ein objektrelationales Datenbanksystem mit über 30 Jahren aktiver Entwicklung, das sich einen hervorragenden Ruf für Zuverlässigkeit, Funktionsumfang und Performance erworben hat.
- [Realtime](https://github.com/supabase/realtime) ist ein Elixir-Server, der es ermöglicht, PostgreSQL-Inserts, -Updates und -Deletes mittels Websockets zu empfangen. Realtime nutzt die integrierte Replikationsfunktionalität von Postgres, wandelt Änderungen in JSON um und sendet diese über Websockets an autorisierte Clients.
- [PostgREST](http://postgrest.org/) ist ein Webserver, der Ihre PostgreSQL-Datenbank direkt in eine RESTful API verwandelt.
- [GoTrue](https://github.com/supabase/gotrue) ist eine JWT-basierte Authentifizierungs-API, die Benutzerregistrierung, Logins und Sitzungsmanagement in Ihren Anwendungen vereinfacht.
- [Storage](https://github.com/supabase/storage-api) ist eine RESTful-API für die Verwaltung von Dateien in S3, wobei die Berechtigungen von Postgres gesteuert werden.
- [pg_graphql](http://github.com/supabase/pg_graphql/) ist eine PostgreSQL-Erweiterung, die eine GraphQL-API bereitstellt.
- [postgres-meta](https://github.com/supabase/postgres-meta) ist eine RESTful-API zur Verwaltung von Postgres, mit der Sie Tabellen abrufen, Rollen hinzufügen, Abfragen ausführen usw. können.
- [Kong](https://github.com/Kong/kong) ist ein cloud-natives API-Gateway.

#### Client-Bibliotheken

Unser Ansatz für Client-Bibliotheken ist modular. Jede Sub-Bibliothek ist eine eigenständige Implementierung für ein externes System. Dies ist eine der Möglichkeiten, wie wir bestehende Tools unterstützen.

<table style="table-layout:fixed; white-space: nowrap;">
  <tr>
    <th>Sprache</th>
    <th>Client</th>
    <th colspan="5">Feature-Clients (im Supabase-Client gebündelt)</th>
  </tr>
  <!-- notranslate -->
  <tr>
    <th></th>
    <th>Supabase</th>
    <th><a href="https://github.com/postgrest/postgrest" target="_blank" rel="noopener noreferrer">PostgREST</a></th>
    <th><a href="https://github.com/supabase/gotrue" target="_blank" rel="noopener noreferrer">GoTrue</a></th>
    <th><a href="https://github.com/supabase/realtime" target="_blank" rel="noopener noreferrer">Realtime</a></th>
    <th><a href="https://github.com/supabase/storage-api" target="_blank" rel="noopener noreferrer">Storage</a></th>
    <th>Funktionen</th>
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
  <th colspan="7">⚡️ Offiziell ⚡️</th>
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

<!--- Entfernen Sie diese Liste, wenn Sie in eine andere Sprache übersetzen, da sie schwer aktuell zu halten ist. -->
<!--- Behalten Sie nur den Link zur Liste der Übersetzungsdateien bei. -->

## Badges

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

## Übersetzungen

- [Arabisch | العربية](/i18n/README.ar.md)
- [Albanisch / Shqip](/i18n/README.sq.md)
- [Bengalisch / বাংলা](/i18n/README.bn.md)
- [Bulgarisch / Български](/i18n/README.bg.md)
- [Katalanisch / Català](/i18n/README.ca.md)
- [Tschechisch / čeština](/i18n/README.cs.md)
- [Dänisch / Dansk](/i18n/README.da.md)
- [Niederländisch / Nederlands](/i18n/README.nl.md)
- [Englisch](https://github.com/supabase/supabase)
- [Estnisch / eesti keel](/i18n/README.et.md)
- [Finnisch / Suomalainen](/i18n/README.fi.md)
- [Französisch / Français](/i18n/README.fr.md)
- [Deutsch](/i18n/README.de.md)
- [Griechisch / Ελληνικά](/i18n/README.el.md)
- [Gujarati / ગુજરાતી](/i18n/README.gu.md)
- [Hebräisch / עברית](/i18n/README.he.md)
- [Hindi / हिंदी](/i18n/README.hi.md)
- [Ungarisch / Magyar](/i18n/README.hu.md)
- [Nepali / नेपाली](/i18n/README.ne.md)
- [Indonesisch / Bahasa Indonesia](/i18n/README.id.md)
- [Italienisch / Italiano](/i18n/README.it.md)
- [Japanisch / 日本語](/i18n/README.jp.md)
- [Koreanisch / 한국어](/i18n/README.ko.md)
- [Litauisch / lietuvių](/i18n/README.lt.md)
- [Lettisch / latviski](/i18n/README.lv.md)
- [Malaiisch / Bahasa Malaysia](/i18n/README.ms.md)
- [Norwegisch (Bokmål) / Norsk (Bokmål)](/i18n/README.nb.md)
- [Persisch / فارسی](/i18n/README.fa.md)
- [Polnisch / Polski](/i18n/README.pl.md)
- [Portugiesisch / Português](/i18n/README.pt.md)
- [Portugiesisch (Brasilien) / Português Brasileiro](/i18n/README.pt-br.md)
- [Rumänisch / Română](/i18n/README.ro.md)
- [Russisch / Pусский](/i18n/README.ru.md)
- [Serbisch / Srpski](/i18n/README.sr.md)
- [Singhalesisch / සිංහල](/i18n/README.si.md)
- [Slowakisch / slovenský](/i18n/README.sk.md)
- [Slowenisch / Slovenščina](/i18n/README.sl.md)
- [Spanisch / Español](/i18n/README.es.md)
- [Vereinfachtes Chinesisch / 简体中文](/i18n/README.zh-cn.md)
- [Schwedisch / Svenska](/i18n/README.sv.md)
- [Thailändisch / ไทย](/i18n/README.th.md)
- [Traditionelles Chinesisch / 繁體中文](/i18n/README.zh-tw.md)
- [Türkisch / Türkçe](/i18n/README.tr.md)
- [Ukrainisch / Українська](/i18n/README.uk.md)
- [Vietnamesisch / Tiếng Việt](/i18n/README.vi-vn.md)
- [Liste der Übersetzungen](/i18n/languages.md) <!--- Nur diesen Link beibehalten -->


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---