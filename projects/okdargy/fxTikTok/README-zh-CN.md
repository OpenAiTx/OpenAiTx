# fxTikTok

只需使用 `s/i/n` 即可在 Discord 上嵌入 TikTok 视频和幻灯片

> [!注意]  
> 想在 fxTikTok 中看到某个功能，或想报告一个错误？请提交 issue！我非常期待您的反馈。

## 📸 截图

<details>
  <summary>点击此处预览 fxTikTok 的实际效果</summary>

| <img src="/.github/readme/compare.png" alt="视频预览" height="400px" /> |
| :--------------------------------------------------------------------------: |
|          比较 `tiktok.com` 与 `tnktok.com` 在 Discord 上的嵌入效果           |

| <img src="/.github/readme/slideshow.png" alt="幻灯片预览" /> |
| :-----------------------------------------------------------------: |
|                          幻灯片嵌入展示                           |

| <img src="/.github/readme/direct.png" alt="直接预览" height="400px" /> |
| :--------------------------------------------------------------------------: |
|                          直接支持图片/视频                          |

</details>

## 📖 使用方法

在 Discord 上使用 fxTikTok 很简单。发送你的 TikTok 链接后输入 `s/i/n`，即可修复丑陋且无响应的嵌入内容。

<details>
  <summary>👁️ 视觉学习者？点击这里查看 GIF 教程</summary>

  <img src="https://raw.githubusercontent.com/okdargy/fxTikTok/hono-rewrite/.github/readme/introduction.gif" alt="介绍 GIF" height="500px" style="border-radius:2%" />
</details>

### 这是如何工作的？

当你在 Discord 中发送 `s/i/n` 时，它会使用 [sed](https://www.gnu.org/software/sed/manual/sed.html) 格式修改你最近的一条消息。具体来说，它会将消息中第二个参数（`i`）的第一个出现替换为第三个参数（`n`）。

|     之前     |     之后      |
| :------------: | :------------: |
| t**i**ktok.com | t**n**ktok.com |

> [!TIP]
> 如果你运营一个 Discord 服务器，我强烈建议将 [FixTweetBot](https://github.com/Kyrela/FixTweetBot) 添加到你的服务器。它会自动修改链接，使用类似 fxTikTok 的嵌入修复器，并且高度可定制。

### 使用直接嵌入

不想让嵌入中出现那些统计信息，只想要视频或图片？只需将你的 URL 改成 `d.tnktok.com`

|         之前         |        之后         |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **d**.t**n**ktok.com |

> 或者，你也可以通过在 URL 查询中添加 `?isDirect=true` 来设置 `isDirect` 为 true

### “我看不到视频的标题！”

默认情况下，我们将描述放入 `og:description` 标签，但如果嵌入中有视频，Discord 会移除该标签。我们决定不把它放在顶部，避免像 [tfxktok.com](https://tfxktok.com) 那样让嵌入被标签过多的标签堆满。

不过，我们想给用户选项来添加它，以防它为视频带来额外的上下文。你可以将 URL 改成 `a.tnktok.com`，以在顶部添加描述。

|         之前         |        之后         |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **a**.t**n**ktok.com |

> 或者，你也可以通过在 URL 查询中添加 `?addDesc=true` 来设置 `addDesc` 为 true

### 切换到高质量

TikTok 支持 H.265/HEVC（高效视频编码），在相同文件大小下提供显著更好的质量，但兼容性较差。默认情况下，我们使用 H.264 质量，因为[许多用户报告 H.265 嵌入出现问题](https://github.com/okdargy/fxTikTok/issues/14)，但支持启用 H.265。

要启用高质量的 H.265 播放，请添加 `?hq=true` 或使用 `hq.tnktok.com`：
| 之前 | 之后 |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **hq**.t**n**ktok.com |

### 组合模式

你可以通过使用特定的主机名或 URL 查询参数来组合不同的模式。例如，如果你想启用 H.265 并且同时看到字幕，可以使用 `hq.a.tnktok.com` 或在 URL 中添加 `?hq=true&addDesc=true`。

> 你不能同时使用直接模式和字幕模式，因为它们相互矛盾。

### 为什么使用 tnktok.com？

我们满足成为最佳 TikTok 嵌入服务之一的所有条件，拥有许多其他服务没有的功能。以下是我们的服务 tnktok.com 与其他 TikTok 嵌入服务及 TikTok 默认嵌入的对比表。

|                                        | [fxTikTok](https://www.tnktok.com) | 默认 TikTok    | [kkScript](https://kktiktok.com/) | [tfxktok.com](https://tfxktok.com) | [EmbedEZ](https://tiktokez.com) |
| -------------------------------------- | ---------------------------------- | -------------- | --------------------------------- | ---------------------------------- | ------------------------------- |
| 嵌入可播放视频                        | ☑️                                 | ☑️             | ☑️                                | ☑️                                 | ☑️                              |
| 嵌入多图幻灯片                       | ☑️                                 | ❌             | ❌                                | ☑️                                 | ☑️                              |
| 开源                                  | ☑️                                 | ❌             | ❔                                | ❌                                 | ❌                              |
| 支持直接嵌入                         | ☑️                                 | ❌             | ❔                                | ❌                                 | ❌                              |
| 显示点赞、分享、评论                  | ☑️                                 | ☑️             | ❌                                | ☑️                                 | ☑️                              |
| 去除重定向追踪                       | ☑️                                 | ❌             | ❌                                | ☑️                                 | ☑️                              |
| 支持多大陆短链接                     | ☑️                                 | ☑️             | ❌                                | ❌                                 | ☑️                              |
| 支持 h265/高清                       | ☑️                                 | ❌             | ❌                                | ❌                                 | ❌                              |
| 最近提交                             | [![][tnk]][tnkc]                   | N/A            | [![][kkt]][kktc]                  | N/A                                | N/A                             |

[tnk]: https://img.shields.io/github/last-commit/okdargy/fxTikTok?label  
[tnkc]: https://github.com/okdargy/fxTikTok/commits  
[kkt]: https://img.shields.io/github/last-commit/kkscript/kk?label  
[kktc]: https://github.com/kkscript/kk/commits  

以下嵌入服务未列出，因为它们已不再维护或根本无法使用：

- [tiktxk.com](https://tiktxk.com)  
- [vxtiktok.com](https://vxtiktok.com)（重定向到 kkScript）  

## 💻 自托管

默认情况下，设置新的 fxTikTok 实例时，默认的卸载服务器是 `offload.tnktok.com`。  
要设置你自己的服务器，只需编译并运行 [`offload.ts`](/src/offload.ts)，它将启动在 **8787** 端口。

```bash
# Install all necessary dependencies
pnpm install
# Start your server
bun run src/offload.ts
```
> 我建议将此配置为您自己的域名，结合像 [nginx](https://nginx.org) 这样的反向代理，并在 Cloudflare 之上启用保护。

接下来，点击下面的按钮部署您的 Worker 并按照说明操作。

[![Deploy to Cloudflare Workers](https://deploy.workers.cloudflare.com/button)](https://deploy.workers.cloudflare.com/?url=https://github.com/okdargy/fxtiktok)

完成后，进入“设置”，在“变量和秘密”下更改您的卸载服务器：

<img src="https://raw.githubusercontent.com/okdargy/fxTikTok/hono-rewrite/.github/readme/settings.png" alt="设置页面，显示点击位置以更改您的卸载服务器" height="300px" style="border-radius:2%" />

#### 🎉 就这样！您现在拥有自己的 fxTikTok 实例，可以随时随地使用。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---