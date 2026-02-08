# FFGO : First Frame est l’endroit idéal pour la personnalisation de contenu vidéo

**Dépôt officiel pour "First Frame est l’endroit idéal pour la personnalisation de contenu vidéo"**

**Anglais :**  
[[Site Web](http://firstframego.github.io)] | [[Article](https://arxiv.org/abs/2511.15700)] | [[🔴 YouTube : Vitrine Communautaire Non Officielle](https://www.youtube.com/watch?v=Dks3q5w7sdw)] | [[🔴 Démo Utilisateur Réel](https://github.com/kijai/ComfyUI-WanVideoWrapper/issues/1676)]

**中文 :**  
[[新智元](https://mp.weixin.qq.com/s/XQGmskJqqFdKx4vCc45tDA)] | [[bilibili](https://www.bilibili.com/video/BV1DQSzB9Eo7/)]


![teaser.gif](https://raw.githubusercontent.com/zli12321/FFGO-Video-Customization/main/./asset/git.gif)



### Bientôt disponible  
- Ajout du support officiel ComfyUI pour utiliser nos LoRAs entraînés, avec tous les paramètres configurés conformément à notre code d’inférence.  
- À faire : Publication des LoRAs pour des modèles de base de plus petite taille - Hunyuan 1.5 8B ou Wan2.2 5B


**🤗 Adaptateurs Lora sur Huggingface :**  
- [FFGO-Lora-Adapter](https://huggingface.co/Video-Customization/FFGO-Lora-Adapter)


#### Exemple de données d’entraînement  
- **Veuillez noter que nous fournissons actuellement seulement un sous-ensemble de nos 50 vidéos d’entraînement pour démontrer le format des données.**

- Consultez le dossier ```/Data/train/```

### Installation  
- Créer l’environnement
```
conda create -n ffgo python=3.11
conda activate ffgo
```
- Cloner le dépôt et configurer

```
git clone https://github.com/zli12321/FFGO-Video-Customization.git
cd FFGO-Video-Customization
bash setup.sh
```


### Test data
- Test data is available in [Data](https://github.com/zli12321/FFGO-Video-Customization/tree/main/Data/combined_first_frames) folder. All test data involving personal portrait rights has been removed. [0-data.csv](https://github.com/zli12321/FFGO-Video-Customization/blob/main/Data/combined_first_frames/0-data.csv) has the input image path and the caption to generate the video.
- Test data materials are available in [data_materials](https://github.com/zli12321/FFGO-Video-Customization/tree/main/Data/data_materials) folder. These are materials that can form the final input image for video generations.
- Get your own test data: find any images online and segment out the elements as RGBA layer, then combine it with a background using our [combine script]().


### Running Inference

- **When running on your own data, make sure to append our learned transition phrase, "ad23r2 the camera view suddenly changes. ", to your text prompt to ensure the model behaves correctly.**

- **All video results in the paper are generated at 1280 × 720 resolution with 81 frames, which requires an H200 GPU for inference unless memory-saving techniques are applied. For lower resource usage, 640 × 480 resolution videos can be generated without H200. However outputs at this lower resolution can differ significantly in content from the 1280 × 720 results as we shown in the paper.**

- **We are using H200 (141GB RAM) to run inference. If you are using A100 or H100, the memory saving such as cpu offload features need to be turned on.**

1. Download [Wan2.2-I2V-14B](https://huggingface.co/Wan-AI/Wan2.2-I2V-A14B) from huggingface or modelscope and download our Lora adapters. 

```bash
bash download.sh
```


2. Run fun demo video inference

```
bash ./example_single_inference.sh
```
3. Exécutez une inférence continue sur notre jeu de données de test exemple

```
bash example_inference.sh
```

<!-- 
4. Run 4 Step Lora speedup (Will cause quality degrade and inconsistency.)

```
bash ./example_4_step_lora_inference.sh
``` -->


### Citation
```
@article{chen2025first,
  title={First Frame Is the Place to Go for Video Content Customization},
  author={Chen, Jingxi and Li, Zongxia and Liu, Zhichao and Shi, Guangyao and Wu, Xiyang and Liu, Fuxiao and Fermuller, Cornelia and Feng, Brandon Y and Aloimonos, Yiannis},
  journal={arXiv preprint arXiv:2511.15700},
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-08

---