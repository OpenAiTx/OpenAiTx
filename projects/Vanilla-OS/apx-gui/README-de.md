<div align="center">
    <img src="https://raw.githubusercontent.com/Vanilla-OS/apx-gui/main/data/icons/hicolor/scalable/apps/org.vanillaos.ApxGUI.svg" height="64">
    <h1>Apx GUI</h1>
    <p>Ein Frontend in GTK 4 und Libadwaita für Apx.</p>
    <br />

[![Translation Status][weblate-image]][weblate-url]

<img src="https://raw.githubusercontent.com/Vanilla-OS/apx-gui/main/data/screenshot.png">
</div>

[weblate-url]: <https://hosted.weblate.org/engage/vanilla-os/>
[weblate-image]: <https://hosted.weblate.org/widgets/vanilla-os/-/apx-gui/svg-badge.svg>

### Abhängigkeiten

#### Build-Abhängigkeiten

```bash
apt install -y build-essential meson libadwaita-1-dev \
               desktop-file-utils pkg-config libglib2.0-dev
```

#### Laufzeit-Abhängigkeiten

```bash
apt install -y python3 python3-gi \
               gir1.2-gtk-4.0 libadwaita-1-0 \
               gir1.2-vte-3.91 python3-yaml \
               python3-requests gettext
```

**APX Version 2.0+ erforderlich.**

### Build

```bash
meson setup build
ninja -C build
```

### Installation

```bash
sudo ninja -C build install
```

## Ausführen

```bash
apx-gui
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---