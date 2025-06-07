# wechat2tg-mac

Basato sul protocollo WeChat per Mac, consente l'invio e la ricezione di messaggi WeChat su Telegram. Il servizio wx2tg-server non è open source per motivi di sicurezza.

## Gruppo TG: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Funzionalità principali

1. Ricezione di messaggi singoli di WeChat, messaggi di gruppo, messaggi da account ufficiali e messaggi WeChat aziendali
2. Telegram invia messaggi a utenti WeChat specifici, gruppi WeChat o account ufficiali
3. Filtraggio di messaggi da gruppi specifici

## Tipologie di messaggi supportate

### Elenco dei tipi di messaggi supportati da WeChat

+ [x] Messaggi di testo
+ [x] Messaggi WeChat aziendali
+ [x] Pacchetti di sticker WeChat
+ [x] Messaggi con immagini
+ [x] Messaggi video
+ [x] Chiamate audio/video (solo notifica di messaggio)
+ [x] Messaggi di file
+ [x] Messaggi con link
+ [x] Messaggi di gruppo
+ [x] Messaggi di gruppo con @ (sia @tutti che @te saranno convertiti in Telegram @te)
+ [x] Messaggi da account ufficiali
+ [x] Emoji
+ [x] Messaggi di posizione
+ [x] Messaggi ritirati
+ [x] Messaggi vocali
+ [ ] Messaggi "Hongbao" (solo notifica, il contenuto non è accessibile)
+ [ ] Mini-programmi

### Elenco dei tipi di messaggi supportati da Telegram

+ [x] Messaggi di testo
+ [x] Sticker ed emoji
+ [x] Messaggi con immagini
+ [x] Messaggi video
+ [x] Messaggi di file
+ [x] Messaggi vocali

## Note

1. Questo progetto è solo per ricerca tecnica e studio, è vietato qualsiasi uso illecito
2. Per qualsiasi problema, si prega di aprire una issue

## Installazione e Deploy

Copiare prima `.env.example` in un nuovo file `.env`, quindi configurare le variabili d’ambiente nel file `.env`

Copiare `app.conf.example` dalla cartella del progetto come `app.conf` nella cartella `conf`, e impostare l'indirizzo di Redis a quello del proprio deployment

### docker-compose

Crea un file `docker-compose.yml`:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # Una volta montata la cartella, i file sticker non dovranno essere riconvertiti
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Scarica l'immagine
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

#### Avvio

```shell
docker-compose up -d
```

#### Disabilitare la modalità privacy del bot

Disabilita la modalità privacy del bot: apri BotFather, inserisci `/mybots`, seleziona il tuo bot. Clicca su `Bot Settings` - `Group Privacy` - `Turn off`
. Se appare il messaggio `Privacy mode is disabled for xxx`, la disattivazione è avvenuta con successo.

## Istruzioni per l’uso

### Comandi del BOT

- `/login`: Ottieni il QR code per il login; la prima persona che invia il comando `/login` dopo il deployment diventa il proprietario del BOT

- `/flogin`: Ottieni il QR code per l'assistente di trasferimento file, supporta ricezione di video e file

- `/update`: Aggiorna avatar e informazioni dei gruppi

- `/message`: Attiva/disattiva la ricezione dei messaggi di gruppo

- `/forward`: Attiva/disattiva l'inoltro dei messaggi di altri membri o bot all'interno del gruppo

- `/user`: Ottieni la lista utenti WeChat; clicca il bottone per creare un nuovo gruppo o associare un utente (si può cercare per nome o nota, ad esempio: `/user 张` per trovare utenti WeChat che contengono "张")

- `/room`: Ottieni la lista dei gruppi WeChat; clicca il bottone per creare un nuovo gruppo o associare un gruppo WeChat (si può cercare per nome o nota, ad esempio: `/room 外卖` per trovare gruppi WeChat che contengono "外卖")

- `/settings`: Impostazioni del programma

- `/unbind`: Disassocia gruppi WeChat o utenti WeChat (solo nei gruppi)

### Descrizione delle variabili d’ambiente

|Nome| Obbligatorio | Descrizione                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| Sì    | Token del Bot Telegram, creato tramite [BotFather](https://t.me/BotFather) |
|`API_ID`| Sì    | API ID di Telegram                                          |
|`API_HASH`| Sì    | API HASH di Telegram                                        |
|`BASE_API`| Sì    | Indirizzo API completo del container wx2tg-server                            |
|`PROXY_PROTOCOL`| No    | Tipo proxy (socks5,http,https)                                     |
|`PROXY_HOST`| No    | URL del proxy                                                        |
|`PROXY_PORT`| No    | Porta del proxy                                                         |
|`PROXY_USERNAME`| No    | Username del proxy                                                         |
|`PROXY_PASSWORD`| No    | Password del proxy                                                          |
|`ROOM_MESSAGE`| No    | Formato di visualizzazione dei messaggi di gruppo WeChat nel BOT              |
|`OFFICIAL_MESSAGE`| No    | Formato di visualizzazione dei messaggi degli account ufficiali nel BOT      |
|`CONTACT_MESSAGE`| No    | Formato di visualizzazione dei messaggi utente WeChat nel BOT                |
|`ROOM_MESSAGE_GROUP`| No    | Formato di visualizzazione dei messaggi di gruppo WeChat nei gruppi         |
|`CONTACT_MESSAGE_GROUP`| No    | Formato di visualizzazione dei messaggi utente WeChat nei gruppi            |
|`OFFICIAL_MESSAGE_GROUP`| No    | Formato di visualizzazione dei messaggi degli account ufficiali nei gruppi |
|`CREATE_ROOM_NAME`| No    | Formato del nome per la creazione automatica di gruppi WeChat                |
|`CREATE_CONTACT_NAME`| No    | Formato del nome per la creazione automatica di gruppi utente WeChat        |
|`MESSAGE_DISPLAY`| No    | Formato di visualizzazione dei messaggi di testo                              |

---

### Descrizione del comando `/settings`

1. Visualizzare emoji di WeChat come link immagine: se attivato, le emoji inviate dagli amici verranno mostrate come link a immagini

2. Sincronizzare le info gruppo all’avvio: se attivato, sincronizzerà le informazioni di tutti i gruppi e aggiornerà avatar e nomi all’avvio

---

### Trascrizione vocale

1. Configurare `TENCENT_SECRET_ID` e `TENCENT_SECRET_KEY`, attivabili dalla [console di riconoscimento vocale di Tencent](https://console.cloud.tencent.com/asr). Sono disponibili quote gratuite.
2. Attivare la funzione di trascrizione automatica nelle impostazioni tramite `/settings`

---

### Come ottenere `API_ID` e `API_HASH`

1. Accedi a [telegram account](https://my.telegram.org/)

2. Clicca su "API development tools" e inserisci i dettagli dell’applicazione (solo titolo e short name necessari)

3. Clicca infine su "Create application"

---

### Modello di messaggio personalizzato

Se desideri modificare il formato del mittente dei messaggi, puoi modificare le variabili d’ambiente nel docker o nel file `.env`

Segnaposto disponibili per il modello personalizzato:

`#[alias]`: Nota del contatto

`#[name]`: Nickname del contatto

`#[topic]`: Nome del gruppo

`#[alias_first]`: Mostra la nota, se non presente mostra il nickname

`#[identity]`: Testo con informazioni sull’identità

`#[body]`: Testo del messaggio

`#[br]`: Nuova riga

### Come menzionare @tutti

Invia un messaggio che inizia con `@all` per menzionare tutti; questa funzione è supportata solo per messaggi di testo

---

## FAQ

## Partecipare allo sviluppo

1. Fai un fork del progetto, passa al branch `wx2tg-mac-dev` o creane uno nuovo. Non inviare il codice direttamente al branch principale
2. Invia una Pull Request al branch `wx2tg-mac-dev`


## Licenza

[MIT](LICENSE)


## Ringraziamenti

Ringraziamo Jetbrains per il supporto a questo progetto

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---