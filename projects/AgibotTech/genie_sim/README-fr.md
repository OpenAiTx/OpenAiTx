![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim Benchmark
Genie Sim est le cadre de simulation développé par AgiBot, qui offre aux développeurs des capacités efficaces de génération de données et des benchmarks d’évaluation afin d’accélérer le développement de l’intelligence incarnée. Genie Sim a établi une chaîne complète en boucle fermée, englobant la génération de trajectoires, l’entraînement de modèles, le benchmarking et la validation du déploiement. Les utilisateurs peuvent rapidement valider les performances des algorithmes et optimiser les modèles via cette chaîne d’outils de simulation efficace. Que ce soit pour des tâches de préhension simples ou des opérations complexes à longue portée, Genie Sim offre un environnement de simulation hautement réaliste et des métriques d’évaluation précises, permettant aux développeurs de mener efficacement le développement et l’itération des technologies robotiques.

Genie Sim Benchmark, en tant que version d’évaluation open source de Genie Sim, est dédié à fournir des tests de performance précis et un support d’optimisation pour les modèles d’IA incarnée.

# 2. Fonctionnalités
- Configuration de simulation flexible et conviviale, interface intuitive
- Benchmarks de simulation et tâches d’évaluation pour plus de 10 tâches de manipulation
- Capacité de téléopération basée sur la VR et le clavier
- Enregistrement et relecture de toutes les articulations et de la pose de l’effecteur final
- Plus de 550 environnements et ressources 3D de haute fidélité et précision physique
- Métriques d’évaluation standardisées pour quantifier la performance des modèles d’IA incarnée
- Résultats d’évaluation atteignant moins de 5% d’erreur sim to real sur le modèle GO-1
- Prise en charge du modèle de référence UniVLA pour l’évaluation en simulation

# 3. Mises à jour
- [25/06/2025] v2.1
  - Ajout de 10 tâches de manipulation supplémentaires pour Agibot World Challenge 2025, incluant toutes les ressources de simulation
  - Open source des jeux de données synthétiques pour 10 tâches de manipulation sur Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - Intégration de la politique UniVLA et prise en charge de l’inférence de modèles pour l’évaluation en simulation
  - Mise à jour du SDK du solveur IK, qui prend en charge la résolution IK multi-embodiment pour d’autres robots
  - Optimisation du cadre de communication et amélioration de la vitesse de simulation par 2x
  - Mise à jour du cadre d’évaluation automatique pour des tâches longues et plus complexes

# 4. Contenu

## 4.1 Introduction
Les benchmarks de simulation de l’intelligence incarnée dans Genie Sim sont conçus pour évaluer et faire progresser le développement des modèles d’IA incarnée. Ces benchmarks offrent des environnements réalistes, des tâches variées et des métriques standardisées pour mesurer la performance des systèmes robotiques d’IA, réduisant le besoin de matériel physique coûteux et de tests en conditions réelles, évitant des scénarios de test risqués et accélérant le processus d’entraînement et d’évaluation des agents IA.

## 4.2 Démarrage rapide
Veuillez vous référer à [cette page](https://agibot-world.com/sim-evaluation/docs/#/v2) pour l’installation, le guide utilisateur et la référence API

## 4.3 Support
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 Liste TODO
- [x] Publier plus de tâches de manipulation à long horizon
- [x] Plus de scènes et de ressources pour chaque tâche de benchmark
- [x] Prise en charge du modèle de référence Agibot World Challenge
- [ ] Boîte à outils de généralisation de la disposition de scénarios et des trajectoires de manipulation

## 4.5 FAQ
- Comment arrêter le serveur isaac sim lorsqu’une erreur survient et que le processus ne répond plus ?
  Tuez le processus dans le terminal avec `pkill -9 -f raise_standalone_sim`
- Comment choisir différents modes de rendu ?
  Le mode de rendu par défaut est `RaytracedLighting(RealTime)`. Pour les tâches contenant des objets transparents, utilisez `RealTimePathTracing(RealTime-2.0)` pour la relation de perspective des objets

## 4.6 Licence et citation
Toutes les données et le code de ce dépôt sont sous licence Mozilla Public License 2.0
Merci de citer notre travail selon l’une des méthodes ci-dessous si cela aide votre recherche.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 Références
1. PDDL Parser (2020). Version 1.1. [Code source]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Version 1.x.x [Code source]. https://github.com/StanfordVL/bddl
3. CUROBO [Code source]. https://github.com/NVlabs/curobo
4. Isaac Lab [Code source]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Code source]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---