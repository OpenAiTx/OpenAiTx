<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">Dictado sin interrupciones impulsado por el modelo Whisper de OpenAI</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## Acerca de

Whispering es una aplicación de transcripción de código abierto que proporciona funcionalidad global de voz a texto, con opciones como atajos de teclado y copiado y pegado automático para hacer que el dictado sea lo más fluido posible.

En su funcionamiento interno, utiliza el modelo Whisper de OpenAI, lo que lo hace significativamente más preciso que el dictado incorporado.

> **Nota importante**: Whispering está diseñado principalmente como una herramienta de transcripción, no como una herramienta de grabación. Para grabaciones largas donde la fiabilidad es crucial, recomiendo usar una aplicación de grabación dedicada en tu teléfono o dispositivo que utilice las API nativas de grabación. Esto garantiza una calidad de audio óptima y estabilidad en la grabación.

## Demos

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Funcionalidades principales

1. **Transcripción global**: Accede a la función de voz a texto de Whisper en cualquier lugar con un atajo global de teclado o en solo dos clics.
2. **Experiencia multiplataforma**:
   - Aplicación de escritorio: Permite la transcripción global en todas las aplicaciones.
   - Extensión de navegador: Proporciona transcripción global en el navegador mediante la comunicación con la aplicación web.
3. **Integración con chat**: La extensión del navegador añade un botón de grabación en los sitios web de ChatGPT y Claude, permitiendo entrada directa por voz y transcripción en la interfaz de chat.
4. **Gestión de transcripciones**: Revisa y edita transcripciones dentro de la app de Whispering para asegurar precisión y claridad.
5. **Integración automática con portapapeles**: Una vez que la transcripción esté lista, el texto se copia automáticamente a tu portapapeles. También hay una opción para pegado automático.

## ¿Cómo se almacena mi información?

Whispering almacena la mayor cantidad posible de datos localmente en tu dispositivo, incluidas las grabaciones y transcripciones de texto. Este enfoque garantiza la máxima privacidad y seguridad de los datos. Aquí tienes un resumen de cómo se maneja la información:

1. **Almacenamiento local**: Las grabaciones de voz y las transcripciones se almacenan en IndexedDB, que se utiliza como almacenamiento de blobs y para guardar todos tus datos, como texto y transcripciones.

2. **Servicio de transcripción**: El único dato que se envía a otro lugar es tu grabación a un servicio de transcripción externo—si eliges uno. Tienes las siguientes opciones:
   - Servicios externos como OpenAI o Groq
   - Un servicio de transcripción local como `faster-whisper-server`, que mantiene todo en el dispositivo

3. **Configuración personalizable**: Puedes cambiar el servicio de transcripción en la configuración para garantizar la máxima funcionalidad local.


## Instalación

### Aplicación web

Visita [whispering.bradenwong.com](https://whispering.bradenwong.com/), donde se aloja la última versión de la carpeta `apps/app` en Vercel.

### Extensión de Chrome

Instala la extensión de Chrome desde la Chrome Web Store [aquí](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### Aplicación de escritorio

Para descargar e instalar la aplicación de escritorio Whispering, sigue los pasos correspondientes a tu sistema operativo:

#### Windows

1. Descarga el paquete de instalación que termina en `.msi` desde la [página de lanzamientos más recientes](https://github.com/braden-w/whispering/releases).
2. Abre el archivo `.msi` descargado para ejecutar el instalador.
3. Si aparece una advertencia de seguridad, haz clic en `Más información` -> `Ejecutar de todas formas` para continuar con la instalación.
4. Sigue las instrucciones en pantalla para completar la instalación.

#### macOS

Para macOS, sigue estos pasos para instalar Whispering:

1. **Descarga el paquete de instalación**:
   - Visita la [página de lanzamientos más recientes](https://github.com/braden-w/whispering/releases).
   - Elige el paquete apropiado:
     - Para Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Para Intel: `Whispering_x.x.x_x64.dmg`

2. **Instala la aplicación**:
   - Abre el archivo `.dmg` descargado.
   - Arrastra la app de Whispering a la carpeta de Aplicaciones.

3. **Inicia Whispering**:
   - Abre Whispering desde la carpeta de Aplicaciones.
   - Si ves una advertencia sobre desarrollador no verificado:
     - Haz clic en `Cancelar`
     - Haz clic derecho en la app en Finder y selecciona `Abrir`

4. **Solución de problemas** (solo Apple Silicon):
   Si te aparece el error `"Whispering" está dañado y no se puede abrir`:
   - Abre Terminal
   - Ejecuta el siguiente comando:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Intenta abrir la aplicación de nuevo

Después de completar estos pasos, Whispering debería estar listo para usarse en tu sistema macOS.

#### Linux

Para Linux, hay varias opciones de instalación disponibles. Elige la que mejor se adapte a tu entorno:

1. **AppImage**:

   - Descarga el archivo `.AppImage` desde la [página de lanzamientos más recientes](https://github.com/braden-w/whispering/releases).
   - Haz que el archivo sea ejecutable:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - Ejecuta el AppImage:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **Paquete DEB (Debian/Ubuntu)**:
   - Descarga el archivo `.deb` desde la [página de lanzamientos más recientes](https://github.com/braden-w/whispering/releases).
   - Instala el paquete usando `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Resuelve cualquier problema de dependencias:
     ```bash
     sudo apt-get install -f
     ```

Tras la instalación, la app estará lista para usarse.

## Uso

### Extensión de Chrome

Después de instalar la extensión de Chrome, encontrarás un icono de Whispering en la barra de extensiones de Chrome. Haz clic en este icono para abrir la extensión. Haz clic en el botón de micrófono para grabar tu voz y luego haz clic en el botón cuadrado cuando termines. Tu transcripción aparecerá en el cuadro de texto inferior.

Para acceder a la función de ChatGPT o Claude, navega a la página web de ChatGPT o Claude. Verás un nuevo botón de grabación en la interfaz de chat. Haz clic en este botón para comenzar y detener la grabación, y el texto transcrito se insertará automáticamente en el campo de entrada del chat.

Para acceder a la función de atajo, presiona <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> o <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (configurable posteriormente a través de los atajos de la extensión de Chrome) para comenzar a grabar desde cualquier sitio web. La transcripción se copiará automáticamente en tu portapapeles y se pegará en el campo de entrada actual.

La extensión de Chrome se comunica con [whispering.bradenwong.com](https://whispering.bradenwong.com), e intentará automáticamente crear una pestaña en segundo plano si no encuentra una. La mayoría de los errores pueden atribuirse a fallos en esta comunicación, como en casos raros en que la pestaña entra en suspensión.

### Aplicación web

La app web es accesible a través de [whispering.bradenwong.com](https://whispering.bradenwong.com). Haz clic en el botón de micrófono para grabar tu voz y luego haz clic en el botón cuadrado cuando termines. Tu transcripción aparecerá en el cuadro de texto.

### Aplicación de escritorio

Después de instalar la aplicación de escritorio Whispering, presiona <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (configurable en la configuración) para comenzar a grabar desde cualquier lugar de tu escritorio. La transcripción se copiará automáticamente en tu portapapeles y se pegará, aunque ambas funciones se pueden activar o desactivar en la configuración.

## Construido con

#### Web y escritorio

La aplicación Whispering está construida utilizando las siguientes tecnologías y librerías:

- [Svelte 5](https://svelte.dev): La biblioteca de reactividad de UI elegida.
- [SvelteKit](https://kit.svelte.dev/docs): Para enrutamiento y generación de sitios estáticos, usada tanto para el sitio web como para el frontend estático de la app Tauri.
- [Tauri](https://tauri.studio/en/docs/intro/): El framework de la aplicación de escritorio.
- [Effect-TS](https://github.com/Effect-TS/effect): Para añadir programación funcional y escribir funciones extremadamente seguras a nivel de tipos, donde los errores están incluidos en el tipo de retorno de la función.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Una librería de notificaciones simple y personalizable para aplicaciones Svelte. Se utiliza para capturar y mostrar errores propagados mediante Effect-TS usando la función `renderAsToast`.
- [TanStack Table](https://tanstack.com/table): Para alimentar todas las tablas de datos.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): Una API de bajo nivel para almacenar grandes cantidades de datos estructurados en el navegador. Sincronizada con Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): La biblioteca de componentes UI elegida.
- [TailwindCSS](https://tailwindcss.com/docs): Un framework CSS utilitario para construir interfaces de usuario personalizadas rápidamente.
- [Turborepo](https://turborepo.org/): Para la gestión de monorepos, de modo que `apps/app` y `apps/extension` puedan compartir la misma base de código, reduciendo drásticamente la duplicación de código y, lo que es más importante, manteniendo una única fuente de la verdad.
- [Rust](https://www.rust-lang.org): Para extender las funcionalidades de la app de escritorio, como el uso del crate `enigo` para manejar el pegado automático.
- [Vercel](https://vercel.com/): Alojamiento ideal para un proyecto de hobby y con buenas integraciones con Turborepo.
- [Zapsplat.com](https://www.zapsplat.com/): Una biblioteca de efectos de sonido libres de derechos.

#### Extensión

La extensión de Chrome de Whispering está construida usando:

- [Plasmo](https://docs.plasmo.com/): Un framework para construir extensiones de Chrome. Utilizamos el [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) para comunicarnos con el sitio web de Whispering.
- [Effect-TS](https://github.com/Effect-TS/effect): Para añadir programación funcional y escribir funciones extremadamente seguras a nivel de tipos, donde los errores están incluidos en el tipo de retorno de la función.
- [React](https://reactjs.org): La biblioteca de reactividad de UI para la extensión de Chrome, ya que Plasmo lamentablemente no soporta Svelte 5.
- [ShadCN](https://github.com/shadcn): La biblioteca de componentes UI para la extensión de Chrome.
- [TailwindCSS](https://tailwindcss.com/docs): Un framework CSS basado en utilidades para construir rápidamente interfaces de usuario personalizadas.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): La API de extensiones de Chrome.
- [Zapsplat.com](https://www.zapsplat.com/): Una biblioteca de efectos de sonido libres de derechos.

## Ejecutar Whispering en Modo de Desarrollo Local

Para configurar el proyecto en tu máquina local, sigue estos pasos:

1. Clona el repositorio: `git clone https://github.com/braden-w/whispering.git`
2. Entra en el directorio del proyecto: `cd whispering`
3. Instala las dependencias necesarias: `pnpm i`

Para ejecutar la aplicación de escritorio y el sitio web de Whispering en modo de desarrollo:

4. Entra en el directorio de la app: `cd apps/app`
5. Ejecuta el servidor de desarrollo: `pnpm tauri dev`

La aplicación de escritorio debería abrirse automáticamente para desarrollo local. Para desarrollar la aplicación web, abre tu navegador y navega a `http://localhost:5173`.

Para ejecutar la extensión de Chrome de Whispering en modo de desarrollo:

4. Entra en el directorio de la extensión: `cd apps/extension`
5. Ejecuta el servidor de desarrollo: `pnpm dev --target=chrome-mv3`

Para desarrollar la extensión de Chrome, cárgala en Chrome navegando a `chrome://extensions`, habilitando el modo desarrollador y cargando la carpeta `apps/extension/build/{platform}-{manifest-version}-dev` como una extensión desempaquetada.

## Compilar el Ejecutable Tú Mismo

Si alguna vez tienes dudas sobre la confiabilidad de los instaladores o deseas más control, siempre puedes compilar el ejecutable tú mismo. Esto requiere más configuración, pero asegura que estás ejecutando el código que esperas. ¡Esa es la belleza del software de código abierto!

### Chrome

1. Entra en el directorio de la extensión: `cd apps/extension`
2. Instala las dependencias necesarias: `pnpm i`
3. Ejecuta el build de Plasmo: `pnpm plasmo build --target=chrome-mv3`
4. La salida se encontrará en `apps/extension/build/chrome-mv3-prod`, la cual se puede cargar en Chrome como una extensión desempaquetada.
5. Alternativamente, puedes compilar la extensión para la Chrome Web Store: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Entra en el directorio de la extensión: `cd apps/extension`
2. Instala las dependencias necesarias: `pnpm i`
3. Ejecuta el build de Plasmo: `pnpm plasmo build --target=firefox-mv3`
4. La salida se encontrará en `apps/extension/build/firefox-mv3-prod`, la cual se puede cargar en Chrome como una extensión desempaquetada.
5. Alternativamente, puedes compilar la extensión para la Chrome Web Store: `pnpm plasmo build --target=firefox-mv3 --release`

### Escritorio

1. Entra en el directorio de la app: `cd apps/app`
2. Instala las dependencias necesarias: `pnpm i`
3. Ejecuta el build de Tauri: `pnpm tauri build`
4. Puedes encontrar el ejecutable en el directorio `apps/app/target/release`.

## Contribuir

¡Damos la bienvenida a contribuciones de la comunidad! Si deseas contribuir a Whispering, por favor sigue estos pasos:

1. Haz un fork del repositorio.
2. Crea una nueva rama para tu funcionalidad o corrección de error: `git checkout -b feature/tu-nombre-de-funcionalidad` o `git checkout -b fix/tu-nombre-de-correcion`
3. Realiza tus cambios y haz commit con un mensaje descriptivo.
4. Haz push de tu rama a tu repositorio forkeado: `git push origin tu-nombre-de-rama`
5. Crea un pull request desde tu repositorio forkeado al original.

Por favor, asegúrate de que tu código sigue las convenciones establecidas y está bien documentado.

## Licencia

Whispering se lanza bajo la [Licencia MIT](https://opensource.org/licenses/MIT).

## Patrocinadores

Este proyecto está apoyado por las siguientes personas y organizaciones increíbles:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Soporte y Comentarios

Si encuentras algún problema o tienes sugerencias de mejoras, por favor abre un issue en la [pestaña de issues de GitHub](https://github.com/braden-w/whispering/issues) o contáctame vía [whispering@bradenwong.com](mailto:whispering@bradenwong.com). ¡Realmente aprecio tus comentarios!

¡Gracias por usar Whispering y felices escritos!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---