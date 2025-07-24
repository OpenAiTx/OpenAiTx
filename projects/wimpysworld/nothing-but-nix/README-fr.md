
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

# Nothing but Nix

**Transformez votre runner GitHub Actions en une centrale [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ en supprimant sans pitié les logiciels préinstallés superflus.**

Les runners GitHub Actions offrent très peu d’espace disque pour Nix – à peine ~20 Go.
*Nothing but Nix* **purge radicalement** les logiciels inutiles, vous offrant **65 Go à 130 Go** pour votre store Nix ! 💪

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
- Doit s'exécuter **avant** l'installation de Nix

## Le problème : faire de la place pour que Nix prospère 🌱

Les runners GitHub Actions standards sont remplis de *"bloatware"* que vous n'utiliserez jamais dans un workflow Nix :

- 🌍 Navigateurs web. Plein. Ils y sont tous !
- 🐳 Images Docker consommant des gigaoctets d'espace disque précieux
- 💻 Runtimes de langages inutiles (.NET, Ruby, PHP, Java...)
- 📦 Gestionnaires de paquets prenant la poussière numérique
- 📚 Documentation que personne ne lira jamais

Cette surcharge ne laisse qu'environ ~20 Go pour votre magasin Nix - à peine assez pour des builds Nix sérieux ! 😞

## La solution : Rien que Nix ️❄️

**Rien que Nix** adopte une approche radicale sur les runners GitHub Actions et récupère sans pitié l'espace disque grâce à une attaque en deux phases :

1. **Coupe initiale :** Crée instantanément un grand volume `/nix` (~65 Go) en réclamant l'espace libre de `/mnt`
2. **Nettoyage en arrière-plan :** Pendant que votre workflow continue, nous éliminons impitoyablement les logiciels inutiles pour étendre votre volume `/nix` jusqu'à ~130 Go
   - Navigateurs web ? Non ⛔
   - Images Docker ? Supprimées 🗑️
   - Runtimes de langages ? Anéantis 💥
   - Gestionnaires de paquets ? Éradiqués 💣
   - Documentation ? Volatilisée ️👻

Le nettoyage du système de fichiers est propulsé par `rmz` (du projet [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - une alternative haute performance à `rm` qui accélère la libération d'espace ! ⚡
   - Surpasse le `rm` standard d'un ordre de grandeur
   - Supprime en parallèle pour une efficacité maximale
   - **Récupère l'espace disque en quelques secondes au lieu de minutes !** ️⏱️

Le résultat final ? Un runner GitHub Actions avec **65 Go à 130 Go** d'espace prêt pour Nix ! 😁

### Croissance dynamique du volume

Contrairement à d'autres solutions, **Rien que Nix** fait croître dynamiquement votre volume `/nix` :

1. **Création initiale du volume (1-10 secondes) :** (*selon le protocole Hatchet*)
   - Crée un périphérique de boucle à partir de l'espace libre de `/mnt`
   - Met en place un système de fichiers BTRFS en configuration RAID0
   - Monte avec compression et optimisation des performances
   - Fournit un `/nix` de 65 Go immédiatement, même avant le début du nettoyage

2. **Expansion en arrière-plan (30-180 secondes) :** (*selon le protocole Hatchet*)
   - Lance les opérations de purge
   - Surveille l'espace libéré au fur et à mesure que la surcharge est éliminée
   - Ajoute dynamiquement un disque d'expansion au volume `/nix`
   - Rééquilibre le système de fichiers pour intégrer le nouvel espace

Le volume `/nix` **s'agrandit automatiquement pendant l'exécution du workflow** 🎩🪄

### Choisissez votre arme : Le protocole Hatchet 🪓

Contrôlez le niveau d'annihilation 💥 avec l'entrée `hatchet-protocol` :

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

Lorsque `nix-permission-edict` est défini sur `true`, l’action exécutera `sudo chown -R "$(id --user)":"$(id --group)" /nix` après avoir monté `/nix`.

Allez maintenant construire quelque chose d’incroyable avec tout cet espace glorieux du store Nix ! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---