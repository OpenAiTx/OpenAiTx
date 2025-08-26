
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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

Aplikacja napisana w Rust, która konwertuje obrazy kontenerów (Docker, itp.) do repozytoriów Git. Każda warstwa kontenera jest reprezentowana jako commit Git, zachowując historię i strukturę oryginalnego obrazu.

![Demo działania OCI2Git konwertującego obraz nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Funkcje

- Analizuj obrazy Dockera i wyodrębniaj informacje o warstwach
- Utwórz repozytorium Git, w którym każda warstwa obrazu jest reprezentowana jako commit
- Obsługa pustych warstw (ENV, WORKDIR, itp.) jako pustych commitów
- Pełna ekstrakcja metadanych do formatu Markdown
- Rozszerzalna architektura umożliwiająca obsługę różnych silników kontenerowych

## Przypadki użycia

### Porównywanie warstw
Podczas rozwiązywania problemów z kontenerami możesz użyć potężnych możliwości porównywania Git, aby dokładnie zidentyfikować, co zmieniło się pomiędzy dowolnymi dwoma warstwami. Uruchamiając `git diff` między commitami, inżynierowie mogą zobaczyć dokładnie, które pliki zostały dodane, zmodyfikowane lub usunięte, co znacznie ułatwia zrozumienie wpływu każdej instrukcji Dockerfile oraz lokalizację problematycznych zmian.
![Przykład porównania warstw](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Śledzenie pochodzenia
Korzystając z `git blame`, programiści mogą szybko ustalić, która warstwa wprowadziła konkretny plik lub linię kodu. Jest to szczególnie cenne podczas diagnozowania problemów z plikami konfiguracyjnymi lub zależnościami. Zamiast ręcznego przeglądania każdej warstwy, można natychmiast prześledzić pochodzenie dowolnego pliku do jego źródłowej warstwy i odpowiadającej instrukcji Dockerfile.

### Śledzenie cyklu życia pliku
OCI2Git umożliwia śledzenie historii wybranego pliku w całym przebiegu historii obrazu kontenera. Możesz obserwować, kiedy plik został utworzony, jak był modyfikowany w kolejnych warstwach i czy/jeśli został ostatecznie usunięty. Ten kompleksowy widok pomaga zrozumieć ewolucję pliku bez konieczności ręcznego śledzenia zmian przez potencjalnie dziesiątki warstw.

Aby śledzić historię pliku w obrazie kontenera — w tym moment jego pojawienia się, zmian lub usunięcia — możesz użyć tych poleceń Git po konwersji:

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
- Oddzielne gałęzie, które rozchodzą się tylko wtedy, gdy obrazy faktycznie się różnią
- Czytelną wizualizację miejsc, w których obrazy mają wspólne pochodzenie w porównaniu do miejsc, gdzie stają się unikalne
- Inteligentne zarządzanie duplikatami: jeśli dokładnie ten sam obraz zostanie przetworzony dwukrotnie, algorytm wykryje to przed końcowym zatwierdzeniem metadanych i pominie tworzenie duplikatu gałęzi

To podejście jest szczególnie wartościowe dla:
- **Analizy rodzin obrazów**: Zrozumienia, jak różne warianty obrazu (różne wersje, architektury lub konfiguracje) są ze sobą powiązane
- **Wpływu obrazu bazowego**: Możliwości zobaczenia, jak zmiany w obrazie bazowym wpływają na wiele obrazów pochodnych
- **Możliwości optymalizacji**: Identyfikacji współdzielonych komponentów, które można lepiej wykorzystać między wariantami obrazów

![Struktura repozytorium wielu obrazów pokazująca współdzieloną bazę i rozgałęziające się gałęzie](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Dodatkowe scenariusze użycia

- **Audyt bezpieczeństwa**: Identyfikacja dokładnego momentu, w którym wprowadzono podatne pakiety lub konfiguracje, oraz możliwość prześledzenia ich do konkretnych instrukcji budowania.
- **Optymalizacja obrazu**: Analiza struktury warstw w celu wykrycia zbędnych operacji lub dużych plików możliwych do konsolidacji, co pomaga zmniejszyć rozmiar obrazu.
- **Zarządzanie zależnościami**: Monitorowanie, kiedy zależności zostały dodane, zaktualizowane lub usunięte na przestrzeni historii obrazu.
- **Usprawnienie procesu budowania**: Analiza składu warstw w celu optymalizacji instrukcji Dockerfile dla lepszego cache’owania i mniejszego rozmiaru obrazu.
- **Porównanie obrazów**: Konwersja wielu powiązanych obrazów do repozytoriów Git i wykorzystanie narzędzi porównawczych Git do analizy ich różnic i cech wspólnych.

## Instalacja

### Z źródła


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Z Crates.io

```bash
cargo install oci2git
```

## Użytkowanie

```bash
oci2git [OPTIONS] <IMAGE>
```
Argumenty:
  `<IMAGE>`  Nazwa obrazu do konwersji (np. 'ubuntu:latest') lub ścieżka do archiwum tar przy użyciu silnika tar

Opcje:
  `-o, --output <o>`  Katalog wyjściowy dla repozytorium Git [domyślnie: ./container_repo]
  `-e, --engine <ENGINE>`  Silnik kontenerowy do użycia (docker, nerdctl, tar) [domyślnie: docker]
  `-h, --help`            Wyświetl informacje pomocy
  `-V, --version`         Wyświetl informacje o wersji

Zmienne środowiskowe:
  `TMPDIR`  Ustaw tę zmienną środowiskową, aby zmienić domyślną lokalizację używaną do przetwarzania danych pośrednich. Jest to zależne od platformy (np. `TMPDIR` w Unix/macOS, `TEMP` lub `TMP` w Windows).

## Przykłady

Użycie silnika Docker (domyślnie):

```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

Używanie już pobranego archiwum tarball obrazu:
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Silnik tar oczekuje prawidłowego pliku tar w formacie OCI, który zwykle jest tworzony za pomocą polecenia `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

To utworzy repozytorium Git w `./ubuntu-repo`, zawierające:
- `Image.md` - Pełne metadane obrazu w formacie Markdown
- `rootfs/` - Zawartość systemu plików z kontenera

Historia Git odzwierciedla historię warstw kontenera:
- Pierwszy commit zawiera tylko plik `Image.md` z pełnymi metadanymi
- Każdy kolejny commit reprezentuje warstwę z oryginalnego obrazu
- Commity zawierają polecenie z Dockerfile jako wiadomość commita

## Struktura repozytorium

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
  
## Wymagania

- Rust w wersji 2021
- Docker CLI (dla obsługi silnika Docker)
- Git

## Licencja

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---