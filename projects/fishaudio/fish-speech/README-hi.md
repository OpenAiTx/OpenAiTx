<div align="center">
<h1>Fish Speech</h1>

**English** | [简体中文](docs/README.zh.md) | [Portuguese](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

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
> **लाइसेंस सूचना**  
> यह कोडबेस **Apache License** के अंतर्गत जारी किया गया है और सभी मॉडल वेट्स **CC-BY-NC-SA-4.0 License** के अंतर्गत जारी किए गए हैं। अधिक जानकारी के लिए कृपया [LICENSE](LICENSE) देखें।

> [!WARNING]
> **कानूनी अस्वीकरण**  
> कोडबेस के किसी भी अवैध उपयोग के लिए हम कोई जिम्मेदारी नहीं लेते। कृपया अपने स्थानीय DMCA और अन्य संबंधित कानूनों का पालन करें।

---

## 🎉 घोषणा

हमें यह घोषणा करते हुए खुशी हो रही है कि हमने अब **OpenAudio** के रूप में रीब्रांड किया है — यह एक क्रांतिकारी नई श्रृंखला है, जिसमें उन्नत Text-to-Speech मॉडल शामिल हैं, जो Fish-Speech की नींव पर आधारित हैं।

हमें गर्व है कि हमने इस श्रृंखला का पहला मॉडल **OpenAudio-S1** जारी किया है, जिसमें गुणवत्ता, प्रदर्शन और क्षमताओं में महत्वपूर्ण सुधार हैं।

OpenAudio-S1 दो संस्करणों में आता है: **OpenAudio-S1** और **OpenAudio-S1-mini**। दोनों मॉडल अब [Fish Audio Playground](https://fish.audio) (के लिए **OpenAudio-S1**) और [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (के लिए **OpenAudio-S1-mini**) पर उपलब्ध हैं।

ब्लॉग और टेक रिपोर्ट के लिए [OpenAudio वेबसाइट](https://openaudio.com/blogs/s1) देखें।

## मुख्य विशेषताएँ ✨

### **उत्कृष्ट TTS गुणवत्ता**

हम मॉडल प्रदर्शन का मूल्यांकन करने के लिए Seed TTS Eval Metrics का उपयोग करते हैं, और परिणाम दिखाते हैं कि OpenAudio S1 अंग्रेज़ी पाठ पर **0.008 WER** और **0.004 CER** प्राप्त करता है, जो पिछले मॉडलों से काफी बेहतर है। (अंग्रेज़ी, ऑटो मूल्यांकन, OpenAI gpt-4o-transcribe के आधार पर, स्पीकर डिस्टेंस Revai/pyannote-wespeaker-voxceleb-resnet34-LM द्वारा)

| मॉडल | वर्ड एरर रेट (WER) | कैरेक्टर एरर रेट (CER) | स्पीकर डिस्टेंस |
|-------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **TTS-Arena2 में सर्वश्रेष्ठ मॉडल** 🏆

OpenAudio S1 ने [TTS-Arena2](https://arena.speechcolab.org/) पर **#1 रैंकिंग** प्राप्त की है, जो टेक्स्ट-टू-स्पीच मूल्यांकन के लिए मानक है:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **स्पीच कंट्रोल**

OpenAudio S1 **भाषण संश्लेषण को बेहतर बनाने के लिए विभिन्न भावनाओं, टोन और स्पेशल मार्कर का समर्थन करता है**:

- **मूल भावनाएँ**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **उन्नत भावनाएँ**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **टोन मार्कर**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **विशेष ऑडियो इफेक्ट्स**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

आप Ha,ha,ha जैसे कंट्रोल भी प्रयोग कर सकते हैं, और भी कई तरीके हैं जिन्हें आप खुद एक्सप्लोर कर सकते हैं।

(अभी अंग्रेज़ी, चीनी और जापानी के लिए समर्थन है, और जल्द ही और भाषाओं का समर्थन आएगा!)

### **दो प्रकार के मॉडल**

| मॉडल | आकार | उपलब्धता | विशेषताएँ |
|-------|------|--------------|----------|
| **S1** | 4B पैरामीटर्स | [fish.audio](fish.audio) पर उपलब्ध | फुल-फीचर्ड फ्लैगशिप मॉडल |
| **S1-mini** | 0.5B पैरामीटर्स | huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) पर उपलब्ध | कोर क्षमताओं वाला डिस्टिल्ड संस्करण |

S1 और S1-mini दोनों में ऑनलाइन रिइन्फोर्समेंट लर्निंग फ्रॉम ह्यूमन फीडबैक (RLHF) शामिल है।

## **विशेषताएँ**

1. **ज़ीरो-शॉट और फ्यू-शॉट TTS:** 10 से 30 सेकंड का वोकल सैंपल इनपुट करें और उच्च गुणवत्ता का TTS आउटपुट प्राप्त करें। **विस्तृत दिशानिर्देशों के लिए देखें [Voice Cloning Best Practices](https://docs.fish.audio/text-to-speech/voice-clone-best-practices)।**

2. **मल्टी-लिंगुअल और क्रॉस-लिंगुअल समर्थन:** मल्टी-लिंगुअल टेक्स्ट को इनपुट बॉक्स में कॉपी-पेस्ट करें—भाषा की चिंता करने की ज़रूरत नहीं। वर्तमान में अंग्रेज़ी, जापानी, कोरियाई, चीनी, फ्रेंच, जर्मन, अरबी और स्पेनिश का समर्थन।

3. **कोई फोनीम निर्भरता नहीं:** मॉडल में मजबूत सामान्यीकरण क्षमताएँ हैं और TTS के लिए फोनीम पर निर्भर नहीं है। यह किसी भी भाषा की लिपि में टेक्स्ट को संभाल सकता है।

4. **अत्यधिक सटीक:** Seed-TTS Eval के लिए लगभग 0.4% CER (कैरेक्टर एरर रेट) और लगभग 0.8% WER (वर्ड एरर रेट) प्राप्त करता है।

5. **तेज़:** फिश-टेक एक्सेलेरेशन के साथ, Nvidia RTX 4060 लैपटॉप पर रियल-टाइम फैक्टर लगभग 1:5 और Nvidia RTX 4090 पर 1:15 है।

6. **WebUI इनफेरेंस:** उपयोग में आसान, Gradio-आधारित वेब UI, Chrome, Firefox, Edge और अन्य ब्राउज़रों के साथ संगत।

7. **GUI इनफेरेंस:** एक PyQt6 ग्राफिकल इंटरफ़ेस प्रदान करता है जो API सर्वर के साथ सहजता से काम करता है। Linux, Windows, और macOS समर्थित। [GUI देखें](https://github.com/AnyaCoder/fish-speech-gui)।

8. **डिप्लॉय-फ्रेंडली:** Linux, Windows (MacOS जल्द आ रहा है) के लिए नेटिव समर्थन के साथ इनफेरेंस सर्वर आसानी से सेटअप करें, स्पीड लॉस न्यूनतम।

## **मीडिया और डेमो**

<div align="center">

### **सोशल मीडिया**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **इंटरएक्टिव डेमो**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **वीडियो प्रदर्शन**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **ऑडियो सैंपल**
<div style="margin: 20px 0;">
    <em> उच्च गुणवत्ता के ऑडियो सैंपल जल्द ही उपलब्ध होंगे, जो विभिन्न भाषाओं और भावनाओं में हमारी मल्टी-लिंगुअल TTS क्षमताओं का प्रदर्शन करेंगे।</em>
</div>

</div>

---

## दस्तावेज़

- [बिल्ड एनवायरनमेंट](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [इनफेरेंस](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## श्रेय

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## टेक रिपोर्ट (V1.4)
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