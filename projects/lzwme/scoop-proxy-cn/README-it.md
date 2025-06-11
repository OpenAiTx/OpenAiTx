# 🍡 scoop-proxy-cn

Repository mirror proxy per bucket di [Scoop](https://scoop.sh) adatto agli utenti della Cina continentale. Sincronizza aggiornamenti da più repository `bucket` open source. In dettaglio:

- Branch `sync` (predefinito): sincronizza applicazioni da più repository senza modificare gli URL per ghproxy. **Adatto a scenari che utilizzano versioni modificate di Scoop domestiche basate su gitee**
- Branch `main`: modifica gli URL di download delle applicazioni scaricate da `github release` usando il proxy `https://ghfast.top`. **Poiché gli indirizzi proxy cambiano frequentemente a causa di interruzioni, non è stabile**

## Utilizzo

Aggiungi il bucket `spc`. Consigliato insieme al [repository mirror ottimizzato per Scoop in Cina](https://gitee.com/scoop-installer/scoop):

```bash
# Aggiungi il bucket, preleva di default il branch sync
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# installa applicazioni
scoop install spc/<nome_app>
```

Se desideri usare solo la versione ufficiale di Scoop, modifica il branch di sottoscrizione a `main` come segue:

```bash
# Entra nella cartella spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# Se hai impostato la variabile ambiente SCOOP, esegui invece
cd "$env:SCOOP\buckets\spc"

# Passa al branch main
git fetch --all
git checkout -b main origin/main
```

## Riferimenti per installazione e configurazione Scoop

### Metodo 1: Installazione basata su mirror domestico personalizzato (consigliato)

Poiché il codice sorgente di scoop e i bucket sono mantenuti principalmente su GitHub in forma git, le difficoltà di accesso a GitHub peggiorano notevolmente l’esperienza di installazione, aggiornamento e download delle applicazioni.

Segue il metodo di installazione per il [repository mirror ottimizzato per Scoop in Cina](https://gitee.com/scoop-installer/scoop).

```bash
# Cambia la policy di esecuzione script, accetta automaticamente
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Metodo 1: comando di installazione (installazione predefinita nella cartella utente, per cambiare usa il comando “Installazione personalizzata” qui sotto)
iwr -useb scoop.201704.xyz | iex


## Metodo 2: installazione personalizzata (modifica il percorso di installazione in base alle tue esigenze)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# Se hai già installato la versione ufficiale, puoi passare a questo repository con
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# Aggiungi il bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Aggiorna all’ultimo repository
scoop update
```

La versione di scoop installata con questo metodo è modificata per supportare proxy personalizzati per l’accelerazione e usa di default il proxy `scoop.201704.xyz` per il download delle applicazioni.

```bash
# Aggiungi proxy
scoop config URL_PROXY "https://scoop.201704.xyz"

# Rimuovi proxy
scoop config rm URL_PROXY
```

### Metodo 2: Installazione tramite repository ufficiale con proxy

Apri `PowerShell` ed esegui:

```bash
# installa
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# configura
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# aggiungi bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# Entra nella cartella spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# Passa al branch main
git fetch --all && git checkout -b main origin/main

# mostra aiuto
scoop help

# installa 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### Informazioni su `scoop-search`

Poiché il repository `scoop-proxy-cn` sincronizza oltre `1.4w+` applicazioni, il comando ufficiale `scoop search` scritto in `PowerShell` è troppo lento per l’uso. Si consiglia di installare e usare lo strumento `scoop-search` sviluppato in linguaggio `go` come alternativa. Esempio:

```bash
scoop install scoop-search
# Usa scoop-search
scoop-search act
```

## Problemi comuni

### Problema di download fallito causato da `aria2`

Quando `aria2` è installato, scoop usa `aria2` per il download accelerato a frammenti. Alcuni proxy non supportano o bloccano le richieste di frammentazione da `aria2`. In questo caso, disabilita `aria2` con:

```bash
scoop config aria2-enabled false
```

### Problema `Hash Check Failed`

Alcune applicazioni configurano l’URL di download sull’ultima release ma hanno ancora l’hash specificato. Quando la versione cambia, si verifica `Hash Check Failed`. Puoi ignorare l’hash con il parametro `-s`. Esempio:

```bash
scoop install scoop-search -s
```

### Metodo per aggiornare quando il proxy è scaduto

Se usi la versione ufficiale di Scoop e il branch `main`, il proxy accelera git e download. Se il proxy è scaduto, l’aggiornamento fallisce. Per risolvere, esegui:

```bash
# Prima aggiorna scoop repo
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Metodo 1: aggiorna l’url remoto del repo spc bucket
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# Se hai modificato la posizione dei buckets, esegui
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Metodo 2: rimuovi e aggiungi nuovamente il bucket spc
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Sincronizza bucket da

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

## Dichiarazione

> [!WARNING]
> Questo repository contiene informazioni sulle applicazioni sincronizzate solo da repository di terze parti, senza una verifica individuale della disponibilità o sicurezza. Si prega di verificare e riconoscere autonomamente prima dell'installazione. In caso di violazioni, si prega di aprire issue per la gestione.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---