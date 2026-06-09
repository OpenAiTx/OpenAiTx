# Convertidor de Tailwind a estilos en línea

Convierte clases de Tailwind CSS a estilos en línea para plantillas HTML listas para email.

### [Pruébalo en línea](https://tailwind-to-inline.vercel.app)

### Instalación
`npm install tailwind-to-inline`


### Uso

#### Desde una ruta de archivo

```js
import { makeStylesInline } from 'tailwind-to-inline';

const htmlTemplate = await makeStylesInline('templates/welcome-email.html', {
  name: 'John',
  cta_text: 'Complete Profile'
});
```

**Parámetros:**

- `templatePath` — Ruta al archivo de plantilla.
- `placeholderValues` *(opcional)* — Un objeto de pares clave-valor para reemplazar contenido dinámico en la plantilla.

#### Desde una cadena HTML sin procesar

```js
import { makeStylesInlineFromString } from 'tailwind-to-inline';

const html = `<div class="pt-10 text-yellow-300">Hello, {{name}}</div>`;
const htmlTemplate = await makeStylesInlineFromString(html, {
  name: 'John',
});
```

**Parámetros:**

- `templateString` — Una cadena HTML sin procesar que contiene clases de Tailwind CSS.
- `data` *(opcional)* — Un objeto de pares clave-valor para reemplazar contenido dinámico en la plantilla.


### Ejemplo
#### Plantilla original `welcome-email.html`:

```html
<html>
  <body class="bg-gray-800">
    <div class="pt-10 mb-4 pl-4 max-w-[512px] relative z-20">
      <span class="mr-5 text-yellow-300">Welcome, {{name}}</span>
    </div>
    <div>
      <a href="https://example.com/complete-profile" class="bg-blue-500">
        {{cta_text}}
      </a>
    </div>
  </body>
</html>
```
#### Resultado convertido:


```html
<html>
  <body style="background-color: #1f2937;">
    <div style="position: relative; z-index: 20; max-width: 512px; margin-bottom: 1rem; padding-left: 1rem; padding-top: 2.5rem;">
      <span style="margin-right: 1.25rem; color: #fde047;">Welcome, John</span>
    </div>
    <div>
      <a href="https://example.com/complete-profile" style="background-color: #3b82f6;">
        Complete Profile
      </a>
    </div>
  </body>
</html>
```

### Contribuyendo

¡Se aceptan contribuciones, problemas y solicitudes de funciones!

### Colaboradores

<a href="https://github.com/vardan-arm"><img src="https://github.com/vardan-arm.png" width="50" height="50" alt="vardan-arm" /></a>
<a href="https://github.com/diogomoretti"><img src="https://github.com/diogomoretti.png" width="50" height="50" alt="diogomoretti" /></a>
<a href="https://github.com/markosmk"><img src="https://github.com/markosmk.png" width="50" height="50" alt="markosmk" /></a>

### Licencia

Este proyecto tiene licencia MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-09

---