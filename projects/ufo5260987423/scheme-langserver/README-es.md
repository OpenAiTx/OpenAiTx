![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Puedes leer mi [artículo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) y citarlo así:
> WANG, Z. (2025, 12 de mayo). Scheme-langserver: Tratar la edición de código Scheme como una preocupación de primera clase. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Debido a que GitHub puede bloquear direcciones IP chinas, he tenido que copiar este repositorio a [aquí](https://codeberg.org/ufo5260987423/scheme-langserver) y [aquí](https://gitee.com/ufo5260987423/scheme-langserver). Continuaré actualizando todos los repositorios, pero no puedo garantizarlo. Ahora también colaboro con [XmacsLabs](https://github.com/XmacsLabs), puedes encontrar un fork [aquí](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**¡Ahora, VSCode puede usar scheme-langserver!** Por favor, consulta [AQUÍ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>NOTA: Hay muchísimos bugs en scheme-langserver. Estoy corrigiendo y pidiendo ayuda a la comunidad. Por favor, ten paciencia.

>NOTA: puedes encontrar la información de tipos generada automáticamente [aquí](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Ahora se usa principalmente para el desarrollo de la siguiente etapa (quizás incluya AKKU) y para depuración.

Implementar soporte como autocompletado, ir a la definición o documentación al pasar el cursor es un esfuerzo importante en programación. Sin embargo, comparado con otros lenguajes como java, python, javascript y c, la implementación de language server protocol para lenguajes lisp se ha hecho en un vacío. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) y [swish-lint](https://github.com/becls/swish-lint), etc., sus trabajos se basan en `repl` (Read-Eval-Print Loop) o en un tokenizador de palabras clave en vez de programación real. Por ejemplo, si un programador está codificando en un proyecto inacabado, en el cual los códigos no son completamente ejecutables, [Geiser](https://gitlab.com/emacs-geiser) o cualquier otro solo completará identificadores de binding de nivel superior listados por el procedimiento `environment-symbols` (para [Chez](https://cisco.github.io/ChezScheme/)), o completará símbolos en vez de identificadores. Esto significa que para bindings locales y códigos no terminados, aunque se supone que el esfuerzo en programación es de suma importancia, [Geiser](https://gitlab.com/emacs-geiser) y sus equivalentes no ayudan en nada para reconocer el alcance válido de los identificadores. Casos similares ocurren con la función de ir a la definición y muchas otras funcionalidades.

Una causa principal es que, para scheme y otros dialectos lisp, sus abundantes conjuntos de datos y estructuras de control flexibles hacen que el análisis de programas sea un gran desafío. Especialmente los macros, parece que scheme se utiliza principalmente para programación de genios y meta/macro programación. Pero yo digo que no. Scheme puede hacer muchas cosas interesantes si se proporciona un mejor entorno de programación. Y ahora puedes [**EMPEZAR AQUÍ**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Este paquete es una implementación del language server protocol que ayuda a programar en scheme. Proporciona autocompletado, definición e inferencia de tipos. Estas funcionalidades se establecen sobre análisis estático de código con el [estándar r6rs](http://www.r6rs.org/) y algunas reglas obvias para códigos inacabados. Este paquete y las bibliotecas relacionadas se publican o se publicarán con [Akku](https://akkuscm.org/), que es un gestor de paquetes para Scheme.

Este paquete también ha sido probado con [Chez Scheme](https://cisco.github.io/ChezScheme/) versiones 9.4 y 9.5. Una prueba detallada en la versión 10.0.0 se realizará después de actualizar el sistema operativo de mi portátil a una versión más reciente.

Hago este trabajo de código abierto solo en mi tiempo libre y puedo contribuir muchas ideas brillantes a la comunidad como incrustar análisis de flujo de datos en scheme-langserver o muchas otras cosas. Y continúo pidiendo muchas más donaciones o financiación. Puedes donar con [esta página de patreon](https://www.patreon.com/PoorProgrammer/membership) o con [爱发电](https://afdian.com/a/ufo5260987423).


## Compilación, Instalación y Configuración está [AQUÍ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Estado Reciente
Seguiré corrigiendo errores, perfilando el código y recolectando información para mi gran libro sobre sistemas de inferencia de tipos caseros. Esto me llevará alrededor de 1 año. Los desarrollos futuros incluyen un plugin para [VScode](https://code.visualstudio.com/) y análisis de flujo de datos. Pero en realidad, ahora estoy considerando este trabajo de código abierto como un trabajo de medio tiempo y no puedo garantizar un cronograma.

## Lanzamiento 
1.2.9 ¡Ahora disfruta de la inferencia de tipos!

Para lanzamientos anteriores por favor revisa [este archivo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Características
1. Autocompletado de bindings de identificadores tanto a nivel superior como local.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Ir a la definición.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Compatible con el gestor de paquetes: Akku.
4. Sincronización de cambios en archivos y cambios correspondientes en el índice.
5. Hover (información al pasar el cursor).
6. Referencias y resaltado de documentos (referencias en el ámbito del documento).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Símbolo de documento.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Captura de bindings locales basados en *-syntax (define-syntax, let-syntax, etc.).
9. Indexación paralela multiplataforma.
10. Anotador de código fuente propio para ser compatible con archivos .sps.
11. Optimización "peephole" para solicitudes de API con tareas suspendibles.
12. Inferencia de tipos con un intérprete DSL casero (¡estoy muy orgulloso de esto!). Y ahora se ha incrustado en el autocompletado. Como indica la siguiente figura, las opciones "length-b" y "length-a" con tipo "integer?" están al frente de las opciones recomendadas porque pueden coincidir con el tipo de parámetro requerido por "<=".
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Una prueba puede demostrar este resultado, solo ejecuta `scheme --script tests/protocol/apis/test-completion.sps` y el archivo de registro `scheme-langserver.log` contendrá resultados como este:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Intérprete abstracto para la captura de identificadores entre diferentes extensiones de archivos como scm, ss, sps, sls y sld.

### POR HACER
14. Renombrado.
15. Compatibilidad total con el [estándar r6rs](http://www.r6rs.org/).
16. Expansor de macros paso a paso: bueno, en realidad ya he implementado uno y quería que fuera un paso clave para capturar bindings de identificadores en macros autodefinidos. Ahora, encuentro que esta captura es mucho más difícil de lo que pensaba, y el expansor no sé dónde podría funcionar.
17. Evaluación de código.
18. Diagnóstico de código.
19. Añadir soporte semántico entre lenguajes. Bueno, ¿podrían soportarse java, c, python y muchos otros lenguajes con un transformador AST?
20. Extraer expresiones/sentencias en un procedimiento.

## POR HACER: Contribuciones 

## Depuración

### Cómo depurar
https://www.scheme.com/debug/debug.html#g1

### Salida de registro
Siguiendo los consejos de [Compilación](#building), [Instalación para Lunar Vim](#installation-for-lunarvim) y [Instalación para VScode](#todo-installation-for-vscode), si alguien quiere hacer algo de desarrollo y registrar información, será conveniente añadir `path-to-log-file` y reescribir el archivo `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` de la siguiente manera:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, una implementación de language server protocol para scheme
]]   ,
  },
}
```
### Recurrencia con Log
Con el [registro de salida](#output-log) anterior, puedes utilizar `tests/log-debug.sps` para reproducir errores recurrentes:
1. Renombra `{path-to-log}` (usualmente `~/scheme-langserver.log`) como `~/ready-for-analyse.log`;
2. ejecuta `scheme --script tests/log-debug.sps`. Si deseas reproducir el entorno multihilo, también puedes ejecutar `scheme --script tests/log-debug.sps`.

## Prueba
Casi todos los procedimientos clave y APIs están probados. Mi trabajo es bastante rudimentario pero útil, tal vez quieras ver lo que he hecho en el directorio `tests` o simplemente ejecutar el siguiente comando en `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>NOTA
Es difícil realizar pruebas en un entorno con hilos. Por lo tanto, las pruebas actuales se centran en un solo hilo.

## Usar Scheme-langserver para Otro Propósito
### Script-Fu en GIMP
Script-Fu está basado en un lenguaje interpretado llamado Scheme, y funciona utilizando funciones que interactúan con las funciones internas de GIMP. Tomando como ejemplo el script de [esta página](https://dalelane.co.uk/blog/?p=628), puedes aplicar scheme-langserver a archivos de script con extensión "SCM".

### Otros

Bueno, también estoy interesado en [OMN (Opusmodus Notation)](https://opusmodus.com/) y AutoLisp. Pero todavía tengo muchas cosas por hacer.

## Conteo de Código
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Documento Detallado
1. [Scheme-langserver: Tratar la Edición de Código Scheme como una Preocupación de Primera Clase](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Capturando enlaces de identificadores](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Sincronizando](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Inferencia de tipos](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Obsoleto, y estoy escribiendo un libro en chino al respecto)
5. [Análisis de API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Historial de Estrellas

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Colaboradores

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---