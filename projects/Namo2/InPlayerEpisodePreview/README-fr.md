In Player Episode Preview
====================
## À propos ##
Ce plugin ajoute une liste d’épisodes au lecteur vidéo, ce qui vous permet de prévisualiser chaque épisode de la série TV sans quitter le lecteur.

Cette modification prend en charge les clients suivants :
* [Client Web Jellyfin](https://github.com/jellyfin/jellyfin-web)
* [Lecteur Média Jellyfin](https://github.com/jellyfin/jellyfin-media-player) (JMP) Client de bureau

### Fonctionnalités ###
* Liste tous les épisodes d’une saison
* Permet de changer de saison
* Affiche le titre de l’épisode, la description, la vignette et la progression de lecture
* Affiche les détails de l’épisode comme le classement communautaire
* Marque les épisodes comme lus ou favoris
* Démarre un nouvel épisode
* Devrait fonctionner avec des thèmes personnalisés

## Aperçu ##
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Thème utilisé : (SkinManager) Kaleidochromic
<br>
Cet aperçu ne montre pas les nouveaux boutons pour marquer un épisode comme terminé ou favori.

## Installation ##

### Client Web Jellyfin (Serveur) ###
1. Ajoutez le manifeste `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` comme dépôt de plugin Jellyfin sur votre serveur.
2. Installez le plugin `InPlayerEpisodePreview` depuis le dépôt.
3. Redémarrez le serveur Jellyfin.

<br/>

### Lecteur Média Jellyfin (JMP) Client de bureau ###
### **Obsolète avec la version JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)** ###
Comme le nouveau client JMP utilise le lecteur web actuel du serveur lui-même, il n’est plus nécessaire de modifier directement le code du client.

C’est la méthode recommandée pour installer le script sur le client de bureau.
Si vous ne vous sentez pas à l’aise pour éditer vous-même le fichier nativeshell.js (étapes 3 à 6), vous pouvez télécharger la version complète à la place, qui inclut déjà le script ajouté au fichier nativeshell.js.
Il n’est pas encore clair s’il pourrait y avoir des problèmes potentiels en remplaçant le fichier nativeshell.js par celui de la version, il est donc recommandé de suivre toutes les étapes ci-dessous.

1. Téléchargez la dernière version [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) ou [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (comprend le script déjà ajouté au fichier nativeshell.js)
2. Extrayez le fichier zip dans votre répertoire Jellyfin (par exemple C:\Program Files\Jellyfin\Jellyfin Media Player)
3. Dans votre répertoire Jellyfin, suivez le chemin du dossier "web-client\extension"
4. Ouvrez le fichier "nativeshell.js" dans un éditeur de texte.
5. Dans le fichier, trouvez la section `const plugins = [];`. Ajoutez une nouvelle ligne au début de la liste et collez `'inPlayerEpisodePreviewPlugin',`. La section devrait maintenant ressembler à ceci :
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Enregistrez le fichier et redémarrez le client JMP.

## Dépannage ##

### 1. Le bouton d'aperçu n'est pas visible ###
Cela est très probablement lié à des permissions incorrectes pour le fichier `index.html`.

#### 1.1 Changer la propriété à l'intérieur d'un conteneur docker ####
Si vous exécutez jellyfin dans un conteneur docker, vous pouvez changer la propriété avec la commande suivante
(remplacez jellyfin par le nom de votre conteneur, user et group par l'utilisateur et le groupe de votre conteneur) :
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Vous pouvez exécuter cela en tant que tâche cron au démarrage du système.

(Merci à [muisje](https://github.com/muisje) pour son aide avec [cette](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) solution)

#### 1.2 Changer la propriété sur une installation Windows ####
1. Naviguez vers : `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Clic droit sur `index.html` → `Propriétés` → `Onglet Sécurité` → Cliquez sur `Modifier`
3. Sélectionnez votre utilisateur dans la liste et cochez la case `Écriture` pour la permission.
4. Redémarrez à la fois le serveur et le client.

(Merci à [xeuc](https://github.com/xeuc) pour [cette](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) solution)

Si cela ne fonctionne pas, veuillez suivre la discussion dans [ce](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) (ou [ce](https://github.com/Namo2/InPlayerEpisodePreview/issues/49)) ticket.

<br/>
Si vous rencontrez une erreur que vous ne pouvez pas résoudre vous-même, n’hésitez pas à ouvrir un ticket.
<br/>Veuillez garder à l’esprit que chaque système est différent, ce qui peut entraîner un comportement inattendu, donc ajoutez autant d’informations que possible.
<br/>Les logs de Jellyfin et les logs de la console du navigateur (préfixés par [InPlayerEpisodePreview]) sont toujours utiles.

## Inconvénients ##
* Le plugin téléchargera des données supplémentaires comme la description de l’épisode depuis le serveur.

## Crédits ##
La structure du plugin est basée et inspirée du plugin [Jellyscrub](https://github.com/nicknsy/jellyscrub) par [NickNSY](https://github.com/nicknsy).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---