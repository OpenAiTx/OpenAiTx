# イーサリアムステーキングガイド #

## はじめに ##

ようこそ！

イーサリアムネットワーク上でのステーキングの**ゴールドスタンダード**であるソロステーカーになりたいなら、これらのガイドが役立ちます！

必要なのは、Ubuntu（22.04 LTS以降）を実行するマシンで、最新のCPU、16GBのRAM（32GBが望ましい）、高品質の2TB SSD（4TBが望ましい）です。

始めるには、以下の[**メインネットステーキングガイド**](https://github.com/SomerEsat/ethereum-staking-guides#mainnet-staking-guides)のいずれかにアクセスしてください。

どのクライアントを使うか迷ったら、シェアが最も低いものを選んでください。こちらをご覧ください：https://clientdiversity.org。以下のガイドは主要な**コンセンサスクライアント**（Lighthouse、Lodestar、Prysm、Nimbus、Teku）に基づいて名前が付けられているので、まずそれを選択する必要があります。各ガイドには、ステーキングに必要な**実行クライアント**のインストール手順も含まれています。こちらもシェアが最も低いものを選ぶことを推奨します。

最後に、メインネットでのバリデーション開始にキューがある場合があります。こちらで確認してください：https://validator-queue-monitoring.vercel.app。

Somer Esat

<br/>

## メインネットステーキングガイド ##

イーサリアムメインネットでのステーキングにこれらのガイドを使用してください。

| ガイド <img width=150/> | 変更履歴 *(日-月-年)* <img width=450/> |
| :--------- | :---------- |
| [Lighthouse](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-lighthouse-773f5d982e03) | <br> *20-08-24* - Reth実行クライアントを追加。 <br> *18-08-24* - Lighthouseクライアントを5.3.0に更新。 <br> *19-06-24* - Lighthouseクライアントを5.2.0に更新。 <br> *18-06-24* - Besuクライアントを24.5.4に更新。 <br> *09-06-24* - Nethermind設定にプルーニングフラグを追加。 <br> *09-06-24* - Nethermind設定からSync.AncientBodies/Receiptsフラグを削除。 <br> *09-06-24* - Nethermindクライアントを1.26.0に更新。 <br> *09-06-24* - Gethクライアントを1.14.5に更新。 <br> *09-06-24* - Erigonクライアントを2.6.1に更新。 <br> *02-06-24* - Erigonクライアントを2.6.0に更新。 <br> *02-06-24* - [Issue 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)に基づき、Erigonの非推奨設定フラグ--externalclを削除。 <br> *02-06-24* - Erigon設定をプリビルトバイナリ使用に更新。 <br> *02-06-24* - 冗長なErigonの前提条件を削除。 <br> *30-05-24* - Besuクライアントを24.5.2に更新し、Besu設定フラグセクションのリンク切れを修正。 <br> *30-05-24* - [#6405](https://github.com/hyperledger/besu/pull/6405)に従い、Besu設定でX_SNAPをSNAPに名称変更。 <br> *30-05-24* - Besuの前提条件をJava Runtime v21（ヘッドレス）に更新。 <br> *14-04-24* - 目次を追加。 <br> *14-04-24* - Ubuntuサーバーバージョンを22.04に引き上げ。 <br> [変更履歴アーカイブ](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md)を参照。 |
| [Lodestar](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-lodestar-193a2553a161) | <br> *20-08-24* - Reth実行クライアントを追加。 <br> *11-08-24* - Lodestarリリースへのリンク誤りを修正。 <br> *18-06-24* - 冗長なLodestar前提条件（NodeJSおよびbuild-essential）を削除。 <br> *18-06-24* - Lodestar設定をプリビルトバイナリ使用に更新。 <br> *18-06-24* - Lodestarクライアントを1.19.0に更新。 <br> *18-06-24* - Besuクライアントを24.5.4に更新。 <br> *18-06-24* - Nethermind設定にプルーニングフラグを追加。 <br> *18-06-24* - Nethermind設定からSync.AncientBodies/Receiptsフラグを削除。 <br> *18-06-24* - Nethermindクライアントを1.26.0に更新。 <br> *18-06-24* - Gethクライアントを1.14.5に更新。 <br> *18-06-24* - Erigonクライアントを2.6.1に更新。 <br> *02-06-24* - Erigonクライアントを2.6.0に更新。 <br> *02-06-24* - [Issue 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)に基づき、Erigonの非推奨設定フラグ--externalclを削除。 <br> *02-06-24* - Erigon設定をプリビルトバイナリ使用に更新。 <br> *02-06-24* - 冗長なErigonの前提条件を削除。 <br> *30-05-24* - Besuクライアントを24.5.2に更新し、Besu設定フラグセクションのリンク切れを修正。 <br> *30-05-24* - [#6405](https://github.com/hyperledger/besu/pull/6405)に従い、Besu設定でX_SNAPをSNAPに名称変更。 <br> *30-05-24* - Besuの前提条件をJava Runtime v21（ヘッドレス）に更新。 <br> *27-04-24* - 目次を追加。 <br> *27-04-24* - Ubuntuサーバーバージョンを22.04に引き上げ。 <br> [変更履歴アーカイブ](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md)を参照。 |
| [Prysm](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-prysm-581fb1969460) | <br> *20-08-24* - Reth実行クライアントを追加。 <br> *24-06-24* - Prysmクライアントを5.0.4に更新。 <br> *19-06-24* - Prysmクライアントを5.0.3に更新。 <br> *18-06-24* - Besuクライアントを24.5.4に更新。 <br> *18-06-24* - Nethermind設定にプルーニングフラグを追加。 <br> *18-06-24* - Nethermind設定からSync.AncientBodies/Receiptsフラグを削除。 <br> *18-06-24* - Nethermindクライアントを1.26.0に更新。 <br> *18-06-24* - Gethクライアントを1.14.5に更新。 <br> *18-06-24* - Erigonクライアントを2.6.1に更新。 <br> *02-06-24* - Erigonクライアントを2.6.0に更新。 <br> *02-06-24* - [Issue 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)に基づき、Erigonの非推奨設定フラグ--externalclを削除。 <br> *02-06-24* - Erigon設定をプリビルトバイナリ使用に更新。 <br> *02-06-24* - 冗長なErigonの前提条件を削除。 <br> *30-05-24* - Besuクライアントを24.5.2に更新し、Besu設定フラグセクションのリンク切れを修正。 <br> *30-05-24* - [#6405](https://github.com/hyperledger/besu/pull/6405)に従い、Besu設定でX_SNAPをSNAPに名称変更。 <br> *30-05-24* - Besuの前提条件をJava Runtime v21（ヘッドレス）に更新。 <br> *27-04-24* - 目次を追加。 <br> *27-04-24* - Ubuntuサーバーバージョンを22.04に引き上げ。 <br> [変更履歴アーカイブ](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md)を参照。 |
| [Nimbus](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-nimbus-31f56657ea8f) | <br> *20-08-24* - Reth実行クライアントを追加。 <br> *24-06-24* - Nimbusクライアントを24.6.0に更新。 <br> *19-06-24* - Nimbusクライアントを24.5.0に更新。 <br> *18-06-24* - Besuクライアントを24.5.4に更新。 <br> *18-06-24* - Nethermind設定にプルーニングフラグを追加。 <br> *18-06-24* - Nethermind設定からSync.AncientBodies/Receiptsフラグを削除。 <br> *18-06-24* - Nethermindクライアントを1.26.0に更新。 <br> *18-06-24* - Gethクライアントを1.14.5に更新。 <br> *18-06-24* - Erigonクライアントを2.6.1に更新。 <br> *02-06-24* - Erigonクライアントを2.6.0に更新。 <br> *02-06-24* - [Issue 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)に基づき、Erigonの非推奨設定フラグ--externalclを削除。 <br> *02-06-24* - Erigon設定をプリビルトバイナリ使用に更新。 <br> *02-06-24* - 冗長なErigonの前提条件を削除。 <br> *30-05-24* - Besuクライアントを24.5.2に更新し、Besu設定フラグセクションのリンク切れを修正。 <br> *30-05-24* - [#6405](https://github.com/hyperledger/besu/pull/6405)に従い、Besu設定でX_SNAPをSNAPに名称変更。 <br> *30-05-24* - Besuの前提条件をJava Runtime v21（ヘッドレス）に更新。 <br> *27-04-24* - 目次を追加。 <br> *27-04-24* - Ubuntuサーバーバージョンを22.04に引き上げ。 <br> [変更履歴アーカイブ](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md)を参照。 |
| [Teku](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-teku-f09ecd9ef2ee) | <br> *20-08-24* - Reth実行クライアントを追加。 <br> *19-06-24* - Tekuの前提条件をJava Runtime v21（ヘッドレス）に更新。 <br> *19-06-24* - Tekuクライアントを24.6.0に更新。 <br> *18-06-24* - Besuクライアントを24.5.4に更新。 <br> *18-06-24* - Nethermind設定にプルーニングフラグを追加。 <br> *18-06-24* - Nethermind設定からSync.AncientBodies/Receiptsフラグを削除。 <br> *18-06-24* - Nethermindクライアントを1.26.0に更新。 <br> *18-06-24* - Gethクライアントを1.14.5に更新。 <br> *18-06-24* - Erigonクライアントを2.6.1に更新。 <br> *02-06-24* - Erigonクライアントを2.6.0に更新。 <br> *02-06-24* - [Issue 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)に基づき、Erigonの非推奨設定フラグ--externalclを削除。 <br> *02-06-24* - Erigon設定をプリビルトバイナリ使用に更新。 <br> *02-06-24* - 冗長なErigonの前提条件を削除。 <br> *30-05-24* - Besuクライアントを24.5.2に更新し、Besu設定フラグセクションのリンク切れを修正。 <br> *30-05-24* - [#6405](https://github.com/hyperledger/besu/pull/6405)に従い、Besu設定でX_SNAPをSNAPに名称変更。 <br> *30-05-24* - Besuの前提条件をJava Runtime v21（ヘッドレス）に更新。 <br> *18-05-24* - 目次を追加。 <br> *18-05-24* - Ubuntuサーバーバージョンを22.04に引き上げ。 <br> [変更履歴アーカイブ](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md)を参照。 |

<br/>

## 出金資格情報更新ガイド ##

ステーカーはこのガイドを使って、バリデーターの出金資格情報を0x00から0x01に更新できます。

| ガイド | 変更履歴 *(日-月-年)* <img width=450/> |
| :--------- | :---------- |
| [イーサリアムにおける出金資格情報設定ガイド](https://someresat.medium.com/guide-to-configuring-withdrawal-credentials-on-ethereum-812dce3193a) | <br> *14-04-24* - 目次を追加。 <br> *12-11-23* - 複数のリンク切れを修正。 <br> *16-04-23* - タイポ修正と送信＆ブロードキャスト前の追加警告を追加。 <br> *13-04-23* - 可読性向上のための各種更新。 <br> *12-04-23* - Beaconcha.inの送信成功メッセージ例を追加。 <br> *11-04-23* - 公開。 |

<br/>

## 寄付歓迎 ##

Somer.eth (0x32B74B90407309F6637245292cd90347DE658A37)

<br/>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---