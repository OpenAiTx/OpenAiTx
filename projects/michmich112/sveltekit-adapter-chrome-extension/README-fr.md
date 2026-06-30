# sveltekit-adapter-chrome-extension

[Adaptateur](https://kit.svelte.dev/docs#adapters) pour les applications SvelteKit qui pré-rendent votre site sous forme d’une collection de fichiers statiques et supprime les scripts en ligne pour se conformer aux politiques de contenu des extensions Chrome utilisant le manifeste v3.

> Basé sur [@sveltekit/adapter-static](https://github.com/sveltejs/kit/blob/master/packages/adapter-static). Le mérite revient à [ces personnes](https://github.com/sveltejs/kit/graphs/contributors) pour leur travail acharné qui rend Svelte si exceptionnel

> 🚧 Si vous utilisez SvelteKit v1.0.0+, assurez-vous de définir `prerender=true` pour chaque page référencée par votre extension afin que SvelteKit génère les fichiers HTML. (voir Issue #27)

## Utilisation

Installez avec `npm i -D sveltekit-adapter-chrome-extension`, puis ajoutez l’adaptateur à votre `svelte.config.js` :

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
## Options

### pages

Le répertoire dans lequel écrire les pages pré-rendues. Par défaut, c’est `build`.

### assets

Le répertoire dans lequel écrire les ressources statiques (le contenu de `static`, plus le JS et CSS côté client générés par SvelteKit). Normalement, il doit être le même que `pages`, et il prendra par défaut la valeur de `pages`, mais dans de rares cas, vous pourriez avoir besoin de sortir les pages et les ressources dans des emplacements séparés.

### fallback

Spécifiez une page de secours pour le mode SPA, par exemple `index.html` ou `200.html` ou `404.html`.

### precompress

Si `true`, compresse à l’avance les fichiers avec brotli et gzip. Cela générera des fichiers `.br` et `.gz`.

### manifest

Spécifiez le nom du fichier manifeste si vous voulez différents manifestes pour différentes plateformes cibles, par exemple `chrome_manifest.json`, `firefox_manifest.json`.  
Ce nom de fichier doit correspondre à un fichier présent dans le répertoire `static` (le dossier contenant vos fichiers statiques). Le fichier cible sélectionné sera renommé en `manifest.json` dans le répertoire de build, et tous les autres fichiers `.json` contenant `manifest` dans le nom ne seront pas copiés.

## License

[MIT](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---