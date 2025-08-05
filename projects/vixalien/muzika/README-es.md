# Muzika

> [!CAUTION]
> Muzika actualmente no está mantenida y será archivada en el futuro. Véase https://github.com/vixalien/muzika/issues/220 para más detalles.

Muzika es una elegante aplicación de streaming de música.

![Página principal de Muzika](https://raw.githubusercontent.com/vixalien/muzika/main/data/resources/screenshots/home.png)

![Muzika reproduciendo "My Queen is Angela Davis"](https://raw.githubusercontent.com/vixalien/muzika/main/data/resources/screenshots/playing.png)

> Nota: Esto es un trabajo en progreso. La aplicación aún no está lista para producción.

## Características

- Pantalla principal personalizada
- Buscar canciones, álbumes, artistas, radios y listas de reproducción
- Iniciar sesión con Google y acceder a tus listas de reproducción y más desde tu biblioteca
- Reproducir radios y mezclas personalizadas
- Ver letras de canciones e información relacionada
- Navegar artistas, álbumes y listas de reproducción, etc.

## Instalación

### Usando el último Nightly Flatpak

Puedes descargar el [último flatpak Nightly](https://vixalien.github.io/muzika/muzika.flatpakref).

### Desde el código fuente

Dependencias:

- GNOME Builder

1. Clona el repositorio

```bash
git clone https://github.com/vixalien/muzika.git --recurse-submodules
```
2. Abre el proyecto en GNOME Builder y usa "Build" para compilar el proyecto.

> Nota: Ya no se admite el uso directo de Meson y Ninja porque Muzika
> utiliza los componentes más recientes (no lanzados) de libadwaita.

## Navegación

Muzika tiene un navegador robusto que te permite navegar a través de diferentes
páginas usando URIs de muzika. Algunas de ellas se documentan a continuación.

La URI de muzika tiene la forma `muzika:endpoint:data`. Las URIs también pueden tener parámetros
de consulta. Por ejemplo, `muzika:library?view=grid` abrirá la página de la biblioteca
con la vista en cuadrícula.

Puedes navegar a una URI de muzika escribiéndola directamente en la barra de búsqueda y
muzika visitará esa página directamente en lugar de buscarla.

También puedes navegar a un endpoint dado activando manualmente la acción del navegador:

1. Abre el inspector de GTK presionando `Ctrl+Shift+I`.
2. Haz clic en la pestaña `Actions` a la derecha.
3. Busca la acción llamada `navigator.visit` y escribe tu URI en el campo
   `Parameter`, luego haz clic en `Activate`.

### Endpoints

Una lista de todos los endpoints está [aquí](https://raw.githubusercontent.com/vixalien/muzika/main/src/pages.ts).

- `muzika:home` - Página principal
- `muzika:playlist:<playlistId>` - Página de lista de reproducción. ej.:
  `muzika:playlist:PL4fGSI1pDJn6puJdseH2Rt9sMvt9E2M4i`/
- `muzika:album:<albumId>` - Página de álbum.
- `muzika:artist:<channelId>` - Página de artista o canal.
- `search:<query>` - Búsqueda. Ten en cuenta que la consulta debe estar codificada en URL. ej.:
  `search:hello%20world` busca `hello world`.
- `muzika:library` - Biblioteca.

Se añadirán más endpoints a medida que Muzika soporte más funciones.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---