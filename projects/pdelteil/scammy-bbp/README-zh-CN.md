<translate-content># scammy-bbp
“骗局”或不道德的漏洞赏金计划有时会承诺奖励给发现安全漏洞的研究人员，但要么延迟支付，要么根本不支付，或者滥用披露的漏洞。

潜在骗局漏洞赏金计划的迹象：

- 条款和条件不明确：计划未明确说明哪些漏洞符合奖励资格或奖励金额。
- 缺乏透明的支付结构：缺少关于支付时间表、支付方式的细节，或有人报告未收到付款的情况。
- 几乎没有社区反馈：缺乏信息安全社区的声誉或存在负面评价。

`命中次数：# 被举报为骗局的数量`

| 计划名称              | 报告的问题                                        | 平台 | 来源     | 命中次数
|---------------------------|-------------------------------------------------------|------------|----------------------| ------
| **[H&M](https://www.hm.com/security.txt)** | 无奖励<sup>1</sup> |自托管|  可信黑客 | 2
| **[Celonis](https://www.celonis.com/pdf/vulnerability-disclosure-program/)** | 忽视报告<sup>2</sup> | 自托管 |可信黑客        | 1
| **[TataPlay](https://www.tataplay.com/bug-bounty-hunter)** | 自动回复，随后无回应 | 自托管| 可信黑客 | 1
| **[Synack](https://synack.responsibledisclosure.com/hc/en-us)** | 奖励守门人<sup>10</sup>|自托管 | 可信黑客 | 1
| **[Zeiss](https://www.zeiss.com/disclosure-policy.pdf)**| 忽视报告<sup>2</sup> | 自托管 |可信黑客| 1
| **[Alefed](https://vdp.alefeducation.com/p/Vulnerability-Disclosure-Policy-and-Submission-Form)**| 无影响但修复<sup>3</sup> |自托管+YesWeHack|可信黑客 | 1
| **[Cex.io](https://blog.cex.io/news/cex-io-bug-bounty-program-and-policy-22948)**| 未支付<sup>4</sup> | 自托管 | 可信黑客 | 1 
| **[Roche](https://hackerone.com/roche?type=team)** | 修补即过<sup>5</sup><br> 伪装重复<sup>7</sup><br> 幻影重复<sup>8</sup><br> 烟幕反击<sup>12</sup>|自托管 | 可信黑客 | 2
| **[Zopa](https://zopa.com/.well-known/security.txt)** | 范围惊喜！<sup>9</sup> |自托管 | 可信黑客 | 1
| **[Atos](https://hackerone.com/atos?type=team)**| 奖励轮盘<sup>11</sup>|自托管 | 可信黑客 | 1
| **[LuminPDF](https://www.luminpdf.com/bug-bounty-program)** | 无影响但修复<sup>3</sup>|自托管 | 可信黑客 | 1
| **[ItsLearning](https://itslearning.com/privacy-commitment/responsible-disclosure)** | 修复且忽视报告<sup>2</sup> | 自托管 | 可信黑客 | 1
| **[Resortdata](https://www.resortdata.com/about/responsible-disclosure/)** | 修复且忽视报告<sup>2</sup> | 自托管 | 可信黑客 | 1
| **[Scalr](https://www.scalr.com/system-description)** | 无影响但修复<sup>3</sup> | 自托管 | 可信黑客 | 1
| **[Standard Bank](http://www.standardbank.co.za/)** | 修复且忽视报告<sup>2</sup> | 自托管 | 可信黑客 | 1
| **[Zynga](https://www.zynga.com/security/rdp)** | 修复且忽视报告<sup>2</sup> | 自托管 | 可信黑客 | 1
| **[Microsoft](https://www.microsoft.com/en-us/msrc/bounty)** | 修复且忽视报告<sup>2</sup> <br>  | 自托管 | 可信黑客 | 2
| **[Cimpress](https://cimpress.com/privacy-security/)** | 奖励轮盘<sup>11</sup> | 自托管 | 可信黑客 | 2
| **[Swiggy](https://www.swiggy.com/bug-bounty)** | 无奖励<sup>1</sup> | 自托管 | 可信黑客 | 1


## Hackerone

本节输入为研究人员公开的报告和分析。

| 计划名称     | 报告       | 问题 | 讨论
|----------------|---------------|------------|---------------
| **[Hackerone]()**|[2180521](https://hackerone.com/reports/2180521)|CVSS 魔法| https://github.com/pdelteil/scammy-bbp/discussions/9
|**[Zendesk]()**| [链接](https://gist.github.com/hackermondev/68ec8ed145fcee49d2f5e2b9d2cf2e52)|神圣的范围外| https://github.com/pdelteil/scammy-bbp/discussions/10

## BugCrowd

| 计划名称              | 报告的问题                                        | 平台 | 来源     | 命中次数
|---------------------------|-------------------------------------------------------|------------|----------------------| ------
| **WesternUnion** | 修复且忽视报告<sup>2</sup> <br> 重复并丢弃<sup>13</sup>  | 自托管 | 可信黑客 | 2


## 详情

- <sup>1</sup>**无奖励：** 他们承诺在计划中对报告给予奖励，但未支付。有时他们直接说停止支付奖励或无法支付。
- <sup>2</sup>**忽视报告：** 从未回复研究人员。时间超过2个月且持续中。
- <sup>3</sup>**无影响但修复：** 漏洞被评为CVSS 0，无影响或类似情况，但仍然修复。
- <sup>4</sup>**未支付：** 同意支付赏金但从未兑现。经常忽略后续邮件。
- <sup>5</sup>**修补即过：** 他们修复报告的漏洞，但标记为范围外。
- <sup>6</sup>**必须P1否则不邀：** 除非报告P1/高危漏洞，否则不邀请加入私有计划。
- <sup>7</sup>**伪装重复：** 当报告极不可能之前被报告时，他们标记为重复。
- <sup>8</sup>**幻影重复：** 在没有完整域名列表的情况下，将所有（未来）报告标记为重复。
- <sup>9</sup>**范围惊喜！：** 他们在你提交报告后定义“范围内”和“范围外”，并未在计划简介中写明。
- <sup>10</sup>**奖励守门人：** 只有你拥有其网站账户（可能非常难获得）时才支付奖励。
- <sup>11</sup>**奖励轮盘：** 不确定是否支付赏金。经常包含欺骗信息：称其页面或网站为“漏洞赏金计划”，邮件地址包含漏洞赏金等。
- <sup>12</sup>**烟幕反击：** 当公司试图破坏报告者声誉时。
- <sup>13</sup>**重复并丢弃：** 他们将所有相同类型/类别的报告标记为重复。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---