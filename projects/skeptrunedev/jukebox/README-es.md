<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=skeptrunedev&project=jukebox&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve Logo">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Docker Pulls" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="GitHub stars" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="Follow on X (Twitter)" />
  </a>
</p>

---
# Convierte Cualquier Dispositivo en un Jukebox Colaborativo

**Jukebox** te permite crear al instante una lista de reproducción compartida con amigos—sin app, sin registro, sin anuncios. Solo crea una caja, comparte un enlace y comienza a agregar canciones juntos. ¡Perfecto para fiestas, viajes por carretera o cualquier reunión de grupo!

- 🌐 **Alternativa de Código Abierto a las Listas Colaborativas de Spotify**
- 🕵️ **No Requiere Cuenta**: Úsalo de forma anónima—sin registro ni correo electrónico
- ✨ **Comparte un Enlace, Agrega Canciones Juntos**: Todos pueden contribuir en tiempo real
- 🚀 **No Requiere Descarga de App**: Funciona en cualquier dispositivo, directamente en tu navegador
- 🎵 **Integración con YouTube**: Busca y reproduce casi cualquier canción al instante
- 📱 **Amigable con Móviles**: Diseñado para teléfonos, tablets y computadoras de escritorio
- ⚖️ **Cola Justa**: Las canciones se ordenan automáticamente para que todos tengan un turno
- 🆓 **100% Gratis, Sin Anuncios**

---

## Pruébalo Ahora

1. **Crea un Jukebox**: Visita la página principal y crea una nueva caja
2. **Comparte el Enlace**: Envía el enlace de invitación a tus amigos
3. **Agrega Canciones**: Busca en YouTube o agrega canciones manualmente
4. **Reproduce Música**: Usa el reproductor integrado para escuchar juntos

---
## Características

- Listas de reproducción colaborativas: Añade, encola y reproduce canciones en grupo
- Uso anónimo: No requiere inicio de sesión ni cuenta
- Búsqueda y reproducción en YouTube: Accede a una enorme biblioteca musical
- Interfaz móvil y adaptable
- Código abierto (Licencia MIT)
- Fácil despliegue con Docker

### Despliegues con Docker Compose

Inicia todos los servicios:

```bash
docker-compose up -d
```

Vuelve a desplegar los servicios sin tiempo de inactividad después de actualizar las imágenes:

```bash
bash ./redeploy.sh
```
---

## Primeros Pasos

### Requisitos Previos

- Node.js 16+
- npm o yarn
- Clave de API de YouTube Data API v3 (gratuita de Google)

### Configuración de la API de YouTube

1. Ve a la [Google Cloud Console](https://console.cloud.google.com/)
2. Crea un nuevo proyecto o selecciona uno existente
3. Habilita la **YouTube Data API v3**
4. Crea credenciales (Clave de API)
5. Copia tu clave de API

### Instalación
```bash
# Clona el repositorio
git clone <tu-url-del-repositorio>
cd jukebox

# Instala las dependencias del servidor
cd server
yarn install

# Instala las dependencias del frontend
cd ../frontend
yarn install

# Configura las variables de entorno
cd ../server
cp .env.example .env
# Edita .env y agrega tu clave de API de YouTube

# Ejecuta las migraciones de la base de datos
```
yarn migrate

# Inicia los servidores de desarrollo
# Backend:
cd server
yarn dev
# Worker:
cd server
yarn dev:worker
# Frontend (en una nueva terminal):
cd frontend
yarn dev
```

---

## Licencia

MIT

---
## Contribuir y Comentarios

- Abre un issue o pull request en [GitHub](https://github.com/skeptrunedev/jukebox)
- ¿Solicitudes de funciones? Manda un DM a [@skeptrune en X (Twitter)](https://twitter.com/skeptrune)

---

## Registro de cambios

Consulta el [Registro de cambios](https://jukebox.skeptrune.com#changelog) para las últimas actualizaciones y características.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---