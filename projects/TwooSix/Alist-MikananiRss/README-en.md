
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  Automatically fetch anime updates from <a href="https://mikanani.me/">Mikan Project</a> or other anime-related RSS feeds and offline download them to the corresponding cloud drive via Alist
</p>  
<p align="center">
  Combined with ChatGPT to analyze resource names and rename resources into a format that can be parsed by Emby.
</p>
</p>  

--- 

[User Guide](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## Features
- Automatically fetch anime updates and download them to the corresponding cloud drive
- Send update notifications via PushPlus, Telegram, and other channels
- Automatically rename to emby-recognizable formats, and also support custom remapping for automatically parsed results to make renaming more accurate

## Preparation
1. Please deploy Alist yourself according to the [Alist](https://github.com/alist-org/alist) project documentation (version must be >=3.42.0), and set up Aria2/qBittorrent for offline downloading
2. Register for a Mikan Project account, subscribe to anime, and obtain the subscription link

Note: Some adaptations have also been made for other RSS feeds; in theory, most feeds (related to anime) are supported. For unsupported RSS, feel free to submit an issue.

## How to Use
For Docker, source code operation, and more running methods, see the [User Guide](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)

Running via pip installation
1. Please make sure your Python version is above 3.11
2. Install via pip: `pip install alist-mikananirss`
3. Create a new `config.yaml` configuration file in the directory and fill in the configuration as follows (for a full-featured example, see [Configuration Instructions](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
   ```yaml
   common:
     interval_time: 300
   
   alist:
     base_url: https://example.com # 修改为你的alist访问地址
     token: alist-xxx # 修改为你的alist token；可在"管理员后台->设置->其他"中找到
     downloader: qBittorrent # 或者 aria2
     download_path: Onedrive/Anime # 修改为你的下载路径(Alist中的路径)

   mikan:
     subscribe_url:
       - https://mikanani.me/RSS/MyBangumi?token=xxx # 修改为你的蜜柑订阅地址
       # - https://mikanani.me/RSS/MyBangumi?token=xxx2 # 多条RSS订阅链接情况
   
     filters:
       - 非合集 # 程序暂不支持合集等形式的重命名，若使用重命名功能推荐使用此过滤器
   ```
4. Run the code: `python -m alist_mikananirss --config /path/to/config.yaml`  
5. Enjoy


## Renaming Effect Display
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---