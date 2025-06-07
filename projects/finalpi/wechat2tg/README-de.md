# wechat2tg-mac

Senden und Empfangen von WeChat-Nachrichten auf Telegram basierend auf dem WeChat-Mac-Protokoll. Der wx2tg-server ist aus Sicherheitsgründen nicht quelloffen.

## TG Gruppe: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Hauptfunktionen

1. Empfang von Einzelchat-Nachrichten, Gruppenchat-Nachrichten, Nachrichten von offiziellen Accounts und Nachrichten von WeCom (Enterprise WeChat)
2. Senden von Nachrichten von Telegram an bestimmte WeChat-Benutzer, WeChat-Gruppen oder offizielle Accounts
3. Blockieren von Nachrichten aus bestimmten Gruppen

## Unterstützte Nachrichtentypen

### Unterstützte WeChat-Nachrichtentypen

+ [x] Textnachrichten
+ [x] WeCom-Nachrichten
+ [x] WeChat-Sticker
+ [x] Bildnachrichten
+ [x] Videonachrichten
+ [x] Audio-/Videoanrufe (nur Benachrichtigungen)
+ [x] Dateinachrichten
+ [x] Linknachrichten
+ [x] Gruppenchat-Nachrichten
+ [x] Gruppenchat-@-Nachrichten (@alle und @dich werden in Telegram zu @dich umgewandelt)
+ [x] Nachrichten von offiziellen Accounts
+ [x] Emojis
+ [x] Standortnachrichten
+ [x] Rückruf-Nachrichten
+ [x] Sprachnachrichten
+ [ ] Red-Packet-Nachrichten (nur Hinweis, Inhalt nicht abrufbar)
+ [ ] Mini-Programm-Nachrichten

### Unterstützte Telegram-Nachrichtentypen

+ [x] Textnachrichten
+ [x] Sticker/Emojis
+ [x] Bildnachrichten
+ [x] Videonachrichten
+ [x] Dateinachrichten
+ [x] Sprachnachrichten

## Hinweise

1. Dieses Projekt dient ausschließlich Forschungs- und Lernzwecken und darf nicht für illegale Zwecke verwendet werden.
2. Jegliche Probleme können gerne als Issue eingereicht werden.

## Deployment & Installation

Kopieren Sie zunächst `.env.example` zu `.env` und konfigurieren Sie die Umgebungsvariablen in der `.env` Datei.

Kopieren Sie `app.conf.example` in das Verzeichnis `conf` als `app.conf` und passen Sie die Redis-Adresse auf Ihre eigene Redis-Instanz an.

### docker-compose

Erstellen Sie eine `docker-compose.yml` Datei:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # Wenn dieses Verzeichnis gemountet ist, müssen Stickerdaten nicht erneut konvertiert werden
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Image ziehen
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

#### Ausführen

```shell
docker-compose up -d
```

#### Bot-Privatsphärenmodus deaktivieren

Deaktivieren Sie den Privatsphärenmodus des Bots: Öffnen Sie BotFather, geben Sie `/mybots` ein, wählen Sie Ihren Bot. Klicken Sie auf `Bot Settings` - `Group Privacy` - `Turn off`. Wenn `Privacy mode is disabled for xxx` erscheint, wurde der Modus erfolgreich deaktiviert.

## Gebrauchsanweisung

### BOT-Befehle

- `/login`: QR-Code zum Einloggen erhalten; Der erste, der nach Deployment und Start `/login` sendet, wird Eigentümer des `BOT`
- `/flogin`: QR-Code für den File Transfer Helper erhalten, unterstützt Empfang von Videos und Dateien
- `/update`: Gruppenavatar- und Nickname-Informationen aktualisieren
- `/message`: Gruppenchat-Nachrichtempfang ein-/ausschalten
- `/forward`: Weiterleitung von Nachrichten anderer Personen oder Bots in der Gruppe ein-/ausschalten
- `/user`: WeChat-Nutzerliste abrufen; Nach Klick auf Button kann eine neue Gruppe erstellt oder ein Nutzer gebunden werden (Suche per Name oder Bemerkung, z.B. `/user 张` findet Nutzer mit „张“)
- `/room`: WeChat-Gruppenliste abrufen; Nach Klick auf Button kann eine neue Gruppe erstellt oder eine WeChat-Gruppe gebunden werden (Suche per Name oder Bemerkung, z.B. `/room 外卖` findet Gruppen mit „外卖“)
- `/settings`: Programmeinstellungen
- `/unbind`: WeChat-Gruppen oder -Nutzer entbinden (nur in Gruppen nutzbar)

### Umgebungsvariablen

|Name| Erforderlich | Beschreibung                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| Ja    | Token des Telegram-Bots, via [BotFather](https://t.me/BotFather) erstellt |
|`API_ID`| Ja    | Telegram API ID                                          |
|`API_HASH`| Ja    | Telegram API HASH                                        |
|`BASE_API`| Ja    | API-Endpunkt des wx2tg-server Containers, vollständiger Pfad erforderlich | |
|`PROXY_PROTOCOL`| Nein    | Proxy-Typ (socks5,http,https)                                     |
|`PROXY_HOST`| Nein    | Proxy-URL                                                        |
|`PROXY_PORT`| Nein    | Proxy-Port                                                         |
|`PROXY_USERNAME`| Nein    | Proxy-Benutzername                                                         |
|`PROXY_PASSWORD`| Nein    | Proxy-Passwort                                                          |
|`ROOM_MESSAGE`| Nein    | Anzeigeformat für WeChat-Gruppennachrichten im BOT                          |
|`OFFICIAL_MESSAGE`| Nein    | Anzeigeformat für Nachrichten von offiziellen Accounts im BOT                 |
|`CONTACT_MESSAGE`| Nein    | Anzeigeformat für WeChat-Nutzer-Nachrichten im BOT                            |
|`ROOM_MESSAGE_GROUP`| Nein    | Anzeigeformat für WeChat-Gruppennachrichten in der Gruppe                      |
|`CONTACT_MESSAGE_GROUP`| Nein    | Anzeigeformat für WeChat-Nutzer-Nachrichten in der Gruppe                     |
|`OFFICIAL_MESSAGE_GROUP`| Nein    | Anzeigeformat für Nachrichten von offiziellen Accounts in der Gruppe           |
|`CREATE_ROOM_NAME`| Nein    | Format für automatisch erstellte Gruppennamen von WeChat-Gruppen                    |
|`CREATE_CONTACT_NAME`| Nein    | Format für automatisch erstellte Gruppennamen von WeChat-Kontakten                 |
|`MESSAGE_DISPLAY`| Nein    | Anzeigeformat für Textnachrichten                                               |

 ---

### Erklärung der Einstellungen `/settings`-Befehl

1. WeChat-Emoji als Bildlink anzeigen: Nach Aktivierung werden Emojis („kleine gelbe Smileys“) als Bildlink angezeigt.
2. Gruppeninformationen beim Start synchronisieren: Nach Aktivierung werden beim Programmstart alle Gruppeninformationen synchronisiert, inklusive Gruppenavatar und Namen.

---

### Sprachnachricht zu Text

1. Konfigurieren Sie `TENCENT_SECRET_ID` und `TENCENT_SECRET_KEY` im [Tencent Sprachsteuerungs-Panel](https://console.cloud.tencent.com/asr). Es gibt ein kostenloses Kontingent.
2. Aktivieren Sie die automatische Umwandlung von Sprachnachrichten in Text unter `/settings`.

---

### API_ID und API_HASH erhalten

1. Anmelden bei [telegram account](https://my.telegram.org/)

2. Klicken Sie auf „API development tools“ und füllen Sie die Anwendungsdetails aus (nur Titel und Kurzname erforderlich)

3. Klicken Sie abschließend auf „Create application“

---

### Eigene Nachrichtenvorlagen

Wenn Sie das Format des Nachrichtensenders anpassen möchten, ändern Sie die Umgebungsvariablen im Docker-Container oder in der `.env` Datei.

Platzhalter für eigene Nachrichtenvorlagen:

`#[alias]`: Kontakt-Bemerkung

`#[name]`: Kontakt-Spitzname

`#[topic]`: Gruppenchat-Name

`#[alias_first]`: Bemerkung (falls keine vorhanden, Spitzname)

`#[identity]`: Identitätsinformation

`#[body]`: Nachrichtentext

`#[br]`: Zeilenumbruch

### Wie @alle

Senden Sie eine mit `@all` beginnende Nachricht, um alle zu @-mentionen. Nur Textnachrichten werden für @alle unterstützt.

---

## FAQ (Häufig gestellte Fragen)


## Beitrag zur Entwicklung

1. Forken Sie das Projekt, wechseln Sie auf den Branch `wx2tg-mac-dev` oder erstellen Sie einen neuen Branch. Bitte keine Commits direkt auf den Haupt-Branch.
2. Reichen Sie einen Pull Request auf den Branch `wx2tg-mac-dev` ein.


## Lizenz

[MIT](LICENSE)


## Dank

Vielen Dank an Jetbrains für die Unterstützung dieses Projekts

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---