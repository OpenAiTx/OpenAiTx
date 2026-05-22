# DisableCtrlClick para macOS

<p align="center">
  <img src="https://raw.githubusercontent.com/achendev/DisableCtrlClick/master/DisableCtrlClick.png" alt="Icono de la aplicación" width="128">
</p>

<p align="center">
  <a href="https://github.com/achendev/DisableCtrlClick/releases">
    <img src="https://img.shields.io/github/downloads/achendev/DisableCtrlClick/total.svg" alt="Descargas totales">
  </a>
  <a href="https://github.com/achendev/DisableCtrlClick">
    <img src="https://img.shields.io/github/stars/achendev/DisableCtrlClick?style=social" alt="Estrella en GitHub">
  </a>
</p>

¿Estás cansado de abrir accidentalmente el menú contextual cuando solo quieres usar la tecla Control? Yo también.

Muchas aplicaciones, especialmente en programación, diseño y juegos, usan `Control` como modificador para acciones principales. Si estás acostumbrado a un toque con dos dedos o a un botón dedicado del ratón para hacer clic derecho, el comportamiento predeterminado de `Ctrl-Clic` puede ser una interrupción molesta. Esta app lo soluciona.

## Qué Hace

Esta es una pequeña utilidad nativa de macOS que vive en tu barra de menús y hace una cosa: fuerza que **`Control + Clic Izquierdo`** se comporte como un **`Clic Izquierdo`** normal, deshabilitando el comportamiento predeterminado de clic derecho/menú contextual.

Eso es todo. No más clics derechos aleatorios.

## Características

*   ✅ **Ligero y Nativo:** Una app sencilla en Swift con uso mínimo de recursos.
*   ✅ **Configurable desde la Barra de Menús:** Haz clic en el icono para desactivar temporalmente la funcionalidad, alternar "Abrir al iniciar sesión" o salir de la app.
*   ✅ **App de Barra de Menús:** Vive discretamente en tu barra de menús. Cmd+Arrastrar para ocultarla, y lanza la app nuevamente para mostrarla.
*   ✅ **Arranque al Iniciar Sesión (Opcional):** Se inicia automáticamente al iniciar sesión. Esto puede activarse o desactivarse desde el menú de la app.
*   ✅ **Cero Configuración:** Solo ejecútala y concede permisos. Eso es todo.
*   ✅ **Moderna y Segura:** Construida con APIs modernas y no requiere privilegios especiales más allá de lo necesario para funcionar.
*   ✅ **Transparente y Pequeña:** Es tan pequeña que puedes literalmente leer todo el código de la app o dárselo a cualquier IA para entender exactamente qué hace y qué estás ejecutando en tu Mac.



## Instalación y Uso

1.  **Descarga:** Ve a la [**página de Releases**](https://github.com/achendev/DisableCtrlClick/releases) y descarga el último `DisableCtrlClick.dmg`.
2.  **Instalar:** Abra el archivo y arrastre `DisableCtrlClick.app` a su carpeta `/Applications`.
3.  **Lanzar:** Abra la aplicación desde su carpeta de Aplicaciones.
4.  **Conceder permisos:** En el primer lanzamiento, la aplicación le pedirá que conceda permisos y luego se cerrará. Debe habilitar **Accesibilidad** y **Monitoreo de entrada** para `DisableCtrlClick` en:
    *   `Configuración del sistema > Privacidad y seguridad > Accesibilidad`
    > **¿Por qué?** Esto es necesario para cualquier aplicación que necesite ver y modificar sus eventos de ratón o teclado en todo el sistema. La aplicación solo busca `Ctrl-Clic` y no hace nada más.

5.  **¡Listo!** Vuelva a lanzar la aplicación una vez más. Ahora está en funcionamiento y se iniciará automáticamente cada vez que inicie sesión por defecto. Puede cambiar este comportamiento desde el icono de la barra de menús.

La aplicación mostrará un pequeño icono en su barra de menús.
*   Haga clic en el icono para abrir un menú donde puede desactivar temporalmente la funcionalidad, controlar si se abre al iniciar sesión o salir de la aplicación.
*   Puede ocultar el icono manteniendo presionada la tecla `⌘` (Comando) y arrastrándolo fuera de la barra de menús. Si desea recuperarlo, simplemente inicie la aplicación de nuevo.

## Compilar desde el código fuente

Si prefiere compilar la aplicación usted mismo:

1.  Clone este repositorio:
    ```bash
    git clone https://github.com/achendev/DisableCtrlClick.git
    cd DisableCtrlClick
    ```
2.  Asegúrese de tener instaladas las herramientas de línea de comandos para Xcode.
3.  Ejecute el script de compilación desde su terminal:
    ```bash
    ./build.sh
    ```
4.  El paquete `DisableCtrlClick.app` se creará en el directorio del proyecto. Luego puedes moverlo a tu carpeta `/Applications`.

5.  Arrástralo a /Applications y ejecútalo. Se añadirá automáticamente a 'Abrir al iniciar sesión' por defecto.

6.  Concede los permisos de Accesibilidad y Monitoreo de Entrada en Configuración del Sistema.

## Solución de Problemas 

La aplicación se proporciona "tal cual" y sin ninguna garantía, expresa o implícita

Requiere macOS 13.0 (Ventura) o posterior.

**Cómo salir**
Haz clic en el icono de la barra de menús y selecciona "Salir". Si has ocultado el icono, puedes volver a iniciar la aplicación para mostrarlo, o usar el comando `killall DisableCtrlClick` en tu Terminal.

**Cómo restablecer permisos**
Si la aplicación no funciona, intenta restablecer sus permisos:
    ```bash
    tccutil reset Accessibility com.usr.DisableCtrlClick
    ```

## Licencia

Este proyecto se publica bajo la Licencia MIT.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-22

---