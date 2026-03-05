<div align="center">
  <img src="https://raw.githubusercontent.com/marsdevx/macOS-config/main/imgs/logo.png" width="320px" alt="macOS Config Logo">
</div>

<br>

<div align="center">

  [![Last Commit](https://custom-icon-badges.demolab.com/github/last-commit/marsdevx/macOS-config?logoColor=white&labelColor=2C2C2C&label=Last%20Commit&color=8A2BE2&logo=mark-github)](https://github.com/marsdevx/macOS-config/commits/main "Last Commit")
  [![Languages](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Languages&message=Bash%20%7C%20Lua&color=D32F2F&logo=file-code)](https://github.com/marsdevx/macOS-config "Languages")
  <br>
  [![Supported Platforms](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Platform&message=MacBook&color=748ADB&logo=apple)](https://github.com/marsdevx/macOS-config "Supported Platforms")
  [![Wallpapers](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Includes&message=Wallpapers&color=F47F42&logo=file-media)](https://github.com/marsdevx/macOS-config/tree/main/wallpapers "Wallpapers")
  [![Customization](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Customization&message=Ricing&color=009688&logo=sparkles-fill)](https://github.com/marsdevx/macOS-config "Customization")
  [![License](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=License&message=MIT&color=00C853&logo=law)](https://github.com/marsdevx/macOS-config/blob/main/LICENSE "License")

</div>

---

#  macOS Config

**macOS Config** is an **open-source** project designed to streamline the setup of your **MacBook** with **custom** settings, **program installations**, and **wallpapers**. Built using **shell** scripts, this tool **automates** the process of **configuring** your **macOS environment** for **productivity** and **ricing**.

* Specifically designed for **macOS customization** and **ricing**.
* Includes `.sh` **scripts** to **install** all programs you need for **work**.
* Applies your custom settings for installed programs **automatically**.
* Adds your favorite **wallpapers** for a personalized **macOS experience**.

Transform your MacBook into a fully customized workspace with this powerful and efficient tool!

---

## 🖼️ Preview

<div align="center">
  <img src="https://raw.githubusercontent.com/marsdevx/macOS-config/main/imgs/preview.png" alt="Preview">
</div>

---

## 🛠️ インストール

このプロジェクトをインストールするには、システムのターミナルアプリを起動し、以下のコマンドを実行してください。 <br>
  - 最初のコマンド実行後にXcodeコマンドラインツールのダウンロードを促すポップアップが表示された場合は、「ダウンロード」をクリックし、その後もう一度最初のコマンドを実行してください。

1. **リポジトリをクローン**
```zsh
git clone https://github.com/marsdevx/macOS-config.git ~/Downloads/macOS-config
```

2. **Homebrewをインストールする**
```zsh
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
echo 'eval "$(/opt/homebrew/bin/brew shellenv)"' >> ~/.zshrc
eval "$(/opt/homebrew/bin/brew shellenv)"
```

3. **デスクトップアイコンを無効にする**
```zsh
defaults write com.apple.finder CreateDesktop false; killall Finder
```

4. **設定ディレクトリの作成**
```zsh
mkdir -p ~/.config
```
5. **システム設定の更新**

  - アクセシビリティとコントロールセンター
    - システム設定 -> アクセシビリティ -> ディスプレイ -> 動作を減らす -> オン  
    - システム設定 -> コントロールセンター -> メニューバーを自動的に隠す/表示する -> 常に  

  - デスクトップとドック
    - システム設定 -> デスクトップとドック -> ドックを自動的に隠す/表示する -> オン  
    - システム設定 -> デスクトップとドック -> 最近使用した順にスペースを自動的に並べ替える -> オフ  
    - システム設定 -> デスクトップとドック -> アプリケーションに切り替えるときにスペースを切り替える... -> オフ  
    - システム設定 -> デスクトップとドック -> アプリケーションごとにウィンドウをグループ化 -> オフ  
    - システム設定 -> デスクトップとドック -> ディスプレイごとに別々のスペースを持つ -> オン  

  - キーボード
    - システム設定 -> キーボード -> キーボードショートカット -> Spotlight -> Spotlight検索を表示 -> オフ  
    - システム設定 -> キーボード -> キーボードショートカット -> Spotlight -> Finder検索ウィンドウを表示 -> オフ  
    - システム設定 -> キーボード -> キーボードショートカット -> ミッションコントロール -> デスクトップ1に切り替え -> オン  
    - システム設定 -> キーボード -> キーボードショートカット -> ミッションコントロール -> デスクトップ2に切り替え -> オン  
    - システム設定 -> キーボード -> キーボードショートカット -> ミッションコントロール -> デスクトップ3に切り替え -> オン  
    - システム設定 -> キーボード -> キーボードショートカット -> ミッションコントロール -> デスクトップ4に切り替え -> オン  
    - システム設定 -> キーボード -> キーボードショートカット -> ミッションコントロール -> デスクトップ5に切り替え -> オン  

---

## 🚀 使い方

1. **ループ**

> ウィンドウマネージャー


```zsh
zsh ~/Downloads/macOS-config/loop.sh
```

- スクリプトを実行した後、Loopアプリを以下の設定で構成します  
  - アクセントカラー -> 壁紙 -> グラデーション -> オン  
  - 動作 -> ログイン時に起動 -> オン  
  - 動作 -> アニメーション速度 -> スムーズ  
  - 動作 -> パディングを含める -> オン -> パディングを設定 -> 7px  
  - 動作 -> カーソルのある画面を使用 -> オフ  
  - キーバインディング -> 中央 -> 削除  
  - キーバインディング -> 追加 -> 一般 -> macOS 中央 -> Fn + Enter  

<br>

2. **Raycast**

> アプリケーションの起動

```zsh
zsh ~/Downloads/macOS-config/raycast.sh
```

- スクリプトを実行した後、Raycastアプリを以下の設定で構成します
  - 「Start Setup」をクリック -> 「Continue」をクリック。
  - 新しいホットキーを設定：Record New Hotkey -> Cmd + Spaceを割り当て。
  - 「Continue」をクリックして完了。

<br>

3. **Sketchybar**

> カスタマイズ可能なトップバー

```zsh
zsh ~/Downloads/macOS-config/sketchybar.sh
```

<br>

4. **SKHD**

> Hotkey manager

```zsh
zsh ~/Downloads/macOS-config/skhd.sh
```

<br>

5. **Yabai**

> Window manager for multiple workspaces

```zsh
zsh ~/Downloads/macOS-config/yabai.sh
```

<br>

5. **Iterm**

> ターミナルアプリ

- Oh My Zsh をインストールする
```zsh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"
```
- Oh My Zshのテーマをインストールする

```zsh
git clone https://github.com/romkatv/powerlevel10k.git $ZSH_CUSTOM/themes/powerlevel10k
```
- Iterm2をインストールして設定する

```zsh
zsh ~/Downloads/macOS-config/iterm.sh
```
- zshrcを更新する

```zsh
source ~/.zshrc
```
- Powerlevel10kの設定  
  - スタイル: Lean  
  - 文字セット: Unicode  
  - カラースキーム: 8色  
  - プロンプトセパレーター: なし  
  - レイアウト: 2行  
  - 接続状態: 切断  
  - プロンプト位置: 左  
  - アクセントカラー: 青  
  - プロンプト密度: まばら  
  - アイコンスタイル: 多数のアイコン  
  - プロンプトスタイル: 簡潔  
  - インスタントプロンプト: 有効  
  - 冗長度: 詳細  

- iTerm2の設定  
  - iTerm2を開き、設定に移動。  
    - 一般 -> 閉じる -> 「Quit iTerm2 (CmdQ)」の確認 -> オフ  
    - 外観 -> 一般 -> テーマ: Minimal  
    - 外観 -> 一般 -> 上部バーの位置: 下  
    - 外観 -> ウィンドウ -> スクロールバーを隠す -> オン  
    - 外観 -> ウィンドウ -> タイトルバー下の線を表示 ... -> オフ  
    - 外観 -> ペイン -> 横の余白: 8  
    - 外観 -> ペイン -> 上下の余白: 12  
    - プロファイル -> カラー -> カラープリセット -> インポート -> ダウンロード -> rose-pine.itermcolors  
    - プロファイル -> カラー -> カラープリセット -> rose-pine  
    - プロファイル -> ウィンドウ -> 透明度: 7  
    - プロファイル -> テキスト -> フォント -> MesloLGS NF  
    - プロファイル -> テキスト -> フォントサイズ -> 13  
    - プロファイル -> シェル統合 -> マークインジケーターを表示 -> オフ  

<br>  

6. **壁紙**  

> 私の壁紙の設定  

- システム設定を開く  
  - 壁紙 -> フォルダまたはアルバムを追加 -> フォルダを選択 -> ダウンロード -> macOS-config -> wallpapers

  - ページ下部の壁紙フォルダをクリックします
  - 設定を調整します：
    - シャッフル：毎分
    - すべてのスペースで表示：オン

---

## 📋 ライセンス

このリポジトリに含まれるすべてのコードは、[MITライセンス](LICENSE)の下でライセンスされています

```
MIT License

Copyright (c) 2025 marsdevx

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## ⭐ サポート

このプロジェクトが気に入ったら、⭐ **スター** を付けて **フォロー** してください！  
あなたの **サポート** が、より多くのプロジェクトを生み出す助けになります。🚀  

🔗 **[GitHub](https://github.com/marsdevx?tab=repositories) で私の他の作品もぜひご覧ください。素晴らしいプロジェクトが見つかります！**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-05

---