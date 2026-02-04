# AutoDefense : Défense Multi-Agent LLM contre les attaques de jailbreak

[**Blog**](https://microsoft.github.io/autogen/0.2/blog/2024/03/11/AutoDefense/Defending%20LLMs%20Against%20Jailbreak%20Attacks%20with%20AutoDefense/)

## Installation

```bash
pip install vllm autogen pandas retry openai
```

## Préparer le Service d'Inférence en Utilisant [vLLM](https://docs.vllm.ai/)

vLLM fournit un serveur API compatible OpenAI avec une inférence efficace et un équilibrage de charge intégré sur plusieurs GPU.

### Démarrer le Serveur vLLM

Démarrez le serveur vLLM avec le modèle de votre choix. Pour les configurations multi-GPU, utilisez `--data-parallel-size` pour activer l'équilibrage automatique de la charge :

**GPU Unique :**
```bash
vllm serve Qwen/Qwen3-1.7B --port 8000
```

**Plusieurs GPU (par exemple, 2 GPU avec parallélisme de données) :**
```bash
vllm serve Qwen/Qwen3-1.7B --port 8000 --data-parallel-size 2
```
**Avec le parallélisme tensoriel pour les modèles plus grands :**

```bash
vllm serve <your-large-model> --port 8000 --tensor-parallel-size 4
```

**Parallélisme tensoriel et parallélisme de données combinés (8 GPU, TP 2 voies × DP 4 voies) :**
```bash
vllm serve <your-large-model> --port 8000 --tensor-parallel-size 2 --data-parallel-size 4
```

Pour plus de détails sur le déploiement en parallèle des données avec équilibrage de charge interne, voir la [documentation vLLM](https://docs.vllm.ai/en/latest/serving/data_parallel_deployment/).

### Vérifier le serveur

Vous pouvez vérifier que le serveur fonctionne en consultant le point de terminaison des modèles :

```bash
curl http://localhost:8000/v1/models
```

## Génération de réponses

Les réponses sont générées par le modèle cible servi par vLLM (par défaut : `Qwen/Qwen3-1.7B`). Assurez-vous que votre serveur vLLM est en fonctionnement avant d'exécuter la commande suivante.

### Invites d'attaque (nuisibles)

```bash
python attack/attack.py --model Qwen/Qwen3-1.7B --host 127.0.0.1 --port 8000
```

Cette commande générera des réponses en utilisant un modèle d’invite d’attaque (par défaut : `--template v1`) chargé depuis `data/prompt/attack_prompt_template.json`.  
Pour exécuter plusieurs répétitions, lancez le script plusieurs fois en variant `--output-suffix` et/ou `--cache-seed`.  

### Invites sûres (Bénignes)  

Pour générer des réponses pour des invites sûres/bénignes (utilisées pour l’évaluation des faux positifs) :

```bash
python attack/attack.py \
    --model Qwen/Qwen3-1.7B \
    --template placeholder \
    --prompts data/prompt/safe_prompts.json \
    --output-prefix safe
```

Le modèle `placeholder` transmet les invites sans aucune mise en cadre d'attaque, tandis que `v1` enveloppe les invites avec des instructions de contournement.

## Exécuter des expériences de défense

La commande suivante exécute les expériences de défense avec 1 agent, 2 agents et 3 agents. Le paramètre `--chat-file` doit pointer vers les sorties nuisibles générées par `attack/attack.py` (par défaut sauvegardées sous `data/harmful_output/<model_dir>/`, par exemple `data/harmful_output/Qwen-Qwen3-1.7B/attack-dan_0.json`).

```bash
export AUTOGEN_USE_DOCKER=0

python defense/run_defense_exp.py \
  --model Qwen/Qwen3-1.7B \
  --chat-file data/harmful_output/Qwen-Qwen3-1.7B/attack-dan_0.json
```

### Arguments en ligne de commande

| Argument | Description | Par défaut |
|----------|-------------|------------|
| `--model` | Modèle cible servi par vLLM | `Qwen/Qwen3-1.7B` |
| `--chat-file` | Chemin vers le fichier de chat avec sorties nuisibles | Requis |
| `--port` | Port où le serveur vLLM fonctionne | `8000` |
| `--host` | Nom d'hôte du serveur vLLM | `127.0.0.1` |
| `--output-dir` | Répertoire de sortie | `data/defense_output/<model_dir>` |
| `--output-suffix` | Suffixe pour le répertoire de sortie | `""` |
| `--strategies` | Stratégies de défense à exécuter | `ex-2 ex-3 ex-cot` |
| `--workers` | Nombre de travailleurs parallèles | `128` |
| `--frequency_penalty` | Pénalité de fréquence pour la génération | `0.0` |
| `--presence_penalty` | Pénalité de présence pour la génération | `0.0` |
| `--temperature` | Température pour la génération | `0.7` |

Après avoir terminé l'expérience de défense, la sortie apparaîtra dans `data/defense_output/<model_dir>/` (par exemple `data/defense_output/Qwen-Qwen3-1.7B/`).

## Évaluation GPT (l’article utilise GPT-4)

Évaluation de la défense contre les sorties nuisibles :

```bash
python evaluator/gpt4_evaluator.py \
--defense_output_dir data/defense_output/Qwen-Qwen3-1.7B \
--ori_prompt_file_name prompt_dan.json
```

Après avoir terminé l’évaluation, le résultat apparaîtra dans `data/defense_output/Qwen-Qwen3-1.7B/asr.csv`.  
Il y aura également une valeur `score` apparaissant pour chaque sortie de défense dans le fichier `json` de sortie.  
`evaluator/gpt4_evaluator.py` utilise un modèle GPT comme évaluateur (l’article original utilise GPT-4).  
Configurez vos identifiants OpenAI via des variables d’environnement (ou des options CLI), et vous pouvez remplacer l’évaluateur par un modèle GPT plus récent (par exemple, GPT-5) via `--model`.  

```bash
export OPENAI_API_KEY=...
# optional (only if you use an OpenAI-compatible endpoint):
# export OPENAI_BASE_URL=...

python evaluator/gpt4_evaluator.py \
  --defense_output_dir data/defense_output/Qwen-Qwen3-1.7B \
  --ori_prompt_file_name prompt_dan.json \
  --model gpt-4-1106-preview
```

L’évaluation basée sur GPT peut être coûteuse ; nous activons la mise en cache pour éviter les évaluations répétées.

Pour une évaluation sûre des réponses, il existe une méthode efficace sans utiliser GPT-4. Si vous savez que toutes les invites de votre ensemble de données sont des invites utilisateur régulières et ne doivent pas être rejetées, vous pouvez utiliser la commande suivante pour évaluer le taux de faux positifs (FPR) de la sortie de la défense.

```bash
python evaluator/evaluate_safe.py
```

Cela trouvera tous les dossiers de sortie dans `data/defense_output` contenant le mot-clé `-safe` et évaluera le taux de faux positifs (FPR).  
Le FPR sera enregistré dans le fichier `data/defense_output/defense_fp.csv`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-04

---