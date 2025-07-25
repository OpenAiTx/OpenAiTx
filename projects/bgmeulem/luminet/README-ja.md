<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

シュワルツシルトブラックホールをシミュレートおよび可視化します。Luminet (1979) に記載された手法に基づいています。

![Example plot of a black hole](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ インストール
`luminet` は PyPI から利用可能です：

```shell
pip install luminet
```

## 📖 [ドキュメント](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 使い方

このリポジトリ内のすべての変数は自然単位系で表されています：$G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
画像を作成するには:
```python
ax = bh.plot()          # Create image like above
```

降着円盤上の光子をサンプリングするには：
```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
ブラックホールの中心にサンプリングが偏っていることに注意してください。なぜなら、ほとんどの輝度はここから来ているためです。


## 📝 背景
シュワルツシルトブラックホールは最内安定軌道が $6M$、光子球が $3M$ にあります。これは、
ブラックホールを周回する降着円盤が半径 $r>6M$ で光子を放出することを意味します。曲がった空間内で光子の最接近点が $3M$（光子球とも呼ばれる）より大きい限り、光子はブラックホールに捕獲されず、理論的には観測者フレーム $(b, \alpha)$ から見ることができます。時空の曲率は、ブラックホールフレーム $(r, \alpha)$ と観測者フレーム $(b, \alpha)$ の間のレンズ効果として最も容易に解釈されます。前者は降着円盤領域を覆う2次元極座標であり、後者は観測者フレームの「写真プレート」を覆う2次元極座標です。後者は文字通りCCDカメラのように考えてください。光子の軌道の最接近点と観測者フレームの半径 $b$ は直接関係しています：

$$b^2 = \frac{P^3}{P-2M}$$

これにより多くの方程式が大幅に簡潔になります。
この方程式の左辺に平方があることに気付くかもしれませんが、これはLuminet (1979) と異なります。元の原稿にはいくつか記法の誤りがあり、著者に問い合わせたところ、以下のように親切に回答をいただきました：

> 「[...] 当時は校正を非常に注意深く読み直す経験がまだありませんでした。しかし幸いにも計算は正しい式で行っており、そうでなければ視覚的な結果は正しくなかったでしょう！」
>
>「昔は校正を厳密に二重チェックする習慣がなかったのですが、幸い正しい式で計算していたので、画像は正しかったのです！」

念のため。このコードが論文と異なる点について注意深く記録しようと努めました。

両座標系の角度の関係は自明ですが、2つの基準系における半径の関係は、非常に複雑な式13で与えられます：

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

ここで、$F$ は第一種不完全ヤコビ楕円積分、$k$ と $Q$ は最接近点 $P$ の関数、$\zeta$ は $P$ の三角関数で、$\gamma$ は以下を満たします：

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

曲がった時空では、同じ座標から発し観測者フレームに投影される複数の光子軌道が存在することが多い（例：重力レンズ効果やアインシュタインクロスを参照）。ブラックホールの周りを曲がり観測者フレームに到達する光子軌道は「高次」像または「ゴースト」像と呼ばれます。この場合、$\gamma$ は以下を満たします：

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

これらのゴースト光子は、上記画像の下半分や光子球を薄く包むかすかな光のハローとして見えます。傾斜角がより正面寄りの場合、このゴースト像は目立ちにくくなります。

本リポジトリは `scipy.optimize.brentq` を用いてこれらの方程式を解き、Luminet (1979) で提示された概念への便利なAPIを提供します。`BlackHole` クラスが最も明白ですが、例えば `Isoradial` クラス（ブラックホールフレームで同じ半径から放出された光子を記述する観測者フレームの線）を操作するのも教育的です。`Isoredshift` クラスは観測者フレームにおける等赤方偏移線を提供します。

## 📕 参考文献
[1] Luminet, J.-P., [“薄い降着円盤をもつ球対称ブラックホールの像.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“ブラックホールイメージングの図説史：個人的回想（1972-2002）.”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---