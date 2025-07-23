<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Szybki i Wysokiej Jakości Zero-Shot Text-to-Speech z Flow Matching
</div>

## Przegląd

ZipVoice to seria szybkich i wysokiej jakości modeli zero-shot TTS opartych na flow matching.

### 1. Najważniejsze cechy

- Mały i szybki: tylko 123M parametrów.

- Wysokiej jakości klonowanie głosu: najnowocześniejsza wydajność w zakresie podobieństwa głosu, zrozumiałości i naturalności.

- Wielojęzyczny: obsługa języka chińskiego i angielskiego.

- Tryb wielofunkcyjny: obsługa generowania mowy jednoosobowej oraz dialogów.

### 2. Warianty modelu

<table>
  <thead>
    <tr>
      <th>Nazwa modelu</th>
      <th>Opis</th>
      <th>Artykuł</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Podstawowy model wspierający zero-shot TTS jednoosobowy w języku chińskim i angielskim.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>Wersja destylowana ZipVoice, zapewniająca zwiększoną szybkość przy minimalnej utracie wydajności.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Model generowania dialogów oparty na ZipVoice, zdolny do generowania jednościeżkowych rozmów dwuosobowych.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>Wariant stereo ZipVoice-Dialog, umożliwiający generowanie dwukanałowych dialogów, gdzie każdy mówca jest przypisany do osobnego kanału.</td>
    </tr>
  </tbody>
</table>

## Aktualności

**2025/07/14**: **ZipVoice-Dialog** oraz **ZipVoice-Dialog-Stereo**, dwa modele generowania mówionych dialogów, zostały wydane. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: Zestaw danych **OpenDialog**, 6,8 tys. godzin nagrań dialogów mówionych, został wydany. Pobierz z [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Szczegóły na [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** oraz **ZipVoice-Distill** zostały wydane. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Instalacja

### 1. Sklonuj repozytorium ZipVoice


```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Opcjonalnie) Utwórz wirtualne środowisko Pythona


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Zainstaluj wymagane pakiety


```bash
pip install -r requirements.txt
```
### 4. Zainstaluj k2 do treningu lub wydajnego wnioskowania

**k2 jest niezbędne do treningu** i może przyspieszyć wnioskowanie. Niemniej jednak, możesz korzystać z trybu wnioskowania ZipVoice bez instalowania k2.

> **Uwaga:** Upewnij się, że instalujesz wersję k2 pasującą do Twojej wersji PyTorch i CUDA. Na przykład, jeśli używasz pytorch 2.5.1 i CUDA 12.1, możesz zainstalować k2 w następujący sposób:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Proszę zapoznać się ze stroną https://k2-fsa.org/get-started/k2/ po szczegóły.
Użytkownicy z Chin kontynentalnych mogą zapoznać się ze stroną https://k2-fsa.org/zh-CN/get-started/k2/.

- Aby sprawdzić instalację k2:


```
python3 -c "import k2; print(k2.__file__)"
```
## Użytkowanie

### 1. Generowanie mowy jednego mówcy

Aby wygenerować mowę jednego mówcy przy użyciu naszych wytrenowanych modeli ZipVoice lub ZipVoice-Distill, użyj następujących poleceń (wymagane modele zostaną pobrane z HuggingFace):

#### 1.1 Wnioskowanie dla pojedynczego zdania


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` może przyjmować wartości `zipvoice` lub `zipvoice_distill`, które oznaczają modele odpowiednio przed i po destylacji.
- Jeśli w tekście pojawią się `<>` lub `[]`, ciągi znaków objęte tymi znakami będą traktowane jako specjalne tokeny. `<>` oznacza chińskie pinyin, a `[]` oznacza inne specjalne tagi.
- Modele ONNX można uruchamiać szybciej na CPU za pomocą `zipvoice.bin.infer_zipvoice_onnx`.

> **Uwaga:** Jeśli masz problemy z połączeniem z HuggingFace, spróbuj:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 Wnioskowanie dla listy zdań


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Każda linia pliku `test.tsv` ma format `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Generowanie mowy dialogowej

#### 2.1 Polecenie inferencji

Aby wygenerować dwuosobowe dialogi mówione za pomocą naszych wytrenowanych modeli ZipVoice-Dialogue lub ZipVoice-Dialogue-Stereo, użyj następujących poleceń (Wymagane modele zostaną pobrane z HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` może przyjmować wartości `zipvoice_dialog` lub `zipvoice_dialog_stereo`,
    które generują odpowiednio dialogi mono i stereo.

#### 2.2 Format wejściowy

Każda linia w pliku `test.tsv` ma jeden z poniższych formatów:

(1) **Format scalonej podpowiedzi**, gdzie nagrania audio i transkrypcje dwóch mówców są scalone w jeden plik wav z podpowiedzią:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```
- `wav_name` to nazwa wyjściowego pliku wav.
- `prompt_transcription` to transkrypcja pliku wav z promptem konwersacyjnym, np. "[S1] Hello. [S2] How are you?"
- `prompt_wav` to ścieżka do pliku wav z promptem.
- `text` to tekst do syntezy, np. "[S1] I'm fine. [S2] What's your name?"

(2) **Format rozdzielonego promptu**, w którym nagrania i transkrypcje dwóch rozmówców znajdują się w osobnych plikach:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` to nazwa wyjściowego pliku wav.
- `spk1_prompt_transcription` to transkrypcja próbki wav pierwszego mówcy, np. "Hello"
- `spk2_prompt_transcription` to transkrypcja próbki wav drugiego mówcy, np. "How are you?"
- `spk1_prompt_wav` to ścieżka do próbki wav pierwszego mówcy.
- `spk2_prompt_wav` to ścieżka do próbki wav drugiego mówcy.
- `text` to tekst do syntezy, np. "[S1] I'm fine. [S2] What's your name?"

### 3. Inne funkcje

#### 3.1 Poprawianie błędnie wymawianych chińskich znaków wieloznacznych

Używamy [pypinyin](https://github.com/mozillazg/python-pinyin) do konwersji chińskich znaków na pinyin. Jednak czasami może błędnie wymówić **znaki wieloznaczne** (多音字).

Aby ręcznie poprawić te błędy wymowy, należy umieścić **poprawny pinyin** w nawiasach ostrych `< >` i dodać **znak tonu**.

**Przykład:**

- Oryginalny tekst: `这把剑长三十公分`
- Popraw pinyin znaku `长`: `这把剑<chang2>三十公分`

> **Uwaga:** Jeśli chcesz ręcznie przypisać kilka pinyinów, umieść każdy pinyin w `<>`, np. `这把<jian4><chang2><san1>十公分`

## Trenuj swój własny model

Zobacz katalog [egs](egs) po przykłady trenowania, fine-tuningu i ewaluacji.

## Dyskusja i komunikacja

Możesz bezpośrednio dyskutować na [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Możesz także zeskanować kod QR, aby dołączyć do naszej grupy na WeChat lub obserwować nasze oficjalne konto WeChat.

| Grupa WeChat | Oficjalne konto WeChat |
| ------------ | ---------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Cytowanie


```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---