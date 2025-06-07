# 엔티움 - Engrammer와 Hands Down Promethium의 만남

![Photograph of Enthium v7 on my Glove80 keyboard](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-photograph-Enthium.jpg
)

이 키보드 레이아웃은 [Engrammer]와 [Hands Down Promethium]의 조합으로,
아래의 키보드 레이아웃 분석기(아래 참고)에서 후자의 성능을 개선하였습니다.
수평으로 미러링하여 [Arno의 Engram 2.0] 레이아웃(왼손 홈로우의 CIEA, PF를 WV와 스왑하여 Engram과 유사하게)과 [드보락] 레이아웃(오른손 홈로우의 HTNS)에 익숙함을 되살렸고,
Engrammer의 정신을 따라 프로그래밍에 최적화된 구두점 배치를 적용하였습니다.

특히 Engram/mer와 Enthium의 차이는 극히 미미하여,
[KeyBr] 훈련에서 모든 문자를 잠금 해제하려면 2~3일(금요일 시작, 주말 활용)에 걸쳐 약 6시간 연습만으로 완전히 전환이 가능합니다.

자세한 내용은 [블로그 포스트](https://sunaku.github.io/enthium-keyboard-layout.html)를 참고하세요. 이 레이아웃을 개발하게 된 “토끼굴” 같은 여정이 담겨 있습니다.

[Hands Down Promethium]: https://reddit.com/r/KeyboardLayouts/comments/1g66ivi
[Arno's Engram 2.0]:     https://engram.dev
[Engrammer]:             https://github.com/sunaku/engrammer
[Dvorak]:                https://www.dvzine.org
[KeyBr]:                 https://github.com/aradzie/keybr.com#readme

## 레이아웃

      q y o u - x l d w z
    b c i e a , k h t n s v
      ' / = . ; j m g p f
                r

>![Rendering of Enthium v7 on a laptop keyboard.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)
>![Rendering of Enthium v7 on my Glove80 keyboard.](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-diagram-Enthium.png
)

<!-- vim-markdown-toc GFM -->

* [설계 근거](#rationale)
  * [편차: PF와 WV](#deviation-pf-and-wv)
  * [편차: B와 V](#deviation-b-and-v)
* [성능](#performance)
  * [Cyanophage 분석기](#cyanophage-analyzer)
  * [KeySolve 분석기](#keysolve-analyzer)
  * [Oxey의 분석기](#oxeys-analyzer)
  * [비교](#comparison)
* [설치](#installation)
  * [리눅스 설정](#linux-setup)
  * [MacOS 설정](#macos-setup)
    * [설치](#installation-1)
    * [복잡한 수정](#complex-modification)
    * [제거](#uninstallation)
* [라이선스](#license)

<!-- vim-markdown-toc -->

## 설계 근거

* Q와 Z는 균형과 대칭을 위해 서로 다른 손으로 분리되어 배치되었습니다.

* B와 V는 홈로우의 측면 소지키(CapsLock, Apostrophe)에 배치되어,
  손가락이 짧거나 [약한 새끼손가락]을 가진 분들이 위로 뻗는 부담을 줄입니다.

* Apostrophe는 YOU 및 I와 완전히 다른 손가락에 배치되어,
  `you'd`, `I'd`와 같은 동일 손가락 이음 빅그램을 방지합니다.

* Comma와 세미콜론을 한데 모아, Vim에서 f/F/t/T 탐색을 빠르게 하고,
  오른손의 K와 J의 상대적 순서를 미러링합니다.

* 마침표와 콤마는 시프트 기호(`>`, `<`) 기준으로 보면 위치가 바뀌었으나,
  이 배치는 측면 스트레치 빅그램을 줄이고, 전통적인 행-스태거드 키보드에서 수직 정렬됩니다.

* 마이너스 기호는 인덱스 손가락에 배치되어(콤마, 마침표, 세미콜론과 일관성),
  문장/단어 구분 부호의 일관적 사용과, 프로그래밍 시 잦은 언더스코어(`_`) 입력을 쉽게 합니다.
  특히 행-스태거드 키보드에서 왼손 인덱스 손가락의 자연스러운 확장 방향을 따라가도록 했습니다.

* 슬래시와 마침표를 통해 `/.`, `./`, `../` 파일 경로 입력이 자연스럽게 굴러갑니다.

[약한 새끼손가락]: https://reddit.com/r/KeyboardLayouts/comments/1fy8nve/_/lqulnww/

### 편차: PF와 WV

PF와 WV를 교체하여 다음과 같은 불편함을 해소했습니다:

* WN은 동일 손가락 계단식 상승 빅그램으로, 아래로 긁듯 입력하고 싶었습니다.
* DW(2u 스킵)는 Engram처럼 인접하지 않아 Vim에서 불편합니다.
* FG(2u 스킵)는 Engram에서처럼 쉘 백그라운드 작업(`bg`, `fg`)에 편리하지 않습니다.
* SW(하프 가위)는 안쪽으로 말아쥐는 것보다 위로 뻗는 게(Engram과 같이) 더 강한 느낌입니다.
* FF(예: "stu*ff*")는 소지로 상단 행을 두 번 두드리기 약간 부담스럽습니다.

Hands Down Promethium의 표준에서 벗어나고 싶지 않았지만,
(이 "Enthium" 파생은 단순 수평 미러 및 구두점 일부 재배치만을 의도했음)
아쉬운 마음에 키보드 레이아웃 분석기에서 PF와 WV를 바꿔도 성능이 나쁘지 않은지 확인해봤고,
놀랍게도 이 변화는 레이아웃의 성능에 거의 영향을 주지 않았습니다:

* Oxey의 분석기는 통계에 변화가 없었습니다!
* KeySolve 분석기는 FSB가 0.14%에서 0.37%로 증가했지만,
  FSS는 0.82%에서 0.48%로, HSB는 6.05%에서 5.64%로,
  HSS는 5.97%에서 5.50%로 개선되었습니다. 나머지는 동일합니다.
* Cyanophage 분석기는 Total Word Effort가 730.9에서 735.9로 소폭 증가했으나,
  나머지 통계는 동일합니다!

이 실험이 잘 되어 정말 기쁩니다. 실제로 더 편안해졌고,
Engrammer에서 Enthium으로 전환하려는 분들에게도 진입 장벽을 더욱 낮출 수 있습니다. :)

### 편차: B와 V

B와 V는 상단 행에서 홈로우 측면으로 회전 배치하여,
손가락이 짧거나 [약한 새끼손가락]을 가진 분들이 위로 뻗지 않도록 했습니다.
해당 키들은 영어에서 가장 드문 문자(Q, Z)로 재배정했습니다.

Cyanophage 분석기 기준, 이 변경은 Pinky/Ring Scissors를 0.49%에서 0.35%로(대폭 감소!),
Skip Bigrams(2u)을 0.30%에서 0.29%로 줄였습니다.
다른 분석기들은 측면 소지키의 특성을 완전히 반영하지 못하지만(각 분석기 소제목 상단 주석 참고),
Oxey 분석기는 SFB가 0.829%에서 0.818%로 감소했다고 보고합니다.

## 성능

### [Cyanophage 분석기][cNT]

> **참고:** 이 분석기는 현재 왼쪽 엄지에만 문자를 배치할 수 있고 오른쪽 엄지에는 불가하여,
> 분석을 위해 레이아웃을 수평 미러링했습니다. 미러링은 결과에 영향을 주지 않습니다.

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/cyanophage.png)

전체 통계:
* Total Word Effort: 748.5
* Effort:            432.54

손가락 사용:
* Same Finger Bigrams: 0.55%
* Skip Bigrams (2u):   0.29%
* Lat Stretch Bigrams: 0.23%
* Pinky/Ring Scissors: 0.34%

트라이그램 통계:
* alt:             37.45%
* bigram roll in:  29.02%
* bigram roll out: 14.67%
* other:           8.28%
* alt sfs:         5.10%
* redirect:        2.14%
* roll in:         1.71%
* weak redirect:   1.32%
* roll out:        0.31%

### [KeySolve 분석기](https://grassfedreeve.github.io/keysolve-web/)

> **참고:** 이 분석기는 전통 CapsLock, Apostrophe 같은 홈로우 측면 소지키에 문자를 배치할 수 없어,
> 결과가 정확하지 않을 수 있습니다. 예를 들어, SFB 비율은 R, B, V가 모두 엄지로 입력된다고 가정하지만,
> 실제로는 R은 오른쪽 엄지, B는 왼쪽 새끼손가락, V는 오른쪽 새끼손가락에 있습니다.

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve1.png)
![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve2.png)
![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve3.png)

전체 통계:

    BIGRAMS     SFB: 0.97%      LSB: 0.44%      HSB: 4.79%      FSB: 0.35%
    SKIPGRAMS   SFS: 6.99%      LSS: 0.92%      HSS: 4.66%      FSS: 0.38%
    TRIGRAMS    ALT: 41.24%     ROL: 40.71%     ONE: 2.47%      RED: 1.66%

손가락 사용:

    LEFT        LI: 13.91%      LM: 20.17%      LR: 8.70%       LP: 3.05%
    RIGHT       RI: 13.12%      RM: 14.59%      RR: 10.60%      RP: 7.94%
    TOTAL               LH: 45.83%                      RH: 54.17%

복사/붙여넣기용 커스텀 소스:

    q y o u - x l d w z
    c i e a , k h t n s
    ' / = . ; j m g p f
    r b v

### [Oxey의 분석기](https://oxey.dev/playground/index.html)

> **참고:** 이 분석기는 전통 CapsLock, Apostrophe 같은 홈로우 측면 소지키에 문자를 배치할 수 없어,
> 결과가 정확하지 않을 수 있습니다. 예를 들어, SFB 비율은 B와 V가 모두 왼쪽 엄지로 입력된다고 가정하지만,
> 실제로는 B는 왼쪽 새끼손가락, V는 오른쪽 새끼손가락에 있습니다.

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/oxey.png)

전체 통계:
* Sfb:              0.811%
* Dsfb:             6.286%
* Lsb:              0.372%
* Inrolls:          29.442%
* Outrolls:         15.841%
* Total Rolls:      45.283%
* Onehands:         2.348%
* Alternates:       31.877%
* Alternates (sfs): 7.284%
* Total Alternates: 39.161%
* Redirects:        3.864%
* BadRedirects:     1.002%
* Total Redirects:  4.866%
* Other:            8.341%
* Invalid:          0.001%

손가락 사용:

    finger 0:   3.63%   finger 9:       8.60%
    finger 1:   9.08%   finger 8:       10.65%
    finger 2:   19.30%  finger 7:       14.56%
    finger 3:   13.28%  finger 6:       12.33%

    Left hand:   45.29% Right hand:     46.14%
    Left center: 1.384% Right center:   1.189%

    Home keys usage: 56.37%

Sfb% 손가락별:

    finger 0:   0.011%  finger 9:       0.024%
    finger 1:   0.047%  finger 8:       0.100%
    finger 2:   0.122%  finger 7:       0.051%
    finger 3:   0.339%  finger 6:       0.114%

### 비교

> **참고:** Oxey 분석기는 전통 CapsLock, Apostrophe 같은 홈로우 측면 소지키에 문자를 배치할 수 없어,
> 결과가 정확하지 않을 수 있습니다. 예를 들어, SFB 비율은 B와 V가 모두 왼쪽 엄지로 입력된다고 가정하지만,
> 실제로는 B는 왼쪽 새끼손가락, V는 오른쪽 새끼손가락에 있습니다.
> 대신 [Cyanophage 분석기 결과](#cyanophage-analyzer)를 참고하세요.
> Cyanophage는 측면 소지키와 엄지에 하나의 문자를 반영합니다.

[키보드 레이아웃 커뮤니티][rKL]에서는 보통 [Pascal Getreuer의 가이드 및 비교표][PGt]를
레이아웃 탐색의 출발점으로 추천하며, Enthium은 (통계상) 최상위 레이아웃 중 하나입니다.

* 0.811% SFBs -- 🥈 2위; Focal에만 뒤짐
* 0.372% LSBs -- 🥇 1위; 전체 표 중 최고!
* 45.283% rolls -- Nerps, Gallium, MTGAP, Graphite, Dvorak, Halmak 등 능가
* 4.866% redirects -- MTGAP, Sturdy, Recurva, APTv3, Canary, Colemak 등 능가
* 2.80% pinky off(측면 제외) -- Graphite, Canary, Gallium, MTGAP 등 능가
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%)
* 5.35% pinky off(측면 포함) -- Engram, Halmak 능가, 나머지에 비해 약간 높음
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%) + `B` (1.49%) + `V` (1.06%)

[rKL]: https://www.reddit.com/r/KeyboardLayouts/
[PGt]: https://getreuer.info/posts/keyboards/alt-layouts/index.html#which-alt-keyboard-layout-should-i-learn

참고로, [이 및 관련 레이아웃의 모든 통계](https://raw.githubusercontent.com/sunaku/enthium/main/stats/)를 표로 정리했습니다:

[cNT]: https://cyanophage.github.io/playground.html?layout=zwdlx-uoyq%5Csnthk%2Caeicbfpgmj%3B.%3D%2F%27vr&mode=ergo&lan=english
[cPM]: https://cyanophage.github.io/playground.html?layout=fpdlx%3Buoybzsnthk%2Caeicqvwgmj-.%27%3D%2F%5Cr&mode=ergo&lan=english
[cNG]: https://cyanophage.github.io/playground.html?layout=byou%27%3Bldwvzciea%2C.htsnqgxjk-%2Frmfp%5C%5E&mode=ergo&lan=english
[cDV]: https://cyanophage.github.io/playground.html?layout=%27%2C.pyfgcrl%2Faoeuidhtns-%3Bqjkxbmwvz%5C%5E&mode=ergo&lan=english
[cCD]: https://cyanophage.github.io/playground.html?layout=qwfpbjluy%3B-arstgmneio%27zxcdvkh%2C.%2F%5C%5E&mode=ergo&lan=english

| 분석기     | 카테고리  | 통계                | [Enthium][cNT] | [Promethium][cPM] | [Engrammer][cNG] | [Dvorak][cDV] | [Colemak-DH][cCD] |
| ---------- | --------- | ------------------- | -------------- | ----------------- | ---------------- | ------------- | ----------------- |
| Oxey's     | Bigrams   | SFB                 | 0.811%         | 0.868%            | 1.511%           | 2.779%        | 1.367%            |
| Oxey's     | Bigrams   | DSFB                | 6.286%         | 6.761%            | 7.620%           | 6.979%        | 8.767%            |
| Oxey's     | Bigrams   | LSB                 | 0.372%         | 0.404%            | 0.671%           | 1.255%        | 1.975%            |
| Oxey's     | Trigrams  | Inrolls             | 29.442%        | 29.333%           | 28.273%          | 23.820%       | 25.173%           |
| Oxey's     | Trigrams  | Outrolls            | 15.841%        | 14.526%           | 14.050%          | 15.104%       | 20.940%           |
| Oxey's     | Trigrams  | Total Rolls         | 45.283%        | 43.858%           | 42.323%          | 38.924%       | 46.113%           |
| Oxey's     | Trigrams  | Onehands            | 2.348%         | 2.189%            | 2.146%           | 0.624%        | 2.484%            |
| Oxey's     | Trigrams  | Alternates          | 31.877%        | 33.770%           | 32.483%          | 35.769%       | 22.913%           |
| Oxey's     | Trigrams  | Alternates (SFS)    | 7.284%         | 8.205%            | 8.752%           | 8.787%        | 7.461%            |
| Oxey's     | Trigrams  | Total Alternates    | 39.161%        | 41.974%           | 41.235%          | 44.556%       | 30.375%           |
| Oxey's     | Trigrams  | Redirects           | 3.864%         | 2.273%            | 3.103%           | 2.639%        | 9.081%            |
| Oxey's     | Trigrams  | BadRedirects        | 1.002%         | 1.236%            | 1.386%           | 0.818%        | 1.498%            |
| Oxey's     | Trigrams  | Total Redirects     | 4.866%         | 3.509%            | 4.489%           | 3.458%        | 10.579%           |
| Oxey's     | Trigrams  | Other               | 8.341%         | 8.468%            | 9.806%           | 12.437%       | 9.202%            |
| Oxey's     | Trigrams  | Invalid             | 0.001%         | 0.001%            | 0.001%           | 0.001%        | 1.248%            |
| Oxey's     | 사용      | Finger 0            | 3.63%          | 9.56%             | 6.58%            | 8.50%         | 8.12%             |
| Oxey's     | 사용      | Finger 1            | 9.08%          | 10.65%            | 9.21%            | 8.72%         | 8.04%             |
| Oxey's     | 사용      | Finger 2            | 19.30%         | 14.56%            | 19.47%           | 12.99%        | 11.55%            |
| Oxey's     | 사용      | Finger 3            | 13.28%         | 12.33%            | 13.35%           | 14.95%        | 19.19%            |
| Oxey's     | 사용      | Finger 6            | 12.33%         | 13.28%            | 16.04%           | 16.33%        | 18.88%            |
| Oxey's     | 사용      | Finger 7            | 14.56%         | 19.77%            | 14.93%           | 13.73%        | 15.60%            |
| Oxey's     | 사용      | Finger 8            | 10.65%         | 9.01%             | 10.31%           | 13.84%        | 10.11%            |
| Oxey's     | 사용      | Finger 9            | 8.60%          | 4.62%             | 9.90%            | 10.59%        | 7.77%             |
| Oxey's     | 사용      | 왼손                | 45.29%         | 47.10%            | 48.61%           | 45.16%        | 46.89%            |
| Oxey's     | 사용      | 오른손              | 46.14%         | 46.68%            | 51.18%           | 54.49%        | 52.36%            |
| Oxey's     | 사용      | 왼쪽 중앙           | 1.384%         | 1.189%            | 1.765%           | 9.208%        | 4.592%            |
| Oxey's     | 사용      | 오른쪽 중앙         | 1.189%         | 1.384%            | 1.294%           | 7.257%        | 3.393%            |
| Oxey's     | 사용      | 홈키                | 56.37%         | 56.37%            | 56.37%           | 56.70%        | 62.31%            |
| Oxey's     | SFB%      | Finger 0            | 0.011%         | 0.028%            | 0.012%           | 0.020%        | 0.041%            |
| Oxey's     | SFB%      | Finger 1            | 0.047%         | 0.100%            | 0.089%           | 0.028%        | 0.047%            |
| Oxey's     | SFB%      | Finger 2            | 0.122%         | 0.051%            | 0.230%           | 0.253%        | 0.186%            |
| Oxey's     | SFB%      | Finger 3            | 0.339%         | 0.114%            | 0.591%           | 1.075%        | 0.219%            |
| Oxey's     | SFB%      | Finger 6            | 0.114%         | 0.339%            | 0.380%           | 0.433%        | 0.388%            |
| Oxey's     | SFB%      | Finger 7            | 0.051%         | 0.185%            | 0.053%           | 0.494%        | 0.341%            |
| Oxey's     | SFB%      | Finger 8            | 0.100%         | 0.040%            | 0.098%           | 0.256%        | 0.137%            |
| Oxey's     | SFB%      | Finger 9            | 0.024%         | 0.011%            | 0.058%           | 0.220%        | 0.007%            |
| KeySolve   | Bigrams   | SFB                 | 0.97%          | 0.94%             | 1.56%            | 2.62%         | 1.49%             |
| KeySolve   | Bigrams   | LSB                 | 0.44%          | 0.45%             | 0.98%            | 1.17%         | 2.21%             |
| KeySolve   | Bigrams   | HSB                 | 4.79%          | 6.04%             | 3.02%            | 6.11%         | 5.93%             |
| KeySolve   | Bigrams   | FSB                 | 0.35%          | 0.26%             | 0.30%            | 0.14%         | 0.37%             |
| KeySolve   | Skipgrams | SFS                 | 6.99%          | 7.02%             | 7.50%            | 7.00%         | 7.95%             |
| KeySolve   | Skipgrams | LSS                 | 0.92%          | 0.93%             | 1.34%            | 4.48%         | 1.75%             |
| KeySolve   | Skipgrams | HSS                 | 4.66%          | 6.11%             | 6.91%            | 8.56%         | 6.49%             |
| KeySolve   | Skipgrams | FSS                 | 0.38%          | 0.78%             | 0.81%            | 1.22%         | 0.78%             |
| KeySolve   | Trigrams  | ALT                 | 41.24%         | 40.37%            | 39.59%           | 41.70%        | 27.58%            |
| KeySolve   | Trigrams  | ROL                 | 40.71%         | 40.84%            | 39.35%           | 37.19%        | 42.78%            |
| KeySolve   | Trigrams  | ONE                 | 2.47%          | 2.66%             | 2.65%            | 0.43%         | 2.45%             |
| KeySolve   | Trigrams  | RED                 | 1.66%          | 1.78%             | 2.65%            | 2.25%         | 6.74%             |
| KeySolve   | 사용      | LI                  | 13.91%         | 13.91%            | 13.91%           | 14.56%        | 18.82%            |
| KeySolve   | 사용      | LM                  | 20.17%         | 20.92%            | 20.30%           | 13.96%        | 10.18%            |
| KeySolve   | 사용      | LR                  | 8.70%          | 8.70%             | 8.83%            | 9.55%         | 7.83%             |
| KeySolve   | 사용      | LP                  | 3.05%          | 3.64%             | 5.72%            | 8.24%         | 7.63%             |
| KeySolve   | 사용      | RI                  | 13.12%         | 13.12%            | 16.52%           | 16.90%        | 20.00%            |
| KeySolve   | 사용      | RM                  | 14.59%         | 14.59%            | 15.03%           | 13.35%        | 16.91%            |
| KeySolve   | 사용      | RR                  | 10.60%         | 10.60%            | 10.08%           | 13.36%        | 10.46%            |
| KeySolve   | 사용      | RP                  | 7.94%          | 8.95%             | 9.47%            | 10.08%        | 8.16%             |
| KeySolve   | 합계      | LH                  | 45.83%         | 47.18%            | 48.75%           | 46.31%        | 44.46%            |
| KeySolve   | 합계      | RH                  | 54.17%         | 52.82%            | 51.25%           | 53.69%        | 55.54%            |
| Cyanophage | 요약      | Total Word Effort   | 748.5          | 732.3             | 899.8            | 1185.5        | 1048.2            |
| Cyanophage | 요약      | Effort              | 432.54         | 398.07            | 457.44           | 769.78        | 535.05            |
| Cyanophage | Bigrams   | Same Finger Bigrams | 0.55%          | 0.58%             | 0.99%            | 1.87%         | 0.91%             |
| Cyanophage | Bigrams   | Skip Bigrams (2u)   | 0.29%          | 0.36%             | 0.39%            | 0.45%         | 0.41%             |
| Cyanophage | Bigrams   | Lat Stretch Bigrams | 0.23%          | 0.24%             | 0.41%            | 0.80%         | 1.27%             |
| Cyanophage | Bigrams   | Pinky/Ring Scissors | 0.34%          | 0.42%             | 0.71%            | 0.40%         | 0.65%             |
| Cyanophage | Trigrams  | Alt                 | 37.45%         | 36.98%            | 35.62%           | 39.08%        | 25.43%            |
| Cyanophage | Trigrams  | Alt SFS             | 5.10%          | 5.27%             | 5.93%            | 5.85%         | 5.47%             |
| Cyanophage | Trigrams  | Roll in             | 1.71%          | 1.37%             | 1.82%            | 0.86%         | 1.50%             |
| Cyanophage | Trigrams  | Roll out            | 0.31%          | 0.11%             | 0.29%            | 0.27%         | 0.98%             |
| Cyanophage | Trigrams  | Bigram roll in      | 29.02%         | 29.18%            | 28.14%           | 23.51%        | 25.18%            |
| Cyanophage | Trigrams  | Bigram roll out     | 14.67%         | 14.56%            | 14.03%           | 15.14%        | 21.55%            |
| Cyanophage | Trigrams  | Redirect            | 2.14%          | 2.03%             | 3.05%            | 2.57%         | 9.22%             |
| Cyanophage | Trigrams  | Weak redirect       | 1.32%          | 1.30%             | 1.40%            | 0.28%         | 1.52%             |
| Cyanophage | Trigrams  | Other               | 8.28%          | 9.20%             | 9.72%            | 12.44%        | 9.17%             |

## 설치

### 리눅스 설정

>*범례:* QWERTY=흰색; Engram=금색; Enthium=파랑/초록; Quirks=분홍.
>![Rendering of this layout on a row-staggered keyboard.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)

설치:

    cd linux/
    sudo make install
    echo 이제 그래픽 세션을 재시작하세요.

활성화:

    setxkbmap -layout us    -variant enthium         # 단일 레이아웃; 전환 없음
    setxkbmap -layout us,us -variant enthium,basic   # 이중 레이아웃 전환

복구(예: XKB 패키지 업그레이드로 설치가 되돌아갈 때):

    cd linux/
    sudo make reinstall
    echo 이제 그래픽 세션을 재시작하세요.

제거:

    cd linux/
    sudo make uninstall
    echo 이제 그래픽 세션을 재시작하세요.

### MacOS 설정

#### 설치

MacOS에서 이 레이아웃을 사용하려면 [Karabiner-Elements](https://karabiner-elements.pqrs.org/)를 설치해야 합니다.

[Homebrew](https://brew.sh/)로 설치할 수 있습니다:

    brew install --cask karabiner-elements

또는 [Karabiner-Elements 공식 웹사이트](https://karabiner-elements.pqrs.org/)에서 다운로드하세요.

다운로드 후, [설치 가이드](https://karabiner-elements.pqrs.org/docs/getting-started/installation/)의 지침을 따르면 됩니다.

#### 복잡한 수정

모두 설치한 후, [복잡한 수정 기능](https://karabiner-elements.pqrs.org/docs/manual/configuration/configure-complex-modifications/)을 사용해 키를 리맵할 수 있습니다.

엔티움 복잡한 수정은 [여기](https://ke-complex-modifications.pqrs.org/?q=enthium)에서 받을 수 있습니다.

기본 레이아웃으로 돌아가려면 엔티움 복잡한 수정을 제거하면 됩니다.

#### 제거

* Brew : `brew uninstall --cask karabiner-elements`
* 수동 : `Applications` 폴더에서 `Karabiner-Elements.app`를 삭제

## 라이선스

[Arno's Engram 2.0] 키보드 레이아웃 소스와 동일한 조건으로 배포됩니다:

> MIT License
>
> Copyright 2022 Ricard Figueroa <https://github.com/rfiga>  
> Copyright 2021 Suraj Kurapati <https://github.com/sunaku>  
> Copyright 2021 Arno Klein <https://github.com/binarybottle>  
>
> 이 소프트웨어 및 관련 문서 파일("소프트웨어")의 복사본을 취득한 모든 사람에게,
> 소프트웨어를 자유롭게 사용, 복사, 수정, 병합, 게시, 배포, 서브라이선스, 판매할 권한을
> 무상으로 부여하며, 다음 조건을 충족해야 합니다:
>
> 위 저작권 고지 및 이 허가 고지는 소프트웨어의 모든 복사본 또는 중요한 부분에 포함되어야 합니다.
>
> 이 소프트웨어는 "있는 그대로" 제공되며, 상품성, 특정 목적 적합성 및 비침해에 대한
> 어떠한 보증도 명시적 또는 묵시적으로 하지 않습니다.
> 저자 또는 저작권자는 소프트웨어 또는 사용, 기타 거래로 인해 발생하는
> 어떠한 클레임, 손해, 기타 책임에 대해 책임지지 않습니다.

---------------------------------------------------------------------------
[Spare A Life]: https://sunaku.github.io/vegan-for-life.html
> 제 작업이 마음에 드셨나요? 👍 오늘 [생명을 살려] 주세요! 🐄🐖🐑🐔🐣🐟✨🙊✌  
> 왜? 💕 윤리, 🌎 환경, 💪 건강을 위해; 위 링크에서 확인하세요. 🙇

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---