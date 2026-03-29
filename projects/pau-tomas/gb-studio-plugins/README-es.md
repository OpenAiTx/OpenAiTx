# GB Studio 4.2 - Paquete de Plugins

Un conjunto de plugins experimentales para GB Studio 4.2. Úselos bajo su propio riesgo :)

> [!NOTA]
> Un puñado de plugins de eventos previamente disponibles ahora están obsoletos, ya que su funcionalidad forma parte de GB Studio. [Ver la lista a continuación](#plugins-obsoletos).

## Diálogo y Menús

### Dibujar Barra de Vida

Dibuja una barra (de vida/poder/mana) en una posición especificada sobre la superposición.

- `X`, `Y`: Coordenadas de mosaicos en la superposición.
- `Tileset`: Un conjunto de mosaicos que incluye los mosaicos para la barra en orden consecutivo.
- `Tile`: El primer mosaico de la barra en el conjunto de mosaicos (usualmente el mosaico vacío).
- `Value`: El valor actual que será representado por la barra.
- `Max Value`: El valor máximo que puede ser representado por la barra.
- `Steps`: El número de mosaicos necesarios para "llenar" un elemento en la barra (sin incluir el vacío).

[Proyecto de ejemplo](examples/Draw%20Lifebar/)

_Nota:_ El conjunto de mosaicos se cargará en el mosaico 128 de VRAM (justo después del bloque de sprites). Esto permite combinar el renderizado de la barra de vida con `Dibujar Texto` en la superposición. El índice de VRAM puede cambiarse editando la línea `const VRAM_BASE_START_TILE = 128` en el archivo del plugin.

<img width="300" alt="Dibujar Barra de Vida" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Draw Lifebar/screenshots/draw_lifebar.png"/>

<img width="300" alt="Dibujar Barra de Vida" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Draw Lifebar/screenshots/draw_lifebar_screenshot.png"/>

### Mostrar Menú Avanzado

Muestra un menú con múltiples opciones y asigna la variable especificada al valor de la opción elegida. La posición de la opción del menú y el orden de navegación pueden configurarse para cada elemento en la pestaña `Items`. Opcionalmente, se puede configurar el botón 'B' para cerrar el menú asignando a la variable el valor '0' y también se puede hacer que el último ítem del menú retorne '0' cuando se seleccione. El tamaño del cuadro de diálogo, la dirección de apertura y cierre, y la posición del menú (arriba o abajo) pueden configurarse en la pestaña `Layout`. La velocidad de apertura y cierre del menú puede ajustarse en la pestaña `Behavior`.

No hay un límite máximo de caracteres por ítem, pero el número total de caracteres mostrados está limitado por el número de mosaicos reservados para texto de interfaz (52 para modo sin color).

_Nota:_ El evento puede volverse muy largo cuando hay muchos ítems.

<img width="300" alt="Ítems de Menú Avanzado" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_items.png"/> <img width="300" alt="Captura de Menú Avanzado" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_screenshot.png"/>

<img width="300" alt="Diseño de Menú Avanzado" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_layout.png"/>

## Reloj en Tiempo Real

Un conjunto de eventos que proporcionan acceso a la funcionalidad del Reloj en Tiempo Real presente en algunos cartuchos de GB.

_Nota:_ El tipo de cartucho debe estar configurado en `MBC3` en la configuración del proyecto para que el RTC funcione.

### Establecer Hora del Reloj

Establece los valores de los campos del reloj en tiempo real a un número o al valor de una variable.

<img width="300" alt="Establecer Hora del Reloj" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/set_clock_time.png"/>

### Almacenar Hora del Reloj en Variables

Almacena la hora actual en una variable para cada valor.

<img width="300" alt="Almacenar Hora del Reloj en Variables" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/store_time_in_var.png"/>

### Iniciar Reloj

Inicia el reloj en tiempo real.

<img width="300" alt="Iniciar Reloj" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/start_clock.png"/>

### Detener Reloj

Detiene el reloj en tiempo real.

<img width="300" alt="Detener Reloj" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/stop_clock.png"/>

## Pantalla

### Fundido Suave

**Solo Modo Color**

Fundir algunas o todas las paletas de fondo o sprites de la escena actual hacia o desde una pantalla blanca o negra, interpolando los valores de color para un fundido suave.

<img width="300" alt="Actualización de Campo del Jugador" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Smooth Fade/screenshots/smooth_fade.png"/>

## Plugins β

Los plugins en esta categoría son aún más experimentales que los anteriores y podrían cambiar en el futuro.

- **Mover Actor Variable A** y **Almacenar Posición del Actor Variable n Variables**:
  - Estos eventos duplican eventos existentes de actores en GB Studio, pero en lugar de usar un menú desplegable para seleccionar el actor, usan una variable. El valor de la variable representa el índice del actor en la escena (el jugador siempre es `0`, y el resto de los actores tienen un índice asignado según cuándo fueron añadidos a la escena).

- **Fijar Actor a la Pantalla** y **Desfijar Actor de la Pantalla**:
  - Fija o desfija al actor en sus coordenadas actuales en pantalla.\nTen en cuenta el estado actual del actor: si ya está fijado o desfijado cuando se llama el evento, su posición se desplazará incorrectamente según la posición del desplazamiento.

## Cómo Instalar

Coloca la carpeta `plugins` dentro de tu proyecto. Todos los eventos anteriores estarán disponibles desde el botón `Agregar Evento`.

## Más plugins de otros autores:

- [Colección de Plugins de GB Studio de NalaFala (Yousurname)](https://github.com/Y0UR-U5ERNAME/gbs-plugin-collection)
- [Platformer+](https://github.com/becomingplural/GBS_PlatformerPlus)
- [Diálogo Avanzado y Menú vB](https://github.com/dochardware/Advanced-Dialog-and-Menu)
- [Plugins GB Studio de Shin](https://github.com/shin-gamedev/gbs-plugins)
- [Gud GBS Plugins](https://github.com/mikeleisz/gud_gbs_plugins)
- [Fade Street](https://gearfo.itch.io/fade-street)
- [Transición de Escena con Desplazamiento](https://github.com/Mico27/GBS-scrollScenePlugin) y más [plugins de Mico27](https://github.com/Mico27/)

## Eventos de Plugins Obsoletos

Los siguientes plugins de eventos ya no están disponibles como parte del paquete de plugins, ya que su funcionalidad ha sido añadida nativamente a GB Studio.

Desde la versión 4.2:

- Actualizar Campo del Jugador
- Almacenar Campo del Jugador en Variable
- Almacenar Campo de la Cámara en Variable

Desde la versión 4.1:

- Mostrar Diálogo Avanzado
- Mostrar Texto de Fondo
- Imprimir Fondo de Pantalla
- Silenciar Canal
- Actualización del Campo de Cámara
- Establecer Marco de Diálogo
- Efectos de Actor

Desde la 4.0:

- Grupo de Evento Bloqueado
- Grupo de Evento Desbloqueado


Si no estás usando GB Studio 4.2 o superior, aún puedes encontrar lo anterior [aquí](https://github.com/pau-tomas/gb-studio-plugins/tree/4.1). Para plugins compatibles con la 4.0, consulta [aquí](https://github.com/pau-tomas/gb-studio-plugins/tree/4.0)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---