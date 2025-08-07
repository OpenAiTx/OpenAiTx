# SongGen: 텍스트-투-송 생성용 단일 단계 오토리그레시브 트랜스포머

🚀🚀🚀 **SongGen: 텍스트-투-송 생성용 단일 단계 오토리그레시브 트랜스포머**의 공식 구현  
<p align="center" style="font-size: 1 em; margin-top: -1em">
<a href="https://scholar.google.com/citations?user=iELd-Q0AAAAJ">Zihan Liu</a>,  
<a href="https://mark12ding.github.io/">Shuangrui Ding</a>,  
<a href="https://github.com/rookiexiong7/">Zhixiong Zhang</a>, 
<a href="https://lightdxy.github.io/">Xiaoyi Dong</a>,  
<a href="https://panzhang0212.github.io/">Pan Zhang</a>,
<a href="https://yuhangzang.github.io/">Yuhang Zang</a>,  
<a href="https://scholar.google.com/citations?user=sJkqsqkAAAAJ">Yuhang Cao</a>, </br>  
<a href="http://dahua.site/">Dahua Lin</a>,  
<a href="https://myownskyw7.github.io/">Jiaqi Wang</a> 
</p>

<p align="center" style="font-size: 5 em; margin-top: 0.5em">
<a href="https://arxiv.org/abs/2502.13128"><img src="https://img.shields.io/badge/arXiv-<color>"></a>
<a href="https://github.com/LiuZH-19/SongGen"><img src="https://img.shields.io/badge/Code-red"></a>
<a href="https://liuzh-19.github.io/SongGen/"><img src="https://img.shields.io/badge/Demo-20d67c"></a>
<a href="https://huggingface.co/collections/LiuZH-19/songgen-a-single-stage-auto-regressive-transformer-for-text-6867ec21169d808034f6d252">
    <img src="https://img.shields.io/badge/HF-Collection-yellow"></a>
</p>





## 📜 뉴스
🚀 [2025/7/4] 자세한 [학습 가이드](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/./training/README.md)와 함께 학습 코드를 공개했습니다.

🚀 [2025/6/30] MusicCaps 테스트 세트가 텍스트-투-송 평가를 위해 [Huggingface🤗](https://huggingface.co/datasets/LiuZH-19/MusicCaps_Test_Song)에서 이용 가능합니다.

🚀 [2025/6/27] SongGen Interleaving (A-V) 체크포인트를 [Huggingface🤗](https://huggingface.co/LiuZH-19/SongGen_interleaving_A_V)에서 공개했습니다.

🎉 [2025/5/1] SongGen이 ICML 2025에 채택되었습니다!

🚀 [2025/3/18] SongGen Mixed_Pro 체크포인트를 [Huggingface🤗](https://huggingface.co/LiuZH-19/SongGen_mixed_pro)에서 공개했습니다.

🚀 [2025/2/19] [논문](https://arxiv.org/abs/2502.13128)과 [데모 페이지](https://liuzh-19.github.io/SongGen/)를 공개했습니다!

## 💡 주요 내용
- 🔥가사, 설명 텍스트, 선택적 참조 음성을 통한 다양한 제어를 제공하는 **단일 단계** 오토리그레시브 트랜스포머 기반의 **텍스트-투-송** 생성기 SongGen을 소개합니다.
- 🔥SongGen은 다양한 요구 사항에 맞게 **혼합 모드**와 **듀얼 트랙 모드**를 모두 지원합니다. 실험을 통해 두 모드 최적화에 대한 **소중한 인사이트**를 제공합니다.
- 🔥**모델 가중치**, **코드**, **주석 데이터**, **전처리 파이프라인**을 공개하여 향후 노래 생성 연구를 위한 간단하면서도 효과적인 기준을 마련하는 것을 목표로 합니다.
<!-- <img align="center" src="https://raw.githubusercontent.com/LiuZH-19/SongGen/master/assets/imgs/motivation1.jpg" style="  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 50%;" /> -->

## 👨‍💻 할 일
- [ ] 주석 데이터 및 전처리 파이프라인 공개
- [x] Musiccaps 테스트 세트 공개
- [x] SongGen 학습 코드 공개
- [x] SongGen (Interleaving A-V) 체크포인트 공개
- [x] SongGen Mixed_pro 체크포인트 공개
- [x] SongGen 추론 코드 공개
- [x] SongGen 데모 공개

## 🛠️ 사용법

### 1. 환경 및 의존성 설치
```bash
git clone https://github.com/LiuZH-19/SongGen.git
cd SongGen
# We recommend using conda to create a new environment.
conda create -n songgen_env python=3.9.18 
conda activate songgen_env
# Install CUDA >= 11.8 and PyTorch, e.g.,
pip install torch==2.3.0 torchvision==0.18.0 torchaudio==2.3.0 --index-url https://download.pytorch.org/whl/cu118
pip install flash-attn==2.6.1 --no-build-isolation
```
추론 모드에서만 SongGen을 사용하려면 다음을 사용하여 설치하십시오:
```bash
pip install -e .
```
### 2. xcodec 다운로드

[🤗](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/
https://huggingface.co/ZhenYe234/xcodec/blob/main/xcodec_hubert_general_audio_v2.pth)에서 X-Codec 체크포인트를 다운로드하고 다음 디렉토리에 배치하세요 : SongGen/songgen/xcodec_wrapper/xcodec_infer/ckpts/general_more

```
xcodec_infer
    ├── ckpts
    │   └── general_more
    │       ├── config_hubert_general.yaml
    │       └── xcodec_hubert_general_audio_v2.pth

```

### 3. 추론 실행

#### (1). 혼합 프로 모드

```python
import torch
import os
from songgen import (
    VoiceBpeTokenizer,
    SongGenMixedForConditionalGeneration,
    SongGenProcessor
)
import soundfile as sf

ckpt_path = "LiuZH-19/SongGen_mixed_pro" # Path to the pretrained model
device = "cuda:0" if torch.cuda.is_available() else "cpu"
model = SongGenMixedForConditionalGeneration.from_pretrained(
    ckpt_path,
    attn_implementation='sdpa').to(device)
processor = SongGenProcessor(ckpt_path, device)

# Define input text and lyrics
lyrics = "..." # The lyrics text
text = "..." # The music description text
ref_voice_path = 'path/to/your/reference_audio.wav' # Path to reference audio, optional
separate= True # Whether to separate the vocal track from the reference voice audio

model_inputs = processor(text=text, lyrics=lyrics, ref_voice_path=ref_voice_path, separate=separate) 
generation = model.generate(**model_inputs,
                do_sample=True,
            )
audio_arr = generation.cpu().numpy().squeeze()
sf.write("songgen_out.wav", audio_arr, model.config.sampling_rate)
```



#### (2). Interleaving A-V  (Dual-track mode)
```python
import torch
import os
from songgen import (
    VoiceBpeTokenizer,
    SongGenDualTrackForConditionalGeneration,
    SongGenProcessor
)
import soundfile as sf

ckpt_path = "LiuZH-19/SongGen_interleaving_A_V" # Path to the pretrained model
device = "cuda:0" if torch.cuda.is_available() else "cpu"
model = SongGenDualTrackForConditionalGeneration.from_pretrained(
    ckpt_path,
    attn_implementation='sdpa').to(device)
processor = SongGenProcessor(ckpt_path, device)

# Define input text and lyrics
lyrics = "..." # The lyrics text
text = "..." # The music description text
ref_voice_path = 'path/to/your/reference_audio.wav' # Path to reference audio, optional
separate= True # Whether to separate the vocal track from the reference voice audio

model_inputs = processor(text=text, lyrics=lyrics, ref_voice_path=ref_voice_path, separate=True) 
generation = model.generate(**model_inputs,
                do_sample=True,
            )

acc_array = generation[0].cpu().numpy()
vocal_array = generation[1].cpu().numpy()
min_len =min(vocal_array.shape[0], acc_array.shape[0])
acc_array = acc_array[:min_len]
vocal_array = vocal_array[:min_len]
audio_arr = vocal_array + acc_array
sf.write("songgen_out.wav", audio_arr, model.config.sampling_rate)
```
### 4. Training

[training 폴더](./training)에는 자신의 SongGen 모델을 학습하거나 미세 조정하는 데 필요한 모든 정보가 포함되어 있습니다. 단계별 지침은 [training 가이드](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/./training/README.md)를 참조하세요.



## ❤️ 감사의 말
이 라이브러리는 여러 오픈소스 거인들 위에 구축되었으며, 이 도구들을 제공해 주신 모든 분들께 진심으로 감사드립니다!

특별 감사:

- [Parler-tts](https://github.com/huggingface/parler-tts): 우리가 기반으로 삼은 코드베이스입니다. 
- [X-Codec](https://github.com/zhenye234/xcodec): 연구에 활용된 오디오 코덱입니다.
- [lp-music-caps](https://github.com/seungheondoh/lp-music-caps): 음악 캡션 생성 프로젝트입니다. 

지금까지 받은 모든 지원에 깊이 감사드립니다.

## ☎️ 한계점 및 향후 과제

이것은 **텍스트-투-송** 생성에 중점을 둔 **연구 작업**입니다. 현재 학습 데이터셋의 한계로 인해, 우리 모델은 현재 최대 30초 길이의 영어 노래 생성에만 제한됩니다.
하지만 **2천 시간** 분량의 데이터와 **1.3B** 파라미터 모델로 학습했음에도 불구하고, 우리의 접근법은 일관성 있고 표현력 있는 노래 생성에 강력한 효과와 유망한 가능성을 보여주고 있습니다. 데이터와 모델 크기를 확장하면 가사 정렬 및 음악성이 더욱 향상될 것이라 믿습니다.
그렇지만 데이터셋 확장은 시간과 노력이 많이 드는 작업입니다. 모델 개선 및 기능 확장을 위한 새로운 방법을 탐색하는 협업과 논의를 환영합니다.
문의나 협업 제안은 언제든지 연락해 주세요: Zihan Liu (liuzihan@pjlab.org.cn) 및 Jiaqi Wang (wangjiaqi@pjlab.org.cn).

## ✒️ 인용
본 연구가 도움이 되셨다면 별 ⭐ 과 인용 📝을 부탁드립니다.

```bibtex
@misc{liu2025songgen,
      title={SongGen: A Single Stage Auto-regressive Transformer for Text-to-Song Generation}, 
      author={Zihan Liu and Shuangrui Ding and Zhixiong Zhang and Xiaoyi Dong and Pan Zhang and Yuhang Zang and Yuhang Cao and Dahua Lin and Jiaqi Wang},
      year={2025},
      eprint={2502.13128},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2502.13128}, 
}

```







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---