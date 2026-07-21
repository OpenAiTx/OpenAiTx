## Jelly Music App (JMA)

Una interfaz de música ligera y elegante para Jellyfin. Diseñada para ser intuitiva y minimalista con gran atención al detalle, una aplicación web libre de desorden centrada en la reproducción de música. Usando la API de Jellyfin, proporciona acceso fluido a tu biblioteca musical personal. [Demo](https://stannnnn.github.io/jelly-app/login?demo=1)

**¿Buscas un reproductor de video?** Echa un vistazo a [Jelly Video App](https://github.com/Stannnnn/jelly-video-app/) - la versión enfocada en video para tu biblioteca Jellyfin!

<br/>

<div>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/light-variant.webp" alt="Variante clara" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/dark-variant.webp" alt="Variante oscura" width="49%">
</div>
<br/>

<details>
  <summary>Capturas de pantalla adicionales</summary>
  <br/>
  <b>Búsqueda en el panel lateral</b>
  <p>Busca pistas, artistas, álbumes, listas de reproducción, géneros</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-light-variant.png" alt="Búsqueda en panel lateral variante clara" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-dark-variant.png" alt="Búsqueda en panel lateral variante oscura" width="49%">
  <br/>
  <br/>
  <b>Resultados de búsqueda</b>
  <p>Ver resultados adicionales en una ventana dedicada</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-results-light-variant.webp" alt="Resultados de búsqueda variante clara" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-results-dark-variant.webp" alt="Resultados de búsqueda variante oscura" width="49%">
  <br/>
  <br/>
  <b>Artistas</b>
  <p>Incluye canciones más reproducidas, álbumes y otras colaboraciones</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/artist-light-variant.webp" alt="Artista variante clara" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/artist-dark-variant.webp" alt="Artista variante oscura" width="49%">
  <br/>
  <br/>
  <b>Listas de reproducción</b>
  <p>Vista de lista de reproducción, con su propia lista de pistas numerada</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/playlist-light-variant.webp" alt="Lista de reproducción variante clara" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/playlist-dark-variant.webp" alt="Lista de reproducción variante oscura" width="49%">
</details>
### Características

- **Diseño Elegante y Simple:** Una interfaz limpia y sin desorden que hace que la reproducción de música sea fácil y agradable. Construido con herramientas modernas como React para una experiencia rápida y fiable.
- **Compatible con Dispositivos:** Disfruta de una experiencia fluida, similar a una aplicación, tanto en móvil como en escritorio, instalable como PWA para acceso instantáneo.
- **Acceso Sincronizado a la Biblioteca:** Conéctate a tu servidor Jellyfin para explorar tu colección personal de música con facilidad.
- **Descubre Tus Favoritos:**
    - **Inicio:** Vuelve rápidamente a las pistas reproducidas recientemente, tus favoritas más escuchadas y medios añadidos recientemente.
    - **Artistas:** Explora las mejores canciones, álbumes y colaboraciones de cualquier artista en tu biblioteca.
    - **Listas de Reproducción:** Visualiza listas con una lista clara y numerada de canciones para una navegación rápida.
    - **Búsqueda Rápida:** Encuentra canciones, artistas, álbumes, listas o géneros sin esfuerzo con una búsqueda en la barra lateral o una página de resultados dedicada.
    - **Mezcla Instantánea:** Disfruta listas de reproducción curadas directamente desde tu biblioteca musical en una página independiente.
- **Cola:** Gestiona y reordena canciones fácilmente con la funcionalidad mejorada y optimizada de la Cola.
- **Fundido Cruzado:** Transiciones suaves entre canciones para una experiencia de escucha continua e inmersiva.
- **Precarga:** Precarga inteligentemente la siguiente pista para asegurar una reproducción fluida y sin interrupciones ni retrasos por buffering.
- **Letras Sincronizadas:** Disfruta tus canciones favoritas de una forma nueva con una interfaz espectacular que muestra letras perfectamente sincronizadas línea por línea mientras escuchas.
- **Obtención Inteligente:** Almacena en caché tu música eficientemente para una reproducción instantánea y fluida.
- **Sincronización Offline:** Descarga canciones individuales, álbumes completos, listas de reproducción o artistas para reproducción sin conexión.
    - **Auto-Sincronización:** Descarga automáticamente las canciones nuevas añadidas a cualquier lista, álbum o artista previamente guardado.
    - **Cola Persistente:** Las descargas se gestionan con una cola local que se reanuda sin problemas entre sesiones.
    - **Transcodificación o Streams Directos:** Soporta descargas tanto en calidad original como transcodificada según la tasa de bits seleccionada.
- **Soporte Docker:** Descarga y despliega la aplicación usando una imagen Docker preconstruida con una URL del servidor Jellyfin preconfigurada para una auto-hospedaje sin complicaciones.

### Instalación

La aplicación Jelly Music puede instalarse como una aplicación de escritorio dedicada, disponible en nuestra [página de lanzamientos de GitHub](https://github.com/Stannnnn/jelly-app/releases). También puedes obtener la última versión de producción desde allí y desplegarla en tu servidor web colocando el contenido de la carpeta archivada en un directorio accesible desde la web.
<br/>
También está disponible como **imagen docker** para un despliegue sencillo, consulta los detalles de docker a continuación.
<br/>
<br/>

[Yarn](https://classic.yarnpkg.com/lang/en/docs/install) (`npm i -g yarn`) es necesario si deseas compilar el proyecto o ejecutar el servidor de desarrollo por ti mismo.

#### Compilar desde el Código Fuente

1. Clona el repositorio:

    ```bash
    git clone https://github.com/Stannnnn/jelly-app.git
    ```
2. Instalar dependencias:
    ```bash
    yarn
    ```
3. Construya los archivos de producción:
    ```bash
    yarn build
    ```
4. Despliegue el contenido de la carpeta `dist` en un directorio accesible desde la web.

Alternativamente, puede ejecutar el servidor de desarrollo directamente: `yarn dev` o `yarn dev:nocache`

Si desea usar una ruta base para la aplicación distinta a la raíz (`/`), debe construirla manualmente estableciendo `URL_BASE_PATH` en la ruta base preferida.

Deje la configuración por defecto, o cambie [`config.json`](https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/config.json) según sea necesario. Las configuraciones se explican en la [Sección de Configuración de la Aplicación](#app-configuration).
El archivo `config.json` puede modificarse directamente en la aplicación ya construida. No es necesario reconstruir si solo cambia una variable de configuración.

### Docker

Puede alojar fácilmente Jelly Music App usando Docker con la imagen preconstruida de ghcr.io:

#### Descargar la imagen de docker

```bash
docker pull ghcr.io/stannnnn/jelly-music-app:latest
```

#### Ejecutar la imagen de Docker

```bash
docker run --rm -p 80:80 ghcr.io/stannnnn/jelly-music-app:latest
```

La imagen de Docker también se puede ejecutar en segundo plano añadiendo la bandera -d `docker run -d ...`

#### Ejecutar la imagen de docker con variables de configuración

```bash
docker run --rm \
    -e DEFAULT_JELLYFIN_URL=https://demo.jellyfin.org/stable \
    -e LOCK_JELLYFIN_URL=false \
    -p 80:80 ghcr.io/stannnnn/jelly-music-app:latest
```
<br/>

Las siguientes son las etiquetas disponibles para docker:

| Etiqueta | Descripción                 |
| -------- | --------------------------- |
| latest   | Rastrea la versión más reciente |
| main     | Rastrea la rama principal    |
| vX.X.X   | Etiquetas específicas de versión |

Ejemplo: `ghcr.io/stannnnn/jelly-music-app:latest`

#### Construcción del Contenedor Docker

También puedes construir Jelly Music App usando Docker.

1.  Construye la imagen de Docker:


    ```bash
    docker build . --tag jelly-music-app
    ```

2.  Ejecutar el contenedor de Docker:

    ```bash
    docker run --rm -p 80:80 jelly-music-app:latest
    ```

    También puede proporcionar la configuración utilizando variables de entorno.

    ```bash
    docker run --rm \
        -e DEFAULT_JELLYFIN_URL=https://demo.jellyfin.org/stable \
        -e LOCK_JELLYFIN_URL=false \
        -p 80:80 jelly-music-app:latest
    ```

#### Docker Compose

Para una gestión más sencilla de los contenedores, puedes usar Docker Compose. Se proporciona un archivo `docker-compose.yaml` en el repositorio con configuraciones predeterminadas adecuadas.

1.  Copia el archivo de entorno de ejemplo y personalízalo para tu configuración:

    ```bash
    cp .env.example .env
    ```

2.  Edite el archivo `.env` con la URL de su servidor Jellyfin y sus preferencias:

    ```env
    JELLYAPP_PORT=80
    JELLYAPP_DEFAULT_URL=https://demo.jellyfin.org/stable
    JELLYAPP_LOCK_URL=true
    ```

3.  Inicie el contenedor usando Docker Compose:

    ```bash
    docker-compose up -d
    ```

El archivo `docker-compose.yaml` utiliza variables de entorno con los siguientes valores predeterminados:

- `JELLYAPP_PORT`: Puerto externo a exponer (predeterminado: `80`)
- `JELLYAPP_DEFAULT_URL`: URL predeterminada del servidor Jellyfin (predeterminado: `https://demo.jellyfin.org/stable`)
- `JELLYAPP_LOCK_URL`: Bloquea la entrada de la URL de Jellyfin (predeterminado: `false`)

### Configuración de la Aplicación

La configuración de la aplicación puede modificarse editando el archivo `config.json` durante el proceso de compilación o en los archivos de la versión. Al usar Docker, las configuraciones pueden proporcionarse como variables de entorno. Las opciones de configuración disponibles son las siguientes:

- `DEFAULT_JELLYFIN_URL`: Establece la URL predeterminada del servidor Jellyfin que se carga en el primer acceso a la aplicación si no hay una URL almacenada en el Almacenamiento Local.
- `LOCK_JELLYFIN_URL`: Si se establece en `true`, elimina el campo de entrada de URL y aplica la URL predeterminada (`DEFAULT_JELLYFIN_URL`) para todas las conexiones, ideal para instancias autoalojadas vinculadas a un solo servidor.

### Contribuciones

Estamos abiertos a solicitudes de extracción, por favor mándelas a la rama `develop`. Si tienes alguna sugerencia o mejora, no dudes en abrir un issue o enviar una solicitud de extracción. ¡Tus contribuciones son bienvenidas y apreciadas!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-21

---