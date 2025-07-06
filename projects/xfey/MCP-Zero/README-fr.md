## MCP-Zero : Découverte Active d’Outils pour Agents LLM Autonomes

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


Merci de l’attention portée à MCP-Zero ! 🤗

Nous avons maintenant publié en open-source le code utilisé dans l’article. Nous continuerons à mettre à jour notre travail, à explorer son application dans l’industrie et à élargir ce projet.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> Utilisation de MCP-Zero pour construire de manière proactive des chaînes d’outils pour « Préparer un excellent repas »</p>
</div>


### Méthode : MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # expériences : APIBank
├── experiment_mcptools.py      # expériences : mcp_tools (needle test)
├── matcher.py                  # code pour l’appariement par similarité
├── prompt_guide/               # prompts pour notre méthode
├── reformatter.py              # formateur json pour la description des outils
├── sampler.py                  # échantillonneur pour la sélection de l’outil cible
├── test_cases.jsonl            # cas de test pour le matcher
├── test_matcher.py             # test unitaire pour le matcher
└── utils.py                    # utilitaires : grid_search
```

Nous avons publié le code de l’article. Le code implémente les capacités de récupération et obtient des résultats concrets lors des expériences.

Dans nos travaux futurs, nous nous engageons à appliquer MCP-zero à l’industrie, donc d’autres modules doivent encore être intégrés, tels que le déploiement dynamique des serveurs MCP, le déploiement d’environnement pour le test GAIA, etc. Nous continuerons à améliorer notre travail, et nous vous remercions tous pour votre attention. Laissez une étoile🌟 pour me dire que vous restez informé·e :D



### Jeu de données : MCP-tools

- **Google Drive** : [Lien de téléchargement](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Lien Huggingface** : Bientôt disponible
- **Placez le fichier dans** : `./MCP-tools/mcp_tools_with_embedding.json`


**Présentation** : Un jeu de données contenant tous les outils filtrés (308 serveurs et 2 797 outils au total) issus du dépôt officiel MCP.

**Structure des données** :
```
{
  "server_name": string, // Le nom du serveur MCP, extrait ou déduit du README
  "server_summary": string, // Un résumé du but et des capacités du serveur, basé sur toutes les parties pertinentes du README.
  "server_description": string, // Description issue des métadonnées. 
  "description_embedding": float[3072], // L’embedding de la description du serveur depuis text-embedding-3-large
  "summary_embedding": float[3072], // L’embedding du résumé du serveur depuis text-embedding-3-large
  "tools": [
    {
      "name": string, // Le nom de la fonction/outil
      "description": string, // Une brève description de ce que fait l’outil
      "description_embedding": float[3072], // L’embedding de la description de l’outil depuis text-embedding-3-large
      "parameter": { // Un dictionnaire des paramètres d’entrée, inclus si explicitement définis
        "param1": "(type) description1",
        "param2": "(Optionnel, type) description2"
      }
    }
  ]
}
```

**Construire le jeu de données vous-même** : Si vous souhaitez créer un jeu de données personnalisé pour les serveurs MCP, vous pouvez suivre le code dans le dossier `MCP-tools/build_data`.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # code pour extraire les données structurées du fichier ReadMe du serveur MCP
│   ├── run_vllm.sh                 # déployer le modèle Qwen2.5-72B-Instruct avec VLLM
│   └── server_summary.prompt       # le prompt pour extraire le jeu de données
└── download_data.md
```


### Citation

> La citation me rend heureux.
> 
>   --Shakespeare
>   ~~(juste pour le fun :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang et Zheng, Xiawu et Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---