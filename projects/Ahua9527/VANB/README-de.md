# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (哇!! NB)

VANB ist ein auf GStreamer basierendes Tool zur Umwandlung von Video-/Audioströmen und unterstützt die bidirektionale Konvertierung zwischen NDI und RTMP Protokollen. Es ermöglicht das Senden von NDI-Quellen an einen RTMP-Server oder die Umwandlung eines RTMP-Streams in einen NDI-Ausgang.

Dieses Projekt ist quelloffen unter der [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) Lizenz.

## Unterstützte Plattformen

Derzeit werden hauptsächlich folgende Plattformen unterstützt:
- macOS (Apple Silicon)

## Systemanforderungen

### Systemabhängigkeiten
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Installationsschritte
1. Installieren Sie das [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. Installieren Sie GStreamer über Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. Klonen Sie das Projekt-Repository
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Installieren Sie die Python-Abhängigkeiten
```bash
pip install -r requirements.txt
```

5. Konfigurieren Sie die Umgebungsvariablen (siehe .env Datei)
```bash
# NDI SDK Pfad konfigurieren
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# GStreamer Plugin-Pfad konfigurieren
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Verwendung

### NDI zu RTMP (Sender)
```bash
python vanb_tx.py
```
Das Programm scannt automatisch nach verfügbaren NDI-Quellen und fordert Sie zur Eingabe der RTMP-Stream-Adresse auf.

### RTMP zu NDI (Empfänger)
```bash
python vanb_rx.py
```
Nach der Eingabe der RTMP-Stream-Adresse erstellt das Programm automatisch einen neuen NDI-Ausgang.

## Entwicklungsstatus

### Bereits implementierte Funktionen
- ✓ Konvertierung von NDI zu RTMP
- ✓ Konvertierung von RTMP zu NDI
- ✓ Automatische Anpassung von Framerate und Auflösung
- ✓ Audio-/Videosynchronisation
- ✓ Automatisches Scannen der NDI-Quellen
- ✓ Automatische Benennung der NDI-Ausgänge
- ✓ VideoToolbox Hardware-Encoding/Decoding

### Noch zu implementierende Funktionen
- ⨯ Unterstützung für Konfigurationsdateien (Profile/config.json)
  - Steuerung der Ein- und Ausgangsparameter über eine Konfigurationsdatei
  - Unterstützung mehrerer Transcoding-Voreinstellungen
  - Konfigurierbare Puffergröße und Latenzparameter
  - Konfigurierbare Balance zwischen Qualität und Performance beim Transcoding
- ⨯ Gleichzeitige Verarbeitung mehrerer Streams

## Lizenzhinweis

⚠️ **Wichtiger Hinweis: Lizenz und Compliance**

### Software-Lizenz

Dieses Projekt steht unter der [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html).

Gründe für die Wahl der GPL-3.0 Lizenz:
1. Dieses Projekt verwendet mehrere GPL-lizenzierte GStreamer-Plugins:
   - `x264`: H.264 Video-Encoder (GPL)
   - `x265`: HEVC/H.265 Video-Encoder (GPL)
   - `faad`: AAC Audio-Decoder (GPL)
2. Gemäß den Copyleft-Bestimmungen der GPL muss Software, die GPL-Komponenten nutzt, ebenfalls unter der GPL stehen.
3. Die Wahl der GPL-3.0 stellt die Kompatibilität mit allen abhängigen Komponentenlizenzen sicher.

### Lizenzanforderungen

Bei der Nutzung dieses Projekts müssen Sie folgende Anforderungen einhalten:
1. **Quelloffenheit**: Wenn Sie den Code dieses Projekts ändern oder in Ihr eigenes Projekt integrieren, müssen Sie Ihren vollständigen Quellcode offenlegen.
2. **Beibehaltung der Lizenz**: Ihr Projekt muss weiterhin unter der GPL-3.0 Lizenz stehen.
3. **Urheberrechtshinweis**: Sie müssen die ursprünglichen Urheberrechts- und Lizenzhinweise beibehalten.
4. **Deutliche Kennzeichnung**: Wenn Sie den Code ändern, müssen Sie Ihre Änderungen deutlich kennzeichnen.
5. **Patentlizenz**: Die GPL-3.0 enthält ausdrückliche Patentlizenzbedingungen.

### Lizenzierung der GStreamer-Komponenten
1. Dieses Projekt ist nur für Entwicklungs- und Testzwecke bestimmt.
2. NDI® ist eine eingetragene Marke von NewTek, Inc.
3. Die Nutzung dieses Projekts unterliegt den Lizenzbedingungen des NewTek NDI® SDK.
4. Stellen Sie vor dem Einsatz in Produktionsumgebungen sicher, dass Sie alle erforderlichen Lizenzen und Genehmigungen eingeholt haben.

## Problembehandlung

Falls Probleme auftreten, gehen Sie bitte wie folgt vor:
1. Überprüfen Sie, ob die Umgebungsvariablen korrekt konfiguriert sind.
2. Stellen Sie sicher, dass die GStreamer-Plugins korrekt installiert sind.
3. Prüfen Sie die ausführlichen Fehlermeldungen in den Logdateien.
4. Melden Sie Probleme über Issues und fügen Sie Protokolle sowie Umgebungsinformationen bei.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---