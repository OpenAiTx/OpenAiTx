<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Simuleer en visualiseer Schwarzschild-zwarte gaten, gebaseerd op de methoden beschreven in Luminet (1979).

![Voorbeeldplot van een zwart gat](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Installeren
`luminet` is beschikbaar via PyPI:

```shell
pip install luminet
```

## 📖 [Documentatie](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Gebruik

Alle variabelen in deze repo zijn in natuurlijke eenheden: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Om een afbeelding te maken:
```python
ax = bh.plot()          # Create image like above
```
Om fotonen op de accretieschijf te bemonsteren:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
Let op dat de bemonstering is bevooroordeeld naar het centrum van het zwarte gat, omdat daar het grootste deel van de lichtkracht vandaan komt.


## 📝 Achtergrond
Schwarzschild-zwarte gaten hebben een binnenste stabiele baan van $6M$, en een fotonensfeer op $3M$. Dit betekent dat
de accretieschijf die rond het zwarte gat draait fotonen uitzendt op straal $r>6M$. Zolang het perigeum van het foton in de gekromde ruimte groter blijft dan $3M$ (ook wel de fotonensfeer genoemd), wordt het foton niet door het zwarte gat ingevangen en kan het in theorie vanuit een waarnemerskader $(b, \alpha)$ worden gezien. De kromming van de ruimtetijd is het eenvoudigst te interpreteren als een lenswerking tussen het zwarte gat-kader $(r, \alpha)$ en het waarnemerskader $(b, \alpha)$. Het eerste zijn 2D poolcoördinaten die het oppervlak van de accretieschijf beslaan, en het tweede zijn 2D poolcoördinaten die de "fotoplaat" van het waarnemerskader beslaan. Zie het laatste als een letterlijke CCD-camera. Het perigeum van de fotonbaan en de straal in het waarnemerskader $b$ zijn direct gerelateerd:

$$b^2 = \frac{P^3}{P-2M}$$

Hierdoor worden veel vergelijkingen aanzienlijk eenvoudiger.
Je zult merken dat deze vergelijking een kwadraat aan de linkerkant heeft, in tegenstelling tot Luminet (1979). Het originele manuscript bevat enkele notatie-fouten. Ik heb de auteur hierover benaderd, waarop hij vriendelijk reageerde:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"Destijds had ik nog niet de gewoonte om mijn proefdrukken zorgvuldig na te lezen. Gelukkig heb ik de resultaten met de juiste formules berekend, anders zou het beeld niet kloppen!".

Dat je het weet. Ik heb geprobeerd zorgvuldig aan te geven waar deze code afwijkt van het artikel.

De relatie tussen de hoeken van beide coördinatensystemen is triviaal, maar de relatie tussen de stralen in de twee referentiekaders wordt gegeven door de monsterachtige Vergelijking 13:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Hier is $F$ een onvolledige Jacobiaanse elliptische integraal van de eerste soort, $k$ en $Q$ zijn functies van het perigeum $P$, $\zeta$ zijn trigonometrische functies van $P$, en $\gamma$ voldoet aan:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

In gekromde ruimtetijd zijn er meestal meerdere fotonbanen die uit hetzelfde coördinaatpunt vertrekken en naar het waarnemerskader projecteren (zie bijv. gravitatielensing en Einstein-kruisen). Fotonbanen die om het zwarte gat krommen en het waarnemerskader bereiken, worden "hogere orde" beelden of "spook"beelden genoemd. In dit geval voldoet $\gamma$ aan:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Deze spookfotonen zie je op de onderste helft van de bovenstaande afbeelding, evenals de nauwelijks zichtbare lichtkrans die dun rond de fotonensfeer wikkelt. Bij minder scheve inclinaties is dit spookbeeld echter minder uitgesproken.

Deze repo gebruikt `scipy.optimize.brentq` om deze vergelijkingen op te lossen, en biedt een handige API voor de concepten uit Luminet (1979). De `BlackHole`-klasse is het meest voor de hand liggend, maar het is ook leerzaam om te experimenteren met bijvoorbeeld de `Isoradial`-klasse: lijnen in het waarnemerskader die fotonen beschrijven die van dezelfde straal in het zwarte gat-kader zijn uitgezonden. De `Isoredshift`-klasse geeft lijnen van gelijke roodverschuiving in het waarnemerskader.

## 📕 Bibliografie
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---