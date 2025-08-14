# Vimesh Headless UI
## Características
Esta es una implementación de Alpine.js de [Tailwind Headless UI](https://headlessui.com/). Construido con el framework [Vimesh UI](https://github.com/vimeshjs/vimesh-ui), Vimesh Headless UI tiene algunas características interesantes:
### Ultra ligero
Vimesh Headless UI tiene un tamaño de código mucho más pequeño

| Componentes   | Vimesh Headless UI   | Tailwind Headless UI para Vue | Tailwind Headless UI para React |
| ----------- | -------------------- | -------- | ----- |
| Listbox   | 8k  | 34k | 30k | 
| Combobox  | 9k  | 25k | 39k |
| Menú      | 7k  | 18k | 20k |
| Interruptor    | 0.6k | 5k | 6k |
| Pestañas      | 4k  | 12k | 16k |
| Diálogo    | 2k  | 15k | 17k |
| Popover   | 6k  | 23k | 28k |
| Grupo de Radio | 1k | 11k | 14k |

Comparando la versión de producción de Vimesh y Tailwind headless en la página de ejemplo de diálogo, Vimesh es mucho más pequeño con más características y menos errores (revisa la visualización del menú en el diálogo emergente de tailwind).

* Vimesh (192k) 
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh001.png) 
* Tailwind (425k)
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/tailwind001.png)

### Carga dinámica solo de los componentes usados
Los componentes son archivos HTML simples, que pueden alojarse en cualquier lugar, normalmente en un CDN. Pueden ser compartidos entre diferentes proyectos sin magia extra de tree shaking. Por ejemplo, el ejemplo básico de diálogo usa dos componentes `hui-dialog` y `hui-menu`. Simplemente cárgalos asincrónicamente con `x-import`. Vimesh UI registra los elementos personalizados nativos correspondientes y los inicializa.

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

### Sin compilación, sin paquete
Lo que escribes es lo que obtienes. Organiza los componentes en archivos html bajo espacios de nombres significativos. No necesitas webpack, rollup, vite, etc. 

## Comenzando
### Modo de desarrollo
Instala las dependencias de desarrollo, incluyendo alpinejs, @vimesh/style, @vimesh/ui, universal-router y http-server.
```
yarn
```
Ejecutar servidor http estático
```
yarn dev
```
Abra la URL `http://127.0.0.1:8080/playground/dev.html`

Muestra una página de índice
![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh002.jpg)

Hay muchos ejemplos para diferentes componentes con el código fuente relativo.

![](https://raw.githubusercontent.com/vimeshjs/vimesh-headless/master/./assets/vimesh003.jpg)

Utiliza la versión de desarrollo de alpinejs y @vimesh/ui en la carpeta node_modules.

### Modo de producción
Por favor, consulte `playground/index.html`, que usa la última versión de alpinejs y @vimesh/ui en `unpkg.com`. De hecho, también es lo que haría si usa Vimesh Headless UI en sus proyectos reales.
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