Yuebing 🥮
==========
Yuebing 是用于运行视频托管网站的开源软件。

Yuebing 会自动将您的源视频准备为现代格式的流媒体，可在任何设备和任何网络连接上播放。

Yuebing 可以使用 Amazon S3 或 Backblaze B2 作为后端存储，并具有许多高级功能。

### 来源
* [GitHub 上的 yuebing](https://github.com/cobbzilla/yuebing)
* [npm 上的 yuebing](https://www.npmjs.com/package/yuebing)
* [DockerHub 上的 yuebing](https://hub.docker.com/r/cobbzilla/yuebing)

# 用其他语言阅读
此 README.md 文档已通过 [hokeylization](https://github.com/cobbzilla/hokeylization) 翻译成多种语言。

我确信它不是完美的，但我希望总比没有好！

&nbsp;&nbsp;&nbsp;[🇸🇦 阿拉伯语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ar/README.md)
&nbsp;&nbsp;&nbsp;[🇧🇩 孟加拉语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/bn/README.md)
&nbsp;&nbsp;&nbsp;[🇩🇪 德语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/de/README.md)
&nbsp;&nbsp;&nbsp;[🇺🇸 英语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/en/README.md)
&nbsp;&nbsp;&nbsp;[🇪🇸 西班牙语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/es/README.md)
&nbsp;&nbsp;&nbsp;[🇫🇷 法语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/fr/README.md)
&nbsp;&nbsp;&nbsp;[🇹🇩 豪萨语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ha/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇳 印地语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/hi/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇩 印度尼西亚语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/id/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇹 意大利语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/it/README.md)
&nbsp;&nbsp;&nbsp;[🇯🇵 日语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ja/README.md)
&nbsp;&nbsp;&nbsp;[🇰🇷 韩语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ko/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇳 马拉地语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/mr/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇱 波兰语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/pl/README.md)
&nbsp;&nbsp;&nbsp;[🇧🇷 葡萄牙语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/pt/README.md)
&nbsp;&nbsp;&nbsp;[🇷🇺 俄语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ru/README.md)
&nbsp;&nbsp;&nbsp;[🇰🇪 斯瓦希里语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/sw/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇭 他加禄语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/tl/README.md)
&nbsp;&nbsp;&nbsp;[🇹🇷 土耳其语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/tr/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇰 乌尔都语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ur/README.md)


&nbsp;&nbsp;&nbsp;[🇻🇳 越南语](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/vi/README.md)
&nbsp;&nbsp;&nbsp;[🇨🇳 中文](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/zh/README.md)
----

# 目录
* [灵感来源](#Inspiration)
* [功能特色](#Features)
* [安装](#Installation)
  * [Docker](#Docker)
  * [npm 包](#npm-package)
  * [源码安装](#From-source)
* [配置](#Configuration)
  * [nginx 配置](#nginx-config)
* [为什么叫 yuebing？](#Why-the-name-yuebing?)

## 灵感来源
去年我妈妈花了大量时间（和金钱！）来整理和数字化一批旧家庭录像。
其中一些非常古老，追溯到1940年代。非常美丽，经典的素材。

我们想私下与家人分享这些视频，但*不想让大科技公司知道*。
使用大型提供商的“免费”视频托管根本不在考虑之列。

我们的需求是：
* 自托管，但完全**免维护且易于运行**
* 支持现代视频格式流，包括自适应码率
* 视频能在任何设备播放，无论是桌面还是移动端
* 在高速带宽下，视频质量极佳；达到最佳效果
  * **即使网络状况差**，播放质量依然不错且*不卡顿不缓冲*
* 加密存储，因此可以有信心使用公共云存储解决方案
* 无状态服务器：将重要数据持久化到高可用存储
  * **我不想担心备份问题！**
  * *这是个额外加分项。事实证明市面上没有类似方案。Yuebing 有！*
* 先运行高性能实例转码所有视频，完成后拆除，长期运行更便宜的方案
  * 你可以用不到10美元/月运行 Yuebing；随着优化，未来成本还会更低

我花了几周时间调研现有方案。我开始大幅放宽需求，依然
找不到合适的。看了几个开源项目，不点名了，因为它们都有
多个明显缺陷。

于是我想，能有多难呢？把 S3 接到 ffmpeg，搭个还算现代的前端，就完事了，对吧？
... 好吧，呃，大部分工作花了几个月时间，但实在太有趣了，停不下来！  
希望你也会喜欢！

### <a style="text-decoration: none; color: inherit" href="https://open.spotify.com/track/0HEYFRBo4pBLLWjXsAZjod?si=riLTqMknTji7_X_4XzSkGQ&context=spotify%3Aalbum%3A20KGjm5xRROTqP0UY1EVRg">**让自托管视频站点变得超级简单！**</a>

## 功能  
* 将 S3（或 B2）视频桶转换为朋友和家人的私人视频站点！  
* 连接一个或多个源桶，提供原始媒体文件  
* Yuebing 自动将源视频转码为最新且最广泛支持的自适应码率流格式（DASH/mp4）  
* 所有数据均存储在目标桶中；你可以随时销毁服务器  
  * 适合初期在 CPU 优化实例上进行转码，然后切换到更便宜的实例实现全天候服务。  
  * 支持全加密存储（应用端加密，只有你拥有密钥）  
  * 源数据始终只读，绝不更改源内容  
  * 自动及手动扫描新媒体文件  
* 你想要多私密或多公开？Yuebing 支持：  
  * 完全私密：匿名用户看不到任何媒体，只有获批邮箱可创建账户  
  * 半私密：匿名用户看不到媒体，但任何人都可以创建用户账户  
  * 限制注册的公开：所有人可见媒体，但只有获批邮箱可创建账户  
  * 完全公开：所有人可见媒体，任何人都可以创建用户账户  
* 完全国际化！所有用户可见文本（及其他本地化相关内容）均来自本地化资源  
  * [帮助社区，把 Yuebing 翻译成更多语言！](https://github.com/cobbzilla/yuebing/blob/master/docs/localize.md)  
* 功能齐全的管理控制台  
* 通过关键词或标签云搜索视频  
* <a href="https://www.patreon.com/cobbzilla">**有你的支持即将推出**</a>：  
  * 支持更多媒体类型（音频、图片等）  
  * 用户上传媒体  
  * 点赞、分享及推送通知  
  * 新“源类型”：另一个 Yuebing 实例！  
    * 友好实例间的联合：统一搜索、用户账户等  

## 匿名用户功能（若站点配置允许匿名访问）  
* 浏览媒体  
* 观看媒体！  
* 创建账户（若站点配置允许注册）  

## 登录用户功能  
* 浏览媒体  
* 观看媒体！  
* 添加评论，编辑评论，删除评论！

* 邀请朋友
* 编辑账户信息
* 删除账户，删除属于你的所有内容，包括你所有的评论

## 管理员用户功能
* 编辑媒体元数据，查看缩略图，改变选定的缩略图
* 查看媒体转换队列和作业状态
* 启动新的扫描和源媒体索引

## 服务器/后端功能
* 适合瞬态，容器内不存储任何持久/重要数据。
  * 所有耐久数据保存在目标桶中；本质上，我们使用 S3 作为数据库
* 自动定期扫描源桶以查找新媒体
* 添加和更改媒体元数据；编辑内容存储在目标桶中，源媒体永远不会被修改
* 可配置输出配置文件。默认是带有多个子配置文件的 DASH-mp4
* 用户账户信息也存储在目标桶中，可选择加密
  * 如果加密密钥更改，管理员可以通过网页管理控制台将用户迁移到新密钥

## 安装
你可以通过 docker、npm 或直接从源码安装并运行 `yuebing`。

### Docker
如果你有 docker，可以快速开始使用 Yuebing：

    docker run -it cobbzilla/yuebing

### npm 包
    # 使用 npm 全局安装
    npm i -g yuebing

    # 使用 yarn 全局安装
    yarn global add yuebing

    # 现在 'yuebing' 命令应该在你的 PATH 中
    yuebing

### 从源码
从源码运行，你需要 nodejs v16+ 和 yarn

    # 克隆源码并安装依赖
    git clone https://github.com/cobbzilla/yuebing.git
    cd yuebing
    yarn install

    # 使用 git 仓库中的 'yuebing' 命令
    ./yuebing

    # 或者，因为你有源码，可以运行任何 `yarn` 脚本
    yarn docker-run-dev    # 构建和启动最快，开发用 docker 镜像
    yarn docker-run        # 运行时更快，生产用 docker 镜像
    yarn dev               # 在本地开发模式下运行 yuebing
    yarn build             # 本地构建 yuebing 生产版本
    yarn start             # 本地启动 yuebing 生产模式

详情请参阅 [开发者文档](https://github.com/cobbzilla/yuebing/blob/master/docs/developer.md)

## 配置
要玩转 Yuebing，可以不做任何配置直接启动。
运行 `yuebing`，启动时会提示你输入最小配置。

如果计划长时间运行 Yuebing，请参阅 [配置文档](https://github.com/cobbzilla/yuebing/blob/master/docs/config.md) 
了解更多设置方法。

### nginx 配置
Yuebing 是一个 Nuxt 应用，期望你在它前面放置 nginx（或其他 Web 服务器）
来处理 SSL、限速等功能（如果需要）。

如果使用 nginx，这里有一个 [示例配置](https://github.com/cobbzilla/yuebing/blob/master/docs/sample-yuebing-nginx.conf) 可供使用。

## 为什么叫 yuebing？
[乌龙兔](https://en.wikipedia.org/wiki/Oolong_(rabbit)) 是一个可爱且著名的
[早期网络表情](https://duckduckgo.com/?q=oolong+rabbit&ia=images&iax=images)。乌龙于 2003 年去世，
那时距离某个极其流行的视频服务诞生还早两年！

乌龙的继任者名叫 Yuebing。Yuebing 没有乌龙那么出名，但这重要吗？
Yuebing 依然成功了。

或许更有趣的是，yuebing 的意思是 [月饼](https://en.wikipedia.org/wiki/Mooncake)
（中文：[月饼](https://zh.wikipedia.org/wiki/%E6%9C%88%E9%A5%BC)，
日文：[月餅](https://ja.wikipedia.org/wiki/%E6%9C%88%E9%A4%85)）；月饼非常美味，可以在
各种风味和风格。享受一种历久弥新的地方风味，或尝试当代面包师探索美味未知领域的异国蛋糕！确实有适合每个人的月饼！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-14

---