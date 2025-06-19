# Go-Deploy Deployment-Tool

Ein automatisiertes Deployment-Tool, entwickelt in Go, das den Upload von lokal gebauten Artefakten auf einen Remote-Server per SFTP-Protokoll unterstützt.

## Funktionsmerkmale

- ✅ **Sichere Übertragung**: Verwendung des SFTP-Protokolls, verschlüsselt über SSH
- ✅ **Verzeichnissynchronisation**: Rekursives Hochladen der gesamten Verzeichnisstruktur, Beibehaltung der Dateihierarchie
- ✅ **Intelligente Erstellung**: Automatisches Erstellen der Remote-Verzeichnisstruktur
- ✅ **Pfad-Adaption**: Automatische Berechnung des lokalen Pfades basierend auf dem Speicherort der ausführbaren Datei, kein Wechsel des Arbeitsverzeichnisses notwendig
- ✅ **Konfigurationsdatei-Support**: Unterstützung für JSON-Konfigurationsdateien, erleichtert das Management verschiedener Umgebungen
- ✅ **Dateiausschluss**: Unterstützung von Platzhalter-Mustern zum Ausschluss nicht benötigter Dateien
- ✅ **Automatische Sicherung**: Automatisches Backup der Remote-Dateien vor dem Upload möglich
- ✅ **Retry-Mechanismus**: Automatischer Wiederholungsversuch bei fehlgeschlagenem Upload, erhöht Erfolgsrate
- ✅ **Detaillierte Statistik**: Anzeige der Anzahl hochgeladener Dateien, Übertragungsvolumen, Dauer und Geschwindigkeit
- ✅ **Fortschrittsanzeige**: Echtzeit-Anzeige des Upload-Fortschritts und der Dateiinformationen
- ✅ **Fehlerbehandlung**: Ausgereiftes Fehlerhandling und Log-Ausgabe

## Systemanforderungen

- Go 1.18 oder neuer
- Zielserver unterstützt SSH/SFTP-Protokoll

## Installationsanleitung

### 1. Projekt klonen

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Go-Modul initialisieren

```bash
go mod init go-deploy
go mod tidy
```

### 3. Abhängigkeiten installieren

Das Programm lädt automatisch folgende Abhängigkeiten herunter:

- `github.com/pkg/sftp` - SFTP-Client
- `golang.org/x/crypto/ssh` - SSH-Client

## Konfigurationsanleitung

Das Programm unterstützt zwei Konfigurationsmethoden:

### 1. Verwendung einer Konfigurationsdatei (empfohlen)

Kopieren Sie `config.example.json` zu `config.json` und passen Sie die Einstellungen an:

```bash
cp config.example.json config.json
```

Bearbeiten Sie anschließend `config.json`:

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### Beschreibung der Konfigurationselemente

**server-Konfiguration**:

- `host`: Adresse des SSH-Servers
- `port`: SSH-Port, üblicherweise 22
- `username`: SSH-Benutzername
- `password`: SSH-Passwort (in Produktionsumgebungen wird die Verwendung von Schlüssel-Authentifizierung empfohlen)
- `timeout`: Verbindungs-Timeout (Sekunden)

**paths-Konfiguration**:

- `local`: Lokaler Verzeichnispfad, unterstützt relative und absolute Pfade
- `remote`: Remote-Verzeichnispfad, muss ein absoluter Pfad sein

**options-Konfiguration**:

- `backup`: Gibt an, ob vor dem Hochladen ein Backup der bereits auf dem Remote-System existierenden Dateien erstellt werden soll
- `backup_suffix`: Suffix für Backup-Dateien, anpassbar; wenn keine Backup-Datei existiert, wird das Backup übersprungen
- `exclude_patterns`: Dateiausschlussmuster, unterstützt Platzhalter
- `max_retries`: Maximale Anzahl an Wiederholungsversuchen bei fehlgeschlagenem Upload
- `chunk_size`: Größe der Dateiübertragungsblöcke (Bytes, derzeit noch nicht implementiert)

### 2. Standardkonfiguration (Kompatibilitätsmodus)

Falls keine `config.json` vorhanden ist, verwendet das Programm eine eingebaute Standardkonfiguration, um die Rückwärtskompatibilität zu gewährleisten.

#### Priorität der Konfigurationsdateien

1. **Per Kommandozeile angegebene Konfigurationsdatei**: Datei, die mit dem Parameter `--config` angegeben wurde
2. **Standard-Konfigurationsdatei**: `config.json` im aktuellen Verzeichnis
3. **Eingebaute Standardkonfiguration**: Falls obiges nicht existiert, wird die programminterne Konfiguration verwendet

#### Pfadverarbeitungsregeln

- **Pfad zur Konfigurationsdatei**:

  - Relativer Pfad: Bezogen auf das Verzeichnis der ausführbaren Datei
  - Absoluter Pfad: Es wird der angegebene Pfad direkt verwendet
- **Lokaler Verzeichnispfad**:

  - Relativer Pfad: Bezogen auf das Verzeichnis der ausführbaren Datei
  - Absoluter Pfad: Es wird der angegebene Pfad direkt verwendet

## Ausführungsanleitung

### Kommandozeilenparameter

Das Programm unterstützt folgende Kommandozeilenparameter:

```bash
# Hilfe anzeigen
./deploy --help

# Versionsinformation anzeigen  
./deploy --version

# Standard-Konfigurationsdatei config.json verwenden
./deploy

# Angegebene Konfigurationsdatei verwenden
./deploy --config prod.json

# Absolute Pfadangabe zur Konfigurationsdatei verwenden
./deploy --config /path/to/config.json
```

### Ausführung in der Entwicklungsumgebung

```bash
# Standardkonfiguration verwenden
go run main.go

# Angegebene Konfigurationsdatei verwenden
go run main.go --config test.json

# Hilfe anzeigen
go run main.go --help
```

### Ausführung nach Kompilierung

```bash
# Kompilieren
go build -o deploy main.go

# Mit Standardkonfiguration ausführen
./deploy

# Mit angegebener Konfigurationsdatei ausführen
./deploy --config prod.json
```

## Paketierungsanleitung

### 1. Paketierung für lokale Plattform

```bash
# Kompilieren der ausführbaren Datei für die aktuelle Plattform
go build -o deploy main.go
```

### 2. Cross-Plattform-Paketierung

#### Linux 64-bit

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64-bit
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64-Bit

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. Paketoptimierung (Dateigröße verringern)

```bash
# Entfernen von Debug-Informationen und Symboltabellen
go build -ldflags="-s -w" -o deploy main.go

# Komprimierung mit UPX (UPX muss vorher installiert werden)
upx --best deploy
```

### 4. Batch-Build-Skript

Erstellen Sie das Skript `build.sh`:

```bash
#!/bin/bash

# Erstellen des Build-Verzeichnisses
mkdir -p builds

# Bauen für verschiedene Plattformen
echo "Baue Linux 64-Bit-Version..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Baue Windows 64-Bit-Version..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "Baue macOS 64-Bit-Version..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "Baue macOS ARM64-Version..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "Build abgeschlossen!"
ls -la builds/
```

Skript ausführen:

```bash
chmod +x build.sh
./build.sh
```

## Anwendungsbeispiele

### Hilfe anzeigen

```bash
$ ./deploy --help
Go-Deploy Deployment-Tool

Verwendung: ./deploy [Optionen]

Optionen:
  -config string
        Pfad zur Konfigurationsdatei (default "config.json")
  -help
        Hilfe anzeigen
  -version
        Versionsinformationen anzeigen

Beispiele:
  ./deploy                           # Verwendet die Standardkonfiguration config.json
  ./deploy --config prod.json        # Verwendet eine angegebene Konfigurationsdatei
  ./deploy --config /path/to/config.json  # Verwendet eine absolute Konfigurationsdatei
```

### Konfigurationsdatei angeben

```bash
$ ./deploy --config prod.json
Starte Deployment...
Versuche, Konfigurationsdatei zu lesen: /path/to/go-deploy/prod.json
Verwende Konfigurationsdatei...
Lokales Verzeichnis /path/to/project/dist existiert
Verbinde mit SSH-Server...
SSH-Server erfolgreich verbunden
...
```

### Konfigurationsdatei verwenden

```bash
$ ./deploy
Starte Deployment...
Versuche, Konfigurationsdatei zu lesen: /path/to/go-deploy/config.json
Verwende Konfigurationsdatei...
Lokales Verzeichnis /path/to/project/unpackage/dist/build/web existiert
Verbinde mit SSH-Server...
SSH-Server erfolgreich verbunden
Erstelle SFTP-Client...
SFTP-Client erfolgreich erstellt
Vorbereitung zum Upload in Remote-Verzeichnis: /opt/xsoft/nginx/html/app/dist
Starte Upload des Verzeichnisses...
Beginne Durchlauf des lokalen Verzeichnisses: /path/to/project/unpackage/dist/build/web
Erstelle Verzeichnis: /opt/xsoft/nginx/html/app/dist
Datei static/js/app.js.map ausgeschlossen, überspringe Upload
Backup erstellen: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Datei hochladen: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
Datei .DS_Store ausgeschlossen, überspringe Upload
Datei hochladen: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Upload fehlgeschlagen (Versuch 1/3): Netzwerkfehler
Erneuter Upload (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
Datei hochladen: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
Verzeichnis erfolgreich hochgeladen!
Statistik:
  - Anzahl hochgeladener Dateien: 485
  - Erstellte Verzeichnisse: 18
  - Übertragene Größe: 25.8 MB
  - Upload-Dauer: 38.5s
  - Gesamtdauer: 39.2s
  - Übertragungsgeschwindigkeit: 0.67 MB/s
```

## Hinweise

1. **Sicherheit**:

   - Für Produktionsumgebungen wird die Authentifizierung mit SSH-Schlüsseln statt Passwort empfohlen
   - Aktuell wird `ssh.InsecureIgnoreHostKey()` verwendet, im Produktivbetrieb sollte der Host-Key überprüft werden
2. **Netzwerk**:

   - Stellen Sie sicher, dass der lokale Rechner den Port 22 des Zielservers erreichen kann
   - Die Übertragungsgeschwindigkeit hängt von der Netzwerkbandbreite und Serverleistung ab
3. **Berechtigungen**:

   - Stellen Sie sicher, dass der SSH-Benutzer Schreibrechte auf das Zielverzeichnis besitzt
   - Ggf. sind sudo-Rechte erforderlich
4. **Pfade**:

   - Der lokale Pfad wird automatisch relativ zum Pfad der ausführbaren Datei berechnet, das Arbeitsverzeichnis ist unerheblich
   - Der Remote-Pfad ist ein absoluter Pfad

## Fehlerbehebung

### Häufige Probleme

1. **Zeitüberschreitung bei Verbindung**

   ```
   Verbindung zum SSH-Server fehlgeschlagen: dial tcp: i/o timeout
   ```

   - Prüfen Sie Serveradresse und Port
   - Netzwerkverbindung sicherstellen
   - Firewall-Einstellungen überprüfen
2. **Authentifizierungsfehler**

   ```
   Anmeldung fehlgeschlagen: ssh: handshake failed
   ```

   - Prüfen Sie Benutzername und Passwort
   - Sicherstellen, dass der SSH-Dienst läuft
   - SSH-Konfiguration überprüfen
3. **Berechtigungsfehler**

   ```
   Verzeichnis-Erstellung fehlgeschlagen: permission denied
   ```

   - Schreibrechte für das Zielverzeichnis prüfen
   - Ggf. sudo verwenden oder Verzeichnisbesitzer ändern
4. **Lokales Verzeichnis nicht vorhanden**

   ```
   Fehler: Lokales Verzeichnis /path/to/unpackage/dist/build/web existiert nicht
   ```

   - Überprüfen, ob der lokale Build abgeschlossen ist
   - Prüfen, ob die Projektstruktur korrekt ist
   - Der Pfad wird automatisch berechnet, Arbeitsverzeichnis muss nicht manuell angepasst werden

## Entwicklungshinweise

### Projektstruktur

```
go-deploy/
├── main.go                 # Hauptprogrammdatei
├── go.mod                  # Go-Moduldatei  
├── go.sum                  # Abhängigkeits-Prüfsummen-Datei
```
├── README.md               # Ausführliche Dokumentation  
├── Makefile                # Build-Tool  
├── build.sh                # Batch-Paketierungsskript  
├── install.sh              # One-Click-Installationsskript  
└── config.example.json     # Beispiel für eine Konfigurationsdatei  
```

### Hauptfunktionen

- `main()` - Hauptfunktion, verarbeitet Verbindungen und ruft den Upload auf  
- `uploadDirectory()` - Rekursives Hochladen von Verzeichnissen  
- `uploadFile()` - Hochladen einzelner Dateien  
- `mkdirAll()` - Rekursives Erstellen von Remote-Verzeichnissen  

## Lizenz

MIT-Lizenz

## Beitrag

Issues und Pull Requests sind willkommen!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---