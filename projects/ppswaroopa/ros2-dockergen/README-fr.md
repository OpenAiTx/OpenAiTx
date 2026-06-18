# 🤖 ros2-dockergen

<p align="center">
  <a href="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/ci.yml"><img src="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/ci.yml/badge.svg" alt="CI"></a>
  <a href="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/publish.yml"><img src="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/publish.yml/badge.svg" alt="Publier sur PyPI"></a>
  <a href="https://pypi.org/project/ros2-dockergen/"><img src="https://img.shields.io/pypi/v/ros2-dockergen.svg" alt="Version PyPI"></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="Licence : MIT"></a>
  <a href="https://www.python.org/downloads/"><img src="https://img.shields.io/badge/python-3.10+-blue.svg" alt="Python 3.10+"></a>
  <a href="https://ppswaroopa.github.io/ros2-dockergen/"><img src="https://img.shields.io/badge/Web-Interactive_UI-00ff88.svg" alt="Interface Web"></a>
</p>

<br />
<p align="center">
  <img src="https://raw.githubusercontent.com/ppswaroopa/ros2-dockergen/main/docs/hero.png" alt="Flux ROS2 DockerGen" width="100%">
</p>
<br />

> **Une commande. Interactive. Sans tracas.**  
> Générez un `Dockerfile` prêt pour la production + `docker-compose.yml` + `README.md` pour n'importe quel projet ROS2 — directement depuis votre terminal ou sur la [page web](https://ppswaroopa.github.io/ros2-dockergen/) ici

---

## Installation rapide

### Depuis PyPI (Recommandé)
```bash
pip install ros2-dockergen
```

### Installateur en une ligne (Bash)
```bash
curl -fsSL https://raw.githubusercontent.com/ppswaroopa/ros2-dockergen/main/install.sh | bash
```

---

## Fonctionnalités

- **Support complet des distributions** : Choisissez entre les distributions ROS2 **Jazzy**, **Humble** et **Kilted**.  
- **Accélération GPU** : Configure automatiquement les images de base `nvidia/cuda` et les capacités d’exécution si CUDA ou TensorRT est sélectionné.  
- **Choix utilisateur** : Gère la création d’**utilisateur non-root** avec mappage automatique UID/GID pour éviter les problèmes de permissions sur les volumes hôtes.  
- **Outils complets** : Activez les paquets ROS2 courants (Nav2, MoveIt2, SLAM Toolbox, MoveIt, Gazebo GZ, etc.) et les outils de dev (colcon, rosdep, Oh-My-Zsh, SSH, X11).  
- **Sortie complète** : Génère non seulement un `Dockerfile`, mais aussi un `docker-compose.yml` correspondant et un `README.md` spécifique à l’espace de travail avec instructions.  
- **Parité Web** : Moteur logique identique partagé avec l’[interface Web](https://ppswaroopa.github.io/ros2-dockergen/).  

---

## Utilisation

Il suffit d’exécuter :
```bash
ros2-dockergen
```
L'assistant interactif vous guidera à travers 8 étapes pour configurer votre environnement.

### Options de ligne de commande
```bash
ros2-dockergen --help    # Show help
ros2-dockergen --version # Show version
```
---

## CI locale avec `act`

Pour reproduire le workflow principal GitHub Actions localement, installez [`act`](https://nektosact.com/installation/) et exécutez :

```bash
./scripts/run_act.sh
```
Par défaut, cela exécute les travaux CI un par un afin que l'utilisation locale de Docker reste gérable et que la sortie de chaque travail soit facile à lire.

Si vous souhaitez plutôt le comportement original du workflow complet `act`, exécutez :


```bash
./scripts/run_act.sh full
```

---

## 📁 Structure du Projet

- `src/ros2_dockergen/` : Package Python principal (CLI + Logique).
- `src/core.js` : Moteur partagé (ESM) pour Web et Node.js.
- `index.html` : Générateur interactif impressionnant basé sur le navigateur.
- `docs/` : Ressources visuelles et documentation du projet.
- `tests/` : Suite de validation de parité (Assure que les sorties Python/JS sont identiques octet par octet).

---

## 🔗 Ressources Associées

- [Utilitaire Web](https://ppswaroopa.github.io/ros2-dockergen/)
- [Documentation Officielle ROS](https://docs.ros.org)
- [OSRF ROS Docker Hub](https://hub.docker.com/r/osrf/ros)

---

## Licence

Publié sous la [Licence MIT](LICENSE).
Droits d'auteur © 2026 Pranava Swaroopa.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-18

---