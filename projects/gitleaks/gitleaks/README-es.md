
#### Dir

El comando `dir` (alias incluyen `files`, `directory`) te permite escanear directorios y archivos. Ejemplo: `gitleaks dir -v path_to_directory_or_file`.
Si no se especifica ningún objetivo como argumento posicional, entonces gitleaks escaneará el directorio de trabajo actual.

#### Stdin

También puedes transmitir datos a gitleaks con el comando `stdin`. Ejemplo: `cat some_file | gitleaks -v stdin`

### Creando una línea base

Al escanear repositorios grandes o repositorios con una larga historia, puede ser conveniente usar una línea base. Al usar una línea base,
gitleaks ignorará cualquier hallazgo antiguo que esté presente en la línea base. Una línea base puede ser cualquier informe de gitleaks. Para crear un informe de gitleaks, ejecuta gitleaks con el parámetro `--report-path`.

```
gitleaks git --report-path gitleaks-report.json # Esto guardará el informe en un archivo llamado gitleaks-report.json
```

Una vez que se crea una línea base, se puede aplicar al ejecutar nuevamente el comando detect:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

Después de ejecutar el comando detect con el parámetro --baseline-path, la salida del informe (findings.json) solo contendrá problemas nuevos.

## Pre-Commit hook

Puedes ejecutar Gitleaks como un hook pre-commit copiando el script de ejemplo `pre-commit.py` en
tu directorio `.git/hooks/`.

## Cargar Configuración

El orden de precedencia es:

1. Opción `--config/-c`:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Variable de entorno `GITLEAKS_CONFIG` con la ruta del archivo:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Variable de entorno `GITLEAKS_CONFIG_TOML` con el contenido del archivo:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. Un archivo `.gitleaks.toml` dentro de la ruta objetivo:
      ```bash
      gitleaks git .
      ```

Si no se utiliza ninguna de las cuatro opciones, entonces gitleaks usará la configuración predeterminada.

## Configuración

Gitleaks ofrece un formato de configuración que puedes seguir para escribir tus propias reglas de detección de secretos:

```toml
# Título para el archivo de configuración de gitleaks.
title = "Configuración personalizada de Gitleaks"

# Básicamente tienes dos opciones para tu configuración personalizada:
#
# 1. definir tu propia configuración, las reglas predeterminadas no aplican
#
#    utiliza, por ejemplo, la configuración predeterminada como punto de partida:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. extender una configuración, las reglas se sobrescriben o se amplían
#
#    Cuando extiendes una configuración, las reglas extendidas tienen prioridad sobre las
#    reglas predeterminadas. Es decir, si hay reglas duplicadas tanto en la configuración extendida
#    como en la configuración predeterminada, las reglas extendidas o
#    sus atributos sobrescribirán las reglas predeterminadas.
#    Otra cosa a tener en cuenta al extender configuraciones es que puedes encadenar
#    múltiples archivos de configuración hasta una profundidad de 2. Los arrays allowlist se
#    agregan y pueden contener duplicados.

# useDefault y path NO pueden ser usados al mismo tiempo. Elige uno.
[extend]
# useDefault extenderá la configuración predeterminada de gitleaks incorporada en el binario
# la última versión se encuentra en:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# o puedes proporcionar una ruta a una configuración desde la cual extender.
# La ruta es relativa a donde se invocó gitleaks,
# no a la ubicación de la configuración base.
# path = "common_config.toml"
# Si hay alguna regla que no quieras heredar, puede ser especificada aquí.
disabledRules = [ "generic-api-key"]

# Un array de tablas que contienen información que define instrucciones
# sobre cómo detectar secretos
[[rules]]
# Identificador único para esta regla
id = "awesome-rule-1"

# Descripción corta y legible para humanos de la regla.
description = "regla asombrosa 1"

# Expresión regular de Golang utilizada para detectar secretos. Nota: el motor regex de Golang
# no soporta lookaheads.
regex = '''one-go-style-regex-for-this-rule'''

# Entero usado para extraer el secreto de la coincidencia de la regex y usado como el grupo que tendrá
# su entropía verificada si `entropy` está establecido.
secretGroup = 3

# Flotante que representa la entropía mínima de Shannon que un grupo de regex debe tener para ser considerado un secreto.
entropy = 3.5

# Expresión regular de Golang usada para hacer coincidir rutas. Esto puede ser usado como una regla independiente o puede ser usado
# en conjunto con una entrada `regex` válida.
path = '''a-file-path-regex'''

# Las palabras clave se utilizan para el filtrado previo a la comprobación de la regex. Las reglas que contienen
# palabras clave realizarán una comprobación rápida de comparación de cadenas para asegurarse de que la(s)
# palabra(s) clave estén en el contenido que se está escaneando. Idealmente estos valores deben
# ser parte del identificador o cadenas únicas específicas para la regex de la regla
# (introducido en v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# Array de cadenas usado para propósitos de metadatos y reportes.
tags = ["etiqueta","otra etiqueta"]

    # ⚠️ En la versión v8.21.0 `[rules.allowlist]` fue reemplazado por `[[rules.allowlists]]`.
    # Este cambio fue compatible con versiones anteriores: las instancias de `[rules.allowlist]` aún funcionan.
    #
    # Puedes definir múltiples allowlists para una regla para reducir falsos positivos.
    # Un hallazgo será ignorado si _CUALQUIERA_ de los `[[rules.allowlists]]` coincide.
    [[rules.allowlists]]
    description = "ignorar commit A"
    # Cuando se definen múltiples criterios, la condición por defecto es "OR".
    # por ejemplo, esto puede coincidir con |commits| O |paths| O |stopwords|.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # nota: stopwords apunta al secreto extraído, no a toda la coincidencia de la regex
    # como 'regexes' lo hace. (stopwords introducido en 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # La condición "AND" puede ser usada para asegurarse de que todos los criterios coincidan.
    # por ejemplo, esto coincide si |regexes| Y |paths| se cumplen.
    condition = "AND"
    # nota: |regexes| por defecto verifica el _Secreto_ en el hallazgo.
    # Los valores aceptables para |regexTarget| son "secret" (por defecto), "match" y "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Puedes extender una regla particular de la configuración predeterminada. por ejemplo, gitlab-pat
# si has definido un prefijo de token personalizado en tu instancia de GitLab
[[rules]]
id = "gitlab-pat"
# todos los otros atributos de la regla predeterminada son heredados

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ En la versión v8.25.0 `[allowlist]` fue reemplazado por `[[allowlists]]`.
#
# Los allowlists globales tienen un orden de precedencia mayor que los allowlists específicos de reglas.
# Si un commit listado en el campo `commits` a continuación es encontrado, entonces ese commit será omitido y no
# se detectarán secretos para dicho commit. La misma lógica aplica para regexes y paths.
[[allowlists]]
description = "lista global de permitidos"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# nota: (global) regexTarget por defecto verifica el _Secreto_ en el hallazgo.
# Los valores aceptables para regexTarget son "match" y "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# nota: stopwords apunta al secreto extraído, no a toda la coincidencia de la regex
# como 'regexes' lo hace. (stopwords introducido en 8.8.0)
stopwords = [
  '''client''',
```markdown
  '''endpoint''',
]

# ⚠️ En la versión v8.25.0, `[[allowlists]]` tiene un nuevo campo llamado |targetRules|.
#
# Las listas de permitidos comunes pueden definirse una vez y asignarse a varias reglas usando |targetRules|.
# Esto solo se ejecutará en las reglas especificadas, no globalmente.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "Nuestros activos de prueba generan falsos positivos en un par de reglas."
paths = ['''tests/expected/._\.json$''']
```

Consulta la [configuración predeterminada de gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) para ver ejemplos o sigue las [directrices de contribución](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md) si deseas contribuir con la configuración predeterminada. Además, puedes consultar [esta publicación en el blog de gitleaks](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) que cubre configuraciones avanzadas.

### Configuración Adicional

#### gitleaks:allow

Si conscientemente vas a confirmar un secreto de prueba que gitleaks detectará, puedes agregar un comentario `gitleaks:allow` en esa línea, lo que indicará a gitleaks
que ignore ese secreto. Ejemplo:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Puedes ignorar hallazgos específicos creando un archivo `.gitleaksignore` en la raíz de tu repositorio. En la versión v8.10.0, Gitleaks agregó un valor `Fingerprint` al informe de Gitleaks. Cada filtración o hallazgo tiene una huella digital que identifica de manera única un secreto. Agrega esta huella digital al archivo `.gitleaksignore` para ignorar ese secreto específico. Consulta el [.gitleaksignore de Gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) como ejemplo. Nota: esta función es experimental y puede cambiar en el futuro.

#### Decodificación

A veces los secretos están codificados de una manera que dificulta su detección
solo con expresiones regulares. Ahora puedes indicar a gitleaks que busque y decodifique
automáticamente el texto codificado. La bandera `--max-decode-depth` habilita esta función (el valor
predeterminado "0" significa que la función está deshabilitada por defecto).

La decodificación recursiva está soportada, ya que el texto decodificado también puede contener texto codificado.
La bandera `--max-decode-depth` establece el límite de recursión. La recursión se detiene
cuando no hay nuevos segmentos de texto codificado por decodificar, por lo que establecer una profundidad máxima muy alta no significa que hará tantas pasadas. Solo hará las necesarias para decodificar el texto. En general, la decodificación solo aumenta mínimamente los tiempos de escaneo.

Los hallazgos para texto codificado difieren de los hallazgos normales en los siguientes aspectos:

- La ubicación señala los límites del texto codificado
  - Si la regla coincide fuera del texto codificado, los límites se ajustan para
    incluir eso también
- La coincidencia y el secreto contienen el valor decodificado
- Se agregan dos etiquetas: `decoded:<encoding>` y `decode-depth:<depth>`

Codificaciones soportadas actualmente:

- **percent** - Cualquier valor ASCII imprimible codificado en porcentaje
- **hex** - Cualquier valor ASCII imprimible codificado en hexadecimal >= 32 caracteres
- **base64** - Cualquier valor ASCII imprimible codificado en base64 >= 16 caracteres

#### Escaneo de Archivos Comprimidos

A veces los secretos están empaquetados dentro de archivos comprimidos como archivos zip o tarballs,
lo que dificulta su descubrimiento. Ahora puedes indicar a gitleaks que extraiga y escanee automáticamente el contenido de los archivos comprimidos. La bandera `--max-archive-depth`
habilita esta función tanto para los tipos de escaneo `dir` como `git`. El valor predeterminado de
"0" significa que esta función está deshabilitada por defecto.

El escaneo recursivo está soportado ya que los archivos comprimidos también pueden contener otros archivos comprimidos.
La bandera `--max-archive-depth` establece el límite de recursión. La recursión se detiene
cuando no hay nuevos archivos comprimidos por extraer, por lo que establecer una profundidad máxima muy alta solo establece el potencial para llegar tan profundo. Solo irá tan profundo como sea necesario.

Los hallazgos para secretos ubicados dentro de un archivo comprimido incluirán la ruta al
archivo dentro del archivo comprimido. Las rutas internas se separan con `!`.

Ejemplo de hallazgo (acortado por brevedad):

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

Esto significa que se detectó un secreto en la línea 4 de `files/.env.prod.`, que está en
`archives/files.tar` que está en `testdata/archives/nested.tar.gz`.

Formatos soportados actualmente:

Los [formatos de compresión](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
y [formatos de archivo](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
soportados por el paquete [archives de mholt](https://github.com/mholt/archives)
son compatibles.

#### Reportes

Gitleaks tiene soporte integrado para varios formatos de informe: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml), y [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Si ninguno de estos formatos se ajusta a tus necesidades, puedes crear tu propio formato de informe con un archivo [Go `text/template` .tmpl](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) y la bandera `--report-template`. La plantilla puede utilizar [funcionalidades extendidas de la librería de plantillas `Masterminds/sprig`](https://masterminds.github.io/sprig/).

Por ejemplo, la siguiente plantilla proporciona una salida JSON personalizada:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

Uso:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## Patrocinios

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="Patrocinio de CodeRabbit.ai" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## Códigos de Salida

Siempre puedes establecer el código de salida cuando se encuentren filtraciones utilizando la bandera --exit-code. Códigos de salida predeterminados a continuación:

```
0 - no hay filtraciones presentes
1 - filtraciones o error encontrado
126 - bandera desconocida
```
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---