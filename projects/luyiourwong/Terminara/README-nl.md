
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Terminara

[![Vraag DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Python ondersteuning](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blauw)

Een terminal-gebaseerd ai simulatiespel.

## Hoe te gebruiken

Je kunt de uitvoerbare applicatie downloaden van de [laatste release](https://github.com/luyiourwong/Terminara/releases/latest).

Het volledige gecomprimeerde bestand bevat het uitvoerbare bestand en het standaard wereldinstellingenbestand. Je kunt alleen het uitvoerbare bestand downloaden als je het spel bijwerkt naar de nieuwste versie.

| OS      | Versie                                            |
|---------|---------------------------------------------------|
| Windows | Windows 10, Windows 11                            |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS  |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26            |

<details>
<summary><strong>Handmatig uitvoeren</strong></summary>

### Installatie

1.  **Clone de repository:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **Maak een virtuele omgeving aan:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    Op Windows gebruikt u `.venv\Scripts\activate`

3.  **Installeer de afhankelijkheden:**
    ```bash
    pip install -e .
    ```

### Startmethode 1: Gebruik van het geïnstalleerde commando (Aanbevolen)
Na installatie start je het spel met:
```bash
terminara
```

### Startmethode 2: Directe uitvoering
Platformonafhankelijke methode
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Op Windows gebruik je `terminara\main.py`

voor meer informatie, zie [Contribute & Develop Guide](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## AI-instelling

Na het starten van de applicatie moet je de AI-instellingen configureren via het hoofdmenu.

![AI-instellingen](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

Je moet de volgende velden invullen: (OpenAI-compatibele API)
- **Host**: Het API-eindpunt. Laat leeg om het standaard OpenAI-eindpunt te gebruiken.
- **API-sleutel**: Jouw API-sleutel voor de AI-dienst.
- **Model**: Het model dat je wilt gebruiken.

Klik op "Toepassen" om de instellingen op te slaan.

### Voorbeelden

#### 1. [OpenAI](https://platform.openai.com/) (Standaard)
- **Host**: (laat leeg)
- **API-sleutel**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API-sleutel**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## Wereldinstelling

### Configuratieopslag
Wereldinstellingen worden opgeslagen in de map `terminara/data/worlds`. (in volledige release)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Een nieuwe wereld maken
Er is een voorbeeldwereld [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). Je kunt het [schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) volgen om een nieuwe wereld te maken.

## Links

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub Repository](https://github.com/luyiourwong/Terminara)
- [Bijdragen & Ontwikkelgids](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## Licentie

Dit project is gelicentieerd onder de [MIT-licentie](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---