<div align="center">
<h1>Fish Speech</h1>

**Inglese** | [简体中文](docs/README.zh.md) | [Portoghese](docs/README.pt-BR.md) | [Giapponese](docs/README.ja.md) | [Coreano](docs/README.ko.md) <br>

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

> [!IMPORTANTE]
> **Avviso Licenza**  
> Questo codice è rilasciato sotto licenza **Apache** e tutti i pesi dei modelli sono rilasciati sotto licenza **CC-BY-NC-SA-4.0**. Si prega di consultare [LICENSE](LICENSE) per maggiori dettagli.

> [!ATTENZIONE]
> **Dichiarazione Legale**  
> Non ci assumiamo alcuna responsabilità per qualsiasi uso illecito di questo codice. Consultare le leggi locali relative al DMCA e altre normative pertinenti.

---

## 🎉 Annuncio

Siamo entusiasti di annunciare la nostra nuova identità come **OpenAudio** — introducendo una nuova rivoluzionaria serie di modelli avanzati di Text-to-Speech che si basa sulle fondamenta di Fish-Speech.

Siamo orgogliosi di presentare **OpenAudio-S1** come primo modello di questa serie, offrendo miglioramenti significativi in qualità, prestazioni e funzionalità.

OpenAudio-S1 è disponibile in due versioni: **OpenAudio-S1** e **OpenAudio-S1-mini**. Entrambi i modelli sono ora disponibili su [Fish Audio Playground](https://fish.audio) (per **OpenAudio-S1**) e su [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (per **OpenAudio-S1-mini**).

Visita il [sito web OpenAudio](https://openaudio.com/blogs/s1) per blog & technical report.

## Punti salienti ✨

### **Qualità TTS eccellente**

Utilizziamo le metriche Seed TTS Eval per valutare le prestazioni del modello, e i risultati mostrano che OpenAudio S1 raggiunge **0.008 WER** e **0.004 CER** su testo inglese, valori significativamente migliori rispetto ai modelli precedenti. (Inglese, auto eval, basato su OpenAI gpt-4o-transcribe, speaker distance usando Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| Modello | Word Error Rate (WER) | Character Error Rate (CER) | Speaker Distance |
|-------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **Miglior modello su TTS-Arena2** 🏆

OpenAudio S1 ha raggiunto la **posizione #1** su [TTS-Arena2](https://arena.speechcolab.org/), il benchmark per la valutazione text-to-speech:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **Controllo della Voce**

OpenAudio S1 **supporta una varietà di emozioni, toni e marcatori speciali** per migliorare la sintesi vocale:

- **Emozioni di base**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **Emozioni avanzate**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **Marcatori di tono**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **Effetti audio speciali**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Puoi anche usare Ha,ha,ha per controllare, ci sono molti altri casi da esplorare autonomamente.

(Attualmente supportato per Inglese, Cinese e Giapponese, altre lingue in arrivo!)

### **Due Tipi di Modelli**

| Modello | Dimensione | Disponibilità | Caratteristiche |
|-------|------|--------------|----------|
| **S1** | 4B parametri | Disponibile su [fish.audio](fish.audio) | Modello flagship completo |
| **S1-mini** | 0.5B parametri | Disponibile su huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | Versione distillata con funzionalità principali |

Sia S1 che S1-mini integrano Reinforcement Learning from Human Feedback (RLHF) online.

## **Caratteristiche**

1. **TTS Zero-shot & Few-shot:** Inserisci un campione vocale da 10 a 30 secondi per generare output TTS di alta qualità. **Per linee guida dettagliate, vedi [Voice Cloning Best Practices](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Supporto multilingue & cross-lingual:** Basta copiare e incollare testo multilingue nel box di input—non è necessario preoccuparsi della lingua. Attualmente supporta Inglese, Giapponese, Coreano, Cinese, Francese, Tedesco, Arabo e Spagnolo.

3. **Nessuna dipendenza dai fonemi:** Il modello ha forti capacità di generalizzazione e non si basa sui fonemi per il TTS. Può gestire testi in qualsiasi scrittura linguistica.

4. **Alta accuratezza:** Raggiunge un basso CER (Character Error Rate) di circa 0.4% e WER (Word Error Rate) di circa 0.8% per Seed-TTS Eval.

5. **Veloce:** Con accelerazione fish-tech, il real-time factor è circa 1:5 su un laptop Nvidia RTX 4060 e 1:15 su una Nvidia RTX 4090.

6. **Inferenza WebUI:** Dispone di una web UI facile da usare basata su Gradio, compatibile con Chrome, Firefox, Edge e altri browser.

7. **Inferenza GUI:** Offre un'interfaccia grafica PyQt6 che funziona perfettamente con il server API. Supporta Linux, Windows e macOS. [Vedi GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **Facile da distribuire:** Imposta facilmente un server di inferenza con supporto nativo per Linux, Windows (MacOS in arrivo), minimizzando la perdita di velocità.

## **Media & Demo**

<div align="center">

### **Social Media**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **Demo Interattive**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **Video Dimostrativi**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Campioni Audio**
<div style="margin: 20px 0;">
    <em> Campioni audio di alta qualità saranno presto disponibili, dimostrando le nostre capacità TTS multilingue su diverse lingue ed emozioni.</em>
</div>

</div>

---

## Documentazione

- [Ambiente di Build](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Inferenza](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Crediti

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Technical Report (V1.4)
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