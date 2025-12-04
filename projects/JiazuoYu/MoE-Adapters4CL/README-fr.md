# MoE-Adapters4CL
Code pour l'article "[**Boosting Continual Learning of Vision-Language Models via Mixture-of-Experts Adapters**](https://arxiv.org/abs/2403.11549)" CVPR2024.

## Table des matières
  - [Résumé](#Abstract)
  - [Approche](#Approach)
  - [Installation](#Install)
  - [Préparation des données](#Data-preparation)
  - [Prise en main](#getting-started)
    - [Checkpoint du modèle](#Model-ckpt)
    - [MTCL](#MTCL)
      - [Test](#Test)
      - [Entraînement](#Train)
    - [CIL](#CIL)
      - [Entraînement](#Train)
  - [Citation](#Citation)
  - [Remerciements](#Acknowledgement)

## Résumé
Continual learning can empower vision-language models to continuously acquire new knowledge, without the need for access to the entire historical dataset. However, mitigating the performance degradation in large-scale models is non-trivial due to (i) parameter shifts throughout lifelong learning and (ii) significant computational burdens associated with full-model tuning. In this work, we present a parameter-efficient continual learning framework to alleviate long-term forgetting in incremental learning with vision-language models. Our approach involves the dynamic expansion of a pre-trained CLIP model, through the integration of Mixture-of-Experts (MoE) adapters in response to new tasks. To preserve the zero-shot recognition capability of vision-language models, we further introduce a Distribution Discriminative Auto-Selector (DDAS) that automatically routes in-distribution and out-of-distribution inputs to the MoE Adapter and the original CLIP, respectively. Through extensive experiments across various settings, our proposed method consistently outperforms previous state-of-the-art approaches while concurrently reducing parameter training burdens by 60%. 
## Approche
___
![image exemple](https://raw.githubusercontent.com/JiazuoYu/MoE-Adapters4CL/MoE-Adapters/fig/framework.png)


## Installation
```bash
conda create -n MoE_Adapters4CL python=3.9
conda activate MoE_Adapters4CL
conda install pytorch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 pytorch-cuda=11.8 -c pytorch -c nvidia
cd cil
pip install -r requirements.txt
```
## Préparation des données  
Jeux de données cibles : Aircraft, Caltech101, CIFAR10, CIFAR100, DTD, EuroSAT, Flowers, Food, MNIST, OxfordPet, StanfordCars, SUN397, TinyImagenet.  

Si vous rencontrez des problèmes avec Caltech101, vous pouvez vous référer à [issue#6](https://github.com/JiazuoYu/MoE-Adapters4CL/issues/6).  

Plus de détails peuvent être consultés dans [datasets.md](https://raw.githubusercontent.com/JiazuoYu/MoE-Adapters4CL/MoE-Adapters/mtil%2Fdatasets.md) de [ZSCL](https://github.com/Thunderbeee/ZSCL). Un grand merci à eux pour leur travail remarquable !  
## Modèle ckpt  
|                  | Modèle                                                              | Lien |
|------------------|----------------------------------------------------------------------|---------------------------------------------------------------------- |
| full_shot_order1 | full_shot_order1_1000iters.pth                  | [Baidu Disk](https://pan.baidu.com/s/1brWYIMrv34fhdc4kC9B0_g?pwd=p3zp) / [Google Drive](https://drive.google.com/drive/folders/1f2GB2kmBYoxzWI9E33XqPnkIKrAB2fh9?usp=sharing)      |
| few_shot_order1  | few_shot_order1_1000iters.pth | [Baidu Disk](https://pan.baidu.com/s/1Z7q3tTLdRFN3zmtkj3_i4g?pwd=4edw) / [Google Drive](https://drive.google.com/drive/folders/1f2GB2kmBYoxzWI9E33XqPnkIKrAB2fh9?usp=sharing)       |
## MTCL  
### Phase de test  
Exemple :  
1. Déplacez les checkpoints dans MoE-Adapters4CL/ckpt  
2. ```cd MoE-Adapters4CL/mtil```  
3. Exécutez le script ```bash srcipts/test/Full_Shot_order1.sh ```  


### Phase d’entraînement  
Exemple :  
1. Déplacez les checkpoints dans MoE-Adapters4CL/ckpt  
2. ```cd MoE-Adapters4CL/mtil```  
3. Exécutez le script ```bash srcipts/train/train_full_shot_router11_experts22_1000iters.sh```  

## Apprentissage incrémental par classe  

### Phase d’entraînement  
Exemple :  
1. ```cd cil```  
2. ```bash run_cifar100-2-2.sh ```  

## Citation

```
@inproceedings{yu2024boosting,
  title={Boosting continual learning of vision-language models via mixture-of-experts adapters},
  author={Yu, Jiazuo and Zhuge, Yunzhi and Zhang, Lu and Hu, Ping and Wang, Dong and Lu, Huchuan and He, You},
  booktitle={Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition},
  pages={23219--23230},
  year={2024}
}
```
## Remerciements
Notre dépôt est construit sur [wise-ft](https://github.com/mlfoundations/wise-ft), [Continual-CLIP](https://github.com/vgthengane/Continual-CLIP/tree/master) et [ZSCL](https://github.com/Thunderbeee/ZSCL). Nous remercions les auteurs pour le partage de leurs codes.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-04

---