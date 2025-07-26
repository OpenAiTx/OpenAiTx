<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Simulez et visualisez des trous noirs de Schwarzschild, en vous basant sur les méthodes décrites dans Luminet (1979).

![Exemple de tracé d’un trou noir](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Installation
`luminet` est disponible sur PyPI :

```shell
pip install luminet
```

## 📖 [Documentation](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Utilisation

Toutes les variables de ce dépôt sont en unités naturelles : $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Pour créer une image :
```python
ax = bh.plot()          # Create image like above
```
Pour échantillonner des photons sur le disque d'accrétion :

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
Notez que l’échantillonnage est biaisé vers le centre du trou noir, car c’est de là que provient la majeure partie de la luminosité.

## 📝 Contexte
Les trous noirs de Schwarzschild ont une orbite stable la plus proche à $6M$, et une sphère de photons à $3M$. Cela signifie que
le disque d’accrétion en orbite autour du trou noir émet des photons à des rayons $r>6M$. Tant que le périgée du photon dans l’espace courbe reste supérieur à $3M$ (également appelé sphère de photons), le photon n’est pas capturé par le trou noir et peut théoriquement être vu d’un certain référentiel d’observation $(b, \alpha)$. La courbure de l’espace-temps s’interprète le plus simplement comme un effet de lentille entre le référentiel du trou noir $(r, \alpha)$ et le référentiel de l’observateur $(b, \alpha)$. Les premiers sont des coordonnées polaires 2D qui couvrent la surface du disque d’accrétion, les seconds sont des coordonnées polaires 2D qui couvrent la « plaque photographique » du référentiel de l’observateur. Pensez à ce dernier comme à un véritable appareil CCD. Le périgée de l’orbite du photon et le rayon dans le référentiel d’observation $b$ sont directement reliés :

$$b^2 = \frac{P^3}{P-2M}$$

Cela simplifie considérablement de nombreuses équations.
Vous remarquerez que cette équation a un carré à gauche, contrairement à Luminet (1979). Le manuscrit original comporte quelques erreurs de notation. J’ai contacté l’auteur à ce sujet, auquel il a aimablement répondu :

> « [...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct! »
>
>« Back in the day, I did not have the habit of carefully double-checking my proofs. Luckily, I did calculate the results with the correct formulas, otherwise the image wouldn't be right! ».

Pour information. J’ai essayé d’être diligent pour noter où ce code diffère de l’article.

La relation entre les angles des deux systèmes de coordonnées est triviale, mais la relation entre les rayons dans les deux référentiels est donnée par la monstrueuse équation 13 :

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Ici, $F$ est une intégrale elliptique de Jacobi incomplète du premier genre, $k$ et $Q$ sont des fonctions du périgée $P$, $\zeta$ sont des fonctions trigonométriques de $P$, et $\gamma$ satisfait :

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

Dans l’espace-temps courbe, il y a généralement plusieurs orbites photoniques qui proviennent de la même coordonnée et se projettent dans le référentiel de l’observateur (voir par ex. le lentillage gravitationnel et les croix d’Einstein). Les orbites de photons qui contournent le trou noir et atteignent l’observateur sont appelées images « d’ordre supérieur » ou images « fantômes ». Dans ce cas, $\gamma$ satisfait :

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Ces photons fantômes sont ce que vous voyez dans la moitié inférieure de l’image ci-dessus, ainsi que l’auréole de lumière à peine visible qui entoure finement la sphère de photons. Pour des inclinaisons moins rasantes, cette image fantôme est cependant moins marquée.

Ce dépôt utilise `scipy.optimize.brentq` pour résoudre ces équations, et fournit une API pratique pour les concepts présentés dans Luminet (1979). La classe `BlackHole` est la plus évidente, mais il est aussi instructif de manipuler par ex. la classe `Isoradial` : lignes dans le référentiel de l’observateur décrivant les photons émis depuis un même rayon dans le référentiel du trou noir. La classe `Isoredshift` fournit les lignes d’égal décalage vers le rouge dans le référentiel de l’observateur.

## 📕 Bibliographie
[1] Luminet, J.-P., [« Image of a spherical black hole with thin accretion disk. »](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [« An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002). »](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---