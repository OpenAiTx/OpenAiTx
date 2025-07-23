<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

## Schnelle und hochwertige Zero-Shot-Text-zu-Sprache mit Flow Matching
</div>

## Übersicht

ZipVoice ist eine Serie schneller und hochwertiger Zero-Shot-TTS-Modelle, die auf Flow Matching basieren.

### 1. Hauptmerkmale

- Klein und schnell: nur 123M Parameter.

- Hochwertiges Voice Cloning: State-of-the-Art-Leistung bei Sprecherähnlichkeit, Verständlichkeit und Natürlichkeit.

- Mehrsprachig: unterstützt Chinesisch und Englisch.

- Multi-Mode: unterstützt sowohl Einzelsprecher- als auch Dialog-Sprachgenerierung.

### 2. Modellvarianten

<table>
  <thead>
    <tr>
      <th>Modellname</th>
      <th>Beschreibung</th>
      <th>Paper</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Das Basismodell, das Zero-Shot-Einzelsprecher-TTS in Chinesisch und Englisch unterstützt.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>Die destillierte Version von ZipVoice, mit verbesserter Geschwindigkeit und minimalem Leistungsverlust.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Ein Dialoggenerierungsmodell auf Basis von ZipVoice, das in der Lage ist, einspurige Zwei-Parteien-Gespräche zu erzeugen.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>Die Stereo-Variante von ZipVoice-Dialog, die Zwei-Kanal-Dialoggenerierung ermöglicht, wobei jeder Sprecher einem eigenen Kanal zugewiesen wird.</td>
    </tr>
  </tbody>
</table>

## Neuigkeiten

**2025/07/14**: **ZipVoice-Dialog** und **ZipVoice-Dialog-Stereo**, zwei gesprochene Dialoggenerierungsmodelle, sind veröffentlicht. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: **OpenDialog**-Datensatz, ein 6.8k-Stunden-Sprachdialogdatensatz, ist veröffentlicht. Download unter [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Details unter [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** und **ZipVoice-Distill** sind veröffentlicht. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Installation

### 1. Klonen Sie das ZipVoice-Repository


```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Optional) Erstellen Sie eine Python-virtuelle Umgebung


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Installieren Sie die erforderlichen Pakete


```bash
pip install -r requirements.txt
```
### 4. Installieren Sie k2 für das Training oder effizientes Inferenzieren

**k2 ist für das Training notwendig** und kann die Inferenz beschleunigen. Dennoch können Sie den Inferenzmodus von ZipVoice auch ohne die Installation von k2 verwenden.

> **Hinweis:** Stellen Sie sicher, dass Sie die k2-Version installieren, die zu Ihrer PyTorch- und CUDA-Version passt. Wenn Sie beispielsweise pytorch 2.5.1 und CUDA 12.1 verwenden, können Sie k2 wie folgt installieren:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Bitte beachten Sie https://k2-fsa.org/get-started/k2/ für weitere Details.
Nutzer in Festlandchina können https://k2-fsa.org/zh-CN/get-started/k2/ nutzen.

- Um die k2-Installation zu überprüfen:


```
python3 -c "import k2; print(k2.__file__)"
```
## Verwendung

### 1. Sprachgenerierung mit einem Sprecher

Um Sprachaufnahmen mit nur einem Sprecher mithilfe unserer vortrainierten ZipVoice- oder ZipVoice-Distill-Modelle zu erzeugen, verwenden Sie die folgenden Befehle (Erforderliche Modelle werden von HuggingFace heruntergeladen):

#### 1.1 Inferenz eines einzelnen Satzes


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` kann `zipvoice` oder `zipvoice_distill` sein, was jeweils die Modelle vor und nach der Destillation bezeichnet.
- Wenn `<>` oder `[]` im Text erscheinen, werden die darin eingeschlossenen Zeichenfolgen als spezielle Tokens behandelt. `<>` steht für chinesische Pinyin und `[]` für andere spezielle Tags.
- Mit `zipvoice.bin.infer_zipvoice_onnx` können ONNX-Modelle auf der CPU schneller ausgeführt werden.

> **Hinweis:** Wenn Sie Probleme beim Verbinden mit HuggingFace haben, versuchen Sie Folgendes:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 Inferenz einer Liste von Sätzen


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Jede Zeile von `test.tsv` hat das Format `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Dialog-Sprachgenerierung

#### 2.1 Inferenzbefehl

Um Zwei-Parteien-Dialoge mit unseren vortrainierten ZipVoice-Dialogue oder ZipVoice-Dialogue-Stereo Modellen zu generieren, verwenden Sie die folgenden Befehle (Die benötigten Modelle werden von HuggingFace heruntergeladen):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` kann entweder `zipvoice_dialog` oder `zipvoice_dialog_stereo` sein,
    wobei jeweils Mono- bzw. Stereo-Dialoge erzeugt werden.

#### 2.2 Eingabeformate

Jede Zeile in `test.tsv` hat eines der folgenden Formate:

(1) **Zusammengeführtes Prompt-Format**, bei dem die Audiodateien und Transkriptionen der Prompts beider Sprecher in einer Prompt-WAV-Datei zusammengeführt werden:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```
- `wav_name` ist der Name der Ausgabedatei im wav-Format.
- `prompt_transcription` ist die Transkription der Gesprächsvorgabe-wav, z. B. "[S1] Hallo. [S2] Wie geht es dir?"
- `prompt_wav` ist der Pfad zur Vorgabe-wav.
- `text` ist der zu synthetisierende Text, z. B. "[S1] Mir geht es gut. [S2] Wie heißt du?"

(2) **Geteiltes Prompt-Format**, bei dem die Audiodateien und Transkriptionen der beiden Sprecher in separaten Dateien vorliegen:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` ist der Name der Ausgabedatei im wav-Format.
- `spk1_prompt_transcription` ist die Transkription der Prompt-wav des ersten Sprechers, z. B. "Hallo"
- `spk2_prompt_transcription` ist die Transkription der Prompt-wav des zweiten Sprechers, z. B. "Wie geht's?"
- `spk1_prompt_wav` ist der Pfad zur Prompt-wav-Datei des ersten Sprechers.
- `spk2_prompt_wav` ist der Pfad zur Prompt-wav-Datei des zweiten Sprechers.
- `text` ist der zu synthetisierende Text, z. B. "[S1] Mir geht's gut. [S2] Wie heißt du?"

### 3. Weitere Funktionen

#### 3.1 Korrektur falsch ausgesprochener chinesischer Polyphon-Zeichen

Wir verwenden [pypinyin](https://github.com/mozillazg/python-pinyin), um chinesische Zeichen in Pinyin umzuwandeln. Allerdings kann es gelegentlich **Polyphon-Zeichen** (多音字) falsch aussprechen.

Um diese Fehlinterpretationen manuell zu korrigieren, setzen Sie das **korrigierte Pinyin** in spitze Klammern `< >` und fügen Sie die **Tonmarkierung** hinzu.

**Beispiel:**

- Originaltext: `这把剑长三十公分`
- Korrigiere das Pinyin von `长`:  `这把剑<chang2>三十公分`

> **Hinweis:** Wenn Sie mehreren Zeichen manuell Pinyin zuweisen möchten, setzen Sie jedes Pinyin in `<>`, z. B. `这把<jian4><chang2><san1>十公分`

## Eigenes Modell trainieren

Siehe das Verzeichnis [egs](egs) für Trainings-, Feinabstimmungs- und Bewertungsbeispiele.

## Diskussion & Kommunikation

Sie können direkt auf [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) diskutieren.

Sie können auch den QR-Code scannen, um unserer WeChat-Gruppe beizutreten oder unserem offiziellen WeChat-Account zu folgen.

| WeChat-Gruppe | Offizieller WeChat-Account |
| ------------- | -------------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Zitation


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