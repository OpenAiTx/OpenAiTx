<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

Een robuust, lokaal geïnstalleerd platform ontworpen voor naadloze SQL-detectie en query-auditing, speciaal afgestemd op DBA’s en ontwikkelaars. Gericht op privacy en efficiëntie, biedt het een intuïtieve en veilige omgeving voor MYSQL-auditing.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Functies

- **AI Assistent**: Onze AI-assistent biedt realtime SQL-optimalisatiesuggesties voor verbeterde SQL-prestaties. Hij ondersteunt ook tekst-naar-SQL-conversie, zodat gebruikers natuurlijke taal kunnen invoeren en geoptimaliseerde SQL-instructies ontvangen.
  
- **SQL Audit**: Maak SQL-auditverzoeken met goedkeuringsworkflows en geautomatiseerde syntaxiscontroles. Valideer SQL-instructies op juistheid, veiligheid en naleving. Rollback-instructies worden automatisch gegenereerd voor DDL/DML-bewerkingen, met een uitgebreide historie-log voor traceerbaarheid.

- **Query Audit**: Auditeer gebruikersquery’s, beperk gegevensbronnen en databases, en anonimiseer gevoelige velden. Queryrecords worden opgeslagen voor toekomstig gebruik.

- **Regelcontrole**: Onze geautomatiseerde syntaxiscontrole ondersteunt een breed scala aan controle regels, geschikt voor de meeste automatische controlescenario’s.

- **Privacygericht**: Yearning is een lokaal implementeerbare, open-source oplossing die de veiligheid van je database en SQL-instructies waarborgt. Het bevat encryptiemechanismen om gevoelige gegevens te beschermen, zodat deze veilig blijven, zelfs bij ongeautoriseerde toegang.

- **RBAC (Role-Based Access Control)**: Maak en beheer rollen met specifieke rechten, en beperk de toegang tot query-aanvragen, auditfuncties en andere gevoelige handelingen op basis van gebruikersrollen.

> \[!TIP]
> Voor meer gedetailleerde informatie, bezoek onze [Yearning Gids](https://next.yearning.io)


## ⚙️ Installatie

Download de [laatste release](https://github.com/cookieY/Yearning/releases/latest) en pak deze uit. Zorg ervoor dat je `./config.toml` hebt geconfigureerd voordat je verdergaat.

### Handmatige installatie

```bash
## Initialiseer de database
./Yearning install

## Start Yearning
./Yearning run

## Help
./Yearning --help
```

### 🚀 Deployen met Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Initialiseer de database
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Start Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 AI Assistentie

Onze AI-assistent maakt gebruik van een groot taalmodel om SQL-optimalisatiesuggesties en tekst-naar-SQL-conversie te bieden. Of je nu standaard- of aangepaste prompts gebruikt, de AI-assistent verbetert SQL-prestaties door instructies te optimaliseren en natuurlijke taal om te zetten in SQL-query's.

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Automatische SQL Checker

De automatische SQL-checker beoordeelt SQL-instructies aan de hand van vooraf gedefinieerde regels en syntaxis. Dit zorgt ervoor dat instructies voldoen aan specifieke codestandaarden, best practices en beveiligingseisen, en biedt een robuuste validatielaag.

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 SQL-syntaxisaccentuering en automatisch aanvullen

Verbeter je efficiëntie bij het schrijven van query’s met SQL-syntaxisaccentuering en automatisch aanvullen. Deze functies helpen gebruikers visueel onderscheid te maken tussen verschillende onderdelen van een SQL-query, zoals sleutelwoorden, tabelnamen, kolomnamen en operatoren, waardoor de querystructuur makkelijker te lezen en te begrijpen is.

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Order-/Query-registratie

Ons platform ondersteunt het auditen van gebruikersorders en query-instructies. Met deze functie kun je alle querybewerkingen volgen en registreren, inclusief gegevensbronnen, databases en de omgang met gevoelige velden, zodat je voldoet aan regelgeving en traceerbaarheid van de querygeschiedenis waarborgt.

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Door te focussen op deze kernfuncties, verbetert Yearning de gebruikerservaring, optimaliseert het SQL-prestaties en zorgt het voor robuuste naleving en traceerbaarheid bij databasebewerkingen.

## 🛠️ Aanbevolen tools

- [Spug - Open Source Lightweight Automation Operations Platform](https://github.com/openspug/spug)

## ☎️ Contact

Voor vragen kun je mailen naar: henry@yearning.io
## 📋 Licentie

Yearning is gelicentieerd onder de AGPL-licentie. Zie [LICENSE](LICENSE) voor details.

2024 © Henry Yee

---

Met Yearning ervaart u een gestroomlijnde, veilige en efficiënte aanpak van SQL-auditing en optimalisatie.


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