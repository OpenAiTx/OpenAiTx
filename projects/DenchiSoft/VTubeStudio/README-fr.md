# <a href="https://denchisoft.com"><img src="https://raw.githubusercontent.com/DenchiSoft/VTubeStudio/master/Images/vtube_studio_logo_nyan_2.png" width="542" /></a><br> [![Licence : MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/DenchiSoft/VTubeStudio/blob/master/LICENSE) [![Discord VTube Studio](https://discordapp.com/api/guilds/652602255748497449/widget.png?style=shield)](https://discord.gg/VTubeStudio) [![Étoiles](https://img.shields.io/github/stars/DenchiSoft/VTubeStudio?style=social)](https://github.com/DenchiSoft/VTubeStudio) [![Suivre sur Twitter](https://img.shields.io/twitter/follow/VTubeStudio.svg?style=social)](https://twitter.com/VTubeStudio)


[![Discord VTube Studio](https://discordapp.com/api/guilds/652602255748497449/widget.png?style=banner2)](https://discord.gg/VTubeStudio)

## Cherchez-vous le [Manuel de VTube Studio](https://github.com/DenchiSoft/VTubeStudio/wiki) ?

Vous pouvez le trouver ici : https://github.com/DenchiSoft/VTubeStudio/wiki

## Cherchez-vous une [liste des Plugins VTube Studio](https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins) ?

Consultez cette page : https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins

## Êtes-vous un développeur cherchant un moyen de recevoir les données de suivi depuis l’application iPhone VTube Studio ?

Le processus pour demander les données de suivi depuis l’application iOS VTube Studio est décrit ici : https://github.com/DenchiSoft/VTubeStudioBlendshapeUDPReceiverTest

## Êtes-vous un développeur qui souhaite apprendre à créer des Plugins VTube Studio ?

Tout ce que vous cherchez se trouve sur cette page. Si vous avez des questions, veuillez les poser sur le [Discord](https://discord.gg/VTubeStudio).

## Contenu

- [Informations générales](#general-info)
- [Informations légales](#legal-info)
- [Plugins et exemples disponibles](#available-examples)
- [API d’événements](#event-api)
- [Détails de l’API](#api-details)
  - [Permissions API](#api-permissions)
  - [Découverte du serveur API (UDP)](#api-server-discovery-udp)
  - [Authentification](#authentication)
  - [S’abonner et se désabonner des événements](#subscribing-to-and-unsubscribing-from-events)
  - [Obtenir les statistiques actuelles de VTS](#getting-current-vts-statistics)
  - [Obtenir la liste des dossiers VTS](#getting-list-of-vts-folders)
  - [Obtenir le modèle actuellement chargé](#getting-the-currently-loaded-model)
  - [Obtenir une liste des modèles VTS disponibles](#getting-a-list-of-available-vts-models)
  - [Charger un modèle VTS par son ID](#loading-a-vts-model-by-its-id)
  - [Déplacer le modèle VTS actuellement chargé](#moving-the-currently-loaded-vts-model)
  - [Demander la liste des raccourcis disponibles dans le modèle VTS actuel ou un autre](#requesting-list-of-hotkeys-available-in-current-or-other-vts-model)
  - [Demander l’exécution des raccourcis](#requesting-execution-of-hotkeys)
  - [Demande de liste des expressions et de leur état](#requesting-current-expression-state-list)
  - [Demande d’activation/désactivation des expressions](#requesting-activation-or-deactivation-of-expressions)
  - [Demande de liste des ArtMeshes dans le modèle actuel](#requesting-list-of-artmeshes-in-current-model)
  - [Teindre les ArtMeshes avec une couleur](#tint-artmeshes-with-color)
  - [Obtenir la couleur de superposition de l’éclairage de la scène](#getting-scene-lighting-overlay-color)
  - [Vérifier si le visage est actuellement détecté par le tracker](#checking-if-face-is-currently-found-by-tracker)
  - [Demande de liste des paramètres de suivi disponibles](#requesting-list-of-available-tracking-parameters)
  - [Obtenir la valeur d’un paramètre spécifique, par défaut ou personnalisé](#get-the-value-for-one-specific-parameter-default-or-custom)
  - [Obtenir la valeur de tous les paramètres Live2D dans le modèle actuel](#get-the-value-for-all-live2d-parameters-in-the-current-model)
  - [Ajout de nouveaux paramètres de suivi (« paramètres personnalisés »)](#adding-new-tracking-parameters-custom-parameters)
  - [Supprimer des paramètres personnalisés](#delete-custom-parameters)
  - [Fournir des données pour les paramètres par défaut ou personnalisés](#feeding-in-data-for-default-or-custom-parameters)
  - [Obtenir les réglages physiques du modèle VTS actuellement chargé](#getting-physics-settings-of-currently-loaded-vts-model)
  - [Remplacer les réglages physiques du modèle VTS actuellement chargé](#overriding-physics-settings-of-currently-loaded-vts-model)
  - [Obtenir et/ou définir les réglages NDI](#get-and-set-ndi-settings)
  - [Demande de liste des éléments disponibles ou des éléments dans la scène](#requesting-list-of-available-items-or-items-in-scene)
  - [Chargement d’un élément dans la scène](#loading-item-into-the-scene)
  - [Suppression d’un élément de la scène](#removing-item-from-the-scene)
  - [Contrôle des éléments et des animations d’éléments](#controling-items-and-item-animations)
  - [Déplacement des éléments dans la scène](#moving-items-in-the-scene)
  - [Définir l’ordre de tri des éléments dans le modèle](#set-item-within-model-sorting-order)
  - [Demander à l’utilisateur de sélectionner des ArtMeshes](#asking-user-to-select-artmeshes)
  - [Épingler des éléments au modèle](#pin-items-to-the-model)
  - [Obtenir la liste des effets de post-traitement et leur état](#get-list-of-post-processing-effects-and-state)
  - [Définir les effets de post-traitement](#set-post-processing-effects)
  
## Informations générales

VTube Studio dispose d’une **API publique**. Cela signifie que vous pouvez écrire des plugins/scripts qui peuvent déclencher des raccourcis clavier, alimenter les données de suivi facial, charger des éléments, charger des modèles, recevoir des notifications d’événements, teindre les ArtMeshes du modèle et bien plus encore.

Si vous développez un plugin ou une application pouvant être utilisée avec VTube Studio, veuillez ouvrir une PR et je l’ajouterai à la liste sur cette page.

## Informations légales

Vous êtes libre d’écrire, publier et vendre tout plugin que vous souhaitez pour VTube Studio. Aucune autorisation n’est requise et il n’y a pas de frais de licence ni de redevances.

## Exemples disponibles

Si vous êtes un utilisateur de VTube Studio à la recherche de plugins utilisables, consultez la [page wiki de la liste des plugins](https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins).

Si vous êtes un développeur à la recherche d’exemples/bibliothèques à consulter pour faciliter l’intégration de l’API VTube Studio dans votre application, veuillez consulter le tableau suivant.

:warning: **Si vous avez créé quelque chose que vous souhaitez voir inclus ici, ouvrez une pull request avec le tableau modifié !!** :warning:

| Plugin | Développeur | Type | Explication |
| --- | --- | --- | --- |
| [Cheers Bot](https://cheers.hawk.bar/) | [Hawkbar](https://twitter.com/HawkbarGaming) | Application | Une plateforme d’intégration Twitch basée sur le web qui peut déclencher des actions dans VTube Studio lorsque les spectateurs utilisent des points de chaîne, parmi de nombreuses autres fonctionnalités. |
| [VTubeStudioJS](https://github.com/Hawkbat/VTubeStudioJS) | [Hawkbar](https://twitter.com/HawkbarGaming) | Bibliothèque | Une bibliothèque JavaScript destinée aux autres auteurs de plugins qui implémente l’API WebSocket de VTube Studio. Compatible avec NodeJS et les navigateurs. |
| [VTS Linker - SMB1](https://github.com/Renpona/VTStudio-Linker-SMB1) | [Renpona](https://twitter.com/renpona) | Exemple | Un prototype pour lire les données d’une copie émulée de Super Mario Bros, et utiliser ces données pour déplacer et recolorer automatiquement un modèle Live2D dans VTS selon ce qui se passe dans le jeu. |
| [VTchaos](https://github.com/Raelice/VTchaos) | [Raelice](https://twitter.com/theraelice) | Application | Un programme qui lit les chats YouTube et Twitch pour effectuer des fonctions telles que le changement de modèle, la rotation, les raccourcis clavier et le mouvement dans VTube Studio via des commandes simples dans le chat. |
| [Mix It Up](https://mixitupapp.com/) | [Mix It Up](https://twitter.com/mixitupapp) | Application | Bot de streaming pour chat, événements et autres fonctionnalités impressionnantes ! |
| [VsPyYt](https://github.com/mlo40/VsPyYt) | [emlo40](https://emlo40.com) | Application/Cadre | VsPyYt est une application en ligne de commande capable de lire le chat YouTube et d’exécuter des commandes sauvegardées dans token.json. Vous pouvez aussi l’utiliser comme base pour des programmes Python interagissant avec VTube Studio. |
| [VTS-Sharp](https://github.com/FomTarro/VTS-Sharp) | [Skeletom](https://www.twitter.com/FomTarro) | Bibliothèque | Une bibliothèque Unity/C# destinée aux autres auteurs de plugins qui implémente l’API WebSocket de VTube Studio. |
| [node-red-contrib-vts](https://github.com/eslym/node-red-contrib-vts) | [0nepeop1e](https://github.com/eslym) | Bibliothèque | Un package de bibliothèque qui fournit un nœud pour Node-RED afin d’intégrer VTube Studio. |
| [VTS Mod](https://github.com/MechaWolfVtuberShin/VTS-Mod/releases/tag/vts-mod) | [MechaWolfVtuber_Shin](https://github.com/MechaWolfVtuberShin) | Application | Un programme qui permet aux utilisateurs de changer la couleur de surface du modèle, y compris le RGB. Il peut aussi changer la rotation du modèle. |
| [Tie Tools: VTS Color Editor](https://tie-tools.tiberiusx.me) | [Prof. Tiberius](https://www.twitter.com/prof_tiberius) | Application | Application web offrant un contrôle approfondi des couleurs et de l’opacité de parties spécifiques de votre modèle. |
| [vtubestudio-rs](https://github.com/walfie/vtubestudio-rs) | [Walfie](https://www.twitter.com/walfieee) | Bibliothèque | Une bibliothèque Rust destinée aux autres auteurs de plugins qui implémente l’API WebSocket de VTube Studio. |
| [vts-heartrate](https://skeletom-ch.itch.io/vts-heartrate) | [Skeletom](https://www.twitter.com/FomTarro) | Application | Un plugin qui connecte des données de fréquence cardiaque en temps réel à VTube Studio, permettant une teinte dynamique du modèle et fournissant des paramètres de suivi personnalisés basés sur le pouls. |
| [vts-chameleon](https://satetsu888.github.io/vts-chameleon/) | [satetsu888](https://www.twitter.com/satetsu888) | Application | Un plugin pour appliquer des teintes de couleur. Vous pouvez jouer en modifiant les tons de couleur des cheveux, de la peau, de l’uniforme, etc. de vos modèles. |
| [ViewLink](https://kawaentertainment.itch.io/viewlink) | [KawaEntertainment](https://twitter.com/kawa_entertain) | Application | Êtes-vous un VTuber qui souhaite streamer des jeux VR mais ne dispose que d’un modèle Live2D ? Avec ViewLink, votre avatar Live2D peut réagir au gameplay VR sans configuration compliquée ni matériel supplémentaire ! |
| [VTS Desktop Audio](https://lualucky.itch.io/vts-desktop-audio-plugin) | [Lua Lucky](https://twitter.com/LuaVLucky) | Application | Un plugin pour utiliser l’audio du bureau comme paramètres d’entrée dans VTS. |
| [pyvts](https://github.com/Genteki/pyvts) | [Genteki](https://github.com/Genteki) | Bibliothèque | Une bibliothèque Python pour interagir avec l’API VTube Studio. |
| [DSYS: Dummy System](https://github.com/chuigda/Project-WG/tree/master/extra/dsys) | [Chuigda](https://github.com/chuigda) | Application | Un plugin simple pour enregistrer/rejouer/semi-piloter avec les paramètres du modèle VTS. |
| [SAMMIVtubeStudioExtension](https://github.com/HueVirtualCreature/SAMMIVtubeStudioExtension) | [hue](https://twitter.com/Hue_SwordDevil) | Plugin | Un plugin pour l’outil d’automatisation de streaming appelé [SAMMI](https://sammi.solutions/) |
| [Streamer.bot](https://streamer.bot) | [Streamer.bot](https://streamer.bot) | Application | Logiciel de streaming multi-plateforme avancé avec une [intégration officielle VTubeStudio](https://docs.streamer.bot/guide/integrations/vtube-studio) |
| [coovts](https://github.com/lgc2333/coovts) | [LgCookie](https://github.com/lgc2333) | Bibliothèque | Une autre bibliothèque pour créer des plugins VTube Studio en Python (en développement précoce). Complète avec hints de type \| design asynchrone \| validation de données basée sur Pydantic |
| [VTS Terminal](https://www.nekomaido.com/plugin/vts-terminal) | [Neko Maido](https://www.nekomaido.com) | Application | Un plugin qui fournit de nombreuses utilités, peut déclencher des raccourcis clavier, ajuster la position du modèle et les effets visuels, et générer un manuel PDF pour votre modèle Live2D. |

# API Événements

Il existe une autre page wiki qui décrit l’**API Événements**, que vous pouvez utiliser pour vous abonner aux événements se produisant dans VTube Studio, tels que le chargement des modèles ou l’exécution des raccourcis clavier. Veuillez consulter la page sur les événements [juste ici](Events/).

# Détails de l’API

Le serveur websocket VTube Studio fonctionne sur `ws://localhost:8001`. C’est la valeur par défaut, mais les utilisateurs peuvent aussi changer le port dans l’application. Les websockets supportent en général les messages `binary` et `text`. VTube Studio répondra toujours avec des messages `text` et il est recommandé d’envoyer aussi des messages `text` à l’API. Vous pouvez aussi envoyer des messages `binary` mais dans ce cas, assurez-vous qu’ils soient encodés en UTF-8.

Si votre plugin ne peut pas se connecter au serveur websocket, dites aux utilisateurs de vérifier si le port est correct ou s’il y a des réglages de pare-feu/antivirus qui pourraient empêcher la connexion. Plus important encore, vous devez demander aux utilisateurs d’« Autoriser l’accès à l’API Plugin » dans VTube Studio. C’est une option sur la page principale de configuration dans VTS.  
Vous devez aussi vous assurer que votre plugin supporte la configuration du port utilisé pour la connexion.


Si vous pouvez vous connecter, la première chose à essayer est de vérifier le statut de votre session.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "MyIDWithLessThan64Characters",
	"messageType": "APIStateRequest"
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"messageType": "APIStateResponse",
	"requestID": "MyIDWithLessThan64Characters",
	"data": {
		"active": true,
		"vTubeStudioVersion": "1.9.0",
		"currentSessionAuthenticated": false
	}
}
```
Chaque requête doit contenir `"apiName" : "VTubeStudioPublicAPI"` et la version de l'API utilisée, qui sera `"1.0"` au moment de la première sortie.
Cette version de l'API restera la même tant que des changements incompatibles ne seront pas apportés au comportement/aux charges utiles. Cela signifie que de nouvelles fonctionnalités peuvent être ajoutées à l'API (y compris de nouveaux champs dans des charges utiles existantes) sans augmenter la version. Assurez-vous que votre application peut gérer cela et ne plante pas si elle rencontre des champs inconnus lors de la désérialisation.

Un exemple de changement incompatible serait de renommer un champ existant ou de le supprimer complètement de la charge utile. S'il y a des changements incompatibles, la version de l'API sera augmentée pour eux afin que les anciennes API puissent toujours être utilisées telles quelles.

Vous pouvez ajouter le champ `"requestID"` à chaque requête. Ceci est optionnel mais recommandé, car cela vous permet d'identifier les réponses à vos requêtes.
Cet ID sera également utilisé pour enregistrer la requête dans les journaux de VTube Studio ainsi que toute erreur. Si quelque chose tourne mal, vous pouvez l'utiliser comme référence pour vérifier toute erreur liée à cette requête dans les journaux.

Vous pouvez utiliser le même ID ou des IDs différents pour chaque requête. Si fournis, les IDs doivent contenir uniquement des caractères ASCII et avoir une longueur d'au moins 1 et au maximum 64 caractères.
Si vous n'ajoutez pas le champ `"requestID"`, VTube Studio ajoutera un UUID généré aléatoirement pour la requête et le renverra avec la réponse.

Le champ `"currentSessionAuthenticated"` vous indiquera si la session actuelle a déjà été authentifiée.

Tous les IDs d'erreur possibles sont listés sur la page [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs).

Une fois connecté, le client peut interroger à tout moment des informations sur l'état actuel de l'application.

## Permissions de l'API

Certaines fonctionnalités offertes par l'API VTube Studio sont verrouillées derrière des **permissions** supplémentaires qui doivent être demandées par le plugin après authentification. Comme les permissions dans iOS et Android, cela permet de s'assurer que les utilisateurs comprennent quand les plugins utilisent des fonctionnalités pouvant être considérées comme risquées ou potentiellement dangereuses, comme le chargement d'images arbitraires en tant qu'éléments.

Lors de la demande d'une permission, une fenêtre contextuelle est affichée à l'utilisateur expliquant ce que fait la permission. L'utilisateur peut alors choisir de l'accorder ou de la refuser. Pour plus d'informations sur la manière de demander des permissions et pourquoi vous en avez besoin, consultez la [page des permissions](Permissions/).

[![Écran de demande de permission de VTube Studio](/Images/vts_api_permissions_1_transparent.png)](Permissions/)


## Découverte du serveur API (UDP)

VTube Studio diffuse également l'état de l'API sur le réseau local via UDP sur le port 47779. Ceci est fait toutes les deux secondes même si l'utilisateur a désactivé l'API.
L'`instanceID` est un ID aléatoire généré pour une instance de VTube Studio au démarrage. Il ne change pas tant que cette instance fonctionne, donc deux instances de VTube Studio auront des IDs différents.

Le `windowTitle` est le texte du titre de la fenêtre. Sous Windows, cela sera différent pour chaque instance de VTS. Lorsqu'il y a plusieurs instances lancées, la première aura pour titre `VTube Studio`, la deuxième aura pour titre `VTube Studio Window 2`, et ainsi de suite. Sur macOS, toutes les instances auront le titre `VTube Studio`


```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1630159656406,
	"messageType": "VTubeStudioAPIStateBroadcast",
	"requestID": "VTubeStudioAPIStateBroadcast",
	"data": {
		"active": false,
		"port": 8001,
		"instanceID": "93aa0d0494304fddb057ae8a295c4e59",
		"windowTitle": "VTube Studio"
	}
}
```

## Authentification

Avant d’utiliser l’API, vous devez vous authentifier une fois. Pour cela, vous devez fournir le nom de votre plugin et le nom du développeur. Ils doivent tous deux comporter entre 3 et 32 caractères.

Cela se fait en demandant un jeton pour votre plugin. Envoyez la requête suivante :

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AuthenticationTokenRequest",
	"data": {
		"pluginName": "My Cool Plugin",
		"pluginDeveloper": "My Name",
		"pluginIcon": "iVBORw0.........KGgoA="
	}
}
```

Si l'utilisateur a activé l'accès à l'API, cela déclenchera une fenêtre contextuelle dans VTS demandant à l'utilisateur s'il souhaite autoriser le plugin `"Mon Super Plugin"` par `"Mon Nom"` à contrôler VTube Studio. `"pluginIcon"` peut être ajouté en option. Il doit s'agir d'une image PNG ou JPG encodée en base64 avec des dimensions exactes de 128x128 pixels. Si vous ajoutez cela, l'icône sera utilisée dans la fenêtre contextuelle de demande d'accès au plugin affichée à l'utilisateur. S'ils cliquent sur "Autoriser", vous recevrez la réponse suivante :

**`RÉPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AuthenticationTokenResponse",
	"data": {
		"authenticationToken": "adcd-123-ef09-some-token-string-abcd"
	}
}
```

Le champ `"authenticationToken"` contient une chaîne ASCII qui servira de jeton pour l'authentification avec l'API. Elle ne dépasse pas 64 caractères.
S'ils refusent l'accès, vous recevrez l'erreur suivante :

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "APIError",
	"data": {
		"errorID": 50,
		"message": "User has denied API access for your plugin."
	}
}
```
Les utilisateurs peuvent révoquer l'accès API à votre plugin à tout moment depuis VTube Studio. S'ils le font, vous obtiendrez également cette erreur lors de l'envoi de toute requête. Vous pouvez essayer de vous réauthentifier dans ce cas.

Vous n'avez besoin d'obtenir le jeton qu'une seule fois. Avec ce jeton, vous pouvez maintenant vous authentifier pour cette session. Lors de la session suivante (par exemple lorsque VTS est redémarré ou que votre plugin doit se reconnecter à VTS pour une raison quelconque), vous pouvez utiliser le même jeton pour vous authentifier à nouveau afin de ne pas avoir à envoyer les requêtes pour obtenir un jeton, l'utilisateur ne sera donc invité à autoriser votre plugin qu'une seule fois.

Pour vous authentifier pour une session, envoyez la requête suivante avec votre jeton :

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AuthenticationRequest",
	"data": {
		"pluginName": "My Cool Plugin",
		"pluginDeveloper": "My Name",
		"authenticationToken": "adcd-123-ef09-some-token-string-abcd"
	}
}
```
`"pluginName"` et `"pluginDeveloper"` doivent correspondre aux valeurs que vous avez utilisées lors de la demande du jeton, sinon la requête d'authentification échouera.

Si le jeton est valide et que l'accès à l'API n'a pas été révoqué par l'utilisateur, vous obtiendrez la réponse suivante :

**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AuthenticationResponse",
	"data": {
		"authenticated": true,
		"reason": "Token valid. The plugin is authenticated for the duration of this session."
	}
}
```

Félicitations, vous êtes authentifié et pouvez utiliser l’API VTube Studio.

Si des champs obligatoires sont manquants, vous recevrez une réponse d’erreur. Si tous les champs sont présents et correctement formatés mais que le jeton est invalide ou a été révoqué par l’utilisateur, `"authenticated"` sera renvoyé comme `false`.

**Note concernant le champ `data` :** Certaines requêtes incluent un champ objet JSON `data` et d’autres non. Pour vous faciliter la tâche, vous pouvez également inclure ce champ dans les requêtes qui n’en ont pas besoin. Il sera simplement ignoré par VTube Studio, même si vous le laissez vide ou le définissez à `null`/`undefined`. VTube Studio renverra ce champ avec chaque requête pour faciliter la désérialisation pour votre plugin. Si la réponse ne contient pas de données, le champ contiendra un objet JSON vide.

**Note concernant le champ `timestamp` :** Toutes les réponses contiennent également un champ `"timestamp"` qui contient le timestamp UNIX en millisecondes auquel votre requête a été traitée. Vous pouvez inclure un champ `"timestamp"` dans vos requêtes, mais il sera ignoré.

## S’abonner et se désabonner des [événements](Events/)

Dans les versions précédentes de l’API, des informations comme le modèle chargé ou les éléments devaient être interrogées de manière répétée par les plugins. Désormais, VTube Studio prend en charge l’abonnement à des **« événements »**, ce qui fera que VTube Studio vous enverra des messages chaque fois que quelque chose de pertinent pour votre plugin se produit. Les événements incluent la notification du chargement des éléments, la perte ou la récupération du suivi, le clic sur le modèle et bien d’autres.

Veuillez consulter la page sur les événements [juste ici](Events/).

## Obtention des statistiques VTS actuelles

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "StatisticsRequest"
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "StatisticsResponse",
	"data": {
		"uptime": 1439384,
		"framerate": 73,
		"vTubeStudioVersion": "1.9.0",
		"allowedPlugins": 7,
		"connectedPlugins": 2,
		"startedWithSteam": true,
		"windowWidth": 1031,
		"windowHeight": 812,
		"windowIsFullscreen": false
	}
}
```
`"uptime"` contient le nombre de millisecondes depuis le démarrage de VTube Studio. `"framerate"` est la valeur actuelle des FPS de rendu. `"allowedPlugins"` est le nombre de plugins que l'utilisateur a actuellement autorisé à utiliser VTube Studio, `"connectedPlugins"` est le nombre de plugins actuellement connectés à l'API de VTube Studio. `"startedWithSteam"` est vrai si l'application a été lancée via Steam, faux sinon (si le fichier `.bat` a été utilisé pour démarrer VTS sans Steam).

La largeur et la hauteur de la fenêtre sont en pixels.

## Obtention de la liste des dossiers VTS

Retourne le nom de divers dossiers de VTube Studio. Ils se trouvent dans le dossier `StreamingAssets` des fichiers du jeu.

**`REQUÊTE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "VTSFolderInfoRequest"
}
```

**`RÉPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "VTSFolderInfoResponse",
	"data": {
		"models": "Live2DModels",
		"backgrounds": "Backgrounds",
		"items": "Items",
		"config": "Config",
		"logs": "Logs",
		"backup": "Backup"
	}
}
```

## Récupérer le modèle actuellement chargé

**`DEMANDE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "CurrentModelRequest"
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "CurrentModelResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDToIdentifyThisModelBy",
		"vtsModelName": "Model.vtube.json",
		"vtsModelIconName": "ModelIconPNGorJPG.png",
		"live2DModelName": "Model.model3.json",
		"modelLoadTime": 3021,
		"timeSinceModelLoaded": 419903,
		"numberOfLive2DParameters": 29,
		"numberOfLive2DArtmeshes": 136,
		"hasPhysicsFile": true,
		"numberOfTextures": 2,
		"textureResolution": 4096,
		"modelPosition": {
			"positionX": -0.1,
			"positionY": 0.4,
			"rotation": 9.33,
			"size": -61.9
		}
	}
}
```
`"modelLoaded"` sera `true` si un modèle est actuellement chargé. Si aucun modèle n’est chargé ou si un modèle est en cours de chargement, cela sera faux. Dans ce cas, toutes les autres valeurs seront vides (ou zéro pour les entiers).

`"modelLoadTime"` est le temps en millisecondes qu’il a fallu pour charger le modèle actuel. `"timeSinceModelLoaded"` contient le temps en millisecondes écoulé depuis que le modèle a été chargé.

`"vtsModelIconName"` contient le nom de l’icône utilisée pour ce modèle dans la barre de sélection des modèles dans VTube Studio. Si le modèle n’a pas d’icône définie, ce sera une chaîne vide. Tous les noms de fichiers retournés dans cette requête sont relatifs au dossier respectif du modèle.

Le tableau `"modelPosition"` contient la position, la rotation et la taille actuelles du modèle. Pour plus d’informations sur la manière d’interpréter ces valeurs, voir `MoveModelRequest`.

## Obtenir une liste des modèles VTS disponibles

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AvailableModelsRequest"
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AvailableModelsResponse",
	"data": {
		"numberOfModels": 2,
		"availableModels": [
			{
				"modelLoaded": false,
				"modelName": "My First Model",
				"modelID": "UniqueIDToIdentifyThisModelBy1",
				"vtsModelName": "Model_1.vtube.json",
				"vtsModelIconName": "ModelIconPNGorJPG_1.png"
			},
			{
				"modelLoaded": true,
				"modelName": "My Second Model",
				"modelID": "UniqueIDToIdentifyThisModelBy2",
				"vtsModelName": "Model_2.vtube.json",
				"vtsModelIconName": "ModelIconPNGorJPG_1.png"
			}
		]
	}
}
```
`"modelLoaded"` est `true` si le modèle respectif est actuellement chargé dans VTube Studio, `false` sinon. 

## Chargement d’un modèle VTS par son ID

**`REQUÊTE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ModelLoadRequest",
	"data": {
		"modelID": "UniqueIDOfModelToLoad"
	}
}
```

**`RÉPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ModelLoadResponse",
	"data": {
		"modelID": "UniqueIDOfModelThatWasJustLoaded"
	}
}
```

Cela peut échouer et renvoyer une erreur si l’application est actuellement dans un état où aucun modèle ne peut être chargé/déchargé. Cela inclut le fait d’avoir des fenêtres de configuration ouvertes ou une opération de chargement de modèle déjà en cours. Il y a aussi un temps de recharge global de 2 secondes pour cette requête.

Si un ID de modèle vide est passé, le modèle actuellement chargé sera déchargé (ne fera rien si aucun modèle n’est chargé).

## Déplacement du modèle VTS actuellement chargé

Si un modèle est chargé, cela vous permet de changer sa position, sa rotation et sa taille. Si aucun modèle n’est chargé, cela renverra une erreur, voir [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)

Les champs requis dans cette requête sont `"timeInSeconds"` et `"valuesAreRelativeToModel"`. `"timeInSeconds"` est le temps en secondes que le déplacement doit prendre et doit être une valeur flottante entre 0 et 2. Si cela est réglé à 0, le modèle apparaîtra instantanément à la position donnée. Une valeur plus élevée fera que le modèle se déplacera, tournera et grandira/rétrécira en douceur vers la position donnée (fondu entrant/sortant). Pendant que le déplacement est en cours, l’utilisateur ne peut pas déplacer manuellement le modèle en le faisant glisser. Cela sera de nouveau possible environ une demi-seconde après que le modèle ait fini de se déplacer vers la destination.

Des `MoveModelRequest` successifs peuvent être envoyés sans attendre la fin de celui en cours. Si un est en cours, il sera interrompu et remplacé par le nouveau. Vous pouvez même prendre un contrôle complet du mouvement en envoyant une requête à chaque image avec 0 comme `"timeInSeconds"`.

La `"size"` est donnée comme un flottant entre -100 (plus petit) et +100 (plus grand). Pour `"positionX"`, `"positionY"` et `"rotation"`, veuillez vous référer à l’image suivante :

#### Le système de coordonnées VTS
![Le système de coordonnées VTS](/Images/coordinate_explanation.png)

Les nombres sur les chats représentent les coordonnées **[X/Y]** que vous pouvez passer en utilisant `"positionX"` et `"positionY"`. Par exemple, envoyer [0/0] positionnera le milieu du modèle au milieu de l’écran. Ce que le « milieu du modèle » est peut être défini librement dans Live2D Cubism et peut varier entre les modèles. Vous pouvez bien sûr aussi envoyer des valeurs beaucoup plus grandes/petites pour déplacer le modèle hors écran. `"positionX"` et `"positionY"` doivent être entre -1000 et 1000.

Les nombres autour du cercle représentent les angles que vous pouvez définir en utilisant `"rotation"`. Les valeurs pour ce paramètre doivent être comprises entre -360 et 360. Notez qu’il y a deux représentations pour chaque angle : positive pour une rotation dans le sens horaire, négative pour une rotation dans le sens antihoraire. Celle que vous utilisez dépend de vous, il n’y a pas de différence. Lorsque vous envoyez une `CurrentModelRequest`, la réponse contiendra aussi la position/rotation/taille du modèle. Dans cette réponse, l’angle sera toujours représenté en notation positive.

Vous n’êtes pas obligé de fournir toutes les valeurs dans la requête. Par exemple, vous pourriez juste fournir des positions ou juste une rotation ou toute autre combinaison. Toutes les valeurs non incluses dans la requête seront ignorées lors du réglage de la position/rotation/taille. Ainsi, vous pourriez par exemple ne changer que la coordonnée X du modèle en laissant tout le reste tel quel.

Si `"valuesAreRelativeToModel"` est réglé sur `false`, les valeurs de votre requête seront prises comme des valeurs absolues et le modèle sera déplacé à cette position. Si `"valuesAreRelativeToModel"` est réglé sur `true`, les valeurs sont considérées comme relatives à la position actuelle du modèle. Supposons que vous le régliez sur `true` et n’incluiez qu’une rotation de `10` dans votre requête. Cela ferait tourner le modèle de 10 degrés dans le sens horaire, depuis la rotation actuelle sans toucher à la position ni à la taille. Cela peut être très utile pour implémenter des effets qui doivent déplacer le modèle sur place, comme le secouer indépendamment de sa position à l’écran.

Si vous souhaitez déplacer le modèle vers une position pixel fixe ou par un certain nombre de pixels, vous devrez calculer vous-même les coordonnées respectives. Vous pouvez le faire en obtenant la largeur et la hauteur de la fenêtre en pixels via la `StatisticsRequest`.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "MoveModelRequest",
	"data": {
		"timeInSeconds": 0.2,
		"valuesAreRelativeToModel": false,
		"positionX": 0.1,
		"positionY": -0.7,
		"rotation": 16.3,
		"size": -22.5
	}
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "MoveModelResponse",
	"data": { }
}
```
## Demande de liste des raccourcis clavier disponibles dans le modèle VTS actuel ou un autre

**`REQUEST`**



```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "HotkeysInCurrentModelRequest",
	"data": {
		"modelID": "Optional_UniqueIDOfModel",
		"live2DItemFileName": "Optional_Live2DItemFileName"
	}
}
```

Le `"modelID"` (et l'objet `"data"` en général ici) est optionnel. S'il n'est pas fourni, les raccourcis clavier pour le modèle actuel sont retournés. Si l'ID du modèle est fourni, les raccourcis clavier du modèle avec l'ID donné sont retournés. Si aucun modèle avec cet ID n'est trouvé, une erreur est retournée (voir [ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs), `ModelIDNotFound`).

Cela peut également retourner les raccourcis clavier de n'importe quel élément Live2D disponible. Pour ce faire, il suffit de passer le nom de fichier de l'élément dans le champ `"live2DItemFileName"`. Vous pouvez obtenir les noms de fichiers (uniques) de tous les éléments Live2D disponibles en utilisant la `ItemListRequest`.

Si à la fois `"modelID"` et `"live2DItemFileName"` sont fournis, seul `"modelID"` est utilisé et l'autre champ sera ignoré.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "HotkeysInCurrentModelResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"availableHotkeys": [
			{
				"name": "My first hotkey",
				"type": "ToggleExpression",
				"description": "Toggles an expression",
				"file": "myExpression_1.exp3.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith1",
				"keyCombination": [],
                		"onScreenButtonID": 8
			},
			{
				"name": "My second hotkey",
				"type": "TriggerAnimation",
				"description": "Triggers an animation",
				"file": "myAnimation.motion3.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith2",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My third hotkey",
				"type": "ChangeVTSModel",
				"description": "Changes the VTS model",
				"file": "someOtherModel.vtube.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith3",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My fourth hotkey",
				"type": "MoveModel",
				"description": "Moves the Live2D model",
				"file": "",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith4",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My fifth hotkey",
				"type": "Unset",
				"description": "No action set for hotkey",
				"file": "",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith5",
				"keyCombination": [],
                		"onScreenButtonID": 5
			}
		]
	}
}
```

Si aucun ID de modèle n’a été spécifié dans la requête et qu’aucun modèle n’est chargé, `"modelLoaded"` sera faux et le tableau `"availableHotkeys"` sera vide. Si un ID a été spécifié, le champ `"modelLoaded"` sera `true` ou `false` selon que le modèle avec l’ID donné est actuellement chargé ou non.

Le champ `"file"` contient le nom de fichier de l’expression/animation/modèle pour les raccourcis de type `TriggerAnimation`, `ChangeIdleAnimation`, `ToggleExpression` et `ChangeVTSModel`. Pour les raccourcis `ChangeBackground`, ce champ contient le nom de l’arrière-plan sans l’extension de fichier. Pour tous les autres types, il contient une chaîne vide.

Le champ `"description"` contient une description de ce que fait le raccourci. Vous pouvez afficher cette chaîne dans l’interface de votre plugin lorsque vous rencontrez un type de raccourci que votre plugin ne connaît pas, par exemple parce que ce type a été ajouté récemment à VTube Studio.

Le tableau `"keyCombination"` contient la combinaison de touches du clavier (ou de la souris) qui déclenchera le raccourci. Voir [RestrictedRawKey.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/RestrictedRawKey.cs) pour toutes les valeurs possibles. Si le tableau est vide, aucune combinaison de touches n’a été définie. **IMPORTANT :** Pour des raisons de sécurité, le tableau `"keyCombination"` sera actuellement **toujours vide**, donc ces données ne seront pas disponibles pour les plugins pour l’instant. Peut être réintégré dans une mise à jour future.

Le champ `"onScreenButtonID"` contient tous les IDs de boutons à l’écran qui déclencheront le raccourci (1 (en haut) à 8 (en bas) ou -1). Si la valeur est `-1`, aucun bouton à l’écran n’a été défini pour ce raccourci.

Toutes les chaînes de type de raccourci se trouvent sur la page [HotkeyActions.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/HotkeyAction.cs).

## Demande d’exécution de raccourcis

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "HotkeyTriggerRequest",
	"data": {
		"hotkeyID": "HotkeyNameOrUniqueIdOfHotkeyToExecute",
		"itemInstanceID": "Optional_ItemInstanceIdOfLive2DItemToTriggerThisHotkeyFor"
	}
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "HotkeyTriggerResponse",
	"data": {
		"hotkeyID": "UniqueIdOfHotkeyThatWasExecuted"
	}
}
```

Cela déclenche un raccourci clavier pour le modèle VTube Studio actuellement chargé, si vous laissez `"itemInstanceID"` vide ou ne le fournissez pas du tout. Si vous fournissez un ID dans ce champ, cela déclenchera le raccourci dans le modèle Live2D Item donné à la place (voir ci-dessous pour plus d'informations).

Vous pouvez déclencher des raccourcis soit par leur ID unique, soit par le nom du raccourci (insensible à la casse). Si plusieurs raccourcis ont le même nom, seul le premier sera exécuté (l'ordre correspond à l'ordre d'apparition dans l'interface utilisateur). Les raccourcis avec un nom vide ne peuvent être déclenchés que par ID.

Cela peut renvoyer une erreur si l'ID ou le nom du raccourci n'a pas été trouvé ou si le raccourci n'a pas pu être exécuté pour une raison quelconque. Les raisons incluent l'absence de modèle actuellement chargé ou le délai de recharge du raccourci non écoulé (un raccourci spécifique ne peut être déclenché qu'une fois toutes les 5 images). Vous pouvez envoyer différents raccourcis en succession rapide, ce qui les mettra en file d'attente. Toutes les 5 images, un raccourci est pris de la file et exécuté. La file peut contenir 32 raccourcis. Lorsque la file est pleine et que vous essayez d'en envoyer plus, une erreur sera renvoyée.

### Déclenchement des raccourcis dans les Live2D Items

Vous pouvez également utiliser cette requête pour déclencher des raccourcis dans les Live2D items. Consultez [cette page](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items) pour plus d'informations sur les Live2D items en général.

Pour ce faire, il suffit de définir `"itemInstanceID"` sur l'ID d'instance de l'item Live2D. Si aucun item Live2D avec cet ID d'instance n'est actuellement chargé, une erreur est renvoyée. Pour obtenir les ID d'instance de tous les items actuellement chargés, vous pouvez utiliser la `ItemListRequest`.

## Demande de la liste des états d'expression actuels

Vous pouvez obtenir l'état actuel (actif ou inactif) d'une expression spécifique ou de toutes les expressions. Si vous incluez `"expressionFile"`, seul l'état de cette expression sera retourné. Si vous ne l'incluez pas ou le laissez vide, l'état de toutes les expressions du modèle actuel sera retourné.

Si vous incluez un nom de fichier mais qu'il est invalide (ne se termine pas par `.exp3.json`) ou introuvable dans le modèle actuel, une erreur est renvoyée (voir "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)").

Définir `"details"` sur true retournera quelques détails supplémentaires dans la réponse (plus précisément, les tableaux `"usedInHotkeys"` et `"parameters"` seront vides si `"details"` est mis à false).

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ExpressionStateRequest",
	"data": {
		"details": true,
		"expressionFile": "myExpression_optional_1.exp3.json",
	}
}
```

Le tableau `expressions` sera vide si aucun modèle n’est chargé. Sinon, il contiendra des informations sur les expressions disponibles pour le modèle actuellement chargé.

Le champ `"file"` est le nom du fichier de l’expression tel qu’il est stocké dans le dossier du modèle. `"name"` est le même, mais sans l’extension `.exp3.json`. `"active"` indique si l’expression est actuellement active ou non.

Si l’expression a été activée à l’aide d’une touche de raccourci, `"deactivateWhenKeyIsLetGo"` et `"autoDeactivateAfterSeconds"` indiqueront si ces options ont été activées pour la touche de raccourci de l’expression. Si `"autoDeactivateAfterSeconds"` est `true`, le temps restant avant que l’expression soit automatiquement désactivée sera retourné dans `"secondsRemaining"` (sinon il sera à 0).

Si `"details"` a été défini à `true` dans la requête, le tableau `"usedInHotkeys"` contiendra la liste de toutes les touches de raccourci dans lesquelles cette expression est utilisée. De plus, le tableau `"parameters"` contiendra le contenu de l’expression, c’est-à-dire les identifiants des paramètres Live2D et les valeurs cibles de tous les paramètres utilisés dans l’expression.

**`RÉPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ExpressionStateResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"expressions": [
			{
				"name": "myExpression_optional_1",
				"file": "myExpression_optional_1 .exp3.json",
				"active": false,
				"deactivateWhenKeyIsLetGo": false,
				"autoDeactivateAfterSeconds": false,
				"secondsRemaining": 0,
				"usedInHotkeys": [
					{
						"name": "Some Hotkey",
						"id": "SomeUniqueIdToIdentifyHotkeyWith1"
					},
					{
						"name": "Some other Hotkey",
						"id": "SomeUniqueIdToIdentifyHotkeyWith2"
					}
				],
				"parameters": [
					{
						"name": "SomeLive2DParamID",
						"value": 0
					}
				]
			}
		]
	}
}
```

## Demande d'activation ou de désactivation des expressions

Il est recommandé d'activer les expressions via des raccourcis clavier, sinon les utilisateurs pourraient se retrouver avec des expressions activées qu'ils ne peuvent pas désactiver faute de raccourcis configurés. Cependant, vous pouvez également activer et désactiver directement les raccourcis si votre plugin l'exige. Vous le faites en passant un nom de fichier d'expression et en précisant si l'expression doit être activée ou désactivée.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ExpressionActivationRequest",
	"data": {
		"expressionFile": "myExpression_1.exp3.json",
		"fadeTime": 0.5,
		"active": true
	}
}
```

Vous recevrez cette réponse vide si la requête a réussi. Si le nom de fichier est invalide (ne se terminant pas par `.exp3.json`) ou introuvable dans le modèle actuel ou aucun modèle n’est chargé, une erreur est renvoyée (voir "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)").
Le paramètre `fadeTime` est limité entre 0 et 2 secondes. Sa valeur par défaut est 0,25. Notez que le temps de fondu ne peut être réglé que lors de l’apparition progressive à cause des restrictions du système d’animation VTS. Lors de la disparition progressive d’une expression, le même temps que pour l’apparition sera toujours utilisé.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ExpressionActivationResponse",
	"data": { }
}
```

## Demande de liste des ArtMeshes dans le modèle actuel

L'API utilise le terme `Nom ArtMesh`, mais cela fait en réalité référence à l'ID ArtMesh qui sera unique par modèle comme imposé par l'éditeur Live2D Cubism. Les `Tags ArtMesh` peuvent être ajoutés en sélectionnant un ArtMesh et en écrivant dans le champ UserData. Si vous souhaitez utiliser des tags, assurez-vous de cocher `Exporter le fichier UserData (userdata3.json)`. Vous devez ensuite inclure le fichier `.userdata3.json` lors de la copie du modèle dans le dossier Live2DModels de VTube Studio.

Les tags ArtMesh renvoyés dans le tableau `"artMeshTags"` ne contiendront pas de doublons.

Si aucun modèle n’est chargé, `"modelLoaded"` sera `false` et les tableaux seront vides.

**Note sur les "tags" :** Des tags peuvent être ajoutés aux ArtMeshes dans le champ "UserData" de l’éditeur Live2D Cubism. Vous pouvez ajouter n’importe quel texte dans ce champ dans l’éditeur. VTube Studio divisera ce texte aux espaces et aux caractères de nouvelle ligne. Cela signifie que si votre texte de tag est "mon tag", il deviendra deux tags dans VTS : "mon" et "tag". Vous pouvez ajouter autant de tags que vous voulez à chaque ArtMesh.

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ArtMeshListRequest"
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ArtMeshListResponse",
	"data": {
		"modelLoaded": true,
		"numberOfArtMeshNames": 5,
		"numberOfArtMeshTags": 2,
		"artMeshNames": ["ArtMesh1", "ArtMesh2", "HairFront1", "HairFront2", "SomeArtMesh"],
		"artMeshTags": ["my_tag", "SomeOtherTag"]
	}
}
```

## Teinter les ArtMeshes avec une couleur

Vous pouvez teinter les ArtMeshes en fournissant une couleur et des critères de correspondance. Tout ArtMesh correspondant à l’un des critères donnés sera teinté avec la couleur indiquée. Pour réinitialiser la couleur d’un ArtMesh, teintez-le en blanc (R=G=B=A=255). Vous ne pouvez pas rendre un ArtMesh blanc avec cette requête, seulement plus foncé.

Ne pas fournir une des valeurs de couleur ou toute valeur en dehors de la plage 0-255 renverra une erreur. Tenter d’envoyer cette requête sans qu’aucun modèle soit chargé renverra également une erreur.

Optionnellement, vous pouvez fournir `mixWithSceneLightingColor` entre 0 et 1. Si fourni, cela déterminera comment la couleur de teinte est mélangée avec la couleur du système d’éclairage de la scène (voir [ici](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay) pour plus d’informations à ce sujet). Si réglé à 1, la couleur fournie écrasera complètement la valeur définie par l’éclairage de la scène. La valeur 0 fera que la couleur de l’éclairage de la scène écrasera votre couleur fournie. Toute valeur intermédiaire mélangera les deux couleurs. Si l’éclairage de la scène est désactivé, cela n’a aucun effet. Si vous ne fournissez pas `mixWithSceneLightingColor`, la valeur par défaut est 1, ce qui signifie que votre couleur écrasera complètement l’éclairage de la scène.

Tous les tableaux inclus dans l’objet `"artMeshMatcher"` sont optionnels. Si vous les incluez, cela sélectionnera les ArtMeshes selon que leurs noms ou tags correspondent exactement à l’une des chaînes données ou les contiennent (lors de l’utilisation des tableaux `"nameContains"`/`"tagContains"`). Le tableau `"artMeshNumber"` vous permet de sélectionner les ArtMeshes selon leur ordre dans le modèle. Si vous souhaitez simplement teinter tout le modèle, n’incluez aucun des tableaux de correspondance et réglez plutôt `"tintAll"` sur true.

Lorsque la session est déconnectée, tous les ArtMeshes qui ont été teintés dans cette session seront réinitialisés à leur valeur par défaut (blanc complètement opaque). Lorsque plusieurs plugins/sessions modifient la couleur d’un ArtMesh, celui-ci prendra la couleur définie par la requête la plus récente.

La correspondance est toujours effectuée **sans distinction de casse**.

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ColorTintRequest",
	"data": {
		"colorTint": {
			"colorR": 255,
			"colorG": 150,
			"colorB": 0,
			"colorA": 255,
			"mixWithSceneLightingColor": 1
		},
		"artMeshMatcher": {
			"tintAll": false,
			"artMeshNumber": [1, 3, 5],
			"nameExact": ["eye_white_left", "eye_white_right"],
			"nameContains": ["mouth"],
			"tagExact": [],
			"tagContains": ["MyTag"]
		}
	}
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ColorTintResponse",
	"data": {
		"matchedArtMeshes": 3
	}
}
```

## Obtenir la couleur de superposition de l'éclairage de la scène

VTube Studio dispose d'une fonctionnalité permettant de superposer le modèle avec la couleur moyenne capturée à partir d'un écran (macOS/Windows) ou d'une fenêtre spécifique (Windows uniquement). Pour plus d'informations, voir [cette page dans la documentation](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay).

Vous pouvez obtenir la configuration utilisateur actuelle et la couleur pour le système de superposition d'éclairage de la scène via l'API.

Au niveau supérieur de la réponse, vous avez le champ `active`, qui indique si la superposition d'éclairage est activée ou non. Si `itemsIncluded` est vrai, tous les éléments sont également affectés par la superposition d'éclairage. Si `isWindowCapture` est `true`, VTube Studio est configuré pour capturer la couleur moyenne d'une fenêtre. Si c'est `false`, la capture est configurée sur un écran.

`baseBrightness` (entre 0 et 100), `colorBoost` (entre 0 et 100) et `smoothing` (entre 0 et 60) sont les trois valeurs que les utilisateurs peuvent sélectionner à l'aide des curseurs sur l'interface utilisateur. Pour une explication, veuillez consulter [la page de documentation sur cette fonctionnalité](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay).

`leftCapturePart`, `middleCapturePart` et `rightCapturePart` décrivent les couleurs moyennes des parties respectives de la fenêtre ou de l'écran capturé. Leur champ `active` indique si la partie de l'écran a été activée par l'utilisateur.

La couleur moyenne calculée à partir de toutes les parties d'écran activées se trouve dans les champs `colorAvg` (R, G et B entre 0 et 255).

La couleur finale qui sera utilisée pour superposer les ArtMeshes se trouve dans les champs `colorOverlay` (R, G et B entre 0 et 459). Notez que cela permet des valeurs supérieures à 255. La couleur finale est calculée comme suit :

`colorAvg` *  (`colorBoost` / 50) + `WHITE_COLOR` * (`baseBrightness` / 100)

Cela peut produire des valeurs allant jusqu'à 2 * 255 pour R, G et B. Les valeurs sont plafonnées à 1,8 * 255 = 459.

Lorsque le système de superposition d'éclairage est désactivé, `active` au niveau supérieur de la charge utile sera `false` et toutes les couleurs seront renvoyées en blanc.

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SceneColorOverlayInfoRequest"
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SceneColorOverlayInfoResponse",
	"data": {
		"active": true,
		"itemsIncluded": true,
		"isWindowCapture": false,
		"baseBrightness": 16,
		"colorBoost": 35,
		"smoothing": 6,
		"colorOverlayR": 206,
		"colorOverlayG": 150,
		"colorOverlayB": 153,
		"colorAvgR": 237,
		"colorAvgG": 157,
		"colorAvgB": 162,
		"leftCapturePart": {
			"active": true,
			"colorR": 243,
			"colorG": 231,
			"colorB": 234
		},
		"middleCapturePart": {
			"active": true,
			"colorR": 230,
			"colorG": 83,
			"colorB": 89
		},
		"rightCapturePart": {
			"active": false,
			"colorR": 235,
			"colorG": 95,
			"colorB": 101
		}
	}
}
```


## Vérification si le visage est actuellement détecté par le traqueur

Renvoie si le visage est actuellement détecté par le traqueur actif (smartphone via réseau/USB ou traqueur webcam).

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "FaceFoundRequest"
}
```

**`RÉPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "FaceFoundResponse",
	"data": {
		"found": true
	}
}
```

## Demande de liste des paramètres de suivi disponibles

Vous pouvez demander une liste des paramètres actuellement disponibles dans VTube Studio.
Cela inclut tous les paramètres réguliers ainsi que tous les paramètres personnalisés créés par les plugins. Les paramètres créés par des plugins seront indiqués comme tels lorsque vous les sélectionnerez dans la liste des paramètres de VTube Studio. Le nom du plugin qui les a créés sera également affiché.

**Important :** Cela peut retourner beaucoup de données. Il n’est pas recommandé d’envoyer cette requête à des fréquences élevées (60+ FPS), car cela pourrait causer des problèmes de performance sur des PC plus lents.

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "InputParameterListRequest"
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "InputParameterListResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"customParameters": [
			{
				"name": "MyCustomParamName1",
				"addedBy": "My Plugin Name",
				"value": 12.4,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "MyCustomParamName2",
				"addedBy": "My Plugin Name",
				"value": 0.833,
				"min": -10,
				"max": 10,
				"defaultValue": 0
			},
			{
				"name": "MyCustomParamName3",
				"addedBy": "My Other Plugin Name",
				"value": 0,
				"min": 0,
				"max": 1,
				"defaultValue": 0
			}
		],
		"defaultParameters": [
			{
				"name": "FaceAngleX",
				"addedBy": "VTube Studio",
				"value": 45.78,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "FacePositionX",
				"addedBy": "VTube Studio",
				"value": 8.33,
				"min": -10,
				"max": 10,
				"defaultValue": 0
			}
		]
	}
}
```
**Remarque :** Le tableau `"defaultParameters"` est incomplet dans cet exemple de charge utile. Il contiendra tous les paramètres de suivi par défaut du visage/souris/etc. proposés par VTube Studio 

## Obtenir la valeur d'un paramètre spécifique, par défaut ou personnalisé

Si le paramètre d'entrée demandé n'existe pas, une erreur sera renvoyée.

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterValueRequest",
	"data": {
		"name": "MyCustomParamName1"
	}
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterValueResponse",
	"data": {
		"name": "MyCustomParamName1",
		"addedBy": "My Plugin Name",
		"value": 12.4,
		"min": -30,
		"max": 30,
		"defaultValue": 0
	}
}
```

## Obtenir la valeur de tous les paramètres Live2D dans le modèle actuel

Cela renverra une erreur si aucun modèle n'est chargé.

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "Live2DParameterListRequest"
}
```

**`RÉPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "Live2DParameterListResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"parameters": [
			{
				"name": "MyLive2DParameterID1",
				"value": 12.4,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "MyLive2DParameterID2",
				"value": 0,
				"min": 0,
				"max": 1,
				"defaultValue": 0
			}
		]
	}
}
```
Si aucun modèle n’est chargé, `"modelLoaded"` sera faux et le tableau de paramètres sera vide. Tous les autres champs seront des chaînes vides.

## Ajout de nouveaux paramètres de suivi (« paramètres personnalisés »)

Vous pouvez également ajouter vos propres nouveaux paramètres de suivi et les utiliser dans vos modèles VTube Studio. Ils sont appelés paramètres « personnalisés ». Après avoir été ajoutés par votre plugin, l’utilisateur peut sélectionner vos paramètres comme entrées pour les correspondances de paramètres Live2D.

Les noms de paramètres doivent être uniques, alphanumériques (pas d’espaces autorisés) et doivent comporter entre 4 et 32 caractères. Les nouveaux paramètres de suivi sont créés comme ceci :

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterCreationRequest",
	"data": {
		"parameterName": "MyNewParamName",
		"explanation": "This is my new parameter.",
		"min": -50,
		"max": 50,
		"defaultValue": 10
	}
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterCreationResponse",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

La requête peut échouer et retourner une erreur si le nom du paramètre est invalide.

Elle échouera également si un paramètre avec le même nom créé par un plugin différent existe déjà. Si vous créez un paramètre plusieurs fois avec le même nom de plugin, la requête réussira. Vous pouvez aussi écraser les valeurs `min`, `max` et `defaultValue` de cette façon.

Les valeurs Min/Max/Par défaut doivent être des nombres à virgule flottante compris entre `-1000000` et `1000000`. Les valeurs min/max ne sont pas vraiment les valeurs minimale et maximale autorisées pour le paramètre. Ce sont les valeurs qui seront utilisées comme valeurs par défaut inférieure et supérieure lorsqu’un nouveau mappage de paramètre est créé avec ce paramètre.

L’explication est une description optionnelle, courte (moins de 256 caractères) indiquant ce que fait le paramètre et comment les utilisateurs doivent l’utiliser dans leurs modèles. Si vous la fournissez dans la requête, elle sera affichée lorsque l’utilisateur consultera les détails de ce paramètre personnalisé.

Il existe une limite globale dans VTS de 300 paramètres personnalisés et une limite de 100 paramètres personnalisés par plugin. Si vous essayez d’en créer plus, une erreur sera renvoyée.

Ces paramètres personnalisés que vous créez sont stockés dans la configuration de VTube Studio dans un fichier appelé `custom_parameters.json` dans le dossier `Config`, qui se trouve dans le dossier `StreamingAssets` de VTube Studio. Si vous révoquez le jeton d’authentification d’un plugin, tous les paramètres personnalisés créés par ce plugin seront également supprimés. Ils resteront définis dans les modèles VTube Studio qui les ont utilisés, mais seront affichés en rouge pour indiquer que le paramètre d’entrée n’existe plus. Les plugins peuvent obtenir un autre jeton et recréer ces paramètres à tout moment et ils continueront de fonctionner.

## Supprimer des paramètres personnalisés

Vous pouvez supprimer des paramètres personnalisés. Les paramètres par défaut ne peuvent pas être supprimés. Vous ne pouvez pas non plus supprimer des paramètres créés par des plugins autres que celui que vous avez utilisé pour authentifier cette session.

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterDeletionRequest",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterDeletionResponse",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

## Saisie de données pour les paramètres par défaut ou personnalisés

Vous pouvez saisir des données pour n'importe quel paramètre par défaut ou personnalisé. Ces paramètres de suivi seront alors utilisés comme entrées pour le modèle VTube Studio chargé et tous les [éléments Live2D](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items) chargés.

La charge utile ressemble à ceci :

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "InjectParameterDataRequest",
	"data": {
		"faceFound": false,
		"mode": "set",
		"parameterValues": [
			{
				"id": "FaceAngleX",
				"value": 12.31
			},
			{
				"id": "MyNewParamName",
				"weight": 0.8,
				"value": 0.7
			}
		]
	}
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "InjectParameterDataResponse",
	"data": { }
}
```

Si un ou plusieurs des paramètres n'existent pas, une charge utile d'erreur sera renvoyée.

Les valeurs doivent être des nombres à virgule flottante compris entre `-1000000` et `1000000`. Les valeurs en dehors de cette plage renverront également une erreur.

Si des valeurs existent pour ces paramètres à partir du suivi webcam/iOS/Android, les valeurs provenant de l'API écraseront celles-ci tant que vous continuez à envoyer des données via l'API.
Vous devez renvoyer les données pour un paramètre que vous souhaitez contrôler avec votre plugin **au moins une fois par seconde**. Sinon, le paramètre sera considéré comme "perdu" et reviendra à la valeur de ce qui le contrôlait auparavant. Si rien d'autre ne le contrôle, il reviendra à sa valeur par défaut.

Vous pouvez également ajouter un paramètre optionnel `"weight"` compris entre 0 et 1. Cela peut être utilisé pour mixer la `"value"` que vous envoyez pour le paramètre avec la valeur qui a été définie pour le paramètre via le suivi facial. Par exemple, vous pourriez contrôler un paramètre à 50 % avec le suivi facial et à 50 % via l'API. Toutefois, un seul plugin API peut écrire sur un paramètre à la fois. Un cas d'utilisation serait de faire apparaître/disparaître le contrôle d'un paramètre de suivi facial afin qu'il ne "saute" pas dès que vous en prenez le contrôle via l'API. Si vous n'incluez pas le paramètre `"weight"` dans votre requête pour un paramètre, il sera considéré comme ayant la valeur 1, ce qui signifie que le paramètre cible sera instantanément réglé à la valeur fournie par votre plugin.

Il convient également de noter que ces paramètres sont traités de manière similaire aux paramètres de suivi normaux. Ainsi, vous pouvez les sélectionner comme entrées normales pour les mappages de paramètres de VTube Studio et appliquer un lissage via les curseurs de l'interface utilisateur. Supprimer des paramètres personnalisés pendant qu'ils sont utilisés par un modèle ne pose également aucun problème et ils peuvent être recréés à tout moment.

Optionnellement, vous pouvez passer `"faceFound": true`, ce qui indiquera à VTube Studio de considérer que le visage de l'utilisateur est détecté. Ainsi, vous pouvez contrôler quand l'animation "suivi perdu" est jouée.

### Contrôler un paramètre avec plusieurs plugins

Généralement, si un autre plugin contrôle déjà un paramètre (par défaut ou personnalisé), une erreur sera renvoyée. Cela se produit car un seul plugin peut "définir" (écraser) un paramètre donné à la fois, ce qui est le mode par défaut pour cette requête. C'est le mode utilisé lorsque vous ne fournissez pas de valeur dans le champ `"mode"` ou que vous la réglez sur `"set"`.

Alternativement, vous pouvez définir le champ `"mode"` sur `"add"`. Cela ajoutera alors les valeurs que vous envoyez à celles actuelles du paramètre. Les valeurs `"weight"` ne sont pas utilisées dans ce cas. Un nombre quelconque de plugins peut utiliser le mode `"add"` pour un paramètre donné en même temps. Cela peut être utile pour des plugins de type **bonk/lancer** et autres cas d'utilisation.

## Obtention des réglages physiques du modèle VTS actuellement chargé

Les utilisateurs peuvent personnaliser les réglages physiques dans VTube Studio. Ils peuvent modifier les réglages suivants :

- **Force physique de base (par modèle) :** Entier entre 0 (désactivé) et 100 (max). Par défaut 50, ce qui signifie que la physique se comporte comme dans Live2D Cubism Editor.
- **Force du vent de base (par modèle) :** Entier entre 0 (désactivé) et 100 (max). Par défaut 0.
- **Multiplicateur de physique (par groupe de physique) :** Pour chaque groupe de physique (configurable dans Live2D Cubism), les utilisateurs peuvent définir un multiplicateur. La valeur physique de base sera multipliée par cette valeur lors du traitement du groupe physique concerné. Nombre à virgule flottante entre 0 et 2, par défaut 1 ce qui signifie que la valeur de base reste inchangée.
- **Multiplicateur de vent (par groupe de physique) :** Pour chaque groupe de physique (configurable dans Live2D Cubism), les utilisateurs peuvent définir un multiplicateur. La valeur de vent de base sera multipliée par cette valeur lors du traitement du groupe physique concerné. Nombre à virgule flottante entre 0 et 2, par défaut 1 ce qui signifie que la valeur de base reste inchangée.

Ces valeurs définies par l'utilisateur peuvent être lues via l'API et également temporairement écrasées (voir `SetCurrentModelPhysicsRequest`).

Pour lire les valeurs du modèle actuellement chargé, utilisez cette requête :

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "GetCurrentModelPhysicsRequest"
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "GetCurrentModelPhysicsResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"modelHasPhysics": true,
		"physicsSwitchedOn": true,
		"usingLegacyPhysics": false,
		"physicsFPSSetting": -1,
		"baseStrength": 50,
		"baseWind": 17,
		"apiPhysicsOverrideActive": false,
		"apiPhysicsOverridePluginName": "",
		"physicsGroups": [
			{
				"groupID": "PhysicsSetting1",
				"groupName": "Hair Front Physics",
				"strengthMultiplier": 1.5,
				"windMultiplier": 0.3
			},
			{
				"groupID": "PhysicsSetting2",
				"groupName": "Clothes Physics",
				"strengthMultiplier": 1,
				"windMultiplier": 2
			}
		]
	}
}
```

Si aucun modèle n'est chargé, `modelLoaded` sera `false`. Toutes les autres valeurs n'ont aucune signification dans ce cas et le tableau `physicsGroups` sera vide.

Si un modèle est chargé, le champ `modelHasPhysics` vous indiquera si le modèle dispose ou non d'une configuration physique valide. Certains modèles n'ont pas de physique configurée ou ont un fichier physique corrompu, ce qui empêchera le système physique de démarrer correctement. `physicsSwitchedOn` sera vrai si le bouton bascule `Use Physics` a été activé pour ce modèle par l'utilisateur dans VTube Studio. `usingLegacyPhysics` correspond à l'état du bouton bascule `Legacy Physics`.

`physicsFPSSetting` contient le réglage des FPS physiques pour ce modèle et peut être 30, 60, 120 ou -1, ce qui indique que l'utilisateur a sélectionné `Use same FPS as app`.

Les champs `apiPhysicsOverrideActive` et `apiPhysicsOverridePluginName` indiquent si un plugin est en train de remplacer certains réglages physiques. Si son champ actif est vrai, le champ nom contiendra le nom du plugin. Un seul plugin peut contrôler le système physique à la fois. Cela sera également expliqué dans la requête `SetCurrentModelPhysicsRequest`.

Si vous utilisez la requête `SetCurrentModelPhysicsRequest` pour modifier les valeurs de base ou les multiplicateurs de physique ou de vent, ces changements ne seront **PAS** reflétés dans cette requête Get. Vous devez vous souvenir de vos propres modifications physiques.

Note concernant le tableau `physicsGroup` : Chaque groupe a un ID mais tous les groupes n'ont pas forcément un nom. Dans ce cas, le champ `groupName` respectif sera une chaîne vide.

## Remplacement des réglages physiques du modèle VTS actuellement chargé

Vous pouvez remplacer les réglages physiques du modèle actuellement chargé en utilisant cette requête. Une fois qu’un plugin a pris le contrôle du système physique via cette API, aucun autre plugin ne peut utiliser cette API tant que le premier plugin n’a pas renoncé au contrôle. Tenter de le faire renverra l’erreur correspondante, voir "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)" (`SetCurrentModelPhysicsRequestPhysicsControlledByOtherPlugin`). Cela renverra également une erreur si aucun modèle n’est chargé, si un des IDs de groupe physique fournis n’existe pas dans le modèle actuel ou si vous avez oublié d’ajouter une valeur à vos remplacements.

Si l'utilisateur a désactivé la physique pour le modèle actuellement chargé, vous ne pouvez pas activer la physique via cette API. Vous ne pouvez utiliser cette API que pour remplacer les valeurs de base et les multiplicateurs de physique/vent.

Comme expliqué dans la section `GetCurrentModelPhysicsRequest` ci-dessus, les valeurs des multiplicateurs de physique/vent doivent être comprises entre 0 et 2 tandis que les valeurs des valeurs de base de physique/vent doivent être des entiers entre 0 et 100 (car c’est également ainsi qu’elles sont affichées à l’utilisateur dans l’application). Les valeurs en dehors de cette plage seront automatiquement limitées.

Si vous souhaitez définir des multiplicateurs pour la force ou le vent pour un groupe physique spécifique, utilisez les tableaux `strengthOverrides` et `windOverrides` avec l’ID de groupe respectif et `setBaseValue` à false. Si vous définissez `setBaseValue` à true, la valeur fournie sera définie comme valeur de base pour la force physique ou le vent au lieu d’un groupe spécifique. Vous pouvez laisser l’ID de groupe (`id`) vide dans ce cas.

En général, les valeurs définies via cette API sont utilisées pour remplacer les valeurs définies par l’utilisateur dans l’application. Elles ne sont pas réellement affichées à l’utilisateur dans l’interface et ne sont pas sauvegardées. Les valeurs de remplacement définies via cette API sont automatiquement désactivées lorsque leur minuterie expire (la valeur que vous définissez avec `overrideSeconds`). Si vous souhaitez continuer à remplacer les valeurs, vous devez envoyer cette requête de manière répétée.

Lorsque toutes les minuteries expirent, l’API ne considérera plus votre plugin comme contrôlant le système physique, ce qui permettra à un autre plugin de prendre le contrôle du système physique.

Les valeurs de minuterie de remplacement doivent être comprises entre 0,5 et 5 secondes. Les valeurs en dehors de cette plage seront automatiquement limitées.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SetCurrentModelPhysicsRequest",
	"data": {
		"strengthOverrides": [
			{
				"id": "PhysicsSetting1",
				"value": 1.5,
				"setBaseValue": false,
				"overrideSeconds": 2
			}
		],
		"windOverrides": [
			{
				"id": "",
				"value": 85,
				"setBaseValue": true,
				"overrideSeconds": 5
			}
		]
	}
}
```
**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "SetCurrentModelPhysicsResponse",
	"data": { }
}
```

## Obtenir et définir les paramètres NDI

Vous pouvez demander les paramètres NDI actuels et les modifier via l'API. Cela vous permet d'activer/désactiver NDI, de définir une résolution fixe personnalisée et plus encore.

Des informations sur NDI et son utilisation dans VTube Studio sont disponibles sur cette page : https://github.com/DenchiSoft/VTubeStudio/wiki/Streaming-to-Mac-PC

Si vous définissez `"setNewConfig"` sur `false`, cela renvoie uniquement la configuration actuelle. Tous les autres champs sont ignorés dans ce cas. S'il est défini sur `true`, la configuration donnée sera appliquée si elle est valide.

`"ndiActive"` active ou désactive NDI. Si NDI est activé, `"useNDI5"` utilise NDI 5 au lieu de NDI 4 (je recommande d'utiliser NDI 5).

Définir `"useCustomResolution"` sur `true` signifie que le flux NDI n'aura plus la même résolution que la fenêtre VTube Studio mais utilisera la résolution personnalisée définie via l'interface utilisateur. Cette résolution peut également être modifiée via l'API en utilisant les champs `"customWidthNDI"` et `"customHeightNDI"`. Les deux doivent être compris entre 256 et 8192. La largeur doit être un multiple de 16 et la hauteur un multiple de 8. Les définir tous les deux à `-1` dans la requête évitera de les modifier et ne changera que les champs booléens. Ainsi, vous pouvez par exemple activer/désactiver NDI sans changer la résolution.

Si la résolution NDI ne correspond pas à la résolution de la fenêtre, VTube Studio coupera et redimensionnera automatiquement le flux vidéo. VTube Studio veillera toujours à ce que le rapport d'aspect soit correct, même si cela signifie couper des parties en haut/bas ou à gauche/droite.

**Important :** Cette requête possède une période de refroidissement de 3 secondes. La déclencher trop rapidement retournera une erreur de type `NDIConfigCooldownNotOver` (voir "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)").

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "NDIConfigRequest",
	"data": {
		"setNewConfig": true,
		"ndiActive": true,
		"useNDI5": true,
		"useCustomResolution": true,
		"customWidthNDI": 1024,
		"customHeightNDI": 512
	}
}
```
La réponse contiendra uniquement les paramètres actuels (les nouveaux si vous avez demandé la configuration d’une nouvelle configuration). Le champ `"setNewConfig"` n’a aucune signification dans la réponse.

**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "NDIConfigResponse",
	"data": {
		"setNewConfig": true,
		"ndiActive": true,
		"useNDI5": true,
		"useCustomResolution": true,
		"customWidthNDI": 1024,
		"customHeightNDI": 512
	}
}
```

## Demande de liste des objets disponibles ou des objets dans la scène

Cette demande vous permet de demander une liste des objets actuellement présents dans la scène. Elle vous permet également de demander une liste des fichiers d'objets disponibles à charger sur le PC de l'utilisateur, y compris les objets Live2D, les dossiers d'animation, ...

Si vous souhaitez savoir quels emplacements de commande sont disponibles pour charger des objets en ce moment, réglez `"includeAvailableSpots"` sur `true`. Sinon, le tableau `"availableSpots"` dans la réponse sera vide.

Si vous souhaitez savoir quels objets sont actuellement chargés dans la scène, réglez `"includeItemInstancesInScene"` sur `true`. Sinon, le tableau `"itemInstancesInScene"` dans la réponse sera vide.

Si vous souhaitez savoir quels fichiers d'objets sont disponibles pour être chargés, réglez `"includeAvailableItemFiles"` sur `true`. Sinon, le tableau `"availableItemFiles"` dans la réponse sera vide. **IMPORTANT :** Ceci lit la liste complète des fichiers d'objets depuis le PC de l'utilisateur. Cela peut ralentir l'application un court instant, donc n'utilisez pas cette demande avec `"includeAvailableItemFiles"` réglé sur `true` fréquemment. Utilisez-la uniquement si vous avez vraiment besoin de rafraîchir la liste des fichiers d'objets disponibles. Mettez-la sur `false` dans tout autre cas.

#### Filtrage pour des objets spécifiques

Si vous souhaitez que les listes d'objets ne contiennent que des objets avec un certain ID d'instance ou un certain nom de fichier, vous pouvez les fournir respectivement dans les champs `"onlyItemsWithInstanceID"` et `"onlyItemsWithFileName"`.

Il n'y aura jamais plus d'un objet avec un certain ID d'instance dans la scène, mais il pourrait y avoir plusieurs objets avec le même nom de fichier car vous pouvez charger plusieurs instances d'objets basées sur le même fichier d'objet.

Veuillez également noter que **les noms de fichiers des objets sont uniques**, ce qui signifie qu'il ne peut pas y avoir deux fichiers d'objets avec le même nom de fichier. Ils sont également **sensibles à la casse**, donc si vous souhaitez faire référence à un fichier spécifique, assurez-vous de ne pas modifier la capitalisation.

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemListRequest",
	"data": {
		"includeAvailableSpots": true,
		"includeItemInstancesInScene": true,
		"includeAvailableItemFiles": false,
		"onlyItemsWithFileName": "OPTIONAL_my_item_filename.png",
		"onlyItemsWithInstanceID": "OPTIONAL_InstanceIdOfItemInScene"
	}
}
```

Les champs de la réponse devraient être en grande partie explicites.

Le nom de fichier est le nom du fichier de l'objet. C'est le nom que vous pouvez utiliser pour charger une instance de l'objet dans la scène. Pour les objets JPG/PNG/GIF, c'est le nom complet du fichier (sans le chemin) incluant l'extension du fichier (par exemple "mon_objet.jpg"). Pour les dossiers d'animation, c'est le nom du dossier. Pour les objets Live2D, c'est aussi le nom du dossier.

Le type d'objet peut être trouvé dans le champ `"type"`. Les valeurs possibles sont `PNG`, `JPG`, `GIF`, `AnimationFolder` ou `Live2D`. Une autre valeur possible est `Unknown`. Cela n'arriverait que si un autre type d'objet est ajouté à VTube Studio avant la mise à jour de l'API, donc cela ne devrait jamais arriver.

`"canLoadItemsRightNow"` peut être `false` si l'utilisateur a certains menus ou dialogues ouverts dans VTube Studio. Cela empêche généralement des actions telles que le chargement d'objets, l'utilisation de raccourcis clavier, et plus encore.

`"framerate"` et `"frameCount"` sont disponibles uniquement pour les objets animés (GIFs et dossiers de trames d'animation).

Si `"pinnedToModel"` est vrai, `"pinnedModelID"` contiendra l'ID du modèle auquel l'objet est attaché (qui sera le modèle actuellement chargé) et `"pinnedArtMeshID"` contiendra l'ID du ArtMesh auquel l'objet est attaché.

Si vous définissez `"includeAvailableItemFiles"` à `true`, `"availableItemFiles"` contiendra une liste de tous les fichiers d'objets dans le dossier `Items` de l'utilisateur. Vous pouvez utiliser les noms de fichiers retournés ici pour charger les objets dans la scène en utilisant `ItemLoadRequest`.

**`RESPONSE`**
```json
{
    "apiName": "VTubeStudioPublicAPI",
    "apiVersion": "1.0",
    "timestamp": 1625405710728,
    "messageType": "ItemListResponse",
    "requestID": "SomeID",
    "data": {
        "itemsInSceneCount": 2,
        "totalItemsAllowedCount": 60,
        "canLoadItemsRightNow": true,
        "availableSpots":
	[
            -30,-29,-28,-27,-26,-25,-24,-23,-22,-21,-20,-19,-18,-17,-16,-15,-14,
            -13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1,3,4,5,6,7,8,9,10,11,12,13,
            14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30
        ],
        "itemInstancesInScene": [
            {
                "fileName": "Ribbon (@denchisoft)",
                "instanceID": "18de53dc47154b00afdd382a6ebd2194",
                "order": 1,
                "type": "Live2D",
                "censored": false,
                "flipped": false,
                "locked": false,
                "smoothing": 0.0,
                "framerate": 0.0,
                "frameCount": -1,
                "currentFrame": -1,
                "pinnedToModel": true,
                "pinnedModelID": "47c71722c5304a039b0570b60a189875",
                "pinnedArtMeshID": "D_FACE_00",
                "groupName": "",
                "sceneName": "",
                "fromWorkshop": false
            },
            {
                "fileName": "akari_fly (@walfieee)",
                "instanceID": "716cddf2e12a438ab5da05bbbf8b341c",
                "order": 2,
                "type": "AnimationFolder",
                "censored": false,
                "flipped": false,
                "locked": false,
                "smoothing": 0.0,
                "framerate": 15.0,
                "frameCount": 7,
                "currentFrame": 0,
                "pinnedToModel": false,
                "pinnedModelID": "",
                "pinnedArtMeshID": "",
                "groupName": "",
                "sceneName": "",
                "fromWorkshop": false
            }
        ],
        "availableItemFiles": [
            {
                "fileName": "Ribbon (@denchisoft)",
                "type": "Live2D",
                "loadedCount": 1
            },
            {
                "fileName": "ANIM_headpat",
                "type": "AnimationFolder",
                "loadedCount": 0
            },
            {
                "fileName": "workshop_2801215328_ANIM_loading gif",
                "type": "AnimationFolder",
                "loadedCount": 0
            },
            {
                "fileName": "akari_fly (@walfieee)",
                "type": "AnimationFolder",
                "loadedCount": 1
            },
            {
                "fileName": "b_woozy (@denchisoft).png",
                "type": "PNG",
                "loadedCount": 0
            }
        ]
    }
}
```
## Chargement d’un élément dans la scène

Avec cette requête, vous pouvez charger des éléments dans la scène. Les éléments sont chargés depuis le dossier "Items" sur le PC de l’utilisateur.

Pour obtenir la liste des fichiers d’éléments disponibles, utilisez la `ItemListRequest`. Vous pouvez utiliser ces noms dans le champ `"fileName"`.

Les éléments peuvent être positionnés/redimensionnés/tournés en utilisant les champs `"positionX/Y"`, `"size"` et `"rotation"`. Veuillez vous référer à l’image montrant le [système de coordonnées de VTube Studio](#le-système-de-coordonnées-de-vts) pour plus d’informations sur la façon d’utiliser ces valeurs. Concernant la taille, elle doit être comprise entre `0` et `1`, avec `0.32` étant à peu près la taille « par défaut » que les éléments auront lorsque l’utilisateur les charge manuellement.

Vous devez vous assurer que votre plugin nettoie ses éléments. Vous ne devez absolument jamais laisser d’éléments hors de la scène visible où l’utilisateur ne peut plus y accéder sans utiliser le bouton **"Supprimer tous les éléments dans la scène"**. Pour vous faciliter cette tâche, vous pouvez définir `"unloadWhenPluginDisconnects"` sur true.

Vous pouvez utiliser le champ `"fadeTime"` pour spécifier un temps de fondu entrant/sortant entre 0 et 2 secondes pour l’élément. Si vous le réglez à 0, l’élément apparaîtra instantanément.

Vous pouvez spécifier l’ordre de tri auquel l’élément doit être chargé dans la scène via le champ `"order"`. Si cet ordre est déjà pris, l’élément sera automatiquement chargé à l’ordre supérieur disponible et si tous les ordres supérieurs sont complets, il vérifiera les ordres inférieurs. Si vous souhaitez que le chargement de l’élément échoue si l’ordre demandé est pris, utilisez `failIfOrderTaken` à `true`. Dans ce cas, une erreur de type `ItemOrderAlreadyTaken` est retournée (voir [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)).

Il y a également des limites pour certaines valeurs. Plus précisément, la taille doit être comprise entre `0` et `1`, les positions doivent être comprises entre `-1000` et `1000` (bien que `-1`/`1` correspondent aux bords de l’écran), le temps de fondu doit être compris entre `0` et `2` secondes et la lissage doit être entre `0` et `1`. Si vous dépassez ces limites, une erreur de type `ItemLoadValuesInvalid` est renvoyée.

### Éléments de données personnalisées

Les plugins peuvent également utiliser cette requête pour charger des données PNG/JPG/GIF arbitraires en tant qu’éléments en les passant via le champ `customDataBase64` (doit être un fichier JPG, PNG ou GIF encodé en base64). Laissez-le vide/NULL si vous ne l’utilisez pas.

Si vous souhaitez faire cela, vous avez besoin de la permission `LoadCustomImagesAsItems`. Pour plus d’informations sur la façon de demander des permissions, consultez la [page des permissions](Permissions/). Si vous ne disposez pas de cette permission, une erreur sera retournée si vous essayez de charger une image de données personnalisées (`RequestRequiresPermission`, voir [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)).

Pour demander le chargement de données arbitraires en tant qu’élément, `customDataBase64` doit contenir des données valides d’un fichier PNG, JPG ou GIF. Les éléments Live2D de données personnalisées ne sont pas actuellement pris en charge. Les dimensions doivent être comprises (incluses) entre 64 et 2048 pixels et les données doivent être inférieures à 5 Mo (les données binaires avant encodage en base64). Pour les données GIF, le GIF doit contenir 1024 images ou moins mais au moins 1 image et toutes les images doivent avoir la même taille.

Lors de la fourniture de données personnalisées, vous devez aussi fournir un nom de fichier dans le champ `fileName`. Le `fileName` doit être alphanumérique (mais peut contenir des tirets) et doit se terminer par `.jpg`, `.png` ou `.gif`. Il doit contenir entre 8 et 32 caractères (inclus).

Lors du chargement de données personnalisées, vous avez deux options :
* Charger simplement l’élément de données personnalisées instantanément.
* Afficher une petite fenêtre contextuelle à l’utilisateur (incluant la vignette de l’élément) et lui demander s’il souhaite charger l’élément.

Choisissez l’option appropriée selon votre cas d’usage. Il est de votre responsabilité de vous assurer que votre plugin ne charge pas d’images pouvant causer des problèmes à l’utilisateur.

Si vous souhaitez simplement charger l’élément immédiatement, réglez `customDataAskUserFirst` sur `false`.

Si vous souhaitez afficher d’abord une fenêtre contextuelle à l’utilisateur, réglez `customDataAskUserFirst` sur `true`. Dans ce cas, la fenêtre suivante sera affichée à l’utilisateur :

![Fenêtre de chargement d’image personnalisée](/Images/vts_load_custom_image_1.png)

6 fenêtres contextuelles de ce type peuvent être affichées simultanément (les fenêtres sont empilées verticalement). Lorsque 6 fenêtres contextuelles sont déjà affichées à l’utilisateur, les requêtes suivantes retourneront une erreur.

Lors de l’affichage du popup, la réponse à cette requête ne sera renvoyée qu’une fois que l’utilisateur aura pris une décision. Si l’utilisateur décide de refuser le chargement de l’élément de données personnalisé, une erreur sera renvoyée (`ItemCustomDataLoadRequestRejectedByUser`). Lorsque l’utilisateur décide de charger l’élément, celui-ci sera chargé et une réponse normale sera renvoyée. Cela l’ajoutera également à la liste blanche pour votre plugin afin que les chargements ultérieurs du même élément (tel que déterminé par son empreinte SHA256) ne déclenchent pas le popup. Si vous souhaitez forcer l’affichage du popup à chaque fois, vous pouvez définir `customDataSkipAskingUserIfWhitelisted` sur false.

Vous pouvez définir un délai d’attente pour le popup en utilisant le champ `customDataAskTimer`. Si vous le réglez à 0 (ou moins), le popup sera affiché indéfiniment (jusqu’à ce que l’utilisateur clique sur OK ou annuler). Si vous le réglez à un autre nombre positif, le popup sera affiché pendant ce nombre de secondes, avec un compte à rebours visible pour l’utilisateur. Si l’utilisateur ne prend pas de décision avant la fin du compte à rebours, la requête de chargement de l’élément est considérée comme rejetée par l’utilisateur.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemLoadRequest",
	"data": {
		"fileName": "some_item_name.jpg",
		"positionX": 0,
		"positionY": 0.5,
		"size": 0.33,
		"rotation": 90,
		"fadeTime": 0.5,
		"order": 4,
		"failIfOrderTaken": false,
		"smoothing": 0,
		"censored": false,
		"flipped": false,
		"locked": false,
		"unloadWhenPluginDisconnects": true,
		"customDataBase64": "",
		"customDataAskUserFirst": true,
		"customDataSkipAskingUserIfWhitelisted": true,
		"customDataAskTimer": -1,
	}
}
```
La réponse contient l'ID d'instance de l'élément nouvellement chargé dans le champ `instanceID`. Elle contient également le nom du fichier.

Si vous avez chargé un élément de données personnalisé, le nom du fichier sera généré par VTube Studio, il sera donc différent du nom de fichier que vous avez passé. Vous pouvez utiliser ce nom de fichier pour demander à nouveau le chargement de cet élément sans passer de données personnalisées. Cependant, lorsque VTube Studio est redémarré, tous les fichiers temporaires sont supprimés, ce qui inclut les éléments de données personnalisés.

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemLoadResponse",
	"data": {
		"instanceID": "SomeUniqueItemInstanceId",
		"fileName": "some_item_name.jpg"
	}
}
```

## Suppression d’un élément de la scène

Vous pouvez utiliser cette requête pour décharger un élément actuellement chargé dans la scène.

Définir `"unloadAllInScene"` à `true` décharge tous les éléments. Tous les autres champs sont ignorés dans ce cas.

Définir `"unloadAllLoadedByThisPlugin"` à `true` décharge tous les éléments chargés par ce plugin.

Si vous souhaitez empêcher cette requête de décharger des éléments chargés par l’utilisateur ou d’autres plugins, définissez `"allowUnloadingItemsLoadedByUserOrOtherPlugins"` à `false`.

Vous pouvez également demander des instances d’éléments spécifiques ou des instances d’éléments chargées à partir de certains noms de fichiers en utilisant les tableaux optionnels `"instanceIDs"` et `"fileNames"`. Même si ces éléments ne sont pas trouvés dans la scène, la requête ne renverra pas d’erreur. Elle renverra simplement une réponse avec un tableau vide.

Cela peut renvoyer une erreur de type `CannotCurrentlyUnloadItem` si l’utilisateur a actuellement des menus ouverts qui empêchent VTS de charger/décharger des éléments.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemUnloadRequest",
    	"data": {
		"unloadAllInScene": false,
		"unloadAllLoadedByThisPlugin": false,
		"allowUnloadingItemsLoadedByUserOrOtherPlugins": true,
		"instanceIDs":
		[
			"SomeInstanceIdOfItemToUnload", "SomeOtherInstanceIdOfItemToUnload"
		],
		"fileNames":
		[
			"UnloadAllItemInstancesWithThisFileName", "SomeOtherFileName"
		]
    	}
}
```
La réponse contient les ID d'instance et les noms de fichiers des éléments déchargés.

**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemUnloadResponse",
    	"data": {
		"unloadedItems":
		[
		    {
			"instanceID": "SomeInstanceId",
			"fileName": "SomeFileName"
		    },
		    {
			"instanceID": "SomeOtherInstanceId",
			"fileName": "SomeFileName"
		    }
		]
    	}
}
```

## Contrôle des éléments et des animations d’éléments

Vous pouvez contrôler certains aspects des éléments dans la scène. Cette requête vous permet de rendre les éléments plus sombres (superposition noire), de modifier l’opacité et de contrôler l’animation des éléments animés. Cette requête ne fonctionne pas avec les éléments Live2D et renverra une erreur de type `ItemAnimationControlUnsupportedItemType` si vous essayez (voir [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)). Cela peut être utile pour des plugins de type « PNG réactif » et plus encore.

Pour les éléments animés, vous pouvez définir la fréquence d’images (en images par seconde, sera automatiquement limitée entre `0.1` et `120`). Vous pouvez également faire sauter manuellement l’animation à une certaine image en utilisant le champ `"frame"`. Une erreur sera renvoyée si cet index d’image est invalide. Pour un élément animé avec (par exemple) 20 images, les indices d’image valides vont de 0 (première image) à 19 (dernière image). Le nombre d’images pour les éléments animés peut être demandé via `ItemListRequest`. Tenter cela pour des éléments JPG/PNG normaux renverra une erreur de type `ItemAnimationControlSimpleImageDoesNotSupportAnim`.

Si vous ne souhaitez pas modifier la fréquence d’images, l’image actuelle, la luminosité ou l’opacité, vous pouvez passer `-1` pour ces champs (ce qui est également leur valeur par défaut si vous omettez les champs dans la charge utile).

Vous pouvez démarrer/arrêter l’animation en utilisant le champ `"animationPlayState"` (`true` = jouer l’animation, `false` = arrêter l’animation). Ce champ est utilisé uniquement si vous définissez `"setAnimationPlayState"` à `true`, sinon l’état de lecture de l’animation ne sera pas modifié.

#### Utilisation des images d’arrêt automatique

Vous pouvez définir une liste d’indices d’images sur lesquels l’animation s’arrêtera automatiquement en utilisant le tableau `"autoStopFrames"`. Ce tableau est utilisé uniquement si vous définissez `"setAutoStopFrames"` à true, sinon les images d’arrêt automatique ne seront pas modifiées. Si vous souhaitez supprimer les images d’arrêt automatique, définissez `"setAutoStopFrames"` à true et mettez un tableau vide dans `"autoStopFrames"`. Vous pouvez avoir un maximum de 1024 images d’arrêt automatique.

Une fois que l’animation atteint l’une de ces images, elle s’arrêtera et ne pourra être relancée que via l’API en utilisant cette requête pour définir l’état de lecture de l’animation à `true` (voir ci-dessus).

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemAnimationControlRequest",
	"data": {
		"itemInstanceID": "ItemInstanceId",
		"framerate": 12,
		"frame": 3,
		"brightness": 1,
		"opacity": 1,
		"setAutoStopFrames": true,
		"autoStopFrames": [0, 7, 26],
		"setAnimationPlayState": true,
		"animationPlayState": true
	}
}
```
La réponse contient l'indice de la trame actuelle et indique si l'animation est en cours de lecture (uniquement pour les éléments animés, pour les autres types d'éléments ces champs doivent être ignorés).

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemAnimationControlResponse",
	"data": {
		"frame": 3,
		"animationPlaying": true
	}
}
```

## Déplacement des éléments dans la scène

Vous pouvez déplacer des éléments dans la scène. Pour ce faire, remplissez le tableau `"itemsToMove"` avec tous les éléments que vous souhaitez déplacer. Le tableau de réponse (`"movedItems"`) contiendra une entrée pour chaque élément demandé, indiquant si la demande de déplacement a réussi ou non pour celui-ci (voir le champ `"success"` respectif). Si cela n’a pas réussi, le champ `"errorID"` contiendra le code d’erreur, qui vous indiquera ce qui s’est mal passé (voir [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)). S’il a réussi, `"success"` sera `true` et `"errorID"` sera `-1`.

Le tableau `"itemsToMove"` peut contenir jusqu’à 64 entrées. Toutes les entrées au-delà seront ignorées. Si le tableau contient des entrées avec des identifiants d’instance d’élément en double, la dernière entrée du tableau pour cet ID sera utilisée.

Si vous souhaitez définir la position instantanément (par exemple lorsque vous voulez définir une nouvelle position à chaque image), réglez `"timeInSeconds"` à `0`. Sinon, vous pouvez utiliser ce champ pour définir la durée de la transition de déplacement (limité entre 0 et 30 secondes).

Si vous souhaitez définir l’état de retournement de l’élément, réglez `"setFlip"` à true. L’état de retournement peut alors être défini avec le champ `"flip"`.

Si vous souhaitez changer l’ordre d’un élément, vous pouvez utiliser le champ `"order"`. Vous ne pouvez changer l’ordre que vers des emplacements d’ordre non pris (voir `ItemListResponse`). Si vous ne voulez pas changer l’ordre, réglez ce champ à -1000 ou moins ou alternativement vous pouvez le régler à la valeur d’ordre actuelle de l’élément. De plus, vous ne pouvez pas changer l’ordre lorsque l’utilisateur a des fenêtres de configuration ouvertes. L’ordre ne sera pas fondu comme les autres paramètres (si demandé) mais changé instantanément à la valeur demandée dès que la requête est reçue.

Pour les champs qui définissent la cible du mouvement (`"positionX"`, `"positionY"`, `"size"` et `"rotation"`), veuillez vous référer à la documentation de la `ItemLoadRequest`. La seule différence est que cette `ItemMoveRequest` ne retournera pas d’erreur si les valeurs données sont trop élevées/basses. À la place, vous pouvez définir des valeurs de `-1000` ou moins si vous souhaitez qu’un champ respectif soit ignoré. Si vous faites cela, ce champ ne sera pas inclus dans le mouvement et la valeur actuelle respective sera utilisée.


#### Types de transition de fondu pour le déplacement des éléments

Vous pouvez définir le type de mouvement pour le fondu de position/rotation/taille en utilisant le champ `"fadeMode"`. Les valeurs acceptées sont `"linear"`, `"easeIn"`, `"easeOut"`, `"easeBoth"`, `"overshoot"` et `"zip"`. Elles ne seront utilisées que si le champ `"timeInSeconds"` a été réglé à plus de `0`.

Si vous voulez que l’utilisateur puisse arrêter le mouvement en cliquant/glissant l’élément pendant qu’il se déplace, réglez `"userCanStop"` à `true`. Si vous le réglez à `false`, les utilisateurs ne pourront pas interagir avec l’élément tant que le mouvement est en cours.

Voici une représentation visuelle des modes de déplacement :

![Modes de déplacement VTube Studio](/Images/vts_movement_modes_smooth.png)

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemMoveRequest",
	"data": {
		"itemsToMove":
		[
			{
				"itemInstanceID": "ItemInstanceId",
				"timeInSeconds": 1,
				"fadeMode": "easeOut",
				"positionX": 0.2,
				"positionY": -0.8,
				"size": 0.6,
				"rotation": 180,
				"order": -1000,
				"setFlip": true,
				"flip": false,
				"userCanStop": true
			},
			{
				"itemInstanceID": "SomeOther_ItemInstanceId",
				"timeInSeconds": 0.5,
				"fadeMode": "zip",
				"positionX": 1,
				"positionY": 1,
				"size": 0.3,
				"rotation": 0,
				"order": 25,
				"setFlip": false,
				"flip": false,
				"userCanStop": false
			}
		]
	}
}
```
Si la demande a réussi, vous recevrez une réponse contenant le statut de tous les éléments demandés.

**`RÉPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemMoveResponse",
	"data": {
		"movedItems":
		[
			{
				"itemInstanceID": "ItemInstanceId",
				"success": true,
				"errorID": -1
			},
			{
				"itemInstanceID": "SomeOther_ItemInstanceId",
				"success": false,
				"errorID": 900
			}
		]
	}
}
```

## Définir l'ordre de tri au sein du modèle pour un élément

#### ⚠️ Cette requête est actuellement disponible uniquement sur la [branche bêta publique](https://github.com/DenchiSoft/VTubeStudio/wiki/Joining-the-Beta) ⚠️

VTube Studio vous permet de trier et d’épingler les éléments **entre les calques** de votre modèle principal. Pour des informations générales sur ce fonctionnement, consultez la page sur le "[Pinning d’éléments entre calques](https://github.com/DenchiSoft/VTubeStudio/wiki/Between-Layer-Item-Pinning)".

Pour les [éléments Live2D](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items) en particulier, vous pouvez aussi diviser le **modèle d’élément Live2D** en une partie avant et une partie arrière et les insérer séparément dans le modèle principal.

Pour identifier l’élément dont vous souhaitez modifier les paramètres de tri au sein du modèle, passez son ID d’instance d’élément via le champ `"itemInstanceID"`. Une erreur `ItemSortRequestInstanceIDNotFound` est renvoyée si aucun élément avec cet ID n’est trouvé. Pour obtenir les IDs d’instance de tous les éléments chargés, vous pouvez utiliser la `ItemListRequest`. L’ID est aussi directement retourné lorsque vous utilisez la `ItemLoadRequest` pour charger un élément via l’API.

Pour toutes les erreurs que cette requête peut retourner, voir "[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)".

*Note :* Les éléments normaux (non Live2D) n’ont pas de « partie arrière » ni de « point de séparation », donc les champs arrière/séparation sont entièrement ignorés lorsqu’on utilise cette requête pour des éléments normaux. Vous pouvez les laisser vides/`null`. Le texte ci-dessous suppose que vous utilisez cette requête pour des éléments Live2D. De plus, VTube Studio s’assurera que même si vous placez la partie arrière devant la partie avant, elle ne dépassera pas cette dernière.

Pour insérer l’élément dans le modèle, définissez `"frontOn"` à `true`. Si vous avez un élément Live2D et souhaitez insérer sa partie arrière plus en arrière dans le modèle, vous pouvez aussi définir `"backOn"` à `true` (ignoré pour les éléments non Live2D).

Le point de séparation et les points d’insertion avant/arrière sont définis en utilisant `"splitAt"`, `"withinModelOrderFront"` et `"withinModelOrderBack"`. La manière dont ces champs sont interprétés dépend de ce que vous passez via `"setSplitPoint"`, `"setFrontOrder"` et `"setBackOrder"`.

Les champs suivants sont utilisés pour définir le point de séparation de l’élément et le(s) point(s) d’insertion :

* `"splitAt"` : Définit le point de séparation utilisé pour diviser le modèle d’élément Live2D en partie avant et arrière.
  * Ignoré pour les éléments non Live2D.
  * Si `"setSplitPoint"` est défini sur `"Unchanged"` : la valeur dans `"splitAt"` sera ignorée et le point de séparation restera inchangé.
  * Si `"setSplitPoint"` est défini sur `"UseArtMeshID"` : `"splitAt"` attend un ID ArtMesh existant dans le modèle Live2D de l’élément et retournera l’erreur `ItemSortRequestInvalidSplitPoint` si cet ID n’existe pas.
* `"withinModelOrderFront"` : Définit où insérer l’élément dans le modèle principal (ou la partie avant de l’élément dans le cas des éléments Live2D).
  * Si `"setFrontOrder"` est défini sur `"Unchanged"` : la valeur dans `"withinModelOrderFront"` sera ignorée et la position d’insertion de la partie avant restera inchangée.
  * Si `"setFrontOrder"` est défini sur `"UseArtMeshID"` : `"withinModelOrderFront"` attend un ID ArtMesh existant dans le modèle Live2D principal, mais si cet ID n’existe pas, la requête réussira quand même car il pourrait s’agir d’un ID d’un modèle Live2D non chargé actuellement.
  * Si `"setFrontOrder"` est défini sur `"UseSpecialID"` : `"withinModelOrderFront"` attend soit `"FullyInFront"` soit `"FullyInBack"` pour toujours placer l’élément (partie avant) complètement devant ou complètement derrière le modèle principal chargé. Toute autre valeur retournera une erreur `ItemSortRequestInvalidFrontOrder`.
* `"withinModelOrderBack"` : Définit où insérer la partie arrière des éléments Live2D dans le modèle principal.
  * Ignoré pour les éléments non Live2D.
  * Si `"setBackOrder"` est défini sur `"Unchanged"` : la valeur dans `"withinModelOrderBack"` sera ignorée et la position d’insertion de la partie arrière restera inchangée.
  * Si `"setBackOrder"` est défini sur `"UseArtMeshID"` : `"withinModelOrderBack"` attend un ID ArtMesh existant dans le modèle Live2D principal, mais si cet ID n’existe pas, la requête réussira quand même car il pourrait s’agir d’un ID d’un modèle Live2D non chargé actuellement.
  * Si `"setBackOrder"` est défini sur `"UseSpecialID"` : `"withinModelOrderBack"` attend `"FullyInBack"` pour toujours placer l’élément (partie arrière) complètement derrière le modèle principal chargé. Toute autre valeur retournera une erreur `ItemSortRequestInvalidBackOrder`.

Les valeurs invalides dans `"setSplitPoint"`, `"setFrontOrder"` et `"setBackOrder"` retourneront une erreur `ItemSortRequestInvalidValueSetType`.

Cette requête retournera aussi l’erreur `ItemSortRequestItemConfigWindowOpen` si la fenêtre de tri au sein du modèle est actuellement ouverte (c’est-à-dire que l’utilisateur est en train de définir manuellement les ordres d’insertion).

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemSortRequest",
	"data": {
		"itemInstanceID": "b616cf51fe3444729ccbf6ee54a14d1a",
		"frontOn": true,
		"backOn": true,
		"setSplitPoint": "UseArtMeshID",
		"setFrontOrder": "UseArtMeshID",
		"setBackOrder": "UseSpecialID",
		"splitAt": "MyArtMeshIDInItemModel91",		
		"withinModelOrderFront": "MyArtMeshIDInMainModel73",
		"withinModelOrderBack": "FullyInBack"
	}
}
```

Si la requête a réussi, vous recevrez cette réponse.

`"itemInstanceID"` renverra l'ID d'instance de l'élément pour lequel la requête a été effectuée.

Si un modèle principal est actuellement chargé, `"modelLoaded"` sera `true` et `"modelID"` et `"modelName"` contiendront l'ID et le nom du modèle. Si aucun modèle n'est chargé, ces champs seront vides.

Si un modèle principal est chargé, `"loadedModelHadRequestedFrontLayer"` et `"loadedModelHadRequestedBackLayer"` vous indiqueront si les points d'insertion avant/arrière que vous avez fournis ont été trouvés dans le modèle actuellement chargé. Si les points d'insertion sont restés inchangés, ces champs sont définis à `false`.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemSortResponse",
	"data": {
		"itemInstanceID": "b616cf51fe3444729ccbf6ee54a14d1a",
		"modelLoaded": true,
		"modelID": "d87b771d2902473bbaa0226d03ef4754",
		"modelName": "Akari",
		"loadedModelHadRequestedFrontLayer": true,
		"loadedModelHadRequestedBackLayer": true
	}
}
```
## Demander à l'utilisateur de sélectionner des ArtMeshes

Vous pouvez utiliser cette requête pour afficher une liste dans VTube Studio contenant tous les ArtMeshes du modèle Live2D principal actuellement chargé et demander à l'utilisateur d'en sélectionner un ou plusieurs. Une fois que l'utilisateur a terminé la sélection des ArtMeshes, les ID des ArtMeshes seront renvoyés. Vous pouvez utiliser ces ID d'ArtMesh dans diverses autres requêtes API, par exemple pour appliquer une teinte de couleur ou les rendre invisibles.

Si aucun modèle n'est actuellement chargé ou si d'autres fenêtres sont ouvertes, la requête renverra une erreur.

L'utilisateur peut survoler les ArtMeshes pour afficher leur ID et cliquer dessus pour filtrer la liste affichée pour tous les ArtMeshes sous la position du clic. L'interface affichée par cette requête ressemble à ceci :

![Écran de sélection de l'API ArtMesh](/Images/vts_request_select_artmeshes.png)

Utilisez le champ `requestedArtMeshCount` pour spécifier combien d'ArtMeshes l'utilisateur doit activer. Le bouton "OK" ne sera pas disponible tant que ce nombre exact d'ArtMeshes n'est pas activé. Si vous définissez `requestedArtMeshCount` à 0 ou moins, l'utilisateur sera invité à choisir un nombre arbitraire d'ArtMeshes (mais au moins un).

Si vous souhaitez pré-activer des ArtMeshes dans la liste, vous pouvez utiliser la liste `activeArtMeshes` et y passer certains ID d'ArtMesh. Si l'un de ces ID n'est pas contenu dans le modèle actuel, une erreur sera renvoyée. Si vous souhaitez obtenir une liste de tous les ArtMeshes du modèle actuellement chargé, utilisez la requête `ArtMeshListRequest`.

Comme vous pouvez le voir dans la capture d'écran ci-dessus, la liste contient un texte par défaut affiché, demandant à l'utilisateur de sélectionner des ArtMeshes pour le plugin. Le même texte est affiché dans une fenêtre popup lorsque vous appuyez sur le bouton `?` (aide) en haut à droite. Vous pouvez remplacer ces deux chaînes en utilisant respectivement les champs `textOverride` et `helpOverride`. Si vous les laissez vides (chaîne vide), null ou si vous les omettez dans la charge utile, le message par défaut ci-dessus sera utilisé. Si vous souhaitez remplacer ces messages, votre chaîne fournie doit contenir entre 4 et 1024 caractères, sinon la valeur par défaut sera utilisée. Vous pouvez utiliser `\n` pour les sauts de ligne dans les chaînes que vous fournissez.

**`REQUÊTE`**


```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ArtMeshSelectionRequest",
	"data": {
		"textOverride": "This text is shown over the ArtMesh selection list.",
		"helpOverride": "This text is shown when the user presses the ? button."
		"requestedArtMeshCount": 5
		"activeArtMeshes": [
			"D_BODY_00",
			"D_ARM_R_05"
		]
	}
}
```
Si la requête est réussie, la liste de sélection sera affichée à l'utilisateur. Il n'y aura pas de réponse immédiate. La réponse viendra une fois que l'utilisateur cliquera sur le bouton "OK" ou "Annuler". Le bouton "Annuler" est toujours disponible mais le bouton "OK" ne sera cliquable qu'une fois la quantité demandée d'ArtMeshes sélectionnée.

Les ArtMeshes activés/désactivés seront retournés dans les tableaux `activeArtMeshes` et `inactiveArtMeshes` respectivement. Il n'y aura **aucun chevauchement** entre ces tableaux, donc si vous combinez les ArtMeshes dans ces tableaux, vous obtiendrez une liste de tous les ArtMeshes dans le modèle.

Si l'utilisateur a cliqué sur "OK", le champ `success` sera `true`. Si l'utilisateur a cliqué sur "Annuler", le champ `success` sera `false` (dans ce cas, vous devriez probablement ignorer les tableaux `activeArtMeshes` et `inactiveArtMeshes`, bien qu'ils seront toujours retournés).

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ArtMeshSelectionResponse",
	"data": {
		"success": true
		"activeArtMeshes": [
			"D_BROW_00",
			"D_EYE_BALL_03",
			"D_EYE_BALL_02",
			"D_EYE_BALL_01",
			"D_EYE_BALL_00",
			"D_EYE_11"
		],
		"inactiveArtMeshes": [
			"D_EAR_06",
			"D_BODY_00",
			"D_ARM_R_05"
		]
	}
}
```


## Épingler des éléments au modèle

Vous pouvez utiliser cette requête pour épingler des éléments dans la scène au modèle actuellement chargé.

L'ID de l'instance de l'élément pour identifier l'élément doit être spécifié dans le champ `itemInstanceID`. Si vous voulez désépingler l'élément, il suffit de définir `pin` à `false`. Aucune autre information n'a besoin d'être fournie dans ce cas. Si aucun élément avec cet ID n'est actuellement chargé, une erreur est renvoyée (voir [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)).

Si vous souhaitez épingler un élément, la position d'épingle doit être fournie dans l'objet `pinInfo`. Il existe plusieurs façons d’épingler un élément. Par exemple, vous pouvez fournir une position exacte à laquelle épingler ou simplement fournir un ArtMesh et laisser VTS épingler l’élément au centre de celui-ci ou à une position aléatoire sur l’ArtMesh. Le fonctionnement exact sera décrit ci-dessous.

Lorsque vous envoyez une `ItemPinRequest` pour un élément avec une `ItemMoveRequest` active, la `ItemMoveRequest` sera automatiquement annulée.

De plus, si votre plugin (ou plusieurs plugins différents) envoient plusieurs requêtes d’épingle pour le même élément et qu’elles sont reçues dans la même image dans VTS, seule la dernière requête d’épingle reçue est exécutée tandis que les autres sont rejetées.

### Options pour l’épinglage

Il y a trois champs qui déterminent comment les données données dans `pinInfo` sont interprétées :

* `angleRelativeTo` : Comment l’angle fourni doit-il être interprété ?
  * `RelativeToWorld` : Angle absolu. Cela signifie que si vous passez 0 comme angle, l’élément sera épinglé droit à un angle de 0 par rapport à la fenêtre VTS. Vous utiliserez cela si vous voulez que l’élément fasse face à une certaine direction relative à la fenêtre VTS.
  * `RelativeToCurrentItemRotation` : Relatif à l’angle auquel l’élément est actuellement. Si vous passez 0 comme angle, cela signifie que l’élément sera épinglé à l’angle où il se trouve déjà, ce qui signifie que sa rotation actuelle ne sera pas modifiée. Vous utiliserez cela si vous ne voulez pas changer la rotation de l’élément et juste l’épingler tel quel.
  * `RelativeToModel` : Angle relatif à la rotation du modèle. Cela signifie que si vous passez 0 comme angle et que l’utilisateur a tourné le modèle, l’élément sera épinglé droit en relation avec le modèle. Cette « rotation du modèle » n’inclut pas la rotation causée par la déformation Live2D ArtMesh, uniquement la rotation réelle appliquée à l’ensemble du modèle par VTube Studio. Vous utiliserez cela si vous voulez que l’élément fasse face à une certaine direction relative à la rotation actuelle du modèle.
  * `RelativeToPinPosition` : Angle relatif à la position d’épingle. C’est ce que vous devez utiliser si vous souhaitez épingler un élément à une certaine position dans un certain ArtMesh à un certain angle et que vous voulez que cet angle soit exactement le même peu importe comment le modèle est tourné actuellement ou comment l’ArtMesh est déformé. Cependant, l’angle que vous devez passer pour obtenir l’effet désiré sera complètement différent pour chaque position d’épingle.
* `sizeRelativeTo` :
  * `RelativeToWorld` : Taille absolue. Entre 0 (plus petit) et 1 (plus grand). Voir aussi `ItemLoadRequest`.
  * `RelativeToCurrentItemSize` : Relatif à la taille actuelle de l’élément. Vous pouvez passer des nombres entre `-1` et `1`, qui seront ajoutés à la taille actuelle de l’élément, ce qui signifie que vous pouvez passer 0 si vous voulez épingler l’élément à sa taille actuelle sans la changer.
* `vertexPinType` : 
  * `Provided` : L’élément sera épinglé à l’ArtMesh donné en utilisant la position d’épingle fournie dans les champs `vertexID1`, `vertexID2`, `vertexID3`, `vertexWeight1`, `vertexWeight2` et `vertexWeight3`. Les détails seront expliqués ci-dessous.
  * `Center` : L’élément sera épinglé au « centre » de l’ArtMesh donné. Ce n’est pas vraiment le centre (spatial) mais en fait le triangle au milieu de la liste des triangles du maillage. Cela vous donnera la même position à chaque fois pour un ArtMesh donné.
  * `Random` : L’élément sera épinglé à un triangle aléatoire dans l’ArtMesh donné.

Si l’ID du modèle fourni ne correspond pas au modèle chargé, une erreur est renvoyée. Vous pouvez aussi laisser l’ID du modèle vide, ce qui tentera d’épingler au modèle actuellement chargé (si un est chargé).

Si le modèle ne possède pas l’ArtMesh avec l’ID d’ArtMesh que vous avez fourni, une erreur est renvoyée. Si vous laissez l’ID d’ArtMesh vide, un ArtMesh aléatoire sera choisi dans le modèle.

Par exemple, vous pourriez laisser vide à la fois l’ID du modèle et l’ID d’ArtMesh et définir `vertexPinType` à `Random`. Cela épinglera simplement l’élément à une position aléatoire sur un ArtMesh aléatoire du modèle actuellement chargé.

### Épingler à une position spécifique

Si vous définissez `vertexPinType` sur `Provided`, vous devez utiliser les champs `vertexID1`, `vertexID2`, `vertexID3`, `vertexWeight1`, `vertexWeight2` et `vertexWeight3` pour fournir une position valide sur l’ArtMesh que vous avez sélectionné en utilisant les champs `modelID` et `artMeshID`.

Les trois champs d’ID de sommet doivent être les ID des sommets d’un triangle dans l’ArtMesh donné. Pour définir une position à l’intérieur de ce triangle spécifique, utilisez les champs de poids des sommets. Ces champs seront multipliés par les positions des sommets pour définir une position dans le triangle. Gardez à l’esprit que les poids doivent totaliser exactement 1, sinon la position résultante serait en dehors du triangle (et une erreur sera retournée). Ce sont des [coordonnées barycentriques](https://en.wikipedia.org/wiki/Barycentric_coordinate_system).

Pour obtenir une de ces positions, vous pouvez utiliser l’[événement ModelClickedEvent](https://github.com/DenchiSoft/VTubeStudio/tree/master/Events#model-clicked-event). Cet événement retournera des positions d’épingles que vous pouvez utiliser avec la `ItemPinRequest` lorsque le modèle est cliqué.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemPinRequest",
	"data": {
		"pin": true,
		"itemInstanceID": "4a241269394f463ca16b8b21aa636568",
		"angleRelativeTo": "RelativeToModel",
		"sizeRelativeTo": "RelativeToWorld",
		"vertexPinType": "Provided",
		"pinInfo": {
			"modelID": "d87b771d2902473bbaa0226d03ef4754",
			"artMeshID": "hair_right_4",
			"angle": 23.938,
			"size": 0.33,
			"vertexID1": 17,
			"vertexID2": 9,
			"vertexID3": 55,
			"vertexWeight1": 0.25928378105163576,
			"vertexWeight2": 0.6850675940513611,
			"vertexWeight3": 0.055648624897003177
		}
	}
}
```

En cas de succès, la réponse contient l'ID de l'article, le nom du fichier de l'article et indique si l'article est maintenant épinglé ou non.

**`RÉPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemPinResponse",
	"data": {
		"isPinned": true,
		"itemInstanceID": "4a241269394f463ca16b8b21aa636568",
		"itemFileName": "my_test_item_2.png",
	}
}
```

## Obtenir la liste des effets de post-traitement et leur état

**Note :** Les termes effets visuels, VFX et effets de post-traitement sont utilisés de manière interchangeable dans ce document.

VTube Studio dispose d'un post-traitement intégré, vous permettant d'ajouter des effets visuels directement à la scène. Cela est disponible sur Windows et macOS. Pour plus d'informations, consultez la page ["Effets Visuels"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects).

Cette requête renvoie l'état général du système de post-traitement, une liste de tous les préréglages de post-traitement existants (créés par l'utilisateur) et une liste de tous les effets de post-traitement disponibles avec leur valeur actuelle (état actuel du post-traitement).

Si vous définissez `fillPostProcessingPresetsArray` sur `false`, le tableau `postProcessingPresets` dans la charge utile de la réponse sera vide. La demande de la liste des préréglages de post-traitement nécessite la lecture des fichiers de préréglages depuis le disque (même s'ils sont mis en cache un certain temps dans VTS), ce qui peut être lent. Si vous envoyez cette requête à une fréquence élevée, assurez-vous que `fillPostProcessingPresetsArray` n'est pas `true`, sinon cela pourrait créer un décalage dû aux E/S disque.

Si vous définissez `fillPostProcessingEffectsArray` sur `false`, le tableau `postProcessingEffects` dans la charge utile de la réponse sera vide. Si vous n'avez pas besoin de la liste complète des effets de post-traitement et de leurs valeurs, il est recommandé de définir `fillPostProcessingEffectsArray` sur `false` car la charge utile de la réponse peut être assez volumineuse.

Si vous êtes uniquement intéressé par des effets de post-traitement spécifiques, vous pouvez les lister dans le tableau `effectIDFilter`. Sinon, laissez le tableau vide pour ne pas appliquer de filtre. Une liste de tous les effets actuels est disponible ici : https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/Effects.cs

**Note :** Ces identifiants sont acceptés dans de nombreux formats différents, vous pouvez donc créer une énumération pour eux dans n'importe quel style d'énumération que vous souhaitez. Ils ne tiennent pas compte de la casse et `_` ou `-` est ignoré. Par exemple, cela signifie qu'au lieu de `ChromaticAberration` vous pouvez écrire `Chromatic_Aberration`, `chromatic_aberration`, `CHROMATIC_ABERRATION` ou tout autre style qui vous convient le mieux.

**`REQUÊTE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "PostProcessingListRequest",
	"data":
	{
		"fillPostProcessingPresetsArray": true,
		"fillPostProcessingEffectsArray": true,
		"effectIDFilter":
		[
			"ASCII",
			"ColorGrading",
			"WeatherEffects",
			"ChromaticAberration"
		]
	}
}
```
La réponse contient des informations générales sur l'état du système de post-traitement ainsi que sur les tableaux `postProcessingEffects` et `postProcessingPresets` si demandés.

`postProcessingSupported` vérifie si la plateforme supporte le post-traitement, ce qui doit toujours être `true` sur Windows et macOS. Le champ `postProcessingActive` indique si l'utilisateur a activé ou non le post-traitement. Gardez à l'esprit que vous pouvez également l'activer/désactiver via l'API en utilisant la `PostProcessingUpdateRequest` décrite ci-après. L'utilisation de la `PostProcessingUpdateRequest` peut ne pas être possible dans certaines situations, notamment lorsque certaines fenêtres ou popups liés aux configurations du post-traitement sont ouverts dans VTube Studio. Dans ce cas, `canSendPostProcessingUpdateRequestRightNow` sera `false`.

Il existe certains effets restreints/expérimentaux (voir ["Effets restreints/expérimentaux"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects#restrictedexperimental-effects)). L'utilisateur doit explicitement autoriser l'utilisation de ces effets. Le champ `restrictedEffectsAllowed` indique si l'utilisateur a autorisé ces effets à être utilisés.

Le champ `presetIsActive` indique si un preset de post-traitement est actif. Si un preset est actif, son nom sera dans le champ `activePreset`, sinon ce champ sera vide.

`presetCount` contient le nombre de presets de post-traitement dans le tableau `postProcessingPresets`. Si vous n'avez pas demandé à remplir ce tableau, `presetCount` sera 0.

`activeEffectCount` est le nombre d'effets de post-traitement actifs. La signification d'un effet "actif" est expliquée plus loin dans cette section.

Les champs "effectCount" et "configCount" contiennent respectivement le nombre d'effets et le nombre total de configurations pour tous les effets avant et après l'application du filtre (si vous avez demandé un filtrage).

### Le tableau `postProcessingEffects`

Le tableau `postProcessingEffects` contient la liste de tous les effets. Ce sont les mêmes effets qui sont affichés dans la liste VFX de VTube Studio. Chaque effet peut avoir plusieurs "configs" qui configurent certains aspects de l'effet, par exemple sa puissance ou une couleur.

L'ID utilisé pour identifier un effet est retourné dans le champ `enumID`. Il y a aussi le champ `internalID` qui contient l'ID que VTube Studio utilise en interne pour cet effet. C'est l'ID utilisé dans les fichiers JSON des presets de post-traitement, donc il ne devrait pas être pertinent pour la plupart des cas d'utilisation. Cependant, ces IDs peuvent aussi être utilisés dans l'API pour référencer les effets si vous souhaitez les utiliser pour une raison quelconque.

Les configs ont toutes l'un des types suivants (retournés dans le champ `type` de la config) :
* Float
* Int
* Bool
* String
* Color
* SceneItem

Les configs pour un effet sont retournées dans le tableau `configEntries`. Chaque config possède aussi un `internalID` et un `enumID`. Toutes les IDs de config pour tous les effets avec explications sont disponibles ici : https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs

Pour une config, seuls les champs correspondant au type de cette config sont remplis. Les autres champs seront vides ou auront une valeur par défaut et doivent être ignorés. Par exemple, pour une config de type float, les champs comme `intMin` et `colorValue` sont vides (dans ce cas 0 et une chaîne vide). En plus d'une valeur par défaut (que tous les types ont), les configs `Float` et `Int` ont aussi un `min` et un `max`.

Pour les champs contenant des couleurs, une chaîne au format hexadécimal RGBA est retournée (comme "77CCAAFF") et `colorHasAlpha` indique si cette config possède une composante alpha. Si c'est `false`, l'alpha sera toujours `FF`.

Les configs de type `SceneItem` sont essentiellement des configs de type chaîne, mais la valeur doit être le nom de fichier d'un item (se terminant par .jpg ou .png) qui existe dans le dossier "Items" de VTube Studio. Ceux-ci sont par exemple utilisés dans l'effet de particules personnalisées.

### Quand un effet est-il considéré comme "actif" ?



Chaque effet possède au moins une configuration flottante (mais peut en avoir plusieurs) avec `activationConfig` réglé sur `true`. Si l'une de ces configurations pour un effet a une valeur supérieure à 0, cet effet est considéré comme `actif`.

Pour l'effet `ColorGrading` par exemple, ce serait la configuration `ColorGrading_Strength`.

**Remarque :** Les `postProcessingEffects` dans cet exemple de charge utile de réponse sont fortement abrégés. Lorsqu'aucun filtre n'est appliqué, cela peut représenter des milliers de lignes car il y a plus de 250 configurations d'effets.

**`RÉPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "PostProcessingListResponse",
	"data": {
		"postProcessingSupported": true,
		"postProcessingActive": true,
		"canSendPostProcessingUpdateRequestRightNow": true,
		"restrictedEffectsAllowed": false,
		"presetIsActive": true,
		"activePreset": "some_effects_preset_3",
		"presetCount": 70,
		"activeEffectCount": 5,
		"effectCountBeforeFilter": 29,
		"configCountBeforeFilter": 258,
		"effectCountAfterFilter": 4,
		"configCountAfterFilter": 31,
		"postProcessingEffects": [
			{
				"internalID": "color_grading",
				"enumID": "ColorGrading",
				"explanation": "Color grading",
				"effectIsActive": false,
				"effectIsRestricted": false,
				"configEntries": [
					{
						"internalID": "color_grading-strength",
						"enumID": "ColorGrading_Strength",
						"explanation": "Effect on/off",
						"type": "Float",
						"activationConfig": true,
						"floatValue": 0.0,
						"floatMin": 0.0,
						"floatMax": 1.0,
						"floatDefault": 0.0,
						"intValue": 0,
						"intMin": 0,
						"intMax": 0,
						"intDefault": 0,
						"colorValue": "",
						"colorDefault": "",
						"colorHasAlpha": false,
						"boolValue": false,
						"boolDefault": false,
						"stringValue": "",
						"stringDefault": "",
						"sceneItemValue": "",
						"sceneItemDefault": ""
					},
					{
						"internalID": "color_grading-color_filter",
						"enumID": "ColorGrading_ColorFilter",
						"explanation": "Color filter",
						"type": "color",
						"activationConfig": false,
						"floatValue": 0.0,
						"floatMin": 0.0,
						"floatMax": 0.0,
						"floatDefault": 0.0,
						"intValue": 0,
						"intMin": 0,
						"intMax": 0,
						"intDefault": 0,
						"colorValue": "FFFFFFFF",
						"colorDefault": "FFFFFFFF",
						"colorHasAlpha": false,
						"boolValue": false,
						"boolDefault": false,
						"stringValue": "",
						"stringDefault": "",
						"sceneItemValue": "",
						"sceneItemDefault": ""
					}
				]
			}
		],
		"postProcessingPresets": [
			"My Cool Preset",
			"some_effects_preset_1",
			"some_effects_preset_2",
			"some_effects_preset_3",
			"test asdf 123456",
			"blur and color grading",
		]
	}
}
```

## Définir les effets de post-traitement

**Note :** Les termes effets visuels, VFX et effets de post-traitement sont utilisés de manière interchangeable dans ce document.

VTube Studio possède un post-traitement intégré, vous permettant d’ajouter des effets visuels directement à la scène. Ceci est disponible sur Windows et macOS. Pour plus d’informations, consultez la page ["Effets Visuels"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects).

En utilisant la `PostProcessingUpdateRequest`, vous pouvez contrôler le système de post-traitement. Vous pouvez l’activer/désactiver, charger/décharger des presets ou même contrôler directement et en détail des éléments de configuration individuels (couleurs, intensités, etc.).

Cette mise à jour ne peut être envoyée que si aucune fenêtre liée à la configuration du post-traitement n’est ouverte. Sinon, l’erreur `PostProcessingUpdateReqestCannotUpdateRightNow` sera retournée. Pour toutes les erreurs que cette requête peut retourner, voir ["ErrorsID.cs"](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs).

Utilisez `postProcessingOn` pour activer ou désactiver globalement le post-traitement. Cela fait la même chose que basculer l’interrupteur de post-traitement dans l’interface de VTS. Vous pouvez définir des presets ou des valeurs de configuration individuelles même en désactivant le post-traitement avec la même requête. Les valeurs seront quand même définies mais rien ne se passera à l’écran. En ouvrant la fenêtre de configuration du post-traitement dans VTube Studio, vous verrez que vos valeurs demandées ont été définies et seront visibles une fois le post-traitement activé. Gardez à l’esprit que si vous définissez un preset mais désactivez le post-traitement avec la même requête, toutes les valeurs du preset seront toujours définies mais le preset ne sera pas affiché comme actif dans l’interface car techniquement il n’est plus « actif ». Toutes les valeurs du preset seront visibles une fois le post-traitement activé à nouveau.

Vous pouvez définir des valeurs pour les éléments de configuration du post-traitement de deux manières :
* Définir un preset de post-traitement : Mettez `setPostProcessingPreset` à `true` et fournissez le nom du preset dans le champ `presetToSet` (juste le nom du preset sans l’extension de fichier). Si le preset n’existe pas, l’erreur `PostProcessingUpdateRequestPresetFileLoadFailed` est retournée.
* Définir des valeurs de configuration individuelles : Mettez `setPostProcessingValues` à `true` et fournissez une liste de paires clé/valeur dans le tableau `postProcessingValues`.

Vous ne pouvez pas faire les deux en même temps : si `setPostProcessingPreset` et `setPostProcessingValues` sont tous deux `true`, l’erreur `PostProcessingUpdateRequestLoadingPresetAndValues` sera retournée. Cependant, les deux peuvent être `false`. Dans ce cas, aucune valeur ne sera définie. Cela peut être utile si vous voulez juste activer/désactiver globalement le post-traitement sans changer quoi que ce soit à la configuration actuelle.

Lors du changement des valeurs de configuration directement ou via des presets, les valeurs de configuration passeront en fondu doux des anciennes aux nouvelles valeurs que vous avez fournies. La durée du fondu doit être indiquée dans le champ `postProcessingFadeTime` et doit être comprise entre 0 et 2 (secondes). Toute valeur en dehors de cette plage retournera l’erreur `PostProcessingUpdateRequestFadeTimeInvalid`.

Lors de la définition de valeurs individuelles, le champ `setAllOtherValuesToDefault` détermine si toutes les autres valeurs (celles que vous n’avez pas mises dans votre charge utile) seront laissées inchangées ou fondues vers leur valeur par défaut, ce qui signifie que tous les effets non mentionnés seront désactivés.

Si vous souhaitez utiliser des [effets restreints/expérimentaux](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects#restrictedexperimental-effects) lors de la définition directe des valeurs de configuration, assurez-vous que `usingRestrictedEffects` est défini à `true` dans votre charge utile. C’est juste un contrôle de cohérence pour éviter que ces effets ne soient utilisés par erreur. Sinon, l’erreur `PostProcessingUpdateRequestTriedToLoadRestrictedEffect` sera retournée. Cette erreur sera aussi retournée si l’utilisateur n’a pas encore activé l’utilisation de ces effets dans les paramètres VFX de VTube Studio. Cela doit être fait manuellement par l’utilisateur. Si un preset est chargé et contient des effets restreints, il sera quand même entièrement chargé et il n’y aura pas d’erreur mais les effets restreints ne seront pas activés.

Vous pouvez aussi demander que toutes les configurations d’effets soient aléatoirement modifiées. C’est juste pour le fun. Pour cela, mettez `randomizeAll` à `true`. Toutes les valeurs de configuration ou presets envoyés dans la charge utile seront ignorés si `randomizeAll` est `true`. Quand plusieurs effets sont actifs en même temps, vous obtenez juste du bruit aléatoire, donc cela limite le nombre d’effets et les valeurs de configuration ne deviennent pas trop folles. Cela peut être contrôlé avec le champ `randomizeAllChaosLevel`, qui accepte des valeurs entre 0 et 1 (les valeurs plus hautes/basses sont ramenées dans cette plage). `0` n’aura qu’un ou deux effets actifs avec des valeurs modérées tandis que `1` créera un chaos complet à l’écran. `0.4` à `0.5` est la plage de valeurs recommandée pour un bon effet. Les effets restreints seront inclus dans la randomisation uniquement si vous avez mis `usingRestrictedEffects` à `true` et que l’utilisateur a autorisé/activé l’utilisation de ces effets.

### Comment définir des valeurs de configuration individuelles

Quand vous voulez contrôler la configuration du post-traitement en détail en définissant des valeurs individuelles, vous devez mettre `setPostProcessingValues` à `true` et définir les valeurs via le tableau `postProcessingValues`. `configID` est l’ID de l’effet de configuration que vous voulez configurer, `configValue` est la valeur que vous voulez définir sous forme de chaîne.

* `configID` : ID de la configuration que vous voulez configurer, voir [cette liste de tous les IDs de config](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs). Ces IDs sont acceptés dans plusieurs formats différents, vous pouvez donc créer une énumération pour eux dans le style d’énumération que vous voulez. Ils ne sont pas sensibles à la casse et `_` ou `-` sont ignorés. Par exemple, cela signifie qu’au lieu de `Backlight_OutlineSize` vous pouvez écrire `Backlight_Outline_Size`, `backlight_outlinesize`, `BACKLIGHT_OUTLINESIZE`, `backlight-outline_size` ou tout autre style qui vous convient le mieux (voir aussi le champ `enumID` dans le tableau `configEntries` de la `PostProcessingListResponse`).
* `configValue` : La valeur à définir, sous forme de chaîne. Pour les floats ou int, les valeurs en dehors de la plage min/max de la config seront ramenées dans la plage. Les valeurs booléennes ne sont pas sensibles à la casse, donc `"True"` et `"true"` (ou `"TRUE"`, etc.) sont des valeurs acceptées.

Si vous avez des clés dupliquées dans le tableau, l’erreur `PostProcessingUpdateRequestValueListContainsDuplicates` est retournée, et si des clés sont invalides (non trouvées) ou des valeurs invalides (échec de désérialisation float, bool, etc., correctement), l’erreur `PostProcessingUpdateRequestValueListInvalid` est retournée.

**Comment réellement activer un effet :** Les effets peuvent avoir plusieurs entrées de configuration. Chaque effet a au moins une entrée de configuration (mais peut en avoir plusieurs) qui active l’effet si cette entrée est supérieure à 0. Dans la charge utile `PostProcessingListResponse`, ces configs (toujours de type float) sont marquées avec `"activationConfig": true`. Vous pouvez aussi regarder la liste de toutes les configs d’effets, où ces configs spéciales sont marquées avec `sets_active: True`, voir : https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs

### Conseils d’utilisation générale

Vous ne devez pas envoyer cette requête à haute fréquence, par exemple à chaque image. Si vous souhaitez atténuer une valeur, utilisez le champ `postProcessingFadeTime` pour définir le temps d'atténuation approprié. En fonction de la combinaison de configurations, des mises à jour fréquentes *peuvent* être acceptables, mais vous devez tester cela attentivement. Le système de post-traitement est optimisé pour des mises à jour de configuration peu fréquentes, alors assurez-vous de vérifier si votre plugin provoque un quelconque décalage avant de le publier. 

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "PostProcessingUpdateRequest",
	"data":
	{
		"postProcessingOn": true,
		"setPostProcessingPreset": false,
		"setPostProcessingValues": true,
		"presetToSet": "",
		"postProcessingFadeTime": 1.3,
		"setAllOtherValuesToDefault": true,
		"usingRestrictedEffects": false,
		"randomizeAll": false,
		"randomizeAllChaosLevel" : 0.0,
		"postProcessingValues": [
			{
				"configID": "Backlight_Strength",
				"configValue": "0.8"
			},
			{
				"configID": "Bloom_Strength",
				"configValue": "1.0"
			},
			{
				"configID": "Bloom_StreakVertical",
				"configValue": "false"
			},
			{
				"configID": "Bloom_StreakColorTint",
				"configValue": "220308FF"
			}
		]
	}
}
```

S'il n'y a pas d'erreur, vous recevrez la réponse suivante avec quelques informations générales sur le nouvel état de post-traitement après votre mise à jour demandée.

**`RÉPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "PostProcessingUpdateResponse",
	"data":
	{
		"postProcessingActive": true,
		"presetIsActive": false,
		"activePreset": "",
		"activeEffectCount": 2
	}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---