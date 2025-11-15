<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <p>Les traductions suivantes ont été générées automatiquement via l’IA. Veuillez noter qu’elles peuvent comporter des inexactitudes ou faire référence à d’anciennes versions de ce fichier README.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Aperçu d’épisodes dans le lecteur
====================
## 📄 À propos
Ce plugin ajoute une liste d’épisodes au lecteur vidéo, permettant de prévisualiser chaque épisode de la série télévisée sans quitter le lecteur.

Cette modification prend en charge les clients suivants :
* [Client Web Jellyfin](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) Client de bureau

## ✨ Fonctionnalités
* Lister tous les épisodes d'une saison
* Passer d'une saison à l'autre
* Affiche le titre de l'épisode, la description, la miniature et la progression de lecture
* Affiche les détails de l'épisode comme le classement de la communauté
* Marquer les épisodes comme lus ou favoris
* Démarrer un nouvel épisode
* Fonctionne avec des thèmes personnalisés

## 📸 Aperçu
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Thème utilisé : (SkinManager) Kaleidochromic
<br>
Cet aperçu ne montre pas les nouveaux boutons pour marquer un épisode comme terminé ou favori.

## 🔧 Installation

### Client Web Jellyfin (Serveur)

> [!NOTE]
> Il est fortement recommandé d'avoir [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) au moins en version v2.2.1.0 installée. Cela permet d'éviter les problèmes de permission lors de la modification du fichier index.html sur tout type d'installation !
<details open>
<summary> Voir les instructions... </summary>

1. Ajoutez le manifeste `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` comme dépôt de plugin Jellyfin sur votre serveur.
2. Installez le plugin `InPlayerEpisodePreview` depuis le dépôt.
3. Redémarrez le serveur Jellyfin.
</details>

### Client Desktop Jellyfin Media Player (JMP) (Obsolète)
<details>
<summary> Voir les instructions... </summary>

**Obsolète avec la version JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

Comme le nouveau client JMP utilise désormais le lecteur web du serveur, il n'est plus nécessaire de modifier le code du client directement.

C'est la méthode recommandée pour installer le script sur le client desktop.
Si vous ne vous sentez pas à l'aise pour modifier vous-même le fichier nativeshell.js (étapes 3 à 6), vous pouvez télécharger la version complète à la place, qui inclut déjà le script ajouté au fichier nativeshell.js.
Il n'est pas encore clair s'il pourrait y avoir des problèmes potentiels en remplaçant le fichier nativeshell.js par celui de la version complète, il est donc recommandé de suivre toutes les étapes ci-dessous.

1. Téléchargez la dernière version [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) ou [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (inclut déjà le script ajouté au fichier nativeshell.js)
2. Extrayez le fichier zip dans votre répertoire Jellyfin (par exemple : C:\Program Files\Jellyfin\Jellyfin Media Player)
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
</details>

## 💡 Dépannage

### 1. Le bouton d’aperçu n’est pas visible
Cela est très probablement lié à des permissions incorrectes pour le fichier `index.html`.

<details>
<summary> Voir une liste de solutions possibles... </summary>

#### 1.1 Évitez ce problème en utilisant le plugin [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation).

#### 1.2 Changer la propriété dans un conteneur docker
Si vous exécutez jellyfin dans un conteneur docker, vous pouvez changer la propriété avec la commande suivante
(remplacez jellyfin par le nom de votre conteneur, user et group par l’utilisateur et le groupe de votre conteneur) :
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Vous pouvez exécuter ceci comme une tâche cron au démarrage du système.
(Merci à [muisje](https://github.com/muisje) pour son aide concernant [cette](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) solution)

#### 1.3 Changer la propriété lors d'une installation sous Windows
1. Naviguez vers : `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Faites un clic droit sur `index.html` → `Propriétés` → onglet `Sécurité` → Cliquez sur `Modifier`
3. Sélectionnez votre utilisateur dans la liste et cochez la case d’autorisation d’écriture.
4. Redémarrez le serveur et le client.
   (Merci à [xeuc](https://github.com/xeuc) pour [cette](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) solution)

Si aucune des solutions ci-dessus ne fonctionne, veuillez consulter les anciens problèmes. Par exemple [ici](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) ou [ici](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Si vous rencontrez une erreur que vous ne pouvez pas résoudre vous-même, n'hésitez pas à ouvrir un ticket.
<br/>Veuillez garder à l'esprit que chaque système est différent, ce qui peut entraîner un comportement inattendu. Ajoutez donc autant d'informations que possible à ce sujet.
<br/>Les journaux Jellyfin et les journaux de la console du navigateur (préfixés par [InPlayerEpisodePreview]) sont toujours utiles.

## Crédits
La structure du plugin est basée et inspirée du plugin [Jellyscrub](https://github.com/nicknsy/jellyscrub) de [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---