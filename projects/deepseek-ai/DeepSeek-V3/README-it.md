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

## Indice

1. [Introduzione](#1-introduzione)
2. [Sommario del Modello](#2-sommario-del-modello)
3. [Download del Modello](#3-download-del-modello)
4. [Risultati della Valutazione](#4-risultati-della-valutazione)
5. [Sito Chat & Piattaforma API](#5-sito-chat--piattaforma-api)
6. [Come Eseguire Localmente](#6-come-eseguire-localmente)
7. [Licenza](#7-licenza)
8. [Citazione](#8-citazione)
9. [Contatto](#9-contatto)

## 1. Introduzione

Presentiamo DeepSeek-V3, un potente modello linguistico Mixture-of-Experts (MoE) con 671 miliardi di parametri totali e 37 miliardi attivati per ogni token.  
Per ottenere un'inferenza efficiente e un addestramento conveniente, DeepSeek-V3 adotta Multi-head Latent Attention (MLA) e le architetture DeepSeekMoE, ampiamente validate in DeepSeek-V2.  
Inoltre, DeepSeek-V3 introduce una strategia pionieristica senza auxiliary loss per il bilanciamento del carico e imposta un obiettivo di training a predizione multi-token per prestazioni migliori.  
Abbiamo pre-addestrato DeepSeek-V3 su 14,8 trilioni di token diversificati e di alta qualità, seguiti da fasi di Fine-Tuning Supervisionato e Reinforcement Learning per sfruttare appieno le sue capacità.  
Valutazioni complete rivelano che DeepSeek-V3 supera altri modelli open-source e raggiunge prestazioni paragonabili ai migliori modelli closed-source.  
Nonostante le sue eccellenti prestazioni, DeepSeek-V3 richiede solo 2.788M ore GPU H800 per il training completo.  
Inoltre, il suo processo di addestramento è notevolmente stabile.  
Durante tutto il processo di training non abbiamo riscontrato alcun picco di perdita irrecuperabile né effettuato rollback.  
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Sommario del Modello

---

**Architettura: Strategia Innovativa di Bilanciamento del Carico e Obiettivo di Training**

- Sulla base dell’architettura efficiente di DeepSeek-V2, introduciamo una strategia senza auxiliary loss per il bilanciamento del carico, minimizzando il degrado delle prestazioni che deriva dall’enforcement del bilanciamento stesso.
-  Esploriamo un obiettivo di Multi-Token Prediction (MTP) e ne dimostriamo il beneficio sulle prestazioni del modello.  
    Può essere utilizzato anche per la decodifica speculativa per accelerare l’inferenza.  

---

**Pre-Training: Verso la Massima Efficienza di Addestramento**

- Progettiamo un framework di training mixed precision FP8 e, per la prima volta, validiamo la fattibilità ed efficacia dell’addestramento FP8 su un modello di scala estremamente ampia.  
- Tramite co-design di algoritmi, framework e hardware, superiamo il collo di bottiglia della comunicazione nel training cross-node MoE, raggiungendo quasi la piena sovrapposizione tra calcolo e comunicazione.  
  Questo incrementa significativamente l’efficienza di training e riduce i costi, permettendo di scalare ulteriormente la dimensione del modello senza overhead aggiuntivo.  
- Con un costo economico di soli 2.664M ore GPU H800, completiamo il pre-training di DeepSeek-V3 su 14,8T token, producendo l’attuale modello base open-source più potente. Le fasi successive richiedono solo 0,1M ore GPU.

---

**Post-Training: Distillazione della Conoscenza da DeepSeek-R1**

-   Introduciamo una metodologia innovativa per distillare capacità di ragionamento da un modello long-Chain-of-Thought (CoT), specificamente da uno dei modelli della serie DeepSeek R1, in LLM standard, in particolare DeepSeek-V3. La nostra pipeline incorpora elegantemente i pattern di verifica e riflessione di R1 in DeepSeek-V3 e ne migliora notevolmente le prestazioni di ragionamento. Nel frattempo, manteniamo il controllo sullo stile e la lunghezza dell’output di DeepSeek-V3.

---


## 3. Download del Modello

<div align="center">

| **Modello** | **#Parametri Totali** | **#Parametri Attivati** | **Lunghezza Contesto** | **Download** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> La dimensione totale dei modelli DeepSeek-V3 su Hugging Face è 685B, che include 671B dei pesi del Modello Principale e 14B dei pesi del Modulo Multi-Token Prediction (MTP).

Per garantire prestazioni ottimali e flessibilità, abbiamo collaborato con comunità open-source e fornitori hardware per offrire diversi modi per eseguire il modello localmente. Per una guida passo-passo, consulta la Sezione 6: [Come eseguire localmente](#6-come-eseguire-localmente).

Per gli sviluppatori che desiderano approfondire, consigliamo di consultare [README_WEIGHTS.md](./README_WEIGHTS.md) per dettagli sui pesi del Modello Principale e dei Moduli Multi-Token Prediction (MTP). Si noti che il supporto MTP è attualmente in fase di sviluppo attivo nella community, e accogliamo con favore i vostri contributi e feedback.

## 4. Risultati della Valutazione
### Modello Base
#### Benchmark Standard

<div align="center">


|  | Benchmark (Metrica) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | Architettura | - | MoE | Denso | Denso | MoE |
| | # Parametri Attivati | - | 21B | 72B | 405B | 37B |
| | # Parametri Totali | - | 236B | 72B | 405B | 671B |
| Inglese | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
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
| Codice | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Matematica | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Cinese | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Multilingue | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> I migliori risultati sono mostrati in grassetto. I punteggi con una differenza non superiore a 0,3 sono considerati allo stesso livello. DeepSeek-V3 ottiene le migliori prestazioni sulla maggior parte dei benchmark, in particolare su matematica e codice.
> Per maggiori dettagli sulle valutazioni, consulta il nostro paper. 

#### Finestra di Contesto
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

Risultati della valutazione sui test ``Needle In A Haystack`` (NIAH). DeepSeek-V3 si comporta bene su tutte le lunghezze di finestra di contesto fino a **128K**. 

### Modello Chat
#### Benchmark Standard (Modelli superiori a 67B)
<div align="center">

| | **Benchmark (Metrica)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Architettura | MoE | MoE | Denso | Denso | - | - | MoE |
| | # Parametri Attivati | 21B | 21B | 72B | 405B | - | - | 37B |
| | # Parametri Totali | 236B | 236B | 72B | 405B | - | - | 671B |
| Inglese | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Codice | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentile) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Matematica | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Cinese | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> Tutti i modelli sono valutati con una configurazione che limita la lunghezza dell’output a 8K. I benchmark con meno di 1000 campioni vengono testati più volte con temperature variabili per ottenere risultati finali robusti. DeepSeek-V3 risulta il miglior modello open-source e mostra prestazioni competitive anche rispetto ai modelli closed-source di frontiera.

####  Valutazione Generazione Open Ended

<div align="center">



| Modello | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> Valutazioni di conversazione open-ended in inglese. Per AlpacaEval 2.0, utilizziamo il win rate controllato per lunghezza come metrica.

## 5. Sito Chat & Piattaforma API
Puoi chattare con DeepSeek-V3 sul sito ufficiale di DeepSeek: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

Forniamo inoltre API compatibile OpenAI sulla piattaforma DeepSeek: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Come Eseguire Localmente

DeepSeek-V3 può essere distribuito localmente utilizzando l’hardware e il software open-source della community seguenti:

1. **DeepSeek-Infer Demo**: Forniamo una demo semplice e leggera per l’inferenza FP8 e BF16.
2. **SGLang**: Supporto completo del modello DeepSeek-V3 in modalità di inferenza sia BF16 che FP8, con Multi-Token Prediction [in arrivo](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: Permette inferenza efficiente FP8 e BF16 per deployment locale e cloud.
4. **TensorRT-LLM**: Attualmente supporta inferenza BF16 e quantizzazione INT4/8, con supporto FP8 in arrivo.
5. **vLLM**: Supporto al modello DeepSeek-V3 con modalità FP8 e BF16 per parallelismo di tensori e pipeline.
6. **LightLLM**: Supporta deployment efficiente a nodo singolo o multi-nodo per FP8 e BF16.
7. **AMD GPU**: Permette l’esecuzione del modello DeepSeek-V3 su GPU AMD tramite SGLang sia in BF16 che FP8.
8. **Huawei Ascend NPU**: Supporta l’esecuzione di DeepSeek-V3 su dispositivi Huawei Ascend.

Poiché il training FP8 è nativamente adottato nel nostro framework, forniamo solo pesi FP8. Se hai bisogno di pesi BF16 per esperimenti, puoi usare lo script di conversione fornito.

Ecco un esempio per convertire i pesi FP8 in BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Hugging Face Transformers non è ancora supportato direttamente.

### 6.1 Inferenza con DeepSeek-Infer Demo (solo esempio)

#### Requisiti di Sistema

> [!NOTE] 
> Solo Linux con Python 3.10. Mac e Windows non sono supportati.

Dipendenze:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Preparazione Pesi Modello & Codice Demo

Per prima cosa, clona il nostro repository GitHub DeepSeek-V3:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

Naviga nella cartella `inference` e installa le dipendenze elencate in `requirements.txt`. Il modo più semplice è usare un package manager come `conda` o `uv` per creare un nuovo ambiente virtuale e installare le dipendenze.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Scarica i pesi del modello da Hugging Face e inseriscili nella cartella `/path/to/DeepSeek-V3`.

#### Conversione dei Pesi Modello

Converti i pesi del modello Hugging Face in un formato specifico:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Esecuzione

Ora puoi chattare con DeepSeek-V3:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

Oppure eseguire inferenza batch su un file dato:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 Inferenza con SGLang (raccomandato)

[SGLang](https://github.com/sgl-project/sglang) attualmente supporta [ottimizzazioni MLA](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache e Torch Compile, offrendo latenze e throughput all’avanguardia tra i framework open-source.

In particolare, [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) supporta pienamente DeepSeek-V3 sia su **GPU NVIDIA che AMD**, rendendolo una soluzione molto versatile e robusta.

SGLang supporta anche [tensor parallelism multi-nodo](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208), permettendo di eseguire il modello su più macchine connesse in rete.

La Multi-Token Prediction (MTP) è in sviluppo, e i progressi sono tracciati nel [piano di ottimizzazione](https://github.com/sgl-project/sglang/issues/2591).

Qui le istruzioni di avvio dal team SGLang: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 Inferenza con LMDeploy (raccomandato)
[LMDeploy](https://github.com/InternLM/lmdeploy), framework flessibile e ad alte prestazioni per inferenza e serving di grandi modelli linguistici, ora supporta DeepSeek-V3. Offre sia elaborazione pipeline offline che capacità di deployment online, integrandosi perfettamente con workflow basati su PyTorch.

Per istruzioni dettagliate passo-passo sull’esecuzione di DeepSeek-V3 con LMDeploy, consulta: https://github.com/InternLM/lmdeploy/issues/2960


### 6.4 Inferenza con TRT-LLM (raccomandato)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) ora supporta il modello DeepSeek-V3, offrendo opzioni di precisione come BF16 e INT4/INT8 weight-only. Il supporto FP8 è attualmente in lavorazione e sarà rilasciato a breve. È possibile accedere al branch personalizzato di TRTLLM per DeepSeek-V3 tramite il seguente link per provare subito le nuove funzionalità: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3. 


### 6.5 Inferenza con vLLM (raccomandato)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 supporta l’inferenza DeepSeek-V3 per le modalità FP8 e BF16 sia su GPU NVIDIA che AMD. Oltre alle tecniche standard, vLLM offre _pipeline parallelism_ permettendo di eseguire il modello su più macchine in rete. Per una guida dettagliata, consulta le [istruzioni vLLM](https://docs.vllm.ai/en/latest/serving/distributed_serving.html). È inoltre possibile seguire [il piano di miglioramento](https://github.com/vllm-project/vllm/issues/11539).

### 6.6 Inferenza con LightLLM (raccomandato)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 supporta deployment tensor parallel a singola e multipla macchina per DeepSeek-R1 (FP8/BF16) e fornisce deployment mixed-precision, con ulteriori modalità di quantizzazione in integrazione continua. Per dettagli, consulta [le istruzioni LightLLM](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). Inoltre, LightLLM offre deployment PD-disaggregation per DeepSeek-V2, e l’implementazione per DeepSeek-V3 è in sviluppo.

### 6.7 Funzionalità di Inferenza Raccomandata con GPU AMD

In collaborazione con il team AMD, abbiamo ottenuto il supporto Day-One per GPU AMD utilizzando SGLang, con piena compatibilità sia per precisione FP8 che BF16. Per una guida dettagliata, consulta le [istruzioni SGLang](#63-inferenza-con-lmdeploy-raccomandato).

### 6.8 Funzionalità di Inferenza Raccomandata con Huawei Ascend NPUs
Il framework [MindIE](https://www.hiascend.com/en/software/mindie) della community Huawei Ascend ha adattato con successo la versione BF16 di DeepSeek-V3. Per una guida passo-passo su Ascend NPUs, consulta [le istruzioni qui](https://modelers.cn/models/MindIE/deepseekv3).


## 7. Licenza
Questo repository di codice è concesso in licenza secondo [la Licenza MIT](LICENSE-CODE). L’uso dei modelli DeepSeek-V3 Base/Chat è soggetto a [Licenza Modello](LICENSE-MODEL). La serie DeepSeek-V3 (inclusi Base e Chat) supporta l’uso commerciale.

## 8. Citazione
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

## 9. Contatto
Se hai domande, apri una issue o contattaci a [service@deepseek.com](service@deepseek.com).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---