# EX-4D : Synthèse vidéo 4D à points de vue extrêmes via un maillage étanche à la profondeur

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Article](https://arxiv.org/abs/2506.05554)  |  [🎥 Page d'accueil](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Code](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Points forts

- **🎯 Synthèse à points de vue extrêmes** : Génère des vidéos 4D de haute qualité avec des mouvements de caméra de -90° à 90°
- **🔧 Maillage étanche à la profondeur** : Nouvelle représentation géométrique modélisant à la fois les régions visibles et occultées
- **⚡ Architecture légère** : Seulement 1 % des paramètres entraînables (140M) du backbone de diffusion vidéo 14B
- **🎭 Pas d'entraînement multi-vues** : Stratégie de masquage innovante éliminant le besoin de jeux de données multi-vues coûteux
- **🏆 Performances à l'état de l'art** : Surpasse les méthodes existantes, notamment sur les angles de caméra extrêmes

## 🎬 Résultats de démonstration

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D transforme les vidéos monoculaires en expériences 4D contrôlables par la caméra avec des résultats physiquement cohérents sous des points de vue extrêmes.*

## 🏗️ Vue d'ensemble du framework

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Notre framework se compose de trois éléments clés :

1. **🔺 Construction du maillage étanche à la profondeur** : Crée un a priori géométrique robuste modélisant explicitement les régions visibles et occultées
2. **🎭 Stratégie de masquage simulée** : Génère des données d'entraînement efficaces à partir de vidéos monoculaires sans jeux de données multi-vues
3. **⚙️ Adaptateur LoRA léger** : Intègre efficacement les informations géométriques avec des modèles de diffusion vidéo pré-entraînés

## 🚀 Démarrage rapide

### Installation

```bash
# Cloner le dépôt
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Créer un environnement conda
conda create -n ex4d python=3.10
conda activate ex4d
# Installer PyTorch (2.x recommandé)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Installer Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Installer les dépendances et diffsynth
pip install -e .
# Installer depthcrafter pour l'estimation de profondeur. (Suivez les instructions d'installation de DepthCrafter pour la préparation des checkpoints.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Télécharger le modèle pré-entraîné
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Exemple d'utilisation
#### 1. Reconstruction du maillage DW
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. Génération EX-4D (48GB VRAM requis)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Vidéo d'entrée</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Vidéo de sortie</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| Méthode | FID (Extrême) ↓ | FVD (Extrême) ↓ | Score VBench ↑ |
|---------|----------------|-----------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Ours)** | **55.42** | **823.61** | **0.450** | -->

### Résultats de l’étude utilisateur

- **70,7 %** des participants ont préféré EX-4D aux méthodes de référence
- Performance supérieure en cohérence physique et qualité pour les angles de vue extrêmes
- Amélioration significative lorsque les angles de caméra deviennent plus extrêmes


## 🎯 Applications

- **🎮 Jeu vidéo** : Créez des cinématiques 3D immersives à partir de séquences 2D
- **🎬 Production cinématographique** : Générez de nouveaux angles de caméra pour la post-production
- **🥽 VR/AR** : Créez des expériences vidéo à point de vue libre
- **📱 Réseaux sociaux** : Générez des mouvements de caméra dynamiques pour la création de contenu
- **🏢 Architecture** : Visualisez des espaces sous plusieurs angles de vue

<!-- ## 📈 Benchmarks -->

<!-- ### Évaluation de l’amplitude des angles de vue

| Plage | Petite (0°→30°) | Large (0°→60°) | Extrême (0°→90°) | Complète (-90°→90°) |
|-------|-----------------|----------------|------------------|---------------------|
| Score FID | 44.19 | 50.30 | 55.42 | - |
| Écart de performance | +9,1 % mieux | +8,9 % mieux | +11,3 % mieux | +15,5 % mieux | -->

<!-- *Écart de performance par rapport à la deuxième meilleure méthode dans chaque catégorie.* -->

## ⚠️ Limitations

- **Dépendance à la profondeur** : Les performances dépendent de la qualité de l’estimation de profondeur monoculaire
- **Coût computationnel** : Nécessite des ressources significatives pour les vidéos haute résolution
- **Surfaces réfléchissantes** : Défis avec les matériaux réfléchissants ou transparents

## 🔮 Perspectives futures
- [ ] Optimisation pour l’inférence en temps réel (3DGS / 4DGS)
- [ ] Prise en charge de résolutions supérieures (1K, 2K)
- [ ] Techniques de raffinement de maillage neuronal

## 🙏 Remerciements

Nous remercions le projet [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) pour avoir fourni le cadre fondamental de diffusion.

## 📚 Citation

Si notre travail vous est utile, veuillez citer :

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---