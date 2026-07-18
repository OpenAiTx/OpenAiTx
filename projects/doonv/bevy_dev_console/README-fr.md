# bevy_dev_console

`bevy_dev_console` est un plugin de console développeur inspiré de Source pour le [Bevy Game Engine](https://github.com/bevyengine/bevy).

![Image de la console développeur](https://raw.githubusercontent.com/doonv/bevy_dev_console/master/doc/console.png)

> [!ATTENTION]  
>
> `bevy_dev_console` est actuellement en phase de développement précoce. Attendez-vous à des changements majeurs dans un avenir proche (surtout lors de l'utilisation de l'analyseur de commandes intégré). Pour cette raison, il est pour le moment uniquement disponible en tant que package git.

## Fonctionnalités

- Visualisation des logs
  - Voir toutes les données cachées de n’importe quel message de log en le survolant.
- Langage d’analyse intégré puissant conçu spécifiquement pour `bevy_dev_console`. ([Documentation](https://github.com/doonv/bevy_dev_console/wiki/Built%E2%80%90in-Parser))
  - Calculs
  - Variables
    - Utilise une version simplifiée de la propriété et de l’emprunt
  - Bibliothèque standard (Ne contient pas beaucoup pour le moment)
  - [Fonctions natives personnalisées](https://github.com/doonv/bevy_dev_console/blob/master/examples/custom_functions.rs) (Accès à `World` inclus !)
  - [Nombreux types](https://github.com/doonv/bevy_dev_console/wiki/Built%E2%80%90in-Parser#types)
  - Visualisation et modification des ressources
    - Enumérations
    - Structures
  - ~~Requêtes d’entités~~ [*Bientôt disponible...*](https://github.com/doonv/bevy_dev_console/issues/3) (Suggestions pour la syntaxe bienvenues !)
  - ...et plus encore !

## Utilisation

1. Ajoutez le package git `bevy_dev_console`.

    ```bash
    cargo add --git https://github.com/doonv/bevy_dev_console.git
    ```
2. Importez le `préambule`.


    ```rust
    use bevy_dev_console::prelude::*;
    ```

3. Ajouter les plugins.

    ```rust,no_run
    use bevy::{prelude::*, log::LogPlugin};
    use bevy_dev_console::prelude::*;

    App::new()
        .add_plugins((
            // Add the log plugin with the custom log layer
            DefaultPlugins.set(LogPlugin {
                custom_layer: custom_log_layer,
                ..default()
            }),
            // Add the dev console plugin itself.
            DevConsolePlugin,
        ))
        .run();
    ```
4. Voilà ! Vous pouvez maintenant appuyer sur la touche `` ` `` / `~` de votre clavier et cela devrait ouvrir la console !

## Fonctions activables/désactivables

**(par défaut)** `builtin-parser` inclut le parseur par défaut. Désactiver cette option vous permet de retirer le parseur intégré et de le remplacer par le vôtre (ou vous pouvez ne rien faire et transformer la console en lecteur de journal).

## Compatibilité Bevy

| bevy   | bevy_dev_console |
| ------ | ---------------- |
| 0.14.* | git (master)     |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-18

---