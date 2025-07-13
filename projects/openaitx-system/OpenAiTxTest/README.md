<p align="center">
    <img src="https://raw.githubusercontent.com/openaitx-system/OpenAiTxTest/main/readmeimgs/logo.png" alt="Basketo Game Engine Logo" width="200"/>
</p>

<h2 align="center">Create, Play, Inspire. Games Brought to Life. ✨</h2>

<h1 align="center">Basketo Game Engine</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Replace your_discord_server_id with your actual server ID -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (formerly Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Welcome to the Basketo Engine - a passion project where we are putting our best effort into creating an awesome and performant engine, with the exciting plan of making it an AI-Native game engine. Featuring Unity-like editor interface, Gemini AI integration, advanced multi-sound effects system, and powerful ECS architecture. Whether you’re here to contribute, suggest ideas, or just watch it grow, you’re part of the journey! 🚀
</p>

## 🚀 Current State of the Engine
<p align="center">
  <img src="https://raw.githubusercontent.com/openaitx-system/OpenAiTxTest/main/readmeimgs/image3.png" alt="Current State of Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>Check out the latest developments and features in action!</em> 🎮
</p>

## ✨ Key Features

### 🎮 **Unity-like Editor Interface**
- **Dual-window setup**: Scene editor and game view side by side
- **Live editing**: Modify scenes while game is running
- **Inspector panel**: Visual component editing with drag-and-drop
- **Hierarchy view**: Organize and manage entities
- **Asset browser**: Easy texture and audio management

### 🤖 **AI-Native Development**
- **Gemini AI Integration**: Natural language commands for game development
- **Smart script generation**: AI-powered Lua script creation
- **Entity modification**: Describe changes in plain English
- **Easy API setup**: Built-in Gemini API key configuration

### 🔊 **Advanced Audio System**
- **Multi-sound effects**: Multiple named sounds per entity (walk, jump, attack, etc.)
- **Traditional audio**: Background music and ambient sounds
- **Lua integration**: Trigger sounds from scripts with `PlaySound(entity, "action")`
- **Visual editor**: Manage sound effects through the inspector

### 🎯 **Entity-Component-System (ECS)**
- **High performance**: Optimized for large numbers of entities
- **Modular design**: Mix and match components as needed
- **Script integration**: Lua scripting with full ECS access
- **Real-time updates**: Live component editing

### 🎨 **Graphics & Animation**
- **Sprite rendering**: Efficient 2D graphics pipeline
- **Animation system**: Frame-based animations with looping
- **Transform system**: Position, rotation, and scaling
- **Camera system**: Multiple camera support

### ⚡ **Physics & Collision**
- **Collision detection**: AABB collision with spatial optimization
- **Rigidbody physics**: Gravity, velocity, and forces
- **Collision callbacks**: Script-accessible collision events
- **Spatial partitioning**: Quadtree optimization for performance

## 🎬 Click the image below to see a video demonstration:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/openaitx-system/OpenAiTxTest/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## � Quick Start Guide

### 1. **Get Your Gemini API Key** (Optional but Recommended)
- Visit [Google AI Studio](https://aistudio.google.com/app/apikey)
- Sign in and create a free API key
- This enables AI-powered features like natural language commands

### 2. **Build and Run**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```

### 3. **Configure AI Features**
- In the engine, go to the AI Prompt panel (bottom)
- Look for "🤖 Gemini AI Configuration"
- Enter your API key and click "Save"

### 4. **Start Creating**
- Try AI commands: `"create a player at 100 200"`
- Add sound effects to entities in the inspector
- Write Lua scripts or let AI generate them
- Use the dual-window editor for live development

## �🛠️ Building the Engine (Linux) 🐧

### Prerequisites
- CMake 3.26.0 or higher is required.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (for AI features)
- nlohmann/json (included as submodule)
- ImGui (included as submodule)

### Build Steps
```bash
# Clone the repository
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Running
```bash
./BasketoGameEngine

```

If you want to run the physics test:
```bash
./PhysicsTest

```

## 🛠️ Building the Engine (Windows) 💻

### Prerequisites

1. **Visual Studio 2022 (Community Edition or higher)**  
   Install with the following workloads:
   - Desktop development with C++
   - C++ CMake tools for Windows
   - Windows 10 or 11 SDK

2. **CMake** (included with Visual Studio or download from https://cmake.org/download/)

3. **vcpkg** (used to install dependencies)


---

### Install Dependencies

```bash
# Open a Developer Command Prompt for VS 2022 or PowerShell

# Clone vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Install required libraries
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Build Steps

```bash
# Clone the Basketo repository
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# Configure with CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# Replace "C:/path/to/vcpkg" with the full path to your vcpkg directory

# Build the engine
cmake --build . --config Release
```

---

### Running

```bash
# From the build/Release directory
./BasketoGameEngine.exe

# To run the physics test
./PhysicsTest.exe
```

## 📚 Documentation

### Core Features
- **[Sound Effects System](https://raw.githubusercontent.com/openaitx-system/OpenAiTxTest/main/docs/SoundEffectsSystem.md)**: Complete guide to multi-sound effects
- **[Gemini API Setup](https://raw.githubusercontent.com/openaitx-system/OpenAiTxTest/main/docs/GeminiAPIKeySetup.md)**: Step-by-step AI configuration
- **[Lua Scripting](assets/Scripts/)**: Example scripts and API reference

### Example Usage

#### AI-Powered Development
```bash
# Natural language commands
"create a player character at position 100 200"
"add jumping behavior to the player"
"make the enemy move faster"

# Script generation
gemini_script create a platformer controller with double jump
```

#### Multi-Sound Effects
```lua
-- In your Lua scripts
PlaySound(entity, "jump")    -- Play jump sound
PlaySound(entity, "walk")    -- Play walking sound
PlaySound(entity, "attack")  -- Play attack sound

-- Check if sound exists
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### Component System
- **Transform**: Position, rotation, scale
- **Sprite**: Texture rendering
- **Animation**: Frame-based animations
- **Script**: Lua behavior scripts
- **Collider**: Physics collision
- **Rigidbody**: Physics simulation
- **Audio**: Background music
- **SoundEffects**: Multiple named sounds
- **Camera**: View management

## 🤝 Get Involved

We love contributions from our community ❤️. For details on contributing or running the project for development, check out our [Contribution Guidelines](https://raw.githubusercontent.com/openaitx-system/OpenAiTxTest/main/ContributionGuidline.md). <!-- Assuming you have this file -->

- 🐛 Found a bug? Open an issue!
- ✨ Have a cool feature idea? Let’s hear it!
- 💻 Want to contribute? Fork, code, and create a pull request!

Let’s build this engine together and make game dev fun and easy for everyone. 🌍

## 👥 Community
Welcome with a huge hug 🤗. We are super excited for community contributions of all kinds - whether it's code improvements 📝, documentation updates 📚, issue reports 🐞, feature requests 💡, and discussions in our Discord 🗣️.

Join our community here:

- 👋 [Join our Discord community](https://discord.gg/F3DswRMW)
- ⭐ [Star us on GitHub](https://github.com/basketoengine/Basketo)

## 🙏 Support us:
We are constantly improving, and more features and examples are coming soon 🌟. If you love this project, please drop us a star ⭐ at GitHub repo [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) to stay tuned and help us grow. 🌱

---

Happy coding and game making! 🎉🎮


