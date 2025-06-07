# Una colección de plantillas `.gitignore`

Esta es la colección de plantillas de archivos [`.gitignore`][man] de GitHub.
Usamos esta lista para poblar los selectores de plantillas `.gitignore` disponibles
en la interfaz de GitHub.com al crear nuevos repositorios y archivos.

Para obtener más información sobre cómo funcionan los archivos `.gitignore` y cómo usarlos,
los siguientes recursos son un excelente punto de partida:

- El [capítulo Ignorando archivos][chapter] del libro [Pro Git][progit].
- El [artículo Ignorando archivos][help] en el sitio de ayuda de GitHub.
- La página de manual [gitignore(5)][man].

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## Estructura de carpetas

Soportamos una colección de plantillas, organizadas de la siguiente manera:

- La carpeta raíz contiene plantillas de uso común, para ayudar a las personas a comenzar
  con los lenguajes de programación y tecnologías más populares. Estas definen un conjunto
  significativo de reglas para ayudar a empezar y asegurar que no estás incluyendo
  archivos sin importancia en tu repositorio.
- [`Global`](./Global) contiene plantillas para varios editores, herramientas y
  sistemas operativos que pueden usarse en diferentes situaciones. Se recomienda
  que [agregues estos a tu plantilla global](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)
  o combines estas reglas en las plantillas específicas de tu proyecto si deseas usarlas
  de forma permanente.
- [`community`](./community) contiene plantillas especializadas para otros lenguajes,
  herramientas y proyectos populares, que actualmente no pertenecen a las plantillas principales.
  Estas deben ser agregadas a las plantillas específicas de tu proyecto cuando decidas
  adoptar el framework o herramienta.

## ¿Qué hace a una buena plantilla?

Una plantilla debe contener un conjunto de reglas para ayudar a que los repositorios Git funcionen con un
lenguaje de programación, framework, herramienta o entorno específico.

Si no es posible seleccionar un pequeño conjunto de reglas útiles para esta situación,
entonces la plantilla no es adecuada para esta colección.

Si una plantilla es principalmente una lista de archivos instalados por una versión particular de
algún software (por ejemplo, un framework de PHP), podría estar en el directorio `community`.
Consulta [plantillas versionadas](#versioned-templates) para más detalles.

Si tienes un conjunto pequeño de reglas, o deseas soportar una tecnología que no es
ampliamente utilizada, y aún crees que esto será útil para otros, por favor lee la
sección sobre [plantillas especializadas](#specialized-templates) para más detalles.

Incluye detalles al abrir un pull request si la plantilla es importante y visible.
Puede que no la aceptemos inmediatamente, pero podemos promoverla a la raíz en una fecha posterior
según el interés.

Por favor, entiende también que no podemos listar todas las herramientas que han existido.
Nuestro objetivo es seleccionar una colección de las plantillas _más comunes y útiles_,
no asegurar que cubrimos todos los proyectos posibles. Si decidimos no
incluir tu lenguaje, herramienta o proyecto, no es porque no sea excelente.

## Guía de contribución

Nos encantaría que nos ayudes a mejorar este proyecto. Para ayudarnos a mantener esta colección
de alta calidad, solicitamos que las contribuciones sigan las siguientes pautas.

- **Proporciona un enlace a la página principal de la aplicación o proyecto**. A menos que sea
  extremadamente popular, existe la posibilidad de que los mantenedores no conozcan o utilicen
  el lenguaje, framework, editor, aplicación o proyecto al que aplica tu cambio.

- **Proporciona enlaces a la documentación** que respalden el cambio que estás realizando.
  La documentación actual y oficial que mencione los archivos a ignorar es lo mejor.
  Si no hay documentación disponible para respaldar tu cambio, haz lo mejor que puedas
  para explicar para qué son los archivos que se están ignorando.

- **Explica por qué estás realizando un cambio**. Incluso si parece evidente, por favor
  tómate una o dos frases para decirnos por qué debe realizarse tu cambio o adición.
  Es especialmente útil articular por qué este cambio aplica a _todas las personas_
  que trabajan con la tecnología aplicable, y no solo a ti o tu equipo.

- **Por favor, considera el alcance de tu cambio**. Si tu cambio es específico de un
  determinado lenguaje o framework, asegúrate de que el cambio se realice en la
  plantilla de ese lenguaje o framework, en vez de en la plantilla de un
  editor, herramienta o sistema operativo.

- **Por favor, modifica _solo una plantilla_ por pull request**. Esto ayuda a mantener
  los pull requests y los comentarios enfocados en un proyecto o tecnología específica.

En general, cuanto más puedas ayudarnos a entender el cambio que estás realizando,
más probable será que aceptemos tu contribución rápidamente.

## Plantillas versionadas

Algunas plantillas pueden cambiar mucho entre versiones, y si deseas contribuir
a este repositorio necesitamos seguir este flujo específico:

- la plantilla en la raíz debe ser la versión soportada actualmente
- la plantilla en la raíz no debe tener una versión en el nombre del archivo (es decir,
  "siempre verde")
- las versiones anteriores de las plantillas deben estar en `community/`
- las versiones anteriores de la plantilla deben incluir la versión en el nombre del archivo,
  para mayor claridad

Esto ayuda a asegurar que los usuarios obtengan la última versión (porque usarán la que esté
en la raíz) pero ayuda a los mantenedores a soportar versiones antiguas que aún existen.

## Plantillas especializadas

Si tienes una plantilla que te gustaría contribuir, pero no es del todo
principal, considera agregarla al directorio `community` bajo una
carpeta que se adecúe a donde pertenece.

Las reglas en tu plantilla especializada deben ser específicas para el framework o
herramienta, y cualquier plantilla adicional debe mencionarse en un comentario en el
encabezado de la plantilla.

Por ejemplo, esta plantilla podría estar en `community/DotNet/InforCRM.gitignore`:

```
# plantilla gitignore para InforCRM (anteriormente SalesLogix)
# sitio web: https://www.infor.com/product-summary/cx/infor-crm/
#
# Recomendado: VisualStudio.gitignore

# Ignorar archivos de modelo que son autogenerados
ModelIndex.xml
ExportedFiles.xml

# Ignorar archivos de despliegue
[Mm]odel/[Dd]eployment

# Incluir forzosamente archivos SupportFiles del portal
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## Flujo de contribución

Así sugerimos que propongas un cambio a este proyecto:

1. [Haz un fork de este proyecto][fork] a tu cuenta.
2. [Crea una rama][branch] para el cambio que deseas hacer.
3. Realiza tus cambios en tu fork.
4. [Envía un pull request][pr] desde la rama de tu fork a nuestra rama `main`.

Usar la interfaz web para hacer cambios también está bien, y te ayudará
realizando automáticamente el fork del proyecto y permitiéndote enviar un pull request también.

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## Licencia

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---