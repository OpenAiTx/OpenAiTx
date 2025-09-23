# Node Monkey

Una herramienta para inspeccionar, depurar y controlar aplicaciones Node.js a través de un navegador web o interfaz SSH en tu aplicación (con tus propios comandos personalizados).

Node Monkey ejecuta un servidor simple (o se conecta a tu servidor existente) y utiliza [Socket.IO](https://github.com/LearnBoost/socket.io) para crear una conexión websocket entre el navegador y el servidor. Su característica principal captura todo lo que normalmente se registraría en la terminal y lo envía al navegador para su inspección.

Es increíblemente fácil comenzar (ver [Uso rápido](#quick-usage) abajo) pero Node Monkey también ofrece características adicionales y una flexibilidad significativa para un uso más avanzado. De hecho, puedes conectarte por SSH a tu aplicación donde Node Monkey proporcionará una interfaz de línea de comandos para ejecutar tus propios comandos personalizados. Esto puede ser muy útil para depurar, monitorear o controlar tu aplicación mientras está en ejecución. Proporciona autenticación para seguridad en aplicaciones de producción.

## Contenidos

- [Motivación](#motivation)
- [Características](#features)
- [Instalación](#installation)
- [Uso rápido](#quick-usage)
- [Servidor](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md)
  - [Proporciona el tuyo](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own)
  - [Opciones](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options)
  - [Propiedades](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#properties)
  - [Métodos](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#methods)
- [Cliente (navegador)](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md)
  - [Propiedades](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#properties)
  - [Métodos](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#methods)
- [SSH](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md)
  - [Configuración](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#setup)
  - [Uso](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#usage)
- [Gestión de usuarios](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/user-management.md)
- [Contribuir](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/contributing.md)
- [Historial de cambios](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/CHANGELOG.md)
- [Licencia MIT](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)

## Motivación

La motivación para este proyecto surgió al intentar depurar un servidor Node.js que escribí y que usaba websockets. Encontré problemático inspeccionar objetos en la terminal porque la salida era demasiado grande y no navegable. Intenté usar la depuración incorporada que funciona con el [plugin de Chrome Developer Tools](https://github.com/joyent/node/wiki/using-eclipse-as-node-applications-debugger) para Eclipse. Desafortunadamente, tuve un problema donde al poner puntos de interrupción para inspeccionar objetos, el servidor dejaba de responder a latidos (heartbeats) causando que el cliente se desconectara. Esto arruinaba completamente mis esfuerzos de depuración. Todo lo que realmente necesitaba era una buena manera de inspeccionar objetos.

Busqué en Google y encontré proyectos como [node-inspector](https://github.com/dannycoates/node-inspector), que no funcionaba con las versiones más recientes de Node, y [node-codein](http://thomashunter.name/blog/nodejs-console-object-debug-inspector/) que tenía muchos errores. Y ninguno funcionaba con Firefox. ¡Así nació Node Monkey!

## Características

- Registrar la salida de consola de tu aplicación en una consola del navegador para una inspección más sencilla
  - Proporciona un stream para quienes usan Bunyan (ver [aquí](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#nodemonkeybunyan_stream))
- Proporciona capacidad SSH para que puedas obtener un shell en tu aplicación para inspección, depuración o control de tu aplicación
- Registra comandos para tu aplicación que pueden ejecutarse desde la consola del navegador o la interfaz SSH

## Instalación

```
npm install --save node-monkey
```

Si estás interesado en probar funciones experimentales y próximas, ejecuta esto en su lugar:

```
npm install --save node-monkey@next
```

## Uso Rápido

Aunque Node Monkey soporta muchas características, empezar está diseñado para ser extremadamente fácil. Todo lo que tienes que hacer es incluir una o dos líneas en tu aplicación. Cualquier cosa que se registre en la consola después de esto aparecerá en la consola del navegador una vez conectado. Captura la salida de la mayoría de las llamadas a funciones `console.*` y reenvía la salida al navegador para inspección.

El uso más sencillo se ve así:

```js
const NodeMonkey = require("node-monkey")
NodeMonkey()
```
Node Monkey también soporta muchas [opciones](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options) de configuración y instancias nombradas. La llamada tiene la forma `NodeMonkey([options[, name])`. Así que, por ejemplo, para suprimir la salida local en la consola y ver solo la salida en tu navegador o terminal conectado, podrías hacer algo como esto:


```js
const NodeMonkey = require("node-monkey")
const monkey = NodeMonkey({
  server: {
    disableLocalOutput: true,
  },
})
```

Puedes incluir Node Monkey en todos los archivos dentro de tu aplicación que desees y si se usa como en los ejemplos anteriores, cada llamada a `NodeMonkey()` siempre devolverá la misma instancia que construiste primero, ignorando cualquier opción pasada en llamadas posteriores. Sin embargo, es posible que desees construir nuevas instancias con diferentes opciones. Para hacerlo, asigna un nombre a tu instancia:

```js
const NodeMonkey = require("node-monkey")
const monkey1 = NodeMonkey() // Creates an instance named 'default'
const monkey2 = NodeMonkey("george") // Creates a new instance with default options
const monkey3 = NodeMonkey(
  {
    // Creates a new instance with custom options named 'ninja'
    server: {
      silent: true,
    },
  },
  "ninja",
)
```

Si no especificas un puerto para las instancias adicionales, se configurará automáticamente y simplemente se incrementará a partir del valor predeterminado (por ejemplo, 50502, 50504 para el servidor websocket y 50503, 50505 para el servidor SSH).

Para obtener una instancia ya construida en otro archivo, simplemente llámala con el nombre nuevamente:

```js
const NodeMonkey = require("node-monkey")
const monkey3 = NodeMonkey("ninja")
```

Cuando inicies tu aplicación verás la siguiente salida:

```
Node Monkey listening at http://0.0.0.0:50500
```

Para conectar tu navegador simplemente ve a la dirección que muestra en tu navegador web (`http://0.0.0.0:50500` en este caso). Si cambias la configuración predeterminada de `host` y `port` o proporcionas tu propio servidor, asegúrate de ajustar la URL en consecuencia. Te pedirá un nombre de usuario y contraseña. Hasta que configures un usuario, el predeterminado es `guest` y `guest`.

Si proporcionas tu propio servidor, puedes ver la salida en la consola de tu propia aplicación web en su lugar. Para ver cómo proporcionar tu propio servidor, consulta la [documentación](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own). Necesitarás incluir la siguiente etiqueta `<script>` en el código fuente HTML para integrar la salida de Node Monkey con tu aplicación:

```html
<script type="text/javascript" src="http://0.0.0.0:50500/monkey.js"></script>
```

**NOTE**: You do NOT have to refresh the page when you restart your Node.js application to continue to receive output. Node Monkey will automatically reconnect.

---

### LICENSE: [MIT](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-23

---