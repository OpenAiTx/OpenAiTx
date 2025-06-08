<h1 align="center">TexGaussian: Generazione di Materiali PBR di Alta Qualità tramite Octree-based 3D Gaussian Splatting</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

I materiali Physically Based Rendering (PBR) giocano un ruolo cruciale nella grafica moderna, consentendo il rendering fotorealistico su diverse mappe ambientali. Sviluppare un algoritmo efficace ed efficiente, in grado di generare automaticamente materiali PBR di alta qualità anziché semplici texture RGB per mesh 3D, può semplificare notevolmente la creazione di contenuti 3D. La maggior parte dei metodi esistenti sfrutta modelli di diffusione 2D pre-addestrati per la sintesi di immagini multi-vista, il che spesso porta a gravi incongruenze tra le texture generate e le mesh 3D in input. Questo articolo presenta TexGaussian, un nuovo metodo che utilizza Octant-aligned 3D Gaussian Splatting per una generazione rapida di materiali PBR. In particolare, posizioniamo ogni Gaussiana 3D sul nodo foglia più fine dell'octree costruito a partire dalla mesh 3D in input per rendere le immagini multi-vista non solo per la mappa albedo, ma anche per roughness e metallic. Inoltre, il nostro modello è addestrato in modo regressivo anziché tramite denoising di diffusione, risultando capace di generare il materiale PBR per una mesh 3D in un solo processo feed-forward. Ampi esperimenti su benchmark pubblici dimostrano che il nostro metodo sintetizza materiali PBR visivamente più gradevoli e opera più rapidamente rispetto ai metodi precedenti sia in scenari incondizionati che condizionati dal testo, mostrando una migliore coerenza con la geometria fornita.

## 📦 Installazione

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# una versione modificata di gaussian splatting (+ rendering profondità, alpha)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# altre dipendenze
pip3 install -r requirements.txt
```

## 🤖 Modelli Preaddestrati

Forniamo i seguenti modelli preaddestrati:

| Modello | Descrizione | Parametri | Download |
| --- | --- | --- | --- |
| TexGaussian-bench | Modello incondizionato texture RGB addestrato su ShapeNet bench | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Modello incondizionato texture RGB addestrato su ShapeNet car | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Modello incondizionato texture RGB addestrato su ShapeNet chair | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Modello incondizionato texture RGB addestrato su ShapeNet table | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Modello PBR condizionato dal testo addestrato su Objaverse | 295M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Inferenza

### Materiale PBR
Per la generazione di materiali PBR condizionata dal testo, eseguire
```bash
bash inference_for_PBR_material.sh
```
Dopo il baking della texture e del materiale, otterrai due mappe: una è la mappa albedo e l'altra è la mappa materiale PBR. In particolare, la mappa materiale PBR contiene tre canali: il canale verde rappresenta il valore di roughness e il canale blu rappresenta il valore metallic. Per eseguire il rendering PBR delle texture e delle mappe materiali generate, si consiglia di utilizzare [questo script di rendering](https://github.com/ymxbj/BlenderToolboxPBR) scritto in bpy.

Inoltre, consigliamo a tutti di imitare lo stile dei testi del dataset Cap3D e creare i propri prompt per ottenere risultati migliori. Il dataset Cap3D può essere scaricato da [qui](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true).

### Texture RGB
Per la generazione di texture RGB incondizionata, che funziona solo per le seguenti 4 categorie: bench, car, chair, table, eseguire
```bash
bash inference_for_RGB_texture.sh
```
Dopo il baking della texture, otterrai una mappa albedo.

## 🏋️‍♂️ Addestramento
Per Objaverse:
```bash
bash train_for_objaverse.sh
```

Per ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] Rilascio codice di addestramento e inferenza
- [x] Rilascio modello pre-addestrato solo albedo incondizionato su ShapeNet Dataset
- [x] Rilascio modello pre-addestrato PBR condizionato da testo su Objaverse Dataset
- [ ] Rilascio dataset e toolkit del dataset

## 📚Ringraziamenti

Questo lavoro si basa su numerosi straordinari lavori di ricerca e progetti open-source. Un grande ringraziamento a tutti gli autori per la condivisione!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) e [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Citazione

Se trovi utile questo lavoro, considera di citare il nostro articolo:

1. Versione arXiv
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. Versione CVPR
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
    title     = {TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
    booktitle = {Proceedings of the Computer Vision and Pattern Recognition Conference (CVPR)},
    month     = {June},
    year      = {2025},
    pages     = {551-561}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---