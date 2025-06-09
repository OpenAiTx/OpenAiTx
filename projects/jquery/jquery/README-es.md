# [jQuery](https://jquery.com/) — JavaScript de Nueva Generación

Las reuniones se llevan a cabo actualmente en la [plataforma matrix.org](https://matrix.to/#/#jquery_meeting:gitter.im).

Las actas de las reuniones se pueden encontrar en [meetings.jquery.org](https://meetings.jquery.org/category/core/).

La última versión de jQuery está disponible en [https://jquery.com/download/](https://jquery.com/download/).

## Soporte de versiones

| Versión | Rama       | Estado   |
| ------- | ---------- | -------- |
| 4.x     | main       | Beta     |
| 3.x     | 3.x-stable | Activa   |
| 2.x     | 2.x-stable | Inactiva |
| 1.x     | 1.x-stable | Inactiva |

Una vez que la versión final 4.0.0 sea publicada, la rama 3.x continuará recibiendo actualizaciones por un tiempo limitado. Las ramas 2.x y 1.x ya no tienen soporte.

El soporte comercial para versiones inactivas está disponible a través de [HeroDevs](https://herodevs.com/nes).

Obtén más información sobre nuestro [soporte de versiones](https://jquery.com/support/).

## Guías de contribución

En el espíritu del desarrollo de software de código abierto, jQuery siempre fomenta la contribución de código por parte de la comunidad. Para ayudarte a comenzar y antes de empezar a escribir código, asegúrate de leer detenidamente estas importantes directrices de contribución:

1. [Cómo participar](https://contribute.jquery.org/)
2. [Guía de estilo principal](https://contribute.jquery.org/style-guide/js/)
3. [Cómo escribir código para proyectos jQuery](https://contribute.jquery.org/code/)

### Referencias a issues/PRs

Los issues/PRs de GitHub normalmente se referencian mediante `gh-NÚMERO`, donde `NÚMERO` es el ID numérico del issue/PR. Puedes encontrar dicho issue/PR en `https://github.com/jquery/jquery/issues/NÚMERO`.

jQuery ha usado en el pasado un sistema de seguimiento de errores diferente, basado en Trac, disponible en [bugs.jquery.com](https://bugs.jquery.com/). Este se mantiene en modo solo lectura para permitir referencias a discusiones pasadas. Cuando el código fuente de jQuery hace referencia a uno de estos issues, utiliza el patrón `trac-NÚMERO`, donde `NÚMERO` es el ID numérico del issue. Puedes encontrar dicho issue en `https://bugs.jquery.com/ticket/NÚMERO`.

## Entornos en los que usar jQuery

- [Soporte para navegadores](https://jquery.com/browser-support/)
- jQuery también es compatible con Node, extensiones de navegador y otros entornos fuera del navegador.

## Qué necesitas para construir tu propio jQuery

Para compilar jQuery, necesitas tener la última versión de Node.js/npm y git 1.7 o posterior. Versiones anteriores podrían funcionar, pero no están soportadas.

Para Windows, debes descargar e instalar [git](https://git-scm.com/downloads) y [Node.js](https://nodejs.org/en/download/).

Los usuarios de macOS deben instalar [Homebrew](https://brew.sh/). Una vez instalado Homebrew, ejecuta `brew install git` para instalar git,
y `brew install node` para instalar Node.js.

Los usuarios de Linux/BSD deben usar sus respectivos gestores de paquetes para instalar git y Node.js, o compilar desde el código fuente
si lo prefieren. Fácil.

## Cómo construir tu propio jQuery

Primero, [clona el repositorio git de jQuery](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Luego, entra en el directorio de jquery, instala las dependencias y ejecuta el script de compilación:

```bash
cd jquery
npm install
npm run build
```

La versión compilada de jQuery se ubicará en el directorio `dist/`, junto con una copia minificada y el archivo de mapa asociado.

## Compilar todos los archivos de lanzamiento de jQuery

Para compilar todas las variantes de jQuery, ejecuta el siguiente comando:

```bash
npm run build:all
```

Esto creará todas las variantes que jQuery incluye en un lanzamiento, incluyendo `jquery.js`, `jquery.slim.js`, `jquery.module.js` y `jquery.slim.module.js` junto con sus archivos minificados asociados y sourcemaps.

`jquery.module.js` y `jquery.slim.module.js` son [módulos ECMAScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules) que exportan `jQuery` y `$` como exports nombrados y se colocan en el directorio `dist-module/` en lugar del directorio `dist/`.

## Compilando un jQuery personalizado

El script de compilación puede ser utilizado para crear una versión personalizada de jQuery que incluya solo los módulos que necesites.

Cualquier módulo puede ser excluido excepto `core`. Al excluir `selector`, no se elimina sino que se reemplaza por un pequeño wrapper alrededor de `querySelectorAll` nativo (ver más abajo para más información).

### Ayuda del script de compilación

Para ver la lista completa de opciones disponibles para el script de compilación, ejecuta lo siguiente:

```bash
npm run build -- --help
```

### Módulos

Para excluir un módulo, pasa su ruta relativa a la carpeta `src` (sin la extensión `.js`) a la opción `--exclude`. Cuando uses la opción `--include`, las inclusiones predeterminadas se omiten y se crea una compilación solo con esos módulos.

Algunos ejemplos de módulos que pueden ser excluidos o incluidos son:

- **ajax**: Toda la funcionalidad AJAX: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, transportes y atajos de eventos AJAX como `.ajaxStart()`.
- **ajax/xhr**: Solo el transporte AJAX con XMLHTTPRequest.
- **ajax/script**: Solo el transporte AJAX con `<script>`; utilizado para recuperar scripts.
- **ajax/jsonp**: Solo el transporte AJAX con JSONP; depende del transporte ajax/script.
- **css**: El método `.css()`. También elimina **todos** los módulos que dependen de css (incluyendo **effects**, **dimensions** y **offset**).
- **css/showHide**: `.show()`, `.hide()` y `.toggle()` no animados; puede excluirse si usas clases o llamadas explícitas a `.css()` para establecer la propiedad `display`. También elimina el módulo **effects**.
- **deprecated**: Métodos documentados como obsoletos pero aún no eliminados.
- **dimensions**: Los métodos `.width()` y `.height()`, incluyendo las variantes `inner-` y `outer-`.
- **effects**: El método `.animate()` y sus atajos como `.slideUp()` o `.hide("slow")`.
- **event**: Los métodos `.on()` y `.off()` y toda la funcionalidad de eventos.
- **event/trigger**: Los métodos `.trigger()` y `.triggerHandler()`.
- **offset**: Los métodos `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()` y `.scrollTop()`.
- **wrap**: Los métodos `.wrap()`, `.wrapAll()`, `.wrapInner()` y `.unwrap()`.
- **core/ready**: Excluye el módulo ready si colocas tus scripts al final del body. Cualquier callback ready enlazado con `jQuery()` se llamará inmediatamente. Sin embargo, `jQuery(document).ready()` no será una función y `.on("ready", ...)` o similar no se activará.
- **deferred**: Excluye jQuery.Deferred. Esto también excluye todos los módulos que dependen de Deferred, incluyendo **ajax**, **effects** y **queue**, pero reemplaza **core/ready** por **core/ready-no-deferred**.
- **exports/global**: Excluye la asignación de las variables globales de jQuery ($ y jQuery) a window.
- **exports/amd**: Excluye la definición AMD.

- **selector**: El motor de selectores completo de jQuery. Cuando este módulo se excluye, se reemplaza por un motor de selectores rudimentario basado en el método `querySelectorAll` del navegador que no soporta extensiones de selectores de jQuery ni semántica mejorada. Consulta el archivo [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) para más detalles.

*Nota*: Excluir el módulo completo `selector` también excluye todas las extensiones de selectores de jQuery (como `effects/animatedSelector` y `css/hiddenVisibleSelectors`).

##### Nombre AMD

Puedes establecer el nombre del módulo para la definición AMD de jQuery. Por defecto, está establecido como "jquery", lo cual funciona bien con plugins y librerías de terceros, pero puede haber casos donde quieras cambiarlo. Pásalo al parámetro `--amd`:

```bash
npm run build -- --amd="nombre-personalizado"
```

O, para definirlo anónimamente, deja el nombre en blanco.

```bash
npm run build -- --amd
```

##### Nombre de archivo y directorio

El nombre por defecto para el archivo compilado de jQuery es `jquery.js`; se coloca en el directorio `dist/`. Es posible cambiar el nombre del archivo usando `--filename` y el directorio usando `--dir`. `--dir` es relativo a la raíz del proyecto.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

Esto creará una versión slim de jQuery y la colocará en `tmp/jquery.slim.js`.

##### Modo ECMAScript Module (ESM)

Por defecto, jQuery genera un archivo JavaScript de script regular. También puedes generar un módulo ECMAScript que exporte `jQuery` como exportación por defecto usando el parámetro `--esm`:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Modo Factory

Por defecto, jQuery depende de un `window` global. Para entornos que no lo tienen, puedes generar una compilación tipo factory que expone una función que acepta `window` como parámetro, que puedes proporcionar externamente (consulta el [`README` del paquete publicado](build/fixtures/README.md) para instrucciones de uso). Puedes generar dicha factory usando el parámetro `--factory`:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Esta opción puede combinarse con otras como `--esm` o `--slim`:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Ejemplos de compilaciones personalizadas

Crea una compilación personalizada usando `npm run build`, listando los módulos a excluir. Excluir un módulo de nivel superior también excluye su directorio correspondiente de módulos.

Excluir toda la funcionalidad **ajax**:

```bash
npm run build -- --exclude=ajax
```

Excluir **css** elimina los módulos que dependen de CSS: **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Excluir varios módulos (`-e` es un alias de `--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Hay un alias especial para generar una compilación con la misma configuración que la versión oficial jQuery Slim:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

O, para crear la compilación slim como un módulo esm:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Las compilaciones personalizadas no oficiales no se prueban regularmente. Úselas bajo su propio riesgo.*

## Ejecutando las pruebas unitarias

Asegúrese de tener las dependencias necesarias:

```bash
npm install
```

Inicie `npm start` para construir jQuery automáticamente mientras trabaja:

```bash
npm start
```

Ejecute las pruebas unitarias con un servidor local que soporte PHP. Asegúrese de ejecutar el sitio desde el directorio raíz, no desde el directorio "test". No se requiere base de datos. Hay servidores locales PHP preconfigurados disponibles para Windows y Mac. Aquí hay algunas opciones:

- Windows: [Descargar WAMP](https://www.wampserver.com/en/)
- Mac: [Descargar MAMP](https://www.mamp.info/en/downloads/)
- Linux: [Configurando LAMP](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (la mayoría de plataformas)](https://code.google.com/p/mongoose/)

## Git Esencial

Como el código fuente es gestionado por el sistema de control de versiones Git, es útil conocer algunas funciones utilizadas.

### Limpiar

Si desea purgar su directorio de trabajo y volver al estado del repositorio principal, se pueden utilizar los siguientes comandos (recuerde que todo en lo que haya trabajado se eliminará después de esto):

```bash
git reset --hard upstream/main
git clean -fdx
```

### Rebase

Para ramas de características/temas, siempre debe usar el flag `--rebase` en `git pull`, o si suele manejar muchas ramas temporales "para ser usadas en una pull request de github", ejecute lo siguiente para automatizar esto:

```bash
git config branch.autosetuprebase local
```

(ver `man git-config` para más información)

### Manejo de conflictos de fusión

Si está obteniendo conflictos de fusión al hacer merge, en lugar de editar manualmente los archivos en conflicto, puede usar la función
`git mergetool`. Aunque la herramienta predeterminada `xxdiff` parece anticuada/fea, es bastante útil.

Los siguientes son algunos comandos que se pueden usar allí:

- `Ctrl + Alt + M` - fusionar automáticamente tanto como sea posible
- `b` - saltar al siguiente conflicto de fusión
- `s` - cambiar el orden de las líneas en conflicto
- `u` - deshacer una fusión
- `botón izquierdo del ratón` - marcar un bloque como ganador
- `botón central del ratón` - marcar una línea como ganadora
- `Ctrl + S` - guardar
- `Ctrl + Q` - salir

## Referencia de [QUnit](https://api.qunitjs.com)

### Métodos de prueba

```js
expect( numAssertions );
stop();
start();
```

*Nota*: La futura adición de un argumento a stop/start en QUnit se ignora en este conjunto de pruebas para que start y stop puedan pasarse como callbacks sin preocuparse por sus parámetros.

### Aserciones de prueba

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## Referencia de métodos de conveniencia del conjunto de pruebas

Vea [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js).

### Devuelve un array de elementos con los IDs dados

```js
q( ... );
```

Ejemplo:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Afirma que una selección coincide con los IDs dados

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Ejemplo:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### Dispara un evento DOM nativo sin pasar por jQuery

```js
fireNative( node, eventType );
```

Ejemplo:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Añade un número aleatorio a la url para evitar el caché

```js
url( "some/url" );
```

Ejemplo:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Ejecutar pruebas en un iframe

Algunas pruebas pueden requerir un documento distinto al fixture estándar de pruebas, y
estas pueden ejecutarse en un iframe separado. El código de prueba y las aserciones
permanecen en los archivos principales de pruebas de jQuery; solo el marcado mínimo del fixture de prueba
y el código de configuración deben colocarse en el archivo del iframe.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

Esto carga una página, construyendo una url con fileName `"./data/" + fileName`.
La página en el iframe determina cuándo ocurre el callback en la prueba incluyendo el script
"/test/data/iframeTest.js" y llamando a
`startIframeTest( [ additional args ] )` cuando sea apropiado. A menudo esto
será después de que se dispare document ready o `window.onload`.

El `testCallback` recibe el objeto QUnit `assert` creado por `testIframe`
para esta prueba, seguido por los objetos globales `jQuery`, `window` y `document` del
iframe. Si el código en el iframe pasa algún argumento a `startIframeTest`,
estos seguirán al argumento `document`.

## ¿Preguntas?

Si tiene alguna pregunta, no dude en consultar en el
[Foro de Desarrollo de jQuery Core](https://forum.jquery.com/developing-jquery-core) o en #jquery en [libera](https://web.libera.chat/).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---