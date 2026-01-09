
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  Zbiór modyfikacji, ulepszeń oraz zasobów pozyskanych metodą inżynierii wstecznej dla Creation Kit firmy Bethesda.
</p>

# Opis
**CKPE** to potężna platforma o otwartym kodzie źródłowym, która wprowadza liczne poprawki i ulepszenia do edytora Creation Kit od **Bethesda**, obejmuje wsparcie edytora dla takich gier jak **Skyrim Special Edition**, **Fallout 4**, **Starfield** i jest następcą projektów [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), a także [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test), który zapoczątkował wszystko dla autora **perchik71**.

Strona [Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki)

# Zależności
[toml11](https://github.com/ToruNiina/toml11) autorstwa `ToruNiina` i innych  
[Zydis](https://github.com/zyantific/zydis.git) autorstwa `zyantifi` i innych  
[zipper](https://github.com/kuba--/zip.git) autorstwa `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) autorstwa `ebiggers` i innych  
[xbyak](https://github.com/herumi/xbyak.git) autorstwa `herumi` i innych    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) autorstwa `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) autorstwa `perchik71` *(rekurencyjnie)*

# Instalacja
### Nowa instalacja
Pobierz dowolną [obsługiwaną grę](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) i zainstaluj Creation Kit.  
Pobierz [najnowsze wydanie](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) **CKPE** dla swojej gry.  
Wypakuj wszystkie pliki do katalogu gry, tak aby **ckpe_loader.exe** znajdował się w tym samym folderze co **CreationKit.exe**.
### Aktualizacja
Pobierz [najnowsze wydanie](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) **CKPE** dla swojej gry.  
Wypakuj wszystkie pliki do katalogu gry, tak aby **ckpe_loader.exe** znajdował się w tym samym folderze co **CreationKit.exe**.  
Zgódź się na zastąpienie wszystkich plików.
### Kompilacja
Zwykli użytkownicy potrzebują tej metody tylko do uzyskania najnowszych funkcji, które jeszcze nie zostały wydane.  
Otwórz projekt w **`Visual Studio 2022`** lub nowszym. Zbuduj projekt w trybie **`Release`** lub **`Release-NoAVX2`**.  
Następnie przenieś wynik kompilacji do katalogu gry, tak aby **ckpe_loader.exe** znajdował się w tym samym folderze co **CreationKit.exe**.  
Jeśli zostaniesz poproszony o zastąpienie starych plików, wyraź zgodę na ich zastąpienie.
### Automatyczne kompilacje (Beta)
Pobierz [najnowszą kompilację z commita](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) **CKPE** dla swojej gry.  
Wypakuj wszystkie pliki do katalogu gry, tak aby **ckpe_loader.exe** znajdował się w tym samym folderze co **CreationKit.exe**.  
Możliwe błędy.

# Podziękowania
[Nukem9](https://github.com/Nukem9) (za funkcje eksperymentalne, hash itd., bardzo przydatne)  
[adzm](https://github.com/adzm) (naprawdę doceniam twoją pracę, zrobiłeś [to](https://github.com/adzm/win32-custom-menubar-aero-theme), co sam od dawna chciałem zrobić)  
[yak3d](https://github.com/yak3d) (za wkład i rozwój workflow oraz wsparcie najnowszego Starfielda)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (za projekt pliku readme)

# Licencja
Od wersji v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) projekt jest licencjonowany na zasadach [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Wcześniejsze wersje są licencjonowane na podstawie [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. Wszelkie prawa zastrzeżone. <br />
Plik `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` zawiera pliki zastrzeżone i nielicencjonowane; to samo dotyczy plików w `d3dcompiler\*.*`. <br />
Zależności są objęte odpowiednimi licencjami. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---