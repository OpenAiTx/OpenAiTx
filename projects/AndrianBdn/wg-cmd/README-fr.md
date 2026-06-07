# WG Commander 

alias "wg-cmd" — Interface utilisateur en mode texte pour gérer les fichiers de configuration WireGuard

<a href="https://github.com/andrianbdn/wg-cmd/releases/latest"><img src="https://img.shields.io/github/v/release/andrianbdn/wg-cmd" /></a>
<a href="./LICENSE"><img src="https://img.shields.io/github/license/andrianbdn/wg-cmd" /></a>
<a href="./go.mod"><img src="https://img.shields.io/github/go-mod/go-version/andrianbdn/wg-cmd" /></a>
[![Go Report Card](https://goreportcard.com/badge/github.com/andrianbdn/wg-cmd)](https://goreportcard.com/report/github.com/andrianbdn/wg-cmd)

![capture d'écran](https://user-images.githubusercontent.com/994900/218720566-e5b3ab22-d7fc-4df7-a777-ad9b6280ada8.png)

# Fonctionnalités
- pas besoin de navigateur ni de port HTTP - fonctionne dans le terminal, aussi via SSH
- dispose d’un assistant d’installation convivial
- interface utilisateur textuelle pour gérer les pairs
- affichage du code QR dans le terminal
- copie de la configuration dans le presse-papiers (OSC 52)
- configure automatiquement sysctl, systemd, NAT

## Limitations actuelles
- supporte une configuration WireGuard simple client-serveur
- principalement pour Linux (suppose que iptables, systemd, sysctl sont disponibles) — voir la section [Autres OS](#other-os-besides-linux)
- ne peut pas gérer une configuration WireGuard existante (mais permet de créer de nouvelles interfaces WireGuard sur le même hôte)

# Installation 

Assurez-vous d’avoir WireGuard et iptables installés  
(`apt install wireguard-tools` sous Ubuntu / Debian, `dnf install wireguard-tools iptables` sous Rocky/Alma 9). 

Pour télécharger avec curl, exécutez :
```shell
# for x86_64 
curl -SL https://github.com/andrianbdn/wg-cmd/releases/download/v0.1.7/wg-cmd-0.1.7-linux-amd64 -o /usr/local/bin/wg-cmd

# for arm64 
curl -SL https://github.com/andrianbdn/wg-cmd/releases/download/v0.1.7/wg-cmd-0.1.7-linux-arm64 -o /usr/local/bin/wg-cmd
```

Définissez les permissions appropriées et exécutez l’outil : 
```
chmod 755 /usr/local/bin/wg-cmd
wg-cmd
```
Si vous n'avez pas `/usr/local/bin` dans $PATH, vous devrez  
exécuter la commande `/usr/local/bin/wg-cmd` en utilisant le chemin complet.  

WG Commander nécessite les permissions root pour ajuster automatiquement sysctl,  
créer des unités systemd et écrire dans /etc/wireguard.  

# Utilisation  

Lors du premier lancement, WG Commander affichera l'assistant de configuration,  
qui permet de configurer une nouvelle interface WireGuard de manière interactive.  

Lors des lancements suivants (si l'assistant a réussi), il affichera simplement l'interface de gestion TUI.  

Note concernant le code QR : certains appareils (Android ?) peuvent nécessiter un code QR de meilleure qualité.  
WG Commander augmentera automatiquement la qualité lorsque vous augmentez la résolution de la fenêtre du Terminal (police plus petite, fenêtre plus grande).  

## Utilisation avancée  

Vous pouvez exécuter WG Commander en tant qu'utilisateur non-root si vous modifiez les permissions sur  
/etc/wireguard et configurez sysctl/systemd manuellement.  

WG Commander conserve sa propre configuration d'interface dans `~/.config/wg-cmd/wg-cmd.toml`  

Les options les plus importantes sont :
```toml
WireguardDir = "/etc/wireguard"
# directory for WireGuard configuration files 

DatabaseDir = "/etc/wireguard"
# directory for WG Commander database files (wgc-<interface-name>)
```
Vous pouvez modifier ces options pour pointer vers des répertoires auxquels vous avez accès en écriture.

### Options spéciales

Exécutez `wg-cmd new` pour démarrer l'assistant de configuration d'une nouvelle interface.

Exécutez `wg-cmd <interface-wg>` pour basculer vers une interface spécifique (doit être créée auparavant avec wg-cmd).

Exécutez `wg-cmd <interface-wg> make` pour générer la configuration Wireguard sans afficher l'interface utilisateur.

### Configuration

WG Commander utilise des répertoires comme sa « base de données ».
Il stocke la configuration de l'interface dans le répertoire /etc/wireguard/wgc-<nom-interface>.

La configuration est stockée au format de fichier [TOML](https://toml.io).

La plupart des clés de configuration sont similaires à celles de WireGuard.

#### configuration serveur (0001-server.toml)
Certaines clés dans ce fichier de configuration seront en fait utilisées pour générer
les fichiers de configuration client.

`ClientRoute` - AllowedIPs pour la configuration client

`ClientDNS` - valeur de configuration DNS pour tous les clients

`ClientServerEndpoint` - Endpoint pour la configuration client

`ClientPersistentKeepalive` - PersistentKeepalive pour la configuration client

`MTU` - MTU pour le serveur et le client (0 — laisser WireGuard choisir)

#### configuration client (nnnn-%client%.toml)

`ClientRoute` - remplace complètement le `ClientRoute` de la configuration serveur

`AddServerRoute` - ajoute un réseau supplémentaire à AllowedIPs pour le client côté serveur (utile
lorsque vous souhaitez router le trafic d'un client vers le réseau d'un autre client via le serveur)

`MTU` - Remplacer le MTU du serveur par une valeur différente pour ce client. Mettez -1 pour omettre le MTU de cette configuration client WireGuard.

`DNS` - Remplacer le paramètre `ClientDNS` du serveur pour tous les clients. Spécifiez une liste d’IP séparées par des virgules.  
Mettez `no` ou `none` pour omettre le DNS de cette configuration client WireGuard.

Les fichiers de configuration client contiennent le champ `PrivateKey`.  
Si vous le trouvez inacceptable, vous pouvez le retirer du fichier après avoir exporté  
la configuration (ou le code QR) vers le client.

### Autres OS que Linux

WG Commander est conçu pour fonctionner sous Linux, car il utilise procfs, systemd, iptables, sysctl.  
Cependant, il est écrit en Go simple, donc il devrait fonctionner sur tout OS supporté par Go.

- Vous devrez compiler le binaire vous-même.  
- Définissez la variable d’environnement `WG_CMD_NO_DEPS` à 1 pour désactiver les vérifications spécifiques à Linux au démarrage.  
- Modifiez 0001-server.toml et définissez vos commandes OS dans les champs PostUp4/PostUp6/PostDown4/PostDown6.  
- Vous devrez recharger la configuration WireGuard : manuellement quand vous changez quelque chose  
ou surveiller les fichiers /etc/wireguard/wg*.conf pour les changements et recharger WireGuard automatiquement.

Les PR sont les bienvenues pour ajouter le support d’autres OS.

### Exécution dans Docker

Bien que ce soit possible, il n’est pas recommandé d’exécuter WG Commander dans Docker.

L’Assistant de configuration ne fonctionnera pas correctement, car il doit créer des unités systemd et modifier sysctl.

### Désinstallation

Pour désinstaller WG Commander, il suffit de supprimer le binaire de /usr/local/bin/wg-cmd.  
Vous pouvez aussi supprimer les répertoires /etc/wireguard/wgc-* et ~/.config/wg-cmd

Si vous avez créé des unités systemd, vous devrez les supprimer manuellement.

Voici un exemple de suppression de l’interface gérée par WG Commander wg7  
(changez-la pour l’interface que vous souhaitez supprimer) :



```sh
systemctl stop wgc-wg7.{path,service}
systemctl disable wgc-wg7.{path,service}
rm /etc/systemd/system/wgc-wg7.{path,service}
systemctl stop wg-quick@wg7.service
systemctl disable wg-quick@wg7.service
rm /etc/wireguard/wg7.conf
rm -Rf /etc/wireguard/wgc-wg7
```

# Testé
WG Commander devrait bien fonctionner sur toute distribution Linux basée sur systemd
avec WireGuard, iptables, sysctl, procfs disponibles.

Il a été testé sur :
- Ubuntu 24.04 (v0.1.7 testé le 9 avril 2026)
- Ubuntu 20.04
- Ubuntu 22.04
- Rocky Linux 9
- Debian 11
- Debian 12

# Contribution

Les contributions sont les bienvenues. Veuillez consulter [CONTRIBUTING.md](https://raw.githubusercontent.com/AndrianBdn/wg-cmd/main/CONTRIBUTING.md) pour les directives, y compris notre politique de divulgation liée à l'IA.

# Remarques
Il n’y a aucun but commercial derrière WG Commander.
Le projet est sous licence
[MIT License](https://github.com/andrianbdn/wg-cmd/blob/master/LICENSE).

Ce projet n’est PAS lié au créateur de WireGuard®.
Le projet WG Commander n’est PAS approuvé, sponsorisé, ni affilié
à WireGuard® ou à la communauté WireGuard®.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---