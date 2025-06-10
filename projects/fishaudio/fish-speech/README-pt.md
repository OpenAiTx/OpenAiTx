<div align="center">
<h1>Fish Speech</h1>

**Inglês** | [简体中文](docs/README.zh.md) | [Português](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

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
> **Aviso de Licença**  
> Este repositório de código é lançado sob a **Licença Apache** e todos os pesos dos modelos são lançados sob a **Licença CC-BY-NC-SA-4.0**. Consulte o [LICENSE](LICENSE) para mais detalhes.

> [!WARNING]
> **Aviso Legal**  
> Não nos responsabilizamos por qualquer uso ilegal deste repositório de código. Consulte as leis locais sobre DMCA e outras leis relacionadas.

---

## 🎉 Anúncio

Estamos entusiasmados em anunciar que rebatizamos para **OpenAudio** — apresentando uma nova série revolucionária de modelos avançados de Texto-para-Fala que se baseia na fundação do Fish-Speech.

Temos o orgulho de lançar **OpenAudio-S1** como o primeiro modelo desta série, trazendo melhorias significativas em qualidade, desempenho e capacidades.

O OpenAudio-S1 vem em duas versões: **OpenAudio-S1** e **OpenAudio-S1-mini**. Ambos os modelos estão disponíveis agora no [Fish Audio Playground](https://fish.audio) (para o **OpenAudio-S1**) e na [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini) (para o **OpenAudio-S1-mini**).

Visite o [site OpenAudio](https://openaudio.com/blogs/s1) para blog & relatório técnico.

## Destaques ✨

### **Excelente qualidade TTS**

Utilizamos métricas Seed TTS Eval para avaliar o desempenho do modelo, e os resultados mostram que o OpenAudio S1 atinge **0.008 WER** e **0.004 CER** em textos em inglês, superando significativamente modelos anteriores. (Inglês, avaliação automática, baseada em OpenAI gpt-4o-transcribe, distância do locutor usando Revai/pyannote-wespeaker-voxceleb-resnet34-LM)

| Modelo | Word Error Rate (WER) | Character Error Rate (CER) | Speaker Distance |
|--------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **Melhor Modelo no TTS-Arena2** 🏆

O OpenAudio S1 atingiu a **classificação #1** no [TTS-Arena2](https://arena.speechcolab.org/), o benchmark de avaliação de texto-para-fala:

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **Controle de Fala**

O OpenAudio S1 **suporta uma variedade de marcadores emocionais, de tom e especiais** para aprimorar a síntese de fala:

- **Emoções básicas**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **Emoções avançadas**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **Marcadores de tom**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **Efeitos especiais de áudio**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Você também pode usar Ha,ha,ha para controlar, há muitos outros casos a serem explorados por você mesmo.

(Suporte para inglês, chinês e japonês atualmente, e mais idiomas em breve!)

### **Dois Tipos de Modelos**

| Modelo | Tamanho | Disponibilidade | Recursos |
|--------|---------|----------------|----------|
| **S1** | 4B parâmetros | Disponível em [fish.audio](fish.audio) | Modelo carro-chefe com todos os recursos |
| **S1-mini** | 0.5B parâmetros | Disponível no huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) | Versão destilada com capacidades essenciais |

Tanto S1 quanto S1-mini incorporam Aprendizado por Reforço Online com Feedback Humano (RLHF).

## **Recursos**

1. **TTS Zero-shot & Few-shot:** Insira uma amostra vocal de 10 a 30 segundos para gerar saída TTS de alta qualidade. **Para orientações detalhadas, veja [Melhores Práticas de Clonagem de Voz](https://docs.fish.audio/text-to-speech/voice-clone-best-practices).**

2. **Suporte Multilíngue & Cruzado:** Basta copiar e colar texto multilíngue na caixa de entrada—não precisa se preocupar com o idioma. Atualmente suporta inglês, japonês, coreano, chinês, francês, alemão, árabe e espanhol.

3. **Sem Dependência de Fonemas:** O modelo possui forte capacidade de generalização e não depende de fonemas para TTS. Pode lidar com texto em qualquer sistema de escrita.

4. **Alta Precisão:** Alcança uma CER (Taxa de Erro de Caracteres) de aproximadamente 0,4% e WER (Taxa de Erro de Palavras) de aproximadamente 0,8% para Seed-TTS Eval.

5. **Rápido:** Com a aceleração fish-tech, o fator de tempo real é aproximadamente 1:5 em um laptop Nvidia RTX 4060 e 1:15 em uma Nvidia RTX 4090.

6. **Inferência via WebUI:** Possui uma interface web fácil de usar, baseada em Gradio, compatível com Chrome, Firefox, Edge e outros navegadores.

7. **Inferência via GUI:** Oferece uma interface gráfica PyQt6 que funciona perfeitamente com o servidor de API. Suporta Linux, Windows e macOS. [Veja GUI](https://github.com/AnyaCoder/fish-speech-gui).

8. **Amigável para Deploy:** Configure facilmente um servidor de inferência com suporte nativo para Linux, Windows (MacOS em breve), minimizando perda de velocidade.

## **Mídia & Demos**

<div align="center">

### **Mídias Sociais**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **Demos Interativos**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **Vídeos de Demonstração**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **Amostras de Áudio**
<div style="margin: 20px 0;">
    <em> Amostras de áudio de alta qualidade estarão disponíveis em breve, demonstrando nossas capacidades TTS multilíngue em diferentes idiomas e emoções.</em>
</div>

</div>

---

## Documentação

- [Build Envrionment](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [Inference](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## Créditos

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## Relatório Técnico (V1.4)
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