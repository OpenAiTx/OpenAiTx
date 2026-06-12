# Boîte à outils vidéo de profondeur métrique (MDVToolbox)

Outils pour générer et travailler avec des vidéos 3D de profondeur métrique.

![gif_banner](https://github.com/user-attachments/assets/4d737bb3-6fb6-4135-b01e-b35528371d22)

_Bannière créée avec 3d_view_depthfile.py_

## Démonstrations

**Vidéo de présentation :** https://youtu.be/nEiUloZ591Q

**Démo conversion film → 3D** : https://www.youtube.com/watch?v=PLFjoNgkZDY

**Extraits stéréo d’exemple :**
https://github.com/calledit/metric_depth_video_toolbox/releases/tag/Showcase


## Fonctionnalités

### Génération de vidéos de profondeur métrique

Convertir des vidéos rgb en vidéos de profondeur métrique en utilisant plusieurs modèles SOTA :

- Série Depth-Anything (`video_metric_convert.py`) et (`videoanythingmetric_video.py`)
- MoGe  (`moge_video.py`)
- UniDepth  (`unidepth_video.py`)
- UniK3D  (`unik3d_video.py`)
- DepthPro  (`depthpro_video.py`)
- DepthCrafter  (`depthcrafter_video.py`)
- MVSAnywhere  (`video_mvsa.py`)

### Conversion stéréo / 3D

- Films 2D → 3D (`movie_2_3D.py`)
- Rendu stéréo à partir de vidéos de profondeur et rgb (`stereo_rerender.py`)
- Remplissage de parallaxe & inpainting stéréo basé sur la diffusion (`stereo_crafter_infill.py`)

### Visualisation

- Visionneuse 3D en temps réel pour vidéos de profondeur métrique (`3d_view_depthfile.py`)
- Rendu de nouvelle vue à partir de vidéo de profondeur (`3d_view_depthfile.py`)

### Suivi de Caméra & Reconstruction 3D

- Suivi de caméra assisté par profondeur (`sam_track_video.py`) et (`align_3d_points.py`)
- Suivi de points à long terme (CoTracker3) (`track_points_in_video.py`)
- Outils d'extraction et d'alignement de pose

### Outils d'Exportation

Exporter la vidéo de profondeur métrique vers des formats standards pour utilisation dans d'autres outils : (`convert_metric_depth_video_to_other_format.py`)

- Nuages de points `.ply`
- Maillages `.obj`
- Pistes de caméra Blender `.blend` & Alembic `.abc`
- Cartes de profondeur 8 bits / 16 bits
- Recalibrage de profondeur basé sur la triangulation

### Masquage & Nettoyage

- Masquage automatique du sujet principal (`generate_video_mask.py`)
- Retouche de sous-titres/logo par inpainting (`apply_inpainting.sh`)


## Documentation

| Sujet | Lien |
|---|---|
Guide débutant | [`HOWTO.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO.md)  
Guide Film → 3D | [`HOWTO_movie2_3d.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO_movie2_3d.md)  
Référence complète de l'outil | [`USAGE.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/USAGE.md)  
Tutoriel vidéo GUI | https://youtu.be/BE_aJCI7DHI  


## Format Vidéo de Profondeur

MDVT utilise une **profondeur métrique 16 bits encodée en RGB** :

- **Rouge + Vert** = 8 bits supérieurs (dupliqués pour visibilité)  
- **Bleu** = 8 bits inférieurs  
- Plage par défaut : **100 mètres**  
- Résolution : **~1,5 mm de précision en profondeur**  

La mise à niveau future pour plus de précision sera effectuée avec : **profondeur 24 bits** ou **profondeur encodée en log** pour une précision à longue portée.  

---  

## Installation  

### Windows  
1. installer git https://git-scm.com/downloads/win  
2. Installer miniconda https://docs.conda.io/en/latest/  
3. Ouvrir l'invite Anaconda (miniconda) depuis le menu démarrer  
4. exécuter
```batch
git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox
windows_installer.bat
```
5. utilisez `conda activate mdvt` pour activer conda et utiliser les outils. Certains modèles ML ne sont pas pris en charge sous Windows mais les plus essentiels le sont, comme Sterecrafter et depth anything.

### Ubuntu/Debian et OSX

```bash


git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox

# on linux
sudo apt-get install -y libgl1
./install_mdvtoolbox.sh

#Optional (only required for some tools)
./install_mdvtoolbox.sh -megasam
./install_mdvtoolbox.sh -geometrycrafter
./install_mdvtoolbox.sh -unik3d
./install_mdvtoolbox.sh -depthpro
./install_mdvtoolbox.sh -stereocrafter
./install_mdvtoolbox.sh -madpose
./install_mdvtoolbox.sh -unidepth
./install_mdvtoolbox.sh -moge
./install_mdvtoolbox.sh -promptda

# if using headless linux you need to start a virtual x11 server
apt-get install xvfb
Xvfb :2 &
export DISPLAY=:2

# OSX (OSX only supports post processing of depth videos not generation of them. As the ML models need CUDA)
# (open3d requires python3.11 on OSX (as of 2025)))
pip3.11 install open3d numpy opencv-python

```

### Exigences
Les outils nécessitant des modèles ML ont été testés sur des machines avec des cartes nvidia 3090 supportant Cuda 12.4 et Torch 2.5.1 sur [vast.ai](https://cloud.vast.ai/?ref_id=148636) utilisant "template PyTorch (cuDNN Devel)"

### Étapes suivantes
- En attente actuellement de nouveaux modèles de profondeur stables et précis.

### Contribution
Est appréciée. Même pour des choses simples comme l’orthographe.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---