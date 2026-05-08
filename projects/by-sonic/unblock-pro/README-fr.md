# UnblockPro — Contournement des blocages Discord et YouTube


<p align="center">
  <strong>Contournement DPI automatique pour macOS et Windows</strong><br>
  Débloquez Discord, YouTube et d'autres services en un clic
</p>

<p align="center">
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/v/release/by-sonic/unblock-pro?style=for-the-badge&color=blue&label=version" alt="Version"></a>
  <a href="https://github.com/by-sonic/unblock-pro/releases/latest"><img src="https://img.shields.io/github/downloads/by-sonic/unblock-pro/total?style=for-the-badge&color=green&label=downloads" alt="Téléchargements"></a>
  <a href="https://github.com/by-sonic/unblock-pro/blob/main/LICENSE"><img src="https://img.shields.io/github/license/by-sonic/unblock-pro?style=for-the-badge&color=purple" alt="Licence"></a>
  <img src="https://img.shields.io/badge/platform-macOS%20%7C%20Windows-blue?style=for-the-badge" alt="Plateforme">
</p>

---

## Télécharger

| Plateforme | Fichier | Description |
|-----------|---------|-------------|
| **macOS** Apple Silicon (M1/M2/M3/M4) | [UnblockPro-mac-arm64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | Pour Mac avec processeur M |
| **macOS** Intel | [UnblockPro-mac-x64.zip](https://github.com/by-sonic/unblock-pro/releases/latest) | Pour Mac avec Intel |
| **Windows** | [UnblockPro-win-setup.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | Installateur |
| **Windows** | [UnblockPro-win-portable.exe](https://github.com/by-sonic/unblock-pro/releases/latest) | Version portable (sans installation) |

> Rendez-vous sur [Releases](https://github.com/by-sonic/unblock-pro/releases/latest) et téléchargez la version pour votre OS

---

## Qu’est-ce que c’est ?

**UnblockPro** est une application de bureau pour contourner les blocages DPI, qui permet d’utiliser Discord, YouTube et d’autres services sans VPN. Fonctionne sur macOS et Windows.

### Fonctionnalités clés

- **Un clic** — cliquez sur « Connecter » et tout fonctionne
- **Sélection automatique de la stratégie** — l’application trouve elle-même la méthode de contournement fonctionnelle pour votre fournisseur
- **Vérification de la connexion** — la stratégie est testée par une requête réelle, pas par devinette
- **macOS + Windows** — prise en charge complète des deux plateformes
- **Démarrage automatique** — se lance avec le système  
- **Connexion automatique** — se connecte automatiquement au démarrage  
- **Zone de notification système** — fonctionne en arrière-plan, sans gêner  
- **Nettoyage sécurisé** — les paramètres proxy sont automatiquement réinitialisés à la fermeture  

---

## Comment ça fonctionne

UnblockPro utilise la technologie [zapret](https://github.com/bol-van/zapret) pour contourner l’inspection approfondie des paquets (DPI) :

| Plateforme | Méthode |
|------------|---------|
| **macOS**  | `tpws` — proxy SOCKS5 avec modification des paquets. L’application configure automatiquement le proxy système |
| **Windows**| `winws` — intercepte les paquets au niveau du pilote via WinDivert. Ne nécessite pas de configuration proxy |

L’application teste successivement plusieurs stratégies (split+disorder, split-tls, methodeol, oob et autres), jusqu’à trouver celle qui fonctionne pour votre fournisseur.

---

## Installation

### macOS

1. Téléchargez `UnblockPro-*-mac.zip` depuis les [Releases](https://github.com/by-sonic/unblock-pro/releases/latest)  
2. Décompressez le ZIP et glissez `UnblockPro.app` dans le dossier « Applications »  
3. **Ouvrez le Terminal** et exécutez la commande :

```bash
xattr -cr /Applications/UnblockPro.app
```

4. Lancez l'application et cliquez sur « Connecter »

> **Pourquoi cette commande est-elle nécessaire ?** macOS bloque les applications sans signature payante Apple Developer (99 $/an). La commande `xattr -cr` supprime le drapeau de quarantaine — c'est sûr, le code du projet est entièrement ouvert. Fonctionne sur Intel et Apple Silicon (M1/M2/M3).

### Windows

1. Téléchargez l'installateur ou la version portable depuis [Releases](https://github.com/by-sonic/unblock-pro/releases/latest)
2. Exécutez en tant qu'administrateur
3. Cliquez sur « Connecter »

> **Important :** Sous Windows, les droits administrateur sont nécessaires pour que WinDivert fonctionne

---

## Captures d'écran

<p align="center">
  <em>Écran principal — statut de la connexion, contrôle en un clic</em>
</p>

---

## FAQ

<details>
<summary><strong>Est-ce un VPN ?</strong></summary>
Non. UnblockPro ne chiffre pas le trafic et ne le redirige pas via un serveur distant. Il modifie localement les paquets réseau afin que les systèmes DPI du fournisseur ne puissent pas reconnaître et bloquer les requêtes vers Discord/YouTube.
</details>

<details>
<summary><strong>Est-ce sécurisé ?</strong></summary>
Oui. L'application est open-source, ne collecte pas de données et n'envoie pas le trafic via des serveurs tiers. Tout le code est disponible pour audit.
</details>

<details>
<summary><strong>Que se passe-t-il si l'application plante ?</strong></summary>
Les paramètres proxy sont automatiquement réinitialisés à toute fermeture : normale, forcée ou via kill. Au prochain lancement, les réglages sont également nettoyés pour plus de fiabilité.
</details>

<details>
<summary><strong>Discord/YouTube ne fonctionnent toujours pas</strong></summary>
Essayez de vous déconnecter puis de vous reconnecter — l'application testera d'autres stratégies. Si aucune ne fonctionne, il est possible que votre fournisseur utilise un DPI avancé — créez un ticket.
</details>

<details>
<summary><strong>macOS : « le fichier n'a pas été ouvert » / Gatekeeper</strong></summary>

Ouvrez le Terminal et exécutez :
```bash
xattr -cr /Applications/UnblockPro.app
```
Après cela, l'application se lancera normalement. Cette opération doit être effectuée une seule fois.

Si vous avez téléchargé le fichier `.zip` et décompressé dans un autre dossier, indiquez le chemin vers `.app` au lieu de `/Applications/UnblockPro.app`.
</details>

---

## Développement

```bash
# Клонировать репозиторий
git clone https://github.com/by-sonic/unblock-pro.git
cd unblock-pro

# Установить зависимости
npm install

# Запустить в режиме разработки
npm start

# Собрать для текущей ОС
npm run build

# Собрать для macOS
npm run build:mac

# Собрать для Windows
npm run build:win
```

---

## Stack

- **Electron** — framework multiplateforme
- **zapret** — moteur de contournement DPI ([bol-van/zapret](https://github.com/bol-van/zapret))
- **electron-builder** — compilation et distribution
- **GitHub Actions** — builds automatiques lors des releases

---

## Licence

[MIT](LICENSE) — utilisation, modification et distribution libres.

---

<p align="center">
  <strong>by sonic</strong><br>
  <sub>Si ce projet vous a aidé — mettez une ⭐️</sub>
</p>

---

### Mots-clés / Keywords

> déblocage discord, déblocage youtube, contournement du blocage discord, contournement du blocage youtube, contournement dpi, antiblocage, débloquer discord, discord russie, youtube russie, zapret gui, contournement dpi, discord unblock russia, youtube unblock russia, anti dpi, bypass discord block, unblock discord, unblock youtube


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---