
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  Een verzameling aanpassingen, verbeteringen en omgekeerd ontwikkelde bronnen voor Creation Kit van Bethesda.
</p>

# Beschrijving
**CKPE** is een gedeeld bron krachtig platform dat talloze fixes en verbeteringen aan de Creation Kit-editor van **Bethesda** biedt, inclusief editorondersteuning voor games zoals **Skyrim Special Edition**, **Fallout 4**, **Starfield**. Het is een opvolger van de projecten [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), en ook de [Unicode patch voor SSE CK 1.5.73](https://github.com/Perchik71/usse_test) die alles in gang zette voor de auteur **perchik71**.  

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) pagina  

# Afhankelijkheden
[toml11](https://github.com/ToruNiina/toml11) door `ToruNiina` en anderen  
[Zydis](https://github.com/zyantific/zydis.git) door `zyantifi` en anderen  
[zipper](https://github.com/kuba--/zip.git) door `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) door `ebiggers` en anderen  
[xbyak](https://github.com/herumi/xbyak.git) door `herumi` en anderen    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) door `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) door `perchik71` *(recursief)*

# Installatie
### Nieuwe installatie
Download een [ondersteunde game](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) en installeer de Creation Kit.  
Download de [laatste release](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) van **CKPE** voor jouw game.  
Pak alle inhoud uit in de gamemap, zodat **ckpe_loader.exe** in dezelfde map staat als **CreationKit.exe**.
### Update
Download de [laatste release](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) van **CKPE** voor jouw game.  
Pak alle inhoud uit in de gamemap, zodat **ckpe_loader.exe** in dezelfde map staat als **CreationKit.exe**.  
Ga akkoord om alle bestanden te vervangen.
### Compilatie
Normale gebruikers hebben deze methode alleen nodig om toegang te krijgen tot de nieuwste functies die nog niet zijn uitgebracht.  
Open een project in **`Visual Studio 2022`** of later. Bouw het project in **`Release`**-modus of **`Release-NoAVX2`**.  
Verplaats daarna je build-output naar de gamemap, zodat **ckpe_loader.exe** in dezelfde map staat als **CreationKit.exe**.  
Indien gevraagd om oude bestanden te vervangen, ga akkoord met vervangen.
### Geautomatiseerde builds (Beta)
Download de [laatste commit-build](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) van **CKPE** voor jouw game.  
Pak alle inhoud uit in de gamemap, zodat **ckpe_loader.exe** in dezelfde map staat als **CreationKit.exe**.  
Mogelijke fouten.

# Credits
[Nukem9](https://github.com/Nukem9) (voor experimentele functies, hash en dergelijke, zeer nuttig)  
[adzm](https://github.com/adzm) (Ik waardeer je werk enorm, je hebt [gedaan](https://github.com/adzm/win32-custom-menubar-aero-theme) wat ik zelf al lang wilde doen)  
[yak3d](https://github.com/yak3d) (Voor de bijdrage en ontwikkeling van workflow en ondersteuning van de nieuwste Starfield)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (Voor het ontwerp van de readme)  

# Licentie
Vanaf v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) is het project gelicenseerd onder [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Vroege versies zijn gelicentieerd onder [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. Alle rechten voorbehouden. <br />
Bestand `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` bevat eigendomsrechtelijk beschermde en niet-gelicentieerde bestanden; hetzelfde geldt voor bestanden in `d3dcompiler\*.*`. <br />
Afhankelijkheden vallen onder hun respectievelijke licenties. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---