<translate-content># 公开免费后缀：人人免费域名

**公开免费后缀** 是一个非盈利的免费子域名服务，旨在赋能各类社区。我们致力于提供便捷的资源给：

* **开发者：** 适合项目测试、预发布环境和个人开发沙箱。
* **学生：** 理想的学术研究、课堂项目和学习新技术的无成本途径。
* **技术人员：** 计算机和网络技术研究、实验室搭建及新配置试验的优良资源。
* **个人用户：** 在我们的合规框架内托管个人博客、作品集或小型兴趣项目。

任何人都可以在这里注册并获得免费的域名，无需每年续费。当前提供服务的后缀如下（二级域名）：</translate-content>
```text
pfsdns.org
nastu.net
tun.re
6ti.net
no.kg
htu.edu.kg
```
## 支持的第三方 DNS 托管平台
经过用户测试并支持的第三方 DNS 服务托管平台（付费/免费）。您需要先将想要的域名添加到这些平台，获取 NS 记录，然后发起 PR 注册流程。

[<img alt="dns.he.net" title="dns.he.net" height="40px" style="margin-right:10px" src="https://dns.he.net/include/images/helogo.gif" />](https://dns.he.net/?src=PublicFreeSuffix)
[<img alt="desec.io" title="desec.io" height="40px" style="margin-right:10px" src="https://desec.io/assets/logo-CP29ePBl.svg" />](https://desec.io/?src=PublicFreeSuffix)
[<img alt="hostry.com" title="hostry.com" height="40px" src="https://hostry.com/img/logo.svg?v=1.00r3266" />](https://hostry.com/?src=PublicFreeSuffix)

## 我如何注册域名？

[可接受使用政策](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/agreements/acceptable-use-policy.md) | 
[隐私政策](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/agreements/privacy-policy.md) | 
[注册和使用协议](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/agreements/registration-and-use-agreement-sokg.md) | 
[保留字列表](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/reserved_words.txt)
1. 克隆仓库：

```bash
git clone https://github.com/PublicFreeSuffix/PublicFreeSuffix.git
```
为您自己的域名创建一个新分支：
```bash
git checkout main
git pull origin main
git checkout -b yourdomain.no.kg-request-1
```
<translate-content>在执行任何 PR（拉取请求）操作之前——无论是注册、更新还是删除域名的 Whois 文件——您都应始终切换回主分支，并将最新的更改同步到本地环境。  
随后，按照指定的分支命名规范创建一个新分支。保存您的更改，然后从该新分支创建一个新的 PR。  
分支命名规范应始终根据具体的操作次数进行调整，格式为：`yourdomain.no.kg-request-{a_number_here}`。  
  
2. 选择可用的域名，并在 `./whois/{your-new-domain-name}.json` 文件夹中创建新的 whois 文件：</translate-content>
```json
{
  "registrant": "your-own-example@gmail.com",
  "domain": "mynewdomain",
  "sld": "no.kg",
  "nameservers": [
    "nameserver1.example.com",
    "nameserver2.example.com",
    "nameserver3.example.com",
    "nameserver4.example.com"
  ],
  "agree_to_agreements": {
    "registration_and_use_agreement": true,
    "acceptable_use_policy": true,
    "privacy_policy": true
  }
}
```
- `registrant`：域名所有者的电子邮件地址。  
- `domain`：不含顶级域的域名（例如，“mynewdomain”），域名长度必须超过3个字符。  
- `sld`：您想注册的后缀（例如，“no.kg”或之前列表中的某个SLD）。  
- `nameservers`：负责解析域名的DNS服务器列表，允许2到4个服务器。  
- `agree_to_agreements`：一个布尔值，表示用户是否已同意注册及使用协议、可接受使用政策和隐私政策。  
- 此文件的名称必须为 `{your-new-domain-name}.json`，例如这里的 `mynewdomain.no.kg.json`。  

> **注意** 为了提高利用率并防止抢注和资源浪费，如果检测到连续30天未部署任何网站内容，您的注册域名将被撤销。  

3. 创建一个包含您新域名和whois文件的拉取请求，您的PR描述应采用[PR描述模板](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/.github/pull_request_template.md)格式，标题应格式为：
```text
Registration/Update/Remove: {your-new-domain-name}.{sld}
```
一个拉取请求仅允许提交一个域名注册请求。

4. 根据[通过电子邮件的自动注册人授权(ARAE)](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/AUTHORIZATION.md)说明，完成注册人邮箱验证。

5. 域名设置完成后，您可以将其用于您的网站或其他用途。

## 如何更新我的域名NS / 注册人邮箱？
很简单，只需修改您的whois文件并创建一个新的拉取请求，然后再次完成注册人邮箱验证。

[<img title="举报域名滥用" src="https://i.postimg.cc/Xq7VHpLs/rebuse-log.png" height="35px" />](https://forms.gle/cXkxrKbdoeBsKBQdA)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---