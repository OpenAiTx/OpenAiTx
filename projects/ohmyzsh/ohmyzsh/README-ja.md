<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zshは、あなたの[zsh](https://www.zsh.org/)設定を管理するためのオープンソースでコミュニティ主導のフレームワークです。

つまらなそうですね。もう一度やり直しましょう。

**Oh My Zshはあなたを10倍の開発者にはしません...しかし、そう感じるかもしれません。**

インストールすると、あなたのターミナルシェルは町中の噂になるでしょう _もしそうならなければ返金します！_ コマンドプロンプトでキーを押すたびに、数百の強力なプラグインや美しいテーマを活用できます。
カフェで見知らぬ人があなたに近づいてきて、こう尋ねるでしょう _「すごいですね！あなたは何かの天才ですか？」_

ついに、あなたがずっと受けるべきだと感じていた注目を得始めるでしょう。...あるいは、節約できた時間でデンタルフロスをもっと頻繁に使い始めるかもしれません。😬

詳細は[ohmyz.sh](https://ohmyz.sh)をご覧ください。[X（旧Twitter）@ohmyzsh](https://x.com/ohmyzsh)をフォローし、[Discord](https://discord.gg/ohmyzsh)にもご参加ください。

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>目次</summary>

- [はじめに](#getting-started)
  - [対応OS](#operating-system-compatibility)
  - [前提条件](#prerequisites)
  - [基本インストール](#basic-installation)
    - [手動確認](#manual-inspection)
- [Oh My Zshの使い方](#using-oh-my-zsh)
  - [プラグイン](#plugins)
    - [プラグインの有効化](#enabling-plugins)
    - [プラグインの使用](#using-plugins)
  - [テーマ](#themes)
    - [テーマの選択](#selecting-a-theme)
  - [FAQ](#faq)
- [上級トピック](#advanced-topics)
  - [高度なインストール](#advanced-installation)
    - [カスタムディレクトリ](#custom-directory)
    - [無人インストール](#unattended-install)
    - [フォークリポジトリからのインストール](#installing-from-a-forked-repository)
    - [手動インストール](#manual-installation)
  - [インストールの問題](#installation-problems)
  - [カスタムプラグインとテーマ](#custom-plugins-and-themes)
  - [macOSおよびfreeBSDでのGNU lsの有効化](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [エイリアスのスキップ](#skip-aliases)
  - [非同期gitプロンプト](#async-git-prompt)
- [アップデートの取得](#getting-updates)
  - [アップデートの詳細度](#updates-verbosity)
  - [手動アップデート](#manual-updates)
- [Oh My Zshのアンインストール](#uninstalling-oh-my-zsh)
- [Oh My Zshへの貢献方法](#how-do-i-contribute-to-oh-my-zsh)
  - [テーマの送付はご遠慮ください](#do-not-send-us-themes)
- [貢献者](#contributors)
- [フォロー](#follow-us)
- [グッズ](#merchandise)
- [ライセンス](#license)
- [Planet Argonについて](#about-planet-argon)

</details>

## はじめに

### 対応OS

| O/S            | 状態 |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### 前提条件

- [Zsh](https://www.zsh.org)がインストールされていること（v4.3.9以上であれば動作しますが、5.0.8以上を推奨）。プレインストールされていない場合（`zsh --version`で確認）、以下のWikiを参照してください: [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl`または`wget`がインストールされていること
- `git`がインストールされていること（v2.4.11以上を推奨）

### 基本インストール

Oh My Zshは、以下のいずれかのコマンドをターミナルで実行することでインストールできます。`curl`、`wget`または他の類似ツールでコマンドラインからインストール可能です。

| 方法    | コマンド                                                                                           |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

また、インストーラーはGitHub以外にもミラーされています。中国やインドなどの一部ISPで`raw.githubusercontent.com`がブロックされている場合は、以下のURLの使用が必要になる場合があります。

| 方法    | コマンド                                           |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_以前の`.zshrc`は`.zshrc.pre-oh-my-zsh`へリネームされます。インストール後、保持したい設定を新しい`.zshrc`に移動できます。_

#### 手動確認

知らないプロジェクトのインストールスクリプトは、事前に確認するのが良いでしょう。まずインストールスクリプトをダウンロードし、中身をチェックして問題なければ実行します。

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

上記URLでタイムアウトや失敗する場合は、`https://install.ohmyz.sh`にURLを差し替えてください。

## Oh My Zshの使い方

### プラグイン

Oh My Zshには大量のプラグインが付属しています。[plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins)ディレクトリや[wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins)で利用可能なプラグインを確認できます。

#### プラグインの有効化

Oh My Zshで使いたいプラグインを見つけたら、`.zshrc`ファイルで有効化します。zshrcファイルは`$HOME`ディレクトリにあります。お好きなテキストエディタで開き、ロードしたいプラグインをリストアップする箇所を編集します。

```sh
vi ~/.zshrc
```

例として、以下のようになります。

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

_プラグインは空白（スペース、タブ、改行など）で区切ります。**カンマを使わないでください。壊れます。**_

#### プラグインの使用

各組み込みプラグインには**README**が付属しており、プラグインで追加されるエイリアスやその他の機能が説明されています。

### テーマ

正直に言うと、Oh My Zsh初期はテーマに少し夢中になりすぎました。現在、150以上のテーマが同梱されています。その多くは[wikiのスクリーンショット](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes)で確認できます（現在更新中です）。ぜひご覧ください！

#### テーマの選択

_Robbyのテーマがデフォルトです。最も派手でも、最もシンプルでもありませんが、（彼にとって）ちょうどいいものです。_

使いたいテーマを見つけたら、`~/.zshrc`ファイルを編集します。全て大文字の環境変数があり、以下のようになっています。

```sh
ZSH_THEME="robbyrussell"
```

別のテーマを使いたい場合は、値を希望するテーマ名に変更します。例：

```sh
ZSH_THEME="agnoster" # （これは派手なテーマの一つです）
# https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster 参照
```

<!-- prettier-ignore-start -->
> [!NOTE]
> zshテーマのスクリーンショットを見て試してみても、同じように表示されないことがあります。
>
> 多くのテーマは正しく表示するために[Powerline Font](https://github.com/powerline/fonts)や
> [Nerd Font](https://github.com/ryanoasis/nerd-fonts)のインストールが必要です。これらがないと、テーマのプロンプト記号が正しく表示されません。詳細は
> [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt)をご覧ください。
>
> また、テーマはプロンプト（コマンド入力前後のテキスト）の表示のみに影響し、ターミナルウィンドウの色（カラースキーム）やフォントは制御しません。これらはターミナルエミュレータの設定で変更できます。詳細は
> [zshテーマとは](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme)を参照してください。
<!-- prettier-ignore-end -->

新しいターミナルウィンドウを開くと、プロンプトが以下のように表示されるはずです。

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

ニーズに合うテーマが見つからない場合は[さらに多くのテーマ](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes)をwikiでご覧ください。

気分で毎回ランダムなテーマを選びたい場合は、以下のように設定できます。

```sh
ZSH_THEME="random" # （...どうかpieテーマになりますように...）
```

お気に入りテーマのリストからランダムに選びたい場合：

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

嫌いなテーマだけをリストから除外したい場合は、以下のように設定できます。

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

質問や問題がある場合は、[FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ)に解決策があるかもしれません。

## 上級トピック

より詳細な設定やカスタマイズがしたい方はこちらをご覧ください。

### 高度なインストール

一部ユーザーはOh My Zshを手動でインストールしたり、デフォルトパスやインストーラーが受け付けるその他の設定を変更したい場合があります（これらの設定はインストールスクリプト冒頭にも記載されています）。

#### カスタムディレクトリ

デフォルトのインストール場所は`~/.oh-my-zsh`（ホームディレクトリ内の隠しディレクトリ、`cd ~/.oh-my-zsh`でアクセス可能）です。

インストールディレクトリを`ZSH`環境変数で変更したい場合、インストール前に`export ZSH=/your/path`を実行するか、以下のようにインストールパイプラインの最後で指定できます。

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### 無人インストール

自動化されたインストールの一部としてOh My Zshインストールスクリプトを実行する場合、`install.sh`スクリプトに`--unattended`フラグを渡せます。これによりデフォルトシェルの変更やインストール後の`zsh`起動を行いません。

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

中国、インドなど`raw.githubusercontent.com`がブロックされている国では、URLを`https://install.ohmyz.sh`に差し替えてください。

#### フォークリポジトリからのインストール

インストールスクリプトは、以下の変数を受け付けることで、異なるリポジトリからのインストールを可能にしています。

- `REPO`（デフォルト: `ohmyzsh/ohmyzsh`）：`owner/repository`形式。設定すると`https://github.com/{owner}/{repository}`からリポジトリを探します。

- `REMOTE`（デフォルト: `https://github.com/${REPO}.git`）：gitリポジトリのクローン用フルURL。GitHub以外（GitLab、Bitbucket等）からインストールしたい場合やHTTPSではなくSSH（`git@github.com:user/project.git`）でクローンしたい場合に利用します。
  
  _注: `REPO`変数との併用はできません。REMOTEが優先されます。_

- `BRANCH`（デフォルト: `master`）：クローン時にチェックアウトするデフォルトブランチを変更したい場合に利用します。プルリクエストのテストや、`master`以外のブランチ使用時に便利です。

例：

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### 手動インストール

##### 1. リポジトリをクローン <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. 既存の`~/.zshrc`をバックアップ（任意） <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. 新しいZsh設定ファイルを作成 <!-- omit in toc -->

テンプレートをコピーして新しいzsh設定ファイルを作成できます。

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. デフォルトシェルを変更 <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

ユーザーセッションから一度ログアウトし、再度ログインしてください。

##### 5. 新しいZsh設定を初期化 <!-- omit in toc -->

新しいターミナルウィンドウを開くと、Oh My Zshの設定が読み込まれます。

### インストールの問題

インストール時に問題が発生した場合、以下のよくある対処法をお試しください。

- Oh My Zshに切り替えた後、一部コマンドが見つからない場合は`~/.zshrc`内の`PATH`を修正する必要があるかもしれません。
- 手動でインストールした場合やインストール先を変更した場合は、`~/.zshrc`内の`ZSH`環境変数を確認してください。

### カスタムプラグインとテーマ

デフォルト動作を上書きしたい場合は、`custom/`ディレクトリに`.zsh`で終わる新しいファイルを追加してください。

複数の関数をまとめたい場合は、`custom/plugins/`ディレクトリに`XYZ.plugin.zsh`というファイル名で保存し、このプラグインを有効化できます。

配布されているプラグインの機能を上書きしたい場合は、同名のプラグインを`custom/plugins/`ディレクトリに作成すると、`plugins/`内のものより優先的に読み込まれます。

### macOSおよびfreeBSDでのGNU lsの有効化

<a name="enable-gnu-ls"></a>

Oh My Zshのデフォルト動作では、macOSおよびFreeBSDシステムでBSD版`ls`が使用されます。GNU版`ls`（`gls`コマンド）がインストールされている場合は、以下のzstyle設定を`oh-my-zsh.sh`を読み込む前に追加することで利用できます。

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_注：`DISABLE_LS_COLORS=true`との併用はできません。_

### エイリアスのスキップ

<a name="remove-directories-aliases"></a>

Oh My Zshのデフォルトエイリアス（`lib/*`ファイルで定義）やプラグインのエイリアスをスキップしたい場合は、**Oh My Zshを読み込む前**に`~/.zshrc`ファイルで以下の設定を利用できます。ニーズに応じて様々な方法があります。

```sh
# libファイルと有効なプラグインすべてのエイリアスをスキップ
zstyle ':omz:*' aliases no

# libファイルのエイリアスのみをスキップ
zstyle ':omz:lib:*' aliases no
# directories.zsh libファイルで定義されたエイリアスのみをスキップ
zstyle ':omz:lib:directories' aliases no

# プラグインのエイリアス全てをスキップ
zstyle ':omz:plugins:*' aliases no
# gitプラグインのエイリアスのみをスキップ
zstyle ':omz:plugins:git' aliases no
```

より詳細に、以下のように組み合わせて使うことも可能です（より具体的なスコープが優先されます）。

```sh
# プラグインのエイリアスは全てスキップ、ただしgitプラグインは有効
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

以前のバージョンでは下記の設定が使われていましたが、現在は廃止されています。

```sh
zstyle ':omz:directories' aliases no
```

代わりに以下を使用してください。

```sh
zstyle ':omz:lib:directories' aliases no
```

#### 注意 <!-- omit in toc -->

> この機能は現在テスト段階であり、将来的に変更される可能性があります。また、zpmやzinitなどのプラグインマネージャーではinitスクリプト（`oh-my-zsh.sh`）をソースしないため、現時点では非対応です。

> また、関数として定義されている「エイリアス」（例：gitプラグインの`gccd`、`ggf`、`ggl`など）には対応していません。

### 非同期gitプロンプト

非同期プロンプト機能は実験的なもので（2024年4月3日追加）、Oh My Zshがプロンプト情報を非同期で描画できるようにします。これによりプロンプト描画のパフォーマンスが向上しますが、一部環境では正常に動作しない場合があります。問題が発生した場合は、Oh My Zshをソースする前に以下の設定で無効化できます。

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

gitプロンプトが表示されなくなった場合は、以下を設定して強制的に表示させることもできます。もしそれでも動作しない場合は、issueを立ててください。

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## アップデートの取得

デフォルトでは、2週間ごとにアップデート確認を促されます。`~/.zshrc`ファイルで**Oh My Zshを読み込む前**に以下の設定を追加することで、アップデートモードを変更できます。

1. 自動アップデート（確認プロンプトなし）:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. アップデートがある場合のみ数日に一度リマインダー表示:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. 自動アップデートを完全に無効化:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

注: Oh My Zshのアップデート確認頻度は以下の設定で制御できます。

```sh
# 7日ごとにアップデート確認
zstyle ':omz:update' frequency 7
# ターミナルを開くたびに確認（非推奨）
zstyle ':omz:update' frequency 0
```

### アップデートの詳細度

以下の設定でアップデート時の詳細度を変更できます。

```sh
zstyle ':omz:update' verbose default # デフォルトのアップデートプロンプト

zstyle ':omz:update' verbose minimal # 最小限の表示

zstyle ':omz:update' verbose silent # エラーのみ表示
```

### 手動アップデート

任意のタイミングでアップデートしたい場合（新しいプラグインがリリースされたときなど）、以下を実行してください。

```sh
omz update
```

> [!NOTE]
> スクリプトで自動化したい場合は、直接`upgrade`スクリプトを呼び出してください。
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> 詳細は[FAQ: Oh My Zshをどうやってアップデートするの？](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh)を参照してください。
>
> **`omz update --unattended`の利用は副作用があるため廃止されました。**

マジック！🎉

## Oh My Zshのアンインストール

Oh My Zshが合わない方もいるでしょう。寂しいですが、簡単にアンインストールできるようにしています。

`oh-my-zsh`をアンインストールするには、コマンドラインで`uninstall_oh_my_zsh`を実行してください。これにより自身を削除し、以前の`bash`または`zsh`設定に戻します。

## Oh My Zshへの貢献方法

コミュニティに参加する前に、[行動規範](CODE_OF_CONDUCT.md)をお読みください。

私は[Zsh](https://www.zsh.org/)のエキスパートではありませんし、もっと改善できる点が多いと思っています。設定の保守性や速度向上のアイデアがあれば、ぜひフォークしてプルリクエストを送ってください！

プルリクエストのテストをしてくださる方も必要です。[オープンな課題](https://github.com/ohmyzsh/ohmyzsh/issues)を見て、ぜひご協力ください。

詳細は[Contributing](CONTRIBUTING.md)をご覧ください。

### テーマの送付はご遠慮ください

（しばらくは）テーマは十分に揃っています。新しいテーマは[外部テーマ](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes)wikiページに追加してください。

## 貢献者

Oh My Zshは多くのユーザーと素晴らしい貢献者によって支えられています。皆さんの時間と協力がなければ、ここまで素晴らしいものにはなりませんでした。

本当にありがとうございます！

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## フォロー

SNSでも情報発信中です：

- X（旧Twitter）の [@ohmyzsh](https://x.com/ohmyzsh)。ぜひフォローしてください。
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) で声をかけてください。
- [Instagram](https://www.instagram.com/_ohmyzsh/) でOh My Zshを使っている写真をタグ付けしてください！
- [Discord](https://discord.gg/ohmyzsh) でチャットしましょう！

## グッズ

[ステッカー、Tシャツ、マグカップなど](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github)でOh My Zshへの愛をアピールできます。あなたも町の話題になること間違いなし！

## ライセンス

Oh My Zshは[MITライセンス](LICENSE.txt)で公開されています。

## Planet Argonについて

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zshは[Planet Argon](https://www.planetargon.com/?utm_source=github)チームによって始められました。
[Ruby on Rails開発エージェンシー](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github)です。
[他のオープンソースプロジェクト](https://www.planetargon.com/open-source?utm_source=github)もご覧ください。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---