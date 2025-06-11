# KVzip: Compressione della Cache KV Indipendente dalla Query con Ricostruzione del Contesto

[[Articolo](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## Novità
- KVzip comprime la cache KV per supportare **diverse query future**.
- [Dipendente dal contesto] Raggiunge una **riduzione di 3–4× della dimensione della cache KV** e una **diminuzione di 2× della latenza di decodifica**, con una degradazione minima delle prestazioni.
- [Indipendente dal contesto] Migliora la compressione KV a livello di testa in stile [DuoAttention](https://github.com/mit-han-lab/duo-attention), utilizzando solo **alcuni forward pass in meno di un minuto** per l’ottimizzazione del punteggio di importanza a livello di testa (100x più veloce).
- Esegui demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Benchmark in configurazione query-agnostica
- Task: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Modello: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Installazione
Abbiamo utilizzato CUDA 12.1 e Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- Per utilizzare la quantizzazione di [QServe](https://github.com/mit-han-lab/omniserve), segui [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### Dataset
- Scarica il dataset SCBench preprocessato da [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link).
- Se hai scaricato i file decompressi, sposta semplicemente la cartella scbench.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Avvio Rapido
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # prefill cache KV + valutazione importanza
kv.prune(ratio=0.3)  # rapporto di compressione, elimina il 70% della cache KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # inferenza efficiente
    print(q, output)
```
- I modelli supportati sono elencati in [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), inclusi **LLaMA3, Qwen2.5/3, Gemma3**.
- Imposta `load_score=True` per eliminare l’overhead di compressione. Questo abilita l’eliminazione KV indipendente dal contesto, con un compromesso nel rapporto di compressione a `ratio=0.6`.
- Dopo la generazione, le coppie KV corrispondenti alle query e ai token generati vengono selettivamente eliminate dalla cache per ulteriori elaborazioni. Imposta `update_cache=True` per abilitare l’inferenza multi-turno, mantenendo l’intera cronologia delle interazioni durante l’inferenza.

## Profilazione di Memoria e Tempo di Calcolo
### Eliminazione dipendente dal contesto
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- Il codice sopra confronta anche gli output generati con cache KV completa rispetto a quella potata.
- Per un test rapido, usa `-d squad`. Per test a lungo contesto, usa `-d scbench_kv`.
  - Nomi dei dati disponibili: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Nomi dei modelli disponibili: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), ad es. llama3.1-8b, qwen2.5-7b (o Qwen/Qwen2.5-7B-Instruct-1M).
- Abbiamo adattato il kernel CUDA da [AdaKV](https://github.com/FFY0/AdaKV/tree/main), che supporta l’allocazione non uniforme del budget per testa.
  - Attualmente, il nostro codice non ha un kernel ottimizzato per Gemma3 che usa cache KV statica, quindi il codice non produce guadagni effettivi in efficienza. Tuttavia, le prestazioni del modello possono ancora essere valutate usando l’attenzione ridotta con sottocampionamento KV (`--kv_type retain`).


### Eliminazione indipendente dal contesto (senza overhead di compressione a runtime)
- Usa il flag `--level head` con `--ratio 0.6` (consigliato).
  - Rimuoviamo tutte le coppie KV di contesto associate a una testa specifica mantenendo le coppie KV del prompt di sistema e della query.
  - I punteggi precomputati per le teste sono disponibili per LLaMA3.1-8B e Qwen2.5-7/14B in `./utils/head_score`.
- Per calcolare i punteggi delle teste per altri modelli:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - I risultati saranno salvati in `./utils/head_score`.
  - Se si punta a un task di coding, si consiglia di eseguire anche il comando con `-d scbench_repoqa`. Questo permette al modello di usare i punteggi massimi delle teste sia dal linguaggio naturale che da quello di programmazione, migliorando le prestazioni.
- Questi punteggi possono essere integrati senza problemi con il motore di inferenza ottimizzato di [DuoAttention](https://github.com/mit-han-lab/duo-attention) sostituendo i loro dati di punteggio delle teste con i nostri.


## Valutazione
- Per generare risposte del modello con rapporti di compressione KV da 0.1 a 1.0:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - I risultati saranno salvati in `./results/[data_name]`.
  - I dataset supportati sono elencati in `data/load.py`.
- Per calcolare le metriche di valutazione dai risultati generati:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## Applicazione a Nuovi Modelli
Per integrare KVzip in un nuovo modello, è necessario aggiornare i seguenti file:
- `attention/attn.py`  
  Modifica la logica del forward pass dell’attenzione come necessario. In alcuni casi, sono richiesti aggiornamenti anche a kvcache.py e score.py.
- `model/monkeypatch.py`  
  Implementa il monkey patching specifico per il modello per l’integrazione.
- `model/template.py`   
  Definisci il prompt di sistema del modello e i template di formattazione della chat.


## Citazione
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Licenza
Licenza MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---