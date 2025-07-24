# Mac OS X 设置
面对新机器的设置（或在全新操作系统安装后需要重新安装等情况），这里有一个非常简短且基本的常用清单，主要与设置 Mac 电脑以便工作相关（多与脚本语言环境相关）。

## Homebrew & Cask
包管理器是我总是首先安装的默认工具。只需按照默认步骤操作。Homebrew 会下载并安装 Xcode 的命令行工具，所以一切准备就绪。Homebrew Cask 现作为 Homebrew 的一部分实现，因此我们从一开始就支持 cask，随时准备使用。最后，`brew-cask-upgrade` 为 cask 提供升级功能，一切就绪。
```bash
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
brew tap buo/cask-upgrade
```
## Mac 应用商店  
如果需要包含之前从 Mac 应用商店购买的软件，我们可以使用 `mas` 来简化安装。

```bash
brew install mas
```

## 我精选的应用列表（以及相关内容）
一旦我们安装了 `homebrew`、`cask`（以及必要时的 `mas`），我们就可以开始了（是的，这些列表可能会通过脚本自动安装，大家可以把它看作是一个精选集合）：

### 生产力工具

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

### 浏览器

```bash
# Browsers
brew install arc
brew install google-chrome
brew install brave-browser
brew install firefox
```

### AI 工具

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

### 常用应用

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

### 开发

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