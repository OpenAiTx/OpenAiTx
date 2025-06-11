# 🍡 scoop-proxy-cn

Bibliothèque miroir proxy des buckets [Scoop](https://scoop.sh) adaptée aux utilisateurs de Chine continentale. Synchronise les mises à jour de plusieurs dépôts `bucket` open source. Parmi ceux-ci :

- Branche `sync` (par défaut) : synchronise les applications de plusieurs dépôts, sans modification de proxy ghproxy. **Adaptée à l'utilisation avec la version modifiée de Scoop domestique sur gitee.**
- Branche `main` : modifie l'adresse de téléchargement des applications depuis les `github release` pour utiliser une adresse proxy basée sur `https://ghfast.top`. **Cette adresse proxy n'étant pas stable et sujette à des changements fréquents en cas de défaillance.**

## Usage

Ajoutez le dépôt d'applications `spc`. À utiliser conjointement avec la [bibliothèque d'optimisation miroir Scoop domestique](https://gitee.com/scoop-installer/scoop) :

```bash
# Ajouter le bucket, récupère par défaut la branche sync
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# installer des applications
scoop install spc/<app_name>
```

Si vous souhaitez uniquement utiliser la version officielle de Scoop, procédez comme suit pour changer la branche de souscription en `main` :

```bash
# Accéder au répertoire spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# Si la variable d'environnement SCOOP est définie, exécutez :
cd "$env:SCOOP\buckets\spc"

# Basculer sur la branche main
git fetch --all
git checkout -b main origin/main
```

## Référence d'installation et configuration de Scoop

### Méthode 1 : Installation basée sur un miroir domestique personnalisé (recommandée)

Comme le code source de Scoop et les applications buckets sont majoritairement maintenus sous forme de git sur GitHub, les difficultés d'accès à GitHub en Chine rendent l'installation, la mise à jour et le téléchargement d'applications très pénibles.

Voici la méthode d'installation pour la [bibliothèque d'optimisation miroir Scoop domestique](https://gitee.com/scoop-installer/scoop).

```bash
# Changer la politique d'exécution des scripts, acceptation automatique par défaut
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Méthode 1 : exécuter la commande d'installation (installée par défaut dans le dossier utilisateur, pour changer, voir "répertoire d'installation personnalisé" ci-dessous)
iwr -useb scoop.201704.xyz | iex


## Méthode 2 : répertoire d'installation personnalisé (modifiez le chemin selon l'emplacement souhaité)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# Si la source officielle est déjà installée, vous pouvez basculer en exécutant :
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# Ajouter le bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Mettre à jour les adresses des bibliothèques
scoop update
```

La version de Scoop installée avec cette méthode est modifiée pour supporter des proxys personnalisés et utilise par défaut `scoop.201704.xyz` comme proxy pour le téléchargement des applications.

```bash
# Ajouter un proxy
scoop config URL_PROXY "https://scoop.201704.xyz"

# Supprimer un proxy
scoop config rm URL_PROXY
```

### Méthode 2 : Installation basée sur le dépôt officiel via proxy

Ouvrez `PowerShell` et exécutez les commandes suivantes pour l'installation :

```bash
# installation
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# configuration
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# ajouter le bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# Accéder au répertoire spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# Basculer sur la branche main
git fetch --all && git checkout -b main origin/main

# afficher l'aide
scoop help

# installer 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### À propos de `scoop-search`

Puisque le dépôt `scoop-proxy-cn` synchronise plus de 14 000 applications, la commande officielle `scoop search` basée sur `PowerShell` est trop lente pour être pratique. Il est recommandé d'installer et d'utiliser l'outil `scoop-search` développé en `go`. Exemple :

```bash
scoop install scoop-search
# utiliser scoop-search
scoop-search act
```

## Problèmes fréquents

### Problème de téléchargement échoué lié à `aria2`

Quand `aria2` est installé, Scoop l'utilise pour accélérer les téléchargements en segments. Certains proxies ne supportent pas ou bloquent ces requêtes segmentées venant d'aria2. Dans ce cas, désactivez aria2 avec la commande :

```bash
scoop config aria2-enabled false
```

### Problème de `Hash Check Failed`

Certains apps configurent une adresse de téléchargement vers la dernière version publiée mais avec un hash fixe. Lors de nouvelles versions, cela génère une erreur `Hash Check Failed`. Vous pouvez ignorer le contrôle de hash avec l'option `-s`. Exemple :

```bash
scoop install scoop-search -s
```

### Mise à jour en cas d'échec du proxy

Si vous utilisez la version officielle de Scoop et que vous êtes sur la branche `main`, les téléchargements et mises à jour sont accélérés via un proxy. Si ce proxy devient obsolète, le dépôt ne peut plus se mettre à jour. Pour corriger cela, exécutez :

```bash
# Mettre d'abord à jour le dépôt scoop
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Méthode 1 : mettre à jour le dépôt spc bucket
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# Si vous avez modifié l'emplacement par défaut des buckets, exécutez :
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Méthode 2 : supprimer et réajouter le bucket spc
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Synchronisation des Buckets depuis

- [ScoopInstaller/PHP](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/PHP)
- [ScoopInstaller/Main](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Main)
- [ScoopInstaller/Extras](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Extras)
- [ScoopInstaller/Java](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Java)
- [ScoopInstaller/Versions](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Versions)
- [ScoopInstaller/Nirsoft](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Nirsoft)
- [ScoopInstaller/Nonportable](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Nonportable)
- [renxia/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/renxia/scoop-bucket)
- [scoopcn/scoopcn](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/scoopcn/scoopcn)
- [rasa/scoops](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/rasa/scoops)
- [amorphobia/siku](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/amorphobia/siku)
- [ACooper81/scoop-apps](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ACooper81/scoop-apps)
- [kkzzhizhou/scoop-zapps](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/kkzzhizhou/scoop-zapps)
- [Calinou/scoop-games](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/Calinou/scoop-games)
- [cderv/r-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/cderv/r-bucket)
- [chawyehsu/dorado](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/chawyehsu/dorado)
- [borger/scoop-galaxy-integrations](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/borger/scoop-galaxy-integrations)
- [ivaquero/scoopet](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ivaquero/scoopet)
- [KNOXDEV/wsl](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/KNOXDEV/wsl)
- [kodybrown/scoop-nirsoft](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/kodybrown/scoop-nirsoft)
- [kidonng/sushi](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/kidonng/sushi)
- [littleli/scoop-clojure](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/littleli/scoop-clojure)
- [niheaven/scoop-sysinternals](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/niheaven/scoop-sysinternals)
- [matthewjberger/scoop-nerd-fonts](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/matthewjberger/scoop-nerd-fonts)
- [TheCjw/scoop-retools](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/TheCjw/scoop-retools)
- [TheRandomLabs/Scoop-Bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/TheRandomLabs/Scoop-Bucket)
- [TheRandomLabs/scoop-nonportable](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/TheRandomLabs/scoop-nonportable)
- [TheRandomLabs/Scoop-Spotify](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/TheRandomLabs/Scoop-Spotify)
- [Paxxs/Cluttered-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/Paxxs/Cluttered-bucket)
- [zhoujin7/tomato](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/zhoujin7/tomato)
- [HCLonely/my-scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/HCLonely/my-scoop-bucket)
- [Weidows-projects/scoop-3rd](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/Weidows-projects/scoop-3rd)
- [hermanjustnu/scoop-emulators](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/hermanjustnu/scoop-emulators)
- [everyx/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/everyx/scoop-bucket)
- [borger/scoop-emulators](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/borger/scoop-emulators)
- [ZvonimirSun/scoop-iszy](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ZvonimirSun/scoop-iszy)
- [kiennq/scoop-misc](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/kiennq/scoop-misc)
- [wzv5/ScoopBucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/wzv5/ScoopBucket)
- [TheRandomLabs/Scoop-Python](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/TheRandomLabs/Scoop-Python)
- [naderi/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/naderi/scoop-bucket)
- [ViCrack/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ViCrack/scoop-bucket)
- [42wim/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/42wim/scoop-bucket)
- [akirco/aki-apps](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/akirco/aki-apps)
- [batkiz/backit](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/batkiz/backit)
- [iquiw/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/iquiw/scoop-bucket)
- [ygguorun/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ygguorun/scoop-bucket)
- [seumsc/scoop-seu](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/seumsc/scoop-seu)
- [cc713/ownscoop](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/cc713/ownscoop)
- [aoisummer/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/aoisummer/scoop-bucket)
- [yuusakuri/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/yuusakuri/scoop-bucket)
- [hu3rror/scoop-muggle](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/hu3rror/scoop-muggle)
- [starise/Scoop-Confetti](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/starise/Scoop-Confetti)
- [dodorz/scoop](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/dodorz/scoop)
(Partie 2 de 2)

- [SayCV/scoop-cvp](https://github.com/SayCV/scoop-cvp)
- [Qv2ray/mochi](https://github.com/Qv2ray/mochi)
- [Homeland-Community/scoop](https://github.com/Homeland-Community/scoop)
- [jingyu9575/scoop-jingyu9575](https://github.com/jingyu9575/scoop-jingyu9575)
- [couleur-tweak-tips/utils](https://github.com/couleur-tweak-tips/utils)
- [wangzq/scoop-bucket](https://github.com/wangzq/scoop-bucket)
- [jonz94/scoop-sarasa-nerd-fonts](https://github.com/jonz94/scoop-sarasa-nerd-fonts)
- [NyaMisty/scoop_bucket_misty](https://github.com/NyaMisty/scoop_bucket_misty)
- [jfut/scoop-jfut](https://github.com/jfut/scoop-jfut)
- [mogeko/scoop-sysinternals](https://github.com/mogeko/scoop-sysinternals)
- [ChungZH/peach](https://github.com/ChungZH/peach)
- [DoveBoy/Apps](https://github.com/DoveBoy/Apps)
- [Velgus/Scoop-Portapps](https://github.com/Velgus/Scoop-Portapps)
- [starise/Scoop-Gaming](https://github.com/starise/Scoop-Gaming)
- [mo-san/scoop-bucket](https://github.com/mo-san/scoop-bucket)
- [brian6932/dank-scoop](https://github.com/brian6932/dank-scoop)
- [AkariiinMKII/Scoop4kariiin](https://github.com/AkariiinMKII/Scoop4kariiin)
- [littleli/Scoop-littleli](https://github.com/littleli/Scoop-littleli)
- [ChinLong/scoop-customize](https://github.com/ChinLong/scoop-customize)
- [Darkatse/Scoop-KanColle](https://github.com/Darkatse/Scoop-KanColle)
- [aliesbelik/poldi](https://github.com/aliesbelik/poldi)
- [MCOfficer/scoop-bucket](https://github.com/MCOfficer/scoop-bucket)
- [KnotUntied/scoop-fonts](https://github.com/KnotUntied/scoop-fonts)
- [beerpiss/scoop-bucket](https://github.com/beerpiss/scoop-bucket)
- [HUMORCE/nuke](https://github.com/HUMORCE/nuke)
- [AkinoKaede/maple](https://github.com/AkinoKaede/maple)
- [hulucc/bucket](https://github.com/hulucc/bucket)
- [Deide/deide-bucket](https://github.com/Deide/deide-bucket)
- [echoiron/echo-scoop](https://github.com/echoiron/echo-scoop)
- [tetradice/scoop-iyokan-jp](https://github.com/tetradice/scoop-iyokan-jp)

## Déclaration

> [!ATTENTION]
> Les informations sur les applications contenues dans ce dépôt sont uniquement synchronisées à partir de dépôts tiers, sans vérification individuelle de leur disponibilité ou sécurité. Veuillez vérifier et identifier par vous-même avant l'installation. En cas de violation de droits, merci de créer un issue pour traitement.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---