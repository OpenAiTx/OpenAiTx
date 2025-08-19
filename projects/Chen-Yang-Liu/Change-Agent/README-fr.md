<div align="center">
    
<h1><a href="https://ieeexplore.ieee.org/document/10591792">Change-Agent : Vers une interprétation et une analyse interactives et complètes des changements en télédétection</a></h1>

**[Chenyang Liu](https://chen-yang-liu.github.io/), [Keyan Chen](https://kyanchen.github.io), [Haotian Zhang](https://scholar.google.com/citations?user=c7uR6NUAAAAJ), [Zipeng Qi](https://scholar.google.com/citations?user=KhMtmBsAAAAJ), [Zhengxia Zou](https://scholar.google.com.hk/citations?hl=en&user=DzwoyZsAAAAJ), et [Zhenwei Shi*✉](https://scholar.google.com.hk/citations?hl=en&user=kNhFWQIAAAAJ)**

<div align="center">
  <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/Change_Agent.png" width="400"/>
</div>
</div>

## Mettez-nous une :star: si ce dépôt vous intéresse

Implémentation officielle PyTorch de l’article : "**Change-Agent : Vers une interprétation et une analyse interactives et complètes des changements en télédétection**" dans [[IEEE](https://ieeexplore.ieee.org/document/10591792)]  ***(Accepté par IEEE TGRS 2024)***

## 🥳Nouvelles

- 2024-06 : Le code est **disponible**.
- 2024-03 : L’article est **disponible**.
- 🔥 Notre enquête "**Modèles vision-langage temporels en télédétection : une enquête complète" : [Arxiv](https://arxiv.org/abs/2412.02573) || [Github](https://github.com/Chen-Yang-Liu/Awesome-RS-Temporal-VLM)** 🔥 

## Table des matières
- [Jeu de données LEVIR-MCI](#LEVIR-MCI-dataset)
- [Entraînement du modèle MCI](#Training-of-the-multi-level-change-interpretation-model)
- [Construction de Change-Agent](#Construction-of-Change-Agent)
- [Citation](#Citation)

## Jeu de données LEVIR-MCI 
- Téléchargez le jeu de données LEVIR_MCI : [LEVIR-MCI](https://huggingface.co/datasets/lcybuaa/LEVIR-MCI/tree/main) (**Disponible maintenant !**).
- Ce jeu de données est une extension de notre précédent [jeu LEVIR-CC](https://github.com/Chen-Yang-Liu/RSICC). Il contient des images bi-temporelles ainsi que des masques de détection de changements divers et des phrases descriptives. Il fournit une base de données essentielle pour explorer l’apprentissage multitâche pour la détection et la description des changements.
    <br>
    <div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/dataset.png" width="800"/>
    </div>
    <br>
## Entraînement du modèle d’interprétation multi-niveaux des changements
Vue d’ensemble du modèle MCI :
<br>
    <div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/MCI_model.png" width="800"/>
    </div>
<br>

### Préparation
    
- **Installation de l'environnement** :
    <details open>
    
    **Étape 1** : Créez un environnement virtuel nommé `Multi_change_env` et activez-le.
    ```python
    conda create -n Multi_change_env python=3.9
    conda activate Multi_change_env
    ```
    
    **Étape 2** : Téléchargez ou clonez le dépôt.
    ```python
    git clone https://github.com/Chen-Yang-Liu/Change-Agent.git
    cd ./Change-Agent/Multi_change
    ```
    
    **Étape 3** : Installer les dépendances.
    ```python
    pip install -r requirements.txt
    ```
    </details>

- **Télécharger le jeu de données** :
  <details open>
      
  Lien : [LEVIR-MCI](https://huggingface.co/datasets/lcybuaa/LEVIR-MCI/tree/main). La structure des données de LEVIR-MCI est organisée comme suit :

    ```
    ├─/DATA_PATH_ROOT/Levir-MCI-dataset/
            ├─LevirCCcaptions.json
            ├─images
                 ├─train
                 │  ├─A
                 │  ├─B
                 │  ├─label
                 ├─val
                 │  ├─A
                 │  ├─B
                 │  ├─label
                 ├─test
                 │  ├─A
                 │  ├─B
                 │  ├─label
    ```
    où le dossier ``A`` contient les images pré-phase, le dossier ``B`` contient les images post-phase, et le dossier ``label`` contient les masques de détection de changement.
    </details>

- **Extraire les fichiers texte pour les descriptions de chaque paire d’images dans LEVIR-MCI** :

    ```
    python preprocess_data.py
    ```
    Après cela, vous pouvez trouver certains fichiers générés dans `./data/LEVIR_MCI/`. 

### Entraînement
Assurez-vous d'avoir effectué la préparation des données ci-dessus. Ensuite, lancez l'entraînement comme suit :
```python
python train.py --train_goal 2 --data_folder /DATA_PATH_ROOT/Levir-MCI-dataset/images --savepath ./models_ckpt/
```

### Évaluer
```python
python test.py --data_folder /DATA_PATH_ROOT/Levir-MCI-dataset/images --checkpoint {checkpoint_PATH}
```
Nous recommandons d'entraîner le modèle 5 fois pour obtenir un score moyen.

### Inférence
Lancez l'inférence pour commencer comme suit :
```python
python predict.py --imgA_path {imgA_path} --imgB_path {imgA_path} --mask_save_path ./CDmask.png
```
Vous pouvez modifier ``--checkpoint`` de ``Change_Perception.define_args()`` dans ``predict.py``. Ensuite, vous pouvez utiliser votre propre modèle, bien sûr, vous pouvez également télécharger notre modèle pré-entraîné ``MCI_model.pth`` ici : [[Hugging face](https://huggingface.co/lcybuaa/Change-Agent/tree/main)]. Après cela, placez-le dans `./models_ckpt/`.



## Construction de Change-Agent
<br>
<div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/overview_agent.png" width="800"/>
</div>

- **Installation de l'Agent** :
    ```python
    cd ./Change-Agent/lagent-main
    pip install -e .[all]
    ```
- **Exécuter l'Agent** :

    se placer dans le dossier ``Multi_change`` :
    ```python
    cd ./Change-Agent/Multi_change
    ```
    (1) Exécuter la démo de l'Agent CLI :
    ```bash
    # You need to install streamlit first
    # pip install streamlit
    python try_chat.py
    ```
        
    (2) Exécuter la démonstration Web de l'Agent :
    ```bash
    # You need to install streamlit first
    # pip install streamlit
    streamlit run react_web_demo.py
    ```
    <br>
    <div align="center">
          <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/web.png"/>
    </div>

## Citation
Si vous trouvez cet article utile dans vos recherches, veuillez envisager de le citer :
```
@ARTICLE{Liu_Change_Agent,
  author={Liu, Chenyang and Chen, Keyan and Zhang, Haotian and Qi, Zipeng and Zou, Zhengxia and Shi, Zhenwei},
  journal={IEEE Transactions on Geoscience and Remote Sensing}, 
  title={Change-Agent: Toward Interactive Comprehensive Remote Sensing Change Interpretation and Analysis}, 
  year={2024},
  volume={},
  number={},
  pages={1-1},
  keywords={Remote sensing;Feature extraction;Semantics;Transformers;Roads;Earth;Task analysis;Interactive Change-Agent;change captioning;change detection;multi-task learning;large language model},
  doi={10.1109/TGRS.2024.3425815}}

```

## Remerciements
Merci aux dépôts suivants :

[RSICCformer](https://github.com/Chen-Yang-Liu/RSICC); [Chg2Cap](https://github.com/ShizhenChang/Chg2Cap); [lagent](https://github.com/InternLM/lagent)

## Licence
Ce dépôt est distribué sous la [Licence MIT](https://github.com/Chen-Yang-Liu/Change-Agent/blob/main/LICENSE.txt). Le code peut être utilisé uniquement à des fins académiques.

## Contactez-nous
Si vous avez d'autres questions❓, veuillez nous contacter rapidement 👬


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---