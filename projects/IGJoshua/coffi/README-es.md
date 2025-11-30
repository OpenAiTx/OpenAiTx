# coffi
[![Clojars Project](https://img.shields.io/clojars/v/org.suskalo/coffi.svg)](https://clojars.org/org.suskalo/coffi)
[![cljdoc badge](https://cljdoc.org/badge/org.suskalo/coffi)](https://cljdoc.org/d/org.suskalo/coffi)

Coffi es una biblioteca de interfaz de funciones externas para Clojure, que utiliza la [Foreign
Function & Memory API](https://openjdk.org/jeps/454) en JDK 22 y posteriores. Esto
permite llamar código nativo directamente desde Clojure sin la necesidad de
Java ni código nativo específico para la biblioteca, como por ejemplo hace JNI. Coffi se enfoca
en la facilidad de uso, incluyendo funciones y macros para crear envoltorios que permitan
que las funciones nativas resultantes actúen como funciones Clojure, sin embargo,
esto no elimina la capacidad de escribir sistemas que minimicen el costo de
marshaling de datos y optimicen el rendimiento, para aprovechar el acceso de bajo nivel
que nos proporciona la FF&M API.

- [Primeros Pasos](https://cljdoc.org/d/org.suskalo/coffi/CURRENT/doc/getting-started)
- [Documentación API](https://cljdoc.org/d/org.suskalo/coffi/CURRENT/api/coffi)
- [Cambios Recientes](https://raw.githubusercontent.com/IGJoshua/coffi/develop/CHANGELOG.md)

## Instalación
Esta biblioteca está disponible en Clojars, o como dependencia git. Agregue una de las
siguientes entradas a la clave `:deps` de su `deps.edn`:

```clojure
org.suskalo/coffi {:mvn/version "1.0.615"}
io.github.IGJoshua/coffi {:git/tag "v1.0.615" :git/sha "7401485"}
```

Si utiliza esta biblioteca como una dependencia de git, necesitará preparar la
biblioteca.

```sh
$ clj -X:deps prep
```

Coffi requiere el uso del paquete `java.lang.foreign`, y la mayoría de las
operaciones son consideradas inseguras por el JDK, por lo que no están disponibles para
tu código sin pasar algunas opciones en la línea de comandos. Para usar coffi, añade
los siguientes argumentos JVM a tu aplicación.

```sh
--enable-native-access=ALL-UNNAMED
```

Puedes especificar argumentos de JVM en una invocación particular del CLI de Clojure con
la opción `-J` de la siguiente manera:

``` sh
clj -J--enable-native-access=ALL-UNNAMED
```

También puedes especificarlos en un alias en tu archivo `deps.edn` bajo la clave
`:jvm-opts` (ver el siguiente ejemplo) y luego invocar la CLI con ese alias
usando `-M`, `-A` o `-X`.

``` clojure
{:aliases {:dev {:jvm-opts ["--enable-native-access=ALL-UNNAMED"]}}}
```

Otras herramientas de construcción deberían proporcionar una funcionalidad similar si revisas su
documentación.

Al crear un archivo jar ejecutable, puedes evitar la necesidad de pasar este
argumento añadiendo el atributo del manifiesto `Enable-Native-Access: ALL-UNNAMED` a
tu jar. Consulta la documentación de tu herramienta de construcción para saber cómo agregar esto.

Coffi también incluye soporte para el linter clj-kondo. Si usas clj-kondo y
las macros de esta biblioteca no están siendo analizadas correctamente, puede que necesites instalar la
configuración incluida con la biblioteca. Puedes hacerlo con el siguiente comando en shell,
ejecutado desde el directorio de tu proyecto:

```sh
$ clj-kondo --copy-configs --dependencies --lint "$(clojure -Spath)"
```

## Uso
Los dos espacios de nombres principales son `coffi.mem`, que proporciona funciones para asignar
y manipular memoria fuera del montón y (de)serializar valores, y `coffi.ffi`
que puede cargar bibliotecas nativas, declarar envoltorios de funciones nativas y
(de)serializar funciones como callbacks.

```clojure
(require '[coffi.mem :as mem])
(require '[coffi.ffi :as ffi :refer [defcfn]])

(defcfn strlen
  "Given a string, measures its length in bytes."
  strlen [::mem/c-string] ::mem/long)

(strlen "hello")
;; => 5

(ffi/load-system-library "z")
```
En el espacio de nombres `coffi.mem` hay tipos para todos los tipos numéricos primitivos con signo en C, además de `::mem/pointer` y `::mem/c-string`, y formas de usar declaraciones de tipo al estilo malli para definir structs, unions, arrays, enums y flagsets.

## Alternativas
Esta biblioteca no es la única biblioteca de Clojure que proporciona acceso a código nativo. Además, existen las siguientes bibliotecas (entre otras):

- [dtype-next](https://github.com/cnuernber/dtype-next)
- [tech.jna](https://github.com/techascent/tech.jna)
- [clojure-jna](https://github.com/Chouser/clojure-jna)

Dtype-next tiene soporte para versiones de Java 8-15, 17+ y GraalVM, pero está fuertemente enfocado en la programación basada en arrays, así como en mantener la memoria en el lado nativo en lugar de transformar datos hacia y desde estructuras nativas de Clojure. En Java 17+, usa la API de Funciones y Memoria Externas (una parte de Project Panama hasta su estabilización en JDK 22), mientras que en otras versiones de Java usa JNA.

Tech.jna y clojure-jna usan ambas la biblioteca JNA en todos los casos, y ninguna proporciona soporte explícito para callbacks. JNA permite el uso de `java.nio.ByteBuffer`s para pasar structs por valor, y ambas bibliotecas ofrecen formas de usar esta construcción por valor para llamar a APIs por referencia.

Una alternativa adicional a coffi es usar directamente JNI, que es el método más antiguo para envolver código nativo en la JVM, pero tiene la desventaja de que requiere escribir código nativo y Java para usarlo, incluso si solo se pretende usar desde Clojure.

Si tu aplicación necesita poder ejecutarse en versiones anteriores a la 22 de la JVM, deberías considerar estas otras opciones. Dtype-next ofrece el soporte más robusto para código nativo, pero si estás envolviendo una biblioteca simple, las otras bibliotecas pueden ser más atractivas, ya que tienen una superficie de API más pequeña y es más fácil envolver funciones.

También existe un [resumen de terceros](https://docs.google.com/spreadsheets/d/1ViLHNUgrO2osh2AH0h7MaCaXz8g0UpLbyWojY5f10kk/edit?gid=332155605#gid=332155605) de opciones FFI para Clojure.






















## Problemas Conocidos
El autor del proyecto está al tanto de estos problemas y planea solucionarlos en una futura
versión:

- Al generar documentación con codox en una biblioteca que depende de coffi, se producirá el siguiente error. Una solución temporal es agregar una dependencia explícita en su compilación de codox sobre insn en la versión 0.2.1
  ```
  Unable to find static field: ACC_OPEN in interface org.objectweb.asm.Opcodes
  ```
## Planes Futuros
Estas características están planificadas para futuras versiones.

- Soporte para tipo va_args
- Herramienta de análisis de encabezados para generar un modelo de datos? (¿quizás solo trabajar con [clong](https://github.com/phronmophobic/clong)?)
- Alias de tipos genéricos
- Tipos de enteros sin signo
- Macro auxiliar para argumentos de salida
- Mejorar mensajes de error del macro defcfn
- Memoria mapeada
- Macros auxiliares para implementaciones personalizadas de serde para tipos de datos más compuestos
- Soporte para GraalVM Native Image (una vez que su soporte para FFM sea maduro)

## Licencia

Copyright © 2023 Joshua Suskalo

Distribuido bajo la Licencia Pública de Eclipse versión 1.0.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-30

---