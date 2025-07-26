<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Symuluj i wizualizuj czarne dziury Schwarzschilda, bazując na metodach opisanych w Luminet (1979).

![Przykładowy wykres czarnej dziury](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Instalacja
`luminet` jest dostępny na PyPI:

```shell
pip install luminet
```

## 📖 [Dokumentacja](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Użytkowanie

Wszystkie zmienne w tym repozytorium są w jednostkach naturalnych: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Aby utworzyć obraz:
```python
ax = bh.plot()          # Create image like above
```
Aby próbować fotony na dysku akrecyjnym:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
Zwróć uwagę, że próbkowanie jest ukierunkowane na centrum czarnej dziury, ponieważ stamtąd pochodzi większość jasności.


## 📝 Tło
Czarne dziury Schwarzschilda mają najbliższą stabilną orbitę na poziomie $6M$, a sferę fotonową na $3M$. Oznacza to, że
dysk akrecyjny otaczający czarną dziurę emituje fotony na promieniach $r>6M$. Dopóki perygeum fotonu w zakrzywionej czasoprzestrzeni pozostaje większe niż $3M$ (nazywane także sferą fotonową), foton nie zostaje pochłonięty przez czarną dziurę i teoretycznie może być widoczny z pewnej ramki obserwatora $(b, \alpha)$. Zakrzywienie czasoprzestrzeni najłatwiej zinterpretować jako efekt soczewkowania między układem odniesienia czarnej dziury $(r, \alpha)$ a układem obserwatora $(b, \alpha)$. Pierwsze z nich to dwuwymiarowe współrzędne biegunowe obejmujące obszar dysku akrecyjnego, a drugie to dwuwymiarowe współrzędne biegunowe pokrywające "kliszę fotograficzną" ramki obserwatora. Możesz myśleć o nich dosłownie jak o matrycy CCD. Perygeum orbity fotonu i promień w układzie obserwatora $b$ są bezpośrednio powiązane:

$$b^2 = \frac{P^3}{P-2M}$$

To sprawia, że wiele równań staje się znacznie prostszych. 
Możesz zauważyć, że to równanie ma kwadrat po lewej stronie, w przeciwieństwie do Luminet (1979). Oryginalny rękopis zawiera kilka błędów notacyjnych. Skontaktowałem się z autorem w tej sprawie, na co uprzejmie odpowiedział:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"W tamtych czasach nie miałem jeszcze nawyku starannego sprawdzania próbnych odbitek. Na szczęście jednak obliczenia wykonałem poprawnymi wzorami, inaczej wynik wizualny nie byłby prawidłowy!".

Tak tylko żebyś wiedział. Starałem się dokładnie zaznaczać, gdzie ten kod różni się od publikacji.

Zależność między kątami obu układów współrzędnych jest trywialna, natomiast zależność między promieniami w obu układach odniesienia podaje potworne Równanie 13:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Tutaj $F$ to niezupełny eliptyczny całka Jacobiego pierwszego rodzaju, $k$ i $Q$ są funkcją perygeum $P$, $\zeta$ to funkcje trygonometryczne $P$, a $\gamma$ spełnia:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

W zakrzywionej czasoprzestrzeni zazwyczaj istnieje wiele orbit fotonów pochodzących z tego samego punktu współrzędnych i rzutujących się na ramkę obserwatora (zob. np. soczewkowanie grawitacyjne i krzyże Einsteina). Orbity fotonów, które okrążają czarną dziurę i docierają do ramki obserwatora, nazywane są "wyższego rzędu" obrazami lub obrazami "duchami". W tym przypadku $\gamma$ spełnia:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Te fotony-duchy to te, które widzisz w dolnej części powyższego obrazu, a także ledwo widoczna aureola światła, która cienko otacza sferę fotonową. Przy mniejszych kątach nachylenia ten obraz-duch jest jednak mniej wyraźny.

To repozytorium używa `scipy.optimize.brentq` do rozwiązywania tych równań oraz zapewnia wygodne API do zagadnień przedstawionych w Luminet (1979). Klasa `BlackHole` jest najbardziej oczywista, ale pouczające jest również pobawienie się np. klasą `Isoradial`: linie w układzie obserwatora opisujące fotony emitowane z tego samego promienia w układzie czarnej dziury. Klasa `Isoredshift` dostarcza linii równych przesunięć ku czerwieni w układzie obserwatora.

## 📕 Bibliografia
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, s. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---