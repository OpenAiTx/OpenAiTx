# SSH-List
Administrador de conexiones SSH con una interfaz TUI.

![demo gif](https://raw.githubusercontent.com/akinoiro/ssh-list/main/images/demo.gif)

Características principales:
- Añadir y editar conexiones
- Reorganizar y ordenar conexiones
- Importar hosts desde ~/.ssh/config
- Buscar y filtrar conexiones
- Ejecutar comandos en hosts remotos

Esta aplicación no modifica tus archivos de configuración SSH existentes. La configuración de hosts puede estar distribuida en múltiples archivos referenciados por directivas Include (y entre configuraciones del sistema y del usuario), por lo que la edición automática no es confiable.

Esta aplicación no almacena contraseñas. Para autenticación segura, utiliza claves SSH.

## Requisitos previos
Debes tener un cliente OpenSSH instalado en tu sistema.
## Instalar desde la versión de GitHub
Descarga el último binario desde la [página de Releases](https://github.com/akinoiro/ssh-list/releases).

#### Para ejecutar el comando `ssh-list` desde la terminal:
```
# Make the binary executable
chmod +x ssh-list
# Move it to a directory in your PATH
sudo mv ssh-list /usr/local/bin/
```
## Instalar desde crates.io

```
cargo install ssh-list
```
## Instalar desde AUR (Arch Linux)
```
paru -S ssh-list
```
## Instalar desde PPA (Ubuntu, Linux Mint)
```
sudo add-apt-repository ppa:akinoiro/ssh-list
sudo apt update
sudo apt install ssh-list
```
## Instalar desde Homebrew (macOS, Linux)
```
brew tap akinoiro/tap
brew install ssh-list
```
## Construir desde el código fuente
Necesitarás tener instalados Rust y Cargo.
```
git clone https://github.com/akinoiro/ssh-list
cd ssh-list
cargo build --release
```
El binario se ubicará en target/release/
## Archivos de configuración
ssh-list crea automáticamente archivos para almacenar tus conexiones:
```
~/.ssh/ssh-list.json
```
y configuración de la aplicación:
```
~/.ssh/ssh-list_config.toml
```
## Appearance customization

![demo settingsgif](https://raw.githubusercontent.com/akinoiro/ssh-list/main/images/demo_settings.gif)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-17

---