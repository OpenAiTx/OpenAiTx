*[English](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README.md) ∙ [日本語](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-ja.md) ∙ [简体中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-Hans.md) ∙ [繁體中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-TW.md) | [العَرَبِيَّة‎](https://github.com/donnemartin/system-design-primer/issues/170) ∙ [বাংলা](https://github.com/donnemartin/system-design-primer/issues/220) ∙ [Português do Brasil](https://github.com/donnemartin/system-design-primer/issues/40) ∙ [Deutsch](https://github.com/donnemartin/system-design-primer/issues/186) ∙ [ελληνικά](https://github.com/donnemartin/system-design-primer/issues/130) ∙ [עברית](https://github.com/donnemartin/system-design-primer/issues/272) ∙ [Italiano](https://github.com/donnemartin/system-design-primer/issues/104) ∙ [한국어](https://github.com/donnemartin/system-design-primer/issues/102) ∙ [فارسی](https://github.com/donnemartin/system-design-primer/issues/110) ∙ [Polski](https://github.com/donnemartin/system-design-primer/issues/68) ∙ [русский язык](https://github.com/donnemartin/system-design-primer/issues/87) ∙ [Español](https://github.com/donnemartin/system-design-primer/issues/136) ∙ [ภาษาไทย](https://github.com/donnemartin/system-design-primer/issues/187) ∙ [Türkçe](https://github.com/donnemartin/system-design-primer/issues/39) ∙ [tiếng Việt](https://github.com/donnemartin/system-design-primer/issues/127) ∙ [Français](https://github.com/donnemartin/system-design-primer/issues/250) | [Add Translation](https://github.com/donnemartin/system-design-primer/issues/28)*

**協助[翻譯](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/TRANSLATIONS.md)本指南！**

# 系統設計入門指南

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png">
  <br/>
</p>

## 動機

> 學習如何設計大型系統。
>
> 為系統設計面試做準備。

### 學習如何設計大型系統

學習如何設計可擴展的系統將幫助你成為更優秀的工程師。

系統設計是一個範圍廣泛的主題。網路上有**大量分散的資源**關於系統設計原則。

本倉庫是一個**有組織的資源集合**，協助你學習如何構建可擴展的系統。

### 向開源社群學習

這是一個持續更新的開源專案。

歡迎[貢獻](#contributing)！

### 為系統設計面試做準備

除了程式面試外，系統設計也是許多科技公司**技術面試流程的必備項目**。

**練習常見的系統設計面試題目**，並將你的結果與**範例解答**（討論、程式碼、與圖示）進行**比較**。

面試準備的其他主題：

* [學習指南](#study-guide)
* [如何解答系統設計面試問題](#how-to-approach-a-system-design-interview-question)
* [系統設計面試問題，**含解答**](#system-design-interview-questions-with-solutions)
* [物件導向設計面試問題，**含解答**](#object-oriented-design-interview-questions-with-solutions)
* [其他系統設計面試問題](#additional-system-design-interview-questions)

## Anki 閃卡

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/zdCAkB3.png">
  <br/>
</p>

提供的 [Anki 閃卡套件](https://apps.ankiweb.net/) 使用間隔重複法幫助你記憶重要的系統設計概念。

* [系統設計閃卡](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design.apkg)
* [系統設計練習閃卡](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design%20Exercises.apkg)
* [物件導向設計練習閃卡](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/OO%20Design.apkg)

非常適合在移動中使用。

### 程式資源：互動式程式挑戰

正在尋找幫助你準備 [**程式面試**](https://github.com/donnemartin/interactive-coding-challenges) 的資源嗎？

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/b4YtAEN.png">
  <br/>
</p>

請參考相關的倉庫 [**互動式程式挑戰**](https://github.com/donnemartin/interactive-coding-challenges)，其中包含額外的 Anki 閃卡套件：

* [程式閃卡](https://github.com/donnemartin/interactive-coding-challenges/tree/master/anki_cards/Coding.apkg)

## 貢獻

> 向社群學習。

歡迎提交 pull requests 來協助：

* 修正錯誤
* 改進章節
* 新增新章節
* [翻譯](https://github.com/donnemartin/system-design-primer/issues/28)

需要進一步潤飾的內容被放置於[開發中](#under-development)。

請參閱[貢獻指南](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/CONTRIBUTING.md)。

## 系統設計主題索引

> 各種系統設計主題的摘要，包括優缺點。**一切都是權衡**。
>
> 每個章節都包含更深入資源的連結。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png">
  <br/>
</p>

* [系統設計主題：從這裡開始](#system-design-topics-start-here)
    * [步驟1：觀看可擴展性影音課程](#step-1-review-the-scalability-video-lecture)
    * [步驟2：閱讀可擴展性文章](#step-2-review-the-scalability-article)
    * [下一步](#next-steps)
* [效能與可擴展性](#performance-vs-scalability)
* [延遲與吞吐量](#latency-vs-throughput)
* [可用性與一致性](#availability-vs-consistency)
    * [CAP 理論](#cap-theorem)
        * [CP - 一致性與分區容錯](#cp---consistency-and-partition-tolerance)
        * [AP - 可用性與分區容錯](#ap---availability-and-partition-tolerance)
* [一致性模式](#consistency-patterns)
    * [弱一致性](#weak-consistency)
    * [最終一致性](#eventual-consistency)
    * [強一致性](#strong-consistency)
* [可用性模式](#availability-patterns)
    * [故障轉移](#fail-over)
    * [複寫](#replication)
    * [數字化可用性](#availability-in-numbers)
* [網域名稱系統](#domain-name-system)
* [內容傳遞網路](#content-delivery-network)
    * [推式 CDN](#push-cdns)
    * [拉式 CDN](#pull-cdns)
* [負載平衡器](#load-balancer)
    * [主動-被動](#active-passive)
    * [主動-主動](#active-active)
    * [第4層負載平衡](#layer-4-load-balancing)
    * [第7層負載平衡](#layer-7-load-balancing)
    * [水平擴展](#horizontal-scaling)
* [反向代理（網頁伺服器）](#reverse-proxy-web-server)
    * [負載平衡器與反向代理](#load-balancer-vs-reverse-proxy)
* [應用層](#application-layer)
    * [微服務](#microservices)
    * [服務發現](#service-discovery)
* [資料庫](#database)
    * [關聯式資料庫管理系統（RDBMS）](#relational-database-management-system-rdbms)
        * [主從複製](#master-slave-replication)
        * [主主複製](#master-master-replication)
        * [聯邦](#federation)
        * [分片](#sharding)
        * [反規範化](#denormalization)
        * [SQL 優化](#sql-tuning)
    * [NoSQL](#nosql)
        * [鍵值儲存](#key-value-store)
        * [文件儲存](#document-store)
        * [寬欄儲存](#wide-column-store)
        * [圖形資料庫](#graph-database)
    * [SQL 或 NoSQL](#sql-or-nosql)
* [快取](#cache)
    * [用戶端快取](#client-caching)
    * [CDN 快取](#cdn-caching)
    * [網頁伺服器快取](#web-server-caching)
    * [資料庫快取](#database-caching)
    * [應用程式快取](#application-caching)
    * [資料庫查詢層級快取](#caching-at-the-database-query-level)
    * [物件層級快取](#caching-at-the-object-level)
    * [何時更新快取](#when-to-update-the-cache)
        * [旁路快取](#cache-aside)
        * [寫入直通](#write-through)
        * [寫入後台（回寫）](#write-behind-write-back)
        * [提前刷新](#refresh-ahead)
* [非同步性](#asynchronism)
    * [訊息佇列](#message-queues)
    * [工作佇列](#task-queues)
    * [回壓機制](#back-pressure)
* [通訊](#communication)
    * [傳輸控制協定 (TCP)](#transmission-control-protocol-tcp)
    * [使用者資料報協定 (UDP)](#user-datagram-protocol-udp)
    * [遠端程序呼叫 (RPC)](#remote-procedure-call-rpc)
    * [表現性狀態轉移 (REST)](#representational-state-transfer-rest)
* [安全性](#security)
* [附錄](#appendix)
    * [二的冪次方表](#powers-of-two-table)
    * [每個程式設計師都應該知道的延遲數字](#latency-numbers-every-programmer-should-know)
    * [額外的系統設計面試問題](#additional-system-design-interview-questions)
    * [真實世界的架構](#real-world-architectures)
    * [公司架構](#company-architectures)
    * [公司工程部落格](#company-engineering-blogs)
* [開發中](#under-development)
* [鳴謝](#credits)
* [聯絡資訊](#contact-info)
* [授權條款](#license)

## 學習指南

> 根據您的面試時間表（短期、中期、長期）建議回顧的主題。

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/OfVllex.png)

**問：面試時需要全部都懂嗎？**

**答：不需要全部都懂才能準備面試**。

在面試中會被問到什麼，取決於以下變數：

* 您的工作經驗有多少
* 您的技術背景是什麼
* 您面試的職位是哪些
* 您面試的是哪些公司
* 運氣

經驗較豐富的候選人通常預期要懂更多系統設計。架構師或團隊領導者通常要比一般成員懂得更多。頂尖科技公司很可能會有一輪或多輪設計面試。

先從廣泛的主題入手，再深入幾個領域。瞭解各種關鍵系統設計主題的基本知識是有幫助的。請根據你的時間安排、經驗、面試職位及面試公司調整以下指南。

* **時間短** - 以系統設計主題的**廣度**為目標。透過解決**部分**面試問題來練習。
* **時間中等** - 以系統設計主題的**廣度**和**部分深度**為目標。透過解決**多數**面試問題來練習。
* **時間長** - 以系統設計主題的**廣度**和**更多深度**為目標。透過解決**大多數**面試問題來練習。

| | 短期 | 中期 | 長期 |
|---|---|---|---|
| 閱讀[系統設計主題索引](#index-of-system-design-topics)以廣泛瞭解系統運作方式 | :+1: | :+1: | :+1: |
| 閱讀你要面試公司的[公司工程部落格](#company-engineering-blogs)中的一些文章 | :+1: | :+1: | :+1: |
| 閱讀一些[真實世界架構](#real-world-architectures) | :+1: | :+1: | :+1: |
| 回顧[如何應對系統設計面試問題](#how-to-approach-a-system-design-interview-question) | :+1: | :+1: | :+1: |
| 練習[系統設計面試題及解答](#system-design-interview-questions-with-solutions) | 部分 | 多數 | 大多數 |
| 練習[物件導向設計面試題及解答](#object-oriented-design-interview-questions-with-solutions) | 部分 | 多數 | 大多數 |
| 回顧[其他系統設計面試問題](#additional-system-design-interview-questions) | 部分 | 多數 | 大多數 |

## 如何應對系統設計面試問題

> 如何解決系統設計面試問題。

系統設計面試是一場**開放式對話**。你需要主導整個討論。

你可以利用以下步驟引導討論。為了鞏固這個流程，請參照以下步驟練習[系統設計面試題及解答](#system-design-interview-questions-with-solutions)部分。

### 步驟 1：列出用例、限制條件與假設

收集需求並界定問題範圍。提出問題以釐清用例和限制條件。討論假設。

* 誰會使用它？
* 他們會怎麼使用？
* 有多少使用者？
* 系統的功能是什麼？
* 系統的輸入與輸出是什麼？
* 預計要處理多少數據？
* 預計每秒有多少請求？
* 預期讀寫比是多少？

### 步驟 2：建立高層設計

概述包含所有重要組件的高層設計。
* 繪製主要元件及其連接方式
* 說明你的設計理念

### 步驟三：設計核心元件

針對每個核心元件進行詳細設計。例如，如果題目要求你[設計一個網址縮短服務](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)，可以討論：

* 產生並儲存完整網址的雜湊值
    * [MD5](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) 與 [Base62](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)
    * 雜湊碰撞
    * SQL 或 NoSQL
    * 資料庫結構設計
* 將雜湊網址轉換為完整網址
    * 資料庫查詢
* API 與物件導向設計

### 步驟四：設計可擴展性

在已知限制下，找出並解決瓶頸。例如，為了解決可擴展性問題，你是否需要以下項目？

* 負載平衡器
* 水平擴展
* 快取
* 資料庫分片

討論潛在解決方案與權衡。任何設計都是一種取捨。請運用[可擴展系統設計原則](#index-of-system-design-topics)來解決瓶頸問題。

### 粗略計算（Back-of-the-envelope calculations）

你可能會被要求手動進行一些估算。請參考[附錄](#appendix)中的以下資源：

* [使用粗略計算](http://highscalability.com/blog/2011/1/26/google-pro-tip-use-back-of-the-envelope-calculations-to-choo.html)
* [二的冪次方表](#powers-of-two-table)
* [每位程式設計師都應該知道的延遲數據](#latency-numbers-every-programmer-should-know)

### 來源與進一步閱讀

請參考以下連結，獲取更多相關資訊：


* [如何在系統設計面試中脫穎而出](https://www.palantir.com/2011/10/how-to-rock-a-systems-design-interview/)
* [系統設計面試](http://www.hiredintech.com/system-design)
* [架構與系統設計面試入門](https://www.youtube.com/watch?v=ZgdS0EUmn70)
* [系統設計模板](https://leetcode.com/discuss/career/229177/My-System-Design-Template)

## 系統設計面試題目與解答

> 常見系統設計面試題目，附有討論範例、程式碼及圖解。
>
> 解答連結至 `solutions/` 資料夾內容。

| 題目 | |
|---|---|
| 設計 Pastebin.com（或 Bit.ly） | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) |
| 設計 Twitter 時間軸與搜尋（或 Facebook 動態消息與搜尋） | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md) |
| 設計一個網頁爬蟲 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md) |
| 設計 Mint.com | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md) |
| 設計社群網路的資料結構 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md) |
| 為搜尋引擎設計鍵值儲存系統 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md) |
| 設計亞馬遜依類別銷售排名功能 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md) |
| 設計在 AWS 上可擴展至百萬用戶的系統 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md) |
| 新增系統設計題目 | [貢獻](#contributing) |

### 設計 Pastebin.com（或 Bit.ly）

[查看練習與解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4edXG0T.png)

### 設計 Twitter 時間軸與搜尋（或 Facebook 動態消息與搜尋）

[查看練習與解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png)

### 設計一個網頁爬蟲

[查看練習與解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md)

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
| 設計一個雜湊映射表 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/hash_table/hash_map.ipynb)  |
| 設計一個最近最少使用快取（LRU Cache） | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/lru_cache/lru_cache.ipynb)  |
| 設計一個呼叫中心 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/call_center/call_center.ipynb)  |
| 設計一副撲克牌 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/deck_of_cards/deck_of_cards.ipynb)  |
| 設計一個停車場 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/parking_lot/parking_lot.ipynb)  |
| 設計一個即時聊天伺服器 | [解答](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/online_chat/online_chat.ipynb)  |
| 設計一個環狀陣列 | [貢獻](#contributing)  |
| 新增一題物件導向設計問題 | [貢獻](#contributing) |

## 系統設計主題：從這裡開始

系統設計新手？

首先，你需要對常見原則有基本認識，了解它們是什麼、如何使用，以及它們的優缺點。

### 步驟 1：觀看可擴展性（Scalability）教學影片

[哈佛可擴展性講座](https://www.youtube.com/watch?v=-W9F__D3oY4)

* 涵蓋主題：
    * 垂直擴展
    * 水平擴展
    * 快取
    * 負載平衡
    * 資料庫複製
    * 資料庫分割

### 步驟 2：閱讀可擴展性文章

[可擴展性](https://web.archive.org/web/20221030091841/http://www.lecloud.net/tagged/scalability/chrono)

* 涵蓋主題：
    * [複製體（Clones）](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
    * [資料庫](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
    * [快取](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
    * [非同步（Asynchronism）](https://web.archive.org/web/20220926171507/https://www.lecloud.net/post/9699762917/scalability-for-dummies-part-4-asynchronism)

### 下一步

接下來，我們將探討高層級的權衡：

* **效能** vs **可擴展性**
* **延遲** vs **吞吐量**
* **可用性** vs **一致性**

請記住，**一切都是權衡**。

然後我們會深入探討更具體的主題，例如 DNS、CDN 與負載平衡器。

## 效能 vs 可擴展性

當服務能隨著資源的增加而呈現相應的**效能提升**時，即稱為**可擴展**。一般而言，提升效能意味著能處理更多的工作單位，但也可以是處理更大型的工作單位，例如當資料集規模增加時。<sup><a href=http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html>1</a></sup>

效能與可擴展性還有另一種理解方式：

* 如果你遇到**效能**問題，系統對單一使用者來說很慢。
* 如果你遇到**可擴展性**問題，系統對單一使用者很快，但在高負載下很慢。

### 來源與進一步閱讀

* [關於可擴展性的一些看法](http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html)
* [可擴展性、可用性、穩定性、模式](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)

## 延遲 vs 吞吐量

**延遲**是執行某個動作或產生某個結果所需的時間。

**吞吐量**是每單位時間內執行此類動作或產生結果的數量。

一般來說，應以**最大化吞吐量**並維持**可接受的延遲**為目標。

### 來源與進一步閱讀

* [理解延遲與吞吐量](https://community.cadence.com/cadence_blogs_8/b/fv/posts/understanding-latency-vs-throughput)

## 可用性 vs 一致性

### CAP 定理

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bgLMI2u.png">
  <br/>
  <i><a href=http://robertgreiner.com/2014/08/cap-theorem-revisited>來源：CAP 定理再探討</a></i>
</p>

在分散式電腦系統中，你只能支援以下三項保證中的兩項：

* **一致性（Consistency）** - 每次讀取都會收到最新的寫入或錯誤
* **可用性（Availability）** - 每個請求都會收到回應，但不保證包含資訊的最新版本
* **分區容忍度（Partition Tolerance）** - 系統在因網路故障造成任意分區時仍能繼續運作

*網路並不可靠，因此你必須支援分區容忍度。你需要在一致性和可用性之間做出軟體取捨。*

#### CP - 一致性與分區容忍度

等待被分區節點的回應可能會導致逾時錯誤。如果你的業務需求需要原子性讀寫，CP 是不錯的選擇。

#### AP - 可用性與分區容忍度

回應會返回任何節點上最容易取得的資料版本，這可能不是最新的。當分區恢復時，寫入可能需要一段時間才能傳播。

如果業務需求允許[最終一致性](#eventual-consistency)，或當系統需要在外部錯誤下繼續運作時，AP 是不錯的選擇。

### 來源與延伸閱讀

* [CAP 定理再探討](http://robertgreiner.com/2014/08/cap-theorem-revisited/)
* [CAP 定理的白話介紹](http://ksat.me/a-plain-english-introduction-to-cap-theorem)
* [CAP 常見問答](https://github.com/henryr/cap-faq)
* [CAP 定理](https://www.youtube.com/watch?v=k-Yaq8AHlFA)

## 一致性模式

當存在多份相同資料時，我們需要選擇如何同步這些資料，以便客戶端能獲得一致的資料視圖。請回顧 [CAP 定理](#cap-theorem) 的一致性定義──每次讀取都會收到最新的寫入或錯誤。

### 弱一致性

寫入後，讀取有可能看到或看不到該寫入。這是一種盡力而為的做法。

這種方式出現在如 memcached 等系統中。弱一致性非常適用於即時應用場景，如 VoIP、視訊聊天和即時多人遊戲。例如，當你在通話時短暫失去訊號，恢復連線後你不會聽到斷線期間說的內容。

### 最終一致性

在寫入後，讀取最終會看到該寫入（通常在毫秒內）。資料是非同步複製的。

此方法常見於 DNS 和電子郵件等系統。最終一致性非常適合高可用性系統。

### 強一致性

在寫入後，讀取會立即看到該寫入。資料是同步複製的。

此方法常見於檔案系統及關聯式資料庫管理系統（RDBMS）。強一致性非常適合需要交易的系統。

### 資料來源及延伸閱讀

* [跨資料中心的交易](http://snarfed.org/transactions_across_datacenters_io.html)

## 可用性模式

有兩種互補模式支援高可用性：**故障切換**與**複製**。

### 故障切換

#### 主動-被動

在主動-被動故障切換中，主動伺服器與待命的被動伺服器之間會定期傳送心跳訊號。若心跳中斷，被動伺服器會接管主動伺服器的 IP 位址並恢復服務。

停機時間長度取決於被動伺服器是否已經在「熱」待命狀態，或是需要從「冷」待命狀態啟動。只有主動伺服器會處理流量。

主動-被動故障切換也可以稱為主從故障切換。

#### 主動-主動

在主動-主動模式下，兩台伺服器皆處理流量，分散負載於兩者之間。

若伺服器對外公開，DNS 需知曉兩台伺服器的公開 IP。若伺服器僅供內部使用，應用程式邏輯需知曉兩台伺服器。

主動-主動故障切換也可以稱為主主故障切換。

### 缺點：故障切換
* 故障切換會增加更多硬體及額外的複雜性。
* 如果主動系統在新寫入的資料能複製到被動系統之前故障，可能會導致資料遺失。

### 複製

#### 主從與主主

此主題在[資料庫](#database)章節中進一步討論：

* [主從複製](#master-slave-replication)
* [主主複製](#master-master-replication)

### 以數字表示的可用性

可用性通常以運作時間（或停機時間）佔服務可用時間的百分比來量化。可用性通常以9的數量來衡量——一個具有99.99%可用性的服務被描述為有四個9。

#### 99.9% 可用性 - 三個9

| 期間                | 可接受的停機時間   |
|---------------------|--------------------|
| 每年停機時間         | 8小時45分57秒      |
| 每月停機時間         | 43分49.7秒         |
| 每週停機時間         | 10分4.8秒          |
| 每日停機時間         | 1分26.4秒          |

#### 99.99% 可用性 - 四個9

| 期間                | 可接受的停機時間   |
|---------------------|--------------------|
| 每年停機時間         | 52分35.7秒         |
| 每月停機時間         | 4分23秒            |
| 每週停機時間         | 1分5秒             |
| 每日停機時間         | 8.6秒              |

#### 並聯與串聯下的可用性

如果一項服務由多個容易故障的元件組成，該服務的整體可用性取決於這些元件是串聯還是並聯。

###### 串聯

當兩個可用性低於 100% 的元件串聯時，整體可用性會下降：


```
Availability (Total) = Availability (Foo) * Availability (Bar)
```

如果 `Foo` 和 `Bar` 各自具有 99.9% 的可用性，它們串聯後的總可用性將是 99.8%。

###### 並聯

當兩個可用性低於 100% 的元件並聯時，整體可用性會提升：

```
Availability (Total) = 1 - (1 - Availability (Foo)) * (1 - Availability (Bar))
```
如果 `Foo` 和 `Bar` 各自擁有 99.9% 的可用性，則它們並聯的總可用性將達到 99.9999%。

## 網域名稱系統

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/IOyLj4i.jpg">
  <br/>
  <i><a href=http://www.slideshare.net/srikrupa5/dns-security-presentation-issa>來源：DNS 安全簡報</a></i>
</p>

網域名稱系統（DNS）會將像 www.example.com 這樣的網域名稱轉換為 IP 位址。

DNS 是分層的，頂層只有少數權威伺服器。你的路由器或 ISP 會提供查詢時應聯絡哪些 DNS 伺服器的資訊。較低層的 DNS 伺服器會快取映射，這些快取可能因 DNS 傳播延遲而過時。DNS 結果也可能被你的瀏覽器或作業系統快取一段時間，這段時間由 [存活時間（TTL）](https://en.wikipedia.org/wiki/Time_to_live) 決定。

* **NS 記錄（名稱伺服器）** - 指定你的網域/子網域的 DNS 伺服器。
* **MX 記錄（郵件交換）** - 指定接受訊息的郵件伺服器。
* **A 記錄（位址）** - 將名稱指向 IP 位址。
* **CNAME（正規名稱）** - 將名稱指向另一個名稱或 `CNAME`（example.com 到 www.example.com）或指向 `A` 記錄。

像 [CloudFlare](https://www.cloudflare.com/dns/) 和 [Route 53](https://aws.amazon.com/route53/) 這樣的服務提供受管理的 DNS 服務。一些 DNS 服務可以透過多種方法導流：

* [加權輪詢](https://www.jscape.com/blog/load-balancing-algorithms)
    * 防止流量進入維護中的伺服器
    * 在不同的叢集規模間平衡
    * A/B 測試
* [延遲導向](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-latency.html)
* [地理位置導向](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geo.html)

### 缺點：DNS

* 訪問 DNS 伺服器會引入輕微延遲，但可透過上述快取機制緩解。
* DNS 伺服器管理可能相當複雜，一般由[政府、ISP 及大型公司](http://superuser.com/questions/472695/who-controls-the-dns-servers/472729)管理。
* DNS 服務近期遭遇 [DDoS 攻擊](http://dyn.com/blog/dyn-analysis-summary-of-friday-october-21-attack/)，導致用戶無法在不知道 Twitter 的 IP 位址時存取 Twitter 等網站。

### 來源與延伸閱讀

* [DNS 架構](https://technet.microsoft.com/en-us/library/dd197427(v=ws.10).aspx)
* [維基百科](https://en.wikipedia.org/wiki/Domain_Name_System)
* [DNS 相關文章](https://support.dnsimple.com/categories/dns/)

## 內容傳遞網路

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h9TAuGI.jpg">
  <br/>
  <i><a href=https://www.creative-artworks.eu/why-use-a-content-delivery-network-cdn/>來源：為什麼要使用 CDN</a></i>
</p>

內容傳遞網路（CDN）是一個全球分佈的代理伺服器網路，能從更接近使用者的位置提供內容。通常，靜態檔案如 HTML/CSS/JS、照片和影片會由 CDN 傳送，但有些 CDN（如 Amazon 的 CloudFront）也支援動態內容。網站的 DNS 解析會告訴客戶端要聯絡哪一台伺服器。

使用 CDN 傳送內容可以透過以下兩種方式顯著提升效能：

* 使用者從離他們較近的資料中心獲取內容
* 您的伺服器不需處理 CDN 已經回應的請求

### Push CDN

Push CDN 在您的伺服器有新內容變更時即接收內容。您需全權負責提供內容，直接上傳至 CDN 並將網址重新指向 CDN。您可以設定內容何時過期及何時更新。只有新或變更的內容才會被上傳，能最小化流量但最大化儲存空間。

流量較小或內容不常更新的網站很適合使用 Push CDN。內容只需上傳至 CDN 一次，而非定期重新拉取。

### Pull CDN

Pull CDN 在第一個使用者請求內容時，才從您的伺服器抓取新內容。您將內容保留在自己的伺服器上，並將網址重新指向 CDN。首次請求時速度較慢，直到內容被快取至 CDN。

一個[存活時間（TTL）](https://en.wikipedia.org/wiki/Time_to_live)決定內容快取的時長。Pull CDN 可最小化 CDN 的儲存空間，但若檔案過期且在尚未變更前被重新拉取，可能產生重複流量。

高流量網站適合使用 Pull CDN，因為流量分配更平均，只有最近被請求的內容會留在 CDN 上。

### 缺點：CDN

* CDN 的花費可能因流量而顯著增加，但應與不使用 CDN 所需的額外成本權衡。
* 若內容在 TTL 到期前被更新，可能導致內容過期。
* 使用 CDN 需將靜態內容的 URL 改為指向 CDN。

### 來源與延伸閱讀

* [全球分佈的內容傳遞](https://figshare.com/articles/Globally_distributed_content_delivery/6605972)
* [Push CDN 與 Pull CDN 的差異](http://www.travelblogadvice.com/technical/the-differences-between-push-and-pull-cdns/)

* [維基百科](https://zh.wikipedia.org/wiki/內容傳遞網路)

## 負載平衡器

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h81n9iK.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>來源：可擴展系統設計模式</a></i>
</p>

負載平衡器將進來的客戶端請求分配到運算資源，如應用伺服器和資料庫。每一次，負載平衡器會將運算資源的回應返回給相應的客戶端。負載平衡器的有效作用包括：

* 防止請求發送到健康狀況不佳的伺服器
* 防止資源過載
* 幫助消除單點故障

負載平衡器可以透過硬體（昂貴）或像 HAProxy 這樣的軟體來實作。

其他優點包括：

* **SSL 終止** - 解密進來的請求並加密伺服器回應，使後端伺服器不必執行這些可能昂貴的操作
    * 免除在每台伺服器上安裝 [X.509 憑證](https://zh.wikipedia.org/wiki/X.509) 的需求
* **會話持久性** - 發行 cookie 並將特定客戶端的請求導向相同的實例，若網頁應用程式未追蹤會話

為了防止故障，常見做法是設置多個負載平衡器，可以採用[主動-被動](#active-passive)或[主動-主動](#active-active)模式。

負載平衡器可根據各種指標導引流量，包括：

* 隨機
* 最低負載
* 會話/cookie
* [輪詢或加權輪詢](https://www.g33kinfo.com/info/round-robin-vs-weighted-round-robin-lb)
* [第 4 層](#layer-4-load-balancing)
* [第 7 層](#layer-7-load-balancing)

### 第 4 層負載平衡

第 4 層負載平衡器會根據[傳輸層](#communication)的資訊來決定如何分配請求。一般涉及標頭中的來源、目的地 IP 位址及埠號，但不涉及封包內容。第 4 層負載平衡器會將網路封包轉發到上游伺服器並回傳，同時執行[網路位址轉換（NAT）](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)。

### 第 7 層負載平衡
第七層負載平衡器會檢查[應用層](#communication)以決定如何分配請求。這可能涉及標頭、訊息和 cookies 的內容。第七層負載平衡器會終止網路流量，讀取訊息，做出負載平衡決策，然後開啟到選定伺服器的連線。例如，第七層負載平衡器可以將影片流量導向主機影片的伺服器，同時將較敏感的使用者帳單流量導向強化安全的伺服器。

以彈性為代價，第四層負載平衡比第七層負載平衡所需的時間和運算資源更少，儘管在現代商用硬體上效能影響可能非常小。

### 水平擴展

負載平衡器也可以協助水平擴展，提升效能和可用性。利用商用機器進行橫向擴展比在昂貴硬體上擴充單一伺服器（稱為**垂直擴展**）更具成本效益，也能帶來更高的可用性。相較於專業企業系統，尋找熟悉商用硬體的人才也更容易。

#### 缺點：水平擴展

* 水平擴展會增加複雜度，並涉及複製伺服器
    * 伺服器應該是無狀態的：不應包含任何使用者相關資料，例如會話或個人頭像
    * 會話可以儲存在集中式資料存放區，如[資料庫](#database)（SQL、NoSQL）或持久性[快取](#cache)（Redis、Memcached）
* 當上游伺服器橫向擴展時，下游伺服器如快取和資料庫需要處理更多同時連線

### 缺點：負載平衡器

* 如果負載平衡器資源不足或配置不當，可能會成為效能瓶頸。
* 引入負載平衡器以消除單一失敗點會增加系統複雜度。
* 單一負載平衡器本身就是單一失敗點，配置多個負載平衡器會進一步增加複雜度。

### 來源及延伸閱讀

* [NGINX 架構](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [HAProxy 架構指南](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [可擴展性](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
* [維基百科](https://en.wikipedia.org/wiki/Load_balancing_(computing))
* [第四層負載平衡](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)
* [第七層負載平衡](https://www.nginx.com/resources/glossary/layer-7-load-balancing/)
* [ELB 監聽器設定](http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html)

## 反向代理（網頁伺服器）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n41Azff.png">
  <br/>
  <i><a href=https://upload.wikimedia.org/wikipedia/commons/6/67/Reverse_proxy_h2g2bob.svg>來源：維基百科</a></i>
  <br/>
</p>

反向代理是一種網頁伺服器，可以集中內部服務並向公眾提供統一介面。客戶端的請求會被轉發到可以滿足該請求的伺服器，然後反向代理再將伺服器的回應返回給客戶端。

額外的好處包括：

* **提高安全性** - 隱藏後端伺服器資訊、黑名單 IP、限制每位客戶端的連線數量
* **提升可擴展性與彈性** - 客戶端只看到反向代理的 IP，讓您能夠擴充伺服器或變更其設定
* **SSL 終止** - 解密進入的請求並加密伺服器回應，因此後端伺服器不需執行這些可能成本高昂的操作
    * 不需在每台伺服器安裝 [X.509 憑證](https://zh.wikipedia.org/wiki/X.509)
* **壓縮** - 壓縮伺服器回應
* **快取** - 回傳已快取請求的回應
* **靜態內容** - 直接提供靜態內容
    * HTML/CSS/JS
    * 照片
    * 影片
    * 等等

### 負載平衡器 vs 反向代理

* 當您有多台伺服器時，部署負載平衡器會很有幫助。通常，負載平衡器會將流量導向一組執行相同功能的伺服器。
* 即使僅有一台網頁伺服器或應用程式伺服器，反向代理仍然有其價值，並能帶來前述的好處。
* NGINX 與 HAProxy 等解決方案可同時支援第 7 層反向代理與負載平衡功能。

### 缺點：反向代理

* 引入反向代理會增加系統的複雜度。
* 單一反向代理會成為單點故障，配置多個反向代理（例如 [故障切換](https://zh.wikipedia.org/wiki/%E6%95%85%E9%9A%9C%E5%88%87%E6%8F%9B)）將進一步提升複雜度。

### 來源及進一步閱讀

* [反向代理 vs 負載平衡器](https://www.nginx.com/resources/glossary/reverse-proxy-vs-load-balancer/)
* [NGINX 架構](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [HAProxy 架構指南](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [維基百科](https://zh.wikipedia.org/wiki/Reverse_proxy)

## 應用層

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yB5SYwm.png">
  <br/>

  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>來源：系統擴展架構入門</a></i>
</p>

將 Web 層與應用層（也稱為平台層）分離，可以讓您獨立地擴展和配置兩個層級。新增一個 API 僅需增加應用伺服器，不必額外增加 Web 伺服器。**單一職責原則**主張建立小型且自治的服務共同運作。小型團隊與小型服務能更積極規劃快速成長。

應用層中的工作者也有助於實現[非同步](#asynchronism)。

### 微服務

與此討論相關的是[微服務](https://en.wikipedia.org/wiki/Microservices)，可描述為一套可獨立部署的小型、模組化服務。每個服務執行獨立程序，並透過明確定義且輕量的機制進行通訊以達成業務目標。<sup><a href=https://smartbear.com/learn/api-design/what-are-microservices>1</a></sup>

以 Pinterest 為例，可能會有如下微服務：用戶資料、追蹤者、動態、搜尋、照片上傳等。

### 服務發現

像是 [Consul](https://www.consul.io/docs/index.html)、[Etcd](https://coreos.com/etcd/docs/latest)、[Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) 等系統，可協助服務透過追蹤註冊名稱、位址及埠口來彼此尋找。[健康檢查](https://www.consul.io/intro/getting-started/checks.html)可驗證服務的完整性，且通常透過 [HTTP](#hypertext-transfer-protocol-http) 端點進行。Consul 和 Etcd 均內建有[鍵值儲存](#key-value-store)，可用於儲存設定值及其他共用資料。

### 缺點：應用層

* 加入一個由鬆耦合服務組成的應用層，無論在架構、營運及流程觀點上，都需採用不同方法（相較於單體系統）。
* 微服務在部署及操作上可能增加複雜度。

### 來源及延伸閱讀

* [系統擴展架構入門](http://lethain.com/introduction-to-architecting-systems-for-scale)
* [破解系統設計面試](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [服務導向架構](https://en.wikipedia.org/wiki/Service-oriented_architecture)
* [Zookeeper 入門](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)
* [建立微服務你需要知道的事](https://cloudncode.wordpress.com/2016/07/22/msa-getting-started/)

## 資料庫

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Xkm5CXz.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>來源：擴展到你的第一千萬用戶</a></i>
</p>

### 關聯式資料庫管理系統（RDBMS）

關聯式資料庫如 SQL 是以表格形式組織的資料項集合。

**ACID** 是關聯式資料庫[交易](https://en.wikipedia.org/wiki/Database_transaction)的一組屬性。

* **原子性（Atomicity）** - 每個交易要麼全部執行，要麼全部不執行
* **一致性（Consistency）** - 任何交易都會使資料庫從一個有效狀態轉換到另一個有效狀態
* **隔離性（Isolation）** - 並行執行交易的結果與序列執行交易的結果相同
* **持久性（Durability）** - 一旦交易被提交，將永久保留

有許多技術可用於擴展關聯式資料庫：**主從複製**、**主主複製**、**聯邦式架構**、**分片**、**去正規化**及**SQL 調校**。

#### 主從複製

主節點負責讀寫操作，並將寫入操作複製到一個或多個僅負責讀取的從節點。從節點也可以像樹狀結構般進一步複製到其他從節點。如果主節點離線，系統仍可繼續以唯讀模式運作，直到某個從節點升級為主節點或配置新的主節點。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/C9ioGtn.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>來源：Scalability, availability, stability, patterns</a></i>
</p>

##### 缺點：主從複製

* 需要額外邏輯來將從節點提升為主節點。
* 有關主從與主主複製共同相關的缺點，請參見[缺點：複製](#disadvantages-replication)。

#### 主主複製

兩個主節點都提供讀寫服務，並在寫入時彼此協調。如果任一主節點故障，系統仍可繼續進行讀寫操作。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/krAHLGg.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>來源：Scalability, availability, stability, patterns</a></i>
</p>

##### 缺點：主主複製

* 你需要一個負載平衡器，或必須修改應用邏輯來決定寫入位置。
* 大多數主主系統要麼是鬆散一致性（違反 ACID），要麼因同步而增加寫入延遲。
* 當新增更多寫入節點且延遲增加時，衝突解決會變得更加重要。
* 有關於主從與主主複寫的相關缺點，請參閱[缺點：複寫](#disadvantages-replication)。

##### 缺點：複寫

* 如果主節點在新寫入的資料能被複製到其他節點之前發生故障，則有資料遺失的風險。
* 寫入操作會重播到讀取副本。如果寫入量很大，讀取副本可能會因重播寫入而變得繁忙，導致無法處理太多讀取操作。
* 讀取副本越多，需要複製的資料就越多，這會導致更大的複寫延遲。
* 某些系統中，寫入主節點可啟動多個執行緒並行寫入，而讀取副本僅支援以單一執行緒依序寫入。
* 複寫會增加更多硬體需求與額外的複雜性。

##### 資料來源與延伸閱讀：複寫

* [Scalability, availability, stability, patterns](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [多主複寫](https://en.wikipedia.org/wiki/Multi-master_replication)

#### 聯邦式架構

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/U3qV33e.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>來源：Scaling up to your first 10 million users</a></i>
</p>

聯邦（或功能分割）是依據功能將資料庫分割。例如，與其使用單一的整體資料庫，不如設置三個資料庫：**論壇**、**用戶**以及**產品**，這樣可以減少每個資料庫的讀寫流量，因此減少複寫延遲。較小的資料庫能有更多資料被放入記憶體，進而提升快取命中率（因快取區域性提高）。由於沒有單一中央主節點序列化寫入，你可以並行寫入，增加吞吐量。

##### 缺點：聯邦

* 如果你的資料表或功能非常龐大，聯邦式架構就不適用。
* 你需要更新應用程式邏輯以判斷要讀取或寫入哪個資料庫。
* 從兩個資料庫合併資料（例如 JOIN）會變得更複雜，需要使用[伺服器連結](http://stackoverflow.com/questions/5145637/querying-data-by-joining-two-tables-in-two-database-on-different-servers)。
* 聯邦會帶來更多硬體需求與額外的複雜性。

##### 資料來源與延伸閱讀：聯邦

* [Scaling up to your first 10 million users](https://www.youtube.com/watch?v=kKjm4ehYiMs)

#### 分片

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wU8x5Id.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>來源：可擴展性、可用性、穩定性模式</a></i>
</p>

分片（Sharding）將資料分佈到不同的資料庫中，使每個資料庫只管理部分資料。以用戶資料庫為例，隨著用戶數量的增加，可以向叢集新增更多分片。

與[聯邦](#federation)的優點類似，分片可以減少讀寫流量、減少複製量並提高快取命中率。索引大小也會縮小，這通常可提升查詢速度與效能。如果某一個分片故障，其他分片仍能運作，雖然你會希望加入某種複製機制以避免資料遺失。像聯邦一樣，沒有單一中央主控序列化寫入，因此可以平行寫入並提升吞吐量。

常見的用戶資料表分片方式包括根據用戶姓氏的首字母或用戶的地理位置進行分配。

##### 缺點：分片

* 你需要更新應用程式邏輯以支援分片，這可能導致複雜的 SQL 查詢。
* 分片中的資料分佈可能變得不均勻。例如，某個分片上的高活躍用戶群可能導致該分片的負載高於其他分片。
    * 負載再平衡會增加額外的複雜性。基於[一致性哈希](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)的分片函數可減少資料轉移量。
* 從多個分片聯合查詢資料會更加複雜。
* 分片會引入更多硬體需求及系統複雜性。

##### 來源及延伸閱讀：分片

* [分片的來臨](http://highscalability.com/blog/2009/8/6/an-unorthodox-approach-to-database-design-the-coming-of-the.html)
* [分片資料庫架構](https://en.wikipedia.org/wiki/Shard_(database_architecture))
* [一致性哈希](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)

#### 非正規化（Denormalization）

非正規化旨在提升讀取效能，但會犧牲部分寫入效能。為避免昂貴的聯合查詢，會將冗餘的資料副本寫入多個資料表。有些關聯式資料庫（如 [PostgreSQL](https://en.wikipedia.org/wiki/PostgreSQL) 與 Oracle）支援[物化檢視表](https://en.wikipedia.org/wiki/Materialized_view)，能自動處理儲存冗餘資訊並保持副本一致性。

一旦資料透過[聯邦](#federation)和[分片](#sharding)等技術分散後，跨資料中心進行聯合查詢的管理會更加複雜。非正規化有時能避免這類複雜的聯合查詢需求。

在多數系統中，讀取操作通常遠多於寫入操作，比例可達 100:1 甚至 1000:1。一個需要複雜資料庫聯合查詢的讀取操作，可能非常昂貴，且需耗費大量磁碟操作時間。

##### 缺點：非正規化

* 資料會被重複儲存。
* 約束條件有助於冗餘資訊保持同步，但這會增加資料庫設計的複雜性。
* 在高寫入負載下，非正規化的資料庫效能可能比正規化的資料庫更差。

###### 來源及延伸閱讀：非正規化
* [反正規化](https://zh.wikipedia.org/wiki/反正規化)

#### SQL 調校

SQL 調校是一個廣泛的主題，許多[書籍](https://www.amazon.com/s/ref=nb_sb_noss_2?url=search-alias%3Daps&field-keywords=sql+tuning)已經作為參考資料出版。

進行**效能基準測試**和**效能剖析**以模擬及發現瓶頸非常重要。

* **效能基準測試** - 使用如 [ab](http://httpd.apache.org/docs/2.2/programs/ab.html) 等工具模擬高負載情境。
* **效能剖析** - 啟用如 [慢查詢日誌](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html) 等工具以協助追蹤效能問題。

基準測試與效能剖析可能會引導你進行下列優化。

##### 收緊資料表結構

* MySQL 會將資料以連續區塊方式寫入磁碟以加速存取。
* 對於固定長度欄位，請使用 `CHAR` 而非 `VARCHAR`。
    * `CHAR` 可有效提供快速隨機存取，而使用 `VARCHAR` 則必須先找到字串結尾才能移至下一個。
* 對於像部落格文章這種大區塊文字，請使用 `TEXT`。`TEXT` 也允許布林搜尋。使用 `TEXT` 欄位會在磁碟上儲存一個指標，用來定位文字區塊。
* 對於最大至 2^32 或 40 億的大數字，請使用 `INT`。
* 對於貨幣請使用 `DECIMAL` 以避免浮點數表示錯誤。
* 避免儲存大型 `BLOB`，改為儲存物件位置即可。
* `VARCHAR(255)` 是 8 位元數字可計算的最大字元數，通常最大化某些 RDBMS 中一個位元組的運用。
* 於適當處設置 `NOT NULL` 條件以[提升查詢效能](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)。

##### 使用良好的索引

* 你查詢的欄位（`SELECT`、`GROUP BY`、`ORDER BY`、`JOIN`）若加索引，查詢可加速。
* 索引通常以自平衡 [B-tree](https://en.wikipedia.org/wiki/B-tree) 表示，可保持資料排序並允許搜尋、序列存取、插入和刪除皆為對數時間。
* 建立索引會使資料保留在記憶體中，需要更多空間。
* 資料寫入時可能會變慢，因索引也需同步更新。
* 當大量載入資料時，先停用索引、載入資料後再重建索引通常較快。

##### 避免昂貴的 join

* 當效能有需求時，請[反正規化](#denormalization)。

##### 分割資料表


* 將熱點分離到另一個資料表，有助於將表格維持在記憶體中。

##### 調整查詢快取

* 在某些情況下，[查詢快取](https://dev.mysql.com/doc/refman/5.7/en/query-cache.html)可能會導致[效能問題](https://www.percona.com/blog/2016/10/12/mysql-5-7-performance-tuning-immediately-after-installation/)。

##### 來源及延伸閱讀：SQL 調校

* [優化 MySQL 查詢的技巧](http://aiddroid.com/10-tips-optimizing-mysql-queries-dont-suck/)
* [為什麼經常看到 VARCHAR(255) 被使用？](http://stackoverflow.com/questions/1217466/is-there-a-good-reason-i-see-varchar255-used-so-often-as-opposed-to-another-l)
* [NULL 值如何影響效能？](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)
* [慢查詢日誌](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)

### NoSQL

NoSQL 是一種以**鍵值儲存**、**文件儲存**、**寬欄儲存**或**圖形資料庫**表示的資料集合。資料通常是非正規化的，且連接操作一般在應用程式程式碼中完成。大多數 NoSQL 儲存系統缺乏真正的 ACID 交易，並偏好[最終一致性](#eventual-consistency)。

**BASE** 常用來描述 NoSQL 資料庫的特性。與[CAP 定理](#cap-theorem)相比，BASE 選擇可用性而非一致性。

* **基本可用** - 系統保證可用性。
* **軟狀態** - 系統的狀態可能隨時間變化，即使沒有任何輸入。
* **最終一致性** - 假如系統在一段時間內未收到輸入，則最終會達到一致性。

除了選擇[SQL 或 NoSQL](#sql-or-nosql)之外，了解哪一種 NoSQL 資料庫最適合你的使用情境也很重要。接下來我們將介紹**鍵值儲存**、**文件儲存**、**寬欄儲存**和**圖形資料庫**。

#### 鍵值儲存

> 抽象概念：雜湊表

鍵值儲存通常允許 O(1) 讀取與寫入，且常以記憶體或 SSD 為後端。資料儲存可以維持鍵值的[字典序排序](https://en.wikipedia.org/wiki/Lexicographical_order)，使得鍵範圍的高效檢索成為可能。鍵值儲存可以讓值附帶中繼資料。

鍵值儲存提供高效能，常用於簡單的資料模型或快速變化的資料，如記憶體快取層。由於只提供有限的操作集，若需要更多操作，複雜度會轉移到應用層。

鍵值儲存是更複雜系統（如文件儲存，有時甚至是圖形資料庫）的基礎。

##### 來源及延伸閱讀：鍵值儲存

* [鍵值資料庫](https://en.wikipedia.org/wiki/Key-value_database)
* [鍵值儲存的缺點](http://stackoverflow.com/questions/4056093/what-are-the-disadvantages-of-using-a-key-value-table-over-nullable-columns-or)
* [Redis 架構](http://qnimate.com/overview-of-redis-architecture/)
* [Memcached 架構](https://adayinthelifeof.nl/2011/02/06/memcache-internals/)

#### 文件存儲

> 抽象：以文件作為值的鍵值存儲

文件存儲以文件（XML、JSON、二進位等）為核心，每個文件儲存一個物件的所有資訊。文件存儲提供 API 或查詢語言，可以根據文件本身的內部結構進行查詢。*注意，許多鍵值存儲包含處理值的中繼資料功能，這使得這兩種存儲型態的界線變得模糊。*

根據底層實作，文件可以依照集合、標籤、中繼資料或目錄來組織。雖然文件可以被組織或群組在一起，但每個文件的欄位可能完全不同。

一些文件存儲如 [MongoDB](https://www.mongodb.com/mongodb-architecture) 和 [CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/) 也提供類 SQL 語言以執行複雜查詢。[DynamoDB](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) 同時支援鍵值與文件。

文件存儲提供高度彈性，常用於處理偶爾變動的資料。

##### 來源與延伸閱讀：文件存儲

* [文件導向資料庫](https://en.wikipedia.org/wiki/Document-oriented_database)
* [MongoDB 架構](https://www.mongodb.com/mongodb-architecture)
* [CouchDB 架構](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)
* [Elasticsearch 架構](https://www.elastic.co/blog/found-elasticsearch-from-the-bottom-up)

#### 寬列表存儲

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n16iOGk.png">
  <br/>
  <i><a href=http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html>來源：SQL & NoSQL，簡史</a></i>
</p>

> 抽象：巢狀 map `ColumnFamily<RowKey, Columns<ColKey, Value, Timestamp>>`

寬列表存儲的基本資料單位是欄（名稱/值配對）。一個欄可以被分組為欄族（類似 SQL 的資料表）。超級欄族則進一步將欄族分組。你可以用列鍵獨立存取每個欄，具有相同列鍵的欄組成一列。每個值都包含一個時間戳記，用於版本控制與衝突解決。

Google 推出 [Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) 作為第一個寬列表存儲，影響了開源的 [HBase](https://www.edureka.co/blog/hbase-architecture/)，常見於 Hadoop 生態系，以及 Facebook 的 [Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)。BigTable、HBase 和 Cassandra 等存儲會以字典順序維護鍵，讓特定鍵範圍的檢索更有效率。

寬列表存儲提供高可用性和高擴展性。它們常用於處理極大規模資料集。

##### 來源與延伸閱讀：寬列表存儲

* [SQL & NoSQL，簡史](http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html)
* [Bigtable 架構](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)
* [HBase 架構](https://www.edureka.co/blog/hbase-architecture/)
* [Cassandra 架構](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)

#### 圖形資料庫

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/fNcl65g.png">
  <br/>
  <i><a href=https://en.wikipedia.org/wiki/File:GraphDatabase_PropertyGraph.png>來源：圖形資料庫</a></i>
</p>

> 抽象：圖形

在圖形資料庫中，每個節點是一筆記錄，每個弧則是兩個節點間的關係。圖形資料庫針對表示具有許多外鍵或多對多關係的複雜關係進行了優化。

圖形資料庫對於具有複雜關係的資料模型（如社交網路）提供高效能。由於相對較新，目前尚未被廣泛使用；開發工具和資源可能較難取得。許多圖形資料庫只能透過 [REST API](#representational-state-transfer-rest) 存取。

##### 來源及進一步閱讀：圖形

* [圖形資料庫](https://en.wikipedia.org/wiki/Graph_database)
* [Neo4j](https://neo4j.com/)
* [FlockDB](https://blog.twitter.com/2010/introducing-flockdb)

#### 來源及進一步閱讀：NoSQL

* [BASE 術語解釋](http://stackoverflow.com/questions/3342497/explanation-of-base-terminology)
* [NoSQL 資料庫調查及決策指引](https://medium.com/baqend-blog/nosql-databases-a-survey-and-decision-guidance-ea7823a822d#.wskogqenq)
* [可擴展性](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
* [NoSQL 入門](https://www.youtube.com/watch?v=qI_g07C_Q5I)
* [NoSQL 模式](http://horicky.blogspot.com/2009/11/nosql-patterns.html)

### SQL 還是 NoSQL

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wXGqG5f.png">
  <br/>
  <i><a href=https://www.infoq.com/articles/Transition-RDBMS-NoSQL/>來源：從 RDBMS 過渡到 NoSQL</a></i>
</p>

選擇 **SQL** 的原因：

* 結構化資料
* 嚴格的結構定義
* 關聯式資料
* 需要複雜的關聯查詢
* 交易處理
* 明確的擴展模式
* 更成熟：開發者、社群、程式碼、工具等
* 透過索引查詢速度非常快

選擇 **NoSQL** 的原因：

* 半結構化資料
* 動態或彈性結構
* 非關聯式資料
* 不需要複雜的關聯查詢
* 可儲存大量 TB（或 PB）等級的資料
* 極度密集的資料工作負載
* 極高的 IOPS 吞吐量

適合 NoSQL 的範例資料：

* 快速匯入點擊流和日誌資料
* 排行榜或分數資料
* 暫存資料，如購物車
* 頻繁存取的（熱門）資料表
* 中繼資料／查詢資料表

##### 資料來源及延伸閱讀：SQL 或 NoSQL

* [Scaling up to your first 10 million users](https://www.youtube.com/watch?v=kKjm4ehYiMs)
* [SQL vs NoSQL differences](https://www.sitepoint.com/sql-vs-nosql-differences/)

## 快取

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Q6z24La.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>來源：Scalable system design patterns</a></i>
</p>

快取能提升頁面載入速度，並減少伺服器和資料庫的負擔。在此模型中，分派器會先查詢該請求是否曾被提出過，並嘗試尋找先前的結果來回應，以節省實際執行的資源。

資料庫通常受益於其分區上的讀寫均勻分佈。熱門項目可能會使分佈失衡，造成瓶頸。在資料庫前加入快取可協助吸收不均勻的負載與流量高峰。

### 用戶端快取

快取可以部署在用戶端（作業系統或瀏覽器）、[伺服器端](#reverse-proxy-web-server) 或獨立快取層。

### CDN 快取

[CDN](#content-delivery-network) 被視為一種類型的快取。

### 網頁伺服器快取

[反向代理](#reverse-proxy-web-server) 和如 [Varnish](https://www.varnish-cache.org/) 之類的快取能直接服務靜態及動態內容。網頁伺服器也可以快取請求，回傳回應而無須聯絡應用程式伺服器。

### 資料庫快取

資料庫通常在預設配置中包含某種程度的快取，針對一般用例進行最佳化。根據特定使用模式微調這些設定可以進一步提升效能。

### 應用程式快取

記憶體快取如 Memcached 與 Redis 是位於應用程式和資料儲存之間的鍵值儲存。由於資料儲存在 RAM 中，讀取速度遠快於一般將資料存於硬碟的資料庫。RAM 容量較硬碟有限，因此可利用 [快取失效](https://zh.wikipedia.org/wiki/Cache_algorithms) 演算法，如 [最近最少使用 (LRU)](https://zh.wikipedia.org/wiki/Cache_replacement_policies#Least_recently_used_(LRU))，來清除「冷」項目並將「熱」資料保留在 RAM 中。

Redis 還具備以下額外功能：

* 永續化選項
* 內建資料結構，如排序集合與列表

快取有多個層級，主要分為兩大類：**資料庫查詢**與**物件**：

* 列（Row）層級
* 查詢層級
* 完整可序列化物件
* 完整渲染的 HTML

通常應避免使用檔案型快取，因為這會使複製和自動擴充變得困難。

### 在資料庫查詢層級進行快取

每當你查詢資料庫時，將查詢內容進行雜湊，作為鍵並將結果存入快取。這種方法存在過期相關的問題：

* 對於複雜查詢，難以刪除已快取的結果
* 如果某個資料變動，例如資料表的一個儲存格，你需要刪除所有可能包含該儲存格的快取查詢

### 在物件層級進行快取

將你的資料視為物件，類似你在應用程式碼中所做的。讓你的應用程式將資料集從資料庫組合成類別實例或資料結構：

* 當物件的底層資料變動時，從快取移除該物件
* 支援非同步處理：工作者可透過消耗最新快取物件來組裝物件

建議可快取的內容：

* 使用者工作階段
* 完全渲染的網頁
* 活動串流
* 使用者圖譜資料

### 何時更新快取

由於快取只能儲存有限量的資料，你需要判斷哪種快取更新策略最適合你的使用情境。

#### Cache-aside

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/ONjORqk.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>來源：From cache to in-memory data grid</a></i>
</p>

應用程式負責從儲存空間讀寫資料。快取並不直接和儲存空間互動。應用程式執行以下操作：

* 在快取中尋找項目，若未命中快取
* 從資料庫載入項目
* 將項目加入快取
* 回傳項目

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
[Memcached](https://memcached.org/) 通常以此方式使用。

隨後從快取中讀取已加入的資料非常迅速。Cache-aside 也被稱為 lazy loading（延遲載入）。只有被請求的資料才會被快取，這可避免快取中充斥未被請求的資料。

##### 缺點：cache-aside

* 每次快取未命中會產生三次往返，可能導致明顯延遲。
* 如果資料在資料庫中被更新，快取中的資料可能會過時。此問題可透過設定存活時間（TTL）來減輕，TTL 會強制更新快取項目，或透過 write-through 解決。
* 當節點故障時，會由新的空節點取代，導致延遲增加。

#### Write-through（直寫快取）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/0vBc0hN.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>來源：Scalability, availability, stability, patterns</a></i>
</p>

應用程式將快取作為主要資料存儲區，對快取進行資料的讀寫，而快取則負責與資料庫的資料讀寫：

* 應用程式在快取中新增/更新項目
* 快取同步將項目寫入資料存儲
* 回傳

應用程式程式碼：


```python
set_user(12345, {"foo":"bar"})
```

快取程式碼：

```python
def set_user(user_id, values):
    user = db.query("UPDATE Users WHERE id = {0}", user_id, values)
    cache.set(user_id, user)
```
寫入直通（Write-through）由於寫入操作而導致整體運作較慢，但隨後對剛剛寫入的資料進行讀取時則非常快速。使用者在更新資料時通常比在讀取資料時更能容忍延遲。快取中的資料不會過時。

##### 缺點：寫入直通

* 當因故障或擴展而建立新節點時，該新節點在資料庫中的條目被更新前不會快取任何資料。結合快取旁路（Cache-aside）和寫入直通可以減輕此問題。
* 大部分寫入的資料可能永遠不會被讀取，可以透過設定 TTL（存活時間）來減少這種情況。

#### 寫入後端（Write-behind/Write-back）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/rgSrvjG.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>來源：可擴展性、可用性、穩定性、模式</a></i>
</p>

在寫入後端中，應用程式會執行以下操作：

* 在快取中新增/更新條目
* 非同步地將條目寫入資料存儲，以提升寫入效能

##### 缺點：寫入後端

* 如果快取在內容寫入資料存儲前崩潰，可能會導致資料遺失。
* 實作寫入後端比實作快取旁路或寫入直通更為複雜。

#### 預先刷新（Refresh-ahead）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/kxtjqgE.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>來源：從快取到記憶體資料網格</a></i>
</p>

你可以配置快取，使其在任何最近存取的快取條目到期之前自動刷新。

如果快取能夠準確預測未來可能需要的項目，預先刷新能比讀取直通降低延遲。

##### 缺點：預先刷新


* 無法準確預測哪些項目未來可能需要，可能導致效能比不使用預先刷新還低。

### 缺點：快取

* 需要透過[快取失效](https://en.wikipedia.org/wiki/Cache_algorithms)來維持快取與真實資料來源（如資料庫）之間的一致性。
* 快取失效是一個困難的問題，何時更新快取會增加額外的複雜度。
* 需要進行應用程式變更，例如新增 Redis 或 memcached。

### 來源與延伸閱讀

* [從快取到記憶體資料網格](http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast)
* [可擴展系統設計模式](http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html)
* [規模化系統架構入門](http://lethain.com/introduction-to-architecting-systems-for-scale/)
* [可擴展性、可用性、穩定性、模式](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [可擴展性](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
* [AWS ElastiCache 策略](http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Strategies.html)
* [維基百科](https://en.wikipedia.org/wiki/Cache_(computing))

## 非同步性

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/54GYsSx.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>來源：規模化系統架構入門</a></i>
</p>

非同步工作流程有助於減少需要高耗時操作的請求時間，這些操作若同步執行會拖慢整體流程。它們也能提前執行費時的工作，例如定期彙總數據。

### 訊息佇列

訊息佇列負責接收、保存並傳遞訊息。如果某項操作過於緩慢而無法同步執行，可以用訊息佇列搭配以下流程：

* 應用程式將工作發佈到佇列，然後通知用戶工作狀態
* 工作者從佇列中取出工作，處理後再通知工作完成

用戶端不會被阻塞，工作會在背景執行。在這段期間，用戶端也可以選擇執行少量處理，讓任務看起來好像已經完成。例如發送推文時，推文可以立即顯示在你的時間軸上，但實際送達所有粉絲可能還需要一段時間。

**[Redis](https://redis.io/)** 可作為簡單的訊息代理，但訊息有可能遺失。

**[RabbitMQ](https://www.rabbitmq.com/)** 很受歡迎，但你需要適應 'AMQP' 協議並自行管理節點。
**[Amazon SQS](https://aws.amazon.com/sqs/)** 是託管式服務，但可能有較高的延遲，且訊息有可能被重複傳送。

### 任務佇列

任務佇列接收任務及其相關資料，執行任務，然後傳送其結果。它們可以支援排程，並可用於在背景執行高運算密集的作業。

**[Celery](https://docs.celeryproject.org/en/stable/)** 支援排程，主要支援 Python。

### 背壓

如果佇列開始顯著成長，佇列大小可能超過記憶體，導致快取失效、磁碟讀取，甚至效能更慢。[背壓](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html) 可以透過限制佇列大小來幫助維持高吞吐率，以及良好的佇列中工作回應時間。當佇列已滿時，客戶端會收到伺服器忙碌或 HTTP 503 狀態碼，請稍後再試。客戶端可在稍後重試請求，也許可用 [指數退避](https://en.wikipedia.org/wiki/Exponential_backoff)。

### 缺點：非同步性

* 像是廉價計算和即時工作流程這類使用情境，可能更適合同步操作，因為引入佇列會增加延遲與複雜度。

### 來源及進階閱讀

* [It's all a numbers game](https://www.youtube.com/watch?v=1KRYH75wgy4)
* [Applying back pressure when overloaded](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)
* [Little's law](https://en.wikipedia.org/wiki/Little%27s_law)
* [What is the difference between a message queue and a task queue?](https://www.quora.com/What-is-the-difference-between-a-message-queue-and-a-task-queue-Why-would-a-task-queue-require-a-message-broker-like-RabbitMQ-Redis-Celery-or-IronMQ-to-function)

## 通訊

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/5KeocQs.jpg">
  <br/>
  <i><a href=http://www.escotal.com/osilayer.html>來源：OSI 七層模型</a></i>
</p>

### 超文字傳輸協定（HTTP）

HTTP 是用於編碼及傳輸資料的用戶端與伺服器間的方法。它是請求／回應協定：用戶端發出請求，伺服器回應相關內容及請求完成狀態。HTTP 是自包含的，允許請求與回應經由多個中介路由器與伺服器流通，這些設備可執行負載均衡、快取、加密及壓縮。

基本的 HTTP 請求包含一個動詞（方法）和一個資源（端點）。以下是常見的 HTTP 動詞：

| 動詞 | 描述 | 達冪性* | 安全性 | 可快取 |


| GET | 讀取資源 | 是 | 是 | 是 |
| POST | 創建資源或觸發處理資料的流程 | 否 | 否 | 若回應包含新鮮度資訊則為是 |
| PUT | 創建或替換資源 | 是 | 否 | 否 |
| PATCH | 部分更新資源 | 否 | 否 | 若回應包含新鮮度資訊則為是 |
| DELETE | 刪除資源 | 是 | 否 | 否 |

*可以多次呼叫且結果不會不同。

HTTP 是一種應用層協定，依賴於如 **TCP** 和 **UDP** 等較低層的協定。

#### 來源及進一步閱讀：HTTP

* [什麼是 HTTP？](https://www.nginx.com/resources/glossary/http/)
* [HTTP 與 TCP 的差異](https://www.quora.com/What-is-the-difference-between-HTTP-protocol-and-TCP-protocol)
* [PUT 與 PATCH 的差異](https://laracasts.com/discuss/channels/general-discussion/whats-the-differences-between-put-and-patch?page=1)

### 傳輸控制協定（TCP）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/JdAsdvG.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>來源：如何製作多人遊戲</a></i>
</p>

TCP 是一種在 [IP 網路](https://en.wikipedia.org/wiki/Internet_Protocol) 上的面向連線協定。連線的建立和終止是透過 [握手](https://en.wikipedia.org/wiki/Handshaking) 完成的。所有發送的封包都保證以原始順序且無損壞地到達目的地，透過以下方式：

* 對每個封包使用序列號和 [檢查碼欄位](https://en.wikipedia.org/wiki/Transmission_Control_Protocol#Checksum_computation)
* [確認](https://en.wikipedia.org/wiki/Acknowledgement_(data_networks)) 封包和自動重新傳送

如果發送端未收到正確的回應，會重新傳送封包。若多次逾時，連線將被中斷。TCP 也實作了 [流量控制](https://en.wikipedia.org/wiki/Flow_control_(data)) 和 [壅塞控制](https://en.wikipedia.org/wiki/Network_congestion#Congestion_control)。這些保證造成延遲，通常比 UDP 傳輸效率低。

為了確保高吞吐量，Web 伺服器可保持大量 TCP 連線開啟，導致高記憶體使用率。若 Web 伺服器執行緒與如 [memcached](https://memcached.org/) 伺服器間有大量開啟連線，則成本昂貴。可以採用 [連線池](https://en.wikipedia.org/wiki/Connection_pool)，或者在適用時改用 UDP。

TCP 適用於需要高可靠性但對時間要求較低的應用，例如 Web 伺服器、資料庫資訊、SMTP、FTP 和 SSH。

當下列情況時選用 TCP 而非 UDP：

* 你需要所有資料都完整抵達
* 你希望自動最佳化網路吞吐量

### 使用者資料包協定（UDP）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yzDrJtA.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>來源：如何製作多人遊戲</a></i>
</p>

UDP 是無連線式的。資料包（類似於封包）僅在資料包層級被保證。資料包可能無序抵達目的地，甚至完全未抵達。UDP 不支援壅塞控制。由於缺少 TCP 提供的保證，UDP 通常更有效率。

UDP 可以廣播，將資料包發送給子網路上的所有設備。這在 [DHCP](https://en.wikipedia.org/wiki/Dynamic_Host_Configuration_Protocol) 中很有用，因為客戶端尚未獲取 IP 位址，因此無法讓 TCP 在沒有 IP 位址時進行串流。

UDP 的可靠性較低，但在即時用途如 VoIP、視訊聊天、串流及即時多人遊戲中表現良好。

在下列情況下選擇 UDP 而非 TCP：

* 你需要最低的延遲
* 遲到的資料比資料遺失更糟
* 你想自行實作錯誤修正

#### 來源與進一步閱讀：TCP 和 UDP

* [遊戲程式設計的網路](http://gafferongames.com/networking-for-game-programmers/udp-vs-tcp/)
* [TCP 與 UDP 協定的主要差異](http://www.cyberciti.biz/faq/key-differences-between-tcp-and-udp-protocols/)
* [TCP 與 UDP 的差異](http://stackoverflow.com/questions/5970383/difference-between-tcp-and-udp)
* [傳輸控制協定](https://en.wikipedia.org/wiki/Transmission_Control_Protocol)
* [使用者資料包協定](https://en.wikipedia.org/wiki/User_Datagram_Protocol)
* [Facebook 的 Memcache 擴展](http://www.cs.bu.edu/~jappavoo/jappavoo.github.com/451/papers/memcache-fb.pdf)

### 遠端程序呼叫（RPC）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/iF4Mkb5.png">
  <br/>
  <i><a href=http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview>來源：破解系統設計面試</a></i>
</p>

在 RPC 中，客戶端會在不同的位址空間（通常是遠端伺服器）上執行某個程序。該程序的編碼方式就像是本地程序呼叫，將與伺服器溝通的細節從客戶端程式中抽象出來。遠端呼叫通常比本地呼叫慢且不可靠，因此區分 RPC 呼叫與本地呼叫是有幫助的。知名的 RPC 框架包括 [Protobuf](https://developers.google.com/protocol-buffers/)、[Thrift](https://thrift.apache.org/) 和 [Avro](https://avro.apache.org/docs/current/)。

RPC 是一種請求-回應協定：

* **客戶端程式** - 呼叫客戶端存根程序。參數會像本地程序呼叫一樣被推入堆疊。
* **客戶端存根程序** - 將程序 ID 和參數封裝（打包）進請求訊息中。
* **客戶端通訊模組** - 作業系統將訊息從客戶端傳送到伺服器。
* **伺服器通訊模組** - 作業系統將收到的封包傳遞給伺服器存根程序。
* **伺服器存根程序** - 解封（還原）結果，呼叫與程序 ID 相符的伺服器程序並傳遞指定參數。
* 伺服器回應會以相反順序重複上述步驟。

範例 RPC 呼叫：

```
GET /someoperation?data=anId

POST /anotheroperation
{
  "data":"anId";
  "anotherdata": "another value"
}
```

RPC 著重於暴露行為。RPC 通常用於內部通訊以提升效能，因為你可以手工打造原生呼叫以更符合你的使用案例。

當符合以下情境時，請選擇原生函式庫（即 SDK）：

* 你清楚你的目標平台。
* 你希望控制你的「邏輯」存取方式。
* 你希望控制錯誤控管發生在你的函式庫外。
* 效能與最終使用者體驗是你的首要考量。

遵循 **REST** 的 HTTP API 通常更常用於公開 API。

#### 缺點：RPC

* RPC 客戶端會與服務端實作緊密耦合。
* 每新增一個操作或使用案例都必須定義新的 API。
* RPC 的除錯可能很困難。
* 你可能無法直接利用現有技術。例如，可能需要額外努力確保 [RPC 呼叫能在快取伺服器如 [Squid](http://www.squid-cache.org/) 上正確快取](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)。

### 表現層狀態轉換（REST）

REST 是一種強制客戶端/伺服器模式的架構風格，其中客戶端操作由伺服器管理的一組資源。伺服器提供資源的表現與可操作資源或取得新表現的動作。所有通訊必須是無狀態且可快取。

RESTful 介面有四大特性：

* **資源識別（HTTP 的 URI）** - 不論任何操作都使用相同的 URI。
* **隨表現改變（HTTP 的動詞）** - 使用動詞、標頭與主體。
* **自我描述的錯誤訊息（HTTP 的狀態回應）** - 使用狀態碼，不要重新發明輪子。
* **[HATEOAS](http://restcookbook.com/Basics/hateoas/)（HTTP 的 HTML 介面）** - 你的網路服務應可在瀏覽器中完整存取。

REST 呼叫範例：

```
GET /someresources/anId

PUT /someresources/anId
{"anotherdata": "another value"}
```
REST 著重於暴露資料。它最小化了客戶端與伺服器之間的耦合，並且常用於公開的 HTTP API。REST 透過 URI 來暴露資源、[以標頭表示](https://github.com/for-GET/know-your-http-well/blob/master/headers.md)、以及以如 GET、POST、PUT、DELETE 和 PATCH 等動詞來執行動作。REST 為無狀態設計，非常適合水平擴展與分割。

#### 缺點：REST

* 由於 REST 著重於暴露資料，若資源不是自然地組織或以簡單階層存取，可能就不適合使用。例如，若要回傳過去一小時內符合特定事件的一組更新紀錄，這需求不易以路徑表達。REST 可能須以 URI 路徑、查詢參數及請求主體的組合來實作。
* REST 通常只依賴少數幾個動詞（GET、POST、PUT、DELETE 和 PATCH），有時不符合你的使用情境。例如，將過期文件移動至歸檔資料夾，這個動作不容易以這些動詞明確表示。
* 取得具有巢狀階層的複雜資源時，需在客戶端與伺服器間多次來回才能渲染單一檢視，例如取得部落格文章內容及其留言。對於在網路狀況不穩的行動應用來說，多次往返是很不理想的。
* 隨著時間推移，API 回應可能會加入更多欄位，舊版客戶端會收到所有新欄位，即使它們不需要，導致回應負載膨脹與延遲加大。

### RPC 與 REST 呼叫比較

| 操作 | RPC | REST |
|---|---|---|
| 註冊    | **POST** /signup | **POST** /persons |
| 辭職    | **POST** /resign<br/>{<br/>"personid": "1234"<br/>} | **DELETE** /persons/1234 |
| 讀取個人資料 | **GET** /readPerson?personid=1234 | **GET** /persons/1234 |
| 讀取個人項目清單 | **GET** /readUsersItemsList?personid=1234 | **GET** /persons/1234/items |
| 新增項目至個人項目 | **POST** /addItemToUsersItemsList<br/>{<br/>"personid": "1234";<br/>"itemid": "456"<br/>} | **POST** /persons/1234/items<br/>{<br/>"itemid": "456"<br/>} |
| 更新項目    | **POST** /modifyItem<br/>{<br/>"itemid": "456";<br/>"key": "value"<br/>} | **PUT** /items/456<br/>{<br/>"key": "value"<br/>} |
| 刪除項目 | **POST** /removeItem<br/>{<br/>"itemid": "456"<br/>} | **DELETE** /items/456 |

<p align="center">
  <i><a href=https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/>來源：你真的知道為什麼偏好 REST 而非 RPC 嗎</a></i>
</p>

#### 來源與延伸閱讀：REST 與 RPC

* [你真的知道為什麼偏好 REST 而非 RPC 嗎](https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/)
* [什麼時候 RPC 類方法比 REST 更合適？](http://programmers.stackexchange.com/a/181186)
* [REST vs JSON-RPC](http://stackoverflow.com/questions/15056878/rest-vs-json-rpc)
* [破解 RPC 與 REST 的迷思](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)
* [使用 RESTful API 的缺點是什麼](https://www.quora.com/What-are-the-drawbacks-of-using-RESTful-APIs)
* [破解系統設計面試](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Thrift](https://code.facebook.com/posts/1468950976659943/)
* [為什麼內部使用 REST 而非 RPC](http://arstechnica.com/civis/viewtopic.php?t=1190508)

## 安全性

本章節尚可更新。歡迎[貢獻](#contributing)！

安全是一個廣泛的主題。除非你有豐富的經驗、安全背景，或是申請需要安全知識的職位，否則你大概只需要了解基本知識：

* 傳輸及儲存時加密。
* 對所有用戶輸入或任何暴露給用戶的參數進行消毒，以防止 [XSS](https://zh.wikipedia.org/wiki/%E8%B7%A8%E7%B6%B2%E9%A0%81%E6%8F%92%E5%85%A5%E6%94%BB%E6%93%8A) 和 [SQL 注入](https://zh.wikipedia.org/wiki/SQL%E6%B3%A8%E5%85%A5)。
* 使用參數化查詢以防止 SQL 注入。
* 採用[最小權限原則](https://zh.wikipedia.org/wiki/%E6%9C%80%E5%B0%8F%E6%AC%8A%E9%99%90%E5%8E%9F%E5%89%87)。

### 資源與延伸閱讀

* [API 安全檢查清單](https://github.com/shieldfy/API-Security-Checklist)
* [開發者安全指南](https://github.com/FallibleInc/security-guide-for-developers)
* [OWASP 十大安全風險](https://www.owasp.org/index.php/OWASP_Top_Ten_Cheat_Sheet)

## 附錄

有時你會被要求做「隨手估算」。例如，你可能需要估算從磁碟產生 100 個影像縮圖需要多長時間，或某個資料結構會佔用多少記憶體。**二的次方表**及**每個程式設計師都該知道的延遲數據**是很好的參考資料。

### 二的次方表


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

#### 來源及進一步閱讀

* [二的冪次方](https://zh.wikipedia.org/wiki/%E4%BA%8C%E7%9A%84%E5%86%AA%E6%AC%A1%E6%96%B9)

### 每位程式設計師都應該知道的延遲數字

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
根據上述數據的實用指標：

* 從 HDD 以 30 MB/s 順序讀取
* 從 1 Gbps 乙太網路以 100 MB/s 順序讀取
* 從 SSD 以 1 GB/s 順序讀取
* 從主記憶體以 4 GB/s 順序讀取
* 每秒可進行 6-7 次全球往返
* 在資料中心內每秒 2,000 次往返

#### 延遲數據視覺化

![](https://camo.githubusercontent.com/77f72259e1eb58596b564d1ad823af1853bc60a3/687474703a2f2f692e696d6775722e636f6d2f6b307431652e706e67)

#### 來源及延伸閱讀

* [每個程式設計師都該知道的延遲數據 - 1](https://gist.github.com/jboner/2841832)
* [每個程式設計師都該知道的延遲數據 - 2](https://gist.github.com/hellerbarde/2843375)
* [設計、經驗教訓與大型分布式系統建設建議](http://www.cs.cornell.edu/projects/ladis2009/talks/dean-keynote-ladis2009.pdf)
* [建設大型分布式系統的軟體工程建議](https://static.googleusercontent.com/media/research.google.com/en//people/jeff/stanford-295-talk.pdf)

### 更多系統設計面試問題

> 常見系統設計面試問題，並附有解決方式相關資源連結。

| 問題 | 參考資源 |
|---|---|
| 設計類似 Dropbox 的檔案同步服務 | [youtube.com](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| 設計類似 Google 的搜尋引擎 | [queue.acm.org](http://queue.acm.org/detail.cfm?id=988407)<br/>[stackexchange.com](http://programmers.stackexchange.com/questions/38324/interview-question-how-would-you-implement-google-search)<br/>[ardendertat.com](http://www.ardendertat.com/2012/01/11/implementing-search-engines/)<br/>[stanford.edu](http://infolab.stanford.edu/~backrub/google.html) |
| 設計類似 Google 的可擴展網路爬蟲 | [quora.com](https://www.quora.com/How-can-I-build-a-web-crawler-from-scratch) |
| 設計 Google docs | [code.google.com](https://code.google.com/p/google-mobwrite/)<br/>[neil.fraser.name](https://neil.fraser.name/writing/sync/) |
| 設計類似 Redis 的鍵值儲存庫 | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| 設計類似 Memcached 的快取系統 | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| 設計類似 Amazon 的推薦系統 | [hulu.com](https://web.archive.org/web/20170406065247/http://tech.hulu.com/blog/2011/09/19/recommendation-system.html)<br/>[ijcai13.org](http://ijcai13.org/files/tutorial_slides/td3.pdf) |
| 設計類似 Bitly 的 tinyurl 系統 | [n00tc0d3r.blogspot.com](http://n00tc0d3r.blogspot.com/) |
| 設計類似 WhatsApp 的聊天應用程式 | [highscalability.com](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html)
| 設計類似 Instagram 的圖片分享系統 | [highscalability.com](http://highscalability.com/flickr-architecture)<br/>[highscalability.com](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html) |
| 設計 Facebook 動態消息功能 | [quora.com](http://www.quora.com/What-are-best-practices-for-building-something-like-a-News-Feed)<br/>[quora.com](http://www.quora.com/Activity-Streams/What-are-the-scaling-issues-to-keep-in-mind-while-developing-a-social-network-feed)<br/>[slideshare.net](http://www.slideshare.net/danmckinley/etsy-activity-feeds-architecture) |
| 設計 Facebook 時間軸功能 | [facebook.com](https://www.facebook.com/note.php?note_id=10150468255628920)<br/>[highscalability.com](http://highscalability.com/blog/2012/1/23/facebook-timeline-brought-to-you-by-the-power-of-denormaliza.html) |
| 設計 Facebook 聊天功能 | [erlang-factory.com](http://www.erlang-factory.com/upload/presentations/31/EugeneLetuchy-ErlangatFacebook.pdf)<br/>[facebook.com](https://www.facebook.com/note.php?note_id=14218138919&id=9445547199&index=0) |

| 設計一個像 Facebook 的圖譜搜尋功能 | [facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-building-out-the-infrastructure-for-graph-search/10151347573598920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-indexing-and-ranking-in-graph-search/10151361720763920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-the-natural-language-interface-of-graph-search/10151432733048920) |
| 設計一個像 CloudFlare 的內容傳遞網路 | [figshare.com](https://figshare.com/articles/Globally_distributed_content_delivery/6605972) |
| 設計一個像 Twitter 的熱門話題系統 | [michael-noll.com](http://www.michael-noll.com/blog/2013/01/18/implementing-real-time-trending-topics-in-storm/)<br/>[snikolov .wordpress.com](http://snikolov.wordpress.com/2012/11/14/early-detection-of-twitter-trends/) |
| 設計一個隨機 ID 產生系統 | [blog.twitter.com](https://blog.twitter.com/2010/announcing-snowflake)<br/>[github.com](https://github.com/twitter/snowflake/) |
| 回傳某段時間區間內的前 k 筆請求 | [cs.ucsb.edu](https://www.cs.ucsb.edu/sites/default/files/documents/2005-23.pdf)<br/>[wpi.edu](http://davis.wpi.edu/xmdv/docs/EDBT11-diyang.pdf) |
| 設計一個從多個資料中心提供資料的系統 | [highscalability.com](http://highscalability.com/blog/2009/8/24/how-google-serves-data-from-multiple-datacenters.html) |
| 設計一個線上多人紙牌遊戲 | [indieflashblog.com](https://web.archive.org/web/20180929181117/http://www.indieflashblog.com/how-to-create-an-asynchronous-multiplayer-game.html)<br/>[buildnewgames.com](http://buildnewgames.com/real-time-multiplayer/) |
| 設計一個垃圾回收系統 | [stuffwithstuff.com](http://journal.stuffwithstuff.com/2013/12/08/babys-first-garbage-collector/)<br/>[washington.edu](http://courses.cs.washington.edu/courses/csep521/07wi/prj/rick.pdf) |
| 設計一個 API 請求速率限制器 | [https://stripe.com/blog/](https://stripe.com/blog/rate-limiters) |
| 設計一個交易所（如 NASDAQ 或 Binance） | [Jane Street](https://youtu.be/b1e4t2k2KJY)<br/>[Golang Implementation](https://around25.com/blog/building-a-trading-engine-for-a-crypto-exchange/)<br/>[Go Implementation](http://bhomnick.net/building-a-simple-limit-order-in-go/) |
| 新增系統設計問題 | [Contribute](#contributing) |

### 真實世界架構

> 關於真實世界系統設計的文章。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/TcUo2fw.png">
  <br/>
  <i><a href=https://www.infoq.com/presentations/Twitter-Timeline-Scalability>來源：Twitter 時間軸的擴展性</a></i>
</p>

**對以下文章不要聚焦於細節，而是：**

* 辨識這些文章中的共通原則、技術和模式
* 研究各個元件所解決的問題、適用情境及限制
* 檢視所獲得的經驗教訓

|類型 | 系統 | 參考資料 |
|---|---|---|
| 資料處理 | **MapReduce** - Google 的分散式資料處理 | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/mapreduce-osdi04.pdf) |
| 資料處理 | **Spark** - Databricks 的分散式資料處理 | [slideshare.net](http://www.slideshare.net/AGrishchenko/apache-spark-architecture) |
| 資料處理 | **Storm** - Twitter 的分散式資料處理 | [slideshare.net](http://www.slideshare.net/previa/storm-16094009) |
| | | |
| 資料儲存 | **Bigtable** - Google 的分散式欄位式資料庫 | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) |
| 資料儲存 | **HBase** - Bigtable 的開源實作 | [slideshare.net](http://www.slideshare.net/alexbaranau/intro-to-hbase) |
| 資料儲存 | **Cassandra** - Facebook 的分散式欄位式資料庫 | [slideshare.net](http://www.slideshare.net/planetcassandra/cassandra-introduction-features-30103666)
| 資料儲存 | **DynamoDB** - Amazon 的文件導向資料庫 | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) |
| 資料儲存 | **MongoDB** - 文件導向資料庫 | [slideshare.net](http://www.slideshare.net/mdirolf/introduction-to-mongodb) |
| 資料儲存 | **Spanner** - Google 的全球分散式資料庫 | [research.google.com](http://research.google.com/archive/spanner-osdi2012.pdf) |
| 資料儲存 | **Memcached** - 分散式記憶體快取系統 | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| 資料儲存 | **Redis** - 具持久性與多種值型態的分散式記憶體快取系統 | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| | | |
| 檔案系統 | **Google File System (GFS)** - 分散式檔案系統 | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/gfs-sosp2003.pdf) |
| 檔案系統 | **Hadoop File System (HDFS)** - GFS 的開源實作 | [apache.org](http://hadoop.apache.org/docs/stable/hadoop-project-dist/hadoop-hdfs/HdfsDesign.html) |
| | | |
| 其他 | **Chubby** - Google 提供的鬆耦合分散式系統鎖服務 | [research.google.com](http://static.googleusercontent.com/external_content/untrusted_dlcp/research.google.com/en/us/archive/chubby-osdi06.pdf) |
| 其他 | **Dapper** - 分散式系統追蹤基礎架構 | [research.google.com](http://static.googleusercontent.com/media/research.google.com/en//pubs/archive/36356.pdf)
| 其他 | **Kafka** - LinkedIn 推出的發布/訂閱訊息佇列 | [slideshare.net](http://www.slideshare.net/mumrah/kafka-talk-tri-hug) |
| 其他 | **Zookeeper** - 提供同步化的集中式基礎設施與服務 | [slideshare.net](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) |
| | 新增一個架構 | [Contribute](#contributing) |

### 公司架構

| 公司 | 參考資料 |
|---|---|
| Amazon | [Amazon 架構](http://highscalability.com/amazon-architecture) |
| Cinchcast | [每天產出1,500小時音訊](http://highscalability.com/blog/2012/7/16/cinchcast-architecture-producing-1500-hours-of-audio-every-d.html) |
| DataSift | [每秒120,000則推文的即時資料探勘](http://highscalability.com/blog/2011/11/29/datasift-architecture-realtime-datamining-at-120000-tweets-p.html) |
| Dropbox | [我們如何擴充 Dropbox](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ESPN | [每秒運作100,000次 duh nuh nuhs](http://highscalability.com/blog/2013/11/4/espns-architecture-at-scale-operating-at-100000-duh-nuh-nuhs.html) |
| Google | [Google 架構](http://highscalability.com/google-architecture) |
| Instagram | [1,400萬用戶，數TB照片](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html)<br/>[Instagram 運作原理](http://instagram-engineering.tumblr.com/post/13649370142/what-powers-instagram-hundreds-of-instances) |
| Justin.tv | [Justin.Tv 的直播影片廣播架構](http://highscalability.com/blog/2010/3/16/justintvs-live-video-broadcasting-architecture.html) |
| Facebook | [Facebook 擴充 Memcached](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/key-value/fb-memcached-nsdi-2013.pdf)<br/>[TAO: Facebook 的分散式社群圖資料儲存](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/data-store/tao-facebook-distributed-datastore-atc-2013.pdf)<br/>[Facebook 的照片儲存](https://www.usenix.org/legacy/event/osdi10/tech/full_papers/Beaver.pdf)<br/>[Facebook Live 同時串流80萬人](http://highscalability.com/blog/2016/6/27/how-facebook-live-streams-to-800000-simultaneous-viewers.html) |
| Flickr | [Flickr 架構](http://highscalability.com/flickr-architecture) |
| Mailbox | [6週內用戶從0到百萬](http://highscalability.com/blog/2013/6/18/scaling-mailbox-from-0-to-one-million-users-in-6-weeks-and-1.html) |
| Netflix | [Netflix 全端架構360度總覽](http://highscalability.com/blog/2015/11/9/a-360-degree-view-of-the-entire-netflix-stack.html)<br/>[Netflix：按下播放鍵會發生什麼？](http://highscalability.com/blog/2017/12/11/netflix-what-happens-when-you-press-play.html) |
| Pinterest | [每月從0到數十億頁檢視](http://highscalability.com/blog/2013/4/15/scaling-pinterest-from-0-to-10s-of-billions-of-page-views-a.html)<br/>[1,800萬訪客，10倍成長，12名員工](http://highscalability.com/blog/2012/5/21/pinterest-architecture-update-18-million-visitors-10x-growth.html) |
| Playfish | [每月5,000萬用戶且持續成長](http://highscalability.com/blog/2010/9/21/playfishs-social-gaming-architecture-50-million-monthly-user.html) |
| PlentyOfFish | [PlentyOfFish 架構](http://highscalability.com/plentyoffish-architecture) |
| Salesforce | [每天處理13億筆交易的架構](http://highscalability.com/blog/2013/9/23/salesforce-architecture-how-they-handle-13-billion-transacti.html) |
| Stack Overflow | [Stack Overflow 架構](http://highscalability.com/blog/2009/8/5/stack-overflow-architecture.html) |
| TripAdvisor | [4,000萬訪客，2億動態頁檢視，30TB資料](http://highscalability.com/blog/2011/6/27/tripadvisor-architecture-40m-visitors-200m-dynamic-page-view.html) |
| Tumblr | [每月150億頁檢視](http://highscalability.com/blog/2012/2/13/tumblr-architecture-15-billion-page-views-a-month-and-harder.html) |
| Twitter | [Twitter 提升效能10,000%](http://highscalability.com/scaling-twitter-making-twitter-10000-percent-faster)<br/>[每天用 MySQL 儲存2.5億則推文](http://highscalability.com/blog/2011/12/19/how-twitter-stores-250-million-tweets-a-day-using-mysql.html)<br/>[1.5億活躍用戶，30萬QPS，22MB/S資料流](http://highscalability.com/blog/2013/7/8/the-architecture-twitter-uses-to-deal-with-150m-active-users.html)<br/>[大規模時間軸](https://www.infoq.com/presentations/Twitter-Timeline-Scalability)<br/>[Twitter 的大數據與小數據](https://www.youtube.com/watch?v=5cKTP36HVgI)<br/>[Twitter 運維：超越1億用戶的擴充](https://www.youtube.com/watch?v=z8LU0Cj6BOU)<br/>[Twitter 每秒處理3,000張圖片](http://highscalability.com/blog/2016/4/20/how-twitter-handles-3000-images-per-second.html) |
| Uber | [Uber 即時市場平台擴充方式](http://highscalability.com/blog/2015/9/14/how-uber-scales-their-real-time-market-platform.html)<br/>[Uber 擴充到2,000工程師、1,000服務、8,000 Git 儲存庫的經驗教訓](http://highscalability.com/blog/2016/10/12/lessons-learned-from-scaling-uber-to-2000-engineers-1000-ser.html) |
| WhatsApp | [Facebook 以190億美元收購的 WhatsApp 架構](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| YouTube | [YouTube 可擴展性](https://www.youtube.com/watch?v=w5WVu624fY8)<br/>[YouTube 架構](http://highscalability.com/youtube-architecture) |

### 公司工程部落格

> 面試公司時的架構參考。
>
> 遇到的問題可能來自相同領域。

* [Airbnb 工程部落格](http://nerds.airbnb.com/)
* [Atlassian 開發者部落格](https://developer.atlassian.com/blog/)
* [AWS 部落格](https://aws.amazon.com/blogs/aws/)
* [Bitly 工程部落格](http://word.bitly.com/)
* [Box 部落格](https://blog.box.com/blog/category/engineering)
* [Cloudera 開發者部落格](http://blog.cloudera.com/)
* [Dropbox 技術部落格](https://tech.dropbox.com/)
* [Quora 工程部落格](https://www.quora.com/q/quoraengineering)
* [Ebay 技術部落格](http://www.ebaytechblog.com/)
* [Evernote 技術部落格](https://blog.evernote.com/tech/)
* [Etsy Code as Craft](http://codeascraft.com/)
* [Facebook 工程部落格](https://www.facebook.com/Engineering)
* [Flickr Code 部落格](http://code.flickr.net/)
* [Foursquare 工程部落格](http://engineering.foursquare.com/)
* [GitHub 工程部落格](https://github.blog/category/engineering)
* [Google 研究部落格](http://googleresearch.blogspot.com/)
* [Groupon 工程部落格](https://engineering.groupon.com/)
* [Heroku 工程部落格](https://engineering.heroku.com/)
* [Hubspot 工程部落格](http://product.hubspot.com/blog/topic/engineering)
* [High Scalability 部落格](http://highscalability.com/)
* [Instagram 工程部落格](http://instagram-engineering.tumblr.com/)
* [Intel 軟體部落格](https://software.intel.com/en-us/blogs/)
* [Jane Street 技術部落格](https://blogs.janestreet.com/category/ocaml/)
* [LinkedIn 工程部落格](http://engineering.linkedin.com/blog)
* [Microsoft 工程部落格](https://engineering.microsoft.com/)
* [Microsoft Python 工程部落格](https://blogs.msdn.microsoft.com/pythonengineering/)
* [Netflix 技術部落格](http://techblog.netflix.com/)
* [Paypal 開發者部落格](https://medium.com/paypal-engineering)
* [Pinterest 工程部落格](https://medium.com/@Pinterest_Engineering)
* [Reddit 部落格](http://www.redditblog.com/)
* [Salesforce 工程部落格](https://developer.salesforce.com/blogs/engineering/)
* [Slack 工程部落格](https://slack.engineering/)
* [Spotify Labs](https://labs.spotify.com/)
* [Stripe 工程部落格](https://stripe.com/blog/engineering)
* [Twilio 工程部落格](http://www.twilio.com/engineering)
* [Twitter 工程部落格](https://blog.twitter.com/engineering/)
* [Uber 工程部落格](http://eng.uber.com/)
* [Yahoo 工程部落格](http://yahooeng.tumblr.com/)
* [Yelp 工程部落格](http://engineeringblog.yelp.com/)
* [Zynga 工程部落格](https://www.zynga.com/blogs/engineering)

#### 來源與進一步閱讀

想要新增部落格嗎？為了避免重複工作，請考慮將您的公司部落格新增至以下倉庫：

* [kilimchoi/engineering-blogs](https://github.com/kilimchoi/engineering-blogs)

## 正在開發中

有興趣新增章節或協助完成正在進行的章節嗎？[貢獻](#contributing)！

* 使用 MapReduce 進行分散式運算
* 一致性雜湊
* 分散收集
* [貢獻](#contributing)

## 鳴謝

本倉庫中各處皆有提供鳴謝與來源。

特別感謝：

* [Hired in tech](http://www.hiredintech.com/system-design/the-system-design-process/)
* [Cracking the coding interview](https://www.amazon.com/dp/0984782850/)
* [High scalability](http://highscalability.com/)
* [checkcheckzz/system-design-interview](https://github.com/checkcheckzz/system-design-interview)
* [shashank88/system_design](https://github.com/shashank88/system_design)
* [mmcgrana/services-engineering](https://github.com/mmcgrana/services-engineering)
* [System design cheat sheet](https://gist.github.com/vasanthk/485d1c25737e8e72759f)
* [A distributed systems reading list](http://dancres.github.io/Pages/)
* [Cracking the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)

## 聯絡資訊

歡迎隨時聯繫我，討論任何問題、疑問或意見。

我的聯絡資訊可在我的 [GitHub 頁面](https://github.com/donnemartin) 找到。

## 授權

*我在這個儲存庫中提供的程式碼和資源是以開源授權方式提供給您的。由於這是我的個人儲存庫，您取得的程式碼和資源授權是由我本人，而非我的僱主（Facebook）所提供。*

    版權所有 2017 Donne Martin

    創用CC 姓名標示 4.0 國際授權條款 (CC BY 4.0)

    http://creativecommons.org/licenses/by/4.0/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---