> 本仓库仅支持 v1 版本，适用于哔哩哔哩和 YouTube！

# 🤖 BibiGPT：音视频内容一键 AI 总结与学习内容对话 [https://bibigpt.co](https://bibigpt.co)

🎉 使用我们的 AI 驱动视频总结工具，轻松总结 YouTube 和哔哩哔哩视频内容。它同样适用于播客、推特、会议、讲座、抖音视频等多种场景。通过 ChatGPT，发现更聪明的学习方式，成为你最好的 AI 学习伴侣！（原 BiliGPT）“省流神器 & 课代表”。

备用地址：https://b.jimmylv.cn  
浏览器插件：https://bibigpt.co/extension

---

## 🤖 BibiGPT · AI 音视频内容一键总结 & 对话 [https://bibigpt.co](https://bibigpt.co)

🎉 ChatGPT AI 一键总结音视频，轻松学习哔哩哔哩丨YouTube丨本地视频丨本地音频丨播客丨小红书丨抖音丨会议丨讲座丨网页等任意内容。BibiGPT 致力于成为最佳 AI 学习助理，支持免费试用！（原 BiliGPT 省流神器 & AI 课代表）（支持 iOS 快捷指令 & 微信服务号）。

备用地址：https://b.jimmylv.cn  
浏览器插件：https://bibigpt.co/extension

---

🎬 本项目使用 AI 为您总结 YouTube/Bilibili/Twitter/TikTok/播客/讲座/会议/... 视频或音频内容。

🤯 灵感来源于 [Nutlope/news-summarizer](https://github.com/Nutlope/news-summarizer) & [zhengbangbo/chat-simplifier](https://github.com/zhengbangbo/chat-simplifier/) & [lxfater/BilibiliSummary](https://github.com/lxfater/BilibiliSummary)

[![BibiGPT音视频总结神器](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./public/BibiGPT.gif)](https://twitter.com/Jimmy_JingLv/status/1630137750572728320?s=20)

🚀 首次发布：[【BibiGPT】AI 自动总结 B 站视频内容，GPT-3 智能提取并总结字幕](https://www.bilibili.com/video/BV1fX4y1Q7Ux/?vd_source=dd5a650b0ad84edd0d54bb18196ecb86)

## 工作原理

本项目使用 [OpenAI ChatGPT API](https://openai.com/api/)（具体为 gpt-3.5-turbo）和 [Vercel Edge functions](https://vercel.com/features/edge-functions) 的流式处理，结合 [Upstash](https://console.upstash.com/) 提供的 Redis 缓存和限流功能。它抓取哔哩哔哩视频内容，发送提示给 GPT-3 API 通过 Vercel Edge 函数进行总结，然后将响应流式返回给应用。

## 节省成本

此类项目可能成本较高，若您想制作自己的版本并公开分享，建议以下三点：

- [x] 1. 实现限流，防止滥用网站  
- [x] 2. 实现缓存，避免高成本的 AI 重复生成  
- [x] 3. 在 `summarize` edge 函数中使用 `text-curie-001` 替代 `text-dacinci-003`

## 本地运行

克隆仓库后，访问 [OpenAI](https://beta.openai.com/account/api-keys) 创建账户，并将你的 API 密钥放入名为 `.env` 的文件中。

然后，在命令行运行应用程序，应用将可通过 `http://localhost:3000` 访问。

[具体运行步骤详见此文档 - 中文版](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./deploy-ch.md)

```bash
npm run dev
```

## 部署

使用 [Vercel](https://vercel.com?utm_source=github&utm_medium=readme&utm_campaign=vercel-examples) 部署示例

按照 `./example.env` 文件设置环境变量。

## 支持 Docker

https://github.com/JimmyLv/BibiGPT/pull/133

```shell
# make sure setup .env file firstly
docker compose up -d
```

## Support -> Contact Me

![](https://raw.githubusercontent.com/JimmyLv/BibiGPT-v1/main/./public/wechat.jpg)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=JimmyLv/BibiGPT&type=Date)](https://star-history.com/#JimmyLv/BibiGPT&Date)

## Contributors

This project exists thanks to all the people who contribute.

 <a href="https://github.com/JimmyLv/BibiGPT/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=JimmyLv/BibiGPT" />
 </a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-13

---