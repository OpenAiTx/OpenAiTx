
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## 플로우 매칭을 통한 빠르고 고품질의 제로샷 텍스트-음성 변환
</div>

## 개요

ZipVoice는 flow matching 기반의 빠르고 고품질의 zero-shot TTS 모델 시리즈입니다.

### 1. 주요 특징

- 작고 빠름: 123M 파라미터만 사용합니다.

- 고품질 음성 복제: 화자 유사도, 명료성, 자연스러움에서 최첨단 성능.

- 다국어 지원: 중국어와 영어 지원.

- 다중 모드: 단일 화자 및 대화 음성 생성 모두 지원.

### 2. 모델 변형

<table>
  <thead>
    <tr>
      <th>모델 이름</th>
      <th>설명</th>
      <th>논문</th>
      <th>데모</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>중국어와 영어 모두에서 zero-shot 단일 화자 TTS를 지원하는 기본 모델입니다.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoice의 속도를 개선한 distilled 버전으로, 성능 저하를 최소화했습니다.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoice 기반의 대화 생성 모델로, 단일 채널의 양방향 음성 대화를 생성할 수 있습니다.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialog의 스테레오 버전으로, 각 화자가 개별 채널에 할당되어 2채널 대화 생성을 지원합니다.</td>
    </tr>
  </tbody>
</table>

## 소식

**2025/07/14**: 두 개의 음성 대화 생성 모델인 **ZipVoice-Dialog** 및 **ZipVoice-Dialog-Stereo**가 출시되었습니다. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: 6.8k시간 분량의 음성 대화 데이터셋인 **OpenDialog**가 공개되었습니다. 다운로드: [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). 자세한 내용은 [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) 참고.

**2025/06/16**: **ZipVoice** 및 **ZipVoice-Distill**이 출시되었습니다. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## 설치

### 1. ZipVoice 저장소 클론하기

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (선택 사항) 파이썬 가상 환경 만들기


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. 필요한 패키지 설치하기


```bash
pip install -r requirements.txt
```
### 4. 학습 또는 효율적인 추론을 위해 k2 설치하기

**k2는 학습에 필수적**이며 추론 속도를 높일 수 있습니다. 하지만 k2를 설치하지 않아도 ZipVoice의 추론 모드는 사용할 수 있습니다.

> **참고:**  사용하는 PyTorch 및 CUDA 버전에 맞는 k2 버전을 설치해야 합니다. 예를 들어, pytorch 2.5.1과 CUDA 12.1을 사용 중이라면, 다음과 같이 k2를 설치할 수 있습니다.


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
자세한 내용은 https://k2-fsa.org/get-started/k2/ 를 참조하십시오.
중국 본토 사용자는 https://k2-fsa.org/zh-CN/get-started/k2/ 를 참조할 수 있습니다.

- k2 설치를 확인하려면:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## 사용법

### 1. 단일 화자 음성 생성

사전 학습된 ZipVoice 또는 ZipVoice-Distill 모델을 사용하여 단일 화자 음성을 생성하려면 다음 명령어를 사용하십시오(HuggingFace에서 필요한 모델이 다운로드됩니다):

#### 1.1 단일 문장 추론


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name`은 `zipvoice` 또는 `zipvoice_distill`이 될 수 있으며, 각각 증류 전과 증류 후의 모델을 의미합니다.
- 텍스트에 `<>` 또는 `[]`가 나타나면, 그 안에 포함된 문자열은 특수 토큰으로 처리됩니다. `<>`는 중국어 병음을, `[]`는 기타 특수 태그를 나타냅니다.

#### 1.2 문장 리스트 추론

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- `test.tsv`의 각 라인은 `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}` 형식입니다.

### 2. 대화 음성 생성

#### 2.1 추론 명령

사전 학습된 ZipVoice-Dialogue 또는 ZipVoice-Dialogue-Stereo 모델로 양자 대화 음성을 생성하려면 다음 명령어를 사용하세요(필요한 모델은 HuggingFace에서 다운로드됩니다):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name`은 `zipvoice_dialog` 또는 `zipvoice_dialog_stereo`일 수 있으며,
    각각 모노 및 스테레오 대화를 생성합니다.

#### 2.2 입력 형식

`test.tsv`의 각 행은 다음 형식 중 하나입니다:

(1) 두 화자의 오디오 및 전사 내용을 하나의 프롬프트 wav 파일로 병합한
    **병합 프롬프트 형식**:
```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name`는 출력 wav 파일의 이름입니다.
- `prompt_transcription`은 대화형 프롬프트 wav의 전사본입니다. 예: "[S1] 안녕하세요. [S2] 어떻게 지내세요?"
- `prompt_wav`는 프롬프트 wav의 경로입니다.
- `text`는 합성할 텍스트입니다. 예: "[S1] 잘 지내요. [S2] 이름이 뭐예요? [S1] 에릭이에요. [S2] 안녕하세요, 에릭."

(2) **분할 프롬프트 형식**에서는 두 화자의 오디오와 전사본이 각각의 파일에 존재합니다:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```

- `wav_name`는 출력 wav 파일의 이름입니다.
- `spk1_prompt_transcription`은 첫 번째 화자의 프롬프트 wav의 전사문입니다. 예: "Hello"
- `spk2_prompt_transcription`은 두 번째 화자의 프롬프트 wav의 전사문입니다. 예: "How are you?"
- `spk1_prompt_wav`는 첫 번째 화자의 프롬프트 wav 파일 경로입니다.
- `spk2_prompt_wav`는 두 번째 화자의 프롬프트 wav 파일 경로입니다.
- `text`는 합성할 텍스트입니다. 예: "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 더 나은 사용을 위한 안내:

#### 3.1 프롬프트 길이

단일 화자 음성 생성의 경우 3초 미만, 대화 음성 생성의 경우 10초 미만의 짧은 프롬프트 wav 파일을 권장합니다. 짧은 프롬프트는 추론 속도를 빠르게 합니다. 너무 긴 프롬프트는 추론을 느리게 하고 음성 품질을 저하시킬 수 있습니다.

#### 3.2 속도 최적화

추론 속도가 만족스럽지 않다면 다음과 같이 속도를 높일 수 있습니다:

- **모델 경량화 및 스텝 수 감소**: 단일 화자 음성 생성 모델에서는 기본적으로 더 나은 음성 품질을 위해 `zipvoice` 모델을 사용합니다. 속도가 더 중요하다면 `zipvoice_distill`로 전환하고 `--num-steps`를 최소 `4`(기본값 8)까지 줄일 수 있습니다.

- **CPU 다중 스레드로 속도 향상**: CPU에서 실행 시, `--num-thread` 파라미터(예: `--num-thread 4`)를 설정하면 더 빠른 속도를 위해 스레드 수를 늘릴 수 있습니다. 기본값은 1개 스레드입니다.

- **ONNX로 CPU 속도 향상**: CPU에서 실행 시, `zipvoice.bin.infer_zipvoice_onnx`로 ONNX 모델을 사용하면 더 빠른 속도를 얻을 수 있습니다(아직 대화 생성 모델은 ONNX 지원하지 않음). 더 빠른 속도를 원한다면 `--onnx-int8 True`로 INT8 양자화 ONNX 모델을 사용할 수 있습니다. 단, 양자화 모델은 음성 품질이 다소 저하될 수 있습니다. **GPU에서는 ONNX를 사용하지 마세요**, GPU에서는 PyTorch보다 느립니다.

#### 3.3 메모리 제어

입력된 텍스트는 구두점(단일 화자 음성 생성) 또는 화자 전환 기호(대화 음성 생성)를 기준으로 청크로 분할됩니다. 이후, 청크된 텍스트들은 배치로 처리됩니다. 따라서 모델은 거의 일정한 메모리 사용량으로 매우 긴 텍스트도 처리할 수 있습니다. `--max-duration` 파라미터를 조정하여 메모리 사용량을 제어할 수 있습니다.

#### 3.4 "Raw" 평가

기본적으로 효율적인 추론과 더 나은 성능을 위해 입력(프롬프트 wav, 프롬프트 전사, 텍스트)을 전처리합니다. 논문의 결과를 재현하거나 정확히 제공된 입력으로 모델의 "raw" 성능을 평가하고자 한다면, `--raw-evaluation True`를 전달하면 됩니다.

#### 3.5 짧은 텍스트

매우 짧은 텍스트(예: 한두 단어) 음성을 생성할 때, 생성된 음성이 특정 발음을 생략하는 경우가 있을 수 있습니다. 이 문제를 해결하려면 `--speed 0.3`(0.3은 조정 가능한 값)을 전달하여 생성된 음성의 길이를 늘릴 수 있습니다.

#### 3.6 중국어 다음자(다음음자) 발음 교정

중국어 문자를 pinyin으로 변환하기 위해 [pypinyin](https://github.com/mozillazg/python-pinyin)을 사용합니다. 그러나 **다음자(다음음자)**(多音字)를 때때로 잘못 발음할 수 있습니다.

이러한 잘못된 발음을 수동으로 수정하려면 **수정된 병음**을 꺾쇠 괄호 `< >`로 감싸고 **성조 표시**를 포함하세요.

**예시:**

- 원본 텍스트: `这把剑长三十公分`
- `长`의 병음을 수정:  `这把剑<chang2>三十公分`

> **참고:** 여러 병음을 수동으로 지정하려면 각각의 병음을 `<>`로 감싸세요. 예: `这把<jian4><chang2><san1>十公分`

#### 3.7 생성된 음성에서 긴 침묵 제거

모델은 생성된 음성에서 침묵의 위치와 길이를 자동으로 결정합니다. 때때로 음성 중간에 긴 침묵이 포함될 수 있습니다. 이를 원하지 않을 경우, 중간의 긴 침묵을 제거하려면 `--remove-long-sil`을 사용하세요(가장자리 침묵은 기본적으로 제거됩니다).

#### 3.8 모델 다운로드

사전 학습된 모델을 다운로드할 때 HuggingFace 연결에 문제가 있다면, 엔드포인트를 미러 사이트로 변경해보세요: `export HF_ENDPOINT=https://hf-mirror.com`.

## 직접 모델 학습하기

학습, 미세조정 및 평가 예시는 [egs](egs) 디렉터리를 참고하세요.

## C++ 배포

CPU에서 C++ 배포 솔루션은 [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498)를 확인하세요.

## 토론 및 소통

[Github Issues](https://github.com/k2-fsa/ZipVoice/issues)에서 직접 토론할 수 있습니다.

QR 코드를 스캔하여 위챗 그룹에 가입하거나 공식 위챗 계정을 팔로우할 수도 있습니다.

| 위챗 그룹 | 위챗 공식 계정 |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## 인용

```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---