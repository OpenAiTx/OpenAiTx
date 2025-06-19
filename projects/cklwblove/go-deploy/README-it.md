# Go-Deploy Strumento di Deploy

Uno strumento di deploy automatizzato sviluppato in Go, che supporta il caricamento dei file di build locali su un server remoto tramite protocollo SFTP.

## Caratteristiche

- ✅ **Trasferimento sicuro**: utilizza il protocollo SFTP, con trasferimento crittografato basato su SSH
- ✅ **Sincronizzazione directory**: caricamento ricorsivo dell’intera struttura delle directory, mantenendo la gerarchia dei file
- ✅ **Creazione intelligente**: creazione automatica della struttura delle directory remote
- ✅ **Adattamento automatico del percorso**: calcolo automatico del percorso locale in base alla posizione dell’eseguibile, senza preoccuparsi della directory di esecuzione
- ✅ **Supporto file di configurazione**: supporta file di configurazione JSON, facilitando la gestione delle configurazioni per ambienti diversi
- ✅ **Esclusione file**: supporta pattern con caratteri jolly per escludere file che non devono essere caricati
- ✅ **Backup automatico**: possibilità di eseguire automaticamente il backup dei file remoti prima del caricamento
- ✅ **Meccanismo di retry**: ritenta automaticamente il caricamento in caso di fallimento, aumentando il tasso di successo
- ✅ **Statistiche dettagliate**: mostra il numero di file caricati, la dimensione trasferita, il tempo impiegato e la velocità
- ✅ **Visualizzazione progressi**: mostra in tempo reale lo stato di avanzamento del caricamento e le informazioni sui file
- ✅ **Gestione degli errori**: gestione completa degli errori e output di log

## Requisiti di sistema

- Go 1.18 o versione superiore
- Il server di destinazione deve supportare il protocollo SSH/SFTP

## Istruzioni di installazione

### 1. Clonare il progetto

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Inizializzare il modulo Go

```bash
go mod init go-deploy
go mod tidy
```

### 3. Installare le dipendenze

Il programma scaricherà automaticamente le seguenti dipendenze:

- `github.com/pkg/sftp` - Client SFTP
- `golang.org/x/crypto/ssh` - Client SSH

## Istruzioni di configurazione

Il programma supporta due modalità di configurazione:

### 1. Utilizzo di un file di configurazione (consigliato)

Copiare `config.example.json` come `config.json` e modificarlo:

```bash
cp config.example.json config.json
```

Poi modificare `config.json`:

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

#### Descrizione delle opzioni di configurazione

**Configurazione server**:

- `host`: indirizzo del server SSH
- `port`: porta SSH, solitamente 22
- `username`: nome utente SSH
- `password`: password SSH (in produzione si consiglia l’autenticazione tramite chiave)
- `timeout`: tempo massimo di attesa per la connessione (secondi)

**Configurazione paths**:

- `local`: percorso della directory locale, supporta sia percorsi relativi che assoluti
- `remote`: percorso della directory remota, deve essere un percorso assoluto

**Configurazione options**:

- `backup`: se eseguire il backup dei file remoti esistenti prima del caricamento
- `backup_suffix`: suffisso per i file di backup, personalizzabile; se il file di backup non esiste il backup viene saltato
- `exclude_patterns`: pattern di esclusione dei file, supporta caratteri jolly
- `max_retries`: numero massimo di tentativi in caso di fallimento del caricamento
- `chunk_size`: dimensione del blocco di trasferimento file (byte, non ancora implementato)

### 2. Configurazione predefinita (modalità compatibilità)

Se il file `config.json` non è presente, il programma utilizzerà la configurazione predefinita interna, garantendo la retrocompatibilità.

#### Priorità dei file di configurazione

1. **File di configurazione specificato da linea di comando**: file indicato con il parametro `--config`
2. **File di configurazione predefinito**: `config.json` nella directory corrente
3. **Configurazione predefinita interna**: se nessuno dei precedenti è presente, viene utilizzata la configurazione interna al programma

#### Regole di gestione dei percorsi

- **Percorso del file di configurazione**:

  - Percorso relativo: rispetto alla directory in cui si trova l’eseguibile
  - Percorso assoluto: utilizza direttamente il percorso specificato
- **Percorso directory locale**:

  - Percorso relativo: rispetto alla directory in cui si trova l’eseguibile
  - Percorso assoluto: utilizza direttamente il percorso specificato

## Istruzioni per l’esecuzione

### Parametri da linea di comando

Il programma supporta i seguenti parametri:

```bash
# Mostra le informazioni di aiuto
./deploy --help

# Mostra le informazioni sulla versione  
./deploy --version

# Utilizza il file di configurazione predefinito config.json
./deploy

# Utilizza uno specifico file di configurazione
./deploy --config prod.json

# Utilizza un file di configurazione con percorso assoluto
./deploy --config /path/to/config.json
```

### Esecuzione in ambiente di sviluppo

```bash
# Utilizza la configurazione predefinita
go run main.go

# Utilizza uno specifico file di configurazione
go run main.go --config test.json

# Mostra la guida
go run main.go --help
```

### Esecuzione dopo la compilazione

```bash
# Compila
go build -o deploy main.go

# Esegui con la configurazione predefinita
./deploy

# Esegui con uno specifico file di configurazione
./deploy --config prod.json
```

## Istruzioni per il packaging

### 1. Packaging per la piattaforma locale

```bash
# Compila l’eseguibile per la piattaforma corrente
go build -o deploy main.go
```

### 2. Packaging cross-platform

#### Linux 64bit

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64bit
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64 bit

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. Ottimizzazione del packaging (riduzione della dimensione del file)

```bash
# Rimuovere informazioni di debug e simboli
go build -ldflags="-s -w" -o deploy main.go

# Comprimere con UPX (è necessario installare UPX)
upx --best deploy
```

### 4. Script di build multipiattaforma

Crea lo script `build.sh`:

```bash
#!/bin/bash

# Crea la directory di build
mkdir -p builds

# Build per ciascuna piattaforma
echo "Costruzione versione Linux 64 bit..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Costruzione versione Windows 64 bit..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "Costruzione versione macOS 64 bit..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "Costruzione versione macOS ARM64..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "Build completata!"
ls -la builds/
```

Esegui lo script:

```bash
chmod +x build.sh
./build.sh
```

## Esempi di utilizzo

### Mostrare le informazioni di aiuto

```bash
$ ./deploy --help
Go-Deploy Strumento di deploy

Utilizzo: ./deploy [opzioni]

Opzioni:
  -config string
        Percorso del file di configurazione (default "config.json")
  -help
        Mostra le informazioni di aiuto
  -version
        Mostra le informazioni sulla versione

Esempi:
  ./deploy                           # Usa il file di configurazione predefinito config.json
  ./deploy --config prod.json        # Usa un file di configurazione specificato
  ./deploy --config /path/to/config.json  # Usa un file di configurazione con percorso assoluto
```

### Utilizzare un file di configurazione specifico

```bash
$ ./deploy --config prod.json
Avvio del programma di deploy...
Tentativo di lettura del file di configurazione: /path/to/go-deploy/prod.json
Utilizzo del file di configurazione...
La directory locale /path/to/project/dist esiste
Connessione al server SSH in corso...
Connessione al server SSH riuscita
...
```

### Utilizzare il file di configurazione

```bash
$ ./deploy
Avvio del programma di deploy...
Tentativo di lettura del file di configurazione: /path/to/go-deploy/config.json
Utilizzo del file di configurazione...
La directory locale /path/to/project/unpackage/dist/build/web esiste
Connessione al server SSH in corso...
Connessione al server SSH riuscita
Creazione client SFTP in corso...
Client SFTP creato con successo
Preparazione upload nella directory remota: /opt/xsoft/nginx/html/app/dist
Avvio upload directory...
Scansione della directory locale: /path/to/project/unpackage/dist/build/web
Creazione directory: /opt/xsoft/nginx/html/app/dist
File static/js/app.js.map escluso, upload saltato
Creazione backup: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Upload file: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
File .DS_Store escluso, upload saltato
Upload file: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Upload fallito (tentativo 1/3): errore di rete
Retry upload file (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
Upload file: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
Upload directory completato con successo!
Statistiche:
  - File caricati: 485
  - Cartelle create: 18
  - Dimensione trasferita: 25.8 MB
  - Tempo upload: 38.5s
  - Tempo totale: 39.2s
  - Velocità trasferimento: 0.67 MB/s
```

## Note

1. **Sicurezza**:

   - Si consiglia di usare l'autenticazione tramite chiave SSH invece della password in ambienti di produzione
   - Attualmente viene usato `ssh.InsecureIgnoreHostKey()`, in produzione si dovrebbe verificare la chiave dell'host
2. **Rete**:

   - Assicurarsi che la porta 22 del server di destinazione sia raggiungibile dalla macchina locale
   - La velocità di trasferimento dipende dalla banda di rete e dalle prestazioni del server
3. **Permessi**:

   - Verificare che l'utente SSH abbia i permessi di scrittura sulla directory di destinazione
   - Se necessario, usare i privilegi sudo
4. **Percorsi**:

   - Il percorso locale viene calcolato automaticamente in base alla posizione dell'eseguibile, non è necessario preoccuparsi della directory di lavoro
   - Il percorso remoto deve essere assoluto

## Risoluzione dei problemi

### Problemi comuni

1. **Timeout di connessione**

   ```
   Connessione al server SSH fallita: dial tcp: i/o timeout
   ```

   - Verificare indirizzo e porta del server
   - Controllare la connettività di rete
   - Verificare le impostazioni del firewall
2. **Autenticazione fallita**

   ```
   Login fallito: ssh: handshake failed
   ```

   - Verificare username e password
   - Controllare che il servizio SSH sia attivo
   - Verificare la configurazione SSH
3. **Errore di permessi**

   ```
   Creazione directory fallita: permission denied
   ```

   - Verificare i permessi di scrittura dell'utente sulla directory di destinazione
   - Potrebbe essere necessario usare sudo o cambiare proprietario della directory
4. **Directory locale non esistente**

   ```
   Errore: la directory locale /path/to/unpackage/dist/build/web non esiste
   ```

   - Verificare che la build locale sia stata completata
   - Controllare che la struttura delle cartelle del progetto sia corretta
   - Il programma calcola automaticamente il percorso, non è necessario modificare manualmente la directory di lavoro

## Note di sviluppo

### Struttura del progetto

```
go-deploy/
├── main.go                 # File principale del programma
├── go.mod                  # File modulo Go  
├── go.sum                  # File di checksum delle dipendenze
```
├── [README.md](https://raw.githubusercontent.com/cklwblove/go-deploy/main/README.md)               # Documentazione dettagliata  
├── [Makefile](https://raw.githubusercontent.com/cklwblove/go-deploy/main/Makefile)                # Strumento di build  
├── [build.sh](https://raw.githubusercontent.com/cklwblove/go-deploy/main/build.sh)                # Script di packaging batch  
├── [install.sh](https://raw.githubusercontent.com/cklwblove/go-deploy/main/install.sh)            # Script di installazione one-click  
└── [config.example.json](https://raw.githubusercontent.com/cklwblove/go-deploy/main/config.example.json)     # Esempio di file di configurazione  
```

### Funzioni principali

- `main()` - Funzione principale, gestisce la connessione e invoca il caricamento
- `uploadDirectory()` - Caricamento ricorsivo della directory
- `uploadFile()` - Caricamento di un singolo file
- `mkdirAll()` - Creazione ricorsiva delle directory remote

## Licenza

Licenza MIT

## Contributi

Sono benvenuti Issue e Pull Request!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---