<h1 align="center">ModernZ - Una OSC Alternativa y Elegante para mpv</h1>

Una OSC moderna y elegante para [mpv](https://mpv.io/), este proyecto es un fork de ModernX diseñado para mejorar la funcionalidad añadiendo más características, todo mientras se preservan los estándares básicos de la OSC de mpv.

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>Instalación »</strong></a>
  <br>
  <a href="#configuration">Configuración</a>
  ·
  <a href="#controls">Controles</a>
  ·
  <a href="#interactive-menus">Menús Interactivos</a>
  ·
  <a href="#translations">Idioma de la OSC</a>
  ·
  <a href="#extras">Scripts Extras</a>
</p>

## Características

- 🎨 Interfaz moderna y personalizable [[opciones](#configuration)]
- 📷 Modo Visor de Imágenes con controles de zoom [[detalles](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ Botones: descarga, lista de reproducción, control de velocidad, captura de pantalla, fijar, bucle, caché y más. [[detalles](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 Menús interactivos para lista de reproducción, subtítulos, capítulos, pistas de audio y dispositivos de audio [[detalles](#interactive-menus)]
- 🌐 Soporte multilenguaje con integración JSON de [locale](#translations)
- ⌨️ Controles configurables [[detalles](#controls)]
- 🖼️ Previsualización de miniaturas de video con [thumbfast](https://github.com/po5/thumbfast)

## Personalización

Puedes cambiar el tema de iconos a `fluent` o `material` para que coincida con tu gusto y estilo usando la opción `icon_theme` en tu `modernz.conf`

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

¿No te gustan los botones y textos blancos? Tienes control total para personalizar colores y disposiciones de botones para reflejar perfectamente tu estilo.

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

Consulta la sección [Personalización de Colores](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style) en la guía de configuración para detalles sobre cómo personalizar colores y botones.

## Menús Interactivos

ModernZ soporta la consola/select incorporada de mpv ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)) para lista de reproducción, subtítulos, navegación de capítulos y más.

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## Instalación

1. **Desactivar la OSC por defecto**

   - Añade `osc=no` en tu `mpv.conf`

2. **Copiar Archivos**

   - Coloca `modernz.lua` en tu directorio de scripts de mpv
   - Coloca `fluent-system-icons.ttf` y `material-design-icons.ttf` en tu directorio de fuentes de mpv
   - (OPCIONAL) Coloca `thumbfast.lua` en tu directorio de scripts de mpv

3. **Ubicaciones**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **Estructura de carpetas** [[manual de mpv](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (opcional)
   ```

## Configuración

1. Crea `modernz.conf` en la carpeta `/script-opts` para personalizar ajustes

   - [Descarga modernz.conf por defecto](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. Ejemplo de una configuración corta:

   ```EditorConfig
   # Color de la barra de progreso (formato hex)
   seekbarfg_color=#B7410E

   # Opciones de interfaz
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

Para una lista completa de opciones, [consulta la lista detallada aquí](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md).

## Controles

### Interacciones con botones

- Click izquierdo: Acción primaria
- Click derecho: Acción secundaria
- Click central/Shift+Click izquierdo: Acción alternativa

> [!NOTA]
> El clic central realiza la misma función que `Shift+botón izquierdo`, permitiendo uso con una sola mano

Para una lista completa de interacciones, consulta la [Guía de Interacciones con Botones](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md).

### Atajos de teclado

ModernZ no asigna atajos por defecto para evitar interferir con tu configuración actual. Puedes añadir atajos en `input.conf` si prefieres:

```
w   script-binding modernz/progress-toggle           # Alternar barra de progreso
x   script-message-to modernz osc-show               # Mostrar OSC
y   script-message-to modernz osc-visibility cycle   # Ciclar modos de visibilidad
z   script-message-to modernz osc-idlescreen         # Alternar pantalla inactiva
```

## Traducciones

ModernZ está actualmente disponible en inglés, ¡pero puedes cambiarlo fácilmente a tu idioma preferido! Aquí te explicamos cómo:

1. **Descarga el paquete de locales:**

Descarga el archivo [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) desde este repositorio. Este archivo contiene traducciones para varios idiomas.

2. **Añade los locales a mpv:**

Copia el archivo `modernz-locale.json` descargado a la carpeta `/script-opts` de tu mpv.

3. **Elige tu idioma:**

Hay dos formas de establecer tu idioma preferido:

- **Recomendado:** Usa el archivo `modernz.conf`

  ```ini
  # Ejemplo de configuración en modernz.conf
  # Establecer idioma a chino simplificado
  language=zh
  ```

- **Alternativa:** Edita el script `modernz.lua`

  Abre `modernz.lua` y busca la sección `user_opts` cerca del inicio. Cambia el valor de `language` al código de idioma que prefieras:

  ```lua
  local user_opts = {
      -- General
      language = "en",  -- Cambia esto por el código de idioma preferido
      ...
  }
  ```

**¿Necesitas más información?**

Para una lista completa de idiomas disponibles, guías de contribución y documentación detallada sobre traducciones, visita el [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md).

## Extras

Los siguientes scripts son desarrollos propios que mantengo, si te son útiles, siéntete libre de usarlos.

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - Un script simple que muestra un indicador al pausar

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - Un script simple para mpv que cambia automáticamente `ytdl-format` (yt-dlp) para dominios especificados.

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - Un script simple para mpv que cambia automáticamente la relación de aspecto 4:3 de archivos/videos a 16:9.

Para más scripts útiles, visita la [Wiki de Scripts de Usuario de mpv](https://github.com/mpv-player/mpv/wiki/User-Scripts). Ofrece una amplia variedad de scripts comunitarios para mejorar tu experiencia con mpv.

## Historial

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - fork de [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - fork de [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - fork de [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**¿Por qué otro fork más?**

- Para añadir muchas características: [Personalización de Colores](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style), [Opciones](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md) y [Integración de Locales](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- Para integrar consola y selección en la OSC, lo que inspiró a mpv a aplicarlo en la OSC original. [ref [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- Para añadir un diseño dedicado para imágenes. [[detalles](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- Para rehacer el proyecto completamente para coincidir con los estándares de la OSC original de mpv, asegurando compatibilidad
- Para eliminar errores antiguos y redundancias en el código
    - Lo que permite que otros forks `Modern` usen ModernZ como base, como [zydezu/ModernX](https://github.com/zydezu/ModernX). [[Referencia](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

En esencia, para mantener y revivir el origen `modern-osc`.
Dicho esto, ModernZ todavía utiliza partes del código antiguo, y todos los autores y colaboradores de forks anteriores y actuales merecen crédito (incluido el osc estándar de mpv), por eso se mencionan en detalle.

#### Créditos:

- Fuente: UI Fluent System Icons [[detalles](https://github.com/microsoft/fluentui-system-icons)] [[archivo de fuente](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- Fuente modificada por [Xurdejl](https://github.com/Xurdejl) para su uso en ModernZ osc
- [mpv](https://github.com/mpv-player/mpv) y su [osc.lua](https://github.com/mpv-player/mpv/blob/master/player/lua/osc.lua), ya que ModernZ osc se basó nuevamente en los estándares del osc estándar y aplica actualizaciones de este
- Todos los orígenes modernos de osc y sus forks como se mencionan en la [historia](#history)
- Todos los [colaboradores](https://github.com/Samillion/ModernZ/graphs/contributors), testers y usuarios que ayudaron directa o indirectamente con ModernZ osc ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---