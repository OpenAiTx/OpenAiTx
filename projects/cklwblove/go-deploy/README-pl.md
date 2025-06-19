# Go-Deploy Narzędzie do wdrażania

Automatyczne narzędzie do wdrażania oparte na języku Go, umożliwiające przesyłanie lokalnych artefaktów budowania na zdalny serwer za pomocą protokołu SFTP.

## Funkcje

- ✅ **Bezpieczny transfer**: użycie protokołu SFTP, transmisja szyfrowana przez SSH
- ✅ **Synchronizacja katalogów**: rekurencyjne przesyłanie całej struktury katalogów z zachowaniem hierarchii plików
- ✅ **Inteligentne tworzenie**: automatyczne tworzenie struktury katalogów na serwerze zdalnym
- ✅ **Dostosowanie ścieżek**: automatyczne wyliczanie lokalnej ścieżki na podstawie położenia pliku wykonywalnego, bez konieczności dbania o katalog uruchomieniowy
- ✅ **Obsługa plików konfiguracyjnych**: wsparcie dla plików konfiguracyjnych JSON, ułatwiające zarządzanie konfiguracjami dla różnych środowisk
- ✅ **Wykluczanie plików**: obsługa wzorców z symbolami wieloznacznymi do wykluczania plików, których nie należy przesyłać
- ✅ **Automatyczna kopia zapasowa**: możliwość automatycznego tworzenia kopii zapasowej plików na serwerze przed przesłaniem
- ✅ **Mechanizm ponawiania**: automatyczne ponawianie przesyłania w przypadku niepowodzenia, zwiększając skuteczność operacji
- ✅ **Szczegółowe statystyki**: wyświetlanie liczby przesłanych plików, rozmiaru transferu, czasu trwania i prędkości
- ✅ **Wyświetlanie postępu**: bieżący podgląd postępu przesyłania i informacji o plikach
- ✅ **Obsługa błędów**: rozbudowana obsługa błędów i logowanie

## Wymagania systemowe

- Go 1.18 lub nowszy
- Serwer docelowy obsługujący protokół SSH/SFTP

## Instrukcja instalacji

### 1. Sklonuj repozytorium

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Inicjalizuj moduł Go

```bash
go mod init go-deploy
go mod tidy
```

### 3. Instalacja zależności

Program automatycznie pobierze następujące zależności:

- `github.com/pkg/sftp` - klient SFTP
- `golang.org/x/crypto/ssh` - klient SSH

## Instrukcja konfiguracji

Program obsługuje dwa tryby konfiguracji:

### 1. Użycie pliku konfiguracyjnego (zalecane)

Skopiuj `config.example.json` jako `config.json` i zmodyfikuj konfigurację:

```bash
cp config.example.json config.json
```

Następnie edytuj plik `config.json`:

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

#### Opis opcji konfiguracyjnych

**Konfiguracja server**:

- `host`: adres serwera SSH
- `port`: port SSH, zazwyczaj 22
- `username`: nazwa użytkownika SSH
- `password`: hasło SSH (w środowisku produkcyjnym zalecane jest użycie uwierzytelniania za pomocą klucza)
- `timeout`: czas oczekiwania na połączenie (w sekundach)

**Konfiguracja paths**:

- `local`: ścieżka do katalogu lokalnego, obsługuje ścieżki względne i bezwzględne
- `remote`: ścieżka do katalogu zdalnego, musi być ścieżką bezwzględną

**Konfiguracja options**:

- `backup`: czy utworzyć kopię zapasową istniejących plików na serwerze przed przesłaniem
- `backup_suffix`: sufiks pliku kopii zapasowej, można zdefiniować własny; jeśli nie istnieje plik do kopii, operacja jest pomijana
- `exclude_patterns`: wzorce wykluczeń plików, obsługa symboli wieloznacznych
- `max_retries`: maksymalna liczba ponowień przy nieudanym przesyłaniu
- `chunk_size`: rozmiar bloku przesyłania pliku (w bajtach, obecnie niezaimplementowane)

### 2. Konfiguracja domyślna (tryb zgodności)

Jeśli plik `config.json` nie istnieje, program użyje wbudowanej domyślnej konfiguracji, zachowując kompatybilność wsteczną.

#### Priorytet plików konfiguracyjnych

1. **Plik konfiguracyjny wskazany w wierszu poleceń**: plik określony przez parametr `--config`
2. **Domyślny plik konfiguracyjny**: `config.json` w bieżącym katalogu
3. **Wbudowana domyślna konfiguracja**: jeśli powyższe nie istnieją, używana jest konfiguracja wbudowana w program

#### Zasady obsługi ścieżek

- **Ścieżka do pliku konfiguracyjnego**:

  - Ścieżka względna: względem katalogu, w którym znajduje się plik wykonywalny
  - Ścieżka bezwzględna: używana bezpośrednio

- **Lokalna ścieżka katalogu**:

  - Ścieżka względna: względem katalogu pliku wykonywalnego
  - Ścieżka bezwzględna: używana bezpośrednio

## Instrukcja uruchamiania

### Parametry wiersza poleceń

Program obsługuje następujące parametry:

```bash
# Wyświetl pomoc
./deploy --help

# Wyświetl informacje o wersji  
./deploy --version

# Użycie domyślnego pliku konfiguracyjnego config.json
./deploy

# Użycie określonego pliku konfiguracyjnego
./deploy --config prod.json

# Użycie pliku konfiguracyjnego z bezwzględną ścieżką
./deploy --config /path/to/config.json
```

### Uruchamianie w środowisku deweloperskim

```bash
# Użycie domyślnej konfiguracji
go run main.go

# Użycie określonego pliku konfiguracyjnego
go run main.go --config test.json

# Wyświetl pomoc
go run main.go --help
```

### Uruchamianie po kompilacji

```bash
# Kompilacja
go build -o deploy main.go

# Uruchomienie z domyślną konfiguracją
./deploy

# Uruchomienie ze wskazanym plikiem konfiguracyjnym
./deploy --config prod.json
```

## Instrukcja pakowania

### 1. Pakowanie dla lokalnej platformy

```bash
# Kompilacja pliku wykonywalnego dla bieżącej platformy
go build -o deploy main.go
```

### 2. Pakowanie wieloplatformowe

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

### 3. Optymalizacja pakowania (zmniejszenie rozmiaru pliku)

```bash
# Usunięcie informacji debugowania i tabeli symboli
go build -ldflags="-s -w" -o deploy main.go

# Kompresja przy użyciu UPX (najpierw zainstaluj UPX)
upx --best deploy
```

### 4. Skrypt do zbiorczego pakowania

Utwórz skrypt `build.sh`:

```bash
#!/bin/bash

# Utwórz katalog kompilacji
mkdir -p builds

# Kompilacja dla różnych platform
echo "Budowanie wersji Linux 64-bit..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Budowanie wersji Windows 64-bit..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "Budowanie wersji macOS 64-bit..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "Budowanie wersji macOS ARM64..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "Budowanie zakończone!"
ls -la builds/
```

Uruchom skrypt:

```bash
chmod +x build.sh
./build.sh
```

## Przykłady użycia

### Wyświetlenie informacji pomocy

```bash
$ ./deploy --help
Go-Deploy Narzędzie do wdrażania

Użycie: ./deploy [opcje]

Opcje:
  -config string
        Ścieżka do pliku konfiguracyjnego (domyślnie "config.json")
  -help
        Wyświetl informacje pomocy
  -version
        Wyświetl informacje o wersji

Przykłady:
  ./deploy                           # Użyj domyślnego pliku config.json
  ./deploy --config prod.json        # Użyj określonego pliku konfiguracyjnego
  ./deploy --config /path/to/config.json  # Użyj pliku konfiguracyjnego z bezwzględną ścieżką
```

### Użycie określonego pliku konfiguracyjnego

```bash
$ ./deploy --config prod.json
Rozpoczynanie wykonywania programu wdrożeniowego...
Próba odczytu pliku konfiguracyjnego: /path/to/go-deploy/prod.json
Używanie pliku konfiguracyjnego...
Lokalny katalog /path/to/project/dist istnieje
Nawiązywanie połączenia z serwerem SSH...
Połączenie z serwerem SSH udane
...
```

### Użycie pliku konfiguracyjnego

```bash
$ ./deploy
Rozpoczynanie wykonywania programu wdrożeniowego...
Próba odczytu pliku konfiguracyjnego: /path/to/go-deploy/config.json
Używanie pliku konfiguracyjnego...
Lokalny katalog /path/to/project/unpackage/dist/build/web istnieje
Nawiązywanie połączenia z serwerem SSH...
Połączenie z serwerem SSH udane
Tworzenie klienta SFTP...
Klient SFTP utworzony pomyślnie
Przygotowanie do przesyłania do katalogu zdalnego: /opt/xsoft/nginx/html/app/dist
Rozpoczynanie przesyłania katalogu...
Rozpoczynanie przeglądania lokalnego katalogu: /path/to/project/unpackage/dist/build/web
Tworzenie katalogu: /opt/xsoft/nginx/html/app/dist
Plik static/js/app.js.map został wykluczony, pomijanie przesyłania
Tworzenie kopii zapasowej: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
Przesyłanie pliku: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
Plik .DS_Store został wykluczony, pomijanie przesyłania
Przesyłanie pliku: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
Przesyłanie nie powiodło się (próba 1/3): błąd sieci
Ponowna próba przesłania pliku (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
Przesyłanie pliku: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
Katalog przesłany pomyślnie!
Statystyki:
  - Liczba przesłanych plików: 485
  - Liczba utworzonych katalogów: 18
  - Przesłany rozmiar: 25.8 MB
  - Czas przesyłania: 38.5s
  - Całkowity czas: 39.2s
  - Prędkość przesyłania: 0.67 MB/s
```

## Uwagi

1. **Bezpieczeństwo**:

   - W środowisku produkcyjnym zaleca się użycie uwierzytelniania kluczem SSH zamiast hasła
   - Aktualnie używane jest `ssh.InsecureIgnoreHostKey()`, w produkcji należy weryfikować klucz hosta
2. **Sieć**:

   - Upewnij się, że port 22 na serwerze docelowym jest dostępny z lokalnej maszyny
   - Prędkość transferu zależy od przepustowości sieci oraz wydajności serwera
3. **Uprawnienia**:

   - Użytkownik SSH musi mieć prawa zapisu do katalogu docelowego
   - W razie potrzeby może być wymagane użycie sudo
4. **Ścieżki**:

   - Lokalna ścieżka jest automatycznie wyliczana względem położenia pliku wykonywalnego, nie wymaga troski o katalog roboczy
   - Ścieżka zdalna powinna być bezwzględna

## Rozwiązywanie problemów

### Typowe problemy

1. **Przekroczono czas połączenia**

   ```
   Nie udało się połączyć z serwerem SSH: dial tcp: i/o timeout
   ```

   - Sprawdź adres i port serwera
   - Upewnij się, że sieć działa prawidłowo
   - Sprawdź ustawienia zapory ogniowej (firewalla)
2. **Błąd uwierzytelnienia**

   ```
   Logowanie nie powiodło się: ssh: handshake failed
   ```

   - Sprawdź nazwę użytkownika i hasło
   - Upewnij się, że usługa SSH jest uruchomiona
   - Sprawdź konfigurację SSH
3. **Błąd uprawnień**

   ```
   Tworzenie katalogu nie powiodło się: permission denied
   ```

   - Sprawdź prawa zapisu użytkownika do katalogu docelowego
   - Może być wymagane użycie sudo lub zmiana właściciela katalogu
4. **Lokalny katalog nie istnieje**

   ```
   Błąd: lokalny katalog /path/to/unpackage/dist/build/web nie istnieje
   ```

   - Upewnij się, że budowanie projektu zostało zakończone
   - Sprawdź poprawność struktury katalogów projektu
   - Program automatycznie wylicza ścieżkę, nie trzeba zmieniać katalogu roboczego

## Informacje dla deweloperów

### Struktura projektu

```
go-deploy/
├── main.go                 # Plik główny programu
├── go.mod                  # Plik modułu Go  
├── go.sum                  # Plik sprawdzający zależności
```
├── README.md               # Szczegółowa dokumentacja
├── Makefile                # Narzędzie budujące
├── build.sh                # Skrypt do pakowania wsadowego
├── install.sh              # Skrypt instalacyjny typu "wszystko w jednym"
└── config.example.json     # Przykładowy plik konfiguracyjny
```

### Główne funkcje

- `main()` - Główna funkcja, obsługuje połączenia i wywołuje upload
- `uploadDirectory()` - Rekursywne przesyłanie katalogu
- `uploadFile()` - Przesyłanie pojedynczego pliku
- `mkdirAll()` - Rekursywne tworzenie zdalnego katalogu

## Licencja

MIT License

## Wkład

Zapraszamy do zgłaszania Issue oraz Pull Request!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---