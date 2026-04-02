
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![Dokumentacja](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![Licencja](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![Pobrania](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (mock do przyszłego test.yaml)
[//]: # ([![Status testu]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Aplikacja w języku Rust, która konwertuje obrazy kontenerowe (Docker, itd.) na repozytoria Git oraz generuje zestawienie materiałowe systemu plików (fsbom) w formacie YAML. Każda warstwa kontenera jest reprezentowana jako commit Gita, zachowując historię i strukturę oryginalnego obrazu.

![Demo działania OCI2Git konwertującego obraz nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Funkcje

- Analiza obrazów Dockera i wydobywanie informacji o warstwach
- Tworzenie repozytorium Git, w którym każda warstwa obrazu to oddzielny commit
- Generowanie zestawienia materiałowego systemu plików (fsbom) w YAML z listą plików dla każdej warstwy
- Obsługa pustych warstw (ENV, WORKDIR, itd.) jako pustych commitów
- Kompleksowe wydobywanie metadanych do formatu Markdown
- Rozszerzalna architektura do wsparcia różnych silników kontenerowych

## Przypadki użycia

### Różnicowanie warstw
Podczas rozwiązywania problemów z kontenerami możesz użyć potężnych możliwości porównywania Gita, aby dokładnie określić, co zmieniło się pomiędzy dowolnymi dwiema warstwami. Uruchamiając `git diff` pomiędzy commitami, inżynierowie mogą zobaczyć dokładnie, które pliki zostały dodane, zmienione lub usunięte, co znacznie ułatwia zrozumienie wpływu każdej instrukcji Dockerfile i lokalizację problematycznych zmian.
![Przykład różnicy między warstwami](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Śledzenie pochodzenia
Korzystając z `git blame`, deweloperzy mogą szybko ustalić, która warstwa wprowadziła konkretny plik lub linię kodu. Jest to szczególnie przydatne przy diagnozowaniu problemów z plikami konfiguracyjnymi lub zależnościami. Zamiast ręcznego przeglądania każdej warstwy, możesz natychmiast prześledzić pochodzenie dowolnego pliku do jego źródłowej warstwy i odpowiadającej jej instrukcji Dockerfile.

### Śledzenie cyklu życia pliku
OCI2Git pozwala śledzić historię konkretnego pliku w całym obrazie kontenera. Możesz obserwować, kiedy plik został utworzony, jak był modyfikowany w kolejnych warstwach i czy/został ostatecznie usunięty. Ten kompleksowy widok pomaga zrozumieć ewolucję pliku bez konieczności ręcznego śledzenia zmian w wielu warstwach.

Aby śledzić historię pliku w obrazie kontenera — w tym, kiedy pojawił się po raz pierwszy, był zmieniany lub usunięty — po konwersji użyj tych poleceń Gita:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```

Te polecenia umożliwiają łatwe śledzenie pełnej historii dowolnego pliku w warstwach kontenera bez konieczności ręcznego wyodrębniania i porównywania archiwów warstw.

### Analiza wielowarstwowa
Czasami najbardziej wartościowe porównania wynikają z badania zmian pomiędzy wieloma, niekolejnymi warstwami. Dzięki OCI2Git możesz używać narzędzi porównawczych Git do analizy ewolucji komponentów na różnych etapach budowy, identyfikując wzorce, które mogą być niewidoczne przy oglądaniu tylko sąsiednich warstw.

### Eksploracja warstw
Korzystając z `git checkout` do przechodzenia do dowolnego konkretnego commita, możesz zbadać system plików kontenera dokładnie tak, jak wyglądał w danej warstwie. Pozwala to deweloperom analizować dokładny stan plików i katalogów w każdym punkcie procesu tworzenia obrazu, zapewniając nieoceniony kontekst podczas debugowania lub badania zachowania kontenera.
![Przejście do poprzedniego commita](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Analiza wielu obrazów

Pracując z wieloma obrazami kontenerów, które mają wspólne pochodzenie, OCI2Git inteligentnie tworzy gałęzie tylko wtedy, gdy obrazy rzeczywiście się rozchodzą. Pozwala to analizować wiele powiązanych obrazów w jednym repozytorium, zachowując ich wspólną historię.

```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Git automatycznie wykrywa współdzielone warstwy między obrazami i tworzy strukturę rozgałęzień odzwierciedlającą ich wspólną bazę. Historia Git pokazuje:
- Wspólny pień zawierający wszystkie współdzielone warstwy
- Oddzielne gałęzie, które rozchodzą się dopiero wtedy, gdy obrazy faktycznie się różnią
- Wyraźną wizualizację, gdzie obrazy mają wspólnego przodka, a gdzie stają się unikalne
- Inteligentne zarządzanie duplikatami: jeśli dokładnie ten sam obraz zostanie przetworzony dwukrotnie, algorytm wykrywa to przed ostatecznym zatwierdzeniem metadanych i pomija tworzenie zduplikowanej gałęzi

To podejście jest szczególnie cenne dla:
- **Analizy rodzin obrazów**: Zrozumienia, jak różne warianty obrazu (różne wersje, architektury lub konfiguracje) są ze sobą powiązane
- **Wpływu obrazu bazowego**: Zobaczenia, jak zmiany w obrazie bazowym wpływają na wiele obrazów pochodnych
- **Możliwości optymalizacji**: Identyfikowania współdzielonych komponentów, które można lepiej wykorzystać w różnych wariantach obrazu

![Struktura repozytorium wielu obrazów pokazująca wspólną bazę i rozgałęziające się gałęzie](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Dodatkowe przypadki użycia

- **Audyt bezpieczeństwa**: Identyfikacja dokładnego momentu wprowadzenia podatnych pakietów lub konfiguracji oraz możliwość prześledzenia ich do konkretnych instrukcji budowania.
- **Optymalizacja obrazu**: Analiza struktury warstw w celu znalezienia zbędnych operacji lub dużych plików, które można skonsolidować, pomagając zmniejszyć rozmiar obrazu.
- **Zarządzanie zależnościami**: Monitorowanie, kiedy zależności zostały dodane, zaktualizowane lub usunięte w historii obrazu.
- **Usprawnienie procesu budowania**: Analiza składu warstw w celu optymalizacji instrukcji Dockerfile dla lepszego buforowania i mniejszego rozmiaru obrazu.
- **Porównanie obrazów**: Konwersja wielu powiązanych obrazów do repozytoriów Git i wykorzystanie narzędzi porównawczych Git do analizy ich różnic i wspólnych cech.

## Instalacja

### Menedżery pakietów

#### macOS / Linux (Homebrew)


```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

Pobierz i zainstaluj pakiet .deb z [najnowszego wydania](https://github.com/virviil/oci2git/releases/latest):

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### Arch Linux (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### Gotowe pliki binarne

Pobierz odpowiedni plik binarny dla swojej platformy z [najnowszego wydania](https://github.com/virviil/oci2git/releases/latest):

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### Z Crates.io

```bash
cargo install oci2git
```

### Ze źródła

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## Użytkowanie

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — obraz OCI → repozytorium Git

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```
Opcje:
  `-o, --output <OUTPUT>`  Katalog wyjściowy dla repozytorium Git [domyślnie: ./container_repo]
  `-e, --engine <ENGINE>`  Silnik kontenerów do użycia (docker, nerdctl, tar) [domyślnie: docker]
  `-v, --verbose`          Tryb szczegółowy (-v dla info, -vv dla debug, -vvv dla trace)

### `fsbom` — Specyfikacja składników systemu plików


```bash
oci2git fsbom [OPTIONS] <IMAGE>
```
Opcje:
  `-o, --output <OUTPUT>`  Ścieżka wyjściowa dla pliku BOM w formacie YAML [domyślnie: ./fsbom.yml]
  `-e, --engine <ENGINE>`  Silnik kontenerów do użycia (docker, nerdctl, tar) [domyślnie: docker]
  `-v, --verbose`          Tryb szczegółowy (-v dla info, -vv dla debug, -vvv dla trace)

Zmienne środowiskowe:
  `TMPDIR`  Ustaw tę zmienną środowiskową, aby zmienić domyślną lokalizację używaną do przetwarzania danych pośrednich. Jest to zależne od platformy (np. `TMPDIR` na Unix/macOS, `TEMP` lub `TMP` w Windows).

## Przykłady

### Konwersja

Użycie silnika Docker (domyślnie):

```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```

Używanie już pobranego archiwum tarball obrazu:
```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Silnik tar oczekuje prawidłowego pliku tar w formacie OCI, który zwykle jest tworzony za pomocą polecenia `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

To spowoduje utworzenie repozytorium Git w `./ubuntu-repo` zawierającego:
- `Image.md` - Kompletną metadane obrazu w formacie Markdown
- `rootfs/` - Zawartość systemu plików z kontenera

Historia Git odzwierciedla historię warstw kontenera:
- Pierwszy commit zawiera tylko plik `Image.md` z pełnymi metadanymi
- Każdy kolejny commit reprezentuje warstwę z oryginalnego obrazu
- Commity zawierają polecenie Dockerfile jako wiadomość commit

### Rachunek materiałowy systemu plików (fsbom)

Wygeneruj YAML zawierający listę każdego pliku wprowadzonego lub zmodyfikowanego w każdej warstwie:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```

Korzystanie z archiwum tar:
```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```

Wyjściowy plik YAML wymienia każdą warstwę z wpisami oznaczonymi według typu (`file`, `hardlink`, `symlink`, `directory`) i statusu (`n:uid:gid` dla nowych, `m:uid:gid` dla zmodyfikowanych). Usunięte pliki (whiteouts OCI) są pominięte.

```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

## Struktura repozytorium

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
## Wymagania

- Rust w edycji 2021
- Docker CLI (dla wsparcia silnika Docker)
- Git

## Licencja

MIT

[dokumentacja]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---