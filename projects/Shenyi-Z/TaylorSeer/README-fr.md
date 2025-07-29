<div align=center>
  
# [ICCV 2025] *TaylorSeer* : De la réutilisation à la prévision : Accélérer les modèles de diffusion avec *TaylorSeers*

<p>
<a href='https://arxiv.org/abs/2503.06923'><img src='https://img.shields.io/badge/Paper-arXiv-red'></a>
<a href='https://taylorseer.github.io/TaylorSeer/'><img src='https://img.shields.io/badge/Project-Page-blue'></a>
</p>

</div>

## 🔥 Actualités

* `2025/06/26` 💥💥 TaylorSeer a l'honneur d'être accepté par ICCV 2025 !

* `2025/05/03` 🚀🚀 TaylorSeer pour HiDream est publié.

* `2025/03/30` 🚀🚀 TaylorSeer pour Wan2.1 est publié.

* `2025/03/30` 🚀🚀 Les scripts d'inférence Diffusers pour TaylorSeers et les scripts xDiT applicables à l'inférence parallèle multi-GPU ont été officiellement publiés.

* `2025/03/10` 🚀🚀 Notre dernier travail "De la réutilisation à la prévision : Accélérer les modèles de diffusion avec TaylorSeers" est publié ! Les codes sont disponibles sur [TaylorSeer](https://github.com/Shenyi-Z/TaylorSeer) ! TaylorSeer supporte une compression sans perte à un taux de 4,99x sur FLUX.1-dev (avec une accélération de latence de 3,53x) et une accélération de haute qualité à un taux de compression de 5,00x sur HunyuanVideo (avec une accélération de latence de 4,65x) ! Nous espérons que *TaylorSeer* pourra faire évoluer le paradigme des méthodes de mise en cache des caractéristiques de la réutilisation à la prévision. Pour plus de détails, veuillez vous référer à notre dernier article de recherche.
* `2025/02/19` 🚀🚀 La solution ToCa pour **FLUX** a été officiellement publiée après ajustements, atteignant désormais jusqu'à **3,14× d'accélération sans perte** (en FLOPs) !
* `2025/01/22` 💥💥 ToCa a l'honneur d'être accepté par ICLR 2025 !
* `2024/12/29` 🚀🚀 Nous publions gratuitement notre travail [DuCa](https://arxiv.org/abs/2412.18911) sur l'accélération des transformateurs de diffusion, qui atteint une accélération quasi sans perte de **2,50×** sur [OpenSora](https://github.com/hpcaitech/Open-Sora) ! 🎉 **DuCa surmonte également la limitation de ToCa en supportant pleinement FlashAttention, permettant une compatibilité et des améliorations d'efficacité plus larges.**
* `2024/12/24` 🤗🤗 Nous publions un dépôt open-source "[Awesome-Token-Reduction-for-Model-Compression](https://github.com/xuyang-liu16/Awesome-Token-Reduction-for-Model-Compression)", qui rassemble les récents excellents articles sur la réduction de tokens ! N'hésitez pas à contribuer avec vos suggestions !
* `2024/12/10` 💥💥 Le travail récent de notre équipe, **SiTo** (https://github.com/EvelynZhang-epiclab/SiTo), a été accepté à **AAAI 2025**. Il accélère les modèles de diffusion grâce à la **pruning adaptative des tokens**.
* `2024/07/15` 🤗🤗 Nous publions un dépôt open-source "[Awesome-Generation-Acceleration](https://github.com/xuyang-liu16/Awesome-Generation-Acceleration)", qui rassemble les récents excellents articles sur l'accélération de génération ! N'hésitez pas à contribuer avec vos suggestions !

<details>
  <summary><strong>Résumé</strong></summary>

  Les Diffusion Transformers (DiT) ont révolutionné la synthèse d'images et de vidéos à haute fidélité, mais leurs exigences computationnelles restent prohibitives pour les applications en temps réel. Pour résoudre ce problème, la mise en cache des caractéristiques a été proposée pour accélérer les modèles de diffusion en mettant en cache les caractéristiques des pas de temps précédents puis en les réutilisant aux pas de temps suivants. Cependant, aux pas de temps avec des intervalles importants, la similarité des caractéristiques dans les modèles de diffusion diminue considérablement, entraînant une augmentation marquée des erreurs introduites par la mise en cache des caractéristiques, ce qui nuit fortement à la qualité de génération. Pour résoudre ce problème, nous proposons TaylorSeer, qui montre d'abord que les caractéristiques des modèles de diffusion aux pas de temps futurs peuvent être prédites à partir de leurs valeurs aux pas de temps précédents. Basé sur le fait que les caractéristiques changent lentement et continuellement au fil des pas de temps, TaylorSeer emploie une méthode différentielle pour approximer les dérivées d'ordre supérieur des caractéristiques et prédire les caractéristiques aux pas de temps futurs avec une expansion en série de Taylor. Des expériences approfondies démontrent son efficacité significative tant en synthèse d'images que de vidéos, particulièrement pour des taux d'accélération élevés. Par exemple, il atteint une accélération quasi sans perte de 4,99 $\times$ sur FLUX et 5,00 $\times$ sur HunyuanVideo sans entraînement supplémentaire. Sur DiT, il obtient un FID inférieur de $3,41$ comparé au précédent état de l'art à une accélération de $4,53$ $\times$.

</details>

## 🧩 Contributions de la communauté

Merci à tous les contributeurs open-source pour leur fort soutien ! Nous serions ravis d’avoir de vos nouvelles !

* ComfyUI-TaylorSeer-philipy1219 (inférence FP8 sur FLUX, plus de modèles vidéo à venir) : [ComfyUI-TaylorSeer-philipy1219](https://github.com/philipy1219/ComfyUI-TaylorSeer) par [philipy1219](https://github.com/philipy1219).

## 🛠 Installation

``` cmd
git clone https://github.com/Shenyi-Z/TaylorSeer.git
```

## TaylorSeer-FLUX

TaylorSeer a réalisé une compression computationnelle sans perte de 4,99 $\times$ et une accélération de latence de 3,53 $\times$ sur FLUX.1-dev, mesurées par [ImageReward](https://github.com/THUDM/ImageReward) pour une qualité globale. Pour exécuter TaylorSeer-FLUX, voir [TaylorSeer-FLUX](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-FLUX.md).

De plus, nous avons fourni des exemples de scripts d'inférence pour la **version diffusers**, ainsi que des scripts d'inférence **xDiT** en parallèle multi-GPU. Vous pouvez également réaliser des tests basés sur ceux-ci, situés respectivement à [TaylorSeers-Diffusers](./TaylorSeers-Diffusers ) et [TaylorSeers-xDiT](./TaylorSeers-xDiT).

## TaylorSeer-HunyuanVideo

TaylorSeer a atteint une compression computationnelle de 5,00 $\times$ et une remarquable accélération de latence de 4,65 $\times$ sur HunyuanVideo, mesurées de manière exhaustive par la métrique [VBench](https://github.com/Vchitect/VBench). Par rapport aux méthodes précédentes, il a démontré des améliorations significatives tant en efficacité d'accélération qu'en qualité. Pour exécuter TaylorSeer-HunyuanVideo, voir [TaylorSeer-HunyuanVideo](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-HunyuanVideo.md).

De plus, nos scripts prennent également en charge l'accélération parallèle multi-GPU mise en œuvre par HunyuanVideo utilisant xDiT. Dans ce cas, l'effet d'accélération apporté par le cache et celui du parallélisme multi-GPU sont indépendants l'un de l'autre et se multiplient, atteignant des effets d'accélération extrêmement élevés.

## TayorSeer-DiT

TaylorSeer a réalisé une compression computationnelle sans perte de 2,77 $\times$ sur le modèle de base DiT, évaluée de manière exhaustive par des métriques telles que le FID. Ses performances à divers ratios d'accélération ont largement surpassé les méthodes précédentes. Par exemple, dans un scénario extrême avec un ratio de compression de 4,53 $\times$, le FID de TaylorSeer n'a augmenté que de 0,33 par rapport à la référence non accélérée de 2,32, atteignant 2,65, tandis que ToCa et DuCa affichaient des scores FID supérieurs à 6,0 dans les mêmes conditions. Pour exécuter TaylorSeer-DiT, voir [TaylorSeer-DiT](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-DiT.md).

## TaylorSeer-Wan2.1

Nous avons implémenté la méthode d'accélération TaylorSeer sur Wan2.1, avec prise en charge de l'inférence parallèle multi-GPU. Les commandes d'installation et d'inférence pour TaylorSeer-Wan2.1 sont entièrement compatibles avec celles de Wan2.1. Pour exécuter TaylorSeer-Wan2.1, voir [TaylorSeer-Wan2.1](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-Wan2.1.md).

## TaylorSeer-HiDream

Le modèle de génération d'images récemment open source **HiDream**, malgré sa qualité de sortie impressionnante, fait face à des demandes croissantes d'accélération en raison de son temps d'inférence plus long. Nous avons appliqué **TaylorSeer** pour accélérer l'inférence de HiDream, réalisant une **réduction de 72 % du temps d'exécution**. Pour plus de détails, voir [TaylorSeer-HiDream](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/TaylorSeer-HiDream.md).

## 👍 Remerciements

- Merci à [DiT](https://github.com/facebookresearch/DiT) pour leur excellent travail et leur base de code sur laquelle nous avons construit TaylorSeer-DiT.
- Merci à [FLUX](https://github.com/black-forest-labs/flux) pour leur excellent travail et leur base de code sur laquelle nous avons construit TaylorSeer-FLUX.
- Merci à [HiDream](https://github.com/HiDream-ai/HiDream-I1) pour leur excellent travail et leur base de code sur laquelle nous avons construit TaylorSeer-HiDream.
- Merci à [HunyuanVideo](https://github.com/Tencent/HunyuanVideo) pour leur excellent travail et leur base de code sur laquelle nous avons construit TaylorSeer-HunyuanVideo.
- Merci à [Wan2.1](https://github.com/Wan-Video/Wan2.1) pour leur excellent travail et leur base de code sur laquelle nous avons construit TaylorSeer-Wan2.1.
- Merci à [ImageReward](https://github.com/THUDM/ImageReward) pour l'évaluation de la qualité texte-image.
- Merci à [VBench](https://github.com/Vchitect/VBench) pour l'évaluation de la qualité texte-vidéo.


## 📌 Citation


```bibtex
@article{TaylorSeer2025,
  title={From Reusing to Forecasting: Accelerating Diffusion Models with TaylorSeers},
  author={Liu, Jiacheng and Zou, Chang and Lyu, Yuanhuiyi and Chen, Junjie and Zhang, Linfeng},
  journal={arXiv preprint arXiv:2503.06923},
  year={2025}
}
```

## :e-mail: Contact

Si vous avez des questions, veuillez envoyer un courriel à [`shenyizou@outlook.com`](https://raw.githubusercontent.com/Shenyi-Z/TaylorSeer/main/mailto:shenyizou@outlook.com).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---