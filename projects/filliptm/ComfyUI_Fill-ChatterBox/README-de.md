<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

Wenn dir dieses Projekt gefällt, erwäge, mich auf Patreon zu unterstützen!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Eine benutzerdefinierte Node-Erweiterung für ComfyUI, die Text-zu-Sprache (TTS) und Sprachkonvertierung (VC) mit der Chatterbox-Bibliothek ermöglicht.
Unterstützt MAXIMAL 40 Sekunden. Ich habe versucht, diese Begrenzung zu entfernen, aber das Modell funktioniert bei längeren Eingaben sehr schlecht, daher bleibt sie bestehen.

![ChatterBox Beispiel](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Installation

1. Klonen Sie dieses Repository in Ihr ComfyUI-Verzeichnis custom_nodes:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Installieren Sie die Basis-Abhängigkeiten:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (Optional) Installieren Sie die Unterstützung für Wasserzeichen:

   ```bash
   pip install resemble-perth
   ```
**Hinweis**: Das Paket `resemble-perth` kann Kompatibilitätsprobleme mit Python 3.12+ haben. Wenn Importfehler auftreten, funktionieren die Nodes weiterhin ohne Wasserzeichen.


## Verwendung

### Text-zu-Sprache-Knoten (FL Chatterbox TTS)
- Fügen Sie den "FL Chatterbox TTS"-Knoten zu Ihrem Workflow hinzu
- Konfigurieren Sie den Texteingang und die Parameter (exaggeration, cfg_weight, temperature)
- Optional können Sie ein Audioprompt für Voice Cloning angeben

### Sprachkonvertierungsknoten (FL Chatterbox VC)
- Fügen Sie den "FL Chatterbox VC"-Knoten zu Ihrem Workflow hinzu
- Verbinden Sie Eingangsaudio und Zielstimme
- Beide Nodes unterstützen CPU-Fallback bei CUDA-Fehlern

## Änderungsprotokoll

### 24.06.2025
- Seed-Parameter zu beiden TTS- und VC-Nodes für reproduzierbare Generierung hinzugefügt
- Seed-Bereich: 0 bis 4.294.967.295 (32-Bit-Integer)
- Ermöglicht konsistente Audioausgabe für Debugging und Workflow-Steuerung
- Perth-Wasserzeichen optional gemacht, um Python 3.12+-Kompatibilitätsprobleme zu beheben
- Nodes funktionieren jetzt auch ohne Wasserzeichen, falls resemble-perth-Import fehlschlägt

### 31.05.2025
- Persistentes Modell-Laden und Ladebalken-Funktionalität hinzugefügt
- Mac-Unterstützung hinzugefügt (muss noch getestet werden, also meldet euch)
- Die chatterbox-tts-Bibliothek entfernt und nativen Inferenz-Code implementiert.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---