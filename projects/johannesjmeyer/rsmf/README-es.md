[![Versión PyPI](https://badge.fury.io/py/rsmf.svg)](https://pypi.org/project/rsmf/)
[![Estado de la documentación](https://readthedocs.org/projects/rsmf/badge/?version=latest)](https://rsmf.readthedocs.io/en/latest/?badge=latest)
[![rsmf](https://circleci.com/gh/johannesjmeyer/rsmf.svg?style=shield)](https://github.com/johannesjmeyer/rsmf)
[![Estilo de código: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)


# rsmf (ajusta el tamaño de mis figuras)

Cuando escribo un artículo soy un poco exigente con las figuras. Es especialmente importante para mí que las fuentes y tamaños de fuente coincidan con el documento circundante. Como normalmente hago gráficos con matplotlib, creé esta biblioteca para ayudar con eso. Esta biblioteca proporciona un medio para 
ajustar automáticamente los tamaños de las figuras y las fuentes en matplotlib para que coincidan con los de revistas científicas comúnmente usadas. Actualmente se soportan `quantumarticle` y `revtex4`. 

# Instalación

Puedes obtener la versión más reciente desde PyPI.
```bash
pip install rsmf
```
Para obtener la versión de desarrollo más reciente, debe instalar el paquete desde GitHub.
```bash
pip install git+https://www.github.com/johannesjmeyer/rsmf
```

El paquete depende del backend PGF de matplotlib. Para poder usarlo, necesitas tener una distribución TeX funcional con `pdflatex` instalado (ver más en el [Issue #2](https://github.com/johannesjmeyer/rsmf/issues/2)).

# Uso

Una explicación detallada del uso se encuentra en la [documentación](https://rsmf.readthedocs.io/en/latest/source/howto.html).

## Configuración
Necesitas indicarle a rsmf cómo configuras tu documento invocando `rsmf.setup`. Esto se puede hacer de dos maneras. O bien, le das a rsmf la cadena `\documentclass` usada para configurar el documento, como en
```python
import rsmf
formatter = rsmf.setup(r"\documentclass[a4paper,12pt,noarxiv]{quantumarticle}")
```
La `r` delante de la cadena es necesaria para que `\d` no se confunda con una secuencia de escape. Si tienes tu documento almacenado localmente, hay una forma aún más conveniente:  
puedes simplemente proporcionar a rsmf la ruta a tu archivo tex principal (el que contiene la configuración del documento) y él lo descubrirá por sí mismo:
```python
formatter = rsmf.setup("example.tex")
```
Esto es especialmente genial porque rsmf ajustará automáticamente los gráficos cuando se cambie la clase del documento subyacente sin necesidad de cambiar el código de Python. ¡Esto hace que cambiar de revista sea mucho más fácil!

Si la clase de documento que estás usando no es compatible con `rsmf`, aún puedes usarlo. En ese caso, debes extraer las medidas relevantes tú mismo y usar `rsmf.CustomFormatter`. Una explicación detallada se encuentra en la [documentación](https://rsmf.readthedocs.io/en/latest/source/howto.html).

## Figuras
La rutina de configuración devolverá un formateador. Este formateador puede usarse para crear objetos de figura de matplotlib invocando el método `formatter.figure`. Tiene tres argumentos:

* `aspect_ratio` (float, opcional): la proporción de aspecto (alto/ancho) de tu gráfico. Por defecto es el inverso de la proporción áurea.
* `width_ratio` (float, opcional): el ancho de tu gráfico en múltiplos de `\columnwidth`. Por defecto es 1.0.
* `wide` (bool, opcional): indica si la figura abarca dos columnas en modo dos columnas,
                es decir, si se usa el entorno figure*, no tiene efecto en modo una columna. Por defecto es False.

Este es el lugar donde configuras el ancho de tus gráficos, _no en el documento LaTeX._ ¡Si incluyes la figura resultante con un ancho diferente, los tamaños de fuente no coincidirán con el documento circundante!

Por ejemplo, una figura regular se crea mediante
```python
fig = formatter.figure(aspect_ratio=.5)

# ... some plotting ...
plt.savefig("example.pdf")
```
e incluido mediante
```tex
\begin{figure}
	\centering
	\includegraphics{example}
	\caption{...}
\end{figure}
```
Una figura ancha que abarca el 80% de la página, por otro lado, se crea mediante
```python
fig = formatter.figure(width_ratio=.8, wide=True)

# ... some plotting ...
plt.savefig("example_wide.pdf")
```
e incluido a través del entorno de múltiples columnas `figure*`:
```tex
\begin{figure*}
	\centering
	\includegraphics{example_wide}
	\caption{...}
\end{figure*}
```

Tenga en cuenta que siempre debe guardar sus figuras en algún tipo de formato vectorizado, como `pdf` y que llamar a `plt.tight_layout()` antes de guardar generalmente hace que sus gráficos se vean mejor.

Además, observe que el parámetro ``aspect_ratio`` se define como la altura del gráfico dividida por su ancho. Aunque las relaciones de aspecto se definen más comúnmente como ancho/altura, esta elección resulta en que el ancho y la altura de la figura sean proporcionales a ``width_ratio`` y ``aspect_ratio`` respectivamente.

También es posible crear los objetos de la figura manualmente, usando `formatter.columnwidth` y `formatter.wide_columnwidth`, la rutina `formatter.figure` es un envoltorio de conveniencia alrededor de esto.

## Otras características
Puede acceder a los tamaños de fuente subyacentes a través de `formatter.fontsizes`. La nomenclatura sigue la de LaTeX mismo, por lo que tenemos, por ejemplo, `formatter.fontsizes.tiny` o `formatter.fontsizes.Large`.
Esto es especialmente útil si desea ajustar títulos, leyendas y anotaciones mientras mantiene tamaños de fuente coincidentes.

## Usando rsmf con otros frameworks
Puede usar rsmf junto con su framework de gráficos favorito, por ejemplo `seaborn`. Solo hay una condición: si utiliza estilos de matplotlib o estilos de seaborn, podría sobrescribir las configuraciones impuestas por rsmf, especialmente en cuanto al tamaño de fuente. Para esto, los formateadores tienen un método `formatter.set_default_fontsizes` que solo cambia los tamaños de fuente subyacentes. Un ejemplo de uso sería
```python
fig = formatter.figure(wide=True)
sns.set(style="ticks")
formatter.set_default_fontsizes()

# ... some plotting ...
```
A veces estos estilos también sobrescriben otras cosas, como la familia tipográfica (serif/sans-serif). Aún no existe un método de corrección para eso.

## Ejemplo
Un documento de ejemplo junto con un cuaderno para hacer los gráficos usados se puede encontrar en la carpeta `examples`.

# Cómo funciona
Bajo el capó, rsmf establece el backend de matplotlib a `pgf`, lo que permite el uso de LaTeX. Para cada clase de documento soportada, los anchos específicos de columna y tamaños de fuente se almacenan en el código, junto con los paquetes que se cargan y que cambian las fuentes. Para `quantumarticle`, por ejemplo, el paquete `lmodern` se carga en el backend `pgf` para obtener la fuente sans-serif correcta.

Al llamar a `rsmf.setup`, se ajustan los `rcParams` de matplotlib para que los tamaños de fuente coincidan con el documento circundante. Tenga en cuenta que `formatter.figure` no modifica los `rcParams`.

# Contribuir
¿Tiene problemas para configurar gráficos para su clase de documento favorita y no está soportada aquí? ¡No dude en hacer un PR!

Un gran agradecimiento por las contribuciones va a:
[Samuel J. Palmer](https://github.com/sp94),
[platipo](https://github.com/platipo),
[Lorenzo Fioroni](https://github.com/LorenzoFioroni)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-18

---