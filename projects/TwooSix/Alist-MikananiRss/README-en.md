<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  Automatically fetch anime update feeds from <a href="https://mikanani.me/">Mikan Project</a> or other anime-related RSS subscription sources and offline download them to the corresponding cloud drives via Alist.
</p>  
<p align="center">
  Combined with ChatGPT to analyze resource names and rename the resources into Emby-parsable formats.
</p>  

--- 

[Usage Documentation](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## Features
- Automatically fetch anime updates and download them to the corresponding cloud drives
- Send update notifications via channels such as PushPlus, Telegram, etc.
- Automatically rename into emby-recognizable formats, while supporting custom remapping of automatically parsed results, making renaming results more accurate

## Preparations 
1. Please deploy Alist (version >=3.42.0) by referring to the [Alist](https://github.com/alist-org/alist) project documentation, and set up Aria2/qBittorrent offline downloads
2. Register a Mikan Project account, subscribe to anime, and obtain the subscription link

Additionally: Certain adaptations have been made for other RSS subscription sources; theoretically supports most subscription sources (anime-related). For unsupported RSS, issues are welcome.

## How to Use
More running methods such as Docker and source code execution can be found in the [Usage Documentation](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) 

Install and run with pip
1. Please ensure your Python version is above 3.11
2. Install via pip: `pip install alist-mikananirss`
3. Create a `config.yaml` configuration file in the directory and fill in the configuration file as follows (a detailed example of full functionality can be found in the [Configuration Instructions](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---