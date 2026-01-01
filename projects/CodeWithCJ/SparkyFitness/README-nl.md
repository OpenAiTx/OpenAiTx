
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Itapano</a></p>
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

# SparkyFitness - Zelfgehost alternatief voor MyFitnessPal

SparkyFitness is een uitgebreide applicatie voor fitnesstracking en -beheer, ontworpen om gebruikers te helpen hun voeding, beweging en lichaamsmetingen te monitoren. Het biedt hulpmiddelen voor dagelijkse voortgangstracking, het stellen van doelen en inzichtelijke rapporten ter ondersteuning van een gezonde levensstijl.

Documentatie: https://codewithcj.github.io/SparkyFitness

## ✨ Functies

### 🍎 Voedingsregistratie

* **Log uw dagelijkse maaltijden**
* **Maak en beheer aangepaste voedingsmiddelen en categorieën**
* **Bekijk samenvattingen en analyseer trends met interactieve grafieken**

### 💪 Oefening Loggen

* **Registreer uw workouts**
* **Blader door en zoek in een uitgebreide oefeningendatabase**
* **Volg fitnessvoortgang in de tijd**

### 💧 Waterinname Monitoren

* **Volg dagelijkse hydratatiedoelen**
* **Eenvoudig en snel water loggen**

### 📏 Lichaamsmetingen

* **Registreer lichaamsmaten** (bijv. gewicht, taille, armen)
* **Voeg aangepaste metingstypen toe**
* **Visualiseer voortgang via grafieken**

### 🎯 Doelen Stellen

* **Stel en beheer fitness- en voedingsdoelen**
* **Volg voortgang in de tijd**

### 🗓️ Dagelijkse Check-ins

* **Monitor dagelijkse activiteit**
* **Blijf consistent met gewoonte-tracking**

### 🤖 AI Voedingscoach (SparkyAI)

* **Log voedsel, oefeningen, lichaamsstatistieken en stappen via chat**
* **Upload voedselafbeeldingen om automatisch maaltijden te loggen**
* **Inclusief chatgeschiedenis en gepersonaliseerd advies**

### 🔒 Gebruikersauthenticatie & Profielen

* **Beveiligd inlogsysteem**
* **Schakel tussen gebruikersprofielen**
* **Ondersteuning voor gezins­toegang en beheer**

### 📊 Uitgebreide Rapporten

* **Genereer samenvattingen voor voeding en lichaams­metingen**
* **Volg langetermijntrends over weken of maanden**

### 🎨 Aanpasbare Thema's

* **Schakel tussen lichte en donkere modus**
* **Ontworpen met een minimalistische, afleidingsvrije interface**

### Hulp Nodig?
* **Word lid van Discord**
  https://discord.gg/vcnMT5cPEA
* **Plaats een bericht in de discussie**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)

## � Snel Starten

Heb SparkyFitness binnen enkele minuten draaiende:

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -o docker-compose.yml https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/docker-compose.prod.yml
curl -o .env https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/.env.example

# 3. (Optional) Edit .env to customize your setup
# e.g., update database credentials, ports, etc.
# if you require Gamrin integration, uncomment Garmin section from compose file.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 📖 Documentatie

Voor volledige installatiehandleidingen, ontwikkelomgevingen en gebruiksinstructies, bezoek onze uitgebreide documentatie:

**👉 [SparkyFitness Documentatiesite](https://codewithcj.github.io/SparkyFitness)**

### Snelle links

- **[🚀 Aan de slag](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Volledige installatiegids voor ontwikkeling en productie
- **[🐳 Docker Gids](https://codewithcj.github.io/SparkyFitness/developer/docker)** - Docker implementatie en configuratie
- **[🔧 Ontwikkelworkflow](https://codewithcj.github.io/SparkyFitness/developer/workflow)** - Ontwikkelaarsgids en bijdrageproces  
- **[📊 Functieoverzicht](https://codewithcj.github.io/SparkyFitness/features/)** - Volledige functiedocumentatie
- **[🏗️ Architectuur](https://codewithcj.github.io/SparkyFitness/app-overview)** - Technische architectuur en ontwerp
- Raadpleeg WIiki voor voorbeeld env setup en configuratie van de mobiele app.


## Stergeschiedenis

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Stergeschiedenisgrafiek" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Vertalingen

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Vertaalstatus" />
</a>

## Repository activiteit

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats analytics afbeelding")


## Bijdragers

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

### ⚠️ Bekende Problemen / Beta-functies ⚠️

De volgende functies zijn momenteel in bèta en zijn mogelijk niet grondig getest. Er kunnen bugs of incomplete functionaliteit optreden:

*   AI Chatbot
*   Ondersteuning voor meerdere gebruikers
*   Toegang voor Familie & Vrienden
*   Integratie van Apple Health Data

Deze applicatie is volop in ontwikkeling. Dingen kunnen niet werken zoals verwacht door de migratie van Supabase naar PostgreSQL. BREAKING CHANGES kunnen worden geïntroduceerd totdat de applicatie stabiel is.
Het kan nodig zijn Docker-/omgevingsvariabelen te wijzigen voor nieuwe releases. Daarom worden automatische upgrades via Watchtower of vergelijkbare apps niet aanbevolen. Lees de release-opmerkingen voor eventuele BREAKING CHANGES.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---