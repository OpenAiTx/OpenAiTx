
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
  Una raccolta di modifiche, miglioramenti e risorse ingegnerizzate inversamente per il Creation Kit di Bethesda.
</p>

# Descrizione
**CKPE** è una potente piattaforma a sorgente condivisa che apporta numerose correzioni e miglioramenti all’editor Creation Kit di **Bethesda**, include il supporto all’editor per giochi come **Skyrim Special Edition**, **Fallout 4**, **Starfield**, ed è il successore dei progetti [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), oltre che della [Unicode patch per SSE CK 1.5.73](https://github.com/Perchik71/usse_test) che ha dato il via a tutto per l’autore **perchik71**.  

Pagina [Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki)  

# Dipendenze
[toml11](https://github.com/ToruNiina/toml11) di `ToruNiina` e altri  
[Zydis](https://github.com/zyantific/zydis.git) di `zyantifi` e altri  
[zipper](https://github.com/kuba--/zip.git) di `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) di `ebiggers` e altri  
[xbyak](https://github.com/herumi/xbyak.git) di `herumi` e altri  
[DirectXTex](https://github.com/microsoft/DirectXTex.git) di `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) di `perchik71` *(ricorsiva)*

# Installazione
### Nuova installazione
Scarica qualsiasi [gioco supportato](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) e installa Creation Kit.  
Scarica [l’ultima release](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) di **CKPE** per il tuo gioco.  
Estrai tutto il contenuto nella directory del gioco, in modo che **ckpe_loader.exe** si trovi nella stessa cartella di **CreationKit.exe**.
### Aggiornamento
Scarica [l’ultima release](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) di **CKPE** per il tuo gioco.  
Estrai tutto il contenuto nella directory del gioco, in modo che **ckpe_loader.exe** si trovi nella stessa cartella di **CreationKit.exe**.  
Acconsenti alla sostituzione di tutti i file.
### Compilazione
Gli utenti normali necessitano di questo metodo solo per accedere alle funzionalità più recenti non ancora rilasciate.  
Apri il progetto in **`Visual Studio 2022`** o versioni successive. Compila il progetto in modalità **`Release`** o **`Release-NoAVX2`**.  
Quindi sposta l’output della compilazione nella directory del gioco, in modo che **ckpe_loader.exe** sia nella stessa cartella di **CreationKit.exe**.  
Se viene richiesto di sostituire i vecchi file, accetta di sostituirli tutti.
### Build automatizzate (Beta)
Scarica la [build dell’ultima commit](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) di **CKPE** per il tuo gioco.  
Estrai tutto il contenuto nella directory del gioco, in modo che **ckpe_loader.exe** si trovi nella stessa cartella di **CreationKit.exe**.  
Possibili errori.

# Crediti
[Nukem9](https://github.com/Nukem9) (per funzioni sperimentali, hash e altro, molto utili)  
[adzm](https://github.com/adzm) (Apprezzo molto il tuo lavoro, hai [realizzato](https://github.com/adzm/win32-custom-menubar-aero-theme) ciò che volevo fare io stesso da tempo)  
[yak3d](https://github.com/yak3d) (Per il contributo e lo sviluppo del workflow e il supporto a Starfield più recente)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (Per il design del readme)  

# Licenza
A partire dalla v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) il progetto è concesso sotto licenza [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Le versioni iniziali sono concesse in licenza secondo la [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. Tutti i diritti riservati. <br />
Il file `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` contiene file proprietari e non concessi in licenza; lo stesso vale per i file in `d3dcompiler\*.*`. <br />
Le dipendenze sono soggette alle rispettive licenze. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---