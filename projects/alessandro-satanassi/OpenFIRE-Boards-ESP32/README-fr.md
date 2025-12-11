## ... portage des OpenFIRE-Boards pour EPS32

Ce dépôt est un portage du projet original 'OpenFIRE-Boards' de TeamOpenFIRE, adapté pour fonctionner sur le microcontrôleur ESP32S3.  
À l'exception de quelques adaptations et petits ajustements, le code reste largement fidèle à l'original de TeamOpenFIRE.  
Le code de ce dépôt fonctionne également sur le microcontrôleur RP2040.  
Chaque fois que des modifications seront apportées au projet original 'OpenFIRE-Boards' de TeamOpenFIRE, je mettrai à jour en conséquence le code de ce dépôt.  
Je remercie sincèrement TeamOpenFIRE pour la création du projet 'OpenFIRE-Boards' ; tout le mérite et ma pleine gratitude leur reviennent.  
Ceci est simplement une adaptation pour fonctionner sur ESP32S3.  


Ce dépôt est un portage du projet original 'OpenFIRE-Boards' de TeamOpenFIRE, adapté pour fonctionner sur le microcontrôleur ESP32S3.  
À l'exception de quelques adaptations et petits ajustements, le code reste largement fidèle à l'original de TeamOpenFIRE.  
Le code de ce dépôt fonctionne également sur le microcontrôleur RP2040.  
Chaque fois que des modifications seront apportées au projet original 'OpenFIRE-Boards' de TeamOpenFIRE, je mettrai à jour en conséquence le code de ce dépôt.  
Je remercie sincèrement TeamOpenFIRE pour la création du projet 'OpenFIRE-Boards' ; tout le mérite et ma pleine gratitude leur reviennent.  
Ceci est simplement une adaptation pour fonctionner sur ESP32S3.  

![Waveshare-esp32-s3-pico](https://github.com/user-attachments/assets/2ce848f3-f308-43cc-b753-3b1dac1647e4)

![YD-esp32-s3-wroom1-DevKitC-1-N16R8](https://github.com/user-attachments/assets/080baf9b-f050-4b3e-ba59-4fb4aa784909)


## ... suit la page originale du projet  
## ... follows the original project page  

# OpenFIRE-Boards  
Dépôt commun des cartes partagées entre le Firmware OpenFIRE &amp; l'Application Desktop  

# Ressources Partagées OpenFIRE  
Ce dépôt contient des ressources pouvant être partagées entre les implémentations du Firmware microcontrôleur et les Applications destinées à interagir avec et configurer ceux-ci sur un appareil PC.  

## `OpenFIREshared.h`  
La première moitié de ce fichier définit ce qui suit, commun aux implémentations Firmware et Application :  
 - Définitions des noms des cartes que le microcontrôleur rapportera lors du docking initial, sous forme de littéraux de chaîne.  
 - Énumérations des types de fonctions des broches, commutateurs, réglages, dispositifs I2C et leurs paramètres, et commandes utilisées dans la communication série entre firmware et application.  
 - Préréglages pour les cartes définies qui sont chargés au démarrage, et référencés par les applications affichant les dispositions de carte par défaut.  

Sous la vérification du préprocesseur pour `OF_APP` se trouvent des chaînes "jolies" pour les cartes prises en charge et les fonctions des broches, ainsi que des dispositions de cartes utilisées uniquement par les Applications Desktop pour représenter graphiquement les broches GPIO des cartes définies – montrant où elles doivent être affichées par rapport à un vecteur de carte centré, et des dispositions alternatives pour les cartes que l'application devrait présenter comme options à l'utilisateur, le cas échéant.  

### `boardPresetsMap`
Les cartes prises en charge doivent avoir un nom correspondant à la définition `OPENFIRE_BOARD` telle que définie en haut du fichier, suivi d’une carte indiquant la fonction par défaut de chaque GPIO (cela est chargé lorsque `OF_Prefs::toggles[OF_Const::customPins]` est défini sur *true* dans les préférences actuelles de la carte). Chaque GPIO du microcontrôleur doit être représenté ici, les broches non mappées étant attribuées à `btnUnmapped` et les broches soit réservées soit non exposées à l’utilisateur devant être attribuées à `unavailable`. Les cartes RP2040 et RP235X-A doivent comporter au maximum trente broches - notez que même si le `rpipico` n’expose qu’environ 26 broches, il prend tout de même en compte les GPIO cachés.

### `boardBoxPositions`
Comme `boardPresetsMap`, pour chaque `OPENFIRE_BOARD` supporté, ceci présente une carte indiquant à peu près *où* chaque broche doit être située dans la vue graphique de la carte dans une application Desktop, représentée par une somme de deux valeurs - la première étant la position relative en tant qu’entier positif commençant à 1, et la seconde étant une valeur d’énumération indiquant de quel côté de la carte les éléments de la broche doivent être positionnés. Ajouter `posLeft`, `posRight` et `posMiddle` placera ce GPIO respectivement sur le côté gauche, droit ou central de la vue de la carte, et ajouter `posNothing` (littéralement 0) informera l’application de ne pas afficher cette broche du tout, ce qui doit être utilisé pour les broches `unavailable` dans `boardPresetsMap`. Le nombre de valeurs doit correspondre au nombre de GPIO définis dans la carte des présélections.

### `boardsAltPresets`
Ceci concerne des présélections optionnelles alternatives de cartes, qui doivent être présentées dans une vue de disposition de la carte sous forme de liste déroulante des noms de dispositions alternatives. Chaque `OPENFIRE_BOARD` supporté peut être listé plusieurs fois, une pour chaque disposition alternative - la chaîne après le nom de la carte indiquant le label à afficher dans l’interface, suivie d’une carte entre accolades des fonctions GPIO de la carte identique à `boardPresetsMap` ; les mêmes conventions et conditions s’appliquent. Ceci est principalement destiné à correspondre à la disposition des cartes adaptatrices qui utilisent des mappages/câblages de boutons suggérés différents, comme la disposition SAMCO 1.1 de `adafruitItsy` pour ces cartes qui diffère du mappage par défaut SAMCO 2.0 ; notez aussi que l’application Desktop de référence actuelle supporte l’exportation et l’importation de dispositions personnalisées.

## `boardPics/` - Vecteurs de cartes et surlignages des broches
Il s’agit du dépôt des vecteurs de cartes que les applications Desktop doivent utiliser pour les vues de disposition de la carte afin de représenter graphiquement la carte actuelle connectée à l’application. Les vecteurs de cartes doivent être exportés en *SVG simple* (ou équivalent), et ajoutés au fichier de ressources `vectors.qrc`, où l’alias de chaque fichier doit correspondre aux noms définis dans la chaîne `OPENFIRE_BOARD` de `OpenFIREshared.h` pour la carte.

L’application Desktop de référence actuelle est capable d’afficher des *broches surlignées* lorsque l’utilisateur survole un élément de broche GPIO dans l’interface. Pour ce faire, les SVG doivent être modifiés comme suit (en utilisant Inkscape comme exemple principal d’interface) :
 1. Si ce n’est pas déjà fait, grouper tous les objets existants de la carte dans une image dans son propre groupe (le nom importe peu). Assurez-vous aussi que les trous des broches sont bien transparents en dessous et ne sont pas remplis d’une couleur de fond.
 2. Créer un nouveau groupe qui sera *en dessous* du groupe de la carte - encore une fois, le nom importe peu, mais pour faciliter l’usage, vous devriez l’appeler quelque chose comme `OF`.
 3. À l’intérieur de ce nouveau groupe de surlignage, créer les éléments de surlignage sans contour, et avec un remplissage simple d’une seule couleur unie (les cartes existantes utilisent RGBA `ebe713`, soit *R253/G231/B19*).
 4. Sélectionner l’élément de surlignage et aller dans l’onglet *Propriétés de l’objet* (ou équivalent affichant la ligne *"ID"*) : chaque élément de surlignage doit avoir un ID nommé `OF_pinX` - où X == numéro de la broche GPIO, sans zéro initial.
 5. Pendant que l’élément est sélectionné, aller dans l’onglet *Remplissage et contour* (ou équivalent affichant *"Opacité (%)"*) et régler l’opacité à **0.0**.
 6. Une fois le positionnement, le nommage et l’opacité satisfaisants, enregistrer le fichier en tant que ***SVG simple*** dans le répertoire `boardPics`. Assurez-vous que `vectors.qrc` contient cette carte listée comme alias à la chaîne `OPENFIRE_BOARD` que vous avez définie pour ce microcontrôleur dans `OpenFIREshared.h` !

> [!NOTE]
> Cette procédure doit être effectuée **uniquement** pour chaque broche GPIO *accessible* de la carte (c’est-à-dire que les broches qui seraient `unavailable` dans `boardPresetsMap` ne doivent pas être ajoutées, car elles seront masquées par l’application).

Une fois cela terminé, recompilez l’application et testez l’image de la carte ; la façon la plus simple étant d’utiliser la fenêtre *Aide->Voir les cartes compatibles*, et de survoler avec le curseur les étiquettes correspondant aux GPIO.

> [!NOTE]
> - Si l’image de la carte ne s’affiche pas du tout, il est probable que le vecteur ne soit pas nommé correctement ou n’ait pas été exporté correctement - vérifiez bien que vous avez suivi correctement l’Étape 6 ci-dessus.
> - Si l’image de la carte s’affiche, mais que les surlignages ne s’affichent pas (ou apparaissent sur les mauvaises broches), il est probable que vous deviez modifier manuellement certaines lignes dans le SVG exporté avec un éditeur de texte, comme Notepad. Les exigences techniques pour que les vecteurs fonctionnent - et les points à vérifier - sont :
>   - Que les lignes `id="OF_pinX"` soient *au-dessus* de la ligne `style="`.
>   - Que la ligne `style="` contienne `opacity:0` à l’intérieur (de préférence `0` ou `0.0` ; peu importe lequel tant que c’est cohérent).
> Reportez-vous à l’exemple ci-dessous (extrait de [`pico.svg`](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-Boards-ESP32/main/boardPics/pico.svg)) pour le formatage idéal général de chaque élément de surlignage :
> ```html
>   <g
>      id="OF">
>     <path
>        id="OF_pin1"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.7,47.4c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2,2.7-6.3,6.1-6.4c3.4,0,6.3,2.6,6.5,6" />
>     <path
>        id="OF_pin2"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.8,88.1c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2c0-3.4,2.7-6.3,6.1-6.4,3.4,0,6.3,2.6,6.5,6" />
> ...
> ```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---