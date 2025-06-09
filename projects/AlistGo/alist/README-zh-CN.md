<div align="center">
  <a href="https://alist.nn.ci"><img width="100px" alt="logo" src="https://cdn.jsdelivr.net/gh/alist-org/logo@main/logo.svg"/></a>
  <p><em>🗂️一个支持多种存储的文件列表程序，由 Gin 和 Solidjs 驱动。</em></p>
<div>
  <a href="https://goreportcard.com/report/github.com/alist-org/alist/v3">
    <img src="https://goreportcard.com/badge/github.com/alist-org/alist/v3" alt="latest version" />
  </a>
  <a href="https://github.com/alist-org/alist/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/Xhofe/alist" alt="License" />
  </a>
  <a href="https://github.com/alist-org/alist/actions?query=workflow%3ABuild">
    <img src="https://img.shields.io/github/actions/workflow/status/Xhofe/alist/build.yml?branch=main" alt="Build status" />
  </a>
  <a href="https://github.com/alist-org/alist/releases">
    <img src="https://img.shields.io/github/release/Xhofe/alist" alt="latest version" />
  </a>
  <a title="Crowdin" target="_blank" href="https://crwd.in/alist">
    <img src="https://badges.crowdin.net/alist/localized.svg">
  </a>
</div>
<div>
  <a href="https://github.com/alist-org/alist/discussions">
    <img src="https://img.shields.io/github/discussions/Xhofe/alist?color=%23ED8936" alt="discussions" />
  </a>
  <a href="https://discord.gg/F4ymsH4xv2">
    <img src="https://img.shields.io/discord/1018870125102895134?logo=discord" alt="discussions" />
  </a>
  <a href="https://github.com/alist-org/alist/releases">
    <img src="https://img.shields.io/github/downloads/Xhofe/alist/total?color=%239F7AEA&logo=github" alt="Downloads" />
  </a>
  <a href="https://hub.docker.com/r/xhofe/alist">
    <img src="https://img.shields.io/docker/pulls/xhofe/alist?color=%2348BB78&logo=docker&label=pulls" alt="Downloads" />
  </a>
  <a href="https://alist.nn.ci/guide/sponsor.html">
    <img src="https://img.shields.io/badge/%24-sponsor-F87171.svg" alt="sponsor" />
  </a>
</div>
</div>

---

English | [中文](./README_cn.md) | [日本語](./README_ja.md) | [Contributing](./CONTRIBUTING.md) | [CODE_OF_CONDUCT](./CODE_OF_CONDUCT.md)

## 功能特性

- [x] 多存储支持
    - [x] 本地存储
    - [x] [阿里云盘](https://www.alipan.com/)
    - [x] OneDrive / Sharepoint ([全球](https://www.office.com/), [中国](https://portal.partner.microsoftonline.cn),de,us)
    - [x] [天翼云盘](https://cloud.189.cn) (个人、家庭)
    - [x] [GoogleDrive](https://drive.google.com/)
    - [x] [123云盘](https://www.123pan.com/)
    - [x] FTP / SFTP
    - [x] [PikPak](https://www.mypikpak.com/)
    - [x] [S3](https://aws.amazon.com/s3/)
    - [x] [Seafile](https://seafile.com/)
    - [x] [又拍云存储服务](https://www.upyun.com/products/file-storage)
    - [x] WebDav（支持无需 API 的 OneDrive/SharePoint）
    - [x] Teambition（[中国](https://www.teambition.com/ )、[国际](https://us.teambition.com/ )）
    - [x] [Mediatrack](https://www.mediatrack.cn/)
    - [x] [139云盘](https://yun.139.com/)（个人、家庭、群组）
    - [x] [YandexDisk](https://disk.yandex.com/)
    - [x] [百度网盘](http://pan.baidu.com/)
    - [x] [Terabox](https://www.terabox.com/main)
    - [x] [UC 网盘](https://drive.uc.cn)
    - [x] [夸克网盘](https://pan.quark.cn)
    - [x] [迅雷云盘](https://pan.xunlei.com)
    - [x] [蓝奏云](https://www.lanzou.com/)
    - [x] [ILanzou](https://www.ilanzou.com/)
    - [x] [阿里云盘分享](https://www.alipan.com/)
    - [x] [Google 相册](https://photos.google.com/)
    - [x] [Mega.nz](https://mega.nz)
    - [x] [百度相册](https://photo.baidu.com/)
    - [x] SMB
    - [x] [115](https://115.com/)
    - [X] Cloudreve
    - [x] [Dropbox](https://www.dropbox.com/)
    - [x] [飞机盘](https://www.feijipan.com/)
    - [x] [多吉云](https://www.dogecloud.com/product/oss)
    - [x] [Azure Blob 存储](https://azure.microsoft.com/products/storage/blobs)
- [x] 部署简单，开箱即用
- [x] 文件预览（PDF、markdown、代码、纯文本等）
- [x] 图库模式下的图片预览
- [x] 视频音频预览，支持歌词和字幕
- [x] Office 文档预览（docx、pptx、xlsx 等）
- [x] `README.md` 预览渲染
- [x] 文件永久链接复制及直接下载
- [x] 暗黑模式
- [x] 多语言（I18n）
- [x] 路由保护（密码保护及认证）
- [x] WebDav（详情见 https://alist.nn.ci/guide/webdav.html）
- [x] [Docker 部署](https://hub.docker.com/r/xhofe/alist)
- [x] Cloudflare Workers 代理
- [x] 文件/文件夹打包下载
- [x] 网页上传（可允许访客上传）、删除、创建文件夹、重命名、移动和复制
- [x] 离线下载
- [x] 跨存储文件复制
- [x] 单线程下载/串流支持多线程加速

## 文档

<https://alistgo.com/>

## 演示

<https://al.nn.ci>

## 讨论

如有一般性问题，请前往我们的[讨论区](https://github.com/alist-org/alist/discussions)，**issues 仅用于提交 bug 报告和新功能请求。**

## 赞助

AList 是一款开源软件，如果您喜欢本项目并希望我能继续维护，请考虑赞助或一次性捐赠！感谢所有的喜欢和支持：
https://alist.nn.ci/guide/sponsor.html

### 特别赞助

- [VidHub](https://apps.apple.com/app/apple-store/id1659622164?pt=118612019&ct=alist&mt=8) - 一款优雅的苹果生态云视频播放器，支持 iPhone、iPad、Mac、Apple TV。
- [亚洲云](https://www.asiayun.com/aff/QQCOOQKZ) - 高防服务器|服务器租用|福州高防|广东电信|香港服务器|美国服务器|海外服务器 - 国内靠谱的企业级云计算服务提供商（赞助中文 API 服务器）
- [找资源](http://zhaoziyuan2.cc/) - 阿里云盘资源搜索引擎

## 贡献者

感谢以下优秀的贡献者：

[![Contributors](http://contrib.nn.ci/api?repo=alist-org/alist&repo=alist-org/alist-web&repo=alist-org/docs)](https://github.com/alist-org/alist/graphs/contributors)

## 许可证

`AList` 是基于 AGPL-3.0 许可证的开源软件。

## 免责声明
- 本程序为免费开源项目，旨在实现网盘文件共享，便于下载和学习 Golang。使用时请遵守相关法律法规，切勿滥用；
- 本程序通过调用官方 sdk/接口实现，并未破坏官方接口行为；
- 本程序仅做 302 跳转/流量转发，不拦截、不存储、不篡改任何用户数据；
- 使用本程序前，请知悉并自行承担相关风险，包括但不限于账号封禁、限速等，与本程序无关；
- 如有侵权，请通过[邮件](mailto:i@nn.ci)联系我，将及时处理。

---

> [@GitHub](https://github.com/alist-org) · [@TelegramGroup](https://t.me/alist_chat) · [@Discord](https://discord.gg/F4ymsH4xv2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---