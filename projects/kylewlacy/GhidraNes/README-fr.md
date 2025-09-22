# GhidraNes

Une extension Ghidra pour prendre en charge le désassemblage et l'analyse des ROMs NES.

![Désassemblage Ghidra montrant une fonction décompilée à partir d'un fichier nommé "game.nes"](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/ghidra-nes.png)

## Fonctionnalités

- Importer des ROMs NES au format iNES. Les mappers suivants sont pris en charge :
    - PRG ROM fixe 16K/32K
        - [NROM](https://www.nesdev.org/wiki/NROM) (mapper 0)
        - [CNROM](https://www.nesdev.org/wiki/CNROM) (mappers 3, 185)
        - [CPROM](https://www.nesdev.org/wiki/CPROM) (mapper 13)
    - PRG ROM bancable 16K
        - [MMC1/SxROM](https://www.nesdev.org/wiki/MMC1) (mapper 1, inclut aussi le mapper 16)
        - [UxROM](https://www.nesdev.org/wiki/UxROM) (mapper 2)
        - [MMC4/FxROM](https://www.nesdev.org/wiki/MMC4) (mapper 10)
        - [UNROM 512](https://www.nesdev.org/wiki/UNROM_512) (mapper 30)
        - [Sunsoft 3](https://www.nesdev.org/wiki/INES_Mapper_067)/[Sunsoft 4](https://www.nesdev.org/wiki/INES_Mapper_068) (mappers 67, 68)
        - Mapper divers [16](https://www.nesdev.org/wiki/INES_Mapper_016)
    - PRG ROM bancable 32K
        - [AxROM](https://www.nesdev.org/wiki/AxROM) (mapper 7)
        - [BNROM/NINA](https://www.nesdev.org/wiki/INES_Mapper_034) (mapper 34)
        - [GxROM](https://www.nesdev.org/wiki/GxROM) (mapper 66)
        - Mappers divers [11](https://www.nesdev.org/wiki/Color_Dreams), [38](https://www.nesdev.org/wiki/INES_Mapper_038), [140](https://www.nesdev.org/wiki/INES_Mapper_140)
    - PRG ROM bancable 8K
        - [MMC3/TxROM](https://www.nesdev.org/wiki/MMC3)/[TxSROM](https://www.nesdev.org/wiki/INES_Mapper_118)/[TQROM](https://www.nesdev.org/wiki/INES_Mapper_119) (mappers 4, 118, 119)
        - [Namco 129/163](https://www.nesdev.org/wiki/INES_Mapper_019) (mapper 19)
        - [Konami VRC2/4](https://www.nesdev.org/wiki/VRC2_and_VRC4) (mappers 21, 22, 23, 25)
        - [RAMBO-1](https://www.nesdev.org/wiki/RAMBO-1) (mappers 64, 158)
        - [Sunsoft FME-7/5A/5B](https://www.nesdev.org/wiki/Sunsoft_FME-7) (mapper 69)
        - [DxROM](https://www.nesdev.org/wiki/DxROM) (mapper [206](https://www.nesdev.org/wiki/INES_Mapper_206))
        - Mappers divers [18](https://www.nesdev.org/wiki/INES_Mapper_018), [65](https://www.nesdev.org/wiki/INES_Mapper_065), [74](https://www.nesdev.org/wiki/INES_Mapper_074), [76](https://www.nesdev.org/wiki/INES_Mapper_076), [88](https://www.nesdev.org/wiki/INES_Mapper_088), [95](https://www.nesdev.org/wiki/INES_Mapper_095), [154](https://www.nesdev.org/wiki/INES_Mapper_154), [191](https://www.nesdev.org/wiki/INES_Mapper_191), [192](https://www.nesdev.org/wiki/INES_Mapper_192), [194](https://www.nesdev.org/wiki/INES_Mapper_194), [195](https://www.nesdev.org/wiki/INES_Mapper_195)

- Ajout de labels et de blocs mémoire dans le désassemblage, facilitant la navigation dans une ROM désassemblée !

## Installation

1. Installer une version compatible de Java et Ghidra (Java 21+).
2. Télécharger la dernière [version de GhidraNes](https://github.com/kylewlacy/GhidraNes/releases). Assurez-vous que la version téléchargée correspond à votre version de Ghidra !
3. Allez dans "Fichier" > "Installer des extensions...". Cliquez sur "+" en haut à droite et choisissez le Zip GhidraNes. Cliquez sur "OK" pour installer l'extension.
4. Redémarrez Ghidra.

## Utilisation

1. Dans Ghidra, créez un nouveau projet en suivant l'assistant sous "Fichier" > "Nouveau projet...".
2. Glissez-déposez une ROM iNES `.nes` dans le projet. Définissez le format sur "NES ROM" et cliquez sur "OK".
3. Double-cliquez sur la ROM dans le projet pour ouvrir le CodeBrowser de Ghidra.
4. Analysez le fichier lorsqu'on vous le demande (ou allez dans "Analyse" > "Analyse automatique..."). Laissez les paramètres par défaut et cliquez sur "Analyser".
5. Terminé, le jeu sera désassemblé ! Sur le côté gauche, sous "Arbre des symboles" > "Fonctions", ouvrez `reset` pour aller au vecteur de réinitialisation (où l'exécution commence), ou `vblank` pour aller au vecteur NMI (où l'exécution se passe pendant le VBlank).

## Notes

### Changement de banque

GhidraNes mappe chaque banque de la ROM à son propre bloc mémoire, mais il n’y a pas d’analyse de flux de contrôle implémentée qui gère automatiquement le changement de banque. Au lieu de cela, la gestion du changement de banque dans le désassemblage est un processus manuel. Prenez cet exemple de fonction :

![Désassemblage Ghidra montrant une fonction "reset" composée de "LDA #0x0", "STA DAT_8000", et "JMP (0xfffc)=>reset". La gouttière montre cette fonction comme une boucle infinie](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-broken.png)

Cette fonction désassemblée effectue un changement de banque : l’écriture à `DAT_8000` change la banque PRG ROM à la banque 0 dans ce cas. Des cas comme celui-ci peuvent être corrigés dans Ghidra en suivant les étapes suivantes :

1. Clic droit sur l’instruction `JMP`
2. Cliquez sur "Références > Ajouter/Modifier (R)"
3. Double-cliquez sur l’opérande de destination
4. Pour le champ "À l’adresse", changez la liste déroulante de gauche de "RAM:" à la banque mémoire appropriée ("PRG0::" pour cet exemple)
5. Cliquez sur "Mettre à jour"

Le désassemblage devrait maintenant montrer un saut vers la banque correcte :

![Désassemblage Ghidra montrant la même fonction "reset", mais l’instruction "JMP" pointe maintenant vers "(0xfffc)=>LAB_PRG0__ffaf"](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-fixed.png)

> Remarque : Toute instruction d’écriture (par ex. `STA`/`STX`/`STY`, `INC`/`DEC`) vers un registre du mapper provoquera un changement de flux de contrôle si la banque contenant le code actuellement exécuté est remplacée. Pour corriger cela :
>
> 1. Clic droit sur l’instruction d’écriture
> 2. Choisissez `Passage` > `Définir...`
> 3. Notez la valeur dans la case de décalage d’adresse
> 4. Sélectionnez `Utilisateur`, et choisissez la nouvelle banque dans la liste déroulante.
> 5. Mettez la case de décalage d’adresse à la valeur de l’étape 3 (car le PC sera toujours sur l’instruction "suivante" dans la nouvelle banque).
>
> Cela devrait aider à l’analyse et à la décompilation pour qu’elles puissent "suivre" le changement de banque.
Par défaut, les ROM avec des tailles de bloc PRG inférieures à 32K sont créées avec une adresse de base de `0x8000` sauf pour la dernière banque, qui sera à l'adresse la plus "haute" pour cette banque (les blocs de 8K seront à `0xe000`, ceux de 16K à `0xc000`).  Vous pouvez utiliser la boîte de dialogue `Options...` au moment du chargement pour définir l'adresse de chaque banque si vous savez à l'avance où chaque banque doit être.  Si vous déterminez plus tard que la supposition était erronée et que vous ne souhaitez pas réimporter la ROM, vous pouvez rebaser la banque en utilisant la fenêtre Carte Mémoire :

1. Sélectionnez le menu `Fenêtre`>`Carte Mémoire` si elle n'est pas déjà ouverte.
2. Sélectionnez la ligne avec la banque que vous souhaitez modifier.
3. Sélectionnez l'icône croix bleue ("Déplacer un bloc à une autre adresse") dans la barre de titre de la fenêtre Carte Mémoire.
4. Changez la "Nouvelle Adresse de Départ" à la bonne adresse de base. La "Nouvelle Adresse de Fin" devrait se mettre à jour automatiquement en fonction de la taille du bloc.
5. Sélectionnez "OK" et la banque sera mise à jour.

## Développement

### Développer avec Eclipse

1. Installez Java et Ghidra.
2. Installez Eclipse.
3. Installez le plugin Eclipse GhidraDev. Les instructions se trouvent dans votre répertoire d'installation de Ghidra, sous `Extensions/Eclipse/GhidraDev/GhidraDev_README.html`.
4. Dans Eclipse, ouvrez le dépôt GhidraNes en allant dans "Fichier" > "Ouvrir des projets depuis le système de fichiers...". Cliquez sur "Répertoire", puis choisissez ce dépôt (le dossier _racine_ contenant ce fichier `README.md` et le sous-répertoire `GhidraNes`). Enfin, cliquez sur "Terminer".
5. Ouvrez "GhidraDev" > "Lier Ghidra...". Ajoutez votre installation de Ghidra, cliquez sur "Suivant >", puis sélectionnez "GhidraNes" comme projet Java. Cliquez sur "Terminer".
6. Allez dans "Exécuter" > "Exécuter en tant que" > "Ghidra" pour lancer Ghidra avec l’extension GhidraNes.

### Construire une version depuis Eclipse

**NOTE :** Assurez-vous que le projet Eclipse GhidraNes est configuré avec la version de Java la plus _ancienne_ ciblée. Utiliser une version plus récente de Java peut causer des problèmes de compatibilité !

1. Installez Gradle (avec [SDKMAN](https://sdkman.io/), cela peut se faire avec `sdk install gradle`).
2. Dans Eclipse, ouvrez "GhidraDev" > "Exporter" > "Extension de Module Ghidra...". Choisissez "GhidraNes" comme projet, cliquez sur "Suivant >", puis choisissez "Répertoire d'installation local :" et naviguez jusqu’au répertoire d’installation de Gradle (avec SDKMAN, ce sera `~/.sdkman/candidates/gradle/$GRADLE_VERSION`). Cliquez sur "Terminer".
3. Le fichier zip construit sera sauvegardé dans le répertoire `GhidraNes/dist/`. Voir la section "Installation" pour les détails sur l’installation du zip construit.

### Développer avec un autre éditeur (comme VS Code)

1. Installez Java et Ghidra.
2. Configurez les paramètres JDK dans votre éditeur.
    - Pour VSCode : Suivez le guide officiel ["Prise en main de Java dans VS Code"](https://code.visualstudio.com/docs/java/java-tutorial).
3. Copiez le fichier `GhidraNes/gradle.properties.example` vers `GhidraNes/gradle.properties` et configurez le répertoire d’installation de Ghidra selon vos besoins.
4. Importez le dépôt GhidraNes en tant que projet Java (le dossier _racine_ contenant ce fichier `README.md` et le sous-répertoire `GhidraNes`).

### Construire une version avec Gradle

1. Déplacez-vous dans le sous-répertoire interne `GhidraNes` : `cd GhidraNes/GhidraNes`
2. Lancez `gradle buildExtension`

    - Si le fichier `gradle.properties` n'a pas été configuré, les propriétés peuvent être passées directement à Gradle, par exemple `gradle buildExtension -PGHIDRA_INSTALL_DIR=/home/user/ghidra_10.2.2_PUBLIC`
3. Le fichier zip construit sera enregistré dans le répertoire `GhidraNes/dist/`. Voir la section "Installation" pour les détails sur l'installation du zip construit.

## Publication d'une version

1. Mettre à jour `CHANGELOG.md` par un nouveau commit
2. Créer une étiquette pour la nouvelle version. L'étiquette et le nom de la version doivent être nommés `vYYYYMMDD` selon la date actuelle [en UTC](https://www.utctime.net/) (par exemple `v20250520`)
3. Pousser l'étiquette. Cela déclenchera le workflow ["Release" GH Actions](https://github.com/kylewlacy/GhidraNes/actions/workflows/release.yml), qui créera un nouveau [brouillon de version](https://github.com/kylewlacy/GhidraNes/releases) avec les notes de version et les fichiers construits après quelques minutes
4. Vérifier que les fichiers construits sont corrects, ajuster ou ajouter aux notes de version si nécessaire, puis publier !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---