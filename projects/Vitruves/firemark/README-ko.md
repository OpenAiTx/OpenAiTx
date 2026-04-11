<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Vitruves&project=firemark&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/firemark.png" alt="firemark" width="200">
</p>

<h1 align="center">firemark</h1>

<p align="center">Rust로 제작된 이미지와 PDF를 위한 빠르고 단일 바이너리 워터마킹 도구입니다.</p>


## 왜 문서에 워터마크를 추가해야 하나요?

매년 수백만 명의 사람들이 단순한 문서 교환에서 시작된 신원 사기로 피해를 입습니다.
일반적인 시나리오: 당신은 임대할 아파트를 찾고 있습니다.
집주인 — 또는 집주인인 척하는 사람이 — 신분증, 급여 명세서, 세금 고지서 사본을 요청합니다.
당신은 아무 표시 없이 문서를 보내고, "집주인"은 사라집니다. 이제 당신의 문서가 은행 계좌 개설, 대출 신청, 또는 신분 위조에 사용됩니다.

문서를 보낼 때마다 워터마크를 추가하는 것은 가장 효과적인 방어책입니다.
**"XYZ 기관에 발송 — 2026년 3월 — 아파트 임대 신청용"**이라는 표시가 있는 오버레이는 문서를 다른 목적으로 사용할 수 없게 만듭니다. 유출될 경우, 어디에서 유출됐는지 정확히 알 수 있습니다.

firemark는 이를 손쉽게 만들어줍니다: 한 번의 명령으로 모든 이미지 또는 PDF에 적용, 17가지 시각적 스타일, 편집에 강한 암호화된 필리그린 패턴, 그리고 전체 폴더의 배치 처리 기능을 제공합니다.

<p align="center">
  <img src="https://raw.githubusercontent.com/Vitruves/firemark/main/assets/img/paycheck-firemark-comparison.png" alt="워터마크 전후 비교" width="800">
  <br>
  <em>워터마크 전과 후 — 한 번의 명령으로 문서가 추적 가능하고 변조 방지가 됩니다.</em>
</p>

## 설치 방법

[crates.io](https://crates.io/crates/firemark)에서:







```bash
cargo install firemark
```
출처:


```bash
git clone https://github.com/Vitruves/firemark.git
cd firemark
cargo install --path .
```
단일 최적화된 바이너리 생성(~5MB).

## 빠른 시작


```bash
# Watermark a single image
firemark photo_id.png -m "Flat rental — SCI Dupont — March 2026"

# Watermark a PDF
firemark tax_notice.pdf -m "CONFIDENTIAL" -s "Do not distribute"

# Watermark an entire folder recursively
firemark ./documents/ -R -m "Sent to Agency X" -t stamp

# Preview without writing files
firemark id_card.jpg -m "Draft" -n
```
출력은 기본적으로 입력과 동일한 위치에 `{name}-watermarked.{ext}`로 저장됩니다.  
명시적인 출력 경로를 설정하려면 `-o`를 사용하고, 사용자 지정 접미사를 원하면 `-S`를 사용하세요.  

## 워터마크 유형

| 플래그 | 스타일 | 설명 |
|---|---|---|
| `diagonal` | 대각선 그리드 | 전체 페이지 반복 대각선 텍스트 (기본값) |
| `stamp` | 도장 | 이중 테두리의 큰 중앙 도장 |
| `stencil` | 스텐실 | 전체 너비 군용 스텐실 문자 |
| `typewriter` | 타자기 | 고정폭 타자기 텍스트 |
| `handwritten` | 서명 | 밑줄이 있는 손글씨 스타일 서명 |
| `redacted` | 편집 | 전체 너비 검은색 편집 바 |
| `badge` | 방패 | 보안 방패/배지 엠블럼 |
| `ribbon` | 리본 | 대각선 모서리 리본 배너 |
| `seal` | 봉인 | 원형 공증 스타일 봉인 |
| `frame` | 테두리 | 전체 페이지 장식 테두리 |
| `tile` | 타일 | 촘촘한 균일 텍스트 그리드 |
| `mosaic` | 모자이크 | 무작위 산재 텍스트 |
| `weave` | 위브 | 서로 맞물리는 대각선 위브 |
| `ghost` | 고스트 | 매우 미묘한 엠보스 텍스트 |
| `watercolor` | 수채화 | 부드럽고 흐린 워시 효과 |
| `noise` | 노이즈 | 픽셀 노이즈가 있는 손상된 텍스트 |
| `halftone` | 하프톤 | 하프톤 점 그리드로 된 텍스트 |


```bash
firemark doc.pdf -t stamp -m "CONFIDENTIAL" --border --color red
```
## 보안 필리그란

firemark는 지폐 보안 기능에서 영감을 받은 암호화 필리그란 패턴을 오버레이합니다.  
이 미세한 기하학적 패턴은 이미지 편집기로 제거하기 매우 어렵습니다.

| 스타일 | 설명 |
|---|---|
| `guilloche` | 사인파 모양의 곡선 밴드 (기본값) |
| `rosette` | 스피로그래프 + 코너 로즈 곡선 |
| `crosshatch` | 미세한 대각선 다이아몬드 격자 |
| `border` | 물결치는 중첩 보안 테두리 |
| `lissajous` | 매개변수 리사주 곡선 |
| `moire` | 동심원 간섭 무늬 |
| `spiral` | 아르키메데스 나선 소용돌이 |
| `mesh` | 육각형 벌집 격자 |
| `plume` | 표면에 흩뿌려진 흐르는 깃털 모양 곡선 |
| `constellation` | 별 노드들이 미세한 기하학적 웹으로 연결됨 |
| `ripple` | 임의의 기원에서 겹치는 타원형 파면 |
| `full` | 모든 패턴 결합 |
| `none` | 필리그란 비활성화 |



```bash
firemark id.png -m "Rental application" --filigrane moire
firemark id.png -m "Rental application" --filigrane none   # disable
```
## AI 제거 강화

모든 렌더는 기본적으로 비결정적입니다. firemark는 보편적인
후처리 변조(알파 지터, 서브픽셀 색상 노이즈, 엣지 마이크로 도트,
희박한 고스트 픽셀)와 렌더러별 무작위화를 적용하여 같은 설정으로도
두 출력이 픽셀 단위로 동일하지 않도록 합니다. 이는 AI
비전 모델이 빼낼 예측 가능한 패턴을 학습하는 것을 불가능하게 만듭니다.

그 위에, 적대적 프롬프트 주입 스트립이 기본적으로 삽입되어
AI 워터마크 제거 도구를 혼란스럽게 합니다. 눈에 보이는 프롬프트 텍스트를 원하지 않으면 `--no-anti-ai`로 비활성화하세요:



```bash
firemark doc.png -m "CONFIDENTIAL" --no-anti-ai
```

## 공통 옵션

```
-m, --main-text           Primary watermark text
-s, --secondary-text      Secondary text line
-t, --type                Watermark style (see table above)
-o, --output              Output file path
-S, --suffix              Custom output suffix (default: "watermarked")
-c, --color               Color — name or #RRGGBB (default: blue)
-O, --opacity             Opacity 0.0–1.0 (default: 0.5)
-r, --rotation            Angle in degrees (default: -45)
-p, --position            center, top-left, top-right, bottom-left, bottom-right, tile
-f, --font                Font name or path to .ttf/.otf
-I, --image               Overlay an image as watermark
    --qr-data             Embed a QR code with custom data
    --qr-code-position    QR code placement (default: center)
    --qr-code-size        QR code size in pixels (default: auto)
    --border              Draw a border around the watermark
    --shadow              Add a drop shadow
    --filigrane           Security filigrane style (default: guilloche)
    --no-anti-ai          Disable adversarial prompt injection (on by default)
```

전체 70개 이상의 플래그 목록은 [`CLI.md`](https://raw.githubusercontent.com/Vitruves/firemark/main/CLI.md)를 참조하세요.

## PDF 옵션

```
    --pages           Pages to watermark (e.g. 1,3-5 or "all")
    --skip-pages      Pages to skip
    --behind          Place watermark behind content
    --no-flatten      Keep layers separate (flattened by default)
    --dpi             Render resolution (default: 150)
```

## 배치 처리

```bash
# Process all images and PDFs in a folder
firemark ./inbox/ -m "INTERNAL" -t tile

# Recursive, 8 threads, custom suffix
firemark ./docs/ -R -j 8 -m "Draft" -S draft

# Dry run — list what would be processed
firemark ./docs/ -R -m "Draft" -n
```
이미 워터마크가 있는 파일(접미사 일치)은 재실행 시 자동으로 건너뜁니다.

## 구성 파일

플래그 반복을 피하기 위해 옵션을 TOML 파일에 저장합니다. 전체 예시는
[`examples/config/firemark.toml`](https://raw.githubusercontent.com/Vitruves/firemark/main/examples/config/firemark.toml)을 참조하세요.
두 가지 프리셋이 있습니다: **ultra-secure** (조밀한 타일링, 전체 필리그램, QR 추적 가능성, 메타데이터 제거)와 **light** (간단한 대각선 텍스트, 추가 기능 없음).




```toml
# Global defaults
main_text = "CONFIDENTIAL"
secondary_text = "{author} — {date}"
watermark_type = "diagonal"
color = "#1a3c6e"
opacity = 0.45
font_weight = "bold"
filigrane = "guilloche"
border = true

[preset.ultra-secure]
main_text = "CONFIDENTIAL — {author}"
watermark_type = "tile"
color = "#CC0000"
opacity = 0.6
filigrane = "full"
anti_ai = true
qr_data = "firemark://{author}/{timestamp}/{uuid}"
strip_metadata = true

[preset.light]
main_text = "COPY"
watermark_type = "diagonal"
color = "#555555"
opacity = 0.3
filigrane = "none"
anti_ai = false
```

```bash
firemark doc.pdf --config firemark.toml
firemark doc.pdf --config firemark.toml --preset ultra-secure
firemark doc.pdf --config firemark.toml --preset light
firemark doc.pdf --save-preset mypreset    # save current flags
firemark --list-presets                     # list available presets
```

## 포맷 지원

| 포맷 | 입력 | 출력 |
|---|---|---|
| PNG | 예 | 예 |
| JPEG | 예 | 예 |
| PDF | 예 | 예 |
| WebP | 예 | 예 |
| TIFF | 예 | 예 |

포맷 간 변환을 지원합니다 (예: `firemark photo.webp -o out.pdf`).

## 라이선스

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---