# SongGen : Un transformeur auto-régressif à étape unique pour la génération de chansons à partir de texte

🚀🚀🚀 Implémentation officielle de **SongGen : Un transformeur auto-régressif à étape unique pour la génération de chansons à partir de texte**
<p align="center" style="font-size: 1 em; margin-top: -1em">
<a href="https://scholar.google.com/citations?user=iELd-Q0AAAAJ">Zihan Liu</a>,  
<a href="https://mark12ding.github.io/">Shuangrui Ding</a>,  
<a href="https://github.com/rookiexiong7/">Zhixiong Zhang</a>, 
<a href="https://lightdxy.github.io/">Xiaoyi Dong</a>,  
<a href="https://panzhang0212.github.io/">Pan Zhang</a>,
<a href="https://yuhangzang.github.io/">Yuhang Zang</a>,  
<a href="https://scholar.google.com/citations?user=sJkqsqkAAAAJ">Yuhang Cao</a>, </br>  
<a href="http://dahua.site/">Dahua Lin</a>,  
<a href="https://myownskyw7.github.io/">Jiaqi Wang</a> 
</p>

<p align="center" style="font-size: 5 em; margin-top: 0.5em">
<a href="https://arxiv.org/abs/2502.13128"><img src="https://img.shields.io/badge/arXiv-<color>"></a>
<a href="https://github.com/LiuZH-19/SongGen"><img src="https://img.shields.io/badge/Code-red"></a>
<a href="https://liuzh-19.github.io/SongGen/"><img src="https://img.shields.io/badge/Demo-20d67c"></a>
<a href="https://huggingface.co/collections/LiuZH-19/songgen-a-single-stage-auto-regressive-transformer-for-text-6867ec21169d808034f6d252">
    <img src="https://img.shields.io/badge/HF-Collection-yellow"></a>
</p>





## 📜 Actualités
🚀 [2025/7/4] Nous avons publié le code d'entraînement avec un [guide détaillé](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/./training/README.md).

🚀 [2025/6/30] Le jeu de test MusicCaps est désormais disponible sur [Huggingface🤗](https://huggingface.co/datasets/LiuZH-19/MusicCaps_Test_Song) pour l’évaluation texte-à-chanson.

🚀 [2025/6/27] Nous avons publié le checkpoint de SongGen Interleaving (A-V) sur [Huggingface🤗](https://huggingface.co/LiuZH-19/SongGen_interleaving_A_V).

🎉 [2025/5/1] SongGen est accepté à ICML 2025 !

🚀 [2025/3/18] Nous avons publié le checkpoint de SongGen Mixed_Pro sur [Huggingface🤗](https://huggingface.co/LiuZH-19/SongGen_mixed_pro).

🚀 [2025/2/19] Le [papier](https://arxiv.org/abs/2502.13128) et la [page de démonstration](https://liuzh-19.github.io/SongGen/) sont publiés !

## 💡 Points forts
- 🔥Nous présentons SongGen, un transformeur auto-régressif **à étape unique** pour la génération **texte-à-chanson**, offrant un contrôle polyvalent via les paroles, un texte descriptif, et une voix de référence optionnelle.
- 🔥SongGen supporte à la fois les modes **mixte** et **double-piste** pour répondre à des besoins divers. Nos expériences fournissent des **insights précieux** pour optimiser les deux modes.
- 🔥En publiant les **poids du modèle**, le **code**, les **données annotées** et le **pipeline de prétraitement**, nous visons à établir une base simple mais efficace pour les futures recherches en génération de chansons.
<!-- <img align="center" src="https://raw.githubusercontent.com/LiuZH-19/SongGen/master/assets/imgs/motivation1.jpg" style="  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 50%;" /> -->

## 👨‍💻 À faire
- [ ] Publier les données annotées et le pipeline de prétraitement
- [x] Publier le jeu de test Musiccaps
- [x] Publier le code d’entraînement SongGen
- [x] Publier le checkpoint SongGen (Interleaving A-V)
- [x] Publier le checkpoint SongGen Mixed_pro
- [x] Publier le code d’inférence SongGen
- [x] Démo SongGen

## 🛠️ Utilisation

### 1. Installer l’environnement et les dépendances
```bash
git clone https://github.com/LiuZH-19/SongGen.git
cd SongGen
# We recommend using conda to create a new environment.
conda create -n songgen_env python=3.9.18 
conda activate songgen_env
# Install CUDA >= 11.8 and PyTorch, e.g.,
pip install torch==2.3.0 torchvision==0.18.0 torchaudio==2.3.0 --index-url https://download.pytorch.org/whl/cu118
pip install flash-attn==2.6.1 --no-build-isolation
```
Pour utiliser SongGen uniquement en mode inférence, installez-le en utilisant :
```bash
pip install -e .
```
### 2. Télécharger le xcodec

Téléchargez le point de contrôle X-Codec depuis [🤗](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/
https://huggingface.co/ZhenYe234/xcodec/blob/main/xcodec_hubert_general_audio_v2.pth) et placez-le dans le répertoire suivant : SongGen/songgen/xcodec_wrapper/xcodec_infer/ckpts/general_more

```
xcodec_infer
    ├── ckpts
    │   └── general_more
    │       ├── config_hubert_general.yaml
    │       └── xcodec_hubert_general_audio_v2.pth

```

### 3. Exécuter l'inférence

#### (1). Mode Pro Mixte

```python
import torch
import os
from songgen import (
    VoiceBpeTokenizer,
    SongGenMixedForConditionalGeneration,
    SongGenProcessor
)
import soundfile as sf

ckpt_path = "LiuZH-19/SongGen_mixed_pro" # Path to the pretrained model
device = "cuda:0" if torch.cuda.is_available() else "cpu"
model = SongGenMixedForConditionalGeneration.from_pretrained(
    ckpt_path,
    attn_implementation='sdpa').to(device)
processor = SongGenProcessor(ckpt_path, device)

# Define input text and lyrics
lyrics = "..." # The lyrics text
text = "..." # The music description text
ref_voice_path = 'path/to/your/reference_audio.wav' # Path to reference audio, optional
separate= True # Whether to separate the vocal track from the reference voice audio

model_inputs = processor(text=text, lyrics=lyrics, ref_voice_path=ref_voice_path, separate=separate) 
generation = model.generate(**model_inputs,
                do_sample=True,
            )
audio_arr = generation.cpu().numpy().squeeze()
sf.write("songgen_out.wav", audio_arr, model.config.sampling_rate)
```



#### (2). Interleaving A-V  (Dual-track mode)
```python
import torch
import os
from songgen import (
    VoiceBpeTokenizer,
    SongGenDualTrackForConditionalGeneration,
    SongGenProcessor
)
import soundfile as sf

ckpt_path = "LiuZH-19/SongGen_interleaving_A_V" # Path to the pretrained model
device = "cuda:0" if torch.cuda.is_available() else "cpu"
model = SongGenDualTrackForConditionalGeneration.from_pretrained(
    ckpt_path,
    attn_implementation='sdpa').to(device)
processor = SongGenProcessor(ckpt_path, device)

# Define input text and lyrics
lyrics = "..." # The lyrics text
text = "..." # The music description text
ref_voice_path = 'path/to/your/reference_audio.wav' # Path to reference audio, optional
separate= True # Whether to separate the vocal track from the reference voice audio

model_inputs = processor(text=text, lyrics=lyrics, ref_voice_path=ref_voice_path, separate=True) 
generation = model.generate(**model_inputs,
                do_sample=True,
            )

acc_array = generation[0].cpu().numpy()
vocal_array = generation[1].cpu().numpy()
min_len =min(vocal_array.shape[0], acc_array.shape[0])
acc_array = acc_array[:min_len]
vocal_array = vocal_array[:min_len]
audio_arr = vocal_array + acc_array
sf.write("songgen_out.wav", audio_arr, model.config.sampling_rate)
```

### 4. Entraînement

Le [dossier d'entraînement](./training) contient toutes les informations pour entraîner ou affiner votre propre modèle SongGen. Consultez le [guide d'entraînement](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/./training/README.md) pour des instructions étape par étape.



## ❤️ Remerciements
Cette bibliothèque s'appuie sur plusieurs géants open-source, auxquels nous souhaitons adresser nos plus chaleureux remerciements pour avoir fourni ces outils !

Remerciements particuliers à :

- [Parler-tts](https://github.com/huggingface/parler-tts) : La base de code sur laquelle nous nous sommes appuyés. 
- [X-Codec](https://github.com/zhenye234/xcodec) : Le codec audio utilisé dans notre recherche.
- [lp-music-caps](https://github.com/seungheondoh/lp-music-caps) : Un projet visant à générer des légendes pour la musique. 

Nous apprécions profondément tout le soutien reçu au cours de cette aventure.

## ☎️ Limites et travaux futurs

Il s'agit d'un **travail de recherche** axé sur la génération de **texte en chanson**. En raison des limites du jeu de données actuel, notre modèle est actuellement limité à la génération de chansons en anglais d'une durée maximale de 30 secondes.
Cependant, malgré un entraînement sur seulement **2k heures** de données avec un modèle de **1,3 milliard** de paramètres, notre approche a démontré une forte efficacité et un potentiel prometteur pour générer des chansons cohérentes et expressives. Nous croyons que l'augmentation des données et de la taille du modèle améliorera davantage l'alignement des paroles et la musicalité.
Cela dit, l'agrandissement du jeu de données est long et difficile. Nous accueillons volontiers collaborations et discussions pour explorer de nouvelles façons d'améliorer le modèle et d'étendre ses capacités.
Pour toute question ou collaboration potentielle, n'hésitez pas à contacter : Zihan Liu (liuzihan@pjlab.org.cn) et Jiaqi Wang (wangjiaqi@pjlab.org.cn).

## ✒️ Citation
Si vous trouvez notre travail utile pour votre recherche, merci de considérer mettre une étoile ⭐ et une citation 📝
```bibtex
@misc{liu2025songgen,
      title={SongGen: A Single Stage Auto-regressive Transformer for Text-to-Song Generation}, 
      author={Zihan Liu and Shuangrui Ding and Zhixiong Zhang and Xiaoyi Dong and Pan Zhang and Yuhang Zang and Yuhang Cao and Dahua Lin and Jiaqi Wang},
      year={2025},
      eprint={2502.13128},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2502.13128}, 
}

```







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---