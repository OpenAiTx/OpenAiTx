# 🎶 ThinkSound

<p align="center">
  Jeśli uznasz ten projekt za przydatny, gwiazdka ⭐ na GitHubie będzie bardzo mile widziana!
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

---

**ThinkSound** to zunifikowane środowisko generowania Any2Audio z dopasowaniem przepływu sterowanym przez rozumowanie Chain-of-Thought (CoT).

Implementacja PyTorch do multimodalnej generacji i edycji dźwięku: generuj lub edytuj dźwięk na podstawie wideo, tekstu oraz dźwięku, napędzana przez rozumowanie krok po kroku z wykorzystaniem Multimodalnych Dużych Modeli Językowych (MLLM).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Aktualności
- **2025.07** &nbsp; 🔥Demo online na [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) oraz [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) do interaktywnego korzystania!
- **2025.07** &nbsp; 🔥Wydano skrypty do wnioskowania i interfejs webowy;
- **2025.06** &nbsp; 🔥[Artykuł ThinkSound](https://arxiv.org/pdf/2506.21448) opublikowany na arXiv!
- **2025.06** &nbsp; 🔥[Demo online](http://thinksound-project.github.io/) już dostępne – wypróbuj teraz!

---

## 🚀 Funkcje

- **Any2Audio**: Generuj dźwięk z dowolnej modalności — wideo, tekstu, dźwięku lub ich kombinacji.
- **Video-to-Audio SOTA**: Osiąga najnowsze wyniki na wielu benchmarkach V2A.
- **CoT-Driven Reasoning**: Rozumowanie Chain-of-Thought dla kompozycyjnej i kontrolowanej generacji dźwięku przez MLLM.
- **Interaktywna Edycja Skoncentrowana na Obiektach**: Ulepszaj lub edytuj konkretne zdarzenia dźwiękowe poprzez kliknięcie na obiekt wizualny lub użycie instrukcji tekstowych.
- **Zunifikowany Framework**: Jeden model bazowy obsługuje generowanie, edycję oraz interaktywny workflow.

---

## ✨ Przegląd Metody

ThinkSound rozkłada generowanie i edycję dźwięku na trzy interaktywne etapy, wszystkie sterowane rozumowaniem Chain-of-Thought (CoT) opartym na MLLM:

1. **Generowanie Foley:** Tworzenie podstawowych, semantycznie i czasowo dopasowanych pejzaży dźwiękowych na podstawie wideo.
2. **Refinacja Skoncentrowana na Obiekcie:** Ulepszaj lub dodawaj dźwięki dla obiektów wskazanych przez użytkownika za pomocą kliknięć lub zaznaczeń na wideo.
3. **Celowana Edycja Dźwięku:** Modyfikuj wygenerowany dźwięk za pomocą złożonych instrukcji w języku naturalnym.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Duży, oznaczony danymi CoT zbiór danych (**AudioCoT**) wykorzystywany jest do trenowania zarówno modułu rozumowania, jak i zunifikowanego modelu bazowego dźwięku.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Szybki Start

**Przygotowanie środowiska:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Pobierz wytrenowane wagi https://huggingface.co/liuhuadai/ThinkSound do katalogu ckpts/
# Wagi modelu można również pobrać z https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Ustaw jako wykonywalny**
```bash
chmod +x scripts/demo.sh
```

**Uruchom skrypt**
```bash
./scripts/demo.sh <ścieżka_do_wideo> <opis> <opis_CoT>
```

### Korzystanie z interfejsu webowego

Aby uzyskać interaktywne doświadczenie, uruchom webowy interfejs Gradio:

```bash
python app.py
```

---
## 📝 DO ZROBIENIA

- ☐ Udostępnić skrypty treningowe dla modeli ThinkSound
- ☐ Udostępnić jako open-source zbiór danych AudioCoT oraz zautomatyzowany pipeline
- ☐ Zapewnić szczegółową dokumentację oraz referencję API
- ☐ Dodać wsparcie dla dodatkowych modalności i zadań końcowych

---

## 📄 Licencja

Ten projekt jest udostępniany na licencji [Apache 2.0](LICENSE).

> **Uwaga:**  
> Kod, modele i zbiór danych są **wyłącznie do celów badawczych i edukacyjnych**.  
> **Użycie komercyjne NIE jest dozwolone.**
>
> W sprawie licencji komercyjnej prosimy o kontakt z autorami.

---

## 📖 Cytowanie

Jeśli ThinkSound okaże się przydatny w Twoich badaniach lub pracy, prosimy o cytowanie naszej publikacji:

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

✨ Zachęcamy do [otwarcia zgłoszenia](https://github.com/liuhuadai/ThinkSound/issues) lub kontaktu mailowego ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)), jeśli masz pytania lub sugestie!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---