<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Snelle en hoogwaardige zero-shot tekst-naar-spraak met flow matching
</div>

## Overzicht

ZipVoice is een serie snelle en hoogwaardige zero-shot TTS-modellen gebaseerd op flow matching.

### 1. Belangrijkste kenmerken

- Klein en snel: slechts 123M parameters.

- Hoogwaardige stemklonen: state-of-the-art prestaties in spreker-gelijkenis, verstaanbaarheid en natuurlijkheid.

- Meertalig: ondersteunt Chinees en Engels.

- Multi-modus: ondersteunt zowel enkelspreker- als dialoogspraakgeneratie.

### 2. Modelvarianten

<table>
  <thead>
    <tr>
      <th>Modelnaam</th>
      <th>Beschrijving</th>
      <th>Paper</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Het basismodel dat zero-shot enkelspreker TTS in zowel Chinees als Engels ondersteunt.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>De gedistilleerde versie van ZipVoice, met verbeterde snelheid en minimale prestatievermindering.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Een dialooggeneratiemodel gebaseerd op ZipVoice, in staat om enkelkanaals tweepartijdialogen te genereren.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>De stereo-variant van ZipVoice-Dialog, waarmee tweekanaals dialooggeneratie mogelijk is met elke spreker op een eigen kanaal.</td>
    </tr>
  </tbody>
</table>

## Nieuws

**2025/07/14**: **ZipVoice-Dialog** en **ZipVoice-Dialog-Stereo**, twee spraakdialooggeneratiemodellen, zijn uitgebracht. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: **OpenDialog** dataset, een 6,8k-uur gesproken dialoogdataset, is uitgebracht. Download op [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Bekijk details op [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** en **ZipVoice-Distill** zijn uitgebracht. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Installatie

### 1. Clone de ZipVoice-repository


```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Optioneel) Maak een Python virtuele omgeving aan


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Installeer de vereiste pakketten


```bash
pip install -r requirements.txt
```
### 4. Installeer k2 voor training of efficiënte inferentie

**k2 is noodzakelijk voor training** en kan de inferentie versnellen. Toch kun je de inferentiemodus van ZipVoice gebruiken zonder k2 te installeren.

> **Opmerking:** Zorg ervoor dat je de k2-versie installeert die overeenkomt met jouw PyTorch- en CUDA-versie. Bijvoorbeeld, als je pytorch 2.5.1 en CUDA 12.1 gebruikt, kun je k2 als volgt installeren:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Raadpleeg https://k2-fsa.org/get-started/k2/ voor meer informatie.
Gebruikers op het Chinese vasteland kunnen terecht op https://k2-fsa.org/zh-CN/get-started/k2/.

- Om de installatie van k2 te controleren:


```
python3 -c "import k2; print(k2.__file__)"
```
## Gebruik

### 1. Enkelspreker spraakgeneratie

Om enkelspreker spraak te genereren met onze voorgetrainde ZipVoice of ZipVoice-Distill modellen, gebruikt u de volgende commando's (Vereiste modellen worden gedownload van HuggingFace):

#### 1.1 Inferentie van een enkele zin


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` kan `zipvoice` of `zipvoice_distill` zijn, wat respectievelijk de modellen vóór en na distillatie zijn.
- Als `<>` of `[]` in de tekst voorkomen, worden de door hen omsloten tekenreeksen als speciale tokens behandeld. `<>` geeft Chinese pinyin aan en `[]` geeft andere speciale tags aan.
- ONNX-modellen kunnen sneller op de CPU draaien met `zipvoice.bin.infer_zipvoice_onnx`.

> **Opmerking:** Als je problemen hebt met verbinden met HuggingFace, probeer dan:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 Inferentie van een lijst met zinnen


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Elke regel van `test.tsv` heeft het formaat `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Dialoogspraakgeneratie

#### 2.1 Inferentiecommando

Om tweepartijgesprekken te genereren met onze voorgetrainde ZipVoice-Dialogue of ZipVoice-Dialogue-Stereo modellen, gebruikt u de volgende commando's (Benodigde modellen worden gedownload van HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` kan `zipvoice_dialog` of `zipvoice_dialog_stereo` zijn,
    die respectievelijk mono- en stereodialogen genereren.

#### 2.2 Invoerformaten

Elke regel van `test.tsv` is in een van de volgende formaten:

(1) **Samengevoegd promptformaat** waarbij de audio's en transcripties van de prompts van twee sprekers zijn samengevoegd in één prompt-wav-bestand:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```
- `wav_name` is de naam van het uitvoer-wav-bestand.
- `prompt_transcription` is de transcriptie van het conversatieprompt-wav, bijvoorbeeld "[S1] Hallo. [S2] Hoe gaat het?"
- `prompt_wav` is het pad naar het prompt-wav-bestand.
- `text` is de te synthetiseren tekst, bijvoorbeeld "[S1] Het gaat goed. [S2] Hoe heet je?"

(2) **Gesplitst promptformaat** waarbij de audio's en transcripties van twee sprekers in aparte bestanden staan:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` is de naam van het uitvoer-wav-bestand.
- `spk1_prompt_transcription` is de transcriptie van het prompt-wav-bestand van spreker 1, bijvoorbeeld "Hallo"
- `spk2_prompt_transcription` is de transcriptie van het prompt-wav-bestand van spreker 2, bijvoorbeeld "Hoe gaat het?"
- `spk1_prompt_wav` is het pad naar het prompt-wav-bestand van spreker 1.
- `spk2_prompt_wav` is het pad naar het prompt-wav-bestand van spreker 2.
- `text` is de te synthetiseren tekst, bijvoorbeeld "[S1] Het gaat goed. [S2] Hoe heet je?"

### 3. Overige functies

#### 3.1 Corrigeren van verkeerd uitgesproken Chinese polyfone karakters

We gebruiken [pypinyin](https://github.com/mozillazg/python-pinyin) om Chinese karakters om te zetten naar pinyin. Soms kan het echter **polyfone karakters** (多音字) verkeerd uitspreken.

Om deze uitspraakfouten handmatig te corrigeren, plaats de **gecorrigeerde pinyin** tussen punthaken `< >` en voeg het **toonteken** toe.

**Voorbeeld:**

- Originele tekst: `这把剑长三十公分`
- Corrigeer de pinyin van `长`:  `这把剑<chang2>三十公分`

> **Let op:** Als je handmatig meerdere pinyins wilt toewijzen, zet elke pinyin tussen `<>`, bijvoorbeeld `这把<jian4><chang2><san1>十公分`

## Train je eigen model

Zie de [egs](egs) directory voor voorbeelden van training, fine-tuning en evaluatie.

## Discussie & Communicatie

Je kunt direct discussiëren op [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Je kunt ook de QR-code scannen om lid te worden van onze Wechat-groep of ons Wechat-officiële account te volgen.

| Wechat Groep | Wechat Officieel Account |
| ------------ | ------------------------ |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Referentie


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