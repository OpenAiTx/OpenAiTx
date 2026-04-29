# Tailscale avec Amnezia-WG 2.0 (v1.88.2+)

[![GitHub Release](https://img.shields.io/github/v/release/LiuTangLei/tailscale)](https://github.com/LiuTangLei/tailscale/releases/latest)
[![Platform Support](https://img.shields.io/badge/platform-Linux%20|%20macOS%20|%20Windows%20|%20OpenWrt%20|%20Android-blue)](https://github.com/LiuTangLei/tailscale/releases/latest)
[![License](https://img.shields.io/badge/license-BSD--3--Clause-green)](LICENSE)

Client Tailscale amélioré avec l'obfuscation Amnezia-WG 2.0 : trafic factice, signatures de protocole, et déguisement de poignée de main/en-tête pour résister au DPI et au blocage. Jusqu'à ce que vous activiez les paramètres AWG, il fonctionne comme un Tailscale standard.

Langues : [English](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/README.md) | [中文](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-zh.md) | [فارسی](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-fa.md) | [Русский](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-ru.md)

Pour la documentation de AWG v1.5, voir [doc/README-awg-v1.5.md](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-awg-v1.5.md).

## Installation

| Plateforme | Commande / Action |
| --- | --- |
| Linux | `curl -fsSL https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-linux.sh \| bash` |
| macOS* | `curl -fsSL https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-macos.sh \| bash` |
| Windows (PowerShell Admin) | `iwr -useb https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-windows.ps1 \| iex` |
| OpenWrt | Voir [Installation OpenWrt](#openwrt-installation) |
| Android | Télécharger l’APK depuis [releases](https://github.com/LiuTangLei/tailscale-android/releases) |

- macOS : l’installateur utilise uniquement `tailscaled` en CLI. Si l’application officielle Tailscale.app est détectée, il vous sera demandé de la supprimer pour éviter les conflits.
- Android supporte actuellement uniquement la synchronisation de configuration AWG. Utilisez le bouton Sync intégré.

![Exemple de synchronisation AWG sur Android](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/sync1.jpg)

## Docker Compose

Le dépôt inclut un fichier `docker-compose.yml` pour exécuter `tailscaled` avec le support AWG.

- L’état est stocké dans `./tailscale-state` à côté du fichier compose, ainsi l’état du nœud et les paramètres AWG survivent aux redémarrages du conteneur et de l’hôte.
- Si vous effectuez une mise à jour depuis l’ancien montage bind `/var/lib/tailscale:/var/lib/tailscale`, copiez d’abord l’état existant :

```bash
docker compose down
cp -a /var/lib/tailscale ./tailscale-state
# update docker-compose.yml
docker compose up -d
```

Flux de base :

1. Démarrez le service : `docker compose up -d`
2. Authentifiez-vous dans le conteneur : `docker compose exec tailscaled tailscale up`
3. Exécutez les commandes AWG de la même manière, par exemple : `docker compose exec tailscaled tailscale awg sync`

Si vous utilisez Headscale, ajoutez `--login-server https://votre-domaine-headscale` à `tailscale up`.

Alias d’hôte optionnel :

```bash
alias tailscale='docker exec -it tailscaled tailscale'
```

Cet alias ne s'applique qu'au shell actuel. Pour le conserver après un redémarrage ou une nouvelle session de terminal, ajoutez-le à `~/.bashrc` ou `~/.zshrc` et rechargez votre shell.

## Installation OpenWrt

Commande par défaut :

```bash
wget -O /usr/bin/install.sh https://raw.githubusercontent.com/LiuTangLei/openwrt-tailscale-awg/main/install_en.sh && chmod +x /usr/bin/install.sh && /usr/bin/install.sh
```

Commande miroir pour les régions avec un accès GitHub restreint :

```bash
wget -O /usr/bin/install.sh https://ghfast.top/https://raw.githubusercontent.com/LiuTangLei/openwrt-tailscale-awg/main/install.sh && chmod +x /usr/bin/install.sh && /usr/bin/install.sh
```

Ce script est dérivé de [GuNanOvO/openwrt-tailscale](https://github.com/GuNanOvO/openwrt-tailscale).

## Miroirs

Si GitHub est lent ou bloqué, vous pouvez héberger vous-même un miroir de préfixe tel que `https://your-mirror-site.com` :

```bash
# Linux
curl -fsSL https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-linux.sh | bash -s -- --mirror https://your-mirror-site.com

# macOS
curl -fsSL https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-macos.sh | bash -s -- --mirror https://your-mirror-site.com
```

```powershell
# Windows
$scriptContent = (iwr -useb https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-windows.ps1).Content; $scriptBlock = [scriptblock]::Create($scriptContent); & $scriptBlock -MirrorPrefix 'https://your-mirror-site.com/'
```

Si PowerShell bloque l'exécution, utilisez `Set-ExecutionPolicy RemoteSigned` ou `Bypass -Scope Process`.

## Démarrage rapide

Astuce : `tailscale amnezia-wg` est équivalent à `tailscale awg`.

1. Connectez-vous :

```bash
# Official control server
tailscale up

# Headscale
tailscale up --login-server https://your-headscale-domain
```

2. Configurer l'AWG :

```bash
tailscale awg set
```

Appuyez sur Entrée à l’invite de génération automatique pour générer des valeurs recommandées pour tout sauf `i1`-`i5`.

3. Sur d’autres appareils, synchronisez la même configuration AWG depuis ce nœud déjà configuré :

- Bureau : exécutez `tailscale awg sync` sur l’autre appareil
- Android : appuyez sur Synchroniser dans l’application sur l’autre appareil

4. Vérifiez ou réinitialisez si nécessaire :

```bash
tailscale awg get
tailscale awg reset
```

## Préréglages de configuration

| Objectif | Exemple | Compatibilité |
| --- | --- | --- |
| Trafic indésirable basique | `tailscale awg set '{"jc":4,"jmin":64,"jmax":256}'` | Fonctionne avec les pairs Tailscale standards |
| Trafic indésirable + signatures | `tailscale awg set '{"jc":2,"jmin":64,"jmax":128,"i1":"<b 0x40><r 12>"}'` | Fonctionne avec les pairs Tailscale standards |
| Masquage de poignée de main | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0}'` | Tous les nœuds AWG doivent utiliser le même `s1`-`s4` |
| Masquage complet | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0,"h1":{"min":100000,"max":200000},"h2":{"min":300000,"max":350000},"h3":{"min":400000,"max":450000},"h4":{"min":500000,"max":550000}}'` | Tous les nœuds AWG doivent utiliser les mêmes `s1`-`s4` et `h1`-`h4` |
| Masquage complet + signatures | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0,"h1":{"min":100000,"max":200000},"h2":{"min":300000,"max":350000},"h3":{"min":400000,"max":450000},"h4":{"min":500000,"max":550000},"i1":"<b 0xc0><r 32><c><t>"}'` | `i1`-`i5` peuvent différer par nœud ; `s1`-`s4` et `h1`-`h4` doivent correspondre |

## Référence des paramètres

- `jc` avec `jmin` et `jmax` : nombre de paquets indésirables et plage de taille.
- `i1`-`i5` : chaîne CPS (Signature de Protocole Personnalisé) optionnelle pour paquets imitant des protocoles personnalisés.
- `s1`-`s4` : champs de bourrage ou préfixe de poignée de main ; tous les nœuds AWG doivent correspondre.
- `h1`-`h4` : plages de champs d’en-tête sous la forme `{"min": bas, "max": haut}` ; il faut définir les quatre ou aucun. Les plages ne doivent pas se chevaucher, et tous les nœuds AWG doivent correspondre.

Un grand nombre de paquets indésirables ou de longues chaînes de signatures augmentent la latence et la consommation de bande passante.

## Support des plateformes

| Plateforme | Arch | Statut |
| --- | --- | --- |
| Linux | x86_64, ARM64 | ✅ Complet |
| macOS | Intel, Apple Silicon | ✅ Complet |
| Windows | x86_64, ARM64 | ✅ Installateur |
| OpenWrt | Divers | ✅ Script |
| Android | ARM64, ARM | ✅ APK (AWG synchronisation uniquement) |

## Avancé : Signatures de protocoles CPS

CPS signifie Signature de Protocole Personnalisé. Il vous permet de composer des paquets d’obfuscation personnalisés qui peuvent imiter des en-têtes de protocoles arbitraires ; il n’est pas limité à un protocole spécifique.

Format CPS :

```text
i{n} = <tag1><tag2>...<tagN>
```

Tags :

- `<b 0xHEX>` : octets statiques
- `<r N>` : octets aléatoires sécurisés
- `<c>` : compteur
- `<t>` : horodatage

Exemple :

```text
i1 = <b 0xf6ab3267fa><c><b 0xf6ab><t><r 10>
```

Si `i1` n'est pas défini, `i2`-`i5` sont ignorés.

## Dépannage

Vérifiez l'installation :

```bash
tailscale version
tailscale awg get
```

Si la connectivité est interrompue, réinitialisez sur WireGuard standard et commencez par un préréglage simple :

```bash
tailscale awg reset
tailscale awg set '{"jc":2,"jmin":64,"jmax":128}'
sudo journalctl -u tailscaled -f
```

Sous Windows PowerShell, privilégiez la configuration interactive pour éviter les problèmes d’échappement JSON :

```powershell
tailscale awg set
```

## Liens & Support

- Versions : <https://github.com/LiuTangLei/tailscale/releases>
- APK Android : <https://github.com/LiuTangLei/tailscale-android/releases>
- Problèmes d'installation : <https://github.com/LiuTangLei/tailscale-awg-installer/issues>
- Docs Amnezia-WG : <https://docs.amnezia.org/documentation/instructions/new-amneziawg-selfhosted/#how-to-extract-a-protocol-signature-for-amneziawg-manually>

## Licence

Licence BSD 3 clauses, identique à celle de Tailscale en amont.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-29

---