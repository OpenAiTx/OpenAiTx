<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesisch</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

Als je dit project leuk vindt, overweeg dan om me te steunen op Patreon!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Een aangepaste node-extensie voor ComfyUI die tekst-naar-spraak (TTS) en stemconversie (VC) mogelijkheden toevoegt met behulp van de Chatterbox-bibliotheek.
Ondersteunt MAXIMAAL 40 seconden. Ik heb geprobeerd deze beperking te verwijderen, maar het model werkt echt slecht met alles langer dan dat, dus het blijft zo.

![ChatterBox Voorbeeld](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Installatie

1. Clone deze repository in je ComfyUI custom_nodes map:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Installeer de basisafhankelijkheden:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (Optioneel) Installeer ondersteuning voor watermerken:

   ```bash
   pip install resemble-perth
   ```
**Opmerking**: Het `resemble-perth` pakket kan compatibiliteitsproblemen hebben met Python 3.12+. Als je importfouten tegenkomt, blijven de nodes werken zonder watermerken.

## Gebruik

### Tekst-naar-spraak Node (FL Chatterbox TTS)
- Voeg de "FL Chatterbox TTS" node toe aan je workflow
- Configureer de tekstinvoer en parameters (overdrijving, cfg_weight, temperatuur)
- Voeg optioneel een audioprompt toe voor stemklonen

### Stemconversie Node (FL Chatterbox VC)
- Voeg de "FL Chatterbox VC" node toe aan je workflow
- Verbind invoeraudio en doelstem
- Beide nodes ondersteunen CPU-terugval als er CUDA-fouten optreden

## Wijzigingslog

### 24-6-2025
- Zaadparameter toegevoegd aan zowel TTS- als VC-nodes voor reproduceerbare generatie
- Zaadbereik: 0 tot 4.294.967.295 (32-bits integer)
- Zorgt voor consistente audio-uitvoer voor debugging en workflowcontrole
- Perth-watermerk optioneel gemaakt om compatibiliteitsproblemen met Python 3.12+ op te lossen
- Nodes werken nu zonder watermerken als resemble-perth importeren mislukt

### 31-5-2025
- Persistente modellading toegevoegd, evenals laadbalkfunctionaliteit
- Mac-ondersteuning toegevoegd (moet nog getest worden, dus stuur een bericht)
- De chatterbox-tts bibliotheek verwijderd en native inferencecode geïmplementeerd.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---