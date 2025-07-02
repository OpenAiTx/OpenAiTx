<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Puedes leer mi [artículo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) y citarlo así:
> WANG, Z. (2025, 12 de mayo). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Debido a que GitHub puede bloquear direcciones IP chinas, tuve que copiar este repositorio [aquí](https://codeberg.org/ufo5260987423/scheme-langserver) y [aquí](https://gitee.com/ufo5260987423/scheme-langserver). Seguiré actualizando todos los repositorios pero no puedo garantizarlo. Ahora también colaboro con [XmacsLabs](https://github.com/XmacsLabs), también puedes encontrar un fork [aquí](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**¡Ahora, VSCode puede usar scheme-langserver!** Por favor, consulta [AQUÍ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>NOTA: Hay muchísimos errores en scheme-langserver. Estoy corrigiéndolos y pidiendo ayuda a la comunidad. Por favor, ten paciencia.

>NOTA: puedes encontrar la información de tipos generada automáticamente [aquí](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Ahora se usa principalmente para el desarrollo de la siguiente etapa (quizás incluyendo AKKU) y para depuración.

Implementar soporte como autocompletado, ir a definición o documentación al pasar el cursor es un gran esfuerzo en programación. Sin embargo, en comparación con otros lenguajes como java, python, javascript y c, la implementación del protocolo de servidor de lenguaje para lenguajes lisp simplemente se hace en el vacío. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) y [swish-lint](https://github.com/becls/swish-lint), etc., sus trabajos se basan todos en `repl` (Read-Eval-Print Loop) o en un tokenizador de palabras clave en vez de programación. Por ejemplo, si un programador está trabajando en un proyecto inacabado, en el que los códigos no son completamente ejecutables, [Geiser](https://gitlab.com/emacs-geiser) o cualquier otro solo completaría los identificadores de enlaces de nivel superior listados por el procedimiento `environment-symbols` (para [Chez](https://cisco.github.io/ChezScheme/)), o completaría símbolos en lugar de identificadores. Esto significa que para enlaces locales y códigos inacabados, aunque se supone que el esfuerzo para la programación es de suma importancia, [Geiser](https://gitlab.com/emacs-geiser) y sus equivalentes no ayudan en nada a reconocer el alcance válido de los identificadores. Casos similares ocurren con ir a la definición y muchas otras funcionalidades.

Una causa principal es que, para scheme y otros dialectos de lisp, sus abundantes conjuntos de datos y estructuras de control flexibles hacen que el análisis de programas sea un gran desafío. Especialmente el macro, parece que scheme se usa principalmente para genios y programación meta/macro. Pero yo digo que no. Scheme puede hacer muchas cosas interesantes si se proporciona un mejor entorno de programación. Y ahora puedes [**EMPEZAR AQUÍ**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Este paquete es una implementación del protocolo de servidor de lenguaje que ayuda a la programación en scheme. Proporciona autocompletado, definición e inferencia de tipos. Estas funcionalidades se basan en análisis estático de código con el [estándar r6rs](http://www.r6rs.org/) y algunas reglas obvias para códigos inacabados. Este paquete en sí mismo y las bibliotecas relacionadas están publicadas o se publicarán con [Akku](https://akkuscm.org/), que es un gestor de paquetes para Scheme.

Este paquete también ha sido probado con [Chez Scheme](https://cisco.github.io/ChezScheme/) versiones 9.4 y 9.5. Se realizará una prueba detallada en la versión 10.0.0 después de actualizar el sistema operativo de mi laptop a una versión más reciente.

Hago este trabajo de código abierto solo en mi tiempo libre y puedo aportar muchas ideas brillantes a la comunidad, como incorporar análisis de flujo de datos en scheme-langserver o muchas otras cosas. Y continuamente estoy pidiendo muchas más donaciones o financiación. Puedes donar en [esta página de patreon](https://www.patreon.com/PoorProgrammer/membership) o en [爱发电](https://afdian.com/a/ufo5260987423).


## Compilación, Instalación y Configuración está [AQUÍ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Estado Reciente
Seguiré corrigiendo errores, perfilando el código y recopilando información para mi gran libro sobre sistemas de inferencia de tipos caseros. Esto me llevará alrededor de 1 año. Los desarrollos futuros incluyen un plugin para [VScode](https://code.visualstudio.com/) y análisis de flujo de datos. Pero en realidad, ahora considero este trabajo de código abierto como un trabajo a tiempo parcial, y no puedo garantizar un cronograma.

## Lanzamiento 
1.2.9 ¡Ahora, disfruta de la inferencia de tipos!

Para lanzamientos anteriores por favor consulta [este archivo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Características
1. Autocompletado de enlaces de identificadores de nivel superior y local.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Ir a definición.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Compatible con el gestor de paquetes: Akku.
4. Sincronización de cambios de archivos y cambio de los índices correspondientes.
5. Hover.
6. Referencias y resaltado de documentos (referencias a nivel de documento).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Símbolo de documento.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Captura de enlaces de identificadores locales basados en *-syntax (define-syntax, let-syntax, etc.).
9. Indexado paralelo multiplataforma.
10. Anotador de código fuente hecho a medida para ser compatible con archivos .sps.
11. Optimización peephole para solicitudes de API con tarea suspendible.
12. Inferencia de tipos con un intérprete DSL casero (¡estoy muy orgulloso de ello!). Y ahora ha sido incorporada en el autocompletado. Como indica la siguiente figura, "length-b" y "length-a" de tipo "integer?" están al frente de las opciones recomendadas porque pueden coincidir con el tipo de parámetro requerido por "<=".
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Una prueba puede demostrar este resultado, solo ejecuta `scheme --script tests/protocol/apis/test-completion.sps` y el archivo de registro `scheme-langserver.log` contendrá resultados como este:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Intérprete abstracto para la captura de identificadores entre diferentes extensiones de archivos como scm, ss, sps, sls y sld.

### TAREAS PENDIENTES
14. Renombrado.
15. Totalmente compatible con el [estándar r6rs](http://www.r6rs.org/).
16. Expansor de macros paso a paso: bueno, en realidad ya implementé uno y quería que fuera un paso clave para capturar enlaces de identificadores en macros definidas por el usuario. Ahora, veo que esta captura es mucho más difícil de lo que pensaba, y el expansor no sé dónde podría funcionar.
17. Evaluación de código.
18. Diagnóstico de código.
19. Añadir soporte semántico entre lenguajes. Bueno, ¿sería posible soportar Java, C, Python y muchos otros lenguajes con un transformador AST?
20. Extraer expresiones/sentencias a un procedimiento.

## TODO:Contribuir

## Depuración

### Cómo depurar
https://www.scheme.com/debug/debug.html#g1

### Registro de salida
Siguiendo los consejos de [Compilación](#building), [Instalación para Lunar Vim](#installation-for-lunarvim) y [Instalación para VScode](#todo-installation-for-vscode), si alguien quiere hacer algo de desarrollo y registrar algo, será conveniente añadir `ruta-al-archivo-de-log` y reescribir el archivo `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` de la siguiente manera:
```lua
local util = require 'lspconfig.util'
local bin_name = '{ruta-al-ejecutable}'
local cmd = { bin_name ,"ruta-al-archivo-de-log"}

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
`scheme-langserver`, una implementación del protocolo de servidor de lenguaje para scheme
]]   ,
  },
}
```
### Repetición con Log
Con el [registro de salida](#registro-de-salida) anterior, puedes usar `tests/log-debug.sps` para reproducir errores:
1. Renombra `{ruta-al-log}` (normalmente `~/scheme-langserver.log`) como `~/ready-for-analyse.log`;
2. ejecuta `scheme --script tests/log-debug.sps`. Si quieres reproducir el entorno multihilo, también está disponible ejecutar `scheme --script tests/log-debug.sps`.

## Pruebas
Casi todos los procedimientos clave y APIs están probados. Mi trabajo es bastante rudimentario pero útil, quizá quieras revisar lo que he hecho en el directorio `tests` o simplemente ejecutar el siguiente comando en `{directorio-raíz-de-scheme-langserver}`
``` bash
bash test.sh
```
>NOTA  
Es difícil hacer pruebas en un entorno multihilo. Por lo tanto, las pruebas actuales se centran en un solo hilo.

## Usar Scheme-langserver para otros propósitos
### Script-Fu en GIMP
Script-Fu se basa en un lenguaje interpretado llamado Scheme y funciona utilizando funciones que interactúan con las funciones internas de GIMP. Tomando como ejemplo el script de [esta página](https://dalelane.co.uk/blog/?p=628), puedes aplicar scheme-langserver con archivos de script con extensión "SCM".

### Otros

Bueno, también me interesa [OMN (Opusmodus Notation)](https://opusmodus.com/) y AutoLisp. Pero todavía tengo muchas cosas que hacer.

## Conteo de código
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Documentación detallada
1. [Scheme-langserver: Tratar la edición de código Scheme como una preocupación de primera clase](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Captura de enlaces de identificadores](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Sincronización](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Inferencia de tipos](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Obsoleto, y estoy escribiendo un libro en chino sobre esto)
5. [Análisis de API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Historial de estrellas

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Contribuidores

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---