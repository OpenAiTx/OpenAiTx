
<a href="https://www.facebook.com/amplifr/">
  <img width="80" height="80" align="right"
    alt="Patrocinado por Amplifr" src="https://raw.githubusercontent.com/vrizo/uibook/master/./amplifr-logo.png" style="border-radius: 100%; margin: 10px;"/>
</a>


# Uibook

Uibook es una herramienta para pruebas visuales de componentes React. Te permite
ver rápidamente tanto la vista de escritorio como la móvil de tus componentes con consultas de medios reales
y diferentes combinaciones de props.

Las características clave:
- Pruebas responsivas para desarrolladores para jugar con **consultas de medios reales**
- Edición de texto en vivo para diseñadores y editores para verificar su contenido
- Instalado como un plugin de Webpack, no requiere ningún compilador adicional.

<img src="/docs/uibook.gif" align="center" alt="Características clave de Uibook" >

:triangular_flag_on_post: Revisa el proyecto demo de Uibook aquí:
[https://uibook.vrizo.net/](https://uibook.vrizo.net/#Presets:ru).

## Uso

### Instalación rápida :hatching_chick:

Hemos diseñado Uibook para una integración fluida en tu proyecto.
Instálalo como un plugin de webpack, y estarás listo:
Uibook no requiere ningún empaquetador separado.

_webpack.config.js_
```js
const UibookPlugin = require('uibook/plugin')

module.exports = {
  …
  plugins: [
    new UibookPlugin({
      outputPath: '/uibook',
      controller: path.join(__dirname, '../src/uibook-controller.js'),
      hot: true
    })
  ],
}
```
[Lea más sobre la instalación →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/install.md)
[Instalar en Create React App usando CRACO →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/install_craco.md)

### Describir componentes en Páginas :hatched_chick:

Debe definir solo dos cosas:

1. La Página — objeto simple con el nombre del componente de prueba y los casos;
2. El Caso — conjunto de props y callbacks para el componente.

_button.uibook.js_

```js
import UibookCase from 'uibook/case'
import Button from '../src/button'

export default {
  component: Button,
  cases: [
    () => <UibookCase>Button</UibookCase>,
    () => <UibookCase props={{ isSmall: true }}>Small button</UibookCase>
  ]
}
```

[Lee más sobre la configuración →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/configure.md)

### Pasar Páginas al Controlador :baby_chick:

Tan pronto como termines tu primera Página de Uibook, estarás listo
para escribir el Controlador de Uibook. Este es el lugar donde todas
las Páginas se incluyen y se pasan a UibookStarter :sparkles:

_uibook-controller.js_
```js
import UibookStarter from 'uibook/starter'
import ButtonUibook from './button.uibook'

export default UibookStarter({
  pages: {
    Button: ButtonUibook
  }
})
```

[Lea más sobre el Controlador →](https://raw.githubusercontent.com/vrizo/uibook/master/docs/controller.md)

### Lanzamiento :rocket:

No se necesitan servidores adicionales ni instancias de webpack.
Uibook se integra en tu proyecto, así que solo ejecuta tu empaquetador
y abre `/uibook` (o tu dirección personalizada — `outputPath`) en un navegador.

### Más información

- **[Solución de problemas](https://raw.githubusercontent.com/vrizo/uibook/master/docs/troubleshooting.md)**
- [Ejemplos](https://raw.githubusercontent.com/vrizo/uibook/master/docs/examples.md)
- [Pregúntame](https://twitter.com/vitaliirizo)

## Edición de texto en vivo

Este modo habilita `contentEditable` para cada caso, permitiendo a gerentes,
diseñadores y editores de interfaz previsualizar contenido en los componentes.

<img src="/docs/text-edit-mode.gif" align="center" alt="Modo de Edición de Texto" >

## Agradecimientos especiales

- [@ai](https://github.com/ai)
- [@demiazz](https://github.com/demiazz)
- [@marfitsin](https://github.com/marfitsin)
- [@iadramelk](https://github.com/iadramelk)
- [@ikowalsker](https://www.facebook.com/ikowalsker)
- [@antiflasher](https://github.com/antiflasher)
- [@HellSquirrel](https://github.com/HellSquirrel)

Cualquiera es bienvenido a contribuir, puedes consultar las tareas actuales
en [PLAN.md](https://raw.githubusercontent.com/vrizo/uibook/master/PLAN.md). Estaré encantado de responder tus preguntas
sobre el proyecto.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---