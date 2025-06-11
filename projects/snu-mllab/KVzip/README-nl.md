# KVzip: Query-Agnostische KV Cache Compressie met Contextreconstructie

[[Paper](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## Wat is er nieuw?
- KVzip comprimeert de KV-cache om **diverse toekomstige queries** te ondersteunen.
- [Context-afhankelijk] Bereik een **3–4× reductie in KV-cache grootte** en een **2× vermindering in decoderingstijd**, met minimale prestatievermindering.
- [Context-onafhankelijk] Verbeter [DuoAttention](https://github.com/mit-han-lab/duo-attention)-stijl head-level KV compressie, met slechts **enkele forward passes binnen een minuut** voor optimalisatie van head-level belangscores (100x sneller).
- Run demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Benchmarking in query-agnostische setting
- Taken: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Model: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Installatie
We gebruikten CUDA 12.1 en Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- Om [QServe](https://github.com/mit-han-lab/omniserve) kwantisatie te gebruiken, volg a.u.b. [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### Dataset
- Download a.u.b. de voorbewerkte SCBench dataset van [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link).
- Als je de bestanden hebt gedownload en uitgepakt, verplaats dan eenvoudig de scbench map.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Snel Starten
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # prefill KV cache + belangscore
kv.prune(ratio=0.3)  # compressieverhouding, verwijder 70% KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # efficiënte inferentie
    print(q, output)
```
- Ondersteunde modellen staan in [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), inclusief **LLaMA3, Qwen2.5/3, Gemma3**.
- Zet `load_score=True` om compressie overhead te elimineren. Dit maakt context-onafhankelijke KV-verwijdering mogelijk, met een compressieverhouding van `ratio=0.6` als compromis.
- Na generatie worden KV-paren die overeenkomen met de queries en gegenereerde tokens selectief verwijderd uit de cache voor verdere verwerking. Zet `update_cache=True` aan voor multi-turn inferentie, waarbij volledige interactiegeschiedenis wordt behouden tijdens de inferentie.

## Profileren van Geheugen en Rekentijd
### Context-afhankelijke verwijdering
```bash
python -B test.py -m [model_naam] -d [data_naam] --kv_type evict --ratio 0.3
```
- De bovenstaande code vergelijkt ook output gegenereerd met volledige versus gepruneerde KV-caches.
- Voor snelle tests, gebruik `-d squad`. Voor lang-context testen, gebruik `-d scbench_kv`.
  - Beschikbare datanamen: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Beschikbare modelnamen: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), bv. llama3.1-8b, qwen2.5-7b (of Qwen/Qwen2.5-7B-Instruct-1M).
- We passen CUDA-kernel aan van [AdaKV](https://github.com/FFY0/AdaKV/tree/main), die niet-uniforme hoofd-budgettoewijzing ondersteunt.
  - Momenteel mist onze code een geoptimaliseerde kernel voor Gemma3 die een statische KV-cache gebruikt, dus de code levert geen echte efficiëntiewinst. Modelprestaties kunnen echter nog steeds worden geëvalueerd met gereduceerde aandacht via KV-subsampling (`--kv_type retain`).


### Context-onafhankelijke verwijdering (geen runtime compressie overhead)
- Gebruik de `--level head` vlag met `--ratio 0.6` (aanbevolen).
  - We verwijderen alle context-KV-paren die horen bij een specifieke head, terwijl systeem-prompt en query-KV-paren behouden blijven.
  - Vooraf berekende head scores zijn beschikbaar voor LLaMA3.1-8B en Qwen2.5-7/14B in `./utils/head_score`.
- Om head scores te berekenen voor andere modellen:
  ```bash
  python -B test.py -m [model_naam] -d scbench_qa_eng --save_head_score
  ```
  - Resultaten worden opgeslagen in `./utils/head_score`.
  - Voor coderingstaken raden we aan ook de opdracht uit te voeren met `-d scbench_repoqa`. Dit stelt het model in staat de maximale head scores van zowel natuurlijke als programmeertalen te gebruiken, wat de prestaties verbetert.
- Deze scores kunnen naadloos geïntegreerd worden met de geoptimaliseerde inferentiemotor van [DuoAttention](https://github.com/mit-han-lab/duo-attention) door hun head score data te vervangen door de onze.


## Evaluatie
- Om modelantwoorden te genereren met KV-compressieverhoudingen van 0.1 tot 1.0:
    ```bash
    python -B eval.py -m [model_naam] -d [data_naam] --kv_type retain --num 100
    ``` 
  - Resultaten worden opgeslagen in `./results/[data_naam]`.
  - Ondersteunde datasets staan in `data/load.py`.
- Om evaluatiemaatstaven te berekenen van gegenereerde resultaten:
  ```bash
  python -B -m results.parse -m [model_naam] -d [data_naam]
  ```

## Toepassen op Nieuwe Modellen
Om KVzip te integreren voor een nieuw model, moet je de volgende bestanden bijwerken:
- `attention/attn.py`  
  Pas de attention forward pass logica aan waar nodig. Soms zijn ook aanpassingen aan kvcache.py en score.py vereist.
- `model/monkeypatch.py`  
  Implementeer model-specifieke monkey patching voor integratie.
- `model/template.py`   
  Definieer de systeem-prompt en chat-formattering templates van het model.


## Citatie
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Licentie
MIT License

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---