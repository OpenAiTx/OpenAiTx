*[English](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README.md) ∙ [日本語](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-ja.md) ∙ [简体中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-Hans.md) ∙ [繁體中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-TW.md) | [العَرَبِيَّة‎](https://github.com/donnemartin/system-design-primer/issues/170) ∙ [বাংলা](https://github.com/donnemartin/system-design-primer/issues/220) ∙ [Português do Brasil](https://github.com/donnemartin/system-design-primer/issues/40) ∙ [Deutsch](https://github.com/donnemartin/system-design-primer/issues/186) ∙ [ελληνικά](https://github.com/donnemartin/system-design-primer/issues/130) ∙ [עברית](https://github.com/donnemartin/system-design-primer/issues/272) ∙ [Italiano](https://github.com/donnemartin/system-design-primer/issues/104) ∙ [한국어](https://github.com/donnemartin/system-design-primer/issues/102) ∙ [فارسی](https://github.com/donnemartin/system-design-primer/issues/110) ∙ [Polski](https://github.com/donnemartin/system-design-primer/issues/68) ∙ [русский язык](https://github.com/donnemartin/system-design-primer/issues/87) ∙ [Español](https://github.com/donnemartin/system-design-primer/issues/136) ∙ [ภาษาไทย](https://github.com/donnemartin/system-design-primer/issues/187) ∙ [Türkçe](https://github.com/donnemartin/system-design-primer/issues/39) ∙ [tiếng Việt](https://github.com/donnemartin/system-design-primer/issues/127) ∙ [Français](https://github.com/donnemartin/system-design-primer/issues/250) | [Add Translation](https://github.com/donnemartin/system-design-primer/issues/28)*
**このガイドの[翻訳](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/TRANSLATIONS.md)にご協力ください！**

# システム設計入門

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png">
  <br/>
</p>

## 動機

> 大規模システムの設計方法を学ぶ。
>
> システム設計面接の準備をする。

### 大規模システムの設計方法を学ぶ

スケーラブルなシステムの設計方法を学ぶことは、より良いエンジニアになる助けとなります。

システム設計は広範なトピックです。システム設計の原則に関する**膨大な量のリソースがウェブ上に散在しています**。

このリポジトリは、スケールするシステムの構築方法を学ぶのに役立つ**体系的に整理されたリソースのコレクション**です。

### オープンソースコミュニティから学ぶ

これは継続的に更新されるオープンソースプロジェクトです。

[貢献](#contributing)を歓迎します！

### システム設計面接の準備

コーディング面接に加えて、多くの技術系企業の**技術面接プロセス**にはシステム設計が**必須の要素**となっています。

**一般的なシステム設計面接の質問を練習し**、**議論、コード、図解を含むサンプル解答**と**比較**しましょう。

面接準備のための追加トピック：

* [学習ガイド](#study-guide)
* [システム設計面接の質問へのアプローチ方法](#how-to-approach-a-system-design-interview-question)

* [システム設計面接質問、**解答付き**](#system-design-interview-questions-with-solutions)
* [オブジェクト指向設計面接質問、**解答付き**](#object-oriented-design-interview-questions-with-solutions)
* [追加のシステム設計面接質問](#additional-system-design-interview-questions)

## Ankiフラッシュカード

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/zdCAkB3.png">
  <br/>
</p>

提供されている[Ankiフラッシュカードデッキ](https://apps.ankiweb.net/)は、間隔反復を利用して主要なシステム設計の概念を記憶するのに役立ちます。

* [システム設計デッキ](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design.apkg)
* [システム設計演習デッキ](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design%20Exercises.apkg)
* [オブジェクト指向設計演習デッキ](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/OO%20Design.apkg)

外出先での利用に最適です。

### コーディングリソース: インタラクティブコーディングチャレンジ

[**コーディング面接**](https://github.com/donnemartin/interactive-coding-challenges)の準備に役立つリソースをお探しですか？

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/b4YtAEN.png">
  <br/>
</p>

姉妹リポジトリの[**Interactive Coding Challenges**](https://github.com/donnemartin/interactive-coding-challenges)もぜひご覧ください。追加のAnkiデッキが含まれています：

* [コーディングデッキ](https://github.com/donnemartin/interactive-coding-challenges/tree/master/anki_cards/Coding.apkg)

## 貢献について

> コミュニティから学びましょう。

以下のためにプルリクエストを自由に送ってください：

* 誤りの修正
* セクションの改善
* 新しいセクションを追加
* [翻訳](https://github.com/donnemartin/system-design-primer/issues/28)

調整が必要なコンテンツは[開発中](#under-development)に置かれています。

[貢献ガイドライン](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/CONTRIBUTING.md)を確認してください。

## システム設計トピックの索引

> さまざまなシステム設計トピックの概要、利点と欠点を含む。 **すべてはトレードオフ**です。
>
> 各セクションには、より詳細なリソースへのリンクが含まれています。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png">
  <br/>
</p>

* [システム設計トピック：ここから始める](#system-design-topics-start-here)
    * [ステップ1：スケーラビリティのビデオ講義を確認](#step-1-review-the-scalability-video-lecture)
    * [ステップ2：スケーラビリティの記事を確認](#step-2-review-the-scalability-article)
    * [次のステップ](#next-steps)
* [パフォーマンス対スケーラビリティ](#performance-vs-scalability)
* [レイテンシ対スループット](#latency-vs-throughput)
* [可用性対整合性](#availability-vs-consistency)
    * [CAP定理](#cap-theorem)
        * [CP - 整合性と分割耐性](#cp---consistency-and-partition-tolerance)
        * [AP - 可用性と分割耐性](#ap---availability-and-partition-tolerance)
* [整合性パターン](#consistency-patterns)
    * [弱い整合性](#weak-consistency)
    * [最終的整合性](#eventual-consistency)
    * [強い整合性](#strong-consistency)
* [可用性パターン](#availability-patterns)
    * [フェイルオーバー](#fail-over)
    * [レプリケーション](#replication)
    * [可用性の数値](#availability-in-numbers)
* [ドメインネームシステム](#domain-name-system)
* [コンテンツ配信ネットワーク](#content-delivery-network)
    * [プッシュCDN](#push-cdns)
    * [プルCDN](#pull-cdns)
* [ロードバランサー](#load-balancer)
    * [アクティブ-パッシブ](#active-passive)
    * [アクティブ-アクティブ](#active-active)
    * [レイヤー4ロードバランシング](#layer-4-load-balancing)
    * [レイヤー7ロードバランシング](#layer-7-load-balancing)
    * [水平スケーリング](#horizontal-scaling)
* [リバースプロキシ（ウェブサーバー）](#reverse-proxy-web-server)
    * [ロードバランサーとリバースプロキシの違い](#load-balancer-vs-reverse-proxy)
* [アプリケーション層](#application-layer)
    * [マイクロサービス](#microservices)
    * [サービスディスカバリー](#service-discovery)
* [データベース](#database)
    * [リレーショナルデータベース管理システム（RDBMS）](#relational-database-management-system-rdbms)
        * [マスター-スレーブレプリケーション](#master-slave-replication)
        * [マスター-マスターレプリケーション](#master-master-replication)
        * [フェデレーション](#federation)
        * [シャーディング](#sharding)
        * [非正規化](#denormalization)
        * [SQLチューニング](#sql-tuning)
    * [NoSQL](#nosql)
        * [キー・バリューストア](#key-value-store)
        * [ドキュメントストア](#document-store)
        * [ワイドカラムストア](#wide-column-store)
        * [グラフデータベース](#graph-database)
    * [SQLまたはNoSQL](#sql-or-nosql)
* [キャッシュ](#cache)
    * [クライアントキャッシュ](#client-caching)
    * [CDNキャッシュ](#cdn-caching)
    * [ウェブサーバーキャッシュ](#web-server-caching)
    * [データベースキャッシュ](#database-caching)
    * [アプリケーションキャッシュ](#application-caching)
    * [データベースクエリレベルでのキャッシュ](#caching-at-the-database-query-level)
    * [オブジェクトレベルでのキャッシュ](#caching-at-the-object-level)
    * [キャッシュ更新のタイミング](#when-to-update-the-cache)
        * [キャッシュアサイド](#cache-aside)
        * [ライトスルー](#write-through)
        * [ライトビハインド（ライトバック）](#write-behind-write-back)
        * [リフレッシュアヘッド](#refresh-ahead)
* [非同期処理](#asynchronism)
    * [メッセージキュー](#message-queues)
    * [タスクキュー](#task-queues)
    * [バックプレッシャー](#back-pressure)
* [通信](#communication)
    * [トランスミッションコントロールプロトコル (TCP)](#transmission-control-protocol-tcp)
    * [ユーザーデータグラムプロトコル (UDP)](#user-datagram-protocol-udp)
    * [リモートプロシージャコール (RPC)](#remote-procedure-call-rpc)
    * [表現状態転送 (REST)](#representational-state-transfer-rest)
* [セキュリティ](#security)
* [付録](#appendix)
    * [2のべき乗表](#powers-of-two-table)
    * [すべてのプログラマーが知るべきレイテンシ数値](#latency-numbers-every-programmer-should-know)
    * [追加のシステム設計面接質問](#additional-system-design-interview-questions)
    * [実際のアーキテクチャ](#real-world-architectures)
    * [企業のアーキテクチャ](#company-architectures)
    * [企業のエンジニアリングブログ](#company-engineering-blogs)
* [開発中](#under-development)
* [クレジット](#credits)
* [連絡先情報](#contact-info)
* [ライセンス](#license)

## 学習ガイド

> 面接のスケジュールに基づく推奨トピック（短期、中期、長期）。

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/OfVllex.png)

**Q: 面接のためにここにあるすべてを知る必要がありますか？**

**A: いいえ、面接準備のためにここにあるすべてを知る必要はありません**。

面接で問われる内容は以下のような変数によって異なります：

* あなたの経験の量
* あなたの技術的な背景
* 面接を受けるポジション
* 面接を受ける企業
* 運

経験豊富な候補者は一般的にシステム設計についてより多く知っていることが期待されます。 アーキテクトやチームリーダーは個人貢献者よりも多く知っていることが期待されるかもしれません。 トップテック企業では一つ以上の設計面接ラウンドがある可能性が高いです。

幅広く学び、いくつかの分野で深掘りしましょう。システム設計の主要なトピックについて少し知っておくと役立ちます。以下のガイドは、あなたのスケジュール、経験、面接するポジションや企業に応じて調整してください。

* **短期間** - システム設計トピックの**広範囲**を目指しましょう。**いくつか**の面接問題を解いて練習します。
* **中期間** - システム設計トピックの**広範囲**と**一部の深掘り**を目指しましょう。**多くの**面接問題を解いて練習します。
* **長期間** - システム設計トピックの**広範囲**と**より深い理解**を目指しましょう。**ほとんどの**面接問題を解いて練習します。

| | 短期間 | 中期間 | 長期間 |
|---|---|---|---|
| [システム設計トピック](#index-of-system-design-topics)を読んでシステムの仕組みを広く理解する | :+1: | :+1: | :+1: |
| 面接予定の企業の[会社のエンジニアリングブログ](#company-engineering-blogs)をいくつか読む | :+1: | :+1: | :+1: |
| [実世界のアーキテクチャ](#real-world-architectures)をいくつか読む | :+1: | :+1: | :+1: |
| [システム設計面接の質問への取り組み方](#how-to-approach-a-system-design-interview-question)を見直す | :+1: | :+1: | :+1: |
| [システム設計面接質問と解答](#system-design-interview-questions-with-solutions)に取り組む | 一部 | 多く | ほとんど |
| [オブジェクト指向設計面接質問と解答](#object-oriented-design-interview-questions-with-solutions)に取り組む | 一部 | 多く | ほとんど |
| [追加のシステム設計面接質問](#additional-system-design-interview-questions)を見直す | 一部 | 多く | ほとんど |

## システム設計面接質問への取り組み方

> システム設計面接質問にどう取り組むか。

システム設計面接は**オープンエンドな対話**です。あなたが主導することが期待されます。

以下のステップを使って議論を進めることができます。このプロセスを確実にするために、[システム設計面接質問と解答](#system-design-interview-questions-with-solutions)のセクションを以下のステップに従って取り組みましょう。

### ステップ1: ユースケース、制約、仮定の概要を示す

要件を集めて問題の範囲を定めます。ユースケースや制約を明確にするために質問し、仮定を議論します。

* 誰が使うのか？
* どのように使うのか？
* ユーザー数は？
* システムは何をするのか？
* システムの入力と出力は何か？
* どれくらいのデータを扱うことを想定しているか？
* 1秒あたりのリクエスト数はどれくらいか？
* 読み込みと書き込みの比率はどの程度か？

### ステップ2: 高レベル設計を作成する

すべての重要なコンポーネントを含む高レベル設計の概要を示します。
* 主なコンポーネントと接続をスケッチする  
* アイデアの正当性を説明する  

### ステップ3: コアコンポーネントの設計  

各コアコンポーネントの詳細に入り込む。たとえば、もし[URL短縮サービスを設計する](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)ように求められた場合、以下を議論する：  

* フルURLのハッシュを生成し保存する  
    * [MD5](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)と[Base62](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)  
    * ハッシュの衝突  
    * SQLかNoSQLか  
    * データベーススキーマ  
* ハッシュ化されたURLをフルURLに変換する  
    * データベース検索  
* APIとオブジェクト指向設計  

### ステップ4: 設計のスケールアップ  

制約条件を踏まえてボトルネックを特定し対処する。たとえば、スケーラビリティの問題に対処するために以下が必要か？  

* ロードバランサー  
* 水平スケーリング  
* キャッシュ  
* データベースシャーディング  

潜在的な解決策とトレードオフを議論する。すべてはトレードオフである。[スケーラブルなシステム設計の原則](#index-of-system-design-topics)を用いてボトルネックに対処する。  

### おおまかな計算  

手計算での見積もりを求められることがある。[付録](#appendix)の以下のリソースを参照せよ：  

* [おおまかな計算の利用](http://highscalability.com/blog/2011/1/26/google-pro-tip-use-back-of-the-envelope-calculations-to-choo.html)  
* [2の冪乗表](#powers-of-two-table)  
* [すべてのプログラマが知るべきレイテンシ数値](#latency-numbers-every-programmer-should-know)  

### 参考文献およびさらなる読書  

以下のリンクを確認し、何を期待すべきかの理解を深めよう：


* [システム設計面接を成功させる方法](https://www.palantir.com/2011/10/how-to-rock-a-systems-design-interview/)
* [システム設計面接](http://www.hiredintech.com/system-design)
* [アーキテクチャとシステム設計面接の入門](https://www.youtube.com/watch?v=ZgdS0EUmn70)
* [システム設計テンプレート](https://leetcode.com/discuss/career/229177/My-System-Design-Template)

## システム設計面接の質問と解答例

> 一般的なシステム設計面接の質問とサンプルディスカッション、コード、図解。
>
> 解答は `solutions/` フォルダ内の内容にリンク。

| 質問 | |
|---|---|
| Pastebin.com（または Bit.ly）の設計 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) |
| Twitterのタイムラインと検索の設計（またはFacebookのフィードと検索） | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md) |
| ウェブクローラーの設計 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md) |
| Mint.comの設計 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md) |
| ソーシャルネットワークのデータ構造の設計 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md) |
| 検索エンジン用のキー・バリューストアの設計 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md) |
| Amazonのカテゴリー別売上ランキング機能の設計 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md) |
| AWSで数百万ユーザーにスケール可能なシステムの設計 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md) |
| システム設計の質問を追加する | [貢献する](#contributing) |

### Pastebin.com（または Bit.ly）の設計

[演習と解答を見る](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4edXG0T.png)

### Twitterのタイムラインと検索の設計（またはFacebookのフィードと検索）

[演習と解答を見る](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png)

### ウェブクローラーの設計

[演習と解答を見る](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bWxPtQA.png)

### Design Mint.com

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/V5q57vU.png)

### Design the data structures for a social network

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/cdCv5g7.png)

### Design a key-value store for a search engine

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4j99mhe.png)

### Design Amazon's sales ranking by category feature

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/MzExP06.png)

### Design a system that scales to millions of users on AWS

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png)

## Object-oriented design interview questions with solutions

> Common object-oriented design interview questions with sample discussions, code, and diagrams.
>
> Solutions linked to content in the `solutions/` folder.

>**Note: This section is under development**

| Question | |
|---|---|
| ハッシュマップを設計する | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/hash_table/hash_map.ipynb)  |
| LRUキャッシュを設計する | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/lru_cache/lru_cache.ipynb)  |
| コールセンターを設計する | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/call_center/call_center.ipynb)  |
| トランプの山札を設計する | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/deck_of_cards/deck_of_cards.ipynb)  |
| 駐車場を設計する | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/parking_lot/parking_lot.ipynb)  |
| チャットサーバーを設計する | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/online_chat/online_chat.ipynb)  |
| 循環配列を設計する | [貢献する](#contributing)  |
| オブジェクト指向設計の質問を追加する | [貢献する](#contributing) |

## システム設計トピック：ここから始めよう

システム設計は初めてですか？

まず、基本的な共通原則の理解が必要です。これらが何であるか、どのように使われるか、その利点と欠点について学びましょう。

### ステップ1：スケーラビリティのビデオ講義を視聴する

[ハーバードのスケーラビリティ講義](https://www.youtube.com/watch?v=-W9F__D3oY4)

* カバーするトピック:
    * 垂直スケーリング
    * 水平スケーリング
    * キャッシュ
    * ロードバランシング
    * データベースのレプリケーション
    * データベースのパーティショニング

### ステップ2：スケーラビリティの記事を読む

[スケーラビリティ](https://web.archive.org/web/20221030091841/http://www.lecloud.net/tagged/scalability/chrono)

* カバーするトピック:
    * [クローン](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
    * [データベース](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
    * [キャッシュ](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
    * [非同期処理](https://web.archive.org/web/20220926171507/https://www.lecloud.net/post/9699762917/scalability-for-dummies-part-4-asynchronism)

### 次のステップ

次に、高レベルのトレードオフについて見ていきます：

* **パフォーマンス** vs **スケーラビリティ**
* **レイテンシ** vs **スループット**
* **可用性** vs **一貫性**

すべては**トレードオフ**であることを念頭に置いてください。

その後、DNS、CDN、ロードバランサーなど、より具体的なトピックに踏み込んでいきます。

## パフォーマンス vs スケーラビリティ

サービスが**スケーラブル**であるとは、追加したリソースに比例して**パフォーマンス**が向上する場合を指します。一般的に、パフォーマンスの向上とはより多くの作業単位を処理することを意味しますが、データセットが増大する場合のように、より大きな作業単位を扱うことも含まれます。<sup><a href=http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html>1</a></sup>

パフォーマンスとスケーラビリティの別の見方：

* **パフォーマンス**の問題がある場合、単一ユーザーに対してシステムが遅い。
* **スケーラビリティ**の問題がある場合、単一ユーザーには速いが、負荷が高いときに遅くなる。

### 参考文献とさらなる読み物

* [スケーラビリティについての一言](http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html)
* [スケーラビリティ、可用性、安定性、パターン](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)

## レイテンシ vs スループット

**レイテンシ**は、ある操作を実行するか結果を出すまでの時間です。

**スループット**は、単位時間あたりのそのような操作や結果の数です。

一般的には、**許容可能なレイテンシ**で**最大スループット**を目指すべきです。

### 参考文献とさらなる読み物

* [レイテンシとスループットの理解](https://community.cadence.com/cadence_blogs_8/b/fv/posts/understanding-latency-vs-throughput)

## 可用性 vs 一貫性

### CAP定理

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bgLMI2u.png">
  <br/>
  <i><a href=http://robertgreiner.com/2014/08/cap-theorem-revisited>出典: CAP定理再考</a></i>
</p>

分散コンピュータシステムでは、次の3つの保証のうち2つだけをサポートできます:

* **一貫性（Consistency）** - すべての読み取りは最新の書き込みを受け取るか、エラーになる
* **可用性（Availability）** - すべてのリクエストは応答を受け取るが、最新の情報が含まれている保証はない
* **分割耐性（Partition Tolerance）** - ネットワーク障害による任意の分割があってもシステムは動作し続ける

*ネットワークは信頼できないため、分割耐性をサポートする必要があります。ソフトウェア上のトレードオフとして、一貫性と可用性のどちらかを選択する必要があります。*

#### CP - 一貫性と分割耐性

分割されたノードからの応答を待つとタイムアウトエラーになる可能性があります。ビジネス上の要件が原子性のある読み書きを必要とする場合、CPは良い選択です。

#### AP - 可用性と分割耐性

応答は任意のノードで最も利用可能なバージョンのデータを返しますが、最新ではない場合があります。分割が解消されると書き込みの伝播に時間がかかることがあります。

APは[最終的な一貫性](#eventual-consistency)を許容する必要がある場合や、外部のエラーがあってもシステムを継続動作させる必要がある場合に適しています。

### 出典とさらなる参考資料

* [CAP定理再考](http://robertgreiner.com/2014/08/cap-theorem-revisited/)
* [CAP定理のわかりやすい紹介](http://ksat.me/a-plain-english-introduction-to-cap-theorem)
* [CAP FAQ](https://github.com/henryr/cap-faq)
* [CAP定理](https://www.youtube.com/watch?v=k-Yaq8AHlFA)

## 一貫性パターン

同じデータの複数のコピーが存在する場合、クライアントが一貫したデータビューを持つようにそれらをどのように同期させるかの選択肢があります。[CAP定理](#cap-theorem)の一貫性の定義を思い出してください - すべての読み取りは最新の書き込みを受け取るか、エラーになる。

### 弱い一貫性

書き込み後に読み取りがそれを見える場合も見えない場合もあります。ベストエフォートのアプローチです。

このアプローチはmemcachedのようなシステムで見られます。弱い一貫性はVoIP、ビデオチャット、リアルタイムマルチプレイヤーゲームなどのリアルタイムユースケースでよく機能します。例えば、電話中に数秒間通信が途切れた場合、接続が回復してもその間に話された内容は聞こえません。
### 最終的整合性

書き込み後、読み取りは最終的にそれを参照します（通常は数ミリ秒以内）。データは非同期に複製されます。

このアプローチはDNSやメールのようなシステムで見られます。最終的整合性は高可用性システムでうまく機能します。

### 強い整合性

書き込み後、読み取りはそれを参照します。データは同期的に複製されます。

このアプローチはファイルシステムやRDBMSで見られます。強い整合性はトランザクションを必要とするシステムでうまく機能します。

### 出典およびさらなる読み物

* [データセンター間のトランザクション](http://snarfed.org/transactions_across_datacenters_io.html)

## 可用性パターン

高可用性をサポートするための相補的なパターンが二つあります：**フェイルオーバー**と**レプリケーション**。

### フェイルオーバー

#### アクティブ-パッシブ

アクティブ-パッシブフェイルオーバーでは、アクティブサーバーと待機中のパッシブサーバー間でハートビートが送信されます。ハートビートが中断された場合、パッシブサーバーがアクティブのIPアドレスを引き継ぎサービスを再開します。

ダウンタイムの長さは、パッシブサーバーがすでに「ホット」スタンバイで稼働しているか、「コールド」スタンバイから起動する必要があるかで決まります。トラフィックを処理するのはアクティブサーバーのみです。

アクティブ-パッシブフェイルオーバーはマスター-スレーブフェイルオーバーとも呼ばれます。

#### アクティブ-アクティブ

アクティブ-アクティブでは、両方のサーバーがトラフィックを管理し、負荷を分散しています。

サーバーが公開向けの場合、DNSは両方のサーバーのパブリックIPを認識する必要があります。サーバーが内部向けの場合、アプリケーションロジックが両方のサーバーを認識する必要があります。

アクティブ-アクティブフェイルオーバーはマスター-マスターフェイルオーバーとも呼ばれます。

### 欠点：フェイルオーバー

* フェイルオーバーは、より多くのハードウェアと追加の複雑さをもたらします。
* アクティブシステムが、新たに書き込まれたデータがパッシブに複製される前に障害が発生した場合、データの損失の可能性があります。

### 複製

#### マスター・スレーブおよびマスター・マスター

このトピックは[データベース](#database)セクションでさらに詳しく説明されています：

* [マスター・スレーブ複製](#master-slave-replication)
* [マスター・マスター複製](#master-master-replication)

### 可用性の数値

可用性はしばしばサービスが利用可能な時間の割合としてアップタイム（またはダウンタイム）で定量化されます。可用性は一般的に「9の数」で測定され、99.99%の可用性を持つサービスは「4つの9」と表現されます。

#### 99.9%の可用性 - 3つの9

| 期間                | 許容ダウンタイム     |
|---------------------|--------------------|
| 年間ダウンタイム     | 8時間45分57秒       |
| 月間ダウンタイム     | 43分49.7秒          |
| 週間ダウンタイム     | 10分4.8秒           |
| 1日あたりのダウンタイム | 1分26.4秒           |

#### 99.99%の可用性 - 4つの9

| 期間                | 許容ダウンタイム     |
|---------------------|--------------------|
| 年間ダウンタイム     | 52分35.7秒          |
| 月間ダウンタイム     | 4分23秒             |
| 週間ダウンタイム     | 1分5秒              |
| 1日あたりのダウンタイム | 8.6秒               |

#### 並列可用性と直列可用性

サービスが障害を起こしやすい複数のコンポーネントで構成されている場合、サービス全体の可用性はコンポーネントが直列か並列かによって異なります。

###### 直列の場合

全体の可用性は、可用性が100%未満の2つのコンポーネントが直列に接続されている場合に低下します:


```
Availability (Total) = Availability (Foo) * Availability (Bar)
```

もし `Foo` と `Bar` の両方がそれぞれ99.9%の可用性を持っている場合、それらが直列に接続されると合計の可用性は99.8%になります。

###### 並列の場合

可用性が100%未満の2つのコンポーネントを並列に配置すると、全体の可用性は向上します：

```
Availability (Total) = 1 - (1 - Availability (Foo)) * (1 - Availability (Bar))
```
もし `Foo` と `Bar` の両方がそれぞれ99.9%の可用性を持っている場合、並列での総可用性は99.9999%になります。

## ドメインネームシステム

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/IOyLj4i.jpg">
  <br/>
  <i><a href=http://www.slideshare.net/srikrupa5/dns-security-presentation-issa>出典: DNSセキュリティプレゼンテーション</a></i>
</p>

ドメインネームシステム（DNS）は、www.example.comのようなドメイン名をIPアドレスに変換します。

DNSは階層構造を持ち、最上位にいくつかの権威サーバーがあります。ルーターやISPは、名前解決時にどのDNSサーバーに連絡すべきかの情報を提供します。下位のDNSサーバーはマッピングをキャッシュしますが、DNS伝播遅延により古くなることがあります。DNSの結果はブラウザやOSによっても一定期間キャッシュされ、その期間は[TTL（Time to Live）](https://en.wikipedia.org/wiki/Time_to_live)によって決まります。

* **NSレコード（ネームサーバー）** - ドメイン／サブドメインのDNSサーバーを指定します。
* **MXレコード（メール交換）** - メッセージ受信のためのメールサーバーを指定します。
* **Aレコード（アドレス）** - 名前をIPアドレスに紐づけます。
* **CNAME（カノニカル）** - 名前を別の名前や `CNAME`（例: example.com を www.example.com に）または `A`レコードに紐づけます。

[CloudFlare](https://www.cloudflare.com/dns/)や[Route 53](https://aws.amazon.com/route53/)のようなサービスはマネージドDNSサービスを提供しています。一部のDNSサービスは以下のような様々な方法でトラフィックをルーティングできます：

* [重み付きラウンドロビン](https://www.jscape.com/blog/load-balancing-algorithms)
    * メンテナンス中のサーバーへのトラフィックを防ぐ
    * 異なるクラスタサイズ間のバランス調整
    * A/Bテスト
* [レイテンシベース](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-latency.html)
* [地理位置ベース](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geo.html)

### DNSの欠点

* DNSサーバーにアクセスすることで若干の遅延が発生しますが、前述のキャッシュにより軽減されます。
* DNSサーバーの管理は複雑であり、一般的に[政府、ISP、大企業](http://superuser.com/questions/472695/who-controls-the-dns-servers/472729)によって管理されています。
* 最近DNSサービスは[DDoS攻撃](http://dyn.com/blog/dyn-analysis-summary-of-friday-october-21-attack/)を受けており、ユーザーがTwitterなどのウェブサイトにアクセスする際にTwitterのIPアドレスを知らないとアクセスできない状況が発生しています。

### 参考文献とさらなる情報

* [DNSアーキテクチャ](https://technet.microsoft.com/en-us/library/dd197427(v=ws.10).aspx)
* [Wikipedia](https://ja.wikipedia.org/wiki/ドメインネームシステム)
* [DNS関連記事](https://support.dnsimple.com/categories/dns/)

## コンテンツ配信ネットワーク

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h9TAuGI.jpg">
  <br/>
  <i><a href=https://www.creative-artworks.eu/why-use-a-content-delivery-network-cdn/>出典: なぜCDNを使うのか</a></i>
</p>

コンテンツ配信ネットワーク（CDN）は、ユーザーに近い場所からコンテンツを配信する、世界中に分散したプロキシサーバーのネットワークです。一般的に、HTML/CSS/JS、写真、動画などの静的ファイルはCDNから配信されますが、AmazonのCloudFrontのように動的コンテンツをサポートするCDNもあります。サイトのDNS解決はクライアントにどのサーバーに接続すべきかを伝えます。

CDNからコンテンツを配信することで、次の2つの方法でパフォーマンスが大幅に向上します：

* ユーザーは自分に近いデータセンターからコンテンツを受け取る
* サーバーはCDNが対応するリクエストを処理する必要がなくなる

### プッシュCDN

プッシュCDNはサーバーで変更があるたびに新しいコンテンツを受け取ります。コンテンツ提供の全責任はあなたにあり、直接CDNにアップロードし、URLを書き換えてCDNを指すようにします。コンテンツの有効期限や更新タイミングを設定できます。コンテンツは新規または変更時のみアップロードされるため、トラフィックを最小限に抑えつつ、ストレージを最大限に活用します。

トラフィックが少ないサイトや更新頻度の低いコンテンツのサイトではプッシュCDNが適しています。コンテンツは一度CDNに配置され、定期的に再取得されることはありません。

### プルCDN

プルCDNは最初のユーザーがコンテンツをリクエストした際にあなたのサーバーから新しいコンテンツを取得します。コンテンツはサーバー上に残し、URLを書き換えてCDNを指すようにします。そのため、コンテンツがCDNにキャッシュされるまではリクエストが遅くなります。

[TTL（Time-to-Live）](https://ja.wikipedia.org/wiki/TTL)はコンテンツがキャッシュされる期間を決定します。プルCDNはCDN上のストレージ使用を最小限に抑えますが、ファイルの期限切れ後に実際には変更されていない場合でも再取得されることで冗長なトラフィックが発生する可能性があります。

トラフィックが多いサイトではプルCDNが適しており、最近リクエストされたコンテンツのみがCDNに残り、トラフィックがより均等に分散されます。

### デメリット：CDN

* トラフィックによってはCDNコストが大きくなる可能性がありますが、CDNを使わなかった場合の追加コストと比較する必要があります。
* TTLが切れる前に更新された場合、コンテンツが古いままになる可能性があります。
* 静的コンテンツのURLをCDNを指すように変更する必要があります。

### 出典および参考文献

* [Globally distributed content delivery](https://figshare.com/articles/Globally_distributed_content_delivery/6605972)
* [プッシュCDNとプルCDNの違い](http://www.travelblogadvice.com/technical/the-differences-between-push-and-pull-cdns/)

* [Wikipedia](https://en.wikipedia.org/wiki/Content_delivery_network)

## ロードバランサー

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h81n9iK.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>出典: スケーラブルシステム設計パターン</a></i>
</p>

ロードバランサーは、アプリケーションサーバーやデータベースなどのコンピューティングリソースに対するクライアントからのリクエストを分散します。 各ケースで、ロードバランサーはコンピューティングリソースからのレスポンスを適切なクライアントに返します。 ロードバランサーは以下に効果的です：

* 不健康なサーバーへのリクエストを防ぐ
* リソースの過負荷を防ぐ
* 単一障害点の排除に役立つ

ロードバランサーはハードウェア（高価）やHAProxyのようなソフトウェアで実装可能です。

追加の利点には以下があります：

* **SSL終端** - 受信リクエストの復号化とサーバーレスポンスの暗号化を行い、バックエンドサーバーがこれらの高コストな処理を行わずに済むようにする
    * 各サーバーに[X.509証明書](https://en.wikipedia.org/wiki/X.509)をインストールする必要がなくなる
* **セッション持続性** - クッキーを発行し、ウェブアプリがセッションを追跡しない場合に特定クライアントのリクエストを同一インスタンスにルーティングする

障害に備えて、ロードバランサーは[アクティブ-パッシブ](#active-passive)または[アクティブ-アクティブ](#active-active)モードで複数台構成することが一般的です。

ロードバランサーは以下のような様々な指標に基づいてトラフィックをルーティングできます：

* ランダム
* 最も負荷の低い
* セッション／クッキー
* [ラウンドロビンまたは加重ラウンドロビン](https://www.g33kinfo.com/info/round-robin-vs-weighted-round-robin-lb)
* [レイヤー4](#layer-4-load-balancing)
* [レイヤー7](#layer-7-load-balancing)

### レイヤー4ロードバランシング

レイヤー4ロードバランサーはリクエスト分散のために[トランスポート層](#communication)の情報を参照します。 一般的には、ヘッダー内の送信元・宛先IPアドレスとポートを使いますが、パケットの内容は見ません。 レイヤー4ロードバランサーはアップストリームサーバーへのネットワークパケットを転送し、[ネットワークアドレス変換（NAT）](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)を行います。

### レイヤー7ロードバランシング
レイヤー7のロードバランサーは、リクエストをどのように分配するかを決定するために[アプリケーション層](#communication)を参照します。これはヘッダー、メッセージ、クッキーの内容を含む場合があります。レイヤー7のロードバランサーはネットワークトラフィックを終端し、メッセージを読み込み、負荷分散の決定を行い、選択されたサーバーへの接続を開きます。例えば、レイヤー7のロードバランサーは動画トラフィックを動画をホストするサーバーに、より機密性の高いユーザー請求トラフィックをセキュリティ強化されたサーバーに振り分けることができます。

柔軟性の代償として、レイヤー4のロードバランシングはレイヤー7よりも少ない時間と計算資源を必要としますが、最新の汎用ハードウェアではパフォーマンスへの影響は最小限です。

### 水平スケーリング

ロードバランサーは水平スケーリングにも役立ち、パフォーマンスと可用性を向上させます。汎用マシンを使用してスケールアウトすることは、より高価なハードウェア上で単一のサーバーをスケールアップする（**垂直スケーリング**と呼ばれる）よりもコスト効率が高く、可用性も向上します。また、専門的な企業システムよりも汎用ハードウェアで働く人材を採用する方が容易です。

#### 欠点：水平スケーリング

* 水平スケーリングは複雑さを導入し、サーバーの複製を伴います
    * サーバーはステートレスであるべきです：セッションやプロフィール画像などのユーザー関連データを含まないこと
    * セッションは[データベース](#database)（SQL、NoSQL）や永続的な[キャッシュ](#cache)（Redis、Memcached）などの集中管理されたデータストアに保存できます
* キャッシュやデータベースなどの下流サーバーは、上流サーバーのスケールアウトに伴い同時接続数の増加を処理する必要があります

### 欠点：ロードバランサー

* ロードバランサーが十分なリソースを持たない場合や適切に設定されていない場合、パフォーマンスのボトルネックになる可能性があります。
* 単一障害点を排除するためにロードバランサーを導入すると、複雑さが増します。
* 単一のロードバランサーは単一障害点であり、複数のロードバランサーを設定するとさらに複雑さが増します。

### 参考文献およびさらなる読み物

* [NGINXのアーキテクチャ](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [HAProxyアーキテクチャガイド](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [スケーラビリティ](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
* [ウィキペディア](https://en.wikipedia.org/wiki/Load_balancing_(computing))
* [レイヤー4ロードバランシング](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)
* [レイヤー7ロードバランシング](https://www.nginx.com/resources/glossary/layer-7-load-balancing/)
* [ELBリスナー設定](http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html)

## リバースプロキシ（ウェブサーバー）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n41Azff.png">
  <br/>
  <i><a href=https://upload.wikimedia.org/wikipedia/commons/6/67/Reverse_proxy_h2g2bob.svg>出典: ウィキペディア</a></i>
  <br/>
</p>

リバースプロキシは、内部サービスを集中管理し、一般向けに統一されたインターフェースを提供するウェブサーバーです。  
クライアントからのリクエストは、それを満たすことができるサーバーに転送され、リバースプロキシはそのサーバーの応答をクライアントに返します。  

追加の利点には以下が含まれます：  

* **セキュリティの向上** - バックエンドサーバーの情報を隠し、IPをブラックリスト化し、クライアントごとの接続数を制限  
* **スケーラビリティと柔軟性の向上** - クライアントはリバースプロキシのIPのみを認識し、サーバーのスケールや設定変更が可能  
* **SSL終了処理** - 受信リクエストを復号し、サーバー応答を暗号化することで、バックエンドサーバーがこれらの高コストな処理を行わなくて済む  
    * 各サーバーに[X.509証明書](https://en.wikipedia.org/wiki/X.509)をインストールする必要がなくなる  
* **圧縮** - サーバー応答の圧縮  
* **キャッシュ** - キャッシュされたリクエストに対して応答を返す  
* **静的コンテンツ** - 静的コンテンツを直接配信  
    * HTML/CSS/JS  
    * 写真  
    * 動画  
    * その他  

### ロードバランサーとリバースプロキシの違い  

* 複数のサーバーがある場合、ロードバランサーの導入は有用です。多くの場合、ロードバランサーは同一機能を提供するサーバー群へトラフィックを振り分けます。  
* リバースプロキシは、単一のウェブサーバーやアプリケーションサーバーでも有用であり、前述の利点を享受できます。  
* NGINXやHAProxyなどのソリューションは、レイヤ7のリバースプロキシとロードバランシングの両方をサポートします。  

### リバースプロキシの欠点  

* リバースプロキシを導入すると複雑さが増します。  
* 単一のリバースプロキシは単一障害点となり、複数のリバースプロキシ（例：[フェイルオーバー](https://en.wikipedia.org/wiki/Failover)）を設定するとさらに複雑になります。  

### 参考文献とさらなる読み物  

* [リバースプロキシ vs ロードバランサー](https://www.nginx.com/resources/glossary/reverse-proxy-vs-load-balancer/)  
* [NGINXのアーキテクチャ](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)  
* [HAProxyアーキテクチャガイド](http://www.haproxy.org/download/1.2/doc/architecture.txt)  
* [Wikipedia](https://en.wikipedia.org/wiki/Reverse_proxy)  

## アプリケーション層  

<p align="center">  
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yB5SYwm.png">  
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>出典：システムをスケールさせるためのアーキテクチャ入門</a></i>
</p>

ウェブ層をアプリケーション層（プラットフォーム層とも呼ばれる）から分離することで、両層を独立してスケールおよび構成できます。新しいAPIを追加する場合、必ずしも追加のウェブサーバーを増やすことなくアプリケーションサーバーを追加できます。**単一責任の原則**は、小さく自律的なサービスが連携して動作することを推奨します。小さなチームと小さなサービスは、急速な成長に対してより積極的な計画が可能です。

アプリケーション層のワーカーは、[非同期処理](#asynchronism)の実現も支援します。

### マイクロサービス

この議論に関連するのが[マイクロサービス](https://en.wikipedia.org/wiki/Microservices)であり、独立してデプロイ可能な小さくモジュール化されたサービス群として説明できます。各サービスは独自のプロセスを実行し、ビジネス目標を達成するために定義された軽量の通信手段を通じて連携します。<sup><a href=https://smartbear.com/learn/api-design/what-are-microservices>1</a></sup>

例えばPinterestでは、ユーザープロファイル、フォロワー、フィード、検索、写真アップロードなどのマイクロサービスが存在する可能性があります。

### サービスディスカバリ

[Consul](https://www.consul.io/docs/index.html)、[Etcd](https://coreos.com/etcd/docs/latest)、および[Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)などのシステムは、登録された名前、アドレス、ポートを追跡することでサービス同士の検出を支援します。[ヘルスチェック](https://www.consul.io/intro/getting-started/checks.html)はサービスの健全性を検証し、多くの場合[HTTP](#hypertext-transfer-protocol-http)エンドポイントを使用して行われます。ConsulとEtcdは共に構成値やその他の共有データを保存するのに便利な組み込みの[key-valueストア](#key-value-store)を備えています。

### 欠点：アプリケーション層

* ゆるく結合されたサービスを持つアプリケーション層の追加は、モノリシックシステムとは異なるアーキテクチャ、運用、プロセスのアプローチを必要とします。
* マイクロサービスはデプロイや運用の面で複雑さを増す可能性があります。

### 出典および参考資料

* [システムをスケールさせるためのアーキテクチャ入門](http://lethain.com/introduction-to-architecting-systems-for-scale)
* [システム設計面接を攻略する](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [サービス指向アーキテクチャ](https://en.wikipedia.org/wiki/Service-oriented_architecture)
* [Zookeeper入門](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)
* [マイクロサービス構築に必要なこと](https://cloudncode.wordpress.com/2016/07/22/msa-getting-started/)

## データベース

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Xkm5CXz.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>出典：最初の1000万人ユーザーへのスケーリング</a></i>
</p>

### リレーショナルデータベース管理システム（RDBMS）

リレーショナルデータベース（SQLのようなもの）は、テーブルに整理されたデータ項目の集合です。

**ACID** はリレーショナルデータベースの[トランザクション](https://en.wikipedia.org/wiki/Database_transaction)の特性のセットです。

* **Atomicity（原子性）** - 各トランザクションは全か無かである
* **Consistency（一貫性）** - いかなるトランザクションもデータベースを有効な状態から別の有効な状態へと変える
* **Isolation（独立性）** - トランザクションを同時に実行しても、直列に実行した場合と同じ結果になる
* **Durability（永続性）** - 一度コミットされたトランザクションは保持され続ける

リレーショナルデータベースをスケールさせる手法は多数あります：**マスター・スレーブレプリケーション**、**マスター・マスターレプリケーション**、**フェデレーション**、**シャーディング**、**非正規化**、および**SQLチューニング**。

#### マスター・スレーブレプリケーション

マスターは読み書きを提供し、書き込みを一つ以上のスレーブにレプリケートします。スレーブは読み込みのみを提供します。スレーブはさらに木構造のように別のスレーブにレプリケートすることもできます。マスターがオフラインになった場合、スレーブがマスターに昇格されるか新しいマスターが用意されるまで、システムは読み取り専用モードで動作を続けられます。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/C9ioGtn.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>出典: Scalability, availability, stability, patterns</a></i>
</p>

##### 欠点：マスター・スレーブレプリケーション

* スレーブをマスターに昇格させるための追加のロジックが必要です。
* **マスター・スレーブ** と **マスター・マスター** の両方に関係する点は [欠点：レプリケーション](#disadvantages-replication) を参照してください。

#### マスター・マスターレプリケーション

両方のマスターが読み書きを提供し、書き込みに関しては互いに調整します。どちらかのマスターがダウンしても、システムは読み書きの両方を継続して動作できます。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/krAHLGg.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>出典: Scalability, availability, stability, patterns</a></i>
</p>

##### 欠点：マスター・マスターレプリケーション

* ロードバランサーが必要になるか、書き込み先を決定するためにアプリケーションロジックを変更する必要があります。
* ほとんどのマスター・マスターシステムは緩やかに整合性が保たれている（ACIDを破る）か、同期による書き込み遅延が増加します。
* コンフリクト解決は、書き込みノードが増え、レイテンシが増加するにつれてより重要になります。
* マスター・スレーブおよびマスター・マスターの**両方**に関連するポイントについては、[欠点：レプリケーション](#disadvantages-replication)を参照してください。

##### 欠点：レプリケーション

* マスターが新たに書き込まれたデータを他のノードにレプリケートする前に障害が発生した場合、データが失われる可能性があります。
* 書き込みはリードレプリカにリプレイされます。書き込みが多いと、リードレプリカは書き込みのリプレイで遅くなり、読み込み処理が減少します。
* リードスレーブが多いほど、レプリケーションする量が増え、レプリケーション遅延が大きくなります。
* 一部のシステムでは、マスターへの書き込みは複数のスレッドで並列に行われますが、リードレプリカは単一スレッドで順次書き込みのみサポートします。
* レプリケーションはハードウェアの追加と複雑さを増加させます。

##### 参考文献および詳細：レプリケーション

* [スケーラビリティ、可用性、安定性、パターン](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [マルチマスター・レプリケーション](https://en.wikipedia.org/wiki/Multi-master_replication)

#### フェデレーション

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/U3qV33e.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>出典：初めての1000万人ユーザーへのスケーリング</a></i>
</p>

フェデレーション（または機能的パーティショニング）は、データベースを機能ごとに分割します。例えば、単一のモノリシックなデータベースの代わりに、**フォーラム**、**ユーザー**、**製品**の3つのデータベースを持つことで、各データベースへの読み書きトラフィックが減り、その結果レプリケーション遅延が少なくなります。小さいデータベースはメモリに収まるデータが増え、キャッシュの局所性が向上するためキャッシュヒット率が上がります。単一の中央マスターが書き込みを直列化しないため、並列に書き込むことができ、スループットが向上します。

##### 欠点：フェデレーション

* スキーマが巨大な関数やテーブルを必要とする場合、フェデレーションは効果的ではありません。
* どのデータベースを読み書きするかを判断するためにアプリケーションロジックを更新する必要があります。
* 2つのデータベースからのデータ結合は、[サーバーリンク](http://stackoverflow.com/questions/5145637/querying-data-by-joining-two-tables-in-two-database-on-different-servers)を使うためより複雑です。
* フェデレーションはハードウェアの追加と複雑さを増加させます。

##### 参考文献および詳細：フェデレーション

* [初めての1000万人ユーザーへのスケーリング](https://www.youtube.com/watch?v=kKjm4ehYiMs)

#### シャーディング

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wU8x5Id.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>出典：スケーラビリティ、可用性、安定性、パターン</a></i>
</p>

シャーディングはデータを異なるデータベースに分散させ、各データベースがデータのサブセットのみを管理できるようにします。ユーザーデータベースを例に取ると、ユーザー数が増えるにつれて、クラスターにシャードが追加されます。

[federation](#federation)の利点と同様に、シャーディングは読み書きトラフィックの減少、レプリケーションの減少、キャッシュヒットの増加をもたらします。インデックスサイズも減少し、一般的にクエリの高速化によってパフォーマンスが向上します。1つのシャードがダウンしても他のシャードは稼働し続けますが、データ損失を防ぐために何らかのレプリケーションを追加する必要があります。federationと同様に、書き込みを直列化する単一の中央マスターがないため、スループットを増加させて並列書き込みが可能です。

ユーザーテーブルをシャーディングする一般的な方法は、ユーザーの姓のイニシャルや地理的位置によるものです。

##### 欠点：シャーディング

* シャードに対応するためにアプリケーションロジックを更新する必要があり、複雑なSQLクエリになる可能性があります。
* データの分布がシャード内で偏ることがあります。例えば、特定のシャードにパワーユーザーが集中すると、そのシャードの負荷が他より増加します。
    * リバランスはさらなる複雑さを加えます。[一貫性ハッシュ](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)に基づくシャーディング関数は転送データ量を減らせます。
* 複数シャードのデータを結合するのはより複雑です。
* シャーディングはハードウェアと複雑さを増やします。

##### 出典およびさらなる参考資料：シャーディング

* [The coming of the shard](http://highscalability.com/blog/2009/8/6/an-unorthodox-approach-to-database-design-the-coming-of-the.html)
* [Shard database architecture](https://en.wikipedia.org/wiki/Shard_(database_architecture))
* [Consistent hashing](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)

#### 非正規化

非正規化は書き込み性能を一部犠牲にして読み取り性能を向上させることを試みます。高価な結合を避けるために、冗長なデータコピーを複数のテーブルに書き込みます。[PostgreSQL](https://ja.wikipedia.org/wiki/PostgreSQL)やOracleなど一部のRDBMSは、冗長情報の保持とコピーの一貫性維持を処理する[マテリアライズドビュー](https://ja.wikipedia.org/wiki/マテリアライズドビュー)をサポートしています。

[federation](#federation)や[sharding](#sharding)のような技術でデータが分散されると、データセンター間の結合管理はさらに複雑になります。非正規化はそのような複雑な結合の必要性を回避するかもしれません。

ほとんどのシステムでは、読み取りが書き込みを100:1または1000:1で大幅に上回ることがあります。複雑なデータベース結合を伴う読み取りは非常にコストがかかり、多くの時間をディスク操作に費やします。

##### 欠点：非正規化

* データが重複します。
* 制約は冗長な情報コピーの同期を助けますが、データベース設計の複雑さを増します。
* 非正規化データベースは書き込み負荷が高いと、正規化されたものより性能が悪化することがあります。

###### 出典およびさらなる参考資料：非正規化
* [非正規化](https://ja.wikipedia.org/wiki/非正規化)

#### SQL チューニング

SQL チューニングは広範なトピックであり、多くの[書籍](https://www.amazon.com/s/ref=nb_sb_noss_2?url=search-alias%3Daps&field-keywords=sql+tuning)が参考資料として書かれています。

**ベンチマーク**および**プロファイリング**を行い、ボトルネックをシミュレートして発見することが重要です。

* **ベンチマーク** - [ab](http://httpd.apache.org/docs/2.2/programs/ab.html)などのツールで高負荷状況をシミュレートします。
* **プロファイル** - [スロークエリログ](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)などのツールを有効にしてパフォーマンス問題の追跡を支援します。

ベンチマークとプロファイリングによって、次の最適化が示唆されることがあります。

##### スキーマを厳密にする

* MySQLは高速アクセスのためにディスクに連続したブロックでダンプします。
* 固定長フィールドには `CHAR` を使用します。
    * `CHAR` は高速なランダムアクセスを可能にしますが、`VARCHAR` は次の文字列に移動する前に文字列の終端を見つける必要があります。
* ブログ投稿などの大きなテキストブロックには `TEXT` を使います。`TEXT` はブール検索も可能です。`TEXT` フィールドを使用すると、テキストブロックを特定するためのポインタがディスクに保存されます。
* 2^32（約40億）までの大きな数値には `INT` を使います。
* 浮動小数点の表現誤差を避けるために通貨には `DECIMAL` を使います。
* 大きな `BLOB` を保存するのは避け、代わりにオブジェクトの取得場所を保存します。
* `VARCHAR(255)` は8ビット数でカウントできる最大の文字数であり、多くのRDBMSでバイトの使用を最大化します。
* 適用可能な場合は `NOT NULL` 制約を設定して[検索性能を改善](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)します。

##### 良いインデックスを使う

* クエリで使用するカラム（`SELECT`、`GROUP BY`、`ORDER BY`、`JOIN`）はインデックスで高速化できます。
* インデックスは通常、データをソートし、探索、順次アクセス、挿入、削除を対数時間で行う自己平衡型の[B木](https://ja.wikipedia.org/wiki/B木)として表されます。
* インデックスを配置するとデータをメモリに保持でき、より多くのスペースを要します。
* インデックスも更新する必要があるため、書き込みは遅くなることがあります。
* 大量データのロード時はインデックスを無効化し、ロード後に再構築する方が速い場合があります。

##### 高コストなジョインを避ける

* パフォーマンスが求められる場合は[非正規化](#非正規化)を行います。

##### テーブルをパーティション分割する


* ホットスポットを別のテーブルに分割してメモリに保持しやすくする。

##### クエリキャッシュの調整

* 場合によっては、[クエリキャッシュ](https://dev.mysql.com/doc/refman/5.7/en/query-cache.html)が[パフォーマンスの問題](https://www.percona.com/blog/2016/10/12/mysql-5-7-performance-tuning-immediately-after-installation/)を引き起こすことがある。

##### 出典および参考文献：SQLチューニング

* [MySQLクエリ最適化のためのヒント](http://aiddroid.com/10-tips-optimizing-mysql-queries-dont-suck/)
* [なぜVARCHAR(255)が頻繁に使われるのか？](http://stackoverflow.com/questions/1217466/is-there-a-good-reason-i-see-varchar255-used-so-often-as-opposed-to-another-l)
* [NULL値はパフォーマンスにどう影響するか？](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)
* [スロークエリログ](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)

### NoSQL

NoSQLは**キー・バリュー・ストア**、**ドキュメントストア**、**ワイドカラムストア**、または**グラフデータベース**で表現されるデータ項目の集合である。 データは非正規化されており、結合は一般的にアプリケーションコード内で行われる。 多くのNoSQLストアは真のACIDトランザクションを欠き、[最終的整合性](#eventual-consistency)を重視する。

**BASE**はNoSQLデータベースの特性を表すために使われることが多い。 [CAP定理](#cap-theorem)と比較すると、BASEは一貫性よりも可用性を優先する。

* **基本的に利用可能** - システムは可用性を保証する。
* **ソフトステート** - システムの状態は入力がなくても時間とともに変化する可能性がある。
* **最終的整合性** - システムは一定期間入力がなければ整合性が取れる状態になる。

[SQLかNoSQLか](#sql-or-nosql)の選択に加えて、どのタイプのNoSQLデータベースがユースケースに最適かを理解することが有用である。 次節では**キー・バリュー・ストア**、**ドキュメントストア**、**ワイドカラムストア**、**グラフデータベース**をレビューする。

#### キー・バリュー・ストア

> 抽象化：ハッシュテーブル

キー・バリュー・ストアは一般的にO(1)の読み書きを可能にし、メモリまたはSSDでバックアップされることが多い。 データストアは[辞書式順序](https://en.wikipedia.org/wiki/Lexicographical_order)でキーを保持でき、キー範囲の効率的な取得を可能にする。 キー・バリュー・ストアは値にメタデータを格納することもできる。

キー・バリュー・ストアは高いパフォーマンスを提供し、シンプルなデータモデルやインメモリキャッシュ層のような急速に変化するデータによく使われる。 限られた操作セットのみを提供するため、追加の操作が必要な場合は複雑さがアプリケーション層に移る。

キー・バリュー・ストアはドキュメントストアや場合によってはグラフデータベースのようなより複雑なシステムの基礎となる。

##### 出典および参考文献：キー・バリュー・ストア

* [キー・バリュー・データベース](https://en.wikipedia.org/wiki/Key-value_database)
* [キー・バリュー・ストアの欠点](http://stackoverflow.com/questions/4056093/what-are-the-disadvantages-of-using-a-key-value-table-over-nullable-columns-or)
* [Redisのアーキテクチャ](http://qnimate.com/overview-of-redis-architecture/)
* [Memcachedのアーキテクチャ](https://adayinthelifeof.nl/2011/02/06/memcache-internals/)

#### ドキュメントストア

> 抽象化: ドキュメントを値として格納するキー・バリュー・ストア

ドキュメントストアはドキュメント（XML、JSON、バイナリなど）を中心に設計されており、ドキュメントは特定のオブジェクトに関するすべての情報を格納します。ドキュメントストアは、ドキュメント内部の構造に基づいてクエリを実行するためのAPIやクエリ言語を提供します。*注：多くのキー・バリュー・ストアは値のメタデータを扱う機能を含んでおり、これら二つのストレージタイプの境界を曖昧にしています。*

基盤となる実装により、ドキュメントはコレクション、タグ、メタデータ、またはディレクトリによって組織化されます。ドキュメントはグループ化されることもありますが、ドキュメント同士が全く異なるフィールドを持つ場合もあります。

[MongoDB](https://www.mongodb.com/mongodb-architecture)や[CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)のような一部のドキュメントストアは、複雑なクエリを実行するためのSQLに似た言語も提供しています。[DynamoDB](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf)はキー・バリューとドキュメントの両方をサポートしています。

ドキュメントストアは高い柔軟性を持ち、時折変更されるデータを扱う場合によく使われます。

##### 参考文献およびさらなる学習: ドキュメントストア

* [ドキュメント指向データベース](https://ja.wikipedia.org/wiki/%E3%83%89%E3%82%AD%E3%83%A5%E3%83%A1%E3%83%B3%E3%83%88%E6%8C%87%E5%90%91%E3%83%87%E3%83%BC%E3%82%BF%E3%83%99%E3%83%BC%E3%82%B9)
* [MongoDBのアーキテクチャ](https://www.mongodb.com/mongodb-architecture)
* [CouchDBのアーキテクチャ](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)
* [Elasticsearchのアーキテクチャ](https://www.elastic.co/blog/found-elasticsearch-from-the-bottom-up)

#### ワイドカラムストア

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n16iOGk.png">
  <br/>
  <i><a href=http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html>出典: SQL & NoSQL、簡単な歴史</a></i>
</p>

> 抽象化: ネストされたマップ `ColumnFamily<RowKey, Columns<ColKey, Value, Timestamp>>`

ワイドカラムストアの基本データ単位はカラム（名前/値のペア）です。カラムはカラムファミリー（SQLのテーブルに類似）にグループ化されます。スーパーカラムファミリーはさらにカラムファミリーをグループ化します。行キーで各カラムに独立してアクセスでき、同じ行キーのカラムが行を形成します。各値にはバージョニングや競合解決のためのタイムスタンプが含まれます。

Googleは最初のワイドカラムストアとして[Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)を導入し、これがHadoopエコシステムでよく使われるオープンソースの[HBase](https://www.edureka.co/blog/hbase-architecture/)やFacebookの[Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)に影響を与えました。BigTable、HBase、Cassandraなどのストアはキーを辞書順で保持し、選択的なキー範囲の効率的な取得を可能にしています。

ワイドカラムストアは高い可用性と高いスケーラビリティを提供し、非常に大規模なデータセットによく使用されます。

##### 参考文献およびさらなる学習: ワイドカラムストア

* [SQL & NoSQL、簡単な歴史](http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html)
* [Bigtableアーキテクチャ](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)
* [HBaseアーキテクチャ](https://www.edureka.co/blog/hbase-architecture/)
* [Cassandraアーキテクチャ](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)

#### グラフデータベース

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/fNcl65g.png">
  <br/>
  <i><a href=https://en.wikipedia.org/wiki/File:GraphDatabase_PropertyGraph.png>出典：グラフデータベース</a></i>
</p>

> 抽象化：グラフ

グラフデータベースでは、各ノードがレコードであり、各アークが2つのノード間の関係を表します。グラフデータベースは、多数の外部キーや多対多の関係を持つ複雑な関係を表現するように最適化されています。

グラフデータベースは、ソーシャルネットワークのような複雑な関係を持つデータモデルに対して高いパフォーマンスを提供します。比較的新しい技術であり、まだ広く使われていないため、開発ツールやリソースを見つけるのが難しい場合があります。多くのグラフは[REST API](#representational-state-transfer-rest)でのみアクセス可能です。

##### 出典および追加資料：グラフ

* [グラフデータベース](https://en.wikipedia.org/wiki/Graph_database)
* [Neo4j](https://neo4j.com/)
* [FlockDB](https://blog.twitter.com/2010/introducing-flockdb)

#### 出典および追加資料：NoSQL

* [BASE用語の説明](http://stackoverflow.com/questions/3342497/explanation-of-base-terminology)
* [NoSQLデータベースの調査と意思決定ガイダンス](https://medium.com/baqend-blog/nosql-databases-a-survey-and-decision-guidance-ea7823a822d#.wskogqenq)
* [スケーラビリティ](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
* [NoSQL入門](https://www.youtube.com/watch?v=qI_g07C_Q5I)
* [NoSQLパターン](http://horicky.blogspot.com/2009/11/nosql-patterns.html)

### SQLまたはNoSQL

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wXGqG5f.png">
  <br/>
  <i><a href=https://www.infoq.com/articles/Transition-RDBMS-NoSQL/>出典：RDBMSからNoSQLへの移行</a></i>
</p>

**SQL**を選ぶ理由:

* 構造化データ
* 厳密なスキーマ
* リレーショナルデータ
* 複雑な結合が必要
* トランザクション
* スケーリングのための明確なパターン
* より確立されている：開発者、コミュニティ、コード、ツールなど
* インデックスによるルックアップが非常に高速

**NoSQL**を選ぶ理由:

* 半構造化データ
* 動的または柔軟なスキーマ
* 非リレーショナルデータ
* 複雑な結合が不要
* 多数のTB（またはPB）のデータを保存
* 非常にデータ集約型のワークロード
* 非常に高いIOPSスループット

NoSQLに適したサンプルデータ:

* クリックストリームやログデータの迅速な取り込み
* リーダーボードやスコアリングデータ
* ショッピングカートのような一時データ
* 頻繁にアクセスされる（「ホット」）テーブル
* メタデータ／ルックアップテーブル

##### 出典およびさらなる参考資料: SQLまたはNoSQL

* [最初の1000万人ユーザーまでのスケーリング](https://www.youtube.com/watch?v=kKjm4ehYiMs)
* [SQLとNoSQLの違い](https://www.sitepoint.com/sql-vs-nosql-differences/)

## キャッシュ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Q6z24La.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>出典: スケーラブルなシステム設計パターン</a></i>
</p>

キャッシュはページの読み込み時間を改善し、サーバーやデータベースの負荷を軽減できます。このモデルでは、ディスパッチャーがまずリクエストが以前に行われたかどうかを確認し、実際の実行を省くために以前の結果を返そうとします。

データベースは通常、パーティション全体で読み書きが均等に分布することで恩恵を受けます。人気のあるアイテムは分布を偏らせ、ボトルネックを引き起こす可能性があります。データベースの前にキャッシュを置くことで、不均等な負荷やトラフィックの急増を吸収できます。

### クライアントキャッシュ

キャッシュはクライアント側（OSやブラウザ）、[サーバー側](#reverse-proxy-web-server)、または独立したキャッシュ層に配置できます。

### CDNキャッシュ

[CDN](#content-delivery-network)はキャッシュの一種と見なされます。

### ウェブサーバーキャッシュ

[リバースプロキシ](#reverse-proxy-web-server)や[Varnish](https://www.varnish-cache.org/)のようなキャッシュは静的および動的コンテンツを直接提供できます。ウェブサーバーもリクエストをキャッシュし、アプリケーションサーバーに連絡せずにレスポンスを返せます。

### データベースキャッシュ

データベースは通常、デフォルト設定で何らかのキャッシュレベルを含み、汎用的なユースケースに最適化されています。特定の使用パターンに合わせてこれらの設定を調整すると、さらにパフォーマンスを向上させることができます。

### アプリケーションキャッシュ

MemcachedやRedisのようなインメモリキャッシュは、アプリケーションとデータストレージの間にあるキー・バリューストアです。データがRAMに保持されるため、通常ディスクに保存されるデータベースよりもはるかに高速です。RAMはディスクよりも容量が限られているため、[キャッシュ無効化](https://ja.wikipedia.org/wiki/キャッシュアルゴリズム)アルゴリズム（例えば[最も最近使われていない（LRU）](https://ja.wikipedia.org/wiki/キャッシュ置換アルゴリズム#最も最近使われていない_(LRU))）が「冷たい」エントリを無効化し、「熱い」データをRAMに保持するのに役立ちます。

Redisには以下の追加機能があります：

* 永続化オプション
* ソート済みセットやリストなどの組み込みデータ構造

キャッシュできるレベルは複数あり、大きく分けて**データベースクエリ**と**オブジェクト**の2種類があります：

* 行レベル
* クエリレベル
* 完全に形成されたシリアライズ可能なオブジェクト
* 完全にレンダリングされたHTML

一般的に、ファイルベースのキャッシュはクローン作成やオートスケーリングを難しくするため避けるべきです。

### データベースクエリレベルでのキャッシュ

データベースをクエリするたびに、クエリをキーとしてハッシュ化し、その結果をキャッシュに保存します。この方法は有効期限の問題があります：

* 複雑なクエリのキャッシュ結果を削除するのが難しい
* テーブルのセルなど一部のデータが変更された場合、変更されたセルを含む可能性のあるすべてのキャッシュクエリを削除する必要がある

### オブジェクトレベルでのキャッシュ

データをアプリケーションコードと同様にオブジェクトとして見なします。アプリケーションがデータベースからのデータセットをクラスインスタンスやデータ構造に組み立てます：

* 基盤となるデータが変更された場合、オブジェクトをキャッシュから削除する
* 非同期処理を可能にする：ワーカーは最新のキャッシュされたオブジェクトを利用してオブジェクトを組み立てる

キャッシュすべきものの提案：

* ユーザーセッション
* 完全にレンダリングされたウェブページ
* アクティビティストリーム
* ユーザーグラフデータ

### キャッシュを更新するタイミング

キャッシュに保存できるデータ量は限られているため、ユースケースに最適なキャッシュ更新戦略を決定する必要があります。

#### Cache-aside

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/ONjORqk.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>出典: From cache to in-memory data grid</a></i>
</p>

アプリケーションがストレージからの読み書きを担当します。キャッシュはストレージと直接やり取りしません。アプリケーションの動作は以下の通りです：

* キャッシュ内のエントリを探すが、キャッシュミスとなる
* データベースからエントリを読み込む
* エントリをキャッシュに追加する
* エントリを返す

```python
def get_user(self, user_id):
    user = cache.get("user.{0}", user_id)
    if user is None:
        user = db.query("SELECT * FROM users WHERE user_id = {0}", user_id)
        if user is not None:
            key = "user.{0}".format(user_id)
            cache.set(key, json.dumps(user))
    return user
```
[Memcached](https://memcached.org/) は一般的にこのように使用されます。

キャッシュに追加されたデータの後続の読み取りは高速です。Cache-asideはレイジーローディングとも呼ばれます。要求されたデータのみがキャッシュされ、要求されていないデータでキャッシュが埋まるのを防ぎます。

##### 欠点: cache-aside

* キャッシュミスごとに3回の往復が発生し、目に見える遅延を引き起こす可能性があります。
* データベースで更新された場合、データが古くなる可能性があります。この問題は、キャッシュエントリの更新を強制するTTL（有効期限）を設定するか、ライトスルーを使用することで緩和されます。
* ノードが故障した場合、新しい空のノードに置き換えられ、レイテンシが増加します。

#### ライトスルー

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/0vBc0hN.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>出典: Scalability, availability, stability, patterns</a></i>
</p>

アプリケーションはキャッシュを主要なデータストアとして使用し、読み書きを行い、キャッシュはデータベースへの読み書きを担当します：

* アプリケーションがキャッシュにエントリを追加/更新
* キャッシュが同期的にデータストアにエントリを書き込み
* 戻り値を返す

アプリケーションコード：


```python
set_user(12345, {"foo":"bar"})
```
キャッシュコード：


```python
def set_user(user_id, values):
    user = db.query("UPDATE Users WHERE id = {0}", user_id, values)
    cache.set(user_id, user)
```

ライトスルーは書き込み操作のため全体的に遅いですが、直後に書き込まれたデータの読み取りは高速です。ユーザーはデータの更新よりも読み取り時の遅延を一般的により許容します。キャッシュ内のデータは古くありません。

##### デメリット：ライトスルー

* 障害やスケーリングにより新しいノードが作成された場合、そのノードはデータベースでエントリが更新されるまでエントリをキャッシュしません。キャッシュアサイドとライトスルーを組み合わせることでこの問題を軽減できます。
* 書き込まれたデータの多くは一度も読み取られない可能性があり、TTLでこれを最小化できます。

#### ライトビハインド（ライトバック）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/rgSrvjG.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>出典：スケーラビリティ、可用性、安定性パターン</a></i>
</p>

ライトビハインドでは、アプリケーションは以下を行います：

* キャッシュにエントリを追加／更新
* 非同期でデータストアにエントリを書き込み、書き込み性能を向上させる

##### デメリット：ライトビハインド

* キャッシュの内容がデータストアに反映される前にキャッシュがダウンするとデータ損失が発生する可能性があります。
* ライトビハインドはキャッシュアサイドやライトスルーよりも実装が複雑です。

#### リフレッシュアヘッド

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/kxtjqgE.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>出典：キャッシュからインメモリデータグリッドへ</a></i>
</p>

キャッシュは自動的に最近アクセスされたキャッシュエントリを期限切れ前にリフレッシュするよう設定できます。

リフレッシュアヘッドは、キャッシュが将来必要とされる可能性のあるアイテムを正確に予測できれば、リードスルーよりもレイテンシを低減できます。

##### デメリット：リフレッシュアヘッド

* 将来必要になる可能性が高いアイテムを正確に予測できないと、リフレッシュアヘッドなしの場合よりもパフォーマンスが低下することがある。

### 欠点: キャッシュ

* キャッシュとデータベースなどの真実のソースとの一貫性を[キャッシュ無効化](https://ja.wikipedia.org/wiki/%E3%82%AD%E3%83%A3%E3%83%83%E3%82%B7%E3%83%A5%E3%82%A2%E3%83%AB%E4%BB%A3%E6%9B%BF)を通じて維持する必要がある。
* キャッシュ無効化は難しい問題であり、いつキャッシュを更新するかに関する追加の複雑さがある。
* Redisやmemcachedの追加など、アプリケーションの変更が必要になる。

### 参考文献およびさらなる読み物

* [キャッシュからインメモリデータグリッドへ](http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast)
* [スケーラブルシステム設計パターン](http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html)
* [スケールのためのシステム設計入門](http://lethain.com/introduction-to-architecting-systems-for-scale/)
* [スケーラビリティ、可用性、安定性のパターン](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [スケーラビリティ](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
* [AWS ElastiCache戦略](http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Strategies.html)
* [ウィキペディア](https://ja.wikipedia.org/wiki/%E3%82%AD%E3%83%A3%E3%83%83%E3%82%B7%E3%83%A5_(%E3%82%B3%E3%83%B3%E3%83%94%E3%83%A5%E3%83%BC%E3%83%86%E3%82%A3%E3%83%B3%E3%82%B0))

## 非同期処理

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/54GYsSx.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>出典: スケールのためのシステム設計入門</a></i>
</p>

非同期ワークフローは、インラインで実行すると高コストな操作のリクエスト時間を短縮するのに役立つ。また、定期的なデータ集約など、時間のかかる作業を事前に行うことにも役立つ。

### メッセージキュー

メッセージキューはメッセージの受信、保持、配信を行う。操作がインラインで行うには遅すぎる場合、以下のワークフローでメッセージキューを利用できる。

* アプリケーションがジョブをキューに公開し、ユーザーにジョブの状態を通知する。
* ワーカーがキューからジョブを取得して処理し、ジョブの完了を通知する。

ユーザーはブロックされず、ジョブはバックグラウンドで処理される。この間、クライアントはタスクが完了したかのように見せるために少量の処理を行うことがある。たとえば、ツイートを投稿する場合、ツイートは即座にタイムラインに表示されるが、実際にすべてのフォロワーに配信されるまでには時間がかかることがある。

**[Redis](https://redis.io/)** はシンプルなメッセージブローカーとして有用だが、メッセージが失われる可能性がある。

**[RabbitMQ](https://www.rabbitmq.com/)** は人気があるが、'AMQP'プロトコルに適応し、自分でノードを管理する必要がある。
**[Amazon SQS](https://aws.amazon.com/sqs/)** はホスト型ですが、高遅延が発生する可能性があり、メッセージが二重に配信される可能性があります。

### タスクキュー

タスクキューはタスクと関連データを受け取り、それを実行し、結果を届けます。スケジューリングをサポートでき、計算負荷の高いジョブをバックグラウンドで実行するのに利用可能です。

**[Celery](https://docs.celeryproject.org/en/stable/)** はスケジューリングをサポートし、主にPythonでのサポートがあります。

### バックプレッシャー

キューのサイズが大幅に増加すると、キューサイズがメモリ容量を超え、キャッシュミスやディスク読み込みが発生し、さらにパフォーマンスが低下します。[バックプレッシャー](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html) はキューサイズを制限することで、スループット率を維持し、キュー内のジョブに対して良好な応答時間を保つのに役立ちます。キューが満杯になると、クライアントはサーバービジーやHTTP 503ステータスコードを受け取り、後で再試行を促されます。クライアントは後でリクエストを再試行でき、[指数バックオフ](https://en.wikipedia.org/wiki/Exponential_backoff)を用いることもあります。

### デメリット：非同期性

* 安価な計算やリアルタイムワークフローのようなユースケースには、キューを導入すると遅延や複雑さが増すため、同期処理の方が適している場合があります。

### 出典および参考文献

* [It's all a numbers game](https://www.youtube.com/watch?v=1KRYH75wgy4)
* [Applying back pressure when overloaded](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)
* [Little's law](https://en.wikipedia.org/wiki/Little%27s_law)
* [What is the difference between a message queue and a task queue?](https://www.quora.com/What-is-the-difference-between-a-message-queue-and-a-task-queue-Why-would-a-task-queue-require-a-message-broker-like-RabbitMQ-Redis-Celery-or-IronMQ-to-function)

## 通信

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/5KeocQs.jpg">
  <br/>
  <i><a href=http://www.escotal.com/osilayer.html>出典: OSI 7層モデル</a></i>
</p>

### ハイパーテキスト転送プロトコル（HTTP）

HTTPはクライアントとサーバー間でデータをエンコードし転送する方法です。リクエスト/レスポンス型のプロトコルであり、クライアントはリクエストを発行し、サーバーは関連コンテンツとリクエストの完了状態情報を含むレスポンスを返します。HTTPは自己完結型であり、多くの中間ルーターやサーバーを経由してロードバランシング、キャッシュ、暗号化、圧縮を行いながらリクエストとレスポンスが流れます。

基本的なHTTPリクエストは動詞（メソッド）とリソース（エンドポイント）で構成されます。以下は一般的なHTTP動詞です：

| 動詞 | 説明 | 冪等* | 安全 | キャッシュ可能 |
|---|---|---|---|---|

| GET | リソースを読み取る | はい | はい | はい |
| POST | リソースを作成するか、データを処理するプロセスをトリガーする | いいえ | いいえ | レスポンスに新鮮さ情報が含まれる場合ははい |
| PUT | リソースを作成または置き換える | はい | いいえ | いいえ |
| PATCH | リソースを部分的に更新する | いいえ | いいえ | レスポンスに新鮮さ情報が含まれる場合ははい |
| DELETE | リソースを削除する | はい | いいえ | いいえ |

* 結果が変わらない場合、何度でも呼び出せます。

HTTPは、**TCP**や**UDP**などの下位プロトコルに依存するアプリケーション層プロトコルです。

#### 出典およびさらなる読み物: HTTP

* [HTTPとは？](https://www.nginx.com/resources/glossary/http/)
* [HTTPとTCPの違い](https://www.quora.com/What-is-the-difference-between-HTTP-protocol-and-TCP-protocol)
* [PUTとPATCHの違い](https://laracasts.com/discuss/channels/general-discussion/whats-the-differences-between-put-and-patch?page=1)

### トランスミッションコントロールプロトコル（TCP）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/JdAsdvG.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>出典：マルチプレイヤーゲームの作り方</a></i>
</p>

TCPは[IPネットワーク](https://ja.wikipedia.org/wiki/インターネットプロトコル)上のコネクション指向プロトコルです。接続は[ハンドシェイク](https://ja.wikipedia.org/wiki/ハンドシェイク)を使って確立および終了されます。送信されるすべてのパケットは、次の方法で元の順序で破損なく宛先に届くことが保証されます：

* 各パケットに対するシーケンス番号と[チェックサムフィールド](https://ja.wikipedia.org/wiki/トランスミッション制御プロトコル#チェックサム計算)
* [確認応答](https://ja.wikipedia.org/wiki/確認応答)パケットと自動再送信

送信者が正しい応答を受け取らない場合、パケットを再送します。タイムアウトが複数回発生すると接続は切断されます。TCPはまた、[フロー制御](https://ja.wikipedia.org/wiki/フロー制御)と[輻輳制御](https://ja.wikipedia.org/wiki/ネットワーク輻輳#輻輳制御)も実装しています。これらの保証は遅延を引き起こし、一般的にUDPより効率の悪い伝送となります。

高スループットを確保するために、ウェブサーバーは多数のTCP接続を開いたままにでき、その結果メモリ使用量が増加します。ウェブサーバースレッドと例えば[memcached](https://memcached.org/)サーバー間で多数の開いた接続を持つことはコストがかかります。[コネクションプーリング](https://ja.wikipedia.org/wiki/コネクションプーリング)は、適用可能な場合はUDPへの切り替えに加えて役立ちます。

TCPは高い信頼性が必要で時間的制約が比較的少ないアプリケーションに有用です。例としてウェブサーバー、データベース情報、SMTP、FTP、SSHなどがあります。

UDPよりTCPを使う場合：

* すべてのデータが完全に届く必要がある場合
* ネットワークスループットの最善推定を自動的に行いたい場合

### ユーザーデータグラムプロトコル（UDP）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yzDrJtA.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>出典: マルチプレイヤーゲームの作り方</a></i>
</p>

UDPはコネクションレスです。データグラム（パケットに類似）はデータグラムレベルでのみ保証されます。データグラムは順序が入れ替わって届くことや、全く届かないこともあります。UDPは輻輳制御をサポートしません。TCPがサポートする保証がないため、UDPは一般的により効率的です。

UDPはブロードキャストが可能で、サブネット上の全デバイスにデータグラムを送信します。これはクライアントがまだIPアドレスを受け取っていないため、TCPがIPアドレスなしでストリームを送る方法を妨げる[DHCP](https://ja.wikipedia.org/wiki/Dynamic_Host_Configuration_Protocol)で有用です。

UDPは信頼性は低いですが、VoIP、ビデオチャット、ストリーミング、リアルタイムマルチプレイヤーゲームなどのリアルタイム用途に適しています。

UDPをTCPの代わりに使うのは以下の場合です：

* 最低の遅延が必要なとき
* 遅延したデータはデータ損失より悪いとき
* 独自の誤り訂正を実装したいとき

#### 出典およびさらなる読み物: TCPとUDP

* [ゲームプログラミングのためのネットワーキング](http://gafferongames.com/networking-for-game-programmers/udp-vs-tcp/)
* [TCPとUDPプロトコルの主な違い](http://www.cyberciti.biz/faq/key-differences-between-tcp-and-udp-protocols/)
* [TCPとUDPの違い](http://stackoverflow.com/questions/5970383/difference-between-tcp-and-udp)
* [伝送制御プロトコル](https://ja.wikipedia.org/wiki/Transmission_Control_Protocol)
* [ユーザーデータグラムプロトコル](https://ja.wikipedia.org/wiki/User_Datagram_Protocol)
* [Facebookのmemcacheスケーリング](http://www.cs.bu.edu/~jappavoo/jappavoo.github.com/451/papers/memcache-fb.pdf)

### リモートプロシージャコール（RPC）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/iF4Mkb5.png">
  <br/>
  <i><a href=http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview>出典: システム設計面接を攻略する</a></i>
</p>

RPCでは、クライアントが通常リモートサーバーの異なるアドレス空間でプロシージャを実行させます。プロシージャはローカルプロシージャコールのようにコード化されており、クライアントプログラムからサーバーとの通信方法の詳細を抽象化しています。リモートコールは通常ローカルコールより遅く信頼性が低いため、RPCコールとローカルコールを区別することが有用です。代表的なRPCフレームワークには[Protobuf](https://developers.google.com/protocol-buffers/)、[Thrift](https://thrift.apache.org/)、[Avro](https://avro.apache.org/docs/current/)があります。

RPCはリクエスト-レスポンスプロトコルです：

* **クライアントプログラム** - クライアントスタブ手続きを呼び出します。パラメータはローカル手続き呼び出しのようにスタックにプッシュされます。
* **クライアントスタブ手続き** - 手続きIDと引数をリクエストメッセージにマーシャリング（パック）します。
* **クライアント通信モジュール** - OSがクライアントからサーバへメッセージを送信します。
* **サーバ通信モジュール** - OSが受信パケットをサーバスタブ手続きに渡します。
* **サーバスタブ手続き** - 結果をアンマーシャルし、手続きIDに対応するサーバ手続きを呼び出し、引数を渡します。
* サーバの応答は上記の手順を逆順で繰り返します。

サンプルRPC呼び出し:

```
GET /someoperation?data=anId

POST /anotheroperation
{
  "data":"anId";
  "anotherdata": "another value"
}
```
RPCは動作の公開に焦点を当てています。RPCは内部通信でパフォーマンス上の理由からよく使用されます。ネイティブ呼び出しを手作業で作成してユースケースにより適合させることができるためです。

ネイティブライブラリ（別名SDK）を選択する場合：

* 対象プラットフォームが明確である。
* 「ロジック」へのアクセス方法を制御したい。
* ライブラリ外でのエラー制御の方法を制御したい。
* パフォーマンスとエンドユーザーの体験が最優先である。

**REST**に従ったHTTP APIは、より一般的に公開APIで使われる傾向があります。

#### 欠点：RPC

* RPCクライアントはサービス実装に強く結合される。
* 新しい操作やユースケースごとに新しいAPIを定義する必要がある。
* RPCのデバッグは困難な場合がある。
* 既存の技術をすぐに活用できないかもしれない。例えば、[RPC呼び出しがキャッシュサーバー（例：[Squid](http://www.squid-cache.org/)）で正しくキャッシュされるようにする](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)には追加の労力が必要なことがある。

### 表現状態転送（REST）

RESTはクライアント/サーバーモデルを強制するアーキテクチャスタイルで、クライアントはサーバーが管理するリソースの集合に対して動作します。サーバーはリソースの表現と、リソースを操作したり新しい表現を取得したりするためのアクションを提供します。全ての通信はステートレスでキャッシュ可能でなければなりません。

RESTfulインターフェースには4つの特徴があります：

* **リソースの識別（HTTPのURI）** - 操作に関わらず同じURIを使用する。
* **表現による変更（HTTPの動詞）** - 動詞、ヘッダー、ボディを使用する。
* **自己記述的なエラーメッセージ（HTTPのステータス応答）** - ステータスコードを使い、再発明しない。
* **[HATEOAS](http://restcookbook.com/Basics/hateoas/)（HTTPのHTMLインターフェース）** - ウェブサービスはブラウザで完全にアクセス可能であるべき。

RESTのサンプル呼び出し：


```
GET /someresources/anId

PUT /someresources/anId
{"anotherdata": "another value"}
```
RESTはデータの公開に焦点を当てています。クライアント/サーバー間の結合度を最小限に抑え、公共のHTTP APIでよく使用されます。RESTはURIを通じてリソースをより一般的かつ均一な方法で公開し、[ヘッダーによる表現](https://github.com/for-GET/know-your-http-well/blob/master/headers.md)やGET、POST、PUT、DELETE、PATCHなどの動詞によるアクションを使用します。ステートレスであるため、RESTは水平スケーリングやパーティショニングに適しています。

#### 欠点: REST

* RESTはデータ公開に焦点を当てているため、リソースが自然に単純な階層構造で整理またはアクセスされない場合には適さないことがあります。例えば、過去1時間に特定のイベントに一致するすべての更新レコードを返すことは、パスとして簡単に表現できません。RESTでは、URIパス、クエリパラメータ、および場合によってはリクエストボディの組み合わせで実装される可能性が高いです。
* RESTは通常、いくつかの動詞（GET、POST、PUT、DELETE、PATCH）に依存しますが、これらが必ずしもユースケースに合わないことがあります。例えば、期限切れのドキュメントをアーカイブフォルダに移動する処理は、これらの動詞のどれにもきれいに収まらないかもしれません。
* 入れ子構造を持つ複雑なリソースを取得するには、クライアントとサーバー間で複数回の往復が必要となり、単一ビューのレンダリングに時間がかかります。例えば、ブログエントリの内容とそのエントリに対するコメントを取得する場合です。変動するネットワーク環境で動作するモバイルアプリケーションでは、これらの複数の往復は非常に望ましくありません。
* 時間が経つにつれてAPIレスポンスにより多くのフィールドが追加されることがあり、古いクライアントは必要のない新しいデータフィールドもすべて受け取ってしまいます。その結果、ペイロードサイズが膨れ上がり、レイテンシが大きくなります。

### RPCとREST呼び出しの比較

| 操作 | RPC | REST |
|---|---|---|
| サインアップ | **POST** /signup | **POST** /persons |
| 退会 | **POST** /resign<br/>{<br/>"personid": "1234"<br/>} | **DELETE** /persons/1234 |
| 人物情報取得 | **GET** /readPerson?personid=1234 | **GET** /persons/1234 |
| 人物のアイテムリスト取得 | **GET** /readUsersItemsList?personid=1234 | **GET** /persons/1234/items |
| 人物のアイテムに追加 | **POST** /addItemToUsersItemsList<br/>{<br/>"personid": "1234";<br/>"itemid": "456"<br/>} | **POST** /persons/1234/items<br/>{<br/>"itemid": "456"<br/>} |
| アイテム更新 | **POST** /modifyItem<br/>{<br/>"itemid": "456";<br/>"key": "value"<br/>} | **PUT** /items/456<br/>{<br/>"key": "value"<br/>} |
| アイテム削除 | **POST** /removeItem<br/>{<br/>"itemid": "456"<br/>} | **DELETE** /items/456 |

<p align="center">
  <i><a href=https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/>出典: RESTをRPCより好む理由を本当に知っていますか</a></i>
</p>

#### 出典およびさらなる参考資料: RESTとRPC

* [RESTをRPCより好む理由を本当に知っていますか](https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/)
* [RPC的アプローチがRESTより適切な場合とは？](http://programmers.stackexchange.com/a/181186)
* [REST vs JSON-RPC](http://stackoverflow.com/questions/15056878/rest-vs-json-rpc)
* [RPCとRESTの神話を覆す](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)
* [RESTの欠点とは？](https://www.quora.com/What-are-the-drawbacks-of-using-RESTful-APIs)
* [システム設計面接を攻略する](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Thrift](https://code.facebook.com/posts/1468950976659943/)
* [なぜ内部利用にはRESTでRPCではないのか](http://arstechnica.com/civis/viewtopic.php?t=1190508)

## セキュリティ

このセクションは更新が必要です。[貢献](#contributing)をご検討ください！

セキュリティは広範なテーマです。 かなりの経験やセキュリティの背景があるか、セキュリティ知識が必要な職に応募していない限り、おそらく基本的なこと以上を知る必要はありません:

* 転送中および保存時に暗号化する。
* [XSS](https://en.wikipedia.org/wiki/Cross-site_scripting)や[SQLインジェクション](https://en.wikipedia.org/wiki/SQL_injection)を防ぐために、すべてのユーザー入力やユーザーに公開されている入力パラメータをサニタイズする。
* SQLインジェクションを防ぐためにパラメータ化クエリを使用する。
* [最小特権の原則](https://en.wikipedia.org/wiki/Principle_of_least_privilege)を利用する。

### 参考資料およびさらなる読み物

* [APIセキュリティチェックリスト](https://github.com/shieldfy/API-Security-Checklist)
* [開発者向けセキュリティガイド](https://github.com/FallibleInc/security-guide-for-developers)
* [OWASPトップテン](https://www.owasp.org/index.php/OWASP_Top_Ten_Cheat_Sheet)

## 付録

時折「ざっとした」見積もりを求められることがあります。 例えば、ディスクから100枚の画像サムネイルを生成するのにどれくらい時間がかかるか、またはデータ構造がどれほどのメモリを必要とするかを見積もる場合です。 **2のべき乗表** と **すべてのプログラマーが知っておくべきレイテンシ数値** は便利な参考資料です。

### 2のべき乗表


```
Power           Exact Value         Approx Value        Bytes
---------------------------------------------------------------
7                             128
8                             256
10                           1024   1 thousand           1 KB
16                         65,536                       64 KB
20                      1,048,576   1 million            1 MB
30                  1,073,741,824   1 billion            1 GB
32                  4,294,967,296                        4 GB
40              1,099,511,627,776   1 trillion           1 TB
```

#### 参照元およびさらなる読書資料

* [2のべき乗](https://en.wikipedia.org/wiki/Power_of_two)

### すべてのプログラマーが知っておくべきレイテンシーの数値

```
Latency Comparison Numbers
--------------------------
L1 cache reference                           0.5 ns
Branch mispredict                            5   ns
L2 cache reference                           7   ns                      14x L1 cache
Mutex lock/unlock                           25   ns
Main memory reference                      100   ns                      20x L2 cache, 200x L1 cache
Compress 1K bytes with Zippy            10,000   ns       10 us
Send 1 KB bytes over 1 Gbps network     10,000   ns       10 us
Read 4 KB randomly from SSD*           150,000   ns      150 us          ~1GB/sec SSD
Read 1 MB sequentially from memory     250,000   ns      250 us
Round trip within same datacenter      500,000   ns      500 us
Read 1 MB sequentially from SSD*     1,000,000   ns    1,000 us    1 ms  ~1GB/sec SSD, 4X memory
HDD seek                            10,000,000   ns   10,000 us   10 ms  20x datacenter roundtrip
Read 1 MB sequentially from 1 Gbps  10,000,000   ns   10,000 us   10 ms  40x memory, 10X SSD
Read 1 MB sequentially from HDD     30,000,000   ns   30,000 us   30 ms 120x memory, 30X SSD
Send packet CA->Netherlands->CA    150,000,000   ns  150,000 us  150 ms

Notes
-----
1 ns = 10^-9 seconds
1 us = 10^-6 seconds = 1,000 ns
1 ms = 10^-3 seconds = 1,000 us = 1,000,000 ns
```
上記の数値に基づく便利な指標：

* HDDからの順次読み取り速度は30 MB/s
* 1 Gbpsイーサネットからの順次読み取り速度は100 MB/s
* SSDからの順次読み取り速度は1 GB/s
* メインメモリからの順次読み取り速度は4 GB/s
* 世界中で6〜7回の往復通信が1秒間に可能
* データセンター内では1秒間に2,000回の往復通信が可能

#### レイテンシー数値の可視化

![](https://camo.githubusercontent.com/77f72259e1eb58596b564d1ad823af1853bc60a3/687474703a2f2f692e696d6775722e636f6d2f6b307431652e706e67)

#### 出典およびさらなる参考資料

* [Latency numbers every programmer should know - 1](https://gist.github.com/jboner/2841832)
* [Latency numbers every programmer should know - 2](https://gist.github.com/hellerbarde/2843375)
* [大規模分散システム構築からの設計・教訓・アドバイス](http://www.cs.cornell.edu/projects/ladis2009/talks/dean-keynote-ladis2009.pdf)
* [大規模分散システム構築からのソフトウェア工学アドバイス](https://static.googleusercontent.com/media/research.google.com/en//people/jeff/stanford-295-talk.pdf)

### 追加のシステム設計面接質問

> 一般的なシステム設計の面接質問と、それぞれの解決方法へのリンク集。

| 質問 | 参考リンク |
|---|---|
| Dropboxのようなファイル同期サービスを設計せよ | [youtube.com](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| Googleのような検索エンジンを設計せよ | [queue.acm.org](http://queue.acm.org/detail.cfm?id=988407)<br/>[stackexchange.com](http://programmers.stackexchange.com/questions/38324/interview-question-how-would-you-implement-google-search)<br/>[ardendertat.com](http://www.ardendertat.com/2012/01/11/implementing-search-engines/)<br/>[stanford.edu](http://infolab.stanford.edu/~backrub/google.html) |
| Googleのようなスケーラブルなウェブクローラーを設計せよ | [quora.com](https://www.quora.com/How-can-I-build-a-web-crawler-from-scratch) |
| Googleドキュメントを設計せよ | [code.google.com](https://code.google.com/p/google-mobwrite/)<br/>[neil.fraser.name](https://neil.fraser.name/writing/sync/) |
| Redisのようなキー・バリューストアを設計せよ | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| Memcachedのようなキャッシュシステムを設計せよ | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| Amazonのようなレコメンデーションシステムを設計せよ | [hulu.com](https://web.archive.org/web/20170406065247/http://tech.hulu.com/blog/2011/09/19/recommendation-system.html)<br/>[ijcai13.org](http://ijcai13.org/files/tutorial_slides/td3.pdf) |
| BitlyのようなTinyURLシステムを設計せよ | [n00tc0d3r.blogspot.com](http://n00tc0d3r.blogspot.com/) |
| WhatsAppのようなチャットアプリを設計せよ | [highscalability.com](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html)
| Instagramのような写真共有システムを設計せよ | [highscalability.com](http://highscalability.com/flickr-architecture)<br/>[highscalability.com](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html) |
| Facebookのニュースフィード機能を設計せよ | [quora.com](http://www.quora.com/What-are-best-practices-for-building-something-like-a-News-Feed)<br/>[quora.com](http://www.quora.com/Activity-Streams/What-are-the-scaling-issues-to-keep-in-mind-while-developing-a-social-network-feed)<br/>[slideshare.net](http://www.slideshare.net/danmckinley/etsy-activity-feeds-architecture) |
| Facebookのタイムライン機能を設計せよ | [facebook.com](https://www.facebook.com/note.php?note_id=10150468255628920)<br/>[highscalability.com](http://highscalability.com/blog/2012/1/23/facebook-timeline-brought-to-you-by-the-power-of-denormaliza.html) |
| Facebookのチャット機能を設計せよ | [erlang-factory.com](http://www.erlang-factory.com/upload/presentations/31/EugeneLetuchy-ErlangatFacebook.pdf)<br/>[facebook.com](https://www.facebook.com/note.php?note_id=14218138919&id=9445547199&index=0) |

| Facebookのようなグラフ検索機能を設計する | [facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-building-out-the-infrastructure-for-graph-search/10151347573598920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-indexing-and-ranking-in-graph-search/10151361720763920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-the-natural-language-interface-of-graph-search/10151432733048920) |
| CloudFlareのようなコンテンツ配信ネットワークを設計する | [figshare.com](https://figshare.com/articles/Globally_distributed_content_delivery/6605972) |
| Twitterのようなトレンドトピックシステムを設計する | [michael-noll.com](http://www.michael-noll.com/blog/2013/01/18/implementing-real-time-trending-topics-in-storm/)<br/>[snikolov .wordpress.com](http://snikolov.wordpress.com/2012/11/14/early-detection-of-twitter-trends/) |
| ランダムID生成システムを設計する | [blog.twitter.com](https://blog.twitter.com/2010/announcing-snowflake)<br/>[github.com](https://github.com/twitter/snowflake/) |
| 一定時間内のトップkリクエストを返す | [cs.ucsb.edu](https://www.cs.ucsb.edu/sites/default/files/documents/2005-23.pdf)<br/>[wpi.edu](http://davis.wpi.edu/xmdv/docs/EDBT11-diyang.pdf) |
| 複数のデータセンターからデータを提供するシステムを設計する | [highscalability.com](http://highscalability.com/blog/2009/8/24/how-google-serves-data-from-multiple-datacenters.html) |
| オンラインマルチプレイヤーカードゲームを設計する | [indieflashblog.com](https://web.archive.org/web/20180929181117/http://www.indieflashblog.com/how-to-create-an-asynchronous-multiplayer-game.html)<br/>[buildnewgames.com](http://buildnewgames.com/real-time-multiplayer/) |
| ガベージコレクションシステムを設計する | [stuffwithstuff.com](http://journal.stuffwithstuff.com/2013/12/08/babys-first-garbage-collector/)<br/>[washington.edu](http://courses.cs.washington.edu/courses/csep521/07wi/prj/rick.pdf) |
| APIレートリミッターを設計する | [https://stripe.com/blog/](https://stripe.com/blog/rate-limiters) |
| 株式取引所（NASDAQやBinanceのような）を設計する | [Jane Street](https://youtu.be/b1e4t2k2KJY)<br/>[Golang Implementation](https://around25.com/blog/building-a-trading-engine-for-a-crypto-exchange/)<br/>[Go Implementation](http://bhomnick.net/building-a-simple-limit-order-in-go/) |
| システム設計の質問を追加する | [Contribute](#contributing) |

### 実世界のアーキテクチャ

> 実際のシステムがどのように設計されているかに関する記事。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/TcUo2fw.png">
  <br/>
  <i><a href=https://www.infoq.com/presentations/Twitter-Timeline-Scalability>出典: 大規模Twitterタイムライン</a></i>
</p>

**以下の記事では細かい詳細にこだわらず、代わりに：**

* これらの記事に共通する原則、一般的な技術、パターンを特定する
* 各コンポーネントが解決する問題、機能する箇所、機能しない箇所を学ぶ
* 得られた教訓を振り返る

|種類 | システム | 参照 |
|---|---|---|
| データ処理 | **MapReduce** - Googleの分散データ処理 | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/mapreduce-osdi04.pdf) |
| データ処理 | **Spark** - Databricksの分散データ処理 | [slideshare.net](http://www.slideshare.net/AGrishchenko/apache-spark-architecture) |
| データ処理 | **Storm** - Twitterの分散データ処理 | [slideshare.net](http://www.slideshare.net/previa/storm-16094009) |
| | | |
| データストア | **Bigtable** - Googleの分散カラム指向データベース | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) |
| データストア | **HBase** - Bigtableのオープンソース実装 | [slideshare.net](http://www.slideshare.net/alexbaranau/intro-to-hbase) |
| データストア | **Cassandra** - Facebookの分散カラム指向データベース | [slideshare.net](http://www.slideshare.net/planetcassandra/cassandra-introduction-features-30103666) |
| データストア | **DynamoDB** - Amazonのドキュメント指向データベース | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) |
| データストア | **MongoDB** - ドキュメント指向データベース | [slideshare.net](http://www.slideshare.net/mdirolf/introduction-to-mongodb) |
| データストア | **Spanner** - Googleのグローバル分散データベース | [research.google.com](http://research.google.com/archive/spanner-osdi2012.pdf) |
| データストア | **Memcached** - 分散メモリキャッシュシステム | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| データストア | **Redis** - 永続性と値タイプを備えた分散メモリキャッシュシステム | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| | | |
| ファイルシステム | **Google File System (GFS)** - 分散ファイルシステム | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/gfs-sosp2003.pdf) |
| ファイルシステム | **Hadoop File System (HDFS)** - GFSのオープンソース実装 | [apache.org](http://hadoop.apache.org/docs/stable/hadoop-project-dist/hadoop-hdfs/HdfsDesign.html) |
| | | |
| その他 | **Chubby** - Googleの疎結合分散システム用ロックサービス | [research.google.com](http://static.googleusercontent.com/external_content/untrusted_dlcp/research.google.com/en/us/archive/chubby-osdi06.pdf) |
| その他 | **Dapper** - 分散システムのトレーシングインフラストラクチャ | [research.google.com](http://static.googleusercontent.com/media/research.google.com/en//pubs/archive/36356.pdf) |
| その他 | **Kafka** - LinkedInのPub/Subメッセージキュー | [slideshare.net](http://www.slideshare.net/mumrah/kafka-talk-tri-hug) |
| その他 | **Zookeeper** - 同期を可能にする集中型インフラとサービス | [slideshare.net](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) |
| | アーキテクチャを追加 | [Contribute](#contributing) |

### 企業アーキテクチャ

| 企業 | 参照 |
|---|---|
| Amazon | [Amazonアーキテクチャ](http://highscalability.com/amazon-architecture) |
| Cinchcast | [毎日1,500時間のオーディオ制作](http://highscalability.com/blog/2012/7/16/cinchcast-architecture-producing-1500-hours-of-audio-every-d.html) |
| DataSift | [毎秒120,000ツイートのリアルタイムデータマイニング](http://highscalability.com/blog/2011/11/29/datasift-architecture-realtime-datamining-at-120000-tweets-p.html) |
| Dropbox | [Dropboxのスケーリング方法](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ESPN | [毎秒100,000回の操作](http://highscalability.com/blog/2013/11/4/espns-architecture-at-scale-operating-at-100000-duh-nuh-nuhs.html) |
| Google | [Googleアーキテクチャ](http://highscalability.com/google-architecture) |
| Instagram | [1400万人のユーザー、テラバイトの写真](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html)<br/>[Instagramの動力源](http://instagram-engineering.tumblr.com/post/13649370142/what-powers-instagram-hundreds-of-instances) |
| Justin.tv | [Justin.Tvのライブビデオ放送アーキテクチャ](http://highscalability.com/blog/2010/3/16/justintvs-live-video-broadcasting-architecture.html) |
| Facebook | [Facebookでのmemcachedのスケーリング](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/key-value/fb-memcached-nsdi-2013.pdf)<br/>[TAO: Facebookのソーシャルグラフ用分散データストア](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/data-store/tao-facebook-distributed-datastore-atc-2013.pdf)<br/>[Facebookの写真ストレージ](https://www.usenix.org/legacy/event/osdi10/tech/full_papers/Beaver.pdf)<br/>[Facebookが80万人の同時視聴者にライブ配信する方法](http://highscalability.com/blog/2016/6/27/how-facebook-live-streams-to-800000-simultaneous-viewers.html) |
| Flickr | [Flickrアーキテクチャ](http://highscalability.com/flickr-architecture) |
| Mailbox | [6週間で0から100万人のユーザーへ](http://highscalability.com/blog/2013/6/18/scaling-mailbox-from-0-to-one-million-users-in-6-weeks-and-1.html) |
| Netflix | [Netflixスタックの360度ビュー](http://highscalability.com/blog/2015/11/9/a-360-degree-view-of-the-entire-netflix-stack.html)<br/>[Netflix：再生ボタンを押すと何が起こるか](http://highscalability.com/blog/2017/12/11/netflix-what-happens-when-you-press-play.html) |
| Pinterest | [月間数百億ページビューへのスケーリング](http://highscalability.com/blog/2013/4/15/scaling-pinterest-from-0-to-10s-of-billions-of-page-views-a.html)<br/>[1800万人の訪問者、10倍の成長、従業員12名](http://highscalability.com/blog/2012/5/21/pinterest-architecture-update-18-million-visitors-10x-growth.html) |
| Playfish | [月間5,000万人のユーザー数と成長](http://highscalability.com/blog/2010/9/21/playfishs-social-gaming-architecture-50-million-monthly-user.html) |
| PlentyOfFish | [PlentyOfFishアーキテクチャ](http://highscalability.com/plentyoffish-architecture) |
| Salesforce | [1日13億件のトランザクションを処理する方法](http://highscalability.com/blog/2013/9/23/salesforce-architecture-how-they-handle-13-billion-transacti.html) |
| Stack Overflow | [Stack Overflowアーキテクチャ](http://highscalability.com/blog/2009/8/5/stack-overflow-architecture.html) |
| TripAdvisor | [4,000万人の訪問者、2億の動的ページビュー、30TBのデータ](http://highscalability.com/blog/2011/6/27/tripadvisor-architecture-40m-visitors-200m-dynamic-page-view.html) |
| Tumblr | [月間150億ページビュー](http://highscalability.com/blog/2012/2/13/tumblr-architecture-15-billion-page-views-a-month-and-harder.html) |
| Twitter | [Twitterを1万倍高速化](http://highscalability.com/scaling-twitter-making-twitter-10000-percent-faster)<br/>[MySQLで1日2.5億ツイートを保存](http://highscalability.com/blog/2011/12/19/how-twitter-stores-250-million-tweets-a-day-using-mysql.html)<br/>[1億5,000万人のアクティブユーザー、30万QPS、22MB/sのファイアホース](http://highscalability.com/blog/2013/7/8/the-architecture-twitter-uses-to-deal-with-150m-active-users.html)<br/>[大規模なタイムライン](https://www.infoq.com/presentations/Twitter-Timeline-Scalability)<br/>[Twitterのビッグ＆スモールデータ](https://www.youtube.com/watch?v=5cKTP36HVgI)<br/>[Twitterの運用：1億ユーザー超のスケーリング](https://www.youtube.com/watch?v=z8LU0Cj6BOU)<br/>[Twitterが毎秒3,000枚の画像を処理する方法](http://highscalability.com/blog/2016/4/20/how-twitter-handles-3000-images-per-second.html) |
| Uber | [Uberのリアルタイムマーケットプラットフォームのスケーリング方法](http://highscalability.com/blog/2015/9/14/how-uber-scales-their-real-time-market-platform.html)<br/>[Uberのスケーリング教訓：2000エンジニア、1000サービス、8000 Gitリポジトリ](http://highscalability.com/blog/2016/10/12/lessons-learned-from-scaling-uber-to-2000-engineers-1000-ser.html) |
| WhatsApp | [Facebookが190億ドルで買収したWhatsAppのアーキテクチャ](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| YouTube | [YouTubeのスケーラビリティ](https://www.youtube.com/watch?v=w5WVu624fY8)<br/>[YouTubeアーキテクチャ](http://highscalability.com/youtube-architecture) |

### 企業のエンジニアリングブログ

> 面接を受ける企業のアーキテクチャ。
>
> 出題される質問は同じドメインから来ることがあります。

* [Airbnb エンジニアリング](http://nerds.airbnb.com/)
* [Atlassian デベロッパー](https://developer.atlassian.com/blog/)
* [AWS ブログ](https://aws.amazon.com/blogs/aws/)
* [Bitly エンジニアリングブログ](http://word.bitly.com/)
* [Box ブログ](https://blog.box.com/blog/category/engineering)
* [Cloudera デベロッパーブログ](http://blog.cloudera.com/)
* [Dropbox テックブログ](https://tech.dropbox.com/)
* [Quora のエンジニアリング](https://www.quora.com/q/quoraengineering)
* [Ebay テックブログ](http://www.ebaytechblog.com/)
* [Evernote テックブログ](https://blog.evernote.com/tech/)
* [Etsy Code as Craft](http://codeascraft.com/)
* [Facebook エンジニアリング](https://www.facebook.com/Engineering)
* [Flickr Code](http://code.flickr.net/)
* [Foursquare エンジニアリングブログ](http://engineering.foursquare.com/)
* [GitHub エンジニアリングブログ](https://github.blog/category/engineering)
* [Google リサーチブログ](http://googleresearch.blogspot.com/)
* [Groupon エンジニアリングブログ](https://engineering.groupon.com/)
* [Heroku エンジニアリングブログ](https://engineering.heroku.com/)
* [Hubspot エンジニアリングブログ](http://product.hubspot.com/blog/topic/engineering)
* [High Scalability](http://highscalability.com/)
* [Instagram エンジニアリング](http://instagram-engineering.tumblr.com/)
* [Intel ソフトウェアブログ](https://software.intel.com/en-us/blogs/)
* [Jane Street テックブログ](https://blogs.janestreet.com/category/ocaml/)
* [LinkedIn エンジニアリング](http://engineering.linkedin.com/blog)
* [Microsoft エンジニアリング](https://engineering.microsoft.com/)
* [Microsoft Python エンジニアリング](https://blogs.msdn.microsoft.com/pythonengineering/)
* [Netflix テックブログ](http://techblog.netflix.com/)
* [Paypal デベロッパーブログ](https://medium.com/paypal-engineering)
* [Pinterest エンジニアリングブログ](https://medium.com/@Pinterest_Engineering)
* [Reddit ブログ](http://www.redditblog.com/)
* [Salesforce エンジニアリングブログ](https://developer.salesforce.com/blogs/engineering/)
* [Slack エンジニアリングブログ](https://slack.engineering/)
* [Spotify ラボ](https://labs.spotify.com/)
* [Stripe エンジニアリングブログ](https://stripe.com/blog/engineering)
* [Twilio エンジニアリングブログ](http://www.twilio.com/engineering)
* [Twitter エンジニアリング](https://blog.twitter.com/engineering/)
* [Uber エンジニアリングブログ](http://eng.uber.com/)
* [Yahoo エンジニアリングブログ](http://yahooeng.tumblr.com/)
* [Yelp エンジニアリングブログ](http://engineeringblog.yelp.com/)
* [Zynga エンジニアリングブログ](https://www.zynga.com/blogs/engineering)

#### 出典およびさらなる参考資料

ブログを追加したいですか？ 重複作業を避けるために、以下のリポジトリにあなたの会社のブログを追加することを検討してください：

* [kilimchoi/engineering-blogs](https://github.com/kilimchoi/engineering-blogs)

## 開発中

セクションを追加したり、進行中のものを完成させるのを手伝いたいですか？ [貢献する](#contributing)！

* MapReduceを用いた分散コンピューティング
* 一貫性のあるハッシュ
* スキャッター・ギャザー
* [貢献する](#contributing)

## クレジット

クレジットと出典はこのリポジトリ全体にわたって提供されています。

特別な感謝：

* [Hired in tech](http://www.hiredintech.com/system-design/the-system-design-process/)
* [Cracking the coding interview](https://www.amazon.com/dp/0984782850/)
* [High scalability](http://highscalability.com/)
* [checkcheckzz/system-design-interview](https://github.com/checkcheckzz/system-design-interview)
* [shashank88/system_design](https://github.com/shashank88/system_design)
* [mmcgrana/services-engineering](https://github.com/mmcgrana/services-engineering)
* [System design cheat sheet](https://gist.github.com/vasanthk/485d1c25737e8e72759f)
* [A distributed systems reading list](http://dancres.github.io/Pages/)
* [Cracking the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)

## 連絡先情報

ご質問やご意見、ご不明な点がございましたら、お気軽にご連絡ください。

私の連絡先情報は[GitHubページ](https://github.com/donnemartin)に記載されています。

## ライセンス

*このリポジトリのコードおよびリソースはオープンソースライセンスのもとで提供しています。これは私個人のリポジトリであるため、コードおよびリソースに対するライセンスは私から直接提供されており、私の勤務先（Facebook）からではありません。*

    著作権 2017 Donne Martin

    クリエイティブ・コモンズ 表示 4.0 国際 ライセンス (CC BY 4.0)

    http://creativecommons.org/licenses/by/4.0/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---