# RefineAnything

**완벽한 국부 디테일을 위한 멀티모달 영역별 정교화**

<a href="https://limuloo.github.io/RefineAnything/"><img src="https://img.shields.io/badge/Project-Page-blue" /></a>
<a href="https://arxiv.org/abs/2604.06870"><img src="https://img.shields.io/badge/arXiv-2604.06870-b31b1b" /></a>
<a href="https://github.com/limuloo/RefineAnything"><img src="https://img.shields.io/badge/GitHub-Code-black?logo=github" /></a>
<a href="https://huggingface.co/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Checkpoint-yellow?logo=huggingface" /></a>
<a href="https://huggingface.co/spaces/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Space-orange?logo=huggingface" /></a>
<a href="https://github.com/smthemex/ComfyUI_RefineAnything"><img src="https://img.shields.io/badge/ComfyUI-Plugin-green?logo=github" /></a>

RefineAnything은 **영역별 이미지 정교화**를 목표로 합니다: 입력 이미지와 사용자가 지정한 영역(예: 스크리블 마스크 또는 바운딩 박스)을 받아, 텍스트, 로고, 얇은 구조물 등 세밀한 디테일을 복원하면서 **편집되지 않은 픽셀은 모두 유지**합니다. 참조 이미지 기반과 참조 이미지 없는 정교화를 모두 지원합니다.

![Teaser](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/teaser.png)
---

## 뉴스
- **2026-04-21** — **환경 버전 고정 업데이트.** 최상의 결과(및 색상 변화 방지)를 위해 `requirement.txt`에 고정된 정확한 버전: `diffusers==0.36.0`, `transformers==4.55.0`, `safetensors==0.5.3`, `peft==0.17.0`를 사용하세요. 시각적 비교는 아래 [환경 안내](#environment-notice)를 참고하세요.
- **2026-04-21** — **허깅페이스 스페이스 환경 수정 완료.** 온라인 데모가 올바른 의존성 버전에서 실행되어 정교화 결과가 현저히 향상되었습니다: <https://huggingface.co/spaces/limuloo1999/RefineAnything>.
- **2026-04-14** — 커뮤니티 ComfyUI 통합 by [@smthemex](https://github.com/smthemex): [ComfyUI_RefineAnything](https://github.com/smthemex/ComfyUI_RefineAnything). 훌륭한 작업 감사합니다!
- **2026-04-14** — 대화형 테스트용 로컬 Gradio 데모(`app.py`) 제공.
- **2026-04-12** — 허깅페이스 스페이스 데모 오픈: <https://huggingface.co/spaces/limuloo1999/RefineAnything>.
- **2026-04-09** — 허깅페이스에 체크포인트 공개: <https://huggingface.co/limuloo1999/RefineAnything>.
- **2026-04-09** — 추론 스크립트 공개.
- **2026-04-08** — 문서 초안 추가; **이번 달 중 코드 공개 예정** (추론 스크립트, 환경, 체크포인트가 여기에 링크됩니다).
- **미정** — 체크포인트 및 학습/평가 리소스는 확정되는 대로 공지 예정.

---

## 주요 특징

- **영역 정확 정교화** — 명확한 영역 신호(스크리블 또는 박스)가 편집을 목표 영역으로 유도합니다.
- **참조 기반 및 비참조 정교화** — 선택적 참조 이미지로 국부 디테일 복원을 안내합니다.
- **엄격한 배경 보존** — 편집은 목표 영역 내에 한정되며, 경계의 자연스러움에 중점을 두어 학습합니다.

---

## 비교

![참조 없는 정성적 비교](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_free.png)

![Reference-based qualitative comparisons](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_reference.png)

---

## Installation

```bash
pip install -r requirement.txt
```
> **중요 — 이 버전을 정확히 고정하세요.** RefineAnything은 기본 라이브러리의 작은 버전 차이에 민감합니다. 아래 버전을 **정확히** 설치해 주세요; 최신 또는 구버전을 사용할 경우 정제된 영역에서 색상 왜곡과 같은 눈에 띄는 아티팩트가 발생할 수 있습니다.
>
> ```
> diffusers==0.36.0
> transformers==4.55.0
> safetensors==0.5.3
> peft==0.17.0
> ```

---

## 환경 안내

`diffusers` / `transformers` / `safetensors` / `peft` 버전이 맞지 않으면, 다른 조건이 동일해도 정제된 영역에서 **색상 왜곡**이 발생할 수 있음을 확인했습니다. 아래 예시는 *"remove the hand"* 프롬프트를 사용했습니다:

<table>
<tr>
<td align="center"><b>입력 (마스크 영역 = 손)</b></td>
<td align="center"><b>올바른 환경</b></td>
<td align="center"><b>잘못된 환경 (색상 왜곡)</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/env_check_input.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/correct_env_result.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/wrong_env_result.png" width="100%"></td>
</tr>
</table>

출력 결과에서 마스크 내부의 색상/톤이 약간 맞지 않고 나머지 부분이 정상이라면, 가장 먼저 패키지 버전을 확인해 보세요.

---

## 빠른 시작

RefineAnything 실행에 필요한 것은 단 **세 가지**입니다:

| 인자 | 설명 |
|----------|-------------|
| `--input` | 원본 이미지 |

| `--mask` | 이진 마스크 (흰색 = 세밀하게 다듬을 영역) |
| `--prompt` | 다듬을 내용 |
| `--ref` | *(선택 사항)* 가이드 정제를 위한 참조 이미지 |

---

### 데모 1 — 참조 기반 로고 정제

참조 이미지를 사용하여 베개 위의 흐릿한 로고를 정제합니다.

```bash
python scripts/fast_inference.py \
    --input  src/input1.png \
    --mask   src/mask1.png \
    --prompt "Refine the LOGO." \
    --ref    src/ref1.png \
    --output output/demo1.png
```
<table>
<tr>
<td align="center"><b>입력</b></td>
<td align="center"><b>참고 이미지</b></td>
<td align="center"><b>프롬프트</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_input_zoom.jpg" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/src/ref1.png" width="100%"></td>
<td><i>"로고를 정제하세요."</i></td>
</tr>
<tr>
<td align="center" colspan="3"><b>출력</b></td>
</tr>
<tr>
<td colspan="3"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

### 데모 2 — 참고 이미지 없이 텍스트 정제

건물 간판의 흐릿한 중국어 텍스트를 정제합니다 — 참고 이미지가 필요 없습니다.


```bash
python scripts/fast_inference.py \
    --input  src/input2.png \
    --mask   src/mask2.png \
    --prompt "refine the text '鼎好商城'" \
    --output output/demo2.png
```
<table>
<tr>
<td align="center"><b>입력</b></td>
<td align="center"><b>프롬프트</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_input_zoom.jpg" width="100%"></td>
<td><i>"텍스트 '鼎好商城' 다듬기"</i></td>
</tr>
<tr>
<td align="center" colspan="2"><b>출력</b></td>
</tr>
<tr>
<td colspan="2"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

## 로컬 그라디오 데모

인터랙티브 테스트를 위해 그라디오 기반 웹 UI도 제공합니다. 브러시로 영역을 지정하고, 참조 이미지를 업로드하며, 모든 추론 파라미터를 브라우저에서 조정할 수 있습니다.


```bash
python app.py
```

그런 다음 브라우저에서 `http://localhost:7860`을 엽니다. 앱은 첫 실행 시 자동으로 기본 모델(`Qwen/Qwen-Image-Edit-2511`)과 Hugging Face에서 RefineAnything LoRA를 다운로드합니다.

`MODEL_DIR` 환경 변수를 통해 사용자 지정 기본 모델 경로를 지정할 수 있습니다:

```bash
MODEL_DIR=/path/to/local/Qwen-Image-Edit-2511 python app.py
```

**Gradio 데모의 특징:**
- **브러시 선택**: 원본 이미지에 직접 그려서 세부 조정 영역을 정의합니다.
- **선택적 참조 이미지**: 두 번째 이미지를 업로드하고 선택적으로 브러시로 특정 참조 영역을 자를 수 있습니다.
- **포커스 크롭**: 편집 영역을 자동으로 자르고 확대하여 더 높은 세부 충실도를 제공한 후 원활하게 합성합니다.
- **라이트닝 LoRA**: 더 적은 단계로 빠른 추론을 위한 원클릭 토글 기능.
- **전후 슬라이더**: 입력과 출력을 즉시 비교할 수 있습니다.

---

## 인용

이 저장소를 사용할 경우, 다음을 인용해 주십시오:

```bibtex
@article{zhou2026refineanything,
  title={RefineAnything: Multimodal Region-Specific Refinement for Perfect Local Details},
  author={Zhou, Dewei and Li, You and Yang, Zongxin and Yang, Yi},
  journal={arXiv preprint arXiv:2604.06870},
  year={2026}
}
```

---

## 감사의 글 및 라이선스

RefineAnything은 광범위한 확산 및 멀티모달 생태계(예: **Qwen2.5-VL**, **Qwen-Image**, 그리고 **VAE** + **MMDiT**를 사용한 잠재 확산)에서 아이디어와 구성 요소를 기반으로 합니다. 기본 모델 가중치 및 API 조건은 각각의 라이선스에 따르며—**체크포인트 또는 파생 가중치를 재배포하기 전에 준수 여부를 확인하세요**.

레포지토리 **코드 라이선스**: *미정* (예: Apache-2.0 또는 MIT)—구현을 오픈소스로 공개할 때 `LICENSE`를 설정하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---