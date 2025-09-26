
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Terminara

[![Chiedi a DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Supporto Python](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

Un gioco di simulazione AI basato su terminale.

## Come usare

Puoi scaricare l'applicazione eseguibile dalla [ultima release](https://github.com/luyiourwong/Terminara/releases/latest).

Il file compresso completo include il file eseguibile e il file delle impostazioni del mondo predefinito. Puoi scaricare solo il file eseguibile se stai aggiornando il gioco all'ultima versione.

| OS      | Versione                                         |
|---------|--------------------------------------------------|
| Windows | Windows 10, Windows 11                           |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26           |

<details>
<summary><strong>Esecuzione manuale</strong></summary>

### Installazione

1.  **Clona il repository:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **Crea un ambiente virtuale:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    Su Windows, usa `.venv\Scripts\activate`

3.  **Installa le dipendenze:**
    ```bash
    pip install -e .
    ```

### Metodo iniziale 1: Utilizzo del comando installato (Consigliato)
Dopo l'installazione, avvia il gioco con:
```bash
terminara
```

### Metodo di avvio 2: Esecuzione diretta
Metodo multipiattaforma
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Su Windows, usa `terminara\main.py`

per ulteriori informazioni, vedi [Guida a Contribuire & Sviluppare](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## Configurazione AI

Dopo aver avviato l'applicazione, è necessario configurare le impostazioni AI dal menu principale.

![Impostazioni AI](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

È necessario compilare i seguenti campi: (API compatibile con OpenAI)
- **Host**: L'endpoint API. Lascia vuoto per usare l'endpoint predefinito di OpenAI.
- **API Key**: La tua chiave API per il servizio AI.
- **Model**: Il modello che vuoi utilizzare.

Fai clic su "Applica" per salvare le impostazioni.

### Esempi

#### 1. [OpenAI](https://platform.openai.com/) (Predefinito)
- **Host**: (lascia vuoto)
- **API Key**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## Configurazione Mondo

### Archiviazione della Configurazione
Le impostazioni del mondo sono memorizzate nella directory `terminara/data/worlds`. (nella release completa)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Creazione di un nuovo mondo
Esiste un mondo di esempio [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). Puoi seguire lo [schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) per creare un nuovo mondo.

## Link

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [Repository GitHub](https://github.com/luyiourwong/Terminara)
- [Guida per Contribuire & Sviluppare](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## Licenza

Questo progetto è distribuito sotto la [Licenza MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---