<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Logotipo del Motor de Juegos Basketo" width="200"/>
</p>

<h2 align="center">Crea, Juega, Inspira. Juegos que Cobran Vida. ✨</h2>

<h1 align="center">Motor de Juegos Basketo</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Reemplaza your_discord_server_id con el ID real de tu servidor -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (formerly Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Bienvenido al Motor Basketo: un proyecto de pasión donde estamos poniendo nuestro mejor esfuerzo en crear un motor increíble y de alto rendimiento, con el emocionante plan de convertirlo en un motor de juegos Nativo de IA. Cuenta con una interfaz de editor similar a Unity, integración con Gemini AI, un sistema avanzado de efectos de sonido múltiples y una potente arquitectura ECS. Ya sea que estés aquí para contribuir, sugerir ideas o simplemente observar su crecimiento, ¡eres parte del viaje! 🚀
</p>
## 🚀 Estado Actual del Motor
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Estado Actual del Motor Basketo" width="700"/>
</p>

<p align="center">
  <em>¡Descubre las últimas novedades y características en acción!</em> 🎮
</p>

## ✨ Características Clave

### 🎮 **Interfaz del Editor Similar a Unity**
- **Configuración de doble ventana**: Editor de escenas y vista del juego lado a lado
- **Edición en vivo**: Modifica escenas mientras el juego se está ejecutando
- **Panel de inspector**: Edición visual de componentes con arrastrar y soltar
- **Vista de jerarquía**: Organiza y administra entidades
- **Explorador de recursos**: Gestión sencilla de texturas y audio

### 🤖 **Desarrollo Nativo con IA**
- **Integración con Gemini AI**: Comandos en lenguaje natural para desarrollo de juegos
- **Generación inteligente de scripts**: Creación de scripts Lua impulsada por IA
- **Modificación de entidades**: Describe cambios en inglés sencillo
- **Configuración fácil de API**: Configuración integrada de la clave API de Gemini
### 🔊 **Sistema de Audio Avanzado**
- **Efectos de sonido múltiples**: Varios sonidos nombrados por entidad (caminar, saltar, atacar, etc.)
- **Audio tradicional**: Música de fondo y sonidos ambientales
- **Integración con Lua**: Dispara sonidos desde scripts con `PlaySound(entity, "action")`
- **Editor visual**: Gestiona efectos de sonido a través del inspector

### 🎯 **Entidad-Componente-Sistema (ECS)**
- **Alto rendimiento**: Optimizado para grandes cantidades de entidades
- **Diseño modular**: Combina y mezcla componentes según sea necesario
- **Integración con scripts**: Scripting en Lua con acceso completo a ECS
- **Actualizaciones en tiempo real**: Edición en vivo de componentes

### 🎨 **Gráficos y Animación**
- **Renderizado de sprites**: Canal de gráficos 2D eficiente
- **Sistema de animación**: Animaciones basadas en cuadros con bucle
- **Sistema de transformaciones**: Posición, rotación y escalado
- **Sistema de cámaras**: Soporte para múltiples cámaras

### ⚡ **Física y Colisiones**
- **Detección de colisiones**: Colisiones AABB con optimización espacial
- **Física de cuerpo rígido**: Gravedad, velocidad y fuerzas
- **Callbacks de colisión**: Eventos de colisión accesibles desde scripts
- **Particionamiento espacial**: Optimización con quadtree para rendimiento
## 🎬 Haz clic en la imagen de abajo para ver una demostración en video:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Demostración del Motor Basketo" width="500"/>
  </a>
</p>

## � Guía de Inicio Rápido

### 1. **Obtén tu clave API de Gemini** (Opcional pero recomendado)
- Visita [Google AI Studio](https://aistudio.google.com/app/apikey)
- Inicia sesión y crea una clave API gratuita
- Esto habilita funciones potenciadas por IA, como comandos en lenguaje natural

### 2. **Construye y ejecuta**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **Configurar Funciones de IA**
- En el motor, ve al panel de IA Prompt (parte inferior)
- Busca "🤖 Gemini AI Configuration"
- Ingresa tu clave API y haz clic en "Guardar"

### 4. **Comienza a Crear**
- Prueba comandos de IA: `"create a player at 100 200"`
- Agrega efectos de sonido a las entidades en el inspector
- Escribe scripts en Lua o deja que la IA los genere
- Usa el editor de doble ventana para desarrollo en vivo

## 🛠️ Compilar el Motor (Linux) 🐧

### Prerrequisitos
- Se requiere CMake 3.26.0 o superior.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (para funciones de IA)
- nlohmann/json (incluido como submódulo)
- ImGui (incluido como submódulo)

### Pasos de compilación
```bash
# Clonar el repositorio
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Ejecución
```bash
./BasketoGameEngine

```
Si desea ejecutar la prueba de física:
```bash
./PhysicsTest

```

## 🛠️ Compilando el Motor (Windows) 💻

### Prerrequisitos

1. **Visual Studio 2022 (Edición Community o superior)**  
   Instale con las siguientes cargas de trabajo:
   - Desarrollo de escritorio con C++
   - Herramientas CMake para C++ en Windows
   - SDK de Windows 10 o 11

2. **CMake** (incluido con Visual Studio o descargue desde https://cmake.org/download/)

3. **vcpkg** (usado para instalar dependencias)


---
### Instalar dependencias

```bash
# Abra un Símbolo del sistema para desarrolladores de VS 2022 o PowerShell

# Clonar vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Instalar las bibliotecas requeridas
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Pasos de compilación
```bash
# Clonar el repositorio de Basketo
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# Configurar con CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/ruta/a/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# Reemplaza "C:/ruta/a/vcpkg" con la ruta completa a tu directorio de vcpkg

# Compilar el motor
cmake --build . --config Release
```

---

### Ejecución

```bash
# Desde el directorio build/Release
```
./BasketoGameEngine.exe

# Para ejecutar la prueba de física
./PhysicsTest.exe
```

## 📚 Documentación

### Características principales
- **[Sistema de Efectos de Sonido](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: Guía completa para efectos de sonido múltiples
- **[Configuración de la API Gemini](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: Configuración de IA paso a paso
- **[Scripting en Lua](assets/Scripts/)**: Scripts de ejemplo y referencia de la API

### Ejemplo de uso

#### Desarrollo impulsado por IA
```bash
# Comandos en lenguaje natural
"crear un personaje jugador en la posición 100 200"
"agregar comportamiento de salto al jugador"
"hacer que el enemigo se mueva más rápido"

# Generación de Scripts
gemini_script crea un controlador de plataformas con doble salto
```

#### Efectos de Sonido Múltiples
```lua
-- En tus scripts Lua
PlaySound(entity, "jump")    -- Reproducir sonido de salto
PlaySound(entity, "walk")    -- Reproducir sonido de caminar
PlaySound(entity, "attack")  -- Reproducir sonido de ataque

-- Comprobar si el sonido existe
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### Sistema de Componentes
- **Transform**: Posición, rotación, escala
- **Sprite**: Renderizado de texturas
- **Animation**: Animaciones basadas en cuadros
- **Script**: Scripts de comportamiento en Lua
- **Collider**: Colisión física
- **Rigidbody**: Simulación física
- **Audio**: Música de fondo
- **SoundEffects**: Múltiples sonidos nombrados
- **Camera**: Gestión de la vista
## 🤝 Participa

Nos encantan las contribuciones de nuestra comunidad ❤️. Para obtener detalles sobre cómo contribuir o ejecutar el proyecto para desarrollo, consulta nuestras [Directrices de Contribución](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md). <!-- Suponiendo que tienes este archivo -->

- 🐛 ¿Encontraste un error? ¡Abre un issue!
- ✨ ¿Tienes una idea genial para una función? ¡Queremos saberla!
- 💻 ¿Quieres contribuir? Haz un fork, programa y crea un pull request.

Construyamos este motor juntos y hagamos que el desarrollo de juegos sea divertido y fácil para todos. 🌍

## 👥 Comunidad
¡Bienvenido con un gran abrazo 🤗! Estamos muy emocionados por las contribuciones de la comunidad de todo tipo, ya sea mejoras de código 📝, actualizaciones de documentación 📚, reportes de errores 🐞, solicitudes de funciones 💡, y discusiones en nuestro Discord 🗣️.

Únete a nuestra comunidad aquí:

- 👋 [Únete a nuestra comunidad en Discord](https://discord.gg/F3DswRMW)
- ⭐ [Dános una estrella en GitHub](https://github.com/basketoengine/Basketo)

## 🙏 Apóyanos:
Estamos mejorando constantemente, y pronto llegarán más funciones y ejemplos 🌟. Si te gusta este proyecto, por favor déjanos una estrella ⭐ en el repositorio de GitHub [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) para mantenerte al tanto y ayudarnos a crecer. 🌱

---

¡Feliz programación y creación de juegos! 🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---