# yt-dlp-rajiko

改进的 [radiko.jp](https://radiko.jp) 提取插件，适用于 yt-dlp（快速且免区域限制）

<p>yt-dlp-rajiko 让你无需 VPN 即可使用 <a href="https://github.com/yt-dlp/yt-dlp">yt-dlp</a> 从 <a href="https://radiko.jp">radiko.jp</a> 下载日本广播节目。
下载速度快，适用于任何参与的电台*，无论你身处世界何地。<br>
<small>*除 NHK 外，但他们有 <a href="https://www.nhk.or.jp/radio/">自己的官网</a>，yt-dlp 正式版支持</small></p>


<p>仅供个人存档使用，非商业用途。如果可能，请订阅 radiko Premium。<br>
<small>（这是自由软件，所以我只是礼貌地请求，并非强制要求。但你应该订阅，这样 radiko 才能继续存在）<br>
（另外，如果你购买 timefree30 计划，可以配合 yt-dlp 使用 :P）
</small></p>

### [日本語  🇯🇵](https://427738.xyz/yt-dlp-rajiko/index.ja.html)

## 安装

[下载插件包](https://427738.xyz/yt-dlp-rajiko/dl/yt_dlp_rajiko-latest.bundle.zip) 或使用 `pip install yt-dlp-rajiko`

<p>需要 yt-dlp 版本 2025.02.19 或更新版本。</p>

<p>如果你通过 pip 安装了 yt-dlp，请使用上面的 pip 命令。
如果你通过 <code>pipx</code> 安装了 yt-dlp，
请使用 <code>pipx inject yt-dlp yt-dlp-rajiko</code> 将插件安装到 yt-dlp 的环境中。</p>

<p>如果你通过 .exe/二进制文件或其他方法安装，
请下载插件包并放置在以下位置之一：</p>

<ul>
	<li><code>%appdata%\yt-dlp\plugins\</code> （Windows 系统）</li>
	<li><code>~/.config/yt-dlp/plugins/</code> （Linux 和 Mac 系统）</li>
	<li>与 <code>yt-dlp.exe</code> 同目录下的 <code>yt-dlp-plugins</code> 文件夹 <a href="https://427738.xyz/yt-dlp-rajiko/i/installation-pluginsfolder2.png">(如图)</a><br>
	<li>以及 <a href="https://github.com/yt-dlp/yt-dlp#installing-plugins">yt-dlp 文档</a> 中列出的其他位置。</li>
</ul>

<p>如果这些文件夹不存在，你需要手动创建。<br>
<b>无需解压 zip 文件。</b></p>


<p>您可以通过运行 <code>yt-dlp -v</code> 并查看 <code>[debug] Extractor Plugins:</code> 或 <code>[debug] Plugin directories:</code> 行来检查是否正确安装。<a href="https://427738.xyz/yt-dlp-rajiko/i/plugincheck.png">（如图）</a>
</p>

有关 yt-dlp 插件的更多信息，请参阅 [yt-dlp 的文档](https://github.com/yt-dlp/yt-dlp#plugins)。

## 更多信息

[请访问网站获取更多信息](https://427738.xyz/yt-dlp-rajiko/)（使用方法、联系方式等）

[也有日语翻译](https://427738.xyz/yt-dlp-rajiko/index.ja.html)

## 关于此代码库

这里仅存放源代码和错误跟踪器。大部分信息都在网站上。

通常您应使用发行版本。
`master` 分支通常可用，但应视为实验性，可能存在错误


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---