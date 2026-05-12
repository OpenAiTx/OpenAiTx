
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Vietnamesisch</a>
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

> Einfaches und benutzerfreundliches selbstgehostetes Statusüberwachungstool

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 Live-Demo

Probiere es aus.

Demo-Server (Standort: Singapur): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

Benutzername: `demo`
Passwort: `demodemo`

## ⭐ Funktionen

Es werden noch mehr Funktionen benötigt, aber aktuell...

- Überwacht die Erreichbarkeit von HTTP(s)
- Status- und Latenzdiagramm
- Benachrichtigungen über Discord
- 60-Sekunden-Intervalle
- Schicke, reaktive, schnelle UI/UX
- Mehrere Statusseiten
- Ordnet Statusseiten bestimmten Domains zu
- Ping-Diagramm
- Zertifikatsinformationen
- PWA
- Unterstützung für Sqlite & Postgres Datenbanken

Und Dutzende kleinerer Funktionen, die noch hinzugefügt werden.

## 🔧 Installation

### 🐳 Docker

Für Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

Für Postgres

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat läuft jetzt unter http://localhost:3000

> [!WICHTIG]
> Stellen Sie sicher, dass Sie die Umgebungswerte vor dem Deployment ändern.

### 💪🏻 Nicht-Docker

Anforderungen:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (Optional)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## Technologiestack

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 Beitrag leisten

Beiträge sind herzlich willkommen! Beiträge sind das, was die Open-Source-Community zu einem so großartigen Ort zum Lernen, Inspirieren und Erschaffen macht. Jeder Beitrag von dir ist **sehr geschätzt**.

Wenn du einen Vorschlag hast, der das Projekt verbessern könnte, forke das Repository, nimm Änderungen vor und erstelle einen Pull Request. Du kannst auch einfach ein Issue mit dem Tag "enhancement" eröffnen.
Vergiss nicht, dem Projekt einen Stern zu geben! Vielen Dank nochmal!

1. Forke das Projekt
2. Erstelle deinen Feature-Branch (`git checkout -b feature/AmazingFeature`)
3. Committe deine Änderungen (`git commit -m 'Add some AmazingFeature'`)
4. Push in den Branch (`git push origin feature/AmazingFeature`)
5. Öffne einen Pull Request

## Mitwirkende

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 Lizenz

Dieses Projekt steht unter der [MIT-Lizenz](https://opensource.org/license/mit/).

## 🖼 Weitere Screenshots

Monitor erstellen

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

Monitor-Seite

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---