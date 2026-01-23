<div align="center">
<img src="https://moooonet.github.io/assets/Comfy-Align//images/display.jpg" width="100%">
<br><br>

[![Version](https://img.shields.io/badge/Version-3.0.4-cyan)](README.md)
[![Youtube](https://img.shields.io/badge/Video-Tutorial-red)](https://youtu.be/p1niyxwsOes)

</div>

ComfyUI-Align ofrece un conjunto potente de herramientas para la alineación, estiramiento y configuración de color de nodos, abordando la falta de funcionalidad de alineación de nodos en ComfyUI

> _Si este plugin te ha ayudado a preservar la cordura, por favor considera dar una ⭐ para sostener el hábito de la cafeína._

## Entorno

- ComfyUI: Probado en la versión 0.3.76; soporta teóricamente versiones recientes y futuras.
- Python: Probado en Python 3.12
- Sistema: Probado en Windows 11 y Ubuntu 25.10. Otras distribuciones Linux deberían funcionar; por favor prueba por ti mismo. Soporta teóricamente macOS, pero no ha sido probado por falta de dispositivo.

## Instalación

- **Desde ComfyUI Manager:** Busca "ComfyUI-Align" en ComfyUI Manager e instala.
- **Clonación Git:** Abre el directorio de ComfyUI, navega a la carpeta `custom_nodes` y ejecuta:
  ```bash
  git clone https://github.com/Moooonet/ComfyUI-Align.git
  ```
- **Reiniciar ComfyUI:** Después de la instalación, reinicie ComfyUI para cargar el nuevo plugin.

## Configuración y Uso

- **Tecla de acceso rápido:** Por defecto es la tecla de acento grave <kbd>`</kbd>, para compatibilidad con múltiples sistemas, la tecla de acceso rápido personalizada se implementa usando la función nativa de ComfyUI. Por favor, busque "Align Panel" en Keybindings para configurar una tecla de acceso rápido personalizada.

<div align="center">
  <img src="https://moooonet.github.io/assets/Comfy-Align/images/keybindings.jpg" width="100%">
</div>

- **Dos modos de operación:**
- 1. Use <kbd>`</kbd> para alternar la visibilidad del panel de alineación. (Tecla de acento grave, ubicada encima de la tecla Tab)
- 2. Habilite el Modo Mantener en Configuración (mantenga presionada la tecla de acceso rápido para mostrar el panel; pase el cursor sobre un botón y suelte la tecla para ejecutar sin hacer clic; o mantenga la tecla y haga clic en diferentes botones para realizar múltiples operaciones).

<div align="center">
  <img src="https://moooonet.github.io/assets/Comfy-Align/images/settings.jpg" width="100%">
</div>

## Características principales

### 1. Alineación, distribución y estiramiento de nodos y grupos

- **Alineación:**

  - **Alinear a la izquierda, Alinear a la derecha, Alinear arriba, Alinear abajo:**
  - Tecla `Alt`: Mantener <kbd>Alt</kbd> mientras se alinea invierte los nodos objetivo.

- **Distribución:**

  - **Distribución alineada arriba horizontal:** Distribuye los nodos uniformemente en horizontal primero, luego alinea arriba.
  - **Distribución alineada al centro vertical:** Distribuye los nodos uniformemente en vertical primero, luego alinea al centro.
  - **Configuración de espacio:** Configure el espacio en las opciones de `Align`.

- **Estiramiento:**
  - **Estirar a la izquierda, Estirar a la derecha, Estirar arriba, Estirar abajo:**
  - **Estiramiento bilateral horizontal:** El nodo más ancho es el objetivo, y los otros nodos se estiran a la izquierda y derecha del nodo objetivo, manteniendo su ancho.
  - **Estiramiento bilateral vertical:** El nodo más alto es el objetivo, y los otros nodos se estiran arriba y abajo del nodo objetivo, manteniendo su altura.
  - Tecla `Alt`: Mantener <kbd>Alt</kbd> mientras se estira invierte los nodos objetivo.

### 2. Gestión de color de nodos y grupos
- **ColorBar:**

  - 7 colores predeterminados
  - Ícono de luna (Para abrir el Selector de Color)
  - Borrar color (borrar el color de los nodos seleccionados)
  - Aplicar color (aplicar el color de los presets a los nodos correspondientes)

- **ColorPicker:**

  - Área de selección de color
  - Herramienta cuentagotas
  - Control deslizante de tono
  - Control deslizante de alfa
  - Valor HEX (clic para copiar, doble clic para editar)
  - Valor RGBA (clic para copiar, doble clic para editar. Mantener Ctrl para copiar todos los valores)
  - Historial de colores
  - Presets de color

- **ColorPresets:**
  - Inicialmente, se generará un archivo `color_presets.json` en el directorio raíz del plugin para almacenar presets de color personalizados.
  - Después de establecer el color de los nodos, haga clic en el botón `Guardar` para guardar el preset.
  - Haga clic en el botón `Borrar` para eliminar todos los colores de presets guardados.
  - Haga clic en el botón `Aplicar` para aplicar los colores de los presets a los nodos correspondientes. (El botón `Aplicar` está ubicado en la última posición de la `ColorBar`)

---

<div align="center">
   <a href="https://www.star-history.com/#Moooonet/ComfyUI-Align&Date">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date&theme=dark" />
      <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date" />
      <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date" />
    </picture>
   </a>
</div>

---

<div align="center">

  <p>A menos que se autorice explícitamente, la integración, modificación o redistribución de cualquier forma está estrictamente prohibida.</p>
  <p>© 2025 Moooonet. Todos los derechos reservados.</p>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-23

---