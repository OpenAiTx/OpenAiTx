Yuebing 🥮
==========
Yuebing es un software de código abierto para ejecutar sitios de alojamiento de videos.

Yuebing prepara automáticamente tus videos fuente para transmisión usando formatos modernos, reproducibles en cualquier
dispositivo y con cualquier conexión.

Yuebing puede usar Amazon S3 o Backblaze B2 para el almacenamiento backend, y tiene muchas funciones avanzadas.

### Fuente
* [yuebing en GitHub](https://github.com/cobbzilla/yuebing)
* [yuebing en npm](https://www.npmjs.com/package/yuebing)
* [yuebing en DockerHub](https://hub.docker.com/r/cobbzilla/yuebing)

# Leer esto en otro idioma
Este documento README.md ha sido traducido, mediante [hokeylization](https://github.com/cobbzilla/hokeylization), a
muchos idiomas.

Estoy seguro de que no es perfecto, ¡pero espero que sea mejor que nada!

&nbsp;&nbsp;&nbsp;[🇸🇦 Árabe](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ar/README.md)
&nbsp;&nbsp;&nbsp;[🇧🇩 Bengalí](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/bn/README.md)
&nbsp;&nbsp;&nbsp;[🇩🇪 Alemán](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/de/README.md)
&nbsp;&nbsp;&nbsp;[🇺🇸 Inglés](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/en/README.md)
&nbsp;&nbsp;&nbsp;[🇪🇸 Español](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/es/README.md)
&nbsp;&nbsp;&nbsp;[🇫🇷 Francés](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/fr/README.md)
&nbsp;&nbsp;&nbsp;[🇹🇩 Hausa](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ha/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇳 Hindi](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/hi/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇩 Indonesio](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/id/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇹 Italiano](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/it/README.md)
&nbsp;&nbsp;&nbsp;[🇯🇵 Japonés](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ja/README.md)
&nbsp;&nbsp;&nbsp;[🇰🇷 Coreano](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ko/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇳 Marathi](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/mr/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇱 Polaco](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/pl/README.md)
&nbsp;&nbsp;&nbsp;[🇧🇷 Portugués](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/pt/README.md)
&nbsp;&nbsp;&nbsp;[🇷🇺 Ruso](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ru/README.md)
&nbsp;&nbsp;&nbsp;[🇰🇪 Swahili](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/sw/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇭 Tagalo](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/tl/README.md)
&nbsp;&nbsp;&nbsp;[🇹🇷 Turco](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/tr/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇰 Urdu](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ur/README.md)
&nbsp;&nbsp;&nbsp;[🇻🇳 Vietnamita](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/vi/README.md)
&nbsp;&nbsp;&nbsp;[🇨🇳 Chino](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/zh/README.md)
----

# Contenidos
* [Inspiración](#Inspiración)
* [Características](#Características)
* [Instalación](#Instalación)
  * [Docker](#Docker)
  * [Paquete npm](#paquete-npm)
  * [Desde el código fuente](#desde-el-código-fuente)
* [Configuración](#Configuración)
  * [Configuración nginx](#configuración-nginx)
* [¿Por qué el nombre yuebing?](#¿por-qué-el-nombre-yuebing?)

## Inspiración
El año pasado mi mamá dedicó mucho tiempo (¡y dinero!) para organizar y digitalizar un archivo de viejos videos familiares.
Algunos de estos eran bastante antiguos, remontándose a los años 40. Cosas realmente hermosas y clásicas.

Queríamos compartirlos en privado con la familia, pero *no con las grandes tecnológicas*.
Optar por un hospedaje de video "gratuito" de un proveedor importante estaba fuera de discusión.

Lo que buscábamos:
* Autoalojado, pero totalmente **fácil de usar y mantener sin intervención**
* Transmite en formatos de video modernos, incluyendo tasa de bits adaptativa
* Los videos se reproducen en cualquier dispositivo, escritorio o móvil
* Con una conexión de alta velocidad, la calidad del video es excelente; lo mejor posible
  * **Incluso con una mala conexión**, la reproducción mantiene buena calidad y *no se salta ni hace buffering*
* Almacenamiento cifrado, por lo que es posible usar soluciones de almacenamiento en la nube pública con cierta confianza
* Servidor sin estado: persistir cualquier cosa importante en un almacenamiento altamente resiliente
  * **¡No quiero preocuparme por las copias de seguridad!**
  * *Esto era deseable. Resulta que nada existente tiene algo así. ¡Yuebing sí!*
* Después de usar una instancia potente para transcodificar todo, desmontarla y usar algo más barato a largo plazo
  * Puedes ejecutar Yuebing por menos de $10/mes; y con suerte aún menos en el futuro a medida que optimizamos el tamaño de Yuebing

Me tomé un par de semanas para investigar lo que había disponible. Empecé a relajar mucho mis requisitos, y aún así
no encontré nada decente. Revisé varios proyectos de código abierto, no digo cuáles porque todos tenían
múltiples fallos evidentes.

Así que decidí, ¿qué tan difícil podría ser? Conectas S3 con ffmpeg, pones un frontend relativamente moderno, y listo, ¿verdad?
... bueno, eh, la mayor parte del trabajo tomó un par de meses, ¡pero fue demasiado divertido para parar!
¡Espero que tú también lo disfrutes!

### <a style="text-decoration: none; color: inherit" href="https://open.spotify.com/track/0HEYFRBo4pBLLWjXsAZjod?si=riLTqMknTji7_X_4XzSkGQ&context=spotify%3Aalbum%3A20KGjm5xRROTqP0UY1EVRg">**¡Hagamos que alojar sitios de video por cuenta propia sea súper fácil!**</a>

## Características
* Transforma un bucket S3 (o B2) de videos en un sitio de video privado para amigos y familia!
* Conecta uno o más buckets de origen que proporcionan archivos multimedia sin procesar
* Yuebing transcodifica automáticamente los videos fuente al formato más reciente y ampliamente soportado para streaming adaptativo de bitrate (DASH/mp4)
* TODOS los datos se almacenan en el bucket de destino; puedes destruir el servidor cuando quieras
  * Útil para ejecutar inicialmente en una instancia optimizada para CPU para la transcodificación inicial, luego ejecutar \
    en una instancia mucho más barata para servicio 24/7/365.
  * Soporta almacenamiento completamente encriptado (encriptación del lado de la aplicación, solo tú tienes la clave)
  * Siempre solo lectura desde la fuente, nunca modifica el contenido fuente
  * Escaneo automático y manual para nuevos archivos multimedia
* ¿Qué tan privado o público quieres que sea? Yuebing soporta:
  * Totalmente privado: no se muestra contenido multimedia a usuarios anónimos, solo direcciones de correo aprobadas pueden crear cuentas
  * Semi-privado: no se muestra contenido multimedia a usuarios anónimos, pero cualquiera puede crear una cuenta de usuario
  * Público con registro limitado: contenido multimedia visible para todos, pero solo direcciones de correo aprobadas pueden crear cuentas
  * Totalmente público: contenido multimedia visible para todos, y cualquiera puede crear una cuenta de usuario
* Totalmente internacionalizado! Todo el texto visible para el usuario (y otras cosas específicas de la localidad) proviene de recursos localizados
  * [¡Ayuda a la comunidad, traduce Yuebing a nuevos idiomas!](https://github.com/cobbzilla/yuebing/blob/master/docs/localize.md)
* Consola de administración con todas las funciones
* Busca videos por palabras clave, o desde la nube de etiquetas
* <a href="https://www.patreon.com/cobbzilla">**Próximamente con tu apoyo**</a>:
  * Soporte para más tipos de medios (audio, imágenes, etc)
  * Medios subidos por usuarios
  * Likes, compartidos y notificaciones push
  * Nuevo "tipo de fuente": ¡Otra instancia de Yuebing!
    * Federación entre instancias amigas: búsqueda unificada, cuentas de usuario, etc

## Funcionalidad para usuarios anónimos (si el sitio ha sido configurado para permitir visitantes anónimos)
* Navegar medios
* ¡Ver medios!
* Crear cuenta (si el sitio ha sido configurado para permitir registro de cuentas)

## Funcionalidades para usuarios conectados
* Navegar medios
* ¡Ver medios!
* Añadir un comentario, editar tu comentario, eliminar tu comentario!
* Invitar amigos
* Editar información de la cuenta
* Eliminar cuenta, elimina todo lo que es tuyo incluyendo todos tus comentarios

## Funciones de usuario administrador
* Editar metadatos de medios, ver miniaturas, cambiar miniatura seleccionada
* Ver cola de transformación de medios y estado de trabajos
* Iniciar nuevos escaneos e índices del medio fuente

## Funciones del servidor/backend
* Amigable con datos transitorios, NO se almacena ningún dato persistente/importante dentro del contenedor.
  * Todos los datos duraderos se persisten en el bucket de destino; esencialmente, usamos S3 como nuestra base de datos
* Escaneo periódico automático del bucket fuente para nuevos medios
* Añadir y cambiar metadatos de medios; las ediciones se almacenan en el bucket de destino, el medio fuente nunca se modifica
* Perfiles de salida configurables. Por defecto es DASH-mp4 con múltiples subperfiles
* La información de la cuenta de usuario también se almacena en el bucket de destino, opcionalmente cifrada
  * Si la clave de cifrado cambia, el administrador puede migrar usuarios a la nueva clave con la consola web administrativa

## Instalación
Puedes instalar y ejecutar `yuebing` mediante docker, npm o directamente desde el código fuente.

### Docker
Si tienes docker, puedes empezar con Yuebing rápidamente:

    docker run -it cobbzilla/yuebing

### Paquete npm
    # instalar globalmente con npm
    npm i -g yuebing

    # instalar globalmente con yarn
    yarn global add yuebing

    # Ahora el comando 'yuebing' debería estar en tu PATH
    yuebing

### Desde el código fuente
Para ejecutar desde el código fuente, necesitarás nodejs v16+ y yarn

    # Clonar el código fuente e instalar dependencias
    git clone https://github.com/cobbzilla/yuebing.git
    cd yuebing
    yarn install

    # Usa el comando 'yuebing' desde el repositorio git
    ./yuebing

    # O, dado que tienes el código fuente, ejecuta cualquiera de los scripts `yarn`
    yarn docker-run-dev    # Compilación y arranque más rápido, imagen docker de desarrollo
    yarn docker-run        # Más rápido en tiempo de ejecución, imagen docker de producción
    yarn dev               # Ejecuta yuebing localmente en modo desarrollo
    yarn build             # Compila yuebing localmente para modo producción
    yarn start             # Inicia yuebing localmente en modo producción

Consulta la [documentación para desarrolladores](https://github.com/cobbzilla/yuebing/blob/master/docs/developer.md) para más información

## Configuración
Para probar Yuebing, está bien iniciarlo sin configurar nada.
Ejecuta `yuebing` y se te pedirá ingresar la configuración mínima al iniciar.

Si planeas usar Yuebing por un tiempo, consulta la [documentación de configuración](https://github.com/cobbzilla/yuebing/blob/master/docs/config.md) para
más información sobre cómo configurarlo.

### configuración de nginx
Yuebing es una app Nuxt, y espera que pongas nginx (u otro servidor web)
delante para manejar SSL, limitación de tasa si es necesario, etc.

Si usas nginx, aquí tienes un [ejemplo de configuración](https://github.com/cobbzilla/yuebing/blob/master/docs/sample-yuebing-nginx.conf) que puedes usar.

## ¿Por qué el nombre yuebing?
[Oolong el conejo](https://en.wikipedia.org/wiki/Oolong_(rabbit)) fue un adorable y famoso
[meme temprano de internet](https://duckduckgo.com/?q=oolong+rabbit&ia=images&iax=images). Oolong murió en 2003,
¡dos años antes de que existiera cierto servicio de vídeo masivamente popular!

El sucesor de Oolong fue llamado Yuebing. Yuebing no fue tan famoso como Oolong, ¿pero acaso eso importaba?
Yuebing triunfó de todas formas.

Quizás más interesante, yuebing significa [pastel de luna](https://en.wikipedia.org/wiki/Mooncake)
(Chino: [月饼](https://zh.wikipedia.org/wiki/%E6%9C%88%E9%A5%BC),
Japonés: [月餅](https://ja.wikipedia.org/wiki/%E6%9C%88%E9%A4%85)); los pasteles de luna son muy sabrosos y se pueden encontrar en
una amplia variedad de sabores y estilos. Disfruta de un estilo regional consagrado por el tiempo, o prueba un pastel exótico de panaderos contemporáneos  
que están explorando territorios deliciosamente inexplorados. ¡Realmente hay un yuebing para todos!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-14

---