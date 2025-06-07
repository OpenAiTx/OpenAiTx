![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Witaj w repozytorium Windows Terminal, Console i Command-Line

<details>
  <summary><strong>Spis Treści</strong></summary>

- [Instalacja i uruchamianie Windows Terminal](#instalacja-i-uruchamianie-windows-terminal)
  - [Microsoft Store \[Zalecane\]](#microsoft-store-zalecane)
  - [Inne metody instalacji](#inne-metody-instalacji)
    - [Przez GitHub](#przez-github)
    - [Przez Windows Package Manager CLI (alias winget)](#przez-windows-package-manager-cli-alias-winget)
    - [Przez Chocolatey (nieoficjalne)](#przez-chocolatey-nieoficjalne)
    - [Przez Scoop (nieoficjalne)](#przez-scoop-nieoficjalne)
- [Instalacja Windows Terminal Canary](#instalacja-windows-terminal-canary)
- [Mapa drogowa Windows Terminal](#mapa-drogowa-windows-terminal)
- [Przegląd Terminala i Konsoli](#przegląd-terminala-i-konsoli)
  - [Windows Terminal](#windows-terminal)
  - [Windows Console Host](#windows-console-host)
  - [Współdzielone komponenty](#współdzielone-komponenty)
  - [Tworzenie nowego Windows Terminal](#tworzenie-nowego-windows-terminal)
- [Zasoby](#zasoby)
- [FAQ](#faq)
  - [Zbudowałem i uruchomiłem nowy Terminal, ale wygląda jak stara konsola](#zbudowałem-i-uruchomiłem-nowy-terminal-ale-wygląda-jak-stara-konsola)
- [Dokumentacja](#dokumentacja)
- [Współtworzenie](#współtworzenie)
- [Kontakt z zespołem](#kontakt-z-zespołem)
- [Wskazówki dla deweloperów](#wskazówki-dla-deweloperów)
- [Wymagania wstępne](#wymagania-wstępne)
- [Budowanie kodu](#budowanie-kodu)
  - [Budowanie w PowerShell](#budowanie-w-powershell)
  - [Budowanie w Cmd](#budowanie-w-cmd)
- [Uruchamianie i debugowanie](#uruchamianie-i-debugowanie)
  - [Wskazówki dotyczące kodowania](#wskazówki-dotyczące-kodowania)
- [Kodeks postępowania](#kodeks-postępowania)

</details>

<br />

To repozytorium zawiera kod źródłowy dla:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Windows Console Host (`conhost.exe`)
* Komponentów współdzielonych między tymi dwoma projektami
* [ColorTool](./src/tools/ColorTool)
* [Projektów przykładowych](./samples)
  pokazujących jak korzystać z Windows Console API

Powiązane repozytoria to m.in.:

* [Dokumentacja Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([Repo: Współtworzenie dokumentacji](https://github.com/MicrosoftDocs/terminal))
* [Dokumentacja API Konsoli](https://github.com/MicrosoftDocs/Console-Docs)
* [Czcionka Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## Instalacja i uruchamianie Windows Terminal

> [!UWAGA]
> Windows Terminal wymaga Windows 10 2004 (kompilacja 19041) lub nowszego

### Microsoft Store [Zalecane]

Zainstaluj [Windows Terminal ze sklepu Microsoft Store][store-install-link].
Pozwala to zawsze mieć najnowszą wersję, gdy tylko wydamy nowe kompilacje
z automatycznymi aktualizacjami.

To nasza preferowana metoda.

### Inne metody instalacji

#### Przez GitHub

Dla użytkowników, którzy nie mogą zainstalować Windows Terminal ze sklepu Microsoft Store,
wydane kompilacje można ręcznie pobrać ze strony [Releases tego repozytorium](https://github.com/microsoft/terminal/releases).

Pobierz plik `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` z sekcji **Assets**. 
Aby zainstalować aplikację, wystarczy dwukrotnie kliknąć plik `.msixbundle`, a instalator powinien automatycznie się uruchomić. Jeśli to się nie powiedzie, spróbuj poniższego polecenia w oknie PowerShell:

```powershell
# UWAGA: Jeśli używasz PowerShell 7+, przed użyciem Add-AppxPackage
# uruchom Import-Module Appx -UseWindowsPowerShell.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!UWAGA]
> Jeśli instalujesz Terminal ręcznie:
>
> * Może być konieczne zainstalowanie [pakietu VC++ v14 Desktop Framework](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages).
>   Jest to wymagane tylko w starszych wersjach Windows 10 i tylko wtedy, gdy pojawi się błąd o brakujących pakietach framework.
> * Terminal nie będzie się automatycznie aktualizował przy wydawaniu nowych kompilacji, więc musisz
>   regularnie instalować najnowsze wydania Terminala, aby otrzymywać poprawki i ulepszenia!

#### Przez Windows Package Manager CLI (alias winget)

Użytkownicy [winget](https://github.com/microsoft/winget-cli) mogą pobrać i zainstalować
najnowszą wersję Terminala, instalując pakiet `Microsoft.WindowsTerminal`:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!UWAGA]
> Obsługa zależności jest dostępna w WinGet w wersji [1.6.2631 lub nowszej](https://github.com/microsoft/winget-cli/releases). Aby zainstalować stabilne wydanie Terminala 1.18 lub nowsze, upewnij się, że masz zaktualizowaną wersję klienta WinGet.

#### Przez Chocolatey (nieoficjalne)

Użytkownicy [Chocolatey](https://chocolatey.org) mogą pobrać i zainstalować najnowszą
wersję Terminala, instalując pakiet `microsoft-windows-terminal`:

```powershell
choco install microsoft-windows-terminal
```

Aby zaktualizować Windows Terminal przez Chocolatey, uruchom:

```powershell
choco upgrade microsoft-windows-terminal
```

Jeśli napotkasz problemy podczas instalacji/aktualizacji pakietu, odwiedź
[stronę pakietu Windows Terminal](https://chocolatey.org/packages/microsoft-windows-terminal)
i postępuj zgodnie z [procesem triage Chocolatey](https://chocolatey.org/docs/package-triage-process)

#### Przez Scoop (nieoficjalne)

Użytkownicy [Scoop](https://scoop.sh) mogą pobrać i zainstalować najnowszy Terminal,
instalując pakiet `windows-terminal`:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Aby zaktualizować Windows Terminal przez Scoop, uruchom:

```powershell
scoop update windows-terminal
```

Jeśli napotkasz problemy podczas instalacji/aktualizacji pakietu, wyszukaj lub zgłoś problem
na [stronie zgłoszeń](https://github.com/lukesampson/scoop-extras/issues) repozytorium Scoop Extras.

---

## Instalacja Windows Terminal Canary
Windows Terminal Canary to nocna kompilacja Windows Terminal. Ta wersja zawiera najnowszy kod z naszej gałęzi `main`, dając Ci możliwość wypróbowania funkcji zanim trafią do Windows Terminal Preview.

Windows Terminal Canary to najmniej stabilna wersja, więc możesz napotkać błędy zanim je wykryjemy.

Windows Terminal Canary jest dostępny jako dystrybucja przez App Installer oraz jako przenośna dystrybucja ZIP.

Dystrybucja App Installer obsługuje automatyczne aktualizacje. Ze względu na ograniczenia platformy, ten instalator działa tylko na Windows 11.

Dystrybucja przenośna ZIP to aplikacja przenośna. Nie będzie aktualizować się automatycznie ani sprawdzać aktualizacji. Ta dystrybucja działa na Windows 10 (19041+) i Windows 11.

| Dystrybucja   | Architektura    | Link                                                 |
|---------------|:---------------:|------------------------------------------------------|
| App Installer | x64, arm64, x86 | [pobierz](https://aka.ms/terminal-canary-installer)  |
| Portable ZIP  | x64             | [pobierz](https://aka.ms/terminal-canary-zip-x64)    |
| Portable ZIP  | ARM64           | [pobierz](https://aka.ms/terminal-canary-zip-arm64)  |
| Portable ZIP  | x86             | [pobierz](https://aka.ms/terminal-canary-zip-x86)    |

_Dowiedz się więcej o [typach dystrybucji Windows Terminal](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Mapa drogowa Windows Terminal

Plan rozwoju Windows Terminal [opisano tutaj](/doc/roadmap-2023.md)
i będzie aktualizowany wraz z postępem projektu.

## Przegląd Terminala i Konsoli

Prosimy poświęcić kilka minut na zapoznanie się z poniższym przeglądem przed rozpoczęciem pracy z kodem:

### Windows Terminal

Windows Terminal to nowa, nowoczesna, bogata w funkcje i produktywna aplikacja terminalowa
dla użytkowników linii poleceń. Zawiera wiele funkcji najczęściej oczekiwanych przez społeczność,
w tym obsługę kart, bogaty tekst, globalizację, konfigurowalność, motywy, stylizację i wiele więcej.

Terminal musi też spełniać nasze cele i kryteria, aby pozostał szybki i wydajny oraz nie zużywał zbyt dużo pamięci czy energii.

### Windows Console Host

Windows Console Host, `conhost.exe`, to oryginalne środowisko wiersza poleceń Windows.
Hostuje infrastrukturę linii poleceń oraz serwer API konsoli, silnik wejścia, silnik renderowania, preferencje użytkownika itp. Kod hosta konsoli w tym repozytorium to rzeczywiste źródło, z którego budowany jest `conhost.exe` w systemie Windows.

Od przejęcia odpowiedzialności za linię poleceń Windows w 2014 roku, zespół dodał kilka nowych funkcji do Konsoli, w tym przezroczystość tła, zaznaczanie liniowe, obsługę [sekwencji ANSI / Virtual Terminal](https://en.wikipedia.org/wiki/ANSI_escape_code), [kolorów 24-bit](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/), [Pseudokonsolę ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) i inne.

Jednak ponieważ głównym celem Konsoli Windows jest zachowanie kompatybilności wstecznej, nie byliśmy w stanie dodać wielu funkcji oczekiwanych przez społeczność (i zespół), takich jak karty, tekst unicode czy emoji.

Te ograniczenia doprowadziły nas do stworzenia nowego Windows Terminal.

> Możesz przeczytać więcej o ewolucji linii poleceń ogólnie oraz w Windows w [tej serii postów na blogu](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/) zespołu Command-Line.

### Współdzielone komponenty

Podczas modernizacji Windows Console znacznie unowocześniliśmy bazę kodową, wyodrębniliśmy logiczne elementy w moduły i klasy, wprowadziliśmy kluczowe punkty rozszerzalności, zastąpiliśmy stare, własne kolekcje i kontenery bezpieczniejszymi, wydajniejszymi [kontenerami STL](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) oraz uprościliśmy i zabezpieczyliśmy kod dzięki [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil).

Ta modernizacja sprawiła, że kilka kluczowych komponentów Konsoli jest dostępnych do ponownego użycia w dowolnej implementacji terminala na Windows. Są to m.in. nowy silnik układu i renderowania tekstu oparty na DirectWrite, bufor tekstu obsługujący UTF-16 i UTF-8, parser/emiter VT i inne.

### Tworzenie nowego Windows Terminal

Planując nową aplikację Windows Terminal, przeanalizowaliśmy i oceniliśmy kilka podejść i stosów technologicznych. Ostatecznie zdecydowaliśmy, że nasze cele zostaną najlepiej zrealizowane poprzez dalszy rozwój naszej bazy kodowej C++, co pozwoli nam wykorzystać zmodernizowane komponenty zarówno w istniejącej Konsoli, jak i w nowym Terminalu. Dodatkowo zrozumieliśmy, że umożliwi nam to zbudowanie rdzenia Terminala jako wielokrotnego użytku kontrolki UI, którą inni mogą używać w swoich aplikacjach.

Efekt tej pracy znajduje się w tym repozytorium i jest dostarczany jako aplikacja Windows Terminal, którą można pobrać ze sklepu Microsoft Store lub [bezpośrednio z wydań tego repozytorium](https://github.com/microsoft/terminal/releases).

---

## Zasoby

Więcej informacji o Windows Terminal można znaleźć w poniższych zasobach:

* [Blog Command-Line](https://devblogs.microsoft.com/commandline)
* [Seria blogów Command-Line Backgrounder](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Premiera Windows Terminal: [Terminal "Sizzle Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Premiera Windows Terminal: [Build 2019 Session](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal z Richardem Turnerem](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [Odcinek 54 - Kayla Cinnamon i Rich Turner o DevOps w zespole Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Session: [Nowoczesny wiersz poleceń Windows: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### Zbudowałem i uruchomiłem nowy Terminal, ale wygląda jak stara konsola

Przyczyna: Uruchamiasz niewłaściwe rozwiązanie w Visual Studio.

Rozwiązanie: Upewnij się, że budujesz i wdrażasz projekt `CascadiaPackage` w Visual Studio.

> [!UWAGA]
> `OpenConsole.exe` to po prostu lokalnie zbudowany `conhost.exe`, klasyczna Konsola Windows hostująca infrastrukturę linii poleceń. OpenConsole jest używane przez Windows Terminal do łączenia się i komunikacji z aplikacjami wiersza poleceń (przez [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Dokumentacja

Wszystka dokumentacja projektu znajduje się pod adresem [aka.ms/terminal-docs](https://aka.ms/terminal-docs). Jeśli chcesz współtworzyć dokumentację, zgłoś pull request w [repozytorium dokumentacji Windows Terminal](https://github.com/MicrosoftDocs/terminal).

---

## Współtworzenie

Cieszymy się, że możemy współpracować z Tobą, naszą wspaniałą społecznością, aby budować i rozwijać Windows Terminal\!

***ZANIM zaczniesz pracę nad funkcją/poprawką***, przeczytaj i stosuj się do naszego
[Poradnika współtwórcy](./CONTRIBUTING.md), aby uniknąć niepotrzebnej lub powielonej pracy.

## Kontakt z zespołem

Najłatwiej skontaktować się z zespołem przez zgłoszenia GitHub.

Zgłaszaj nowe problemy, prośby o funkcje i sugestie, ale **przed utworzeniem nowego zgłoszenia sprawdź, czy nie istnieją podobne otwarte/zamknięte zgłoszenia.**

Jeśli masz pytanie, które nie wymaga jeszcze zgłoszenia, skontaktuj się z nami przez Twittera:

* Christopher Nguyen, Product Manager: [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Engineering Lead: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Senior Developer: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Developer: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Developer
* Leonard Hecker, Developer: [@LeonardHecker](https://twitter.com/LeonardHecker)

## Wskazówki dla deweloperów

## Wymagania wstępne

Możesz skonfigurować środowisko do budowania Terminala na dwa sposoby:

### Użycie pliku konfiguracyjnego WinGet

Po sklonowaniu repozytorium możesz użyć [pliku konfiguracyjnego WinGet](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)
do skonfigurowania środowiska. [Domyślny plik konfiguracyjny](.config/configuration.winget) instaluje Visual Studio 2022 Community i wszystkie wymagane narzędzia. Dostępne są dwa inne warianty pliku konfiguracyjnego w katalogu [.config](.config) dla edycji Enterprise i Professional Visual Studio 2022. Aby uruchomić domyślny plik konfiguracyjny, możesz dwukrotnie kliknąć plik z eksploratora lub uruchomić polecenie:

```powershell
winget configure .config\configuration.winget
```

### Konfiguracja ręczna

* Musisz używać Windows 10 2004 (kompilacja >= 10.0.19041.0) lub nowszego, aby uruchomić Windows Terminal
* Musisz [włączyć Tryb Dewelopera w aplikacji Ustawienia Windows](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development), aby lokalnie instalować i uruchamiać Windows Terminal
* Musisz mieć zainstalowany [PowerShell 7 lub nowszy](https://github.com/PowerShell/PowerShell/releases/latest)
* Musisz mieć zainstalowany [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
* Musisz mieć zainstalowane co najmniej [VS 2022](https://visualstudio.microsoft.com/downloads/)
* Musisz zainstalować następujące Workloads przez Instalator VS. Uwaga: Otwarcie rozwiązania w VS 2022 [wywoła automatyczną instalację brakujących składników](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * Desktop Development with C++
  * Universal Windows Platform Development
  * **Następujące Indywidualne Komponenty**
    * C++ (v143) Universal Windows Platform Tools
* Musisz zainstalować [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) aby budować projekty testowe

## Budowanie kodu

OpenConsole.sln można budować z poziomu Visual Studio lub z linii poleceń
używając zestawu skryptów i narzędzi w katalogu **/tools**:

### Budowanie w PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Budowanie w Cmd

```shell
.\tools\razzle.cmd
bcz
```

## Uruchamianie i debugowanie

Aby debugować Windows Terminal w VS, kliknij prawym przyciskiem na `CascadiaPackage` (w Eksploratorze Rozwiązań) i przejdź do właściwości. W menu Debug zmień "Application process" i "Background task process" na "Native Only".

Następnie powinieneś móc budować i debugować projekt Terminala naciskając <kbd>F5</kbd>. Upewnij się, że wybrano platformę "x64" lub "x86" - Terminal nie buduje się dla "Any Cpu" (ponieważ Terminal to aplikacja C++, a nie C#).

> 👉 Nie będzie można uruchomić Terminala bezpośrednio przez WindowsTerminal.exe. Więcej szczegółów dlaczego, zobacz
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### Wskazówki dotyczące kodowania

Prosimy zapoznać się z poniższymi krótkimi dokumentami dotyczącymi naszych praktyk kodowania.

> 👉 Jeśli czegoś brakuje w tej dokumentacji, śmiało współtwórz dowolny plik dokumentacji w repozytorium (lub napisz nowy!)

To jest praca w toku, w miarę jak uczymy się, co będzie potrzebne, by efektywnie współtworzyć nasz projekt.

* [Styl kodowania](./doc/STYLE.md)
* [Organizacja kodu](./doc/ORGANIZATION.md)
* [Wyjątki w naszej bazie kodu legacy](./doc/EXCEPTIONS.md)
* [Przydatne inteligentne wskaźniki i makra do pracy z Windows w WIL](./doc/WIL.md)

---

## Kodeks postępowania

Ten projekt przyjął [Kodeks postępowania Microsoft Open Source][conduct-code]. Więcej informacji znajduje się w [FAQ Kodeksu postępowania][conduct-FAQ] lub kontaktując się pod [opencode@microsoft.com][conduct-email] w przypadku dodatkowych pytań lub komentarzy.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---