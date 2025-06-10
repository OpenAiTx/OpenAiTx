<div align="center">
<h1>Fish Speech</h1>

**English** | [简体中文](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/README.zh.md) | [Portuguese](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/README.pt-BR.md) | [日本語](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/README.ja.md) | [한국어](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/README.ko.md) <br>

<a href="https://www.producthunt.com/posts/fish-speech-1-4?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-fish&#0045;speech&#0045;1&#0045;4" target="_blank">
    <img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=488440&theme=light" alt="Fish&#0032;Speech&#0032;1&#0046;4 - Open&#0045;Source&#0032;Multilingual&#0032;Text&#0045;to&#0045;Speech&#0032;with&#0032;Voice&#0032;Cloning | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" />
</a>
<a href="https://trendshift.io/repositories/7014" target="_blank">
    <img src="https://trendshift.io/api/badge/repositories/7014" alt="fishaudio%2Ffish-speech | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/>
</a>
<br>
</div>
<br>

<div align="center">
    <img src="https://count.getloli.com/get/@fish-speech?theme=asoul" /><br>
</div>

<br>

<div align="center">
    <a target="_blank" href="https://discord.gg/Es5qTB9BcN">
        <img alt="Discord" src="https://img.shields.io/discord/1214047546020728892?color=%23738ADB&label=Discord&logo=discord&logoColor=white&style=flat-square"/>
    </a>
    <a target="_blank" href="https://hub.docker.com/r/fishaudio/fish-speech">
        <img alt="Docker" src="https://img.shields.io/docker/pulls/fishaudio/fish-speech?style=flat-square&logo=docker"/>
    </a>
    <a target="_blank" href="https://pd.qq.com/s/bwxia254o">
      <img alt="QQ Channel" src="https://img.shields.io/badge/QQ-blue?logo=tencentqq">
    </a>
</div>

<div align="center">
    <a target="_blank" href="https://huggingface.co/spaces/TTS-AGI/TTS-Arena-V2">
      <img alt="TTS-Arena2 Score" src="https://img.shields.io/badge/TTS_Arena2-Rank_%231-gold?style=flat-square&logo=trophy&logoColor=white">
    </a>
    <a target="_blank" href="https://huggingface.co/spaces/fishaudio/fish-speech-1">
        <img alt="Huggingface" src="https://img.shields.io/badge/🤗%20-space%20demo-yellow"/>
    </a>
    <a target="_blank" href="https://huggingface.co/fishaudio/openaudio-s1-mini">
        <img alt="HuggingFace Model" src="https://img.shields.io/badge/🤗%20-models-orange"/>
    </a>
</div>

> [!IMPORTANT]
> **라이선스 안내**  
> 이 코드베이스는 **Apache License**로 배포되며, 모든 모델 가중치는 **CC-BY-NC-SA-4.0 License**로 공개됩니다. 자세한 내용은 [LICENSE](https://raw.githubusercontent.com/fishaudio/fish-speech/main/LICENSE)를 참고하세요.

> [!WARNING]
> **법적 고지**  
> 본 코드베이스의 불법적 사용에 대한 책임은 일체 지지 않습니다. DMCA 및 기타 관련 법률에 대해 반드시 해당 지역의 법을 준수하세요.

---

## 🎉 공지사항

저희는 **OpenAudio**로 리브랜딩되었음을 기쁘게 알립니다. Fish-Speech의 기반 위에 혁신적인 차세대 고성능 텍스트-투-스피치(TTS) 모델 시리즈를 선보입니다.

시리즈의 첫 모델인 **OpenAudio-S1**을 출시했습니다. 품질, 성능, 기능 면에서 크게 향상되었습니다.

OpenAudio-S1은 두 가지 버전(**OpenAudio-S1**, **OpenAudio-S1-mini**)으로 제공되며, 각각 [Fish Audio Playground](https://fish.audio) (**OpenAudio-S1**)와 [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (**OpenAudio-S1-mini**)에서 사용하실 수 있습니다.

블로그 및 기술 보고서는 [OpenAudio 웹사이트](https://openaudio.com/blogs/s1)에서 확인하세요.

## 주요 특징 ✨

### **우수한 TTS 품질**

Seed TTS 평가 지표를 통해 모델 성능을 평가하였으며, OpenAudio S1은 영어 텍스트에서 **0.008 WER**와 **0.004 CER**를 달성했습니다. 이는 기존 모델보다 현저히 우수한 결과입니다. (영어, 자동 평가, OpenAI gpt-4o-transcribe 기반, 화자 거리 측정에 Revai/pyannote-wespeaker-voxceleb-resnet34-LM 사용)

| 모델 | 단어 오류율(WER) | 문자 오류율(CER) | 화자 거리 |
|-------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **TTS-Arena2 최고 모델** 🏆

OpenAudio S1은 텍스트-투-스피치 벤치마크인 [TTS-Arena2](https://arena.speechcolab.org/)에서 **1위**를 차지했습니다:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **음성 제어**

OpenAudio S1은 **다양한 감정, 어조, 특수 마커**를 지원하여 음성 합성의 표현력을 높입니다:

- **기본 감정**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **고급 감정**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **어조 마커**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **특수 음향 효과**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Ha,ha,ha 등 다양한 제어도 사용할 수 있으며, 더 많은 활용 사례가 기다리고 있습니다.

(현재 영어, 중국어, 일본어 지원, 더 많은 언어가 곧 추가될 예정입니다!)

### **두 가지 모델 타입**

| 모델 | 크기 | 배포처 | 특징 |
|-------|------|--------------|----------|
| **S1** | 40억 파라미터 | [fish.audio](https://fish.audio)에서 사용 가능 | 모든 기능을 갖춘 플래그십 모델 |
| **S1-mini** | 5억 파라미터 | huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini)에서 사용 가능 | 핵심 기능만 추출한 경량화 버전 |

S1과 S1-mini 모두 온라인 인간 피드백 강화학습(RLHF)을 도입했습니다.

## **주요 기능**

1. **제로샷 & 퓨샷 TTS:** 10~30초 분량의 음성 샘플을 입력하면 고품질 TTS를 생성합니다. **자세한 가이드라인은 [Voice Cloning Best Practices](https://docs.fish.audio/text-to-speech/voice-clone-best-practices)를 참고하세요.**

2. **다국어 & 크로스-링궐 지원:** 입력란에 다국어 텍스트를 붙여넣기만 하면 됩니다. 언어를 신경 쓸 필요가 없습니다. 현재 영어, 일본어, 한국어, 중국어, 프랑스어, 독일어, 아랍어, 스페인어를 지원합니다.

3. **음소 비의존:** 모델은 강력한 일반화 능력을 지니며, TTS에 음소를 필요로 하지 않습니다. 모든 언어의 문자로 입력이 가능합니다.

4. **높은 정확도:** Seed-TTS 평가에서 약 0.4% CER(문자 오류율)과 0.8% WER(단어 오류율)를 달성합니다.

5. **빠른 속도:** fish-tech 가속으로 Nvidia RTX 4060 노트북 기준 약 1:5, RTX 4090 기준 약 1:15의 실시간 비율을 보입니다.

6. **WebUI 추론:** Chrome, Firefox, Edge 등 다양한 브라우저에서 사용할 수 있는 Gradio 기반 웹 UI를 제공합니다.

7. **GUI 추론:** API 서버와 연동되는 PyQt6 기반 그래픽 인터페이스를 제공합니다. Linux, Windows, macOS 지원. [GUI 자세히 보기](https://github.com/AnyaCoder/fish-speech-gui).

8. **배포 친화적:** Linux, Windows(곧 MacOS 지원 예정)에서 네이티브 추론 서버를 손쉽게 구축할 수 있으며, 속도 저하가 최소화됩니다.

## **미디어 & 데모**

<div align="center">

### **소셜 미디어**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **인터랙티브 데모**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **비디오 쇼케이스**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **오디오 샘플**
<div style="margin: 20px 0;">
    <em> 고품질 오디오 샘플이 곧 제공될 예정이며, 다양한 언어와 감정에 대한 다국어 TTS 성능을 시연할 예정입니다.</em>
</div>

</div>

---

## 문서

- [빌드 환경](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [추론](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## 크레딧

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## 기술 보고서 (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
```
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---