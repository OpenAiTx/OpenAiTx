# GOT-OCR-2-GUI

## [영문 버전 보기](https://raw.githubusercontent.com/XJF2332/GOT-OCR-2-GUI/main/README-en.md)

🛑지원 중단, 이후는 자유 업데이트

![img.png](https://raw.githubusercontent.com/XJF2332/GOT-OCR-2-GUI/main/img.png)

## 이 프로젝트에 대하여

모델 가중치: [미러 사이트](https://hf-mirror.com/stepfun-ai/GOT-OCR2_0), [원 사이트](https://huggingface.co/stepfun-ai/GOT-OCR2_0)  
원 GitHub: [GOT-OCR2.0](https://github.com/Ucas-HaoranWei/GOT-OCR2.0/)  
이 프로젝트는 Windows에서 개발되었으며, 저는 Linux를 사용해본 적이 없고 사용할 줄도 몰라서 Linux에서 정상적으로 작동할지 보장할 수 없습니다. 만약 Linux에 배포하려면 이 [이슈](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/3)를 참고하세요.  
일부 코드는 다음에서 가져왔습니다: [GLM4](https://chatglm.cn/main/alltoolsdetail?lang=zh), [Deepseek](https://www.deepseek.com/)

별점 한 번 눌러주세요

## 할 일

- [x] 로그 내용 현지화
- [ ] 새로운 모델 stepfun-ai/GOT-OCR-2.0-hf 지원
- [ ] PDF 관련 오류 처리 로직 최적화
- [x] GGUF 모델 지원, 추론 가속 희망 (도움 주신 [이슈 #19](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/19) 감사합니다)
- [ ] GGUF 모델 지원 보완
- [x] 새로운 렌더링 모드: 성능 최적화, 더 많은 포맷 출력 지원
- [ ] 구버전 렌더러 제거/숨김

## 사용 방법

여기에 언급된 폴더가 없다면 **새로 만드세요**

### 브랜치 선택

#### Alpha

가장 빠르게 업데이트되는 브랜치로 최신 변경사항이 모두 이 브랜치에 반영됩니다.  
코드는 때때로 테스트되지 않은 상태일 수 있습니다.  
매우 불안정하며 때로는 사용할 수 없을 수도 있습니다.


#### main

비교적 안정적인 브랜치이지만 일부 새로운 기능이 누락될 수 있습니다.

### 의존성

이 환경은 **python 3.11.9**에서 테스트되어 정상 작동함을 확인하였습니다.

#### torch

[torch 공식 홈페이지](https://pytorch.org/get-started/locally/)에서 자신의 **GPU 버전**에 맞는 torch를 설치하면 됩니다.  
저는 이전에 Stable 2.4.1 + cu124를 사용했습니다.  
현재는 Stable 2.0.1 + cu118을 사용 중이며, `1 Torch is not compiled with Flash Attention` 문제를 해결할 수 있었고, 다른 문제는 발견하지 못했습니다.

#### PyMuPDF

실제로 `requirements.txt`에서 바로 설치하면 `ModuleNotFoundError: No module named 'frontend'` 오류가 발생하지만, 개별 설치 시에는 발생하지 않습니다. 구체적인 원인은 불분명합니다.  
또한, 여전히 `ModuleNotFoundError`가 발생하면 `fitz`와 `PyMuPDF`를 먼저 제거한 후 다시 설치하면 해결되는 경우가 있습니다. 실제로 `pip install -U PyMuPDF`는 효과가 없습니다.



```commandline
pip install fitz
pip install PyMuPDF
```
#### `pip` 사용법으로 설치하기


```commandline
pip install -r requirements.txt
```
또한, 누군가 `requirements.txt`로 의존성을 설치할 때 충돌 문제가 발생했다고 했지만, 저는 여기서 문제를 발견하지 못했습니다. `pipdeptree`도 아무 충돌 항목을 표시하지 않았고, `requirements.txt`는 제 가상 환경에서 `pip freeze`로 직접 생성한 것이므로 원칙적으로 문제가 없어야 합니다.  
하지만 실제로 이런 문제가 발생했기에, 버전 번호가 없는 `requirements-noversion.txt`를 추가로 제공하니 한번 시도해 보시기 바랍니다.  
자세한 내용은 이 [issue #4](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/4)를 참조하세요.



```commandline
pip install -r requirements-noversion.txt
```
#### 기타

- [Edge WebDriver](https://developer.microsoft.com/zh-cn/microsoft-edge/tools/webdriver/?form=MA13LH#downloads)
  , 압축 파일을 다운로드하여 `edge_driver` 폴더에 넣으세요

> 여러분의 컴퓨터에는 아마도 edge가 있을 거예요? 있겠죠? 이건 기본으로 설치되어 있거든요...  
> 파일 구조는 대략 다음과 같아야 합니다:
> ```
> GOT-OCR-2-GUI
> └─edge_driver
>    ├─msedgedriver.exe
>    └─...
> ```

### 모델 파일 다운로드

아래 모델 중 하나만 있어도 OCR 실행이 가능하지만, 자동 모델 로드를 사용하려면 `Safetensors` 모델이 필요합니다  
GGUF 모델 지원은 아직 완벽하지 않으니, 현재는 GGUF 탭에서 별도로 체험할 수 있습니다

#### Safetensors

1. `models` 폴더에 다운로드하세요  
2. 파일 다운로드를 빠뜨리지 마세요  
3. 새로운 `GOT-OCR-2-HF` 모델(현재 지원 미완성)은 `models-hf` 폴더에 다운로드하세요(현재는 지원이 추가되어 있지 않습니다)

- 파일 구조는 대략 다음과 같아야 합니다:


```
GOT-OCR-2-GUI
└─models
   ├─config.json
   ├─generation_config.json
   ├─got_vision_b.py
   ├─model.safetensors
   ├─modeling_GOT.py
   ├─qwen.tiktoken
   ├─render_tools.py
   ├─special_tokens_map.json
   ├─tokenization_qwen.py
   └─tokenizer_config.json
```
#### GGUF

GGUF 모델은 `got.cpp`에서 지원합니다  
`MosRat/got.cpp` 저장소에서 모델을 다운로드하세요, `Encode.onnx`는 `gguf\Encoder.onnx`에 넣고, 나머지 Decoder GGUF 모델은 `gguf\decoders`에 넣으세요

### 시작하기

1. 커맨드 라인을 사용하려면 `CLI.py`를 사용하세요  
2. 그래픽 인터페이스를 사용하려면 `GUI.py`를 사용하세요  
3. 설정을 수정하려면 `Config Manager.py`를 사용하세요  
4. 자동 렌더링 작업을 실행하려면 `Renderer.py`를 사용하세요, 이 스크립트는 `imgs` 폴더 내의 모든 `.jpg`와 `.png` 이미지를 자동으로 렌더링합니다

> GUI 사용자라면 신경 쓸 필요 없지만, CLI를 사용하는 분들은 OCR 대상 이미지를 `imgs` 폴더에 넣으세요 (현재 CLI는 `.jpg`와 `.png` 파일만 인식합니다)

## 로컬라이제이션 지원

- `Locales` 폴더에서 다양한 언어의 `.json` 파일을 찾을 수 있으며, CLI와 GUI의 언어 파일은 별도로 저장됩니다  
- `gui` 하위 폴더에는 `언어.json` 파일 외에도 `instructions` 폴더가 있는데, 여기에는 GUI 내장 튜토리얼인 `언어.md` 파일이 들어 있습니다  
- 언어 지원을 변경하려면 `config.json`의 `'language'` 값을 수정하면 됩니다. 사용 가능한 값은 `언어.json` 파일 이름에서 확장자를 뺀 이름입니다  
- 새로운 언어 지원을 추가하려면 CLI에서는 새로운 `언어.json` 파일만 추가하면 됩니다 (기존 파일을 템플릿으로 사용하는 것을 강력히 권장합니다). GUI에서는 대응하는 `언어.md` 파일도 추가해야 합니다  
- `Config Manager.py`를 사용하여 언어 및 기타 설정 파일을 관리할 수 있습니다

## 주의 사항

- 스크립트가 갑자기 종료된다면 `cmd`에서 `python +파일명`으로 실행해 보세요. 저도 테스트 중에 갑작스러운 종료 현상을 경험했으며 원인을 모르겠습니다  
- `result` 폴더 내의 `markdown-it.js` 파일은 삭제하지 마세요, 삭제하면 PDF 내보내기에 오류가 발생합니다!

> 만약 실수로 삭제했다면 `scripts` 폴더에서 백업본을 찾아 복사해 오면 됩니다

- `torch`는 GPU 버전을 설치했는지 확인하세요, 스크립트에서 `device_map='cuda'`를 사용합니다

## 자주 묻는 질문

- Q：CLI.py: error: the following arguments are required: --path/-P  
- A：PowerShell을 사용하세요, CMD에서는 이 버그가 발생하는데 원인을 아직 찾지 못했습니다  
---  
- Q：“HTML 로컬 파일”이란 무엇인가요? 로컬에 저장되지 않은 HTML 파일도 있나요?  
- A：모델이 출력하는 HTML 파일은 로컬에 저장되지만 외부 스크립트를 사용하기 때문에, 파일이 로컬에 있어도 네트워크가 필요합니다. 그래서 앞서 말한 외부 스크립트를 다운로드해서 포함시켰습니다


  `mardown-it.js`입니다. 이렇게 하는 주된 이유는 네트워크 문제로 인한 PDF 내보내기 실패를 방지하기 위함입니다.
---
- Q：왜 내 모델이 로드되지 않나요?
- A：파일이 누락되었는지 확인하세요. 바이두 클라우드에서 다운로드한 모델 파일은 일부 파일이 누락된 경우가 있으니, 앞서 언급한 Huggingface에서 다운로드할 것을 권장합니다.
---
- Q：이 프로젝트를 배포하는 데 조언이 있나요?
- A：이 [이슈 #5](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/5)를 참고하세요.
---
- Q：도움말 문서는 어디서 볼 수 있나요?
- A：GUI 사용자의 경우 `설명` 탭에서 찾을 수 있고, CLI 사용자는 `.\CLI.py --help`를 통해 argparse가 자동 생성한 도움말 문서를 볼 수 있으며, `.\CLI.py --detailed-help`를 통해 더 자세한 도움말 문서도 확인할 수 있습니다.

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=XJF2332/GOT-OCR-2-GUI&type=Date)](https://star-history.com/#XJF2332/GOT-OCR-2-GUI&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-12

---