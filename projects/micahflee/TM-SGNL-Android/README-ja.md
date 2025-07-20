# Signal Android

Signalはシンプルで強力かつ安全なメッセンジャーです。

Signalは電話のデータ接続（WiFi/3G/4G/5G）を使用して安全に通信します。世界中で何百万人もの人々が毎日無料かつ瞬時にSignalを使ってコミュニケーションしています。高品質なメッセージの送受信、HD音声/ビデオ通話への参加、そしてつながりを保つための新機能の拡充を体験してください。Signalの高度なプライバシー保護技術は常に有効であるため、大切な人との大切な瞬間の共有に集中できます。

現在、Playストアおよび[signal.org](https://signal.org/android/apk/)で利用可能です。

<a href='https://play.google.com/store/apps/details?id=org.tm.archive&pcampaignid=MKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1'><img alt='Get it on Google Play' src='https://play.google.com/intl/en_us/badges/images/generic/en_badge_web_generic.png' height='80px'/></a>

## バグ報告への協力
バグ追跡にはGitHubを使用しています。既存の問題を検索し、まだ追跡されていない場合は新規作成してください！

https://github.com/signalapp/Signal-Android/issues

## ベータ版への参加
最先端の環境で生活し、テストに協力したいですか？

Signal Androidベータ版リリースに登録はこちら：
https://play.google.com/apps/testing/org.tm.archive

平穏な生活を望むなら、標準リリース版をお使いください。

## コードへの貢献

Signalのコードベースが初めての方は、まず問題を確認し、簡単なバグ（問題の「easy」ラベルを参照）を修正して慣れてみることをおすすめします。また、[CONTRIBUTING.md](https://github.com/signalapp/Signal-Android/blob/main/CONTRIBUTING.md)もご覧ください。質問への回答が見つかるかもしれません。

大きな変更や機能案については、実装前に[非公式コミュニティフォーラム](https://community.signalusers.org)で広範な議論を提案してください。

## アイデアへの貢献
Signalプロジェクトについて何か言いたいことがある、または会話に参加したいですか？[コミュニティフォーラム](https://community.signalusers.org)に参加しましょう。

ヘルプ
====
## サポート
トラブルシューティングや質問については、サポートセンターをご覧ください！

https://support.signal.org/

## ドキュメント
ドキュメントをお探しですか？ウィキをご覧ください！

https://github.com/signalapp/Signal-Android/wiki

# 法的事項
## 暗号技術に関する通知

この配布物には暗号化ソフトウェアが含まれています。現在居住している国では、暗号化ソフトウェアの輸入、所持、使用、および他国への再輸出に制限がある場合があります。
暗号化ソフトウェアを使用する前に、輸入、所持、使用、および再輸出に関する法律、規制、政策を必ずご確認ください。
詳細は <http://www.wassenaar.org/> を参照してください。

米国商務省産業安全保障局（BIS）は、本ソフトウェアを輸出管理番号（ECCN）5D002.C.1に分類しています。これは非対称暗号化アルゴリズムを用いる情報セキュリティソフトウェアを含みます。
この配布形態は、オブジェクトコードおよびソースコードの両方に対してライセンス例外ENC技術ソフトウェア無制限（TSU）（BIS輸出管理規則第740.13節）に基づく輸出が可能です。

## ライセンス

Copyright 2013-2024 Signal Messenger, LLC

GNU AGPLv3のもとでライセンスされています: https://www.gnu.org/licenses/agpl-3.0.html

Google PlayおよびGoogle PlayロゴはGoogle LLCの商標です。


//**TM_SA**//
Signal – 新しいベースライン
1.	以下のリンクからSignal公式オープンソースをダウンロードしてください：
      https://github.com/signalapp/Signal-Android

2.	次の順序で各フォルダの名前を変更してください：
      a.	thoughtcrime → tm
      b.	securesms → archive
3.	“すべて置換”機能（Ctrl + Shift + R）で古いパッケージの記述をすべて置換してください
      a.	org.tm.archive -> org.tm.archive
4.	アーカイバSDKと共通ライブラリを新しい“libs”フォルダに追加し、依存関係でコンパイルしてください。
5.	アーカイバ、intune、selfauthenticationフォルダを、すべてのアーカイブクラスやユーティリティ等と共に追加してください（src->main->java->orgから取得）。
6.	現在のプロジェクトで“ArchiveLogger.Companion.sendArchiveLog”を検索し、すべての該当箇所を更新されたプロジェクトに追加してください。
7.	ランチャーアイコンアプリを追加し、マニフェストのラウンドアイコンのパスを変更してください。
8.	現在のプロジェクトからproguard-event_busを更新されたプロジェクトに追加してください。
9.	TeleMessage SignalプロジェクトでCtrl+Alt+Fで検索：//**TM_SA**//

この文字列への参照が数十あります。結果を一つずつ進めて、この文字列（//**TM_SA**//）を用いてコードを置換または追加し、ベースライン更新方法の継続を作成してください。


intune

1. 依存関係を//**TM_SA**//を使って追加してください。
2. MAMSDKフォルダにaarとjarを追加してください。
3. 1. アプリをintuneサーバーに登録してください。
2. https://aad.portal.azure.com/#view/Microsoft_AAD_IAM/ActiveDirectoryMenuBlade/~/Overview
3. Azure Active Directory > アプリ登録 > 新規登録
4. 認証でプラットフォームを追加 -> URIを追加 -> パッケージ名を入力。
5. 表示される「View」ボタンを使ってauth-configファイルを追加し、resource->rawに配置。
6. API権限を追加...

4. 1. https://aad.portal.azure.com/#view/Microsoft_AAD_IAM/ActiveDirectoryMenuBlade/~/RegisteredApps
2. 次に、アプリ構成ポリシー -> アプリ構成ポリシーの作成 -> アプリ管理 -> 設定 -> 値(managerID等)を追加
3. 次に、割り当て -> グループを含めるか全員に割り当て。

5. http://everythingaboutintune.com/2021/07/guide-for-integrating-intune-sdk-and-msal-to-lob-application/

https://www.youtube.com/watch?v=1AyGpcdDRkY&t=741s&ab_channel=EverythingAboutIntune
https://github.com/msintuneappsdk/Taskr-Sample-Intune-Android-App#readme
//**TM_SA**//


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---