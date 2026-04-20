<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">Engels</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">Vereenvoudigd Chinees</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">Traditioneel Chinees</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">Japans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">Koreaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">Hindi</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">Thais</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Frans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Duits</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Spaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Russisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Portugees</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Pools</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">Arabisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">Perzisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Turks</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Vietnamees</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Indonesisch</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

Een zelfgehost, privacygericht alternatief voor MyFitnessPal. Houd voeding, beweging, lichaamsmetingen en gezondheidsgegevens bij terwijl je volledige controle over je data behoudt.

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness is een zelfgehost fitness tracking platform dat bestaat uit:

- Een backend server (API + gegevensopslag)
- Een webgebaseerde frontend
- Native mobiele apps voor iOS en Android

Het slaat gezondheidsgegevens op en beheert deze op infrastructuur die jij beheert, zonder afhankelijk te zijn van diensten van derden.

## Kernfuncties

- Voeding, beweging, hydratatie, slaap, vasten, stemming en lichaamsmetingen bijhouden
- Doelstellingen instellen en dagelijkse check-ins
- Interactieve grafieken en langetermijnrapporten
- Meerdere gebruikersprofielen en gezins-toegang
- Licht- en donkerthema's
- OIDC, TOTP, Passkey, MFA etc.

## Gezondheids- & Apparaatkoppelingen

SparkyFitness kan gegevens synchroniseren van meerdere gezondheids- en fitnessplatformen:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (gedeeltelijk getest)
- **Hevy** (niet getest)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (gedeeltelijk getest)

Koppelingen synchroniseren automatisch activiteitsgegevens zoals stappen, trainingen en slaap, samen met gezondheidsmetingen zoals gewicht en lichaamsmaten, naar je SparkyFitness-server.

## Optionele AI-functies (Bèta)

SparkyAI biedt een conversatie-interface voor het loggen van gegevens en het beoordelen van voortgang.

- Voer voeding, beweging, lichaamsstatistieken en stappen in via chat
- Upload voedselafbeeldingen voor automatische maaltijdregistratie
- Behoudt gespreksgeschiedenis voor vervolgacties

Opmerking: AI-functies zijn momenteel in bèta.

## Snel starten (Server)

Zet een SparkyFitness-server op in enkele minuten met Docker Compose.

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
## 🎥 Videotutorial

[![Bekijk de video](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

Korte tutorial van 2 minuten waarin wordt getoond hoe je SparkyFitness installeert (self-hosted fitness tracker).


## Documentatie

Voor volledige installatiehandleidingen, configuratie-opties en ontwikkelaarsdocumentatie, bezoek onze [Documentatiesite](https://codewithcj.github.io/SparkyFitness/).

### Snelle links

- **[Installatiehandleiding](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - Uitrol en configuraties
- **[Functieoverzicht](https://codewithcj.github.io/SparkyFitness/features)** - Complete functiedocumentatie
- **[Ontwikkelworkflow](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Ontwikkelaarsgids en bijdrageproces
- **[iOS App Info](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** en **[Android App Info](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### Hulp nodig?

- Plaats een bericht in Github issues/discussie.
- Voor snellere reactie en hulp van andere communityleden **[Word lid van onze Discord](https://discord.gg/vcnMT5cPEA)**

## Sterrenhistorie

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Vertalingen

**[Weblate Vertalingen](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">


<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Vertaalstatus" />
</a>

## Repositoryactiviteit

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats analytics afbeelding")

## Bijdragers

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Bekende problemen / Bètafuncties ⚠️

SparkyFitness is in actieve ontwikkeling.
Er kunnen ingrijpende wijzigingen optreden tussen releases.

- Het automatisch bijwerken van containers wordt niet aanbevolen
- Bekijk altijd de release-opmerkingen voordat u upgradet

De volgende functies zijn momenteel in bèta en zijn mogelijk niet grondig getest. Verwacht mogelijke bugs of onvolledige functionaliteit:

- AI Chatbot
- Familie & Vrienden toegang
- API-documentatie


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---