<div align="center">  
  <a href="https://irokaru.github.io/pixel-scaler/">
    <img src="https://raw.githubusercontent.com/irokaru/pixel-scaler/master/./public/logo.png" width="33%" alt="Logo Pixel Scaler"/>
  </a>
  <p><b>Un outil d’agrandissement de pixel art</b></p>

  <!-- Badges -->
  <p>
    <a href="https://github.com/irokaru/pixel-scaler/releases/latest"><img src="https://img.shields.io/github/v/release/irokaru/pixel-scaler.svg?style=for-the-badge" alt="Dernière version"/></a>
    <img src="https://img.shields.io/github/downloads/irokaru/pixel-scaler/total?style=for-the-badge" alt="Téléchargements"/>
    <a href="https://app.codecov.io/gh/irokaru/pixel-scaler/tree/master"><img src="https://img.shields.io/codecov/c/github/irokaru/pixel-scaler?style=for-the-badge" alt="Couverture"/></a>
    <a href="https://x.com/IroKaru"><img src="https://img.shields.io/twitter/follow/irokaru?style=for-the-badge" alt="Suivre sur X"/></a>
  </p>
</div>

## Environnement de développement

* node (>= 22.x)
* rust (>=1.85.0)
  * (requis pour le développement Tauri)

## Configuration pour le développement (WSL)

Installer les dépendances :

```sh
npm ci
```

(Facultatif) Si vous souhaitez utiliser Tauri :

```sh
cargo install tauri-cli
sudo apt install -y libsoup2.4-dev javascriptcoregtk-4.1 libsoup-3.0 webkit2gtk-4.1 \
                    libjavascriptcoregtk-4.0-dev libwebkit2gtk-4.0-dev librsvg2-dev
```

## Commandes Disponibles

| Commande                | Description                                               |
|-------------------------|-----------------------------------------------------------|
| `npm run dev`           | Démarrer le serveur de développement avec Vite           |
| `npm run dev:tauri`     | Démarrer le serveur de développement Tauri                |
| `npm run build`         | Construire le projet pour la production                    |
| `npm run build:tauri`   | Construire le projet avec tauri                            |
| `npm run preview`       | Prévisualiser le projet construit (requiert d'abord `npm run build`) |
| `npm run test`          | Exécuter les tests                                        |
| `npm run test:watch`    | Exécuter les tests en mode surveillance                    |
| `npm run test:coverage` | Exécuter les tests avec couverture                         |
| `npm run test:e2e`      | Exécuter les tests avec playwright                         |
| `npm run clean`         | Supprimer les fichiers générés                             |
| `npm run lint-staged`   | Lancer le linting sur les fichiers stagés                  |
| `npm run prepare`       | Configurer Husky pour les hooks Git                        |

## Bibliothèque de mise à l’échelle

* xBRjs (Copyright 2020 Josep del Rio)
  * https://github.com/joseprio/xBRjs


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-27

---