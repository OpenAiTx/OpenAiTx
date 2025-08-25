![Captura de pantalla de la aplicación Ogres](https://raw.githubusercontent.com/samcf/ogres/main/site/web/media/ogres-media-collection.webp)

## Características

[ogres.app](https://ogres.app) es una mesa virtual gratuita y de código abierto que puedes ejecutar en tu navegador y usar para jugar con tus amigos. Su objetivo es ser una alternativa muy ligera a algunas de las herramientas más completas disponibles hoy en día. Su conjunto limitado de funciones principales está diseñado para ayudar a los maestros de mazmorras a configurar rápidamente encuentros y aventuras con solo lo más importante.

- Comienza a preparar tu juego al instante; sin registros ni anuncios
- Inicia una sesión colaborativa en línea para tus amigos
- Prepara y administra múltiples escenas a la vez
- Rastreador de iniciativa incorporado para encuentros optimizados
- Diseño adaptable para teléfonos y tabletas
- Fácil de usar para otros sistemas de juego
- ... ¡y mucho más planeado!

## Contribuir

¿Interesado en ayudar a corregir errores o ampliar funciones? Busca problemas etiquetados como **amigables para principiantes** y comenta que te gustaría trabajar en ello. A continuación, se presentan las instrucciones para iniciar un entorno de desarrollo local (solo para desarrolladores).

> [!IMPORTANTE]
> Necesitarás tener instalados `node`, `npm` y `clojure`.

```sh
#!/bin/sh

# copy the repository
git clone git@github.com:samcf/ogres.git

# install dependencies and start the local web server
# by default opens at http://localhost:8080
npm install
npm start

# run the process that bundles CSS files
npm run style

# optionally, start the application server necessary
# for hosting online sessions
clojure -M -m ogres.server.core 5000
```

## Ejecuta tu propio servidor

Puedes ejecutar tu propia instancia de esta aplicación utilizando Docker. Para más información, consulta la [documentación wiki](https://github.com/samcf/ogres/wiki/Docker-Usage). El siguiente comando instalará y ejecutará la aplicación.

```sh
#!/bin/sh
docker compose up -d
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---