<div align="center">
  <br/>
  <img src="https://raw.githubusercontent.com/therepanic/spotilyrics/master/logo.png" width="350" alt="Logo Spotilyrics"/>
  <p><i>Voir les paroles synchronisées de Spotify dans VS Code pendant que vous codez.</i></p>
<p>
  <a href="https://marketplace.visualstudio.com/items?itemName=therepanic.spotilyrics"><img src="https://img.shields.io/badge/VS%20Code-Extension-blue?style=flat&logo=visualstudiocode" /></a>
  <a href="https://developer.spotify.com/documentation/web-api"><img src="https://img.shields.io/badge/Spotify-API-1DB954?style=flat&logo=spotify" /></a>
  <a href="https://lrclib.net"><img src="https://img.shields.io/badge/Lyrics-LRClib-orange?style=flat" /></a>
  <a href="https://news.ycombinator.com/item?id=45087905"><img src="https://img.shields.io/badge/Hacker%20News-Discuss-orange?style=flat&logo=ycombinator" /></a>
  <a href="https://unlicense.org/"><img src="https://img.shields.io/badge/License-Unlicensed-red?style=flat" /></a>
</p>
</div>

---

## ✨ Fonctionnalités

- 📌 **Synchronisation des paroles en direct** avec votre lecture Spotify.
- 🎨 Couleurs des paroles automatiquement thématisées à partir de la pochette de l’album (via `colorthief`).
- 🖥️ **Vue en panneau latéral** fluide – code à gauche, paroles à droite.
- 📱 **Mode mobile** – lignes non jouées en noir, lignes jouées en blanc (comme l’application mobile Spotify).
- 🔑 Connexion simple **une seule fois** avec votre propre Client ID Spotify.
- 🚪 Commande de déconnexion rapide pour réinitialiser la session.
- ⚡ Définissez une **taille maximale du cache de pistes** pour la synchronisation des paroles.

---

## 📸 Démo

## <img src="https://raw.githubusercontent.com/therepanic/spotilyrics/master/demo.png"/>

## ⚡️ Installation

1. Ouvrez **VS Code** → Extensions → recherchez `spotilyrics` ou [installez depuis le Marketplace VS Code](https://marketplace.visualstudio.com/items?itemName=therepanic.spotilyrics).

2. Exécutez la commande :

```
Show Spotify Lyrics via Spotilyrics
```

---

## 🔑 Authentification (configuration unique)

1. Allez sur [Spotify Developer Dashboard](https://developer.spotify.com/dashboard).
2. Créez une application → copiez le **Client ID**.
3. **Important :** définissez l'**URI de redirection** de votre application sur : `http://127.0.0.1:8000/callback`
4. Exécutez la commande `Afficher les paroles Spotify via Spotilyrics`.
5. Collez votre **Client ID** dans le panneau et connectez-vous.
6. Profitez des paroles synchronisées pendant que vous codez ! 🎶

> ℹ️ Pourquoi ? – Pour respecter les limites d'utilisation de l'API Spotify, vous devez utiliser votre propre ID.

---

## ⌨️ Commandes

- `Afficher les paroles Spotify via Spotilyrics` (`spotilyrics.lyrics`) – ouvrir le panneau des paroles synchronisées.
- `Basculer en mode mobile` (`spotilyrics.toggleMobileMode`) – passer du mode normal au mode mobile.
- `Déconnexion de Spotilyrics` (`spotilyrics.logout`) – effacer la session et se reconnecter si besoin.
- `Définir la taille max du cache des pistes` (`spotilyrics.setTracksCacheMaxSize`) – configurer le nombre maximal de pistes mises en cache pour les paroles.

---

## ⚙️ Technologies utilisées

- [Spotify Web API](https://developer.spotify.com/documentation/web-api/)
- [LRClib](https://lrclib.net/) pour les paroles avec minutage
- [colorthief](https://lokeshdhakar.com/projects/color-thief/) pour le thème basé sur la pochette
- TypeScript + VS Code WebView

---

## 📜 Licence

Ce projet est sous licence **Non licencié**.  
N’hésitez pas à l’utiliser, le modifier et le remixer – mais sans aucune garantie 😉

---
<div align="center">
<sub>Fait avec ❤️ par therepanic. Code dur, ambiance encore plus forte 🎧</sub>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-02

---