# STAnd aLONE TRAY [![Build][badge-build]][yaml-build] [![Lint][badge-lint]][yaml-lint]

[badge-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml/badge.svg
[yaml-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml
[badge-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml/badge.svg
[yaml-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml

Stalonetrayは、X11ウィンドウシステムを使用するUnixデスクトップ向けのスタンドアロンシステムトレイ（通知領域）です。  
ビルド時および実行時の依存関係は最小限で、XlibとlibXineramaのみですが、よりミニマルにするために後者の機能を無効化することも可能です。Stalonetrayはほぼすべてのウィンドウマネージャーで動作します。

stalonetrayの使用を開始するには、`stalonetrayrc.sample`を`~/.stalonetrayrc`または`$XDG_CONFIG_HOME/stalonetrayrc`にコピーするだけです。  
コメントが豊富に付けられており、素早く始めるには十分です。

一部の機能はデフォルトで無効になっており、stalonetrayのビルド方法によってはすぐには動作しない場合があります。  
必要な機能を有効にして自分でコンパイルしたい場合は、以下の「ソースからのビルド」セクションを参照してください。

## メンテナンス状況

このプロジェクトは元々[Roman Dubtsov (kolbusa)][gh-kolbusa]によって開発され、最近所有権が移りました。Romanは現在も関与していますが、積極的なメンテナンスは行っていません。

**長年このプロジェクトを作成し維持してきたRomanにすべての功績があります。ありがとうございます、Roman！**

[gh-kolbusa]: https://github.com/kolbusa

## インストール

パッケージマネージャーを利用するのがstalonetrayをインストールする最も便利な方法です。  
いくつかのLinuxディストリビューションとBSD系OS向けにパッケージ化されています。DebianおよびUbuntuでは、以下を実行してください：











```sh
sudo apt install stalonetray
```

Fedoraで実行：

```sh
sudo dnf install stalonetray
```

## ソースからのビルド

Stalonetrayは[Meson](https://mesonbuild.com/)を使用します。利用可能なビルドオプションとそのデフォルト値については、`meson.options`ファイルを参照してください。

Mesonを使ってstalonetrayをビルドするには、必要な依存関係がインストールされていることを確認してください
--- デフォルトではXlibとlibXineramaの開発パッケージのみが必要です ---
そして標準的なMesonのビルドコマンドを実行します：


```sh
meson setup builddir
meson compile -C builddir stalonetray
```

これにより、`builddir` ディレクトリに `stalonetray` バイナリがビルドされます。

stalonetray のドキュメントをビルドするには、まず `xsltproc` と DocBook
スタイルシートをインストールする必要があります。次に `manpage` ターゲットをビルドしてください：

```sh
meson compile -C builddir manpage
```

これにより、`builddir` ディレクトリに `stalonetray.1` ファイルが作成されます。

ソースからのインストールは次のように行えます：

```sh
meson install -C builddir
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-11

---