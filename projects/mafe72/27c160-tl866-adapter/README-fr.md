# Série d’adaptateurs de programmation EPROM 27C322/160/800/400

![GitHub issues](https://img.shields.io/github/issues-raw/mafe72/27c160-tl866-adapter?logo=Github&style=for-the-badge)

## Introduction

Cet adaptateur convertit les broches des composants listés ci-dessous (qui sont similaires aux ROMs masquées DIP contemporaines) vers la broche 27C4096 prise en charge par la série TL866 d’encodeurs USB, facilement disponibles et peu coûteux.

Les EPROMs pris en charge sont :
- **27C400 :** 40 broches, 4 Mbits (256k x 16 bits, 512k x 8 bits)
- **27C800 :** 42 broches, 8 Mbits (512k x 16 bits, 1M x 8 bits)
- **27C160 :** 42 broches, 16 Mbits (1M x 16 bits, 2M x 8 bits)
- **27C322 :** 42 broches, 32 Mbits (2M x 16 bits, pas de mode accès 8 bits)

## Conception

Cet adaptateur a été conçu avec KiCad 5.0, vous pouvez trouver les fichiers du projet dans le dossier nommé kicad-project.

Côté supérieur :

![top](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/front_th.png)

Côté inférieur :

![bottom](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/back_th.png)

## Utilisation

Insérez l’adaptateur de programmation dans le TL866 avec les poignées de la prise côte à côte. Insérez l’EPROM dans la position la plus basse possible dans l’adaptateur et avec la broche 1 près de la poignée.

![Adapter when in use](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/adapter_in_use.jpg)

Si vous programmez une EPROM 27C322, déplacez l’interrupteur en **Position 27c322**, pour les EPROMs 27C160, 27C400 et 27C800, l’interrupteur doit être en **Position autre**.

![Adapter mode](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/addapter_mode.jpg)

## Logiciel

Les instructions suivantes décrivent comment écrire une EPROM 27c160.

Divisez la source EPROM en parties de 512 Kbytes, dans ce cas j'utilise HJSplit, cependant d'autres programmes peuvent être utilisés.

![HJSplit](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/hjsplit_512k.jpg)

Localisez le chemin de sortie, pour cet exemple quatre fichiers de taille 512Kbyte avec une extension se terminant par ".001" - ".004".

Lancez le logiciel MiniPro, sélectionnez le périphérique `AMD 27C4096 DIP40`, désélectionnez `Check ID` et réglez le `Pulse Delay` à `50us`. Vous pouvez également réduire facultativement la `VPP Voltage` à `12.50V`, selon la fiche technique de votre EPROM et le succès de la programmation.

![MiniPro Software Configuration](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/minipro.jpg)

L'EPROM peut maintenant être accessible comme s'il s'agissait d'un appareil 27C4096, 512kB à la fois, comme configuré par l'interrupteur DIP :

- **27C400 :** programmer les 512kB en un seul passage.
- **27C800 :** programmer en 2 (deux) passages de 512kB.
- **27C160 :** programmer en 4 (quatre) passages de 512kB.
- **27C322 :** programmer en 8 (huit) passages de 512kB.

Référez-vous au tableau suivant pour la configuration de l'interrupteur DIP :

![DIP Switch configuration](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/dip_config.png)

## Dépannage

Si vous rencontrez des erreurs d’écriture ou de vérification lors de la programmation, essayez ces étapes :

1. Assurez-vous que l'EPROM est complètement effacée avant de la programmer (`Device -> Blank Check`). Toutes les EPROM disponibles aujourd'hui sont d'occasion ; les vendeurs ne prennent pas toujours soin de les effacer avant la revente.

2. Ouvrez et fermez plusieurs fois le levier ZIF de l'adaptateur, et repositionnez l'EPROM bien à plat dans le socket.

3. Essayez d'ajuster la `VPP Voltage` entre `12.50V` et `13.50V`. Subjectivement, j'ai eu plus de succès à la tension la plus élevée, ce qui permet une marge pour les pertes de tension lors du transfert de la VPP à travers la logique de l'adaptateur.

4. Des erreurs de programmation peuvent survenir occasionnellement, et bien sûr, les chances augmentent avec la taille du dispositif. Il est judicieux d’investir dans un effaceur UV. Ceux-ci sont disponibles à faible coût sur eBay pour environ 15 à 20 $. La plupart des dispositifs seront effacés après 10 à 20 minutes sous lumière UV.

5. [Maillouski](https://github.com/Maillouski/), a signalé que Xgpro v12.38 définit par défaut la valeur VDD Write à 6.60V pour l’AT27C4096. Pour éviter les problèmes de programmation, assurez-vous de changer cette valeur à 3.30V.

![IC Config Information VDD Write](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/vdd_3v30.png)

6. [Tim alias BeepFixer](https://x.com/@beepfixer), partage ses valeurs de programmation pour les variantes **27C160** provenant d’AliExpress.

   La principale différence : la configuration du pad de la fenêtre UV. Appelez-les Types A, B et C.
    - **Type A** : 2x2 pads utilisant uniquement le centre de l’espace disponible de la fenêtre 
    - **Type B** : 2x2 pads utilisant la majeure partie de l’espace disponible de la fenêtre 
    - **Type C** : 2x4 pads

![IC Config Information VDD Write](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/m27c160_variants.jpg)

**Résultats des tests**

  **Type A** : 2/10 puces ont nécessité un petit soin particulier – un léger ajustement hors des réglages recommandés (changement de 50us à 100us) les a rendues programmables et vérifiables. Juste pour être sûr, voici les réglages complets utilisés : Tension VPP : 13.50V / Vérification VCC : 5.00V / Écriture VDD : 5.00V / Délai d’impulsion : 100us. Cependant, le succès a aussi été obtenu avec d’autres tensions, tant que le délai d’impulsion était à 100 et non 50us.

  **Type B** : 7/10 puces ont fonctionné parfaitement – du premier coup, réglages recommandés par Eladio (50us)

  **Type C** : 1/10 puce a échoué spectaculairement. Elle lit et efface très bien, et peut écrire un seul mot. Mais après l’écriture du mot unique, elle refuse d’écrire plus. Probablement une variante plus ancienne et plus stricte ; pas défectueuse, juste une diva du silicium. J’ai essayé maintes fois avec différents réglages sans jamais réussir à écrire un lot complet.

**Conseils pratiques**

   - Toujours vérifier après programmation. 
   - Essayer des différences de tension comme mentionné aussi dans le GitHub de l’adaptateur.
   - Et faites attention aux écritures de fichiers ; puisque vous utiliserez l’adaptateur pour écrire une image divisée en 4 sections, il est facile d’écrire le mauvais fichier dans la mauvaise banque (oups, oui coupable d’avoir écrit le fichier 3 dans la banque 3 et 4 moi-même une fois). Donc, vérifiez bien l’EPROM sur le dispositif de destination !

## Journal des modifications matérielles

R_20231123

* Correction de la polarité correcte de l’interrupteur DIP EDG-03.
* Mise à jour du numéro de révision à R_20231123
* Mise à jour du numéro de version à 1.1

V_20180919

* Première version.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---