# lsfg-vk
¡Este proyecto trae la [Generación de Fotogramas de Lossless Scaling](https://store.steampowered.com/app/993090/Lossless_Scaling/) a Linux!
>[!NOTE]
> Este es un trabajo en progreso. Aunque la generación de fotogramas ha funcionado en algunos juegos, aún queda mucho por hacer. Por favor revisa la wiki para soporte (la wiki aún no está escrita)

## Compilación, Instalación y Ejecución

>[!CAUTION]
> Las instrucciones de compilación han cambiado recientemente. Por favor, revísalas.

Para compilar LSFG, asegúrate de tener los siguientes componentes instalados en tu sistema:
- Herramientas de compilación tradicionales (+ sed, git)
- Compilador Clang (este proyecto NO se compila fácilmente con GCC)
- Archivos de cabecera de Vulkan
- Sistema de construcción CMake
- Sistema de construcción Meson (para DXVK)
- Sistema de construcción Ninja (backend para CMake)

Compilar lsfg-vk es relativamente sencillo, ya que todo está perfectamente integrado en CMake:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
Esto instalará lsfg-vk en ~/.local/lib y ~/.local/share/vulkan.

A continuación, necesitarás descargar Lossless Scaling desde Steam. Cambia a la rama `legacy_2.13` o descarga el depot correspondiente.
Copia o toma nota de la ruta de "Lossless.dll" de los archivos del juego.

Finalmente, iniciemos un programa con la generación de fotogramas habilitada. Para este ejemplo, voy a usar `vkcube`:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Asegúrate de ajustar las rutas. Examinemos cada una:
- `LVK_INSTANCE_LAYERS`: Especifica aquí `VK_LAYER_LS_frame_generation`. Esto fuerza a cualquier aplicación Vulkan a cargar la capa lsfg-vk.
- `LSFG_DLL_PATH`: Aquí especificas el Lossless.dll que descargaste de Steam. lsfg-vk extraerá y traducirá los sombreadores desde aquí.
- `LSFG_MULTIPLIER`: Este es el multiplicador con el que deberías estar familiarizado. Especifica `2` para duplicar el framerate, etc.
- `VK_LAYER_PATH`: Si no instalaste en `~/.local` o `/usr`, debes especificar aquí la carpeta `explicit_layer.d`.

>[!WARNING]
> A diferencia de Windows, LSFG_MULTIPLIER está fuertemente limitado aquí (¡por el momento!). Si tu hardware puede crear 8 imágenes de swapchain, entonces al establecer LSFG_MULTIPLIER en 4 se ocupan 4 de ellas, dejando solo 4 para el juego. Si el juego solicita 5 o más, se bloqueará.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---