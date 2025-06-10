<div align="center">
<h1>Fish Speech</h1>

**Engels** | [简体中文](docs/README.zh.md) | [Portugees](docs/README.pt-BR.md) | [Japans](docs/README.ja.md) | [Koreaans](docs/README.ko.md) <br>

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
> **Licentie Kennisgeving**  
> Deze codebase is uitgebracht onder de **Apache License** en alle modelgewichten zijn uitgebracht onder de **CC-BY-NC-SA-4.0 Licentie**. Zie [LICENSE](LICENSE) voor meer details.

> [!WARNING]
> **Juridische Disclaimer**  
> Wij zijn niet verantwoordelijk voor enig illegaal gebruik van deze codebase. Raadpleeg uw lokale wetgeving met betrekking tot DMCA en aanverwante wetgeving.

---

## 🎉 Aankondiging

We zijn verheugd om aan te kondigen dat we zijn omgedoopt tot **OpenAudio** — een revolutionaire nieuwe serie geavanceerde Text-to-Speech modellen die voortbouwt op de basis van Fish-Speech.

We zijn trots om **OpenAudio-S1** uit te brengen als het eerste model in deze serie, met aanzienlijke verbeteringen in kwaliteit, prestaties en mogelijkheden.

OpenAudio-S1 is beschikbaar in twee versies: **OpenAudio-S1** en **OpenAudio-S1-mini**. Beide modellen zijn nu beschikbaar op [Fish Audio Playground](https://fish.audio) (voor **OpenAudio-S1**) en [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (voor **OpenAudio-S1-mini**).

Bezoek de [OpenAudio website](https://openaudio.com/blogs/s1) voor blog & technisch rapport.

## Hoogtepunten ✨

### **Uitstekende TTS-kwaliteit**

Wij gebruiken Seed TTS Evaluatie Maatstaven om de modelprestaties te beoordelen, en de resultaten laten zien dat OpenAudio S1 een **0.008 WER** en **0.004 CER** behaalt op Engelse tekst, wat aanzienlijk beter is dan eerdere modellen. (Engels, automatische evaluatie, gebaseerd op OpenAI gpt-4o-transcribe, sprekerafstand met Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| Model | Woordfoutpercentage (WER) | Karakterfoutpercentage (CER) | Sprekerafstand |
|-------|--------------------------|------------------------------|----------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **Beste Model in TTS-Arena2** 🏆

OpenAudio S1 heeft de **#1 ranking** bereikt op [TTS-Arena2](https://arena.speechcolab.org/), de benchmark voor text-to-speech evaluatie:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **Spraakbesturing**

OpenAudio S1 **ondersteunt een verscheidenheid aan emotionele, toon- en speciale markeringen** om spraaksynthese te verbeteren:

- **Basisemoties**:
```
(boos) (verdrietig) (opgewonden) (verrast) (tevreden) (verheugd) 
(bang) (bezorgd) (van streek) (nerveus) (gefrustreerd) (gedeprimeerd)
(empatisch) (beschaamd) (walging) (geraakt) (trots) (ontspannen)
(dankbaar) (zelfverzekerd) (geïnteresseerd) (nieuwsgierig) (verward) (vrolijk)
```

- **Geavanceerde emoties**:
```
(minachtend) (ongelukkig) (angstig) (hysterisch) (onverschillig) 
(onGeduldig) (schuldig) (spottend) (in paniek) (woedend) (terughoudend)
(enthousiast) (afkeurend) (negatief) (ontkennend) (verbaasd) (serieus)
(sarcastisch) (verzoenend) (troostend) (oprecht) (smalend)
(twijfelend) (toegevend) (pijnlijk) (ongemakkelijk) (geamuseerd)
```

- **Toonmarkeringen**:
```
(gehaaste toon) (schreeuwen) (gillen) (fluisteren) (zachte toon)
```

- **Speciale audio-effecten**:
```
(lachen) (grinniken) (snikken) (hard huilen) (zuchten) (hijgen)
(kreunen) (menigte lacht) (achtergrondgelach) (publiek lacht)
```

Je kunt ook Ha,ha,ha gebruiken voor controle; er zijn veel andere mogelijkheden die je zelf kunt ontdekken.

(Ondersteuning voor Engels, Chinees en Japans nu; meer talen binnenkort!)

### **Twee Type Modellen**

| Model | Grootte | Beschikbaarheid | Eigenschappen |
|-------|--------|-----------------|---------------|
| **S1** | 4B parameters | Beschikbaar op [fish.audio](fish.audio) | Volledig uitgeruste vlaggenschipmodel |
| **S1-mini** | 0.5B parameters | Beschikbaar op huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | Gedistilleerde versie met kerncapaciteiten |

Zowel S1 als S1-mini bevatten online Reinforcement Learning from Human Feedback (RLHF).

## **Eigenschappen**

1. **Zero-shot & Few-shot TTS:** Voer een 10 tot 30 seconden durend stemvoorbeeld in om hoogwaardige TTS-uitvoer te genereren. **Zie voor gedetailleerde richtlijnen [Voice Cloning Best Practices](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Meertalig & Cross-linguaal:** Kopieer en plak eenvoudig meertalige tekst in het invoerveld—geen zorgen over de taal. Ondersteunt momenteel Engels, Japans, Koreaans, Chinees, Frans, Duits, Arabisch en Spaans.

3. **Geen Foneemafhankelijkheid:** Het model heeft sterke generalisatievermogen en is niet afhankelijk van fonemen voor TTS. Kan tekst in elk taalschrift verwerken.

4. **Zeer Nauwkeurig:** Bereikt een lage CER (Karakterfoutpercentage) van ongeveer 0,4% en WER (Woordfoutpercentage) van ongeveer 0,8% voor Seed-TTS Evaluatie.

5. **Snel:** Met fish-tech versnelling is de real-time factor circa 1:5 op een Nvidia RTX 4060 laptop en 1:15 op een Nvidia RTX 4090.

6. **WebUI Inference:** Voorzien van een gebruiksvriendelijke, op Gradio gebaseerde web-UI compatibel met Chrome, Firefox, Edge en andere browsers.

7. **GUI Inference:** Biedt een PyQt6 grafische interface die naadloos werkt met de API-server. Ondersteunt Linux, Windows en macOS. [Zie GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **Deploy-Vriendelijk:** Zet eenvoudig een inference server op met native ondersteuning voor Linux, Windows (MacOS binnenkort), met minimaal snelheidsverlies.

## **Media & Demo's**

<div align="center">

### **Social Media**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Laatste Demo op X" />
</a>

### **Interactieve Demo's**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Probeer OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Probeer S1 Mini" />
</a>

### **Video Demo's**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Audio Voorbeelden**
<div style="margin: 20px 0;">
    <em> Hoogwaardige audiovoorbeelden zullen binnenkort beschikbaar zijn, waarmee onze meertalige TTS-mogelijkheden in verschillende talen en emoties worden gedemonstreerd.</em>
</div>

</div>

---

## Documentatie

- [Build Omgeving](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Inferences](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Credits

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Technisch Rapport (V1.4)
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