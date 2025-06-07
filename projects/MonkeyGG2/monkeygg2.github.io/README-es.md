<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Tu sitio de juegos amigable del vecindario.</p>
<br>

Bienvenido a MonkeyGG2, un sitio de juegos lleno de funciones creado para ti. ¡Con más de 150 juegos para elegir, MonkeyGG2 ofrece una experiencia de juego única y personalizable! Seas un gamer, un desarrollador, o un usuario promedio, MonkeyGG2 brinda un entorno de juego fluido y agradable.

> ¡Considera darnos una estrella! Especialmente si has hecho un fork de este repositorio o le has encontrado alguna otra utilidad.

## Características

-   Más de 150 juegos
-   Fácil de usar
-   Fácil de desplegar
-   Personalizable
-   Proxy
-   Y mucho más...

## Personalización

### Configuración

#### Enmascaramiento (Cloaking)

El enmascaramiento se refiere a abrir la página en una pestaña `about:blank`. Este comportamiento está forzado por defecto, aunque puede ser deshabilitado. Hay preajustes disponibles para el enlace de redirección, pero también se puede configurar manualmente.

#### Mascara (Masking)

La máscara se refiere a cambiar el icono y el título de la pestaña de about:blank. Hay preajustes disponibles para el icono y el título de la pestaña, pero también se puede configurar manualmente.

#### Atajos

Se pueden crear atajos de teclado personalizados para realizar una variedad de tareas. Por ejemplo, salir del juego, enmascarar la pestaña y ejecutar JavaScript personalizado están soportados.
> Nota: si deseas ejecutar JavaScript personalizado, asegúrate de saber lo que estás haciendo. Si algo sale mal, recargar la página siempre es la solución.

#### Tema

Actualmente se soportan las siguientes personalizaciones de tema:
- Activar/Desactivar animación de fondo (si te preocupa el rendimiento en medio del juego, no te preocupes, se desactiva automáticamente cuando estás jugando)
- Color de fondo
- Color de bloques
- Color de botones
- Color de los juegos
- Color al pasar el ratón (hover)
- Color de la barra de desplazamiento
- Color de la pista de la barra de desplazamiento
- Color de fuente

> Nota: si accidentalmente cambias los colores de manera que el sitio sea inutilizable, tendrás que borrar tus cookies y almacenamiento local.

### Personalización Avanzada

> Aviso: Las siguientes personalizaciones solo están disponibles para los propietarios del repositorio o de cualquier fork del mismo.

El archivo `config.jsonc` está formateado para incluir la configuración de todo el sitio. Actualmente, se soportan los siguientes elementos:
- Juegos
- Temas (próximamente)
- Configuración de Proxy

#### Juegos

Cada entrada de juego tiene una clave que representa el nombre a mostrar del juego, y el valor debe ser un objeto con tres pares clave-valor:
- `"path"`: Ruta al juego desde el directorio `./games`
- `"aliases"`: Lista de nombres alternativos para el juego utilizados para mejorar la búsqueda
- `"categories"`: Lista de categorías a las que pertenece el juego (el soporte para agregar iconos llegará pronto)

Agregar una entrada manualmente es posible, pero tedioso, especialmente si deseas ordenar la lista alfanuméricamente (aunque no es necesario para que la configuración funcione).
Por eso se creó el script `add-game-entry.js`, una forma fácil de agregar un nuevo juego a la configuración sin tener que editar el archivo manualmente.

```bash
# Puedes usar cualquier entorno de ejecución JS como node.js, bun o deno
# En este ejemplo se usará bun porque instala las dependencias automáticamente
bun add-game-script.js
# Responde las preguntas que sigan y la configuración se actualizará
```

#### Temas

Estándar de tema aún no implementado (TODO)

#### Proxy

Las opciones de configuración del proxy están bajo la clave **"config"**. 
El valor de la clave `"proxy"` es un valor booleano que habilita o deshabilita la función de proxy. Si `"proxy"` está en falso, el usuario verá un diálogo de error al intentar acceder al proxy.
El valor de la clave `"proxyPath"` es la ruta hacia el proxy. Puede ser una ruta absoluta o relativa, pero el proxy debe soportar **CORS** ya que la página del proxy se mostrará como un iframe en el sitio.


## Despliegue

### Sin Proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

Alternativamente, puedes hacer un fork de este repositorio en [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) o en [Codeberg](https://codeberg.org/MonkeyGG2/pages) y desplegar en GitHub Pages o Codeberg Pages, respectivamente.

### Con Proxy

Visita la página de [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) para saber más sobre cómo alojar MonkeyGG2 con un proxy.

### Ejecutando Localmente

```bash
# ADVERTENCIA: si tienes una carpeta llamada "monkeygg2", este comando eliminará todos los archivos dentro de esa carpeta
# por favor cambia el nombre del directorio en los siguientes dos comandos
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# desde aquí puedes usar cualquier herramienta para ejecutar un servidor estático, en este ejemplo se usará "live-server" de npm
npm install -g live-server # solo si no lo tienes instalado ya
npx live-server
```

## Licencia

Distribuido bajo la licencia WTFPL. Consulta [aquí](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) para más detalles.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---