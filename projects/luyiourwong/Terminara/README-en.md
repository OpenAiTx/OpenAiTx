
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">Assamese</
      </div>
    </div>
  </details>

</div>

# Terminara

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Python support](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

A terminal-based AI simulation game.

## How to use

You can download the executable application from [latest release](https://github.com/luyiourwong/Terminara/releases/latest).

The full compressed file includes the executable file and the default world settings file. You can only download the executable file if you are updating the game to the latest version.

| OS      | Version                                          |
|---------|--------------------------------------------------|
| Windows | Windows 10, Windows 11                           |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26           |

<details>
<summary><strong>Manual run</strong></summary>

### Installation

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **Create a virtual environment:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    On Windows, use `.venv\Scripts\activate`

3.  **Install the dependencies:**
    ```bash
    pip install -e .
    ```
### Start Method 1: Using the installed command (Recommended)
After installation, run the game with:

```bash
terminara
```

### Start Method 2: Direct execution
Cross-platform way
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
On Windows, use `terminara\main.py`

for more information, see [Contribute & Develop Guide](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## AI Setup

After starting the application, you need to configure the AI settings from the main menu.

![AI Settings](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

You need to fill in the following fields: (OpenAI compatibility API)
- **Host**: The API endpoint. Leave it empty to use the default OpenAI endpoint.
- **API Key**: Your API key for the AI service.
- **Model**: The model you want to use.

Click "Apply" to save the settings.

### Examples

#### 1. [OpenAI](https://platform.openai.com/) (Default)
- **Host**: (leave empty)
- **API Key**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## World Setup

### Configuration Storage
World settings are stored in the `terminara/data/worlds` directory. (in full release)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Creating a new world
There is an example world [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). You can follow the [schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) to create a new world.

## Links

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub Repository](https://github.com/luyiourwong/Terminara)
- [Contribute & Develop Guide](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## License

This project is licensed under the [MIT License](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---