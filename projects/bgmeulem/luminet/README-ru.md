<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Симуляция и визуализация чёрных дыр Шварцшильда на основе методов, описанных в Luminet (1979).

![Пример графика чёрной дыры](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Установка
`luminet` доступен через PyPI:

```shell
pip install luminet
```

## 📖 [Документация](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Использование

Все переменные в этом репозитории указаны в естественных единицах: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Чтобы создать изображение:
```python
ax = bh.plot()          # Create image like above
```
Чтобы отобрать фотоны на аккреционном диске:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
Обратите внимание, что выборка смещена к центру черной дыры, поскольку именно оттуда исходит большая часть светимости.

## 📝 Обзор
У шварцшильдовских черных дыр существует внутренняя устойчивая орбита на расстоянии $6M$ и фотонная сфера на $3M$. Это означает, что аккреционный диск, вращающийся вокруг черной дыры, испускает фотоны на радиусах $r>6M$. Пока перигей фотона в искривленном пространстве остается больше $3M$ (также называемой фотонной сферой), фотон не захватывается черной дырой и теоретически может быть виден из некоторой системы отсчета наблюдателя $(b, \alpha)$. Искривление пространства-времени наиболее просто интерпретируется как эффект гравитационного линзирования между системой отсчета черной дыры $(r, \alpha)$ и системой отсчета наблюдателя $(b, \alpha)$. Первая — это двумерные полярные координаты, охватывающие область аккреционного диска, а вторая — двумерные полярные координаты, охватывающие "фотопластинку" системы наблюдателя. Представьте это как буквальную CCD-камеру. Перигей орбиты фотона и радиус в системе наблюдателя $b$ напрямую связаны:

$$b^2 = \frac{P^3}{P-2M}$$

Это делает многие уравнения значительно проще.
Вы можете заметить, что в этом уравнении слева стоит квадрат, в отличие от Luminet (1979). В оригинальной рукописи есть несколько ошибок в обозначениях. Я связался с автором по этому поводу, на что он любезно ответил:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"В те времена у меня еще не было привычки тщательно перечитывать корректуру. К счастью, расчеты я делал по правильным формулам, иначе изображение было бы неверным!".

Просто чтобы вы знали. Я постарался тщательно отметить, где этот код отличается от статьи.

Связь между углами обеих систем координат тривиальна, но связь между радиусами в двух системах отсчета задается монструозным уравнением 13:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Здесь $F$ — это неполный эллиптический интеграл Якоби первого рода, $k$ и $Q$ являются функциями перигея $P$, $\zeta$ — тригонометрические функции от $P$, а $\gamma$ удовлетворяет:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

В искривленном пространстве-времени обычно существует несколько орбит фотонов, исходящих из одной и той же точки и проецирующихся в систему наблюдателя (см., например, гравитационное линзирование и кресты Эйнштейна). Орбиты фотонов, которые огибают черную дыру и достигают системы наблюдателя, называются "образами высшего порядка" или "призрачными" изображениями. В этом случае $\gamma$ удовлетворяет:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Эти призрачные фотоны — это то, что вы видите на нижней половине изображения выше, а также едва различимую световую ауру, тонко опоясывающую фотонную сферу. Для менее наклоненных дисков такое призрачное изображение выражено слабее.

В этом репозитории используется `scipy.optimize.brentq` для решения этих уравнений и предоставляется удобный API для концепций, представленных в Luminet (1979). Класс `BlackHole` — наиболее очевидный, но полезно также поэкспериментировать, например, с классом `Isoradial`: линии в системе наблюдателя, описывающие фотоны, испущенные с одного радиуса в системе черной дыры. Класс `Isoredshift` строит линии равного красного смещения в системе наблюдателя.

## 📕 Библиография
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---