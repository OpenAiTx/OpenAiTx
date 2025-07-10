<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Basketo Game Engine Logo" width="200"/>
</p>

<h2 align="center">Creëer, Speel, Inspireer. Games tot leven gebracht. ✨</h2>

<h1 align="center">Basketo Game Engine</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Vervang your_discord_server_id door je daadwerkelijke server-ID -->
[![GitHub sterren](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (voorheen Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Welkom bij de Basketo Engine - een passieproject waarin we ons uiterste best doen om een geweldige en krachtige engine te creëren, met het spannende plan om het een AI-Native game engine te maken. Met een editorinterface die lijkt op Unity, Gemini AI-integratie, een geavanceerd systeem voor meerdere geluidseffecten en een krachtige ECS-architectuur. Of je nu wilt bijdragen, ideeën wilt aandragen of gewoon wilt zien hoe het groeit, je bent onderdeel van de reis! 🚀
</p>
## 🚀 Huidige Status van de Engine
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Huidige Status van de Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>Bekijk de nieuwste ontwikkelingen en functies in actie!</em> 🎮
</p>

## ✨ Belangrijkste Functies

### 🎮 **Unity-achtige Editor Interface**
- **Dubbel venster-indeling**: Scene-editor en game-weergave naast elkaar
- **Live bewerken**: Pas scènes aan terwijl de game draait
- **Inspector-paneel**: Visueel componenten bewerken met drag-and-drop
- **Hiërarchie-weergave**: Organiseer en beheer entiteiten
- **Asset-browser**: Eenvoudig beheer van textures en audio

### 🤖 **AI-Natieve Ontwikkeling**
- **Gemini AI-integratie**: Natuurlijke taalcommando’s voor game-ontwikkeling
- **Slimme scriptgeneratie**: AI-aangedreven Lua-scriptcreatie
- **Entiteitswijziging**: Beschrijf veranderingen in gewoon Engels
- **Eenvoudige API-instelling**: Ingebouwde configuratie van Gemini API-sleutel
### 🔊 **Geavanceerd Audiosysteem**
- **Meerdere geluidseffecten**: Meerdere benoemde geluiden per entiteit (lopen, springen, aanvallen, enz.)
- **Traditionele audio**: Achtergrondmuziek en omgevingsgeluiden
- **Lua-integratie**: Geluiden triggeren vanuit scripts met `PlaySound(entity, "action")`
- **Visuele editor**: Geluidseffecten beheren via de inspector

### 🎯 **Entity-Component-System (ECS)**
- **Hoge prestaties**: Geoptimaliseerd voor grote aantallen entiteiten
- **Modulair ontwerp**: Componenten naar behoefte combineren
- **Scriptintegratie**: Lua-scripting met volledige ECS-toegang
- **Realtime updates**: Live componentbewerking

### 🎨 **Grafics & Animatie**
- **Sprite-rendering**: Efficiënte 2D-grafische pijplijn
- **Animatiesysteem**: Frame-gebaseerde animaties met herhaling
- **Transformatiesysteem**: Positie, rotatie en schaal
- **Camerasysteem**: Ondersteuning voor meerdere camera’s

### ⚡ **Fysica & Botsing**
- **Botsingsdetectie**: AABB-botsing met ruimtelijke optimalisatie
- **Rigidbody-fysica**: Zwaartekracht, snelheid en krachten
- **Botsingscallbacks**: Scripttoegankelijke botsingsgebeurtenissen
- **Ruimtelijke partitionering**: Quadtree-optimalisatie voor prestaties
## 🎬 Klik op de onderstaande afbeelding om een videodemonstratie te zien:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## � Snelstartgids

### 1. **Haal je Gemini API-sleutel** (Optioneel maar aanbevolen)
- Bezoek [Google AI Studio](https://aistudio.google.com/app/apikey)
- Log in en maak een gratis API-sleutel aan
- Hiermee worden AI-gestuurde functies zoals natuurlijke taalcommando’s mogelijk

### 2. **Bouwen en Uitvoeren**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **AI-functies configureren**
- Ga in de engine naar het AI Prompt-paneel (onderaan)
- Zoek naar "🤖 Gemini AI Configuratie"
- Voer je API-sleutel in en klik op "Opslaan"

### 4. **Begin met creëren**
- Probeer AI-commando’s: `"create a player at 100 200"`
- Voeg geluidseffecten toe aan entiteiten in de inspector
- Schrijf Lua-scripts of laat AI ze genereren
- Gebruik de dual-window editor voor live ontwikkeling

## �🛠️ Engine bouwen (Linux) 🐧

### Vereisten
- CMake 3.26.0 of hoger is vereist.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (voor AI-functies)
- nlohmann/json (inbegrepen als submodule)
- ImGui (inbegrepen als submodule)

### Build Stappen
```bash
# Clone de repository
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Uitvoeren
```bash
./BasketoGameEngine

```
Als je de fysica-test wilt uitvoeren:
```bash
./PhysicsTest

```

## 🛠️ De Engine Bouwen (Windows) 💻

### Vereisten

1. **Visual Studio 2022 (Community Edition of hoger)**  
   Installeer met de volgende workloads:
   - Desktopontwikkeling met C++
   - C++ CMake-tools voor Windows
   - Windows 10 of 11 SDK

2. **CMake** (meegeleverd met Visual Studio of te downloaden via https://cmake.org/download/)

3. **vcpkg** (gebruikt om afhankelijkheden te installeren)


---
### Vereiste afhankelijkheden installeren

```bash
# Open een Developer Command Prompt voor VS 2022 of PowerShell

# Clone vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Installeer vereiste bibliotheken
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Build Stappen
```bash
# Clone de Basketo repository
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# Configureren met CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/pad/naar/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# Vervang "C:/pad/naar/vcpkg" door het volledige pad naar jouw vcpkg-map

# Bouw de engine
cmake --build . --config Release
```

---

### Uitvoeren

```bash
# Vanuit de build/Release directory
```
./BasketoGameEngine.exe

# Om de physics-test uit te voeren
./PhysicsTest.exe
```

## 📚 Documentatie

### Kernfuncties
- **[Sound Effects Systeem](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: Complete gids voor multi-geluidseffecten
- **[Gemini API Setup](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: Stapsgewijze AI-configuratie
- **[Lua Scripting](assets/Scripts/)**: Voorbeeldscripts en API-referentie

### Voorbeeldgebruik

#### AI-Aangedreven Ontwikkeling
```bash
# Natuurlijke taalopdrachten
"maak een spelerkarakter aan op positie 100 200"
"voeg springgedrag toe aan de speler"
"laat de vijand sneller bewegen"

# Scriptgeneratie
gemini_script maak een platformer controller met dubbele sprong
```

#### Meerdere geluidseffecten
```lua
-- In je Lua-scripts
PlaySound(entity, "jump")    -- Speel spronggeluid af
PlaySound(entity, "walk")    -- Speel loopgeluid af
PlaySound(entity, "attack")  -- Speel aanvalsgeluid af

-- Controleer of geluid bestaat
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### Componentensysteem
- **Transform**: Positie, rotatie, schaal
- **Sprite**: Textuurrendering
- **Animatie**: Frame-gebaseerde animaties
- **Script**: Lua-gedragsscripts
- **Collider**: Fysieke botsing
- **Rigidbody**: Fysische simulatie
- **Audio**: Achtergrondmuziek
- **SoundEffects**: Meerdere benoemde geluiden
- **Camera**: Weergavebeheer

## 🤝 Doe mee

We houden van bijdragen uit onze community ❤️. Voor details over bijdragen of het project draaien voor ontwikkeling, bekijk onze [Bijdrage Richtlijnen](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md). <!-- Ervan uitgaande dat je dit bestand hebt -->

- 🐛 Een bug gevonden? Open een issue!
- ✨ Een gaaf idee voor een feature? Laat het ons weten!
- 💻 Wil je bijdragen? Fork, codeer, en maak een pull request!

Laten we samen deze engine bouwen en game-ontwikkeling leuk en gemakkelijk maken voor iedereen. 🌍

## 👥 Community
Welkom met een dikke knuffel 🤗. We zijn super enthousiast over community-bijdragen van alle soorten - of het nu gaat om code-verbeteringen 📝, documentatie-updates 📚, issue-rapportages 🐞, feature-verzoeken 💡, en discussies in onze Discord 🗣️.

Word lid van onze community hier:

- 👋 [Word lid van onze Discord-community](https://discord.gg/F3DswRMW)
- ⭐ [Geef ons een ster op GitHub](https://github.com/basketoengine/Basketo)

## 🙏 Steun ons:
We zijn constant aan het verbeteren, en er komen binnenkort meer functies en voorbeelden 🌟. Als je van dit project houdt, geef ons dan alsjeblieft een ster ⭐ op de GitHub-repo [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) om op de hoogte te blijven en ons te helpen groeien. 🌱

---

Veel plezier met coderen en games maken! 🎉🎮


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---