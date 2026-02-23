
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Automatyczny instalator menedżera pakietów Chocolatey w wine, przydatny do szybkiego instalowania programów w wine (i jednoczesnego wykrywania błędów w wine ;) )  
Dla niektórych błędów dodano obejścia, jak dla Visual Studio Community 2022 i nodejs, patrz dalej.  

Podczas lockdownu, z nudów, napisałem własny winetricks(.ps1) z poleceniami, które uważam za przydatne. Po prostu wpisz 'winetricks', aby je zobaczyć.
Dla niektórych poleceń wymagany jest pełny restart wine (ze względu na ostatnie zmiany w wine). Pojawi się okienko z komunikatem i sesja zostanie zakończona. Wystarczy ponownie uruchomić powershella i spróbować ponownie wykonać polecenie. Jeśli zrobisz to raz, nie będzie to już wymagane dla żadnego polecenia.  

Przykład:  

'winetricks vs22_interactiveinstaller'  ( --> sesja zostanie zakończona)  

wykonaj 'wine powershell'  

wykonaj 'winetricks vs22_interactiveinstaller'  


(NA MARGINESIE przez 'winetricks vs22_interactive_installer' możesz wybrać, co zainstalować poprzez instalator Visual Studio 2022; 'winetricks vs22_interactive_installer' uruchomił mi po dziesięciu minutach główny program (wybrano Desktop development with C++)).

Instalacja :
- Pobierz i rozpakuj plik zip z wydaniem i wykonaj 'wine ChoCinstaller_0.5c.751.exe' (zajmuje około minutę)

Opcjonalnie:
- Uruchom instalator jak 'wine ChoCinstaller_0.5a.751.exe /s' , wtedy pliki instalacyjne (takie jak Powershell*.msi i dotnet48) zostaną zapisane w 
  Moje Dokumenty i nie będzie potrzeby ich ponownie pobierać przy tworzeniu nowego prefixu)
Opcjonalnie:
- Uruchom instalator jak 'wine ChoCinstaller_0.5a.751.exe /q', aby zapobiec automatycznemu uruchomieniu okna powershell (tylko instalacja). 

Opcjonalnie:
- Sprawdź, czy wszystko poszło dobrze: "choco install chromium" oraz  "start chrome.exe (--no-sandbox nie jest już potrzebne od wine-8,4)" 

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
O PowerShell:

Wskazówka: Chocolatey zwykle instaluje najnowszą wersję programu, co może ujawnić nowe błędy wine. Być może lepiej zadziała starsza wersja oprogramowania.  
Przykład:  

choco search --exact microsoft-edge --all (--> wyświetl wszystkie wersje)  

choco install microsoft-edge --version --version='135.0.3179.98'

Informacje ogólne:

- 'wine powershell.exe' uruchamia konsolę PowerShell-Core.

 
O ConEmu:

Konsola ConEmu cierpi z powodu kilku błędów wine:
  - Ctrl^C do zakończenia programu, który nie wraca do konsoli, nie działa. Użyj Shift^Ctrl^C zamiast tego.
  - Wybieranie tekstu w oknie ConEmu (do kopiowania/wklejania) nie podświetla zaznaczenia. Dołączony jest bardzo smutny hack przeciwko najnowszym wersjom wine, który to omija, więc podświetlanie powinno już działać.
   
O winetricks(.ps1):

- Jeśli nie wywołujesz go ('winetricks' w konsoli powershell), nic nie zostaje pobrane, więc nie ma żadnych obciążeń.
- Wiele komend (jak powershell 5.1) wymaga kilku podstawowych plików do rozpakowania danych z pakietów msu. Instalacja tych plików wymaga najpierw ogromnych pobrań i zajmuje dużo czasu przy pierwszym użyciu. Po zcache’owaniu wszystko działa szybko. Na przykład jeśli chcesz wypróbować 'winetricks ps51' najpierw, zajmie to około 15 minut. Niektóre inne komendy mogą zająć 5 minut przy pierwszym użyciu. Po jednorazowym wywołaniu komendy ten problem znika.
- Pliki są cache'owane w katalogu Moje Dokumenty. Jeśli wywołasz wszystkie komendy, zajmie to około 800 MB.
- Miejmy nadzieję, że pojawi się lepsze wsparcie 64-bitowe dla różnych komend.
- Możliwość wyodrębnienia pliku i (próby) instalacji z pliku msu. Wykonaj 'winetricks install_dll_from_msu', aby zobaczyć jak.
- Podstawowy Powershell 5.1.
- Eksperymentalna instalacja dotnet481 oraz dotnet35 (może być potrzebna przez aplikacje, które nie są zadowolone z obecnej instalacji dotnet48).
- Automatyczne uzupełnianie zakładek. Uwaga: podczas używania wielu komend z linii poleceń muszą być oddzielone przecinkiem
  od teraz (tak powershell obsługuje wiele argumentów)
  Więc 'winetricks riched20 gdiplus' nie będzie już działać, użyj 'winetricks riched20,gdiplus' zamiast tego
- Niektóre programy nie udaje się zainstalować/uruchomić przez Chocolatey z powodu błędów wine. Dodałem kilka obejść w winetricks dla nich, zobacz poniżej.
- Specjalne komendy (winetricks vs19, vs22 oraz vs22_interactive_installer) do instalacji działającego Visual Studio Community 2019 i 2022 (patrz zrzut ekranu, >10 min instalacja i wymaga ok. 10GB!, po instalacji uruchom devenv.exe z katalogu c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![zrzut ekranu](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Specjalna komenda do uzyskania dostępu do różnych poleceń unixowych, jak grep, sed, file, less, curl itd. (winetricks git.portable, Uwaga: niektóre polecenia jeszcze nie działają z powodu błędów wine
- Dołączono też kilka skryptów powershell dostosowanych z fragmentów kodu znalezionych w internecie:
    - Jak osadzić exe w skrypcie powershell przez Invoke-ReflectivePEInjection (exe nie pojawi się w tasklist).
    - Jak zrobić efektowne okna komunikatów
    - Konwersja skryptu powershell (ps1) na exe.
    - I kilka innych
 
     
O programach systemowych:

Dodano funkcję zastępowania prostych programów systemowych, jak np. setx.exe, funkcją w
c:\\Program Files\Powershell\7\profile.ps1. Lub dodawania brakujących programów systemowych, jak getmac.exe.
Jeśli programy nie działają przez zbyt mało dojrzałe lub brakujące programy systemowe, można napisać
funkcję zwracającą to, czego program oczekuje.
Jak w profile.ps1 dodałem (między innymi) wmic.exe z obsługą trochę większej liczby opcji,
i podstawowy setx.exe.
Możesz też po prostu manipulować argumentami przekazywanymi do programu systemowego. Zobacz profile.ps1 i choc_install.ps1.
Nie gwarantuję, że to działa również dla bardziej złożonych programów...
 
Uwagi:

  - NIE używaj na istniejącym wineprefix, tylko na świeżo utworzonym! Instalator po prostu głupio instaluje dotnet48 samodzielnie i miesza w kluczach rejestru.
    Jeśli masz już zainstalowaną jakąkolwiek wersję dotnet za pomocą zwykłego winetricks.sh, prawdopodobnie instalacja się nie powiedzie, a nawet jeśli się uda, najprawdopodobniej skończysz z uszkodzonym prefiksem.
    Jeśli musisz instalować rzeczy za pomocą zwykłego winetricks.sh dla programów, NIE używaj żadnych poleceń dotnet*.
    BTW polecenia 'Arial' i 'd3dcompiler_47' są już domyślnie zainstalowane.
  - WINEARCH=win32 NIE jest obsługiwany!
  - Aktualizacja z poprzedniej wersji nie jest (jeszcze) obsługiwana, może później

Kompilacja:
  - Jeśli chcesz samodzielnie skompilować zamiast pobierać binaria: zobacz instrukcje kompilacji w mainv1.c i installer.c
  - Następnie skopiuj choc_install.ps1 do tego samego katalogu
  - Następnie wykonaj 'wine ChoCinstaller_0.5a.735.exe'
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---