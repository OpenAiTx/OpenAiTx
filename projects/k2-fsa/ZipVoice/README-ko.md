<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">영어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">일본어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">힌디어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">태국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">프랑스어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">독일어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">스페인어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">이탈리아어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">러시아어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">포르투갈어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">네덜란드어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">폴란드어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">아랍어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">페르시아어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">터키어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">베트남어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">인도네시아어</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## 플로우 매칭 기반의 빠르고 고품질의 제로샷 텍스트-투-스피치
</div>

## 개요

ZipVoice는 플로우 매칭을 기반으로 한 빠르고 고품질의 제로샷 TTS 모델 시리즈입니다.

### 1. 주요 특징

- 작고 빠름: 1억 2300만 파라미터만 사용.

- 고품질 음성 클로닝: 화자 유사성, 명료성, 자연스러움에서 최첨단 성능.

- 다국어 지원: 중국어와 영어 지원.

- 다중 모드 지원: 단일 화자 및 대화체 음성 생성 모두 지원.

### 2. 모델 변형

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
      <td>중국어와 영어 모두에서 제로샷 단일 화자 TTS를 지원하는 기본 모델입니다.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoice의 디스틸 버전으로, 성능 저하를 최소화하면서 속도를 개선했습니다.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoice 기반의 대화 생성 모델로, 단일 채널 2인 대화 음성 생성을 지원합니다.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialog의 스테레오 버전으로, 각 화자가 별도의 채널에 할당된 2채널 대화 생성을 지원합니다.</td>
    </tr>
  </tbody>
</table>

## 소식

**2025/07/14**: **ZipVoice-Dialog**와 **ZipVoice-Dialog-Stereo**, 두 가지 음성 대화 생성 모델이 공개되었습니다. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: **OpenDialog** 데이터셋(6.8k 시간 분량의 대화 음성 데이터셋) 공개. 다운로드: [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). 자세한 내용은 [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) 참고.

**2025/06/16**: **ZipVoice** 및 **ZipVoice-Distill** 모델 공개. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## 설치

### 1. ZipVoice 저장소 클론


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


```
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
- `wav_name` 은 출력 wav 파일의 이름입니다.  
- `prompt_transcription` 은 대화형 프롬프트 wav의 전사이며, 예를 들어 "[S1] 안녕하세요. [S2] 어떻게 지내세요?" 입니다.  
- `prompt_wav` 는 프롬프트 wav의 경로입니다.  
- `text` 는 합성할 텍스트이며, 예를 들어 "[S1] 저는 괜찮아요. [S2] 이름이 뭐에요?" 입니다.  

(2) **분리된 프롬프트 형식**으로, 두 화자의 오디오와 전사가 별도의 파일에 존재합니다:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name`은 출력 wav 파일의 이름입니다.
- `spk1_prompt_transcription`은 첫 번째 화자의 프롬프트 wav의 전사본입니다. 예: "Hello"
- `spk2_prompt_transcription`은 두 번째 화자의 프롬프트 wav의 전사본입니다. 예: "How are you?"
- `spk1_prompt_wav`는 첫 번째 화자의 프롬프트 wav 파일 경로입니다.
- `spk2_prompt_wav`는 두 번째 화자의 프롬프트 wav 파일 경로입니다.
- `text`는 합성할 텍스트입니다. 예: "[S1] I'm fine. [S2] What's your name?"

### 3. 기타 기능

#### 3.1 중국어 다음자(다음음절자) 발음 오류 교정

중국어 문자를 [pypinyin](https://github.com/mozillazg/python-pinyin)으로 병음으로 변환합니다. 하지만, 가끔 **다음자(多音字)**의 발음을 잘못 인식할 수 있습니다.

이러한 발음 오류를 수동으로 교정하려면, **교정된 병음**을 꺾쇠 괄호 `< >`로 감싸고 **성조**를 포함하세요.

**예시:**

- 원본 텍스트: `这把剑长三十公分`
- `长`의 병음을 교정:  `这把剑<chang2>三十公分`

> **참고:** 여러 병음을 수동으로 지정하려면 각 병음을 `<>`로 감싸세요. 예: `这把<jian4><chang2><san1>十公分`

## 사용자 모델 학습

학습, 파인튜닝, 평가 예시는 [egs](egs) 디렉토리를 참고하세요.

## 토론 및 소통

[Github Issues](https://github.com/k2-fsa/ZipVoice/issues)에서 직접 토론할 수 있습니다.

또한 QR 코드를 스캔하여 위챗 그룹에 참여하거나 공식 위챗 계정을 팔로우할 수 있습니다.

| 위챗 그룹 | 위챗 공식 계정 |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## 인용 안내


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---