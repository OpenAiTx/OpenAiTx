## Una forma fácil de crear una biblioteca de documentos para tu proyecto

Demo: [https://easydocs.codeandmedia.com/](https://easydocs.codeandmedia.com/)

Este tema para [Zola](https://getzola.org) (motor de sitios estáticos) te ayuda a construir y publicar la documentación de tu proyecto fácil y rápido. Zola es solo un binario que genera páginas html y activos estáticos adicionales después de construir tu documentación escrita en Markdown. Por lo tanto, puedes tomar el tema, tus archivos md, Zola y obtener un sitio web flexible y sencillo para documentación.

### Paso a paso

Como habrás oído, Zola es bastante flexible :) Entonces, el escenario a continuación es una de las cientos de formas posibles de hacer las cosas, siéntete libre de encontrar la que mejor te funcione. Además, Zola proporciona su propio mecanismo para instalar y usar temas, consulta [la documentación](https://www.getzola.org/documentation/themes/installing-and-using-themes/).

1. Haz un fork del repositorio y reemplaza el contenido de demostración dentro de la carpeta content con el tuyo. Pero revisa los archivos _index.md. Contienen `title` y cuando quieras tener anclas a la derecha de tus encabezados añade `insert_anchor_links = "right"` a cada índice. También se pueden eliminar `theme.toml`, la captura de pantalla y el readme.
2. Dentro de `config.toml` cambia la URL y el título por los tuyos. En la sección extra puedes especificar la ruta a tu API de GitHub para la versión debajo del logo en la navegación, favicon y el logo mismo. O simplemente elimina las líneas si no lo necesitas. También puedes configurar o activar algunas opciones adicionales relacionadas con Zola. [La especificación está aquí](https://www.getzola.org/documentation/getting-started/configuration/).
3. En sass/_variables.scss puedes cambiar la fuente, color o fondo si quieres.
4. Casi listo. Ahora debes decidir cómo quieres construir y dónde se alojará tu sitio web. Puedes construirlo localmente y subirlo a algún lugar. O construirlo en GitHub Actions y alojar en GitHub Pages / Netlify / CloudFlare Pages / AnyS3CloudStorage. [Cómo hacerlo para GitHub Pages](https://www.getzola.org/documentation/deployment/github-pages/). [Mi ejemplo](https://github.com/o365hq/o365hq.com/blob/main/.github/workflows/main.yml) de workflow de GitHub con build en 2 pasos (el primero verifica enlaces y errores ortográficos, el segundo sube a Azure). [Dockerfile](https://github.com/codeandmedia/zola_docsascode_theme/blob/master/Dockerfile) para crear una imagen Docker.

## Opciones de configuración proporcionadas

Estas opciones pueden configurarse en la sección `extra` del [config.toml](https://raw.githubusercontent.com/codeandmedia/zola_easydocs_theme/master/config.toml).  
Si alguna no está presente, tiene el mismo comportamiento que el valor por defecto que se muestra en el config.toml inicial [config.toml](https://raw.githubusercontent.com/codeandmedia/zola_easydocs_theme/master/config.toml).

- **easydocs_logo_always_clickable** controla si el logo siempre es clickeable. Por defecto, el logo solo es clickeable si no estás en la página principal. Si se habilita, el logo será clickeable también en la página principal. Por lo tanto, en la página principal básicamente solo refrescará la página ya que te llevará a la misma.
- **easydocs_uglyurls** proporciona soporte para sitios offline que no usan servidor web. Si se establece en true, los enlaces en la navegación se generan con la ruta completa incluyendo `index.html`. Esta funcionalidad fue inspirada por el [tema Abridge](https://www.getzola.org/themes/abridge/). Ten en cuenta que para que esto funcione también requiere que la URL base esté configurada a la carpeta local donde se almacenará el sitio, por ejemplo `base_url = file:///home/user/mysite/public/`. Por lo tanto, no es portable y solo funciona con una carpeta local específica, pero no requiere servidor web para navegar el sitio.
- **easydocs_heading_threshold** controla el número mínimo de encabezados necesarios en una página antes de que se muestren en la navegación a la izquierda. Por defecto es 5. Puede usarse, por ejemplo, para mostrar siempre encabezados en cada página configurándolo en 1.

¡Disfruta tu documentación!

* _Íconos: [Office UI Fabric Icons](https://uifabricicons.azurewebsites.net/)_
* _Botón de copiar código: [Aaron Luna](https://aaronluna.dev/blog/add-copy-button-to-code-blocks-hugo-chroma/)_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---