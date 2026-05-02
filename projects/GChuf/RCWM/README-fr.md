# Magie du clic droit sous Windows

Magie du clic droit sous Windows est un ensemble d’outils de menu contextuel (clic droit) pour les administrateurs, utilisateurs avancés et autres êtres magiques. Si vous vous considérez comme un magicien et souhaitez vous épargner du temps et des maux de tête, c’est le bon ensemble d’outils de menu contextuel pour vous.

Ce petit pack magique inclut :
- option pour rétablir l’ancien menu contextuel sous Windows 11
- robocopy pour copier et déplacer des répertoires (beaucoup plus rapide que la copie classique)
- robocopy fonctionne aussi pour copier/déplacer sur des partages réseau
- coller depuis le presse-papiers (avec robocopy)
- SCP depuis/vers
- ouvrir des fenêtres CMD ou PowerShell dans des dossiers ou lecteurs
- exécuter des scripts en tant qu’administrateur pour les scripts .ps1
- prendre possession des fichiers ou répertoires avec récursivité (takeown && icacls)
- options pour démarrer en mode sans échec
- option pour redémarrer en mode récupération
- ouvrir le Panneau de configuration depuis le Bureau
- exécuter des programmes avec une priorité personnalisée
- option pour toujours ouvrir cmd en administrateur
- création de liens symboliques/liens physiques
- ouvrir le "Mode Dieu"
- redémarrer/arrêter dans x secondes
- options pour Déplacer vers / Envoyer vers (depuis Windows 7)
- déconnexion depuis le fond d’écran du bureau
- ouvrir GodMode
- options pour désinstaller les modifications apportées
- désactivation de l’UAC
- activation des chemins longs (chemins de plus de 260 caractères)

Vous pouvez également retirer certaines options du menu clic droit, afin que votre menu ne devienne pas trop encombré :
- Épingler à Accès rapide
- Épingler à l’écran de démarrage
- Inclure dans la bibliothèque
- Envoyer vers
- Partager
- Ajouter à Windows Media Player
- Analyser avec Windows Defender

Autres suppressions :
- onglet "Version" dans l’explorateur


TODO (la magie prend du temps) :
- takeown pour les fichiers (.exe et autres)
- jonctions de répertoires pour plusieurs fichiers/dossiers
- pwsh ouvert avec privilèges administrateur
- ajout d’autres outils admin au clic droit dans le fond
- vos suggestions


![Exemples de magie](https://raw.githubusercontent.com/GChuf/RCWM/magic/img/RCWM.gif)


# Installation


Pour installer les outils : téléchargez le dernier fichier zip dans les releases ([ici](https://github.com/GChuf/RCWM/releases/latest)), dézippez-le et lancez le script install.cmd __en tant qu’administrateur__ - après cela, vous n’aurez besoin que des deux touches les plus utilisées : __*Y*__ et __*N*__ (et peut-être quelques autres).
Si l’utilisateur exécutant les commandes RCWM n’a pas les privilèges administrateur, une partie de la magie pourrait ne pas fonctionner correctement.


# Comment ça marche ?

De la magie, essentiellement. Un peu de code spaghetti aussi.

Pour l’instant, la magie se passe dans le registre Windows avec un peu d’aide des scripts batch et powershell.

L’objectif était d’automatiser les outils en ligne de commande comme robocopy, pour que 1) tout le monde puisse l’utiliser, et 2) cela fasse gagner du temps à ceux qui savent déjà s’en servir. En automatisant les tâches, j’ai découvert par hasard que je pouvais automatiser bien plus que prévu - et maintenant, vous pouvez sélectionner plusieurs dossiers à copier/déplacer et les coller tous dans un seul dossier, comme vous le feriez avec l’interface Windows classique, lente et paresseuse.


# RoboCopy : options Copier et Déplacer des éléments

Copier/Coller & Déplacer Fichier/Répertoire utilisent tous deux robocopy pour effectuer le travail.
Vous avez deux options : vous pouvez copier plusieurs répertoires ou un seul à la fois.

__Unique__ :
Le fichier/dossier (chemin du répertoire) à copier (lorsque vous faites un clic droit sur "Copier") est écrit dans le registre et __écrase__ tous les chemins de dossiers précédemment stockés. Si vous spécifiez un nouveau dossier à copier, l’ancien (s’il existe) sera écrasé.

__Multiple__ :
La liste des chemins de fichiers/dossiers à copier est __ajoutée__ au registre sous les clés *HKCU:\SOFTWARE\RCWM\{rcopy || rcmov}*. Ensuite, le script passe par une boucle powershell pour copier tous les éléments.

Par défaut, vous ne pouvez sélectionner que jusqu’à 15 dossiers à copier (la limite par défaut de Windows pour les options du clic droit est de 15, vous pouvez l’augmenter à 31 ou plus dans le script d’installation - voir le fichier *MultipleInvokeMinimum.reg* pour plus d’informations). La copie/déplacement récursifs ne posent jamais de problème (vous pouvez avoir autant de sous-dossiers que vous voulez).

Utilisez cette option si vous avez l'intention d'utiliser RoboCopy fréquemment. Vous pouvez lire le fichier powershell rcp.ps1 pour comprendre comment le script fonctionne.

Copier (multiple) versus Déplacer (unique) :

![Unique vs Multiple](https://raw.githubusercontent.com/GChuf/RCWM/magic/img/sm.gif)

# RoboCopy : autres options

Vous pouvez également coller des dossiers que vous avez sélectionnés avec ctrl+c. L'option s'appelle "Coller depuis le presse-papiers".
De plus, vous pouvez aussi utiliser l'option de mise en miroir (/MIR) pour refléter un répertoire. Cela ne fonctionne que si vous reflétez le répertoire quelque part où un répertoire portant le même nom existe déjà.

# Bugs connus

- TakeOwn ne fonctionne pas correctement lorsqu'on clique droit sur un très grand nombre de dossiers (les permissions de certains dossiers ne seront pas modifiées - vous devez donc le faire deux fois) ?
Changer la propriété d'un grand nombre de dossiers récursifs fonctionne cependant bien.
- Exécuter avec priorité n'affiche pas le menu pour choisir avec quelle priorité exécuter un programme - veuillez signaler si cela vous arrive
- rmdir et robocopy nécessitent parfois des privilèges administrateur (robocopy renvoie l'erreur 5) - si vous rencontrez cela, takeown ou toujours exécuter cmd en admin aidera

# Tests
RoboCopy est beaucoup plus rapide pour copier une grande quantité de petits fichiers.
RmDir (del et rd) est aussi plus rapide que la suppression "standard", et que l'option /MIR de robocopy lorsqu'on utilise un répertoire vide.

Résultats des tests sur ma machine avec un disque SSD :
Infos du dossier : 1,73 Go / 12 089 fichiers
- rcopy/copie normale : 43s/91s
- rmdir/suppression normale : ~ 3s/4,5s

Les résultats peuvent varier selon votre ordinateur et disque - mais là où il y a beaucoup de petits fichiers, vous devriez en bénéficier.

# Sécurité

RCWM v2 avait quelques problèmes dus au script ps2exe, et sa sortie était signalée par les antivirus.
Je me suis éloigné de ps2exe maintenant.

Tous les fichiers .exe sont vérifiés et marqués sûrs par virus total (les fichiers sont utilisés pour sauvegarder les chemins des dossiers dans le registre sous HKCU) :

[rcwm-single.exe](https://www.virustotal.com/gui/url/3f1d93268323b721b956ac7a015e80a68768fedf34adbbb022b660c06b7f2efb?nocache=1)


[rcwm-multiple.exe](https://www.virustotal.com/gui/url/bcf252d68d68198eb304682dc070f0bed0b14fa159add7e6766c3c41b1feff86?nocache=1)

[RCWMInit.exe](https://www.virustotal.com/gui/url-analysis/u-13bb952212b2d23dce18713803085437b31180b593acb4f4f2d13753269e2db3-21bd70f1?nocache=1)

# Contribution

Vous pouvez toujours créer une PR ou ouvrir un nouveau ticket, concernant des bugs ou des suggestions.

# Support

Le but du projet est de faciliter la vie des autres.

Mettre une étoile au projet les aide à le découvrir.

Si vous voulez, vous pouvez m’offrir un ~~café~~ bière :

- paypal.me : paypal.me/gchuf

- btc : 16BRUTbKu3tSuS9SudCoP7qHreNs6sAp8d

- eth : 0x75240bb1d3fac69954e980ec53d1c93a2d140389

- ltc : LWtm2gXdr29HhaiaXytnaz799RwYbxhz2d

# Crédits

Les fichiers pour démarrer en mode sans échec et exécuter avec priorité ont été fortement influencés par Shawn Brink sur [tenforums.com](https://www.tenforums.com/tutorials/1977-windows-10-tutorial-index.html)

Les fichiers TakeOwn.reg pour prendre possession ont été fortement influencés par Vishal Gupta sur [AskVG.com](https://www.askvg.com/) & Shawn Brink.

L’option Redémarrer en mode récupération a été trouvée quelque part sur internet il y a un certain temps. Malheureusement, je ne me souviens pas de l’auteur original.

L’idée de lancer un script en tant qu’administrateur a été trouvée ici : https://ss64.com/ps/syntax-elevate.html

J’ai modifié et adapté tous ces fichiers, mais leurs idées et implémentations initiales méritent le crédit.

Tout le reste est mon propre travail, avec l’aide d’internet.

# Téléchargements

![Downloads](https://img.shields.io/github/downloads/GChuf/RCWM/total?label=TotalDownloads)

![Downloads-Latest](https://img.shields.io/github/downloads/GChuf/RCWM/latest/total?label=LatestReleaseDownloads)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-02

---