# EX-4D: EXtreme Viewpoint 4D Video Synthese via Depth Watertight Mesh

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Paper](https://arxiv.org/abs/2506.05554)  |  [🎥 Homepage](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Code](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Hoogtepunten

- **🎯 Extreme Standpunt Synthese**: Genereer hoogwaardige 4D-video’s met camerabewegingen van -90° tot 90°
- **🔧 Depth Watertight Mesh**: Nieuwe geometrische representatie die zowel zichtbare als verborgen gebieden modelleert
- **⚡ Lichtgewicht Architectuur**: Slechts 1% trainbare parameters (140M) van de 14B video diffusie-backbone
- **🎭 Geen Multi-view Training**: Innovatieve maskeringsstrategie elimineert de noodzaak voor dure multi-view datasets
- **🏆 State-of-the-art Prestaties**: Overtreft bestaande methoden, vooral bij extreme camerahoeken

## 🎬 Demo Resultaten

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D transformeert monoculaire video’s in camera-controleerbare 4D-ervaringen met fysiek consistente resultaten onder extreme standpunten.*

## 🏗️ Framework Overzicht

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Ons framework bestaat uit drie belangrijke componenten:

1. **🔺 Depth Watertight Mesh Constructie**: Creëert een robuuste geometrische prior die zowel zichtbare als verborgen gebieden expliciet modelleert
2. **🎭 Gesimuleerde Maskeringsstrategie**: Genereert effectieve trainingsdata uit monoculaire video’s zonder multi-view datasets
3. **⚙️ Lichtgewicht LoRA Adapter**: Integreert efficiënt geometrische informatie met voorgetrainde video diffusie-modellen

## 🚀 Snelstart

### Installatie

```bash
# Clone de repository
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Maak conda-omgeving aan
conda create -n ex4d python=3.10
conda activate ex4d
# Installeer PyTorch (2.x aanbevolen)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Installeer Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Installeer afhankelijkheden en diffsynth
pip install -e .
# Installeer depthcrafter voor diepte-schatting. (Volg DepthCrafter's installatie-instructie voor de voorbereiding van checkpoints.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Download Voorgetraind Model
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Voorbeeld Gebruik
#### 1. DW-Mesh Reconstructie
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. EX-4D Generatie (48GB VRAM vereist)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Invoervideo</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Uitvoervideo</b>
</td>
</tr> 
</table>

<!-- ## 📊 Prestaties

### Kwantitatieve Resultaten
| Methode | FID (Extreme) ↓ | FVD (Extreme) ↓ | VBench Score ↑ |
|---------|-----------------|-----------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Ours)** | **55.42** | **823.61** | **0.450** | -->

### Resultaten Gebruikersonderzoek

- **70,7%** van de deelnemers gaf de voorkeur aan EX-4D boven de basismethoden
- Superieure prestaties in fysieke consistentie en kwaliteit bij extreme gezichtspunten
- Significante verbetering naarmate de camerahoeken extremer worden


## 🎯 Toepassingen

- **🎮 Gaming**: Maak meeslepende 3D-gamecinematografie van 2D-beelden
- **🎬 Filmproductie**: Genereer nieuwe camerahoeken voor postproductie
- **🥽 VR/AR**: Maak vrij-uitzicht video-ervaringen
- **📱 Sociale media**: Genereer dynamische camerabewegingen voor contentcreatie
- **🏢 Architectuur**: Visualiseer ruimtes vanuit meerdere gezichtspunten

<!-- ## 📈 Benchmarks -->

<!-- ### Viewpoint Range Evaluation

| Bereik | Klein (0°→30°) | Groot (0°→60°) | Extreem (0°→90°) | Volledig (-90°→90°) |
|--------|----------------|----------------|------------------|---------------------|
| FID Score | 44.19 | 50.30 | 55.42 | - |
| Prestatiekloof | +9,1% beter | +8,9% beter | +11,3% beter | +15,5% beter | -->

<!-- *Prestatiekloof ten opzichte van de op één na beste methode in elke categorie.* -->

## ⚠️ Beperkingen

- **Diepteafhankelijkheid**: Prestaties zijn afhankelijk van de kwaliteit van monoculaire diepteschatting
- **Rekenkosten**: Vereist aanzienlijke rekenkracht voor video's met hoge resolutie
- **Reflecterende oppervlakken**: Uitdagingen met reflecterende of transparante materialen

## 🔮 Toekomstig Werk
- [ ] Real-time inferentie-optimalisatie (3DGS / 4DGS)
- [ ] Ondersteuning voor hogere resoluties (1K, 2K)
- [ ] Neurale mesh-verfijningstechnieken

## 🙏 Dankwoord

Wij willen het [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) project bedanken voor het leveren van het fundamentele diffusiemodel.

## 📚 Referentie

Als u ons werk nuttig vindt, overweeg dan om te citeren:

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