## Jubler - Subtitle Editor

![GitHub release (latest by date)](https://img.shields.io/github/v/release/teras/Jubler)
![GitHub all releases](https://img.shields.io/github/downloads/teras/Jubler/total)
![GitHub](https://img.shields.io/github/license/teras/Jubler?v=2)
![Java](https://img.shields.io/badge/Java-8+-orange)
![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS%20%7C%20Windows-blue)
![GitHub Release Date](https://img.shields.io/github/release-date/teras/Jubler)

Jubler is a free and open source subtitle editor for creating, editing, and converting text-based subtitles. Written in Java for cross-platform compatibility, it provides tools for authoring new subtitles and refining existing ones with video preview, quality validation, and extensive format support.

(C) 2005-2025 Panayotis Katsaloulis
panayotis@panayotis.com

Licensed under the GNU Affero General Public License v3 (AGPL-3.0)

---

## Features

### Subtitle Formats
- **20+ formats supported** including SubRip (SRT), Advanced SubStation Alpha (ASS/SSA), WebVTT, MicroDVD, SubViewer, MPL2, Spruce DVD Maestro, TTML, ITT, DFXP, and YouTube subtitles
- **Universal encoding support** (UTF-8, UTF-16, and all Java platform encodings)
- **Character and paragraph-level styling** for formats that support it (ASS/SSA, SRT)
- **Format conversion** between all supported types

### Video Integration
- **FFmpeg integration** for frame preview and audio waveform visualization
- **MPlayer support** for video playback
- **Real-time subtitle editing** while watching video
- **Interactive timeline** with draggable subtitle blocks
- **Two-point synchronization** for timing alignment
- **Enhanced preview controls** with shift/alt key support and snapping

### Editing Tools
- **Time manipulation** - shift, frame rate conversion, round timing
- **Content operations** - split/join entries, split/join files
- **Text processing** - spell checker, find & replace with regex support
- **Smart time fixer** with overlap detection and resolution
- **Translation mode** for side-by-side subtitle translation
- **Undo/redo** with full history
- **Auto-save and recovery**

### Quality Control
- **Subtitle validation** with configurable quality rules
- **CPS (characters-per-second) metrics** displayed in subtitle table
- **TED guidelines compliance** checking
- **Color-coded validation** to highlight issues
- **Statistics and analysis** tools

### User Interface
- **HiDPI support** with adjustable scaling
- **Dark theme** available
- **Customizable keyboard shortcuts**
- **Multi-language interface** with i18n support
- **Color marking** for organizing subtitle groups

### Automation
- **Command-line tools** for batch processing
- **Plugin system** for extensibility
- **External tool integration**
- **Azure Translator support** for automated translation

---

## Getting Started

### Requirements
- Java 8 or higher (often bundled with distribution)
- Optional: MPlayer for video preview
- Optional: ASpell for spell checking

### Installation

Download binaries from the [releases page](https://github.com/teras/Jubler/releases):
- Windows, macOS, and Linux installers
- Linux AppImage
- Generic cross-platform package

Or build from source (see [BUILD_AND_RUN.md](https://raw.githubusercontent.com/teras/Jubler/master/BUILD_AND_RUN.md))

### Running

Launch from your application menu or desktop shortcut. You can also run manually:
```bash
java -jar Jubler.jar
```

---

## Contributing

Jubler is an open source project that welcomes contributions. Whether you're fixing bugs, adding features, improving documentation, or translating the interface, your help is appreciated.

---

## Credits

Free code signing on Windows provided by [SignPath.io](https://signpath.io/), certificate by [SignPath Foundation](https://signpath.org/)

