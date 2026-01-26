## PSICHIC : réseau de neurones graphes physico-chimiques pour l’apprentissage des empreintes d’interaction protéine-ligand à partir de données de séquence [[Nature Machine Intelligence](https://www.nature.com/articles/s42256-024-00847-1)]

<img src="https://raw.githubusercontent.com/huankoh/PSICHIC/main/image/PSICHIC.jpg" width="500"/>

## Serveur Web PSICHIC <a href="http://www.psichicserver.com" target="_blank"><img src="https://raw.githubusercontent.com/huankoh/PSICHIC/main/image/crystal_ball.png" alt="Serveur Web PSICHIC" width="30"/></a>

Bonne nouvelle❗ Le serveur web PSICHIC (version bêta) est maintenant disponible ! 🚀 Découvrez l’avenir de l’analyse des interactions protéine-ligand sur [www.psichicserver.com](https://www.psichicserver.com/)

_Commencez à explorer. Votre prochaine découverte_ 🌐🔬 _pourrait être à quelques clics seulement !_

<sub>Note : Ce serveur n’est pas officiellement associé à l’article. Pour la version officielle, vous pouvez consulter le Colab et la configuration de déploiement local ci-dessous.</sub>

## Plateforme de criblage virtuel PSICHIC <a href="https://colab.research.google.com/github/huankoh/PSICHIC/blob/main/PSICHIC.ipynb" target="_parent"><img src="https://colab.research.google.com/assets/colab-badge.svg" alt="Ouvrir dans Colab"/></a>

- **Données de séquence uniquement** : seules les paires Séquence Protéine + SMILES ligand sont nécessaires.
- **Criblage rapide** : jusqu’à 100 000 composés en une heure.
- **Analyse approfondie** : révélez des informations moléculaires avec l’analyse pharmacophore et mutagenèse ciblée propulsée par PSICHIC.

**MISE À JOUR :** Nous avons inclus un notebook jupyter dans le sous-dossier sélectivité pour démontrer comment PSICHIC peut être utilisé pour le profilage de sélectivité.

## Configuration de l’environnement PSICHIC pour déploiement local
<details>
<summary>Cliquez pour afficher le contenu du développement local PSICHIC </summary>

Actuellement, PSICHIC est validé pour une utilisation sur MacOS (OSX), Linux et Windows. Nous recommandons l’installation via conda, ou mieux encore, en utilisant le gestionnaire de paquets et d’environnements plus rapide mamba. Mamba peut être installé avec la commande ``conda install mamba -n base -c conda-forge``. Pour la configuration utilisant conda ou mamba, veuillez vous référer à la ligne de code correspondante ci-dessous.


```
## OSX 
conda env create -f environment_osx.yml  # if mamba: mamba env create -f environment_osx.yml
## LINUX or Windows GPU
conda env create -f environment_gpu.yml # if mamba: mamba env create -f environment_gpu.yml
conda activate psichic_fp
pip install torch_scatter torch_sparse torch_cluster torch_spline_conv -f https://data.pyg.org/whl/torch-2.1.0+cu118.html
## LINUX or Windows CPU
conda env create -f environment_cpu.yml  # if mamba: mamba env create -f environment_cpu.yml
conda activate psichic_fp
pip install torch_scatter torch_sparse torch_cluster torch_spline_conv -f https://data.pyg.org/whl/torch-2.1.0+cpu.html
```

Alternativement, des lignes de commande qui peuvent être utiles pour configurer l'environnement (testées sous Linux avec Python 3.8). 
```
conda create --name psichic_fp python=3.8
conda install pytorch==2.0.0 torchvision==0.15.0 torchaudio==2.0.0 pytorch-cuda=11.7 -c pytorch -c nvidia
conda install pyg -c pyg
conda install -c conda-forge rdkit==2022.09.5
pip install scipy biopython pandas biopandas timeout_decorator py3Dmol umap-learn plotly mplcursors lifelines reprint
pip install "fair-esm"
```
## BYO-PSICHIC avec données de séquence annotées

Créez un fichier csv train, valid et test dans un dossier de données (pour des exemples, voir le dossier dataset). Le dossier de données doit contenir au moins un fichier train.csv et test.csv. Selon vos étiquettes annotées, vous souhaitez utiliser ``--regression_task True`` s’il s’agit d’une étiquette de valeur continue (par exemple, affinité de liaison), ``--classification_task True`` s’il s’agit d’une étiquette de classe binaire (par exemple, présence d’interaction) et ``--mclassification_task C`` où C représente le nombre de classes dans vos étiquettes multiclasses (par exemple, 3 si vous utilisez notre jeu de données de réponse fonctionnelle protéine-ligand). Notez que vous pouvez avoir un jeu de données avec plusieurs types d’étiquettes et nous entraînerons PSICHIC à prédire plusieurs propriétés d’interaction protéine-ligand (voir PSICHIC-MultiTask ci-dessous)


```
python main.py --datafolder annotated_folder --result_path result/annotated_result --regression_task True 
```

BYO-PSICHIC utilisant un ensemble de données de référence, par exemple, le benchmark PDBBind v2020 :
```
python main.py --datafolder dataset/pdb2020 --result_path result/PDB2020_BENCHMARK --regression_task True 
```
Les configurations du modèle et de l'optimiseur sont cohérentes pour tous les ensembles de données de référence, sauf pour PDBBind v2016 où vous souhaitez modifier le nombre d'itérations d'entraînement de l'optimiseur, les betas et eps respectivement à 30000, "(0.9,0.99)" et 1e-5, c’est-à-dire ajouter à la ligne de commande : ``--total_iters 30000 --betas "(0.9,0.99)" --eps 1e-5``. Pour une tâche de classification binaire, remplacez ``--regression_task True`` par ``--classification_task True``. Pour l’ensemble de données d’effet fonctionnel des protéines, remplacez ``--regression_task True`` par ``--mclassification_task 3``. N’hésitez pas à ajuster les hyperparamètres du modèle dans le fichier config.json, faites-nous savoir si vous trouvez des résultats intéressants !


## Structure des ensembles de données et directives de formatage BYO
Tous les ensembles de données référencés dans notre manuscrit sont disponibles sur Google Drive ([Dataset](https://drive.google.com/drive/folders/1ZRpnwXtllCP89hjhfDuPivBlarBIXnmu?usp=sharing)). Pour les ensembles de données utilisés dans l’évaluation comparative de PSICHIC, nous avons des fichiers CSV train, valid et test qui ont été créés selon des paramètres de découpage établis. Un fichier README.md séparé dans la section des ensembles de données est dédié à expliquer le but de chaque ensemble de données dans le lien Google Drive (c’est similaire au tableau étendu 1 dans notre manuscrit).

Ensemble de données BYO-PSICHIC : Chaque fichier devrait ressembler à ceci si vous souhaitez entraîner BYO-PSICHIC. Un fichier CSV de validation n’est pas requis si vous n’en avez pas, par exemple si vous prévoyez d’appliquer les résultats dans des expériences externes.

__Régression de l’affinité de liaison__

| Protéine | Ligand | regression_label | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 6.7 | 
| GGALVSVISAFQASV....  | O=C(C)Oc1ccccc1C(=O)O | 4.0 |
|...|...| ...|
| MIPSAYIGIEVLI... | CCO | 8.1 | 

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --regression_task True 
```

__Classification des interactions binaires__

| Protéine | Ligand | étiquette_de_classification | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 1 | 
| GGALVSVISAFQASV.... | O=C(C)Oc1ccccc1C(=O)O | 0 |
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 1 | 

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --classification_task True
```

__Classification de l'effet fonctionnel (Classification à trois voies)__

| Protéine | Ligand | multiclass_label | 
|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | -1 |  # antagoniste
| GGALVSVISAFQASV.... | O=C(C)Oc1ccccc1C(=O)O | 0 | # non-ligand
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 1 | # agoniste

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --mclassification_task 3
```

__Multi Task PSICHIC__

| Protéine | Ligand | étiquette_régression | étiquette_multiclasse | 
|:----------:|:----------:|:----------:|:----------:|
| ISAFQAAYIGIE....  | C1CCCCC1  | 6.7 | -1 |  # antagoniste
| GGALVSVISAFQASV....  | O=C(C)Oc1ccccc1C(=O)O | 4.0 | 0 | # non-ligand
|...|...| ...|
| MIPSAYIGIEVLI.... | CCO | 8.1 | 1 | # agoniste

```
python main.py --datafolder BYO_DATASET --result_path BYO_RESULT --regression_task True --mclassification_task 3
```

**Divisez stratégiquement votre ensemble de données ?** Le notebook Jupyter dans le dossier dataset est disponible pour illustrer comment nous effectuons des divisions aléatoires, des divisions par protéines non vues, et des divisions par échafaudages de ligands non vus afin d’évaluer la généralisabilité de PSICHIC ou d’autres méthodes. Cela peut être utile pour évaluer si BYO-PSICHIC fonctionne sur vos données de séquence annotées.
 
## PSICHIC<sub>XL</sub> : Entraînement de prédiction multitâche sur un ensemble de données d’interactions à grande échelle
Le PSICHIC<sub>XL</sub> était auparavant appelé PSICHIC multitâche pré-entraîné. Le PSICHIC<sub>A1R</sub> était auparavant appelé PSICHIC multitâche affiné. Nous avons changé le nom pour clarifier que PSICHIC<sub>XL</sub> peut être utilisé tel quel sans entraînement supplémentaire. Cependant, PSICHIC<sub>XL</sub> peut potentiellement améliorer ses capacités de classement en criblage virtuel lorsqu’il est affiné sur des données spécifiques à une cible protéique, par ex., le PSICHIC<sub>A<sub>1</sub>R</sub> que nous montrons ci-dessous en utilisant des données liées à A<sub>1</sub>R.

### Entraînement de PSICHIC<sub>XL</sub> (alias PSICHIC pré-entraîné dans le préprint)
```
python main.py --datafolder dataset/large_scale_interaction_dataset --result_path PSICHIC_MultiTask_Pretrain --lrate 1e-5 --sampling_col pretrain_sampling_weight --regression_task True --mclassification_task 3 --total_iters 300000 --evaluate_step 25000
```
### Affiner PSICHIC<sub>XL</sub> en PSICHIC<sub>A<sub>1</sub>R</sub> (Aussi appelé PSICHIC affiné dans le préprint)  
Nous affinons uniquement les couches d'application de PSICHIC<sub>XL</sub> pendant 1000 itérations sur la protéine liée à A<sub>1</sub>R en utilisant la commande suivante :
```
python main.py --regression_task True --mclassification_task 3 --datafolder dataset/A1R_FineTune --result_path PSICHIC_A1R_FineTune --lrate 1e-5 --total_iters 1000 --finetune_modules "['reg_out','mcls_out']" --trained_model_path trained_weights/multitask_PSICHIC
```
Nous avons renommé la version de PSICHIC entraînée sur le vaste jeu de données d’interactions en PSICHIC<sub>XL</sub>, et le sous-ensemble se concentrant sur les données A<sub>1</sub>R en PSICHIC<sub>A<sub>1</sub>R</sub>. Auparavant, PSICHIC<sub>XL</sub> et PSICHIC<sub>A<sub>1</sub>R</sub> étaient respectivement appelés PSICHIC pré-entraîné et PSICHIC affiné. Ce changement reflète plus précisément la large applicabilité de PSICHIC<sub>XL</sub> et l’accent spécifique de PSICHIC<sub>A<sub>1</sub>R</sub> sur A1R.

Pour toute autre protéine, vous pouvez filtrer les protéines non pertinentes et les non-ligands dans le grand jeu de données d’interactions afin d’appliquer PSICHIC pour d’autres expériences.
</details>



## Références

Pour plus d’informations, veuillez vous référer à notre travail : 

```
PSICHIC: physicochemical graph neural network for learning protein-ligand interaction fingerprints from sequence data
Huan Yee Koh, Anh T.N. Nguyen, Shirui Pan, Lauren T. May, Geoffrey I. Webb
bioRxiv 2023.09.17.558145; doi: https://doi.org/10.1101/2023.09.17.558145
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---