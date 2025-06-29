# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Site Web：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Langues : [简体中文](./README.zh.md) | English

## Résumé

----

L’idée de cette extension provient de [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), tout le code a été réécrit. Compatible avec tous les paquets vocaux, et ajoute de nouvelles fonctionnalités.

## Remerciements Spéciaux

---

1. L’extension inclut le paquet vocal chinois de [@justkowalski](https://github.com/JustKowalski). Vous pouvez [obtenir plus de paquets vocaux sur github](https://github.com/topics/rainbow-fart) 
2. L’extension inclut cmdmp3win.exe, provenant de [@James K. Lawless](http://jiml.us) 
3. Le modèle waifu par défaut provient de [@二夏](https://erxia207.lofter.com). Si vous souhaitez concevoir une waifu originale qui vous appartient, contactez-la. 
4. L’extension inclut un autre modèle waifu nommé keysoban, open source par [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Obtenez plus de modèles Waifu](https://github.com/ezshine/live2d-model-collections)

## Plateformes supportées

---

~~~~
Supporté uniquement sur MacOS et Windows10
~~~~

## Q&R

---

#### _La waifu ne s’affiche pas ?_
> R : Vous devez [télécharger](https://github.com/ezshine/live2d-model-collections) le conteneur waifu. Après avoir extrait tous les fichiers du zip, exécutez liv2dplayer.exe, affichez la liste des commandes dans vscode, essayez de changer de modèle waifu.

## Manuel, Commandes

---

🌈 Afficher les commandes Rainbow Fart Waifu

- "Changer de paquet vocal"
- "Changer de modèle Waifu"
- "Ouvrir le répertoire de ressources"

> Si vous téléchargez un paquet vocal ou un paquet de modèle, vous devez utiliser cette commande pour ouvrir le répertoire de ressources et placer ces paquets dans ce chemin

- "Télécharger le conteneur Waifu et plus de ressources"

## Fonctionnalités

---

1. Suppression du WebUI, lecture du fichier audio avec 'afplay' sur MacOS et 'cmdmp3win' sur Windows10. 
2. Interaction avec WaifuContainer, mettez une waifu virtuelle sur votre bureau pour accompagner votre programmation.

## Remarques sur les paquets vocaux

---

~~~~
Quelques remarques pour personnaliser un paquet vocal ou utiliser un paquet vocal téléchargé sur Internet
~~~~

1. Utilisez 'contributes.json' et non 'manifest.json'.
2. Ajoutez des textes dans 'contributes.json' pour correspondre au contenu vocal.

~~~~javascript
"contributes": [
    {
        "keywords": ["function", "=>", "func ", "def "],
        "voices":[
            "function_01.mp3",
            "function_02.mp3",
            "function_03.mp3"
        ],
        "texts":[
            "Waouh, ta fonction callback est vraiment géniale !",
            "Que penses-tu de nommer cette fonction avec mon nom ?",
            "Même la fonction la plus puissante n’exécutera jamais mon amour pour toi !"
        ]
    }
]
~~~~

## Soutenez-moi

---

Si cette extension rend votre programmation plus joyeuse, puis-je avoir un coca ?

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)


**Profitez-en !**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---