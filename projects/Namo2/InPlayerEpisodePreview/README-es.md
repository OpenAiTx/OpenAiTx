<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <p>Las siguientes traducciones fueron generadas automáticamente usando IA. Tenga en cuenta que pueden incluir inexactitudes o hacer referencia a versiones anteriores de este archivo README.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Vista previa de episodios en el reproductor
====================
## 📄 Acerca de
Este complemento añade una lista de episodios al reproductor de video, lo que te permite previsualizar cada episodio de la serie de TV sin tener que salir del reproductor.

Esta modificación es compatible con los siguientes clientes:
* [Cliente web de Jellyfin](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) Cliente de escritorio

## ✨ Características
* Listar todos los episodios de una temporada
* Cambiar entre temporadas
* Muestra el título del episodio, descripción, miniatura y progreso de reproducción
* Muestra detalles del episodio como la clasificación de la comunidad
* Marcar episodios como vistos o favoritos
* Iniciar un nuevo episodio
* Debería funcionar con temas personalizados

## 📸 Vista previa
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Tema utilizado: (SkinManager) Kaleidochromic
<br>
Esta vista previa no muestra los nuevos botones para marcar un episodio como completado o favorito.

## 🔧 Instalación

### Cliente Web de Jellyfin (Servidor)

> [!NOTA]
> Se recomienda encarecidamente tener instalado al menos la versión v2.2.1.0 de [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation). ¡Esto ayuda a evitar problemas de permisos al modificar index.html en cualquier tipo de instalación!
<details open>
<summary> Ver instrucciones... </summary>

1. Agrega el manifiesto `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` como un repositorio de plugins de Jellyfin en tu servidor.
2. Instala el plugin `InPlayerEpisodePreview` desde el repositorio.
3. Reinicia el servidor Jellyfin.
</details>

### Cliente de escritorio Jellyfin Media Player (JMP) (Obsoleto)
<details>
<summary> Ver instrucciones... </summary>

**Obsoleto desde la versión JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

Debido a que el nuevo cliente JMP utiliza el reproductor web actual directamente desde el servidor, ya no es necesario realizar cambios directos en el código del cliente.

Esta es la forma recomendada de instalar el script en el cliente de escritorio.
Si no te sientes cómodo editando el archivo nativeshell.js tú mismo (pasos 3 a 6), puedes descargar la versión completa en su lugar, que ya incluye el script añadido al archivo nativeshell.js.
Aún no está claro si podría haber problemas potenciales al reemplazar el archivo nativeshell.js con el de la versión completa, por lo que se recomienda seguir todos los pasos a continuación.

1. Descarga la última versión [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) o [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (incluye el script ya añadido al archivo nativeshell.js)
2. Extrae el archivo zip en tu directorio de Jellyfin (por ejemplo: C:\Program Files\Jellyfin\Jellyfin Media Player)
3. Dentro de tu directorio de Jellyfin, sigue la ruta de carpetas "web-client\extension"
4. Abre el archivo "nativeshell.js" en un editor de texto.
5. Dentro del archivo, encuentra la sección `const plugins = [];`. Agrega una nueva línea al inicio de la lista y pega `'inPlayerEpisodePreviewPlugin',`. La sección ahora debería verse similar a esto:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Guarda el archivo y reinicia el cliente JMP.
</details>

## 💡 Solución de problemas

### 1. El botón de vista previa no es visible
Esto probablemente está relacionado con permisos incorrectos para el archivo `index.html`.

<details>
<summary> Ver una lista de posibles soluciones... </summary>

#### 1.1 Evita este problema usando el plugin [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation).

#### 1.2 Cambia la propiedad dentro de un contenedor docker
Si ejecutas jellyfin en un contenedor docker, puedes cambiar la propiedad con el siguiente comando
(reemplaza jellyfin por el nombre de tu contenedor, user y group por el usuario y grupo de tu contenedor):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Puedes ejecutar esto como un trabajo cron al iniciar el sistema.
(Gracias a [muisje](https://github.com/muisje) por ayudar con [esta](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) solución)

#### 1.3 Cambiar la propiedad ejecutando en una instalación de Windows
1. Navega a: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Haz clic derecho en `index.html` → `Propiedades` → Pestaña `Seguridad` → Haz clic en `Editar`
3. Selecciona tu usuario de la lista y marca la casilla de permiso de Escritura.
4. Reinicia tanto el servidor como el cliente.
   (Gracias a [xeuc](https://github.com/xeuc) por [esta](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) solución)

Si ninguna de las soluciones anteriores funciona, por favor revisa los problemas antiguos. Por ejemplo [aquí](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) o [aquí](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Si encuentras algún error que no puedas resolver por ti mismo, siéntete libre de abrir un issue.
<br/>Por favor ten en cuenta que cada sistema es diferente, lo que puede provocar comportamientos inesperados, así que añade tanta información como sea posible.
<br/>Los registros de Jellyfin y los registros de consola del navegador (con el prefijo [InPlayerEpisodePreview]) siempre son útiles.

## Créditos
La estructura del complemento está basada e inspirada en el complemento [Jellyscrub](https://github.com/nicknsy/jellyscrub) por [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---