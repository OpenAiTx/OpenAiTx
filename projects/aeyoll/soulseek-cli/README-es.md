# Soulseek CLI

[![Estado de la compilación](https://travis-ci.org/aeyoll/soulseek-cli.svg?branch=develop)](https://travis-ci.org/aeyoll/soulseek-cli)

Un cliente Soulseek CLI.

Requisitos
---

NodeJS >= 20

Instalación
---

```sh
npm install -g soulseek-cli
```

### En Linux

Una de las dependencias de soulseek-cli ([node-keytar](https://github.com/atom/node-keytar)) usa libsecret, por lo que necesitas instalarla antes de ejecutar `npm install`.

Dependiendo de tu distribución, deberás ejecutar el siguiente comando:

- Debian/Ubuntu: `sudo apt-get install libsecret-1-dev`
- Basado en Red Hat: `sudo yum install libsecret-devel`
- Arch Linux: `sudo pacman -S libsecret`

### En Linux sin interfaz gráfica

En Linux, [node-keytar](https://github.com/atom/node-keytar) utiliza la API Linux SecretService. Es posible usar el backend SecretService en sistemas Linux sin servidor X11 disponible (solo se requiere D-Bus). En este caso, puedes hacer lo siguiente (el ejemplo es en un entorno Debian):

#### Instalar dependencias

```sh
apt install gnome-keyring --no-install-recommends # Install the GNOME Keyring daemon. "no-install-recommends" prevents X11 install
```

#### Uso

```sh
dbus-run-session -- $SHELL # Start a D-Bus session
echo 'root' | /usr/bin/gnome-keyring-daemon -r -d --unlock # Unlock GNOME Keyring
soulseek ... # Use soulseek-cli normally
```
Comandos
---

### Iniciar sesión

Antes de poder buscar, necesitas iniciar sesión.

Uso:

```
soulseek login
```

Se le solicitará su inicio de sesión y contraseña de Soulseek. Las credenciales se almacenan y cifran en el llavero de su sistema.

Alternativamente, también puede iniciar sesión configurando variables de entorno:

```sh
export SOULSEEK_ACCOUNT=youraccount
export SOULSEEK_PASSWORD=yourpassword
soulseek download "..."
```

### Descargar

Descargar con la consulta requerida.

Uso:
```
soulseek download|d [options] [query...]
```

:warning: Este comando solía llamarse `search` en versiones anteriores a la 0.1.0.

Opciones:

| Opción                    | Descripción                                                                   |
| ------------------------- | ----------------------------------------------------------------------------- |
| -d --destination <folder> | destino de las descargas                                                     |
| -q --quality <quality>    | mostrar solo mp3 con una calidad definida                                    |
| -m --mode <mode>          | filtrar el tipo de archivos que desea (disponible: "mp3", "flac", por defecto: "mp3") |
| -h --help                 | mostrar ayuda para el comando                                                |

Ejemplos:

```sh
soulseek download "Your query" # Download in the current folder
soulseek download "Your query" --destination=/path/to/directory # Download in a defined folder (relative or absolute)
soulseek download "Your query" --quality=320 # Filter by quality
soulseek download "Your query" --mode=flac # Filter by file type
```

### Consulta

Buscar con la consulta requerida, pero no descargar nada. Si se encuentra un resultado, el código de retorno será 0. De lo contrario,
el código de retorno será 1 (útil para scripts)

Uso:

```
soulseek query|q [options] [query...]
```

Opciones:

| Opción                 | Descripción                                                                  |
| ---------------------- | ---------------------------------------------------------------------------- |
| -q --quality <quality> | mostrar solo mp3 con una calidad definida                                   |
| -m --mode <mode>       | filtrar el tipo de archivos que deseas (disponibles: "mp3", "flac", por defecto: "mp3") |
| -h --help              | mostrar ayuda para el comando                                               |



Contribución
---

Ver [CONTRIBUTING.md](https://raw.githubusercontent.com/aeyoll/soulseek-cli/main/CONTRIBUTING.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---