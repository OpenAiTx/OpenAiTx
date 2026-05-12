
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> strumento di monitoraggio dello stato semplice e facile da usare, self-hosted

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 Demo dal vivo

Provalo.

Server Demo (Posizione: Singapore): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

Nome utente: `demo`
Password: `demodemo`

## ⭐ Funzionalità

Ha bisogno di altre funzionalità ma per ora...

- Monitoraggio uptime per HTTP(s)
- Grafico dello stato e della latenza
- Notifiche tramite Discord
- Intervalli di 60 secondi
- UI/UX elegante, reattiva e veloce
- Pagine di stato multiple
- Mappa le pagine di stato a domini specifici
- Grafico ping
- Info certificato
- PWA
- Supporto database Sqlite & Postgres

E dozzine di funzionalità minori da aggiungere.

## 🔧 Come installare

### 🐳 Docker

Per Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

Per Postgres

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat è ora in esecuzione su http://localhost:3000

> [!IMPORTANTE]
> Assicurati di modificare i valori dell'ambiente prima della distribuzione.

### 💪🏻 Non-Docker

Requisiti:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (Opzionale)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## Stack tecnologico

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 Contribuire

Accolgo con piacere i contributi! I contributi sono ciò che rende la comunità open source un posto straordinario dove imparare, ispirarsi e creare. Qualsiasi contributo tu faccia è **molto apprezzato**.

Se hai un suggerimento per migliorare questo progetto, fai il fork del repository, apporta le modifiche e crea una pull request. Puoi anche semplicemente aprire una issue con il tag "enhancement".
Non dimenticare di dare una stella al progetto! Grazie ancora!

1. Fai il fork del progetto
2. Crea il tuo Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Fai il commit delle tue modifiche (`git commit -m 'Add some AmazingFeature'`)
4. Fai il push sul branch (`git push origin feature/AmazingFeature`)
5. Apri una Pull Request

## Contributori

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 Licenza

Questo progetto è concesso in licenza sotto la [Licenza MIT](https://opensource.org/license/mit/).

## 🖼 Altre schermate

Crea un Monitor

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

Pagina Monitor

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---