<div align="center">
  <a href="https://alist.nn.ci"><img width="100px" alt="logo" src="https://cdn.jsdelivr.net/gh/alist-org/logo@main/logo.svg"/></a>
  <p><em>🗂️一個支援多儲存空間的檔案列表程式，由 Gin 和 Solidjs 驅動。</em></p>
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

## 功能

- [x] 多儲存空間支援
    - [x] 本地儲存
    - [x] [阿里雲盤](https://www.alipan.com/)
    - [x] OneDrive / Sharepoint ([全球](https://www.office.com/), [中國](https://portal.partner.microsoftonline.cn),de,us)
    - [x] [天翼雲盤](https://cloud.189.cn)（個人、家庭）
    - [x] [Google 雲端硬碟](https://drive.google.com/)
    - [x] [123雲盤](https://www.123pan.com/)
    - [x] FTP / SFTP
    - [x] [PikPak](https://www.mypikpak.com/)
    - [x] [S3](https://aws.amazon.com/s3/)
    - [x] [Seafile](https://seafile.com/)
    - [x] [又拍雲儲存服務](https://www.upyun.com/products/file-storage)
    - [x] WebDav（支援無 API 的 OneDrive/SharePoint）
    - [x] Teambition（[中國](https://www.teambition.com/)，[國際](https://us.teambition.com/)）
    - [x] [Mediatrack](https://www.mediatrack.cn/)
    - [x] [139雲](https://yun.139.com/)（個人、家庭、群組）
    - [x] [YandexDisk](https://disk.yandex.com/)
    - [x] [百度網盤](http://pan.baidu.com/)
    - [x] [Terabox](https://www.terabox.com/main)
    - [x] [UC](https://drive.uc.cn)
    - [x] [夸克雲盤](https://pan.quark.cn)
    - [x] [迅雷雲盤](https://pan.xunlei.com)
    - [x] [藍奏雲](https://www.lanzou.com/)
    - [x] [i藍奏雲](https://www.ilanzou.com/)
    - [x] [阿里雲盤分享](https://www.alipan.com/)
    - [x] [Google 相簿](https://photos.google.com/)
    - [x] [Mega.nz](https://mega.nz)
    - [x] [百度相冊](https://photo.baidu.com/)
    - [x] SMB
    - [x] [115](https://115.com/)
    - [X] Cloudreve
    - [x] [Dropbox](https://www.dropbox.com/)
    - [x] [飛機雲盤](https://www.feijipan.com/)
    - [x] [多吉雲](https://www.dogecloud.com/product/oss)
    - [x] [Azure Blob Storage](https://azure.microsoft.com/products/storage/blobs)
- [x] 易於部署，開箱即用
- [x] 檔案預覽（PDF、markdown、程式碼、純文字等）
- [x] 圖片畫廊模式預覽
- [x] 影片和音訊預覽，支援歌詞與字幕
- [x] Office 文件預覽（docx、pptx、xlsx 等）
- [x] `README.md` 預覽渲染
- [x] 檔案永久連結複製與直接下載
- [x] 暗黑模式
- [x] I18n 多語言
- [x] 保護路徑（密碼保護與身份驗證）
- [x] WebDav（詳見 https://alist.nn.ci/guide/webdav.html）
- [x] [Docker 部署](https://hub.docker.com/r/xhofe/alist)
- [x] Cloudflare Workers 代理
- [x] 檔案/資料夾打包下載
- [x] Web 上傳（可允許訪客上傳）、刪除、建立資料夾、重新命名、移動與複製
- [x] 離線下載
- [x] 跨儲存空間檔案複製
- [x] 單線程下載/串流加速多線程下載

## 文件

<https://alistgo.com/>

## 演示

<https://al.nn.ci>

## 討論

如有一般性問題請前往我們的[討論區](https://github.com/alist-org/alist/discussions)，**Issues 僅用於錯誤回報與功能請求。**

## 贊助

AList 是一款開源軟體，如果你喜歡這個專案並希望我能持續維護，請考慮贊助我或給予一次性捐款！感謝所有的支持與厚愛：
https://alist.nn.ci/guide/sponsor.html

### 特別贊助

- [VidHub](https://apps.apple.com/app/apple-store/id1659622164?pt=118612019&ct=alist&mt=8) - 一款優雅的蘋果生態雲端影片播放器。支援 iPhone、iPad、Mac 及 Apple TV。
- [亞洲雲](https://www.asiayun.com/aff/QQCOOQKZ) - 高防伺服器｜伺服器租用｜福州高防｜廣東電信｜香港伺服器｜美國伺服器｜海外伺服器 - 國內可靠的企業級雲計算服務提供商（贊助中國 API 伺服器）
- [找資源](http://zhaoziyuan2.cc/) - 阿里雲盤資源搜尋引擎

## 貢獻者

感謝這些出色的貢獻者：

[![Contributors](http://contrib.nn.ci/api?repo=alist-org/alist&repo=alist-org/alist-web&repo=alist-org/docs)](https://github.com/alist-org/alist/graphs/contributors)

## 授權

`AList` 是在 AGPL-3.0 協議下開源的軟體。

## 免責聲明
- 本程式為自由開源項目，用於網盤檔案分享，便於下載及學習 Golang，請在使用時遵守相關法律法規，不得濫用；
- 本程式通過調用官方 sdk/介面實現，未破壞官方介面行為；
- 本程式僅做 302 跳轉/流量轉發，不攔截、不存儲、不篡改任何使用者資料；
- 使用本程式前，應充分瞭解並承擔相應風險，包括但不限於賬號封禁、下載限速等，均與本程式無關；
- 如有侵權，請通過[email](mailto:i@nn.ci)聯繫我，將及時處理。

---

> [@GitHub](https://github.com/alist-org) · [@TelegramGroup](https://t.me/alist_chat) · [@Discord](https://discord.gg/F4ymsH4xv2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---