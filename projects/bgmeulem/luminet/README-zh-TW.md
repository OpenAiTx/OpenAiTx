<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

模擬並視覺化史瓦西黑洞，基於 Luminet (1979) 描述的方法。

![黑洞範例圖](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ 安裝
`luminet` 可從 PyPI 安裝：

```shell
pip install luminet
```

## 📖 [文件說明](https://luminet.readthedocs.io/zh/latest/index.html)

## 🔩 使用方式

本倉庫中的所有變數均採自然單位：$G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
要建立一個圖像：
```python
ax = bh.plot()          # Create image like above
```

要在吸積盤上採樣光子：
```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
請注意，取樣偏向黑洞中心，因為大多數的光度都來自這裡。

## 📝 背景
史瓦西黑洞具有最內穩定軌道為 $6M$，而光子球則位於 $3M$。這意味著
圍繞黑洞運行的吸積盤在半徑 $r>6M$ 處發射光子。只要曲率空間中的光子近地點大於 $3M$（也稱為光子球），光子就不會被黑洞捕獲，理論上可以從某個觀測者座標系 $(b, \alpha)$ 看到。時空曲率最容易被解釋為黑洞座標系 $(r, \alpha)$ 與觀測者座標系 $(b, \alpha)$ 之間的引力透鏡效應。前者是跨越吸積盤區域的二維極座標，後者則是跨越觀測者座標系“照相底片”的二維極座標。你可以把後者想像成一台真正的 CCD 相機。光子軌道近地點與觀測者座標系半徑 $b$ 之間有直接的關係：

$$b^2 = \frac{P^3}{P-2M}$$

這使得許多方程式大為簡化。
你可能注意到這個方程式左側有平方，與 Luminet (1979) 不同。原始手稿中有一些符號錯誤。我曾就此聯繫作者，他也親切地回覆：

>「[…] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!」
>
>「當年我還沒有仔細校對校樣的習慣。幸運的是，我的計算使用了正確的公式，不然圖像就不會正確了！」

僅供參考。我已盡力註明本程式碼與論文不同之處。

兩個座標系的角度之間關係很簡單，但兩個參考系半徑之間的關係則由龐大的方程 13 給出：

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

這裡 $F$ 是第一類不完全雅可比橢圓積分，$k$ 和 $Q$ 是近地點 $P$ 的函數，$\zeta$ 是 $P$ 的三角函數，而 $\gamma$ 滿足：

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

在曲率時空中，通常有多條來自同一座標並投影到觀測者座標系的光子軌道（例如見引力透鏡和愛因斯坦十字）。繞過黑洞並到達觀測者座標系的光子軌道稱為“高階”影像或“幽靈”影像。在這種情況下，$\gamma$ 滿足：

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

這些幽靈光子就是你在上圖下半部看到的，以及薄薄包裹在光子球周圍、幾乎看不見的光暈。對於較不傾斜（非邊緣對視）的情況，這種幽靈影像則不那麼明顯。

本倉庫使用 `scipy.optimize.brentq` 來求解這些方程式，並針對 Luminet (1979) 中提出的概念提供便利的 API。`BlackHole` 類是最直接的，但例如 `Isoradial` 類也很有教育意義：在觀測者座標系中描述從黑洞座標系同一半徑發射的光子軌跡。`Isoredshift` 類則提供觀測者座標系中的等紅移線。

## 📕 參考文獻
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---