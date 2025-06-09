# [jQuery](https://jquery.com/) — Nowa fala JavaScript

Spotkania odbywają się obecnie na [platformie matrix.org](https://matrix.to/#/#jquery_meeting:gitter.im).

Protokoły spotkań można znaleźć na [meetings.jquery.org](https://meetings.jquery.org/category/core/).

Najnowsza wersja jQuery jest dostępna na [https://jquery.com/download/](https://jquery.com/download/).

## Wsparcie wersji

| Wersja | Gałąź      | Status   |
| ------- | ---------- | -------- |
| 4.x     | main       | Beta     |
| 3.x     | 3.x-stable | Aktywna  |
| 2.x     | 2.x-stable | Nieaktywna |
| 1.x     | 1.x-stable | Nieaktywna |

Po wydaniu wersji 4.0.0 finalnej, gałąź 3.x będzie nadal otrzymywać aktualizacje przez ograniczony czas. Gałęzie 2.x i 1.x nie są już wspierane.

Komercyjne wsparcie dla nieaktywnych wersji jest dostępne od [HeroDevs](https://herodevs.com/nes).

Dowiedz się więcej o naszym [wsparciu wersji](https://jquery.com/support/).

## Przewodniki po kontrybucji

W duchu rozwoju oprogramowania open source, jQuery zawsze zachęca do wkładu społeczności w kod. Aby pomóc Ci zacząć i zanim przejdziesz do pisania kodu, koniecznie zapoznaj się dokładnie z tymi ważnymi wytycznymi dotyczącymi kontrybucji:

1. [Jak się zaangażować](https://contribute.jquery.org/)
2. [Przewodnik stylu Core](https://contribute.jquery.org/style-guide/js/)
3. [Pisanie kodu dla projektów jQuery](https://contribute.jquery.org/code/)

### Odwołania do zgłoszeń/PR

Zgłoszenia/PR na GitHubie są zwykle oznaczane jako `gh-NUMER`, gdzie `NUMER` to numeryczny identyfikator zgłoszenia/PR. Takie zgłoszenie/PR znajdziesz pod adresem `https://github.com/jquery/jquery/issues/NUMER`.

jQuery używało wcześniej innego systemu zgłaszania błędów - opartego na Trac - dostępnego pod [bugs.jquery.com](https://bugs.jquery.com/). Jest on utrzymywany w trybie tylko do odczytu, aby można było odwoływać się do dawnych dyskusji. Gdy w kodzie źródłowym jQuery pojawia się odwołanie do takiego zgłoszenia, używa się wzorca `trac-NUMER`, gdzie `NUMER` to numeryczny identyfikator zgłoszenia. Takie zgłoszenie znajdziesz pod adresem `https://bugs.jquery.com/ticket/NUMER`.

## Środowiska, w których można używać jQuery

- [Wsparcie przeglądarek](https://jquery.com/browser-support/)
- jQuery obsługuje także Node, rozszerzenia przeglądarkowe oraz inne środowiska nieprzeglądarkowe.

## Co jest potrzebne, aby zbudować własne jQuery

Aby zbudować jQuery, musisz posiadać najnowszą wersję Node.js/npm oraz git 1.7 lub nowszy. Wcześniejsze wersje mogą działać, ale nie są wspierane.

Dla Windows należy pobrać i zainstalować [git](https://git-scm.com/downloads) oraz [Node.js](https://nodejs.org/en/download/).

Użytkownicy macOS powinni zainstalować [Homebrew](https://brew.sh/). Po zainstalowaniu Homebrew, uruchom `brew install git`, aby zainstalować git,
oraz `brew install node`, aby zainstalować Node.js.

Użytkownicy Linux/BSD powinni użyć odpowiednich menedżerów pakietów, aby zainstalować git i Node.js, lub zbudować je ze źródeł,
jeśli tak wolą. Proste.

## Jak zbudować własne jQuery

Najpierw [sklonuj repozytorium jQuery z gita](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Następnie wejdź do katalogu jquery, zainstaluj zależności i uruchom skrypt budujący:

```bash
cd jquery
npm install
npm run build
```

Zbudowana wersja jQuery zostanie umieszczona w katalogu `dist/`, wraz ze zminimalizowaną kopią oraz powiązanym plikiem mapy.

## Budowanie wszystkich plików wydania jQuery

Aby zbudować wszystkie warianty jQuery, uruchom następujące polecenie:

```bash
npm run build:all
```

To polecenie stworzy wszystkie warianty, które jQuery dołącza do wydania, w tym `jquery.js`, `jquery.slim.js`, `jquery.module.js` oraz `jquery.slim.module.js`, wraz z odpowiadającymi im zminimalizowanymi plikami i sourcemapami.

`jquery.module.js` oraz `jquery.slim.module.js` to [moduły ECMAScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules), które eksportują `jQuery` i `$` jako eksporty nazwane i są umieszczane w katalogu `dist-module/` zamiast w katalogu `dist/`.

## Tworzenie własnego jQuery

Skrypt budujący może być użyty do stworzenia własnej wersji jQuery, która zawiera tylko potrzebne moduły.

Każdy moduł może być wykluczony z wyjątkiem `core`. Po wykluczeniu `selector` nie jest on usuwany, ale zastępowany małym wrapperem wokół natywnego `querySelectorAll` (więcej informacji poniżej).

### Pomoc do skryptu budującego

Aby zobaczyć pełną listę dostępnych opcji dla skryptu budującego, uruchom:

```bash
npm run build -- --help
```

### Moduły

Aby wykluczyć moduł, przekaż jego ścieżkę względem folderu `src` (bez rozszerzenia `.js`) do opcji `--exclude`. Przy użyciu opcji `--include`, domyślne moduły są pomijane i tworzona jest kompilacja tylko z podanymi modułami.

Przykładowe moduły, które można wykluczyć lub dołączyć to:

- **ajax**: Cała funkcjonalność AJAX: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, transporty oraz skróty zdarzeń ajax, takie jak `.ajaxStart()`.
- **ajax/xhr**: Tylko transport AJAX XMLHTTPRequest.
- **ajax/script**: Tylko transport AJAX `<script>`; używany do pobierania skryptów.
- **ajax/jsonp**: Tylko transport AJAX JSONP; zależy od transportu ajax/script.
- **css**: Metoda `.css()`. Usuwa także **wszystkie** moduły zależne od css (w tym **effects**, **dimensions** oraz **offset**).
- **css/showHide**: Nieanimowane `.show()`, `.hide()` oraz `.toggle()`; można wykluczyć, jeśli używasz klas lub jawnych wywołań `.css()` do ustawiania właściwości `display`. Usuwa także moduł **effects**.
- **deprecated**: Metody udokumentowane jako przestarzałe, ale jeszcze niewycofane.
- **dimensions**: Metody `.width()` i `.height()`, w tym warianty `inner-` i `outer-`.
- **effects**: Metoda `.animate()` i jej skróty, takie jak `.slideUp()` lub `.hide("slow")`.
- **event**: Metody `.on()` i `.off()` oraz cała funkcjonalność zdarzeń.
- **event/trigger**: Metody `.trigger()` i `.triggerHandler()`.
- **offset**: Metody `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()` oraz `.scrollTop()`.
- **wrap**: Metody `.wrap()`, `.wrapAll()`, `.wrapInner()` oraz `.unwrap()`.
- **core/ready**: Wyklucz moduł ready, jeśli umieszczasz swoje skrypty na końcu body. Wszystkie callbacki ready powiązane z `jQuery()` zostaną po prostu wywołane natychmiast. Jednak `jQuery(document).ready()` nie będzie funkcją, a `.on("ready", ...)` lub podobne nie zostanie wywołane.
- **deferred**: Wyklucz jQuery.Deferred. Wyklucza to także wszystkie moduły zależne od Deferred, w tym **ajax**, **effects** i **queue**, ale zastępuje **core/ready** modułem **core/ready-no-deferred**.
- **exports/global**: Wyklucz dołączanie globalnych zmiennych jQuery ($ i jQuery) do obiektu window.
- **exports/amd**: Wyklucz definicję AMD.

- **selector**: Pełny silnik selektorów jQuery. Gdy ten moduł jest wykluczony, zastępowany jest uproszczonym silnikiem selektorów opartym o `querySelectorAll` przeglądarki, który nie obsługuje rozszerzeń selektorów jQuery ani rozszerzonej semantyki. Szczegóły zobacz w pliku [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js).

*Uwaga*: Wykluczenie pełnego modułu `selector` spowoduje również wykluczenie wszystkich rozszerzeń selektorów jQuery (takich jak `effects/animatedSelector` i `css/hiddenVisibleSelectors`).

##### Nazwa AMD

Możesz ustawić nazwę modułu dla definicji AMD jQuery. Domyślnie jest to "jquery", co dobrze współpracuje z pluginami i bibliotekami zewnętrznymi, ale mogą być sytuacje, gdy chcesz to zmienić. Przekaż nazwę do parametru `--amd`:

```bash
npm run build -- --amd="własna-nazwa"
```

Lub, aby zdefiniować anonimowo, pozostaw nazwę pustą.

```bash
npm run build -- --amd
```

##### Nazwa pliku i katalog

Domyślna nazwa budowanego pliku jQuery to `jquery.js`; umieszczany jest on w katalogu `dist/`. Można zmienić nazwę pliku za pomocą `--filename` oraz katalog za pomocą `--dir`. `--dir` jest ścieżką względem głównego katalogu projektu.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

To polecenie stworzy slimową wersję jQuery i umieści ją w `tmp/jquery.slim.js`.

##### Tryb modułu ECMAScript (ESM)

Domyślnie jQuery generuje zwykły plik JavaScript. Możesz także wygenerować moduł ECMAScript eksportujący `jQuery` jako eksport domyślny, używając parametru `--esm`:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Tryb fabryczny (Factory mode)

Domyślnie jQuery zależy od globalnego `window`. Dla środowisk, które go nie mają, możesz wygenerować kompilację fabryczną, która udostępnia funkcję akceptującą `window` jako parametr, który możesz przekazać z zewnątrz (zobacz [`README` opublikowanej paczki](build/fixtures/README.md) po instrukcje użycia). Możesz wygenerować taką fabrykę używając parametru `--factory`:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Opcję tę można łączyć z innymi, jak `--esm` czy `--slim`:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Przykłady własnych kompilacji

Stwórz własną kompilację używając `npm run build`, wymieniając moduły do wykluczenia. Wykluczenie modułu najwyższego poziomu wyklucza również odpowiadający mu katalog modułów.

Wyklucz całą funkcjonalność **ajax**:

```bash
npm run build -- --exclude=ajax
```

Wykluczenie **css** usuwa moduły zależne od CSS: **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Wyklucz kilka modułów naraz (`-e` to alias dla `--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Jest specjalny alias do wygenerowania kompilacji o tej samej konfiguracji, co oficjalna wersja jQuery Slim:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

Lub, aby stworzyć slimową wersję jako moduł esm:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Niestandardowe, nieoficjalne kompilacje nie są regularnie testowane. Używasz ich na własne ryzyko.*

## Uruchamianie testów jednostkowych

Upewnij się, że masz zainstalowane niezbędne zależności:

```bash
npm install
```

Uruchom `npm start`, aby jQuery było automatycznie budowane podczas pracy:

```bash
npm start
```

Uruchom testy jednostkowe za pomocą lokalnego serwera obsługującego PHP. Upewnij się, że uruchamiasz stronę z katalogu głównego, a nie z katalogu "test". Nie jest wymagany żaden system baz danych. Gotowe, skonfigurowane lokalne serwery PHP są dostępne dla Windows i Mac. Oto kilka opcji:

- Windows: [Pobierz WAMP](https://www.wampserver.com/en/)
- Mac: [Pobierz MAMP](https://www.mamp.info/en/downloads/)
- Linux: [Konfiguracja LAMP](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (większość platform)](https://code.google.com/p/mongoose/)

## Podstawowe polecenia Git

Ponieważ kod źródłowy jest zarządzany przez system kontroli wersji Git, warto znać niektóre używane funkcje.

### Czyszczenie

Jeśli chcesz przywrócić swój katalog roboczy do stanu zgodnego z upstream, możesz użyć następujących poleceń (pamiętaj, że wszystko nad czym pracowałeś zostanie usunięte):

```bash
git reset --hard upstream/main
git clean -fdx
```

### Rebase

Dla gałęzi z funkcjami/tematami powinieneś zawsze używać flagi `--rebase` z `git pull`, lub jeśli często zarządzasz wieloma tymczasowymi gałęziami "do zgłoszenia pull request na github", uruchom poniższe polecenie, aby to zautomatyzować:

```bash
git config branch.autosetuprebase local
```

(zobacz `man git-config` po więcej informacji)

### Obsługa konfliktów scalania

Jeśli podczas scalania pojawiają się konflikty, zamiast ręcznie edytować pliki z konfliktami, możesz użyć funkcji
`git mergetool`. Mimo że domyślne narzędzie `xxdiff` wygląda nieatrakcyjnie/staro, jest całkiem przydatne.

Poniżej kilka poleceń, które można tam wykorzystać:

- `Ctrl + Alt + M` - automatyczne scalenie tak dużo, jak to możliwe
- `b` - przejdź do następnego konfliktu
- `s` - zmień kolejność konfliktowych linii
- `u` - cofnij scalenie
- `lewy przycisk myszy` - zaznacz blok jako zwycięski
- `środkowy przycisk myszy` - zaznacz linię jako zwycięską
- `Ctrl + S` - zapisz
- `Ctrl + Q` - wyjdź

## Dokumentacja [QUnit](https://api.qunitjs.com)

### Metody testowe

```js
expect( numAssertions );
stop();
start();
```

*Uwaga*: Przyszłe dodanie argumentu do stop/start w QUnit jest ignorowane w tym zestawie testowym, aby start i stop mogły być przekazywane jako callbacki bez martwienia się o ich parametry.

### Asercje testowe

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## Dokumentacja wygodnych metod zestawu testowego

Zobacz [test/data/testinit.js](https://raw.githubusercontent.com/jquery/jquery/main/test/data/testinit.js).

### Zwraca tablicę elementów o podanych identyfikatorach

```js
q( ... );
```

Przykład:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Sprawdza, czy selekcja odpowiada podanym ID

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Przykład:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### Wywołuje natywne zdarzenie DOM bez użycia jQuery

```js
fireNative( node, eventType );
```

Przykład:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Dodaje losowy numer do url, aby zapobiec cache'owaniu

```js
url( "some/url" );
```

Przykład:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Uruchamianie testów w ramce iframe

Niektóre testy mogą wymagać dokumentu innego niż standardowy test fixture,
które mogą być uruchamiane w osobnej ramce iframe. Faktyczny kod testu i asercje
pozostają w głównych plikach testowych jQuery; tylko minimalny markup testowego fixture
i kod inicjujący powinny być umieszczone w pliku iframe.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

To ładuje stronę, konstruując url z fileName `"./data/" + fileName`.
Strona w iframe decyduje, kiedy wywołać callback w teście przez
dołączenie skryptu "/test/data/iframeTest.js" i wywołanie
`startIframeTest( [ additional args ] )` w odpowiednim momencie. Często
następuje to po załadowaniu dokumentu lub wywołaniu `window.onload`.

`testCallback` otrzymuje obiekt QUnit `assert` utworzony przez `testIframe`
dla tego testu, a następnie globalne `jQuery`, `window` i `document` z
iframe. Jeśli kod iframe przekaże jakiekolwiek argumenty do `startIframeTest`,
trafią one po argumencie `document`.

## Pytania?

Jeśli masz jakiekolwiek pytania, śmiało pytaj na
[forum Developing jQuery Core](https://forum.jquery.com/developing-jquery-core) lub na #jquery na [libera](https://web.libera.chat/).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---