# cmyflix
*一个用C语言实现的Netflix克隆！*

cmyflix 也是我最初的 ![Myflix](https://github.com/farfalleflickan/Myflix/) 的完全重写版本，使用 C 语言编写，因此速度比原版快约30倍，同时几乎保留了所有功能。

cmyflix 试图成为一个相对简单轻量的“DIY Netflix”，类似于 Plex、streama 或 Emby，适用于您的 NAS，特别针对 Raspberry Pi/Odroid 等生态系统。它并非**旨在**或**设计为**华丽（如果您有硬件并且想要大量功能，可以选择其他解决方案 :)），而是实现了基本的美观、快速且可用的最低要求。该程序创建存储文件位置和元数据的 JSON 数据库，这些数据库随后被用来创建可以由任何 Web 服务器提供的静态网页！

非常感谢以下库：![cwalk](https://github.com/likle/cwalk)、![cjson](https://github.com/DaveGamble/cJSON)。  
如果您想为您的 cmyflix 文件设置密码保护，您可以看看![这个](https://github.com/farfalleflickan/JSONlogin)！

喜欢我的作品吗？欢迎捐赠 :)  
[<img src="https://raw.githubusercontent.com/andreostrovsky/donate-with-paypal/master/dark.svg" alt="donation" width="150"/>](https://www.paypal.com/donate?hosted_button_id=YEAQ4WGKJKYQQ)

# 截图：  
电视剧页面  
![TV shows](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/ec53e53f252f908bc8bac7f8c4486790.jpg)   

电视剧季/集模态窗口  
![TV show episodes](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/fb31129a22d81b732ce88f02cae27fea.jpg)  

电视剧集播放器  
![TV show episode player](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/102b3df4924efeae7476d6ceee79bec9.png)

电影页面  
![Movies](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/d4271907a9af78d8dd84f3941ca1e56a.jpg)  

电影播放器  
![Movies player](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/2eb41c935d1c11e19adb66466bcdf97e.png)

# 如何编译：  
只需运行 make 即可编译，所需库（在 Ubuntu 中）为 `libbsd-dev libcjson-dev libcurl4-openssl-dev`。

# 如何安装：  
可以通过 make install 从源码安装，或使用发布标签中的预编译包。

注意，预编译的 `deb` 文件是使用默认的 `libcurl4-openssl-dev` 后端构建的。

# 运行要求：  
cmyflix 依赖 libcjson(>=1.7.15)、libcurl(>=7.68)、imagemagick、ffmpeg 以及 TMDB API 密钥。请注意，由于使用了 HTML5 及其支持的格式，cmyflix 会搜索 `mp4`、`mkv`、`ogv` 和 `webm` 文件。


# 配置与使用：
首先，cmyflix 会优先在与二进制文件相同的文件夹中查找 `cmyflix.cfg`，然后是在 `$HOME/.config/cmyflix/`，最后是在 `/etc/cmyflix/`。文件夹 `html` 及其内容也遵循相同规则。

更多选项和信息，请查看配置文件或使用 `--help` 参数调用帮助菜单。

# 文件夹结构要求
cmyflix 对文件夹结构有一定要求，期望所有内容都在有序的文件夹中。
对于电视剧，期望每个剧集在自己的文件夹内，每个季节有一个子文件夹（还有一个 “Season.Extras” 用于其他内容）。例如：`/path/to/files/Name.of.TV.show/Season.1/Name.Of.TV.show.S01E01.mp4`。
对于电影，理想情况下每部电影在自己的子文件夹中，例如：`/path/to/files/Name.of.Movie/Name.Of.Movie.mp4`。注意技术上多个电影可以在同一个子文件夹中，例如 `/path/to/files/Movies/Star.Wars/Revenge.of.The.Sith.mp4` 和 `/path/to/files/Movies/Star.Wars/Empire.Strikes.Back.mp4`。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---