<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

基于 Luminet (1979) 描述的方法，模拟并可视化施瓦西黑洞。

![Example plot of a black hole](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ 安装
`luminet` 可通过 PyPI 获得：

```shell
pip install luminet
```

## 📖 [文档](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 用法

本仓库中的所有变量均采用自然单位：$G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
要创建一张图片：
```python
ax = bh.plot()          # Create image like above
```
在吸积盘上采样光子：

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
请注意，采样偏向于黑洞中心，因为大部分光度都来自这里。

## 📝 背景
史瓦西黑洞的最内稳定轨道为 $6M$，而光子球位于 $3M$。这意味着环绕黑洞的吸积盘在半径 $r>6M$ 处发射光子。只要弯曲时空中的光子近地点大于 $3M$（也称为光子球），光子就不会被黑洞捕获，并且理论上可以从某个观测者坐标系 $(b, \alpha)$ 看到。时空曲率最容易解释为黑洞坐标系 $(r, \alpha)$ 和观测者坐标系 $(b, \alpha)$ 之间的透镜效应。前者为二维极坐标，覆盖吸积盘区域，后者为二维极坐标，覆盖观测者坐标系的“感光板”。可以把后者字面理解为 CCD 相机。光子轨道近地点与观测者坐标系中的半径 $b$ 直接相关：

$$b^2 = \frac{P^3}{P-2M}$$

这使得许多方程变得更加简明。
你可能注意到这个方程左边有一个平方，与 Luminet (1979) 不同。原始手稿中有一些符号错误。我已联系作者，他友好地回复道：

> “[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!”
>
>“那时候我还没有仔细校对论文的习惯。幸运的是，我的计算是用正确公式做的，否则图像结果就不会正确了！”

仅供参考。我尽量详细记录了本代码与论文不同之处。

两套坐标系的角度关系很简单，但两参考系中半径的关系由庞大的公式 13 给出：

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

这里，$F$ 是不完全雅可比椭圆积分第一类，$k$ 和 $Q$ 是近地点 $P$ 的函数，$\zeta$ 是 $P$ 的三角函数，$\gamma$ 满足：

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

在弯曲时空中，通常有多个光子轨道从同一坐标出发投影到观测者坐标系（例如引力透镜和爱因斯坦十字）。绕黑洞弯曲并最终到达观测者坐标系的光子轨道称为“高阶”像或“幽灵”像。此时，$\gamma$ 满足：

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

这些幽灵光子就是上图下半部分所见之物，以及几乎不可见的薄光环，它紧贴光子球包裹一圈。当视线不那么接近平面时，这种幽灵像就不那么明显了。

本仓库使用 `scipy.optimize.brentq` 求解这些方程，并为 Luminet (1979) 中提出的概念提供了便捷的 API。最明显的是 `BlackHole` 类，但玩一玩如 `Isoradial` 类也很有教育意义：它描述了观测者坐标系下来自黑洞坐标系同一半径发射的光子的轨迹线。`Isoredshift` 类则在观测者坐标系下给出等红移线。

## 📕 参考文献
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>天文学与天体物理</i>, 第 75 卷, 228–235 页, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---