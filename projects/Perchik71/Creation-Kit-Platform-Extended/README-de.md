
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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
  Eine Sammlung von Modifikationen, Verbesserungen und rückentwickelten Ressourcen für das Creation Kit von Bethesda.
</p>

# Beschreibung
**CKPE** ist eine quelloffene, leistungsstarke Plattform, die zahlreiche Fehlerbehebungen und Verbesserungen für den Creation Kit Editor von **Bethesda** bietet. Sie unterstützt Editoren für Spiele wie **Skyrim Special Edition**, **Fallout 4**, **Starfield** und ist der Nachfolger der Projekte [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) sowie des [Unicode-Patches für SSE CK 1.5.73](https://github.com/Perchik71/usse_test), mit dem für den Autor **perchik71** alles begann.  

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) Seite  

# Abhängigkeiten
[toml11](https://github.com/ToruNiina/toml11) von `ToruNiina` und anderen  
[Zydis](https://github.com/zyantific/zydis.git) von `zyantifi` und anderen  
[zipper](https://github.com/kuba--/zip.git) von `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) von `ebiggers` und anderen  
[xbyak](https://github.com/herumi/xbyak.git) von `herumi` und anderen  
[DirectXTex](https://github.com/microsoft/DirectXTex.git) von `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) von `perchik71` *(rekursiv)*

# Installation
### Neuinstallation
Laden Sie ein beliebiges [unterstütztes Spiel](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) herunter und installieren Sie das Creation Kit.  
Laden Sie die [neueste Version](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) von **CKPE** für Ihr Spiel herunter.  
Entpacken Sie alle Inhalte ins Spielverzeichnis, sodass **ckpe_loader.exe** sich im selben Ordner wie **CreationKit.exe** befindet.
### Update
Laden Sie die [neueste Version](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) von **CKPE** für Ihr Spiel herunter.  
Entpacken Sie alle Inhalte ins Spielverzeichnis, sodass **ckpe_loader.exe** sich im selben Ordner wie **CreationKit.exe** befindet.  
Stimmen Sie zu, alle Dateien zu ersetzen.
### Kompilierung
Normale Nutzer benötigen diese Methode nur, um auf die neuesten, noch nicht veröffentlichten Funktionen zuzugreifen.  
Öffnen Sie das Projekt in **`Visual Studio 2022`** oder neuer. Bauen Sie das Projekt im **`Release`**-Modus oder **`Release-NoAVX2`**.  
Verschieben Sie danach Ihr Build-Output ins Spielverzeichnis, sodass **ckpe_loader.exe** sich im selben Ordner wie **CreationKit.exe** befindet.  
Wenn Sie aufgefordert werden, alte Dateien zu ersetzen, stimmen Sie zu.
### Automatisierte Builds (Beta)
Laden Sie das [neueste Commit-Build](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) von **CKPE** für Ihr Spiel herunter.  
Entpacken Sie alle Inhalte ins Spielverzeichnis, sodass **ckpe_loader.exe** sich im selben Ordner wie **CreationKit.exe** befindet.  
Mögliche Fehler.

# Danksagungen
[Nukem9](https://github.com/Nukem9) (für experimentelle Funktionen, Hashing usw., sehr nützlich)  
[adzm](https://github.com/adzm) (Ich schätze deine Arbeit sehr, du hast [umgesetzt](https://github.com/adzm/win32-custom-menubar-aero-theme), was ich schon lange selbst tun wollte)  
[yak3d](https://github.com/yak3d) (Für den Beitrag und die Entwicklung des Workflows sowie die Unterstützung des neuesten Starfield)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (Für das Design des Readme)  

# Lizenz
Ab Version v0.6 (Commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) ist das Projekt unter der [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html) lizenziert. <br />
Frühere Versionen sind unter [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) lizenziert <br />
Copyright © 2023-2025 aka perchik71. Alle Rechte vorbehalten. <br />
Die Datei `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` enthält proprietäre und nicht lizenzierte Dateien; dasselbe gilt für Dateien in `d3dcompiler\*.*`. <br />
Abhängigkeiten unterliegen ihren jeweiligen Lizenzen. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---