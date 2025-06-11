# 🍡 scoop-proxy-cn

適合中國大陸用戶使用的 [Scoop](https://scoop.sh) buckets 代理鏡像庫。從多個開源 `bucket` 倉庫同步更新。其中：

- `sync`分支(默認)： 同步多個倉庫應用，但不作 ghproxy 代理修改處理。**適用於使用 gitee 國內修改版 scoop 的場景**
- `main`分支：將從 `github release` 下載的應用地址修改為基於 `https://ghfast.top` 的代理下載地址。**由於代理地址經常會因失效而變動，並不穩定**

## Usage

添加 `spc`應用倉庫。適用與 [scoop 國內鏡像優化庫](https://gitee.com/scoop-installer/scoop) 搭配適用：

```bash
# 添加 bucket，默認拉取 sync 分支
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# install apps
scoop install spc/<app_name>
```

如果只希望使用 Scoop 官方版，可作如下操作，將訂閱分支修改為 `main` 分支：

```bash
# 進入到 spc 目錄下
cd "$env:USERPROFILE\scoop\buckets\spc"
# 如果設置了環境變量 SCOOP，則應執行如下命令
cd "$env:SCOOP\buckets\spc"

# 切換到 main 分支
git fetch --all
git checkout -b main origin/main
```

## Scoop 安裝與配置參考

### 方式一：基於國內定製鏡像安裝(推薦)

由於 scoop 的源碼和 buckets 應用基本都是以 git 形式維護在 github，github 的訪問難題使得其安裝、更新和應用下載都會變得體驗極差。

下面介紹為 [scoop 國內鏡像優化庫](https://gitee.com/scoop-installer/scoop)的安裝方法。

```bash
# 腳本執行策略更改，默認自動同意
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# 方法一：執行安裝命令（默認安裝在用戶目錄下，如需更改請執行下面的“自定義安裝目錄”命令）
iwr -useb scoop.201704.xyz | iex


## 方法二：自定義安裝目錄（注意將目錄修改為合適位置)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# 若已安裝官方源，可執行如下命令進行切換
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# 添加 spc bucket
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# 拉取新庫地址
scoop update
```

該方式安裝的 scoop 經過定製修改，支持自定義代理加速站，並默認使用 `scoop.201704.xyz` 代理下載應用。

```bash
# 添加代理
scoop config URL_PROXY "https://scoop.201704.xyz"

# 刪除代理
scoop config rm URL_PROXY
```

### 方式二：基於官方倉庫以代理形式安裝

打開 `PowerShell` 並執行如下命令進行安裝：

```bash
# install
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# config
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# add spc bucket
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# 進入到 spc 目錄下
cd "$env:USERPROFILE\scoop\buckets\spc"
# 切換到 main 分支
git fetch --all && git checkout -b main origin/main

# show help
scoop help

# install 7zip、aria2、scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### 關於 `scoop-search`

由於 `scoop-proxy-cn` 倉庫同步了 `1.4w+` 應用，官方的基於 `PowerShell` 編寫的 `scoop search` 命令效率差到無法使用，推薦安裝並使用基於 `go` 語言開發的 `scoop-search` 工具替代。示例：

```bash
scoop install scoop-search
# 使用 scoop-search
scoop-search act
```

## 常見問題

### 關於 `aria2` 導致的下載失敗的問題

當安裝了 `aria2` 時，scoop 會採用 `aria2` 實現分片加速下載。但部分代理地址不支持或屏蔽了來自 `aria2` 的分片下載請求，此時可以執行如下命令禁用 `aria2`：

```bash
scoop config aria2-enabled false
```

### 關於 `Hash Check Failed` 的問題

由於部分 app 配置的下載地址為最新發布地址，但同時又配置了 hash 值，當其有新版本變更時則會出現 `Hash Check Failed` 的問題。此時可以添加參數 `-s` 以忽略。示例：

```bash
scoop install scoop-search -s
```

### 關於代理站失效需更新的處理方法

在使用 Scooop 官方版並且訂閱為 `main` 分支的情況下，會使用代理站加速 git 倉庫及應用下載地址。但舊的代理加速站失效則會導致站點無法繼續更新。請執行如下命令以重新添加：

```bash
# 先更新 scoop repo
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# 方法一：更新 spc bucket repo
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# 如果修改了 buckets 的默認位置，則執行如下命令
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# 方法二：移除並重新添加 spc bucket
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

## 聲明

> [!WARNING]
> 本倉庫包含的應用資訊僅從第三方倉庫同步，未逐一作可用性、安全性驗證，請在安裝選擇時自行驗證識別。若有侵權請提 issues 處理。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---