# DyberPet - Version Genshin Impact

> [!IMPORTANT]
> ## ⚠️ Ce dépôt n'est plus maintenu, veuillez passer à la nouvelle version DyberPet
>
> **La version Genshin Impact de DyberPet a été fusionnée il y a plusieurs années dans le nouveau cadre [DyberPet](https://github.com/ChaozhongLiu/DyberPet).**
>
> Ce dépôt ne sera plus mis à jour et son utilisation n'est plus recommandée.  
> Il suffit désormais d’emporter le dossier des personnages pour migrer vers la nouvelle version DyberPet et profiter de plus de fonctionnalités.
>
> 👉 **Veuillez vous rendre sur le nouveau dépôt : [ChaozhongLiu/DyberPet](https://github.com/ChaozhongLiu/DyberPet)**

----
[![Licence](https://img.shields.io/github/license/ChaozhongLiu/DyberPet.svg)](LICENSE)
![Version DyberPet](https://img.shields.io/badge/DyberPet-v0.2.2-green.svg)  
DyberPet (呆啵宠物) version Genshin Impact est un compagnon de bureau basé sur le cadre [DyberPet](https://github.com/ChaozhongLiu/DyberPet), la partie artistique a été réalisée par [@栎曦_Nuo](https://space.bilibili.com/14004864).  

🆕 **La version UI refondue** est désormais disponible sur la [page principale de DyberPet](https://github.com/ChaozhongLiu/DyberPet) ! La nouvelle version inclut la sauvegarde des archives, l’ajout de personnages, une UI plus conviviale, n’hésitez pas à essayer et à donner votre avis !

Si vous aimez cette application compagnon, cliquez sur l’étoile en haut à droite :star:**Star**, cela nous encouragera beaucoup à continuer le développement !  
De plus, de nouveaux personnages, objets et fonctionnalités seront ajoutés progressivement, suivez [@栎曦_Nuo](https://space.bilibili.com/14004864) et ce dépôt pour rester à jour.

Si vous rencontrez des problèmes lors de l’utilisation, vous pouvez me contacter en message privé [@哦哟喔嚯](https://space.bilibili.com/39307302) ou ouvrir une issue sur la [page Issues](https://github.com/ChaozhongLiu/DyberPet_GenshinImpact/issues).

:warning:  ~~Récemment, je suis occupé par la soutenance de doctorat et la recherche d’emploi, le cadre ne pourra pas être mis à jour rapidement, désolé. La maintenance et les corrections devraient reprendre mi-octobre.~~ :beers:  
Une nouvelle refonte UI est en cours, ainsi que l’ajout de fonctionnalités pratiques, les mises à jour peuvent être lentes, merci de votre compréhension !

  
Pour la version **en anglais et autres langues** de l’application, veuillez consulter notre [version Alpha de DyberPet](https://github.com/ChaozhongLiu/DyberPet/releases/tag/v0.3.0a).  
Merci de :star:**Star** pour recevoir les prochaines mises à jour !



## Expérience rapide
### Utilisateurs Windows
  **Première utilisation** : téléchargez ce dépôt [ici](https://github.com/ChaozhongLiu/DyberPet_GenshinImpact/archive/refs/heads/main.zip), décompressez-le puis double-cliquez sur **``DyberPet-Genshin.exe``**  
  (Le programme .exe ne peut pas être déplacé hors du dossier, mais vous pouvez créer un raccourci sur le bureau)
  
  
  **Mise à jour de la version** : si vous utilisez déjà DyberPet, remplacez les anciens fichiers par la dernière version téléchargée [ici](https://github.com/ChaozhongLiu/DyberPet_GenshinImpact/archive/refs/heads/main.zip)  
  (Tout écraser, le dossier ``data`` sera conservé, les données ne seront pas perdues)
  
  **Baidu Netdisk** : [Lien](https://pan.baidu.com/s/1dLY0ZfFcTRySuU4tXv1-pA?pwd=bs1d) | Code d'extraction : bs1d  
  **Quark Netdisk** : [Lien](https://pan.quark.cn/s/a070df462217) | Code d'extraction : 7RD4

### Utilisateurs Linux / MacOS
  
  **Version bêta Mac**  
  **Quark Netdisk** : [Lien](https://pan.quark.cn/s/6386f4b5efc9) | Code d'extraction : D3VR  
  Rejoignez le groupe pour signaler les bugs et poser des questions, et obtenir les dernières mises à jour ! ``233305772``  
  **Q : Le programme est corrompu, il ne s’ouvre pas** :   
  **R :** C’est un problème d’autorisations des applications tierces, ce n’est pas une véritable corruption. Pour résoudre, veuillez consulter : https://macoshome.com/course/1699.html
  
  Vous pouvez également utiliser [cette méthode](https://www.bilibili.com/read/cv21890026) (merci à l’utilisateur Bilibili [@洛天依_Linux](https://space.bilibili.com/495653264))
  

## Manuel utilisateur
Veuillez consulter ce [manuel utilisateur simplifié](https://raw.githubusercontent.com/ChaozhongLiu/DyberPet_GenshinImpact/main/用户手册.pdf), ou regarder la [vidéo Bilibili](https://www.bilibili.com/video/BV1fd4y1W7ht) pour découvrir les fonctionnalités actuelles.


## Journal des mises à jour

<details>
  <summary>Liste des mises à jour des versions</summary>
  
**  **
  
**v0.2.2 - 03/05/2023**
- Modification de la structure des données des animations permanentes, correction de bugs  
- Les compagnons ont désormais une détection d’animations permanentes, doit être configuré lorsque c’est l’animal principal
  
**v0.2.2 - 03/05/2023**
- Nouveau personnage : Xiao  
- Ajout de la fonction de suivi du curseur de la souris  
- Ajout dans le menu contextuel d’une option d’animation permanente, permettant de changer l’animation par défaut en veille ; lorsqu’elle est sélectionnée, les autres animations ne seront plus jouées aléatoirement  
- Le sac a été divisé en deux sections : nourriture et objets de collection
  
**v0.2.1 - 23/02/2023**
- Optimisation du mécanisme de zoom  
- Le nombre d’objets n’est pas affiché lorsqu’il est égal à 1
- Optimisation de la méthode de détermination de la liste principale des animaux de compagnie et de la sauvegarde de l’animal de compagnie par défaut
  
**v0.2.0 - 22/02/2023**
- Ajout de la compensation des récompenses de niveau d’affection
- Le Vagabond et Nahida ont chacun ajouté 4 ensembles de dialogues, disponibles aux niveaux d’affection 2, 3, 4 et 5
  
**v0.2.0 - 19/02/2023**
- Réduction de la taille de Nahida
- Correction du bug d’activation/désactivation du temps d’accompagnement lors du changement de personnage
  
**v0.2.0 - 18/02/2023**
- Nouveau personnage - Le Vagabond
- Limite maximale du niveau d’affection ajustée à 8 (roulez ça doge)
- Ajout de la sélection du personnage par défaut au démarrage dans les paramètres
  
**v0.1.19 - 16/02/2023**
- Possibilité de mettre en sourdine dans les paramètres
- Ajout du suivi des jours d’accompagnement et de l’affichage de la plaque nominative
- Ajout automatique d’un bouton "étape précédente" dans les boîtes de dialogue (matériel non encore implémenté)
- Ajustement du calcul de la longueur pour certains caractères chinois spéciaux
  
**v0.1.18 - 11/02/2023**
- Ajout de la connexion entre animal de compagnie principal et secondaire
- Garantie que les objets de collection ne se répètent pas dans les drops aléatoires
- Organisation des valeurs système modifiables
  
**v0.1.18 - 11/02/2023**
- Correction de l’erreur d’affichage du bouton d’inventaire lors du rappel de Paimon via le menu clic droit
  
**v0.1.18 - 10/02/2023**
- Ajout de l’interface et des fonctionnalités de dialogue (matériel non encore implémenté)
- Ajout d’un attribut aux objets : ``pet_limit`` qui définit que l’objet n’apparaît que pour un certain animal de compagnie (préparation pour plusieurs personnages à venir)
  
**v0.1.17 - 06/02/2023**
- Les emplacements d’inventaire des objets de collection sont en haut, avec un fond bleu clair
- L’utilisation des objets de collection peut être annulée dans l’inventaire (par exemple, si Paimon est perdu à cause d’un bug, elle peut être rappelée depuis l’inventaire)
  
**v0.1.17 - 05/02/2023**
- Ajout de l’attribut ``sound_priority`` pour la priorité des sons dans le système de notification
- Ajout d’événements vocaux aléatoires lors du clic
- Ajout de la bibliothèque vocale de Nahida

**v0.1.16 - 02/02/2023**
- Correction du problème d'ancrage des actions des compagnons
- Support complet du multi-écran (en test)

**v0.1.15 - 02/01/2023**
- Correction du changement de taille de Paimon lors de l'agrandissement de l'échelle de l'écran
- Correction du clignotement lors du glissement des accessoires
- Correction du problème d'affichage incomplet lors de l'agrandissement de l'appel des compagnons
- Correction du problème de position de Paimon animal de compagnie lors du zoom sous certaines conditions

**v0.1.15 - 01/31/2023**
- Contournement du bug de plantage lié au temps de concentration à 0 minutes 0 secondes
- Résolution du gros bug des objets de frénésie indicible
- Le bouton d'arrêt devient immédiatement inactif après appui pour éviter plusieurs calculs
- Correction du bug de clignotement causé par un léger déplacement lors du clic rapide de la souris

**v0.1.15 - 01/30/2023**
- Police de la barre de valeurs fixée à Times
- Ajout d'une option pour définir l'affichage en haut dans les paramètres
- Le temps de diminution de la satiété est passé à 4 minutes par unité
- Ajout des récompenses de montée de niveau pour les niveaux 3 et 4 d'affection
- Pour simplifier le processus de mise à jour, le dossier ``data`` a été supprimé et sera généré automatiquement au premier lancement.

**v0.1.14 - 01/29/2023**
- La valeur minimale de l'accélération gravitationnelle est passée à 0,01
- Suppression de l'influence du zoom d'écran sur la taille des animaux de compagnie, l'utilisateur peut régler cela dans les paramètres

**v0.1.14 - 01/28/2023**
- Correction du bug de détection des limites lors du changement de zoom
- Amélioration de la logique de sélection de la voix au démarrage

**v0.1.14 - 01/27/2023**
- Après quatre mois de développement, la version animal de compagnie Daibo - Genshin Impact est officiellement lancée !

</details>

## Rejoignez-nous  


Si vous souhaitez également développer un nouveau set d’images, d’animations et d’objets pour les animaux de compagnie, vous pouvez consulter le [document de développement des ressources](https://github.com/ChaozhongLiu/DyberPet/blob/main/docs/art_dev.md) qui est encore en cours d’élaboration. Vous êtes aussi invités à me contacter en message privé sur Bilibili [@哦哟喔嚯](https://space.bilibili.com/39307302) et [@栎曦_Nuo](https://space.bilibili.com/14004864) pour rejoindre notre équipe et créer ensemble !

Si vous souhaitez développer ensemble le framework des animaux de compagnie Daibo, n’hésitez pas à m’envoyer un message privé sur Bilibili [@哦哟喔嚯](https://space.bilibili.com/39307302) pour affronter ensemble les montagnes de code !

## Déclaration de droits d’auteur
- Les droits d’auteur des ressources des animaux de compagnie appartiennent à miHoYo, veuillez ne pas les utiliser commercialement !
- La découpe des ressources et la conception des animations proviennent de Bilibili [@栎曦_Nuo](https://space.bilibili.com/14004864). Merci de citer la source lors de la reproduction ou de l’utilisation.
- Daibo Pets suit la licence GPL v3.0, veuillez mentionner l’auteur GitHub@ChaozhongLiu lors du développement ou de l’utilisation.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---