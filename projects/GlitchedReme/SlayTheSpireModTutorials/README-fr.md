Tutoriel de création de mod pour Slay the Spire
=====================

Tutoriel de création de mods pour « Slay the Spire 2 » en cours de mise à jour : https://github.com/GlitchedReme/SlayTheSpire2ModdingTutorials

<b>Ce tutoriel n’explique pas les notions de programmation Java, il est conseillé d’avoir des bases en programmation avant de l’étudier.</b>

<b>Si vous trouvez des erreurs ou des incohérences dans ce tutoriel, vous pouvez aider à l’améliorer en soumettant des issues.</b>

<b>Si vous avez des questions, vous pouvez rejoindre le groupe de discussion ci-dessous ou poser vos questions dans la section discussions en haut.</b>

<b>Cliquez sur le dossier Tutorials en haut ou sur le [site du tutoriel](https://glitchedreme.github.io/SlayTheSpireModTutorials/) à droite pour voir tous les tutoriels.</b>

Groupe de discussion personnel : 542370192

# Quelques outils/sites utiles

## Table des matières
* [Sites](#sites)
* [Outils](#outils)
* [Modèles de mod](modèles-de-mod)
* [Animations](#animations)

## Sites
* [ModTheSpire Wiki](https://github.com/kiooeht/ModTheSpire/wiki)<br>
<b>ModTheSpire</b> (abrégé MTS) est un outil permettant de charger des mods externes dans Slay the Spire sans modifier les fichiers de base du jeu, tout en autorisant les mods à patcher leur propre code dans celui du jeu.<br>
Le wiki de MTS explique comment gérer les sauvegardes globales, les patchs, etc.

* [BaseMod Wiki](https://github.com/daviscook477/BaseMod/wiki)<br>
<b>BaseMod</b> est l’API de base pour les mods, qui permet aux auteurs de mods d’ajouter facilement leurs propres cartes et contenus au jeu et de gérer ces contenus de manière centralisée.<br>
Le wiki propose des outils très pratiques, comme l’enregistrement automatique de toutes les cartes (AutoAdd), les modificateurs de cartes (CardModifier), la sauvegarde personnalisée en cours de partie (CustomSavable), etc. Il inclut aussi un tutoriel de création de mods écrit par l’auteur de BaseMod.

## Outils
* [JD-GUI](http://java-decompiler.github.io/)<br>
Un outil de décompilation Java avec interface graphique.<br>
Permet de consulter le code source reconstruit du jeu ou d’autres mods pour faciliter ~~la copie~~ l’étude du code d’autres auteurs.<br>
Peut aussi servir à trouver les numéros de ligne nécessaires pour appliquer des patchs. (La décompilation intégrée d’IDEA est moins précise)

* [Outil de découpage d’images sts](https://github.com/JohnnyBazooka89/StSModdingToolCardImagesCreator)<br>

Découpez l’image selon la forme et la taille requises par le mod de la flèche.<br>
Je ne l’ai pas utilisé, mais dans le groupe, certains membres ont créé un autre outil avec les mêmes fonctionnalités.

## Mod modèle
* [Mod insigne du seigneur de guerre](https://github.com/Rita-Bernstein/Warlord-Emblem)<br>
~~Recommandé par Rita, c’est forcément un chef-d’œuvre~~<br>
Un exemple de mod assez standardisé.

## Animation
* [DragonBones](https://dragonbones.github.io/cn/index.html)<br>
Un logiciel pouvant exporter des animations Spine, généralement suffisant, vous pouvez chercher une version disponible.

*Créer des animations demande quelques bases, mais en fait la plupart des mods n’ont besoin que d’une seule image.*
* [Spine](http://zh.esotericsoftware.com/)<br>
Logiciel d’animation 2D utilisé pour la flèche.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---