# IPTV [![update](https://github.com/iptv-org/iptv/actions/workflows/update.yml/badge.svg)](https://github.com/iptv-org/iptv/actions/workflows/update.yml)

来自世界各地的公开可用IPTV（互联网协议电视）频道合集。

## 目录

- 🚀 [如何使用？](#how-to-use)
- 📺 [播放列表](#playlists)
- 🗓 [EPG](#epg)
- 🗄 [数据库](#database)
- 👨‍💻 [API](#api)
- 📚 [资源](#resources)
- 💬 [讨论](#discussions)
- ❓ [常见问题](#faq)
- 🛠 [贡献](#contribution)
- ⚖ [法律声明](#legal)
- © [许可证](#license)

## 如何使用？

只需将以下任意一个链接插入到支持直播流的[任意视频播放器](https://github.com/iptv-org/awesome-iptv#apps)中，然后点击 _打开_。

![VLC网络面板](https://github.com/iptv-org/iptv/raw/master/.readme/preview.png)

## 播放列表

我们提供多种分组方式的播放列表版本。自2024年1月30日起，我们已停止分发NSFW频道。更多信息请参见[此议题](https://github.com/iptv-org/iptv/issues/15723)。

### 主播放列表

此播放列表包含本仓库中所有已知频道。

```
https://iptv-org.github.io/iptv/index.m3u
```

### 按类别分组

频道按类别分组的播放列表。所有支持类别及其描述请见[此处](.readme/supported-categories.md)。

<details>
<summary>展开</summary>
<br>

```
https://iptv-org.github.io/iptv/index.category.m3u
```

同样内容，按类别拆分为独立文件：

<!-- 保持表格原样 -->
<table>
  <thead>
    <tr><th align="left">Category</th><th align="left">Channels</th><th align="left">Playlist</th></tr>
  </thead>
  <tbody>
    <tr><td>Animation</td><td align="right">47</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/animation.m3u</code></td></tr>
    <tr><td>Auto</td><td align="right">19</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/auto.m3u</code></td></tr>
    <tr><td>Business</td><td align="right">63</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/business.m3u</code></td></tr>
    <tr><td>Classic</td><td align="right">47</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/classic.m3u</code></td></tr>
    <tr><td>Comedy</td><td align="right">83</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/comedy.m3u</code></td></tr>
    <tr><td>Cooking</td><td align="right">29</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/cooking.m3u</code></td></tr>
    <tr><td>Culture</td><td align="right">162</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/culture.m3u</code></td></tr>
    <tr><td>Documentary</td><td align="right">113</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/documentary.m3u</code></td></tr>
    <tr><td>Education</td><td align="right">158</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/education.m3u</code></td></tr>
    <tr><td>Entertainment</td><td align="right">566</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/entertainment.m3u</code></td></tr>
    <tr><td>Family</td><td align="right">49</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/family.m3u</code></td></tr>
    <tr><td>General</td><td align="right">2284</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/general.m3u</code></td></tr>
    <tr><td>Kids</td><td align="right">248</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/kids.m3u</code></td></tr>
    <tr><td>Legislative</td><td align="right">190</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/legislative.m3u</code></td></tr>
    <tr><td>Lifestyle</td><td align="right">93</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/lifestyle.m3u</code></td></tr>
    <tr><td>Movies</td><td align="right">300</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/movies.m3u</code></td></tr>
    <tr><td>Music</td><td align="right">621</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/music.m3u</code></td></tr>
    <tr><td>News</td><td align="right">770</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/news.m3u</code></td></tr>
    <tr><td>Outdoor</td><td align="right">50</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/outdoor.m3u</code></td></tr>
    <tr><td>Relax</td><td align="right">3</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/relax.m3u</code></td></tr>
    <tr><td>Religious</td><td align="right">702</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/religious.m3u</code></td></tr>
    <tr><td>Science</td><td align="right">24</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/science.m3u</code></td></tr>
    <tr><td>Series</td><td align="right">260</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/series.m3u</code></td></tr>
    <tr><td>Shop</td><td align="right">88</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/shop.m3u</code></td></tr>
    <tr><td>Sports</td><td align="right">278</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/sports.m3u</code></td></tr>
    <tr><td>Travel</td><td align="right">44</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/travel.m3u</code></td></tr>
    <tr><td>Weather</td><td align="right">13</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/weather.m3u</code></td></tr>
    <tr><td>XXX</td><td align="right">0</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/xxx.m3u</code></td></tr>
    <tr><td>Undefined</td><td align="right">3818</td><td nowrap><code>https://iptv-org.github.io/iptv/categories/undefined.m3u</code></td></tr>
  </tbody>
</table>

</details>

### 按语言分组

频道按其播出语言分组的播放列表。

<details>
<summary>展开</summary>
<br>

```
https://iptv-org.github.io/iptv/index.language.m3u
```

同样内容，按语言拆分为独立文件：

<!-- 保持表格原样 -->
<table>
  <thead>
    <tr><th align="left">Language</th><th align="left">Channels</th><th align="left">Playlist</th></tr>
  </thead>
  <tbody>
    <!-- 表格内容省略，保持原样 -->
  </tbody>
</table>

</details>

### 按国家分组

频道按其播出国家分组的播放列表。

<details>
<summary>展开</summary>
<br>

```
https://iptv-org.github.io/iptv/index.country.m3u
```

同样内容，按国家拆分为独立文件：

<!-- 保持表格原样 -->
<table>
  <thead>
    <tr><th align="left">Country</th><th align="left">Channels</th><th align="left">Playlist</th></tr>
  </thead>
  <tbody>
    <!-- 表格内容省略，保持原样 -->
  </tbody>
</table>

</details>

### 按地区分组

频道按其播出地区分组的播放列表。

<details>
<summary>展开</summary>
<br>

```
https://iptv-org.github.io/iptv/index.region.m3u
```

同样内容，按地区拆分为独立文件：

<!-- 保持表格原样 -->
<table>
  <thead>
    <tr><th align="left">Region</th><th align="left">Channels</th><th align="left">Playlist</th></tr>
  </thead>
  <tbody>
    <!-- 表格内容省略，保持原样 -->
  </tbody>
</table>

</details>

## EPG

大多数频道的[电子节目指南](https://en.wikipedia.org/wiki/Electronic_program_guide)（EPG）可通过[iptv-org/epg](https://github.com/iptv-org/epg)仓库中发布的工具下载。

## 数据库

所有频道数据均来自 [iptv-org/database](https://github.com/iptv-org/database) 仓库。如果您发现任何错误，请在此仓库中新建[issue](https://github.com/iptv-org/database/issues)反馈。

## API

API文档可在 [iptv-org/api](https://github.com/iptv-org/api) 仓库中查阅。

## 资源

其他有用的IPTV相关资源链接可在 [iptv-org/awesome-iptv](https://github.com/iptv-org/awesome-iptv) 仓库中找到。

## 讨论

如果您需要帮助寻找频道、有问题或想法，欢迎访问[讨论区](https://github.com/orgs/iptv-org/discussions)。

## 常见问题

最常见问题的解答可在 [FAQ.md](FAQ.md) 文件中找到。

## 贡献

在提交issue或发起pull request前，请务必阅读[贡献指南](CONTRIBUTING.md)。

同时感谢所有已做出贡献的朋友！

### 支持者

<a href="https://opencollective.com/iptv-org"><img src="https://opencollective.com/iptv-org/backers.svg?width=890" /></a>

### 贡献者

<a href="https://github.com/iptv-org/iptv/graphs/contributors"><img src="https://opencollective.com/iptv-org/contributors.svg?width=890" /></a>

## 法律声明

本仓库不存储任何视频文件。仓库仅包含用户提交的公开可用视频流URL链接，据我们所知，这些链接已由版权所有者有意公开。如果这些播放列表中的任何链接侵犯了您的版权所有权益，您可以通过提交[pull request](https://github.com/iptv-org/iptv/pulls)或新建[issue](https://github.com/iptv-org/iptv/issues/new?assignees=freearhey&labels=removal+request&template=--removal-request.yml&title=Remove%3A+)申请移除。但请注意，我们对链接的目标网站没有任何控制权，仅从播放列表中移除链接并不会从网络上移除其内容。请注意，链接并不直接侵犯版权，因为在提供链接的网站上并未制作任何副本，因此这**不是**向GitHub发送DMCA通知的有效理由。如需从网络上移除该内容，应联系真正托管该内容的网站主机（**不是**GitHub，也不是本仓库的维护者）。

## 许可证

[![CC0](http://mirrors.creativecommons.org/presskit/buttons/88x31/svg/cc-zero.svg)](LICENSE)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---