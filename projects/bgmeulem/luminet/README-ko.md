<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Luminet(1979)에 기술된 방법을 기반으로 슈바르츠실트 블랙홀을 시뮬레이션하고 시각화합니다.

![블랙홀의 예시 플롯](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ 설치
`luminet`은 PyPI에서 사용할 수 있습니다:

```shell
pip install luminet
```

## 📖 [문서](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 사용법

이 저장소의 모든 변수는 자연 단위계($G=c=1$)로 표시됩니다.

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
이미지를 만들려면:
```python
ax = bh.plot()          # Create image like above
```

축적 원반에서 광자를 샘플링하려면:
```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
샘플링은 블랙홀 중심을 향해 편향되어 있다는 점에 유의하십시오. 이는 대부분의 광도가 이곳에서 발생하기 때문입니다.

## 📝 배경
슈바르츠실트 블랙홀은 $6M$의 가장 안쪽 안정 궤도와 $3M$의 광자 구를 가지고 있습니다. 이는 블랙홀을 공전하는 강착 원반이 $r>6M$의 반지름에서 광자를 방출함을 의미합니다. 곡률 공간에서 광자의 근지점이 $3M$ (즉, 광자 구)보다 크면, 광자는 블랙홀에 포획되지 않고 어떤 관측자 프레임 $(b, \alpha)$에서 볼 수 있습니다. 시공간 곡률은 블랙홀 프레임 $(r, \alpha)$과 관측자 프레임 $(b, \alpha)$ 사이의 렌즈 효과로 가장 쉽게 해석됩니다. 전자는 강착 원반 영역을 아우르는 2차원 극좌표이고, 후자는 관측자 프레임의 "사진판"을 아우르는 2차원 극좌표입니다. 후자를 실제 CCD 카메라라고 생각하면 됩니다. 광자 궤도 근지점과 관측자 프레임 반지름 $b$는 직접적으로 연관되어 있습니다:

$$b^2 = \frac{P^3}{P-2M}$$

이로 인해 많은 방정식이 훨씬 더 간단해집니다. 
이 식의 좌변에 제곱이 있는 것이 Luminet (1979)와 다르다는 점을 알 수 있습니다. 원래 논문에는 몇몇 표기 오류가 있습니다. 이에 대해 저자에게 문의했으며, 친절하게 다음과 같이 답변해 주셨습니다:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"그 당시에는 교정을 꼼꼼히 확인하는 습관이 없었습니다. 다행히 계산은 올바른 공식으로 했기 때문에, 그렇지 않았다면 이미지는 맞지 않았을 것입니다!".

참고로, 이 코드가 논문과 다른 부분이 있으면 신경 써서 기록하려고 했습니다.

두 좌표계의 각도 사이의 관계는 자명하지만, 두 기준 프레임의 반지름 사이의 관계는 복잡한 13번 식으로 주어집니다:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

여기서 $F$는 첫 번째 종류의 불완전 자코비 타원적분이고, $k$와 $Q$는 근지점 $P$의 함수, $\zeta$는 $P$의 삼각함수, $\gamma$는 다음을 만족합니다:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

곡률 시공간에서는 동일한 좌표에서 시작하여 관측자 프레임으로 투영되는 여러 광자 궤도가 보통 존재합니다(예: 중력렌즈 효과 및 아인슈타인 십자가 참고). 블랙홀을 한 바퀴 돌아 관측자 프레임에 도달하는 광자 궤도는 "고차" 상 또는 "유령" 상이라고 부릅니다. 이 경우 $\gamma$는 다음을 만족합니다:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

이 유령 광자는 위의 그림 하단에서 볼 수 있으며, 광자 구를 얇게 감싸는 희미한 빛의 후광에서도 볼 수 있습니다. 가장자리에 가깝지 않은 경사에서는 이 유령 상이 덜 뚜렷하게 나타납니다.

이 저장소는 `scipy.optimize.brentq`를 사용해 이러한 방정식을 풀고, Luminet (1979)에서 제시된 개념에 편리한 API를 제공합니다. `BlackHole` 클래스가 가장 대표적이며, 예를 들어 `Isoradial` 클래스와 같이 블랙홀 프레임에서 같은 반지름에서 방출된 광자가 관측자 프레임에서 그리는 선을 실험해 보는 것도 교육적입니다. `Isoredshift` 클래스는 관측자 프레임에서 동일 적색편이 선을 제공합니다.

## 📕 참고 문헌
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---