# Plugin de IntelliJ para Pebble [![Gitter](https://badges.gitter.im/bjansen/pebble-intellij.svg)](https://gitter.im/bjansen/pebble-intellij) [![GitHub Actions](https://github.com/bjansen/pebble-intellij/workflows/Java%20CI/badge.svg?branch=master)](https://github.com/bjansen/pebble-intellij/actions) [![GitHub release](https://img.shields.io/github/release/bjansen/pebble-intellij.svg)](https://plugins.jetbrains.com/plugin/9407-pebble) [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=pebble-intellij&metric=coverage)](https://sonarcloud.io/dashboard?id=pebble-intellij)

Este plugin proporciona soporte para el [motor de plantillas Pebble](https://github.com/PebbleTemplates/pebble) en 
IntelliJ IDEA 2017.3 y versiones posteriores.

<p align="center">
  <img src="https://github.com/bjansen/pebble-intellij/raw/master/images/plugin.png" 
       width="594" alt="Plugin de IntelliJ para Pebble"/>
<p>

## Características

* parser/lexer<sup>1</sup> y resaltado de sintaxis (soporta delimitadores personalizados)
* plantillas en vivo para etiquetas incorporadas
* coincidencia de llaves, plegado de código y comentarios
* manejador de comillas
* navegación (métodos y campos, archivos incluidos)
* autocompletado de código
* resaltar referencias desconocidas
* soporte para variables y funciones introducidas por [pebble-spring](https://github.com/PebbleTemplates/pebble/wiki/spring-integration)
* [más por venir](https://github.com/bjansen/pebble-intellij/issues?utf8=%E2%9C%93&q=is%3Aissue%20is%3Aopen%20label%3At-feature)

<sup>1</sup>: *Actualmente no se soportan operadores personalizados*.

## Instalación

Este plugin está disponible en el [repositorio de plugins](https://plugins.jetbrains.com/idea/plugin/9407-pebble) de JetBrains,
desde tu IDE ve a `Preferences > Plugins` y escribe `pebble` en la barra de búsqueda.

## Mezclando Pebble y otros lenguajes

Para que el editor reconozca dos lenguajes en el mismo archivo, por ejemplo HTML 
y Pebble, ve a `Preferences > Languages & Frameworks > Template Data Languages`
y selecciona el lenguaje de datos `HTML` en el directorio que contiene tus plantillas Pebble:

![Configuración de lenguajes de datos para plantillas](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/settings.png)

Esto habilitará características como resaltado de sintaxis, autocompletado, navegación,
expansiones Emmet, etc.

## Uso del autocompletado

Para usar el autocompletado, debes indicarle al plugin cuál es el tipo
de `foo`. Esto se puede hacer usando pistas `@pebvariable`, similar a los plugins de JSP, FreeMarker
y Velocity:

![Autocompletado](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/completion.png)

Las pistas `@pebvariable` pueden añadirse fácilmente a las plantillas mediante la plantilla en vivo `var`. Deben
seguir esta sintaxis:

    {# @pebvariable name="<nombre>" type="<tipo>" #}

Para que el autocompletado funcione correctamente en el atributo `type`, tus archivos `.peb` deben estar ubicados
bajo una [raíz de contenido](https://www.jetbrains.com/help/idea/content-roots.html) (por ejemplo, `src/main/resources`).
De lo contrario, las clases definidas en tus propios archivos fuente no serán sugeridas.

## Versiones nocturnas

Las compilaciones snapshot están disponibles como parte de Actions CI:
 * ve a https://github.com/bjansen/pebble-intellij/actions
 * haz clic en la compilación más reciente
 * desplázate hasta la parte inferior de la página, en la sección `Artifacts` haz clic en `pebble-intellij-development`
 * esto descargará un archivo zip que puede ser instalado en tu IDE usando [Instalar plugin desde disco](https://www.jetbrains.com/help/idea/managing-plugins.html#install_plugin_from_disk)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---