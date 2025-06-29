<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

Eine robuste, lokal bereitgestellte Plattform, die für nahtlose SQL-Erkennung und Query-Auditing entwickelt wurde – speziell zugeschnitten auf DBAs und Entwickler. Mit Fokus auf Datenschutz und Effizienz bietet sie eine intuitive und sichere Umgebung für das MYSQL-Auditing.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Funktionen

- **KI-Assistent**: Unser KI-Assistent bietet Echtzeit-Vorschläge zur SQL-Optimierung und verbessert so die SQL-Performance. Er unterstützt auch die Umwandlung von Text in SQL, sodass Nutzer natürliche Sprache eingeben und optimierte SQL-Anweisungen erhalten können.
  
- **SQL-Audit**: Erstellen Sie SQL-Audit-Tickets mit Genehmigungs-Workflows und automatischen Syntaxprüfungen. SQL-Anweisungen werden auf Korrektheit, Sicherheit und Compliance überprüft. Für DDL/DML-Operationen werden automatisch Rollback-Anweisungen generiert, mit einem umfassenden Protokoll für Nachverfolgbarkeit.

- **Query-Audit**: Überprüfen Sie Benutzerabfragen, beschränken Sie Datenquellen und Datenbanken und anonymisieren Sie sensible Felder. Abfrageprotokolle werden zur späteren Referenz gespeichert.

- **Regelprüfung**: Unser automatischer Syntaxprüfer unterstützt eine Vielzahl von Prüfregeln, geeignet für die meisten automatisierten Prüfszenarien.

- **Datenschutzfokus**: Yearning ist eine lokal einsetzbare Open-Source-Lösung, die die Sicherheit Ihrer Datenbank und SQL-Anweisungen gewährleistet. Sie beinhaltet Verschlüsselungsmechanismen zum Schutz sensibler Daten, sodass diese auch bei unbefugtem Zugriff sicher bleiben.

- **RBAC (Rollenbasierte Zugriffskontrolle)**: Erstellen und verwalten Sie Rollen mit spezifischen Berechtigungen, um den Zugang zu Query-Tickets, Audit-Funktionen und anderen sensiblen Operationen basierend auf Benutzerrollen einzuschränken.

> \[!TIPP]
> Für detailliertere Informationen besuchen Sie unseren [Yearning Guide](https://next.yearning.io)


## ⚙️ Installation

Laden Sie das [neueste Release](https://github.com/cookieY/Yearning/releases/latest) herunter und entpacken Sie es. Stellen Sie sicher, dass Sie `./config.toml` konfiguriert haben, bevor Sie fortfahren.

### Manuelle Installation

```bash
## Datenbank initialisieren
./Yearning install

## Yearning starten
./Yearning run

## Hilfe
./Yearning --help
```

### 🚀 Bereitstellung mit Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Datenbank initialisieren
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Yearning starten
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 KI-Unterstützung

Unser KI-Assistent nutzt ein großes Sprachmodell, um SQL-Optimierungsvorschläge und Text-zu-SQL-Umwandlung bereitzustellen. Ob mit Standard- oder benutzerdefinierten Prompts – der KI-Assistent verbessert die SQL-Performance, indem er Anweisungen optimiert und natürliche Sprache in SQL-Abfragen umwandelt.

![Text zu SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Automatischer SQL-Prüfer

Der automatische SQL-Prüfer bewertet SQL-Anweisungen anhand vordefinierter Regeln und Syntax. Er stellt sicher, dass Anweisungen bestimmten Codierungsstandards, Best Practices und Sicherheitsanforderungen entsprechen und bietet eine robuste Validierungsebene.

![SQL-Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 SQL-Syntaxhervorhebung und Auto-Vervollständigung

Steigern Sie Ihre Effizienz beim Schreiben von Abfragen mit SQL-Syntaxhervorhebung und Auto-Vervollständigung. Diese Funktionen helfen Nutzern, verschiedene Komponenten einer SQL-Abfrage wie Schlüsselwörter, Tabellennamen, Spaltennamen und Operatoren visuell zu unterscheiden und erleichtern das Lesen und Verstehen der Abfragestruktur.

![SQL-Abfrage](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Ticket-/Abfrageprotokoll

Unsere Plattform unterstützt das Auditieren von Benutzer-Tickets und Abfrageanweisungen. Diese Funktion ermöglicht es Ihnen, alle Abfragevorgänge einschließlich Datenquellen, Datenbanken und die Verarbeitung sensibler Felder zu verfolgen und zu protokollieren, um die Einhaltung von Vorschriften zu gewährleisten und die Nachverfolgbarkeit der Abfragehistorie sicherzustellen.

![Ticket-/Abfrageprotokoll](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Durch den Fokus auf diese Schlüsselmerkmale verbessert Yearning das Benutzererlebnis, optimiert die SQL-Performance und gewährleistet robuste Compliance und Nachverfolgbarkeit in Datenbankoperationen.

## 🛠️ Empfohlene Tools

- [Spug – Open Source Lightweight Automation Operations Platform](https://github.com/openspug/spug)

## ☎️ Kontakt

Für Anfragen schreiben Sie bitte eine E-Mail an: henry@yearning.io
## 📋 Lizenz

Yearning ist unter der AGPL-Lizenz lizenziert. Siehe [LICENSE](LICENSE) für Details.

2024 © Henry Yee

---

Mit Yearning erleben Sie einen schlanken, sicheren und effizienten Ansatz für SQL-Auditing und -Optimierung.


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