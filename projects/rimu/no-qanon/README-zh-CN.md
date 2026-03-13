# No-QAnon

一个反法西斯的QAnon、阴谋论、假新闻、极右翼和歧视性网站域名黑名单。

通过阻止与仇恨团体和恶意行为者相关的网站，旨在化解招募、宣传，并通过心理战、草根运动、网络喷子、假旗行动、马甲账号、随机恐怖主义、恐惧不确定性怀疑（FUD）等策略减缓虚假信息的传播。

域名黑名单仅阻止整个网站：遗憾的是无法阻止社交媒体上经常发生的激进化内容。  
但仍然肯定会减少接触虚假和有害信息。  
法西斯分子以弱势群体为猎物，所以请保持警惕，如有需要，也可考虑使用社交媒体黑名单。

根据[反法西斯许可证](https://github.com/rimu/no-qanon/blob/master/LICENSE.txt)分发。

## Hosts 格式

[Hosts 格式黑名单](https://raw.githubusercontent.com/rimu/no-qanon/master/hosts.txt)，可用于[hosts](https://zh.wikipedia.org/wiki/Hosts%E6%96%87%E4%BB%B6)文件或 PiHole。

[IPV6 版本](https://raw.githubusercontent.com/rimu/no-qanon/master/hosts.txt.ipv6)。

- [在 Windows 电脑上安装说明。](https://github.com/yui-konnu/qanon-block-guide)

- [在 PiHole 上安装说明。](https://www.reddit.com/r/QAnonCasualties/comments/wekhem/how_to_use_pihole_to_block_q_related_websites/)

已知问题：Firefox 的 DNS over HTTPS 选项会绕过电脑的 hosts 文件规则集。https://bugzilla.mozilla.org/show_bug.cgi?id=1453207

## Dnsmasq 格式

[Dnsmasq 格式黑名单](https://raw.githubusercontent.com/rimu/no-qanon/master/dnsmasq.txt)，用于[Dnsmasq](https://thekelleys.org.uk/dnsmasq/doc.html) DNS 服务器软件。

## 浏览器扩展

### Netsane 格式

[Netsane 格式黑名单](https://raw.githubusercontent.com/rimu/no-qanon/master/netsane.txt)，用于[Netsane](https://github.com/rimu/netsane)软件。

### AdBlock Plus 语法

[AdBlock 格式黑名单](https://raw.githubusercontent.com/rimu/no-qanon/master/adblock.txt)，用于广告拦截器（[uBlock Origin](https://ublockorigin.com)、[Adguard](https://adguard.com) 等）或 Adguard Home。它使用[严格阻止规则](https://github.com/gorhill/uBlock/wiki/Strict-blocking)来阻止浏览器访问这些网站。

[点击这里订阅。](https://subscribe.adblockplus.org/?location=https://raw.githubusercontent.com/rimu/no-qanon/master/adblock.txt&title=No-QAnon)

### uBlacklist 语法

[uBlacklist 格式的封锁列表](https://raw.githubusercontent.com/rimu/no-qanon/master/ublacklist.txt)，用于 [uBlacklist](https://github.com/iorate/ublacklist)。它可以从搜索引擎结果中移除被封锁的网站。

[点击这里订阅。](https://iorate.github.io/ublacklist/subscribe?name=No-QAnon&url=https://raw.githubusercontent.com/rimu/no-qanon/master/ublacklist.txt)（该自动订阅链接仅兼容 Chrome，其他浏览器需要手动添加！）

### 域名列表

[域名列表格式](https://raw.githubusercontent.com/rimu/no-qanon/master/domains.txt)，用于 [搜索引擎垃圾屏蔽器](https://github.com/no-cmyk/Search-Engine-Spam-Blocker)。它可以从搜索引擎结果中移除被封锁的网站。

## 如何贡献

克隆此仓库，并在 `sources` 文件夹中的相应 `.txt` 文件中添加新的域名。如果你不想分类，只需将其放入 `sources/default.txt` 文件中即可被封锁。

> 对于 `https://www.example.com` 网站，将 `example.com` 添加到 `sources/default.txt` 文件中。

然后，当你将更改推送到 `sources` 文件夹时，GitHub Actions 会自动触发并生成新的封锁列表版本。如果你想自己生成，可以运行 `scripts/update.sh` 脚本（前提条件：bash，python）。

最后，发起一个拉取请求：我们将在几天内进行审核和批准。

### 分类

被封锁的网站通过 `sources` 文件夹中的子文件夹和 `.txt` 文件进行组织。使用 Markdown（`.md`）文件和注释（`#`）添加更多信息和参考。

### 如何贡献（简易模式）

如果你不了解 Git 的使用，也可以贡献！只需[打开一个问题](https://github.com/rimu/no-qanon/issues)，列出你想添加到列表中的 URL，尽可能按语言和类别分组。我们会尽快检查并添加。

## 其他有用的列表

[Jmdugan 封锁列表](https://github.com/jmdugan/blocklists/tree/master/corporations)：考虑封锁 Twitter、YouTube 和 Facebook，因为它们发布了大量假新闻。

[Antifa-n 封锁列表](https://github.com/antifa-n/pihole/blob/master/blocklist.txt) 也是一个聚焦于法西斯网站的优秀封锁列表。

[绕过方法封锁列表](https://github.com/nextdns/metadata/blob/master/parentalcontrol/bypass-methods) 可用于封锁绕过方法（VPN、代理、DNS 等）。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-13

---