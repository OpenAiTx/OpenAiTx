<div align="center">
  <img src="https://raw.githubusercontent.com/dreamwing/clawbridge/master/public/app-icon.png" width="120" alt="ClawBridge Logo" />
  <h1>Tableau de Bord ClawBridge</h1>
  <p><strong>Le Tableau de Bord Mobile & Centre de Commande d'OpenClaw.</strong></p>

  <a href="https://clawbridge.app">
    <img src="https://img.shields.io/badge/Website-clawbridge.app-3b82f6?style=for-the-badge&logo=google-chrome&logoColor=white" alt="Website" />
  </a>
  <a href="https://github.com/openclaw/openclaw">
    <img src="https://img.shields.io/badge/OpenClaw-Compatible-22c55e?style=for-the-badge&logo=robot-framework&logoColor=white" alt="OpenClaw" />
  </a>
  <a href="LICENSE">
    <img src="https://img.shields.io/badge/License-MIT-fab005?style=for-the-badge" alt="License" />
  </a>
  
  <br/><br/>
  [ <strong>English</strong> | <a href="README_CN.md">简体中文</a> ]
</div>

---

**ClawBridge** est le **Tableau de Bord Mobile** définitif pour les agents OpenClaw. Il sert de **Centre de Commande** de poche — surveillez les pensées en temps réel, suivez les coûts en tokens et gérez les tâches en arrière-plan de n'importe où, en toute sécurité et instantanément.

## ✨ Fonctionnalités Clés

*   **📱 Tableau de Bord Mobile-Premier** : Optimisé pour les écrans de téléphone. Consultez journaux, statistiques et contrôles sans plisser les yeux.
*   **🧠 Flux d'Activité en Direct** : Regardez votre agent "penser" et exécuter des outils en temps réel. Dispose d'un journal parallèle intelligent (aucune tâche en arrière-plan manquée) et déduplication.
*   **💰 Économie de Tokens** : Suivez les coûts LLM quotidiens/mensuels et les tendances d'utilisation. Sachez exactement où va votre argent.
*   **🔍 [Centre de Contrôle des Coûts](https://raw.githubusercontent.com/dreamwing/clawbridge/master/docs/cost-control-center.md)** : 10 diagnostics automatisés qui analysent votre usage, calculent les économies et vous permettent d'appliquer des optimisations en un clic. Réduisez les coûts API de 30 à 90 %.
*   **📜 Chronologie de la Mémoire** : Parcourez les journaux quotidiens de votre agent et l'évolution de sa mémoire à long terme.
*   **🚀 Centre de Commande** : Déclenchez des tâches cron, redémarrez des services, ou tuez des scripts hors de contrôle directement depuis l'interface.
*   **⚡ Télécommande Sans Configuration** : 
    *   **Port Auto** : Trouve automatiquement un port disponible si le 3000 est occupé.
    *   **Réseautage Intelligent** : Détecte automatiquement **Tailscale/WireGuard** pour un accès sécurisé direct.
    *   **Tunnel Rapide** : Si aucun VPN n'est détecté, génère automatiquement une URL publique temporaire via Cloudflare (Sans Configuration).

## 🚀 Installation

Exécutez cette commande unique sur votre serveur OpenClaw (Ubuntu/Debian) :

```bash
curl -sL https://clawbridge.app/install.sh | bash
```
C'est tout. Le script va :
1.  Détecter votre environnement (VPN ou Public).
2.  Générer une clé d'accès sécurisée.
3.  Vous fournir une URL prête à l'emploi.

## 📱 Utilisation

### 1. Accès Zero-Config (Par défaut)
Si vous souhaitez simplement l'essayer, l'installateur fournit une URL **Tunnel Rapide** :
`https://<random-name>.trycloudflare.com/?key=<YOUR_KEY>`

*   **Avantages** : Accès instantané de n'importe où.
*   **Inconvénients** : L'URL change si vous redémarrez le service.

### 2. Accès Direct VPN (Confidentialité avant tout)
Si **Tailscale** ou **WireGuard** est détecté, l'installateur saute le tunnel public et vous donne un lien privé :
`http://<VPN_IP>:3000/?key=<YOUR_KEY>`

*   **Avantages** : Vitesse la plus rapide, confidentialité maximale.
*   **Inconvénients** : Votre téléphone doit être connecté au VPN.

### 3. Domaine Public Permanent (Avancé)
Vous voulez une URL fixe comme `dash.votresite.com` ?
1.  Obtenez un **Jeton Tunnel Cloudflare** depuis [Cloudflare Dash \> Réseau \> Tunnels](https://dash.cloudflare.com/?to=/:account/tunnels).
2.  Lancez l'installateur avec le jeton :

    ```bash
    cd skills/clawbridge
    ./install.sh --token=<YOUR_TOKEN>
    ```
    *   Ou forcer un nouveau Quick Tunnel : `./install.sh --force-cf`
3.  Après une installation réussie, retournez à la page **Nom d’hôte public** (ou **Routes**) du Tunnel Cloudflare et cliquez sur **Ajouter un nom d’hôte public** pour associer votre propre domaine à `localhost:3000` pour un accès permanent.

### 4. Docker (Conteneurisé)
Vous pouvez exécuter ClawBridge en tant que conteneur Docker. Les images sont automatiquement publiées sur le [GitHub Container Registry (ghcr.io)](https://github.com/dreamwing/clawbridge/pkgs/container/clawbridge).
```bash
docker pull ghcr.io/dreamwing/clawbridge:latest
docker run -d --name clawbridge \
  -p 3000:3000 \
  -e ACCESS_KEY=your_secret_key \
  -e OPENCLAW_STATE_DIR=/openclaw \
  -e OPENCLAW_WORKSPACE=/openclaw/workspace \
  -v ~/.openclaw:/openclaw:ro \
  -v ./data:/app/data \
  ghcr.io/dreamwing/clawbridge:latest
```

## 📱 Application Mobile (PWA)
1.  Ouvrez le tableau de bord dans Safari (iOS) ou Chrome (Android).
2.  Appuyez sur "Partager" -> "Ajouter à l'écran d'accueil".
3.  Lancez-le comme une application native (plein écran, sans barre de navigateur).

## 🛠️ Stack Technologique
*   **Backend** : Node.js (Express, WebSocket) - Processus sidecar léger.
*   **Frontend** : Vanilla JS - Zéro étape de build, chargement instantané.
*   **Tunnel** : Cloudflared

## Crédits

Un grand merci à notre communauté pour avoir aidé à améliorer ClawBridge :
- [@yaochao](https://github.com/yaochao) pour avoir signalé des problèmes critiques de sécurité et de portabilité et suggéré un refactoring architectural (#1, #2, #3, #4, #5, #6, #7).
- [@斯图超哥](https://x.com/StewartLi666) pour ses retours sur la compatibilité Linux, la stabilité de la détection IP, et la logique de rafraîchissement Quick Tunnel (#12).
- [@zjy4fun](https://github.com/zjy4fun) pour ses contributions précieuses à la correction de la détection des espaces de travail (PR #22).
- [@chrisuhg](https://github.com/chrisuhg) pour ses contributions précieuses à la résolution des problèmes d'installation et de boucle d'authentification (Issue #19).
- [@ForceConstant](https://github.com/ForceConstant) pour ses contributions précieuses à la demande de fonctionnalité : images docker versionnées (#24) (Issue #24).

---
*Licence MIT. Construit pour la communauté OpenClaw.*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-14

---