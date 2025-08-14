# Vimesh Headless UI
## Fonctionnalités
Ceci est une implémentation Alpine.js de [Tailwind Headless UI](https://headlessui.com/). Construit avec le framework [Vimesh UI](https://github.com/vimeshjs/vimesh-ui), Vimesh Headless UI possède quelques fonctionnalités intéressantes :
### Ultra léger 
Vimesh Headless UI a une taille de code bien plus petite

| Composants   | Vimesh Headless UI   | Tailwind Headless UI pour Vue | Tailwind Headless UI pour React |
| ----------- | -------------------- | -------- | ----- |
| Listbox   | 8k  | 34k | 30k | 
| Combobox  | 9k  | 25k | 39k |
| Menu      | 7k  | 18k | 20k |
| Switch    | 0.6k | 5k | 6k |
| Tabs      | 4k  | 12k | 16k |
| Dialog    | 2k  | 15k | 17k |
| Popover   | 6k  | 23k | 28k |
| Radio Group | 1k | 11k | 14k |

En comparant la version de production de Vimesh et la page d'exemple du dialogue headless de Tailwind en taille, Vimesh est bien plus petit avec plus de fonctionnalités et moins de bugs (vérifiez l'affichage du menu dans la fenêtre popup tailwind). 

* Vimesh (192k) 
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh001.png) 
* Tailwind (425k)
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/tailwind001.png)

### Charger uniquement les composants utilisés dynamiquement
Les composants sont des fichiers HTML simples, qui peuvent être hébergés n'importe où, normalement sur un CDN. Ils peuvent être partagés entre différents projets sans magie supplémentaire de tree shaking. Par exemple, l'exemple basique de dialogue utilise deux composants `hui-dialog` et `hui-menu`. Il suffit de les charger de manière asynchrone avec `x-import`. Vimesh UI enregistre les éléments personnalisés natifs correspondants et les initialise.

```html
<template x-component:page="dialog-basic" x-import="hui:dialog,menu" x-data="setupDialogBasicData()"
    class="overflow-y-auto">
    ...
    <hui-dialog :open="isOpen" @close="setIsOpen(false)">
        ...
        <hui-menu>
        </hui-menu>
    </hui-dialog>
    ...
</template>
```

### Pas de build, pas de bundle
Ce que vous écrivez est ce que vous obtenez. Organisez les composants dans des fichiers html sous des espaces de noms significatifs. Vous n'avez pas besoin de webpack, rollup, vite, etc. 

## Pour commencer
### Mode développement
Installez les dépendances de développement, y compris alpinejs, @vimesh/style, @vimesh/ui, universal-router et http-server.
```
yarn
```
Exécuter un serveur HTTP statique
```
yarn dev
```
Ouvrez l'URL `http://127.0.0.1:8080/playground/dev.html`

Elle affiche une page d'index
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh002.jpg)

Il y a de nombreux exemples pour différents composants avec le code source relatif.

![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh003.jpg)

Elle utilise la version de développement d'alpinejs et @vimesh/ui dans le dossier node_modules.

### Mode production
Veuillez consulter `playground/index.html`, qui utilise la dernière version d'alpinejs et @vimesh/ui sur `unpkg.com`. En fait, c'est aussi ce que vous feriez si vous utilisez Vimesh Headless UI dans vos projets réels.
``` html
<head>
    <link rel="icon" type="image/x-icon" href="./assets/favicon.ico">

    <script src="https://unpkg.com/@vimesh/style"></script>
    <script src="https://unpkg.com/@vimesh/ui"></script>
    <script src="https://unpkg.com/alpinejs" defer></script>
    <script src="https://unpkg.com/universal-router/universal-router.min.js"></script>

    <script>
        const DEBUG = false
        $vui.config.debug = DEBUG
        $vui.config.importMap = {
            "hui": '../components/${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
            "app": './components/${path}${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
            "page": './pages/${path}${component}.html' + (DEBUG ? '?v=' + new Date().valueOf() : '?v=0.1'),
        }
    </script>
    ...
</head>
```

[Online Playground](https://unpkg.com/@vimesh/headless/playground/index.html)

Yes, the online playground are 100% plain html hosted at `unpkg.com`. It is very old school style, right? Let's make frondend development back to what it should be.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-14

---