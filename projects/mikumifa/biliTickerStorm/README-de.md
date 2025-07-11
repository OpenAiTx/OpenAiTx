# 🎫 BiliTickerStorm

## ⚙️ Servicebeschreibung

| Dienstname           | Beschreibung                  | Anmerkung      |
| -------------------- | ---------------------------- | -------------- |
| `ticket-master`      | Hauptsteuerdienst, zuständig für die Aufgabenkoordination | Einzelinstanz |
| `ticket-worker`      | Ticket-Worker, horizontal skalierbar                  | Mehrfachinstanzen unterstützt |
| `gt-python`          | Dienst zur Bildverifizierung (Captcha)                | Einzelinstanz |

---

## 🚀 Schnelle Bereitstellungsschritte

> Der Clusteraufbau kann anhand des [Clusteraufbau-Leitfadens](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md) erfolgen.

<details> <summary><strong>📦 Installation aus Remote-Repository (empfohlen)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Chart installieren

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` ist das Verzeichnis für die Ticket-Konfigurationsdateien, das für den `ticket-master` Container gemountet wird. Die Ticket-Konfigurationsdateien werden mit https://github.com/mikumifa/biliTickerBuy erstellt.
> - `ticketWorker.pushplusToken` ist die Pushplus Push-Konfiguration. Nach der Einstellung können Benachrichtigungen über das Ticket-Ergebnis empfangen werden.
> - `ticketWorker.ticketInterval` ist das Intervall für die Ticket-Erfassung in Millisekunden, Standardwert ist 300 Millisekunden.
> - `ticketWorker.ticketTimeStart` ist die Startzeit für das zeitgesteuerte Beginnen im Format `2025-05-20T13:14`. Wenn nicht angegeben, startet die Ticket-Erfassung direkt beim Start des Containers.

### 3. Chart aktualisieren

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details>
<details> <summary><strong>📦 Lokale Chart-Installation</strong></summary>


### 1. Chart installieren

```bash
# Repository klonen
git clone https://github.com/mikumifa/biliTickerStorm
# Lokales Chart-Paket verwenden
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Chart aktualisieren

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 Allgemeine Befehle</strong></summary>

### ⏹ Deinstallation
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Haftungsausschluss

Dieses Projekt unterliegt der MIT-Lizenz und ist ausschließlich für den persönlichen Lern- und Forschungsgebrauch bestimmt. Die Nutzung dieses Projekts zu kommerziellen Zwecken ist untersagt, ebenso jegliche Verwendung für automatisierte Käufe, illegale Aktivitäten oder Verstöße gegen die Regeln der jeweiligen Plattform. Alle daraus resultierenden Konsequenzen liegen allein in der Verantwortung des Nutzers und haben nichts mit dem Urheber zu tun.

Wenn Sie dieses Projekt forken oder verwenden, halten Sie sich bitte unbedingt an die geltenden Gesetze, Vorschriften und die Regeln der Zielplattform.

## 💡 Über Zugriffsfrequenz und Parallelitätskontrolle
Bei der Entwicklung dieses Projekts wurde streng das Prinzip der „Nicht-Intrusivität“ beachtet, um jegliche Störung der Zielserver (wie Bilibili) zu vermeiden.

Alle Zeitabstände zwischen Netzwerk-Anfragen sind vom Nutzer selbst konfigurierbar; die Standardwerte simulieren die Geschwindigkeit manueller Bedienung durch normale Nutzer. Das Programm läuft standardmäßig im Einzelthread-Betrieb, ohne parallele Aufgaben. Bei fehlgeschlagenen Anfragen unternimmt das Programm eine begrenzte Anzahl von Wiederholungsversuchen und fügt zwischen den Versuchen angemessene Verzögerungen ein, um hohe Anfragefrequenzen zu vermeiden. Das Projekt verlässt sich ausschließlich auf öffentliche Schnittstellen und Webseitenstrukturen der Plattform und enthält keine destruktiven Methoden wie Umgehung von Risikokontrollen oder API-Manipulation.
## 🛡️ Plattform-Respekt-Erklärung

Bei der Entwicklung dieses Programms wurde darauf geachtet, die Anfragefrequenz so weit wie möglich zu kontrollieren, um jegliche erkennbare Belastung oder Beeinträchtigung der Bilibili-Server zu vermeiden. Das Projekt dient ausschließlich Lernzwecken, besitzt keine Fähigkeiten für großflächige oder hochparallele Anwendungen und verfolgt keinerlei böswillige Absichten oder Störungen des Dienstes.

Sollte dieses Projekt Inhalte enthalten, die die legitimen Rechte und Interessen der Firma Bilibili verletzen, kontaktieren Sie mich bitte per E-Mail unter [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com). Ich werde die betreffenden Inhalte umgehend entfernen und dieses Repository löschen. Für dadurch entstehende Unannehmlichkeiten entschuldige ich mich aufrichtig und danke Ihnen für Ihr Verständnis und Ihre Nachsicht.

## 📄 Lizenz

[MIT License](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---