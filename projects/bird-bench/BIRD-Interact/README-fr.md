
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
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## ⚠️ Annonce  
Veuillez noter qu'avant votre processus d'évaluation, lorsque Docker charge les bases de données, des erreurs peuvent parfois survenir en raison de l'incohérence de l'environnement (cela ne terminera pas le processus mais apparaîtra dans les logs Docker). En conséquence, certaines bases de données peuvent ne pas se charger correctement, ce qui conduit à des bases de données vides. Cela entraînera des résultats d'évaluation anormalement bas.  
👉 Par conséquent, nous recommandons fortement de vérifier les logs Docker pour toute erreur **avant d'exécuter l'évaluation** et de vérifier que toutes les bases de données ont été chargées avec succès.

👉 Nous avons mis à jour les **Directives de soumission**, où les agents personnalisés sont désormais supportés. N'hésitez pas à consulter nos directives de soumission détaillées [ici](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Actualités

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK** : Nous publions **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)**, une implémentation basée sur Google ADK avec une architecture modulaire à 3 microservices (agent, simulateur d'utilisateur et environnement BD). Remplacez facilement votre propre agent, simulateur d'utilisateur ou environnement BD. Prise en charge de l'exécution parallèle et de tout fournisseur LLM compatible [LiteLlm](https://docs.litellm.ai/docs/providers). Nous recommandons d'utiliser cette implémentation pour vos recherches.

- [2026-02-08] 🔥🔥🔥 Notre **[article Bird-Interact](https://huggingface.co/papers/2510.05318)** a été accepté à **ICLR 2026 (Oral)** ! Rendez-vous à Rio 🇧🇷 !  

- [2025-11-06] 🐛 **Correction de bug** & 🐳 **Mise à jour Docker** : Mise à jour de la version de sqlglot vers 26.16.4 pour corriger le bug où le parseur SQL ne pouvait pas analyser correctement le SQL pour le simulateur d'utilisateur. Vous pouvez corriger cela en réinstallant via `pip install sqlglot==26.16.4` dans l'environnement `bird_interact_eval`. L'image `bird_interact_eval` a également été mise à jour, vous pouvez donc la tirer et recréer le conteneur `bird_interact_eval`.

- [2025-10-21] 🐳 **Mise à jour Docker** : Nous avons ajouté le docker pour l'environnement BD complet. Et nous avons poussé 3 images docker (Base/Environnement BD complet et l'environnement d'évaluation pour `a-Interact` et `c-Interact`) sur Docker Hub pour faciliter la configuration de l'environnement. Plus besoin de télécharger les dumps BD et de construire les images manuellement !

- [2025-10-08] 📝 Notre **[article Bird-Interact](https://huggingface.co/papers/2510.05318)** est maintenant disponible publiquement !  
  Il présente tous les détails, la méthodologie et l'évaluation de notre benchmark interactif text-to-SQL.  
  👉 Consultez-le pour en savoir plus sur les idées derrière [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Nous sommes ravis d'annoncer la sortie du set **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** !  
C'est un défi — les meilleurs LLMs n'obtiennent qu'un taux de réussite de **16,33%**, avec seulement **10,0%** sur les portions `c-interact` et `a-interact`.  
👉 Pour plus de détails, veuillez visiter notre [site du projet](https://bird-interact.github.io/).

- [2025-08-26] 📬 Nous enverrons les **données de référence & cas de test** à notre liste de diffusion cette semaine.  
Si vous souhaitez un accès anticipé, veuillez envoyer un email comme indiqué sur le site pour un **téléchargement automatique**.  

- [2025-08-26] 💾 Par ailleurs, nous avons également publié une version SQLite de **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** pour faciliter la recherche locale.  
Les versions complètes **LiveSQLBench-Base** et **-Large** arrivent bientôt !

- [2025-08-22] **Correction de bug** : Dans le code de Bird-Interact-Agent, nous avons corrigé un bug lors de l'évaluation de la phase-2 SQL, où la SQL de la phase-1 stockée ne pouvait pas être exécutée avec succès, ce qui entraînait un taux de succès plus faible en phase-2. Ce bug ne concerne que les tâches où la phase1 SQL effectue des opérations sur la base de données, par exemple CREATE table, etc.

## 🧸 Aperçu

BIRD-INTERACT, un benchmark interactif text-to-SQL, **réinvente l’évaluation Text-to-SQL sous l’angle des interactions dynamiques**.
L’environnement mélange une base de connaissances hiérarchique, la documentation de la base de données et un simulateur d’utilisateur piloté par fonctions afin de recréer des environnements d’entreprise authentiques couvrant l’ensemble des opérations **CRUD**.
Il propose deux modes de test rigoureux : (1) **Interaction Conversationnelle** passive et (2) **Interaction Agentique** active, couvrant 600 tâches annotées incluant Business Intelligence (BI), opérations CRUD, etc., chacune étant validée par des cas de test exécutables.
Les évaluations typiques déclenchent de 1 968 à 5 496 tours d’interaction entre le modèle et le simulateur utilisateur, tandis que les modèles de raisonnement de pointe ne résolvent actuellement que **≈24%** et **≈18%** des tâches, ce qui souligne le défi du benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Deux Modes d'Évaluation

BIRD-INTERACT prend en charge deux modes d’évaluation comme mentionné ci-dessus :

   - **c-Interact** : Interaction Conversationnelle qui est un mode passif et dont le flux de travail est fixe. Le code et les informations détaillées se trouvent dans `bird_interact_conv`.
   - **a-Interact** : Interaction Agentique, un mode actif incarné où le flux de travail est dynamique et piloté par les modèles. Le code et les informations détaillées se trouvent dans `bird_interact_agent`.


### 🐣 Version Allégée

Nous publions une version allégée de BIRD-INTERACT, `bird-interact-lite-exp`, qui comprend 270 tâches réelles de haute qualité spécifiquement pour PostgreSQL. Il s’agit d’un bon point de départ pour une expérimentation rapide.

### 🦜 Version Complète

La version complète de BIRD-INTERACT, `bird-interact-full`, est un benchmark complet qui inclut 600 tâches pour PostgreSQL. Elle couvre un large éventail d’opérations SQL et de requêtes utilisateur. La version complète arrive bientôt.

### Résultats de Performance des Modèles sur BIRD-INTERACT-FULL

#### 1. **Performance c-Interact Text-to-SQL**
| Rang | Nom du Modèle         | Récompense Normalisée | Coût Moy. (USD)/Tâche | Niveau               |
|:----:|:---------------------|:---------------------:|:---------------------:|:--------------------:|
| 1    | Gemini-2.5-Pro       | 20.92                 | $0.04                 | 🏆 Chat Excellent    |
| 2    | O3-Mini              | 20.27                 | $0.07                 | 🏆 Chat Excellent    |
| 3    | Claude-Sonnet-4      | 18.35                 | $0.29                 | 💎 Bon Chat          |
| 4    | Qwen-3-Coder-480B    | 17.75                 | $0.11                 | 💎 Bon Chat          |
| 5    | Deepseek-Chat-V3.1   | 15.15                 | $0.12                 | ✨ Standard          |
| 6    | Claude-Sonnet-3.7    | 13.87                 | $0.29                 | ✨ Standard          |
| 7    | GPT-5                | 12.58                 | $0.08                 | ⚪ Basique           |

#### 2. **Performance a-Interact Text-to-SQL**
| Rang | Nom du Modèle         | Récompense Normalisée | Coût Moy. (USD)/Tâche | Niveau                      |
|:----:|:---------------------|:---------------------:|:---------------------:|:--------------------------:|
| 1    | GPT-5                | 25.52                 | $0.24                 | 🏆 Interaction Excellente   |
| 2    | Claude-Sonnet-4      | 23.28                 | $0.51                 | 🏆 Interaction Excellente   |
| 3    | Claude-Sonnet-3.7    | 17.45                 | $0.60                 | 💎 Bonne Interaction        |
| 4    | Gemini-2.5-Pro       | 17.33                 | $0.22                 | 💎 Bonne Interaction        |
| 5    | O3-Mini              | 16.43                 | $0.06                 | ✨ Standard                 |
| 6    | Deepseek-Chat-V3.1   | 13.47                 | $0.06                 | ✨ Standard                 |
| 7    | Qwen-3-Coder-480B    | 10.58                 | $0.07                 | ⚪ Basique                  |

> \* Paramètres de budget : Budget de départ/Budget de patience utilisateur, mesurés par notre monnaie virtuelle *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Voir [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) pour plus de détails.

### Échelle du Temps d’Interaction (ITS)

L’Échelle du Temps d’Interaction (ITS) désigne la capacité d’un modèle à augmenter continuellement ses performances finales via des interactions multi-tours. Lorsque cette performance interactive dépasse la performance idéalisée du modèle sur une tâche entièrement spécifiée et non ambiguë en un seul tour, on dit qu’il satisfait à la **loi ITS**. À mesure que la patience de l’utilisateur augmente et que les tours d’interaction s’accumulent, la performance continue de progresser, montrant que le modèle peut maintenir une communication efficace sur une longue durée de dialogue. Actuellement, seul claude-3-7-sonnet satisfait la loi ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Mise en place de l’environnement

1. Lancez les conteneurs Docker pour la base de données bird-interact-lite, la base de données bird-interact-full, et l’environnement d’évaluation :
  
  > Si vous souhaitez simplement évaluer sur `bird-interact-lite`, vous pouvez commenter le service [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) dans `docker-compose.yml` pour accélérer la mise en place de l’environnement.
  
  Lancez l’environnement en exécutant :
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Attendez quelques minutes pour l'initialisation de la base de données.
   
  Vous pouvez suivre l'avancement de la construction en :
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Si vous avez terminé, vous devriez voir les journaux sans erreurs comme :

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  Si vous avez déjà créé des conteneurs et souhaitez les recréer, vous pouvez exécuter la commande suivante :
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   Cela lance 3 conteneurs utilisant des images pré-construites depuis Docker Hub :
   - `bird_interact_postgresql` : Base de données PostgreSQL pour bird-interact-lite
   - `bird_interact_postgresql_full` : Base de données PostgreSQL pour bird-interact-full
   - `bird_interact_eval` : Environnement d'évaluation pour `a-Interact` et `c-Interact`.

   Vous pouvez maintenant démarrer l'environnement d'évaluation en exécutant la commande suivante :
   ```bash
   docker compose exec bird_interact_eval bash
   ```
2. (Optionnel) Construisez l'environnement manuellement (si vous souhaitez créer les images à partir de zéro) : 
   - Téléchargez les dumps de base de données 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Décompressez et renommez-le en `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Décompressez et renommez-le en `env/postgre_table_dumps_full`.
   - Construisez l'environnement manuellement en lançant `docker-compose.build.yml`.

      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Recommandé) Vérifiez que les conteneurs de base de données sont construits et fonctionnent correctement.

-  Affichez les journaux de construction des conteneurs pour vous assurer que les bases de données sont créées avec succès sans erreurs :
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Si des erreurs surviennent, `"Des erreurs sont survenues lors de l'importation :"` sera affiché dans les fichiers journaux.


-  Vérifiez si les conteneurs de la base de données sont en bon état.
   
   Utilisez notre script Python fourni pour vérifier les métadonnées de la base de données :
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Résultats attendus :
   - **bird-interact-lite** : 
     - 📈 Bases de données totales : 18
     - 📋 Tables totales : 175
     - 🔢 Colonnes totales : 2286
     - 📈 Moyenne de lignes par table : 1 038,48
     - 💾 Taille totale : 207,15 Mo (environ)
   - **bird-interact-full** : 
     - 📈 Bases de données totales : 22
     - 📋 Tables totales : 244
     - 🔢 Colonnes totales : 2011
     - 📈 Moyenne de lignes par table : 1 121,19
     - 💾 Taille totale : 272,00 Mo (environ)


## 📦 Détails du jeu de données

### Description du jeu de données

- **Base de données :** La base de données PostgreSQL complète peut être téléchargée depuis [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) et [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **données :** Chaque instance de données contient les parties principales suivantes :
   - `selected_database` : Le nom de la base de données.  
   - `query` : La requête utilisateur non ambiguë.  
   - `amb_user_query` : La requête utilisateur avec ambiguïtés injectées.
   - `user_query_ambiguity` : Les ambiguïtés injectées dans la requête utilisateur.
   - `non_critical_ambiguity` : Les ambiguïtés non critiques comme l'ordre, la limite, etc.
   - `knowledge_ambiguity` : Les ambiguïtés créées par des connaissances externes masquées. 
   - `sol_sql` : La solution SQL de référence.  
   - `preprocess_sql` : Requêtes SQL à exécuter avant la solution ou la prédiction.  
   - `clean_up_sql` : Requêtes SQL à exécuter après les cas de test pour annuler les modifications apportées à la base de données.  
   - `test_cases` : Un ensemble de cas de test pour valider le SQL corrigé prédit.
   - `follow_up` : Les questions de suivi étiquetées.
   - `external_knowledge` : Les connaissances externes liées à la tâche spécifique.

- **évaluation :** Le code d'évaluation est disponible dans le répertoire [`./evaluation`](./evaluation).
- **Réalisé par :** BIRD Team & Google Cloud
- **Licence :** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Carte du jeu de données HuggingFace :** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  et [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full) pour PostgreSQL ; et [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact) pour SQLite.
### Utilisations du jeu de données

Pour éviter toute fuite de données par auto-crawling, nous n'incluons pas les solutions SQL GT ni les cas de test avec les données.
Veuillez envoyer un e-mail à [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) avec le tag `[bird-interact-lite GT&Test Cases]` ou `[bird-interact-full GT&Test Cases]` dans le titre pour obtenir la vérité terrain et les cas de test du jeu de données bird-interact-lite ou bird-interact-full, qui vous seront envoyés automatiquement.


### Combiner les données publiques avec la vérité terrain et les cas de test

Utilisez ensuite le script suivant pour combiner les données publiques avec la vérité terrain et les cas de test :

Prenons la version complète comme exemple :
(1) Exécutez :
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
Cela créera un nouveau fichier à l'emplacement `/path/to/bird_interact_data.jsonl` contenant les données combinées.

(2) Remplacez ensuite les données publiques originales par les données combinées :

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

Idem pour les autres versions : bird-interact-lite, version mini, etc. Il suffit de définir les bons chemins pour les données publiques, la vérité terrain et les cas de test, puis de remplacer les données publiques par les données combinées.




<!-- ### Utiliser le jeu de données depuis HuggingFace

Vous pouvez télécharger le jeu de données depuis HuggingFace avec la commande suivante :
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
├── BIRD-Interact-ADK
│   ├── ...
│   └── README.md
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
Les détails concernant l’exécution de **a-interact** se trouvent dans `./bird_interact_agent/README.md` ; **c-interact** se trouve dans `./bird_interact_conv/README.md` ; et l’**implémentation basée sur ADK** se trouve dans `./BIRD-Interact-ADK/README.md`.

## 📋 Listes de tâches

- [x] Publication de la version allégée, bird-interact-lite (270).
- [x] Publication de la version conversationnelle, bird-interact-conv.
- [x] Publication de la version agent, bird-interact-agent.
- [x] Publication de la version complète bird-interact-full (600).
- [x] Publication de l’implémentation basée sur ADK, BIRD-Interact-ADK.
- [ ] SFT / RL et Simulateur d’Utilisateur

## Remerciements
Nous souhaitons exprimer notre profonde gratitude à **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi**, et au Professeur **Shinji Watanabe** pour leurs discussions enrichissantes et leurs précieux conseils qui ont permis d’améliorer ce projet.

## Créé par :
Équipe BIRD & Google Cloud







## Citation

```bibtex
@inproceedings{
huo2026birdinteract,
title={{BIRD}-{INTERACT}: Re-imagining Text-to-{SQL} Evaluation via Lens of Dynamic Interactions},
author={Nan Huo and Xiaohan Xu and Jinyang Li and Per Jacobsson and Shipei Lin and Bowen Qin and Binyuan Hui and Xiaolong Li and Ge Qu and Shuzheng Si and Linheng Han and Edward Alexander and Xintong Zhu and Rui Qin and Ruihan Yu and Yiyao Jin and Feige Zhou and Weihao Zhong and Yun Chen and Hongyu Liu and Chenhao Ma and Fatma Ozcan and Yannis Papakonstantinou and Reynold Cheng},
booktitle={The Fourteenth International Conference on Learning Representations},
year={2026},
url={https://openreview.net/forum?id=nHrYBGujps}
}
```
## Journal des modifications

- [2025-11-06] 🐛 **Correction de bug** & 🐳 **Mise à jour Docker** : Mise à jour de la version de sqlglot à 26.16.4 pour corriger le bug où le parseur SQL n'arrivait pas à analyser correctement le SQL pour le simulateur d'utilisateur. Vous pouvez corriger cela en le réinstallant via `pip install sqlglot==26.16.4` dans l'env `bird_interact_eval`. L'image `bird_interact_eval` est également mise à jour, vous pouvez donc aussi la récupérer et recréer le conteneur `bird_interact_eval`.
- [2025-10-21] 🐳 **Mise à jour Docker** : Ajout du docker pour l'environnement Full DB. Et nous avons poussé 3 images docker (Base/Full DB Env et l'environnement d'évaluation pour `a-Interact` et `c-Interact`) sur Docker Hub pour faciliter la mise en place de l'environnement. Plus besoin de télécharger les dumps DB et de construire les images manuellement ! Merci de tirer les dernières images de Docker Hub et de recréer les conteneurs, par exemple en utilisant `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Correction de bug** : Correction du bug lors de l'évaluation des SQL de phase 2, où les SQL de phase 1 stockées ne pouvaient pas être exécutées avec succès, entraînant un taux de réussite plus faible en phase 2. Ce bug n'affecte que les tâches où la SQL de phase 1 effectue des opérations sur la base de données, par exemple CREATE table, etc.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---