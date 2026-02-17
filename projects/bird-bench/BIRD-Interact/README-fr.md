
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
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="Licence">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Classement">
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
Veuillez noter qu'avant le processus d'évaluation, lors du chargement des bases de données par Docker, des erreurs peuvent parfois survenir en raison d'une incohérence d'environnement (elles n'arrêtent pas le processus mais apparaissent dans les logs Docker). Par conséquent, certaines bases de données peuvent ne pas se charger correctement, entraînant des bases de données vides. Cela provoquera des résultats d'évaluation anormalement faibles.  
👉 Nous vous recommandons donc fortement de vérifier les logs Docker pour toute erreur **avant de lancer l'évaluation** et de vérifier que toutes les bases de données ont bien été chargées.

👉 Nous avons mis à jour les **Directives de soumission**, où les squelettes d'agents personnalisés sont pris en charge. N'hésitez pas à consulter nos directives de soumission détaillées [ici](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Actualités

- [2026-02-08] 🔥🔥🔥 Notre **[article Bird-Interact](https://huggingface.co/papers/2510.05318)** a été accepté à **ICLR 2026 (Oral)** ! Rendez-vous à Rio 🇧🇷 !  

- [2025-11-06] 🐛 **Correction de bug** & 🐳 **Mise à jour Docker** : Mise à jour de sqlglot en version 26.16.4 pour corriger le bug empêchant l'analyse correcte du SQL pour le simulateur utilisateur. Vous pouvez corriger cela en réinstallant avec `pip install sqlglot==26.16.4` dans l'environnement `bird_interact_eval`. L'image `bird_interact_eval` est également mise à jour, vous pouvez donc la récupérer et recréer le conteneur `bird_interact_eval`.

- [2025-10-21] 🐳 **Mise à jour Docker** : Nous avons ajouté le docker pour l'environnement Full DB. Nous avons également publié 3 images docker (Base/Full DB Env et l'environnement d'évaluation pour `a-Interact` et `c-Interact`) sur Docker Hub pour faciliter la configuration de l'environnement. Plus besoin de télécharger les dumps de base de données ni de construire les images manuellement !

- [2025-10-08] 📝 Notre **[article Bird-Interact](https://huggingface.co/papers/2510.05318)** est désormais disponible publiquement !  
  Il présente tous les détails, la méthodologie et l'évaluation de notre benchmark interactif text-to-SQL.  
  👉 Consultez-le pour en savoir plus sur les idées derrière [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Nous sommes ravis d’annoncer la sortie du **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** !  
C’est un défi difficile — les meilleurs LLM n’atteignent qu’un taux de réussite de **16.33%**, avec seulement **10.0%** sur les portions `c-interact` et `a-interact`.  
👉 Pour plus de détails, veuillez visiter notre [site du projet](https://bird-interact.github.io/).

- [2025-08-26] 📬 Nous enverrons les **Ground Truth & cas de test** à notre liste de diffusion cette semaine.  
Si vous souhaitez un accès anticipé, veuillez envoyer un e-mail comme indiqué sur le site pour un **téléchargement automatique**.  

- [2025-08-26] 💾 Par ailleurs, nous avons également publié une version SQLite de **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** pour faciliter la recherche locale.  
Les versions complètes **LiveSQLBench-Base** et **-Large** arrivent bientôt !

- [2025-08-22] **Correction de bug** : Dans le code Bird-Interact-Agent, nous avons corrigé un bug qui, lors de l'évaluation des SQL de phase 2, empêchait l'exécution réussie du SQL de phase 1 stocké, entraînant un taux de réussite plus faible en phase 2. Ce bug n'affecte que les tâches où le sql de phase 1 effectue des opérations sur la base de données, par exemple CREATE table, etc.

## 🧸 Aperçu

BIRD-INTERACT, un benchmark interactif text-to-SQL, **réinvente l'évaluation Text-to-SQL à travers le prisme des interactions dynamiques**.
L'environnement combine une base de connaissances hiérarchique, la documentation de base de données et un simulateur d'utilisateur orienté fonctions pour recréer des environnements d'entreprise authentiques à travers toutes les opérations **CRUD**.
Il propose deux modes de test rigoureux : (1) **Interaction Conversationnelle** passive et (2) **Interaction Agentique** active, couvrant 600 tâches annotées incluant Business Intelligence (BI), opérations CRUD, etc., chacune accompagnée de cas de test exécutables.
Les évaluations typiques génèrent 1 968 à 5 496 tours d'interaction entre le modèle et le simulateur utilisateur, tandis que les modèles de raisonnement les plus avancés ne résolvent actuellement que **≈24 %** et **≈18 %** des tâches, soulignant le défi du benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Deux modes d'évaluation

BIRD-INTERACT prend en charge deux modes d'évaluation comme mentionné ci-dessus :

   - **c-Interact** : Interaction conversationnelle qui est un mode passif et le flux de travail est fixe. Le code et les informations détaillées sont disponibles dans `bird_interact_conv`.
   - **a-Interact** : Interaction agentique, un mode actif incarné où le flux de travail est dynamique et guidé par les modèles. Le code et les informations détaillées sont disponibles dans `bird_interact_agent`.


### 🐣 Version Lite

Nous publions une version allégée de BIRD-INTERACT, `bird-interact-lite-exp`, qui inclut 270 tâches réelles de haute qualité spécialement pour PostgreSQL. C'est un bon point de départ pour une expérimentation rapide. 

### 🦜 Version Complète

La version complète de BIRD-INTERACT, `bird-interact-full`, est un benchmark complet qui inclut 600 tâches pour PostgreSQL. Elle couvre un large éventail d'opérations SQL et de requêtes utilisateur. La version complète arrive bientôt.

### Résultats de performance des modèles sur BIRD-INTERACT-FULL

#### 1. **Performance c-Interact Text-to-SQL**
| Rang | Nom du modèle      | Récompense normalisée | Coût moyen (USD)/Tâche | Niveau              |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 Chat excellent  |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 Chat excellent  |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 Chat bon        |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 Chat bon        |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ Standard        |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ Standard        |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ Basique         |

#### 2. **a-Interact Text-to-SQL** Performance
| Rank | Nom du modèle      | Récompense normalisée | Coût moyen (USD)/Tâche | Niveau                    |
|:----:|:-------------------|:----------------------:|:-----------------------:|:--------------------------:|
| 1    | GPT-5              | 25.52                  | $0.24                   | 🏆 Interaction excellente  |
| 2    | Claude-Sonnet-4    | 23.28                  | $0.51                   | 🏆 Interaction excellente  |
| 3    | Claude-Sonnet-3.7  | 17.45                  | $0.60                   | 💎 Interaction bonne       |
| 4    | Gemini-2.5-Pro     | 17.33                  | $0.22                   | 💎 Interaction bonne       |
| 5    | O3-Mini            | 16.43                  | $0.06                   | ✨ Standard                |
| 6    | Deepseek-Chat-V3.1 | 13.47                  | $0.06                   | ✨ Standard                |
| 7    | Qwen-3-Coder-480B  | 10.58                  | $0.07                   | ⚪ Basique                 |

> \* Paramètres de budget : Budget initial/Budget de patience utilisateur, mesuré par notre monnaie virtuelle *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Consultez [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) pour plus de détails.

### Échelonnage du temps d'interaction (ITS)

L’échelonnage du temps d’interaction (ITS) désigne la capacité d’un modèle à augmenter continuellement sa performance finale lors d’interactions multi-tours. Lorsque cette performance interactive dépasse la performance idéalisée du modèle sur une tâche entièrement spécifiée et non ambiguë en un seul tour, on dit qu’il satisfait la **loi ITS**. À mesure que la patience de l’utilisateur augmente et que les tours d’interaction s’accumulent, la performance continue de s’améliorer, démontrant que le modèle peut maintenir une communication efficace sur un dialogue prolongé. Actuellement, nous ne trouvons que claude-3-7-sonnet qui satisfait la loi ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Configuration de l’environnement

1. Exécutez les conteneurs Docker pour la base de données bird-interact-lite, la base de données bird-interact-full et l’environnement d’évaluation :
  
  > Si vous souhaitez simplement évaluer sur `bird-interact-lite`, vous pouvez commenter le service [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) dans `docker-compose.yml` pour accélérer la configuration de l’environnement.
  
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
- **data :** Chaque instance de données contient les éléments principaux suivants :
   - `selected_database` : Le nom de la base de données.  
   - `query` : La requête utilisateur non ambiguë.  
   - `amb_user_query` : La requête utilisateur avec des ambiguïtés injectées.
   - `user_query_ambiguity` : Les ambiguïtés injectées dans la requête utilisateur.
   - `non_critical_ambiguity` : Les ambiguïtés non critiques comme l’ordre, la limite, etc.
   - `knowledge_ambiguity` : Les ambiguïtés créées par des connaissances externes masquées. 
   - `sol_sql` : La solution SQL de référence.  
   - `preprocess_sql` : Les requêtes SQL à exécuter avant d’exécuter la solution ou la prédiction.  
   - `clean_up_sql` : Les requêtes SQL à exécuter après les cas de test pour annuler les modifications apportées à la base de données.  
   - `test_cases` : Un ensemble de cas de test pour valider le SQL corrigé prédit.
   - `follow_up` : Les questions de suivi annotées.
   - `external_knowledge` : Les connaissances externes liées à la tâche spécifique.

- **evaluation :** Le code d’évaluation est disponible dans le répertoire [`./evaluation`](./evaluation).
- **Préparé par :** Équipe BIRD & Google Cloud
- **Licence :** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Fiche de jeu de données HuggingFace :** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  et [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
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
Les détails concernant l’exécution de **a-interact** se trouvent dans `./bird_interact_agent/README.md` ; et pour **c-interact**, voir `./bird_interact_conv/README.md`.

## 📋 Listes de tâches

- [x] Publication de la version légère, bird-interact-lite (270).
- [x] Publication de la version conversationnelle, bird-interact-conv.
- [x] Publication de la version agent, bird-interact-agent.
- [x] Publication de la version complète bird-interact-full (600).
- [ ] SFT / RL d’un simulateur d’utilisateur

## Remerciements
Nous tenons à exprimer notre sincère gratitude à **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi** et au Professeur **Shinji Watanabe** pour leurs discussions fructueuses et leurs précieuses idées qui ont permis d'améliorer ce projet.

## Créé par :
Équipe BIRD & Google Cloud








## Journal des modifications

- [2025-11-06] 🐛 **Correction de bug** & 🐳 **Mise à jour Docker** : Mise à jour de la version de sqlglot vers 26.16.4 pour corriger le bug empêchant l’analyse correcte des SQL pour le simulateur d’utilisateur. Vous pouvez corriger ce problème en réinstallant via `pip install sqlglot==26.16.4` dans l’env `bird_interact_eval`. L’image `bird_interact_eval` a également été mise à jour, vous pouvez donc aussi la tirer et recréer le conteneur `bird_interact_eval`.
- [2025-10-21] 🐳 **Mise à jour Docker** : Ajout du docker pour l’environnement Full DB. Nous avons poussé 3 images docker (Base/Full DB Env et l’environnement d’évaluation pour `a-Interact` et `c-Interact`) sur Docker Hub pour faciliter l’installation. Plus besoin de télécharger les dumps DB et de construire les images manuellement ! Veuillez tirer les images les plus récentes depuis Docker Hub et recréer les conteneurs, par exemple avec `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Correction de bug** : Correction du bug qui, lors de l’évaluation SQL phase-2, empêchait l’exécution correcte du SQL phase-1 stocké, menant à un taux de réussite plus faible en phase-2. Ce bug ne concerne que les tâches où la phase 1 SQL effectue des opérations sur la base de données, par ex. CREATE table, etc.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---