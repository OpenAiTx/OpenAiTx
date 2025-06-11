<div align="center">

Megatron-LM & Megatron-Core
===========================
<h4>GPU-geoptimaliseerde technieken voor het trainen van transformer-modellen op schaal</h4>

[![Documentatie](https://img.shields.io/badge/docs-latest-brightgreen.svg?style=flat)](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html)
[![versie](https://img.shields.io/badge/release-0.5.0-green)](./setup.py)
[![licentie](https://img.shields.io/badge/license-OpenBSD-blue)](./LICENSE)

<div align="left">

# Laatste Nieuws

- **[2024/7]** Megatron-Core v0.7 verbetert schaalbaarheid en trainingsbestendigheid en voegt ondersteuning toe voor multimodale training ([blog](https://developer.nvidia.com/blog/train-generative-ai-models-more-efficiently-with-new-nvidia-megatron-core-functionalities/)). 
- **[2024/6]** Megatron-Core heeft ondersteuning toegevoegd voor Mamba-gebaseerde modellen. Bekijk ons artikel [An Empirical Study of Mamba-based Language Models](https://arxiv.org/pdf/2406.07887) en [codevoorbeeld](https://github.com/NVIDIA/Megatron-LM/tree/ssm/examples/mamba).
- **[2024/1 Mededeling]** NVIDIA heeft de kernmogelijkheden in **Megatron-LM** vrijgegeven als [**Megatron-Core**](https://github.com/NVIDIA/Megatron-LM/tree/main/megatron/core) in deze repository. Megatron-Core breidt Megatron-LM's GPU-geoptimaliseerde technieken uit met meer innovatieve optimalisaties op systeemniveau, met composable en modulaire API's. Bekijk de [Megatron-Core introductie](#megatron-core) voor meer details.

# Inhoudsopgave

- [Megatron-LM \& Megatron-Core](#megatron-lm--megatron-core)
- [Laatste Nieuws](#laatste-nieuws)
- [Inhoudsopgave](#inhoudsopgave)
- [Megatron Overzicht](#megatron-overview)
  - [Megatron-LM](#megatron-lm)
  - [Megatron-Core](#megatron-core)
- [Trainingssnelheid en Schaalbaarheid](#training-speed-and-scalability)
- [Installatie](#setup)
  - [Docker (Aanbevolen)](#docker-recommended)
  - [Installatieopties](#installation-options)
    - [Installeren via PyPI](#install-from-pypi)
    - [Installeren vanuit broncode](#install-from-source)
  - [Vereisten](#prerequisites)
  - [Checkpoints downloaden](#downloading-checkpoints)
- [Gebruik](#usage)
- [Training](#training)
  - [Datapreprocessing](#data-preprocessing)
  - [BERT Pretraining](#bert-pretraining)
  - [GPT Pretraining](#gpt-pretraining)
  - [T5 Pretraining](#t5-pretraining)
  - [Distributed Pretraining](#distributed-pretraining)
  - [Activation Checkpointing en Recomputation](#activation-checkpointing-and-recomputation)
  - [Distributed Optimizer](#distributed-optimizer)
  - [FlashAttention](#flashattention)
  - [GPT-3 Voorbeeld](#gpt-3-example)
  - [Retro en InstructRetro](#retro-and-instructretro)
  - [Mamba-gebaseerde Language Models](#mamba-based-language-models)
  - [Mixture of Experts](#mixture-of-experts)
- [Evaluatie en Taken](#evaluation-and-tasks)
  - [GPT Tekstgeneratie](#gpt-text-generation)
    - [Detoxify GPT via Zelfgeneratie](#detoxify-gpt-via-self-generation)
  - [GPT Evaluatie](#gpt-evaluation)
    - [WikiText Perplexity Evaluatie](#wikitext-perplexity-evaluation)
    - [LAMBADA Cloze Accuratesse](#lambada-cloze-accuracy)
  - [BERT Taakevaluatie](#bert-task-evaluation)
    - [RACE Evaluatie](#race-evaluation)
    - [MNLI Evaluatie](#mnli-evaluation)
  - [Llama-2 Inference en Finetuning](#llama-2-inference-and-finetuning)
- [Modeloptimalisatie en Implementatie](#model-optimization-and-deployment)
  - [Quantisatie en TensorRT-LLM Implementatie](#quantization-and-tensorrt-llm-deployment)
- [Datasets](#datasets)
  - [Wikipedia Trainingsdata verzamelen](#collecting-wikipedia-training-data)
  - [GPT Webtext Data verzamelen](#collecting-gpt-webtext-data)
- [Reproduceerbaarheid](#reproducibility)
- [Checkpoint conversie](#checkpoint-conversion)
  - [Modelklasse conversie](#model-class-conversion)
  - [Checkpoint formaatconversie](#checkpoint-format-conversion)
- [Projecten met Megatron](#projects-using-megatron)

# Megatron Overzicht
Deze repository bestaat uit twee essentiële componenten: **Megatron-LM** en **Megatron-Core**. Megatron-LM dient als een onderzoeksgericht framework dat Megatron-Core gebruikt voor het trainen van grote taalmodellen (LLM). Megatron-Core daarentegen is een bibliotheek van GPU-geoptimaliseerde trainingstechnieken met formele productsupport, inclusief versiebeheer van API's en regelmatige releases. Je kunt Megatron-Core gebruiken naast Megatron-LM of het [Nvidia NeMo Framework](https://docs.nvidia.com/deeplearning/nemo/user-guide/docs/en/main/nlp/nemo_megatron/mcore_customization.html) voor een end-to-end en cloud-native oplossing. Je kunt ook de bouwstenen van Megatron-Core integreren in je favoriete trainingsframework.

## Megatron-LM
Eerst geïntroduceerd in 2019, heeft Megatron ([1](https://arxiv.org/pdf/1909.08053.pdf), [2](https://arxiv.org/pdf/2104.04473.pdf), en [3](https://arxiv.org/pdf/2205.05198)) een golf van innovatie veroorzaakt in de AI-gemeenschap, waardoor onderzoekers en ontwikkelaars de basis van deze bibliotheek konden gebruiken om LLM-ontwikkelingen te stimuleren. Tegenwoordig zijn veel van de populairste LLM-ontwikkelframeworks geïnspireerd door en direct gebouwd op de open-source Megatron-LM-bibliotheek, wat heeft geleid tot een golf van foundation models en AI-startups. Enkele van de populairste LLM-frameworks gebouwd op Megatron-LM zijn onder andere [Colossal-AI](https://github.com/hpcaitech/ColossalAI), [HuggingFace Accelerate](https://github.com/huggingface/accelerate), en [NVIDIA NeMo Framework](https://www.nvidia.com/en-us/ai-data-science/generative-ai/nemo-framework/). Een lijst met projecten die Megatron direct gebruiken vind je [hier](#projects-using-megatron).

## Megatron-Core
Megatron-Core is een open-source, op PyTorch gebaseerde bibliotheek die GPU-geoptimaliseerde technieken en geavanceerde optimalisaties op systeemniveau bevat. Deze worden geabstraheerd in composable en modulaire API's, waardoor volledige flexibiliteit ontstaat voor ontwikkelaars en modelonderzoekers om op NVIDIA-versnelde infrastructuur aangepaste transformers op schaal te trainen. Deze bibliotheek is compatibel met alle NVIDIA Tensor Core GPU's, inclusief FP8-ondersteuning voor [NVIDIA Hopper-architecturen](https://www.nvidia.com/en-us/data-center/technologies/hopper-architecture/).

Megatron-Core biedt kernbouwstenen zoals attention-mechanismen, transformerblokken en -lagen, normalisatielagen en embedding-technieken. Extra functionaliteit zoals activatie-recomputation en gedistribueerde checkpointing zijn ook standaard ingebouwd. De bouwstenen en functionaliteit zijn allemaal GPU-geoptimaliseerd, en kunnen worden gebruikt met geavanceerde parallelisatiestrategieën voor optimale trainingssnelheid en stabiliteit op NVIDIA Accelerated Computing Infrastructure. Een ander belangrijk onderdeel van de Megatron-Core-bibliotheek omvat geavanceerde modelparallelisme-technieken (tensor, sequentie, pipeline, context en MoE expert parallelisme).

Megatron-Core kan gebruikt worden met [NVIDIA NeMo](https://www.nvidia.com/en-us/ai-data-science/products/nemo/), een enterprise-grade AI-platform. Je kunt Megatron-Core ook verkennen met de native PyTorch trainingsloop [hier](https://github.com/NVIDIA/Megatron-LM/tree/main/examples). Raadpleeg de [Megatron-Core documentatie](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html) voor meer informatie.

# Trainingssnelheid en Schaalbaarheid
Onze codebase is in staat om efficiënt grote taalmodellen te trainen (d.w.z. modellen met honderden miljarden parameters) met zowel model- als dataparallelisme. Om te laten zien hoe onze software schaalt met meerdere GPU's en modelgroottes, beschouwen we GPT-modellen van 2 miljard tot 462 miljard parameters. Alle modellen gebruiken een vocabulairegrootte van 131.072 en een sequentielengte van 4096. We variëren de hidden size, het aantal attention heads en het aantal lagen om tot een specifieke modelgrootte te komen. Naarmate de modelgrootte toeneemt, vergroten we ook bescheiden de batch size. Onze experimenten maken gebruik van maximaal 6144 [H100](https://www.nvidia.com/en-us/data-center/h100/) GPU's. We voeren fijnmazige overlapping uit van data-parallel (`--overlap-grad-reduce --overlap-param-gather`), tensor-parallel (`--tp-comm-overlap`) en pipeline-parallel communicatie (standaard ingeschakeld) met berekeningen om de schaalbaarheid te verbeteren. De gerapporteerde doorvoersnelheden zijn gemeten voor end-to-end training en omvatten alle bewerkingen, inclusief data laden, optimizer-stappen, communicatie en zelfs logging. Merk op dat we deze modellen niet tot convergentie hebben getraind.

![Modeltabel](images/model_table.png)

Onze weak scaling-resultaten tonen superlineaire schaalbaarheid (MFU stijgt van 41% voor het kleinste model naar 47-48% voor de grootste modellen); dit komt doordat grotere GEMMs een hogere rekenintensiteit hebben en daardoor efficiënter kunnen worden uitgevoerd.

![Weak scaling](images/weak_scaling.png)

We hebben ook het standaard GPT-3 model (onze versie heeft iets meer dan 175 miljard parameters door de grotere vocabulairegrootte) geschaald van 96 H100 GPU's naar 4608 GPU's, met gebruik van dezelfde batch size van 1152 sequenties gedurende het geheel. Communicatie wordt op grotere schaal meer uitgesproken, wat leidt tot een verlaging van de MFU van 47% naar 42%.

![Strong scaling](images/strong_scaling.png)

# Installatie

## Docker (Aanbevolen)

We raden sterk aan om de vorige release van de [PyTorch NGC Container](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/pytorch) te gebruiken in plaats van de nieuwste. Onze releases zijn altijd gebaseerd op de NGC-container van de vorige maand, wat compatibiliteit en stabiliteit waarborgt. Deze container bevat alle vereiste afhankelijkheden vooraf geïnstalleerd met compatibele versies en geoptimaliseerde configuraties voor NVIDIA GPU's. 

```bash
# Trek de vorige NGC-container op (vervang 25.04 door de versie van de vorige maand)
docker pull nvcr.io/nvidia/pytorch:25.04-py3
```

```bash
# Start container met gemounte mappen
docker run --gpus all -it --rm \
  -v /pad/naar/megatron:/workspace/megatron \
  -v /pad/naar/dataset:/workspace/dataset \
  -v /pad/naar/checkpoints:/workspace/checkpoints \
  nvcr.io/nvidia/pytorch:25.04-py3
```

## Installatieopties

### Vereisten

- PyTorch (laatste stabiele versie)
- CUDA, cuDNN, NCCL (laatste stabiele versies)
- Ondersteuning voor FP8 op NVIDIA Hopper, Ada, en Blackwell GPU's
- Voor de beste prestaties, gebruik NVIDIA Turing GPU-architecturen of nieuwer

### Installeren via PyPI

Om de laatste stabiele versie te installeren met pip:

```bash
# Installeer de nieuwste release
pip install megatron-core
```

### Installeren vanuit broncode

```bash
# Clone de repository
git clone https://github.com/NVIDIA/Megatron-LM.git
cd Megatron-LM

# Optioneel: checkout een specifieke release
git checkout v0.11.0

# Installeer in development-modus
pip install -e .
```

## Checkpoints downloaden
We hebben voorgetrainde [BERT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_bert_345m) en [GPT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_lm_345m) checkpoints beschikbaar gesteld voor evaluatie of voor finetuning op downstream taken. Om toegang te krijgen tot deze checkpoints, [registreer](https://ngc.nvidia.com/signup) en [configureer](https://ngc.nvidia.com/setup/installers/cli) eerst de NVIDIA GPU Cloud (NGC) Registry CLI. Verdere documentatie voor het downloaden van modellen is te vinden in de [NGC-documentatie](https://docs.nvidia.com/dgx/ngc-registry-cli-user-guide/index.html#topic_6_4_1).

Alternatief kun je de checkpoints direct downloaden via:

<pre>
BERT-345M-uncased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_uncased/zip -O megatron_bert_345m_v0.1_uncased.zip
BERT-345M-cased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_cased/zip -O megatron_bert_345m_v0.1_cased.zip
GPT-345M: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_lm_345m/versions/v0.0/zip -O megatron_lm_345m_v0.0.zip
</pre>

De modellen vereisen vocabulairebestanden om te werken. Het BERT WordPiece-vocab-bestand kan worden geëxtraheerd uit Google's voorgetrainde BERT-modellen: [uncased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-uncased-vocab.txt), [cased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-cased-vocab.txt). Het GPT [vocab-bestand](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-vocab.json) en [merge-tabel](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-merges.txt) zijn direct te downloaden.

# Gebruik

Na installatie zijn er verschillende mogelijke workflows. De meest uitgebreide is:
1. Datapreprocessing
2. Pretraining
3. Finetuning (Optioneel voor zero-shot taken)
4. Downstream taakevaluatie of tekstgeneratie

Stap 1 en 2 kunnen echter worden vervangen door het gebruik van een van de bovengenoemde voorgetrainde modellen.

We hebben verschillende scripts meegeleverd voor pretraining van zowel BERT als GPT in de [`examples`](./examples) map, evenals scripts voor zowel zero-shot als gefinetunede downstream-taken zoals MNLI, RACE, WikiText103 en LAMBADA-evaluatie. Er is ook een script voor interactieve GPT-tekstgeneratie.

# Training
## Datapreprocessing
De trainingsdata vereist preprocessing. Plaats eerst je trainingsdata in een los json-formaat, waarbij één json per regel een tekstvoorbeeld bevat. Bijvoorbeeld:
<pre>
{"src": "www.nvidia.com", "text": "The quick brown fox", "type": "Eng", "id": "0", "title": "First Part"}
{"src": "The Internet", "text": "jumps over the lazy dog", "type": "Eng", "id": "42", "title": "Second Part"}
</pre>

De naam van het `text`-veld in de json kan worden gewijzigd met de `--json-key`-vlag in [`preprocess_data.py`](./tools/preprocess_data.py). De andere metadata zijn optioneel en worden niet gebruikt tijdens training.

De losse json wordt vervolgens verwerkt tot een binair formaat voor training. Om de json naar mmap-formaat te converteren, gebruik je `preprocess_data.py`. Een voorbeeldscript om data voor BERT-training voor te bereiden is:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-bert \
       --vocab-file bert-vocab.txt \
       --tokenizer-type BertWordPieceLowerCase \
       --split-sentences
</pre>

De output zal bestaan uit twee bestanden, in dit geval `my-bert_text_sentence.bin` en `my-bert_text_sentence.idx`. De `--data-path` die later wordt opgegeven bij BERT-training is het volledige pad en de nieuwe bestandsnaam, maar zonder bestandsextensie.

Voor T5 gebruik je dezelfde preprocessing als voor BERT, eventueel met een andere naam:
<pre>
       --output-prefix my-t5 \
</pre>
Enkele kleine aanpassingen zijn vereist voor GPT data preprocessing, namelijk de toevoeging van een merge-tabel, een end-of-document-token, het verwijderen van zinsplitsing en een wijziging van het tokenizer-type:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-gpt2 \
       --vocab-file gpt2-vocab.json \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file gpt2-merges.txt \
       --append-eod
</pre>

Hier worden de uitvoerbestanden genoemd `my-gpt2_text_document.bin` en `my-gpt2_text_document.idx`. Net als voorheen, gebruik bij GPT-training de langere naam zonder extensie als `--data-path`.

Verdere commandoregelargumenten worden beschreven in het bronbestand [`preprocess_data.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/preprocess_data.py).

## BERT Pretraining

Het script [`examples/bert/train_bert_340m_distributed.sh`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/bert/train_bert_340m_distributed.sh) voert single-GPU pretraining uit van een BERT-model met 345M parameters. Single GPU-training is vooral bedoeld voor debugging, omdat de codebasis en commandoregelargumenten geoptimaliseerd zijn voor sterk gedistribueerde training. De meeste argumenten spreken redelijk voor zich. Standaard neemt de learning rate lineair af over de trainingsiteraties, beginnend bij `--lr` tot een minimum ingesteld door `--min-lr` over `--lr-decay-iters` iteraties. Het fractie van de trainingsiteraties dat gebruikt wordt voor warmup wordt ingesteld met `--lr-warmup-fraction`. Hoewel dit single GPU-training is, is de batch size gespecificeerd door `--micro-batch-size` een enkele forward-backward batch-grootte; de code voert gradient accumulation stappen uit tot `global-batch-size` is bereikt, wat de batch size per iteratie is. De data wordt opgedeeld in een verhouding van 949:50:1 voor training/validatie/test sets (standaard is 969:30:1). Deze partitionering gebeurt on-the-fly, maar is consistent over runs met dezelfde random seed (standaard 1234, of handmatig opgegeven met `--seed`). We gebruiken `train-iters` als het aantal trainingsiteraties. Alternatief kan `--train-samples` opgegeven worden, wat het totale aantal samples is waarop getraind wordt. Als deze optie aanwezig is, moet in plaats van `--lr-decay-iters` de optie `--lr-decay-samples` opgegeven worden.

De logging-, checkpoint-save- en evaluatie-intervalopties zijn gespecificeerd. Let op dat `--data-path` nu de extra `_text_sentence` suffix bevat die is toegevoegd in preprocessing, maar geen bestandsextensies bevat.

Verdere commandoregelargumenten worden beschreven in het bronbestand [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py).

Om `train_bert_340m_distributed.sh` uit te voeren, voer je gewenste aanpassingen uit, waaronder het instellen van de omgevingsvariabelen voor `CHECKPOINT_PATH`, `VOCAB_FILE` en `DATA_PATH`. Zorg ervoor dat deze variabelen naar de juiste paden in de container verwijzen. Start vervolgens de container met Megatron en de benodigde paden als mounts (zoals uitgelegd in [Setup](#setup)) en voer het voorbeeldscript uit.

## GPT Pretraining

Het script `examples/gpt3/train_gpt3_175b_distributed.sh` voert single-GPU pretraining uit van een GPT-model met 345M parameters. Zoals hierboven vermeld, is single GPU-training vooral bedoeld voor debugging, omdat de code geoptimaliseerd is voor gedistribueerde training.

Het volgt grotendeels hetzelfde format als het vorige BERT-script, met enkele belangrijke verschillen: het gebruikte tokenisatieschema is BPE (wat een merge-tabel en een `json` vocabulairebestand vereist) in plaats van WordPiece, de modelarchitectuur staat langere sequenties toe (let erop dat de max position embedding groter dan of gelijk aan de maximale sequentielengte moet zijn) en `--lr-decay-style` is ingesteld op cosine decay. Let op dat `--data-path` nu de extra `_text_document` suffix bevat die is toegevoegd in preprocessing, maar geen bestandsextensies bevat.

Verdere commandoregelargumenten worden beschreven in het bronbestand [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py).

`train_gpt3_175b_distributed.sh` kan op dezelfde manier gestart worden als bij BERT. Stel de omgevingsvariabelen in, voer eventuele andere aanpassingen uit, start de container met de juiste mounts en voer het script uit.
Meer details in [`examples/gpt3/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/gpt3/README.md)

## T5 Pretraining

Zeer vergelijkbaar met BERT en GPT voert het script `examples/t5/train_t5_220m_distributed.sh` single-GPU pretraining uit van het "base" (~220M parameters) T5-model. Het belangrijkste verschil met BERT en GPT is de toevoeging van de volgende argumenten om de T5-architectuur te ondersteunen:

* `--kv-channels` stelt de interne dimensie in van de "key" en "value" matrices van alle attention-mechanismen in het model. Voor BERT en GPT is dit standaard de hidden size gedeeld door het aantal attention heads, maar dit kan aangepast worden voor T5.

* `--ffn-hidden-size` stelt de hidden size in binnen de feed-forward-netwerken van een transformerlaag. Voor BERT en GPT is dit standaard 4 keer de transformer hidden size, maar dit kan aangepast worden voor T5.

* `--encoder-seq-length` en `--decoder-seq-length` stellen de sequentielengte voor encoder en decoder afzonderlijk in.

Alle andere argumenten blijven hetzelfde als bij BERT en GPT pretraining. Voer dit voorbeeld uit volgens dezelfde stappen als hierboven beschreven voor de andere scripts.

Meer details in [`examples/t5/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/t5/README.md)

## Gedistribueerde Pretraining

De scripts `pretrain_{bert,gpt,t5}_distributed.sh` gebruiken de PyTorch distributed launcher voor gedistribueerde training. Zo kan multi-node training worden bereikt door de juiste omgevingsvariabelen in te stellen. Zie de officiële PyTorch [documentatie](https://pytorch.org/docs/stable/elastic/run.html#launcher-api) voor verdere beschrijving van deze [omgevingsvariabelen](https://pytorch.org/docs/stable/distributed.html#environment-variable-initialization). Standaard gebruikt multi-node training de [nccl](https://developer.nvidia.com/nccl) distributed backend. Een eenvoudige set extra argumenten en het gebruik van de PyTorch distributed module met de `torchrun` elastic launcher (equivalent aan `python -m torch.distributed.run`) zijn de enige extra vereisten om gedistribueerde training toe te passen. Zie een van de `pretrain_{bert,gpt,t5}_distributed.sh` scripts voor meer details.

We gebruiken twee typen parallellisme: data- en modelparallellisme. Onze data-parallelle implementatie staat in `megatron/core/distributed`, en ondersteunt overlapping van gradient-reductie met de backward pass als de optie `--overlap-grad-reduce` wordt gebruikt.

Ten tweede hebben we een eenvoudige en efficiënte tweedimensionale model-parallelle aanpak ontwikkeld. Om de eerste dimensie te gebruiken, tensor model parallelism (het splitsen van de uitvoering van een enkele transformermodule over meerdere GPU's, zie Sectie 3 van [ons paper](https://arxiv.org/pdf/1909.08053.pdf)), voeg je de vlag `--tensor-model-parallel-size` toe om het aantal GPU's aan te geven waarover het model wordt gesplitst, samen met de argumenten die aan de distributed launcher worden meegegeven zoals hierboven vermeld. Voor de tweede dimensie, sequence parallelism, specificeer je `--sequence-parallel`, wat ook vereist dat tensor model parallelism is ingeschakeld, omdat het over dezelfde GPU's splitst (meer details in Sectie 4.2.2 van [ons paper](https://arxiv.org/pdf/2205.05198.pdf)).

Om pipeline model parallelism te gebruiken (het opsplitsen van de transformermodules in stages met een gelijk aantal transformermodules per stage, en vervolgens pipelining door de batch op te splitsen in kleinere microbatches, zie Sectie 2.2 van [ons paper](https://arxiv.org/pdf/2104.04473.pdf)), gebruik je de vlag `--pipeline-model-parallel-size` om het aantal stages aan te geven waarin het model wordt gesplitst (bijvoorbeeld: een model met 24 transformerlagen over 4 stages betekent dat elke stage 6 transformerlagen krijgt).

We hebben voorbeelden van hoe deze twee verschillende vormen van modelparallellisme gebruikt kunnen worden in de voorbeeldscripts die eindigen op `distributed_with_mp.sh`.

Afgezien van deze kleine aanpassingen is de gedistribueerde training identiek aan training op een enkele GPU.

Het interleaved pipelining schema (meer details in Sectie 2.2.2 van [ons paper](https://arxiv.org/pdf/2104.04473.pdf)) kan worden ingeschakeld met het argument `--num-layers-per-virtual-pipeline-stage`, waarmee je het aantal transformerlagen in een virtuele stage regelt (standaard, met het niet-interleaved schema, voert elke GPU één virtuele stage uit met `NUM_LAYERS / PIPELINE_MP_SIZE` transformerlagen). Het totale aantal lagen in het transformermodel moet deelbaar zijn door deze argumentwaarde. Daarnaast moet het aantal microbatches in de pipeline (berekend als `GLOBAL_BATCH_SIZE / (DATA_PARALLEL_SIZE * MICRO_BATCH_SIZE)`) deelbaar zijn door `PIPELINE_MP_SIZE` bij gebruik van dit schema (deze voorwaarde wordt gecontroleerd met een assert in de code). Het interleaved schema wordt niet ondersteund voor pipelines met 2 stages (`PIPELINE_MP_SIZE=2`).

## Activation Checkpointing en Recomputation

Om het GPU-geheugengebruik te verminderen bij het trainen van een groot model, ondersteunen we verschillende vormen van activatiecheckpointing en recomputation. In plaats van dat alle activaties in het geheugen worden opgeslagen voor gebruik tijdens backprop, zoals traditioneel het geval was bij deep learning-modellen, worden alleen activaties op bepaalde "checkpoints" in het model in het geheugen bewaard (of opgeslagen), en de andere activaties worden on-the-fly opnieuw berekend wanneer ze nodig zijn voor backprop. Let op: dit type checkpointing, *activatie* checkpointing, is heel anders dan het checkpointen van modelparameters en optimizer state, dat elders wordt besproken.

We ondersteunen twee niveaus van recompute-granulariteit: `selective` en `full`. Selectieve recomputation is de standaard en wordt in bijna alle gevallen aanbevolen. In deze modus blijven de activaties die minder geheugenruimte innemen en duurder zijn om opnieuw te berekenen in het geheugen, en worden de activaties die meer geheugenruimte innemen maar relatief goedkoop zijn om opnieuw te berekenen, opnieuw berekend. Zie [ons paper](https://arxiv.org/pdf/2205.05198) voor details. Je zult merken dat deze modus de prestaties maximaliseert en het benodigde geheugen voor activaties minimaliseert. Om selectieve activatierecompute in te schakelen, gebruik simpelweg `--recompute-activations`.

In gevallen waar het geheugen zeer beperkt is, bespaart `full` recompute alleen de inputs van een transformerlaag, of een groep, of block, van transformerlagen, en rekent de rest opnieuw uit. Om full activatierecompute in te schakelen, gebruik `--recompute-granularity full`. Bij het gebruik van `full` activatierecompute zijn er twee methoden: `uniform` en `block`, gekozen met het argument `--recompute-method`.

* De `uniform` methode verdeelt de transformerlagen uniform in groepen lagen (elke groep met grootte `--recompute-num-layers`) en slaat de inputactivaties van elke groep in het geheugen op. De baseline groepsgrootte is 1 en in dat geval wordt de inputactivatie van elke transformerlaag opgeslagen. Wanneer het GPU-geheugen onvoldoende is, verkleint het verhogen van het aantal lagen per groep het geheugengebruik, waardoor een groter model kan worden getraind. Bijvoorbeeld, als `--recompute-num-layers` is ingesteld op 4, wordt alleen de inputactivatie van elke groep van 4 transformerlagen opgeslagen.

* De `block` methode rekent de inputactivaties opnieuw uit van een specifiek aantal (gegeven door `--recompute-num-layers`) individuele transformerlagen per pipelinestage en slaat de inputactivaties van de overige lagen in de pipelinestage op. Het verlagen van `--recompute-num-layers` resulteert in het opslaan van de inputactivaties van meer transformerlagen, wat de benodigde activatierecompute tijdens backprop vermindert en zo de trainingsprestaties verbetert, terwijl het geheugengebruik toeneemt. Bijvoorbeeld, als we 5 lagen specificeren om te recomputen van 8 lagen per pipelinestage, worden de inputactivaties van alleen de eerste 5 transformerlagen opnieuw berekend in de backprop-stap, terwijl de inputactivaties van de laatste 3 lagen worden opgeslagen. `--recompute-num-layers` kan geleidelijk worden verhoogd totdat het benodigde geheugen klein genoeg is om in het beschikbare geheugen te passen, zodat zowel het geheugen maximaal benut wordt als de prestaties gemaximaliseerd worden.

## Gedistribueerde Optimizer

Gebruik: `--use-distributed-optimizer`. Compatibel met alle model- en datatypes.

De gedistribueerde optimizer is een geheugensparende techniek, waarbij de optimizer state gelijkmatig verdeeld wordt over data parallel ranks (versus de traditionele methode waarbij de optimizer state over alle data parallel ranks wordt gerepliceerd). Zoals beschreven in [ZeRO: Memory Optimizations Toward Training Trillion Parameter Models](https://arxiv.org/abs/1910.02054), distribueert onze implementatie alle optimizer state die niet overlapt met de model state. Bijvoorbeeld, bij gebruik van fp16 modelparameters onderhoudt de distributed optimizer zijn eigen aparte kopie van fp32 hoofdparameters & grads, die verdeeld zijn over DP ranks. Bij gebruik van bf16 modelparameters zijn de fp32 hoofdgrads van de distributed optimizer echter hetzelfde als de fp32 grads van het model, en worden de grads in dit geval dus niet verdeeld (hoewel de fp32 hoofdparameters nog steeds verdeeld zijn, omdat ze los staan van de bf16 modelparameters).

De theoretische geheugensbesparing varieert afhankelijk van de combinatie van het param dtype en grad dtype van het model. In onze implementatie is het theoretisch aantal bytes per parameter (waarbij 'd' de data parallel grootte is):

| | Niet-gedistribueerde optim | Gedistribueerde optim |
|-|-|-|
| fp16 param, fp16 grads | 20 | 4 + 16/d |
| bf16 param, fp32 grads | 18 | 6 + 12/d |
| fp32 param, fp32 grads | 16 | 8 + 8/d |

Net als bij gewone data parallelisme kan overlapping van gradient reductie (in dit geval een reduce-scatter) met de backward pass gefaciliteerd worden met de `--overlap-grad-reduce` vlag. Daarnaast kan overlapping van de parameter all-gather met de forward pass plaatsvinden met `--overlap-param-gather`.

## FlashAttention

Gebruik: `--use-flash-attn`. Ondersteunt attention head dimensies tot maximaal 128.

[FlashAttention](https://github.com/HazyResearch/flash-attention) is een snelle en
geheugenefficiënte algoritme om exacte attention te berekenen. Het versnelt modeltraining en vermindert het geheugengebruik.

Om FlashAttention te installeren:
```sh
pip install flash-attn
```

## GPT-3 Voorbeeld

In `examples/gpt3/train_gpt3_175b_distributed.sh` hebben we een voorbeeld gegeven van hoe je Megatron configureert om [GPT-3](https://arxiv.org/abs/2005.14165) met 175 miljard parameters te trainen op 1024 GPU's. Het script is ontworpen voor [slurm](https://slurm.schedmd.com/documentation.html) met [pyxis](https://github.com/NVIDIA/pyxis) plugin, maar kan eenvoudig worden aangepast voor andere schedulers. Het gebruikt 8-weg tensor parallellisme en 16-weg pipeline parallellisme. Met de opties `global-batch-size 1536` en `rampup-batch-size 16 16 5859375` zal de training starten met een globale batchgrootte van 16 en deze lineair verhogen tot 1536 over 5.859.375 samples met stappen van 16. De trainingsdataset kan een enkele set zijn of meerdere datasets gecombineerd met een set gewichten.

Met een volledige globale batchgrootte van 1536 op 1024 A100 GPU's duurt elke iteratie ongeveer 32 seconden, wat resulteert in 138 teraFLOPs per GPU (44% van de theoretische piek-FLOPs).

## Retro en InstructRetro

Retro [(Borgeaud et al., 2022)](https://arxiv.org/abs/2112.04426) is een autoregressief, alleen-decoder language model (LM) dat is voorgetraind met retrieval-augmentatie.
Retro kenmerkt zich door praktische schaalbaarheid om grootschalige pretraining vanaf nul te ondersteunen door te retrieven uit biljoenen tokens.
Pretraining met retrieval biedt een efficiëntere opslag van feitelijke kennis, vergeleken met het impliciet opslaan van feitelijke kennis in de netwerkparameters, waardoor het aantal modelparameters aanzienlijk wordt verminderd en toch een lagere perplexity wordt bereikt dan standaard GPT.
Retro biedt ook de flexibiliteit om de
kennis die is opgeslagen in LMs [(Wang et al., 2023a)](https://arxiv.org/abs/2304.06762)
bij te werken door de retrieval database te updaten zonder de LMs opnieuw te trainen.

InstructRetro [(Wang et al., 2023b)](https://arxiv.org/abs/2310.07713) schaalt de grootte van Retro verder op tot 48B, en is daarmee het grootste LLM dat (vanaf december 2023) met retrieval is voorgetraind.
Het verkregen foundation model, Retro 48B, presteert aanzienlijk beter dan de GPT-tegenhanger qua perplexity.
Met instruction tuning op Retro toont InstructRetro een significante verbetering ten opzichte van de instruction tuned GPT bij downstream taken in de zero-shot setting. Specifiek is de gemiddelde verbetering van InstructRetro 7% ten opzichte van GPT bij 8 short-form QA-taken en 10% bij 4 uitdagende long-form QA-taken. Ook blijkt dat men de encoder uit de InstructRetro-architectuur kan verwijderen en direct de InstructRetro decoder-backbone als GPT kan gebruiken, met vergelijkbare resultaten.

In deze repo bieden we een end-to-end reproductiegids voor het implementeren van Retro en InstructRetro, inclusief
- **Retrieval database constructie**, die biljoenen tokens ondersteunt als grootschalige retrieval database.
- **Pretraining met retrieval**, wat zowel pretraining vanaf nul als pretraining vanaf een voorgetraind GPT-model (Retro-fitting) ondersteunt.
- **Instruction tuning**, waarbij we een open-source instruction tuning dataset en het trainingsrecept voor instruction tuning op Retro leveren.
- **Downstream taak evaluatie**, waarbij we tekstgeneratie- en evaluatiescripts leveren voor zero-shot question answering taken.

Zie [tools/retro/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/retro/README.md) voor een gedetailleerd overzicht.

## Mamba-gebaseerde Language Models

Zie [examples/mamba](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/mamba) voor details.

<!--
## REALM Pipeline
We werken aan de implementatie van het [REALM](https://arxiv.org/pdf/2002.08909.pdf) systeem. De volgende secties (zullen) de drie fasen van de training ervan beschrijven. Voor nu is alleen de ICT-code beschikbaar.
Globaal zijn dit: eerst de retrievermodules pretrainen, daarna het language model en de retriever gezamenlijk trainen, en tot slot een question answering head finetunen op het language model met vaste retriever.

### Inverse Cloze Task (ICT) Pretraining
1. Zorg voor een corpus in los JSON-formaat met als doel een verzameling van fixed-size tekstblokken te maken als fundamentele data-eenheden. Voor een corpus als Wikipedia betekent dit meerdere zinnen per blok, maar ook meerdere blokken per document.
Voer `tools/preprocess_data.py` uit om één of meerdere geïndexeerde datasets te construeren met het argument `--split-sentences` zodat zinnen de basiseenheid vormen. Voor het originele REALM-systeem maken we twee datasets: één met de titel van elk document en een andere met de body.
Zie het volgende script
<pre>
python preprocess_data.py \
    --input /path/to/corpus.json \
    --json-keys text title \
    --split-sentences \
    --tokenizer-type BertWordPieceLowerCase \
    --vocab-file /path/to/vocab.txt \
    --output-prefix corpus_indexed \
    --workers 5  # werkt goed voor 10 CPU-cores. Schaal omhoog indien nodig.
</pre>

2. Gebruik een aangepaste samples mapping functie in plaats van `megatron/legacy/data/realm_dataset_utils.get_block_samples_mapping` indien vereist. Hiervoor moet je een nieuwe functie implementeren in C++ binnen `megatron/core/datasets/helpers.cpp`. De samples mapping datastructuur wordt gebruikt om de data te selecteren die elke trainingssample zal vormen, voorafgaand aan de training loop.
 De samples mapping bevat alle vereiste metadata om de sample samen te stellen uit één of meerdere geïndexeerde datasets. In REALM bevat de mapping de start- en eindzin-indexen, evenals de documentindex (om de juiste titel bij een body te vinden) en een unieke ID voor elk blok.
3. Pretrain een BERT-language model met `pretrain_bert.py`, met de sequentielengte gelijk aan de blokgrootte in token ids. Dit model moet getraind worden op dezelfde geïndexeerde dataset die gebruikt wordt voor het leveren van de blokken voor de information retrieval taak.
In REALM is dit een uncased bert base model getraind met de standaard hyperparameters.
4. Gebruik `pretrain_ict.py` om een `ICTBertModel` te trainen die twee BERT-gebaseerde encoders gebruikt om queries en blokken te encoderen voor retrieval.
Onderstaand script traint het ICT-model uit REALM. Het verwijst naar een voorgetraind BERT-model (stap 3) in het argument `--bert-load`. De batch size die in het paper wordt gebruikt is 4096, dus dit moet gedraaid worden met data parallel world size 32.
<pre>
python pretrain_ict.py \
    --num-layers 12 \
    --num-attention-heads 12 \
    --hidden-size 768 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-head-size 128 \
    --train-iters 100000 \
    --bert-load /path/to/pretrained_bert \
    --load checkpoints \
    --save checkpoints \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --vocab-file /path/to/vocab.txt \
    --lr 0.0001 \
    --num-workers 2 \
    --lr-decay-style linear \
    --weight-decay 1e-2 \
    --clip-grad 1.0 \
    --lr-warmup-fraction .01 \
    --save-interval 3000 \
    --query-in-block-prob 0.1 \
    --fp16

</pre>

### Bouwen van een Index van Block Embeddings
Na het trainen van een ICT-model kun je nu een volledige dataset van blokken embedden door een `BlockData` structuur te maken. Nadat deze is opgeslagen, kun je hem laden
en omwikkelen met een `FaissMIPSIndex` om snelle similarity search uit te voeren, wat cruciaal is in de learned information retrieval pipeline. De initiële index kan worden gebouwd met het volgende script, bedoeld om in een interactieve sessie te draaien. Het kan meerdere GPU's op meerdere nodes benutten om grote datasets veel sneller te indexeren.

<pre>
python tools/create_doc_index.py \
    --num-layers 12 \
    --hidden-size 768 \
    --ict-head-size 128 \
    --num-attention-heads 12 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-load /pad/naar/voorgeleerde_ict \
    --data-path /pad/naar/geindexeerde_dataset \
    --titles-data-path /pad/naar/titels_geindexeerde_dataset \
    --block-data-path embedded_blocks.pkl \
    --indexer-log-interval 1000 \
    --indexer-batch-size 128 \
    --vocab-file /pad/naar/vocab.txt \
    --num-workers 2 \
    --fp16
</pre>

-->

## Mixture of Experts
MoE (Mixture of Experts) is een krachtige LLM-architectuur geïmplementeerd in het Megatron-Core framework, ontworpen om de efficiëntie en schaalbaarheid van grote taalmodellen te verbeteren. Het maakt gebruik van **Expert Parallelism**, waardoor meerdere experts verdeeld kunnen worden over verschillende workers, waarbij elke worker verschillende batches trainingsvoorbeelden verwerkt. Deze methode verhoogt de computationele doorvoer aanzienlijk, waardoor modellen hoge prestatiecijfers kunnen behalen, zoals 47% MFU tijdens BF16-training voor 8x7B op H100.

Belangrijkste kenmerken van MoE:
- **Parallelisme Technieken**: MoE combineert verschillende parallelisme strategieën, waaronder Expert Parallelism, Data Parallelism, Tensor Parallelism, Sequence Parallelism, Pipeline Parallelism, en Context Parallelism. Deze combinatie maakt het mogelijk grotere modelvarianten effectief te verwerken.
- **Router en Load Balancing**: Het systeem maakt gebruik van geavanceerde routeringsmechanismen zoals de Top-K router en gebruikt load balancing algoritmes om de distributie van tokens over experts te optimaliseren.
- **Prestatie-optimalisaties**: Technieken zoals GroupedGEMM en FP8-training verhogen de efficiëntie van MoE-modellen, vooral wanneer meerdere experts worden ingezet.
- **Token Dispatch Mechanisme**: MoE ondersteunt zowel dropless als token drop strategieën om de distributie van tokens effectief over experts te beheren.

Voor een uitgebreid overzicht van MoE-trainingsconfiguraties en optimalisaties, zie de gedetailleerde README op [megatron/core/transformer/moe/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/core/transformer/moe/README.md).

# Evaluatie en Taken

We bieden verschillende commandoregelargumenten, gedetailleerd in de onderstaande scripts, om diverse zero-shot en fijngetunede downstream-taken te verwerken. Je kunt echter je model ook verder trainen vanaf een voorgetraind checkpoint op andere corpora naar wens. Voeg hiervoor simpelweg de `--finetune` vlag toe en pas de invoerbestanden en trainingsparameters aan binnen het originele trainingsscript. Het aantal iteraties wordt dan teruggezet naar nul en de optimizer en interne status worden opnieuw geïnitialiseerd. Als de fine-tuning om wat voor reden dan ook wordt onderbroken, zorg er dan voor dat je de `--finetune` vlag verwijdert voordat je verdergaat, anders start de training opnieuw vanaf het begin.

Omdat evaluatie aanzienlijk minder geheugen vereist dan training, kan het voordelig zijn om een in parallel getraind model samen te voegen voor gebruik op minder GPU's bij downstream-taken. Het volgende script doet dit. In dit voorbeeld wordt een GPT-model met 4-weg tensor en 4-weg pipeline modelparallelisme ingelezen en wordt een model met 2-weg tensor en 2-weg pipeline modelparallelisme weggeschreven.

<pre>
python tools/checkpoint/convert.py \
        --model-type GPT \
        --load-dir checkpoints/gpt3_tp4_pp4 \
        --save-dir checkpoints/gpt3_tp2_pp2 \
        --target-tensor-parallel-size 2 \
        --target-pipeline-parallel-size 2

</pre>

Verschillende downstream-taken worden hieronder beschreven voor zowel GPT- als BERT-modellen. Ze kunnen worden uitgevoerd in gedistribueerde en model-parallelle modi met dezelfde aanpassingen als gebruikt in de trainingsscripts.

## GPT Tekstgeneratie

We hebben een eenvoudige REST-server opgenomen voor tekstgeneratie in `tools/run_text_generation_server.py`. Je start deze op vergelijkbare wijze als een pretrainingsjob, met een geschikt voorgetraind checkpoint. Er zijn ook enkele optionele parameters: `temperature`, `top-k` en `top-p`. Zie `--help` of het bronbestand voor meer informatie. Zie [examples/inference/run_text_generation_server_345M.sh](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/inference/run_text_generation_server_345M.sh) voor een voorbeeld van het opstarten van de server.

Wanneer de server draait, kun je `tools/text_generation_cli.py` gebruiken om deze te bevragen; deze neemt één argument, namelijk de host waarop de server draait.

<pre>
tools/text_generation_cli.py localhost:5000
</pre>

Je kunt ook CURL of andere tools gebruiken om de server direct te bevragen:

<pre>
curl 'http://localhost:5000/api' -X 'PUT' -H 'Content-Type: application/json; charset=UTF-8'  -d '{"prompts":["Hello world"], "tokens_to_generate":1}'
</pre>

Zie [megatron/inference/text_generation_server.py](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/inference/text_generation_server.py) voor meer API-opties.

### Detoxify GPT via Zelf-generatie
We bevatten een voorbeeld in `examples/academic_paper_scripts/detxoify_lm/` om taalmodellen te detoxificeren door gebruik te maken van de generatieve kracht van taalmodellen.

Zie [examples/academic_paper_scripts/detxoify_lm/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/academic_paper_scripts/detxoify_lm/README.md) voor stapsgewijze tutorials over domeinadaptieve training en het detoxificeren van LM met een zelfgegenereerde corpus.


## GPT Evaluatie
We bevatten voorbeeldscripts voor GPT-evaluatie op WikiText perplexity-evaluatie en LAMBADA Cloze nauwkeurigheid.

### WikiText Perplexity Evaluatie
Voor een eerlijke vergelijking met eerdere werken, evalueren we perplexity op het woordniveau [WikiText-103 testdataset](https://s3.amazonaws.com/research.metamind.io/wikitext/wikitext-103-v1.zip), en berekenen we de perplexity op de juiste wijze gezien de verandering in tokens bij gebruik van onze subword-tokenizer.

We gebruiken het volgende commando om WikiText-103 evaluatie uit te voeren op een 345M parameter model.
<pre>
TASK="WIKITEXT103"

VALID_DATA=&#60;wikitext pad&#62;.txt
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m

COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 1024 \
                  --max-position-embeddings 1024 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>


### LAMBADA Cloze Nauwkeurigheid
Om de LAMBADA cloze-nauwkeurigheid te berekenen (de nauwkeurigheid van het voorspellen van het laatste token gegeven de voorgaande tokens), gebruiken we een gedetokeniseerde, verwerkte versie van de [LAMBADA dataset](https://github.com/cybertronai/bflm/blob/master/lambada_test.jsonl).

We gebruiken het volgende commando om LAMBADA-evaluatie uit te voeren op een 345M parameter model. Let op dat de `--strict-lambada` vlag moet worden gebruikt om te eisen dat het hele woord overeenkomt. Zorg ervoor dat `lambada` deel uitmaakt van het bestandspad.

<pre>
TASK="LAMBADA"

VALID_DATA=&#60;lambada pad&#62;.json
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m
COMMON_TASK_ARGS=&#60;dezelfde als bij <a href="#wikitext-perplexity-evaluation">WikiText Perplexity Evaluatie</a> hierboven&#62;

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --strict-lambada \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>

Verdere commandoregelargumenten worden beschreven in het bronbestand [`main.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tasks/main.py)

## BERT Taakevaluatie
### RACE Evaluatie
Het volgende script finetunet het BERT-model voor evaluatie op de [RACE dataset](http://www.cs.cmu.edu/~glai1/data/race/). De `TRAIN_DATA` en `VALID_DATA` directory bevatten de RACE dataset als afzonderlijke `.txt`-bestanden. Let op dat voor RACE de batchgrootte het aantal RACE-vragen is om te evalueren. Omdat elke RACE-vraag vier voorbeelden heeft, zal de effectieve batchgrootte die door het model gaat vier keer de batchgrootte zijn die op de commandoregel is opgegeven.

<pre>
TRAIN_DATA="data/RACE/train/middle"
VALID_DATA="data/RACE/dev/middle \
            data/RACE/dev/high"
VOCAB_FILE=bert-vocab.txt
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
CHECKPOINT_PATH=checkpoints/bert_345m_race
COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 512 \
                  --max-position-embeddings 512 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

COMMON_TASK_ARGS_EXT="--train-data $TRAIN_DATA \
                      --valid-data $VALID_DATA \
                      --pretrained-checkpoint $PRETRAINED_CHECKPOINT \
                      --save-interval 10000 \
                      --save $CHECKPOINT_PATH \
                      --log-interval 100 \
                      --eval-interval 1000 \
                      --eval-iters 10 \
                      --weight-decay 1.0e-1"

python tasks/main.py \
       --task RACE \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
       --tokenizer-type BertWordPieceLowerCase \
       --epochs 3 \
       --micro-batch-size 4 \
       --lr 1.0e-5 \
       --lr-warmup-fraction 0.06
</pre>

### MNLI Evaluatie
Het volgende script finetunet het BERT-model voor evaluatie met het [MultiNLI sentence pair corpus](https://www.nyu.edu/projects/bowman/multinli/). Omdat de matching-taken erg op elkaar lijken, kan het script eenvoudig worden aangepast voor gebruik met de [Quora Question Pairs](https://www.kaggle.com/quora/question-pairs-dataset) (QQP) dataset.

<pre>

TRAIN_DATA="data/glue_data/MNLI/train.tsv"
VALID_DATA="data/glue_data/MNLI/dev_matched.tsv \
            data/glue_data/MNLI/dev_mismatched.tsv"
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
VOCAB_FILE=bert-vocab.txt
CHECKPOINT_PATH=checkpoints/bert_345m_mnli
COMMON_TASK_ARGS=&#60;dezelfde als bij <a href="#race-evaluation">RACE Evaluatie</a> hierboven&#62;
COMMON_TASK_ARGS_EXT=&#60;dezelfde als bij <a href="#race-evaluation">RACE Evaluatie</a> hierboven&#62;

python tasks/main.py \
       --task MNLI \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
```
   --tokenizer-type BertWordPieceLowerCase \
   --epochs 5 \
   --micro-batch-size 8 \
   --lr 5.0e-5 \
   --lr-warmup-fraction 0.065
</pre>

## Llama-2 Inferentie en Fijnslijpen

De Llama-2 [familie van modellen](https://ai.meta.com/llama/) is een open-source set van voorgetrainde en fijngeslepen (voor chat) modellen die sterke resultaten hebben behaald op een breed scala aan benchmarks. Op het moment van uitgave behaalden Llama-2 modellen tot de beste resultaten voor open-source modellen en waren ze concurrerend met het gesloten GPT-3.5 model (zie https://arxiv.org/pdf/2307.09288.pdf).

De Llama-2 checkpoints kunnen in Megatron geladen worden voor inferentie en fijnslijpen. Zie documentatie [hier](docs/llama_mistral.md).

# Modeloptimalisatie en Uitrol
Megatron-Core (MCore) `GPTModel` familie ondersteunt geavanceerde kwantisatie-algoritmen en high-performance inferentie via TensorRT-LLM.

## Kwantisatie en TensorRT-LLM Uitrol
Zie [Megatron Modeloptimalisatie en Uitrol](examples/inference/quantization/README.md) voor voorbeelden van `llama2` en `nemotron3`.

# Datasets
Wij hosten geen datasets voor GPT of BERT training, maar we beschrijven hun verzameling zodat onze resultaten gereproduceerd kunnen worden.

## Wikipedia Trainingsdata Verzamelen
We raden aan het Wikipedia data-extractieproces te volgen zoals gespecificeerd door Google research: "de aanbevolen pre-processing is om [de laatste dump](https://dumps.wikimedia.org/enwiki/latest/enwiki-latest-pages-articles.xml.bz2) te downloaden, de tekst te extraheren met [WikiExtractor.py](https://github.com/attardi/wikiextractor), en vervolgens eventuele noodzakelijke opschoning toe te passen om het om te zetten naar platte tekst."

We raden aan het `--json` argument te gebruiken bij het gebruik van WikiExtractor, waardoor de Wikipedia data in los JSON formaat (één JSON object per regel) wordt opgeslagen. Dit maakt het beheersbaarder op het bestandssysteem en direct bruikbaar voor onze codebase. We adviseren om deze JSON dataset verder voor te bewerken met nltk interpunctiestandaardisatie. Voor BERT-training gebruik je de `--split-sentences` vlag bij `preprocess_data.py` zoals [hierboven](#data-preprocessing) beschreven om zinsafbrekingen op te nemen in de geproduceerde index. Als je Wikipedia data wilt gebruiken voor GPT-training, moet je het nog steeds opschonen met nltk/spacy/ftfy, maar gebruik dan niet de `--split-sentences` vlag.

## GPT Webtext Data Verzamelen
We maken gebruik van de publiek beschikbare [OpenWebText](https://github.com/eukaryote31/openwebtext) bibliotheek van [jcpeterson](https://github.com/jcpeterson/openwebtext) en [eukaryote31's](https://github.com/eukaryote31/openwebtext) werk om URL's te downloaden. We filteren, schonen en dedupliceren vervolgens alle gedownloade content volgens de procedure beschreven in onze [openwebtext](./tools/openwebtext) directory. Voor Reddit URL's die overeenkomen met content tot oktober 2018 kwamen we uit op ongeveer 37GB aan content.

# Reproduceerbaarheid
Megatron-training kan bitwise reproduceerbaar zijn; om deze modus te activeren gebruik je `--deterministic-mode`. Dit betekent dat dezelfde trainingsconfiguratie, tweemaal uitgevoerd in dezelfde HW- en SW-omgeving, identieke modelcheckpoints, verlies- en nauwkeurigheidswaarden moet opleveren (iteratietijd kan variëren).

Er zijn momenteel drie bekende Megatron-optimalisaties die de reproduceerbaarheid doorbreken terwijl ze bijna identieke trainingsruns produceren:
1. Het specifieke NCCL-algoritme dat wordt gebruikt tijdens een all-reduce (zoals gespecificeerd door de omgevingsvariabele `NCCL_ALGO`) is belangrijk. We hebben het volgende getest: `^NVLS`, `Tree`, `Ring`, `CollnetDirect`, `CollnetChain`. De code staat het gebruik van `^NVLS` toe, waardoor NCCL niet-NVLS algoritmes kan kiezen; deze keuze lijkt stabiel.
2. Flash attention is niet-deterministisch; gebruik niet `--use-flash-attn`.
3. Indien je Transformer Engine gebruikt, moet je ook de omgevingsvariabele `NVTE_ALLOW_NONDETERMINISTIC_ALGO=0` instellen.

Daarnaast is determinisme alleen geverifieerd in NGC PyTorch containers tot en met versie 23.12 en nieuwer. Als je niet-determinisme waarneemt in Megatron-training onder andere omstandigheden, open dan een issue.

# Checkpoint conversie

We ondersteunen twee vormen van modelconversie:

1. Modelklasse conversie (d.w.z. de `GPTModel` in `model.legacy` vs. `model.core`)
2. Checkpointformaat conversie (d.w.z. gedistribueerd versus niet-gedistribueerd checkpoint)

## Modelklasse conversie

Megatron ondersteunt conversie tussen verschillende modelklassen, waaronder interne modelklassen (we hebben momenteel de oudere `legacy` modellen en de nieuwere `core` modellen) en externe modelklassen (zoals Meta, Huggingface, Mistral, en Mixtral modellen). Daarnaast kan tijdens deze conversie de parallelstaat van het model worden bijgewerkt (d.w.z. het wijzigen van tensor- en pipeline modelparallelisme).

 We bieden het hulpmiddel `tools/checkpoint/convert.py` om tussen modelklassen te converteren. Enkele belangrijke argumenten zijn:

- `--model-type`: `GPT` of `BERT`
- `--loader`: formaat van het bestaande checkpoint. Ondersteunde formaten zijn:
  - `legacy`: onze oudere modelklassen (onder `megatron.legacy.model`)
  - `core`: onze nieuwere modelklassen (onder `megatron.core.models`)
  - `llama_mistral`: voor het laden van Llama en Mistral modellen (ondersteunt Meta en Huggingface formaten)
  - `mixtral_hf`: voor het laden van Mixtral modellen (alleen Huggingface)
- `--load-dir`: directory voor het laden van het bestaande checkpoint
- `--saver`: `legacy` of `core` (zie beschrijvingen onder `--loader`)
- `--save-dir`: directory voor het opslaan van het nieuwe checkpoint
- `--target-tensor-parallel-size`: nieuwe tensor model parallel grootte
- `--target-pipeline-parallel-size`: nieuwe pipeline model parallel grootte

Voor meer details over de argumenten, zie het hoofdscript (`convert.py`), loader scripts (`loader_core.py`, `loader_legacy.py`, `loader_llama_mistral.py`, `loader_mixtral_hf.py`), of saver scripts (`saver_core.py`, `saver_legacy.py`).

Een voorbeeldcommando voor het converteren van een GPT model van het oude formaat (`legacy`) naar het nieuwe formaat (`core`) zou er als volgt uitzien:

```
python tools/checkpoint/convert.py \
>   --model-type GPT \
>   --loader legacy \
>   --load-dir ${LEGACY_FORMAT_DIR} \
>   --saver core \
>   --save-dir ${CORE_FORMAT_DIR} \
>   --target-tensor-parallel-size ${TP} \
>   --target-pipeline-parallel-size ${PP} \
```

Voor voorbeelden van het converteren van Llama/Mistral modellen naar Megatron, zie [hier](docs/llama_mistral.md).

## Checkpointformaat conversie

Megatron biedt meerdere checkpointformaten, waaronder:

- `torch`: Basis checkpointformaat met sequentieel lezen & schrijven, en is gekoppeld aan een specifieke tensor/pipeline model parallelstaat (TP/PP staten). (Hoewel een specifiek checkpoint is gekoppeld aan een specifieke TP/PP staat, kan een checkpoint nog steeds handmatig worden geconverteerd via de hierboven beschreven modelklasse converter.)
- `torch_dist`: Gedistribueerd checkpointformaat, voor snelle parallelle lees & schrijf acties, en is ook parallelstaat-agnostisch (d.w.z. men kan hetzelfde checkpoint laden in verschillende TP/PP configuraties).

Over het algemeen is `torch_dist` het modernere en aanbevolen checkpointformaat vanwege de snelheid. Afhankelijk van het gebruik kan het echter wenselijk zijn om tussen deze twee formaten te converteren. Om dit te doen, start je je *training* script (bijv. via `pretrain_gpt.py`) zoals je normaal zou doen, maar met twee extra argumenten:

- `--ckpt-convert-format ${FORMAT}`: `${FORMAT}` kan één van `torch` of `torch_dist` zijn, zoals hierboven beschreven.
- `--ckpt-convert-save ${PATH_TO_SAVE_NEW_FORMAT}`: dit pad moet anders zijn dan je bestaande `--load`/`--save` paden, om te voorkomen dat het bestaande checkpoint wordt overschreven. Gebruik na het converteren dit nieuwe pad voor je `--load`/`--save` paden.

Het algemene idee van deze checkpointformaat converter is dat het model wordt gestart zoals normaal voor training, maar voordat er trainingsiteraties worden uitgevoerd, wordt er opgeslagen in het nieuwe checkpointformaat en vervolgens wordt afgesloten. Het is belangrijk op te merken dat alle andere startargumenten hetzelfde moeten blijven, zodat het systeem het vorige checkpointformaat kan begrijpen.

# Projecten die Megatron gebruiken
Hieronder enkele projecten waarin Megatron direct is gebruikt:
* [BERT and GPT Studies Using Megatron](https://arxiv.org/pdf/1909.08053.pdf)
* [BioMegatron: Larger Biomedical Domain Language Model](https://www.aclweb.org/anthology/2020.emnlp-main.379.pdf)
* [End-to-End Training of Neural Retrievers for Open-Domain Question Answering](https://arxiv.org/abs/2101.00408)
* [Large Scale Multi-Actor Generative Dialog Modeling](https://www.aclweb.org/anthology/2020.acl-main.8.pdf)
* [Local Knowledge Powered Conversational Agents](https://arxiv.org/abs/2010.10150)
* [MEGATRON-CNTRL: Controllable Story Generation with External Knowledge Using Large-Scale Language Models](https://www.aclweb.org/anthology/2020.emnlp-main.226.pdf)
* [RACE Reading Comprehension Dataset Leaderboard](http://www.qizhexie.com/data/RACE_leaderboard.html)
* [Training Question Answering Models From Synthetic Data](https://www.aclweb.org/anthology/2020.emnlp-main.468.pdf)
* [Few-shot Instruction Prompts for Pretrained Language Models to Detect Social Biases](https://arxiv.org/abs/2112.07868)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Using DeepSpeed and Megatron to Train Megatron-Turing NLG 530B, A Large-Scale Generative Language Model](https://arxiv.org/abs/2201.11990)
* [Multi-Stage Prompting for Knowledgeable Dialogue Generation](https://arxiv.org/abs/2203.08745)
* [Evaluating Parameter Efficient Learning for Generation](https://aclanthology.org/2022.emnlp-main.319.pdf)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Shall We Pretrain Autoregressive Language Models with Retrieval? A Comprehensive Study](https://arxiv.org/abs/2304.06762)
* [InstructRetro: Instruction Tuning post Retrieval-Augmented Pretraining](https://arxiv.org/abs/2310.07713)
* [An Empirical Study of Mamba-based Language Models](https://arxiv.org/abs/2406.07887)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---