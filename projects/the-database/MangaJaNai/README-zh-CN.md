# MangaJaNai

[![Discord](https://img.shields.io/discord/1121653618173546546?label=Discord&logo=Discord&logoColor=white)](https://discord.gg/EeFfZUBvxj)

<a href="./mangajanaiv1demo.webp?raw=1"><img src="https://raw.githubusercontent.com/the-database/MangaJaNai/main/mangajanaiv1demo.webp"/></a>
<p align="center"><sup>(点击图片放大)</sup></p>

## 概述

MangaJaNai 是一组用于漫画图像放大的模型。该模型主要针对高度大约在1200像素到2048像素范围内的日文或英文数字漫画图像进行优化放大。

加入 [**JaNai Discord 服务器**](https://discord.gg/EeFfZUBvxj) 获取最新消息，下载预发布和实验性模型，获得支持和提问，分享你的放大效果，或者反馈你的意见。日语也没问题。

## 使用说明

### 使用 MangaJaNaiConverterGui 放大

为了简单方便的使用体验，请使用 [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui) 利用 MangaJaNai 模型放大你的漫画图像。

## MangaJaNai 模型
虽然漫画制作时分辨率极高（10000像素以上）且实体书印刷质量优良，但官方数字漫画通常分辨率较低，且充满 JPEG 压缩和干涉条纹（莫尔纹）伪影。MangaJaNai 模型的目标是将低质量的黑白数字漫画放大，清理 JPEG 和干涉条纹伪影，生成更接近实体印刷版本的效果。

大多数漫画采用网点印刷，但部分数字版本质量极差，网点已经不可见。MangaJaNai 模型可能看起来好像生成了原图中不存在的网点，但在大多数情况下，模型正确还原了低质量源图中已经不可见的网点。为了保证网点大小和频率的正确生成，训练了多个 MangaJaNai 模型，每个模型针对不同的图像高度进行优化，这七种高度对应日本数字漫画中最常见的图像尺寸：1200p、1300p、1400p、1500p、1600p、1920p 和 2048p。[MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui) 会根据输入图像的分辨率自动选择最佳模型。

## IllustrationJaNai 模型
由于 MangaJaNai 模型仅适用于黑白漫画页，因此训练了补充的 IllustrationJaNai 模型，用于漫画中的彩色图像，如封面和彩页。这些模型训练用于去除常见图像伪影，如 JPEG 伪影和低分辨率印刷网点，同时也适合作为数字艺术的通用放大模型。[MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui) 会自动为彩色图像选择 IllustrationJaNai 模型。

## 相关项目

- [mpv-upscale-2x_animejanai](https://github.com/the-database/mpv-upscale-2x_animejanai)：使用 Real-ESRGAN 紧凑模型在 mpv 中实现实时动漫 4k 放大
- [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui)：用于 MangaJaNai 模型漫画放大的 Windows 图形界面
- [traiNNer-redux](https://github.com/the-database/traiNNer-redux)：训练放大模型的软件

## 致谢
- 感谢 [422415](https://github.com/422415) 在数据集准备及 V1 模型开发过程中提供的重要帮助和持续反馈
- 感谢 JaNai Discord 服务器成员协助提供漫画资源：
    - Alexandros
    - umzi
    - M7MedOo
    - Gnathonic
- JaNai Discord 服务器成员，持续提供测试版模型反馈：
    - junmittens
    - SOUNDSPHERE BEST GAME
    - marv
    - Big_herooooo
    - avc1657
    - risho
- [traiNNer-redux](https://github.com/joeyballentine/traiNNer-redux)
- [Dataset Destroyer](https://github.com/Kim2091/helpful-scripts/tree/main/Dataset%20Destroyer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---