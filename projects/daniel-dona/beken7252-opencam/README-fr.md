# Beken7252 OpenCam
Projet alternatif RT-Thread pour caméras A9

# Mises à jour
## 25/09/25
J’ai terminé mon MSc et j’ai maintenant un peu plus de temps libre, avec encore beaucoup de ces caméras autour. Il est temps de planifier une première version officielle pour ce projet. Je travaille dessus depuis quelques semaines et j’ai actuellement une version précoce qui démarre, se connecte au Wi-Fi, lit et écrit sur la carte SD, supporte MQTT et surtout, fonctionne avec au moins 3 capteurs de caméra différents : GC0311, HI704 et GC0328. Cela inclut le stockage des images et le streaming via HTTP (avec multipart/x-mixed-replace).

Il nécessite encore des tests supplémentaires pour la stabilité et pour améliorer l’état général du SDK et du projet.

Consultez [ce ticket](https://github.com/daniel-dona/beken7252-opencam/issues/21) pour un plan détaillé de la version 1.0.0.

## 20/11/2023
Le mois dernier, j’attendais l’arrivée de quelques caméras A9 supplémentaires, car je n’en avais qu’une, et je craignais d’endommager le PCB avec ce soudage et dessoudage constant des fils de test.  
Eh bien, cela ne s’est pas passé comme prévu. J’ai reçu environ 12 caméras différentes car elles ne coûtaient qu’environ 3€ sur Aliexpress, et j’ai eu :

~6 avec une puce Beken

~3 avec une puce inconnue, qui semble être une sorte de XRadio/Allwinner personnalisée

~1 avec un autre vendeur dont je ne me souviens plus

~1 avec une puce sans aucun marquage

Oui, les chiffres ne s’additionnent pas très bien ; l’important est que j’ai eu plus avec la puce Beken… ou pas ?

La puce est marquée BK7252, mais le brochage est différent. La puce documentée et dont nous avons au moins une fiche technique a 68 broches ; celle-ci a 48 broches et la référence est BK7252UQN48.

Plus d’infos ici : https://github.com/daniel-dona/beken7252-opencam/wiki/BK7252-SoC-variations

Je ne vais pas travailler avec cette puce pour le moment. J’ai essayé de téléverser un code fonctionnel sur cette puce, et cela ne fonctionne pas comme prévu. Certainement, ils ont retiré certaines fonctionnalités, ou elles sont maintenant multiplexées différemment. Peut-être que les régions mémoire pour certains registres sont différentes, peut-être que je suis idiot, et que j’ai mal téléversé le code…

Dans tous les cas, je pense qu’il vaut mieux d’abord faire fonctionner quelque chose sur la puce connue, puis nous pourrons explorer cette nouvelle.

# SDK connus
- FreeRTOS : https://github.com/YanMinge/beken_freertos_sdk_release
- RT-Thread : https://github.com/YangAlex66/bdk_rtt et https://github.com/biemster/bdk_rtt_v3

# Sources et articles liés :
- [À FAIRE]


# À FAIRE

- Documenter les variantes de PCB et de capteurs
- Documenter les brochages des variantes de caméra
- Documenter la procédure de flashage (et de déblocage)
- Nettoyer le SDK Beken
- Migrer le code SDK vers GCC et Scons plus modernes
- Autres (?)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-29

---