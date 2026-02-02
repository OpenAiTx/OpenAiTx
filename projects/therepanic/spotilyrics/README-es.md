<div align="center">
  <br/>
  <img src="https://raw.githubusercontent.com/therepanic/spotilyrics/master/logo.png" width="350" alt="Logotipo de Spotilyrics"/>
  <p><i>Ve letras sincronizadas de Spotify dentro de VS Code mientras programas.</i></p>
<p>
  <a href="https://marketplace.visualstudio.com/items?itemName=therepanic.spotilyrics"><img src="https://img.shields.io/badge/VS%20Code-Extension-blue?style=flat&logo=visualstudiocode" /></a>
  <a href="https://developer.spotify.com/documentation/web-api"><img src="https://img.shields.io/badge/Spotify-API-1DB954?style=flat&logo=spotify" /></a>
  <a href="https://lrclib.net"><img src="https://img.shields.io/badge/Lyrics-LRClib-orange?style=flat" /></a>
  <a href="https://news.ycombinator.com/item?id=45087905"><img src="https://img.shields.io/badge/Hacker%20News-Discuss-orange?style=flat&logo=ycombinator" /></a>
  <a href="https://unlicense.org/"><img src="https://img.shields.io/badge/License-Unlicensed-red?style=flat" /></a>
</p>
</div>

---

## ✨ Características

- 📌 **Sincronización en vivo de letras** con la reproducción de Spotify.
- 🎨 Colores de letras auto-tematizados desde la portada del álbum (a través de `colorthief`).
- 🖥️ Suave **vista en panel lateral** – código a la izquierda, letras a la derecha.
- 📱 **Modo móvil** – líneas negras no reproducidas, líneas blancas reproducidas (como la app móvil de Spotify).
- 🔑 Inicio de sesión simple **único** usando tu propio Client ID de Spotify.
- 🚪 Comando rápido de cierre de sesión para reiniciar la sesión.
- ⚡ Establece un **tamaño máximo de caché de pistas** para la sincronización de letras.

---

## 📸 Demostración

## <img src="https://raw.githubusercontent.com/therepanic/spotilyrics/master/demo.png"/>

## ⚡️ Instalación

1. Abre **VS Code** → Extensiones → busca `spotilyrics` o [instala desde VS Code Marketplace](https://marketplace.visualstudio.com/items?itemName=therepanic.spotilyrics).

2. Ejecuta el comando:

```
Show Spotify Lyrics via Spotilyrics
```

---

## 🔑 Autenticación (configuración única)

1. Ve a [Spotify Developer Dashboard](https://developer.spotify.com/dashboard).
2. Crea una aplicación → copia el **Client ID**.
3. **Importante:** configura el **Redirect URI** de tu app en: `http://127.0.0.1:8000/callback`
4. Ejecuta el comando `Show Spotify Lyrics via Spotilyrics`.
5. Pega tu **Client ID** en el panel e inicia sesión.
6. ¡Disfruta de las letras sincronizadas mientras codificas! 🎶

> ℹ️ ¿Por qué? – Para respetar los límites de tasa de la API de Spotify, necesitas tu propio ID.

---

## ⌨️ Comandos

- `Show Spotify Lyrics via Spotilyrics` (`spotilyrics.lyrics`) – abrir panel de letras sincronizadas.
- `Toggle Mobile Mode` (`spotilyrics.toggleMobileMode`) – cambiar entre modo normal y móvil.
- `Logout from Spotilyrics` (`spotilyrics.logout`) – limpiar sesión y reautenticar cuando sea necesario.
- `Set Tracks Cache Max Size` (`spotilyrics.setTracksCacheMaxSize`) – configurar el número máximo de pistas en caché para letras.

---

## ⚙️ Tecnologías

- [Spotify Web API](https://developer.spotify.com/documentation/web-api/)
- [LRClib](https://lrclib.net/) para letras con sincronización temporal
- [colorthief](https://lokeshdhakar.com/projects/color-thief/) para tema basado en la portada
- TypeScript + VS Code WebView

---

## 📜 Licencia

Este proyecto está licenciado como **No Licenciado**.  
Siéntete libre de usar, modificar y remezclar – pero sin garantías 😉

---

<div align="center">
<sub>Hecho con ❤️ por therepanic. Programa duro, vibra más duro 🎧</sub>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-02

---