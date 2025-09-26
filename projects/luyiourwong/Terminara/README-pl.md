
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

[![Zapytaj DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Obsługa Pythona](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-niebieski)

Gra symulacyjna AI w terminalu.

## Jak używać

Możesz pobrać plik wykonywalny aplikacji z [najnowszego wydania](https://github.com/luyiourwong/Terminara/releases/latest).

Pełny plik skompresowany zawiera plik wykonywalny oraz domyślny plik ustawień świata. Możesz pobrać tylko plik wykonywalny, jeśli aktualizujesz grę do najnowszej wersji.

| OS      | Wersja                                              |
|---------|-----------------------------------------------------|
| Windows | Windows 10, Windows 11                              |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS    |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26              |

<details>
<summary><strong>Ręczne uruchomienie</strong></summary>

### Instalacja

1.  **Sklonuj repozytorium:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **Utwórz środowisko wirtualne:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    Na systemie Windows użyj `.venv\Scripts\activate`

3.  **Zainstaluj zależności:**
    ```bash
    pip install -e .
    ```

### Metoda uruchomienia 1: Użycie zainstalowanej komendy (Zalecane)
Po instalacji uruchom grę za pomocą:
```bash
terminara
```

### Metoda uruchamiania 2: Bezpośrednie wykonanie
Sposób wieloplatformowy
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Na Windows użyj `terminara\main.py`

aby uzyskać więcej informacji, zobacz [Przewodnik Współtworzenia i Rozwoju](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## Ustawienia AI

Po uruchomieniu aplikacji musisz skonfigurować ustawienia AI z głównego menu.

![Ustawienia AI](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

Musisz wypełnić następujące pola: (API kompatybilne z OpenAI)
- **Host**: Endpoint API. Pozostaw puste, aby użyć domyślnego endpointu OpenAI.
- **Klucz API**: Twój klucz API do usługi AI.
- **Model**: Model, którego chcesz użyć.

Kliknij "Zastosuj", aby zapisać ustawienia.

### Przykłady

#### 1. [OpenAI](https://platform.openai.com/) (Domyślny)
- **Host**: (pozostaw puste)
- **Klucz API**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **Klucz API**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## Konfiguracja Świata

### Przechowywanie konfiguracji
Ustawienia świata są przechowywane w katalogu `terminara/data/worlds`. (w pełnej wersji)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Tworzenie nowego świata
Istnieje przykładowy świat [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). Możesz wykorzystać [schemat](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json), aby utworzyć nowy świat.

## Linki

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [Repozytorium GitHub](https://github.com/luyiourwong/Terminara)
- [Przewodnik współpracy i rozwoju](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## Licencja

Ten projekt jest objęty licencją [MIT License](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---