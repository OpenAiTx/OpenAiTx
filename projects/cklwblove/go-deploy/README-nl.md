# Go-Deploy Deploy Tool

Een op Go gebaseerde geautomatiseerde deployment tool die ondersteunt dat lokale build-artifacten via het SFTP-protocol naar een externe server worden geüpload.

## Functies en Eigenschappen

- ✅ **Veilige overdracht**: gebruikt SFTP-protocol, gebaseerd op SSH-encryptie
- ✅ **Directory-synchronisatie**: recursief uploaden van volledige directorystructuren, behoudt de bestandsstructuur
- ✅ **Intelligent aanmaken**: maakt automatisch de remote directorystructuur aan
- ✅ **Padaanpassing**: berekent automatisch het lokale pad op basis van de locatie van het uitvoerbare bestand, geen zorg om werkdirectory
- ✅ **Configuratiebestand ondersteuning**: ondersteunt JSON-configuratiebestanden, handig voor beheer van verschillende omgevingen
- ✅ **Bestandsexclusie**: ondersteunt wildcard-patronen om niet-gewenste bestanden uit te sluiten van upload
- ✅ **Automatische back-up**: kan automatisch remote bestanden back-uppen vóór upload
- ✅ **Retry-mechanisme**: automatische herpoging bij upload-falen, verhoogt succeskans
- ✅ **Gedetailleerde statistieken**: toont aantal geüploade bestanden, overdrachtsgrootte, tijd en snelheid
- ✅ **Voortgangsweergave**: realtime weergave van uploadvoortgang en bestandsinformatie
- ✅ **Foutafhandeling**: uitgebreide foutafhandeling en log-output

## Systeemeisen

- Go 1.18 of hoger
- Doelserver ondersteunt SSH/SFTP-protocol

## Installatie-instructies

### 1. Project klonen

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Go-module initialiseren

```bash
go mod init go-deploy
go mod tidy
```

### 3. Afhankelijkheden installeren

Het programma downloadt automatisch de volgende afhankelijkheden:

- `github.com/pkg/sftp` - SFTP-client
- `golang.org/x/crypto/ssh` - SSH-client

## Configuratie-instructies

Het programma ondersteunt twee configuratiemethoden:

### 1. Gebruik van configuratiebestand (aanbevolen)

Kopieer `config.example.json` naar `config.json` en pas de configuratie aan:

```bash
cp config.example.json config.json
```

Bewerk daarna `config.json`:

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

#### Uitleg van configuratieopties

**server-configuratie**:

- `host`: SSH-serveradres
- `port`: SSH-poort, meestal 22
- `username`: SSH-gebruikersnaam
- `password`: SSH-wachtwoord (voor productie-omgevingen wordt sleutelauthenticatie aanbevolen)
- `timeout`: Verbindings-timeout (seconden)

**paths-configuratie**:

- `local`: Lokaal directorypad, ondersteunt relatieve en absolute paden
- `remote`: Remote directorypad, moet een absoluut pad zijn

**options-configuratie**:

- `backup`: Of er een back-up van bestaande remote bestanden gemaakt moet worden vóór upload
- `backup_suffix`: Extensie van het back-upbestand, kan naar wens worden ingesteld; als het back-upbestand niet bestaat, wordt back-up overgeslagen
- `exclude_patterns`: Uitsluitingspatronen voor bestanden, ondersteunt wildcards
- `max_retries`: Maximaal aantal pogingen bij upload-falen
- `chunk_size`: Grootte van het overdrachtsblok (bytes, nog niet geïmplementeerd)

### 2. Standaardconfiguratie (compatibiliteitsmodus)

Als er geen `config.json`-bestand is, gebruikt het programma de ingebouwde standaardconfiguratie voor achterwaartse compatibiliteit.

#### Prioriteit van configuratiebestanden

1. **Configuratiebestand opgegeven via commandline**: Bestand gespecificeerd met de `--config` parameter
2. **Standaardconfiguratiebestand**: `config.json` in de huidige directory
3. **Ingebouwde standaardconfiguratie**: Als bovenstaande niet aanwezig zijn, wordt de ingebouwde configuratie gebruikt

#### Padverwerkingsregels

- **Pad van configuratiebestand**:

  - Relatief pad: Gebaseerd op de directory van het uitvoerbare bestand
  - Absoluut pad: Direct het opgegeven pad gebruiken
- **Lokaal directorypad**:

  - Relatief pad: Gebaseerd op de directory van het uitvoerbare bestand
  - Absoluut pad: Direct het opgegeven pad gebruiken

## Gebruiksinstructies

### Commandline-parameters

Het programma ondersteunt de volgende commandline-parameters:

```bash
# Toon helpinformatie
./deploy --help

# Toon versie-informatie  
./deploy --version

# Gebruik standaardconfiguratiebestand config.json
./deploy

# Gebruik opgegeven configuratiebestand
./deploy --config prod.json

# Gebruik absoluut pad naar configuratiebestand
./deploy --config /path/to/config.json
```

### Uitvoeren in ontwikkelomgeving

```bash
# Gebruik standaardconfiguratie
go run main.go

# Gebruik opgegeven configuratiebestand
go run main.go --config test.json

# Toon help
go run main.go --help
```

### Uitvoeren na compilatie

```bash
# Compileren
go build -o deploy main.go

# Gebruik standaardconfiguratie
./deploy

# Gebruik opgegeven configuratiebestand
./deploy --config prod.json
```

## Inpak-instructies

### 1. Lokale platform builden

```bash
# Compileer uitvoerbaar bestand voor huidig platform
go build -o deploy main.go
```

### 2. Cross-platform builden

#### Linux 64-bit

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64-bit
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64-bit

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. Optimaliseren van het pakketproces (bestandsgrootte verkleinen)

```bash
# Verwijder debug-informatie en symbooltabellen
go build -ldflags="-s -w" -o deploy main.go

# Comprimeer met UPX (eerst UPX installeren)
upx --best deploy
```

### 4. Batch build script

Maak het `build.sh` script aan:

```bash
#!/bin/bash

# Maak build map aan
mkdir -p builds

# Build voor verschillende platforms
echo "Bouwen van Linux 64-bit versie..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Bouwen van Windows 64-bit versie..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "Bouwen van macOS 64-bit versie..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "Bouwen van macOS ARM64 versie..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "Bouwen voltooid!"
ls -la builds/
```

Voer het script uit:

```bash
chmod +x build.sh
./build.sh
```

## Gebruiksvoorbeeld

### Toon helpinformatie

```bash
$ ./deploy --help
Go-Deploy implementatie tool

Gebruik: ./deploy [opties]

Opties:
  -config string
        Pad naar configuratiebestand (standaard "config.json")
  -help
        Toon helpinformatie
  -version
        Toon versie-informatie

Voorbeelden:
  ./deploy                           # Gebruik standaardconfiguratiebestand config.json
  ./deploy --config prod.json        # Gebruik opgegeven configuratiebestand
  ./deploy --config /path/to/config.json  # Gebruik absoluut pad naar configuratiebestand
```

### Gebruik opgegeven configuratiebestand

```bash
$ ./deploy --config prod.json
Starten van implementatieprogramma...
Probeer configuratiebestand te lezen: /path/to/go-deploy/prod.json
Configuratiebestand wordt gebruikt...
Lokale map /path/to/project/dist bestaat
Bezig met verbinden met SSH-server...
SSH-serververbinding succesvol
...
```

### Gebruik configuratiebestand

```bash
$ ./deploy
Starten van implementatieprogramma...
Probeer configuratiebestand te lezen: /path/to/go-deploy/config.json
Configuratiebestand wordt gebruikt...
Lokale map /path/to/project/unpackage/dist/build/web bestaat
Bezig met verbinden met SSH-server...
SSH-serververbinding succesvol
Bezig met maken van SFTP-client...
SFTP-client succesvol aangemaakt
Voorbereiden upload naar remote map: /opt/xsoft/nginx/html/app/dist
Starten met uploaden van map...
Lokale map wordt doorlopen: /path/to/project/unpackage/dist/build/web
Map aanmaken: /opt/xsoft/nginx/html/app/dist
Bestand static/js/app.js.map uitgesloten, upload overgeslagen
Back-up aanmaken: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Uploaden bestand: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
Bestand .DS_Store uitgesloten, upload overgeslagen
Uploaden bestand: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Upload mislukt (poging 1/3): Netwerkfout
Opnieuw proberen upload bestand (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
Uploaden bestand: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
Map succesvol geüpload!
Statistieken:
  - Aantal geüploade bestanden: 485
  - Aantal aangemaakte mappen: 18
  - Overgedragen grootte: 25.8 MB
  - Uploadtijd: 38.5s
  - Totale tijd: 39.2s
  - Overdrachtsnelheid: 0.67 MB/s
```

## Opmerkingen

1. **Veiligheid**:

   - Gebruik in productieomgevingen SSH-sleutelauthenticatie in plaats van wachtwoordauthenticatie
   - Momenteel wordt `ssh.InsecureIgnoreHostKey()` gebruikt, valideer in productie de hostkey
2. **Netwerk**:

   - Zorg dat lokaal poort 22 van de doelserver bereikbaar is
   - Overdrachtsnelheid is afhankelijk van netwerkbandbreedte en serverprestaties
3. **Rechten**:

   - Zorg dat SSH-gebruiker schrijfrechten heeft op de doellocatie
   - Indien nodig zijn sudo-rechten vereist
4. **Pad**:

   - Lokale paden worden automatisch berekend op basis van de uitvoerbare locatie, werklocatie is niet relevant
   - Remote pad gebruikt absoluut pad

## Probleemoplossing

### Veelvoorkomende problemen

1. **Verbindingstime-out**

   ```
   Verbinden met SSH-server mislukt: dial tcp: i/o timeout
   ```

   - Controleer serveradres en poort
   - Controleer netwerkverbinding
   - Controleer firewall-instellingen
2. **Authenticatie mislukt**

   ```
   Inloggen mislukt: ssh: handshake failed
   ```

   - Controleer gebruikersnaam en wachtwoord
   - Controleer of SSH-service actief is
   - Controleer SSH-configuratie
3. **Rechtenfout**

   ```
   Maken van map mislukt: permission denied
   ```

   - Controleer of gebruiker schrijfrechten heeft op het doeldirectory
   - Mogelijk is sudo vereist of moet eigenaar worden aangepast
4. **Lokale map bestaat niet**

   ```
   Fout: lokale map /path/to/unpackage/dist/build/web bestaat niet
   ```

   - Controleer of de lokale build is voltooid
   - Controleer de structuur van het projectdirectory
   - Het programma berekent het pad automatisch, handmatig wijzigen is niet nodig

## Ontwikkelaarsinformatie

### Projectstructuur

```
go-deploy/
├── main.go                 # Hoofdprogramma
├── go.mod                  # Go modulebestand  
├── go.sum                  # Afhankelijkheidscontrolebestand
```
├── README.md               # Gedetailleerde documentatie
├── Makefile                # Build-tool
├── build.sh                # Batch-packagescript
├── install.sh              # One-click installatiescript
└── config.example.json     # Voorbeeld van configuratiebestand
```

### Belangrijkste functies

- `main()` - Hoofdfunctie, verwerkt verbindingen en roept upload aan
- `uploadDirectory()` - Recursief uploaden van een map
- `uploadFile()` - Uploaden van een enkel bestand
- `mkdirAll()` - Recursief aanmaken van een externe map

## Licentie

MIT-licentie

## Bijdragen

Issues en Pull Requests zijn van harte welkom!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---