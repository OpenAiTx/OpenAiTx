<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## Inhoudsopgave

1. [Introductie](#1-introductie)
2. [Modeloverzicht](#2-modeloverzicht)
3. [Modeldownloads](#3-modeldownloads)
4. [Evaluatieresultaten](#4-evaluatieresultaten)
5. [Chatwebsite & API Platform](#5-chatwebsite--api-platform)
6. [Lokaal uitvoeren](#6-lokaal-uitvoeren)
7. [Licentie](#7-licentie)
8. [Citeren](#8-citeren)
9. [Contact](#9-contact)


## 1. Introductie

We presenteren DeepSeek-V3, een krachtig Mixture-of-Experts (MoE) taalmodel met 671B totale parameters waarvan 37B geactiveerd per token.
Om efficiënte inferentie en kosteneffectieve training te bereiken, hanteert DeepSeek-V3 Multi-head Latent Attention (MLA) en DeepSeekMoE-architecturen, die grondig zijn gevalideerd in DeepSeek-V2.
Bovendien introduceert DeepSeek-V3 als pionier een auxiliary-loss-vrije strategie voor load balancing en stelt het een multi-token voorspellingstrainingsdoelstelling vast voor betere prestaties.
We pre-trainen DeepSeek-V3 op 14,8 biljoen diverse en hoogwaardige tokens, gevolgd door Supervised Fine-Tuning en Reinforcement Learning stadia om het volledige potentieel te benutten.
Uitgebreide evaluaties tonen aan dat DeepSeek-V3 beter presteert dan andere open-source modellen en vergelijkbare prestaties behaalt als toonaangevende gesloten modellen.
Ondanks de uitstekende prestaties vereist DeepSeek-V3 slechts 2.788M H800 GPU-uren voor de volledige training.
Daarnaast is het trainingsproces opmerkelijk stabiel.
Gedurende het gehele trainingsproces hebben we geen onherstelbare verliespieken ervaren of rollbacks hoeven uitvoeren.
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Modeloverzicht

---

**Architectuur: Innovatieve Load Balancing Strategie en Trainingsdoelstelling**

- Bovenop de efficiënte architectuur van DeepSeek-V2 introduceren we een auxiliary-loss-vrije strategie voor load balancing, die de prestatievermindering minimaliseert die ontstaat door het stimuleren van load balancing.
- We onderzoeken een Multi-Token Prediction (MTP) doelstelling en bewijzen het voordeel voor de modelprestaties.
    Het kan ook gebruikt worden voor speculative decoding om inferentie te versnellen.

---

**Pre-Training: Naar Ultieme Trainingsefficiëntie**

- We ontwerpen een FP8 mixed precision trainingsframework en valideren voor het eerst de haalbaarheid en effectiviteit van FP8-training op een extreem grootschalig model.
- Door co-design van algoritmes, frameworks en hardware overwinnen we de communicatiestuwing in cross-node MoE-training, en bereiken we vrijwel volledige overlap tussen berekening en communicatie.
  Dit verhoogt onze trainingsefficiëntie aanzienlijk en vermindert de trainingskosten, waardoor we het model verder kunnen opschalen zonder extra overhead.
- Tegen een economische kost van slechts 2.664M H800 GPU-uren voltooien we de pre-training van DeepSeek-V3 op 14,8T tokens, waarmee we het momenteel krachtigste open-source basismodel produceren. De daaropvolgende trainingsstadia na pre-training vereisen slechts 0,1M GPU-uren.

---

**Post-Training: Kennisdistillatie van DeepSeek-R1**

-   We introduceren een innovatieve methodologie om redeneercapaciteiten te distilleren van het long-Chain-of-Thought (CoT) model, specifiek van een van de DeepSeek R1-serie modellen, naar standaard LLM's, in het bijzonder DeepSeek-V3. Onze pipeline integreert op elegante wijze de verificatie- en reflectiepatronen van R1 in DeepSeek-V3 en verbetert het redeneervermogen aanzienlijk. Ondertussen behouden we controle over de outputstijl en lengte van DeepSeek-V3.

---


## 3. Modeldownloads

<div align="center">

| **Model** | **#Totale Params** | **#Geactiveerde Params** | **Contextlengte** | **Download** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!OPMERKING]
> De totale omvang van de DeepSeek-V3 modellen op Hugging Face is 685B, wat 671B aan hoofdmodelgewichten en 14B aan Multi-Token Prediction (MTP) Module gewichten omvat.

Om optimale prestaties en flexibiliteit te garanderen, werken we samen met open-source gemeenschappen en hardwareleveranciers om meerdere manieren te bieden om het model lokaal uit te voeren. Raadpleeg sectie 6: [Lokaal uitvoeren](#6-lokaal-uitvoeren) voor stapsgewijze begeleiding.

Voor ontwikkelaars die dieper willen duiken, raden we aan [README_WEIGHTS.md](./README_WEIGHTS.md) te bekijken voor details over de hoofdmodelgewichten en de Multi-Token Prediction (MTP) Modules. Let op: MTP-ondersteuning wordt momenteel actief ontwikkeld binnen de community, en we verwelkomen je bijdragen en feedback.

## 4. Evaluatieresultaten
### Basismodel
#### Standaard Benchmarks

<div align="center">


|  | Benchmark (Metriek) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | Architectuur | - | MoE | Dense | Dense | MoE |
| | # Geactiveerde Params | - | 21B | 72B | 405B | 37B |
| | # Totale Params | - | 236B | 72B | 405B | 671B |
| Engels | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Acc.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Acc.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Acc.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Acc.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Acc.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Acc.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Acc.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Acc.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Acc.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Acc.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Acc.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| Code | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Wiskunde | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Chinees | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Meertalig | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!OPMERKING]
> Beste resultaten zijn vetgedrukt. Scores met een verschil van niet meer dan 0,3 worden als gelijkwaardig beschouwd. DeepSeek-V3 behaalt de beste prestaties op de meeste benchmarks, vooral bij wiskunde- en codeertaken.
> Voor meer evaluatiedetails, zie ons paper.

#### Contextvenster
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

Evaluatieresultaten op de ``Needle In A Haystack`` (NIAH) tests. DeepSeek-V3 presteert goed over alle contextvensterlengtes tot **128K**.

### Chatmodel
#### Standaard Benchmarks (Modellen groter dan 67B)
<div align="center">

| | **Benchmark (Metriek)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Architectuur | MoE | MoE | Dense | Dense | - | - | MoE |
| | # Geactiveerde Params | 21B | 21B | 72B | 405B | - | - | 37B |
| | # Totale Params | 236B | 236B | 72B | 405B | - | - | 671B |
| Engels | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Code | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentiel) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Opgelost) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Wiskunde | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Chinees | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!OPMERKING]
> Alle modellen worden geëvalueerd in een configuratie die de outputlengte beperkt tot 8K. Benchmarks met minder dan 1000 samples worden meerdere keren getest met verschillende temperatuurinstellingen om robuuste eindresultaten te verkrijgen. DeepSeek-V3 is het best presterende open-source model en vertoont ook concurrerende prestaties ten opzichte van vooraanstaande gesloten modellen.


####  Open Ended Generation Evaluatie

<div align="center">



| Model | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!OPMERKING]
> Engelse open-ended gespreksbeoordelingen. Voor AlpacaEval 2.0 gebruiken we het lengte-gecontroleerde winpercentage als metriek.


## 5. Chatwebsite & API Platform
Je kunt chatten met DeepSeek-V3 op de officiële website van DeepSeek: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

We bieden ook een OpenAI-compatibele API op het DeepSeek Platform: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Lokaal uitvoeren

DeepSeek-V3 kan lokaal worden ingezet met behulp van de volgende hardware en open-source community software:

1. **DeepSeek-Infer Demo**: We bieden een eenvoudige en lichte demo voor FP8 en BF16 inferentie.
2. **SGLang**: Volledige ondersteuning voor het DeepSeek-V3 model in zowel BF16- als FP8-inferentiemodi, met Multi-Token Prediction [binnenkort beschikbaar](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: Maakt efficiënte FP8 en BF16 inferentie mogelijk voor lokale en cloudimplementatie.
4. **TensorRT-LLM**: Ondersteunt momenteel BF16-inferentie en INT4/8 kwantisatie, met FP8-ondersteuning binnenkort beschikbaar.
5. **vLLM**: Ondersteunt DeepSeek-V3 model met FP8- en BF16-modi voor tensor parallelisme en pipeline parallelisme.
6. **LightLLM**: Ondersteunt efficiënte single-node of multi-node implementatie voor FP8 en BF16.
7. **AMD GPU**: Maakt het mogelijk om het DeepSeek-V3 model op AMD GPU's uit te voeren via SGLang in zowel BF16- als FP8-modi.
8. **Huawei Ascend NPU**: Ondersteunt het draaien van DeepSeek-V3 op Huawei Ascend apparaten.

Aangezien FP8-training standaard is geïmplementeerd in ons framework, leveren we alleen FP8-gewichten. Als je BF16-gewichten nodig hebt voor experimenten, kun je het bijgeleverde conversiescript gebruiken om de transformatie uit te voeren.

Hier is een voorbeeld van het converteren van FP8-gewichten naar BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!OPMERKING]
> Hugging Face's Transformers wordt nog niet direct ondersteund.

### 6.1 Inferentie met DeepSeek-Infer Demo (alleen voorbeeld)

#### Systeemeisen

> [!OPMERKING]
> Alleen Linux met Python 3.10. Mac en Windows worden niet ondersteund.

Vereiste afhankelijkheden:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Modelgewichten & Demo Code Voorbereiding

Kloon eerst onze DeepSeek-V3 GitHub repository:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

Navigeer naar de `inference` map en installeer de afhankelijkheden uit `requirements.txt`. De makkelijkste manier is om een pakketbeheerder zoals `conda` of `uv` te gebruiken om een nieuwe virtuele omgeving te maken en de afhankelijkheden te installeren.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Download de modelgewichten van Hugging Face en plaats deze in de `/path/to/DeepSeek-V3` map.

#### Modelgewichten Converteren

Converteer Hugging Face modelgewichten naar een specifiek formaat:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Uitvoeren

Daarna kun je chatten met DeepSeek-V3:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

Of batch-inferentie op een opgegeven bestand:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 Inferentie met SGLang (aanbevolen)

[SGLang](https://github.com/sgl-project/sglang) ondersteunt momenteel [MLA optimalisaties](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache en Torch Compile, en levert state-of-the-art latency en throughput prestaties onder open-source frameworks.

Opmerkelijk is dat [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) volledige ondersteuning biedt voor DeepSeek-V3 op zowel **NVIDIA als AMD GPU's**, waardoor het een veelzijdige en robuuste oplossing is.

SGLang ondersteunt ook [multi-node tensorparallelisme](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208), waarmee je dit model op meerdere met elkaar verbonden machines kunt uitvoeren.

Multi-Token Prediction (MTP) is in ontwikkeling en de voortgang is te volgen in het [optimalisatieplan](https://github.com/sgl-project/sglang/issues/2591).

Hier zijn de startinstructies van het SGLang team: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 Inferentie met LMDeploy (aanbevolen)
[LMDeploy](https://github.com/InternLM/lmdeploy), een flexibel en high-performance inferentie- en serveerframework voor grote taalmodellen, ondersteunt nu DeepSeek-V3. Het biedt zowel offline pipeline verwerking als online implementatie, en integreert naadloos met PyTorch-gebaseerde workflows.

Voor uitgebreide stapsgewijze instructies voor het uitvoeren van DeepSeek-V3 met LMDeploy, zie hier: https://github.com/InternLM/lmdeploy/issues/2960

### 6.4 Inferentie met TRT-LLM (aanbevolen)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) ondersteunt nu het DeepSeek-V3 model, met precisieopties zoals BF16 en INT4/INT8 weight-only. Ondersteuning voor FP8 is momenteel in ontwikkeling en zal binnenkort worden uitgebracht. Je kunt de aangepaste branch van TRTLLM, specifiek voor DeepSeek-V3, direct hier vinden: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3.

### 6.5 Inferentie met vLLM (aanbevolen)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 ondersteunt DeepSeek-V3 inferentie voor FP8- en BF16-modi op zowel NVIDIA als AMD GPU's. Naast standaardtechnieken biedt vLLM _pipeline parallelism_, waarmee je dit model op meerdere via netwerken verbonden machines kunt uitvoeren. Zie de [vLLM instructies](https://docs.vllm.ai/en/latest/serving/distributed_serving.html) voor gedetailleerde begeleiding. Volg ook gerust [het verbeterplan](https://github.com/vllm-project/vllm/issues/11539).

### 6.6 Inferentie met LightLLM (aanbevolen)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 ondersteunt single-machine en multi-machine tensor parallel implementatie voor DeepSeek-R1 (FP8/BF16) en biedt mixed-precision implementatie, met steeds meer kwantisatiemodi in integratie. Zie voor meer details de [LightLLM instructies](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). Daarnaast biedt LightLLM PD-disaggregatie voor DeepSeek-V2, en de implementatie van PD-disaggregatie voor DeepSeek-V3 is in ontwikkeling.

### 6.7 Aanbevolen inferentiefuncties met AMD GPU's

In samenwerking met het AMD-team hebben we Day-One ondersteuning voor AMD GPU's bereikt met SGLang, met volledige compatibiliteit voor zowel FP8 als BF16 precisie. Raadpleeg de [SGLang instructies](#63-inferentie-met-lmdeploy-aanbevolen) voor meer details.

### 6.8 Aanbevolen inferentiefuncties met Huawei Ascend NPU's
Het [MindIE](https://www.hiascend.com/en/software/mindie) framework van de Huawei Ascend-community heeft met succes de BF16-versie van DeepSeek-V3 aangepast. Voor stapsgewijze begeleiding op Ascend NPU's, volg de [instructies hier](https://modelers.cn/models/MindIE/deepseekv3).


## 7. Licentie
Deze coderepository is gelicentieerd onder [de MIT-licentie](LICENSE-CODE). Het gebruik van DeepSeek-V3 Base/Chat modellen is onderworpen aan [de Model Licentie](LICENSE-MODEL). DeepSeek-V3-serie (inclusief Base en Chat) ondersteunt commercieel gebruik.

## 8. Citeren
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. Contact
Als je vragen hebt, maak dan een issue aan of neem contact met ons op via [service@deepseek.com](service@deepseek.com).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---