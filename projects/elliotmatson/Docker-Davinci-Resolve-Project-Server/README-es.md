# Servidor de Proyectos Davinci Resolve

![Lint](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/lint.yml/badge.svg)
![Healthcheck](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/stack-healthcheck.yml/badge.svg)
![Docker Build](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/docker.yml/badge.svg)

Servidor de proyectos Resolve simple con copias de seguridad automáticas

## Tabla de Contenidos

- [Servidor de Proyectos Davinci Resolve](#davinci-resolve-project-server)
  - [Tabla de Contenidos](#table-of-contents)
  - [Introducción](#introduction)
    - [Características](#features)
  - [Configuración](#configuration)
    - [Base de Datos](#database)
    - [Copias de Seguridad](#backups)
    - [PGAdmin](#pgadmin)
    - [Ubicaciones de Volúmenes](#volume-locations)
  - [Instalación](#installation)
    - [Instalación en QNAP](#qnap-installation)
    - [Synology](#synology)
    - [Linux](#linux)
  - [Diferentes versiones de PostgreSQL](#different-postgresql-versions)
    - [Configuración de un Servidor de Proyectos PostgreSQL 9.5 o 11](#setting-up-a-postgresql-95-or-11-project-server)
  - [Agradecimientos](#thanks)

## Introducción

Existen muchas formas de alojar un servidor de proyectos Resolve, pero cada una tiene su propio conjunto de problemas. El servidor oficial de proyectos requiere copias de seguridad manuales, y otras opciones pueden ser complicadas para quienes no tienen acceso a un equipo de TI. ¡Esperamos que esta sea una solución más confiable y sencilla para equipos pequeños!

### Características

- **Ligero** - Basado en Docker, por lo que no requiere una máquina o VM completa con macOS o Windows.
- **Independiente de la Plataforma** - puede instalarse en Windows, Mac, Linux, QNAP, Synology, RPi, realmente en cualquier cosa que pueda ejecutar Docker.
- **Compatible con las funciones existentes de copia de seguridad/restauración de Resolve** - Todos los archivos de copia de seguridad usan la sintaxis estándar de archivo \*.backup de Resolve, y pueden restaurarse desde la interfaz de usuario de Resolve.
- **Servidor PGAdmin incorporado** - PGAdmin es una herramienta para administrar un servidor PostgreSQL, útil para diagnosticar problemas y migrar/actualizar servidores completos.

## Configuración

Hay algunas cosas que necesitaremos editar en la parte superior del archivo docker-compose.yml para configurar nuestra instalación:

```yaml
---
version: "3.8"
x-common:
  database: &db-environment
    POSTGRES_DB: database
    POSTGRES_USER: &pg-user postgres
    POSTGRES_PASSWORD: DaVinci
    TZ: America/Chicago
    POSTGRES_LOCATION: &db-location "???:/var/lib/postgresql/data"
  backup: &backup-environment
    SCHEDULE: "@daily"
    BACKUP_KEEP_DAYS: 7
    BACKUP_KEEP_WEEKS: 4
    BACKUP_KEEP_MONTHS: 6
    BACKUP_LOCATION: &bk-location "???:/backups"
  admin: &admin-environment
    PGADMIN_DEFAULT_EMAIL: admin@admin.com
    PGADMIN_DEFAULT_PASSWORD: root
    PGADMIN_PORT: &pgadmin-port "3001:80"
```

### Base de Datos

Para configurar el servidor en sí, querrás configurar las variables de entorno a continuación:
| Variable de Entorno |Significado|
|---|---|
| POSTGRES_DB | Nombre de tu base de datos. Ponle el nombre que desees. |
| POSTGRES_USER | Nombre de usuario que usarás para conectarte a tu base de datos. El valor predeterminado en Resolve es "postgres" |
| POSTGRES_PASSWORD | Contraseña que usarás para conectarte a tu base de datos. El valor predeterminado en Resolve es "DaVinci" |
| TZ | Tu zona horaria, aquí hay [una lista](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)|
| POSTGRES_LOCATION | Ubicación donde se almacenará tu base de datos. Ver [Ubicaciones de Volumen](#volume-locations) |

### Copias de Seguridad

Para configurar las copias de seguridad, querrás configurar las variables a continuación:
| Variable de Entorno |Significado|
|---|---|
| SCHEDULE | Esta es una [cadena cron](https://www.freeformatter.com/cron-expression-generator-quartz.html) para la frecuencia con la que se crean las copias de seguridad. Puede ser "@daily", "@every 1h", etc. |
| BACKUP_KEEP_DAYS | Número de copias de seguridad diarias que se conservarán antes de eliminarse. |
| BACKUP_KEEP_WEEKS | Número de copias de seguridad semanales que se conservarán antes de eliminarse. |
| BACKUP_KEEP_MONTHS | Número de copias de seguridad mensuales que se conservarán antes de eliminarse. |
| BACKUP_LOCATION | Ubicación donde se almacenarán tus copias de seguridad. Ver [Ubicaciones de Volumen](#volume-locations) |

### PGAdmin

Para configurar PGAdmin, querrás configurar las variables a continuación:
| Variable de Entorno |Significado|
|---|---|
| PGADMIN_DEFAULT_EMAIL | Correo electrónico usado para iniciar sesión en PGAdmin. El valor predeterminado es "admin@admin.com" |
| PGADMIN_DEFAULT_PASSWORD | Contraseña usada para iniciar sesión en PGAdmin. El valor predeterminado es "root" |
| PGADMIN_PORT | Cadena que configura el puerto para exponer PGAdmin. La sintaxis es "TU_PUERTO:80" |

### Ubicaciones de Volumen

La ubicación de tu base de datos y copias de seguridad depende de la plataforma en la que estés instalando. Necesitarás la ruta completa a la carpeta donde deseas almacenarlas. En un NAS QNAP, por ejemplo, si quisiera usar una carpeta llamada "Backups" dentro de una carpeta compartida llamada "Videos" para la ubicación de mis copias de seguridad, la ruta sería `/shares/Videos/Backups/`, y mi valor `BACKUP_LOCATION` se vería así:

```yaml
BACKUP_LOCATION: &bk-location "/shares/Videos/Backups/:/backups"
```

En Ubuntu, si quisiera usar una carpeta llamada "database" en el directorio home del usuario llamado "johndoe" para la ubicación de mi base de datos, la ruta sería `/home/johndoe/database/`, y mi valor de `POSTGRES_LOCATION` se vería así:

```yaml
POSTGRES_LOCATION: &db-location "johndoe/database/:/var/lib/postgresql/data"
```
Recomiendo poner su base de datos en un SSD, la velocidad de acceso será notablemente más lenta en un disco giratorio.

Una vez que haya configurado estos ajustes, guarde su archivo docker-compose.yml modificado y continúe con la instalación.

## Instalación

### Instalación en QNAP

Instalar en un NAS QNAP es relativamente sencillo. Una nota, por favor coloque los archivos de la base de datos en un SSD. Me lo agradecerá después.

1. Si aún no lo tiene, instale Container Station desde la tienda de aplicaciones de QNAP.
2. En Container Station, haga clic en "Crear", luego haga clic en "Crear aplicación".
3. Nombre su aplicación como desee (por ejemplo, ResolveServer).
4. Copie/pegue su archivo docker-compose.yml modificado, presione "Validar YAML" para probarlo y si pasa, haga clic en "Crear".
5. Container Station descargará los archivos necesarios y arrancará la aplicación. Una vez terminado, debería poder conectar Resolve a la dirección IP de su QNAP usando el nombre de la base de datos y las credenciales.

### Synology

Consulte [esta discusión](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/discussions/15#discussioncomment-4615278)

### Linux

1. Siga las [instrucciones de instalación de Docker para su distribución Linux](https://docs.docker.com/engine/install/)
2. Instale [Docker Compose](https://docs.docker.com/compose/install/)
3. Mueva su archivo docker-compose.yml modificado a una carpeta en su máquina Linux, luego navegue a esa carpeta en la terminal.
4. Ejecute:
   `docker-compose up -d`
5. Docker-compose descargará los archivos que necesita y arrancará la aplicación. Una vez terminado, debería poder conectar Resolve a la dirección IP de su instancia de servidor Linux usando el nombre de la base de datos y las credenciales.

## Diferentes versiones de PostgreSQL

Generalmente, Resolve no es muy tolerante con versiones de PostgreSQL incompatibles. Resolve 18 usa PostgreSQL 13, que es la versión predeterminada en este repositorio. Resolve 17 y anteriores usan PostgreSQL 9.5. Desafortunadamente, la versión principal 9.5 está en EOL, y la 9.5.4 en particular tiene muchas vulnerabilidades que la hacen insegura.
Como la mayoría de las personas aún usan las credenciales predeterminadas de Resolve para su servidor, la seguridad generalmente no es la mayor preocupación, pero si está intentando asegurar su servidor de proyectos con una versión antigua de Resolve, querrá cambiar a una versión soportada de PostgreSQL.

Resolve 17 y anteriores aún usan una función heredada que fue eliminada en PostgreSQL 12, por lo que la última versión principal que se puede usar es la 11, que se mantendrá hasta el 9 de noviembre de 2023.

### Configuración de un servidor de proyectos PostgreSQL 9.5 o 11

Para configurar un servidor PostgreSQL 9.5 o 11 en lugar del 13, hay 2 líneas que deben cambiarse en docker_compose.yml:


```yaml
services:
  postgres:
    image: postgres:13
    ...
  pgbackups:
    image: prodrigestivill/postgres-backup-local:13
    ...
...
```
a lo siguiente:


```yaml
services:
  postgres:
    image: postgres:9.5
    ...
  pgbackups:
    image: prodrigestivill/postgres-backup-local:9.5
    ...
...
```

## Gracias

-[prodrigestivill](https://github.com/prodrigestivill/) por su [imagen docker de respaldo de PostgreSQL](https://github.com/prodrigestivill/docker-postgres-backup-local)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---