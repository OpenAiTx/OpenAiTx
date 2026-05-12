
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

> prosty i łatwy w użyciu narzędzie do samodzielnego monitorowania statusu

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 Demo na żywo

Wypróbuj.

Serwer demo (Lokalizacja: Singapur): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

Nazwa użytkownika: `demo`
Hasło: `demodemo`

## ⭐ Funkcje

Potrzebuje więcej funkcji, ale na razie...

- Monitorowanie dostępności HTTP(s)
- Wykres statusu i opóźnienia
- Powiadomienia przez Discord
- Interwały co 60 sekund
- Nowoczesny, reaktywny, szybki interfejs UI/UX
- Wiele stron statusowych
- Przypisywanie stron statusowych do konkretnych domen
- Wykres pingów
- Informacje o certyfikacie
- PWA
- Wsparcie dla baz danych Sqlite i Postgres

I dziesiątki mniejszych funkcji do dodania.

## 🔧 Jak zainstalować

### 🐳 Docker

Dla Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

Dla Postgresa

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```
Upstat działa teraz pod adresem http://localhost:3000

> [!WAŻNE]
> Przed wdrożeniem upewnij się, że zmienisz wartości środowiskowe.

### 💪🏻 Bez Dockera

Wymagania:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (opcjonalnie)


```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## Stos technologiczny

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 Wkład

Zapraszam do współpracy! Wkład to to, co czyni społeczność open source tak niesamowitym miejscem do nauki, inspiracji i tworzenia. Każdy Twój wkład jest **bardzo doceniany**.

Jeśli masz sugestię, która mogłaby to ulepszyć, rozwidl repozytorium, wprowadź zmiany i utwórz pull request. Możesz też po prostu otworzyć zgłoszenie z tagiem "enhancement".
Nie zapomnij dać gwiazdki temu projektowi! Dziękuję jeszcze raz!

1. Rozwidl projekt (Fork the Project)
2. Utwórz swoją gałąź z funkcją (`git checkout -b feature/AmazingFeature`)
3. Zatwierdź zmiany (`git commit -m 'Add some AmazingFeature'`)
4. Wypchnij gałąź (`git push origin feature/AmazingFeature`)
5. Otwórz Pull Request

## Współtwórcy

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 Licencja

Projekt jest objęty [Licencją MIT](https://opensource.org/license/mit/).

## 🖼 Więcej zrzutów ekranu

Utwórz monitor

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

Strona monitora

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---