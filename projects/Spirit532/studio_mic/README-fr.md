# Microphone à condensateur simple et de haute qualité pour moins de 100 $

J'avais besoin d'un microphone de bonne qualité, mais toutes les options disponibles étaient soit un peu chères, soit simplement pas vraiment performantes, alors j'ai décidé de construire le mien.

La construction du microphone utilise une capsule clone RK12/CK12 (40-50 $ sur Aliexpress/Ebay/etc, recherchez "capsule à terminaison de bord"), un corps donneur U87 (15-30 $, également Aliexpress, terme de recherche "U87 mic"), et une carte préamplificatrice personnalisée (20-30 $, ce projet).

La carte est très simple, mais haute performance - elle utilise un ampli-op à entrée double FET dans un seul boîtier pour à la fois convertir l'impédance de la capsule et fournir un signal différentiel, tandis que le biais est fourni par une pompe de charge légèrement maudite utilisant un inverseur trigger de Schmitt hexagonal.

Avec la configuration illustrée ci-dessous, les résultats sont, pour une oreille non audiophile, parfaits. Il n’y a pratiquement aucun bruit propre grâce à la simplicité du circuit et à la performance de l’ampli-op choisi, une grande plage dynamique, et aucune distorsion ou "coloration" du signal. Vous obtenez exactement ce que la capsule capte sur la prise XLR.

#### Notes sur le choix des composants
  1. Vous pouvez utiliser à peu près n’importe quel ampli-op à entrée FET, **cependant** vous devez faire très attention au courant de repos. Ce circuit utilise un chemin d’alimentation à impédance assez élevée, et la norme d’alimentation fantôme ne peut pas fournir beaucoup de courant de toute façon. La consommation totale des deux ampli-op ne doit pas dépasser environ 7-8 mA (3,5-4 mA chacun).

  2. Il en va de même pour l’inverseur hexagonal en termes de consommation, mais sinon n’importe quoi fera l’affaire. Vous pouvez remplacer la pièce par n’importe quel clone 40106 de fonctionnalité similaire.

  3. Veillez à acheter des condensateurs à haute tension là où c’est spécifié - c’est important ! Les condensateurs céramiques perdent de la capacité à des tensions élevées, donc les condensateurs de classe X7R notés pour 100 V ou plus sont préférés (cela ne résout pas explicitement la dégradation, mais aide). Toutes les valeurs sont facilement disponibles en taille 0805, donc ce n’est pas un problème.

  4. Choisissez des condensateurs NP0/C0G pour les céramiques si votre budget le permet. Ils amélioreront un peu les performances, mais pas énormément. (cela résout la dégradation, mais à un coût significatif)

Le design est sous licence MIT. Si vous voulez le construire, allez-y. Si vous voulez le vendre, allez-y aussi, mais mentionnez simplement cette page ou quelque chose. Presque rien de tout cela n’est vraiment original et a été fait des dizaines de fois (par exemple DJJules/Sound Sleuth sur Instructables, dont j’ai pris l’inspiration pour le circuit), j’y ai juste ajouté ma propre touche.

#### Note importante sur les corps donneurs bon marché
La plupart des corps donneurs bon marché sont pré-anodisés ou même pré-peints, y compris les surfaces de contact aux points de séparation (couvercle du circuit, panier de tête, écrou, entretoises, etc), __assurez-vous de les poncer__ pour exposer le métal, sinon vous capterez beaucoup de bourdonnement secteur et d’autres bruits électriques externes !


## Obtenir la carte
Si vous ne pouvez pas fabriquer ou assembler la carte vous-même... eh bien, bonne chance, mais la plupart des usines d’assemblage en Chine les fabriqueront volontiers pour vous pour pas très cher.
J’avais un lien affilié PCBWay ici, mais je ne recommanderais plus de traiter avec eux.

## Schéma
(disponible aussi en pdf ou sources KiCad 7, voir fichiers)

![Schéma](https://raw.githubusercontent.com/Spirit532/studio_mic/main/sch_img.png)

## Rendu PCB
![Rendu](https://raw.githubusercontent.com/Spirit532/studio_mic/main/render.png)

## Carte assemblée, version DIY monocouche (faite maison)
![Construction](https://raw.githubusercontent.com/Spirit532/studio_mic/main/build.jpg)

## Capsule montée dans le corps du donneur
![Capsule](https://raw.githubusercontent.com/Spirit532/studio_mic/main/capsule.png)

## Corps du donneur clone U87
![Donor](https://raw.githubusercontent.com/Spirit532/studio_mic/main/donor.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-05

---