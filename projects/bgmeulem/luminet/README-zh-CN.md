<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

基于Luminet (1979) 中描述的方法，模拟和可视化Schwarzschild黑洞。

![Example plot of a black hole](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ 安装
`luminet` 可通过 PyPI 获取：

```shell
pip install luminet
```

## 📖 [文档](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 使用方法

本仓库中的所有变量均采用自然单位制：$G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
创建图像：
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
注意采样偏向黑洞中心，因为那里是大部分光度的来源。

## 📝 背景
施瓦茨希尔德黑洞有一个最内稳定轨道为 $6M$，以及一个光子球面在 $3M$。这意味着
绕黑洞旋转的吸积盘在半径 $r>6M$ 处发射光子。只要光子在曲率空间中的近地点大于 $3M$（也称为光子球面），光子不会被黑洞捕获，理论上可以从某个观测者坐标系 $(b, \alpha)$ 看到。时空曲率最容易被解释为黑洞坐标系 $(r, \alpha)$ 与观测者坐标系 $(b, \alpha)$ 之间的透镜效应。前者是跨越吸积盘区域的二维极坐标，后者是跨越观测者坐标系“摄影底片”的二维极坐标。可以把后者想象成一个真实的 CCD 摄像头。光子轨道近地点与观测者坐标系中的半径 $b$ 直接相关：

$$b^2 = \frac{P^3}{P-2M}$$

这使许多方程显著简化。
你可能注意到该方程左侧有平方，与 Luminet (1979) 不同。原稿中存在一些符号错误。我已联系作者，他友好回复：

> “[…] 当时我还没有仔细校对校样的习惯。但幸运的是，我的计算是用正确的公式完成的，否则结果图像不会正确！”
>
> “Back in the day, I did not have the habit of carefully double-checking my proofs. Luckily, I did calculate the results with the correct formulas, otherwise the image wouldn't be right!”

特此告知。我尽量认真记录代码与论文的差异。

两个坐标系统的角度关系很简单，但两个参考系中半径的关系由庞大的方程13给出：

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

其中，$F$ 是第一类不完全雅可比椭圆积分，$k$ 和 $Q$ 是近地点 $P$ 的函数，$\zeta$ 是 $P$ 的三角函数，$\gamma$ 满足：

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

在曲率时空中，通常存在多个光子轨道起源于相同坐标并投影到观测者坐标系（参见如引力透镜和爱因斯坦十字）。绕黑洞弯曲达到观测者坐标系的光子轨道称为“高阶”图像或“幽灵”图像。在这种情况下，$\gamma$ 满足：

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

这些幽灵光子就是你在上图下半部分看到的，以及稀薄包绕光子球面的微弱光晕。对于不那么边缘视角的倾角，这种幽灵图像则不那么明显。

本仓库使用 `scipy.optimize.brentq` 解这些方程，并提供方便的 API 来实现 Luminet (1979) 中的概念。`BlackHole` 类是最明显的，但玩转例如 `Isoradial` 类也很有教育意义：表示观测者坐标系中从黑洞坐标系同一半径发射光子的线。`Isoredshift` 类提供观测者坐标系中等红移线。

## 📕 参考文献
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---