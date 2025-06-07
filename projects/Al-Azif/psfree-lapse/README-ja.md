# PSFree バージョン 1.5.1

PSFree は、PS4 コンソール向けのエクスプロイト集です。本リポジトリの主な対象は PS4 ですが、PS5 への移植も目指しています。

## 機能

- **自動検出:** コンソールの種類とファームウェアバージョンを自動検出（[`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs) にて）。
- **WebKit エクスプロイト（PSFree）:** コンソールのウェブブラウザ経由でエントリーポイントを提供。
- **カーネルエクスプロイト（Lapse）:** 権限をカーネルレベルに昇格。
- **ペイロードローダー:** カーネルエクスプロイト成功後、ポート 9020 でペイロードの受信を待機。

## 脆弱性の範囲

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## 本リポジトリでサポートされている範囲

この表は、_現行バージョン_ の本リポジトリが動作確認済みのエクスプロイトチェーンを提供するファームウェアバージョンを示します。

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_注: 「脆弱性の範囲」表に記載されている他のファームウェアについては、現在対応作業中の場合や、過去のバージョンでサポートされていた場合があります。過去の対応状況については [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) をご確認ください。_

## TODO リスト

- [ ] 一部ゲームにおけるブラックスクリーン／セーブ問題
- [ ] [`lapse.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/lapse.mjs): JIT 権限のビットのみを設定する
- [ ] [`view.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/view.mjs): PS4 前提、PS5 対応も実装
- [ ] PS5 サポートの追加

## 著作権と著作者

AGPL-3.0-or-later（[LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE) 参照）。このリポジトリは `anonymous` グループに帰属します。匿名の貢献者も「anonymous」として扱います。

## クレジット

- PS4 ファームウェアカーネルダンプの anonymous
- 他の**追加**貢献者については、各ファイルをご確認ください。特に記載がない限り、すべて私たちに帰属します。

## 寄付

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---