
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.fr">
    <img src="https://img.shields.io/badge/Licence-CC%20By%20SA%204.0-orange.svg" alt="Licence">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Classement-2025-28a745.svg" alt="Classement">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Jeu%20de%20donn%C3%A9es-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## 📰 Actualités

- [2025-08-26] 🚀 Nous sommes ravis d'annoncer la sortie du set **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** !  
C'est un défi — les meilleurs LLMs n'atteignent qu'un taux de réussite de **16,33%**, avec seulement **10,0%** sur les parties `c-interact` et `a-interact`.  
👉 Pour plus de détails, veuillez consulter notre [site projet](https://bird-interact.github.io/).

- [2025-08-26] 📬 Nous enverrons cette semaine les **Ground Truth & cas de test** à notre liste de diffusion.  
Pour un accès anticipé, merci d'envoyer un e-mail selon les instructions du site pour un **téléchargement automatique**.  

- [2025-08-26] 💾 Par ailleurs, nous avons également publié une version SQLite de **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** pour faciliter la recherche locale.  
Les versions complètes **LiveSQLBench-Base** et **-Large** arrivent bientôt !

- [2025-08-22] **Correction de bug** : Dans le code Bird-Interact-Agent, nous avons corrigé un bug qui, lors de l'évaluation du SQL de phase-2, empêchait l'exécution réussie du SQL de phase-1 stocké, entraînant un taux de réussite plus faible en Phase-2. Ce bug n'affecte que les tâches où le SQL de phase1 effectue des opérations sur la base de données, par exemple CREATE table, etc.

## 🧸 Vue d'ensemble

BIRD-INTERACT, un benchmark interactif text-to-SQL, **réinvente l'évaluation Text-to-SQL à travers le prisme des interactions dynamiques**.
L'environnement combine une base de connaissances hiérarchique, une documentation de base de données et un simulateur d'utilisateur piloté par fonctions pour recréer des environnements d'entreprise authentiques couvrant l'ensemble des opérations **CRUD**.
Il propose deux modes de test rigoureux : (1) **Interaction Conversationnelle** passive et (2) **Interaction Agentique** active, couvrant 600 tâches annotées incluant Business Intelligence (BI), opérations CRUD, etc., chacune protégée par des cas de test exécutables.
Les évaluations typiques déclenchent 1 968 à 5 496 tours d'interaction entre le modèle et le simulateur d'utilisateur, tandis que les modèles de raisonnement de pointe ne résolvent actuellement que **≈24%** et **≈18%** des tâches, ce qui souligne le défi du benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Deux modes d’évaluation

BIRD-INTERACT prend en charge deux modes d’évaluation comme mentionné ci-dessus :

   - **c-Interact** : Interaction conversationnelle, mode passif avec workflow fixe. Le code et les détails sont disponibles dans `bird_interact_conv`.
   - **a-Interact** : Interaction agentique, mode actif incarné où le workflow est dynamique et guidé par les modèles. Le code et les détails sont disponibles dans `bird_interact_agent`.


### 🐣 Version Lite

Nous publions une version allégée de BIRD-INTERACT, `bird-interact-lite-exp`, comprenant 270 tâches réelles de haute qualité spécifiquement pour PostgreSQL. C’est un bon point de départ pour une expérimentation rapide.

### 🦜 Version complète

La version complète de BIRD-INTERACT, `bird-interact-full`, est un benchmark exhaustif contenant 600 tâches pour PostgreSQL. Elle couvre un large éventail d’opérations SQL et de requêtes utilisateur. La version complète arrive bientôt.

### Résultats de performance des modèles sur BIRD-INTERACT Lite

#### 1. **Performance c-Interact**
| Rang | Nom du modèle       | Récompense normalisée | Niveau        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Excellente discussion |
| 2    | GPT-4o             | 30.33 | 💎 Bonne discussion      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Bonne discussion      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standard       |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standard       |
| 6    | Qwen3              | 20.33 | ⚪ Basique          |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Basique          |

#### 2. **Performance a-Interact**
| Rang | Nom du modèle       | Paramètres Budget* | Moy. étapes/tâche | Coût moy. (USD)/tâche | Récompense normalisée | Niveau              |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Excellente interaction |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Bonne interaction      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Bonne interaction      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standard              |
| 5    | GPT-4o             | 6/6 | 15,3 | $0,4594 | 18,37 | ✨ Standard              |
| 6    | Gemini-2.0-flash   | 6/6 | 13,2 | $0,0337 | 17,26 | ⚪ Basic                 |
| 7    | DeepSeek-R1        | 6/6 | 12,0 | $0,0931 | 17,07 | ⚪ Basic                 |

> \* Paramètres de budget : Budget de départ/Budget de patience utilisateur, mesurés par notre monnaie virtuelle *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Voir [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) pour plus de détails.

### Interaction-Time Scaling (ITS)

L'Interaction-Time Scaling (ITS) fait référence à la capacité d'un modèle à améliorer continuellement ses performances finales lors d'interactions multi-tours. Lorsque cette performance interactive dépasse celle du modèle en un seul tour sur une tâche entièrement spécifiée et non ambiguë, on dit qu'il satisfait la **loi ITS**. À mesure que la patience de l'utilisateur augmente et que les tours d'interaction s'accumulent, la performance continue de s'améliorer, démontrant que le modèle peut maintenir une communication efficace sur un dialogue prolongé. Actuellement, seul claude-3-7-sonnet satisfait la loi ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Détails du jeu de données

### Description du jeu de données

- **Base de données :** La base PostgreSQL complète peut être téléchargée depuis [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Consultez la section [Quick Eval](#quick-eval) pour plus de détails.
- **data :** Chaque instance de données contient les éléments principaux suivants :
   - `selected_database` : Le nom de la base de données.  
   - `query` : La requête utilisateur non ambiguë.  
   - `amb_user_query` : La requête utilisateur avec ambiguïtés injectées.
   - `user_query_ambiguity` : Les ambiguïtés injectées dans la requête utilisateur.
   - `non_critical_ambiguity` : Les ambiguïtés non critiques comme order, limit, etc.
   - `knowledge_ambiguity` : Les ambiguïtés créées par des connaissances externes masquées. 
   - `sol_sql` : La solution SQL de référence.  
   - `preprocess_sql` : Requêtes SQL à exécuter avant la solution ou la prédiction.  
   - `clean_up_sql` : Requêtes SQL à exécuter après les cas de test pour annuler les modifications apportées à la base.  
   - `test_cases` : Un ensemble de cas de test pour valider le SQL corrigé prédit.
   - `follow_up` : Les questions de suivi étiquetées.
   - `external_knowledge` : Les connaissances externes liées à la tâche spécifique.

- **evaluation :** Le code d’évaluation est disponible dans le répertoire [`./evaluation`](./evaluation).
- **Curaté par :** Équipe BIRD & Google Cloud
- **Licence :** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Carte du jeu de données HuggingFace :** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Usages du jeu de données

Pour éviter toute fuite de données due à l'auto-exploration, nous n'incluons pas les solutions GT sql et les cas de test avec les données.
veuillez envoyer un email à [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) avec le tag `[bird-interact-lite GT&Test Cases]` dans le titre pour obtenir l'ensemble complet, qui vous sera envoyé automatiquement.


<!-- ### Utiliser le jeu de données depuis HuggingFace

Vous pouvez télécharger le jeu de données depuis HuggingFace en utilisant la commande suivante :
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
Ou vous pouvez utiliser le script fourni pour télécharger la version complète du jeu de données et le diviser en différents dialectes.

```bash
cd baseline/data
python pull_data.py \
  --schema_path chemin/vers/full_schema.jsonl \
  --input_path chemin/vers/input.jsonl \ # Chemin vers le fichier JSONL d'entrée (peut être vide si vous souhaitez télécharger le jeu de données depuis HuggingFace)
  --output_folder chemin/vers/output_dir # dossier de sortie des fichiers divisés
```

## Structure des dossiers
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
Les détails concernant l’exécution de **a-interact** se trouvent dans `./bird_interact_agent/README.md` ; et ceux de **c-interact** dans `./bird_interact_conv/README.md`.

## 📋 Listes de tâches

- [x] Publier la version allégée, bird-interact-lite (270).
- [x] Publier la version conversationnelle, bird-interact-conv.
- [x] Publier la version agent, bird-interact-agent.
- [x] Publier la version complète bird-interact-full (600).
- [ ] SFT / RL d’un simulateur utilisateur

## Créé par :
Équipe BIRD & Google Cloud





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---