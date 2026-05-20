
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
  Zbiór modyfikacji, ulepszeń i zasobów inżynierii wstecznej dla Creation Kit firmy Bethesda.
</p>

# Opis
**CKPE** to platforma o otwartym kodzie źródłowym, która wprowadza liczne poprawki i ulepszenia do edytora Creation Kit od **Bethesdy**, obejmuje wsparcie edytora dla gier takich jak **Skyrim Special Edition**, **Fallout 4**, **Starfield**, jest następcą projektów [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), a także [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test), który zapoczątkował wszystko dla autora **perchik71**.  

Strona [Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki)  

# Wymagane biblioteki
[toml11](https://github.com/ToruNiina/toml11) od `ToruNiina` i innych  
[Zydis](https://github.com/zyantific/zydis.git) od `zyantifi` i innych  
[zipper](https://github.com/kuba--/zip.git) od `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) od `ebiggers` i innych  
[xbyak](https://github.com/herumi/xbyak.git) od `herumi` i innych    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) od `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) od `perchik71` *(rekurencyjnie)*

# Instalacja
>[!WAŻNE]
>Wersja standardowa czy noavx2?  
>Sprawdź w Steam czy Twój procesor obsługuje avx2. Otwórz Steam, najedź na menu pomoc w lewym rogu, wybierz Informacje o systemie i wyszukaj AVX2.  
>Jeśli jest obsługiwane, wybierz wersję standardową  
>Jeśli nie, wybierz wersję noavx2  
### Czysta instalacja
Pobierz dowolną [wspieraną grę](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) i zainstaluj Creation Kit.  
Pobierz [najnowsze wydanie](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) **CKPE** dla swojej gry.  
Wypakuj całą zawartość do katalogu gry, tak aby **ckpe_loader.exe** znajdował się w tym samym folderze co **CreationKit.exe**.
### Aktualizacja
Pobierz [najnowsze wydanie](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) **CKPE** dla swojej gry.  
Wypakuj całą zawartość do katalogu gry, tak aby **ckpe_loader.exe** znajdował się w tym samym folderze co **CreationKit.exe**.  
Zgódź się na zastąpienie wszystkich plików.
### Kompilacja
Zwykli użytkownicy potrzebują tej metody tylko, aby uzyskać dostęp do najnowszych funkcji, które nie zostały jeszcze wydane.  
Otwórz projekt w **`Visual Studio 2022`** lub nowszym. Zbuduj projekt w trybie **`Release`** lub **`Release-NoAVX2`**.  
Następnie przenieś wynik kompilacji do katalogu gry, tak aby **ckpe_loader.exe** znajdował się w tym samym folderze co **CreationKit.exe**.  
Jeśli pojawi się pytanie o zastąpienie starych plików, zgódź się na zastąpienie wszystkich.
### Automatyzacja kompilacji (Beta)
Pobierz [najnowszą wersję skompilowaną](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) **CKPE** dla swojej gry.  
Wypakuj całą zawartość do katalogu gry, tak aby **ckpe_loader.exe** znajdował się w tym samym folderze co **CreationKit.exe**.  
Możliwe błędy.

# Podziękowania
[Nukem9](https://github.com/Nukem9) (za funkcje eksperymentalne, hash i inne, bardzo przydatne)  
[adzm](https://github.com/adzm) (Bardzo doceniam Twoją pracę, zrobiłeś [to](https://github.com/adzm/win32-custom-menubar-aero-theme), co od dawna sam chciałem zrobić)  
[yak3d](https://github.com/yak3d) (Za wkład i rozwój workflow oraz wsparcie najnowszego Starfield)  
[DioKyrie-Git](https://github.com/DioKyrie-Git) (Za projekt readme)  

# Licencja
Począwszy od wersji v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) projekt jest licencjonowany na [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Wcześniejsze wersje są licencjonowane na [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. Wszelkie prawa zastrzeżone. <br />
Plik `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` zawiera pliki zastrzeżone i nielicencjonowane; to samo dotyczy plików w `d3dcompiler\*.*`. <br />
Zależności są na podstawie ich odpowiednich licencji. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---