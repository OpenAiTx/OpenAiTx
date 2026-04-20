<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  Jeśli uważasz, że ten projekt jest przydatny,<br>
  będziemy bardzo wdzięczni za gwiazdkę ⭐ na GitHub!
</p>

---

## Struktura repozytorium

To repozytorium **ThinkSound** na GitHubie zawiera dwa powiązane projekty na oddzielnych gałęziach:

| Gałąź | Projekt | Dokumentacja |
|--------|---------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — zunifikowana generacja Any2Audio z dopasowaniem przepływu prowadzonym przez CoT | Ten plik: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — praca kontynuacyjna (ICLR 2026) na temat video-to-audio z wielowymiarowym CoT-RL | **`README.md`** na gałęzi [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) |

Dla **ThinkSound** użyj gałęzi **`master`** (ten README). Dla **PrismAudio** przejdź na **`prismaudio`** i postępuj zgodnie z **`README.md`** tam.

---

**ThinkSound** to zunifikowany framework generacji Any2Audio z dopasowaniem przepływu prowadzonym przez Chain-of-Thought (CoT).

Implementacja w PyTorch do multimodalnej generacji i edycji dźwięku: generuj lub edytuj audio z wideo, tekstu i audio, zasilana przez rozumowanie krok po kroku z Multimodalnymi Dużymi Modelami Językowymi (MLLM).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Aktualności
- **2026.03.24** &nbsp; 🔥 **PrismAudio** wydany w tym samym repozytorium na gałęzi [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) — zobacz **`README.md`** tam, aby uzyskać instrukcje i modele.
- **2026.01.26** &nbsp; 🎉 PrismAudio zaakceptowany na **ICLR 2026 Main Conference** (kod/dokumentacja na `prismaudio`).
- **2025.11.25** &nbsp; 🔥 [PrismAudio Demo Online](http://prismaudio-project.github.io/) jest dostępne.
- **2025.11.25** &nbsp; 🔥 [PrismAudio paper](https://arxiv.org/pdf/2511.18833) na arXiv — wielowymiarowy CoT-RL dla video-to-audio.
- **2025.09.19** &nbsp; 🎉 **ThinkSound** zaakceptowany na **NeurIPS 2025 Main Conference**!
- **2025.09.01** &nbsp; Nasz zbiór danych AudioCoT jest już otwartoźródłowy i dostępny na [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Finetuning włączony: kod do treningu i finetuningu jest już publiczny, z jasnymi instrukcjami użytkowania, które pozwalają dostosować i rozbudować ThinkSound o własne dane.
- **2025.07.15** &nbsp; 📦 Uproszczona instalacja i użyteczność: zależności dostępne na PyPI dla łatwego, wieloplatformowego wdrożenia; skrypty Windows `.bat` automatyzują tworzenie środowiska i uruchamianie skryptów.
- **2025.07.08** &nbsp;  🔧 Duża aktualizacja: model odchudzony i zoptymalizowano użycie pamięci oraz GPU, teraz obsługuje generację audio na dużą skalę!
- **2025.07.01** &nbsp; Demo online na [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) oraz [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) dla interaktywnego doświadczenia!
- **2025.07.01** &nbsp; Wydano skrypty do inferencji i interfejs webowy; 
- **2025.06** &nbsp; [ThinkSound paper](https://arxiv.org/pdf/2506.21448) wydany na arXiv!
- **2025.06** &nbsp; [Demo Online](http://thinksound-project.github.io/) jest dostępne - wypróbuj teraz!

---


<div align="center">

### Kontynuacja: PrismAudio (to samo repozytorium, gałąź `prismaudio`)

**PrismAudio** jest następcą ThinkSound (ICLR 2026), rozwijanym pod nową nazwą, ale utrzymywanym w tym repozytorium na gałęzi **`prismaudio`**. Instrukcje instalacji, punkty kontrolne i cytowanie znajdują się w **[`README.md` na tej gałęzi](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) lub otwórz gałąź na GitHubie.

</div>

---


## 🚀 Funkcje

- **Any2Audio**: Generowanie dźwięku z dowolnych modalności — wideo, tekstu, audio lub ich kombinacji.
- **Video-to-Audio SOTA**: Osiąga najlepsze wyniki na wielu benchmarkach V2A.
- **CoT-Driven Reasoning**: Chain-of-Thought reasoning do kompozycyjnego i kontrolowanego generowania dźwięku przez MLLM.
- **Interaktywna Edycja Obiektowa**: Poprawiaj lub edytuj określone zdarzenia dźwiękowe klikając na obiekty wizualne lub używając instrukcji tekstowych.
- **Zunifikowany Framework**: Jeden model bazowy obsługuje generowanie, edycję i interaktywny workflow.

---

## ✨ Przegląd Metody

ThinkSound rozbija generowanie i edycję dźwięku na trzy interaktywne etapy, wszystkie prowadzone przez Chain-of-Thought (CoT) oparty na MLLM:

1. **Generowanie Foley:** Tworzenie podstawowych, semantycznie i czasowo dopasowanych pejzaży dźwiękowych z wideo.
2. **Doprecyzowanie obiektowe:** Poprawianie lub dodawanie dźwięków dla wybranych przez użytkownika obiektów za pomocą kliknięć lub wskazanych obszarów na wideo.
3. **Celowana edycja audio:** Modyfikacja wygenerowanego dźwięku za pomocą wysokopoziomowych instrukcji języka naturalnego.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Do trenowania zarówno modułu rozumowania, jak i zunifikowanego modelu audio używany jest duży zbiór danych z adnotacjami CoT (**AudioCoT**).
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Szybki Start

**Przygotowanie środowiska:**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Wskazówka dla Windows:**  
> Użytkownicy Windows mogą po prostu uruchomić `setup_windows.bat` (lub kliknąć go dwukrotnie), aby automatycznie utworzyć środowisko conda, zainstalować wszystkie zależności (w tym FFmpeg) i pobrać wytrenowany model — bez konieczności ręcznej konfiguracji.  
> Przed uruchomieniem skryptu upewnij się, że `conda` i `git` są zainstalowane i dostępne w zmiennej PATH systemu.


### ▶️ Uruchom Demo

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

Możesz zamiast tego użyć dołączonego skryptu `.bat`:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**Uwaga:**

* `<ścieżka-do-twojego-wideo-demo>`: Ścieżka do pojedynczego wideo
* `[use-half]` (opcjonalnie): Dodaj use-half na końcu, aby włączyć ekstrakcję cech w połowie precyzji.

---

### 📦 Przetwarzanie wsadowe

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

Użyj równoważnego skryptu `.bat`:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**Uwaga:**

* `<video_path>`: Ścieżka do katalogu głównego zawierającego wszystkie filmy .mp4 do przetworzenia (wszystkie filmy muszą mieć taką samą długość).
* `<csv_path>`: Plik CSV z tekstowymi podpowiedziami dla każdego filmu (zobacz `demo_test.csv` dla formatu).
* `<save_path>` (opcjonalnie): Gdzie zapisać wygenerowane audio. Domyślnie `results/features`.
* `[use-half]` (opcjonalnie): Dodaj use-half na końcu, aby włączyć ekstrakcję cech w trybie półprecyzyjnym.

---


### Użycie interfejsu webowego

Aby uzyskać interaktywne doświadczenie, uruchom interfejs webowy Gradio:


```bash
python app.py
```


## 🏋️ Trening modelu

Zobacz [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---


## 📄 Licencja

Ten projekt jest udostępniany na licencji Apache 2.0.

> **Uwaga:**
> Kod, modele i zestaw danych są **wyłącznie do celów badawczych i edukacyjnych**.
> **Użycie komercyjne NIE jest dozwolone.**
> W sprawie licencjonowania komercyjnego prosimy o kontakt z autorami.

**📦 Komponenty zewnętrzne**

* **Stable Audio Open VAE** (autor: Stability AI):
  Repozytorium zawiera dostrojony VAE z [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), licencjonowany na [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Użycie komercyjne i redystrybucja wymagają uprzedniej zgody Stability AI.**

* 📘 **Cały pozostały kod i modele** są udostępnione na licencji Apache 2.0.

---

## Podziękowania

Serdeczne podziękowania dla:

* **stable-audio-tools** (autor: Stability AI):
Za udostępnienie łatwego w użyciu frameworka do generowania dźwięku, a także modułu VAE i wag.
* **MMAudio**:
  Za implementację szkieletu MM-DiT w domenie audio.

---

## 📖 Cytowanie

Jeśli nasz projekt okazał się przydatny w Twoich badaniach lub pracy, prosimy o cytowanie naszej publikacji:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---