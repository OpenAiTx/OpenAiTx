<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh 是一個開源、由社群驅動的框架，用於管理你的 [zsh](https://www.zsh.org/) 設定。

聽起來很無聊。讓我們再試一次。

**Oh My Zsh 不會讓你成為 10 倍開發者……但你可能會有那種感覺。**

安裝完成後，你的終端機 shell 將成為城中話題，_否則退錢！_ 每當你在命令提示字元輸入時，你都能享受到數百個強大插件與精美主題的便利。陌生人會在咖啡館走向你，問道，_「太厲害了！你是什麼天才嗎？」_

最後，你終於會開始獲得你一直覺得自己應該得到的關注。……或者你會利用省下來的時間更常用牙線。😬

想了解更多，請造訪 [ohmyz.sh](https://ohmyz.sh)、在 X（前身為 Twitter）追蹤 [@ohmyzsh](https://x.com/ohmyzsh)，以及加入我們的 [Discord](https://discord.gg/ohmyzsh)。

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>目錄</summary>

- [快速開始](#getting-started)
  - [作業系統相容性](#operating-system-compatibility)
  - [先決條件](#prerequisites)
  - [基本安裝](#basic-installation)
    - [手動檢查](#manual-inspection)
- [使用 Oh My Zsh](#using-oh-my-zsh)
  - [插件](#plugins)
    - [啟用插件](#enabling-plugins)
    - [使用插件](#using-plugins)
  - [主題](#themes)
    - [選擇主題](#selecting-a-theme)
  - [常見問題](#faq)
- [進階主題](#advanced-topics)
  - [進階安裝](#advanced-installation)
    - [自訂目錄](#custom-directory)
    - [無人值守安裝](#unattended-install)
    - [從分支倉庫安裝](#installing-from-a-forked-repository)
    - [手動安裝](#manual-installation)
  - [安裝問題](#installation-problems)
  - [自訂插件與主題](#custom-plugins-and-themes)
  - [在 macOS 與 freeBSD 啟用 GNU ls](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [跳過別名](#skip-aliases)
  - [非同步 git 提示](#async-git-prompt)
- [獲取更新](#getting-updates)
  - [更新訊息詳細程度](#updates-verbosity)
  - [手動更新](#manual-updates)
- [卸載 Oh My Zsh](#uninstalling-oh-my-zsh)
- [如何貢獻 Oh My Zsh？](#how-do-i-contribute-to-oh-my-zsh)
  - [請勿投稿主題](#do-not-send-us-themes)
- [貢獻者](#contributors)
- [追蹤我們](#follow-us)
- [周邊商品](#merchandise)
- [授權](#license)
- [關於 Planet Argon](#about-planet-argon)

</details>

## 快速開始

### 作業系統相容性

| 作業系統        | 狀態  |
| :-------------- | :---: |
| Android         |   ✅  |
| freeBSD         |   ✅  |
| LCARS           |   🛸  |
| Linux           |   ✅  |
| macOS           |   ✅  |
| OS/2 Warp       |   ❌  |
| Windows (WSL2)  |   ✅  |

### 先決條件

- 必須已安裝 [Zsh](https://www.zsh.org)（v4.3.9 或更新版本即可，但我們建議 5.0.8 以上）。如未預先安裝（執行 `zsh --version` 以確認），請參考 wiki 教學：[安裝 ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- 必須安裝 `curl` 或 `wget`
- 必須安裝 `git`（建議 v2.4.11 或以上）

### 基本安裝

Oh My Zsh 可透過在終端機執行下列其中一條指令來安裝。你可以使用 `curl`、`wget` 或其他類似工具從命令列安裝。

| 方式      | 指令                                                                                              |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

另外，安裝程式也有在 GitHub 以外的鏡像。如果你身處中國、印度（或部分 ISP），`raw.githubusercontent.com` 被封鎖，則可使用下方網址：

| 方式      | 指令                                           |
| :-------- | :--------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_注意：安裝前的 `.zshrc` 將會被重新命名為 `.zshrc.pre-oh-my-zsh`。安裝完成後，可將你要保留的設定搬移到新的 `.zshrc`。_

#### 手動檢查

對於不熟悉的專案，建議先檢查安裝腳本。你可以先下載安裝腳本，檢查內容沒問題後再執行：

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

如果上述網址超時或失敗，請改用 `https://install.ohmyz.sh` 下載腳本。

## 使用 Oh My Zsh

### 插件

Oh My Zsh 內建了大量插件供你使用。你可以在 [plugins 目錄](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) 或 [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) 查看目前可用的插件。

#### 啟用插件

找到想啟用的插件後，需在 `.zshrc` 檔案中啟用。該檔案位於 `$HOME` 目錄下。用你喜愛的文字編輯器打開，找到列出所有要載入插件的位置。

```sh
vi ~/.zshrc
```

例如，設定內容可能如下：

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_注意：插件名稱以空白（空格、tab、換行等）分隔。**不要**用逗號，否則會出錯。_

#### 使用插件

每個內建插件都包含 **README**，說明其功能。README 會列出該插件新增的別名及其他功能。

### 主題

我們承認，一開始 Oh My Zsh 世界對主題有點過於熱衷。現在我們已內建超過 150 種主題。大多數主題在 wiki 上有 [截圖](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes)（我們正持續更新中！），歡迎參考！

#### 選擇主題

_Robby 的主題是預設主題。它不是最華麗的，也不是最簡單的，但對他而言剛剛好。_

找到想用的主題後，需編輯 `~/.zshrc` 檔案。你會看到有個環境變數（全大寫）如下：

```sh
ZSH_THEME="robbyrussell"
```

如要更換主題，只需將其改為你想要的主題名稱。例如：

```sh
ZSH_THEME="agnoster" #（這是比較酷炫的主題之一）
# 參見 https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> 你經常會看到某個 zsh 主題的截圖，實際套用後卻發現效果不同。
>
> 這是因為許多主題需要安裝 [Powerline 字型](https://github.com/powerline/fonts) 或 [Nerd Font](https://github.com/ryanoasis/nerd-fonts) 才能正確顯示。否則主題可能出現奇怪的提示符號。詳情請參閱 [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt)。
>
> 另外要注意，主題只控制提示符外觀，也就是游標前後顯示的文字。主題不會影響終端機視窗的配色方案或字型，這些需在終端模擬器中設定。詳情請見 [什麼是 zsh 主題](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme)。
<!-- prettier-ignore-end -->

打開新的終端機視窗，你的提示符應該會類似這樣：

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

如果沒有找到合適的主題，請參考 wiki 的 [更多主題](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes)。

如果你想試試隨機主題，每次開新終端機時讓電腦幫你隨機選擇：

```sh
ZSH_THEME="random" #（...請給我派...希望是派..）
```

若只想隨機從你喜歡的主題中挑選：

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

如果只知道哪些主題你不喜歡，也可以將它們加入忽略清單：

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### 常見問題

如果有更多問題或疑問，可在 [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ) 尋找解答。

## 進階主題

如果你喜歡動手調整，以下內容適合你。

### 進階安裝

有些用戶可能想手動安裝 Oh My Zsh，或更改預設路徑及其他安裝設定（這些設定也在安裝腳本開頭有說明）。

#### 自訂目錄

預設位置為 `~/.oh-my-zsh`（隱藏於家目錄，可用 `cd ~/.oh-my-zsh` 進入）

如要更改安裝目錄，可在安裝前以 `export ZSH=/your/path` 設定 `ZSH` 環境變數，或直接在安裝管線最後設定：

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### 無人值守安裝

如在自動安裝腳本中安裝 Oh My Zsh，可對 `install.sh` 傳入 `--unattended` 參數。如此一來，安裝腳本不會嘗試更改預設 shell，也不會在安裝完成後自動執行 `zsh`。

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

如果你在中國、印度或其他封鎖 `raw.githubusercontent.com` 的國家，請將網址替換為 `https://install.ohmyz.sh`。

#### 從分支倉庫安裝

安裝腳本也接受下列變數，允許安裝不同的倉庫：

- `REPO`（預設：`ohmyzsh/ohmyzsh`）：格式為 `owner/repository`。設定此變數後，安裝器會從 `https://github.com/{owner}/{repository}` 抓取。
- `REMOTE`（預設：`https://github.com/${REPO}.git`）：git 倉庫完整 URL。若你想從非 GitHub 的分支（如 GitLab、Bitbucket）或用 SSH 方式 clone，可用此參數。

  _注意：此參數與 `REPO` 變數不相容，會以此參數為主。_

- `BRANCH`（預設：`master`）：更換預設分支，clone 倉庫時會 checkout 該分支。適合測試 PR 或使用非 master 分支。

例如：

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### 手動安裝

##### 1. 克隆倉庫 <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _可選_，備份現有 `~/.zshrc` 檔案 <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. 建立新的 Zsh 設定檔 <!-- omit in toc -->

你可從我們提供的範本複製一份新的 zsh 設定檔：

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. 更改預設 shell <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

你必須登出並重新登入，這個變更才會生效。

##### 5. 初始化新的 Zsh 設定 <!-- omit in toc -->

開啟新的終端機視窗，應會自動載入 Oh My Zsh 的設定。

### 安裝問題

如果安裝過程有狀況，以下是常見解法：

- 若切換到 oh-my-zsh 後找不到部分指令，_可能_需在 `~/.zshrc` 修改你的 `PATH`。
- 如手動安裝或更改安裝位置，請檢查 `~/.zshrc` 中的 `ZSH` 變數。

### 自訂插件與主題

若要覆寫預設行為，只需在 `custom/` 目錄新增 `.zsh` 結尾的檔案。

若你有多個相互搭配的函式，可將它們存為 `XYZ.plugin.zsh` 放在 `custom/plugins/` 目錄，再啟用此插件。

若想覆蓋 Oh My Zsh 內建插件的功能，只需在 `custom/plugins/` 目錄下建立同名插件，即會優先生效。

### 在 macOS 與 freeBSD 啟用 GNU ls

<a name="enable-gnu-ls"></a>

Oh My Zsh 預設在 macOS 與 FreeBSD 系統使用 BSD `ls`。若已安裝 GNU `ls`（命令為 `gls`），可選擇使用它。請在載入 `oh-my-zsh.sh` 之前，加入如下 zstyle 設定：

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_注意：此功能與 `DISABLE_LS_COLORS=true` 不相容_

### 跳過別名

<a name="remove-directories-aliases"></a>

如需跳過 Oh My Zsh 預設（`lib/*` 檔案）或插件定義的別名，請在 `~/.zshrc` 檔案中（**於載入 Oh My Zsh 前**）使用下列設定。根據需求有多種跳過方式：

```sh
# 跳過所有 lib 檔案及啟用插件中的別名
zstyle ':omz:*' aliases no

# 僅跳過所有 lib 檔案中的別名
zstyle ':omz:lib:*' aliases no
# 僅跳過 directories.zsh lib 檔案中的別名
zstyle ':omz:lib:directories' aliases no

# 跳過所有插件別名
zstyle ':omz:plugins:*' aliases no
# 僅跳過 git 插件的別名
zstyle ':omz:plugins:git' aliases no
```

你也可以組合使用，較特定的範圍會覆蓋較廣泛的設定：

```sh
# 跳過所有插件別名，除了 git 插件
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

舊版用法如下，已被移除：

```sh
zstyle ':omz:directories' aliases no
```

請改用下列方式：

```sh
zstyle ':omz:lib:directories' aliases no
```

#### 注意 <!-- omit in toc -->

> 此功能目前為測試階段，未來可能變動。且目前不支援 zpm、zinit 等插件管理器，因它們不會 source init 腳本（`oh-my-zsh.sh`），而此功能正實作於該腳本內。
>
> 也不會識別以函式定義的「別名」，如 git 插件中的 `gccd`、`ggf` 或 `ggl` 等函式。

### 非同步 git 提示

非同步提示功能是實驗性功能（2024 年 4 月 3 日加入），讓 Oh My Zsh 能非同步渲染提示資訊。這可提升提示效能，但某些環境可能不適用。如遇問題可在 `.zshrc` 載入 Oh My Zsh 前關閉此功能：

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

若你的問題是 git 提示消失，可嘗試強制啟用此功能。若仍不行，請回報 issue：

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## 獲取更新

預設每兩週會提示你檢查更新。你可於 `~/.zshrc` 檔案（**於載入 Oh My Zsh 前**）設定其他更新模式：

1. 自動更新，無需確認提示：

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. 僅於有更新時每隔幾天提醒：

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. 完全停用自動更新：

   ```sh
   zstyle ':omz:update' mode disabled
   ```

注意：你可用下列設定控制 Oh My Zsh 檢查更新的頻率：

```sh
# 每 7 天檢查一次更新
zstyle ':omz:update' frequency 7
# 每次打開終端機都檢查（不建議）
zstyle ':omz:update' frequency 0
```

### 更新訊息詳細程度

你也可以以下列設定調整更新訊息的詳細程度：

```sh
zstyle ':omz:update' verbose default # 預設更新提示

zstyle ':omz:update' verbose minimal # 僅顯示少量訊息

zstyle ':omz:update' verbose silent # 僅顯示錯誤
```

### 手動更新

如需隨時手動更新（例如新插件釋出不想等一週），只需執行：

```sh
omz update
```

> [!NOTE]
> 若需在腳本中自動化更新，請直接呼叫 `upgrade` 腳本：
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> 更多選項請見 [FAQ：如何更新 Oh My Zsh？](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh)。
>
> **`omz update --unattended` 已被移除，因會造成副作用**。

神奇！🎉

## 卸載 Oh My Zsh

Oh My Zsh 並不適合每個人。我們會想念你，但我們希望分手也能很容易。

如要卸載 `oh-my-zsh`，只需在命令列執行 `uninstall_oh_my_zsh`。它會自我移除，並還原你原本的 `bash` 或 `zsh` 設定。

## 如何貢獻 Oh My Zsh？

在參與我們這個愉快社群前，請先閱讀 [行為準則](CODE_OF_CONDUCT.md)。

我遠非 [Zsh](https://www.zsh.org/) 專家，深信尚有許多改進空間——如果你有提升設定維護性（與速度）的想法，請不要猶豫，fork 並送出 pull requests！

我們也需要人幫忙測試 pull requests。請瀏覽 [開放議題](https://github.com/ohmyzsh/ohmyzsh/issues)，一起貢獻。

詳情請見 [貢獻方式](CONTRIBUTING.md)。

### 請勿投稿主題

現有（超過）足夠多的主題。請將你的主題加到 [external themes](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) wiki 頁面。

## 貢獻者

Oh My Zsh 有著活躍的快樂用戶與熱情的貢獻者社群。沒有他們的付出，Oh My Zsh 不會這麼棒。

非常感謝大家！

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## 追蹤我們

我們的社群平台：

- X（前 Twitter）上的 [@ohmyzsh](https://x.com/ohmyzsh)。歡迎追蹤。
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) 與我們互動。
- [Instagram](https://www.instagram.com/_ohmyzsh/) 標註我們，秀出你的 Oh My Zsh！
- [Discord](https://discord.gg/ohmyzsh) 與我們聊天！

## 周邊商品

我們有為你準備 [貼紙、T 恤、馬克杯等周邊](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github)，讓你展現對 Oh My Zsh 的熱愛。你一定會成為矚目焦點！

## 授權

Oh My Zsh 採用 [MIT 授權條款](LICENSE.txt)。

## 關於 Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh 由 [Planet Argon](https://www.planetargon.com/?utm_source=github) 團隊發起，是一家 [Ruby on Rails 開發公司](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github)。歡迎參考我們的 [其他開源專案](https://www.planetargon.com/open-source?utm_source=github)。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---