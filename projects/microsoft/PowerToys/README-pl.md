# Microsoft PowerToys

![Obraz główny Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[Jak używać PowerToys][usingPowerToys-docs-link] | [Pobieranie i informacje o wydaniu][github-release-link] | [Wkład w PowerToys](#contributing) | [Co się dzieje](#whats-happening) | [Mapa drogowa](#powertoys-roadmap)

## O programie

Microsoft PowerToys to zestaw narzędzi dla zaawansowanych użytkowników, umożliwiających dostosowanie i usprawnienie pracy w systemie Windows w celu zwiększenia produktywności. Więcej informacji na temat [przeglądu PowerToys i jak korzystać z narzędzi][usingPowerToys-docs-link] oraz innych narzędzi i zasobów do [środowisk deweloperskich Windows](https://learn.microsoft.com/windows/dev-environment/overview) znajdziesz na [learn.microsoft.com][usingPowerToys-docs-link]!

|              | Obecne narzędzia: |              |
|--------------|--------------------|--------------|
| [Advanced Paste](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Always on Top](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Color Picker](https://aka.ms/PowerToysOverview_ColorPicker) | [Command Not Found](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [Crop And Lock](https://aka.ms/PowerToysOverview_CropAndLock) | [Zmienne środowiskowe](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [Dodatki Eksploratora plików](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Edytor pliku Hosts](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Image Resizer](https://aka.ms/PowerToysOverview_ImageResizer) | [Keyboard Manager](https://aka.ms/PowerToysOverview_KeyboardManager) | [Narzędzia myszy](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Mouse Without Borders](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [Wklej jako tekst zwykły](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [Registry Preview](https://aka.ms/PowerToysOverview_RegistryPreview) | [Linijka ekranu](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Przewodnik po skrótach](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Wyodrębnianie tekstu](https://aka.ms/PowerToysOverview_TextExtractor) | [Workspaces](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Instalacja i uruchomienie Microsoft PowerToys

### Wymagania

- Windows 11 lub Windows 10 w wersji 2004 (nazwa kodowa 20H1 / numer kompilacji 19041) lub nowszy.
- Procesor x64 lub ARM64
- Instalator zainstaluje następujące elementy:
   - [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703) bootstrapper. Zostanie zainstalowana najnowsza wersja.

### Przez GitHub za pomocą EXE [Zalecane]

Przejdź na [stronę wydań Microsoft PowerToys na GitHub][github-release-link] i kliknij `Assets` na dole, aby wyświetlić pliki dostępne w wydaniu. Użyj odpowiedniego instalatora PowerToys zgodnego z architekturą i zakresem instalacji Twojego komputera. Dla większości użytkowników będzie to `x64` i instalacja dla użytkownika.

<!-- elementy wymagające aktualizacji przy każdym wydaniu -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  Opis   | Nazwa pliku | skrót sha256 |
|---------|-------------|--------------|
| Dla użytkownika - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Dla użytkownika - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Dla wszystkich - x64        | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Dla wszystkich - ARM64      | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

To jest nasza preferowana metoda.

### Przez Microsoft Store

Zainstaluj z [PowerToys na Microsoft Store][microsoft-store-link]. Musisz korzystać z [nowego Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/), który jest dostępny zarówno dla Windows 11, jak i Windows 10.

### Przez WinGet
Pobierz PowerToys za pomocą [WinGet][winget-link]. Aktualizacja PowerToys przez winget uwzględnia obecny zakres instalacji PowerToys. Aby zainstalować PowerToys, uruchom poniższe polecenie z wiersza poleceń / PowerShell:

#### Instalator dla użytkownika [domyślny]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Instalator dla wszystkich użytkowników

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Inne metody instalacji

Istnieją [społecznościowe metody instalacji](./doc/unofficialInstallMethods.md), takie jak Chocolatey czy Scoop. Jeśli są to Twoje preferowane rozwiązania instalacyjne, instrukcje znajdziesz pod tym adresem.

## Wtyczki Run firm trzecich

Istnieje kolekcja [wtyczek firm trzecich](./doc/thirdPartyRunPlugins.md) stworzonych przez społeczność, które nie są dystrybuowane razem z PowerToys.

## Wkład

Ten projekt przyjmuje wszelkiego rodzaju wkład. Oprócz funkcji programistycznych / poprawek błędów, inne formy pomocy to pisanie specyfikacji, projektowanie, dokumentacja i wyszukiwanie błędów. Z radością współpracujemy ze społecznością zaawansowanych użytkowników, aby stworzyć zestaw narzędzi pomagających w pełni wykorzystać możliwości Windows.

Prosimy, aby **zanim zaczniesz pracę nad funkcją, którą chcesz dodać**, zapoznać się z naszym [Przewodnikiem dla współtwórców](CONTRIBUTING.md). Chętnie pomożemy ustalić najlepsze podejście, udzielimy wskazówek i wsparcia podczas prac oraz pomożemy uniknąć zbędnych lub zduplikowanych działań.

Większość wkładów wymaga zgody na [Umowę Licencyjną Współtwórcy (CLA)][oss-CLA], w której oświadczasz, że przekazujesz nam prawo do wykorzystania swojego wkładu i masz do tego uprawnienia.

Wskazówki dotyczące rozwoju PowerToys znajdziesz w [dokumentacji dla programistów](/doc/devdocs), gdzie szczegółowo opisano konfigurację środowiska kompilacji.

## Co się dzieje

### Mapa drogowa PowerToys

Nasza [priorytetowa mapa drogowa][roadmap] funkcji i narzędzi, na których koncentruje się główny zespół.

### 0.91 - Aktualizacja maj 2025

W tym wydaniu skupiliśmy się na nowych funkcjach, stabilności i automatyzacji.

**✨Najważniejsze**

 - Skupiliśmy się na znacznym poprawieniu wydajności Command Palette i naprawieniu wielu błędów. Dodaliśmy m.in.:
 - Możliwość wyszukiwania dowolnego pliku w Command Palette za pomocą polecenia zapasowego.
 - Możliwość ustawienia globalnego skrótu Command Palette jako niskopoziomowego haka klawiatury.
 - Dodano polecenie otwierania adresu URL dla rozszerzenia WebSearch, umożliwiające bezpośrednie otwieranie adresów w przeglądarce z poziomu Command Palette.
 - Możesz teraz definiować własne formaty w wtyczkach Data i Godzina w PT Run oraz Command Palette. Dzięki [@htcfreek](https://github.com/htcfreek)!

### Advanced Paste

 - Naprawiono problem, w którym Advanced Paste nie mógł utworzyć silnika OCR dla niektórych tagów języka angielskiego (np. en-CA), inicjalizując silnik OCR zgodnie z językiem profilu użytkownika. Dzięki [@cryolithic](https://github.com/cryolithic)!

### Color Picker

 - Naprawiono wyciek zasobów powodujący zawieszanie lub awarie przez właściwe usuwanie obiektu Graphics. Dzięki [@dcog989](https://github.com/dcog989)!
 - Naprawiono problem, w którym Color Picker zamykał się po naciśnięciu Backspace, zapewniając zamykanie tylko przy skupieniu i ujednolicając działanie Escape/Backspace. Dzięki [@PesBandi](https://github.com/PesBandi)!
 - Dodano obsługę formatów kolorów Oklab i Oklch. Dzięki [@lemonyte](https://github.com/lemonyte)!

### Command Not Found

 - Zaktualizowano skrypt WinGet Command Not Found, by włączać funkcje eksperymentalne tylko, jeśli faktycznie istnieją.

### Command Palette

 - Zaktualizowano szablon zgłoszenia błędu o moduł Command Palette.
 - Naprawiono problem, w którym okno powiadomień nie skalowało się do DPI, powodując problemy z układem przy skalowaniu wyświetlacza.
 - Naprawiono problem, w którym nawigacja klawiaturą w górę/dół nie przesuwała zaznaczenia, gdy kursor był na pozycji 0, oraz dodano ciągłą nawigację jak w PT Run v1. Dzięki [@davidegiacometti](https://github.com/davidegiacometti)!
 - Uproszczono kod rozszerzenia Czas i Data, poprawiając przejrzystość.
 - Naprawiono problem, w którym wielkość liter w poleceniu powodowała błąd przy przejściu do wskaźnika myszy, dostosowując komendę do małych liter.
 - Dodano polecenie otwierania adresu URL dla rozszerzenia WebSearch. Dzięki [@htcfreek](https://github.com/htcfreek)!
 - Dodano ustawienie umożliwiające włączanie/wyłączanie ikony w zasobniku systemowym w CmdPal oraz ujednolicono terminologię z Windows 11. Dzięki [@davidegiacometti](https://github.com/davidegiacometti)!
 - Naprawiono problem z aktualizacją aliasu, usuwając stary alias przy ustawianiu nowego.
 - Rozwiązano konflikt wielkości liter na GitHub, przenosząc Exts i exts do nowego katalogu ext, zapewniając spójność struktury na różnych platformach i zapobiegając fragmentacji ścieżek.
 - Naprawiono problem, w którym polecenie 'Utwórz nowe rozszerzenie' generowało puste nazwy plików.
 - Dodano możliwość ustawienia globalnego skrótu jako niskopoziomowego haka klawiatury.
 - Dodano obsługę miniatur JUMBO, umożliwiając dostęp do ikon w wysokiej rozdzielczości.
 - Naprawiono awarie, gdy CmdPal automatycznie się ukrywał przy otwartym oknie MSAL, uniemożliwiając ukrycie CmdPal, jeśli jest wyłączony.
 - Dodano obsługę natychmiastowego zaznaczania tekstu wyszukiwania po załadowaniu strony.
 - Naprawiono błąd uniemożliwiający ponowne ładowanie ustawień rozszerzenia po ponownym otwarciu, aktualizując formularz ustawień po zapisaniu ustawień rozszerzenia.
 - Naprawiono problem z uruchamianiem Command Palette z poziomu runnera.
 - Przepisano i przeniesiono logikę kalkulatora PowerToys Run v1 do Command Palette, dodano obsługę ustawień i ulepszono zachowanie zapasowe.
 - Przywrócono obsługę skrótów klawiaturowych dla elementów listy.
 - Zwiększono dostępność w Command Palette, dodając odpowiednie etykiety, poprawiając animacje, lokalizację i naprawiając problemy a11y.
 - Przeniesiono obsługę własnych formatów do wtyczki Czas i Data, uporządkowano ustawienia, poprawiono komunikaty o błędach i naprawiono awarie w sytuacjach brzegowych dla większej niezawodności i wygody. Dzięki [@htcfreek](https://github.com/htcfreek)!
 - Dodano element zapasowy dla polecenia systemowego.
 - Naprawiono błąd, w którym dla akcji "Otwórz Kosz" wyświetlał się błędnie komunikat "Puste" w podpowiedzi klawisza. Dzięki [@jironemo](https://github.com/jironemo)!
 - Naprawiono problem z listą "więcej poleceń", gdzie wyświetlane były komendy, które nie powinny być widoczne. Dzięki [@davidegiacometti](https://github.com/davidegiacometti)!
 - Naprawiono problem z wyświetlaniem zbyt dużej ikony i przesuniętego tekstu w widoku szczegółów, ujednolicając do zachowania Windows Search.
 - Naprawiono błąd, w którym puste treści ekranu i polecenia paska poleceń były ucinane przy długich etykietach, zapewniając poprawny układ i widoczność.
 - Ulepszono integrację CmdPal z WinGet, poprawiając wyświetlanie wersji zainstalowanych pakietów, umożliwiając aktualizacje z ikonami i migrację API preview winget do stabilnej wersji.
 - Naprawiono błąd, w którym polecenia dla ContentPage aktualizowały się dopiero po wyjściu, zapewniając pełną inicjalizację menu kontekstowego przy zmianie.
 - Dodano obsługę zapasową do rozszerzenia TimeDate, umożliwiając bezpośrednie zapytania o datę/godzinę bez wyboru polecenia.
 - Dodano import Common.Dotnet.AotCompatibility.props do wielu plików projektów CmdPal dla lepszej obsługi kompilacji AOT.
 - Naprawiono awarię ustawień CmdPal spowodowaną przez null HotKey, gdy settings.json nie zawierał zdefiniowanego skrótu. Dzięki [@davidegiacometti](https://github.com/davidegiacometti)!
 - Dodano obsługę filtrowalnych, zagnieżdżonych menu kontekstowych w CmdPal, w tym pole wyszukiwania dla zachowania skupienia.
 - Przepisano klasy CmdPal dla poprawy serializacji JSON i wprowadzono nowe konteksty serializacji dla lepszej wydajności i możliwości utrzymania.
 - Dodano obsługę kompilacji ahead-of-time (AoT).
 - Dodano mechanizm ponawiania uruchamiania CmdPal.
 - Usunięto nieużywane pliki z CmdPal.Common dla uproszczenia kodu i oznaczenia jako AoT-compatible.
 - Naprawiono błąd, w którym warunek wyścigu przy aktualizacji SearchText powodował, że kursor w polu wprowadzania przeskakiwał automatycznie na koniec linii, zapewniając aktualizację SearchText tylko po faktycznej zmianie.
 - Dodano obsługę wyszukiwania dowolnego pliku w poleceniu zapasowym.
 - Oczyszczono kod związany z AoT, by zapobiegać podwójnym operacjom podczas testów.
 - Skrócono czas ładowania CmdPal, równolegle uruchamiając rozszerzenia i wprowadzając limity czasowe, by nieprawidłowe rozszerzenia nie blokowały innych.
 - Ulepszono zachowanie UI przez ukrywanie panelu szczegółów po opróżnieniu listy, unikając niespójnych stanów wizualnych.
 - Dodano obsługę usuwania polecenia zapasowego w CmdPal, jeśli nie znaleziono pasującego polecenia, zapewniając czystsze ponowne ładowanie.
 - Naprawiono wyciek w szablonie rozszerzenia CmdPal przez poprawne użycie ComServer.
 - Zapobieżono maksymalizowaniu okna CmdPal przez dwukrotne kliknięcie paska tytułu, by zachować zamierzone zachowanie okna. Dzięki [@davidegiacometti](https://github.com/davidegiacometti)!
 - Naprawiono problem, w którym UI ustawień uruchamiał się zbyt mały, czyniąc wymiary okna zależne od DPI oraz wymuszając minimalną szerokość i wysokość przez WinUIEx.
 - Naprawiono białe błyski i jednorazowe animacje w CmdPal przez ukrywanie okna zamiast jego zamykania.
 - Naprawiono błąd, w którym wszystkie ustawienia rozszerzeń były pobierane przy starcie przez leniwe ładowanie ustawień, zmniejszając obciążenie inicjalizacyjne.
 - Dodano ochronę CmdPal przed awariami podczas błędów parsowania Adaptive Card.
 - Zamieniono shell:AppsFolder na aktywację URI w CmdPal dla poprawy niezawodności.
 - Dodano możliwość otwierania ustawień CmdPal z ustawień PowerToys.
 - Dodano możliwość dynamicznej aktualizacji szczegółów rozszerzenia przez obserwowanie zmian właściwości wybranego elementu.
 - Zaktualizowano wersję zestawu narzędzi używanego w szablonie rozszerzenia CmdPal do 0.2.0.

### Image Resizer

 - Naprawiono problem, w którym usunięcie predefiniowanego rozmiaru powodowało usunięcie niewłaściwego ustawienia.

### Keyboard Manager

 - Naprawiono błąd, gdzie klawisz modyfikujący ustawiony bez określenia lewego/prawego blokował się przez błędną obsługę klawiszy, śledząc naciśnięte klawisze i wysyłając odpowiedni klawisz. Dzięki [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - Rozszerzono możliwości formatowania czasu w PowerRename, dodając wzorce formatu 12-godzinnego z obsługą AM/PM. Dzięki [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - Dodano obsługę własnych formatów w wtyczce "Czas i Data" oraz ulepszono komunikaty o błędach dla nieprawidłowych formatów wejściowych. Dzięki [@htcfreek](https://github.com/htcfreek)!
 - Naprawiono dwie awarie: jedną dla WFT przy bardzo wczesnych datach i drugą przy obliczaniu tygodnia miesiąca dla bardzo późnych dat (np. 31.12.9999), a także uporządkowano ustawienia UI. Dzięki [@htcfreek](https://github.com/htcfreek)!
 - Naprawiono problem z wielkością liter w poleceniu podczas przechodzenia do wskaźnika myszy, dostosowując polecenie do małych liter.
 - Dodano szczegóły wersji do komunikatów o błędach wtyczek dla 'Błąd ładowania' i 'Błąd inicjalizacji'. Dzięki [@htcfreek](https://github.com/htcfreek)!
 - Rozszerzono model wyników o możliwość zapobiegania sortowaniu na podstawie użycia, dając deweloperom większą kontrolę nad kolejnością. Dzięki [@CoreyHayward](https://github.com/CoreyHayward) i [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - Zaktualizowano mapowanie liter w GetDefaultLetterKeyEPO, zastępując "ǔ" na "ŭ" dla klawisza VK_U, aby dokładniej oddać fonetykę esperanto. Dzięki [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - Naprawiono problem, w którym Quick Accent nie działał poprawnie przy użyciu klawiatury ekranowej. Dzięki [@davidegiacometti](https://github.com/davidegiacometti)!

### Registry Preview

 - Rozszerzono Registry Preview o możliwość wklejania kluczy i wartości rejestru bez ręcznego wpisywania nagłówka pliku oraz dodano przycisk resetowania aplikacji. Dzięki [@htcfreek](https://github.com/htcfreek)!

### Ustawienia

 - Naprawiono problem, w którym aplikacja Ustawienia losowo wyświetlała pustą ikonę na pasku zadań, odraczając przypisanie ikony do momentu aktywacji okna.
 - Dodano możliwość maksymalizacji okna "Co nowego" dla wygodniejszego czytania.

### Workspaces

 - Naprawiono błędy, przez które gry Steam nie były poprawnie wykrywane ani uruchamiane, aktualizując filtrowanie okien i obsługę protokołu URL Steam.

### Dokumentacja

 - Dodano QuickNotes do dokumentacji wtyczek firm trzecich PowerToys Run. Dzięki [@ruslanlap](https://github.com/ruslanlap)!
 - Dodano wtyczki Weather i Pomodoro do dokumentacji wtyczek firm trzecich PowerToys Run. Dzięki [@ruslanlap](https://github.com/ruslanlap)!
 - Dodano wtyczkę Linear do dokumentacji wtyczek firm trzecich PowerToys Run. Dzięki [@vednig](https://github.com/vednig)!
 - Naprawiono problemy z formatowaniem plików dokumentacji i zaktualizowano informacje o współtwórcach i członkach zespołu. Dzięki [@DanielEScherzer](https://github.com/DanielEScherzer) i [@RokyZevon](https://github.com/RokyZevon)!

### Rozwój

 - Zaktualizowano akcję GitHub do instalacji .NET 9 na potrzeby wydania MSStore.
 - Zaktualizowano placeholder wersji w bug_report.yml, by zapobiec błędnemu wersjonowaniu v0.70.0 w zgłoszeniach.
 - Zaktualizowano akcję GitHub, podnosząc actions/setup-dotnet z wersji 3 do 4 dla wydania MSStore.
 - Dodano securityContext do plików konfiguracyjnych WinGet, umożliwiając uruchamianie z kontekstu użytkownika i pojedyncze wywołanie UAC dla podniesionych zasobów w osobnym procesie. Dzięki [@mdanish-kh](https://github.com/mdanish-kh)!
 - Zmieniono rozszerzenia plików dzienników z .txt na .log dla poprawnego powiązania plików i kompatybilności narzędzi, oraz dodano logi dla Workspaces. Dzięki [@benwa](https://github.com/benwa)!
 - Uaktualniono zależności frameworka testowego i ujednolicono wersje pakietów w komponentach.
 - Uaktualniono zależności dla poprawy bezpieczeństwa.
 - Zwiększono bezpieczeństwo repozytorium przez przypinanie akcji GitHub i tagów Docker do niezmiennych pełnych commitów oraz integrację automatycznego skanowania podatności zależności przez Dependency Review Workflow. Dzięki [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Uaktualniono zależności Boost do nowszej wersji.
 - Uaktualniono toolkit do najnowszej wersji, wyciszając ostrzeżenia związane z AoT.
 - Naprawiono problem, w którym brak podpisu dla nowo dodanych plików powodował błędy kompilacji.
 - Uaktualniono pipeline wydania, by nie publikować symboli prywatnych przez 100 lat.
 - Wprowadzono fuzzing dla PowerRename w celu poprawy niezawodności i dodano wskazówki dotyczące rozszerzania fuzzingu na inne moduły C++.
 - Dodano centralne pre-tworzenie folderów generowanych dla wszystkich projektów .csproj, by zapobiec awariom kompilacji.
 - Zaktualizowano WinAppSDK do najnowszej wersji 1.7.
 - Uaktualniono zależności Boost do najnowszej wersji dla projektu PowerRename Fuzzing.
 - Zaktualizowano ścieżkę obszaru ADO w tsa.json, by rozwiązać błędy pipeline TSA spowodowane przestarzałą ścieżką.
 - Rozpoczęto wsparcie AoT dla CmdPal — prace podstawowe w toku.
  
### Narzędzie/Ogólne

 - Dodano możliwość automatycznego generowania zgłoszenia błędu przez tworzenie wstępnie wypełnionego adresu URL zgłoszenia GitHub z informacjami o systemie i diagnostyce. Dzięki [@donlaci](https://github.com/donlaci)!
 - Dodano skrypty do lokalnej kompilacji instalatora, zapewniając możliwość uruchamiania CmdPal w środowisku lokalnym.
 - Usunięto eksport logiki PFX, eliminując użycie twardo zakodowanego hasła i rozwiązując ostrzeżenie PSScriptAnalyzer dotyczące bezpieczeństwa.
 - Dodano skrypt PowerShell i integrację CI do wymuszania spójnego użycia Common.Dotnet.CsWinRT.props we wszystkich projektach C# pod folderem src.
   
### Co jest planowane na wersję 0.92

Dla [v0.92][github-next-release-work] planujemy pracę nad poniższymi elementami:

 - Kontynuacja dopracowania Command Palette
 - Nowe testy automatyzacji interfejsu użytkownika
 - Prace nad ulepszeniem instalatora
 - Ulepszenie UI edytora Keyboard Manager
 - Poprawa stabilności / naprawa błędów

## Społeczność PowerToys

Zespół PowerToys jest niezmiernie wdzięczny za [wsparcie niesamowitej, aktywnej społeczności][community-link]. Wasza praca jest niezwykle ważna. PowerToys nie byłby tym, czym jest dziś bez Waszej pomocy w zgłaszaniu błędów, aktualizacji dokumentacji, współtworzeniu projektów czy pisaniu funkcji. Chcemy podziękować i poświęcić czas, by docenić Wasze osiągnięcia. Z miesiąca na miesiąc, bezpośrednio pomagacie czynić PowerToys lepszym oprogramowaniem.

## Kodeks postępowania

Ten projekt przyjął [Kodeks Postępowania Microsoft Open Source][oss-conduct-code].

## Oświadczenie o prywatności

Aplikacja rejestruje podstawowe dane diagnostyczne (telemetria). Więcej informacji na temat prywatności i zbieranych danych znajdziesz w [dokumentacji dotyczącej danych i prywatności PowerToys](https://aka.ms/powertoys-data-and-privacy-documentation).

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---