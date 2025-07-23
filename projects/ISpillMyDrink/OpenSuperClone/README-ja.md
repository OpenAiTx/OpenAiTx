<h1 align="center">
  <br>
  OpenSuperClone
  <br>
</h1>

<div align="center">

  [![Commits](https://badgen.net/github/commits/ispillmydrink/opensuperclone/main)](https://github.com/ISpillMyDrink/OpenSuperClone/commits/main)
  [![Last Commit](https://badgen.net/github/last-commit/ispillmydrink/opensuperclone/main)](https://github.com/ISpillMyDrink/OpenSuperClone/commits/main)
  [![Release](https://badgen.net/github/release/ispillmydrink/opensuperclone)](https://github.com/ISpillMyDrink/OpenSuperClone/releases)
  [![License](https://badgen.net/github/license/ispillmydrink/opensuperclone)](https://github.com/ISpillMyDrink/OpenSuperClone/blob/main/LICENSE)
  
</div>

<h4 align="center">
  <a href="https://www.hddsuperclone.com/">Scott DwyerのHDDSuperClone</a>をベースにした多くの高度な機能を備えたLinux向けの強力なデータ復旧ユーティリティです。
</h4>

<p align="center">
  <a href="#-features">✨ 機能</a> •
  <a href="#-installation">💾 インストール</a> •
  <a href="#-documentation">📖 ドキュメント</a> •
  <a href="#%EF%B8%8F-changelog">✏️ 更新履歴</a> •
  <a href="#-credits">💵 クレジット</a> •
  <a href="#-license">📄 ライセンス</a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/ISpillMyDrink/OpenSuperClone/main/./doc/opensuperclone.gif" alt="Size Limit CLI" width="738">
</p>

## ✨ 機能

* ddrescueに匹敵する高度なドライブ<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Clone-Mode">クローン</a>機能
* ターゲットデータ抽出用の<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Virtual-Disk-Mode">仮想ディスクモード</a>
* OSドライバを回避する<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Direct-Modes">直接AHCI/IDE</a>機能
* ドライブの自動電源サイクル用<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Relay-Operation">USBリレー制御</a>

#### 📋 予定されている変更

予定されている変更の一覧は<a href="https://github.com/users/ISpillMyDrink/projects/2">ロードマップ</a>をご覧ください。

## 💾 インストール

OpenSuperCloneの事前ビルド済みDEBおよびRPMパッケージは<a href=https://github.com/ISpillMyDrink/OpenSuperClone/releases>リリース</a>ページにあります。

ソースからOpenSuperCloneをインストールする手順は<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki/Compiling-from-Source">Wiki</a>にあります。

また、OpenSuperCloneをインストールする代わりに、<a href="https://sourceforge.net/projects/opensuperclone-live/">Linux Live ISO</a>が<a href="https://sourceforge.net/u/xak77/profile/">xak77</a>によって提供されています。

## 📖 ドキュメント

OpenSuperCloneのドキュメントは<a href="https://github.com/ISpillMyDrink/OpenSuperClone/wiki">Wiki</a>にあります。
Wikiは現在作業中で未完成であることに注意してください。

## ✏️ 更新履歴

#### OpenSuperClone 2.5.1（作業中）

* OSCDriver 2.6.7: カーネル6.14.0までのサポートを追加（<a href="https://github.com/ISpillMyDrink/OpenSuperClone/pull/25">piernov</a>に感謝）

#### OpenSuperClone 2.5

* ドライバーインストールのためDKMSを実装
* OSCDriver 2.6.6: カーネル6.11.0までのサポートを追加（<a href="https://github.com/ISpillMyDrink/OpenSuperClone/pull/19">piernov</a>に感謝）
* USBマスストレージドライバーの無効化がUSB Attached SCSIドライバーの無効化も行うように変更
* ほとんどのコントロールにツールチップを追加し、SMART、解析、識別ビューを改善するなどのUI改善
* いくつかの既知のSMART属性と識別フラグを追加
* 最大リトライ回数を8から1000に増加（SSDの復旧に有用）

#### OpenSuperClone 2.4.1

* UIラベルに誤った文字列が表示されるバグを修正

#### OpenSuperClone 2.4

* ライセンス関連コードの削除
* ビルドシステムにCMakeを導入
* GTK2からGTK3に移行
* ローカリゼーションシステムをgettextに置換
* OSCDriver 2.6.1: カーネル5.19.11までのサポートを追加（<a href="https://github.com/piernov/">piernov</a>に感謝）
* OSCViewerの小さな改善（カラーピッカー、軽微なグラフィカル変更）

## 💵 クレジット

このプロジェクトは<a href="https://www.hddsuperclone.com/">HDDSuperClone</a>の優れた作業を行ったScott Dwyerと、カーネルモジュール更新のために尽力した<a href="https://github.com/piernov/">piernov</a>に感謝します。

本プロジェクトは以下のライブラリ/プログラムを使用しています：
* GLADE (https://glade.gnome.org/)
* GTK (https://www.gtk.org/)
* libconfig (https://hyperrealm.github.io/libconfig/)
* libintl (https://www.gnu.org/software/gettext/)
* libusb (https://libusb.info/)
* Font Awesome (https://fontawesome.com/)

## 📄 ライセンス

このソフトウェアは[GPLv2](LICENSE)の下でライセンスされています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---