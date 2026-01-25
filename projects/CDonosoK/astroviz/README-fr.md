# 🚀 AstroViz 🚀

<img src="https://github.com/hucebot/astroviz/blob/main/images/AstroViz.png" alt="Image AstroViz" width="800" height="500">

[![Licence](https://img.shields.io/badge/License-MIT--Clause-blue.svg)](https://opensource.org/licenses/MIT)
[![Version ROS2](https://img.shields.io/badge/ROS-Humble-green)](https://docs.ros.org/en/humble/index.html)

AstroViz est la suite ultime de visualisation de données en temps réel pour les missions robotiques ROS 2. Conçu de A à Z pour la flexibilité, la clarté et la performance, AstroViz offre aux roboticiens, ingénieurs et opérateurs sur le terrain une interface unifiée pour surveiller, contrôler et déboguer des systèmes complexes en temps réel.

- 🌍 Visualisation tout-en-un : Du GPS et LiDAR aux flux caméra, état du robot et santé des moteurs, AstroViz intègre plusieurs vues dans une interface moderne et cohérente.
- ⚡ Haute performance : Le déploiement basé sur Docker avec prise en charge GPU garantit un fonctionnement fluide même dans des environnements à forte intensité de données.
- 🛰️ Éprouvé sur le terrain : Que vous lanciez des véhicules autonomes, drones ou robots terrestres, AstroViz est votre centre de commande visuel.

💡 Vous cherchez un outil ROS 2 qui va au-delà des données brutes et vous aide à prendre des décisions en temps réel sur le terrain ?  
<b>AstroViz est conçu pour cela.</b>

## Aperçu Visuel
<table>
  <tr>
    <td colspan="2" align="center">
      <strong>VUE TABLEAU DE BORD</strong><br>
      <img src="https://github.com/hucebot/astroviz/blob/main/images/dashboard.gif" alt="Aperçu téléopération" width="800">
    </td>
  </tr>
</table>

Pour une vue détaillée de toutes les fenêtres implémentées, voir : [fenêtres implémentées](https://raw.githubusercontent.com/CDonosoK/astroviz/main/WINDOWS_IMPLEMENTED.md)


## Table des matières
1. [Commencer](#get-started)
   - [Prérequis](#prerequisites)
   - [Installation](#installation)
      - [Cloner le dépôt](#clone-the-repository)
      - [Construire avec Docker](#build-using-docker)
      - [Lancer le conteneur Docker](#run-the-docker-container)
2. [Utilisation](#usage)
   - [Vue d'ensemble des nœuds](#node-overview)
   - [Exécution des nœuds](#running-nodes)
3. [Mainteneur](#maintainer)
3. [Licence](#license)

---

## Commencer
### Prérequis

Pour exécuter ce package, assurez-vous que les dépendances suivantes sont installées :
- **Git** : Pour le contrôle de version et la gestion du dépôt.
- **Docker** : Pour faciliter la configuration et l'exécution de l'environnement.
- **NVIDIA Container Toolkit** (si vous utilisez un GPU NVIDIA) : Pour l'accélération matérielle.


### Installation

#### Cloner le dépôt
Commencez par cloner le dépôt :
```bash
git clone git@github.com:hucebot/astroviz.git
```

#### Construire avec Docker
Ce dépôt comprend une configuration Docker préconfigurée pour un déploiement facile. Pour construire l’image Docker :
1. Naviguez vers le répertoire `docker` :
   ```bash
   cd astroviz/docker
   ```
2. Exécutez le script de construction :
   ```bash
   sh build.sh
   ```
   Cela créera une image Docker nommée `astroviz`.

#### Exécuter le conteneur Docker
Une fois construit, lancez le conteneur en utilisant :
```bash
sh run.sh
```
---

## Utilisation
### Vue d'ensemble des nœuds

Ce paquet contient des nœuds conçus pour faciliter la téléopération et la visualisation des données. Chaque nœud a un but spécifique dans le flux de travail de téléopération :
- **gpsmap_viewer** : Visualise les données GPS sur une carte.
- **camera_viewer** : Affiche le flux de la caméra du robot.
- **imu_viewer** : Visualise les données de l'IMU.
- **lidar_viewer** : Visualise les données LiDAR.
- **teleoperation_viewer** : Fournit une interface graphique pour le contrôle de la téléopération.
- **dashboard_viewer** : Un tableau de bord complet qui intègre divers flux de données et offre une interface unifiée pour la surveillance et le contrôle.
- **plot_viewer** : Affiche des graphiques en temps réel de divers flux de données.
- **grid_map_viewer** : Visualise les données de la carte en grille pour la navigation et la planification.
- **robot_state_viewer** : Affiche l'état actuel du robot lié aux positions des articulations et aux transformations.
- **motor_state_viewer** : Surveille et visualise l'état des moteurs du robot, y compris les lectures de température et de tension.
- **record_manager_viewer** : Gère et visualise les sessions d'enregistrement, permettant aux utilisateurs de démarrer, arrêter et revoir les enregistrements.

### Exécution des nœuds
Pour exécuter les nœuds, vous pouvez utiliser la commande suivante :
```bash
ros2 run astroviz <node_name>
```
Remplacez `<node_name>` par le nom du nœud que vous souhaitez exécuter, comme `gps_map_viewer`, `camera_viewer`, etc.

Ou si vous préférez exécuter le visualiseur de tableau de bord, qui intègre toutes les fonctionnalités :
```bash
ros2 launch astroviz dashboard_launcher.launch.py
```

## Mainteneur
Ce paquet est maintenu par :

**Clément Donoso**  
Email : [clemente.donoso@inria.fr](https://raw.githubusercontent.com/CDonosoK/astroviz/main/mailto:clemente.donoso@inria.fr)
GitHub : [CDonosoK](https://github.com/CDonosoK)  

---

## Licence
Ce projet est sous licence **MIT**. Voir le fichier [LICENSE](LICENSE) pour plus de détails.

---
Les contributions et retours sont les bienvenus ! Si vous rencontrez des problèmes ou avez des suggestions d'amélioration, n'hésitez pas à ouvrir un ticket ou à soumettre une pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-25

---