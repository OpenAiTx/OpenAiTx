# Polyrhythm Mania
Un juego que recrea fielmente el minijuego *Polyrhythm* de Rhythm Tengoku (リズム天国), con un 
editor de niveles incorporado y modos secundarios.

![Miniatura de Polyrhythm Mania](https://user-images.githubusercontent.com/6299069/144956042-654ff2b3-aeba-4486-810e-f26aa1b33bff.png)
![Miniatura del modo lateral Polyrhythm: Assemble](https://user-images.githubusercontent.com/6299069/140859874-0552bb9a-c6dc-460b-a4a2-e35f99648ea9.png)

[![Descargas](https://img.shields.io/github/downloads/chrislo27/PolyrhythmMania/total.svg)](https://github.com/chrislo27/PolyrhythmMania/releases/latest)
[![Licencia GitHub](https://img.shields.io/github/license/chrislo27/PolyrhythmMania.svg)](https://github.com/chrislo27/PolyrhythmMania/blob/dev/LICENSE.txt)
[![Donar al mantenedor del proyecto](https://img.shields.io/badge/Donate-PayPal-blue.svg?logo=paypal)](https://www.paypal.com/donate?hosted_button_id=9JLGHKZNWLLQ8)

[Banda sonora original en YouTube por GENERIC](https://www.youtube.com/playlist?list=PLt_3dgnFrUPwcA6SdTfi0RapEBdQV64v_)

## Características
* Recreación completa del minijuego Polyrhythm de Rhythm Tengoku, *¡y más!*
* Un completo *Modo Historia* con más de 40 niveles
* Ordena y organiza tus niveles personalizados usando la función Biblioteca
* Crea niveles personalizados con un editor de niveles incorporado e intuitivo
* Efectos de nivel como cambiar la paleta de colores, añadir cuadros de texto, poner Estrellas de Habilidad, y más
* Cambia entre texturas clásicas de GBA, modernas en HD y arcade, o añade tu propio paquete de texturas personalizado
* Modos de práctica para mejorar tus habilidades de Polyrhythm con niveles del juego original de GBA
* Modo Infinito que te mantiene alerta con patrones generados proceduralmente sin fin
* Modo Desafío Diario con una serie de patrones no vistos en el modo Infinito regular, con tablas de clasificación en línea
* Modos adicionales como _Polyrhythm: Dunk_, _Polyrhythm: Assemble_ y _Built to Scale: Solitaire_ añaden más diversión a Polyrhythm

[¡Mira el tráiler de la actualización v1.2 en YouTube!](https://www.youtube.com/watch?v=I4BXu7sNj-M)  
[¡Mira el tráiler de anuncio en YouTube!](https://www.youtube.com/watch?v=A3ZUBIy_MAQ)  
[¡Mira el tráiler de características de agosto 2021!](https://www.youtube.com/watch?v=k9PtPI1-tDo)  


## Requisitos del sistema para jugar
**Sistemas operativos oficialmente soportados:** Windows 10 o superior, Linux (x86-64 y ARM).

> macOS no está oficialmente soportado (es decir, no aceptamos reportes de errores desde macOS) pero puedes intentar ejecutarlo según [issue #29](https://github.com/chrislo27/PolyrhythmMania/issues/29).

**Especificaciones del sistema:** Se usan [requisitos similares a *Minecraft: Java Edition*](https://help.minecraft.net/hc/en-us/articles/4409225939853-Minecraft-Java-Edition-Installation-Issues-FAQ#h_01FFJMSQWJH31CH16H63GX4YKE),
ya que se utiliza la misma biblioteca gráfica subyacente (GLFW con OpenGL 4.4).

### Requisitos mínimos
* CPU: Intel Core i3-3210 3.2 GHz / AMD A8-7600 APU 3.1 GHz o equivalente
* RAM: 4GB  
* GPU (Integrada): Intel HD Graphics 4000 (Ivy Bridge) o AMD Radeon serie R5 (línea Kaveri) con OpenGL 4.4  
* GPU (Discreta): NVIDIA GeForce serie 400 o AMD Radeon HD serie 7000 con OpenGL 4.4  
* HDD: Al menos 1GB para el juego y niveles  
* SO: Windows 10 y superiores, distribuciones Linux de 64 bits desde 2018 en adelante  
* Pantalla: resolución 1280x720  

### Requisitos recomendados  
* CPU: Intel Core i5-4690 3.5GHz / AMD A10-7800 APU 3.5 GHz o equivalente  
* RAM: 8GB  
* GPU: NVIDIA GeForce serie 700 o AMD Radeon Rx serie 200 (excluyendo chipsets integrados) con OpenGL 4.5  
* HDD: 2GB (se recomienda SSD)  
* SO: Windows 10 y posteriores (64 bits), distribuciones Linux de 64 bits desde 2020 en adelante (p. ej. Ubuntu 20.04)  
* Pantalla: resolución 1920x1080  

## Instrucciones de instalación  
Estas instrucciones son las mismas si estás descargando el juego por primera vez o actualizando a una nueva versión.  
Asegúrate de cumplir con los requisitos del sistema mencionados arriba.  

__Windows (solo 64 bits, no requiere instalación de Java):__  
1. Navega a la [última versión aquí](https://github.com/chrislo27/PolyrhythmMania/releases/latest) en una nueva pestaña o ventana.  
2. Descarga la versión correcta del juego en la sección Assets llamada `PolyrhythmMania_VERSION_win64.zip`, donde VERSION es el nombre de la versión. **Fíjate en el "win64" en el nombre del archivo.** No descargues el "Código fuente".  
3. Busca el archivo zip descargado en el Explorador de archivos. Extrae el archivo zip: clic derecho sobre el archivo zip descargado, selecciona "Extraer todo..." y extrae el contenido en una carpeta.  
4. Abre la carpeta recién extraída y entra en la carpeta `PolyrhythmMania_win64`.  
5. Haz doble clic en el ejecutable `LaunchPolyrhythmMania.exe` para iniciar el juego. (No necesitas tener instalado el Entorno de Ejecución de Java, el juego incluye una copia.)  
6. Si Windows Defender muestra "Windows Defender SmartScreen impidió que se iniciara una aplicación no reconocida", puedes ignorarlo de forma segura haciendo clic en "Más información" y luego en "Ejecutar de todas formas".  

__Otras plataformas (o para usuarios avanzados que ya tienen Java instalado)__  
1. **(Requisito previo)** Asegúrate de tener instalado el Entorno de Ejecución de Java (JRE 17 recomendado, JRE 11 mínimo) y que sea accesible en tu ruta como el comando `java`.  
2. Navega a la [última versión aquí](https://github.com/chrislo27/PolyrhythmMania/releases/latest) en una nueva pestaña o ventana.  
3. Descarga la versión correcta del juego en la sección Assets llamada `PolyrhythmMania_VERSION.zip`, donde VERSION es el nombre de la versión. No descargues el "Código fuente".  
4. Extrae el archivo zip a una ubicación conocida.  
5. Abre el directorio recién extraído y entra en el directorio `PolyrhythmMania_platform_agnostic`.  
6. Ejecuta el script de lanzamiento apropiado: en Windows, haz doble clic en `play_windows.bat`. En Linux, ejecuta el archivo `play_linux.sh` (puede que necesites hacer `chmod +x play_linux.sh` primero).  
7. Si prefieres no usar un script de lanzamiento, puedes ejecutar `java -jar bin/PolyrhythmMania.jar` con tus configuraciones preferidas.  

## Instrucciones de compilación  
Estas instrucciones son para personas interesadas en editar el código fuente del juego.  

1. Asegúrate de tener instalado JDK 17 o superior.
2. `chmod +x gradlew`
3. `./gradlew :desktop:run`

## Otra información
Rhythm Heaven es propiedad intelectual de Nintendo.
Este programa **NO** está respaldado ni patrocinado de ninguna manera por Nintendo.
Todas las propiedades usadas de Nintendo (como nombres, audio, gráficos, etc.) en este software no tienen la intención de infringir maliciosamente derechos de marca registrada.
Todas las demás marcas y activos son propiedad de sus respectivos dueños.
Este es un proyecto comunitario y está disponible para que otros lo usen
de acuerdo con la [licencia GPL-3.0](LICENSE), sin cargo.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-31

---