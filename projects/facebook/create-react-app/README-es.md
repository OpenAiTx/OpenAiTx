## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## Obsoleto
>
> Create React App fue una de las herramientas clave para iniciar un proyecto React entre 2017 y 2021. Actualmente está en estado de mantenimiento a largo plazo y recomendamos migrar a uno de los frameworks de React documentados en [Iniciar un Nuevo Proyecto de React](https://react.dev/learn/start-a-new-react-project).
>
> Si estás siguiendo un tutorial para aprender React, todavía es útil continuar con tu tutorial, pero no recomendamos iniciar aplicaciones en producción basadas en Create React App.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Crea aplicaciones React sin configuración de compilación.

- [Crear una App](#creating-an-app) – Cómo crear una nueva aplicación.
- [Guía de Usuario](https://facebook.github.io/create-react-app/) – Cómo desarrollar aplicaciones creadas con Create React App.

Create React App funciona en macOS, Windows y Linux.<br>
Si algo no funciona, por favor [informa un problema](https://github.com/facebook/create-react-app/issues/new).<br>
Si tienes preguntas o necesitas ayuda, por favor pregunta en [GitHub Discussions](https://github.com/facebook/create-react-app/discussions).

## Resumen Rápido

```sh
npx create-react-app my-app
cd my-app
npm start
```

Si anteriormente instalaste `create-react-app` globalmente vía `npm install -g create-react-app`, te recomendamos desinstalar el paquete usando `npm uninstall -g create-react-app` o `yarn global remove create-react-app` para asegurarte de que npx siempre use la versión más reciente.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) viene incluido con npm 5.2+ y superior, consulta [instrucciones para versiones antiguas de npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Luego abre [http://localhost:3000/](http://localhost:3000/) para ver tu aplicación.<br>
Cuando estés listo para desplegar a producción, crea un paquete minificado con `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Comienza Inmediatamente

**No** necesitas instalar o configurar herramientas como webpack o Babel.<br>
Ya vienen preconfiguradas y ocultas para que puedas concentrarte en el código.

Crea un proyecto y listo para comenzar.

## Crear una App

**Necesitarás tener Node 14.0.0 o superior en tu máquina de desarrollo local** (pero no es necesario en el servidor). Recomendamos usar la última versión LTS. Puedes usar [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) o [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) para cambiar de versión de Node entre diferentes proyectos.

Para crear una nueva aplicación, puedes elegir uno de los siguientes métodos:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) es una herramienta para ejecutar paquetes que viene incluida con npm 5.2+ y superior, consulta [instrucciones para versiones antiguas de npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` está disponible en npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) está disponible en Yarn 0.25+_

Esto creará un directorio llamado `my-app` dentro de la carpeta actual.<br>
Dentro de ese directorio, generará la estructura inicial del proyecto e instalará las dependencias transitivas:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

Sin configuración ni estructuras de carpetas complicadas, solo los archivos que necesitas para construir tu aplicación.<br>
Una vez finalizada la instalación, puedes abrir la carpeta de tu proyecto:

```sh
cd my-app
```

Dentro del proyecto recién creado, puedes ejecutar algunos comandos integrados:

### `npm start` o `yarn start`

Ejecuta la aplicación en modo desarrollo.<br>
Abre [http://localhost:3000](http://localhost:3000) para verla en el navegador.

La página se recargará automáticamente si haces cambios en el código.<br>
Verás los errores de compilación y advertencias de lint en la consola.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` o `yarn test`

Ejecuta el watcher de pruebas en modo interactivo.<br>
Por defecto, ejecuta pruebas relacionadas con los archivos modificados desde el último commit.

[Lee más sobre las pruebas.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` o `yarn build`

Compila la aplicación para producción en la carpeta `build`.<br>
Empaqueta correctamente React en modo producción y optimiza la compilación para el mejor rendimiento.

La compilación es minificada y los nombres de archivo incluyen los hashes.<br>

Tu aplicación está lista para ser desplegada.

## Guía de Usuario

Puedes encontrar instrucciones detalladas sobre cómo usar Create React App y muchos consejos en [su documentación](https://facebook.github.io/create-react-app/).

## ¿Cómo Actualizar a Nuevas Versiones?

Por favor consulta la [Guía de Usuario](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) para esto y otra información.

## Filosofía

- **Una Sola Dependencia:** Solo hay una dependencia de compilación. Utiliza webpack, Babel, ESLint y otros proyectos increíbles, pero proporciona una experiencia cohesionada y curada sobre ellos.

- **Sin Configuración Requerida:** No necesitas configurar nada. Una configuración razonablemente buena tanto para desarrollo como para producción está gestionada por ti, para que puedas concentrarte en escribir código.

- **Sin Ataduras:** Puedes “ejectar” a una configuración personalizada en cualquier momento. Ejecuta un solo comando y toda la configuración y dependencias de compilación se moverán directamente a tu proyecto, para que puedas continuar justo donde lo dejaste.

## ¿Qué Está Incluido?

Tu entorno tendrá todo lo que necesitas para construir una aplicación React moderna de una sola página:

- Soporte para React, JSX, ES6, TypeScript y Flow.
- Extensiones del lenguaje más allá de ES6, como el operador de propagación de objetos.
- CSS con autoprefijos, para que no necesites `-webkit-` u otros prefijos.
- Un ejecutor de pruebas unitarias interactivo y rápido con soporte integrado para informes de cobertura.
- Un servidor de desarrollo en vivo que advierte sobre errores comunes.
- Un script de construcción para empaquetar JS, CSS e imágenes para producción, con hashes y sourcemaps.
- Un [service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) offline-first y un [web app manifest](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/) que cumplen con todos los criterios de [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app). (_Nota: El uso del service worker es optativo desde `react-scripts@2.0.0` y superior_)
- Actualizaciones sin complicaciones para las herramientas anteriores con una sola dependencia.

Consulta [esta guía](https://github.com/nitishdayal/cra_closer_look) para una visión general de cómo estas herramientas funcionan juntas.

La contrapartida es que **estas herramientas están preconfiguradas para funcionar de una manera específica**. Si tu proyecto necesita más personalización, puedes ["ejectar"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) y personalizarlo, pero luego tendrás que mantener esa configuración.

## Alternativas Populares

Create React App es una excelente opción para:

- **Aprender React** en un entorno de desarrollo cómodo y rico en funciones.
- **Iniciar nuevas aplicaciones React de una sola página.**
- **Crear ejemplos** con React para tus librerías y componentes.

Aquí hay algunos casos comunes donde podrías querer probar otra cosa:

- Si quieres **probar React** sin cientos de dependencias de herramientas de compilación transitivas, considera [usar un solo archivo HTML o un sandbox en línea](https://reactjs.org/docs/getting-started.html#try-react).

- Si necesitas **integrar código React con un framework de plantillas del lado del servidor** como Rails, Django o Symfony, o si **no estás construyendo una aplicación de una sola página**, considera usar [nwb](https://github.com/insin/nwb), o [Neutrino](https://neutrino.js.org/) que son más flexibles. Para Rails específicamente, puedes usar [Rails Webpacker](https://github.com/rails/webpacker). Para Symfony, prueba [webpack Encore de Symfony](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- Si necesitas **publicar un componente React**, [nwb](https://github.com/insin/nwb) [también puede hacer esto](https://github.com/insin/nwb#react-components-and-libraries), así como el [preset react-components de Neutrino](https://neutrino.js.org/packages/react-components/).

- Si quieres hacer **renderizado del lado del servidor** con React y Node.js, revisa [Next.js](https://nextjs.org/) o [Razzle](https://github.com/jaredpalmer/razzle). Create React App es agnóstico respecto al backend y solo produce bundles estáticos de HTML/JS/CSS.

- Si tu sitio web es **mayormente estático** (por ejemplo, un portafolio o un blog), considera usar [Gatsby](https://www.gatsbyjs.org/) o [Next.js](https://nextjs.org/). A diferencia de Create React App, Gatsby pre-renderiza el sitio web en HTML en tiempo de compilación. Next.js soporta tanto renderizado del lado del servidor como pre-renderizado.

- Finalmente, si necesitas **más personalización**, revisa [Neutrino](https://neutrino.js.org/) y su [preset React](https://neutrino.js.org/packages/react/).

Todas las herramientas anteriores pueden funcionar con poca o ninguna configuración.

Si prefieres configurar la compilación tú mismo, [sigue esta guía](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

¿Buscas algo similar, pero para React Native?<br>
Revisa [Expo CLI](https://github.com/expo/expo-cli).

## Contribuir

¡Nos encantaría contar con tu ayuda en `create-react-app`! Consulta [CONTRIBUTING.md](CONTRIBUTING.md) para más información sobre qué buscamos y cómo empezar.

## Apoyando Create React App

Create React App es un proyecto mantenido por la comunidad y todos los colaboradores son voluntarios. Si te gustaría apoyar el desarrollo futuro de Create React App considera donar a nuestro [Open Collective](https://opencollective.com/create-react-app).

## Créditos

Este proyecto existe gracias a todas las personas que [contribuyen](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Gracias a [Netlify](https://www.netlify.com/) por alojar nuestra documentación.

## Reconocimientos

Agradecemos a los autores de proyectos relacionados existentes por sus ideas y colaboración:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Licencia

Create React App es software de código abierto [licenciado como MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). El logo de Create React App está licenciado bajo una [licencia Creative Commons Attribution 4.0 International](https://creativecommons.org/licenses/by/4.0/).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---