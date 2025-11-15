<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <p>De volgende vertalingen zijn automatisch gegenereerd met AI. Houd er rekening mee dat ze onnauwkeurigheden kunnen bevatten of verwijzen naar oudere versies van deze readme.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

In Player Episode Preview
====================
## 📄 Over
Deze plugin voegt een afleveringenlijst toe aan de videospeler, waarmee je elke aflevering van de tv-serie kunt bekijken zonder de speler te verlaten.

Deze aanpassing ondersteunt de volgende clients:
* [Jellyfin Web Client](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) Desktop Client

## ✨ Functies
* Toon alle afleveringen van een seizoen
* Wissel tussen seizoenen
* Toont afleveringstitel, beschrijving, miniatuur en afspeelvoortgang
* Toont afleveringsdetails zoals community-beoordeling
* Markeer afleveringen als afgespeeld of favoriet
* Start een nieuwe aflevering
* Moet werken met aangepaste thema's

## 📸 Preview
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Gebruikt thema: (SkinManager) Kaleidochromic
<br>
Deze preview mist de nieuwe knoppen voor het markeren van een aflevering als voltooid of favoriet.

## 🔧 Installatie

### Jellyfin Web Client (Server)

> [!LET OP]
> Het is sterk aanbevolen om [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) minimaal v2.2.1.0 geïnstalleerd te hebben. Dit helpt om toestemmingproblemen te voorkomen bij het aanpassen van index.html op elke installatie!
<details open>
<summary> Zie instructies... </summary>

1. Voeg het manifest `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` toe als een Jellyfin plugin repository aan je server.
2. Installeer de plugin `InPlayerEpisodePreview` vanuit de repository.
3. Herstart de Jellyfin server.
</details>

### Jellyfin Media Player (JMP) Desktop Client (Verouderd)
<details>
<summary> Zie instructies... </summary>

**Verouderd met JMP Versie [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

Omdat de nieuwe JMP-client de huidige webspeler van de server zelf gebruikt, is het niet langer nodig om wijzigingen direct in de clientcode aan te brengen.

Dit is de aanbevolen manier om het script op de desktopclient te installeren.
Als je je niet prettig voelt bij het zelf bewerken van het nativeshell.js-bestand (stap 3 t/m 6), kun je in plaats daarvan de volledige release downloaden, waarin het script al is toegevoegd aan het nativeshell.js-bestand.
Het is nog onduidelijk of er mogelijke problemen kunnen ontstaan bij het vervangen van het nativeshell.js-bestand door degene uit de release, dus het wordt aanbevolen om alle onderstaande stappen te volgen.

1. Download de laatste release [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) of [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (bevat het script al toegevoegd aan het nativeshell.js-bestand)
2. Pak het zip-bestand uit in je Jellyfin-map (bijv. C:\Program Files\Jellyfin\Jellyfin Media Player)
3. Volg in je Jellyfin-map het pad naar de map "web-client\extension"
4. Open het bestand "nativeshell.js" in een teksteditor.
5. Zoek in het bestand het gedeelte `const plugins = [];`. Voeg een nieuwe regel toe aan het begin van de lijst en plak daarin `'inPlayerEpisodePreviewPlugin',`. Het gedeelte ziet er nu ongeveer zo uit:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Sla het bestand op en herstart de JMP-client.
</details>

## 💡 Probleemoplossing

### 1. De voorbeeldknop is niet zichtbaar
Dit is hoogstwaarschijnlijk gerelateerd aan verkeerde machtigingen voor het bestand `index.html`.

<details>
<summary> Zie een lijst met mogelijke oplossingen... </summary>

#### 1.1 Voorkom dit probleem door de [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) plugin te gebruiken.

#### 1.2 Eigendom wijzigen in een docker-container
Als je jellyfin in een docker-container draait, kun je het eigendom wijzigen met het volgende commando
(vervang jellyfin door je containernaam, user en group door de gebruiker en groep van je container):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Je kunt dit als een cron-taak uitvoeren bij het opstarten van het systeem.
(Dank aan [muisje](https://github.com/muisje) voor hulp met [deze](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) oplossing)

#### 1.3 Eigendom wijzigen op een Windows-installatie
1. Navigeer naar: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Klik met de rechtermuisknop op `index.html` → `Eigenschappen` → `Tabblad Beveiliging` → Klik op `Bewerken`
3. Selecteer je gebruiker uit de lijst en vink het vakje Schrijven `machtiging` aan.
4. Herstart zowel de server als de client.
   (Dank aan [xeuc](https://github.com/xeuc) voor [deze](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) oplossing)

Als geen van bovenstaande oplossingen werkt, kijk dan eens naar oude issues. Bijvoorbeeld [hier](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) of [hier](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Als je een fout tegenkomt die je niet zelf kunt oplossen, open gerust een issue.
<br/>Houd er rekening mee dat elk systeem anders is, wat kan leiden tot onverwacht gedrag, dus voeg zo veel mogelijk informatie toe.
<br/>Jellyfin-logboeken en console-logboeken uit de browser (geprefixeerd als [InPlayerEpisodePreview]) zijn altijd nuttig.

## Credits
De pluginstructuur is gebaseerd op en geïnspireerd door de [Jellyscrub](https://github.com/nicknsy/jellyscrub) plugin van [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---