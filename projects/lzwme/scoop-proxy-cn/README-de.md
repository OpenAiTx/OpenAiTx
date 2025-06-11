# 🍡 scoop-proxy-cn

Ein Proxy-Mirror-Repository für [Scoop](https://scoop.sh) Buckets, geeignet für Benutzer in Festlandchina. Synchronisiert Updates aus mehreren Open-Source-`bucket`-Repositories. Dabei gilt:

- `sync` Branch (Standard): Synchronisiert Anwendungen aus mehreren Repositories, ohne ghproxy Proxy-Änderungen vorzunehmen. **Geeignet für Szenarien, in denen die in China angepasste Version von Scoop auf Gitee verwendet wird.**
- `main` Branch: Ändert die Download-URLs der Anwendungen, die von `github release` geladen werden, auf Proxy-URLs basierend auf `https://ghfast.top`. **Da Proxy-Adressen häufig wegen Ausfällen wechseln, ist diese Methode nicht stabil.**

## Verwendung

Fügen Sie das `spc` Anwendungs-Repository hinzu. Geeignet zur Verwendung mit der [Scoop China Mirror Optimization Library](https://gitee.com/scoop-installer/scoop):

```bash
# Bucket hinzufügen, standardmäßig wird der sync Branch gezogen
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Apps installieren
scoop install spc/<app_name>
```

Wenn Sie nur die offizielle Scoop-Version verwenden möchten, können Sie wie folgt vorgehen und den Abonnement-Branch auf den `main` Branch ändern:

```bash
# Wechseln Sie in das spc-Verzeichnis
cd "$env:USERPROFILE\scoop\buckets\spc"
# Falls die Umgebungsvariable SCOOP gesetzt ist, verwenden Sie folgenden Befehl
cd "$env:SCOOP\buckets\spc"

# Wechseln zum main Branch
git fetch --all
git checkout -b main origin/main
```

## Scoop Installation und Konfiguration Referenz

### Methode 1: Installation basierend auf einem inländischen angepassten Spiegel (empfohlen)

Da Scoop Quellcode und Buckets Anwendungen überwiegend als Git-Repositories auf GitHub verwaltet, führt die erschwerte GitHub-Zugänglichkeit in China zu einer schlechten Nutzererfahrung bei Installation, Updates und App-Downloads.

Nachfolgend die Installationsmethode für die [Scoop China Mirror Optimization Library](https://gitee.com/scoop-installer/scoop).

```bash
# Ändern der Skript-Ausführungsrichtlinie, standardmäßig automatische Zustimmung
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Methode 1: Installationsbefehl ausführen (standardmäßig Installation im Benutzerverzeichnis, für andere Verzeichnisse siehe “Benutzerdefiniertes Installationsverzeichnis”)
iwr -useb scoop.201704.xyz | iex


## Methode 2: Benutzerdefiniertes Installationsverzeichnis (bitte Verzeichnis anpassen)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# Falls die offizielle Quelle bereits installiert ist, können Sie mit folgendem Befehl wechseln
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# spc bucket hinzufügen
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Neue Repository-Adresse abrufen
scoop update
```

Diese Methode installiert eine angepasste Version von Scoop, die benutzerdefinierte Proxy-Beschleuniger unterstützt und standardmäßig `scoop.201704.xyz` als Proxy für App-Downloads verwendet.

```bash
# Proxy hinzufügen
scoop config URL_PROXY "https://scoop.201704.xyz"

# Proxy entfernen
scoop config rm URL_PROXY
```

### Methode 2: Installation auf Basis des offiziellen Repositories mit Proxy

Öffnen Sie `PowerShell` und führen Sie folgende Befehle aus, um zu installieren:

```bash
# Installation
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# Konfiguration
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# spc bucket hinzufügen
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# Wechseln in das spc-Verzeichnis
cd "$env:USERPROFILE\scoop\buckets\spc"
# Wechsel zum main Branch
git fetch --all && git checkout -b main origin/main

# Hilfe anzeigen
scoop help

# Installation von 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### Über `scoop-search`

Da das `scoop-proxy-cn` Repository über `1.4w+` Anwendungen synchronisiert, ist der offizielle `scoop search` Befehl, der auf `PowerShell` basiert, ineffizient und kaum nutzbar. Es wird empfohlen, stattdessen das auf Go basierende Tool `scoop-search` zu installieren und zu verwenden. Beispiel:

```bash
scoop install scoop-search
# Verwendung von scoop-search
scoop-search act
```

## Häufige Probleme

### Problem mit Download-Fehlern durch `aria2`

Wenn `aria2` installiert ist, verwendet Scoop `aria2` für beschleunigte, segmentierte Downloads. Manche Proxy-Adressen unterstützen jedoch keine segmentierten Anfragen oder blockieren sie. In diesem Fall kann `aria2` deaktiviert werden mit:

```bash
scoop config aria2-enabled false
```

### Problem `Hash Check Failed`

Einige Apps konfigurieren Download-URLs als neueste Release-Adresse, aber gleichzeitig mit einem festen Hash-Wert. Wenn eine neue Version erscheint, schlägt der Hash-Check fehl. In solchen Fällen kann der Parameter `-s` zum Ignorieren verwendet werden. Beispiel:

```bash
scoop install scoop-search -s
```

### Umgang mit Proxy-Ausfällen und Aktualisierung

Wenn die offizielle Scoop-Version mit dem `main` Branch verwendet wird, nutzt Scoop Proxy-Server zur Beschleunigung von Git-Repository- und App-Downloads. Fällt der Proxy aus, ist keine Aktualisierung mehr möglich. Führen Sie folgende Befehle zur Wiederherstellung aus:

```bash
# Zuerst das scoop repo aktualisieren
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Methode 1: spc bucket repo aktualisieren
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# Wenn der buckets-Standardpfad geändert wurde, verwenden Sie stattdessen:
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Methode 2: spc bucket entfernen und neu hinzufügen
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Synchronisierte Buckets von

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

## Erklärung

> [!WARNUNG]
> Dieses Repository enthält Anwendungsinformationen, die nur von Drittanbieter-Repositories synchronisiert wurden und nicht einzeln auf Verwendbarkeit oder Sicherheit überprüft sind. Bitte überprüfen und identifizieren Sie diese selbst bei der Installation und Auswahl. Bei Urheberrechtsverletzungen wenden Sie sich bitte per Issue an uns zur Klärung.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---