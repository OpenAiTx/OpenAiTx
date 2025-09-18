[![PyPI version](https://badge.fury.io/py/rsmf.svg)](https://pypi.org/project/rsmf/)
[![Documentation Status](https://readthedocs.org/projects/rsmf/badge/?version=latest)](https://rsmf.readthedocs.io/en/latest/?badge=latest)
[![rsmf](https://circleci.com/gh/johannesjmeyer/rsmf.svg?style=shield)](https://github.com/johannesjmeyer/rsmf)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)


# rsmf (내 그림 크기 자동 조절)

논문을 쓸 때 저는 그림에 대해 조금 까다로운 편입니다. 특히 글꼴과 글꼴 크기가 주변 문서와 일치하는 것이 매우 중요합니다. 보통 matplotlib로 플롯을 그리기 때문에 이를 돕기 위해 이 라이브러리를 만들었습니다. 이 라이브러리는 matplotlib에서 그림 크기와 글꼴 크기를 일반적으로 사용되는 과학 저널에 맞게 자동으로 조정하는 기능을 제공합니다. 현재 `quantumarticle`과 `revtex4`를 지원합니다.

# 설치

PyPI에서 최신 릴리스 버전을 받을 수 있습니다.

```bash
pip install rsmf
```
최신 개발 버전을 받으려면 GitHub에서 패키지를 설치해야 합니다.
```bash
pip install git+https://www.github.com/johannesjmeyer/rsmf
```

이 패키지는 matplotlib의 PGF 백엔드에 의존합니다. 이를 사용하려면 `pdflatex`가 설치된 작동하는 TeX 배포판이 필요합니다 (자세한 내용은 [이슈 #2](https://github.com/johannesjmeyer/rsmf/issues/2)를 참조하세요).

# 사용법

자세한 사용법은 [문서](https://rsmf.readthedocs.io/en/latest/source/howto.html)에 나와 있습니다.

## 설정
`rsmf.setup`을 호출하여 문서 설정 방법을 rsmf에 알려야 합니다. 이는 두 가지 방법으로 할 수 있습니다. 첫째, 문서 설정에 사용된 `\documentclass` 문자열을 rsmf에 전달하는 방법입니다.
```python
import rsmf
formatter = rsmf.setup(r"\documentclass[a4paper,12pt,noarxiv]{quantumarticle}")
```
문자열 앞의 `r`은 `\d`가 이스케이프 시퀀스로 오인되지 않도록 하기 위해 필요합니다. 문서를 로컬에 저장한 경우, 더 편리한 방법이 있습니다:  
메인 tex 파일(문서 설정이 포함된 파일)의 경로를 rsmf에 제공하기만 하면, rsmf가 이를 자동으로 찾아냅니다:
```python
formatter = rsmf.setup("example.tex")
```
이것이 특히 멋진 점은 rsmf가 기본 문서 클래스가 변경될 때마다 파이썬 코드를 변경할 필요 없이 자동으로 플롯을 조정한다는 것입니다! 이는 저널 교체를 훨씬 쉽게 만듭니다.

대상 문서 클래스가 `rsmf`에서 지원되지 않는 경우에도 여전히 사용할 수 있습니다. 이 경우 관련 측정을 직접 추출하고 `rsmf.CustomFormatter`를 사용해야 합니다. 자세한 설명은 [문서](https://rsmf.readthedocs.io/en/latest/source/howto.html)에 나와 있습니다.

## 그림
설정 루틴은 포매터를 반환합니다. 이 포매터는 `formatter.figure` 메서드를 호출하여 matplotlib 그림 객체를 생성하는 데 사용할 수 있습니다. 세 가지 인수가 있습니다:

* `aspect_ratio` (float, 선택 사항): 플롯의 종횡비(높이/너비)입니다. 기본값은 황금비의 역수입니다.
* `width_ratio` (float, 선택 사항): `\columnwidth`의 배수로 플롯 너비입니다. 기본값은 1.0입니다.
* `wide` (bool, 선택 사항): 그림이 두 단 모드에서 두 단을 차지하는지 나타냅니다, 즉 figure* 환경을 사용하는 경우이며, 단일 단 모드에서는 효과가 없습니다. 기본값은 False입니다.

플롯의 너비는 여기서 설정합니다, _LaTeX 문서에서가 아닙니다._ 결과 그림을 다른 너비로 포함하면 글꼴 크기가 주변 문서와 일치하지 않습니다!

예를 들어, 일반 그림은 다음과 같이 생성됩니다

```python
fig = formatter.figure(aspect_ratio=.5)

# ... some plotting ...
plt.savefig("example.pdf")
```
및 포함됨 통해
```tex
\begin{figure}
	\centering
	\includegraphics{example}
	\caption{...}
\end{figure}
```
반면에 페이지의 80%를 차지하는 넓은 그림은 다음과 같이 생성됩니다.
```python
fig = formatter.figure(width_ratio=.8, wide=True)

# ... some plotting ...
plt.savefig("example_wide.pdf")
```
그리고 다중 열 `figure*` 환경을 통해 포함됩니다:
```tex
\begin{figure*}
	\centering
	\includegraphics{example_wide}
	\caption{...}
\end{figure*}
```

도형은 항상 `pdf`와 같은 벡터화된 형식으로 저장하는 것이 좋으며, 저장 전에 `plt.tight_layout()`를 호출하면 플롯이 더 보기 좋게 만들어집니다.

또한, ``aspect_ratio`` 매개변수는 플롯의 높이를 너비로 나눈 값으로 정의된다는 점에 유의하세요. 종종 가로/세로 비율로 정의되지만, 이 선택은 도형의 너비와 높이를 각각 ``width_ratio``와 ``aspect_ratio``에 비례하게 만듭니다.

또한, `formatter.columnwidth`와 `formatter.wide_columnwidth`를 사용하여 수동으로 도형 객체를 생성할 수도 있으며, `formatter.figure` 루틴은 이를 편리하게 감싸는 래퍼입니다.

## 기타 기능
기본 폰트 크기는 `formatter.fontsizes`를 통해 접근할 수 있습니다. 명명법은 LaTeX과 동일하여 예를 들어 `formatter.fontsizes.tiny` 또는 `formatter.fontsizes.Large`가 있습니다.
이 기능은 제목, 범례, 주석 등을 조정하면서도 일치하는 폰트 크기를 유지하는 데 특히 유용합니다.

## rsmf를 다른 프레임워크와 함께 사용하기
rsmf는 `seaborn`과 같은 좋아하는 플로팅 프레임워크와 함께 사용할 수 있습니다. 단 한 가지 주의할 점은 matplotlib 스타일이나 seaborn 스타일을 사용하면 특히 폰트 크기와 관련하여 rsmf가 설정한 값이 덮어씌워질 수 있다는 것입니다. 이를 위해 formatter에는 기본 폰트 크기만 변경하는 `formatter.set_default_fontsizes` 메서드가 있습니다. 사용 예는 다음과 같습니다.
```python
fig = formatter.figure(wide=True)
sns.set(style="ticks")
formatter.set_default_fontsizes()

# ... some plotting ...
```
때때로 이러한 스타일은 글꼴 패밀리(세리프/산세리프)와 같은 다른 요소도 덮어쓰기도 합니다. 아직 이를 수정하는 방법은 없습니다.

## 예제
플롯을 만드는 노트북과 함께 예제 문서는 `examples` 폴더에서 찾을 수 있습니다.

# 작동 원리
내부적으로 rsmf는 matplotlib 백엔드를 `pgf`로 설정하여 LaTeX 사용을 가능하게 합니다. 지원되는 각 문서 클래스에 대해 특정 열 너비와 글꼴 크기가 코드에 저장되며, 글꼴을 변경하는 패키지도 함께 로드됩니다. 예를 들어 `quantumarticle`의 경우 적절한 산세리프 글꼴을 얻기 위해 `lmodern` 패키지가 `pgf` 백엔드에 로드됩니다.

`rsmf.setup`을 호출하면 matplotlib의 `rcParams`가 조정되어 글꼴 크기가 주변 문서와 일치하도록 합니다. `formatter.figure`는 `rcParams`를 변경하지 않는 점에 유의하세요.

# 기여
좋아하는 문서 클래스에 맞게 플롯을 설정하는 데 문제가 있고 여기서 지원하지 않나요? PR을 주저하지 마세요!

기여해 주신 분들께 큰 감사를 드립니다:
[Samuel J. Palmer](https://github.com/sp94), 
[platipo](https://github.com/platipo), 
[Lorenzo Fioroni](https://github.com/LorenzoFioroni)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-18

---