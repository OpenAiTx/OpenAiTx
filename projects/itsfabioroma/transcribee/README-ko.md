# transcribee 🐝

**YouTube, Instagram Reels, TikTok 및 로컬 미디어용 오픈 소스 macOS 전사기 — 자기 조직화 지식 기반으로 진화합니다.**

```bash
transcribee "https://youtube.com/watch?v=..."
transcribee "https://instagram.com/reel/..."
transcribee "https://vt.tiktok.com/..."
transcribee ~/Downloads/podcast.mp3
```
시간이 지남에 따라, 당신의 `~/Documents/transcripts/` 폴더는 자연스럽게 개인 도서관으로 발전합니다:


```
transcripts/
├── AI-Research/
│   ├── ilya-sutskever-agi-2024/
│   └── anthropic-constitutional-ai/
├── Startups/
│   ├── ycombinator-how-to-get-users/
│   └── pmarca-founder-mode/
└── Health/
    └── huberman-sleep-optimization/
```
각 전사는 화자 라벨이 지정되어 있으며 ChatGPT, Claude 또는 기타 LLM에 바로 붙여넣을 준비가 되어 있습니다.

## 왜 🍯

저는 유튜브, 인스타그램, 틱톡, 팟캐스트, 인터뷰 등 많은 비디오 콘텐츠를 소비합니다. 저는 다음을 원했습니다:
- LLM에서 비디오에 대해 질문하기
- 모든 지식을 검색 가능하고 체계적으로 정리하기
- 유지 관리를 위한 수작업을 하지 않기

transcribee는 바로 그 일을 합니다. 한 번 전사하면 지식이 영원히 유지됩니다.

## 기능 🪻

- **전사** 유튜브, 인스타그램 릴스, 틱톡, 로컬 오디오/비디오 파일
- **화자 구분** — 서로 다른 화자 식별
- **자동 분류** Claude를 사용하여 내용에 따라 전사본 자동 분류
- **지식 라이브러리 구축** 시간이 지남에 따라 스스로 조직화

## OpenClaw와 함께 사용하기 🤖

transcribee는 [OpenClaw](https://github.com/openclaw/openclaw) 스킬로 제공됩니다. 에이전트에게 유튜브 비디오를 전사해 달라고 요청하세요:

> "이 비디오를 전사해 주세요: https://youtube.com/watch?v=..."

### 스킬 설치하기


```bash
# Install from ClawHub (recommended)
openclaw skills install transcribee

# Or clone manually
git clone https://github.com/itsfabioroma/transcribee.git ~/.openclaw/workspace/skills/transcribee
```

의존성이 설치되어 있는지 확인하세요 (`brew install yt-dlp ffmpeg`) 및 API 키가 설정되어 있는지 확인하세요.

## 빠른 시작 🪺

```bash
# Install dependencies (macOS)
brew install yt-dlp ffmpeg
pnpm install

# Configure API keys
cp .env.example .env
# Add your ElevenLabs + Anthropic API keys to .env

# Transcribe anything
transcribee "https://youtube.com/watch?v=..."
transcribee "https://instagram.com/reel/..."
transcribee "https://vt.tiktok.com/..."
transcribee ~/Downloads/podcast.mp3
transcribee ~/Videos/interview.mp4
```

### 셸 별칭 (권장)

`~/.zshrc`에 추가:

```bash
alias transcribee="noglob /path/to/transcribee/transcribe.sh"
```

## 출력 🍯

각 대본은 `~/Documents/transcripts/{category}/{title}/`에 저장됩니다:

| 파일 | 용도 |
|------|-------|
| `transcript.txt` | 화자 라벨이 붙은 대본 — **이것을 LLM에 붙여넣으세요** |
| `metadata.json` | 비디오 정보, 언어, 자동 감지된 주제 |

### 원시 JSON (선택 사항)

단어 단위 타임스탬프와 신뢰도 점수가 필요한 고급 사용자를 위한:

```bash
transcribee --raw "https://youtube.com/watch?v=..."
```
This adds `transcript-raw.json` with the full ElevenLabs response.

## 작동 원리 🐝

1. YouTube에서 오디오 다운로드(yt-dlp) 또는 로컬 비디오에서 추출(ffmpeg)
2. ElevenLabs로 전사(`scribe_v1_experimental` 화자 분리 포함)
3. Claude가 콘텐츠 및 기존 라이브러리 구조 분석
4. 자동으로 올바른 폴더에 분류
5. 메타데이터와 함께 전사 파일 저장

## 요구 사항

- macOS (Sonoma에서 테스트됨)
- Node.js 18 이상
- [yt-dlp](https://github.com/yt-dlp/yt-dlp) — `brew install yt-dlp`
- [ffmpeg](https://ffmpeg.org/) — `brew install ffmpeg`
- [ElevenLabs API 키](https://elevenlabs.io/) — 전사용
- [Anthropic API 키](https://anthropic.com/) — 자동 분류용

## 지원 형식

| 유형 | 형식 |
|------|---------|
| 오디오 | mp3, m4a, wav, ogg, flac |
| 비디오 | mp4, mkv, webm, mov, avi |
| URL | youtube.com, youtu.be, instagram.com/reel, tiktok.com |

---

*부지 부지* 🐝



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-31

---