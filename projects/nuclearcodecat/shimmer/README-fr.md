# shimmer - charmant userchrome firefox avec support sidebery (v2.37)
![BOUTON ÉTOILE](https://github.com/user-attachments/assets/227bfd9e-ce3a-4d76-b8b7-24ad55dc128a)[![ISSUE](https://github.com/user-attachments/assets/648d41c3-4812-47fd-9696-38d76a2a0a5a)](https://github.com/nuclearcodecat/shimmer/issues)[![BOUTON ARGENT](https://github.com/user-attachments/assets/18d7f816-f784-46b2-97b1-89173f68e227)](https://ko-fi.com/nuclearcodecat)

voir le [changelog](https://raw.githubusercontent.com/nuclearcodecat/shimmer/main/CHANGELOG.md) pour l’historique des changements

### salut, je considère ce projet comme essentiellement terminé. je ne prévois pas de nouvelles fonctionnalités car je n’ai simplement pas envie de travailler dessus et j’ai des projets ÉNORMES sur lesquels je me concentre en ce moment. shimmer est super et je le laisse tel quel. n’hésitez pas à faire des demandes, je ne promets pas de les ajouter cependant. merci pour tous les mots gentils et les étoiles :333

## démonstration
<!--
![sidebarcollapse](https://github.com/user-attachments/assets/be8cb062-19f6-40b5-b26d-6a4fe8ceff7b)
-->
![sortie](https://github.com/user-attachments/assets/41ca27e6-701b-4049-8e38-76bcb300cd85)


| utilisation de sidebery                                                                              | onglets natifs                                                                                              |
|----------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------|
| ![y](https://github.com/user-attachments/assets/6c8ce4d2-a9a8-478c-b427-77417f6a27a5) | ![x](https://github.com/user-attachments/assets/7b523c33-bec6-482a-9f01-3e478e75902e) |
<!-- | ![lightsidebery](https://github.com/user-attachments/assets/dd26f273-438e-42be-b77a-5d0df96b70bf) | ![greennative](https://github.com/user-attachments/assets/a60e6432-c919-4766-8353-609f1296315d)              | -->



| menus                                                                                           | popover barre d’url                                                                         |
|------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------|
| ![ctxmenu](https://github.com/user-attachments/assets/7da9bdff-d247-4680-ad20-70d12c886272)    | ![urlbar](https://github.com/user-attachments/assets/8b328ecf-0297-4e8c-8cb6-8826040c7916) |

### barre latérale rétractable
comme montré dans la démonstration

### barre de recherche compacte
![findbar](https://github.com/user-attachments/assets/198c5ec8-6e59-46fb-8624-0baa90506c86)

### améliorations de la qualité de vie
![longtab](https://github.com/user-attachments/assets/6ab029f9-1b67-4545-a898-bd680bd40000)

### boutons de contrôle de fenêtre compacts, style macos
![winctr](https://github.com/user-attachments/assets/934849bd-19ba-4617-8bfe-f5b41508a872)

## fonctionnalités
 - barre latérale rétractable
 - barre d’url popover (voir image animée de la démo)
 - fonctionne avec des thèmes personnalisés  
 - coins arrondis du navigateur/barre latérale  
 - menus contextuels minimisés  
 - transitions subtiles et non obstructives  
 - barre de recherche minimisée  
 - option disponible pour déplacer la barre latérale du côté droit  
 - propriétés de configuration pour la personnalisation  
 - compatible avec Firefox Nightly  
 - semi-compatible avec les onglets verticaux natifs  
 - panneau de statut flottant  

## installation  
 - cloner ou télécharger le code depuis GitHub (bouton vert "code") et décompresser  
 - télécharger Sidebery depuis les extensions Mozilla si désiré  
 - ouvrir les paramètres de Sidebery, descendre en bas (section aide)  
 - cliquer sur "importer les données de l’extension"  
 - sélectionner "sidebery.json" depuis l’archive téléchargée  
 - laisser les options par défaut et cliquer sur "importer"  
 - aller dans about:config  
 - activer `toolkit.legacyUserProfileCustomizations.stylesheets` à true  
 - activer `svg.context-properties.content.enabled` à true  
 - désactiver `sidebar.revamp` à false  
 - ouvrir about:profiles, trouver votre profil et ouvrir le dossier racine  
 - créer un dossier `chrome` s’il n’existe pas  
 - déplacer les fichiers `userChrome.css`, `userContent.css` et le dossier `assets` dans le dossier `chrome`  
 - relancer Firefox  
 - terminé ! :3  
 - veuillez SVP visiter cette page GitHub de temps en temps pour télécharger la dernière version, voir la section "mise à jour" de ce readme  
 - voir la section "personnalisation" de ce readme pour les options de personnalisation  

## mise à jour  
 consultez cette page GitHub de temps en temps pour vérifier si une nouvelle version est disponible. La version installée est visible à côté du bouton de fermeture dans le menu des paramètres du nouvel onglet (en bas à droite du nouvel onglet).  
### comment mettre à jour :  
 suivez les instructions d’installation, autorisez votre explorateur de fichiers à remplacer les fichiers si demandé (n’oubliez pas de mettre à jour les styles de Sidebery)  

## personnalisation  
 en haut de `userChrome.css`, il y a des variables CSS personnalisables. Parmi elles se trouvent des options de taille des onglets, arrondis, espacements entre certains éléments, etc. En dessous de ces variables, il existe aussi des exclusions du menu contextuel clic droit. Commentez ou décommentez les options que vous souhaitez activer ou désactiver.  

 j’ai aussi implémenté certaines valeurs booléennes personnalisées dans `about:config` que vous pouvez modifier  
 - `shimmer.disable-collapsing-sidebar` – activer à true pour désactiver la barre latérale rétractable (malheureusement cela nécessite aussi de commenter certains styles Sidebery, ils sont indiqués dans l’éditeur de styles dans les paramètres de Sidebery)
 - `shimmer.remove-winctr-buttons` – basculez sur true pour supprimer les boutons de contrôle de la fenêtre
 - `shimmer.remove-firefox-view-button` – basculez sur true pour supprimer le bouton de vue Firefox
 - `shimmer.disable-popover-transition` – basculez sur true pour supprimer la transition du popover de la barre d’URL
 - `shimmer.disable-urlbar-background-transition` – basculez sur true pour supprimer la transition subtile de l’arrière-plan de la barre d’URL qui se produit pendant l’animation du popover
 - `shimmer.disable-popover-urlbar` – basculez sur true pour supprimer l’effet popover sur la barre d’URL
 - `shimmer.native-vertical-tabs` – basculez sur true si vous utilisez les onglets verticaux de Firefox au lieu de Sidebery. ne basculez pas sur true si vous utilisez des onglets *horizontaux*, ils disparaîtront
 - `shimmer.show-sidebar-header` – basculez sur true pour afficher l’en-tête de la barre latérale
 - `shimmer.show-sidebar-header-close-button` - même si vous activez l’en-tête, le bouton de fermeture est automatiquement caché. basculez ceci sur true pour le faire réapparaître
 - `shimmer.sidebar-right-side` – basculez sur true si vous utilisez Sidebery sur le côté droit. vous devez d’abord déplacer la barre latérale dans Firefox en utilisant l’en-tête de la barre latérale, qui doit être réactivé dans la config
 - `shimmer.reverse-winctr-buttons-side` – basculez sur true pour déplacer les boutons de contrôle de la fenêtre vers la gauche
 - `shimmer.taller-tabs` – basculez sur true pour rendre les onglets aussi hauts que les onglets Firefox par défaut
 - `shimmer.shorter-navbar` – basculez sur true pour rendre la barre de navigation aussi haute que dans Firefox non modifié (peut nécessiter un redémarrage de Firefox)
 - `shimmer.disable-compact-winctr-buttons` – basculez sur true pour revenir aux boutons compacts de contrôle de fenêtre par défaut
 - `shimmer.dont-expand-selected-tab` – basculez sur true pour désactiver l’effet d’agrandissement de l’onglet actif lorsqu’il y a beaucoup d’onglets ouverts
 - `shimmer.enable-theme-aware-wallpapers` – basculez sur true pour commander à Firefox d’afficher les fonds d’écran sélectionnés par l’utilisateur. pour changer les fonds d’écran, ouvrez le répertoire chrome, remplacez les fichiers *light* et *dark* dans le répertoire *walls* par les images désirées, et exécutez `makewalls.sh`. veuillez noter qu’il s’agit d’un script bash. si un fond d’écran ne fonctionne pas, essayez de le rendre plus petit, malheureusement les fichiers volumineux posent problème – une limite sûre est < 1MiB.

## maintenance
 veuillez garder à l’esprit que je n’aurai pas toujours le temps de corriger un problème créé par une nouvelle version de Firefox en une journée. si vous souhaitez créer une pull request, n’hésitez pas à le faire. si vous trouvez des problèmes, veuillez les signaler dans l’onglet « issues » sur GitHub.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---