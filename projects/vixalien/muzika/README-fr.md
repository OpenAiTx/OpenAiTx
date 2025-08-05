# Muzika

> [!CAUTION]
> Muzika n'est actuellement plus maintenu, et sera archivé à l'avenir. Voir https://github.com/vixalien/muzika/issues/220 pour plus de détails.

Muzika est une application élégante de streaming musical.

![Page d'accueil de Muzika](https://raw.githubusercontent.com/vixalien/muzika/main/data/resources/screenshots/home.png)

![Muzika jouant "My Queen is Angela Davis"](https://raw.githubusercontent.com/vixalien/muzika/main/data/resources/screenshots/playing.png)

> Note : Ceci est un travail en cours. L'application n'est pas encore prête pour la production.

## Fonctionnalités

- Écran d'accueil personnalisé
- Recherche de chansons, albums, artistes, radios et playlists
- Connexion avec Google et accès à vos playlists et plus depuis votre bibliothèque
- Lecture de radios et mixes personnalisés
- Affichage des paroles et informations liées à la chanson
- Parcourir artistes, albums et playlists, etc.

## Installation

### Utilisation du dernier Flatpak Nightly

Vous pouvez télécharger le [dernier flatpak Nightly](https://vixalien.github.io/muzika/muzika.flatpakref).

### Depuis la source

Dépendances :

- GNOME Builder

1. Cloner le dépôt

```bash
git clone https://github.com/vixalien/muzika.git --recurse-submodules
```
2. Ouvrez le projet dans GNOME Builder et utilisez "Build" pour construire le projet.

> Remarque : L'utilisation directe de Meson et Ninja n'est plus prise en charge car Muzika
> utilise les derniers composants libadwaita (non publiés).

## Navigation

Muzika dispose d'un navigateur robuste qui vous permet de naviguer à travers différentes
pages en utilisant des URI muzika. Certains d'entre eux sont documentés ci-dessous.

L'URI muzika a la forme `muzika:endpoint:data`. Les URI peuvent aussi avoir des paramètres de requête.
Par exemple, `muzika:library?view=grid` ouvrira la page de la bibliothèque
avec la vue en grille.

Vous pouvez naviguer vers une URI muzika en la tapant directement dans la barre de recherche et
muzika visitera cette page directement au lieu de la chercher.

Vous pouvez aussi naviguer vers un endpoint donné en déclenchant manuellement l'action du navigateur :

1. Ouvrez l'inspecteur GTK en appuyant sur `Ctrl+Shift+I`.
2. Cliquez sur l'onglet `Actions` à droite.
3. Recherchez l'action nommée `navigator.visit` et tapez votre URI dans le
   champ `Parameter`, puis cliquez sur `Activate`.

### Points d'accès

Une liste de tous les endpoints est [ici](https://raw.githubusercontent.com/vixalien/muzika/main/src/pages.ts).

- `muzika:home` - Page d'accueil
- `muzika:playlist:<playlistId>` - Page de playlist. ex :
  `muzika:playlist:PL4fGSI1pDJn6puJdseH2Rt9sMvt9E2M4i`/
- `muzika:album:<albumId>` - Page d'album.
- `muzika:artist:<channelId>` - Page d'artiste ou de chaîne.
- `search:<query>` - Recherche. Notez que la requête doit être encodée en URL. ex :
  `search:hello%20world` recherche `hello world`.
- `muzika:library` - Bibliothèque.

D'autres endpoints seront ajoutés au fur et à mesure que Muzika supportera plus de fonctionnalités.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---