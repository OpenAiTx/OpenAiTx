# Microsoft PowerToys

![Image principale de Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[Comment utiliser PowerToys][usingPowerToys-docs-link] | [Téléchargements & Notes de version][github-release-link] | [Contribuer à PowerToys](#contributing) | [Quoi de neuf](#whats-happening) | [Feuille de route](#powertoys-roadmap)

## À propos

Microsoft PowerToys est un ensemble d'utilitaires destinés aux utilisateurs avancés pour optimiser et personnaliser leur expérience Windows afin d'accroître leur productivité. Pour plus d'informations sur [l'aperçu de PowerToys et l'utilisation des utilitaires][usingPowerToys-docs-link], ou pour tout autre outil et ressource concernant les [environnements de développement Windows](https://learn.microsoft.com/windows/dev-environment/overview), rendez-vous sur [learn.microsoft.com][usingPowerToys-docs-link] !

|              | Utilitaires actuels : |              |
|--------------|----------------------|--------------|
| [Collage avancé](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Toujours au premier plan](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Pipette à couleurs](https://aka.ms/PowerToysOverview_ColorPicker) | [Commande introuvable](https://aka.ms/PowerToysOverview_CmdNotFound) | [Palette de commandes](https://aka.ms/PowerToysOverview_CmdPal) |
| [Rogner et verrouiller](https://aka.ms/PowerToysOverview_CropAndLock) | [Variables d'environnement](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [Extensions pour l'Explorateur de fichiers](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Éditeur de fichier Hosts](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Redimensionneur d'images](https://aka.ms/PowerToysOverview_ImageResizer) | [Gestionnaire de clavier](https://aka.ms/PowerToysOverview_KeyboardManager) | [Utilitaires de souris](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Souris sans frontières](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [Coller en texte brut](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Accent rapide](https://aka.ms/PowerToysOverview_QuickAccent) | [Aperçu du registre](https://aka.ms/PowerToysOverview_RegistryPreview) | [Règle d'écran](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Guide des raccourcis](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Extracteur de texte](https://aka.ms/PowerToysOverview_TextExtractor) | [Espaces de travail](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Installer et exécuter Microsoft PowerToys

### Prérequis

- Windows 11 ou Windows 10 version 2004 (nom de code 20H1 / numéro de build 19041) ou ultérieur.
- Processeur x64 ou ARM64
- Notre installateur installera les éléments suivants :
   - Bootstrapper du [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703). Cela installera la dernière version.

### Via GitHub avec EXE [Recommandé]

Rendez-vous sur la [page des versions GitHub de Microsoft PowerToys][github-release-link] et cliquez sur `Assets` en bas pour afficher les fichiers disponibles dans la release. Veuillez utiliser l'installateur PowerToys approprié correspondant à l’architecture de votre machine et à la portée d’installation. Pour la plupart, il s'agit de `x64` et par utilisateur.

<!-- éléments à mettre à jour à chaque version -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  Description   | Nom du fichier | Hash sha256 |
|----------------|----------------|-------------|
| Par utilisateur - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Par utilisateur - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Pour toute la machine - x64   | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Pour toute la machine - ARM64 | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

C’est notre méthode préférée.

### Via Microsoft Store

Installez depuis la [page PowerToys du Microsoft Store][microsoft-store-link]. Vous devez utiliser le [nouveau Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) qui est disponible pour Windows 11 et Windows 10.

### Via WinGet
Téléchargez PowerToys depuis [WinGet][winget-link]. La mise à jour via winget respectera la portée d'installation actuelle de PowerToys. Pour installer PowerToys, exécutez la commande suivante dans la ligne de commande / PowerShell :

#### Installateur par utilisateur [par défaut]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Installateur pour toute la machine

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Autres méthodes d'installation

Il existe des [méthodes d'installation communautaires](./doc/unofficialInstallMethods.md) telles que Chocolatey et Scoop. Si vous préférez ces solutions, consultez les instructions d'installation correspondantes.

## Plugins tiers pour Run

Une collection de [plugins tiers](./doc/thirdPartyRunPlugins.md) créés par la communauté et non distribués avec PowerToys est disponible.

## Contribution

Ce projet accueille tous types de contributions. Outre le développement de fonctionnalités et la correction de bugs, vous pouvez aussi aider par la rédaction de spécifications, le design, la documentation ou la recherche de bugs. Nous sommes ravis de collaborer avec la communauté des utilisateurs avancés pour construire un ensemble d’outils vous permettant de tirer le meilleur de Windows.

Nous demandons que **vous lisiez notre [Guide du contributeur](CONTRIBUTING.md) avant de commencer à travailler sur une fonctionnalité que vous souhaitez proposer**. Nous serons heureux de collaborer avec vous pour déterminer la meilleure approche, vous guider et vous accompagner tout au long du développement, et vous éviter des efforts redondants ou inutiles.

La plupart des contributions nécessitent d'accepter un [Contrat de Licence du Contributeur (CLA)][oss-CLA] déclarant que vous nous accordez les droits d’utilisation de votre contribution et que vous êtes autorisé à le faire.

Pour obtenir des conseils sur le développement de PowerToys, veuillez consulter la [documentation développeur](/doc/devdocs) pour une explication détaillée, y compris la configuration de votre poste de travail.

## Quoi de neuf

### Feuille de route PowerToys

Notre [feuille de route priorisée][roadmap] des fonctionnalités et utilitaires sur lesquels l’équipe principale se concentre.

### 0.91 - Mise à jour de mai 2025

Dans cette version, nous nous sommes concentrés sur de nouvelles fonctionnalités, la stabilité et l'automatisation.

**✨Points forts**

 - Amélioration significative des performances de la Palette de commandes et correction de nombreux bugs. Parmi les nouvelles fonctionnalités :
 - Ajout de la possibilité pour la Palette de commandes de rechercher n'importe quel fichier via une commande de secours.
 - Ajout de la possibilité de faire du raccourci global de la Palette de commandes un hook clavier bas niveau.
 - Ajout d'une commande de secours d'ouverture d'URL pour l'extension WebSearch, permettant d'ouvrir directement des URL dans le navigateur depuis la Palette de commandes.
 - Il est maintenant possible de définir des formats personnalisés dans les plugins Date et Heure de PT Run et de la Palette de commandes. Merci [@htcfreek](https://github.com/htcfreek) !

### Collage avancé

 - Correction d’un problème où Collage avancé ne parvenait pas à créer le moteur OCR pour certains tags de langue anglaise (par exemple, en-CA) en initialisant le moteur OCR avec la langue du profil utilisateur. Merci [@cryolithic](https://github.com/cryolithic) !

### Pipette à couleurs

 - Correction d’un problème de fuite de ressources causant des blocages ou des plantages, en libérant correctement l’objet Graphics. Merci [@dcog989](https://github.com/dcog989) !
 - Correction d’un problème où la Pipette à couleurs se fermait lors de l’appui sur la touche Retour arrière, en s’assurant qu’elle ne se ferme que lorsqu’elle a le focus et en alignant les comportements Échap/Retour arrière. Merci [@PesBandi](https://github.com/PesBandi) !
 - Ajout de la prise en charge des formats de couleur Oklab et Oklch. Merci [@lemonyte](https://github.com/lemonyte) !

### Commande introuvable

 - Mise à jour du script WinGet Command Not Found pour n’activer les fonctionnalités expérimentales que si elles existent réellement.

### Palette de commandes

 - Mise à jour du modèle de bug pour inclure le module Palette de commandes.
 - Correction d’un problème d’échelle DPI de la fenêtre toast, causant des problèmes d’affichage sous mise à l’échelle de l’écran.
 - Correction d’un problème de navigation clavier Haut/Bas qui ne déplaçait pas la sélection lorsque le curseur était à la position 0, et ajout d’une navigation continue comme PT Run v1. Merci [@davidegiacometti](https://github.com/davidegiacometti) !
 - Simplification et clarification du code de l’extension Date et Heure.
 - Correction d’un problème où la capitalisation dans la commande causait un échec lors du déplacement du pointeur de la souris, résolu en mettant la commande en minuscules.
 - Ajout de la commande de secours d’ouverture d’URL pour l’extension WebSearch, permettant d’ouvrir directement des URL dans le navigateur depuis la Palette de commandes. Merci [@htcfreek](https://github.com/htcfreek) !
 - Ajout d’un paramètre pour activer/désactiver l’icône de la barre d’état système dans CmdPal et alignement de la terminologie avec Windows 11. Merci [@davidegiacometti](https://github.com/davidegiacometti) !
 - Correction d’un problème de mise à jour des alias en supprimant l’ancien lors de la création d’un nouveau.
 - Résolution d’un conflit de casse GitHub en migrant Exts et exts dans un nouveau répertoire ext, assurant une structure cohérente sur toutes les plateformes et évitant la fragmentation des chemins.
 - Correction d’un problème où la commande ‘Créer une nouvelle extension’ générait des noms de fichiers vides.
 - Ajout de la possibilité de faire du raccourci global un hook clavier bas niveau.
 - Prise en charge des miniatures JUMBO, permettant d’accéder à des icônes haute résolution.
 - Correction de plantages lorsque CmdPal se masquait automatiquement pendant l’ouverture d’une boîte de dialogue MSAL, en empêchant CmdPal de se masquer s’il est désactivé.
 - Sélection immédiate du texte de recherche lors du chargement d’une page.
 - Correction d’un bug où les pages de paramètres d’extension ne se rechargeaient pas lors de la réouverture en mettant à jour le formulaire des paramètres lors de l’enregistrement.
 - Correction d’un problème où la Palette de commandes ne se lançait pas depuis le runner.
 - Refactorisation et portage de la logique de calculatrice de PowerToys Run v1 dans la Palette de commandes, ajout de la gestion des paramètres et amélioration du comportement de secours.
 - Réintroduction de la prise en charge des raccourcis clavier sur les éléments de liste.
 - Amélioration de l’accessibilité de la Palette de commandes avec des libellés adaptés, des animations affinées, une meilleure localisation et correction des problèmes a11y.
 - Portage de la gestion des formats personnalisés dans le plugin Date et Heure, réorganisation et nettoyage des paramètres, amélioration des messages d’erreur, et correction de crashs en cas limites pour un comportement plus robuste et convivial. Merci [@htcfreek](https://github.com/htcfreek) !
 - Ajout d’un élément de secours pour la commande système.
 - Correction d’un bug dans la commande système Windows où l’invite de touche affichait incorrectement "Empty" pour l’action "Ouvrir la corbeille". Merci [@jironemo](https://github.com/jironemo) !
 - Correction d’un problème où la liste ‘plus de commandes’ affichait des commandes qui ne devraient pas être visibles. Merci [@davidegiacometti](https://github.com/davidegiacometti) !
 - Correction d’un problème d’affichage d’une icône surdimensionnée et d’un texte mal aligné dans la vue détaillée, aligné avec le comportement de Windows Search.
 - Correction d’un bug où le contenu vide de l’écran et les commandes de la barre de commandes étaient coupés en cas de libellés longs, assurant un affichage correct.
 - Amélioration de l’intégration WinGet de CmdPal : correction de l’affichage des versions pour les packages installés, activation des mises à jour avec icônes, migration de l’API winget de préversion vers la version stable.
 - Correction d’un bug où les commandes pour ContentPage n’étaient mises à jour qu’après la sortie, en s’assurant que les menus contextuels sont entièrement initialisés lors des changements.
 - Ajout de la prise en charge de la commande de secours dans l’extension TimeDate, permettant des requêtes directes sans sélection préalable.
 - Importation de Common.Dotnet.AotCompatibility.props dans plusieurs fichiers de projet CmdPal pour améliorer la compatibilité AoT.
 - Correction d’un crash dans les paramètres CmdPal causé par une touche de raccourci nulle lorsque settings.json est absent ou sans raccourci défini. Merci [@davidegiacometti](https://github.com/davidegiacometti) !
 - Prise en charge des menus contextuels filtrables et imbriqués dans CmdPal, incluant une barre de recherche pour garder le focus.
 - Refactorisation des classes CmdPal pour améliorer la sérialisation JSON et introduction de nouveaux contextes de sérialisation pour de meilleures performances et maintenabilité.
 - Ajout du support de la compilation anticipée (AoT).
 - Ajout d’un mécanisme de relance pour CmdPal.
 - Suppression de fichiers inutilisés dans CmdPal.Common pour simplifier la base de code et faciliter sa compatibilité AoT.
 - Correction d’un bug où une condition de concurrence dans la mise à jour de SearchText faisait sauter automatiquement le curseur à la fin de la ligne, la mise à jour n’ayant lieu qu’après un réel changement.
 - Prise en charge de la recherche de n’importe quel fichier via la commande de secours.
 - Nettoyage du code lié à AoT pour éviter les opérations en double lors des tests.
 - Réduction du temps de chargement de CmdPal en parallélisant l’initialisation des extensions et en ajoutant des délais pour éviter qu’une extension défaillante ne bloque les autres.
 - Amélioration du comportement de l’UI en fermant le volet de détails lorsque la liste est vidée, évitant les états visuels incohérents.
 - Prise en charge de la suppression de la commande de secours dans CmdPal quand aucune commande ne correspond, assurant un rechargement plus propre.
 - Correction d’une fuite dans le modèle d’extension CmdPal via une mauvaise utilisation de ComServer.
 - Empêche la fenêtre CmdPal de se maximiser via un double-clic sur la barre de titre pour maintenir le comportement prévu. Merci [@davidegiacometti](https://github.com/davidegiacometti) !
 - Correction d’un problème où l’UI des Paramètres était lancée trop petite en rendant les dimensions de la fenêtre sensibles au DPI et en imposant des largeurs/hauteurs minimales via WinUIEx.
 - Correction d’un flash blanc et des problèmes d’animation unique dans CmdPal en masquant la fenêtre plutôt qu’en la cachant.
 - Correction d’un bug où tous les paramètres d’extension étaient chargés au démarrage en chargeant les paramètres à la demande, réduisant ainsi la surcharge d’initialisation.
 - Protection de CmdPal contre les crashs lors de l’échec d’analyse des Adaptive Cards.
 - Remplacement de shell:AppsFolder par l’activation URI dans CmdPal pour une meilleure fiabilité.
 - Ajout de la possibilité d’ouvrir les paramètres CmdPal depuis les Paramètres PowerToys.
 - Ajout de la possibilité à CmdPal d’observer et de mettre à jour dynamiquement les détails d’extension en suivant les changements de propriétés sur l’élément sélectionné.
 - Mise à jour de la version du toolkit utilisé dans le modèle d’extension CmdPal à 0.2.0.

### Redimensionneur d’images

 - Correction d’un problème où la suppression d’un préréglage supprimait le mauvais préréglage.

### Gestionnaire de clavier

 - Correction d’un problème où une touche modificatrice, définie sans spécifier gauche ou droite, pouvait rester bloquée en raison d’une mauvaise gestion, en suivant les touches pressées et en envoyant la bonne touche. Merci [@mantaionut](https://github.com/mantaionut) !

### PowerRename

 - Amélioration de la gestion du format horaire avec l’ajout de motifs au format 12h avec prise en charge AM/PM. Merci [@bitmap4](https://github.com/bitmap4) !

### PowerToys Run

 - Ajout du support des formats personnalisés dans le plugin "Date et heure" et amélioration des messages d’erreur pour les formats invalides. Merci [@htcfreek](https://github.com/htcfreek) !
 - Correction de deux plantages : un pour WFT sur des dates très anciennes, un autre pour le calcul de la semaine du mois sur des dates très tardives (ex. 31.12.9999), et réorganisation des paramètres UI. Merci [@htcfreek](https://github.com/htcfreek) !
 - Correction d’un problème où la capitalisation dans la commande causait un échec lors du déplacement du pointeur de la souris, résolu en mettant la commande en minuscules.
 - Ajout des détails de version aux messages d’erreur des plugins pour "Erreur de chargement" et "Erreur d’initialisation". Merci [@htcfreek](https://github.com/htcfreek) !
 - Amélioration du modèle de résultat en ajoutant la possibilité de prévenir le tri basé sur l’utilisation, offrant aux développeurs de plugins un meilleur contrôle du tri. Merci [@CoreyHayward](https://github.com/CoreyHayward) et [@htcfreek](https://github.com/htcfreek) !

### Accent rapide

 - Mise à jour du mappage des lettres dans GetDefaultLetterKeyEPO, remplacement de "ǔ" par "ŭ" pour la touche VK_U afin de refléter correctement la phonétique de l’espéranto. Merci [@OlegKharchevkin](https://github.com/OlegKharchevkin) !
 - Correction d’un problème où Accent rapide ne fonctionnait pas correctement avec le clavier visuel. Merci [@davidegiacometti](https://github.com/davidegiacometti) !

### Aperçu du registre

 - Amélioration de l’Aperçu du registre pour permettre le collage de clés et valeurs sans écrire manuellement l’en-tête du fichier, et ajout d’un bouton de réinitialisation de l’application. Merci [@htcfreek](https://github.com/htcfreek) !

### Paramètres

 - Correction d’un problème où l’application Paramètres affichait aléatoirement une icône blanche dans la barre des tâches en différant l’attribution de l’icône jusqu’à l’activation de la fenêtre.
 - Ajout de la possibilité de maximiser la fenêtre "Quoi de neuf" pour un meilleur confort de lecture.

### Espaces de travail

 - Correction de bugs où les jeux Steam n’étaient pas capturés ou lancés correctement en mettant à jour le filtrage des fenêtres et en intégrant la gestion du protocole URL de Steam.

### Documentation

 - Ajout de QuickNotes à la documentation des plugins tiers de PowerToys Run. Merci [@ruslanlap](https://github.com/ruslanlap) !
 - Ajout des plugins Weather et Pomodoro à la documentation des plugins tiers de PowerToys Run. Merci [@ruslanlap](https://github.com/ruslanlap) !
 - Ajout du plugin Linear à la documentation des plugins tiers de PowerToys Run. Merci [@vednig](https://github.com/vednig) !
 - Correction de problèmes de formatage dans la documentation et mise à jour des informations sur les contributeurs et membres de l’équipe. Merci [@DanielEScherzer](https://github.com/DanielEScherzer) et [@RokyZevon](https://github.com/RokyZevon) !

### Développement

 - Mise à jour de l’Action GitHub pour installer .NET 9 pour le support de la publication MSStore.
 - Mise à jour du placeholder de version dans bug_report.yml pour éviter des versions incorrectes v0.70.0 dans les rapports d’incident.
 - Mise à jour de l’Action GitHub pour passer actions/setup-dotnet de la version 3 à la version 4 pour MSStore.
 - Ajout de securityContext dans les fichiers de configuration WinGet, permettant l’appel depuis le contexte utilisateur et l’invocation d’un seul UAC pour les ressources élevées dans un processus séparé. Merci [@mdanish-kh](https://github.com/mdanish-kh) !
 - Changement de l’extension des fichiers journaux de .txt à .log pour une meilleure association de fichiers et compatibilité des outils, et ajout de logs pour Workspace. Merci [@benwa](https://github.com/benwa) !
 - Mise à jour des dépendances du framework de test et harmonisation des versions des packages.
 - Mise à jour des dépendances pour corriger des vulnérabilités.
 - Renforcement de la sécurité du dépôt en figeant les versions des actions GitHub et des tags Docker, et intégration de l’analyse automatisée des vulnérabilités via Dependency Review Workflow. Merci [@Nick2bad4u](https://github.com/Nick2bad4u) !
 - Mise à jour des dépendances Boost vers une version plus récente.
 - Mise à jour du toolkit à la dernière version, suppression des avertissements liés à AoT.
 - Correction d’un problème de signature manquante sur de nouveaux fichiers causant des échecs de build.
 - Mise à jour du pipeline de release pour éviter la publication de symboles privés pendant 100 ans.
 - Introduction du fuzzing pour PowerRename afin d’améliorer la fiabilité et ajout de la documentation pour l’étendre à d’autres modules C++.
 - Centralisation de la pré-création des dossiers générés pour tous les projets .csproj afin d’éviter les échecs de build.
 - Mise à jour de WinAppSDK à la version 1.7 la plus récente.
 - Mise à jour des dépendances Boost pour le projet de fuzzing PowerRename.
 - Mise à jour du chemin d’aire ADO dans tsa.json pour résoudre des erreurs de pipeline TSA causées par un chemin obsolète.
 - Début du support AoT pour CmdPal avec des travaux préliminaires en cours.
  
### Outils/Général

 - Ajout du support pour l’automatisation de la création de rapports de bugs en générant une URL GitHub pré-remplie avec les informations système et de diagnostic. Merci [@donlaci](https://github.com/donlaci) !
 - Ajout de scripts pour construire localement l’installateur, assurant que CmdPal peut aussi être lancé en local.
 - Suppression de la logique d’export PFX pour éliminer l’utilisation de mots de passe codés en dur et résoudre l’avertissement de sécurité PSScriptAnalyzer.
 - Ajout d’un script PowerShell et intégration CI pour imposer l’utilisation cohérente de Common.Dotnet.CsWinRT.props dans tous les projets C# sous le dossier src.
   
### Ce qui est prévu pour la version 0.92

Pour [v0.92][github-next-release-work], nous travaillerons sur les points suivants :

 - Améliorations continues de la Palette de commandes
 - Nouveaux tests d’automatisation de l’UI
 - Amélioration de la mise à jour de l’installateur
 - Mise à niveau de l’éditeur du Gestionnaire de clavier
 - Corrections de stabilité/bugs

## Communauté PowerToys

L’équipe PowerToys est extrêmement reconnaissante d’avoir [le soutien d’une communauté active exceptionnelle][community-link]. Votre travail est incroyablement important. PowerToys ne serait pas ce qu’il est aujourd’hui sans votre aide pour signaler les bugs, mettre à jour la documentation, orienter le design ou développer des fonctionnalités. Nous tenons à vous remercier et à reconnaître votre contribution. Mois après mois, vous contribuez directement à améliorer PowerToys.

## Code de conduite

Ce projet a adopté le [Code de conduite Open Source Microsoft][oss-conduct-code].

## Déclaration de confidentialité

L’application enregistre des données de diagnostic de base (télémétrie). Pour plus d’informations sur la confidentialité et les données collectées, consultez notre [documentation sur les données et la confidentialité de PowerToys](https://aka.ms/powertoys-data-and-privacy-documentation).

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---