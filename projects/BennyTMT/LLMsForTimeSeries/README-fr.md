# Les modèles de langage sont-ils réellement utiles pour la prévision des séries temporelles ? 

**(NeurIPS 2024 Spotlight)** 🌟 [Lien vers l’article](https://arxiv.org/pdf/2406.16964) 

Dans ce travail, nous avons montré que malgré la popularité récente des grands modèles de langage (LLM) dans la prévision des séries temporelles (TSF), ils ne semblent pas améliorer significativement les performances. Une simple méthode de base, "PAttn," a été proposée, qui a surpassé la plupart des modèles TSF basés sur les LLM. 

Auteurs : [Mingtian Tan](https://x.com/MTTan1203),[Mike A. Merrill](https://mikemerrill.io/),[Vinayak Gupta](https://gvinayak.github.io/),[Tim Althoff](https://homes.cs.washington.edu/~althoff/),[Thomas Hartvigsen](https://www.tomhartvigsen.com/)

### Les LLM autoregressifs ont un grand potentiel pour exploiter le contexte afin de raisonner (prédire) les séries temporelles futures. Les modèles de prévision des séries temporelles mentionnés dans cet article ne le font pas.

Pour raisonner (prédire) les séries temporelles via du texte, vous pouvez vous référer à ce [travail sur le raisonnement (prévision) des séries temporelles](https://github.com/behavioral-data/TSandLanguage/tree/main/text_aid_forecast).

## Aperçu 💁🏼
Les travaux récents en analyse des séries temporelles se sont de plus en plus concentrés sur l’adaptation des grands modèles de langage préentraînés (LLM) pour la **prévision (TSF)**, la classification, et la détection d’anomalies. Ces études suggèrent que les modèles de langage, conçus pour les dépendances séquentielles dans le texte, pourraient se généraliser aux données de séries temporelles. Bien que cette idée soit en accord avec la popularité des modèles de langage en apprentissage automatique, les liens directs entre modélisation du langage et TSF restent flous. **Quelle est l’utilité des modèles de langage pour les tâches traditionnelles de TSF ?**

À travers une série d’études d’ablation sur trois méthodes récentes **TSF basées sur LLM**, nous avons constaté que **supprimer la composante LLM ou la remplacer par une simple couche d’attention ne dégradait pas les résultats — dans de nombreux cas, cela conduisait même à des améliorations.** De plus, nous avons introduit PAttn, montrant que les structures de patching et d’attention peuvent égaler les performances des meilleurs prévisionnistes basés sur LLM.

![Ablations/PAttn](https://raw.githubusercontent.com/BennyTMT/LLMsForTimeSeries/main/pic/ablations.png)

## Jeu de données 📖
Vous pouvez accéder aux jeux de données bien pré-traités depuis [Google Drive](https://drive.google.com/file/d/1NF7VEefXCmXuWNbnNe858WvQAkJ_7wuP/view), puis placer les contenus téléchargés sous ./datasets

## Installation 🔧
Trois méthodes populaires différentes basées sur LLM pour la TSF ont été incluses dans notre approche d’ablation. Vous pouvez suivre les dépôts correspondants, [OneFitsAll](https://github.com/DAMO-DI-ML/NeurIPS2023-One-Fits-All), [Time-LLM](https://github.com/KimMeen/Time-LLM), et [CALF](https://github.com/Hank0626/CALF), pour configurer l’environnement respectivement. Pour la méthode **''PAttn''**, l’environnement de n’importe lequel des dépôts ci-dessus est compatible.


## PAttn 🤔
La principale différence entre **PAttn** et [PatchTST](https://github.com/yuqinie98/PatchTST) est que nous avons progressivement retiré des parties du module Transformer qui peuvent ne pas être aussi essentielles, ainsi que l’Encodage de Position. Pour plus d’explications, veuillez consulter [cette réponse](https://github.com/BennyTMT/LLMsForTimeSeries/issues/7).

**Motivation** : Lorsque [DLinear](https://github.com/cure-lab/LTSF-Linear) a été surpassé par de nombreuses nouvelles méthodes, nous visons à fournir une méthode basée sur le patching qui soit à la fois simple et efficace, servant de référence basique.

     cd ./PAttn 

     bash ./scripts/ETTh.sh (pour ETTh1 & ETTh2)
     bash ./scripts/ETTm.sh (pour ETTm1 & ETTm2)
     bash ./scripts/weather.sh (pour Weather)
     
#### Pour les autres jeux de données, veuillez changer le nom du script dans la commande ci-dessus.

## Ablations
     
#### Exécuter les ablations sur CALF (ETT) :
     
    cd ./CALF
    sh scripts/long_term_forecasting/ETTh_GPT2.sh
    sh scripts/long_term_forecasting/ETTm_GPT2.sh
    
    sh scripts/long_term_forecasting/traffic.sh 
    (Pour d’autres jeux de données, comme traffic)

#### Exécuter les ablations sur OneFitsAll (ETT) :
     cd ./OFA
     bash ./script/ETTh_GPT2.sh   
     bash ./script/ETTm_GPT2.sh

     bash ./script/illness.sh 
     (Pour d’autres jeux de données, comme illness)

#### Exécuter les ablations sur Time-LLM (ETT) 
     cd ./Time-LLM-exp
     bash ./scripts/train_script/TimeLLM_ETTh1.sh
     bash ./scripts/train_script/TimeLLM_ETTm1.sh 

     bash ./scripts/train_script/TimeLLM_Weather.sh
     (Pour d’autres jeux de données, comme Weather)

#### (Pour exécuter des ablations sur d’autres jeux de données, veuillez changer le nom du jeu de données comme indiqué dans l’exemple.)

## Remerciements

Cette base de code est construite à partir de la [Time-Series-Library](https://github.com/thuml/Time-Series-Library). Merci !


## Citation
Si vous trouvez notre travail utile, merci de bien vouloir citer notre travail comme suit :
```bibtex
@inproceedings{tan2024language,
    title={Les modèles de langage sont-ils réellement utiles pour la prévision des séries temporelles ?},
    author={Tan, Mingtian et Merrill, Mike A et Gupta, Vinayak et Althoff, Tim et Hartvigsen, Thomas},
    booktitle={Neural Information Processing Systems (NeurIPS)},
    year={2024}
}

```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---