
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  Automatisch anime-updates ophalen van <a href="https://mikanani.me/">Mikan Project</a> of andere anime-gerelateerde RSS feeds en via Alist offline downloaden naar de betreffende cloudopslag
</p>  
<p align="center">
  In combinatie met ChatGPT wordt de bestandsnaam geanalyseerd en hernoemd naar een formaat dat door Emby kan worden herkend.
</p>
</p>  

--- 

[Gebruikershandleiding](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## Functionaliteit
- Automatisch bijwerken van anime en downloaden naar de juiste cloudopslag
- Verstuur update-meldingen via PushPlus, Telegram en andere kanalen
- Automatisch hernoemen naar een door emby herkenbaar formaat, tevens ondersteuning voor het aanpassen van automatisch geparseerde resultaten voor een nog nauwkeuriger hernoemresultaat

## Voorbereiding 
1. Raadpleeg de documentatie van het [Alist](https://github.com/alist-org/alist) project om Alist te implementeren (versie moet >=3.42.0 zijn) en stel Aria2/qBittorrent offline download in
2. Registreer zelf een Mikan Project-account, abonneer je op anime, en verkrijg de abonnementslink

Bijlage: Er is enige aanpassing gedaan voor andere RSS-feeds, waardoor in theorie de meeste (anime-gerelateerde) feeds worden ondersteund. Voor RSS-feeds die niet ondersteund worden, dien gerust een issue in.

## Hoe te gebruiken
Zie de [gebruiksaanwijzing](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) voor meer manieren om te draaien met Docker, broncode, etc.

Installeren en uitvoeren met pip
1. Zorg ervoor dat je python versie 3.11 of hoger gebruikt
2. Installeer met pip: `pip install alist-mikananirss`
3. Maak een nieuw `config.yaml` configuratiebestand aan in de map en vul het als volgt in (voor een volledige uitleg van alle functies, zie [Configuratie-instructies](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
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
4. Voer de code uit: `python -m alist_mikananirss --config /path/to/config.yaml`  
5. Veel plezier


## Voorbeeld van hernoemresultaat
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---