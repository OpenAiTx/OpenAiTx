# SSH-List
Gestionnaire de connexions SSH avec une interface TUI.

![demo gif](https://raw.githubusercontent.com/akinoiro/ssh-list/main/images/demo.gif)

Fonctionnalités principales :
- Ajouter et modifier des connexions
- Réorganiser et trier les connexions
- Importer les hôtes depuis ~/.ssh/config
- Rechercher et filtrer les connexions
- Exécuter des commandes sur des hôtes distants

Cette application ne modifie pas vos fichiers de configuration SSH existants. Les paramètres des hôtes peuvent être répartis sur plusieurs fichiers référencés par des directives Include (et entre configurations système et utilisateur), donc la modification automatique est peu fiable.

Cette application ne stocke pas les mots de passe. Pour une authentification sécurisée, utilisez des clés SSH.

## Prérequis
Vous devez avoir un client OpenSSH installé sur votre système.
## Installation depuis la Release GitHub
Téléchargez le dernier binaire depuis la [page des Releases](https://github.com/akinoiro/ssh-list/releases).

#### Pour exécuter la commande `ssh-list` depuis le terminal :
```
# Make the binary executable
chmod +x ssh-list
# Move it to a directory in your PATH
sudo mv ssh-list /usr/local/bin/
```
## Installer depuis crates.io

```
cargo install ssh-list
```
## Installer depuis l'AUR (Arch Linux)
```
paru -S ssh-list
```
## Installer depuis un PPA (Ubuntu, Linux Mint)
```
sudo add-apt-repository ppa:akinoiro/ssh-list
sudo apt update
sudo apt install ssh-list
```
## Installer depuis Homebrew (macOS, Linux)
```
brew tap akinoiro/tap
brew install ssh-list
```
## Construire à partir des sources
Vous aurez besoin de Rust et Cargo installés.
```
git clone https://github.com/akinoiro/ssh-list
cd ssh-list
cargo build --release
```
Le binaire sera situé dans target/release/
## Fichiers de configuration
ssh-list crée automatiquement des fichiers pour stocker vos connexions :
```
~/.ssh/ssh-list.json
```
et paramètres d'application :
```
~/.ssh/ssh-list_config.toml
```
## Appearance customization

![demo settingsgif](https://raw.githubusercontent.com/akinoiro/ssh-list/main/images/demo_settings.gif)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-17

---