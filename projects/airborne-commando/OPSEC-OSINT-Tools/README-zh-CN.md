## ***免责声明***

我对本页面所列工具或方法的任何滥用、误用或不道德行为**不负任何责任**。**OSINT（开源情报）是一种中立技术**——任何人都可以使用，也可以成为目标。

注意：部分域名（例如 `exposed.lol`）可能已失效，请参考整理的列表或备选链接。

## 建议反馈

如有建议或反馈，请在 [issue 区](https://github.com/airborne-commando/OPSEC-OSINT-Tools/issues) 提交。

## 为什么要写这个？

人们对互联网过于信任。在当今世界，线上与线下几乎无区别——真相与虚构界限模糊。此 README 旨在提升安全意识。你可以克隆、分支、改编，甚至制作成 [Rentry](https://rentry.co/) 页面，以你喜欢的方式传播知识。

你能通过这些内容预测某人的行为吗？不完全能；人有时候是不可预测的。

# OSINT/OPSEC 工具

这里列出了我制作、分支或使用的 OSINT/OPSEC 工具。首先，先介绍一下相关定义。

## 目录
1. [OPSEC](#operations-security-is-a-systematic-process-for)
   - [如何进行 OPSEC](#how-to-opsec)
      - [烟幕与虚假信息](#Smoke-Screen-and-misinfo) 
2. [开源情报（OSINT）](#open-source-intelligence-osint)
3. [谁在用开源情报（OSINT）？](#who-uses-open-source-intelligence-osint)
4. [OSINT 信息来源](#sources-of-osint)
5. [OSINT 画像分析](#digital-profiling-osint-profiling)
6. [闭源信息](#closed-sourced-info)
7. [OSINT 实际案例](#real-world-examples-of-osint)
   - [2016 年空袭协调](#in-the-year-2016-a-basket-weaving-image-board-used-osint-to-pay-some-supposed-terrorist-a-vist-from-a-govt-in-russia-resulting-in-airstrikes)
   - [2017 年希亚·拉博夫抗议](#in-2017-shia-labeouf-had-a-protest-due-to-trumps-election-this-resulted-in-a-basket-weaving-image-board-using-osint-and-sky-patterns-to-figure-out-where-a-flag-is)
8. [工具](#tools)
      - [工具链推荐](#toolchain-recommendations)
9. [美国境内的人肉搜索工具](#people-search-tools-in-the-states)
10. [灰色文献](#grey-literature)
11. [数据泄露](#breached-data)
12. [社交媒体](#social-media)
13. [自查 OSINT](#toolchain-self-osint)
14. [工具列表整理](#curated-lists)
16. [归档工具](#archive-tools-that-ive-made)

## (操作安全) 是一个系统化流程，用于：
1. 识别
2. 保护和控制关键信息

它是一项安全学科和运作职能，涉及一个持续循环：
* 识别关键信息与指示器（CII）
  * 关键信息与指示器是操作安全的核心，旨在保护可能被对手利用的敏感数据。关键信息包括未分类或受控的关于活动、意图、能力或限制的信息，对手可利用这些信息获得优势。指示器是能揭示操作细节的可观察行动或信息，例如程序突然变化或安全措施增强。保护这些信息包括识别漏洞并采取对策防止未授权泄露。
* 分析潜在威胁与漏洞
* 风险评估
* 制定保护 CII 的对策

用于保护信息与活动免受对手威胁。它有助于识别并保护可能让对手获益的敏感信息。OPSEC 原则可应用于日常生活，例如不分享个人信息如出生日期、地址、邮箱、电话等。

**OPSEC 常见失误示例：**
* 在线过度分享个人信息
   * [Chris Chan](https://www.youtube.com/playlist?list=PLABqEYq6H3vpCmsmyUnHnfMOeAnjBdSNm)
   * [suspectAGB](https://opsecfail.github.io/blog.html?filecase=suspectAGB)
* 保留未使用的社交媒体账号
* 在社交媒体与目标互动
   * [w0rmer](https://opsecfail.github.io/blog.html?filecase=w0rmer)
   * [darknetdiaries](https://darknetdiaries.com/transcript/63/)
* [优劣 OPSEC 及部分 OSINT 示例](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/examples.md)

OPSEC 是对其他安全措施的补充，而非替代。

### 如何进行 OPSEC：

* **使用可隐藏身份的服务：**
---

| **类别**               | **工具/技术**      | **描述**                                                           | **优点**                           | **缺点/限制**                       |
|----------------------|-------------------|-------------------------------------------------------------------|-----------------------------------|-------------------------------------|
| **加密消息**         | [Telegram](https://telegram.org/)    | 云端消息，可选端到端加密（“秘密聊天”）                             | 广泛使用，功能丰富                | 默认非端到端加密；数据存储于服务器；需手机号 |
|                      | [Simplex](https://simplex.chat/)     | 无用户标识符（甚至无随机号）                                       | 最大限度元数据隐私                | 用户体验一般，用户基数小            |
|                      | [Signal](https://signal.org/download/)| 默认端到端加密，最小化元数据保留                                   | 隐私黄金标准，抗法院取证           | 需手机号                            |
| **匿名网络**         | [Tor](https://www.torproject.org/)   | 通过加密节点路由流量隐藏 IP                                        | 免费，抗追踪能力强                | 速度慢，常遇验证码                  |
|                      | [Mullvad VPN](https://mullvad.net/en)| 零日志 VPN，可用门罗币支付                                         | 隐私强，匿名支付选项              | VPN 不能弥补糟糕的 OPSEC 习惯        |
| **加密货币**         | [Monero (XMR)](https://www.getmonero.org/) | 难以追踪的加密货币                                             | 交易隐私好                        | 全匿名需本地节点和挖矿，耗时         |
| **身份管理**         | 独立用户名         | 各网站使用不同账号                                                | 防止关联攻击                      | 不用密码管理器难以管理              |
|                      | 文字变换           | 复述文本避免检测                                                  | 规避抄袭/身份关联                 | 可能不自然                          |
|                      | AI 生成头像        | 虚假头像（例如 ThisPersonDoesNotExist.com）                       | 隐藏真实身份                      | 可能不自然                          |
| **自查 OSINT**       | 退出指南           | 从人肉搜索网站移除个人信息                                        | 降低数字足迹                      | 耗时，不全站点免费                  |
| **OPSEC 资源**       | 坏 OPSEC 示例      | [失误列表](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/badopsec.md) | 吸取他人教训                     | N/A                                 |
|                      | 好 OPSEC 实践      | [指南](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/good-opsec.md) | 可执行建议                       | 需自律                              |
| **工具列表**         | OPSEC 工具         | [整理列表](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md) | 资源全面                         | 需及时更新                          |

---

### **要点总结**  
1. **消息**：  
   - 注重隐私时，**Signal** 或 **Simplex** 优于 **Telegram**。  
   - 注意：端到端加密 ≠ 完全匿名（元数据泄漏/习惯也重要）。

2. **匿名性**：  
   - **Tor** + **Mullvad VPN** + **XMR** = 分层保护。  
   - 使用时避免登录个人账号。
   - 建议 Tor 与 Mullvad 分别使用，最大化匿名；VPN、TOR 建议在虚拟机或主机区分使用（[虚拟化建议](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md#virtualization)）。

3. **身份**：  
   - 独立用户名 + AI 头像 + 文字变换 = 更难追踪。  

4. **自查**：  
   - 定期退出数据经纪商、OSINT 自查。  

5. **OPSEC 思维**：  
   - 遵循[好 OPSEC](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/good-opsec.md)，远离[坏习惯](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/badopsec.md)。

**说明**：

TOR 指 Tor 浏览器，VPN 即虚拟专用网络（以 Mullvad 为例，也可选其他经隐私专家验证的 VPN）；XMR 为门罗币。

如有疑惑可查阅 Wikipedia：
1. [VPN](https://en.wikipedia.org/wiki/Virtual_private_network)
   - [VPN 服务](https://en.wikipedia.org/wiki/VPN_service)
2. [TOR](https://en.wikipedia.org/wiki/Tor_(network))
3. [XMR](https://en.wikipedia.org/wiki/Monero)

--- 

### **专业建议**  
- **Signal 注册技巧**：用临时手机号（如 Google Voice）注册。  
- **门罗币挖矿**：运行本地节点，避免被中心化交易所追踪。

详细工具信息见 **[OPSEC 工具列表](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md)**。

## 烟幕与虚假信息

OSINT（开源情报）语境下的“烟幕操作”是指有意识地采取行动，掩盖、误导或掩饰个人或组织真实活动、意图或身份，防止被情报收集者发现。此词源自军事战术，用烟雾遮蔽行动或阵地。在网络与情报领域，该概念被延伸至数字和信息环境。详见[烟幕与虚假信息说明](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/smokescreen-misinfo.md)。

## 开源情报（OSINT）

**<div align="center">什么是 OSINT？如何使用？为何重要？</div>**

- OSINT 是利用公开信息源收集、分析情报以满足特定需求的实践。政府与商业机构使用 OSINT 目的包括：

  - 侦察
  - 网络犯罪调查
  - 市场趋势分析
  - 品牌定位分析
  - 评估组织风险
  - 理解行为者、战术及目标
  - 获取实时信息
  - 做出明智决策
  - 提前预警潜在威胁

## 谁在用开源情报（OSINT）？

- 国家安全与情报机构、执法部门、企业、网络安全与网络犯罪组织、注重隐私者、非政府组织

  - 美国 CIA、国防情报局（DIA）、国家情报总监办公室（ODNI）均使用 OSINT。
  - OSINT 可保护公民（无论私人还是公众）免受身份盗窃、性暴力和虐待。
  - OSINT 可用于监控竞争对手、市场调研、营销策划。
  - OSINT 能在线搜集关于特定目标的情报。
  - OSINT 可检测外部人员如何攻破其计算设备。
  - OSINT 还可用于自查，保障个人隐私。
  - Bellingcat、信息韧性中心、Oryx 等机构使用 OSINT。
  - 你也可以用 OSINT！

## OSINT 信息来源
OSINT 可从多种来源收集信息，包括：
- [公开政府数据](https://www.opendatasoft.com/en/glossary/public-data/)

  - 公开数据指政府或地方机构免费发布的所有信息。其与开放数据不同，后者是公开数据的子集且结构化、易用。部分公开数据难以检索，或需提交信息公开申请。

- [专业及学术出版物](https://www.lawinsider.com/dictionary/academic-publication)

  - 学术出版物指期刊、电子仓储发布的摘要、文章或论文，或在会议/研讨会的展示。

- [商业数据](https://www.lawinsider.com/dictionary/commercial-data)

  - 商业数据指与特定或可识别个人相关的所有数据与信息，无论是否准确，单独或与其他信息合用。可用于实际或潜在客户。
  - 不同定义下同理，涉及所有与企业业务有关的客户数据。
  - 包括卖方实体收集或处理的所有业务客户数据。

- [灰色文献](https://browse.welch.jhmi.edu/c.php?g=1195274)

  - 灰色文献是指由政府、学术、企业和工业部门生成但不受商业出版机构控制的所有格式信息。
  - 灰色文献对研究有用，但检索方式不同于商业出版物。许多灰色文献不会被常用数据库（如 PubMed、CINAHL、Scopus 等）收录。

### OSINT 实际案例

## 2016 年，一个手工艺论坛利用 OSINT 协助俄政府对疑似恐怖分子实施空袭 [相关报道](https://imgur.com/pol-helps-coordinate-airstrike-on-moderate-syrian-rebels-N7DwWP1)

- [事件视频](https://www.youtube.com/watch?v=OR6epSP_Xlw)

  - 2016 年叙利亚内战期间，多个叛军组织试图推翻阿萨德总统。混乱局势使恐怖组织壮大，美国与俄罗斯分别支持不同派别。4chan 的 Syria General 版（SG）有用户称叙利亚反对派 Jaysh al-Izza 在 YouTube 上传了其秘密营地视频。该组织与基地组织有关，被 4chan 用户视为目标。知名用户 Ivan Sirenko（与俄军有联系）从 4chan 获取坐标后推特通知俄国防部，导致对营地空袭。两个月后，同一组织再次曝光新训练营，4chan 用户再次用地标定位并促成新一轮空袭。

更新：事实证明该战争极为复杂，4chan 介入留下案例。主要问题是他们将训练地点带有地理信息的视频发布到网上，极其糟糕的 opsec。

## 2017 年，希亚·拉博夫因川普当选发起抗议；结果被手工艺论坛用 OSINT 和[天象分析找到旗帜位置](https://www.vice.com/en/article/4chan-does-first-good-thing-pulls-off-the-heist-of-the-century1/)

- 2017 年，4chan 用户追踪并替换了 Shia LaBeouf 的“他不会分裂我们”抗议旗帜。仅用旗帜直播画面，他们分析航班、星空与一条推特，最终锁定田纳西州 Greeneville。当地网友通过按喇叭让直播收音，精准定位旗帜。最终用川普帽替换，结束了这场精妙的恶搞。

## 数字画像（OSINT 画像分析）

数字画像与行为分析通过分析目标的在线活动和数字足迹，揭示个人特征和行为倾向。虽然这些方法多由专业人士使用，按系统流程你也可以自行实践。

更多见 [OSINT 画像分析](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/OSINT-profiling.md)

## 闭源信息

- [HUMINT（人力情报）](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/HUMINT.md)

**HUMINT 可通过公开（如采访、汇报、外交报告）或秘密手段（如间谍、秘密监控）收集。**

**如通过数据经纪商购买信息且非公开，且未被[整理列表](#curated-lists)或[自查工具链](#toolchain-self-osint)交叉验证，则视为闭源。**

## 工具

---

| **类别**             | **工具**                  | **链接**                                                                 | **功能**                                                              | **限制/说明**                                      |
|---------------------|--------------------------|-------------------------------------------------------------------------|-----------------------------------------------------------------------|----------------------------------------------------|
| **搜索引擎查询**    | Google-FU                | [GitHub](https://github.com/airborne-commando/GoogleFU-improved)        | 高级谷歌 dork 搜索                                                    | 有速率限制，可能触发验证码                           |
| **生物识别分析**    | Facecheck.ID             | [GitHub](https://github.com/vin3110/facecheck.id-results-extractor)     | 逆向图片搜索，绕过付费墙                                              | 需 Tampermonkey，仅提取源链接                        |
| **用户名/邮箱搜索** | Blackbird                | [GitHub](https://github.com/p1ngul1n0/blackbird)                       | 快速跨平台用户名/邮箱查找                                             | 仅命令行，轻量级                                     |
|                     | Crow (Blackbird GUI)     | [GitHub](https://github.com/airborne-commando/crow)                     | Blackbird 图形界面                                                    | 功能同 CLI                                          |
|                     | Sherlock                 | [GitHub](https://github.com/sherlock-project/sherlock)                  | 支持 300+ 站点的用户名搜索                                            | 误报（如 Imgur），命令行                             |
|                     | No-Shit-Sherlock (GUI)   | [GitHub](https://github.com/airborne-commando/no-shit-sherlock)         | Sherlock 图形界面                                                     | 继承 Sherlock 限制                                  |
|                     | Maigret                  | [GitHub](https://github.com/soxoj/maigret)                              | 用户名关联（Sherlock 分支）                                            | 侧重关联分析                                        |
|                     | Maigret-Night (GUI)      | [GitHub](https://github.com/airborne-commando/maigret-night)            | Maigret 图形界面                                                      | 同 Maigret CLI                                      |
|                     | Holehe                   | [GitHub](https://github.com/megadose/holehe)                            | 检查邮箱在各站点的使用情况                                            | Imgur 误报，命令行                                  |
| **邮箱泄露检测**    | Hudson Rock Extractor    | [GitHub](https://github.com/airborne-commando/hudsonrock-search-extractor)| 手动邮箱泄露检测（基于 Flask）                                       | 非自动化，需手动输入                                 |
| **地理定位**        | Google Maps              | [maps.google.com](https://maps.google.com/)                             | 定位/地标比对                                                         | 仅公开数据，无高级 OSINT 功能                         |
| **通用 OSINT**      | OSINT Rocks              | [osint.rocks](https://osint.rocks/)                                     | 多合一：Hudson Rock、Holehe、GHunt、电话/域名/用户名查找               | Web 端，集多工具于一体                               |

---

### **要点与建议**

1. **误报问题**：  
   - **Sherlock/Holehe**：Imgur 结果常误导，需人工验证。
   - **Facecheck.ID**：仅提取链接，不分析图片，建议结合 [Pimeyes（10 次免费）](https://pimeyes.com/en) 等比对。

2. **命令行 vs. 图形界面**：  
   - **CLI 工具（Blackbird、Sherlock、Maigret）**：速度快，需技术基础。
   - **GUI 封装（Crow、No-Shit-Sherlock）**：适合初学者，底层逻辑相同。

3. **邮箱调查**：  
   - 结合 **Holehe**（账户检测）+ **Hudson Rock Extractor**（泄露数据），详见[工具链推荐](#Toolchain-Recommendations)。
   - Gmail OSINT 用 **GHunt**（见 OSINT Rocks）。

4. **地理定位**：  
   - 用 **Google 地图街景** 验证其他工具（如 ClustrMaps）获取的地标。

5. **OPSEC 注意事项**：  
   - **速率限制**：如 Google-FU 可能被封，建议用代理/VPN。
   - **合法性**：未经授权勿抓取隐私数据（如 Facebook pro）。

6. **生物识别分析**：可用如下工具补充比对：
 - faceonlive.com（3~4 次搜索限制，建议用 TOR）
 - lenso.ai 
之后用新标签打开图片，保存或拖入 facecheck.id 比对（如前述第 1 步）。

---

### **工具链推荐**
- **用户名快速搜索**：Crow（GUI 快速）→ Maigret（GUI 深度）→ Sherlock（CLI 深度）。
- **邮箱泄露**：Have I Been Pwned → Pentester（半免费）→ OSINT Rocks（Hudson Rock/Holehe）→ LOLArchiver。
- **图片**：Facecheck.ID → Pimeyes → lenso.ai → faceonlive
- **文件**：加密分区（LUKS）→ veracrypt → keepassxc

关于 Pentester：其用户名等信息有免费额度，不建议购买，善用快照记录即可。

关于 keepassxc：建议用强密码或 YubiKey（硬件密钥），可建两个库，一个记得住的，一个用于敏感文件的复杂密码。

更多小众工具参见[工具列表整理](#curated-lists)。

流程详见 [OPSEC 文件安全流程](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md#opsec-pipeline-for-secure-files)
    
## 美国境内人肉搜索工具：

**免责声明：下述网站中邮箱信息多源自早期数据泄露；用户一般不会更换邮箱（因双因认证+密码管理器），除非邮箱被攻破或因骚扰、垃圾邮件等原因更换。**

---

| **工具**                       | **查找方式**                 | **返回信息**                   | **备注**                             |
|-------------------------------|------------------------------|-------------------------------|--------------------------------------|
| **[FastPeopleSearch](https://www.fastpeoplesearch.com/)**   | 姓名、电话、地址   | 年龄、地址、电话、邮箱         | 免费，数据可能过时                   |
| **[That's Them](https://thatsthem.com/)**        | 姓名、邮箱、IP、VIN、电话 | IP、地址、电话、邮箱           | 聚合 Intelius/Spokeo 数据，部分付费  |
| **[Nuwber](https://nuwber.com/)**            | 姓名、电话、邮箱、地址 | 出生日期、地址、邮箱、电话     | 详细报告需付费                       |
| **[IDCrawl](https://idcrawl.com/)**           | 姓名、用户名、电话、邮箱 | 姓名、用户名、电话、邮箱       | 侧重用户名/社交媒体                 |
| **[PeekYou](https://www.peekyou.com/)**           | 姓名、用户名、州       | 年龄、社交媒体、邮箱、地址     | 社交媒体画像强                      |
| **[Webmii](https://webmii.com/)**            | 姓名                   | 社交媒体、搜索结果             | 精简，扫描公开网页/社交资料          |
| **[PublicRecords](https://www.publicrecords.onlinesearches.com/)**     | 姓名、地址、州        | 姓名、地址、部分电话           | 免费目录，详细跳转 Intelius 付费     |
| **[ClustrMaps](https://clustrmaps.com/)**        | 姓名、地址              | 地址、居民、房产、IP 数据      | 侧重地理/人口统计，含产权历史        |
| **[fastbackgroundcheck](https://www.fastbackgroundcheck.com)** | 姓名、地址、电话 | 姓名、地址、电话、邮箱         | 号称遍历数十亿记录，详见[官网](https://www.fastbackgroundcheck.com/about) |

---

### **要点观察**：
1. **免费与付费**：大部分工具基础信息免费，详细报告收费（如 PublicRecords→Intelius）。
2. **数据来源**：多数源于同一批泄露/公开记录（邮箱、电话常过时但不少仍在用）。
3. **工具侧重**：  
   - *社交媒体*：PeekYou、IDCrawl  
   - *地理定位*：ClustrMaps  
   - *综合性*：FastPeopleSearch、Nuwber、fastbackgroundcheck  

**免责声明**：准确性有限，用户邮箱除非被盗一般不会更换。请合法、道德使用！

- 更多工具见[工具列表整理](#curated-lists)

## 灰色文献

建议使用此站点查验选民注册：[无需注册](https://vote.gov/register)。部分州需更多信息。

我写了个 [PA 选民服务自动工具](https://github.com/airborne-commando/voter-reg-status)，欢迎分支用于其他州。

## 数据泄露
---

| **工具**                        | **查找方式**     | **返回信息**                                  | **限制/费用**                        | **备注**                                 |
|---------------------------------|------------------|----------------------------------------------|--------------------------------------|------------------------------------------|
| **[Have I Been Pwned](https://haveibeenpwned.com/)**  | 邮箱、电话     | 泄露名称、时间、泄露数据                      | 免费，无明文密码                     | 可信来源，支持新泄露提醒                 |
| **[BreachDirectory](https://breachdirectory.org/)**    | 邮箱、用户名    | 密码哈希片段（SHA-1 前4位）、长度             | 免费，无完整密码                     | 有助于撞库检查                           |
| **[Breach.vip](https://Breach.vip)**         | 邮箱、用户名    | Minecraft 相关泄露（用户名、IP）              | 免费，需注册                         | 游戏账户专用，娱乐性质但可用            |
| **[LeakPeek](https://leakpeek.com/)**           | 邮箱、用户名    | 部分泄露片段（如域名）                        | 5 次免费，TOR 可绕过                 | 付费可查全数据，结果做模糊化            |
| **[LOLArchiver](https://osint.lolarchiver.com/)**        | 邮箱、用户名    | 完整泄露库（如邮箱、密码）                    | 仅付费                              | 专业 OSINT 用，资源高价值                |
| **[Icebreaker](https://github.com/airborne-commando/ice-breaker)**         | 本地泄露文件    | 解析分析大批量泄露数据                        | Python/EXE，建议 <1000GB 文件        | 内含演示脚本，适用于[Facebook 533M](https://github.com/davidfegyver/facebook-533m)等大库（无密码） |
| **[hashes.com](https://hashes.com/)**         | 哈希（MD5、SHA-1 等） | 明文密码（如已解密）                       | 免费/付费破解工具                    | 适合反查泄露哈希                         |
| **[pentester.com](https://pentester.com/)**          | 邮箱、用户名    | 泄露详情（多于 HIBP）                        | 免费，无需 TOR                      | 非官方但数据广，或含敏感信息             |

---

### **要点总结**：  
1. **免费 vs. 付费**：  
   - *免费*：HIBP、BreachDirectory、Pentester、Hashes.com  
   - *限免*：LeakPeek（5 次）、Breach.vip（需登录）  
   - *付费*：LOLArchiver、LeakPeek 收费版  

2. **功能区分**：  
   - *密码恢复*：Hashes.com、BreachDirectory（哈希片段）
   - *游戏泄露*：Breach.vip（Minecraft）
   - *本地分析*：Icebreaker（批量泄露数据解析）

3. **合规/法律说明**：  
   - 多数工具仅提供**部分数据**（如密码前4位）以符合法规
   - 用 LeakPeek 时建议用 TOR 绕过限额
   - 谨防滥用，如 Pentester 可能暴露敏感数据

4. **大数据集分析**：  
   - [Icebreaker](https://github.com/airborne-commando/ice-breaker) + [Facebook 533M](https://github.com/davidfegyver/facebook-533m)（无密码）可做批量分析

---

### **补充资源**：  
- **工具列表整理**：见[工具列表整理](#curated-lists)
- **演示脚本**：[Icebreaker](https://github.com/airborne-commando/ice-breaker) 内含 demo

## 社交媒体
---

| **平台**   | **工具**               | **URL**                                    | **功能**                              | **限制/说明**                     |
|------------|-----------------------|---------------------------------------------|--------------------------------------|-----------------------------------|
| **通用**   | Social Searcher       | [social-searcher.com](https://www.social-searcher.com/) | 多平台联查                        | 免费版有限制                      |
| **Snapchat** | Snapchat Map        | [map.snapchat.com](https://map.snapchat.com/) | 查看公开位置故事                    | 需 Snapchat 账号                  |
| **Instagram**| Dumpor             | [dumpor.com](https://dumpor.com/)           | 匿名浏览资料/故事                   | 可能有限制                        |
| **Twitter**  | Sotwe              | [sotwe.com](https://www.sotwe.com/)         | 匿名浏览推特                        | 无需登录                          |
|              | Xcancel            | [xcancel.com](https://xcancel.com/)         | 轻量推特镜像                        | 简洁界面                          |
|              | Nitter             | [nitter.net](https://nitter.net/)           | 隐私友好推特前端                    | 避免被追踪                        |
| **Facebook** | Facebook Search    | [facebook.com/search](https://www.facebook.com/search/) | 原生 Facebook 搜索                | 无登录功能有限                    |
|              | WhoPostedWhat      | [whopostedwhat.com](https://www.whopostedwhat.com/) | 日期/关键词查 Facebook 帖子        | 需精确查询，限公开账号            |
| **Reddit**   | r00m101.com        | [r00m101](https://r00m101.com/)              | 查询活跃/已删 Reddit 账号           | 完整查询可能需付费                |

---

### **技巧与绕过方法**

1. **Facebook 私密账号**：
   - 方法 1：注册虚假账号（难度高，需验证）
   - 方法 2：浏览器开发者工具→设备模拟器（或用手机）+ 直链访问
   - 建议先尝试无登录或隐私模式

2. **LinkedIn 限制**：
   - 若资料打不开：
     - 等待 1-2 分钟（更换 IP/清 Cookie）
     - 注册基础账号（避免过度操作）
   - 多次查询可能被 HWID/IP 封禁

3. **Twitter 替代方案**：
   - 用 **Nitter/Xcancel** 避免限额与追踪
   - **Sotwe** 无需登录

4. **Instagram**：
   - **Dumpor** 可绕部分隐私设置
   - **快速用法** https://dumpor.io/v/USERNAME 替换 ``USERNAME``
   - **私密账号无效**

---

### **要点总结**
- **匿名性**：Nitter/Dumpor 可避免平台追踪
- **移动端技巧**：用移动端模拟更易访问受限内容
- **耐心**：部分平台（LinkedIn/Facebook）需耐心或注册账号

- 更多工具见下方工具列表整理。

## 工具列表整理

- [Awesome OSINT](https://github.com/jivoi/awesome-osint) - OSINT 工具、博客与视频精选列表

- [OSINT Framework](https://osintframework.com/) - 更全面的工具列表

- [OSINT Resources](https://sizeof.cat/post/osint-resources/) - 收录较新 OSINT 资源（含 NSFW）

  - [归档版](https://archive.ph/rZZf0) 

- Reddit OSINT 社区的 [维基页面](https://www.reddit.com/r/OSINT/wiki/index/)

- [cipher387 的 OSINT 工具集](https://github.com/cipher387/osint_stuff_tool_collection) - 涵盖社交、地图、域名等

**退出**

- [大规模数据经纪商退出列表](https://github.com/yaelwrites/Big-Ass-Data-Broker-Opt-Out-List) 可对比信息并操作退出

- [inteltechniques opt out workbook](https://inteltechniques.com/workbook.html)

- [Google “关于你的结果”](https://myactivity.google.com/results-about-you) - 检查谷歌收录你的信息，建议访问相应网站执行退出操作

## 工具链（自查 OSINT）

Google dork：`https://www.google.com/search?q= "first+last" "Street Address" "City state" "age"` -> [关于你的结果（谷歌索引）](https://myactivity.google.com/results-about-you) -> [大规模退出列表](https://github.com/yaelwrites/Big-Ass-Data-Broker-Opt-Out-List) -> [inteltechniques opt out workbook](https://inteltechniques.com/workbook.html) -> [人肉搜索工具](https://github.com/airborne-commando/OPSEC-OSINT-Tools/tree/main?tab=readme-ov-file#people-search-tools-in-the-states)

**说明** 

[关于你的结果（谷歌索引）](https://myactivity.google.com/results-about-you) 也可接收邮件通知，对比信息时需注意：谷歌会发现包含你姓名和地址的网站，并引导你申请移除。建议先从源网站删除信息，再申请谷歌移除。Google dork 手动方式不易被谷歌识别为机器人。

同时，手动 Google dork 可更快发现并删除相关信息。

## 归档工具（自制）

- [链接提取与归档](https://github.com/airborne-commando/link-extractor-and-archive) —— 用 archive.ph 归档基础网页，需手动编辑（查找与替换）。

其他工具：

- 更多工具见上方工具列表整理

捐赠：

如本项目对你有帮助，欢迎捐赠门罗币：

![mon](https://github.com/user-attachments/assets/f77ce530-5a5d-479d-bb47-481674c93f4c)

    8BPdcsLtA5iWLNTWvYzUVyTWtQkM62e8r7xqAuwjXTSC4RcoSWqpmtyLsMYvz3QNZtT1rbgPUnmVpMAudhxTn6zkRxUFcZN

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---