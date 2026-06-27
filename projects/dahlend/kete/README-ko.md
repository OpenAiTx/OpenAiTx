<p align="center">
<img src="https://github.com/dahlend/kete/blob/main/docs/_static/kete.svg" style="width:20%">
</p> 

# *케테 (Kete)*

소행성과 혜성의 궤도를 대규모로 예측합니다.

[arXiv 논문](http://arxiv.org/abs/2509.04666)을 참조하세요.

![Github Actions](https://github.com/dahlend/kete/actions/workflows/test-lint.yml/badge.svg?branch=main)
[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.15259732.svg)](https://doi.org/10.5281/zenodo.15259732)
[![arXiv](https://img.shields.io/badge/arXiv-2509.04666-00ff00.svg)](http://arxiv.org/abs/2509.04666)

케테 도구는 소행성 전천 탐사의 시뮬레이션을 가능하게 하기 위해 설계되었습니다.  
여기에는 다체 물리 궤도 역학, 궤도 결정 및 적합, 물체의 열 및 광학 모델링,  
시야 및 광 지연 보정이 포함됩니다. 이러한 도구들은 소행성 센터(MPC)와 JPL의  
알려진 소행성 데이터베이스와 함께 사용되어 탐사를 계획할 뿐만 아니라  
기존 또는 과거 탐사에서 어떤 물체가 관측 가능한지도 예측할 수 있습니다.

케테의 주요 목표는 특정 물체에 대한 쿼리를 수행하지 않고도  
전체 MPC 카탈로그를 한 번에 처리할 수 있는 도구 세트를 제공하는 것입니다.  
이 도구는 1천만 개의 주 소행성과 근지구 소행성을 사용해  
NEO 서베이어 임무의 10년 이상의 탐사 시간을 시뮬레이션하는 데 활용되었습니다.

[문서](https://dahlend.github.io/kete/)  
   - [예제](https://dahlend.github.io/kete/auto_examples/index.html)
   - [튜토리얼](https://dahlend.github.io/kete/tutorials/index.html)


https://github.com/user-attachments/assets/a48491d8-9c15-4659-9022-1767a3aa1e94

다음은 2023년 전체 동안 ZTF 탐사가 관측했을 시뮬레이션입니다.  
이는 모든 번호가 매겨진 소행성의 모든 위치와 예상 V-밴드 등급 계산을 포함합니다.  
예상 등급이 해당 프레임에 대해 ZTF가 보고한 등급 한계보다 밝으면,  
해당 물체는 연한 회색으로 깜박입니다.

이 계산은 데스크톱 컴퓨터에서 약 50분이 걸렸고,  
영상을 생성하는 데는 약 40분이 소요되었습니다.

Kete는 예를 들어 [주어진 이미지](https://dahlend.github.io/kete/tutorials/kona.html) 내에 알려진 모든 소행성을 식별하는 등 많은 질문에 답하는 데 사용할 수 있습니다.

Kete는 또한 다음과 같은 더 재미있는 시각화의 백엔드로 사용할 수 있습니다:  

[Ketev](https://dahlend.github.io/ketev/) - 브라우저에서 태양계 시각화 도구


## 설치

Kete는 pip를 사용하여 설치할 수 있습니다:



``` bash
pip install kete
```
## 코드 예제

다음은 kete로 프로그래밍하는 모습을 보여주는 작은 예제입니다.  
이 코드는 2029년 4월에 지구에 *매우* 가까이 접근하는 소행성 아포피스의 가장 가까운 거리를 계산합니다.

이 예제에 대한 더 자세한 설명은  
[여기](https://dahlend.github.io/kete/auto_examples/plot_close_approach.html)에서 확인할 수 있습니다.



```python

      import kete
      import numpy as np

      # Date of impact +- 1 day in Julian Date
      jd_center = kete.Time.from_ymd(2029, 4, 13.9066).jd

      # Step the orbit every 1 minute for +- 1 day.
      step_size = 1 / 24 / 60
      jd_range = np.arange(-1, 1, step_size) + jd_center

      # load Apophis from JPL Horizons
      obj = kete.HorizonsProperties.fetch("Apophis")
      cur_state = obj.state

      # keep track the the closest approach
      closest_approach = [np.inf, 0]
      for jd in jd_range:
            # propagate the object, and include the massive main belt asteroids
            cur_state = kete.propagate_n_body(cur_state, jd, include_asteroids=True)

            # calculate position relative to earth
            earth_vec = cur_state.pos - kete.spice.get_state("Earth", cur_state.jd).pos
            earth_dist = earth_vec.r * kete.constants.AU_KM
            if earth_dist < closest_approach[0]:
                  closest_approach = [earth_dist, cur_state.jd]

      print("Closest approach is on:")
      print(kete.Time(closest_approach[1]).iso)
      print(f"At a distance of about {closest_approach[0]:0.0f} km")
      #  Closest approach is on:
      #  2029-04-13T21:45:30.239+00:00
      #  At a distance of about 38015 km

```
## 이름

'케테(Kete)'는 고대 그리스 신화에서 유래한 단어로 바다 괴물을 의미하며, 고래류(Cetaceans)의 어원이 됩니다.

## 라이선스:

이 코드의 원본 버전은 원저자 다르 달렌(Dar Dahlen)이 캘텍 IPAC에서 근무할 때 개발되었습니다. 이 저장소는 개인 프로젝트로 계속 작업하기 위한 원본 저장소의 포크입니다. 이 포크와 이전 코드 간의 차이는 BSD 3-조항 라이선스가 적용되며, 저작권은 다르 달렌 및 미래의 협력자에게 있습니다.

### 단위 및 기준 좌표계

케테는 기본 좌표계로 ICRF 참조 좌표계를 사용하며, 단위는 AU, 시간은 바리센트릭 역학 시간(TDB) 스케일링이 적용된 JD로 사용합니다. 내부적으로 이 좌표계는 JPL Horizons에서 사용하는 경사각 정의에 따라 정의된 J2000 프레임의 IAU76/80 모델을 따른 황도 좌표계로 변환됩니다.

      - https://en.wikipedia.org/wiki/Axial_tilt#Short_term
      - https://ssd.jpl.nasa.gov/horizons/manual.html#defs

JPL Horizons와 소행성센터(MPC) 모두 이 좌표계를 사용하며, 본질적으로 J2000 황도 좌표와 동일합니다. 케테에는 적도 좌표계 및 다양한 시간 체계로 변환할 수 있는 도구가 제공됩니다.

### 캐시 디렉토리

케테에서 여러 작업은 다양한 파일을 다운로드하는 결과를 낳습니다. 이 파일들은 자동으로 캐시되며, 캐시 저장 디렉토리는 환경 변수 `KETE_CACHE_DIR`을 설정하여 지정할 수 있습니다. 기본 디렉토리는 `~/.kete/`입니다.













``` bash
export KETE_CACHE_DIR="~/.kete/"
```
### 컨테이너 사용 - Docker/Podman

kete가 처음 사용할 때 여러 개의 큰 SPICE 커널 파일을 다운로드하며,
이는 캐시 디렉터리에 저장된다는 점을 유의하세요.

**Docker/Podman 사용 시 중요:**
- 다운로드를 **Docker 빌드 중에 트리거할 경우** (예:
  `RUN python -c "import kete"`), 파일들이 이미지에 포함됩니다.
- 이 단계를 건너뛰면, 첫 컨테이너 실행 시 파일이 다운로드되지만
  **컨테이너가 중지되면 파일이 사라집니다** 캐시 디렉터리에 대한 볼륨 마운트를 사용하지 않는 한.

**권장 Dockerfile 접근법:**


```dockerfile
RUN pip install kete && \
    python -c "import kete"  # Triggers kernel downloads during build
```
이것은 SPICE 커널이 이미지의 일부가 되어 다시 다운로드할 필요가 없도록 합니다.

# 개발자 정보:

아래 정보는 개발자를 위한 것이며, 최종 사용자에게는 필요하지 않습니다.

## 소스에서 설치

kete를 소스에서 빌드하는 경우, Rust 컴파일러가 설치되어 있어야 합니다. 설치
지침은 다음에서 확인할 수 있습니다:

https://www.rust-lang.org/learn/get-started

Python이 최신 버전인지 확인하세요. 이 코드는 Python 3.9 이상에서 실행됩니다.

``` bash
python --version
```

pip가 최신 버전인지 확인하세요. 최소 `22.0.0` 버전이어야 합니다.
``` bash
pip --version
```

이것은 다음을 사용하여 업데이트할 수 있습니다:
``` bash
python -m pip install "pip>=22.0.0" --upgrade
pip install setuptools --upgrade
```

### 개발

개발을 계획하고 있다면, 다음과 같이 설치하는 것을 권장합니다:
``` bash
pip install '.[dev]'
```
그 줄에 있는 `[dev]`는 개발에 유용한 여러 선택적 의존성을 pip로 설치합니다.  
pytest와 문서화 도구들이 포함되어 있습니다.  

### 문서 빌드  

문서가 빌드되기 위해서는 추가적인 Python 라이브러리가 필요합니다.  
다음 명령어로 설치할 수 있습니다:
``` bash
pip install sphinx sphinx_gallery autodoc
```
설치가 완료되면, kete 디렉토리 내에서 실행하여 문서를 빌드할 수 있습니다.

``` bash
(cd docs && make html && open html/index.html&)
```
실행이 완료되면 HTML 문서에 접근하기 위해 `kete/docs/html/index.html` 파일을 엽니다.

이전 문서 빌드를 정리하려면:

``` bash
(cd docs && make clean)
```

문서 테스트는 다음 명령어로 실행할 수 있습니다:
``` bash
(cd docs && make doctest)
```

### 테스트 실행

테스트를 실행하려면 `pytest` 및 `pytest-cov` 패키지가 설치되어 있어야 합니다.

이 폴더의 기본 위치에서 터미널을 열고 다음 명령어를 실행하세요:
``` bash
pytest --cov-report term-missing --cov=kete   
```

다른 커버리지 보고서 유형은 HTML로, 이 명령이 실행된 디렉터리에 `htmlcov`라는 폴더를 생성한 후,
`htmlcov/index.html` 파일을 열 수 있습니다. 이것은 코드 커버리지의 사용자 친화적인 웹사이트 표현입니다.

``` bash
pytest --cov-report html --cov=kete   
```

### 튜토리얼 실행하기

튜토리얼은 계산 비용이 많이 드는 예제로서 일반적인
예상 사용 사례를 더 잘 나타냅니다. 이 예제들은 실행 비용이 매우 크기 때문에,
수동으로 실행하지 않는 한 실행되지 않습니다. 이를 위해 편리한 파이썬 스크립트가 제공되었습니다.

``` bash
cd docs
python utils.py
```
### 벤치마크 실행하기

kete의 러스트 백엔드에는 마이크로 벤치마크 테스트 스위트가 있습니다.  
이들은 `gnuplot`이 설치되어 있어야 하며, 다음 명령어를 사용하여 실행할 수 있습니다:  


``` bash
cargo bench
open target/criterion/report/index.html
```

또한, Flamegraphs는 다음을 사용하여 생성할 수 있습니다:

``` bash
cargo bench --bench propagation -- --profile-time=5
cargo bench --bench spice -- --profile-time=5
cargo bench --bench thermal -- --profile-time=5
```
이 플레임그래프는 `target/criterion/*/profile/flamegraph.svg`에 저장됩니다.  
이 파일들을 웹 브라우저에서 열면 벤치마크 중에 어떤 함수들이 사용되고 있는지 볼 수 있습니다.  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-27

---