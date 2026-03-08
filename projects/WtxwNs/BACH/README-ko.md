
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=WtxwNs&project=BACH&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>BACH가 어떻게 원시 토큰을 구조화된 음악으로 바꾸는지—단계별로 확인하세요.</i>
</p>

# BACH: 마디 단위 AI 작곡 보조 도구
<p align="center">
  <a href="https://arxiv.org/abs/2508.01394">
    <img src="https://img.shields.io/badge/arXiv-2508.01394-b31b1b.svg" alt="arXiv"/>
  </a>
  <a href="https://github.com/WtxwNs/BACH/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/WtxwNs/BACH" alt="License"/>
  </a>
  <img src="https://img.shields.io/github/repo-size/WtxwNs/BACH" alt="Repo Size"/>
  <img src="https://img.shields.io/github/stars/WtxwNs/BACH?style=social" alt="Stars"/>
</p>

&gt; *"Score to Performance를 통한: 바 단위 심볼릭 표기법으로 효율적인 인간 제어 가능한 장곡 생성"*  
&gt; ICASSP 2026 제출 – **채택됨**

---

## 🎼 한 줄 요약  
BACH는 최초의 **인간 편집 가능**, **바 단위** 심볼릭 송 생성기입니다:  
LLM이 가사를 작성 → 트랜스포머가 ABC 악보 출력 → 기존 렌더러로 **수 분 길이, Suno 수준** 음악 생성.  
**1 B 파라미터**, **분 단위** 추론, **SOTA 오픈소스**.

---

## 📦 이 저장소에 포함된 내용 (미리보기 버전)
| 경로 | 설명 |
|------|-------------|
| `README.md` | 이 파일 |
| `code/` | 추론 코드 |
| `example.mp3` | 예시 노래 |
| `fig/` | 아키텍처 그림 |

---

## 🏗️ 모델 아키텍처 (한눈에 보기)

사용자 프롬프트
Qwen3 — 가사 & 스타일 태그
BACH-1B 디코더 전용 트랜스포머
ABC 악보 (Dual-NTP + Chain-of-Score)

ABC → MIDI → FluidSynth + VOCALOID
스테레오 믹스


| 구성 요소 | 핵심 아이디어 |
|-----------|--------------|
| **Dual-NTP** | `{vocal_patch, accomp_patch}`를 매 단계마다 공동 예측 |
| **Chain-of-Score** | 긴 일관성을 위한 섹션 태그 `[START:Chorus] ... [END:Chorus]` |
| **Bar-stream patch** | 바마다 16자 비중첩 패치 |

---

## 🧪 빠른 시작 (CPU 친화적)
```bash
# 1. Clone
git clone https://github.com/your-github/BACH.git
cd BACH

# 2. Install
pip install -r requirements.txt        # transformers>=4.41 mido abcpy fluidsynth

# 3. Generate ABC
python bach/generate.py \
    --prompt "A rainy-day lo-fi hip-hop song about missing the last train" \
    --out_abc demo/rainy_lofi.abc

# 4. Render audio
```
##  🎧 지금 듣기
example.mp3가 준비되었습니다, 전체 노래입니다. Suno와 비교할 수 있습니다🙂

## 관련 논문 승인 시 전체 공개
- 완전한 학습 세트 (ABC + 가사 + 구조 레이블)
- BACH-1B 가중치 (트랜스포머 형식)
- 학습 스크립트 (다단계 + 다중작업 + ICL)
- 완전한 코드

## 📎 인용
논문이 Arxiv에 공개되었습니다, 

```bibtex
@misc{wang2025scoreperformanceefficienthumancontrollable,
      title={스코어를 통한 성능: 마디 단위 기호 표기를 사용한 효율적이고 인간 조절 가능한 긴 곡 생성}, 
      author={Tongxi Wang and Yang Yu and Qing Wang and Junlang Qian},
      year={2025},
      eprint={2508.01394},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2508.01394}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---