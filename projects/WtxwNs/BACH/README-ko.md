<p align="center">
  <img src="https://raw.githubusercontent.com/WtxwNs/BACH/main/tokenpair.png" width="85%"/>
  <br><br>
  <i>BACH가 원시 토큰을 구조화된 음악으로 단계별로 변환하는 과정을 지켜보세요.</i>
</p>

# BACH: 마디 단위 AI 작곡 도우미  

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

&gt; *"악보에서 연주로: 마디 단위 기호 표기를 통한 효율적 인간 제어 장시간 곡 생성"*  
&gt; ICASSP 2026 제출 – **검토 중**

---

## 🎼 한 문장 요약  
BACH는 최초의 **인간이 편집 가능한**, **마디 단위** 기호 기반 곡 생성기입니다:  
LLM이 가사를 작성 → Transformer가 ABC 악보 생성 → 기존 렌더러가 **분 단위, Suno 수준**의 음악 생성.  
**1B 파라미터**, **분 단위** 추론, **최신 공개 소스**.

---

## 📦 이 저장소에 포함된 내용 (미리보기 버전)
| 경로 | 설명 |
|------|-------------|
| `README.md` | 이 파일 |
| `code/` | 추론 코드 |
| `example.mp3` | 예제 곡 |
| `fig/` | 아키텍처 도표 |

---
## 🏗️ 모델 아키텍처 (한눈에 보기)

사용자 프롬프트  
Qwen3 — 가사 및 스타일 태그  
BACH-1B 디코더 전용 트랜스포머  
ABC 점수 (Dual-NTP + 체인-오브-스코어)  
ABC → MIDI → FluidSynth + VOCALOID  
스테레오 믹스  


| 구성 요소 | 핵심 아이디어 |  
|-----------|--------------|  
| **Dual-NTP** | 매 스텝마다 `{vocal_patch, accomp_patch}`를 공동 예측 |  
| **체인-오브-스코어** | 긴 일관성을 위한 섹션 태그 `[START:Chorus] ... [END:Chorus]` |  
| **마디-스트림 패치** | 마디당 16자 비중첩 패치 |  

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---