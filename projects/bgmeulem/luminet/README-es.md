<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Simula y visualiza agujeros negros de Schwarzschild, basado en los métodos descritos en Luminet (1979).

![Ejemplo de gráfico de un agujero negro](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Instalación
`luminet` está disponible en PyPI:

```shell
pip install luminet
```

## 📖 [Documentación](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Uso

Todas las variables en este repositorio están en unidades naturales: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Para crear una imagen:
```python
ax = bh.plot()          # Create image like above
```

Para muestrear fotones en el disco de acreción:
```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
Ten en cuenta que el muestreo está sesgado hacia el centro del agujero negro, ya que es donde proviene la mayor parte de la luminosidad.


## 📝 Antecedentes
Los agujeros negros de Schwarzschild tienen una órbita estable más interna de $6M$, y una esfera de fotones en $3M$. Esto significa que
el disco de acreción que orbita el agujero negro emite fotones en radios $r>6M$. Mientras el perigeo del fotón en el espacio curvo permanezca mayor que $3M$ (también llamada la esfera de fotones), el fotón no es capturado por el agujero negro y en teoría puede ser visto desde algún marco de observador $(b, \alpha)$. La curvatura del espacio-tiempo se interpreta más fácilmente como un efecto de lente entre el marco del agujero negro $(r, \alpha)$ y el marco del observador $(b, \alpha)$. Los primeros son coordenadas polares 2D que abarcan el área del disco de acreción, y los segundos son coordenadas polares 2D que abarcan la "placa fotográfica" del marco del observador. Piensa en estos últimos como una cámara CCD literal. El perigeo de la órbita del fotón y el radio en el marco del observador $b$ están directamente relacionados:

$$b^2 = \frac{P^3}{P-2M}$$

Esto hace que muchas ecuaciones sean significativamente más sencillas.
Puedes notar que esta ecuación tiene un cuadrado en el lado izquierdo, en contraste con Luminet (1979). El manuscrito original tiene un puñado de errores de notación. Me puse en contacto con el autor al respecto, a lo que él respondió amablemente:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!"
>
>"En aquel entonces, no tenía el hábito de revisar cuidadosamente mis pruebas. Por suerte, sí realicé los cálculos con las fórmulas correctas, ¡de lo contrario la imagen no habría sido correcta!".

Solo para que lo sepas. Intenté ser diligente al anotar dónde este código difiere del artículo.

La relación entre los ángulos de ambos sistemas de coordenadas es trivial, pero la relación entre los radios en los dos marcos de referencia viene dada por la monstruosa Ecuación 13:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Aquí, $F$ es una integral elíptica jacobiana incompleta de primera especie, $k$ y $Q$ son funciones del perigeo $P$, $\zeta$ son funciones trigonométricas de $P$, y $\gamma$ satisface:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

En el espacio-tiempo curvado, suele haber múltiples órbitas de fotones que se originan desde la misma coordenada y se proyectan al marco del observador (ver por ejemplo lentes gravitacionales y cruces de Einstein). Las órbitas de fotones que giran alrededor del agujero negro y llegan al marco del observador se llaman imágenes de "orden superior", o imágenes "fantasma". En este caso, $\gamma$ satisface:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Estos fotones fantasma son los que ves en la mitad inferior de la imagen de arriba, así como el halo de luz apenas visible que rodea finamente la esfera de fotones. Para inclinaciones menos de canto, esta imagen fantasma es menos pronunciada.

Este repositorio utiliza `scipy.optimize.brentq` para resolver estas ecuaciones, y proporciona una API conveniente para los conceptos presentados en Luminet (1979). La clase `BlackHole` es la más obvia, pero también es educativo experimentar con, por ejemplo, la clase `Isoradial`: líneas en el marco del observador que describen fotones emitidos desde el mismo radio en el marco del agujero negro. La clase `Isoredshift` proporciona líneas de igual corrimiento al rojo en el marco del observador.

## 📕 Bibliografía
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---