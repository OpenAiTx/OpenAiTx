# DisableCtrlClick pour macOS

<p align="center">
  <img src="https://raw.githubusercontent.com/achendev/DisableCtrlClick/master/DisableCtrlClick.png" alt="Icône de l'application" width="128">
</p>

<p align="center">
  <a href="https://github.com/achendev/DisableCtrlClick/releases">
    <img src="https://img.shields.io/github/downloads/achendev/DisableCtrlClick/total.svg" alt="Téléchargements totaux">
  </a>
  <a href="https://github.com/achendev/DisableCtrlClick">
    <img src="https://img.shields.io/github/stars/achendev/DisableCtrlClick?style=social" alt="Étoile sur GitHub">
  </a>
</p>

Êtes-vous fatigué d’ouvrir accidentellement le menu contextuel alors que vous essayez simplement d’utiliser la touche Control ? Moi aussi.

De nombreuses applications, en particulier en programmation, design et jeux, utilisent `Control` comme modificateur pour les actions principales. Si vous avez l’habitude d’un tapotement à deux doigts ou d’un bouton de souris dédié pour le clic droit, le comportement par défaut `Ctrl-Clic` peut être une interruption agaçante. Cette application résout ce problème.

## Ce que ça fait

C’est un utilitaire natif macOS très léger qui vit dans votre barre de menu et fait une seule chose : il force **`Control + Clic gauche`** à se comporter comme un **`Clic gauche`** normal, désactivant ainsi le comportement par défaut du clic droit/menu contextuel.

C’est tout. Plus de clics droits aléatoires.

## Fonctionnalités

*   ✅ **Léger & Natif :** Une application Swift simple avec une utilisation minimale des ressources.
*   ✅ **Configuré via la barre de menu :** Cliquez sur l’icône pour désactiver temporairement la fonctionnalité, basculer « Ouvrir à la connexion » ou quitter l’application.
*   ✅ **Application dans la barre de menu :** Vit discrètement dans votre barre de menu. Cmd+Glisser pour la cacher, relancez l’application pour la faire réapparaître.
*   ✅ **Démarre à la connexion (Optionnel) :** Démarre automatiquement à votre connexion. Ceci peut être activé/désactivé depuis le menu de l’application.
*   ✅ **Aucune configuration :** Il suffit de la lancer et d’accorder les permissions. C’est tout.
*   ✅ **Moderne & Sécurisé :** Conçu avec des API modernes et ne requiert aucun privilège spécial au-delà de ce qui est nécessaire pour fonctionner.
*   ✅ **Transparent & Minuscule :** Elle est si petite que vous pouvez littéralement lire tout le code de l’application ou le soumettre à n’importe quelle IA pour comprendre exactement ce qu’elle fait et ce que vous exécutez sur votre Mac.

## Installation & Utilisation

1.  **Téléchargez :** Rendez-vous sur la [**page des Releases**](https://github.com/achendev/DisableCtrlClick/releases) et téléchargez le dernier `DisableCtrlClick.dmg`.


2.  **Installer :** Ouvrez le fichier et glissez `DisableCtrlClick.app` dans votre dossier `/Applications`.
3.  **Lancer :** Ouvrez l’application depuis votre dossier Applications.
4.  **Accorder les permissions :** Lors du premier lancement, l’application vous demandera d’accorder les permissions puis se fermera. Vous devez activer **Accessibilité** et **Surveillance de l’entrée** pour `DisableCtrlClick` dans :
    *   `Réglages Système > Confidentialité et Sécurité > Accessibilité`
    > **Pourquoi ?** Ceci est requis pour toute application qui doit voir et modifier les événements de votre souris ou clavier à l’échelle du système. L’application ne détecte que le `Ctrl-Clic` et ne fait rien d’autre.

5.  **Terminé !** Relancez l’application une fois de plus. Elle fonctionne maintenant et se lancera automatiquement à chaque connexion par défaut. Vous pouvez changer ce comportement depuis l’icône de la barre de menu.

L’application affichera une petite icône dans votre barre de menu.
*   Cliquez sur l’icône pour ouvrir un menu où vous pouvez désactiver temporairement la fonctionnalité, contrôler son ouverture au démarrage, ou quitter l’application.
*   Vous pouvez masquer l’icône en maintenant `⌘` (Commande) et en la faisant glisser hors de la barre de menu. Si vous la voulez de nouveau, relancez simplement l’application.

## Compilation depuis le code source

Si vous préférez compiler l’application vous-même :

1.  Clonez ce dépôt :
    ```bash
    git clone https://github.com/achendev/DisableCtrlClick.git
    cd DisableCtrlClick
    ```
2.  Assurez-vous d'avoir installé les outils en ligne de commande pour Xcode.  
3.  Exécutez le script de compilation depuis votre terminal :
    ```bash
    ./build.sh
    ```
4.  Le bundle `DisableCtrlClick.app` sera créé dans le répertoire du projet. Vous pouvez ensuite le déplacer dans votre dossier `/Applications`.

5.  Glissez-le dans /Applications, lancez-le. Il sera ajouté automatiquement à 'Ouverture à la connexion' par défaut.

6.  Accordez les autorisations d’Accessibilité et de Surveillance des entrées dans les Réglages Système.

## Dépannage

L’application est fournie « telle quelle » sans aucune garantie, expresse ou implicite

Nécessite macOS 13.0 (Ventura) ou une version ultérieure.

**Comment quitter**
Cliquez sur l’icône dans la barre de menus et sélectionnez « Quitter ». Si vous avez caché l’icône, vous pouvez soit relancer l’application pour l’afficher, soit utiliser la commande `killall DisableCtrlClick` dans votre Terminal.

**Comment réinitialiser les autorisations**
Si l’application ne fonctionne pas, essayez de réinitialiser ses autorisations :
    ```bash
    tccutil reset Accessibility com.usr.DisableCtrlClick
    ```

## Licence

Ce projet est publié sous la licence MIT.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-22

---