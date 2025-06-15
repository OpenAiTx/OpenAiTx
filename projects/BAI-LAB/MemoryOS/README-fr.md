# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 Si vous aimez notre projet, merci de lui attribuer une étoile ⭐ sur GitHub pour suivre les dernières mises à jour.</h5>
**MemoryOS** est conçu pour fournir un système d’exploitation mémoire pour les agents IA personnalisés, permettant des interactions plus cohérentes, personnalisées et sensibles au contexte. S’inspirant des principes de gestion de la mémoire des systèmes d’exploitation, il adopte une architecture de stockage hiérarchique avec quatre modules principaux : Stockage, Mise à jour, Récupération et Génération, afin de réaliser une gestion de la mémoire complète et efficace. Sur le benchmark LoCoMo, le modèle a atteint une amélioration moyenne de **49,11%** et **46,18%** sur les scores F1 et BLEU-1.







## 📣 Dernières nouvelles
*   *<mark>[nouveau]</mark>* 🔥  **[2025-06-15]** :🛠️ L’open source **MemoryOS-MCP** est disponible ! Désormais configurable sur les clients agents pour une intégration et une personnalisation sans couture. [👉 Voir](#memoryos_mcp-getting-started)
*   **[2025-05-30]** : Version initiale de **MemoryOS** lancée ! Inclut la mémoire de persona à court, moyen et long terme avec mise à jour automatisée du profil utilisateur et des connaissances.

## Démo
[![Voir la vidéo](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	Architecture du système
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## Structure du projet

```
memoryos/
├── __init__.py            # Initialise le package MemoryOS
├── __pycache__/           # Répertoire de cache Python (généré automatiquement)
├── long_term.py           # Gère la mémoire persona à long terme (profil utilisateur, connaissances)
├── memoryos.py            # Classe principale pour MemoryOS, orchestre tous les composants
├── mid_term.py            # Gère la mémoire à moyen terme, consolide les interactions à court terme
├── prompts.py             # Contient les prompts utilisés pour les interactions LLM (ex : résumé, analyse)
├── retriever.py           # Récupère les informations pertinentes de tous les niveaux de mémoire
├── short_term.py          # Gère la mémoire à court terme pour les interactions récentes
├── updater.py             # Traite les mises à jour mémoire, y compris la promotion d’informations entre les niveaux
└── utils.py               # Fonctions utilitaires utilisées dans toute la bibliothèque
```

## Fonctionnement

1.  **Initialisation :** `Memoryos` est initialisé avec les identifiants utilisateur et assistant, les clés API, les chemins de stockage des données, ainsi que divers paramètres de capacité/ seuil. Il configure un espace de stockage dédié pour chaque utilisateur et assistant.
2.  **Ajout de souvenirs :** Les entrées utilisateur et les réponses de l’agent sont ajoutées sous forme de paires QA. Elles sont initialement stockées dans la mémoire à court terme.
3.  **Traitement court terme → moyen terme :** Lorsque la mémoire à court terme est pleine, le module `Updater` traite ces interactions, les consolide en segments significatifs et les stocke dans la mémoire à moyen terme.
4.  **Analyse moyen terme & mises à jour LPM :** Les segments de mémoire à moyen terme accumulent de la « chaleur » en fonction de facteurs comme la fréquence de visite et la longueur d’interaction. Lorsqu’un segment dépasse un seuil de chaleur, son contenu est analysé :
    *   Des informations de profil utilisateur sont extraites et utilisées pour mettre à jour le profil utilisateur à long terme.
    *   Des faits spécifiques sur l’utilisateur sont ajoutés à ses connaissances à long terme.
    *   Les informations pertinentes pour l’assistant sont ajoutées à la base de connaissances à long terme de l’assistant.
5.  **Génération de réponse :** Lorsqu’une requête utilisateur est reçue :
    *   Le module `Retriever` récupère le contexte pertinent de l’historique à court terme, des segments à moyen terme, du profil & des connaissances de l’utilisateur, et de la base de connaissances de l’assistant.
    *   Ce contexte complet est ensuite utilisé, avec la requête de l’utilisateur, pour générer une réponse cohérente et informée via un LLM.

## Démarrage MemoryOS_PYPI

### Prérequis

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### Installation

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### Utilisation de base

```python

import os
from memoryos import Memoryos

# --- Configuration de base ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # Remplacez par votre clé
BASE_URL = ""  # Optionnel : si vous utilisez un endpoint OpenAI personnalisé
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Démo Simple")
    
    # 1. Initialiser MemoryOS
    print("Initialisation de MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS initialisé avec succès !\n")
    except Exception as e:
        print(f"Erreur : {e}")
        return

    # 2. Ajouter quelques souvenirs de base
    print("Ajout de quelques souvenirs...")
    
    memo.add_memory(
        user_input="Salut ! Je suis Tom, je travaille comme data scientist à San Francisco.",
        agent_response="Bonjour Tom ! Ravi de vous rencontrer. La data science est un domaine passionnant. Avec quel type de données travaillez-vous ?"
    )
     
    test_query = "Que te rappelles-tu de mon métier ?"
    print(f"Utilisateur : {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Assistant : {response}")

if __name__ == "__main__":
    simple_demo()
```
## Démarrage MemoryOS-MCP
### 🔧 Outils principaux

#### 1. `add_memory`
Enregistre le contenu de la conversation entre l’utilisateur et l’assistant IA dans le système mémoire, afin de construire un historique de dialogue persistant et un enregistrement contextuel.

#### 2. `retrieve_memory`
Récupère les dialogues historiques pertinents, les préférences utilisateur et les informations de connaissances depuis le système mémoire en fonction d’une requête, aidant l’assistant IA à comprendre les besoins et le contexte de l’utilisateur.

#### 3. `get_user_profile`
Obtient un profil utilisateur généré à partir de l’analyse des dialogues historiques, y compris les traits de personnalité, les préférences d’intérêt et le contexte de connaissances pertinent.


### 1. Installer les dépendances
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. Configuration

Éditez `config.json`：
```json
{
  "user_id": "votre ID utilisateur",
  "openai_api_key": "votre clé API OpenAI",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. Démarrer le serveur
```bash
python server_new.py --config config.json
```
### 4. Tester
```bash
python test_comprehensive.py
```
### 5. Configurez-le sur Cline et d'autres clients
Copiez le fichier mcp.json et assurez-vous que le chemin du fichier est correct.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
# Ceci doit être modifié vers l’interpréteur Python de votre environnement virtuel
```
## Contribution

Les contributions sont les bienvenues ! N’hésitez pas à soumettre des issues ou des pull requests.

## Citation
Si vous souhaitez lire plus de détails, cliquez ici : [Lire l’article complet](https://arxiv.org/abs/2506.06326)

Si ce projet vous est utile, merci de citer notre article :

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## Contactez-nous
百家AI est un groupe de recherche dirigé par la professeure associée Bai Ting de l'Université des Postes et Télécommunications de Pékin, dédié à la création d'un cerveau doté d'émotions riches et d'une mémoire exceptionnelle pour l'humanité au silicium.<br>
Coopération et suggestions : baiting@bupt.edu.cn<br>
Nous vous invitons à suivre le compte public 百家Agent sur WeChat ainsi que notre groupe WeChat pour échanger ensemble !  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="Compte public 百家Agent" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="QR code du groupe WeChat" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---