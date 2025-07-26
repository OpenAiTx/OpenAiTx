<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Luminet (1979) で記述された手法に基づき、シュヴァルツシルトブラックホールのシミュレーションと可視化を行います。

![ブラックホールのプロット例](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ インストール
`luminet` は PyPI から入手できます:

```shell
pip install luminet
```

## 📖 [ドキュメント](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 使い方

このリポジトリ内のすべての変数は自然単位系（$G=c=1$）で表されています。

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
画像を作成するには：
```python
ax = bh.plot()          # Create image like above
```
降着円盤上で光子をサンプリングするには：

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
サンプリングはブラックホールの中心に偏っていることに注意してください。これはほとんどの光度がこの領域から放出されるためです。

## 📝 背景
シュワルツシルトブラックホールには$6M$の最内安定軌道と$3M$の光子球があります。これは、ブラックホールを周回する降着円盤が半径$r>6M$で光子を放出することを意味します。曲がった空間において光子の最近点が$3M$（光子球とも呼ばれる）より大きい限り、光子はブラックホールに捕獲されず、理論的にはいずれかの観測者フレーム$(b, \alpha)$から観測可能です。時空の湾曲はブラックホールフレーム$(r, \alpha)$と観測者フレーム$(b, \alpha)$の間のレンズ効果として最も簡単に解釈できます。前者は降着円盤領域を表す2次元極座標系で、後者は観測者フレームの「写真板」を表す2次元極座標系です。後者を文字通りCCDカメラとして考えてください。光子軌道の最近点と観測者フレームの半径$b$は直接的に関係しています：

$$b^2 = \frac{P^3}{P-2M}$$

この式により多くの方程式が大幅に簡潔になります。
この式の左辺が二乗になっていることに気づくかもしれませんが、これはLuminet (1979)と対照的です。元の論文にはいくつか記法の誤りがあります。私は著者にこれについて連絡を取りましたが、彼は親切に次のように答えてくれました：

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"当時はまだ校正を慎重に見直す習慣がありませんでした。幸いにも計算は正しい式で行っていたので、もしそうでなければ画像は正しくなかったでしょう！"

ご参考までに。このコードが論文と異なる箇所については注意深く記載するよう努めました。

両座標系の角度の関係は自明ですが、2つの参照フレームにおける半径の関係は巨大な式13で与えられます：

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

ここで、$F$は第一種不完全ヤコビ楕円積分、$k$と$Q$は最近点$P$の関数、$\zeta$は$P$の三角関数、$\gamma$は次のように与えられます：

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

湾曲した時空では、同じ座標から発し観測者フレームに投影される複数の光子軌道が存在する場合があります（例えば重力レンズやアインシュタインクロスなど）。ブラックホールの周りを曲がり観測者フレームに到達する光子軌道は「高次画像」または「ゴースト画像」と呼ばれます。この場合、$\gamma$は次の式を満たします：

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

これらのゴースト光子は上記画像の下半分や、光子球を薄く包むほとんど見えない光のハローとして現れます。傾斜がよりエッジオンでない場合、このゴースト画像はあまり顕著ではありません。

このリポジトリはこれらの方程式を解くために`scipy.optimize.brentq`を使用し、Luminet (1979)で提示された概念の便利なAPIを提供します。`BlackHole`クラスが最も明白ですが、例えば`Isoradial`クラス（ブラックホールフレームの同じ半径から放出された光子を観測者フレームで表す線）をいじってみるのも教育的です。`Isoredshift`クラスは観測者フレームにおける等赤方偏移線を提供します。

## 📕 参考文献
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---