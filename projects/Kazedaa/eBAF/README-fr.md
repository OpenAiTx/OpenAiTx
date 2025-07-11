# eBAF - Pare-feu publicitaire basé sur eBPF
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - Bannière du pare-feu publicitaire eBPF" width="600"/>
</p>

## "Vous ne téléchargeriez pas une pub"
### Mais vous en bloqueriez une !

Spotify a bâti un empire sur une formule simple : monétiser votre attention, sous-payer les artistes, et vous revendre votre propre temps comme une fonctionnalité premium.
Dans leur monde, votre expérience d’écoute ne vous appartient pas. C’est un marché soigneusement organisé — vos oreilles sont le produit, votre patience est la monnaie.

Ils aiment appeler cela une offre "gratuite".
Mais soyons honnêtes : ce n’est pas gratuit si vous payez avec votre temps.

Pendant ce temps, les artistes que vous aimez — ceux dont le travail fait vivre la plateforme — gagnent souvent à peine quelques fractions de centime par écoute. Spotify engrange des profits confortables, les annonceurs obtiennent leur visibilité, et les créateurs ? Ils récupèrent des miettes.

Il ne s’agit pas seulement de passer quelques publicités agaçantes.
Il s’agit de refuser de participer à un système qui profite de l’exploitation, de la distraction, et de la marchandisation de votre attention.

#### Qu’est-ce que c’est ?
Un petit acte élégant de résistance numérique : un bloqueur de publicités propre et open-source pour Spotify qui arrête le bruit — littéralement.

Pas de mods douteux, pas de clients crackés, pas de malwares déguisés en liberté. Un seul objectif : laisser la musique jouer sans être pris en otage par les publicités.

Spotify n’est pas gratuit — vous payez avec votre patience.

Ils vous bombardent avec les mêmes publicités agaçantes, encore et encore, jusqu’à ce que vous cédiez et vous abonniez. Pas parce que vous aimez Premium. Mais parce que vous avez été usé. Ce n’est pas du freemium — c’est une guerre psychologique avec une playlist.

Pendant ce temps, les artistes ? Toujours sous-payés.
Les pubs ? Plus fortes. Plus fréquentes. Parfois littéralement plus fortes.
Vous ? Vous essayez juste de profiter.

Ils profitent de votre patience et du sous-paiement des créateurs, tout en prétendant que c’est la seule voie durable. Spoiler : ce n’est pas le cas. Ils avaient le choix — mais ils ont préféré les marges bénéficiaires aux personnes.

Spotify veut vous faire croire que c’est le prix de l’accès.
Nous pensons que c’est un mensonge.

Nous ne sommes pas des pirates. Nous ne sommes pas des criminels. Nous sommes juste des gens qui pensent qu’il est normal de fixer une limite.

Ce projet ne consiste pas à sauter quelques pubs. Il s’agit de rejeter un système qui dit que votre silence peut être vendu, que votre expérience peut être interrompue, et que votre valeur ne commence qu’une fois votre portefeuille ouvert.

Bloquer les pubs n’est pas du vol.<br>
Voler votre temps, si.<br>
Nous ne sommes pas là pour pirater. Nous sommes là pour refuser.<br>
<br>
**Vous ne téléchargeriez pas une pub. Mais vous en bloqueriez une.**

## Comment fonctionne eBAF ?

eBAF (eBPF Ad Firewall) exploite la puissance de eBPF (Extended Berkeley Packet Filter) pour bloquer les publicités indésirables au niveau du noyau. Voici un aperçu général de son fonctionnement :

## Comment fonctionne eBAF ?

eBAF (eBPF Ad Firewall) utilise eBPF (Extended Berkeley Packet Filter) pour bloquer efficacement les publicités au niveau du noyau. Voici un aperçu simplifié :

1. **Filtrage des paquets** :
   - Inspecte les paquets réseau entrants et bloque ceux correspondant à une liste noire d'adresses IP en utilisant XDP (eXpress Data Path).

2. **Mises à jour dynamiques** :
   - Résout les noms de domaine en adresses IP et met à jour dynamiquement la liste noire afin de rester efficace face à l’évolution des serveurs publicitaires.

3. **Tableau de bord web** :
   - Fournit des statistiques en temps réel et un suivi via une interface conviviale.

4. **Haute performance** :
   - Fonctionne directement au niveau de l’interface réseau, contournant la pile réseau du noyau pour un traitement plus rapide et une utilisation minimale des ressources.

eBAF allie efficacité, transparence et simplicité d’utilisation pour offrir une solution de blocage des publicités puissante.
## Installation simple (Recommandée)
Assurez-vous d’avoir git et curl installés
```bash
git --version
curl --version
```
### Installation
#### Activer l’intégration Spotify (Recommandé)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Désactiver explicitement
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### Désinstallation
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Installation de développement
Exécutez les commandes suivantes pour installer les dépendances requises :
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### Corriger l’erreur asm/types.h lors de l’exécution du code eBPF
Vérifiez le lien actuel
`ls -l /usr/include/asm`
Trouvez le lien correct
`find /usr/include -name "types.h" | grep asm`
Corrigez le lien symbolique
```bash
sudo rm /usr/include/asm
sudo ln -s <lien_courant> /usr/include/asm
```

### Compilation du projet

Pour compiler l’Adblocker eBPF, suivez ces étapes :

1. Clonez le dépôt :
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Construire le projet :
   ```bash
   make
   ```

3. (Optionnel) Installer sur l'ensemble du système :
   ```bash
   sudo make install
   ```

4. Autres options d'installation (aide)
    ```bash
    make help
    ````

5. Désinstaller
    ```bash
    make uninstall
    ````
## Utilisation

### Exécution de l’Adblocker
    Utilise spotify-stable.txt comme liste noire par défaut.
    Utilisation : ebaf [OPTIONS] [INTERFACE...]
    OPTIONS :
    -a, --all               Exécuter sur toutes les interfaces actives
    -d, --default           Exécuter uniquement sur l’interface par défaut (ayant accès à Internet)
    -i, --interface IFACE   Spécifier une interface à utiliser
    -D, --dash              Démarrer le tableau de bord web (http://localhost:8080)
    -q, --quiet             Supprimer la sortie (mode silencieux)
    -h, --help              Afficher ce message d’aide


### Configuration de la liste noire
Modifiez les listes pour ajouter ou supprimer des domaines. Chaque domaine doit être sur une ligne séparée. Les commentaires commencent par `#`.

## Remerciements

Un grand merci à ❤️ <br>
1. [Spotify-AdsList d’Isaaker](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [spotify-adblock d’AnanthVivekanand](https://github.com/AnanthVivekanand/spotify-adblock)

pour avoir fourni une liste de blocage Spotify
## ⭐️ Soutenez le projet

Si vous trouvez eBAF utile, veuillez envisager de donner une étoile au dépôt sur GitHub ! Votre soutien aide à accroître la visibilité et encourage le développement continu.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---