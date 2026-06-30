# sveltekit-adapter-chrome-extension

[Adaptador](https://kit.svelte.dev/docs#adapters) para aplicaciones SvelteKit que prerenderiza tu sitio como una colección de archivos estáticos y elimina los scripts en línea para cumplir con las políticas de contenido de las extensiones de Chrome que usan el manifiesto v3.

> Basado en [@sveltekit/adapter-static](https://github.com/sveltejs/kit/blob/master/packages/adapter-static). El crédito es para [estas personas](https://github.com/sveltejs/kit/graphs/contributors) por su arduo trabajo para hacer que Svelte sea tan genial

> 🚧 Si usas SvelteKit v1.0.0+, asegúrate de establecer `prerender=true` para cada página referenciada por tu extensión para que SvelteKit genere los archivos HTML. (c.f. Issue #27)

## Uso

Instala con `npm i -D sveltekit-adapter-chrome-extension`, luego añade el adaptador a tu `svelte.config.js`:

```js
// svelte.config.js
import adapter from "sveltekit-adapter-chrome-extension";

export default {
  kit: {
    adapter: adapter({
      // default options are shown
      pages: "build",
      assets: "build",
      fallback: null,
      precompress: false,
      manifest: "manifest.json",
    }),
    appDir: "app",
  },
};
```

## Opciones

### pages

El directorio donde se escribirán las páginas prerenderizadas. Por defecto es `build`.

### assets

El directorio donde se escribirán los recursos estáticos (el contenido de `static`, más JS y CSS del lado del cliente generados por SvelteKit). Normalmente debería ser el mismo que `pages`, y por defecto será el valor de `pages`, pero en raras circunstancias podría ser necesario generar páginas y recursos en ubicaciones separadas.

### fallback

Especifica una página de reserva para el modo SPA, por ejemplo `index.html` o `200.html` o `404.html`.

### precompress

Si es `true`, precomprime archivos con brotli y gzip. Esto generará archivos `.br` y `.gz`.

### manifest

Especifica el nombre del archivo de manifiesto si deseas diferentes manifiestos para distintas plataformas objetivo, por ejemplo `chrome_manifest.json`, `firefox_manifest.json`.
Este nombre de archivo debe coincidir con uno que esté presente en el directorio `static` (el directorio que contiene tus archivos estáticos). El archivo objetivo seleccionado será renombrado a `manifest.json` en el directorio de build, y todos los demás archivos `.json` con `manifest` en el nombre no serán copiados.

## Licencia

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---