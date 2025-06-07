<!---
Copyright 2020 The HuggingFace Team. All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Library" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints on Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentation" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adottato-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>Modelli preaddestrati all’avanguardia per inferenza e addestramento</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers è una libreria di modelli preaddestrati per testo, visione artificiale, audio, video e multimodale per inferenza e addestramento. Usa Transformers per fare fine-tuning sui tuoi dati, costruire applicazioni di inferenza e per casi d’uso di AI generativa su diverse modalità.

Ci sono oltre 500.000+ [checkpoint di modelli Transformers](https://huggingface.co/models?library=transformers&sort=trending) disponibili su [Hugging Face Hub](https://huggingface.com/models).

Esplora subito l’[Hub](https://huggingface.com/) per trovare un modello e utilizzare Transformers per partire subito.

## Installazione

Transformers funziona con Python 3.9+, [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+ e [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

Crea e attiva un ambiente virtuale con [venv](https://docs.python.org/3/library/venv.html) o [uv](https://docs.astral.sh/uv/), un veloce gestore di pacchetti e progetti Python basato su Rust.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Installa Transformers nel tuo ambiente virtuale.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Installa Transformers dal sorgente se vuoi le ultime modifiche nella libreria o se sei interessato a contribuire. Tuttavia, la versione *latest* potrebbe non essere stabile. Sentiti libero di aprire una [issue](https://github.com/huggingface/transformers/issues) se riscontri un errore.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Avvio rapido

Inizia subito con Transformers grazie all’API [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial). `Pipeline` è una classe di alto livello per l’inferenza che supporta attività su testo, audio, visione e multimodale. Si occupa del preprocessing dell’input e restituisce l’output appropriato.

Istanzia una pipeline e specifica il modello da usare per la generazione di testo. Il modello viene scaricato e memorizzato in cache così puoi riutilizzarlo facilmente. Infine, passa del testo per stimolare il modello.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

Per chattare con un modello, il pattern di utilizzo è lo stesso. L’unica differenza è che devi costruire una cronologia della chat (l’input per `Pipeline`) tra te e il sistema.

> [!TIP]
> Puoi anche chattare con un modello direttamente dalla riga di comando.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Sei un robot spiritoso e sarcastico come immaginato da Hollywood nel 1986."},
    {"role": "user", "content": "Ehi, puoi dirmi qualche cosa divertente da fare a New York?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Espandi gli esempi qui sotto per vedere come funziona `Pipeline` per diverse modalità e attività.

<details>
<summary>Riconoscimento automatico del parlato</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Classificazione immagini</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>Visual question answering</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="What is in the image?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## Perché dovrei usare Transformers?

1. Modelli all’avanguardia facili da usare:
    - Alte prestazioni su comprensione e generazione del linguaggio naturale, visione artificiale, audio, video e attività multimodali.
    - Basso livello di accesso per ricercatori, ingegneri e sviluppatori.
    - Poche astrazioni rivolte all’utente con solo tre classi da imparare.
    - API unificata per utilizzare tutti i nostri modelli preaddestrati.

1. Riduci i costi computazionali, minore impatto ambientale:
    - Condividi modelli addestrati invece di addestrare da zero.
    - Riduci il tempo di calcolo e i costi di produzione.
    - Decine di architetture di modelli con oltre 1 milione di checkpoint preaddestrati su tutte le modalità.

1. Scegli il framework giusto per ogni fase del ciclo di vita di un modello:
    - Addestra modelli all’avanguardia in 3 righe di codice.
    - Sposta un singolo modello tra i framework PyTorch/JAX/TF2.0 a piacere.
    - Scegli il framework adatto per addestramento, valutazione e produzione.

1. Personalizza facilmente un modello o un esempio secondo le tue esigenze:
    - Forniamo esempi per ogni architettura per riprodurre i risultati pubblicati dagli autori originali.
    - Gli interni dei modelli sono esposti in modo il più possibile coerente.
    - I file dei modelli possono essere usati indipendentemente dalla libreria per esperimenti rapidi.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Perché non dovrei usare Transformers?

- Questa libreria non è una toolbox modulare di componenti per reti neurali. Il codice nei file dei modelli non è rifattorizzato con ulteriori astrazioni di proposito, così i ricercatori possono iterare rapidamente su ciascun modello senza immergersi in astrazioni/file aggiuntivi.
- L’API di training è ottimizzata per funzionare con i modelli PyTorch forniti da Transformers. Per cicli generici di machine learning, dovresti usare un’altra libreria come [Accelerate](https://huggingface.co/docs/accelerate).
- Gli [script di esempio]((https://github.com/huggingface/transformers/tree/main/examples)) sono solo *esempi*. Potrebbero non funzionare subito per il tuo caso d’uso specifico e dovrai adattare il codice perché funzioni.

## 100 progetti che usano Transformers

Transformers è più di un toolkit per usare modelli preaddestrati, è una comunità di progetti costruiti attorno ad esso e all’Hugging Face Hub. Vogliamo che Transformers consenta a sviluppatori, ricercatori, studenti, professori, ingegneri e chiunque altro di costruire i propri progetti da sogno.

Per celebrare le 100.000 stelle di Transformers, vogliamo mettere in luce la comunità con la pagina [awesome-transformers](./awesome-transformers.md) che elenca 100 progetti incredibili costruiti con Transformers.

Se possiedi o usi un progetto che pensi debba far parte della lista, apri una PR per aggiungerlo!

## Modelli di esempio

Puoi provare la maggior parte dei nostri modelli direttamente sulle loro [pagine modello sul Hub](https://huggingface.co/models).

Espandi ogni modalità qui sotto per vedere alcuni modelli di esempio per vari casi d’uso.

<details>
<summary>Audio</summary>

- Classificazione audio con [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- Riconoscimento automatico del parlato con [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- Riconoscimento di parole chiave con [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- Generazione da voce a voce con [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- Da testo ad audio con [MusicGen](https://huggingface.co/facebook/musicgen-large)
- Da testo a parlato con [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>Visione artificiale</summary>

- Generazione automatica di maschere con [SAM](https://huggingface.co/facebook/sam-vit-base)
- Stima della profondità con [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- Classificazione immagini con [DINO v2](https://huggingface.co/facebook/dinov2-base)
- Rilevamento di keypoint con [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- Associazione di keypoint con [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- Rilevamento oggetti con [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- Stima delle pose con [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- Segmentazione universale con [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- Classificazione video con [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>Multimodale</summary>

- Da audio o testo a testo con [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- Domande su documenti con [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- Da immagine o testo a testo con [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- Captioning immagini con [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- Comprensione di documenti basata su OCR con [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- Domande su tabelle con [TAPAS](https://huggingface.co/google/tapas-base)
- Comprensione e generazione multimodale unificata con [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- Da visione a testo con [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- Visual question answering con [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- Segmentazione di espressioni visive riferite con [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>NLP</summary>

- Completamento di parole mascherate con [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- Riconoscimento di entità nominate con [Gemma](https://huggingface.co/google/gemma-2-2b)
- Question answering con [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- Sintesi con [BART](https://huggingface.co/facebook/bart-large-cnn)
- Traduzione con [T5](https://huggingface.co/google-t5/t5-base)
- Generazione di testo con [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- Classificazione di testo con [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## Citazione

Ora abbiamo un [paper](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) che puoi citare per la libreria 🤗 Transformers:
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---