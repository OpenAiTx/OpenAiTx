# GB Studio 4.2 - Plugin Pak

Un ensemble de plugins expérimentaux pour GB Studio 4.2. Utilisez-les à vos risques et périls :)

> [!NOTE]
> Quelques plugins d'événements précédemment disponibles sont désormais obsolètes, car leur fonctionnalité fait partie de GB Studio. [Voir la liste ci-dessous](#deprecated-plugins).

## Dialogue & Menus

### Dessiner une barre de vie

Dessine une barre (vie/puissance/mana) à une position spécifiée sur la superposition.

- `X`, `Y` : Coordonnées en tuiles sur la superposition.
- `Tileset` : Un tileset qui inclut les tuiles pour la barre dans l'ordre consécutif.
- `Tile` : La première tuile de la barre dans le tileset (généralement la tuile vide).
- `Value` : La valeur actuelle à représenter par la barre.
- `Max Value` : La valeur maximale pouvant être représentée par la barre.
- `Steps` : Le nombre de tuiles nécessaires pour "remplir" un élément dans la barre (sans compter la tuile vide).

[Projet d'exemple](examples/Draw%20Lifebar/)

_Note :_ Le tileset sera chargé à la tuile 128 de la VRAM (juste après le bloc des sprites). Cela permet de combiner le rendu de la barre de vie avec `Draw Text` sur la superposition. L’indice VRAM peut être modifié en éditant la ligne `const VRAM_BASE_START_TILE = 128` dans le fichier du plugin.

<img width="300" alt="Dessiner une barre de vie" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Draw Lifebar/screenshots/draw_lifebar.png"/>

<img width="300" alt="Dessiner une barre de vie" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Draw Lifebar/screenshots/draw_lifebar_screenshot.png"/>

### Afficher un menu avancé

Affiche un menu avec plusieurs options et assigne la variable spécifiée à la valeur de l’option choisie. La position des options du menu et l’ordre de navigation peuvent être définis pour chaque élément dans l’onglet `Items`. Vous pouvez optionnellement configurer le bouton 'B' pour fermer le menu en mettant la variable à '0' et également faire en sorte que le dernier élément du menu retourne '0' lorsqu’il est sélectionné. La taille de la boîte de dialogue, la direction d’ouverture et de fermeture, ainsi que la position du menu (en haut ou en bas) peuvent être configurées dans l’onglet `Layout`. La vitesse d’ouverture et de fermeture du menu peut être réglée dans l’onglet `Behavior`.

Il n’y a pas de longueur maximale par élément, mais le nombre total de caractères affichés est limité par le nombre de tuiles réservées pour le texte de l’interface (52 en mode non couleur).

_Note :_ L’événement peut devenir très long s’il y a beaucoup d’éléments.

<img width="300" alt="Options du menu avancé" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_items.png"/> <img width="300" alt="Capture d’écran du menu avancé" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_screenshot.png"/>

<img width="300" alt="Disposition du menu avancé" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_layout.png"/>

## Horloge Temps Réel

Un ensemble d'événements qui permettent d'accéder à la fonctionnalité d'Horloge Temps Réel présente dans certaines cartouches GB.

_Note :_ Le type de cartouche doit être réglé sur `MBC3` dans les paramètres du projet pour que l'horloge fonctionne.

### Régler l'Heure de l'Horloge

Définir les valeurs des champs de l'horloge temps réel à un nombre ou à la valeur d'une variable.

<img width="300" alt="Régler l'Heure de l'Horloge" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/set_clock_time.png"/>

### Stocker l'Heure dans des Variables

Stocker l'heure actuelle dans une variable pour chaque valeur.

<img width="300" alt="Stocker l'Heure dans des Variables" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/store_time_in_var.png"/>

### Démarrer l'Horloge

Démarre l'horloge temps réel.

<img width="300" alt="Démarrer l'Horloge" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/start_clock.png"/>

### Arrêter l'Horloge

Arrête l'horloge temps réel.

<img width="300" alt="Arrêter l'Horloge" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/stop_clock.png"/>

## Écran

### Fondu Doux

**Mode Couleur uniquement**

Faire un fondu des palettes de fond ou de sprites de la scène actuelle, en tout ou partie, vers ou depuis un écran blanc ou noir, en interpolant les valeurs des couleurs pour un fondu doux.

<img width="300" alt="Mise à Jour du Champ Joueur" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Smooth Fade/screenshots/smooth_fade.png"/>

## Plugins β

Les plugins de cette catégorie sont encore plus expérimentaux que ceux ci-dessus et pourraient changer à l'avenir.

- **Déplacer un acteur variable vers** et **Stocker la position de l’acteur variable dans n variables** :
  - Ces événements dupliquent les événements d’acteur existants de GB Studio, mais au lieu d’utiliser un menu déroulant pour sélectionner l’acteur, ils utilisent une variable. La valeur de la variable représente l’indice de l’acteur dans la scène (le joueur est toujours `0`, et les autres acteurs ont un indice attribué en fonction du moment où ils ont été ajoutés à la scène).

- **Épingler un acteur à l’écran** et **Désépingler un acteur de l’écran** :
  - Épinglez ou désépinglez l’acteur à ses coordonnées actuelles à l’écran.\nSoyez conscient de l’état actuel de l’acteur : s’il est déjà épinglé ou désépinglé lorsque l’événement est appelé, sa position sera décalée de manière incorrecte en fonction de la position de défilement.

## Comment Installer

Déposez le dossier `plugins` dans votre projet. Tous les événements ci-dessus seront disponibles via le bouton `Ajouter un événement`.

## Plus de plugins d’autres auteurs :

- [Collection de plugins GB Studio de NalaFala (Yousurname)](https://github.com/Y0UR-U5ERNAME/gbs-plugin-collection)
- [Platformer+](https://github.com/becomingplural/GBS_PlatformerPlus)
- [Dialogue avancé et menu vB](https://github.com/dochardware/Advanced-Dialog-and-Menu)
- [Plugins GB Studio de Shin](https://github.com/shin-gamedev/gbs-plugins)
- [Plugins Gud GBS](https://github.com/mikeleisz/gud_gbs_plugins)
- [Fade Street](https://gearfo.itch.io/fade-street)
- [Transition de scène avec défilement](https://github.com/Mico27/GBS-scrollScenePlugin) et plus [plugins de Mico27](https://github.com/Mico27/)

## Événements de plugins obsolètes

Les plugins d’événements suivants ne sont plus disponibles dans le Plugin Pak, car leurs fonctionnalités ont été intégrées nativement à GB Studio.

Depuis la version 4.2 :

- Mise à jour du champ joueur
- Stocker le champ joueur dans une variable
- Stocker le champ caméra dans une variable

Depuis la version 4.1 :

- Afficher un dialogue avancé
- Afficher un texte d’arrière-plan
- Imprimer l’arrière-plan de l’écran
- Couper le son d’un canal
- Mise à jour du champ de la caméra
- Définir le cadre de dialogue
- Effets d'acteur

Depuis la version 4.0 :

- Groupe d'événements verrouillé
- Groupe d'événements déverrouillé


Si vous n'utilisez pas GB Studio 4.2 ou une version supérieure, vous pouvez toujours trouver ce qui précède [ici](https://github.com/pau-tomas/gb-studio-plugins/tree/4.1). Pour les plugins compatibles avec la version 4.0, consultez [ici](https://github.com/pau-tomas/gb-studio-plugins/tree/4.0)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---