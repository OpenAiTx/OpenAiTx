# IntelliJ plugin for Pebble [![Gitter](https://badges.gitter.im/bjansen/pebble-intellij.svg)](https://gitter.im/bjansen/pebble-intellij) [![GitHub Actions](https://github.com/bjansen/pebble-intellij/workflows/Java%20CI/badge.svg?branch=master)](https://github.com/bjansen/pebble-intellij/actions) [![GitHub release](https://img.shields.io/github/release/bjansen/pebble-intellij.svg)](https://plugins.jetbrains.com/plugin/9407-pebble) [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=pebble-intellij&metric=coverage)](https://sonarcloud.io/dashboard?id=pebble-intellij)

This plugin provides support for the [Pebble templating engine](https://github.com/PebbleTemplates/pebble) in 
IntelliJ IDEA 2017.3 and later.

<p align="center">
  <img src="https://github.com/bjansen/pebble-intellij/raw/master/images/plugin.png" 
       width="594" alt="IntelliJ plugin for Pebble"/>
<p>

## Features

* parser/lexer<sup>1</sup> and syntax highlighter (supports custom delimiters)
* live templates for built-in tags
* braces matching, code folding and commenting
* quote handler
* navigation (methods and fields, included files)
* code completion
* highlight unknown references
* support for variables and functions introduced by [pebble-spring](https://github.com/PebbleTemplates/pebble/wiki/spring-integration)
* [more to come](https://github.com/bjansen/pebble-intellij/issues?utf8=%E2%9C%93&q=is%3Aissue%20is%3Aopen%20label%3At-feature)

<sup>1</sup>: *Custom operators are currently not supported*.

## Installation

This plugin is available in JetBrains' [plugin repository](https://plugins.jetbrains.com/idea/plugin/9407-pebble),
from your IDE go to `Preferences > Plugins` and enter `pebble` in the search bar.

## Mixing Pebble and other languages

To make the editor recognize two languages in the same file, for example HTML 
and Pebble, go to `Preferences > Languages & Frameworks > Template Data Languages`
and select the `HTML` data language on the directory that contains your Pebble
templates:

![Template data languages settings](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/settings.png)

This will enable features like syntax highlighting, code completion, navigation,
Emmet expansions etc.

## Using code completion

In order to use code completion, you will have to let the plugin know what the type
of `foo` is. This can be done using `@pebvariable` hints, much like in the JSP, FreeMarker
and Velocity plugins:

![Code completion](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/completion.png)

`@pebvariable` hints can be easily added to templates via the `var` live template. They must
follow this syntax:

    {# @pebvariable name="<name>" type="<type>" #}

For code completion to work properly in the `type` attribute, your `.peb` files need to be placed
under a [content root](https://www.jetbrains.com/help/idea/content-roots.html) (e.g. `src/main/resources`).
Otherwise, classes defined in your own source files won't be suggested.

## Nightly builds

Snapshot builds are available as part of the Actions CI:
 * go to https://github.com/bjansen/pebble-intellij/actions
 * click on the latest build
 * scroll to the bottom of the page, under the `Artifacts` section click on `pebble-intellij-development`
 * this will download a zip file that can be installed in your IDE using [Install plugin from disk](https://www.jetbrains.com/help/idea/managing-plugins.html#install_plugin_from_disk)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---