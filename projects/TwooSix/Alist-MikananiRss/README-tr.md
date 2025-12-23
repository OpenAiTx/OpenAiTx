
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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
  <a href="https://mikanani.me/">Mikan Projesi</a> veya diğer anime dizi ile ilgili RSS beslemelerinden otomatik olarak dizi güncellemelerini alır ve Alist ile çevrimdışı olarak ilgili bulut diske indirir.
</p>  
<p align="center">
  Ayrıca ChatGPT ile kaynak adı analizi yaparak, kaynağı Emby tarafından çözümlenebilecek bir formata yeniden adlandırır.
</p>
</p>  

--- 

[Dokümantasyon](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## Özellikler
- Anime güncellemelerini otomatik olarak alır ve ilgili bulut diskine indirir
- PushPlus, Telegram gibi kanallar üzerinden güncelleme bildirimi gönderir
- emby tarafından tanınabilir biçimde otomatik yeniden adlandırır, ayrıca otomatik olarak çözümlenen sonuçlar için özel yeniden eşleme desteği ile yeniden adlandırma daha doğru olur

## Hazırlıklar 
1. Lütfen [Alist](https://github.com/alist-org/alist) proje dokümantasyonunu takip ederek Alist'i kurun (sürüm >=3.42.0 olmalı) ve Aria2/qBittorrent ile offline indirmeyi ayarlayın
2. Kendiniz bir Mikan Project hesabı oluşturun, anime abonesi olun ve abone bağlantısını alın

Not: Diğer RSS abonelik kaynakları için de belirli bir uyum sağlanmıştır, teorik olarak çoğu abonelik kaynağını (anime ile ilgili) destekler, desteklenmeyen RSS için de issue açabilirsiniz

## Nasıl Kullanılır
Docker, kaynak koddan çalıştırma gibi daha fazla çalışma yöntemi için [Dokümantasyon](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) sayfasına bakınız

pip ile kurup çalıştırma
1. Python sürümünüzün 3.11 ve üzeri olduğundan emin olun
2. pip ile kurun: `pip install alist-mikananirss`
3. Klasörde bir `config.yaml` yapılandırma dosyası oluşturup aşağıdaki gibi doldurun (tüm özellikler için örnek ve detaylar için [Yapılandırma Açıklaması](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E) sayfasına bakınız)
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
4. Kodu çalıştırın: `python -m alist_mikananirss --config /path/to/config.yaml`  
5. Keyfini çıkarın


## Yeniden Adlandırma Sonucu Gösterimi
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---