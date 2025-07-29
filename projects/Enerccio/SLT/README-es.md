# SLT - Un plugin de lenguaje Common Lisp para la línea de IDEs de Jetbrains

![GitHub release (latest by date)](https://img.shields.io/github/v/release/Enerccio/SLT)
[![Version](https://img.shields.io/jetbrains/plugin/v/21132-slt.svg)](https://plugins.jetbrains.com/plugin/21132-slt)
![JetBrains plugins](https://img.shields.io/jetbrains/plugin/d/21132)
![GitHub Release Date](https://img.shields.io/github/release-date/Enerccio/SLT)
![OSS Lifecycle](https://img.shields.io/osslifecycle/Enerccio/SLT)
![GitHub](https://img.shields.io/github/license/Enerccio/SLT)
![GitHub lisp counter](https://img.shields.io/github/search/Enerccio/SLT/lisp)
[![0.1.0](https://badgen.net/github/milestones/enerccio/SLT/1)](https://github.com/enerccio/SLT/milestone/1)
[![0.2.0](https://badgen.net/github/milestones/enerccio/SLT/2)](https://github.com/enerccio/SLT/milestone/2)
[![0.3.0](https://badgen.net/github/milestones/enerccio/SLT/4)](https://github.com/enerccio/SLT/milestone/4)
[![0.4.0](https://badgen.net/github/milestones/enerccio/SLT/5)](https://github.com/enerccio/SLT/milestone/5)
[![0.5.0](https://badgen.net/github/milestones/enerccio/SLT/6)](https://github.com/enerccio/SLT/milestone/6)
![GitHub all releases](https://img.shields.io/github/downloads/Enerccio/SLT/total)
![GitHub last commit](https://img.shields.io/github/last-commit/Enerccio/SLT)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/Enerccio/SLT)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/Enerccio/SLT)
![Lines of code](https://img.shields.io/tokei/lines/github/Enerccio/SLT)
![GitHub top language](https://img.shields.io/github/languages/top/Enerccio/SLT)
[![(want-to-support-me? T NIL)](https://img.shields.io/liberapay/receives/Enerccio.svg?logo=liberapay)](https://liberapay.com/Enerccio)
![Liberapay patrons](https://img.shields.io/liberapay/patrons/Enerccio)
[![Support me on Patreon](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Denerccio%26type%3Dpledges&style=flat)](https://patreon.com/enerccio)[![Support me on Patreon](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Denerccio%26type%3Dpatrons&style=flat)](https://patreon.com/enerccio)
![Maintenance](https://img.shields.io/maintenance/yes/2023)
![GitHub issues](https://img.shields.io/github/issues/Enerccio/SLT)
![GitHub branch checks state](https://img.shields.io/github/checks-status/Enerccio/SLT/master)

[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/SLT_IDE?style=social)](https://old.reddit.com/r/SLT_IDE/)
![GitHub forks](https://img.shields.io/github/forks/Enerccio/SLT?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/Enerccio/SLT?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/Enerccio/SLT?style=social)
[![Join the chat at https://gitter.im/SLT-Plugin/community](https://badges.gitter.im/SLT-Plugin/Lobby.svg)](https://gitter.im/SLT-Plugin/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
![GitHub Discussions](https://img.shields.io/github/discussions/Enerccio/SLT)

![Image](https://raw.githubusercontent.com/Enerccio/SLT/master/src/main/resources/logo/logo.svg)

**¡ESTE PLUGIN ES EXPERIMENTAL y puede fallar en cualquier momento! ¡Por favor reporta todos los errores!**

Este plugin proporciona soporte para Common Lisp en los IDEs de JetBrains.  
Usa un protocolo SLIME/Swank modificado para comunicarse con el intérprete de Lisp proporcionando  
capacidades de IDE para Common Lisp.

# Guía de instalación y uso (algo) detallada

Ahora puedes descargar el plugin desde el marketplace! https://plugins.jetbrains.com/plugin/21132-slt

https://github.com/Enerccio/SLT/wiki/User-Guide

## Requisitos

1) IDE basado en Intellij - probado en `Intellij Idea Community/Ultimate` pero debería funcionar en todos los IDEs principales  
   1) Las versiones soportadas son desde 2022.2 en adelante

Opcionalmente (ver más - guía):

1) Uno de los intérpretes LISP soportados instalado:  
   * [Steel Bank Common Lisp](https://www.sbcl.org/)  
   * [Armed Bear Common Lisp](https://armedbear.common-lisp.dev/)  
   * [Clozure Common Lisp](https://ccl.clozure.com/)  
   * [Allegro CL](https://franz.com/products/allegro-common-lisp/)  
   * [CMUCL](https://www.cons.org/cmucl/)  
2) [Quicklisp](https://www.quicklisp.org/beta/) instalado

(¡No todas las características funcionan con todos los intérpretes, ve [FEATURES.md](https://raw.githubusercontent.com/Enerccio/SLT/master/FEATURES.md) para más información!)

## Comenzando

Consulta https://github.com/Enerccio/SLT/wiki/User-Guide#plugin-installation

## Opciones del plugin

- Consulta la guía anterior para el SDK  
- Para cambiar colores https://github.com/Enerccio/SLT/wiki/User-Guide#change-colors-of-elements  
- Para cambiar la sangría https://github.com/Enerccio/SLT/wiki/User-Guide#change-indentation-settings

## Compilando el código fuente

Clona el repositorio y modifica gradle.properties para tu IDE.  
Luego usa gradle para construir el plugin.  
También puedes abrir esto como un proyecto en Intellij Idea.

## Características / objetivos planeados

* [x] Subir al marketplace cuando tenga suficientes características  
* [x] Sangría automática  
* [x] REPL  
  * [x] Inspección de retorno del REPL  
* [x] Depuración interactiva  
* [x] Ayuda de argumentos (Ctrl+P)  
* [x] Inspección  
  * [x] Inspección básica  
  * [x] Acciones  
  * [x] Inspector de símbolos  
  * [ ] Evaluación en inspección  
* [x] Puntos de interrupción  
* [x] Documentación  
  * [x] Integración con Hyperspec  
* [x] Expansión de macros (todas, 1, normal)  
* [x] Buscar función por nombre de símbolo  
* [x] Buscar símbolos
* [x] Referencias hacia atrás  
* [x] Llaves de colores  
* [ ] Refactorización  
  * [x] Extraer lambda a función  
* [ ] Lista de paquetes instalados de quicklisp / paquetes ASDF  
* [ ] Lista de formas de nivel superior modificadas que aún no han sido evaluadas  
* [ ] Realmente hacer un IDE, es decir, solo un plugin con dependencias como una aplicación, no un plugin  
* [x] Soporte SDK  
    * no es un SDK verdadero porque eso solo está disponible en Intellij y no en (por ejemplo) PyCharm, por lo tanto  
      esto se implementa manualmente.  
    * [x] Descargar SBCL y quicklisp para el usuario  
* [x] Descarga automática del intérprete de lisp y quicklisp  
* [x] Soporte para diferentes intérpretes de lisp  

## Licencia  

Este proyecto está licenciado bajo [Apache License v2](https://raw.githubusercontent.com/Enerccio/SLT/master/LICENSE.txt).  

# ¿Cómo ayudar?  

* Por favor, instala el plugin y pruébalo!  
* Reporta todos los errores para que pueda corregirlos todos. Haz clic [aquí](https://github.com/enerccio/SLT/issues/new) para reportar.  
* Si te gusta el proyecto, considera darle estrella o difundir información sobre él  
* Este proyecto es OSS, así que si tienes conocimiento y quieres implementar algo puedes hacer un fork del repositorio y luego crear un PR!  

## Donaciones  

Si quieres, puedes donar para apoyar mi trabajo vía [Liberapay](https://liberapay.com/Enerccio/donate) o  
[Patreon](https://www.patreon.com/enerccio).  

# ¿Qué significa SLT?  

SLT - Terapia del Lenguaje Hablado. ¡La única cura para LISP!  

También, acrónimo inverso de Superior Lisp Tooling!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---