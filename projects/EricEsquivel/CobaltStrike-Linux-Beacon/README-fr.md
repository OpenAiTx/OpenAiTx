# Cobalt Strike Linux Beacon

Un Beacon Linux personnalisé proof-of-concept écrit en C qui communique avec le serveur d'équipe Cobalt Strike en utilisant le protocole HTTP/S.

L'objectif de ce projet n'est pas d'être un implant complet, ni d'être limité à Linux uniquement. Il s'agit de démontrer qu'il est possible de créer des implants personnalisés pour Cobalt Strike sur n'importe quelle plateforme. La seule exigence est de communiquer correctement avec le serveur d'équipe.

Avec des implants personnalisés, vous pouvez définir un comportement personnalisé, ajouter de nouvelles fonctionnalités, prendre en charge différentes plateformes et types de fichiers, appliquer de l'obfuscation à la compilation, et plus encore. Les possibilités sont infinies.

Espérons qu'un jour Cobalt Strike supportera officiellement le développement de Beacons personnalisés en ajoutant plus de documentation et des fonctionnalités facilitant la vie.


## Fonctionnalités
- Support du listener HTTP/S (profil C2 par défaut)
- Contient quelques commandes intégrées : `sleep`, `cd`, `pwd`, `shell`, `ls`, `exit`, `upload`, `download`
- Exécution Linux BOF utilisant ELFLoader de TrustedSec. Supporte les BOFs TrustedSec & Outflank
- Proxy SOCKS

## Démo
Génération de payloads avec le script Aggressor
![Génération de payloads Linux Beacon](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/generate_payloads.gif)

Exécution de commandes & BOFs dans le Linux Beacon
![Démo des commandes Linux Beacon](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/demo/commands.gif)

## Installation
Vous pouvez consulter les étapes d'installation dans le fichier [SETUP](https://raw.githubusercontent.com/EricEsquivel/CobaltStrike-Linux-Beacon/main/SETUP.md).

## Remerciements spéciaux
Merci à [Kyle Avery](https://x.com/kyleavery) pour son aide à l'intégration de l'exécution BOF et aux tests de l'implant.

## Objectifs futurs
* Ajouter le support des profils C2 personnalisés
* Ajouter un listener TCP + fonctionnalité de connexion
* Continuer à corriger les bugs

## Ressources
- Cobalt Strike (wow !)
- [ELFLoader & BOFs de TrustedSec](https://github.com/trustedsec/ELFLoader)
- [BOFs d'Outflank](https://github.com/outflanknl/nix_bof_template)
- [PaloAltoNetworks Unit42](https://unit42.paloaltonetworks.com/cobalt-strike-metadata-encryption-decryption/)
- [SANS ISC](https://isc.sans.edu/diary/27968)
- [cs-decrypt-metadata-py](https://blog.didierstevens.com/2021/10/22/new-tool-cs-decrypt-metadata-py/)
- [SentinelOne CobaltStrikeParser](https://github.com/Sentinel-One/CobaltStrikeParser)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-27

---