<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Luminet(1979)에 기술된 방법을 기반으로 한 슈바르츠실트 블랙홀 시뮬레이션 및 시각화.

![Example plot of a black hole](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ 설치
`luminet`은 PyPI에서 사용할 수 있습니다:

```shell
pip install luminet
```
## 📖 [문서](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 사용법

이 저장소의 모든 변수는 자연 단위계입니다: $G=c=1$


```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
이미지를 생성하려면:
```python
ax = bh.plot()          # Create image like above
```

강착 원반에서 광자를 샘플링하려면:
```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
샘플링은 대부분의 광도가 발생하는 블랙홀 중심 쪽으로 편향되어 있음을 유의하세요.


## 📝 배경
슈바르츠실트 블랙홀은 가장 안쪽 안정 궤도가 $6M$이고, 광자 구면이 $3M$에 있습니다. 이는 블랙홀을 도는 강착 원반이 반지름 $r>6M$에서 광자를 방출한다는 것을 의미합니다. 휘어진 공간에서 광자의 근지점이 $3M$(광자 구면)보다 크면, 광자는 블랙홀에 포획되지 않고 이론적으로 어떤 관찰자 좌표계 $(b, \alpha)$에서 볼 수 있습니다. 시공간 곡률은 블랙홀 좌표계 $(r, \alpha)$와 관찰자 좌표계 $(b, \alpha)$ 사이의 렌즈 효과로 가장 쉽게 해석할 수 있습니다. 전자는 강착 원반 영역을 덮는 2차원 극좌표이고, 후자는 관찰자 좌표계의 "사진판"을 덮는 2차원 극좌표입니다. 후자를 문자 그대로 CCD 카메라로 생각하세요. 광자 궤도 근지점과 관찰자 좌표계 반지름 $b$는 다음과 같이 직접적으로 관련됩니다:

$$b^2 = \frac{P^3}{P-2M}$$

이는 많은 방정식을 훨씬 간단하게 만듭니다. 
왼쪽에 제곱이 있는 이 방정식이 Luminet (1979)과 대조적임을 알 수 있을 것입니다. 원 논문에는 약간의 표기 오류가 있습니다. 필자는 이에 대해 저자에게 연락했고, 저자는 다음과 같이 친절히 응답했습니다:

> "[...] 당시에는 교정을 아주 꼼꼼히 재검토하는 경험이 없었어요. 하지만 다행히도 계산은 올바른 공식으로 했기에 시각적 결과는 정확했답니다!"
>
>"Back in the day, I did not have the habit of carefully double-checking my proofs. Luckily, I did calculate the results with the correct formulas, otherwise the image wouldn't be right!".

참고하시길 바랍니다. 본 코드는 논문과 다른 부분을 주의 깊게 기록하려 노력했습니다.

두 좌표계 각도의 관계는 자명하지만, 두 기준계의 반지름 관계는 엄청난 식 13으로 주어집니다:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

여기서 $F$는 첫 번째 종류의 불완전 야코비 타원 적분이고, $k$와 $Q$는 근지점 $P$의 함수이며, $\zeta$는 $P$의 삼각함수이고, $\gamma$는 다음을 만족합니다:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

휘어진 시공간에서는 보통 같은 좌표에서 출발해 관찰자 좌표계로 투영되는 광자 궤도가 여러 개 있습니다(예: 중력 렌즈 효과와 아인슈타인 십자형 참조). 블랙홀 주변을 휘어 돌며 관찰자 좌표계에 도달하는 광자 궤도를 "고차" 영상 또는 "유령" 영상이라 합니다. 이 경우, $\gamma$는 다음을 만족합니다:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

이 유령 광자는 위 이미지 하단과 광자 구면을 얇게 둘러싼 거의 보이지 않는 빛의 후광에서 볼 수 있습니다. 경사각이 덜 가장자리 쪽일수록 이 유령 영상은 덜 뚜렷합니다.

이 저장소는 `scipy.optimize.brentq`를 사용해 이 방정식들을 풉니다. Luminet (1979)에서 제시된 개념을 편리하게 사용할 수 있는 API도 제공합니다. `BlackHole` 클래스가 가장 명확하지만, 예를 들어 `Isoradial` 클래스로 놀면서 배우는 것도 좋습니다: 블랙홀 좌표계에서 같은 반지름에서 방출된 광자를 관찰자 좌표계에서 나타내는 선입니다. `Isoredshift` 클래스는 관찰자 좌표계에서 동일 적색편이 선을 제공합니다.

## 📕 참고문헌
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---