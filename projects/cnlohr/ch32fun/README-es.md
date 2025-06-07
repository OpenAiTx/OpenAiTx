# ch32fun

Un entorno de desarrollo de código abierto (herramientas, cabeceras, ejemplos) para el [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (y muchos otros chips dentro de la familia CH32V) con gcc-riscv64 que puede usarse en Windows (nativo), Linux y/o WSL. El CH32V003 es una pieza de 10 centavos con un núcleo RISC-V EC que funciona a 48MHz, tiene 16kB de flash y 2kB de RAM y un montón de periféricos. También está disponible en encapsulados SOP-8, QFN-20 y SOIC. Puedes obtener la hoja de datos [aquí](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html).

El objetivo de este proyecto es desarrollar las herramientas y el entorno para un uso eficiente del CH32V003. ¡Evita HALs complicados y libera el hardware! El EVT existente es masivo, y el entorno de desarrollo es pesado. Este proyecto evita específicamente el HAL y hace que puedas usar directamente el [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html). En contraste, blinky solo ocupa 500 bytes con ch32fun, arranca más rápido y es significativamente más simple en general.

ch32fun contiene:
1. Ejemplos usando ch32fun, pero no tantos como usando el HAL. La mayoría están centrados en el ch32v003, pero muchos de ellos son compatibles con otros procesadores.
2. "minichlink", que utiliza el WCH CH-Link con libusb, para uso multiplataforma.
   * Un programador STM32F042, el [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * Un programador ESP32S2, el [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * El programador oficial WCH Link-E.
   * Una interfaz basada en Arduino, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
   * Soporta depuración estilo gdbserver para uso con Visual Studio.
   * Soporta printf sobre un solo cable. (A unos 400kBaud)
3. Una copia extra de libgcc para que puedas usar cadenas de compilación risc-v inusuales, ubicada en `misc/libgcc.a`.
4. Una carpeta llamada "ch32fun" que contiene un solo archivo fuente y un archivo de cabecera auto-contenidos para compilar aplicaciones para el ch32v003.
5. En algunos sistemas, la capacidad de hacer "printf" de regreso a través de
6. Un bootloader de demostración.

## Soporte para otras familias

Actualmente, hay soporte experimental para ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 y ch32v307. GDB está mayormente probado en el 003, pero funciona, en un grado limitado, en los otros procesadores.

## Primeros pasos

Para instrucciones de instalación/configuración, consulta la [página wiki aquí](https://github.com/cnlohr/ch32fun/wiki/Installation)

## ¡Características!

### Un "printf" de depuración rápido sobre la interfaz de programación.

Y por rápido, me refiero a muy rápido. Típicamente alrededor de 36kBytes/seg.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Puedes probar el proyecto debugprintf, o llamar a SetupDebugPrintf(); y usar printf() libremente.

### ¡Soporte de depuración!

¡A través de gdbserver integrado en minichlink! Funciona con `gdb-multiarch` así como en Visual Studio Code.

## Compilación y Grabación

```
cd examples/blink
make
```

text = código, data = valores constantes e inicialización, bss = valores no inicializados.  
dec es la suma de los 3 y refleja el número de bytes en flash que ocupará el programa.

El .bin generado es utilizado por minichlink y el archivo .hex es compatible con la herramienta oficial de grabación WCH.

## VSCode +/- PlatformIO

Nota: PlatformIO se usa generalmente para CI en este repositorio. Aunque PlatformIO se puede usar para programar y depurar un proyecto ch32fun dentro de VSCode, también puedes hacerlo completamente sin PlatformIO: Para eso, consulta el [proyecto plantilla](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

Este proyecto puede ser compilado, subido y depurado con VSCode y la extensión PlatformIO. Simplemente clona y abre este proyecto en VSCode y ten la extensión PlatformIO instalada. Usa el [selector de entorno del proyecto](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) para seleccionar un ejemplo específico, como "blink".

Para crear un nuevo proyecto de firmware PlatformIO basado en ch32fun, simplemente utiliza el asistente "New Project" de [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) y establece "Framework" en "ch32v003fun". Hay [varios ejemplos](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

El comando equivalente de [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) sería
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Si deseas añadir tu código directamente al proyecto ch32fun, por favor expande los entornos disponibles en el `platformio.ini` [según las instrucciones](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53).

Ten en cuenta también que, cuando abres este proyecto en PlatformIO, puedes utilizar el [selector de entorno del proyecto](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) en la parte inferior de la barra de tareas de VSCode para seleccionar una carpeta de ejemplo específica. De lo contrario, "Build" por defecto compilará **todos** los ejemplos.

Consulta [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) para más detalles e instalación de la plataforma.

## clangd

Si el servidor de lenguaje C/C++ clangd no puede encontrar `ch32fun.h`, el ejemplo deberá ser limpiado con `make clean` y compilado una vez con `bear -- make build`, lo cual generará un `compile_commands.json`, que clangd utiliza para encontrar las rutas de inclusión especificadas en los makefiles.  
`make clangd` hace esto en un solo paso.  
`build_all_clangd.sh` en `build scripts` lo hace para todos los ejemplos.

## Referencia Rápida
 * **REQUERIDO** para programación/depuración: `SWIO` está en `PD1`. No reutilices PD1 para múltiples funciones.
 * **OPCIONAL** `NRST` está en `PD7`. No es necesario, por defecto es GPIO en algunas configuraciones.
 * **OPCIONAL** UART `TX` está en: `PD5`. Recomendamos usar SWIO para depuración `printf`.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## ¿Más ejemplos/proyectos?

Otras herramientas de terceros están añadiendo muchos ejemplos, etc. Consulta los siguientes repositorios para bibliotecas adicionales, etc.
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Soporte

Puedes abrir un ticket en github o unirte a mi Discord en el canal #ch32fun. Actualmente las invitaciones son privadas, así que solo envíame un mensaje @cnlohr para obtener un enlace de invitación. Mis mensajes privados están abiertos.

### Notas al pie/enlaces

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Manual de Depuración
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html Manual del Procesador
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Manual de Referencia Técnica
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Hoja de Datos
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Detalles de la ISA comprimida en este chip.
 * El CH32V003 tiene extensiones xv, puedes usar esta versión personalizada de rvcodec.js para trabajar con sus opcodes: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---