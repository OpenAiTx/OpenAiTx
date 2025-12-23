
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  Automatisches Abrufen von Anime-Updates aus dem <a href="https://mikanani.me/">Mikan-Projekt</a> oder anderen animebezogenen RSS-Feeds und Offline-Download über Alist auf das entsprechende Netzlaufwerk.
</p>  
<p align="center">
  In Kombination mit ChatGPT wird der Ressourcenname analysiert und die Datei in ein von Emby lesbares Format umbenannt.
</p>
</p>  

--- 

[Benutzerdokumentation](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## Funktionen
- Automatisches Abrufen von Anime-Updates und Download auf das entsprechende Netzlaufwerk
- Versand von Update-Benachrichtigungen über PushPlus, Telegram und andere Kanäle
- Automatische Umbenennung in ein von emby erkennbares Format, unterstützt zudem eine benutzerdefinierte Neuabbildung der automatisch analysierten Ergebnisse für eine genauere Umbenennung

## Vorbereitung 
1. Bitte installieren Sie Alist gemäß der [Alist](https://github.com/alist-org/alist) Projektdokumentation (Version muss >=3.42.0 sein) und richten Sie Aria2/qBittorrent für das Offline-Downloading ein
2. Registrieren Sie selbst ein Mikanani-Konto, abonnieren Sie Anime-Serien und holen Sie den Abonnement-Link ein

Hinweis: Auch andere RSS-Feeds wurden angepasst, theoretisch werden die meisten RSS-Quellen (Anime-bezogen) unterstützt. Für nicht unterstützte RSS-Feeds können Sie gerne ein Issue eröffnen.

## Anwendung
Weitere Methoden zur Ausführung wie Docker, Quellcode usw. finden Sie in der [Benutzerdokumentation](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) 

Installation und Ausführung mit pip
1. Stellen Sie sicher, dass Ihre Python-Version 3.11 oder höher ist
2. Installation mit pip: `pip install alist-mikananirss`
3. Erstellen Sie im Verzeichnis eine `config.yaml`-Konfigurationsdatei und füllen Sie diese wie folgt aus (eine vollständige Funktionsbeschreibung finden Sie unter [Konfigurationshinweis](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
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
4. Führen Sie den Code aus: `python -m alist_mikananirss --config /path/to/config.yaml`  
5. Viel Spaß


## Anzeige des Umbenennungseffekts
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---