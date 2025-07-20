<translate-content># 🧘 zenta

> **코딩 흐름에 맞춘 마음챙김**

코딩 중에 마음이 산만해질 때, 단순히 호흡으로 돌아가세요. 추적도, 지표도, 방해도 없이—터미널에서 순수한 인식만을 경험하세요.

**인식하는 그 자체가 수행입니다.** ✨

---

## ⚡ 빠른 시작
</translate-content>
```bash
# Install (one-liner)
curl -fsSL https://raw.githubusercontent.com/e6a5/zenta/main/install.sh | bash

# Set up zen aliases
echo "alias breath='zenta now --quick'" >> ~/.zshrc
echo "alias breathe='zenta now'" >> ~/.zshrc
echo "alias anchor='zenta anchor'" >> ~/.zshrc
echo "alias reflect='zenta reflect'" >> ~/.zshrc
source ~/.zshrc

# Use instantly
breath    # When mind wanders → return to breath (1 breath cycle)
breathe   # Need deeper centering → longer session (3 breath cycles)
anchor    # Find your rhythm → interactive breathing anchor
reflect   # Evening → gentle day review
```
---

## 🌸 왜 zenta인가?

### **당신의 실제 작업 흐름에 맞춤**

1. **알림**: "계획에 갇혔어요"
2. **돌아가기**: `breath`
3. **계속하기**: 코딩으로 돌아가 더 집중하기

### **진정한 선(Zen) 접근법**

- ✅ **추적 없음** → 인식은 최적화할 데이터가 아님
- ✅ **분석 없음** → 수행 자체가 목표
- ✅ **방해 없음** → 터미널에 그대로 머묾
- ✅ **그저 호흡하기** → 순수한 마음챙김

### **개발자를 위해 설계됨**

- 터미널 네이티브 (작업 흐름에 적합)
- 단일 바이너리 (의존성 없음)
- 개인 정보 보호 (데이터 수집 없음)
- 즉시 실행 (`breath`는 한 키 입력 거리)

---

## 🌊 아름다운 호흡


```bash
$ breath

       Let's breathe 🌸

    🌬️ Breathe in gently, let your body expand...

                      ○
                    ○ · ○
                     ···
              ○ · · ·   · · · ○
                     ···
                    ○ · ○
                      ·

       Carry this calm with you throughout your day 🙏
```
_부드러운 애니메이션과 함께하는 순수 시각적 호흡 안내_

---

## 💡 명령어

### **필수 명령어 (별칭 포함)**

| 명령어      | 사이클   | 기능                                     | 적합한 상황                         |
| --------- | -------- | -------------------------------------- | ---------------------------------- |
| `breath`  | 1 사이클 | 빠른 호흡 + 명언                       | 마음이 산만할 때                   |
| `breathe` | 3 사이클 | 표준 호흡 + 명언                       | 어려운 작업 전                     |
| `anchor`  | 사용자 주도 | 리듬 찾기를 위한 인터랙티브 앵커       | 자신의 페이스를 설정할 때         |
| `reflect` | -        | 부드러운 저녁 회고                     | 하루를 마무리하는 사색 시간         |

### **전체 명령어**

| 명령어                    | 사이클   | 기능                                         |
| ---------------------- | -------- | ---------------------------------------------- |
| `zenta now`            | 3 사이클 | 표준 호흡 + 명언                             |
| `zenta now --quick`    | 1 사이클 | 빠른 호흡 + 명언                             |
| `zenta now --extended` | 5 사이클 | 확장된 호흡 + 명언                           |
| `zenta anchor`         | 사용자 주도 | 자신의 리듬을 찾기 위한 인터랙티브 앵커         |
| `zenta now --silent`   | 3 사이클 | 호흡만, 명언 없음                            |
| `zenta now --simple`   | 3 사이클 | 단순 선 애니메이션 (터미널 호환성)               |

**옵션 조합:** `zenta now --quick --silent` (1 사이클, 명언 없음)

---

## 🔧 터미널 호환성

**아름다운 원 vs 단순 선:**

- **대부분 터미널**: 아름답게 확장/축소하는 호흡 원 애니메이션
- **macOS Terminal.app**: 자동 감지 후 단순 선 애니메이션 사용
- **tmux/screen**: 복잡한 애니메이션도 잘 작동

**단순 모드 강제 적용:** 모든 명령어에 `--simple` 추가 가능


```bash
breath --simple     # Force simple animation
zenta now --simple  # Works with any options
```
**왜?** macOS Terminal.app만 ANSI 이스케이프 시퀀스 특이점이 있습니다. zenta는 이를 자동 감지하여 최적의 경험을 제공합니다.

---

## 🎯 진짜 마음챙김 vs 가짜 마음챙김

**✅ 진짜 마음챙김 (zenta 방식):**

- 마음이 방황할 때 알아차리기
- 즉시 호흡으로 돌아가기
- 인식을 유지하며 작업 계속하기
- 측정 불필요

**❌ 가짜 마음챙김:**

- 명상 연속 기록 추적
- 인식 지표 최적화
- 내면의 평화 수치화
- 마음챙김을 생산적으로 만들기

---

## 🌿 철학

> _"조용해질수록 더 많이 들을 수 있다."_

**zenta의 믿음:**

- 마음챙김 도구는 수행 속으로 사라져야 한다
- 알아차림 그 자체가 깨달음이다
- 개발자는 생산성 해킹이 아닌 현재에 집중이 필요하다
- 진정한 선에는 지표가 없다

---

## 🚀 설치

### **옵션 1: 미리 빌드된 바이너리 (권장)**

**macOS/Linux:**


```bash
# Download and install the latest binary for your platform
curl -s https://api.github.com/repos/e6a5/zenta/releases/latest \
| grep "browser_download_url.*$(uname -s | tr '[:upper:]' '[:lower:]')-$(uname -m | sed 's/x86_64/amd64/')" \
| cut -d '"' -f 4 \
| xargs curl -L -o zenta.tar.gz \
&& tar -xzf zenta.tar.gz \
&& sudo mv zenta-* /usr/local/bin/zenta \
&& rm zenta.tar.gz

# Or download manually from GitHub Releases
```
**Windows:**  
최신 `.zip` 파일을 [GitHub Releases](https://github.com/e6a5/zenta/releases)에서 다운로드하고, 압축을 풀어 실행 파일을 PATH에 추가하세요.  

**수동 다운로드:** [GitHub Releases](https://github.com/e6a5/zenta/releases) - 플랫폼을 선택하세요  

### **옵션 2: 소스에서 빌드하기**  

_Go 1.23 이상이 설치되어 있어야 합니다_


```bash
git clone https://github.com/e6a5/zenta.git && cd zenta && make install-system
```
**먼저 Go를 설치하세요:** [https://golang.org/dl/](https://golang.org/dl/)

_Linux, macOS, Windows, FreeBSD(모든 아키텍처) 지원_

---

## 🧘 연습에 참여하기

- 🐛 **버그 신고** → [Issues](https://github.com/e6a5/zenta/issues)
- 💭 **심도 있는 토론** → [Discussions](https://github.com/e6a5/zenta/discussions)
- 🔧 **기여하기** → [CONTRIBUTING.md](https://raw.githubusercontent.com/e6a5/zenta/main/CONTRIBUTING.md)

---

## 📄 라이선스

MIT 라이선스 - [LICENSE](LICENSE)

---

> _"미래를 돌보는 가장 좋은 방법은 현재 순간을 돌보는 것이다."_ — 틱낫한

**오늘부터 마음챙김 코딩 연습을 시작하세요:**


```bash
breath  # Just try it 🙏
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---