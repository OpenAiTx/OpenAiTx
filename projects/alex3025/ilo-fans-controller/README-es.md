<h1 align="center">Controlador de Ventiladores iLO</h1>

<p align="center">
  <img width="800" src="https://raw.githubusercontent.com/alex3025/ilo-fans-controller/main/screenshot.png" alt="Captura de pantalla de la página web">
  <br>
  <i>¡Gestiona fácilmente la velocidad de los ventiladores de tu servidor HP, desde cualquier lugar!</i>
</p>

---

<h3 align="center"> 🎉 ¡Muchas gracias por las <code>1.000+</code> descargas del contenedor! 🎉 </h3>

> ℹ **NOTA:** La versión v1.0.0 es una **reescritura completa** de la herramienta, ¡así que cualquier comentario es bienvenido!<br>
> Si encuentras algún error o tienes alguna sugerencia, por favor [abre un issue](https://github.com/alex3025/ilo-fans-controller/issues). ¡Gracias! 😄

## FAQ

### ¿Cómo funciona? 🛠

Esta herramienta es un **script PHP único** que utiliza la extensión `php-curl` para **obtener la velocidad actual de los ventiladores del servidor desde la API REST de iLO** y la extensión `php-ssh2` para **establecer la velocidad de los ventiladores usando la [interfaz SSH parcheada de iLO](#can-i-use-this-tool-with-my-hp-server-%EF%B8%8F).** También puedes **crear presets personalizados** para configurar una configuración específica de ventiladores con un solo clic, todo con una **interfaz web sencilla y limpia** hecha con [Alpine.js](https://alpinejs.dev/) y [TailwindCSS](https://tailwindcss.com/).

### ¿Puedo usar esta herramienta con mi servidor HP? 🖥️

Esta herramienta requiere un **firmware parcheado de iLO** que exponga a la interfaz SSH de iLO algunos comandos para manipular la velocidad de los ventiladores. Puedes encontrar más información sobre este parche en [este post de Reddit](https://www.reddit.com/r/homelab/comments/sx3ldo/hp_ilo4_v277_unlocked_access_to_fan_controls/).

Por ahora, el parche (y por tanto esta herramienta) solo funciona para **servidores Gen8 y Gen9 con iLO 4.**

> 🚫 Los servidores Gen10/11/12 con iLO 5/6/7 no son compatibles (y probablemente nunca lo serán).

### ¿Por qué PHP? 📄

En mi opinión, PHP es perfecto para este tipo de tareas donde necesitas hacer algo simple del lado del servidor y algo fácil de desplegar (solo necesitas un servidor web con PHP instalado).

### ¿Por qué hiciste esto? 🤔

¡Consulta mi [comentario original en r/homelab](https://www.reddit.com/r/homelab/comments/rcel73/comment/hnu3iyp/?utm_source=share&utm_medium=web2x&context=3) para conocer la historia detrás de esta herramienta!

### ¿Te gusta este proyecto? ¡Ofréceme una porción de pizza! 🍕

Si encontraste esta herramienta útil, considera ofrecerme una porción (o una pizza entera) usando [PayPal](https://paypal.me/alex3025) o [GitHub Sponsors](https://github.com/sponsors/alex3025) para apoyar mi trabajo. ¡Muchísimas gracias! 🙏

---

## Getting started with Docker / Docker Compose

If you already have a Docker environment, you can be up and running in minutes using the following command (obviously you need to change the value):

```sh
docker run -d --name ilo-fans-controller --restart always \
    -p 8000:80 \
    -e ILO_HOST='your-ilo-address' \
    -e ILO_USERNAME='your-ilo-username' \
    -e ILO_PASSWORD='your-ilo-password' \
    ghcr.io/alex3025/ilo-fans-controller:latest
```
O si lo prefieres, puedes usar `docker compose`, ya que también se proporciona el archivo [docker-compose.yaml](https://github.com/alex3025/ilo-fans-controller/blob/main/docker-compose.yaml).

**¡Revisa [`config.inc.php`](https://github.com/alex3025/ilo-fans-controller/blob/main/config.inc.php) para ver todas las variables de entorno disponibles!**

---

> ⚠ **¡IMPORTANTE!** ⚠
>
> De nuevo, esta herramienta funciona gracias a un **[firmware iLO parcheado](#can-i-use-this-tool-with-my-hp-server-%EF%B8%8F)** que expone a la interfaz SSH de iLO algunos comandos para manipular las velocidades de los ventiladores.
>
> **¡Este parche es necesario para usar esta herramienta!**

## Instalación manual

### La siguiente guía se ejecutó en

* Un servidor **HP ProLiant DL380e Gen8**
* **iLO 4 parcheado** Avanzado **v2.77** (07 de diciembre de 2020)
* Un contenedor Proxmox (LXC) ejecutando **Ubuntu 22.04**
* **Apache 2** y **PHP 8.1**

### Preparando el entorno

1. Actualiza el sistema:


    ```sh
    sudo apt-get update && sudo apt-get upgrade
    ```

2. Instale los paquetes requeridos (`apache2`, `php`, `php-curl` y `php-ssh2`):

    ```sh
    sudo apt-get install apache2 php php-curl php-ssh2
    ```

### Descargando la herramienta

1. Descargue y extraiga el código fuente más reciente usando `wget` y `tar`:

    ```sh
    wget -qL https://github.com/alex3025/ilo-fans-controller/archive/refs/heads/main.tar.gz -O - | tar -xz
    ```

2. Ingrese al directorio:

    ```sh
    cd ilo-fans-controller-main
    ```

### Configuración e instalación de la herramienta

1. Abra el archivo `config.inc.php` en su editor de texto favorito y cambie las variables según su configuración.

    > ℹ **NOTA:** Recuerde que `$ILO_HOST` es la dirección IP de su interfaz iLO, no del servidor en sí.

    > ℹ **NOTA:** Se recomienda crear un nuevo usuario iLO con los privilegios mínimos necesarios para acceder a la interfaz SSH y a la API REST (Acceso a la Consola Remota).

    Aquí hay un ejemplo:

    ```php
    /*
    ILO ACCESS CREDENTIALS
    --------------
    These are used to connect to the iLO
    interface and manage the fan speeds.
    */

    $ILO_HOST = '192.168.1.69';
    $ILO_USERNAME = 'Administrator';
    $ILO_PASSWORD = 'AdministratorPassword1234';
    ```

2. Cuando termines, crea un nuevo subdirectorio en el directorio raíz de tu servidor web (usualmente `/var/www/html/`) y copia `config.inc.php`, `ilo-fans-controller.php` y `favicon.ico` en él:

    ```sh
    sudo mkdir /var/www/html/ilo-fans-controller
    sudo cp config.inc.php ilo-fans-controller.php favicon.ico /var/www/html/ilo-fans-controller/
    ```

    Luego renombre `ilo-fans-controller.php` a `index.php` (para que funcione sin especificar el nombre del archivo en la URL):

    ```sh
    sudo mv /var/www/html/ilo-fans-controller/ilo-fans-controller.php /var/www/html/ilo-fans-controller/index.php
    ```
3. ¡Eso es todo! Ahora puedes acceder a la herramienta en `http://<tu-ip-servidor>/ilo-fans-controller/` (o `http://<tu-ip-servidor>/ilo-fans-controller/index.php` para solicitudes API).

> ℹ **NOTA:** Si el servidor web donde instalaste esta herramienta **será accesible desde fuera de tu red**, recuerda **configurar algún tipo de autenticación** (como Basic Auth) para evitar la _gestión no autorizada de ventiladores a las 2AM_.

---

## Solución de problemas

Lo primero que debes hacer cuando encuentres un problema es **revisar los registros**.

> Si usas Apache, los errores de PHP se registran en el archivo `/var/log/apache2/error.log`.

Si crees que encontraste un error, por favor [abre un issue](https://github.com/alex3025/ilo-fans-controller/issues) y lo revisaré.

A continuación puedes encontrar algunos problemas comunes y sus soluciones.

### Los presets no se guardan

Si ves el siguiente error en los registros cuando creas un nuevo preset:


```log
PHP Warning:  file_put_contents(presets.json): Failed to open stream: Permission denied in .../index.php on line X
```

Esto probablemente se deba a que el archivo `presets.json` no es modificable por el usuario del servidor web.<br>
Para solucionarlo, ejecute el siguiente comando para cambiar el propietario del archivo a `www-data` (el usuario predeterminado de Apache):

```sh
sudo chown www-data:www-data /var/www/html/ilo-fans-controller/presets.json
```

---

## Documentación de la API

La herramienta expone una API sencilla que se puede usar para:

* Obtener las velocidades actuales de los ventiladores desde iLO
* Configurar las velocidades de los ventiladores
* Obtener todos los presets
* Crear un preset

> Los siguientes ejemplos usan cURL para mostrar cómo usar la API, pero puedes usar cualquier otra herramienta que desees.

### APIs de ventiladores

Para usar las siguientes APIs necesitas añadir `?api=fans` al final de la URL.

#### Obtener velocidades de ventiladores (`GET`)

<details>
<summary>Estructura JSON (respuesta)</summary>

```jsonc
{
    "Fan 1": 85,
    "Fan 2": 48,
    "Fan 3": 69,
    "Fan 4": 18,
    "Fan 5": 44,
    "Fan 6": 96
}
```

</details>

<details>
<summary>Ejemplo de cURL</summary>

```sh
curl 'http://<server ip>/ilo-fans-controller/index.php?api=fans'
```

</details>

#### Configurar las velocidades del ventilador (`POST`)

<details>
<summary>Ejemplo de estructura JSON</summary>

```jsonc
{
    "action": "fans",
    // You can use either an object or a single number value (that will be applied to all fans):
    // Example: `fans: { ... }` or `fans: 50`
    "fans": {
        "Fan 1": 40,
        "Fan 2": 23,
        "Fan 5": 70
        // ...
    }
}
```

</details>

<details>
<summary>Ejemplo de cURL</summary>

```sh
curl -X POST 'http://<server ip>/ilo-fans-controller/index.php' \
    -H 'Content-Type: application/json' \
    -d '{"action": "fans", "fans": 50}'
```

Este comando establecerá todos los ventiladores al 50%.<br>
_Yo personalmente uso este comando para reducir automáticamente la velocidad de los ventiladores cuando mi servidor arranca._
</details>

### APIs predefinidas

Para usar las siguientes APIs necesitas agregar `?api=preset` al final de la URL.

#### Obtener todos los preajustes (`GET`)

<details>
<summary>Estructura JSON (respuesta)</summary>

```jsonc
[
    {
        "name": "Silent Mode",
        "speeds": [15]  // Like when setting the speeds, this number applies to all fans.
    },
    {
        "name": "Normal Mode",
        "speeds": [50]
    },
    {
        "name": "Turbo Mode",
        "speeds": [100]
    },
    {
        "name": "My Custom Preset",
        "speeds": [10, 10, 25, 30, 10, 15]  // Here you can see the different speeds for each fan.
    }
]
```

</details>

<details>
<summary>Ejemplo de cURL</summary>

```sh
curl 'http://<server ip>/ilo-fans-controller/index.php?api=presets'
```

</details>

#### Crear un preajuste (`POST`)

<details>
<summary>Ejemplo de estructura JSON</summary>

```jsonc
{
    "action": "presets",
    // WARNING: The API will replace all the saved presets with the new data!
    // To add a preset you should get all the presets first and then add the new one to the existing array.
    "presets": [
        {
            "name": "Silent Mode",
            "speeds": [15]
        },
        {
            "name": "Normal Mode",
            "speeds": [50]
        },
        {
            "name": "Turbo Mode",
            "speeds": [100]
        },
        {
            "name": "My Custom Preset",
            "speeds": [10, 10, 25, 30, 10, 15]
        }
    ]
}
```

</details>

<details>
<summary>Ejemplo de cURL</summary>

```sh
curl -X POST 'http://<server ip>/ilo-fans-controller/index.php' \
    -H 'Content-Type: application/json' \
    -d '{"action": "presets", "presets": [{"My Custom Preset 1": [50], "My Custom Preset 2": [10, 20, 30, 30, 20, 10]}]}'
```

</detalles>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-10

---