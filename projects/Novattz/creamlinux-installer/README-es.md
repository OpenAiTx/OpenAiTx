# CreamLinux

CreamLinux es una aplicación GUI para Linux que simplifica la gestión de IDs de DLC en juegos de Steam. Proporciona una interfaz fácil de usar para instalar y configurar CreamAPI (para juegos nativos de Linux) y SmokeAPI (para juegos de Windows que se ejecutan a través de Proton).

## Mira la demostración aquí:

[![Mira la demostración](https://raw.githubusercontent.com/Novattz/creamlinux-installer/main/./src/assets/screenshot1.png)](https://www.youtube.com/watch?v=neUDotrqnDM)

## Estado Beta

⚠️ **IMPORTANTE**: CreamLinux está actualmente en BETA. Esto significa:

- Algunas funciones pueden estar incompletas o sujetas a cambios
- Puede que encuentres errores o comportamientos inesperados
- La aplicación está en desarrollo activo
- Tus comentarios y reportes de errores son invaluables

Aunque la funcionalidad principal está operativa, ten en cuenta que esta es una versión temprana. Estoy trabajando continuamente para mejorar la estabilidad, agregar funciones y mejorar la experiencia del usuario. Por favor, reporta cualquier problema que encuentres en la [página de Issues de GitHub](https://github.com/Novattz/creamlinux-installer/issues).

## Características

- **Auto-descubrimiento**: Encuentra automáticamente los juegos de Steam instalados en tu sistema
- **Soporte nativo**: Instala CreamLinux para juegos nativos de Linux
- **Soporte Proton**: Instala SmokeAPI para juegos de Windows que se ejecutan a través de Proton
- **Gestión de DLC**: Selecciona fácilmente qué DLCs activar
- **Interfaz moderna**: Interfaz limpia, responsiva y fácil de usar

## Instalación

### AppImage (Recomendado)

1. Descarga el último `creamlinux.AppImage` desde la página de [Releases](https://github.com/Novattz/creamlinux-installer/releases)
2. Hazlo ejecutable:
   ```bash
   chmod +x creamlinux.AppImage
   ```
3. Ejecútalo:

   ```bash
   ./creamlinux.AppImage
   ```
   Para usuarios de Nvidia, use este comando:


   ```
   WEBKIT_DISABLE_DMABUF_RENDERER=1 ./creamlinux.AppImage
   ```

### Construcción desde el código fuente

#### Requisitos previos

- Rust 1.77.2 o superior
- Node.js 18 o superior
- webkit2gtk-4.1 (libwebkit2gtk-4.1 para debian)
- npm o yarn

#### Pasos

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/Novattz/creamlinux-installer.git
   cd creamlinux-installer
   ```

2. Instalar dependencias:

   ```bash
   npm install # or yarn
   ```
3. Construya la aplicación:


   ```bash
   NO_STRIP=true npm run tauri build
   ```

4. El binario compilado estará disponible en `src-tauri/target/release/creamlinux`

### Integración en el Escritorio

Si estás usando la versión AppImage, puedes integrarla en tu entorno de escritorio:

1. Crea un archivo de entrada para el escritorio:

   ```bash
   mkdir -p ~/.local/share/applications
   ```

2. Cree `~/.local/share/applications/creamlinux.desktop` con el siguiente contenido (ajuste la ruta a su AppImage):

   ```
   [Desktop Entry]
   Name=Creamlinux
   Exec=/absolute/path/to/CreamLinux.AppImage
   Icon=/absolute/path/to/creamlinux-icon.png
   Type=Application
   Categories=Game;Utility;
   Comment=DLC Manager for Steam games on Linux
   ```

3. Actualice su base de datos de escritorio para que creamlinux aparezca en el lanzador de aplicaciones:

```bash
update-desktop-database ~/.local/share/applications
```

## Solución de problemas

### Problemas comunes

- **El juego no carga**: Asegúrate de que las opciones de lanzamiento estén configuradas correctamente en Steam
- **Los DLC no aparecen**: Intenta actualizar la lista de juegos y reinstalar
- **No se encuentra Steam**: Asegúrate de que Steam esté instalado y lo hayas iniciado al menos una vez

### Registros de depuración

Los registros se almacenan en: `~/.cache/creamlinux/creamlinux.log`

## Licencia

Este proyecto está licenciado bajo la Licencia MIT - consulta el archivo [LICENSE](https://raw.githubusercontent.com/Novattz/creamlinux-installer/main/LICENSE.md) para más detalles.

## Créditos

- [Creamlinux](https://github.com/anticitizn/creamlinux) - Soporte nativo
- [SmokeAPI](https://github.com/acidicoala/SmokeAPI) - Soporte Proton
- [Tauri](https://tauri.app/) - Framework para construir la aplicación de escritorio
- [React](https://reactjs.org/) - Biblioteca de interfaz de usuario


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---