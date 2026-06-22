# Fansly Scraper

> [!IMPORTANT]
> **Mise à jour du statut du projet**
>
> En raison d’un récent problème de santé, ce projet passe en très basse priorité dans ma vie. Les mises à jour et le support seront très limités pour un avenir prévisible. Merci pour votre compréhension.
>
> Si vous cherchez une alternative plus activement maintenue avec une interface Web complète, un tableau de bord en direct et un lecteur VOD, ainsi qu’une surveillance et archivage automatiques en arrière-plan, consultez **[Accerso](https://accesro.one)**.

> [!WARNING]
> **‼️ Faux positif de Windows Defender** (aucune idée d’où cela vient ni pourquoi)
>
> L’exécutable Windows de ce programme est fréquemment détecté comme **`Trojan:Script/Wacatac.B!ml`** par Windows Defender et d’autres antivirus. Il s’agit d’un **faux positif**.
>
> **Pourquoi cela arrive-t-il ?**
> Le `!ml` dans le nom de détection signifie qu’il a été signalé par un modèle d’apprentissage automatique, pas par un humain. Comme il s’agit d’un outil scraper open-source non signé qui effectue de nombreuses requêtes internet, le système automatique le marque incorrectement comme suspect. C’est un problème courant pour de nombreux outils en ligne de commande basés sur Go et Rust.
>
> **Solution recommandée – Installer via Go (devrait idéalement contourner les problèmes AV) :**
> ```bash
> go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
> ```
>
> **Ce que vous pouvez faire :**
> 1.  **Faire confiance au programme :** Vous pouvez temporairement désactiver Windows Defender pour télécharger et exécuter le programme, puis l’ajouter en exception.
> 2.  **Compiler depuis la source :** Si vous avez Go installé, vous pouvez le compiler vous-même. Le programme n’est pas détecté lorsqu’il est compilé localement ou installé via go.
>
> Le code est entièrement open-source pour que vous puissiez l’inspecter. Il est sûr à utiliser, mais je comprends que les alertes AV puissent inquiéter.

Un outil simple tout-en-un pour télécharger et surveiller le contenu des créateurs Fansly.

> **⚠️ En cours de développement** – Certaines fonctionnalités peuvent ne pas fonctionner parfaitement. Voir les [problèmes connus](#known-issues) ci-dessous.


## Prérequis

- **Optionnel mais fortement recommandé** : [ffmpeg](https://ffmpeg.org/) pour l’enregistrement de livestreams et la sauvegarde de vidéos de meilleure qualité. Suivez [ce guide](https://phoenixnap.com/kb/ffmpeg-windows) pour l’installation dans le chemin système sous Windows.
- **Optionnel** : [mt](https://github.com/mutschler/mt) pour de meilleures planches-contact

## Démarrage rapide

### 1. Téléchargement
- **Méthode facile** : Visitez la [page de téléchargement](https://agnosto.github.io/projects/fansly-scraper/) (détecte automatiquement votre système)
- **Méthode manuelle** : Téléchargez depuis les [releases GitHub](https://github.com/agnosto/fansly-scraper/releases)
- **Installation via Go** :
```bash
go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
```

### 2. Exécuter le programme
```bash
./fansly-scraper
```

Lors du premier lancement, l'assistant de configuration vous aide à tout configurer. Appuyez sur 'a' pour utiliser la connexion automatique : il ouvre Fansly et fournit un extrait d'une ligne à coller dans la console DevTools. Votre jeton et l'agent utilisateur sont capturés automatiquement et enregistrés dans la configuration.

## Utilisation de base

### Mode interactif (recommandé pour les débutants)
```bash
./fansly-scraper
```

Depuis le menu principal, vous pouvez :
- Lancer l'assistant de configuration (choisir l'emplacement de sauvegarde, connexion automatique)
- Réinitialiser la configuration (restaurer les paramètres par défaut, relancer l'assistant)

### Mode ligne de commande
```bash
# Download all content from a creator
./fansly-scraper -u {creator-name}

# Download specific content types
./fansly-scraper -u {creator-name} -d [all|timeline|messages|stories]

# Monitor for live streams
./fansly-scraper -m {creator-name}

# Start/stop monitoring
./fansly-scraper monitor [start|stop]
```

**Note** : La surveillance en direct nécessite de garder votre session terminal active. Pour exécuter la surveillance en arrière-plan, envisagez d'utiliser des multiplexeurs de terminal comme [tmux](https://github.com/tmux/tmux/wiki) ou [zellij](https://github.com/zellij-org/zellij) sur Linux/WSL. À partir de la version 0.6.3, vous pouvez surveiller des créateurs supplémentaires en exécutant `-m creator` dans des instances de terminal séparées sans redémarrer le processus de surveillance existant.

### Mettre à jour le programme
```bash
./fansly-scraper update
```

## Feuille de route du projet & Configuration avancée

Notre développement est suivi publiquement sur notre **[Feuille de route du projet](https://github.com/users/agnosto/projects/1)**. Vous pouvez voir sur quoi nous travaillons, ce qui est prévu pour l'avenir, et contribuer à la discussion.

- **Guide de configuration** : Voir le **[Wiki officiel](https://github.com/agnosto/fansly-scraper/wiki)**
- **Compiler à partir des sources** :
  ```bash
  git clone https://github.com/agnosto/fansly-scraper && cd fansly-scraper
  go build -v -ldflags "-w -s" -o fansly-scraper ./cmd/fansly-scraper
  ```

## Contribution

Les contributions sont les bienvenues et grandement appréciées ! Que ce soit pour signaler un bug, proposer une fonctionnalité ou soumettre une pull request, votre aide est précieuse.

![alt text](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

![alt text](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat-square)

Veuillez lire nos [Directives de contribution](https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./CONTRIBUTING.md) avant de commencer.
Consultez l’[onglet Issues](https://github.com/agnosto/fansly-scraper/issues) pour voir s’il y a une tâche que vous souhaitez prendre en charge.

## Problèmes connus

- **Redownload** : Depuis la version 0.8.3, la convention de nommage des fichiers a été modifiée, ce qui entraîne un retéléchargement des médias.
- **Enregistrement du chat** : Peut occasionnellement manquer des messages lors des reconnexions.
- **Utilisateurs MacOS** : Il peut être nécessaire d’autoriser les notifications dans les [paramètres système](https://github.com/gen2brain/beeep/issues/67#issuecomment-2646474049).
- **Statut en direct** : Appuyez sur `r` dans l’interface TUI pour rafraîchir le statut en direct.
- **Fichiers en double** : Parfois, la même image peut apparaître deux fois en raison de la structure de l’API de Fansly.
- **Formats de date pour le nom de fichier de livestream** : En cas d’interruption et de tentative de réenregistrement, si le format de date n’est pas assez précis (par exemple, sans horodatage), il peut échouer à sauvegarder le stream car les deux VOD auront le même nom. Pour l’instant, utilisez l’un de ces formats : `2006-01-02_15:04:05` ou `20060102_150405`.

## Soutenez le projet

Si cet outil vous aide, envisagez de le sponsoriser sur GitHub :

[![Sponsor agnosto on GitHub](https://img.shields.io/badge/Sponsor-%23EA4AAA?style=for-the-badge&logo=githubsponsors)](https://github.com/sponsors/agnosto)

Sinon, vous pouvez faire un don ponctuel via une cryptomonnaie :

<table>
  <tr>
    <td align="center"><strong>Bitcoin (BTC)</strong></td>
    <td align="center"><strong>Solana (SOL)</strong></td>
  </tr>
  <tr>
    <td align="center">
      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/btc_qr.png" alt="Code QR Bitcoin" width="200"/>
      <p><code>bc1q0e78wrtc9ezp6tqv000wfewgqf2ue4tpzdk7ee</code></p>
    </td>
    <td align="center">
      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/sol_qr.png" alt="Code QR Solana" width="200"/>
      <p><code>Bv3kYZcwSTHXAQtnPddTF27D3F6Gc29v2MfFLqmGF6Gf</code></p>
    </td>
  </tr>
</table>

---

> [!CAUTION]
> **Avertissement** : Cet outil n'est pas affilié à Fansly ou Select Media LLC. Utilisez-le à vos risques et périls. Le développeur de ce script n'est pas responsable des actions des utilisateurs finaux ni des conséquences pouvant affecter leur compte. Utilisez à vos risques et périls.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---