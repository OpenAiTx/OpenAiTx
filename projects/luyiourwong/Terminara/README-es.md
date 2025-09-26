
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

[![Preguntar en DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Compatibilidad con Python](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

Un juego de simulación de IA basado en terminal.

## Cómo usar

Puedes descargar la aplicación ejecutable desde la [última versión](https://github.com/luyiourwong/Terminara/releases/latest).

El archivo comprimido completo incluye el archivo ejecutable y el archivo de configuración del mundo por defecto. Puedes descargar solo el archivo ejecutable si estás actualizando el juego a la última versión.

| SO      | Versión                                          |
|---------|--------------------------------------------------|
| Windows | Windows 10, Windows 11                           |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26           |

<details>
<summary><strong>Ejecución manual</strong></summary>

### Instalación

1.  **Clona el repositorio:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```
2.  **Crear un entorno virtual:**

    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    En Windows, use `.venv\Scripts\activate`

3.  **Instale las dependencias:**
    ```bash
    pip install -e .
    ```

### Método 1 para iniciar: Usar el comando instalado (Recomendado)
Después de la instalación, ejecuta el juego con:
```bash
terminara
```

### Iniciar Método 2: Ejecución directa
Manera multiplataforma
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
En Windows, use `terminara\main.py`

para más información, consulte la [Guía de Contribución y Desarrollo](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## Configuración de IA

Después de iniciar la aplicación, necesita configurar los ajustes de IA desde el menú principal.

![Configuración de IA](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

Debe completar los siguientes campos: (API compatible con OpenAI)
- **Host**: El endpoint de la API. Déjelo vacío para usar el endpoint predeterminado de OpenAI.
- **Clave API**: Su clave API para el servicio de IA.
- **Modelo**: El modelo que desea usar.

Haga clic en "Aplicar" para guardar la configuración.

### Ejemplos

#### 1. [OpenAI](https://platform.openai.com/) (Predeterminado)
- **Host**: (dejar vacío)
- **Clave API**: `YOUR_OPENAI_API_KEY`
- **Modelo**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **Clave API**: `YOUR_GEMINI_API_KEY`
- **Modelo**: `gemini-2.0-flash`

## Configuración del Mundo

### Almacenamiento de Configuración
Los ajustes del mundo se almacenan en el directorio `terminara/data/worlds`. (en versión completa)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Creando un nuevo mundo
Hay un mundo de ejemplo [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). Puedes seguir el [esquema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) para crear un nuevo mundo.

## Enlaces

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [Repositorio de GitHub](https://github.com/luyiourwong/Terminara)
- [Guía para Contribuir y Desarrollar](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## Licencia

Este proyecto está licenciado bajo la [Licencia MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---