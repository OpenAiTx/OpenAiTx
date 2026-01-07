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
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
<p align="center">
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
  gwiazdka ⭐ na GitHubie będzie mile widziana!
</p>

---

**ThinkSound** to zunifikowany system generowania Any2Audio z dopasowaniem przepływu kierowanym przez rozumowanie Chain-of-Thought (CoT).
Implementacja PyTorch dla multimodalnej generacji i edycji dźwięku: generuj lub edytuj dźwięk z wideo, tekstu i dźwięku, wspierana przez krok po kroku rozumowanie z Multimodalnych Dużych Modeli Językowych (MLLM).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Aktualności
- **2025.11.25** &nbsp; 🔥[Online PrismAudio Demo](http://prismaudio-project.github.io/) już dostępne – wypróbuj teraz!
- **2025.11.25** &nbsp; 🔥[PrismAudio paper](https://arxiv.org/pdf/2511.18833) opublikowany na arXiv, pierwszy wielowymiarowy framework CoT-RL dla generowania dźwięku z wideo!
- **2025.09.19** &nbsp; 🎉 ThinkSound został przyjęty na **NeurIPS 2025 Main Conference**!
- **2025.09.01** &nbsp; Nasz zbiór danych AudioCoT jest teraz open-source i dostępny na [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 Dostępne dostrajanie: kod treningowy i dostrajania jest już publiczny wraz z jasnymi instrukcjami, które pomogą Ci dostosować i rozszerzyć ThinkSound o własne dane.
- **2025.07.15** &nbsp; 📦 Uproszczona instalacja i użyteczność: zależności dostępne na PyPI dla łatwego wdrożenia cross-platform; skrypty Windows `.bat` automatyzują tworzenie środowiska i uruchamianie skryptów.
- **2025.07.08** &nbsp;  🔧 Duża aktualizacja: model odchudzony i zoptymalizowane zużycie pamięci i GPU, teraz obsługuje generowanie dźwięku na dużą skalę!
- **2025.07.01** &nbsp; Demo online na [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) oraz [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) dla interaktywnej prezentacji!
- **2025.07.01** &nbsp; Udostępniono skrypty do wnioskowania oraz interfejs webowy;
- **2025.06** &nbsp; [ThinkSound paper](https://arxiv.org/pdf/2506.21448) opublikowany na arXiv!
- **2025.06** &nbsp; [Demo Online](http://thinksound-project.github.io/) już dostępne – wypróbuj teraz!

---


## 🚀 Funkcje

- **Any2Audio**: Generowanie dźwięku z dowolnych modalności — wideo, tekstu, dźwięku lub ich kombinacji.
- **Video-to-Audio SOTA**: Osiąga najnowocześniejsze wyniki na wielu benchmarkach V2A.
- **CoT-Driven Reasoning**: Chain-of-Thought do kompozycyjnej i sterowalnej generacji dźwięku przez MLLM.
- **Interaktywna Edycja Obiektowa**: Ulepszaj lub edytuj konkretne zdarzenia dźwiękowe klikając w obiekty wizualne lub używając instrukcji tekstowych.
- **Zunifikowany Framework**: Jeden model bazowy obsługuje generowanie, edycję i interaktywny workflow.

---

## ✨ Przegląd Metody

ThinkSound rozbija generowanie i edycję dźwięku na trzy interaktywne etapy, wszystkie sterowane rozumowaniem Chain-of-Thought (CoT) na bazie MLLM:

1. **Generowanie Foley:** Tworzenie podstawowych, semantycznie i czasowo dopasowanych krajobrazów dźwiękowych z wideo.
2. **Refinacja Obiektowa:** Ulepszaj lub dodawaj dźwięki dla wskazanych przez użytkownika obiektów poprzez kliknięcia lub zaznaczenia w wideo.
3. **Ukierunkowana Edycja Dźwięku:** Modyfikuj wygenerowany dźwięk za pomocą wysokopoziomowych poleceń w języku naturalnym.


![ThinkSound Przegląd](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Duży zbiór danych z adnotacjami CoT (**AudioCoT**) jest używany do trenowania zarówno modułu wnioskowania, jak i zunifikowanego bazowego modelu audio.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Szybki start

**Przygotowanie środowiska:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
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

## 📝 TODO i plany na przyszłość
* - [ ] Wydanie bardziej zaawansowanego modelu bazowego obejmującego wiele domen, zapewniającego bardziej angażujące i immersyjne tworzenie efektów foley
* - [ ] Dodanie obsługi dodatkowych modalności i zadań pochodnych
* - [ ] Wydanie modeli o różnych skalach
* - [x] Otwarcie źródła zestawu danych AudioCoT oraz automatycznej linii produkcyjnej
* - [x] Wydanie skryptów treningowych dla modeli ThinkSound
* - [x] Przyjazny dla początkujących README z szybkim startem na Windows
---

## 📄 Licencja

Ten projekt jest wydany na licencji Apache 2.0.

> **Uwaga:**
> Kod, modele i zestaw danych są **przeznaczone wyłącznie do celów badawczych i edukacyjnych**.
> **Użycie komercyjne NIE jest dozwolone.**
> W sprawie licencji komercyjnych prosimy o kontakt z autorami.

**📦 Komponenty zewnętrzne**

* **Stable Audio Open VAE** (by Stability AI):
  Repozytorium zawiera dostrojony VAE z [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), udostępniony na [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Użycie komercyjne i dystrybucja wymagają wcześniejszej zgody Stability AI.**

* 📘 **Wszelki inny kod i modele** wydawane są na licencji Apache 2.0.

---

## Podziękowania




Wielkie podziękowania dla:

* **stable-audio-tools** (od Stability AI):
Za udostępnienie łatwego w użyciu frameworka do generowania dźwięku, a także modułu VAE i wag.
* **MMAudio**:
  Za implementację szkieletu MM-DiT w dziedzinie audio.

---

## 📖 Cytowanie

Jeśli ThinkSound okazał się przydatny w Twoich badaniach lub pracy, prosimy o cytowanie naszej publikacji:

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
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-07

---