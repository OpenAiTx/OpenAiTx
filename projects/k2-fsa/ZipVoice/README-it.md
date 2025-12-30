
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

## Sintesi Vocale Testo-a-Voce Rapida e di Alta Qualità Zero-Shot con Flow Matching
</div>

## Panoramica

ZipVoice è una serie di modelli TTS zero-shot rapidi e di alta qualità basati su flow matching.

### 1. Caratteristiche principali

- Piccolo e veloce: solo 123M di parametri.

- Clonazione vocale di alta qualità: prestazioni all'avanguardia in somiglianza vocale, intelligibilità e naturalezza.

- Multilingue: supporta cinese e inglese.

- Multimodale: supporta sia la generazione vocale singola che dialoghi.

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
      <td>Il modello base che supporta TTS zero-shot a singolo parlante sia in cinese che in inglese.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Articolo-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Pagina_Demo-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>La versione distillata di ZipVoice, con velocità migliorata e degrado minimo delle prestazioni.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Un modello di generazione di dialoghi basato su ZipVoice, capace di generare dialoghi parlati a due parti su singolo canale.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Articolo-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Pagina_Demo-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>La variante stereo di ZipVoice-Dialog, che consente la generazione di dialoghi a due canali con ogni speaker assegnato a un canale distinto.</td>
    </tr>
  </tbody>
</table>

## Novità

**14/07/2025**: **ZipVoice-Dialog** e **ZipVoice-Dialog-Stereo**, due modelli di generazione di dialoghi vocali, sono stati rilasciati. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**14/07/2025**: Il dataset **OpenDialog**, un dataset di dialoghi vocali di 6,8k ore, è stato rilasciato. Scarica da [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Consulta i dettagli su [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**16/06/2025**: **ZipVoice** e **ZipVoice-Distill** sono stati rilasciati. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Installazione

### 1. Clona il repository ZipVoice

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


```bash
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
- Se nel testo compaiono `<>` o `[]`, le stringhe racchiuse da questi saranno trattate come token speciali. `<>` indica il pinyin cinese e `[]` indica altri tag speciali.

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
- `prompt_transcription` è la trascrizione del file wav del prompt conversazionale, ad esempio, "[S1] Ciao. [S2] Come stai?"
- `prompt_wav` è il percorso del file wav del prompt.
- `text` è il testo da sintetizzare, ad esempio, "[S1] Sto bene. [S2] Come ti chiami? [S1] Sono Eric. [S2] Ciao Eric."

(2) **Formato prompt separato** dove gli audio e le trascrizioni dei due interlocutori esistono in file separati:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` è il nome del file wav di output.
- `spk1_prompt_transcription` è la trascrizione del prompt wav del primo speaker, ad esempio, "Ciao"
- `spk2_prompt_transcription` è la trascrizione del prompt wav del secondo speaker, ad esempio, "Come stai?"
- `spk1_prompt_wav` è il percorso del file wav del prompt del primo speaker.
- `spk2_prompt_wav` è il percorso del file wav del prompt del secondo speaker.
- `text` è il testo da sintetizzare, ad esempio, "[S1] Sto bene. [S2] Come ti chiami? [S1] Sono Eric. [S2] Ciao Eric."

### 3 Guida per un uso migliore:

#### 3.1 Lunghezza del prompt

Si consiglia un file wav di prompt breve (ad esempio, meno di 3 secondi per la generazione di parlato a singolo speaker, meno di 10 secondi per la generazione di dialoghi) per una velocità di inferenza più rapida. Un prompt molto lungo rallenterà l'inferenza e peggiorerà la qualità del parlato.

#### 3.2 Ottimizzazione della velocità

Se la velocità di inferenza non è soddisfacente, puoi velocizzarla come segue:

- **Distillazione del modello e meno step**: Per il modello di generazione di parlato a singolo speaker, utilizziamo di default il modello `zipvoice` per una migliore qualità del parlato. Se la velocità è prioritaria, puoi passare a `zipvoice_distill` e ridurre `--num-steps` fino a `4` (8 di default).

- **Velocizzazione CPU con multi-threading**: In esecuzione su CPU, puoi passare il parametro `--num-thread` (es., `--num-thread 4`) per aumentare il numero di thread e accelerare la velocità. Usiamo 1 thread di default.

- **Velocizzazione CPU con ONNX**: In esecuzione su CPU, puoi utilizzare modelli ONNX con `zipvoice.bin.infer_zipvoice_onnx` per una velocità maggiore (ONNX non è ancora supportato per i modelli di generazione dialogica). Per una velocità ancora superiore, puoi impostare `--onnx-int8 True` per usare un modello ONNX quantizzato INT8. Nota che il modello quantizzato comporterà un certo degrado della qualità del parlato. **Non usare ONNX su GPU**, poiché è più lento di PyTorch su GPU.

- **Accelerazione GPU con NVIDIA TensorRT**: Per un notevole aumento delle prestazioni su GPU NVIDIA, esporta prima il modello in un engine TensorRT usando zipvoice.bin.tensorrt_export. Poi, esegui l'inferenza sul tuo dataset (ad esempio, un dataset Hugging Face) con zipvoice.bin.infer_zipvoice. Questo può ottenere circa 2x il throughput rispetto all'implementazione standard PyTorch su GPU.

#### 3.3 Controllo della memoria

Il testo fornito verrà suddiviso in blocchi in base alla punteggiatura (per la generazione di parlato a singolo speaker) o al simbolo di cambio speaker (per la generazione di dialoghi). Successivamente, i blocchi di testo verranno processati in batch. Pertanto, il modello può processare testi arbitrariamente lunghi con un uso di memoria quasi costante. Puoi controllare l'uso di memoria regolando il parametro `--max-duration`.

#### 3.4 Valutazione "Raw"

Per impostazione predefinita, pre-processiamo gli input (prompt wav, trascrizione prompt e testo) per un'inferenza efficiente e migliori prestazioni. Se vuoi valutare le prestazioni "raw" del modello usando gli input esatti forniti (ad esempio, per riprodurre i risultati del nostro articolo), puoi passare `--raw-evaluation True`.

#### 3.5 Testo breve

Quando si genera parlato per testi molto brevi (ad esempio, una o due parole), il parlato generato può talvolta omettere alcune pronunce. Per risolvere questo problema, puoi passare `--speed 0.3` (dove 0.3 è un valore regolabile) per estendere la durata del parlato generato.

#### 3.6 Correzione dei caratteri polifonici cinesi pronunciati in modo errato


Usiamo [pypinyin](https://github.com/mozillazg/python-pinyin) per convertire i caratteri cinesi in pinyin. Tuttavia, talvolta può pronunciare erroneamente i **caratteri polifonici** (多音字).

Per correggere manualmente queste pronunce errate, racchiudi il **pinyin corretto** tra parentesi angolari `< >` e includi il **segno tonale**.

**Esempio:**

- Testo originale: `这把剑长三十公分`
- Correggi il pinyin di `长`:  `这把剑<chang2>三十公分`

> **Nota:** Se vuoi assegnare manualmente più pinyin, racchiudi ciascun pinyin con `<>`, ad esempio: `这把<jian4><chang2><san1>十公分`

#### 3.7 Rimuovere lunghe pause dal parlato generato

Il modello determinerà automaticamente le posizioni e le lunghezze delle pause nel parlato generato. Talvolta ci sono lunghe pause nel mezzo del parlato. Se non desideri questo, puoi passare `--remove-long-sil` per rimuovere le lunghe pause nel mezzo del parlato generato (le pause ai bordi verranno rimosse automaticamente).

#### 3.8 Download del modello

Se hai problemi di connessione a HuggingFace durante il download dei modelli pre-addestrati, prova a cambiare endpoint al sito mirror: `export HF_ENDPOINT=https://hf-mirror.com`.

## Addestra il tuo modello

Consulta la directory [egs](egs) per esempi di addestramento, fine-tuning e valutazione.

## Distribuzione in produzione

### Runtime GPU NVIDIA Triton

Per una distribuzione pronta per la produzione con alte prestazioni e scalabilità, consulta l'integrazione con [Triton Inference Server](runtime/nvidia_triton/) che offre motori TensorRT ottimizzati, gestione concorrente delle richieste e API gRPC/HTTP per uso aziendale.

### Distribuzione su CPU

Consulta [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) per la soluzione di distribuzione C++ su CPU.

## Discussione & Comunicazione

Puoi discutere direttamente su [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Puoi anche scansionare il codice QR per unirti al nostro gruppo wechat o seguire il nostro account ufficiale wechat.

| Gruppo Wechat | Account Ufficiale Wechat |
| ------------ | ----------------------- |
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-30

---