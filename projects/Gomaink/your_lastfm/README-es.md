[![Estado](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![Licencia](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Una aplicación Node.js containerizada que sincroniza scrobbleos desde **Last.fm**, los almacena en una base de datos local **SQLite**, y ofrece un panel web.

<img width="1718" height="1066" alt="imagen" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />

---

## Proyecto

**Your LastFM** es una aplicación Node.js diseñada para **sincronizar automáticamente los scrobbleos de música** desde Last.fm. Conserva tu historial de escucha en una base de datos SQLite local y ofrece una interfaz web para la visualización de datos.

El proyecto está completamente containerizado con **Docker**, usando un punto de entrada automatizado para manejar la inicialización de la base de datos y la ejecución secuencial (Sincronizando primero, luego lanzando la API web). También utiliza **PM2** como gestor de procesos dentro del contenedor para asegurar que el servicio web permanezca activo y resiliente.

## Características
### Panel Web Interactivo

- Interfaz web limpia y moderna para visualizar tu actividad musical.

### Sincronización Automática de Scrobbles de Last.fm

- Recupera y almacena periódicamente tu historial de escucha (scrobbles) desde Last.fm.
- Garantiza que tus datos estén siempre actualizados sin intervención manual.

### Base de Datos Local de Historial Musical

- Persiste todos los scrobbles en una base de datos SQLite local.
- Permite consultas rápidas y acceso offline a datos históricos de escucha.

### Vista de Scrobbles Recientes

- Muestra tus pistas más recientes.
- Lógica inteligente de imágenes de respaldo para pistas, álbumes y artistas.

### Comparación con Amigos (Vista de Compatibilidad)

- Compara tu gusto musical con amigos de Last.fm.
- Muestra el nivel de compatibilidad (Muy Bajo → Súper).  
- Muestra los artistas, álbumes y pistas principales comunes.  
- Calcula y normaliza la compatibilidad basada en datos reales de escucha.  

### Tarjetas de Música Compartibles  

- Genera imágenes dinámicas basadas en tus datos de escucha.  
- Diseños optimizados para publicaciones en el feed e historias de Instagram (9:16)  
- Construido usando node-canvas para renderizado de imágenes del lado del servidor.  

## Requisitos Previos  

* [Docker](https://docs.docker.com/get-docker/)  
* [Docker Compose](https://docs.docker.com/compose/install/)  

## Instalación  

### Crear un archivo `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: Crea una cuenta de API [aquí](https://www.last.fm/api/account/create) para obtener tu clave de API.

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

En la terminal:
`docker compose up -d`

Luego acceder a:
```
http://localhost:1533
```
(o reemplace `localhost` con la IP de su servidor)

## Licencia

Este proyecto está licenciado bajo la Licencia MIT.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---