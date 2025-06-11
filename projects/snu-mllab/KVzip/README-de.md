# KVzip: Abfrage-agnostische KV-Cache-Kompression mit Kontextrekonstruktion

[[Paper](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## Was ist neu?
- KVzip komprimiert den KV-Cache, um **diverse zukünftige Abfragen** zu unterstützen.
- [Kontextabhängig] Erreicht eine **3–4× Reduktion der KV-Cache-Größe** und eine **2× Verringerung der Dekodierlatenz**, mit minimalem Leistungsverlust.
- [Kontextunabhängig] Verbessert die [DuoAttention](https://github.com/mit-han-lab/duo-attention)-artige Kopf-Level-KV-Kompression, indem nur **wenige Vorwärtsdurchläufe innerhalb einer Minute** für die Optimierung der Kopf-Level-Wichtigkeitswerte verwendet werden (100x schneller).
- Demo ausführen:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Benchmarking im abfrage-agnostischen Setting
- Aufgaben: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Modell: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Installation
Wir verwendeten CUDA 12.1 und Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- Um [QServe](https://github.com/mit-han-lab/omniserve)-Quantisierung zu verwenden, folgen Sie bitte [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### Datensatz
- Bitte laden Sie den vorverarbeiteten SCBench-Datensatz von [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link) herunter.
- Wenn Sie die Dateien entpackt haben, verschieben Sie einfach den Ordner scbench.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Schnellstart
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # KV-Cache vorbefüllen + Wichtigkeit bewerten
kv.prune(ratio=0.3)  # Kompressionsrate, 70 % KV entfernen

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # effiziente Inferenz
    print(q, output)
```
- Unterstützte Modelle sind in [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py) aufgelistet, darunter **LLaMA3, Qwen2.5/3, Gemma3**.
- Setzen Sie `load_score=True`, um Kompressions-Overhead zu eliminieren. Dadurch ist kontextunabhängiges KV-Verwerfen möglich, mit einem Kompromiss bei der Kompressionsrate von `ratio=0.6`.
- Nach der Generierung werden KV-Paare, die den Abfragen und generierten Tokens entsprechen, selektiv aus dem Cache entfernt, um weitere Verarbeitung zu ermöglichen. Setzen Sie `update_cache=True`, um Multi-Turn-Inferenz zu aktivieren und vollständige Interaktionsverläufe während der Inferenz beizubehalten.

## Profilierung von Speicher und Rechenzeit
### Kontextabhängiges Verwerfen
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- Der obige Code vergleicht auch die mit vollem versus beschnittenem KV-Cache generierten Ausgaben.
- Für einen schnellen Test verwenden Sie `-d squad`. Für Langzeit-Kontext-Tests nutzen Sie `-d scbench_kv`.
  - Verfügbare Datensatznamen: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Verfügbare Modellnamen: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), z.B. llama3.1-8b, qwen2.5-7b (oder Qwen/Qwen2.5-7B-Instruct-1M).
- Wir passen CUDA-Kernel von [AdaKV](https://github.com/FFY0/AdaKV/tree/main) an, der nicht-uniforme Kopf-Budget-Zuweisung unterstützt.
  - Derzeit fehlt in unserem Code ein optimierter Kernel für Gemma3, das einen statischen KV-Cache verwendet, weshalb keine tatsächlichen Effizienzgewinne erzielt werden. Die Modellleistung kann jedoch weiterhin mittels reduzierter Aufmerksamkeit mit KV-Subsampling (`--kv_type retain`) evaluiert werden.


### Kontextunabhängiges Verwerfen (kein Laufzeit-Kompressions-Overhead)
- Verwenden Sie das Flag `--level head` mit `--ratio 0.6` (empfohlen).
  - Wir entfernen alle Kontext-KV-Paare, die mit einem bestimmten Kopf verbunden sind, während System-Prompt- und Abfrage-KV-Paare erhalten bleiben.
  - Vorgefertigte Kopf-Wichtigkeitswerte sind für LLaMA3.1-8B und Qwen2.5-7/14B in `./utils/head_score` verfügbar.
- Um Kopf-Wichtigkeitswerte für andere Modelle zu berechnen:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - Ergebnisse werden in `./utils/head_score` gespeichert.
  - Bei Zielsetzung einer Coding-Aufgabe empfehlen wir zusätzlich den Befehl mit `-d scbench_repoqa` auszuführen. Dadurch kann das Modell die maximalen Kopf-Wichtigkeitswerte aus natürlichen und Programmier-Sprachen verwenden, was die Leistung verbessert.
- Diese Werte können nahtlos in die optimierte Inferenz-Engine von [DuoAttention](https://github.com/mit-han-lab/duo-attention) integriert werden, indem deren Kopf-Wertdaten durch unsere ersetzt werden.


## Evaluation
- Um Modellantworten mit KV-Kompressionsraten von 0,1 bis 1,0 zu generieren:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - Ergebnisse werden in `./results/[data_name]` gespeichert.
  - Unterstützte Datensätze sind in `data/load.py` aufgelistet.
- Um Evaluationsmetriken aus generierten Ergebnissen zu berechnen:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## Anwendung auf neue Modelle
Um KVzip in ein neues Modell zu integrieren, müssen Sie folgende Dateien aktualisieren:
- `attention/attn.py`  
  Modifizieren Sie die Logik des Attention-Forward-Passes nach Bedarf. In manchen Fällen sind auch Änderungen an kvcache.py und score.py erforderlich.
- `model/monkeypatch.py`  
  Implementieren Sie modell-spezifisches Monkey-Patching für die Integration.
- `model/template.py`   
  Definieren Sie den System-Prompt und die Chat-Formatvorlagen des Modells.


## Zitierung
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Lizenz
MIT Lizenz

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---