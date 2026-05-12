
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> eenvoudige en gebruiksvriendelijke zelf-gehoste status monitoring tool

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 Live Demo

Probeer het.

Demo Server (Locatie: Singapore): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

Gebruikersnaam: `demo`
Wachtwoord: `demodemo`

## ⭐ Functies

Er zijn meer functies nodig, maar voorlopig...

- Monitoring van uptime voor HTTP(s)
- Status- en Latency-grafiek
- Meldingen via Discord
- Intervallen van 60 seconden
- Mooie, Reactieve, Snelle UI/UX
- Meerdere statuspagina’s
- Koppel statuspagina’s aan specifieke domeinen
- Ping-grafiek
- Certificaatinformatie
- PWA
- Ondersteuning voor Sqlite & Postgres databases

En tientallen kleinere functies die nog toegevoegd worden.

## 🔧 Installatie-instructies

### 🐳 Docker

Voor Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

Voor Postgres

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat draait nu op http://localhost:3000

> [!IMPORTANT]
> Zorg ervoor dat je de omgevingswaarden wijzigt voordat je gaat deployen.

### 💪🏻 Niet-Docker

Vereisten:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (optioneel)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## Technische stack

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 Bijdragen

Bijdragen zijn welkom! Bijdragen maken de open source community tot zo'n geweldige plek om te leren, inspireren en creëren. Elke bijdrage die je levert wordt **zeer gewaardeerd**.

Als je een suggestie hebt om dit te verbeteren, fork dan de repo, voer wijzigingen door en maak een pull request aan. Je kunt ook simpelweg een issue openen met het label "enhancement".
Vergeet niet het project een ster te geven! Nogmaals bedankt!

1. Fork het project
2. Maak je Feature Branch aan (`git checkout -b feature/AmazingFeature`)
3. Commit je wijzigingen (`git commit -m 'Add some AmazingFeature'`)
4. Push naar de Branch (`git push origin feature/AmazingFeature`)
5. Open een Pull Request

## Bijdragers

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 Licentie

Dit project is gelicentieerd onder de [MIT Licentie](https://opensource.org/license/mit/).

## 🖼 Meer screenshots

Monitor aanmaken

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

Monitorpagina

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---