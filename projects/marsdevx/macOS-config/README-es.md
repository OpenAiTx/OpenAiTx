<div align="center">
  <img src="https://raw.githubusercontent.com/marsdevx/macOS-config/main/imgs/logo.png" width="320px" alt="macOS Config Logo">
</div>

<br>

<div align="center">

  [![Last Commit](https://custom-icon-badges.demolab.com/github/last-commit/marsdevx/macOS-config?logoColor=white&labelColor=2C2C2C&label=Last%20Commit&color=8A2BE2&logo=mark-github)](https://github.com/marsdevx/macOS-config/commits/main "Last Commit")
  [![Languages](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Languages&message=Bash%20%7C%20Lua&color=D32F2F&logo=file-code)](https://github.com/marsdevx/macOS-config "Languages")
  <br>
  [![Supported Platforms](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Platform&message=MacBook&color=748ADB&logo=apple)](https://github.com/marsdevx/macOS-config "Supported Platforms")
  [![Wallpapers](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Includes&message=Wallpapers&color=F47F42&logo=file-media)](https://github.com/marsdevx/macOS-config/tree/main/wallpapers "Wallpapers")
  [![Customization](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Customization&message=Ricing&color=009688&logo=sparkles-fill)](https://github.com/marsdevx/macOS-config "Customization")
  [![License](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=License&message=MIT&color=00C853&logo=law)](https://github.com/marsdevx/macOS-config/blob/main/LICENSE "License")

</div>

---

#  macOS Config

**macOS Config** is an **open-source** project designed to streamline the setup of your **MacBook** with **custom** settings, **program installations**, and **wallpapers**. Built using **shell** scripts, this tool **automates** the process of **configuring** your **macOS environment** for **productivity** and **ricing**.

* Specifically designed for **macOS customization** and **ricing**.
* Includes `.sh` **scripts** to **install** all programs you need for **work**.
* Applies your custom settings for installed programs **automatically**.
* Adds your favorite **wallpapers** for a personalized **macOS experience**.

Transform your MacBook into a fully customized workspace with this powerful and efficient tool!

---

## 🖼️ Preview

<div align="center">
  <img src="https://raw.githubusercontent.com/marsdevx/macOS-config/main/imgs/preview.png" alt="Preview">
</div>

---

## 🛠️ Instalación

Para instalar este proyecto, abra la aplicación Terminal en su sistema y ejecute los siguientes comandos. <br>
  - Si aparece una ventana emergente que le solicita descargar las Herramientas de Línea de Comandos de Xcode después del primer comando, haga clic en “Descargar” y luego ejecute nuevamente el primer comando.

1. **Clonar repositorio**
```zsh
git clone https://github.com/marsdevx/macOS-config.git ~/Downloads/macOS-config
```
2. **Instalar Homebrew**

```zsh
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
echo 'eval "$(/opt/homebrew/bin/brew shellenv)"' >> ~/.zshrc
eval "$(/opt/homebrew/bin/brew shellenv)"
```

3. **Desactivar los iconos del escritorio**
```zsh
defaults write com.apple.finder CreateDesktop false; killall Finder
```

4. **Crear directorio de configuración**
```zsh
mkdir -p ~/.config
```

5. **Actualizar Configuración del Sistema**

  - Centro de Accesibilidad y Control
    - Configuración del Sistema -> Accesibilidad -> Pantalla -> Reducir movimiento -> Activado  
    - Configuración del Sistema -> Centro de Control -> Ocultar y mostrar automáticamente la barra de menús -> Siempre  

  - Escritorio y Dock
    - Configuración del Sistema -> Escritorio y Dock -> Ocultar y mostrar automáticamente el Dock -> Activado  
    - Configuración del Sistema -> Escritorio y Dock -> Reorganizar automáticamente los Espacios según el uso más reciente -> Desactivado  
    - Configuración del Sistema -> Escritorio y Dock -> Al cambiar a una aplicación, cambiar a un Espacio ... -> Desactivado  
    - Configuración del Sistema -> Escritorio y Dock -> Agrupar ventanas por aplicación -> Desactivado  
    - Configuración del Sistema -> Escritorio y Dock -> Las pantallas tienen Espacios separados -> Activado  

  - Teclado
    - Configuración del Sistema -> Teclado -> Atajos de Teclado -> Spotlight -> Mostrar búsqueda Spotlight -> Desactivado  
    - Configuración del Sistema -> Teclado -> Atajos de Teclado -> Spotlight -> Mostrar ventana de búsqueda del Finder -> Desactivado  
    - Configuración del Sistema -> Teclado -> Atajos de Teclado -> Mission Control -> Cambiar a Escritorio 1 -> Activado  
    - Configuración del Sistema -> Teclado -> Atajos de Teclado -> Mission Control -> Cambiar a Escritorio 2 -> Activado  
    - Configuración del Sistema -> Teclado -> Atajos de Teclado -> Mission Control -> Cambiar a Escritorio 3 -> Activado  
    - Configuración del Sistema -> Teclado -> Atajos de Teclado -> Mission Control -> Cambiar a Escritorio 4 -> Activado  
    - Configuración del Sistema -> Teclado -> Atajos de Teclado -> Mission Control -> Cambiar a Escritorio 5 -> Activado  

---

## 🚀 Uso

1. **Bucle**

> Gestor de ventanas

```zsh
zsh ~/Downloads/macOS-config/loop.sh
```
- Después de ejecutar el script, configura la aplicación Loop con estos ajustes  
  - Color de acento -> Fondo de pantalla -> Degradado -> Activado  
  - Comportamiento -> Iniciar al iniciar sesión -> Activado  
  - Comportamiento -> Velocidad de animación -> Suave  
  - Comportamiento -> Incluir relleno -> Activado -> Configurar relleno -> 7px  
  - Comportamiento -> Usar pantalla con cursor -> Desactivado  
  - Atajos de teclado -> Centrar -> Eliminar  
  - Atajos de teclado -> Añadir -> General -> Centrar macOS -> Fn + Enter  

<br>

2. **Raycast**  

> Lanzamiento de aplicaciones


```zsh
zsh ~/Downloads/macOS-config/raycast.sh
```

- Después de ejecutar el script, configura la aplicación Raycast con estas configuraciones
  - Haz clic en Start Setup -> Continue.
  - Establece un nuevo atajo de teclado: Record New Hotkey -> Asignar Cmd + Espacio.
  - Haz clic en Continue para finalizar.

<br>

3. **Sketchybar**

> Barra superior personalizable

```zsh
zsh ~/Downloads/macOS-config/sketchybar.sh
```

<br>

4. **SKHD**

> Hotkey manager

```zsh
zsh ~/Downloads/macOS-config/skhd.sh
```

<br>

5. **Yabai**

> Window manager for multiple workspaces

```zsh
zsh ~/Downloads/macOS-config/yabai.sh
```

<br>

5. **Iterm**

> Aplicación de terminal

- Instalar Oh My Zsh
```zsh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"
```
- Instalar tema para Oh My Zsh

```zsh
git clone https://github.com/romkatv/powerlevel10k.git $ZSH_CUSTOM/themes/powerlevel10k
```

- Instalar y configurar Iterm2
```zsh
zsh ~/Downloads/macOS-config/iterm.sh
```

- Actualizar zshrc
```zsh
source ~/.zshrc
```
- Configurar Powerlevel10k  
  - Estilo: Lean  
  - Conjunto de caracteres: Unicode  
  - Esquema de color: 8 colores  
  - Separador del prompt: No  
  - Diseño: Dos líneas  
  - Estado de conexión: Desconectado  
  - Alineación del prompt: Izquierda  
  - Color de acento: Azul  
  - Densidad del prompt: Escaso  
  - Estilo de icono: Muchos iconos  
  - Estilo del prompt: Conciso  
  - Prompt instantáneo: Sí  
  - Verbosidad: Verboso  

- Configurar iTerm2  
  - Abrir iTerm2 y navegar a Configuración.  
    - General -> Cierre -> Confirmar "Salir de iTerm2 (CmdQ)" -> Apagado  
    - Apariencia -> General -> Tema: Minimal  
    - Apariencia -> General -> Ubicación de la barra superior: Inferior  
    - Apariencia -> Ventanas -> Ocultar barras de desplazamiento -> Activado  
    - Apariencia -> Ventanas -> Mostrar línea bajo la barra de título ... -> Apagado  
    - Apariencia -> Paneles -> Márgenes laterales: 8  
    - Apariencia -> Paneles -> Márgenes superior e inferior: 12  
    - Perfiles -> Colores -> Preajustes de color -> Importar -> Descargas -> rose-pine.itermcolors  
    - Perfiles -> Colores -> Preajustes de color -> rose-pine  
    - Perfiles -> Ventana -> Transparencia: 7  
    - Perfiles -> Texto -> Fuente -> MesloLGS NF  
    - Perfiles -> Texto -> Tamaño de fuente -> 13  
    - Perfiles -> Integración con la shell -> Mostrar indicadores de marca -> Apagado  

<br>  

6. **Fondos de pantalla**  

> Mi configuración de fondos de pantalla  

- Abrir Configuración del sistema  
  - Fondo de pantalla -> Añadir carpeta o álbum -> Elegir carpeta -> Descargas -> macOS-config -> wallpapers  

  - Haga clic en la carpeta de fondos de pantalla en la parte inferior de la página
  - Ajuste la configuración:
    - Aleatorio: Cada minuto
    - Mostrar en todos los espacios: Activado

---

## 📋 Licencia

Todo el código contenido en este repositorio está licenciado bajo la [Licencia MIT](LICENSE)

```
MIT License

Copyright (c) 2025 marsdevx

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## ⭐ Soporte

Si te gusta este proyecto, no olvides ⭐ **estrellarlo** y **seguirme**.  
Tu **apoyo** me ayuda a crear más proyectos. 🚀  

🔗 **¡Explora más de mi trabajo en [GitHub](https://github.com/marsdevx?tab=repositories) y descubre otros proyectos emocionantes!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-05

---