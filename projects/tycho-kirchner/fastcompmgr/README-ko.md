# fastcompmgr

__fastcompmgr__는 X용 _빠른_ 컴포지터로, __Compton__의 초기 버전을 포크한 것이며,
이는 다시 __xcompmgr-dana__의 포크이고, __xcompmgr__의 포크입니다.

저는 오랫동안 좋은 옛날 xcompmgr를 사용했는데, compton은 창을 이동하거나 크기를 조절하거나
웹페이지를 관성 스크롤할 때 약간 지연되는 느낌이 들었기 때문입니다.
최신 picom-10.2를 테스트해보니 상황이 더 악화된 것 같습니다(아래 벤치마크 참고).
하지만 xcompmgr는 argb 창(예: 일부 터미널)에서 그림자를 그리지 않고,
여러 다른 결함도 있습니다. 그래서 2011년으로 돌아가서,
이 기능이 막 추가되던 시점의 버전을 기반으로, 불필요한 세그폴트와 메모리 누수를 없애는
몇몇 최신 compton 커밋을 선별해 적용하고 프로파일링을 바탕으로 그 버전을 더 빠르게 만들었습니다.
예를 들어, 창 이동 및 크기 조절 이벤트는 이벤트 수가 제한되고 고정된 프레임률로 렌더링되며,
스크롤은 가능한 한 빠르게 처리됩니다. 가려진 창은 그려지지 않고, 메모리 할당/해제가
대부분 회피되어 화면 재페인트가 더 빠릅니다.
단점으로는, 페이딩 기능은 현재 작동하지 않습니다(저는 사용하지 않습니다). 죄송합니다(;

## 벤치마크
제 Dell Latitude E5570에서 창 이동, 크기 조절 및 스크롤이
*명확히* 더 빠르게 느껴지며, 이를 뒷받침하는 몇 가지 수치도 있습니다.
완전히 가려지지 않은 여러 개의 중첩된 크롬 창이 있을 때, 해당 작업들을 *수동으로* 수행했으므로
벤치마크가 매우 정교하지는 않다는 점 참고 바랍니다. 관성 스크롤이 가능한
터치패드 드라이버 `xserver-xorg-input-synaptics`를 사용했습니다(웨이랜드는요?).
측정된 CPU 사용량은 다음과 같습니다:

| 컴포지터     | 이동   | 크기 조절 | 스크롤  |
| ------------- | ------ | -------- | ------- |
| fastcompmgr   | 6.7%   | 4.4%     | 1.5%    |
| xcompmgr      | 7.8%   | 4.9%     | 1.6%    |
| compton       | 26.4%  | 6.8%     | 17.1%   |
| picom         | 29.3%  | 8.1%     | 23.1%   |









도구는 다음 플래그와 함께 사용되었습니다:
~~~
(v0.1) fastcompmgr -o 0.4 -r 12 -c -C
(v1.1.8 from Debian 11) xcompmgr -o 0.4 -r 12 -c -C
(v1 from Debian 11) compton --config /dev/null --backend xrender -o 0.4 -r 12 -c -C
(v10.2) picom --config /dev/null --backend xrender -o 0.4 -r 12 -c

# 평균 계산 사용법
$ fastcompmgr -o 0.4 -r 12 -c -C &  pid=$!; sleep 4; \
    top -b -n 20 -d 0.5 -p $pid | LC_ALL=C awk -v pid=$pid \
    '$1==PID {++PIDCOUNT} $1==pid && PIDCOUNT>1 {print $9}' |  \
    datamash mean 1; kill $pid
~~~



## 설치
귀찮으면 [릴리즈 페이지](https://github.com/tycho-kirchner/fastcompmgr/releases)에서 바이너리를 받으세요.

그렇지 않으면, 다음 라이브러리 개발 버전을 설치하세요:
### 의존성:

* libx11
* libxcomposite
* libxdamage
* libxfixes
* libxrender
* pkg-config
* make

빌드 방법:

~~~ bash
$ make
$ make install
~~~

## 사용법

~~~ bash
$ fastcompmgr -o 0.4 -r 12 -c -C
~~~
모든 옵션 (현재 페이딩은 작동하지 않음):
~~~
   -d 디스플레이
    관리할 디스플레이를 지정합니다.
   -r 반경
    그림자에 대한 블러 반경입니다. (기본값 12)
   -o 불투명도
    그림자의 투명도입니다. (기본값 .75)
   -l 왼쪽 오프셋
    그림자의 왼쪽 오프셋입니다. (기본값 -15)
   -t 위쪽 오프셋
    그림자의 위쪽 오프셋입니다. (기본값 -15)
   -m 불투명도
    메뉴의 불투명도입니다. (기본값 1.0)
   -c
    창에 클라이언트 측 그림자를 활성화합니다.
   -C
    도크/패널 창에 그림자 그리기를 방지합니다.
   -i 불투명도
    비활성 창의 불투명도입니다. (0.1 - 1.0)
   -e 불투명도
    창 제목 표시줄 및 테두리의 불투명도입니다. (0.1 - 1.0)
    --shadow-red 값
    그림자의 빨간색 값 (0.0 - 1.0, 기본값 0).
    --shadow-green 값
    그림자의 녹색 값 (0.0 - 1.0, 기본값 0).
    --shadow-blue 값
    그림자의 파란색 값 (0.0 - 1.0, 기본값 0).

~~~


## 라이선스

xcompmgr는 여러 곳에서 사용되었습니다. 제가 알기로 이
특정 계통의 계보는 다음과 같습니다:

* Keith Packard (원저자)
* 매튜 호언
* ...
* 다나 얀센스
* 크리스토퍼 제프리
* 타이코 키르슈너

그 사이에 포크한 수십 명은 제외합니다.

자세한 내용은 LICENSE를 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-17

---