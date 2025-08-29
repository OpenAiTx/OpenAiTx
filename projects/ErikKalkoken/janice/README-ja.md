# Janice

大きなJSONファイルを閲覧するためのデスクトップアプリ。

[![GitHub Release](https://img.shields.io/github/v/release/ErikKalkoken/janice)](https://github.com/ErikKalkoken/janice)
[![Fyne](https://img.shields.io/badge/dynamic/regex?url=https%3A%2F%2Fgithub.com%2FErikKalkoken%2Fjanice%2Fblob%2Fmain%2Fgo.mod&search=fyne%5C.io%5C%2Ffyne%5C%2Fv2%20(v%5Cd*%5C.%5Cd*%5C.%5Cd*)&replace=%241&label=Fyne&cacheSeconds=https%3A%2F%2Fgithub.com%2Ffyne-io%2Ffyne)](https://github.com/fyne-io/fyne)
[![build status](https://github.com/ErikKalkoken/janice/actions/workflows/ci-cd.yml/badge.svg)](https://github.com/ErikKalkoken/janice/actions/workflows/ci-cd.yml)
[![codecov](https://codecov.io/gh/ErikKalkoken/janice/graph/badge.svg?token=nei6PLRXrD)](https://codecov.io/gh/ErikKalkoken/janice)
[![GitHub License](https://img.shields.io/github/license/ErikKalkoken/janice)](https://github.com/ErikKalkoken/janice)
[![GitHub Downloads (all assets, all releases)](https://img.shields.io/github/downloads/ErikKalkoken/janice/total)](https://github.com/ErikKalkoken/janice/releases)

[![download](https://github.com/user-attachments/assets/c8de336f-8c42-4501-86bb-dbc9c66db1f0)](https://github.com/ErikKalkoken/janice/releases/latest)

## 目次

- [説明](#description)
- [スクリーンショット](#screenshots)
- [起動方法](#how-to-run)
- [よくある質問](#faq)
- [帰属](#attributions)

## 説明

Janiceは大きなJSONファイルを閲覧するためのデスクトップアプリです。主な特徴は次の通りです:

- クラシックなツリー構造でJSONドキュメントを閲覧
- ファイルダイアログ、クリップボード、ウィンドウへのドロップ、コマンドライン引数からJSONファイルを開ける
- 非常に大きなJSONファイル（>100MB、>1000万要素）に対応
- ドキュメント内のキーや値を検索。ワイルドカード対応
- JSONファイルの一部を新しいファイルまたはクリップボードへエクスポート
- 値をクリップボードにコピー
- 単一の実行ファイル、インストール不要
- Windows、Linux、macOSで動作するデスクトップアプリ
- 自動でダークテーマとライトテーマを切り替え

## スクリーンショット

### ライトテーマ

![light](https://cdn.imgpile.com/f/0IrYBjJ_xl.png)
### ダークテーマ

![dark](https://cdn.imgpile.com/f/bdQBc3q_xl.png)

## 実行方法

Janiceを実行するには、最新リリースをダウンロードして解凍するだけです。Janiceは単一の実行可能ファイルとして提供されており、直接実行できます。最新のパッケージは[リリースページ](https://github.com/ErikKalkoken/janice/releases)からダウンロードできます。

### Linux

Linuxデスクトップへのインストールには2つのバリアントを提供しています：

- AppImage: AppImageバリアントはインストールやroot権限を必要とせず、実行ファイルから直接アプリを実行できます。
- Tarball: tarファイルはインストールが必要ですが、デスクトップ環境にアプリを統合することが可能です。tarballは異なるLinuxバージョン間での互換性も広いです。

#### AppImage

> [!NOTE]
> アプリは[AppImage](https://appimage.org/)形式で提供されているため、インストール不要で多くのLinuxディストリビューション上で実行可能です。

1. リリースページから最新のAppImageファイルをダウンロードし、実行可能にします。
1. 実行してアプリを起動します。

> [!TIP]
> 以下のエラーが出る場合：`AppImages require FUSE to run.`、まずシステムにFUSEをインストールする必要があります。これはすべてのAppImageが動作するために必要なライブラリです。詳細は[こちらのページ](https://docs.appimage.org/user-guide/troubleshooting/fuse.html#the-appimage-tells-me-it-needs-fuse-to-run)をご覧ください。

#### Tarball

1. リリースページから最新のtarファイルをダウンロードします。
1. 例えば `tar xf janice-0.12.3-linux-amd64.tar.xz` のようにtarファイルを解凍します。
1. 現在のユーザー用にインストールするには `make user-install` を実行、システム全体にインストールするには `sudo make install` を実行します。

これでデスクトップ環境のランチャーにアプリ起動用のショートカットが作成されているはずです。

アンインストールするには、インストール方法に応じて `make user-uninstall` または `sudo make uninstall` を実行してください。

### Windows

1. Githubの最新リリースからWindows用のzipファイルをダウンロードします。

1. ファイルを任意のディレクトリに解凍し、.exeファイルを実行してアプリを起動します。

### Mac OS

1. Githubの最新リリースから、該当プラットフォーム（armまたはintel）用のdarwin zipファイルをダウンロードします。
1. ファイルを任意のディレクトリに解凍します。
1. .appファイルを実行してアプリを起動します。

> [!TIP]
> MacOSは、このアプリをAppleの証明書で署名されていないため「破損している」と誤って報告する場合があります。ターミナルを開き、以下のコマンドを実行することでこのエラーを解除できます。詳細は[ Fyneトラブルシューティング](https://docs.fyne.io/faq/troubleshoot#distribution)をご覧ください：
>
> ```sudo xattr -r -d com.apple.quarantine Janice.app```

### リポジトリからビルドして実行する

システムが[Fyne](https://fyne.io/)アプリのビルドに対応している場合、以下のコマンドでリポジトリから直接ビルドおよび実行が可能です：

```sh
go run github.com/ErikKalkoken/janice@latest
```

Fyneのシステム設定についての詳細は、こちらをご覧ください: [Getting Started](https://docs.fyne.io/started/)。

## FAQ

### ロードできる最大のJSONファイルサイズはどれくらいですか？

ロード可能な最大のJSONファイルサイズは、主に搭載されているRAMの容量と特定のJSONファイルによります。メモリ消費量の主な要因は、JSONドキュメント内の要素数です。

比較のために、当社の開発者ノートパソコンでロードテストを行いました。RAMは8GBで、Ubuntu 22.04 LTSを実行しています。最大で4500万要素のJSONファイルを正常にロードできました。テストファイルのサイズは約2.5GBでした。

### JSONファイルはフォーマットされていますか？

はい。JSONドキュメントはツリー形式で表示され、キーはアルファベット順に並べられます。

## 謝辞

- [Jsonアイコン 作成者 LAB Design Studio - Flaticon](https://www.flaticon.com/free-icons/json)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---