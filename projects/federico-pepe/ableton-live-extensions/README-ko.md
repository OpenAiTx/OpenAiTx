# Ableton Live 확장 실험

![Ableton Live Extensions](/images/Ableton-Extensions.png)

🖥️ [내 소개 영상을 YouTube에서 시청하기](https://www.youtube.com/watch?v=_izRiBGngGI)

*기대되는 것을 깨뜨리세요. Live를 당신만의 것으로 만드세요.* 

확장은 반복 작업을 자동화하여 워크플로우를 가속화하고, 새로운 아이디어를 반짝이거나 섞어내는 등 Live의 기능을 강화하는 강력한 도구로서 새로운 방식입니다.

이 저장소는 여러분이 시도하고 탐색하며 편집할 수 있도록 제가 개발한 확장 기능 모음입니다. 대부분은 SDK의 기능을 확인하기 위한 테스트입니다.

Ableton 확장에 대해 더 읽어보세요:

* [Ableton.com](https://www.ableton.com/en/live/extensions)
* [Extension SDK](https://ableton.github.io/extensions-sdk)
* 확장에 대해 토론하려면 [Ableton의 Discord](https://discord.gg/ableton)에 참여하세요

## 요구 사항

* Ableton Live Suite 12.4.5 베타

## 면책 조항

대부분의 확장은 코드 작업의 대부분을 담당한 *Claude Code*의 도움으로 만들었습니다. 이 점이 불편하거나 그 방식에 동의하지 않으셔도 괜찮습니다. 어쨌든 시간을 내어 확인해 주셔서 감사합니다.

**Bird Game** 확장 개발과 멋지게 완성하는 데 도움을 준 **Rain**과 **Jackie**에게 큰 감사를 드립니다. Windows 호환 **Doom**을 만들어 준 Glau [@glaurossi](https://github.com/glaurossi)에게 감사합니다. **Freesound Sampler**는 Freesound 수석 개발자 Frederic Font Corbera [@ffont](https://github.com/ffont)의 피드백과 협업으로 개발되었습니다.

---

# 확장

| 이름 | 버전 | 설명 | 다운로드 | 소스 |
|---|---|---|---|---|
| Arrangement Helper | 0.0.8 | MIDI 트랙에 이름과 색상이 지정된 구조화된 편곡을 생성합니다. *⚠️ 확장 README 파일의 현재 알려진 제한 사항을 반드시 읽어주세요.* | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Arrangement-Helper-0.0.8.ablx) | [🏗️ 소스](extensions/arrangement-helper) |
| Basic Pitch ✨ | 1.0.3 | Spotify의 Basic Pitch 신경망을 사용해 오디오 클립을 MIDI로 변환하며 완전 오프라인(macOS 및 Windows) | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Basic-Pitch-1.0.3.ablx) | [🏗️ 소스](extensions/spotify-basic-pitch) |
| Bird Game | 1.1.0 | Flappy Bird에서 영감을 받은 재미용 게임으로 실행을 MIDI 클립으로 변환(macOS 및 Windows) | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/bird-game-1.1.0.ablx) | [🏗️ 소스](extensions/bird-game) |
| Chord Progression Helper | 0.5.1 | 모든 키에서 코드 진행을 생성하고 MIDI 클립으로 작성 | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Chord-Progression-Helper-0.5.1.ablx) | [🏗️ 소스](extensions/chord-progression-helper) |
| Chord Voicing Helper | 1.0.2 | MIDI 클립에서 코드를 감지하고 보이싱 전략을 적용 및 미리보기 가능 | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Chord-Voicing-Helper-1.0.2.ablx) | [🏗️ 소스](extensions/chord-voicings-helper) |
| ChromaFlux | 0.0.7 | 설정 가능한 모드와 강도로 악기 랙 매개변수를 무작위화 | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/ChromaFlux-0.0.7.ablx) | [🏗️ 소스](extensions/chroma-flux) |
| Doom | 1.0.0 | Ableton Live(macOS 및 Windows) 내에서 완전 오프라인으로 원본 DOOM 쉐어웨어(1993)를 실행 | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Doom-1.0.0.ablx) | [🏗️ 소스](extensions/doom) |
| Duplicate Track | 0.0.7 | 클립을 복사하지 않고 트랙을 복제 | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Duplicate-Track-0.0.7.ablx) | [🏗️ 소스](extensions/duplicate-track) |
| Freesound Sampler | 1.1.3 | Freesound.org를 검색하고 사운드를 트랙으로 직접 다운로드 | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Freesound-Sampler-1.1.3.ablx) | [🏗️ 소스](extensions/freesound-sampler) |
| Session to Arrangement Bridge | 0.0.8 | 모든 세션 뷰 클립을 완전한 충실도로 어레인지먼트 뷰로 전송. *⚠️ 확장 README 파일의 현재 알려진 제한 사항을 반드시 읽어주세요.* | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Session-to-Arrangement-Bridge-0.0.8.ablx) | [🏗️ 소스](extensions/session-arrangement-bridge) |
| Snake | 0.0.7 | Live 내에서 스네이크 게임을 플레이하고 게임플레이를 MIDI 클립으로 변환 | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Snake-0.0.7.ablx) | [🏗️ 소스](extensions/snake) |
| Track Creator | 0.0.6 | 간단한 대화상자에서 여러 개의 오디오 또는 MIDI 트랙을 한 번에 생성 | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Track-Creator-0.0.6.ablx) | [🏗️ 소스](extensions/track-creator) |
| Transpose Clips | 0.1.0 | Live 세트 내 모든 MIDI 클립을 선택한 반음 수만큼 전조 | [⬇️ 다운로드](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Transpose-Clips-0.1.0.ablx) | [🏗️ 소스](extensions/transposer) |

✨ *가장 최근 업데이트됨*

---

# 변경 로그

## 2026년 6월 28일

### Basic Pitch 1.0.3
- **불확정 진행 바** — 전사 중 진행 바가 멈추지 않고 불확정 모드로 애니메이션화됩니다. TF.js CPU 추론은 동기 방식이며 Node의 단일 스레드를 차단하므로 고정 백분율은 추론 완료 전까지 업데이트되지 않았습니다.

## 2026년 6월 15일

### Freesound Sampler 1.1.3
- **Inspire Me** — **Inspire Me** 클릭 시 임의 검색어를 선택하여 예상치 못한 사운드를 즉시 발견
- **OAuth 로그인** - 워크플로우 개선. API 키 필드 제거.

## 2026년 6월 12일

### Freesound Sampler 1.0.0
- **OAuth 로그인** — 확장에서 Freesound 계정으로 직접 로그인; 수동 API 키 불필요
- **원본 품질 다운로드** — 로그인 시 MP3 미리보기 대신 원본 형식(WAV, FLAC, AIFF 등)으로 사운드 다운로드
- **저작자 표시 도우미** — 저작자 표시 뷰에서 불러온 사운드를 크레딧 복사 한 번으로 목록화
- **고급 검색 필터** — 음색 설명자(밝기, 따뜻함, 거침 등), 키, BPM, 지속시간, 라이선스 등으로 필터링

## 2026년 6월 9일

### Bird Game 1.1.0
- **Windows 지원** — 이제 macOS와 Windows 모두에서 실행 가능

### Doom 1.0.0
- **Windows 지원** — 이제 macOS와 Windows 모두에서 실행 가능 (Glau [@glaurossi](https://github.com/glaurossi) 감사합니다)
- **완전 오프라인** — 모든 게임 자산 번들 포함; 인터넷 연결 불필요

## 2026년 6월 7일

### Basic Pitch 1.0.0
- **윈도우 지원** — [@jwfeniello](https://github.com/jwfeniello) 덕분에 macOS 및 Windows 완전 크로스 플랫폼 지원
- **번들 모델** — ML 모델이 완전히 로컬에서 실행; 데이터가 기기를 벗어나지 않음
- **안정성 수정** — 호스트 크래시 및 압축 오디오 샘플 처리 문제 수정

## 2026년 6월 1일

### 초기 공개 버전
- **Bird Game 1.0.0** — 플래피 버드에서 영감을 받은 게임으로 실행을 MIDI 클립으로 변환
- **Doom** — Ableton Live 내에서 실행되는 원본 DOOM Shareware(1993), 새 SDK로 이전됨
- **Arrangement Helper**, **Basic Pitch**, **Chord Progression Helper**, **Chord Voicing Helper**, **ChromaFlux**, **Duplicate Track**, **Freesound Sampler**, **Session to Arrangement Bridge**, **Snake**, **Track Creator**, **Transpose Clips** — 첫 공개 버전

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-12

---