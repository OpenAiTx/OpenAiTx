<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

Eine selbstgehostete, datenschutzorientierte Alternative zu MyFitnessPal. Verfolge Ernährung, Training, Körperwerte und Gesundheitsdaten und behalte die volle Kontrolle über deine Daten.

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness ist eine selbstgehostete Fitness-Tracking-Plattform, die aus folgenden Komponenten besteht:

- Einem Backend-Server (API + Datenspeicherung)
- Einem webbasierten Frontend
- Native mobile Apps für iOS und Android

Es speichert und verwaltet Gesundheitsdaten auf einer von Ihnen kontrollierten Infrastruktur, ohne auf Drittanbieterdienste angewiesen zu sein.

## Kernfunktionen

- Nachverfolgung von Ernährung, Bewegung, Flüssigkeitszufuhr, Schlaf, Fasten, Stimmung und Körpermaßen
- Zielsetzung und tägliche Check-ins
- Interaktive Diagramme und Langzeitberichte
- Mehrere Benutzerprofile und Familienzugang
- Helle und dunkle Designs
- OIDC, TOTP, Passkey, MFA usw.

## Gesundheits- & Geräteintegrationen

SparkyFitness kann Daten von mehreren Gesundheits- und Fitnessplattformen synchronisieren:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (teilweise getestet)
- **Hevy** (nicht getestet)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (teilweise getestet)

Integrationen synchronisieren automatisch Aktivitätsdaten wie Schritte, Workouts und Schlaf sowie Gesundheitsmetriken wie Gewicht und Körpermaße mit Ihrem SparkyFitness-Server.

## Optionale KI-Funktionen (Beta)

SparkyAI bietet eine konversationsbasierte Oberfläche zum Protokollieren von Daten und Überprüfen des Fortschritts.

- Protokollieren Sie Essen, Bewegung, Körperwerte und Schritte über den Chat
- Laden Sie Essensbilder für die automatische Mahlzeitenprotokollierung hoch
- Behaltet den Gesprächsverlauf für Nachverfolgungen bei

Hinweis: KI-Funktionen befinden sich derzeit in der Beta-Phase.

## Schnellstart (Server)

Bringen Sie einen SparkyFitness-Server in wenigen Minuten mit Docker Compose zum Laufen.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 🎥 Videoanleitung

[![Video ansehen](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

Kurzes 2-Minuten-Tutorial, das zeigt, wie man SparkyFitness (selbstgehosteter Fitness-Tracker) installiert.


## Dokumentation

Für vollständige Installationsanleitungen, Konfigurationsoptionen und Entwicklerdokumentation besuchen Sie bitte unsere [Dokumentationsseite](https://codewithcj.github.io/SparkyFitness/).

### Schnellzugriffe

- **[Installationsanleitung](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - Bereitstellung und Konfigurationen
- **[Funktionsübersicht](https://codewithcj.github.io/SparkyFitness/features)** - Vollständige Funktionsdokumentation
- **[Entwicklungsablauf](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Entwicklerleitfaden und Beitrag-Prozess
- **[iOS App Info](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** und **[Android App Info](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### Benötigen Sie Hilfe?

- Erstellen Sie ein Thema in Github Issues/Discussion.
- Für schnellere Antworten und um Hilfe von anderen Community-Mitgliedern zu erhalten **[Treten Sie unserem Discord bei](https://discord.gg/vcnMT5cPEA)**

## Sterne-Historie

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Sterne-Historie Diagramm" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Übersetzungen

**[Weblate Übersetzungen](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">

<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Übersetzungsstatus" />
</a>

## Repository-Aktivität

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats Analysebild")

## Mitwirkende

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Bekannte Probleme / Beta-Features ⚠️

SparkyFitness befindet sich in aktiver Entwicklung.
Zwischen Releases können breaking changes auftreten.

- Automatische Updates von Containern werden nicht empfohlen
- Überprüfen Sie immer die Release Notes, bevor Sie ein Upgrade durchführen

Die folgenden Funktionen befinden sich derzeit in der Beta-Phase und wurden möglicherweise noch nicht gründlich getestet. Es können Fehler oder unvollständige Funktionen auftreten:

- KI-Chatbot
- Zugriff für Familie & Freunde
- API-Dokumentation


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---