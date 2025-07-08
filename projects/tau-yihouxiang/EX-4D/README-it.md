# EX-4D: Sintesi Video 4D da Punti di Vista Estremi tramite Depth Watertight Mesh

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Paper](https://arxiv.org/abs/2506.05554)  |  [🎥 Homepage](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Codice](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Punti Salienti

- **🎯 Sintesi da Punti di Vista Estremi**: Genera video 4D di alta qualità con movimenti di camera da -90° a 90°
- **🔧 Depth Watertight Mesh**: Nuova rappresentazione geometrica che modella sia le regioni visibili che quelle occluse
- **⚡ Architettura Leggera**: Solo l'1% dei parametri addestrabili (140M) rispetto alla backbone di diffusione video da 14B
- **🎭 Nessun Addestramento Multi-view**: Innovativa strategia di mascheramento che elimina la necessità di costosi dataset multi-view
- **🏆 Prestazioni all'Avanguardia**: Supera i metodi esistenti, soprattutto su angoli di ripresa estremi

## 🎬 Risultati Demo

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D trasforma video monoculari in esperienze 4D controllabili dalla camera con risultati fisicamente coerenti anche da punti di vista estremi.*

## 🏗️ Panoramica del Framework

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Il nostro framework è composto da tre componenti chiave:

1. **🔺 Costruzione Depth Watertight Mesh**: Crea un robusto prior geometrico che modella esplicitamente sia le regioni visibili che quelle occluse
2. **🎭 Strategia di Mascheramento Simulato**: Genera dati di addestramento efficaci da video monoculari senza dataset multi-view
3. **⚙️ Lightweight LoRA Adapter**: Integra in modo efficiente le informazioni geometriche con modelli pre-addestrati di video diffusion

## 🚀 Quick Start

### Installazione

```bash
# Clona il repository
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Crea un ambiente conda
conda create -n ex4d python=3.10
conda activate ex4d
# Installa PyTorch (consigliato 2.x)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Installa Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Installa le dipendenze e diffsynth
pip install -e .
# Installa depthcrafter per la stima della profondità. (Segui le istruzioni di DepthCrafter per la preparazione dei checkpoint.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Scarica il Modello Preaddestrato
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Esempio di Utilizzo
#### 1. Ricostruzione DW-Mesh
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. Generazione EX-4D (richiesti 48GB VRAM)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Video di Input</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Video di Output</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| Metodo | FID (Estremo) ↓ | FVD (Estremo) ↓ | VBench Score ↑ |
|--------|-----------------|-----------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Nostro)** | **55.42** | **823.61** | **0.450** | -->

### Risultati dello Studio Utente

- **70.7%** dei partecipanti ha preferito EX-4D rispetto ai metodi di base
- Prestazioni superiori in coerenza fisica e qualità da punti di vista estremi
- Miglioramento significativo man mano che gli angoli di ripresa diventano più estremi


## 🎯 Applicazioni

- **🎮 Gaming**: Creazione di cinematiche di gioco 3D immersive da filmati 2D
- **🎬 Produzione Cinematografica**: Generazione di angolazioni di camera innovative per la post-produzione
- **🥽 VR/AR**: Creazione di esperienze video a punto di vista libero
- **📱 Social Media**: Generazione di movimenti dinamici di camera per la creazione di contenuti
- **🏢 Architettura**: Visualizzazione di spazi da molteplici punti di vista

<!-- ## 📈 Benchmark -->

<!-- ### Valutazione Intervallo Angolazione

| Intervallo | Piccolo (0°→30°) | Grande (0°→60°) | Estremo (0°→90°) | Completo (-90°→90°) |
|------------|------------------|------------------|------------------|---------------------|
| FID Score | 44.19 | 50.30 | 55.42 | - |
| Vantaggio Prestazionale | +9.1% meglio | +8.9% meglio | +11.3% meglio | +15.5% meglio | -->

<!-- *Vantaggio prestazionale rispetto al secondo miglior metodo in ciascuna categoria.* -->

## ⚠️ Limitazioni

- **Dipendenza dalla Profondità**: Le prestazioni dipendono dalla qualità della stima di profondità monoculare
- **Costo Computazionale**: Richiede notevoli risorse computazionali per video ad alta risoluzione
- **Superfici Riflettenti**: Difficoltà con materiali riflettenti o trasparenti

## 🔮 Lavori Futuri
- [ ] Ottimizzazione per inferenza in tempo reale (3DGS / 4DGS)
- [ ] Supporto per risoluzioni più elevate (1K, 2K)
- [ ] Tecniche di raffinamento di mesh neurali

## 🙏 Ringraziamenti

Desideriamo ringraziare il progetto [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) per aver fornito il framework di diffusione di base.

## 📚 Citazione

Se trovi utile il nostro lavoro, considera di citarlo:

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