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
> **Informacja o licencji**  
> Ten kod jest udostępniany na licencji **Apache License**, a wszystkie wagi modeli są udostępniane na licencji **CC-BY-NC-SA-4.0**. Zapoznaj się z [LICENSE](LICENSE) po więcej szczegółów.

> [!WARNING]
> **Zastrzeżenie prawne**  
> Nie ponosimy odpowiedzialności za jakiekolwiek nielegalne wykorzystanie tego kodu. Sprawdź lokalne przepisy dotyczące DMCA i innych powiązanych ustaw.

---

## 🎉 Ogłoszenie

Z radością informujemy, że dokonaliśmy rebrandingu na **OpenAudio** — prezentując rewolucyjną, nową serię zaawansowanych modeli zamiany tekstu na mowę, które rozwijają osiągnięcia Fish-Speech.

Z dumą ogłaszamy wydanie **OpenAudio-S1** jako pierwszego modelu z tej serii, oferującego znaczące ulepszenia jakości, wydajności i możliwości.

OpenAudio-S1 występuje w dwóch wersjach: **OpenAudio-S1** oraz **OpenAudio-S1-mini**. Oba modele są już dostępne na [Fish Audio Playground](https://fish.audio) (dla **OpenAudio-S1**) oraz na [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (dla **OpenAudio-S1-mini**).

Odwiedź [stronę OpenAudio](https://openaudio.com/blogs/s1), aby przeczytać bloga i raport techniczny.

## Najważniejsze cechy ✨

### **Doskonała jakość TTS**

Używamy Seed TTS Eval Metrics do oceny wydajności modelu, a wyniki pokazują, że OpenAudio S1 osiąga **0.008 WER** oraz **0.004 CER** dla tekstów angielskich, co jest znacząco lepsze od poprzednich modeli. (Angielski, auto eval, na bazie OpenAI gpt-4o-transcribe, odległość mówcy z użyciem Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| Model | Word Error Rate (WER) | Character Error Rate (CER) | Speaker Distance |
|-------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **Najlepszy model na TTS-Arena2** 🏆

OpenAudio S1 uzyskał **1. miejsce** na [TTS-Arena2](https://arena.speechcolab.org/), będącym benchmarkiem dla oceny systemów TTS:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **Kontrola mowy**

OpenAudio S1 **obsługuje różne emocje, ton oraz specjalne markery** pozwalające wzbogacić syntezę mowy:

- **Podstawowe emocje**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **Zaawansowane emocje**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **Markery tonu**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **Specjalne efekty dźwiękowe**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Możesz także użyć Ha,ha,ha do sterowania, jest wiele innych przypadków do samodzielnego odkrycia.

(Obecnie obsługiwane języki: angielski, chiński i japoński; więcej już wkrótce!)

### **Dwa typy modeli**

| Model | Rozmiar | Dostępność | Funkcje |
|-------|--------|------------|---------|
| **S1** | 4B parametrów | Dostępny na [fish.audio](fish.audio) | Pełnofunkcyjny model flagowy |
| **S1-mini** | 0,5B parametrów | Dostępny na huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | Wersja zdystylowana, z podstawowymi funkcjami |

Zarówno S1, jak i S1-mini wykorzystują online Reinforcement Learning from Human Feedback (RLHF).

## **Funkcje**

1. **Zero-shot & Few-shot TTS:** Wprowadź 10–30 sekundowy próbkę głosu, aby wygenerować wysokiej jakości mowę TTS. **Szczegółowe wskazówki znajdziesz w [Voice Cloning Best Practices](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Obsługa wielu języków i języków krzyżowych:** Po prostu skopiuj i wklej tekst w różnych językach do pola wejściowego — nie musisz się martwić językiem. Obecnie obsługiwane: angielski, japoński, koreański, chiński, francuski, niemiecki, arabski i hiszpański.

3. **Brak zależności od fonemów:** Model ma silne zdolności generalizacyjne i nie opiera się na fonemach w TTS. Radzi sobie z tekstem zapisanym w dowolnym alfabecie.

4. **Wysoka dokładność:** Osiąga niski współczynnik błędów znaków (CER) na poziomie ok. 0,4% oraz współczynnik błędów słów (WER) ok. 0,8% dla Seed-TTS Eval.

5. **Szybkość:** Dzięki akceleracji fish-tech, współczynnik czasu rzeczywistego wynosi około 1:5 na laptopie z Nvidia RTX 4060 i 1:15 na Nvidia RTX 4090.

6. **WebUI Inference:** Łatwy w użyciu interfejs webowy oparty na Gradio, kompatybilny z Chrome, Firefox, Edge i innymi przeglądarkami.

7. **GUI Inference:** Oferuje graficzny interfejs PyQt6 działający bezproblemowo z serwerem API. Obsługuje Linux, Windows i macOS. [Zobacz GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **Przyjazny wdrożeniom:** Łatwe uruchamianie serwera inferencyjnego z natywną obsługą Linux i Windows (MacOS wkrótce), minimalizując utratę prędkości.

## **Media i dema**

<div align="center">

### **Social Media**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **Interaktywne dema**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **Prezentacje wideo**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Próbki audio**
<div style="margin: 20px 0;">
    <em> Wkrótce dostępne będą wysokiej jakości próbki audio, prezentujące nasze możliwości wielojęzycznego TTS w różnych językach i emocjach.</em>
</div>

</div>

---

## Dokumentacja

- [Środowisko budowy](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Inferencja](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Podziękowania

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Raport techniczny (V1.4)
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