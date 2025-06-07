# wechat2tg-mac

Op basis van het Mac-protocol van WeChat berichten van WeChat verzenden en ontvangen op Telegram. De wx2tg-server backend is om veiligheidsredenen niet open source.

## TG Groep: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Belangrijkste functies

1. Ontvangen van WeChat privéberichten, groepschats, berichten van officiële accounts en berichten van WeCom (WeChat Work)
2. Versturen van berichten vanuit Telegram naar specifieke WeChat-gebruikers, groepschats of officiële accounts
3. Blokkeren van berichten van bepaalde groepen

## Ondersteunde berichttypes

### Ondersteunde WeChat berichttypes

+ [x] Tekstberichten
+ [x] WeCom (WeChat Work) berichten
+ [x] WeChat stickers
+ [x] Afbeeldingsberichten
+ [x] Videoberichten
+ [x] Audio-/video-oproepen (alleen notificatie)
+ [x] Bestandsberichten
+ [x] Linkberichten
+ [x] Groepschatberichten
+ [x] Groepschat @-berichten (@iedereen en @jij worden omgezet naar Telegram @jij)
+ [x] Officiële accountberichten
+ [x] Emoji
+ [x] Locatieberichten
+ [x] Teruggetrokken berichten
+ [x] Spraakberichten
+ [ ] Hongbao-berichten (alleen melding, inhoud niet beschikbaar)
+ [ ] Mini-programma berichten

### Ondersteunde Telegram berichttypes

+ [x] Tekstberichten
+ [x] Stickers/emoji
+ [x] Afbeeldingsberichten
+ [x] Videoberichten
+ [x] Bestandsberichten
+ [x] Spraakberichten

## Opmerkingen

1. Dit project is uitsluitend bedoeld voor technisch onderzoek en educatie, en mag niet voor illegale doeleinden worden gebruikt
2. Bij problemen, dien gerust een issue in

## Installatie en Deploy

Maak eerst een kopie van `.env.example` naar `.env` en configureer de variabelen in het `.env`-bestand

Kopieer `app.conf.example` uit het project naar het bestand `app.conf` in de map `conf` en stel het Redis-adres in op het adres van jouw Redis-installatie

### docker-compose

Maak een `docker-compose.yml` bestand aan:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # Na het mounten hoeven stickervelden niet meer opnieuw geconverteerd te worden
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Pull image
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### Starten

```shell
docker-compose up -d
```

#### Schakel bot privacy-modus uit

Schakel de privacy-modus van de bot uit. Open BotFather, typ `/mybots`, kies jouw bot. Klik op `Bot Settings` - `Group Privacy` - `Turn off`. Als `Privacy mode is disabled for xxx` verschijnt, is de privacy-modus succesvol uitgeschakeld.

## Gebruiksaanwijzing

### BOT-commando’s

- `/login`: Ontvang een QR-code om in te loggen; de eerste die na installatie het `/login`-commando stuurt, wordt de eigenaar van de `BOT`

- `/flogin`: Ontvang een QR-code voor de File Transfer Assistant, ondersteunt het ontvangen van video’s en bestanden

- `/update`: Update groepsavatar en bijbehorende naam

- `/message`: Schakel ontvangst van groepsberichten in/uit

- `/forward`: Schakel doorsturen van berichten van anderen of van bots in groepen in/uit

- `/user`: Verkrijg WeChat gebruikerslijst; maak nieuwe groep of koppel gebruiker via knop (zoeken op naam of opmerking, bijvoorbeeld: `/user 张` zoekt naar WeChat-gebruikers met “张” in de naam)

- `/room`: Verkrijg WeChat groepslijst; maak nieuwe groep of koppel WeChat-groep via knop (zoeken op naam of opmerking, bijvoorbeeld: `/room 外卖` zoekt naar groepen met “外卖” in de naam)

- `/settings`: Programma-instellingen

- `/unbind`: Ontkoppel WeChat-groep of -gebruiker (alleen ondersteund in groepen)

### Uitleg omgevingsvariabelen

|Naam| Vereist | Omschrijving                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| Ja    | Token van de Telegram Bot, aan te maken via [BotFather](https://t.me/BotFather) |
|`API_ID`| Ja    | Telegram API ID                                          |
|`API_HASH`| Ja    | Telegram API HASH                                        |
|`BASE_API`| Ja    | API-adres van de wx2tg-server container, volledig pad vereist                            | |
|`PROXY_PROTOCOL`| Nee    | Optioneel type proxy (socks5,http,https)                                     |
|`PROXY_HOST`| Nee    | Proxy-URL                                                        |
|`PROXY_PORT`| Nee    | Proxy-poort                                                         |
|`PROXY_USERNAME`| Nee    | Proxy-gebruikersnaam                                                         |
|`PROXY_PASSWORD`| Nee    | Proxy-wachtwoord                                                          |
|`ROOM_MESSAGE`| Nee    | Weergaveformaat van WeChat groepsberichten in de BOT                                              |
|`OFFICIAL_MESSAGE`| Nee    | Weergaveformaat van officiële accountberichten in de BOT                                              |
|`CONTACT_MESSAGE`| Nee    | Weergaveformaat van WeChat gebruikersberichten in de BOT                                             |
|`ROOM_MESSAGE_GROUP`| Nee    | Weergaveformaat van WeChat groepsberichten in groepen                                                 |
|`CONTACT_MESSAGE_GROUP`| Nee    | Weergaveformaat van WeChat gebruikersberichten in groepen                                                |
|`OFFICIAL_MESSAGE_GROUP`| Nee    | Weergaveformaat van officiële accountberichten in groepen                                                 |
|`CREATE_ROOM_NAME`| Nee    | Formaat voor groepsnaam bij automatisch aanmaken van een WeChat-groep                                           |
|`CREATE_CONTACT_NAME`| Nee    | Formaat voor groepsnaam bij automatisch aanmaken van een WeChat-contactgroep                                         |
|`MESSAGE_DISPLAY`| Nee    | Weergaveformaat van tekstberichten                                                      |

 ---

### Uitleg `/settings`-commando

1. WeChat-emoji als afbeeldingslink tonen: Indien ingeschakeld worden emoji van vrienden weergegeven als afbeeldingslinks

2. Synchroniseer groepsinformatie bij opstarten: Indien ingeschakeld worden bij het opstarten alle groepsinformatie, avatars en namen gesynchroniseerd

---

### Spraak naar tekst

1. Stel `TENCENT_SECRET_ID` en `TENCENT_SECRET_KEY` in, verkrijgbaar via de [Tencent spraakherkenningsconsole](https://console.cloud.tencent.com/asr). Er is een gratis tegoed beschikbaar
2. Schakel automatische spraak-naar-tekst functie in via `/settings`

---

### Verkrijg `API_ID` en `API_HASH`

1. Log in op [telegram account](https://my.telegram.org/)

2. Klik op "API development tools" en vul de applicatiegegevens in (alleen titel en korte naam vereist)

3. Klik op "Create application"

---

### Aangepaste berichtsjablonen

Wil je het formaat van de afzender aanpassen? Wijzig de omgevingsvariabelen in Docker of in het `.env`-bestand

Aangepaste placeholders:

`#[alias]`: Opmerking bij contactpersoon

`#[name]`: WeChat-naam

`#[topic]`: Groepsnaam

`#[alias_first]`: Opmerking, of naam als geen opmerking

`#[identity]`: Identiteitstekst

`#[body]`: Berichtinhoud

`#[br]`: Nieuwe regel

### Hoe @iedereen

Berichten die beginnen met `@all` zullen iedereen @-en. Alleen tekstberichten ondersteunen @iedereen.

---

## Veelgestelde vragen


## Bijdragen aan ontwikkeling

1. Fork het project, switch naar de `wx2tg-mac-dev` branch of maak een nieuwe branch. Dien geen code direct in op de hoofdbranch
2. Dien een Pull Request in naar de `wx2tg-mac-dev` branch


## Licentie

[MIT](LICENSE)


## Dankwoord

Met dank aan Jetbrains voor de ondersteuning van dit project

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---