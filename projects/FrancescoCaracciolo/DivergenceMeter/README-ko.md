
# 다이버전스미터
실제 세계 뉴스를 분석하여 Steins;Gate 용어로 현재 세계의 다이버전스 값을 추정하려고 합니다.
<div id="divergence-meter" style="cursor: pointer;">
  <img alt="Digit 0" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 1" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="Digit 2" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 3" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="Digit 4" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 5" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="Digit 6" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 7" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
</div>

- [웹사이트](https://divergence.nyarchlinux.moe)
- [API 문서](https://divergence.nyarchlinux.moe/docs.html)
- [기능](#features)
- [스크린샷](#screenshots)
- [세계선 계산](#worldline-calculation)
- [파이썬 예제](https://github.com/FrancescoCaracciolo/DivergenceMeter/blob/main/src/client/client.py)
- [크레딧](#credits)

## 기능

- <img alt="Digit 0" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="5px" /> <img alt="Digit 0" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="5px" /> 웹사이트는 <a href="https://divergence.nyarchlinux.moe">https://divergence.nyarchlinux.moe</a> 에서 방문할 수 있습니다. 
- 🔄 **자동 업데이트**: 카운터가 15분마다 자동으로 갱신됩니다
- 🗞 **뉴스 테이블**: 세계 뉴스가 타임라인에 어떻게 영향을 미치는지 확인할 수 있습니다
- 📊 **그래프**: 시간에 따른 세계선 추정을 표시합니다
- 🔉 **사운드**: 세계선 추정치가 변경될 때 VN에서 사운드가 재생됩니다
- 🪶 **라이트 모드**: <a href="https://divergence.nyarchlinux.moe/lite.html">라이트 모드가 제공됩니다</a>, 리소스를 많이 소모하는 그래프를 표시하지 않습니다
- 🛠 **무료 및 공개 API**: 우리 측정값을 프로젝트에 통합하세요. 맞춤 위젯, 실제 세계 다이버전스 미터, 앱 등 다양한 용도로 활용할 수 있습니다!  
다이버전스 카운터는 15분마다 자동으로 새로고침됩니다. <a href="https://divergence.nyarchlinux.moe/docs.html">API 문서</a>
- ⏳ **분석 간격**: 15분마다 현재 세계 뉴스를 분석하여 현재 세계선 다이버전스를 추정합니다

## 스크린샷
**다이버전스 미터**
![image](https://github.com/user-attachments/assets/4dfacc07-6d5e-4e66-9450-ada057e17725)

**세계선 상태 보고서**
![image](https://github.com/user-attachments/assets/2ee7c178-d182-4075-a9be-5e298bf83dbb)

**다이버전스 그래프**
![image](https://github.com/user-attachments/assets/abe100b6-4d88-46de-838a-f2a8227be1aa)

## 세계선 계산
Steins;Gate에서 다이버전스는 세계선 간 중력 값의 차이를 사용하여 계산됩니다.
나는 리딩 슈타이너가 없고(적어도 내가 아는 한), 아직 어떤 세계선에도 여행하지 않았기 때문에, 세계선은 
세계 뉴스를 사용하여 **추정**됩니다. 뉴스는 세계 뉴스, 과학 뉴스, 지역 뉴스를 포함하는 여러 RSS 피드에서 가져옵니다.

**스포일러 경고**: 다음에 볼 방정식은 Chaos;Head에 나온 일부 방정식을 해석한 것입니다. 방정식 자체는 스포일러가 아니지만, 검색 시 Chaos;Head 비주얼 노벨에 대한 스포일러가 있을 수 있습니다. 또한, 이 개념들 중 일부는 Steins;Gate VN에 대한 가벼운 스포일러일 수 있습니다.

**참고**: 여기 있는 일부 이론은 SciAdv 시리즈와 일관되도록 만들어진 것입니다.

#### 기본 이론
**가정**: 모든 사건 $e$는 독립적인 다이버전스 $d$를 가집니다. 이것은 사건 $e$가 가장 강한 어트랙터를 가지는 세계선입니다. 사소한 사건은 적절한 어트랙터 필드를 가지지 않지만, 다른 세계선에 영향을 미칩니다.
예를 들어, Steins;Gate에서 Sern 디스토피아는 독립적인 다이버전스가 0입니다. 세계선이 0에 가까울수록 더 빨리 그 결과에 도달합니다.

#### 뉴스 분석
각 뉴스는 사건 $e$가 발생했음을 문서화합니다. (뉴스가 발행된 사실 자체도 사건 $e$로 간주될 수 있습니다.)
각 뉴스는 가장 가능성 높은 어트랙터 필드(예: $\alpha$, $\beta$ ...)에 따라 분류됩니다. 또한, 각 뉴스에는 그 어트랙터 필드에 미치는 영향력 $Im$과, 어트랙터 필드 중심과의 근접도를 나타내는 필드 인력 $Fa$가 부여됩니다.

#### 독립 다이버전스 계산
1. 사건 $e$의 독립 다이버전스를 계산하기 위해 $Ir2$ 방정식에서 시작합니다:

$$Ir2 = fun^{10}*int^{40}$$

Chaos;Head에서, 이것은 세계가 분기하는 기본 방정식입니다.
VN에서는 이 방정식의 의미가 설명되지 않았습니다(단, Ir2가 "눈이 두 개"를 의미한다는 점만).
Dirac Sea와 관련 있다고 가정하면 가능한 설명은 다음과 같습니다:
- $Ir$는 진공 영역의 정보율(Information Rate)입니다. 정보율이 높을수록 더 복잡하고 역동적인 진공 구조를 의미합니다.
- $fun$은 필드 균일성 수(Field Uniformity Number)입니다. 덜 균일한 필드는 더 많은 그래디언트, 퍼텐셜, 즉 입자 생성과 상호작용을 위한 더 많은 에너지를 의미할 수 있습니다.
- $int$는 Dirac Sea 상태들의 상호연결성(Interconnectedness)입니다. 이는 Dirac Sea 내 음의 에너지 상태들이 얼마나 연결되어 있는지를 나타냅니다.

우리는 다이버전스 $d$가 진공의 정보 상태 변화의 결과라고 가정할 수 있으며, 중력도 영향을 받습니다.
따라서 $d \propto Ir$라고 가정할 수 있습니다. 어떤 상수 $k_1$가 존재하여:

$$d = k_1 * Ir2$$

2. $Ir2$의 주어진 식을 $d$의 정의에 대입합니다:

  $$d = k_1 \cdot (fun^{10} * int^{40})$$

3. 이제 다음 관계를 가정합니다:
    *   **영향력 (`Im`)과 균일성 (`fun`)**: 영향력이 큰 뉴스 이벤트 ($Im$)는 지역 진공 필드를 교란하여 균일성 ($fun$)을 감소시킵니다. 이것을 역비례 관계로 모델링할 수 있습니다:

        $$fun = \frac{C_f}{Im}$$

        여기서 $C_f$는 상수입니다.
    *   **필드 인력 ($Fa$)과 상호연결성 ($int$)**: 강한 인력 ($Fa$)은 사건 $e$가 Dirac Sea 상태 내에서 효율적인 경로를 생성하여 지역 상호연결성 ($int$)을 증가시킴을 의미합니다. 이것을 정비례 관계로 모델링합니다:

        $$int = C_i \cdot Fa$$

        여기서 $C_i$는 상수입니다.

4. 위의 공식을 식에 대입합니다.
    3단계에서 구한 $fun$과 $int$의 식을 2단계의 $d$ 식에 대입합니다:
   
    $$d = k_1 \cdot \left( \left( \frac{C_f}{Im} \right)^{10} \cdot (C_i \cdot Fa)^{40} \right)$$

5. 마지막으로 상수들을 결합하여 식을 단순화합니다:

    $$d = k_1 \cdot \left( \frac{C_f^{10}}{Im^{10}} \cdot C_i^{40} \cdot Fa^{40} \right)$$
    $$d = (k_1 \cdot C_f^{10} \cdot C_i^{40}) \cdot \frac{Fa^{40}}{Im^{10}}$$

6. 우리는 발산 상수 $K_d = k_1 \cdot C_f^{10} \cdot C_i^{40}$ 라는 새로운 상수를 생성합니다.
    독립 발산 $d$를 계산하는 최종 공식은 다음과 같습니다:
   
    $$d = K_d \frac{Fa^{40}}{Im^{10}}$$

#### 세계선 업데이트
현재 세계선을 추정하기 위해서는 뉴스가 도착하는 즉시 이를 분석하고, 해당 뉴스의 독립 발산을 기반으로 현재 발산을 업데이트해야 합니다.
이를 위해 가중치 온라인 경사 하강법(Weighted Online Gradient Descent)의 수정된 버전이 사용됩니다.

$$d(t) = d(t-1) - Im * \eta \nabla L(d(t-1))$$

## 출처
- 발산에 관한 정보는 [Steins;Gate Wiki](https://steins-gate.fandom.com/wiki/Steins;Gate_Wiki) 참조
- 이미지 및 GIF는 [LuqueDaniel/Divergence-Meter](https://github.com/LuqueDaniel/Divergence-Meter/tree/master) 제공
- [SciAdv Series](https://wikipedia.org/wiki/Science_Adventure) 에서 영감을 받음

프로젝트를 지원하고 싶다면 ⭐️를 남겨주세요

<a href="https://nyarchlinux.moe">Nyarch Linux</a> 수석 개발자가 ❤️를 담아 제작했습니다



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---