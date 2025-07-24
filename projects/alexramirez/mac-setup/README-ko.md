# Mac OS X 설정
새로운 기기 설정(또는 새 OS 설치 후 재설치 필요 시 등)을 마주할 때, 주로 사용하는 맥 컴퓨터 설정과 관련된 매우 간단하고 기본적인 목록입니다(대부분 스크립팅 언어 환경과 관련됨).

## Homebrew & Cask
패키지 관리자는 항상 가장 먼저 설치하는 기본 항목입니다. 기본 절차를 따라 설치합니다. Homebrew는 Xcode용 명령줄 도구를 다운로드하고 설치하므로 문제없습니다. Homebrew Cask는 이제 Homebrew의 일부로 구현되어 있어, 처음부터 Cask가 활성화되어 탭핑 준비가 완료된 상태입니다. 마지막으로, `brew-cask-upgrade`는 Cask에 업그레이드 기능을 제공하므로 모든 준비가 완료됩니다.
```bash
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
brew tap buo/cask-upgrade
```
## Mac App Store
이전에 Mac App Store에서 구매한 소프트웨어를 포함해야 하는 경우, `mas`를 사용하여 설치를 쉽게 할 수 있습니다.

```bash
brew install mas
```
## 내가 엄선한 앱 목록 (그리고 기타 등등)
`homebrew`, `cask` (필요시 `mas`도) 가 준비되면 우리는 시작할 준비가 된 것입니다 (그리고 네, 이 목록들은 모두 설치 자동화를 위해 스크립트화될 수도 있으니, 단지 엄선된 세트로 봐주세요):

### 생산성


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
### 브라우저


```bash
# Browsers
brew install arc
brew install google-chrome
brew install brave-browser
brew install firefox
```

### AI 도구

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

### 일반 앱

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

### 개발

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