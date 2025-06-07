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

## Inhaltsverzeichnis

1. [Einleitung](#1-einleitung)
2. [Modellübersicht](#2-modellübersicht)
3. [Modell-Downloads](#3-modell-downloads)
4. [Evaluationsergebnisse](#4-evaluationsergebnisse)
5. [Chat-Website & API-Plattform](#5-chat-website--api-plattform)
6. [Lokale Ausführung](#6-lokale-ausführung)
7. [Lizenz](#7-lizenz)
8. [Zitierung](#8-zitierung)
9. [Kontakt](#9-kontakt)

## 1. Einleitung

Wir präsentieren DeepSeek-V3, ein leistungsstarkes Mixture-of-Experts (MoE) Sprachmodell mit 671B Gesamtparametern, von denen 37B für jedes Token aktiviert werden.  
Zur Erreichung effizienter Inferenz und kostengünstigem Training setzt DeepSeek-V3 auf die Multi-head Latent Attention (MLA) und DeepSeekMoE-Architekturen, die bereits in DeepSeek-V2 umfassend validiert wurden.  
Darüber hinaus ist DeepSeek-V3 Vorreiter einer auxiliary-loss-freien Strategie für Load Balancing und setzt ein Multi-Token-Prediction-Trainingsziel für stärkere Performance.  
Wir pre-trainieren DeepSeek-V3 mit 14,8 Billionen diversen und hochwertigen Tokens, gefolgt von Supervised Fine-Tuning und Reinforcement-Learning-Phasen, um das volle Potenzial auszuschöpfen.  
Umfassende Bewertungen zeigen, dass DeepSeek-V3 andere Open-Source-Modelle übertrifft und eine vergleichbare Leistung zu führenden Closed-Source-Modellen erzielt.  
Trotz der herausragenden Leistung benötigt DeepSeek-V3 nur 2,788M H800 GPU-Stunden für das vollständige Training.  
Zudem ist der Trainingsprozess bemerkenswert stabil.  
Während des gesamten Trainings gab es keine irreparablen Verlustspitzen und es mussten keine Rollbacks durchgeführt werden.  
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Modellübersicht

---

**Architektur: Innovative Load-Balancing-Strategie und Trainingsziel**

- Aufbauend auf der effizienten Architektur von DeepSeek-V2 führen wir eine auxiliary-loss-freie Strategie für Load Balancing ein, die die Leistungsdegradation minimiert, welche durch das Erzwingen von Load Balancing entsteht.
- Wir untersuchen ein Multi-Token-Prediction (MTP)-Ziel und belegen dessen Nutzen für die Modellleistung.  
  Es kann auch für spekulatives Decoding zur Beschleunigung der Inferenz eingesetzt werden.

---

**Pre-Training: Für ultimative Trainingseffizienz**

- Wir entwickeln ein FP8-Mixed-Precision-Training-Framework und validieren erstmals die Machbarkeit und Effektivität von FP8-Training auf einem extrem großen Modell.  
- Durch das Co-Design von Algorithmen, Frameworks und Hardware überwinden wir den Kommunikations-Engpass beim Cross-Node-MoE-Training und erreichen nahezu vollständige Überlappung von Berechnung und Kommunikation.  
  Dies steigert die Trainingseffizienz erheblich und reduziert die Trainingskosten, sodass wir die Modellgröße ohne zusätzlichen Aufwand weiter skalieren können.  
- Zu einem wirtschaftlichen Preis von nur 2,664M H800 GPU-Stunden schließen wir das Pre-Training von DeepSeek-V3 mit 14,8T Tokens ab und liefern das derzeit stärkste Open-Source-Basismodell. Die nachfolgenden Trainingsphasen nach dem Pre-Training benötigen nur 0,1M GPU-Stunden.

---

**Post-Training: Wissensdistillation aus DeepSeek-R1**

- Wir führen eine innovative Methodik ein, um Reasoning-Fähigkeiten aus dem Long-Chain-of-Thought (CoT)-Modell, speziell aus einem der DeepSeek R1-Modelle, in Standard-LLMs, insbesondere DeepSeek-V3, zu distillieren. Unsere Pipeline integriert elegant die Verifizierungs- und Reflexionsmuster von R1 in DeepSeek-V3 und verbessert so die Reasoning-Leistung erheblich. Gleichzeitig behalten wir die Kontrolle über den Ausgabestil und die Länge von DeepSeek-V3.

---

## 3. Modell-Downloads

<div align="center">

| **Modell** | **#Gesamtparameter** | **#Aktivierte Parameter** | **Kontextlänge** | **Download** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!HINWEIS]
> Die Gesamtgröße der DeepSeek-V3-Modelle auf Hugging Face beträgt 685B, einschließlich 671B der Hauptmodell-Gewichte und 14B der Multi-Token-Prediction (MTP)-Modulgewichte.

Um optimale Leistung und Flexibilität zu gewährleisten, kooperieren wir mit Open-Source-Communities und Hardware-Anbietern, um mehrere Möglichkeiten zur lokalen Ausführung des Modells bereitzustellen. Für eine Schritt-für-Schritt-Anleitung siehe Abschnitt 6: [Lokale Ausführung](#6-lokale-ausführung).

Für Entwickler empfehlen wir [README_WEIGHTS.md](./README_WEIGHTS.md) für Details zu den Hauptmodell-Gewichten und den Multi-Token-Prediction (MTP)-Modulen. Bitte beachten Sie, dass MTP-Unterstützung derzeit aktiv in der Community entwickelt wird. Beiträge und Feedback sind willkommen.

## 4. Evaluationsergebnisse
### Basismodell
#### Standard-Benchmarks

<div align="center">


|  | Benchmark (Metrik) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | Architektur | - | MoE | Dense | Dense | MoE |
| | # Aktivierte Parameter | - | 21B | 72B | 405B | 37B |
| | # Gesamtparameter | - | 236B | 72B | 405B | 671B |
| Englisch | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Genauigkeit) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Genauigkeit) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Genauigkeit) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Genauigkeit) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Genauigkeit) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Genauigkeit) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Genauigkeit) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Genauigkeit) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Genauigkeit) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Genauigkeit) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Genauigkeit) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| Code | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Genauigkeit) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Genauigkeit) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Mathematik | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Chinesisch | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Genauigkeit) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Genauigkeit) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Genauigkeit) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Genauigkeit) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Mehrsprachig | MMMLU-non-English (Genauigkeit) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!HINWEIS]
> Beste Ergebnisse sind fett markiert. Ergebnisse mit einer Differenz ≤ 0,3 gelten als gleichwertig. DeepSeek-V3 erzielt auf den meisten Benchmarks die besten Ergebnisse, insbesondere bei Mathematik- und Code-Aufgaben.
> Für weitere Details siehe unser Paper. 

#### Kontextfenster
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

Evaluationsergebnisse der ``Needle In A Haystack`` (NIAH) Tests. DeepSeek-V3 zeigt über alle Kontextfensterlängen bis **128K** eine starke Performance.

### Chat-Modell
#### Standard-Benchmarks (Modelle >67B)
<div align="center">

| | **Benchmark (Metrik)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Architektur | MoE | MoE | Dense | Dense | - | - | MoE |
| | # Aktivierte Parameter | 21B | 21B | 72B | 405B | - | - | 37B |
| | # Gesamtparameter | 236B | 236B | 72B | 405B | - | - | 671B |
| Englisch | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Korrekt) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Genauigkeit) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Genauigkeit) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Code | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Perzentil) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Gelöst) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Genauigkeit) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Genauigkeit) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Mathematik | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Chinesisch | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Korrekt) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!HINWEIS]
> Alle Modelle werden mit einer Ausgabelängenbegrenzung von 8K getestet. Benchmarks mit weniger als 1000 Samples werden mehrfach mit unterschiedlichen Temperatureinstellungen getestet, um robuste Endergebnisse zu erhalten. DeepSeek-V3 ist das leistungsstärkste Open-Source-Modell und zeigt auch im Vergleich zu führenden Closed-Source-Modellen eine starke Performance.

####  Open-Ended-Generierung Evaluation

<div align="center">

| Modell | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!HINWEIS]
> Englischsprachige Open-Ended-Konversationsauswertung. Für AlpacaEval 2.0 verwenden wir die length-controlled Winrate als Metrik.

## 5. Chat-Website & API-Plattform
Sie können mit DeepSeek-V3 auf der offiziellen DeepSeek-Website chatten: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

Wir bieten außerdem eine OpenAI-kompatible API auf der DeepSeek-Plattform an: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Lokale Ausführung

DeepSeek-V3 kann lokal mit folgender Hardware und Open-Source-Community-Software betrieben werden:

1. **DeepSeek-Infer Demo**: Einfache und leichte Demo für FP8- und BF16-Inferenz.
2. **SGLang**: Vollständige Unterstützung des DeepSeek-V3-Modells in BF16- und FP8-Inferenzmodi, Multi-Token Prediction [in Kürze verfügbar](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: Effiziente FP8- und BF16-Inferenz für lokale und Cloud-Deployments.
4. **TensorRT-LLM**: Unterstützt derzeit BF16-Inferenz und INT4/8-Quantisierung, FP8-Unterstützung folgt bald.
5. **vLLM**: Unterstützt DeepSeek-V3 mit FP8- und BF16-Modi für Tensor- und Pipeline-Parallelismus.
6. **LightLLM**: Effiziente Einzel- oder Multi-Node-Deployments für FP8 und BF16.
7. **AMD GPU**: Ausführung von DeepSeek-V3 auf AMD-GPUs via SGLang in BF16- und FP8-Modi.
8. **Huawei Ascend NPU**: Ausführung von DeepSeek-V3 auf Huawei Ascend-Geräten.

Da FP8-Training nativ in unserem Framework verwendet wird, stellen wir nur FP8-Gewichte bereit. Falls Sie BF16-Gewichte für Experimente benötigen, können Sie das bereitgestellte Konvertierungsskript nutzen.

So konvertieren Sie FP8-Gewichte nach BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!HINWEIS]
> Hugging Face Transformers wird derzeit noch nicht direkt unterstützt.

### 6.1 Inferenz mit DeepSeek-Infer Demo (nur Beispiel)

#### Systemanforderungen

> [!HINWEIS] 
> Nur Linux mit Python 3.10. Mac und Windows werden nicht unterstützt.

Abhängigkeiten:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Modellgewichte & Demo-Code vorbereiten

Zuerst unser DeepSeek-V3 GitHub-Repository klonen:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

Wechseln Sie in den `inference`-Ordner und installieren Sie die in `requirements.txt` gelisteten Abhängigkeiten. Am einfachsten ist dies in einer neuen virtuellen Umgebung mit `conda` oder `uv`.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Laden Sie die Modellgewichte von Hugging Face herunter und legen Sie sie im Ordner `/path/to/DeepSeek-V3` ab.

#### Konvertierung der Modellgewichte

Konvertieren Sie die Hugging Face Modellgewichte in ein spezielles Format:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Ausführen

Nun können Sie mit DeepSeek-V3 chatten:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

Oder Batch-Inferenz auf einer Datei:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 Inferenz mit SGLang (empfohlen)

[SGLang](https://github.com/sgl-project/sglang) unterstützt aktuell [MLA-Optimierungen](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV-Cache und Torch Compile und liefert modernste Latenz und Durchsatz unter den Open-Source-Frameworks.

[SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) unterstützt den Betrieb von DeepSeek-V3 auf **NVIDIA und AMD GPUs**, was es zu einer äußerst vielseitigen und robusten Lösung macht.

SGLang unterstützt zudem [Multi-Node-Tensor-Parallelismus](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208), sodass das Modell auf mehreren, im Netzwerk verbundenen Maschinen betrieben werden kann.

Multi-Token Prediction (MTP) ist in Entwicklung. Fortschritte können im [Optimierungsplan](https://github.com/sgl-project/sglang/issues/2591) verfolgt werden.

Hier die Startanleitung vom SGLang-Team: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 Inferenz mit LMDeploy (empfohlen)
[LMDeploy](https://github.com/InternLM/lmdeploy) ist ein flexibles und leistungsfähiges Inferenz- und Serving-Framework für große Sprachmodelle und unterstützt nun DeepSeek-V3. Es bietet sowohl Offline-Pipeline-Verarbeitung als auch Online-Deployment und integriert sich nahtlos in PyTorch-basierte Workflows.

Für eine ausführliche Schritt-für-Schritt-Anleitung siehe: https://github.com/InternLM/lmdeploy/issues/2960

### 6.4 Inferenz mit TRT-LLM (empfohlen)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) unterstützt nun das DeepSeek-V3-Modell mit Präzisionsoptionen wie BF16 und INT4/INT8 weight-only. Unterstützung für FP8 ist in Arbeit. Der speziell für DeepSeek-V3 angepasste Branch ist hier verfügbar: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3

### 6.5 Inferenz mit vLLM (empfohlen)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 unterstützt DeepSeek-V3 Inferenz für FP8- und BF16-Modi auf NVIDIA und AMD GPUs. Neben Standardtechniken bietet vLLM _Pipeline-Parallelismus_ für den Betrieb auf mehreren, netzwerkverbundenen Maschinen. Für Details siehe die [vLLM-Anleitung](https://docs.vllm.ai/en/latest/serving/distributed_serving.html) und den [Enhancement-Plan](https://github.com/vllm-project/vllm/issues/11539).

### 6.6 Inferenz mit LightLLM (empfohlen)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 unterstützt Einzel- und Multi-Maschinen-Tensor-Parallelismus für DeepSeek-R1 (FP8/BF16) und bietet Mixed-Precision-Deployment, mit laufend integrierten Quantisierungsmodi. Details finden Sie in der [LightLLM-Anleitung](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). Zudem bietet LightLLM PD-Disaggregation-Deployment für DeepSeek-V2 und die Implementierung für DeepSeek-V3 ist in Entwicklung.

### 6.7 Empfohlene Inferenzfunktionalität mit AMD GPUs

In Zusammenarbeit mit dem AMD-Team bieten wir Day-One-Support für AMD GPUs mit SGLang, voll kompatibel mit FP8 und BF16. Details siehe [SGLang-Anleitung](#63-inference-with-lmdeploy-recommended).

### 6.8 Empfohlene Inferenzfunktionalität mit Huawei Ascend NPUs

Das [MindIE](https://www.hiascend.com/en/software/mindie)-Framework der Huawei Ascend Community hat die BF16-Version von DeepSeek-V3 erfolgreich adaptiert. Die Schritt-für-Schritt-Anleitung finden Sie [hier](https://modelers.cn/models/MindIE/deepseekv3).

## 7. Lizenz
Dieses Code-Repository steht unter [der MIT-Lizenz](LICENSE-CODE). Die Nutzung der DeepSeek-V3 Base/Chat-Modelle unterliegt [der Modelllizenz](LICENSE-MODEL). Die DeepSeek-V3-Serie (einschließlich Base und Chat) unterstützt kommerzielle Nutzung.

## 8. Zitierung
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

## 9. Kontakt
Wenn Sie Fragen haben, erstellen Sie bitte ein Issue oder kontaktieren Sie uns unter [service@deepseek.com](service@deepseek.com).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---