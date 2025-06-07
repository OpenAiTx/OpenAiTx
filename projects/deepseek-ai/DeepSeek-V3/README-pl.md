<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Strona główna"
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
  <a href="https://arxiv.org/pdf/2412.19437"><b>Link do artykułu</b>👁️</a>
</div>

## Spis treści

1. [Wprowadzenie](#1-wprowadzenie)
2. [Podsumowanie modelu](#2-podsumowanie-modelu)
3. [Pobieranie modelu](#3-pobieranie-modelu)
4. [Wyniki ewaluacji](#4-wyniki-ewaluacji)
5. [Strona czatu i platforma API](#5-strona-czatu--platforma-api)
6. [Jak uruchomić lokalnie](#6-jak-uruchomić-lokalnie)
7. [Licencja](#7-licencja)
8. [Cytowanie](#8-cytowanie)
9. [Kontakt](#9-kontakt)

## 1. Wprowadzenie

Przedstawiamy DeepSeek-V3, zaawansowany językowy model Mixture-of-Experts (MoE) z 671 miliardami parametrów ogółem i 37 miliardami aktywowanych dla każdego tokena.  
Aby osiągnąć wydajne wnioskowanie i efektywne kosztowo trenowanie, DeepSeek-V3 wykorzystuje architektury Multi-head Latent Attention (MLA) oraz DeepSeekMoE, które zostały gruntownie zweryfikowane w DeepSeek-V2.  
Ponadto, DeepSeek-V3 wprowadza nowatorską strategię równoważenia obciążenia bez strat pomocniczych oraz ustanawia cel treningowy wielotokenowej predykcji dla lepszej wydajności.  
Model DeepSeek-V3 został wytrenowany wstępnie na 14,8 bilionach różnorodnych i wysokiej jakości tokenów, a następnie poddany etapom Supervised Fine-Tuning i Reinforcement Learning w celu pełnego wykorzystania jego możliwości.  
Kompleksowe ewaluacje wykazują, że DeepSeek-V3 przewyższa inne modele open-source i osiąga wydajność porównywalną z wiodącymi modelami zamkniętymi.  
Pomimo znakomitej wydajności, DeepSeek-V3 wymaga jedynie 2,788 mln godzin GPU H800 do pełnego treningu.  
Dodatkowo, proces treningu jest niezwykle stabilny.  
W całym przebiegu treningu nie zaobserwowaliśmy żadnych nieodwracalnych skoków straty ani nie wykonywaliśmy żadnych rollbacków.  
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Podsumowanie modelu

---

**Architektura: Innowacyjna strategia równoważenia obciążenia i cel treningowy**

- Na bazie wydajnej architektury DeepSeek-V2 wprowadziliśmy strategię równoważenia obciążenia bez strat pomocniczych, co minimalizuje degradację wydajności wynikającą z wymuszania równowagi obciążenia.
- Badamy cel Multi-Token Prediction (MTP) i dowodzimy jego korzyści dla wydajności modelu.  
  Może być on również wykorzystany do spekulatywnego dekodowania, przyspieszając wnioskowanie.

---

**Trenowanie wstępne: W kierunku maksymalnej efektywności treningu**

- Opracowaliśmy ramy treningu mieszanej precyzji FP8 i po raz pierwszy zweryfikowaliśmy możliwość oraz skuteczność treningu FP8 na modelu o tak dużej skali.  
- Dzięki współprojektowaniu algorytmów, frameworków oraz sprzętu przezwyciężyliśmy wąskie gardła komunikacyjne podczas treningu MoE pomiędzy węzłami, niemal osiągając pełne nakładanie się obliczeń i komunikacji.  
  Znacząco poprawia to efektywność treningu i redukuje koszty, umożliwiając dalsze skalowanie modelu bez dodatkowych nakładów.  
- Przy ekonomicznym koszcie jedynie 2,664 mln godzin GPU H800 ukończyliśmy trenowanie wstępne DeepSeek-V3 na 14,8T tokenów, tworząc obecnie najsilniejszy otwartoźródłowy model bazowy. Kolejne etapy treningu po trenowaniu wstępnym wymagają jedynie 0,1 mln godzin GPU.

---

**Trenowanie końcowe: Destylacja wiedzy z DeepSeek-R1**

- Wprowadzamy innowacyjną metodologię destylacji umiejętności rozumowania z modelu long-Chain-of-Thought (CoT), konkretnie z jednego z modeli serii DeepSeek R1, do standardowych LLM, w szczególności DeepSeek-V3. Nasz pipeline elegancko integruje wzorce weryfikacji i refleksji z R1 do DeepSeek-V3 i znacząco poprawia jego wydajność rozumowania. Jednocześnie kontrolujemy styl oraz długość generowanych odpowiedzi przez DeepSeek-V3.

---

## 3. Pobieranie modelu

<div align="center">

| **Model** | **#Parametrów ogółem** | **#Parametrów aktywowanych** | **Długość kontekstu** | **Pobierz** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> Całkowity rozmiar modeli DeepSeek-V3 na Hugging Face to 685B, co obejmuje 671B wag Głównego Modelu oraz 14B wag Modułu Multi-Token Prediction (MTP).

Aby zapewnić optymalną wydajność i elastyczność, współpracujemy ze społecznościami open-source oraz dostawcami sprzętu, aby umożliwić uruchamianie modelu lokalnie na różne sposoby. Szczegółowe instrukcje znajdują się w sekcji 6: [Jak uruchomić lokalnie](#6-jak-uruchomić-lokalnie).

Dla deweloperów zainteresowanych szczegółami polecamy zapoznać się z [README_WEIGHTS.md](./README_WEIGHTS.md), gdzie opisano szczegóły dotyczące wag Głównego Modelu i Modułów Multi-Token Prediction (MTP). Zwracamy uwagę, że wsparcie dla MTP jest obecnie aktywnie rozwijane przez społeczność – zachęcamy do współpracy i przekazywania opinii.

## 4. Wyniki ewaluacji

### Model bazowy
#### Standardowe benchmarki

<div align="center">

|  | Benchmark (metryka) | # Strzałów | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | Architektura | - | MoE | Dense | Dense | MoE |
| | # Param. aktyw. | - | 21B | 72B | 405B | 37B |
| | # Param. ogółem | - | 236B | 72B | 405B | 671B |
| Angielski | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
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
| Kod | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Matematyka | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Chiński | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Wielojęzyczny | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> Najlepsze wyniki wyróżniono pogrubieniem. Wyniki, których różnica nie przekracza 0,3, uznaje się za równorzędne. DeepSeek-V3 osiąga najlepsze wyniki w większości benchmarków, szczególnie w zadaniach matematycznych i kodowych.
> Więcej szczegółów ewaluacji znajduje się w naszym artykule.

#### Okno kontekstu
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

Wyniki ewaluacji w testach ``Needle In A Haystack`` (NIAH). DeepSeek-V3 osiąga wysoką wydajność dla wszystkich długości okna kontekstu do **128K**.

### Model czatu
#### Standardowe benchmarki (modele powyżej 67B)
<div align="center">

| | **Benchmark (metryka)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Architektura | MoE | MoE | Dense | Dense | - | - | MoE |
| | # Param. aktyw. | 21B | 21B | 72B | 405B | - | - | 37B |
| | # Param. ogółem | 236B | 236B | 72B | 405B | - | - | 671B |
| Angielski | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Kod | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentile) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Matematyka | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Chiński | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> Wszystkie modele są ewaluowane z ograniczeniem długości wyjścia do 8K. Benchmarki zawierające mniej niż 1000 próbek są testowane wielokrotnie z różnymi ustawieniami temperatury, aby uzyskać stabilne wyniki końcowe. DeepSeek-V3 to najlepiej wypadający model open-source i wykazuje konkurencyjność względem czołowych modeli zamkniętych.

#### Ewaluacja generacji otwartej

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

> [!NOTE]
> Angielskie ewaluacje konwersacyjne otwartej generacji. Dla AlpacaEval 2.0 stosujemy miarę wygranych pod kontrolą długości odpowiedzi.

## 5. Strona czatu i platforma API

Możesz rozmawiać z DeepSeek-V3 na oficjalnej stronie DeepSeek: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

Udostępniamy także API kompatybilne z OpenAI na platformie DeepSeek: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Jak uruchomić lokalnie

DeepSeek-V3 można wdrożyć lokalnie przy użyciu następującego sprzętu i oprogramowania open-source:

1. **DeepSeek-Infer Demo**: Udostępniamy prostą i lekką demonstrację dla wnioskowania FP8 i BF16.
2. **SGLang**: Pełne wsparcie dla modelu DeepSeek-V3 w trybach wnioskowania BF16 i FP8, Multi-Token Prediction [wkrótce](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: Umożliwia wydajne wnioskowanie FP8 i BF16 dla wdrożeń lokalnych i chmurowych.
4. **TensorRT-LLM**: Aktualnie obsługuje wnioskowanie BF16 oraz kwantyzację INT4/8, wsparcie FP8 wkrótce.
5. **vLLM**: Obsługuje model DeepSeek-V3 z trybami FP8 i BF16 dla równoległości tensorowej i pipeline.
6. **LightLLM**: Wydajne wdrożenia jedno- i wielowęzłowe dla FP8 i BF16.
7. **AMD GPU**: Umożliwia uruchomienie DeepSeek-V3 na GPU AMD poprzez SGLang w trybach BF16 i FP8.
8. **Huawei Ascend NPU**: Obsługuje uruchamianie DeepSeek-V3 na urządzeniach Huawei Ascend.

Ponieważ trening FP8 jest natywnie zaimplementowany w naszym frameworku, udostępniamy wyłącznie wagi FP8. Jeśli potrzebujesz wag BF16 do eksperymentów, użyj dołączonego skryptu konwersji.

Przykład konwersji wag FP8 do BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /ścieżka/do/fp8_weights --output-bf16-hf-path /ścieżka/do/bf16_weights
```

> [!NOTE]
> Transformers Hugging Face nie jest jeszcze bezpośrednio wspierany.

### 6.1 Wnioskowanie z DeepSeek-Infer Demo (przykład)

#### Wymagania systemowe

> [!NOTE] 
> Tylko Linux z Pythonem 3.10. Mac i Windows nie są obsługiwane.

Zależności:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Przygotowanie wag modelu i kodu demo

Najpierw sklonuj repozytorium DeepSeek-V3 z GitHuba:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

Przejdź do folderu `inference` i zainstaluj zależności z `requirements.txt`. Najwygodniej użyć menedżera pakietów `conda` lub `uv`, tworząc nowe środowisko wirtualne.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Pobierz wagi modelu z Hugging Face i umieść je w katalogu `/ścieżka/do/DeepSeek-V3`.

#### Konwersja wag modelu

Konwertuj wagi modelu Hugging Face do wymaganego formatu:

```shell
python convert.py --hf-ckpt-path /ścieżka/do/DeepSeek-V3 --save-path /ścieżka/do/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Uruchomienie

Teraz możesz rozmawiać z DeepSeek-V3:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /ścieżka/do/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

Lub wykonać wnioskowanie wsadowe na pliku wejściowym:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /ścieżka/do/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 Wnioskowanie z SGLang (zalecane)

[SGLang](https://github.com/sgl-project/sglang) obecnie obsługuje [optymalizacje MLA](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache oraz Torch Compile, zapewniając najnowocześniejsze opóźnienia i przepustowość wśród frameworków open-source.

W szczególności [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) w pełni obsługuje uruchamianie DeepSeek-V3 zarówno na GPU NVIDIA, jak i AMD, czyniąc to rozwiązanie wszechstronnym i niezawodnym.

SGLang obsługuje również [wielowęzłową równoległość tensorową](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208), pozwalając na uruchamianie modelu na wielu maszynach połączonych siecią.

Multi-Token Prediction (MTP) jest w trakcie rozwoju, postęp można śledzić w [planu optymalizacji](https://github.com/sgl-project/sglang/issues/2591).

Instrukcje uruchomienia od zespołu SGLang: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 Wnioskowanie z LMDeploy (zalecane)
[LMDeploy](https://github.com/InternLM/lmdeploy), elastyczny i wydajny framework do wnioskowania i serwowania dużych modeli językowych, obsługuje DeepSeek-V3. Oferuje zarówno offline pipeline processing, jak i online deployment, płynnie integrując się z workflow opartymi na PyTorch.

Kompleksowe instrukcje krok po kroku znajdują się tutaj: https://github.com/InternLM/lmdeploy/issues/2960

### 6.4 Wnioskowanie z TRT-LLM (zalecane)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) obsługuje model DeepSeek-V3, oferując opcje precyzji BF16 oraz INT4/INT8 weight-only. Wsparcie FP8 jest w trakcie realizacji. Dostęp do specjalnej gałęzi TRTLLM dla DeepSeek-V3: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3.

### 6.5 Wnioskowanie z vLLM (zalecane)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 obsługuje wnioskowanie DeepSeek-V3 w trybach FP8 i BF16 na GPU NVIDIA i AMD. Oprócz standardowych technik vLLM oferuje _pipeline parallelism_, umożliwiając uruchamianie modelu na wielu maszynach sieciowych. Szczegóły w [instrukcji vLLM](https://docs.vllm.ai/en/latest/serving/distributed_serving.html). Warto śledzić [plan rozwoju](https://github.com/vllm-project/vllm/issues/11539).

### 6.6 Wnioskowanie z LightLLM (zalecane)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 obsługuje wdrożenia tensor parallel na pojedynczych i wielu maszynach dla DeepSeek-R1 (FP8/BF16) oraz udostępnia deployment w mieszanej precyzji, ze stałym rozwojem trybów kwantyzacji. Szczegóły w [instrukcji LightLLM](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). Ponadto LightLLM umożliwia wdrożenia PD-disaggregation dla DeepSeek-V2, a implementacja dla DeepSeek-V3 jest w przygotowaniu.

### 6.7 Zalecane wnioskowanie na GPU AMD

Wspólnie z zespołem AMD zapewniliśmy wsparcie Day-One dla GPU AMD przy użyciu SGLang, z pełną kompatybilnością dla precyzji FP8 i BF16. Szczegóły w [instrukcji SGLang](#63-wnioskowanie-z-lmdeploy-zalecane).

### 6.8 Zalecane wnioskowanie na Huawei Ascend NPU

Framework [MindIE](https://www.hiascend.com/en/software/mindie) społeczności Huawei Ascend dostosował wersję BF16 DeepSeek-V3. Szczegółowe instrukcje dla Ascend NPU znajdują się [tutaj](https://modelers.cn/models/MindIE/deepseekv3).

## 7. Licencja

To repozytorium kodu jest licencjonowane na [Licencji MIT](LICENSE-CODE). Użycie modeli DeepSeek-V3 Base/Chat podlega [Licencji Modelu](LICENSE-MODEL). Seria DeepSeek-V3 (w tym Base i Chat) wspiera zastosowania komercyjne.

## 8. Cytowanie
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

W przypadku pytań prosimy o zgłoszenie issue lub kontakt pod [service@deepseek.com](service@deepseek.com).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---