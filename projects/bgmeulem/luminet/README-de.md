<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Simuliere und visualisiere Schwarze Löcher nach Schwarzschild, basierend auf den in Luminet (1979) beschriebenen Methoden.

![Beispielgrafik eines Schwarzen Lochs](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Installation
`luminet` ist über PyPI verfügbar:

```shell
pip install luminet
```

## 📖 [Dokumentation](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Verwendung

Alle Variablen in diesem Repository sind in natürlichen Einheiten angegeben: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Um ein Bild zu erstellen:
```python
ax = bh.plot()          # Create image like above
```
Um Photonen auf der Akkretionsscheibe zu sampeln:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
Beachte, dass das Sampling zum Zentrum des Schwarzen Lochs hin verzerrt ist, da von dort der größte Teil der Leuchtkraft stammt.


## 📝 Hintergrund
Schwarzschild-Schwarze Löcher haben eine innerste stabile Umlaufbahn bei $6M$ und eine Photonensphäre bei $3M$. Das bedeutet,
dass die Akkretionsscheibe, die das Schwarze Loch umkreist, Photonen bei Radien $r>6M$ emittiert. Solange das Perigäum des Photons im gekrümmten Raum größer als $3M$ bleibt (auch Photonensphäre genannt), wird das Photon nicht vom Schwarzen Loch eingefangen und kann theoretisch von einem Beobachterrahmen $(b, \alpha)$ aus gesehen werden. Die Raumzeitkrümmung lässt sich am einfachsten als Linseneffekt zwischen dem Schwarzen-Loch-Rahmen $(r, \alpha)$ und dem Beobachterrahmen $(b, \alpha)$ interpretieren. Erstere sind 2D-Polarkoordinaten, die den Bereich der Akkretionsscheibe aufspannen, letztere sind 2D-Polarkoordinaten, die die „Fotoplatte“ des Beobachterrahmens aufspannen. Letztere kann man sich als eine echte CCD-Kamera vorstellen. Das Photonorbit-Perigäum und der Radius im Beobachterrahmen $b$ stehen in direktem Zusammenhang:

$$b^2 = \frac{P^3}{P-2M}$$

Dies vereinfacht viele Gleichungen erheblich.
Dir fällt vielleicht auf, dass diese Gleichung auf der linken Seite ein Quadrat enthält, im Gegensatz zu Luminet (1979). Das Originalmanuskript enthält einige Notationsfehler. Ich habe den Autor dazu kontaktiert, woraufhin er freundlich antwortete:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"Damals hatte ich mir noch nicht angewöhnt, meine Korrekturbögen sehr sorgfältig gegenzulesen. Zum Glück habe ich die Berechnungen mit den richtigen Formeln durchgeführt, sonst wäre das visuelle Ergebnis nicht korrekt gewesen!".

Nur damit du Bescheid weißt. Ich habe versucht, sorgfältig zu vermerken, wo sich dieser Code von der Publikation unterscheidet.

Die Beziehung zwischen den Winkeln beider Koordinatensysteme ist trivial, aber die Beziehung der Radien in den beiden Bezugssystemen wird durch die monströse Gleichung 13 gegeben:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Hier ist $F$ ein unvollständiges Jacobisches elliptisches Integral erster Art, $k$ und $Q$ sind Funktionen des Perigäums $P$, $\zeta$ sind trigonometrische Funktionen von $P$, und $\gamma$ erfüllt:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

Im gekrümmten Raum gibt es in der Regel mehrere Photonbahnen, die vom selben Koordinatenpunkt ausgehen und auf den Beobachterrahmen projizieren (siehe z. B. Gravitationslinsen und Einstein-Kreuze). Photonbahnen, die um das Schwarze Loch herum verlaufen und den Beobachterrahmen erreichen, nennt man „höherordentliche“ oder „Geisterbilder“. In diesem Fall gilt für $\gamma$:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Diese Geisterphotonen sind auf der unteren Hälfte des obigen Bildes sowie im kaum sichtbaren Lichtkranz zu sehen, der sich dünn um die Photonensphäre legt. Bei geringeren Inklinationen ist dieses Geisterbild allerdings weniger ausgeprägt.

Dieses Repository verwendet `scipy.optimize.brentq`, um diese Gleichungen zu lösen, und stellt eine praktische API zu den in Luminet (1979) vorgestellten Konzepten bereit. Die Klasse `BlackHole` ist die offensichtlichste, aber es ist auch lehrreich, z. B. mit der Klasse `Isoradial` zu experimentieren: Linien im Beobachterrahmen, die Photonen beschreiben, die vom selben Radius im Schwarzen-Loch-Rahmen emittiert werden. Die Klasse `Isoredshift` liefert Linien gleichen Rotverschiebungswertes im Beobachterrahmen.

## 📕 Bibliographie
[1] Luminet, J.-P., [„Image of a spherical black hole with thin accretion disk.“](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, Bd. 75, S. 228–235, 1979.

[2] J.-P. Luminet, [„An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).“](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---