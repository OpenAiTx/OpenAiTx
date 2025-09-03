# kanjiapi.dev: una API JSON moderna para Kanji

Más de 13,000 kanji disponibles en [https://kanjiapi.dev](https://kanjiapi.dev)

## Enlaces
- Documentación de la API: https://kanjiapi.dev/#!/documentation
- Ayuda para entender por qué ciertos kanji existen en ciertas listas: https://onlyskin.dev/official-kanji-list-diffs/

## Invítame a un café

https://buymeacoffee.com/onlyskin

## Ejemplos

### Kanji `/v1/kanji/{character}`
```
$ curl https://kanjiapi.dev/v1/kanji/猫
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/kanji/猫').then(r => r.json()).then(console.log);
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```
#### Lista de todos los kanji soportados

`$ curl https://kanjiapi.dev/v1/kanji/all`

#### Lista de kanji joyo

`$ curl https://kanjiapi.dev/v1/kanji/joyo` (también `/jouyou`)

Los kanji JOYO son kanji de uso general definidos por el gobierno japonés. La
Base de Datos Unihan etiqueta cuatro kanji adicionales como kanji Joyo, llevando
el total a 2140 puntos de código. Esto se debe a que cuatro de los kanji Joyo
faltan en la codificación JIS X 0208, por lo que históricamente se usó un kanji
diferente que *sí* está presente en JIS X 0208. Por lo tanto, en la Base de Datos
Unihan, tanto los cuatro kanji oficiales como los cuatro kanji compatibles con
JIS X 0208 están marcados como kanji Joyo. Esto se refleja en la lista `/joyo`
proporcionada por kanjiapi.dev.

Los caracteres afectados son:
| kanji oficial Joyo | compatible histórico JIS X 0208 |
| --- | --- |
|𠮟 U+20B9F |叱 U+53F1|
|塡 U+5861  |填 U+586B|
|剝 U+525D  |剥 U+5265|
|頰 U+9830  |頬 U+982C|

#### Lista de kanji jinmeiyo

`$ curl https://kanjiapi.dev/v1/kanji/jinmeiyo` (también `/jinmeiyou`)

Nota, 82 kanji en la lista Jinmeiyo tienen puntos de código en el bloque de
compatibilidad CJK de Unicode. Por lo tanto, a veces serán tratados como
"el mismo kanji" que otro carácter. Esto está especificado por Unicode en la
Base de Datos Unihan.

`kanjiapi.dev` proporciona endpoints `/kanji/{character}` para estos puntos
de código de compatibilidad CJK, pero añade un campo especial para facilitar
el acceso a la versión unificada del carácter. Además, estos caracteres de
compatibilidad en su mayoría no tienen palabras listadas en su archivo
equivalente `/words/{character}`, y tienen información mucho más limitada en
los campos del endpoint `/kanji/{character}`. Esto refleja los datos que están presentes
en el archivo `KANJIDIC`.

Por ejemplo, el carácter Jinmeiyo 海 (U+FA45) es considerado por Unicode como
el mismo que el carácter Joyo 海 (U+6d77). Por lo tanto, la versión Jinmeiyo está
presente en el bloque de compatibilidad CJK.

Esto es un problema porque cualquier capa de software (por ejemplo, la caché
del navegador, la codificación de URL) puede realizar una normalización Unicode,
que convertiría el carácter Jinmeiyo en un carácter diferente. Si esperas ver un
carácter Jinmeiyo, pero ves un carácter Joyo, probablemente esta sea la razón.

Si es necesario, la propiedad css `font-variant-east-asian: traditional;` puede
usarse para indicar al navegador que muestre el carácter equivalente unificado
de la manera tradicional, lo que debería significar que un código de carácter Joyo
se muestre como su equivalente Jinmeiyo.

#### Lista de kanji Heisig

`$ curl https://kanjiapi.dev/v1/kanji/heisig`

Lista de caracteres que tienen una palabra clave Heisig asignada. Nota, hay cuatro
kanji adicionales en la lista heisig etiquetados con '[alt]' después de la palabra
clave normal. Estos son los cuatro variantes oficiales joyo de los kanji faltantes
de JIS X 0208 (la serie de libros Heisig asignó estas palabras clave a los caracteres
compatibles con JIS, pero una persona buscándolos podría venir de la versión compatible
con JIS o la versión oficial). Ver la sección `Lista de kanji joyo` arriba.

#### Lista de kanji de un cierto grado

`$ curl https://kanjiapi.dev/v1/kanji/grade-1` (grados escolares 1-6, con el grado 8 señalando
el resto del grado de secundaria)

### Lectura `/v1/reading/{reading}`
```
$ curl https://kanjiapi.dev/v1/reading/クウ
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

### Palabras `/v1/words/{character}`
```
$ curl https://kanjiapi.dev/v1/words/猫
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```

## Desarrollo:

### Requisitos:

Se asume que `python 3`, `make` y `node` están disponibles.

### Configuración:

Instalar las librerías de python usando requirements.txt

Instalar las dependencias de node usando `yarn` o `npm install`.

Guardar y extraer el archivo del diccionario kanji `kanjidic2.xml` desde [EDRDG](http://www.edrdg.org/wiki/index.php/KANJIDIC_Project) en la raíz del proyecto.

Guardar y extraer el archivo del diccionario jmdict `JMdict` desde [EDRDG](http://www.edrdg.org/wiki/index.php/JMdict-EDICT_Dictionary_Project) en la raíz del proyecto.

Guardar y extraer el archivo Unihan_OtherMappings.txt desde Unihan.zip de [Unicode](https://www.unicode.org/versions/components-15.0.0.html) en la raíz del proyecto.

Guardar y extraer el archivo Unihan_IRGSources.txt desde Unihan.zip de [Unicode](https://www.unicode.org/versions/components-15.0.0.html) en la raíz del proyecto.

Asegurarse de que el sistema tenga la fuente `System/Library/Fonts/ヒラギノ丸ゴ\ ProN\ W4.ttc`
disponible (para la generación del favicon).

### Construcción:

Ejecutar `make` para construir el sitio y los endpoints API como activos estáticos.

Ejecutar `python -m pytest tests` para correr las pruebas.

Nota: para obtener datos de la construcción local de la API desde la construcción local del sitio, puedes configurar la raíz de tu servidor de archivos a out/site (por ejemplo con `serveit`: `serveit -s out/site make`). Hay un enlace simbólico a `out/v1` dentro de `out/site` para habilitar esto.

Nota: los archivos de endpoints para caracteres en el bloque de Compatibilidad CJK de Unicode
se escriben en un directorio separado ya que algunos sistemas de archivos los normalizan con los equivalentes no compatibles. Esto significa que algunos endpoints
`/kanji/{character}` y `/words/{character}` no aparecen bajo la ruta normal en la API durante el desarrollo local.






### Despliegue (Requiere credenciales de cuenta de Google Cloud):

#### Versionado

La versión de la API para el despliegue está codificada en `api_data.py` y en el `makefile`.


#### Subida al bucket

Después de construir, para sincronizar los recursos construidos con el bucket del sitio web, ejecute:

NB: es una buena idea ejecutar todos estos comandos con `rsync -n` para una prueba en seco primero

Para sincronizar el directorio del sitio construido (`out/site`) con la raíz del bucket, pero no recursivamente:
`gsutil -m rsync -c -d -x ".*\.map$" out/site gs://kanjiapi.dev`

Para sincronizar las carpetas del directorio de la API construida (`out/{version}`) con el directorio `/{version}` en el bucket recursivamente basándose en los hashes de los archivos:
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/kanji gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/kanji_cjk gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/words gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/words_cjk gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/reading gs://kanjiapi.dev/v1/reading/`

#### Configuración de la política CORS:

La política CORS se almacena en `cors.json`, puede actualizarse editando este archivo y ejecutando `gsutil cors set cors.json gs://kanjiapi.dev`

### Registro:

Los archivos de registro son generados por el bucket de almacenamiento en la nube para la API, hay una
función en la nube que se activa cada vez que se escribe un archivo de registro de uso. La
función en la nube lee los archivos de registro para agregar información útil que se
muestra en la [página de registros](https://kanjiapi.dev/#!/logs)

La función en la nube se encuentra en el directorio `popularity-contest`.

Para desplegarla, ejecute `gcloud functions deploy popularity-contest --gen2
--region=us-west1 --runtime=python310 --source popularity-contest --entry-point
handle --trigger-bucket=kanjiapi-dev-logging --trigger-location=us` desde la
raíz del proyecto. (se necesitan credenciales)

Para ejecutar la función en la nube localmente, ingrese al directorio `popularity-contest`,
cree y/o active un entorno virtual basado en el archivo `requirements.txt`
en ese subdirectorio, luego ejecute `python main.py`. Esto es útil para
procesar manualmente (re) algunos archivos de registro sin desplegar o activar la función en la nube.
(se necesitan credenciales)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-03

---