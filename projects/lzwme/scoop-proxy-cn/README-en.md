# 🍡 scoop-proxy-cn

A proxy mirror repository for [Scoop](https://scoop.sh) buckets suitable for users in mainland China. It synchronizes updates from multiple open-source `bucket` repositories. Among them:

- `sync` branch (default): Synchronizes applications from multiple repositories, but does not modify for ghproxy proxy handling. **Suitable for scenarios using the Gitee domestic modified version of Scoop**
- `main` branch: Modifies the application download URLs from `github release` to proxy download URLs based on `https://ghfast.top`. **Due to frequent changes and instability of the proxy addresses caused by invalidation**

## Usage

Add the `spc` application repository. Suitable for use with the [Scoop domestic mirror optimization repository](https://gitee.com/scoop-installer/scoop):

```bash
# Add bucket, default pulls the sync branch
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# install apps
scoop install spc/<app_name>
```

If you only want to use the official Scoop version, you can do the following to switch the subscription branch to the `main` branch:

```bash
# Navigate to the spc directory
cd "$env:USERPROFILE\scoop\buckets\spc"
# If the SCOOP environment variable is set, run the following command
cd "$env:SCOOP\buckets\spc"

# Switch to the main branch
git fetch --all
git checkout -b main origin/main
```

## Scoop Installation and Configuration Reference

### Method 1: Installation Based on Domestic Customized Mirror (Recommended)

Since Scoop’s source code and buckets applications are mostly maintained on GitHub via git, the difficulty of accessing GitHub makes installation, updates, and application downloads a poor experience.

Below is the installation method for the [Scoop domestic mirror optimization repository](https://gitee.com/scoop-installer/scoop).

```bash
# Change script execution policy, default auto-accept
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Method 1: Execute the installation command (default installs in user directory, to change run the “Custom Install Directory” command below)
iwr -useb scoop.201704.xyz | iex


## Method 2: Custom install directory (remember to change the directory to a suitable location)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# If the official source is already installed, you can switch by running
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# Add spc bucket
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Pull the new repository address
scoop update
```

The Scoop installed by this method is customized and supports custom proxy acceleration sites, defaulting to using `scoop.201704.xyz` for proxy downloading applications.

```bash
# Add proxy
scoop config URL_PROXY "https://scoop.201704.xyz"

# Remove proxy
scoop config rm URL_PROXY
```

### Method 2: Installation Based on Official Repository with Proxy

Open `PowerShell` and execute the following commands to install:

```bash
# install
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# config
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# add spc bucket
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# Navigate to the spc directory
cd "$env:USERPROFILE\scoop\buckets\spc"
# Switch to the main branch
git fetch --all && git checkout -b main origin/main

# show help
scoop help

# install 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### About `scoop-search`

Since the `scoop-proxy-cn` repository synchronizes over 14,000 applications, the official `scoop search` command written in PowerShell is too inefficient to use. It is recommended to install and use the `scoop-search` tool developed in `Go` as a replacement. Example:

```bash
scoop install scoop-search
# Use scoop-search
scoop-search act
```

## Common Issues

### About download failures caused by `aria2`

When `aria2` is installed, Scoop uses `aria2` to implement segmented accelerated downloads. However, some proxy addresses do not support or block segmented download requests from `aria2`. In this case, you can disable `aria2` with the following command:

```bash
scoop config aria2-enabled false
```

### About `Hash Check Failed` errors

Some app configurations use the latest release download URL but also specify a hash value. When a new version is released, this causes a `Hash Check Failed` error. You can add the `-s` parameter to ignore this. Example:

```bash
scoop install scoop-search -s
```

### Handling proxy site invalidation and update

When using the official Scoop version with the subscription set to the `main` branch, proxy sites are used to accelerate git repository and application download URLs. If the old proxy acceleration site becomes invalid, the site will fail to update. Please run the following commands to re-add:

```bash
# First update scoop repo
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Method 1: Update spc bucket repo
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# If the buckets default location was changed, run the following
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Method 2: Remove and re-add spc bucket
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Sync Buckets From

- [ScoopInstaller/PHP](https://github.com/ScoopInstaller/PHP)
- [ScoopInstaller/Main](https://github.com/ScoopInstaller/Main)
- [ScoopInstaller/Extras](https://github.com/ScoopInstaller/Extras)
- [ScoopInstaller/Java](https://github.com/ScoopInstaller/Java)
- [ScoopInstaller/Versions](https://github.com/ScoopInstaller/Versions)
- [ScoopInstaller/Nirsoft](https://github.com/ScoopInstaller/Nirsoft)
- [ScoopInstaller/Nonportable](https://github.com/ScoopInstaller/Nonportable)
- [renxia/scoop-bucket](https://github.com/renxia/scoop-bucket)
- [scoopcn/scoopcn](https://github.com/scoopcn/scoopcn)
- [rasa/scoops](https://github.com/rasa/scoops)
- [amorphobia/siku](https://github.com/amorphobia/siku)
- [ACooper81/scoop-apps](https://github.com/ACooper81/scoop-apps)
- [kkzzhizhou/scoop-zapps](https://github.com/kkzzhizhou/scoop-zapps)
- [Calinou/scoop-games](https://github.com/Calinou/scoop-games)
- [cderv/r-bucket](https://github.com/cderv/r-bucket)
- [chawyehsu/dorado](https://github.com/chawyehsu/dorado)
- [borger/scoop-galaxy-integrations](https://github.com/borger/scoop-galaxy-integrations)
- [ivaquero/scoopet](https://github.com/ivaquero/scoopet)
- [KNOXDEV/wsl](https://github.com/KNOXDEV/wsl)
- [kodybrown/scoop-nirsoft](https://github.com/kodybrown/scoop-nirsoft)
- [kidonng/sushi](https://github.com/kidonng/sushi)
- [littleli/scoop-clojure](https://github.com/littleli/scoop-clojure)
- [niheaven/scoop-sysinternals](https://github.com/niheaven/scoop-sysinternals)
- [matthewjberger/scoop-nerd-fonts](https://github.com/matthewjberger/scoop-nerd-fonts)
- [TheCjw/scoop-retools](https://github.com/TheCjw/scoop-retools)
- [TheRandomLabs/Scoop-Bucket](https://github.com/TheRandomLabs/Scoop-Bucket)
- [TheRandomLabs/scoop-nonportable](https://github.com/TheRandomLabs/scoop-nonportable)
- [TheRandomLabs/Scoop-Spotify](https://github.com/TheRandomLabs/Scoop-Spotify)
- [Paxxs/Cluttered-bucket](https://github.com/Paxxs/Cluttered-bucket)
- [zhoujin7/tomato](https://github.com/zhoujin7/tomato)
- [HCLonely/my-scoop-bucket](https://github.com/HCLonely/my-scoop-bucket)
- [Weidows-projects/scoop-3rd](https://github.com/Weidows-projects/scoop-3rd)
- [hermanjustnu/scoop-emulators](https://github.com/hermanjustnu/scoop-emulators)
- [everyx/scoop-bucket](https://github.com/everyx/scoop-bucket)
- [borger/scoop-emulators](https://github.com/borger/scoop-emulators)
- [ZvonimirSun/scoop-iszy](https://github.com/ZvonimirSun/scoop-iszy)
- [kiennq/scoop-misc](https://github.com/kiennq/scoop-misc)
- [wzv5/ScoopBucket](https://github.com/wzv5/ScoopBucket)
- [TheRandomLabs/Scoop-Python](https://github.com/TheRandomLabs/Scoop-Python)
- [naderi/scoop-bucket](https://github.com/naderi/scoop-bucket)
- [ViCrack/scoop-bucket](https://github.com/ViCrack/scoop-bucket)
- [42wim/scoop-bucket](https://github.com/42wim/scoop-bucket)
- [akirco/aki-apps](https://github.com/akirco/aki-apps)
- [batkiz/backit](https://github.com/batkiz/backit)
- [iquiw/scoop-bucket](https://github.com/iquiw/scoop-bucket)
- [ygguorun/scoop-bucket](https://github.com/ygguorun/scoop-bucket)
- [seumsc/scoop-seu](https://github.com/seumsc/scoop-seu)
- [cc713/ownscoop](https://github.com/cc713/ownscoop)
- [aoisummer/scoop-bucket](https://github.com/aoisummer/scoop-bucket)
- [yuusakuri/scoop-bucket](https://github.com/yuusakuri/scoop-bucket)
- [hu3rror/scoop-muggle](https://github.com/hu3rror/scoop-muggle)
- [starise/Scoop-Confetti](https://github.com/starise/Scoop-Confetti)
- [dodorz/scoop](https://github.com/dodorz/scoop)
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

## Statement

> [!WARNING]
> The application information contained in this repository is only synchronized from third-party repositories and has not been individually verified for usability or security. Please verify and identify before installation and selection. If there is any infringement, please submit issues for handling.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---