
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

ZipVoice ist eine Serie von schnellen und hochwertigen Zero-Shot-TTS-Modellen, die auf Flow Matching basieren.

### 1. Hauptmerkmale

- Klein und schnell: nur 123M Parameter.

- Hochwertiges Voice Cloning: branchenführende Leistung bei Sprecherähnlichkeit, Verständlichkeit und Natürlichkeit.

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
      <td>Die destillierte Version von ZipVoice mit verbesserter Geschwindigkeit und minimalem Leistungsverlust.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Ein Dialoggenerierungsmodell, das auf ZipVoice basiert und einsprachige Zwei-Parteien-Gespräche erzeugen kann.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>Die Stereo-Variante von ZipVoice-Dialog, ermöglicht zweikanalige Dialoggenerierung mit jedem Sprecher auf einem eigenen Kanal.</td>
    </tr>
  </tbody>
</table>

## Neuigkeiten

**2025/07/14**: **ZipVoice-Dialog** und **ZipVoice-Dialog-Stereo**, zwei Modelle zur gesprochenen Dialoggenerierung, sind veröffentlicht. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![Demo-Seite](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: **OpenDialog** Datensatz, ein 6,8k-Stunden-Datensatz für gesprochene Dialoge, ist veröffentlicht. Download unter [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Details unter [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** und **ZipVoice-Distill** sind veröffentlicht. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![Demo-Seite](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Installation

### 1. Klone das ZipVoice-Repository

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


```bash
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
- Wenn `<>` oder `[]` im Text erscheinen, werden von ihnen eingeschlossene Zeichenfolgen als spezielle Tokens behandelt. `<>` steht für chinesische Pinyin und `[]` für andere spezielle Tags.

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
- `prompt_transcription` ist die Transkription der Konversationsaufforderung (Prompt-wav), z.B. "[S1] Hallo. [S2] Wie geht es dir?"
- `prompt_wav` ist der Pfad zur Prompt-wav-Datei.
- `text` ist der zu synthetisierende Text, z.B. "[S1] Mir geht es gut. [S2] Wie heißt du? [S1] Ich bin Eric. [S2] Hallo Eric."

(2) **Geteiltes Prompt-Format**, bei dem die Audiodateien und Transkriptionen der beiden Sprecher in separaten Dateien vorliegen:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` ist der Name der Ausgabedatei im WAV-Format.
- `spk1_prompt_transcription` ist die Transkription der Prompt-WAV-Datei des ersten Sprechers, z. B. „Hallo“.
- `spk2_prompt_transcription` ist die Transkription der Prompt-WAV-Datei des zweiten Sprechers, z. B. „Wie geht es dir?“
- `spk1_prompt_wav` ist der Pfad zur Prompt-WAV-Datei des ersten Sprechers.
- `spk2_prompt_wav` ist der Pfad zur Prompt-WAV-Datei des zweiten Sprechers.
- `text` ist der zu synthetisierende Text, z. B. „[S1] Mir geht's gut. [S2] Wie heißt du? [S1] Ich bin Eric. [S2] Hallo Eric.“

### 3 Hinweise für bessere Nutzung:

#### 3.1 Promptlänge

Wir empfehlen eine kurze Prompt-WAV-Datei (z. B. weniger als 3 Sekunden für die Sprachsynthese mit einem Sprecher, weniger als 10 Sekunden für die Dialog-Sprachsynthese) für eine schnellere Inferenzgeschwindigkeit. Eine sehr lange Prompt-Datei verlangsamt die Inferenz und verschlechtert die Sprachqualität.

#### 3.2 Geschwindigkeitsoptimierung

Falls die Inferenzgeschwindigkeit unzureichend ist, können Sie diese wie folgt erhöhen:

- **Distill-Modell und weniger Schritte**: Für das Einzelsprecher-Sprachgenerierungsmodell verwenden wir standardmäßig das `zipvoice`-Modell für bessere Sprachqualität. Wenn schnellere Geschwindigkeit Priorität hat, können Sie auf `zipvoice_distill` umschalten und die Anzahl der `--num-steps` auf bis zu `4` reduzieren (Standard ist 8).

- **CPU-Beschleunigung durch Multithreading**: Beim Ausführen auf der CPU können Sie den Parameter `--num-thread` (z. B. `--num-thread 4`) verwenden, um die Anzahl der Threads für höhere Geschwindigkeit zu erhöhen. Standardmäßig wird 1 Thread verwendet.

- **CPU-Beschleunigung mit ONNX**: Beim Ausführen auf der CPU können Sie ONNX-Modelle mit `zipvoice.bin.infer_zipvoice_onnx` für höhere Geschwindigkeit verwenden (ONNX wird für Dialoggenerierungsmodelle bisher nicht unterstützt). Für noch höhere Geschwindigkeit können Sie zusätzlich `--onnx-int8 True` setzen, um ein INT8-quantisiertes ONNX-Modell zu nutzen. Beachten Sie, dass das quantisierte Modell zu einer gewissen Verschlechterung der Sprachqualität führt. **Verwenden Sie ONNX nicht auf der GPU**, da es langsamer ist als PyTorch auf der GPU.

#### 3.3 Speichersteuerung

Der angegebene Text wird anhand von Satzzeichen (für Einzelsprecher-Sprachsynthese) oder Sprecherwechsel-Symbolen (für Dialog-Sprachsynthese) in Abschnitte unterteilt. Anschließend werden die Abschnitte stapelweise verarbeitet. Das Modell kann daher beliebig lange Texte mit nahezu konstantem Speicherverbrauch verarbeiten. Sie können den Speicherverbrauch durch Anpassung des Parameters `--max-duration` steuern.

#### 3.4 „Raw“-Bewertung

Standardmäßig werden die Eingaben (Prompt-WAV, Prompt-Transkription und Text) vorverarbeitet, um eine effiziente Inferenz und bessere Leistung zu erzielen. Wenn Sie die „rohe“ Leistung des Modells mit den exakt vorgegebenen Eingaben bewerten möchten (z. B. um die Ergebnisse aus unserer Publikation zu reproduzieren), können Sie `--raw-evaluation True` verwenden.

#### 3.5 Kurzer Text

Bei der Spracherzeugung für sehr kurze Texte (z. B. ein oder zwei Wörter) kann es vorkommen, dass die erzeugte Sprache bestimmte Aussprachen auslässt. Um dieses Problem zu beheben, können Sie `--speed 0.3` verwenden (wobei 0.3 ein anpassbarer Wert ist), um die Dauer der erzeugten Sprache zu verlängern.

#### 3.6 Korrektur falsch ausgesprochener chinesischer Polyphon-Zeichen

Wir verwenden [pypinyin](https://github.com/mozillazg/python-pinyin), um chinesische Schriftzeichen in Pinyin umzuwandeln. Allerdings kann es gelegentlich zu falscher Aussprache von **Polyphon-Zeichen** (多音字) kommen.


Um diese Fehl-Aussprache manuell zu korrigieren, setze das **korrigierte Pinyin** in spitze Klammern `< >` und füge das **Tonzeichen** hinzu.

**Beispiel:**

- Originaltext: `这把剑长三十公分`
- Korrigiere das Pinyin von `长`:  `这把剑<chang2>三十公分`

> **Hinweis:** Wenn du mehreren Zeichen manuell Pinyin zuweisen möchtest, setze jedes Pinyin in `< >`, z.B.: `这把<jian4><chang2><san1>十公分`

#### 3.7 Entfernen von langen Pausen aus der generierten Sprache

Das Modell bestimmt automatisch die Positionen und Längen der Pausen in der generierten Sprache. Gelegentlich gibt es eine lange Pause mitten in der Sprache. Wenn du das nicht möchtest, kannst du `--remove-long-sil` verwenden, um lange Pausen in der Mitte der generierten Sprache zu entfernen (Randpausen werden standardmäßig entfernt).

#### 3.8 Modell-Download

Wenn du beim Herunterladen der vortrainierten Modelle Probleme hast, dich mit HuggingFace zu verbinden, versuche, den Endpunkt auf die Mirror-Seite zu wechseln: `export HF_ENDPOINT=https://hf-mirror.com`.

## Trainiere dein eigenes Modell

Siehe das [egs](egs) Verzeichnis für Beispiele zum Training, Fine-Tuning und zur Auswertung.

## C++-Bereitstellung

Siehe [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) für die C++-Bereitstellungslösung auf der CPU.

## Diskussion & Kommunikation

Du kannst direkt in [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) diskutieren.

Du kannst auch den QR-Code scannen, um unserer Wechat-Gruppe beizutreten oder unserem offiziellen Wechat-Account zu folgen.

| Wechat-Gruppe | Offizieller Wechat-Account |
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---