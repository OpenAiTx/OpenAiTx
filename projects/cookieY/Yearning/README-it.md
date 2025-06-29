<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 Una piattaforma robusta, distribuita localmente, progettata per un rilevamento SQL fluido e un auditing delle query, pensata specificamente per DBA e sviluppatori. Concentrata su privacy ed efficienza, offre un ambiente intuitivo e sicuro per l’auditing di MYSQL.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Funzionalità

- **Assistente AI**: Il nostro assistente AI offre suggerimenti di ottimizzazione SQL in tempo reale, migliorando le prestazioni SQL. Supporta anche la conversione da testo a SQL, consentendo agli utenti di inserire un linguaggio naturale e ricevere istruzioni SQL ottimizzate.
  
- **Audit SQL**: Crea ticket di audit SQL con flussi di approvazione e controlli automatici della sintassi. Valida le istruzioni SQL per correttezza, sicurezza e conformità. Gli statement di rollback vengono generati automaticamente per le operazioni DDL/DML, con un registro storico completo per la tracciabilità.

- **Audit Query**: Audita le query degli utenti, limita le fonti dati e i database, e anonimizza i campi sensibili. I record delle query vengono salvati per riferimento futuro.

- **Regole di Controllo**: Il nostro controllore di sintassi automatizzato supporta una vasta gamma di regole di controllo, adatte alla maggior parte degli scenari di controllo automatico.

- **Privacy al Centro**: Yearning è una soluzione open source distribuibile localmente che garantisce la sicurezza del tuo database e delle istruzioni SQL. Include meccanismi di crittografia per proteggere i dati sensibili, assicurandone la sicurezza anche in caso di accessi non autorizzati.

- **RBAC (Controllo Accessi Basato sui Ruoli)**: Crea e gestisci ruoli con permessi specifici, limitando l’accesso agli ordini di query, alle funzioni di auditing e ad altre operazioni sensibili in base ai ruoli utente.

> \[!TIP]
> Per informazioni più dettagliate, visita la nostra [Guida Yearning](https://next.yearning.io)


## ⚙️ Installazione

Scarica l’[ultima release](https://github.com/cookieY/Yearning/releases/latest) ed estraila. Assicurati di aver configurato `./config.toml` prima di procedere.

### Installazione Manuale

```bash
## Inizializza il database
./Yearning install

## Avvia Yearning
./Yearning run

## Aiuto
./Yearning --help
```

### 🚀 Deploy con Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Inizializza il database
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Avvia Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 Assistenza AI

Il nostro Assistente AI sfrutta un modello linguistico di grandi dimensioni per offrire suggerimenti di ottimizzazione SQL e conversione da testo a SQL. Che tu utilizzi prompt predefiniti o personalizzati, l’Assistente AI migliora le prestazioni SQL ottimizzando le istruzioni e convertendo input in linguaggio naturale in query SQL.

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Controllore SQL Automatico

Il controllore SQL automatico valuta le istruzioni SQL rispetto a regole e sintassi predefinite. Garantisce che le istruzioni rispettino specifici standard di codifica, best practice e requisiti di sicurezza, offrendo un robusto livello di validazione.

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 Evidenziazione Sintassi SQL e Completamento Automatico

Migliora l’efficienza nella scrittura delle query con l’evidenziazione della sintassi SQL e il completamento automatico. Queste funzionalità aiutano gli utenti a distinguere visivamente le diverse componenti di una query SQL, come parole chiave, nomi di tabelle, nomi di colonne e operatori, rendendo più facile leggere e comprendere la struttura della query.

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Ordine/Record di Query

La nostra piattaforma supporta l’auditing delle istruzioni di ordine e query degli utenti. Questa funzione consente di tracciare e registrare tutte le operazioni di query, incluse fonti dati, database e gestione dei campi sensibili, garantendo la conformità alle normative e fornendo tracciabilità della cronologia delle query.

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Concentrandosi su queste funzionalità chiave, Yearning migliora l’esperienza utente, ottimizza le prestazioni SQL e garantisce una solida conformità e tracciabilità nelle operazioni di database.

## 🛠️ Strumenti Consigliati

- [Spug - Piattaforma Open Source Leggera per l’Automazione delle Operazioni](https://github.com/openspug/spug)

## ☎️ Contatti

Per richieste, scrivi a: henry@yearning.io
## 📋 Licenza

Yearning è distribuito sotto licenza AGPL. Consulta [LICENSE](LICENSE) per i dettagli.

2024 © Henry Yee

---

Con Yearning, sperimenta un approccio semplificato, sicuro ed efficiente all'auditing e all'ottimizzazione SQL.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---