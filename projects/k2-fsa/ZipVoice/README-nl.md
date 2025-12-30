
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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

## Snel en Hoogwaardige Zero-Shot Tekst-naar-Spraak met Flow Matching
</div>

## Overzicht

ZipVoice is een serie snelle en hoogwaardige zero-shot TTS-modellen gebaseerd op flow matching.

### 1. Belangrijkste kenmerken

- Klein en snel: slechts 123M parameters.

- Hoogwaardige stemkloning: state-of-the-art prestaties in spreker-gelijkenis, verstaanbaarheid en natuurlijkheid.

- Meertalig: ondersteunt Chinees en Engels.

- Multi-modus: ondersteunt zowel enkelspreker als dialoogspraakgeneratie.

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
      <td>Het basismodel dat zero-shot enkelspreker TTS ondersteunt in zowel Chinees als Engels.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>De gedistilleerde versie van ZipVoice, met verbeterde snelheid en minimale prestatiedaling.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Een dialooggeneratiemodel gebaseerd op ZipVoice, dat enkelkanaals tweezijdige gesproken dialogen kan genereren.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>De stereo-variant van ZipVoice-Dialog, waarmee tweekanaals dialooggeneratie mogelijk is waarbij elke spreker aan een afzonderlijk kanaal wordt toegewezen.</td>
    </tr>
  </tbody>
</table>

## Nieuws

**2025/07/14**: **ZipVoice-Dialog** en **ZipVoice-Dialog-Stereo**, twee modellen voor gesproken dialooggeneratie, zijn uitgebracht. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: **OpenDialog** dataset, een 6,8k-uur gesproken dialoogdataset, is uitgebracht. Download via [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Bekijk details via [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** en **ZipVoice-Distill** zijn uitgebracht. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Installatie

### 1. Clone de ZipVoice repository

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


```bash
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
- Als `<>` of `[]` in de tekst verschijnen, worden de door hen omsloten strings behandeld als speciale tokens. `<>` duidt op Chinese pinyin en `[]` op andere speciale tags.

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
- `prompt_transcription` is de transcriptie van de conversatieprompt-wav, bijvoorbeeld: "[S1] Hallo. [S2] Hoe gaat het?"
- `prompt_wav` is het pad naar de prompt-wav.
- `text` is de te synthetiseren tekst, bijvoorbeeld: "[S1] Het gaat goed. [S2] Hoe heet je? [S1] Ik ben Eric. [S2] Hallo Eric."

(2) **Gesplitst promptformaat** waarbij de audio's en transcripties van twee sprekers in afzonderlijke bestanden staan:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```

- `wav_name` is de naam van het uitvoer wav-bestand.
- `spk1_prompt_transcription` is de transcriptie van het prompt wav-bestand van de eerste spreker, bijvoorbeeld "Hallo".
- `spk2_prompt_transcription` is de transcriptie van het prompt wav-bestand van de tweede spreker, bijvoorbeeld "Hoe gaat het?"
- `spk1_prompt_wav` is het pad naar het prompt wav-bestand van de eerste spreker.
- `spk2_prompt_wav` is het pad naar het prompt wav-bestand van de tweede spreker.
- `text` is de te synthetiseren tekst, bijvoorbeeld "[S1] Het gaat goed. [S2] Hoe heet je? [S1] Ik ben Eric. [S2] Hallo Eric."

### 3 Richtlijnen voor beter gebruik:

#### 3.1 Lengte van de prompt

Wij raden een kort prompt wav-bestand aan (bijvoorbeeld minder dan 3 seconden voor spraakgeneratie met één spreker, minder dan 10 seconden voor dialoogspraakgeneratie) voor snellere inferentiesnelheid. Een heel lang promptbestand vertraagt de inferentie en verslechtert de spraakkwaliteit.

#### 3.2 Snelheidsoptimalisatie

Als de inferentiesnelheid onvoldoende is, kun je deze als volgt verhogen:

- **Gedistilleerd model en minder stappen**: Voor het spraakgeneratiemodel met één spreker gebruiken we standaard het `zipvoice`-model voor betere spraakkwaliteit. Als een hogere snelheid de prioriteit heeft, kun je overschakelen op `zipvoice_distill` en het aantal stappen (`--num-steps`) verlagen tot minimaal `4` (standaard 8).

- **CPU-versnelling met multithreading**: Bij gebruik van de CPU kun je de parameter `--num-thread` meegeven (bijv. `--num-thread 4`) om het aantal threads te verhogen voor meer snelheid. Standaard gebruiken we 1 thread.

- **CPU-versnelling met ONNX**: Bij gebruik van de CPU kun je ONNX-modellen gebruiken met `zipvoice.bin.infer_zipvoice_onnx` voor hogere snelheid (ONNX wordt nog niet ondersteund voor dialooggeneratiemodellen). Voor nog meer snelheid kun je `--onnx-int8 True` instellen om een INT8-gekwantiseerd ONNX-model te gebruiken. Houd er rekening mee dat het gekwantiseerde model leidt tot een zekere mate van degradatie van de spraakkwaliteit. **Gebruik ONNX niet op GPU**, omdat het trager is dan PyTorch op GPU.

- **GPU-versnelling met NVIDIA TensorRT**: Voor een aanzienlijke prestatieverbetering op NVIDIA GPU's exporteer je eerst het model naar een TensorRT-engine met zipvoice.bin.tensorrt_export. Voer daarna inferentie uit op je dataset (bijvoorbeeld een Hugging Face-dataset) met zipvoice.bin.infer_zipvoice. Dit kan ongeveer 2x meer throughput behalen dan de standaard PyTorch-implementatie op een GPU.

#### 3.3 Geheugenbeheer

De opgegeven tekst wordt gesplitst in stukken op basis van leestekens (voor spraakgeneratie met één spreker) of sprekerwisselsymbolen (voor dialoogspraakgeneratie). Vervolgens worden de tekststukken in batches verwerkt. Hierdoor kan het model willekeurig lange tekst verwerken met vrijwel constant geheugengebruik. Je kunt het geheugengebruik regelen met de parameter `--max-duration`.

#### 3.4 "Ruwe" evaluatie

Standaard preprocessen we de invoer (prompt wav, prompt transcriptie en tekst) voor efficiënte inferentie en betere prestaties. Als je de "ruwe" prestaties van het model wilt evalueren met exact de opgegeven invoer (bijvoorbeeld om de resultaten in ons paper te reproduceren), kun je `--raw-evaluation True` meegeven.

#### 3.5 Korte tekst

Bij het genereren van spraak voor zeer korte teksten (bijvoorbeeld één of twee woorden) kan het gebeuren dat bepaalde uitspraken soms worden weggelaten. Om dit probleem op te lossen kun je `--speed 0.3` meegeven (waarbij 0.3 een afstembare waarde is) om de duur van de gegenereerde spraak te verlengen.

#### 3.6 Het corrigeren van verkeerd uitgesproken Chinese polyfoonkarakters

We gebruiken [pypinyin](https://github.com/mozillazg/python-pinyin) om Chinese karakters naar pinyin om te zetten. Echter, het kan soms **polyfone karakters** (多音字) verkeerd uitspreken.

Om deze verkeerde uitspraken handmatig te corrigeren, zet je de **gecorrigeerde pinyin** tussen punthaken `< >` en voeg je het **toonaccent** toe.

**Voorbeeld:**

- Originele tekst: `这把剑长三十公分`
- Corrigeer de pinyin van `长`:  `这把剑<chang2>三十公分`

> **Opmerking:** Wil je handmatig meerdere pinyins toewijzen, zet dan elke pinyin tussen `<>`, bijvoorbeeld: `这把<jian4><chang2><san1>十公分`

#### 3.7 Verwijder lange stiltes uit de gegenereerde spraak

Het model bepaalt automatisch de posities en lengtes van stiltes in de gegenereerde spraak. Soms zit er een lange stilte midden in de spraak. Wil je dit niet, dan kun je `--remove-long-sil` meegeven om lange stiltes in het midden van de gegenereerde spraak te verwijderen (randstiltes worden standaard verwijderd).

#### 3.8 Model downloaden

Als je problemen hebt met verbinden naar HuggingFace bij het downloaden van de voorgetrainde modellen, probeer dan het endpoint te wisselen naar de mirror-site: `export HF_ENDPOINT=https://hf-mirror.com`.

## Train Je Eigen Model

Zie de [egs](egs) map voor voorbeelden van training, fine-tuning en evaluatie.

## Productie Implementatie

### NVIDIA Triton GPU Runtime

Voor productieklare implementatie met hoge prestaties en schaalbaarheid, bekijk de [Triton Inference Server integratie](runtime/nvidia_triton/) die geoptimaliseerde TensorRT-engines, gelijktijdige aanvraagverwerking en zowel gRPC/HTTP API's voor zakelijk gebruik biedt.

### CPU Implementatie

Bekijk [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) voor de C++ implementatie-oplossing op CPU.

## Discussie & Communicatie

Je kunt direct discussiëren op [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Je kunt ook de QR-code scannen om lid te worden van onze wechat-groep of ons officiële wechat-account te volgen.

| Wechat Groep | Wechat Officieel Account |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Citaat

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-30

---