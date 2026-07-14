# mozcdict-ext

Convertir palabras externas en el diccionario del sistema Mozc

# Resumen

Este conjunto de herramientas fue creado originalmente como una "evacuación de emergencia" para compensar la pérdida de Mozc-UT (Mozcdic-UT).  
Actualmente, se busca construir un entorno de conversión más cómodo mediante un enfoque diferente al de Mozc-UT.

Este conjunto de herramientas construye el diccionario del sistema Mozc a partir de recursos externos a Mozc.  
Al incorporarlo a Mozc y compilarlo, se puede aumentar el vocabulario de Mozc.

El software no *incluye* diccionarios generados de esta manera.  
Además, *no incluye el núcleo de Mozc*.

Originalmente fue un software creado como un "parche" de emergencia, pero ahora se desarrolla bajo una política algo diferente a Mozc-UT.

Las principales diferencias con Mozcdic-UT son las siguientes:

* Es un proyecto abierto y su licencia es GPL v3  
* El software es una herramienta para generar diccionarios, no un diccionario generado  
* Mozcdic-UT está dirigido solo a nombres comunes, mientras que Mozcdict-EXT no restringe las clases de palabras  
* Además del convertidor de diccionarios web, tiene un diccionario ByHand compilado manualmente

# Cómo usarlo

## Fundamentos de la generación

Los archivos `mkdict.zsh` o `mkdict.rb` en cada directorio generan el diccionario convertido y lo envían a la salida estándar.

Para ello, se deben cumplir las siguientes condiciones previas:

* Ejecutar el script con el directorio donde está el script como directorio actual  
* Es necesario definir la variable de entorno `$MOZC_ID_FILE` con la ruta al archivo `id.def` de Mozc

El archivo `id.def` se encuentra en `src/data/dictionary_oss/id.def` dentro de Mozc.  
Este archivo *no está incluido en este software.*  
Dado que para la compilación se requiere Mozc de todos modos, es recomendable obtener y actualizar el repositorio de Mozc previamente.

El contenido enviado a la salida estándar de esta manera puede tratarse como un diccionario del sistema de Mozc, y al incorporarlo y compilarlo se puede incluir.
Se recomienda añadirlo en `src/data/dictionary_oss/dictionary09.txt`.

## Formateo final

Si se generan múltiples diccionarios, realizar tareas de formateo que abarquen varios diccionarios mejora el resultado.

`.dev.utils/uniqword.rb` lee el diccionario desde `ARGF` y elimina las palabras idénticas, incluyendo la categoría gramatical, y las imprime en STDOUT.
Las palabras duplicadas se envían a STDERR.

```bash
ruby uniqword.rb ~/dict/neologd.txt ~/dict/sudachi.txt > ~/dict/unified.txt
```
A diferencia de Mozcdic-UT, se realiza la generación de nombres propios, por lo que es recomendable realizar esta tarea.

## En el caso de Archlinux

Se proporciona un paquete AUR llamado `fcitx5-mozc-ext-neologd` aparte de este proyecto.

Al instalar este paquete desde AUR, es posible construir e instalar Mozc incluyendo un diccionario externo.

Cabe destacar que este paquete es independiente de este proyecto.

# Variables de entorno

## `$MOZC_ID_FILE`

Obligatorio. Indica la ubicación del archivo `id.def` de MOZC.

## `$WORDCLASS_ROUND`

Si no existe una clase gramatical que coincida exactamente, redondea a una clase gramatical más general.
Si se especifica `no`, esta operación no se realiza.
Funciona con las siguientes herramientas de diccionario:

* sudachi

## `$ERROR_ON_UNEXPECTED_CLASS`

Genera un error si hay palabras con clase gramatical desconocida.
Por defecto no genera errores, solo si se especifica `yes`.
Funciona con las siguientes herramientas de diccionario:

* sudachi

# Opciones de ejecución

## -e / --english

Normalmente, esta herramienta excluye la "conversión al inglés".
Con la opción `-e` o `--english`, se permite el resultado de la conversión al inglés.


## --english-proper

Si no se usa `--english` y se usa `--english-proper`, solo se permiten los nombres propios en inglés.

## -P / --no-proper

Excluir nombres propios.

## -w / --fullwidth-english (neologd, sudachi)

No excluir la conversión a caracteres alfanuméricos de ancho completo y kana de medio ancho.

Más precisamente, normalmente se excluye si coincide con la expresión regular de Onigmo `/^[\p{Symbol}\p{In_CJK_Symbols_and_Punctuation}\p{Punctuation}\p{White_Space}\p{In_Halfwidth_and_Fullwidth_Forms}]+$/`, pero esta exclusión se detiene.

## -W / --exclude-containing-fullwidth-english (byhand)

Excluir si contiene caracteres alfanuméricos de ancho completo o kana de medio ancho.

## --fullwidth-english-proper (neologd, sudachi)

Solo permitir nombres propios si no se usa `--fullwidth-english`.

## -s / --symbol

Normalmente, esta herramienta excluye símbolos que dificultan la conversión, pero
si se usa la opción `-s` o `--symbol`, se incluyen forzosamente en la salida.

# Opciones predeterminadas

Si desea cambiar las opciones predeterminadas sin usar opciones de línea de comandos, puede establecer opciones predeterminadas mediante el archivo `config.yaml` en el directorio de configuración (`${XDG_CONFIG_HOME:-$HOME/.config}/mozcdict-ext`).

Por ejemplo, si desea habilitar siempre `--fullwidth-english`, hágalo así.

```yaml
fullwidth-english: true
```

# Exclusión

Se puede especificar un patrón que se desea evitar agregar al diccionario utilizando el archivo `exclude.txt` en el directorio de configuración.

La lista de exclusión contiene un patrón por línea, separado por uno o más espacios en blanco consecutivos entre el patrón de lectura y el patrón de forma base.

Cada patrón se verifica mediante `File.fnmatch`.

Por ejemplo, si desea excluir todas las candidaturas que se convierten con una lectura que comienza con `ゃ`:

```
ゃ*    *
```

とする。

# IssueとPR

何か問題があれば、Issueに書くか、Pull Requestを生成してほしい。

ただ、私は既にかなり手出ししている中で善意で本ソフトウェアを作っていることを理解してほしい。
つまり、IssueやPull Requestにまで手が回るかは分からない。
(少なくとも、なるべく対応したいとは思っている。)

# Añadir vocabulario al diccionario ByHand y reportar vocabulario faltante

Si hay palabras que no se pueden convertir con la última versión de Mozc y con todos los diccionarios de este software habilitados, por favor solicítelo en [Informe de vocabulario faltante de Mozcdict Ext](https://mozc.chienomi.org).

Para aquellos que no pueden solicitarse desde la misma página, por favor repórtelos en un issue.
Además, si puede especificar la categoría gramatical concreta de Mozc, por favor cree un issue en lugar de usar la página.

# Licencia y empaquetado

Este software está licenciado bajo GPL v3.
Puede copiar y usar el software "libremente".

Por otro lado, aunque este software tenga algún problema o deficiencia, no puedo asumir ninguna responsabilidad.
Como todo el mundo sabe, es ABSOLUTELY NO WARRANTY.

Este software proporciona únicamente una herramienta para generar diccionarios.
Sin embargo, probablemente si desea distribuirlo como una distribución, será Mozc construido con ello.
Mozc construido de esta manera no tiene ninguna relación con la licencia de esta herramienta.
Porque esta herramienta no está incluida en dicho Mozc.
Tales paquetes deben cumplir con las licencias y regulaciones de Mozc y los recursos usados como diccionarios externos.
No garantizamos que sea posible distribuirlo de esta manera, ni el software ni yo.

# Estado actual

* NEologd - Funciona
* Sudachi - Generado solo para algunas categorías gramaticales (experimental, en desarrollo)

# Avisos

* Este software no tiene ninguna relación con la licencia ni la validez de los diccionarios generados por este software.

# Elementos para los que se solicitan contribuciones especiales

`clsmap.yaml` de sudachi (conversión de la clasificación de partes del habla de Sudachi a la clasificación de partes del habla de Mozc)

Usando `utils/dev-by-cls.rb` se clasifican palabras específicas por parte del habla y se generan en `.dev.reference/sudachi-cls` (que está en `.gitignore`), por lo que se está avanzando en la consolidación de la clasificación de partes del habla con referencia a esto.

# Dependencias

* Ruby >= 3.0
* Zsh
* xz(1)
* curl(1)
* Git (Submódulos)

# Sobre los diccionarios

## neologd

Es un diccionario basado en mecab-ipadic-NEologd.

## sudachi

Es un diccionario que reutiliza el diccionario del software de análisis morfológico Sudachi.

Se planea usarlo también para partes del habla distintas a los sustantivos, pero actualmente está estancado.

## byhand

Es un diccionario compilado manualmente para palabras que no se pueden convertir o cuya conversión es difícil usando neologd o sudachi.

Como regla general, sólo incluye palabras generales que aparecerían en un pequeño diccionario de lengua japonesa, y no incluye nombres propios.

## Mozc Common User Dict

[Mozc Common User Dict](https://github.com/reasonset/mozc-common-user-dict) es un diccionario de usuario de palabras generales que complementa este proyecto.

Las palabras que por alguna razón son difíciles de incluir en byhand se incluyen aquí.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---