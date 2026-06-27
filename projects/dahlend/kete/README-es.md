<p align="center">
<img src="https://github.com/dahlend/kete/blob/main/docs/_static/kete.svg" style="width:20%">
</p> 

# *Kete*

Predecir órbitas de asteroides y cometas a gran escala.

Vea el [artículo en arXiv](http://arxiv.org/abs/2509.04666).

![Github Actions](https://github.com/dahlend/kete/actions/workflows/test-lint.yml/badge.svg?branch=main)
[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.15259732.svg)](https://doi.org/10.5281/zenodo.15259732)
[![arXiv](https://img.shields.io/badge/arXiv-2509.04666-00ff00.svg)](http://arxiv.org/abs/2509.04666)

Las herramientas kete están diseñadas para permitir la simulación de encuestas de todo el cielo de
planetas menores. Esto incluye la dinámica orbital de física de múltiples cuerpos,
determinación y ajuste de órbitas, modelado térmico y óptico de los objetos, así como correcciones
de campo de visión y retraso de la luz. Estas herramientas, junto con los Centros de Planetas Menores (MPC) y
las bases de datos de asteroides conocidos del JPL, pueden usarse no solo para planificar encuestas sino también para
predecir qué objetos son visibles para encuestas existentes o pasadas.

El objetivo principal de kete es habilitar un conjunto de herramientas que puedan operar sobre todo el
catálogo MPC de una vez, sin necesidad de hacer consultas sobre objetos específicos. Se ha
usado para simular más de 10 años de tiempo de encuesta para la misión NEO Surveyor usando 10
millones de asteroides del cinturón principal y cercanos a la Tierra.

[Documentación](https://dahlend.github.io/kete/)  
   - [Ejemplos](https://dahlend.github.io/kete/auto_examples/index.html)
   - [Tutoriales](https://dahlend.github.io/kete/tutorials/index.html)


https://github.com/user-attachments/assets/a48491d8-9c15-4659-9022-1767a3aa1e94

Aquí hay una simulación de lo que la encuesta ZTF observaría durante todo el 2023.
Esta es cada posición de cada asteroide numerado, junto con un cálculo de las
magnitudes esperadas en banda V. Si la magnitud esperada es menor que el límite de magnitud reportado por ZTF
para el cuadro específico, entonces el objeto parpadeará en gris claro.

Esto tomó aproximadamente 50 minutos en una computadora de escritorio para calcular, y alrededor de 40 minutos
para generar la película.

Kete se puede usar para responder muchas preguntas, por ejemplo, identificar todos los asteroides conocidos
dentro de una [imagen dada](https://dahlend.github.io/kete/tutorials/kona.html).

Kete también se puede usar como backend para visualizaciones más divertidas, tales como:  

[Ketev](https://dahlend.github.io/ketev/) - Visualizador del Sistema Solar en tu navegador


## Instalación

Kete se puede instalar usando pip:

``` bash
pip install kete
```

## Ejemplo de Código

Aquí hay un pequeño ejemplo que muestra cómo es programar con kete.
Esto calcula la distancia más cercana que el asteroide Apophis tendrá
durante su acercamiento *muy* cercano a la Tierra en abril de 2029.

Una mirada más profunda a este ejemplo se puede encontrar
[aquí](https://dahlend.github.io/kete/auto_examples/plot_close_approach.html).

```python

      import kete
      import numpy as np

      # Date of impact +- 1 day in Julian Date
      jd_center = kete.Time.from_ymd(2029, 4, 13.9066).jd

      # Step the orbit every 1 minute for +- 1 day.
      step_size = 1 / 24 / 60
      jd_range = np.arange(-1, 1, step_size) + jd_center

      # load Apophis from JPL Horizons
      obj = kete.HorizonsProperties.fetch("Apophis")
      cur_state = obj.state

      # keep track the the closest approach
      closest_approach = [np.inf, 0]
      for jd in jd_range:
            # propagate the object, and include the massive main belt asteroids
            cur_state = kete.propagate_n_body(cur_state, jd, include_asteroids=True)

            # calculate position relative to earth
            earth_vec = cur_state.pos - kete.spice.get_state("Earth", cur_state.jd).pos
            earth_dist = earth_vec.r * kete.constants.AU_KM
            if earth_dist < closest_approach[0]:
                  closest_approach = [earth_dist, cur_state.jd]

      print("Closest approach is on:")
      print(kete.Time(closest_approach[1]).iso)
      print(f"At a distance of about {closest_approach[0]:0.0f} km")
      #  Closest approach is on:
      #  2029-04-13T21:45:30.239+00:00
      #  At a distance of about 38015 km

```
## Nombre

'Kete' proviene de la mitología griega antigua, significa monstruos marinos, y es la palabra raíz
de Cetáceos (Ballenas).

## Licencia:

La versión original de este código fue desarrollada mientras el autor original (Dar Dahlen)
trabajaba en Caltech IPAC. Este es un fork de ese repositorio donde el trabajo continuará como
un proyecto personal. La diferencia entre este fork y el código anterior está licenciada bajo
BSD de 3 cláusulas, pero con derechos de autor para Dar Dahlen y futuros colaboradores.

### Unidades y Marco de Referencia

Kete usa el marco de referencia ICRF como el marco de coordenadas base, con unidades en UA,
y tiempo en JD con escala de Tiempo Dinámico Baricéntrico (TDB). Internamente este marco
se convierte a un sistema de coordenadas Eclípticas definido por el ángulo de oblicuidad
usado por JPL Horizons, que es el modelo definido IAU76/80 en el marco J2000.

      - https://en.wikipedia.org/wiki/Axial_tilt#Short_term
      - https://ssd.jpl.nasa.gov/horizons/manual.html#defs

Tanto JPL Horizons como el Centro de Planetas Menores (MPC) usan este marco de coordenadas, que es
esencialmente equivalente a las coordenadas Eclípticas J2000. Herramientas de conversión están disponibles en
kete que permiten la conversión al marco Ecuatorial y a varias formas de tiempo.

### Directorio de caché

Muchas operaciones en kete resultan en la descarga de varios archivos. Estos archivos se almacenan en caché
automáticamente, el directorio donde se guarda esta caché puede establecerse configurando la
variable de entorno `KETE_CACHE_DIR`. El directorio predeterminado es `~/.kete/`.


``` bash
export KETE_CACHE_DIR="~/.kete/"
```

### Uso con Contenedores - Docker/Podman

Tenga en cuenta que kete descarga varios archivos grandes del núcleo SPICE en el primer uso, que se
guardan en un directorio de caché.

**Importante para Docker/Podman:**
- Si activa la descarga **durante la construcción de Docker** (por ejemplo,
  `RUN python -c "import kete"`), los archivos se incluirán en la imagen.
- Si omite este paso, los archivos se descargarán en la primera ejecución del contenedor pero
  **se perderán cuando el contenedor se detenga** a menos que use un montaje de volumen para el directorio de caché.

**Enfoque recomendado para Dockerfile:**

```dockerfile
RUN pip install kete && \
    python -c "import kete"  # Triggers kernel downloads during build
```
Esto asegura que los núcleos SPICE formen parte de su imagen y no necesiten ser descargados nuevamente.

# Información para desarrolladores:

La información a continuación está dirigida a desarrolladores, y no es necesaria para los usuarios finales.

## Instalación - Desde el código fuente

Si kete se construye desde el código fuente, debe estar instalado el compilador de Rust. Las instrucciones de instalación
pueden encontrarse aquí: 

https://www.rust-lang.org/learn/get-started

Asegúrese de que su Python esté actualizado, este código funciona con Python 3.9+.

``` bash
python --version
```
Asegúrese de que su pip esté actualizado, debe ser al menos la versión `22.0.0`.

``` bash
pip --version
```

Esto se puede actualizar usando:
``` bash
python -m pip install "pip>=22.0.0" --upgrade
pip install setuptools --upgrade
```

### Desarrollo

Si planea hacer desarrollo, se recomienda instalar con lo siguiente:
``` bash
pip install '.[dev]'
```
El `[dev]` en esa línea tiene pip install una serie de dependencias opcionales que  
son útiles para el desarrollo. Incluyendo pytest y herramientas de documentación.  

### Construcción de la Documentación  

Para que la documentación se construya, se necesitan algunas bibliotecas adicionales de Python.  
Estas se pueden instalar con:
``` bash
pip install sphinx sphinx_gallery autodoc
```
Después de que esto haya sido instalado, la documentación puede ser construida ejecutando dentro del
directorio kete.
``` bash
(cd docs && make html && open html/index.html&)
```
Una vez que esto haya terminado de ejecutarse, abra el archivo `kete/docs/html/index.html` para acceder
a la documentación HTML.

Para limpiar la compilación de documentos anterior:
``` bash
(cd docs && make clean)
```

Las pruebas de documentación pueden ejecutarse con:
``` bash
(cd docs && make doctest)
```

### Ejecutando pruebas

Ejecutar pruebas requiere que los paquetes `pytest` y `pytest-cov` estén instalados.

Abre una terminal en la base de esta carpeta y ejecuta el siguiente comando:
``` bash
pytest --cov-report term-missing --cov=kete   
```

Otro tipo de informe de cobertura es HTML, esto generará una carpeta llamada `htmlcov`
en el directorio donde se ejecutó el comando, luego puedes abrir el archivo `htmlcov/index.html`.
Esta es una representación en forma de sitio web amigable para el usuario de la cobertura de código.
``` bash
pytest --cov-report html --cov=kete   
```

### Ejecución de Tutoriales

Los tutoriales son ejemplos computacionalmente costosos que son más indicativos del uso típico esperado.  
Dado que estos ejemplos son tan costosos de ejecutar, no se ejecutan a menos que  
se realicen manualmente. Se ha proporcionado un script de Python de conveniencia para hacer precisamente esto.

``` bash
cd docs
python utils.py
```

### Ejecución de Benchmarks

Hay un conjunto de micro-benchmarks en el backend de rust de kete. Estos requieren
`gnuplot` instalado, y pueden ejecutarse usando el siguiente comando:

``` bash
cargo bench
open target/criterion/report/index.html
```

Adicionalmente, los Flamegraphs pueden ser producidos usando lo siguiente:

``` bash
cargo bench --bench propagation -- --profile-time=5
cargo bench --bench spice -- --profile-time=5
cargo bench --bench thermal -- --profile-time=5
```

Estos flamegraphs se colocarán en `target/criterion/*/profile/flamegraph.svg`. Abrir
estos archivos en un navegador web mostrará qué funciones se están utilizando durante la prueba.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-27

---