# PPTAgent : Génération et Évaluation de Présentations au-delà du Texte-vers-Diapositive
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">Article</a> &nbsp; | &nbsp;
  🤗 <a href="https://huggingface.co/datasets/Forceless/Zenodo10K" target="_blank">Jeu de données</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">Documentation</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">Citation</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="Ask DeepWiki"> DeepWiki</a>
</p>

Nous présentons PPTAgent, un système innovant qui génère automatiquement des présentations à partir de documents. S'inspirant des méthodes humaines de création de présentations, notre système utilise un processus en deux étapes pour garantir l'excellence de la qualité globale. De plus, nous introduisons **PPTEval**, un cadre d’évaluation complet qui analyse les présentations selon plusieurs dimensions.

> [!TIP]
> 🚀 Commencez rapidement avec notre image Docker préconstruite - [Voir les instructions Docker](DOC.md/#docker-)

## Vidéo Démo 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## Fonctionnalités Distinctives ✨

- **Génération Dynamique de Contenu** : Crée des diapositives avec texte et images intégrés de manière fluide
- **Apprentissage Intelligent des Références** : Exploite des présentations existantes sans nécessiter d’annotation manuelle
- **Évaluation Complète de la Qualité** : Évalue les présentations via plusieurs métriques de qualité

## Étude de Cas 💡

- #### [Iphone 16 Pro](https://www.apple.com/iphone-16-pro/)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0001.jpg" alt="Image1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0002.jpg" alt="Image2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0003.jpg" alt="Image3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0004.jpg" alt="Image4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0005.jpg" alt="Image5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0006.jpg" alt="Image6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0007.jpg" alt="Image7" width="200"/>

</div>

- #### [Construire des Agents Efficaces](https://www.anthropic.com/research/building-effective-agents)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0001.jpg" alt="Image1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0002.jpg" alt="Image2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0003.jpg" alt="Image3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0004.jpg" alt="Image4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0005.jpg" alt="Image5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0006.jpg" alt="Image6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0007.jpg" alt="Image7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0008.jpg" alt="Image8" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0009.jpg" alt="Image9" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0010.jpg" alt="Image10" width="200"/>

</div>

## PPTAgent 🤖

PPTAgent suit une approche en deux phases :
1. **Phase d’Analyse** : Extrait et apprend des modèles dans des présentations de référence
2. **Phase de Génération** : Développe des plans structurés et produit des diapositives visuellement cohérentes

Le flux de travail de notre système est illustré ci-dessous :


![Flux de travail PPTAgent](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig2.jpg)

## PPTEval ⚖️

PPTEval évalue les présentations selon trois dimensions :
- **Contenu** : Vérifie la précision et la pertinence des diapositives.
- **Conception** : Évalue l’attrait visuel et la cohérence.
- **Cohérence** : Assure le déroulement logique des idées.

Le flux de travail de PPTEval est présenté ci-dessous :
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="Flux de travail PPTEval" style="width:70%;"/>
</p>


## Citation 🙏

Si vous trouvez ce projet utile, veuillez utiliser la citation suivante :
```bibtex
@article{zheng2025pptagent,
  title={PPTAgent: Generating and Evaluating Presentations Beyond Text-to-Slides},
  author={Zheng, Hao and Guan, Xinyan and Kong, Hao and Zheng, Jia and Zhou, Weixiang and Lin, Hongyu and Lu, Yaojie and He, Ben and Han, Xianpei and Sun, Le},
  journal={arXiv preprint arXiv:2501.03936},
  year={2025}
}
```

[![Star History Chart](https://api.star-history.com/svg?repos=icip-cas/PPTAgent&type=Date)](https://star-history.com/#icip-cas/PPTAgent&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-31

---