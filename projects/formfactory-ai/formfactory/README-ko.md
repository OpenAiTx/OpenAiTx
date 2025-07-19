<translate-content># FormFactory: 다중 모달 폼 작성 에이전트를 위한 인터랙티브 벤치마킹 스위트

![](https://raw.githubusercontent.com/formfactory-ai/formfactory/main/img/fig1v1_page_1.png)

<p align="center">
  <a href="https://arxiv.org/abs/2506.01520"><img src="https://img.shields.io/badge/arXiv-2506.01520-B31B1B.svg" alt="arXiv"></a>
  &nbsp;
  <a href="https://formfactory-ai.github.io/#demo-video" target="_blank"><img src="https://img.shields.io/badge/Demo-Video-orange.svg" alt="Video Demo"></a>
  &nbsp;
  <a href="https://formfactory-ai.github.io" target="_blank"><img src="https://img.shields.io/badge/Project_Page-Website-blue.svg" alt="Project Page"></a>
</p>

## 📖 개요
온라인 폼 작성은 가장 흔하면서도 가장 노동 집약적인 일상 작업 중 하나입니다. 전통적인 자동화 도구는 보통 규칙 기반 스크립트로, 복잡하고 끊임없이 변화하는 웹 레이아웃에 어려움을 겪습니다. 최근 다중 모달 대형 언어 모델(**MLLMs**)의 부상으로, 연구자들은 "원클릭" 폼 완성을 수행할 수 있는 비전-언어 에이전트를 탐구하기 시작했습니다. 그러나 현재 모델들은 여전히 레이아웃 이해와 필드-값 정렬에서 부족한 점이 있습니다.

**FormFactory**는 다중 모달 폼 작성 에이전트를 위한 고충실도 벤치마크 및 실험 플랫폼을 제공하여 이 격차를 해소합니다. 프로젝트는 다음으로 구성됩니다:

1. 🌐 **웹 프론트엔드** – 8개 도메인(학계, 비즈니스, 금융, 의료 등)에 걸친 실제 시나리오에서 수집한 40개 이상의 고충실도 HTML 폼.
2. 🗄 **데이터셋** –
   • `data1/`에는 각 폼에 대한 JSON **정답**(실제 필드 값)이 포함되어 있습니다.
   • `data2/`는 추가 컨텍스트 또는 프롬프트로 사용할 수 있는 지원 **텍스트 자료**를 저장합니다.
   • `labeled-images/`는 페이지 **스크린샷**과 해당 **bbox 주석**(폴더 A–H별로 구성)을 제공합니다.
3. ⚙️ **백엔드 서비스** – 페이지를 렌더링하고 제출을 수신하며 결과를 자동으로 저장하는 경량 Flask API.
4. 📊 **평가 스크립트** – 필드 수준 및 폼 수준 정확도, 레이아웃 추론 지표 등을 계산하는 유틸리티.

---

## 🚀 빠른 시작

### 1  사전 요구 사항

- Python ≥ 3.8
- Flask == 2.3.*
- 추가 의존성 설치 명령:</translate-content>
  ```bash
  pip install -r requirements.txt
  ```
### 2  저장소 복제하기

```bash
git clone https://github.com/formfactory-ai/formfactory.git
cd formfactory
```
### 3  데모 서버 실행

```bash
python app.py        # default: http://127.0.0.1:5000/
```
브라우저에서 URL을 열고, 대시보드에서 아무 양식을 선택한 후 상호작용을 시작하세요.

---

## 🗂 디렉토리 구조</translate-content>
```text
formfactory/
├─ app.py                # Flask back-end entry point
├─ templates/            # 40+ HTML form templates
├─ static/               # Stylesheets & front-end assets
├─ data/                 # Dataset root
│  ├─ data1/             # Gold answers in JSON format
│  ├─ data2/             # Supporting textual materials
│  └─ labeled-images/    # Screenshots + bbox annotations (A–H)
├─ submission/           # Auto-generated user/model submissions
└─ README.md             # This document
```
---

## ✨ 주요 특징
- **다중 도메인 커버리지** – 학계, 비즈니스, 예술, 기술, 금융, 의료, 법률, 제조 분야 포함.
- **고충실도 페이지** – 시각적 이해 및 현장 현지화 테스트를 위한 현실적인 레이아웃.
- **동적 필드** – 그룹, 반복 섹션, 계단식 종속성 등 다양한 기능.
- **인터랙티브 평가** – 서버를 실행하여 실시간으로 모델 동작 관찰; 결과는 자동 저장.
- **확장 용이** – HTML 템플릿과 JSON 답안 파일만 제공하면 새 양식 추가 가능.

---

## 🧪 평가

![](https://raw.githubusercontent.com/formfactory-ai/formfactory/main/img/systemoverview_page_1.png)


```bash
# 📁 Navigate to evaluation directory
cd eval

# 🔄 Process data with model API
python batch_processor.py A11 json --filename Art_Exhibition_Submission_Form

# 📊 Evaluate model performance  
python evaluator.py --batch

# 📋 View detailed evaluation report
cat evaluation_results/batch_evaluation_*_report.txt
```
---

> [!NOTE]
>
> `model_call.py`에서 API 호출을 완료하고, `evaluator.py`에서 평가를 사용자 정의하세요.

## 📄 라이선스
이 프로젝트는 **MIT 라이선스** 하에 배포됩니다 – 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

---

## 🔗 인용
연구에 FormFactory를 사용하셨다면, 다음을 인용해 주세요:

```bibtex
@misc{li2025formfactoryinteractivebenchmarkingsuite,
  title        = {FormFactory: An Interactive Benchmarking Suite for Multimodal Form-Filling Agents},
  author       = {Bobo Li and Yuheng Wang and Hao Fei and Juncheng Li and Wei Ji and Mong-Li Lee and Wynne Hsu},
  year         = {2025},
  eprint       = {2506.01520},
  archivePrefix= {arXiv},
  primaryClass = {cs.CL},
  url          = {https://arxiv.org/abs/2506.01520}
}
```
행복한 연구 되시고, 함께 멀티모달 양식 작성 에이전트를 발전시켜 나갑시다!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---