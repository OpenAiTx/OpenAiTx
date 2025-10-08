
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 yt-dlp Video Batch Download Tool (Windows / Linux Ondersteuning)

> Een one-click video downloadscript gebaseerd op [yt-dlp](https://github.com/yt-dlp/yt-dlp), geïnspireerd door [NodeSeek's gedeelde post](https://www.nodeseek.com/post-334093-2#15).
> Ondersteunt zowel enkele video's als batchdownloads, compatibel met Windows en de gangbare Linux distributies (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Functies en Kenmerken

* 📥 **One-click uitvoeren**: Geen handmatige configuratie nodig, voer gewoon de gevraagde informatie in om te beginnen met downloaden
* 🍪 **Ondersteuning voor aangepaste Cookie**: Geschikt voor video’s die alleen na inloggen te downloaden zijn (⚠️ Deze functie is nog niet getest, mogelijk zijn er bugs)
* 📂 **Ondersteuning voor aangepaste uitvoermap**: Gemakkelijk opslaan in een opgegeven map
* 📃 **Ondersteuning voor batch-downloads**: Leest automatisch de links uit het `urls.txt`-bestand voor downloaden
* ⚙️ **Automatische installatie van afhankelijkheden**: Installeert automatisch `yt-dlp` en `ffmpeg` in Linux-omgevingen

---

## 🖼️ Screenshot Voorbeeld

| Voorbeeld 1                                                                  | Voorbeeld 2                                                                  |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| ![Voorbeeld 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Voorbeeld 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Voorbeeld 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Voorbeeld 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Windows Gebruiksaanwijzing

1. Download de volgende bestanden:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` Windows-versie](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Pak uit en plaats de volgende bestanden in dezelfde map (bijv. de `yt-dlp` map):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (scriptbestand)

3. Dubbelklik op `yt-dlp.bat` en volg de instructies om video's te downloaden.
4. Bewerk config/config.ini om de standaardconfiguratie aan te passen

---

## 🐧 Linux Gebruiksaanwijzing (Het nieuwste script van Techlion integreert deze functionaliteit ook)

**Ondersteunde systemen**: Debian / Ubuntu / Alpine / CentOS

Eenmalige implementatie of update en uitvoeren:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

Om te deïnstalleren:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```
---

## 📱 Aanbevolen voor Android-gebruik

1. Gebruik de [Seal](https://github.com/JunkFood02/Seal) App om de `yt-dlp` functionaliteit op Android te ervaren.
2. Je kunt Debian installeren via termux om ook te downloaden, maar dat is niet nodig; Seal is erg gebruiksvriendelijk.

---

## ⚠️ Opmerkingen

1. **Batch-downloadmodus**: Het script leest automatisch de `config\urls.txt` in de huidige map, één videolink per regel. Als het bestand niet bestaat, wordt het automatisch aangemaakt.
2. **Resourcegebruik-waarschuwing**: Apparaten met weinig geheugen moeten het gelijktijdig downloaden van grote video's of het instellen van te veel threads vermijden.
3. **CentOS speciale toelichting**: Vanwege de bijzondere omgeving is er nog geen volledige test uitgevoerd; gebruik bij voorkeur niet in productie. Alle andere gangbare systemen zijn getest en bruikbaar bevonden.
4. Kleine bug in Linux-versie: Bij het starten van het script op de hoofdpagina wordt één keer op afhankelijkheden gecontroleerd. Werkt volgens het principe 'als het draait is het goed', geen zin om aan te passen.
5. Kleine bug in Windows-versie: Als je van een andere pagina terugkeert naar de hoofdpagina en opnieuw kiest, kan de standaardoptie niet werken en blijft het script hangen. Beperkte capaciteit, niet goed opgelost.
Twee mogelijke oplossingen:
    1. Afsluiten en opnieuw starten
    2. Niet standaard kiezen, gewoon het nummer invoeren

---

## 📄 Licentie

Dit project valt onder de [MIT License](https://opensource.org/licenses/MIT).

---



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---