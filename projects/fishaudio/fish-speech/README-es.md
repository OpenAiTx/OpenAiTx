<div align="center">
<h1>Fish Speech</h1>

**Inglés** | [简体中文](docs/README.zh.md) | [Portugués](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

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
> **Aviso de Licencia**  
> Este repositorio de código se publica bajo la **Licencia Apache** y todos los pesos de los modelos se publican bajo la **Licencia CC-BY-NC-SA-4.0**. Por favor, consulte [LICENSE](LICENSE) para más detalles.

> [!WARNING]
> **Descargo de Responsabilidad Legal**  
> No asumimos ninguna responsabilidad por el uso ilegal de este repositorio. Por favor, consulte las leyes locales sobre DMCA y otras leyes relacionadas.

---

## 🎉 Anuncio

Nos complace anunciar que nos hemos renovado como **OpenAudio** — presentando una nueva serie revolucionaria de avanzados modelos de Texto a Voz que se basa en la fundación de Fish-Speech.

Nos enorgullece lanzar **OpenAudio-S1** como el primer modelo de esta serie, ofreciendo mejoras significativas en calidad, rendimiento y capacidades.

OpenAudio-S1 está disponible en dos versiones: **OpenAudio-S1** y **OpenAudio-S1-mini**. Ambos modelos están disponibles en [Fish Audio Playground](https://fish.audio) (para **OpenAudio-S1**) y en [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (para **OpenAudio-S1-mini**).

Visita el [sitio web de OpenAudio](https://openaudio.com/blogs/s1) para el blog e informe técnico.

## Destacados ✨

### **Excelente calidad TTS**

Utilizamos las métricas de evaluación Seed TTS Eval Metrics para evaluar el rendimiento del modelo, y los resultados muestran que OpenAudio S1 alcanza **0.008 WER** y **0.004 CER** en texto en inglés, lo que es significativamente mejor que modelos anteriores. (Inglés, evaluación automática, basada en OpenAI gpt-4o-transcribe, distancia del hablante usando Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| Modelo | Tasa de Error de Palabras (WER) | Tasa de Error de Caracteres (CER) | Distancia del Hablante |
|--------|-------------------------------|-------------------------------|------------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **Mejor Modelo en TTS-Arena2** 🏆

OpenAudio S1 ha logrado el **puesto #1** en [TTS-Arena2](https://arena.speechcolab.org/), el benchmark para la evaluación de texto a voz:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **Control de Voz**

OpenAudio S1 **soporta una variedad de emociones, tonos y marcadores especiales** para mejorar la síntesis de voz:

- **Emociones básicas**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **Emociones avanzadas**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **Marcadores de tono**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **Efectos de audio especiales**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

También puedes usar Ha,ha,ha para controlar, hay muchos otros casos esperando ser explorados por ti mismo.

(¡Actualmente soporta inglés, chino y japonés, y pronto habrá más idiomas!)

### **Dos Tipos de Modelos**

| Modelo | Tamaño | Disponibilidad | Características |
|--------|--------|----------------|-----------------|
| **S1** | 4B parámetros | Disponible en [fish.audio](fish.audio) | Modelo insignia con todas las funciones |
| **S1-mini** | 0.5B parámetros | Disponible en huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | Versión destilada con capacidades principales |

Tanto S1 como S1-mini incorporan aprendizaje por refuerzo en línea a partir de retroalimentación humana (RLHF).

## **Características**

1. **TTS Zero-shot & Few-shot:** Ingresa una muestra vocal de 10 a 30 segundos para generar una salida TTS de alta calidad. **Para pautas detalladas, consulta [Mejores Prácticas de Clonado de Voz](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Soporte multilingüe y cruzado:** Simplemente copia y pega texto multilingüe en el cuadro de entrada—no te preocupes por el idioma. Actualmente soporta inglés, japonés, coreano, chino, francés, alemán, árabe y español.

3. **Sin dependencia de fonemas:** El modelo tiene fuertes capacidades de generalización y no depende de fonemas para TTS. Puede manejar texto en cualquier sistema de escritura de idioma.

4. **Alta precisión:** Alcanza un CER (Tasa de Error de Caracteres) bajo, alrededor del 0.4% y un WER (Tasa de Error de Palabras) de alrededor del 0.8% para Seed-TTS Eval.

5. **Rápido:** Con aceleración fish-tech, el factor de tiempo real es aproximadamente 1:5 en una laptop Nvidia RTX 4060 y 1:15 en una Nvidia RTX 4090.

6. **Inferencia WebUI:** Cuenta con una interfaz web fácil de usar basada en Gradio, compatible con Chrome, Firefox, Edge y otros navegadores.

7. **Inferencia GUI:** Ofrece una interfaz gráfica PyQt6 que funciona perfectamente con el servidor API. Soporta Linux, Windows y macOS. [Ver GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **Amigable para despliegue:** Configura fácilmente un servidor de inferencia con soporte nativo para Linux, Windows (MacOS próximamente), minimizando la pérdida de velocidad.

## **Medios y Demos**

<div align="center">

### **Redes Sociales**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **Demos Interactivas**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **Demostraciones en Video**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Muestras de Audio**
<div style="margin: 20px 0;">
    <em>Próximamente estarán disponibles muestras de audio de alta calidad, demostrando nuestras capacidades TTS multilingües en diferentes idiomas y emociones.</em>
</div>

</div>

---

## Documentos

- [Configuración del Entorno](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Inferencia](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Créditos

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Informe Técnico (V1.4)
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