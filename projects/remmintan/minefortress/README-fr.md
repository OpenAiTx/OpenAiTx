![le mod qui transformera votre Minecraft en stratégie en temps réel](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/main-banner.png)
# MineFortress
[![Soutenez le projet](https://img.shields.io/badge/PATREON-SUPPORT_THE_PROJECT-f96854?style=for-the-badge&logo=patreon&logoColor=f96854&labelColor=052d49&color=f96854)](https://www.patreon.com/minefortress)
[![Rejoindre Discord](https://img.shields.io/discord/906943962659561515?style=for-the-badge&logo=discord&label=discord&color=5865F2)](https://discord.gg/6rt7VJxPcq)
[![Site Web](https://img.shields.io/badge/website-minefortress-CC9966?style=for-the-badge)](https://minefortress.net/)

Le mod qui transforme votre Minecraft en RTS. Prenez le rôle d’un chef de village, rassemblez des ressources, construisez des maisons, engagez des professionnels pour développer et étendre votre village et même conquérir vos voisins ! Oubliez la vue à la première personne et contrôlez tout avec votre curseur de souris comme dans les jeux RTS classiques.
## Liens
* **[Site Web](https://minecraftfortress.org/)**
* **[Patreon](https://www.patreon.com/minefortress)**
* **[Modrinth](https://modrinth.com/mod/minefortress)**
* **[CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts)**
## Pour les joueurs
Ce dépôt est destiné aux développeurs. Si vous voulez jouer au mod, veuillez le télécharger depuis [CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts) ou [Modrinth](https://modrinth.com/mod/minefortress).

Le mod nécessite Fabric Loader et Fabric API pour fonctionner.
Suivez les instructions d’installation détaillées dans notre [wiki](https://wiki.minecraftfortress.org/wiki/Installation:Curseforge_Launcher).

## Pour les développeurs
### Prérequis
Je suppose que tous ceux qui souhaitent contribuer au projet sont familiers avec le développement Java/Kotlin en général.
Je ne détaillerai pas l’installation de la configuration de base pour développeur, mais je vais lister tous les outils nécessaires pour travailler sur le projet :
* Java 17 - Je préfère utiliser les builds [Adoptium](https://adoptium.net/)
* IntelliJ IDEA - Pour une expérience de développement la plus confortable et obtenir des résultats identiques aux miens, je recommande d’utiliser IntelliJ IDEA. Vous pouvez le télécharger [ici](https://www.jetbrains.com/idea/download/).
* Git - Pour cloner le dépôt et valider vos modifications. Vous pouvez le télécharger [ici](https://git-scm.com/downloads).

Si vous avez besoin d’aide pour configurer votre environnement de développement, veuillez lire les articles disponibles ici : [Développement Java avec IntelliJ IDEA](https://www.jetbrains.com/help/idea/getting-started.html)

N’hésitez pas à demander de l’aide sur notre [serveur Discord](https://discord.gg/6rt7VJxPcq).
### Premiers pas / Installation
1. Clonez le dépôt avec Git.
2. Assurez-vous que le projet est cloné dans un répertoire nommé `minefortress`. Cela est nécessaire pour que Gradle fonctionne correctement avec IDEA.
3. Ouvrez le projet dans IntelliJ IDEA.
4. Attendez que Gradle ait fini d’importer le projet.
5. Nous devons encore faire fonctionner les configurations de lancement. Le plugin Fabric le fera automatiquement, mais nous devons fermer le projet.
6. Fermez le projet et ouvrez-le à nouveau.
7. De nouvelles configurations de lancement devraient apparaître. Si ce n’est pas le cas, essayez de redémarrer IDEA.
8. Une configuration de lancement peut avoir une petite croix à côté. Cela signifie que le plugin Fabric a utilisé le mauvais module lors de la configuration.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-1.png)
9. Pour corriger cela, éditez la configuration et sélectionnez dans le menu déroulant du classpath du module `minefortress.main`.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-2.png)
10. Vous pouvez maintenant exécuter le projet en utilisant la configuration `Minecraft Client`.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-3.png)

### Contribution
Toute aide est grandement appréciée ! Si vous souhaitez contribuer au projet, veuillez suivre ces étapes :
1. Forkez le dépôt.
2. Créez une nouvelle branche à partir de la branche `master`.
3. Apportez vos modifications.
4. Committez vos modifications et poussez-les sur votre fork.
5. Créez une pull request vers la branche `master` de ce dépôt.

Il n’y a pas encore de guide de contribution, mais vous pouvez consulter les [issues](https://github.com/remmintan/minefortress/issues) pour trouver quelque chose sur lequel travailler.
J’essaierai de rassembler les bugs et demandes de fonctionnalités dans les issues, mais si vous avez des questions, n’hésitez pas à les poser sur notre [serveur Discord](https://discord.gg/6rt7VJxPcq).

N’hésitez pas également à créer des issues si vous trouvez des bugs ou avez des demandes de fonctionnalités.

Avec le temps, j’essaierai de créer un guide de contribution et une liste d’issues adaptées aux débutants.

## Licence
Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.

## Faire un don
Soutenez le développement open-source en faisant un don au projet. Vous pouvez faire un don via les méthodes suivantes :
* **[Patreon](https://www.patreon.com/minefortress)**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---