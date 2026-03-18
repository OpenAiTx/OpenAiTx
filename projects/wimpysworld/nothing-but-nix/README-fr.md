
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Rien que Nix

**Transformez votre runner GitHub Actions en une centrale [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ en éliminant impitoyablement les logiciels préinstallés inutiles.**

Les runners GitHub Actions offrent peu d’espace disque pour Nix - à peine ~20GB.
*Rien que Nix* **purge sans pitié** les logiciels superflus, vous offrant **65GB à 130GB** pour votre magasin Nix ! 💪

## Utilisation 🔧

Ajoutez cette action **avant** d’installer Nix dans votre workflow :

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### Exigences ️✔️

- Prend uniquement en charge les runners GitHub Actions officiels **Ubuntu**
- Doit être exécuté **avant** l'installation de Nix
- **Runners macOS/Darwin** : Cette action sera ignorée proprement avec un avertissement si elle est lancée sur macOS. Les runners macOS fournissent déjà suffisamment d'espace pour Nix et n'ont pas besoin de cette action
- **Runners Windows** : Cette action sera ignorée proprement avec un avertissement si elle est lancée sur Windows. Les runners Windows ont des dispositions et des contraintes de système de fichiers différentes

## Le problème : Faire de la place pour que Nix s’épanouisse 🌱

Les runners GitHub Actions standards sont remplis de *"bloatware"* que vous n’utiliserez jamais dans un workflow Nix :

- 🌍 Navigateurs web. Beaucoup d’entre eux. Il les faut tous !
- 🐳 Images Docker consommant des gigaoctets d’espace disque précieux
- 💻 Environnements d’exécution inutiles (.NET, Ruby, PHP, Java...)
- 📦 Gestionnaires de paquets prenant la poussière numérique
- 📚 Documentation que personne ne lira jamais

Cette surcharge ne laisse qu’environ 20 Go pour votre store Nix — à peine assez pour des builds Nix sérieux ! 😞

## La solution : Que Nix et rien d’autre ️❄️

**Que Nix et rien d’autre** adopte une approche radicale sur les runners GitHub Actions et récupère sans pitié l’espace disque avec une attaque en deux phases :

1. **Coup initial :** Crée instantanément un grand volume `/nix` (~65 Go) en récupérant l’espace libre de `/mnt`
2. **Nettoyage en arrière-plan :** Pendant que votre workflow continue, nous éliminons sans relâche les logiciels inutiles pour étendre votre volume `/nix` jusqu’à ~130 Go
   - Navigateurs web ? Non ⛔
   - Images Docker ? Supprimées 🗑️
   - Environnements d’exécution ? Anéantis 💥
   - Gestionnaires de paquets ? Annihilés 💣
   - Documentation ? Volatilisée ️👻

La purge du système de fichiers est alimentée par `rmz` (du projet [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) — une alternative haute performance à `rm` qui accélère la récupération d’espace ! ⚡
   - Surpasse le `rm` standard d’un ordre de grandeur
   - Traite les suppressions en parallèle pour une efficacité maximale
   - **Récupère l’espace disque en quelques secondes au lieu de minutes !** ️⏱️

Le résultat final ? Un runner GitHub Actions avec **65 Go à 130 Go** d’espace prêt pour Nix ! 😁

### Extension dynamique du volume

Contrairement aux autres solutions, **Nothing but Nix** fait évoluer dynamiquement votre volume `/nix` :

1. **Création initiale du volume (1-10 secondes) :** (*selon le protocole Hatchet*)
   - Crée un périphérique loop à partir de l’espace libre sur `/mnt`
   - Met en place un système de fichiers BTRFS en configuration RAID0
   - Monte avec compression et optimisation des performances
   - Fournit immédiatement un `/nix` de 65 Go, même avant le début de la purge

2. **Extension en arrière-plan (30-180 secondes) :** (*selon le protocole Hatchet*)
   - Exécute les opérations de purge
   - Surveille l’espace nouvellement libéré à mesure que l’encombrement est éliminé
   - Ajoute dynamiquement un disque d’extension au volume `/nix`
   - Rééquilibre le système de fichiers pour incorporer le nouvel espace

Le volume `/nix` **grandit automatiquement pendant l’exécution du flux de travail** 🎩🪄

### Choisissez votre arme : le protocole Hatchet 🪓

Contrôlez le niveau d’anéantissement 💥 avec l’entrée `hatchet-protocol` :

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### Comparaison des Protocoles ⚖️

| Protocole | `/nix` | Description                                        | Purger apt  | Purger docker | Purger snap | Systèmes de fichiers purgés   |
|-----------|--------|----------------------------------------------------|-------------|---------------|-------------|-------------------------------|
| Holster   | ~65Go  | Garder la hache dans son fourreau, utiliser `/mnt` | Non         | Non           | Non         | Aucun                         |
| Carve     | ~85Go  | Fusionner l’espace libre de `/` et `/mnt`          | Non         | Non           | Non         | Aucun                         |
| Cleave    | ~115Go | Couper puissamment les gros paquets                | Minimal     | Oui           | Oui         | `/opt` et `/usr/local`        |
| Rampage   | ~130Go | Élimination brutale et implacable de tout surplus  | Agressif    | Oui           | Oui         | Mouahahaha ! 🔥🌎             |

Choisissez judicieusement :
- **Holster** si vous avez besoin que tous les outils du runner restent fonctionnels
- **Carve** pour préserver les outils du runner mais libérer tout l’espace pour Nix
- **Cleave** (*par défaut*) pour un bon équilibre entre espace et fonctionnalité
- **Rampage** si vous voulez un maximum d’espace Nix sans souci de casse `#nix-is-life`

### Soyez témoin du carnage 🩸

Par défaut, le processus de purge s’exécute silencieusement en arrière-plan pendant que votre workflow continue. Mais si vous souhaitez assister au massacre en temps réel :

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Personnalisez les zones sûres 🛡️

Contrôlez l’espace à préserver de l’appropriation du Nix store grâce à des tailles de zones sûres personnalisées :

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

Ces refuges sûrs définissent combien d’espace (en Mo) sera gracieusement épargné lors de la récupération d’espace :
- Le `root-safe-haven` par défaut est de 2048 Mo (2 Go)
- Le `mnt-safe-haven` par défaut est de 1024 Mo (1 Go)

Augmentez ces valeurs si vous avez besoin de plus d’espace libre sur vos systèmes de fichiers, ou diminuez-les pour ne faire preuve d’aucune pitié ! 😈

### Accorder la propriété utilisateur de /nix (Édit de permission Nix) 🧑‍⚖️

Certains installateurs ou configurations Nix attendent que le répertoire `/nix` soit accessible en écriture par l’utilisateur courant. Par défaut, `/nix` appartient à root. Si vous avez besoin de la propriété utilisateur (par exemple, pour certains scripts d’installation Nix qui n’utilisent pas `sudo` pour toutes les opérations dans `/nix`), vous pouvez activer le `nix-permission-edict` :

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

Lorsque `nix-permission-edict` est défini sur `true`, l’action exécutera `sudo chown -R "$(id --user)":"$(id --group)" /nix` après le montage de `/nix`.

### Configurer Nix pour utiliser /nix/build

Cette action crée `/nix/build` pour que les constructions de dérivations Nix utilisent l’espace récupéré. Ajoutez `build-dir` à votre configuration Nix :

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

Ou avec DeterminateSystems :

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```

Cela indique à Nix d'effectuer les compilations sur le grand volume BTRFS plutôt que sur le répertoire temporaire par défaut du système.

## Dépannage 🔍

### "Plus d'espace disponible sur le périphérique" lors de grandes compilations

Si votre compilation manque d'espace malgré l'utilisation exclusive de Nix, c'est probablement parce que la purge en arrière-plan n'a pas terminé avant que votre compilation consomme l'espace disponible. Cela affecte souvent :

- Les tests VM NixOS qui assemblent de grandes images disque
- Les compilations avec de nombreuses dépendances non mises en cache
- Les chaînes d'outils Rust et autres grandes compilations

**Solution :** Utilisez `witness-carnage: true` pour forcer une purge synchrone. Cela garantit que tout l'espace est récupéré *avant* le démarrage de votre compilation :

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```
Cela ajoute 30 à 180 secondes à la configuration de votre workflow, mais garantit que l'espace maximal est disponible lorsque votre build commence.

Allez maintenant créer quelque chose d'incroyable avec tout cet espace glorieux du Nix store ! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---