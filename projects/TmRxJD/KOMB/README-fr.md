<head><meta name="google-site-verification" content="YTr2AYTpsxIQk7KIOlVTOfKr11dqkzZP-gOUiyhPU5s" />
<body>

<h1>KOMB : Macro de brossage ultime pour Klipper</h1>

Bienvenue dans KOMB, le Macro Optimisé pour le Brossage de Klipper ! Cette macro polyvalente simplifie les séquences de brossage, conçue sur mesure pour les brosses montées sur lit ou portique. Dites adieu aux tracas d’adapter des macros existantes ou d’en créer de nouvelles — vous pouvez désormais exploiter tout le potentiel de votre brosse en trois dimensions !

<h3> Installation : </h3>

La manière la plus propre et la plus simple de commencer avec KAMP est d’utiliser l’utilitaire Update Manager de Moonraker. Cela vous permettra d’installer facilement et aidera à fournir des mises à jour futures lorsque de nouvelles fonctionnalités seront déployées !

1. `ssh` dans votre appareil Klipper et exécutez les commandes suivantes :
   ```bash
    cd
    
    git clone https://github.com/TmRxJD/KOMB    

    ln -s ~/KOMB printer_data/config/KOMB

    cp ~/KOMB/_KOMB_Variables.cfg ~/printer_data/config/KOMB_Variables.cfg

    ```
2. Ouvrez votre fichier `moonraker.conf` et ajoutez cette configuration :

   ```yaml
   [update_manager KOMB]
   type: git_repo
   channel: dev
   path: ~/KOMB
   origin: https://github.com/TmRxJD/KOMB
   managed_services: klipper
   primary_branch: main
    ```

    > **Remarque :**
    > Chaque fois que les configurations de Moonraker sont modifiées, il faut le redémarrer pour que les changements prennent effet. Si vous ne souhaitez pas que Moonraker vous informe des futures mises à jour de KAMP, vous pouvez ignorer cette étape.

3. Optionnellement, incluez KOMB_Purge.cfg dans votre KOMB_Variables.cfg pour utiliser la macro là-bas. 

<h3>Fonctionnalités et Fonctionnalité</h3>

Mouvement Flexible : Le mouvement par défaut de KOMB balaie du coin inférieur gauche vers la droite, mais vous pouvez personnaliser facilement le déplacement selon différents axes et directions. Utilisez-le même en cours d’impression selon votre imprimante et le placement de votre brosse.

Motifs Divers : Supporte actuellement les balayages diagonaux et circulaires (nécessite gcode_arcs activé), le répertoire de KOMB s’élargira bientôt avec plus de motifs.

Brossage 3D : Profitez de toute la surface et la profondeur possible de votre brosse pour assurer une buse plus propre avec des performances plus constantes, vous pouvez être assuré que votre buse sera propre à chaque fois. La buse peut s’abaisser dans la brosse étape par étape pour permettre à plus de surface de la buse d’atteindre la brosse.

Utilisation en Cours d’Impression : avec le déclencheur KOMB, vous pouvez utiliser la macro aussi souvent que vous le souhaitez pendant l’impression, garantissant que votre buse reste propre tout au long.

<h3>Paramètres de Brosse Ajustables : Modifiez les variables pour un contrôle précis</h3>
* Spécifiez l’emplacement de votre brosse en (X, Y, Z), ainsi que la taille et la profondeur en millimètres <br>
* Taille du pas : Distance entre les coups diagonaux ou circulaires <br>
* Pas en Z : Descente après chaque itération lors de l’utilisation du mode répétition. Mettre à 0 pour désactiver. <br>
* Décalage : Permet de commencer et finir les mouvements en dehors des limites de la brosse, ou pour rester plus confiné utilisez une valeur négative pour cela <br>
* Nombre de répétitions : Spécifiez combien de fois vous souhaitez que le motif soit itéré <br>
* Inversion : Activez pour répéter le motif en sens inverse avant la répétition suivante. Si désactivé, la buse retournera directement au départ après le motif <br>
* Départ côté Opposé et/ou Adjacent : Si le côté opposé est activé, la buse se déplacera de droite à gauche. Si adjacent est activé, la buse se déplacera selon l’axe opposé et commencera en bas en montant. Si les deux sont activés, la buse ira de haut en bas. <br>
* Vitesse Variable : Spécifiez la vitesse en mm/s et augmentez ou diminuez la vitesse à chaque répétition. Peut aussi contrôler la vitesse de déplacement vers la brosse <br>
* Motifs : Choisissez entre différents motifs de brossage, actuellement les diagonales et cercles sont supportés. (Si vous souhaitez encore utiliser un motif horizontal classique, vous pouvez, il suffit de régler la taille de la brosse sur l’axe opposé à 0. Si vous voulez qu’il puisse encore faire des pas, réglez l’angle à 0) <br>
* Angle : spécifiez l’angle des coups diagonaux en utilisant le motif 1, l’angle par défaut recommandé est 45 <br>
* Chauffage Automatique : Activez et spécifiez une température minimale pour permettre le brossage et préchauffez automatiquement à cette température avant le brossage <br>
* Retour à la Maison Automatique : Ramène automatiquement la tête d’impression à la position d’origine si nécessaire. Ne le fait que si ce n’est pas déjà fait. <br>
* Rétraction : Configurez la rétraction avant, pendant et après le brossage. <br>
* Saut en Z : Spécifiez une hauteur pour lever la buse avant de se déplacer à la position de la brosse puis de redescendre. Mettre à 0 pour désactiver.<br>
* Rétroaction Verbose : Activez la sortie console détaillée pour des informations complètes sur le processus de brossage, incluant les valeurs des axes, calculs et points de positionnement. <br>

<h4>Déclencheur KOMB</h4>

You can use KOMB at a specified frequency throughout the print to ensure your nozzle stays clean for the entire duration. Include `KOMB_trigger` in the 'at layer change' section of your slicer configuration to effortlessly trigger the macro at your preferred frequency. Additionally, integrate this macro name into your start print routine to use the macro before starting printing. This feature is not intended for per-object printing and is tailored for use with gantry and frame-mounted brushes. While functional with bed-mounted brushes, cautious use is advised, as attention to your printer's clearances is essential to prevent potential collisions. If utilizing Z hop, the nozzle will ascend before maneuvering over the brush, descend for brushing, and subsequently reascend to its initial height before resuming printing. Configure Z hop settings to provide added clearance during elevation and descent. It is strongly recommended not to set the Z hop value below 2. Additionally, ensure that your axis limits are accurately defined for the macro's effective operation. For guidance on setting axis limits, refer to the guide provided at the end of this readme.
<h4>Purges KOMB</h4>

L’option de purge de KOMB vous permet d’initier une purge contrôlée du matériau avant de commencer la séquence de brossage. Cette fonctionnalité est particulièrement utile lorsque la précision est importante, comme lors de la calibration du décalage Z ou d’autres opérations dépendantes des mesures, sans avoir besoin de tracer une ligne de purge supplémentaire. En utilisant cette fonctionnalité, vous pouvez facilement définir l’emplacement de votre récipient de purge, la quantité d’extrusion de filament souhaitée, et le temps d’attente avant de passer à la séquence de brossage. L’option de purge peut également être activée indépendamment du reste de la macro ; cela vous offre la flexibilité d’adapter votre processus d’impression selon vos besoins spécifiques. Pour utiliser la macro dans votre démarrage d’impression, ajoutez « KOMB_purge » à votre configuration.

<h3>La Distinctivité de KOMB</h3>

KOMB est conçu pour s’adapter parfaitement à diverses configurations d’imprimantes, prenant en compte différentes tailles et emplacements de brosse. Contrairement aux macros traditionnelles qui forcent votre buse à se déplacer vers des emplacements spécifiques, KOMB génère une séquence complète de coordonnées basées sur vos variables, ajustées préventivement pour rester dans les limites de l’imprimante. Cette approche proactive élimine presque totalement le risque d’erreurs pour garantir un brossage réussi, quelles que soient les erreurs de l’utilisateur. Tous les points générés dépassant les limites de l’imprimante sont automatiquement ajustés pour rester à l’intérieur, assurant une exécution fluide. Une fois la liste instantanément générée, KOMB guide la buse à travers les coordonnées prédéfinies avec aisance.

<h3>Commencer avec KOMB</h3>

Assurez-vous que le firmware Klipper est installé sur votre imprimante 3D.

Intégrez le code macro KOMB fourni, `KOMB.cfg`, dans votre fichier de configuration Klipper « printer.cfg », avec vos autres macros. Pour plus de convivialité, il est recommandé de conserver les variables KOMB dans un fichier séparé et de l’inclure via `[include _KOMB_Variables.cfg].` Alternativement, vous pouvez le fusionner avec la configuration principale si vous trouvez cela plus pratique.

Spécifiez les variables dans la section KOMB_Variables pour correspondre à vos besoins de brossage.

Déterminez la position XY exacte de la brosse via l’interface utilisateur de l’imprimante. Commencez depuis le coin inférieur gauche, en ajustant jusqu’à une précision de 0,1 mm si vous le souhaitez.

Mesurez la taille de la brosse ou calculez-la en vous déplaçant vers le coin supérieur droit et en soustrayant la position du coin inférieur gauche de celle du coin supérieur droit sur les axes X et Y.  
Répétez un processus similaire pour la position Z, en tenant compte de l’option de descendre la buse par incréments à chaque itération (z_step).

Sauvegardez le fichier de configuration et rechargez Klipper pour appliquer les modifications.

Exécutez KOMB dans la console, via un bouton macro dans l’interface utilisateur, ou ajoutez `KOMB` à votre macro de démarrage d’impression. Assurez-vous que les variables sont correctement configurées avant l’exécution.

Surveillez la progression via la sortie console lorsque la sortie détaillée est activée.

Profitez d’un brossage amélioré avec KOMB !

<h3>Notes Importantes</h3>

Cette macro est conçue pour fonctionner avec un ensemble de variables et paramètres. Assurez-vous de les ajuster selon les spécifications de votre imprimante et vos besoins de brossage. Veillez à bien comprendre le rôle de chaque variable et la manière de l’utiliser.

Vous devez vous assurer que les limites de vos axes sont correctement définies pour que cette macro fonctionne correctement. Suivez ce guide si vous avez un doute : https://github.com/rootiest/zippy_guides/blob/main/guides/axis_limits.md

Comme cette macro implique le déplacement de la buse de l’imprimante, faites preuve de prudence afin d’éviter toute collision durant le processus de brossage et assurez-vous que toutes les valeurs sont correctes. Il est recommandé de tester la macro à faible vitesse au-dessus de la brosse avant de l’abaisser en position.

N’oubliez pas de revenir régulièrement pour des mises à jour et plus de motifs !


KOMB est un travail en cours, et toutes les combinaisons de variables n'ont pas été testées de manière exhaustive. Vos retours et contributions pour améliorer la macro sont très appréciés.

Si vous rencontrez des problèmes, avez des suggestions d'amélioration, ou souhaitez contribuer au développement de KOMB, n'hésitez pas à m'envoyer un message, ouvrir un ticket ou soumettre une demande de tirage sur le dépôt GitHub.

Bon KOMBing !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-14

---