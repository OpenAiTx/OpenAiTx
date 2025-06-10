<div align="center">
<h1>Fish Speech</h1>

**Englisch** | [简体中文](docs/README.zh.md) | [Portugiesisch](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

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
> **Lizenzhinweis**  
> Dieser Code ist unter der **Apache License** veröffentlicht und alle Modellgewichte sind unter der **CC-BY-NC-SA-4.0 Lizenz** verfügbar. Weitere Details finden Sie unter [LICENSE](LICENSE).

> [!WARNING]
> **Rechtlicher Hinweis**  
> Wir übernehmen keine Verantwortung für jegliche illegale Nutzung dieses Codes. Bitte beachten Sie die lokalen Gesetze bezüglich DMCA und anderer relevanter Vorschriften.

---

## 🎉 Ankündigung

Wir freuen uns, bekannt zu geben, dass wir jetzt **OpenAudio** heißen — eine revolutionäre neue Serie fortschrittlicher Text-to-Speech-Modelle, die auf Fish-Speech aufbaut.

Wir sind stolz, **OpenAudio-S1** als erstes Modell dieser Serie zu veröffentlichen, das deutliche Verbesserungen bei Qualität, Leistung und Fähigkeiten bietet.

OpenAudio-S1 gibt es in zwei Versionen: **OpenAudio-S1** und **OpenAudio-S1-mini**. Beide Modelle sind jetzt auf dem [Fish Audio Playground](https://fish.audio) (für **OpenAudio-S1**) und auf [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (für **OpenAudio-S1-mini**) verfügbar.

Besuchen Sie die [OpenAudio-Website](https://openaudio.com/blogs/s1) für Blog & technischen Bericht.

## Highlights ✨

### **Exzellente TTS-Qualität**

Wir verwenden Seed TTS Eval Metrics zur Bewertung der Modellleistung. Die Ergebnisse zeigen, dass OpenAudio S1 **0,008 WER** und **0,004 CER** bei englischem Text erreicht – deutlich besser als bisherige Modelle. (Englisch, automatische Auswertung, basierend auf OpenAI gpt-4o-transcribe, Sprecherabstand mit Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| Modell | Word Error Rate (WER) | Character Error Rate (CER) | Sprecherabstand |
|--------|----------------------|---------------------------|-----------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **Bestes Modell in TTS-Arena2** 🏆

OpenAudio S1 hat den **#1 Rang** auf [TTS-Arena2](https://arena.speechcolab.org/) erreicht, dem Benchmark für Text-to-Speech-Auswertung:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **Sprachkontrolle**

OpenAudio S1 **unterstützt eine Vielzahl von Emotions-, Ton- und Spezialmarkern**, um die Sprachsynthese zu verbessern:

- **Grundlegende Emotionen**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **Erweiterte Emotionen**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **Ton-Marker**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **Spezielle Audioeffekte**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Sie können auch Ha,ha,ha verwenden, um zu steuern – viele weitere Möglichkeiten warten darauf, von Ihnen entdeckt zu werden.

(Unterstützung für Englisch, Chinesisch und Japanisch derzeit, weitere Sprachen folgen in Kürze!)

### **Zwei Modelltypen**

| Modell | Größe | Verfügbarkeit | Funktionen |
|--------|-------|---------------|------------|
| **S1** | 4B Parameter | Verfügbar auf [fish.audio](fish.audio) | Voll ausgestattetes Flaggschiff-Modell |
| **S1-mini** | 0,5B Parameter | Verfügbar auf Huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | Destillierte Version mit Kernfunktionen |

Sowohl S1 als auch S1-mini beinhalten Online Reinforcement Learning from Human Feedback (RLHF).

## **Funktionen**

1. **Zero-shot & Few-shot TTS:** Geben Sie eine 10- bis 30-sekündige Sprachprobe ein, um hochwertige TTS-Ausgaben zu erzeugen. **Für detaillierte Richtlinien siehe [Voice Cloning Best Practices](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Mehrsprachige & Cross-linguale Unterstützung:** Einfach mehrsprachigen Text in das Eingabefeld kopieren und einfügen – keine Sorge um die Sprache. Unterstützt derzeit Englisch, Japanisch, Koreanisch, Chinesisch, Französisch, Deutsch, Arabisch und Spanisch.

3. **Keine Phonem-Abhängigkeit:** Das Modell hat starke Generalisierungsfähigkeiten und ist nicht auf Phoneme für TTS angewiesen. Es kann Text in jedem Sprachskript verarbeiten.

4. **Sehr genau:** Erreicht einen niedrigen CER (Character Error Rate) von etwa 0,4 % und WER (Word Error Rate) von etwa 0,8 % im Seed-TTS Eval.

5. **Schnell:** Mit fish-tech-Beschleunigung beträgt der Real-Time-Faktor etwa 1:5 auf einem Nvidia RTX 4060 Laptop und 1:15 auf einer Nvidia RTX 4090.

6. **WebUI-Inferenz:** Bietet eine benutzerfreundliche, auf Gradio basierende Web-Oberfläche, kompatibel mit Chrome, Firefox, Edge und anderen Browsern.

7. **GUI-Inferenz:** Bietet eine PyQt6-GUI, die nahtlos mit dem API-Server funktioniert. Unterstützt Linux, Windows und macOS. [Siehe GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **Bereitstellungsfreundlich:** Einfaches Einrichten eines Inferenzservers mit nativer Unterstützung für Linux, Windows (macOS kommt bald), minimiert Geschwindigkeitsverluste.

## **Medien & Demos**

<div align="center">

### **Soziale Medien**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **Interaktive Demos**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **Video-Demonstrationen**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Audio-Beispiele**
<div style="margin: 20px 0;">
    <em> Hochwertige Audio-Beispiele werden bald verfügbar sein und unsere mehrsprachigen TTS-Fähigkeiten in verschiedenen Sprachen und Emotionen demonstrieren.</em>
</div>

</div>

---

## Dokumentation

- [Build Environment](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Inference](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Danksagungen

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Technischer Bericht (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---