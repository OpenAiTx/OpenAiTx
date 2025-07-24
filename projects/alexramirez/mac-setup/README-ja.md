# Mac OS X セットアップ
新しいマシンのセットアップ時（または新規OSインストール後の再インストールなどの必要がある場合）に、ここではmacコンピュータを作業環境として設定する際によく使う基本的な項目の簡単なリストを示します（主にスクリプト言語の文脈に関連しています）。

## Homebrew & Cask
パッケージマネージャーは、私が最初に必ずインストールするものです。デフォルトの手順に従うだけです。HomebrewはXcodeのコマンドラインツールをダウンロードしてインストールするので問題ありません。Homebrew Caskは現在Homebrewの一部として実装されているので、最初からcask対応しており、すぐに利用可能です。最後に、`brew-cask-upgrade`はcaskにアップグレード機能を提供してくれるので、準備完了です。
```bash
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
brew tap buo/cask-upgrade
```
## Mac App Store
以前にMac App Storeから購入したソフトウェアを含める必要がある場合、インストールを簡単にするために`mas`を使用できます。

```bash
brew install mas
```

## 私の厳選アプリリスト（その他もろもろ）
`homebrew`、`cask`（必要なら`mas`も）を揃えれば準備完了です（そしてはい、これらのリストはすべてインストールを自動化するスクリプト化も可能です。これはあくまで厳選セットとしてご覧ください）：

### 生産性向上用

```bash
# Efficiency booster
brew install alfred

# CloudApp
mas install 417602904

# Slack
brew install slack

# Miro
brew install miro

# Notes & related
mas install 1091189122 #Bear
brew install evernote
brew install notion
brew install obsidian
brew install skitch
brew install typora

# Amphetamine
mas install 937984704

# Bartender
brew install bartender

# Magnet
mas install 441258766
```

### ブラウザ

```bash
# Browsers
brew install arc
brew install google-chrome
brew install brave-browser
brew install firefox
```

### AIツール

```bash
# Anthropic
brew install claude

# OpenAI
brew install chatgpt

# IDEs
brew install cursor
brew install windsurf

# Other models/tools
brew install ollama # DeepSeek, Llama,Llava, etc.
```

### 一般的なアプリケーション

```bash

# Calibre
brew install calibre

# Blog
brew install hugo

# Personal cloud storage
brew install amazon-photos
brew install dropbox

# Gimp
brew install gimp

# Some of the Google stuff
brew install google-drive
brew install google-earth

# Kindle
brew install kindle

# MS
brew install microsoft-office

# Photo editing
brew install adobe-creative-cloud
brew install affinity-designer
brew install affinity-photo

# Spotify
brew install spotify

# Shazam
mas install 897118787

# Twitter
mas install 409789998

# The Unarchiver
brew install the-unarchiver

# VLC
brew install vlc

# Videoconference
brew install microsoft-teams
brew install webex
brew install zoom
brew install krisp

# Messaging
brew install telegram
brew install whatsapp
```

### 開発

```bash
# A good terminal
brew install iterm2
brew install jq
brew install zsh zsh-completions zsh-syntax-highlighting zsh-autosuggestions
# And definitely check plugins, templates, themes, etc. at:
# https://github.com/robbyrussell/oh-my-zsh
brew install tree
brew install wget
brew install tldr
brew install thefuck

# Go2Shell
brew install go2shell

# Shuttle
brew install shuttle 

# AWS CLI
brew install awscli

# API development
brew install rapidapi
brew install postman

# Text editors/IDEs
brew install textmate
brew install sublime-text
brew install brackets
brew install atom
brew install visual-studio-code

# Charles proxy
brew install charles

# Dash
brew install dash

# Docker
brew install docker
brew install kitematic

# ES
brew install elasticsearch

# Gas Mask
brew install gas-mask

# Git-related
brew install rowanj-gitx
brew install sourcetree
brew install tower

# Gradle
brew install gradle

# GoLang
brew install go

# JS
brew install node
brew install yarn

# Ngrok
brew install ngrok

# Python
brew install python
brew install python3
brew install pyenv
brew install anaconda

# DevOps
brew install vagrant
brew install virtualbox
brew install packer
brew install terraform
brew install vault

# Cloud storage and related
brew install cyberduck

# JetBrains
brew install phpstorm
brew install pycharm
brew install rubymine
brew install intellij-idea
brew install webstorm

# PHP & related
brew install composer

# Databases
brew install sequel-ace # Alternative to sequel-pro 

# VPN
brew install nordvpn
brew install tunnelblick
brew install cloudflare-warp

# Xcode. Will take forever to download, yes. Not needed by everyone.
mas install 497799835
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---