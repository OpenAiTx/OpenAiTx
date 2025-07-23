
# scammy-bbp
「詐欺的」または非倫理的なバグバウンティプログラムは、セキュリティの欠陥を特定した研究者に報酬を約束することがありますが、支払いを遅延させたり、全く支払わなかったり、開示された脆弱性を悪用したりすることがあります。

詐欺的な可能性のあるバグバウンティプログラムの兆候：

- 不明瞭な利用規約：どの脆弱性が報酬対象になるか、または報酬額が明確に記載されていないプログラム。
- 透明性のない支払い構造：支払いのタイムライン、支払い方法の詳細がなく、支払いがされないという報告がある場合。
- ほとんどまたは全くコミュニティからのフィードバックがない：情報セキュリティコミュニティからの評判や否定的なレビューがない。

`ヒット数：詐欺的であると報告された件数`

| プログラム名              | 報告された問題                                        | プラットフォーム | ソース     | ヒット数
|---------------------------|-------------------------------------------------------|------------|----------------------| ------
| **[H&M](https://www.hm.com/security.txt)** | 報酬なし<sup>1</sup> | 自社運用|  信頼できるハッカー | 2
| **[Celonis](https://www.celonis.com/pdf/vulnerability-disclosure-program/)** | 報告無視<sup>2</sup> | 自社運用 |信頼できるハッカー        | 1
| **[TataPlay](https://www.tataplay.com/bug-bounty-hunter)** | 自動応答、その後無応答 | 自社運用| 信頼できるハッカー | 1
| **[Synack](https://synack.responsibledisclosure.com/hc/en-us)** | 報酬の門番<sup>10</sup>|自社運用 | 信頼できるハッカー | 1
| **[Zeiss](https://www.zeiss.com/disclosure-policy.pdf)**| 報告無視<sup>2</sup> | 自社運用 |信頼できるハッカー| 1
| **[Alefed](https://vdp.alefeducation.com/p/Vulnerability-Disclosure-Policy-and-Submission-Form)**| 影響なしだが修正済<sup>3</sup> |自社運用+YesWeHack|信頼できるハッカー | 1
| **[Cex.io](https://blog.cex.io/news/cex-io-bug-bounty-program-and-policy-22948)**| 支払い失敗<sup>4</sup> | 自社運用 | 信頼できるハッカー | 1 
| **[Roche](https://hackerone.com/roche?type=team)** | パッチして終了<sup>5</sup><br> 重複偽装<sup>7</sup><br>重複幻影<sup>8</sup><br>煙幕攻撃<sup>12</sup>|自社運用 | 信頼できるハッカー | 2
| **[Zopa](https://zopa.com/.well-known/security.txt)** | 範囲の驚き！<sup>9</sup> |自社運用 | 信頼できるハッカー | 1
| **[Atos](https://hackerone.com/atos?type=team)**| バウンティルーレット<sup>11</sup>|自社運用 | 信頼できるハッカー | 1
| **[LuminPDF](https://www.luminpdf.com/bug-bounty-program)** | 影響なしだが修正済<sup>3</sup>|自社運用 | 信頼できるハッカー | 1
| **[ItsLearning](https://itslearning.com/privacy-commitment/responsible-disclosure)** | 修正済みだが報告無視<sup>2</sup> | 自社運用 | 信頼できるハッカー | 1
| **[Resortdata](https://www.resortdata.com/about/responsible-disclosure/)** | 修正済みだが報告無視<sup>2</sup> | 自社運用 | 信頼できるハッカー | 1
| **[Scalr](https://www.scalr.com/system-description)** | 影響なしだが修正済<sup>3</sup> | 自社運用 | 信頼できるハッカー | 1
| **[Standard Bank](http://www.standardbank.co.za/)** | 修正済みだが報告無視<sup>2</sup> | 自社運用 | 信頼できるハッカー | 1
| **[Zynga](https://www.zynga.com/security/rdp)** | 修正済みだが報告無視<sup>2</sup> | 自社運用 | 信頼できるハッカー | 1
| **[Microsoft](https://www.microsoft.com/en-us/msrc/bounty)** | 修正済みだが報告無視<sup>2</sup> <br>  | 自社運用 | 信頼できるハッカー | 2
| **[Cimpress](https://cimpress.com/privacy-security/)** | バウンティルーレット<sup>11</sup> | 自社運用 | 信頼できるハッカー | 2
| **[Swiggy](https://www.swiggy.com/bug-bounty)** | 報酬なし<sup>1</sup> | 自社運用 | 信頼できるハッカー | 1


## Hackerone

このセクションの入力は研究者による公開レポートおよび解説です。

| プログラム名     | レポート       | 問題点 | 議論
|----------------|---------------|------------|---------------
| **[Hackerone]()**|[2180521](https://hackerone.com/reports/2180521)|CVSSのマジック| https://github.com/pdelteil/scammy-bbp/discussions/9
|**[Zendesk]()**| [URL](https://gist.github.com/hackermondev/68ec8ed145fcee49d2f5e2b9d2cf2e52)|神聖な範囲外| https://github.com/pdelteil/scammy-bbp/discussions/10

## BugCrowd

| プログラム名              | 報告された問題                                        | プラットフォーム | ソース     | ヒット数
|---------------------------|-------------------------------------------------------|------------|----------------------| ------
| **WesternUnion** | 修正済みだが報告無視<sup>2</sup> <br> 重複して廃棄<sup>13</sup>  | 自社運用 | 信頼できるハッカー | 2


## 詳細

- <sup>1</sup>**報酬なし:** プログラム内で報告に報酬を約束しているが、支払いをしない。時に報酬支払いを停止した、またはもうできないと言うだけの場合もある。
- <sup>2</sup>**報告無視:** 研究者に全く返答しない。2ヶ月以上返答なしが続いている。
- <sup>3</sup>**影響なしだが修正済:** バグはCVSS 0と評価され影響なし、または類似の理由であるが修正されている。  
- <sup>4</sup>**支払い失敗:** バウンティ支払いに同意したが支払われなかった。フォローアップメールも無視されることが多い。
- <sup>5</sup>**パッチして終了:** 報告されたバグは修正するが、範囲外として扱う。
- <sup>6</sup>**P1報告必須:** P1/高リスクのバグを報告しない限り、プライベートプログラムに招待しない。
- <sup>7</sup>**重複偽装:** 報告がほぼ初出の内容でも重複と判断される。
- <sup>8</sup>**重複幻影:** ドメインの完全なリストがないまま、すべての（将来の）報告を重複とする。
- <sup>9</sup>**範囲の驚き！:** 報告後に「対象範囲内」「対象範囲外」を定義し、プログラム概要には書かれていない。
- <sup>10</sup>**報酬の門番:** 報酬は自社サイトのアカウントを持っている場合のみ支払う（取得が非常に困難な場合がある）。
- <sup>11</sup>**バウンティルーレット:** 報酬支払いが不明確。プログラム名やメールアドレスに「バグバウンティ」と含めるなど、欺瞞的な情報を含むことが多い。
- <sup>12</sup>**煙幕攻撃:** 企業が報告者の評判を傷つけようとする行為。
- <sup>13</sup>**重複して廃棄:** 同種・同クラスの報告をすべて重複と判断する。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---