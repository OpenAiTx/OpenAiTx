<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Basketo Game Engine Logo" width="200"/>
</p>

<h2 align="center">Erstellen, Spielen, Inspirieren. Spiele zum Leben erweckt. ✨</h2>

<h1 align="center">Basketo Game Engine</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Ersetzen Sie your_discord_server_id durch Ihre tatsächliche Server-ID -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (vormals Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Willkommen bei der Basketo Engine – ein Herzensprojekt, bei dem wir unser Bestes geben, um eine großartige und leistungsstarke Engine zu entwickeln, mit dem spannenden Plan, sie zu einer AI-nativen Game Engine zu machen. Mit Unity-ähnlicher Editor-Oberfläche, Gemini AI-Integration, fortschrittlichem Multi-Soundeffekt-System und leistungsfähiger ECS-Architektur. Egal ob du beitragen, Ideen vorschlagen oder einfach nur das Wachstum beobachten möchtest – du bist Teil dieser Reise! 🚀
</p>
## 🚀 Aktueller Stand der Engine
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Aktueller Stand der Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>Entdecken Sie die neuesten Entwicklungen und Funktionen in Aktion!</em> 🎮
</p>

## ✨ Hauptfunktionen

### 🎮 **Unity-ähnliche Editor-Oberfläche**
- **Dual-Fenster-Setup**: Szeneneditor und Spielansicht nebeneinander
- **Live-Bearbeitung**: Szenen während des laufenden Spiels bearbeiten
- **Inspektor-Panel**: Visuelle Komponentenbearbeitung per Drag-and-Drop
- **Hierarchieansicht**: Organisieren und Verwalten von Entitäten
- **Asset-Browser**: Einfache Verwaltung von Texturen und Audio

### 🤖 **KI-native Entwicklung**
- **Gemini KI-Integration**: Sprachbefehle für die Spieleentwicklung
- **Intelligente Skripterstellung**: KI-gestützte Lua-Skriptgenerierung
- **Entitätsänderung**: Änderungen in einfachem Englisch beschreiben
- **Einfache API-Einrichtung**: Integrierte Gemini API-Schlüssel-Konfiguration
### 🔊 **Erweitertes Audiosystem**
- **Mehrfache Soundeffekte**: Mehrere benannte Sounds pro Entität (Gehen, Springen, Angriff usw.)
- **Traditionelles Audio**: Hintergrundmusik und Umgebungsgeräusche
- **Lua-Integration**: Auslösen von Sounds aus Skripten mit `PlaySound(entity, "action")`
- **Visueller Editor**: Verwaltung von Soundeffekten über den Inspektor

### 🎯 **Entity-Component-System (ECS)**
- **Hohe Leistung**: Optimiert für große Mengen an Entitäten
- **Modulares Design**: Komponenten nach Bedarf kombinieren
- **Skriptintegration**: Lua-Skripting mit vollem ECS-Zugriff
- **Echtzeit-Updates**: Live-Bearbeitung von Komponenten

### 🎨 **Grafik & Animation**
- **Sprite-Rendering**: Effiziente 2D-Grafikpipeline
- **Animationssystem**: Framebasierte Animationen mit Schleifenfunktion
- **Transforms-System**: Position, Rotation und Skalierung
- **Kamerasystem**: Unterstützung mehrerer Kameras

### ⚡ **Physik & Kollision**
- **Kollisionserkennung**: AABB-Kollision mit räumlicher Optimierung
- **Rigidbody-Physik**: Schwerkraft, Geschwindigkeit und Kräfte
- **Kollisions-Callbacks**: Skriptzugängliche Kollisionsereignisse
- **Räumliche Unterteilung**: Quadtree-Optimierung für Leistung
## 🎬 Klicken Sie auf das Bild unten, um eine Videodemonstration zu sehen:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## � Schnellstart-Anleitung

### 1. **Holen Sie sich Ihren Gemini API-Schlüssel** (Optional, aber empfohlen)
- Besuchen Sie [Google AI Studio](https://aistudio.google.com/app/apikey)
- Melden Sie sich an und erstellen Sie einen kostenlosen API-Schlüssel
- Dies ermöglicht KI-gestützte Funktionen wie natürliche Sprachbefehle

### 2. **Bauen und Ausführen**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **KI-Funktionen konfigurieren**
- Gehe im Engine-Fenster zum KI-Prompt-Panel (unten)
- Suche nach „🤖 Gemini KI-Konfiguration“
- Gib deinen API-Schlüssel ein und klicke auf „Speichern“

### 4. **Erste Schritte beim Erstellen**
- Probiere KI-Befehle aus: `"create a player at 100 200"`
- Füge Entitäten im Inspektor Soundeffekte hinzu
- Schreibe Lua-Skripte oder lasse sie von der KI generieren
- Nutze den Dual-Window-Editor für Live-Entwicklung

## �🛠️ Engine kompilieren (Linux) 🐧

### Voraussetzungen
- CMake 3.26.0 oder neuer ist erforderlich.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (für KI-Funktionen)
- nlohmann/json (als Submodul enthalten)
- ImGui (als Submodul enthalten)

### Build-Schritte
```bash
# Repository klonen
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Ausführen
```bash
./BasketoGameEngine

```
Wenn Sie den Physiktest ausführen möchten:
```bash
./PhysicsTest

```

## 🛠️ Kompilieren der Engine (Windows) 💻

### Voraussetzungen

1. **Visual Studio 2022 (Community Edition oder höher)**  
   Installieren Sie die folgenden Workloads:
   - Desktopentwicklung mit C++
   - C++ CMake-Tools für Windows
   - Windows 10 oder 11 SDK

2. **CMake** (in Visual Studio enthalten oder unter https://cmake.org/download/ herunterladen)

3. **vcpkg** (wird zur Installation von Abhängigkeiten verwendet)


---
### Abhängigkeiten installieren

```bash
# Öffnen Sie eine Entwickler-Eingabeaufforderung für VS 2022 oder PowerShell

# vcpkg klonen

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Erforderliche Bibliotheken installieren
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Bauschritte
```bash
# Klonen Sie das Basketo-Repository
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# Konfigurieren mit CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/Pfad/zu/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# Ersetzen Sie "C:/Pfad/zu/vcpkg" durch den vollständigen Pfad zu Ihrem vcpkg-Verzeichnis

# Bauen Sie die Engine
cmake --build . --config Release
```

---

### Ausführen

```bash
# Aus dem build/Release-Verzeichnis
```
./BasketoGameEngine.exe

# Um den Physik-Test auszuführen
./PhysicsTest.exe
```

## 📚 Dokumentation

### Kernfunktionen
- **[Soundeffekte-System](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: Vollständige Anleitung für Multi-Soundeffekte
- **[Gemini API Einrichtung](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: Schritt-für-Schritt KI-Konfiguration
- **[Lua-Skripting](assets/Scripts/)**: Beispielskripte und API-Referenz

### Beispielhafte Nutzung

#### KI-gestützte Entwicklung
```bash
# Befehle in natürlicher Sprache
"erstelle eine Spielerfigur an Position 100 200"
"füge dem Spieler Sprungverhalten hinzu"
"lasse den Gegner schneller bewegen"

# Skripterstellung
gemini_script erstelle einen Platformer-Controller mit Doppelsprung
```

#### Mehrfache Soundeffekte
```lua
-- In deinen Lua-Skripten
PlaySound(entity, "jump")    -- Spring-Sound abspielen
PlaySound(entity, "walk")    -- Lauf-Sound abspielen
PlaySound(entity, "attack")  -- Angriffs-Sound abspielen

-- Prüfen, ob Sound existiert
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### Komponenten-System
- **Transform**: Position, Rotation, Skalierung
- **Sprite**: Textur-Rendering
- **Animation**: Framebasierte Animationen
- **Script**: Lua-Verhaltensskripte
- **Collider**: Physikalische Kollision
- **Rigidbody**: Physik-Simulation
- **Audio**: Hintergrundmusik
- **SoundEffects**: Mehrere benannte Sounds
- **Camera**: Sichtverwaltung
## 🤝 Mitmachen

Wir freuen uns über Beiträge aus unserer Community ❤️. Für Details zum Mitwirken oder zum Ausführen des Projekts für die Entwicklung, wirf einen Blick auf unsere [Beitragsrichtlinien](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md). <!-- Assuming you have this file -->

- 🐛 Einen Fehler gefunden? Eröffne ein Issue!
- ✨ Hast du eine coole Feature-Idee? Lass sie uns wissen!
- 💻 Möchtest du beitragen? Forken, coden und einen Pull Request erstellen!

Lasst uns diese Engine gemeinsam entwickeln und Game Development für alle spaßig und einfach machen. 🌍

## 👥 Community
Herzlich willkommen mit einer riesigen Umarmung 🤗. Wir freuen uns riesig über alle Arten von Community-Beiträgen – egal ob Code-Verbesserungen 📝, Aktualisierungen der Dokumentation 📚, Fehlerberichte 🐞, Feature-Anfragen 💡 oder Diskussionen in unserem Discord 🗣️.

Tritt hier unserer Community bei:

- 👋 [Tritt unserer Discord-Community bei](https://discord.gg/F3DswRMW)
- ⭐ [Gib uns einen Stern auf GitHub](https://github.com/basketoengine/Basketo)

## 🙏 Unterstütze uns:
Wir verbessern uns ständig und weitere Funktionen sowie Beispiele sind bald verfügbar 🌟. Wenn dir dieses Projekt gefällt, gib uns bitte einen Stern ⭐ im GitHub-Repository [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo), um auf dem Laufenden zu bleiben und uns beim Wachsen zu helfen. 🌱

---

Viel Spaß beim Coden und Spiele entwickeln! 🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---