
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Estado](https://img.shields.io/badge/status-activo-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![Licencia](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Una aplicación Node.js contenerizada que sincroniza scrobbles de **Last.fm**, los almacena en una base de datos local **SQLite** y ofrece un panel web.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Proyecto

**Your LastFM** es una aplicación Node.js diseñada para **sincronizar automáticamente los scrobbleos de música** desde Last.fm. Conserva tu historial de escucha en una base de datos local SQLite y ofrece una interfaz web para la visualización de datos.

El proyecto está completamente containerizado con **Docker**, utilizando un punto de entrada automatizado para manejar la inicialización de la base de datos y la ejecución secuencial (primero la sincronización, luego el lanzamiento de la API web). También utiliza **PM2** como gestor de procesos dentro del contenedor para asegurar que el servicio web permanezca activo y resiliente.

## Características
### Panel Web Interactivo

- Interfaz web limpia y moderna para visualizar tu actividad musical.

### Sincronización Automática de Scrobbleos de Last.fm

- Obtiene y almacena periódicamente tu historial de escucha (scrobbleos) de Last.fm.
- Asegura que tus datos estén siempre actualizados sin intervención manual.

### Base de Datos Local de Historial Musical

- Persiste todos los scrobbleos en una base de datos SQLite local.
- Permite consultas rápidas y acceso offline a datos históricos de escucha.

### Vista de Scrobbleos Recientes

- Muestra tus pistas más recientes.
- Lógica inteligente de imagen de respaldo para pistas, álbumes y artistas.

### Comparación con Amigos (Vista de Compatibilidad)

- Compara tu gusto musical con amigos de Last.fm.
- Muestra el nivel de compatibilidad (Muy Bajo → Súper).
- Visualiza artistas, álbumes y pistas principales en común.
- Calcula y normaliza la compatibilidad basada en datos reales de escucha.

### Tarjetas Musicales Compartibles

- Genera imágenes dinámicas basadas en tus datos de escucha.
- Diseños optimizados para publicaciones en feeds y stories de instagram (9:16)

- Construido utilizando node-canvas para renderizado de imágenes del lado del servidor.

## Requisitos previos

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Instalación

### Cree un archivo `.env`

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---