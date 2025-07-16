<div align="center">

# ZipVoice⚡

## 플로우 매칭을 이용한 빠르고 고품질의 제로샷 텍스트-투-스피치
</div>

## 개요

ZipVoice는 플로우 매칭을 기반으로 한 빠르고 고품질의 제로샷 TTS 모델 시리즈입니다.

### 1. 주요 특징

- 작고 빠름: 단 1억 2300만 개의 파라미터.

- 고품질 음성 복제: 화자 유사성, 명료성, 자연스러움에서 최첨단 성능.

- 다국어 지원: 중국어와 영어 지원.

- 다중 모드: 단일 화자 및 대화 음성 생성 모두 지원.

### 2. 모델 변종

<table>
  <thead>
    <tr>
      <th>모델명</th>
      <th>설명</th>
      <th>논문</th>
      <th>데모</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>중국어 및 영어에서 제로샷 단일 화자 TTS를 지원하는 기본 모델.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>성능 저하를 최소화하면서 속도를 향상시킨 ZipVoice의 증류 버전.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoice를 기반으로 한 대화 생성 모델로, 단일 채널에서 2자 간 음성 대화 생성 가능.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>각 화자별로 별도의 채널이 할당된 2채널 대화 생성을 지원하는 ZipVoice-Dialog의 스테레오 버전.</td>
    </tr>
  </tbody>
</table>

## 뉴스

**2025/07/14**: 두 개의 음성 대화 생성 모델인 **ZipVoice-Dialog**와 **ZipVoice-Dialog-Stereo**가 공개되었습니다. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: 6.8천 시간 분량의 음성 대화 데이터셋인 **OpenDialog**가 공개되었습니다. 다운로드: [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). 자세한 내용은 [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318)에서 확인하세요.

**2025/06/16**: **ZipVoice**와 **ZipVoice-Distill**이 공개되었습니다. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

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
### 4. (선택 사항) 학습 또는 효율적인 추론을 위해 k2 설치

k2는 학습에 필요하며 추론 속도를 향상시킬 수 있습니다. 그럼에도 불구하고, k2를 설치하지 않고도 ZipVoice의 추론 모드를 사용할 수 있습니다.

> **참고:** 사용 중인 PyTorch 및 CUDA 버전에 맞는 k2 버전을 반드시 설치하세요. 예를 들어, pytorch 2.5.1과 CUDA 12.1을 사용 중이라면 다음과 같이 k2를 설치할 수 있습니다:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
<translate-content>
자세한 내용은 https://k2-fsa.org/get-started/k2/ 를 참조하십시오.  
중국 본토 사용자는 https://k2-fsa.org/zh-CN/get-started/k2/ 를 참조할 수 있습니다.  

## 사용법

### 1. 단일 화자 음성 생성

사전 학습된 ZipVoice 또는 ZipVoice-Distill 모델로 단일 화자 음성을 생성하려면 다음 명령어를 사용하십시오 (필요한 모델은 HuggingFace에서 다운로드됩니다):

#### 1.1 단일 문장 추론
</translate-content>
```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name`은 각각 증류 전과 후의 모델인 `zipvoice` 또는 `zipvoice_distill`일 수 있습니다.  
- 텍스트에 `<>` 또는 `[]`가 나타나면, 그 안에 포함된 문자열은 특수 토큰으로 처리됩니다. `<>`는 중국어 병음을 나타내고, `[]`는 기타 특수 태그를 나타냅니다.  
- `zipvoice.bin.infer_zipvoice_onnx`를 사용하면 CPU에서 ONNX 모델을 더 빠르게 실행할 수 있습니다.  

> **참고:** HuggingFace 연결에 문제가 있을 경우 다음을 시도하세요:  
> ```bash  
> export HF_ENDPOINT=https://hf-mirror.com  
> ```  

#### 1.2 문장 목록의 추론  


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- `test.tsv`의 각 행은 `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}` 형식입니다.

### 2. 음성 대화 생성

#### 2.1 추론 명령어

사전 학습된 ZipVoice-Dialogue 또는 ZipVoice-Dialogue-Stereo 모델을 사용하여 양방향 음성 대화를 생성하려면 다음 명령어를 사용하세요 (필요한 모델은 HuggingFace에서 다운로드됩니다):


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
- `wav_name` 은 출력 wav 파일의 이름입니다.  
- `prompt_transcription` 은 대화형 프롬프트 wav의 전사이며, 예를 들어 "[S1] 안녕하세요. [S2] 어떻게 지내세요?" 입니다.  
- `prompt_wav` 는 프롬프트 wav의 경로입니다.  
- `text` 는 합성할 텍스트이며, 예를 들어 "[S1] 저는 괜찮아요. [S2] 이름이 뭐에요?" 입니다.  

(2) **분리된 프롬프트 형식**으로, 두 화자의 오디오와 전사가 별도의 파일에 존재합니다:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` 은 출력 wav 파일의 이름입니다.
- `spk1_prompt_transcription` 은 첫 번째 화자의 프롬프트 wav 전사본입니다, 예: "Hello"
- `spk2_prompt_transcription` 은 두 번째 화자의 프롬프트 wav 전사본입니다, 예: "How are you?"
- `spk1_prompt_wav` 은 첫 번째 화자의 프롬프트 wav 파일 경로입니다.
- `spk2_prompt_wav` 은 두 번째 화자의 프롬프트 wav 파일 경로입니다.
- `text` 는 합성할 텍스트입니다, 예: "[S1] I'm fine. [S2] What's your name?"

### 3. 기타 기능

#### 3.1 잘못 발음된 중국어 다음소리 문자 수정

우리는 [pypinyin](https://github.com/mozillazg/python-pinyin) 을 사용하여 한자를 병음으로 변환합니다. 하지만 가끔 **다음소리 문자**(多音字)를 잘못 발음할 수 있습니다.

이러한 잘못된 발음을 수동으로 수정하려면, **수정된 병음**을 꺾쇠 괄호 `< >` 안에 넣고 **성조 표시**를 포함하세요.

**예시:**

- 원본 텍스트: `这把剑长三十公分`
- `长`의 병음 수정:  `这把剑<chang2>三十公分`

> **참고:** 여러 개의 병음을 수동으로 지정하려면 각 병음을 `<>`로 감싸세요, 예: `这把<jian4><chang2><san1>十公分`

## 자신만의 모델 훈련하기

훈련 및 미세 조정 예시는 [egs](egs) 디렉토리를 참조하세요.

## 토론 및 소통

직접 [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) 에서 토론할 수 있습니다.

또한 QR 코드를 스캔하여 우리 위챗 그룹에 참여하거나 공식 위챗 계정을 팔로우할 수 있습니다.

| 위챗 그룹 | 위챗 공식 계정 |
| --------- | -------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## 인용문헌


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
<translate-content></translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---