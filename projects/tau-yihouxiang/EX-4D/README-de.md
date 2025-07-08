# EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Paper](https://arxiv.org/abs/2506.05554)  |  [🎥 Homepage](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Code](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Highlights

- **🎯 Extreme Viewpoint Synthesis**: Erzeuge hochwertige 4D-Videos mit Kamerabewegungen von -90° bis 90°
- **🔧 Depth Watertight Mesh**: Neue geometrische Repräsentation, die sowohl sichtbare als auch verdeckte Bereiche modelliert
- **⚡ Leichtgewichtige Architektur**: Nur 1 % trainierbare Parameter (140M) des 14B Video-Diffusions-Backbones
- **🎭 Kein Multi-View-Training**: Innovative Maskierungsstrategie eliminiert die Notwendigkeit teurer Multi-View-Datensätze
- **🏆 State-of-the-art Performance**: Übertrifft bestehende Methoden, insbesondere bei extremen Kamerawinkeln

## 🎬 Demo-Ergebnisse

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D verwandelt monokulare Videos in kamerasteuerbare 4D-Erlebnisse mit physikalisch konsistenten Ergebnissen bei extremen Blickwinkeln.*

## 🏗️ Rahmenüberblick

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Unser Framework besteht aus drei Schlüsselelementen:

1. **🔺 Depth Watertight Mesh Construction**: Erzeugt ein robustes geometrisches Vorwissen, das explizit sowohl sichtbare als auch verdeckte Bereiche modelliert
2. **🎭 Simulierte Maskierungsstrategie**: Generiert effektive Trainingsdaten aus monokularen Videos ohne Multi-View-Datensätze
3. **⚙️ Leichtgewichtiger LoRA-Adapter**: Integriert geometrische Informationen effizient in vortrainierte Video-Diffusionsmodelle

## 🚀 Schnellstart

### Installation

```bash
# Repository klonen
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Conda-Umgebung erstellen
conda create -n ex4d python=3.10
conda activate ex4d
# PyTorch installieren (2.x empfohlen)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Nvdiffrast installieren
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Abhängigkeiten und diffsynth installieren
pip install -e .
# depthcrafter für Tiefenschätzung installieren. (Folge DepthCrafters Installationsanleitung für die Vorbereitung der Checkpoints.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Vorgefertigtes Modell herunterladen
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Beispielanwendung
#### 1. DW-Mesh Rekonstruktion
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. EX-4D Generierung (48GB VRAM erforderlich)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Eingabevideo</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Ausgabevideo</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| Methode | FID (Extreme) ↓ | FVD (Extreme) ↓ | VBench Score ↑ |
|---------|-----------------|-----------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Unseres)** | **55.42** | **823.61** | **0.450** | -->

### Ergebnisse der Benutzerstudie

- **70,7%** der Teilnehmer bevorzugten EX-4D gegenüber den Basismethoden
- Überlegene Leistung bei physikalischer Konsistenz und Qualität aus extremen Blickwinkeln
- Deutliche Verbesserung, wenn die Kamerawinkel extremer werden

## 🎯 Anwendungen

- **🎮 Gaming**: Immersive 3D-Spielkinematiken aus 2D-Material erstellen
- **🎬 Filmproduktion**: Neue Kamerawinkel für die Postproduktion generieren
- **🥽 VR/AR**: Free-Viewpoint-Videoerlebnisse erstellen
- **📱 Soziale Medien**: Dynamische Kamerabewegungen für die Content-Erstellung erzeugen
- **🏢 Architektur**: Räume aus mehreren Blickwinkeln visualisieren

<!-- ## 📈 Benchmarks -->

<!-- ### Auswertung des Blickwinkelbereichs

| Bereich | Klein (0°→30°) | Groß (0°→60°) | Extrem (0°→90°) | Voll (-90°→90°) |
|---------|----------------|---------------|-----------------|-----------------|
| FID Score | 44.19 | 50.30 | 55.42 | - |
| Leistungsabstand | +9,1% besser | +8,9% besser | +11,3% besser | +15,5% besser | -->

<!-- *Leistungsabstand im Vergleich zur zweitbesten Methode in jeder Kategorie.* -->

## ⚠️ Einschränkungen

- **Abhängigkeit von Tiefe**: Die Leistung hängt von der Qualität der monokularen Tiefenschätzung ab
- **Rechenaufwand**: Benötigt erhebliche Rechenleistung für hochauflösende Videos
- **Reflektierende Oberflächen**: Herausforderungen bei reflektierenden oder transparenten Materialien

## 🔮 Zukünftige Arbeiten
- [ ] Echtzeit-Inferenz-Optimierung (3DGS / 4DGS)
- [ ] Unterstützung für höhere Auflösungen (1K, 2K)
- [ ] Techniken zur neuronalen Mesh-Verfeinerung

## 🙏 Danksagung

Wir danken dem [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1)-Projekt für die Bereitstellung des grundlegenden Diffusions-Frameworks.

## 📚 Zitation

Wenn Sie unsere Arbeit nützlich finden, zitieren Sie bitte:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng und Xiao Liu und Yuewen Ma},
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