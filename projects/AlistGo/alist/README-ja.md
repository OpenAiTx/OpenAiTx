<div align="center">
  <a href="https://alist.nn.ci"><img width="100px" alt="logo" src="https://cdn.jsdelivr.net/gh/alist-org/logo@main/logo.svg"/></a>
  <p><em>🗂️GinとSolidjsを利用した、マルチストレージ対応のファイルリストプログラム。</em></p>
<div>
  <a href="https://goreportcard.com/report/github.com/alist-org/alist/v3">
    <img src="https://goreportcard.com/badge/github.com/alist-org/alist/v3" alt="latest version" />
  </a>
  <a href="https://github.com/alist-org/alist/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/Xhofe/alist" alt="License" />
  </a>
  <a href="https://github.com/alist-org/alist/actions?query=workflow%3ABuild">
    <img src="https://img.shields.io/github/actions/workflow/status/Xhofe/alist/build.yml?branch=main" alt="Build status" />
  </a>
  <a href="https://github.com/alist-org/alist/releases">
    <img src="https://img.shields.io/github/release/Xhofe/alist" alt="latest version" />
  </a>
  <a title="Crowdin" target="_blank" href="https://crwd.in/alist">
    <img src="https://badges.crowdin.net/alist/localized.svg">
  </a>
</div>
<div>
  <a href="https://github.com/alist-org/alist/discussions">
    <img src="https://img.shields.io/github/discussions/Xhofe/alist?color=%23ED8936" alt="discussions" />
  </a>
  <a href="https://discord.gg/F4ymsH4xv2">
    <img src="https://img.shields.io/discord/1018870125102895134?logo=discord" alt="discussions" />
  </a>
  <a href="https://github.com/alist-org/alist/releases">
    <img src="https://img.shields.io/github/downloads/Xhofe/alist/total?color=%239F7AEA&logo=github" alt="Downloads" />
  </a>
  <a href="https://hub.docker.com/r/xhofe/alist">
    <img src="https://img.shields.io/docker/pulls/xhofe/alist?color=%2348BB78&logo=docker&label=pulls" alt="Downloads" />
  </a>
  <a href="https://alist.nn.ci/guide/sponsor.html">
    <img src="https://img.shields.io/badge/%24-sponsor-F87171.svg" alt="sponsor" />
  </a>
</div>
</div>

---

English | [中文](./README_cn.md) | [日本語](./README_ja.md) | [Contributing](./CONTRIBUTING.md) | [CODE_OF_CONDUCT](./CODE_OF_CONDUCT.md)

## 特徴

- [x] 複数のストレージに対応
    - [x] ローカルストレージ
    - [x] [Aliyundrive](https://www.alipan.com/)
    - [x] OneDrive / Sharepoint ([グローバル](https://www.office.com/), [中国](https://portal.partner.microsoftonline.cn),de,us)
    - [x] [189cloud](https://cloud.189.cn)（個人、ファミリー）
    - [x] [GoogleDrive](https://drive.google.com/)
    - [x] [123pan](https://www.123pan.com/)
    - [x] FTP / SFTP
    - [x] [PikPak](https://www.mypikpak.com/)
    - [x] [S3](https://aws.amazon.com/s3/)
    - [x] [Seafile](https://seafile.com/)
    - [x] [UPYUN Storage Service](https://www.upyun.com/products/file-storage)
    - [x] WebDav（APIなしでOneDrive/SharePointをサポート）
    - [x] Teambition（[中国](https://www.teambition.com/)、[国際](https://us.teambition.com/)）
    - [x] [Mediatrack](https://www.mediatrack.cn/)
    - [x] [139yun](https://yun.139.com/)（個人、ファミリー、グループ）
    - [x] [YandexDisk](https://disk.yandex.com/)
    - [x] [BaiduNetdisk](http://pan.baidu.com/)
    - [x] [Terabox](https://www.terabox.com/main)
    - [x] [UC](https://drive.uc.cn)
    - [x] [Quark](https://pan.quark.cn)
    - [x] [Thunder](https://pan.xunlei.com)
    - [x] [Lanzou](https://www.lanzou.com/)
    - [x] [ILanzou](https://www.ilanzou.com/)
    - [x] [Aliyundrive share](https://www.alipan.com/)
    - [x] [Google photo](https://photos.google.com/)
    - [x] [Mega.nz](https://mega.nz)
    - [x] [Baidu photo](https://photo.baidu.com/)
    - [x] SMB
    - [x] [115](https://115.com/)
    - [X] Cloudreve
    - [x] [Dropbox](https://www.dropbox.com/)
    - [x] [FeijiPan](https://www.feijipan.com/)
    - [x] [dogecloud](https://www.dogecloud.com/product/oss)
    - [x] [Azure Blob Storage](https://azure.microsoft.com/products/storage/blobs)
- [x] 簡単なデプロイとすぐに使える設計
- [x] ファイルプレビュー（PDF、markdown、コード、テキストなど）
- [x] ギャラリーモードでの画像プレビュー
- [x] 動画・音声プレビュー、歌詞・字幕に対応
- [x] Officeドキュメントプレビュー（docx、pptx、xlsxなど）
- [x] `README.md` プレビュー表示
- [x] ファイルのパーマリンクコピーおよび直接ダウンロード
- [x] ダークモード
- [x] I18n対応
- [x] 保護ルート（パスワード保護・認証対応）
- [x] WebDav（詳細は https://alist.nn.ci/guide/webdav.html を参照）
- [x] [Dockerによるデプロイ](https://hub.docker.com/r/xhofe/alist)
- [x] Cloudflare Workers プロキシ
- [x] ファイル・フォルダのパッケージダウンロード
- [x] Webアップロード（訪問者アップロード可）、削除、mkdir、リネーム、移動、コピー
- [x] オフラインダウンロード
- [x] 2つのストレージ間でファイルコピー
- [x] シングルスレッドダウンロード/ストリーミング時のマルチスレッド高速化

## ドキュメント

<https://alistgo.com/>

## デモ

<https://al.nn.ci>

## ディスカッション

一般的な質問は[ディスカッションフォーラム](https://github.com/alist-org/alist/discussions)にてお願いします。**Issueはバグ報告・機能要望のみご利用ください。**

## スポンサー

AListはオープンソースソフトウェアです。このプロジェクトが気に入った方は、ぜひスポンサーや単発のご寄付をご検討ください！ご支援・ご愛顧に感謝します：
https://alist.nn.ci/guide/sponsor.html

### 特別スポンサー

- [VidHub](https://apps.apple.com/app/apple-store/id1659622164?pt=118612019&ct=alist&mt=8) - Appleエコシステムに最適化されたエレガントなクラウド動画プレイヤー。iPhone、iPad、Mac、Apple TV対応。
- [亚洲云](https://www.asiayun.com/aff/QQCOOQKZ) - 高防サーバー|サーバーレンタル|福州高防|広東電信|香港サーバー|米国サーバー|海外サーバー - 国内信頼の企業向けクラウドサービスプロバイダー（中国APIサーバースポンサー）
- [找资源](http://zhaoziyuan2.cc/) - アリ雲ドライブリソース検索エンジン

## 貢献者

素晴らしい貢献者の皆さま、ありがとうございます：

[![Contributors](http://contrib.nn.ci/api?repo=alist-org/alist&repo=alist-org/alist-web&repo=alist-org/docs)](https://github.com/alist-org/alist/graphs/contributors)

## ライセンス

`AList`はAGPL-3.0ライセンスの下で公開されているオープンソースソフトウェアです。

## 免責事項
- 本プログラムは無料・オープンソースプロジェクトです。ネットワークディスク上でのファイル共有とGolang学習の利便性向上を目的としています。ご利用の際は、関連する法律や規則を遵守し、不正利用をしないでください。
- 本プログラムは公式のSDK/インターフェースを利用して実装されており、公式のインターフェース挙動を破壊しません。
- 本プログラムは302リダイレクト/トラフィック転送のみを行い、ユーザーデータの傍受・保存・改ざんは一切行いません。
- 本プログラムの利用により発生する、アカウント凍結・ダウンロード速度制限等のリスクは、利用者ご自身が理解・負担するものとし、本プログラムは一切責任を負いません。
- 万が一権利侵害等がありましたら、[メール](mailto:i@nn.ci)にてご連絡いただければ速やかに対応いたします。

---

> [@GitHub](https://github.com/alist-org) · [@TelegramGroup](https://t.me/alist_chat) · [@Discord](https://discord.gg/F4ymsH4xv2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---