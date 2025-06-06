# [React](https://react.dev/) &middot; [![Licencia de GitHub](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![Versión de npm](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Compilación y Pruebas](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Bienvenidos](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React es una biblioteca de JavaScript para construir interfaces de usuario.

* **Declarativo:** React facilita la creación de interfaces de usuario interactivas. Diseña vistas simples para cada estado en tu aplicación, y React actualizará y renderizará eficientemente solo los componentes necesarios cuando tus datos cambien. Las vistas declarativas hacen que tu código sea más predecible, más simple de entender y más fácil de depurar.
* **Basado en Componentes:** Construye componentes encapsulados que gestionan su propio estado y luego compónlos para crear interfaces de usuario complejas. Como la lógica de los componentes se escribe en JavaScript en lugar de plantillas, puedes pasar fácilmente datos complejos a través de tu aplicación y mantener el estado fuera del DOM.
* **Aprende una vez, escribe en cualquier lugar:** No hacemos suposiciones sobre el resto de tu stack tecnológico, por lo que puedes desarrollar nuevas funcionalidades en React sin reescribir el código existente. React también puede renderizar en el servidor usando [Node](https://nodejs.org/en) y potenciar aplicaciones móviles usando [React Native](https://reactnative.dev/).

[Aprende cómo usar React en tu proyecto](https://react.dev/learn).

## Instalación

React ha sido diseñado para una adopción gradual desde el principio, y **puedes usar tan poco o tanto de React como necesites**:

* Utiliza el [Inicio Rápido](https://react.dev/learn) para probar React.
* [Agrega React a un Proyecto Existente](https://react.dev/learn/add-react-to-an-existing-project) para usar tan poco o tanto de React como quieras.
* [Crea una Nueva Aplicación React](https://react.dev/learn/start-a-new-react-project) si buscas una potente cadena de herramientas de JavaScript.

## Documentación

Puedes encontrar la documentación de React [en el sitio web](https://react.dev/).

Consulta la página de [Primeros Pasos](https://react.dev/learn) para una visión general rápida.

La documentación está dividida en varias secciones:

* [Inicio Rápido](https://react.dev/learn)
* [Tutorial](https://react.dev/learn/tutorial-tic-tac-toe)
* [Pensando en React](https://react.dev/learn/thinking-in-react)
* [Instalación](https://react.dev/learn/installation)
* [Describiendo la UI](https://react.dev/learn/describing-the-ui)
* [Agregando Interactividad](https://react.dev/learn/adding-interactivity)
* [Gestionando Estado](https://react.dev/learn/managing-state)
* [Guías Avanzadas](https://react.dev/learn/escape-hatches)
* [Referencia de API](https://react.dev/reference/react)
* [Dónde Obtener Soporte](https://react.dev/community)
* [Guía de Contribución](https://legacy.reactjs.org/docs/how-to-contribute.html)

Puedes mejorarla enviando pull requests a [este repositorio](https://github.com/reactjs/react.dev).

## Ejemplos

Tenemos varios ejemplos [en el sitio web](https://react.dev/). Aquí tienes el primero para comenzar:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Este ejemplo renderizará "Hello Taylor" en un contenedor de la página.

Notarás que usamos una sintaxis similar a HTML; [la llamamos JSX](https://react.dev/learn#writing-markup-with-jsx). JSX no es obligatorio para usar React, pero hace el código más legible, y escribirlo se siente como escribir HTML.

## Contribuir

El principal propósito de este repositorio es continuar evolucionando el núcleo de React, haciéndolo más rápido y fácil de usar. El desarrollo de React ocurre abiertamente en GitHub, y estamos agradecidos con la comunidad por contribuir con correcciones de errores y mejoras. Lee a continuación para aprender cómo puedes participar en la mejora de React.

### [Código de Conducta](https://code.fb.com/codeofconduct)

Facebook ha adoptado un Código de Conducta que esperamos que los participantes del proyecto sigan. Por favor, lee [el texto completo](https://code.fb.com/codeofconduct) para que puedas entender qué acciones serán y no serán toleradas.

### [Guía de Contribución](https://legacy.reactjs.org/docs/how-to-contribute.html)

Lee nuestra [guía de contribución](https://legacy.reactjs.org/docs/how-to-contribute.html) para aprender sobre nuestro proceso de desarrollo, cómo proponer correcciones de errores y mejoras, y cómo construir y probar tus cambios en React.

### [Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue)

Para ayudarte a comenzar y familiarizarte con nuestro proceso de contribución, tenemos una lista de [good first issues](https://github.com/facebook/react/labels/good%20first%20issue) que contienen errores de alcance relativamente limitado. Este es un excelente lugar para empezar.

### Licencia

React está [licenciado bajo MIT](./LICENSE).

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---