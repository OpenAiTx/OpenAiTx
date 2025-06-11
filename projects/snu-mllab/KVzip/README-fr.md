# KVzip : Compression du cache KV indépendante des requêtes avec reconstruction de contexte

[[Article](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## Quoi de neuf ?
- KVzip compresse le cache KV pour supporter **diverses requêtes futures**.
- [Dépendant du contexte] Obtention d'une **réduction de 3 à 4× de la taille du cache KV** et d'une **diminution de 2× de la latence de décodage**, avec une dégradation de performance minimale.
- [Indépendant du contexte] Amélioration de la compression KV au niveau des têtes de type [DuoAttention](https://github.com/mit-han-lab/duo-attention), en utilisant seulement **quelques passages avant en moins d'une minute** pour l'optimisation des scores d'importance au niveau des têtes (100x plus rapide).
- Exécutez demo.py :
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Benchmark dans un cadre indépendant des requêtes
- Tâches : [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Modèle : [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Installation
Nous avons utilisé CUDA 12.1 et Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- Pour utiliser la quantification [QServe](https://github.com/mit-han-lab/omniserve), veuillez suivre [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### Jeu de données
- Veuillez télécharger le jeu de données SCBench pré-traité depuis [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link).
- Si vous avez téléchargé les fichiers décompressés, déplacez simplement le dossier scbench.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Démarrage rapide
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # préremplissage du cache KV + score d'importance
kv.prune(ratio=0.3)  # taux de compression, éviction de 70% du KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # inférence efficace
    print(q, output)
```
- Les modèles supportés sont listés dans [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), incluant **LLaMA3, Qwen2.5/3, Gemma3**.
- Définissez `load_score=True` pour éliminer le surcoût de compression. Cela permet une éviction KV indépendante du contexte, avec un compromis sur le taux de compression à `ratio=0.6`.
- Après la génération, les paires KV correspondant aux requêtes et aux tokens générés sont évincées sélectivement du cache pour un traitement ultérieur. Définissez `update_cache=True` pour permettre une inférence multi-tours, en conservant l'historique complet des interactions pendant toute l'inférence.

## Profilage de la mémoire et du temps de calcul
### Éviction dépendante du contexte
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- Le code ci-dessus compare également les sorties générées avec le cache KV complet versus le cache KV élagué.
- Pour un test rapide, utilisez `-d squad`. Pour un test en contexte long, utilisez `-d scbench_kv`.
  - Noms des données disponibles : [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Noms des modèles disponibles : [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), ex. llama3.1-8b, qwen2.5-7b (ou Qwen/Qwen2.5-7B-Instruct-1M).
- Nous adaptons le kernel CUDA de [AdaKV](https://github.com/FFY0/AdaKV/tree/main), supportant une allocation non uniforme du budget par tête.
  - Actuellement, notre code ne comprend pas de kernel optimisé pour Gemma3 qui utilise un cache KV statique, donc le code n'apporte pas de gains d'efficacité réels. Cependant, la performance du modèle peut toujours être évaluée en utilisant une attention réduite avec sous-échantillonnage KV (`--kv_type retain`).


### Éviction indépendante du contexte (sans surcoût de compression à l'exécution)
- Utilisez le flag `--level head` avec `--ratio 0.6` (recommandé).
  - Nous supprimons toutes les paires KV de contexte associées à une tête spécifique tout en conservant les paires KV du prompt système et des requêtes.
  - Les scores de tête pré-calculés sont disponibles pour LLaMA3.1-8B et Qwen2.5-7/14B dans `./utils/head_score`.
- Pour calculer les scores de tête pour d'autres modèles :
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - Les résultats seront sauvegardés dans `./utils/head_score`.
  - Si vous ciblez une tâche de codage, nous recommandons également d'exécuter la commande avec `-d scbench_repoqa`. Cela permet au modèle d'utiliser les scores de tête maximum issus des langues naturelles et du codage, ce qui améliore les performances.
- Ces scores peuvent être intégrés sans difficulté avec le moteur d'inférence optimisé de [DuoAttention](https://github.com/mit-han-lab/duo-attention) en remplaçant leurs données de score de tête par les nôtres.


## Évaluation
- Pour générer des réponses de modèle avec des taux de compression KV allant de 0.1 à 1.0 :
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - Les résultats seront sauvegardés dans `./results/[data_name]`.
  - Les jeux de données supportés sont listés dans `data/load.py`.
- Pour calculer les métriques d'évaluation à partir des résultats générés :
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## Application à de nouveaux modèles
Pour intégrer KVzip à un nouveau modèle, vous devrez mettre à jour les fichiers suivants :
- `attention/attn.py`  
  Modifiez la logique du passage avant de l'attention selon les besoins. Dans certains cas, des mises à jour de kvcache.py et score.py peuvent aussi être nécessaires.
- `model/monkeypatch.py`  
  Implémentez le monkey patch spécifique au modèle pour l'intégration.
- `model/template.py`   
  Définissez le prompt système et les templates de formatage de chat du modèle.


## Citation
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Licence
Licence MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---