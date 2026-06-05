# Beampy [![Build Status](https://travis-ci.com/hchauvet/beampy.svg)](https://travis-ci.com/hchauvet/beampy) [![codecov](https://codecov.io/gh/hchauvet/beampy/graph/badge.svg)](https://codecov.io/gh/hchauvet/beampy) ![pypi python version](https://img.shields.io/pypi/pyversions/beampy-slideshow.svg) ![pypi licence](https://img.shields.io/pypi/l/beampy-slideshow.svg) ![pypi download](https://img.shields.io/pypi/dm/beampy-slideshow.svg) ![pypi beampy version](https://img.shields.io/pypi/v/beampy-slideshow.svg)

**El desarrollo de la rama master está actualmente congelado, (solo se aplicarán correcciones urgentes de errores), la nueva versión de beampy se está desarrollando en la rama dev, que aún no es lo suficientemente estable para usar...**

Beampy es una herramienta en python para crear presentaciones en svg que pueden mostrarse con HTML5
(probado en Firefox y Chromium)
El tamaño de las diapositivas es fijo, como en un documento Latex Beamer.

La salida de la presentación Beampy es solo un archivo html con todos los contenidos incrustados.

* [Ver la documentación de Beampy](https://hchauvet.github.io/beampy/)
* [Ver una presentación de pruebas de Beampy](https://rawgit.com/hchauvet/beampy/master/examples/beampy_tests.html) (el código fuente está en *examples/beampy_tests_modules.py*)

## Instalar:

Desde el Índice de Paquetes de Python:

```bash
pip install beampy-slideshow
```

[See full installation documentation](https://hchauvet.github.io/beampy/install.html#beampy-install)

## A quick example :

```python
from beampy import *

doc = document()

with slide():
    maketitle('Beampy a tool to make simple presentation', ['H. Chauvet'])

with slide('Beampy test'):
    text(r'\href{#0}{Go to Title}')
    text(r'Use LaTeX to render text and $$\sqrt{10}$$', align='center')

with slide('Beampy test with animated layers'):
    text(r'\href{#0}{Go to Title}')[:]
    text(r'Use LaTeX to render text and $$\sqrt{10}$$', align='center')[1]

save('./simple_one.html')

#To save in pdf just change the above command to the following
#save('./simple_one.pdf')
```

[beampy_presentation.html](https://cdn.rawgit.com/hchauvet/beampy/master/examples/simple_one.html)



## Registro de cambios:

### 0.5.5
* Corregir problemas importantes con la codificación para python 2 y 3.
* Solucionar problemas con referencias faltantes en svg generados por dvisvgm
  (problema semilla [#18](https://github.com/hchauvet/beampy/issues/18) para
  toda la historia), que crea partes faltantes del contenido latex en el
  svg.
* Mejor gestión de los archivos temporales
* Actualizar scour (optimizador svg) a su última versión

### 0.5.4

* Beampy ahora es compatible con python 3 y 2 (al menos 2.7 y 3.7) !
* Introducción de pruebas integradas con el framework pytest (aún sin pruebas unitarias de las funciones núcleo de beampy)
* Corregir error al guardar múltiples formatos al mismo tiempo, ya no hay duplicación de textos [problema #13](https://github.com/hchauvet/beampy/issues/13)
* Añadir modo de salida logging.debug
* Añadir opción para especificar la ubicación del archivo fuente de la presentación ( doc = document(source_filename=__name__) )

### 0.5.3

Algunas correcciones menores:
* Corregir error en la propagación de capas para caja
* Corregir error cuando la última capa se establece como [n:]
* Comenzar a usar logging.debug en los módulos

### 0.5.2

* Corregir error con la salida de dvisvgm para tikz dvi (la función latex2svg ahora tiene
  una opción para escribir el svg producido por dvisvgm).
* Añadir módulos tableofcontents [Ver documentación](https://hchauvet.github.io/beampy/auto_examples/plot_TOC.html).
* Añadir un tema BeamerFrankfurt [Ver documentación](https://hchauvet.github.io/beampy/auto_themes/theme_BeamerFrankfurt.html).
* El módulo Figure acepta gif animados.
* Se pueden añadir paquetes latex extra al módulo texto con el
  argumento "extra_packages".
* Calcular el tamaño del rectángulo y círculo svg que mejora la velocidad de renderizado (no es necesario llamar a Inkscape).  
* Mejorar el módulo de caja (ahora es una subclase de grupo) [Ver documentación](https://hchauvet.github.io/beampy/auto_examples/plot_box.html).  
* Corregir algunos factores de escala en la función convert_unit.  
* El ancho y el alto ahora son objetos Length y aceptan operaciones complejas como:  
  


  ```python

  # 50% of the currentwidth 
  a = rectangle(width='50%', height=10)

  # width/height relative to the a element
  b = rectangle(width=a.width/2+'2cm', height=a.height/'10pt')
  ```
* la posición del módulo (x,y) ahora acepta objetos de Tipo Longitud (ancho/alto):


  ```python

  a = rectangle(width='50%', height=10)

  b = rectangle(x=a.width+'2cm', y=a.height+5)
  ```
  
* Cambiar el núcleo de beampy para renderizar elementos cuando sea necesario para
  operar sobre posición o longitud (es decir, cuando se realiza una operación sobre
  el ancho o alto de un elemento que es desconocido, el elemento será
  renderizado para obtener su tamaño y permitir la operación)
* Añadir la operación "zorder" para módulos (arriba/abajo/último/primero) para cambiar
  su orden de superposición:

  ```python

  a = rectangle(x='center', y='center', width=50, height=50)
  b = rectangle(x='center', y='center', width=a.height+100,
                height=a.height+100, color='red')

  # Make b appears below a
  b.below(a)
  
  # equivalent to a.above(b) or a.last() or b.first()
  ```

### 0.5.1

* Corregir varios errores en las figuras bokeh (gracias a [Silmathoron](https://github.com/Silmathoron))
* Corregir el redimensionamiento de figuras bokeh, ahora usa "sizing_mode = scale_both" de bokeh y revierte la escala de transformación css para el div de bokeh.
* Corregir cargador javascript para bokeh (nueva versión de bokeh (>0.12.6) nombró su div principal "bk_root")
* Añadir función para cachear archivos en la clase cache de beampy
* Cachear archivos javascript de librerías externas de bokeh (descargar desde su CDN, si "doc = document(cache=False)")


### 0.5.0
* Añadir función box para decorar grupos
* Nueva forma experimental de escribir texto dentro de la presentación usando el gestor de contexto

  ```python
  with text(width=400):
       """
       Any comment inside the context manager will be passed to the
       text function as input argument. This allows clearer source
       when writing long texts.

       No more need to add an *r* before to protect the text passed to
       latex, it's now automatically added.
       """
  ```
  
* Corregir error cuando sólo hay objetos html presentes en una diapositiva
* Corregir pequeños errores tipográficos en la sección de instalación de la documentación.

### 0.4.9

* Primer borrador de la [documentación de Beampy](https://hchauvet.github.io/beampy/)
* Añadir documentación en el módulo Beampy
* Añadir clave 'anchor' al diccionario de posición para definir el ancla a lo largo del
  cuadro delimitador del módulo para colocarlos.
* Añadir utils.py para almacenar funciones que llaman a módulos beampy.
* Añadir función **bounding_box(module)** a utils.py para dibujar el cuadro delimitador con
  anclas alrededor de los módulos Beampy. Añadir también una función para dibujar ejes en la diapositiva,
  **draw_axes()**

### 0.4.8

* Corregir parcialmente el problema #12.
* Limpiar la sintaxis del código.

### 0.4.7

* Introducir mecanismo de capas. Los elementos de la diapositiva pueden ser animados por capas permitiendo mecanismos como el "\only" de beamer.
  Las capas se gestionan como rebanado python sobre los módulos Beampy.

  ```python 
  with slide('Test layers'):
    text('First printed on layer 0')
    text('Secondly printed on layer 1')[1]
    text('Printed from layer 2 to 3')[2,3]
    text('Printed on all layers')[:]
    text('Printed on layer 4')[4]
    
    with group(width=300)[2:]:
        text('Printed inside group')
        text('for layers 2 to end')
  ```
  

### 0.4.6

* The core of Beampy slide processor has been rewritten and now allows recursive group of elements.

  ```python
  with group():
    text('toto')
    with group(width=300):
        text('tata')

        with group(width=200):
            figure('./niceplot.pdf')
            text('nice legend')
  ```
* Si se proporciona un ancho de grupo, todos los elementos en grupos sin ancho especificado toman el ancho del grupo


  ```python
  with group(width=200):
    figure('./niceplot.pdf')
    text('nice legend')
    # Figure and text width will be automatically set to 200 px
  ```

* La colocación relativa ahora se puede realizar en elementos con posición automática

  ```python
  t0 = text('toto')
  text('tata', x=t0.center + center(0), t0.bottom + 0.1)
  ```

* Ahora el video puede usar enlaces externos (con *embedded=True*) en lugar de estar incluido en el archivo html.  
  El video se carga desde el disco (tener cuidado con la ruta del archivo) cuando la diapositiva se muestra en pantalla.

### 0.4.5

* Todos los textos se preprocesan en un solo archivo latex (Latex se llama solo una vez: mejora el tiempo de compilación)  
* Corrección de error de caché: Video y svg ahora se almacenan en caché correctamente

### 0.4.4

* Mejora de caché: un archivo por elemento almacenado en caché (¡no escribir la caché dos veces!)  
* Svg: Añadir comandos de línea y rectángulo para dibujar fácilmente líneas y rectángulos  
* Colocación relativa: añadir accesos directos center(shift), right(shift) y bottom(shift)  
  para cambiar el ancla del elemento actual.

  ```python 
    e1 = text('Somthing', x=0.2, y=0.4)
    e2 = text('An other thing', 
              x=e1.left + right(0.1), 
              y=e1.center + center(0))
  ```


### 0.4.3

* Las figuras de Matplotlib ahora pueden pasarse directamente a *figure()* o una lista de figuras de matplotlib puede animarse con *animatesvg()*
* Mejora menor en el tamaño de caché (el contenido ya no se almacena en el archivo de caché)
* Actualización de la versión de scour (svg-optimiser) 

### 0.4.2
* Las rutas de glifos de Latex ahora son únicas (esto reduce el número de líneas svg en los documentos)
* Añadir el comando *svg* para incluir svg sin procesar en la diapositiva
* Mejorar la flexibilidad del tema, ¡ahora se puede crear un fondo con elementos interactivos!

### 0.4.1
* Todas las diapositivas ahora se cargan en la RAM, mejora la velocidad
* Los módulos ahora son clases que heredan de una clase base "beampy_module" en modules/core.py
* La caché ahora es única para todos los formatos (pdf, svg, html) y se pueden añadir claves especiales
  a los módulos para crear su id de caché

## Instalación

[Ver página de instalación de la documentación de Beampy](https://hchauvet.github.io/beampy/install.html)






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-05

---