<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">Inglese</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Italiano</a>
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

## Sintesi vocale testuale zero-shot veloce e di alta qualità con Flow Matching
</div>

## Panoramica

ZipVoice è una serie di modelli TTS zero-shot veloci e di alta qualità basati su flow matching.

### 1. Caratteristiche principali

- Piccolo e veloce: solo 123M parametri.

- Clonazione vocale di alta qualità: prestazioni all'avanguardia in somiglianza della voce, intelligibilità e naturalezza.

- Multilingue: supporta cinese e inglese.

- Multimodale: supporta la generazione vocale sia per singolo parlante sia per dialoghi.

### 2. Varianti del modello

<table>
  <thead>
    <tr>
      <th>Nome Modello</th>
      <th>Descrizione</th>
      <th>Articolo</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>Il modello base che supporta la sintesi vocale testuale zero-shot per singolo parlante in cinese e inglese.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>La versione distillata di ZipVoice, con velocità migliorata e minima perdita di prestazioni.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Un modello per la generazione di dialoghi basato su ZipVoice, in grado di generare dialoghi parlati a due voci su un unico canale.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>La variante stereo di ZipVoice-Dialog, che consente la generazione di dialoghi su due canali con ogni parlante assegnato a un canale distinto.</td>
    </tr>
  </tbody>
</table>

## Novità

**14/07/2025**: **ZipVoice-Dialog** e **ZipVoice-Dialog-Stereo**, due modelli di generazione di dialoghi vocali, sono stati rilasciati. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**14/07/2025**: Il dataset **OpenDialog**, un dataset di dialoghi vocali di 6.8k ore, è stato rilasciato. Scaricalo da [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Dettagli su [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**16/06/2025**: **ZipVoice** e **ZipVoice-Distill** sono stati rilasciati. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Installazione

### 1. Clonare il repository ZipVoice


```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Opzionale) Crea un ambiente virtuale Python


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Installa i pacchetti richiesti


```bash
pip install -r requirements.txt
```
### 4. Installa k2 per l'addestramento o l'inferenza efficiente

**k2 è necessario per l'addestramento** e può velocizzare l'inferenza. Tuttavia, puoi comunque utilizzare la modalità di inferenza di ZipVoice senza installare k2.

> **Nota:** Assicurati di installare la versione di k2 che corrisponde alla tua versione di PyTorch e CUDA. Ad esempio, se stai usando pytorch 2.5.1 e CUDA 12.1, puoi installare k2 come segue:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Si prega di fare riferimento a https://k2-fsa.org/get-started/k2/ per i dettagli.
Gli utenti nella Cina continentale possono fare riferimento a https://k2-fsa.org/zh-CN/get-started/k2/.

- Per verificare l'installazione di k2:


```
python3 -c "import k2; print(k2.__file__)"
```
## Utilizzo

### 1. Generazione di parlato a singolo parlante

Per generare parlato a singolo parlante con i nostri modelli pre-addestrati ZipVoice o ZipVoice-Distill, utilizzare i seguenti comandi (i modelli necessari verranno scaricati da HuggingFace):

#### 1.1 Inferenza di una singola frase


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` può essere `zipvoice` o `zipvoice_distill`, che sono rispettivamente i modelli prima e dopo la distillazione.
- Se nel testo compaiono `<>` o `[]`, le stringhe racchiuse da essi saranno trattate come token speciali. `<>` indica il pinyin cinese e `[]` indica altri tag speciali.
- È possibile eseguire modelli ONNX sulla CPU più velocemente con `zipvoice.bin.infer_zipvoice_onnx`.

> **Nota:** Se hai problemi a connetterti a HuggingFace, prova:
> ```bash
> export HF_ENDPOINT=https://hf-mirror.com
> ```

#### 1.2 Inferenza di una lista di frasi


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Ogni riga di `test.tsv` è nel formato `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Generazione di dialoghi vocali

#### 2.1 Comando di inferenza

Per generare dialoghi vocali a due voci con i nostri modelli pre-addestrati ZipVoice-Dialogue o ZipVoice-Dialogue-Stereo, utilizzare i seguenti comandi (i modelli necessari saranno scaricati da HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` può essere `zipvoice_dialog` oppure `zipvoice_dialog_stereo`,
    che generano rispettivamente dialoghi mono e stereo.

#### 2.2 Formati di input

Ogni riga di `test.tsv` è in uno dei seguenti formati:

(1) **Formato prompt unificato** in cui gli audio e le trascrizioni dei prompt di due speaker sono uniti in un unico file wav prompt:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```
- `wav_name` è il nome del file wav di output.
- `prompt_transcription` è la trascrizione del prompt conversazionale wav, ad esempio, "[S1] Ciao. [S2] Come stai?"
- `prompt_wav` è il percorso del prompt wav.
- `text` è il testo da sintetizzare, ad esempio, "[S1] Sto bene. [S2] Come ti chiami?"

(2) **Formato prompt suddiviso** dove gli audio e le trascrizioni dei due parlanti esistono in file separati:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` è il nome del file wav di output.
- `spk1_prompt_transcription` è la trascrizione del prompt wav del primo speaker, ad esempio, "Ciao"
- `spk2_prompt_transcription` è la trascrizione del prompt wav del secondo speaker, ad esempio, "Come stai?"
- `spk1_prompt_wav` è il percorso del file wav del prompt del primo speaker.
- `spk2_prompt_wav` è il percorso del file wav del prompt del secondo speaker.
- `text` è il testo da sintetizzare, ad esempio. "[S1] Sto bene. [S2] Come ti chiami?"

### 3. Altre funzionalità

#### 3.1 Correzione dei caratteri polifonici cinesi pronunciati erroneamente

Utilizziamo [pypinyin](https://github.com/mozillazg/python-pinyin) per convertire i caratteri cinesi in pinyin. Tuttavia, può occasionalmente pronunciare in modo errato i **caratteri polifonici** (多音字).

Per correggere manualmente queste pronunce errate, racchiudere il **pinyin corretto** tra parentesi angolari `< >` e includere il **tono**.

**Esempio:**

- Testo originale: `这把剑长三十公分`
- Correggere il pinyin di `长`:  `这把剑<chang2>三十公分`

> **Nota:** Se si desidera assegnare manualmente più pinyin, racchiudere ciascun pinyin con `<>`, ad esempio, `这把<jian4><chang2><san1>十公分`

## Allena il tuo modello

Consulta la directory [egs](egs) per esempi di addestramento, fine-tuning e valutazione.

## Discussione & Comunicazione

Puoi discutere direttamente su [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Puoi anche scansionare il codice QR per unirti al nostro gruppo wechat o seguire il nostro account ufficiale wechat.

| Gruppo Wechat | Account Ufficiale Wechat |
| ------------- | ------------------------ |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Citazione


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