# getmic.ro

![Test](https://github.com/benweissmann/getmic.ro/workflows/Test/badge.svg)

La forma más rápida de instalar [Micro](https://micro-editor.github.io/)

```Bash
# local install just for your user
curl https://getmic.ro | bash
```

O, usando `wget` en lugar de `curl` y cualquier intérprete de `sh` en lugar de `bash`:

```Bash
# local install just for your user
wget -O- https://getmic.ro | sh
```

Este script instalará micro en el directorio en el que te encuentres. Para instalar en otro lugar (por ejemplo, /usr/local/bin), cambia a ese directorio y asegúrate de tener permisos de escritura, por ejemplo `cd /usr/local/bin; curl https://getmic.ro | sudo sh` así:

```Bash
# global install for all users
cd /usr/bin
curl https://getmic.ro | sudo sh
```

Este script también puede usar update-alternatives para registrar micro como un editor de texto del sistema.
Por ejemplo, esto permitirá que `crontab -e` abra el archivo cron con micro.

Para habilitar esta función, defina la variable `GETMICRO_REGISTER` o use la URL
`https://getmic.ro/r`. Tenga en cuenta que debe instalar micro en un directorio
accesible para todos los usuarios al hacer esto, típicamente /usr/bin:

```Bash
# global install for all users, registering with update-alternatives
cd /usr/bin
curl https://getmic.ro/r | sudo sh
```

> ¿No entiendes inglés? ¿Hablas francés? **Mira el [*LÉEME* en francés](https://raw.githubusercontent.com/benweissmann/getmic.ro/master/./README.fr.md)!**

## Uso avanzado

Hay un par de cosas más que puedes hacer con getmic.ro. A continuación se enumeran las variables de entorno que puedes elegir:

* `GETMICRO_HTTP=<COMANDO ...ARGS>`
    + Usa este comando con argumentos delimitados por espacios para descargar archivos de internet.
        - DEBE seguir redirecciones (a través de cabeceras HTTP Location).
        - DEBE imprimir el contenido del archivo resultante en stdout.
        - DEBE aceptar que el siguiente argumento sea la URL del archivo a descargar.
        - ES OPCIONAL que el comando también acepte un parámetro `--header` usado para un fallback no esencial de autenticación en GitHub.
    + Por ejemplo, para forzar el uso de `curl`, haz: `curl https://getmic.ro | GETMICRO_HTTP="curl -L" sh`
    + Por ejemplo, para forzar el uso de `wget`, haz: `wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" sh`
* `GETMICRO_PLATFORM=[freebsd32 | freebsd64 linux-arm | linux-arm64 | linux32 | linux64 | linux64-static | macos-arm64 | netbsd32 | netbsd64 | openbsd32 | openbsd64 | osx | win32 | win64]`
    + Esto anula manualmente el mecanismo de detección de plataforma y descarga los binarios para la plataforma que especifiques.
    + Un uso de esto es especificar `https://getmic.ro | GETMICRO_PLATFORM=linux64-static sh` cuando se usa una implementación libc incompatible como musl.
* `GETMICRO_REGISTER=[y | n]`
    + Indica si registrar micro con `update-alternatives` para que puedas usar micro como editor de texto del sistema sin problemas.
        - y => sí
        - n => no (el valor por defecto)
    + Si GETMICRO_REGISTER está definido pero el sistema no soporta `update-alternatives`, entonces esta opción se ignora silenciosamente.
    + Cuando está habilitado, getmicro debe ejecutarse con privilegios suficientes (típicamente el usuario root) para usar `update-alternatives`, de lo contrario getmicro terminará con un error.
    + Como atajo, puedes usar `https://getmic.ro/r` que define `GETMICRO_REGISTER=y`.

Juntándolo todo, la siguiente línea de comando siempre usaría wget, siempre instalaría los binarios linux32, y siempre registraría con `update-alternatives`:

```Bash
wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" GETMICRO_PLATFORM=linux32 GETMICRO_REGISTER=y sh
```

### Verificar la suma de verificación del script

Para verificar el script, puede descargarlo y calcular su suma de verificación. La suma de verificación sha256 es `d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35`.

```Bash
gmcr="$(curl https://getmic.ro)" && [ $(echo "$gmcr" | shasum -a 256 | cut -d' ' -f1) = d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35 ] && echo "$gmcr" | sh
```

Alternativamente, puede usar el siguiente método manual.

```Bash
# 1. Manually verify that this outputs d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35
curl https://getmic.ro | shasum -a 256

# 2. If #1 was successful, then execute getmicro
curl https://getmic.ro | sh
```

## Contribuir

¡Gracias por contribuir! Usamos el flujo de trabajo de pull request de Github: haz un fork de este repositorio, realiza tus cambios y luego envía un pull request. Hay un par de cosas que necesitarás hacer para que tu PR sea aceptado:

- Asegúrate de que todas las pruebas pasen. Github Actions reportará fallos en las pruebas en la página del PR una vez que lo abras.

- Si introduces un nuevo comportamiento, actualiza las pruebas de Github Actions (en [`.github/workflows/test.yml`](https://github.com/benweissmann/getmic.ro/blob/master/.github/workflows/test.yml)) para probar ese comportamiento.

- Si introduces nuevas opciones o comportamientos visibles para el usuario, actualiza los archivos README para documentar ese comportamiento (no traduzcas si no conoces el idioma del archivo de destino).

Si no estás seguro de cómo hacer alguna de estas cosas, ¡no dudes en abrir un PR con tu trabajo en progreso y las preguntas que tengas!

## Agradecimientos:

- Micro, por supuesto: https://micro-editor.github.io/

- Basado libremente en el Chef curl|bash: https://docs.chef.io/install_omnibus.html

- Arte ASCII cortesía de figlet: http://www.figlet.org/

<!--shasum=d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35-->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---