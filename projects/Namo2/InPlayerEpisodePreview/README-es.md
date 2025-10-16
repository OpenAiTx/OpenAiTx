Vista previa de episodios en el reproductor
====================
## Acerca de ##
Este complemento añade una lista de episodios al reproductor de video, lo que permite previsualizar cada episodio del programa de televisión sin tener que salir del reproductor.

Esta modificación es compatible con los siguientes clientes:
* [Cliente Web Jellyfin](https://github.com/jellyfin/jellyfin-web)
* [Reproductor Multimedia Jellyfin](https://github.com/jellyfin/jellyfin-media-player) (JMP) Cliente de Escritorio

### Características ###
* Listar todos los episodios de una temporada
* Cambiar entre temporadas
* Muestra título del episodio, descripción, miniatura y progreso de reproducción
* Muestra detalles del episodio como la clasificación comunitaria
* Marcar episodios como reproducidos o favoritos
* Iniciar un nuevo episodio
* Debe funcionar con temas personalizados

## Vista previa ##
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Tema utilizado: (SkinManager) Kaleidochromic
<br>
A esta vista previa le faltan los nuevos botones para marcar un episodio como completado o favorito.

## Instalación ##

### Cliente Web Jellyfin (Servidor) ###
1. Añada el manifiesto `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` como un repositorio de plugins de Jellyfin a su servidor.
2. Instale el complemento `InPlayerEpisodePreview` desde el repositorio.
3. Reinicie el servidor Jellyfin.

<br/>

### Reproductor Multimedia Jellyfin (JMP) Cliente de Escritorio ###
### **Obsoleto con la versión JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)** ###
Debido a que el nuevo cliente JMP usa el reproductor web actual del propio servidor, ya no es necesario hacer cambios directamente en el código del cliente.

Esta es la forma recomendada de instalar el script en el cliente de escritorio.
Si no se siente cómodo editando el archivo nativeshell.js usted mismo (pasos 3 a 6), puede descargar la versión completa, que incluye el script ya añadido al archivo nativeshell.js.
Aún no está claro si podría haber problemas potenciales al reemplazar el archivo nativeshell.js con el de la versión, por lo que se recomienda seguir todos los pasos a continuación.

1. Descargue la última versión [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) o [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (incluye el script ya agregado al archivo nativeshell.js)
2. Extraiga el archivo zip en su directorio Jellyfin (por ejemplo, C:\Program Files\Jellyfin\Jellyfin Media Player)
3. Dentro de su directorio Jellyfin siga la ruta de la carpeta "web-client\extension"
4. Abra el archivo "nativeshell.js" en un editor de texto.
5. Dentro del archivo encuentre la sección `const plugins = [];`. Agregue una nueva línea al inicio de la lista y pegue `'inPlayerEpisodePreviewPlugin',`. La sección ahora debería verse similar a esto:
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

## Solución de problemas ##

### 1. El botón de vista previa no es visible ###
Esto probablemente está relacionado con permisos incorrectos para el archivo `index.html`.

#### 1.1 Cambiar la propiedad dentro de un contenedor docker ####
Si estás ejecutando jellyfin en un contenedor docker, puedes cambiar la propiedad con el siguiente comando
(reemplaza jellyfin con el nombre de tu contenedor, user y group con el usuario y grupo de tu contenedor):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Puede ejecutar esto como un trabajo cron al iniciar el sistema.

(Gracias a [muisje](https://github.com/muisje) por ayudar con [esta](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) solución)

#### 1.2 Cambiar la propiedad ejecutándose en una instalación de Windows ####
1. Navegue a: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Haga clic derecho en `index.html` → `Propiedades` → `Pestaña Seguridad` → Haga clic en `Editar`
3. Seleccione su usuario de la lista y marque la casilla de permiso de Escritura.
4. Reinicie tanto el servidor como el cliente.

(Gracias a [xeuc](https://github.com/xeuc) por [esta](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) solución)

Si esto no funciona, siga la discusión en [este](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) (o [este](https://github.com/Namo2/InPlayerEpisodePreview/issues/49)) problema.

<br/>
Si encuentra algún error que no pueda resolver por sí mismo, no dude en abrir un problema.
<br/>Tenga en cuenta que cada sistema es diferente, lo que puede provocar comportamientos inesperados, así que agregue tanta información como sea posible.
<br/>Los registros de Jellyfin y los registros de consola del navegador (con el prefijo [InPlayerEpisodePreview]) siempre son útiles.

## Inconvenientes ##
* El complemento descargará algunos datos adicionales como la descripción del episodio desde el servidor.

## Créditos ##
La estructura del complemento está basada e inspirada en el complemento [Jellyscrub](https://github.com/nicknsy/jellyscrub) por [NickNSY](https://github.com/nicknsy).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---