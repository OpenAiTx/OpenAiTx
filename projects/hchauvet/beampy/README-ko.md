# Beampy [![Build Status](https://travis-ci.com/hchauvet/beampy.svg)](https://travis-ci.com/hchauvet/beampy) [![codecov](https://codecov.io/gh/hchauvet/beampy/graph/badge.svg)](https://codecov.io/gh/hchauvet/beampy) ![pypi python version](https://img.shields.io/pypi/pyversions/beampy-slideshow.svg) ![pypi licence](https://img.shields.io/pypi/l/beampy-slideshow.svg) ![pypi download](https://img.shields.io/pypi/dm/beampy-slideshow.svg) ![pypi beampy version](https://img.shields.io/pypi/v/beampy-slideshow.svg)

**마스터 브랜치의 개발은 현재 중단된 상태이며, (긴급 버그 수정만 반영됩니다), 새로운 버전의 beampy는 아직 충분히 안정적이지 않은 dev 브랜치에서 개발 중입니다...**

Beampy는 HTML5로 표시할 수 있는 svg 슬라이드쇼를 생성하는 파이썬 도구입니다  
(Firefox와 Chromium에서 테스트됨)  
슬라이드 크기는 Latex Beamer 문서처럼 고정되어 있습니다.

Beampy 프레젠테이션은 모든 내용을 내장한 하나의 html 파일만 출력합니다.

* [Beampy 문서 보기](https://hchauvet.github.io/beampy/)
* [Beampy 테스트 프레젠테이션 보기](https://rawgit.com/hchauvet/beampy/master/examples/beampy_tests.html) (소스는 *examples/beampy_tests_modules.py*에 있음)

## 설치:

파이썬 패키지 인덱스에서:

```bash
pip install beampy-slideshow
```

[See full installation documentation](https://hchauvet.github.io/beampy/install.html#beampy-install)

## A quick example :

```python
from beampy import *

doc = document()

with slide():
    maketitle('Beampy a tool to make simple presentation', ['H. Chauvet'])

with slide('Beampy test'):
    text(r'\href{#0}{Go to Title}')
    text(r'Use LaTeX to render text and $$\sqrt{10}$$', align='center')

with slide('Beampy test with animated layers'):
    text(r'\href{#0}{Go to Title}')[:]
    text(r'Use LaTeX to render text and $$\sqrt{10}$$', align='center')[1]

save('./simple_one.html')

#To save in pdf just change the above command to the following
#save('./simple_one.pdf')
```

[beampy_presentation.html](https://cdn.rawgit.com/hchauvet/beampy/master/examples/simple_one.html)



## 변경 로그:

### 0.5.5
* 파이썬 2와 3의 인코딩 문제를 중요하게 수정함.
* dvisvgm이 생성한 svg에서 누락된 참조 문제 수정
  (전체 이야기는 [이슈 #18](https://github.com/hchauvet/beampy/issues/18) 참고), 이는
  svg 내 라텍스 일부 누락을 발생시킴.
* 임시 파일 관리 개선
* scour(svg 최적화 도구)를 최신 버전으로 업데이트

### 0.5.4

* Beampy가 이제 파이썬 3와 2를 모두 지원함 (최소 2.7과 3.7) !
* pytest 프레임워크를 이용한 통합 테스트 도입 (아직 core 함수 유닛 테스트는 없음)
* 여러 포맷을 동시에 저장할 때 발생하던 텍스트 중복 버그 수정 [이슈 #13](https://github.com/hchauvet/beampy/issues/13)
* logging.debug 출력 모드 추가
* 프레젠테이션 소스 파일 위치 지정 옵션 추가 ( doc = document(source_filename=__name__) )

### 0.5.3

작은 수정 사항:
* box 레이어 전파 버그 수정
* 마지막 레이어가 [n:]로 설정될 때 버그 수정
* 모듈에서 logging.debug 사용 시작

### 0.5.2

* tikz dvi용 dvisvgm 출력 버그 수정 (latex2svg 함수에 dvisvgm이 생성한 svg를 저장하는 옵션 추가).
* 목차(tableofcontents) 모듈 추가 [문서 참조](https://hchauvet.github.io/beampy/auto_examples/plot_TOC.html).
* BeamerFrankfurt 테마 추가 [문서 참조](https://hchauvet.github.io/beampy/auto_themes/theme_BeamerFrankfurt.html).
* Figure 모듈에서 애니메이션 gif 지원.
* 텍스트 모듈에 "extra_packages" 인자를 통해 추가 라텍스 패키지 삽입 가능.



* 렌더링 속도를 향상시키는 svg 사각형 및 원 크기 계산 (Inkscape 호출 불필요).
* 박스 모듈 개선 (현재 그룹의 서브클래스임) [문서 보기](https://hchauvet.github.io/beampy/auto_examples/plot_box.html).
* convert_unit 함수의 일부 배율 인자 수정.
* 너비와 높이는 이제 Length 객체이며 다음과 같은 복합 연산을 지원합니다:
  


  ```python

  # 50% of the currentwidth 
  a = rectangle(width='50%', height=10)

  # width/height relative to the a element
  b = rectangle(width=a.width/2+'2cm', height=a.height/'10pt')
  ```
* 모듈 위치 (x,y) 작업이 이제 길이 객체(너비/높이)를 허용합니다:


  ```python

  a = rectangle(width='50%', height=10)

  b = rectangle(x=a.width+'2cm', y=a.height+5)
  ```
  
* beampy의 핵심을 변경하여 위치나 길이에 대한 작업이 필요할 때 요소를 렌더링하도록 함 (즉, 요소의 너비나 높이가 알려지지 않은 상태에서 작업을 수행하면, 요소를 렌더링하여 크기를 얻고 작업을 가능하게 함)
* 모듈의 오버레이 순서를 변경하기 위한 "zorder" 연산 추가 (위/아래/마지막/첫번째):





  ```python

  a = rectangle(x='center', y='center', width=50, height=50)
  b = rectangle(x='center', y='center', width=a.height+100,
                height=a.height+100, color='red')

  # Make b appears below a
  b.below(a)
  
  # equivalent to a.above(b) or a.last() or b.first()
  ```
### 0.5.1

* bokeh 도형에서 여러 버그 수정 (감사합니다 [Silmathoron](https://github.com/Silmathoron))
* bokeh 도형 크기 조정 수정, 이제 bokeh의 "sizing_mode = scale_both"를 사용하고 bokeh div의 css 변환 스케일링을 되돌림.
* bokeh용 자바스크립트 로더 수정 (새로운 bokeh 버전(>0.12.6)에서 메인 div를 "bk_root"로 명명함)
* beampy 캐시 클래스에 파일 캐시 기능 추가
* bokeh에서 자바스크립트 외부 라이브러리 파일 캐시 (CDN에서 다운로드, "doc = document(cache=False)"일 경우)


### 0.5.0
* 그룹을 꾸미기 위한 box 함수 추가
* 컨텍스트 매니저를 사용하여 프레젠테이션 내 텍스트 작성하는 새로운 실험적 방법 추가


  ```python
  with text(width=400):
       """
       Any comment inside the context manager will be passed to the
       text function as input argument. This allows clearer source
       when writing long texts.

       No more need to add an *r* before to protect the text passed to
       latex, it's now automatically added.
       """
  ```
  
* 한 슬라이드에 html 객체만 있을 때 발생하는 버그 수정
* 문서 설치 섹션의 작은 오타 수정

### 0.4.9

* [Beampy 문서](https://hchauvet.github.io/beampy/) 초안 작성
* Beampy 모듈에 문서 추가
* 모듈을 배치할 때 바운딩 박스에 따른 앵커를 정의하는 위치 사전에 'anchor' 키 추가
* beampy 모듈을 호출하는 함수를 저장하기 위해 utils.py 추가
* Beampy 모듈 주변에 앵커가 있는 바운딩 박스를 그리는 **bounding_box(module)** 함수 utils.py에 추가. 슬라이드에 축을 그리는 함수 **draw_axes()** 도 추가

### 0.4.8

* 이슈 #12 부분 수정
* 코드 문법 정리

### 0.4.7

* 레이어 메커니즘 도입. 슬라이드 요소를 레이어 단위로 애니메이션화하여 beamer의 "\only"와 같은 메커니즘 지원.
  레이어는 Beampy 모듈에서 파이썬 슬라이싱으로 관리됨




  ```python 
  with slide('Test layers'):
    text('First printed on layer 0')
    text('Secondly printed on layer 1')[1]
    text('Printed from layer 2 to 3')[2,3]
    text('Printed on all layers')[:]
    text('Printed on layer 4')[4]
    
    with group(width=300)[2:]:
        text('Printed inside group')
        text('for layers 2 to end')
  ```
  

### 0.4.6

* The core of Beampy slide processor has been rewritten and now allows recursive group of elements.

  ```python
  with group():
    text('toto')
    with group(width=300):
        text('tata')

        with group(width=200):
            figure('./niceplot.pdf')
            text('nice legend')
  ```

* 그룹 너비가 지정된 경우 너비가 지정되지 않은 그룹 내 모든 요소는 그룹의 너비를 가집니다

  ```python
  with group(width=200):
    figure('./niceplot.pdf')
    text('nice legend')
    # Figure and text width will be automatically set to 200 px
  ```

* 상대 위치 지정이 이제 자동 위치 지정된 요소에 대해 수행될 수 있습니다

  ```python
  t0 = text('toto')
  text('tata', x=t0.center + center(0), t0.bottom + 0.1)
  ```
* 비디오는 이제 외부 링크(*embedded=True* 사용)를 사용할 수 있으며, html 파일에 포함되지 않습니다.  
  슬라이드가 화면에 표시될 때 비디오는 디스크에서 로드됩니다(파일 경로에 주의).

### 0.4.5

* 모든 텍스트는 단일 latex 파일에서 전처리됩니다 (Latex는 한 번만 호출되어 컴파일 시간을 개선함)  
* 캐시 버그 수정: 비디오와 svg가 이제 올바르게 캐시됩니다

### 0.4.4

* 캐시 개선: 요소별로 하나의 파일만 캐시(캐시를 두 번 쓰지 않음!)  
* Svg: 선과 사각형 명령어 추가로 선과 사각형을 쉽게 그릴 수 있음  
* 상대 위치 지정: 현재 요소의 앵커를 변경하는 단축키 center(shift), right(shift), bottom(shift) 추가



  ```python 
    e1 = text('Somthing', x=0.2, y=0.4)
    e2 = text('An other thing', 
              x=e1.left + right(0.1), 
              y=e1.center + center(0))
  ```
### 0.4.3

* Matplotlib 그림을 이제 *figure()*에 직접 전달할 수 있으며, matplotlib 그림 목록을 *animatesvg()*로 애니메이션화할 수 있습니다.
* 캐시 크기 소폭 개선 (내용이 더 이상 캐시 파일에 저장되지 않음)
* scour 버전 업데이트 (svg-최적화기) 

### 0.4.2
* Latex에서 생성된 글리프 경로가 이제 고유해졌습니다 (문서 내 svg 라인 수 감소)
* 슬라이드에 원시 svg를 포함하는 *svg* 명령어 추가
* 테마 유연성 개선, 인터랙티브 요소가 포함된 배경을 이제 생성할 수 있습니다!

### 0.4.1
* 모든 슬라이드가 이제 램에 로드되어 속도 향상
* 모듈들이 이제 modules/core.py의 기본 클래스 "beampy_module"을 상속하는 클래스 형태
* 캐시가 이제 모든 포맷(pdf, svg, html)에 대해 고유하며, 모듈에 특수 키를 추가하여 캐시 ID 생성 가능

## 설치

[Beampy 문서 설치 페이지 보기](https://hchauvet.github.io/beampy/install.html)









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-05

---