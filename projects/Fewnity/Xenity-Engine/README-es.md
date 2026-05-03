# Xenity Engine

Xenity Engine es un motor de juegos multiplataforma basado en GameObjects y Componentes para PlayStation Portable, PsVita, PS3 y Windows.

[Documentación de Scripting de Xenity](https://fewnity.github.io/Xenity-Engine/script_api_reference/scripting_api_reference.html)

Estoy planeando trabajar en un nuevo motor, para solucionar la mayoría de los grandes problemas de este motor.<br>
Así que probablemente no añadiré nuevas funciones a este motor.<br>
¡Pero las solicitudes de extracción siguen siendo bienvenidas, nuevas funciones, refactorización, corrección de errores, optimizaciones o mejora de documentación, todo es bueno para aceptar!
Si quieres mejorar el motor, aquí está la [lista TODO](https://github.com/Fewnity/Xenity-Engine/blob/crossplatform/TODO.md).

![image](https://github.com/Fewnity/Xenity-Engine/assets/39272935/df59e12e-b989-4b0d-93b1-4f95fac7c91f)

![gif](https://github.com/user-attachments/assets/7568e868-e41c-4495-bde7-56bb7b6bc54d)

¡[Ejemplos de juegos](https://fewnity.github.io/Xenity-Engine/game_project_samples/game_project_samples.html) disponibles para descargar!

### Plataformas soportadas:<br>
✔️ Soportado<br>
🚧 En progreso<br>

| Estado | Plataforma |
|-|-|
✔️ | Windows
✔️ | PlayStation Portable
✔️ | PlayStation Vita
✔️ | PlayStation 3
🚧 | Linux (La interfaz tiene algunos fallos, falta audio y sistema de compilación)

Características:

- [X] Básico 2D
- [X] Básico 3D
- [X] Audio 2D
- [ ] Audio 3D
- [X] Skyboxes
- [X] Escenas
- [ ] Animaciones
- [X] Física 3D
- [ ] Física 2D
- [X] Recarga en caliente de C++

> [!WARNING]
> El motor no es perfecto. Por lo tanto, puede que encuentres problemas durante el desarrollo del juego como:
> - Eliminar archivos Meta tendrá repercusiones en tu proyecto. Las variables que referencian esos archivos quedarán vacías.
> - Duplicar un archivo meta causará problemas, cada archivo meta tiene un ID de archivo único.
> - El audio funciona "bien" con 44100Hz pero en PS3 necesitas usar audio a 48000Hz.

> [!NOTE]
> Si quieres compilar un juego en el editor, debes configurar `Compiler path` en el menú `Engine Settings` (Ventana->Engine Settings).<br>
> `Compiler path` por defecto es `C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build`, cámbialo si tu instalación/versión de Visual Studio es diferente.<br>
> Puedes establecer la `PPSSPP location` para Construir y Ejecutar en compilaciones PSP.

## Cómo usar el editor
### Cómo jugar el juego en el editor
- Compila el juego en "Juego->Compilar Juego"
- Haz clic en el botón de reproducir
### Cómo construir el juego
- Abre el menú de Configuración de Compilación en "Archivo->Configuración de Compilación"
- Selecciona la plataforma
- Haz clic en construir
(Para PSP, PS3 y PsVita, necesitarás tener Docker Desktop instalado y configurado).

## Configuración de Docker
Docker Desktop es necesario para compilar juegos de PSP, PS3 y PsVita.<br>
Descarga Docker Desktop: https://www.docker.com/products/docker-desktop/

Luego finaliza la instalación de Docker en Xenity. Ve a "Ventana->Configuración de Docker", el proceso puede tardar varios minutos especialmente si tienes un ordenador lento o conexión a internet lenta. (El editor se congelará).

## Archivos compatibles
Imágenes: `.png .jpg .bmp, .tga`

Audio: `.wav .mp3` (Por favor usa audio a 44100Hz excepto en PS3, donde debes usar audio a 48000Hz)

Malla: `.obj .fbx`

Fuente: `.ttf`

## Cómo compilar el motor en Visual Studio
- Configura el proyecto `Xenity_Engine_Executable` como proyecto de inicio.
- Compilar la configuración de `Engine` y luego `Editor` para generar todos los archivos dll.

## Cómo funciona internamente el motor

Cuando se carga un proyecto/juego, el motor crea una lista de todos los archivos existentes. Cada archivo tiene un Id único.
Las clases que originalmente son un archivo como `Texture`, `Audio Clip`, `Mesh Data` y más, heredan de `File Reference` para tener un puntero a su archivo.

Algunas clases como `Component`, `GameObject`, `Vector3` y más, heredan de `Reflective`. Esto permite acceder a sus variables sin conocer la clase base. Esto es usado por el Inspector para ver y modificar datos y se utiliza para guardar/cargar sus datos en/de un archivo.

## Contacto
Si necesitas ayuda, puedes abrir un Issue o contactarme.

Correo: `fewnity@gmail.com`<br>
Discord: `fewnity`

## Licencia

El código de este repositorio está bajo la licencia MIT.

## SDKs para Consolas de Juegos

https://github.com/Fewnity/Xenity-Engine-SDK

## Librerías usadas
Stb (usado: stb_image 2.23 (versiones posteriores no funcionan en PSP), stb_image_resize 0.97, stb_image_write 1.16): https://github.com/nothings/stb

drmp3 v0.6.40 & drwav v0.13.17: https://github.com/mackron/dr_libs

JSON for Modern C++ v3.11.3: https://github.com/nlohmann/json

GLM (ligeramente modificado para PS2): https://github.com/g-truc/glm

Bullet 2.82 (ligeramente modificado para corregir compilación): https://code.google.com/archive/p/bullet/downloads

### Específico para Windows:
Assimp (79d451b): https://github.com/assimp/assimp/
<br>`cmake CMakeLists.txt -DASSIMP_BUILD_ZLIB=ON -DASSIMP_NO_EXPORT=ON -DASSIMP_BUILD_ALL_EXPORTERS_BY_DEFAULT=OFF -DASSIMP_BUILD_TESTS=OFF -DASSIMP_BUILD_ASSIMP_VIEW=OFF -DASSIMP_INJECT_DEBUG_POSTFIX=OFF -DASSIMP_INSTALL=OFF -DASSIMP_BUILD_ALL_IMPORTERS_BY_DEFAULT=OFF -DASSIMP_BUILD_OBJ_IMPORTER=ON -DASSIMP_BUILD_FBX_IMPORTER=ON -DCMAKE_BUILD_TYPE=Release`
`cmake --build . --config Release`

FreeType (v2.13.2): https://github.com/ubawurinna/freetype-windows-binaries/

Rama Docking de ImGui (1.91.8 WIP): https://github.com/ocornut/imgui

SDL (3.2): https://github.com/libsdl-org/SDL

Glad v2.0.8 (modo compatibilidad gl 4.6): https://gen.glad.sh/

### Específico para PsVita: 
VitaGL (029ddbe): (Compilado con la bandera HAVE_GLSL_SUPPORT=1 activada, NO_DEBUG=1 para lanzamiento y HAVE_SHARK_LOG=1 LOG_ERRORS=2 para depuración) https://github.com/Rinnegatamante/vitaGL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-03

---