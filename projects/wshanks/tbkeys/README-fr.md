[![Contributor Covenant](https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg)](code_of_conduct.md)

# <a name="intro"></a>tbkeys

`tbkeys` est un module complémentaire pour Thunderbird qui utilise [Mousetrap](https://craig.is/killing/mice) pour associer des séquences de touches à des commandes personnalisées.

## Installation

- Téléchargez le fichier tbkeys.xpi depuis l'une des versions listées sur la [page des releases GitHub](https://github.com/willsALMANJ/tbkeys/releases).
- Ouvrez le gestionnaire de modules complémentaires dans Thunderbird (Outils->Modules complémentaires).
- Cliquez sur l'icône d'engrenage en haut à droite et choisissez "Installer un module depuis un fichier..." puis sélectionnez le fichier tbkeys.xpi téléchargé.
- Le module complémentaire se mettra à jour automatiquement depuis la page des releases GitHub lors des futures mises à jour.

La version [tbkeys-lite](#tbkeys-lite) du module peut également être installée depuis addons.thunderbird.net en recherchant "tbkeys-lite" dans le gestionnaire de modules complémentaires de Thunderbird ou en téléchargeant le fichier xpi depuis [cette page](https://addons.thunderbird.net/en-US/thunderbird/addon/tbkeys-lite/) et en suivant les étapes ci-dessus.

## Raccourcis clavier par défaut

Les raccourcis clavier par défaut pour la fenêtre principale sont calqués sur ceux de GMail.

| Touche | Fonction                                          |
| --- | ------------------------------------------------- |
| c   | Rédiger un nouveau message                        |
| r   | Répondre                                          |
| a   | Répondre à tous                                   |
| f   | Transférer                                        |
| #   | Supprimer                                        |
| u   | Actualiser le courrier. Si un onglet de message est ouvert, le fermer. |
| j   | Message suivant                                  |
| k   | Message précédent                                |
| o   | Ouvrir le message                                |
| x   | Archiver le message                              |

## Personnalisation des raccourcis clavier

Pour personnaliser les raccourcis clavier, modifiez les entrées "key bindings" dans le panneau des préférences du module accessible depuis l'entrée du module dans le gestionnaire de modules complémentaires ("Modules complémentaires" dans le menu Thunderbird).  
Voici quelques points à considérer lors de la définition des raccourcis clavier :

- L'entrée "key bindings" doit être un objet JSON associant des raccourcis clavier (avec la syntaxe Mousetrap décrite [ici](https://craig.is/killing/mice)) à une commande valide (voir la section [Syntaxe des commandes](#command-syntax)).
- Il y a des champs séparés dans la page des préférences pour définir les raccourcis clavier pour la fenêtre principale de Thunderbird et la fenêtre de rédaction.  
  Les raccourcis ne fonctionnent pas dans d'autres fenêtres.
- Les raccourcis clavier ne s’activent pas dans les champs de saisie de texte à moins que la première combinaison de touches n’inclue un modificateur autre que `shift`.
- La page des préférences n’autorise pas la soumission d’un JSON invalide, mais elle ne vérifie pas la cohérence des raccourcis autrement.
- Cette [ancienne page wiki sur Keyconfig](http://kb.mozillazine.org/Keyconfig_extension:_Thunderbird) contient également des commandes encore valides.
- La boîte à outils développeur (Outils->Outils de développement->Boîte à outils développeur dans le menu) peut être utile pour explorer l’interface et trouver le nom d’un élément pour appeler une fonction dessus.
- La définition d’une séquence de touches (c’est-à-dire plusieurs touches successives) dont la première combinaison est identique à un raccourci intégré (comme `ctrl+j ctrl+k`) n’est pas prise en charge.
  Des touches simples avec modificateurs peuvent être mappées pour remplacer les raccourcis intégrés mais pas des séquences.

### Syntaxe des commandes

Plusieurs styles de commandes peuvent être spécifiés pour les raccourcis clavier.
Ils sont :

- **Commandes simples** : Ces commandes suivent le format `cmd:<nom_de_commande>` où `<nom_de_commande>` est une commande que Thunderbird peut exécuter avec `goDoCommand()`.
  La plupart des noms de commandes se trouvent dans [le fichier principal des commandes](https://hg.mozilla.org/comm-central/file/tip/mail/base/content/mainCommandSet.inc.xhtml) du code source de Thunderbird.
- **Appels de fonction simples** : Ces commandes suivent le format `func:<nom_de_fonction>` où `<nom_de_fonction>` est une fonction définie sur l’objet fenêtre de Thunderbird.
  Cette fonction est appelée sans aucun argument.
- **Appels de fonction personnalisés** : Ces commandes suivent le format `tbkeys:<nom_de_fonction>` où `<nom_de_fonction>` est le nom d’une fonction personnalisée écrite dans tbkeys.
  Actuellement, la seule fonction personnalisée disponible est `closeMessageAndRefresh` qui ferme l’onglet ouvert s’il n’est pas le premier onglet puis actualise tous les comptes.
  Ce comportement imite celui du raccourci GMail `u`.
- **Désactivation d’un raccourci** : Ces entrées contiennent simplement le texte `unset`.
  Lorsqu’un raccourci `unset` est déclenché, rien ne se passe.
  Ceci peut être utile pour désactiver des raccourcis intégrés de Thunderbird que vous ne souhaitez pas activer par accident.
- **Messages MailExtension** : Ces commandes suivent le format `memsg:<ID_extension>:<message>` où `<ID_extension>` est l’ID de l’extension Thunderbird à laquelle envoyer un message et `<message>` est une chaîne de caractères à envoyer à l’extension via l’API MailExtension `browser.runtime.sendMessage()`.
  Actuellement, seuls les messages sous forme de chaînes sont pris en charge car `tbkeys` stocke ses commandes sous forme de chaînes, bien que cette restriction pourrait être assouplie à l’avenir.
- <a name="eval"></a>**Commandes Eval** : Ces entrées peuvent contenir du code javascript arbitraire sur lequel tbkeys appellera `eval()` lorsque le raccourci est déclenché.
  Toute entrée ne correspondant pas aux préfixes des autres types de commandes est traitée comme une commande eval.
  **REMARQUE :** les commandes eval ne sont pas disponibles dans tbkeys-lite et fonctionneront comme des commandes unset.

## Raccourcis courants

Voici quelques exemples de commandes eval pour des raccourcis fréquemment désirés :

- **Onglet suivant** : `window.document.getElementById('tabmail-tabs').advanceSelectedTab(1, true)`
- **Onglet précédent** : `window.document.getElementById('tabmail-tabs').advanceSelectedTab(-1, true)`
- **Fermer l’onglet** : `func:CloseTabOrWindow`
- **Faire défiler la liste des messages vers le bas** : `window.document.getElementById('threadTree').scrollByLines(1)`
- **Faire défiler la liste des messages vers le haut** : `window.document.getElementById('threadTree').scrollByLines(-1)`
- **Faire défiler le corps du message vers le bas** :
  - v115+ : `window.gTabmail.currentAboutMessage.getMessagePaneBrowser().contentWindow.scrollBy(0, 100)`
  - v102 : `window.document.getElementById('messagepane').contentDocument.documentElement.getElementsByTagName('body')[0].scrollBy(0, 100)`
- **Faire défiler le corps du message vers le haut** :  
  - v115+ : `window.gTabmail.currentAboutMessage.getMessagePaneBrowser().contentWindow.scrollBy(0, -100)`  
  - v102 : `window.document.getElementById('messagepane').contentDocument.documentElement.getElementsByTagName('body')[0].scrollBy(0, -100)`  
- **Créer un nouveau dossier** : `window.goDoCommand('cmd_newFolder')`  
- **S’abonner à un flux** : `window.openSubscriptionsDialog(window.GetSelectedMsgFolders()[0])`  

## Désactivation des raccourcis clavier par défaut  

Le bouton "Désactiver les simples" dans le panneau des préférences peut être utilisé pour désactiver les raccourcis clavier simples par défaut de Thunderbird dans la fenêtre principale.  
Cette fonction définit tous les raccourcis clavier simples par défaut de Thunderbird sur `unset` sauf s’ils sont déjà configurés dans les préférences de tbkey (c’est-à-dire qu’elle ne remplacera pas les réglages existants de tbkeys pour les raccourcis simples).  

## <a name="tbkeys-lite"></a>tbkeys et tbkeys-lite  

tbkeys-lite est une version de tbkeys dont la capacité d’exécuter du javascript arbitraire a été supprimée.  

## Sécurité, confidentialité et implémentation  

Avant l’installation, Thunderbird affiche une demande d’autorisation indiquant que l’extension nécessite la permission d’« avoir un accès complet et illimité à Thunderbird et à votre ordinateur ».  
La raison de cette demande d’autorisation est que tbkeys doit injecter un écouteur de touches dans l’interface utilisateur de Thunderbird afin d’écouter les raccourcis clavier.  
Pour cela, tbkeys utilise l’ancienne interface d’extension de Thunderbird qui précède les MailExtensions.  
Cette interface était utilisée par toutes les extensions avant Thunderbird 68.  
Les nouvelles API MailExtensions, qui offrent un contrôle plus strict sur ce que les extensions peuvent faire, ne disposent pas d’une API pour les raccourcis clavier.  
Si vous souhaitez qu’une API de raccourcis clavier soit ajoutée à Thunderbird, merci de considérer contribuer au projet.  
Peut-être que [ce ticket](https://bugzilla.mozilla.org/show_bug.cgi?id=1591730) dans le suivi des problèmes de Thunderbird pourrait être un point de départ.  

Pour discuter plus en détail des considérations de sécurité liées à tbkeys, il est nécessaire d’examiner son implémentation.  
Comme mentionné dans l’[intro](#intro), tbkeys s’appuie sur la bibliothèque Mousetrap pour gérer les raccourcis clavier.  
La majeure partie de la logique de tbkeys se trouve dans [implementation.js](https://raw.githubusercontent.com/wshanks/tbkeys/main/addon/implementation.js) qui est une [expérimentation MailExtension](https://developer.thunderbird.net/add-ons/mailextensions/experiments).  
`implementation.js` configure l’API d’expérimentation qui peut être appelée par l’extension MailExtension standard (à portée restreinte) de tbkey pour associer des raccourcis clavier à des fonctions (y compris une fonction nulle pour désassocier) et à des messages à envoyer à d’autres extensions.  
`implementation.js` charge également Mousetrap dans chaque fenêtre Thunderbird, ajuste les conditions dans lesquelles Mousetrap capture un événement de touche pour tenir compte des éléments spécifiques à l’interface Thunderbird, et définit la fonction qui exécute ce que l’utilisateur spécifie pour chaque raccourci clavier.  
C’est tout ce que fait `implementation.js`.  
Il n’accède pas au système de fichiers local ni aux données des messages et n’accède pas au réseau.  

Un des modes de commande pris en charge par tbkeys est [eval](#eval).  
Ce mode utilise `eval()` pour exécuter un code arbitraire fourni par l’utilisateur dans `implementation.js` avec un accès complet aux internals de Thunderbird.  
Si on n’a pas besoin d’associer du code arbitraire, il y a peut-être un avantage en termes de sécurité à utiliser [tbkeys-lite](#tbkeys-lite) qui ne supporte pas les commandes eval.  
tbkeys-lite est la version publiée sur la [page des modules complémentaires de Thunderbird](https://addons.thunderbird.net/en-US/thunderbird/addon/tbkeys-lite/).  
Les modules complémentaires publiés là-bas font l’objet d’une revue manuelle indépendante.  
Avoir cette barrière de revue entre vous et le développeur apporte une couche supplémentaire de sécurité.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-02

---