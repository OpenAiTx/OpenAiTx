# Simulation de véhicule à direction Ackermann dans ROS2 avec Gazebo Sim Harmonic

Ce projet présente la simulation d’un véhicule personnalisé avec des **capacités de direction Ackermann**, développé en utilisant **ROS2** et l’environnement **Gazebo Sim Harmonic**. Le modèle intègre une variété de capteurs et d’outils de navigation pour une opération autonome, en faisant l’une des premières implémentations d’un véhicule à direction Ackermann dans ce cadre de simulation.

| **Visualisation du nuage de points 3D LiDAR** | **Modèle d’environnement d’entrepôt** |
| ----- | ----- |
| ![Nuage de points 3D](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/3d_lidar_pointcloud.png) | ![Modèle d’entrepôt](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/warehouse_environment.png) |

### Si ce projet vous plaît, pensez à lui attribuer une ⭐ pour montrer votre soutien !

## Table des matières

- [Simulation de véhicule à direction Ackermann dans ROS2 avec Gazebo Sim Harmonic](#ackermann-steering-vehicle-simulation-in-ros2-with-gazebo-sim-harmonic)
- [Fonctionnalités](#features)
  - [1 Direction Ackermann](#1-ackermann-steering)
  - [2 Communication ROS2](#2-ros2-communication)
  - [3 Capteurs](#3-sensors)
  - [4 Navigation](#4-navigation)
  - [5 Contrôle manuel avec joystick externe](#5-manual-control-with-external-joystick)
  - [6 Visualisation](#6-visualization)
- [Prérequis](#requirements)
- [Installation locale](#local-installation)
- [Installation Docker](#docker-installation)
- [Utilisation](#usage)
  - [1 Simulation de base et contrôle manuel](#1-basic-simulation-and-manual-control)
  - [2 SLAM localisation et cartographie simultanées](#2-slam-simultaneous-localization-and-mapping)
  - [3 Navigation avec Nav2](#3-navigation-with-nav2)
- [Travaux futurs](#future-work)
- [Galerie](#gallery)
- [Arbre TF](#tf-tree)
- [Historique des étoiles](#star-history)

## Fonctionnalités

### 1. **Direction Ackermann**

- Un modèle de véhicule personnalisé construit avec une dynamique réaliste de direction Ackermann pour une maniabilité précise.

### 2. **Communication ROS2**

- Toutes les données des capteurs et les signaux de contrôle sont entièrement intégrés dans l’écosystème ROS2 pour une interopérabilité transparente.

### 3. **Capteurs**

- **IMU** : Fournit l’orientation et la vitesse angulaire.
- **Odométrie** : Assure un retour précis de l’état du véhicule.
- **LiDAR** : Monté pour la détection d’obstacles et le balayage environnemental. Supporte la génération de nuages de points 3D pour des tâches avancées de perception.
- **Caméras** :
  - Avant
  - Arrière
  - Côté gauche
  - Côté droit
  > **Note :** Par défaut, seule la caméra avant est connectée à ROS 2. Si vous souhaitez utiliser toutes les caméras (gauche, droite, arrière) dans ROS 2, retirez le `#` au début des sections de caméra concernées dans `saye_bringup/config/ros_gz_bridge.yaml` pour les activer (par ex., `/camera/left_raw`, `/camera/right_raw`, `/camera/rear_raw`).

### 4. **Navigation**

- Intégré avec la **pile Nav2** pour la navigation autonome.
- **AMCL (Localisation Monte Carlo Adaptative)** pour une meilleure précision de position.
- Techniques de **SLAM** mises en œuvre pour la cartographie en temps réel et la compréhension de l’environnement.
- Paramètres finement ajustés pour une performance optimisée de la navigation.

### 5. **Contrôle manuel (avec joystick externe)**

- Ajout du support pour le contrôle manuel via joystick dans l’environnement de simulation, permettant aux utilisateurs de tester les déplacements du véhicule de manière interactive.

### 6. **Visualisation**

- Visualisation complète du modèle et des données des capteurs dans **RViz2**, offrant des informations sur les états du robot et le retour environnemental.

## Exigences

- **ROS2 (Humble)**
- **Gazebo Sim Harmonic**
- **RViz2**
- **Nav2**

## Installation locale

0. Vous devez vous assurer de l’installation de Gazebo Harmonic et de ROS (ros_gz) :<br>
   `sudo apt-get install ros-${ROS_DISTRO}-ros-gz`<br>
   `sudo apt-get install ros-humble-ros-gzharmonic` (Version Humble uniquement)<br>
   Plus de détails sur l'installation de Gazebo et ROS : <a href="https://gazebosim.org/docs/latest/ros_installation/">Lien</a>
1. Cloner le dépôt :<br>
   `mkdir -p ackermann_sim/src && cd ackermann_sim/src`<br>
   `git clone https://github.com/alitekes1/ackermann-vehicle-gzsim-ros2`<br>`cd ..`
2. Construire le projet :
   `colcon build && source install/setup.bash`
3. Configurer les variables d'environnement :
   ```bash
   # Set environment variables for current session
   export GZ_SIM_RESOURCE_PATH=$GZ_SIM_RESOURCE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/
   export ROS_PACKAGE_PATH=$ROS_PACKAGE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/
   ```

   **Pour une configuration permanente :**
   
   Pour rendre ces variables d'environnement permanentes, ajoutez-les à votre fichier `.bashrc` :
   ```bash
   # Add environment variables to .bashrc
   echo 'export GZ_SIM_RESOURCE_PATH=$GZ_SIM_RESOURCE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/' >> ~/.bashrc
   echo 'export ROS_PACKAGE_PATH=$ROS_PACKAGE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/' >> ~/.bashrc
   
   # Apply changes
   source ~/.bashrc
   ```

   > **Note :** Remplacez `/your/path/` par le chemin réel de votre installation.

## Installation de Docker

Vous pouvez également exécuter la simulation en utilisant Docker, ce qui garantit un environnement cohérent sur différents systèmes.

### Prérequis
- Docker
- NVIDIA Container Toolkit (pour la prise en charge GPU)

### Étapes pour exécuter avec Docker

1. Clonez le dépôt :
   ```bash
   mkdir -p ackermann_sim/src && cd ackermann_sim/src
   git clone https://github.com/alitekes1/ackermann-vehicle-gzsim-ros2
   cd ackermann-vehicle-gzsim-ros2
   ```

2. Construisez et exécutez le conteneur Docker :
   ```bash
      docker run -it \
      --name ackermann_sim \
      --hostname ackermann_sim \
      --env="DISPLAY=$DISPLAY" \
      --env="QT_X11_NO_MITSHM=1" \
      --volume="/tmp/.X11-unix:/tmp/.X11-unix:rw" \
      --privileged alitekes1/ackermann_sim:latest
   ```
3. Si vous souhaitez un terminal supplémentaire pour le même conteneur

   ```bash
      docker exec -it ackermann_sim bash
   ```
   
> **Remarque :** À l'intérieur du conteneur, vous pouvez exécuter les commandes de simulation normalement.

## Utilisation

### 1. Simulation de base et contrôle manuel

1.  Lancer la simulation :

    ```bash
    ros2 launch saye_bringup saye_spawn.launch.py
    ```
2.  Voiture de contrôle :
    ```bash
    ros2 run teleop_twist_keyboard teleop_twist_keyboard
    ```

### 2. SLAM (Localisation et Cartographie Simultanées)

-   Pour exécuter SLAM Toolbox pour la cartographie, lancez ce qui suit après avoir démarré la simulation :
    ```bash
    ros2 launch saye_bringup slam.launch.py
    ```
    [![SLAM- Youtube](https://img.youtube.com/vi/QWcJ9TlqFOU/0.jpg)](https://www.youtube.com/watch?v=QWcJ9TlqFOU "Présentation du projet")

### 3. Navigation avec Nav2

-   Pour exécuter la simulation avec la pile Nav2 pour la navigation autonome, lancez ce qui suit après avoir démarré la simulation :
    ```bash
    ros2 launch saye_bringup navigation_bringup.launch.py
    ```
    [![Navigation Autonome - Youtube](https://img.youtube.com/vi/SJ4NrbdlNZo/0.jpg)](https://www.youtube.com/watch?v=SJ4NrbdlNZo "NAV2")

> **Note :** Les vidéos YouTube ci-dessus sont lues à une vitesse 4x. Vous pouvez accéder aux vidéos en cliquant sur les images.

## Travaux Futurs

1. **Support SLAM 3D :**
   - Former le véhicule à gérer des scénarios complexes de manière autonome en utilisant des algorithmes DRL avancés.
2. **Fonctionnalités Améliorées :**
   - Explorer des configurations de capteurs supplémentaires et des stratégies de navigation.
3. **Intégration Nav2 avec Localisation 3D**
   - Au lieu d'AMCL(2D), implémentation d'algorithmes plus précis et robustes.
## Galerie

![Capture d'écran du 2024-09-23 00-09-48.png](https://github.com/user-attachments/assets/dd5604c6-014e-4a7a-9a2f-c4dd237abb37)

### Nuage de Points LiDAR 3D & Environnement

| **Visualisation du Nuage de Points LiDAR 3D**                             | **Modèle de l'Environnement Entrepôt**                                   |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| ![Nuage de Points 3D](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/3d_lidar_pointcloud.png) | ![Modèle Entrepôt](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/warehouse_environment.png) |

### Véhicule & Navigation

| **Simulation Gazebo Harmonic**                                                                                                     | **RViz2**                                                                                                                   |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| ![Capture d'écran du 2024-09-23 00-13-03.png](https://github.com/user-attachments/assets/1d2b56f7-34c1-4b01-9a85-fb01ceab5bd6) | ![Capture d'écran du 2024-09-23 00-09-04.png](https://github.com/user-attachments/assets/ba6853fd-4143-4b4d-bbc6-072895e4c75e) |
| ![Capture d'écran du 2024-09-23 00-12-13.png](https://github.com/user-attachments/assets/477cce7b-995b-471e-a684-4d82bee0fc34) | ![Capture d'écran du 2024-09-23 00-15-04.png](https://github.com/user-attachments/assets/bf9ad916-14a6-4b62-a799-4169a767e4dd) |
| ![texte alternatif](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/saye.png)                                                                                         | ![texte alternatif](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/rviz_saye.png)                                                                                    |

## Arbre TF

![Arbre TF](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/frames.png)

---

## Historique des Étoiles

<a href="https://www.star-history.com/#alitekes1/ackermann-vehicle-gzsim-ros2&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
   <img alt="Graphique de l'historique des étoiles" src="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-13

---