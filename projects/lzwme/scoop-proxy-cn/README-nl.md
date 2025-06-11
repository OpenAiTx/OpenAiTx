# 🍡 scoop-proxy-cn

Geschikte proxy mirror repository voor [Scoop](https://scoop.sh) buckets voor gebruikers in Mainland China. Synchroniseert updates van meerdere open source `bucket` repositories. Hieronder:

- `sync` branch (standaard): Synchroniseert applicaties van meerdere repositories, maar voert geen ghproxy proxy-aanpassingen uit. **Geschikt voor gebruik met gitee aangepaste Scoop-versies binnen China**
- `main` branch: Wijzigt de applicatie-downloadadressen van `github release` naar proxy-downloadadressen gebaseerd op `https://ghfast.top`. **Omdat proxy-adressen vaak veranderen door uitval, is dit minder stabiel**

## Gebruik

Voeg de `spc` applicatie repository toe. Geschikt in combinatie met de [Scoop China mirror optimalisatie repository](https://gitee.com/scoop-installer/scoop):

```bash
# Voeg bucket toe, standaard haalt sync branch op
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# installeer apps
scoop install spc/<app_naam>
```

Als je alleen de officiële Scoop-versie wilt gebruiken, kun je de subscribe branch als volgt naar `main` wijzigen:

```bash
# Ga naar de spc map
cd "$env:USERPROFILE\scoop\buckets\spc"
# Als de SCOOP omgevingsvariabele is ingesteld, gebruik dan:
cd "$env:SCOOP\buckets\spc"

# Schakel over naar de main branch
git fetch --all
git checkout -b main origin/main
```

## Referentie voor Scoop installatie en configuratie

### Methode 1: Installatie gebaseerd op binnenlandse aangepaste mirror (aanbevolen)

Omdat de broncode en buckets van Scoop meestal via git op GitHub worden beheerd, leidt de moeilijke toegang tot GitHub tot een slechte installatie-, update- en downloadervaring.

Hieronder wordt de installatie beschreven voor de [Scoop China mirror optimalisatie repository](https://gitee.com/scoop-installer/scoop).

```bash
# Wijzig het script-uitvoeringsbeleid, standaard automatisch akkoord
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Methode 1: Voer het installatiescript uit (standaard installatie in gebruikersmap, wijzig anders met “aangepaste installatiemap” hieronder)
iwr -useb scoop.201704.xyz | iex


## Methode 2: Aangepaste installatiemap (pas het pad aan naar een geschikte locatie)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# Als de officiële source reeds geïnstalleerd is, kun je overschakelen met
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# Voeg spc bucket toe
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Update naar nieuwe repository adressen
scoop update
```

Deze Scoop-installatie is aangepast en ondersteunt aangepaste proxy acceleratorsites, standaard gebruikmakend van `scoop.201704.xyz` als proxy voor app downloads.

```bash
# Proxy toevoegen
scoop config URL_PROXY "https://scoop.201704.xyz"

# Proxy verwijderen
scoop config rm URL_PROXY
```

### Methode 2: Installatie gebaseerd op officiële repository via proxy

Open `PowerShell` en voer de volgende commando’s uit om te installeren:

```bash
# Installeren
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/install.ps1 | iex

# Configureren
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# Voeg spc bucket toe
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# Ga naar de spc directory
cd "$env:USERPROFILE\scoop\buckets\spc"
# Schakel over naar main branch
git fetch --all && git checkout -b main origin/main

# Toon help
scoop help

# Installeer 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### Over `scoop-search`

Omdat `scoop-proxy-cn` repository meer dan `1.4w+` applicaties synchroniseert, is het officiële met PowerShell geschreven `scoop search` commando inefficiënt en praktisch onbruikbaar. Het wordt aanbevolen de in Go geschreven `scoop-search` tool te installeren en gebruiken als vervanging. Voorbeeld:

```bash
scoop install scoop-search
# Gebruik scoop-search
scoop-search act
```

## Veelgestelde vragen

### Problemen met downloadfouten veroorzaakt door `aria2`

Als `aria2` geïnstalleerd is, gebruikt Scoop `aria2` voor versneld gedistribueerd downloaden. Sommige proxy-adressen ondersteunen dit niet of blokkeren gedistribueerde downloads van `aria2`. Schakel `aria2` dan uit met:

```bash
scoop config aria2-enabled false
```

### Problemen met `Hash Check Failed`

Sommige apps configureren downloadadressen naar de nieuwste release, maar hebben ook een hashwaarde ingesteld. Bij een nieuwe versie kan hierdoor een `Hash Check Failed` optreden. Voeg dan de `-s` parameter toe om te negeren. Voorbeeld:

```bash
scoop install scoop-search -s
```

### Methode voor het bijwerken bij proxy-uitval

Als je de officiële Scoop gebruikt met de `main` branch, wordt een proxy gebruikt voor versnelling van git repositories en app downloads. Als de oude proxy uitvalt, kun je niet meer updaten. Voer de volgende commando’s uit om opnieuw toe te voegen:

```bash
# Update eerst scoop repo
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Methode 1: Update spc bucket repo
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# Als je de standaard locatie van buckets hebt aangepast, gebruik dan:
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Methode 2: Verwijder en voeg spc bucket opnieuw toe
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Sync Buckets Van

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

## Verklaring

> [!WARNING]
> Deze repository bevat applicatie-informatie die alleen gesynchroniseerd is van externe repositories. De bruikbaarheid en veiligheid zijn niet individueel geverifieerd. Gelieve zelf de validiteit te controleren bij installatie. Bij inbreuk graag een issue aanmaken voor afhandeling.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---