# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="assets/linux/icon_256.png">

Lanzador de aplicaciones multiplataforma orientado a la web con plugins basados en React

> [!WARNING]
> El lanzador está siendo desarrollado por un solo desarrollador en su tiempo libre.
> Los cambios pueden ser lentos pero constantes
>
> Probablemente habrá cambios incompatibles que se documentarán en el [registro de cambios](CHANGELOG.md).

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Demo

Demo ligeramente desactualizada

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Características

- Enfoque en plugins
  - Los plugins están escritos en TypeScript
  - API de plugins extensa
      - Crear vistas de interfaz de usuario
      - Comandos de una sola ejecución
      - Proveer dinámicamente una lista de comandos de una sola ejecución
      - Renderizar contenido rápido "en línea" directamente bajo la barra principal de búsqueda según el valor ingresado
      - Obtener contenido del portapapeles y agregar contenido al mismo
  - Los plugins se distribuyen como una rama separada en un repositorio Git, lo que significa que la distribución de plugins no necesita ningún servidor central
  - Los IDs de plugins son simplemente URLs de repositorios Git
  - Interfaz de usuario basada en [React](https://github.com/facebook/react) para plugins
    - Implementado usando un React Reconciler personalizado (sin Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno permite aislar el código JavaScript de los plugins para una mayor seguridad
    - Los plugins deben especificar explícitamente qué permisos necesitan para funcionar
    - Node.js se utiliza para ejecutar herramientas de desarrollo de plugins, pero como desarrollador de plugins siempre escribirás código que se ejecuta en Deno
- Diseñado desde el principio con la multiplataforma en mente
- Comandos y vistas pueden ejecutarse o abrirse usando atajos globales personalizados
- Se pueden asignar alias de búsqueda personalizados a comandos o vistas
- Soporte de temas personalizado
- La funcionalidad integrada es proporcionada por plugins incluidos
  - Aplicaciones: muestra las aplicaciones instaladas en el sistema en los resultados de búsqueda
    - El plugin también rastrea ventanas y a qué aplicación pertenecen, por lo que abrir una aplicación que ya está abierta, por defecto, traerá la ventana creada previamente
      - No todos los sistemas están soportados actualmente. Ver [soporte de características](https://gauntlet.sh/docs/feature-support)
  - Calculadora: muestra el resultado de operaciones matemáticas directamente bajo la barra principal de búsqueda
    - Incluye conversión de moneda usando tasas de cambio
    - Impulsado por [Numbat](https://github.com/sharkdp/numbat)
- Ordenamiento de resultados de búsqueda basado en frecuencia y recencia (Frecency)
   - Frecency es una combinación de frecuencia y recencia
   - Cuanto más se use un elemento, más arriba aparecerá en la lista de resultados, pero elementos que se usaron mucho en el pasado serán clasificados más abajo que los que se usaron la misma cantidad de veces recientemente
   - Los resultados se emparejan por palabra mediante subcadenas

##### Soporte de sistemas operativos

##### Oficial
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### Mejor esfuerzo
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland aún no está soportado, ver [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Primeros pasos

### Instalar Gauntlet

Ver [Instalación](https://gauntlet.sh/docs/installation)

### Atajo global

La ventana principal puede abrirse usando un atajo global o comando CLI:
- Atajo global (puede cambiarse en Configuración)
  - Windows: <kbd>ALT</kbd> + <kbd>Espacio</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Espacio</kbd>
  - Linux Wayland
    - El atajo global puede no estar soportado, ver [soporte de características](https://gauntlet.sh/docs/feature-support)
    - Por favor, utiliza el comando CLI en su lugar e invócalo usando el método específico del gestor de ventanas
  - macOS: <kbd>CMD</kbd> + <kbd>Espacio</kbd>
- Comando CLI
  - `gauntlet open`

### Instalar un plugin

Los plugins se instalan en la interfaz de Configuración. Utiliza la URL del repositorio Git del plugin para instalarlo, por ejemplo: `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](docs/settings_ui.png)

### Crear tu propio plugin

Ver [Primeros pasos con el desarrollo de plugins](https://gauntlet.sh/docs/plugin-development/getting-started)

## Temas

Ver [Temas](https://gauntlet.sh/docs/theming)

## Compilando Gauntlet

Necesitarás:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (no lo usa el proyecto directamente, pero es requerido por una dependencia)
- En Linux: `libxkbcommon-dev` (nota: el nombre puede variar según la distribución usada)

### Desarrollo

Para construir en modo desarrollo ejecuta:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
En modo desarrollo (sin la característica "release") la aplicación usará directorios SOLO dentro del directorio del proyecto para almacenar estado o caché, para evitar afectar instalaciones globales

### No empaquetado aún

Para construir un binario de lanzamiento no empaquetado aún, ejecuta:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Empaquetado
Para construir el paquete específico de un sistema operativo, ejecuta uno de los siguientes:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Pero el lanzamiento de la nueva versión debe realizarse a través de GitHub Actions

## Contribuir

Si quieres ayudar a construir Gauntlet puedes hacerlo de más formas además de contribuir código:
- Reportando un error o problema de UI/UX
- Creando un plugin

Para problemas simples siéntete libre de abrir un issue o PR y abordarlo tú mismo.
Para cambios más significativos, por favor contacta a los creadores en Discord (enlace de invitación al inicio del README) y discútelo primero.

Todas y cualquier contribución es bienvenida.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---