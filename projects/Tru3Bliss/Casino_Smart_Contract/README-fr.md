# 🎯 Guide d'installation du projet

Bienvenue sur le projet ! Ce guide vous aidera à démarrer rapidement en installant les outils requis et en configurant votre environnement local.

---

## 🛠️ Prérequis

Assurez-vous que les outils suivants sont installés sur votre système :

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **Version recommandée d'Anchor :** `0.30.1`

---

## ✅ Vérifier les versions & configurer

Vérifiez que tout est correctement installé et configuré :

```bash
rustc --version             # Vérifier la version de Rust
solana --version            # Vérifier la version du Solana CLI
anchor --version            # Vérifier la version d'Anchor

solana config get           # Voir la configuration actuelle de Solana
solana config set --url devnet  # Définir le réseau sur devnet
```
---

## 🔐 Configuration du portefeuille

Générez et gérez les clés de votre portefeuille :

```bash
solana-keygen new -o ./keys/admin.json     # Générer une nouvelle paire de clés
solana-keygen pubkey ./keys/admin.json     # Obtenir la clé publique
solana balance ./keys/admin.json           # Vérifier le solde du portefeuille
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # Airdrop de 5 SOL sur votre portefeuille
```

---

## 📦 Installation du projet

Clonez le projet et installez les dépendances :

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ Démarrage rapide

### 🏗️ Compiler le programme

Compilez le smart contract Anchor :

```bash
# Compiler le programme Anchor en utilisant la toolchain nightly
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# Synchroniser toutes les clés publiques du programme
anchor keys sync

# Recompiler si l'adresse du programme dans lib.rs a changé
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Test sur Devnet

Assurez-vous que votre `Anchor.toml` utilise Devnet :

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 Déployer le programme

```bash
anchor deploy
```

---

## 🧪 Utiliser le CLI pour interagir avec le programme
Utilisez ces scripts CLI pour interagir localement avec votre contrat intelligent.

---

### 🔹 Initialiser le programme

```bash
yarn script config
```

Initialise la configuration du contrat.

---

### 🔹 Créer un tour

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# Exemple :
yarn script create -t 60 -d 100000000 -j 100
```

**Paramètres :**

- `<ROUND_TIME>` : Durée du tour en secondes (par exemple, `60` = 60s).
- `<MIN_DEPOSIT_AMOUNT>` : Dépôt minimum en lamports (1 SOL = 1_000_000_000). Doit être supérieur à `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`.
- `<MAX_JOINER_COUNT>` : Nombre maximum de participants. Doit être inférieur à `config.TEST_INITIAL_MAX_JOINER_COUNT`.

---

### 🔹 Rejoindre un tour

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# Exemple :
yarn script join -a 100000000 -g 2
```
**Paramètres :**

- `<DEPOSIT_SOL_AMOUNT>` : Montant du dépôt en lamports (par exemple, 0,1 SOL = 100_000_000).
- `<ROUND_NUMBER>` : Index du round à rejoindre. Commence à `0`. Doit être inférieur à `total_round`.

> 🕒 Remarque : Le compte à rebours pour le round commence lorsque le deuxième participant rejoint.

---

### 🔹 Sélectionner le gagnant

```bash
yarn script winner -g <ROUND_NUMBER>

# Exemple :
yarn script winner -g 2
```

**Remarque :** N'appelez cette commande qu'après que le temps du round soit entièrement écoulé.

---
### 🔹 Réclamer les gains

```bash
yarn script claim -g <NUMÉRO_DU_TOUR>

# Exemple :
yarn script claim -g 2
```

**Remarque :** Ceci doit être exécuté par le portefeuille gagnant après la sélection du gagnant.

---

## Contact

Pour toute question ou demande concernant le développement de smart contracts Solana, l’implémentation DeFi ou l’intégration DEX, veuillez contacter les responsables du projet.

**Telegram** : [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)** : [@XTruebliss](https://x.com/XTruebliss)
**Discord** : [@trueb1iss](https://discord.com/users/1274339638668038187)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---