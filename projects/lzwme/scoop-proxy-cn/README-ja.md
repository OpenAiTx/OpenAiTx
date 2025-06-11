# 🍡 scoop-proxy-cn

中国本土ユーザー向けの[Scoop](https://scoop.sh)バケット代理ミラーリポジトリ。複数のオープンソース `bucket` リポジトリから同期更新しています。内訳は以下の通りです：

- `sync` ブランチ（デフォルト）：複数のリポジトリのアプリを同期しますが、ghproxy代理の変更処理は行いません。**giteeの国内改変版scoopを使用するシーンに適しています。**
- `main` ブランチ：`github release`からダウンロードするアプリのURLを`https://ghfast.top`を基にした代理ダウンロードURLに変更します。**代理アドレスは頻繁に無効化や変更が発生するため安定性が低いです。**

## 使い方

`spc`アプリリポジトリを追加します。[scoop国内ミラー最適化リポジトリ](https://gitee.com/scoop-installer/scoop)との併用に適しています：

```bash
# バケットを追加、デフォルトでsyncブランチを取得
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# アプリをインストール
scoop install spc/<app_name>
```

Scoop公式版のみを使いたい場合は、購読ブランチを`main`に切り替えます：

```bash
# spcディレクトリに移動
cd "$env:USERPROFILE\scoop\buckets\spc"
# 環境変数 SCOOP が設定されている場合は以下を実行
cd "$env:SCOOP\buckets\spc"

# mainブランチに切り替え
git fetch --all
git checkout -b main origin/main
```

## Scoopインストールと設定参考

### 方法1：国内カスタムミラーを基にしたインストール（推奨）

scoopのソースコードおよびバケットアプリは基本的にGitHub上のgit形式で管理されています。GitHubへのアクセス困難によりインストール、更新、アプリダウンロードの体験が非常に悪化します。

以下は[scoop国内ミラー最適化リポジトリ](https://gitee.com/scoop-installer/scoop)のインストール方法です。

```bash
# スクリプト実行ポリシー変更、デフォルトで自動同意
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# 方法1：インストールコマンドを実行（デフォルトはユーザーディレクトリにインストール。変更したい場合は下の「カスタムインストールディレクトリ」コマンドを実行）
iwr -useb scoop.201704.xyz | iex


## 方法2：カスタムインストールディレクトリ（ディレクトリを適切な場所に変更してください）
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# もし公式リポジトリがインストール済みの場合は以下で切り替え可能
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# spcバケットを追加
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# 新しいリポジトリアドレスを取得
scoop update
```

この方法でインストールしたscoopはカスタム修正が施されており、プロキシ加速サイトのカスタマイズをサポートし、デフォルトで`scoop.201704.xyz`を代理ダウンロードに使用します。

```bash
# プロキシを追加
scoop config URL_PROXY "https://scoop.201704.xyz"

# プロキシを削除
scoop config rm URL_PROXY
```

### 方法2：公式リポジトリを代理経由でインストール

PowerShellを開き、以下のコマンドを実行してください：

```bash
# インストール
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# 設定
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# spcバケットを追加
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# spcディレクトリに移動
cd "$env:USERPROFILE\scoop\buckets\spc"
# mainブランチに切り替え
git fetch --all && git checkout -b main origin/main

# ヘルプ表示
scoop help

# 7zip、aria2、scoop-searchなどをインストール
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### `scoop-search`について

`scoop-proxy-cn`リポジトリは`1.4万以上`のアプリを同期しています。PowerShellベースの公式`scoop search`コマンドは効率が悪く実用的ではありません。代わりにGo言語で開発された`scoop-search`ツールのインストールと使用を推奨します。例：

```bash
scoop install scoop-search
# scoop-searchを使用
scoop-search act
```

## よくある質問

### `aria2`によるダウンロード失敗問題について

`aria2`をインストールすると、scoopは`aria2`で分割加速ダウンロードを行いますが、一部の代理アドレスは`aria2`からの分割ダウンロードをサポートしないかブロックしています。その場合は以下のコマンドで`aria2`を無効化してください：

```bash
scoop config aria2-enabled false
```

### `Hash Check Failed`問題について

一部アプリは最新リリースアドレスを設定しつつハッシュ値も指定しているため、新バージョンの変更時に`Hash Check Failed`が発生します。この場合、`-s`オプションを追加して無視できます。例：

```bash
scoop install scoop-search -s
```

### 代理サイトが無効化され更新が必要な場合の対処法

Scoop公式版を使い、購読ブランチが`main`の場合、gitリポジトリやアプリダウンロードURLに代理サイトが使われますが、代理サイトが無効化されると更新ができなくなります。以下のコマンドで再設定してください：

```bash
# まずscoopリポジトリを更新
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# 方法1：spcバケットリポジトリのURLを更新
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# バケットのデフォルト位置を変更している場合はこちらを実行
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# 方法2：spcバケットを削除して再追加
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## 同期元バケット

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

## 声明

> [!WARNING]
> 本リポジトリに含まれるアプリ情報はすべてサードパーティのリポジトリから同期したものであり、個別の可用性や安全性の検証は行っておりません。インストール時はご自身で検証・識別を行ってください。もし権利侵害があった場合は、issuesにてご連絡ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---