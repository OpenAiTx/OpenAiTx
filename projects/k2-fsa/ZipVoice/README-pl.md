
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

## Szybka i wysokiej jakości synteza mowy z tekstu bez uczenia głosu z dopasowaniem przepływu
</div>

## Przegląd

ZipVoice to seria szybkich i wysokiej jakości modeli TTS typu zero-shot opartych na flow matching.

### 1. Kluczowe cechy

- Mały i szybki: tylko 123M parametrów.

- Wysokiej jakości klonowanie głosu: najnowocześniejsza wydajność w zakresie podobieństwa mówcy, zrozumiałości i naturalności.

- Wielojęzyczny: obsługuje język chiński i angielski.

- Wielomodowy: obsługuje generowanie mowy pojedynczego mówcy oraz dialogów.

### 2. Warianty modeli

<table>
  <thead>
    <tr>
      <th>Nazwa modelu</th>
      <th>Opis</th>
      <th>Publikacja</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Podstawowy model obsługujący zero-shot TTS dla pojedynczego mówcy w języku chińskim i angielskim.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>Wersja destylowana ZipVoice, charakteryzująca się zwiększoną szybkością przy minimalnej utracie wydajności.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Model generowania dialogów oparty na ZipVoice, zdolny do generowania jednopasmowych, dwustronnych dialogów mówionych.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>Wariant stereo ZipVoice-Dialog, umożliwiający generowanie dwukanałowych dialogów z przypisaniem każdego rozmówcy do oddzielnego kanału.</td>
    </tr>
  </tbody>
</table>

## Aktualności

**2025/07/14**: Modele generowania mowy dialogowej **ZipVoice-Dialog** oraz **ZipVoice-Dialog-Stereo** zostały wydane. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: Zbiór danych **OpenDialog**, obejmujący 6,8 tysiąca godzin dialogów mówionych, został wydany. Pobierz z [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Szczegóły na [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

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


```bash
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
- `--model-name` może być `zipvoice` lub `zipvoice_distill`, które oznaczają modele przed i po destylacji, odpowiednio.
- Jeśli w tekście pojawią się `<>` lub `[]`, ciągi znaków otoczone nimi będą traktowane jako specjalne tokeny. `<>` oznacza chińską transkrypcję pinyin, a `[]` oznacza inne specjalne tagi.

#### 1.2 Wnioskowanie listy zdań

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
- `prompt_transcription` to transkrypcja konwersacyjnego pliku wav, np. "[S1] Cześć. [S2] Jak się masz?"
- `prompt_wav` to ścieżka do pliku wav z promptem.
- `text` to tekst do syntezy, np. "[S1] Wszystko w porządku. [S2] Jak masz na imię? [S1] Jestem Eric. [S2] Cześć Eric."

(2) **Format podzielonego promptu**, gdzie nagrania i transkrypcje dwóch rozmówców znajdują się w osobnych plikach:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` to nazwa wyjściowego pliku wav.
- `spk1_prompt_transcription` to transkrypcja pliku wav z podpowiedzią pierwszego mówcy, np. "Hello"
- `spk2_prompt_transcription` to transkrypcja pliku wav z podpowiedzią drugiego mówcy, np. "How are you?"
- `spk1_prompt_wav` to ścieżka do pliku wav z podpowiedzią pierwszego mówcy.
- `spk2_prompt_wav` to ścieżka do pliku wav z podpowiedzią drugiego mówcy.
- `text` to tekst do syntezy, np. "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 Wskazówki dla lepszego użytkowania:

#### 3.1 Długość podpowiedzi

Zalecamy krótkie pliki wav z podpowiedzią (np. krótsze niż 3 sekundy dla generowania mowy jednego mówcy, krótsze niż 10 sekund dla generowania mowy w dialogu) dla szybszego działania. Bardzo długi plik z podpowiedzią spowolni działanie i pogorszy jakość mowy.

#### 3.2 Optymalizacja szybkości

Jeśli szybkość działania jest niezadowalająca, można ją zwiększyć następująco:

- **Model destylowany i mniej kroków**: Dla modelu generowania mowy jednego mówcy domyślnie używamy modelu `zipvoice` dla lepszej jakości mowy. Jeśli priorytetem jest szybkość, można przełączyć na `zipvoice_distill` i zmniejszyć `--num-steps` nawet do `4` (domyślnie 8).

- **Przyspieszenie CPU wielowątkowością**: Przy uruchamianiu na CPU można podać parametr `--num-thread` (np. `--num-thread 4`) aby zwiększyć liczbę wątków dla szybszej pracy. Domyślnie używamy 1 wątku.

- **Przyspieszenie CPU z ONNX**: Przy uruchamianiu na CPU można użyć modeli ONNX z `zipvoice.bin.infer_zipvoice_onnx` dla szybszego działania (nieobsługiwane jeszcze dla modeli generowania dialogów). Aby uzyskać jeszcze większą szybkość, można ustawić `--onnx-int8 True` aby użyć modelu ONNX z kwantyzacją INT8. Należy pamiętać, że model kwantyzowany będzie miał pewien spadek jakości mowy. **Nie używaj ONNX na GPU**, ponieważ jest wolniejszy niż PyTorch na GPU.

#### 3.3 Kontrola pamięci

Podany tekst zostanie podzielony na fragmenty na podstawie znaków interpunkcyjnych (dla generowania mowy jednego mówcy) lub symbolu zmiany mówcy (dla generowania mowy w dialogu). Następnie podzielone teksty będą przetwarzane w partiach. Dzięki temu model może przetwarzać dowolnie długi tekst przy niemal stałym zużyciu pamięci. Możesz kontrolować zużycie pamięci, regulując parametr `--max-duration`.

#### 3.4 Ocena "Raw"

Domyślnie wstępnie przetwarzamy wejścia (plik wav z podpowiedzią, transkrypcję podpowiedzi oraz tekst) dla efektywnego działania i lepszych wyników. Jeśli chcesz ocenić "surowe" działanie modelu na dokładnie podanych wejściach (np. aby odtworzyć wyniki z naszego artykułu), możesz podać `--raw-evaluation True`.

#### 3.5 Krótki tekst

Podczas generowania mowy dla bardzo krótkich tekstów (np. jedno lub dwa słowa), wygenerowana mowa może czasem pomijać pewne wymowy. Aby rozwiązać ten problem, można podać `--speed 0.3` (gdzie 0.3 to wartość do regulacji), aby wydłużyć czas trwania wygenerowanej mowy.

#### 3.6 Poprawianie błędnie wymawianych chińskich znaków wieloznacznych

Używamy [pypinyin](https://github.com/mozillazg/python-pinyin) do konwersji chińskich znaków na pinyin. Jednak czasami może błędnie wymawiać **znaki wieloznaczne** (多音字).


Aby ręcznie poprawić te błędne wymowy, umieść **poprawiony pinyin** w nawiasach kątowych `< >` i dodaj **oznaczenie tonu**.

**Przykład:**

- Oryginalny tekst: `这把剑长三十公分`
- Popraw pinyin `长`:  `这把剑<chang2>三十公分`

> **Uwaga:** Jeśli chcesz ręcznie przypisać wiele pinyinów, umieść każdy pinyin w `<>`, np. `这把<jian4><chang2><san1>十公分`

#### 3.7 Usuwanie długich pauz z wygenerowanej mowy

Model automatycznie określa pozycje i długości pauz w wygenerowanej mowie. Czasami pojawia się długa pauza w środku wypowiedzi. Jeśli nie chcesz tego, możesz przekazać `--remove-long-sil`, aby usunąć długie pauzy ze środka wygenerowanej mowy (pauzy na początku i końcu są usuwane domyślnie).

#### 3.8 Pobieranie modelu

Jeśli masz problem z połączeniem z HuggingFace podczas pobierania wstępnie wytrenowanych modeli, spróbuj przełączyć punkt końcowy na mirror: `export HF_ENDPOINT=https://hf-mirror.com`.

## Trenuj własny model

Zobacz katalog [egs](egs) dla przykładów trenowania, dostrajania i ewaluacji.

## Wdrażanie C++ 

Sprawdź [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) jako rozwiązanie wdrożeniowe w C++ na CPU.

## Dyskusja i komunikacja

Możesz bezpośrednio dyskutować na [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Możesz także zeskanować kod QR, aby dołączyć do naszej grupy na WeChat lub śledzić nasz oficjalny profil WeChat.

| Grupa WeChat | Oficjalny profil WeChat |
| ------------ | ----------------------- |
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---