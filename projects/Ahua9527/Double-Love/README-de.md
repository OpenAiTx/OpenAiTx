# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 Liebe zwischen den Frames, doppelte Effizienz

[//]: # (Im Code versteckte Easter Eggs)
<!Double Love: Lass jeden Shot eine unausgesprochene Framerate von mir enthalten -->

[English](./README.en.md) · 简体中文 · [Online-Demo](https://double-love.ahua.space)

</div>

Double Love bietet eine automatisierte und standardisierte Verarbeitung für Metadaten von Klappenblättern. Unterstützt Offline-Nutzung. Ermöglicht nahtlose Integration mit Adobe Premiere, Silverstack, DTG Slate durch Batch- und lokale Verarbeitung, um die Konsistenz der Metadaten zu gewährleisten. Steigert die Effizienz im Postproduktions-Workflow erheblich.

## ✨ Funktionsmerkmale

- 🎬 Unterstützung für industrialisierte Film-Workflows
- 📝 Intelligente Standardisierung von Metadaten
- ⚡ Null Latenz durch lokale Verarbeitung
- 🧩 Nahtlose Integration mit Adobe Premiere

## 🚀 Schnellstart

### Basis-Workflow

1. Klappenblatt-Aufzeichnung: Interaktives Klappenblatt mit DTG Slate erstellen
2. Datenmanagement: Klappenblatt-Daten mit Silverstack Lab importieren
3. Dateiexport: Adobe Premiere Pro XML generieren
4. Standardisierung: Intelligente Optimierung mit Double Love

Beispiel:
- Eingabe-xml: `UnitA_304_20250127.xml`
- Ausgabe-xml: `UnitA_304_20250127_Double_LOVE.xml`

### Detailliertes Beispiel

#### Dateinamen-Optimierung
- Das Programm verarbeitet automatisch das Format von Szenen-, Shot- und Take-Nummern
- Führende Nullen werden für Zahlen automatisch ergänzt
- Automatische Groß- und Kleinschreibungskorrektur
- Überflüssige Unterstriche werden automatisch entfernt

#### Clip-Namenskonvention

Der verarbeitete Clipname folgt dem Format:
```
{Projektpräfix}{Szene}_{Kameraeinstellung}_{Take}{Kamera}{Bewertung}
```

- `prefix`: Benutzerdefiniertes Präfix (optional)
- `scene`: Szenennummer (3-stellig, z. B. 001)
- `shot`: Kameraeinstellungsnummer (2-stellig, z. B. 01)
- `take`: Take-Nummer (2-stellig, z. B. 01)
- `camera`: Kamera-Kennzeichnung (Kleinbuchstabe, z. B. a)
- `Rating`: Bewertung (ok/kp/ng)

#### Bewertungsverarbeitung
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### DIT-Informationen
- Automatisches Hinzufügen der DIT-Info: 'DIT: 哆啦Ahua 🌱'
- Zum Entfernen bitte selbstständig deployen 😁😁

#### Beispiel für benutzerdefiniertes Präfix

1. Präfix auf "PROJECT_A_" setzen:
   - Eingabedatei: `A304C007_250123G3`
   - Ausgabedatei: `PROJECT_A_004_01_07a_kp`

2. Ohne Präfix:
   - Eingabedatei: `A304C007_250123G3`
   - Ausgabedatei: `004_01_07a_kp`

#### Beispiel für Sequenzauflösungseinstellungen

1. FHD-Auflösung (Standard):
   - Breite: 1920
   - Höhe: 1080   
2. DCI 2K-Auflösung (benutzerdefiniert):
   - Breite: 2048
   - Höhe: 1080   

#### Beispiel für Batch-Verarbeitung

1. Mehrere Dateien gleichzeitig hochladen:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. Nach der Verarbeitung erhalten Sie:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Technologiestack

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- PWA-Unterstützung

## 📦 Installation & Nutzung

1. Projekt klonen

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Abhängigkeiten installieren

```bash
npm install
```

3. Lokale Entwicklung

```bash
npm run dev
```

4. Projekt bauen

```bash
npm run build
```

## 🔒 Sicherheitshinweise

- Alle Dateioperationen werden lokal im Browser durchgeführt, kein Upload auf einen Server
- Maximale Dateigröße: 50 MB
- Es werden nur XML-Dateien unterstützt

## 🌈 Hinweise für Entwickler

### Projektstruktur

```
Double-Love/
├── src/
│   ├── components/     # React-Komponenten
│   ├── context/        # React Context
│   ├── utils/          # Hilfsfunktionen
│   ├── styles/         # Stylesheets
│   └── App.tsx         # Hauptanwendungskomponente
├── public/             # Statische Ressourcen
└── ...Konfigurationsdateien
```

## 📃 Lizenz

[MIT License](LICENSE)

## 🤝 Beitrag leisten

Issues und Pull Requests sind willkommen!

## 👨‍💻 Autor

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---