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
  Jeśli projekt okazał się przydatny,<br>
  gwiazdka ⭐ na GitHubie będzie mile widziana!
</p>

---

**ThinkSound** to zunifikowane środowisko Any2Audio do generowania dźwięku z prowadzeniem przepływu na podstawie rozumowania typu Chain-of-Thought (CoT).

Implementacja PyTorch do multimodalnego generowania i edycji dźwięku: generuj lub edytuj dźwięk na podstawie wideo, tekstu oraz dźwięku, z wykorzystaniem krokowego rozumowania przez Multimodalne Duże Modele Językowe (MLLM).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Aktualności
- **2025.07.15** &nbsp; 📦 Uproszczona instalacja i użyteczność: zależności dostępne na PyPI dla łatwego wdrożenia na różnych platformach; skrypty Windows `.bat` automatyzują tworzenie środowiska i uruchamianie skryptów.
- **2025.07.08** &nbsp;  🔧 Duża aktualizacja: model odchudzony i zoptymalizowane zużycie pamięci oraz GPU, teraz obsługuje szybkie generowanie dźwięku na dużą skalę!
- **2025.07.01** &nbsp; 🔥Dostępne demo online na [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) oraz [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) — interaktywne doświadczenie!
- **2025.07.01** &nbsp; 🔥Wydano skrypty do wnioskowania oraz interfejs webowy; 
- **2025.06** &nbsp; 🔥[Artykuł ThinkSound](https://arxiv.org/pdf/2506.21448) udostępniony na arXiv!
- **2025.06** &nbsp; 🔥[Demo online](http://thinksound-project.github.io/) jest już dostępne - wypróbuj teraz!

---


## 🚀 Funkcje

- **Any2Audio**: Generowanie dźwięku z dowolnych modalności — wideo, tekstu, dźwięku lub ich kombinacji.
- **Video-to-Audio SOTA**: Najlepsze wyniki w wielu benchmarkach V2A.
- **Rozumowanie CoT**: Chain-of-Thought do kompozycyjnego i kontrolowanego generowania dźwięku przez MLLM.
- **Interaktywna edycja obiektów**: Udoskonalaj lub edytuj konkretne zdarzenia dźwiękowe klikając na obiekty wizualne lub używając poleceń tekstowych.
- **Zunifikowane środowisko**: Jeden model bazowy obsługuje generowanie, edycję i interaktywną pracę.

---

## ✨ Przegląd metody

ThinkSound rozkłada generowanie i edycję dźwięku na trzy interaktywne etapy, wszystkie prowadzone przez rozumowanie typu CoT oparte na MLLM:

1. **Generowanie Foley:** Tworzenie podstawowych, semantycznie i czasowo dopasowanych pejzaży dźwiękowych z wideo.
2. **Obiektowa modyfikacja:** Udoskonalanie lub dodawanie dźwięków do wybranych przez użytkownika obiektów przez kliknięcia lub zaznaczone regiony na wideo.
3. **Ukierunkowana edycja audio:** Modyfikacja generowanego dźwięku za pomocą wysokopoziomowych instrukcji języka naturalnego.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Wielkoskalowy zbiór danych z adnotacjami CoT (**AudioCoT**) wykorzystywany jest do trenowania zarówno modułu rozumowania, jak i zunifikowanego modelu audio.
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
---

## 📝 TODO & Plany na przyszłość
* - [ ] Udostępnienie skryptów treningowych dla modeli ThinkSound (Oczekiwane przed 20.07.2025)
* - [ ] Otwarcie datasetu AudioCoT i zautomatyzowanego pipeline'u (Oczekiwane przed 23.07.2025)
* - [ ] Udostępnienie gotowego obrazu środowiska (Oczekiwane przed 23.07.2025)
* - [ ] Wydanie bardziej zaawansowanego modelu bazowego obejmującego wiele domen, umożliwiającego bardziej angażujące i immersyjne tworzenie efektów foley (Oczekiwane do końca sierpnia 2025)
* - [ ] Dodanie wsparcia dla dodatkowych modalności i zadań downstream (Oczekiwane przed końcem lipca 2025)
* - [ ] Udostępnienie modeli w różnych skalach (Oczekiwane przed końcem lipca 2025)
* - [x] Instrukcja szybkiego startu dla początkujących użytkowników Windows
---


## 📄 Licencja

Ten projekt został wydany na licencji Apache 2.0.

> **Uwaga:**
> Kod, modele i zestaw danych są **wyłącznie do celów badawczych i edukacyjnych**.
> **Użycie komercyjne NIE jest dozwolone.**
> W sprawie licencji komercyjnej prosimy o kontakt z autorami.

**📦 Komponenty zewnętrzne**

* **Stable Audio Open VAE** (od Stability AI):
  To repozytorium zawiera dostrojony VAE z [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), licencjonowany na [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **Użycie komercyjne i redystrybucja wymagają wcześniejszej zgody Stability AI.**

* 📘 **Cały pozostały kod i modele** są wydane na licencji Apache 2.0.

---

## Podziękowania

Serdeczne podziękowania dla:

* **stable-audio-tools** (od Stability AI):
Za udostępnienie łatwego w użyciu frameworka do generowania dźwięku, a także modułu VAE i wag.
* **MMAudio**:
  Za implementację rdzenia MM-DiT w dziedzinie audio.

---

## 📖 Cytowanie

Jeśli ThinkSound był pomocny w Twoich badaniach lub pracy, prosimy o cytowanie naszej publikacji:


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

## 📬 Kontakt

✨ Zachęcamy do [zgłoszenia problemu](https://github.com/liuhuadai/ThinkSound/issues) lub kontaktu mailowego ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)), jeśli masz jakiekolwiek pytania lub sugestie!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---