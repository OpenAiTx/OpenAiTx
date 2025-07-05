# TeamSpeak 6 Server - Beta Release README

Willkommen zur Beta-Version des TeamSpeak 6 Servers! Wir freuen uns, dass Sie dabei sind, um die nächste Generation von TeamSpeak zu entdecken. Dieses Dokument wird Sie beim Einstieg unterstützen und wichtige Details zur aktuellen Beta hervorheben.

Da es sich um eine Beta-Version handelt, befinden sich einige Funktionen noch in der Entwicklung und Sie könnten auf Fehler stoßen. Ihr Feedback ist wichtig und hilft uns, eine stabilere und vollständigere endgültige Version zu gestalten.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;Über TeamSpeak</h2>

Bewährt und getestet seit fast 25 Jahren, bieten wir eine Lösung, die für jeden Bedarf passt. TeamSpeak bietet die ideale Sprachkommunikation für Gaming, Bildung und Training, interne Geschäftskommunikation sowie den Kontakt mit Freunden und Familie. Unser Hauptaugenmerk liegt auf einer einfach zu bedienenden Lösung mit hohen Sicherheitsstandards, ausgezeichneter Sprachqualität sowie geringem System- und Bandbreitenverbrauch.

## ℹ️ Beta-Status & Bekannte Probleme
**Dies ist eine Beta-Version. Das Hauptziel ist es, vielfältiges Feedback zu sammeln und potenzielle Probleme zu identifizieren, bevor die stabile Version veröffentlicht wird.**

**Self-Hosted Server-Dateien:** Die dedizierte Server-Software für TeamSpeak 6 befindet sich weiterhin in aktiver Entwicklung und ist noch nicht vollständig funktionsfähig. Wir setzen alles daran, das vollständige TS6-Erlebnis auch für selbst gehostete Server bereitzustellen.

**Funktionsinstabilität:** Einige der neuen Funktionen können instabil sein oder sich ändern, während wir sie weiter verfeinern.

**Feedback ist essenziell:** Ihre Erfahrungen sind unschätzbar und Ihr Input ist für uns von großer Bedeutung. Bitte melden Sie Probleme oder teilen Sie Ihre Vorschläge in unserem [Community-Forum](https://community.teamspeak.com/c/teamspeak-6-server/45) oder direkt hier auf [GitHub](https://github.com/teamspeak/teamspeak6-server/issues).

**Einschränkungen:** Bitte beachten Sie, dass **TeamSpeak 3 Server-Lizenzen nicht kompatibel** mit TeamSpeak 6 Servern sind und es derzeit **keinen Migrationspfad zwischen den beiden Versionen gibt**.

**Preview-Lizenz:** Als Reaktion auf Ihr Feedback kommt der Server nun mit einer **temporären** 32-Slot-Preview-Lizenz, um während des Evaluierungszeitraums mehr Flexibilität zu bieten. Bitte beachten Sie, dass diese Lizenz **nur zwei Monate gültig ist**.

Darüber hinaus ist es **derzeit noch nicht möglich, eine größere Lizenz für TeamSpeak 6 zu erhalten oder ein Upgrade durchzuführen**.

Wir danken Ihnen für Ihre Geduld und Ihr Verständnis, während wir weiterhin an Lösungen arbeiten, um Ihre Anforderungen in Zukunft besser zu unterstützen.

## 👇 Einstieg in TS6
Um mit dem TeamSpeak 6 Client zu starten, besuchen Sie bitte unsere [Downloads](https://teamspeak.com/en/downloads/) Seite.

Informationen zum Self-Hosting finden Sie im kurzen Leitfaden weiter unten. Für die neuesten Updates, Ankündigungen und um sich mit der TeamSpeak-Community auszutauschen, besuchen Sie unser [Community-Forum](https://community.teamspeak.com/) und folgen Sie uns auf [Twitter](https://x.com/teamspeak).

Sie möchten nicht selbst hosten oder suchen einfach einen leichteren Einstieg in TeamSpeak 6? Sie können zuverlässige und offizielle TeamSpeak 6 Server direkt über uns bei [TeamSpeak Communities](https://www.myteamspeak.com/communities) mieten.
## ⚙️ Konfiguration
### Sie können Ihren Server auf drei Hauptwegen konfigurieren:

1. **Kommandozeilen-Argumente:** Übergeben Sie Optionen direkt beim Starten des Servers (z.B. ./tsserver --default-voice-port 9987). Dies ist nützlich für temporäre Änderungen oder beim Scripting.

2. **Umgebungsvariablen:** Setzen Sie Umgebungsvariablen, bevor Sie den Server starten. Dies ist nützlich für Docker oder wenn Sie die Kommandozeile übersichtlich halten möchten.

3. **YAML-Konfigurationsdatei:** Für eine dauerhafte Konfiguration wird dringend empfohlen, eine tsserver.yaml-Datei zu verwenden. Sie können eine Standard-Konfigurationsdatei mit dem --write-config-file-Flag erzeugen.

Wichtige Einstellungen, die Sie steuern können, beinhalten Netzwerkports (Voice, File Transfer), Datenbankverbindungen (unterstützt SQLite und MariaDB), IP-Bindings und Logging-Optionen.

Für eine vollständige Liste aller verfügbaren Optionen starten Sie den Server mit dem `--help`-Flag oder konsultieren Sie die [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md).

### Server mit Binärdateien ausführen
Wenn Sie kein Docker verwenden, können Sie den Server direkt auf Ihrem Betriebssystem ausführen.

<h2><img width="22" src="/icons/linux.svg">&nbsp;Unter Linux:</h2>

Machen Sie die Server-Binärdatei ausführbar:
```sh
chmod +x tsserver
```

Starten Sie den Server aus Ihrem Terminal und akzeptieren Sie die Lizenz:

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;Unter Windows:</h2>

Öffnen Sie die Eingabeaufforderung oder PowerShell und navigieren Sie zu dem Verzeichnis, in das Sie die Serverdateien entpackt haben.

Führen Sie die Server-Exe aus und akzeptieren Sie die Lizenz:
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Server mit Docker ausführen (Empfohlen):</h2>
Docker ist der einfachste Weg, um den TeamSpeak 6 Server in einer isolierten und gut verwaltbaren Umgebung zu betreiben.

### 1. Einfacher docker run-Befehl:

Für einen schnellen Start können Sie den docker run-Befehl verwenden.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. Mit docker-compose.yaml (für dauerhafte Setups):
Dies ist die empfohlene Vorgehensweise für einen Server, der dauerhaft laufen soll. Erstellen Sie eine docker-compose.yaml-Datei:

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # Voice Port
      - "30033:30033/tcp" # File Transfer
      # - "10080:10080/tcp" # Web Query
    environment:
```
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 Nützliche Links
[Offizielle Website](https://teamspeak.com/de/)<br>
[Community-Forum](https://community.teamspeak.com)<br>
[GitHub Issues](https://github.com/teamspeak/teamspeak6-server/issues)<br>

Ihre Teilnahme und Ihr Feedback helfen uns, die Zukunft von TeamSpeak zu gestalten! 💙<br>
Vielen Dank, dass Sie Teil des TeamSpeak 6 Beta-Programms sind und zu dessen Fortschritt beitragen! 🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---