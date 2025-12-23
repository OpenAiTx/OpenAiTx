<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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
  รับข้อมูลอัปเดตอนิเมะโดยอัตโนมัติจาก<a href="https://mikanani.me/">Mikan Project</a>หรือแหล่ง RSS ที่เกี่ยวข้องกับอนิเมะอื่น ๆ และดาวน์โหลดไปยังคลาวด์ไดรฟ์ผ่าน Alist แบบออฟไลน์
</p>  
<p align="center">
  พร้อมใช้งานร่วมกับ ChatGPT เพื่อวิเคราะห์ชื่อไฟล์ทรัพยากรและเปลี่ยนชื่อไฟล์ให้อยู่ในรูปแบบที่ Emby สามารถแยกวิเคราะห์ได้
</p>
</p>  

--- 

[คู่มือการใช้งาน](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## ฟีเจอร์
- ดึงตอนใหม่ของอนิเมะและดาวน์โหลดไปยังคลาวด์ไดรฟ์ที่กำหนดโดยอัตโนมัติ
- ส่งการแจ้งเตือนอัปเดตผ่านช่องทางต่างๆ เช่น PushPlus, Telegram ฯลฯ
- เปลี่ยนชื่อไฟล์อัตโนมัติให้อยู่ในรูปแบบที่ emby รองรับ พร้อมทั้งสามารถปรับแต่งการแมปชื่อเพื่อความแม่นยำยิ่งขึ้น

## การเตรียมความพร้อม 
1. โปรดติดตั้งและตั้งค่า Alist ตามคู่มือจาก [Alist](https://github.com/alist-org/alist) (เวอร์ชันต้อง >=3.42.0) และตั้งค่า Aria2/qBittorrent สำหรับดาวน์โหลดแบบออฟไลน์ให้พร้อม
2. สมัครบัญชี Mikan Project ด้วยตัวเอง สมัครรับอนิเมะที่ต้องการ และรับลิงก์สำหรับการสมัครรับข้อมูล

หมายเหตุ: รองรับ RSS feed อื่นๆ ที่เกี่ยวข้องกับอนิเมะในระดับหนึ่ง ทฤษฎีแล้วรองรับ RSS ส่วนใหญ่ หากพบ RSS ที่ยังไม่รองรับ สามารถแจ้ง issue ได้

## วิธีการใช้งาน
สำหรับ Docker, การรันด้วยซอร์สโค้ด หรือวิธีรันอื่นๆ ดูรายละเอียดเพิ่มเติมใน [คู่มือการใช้งาน](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) 

การติดตั้งและรันด้วย pip
1. โปรดตรวจสอบว่า python ของคุณเป็นเวอร์ชัน 3.11 ขึ้นไป
2. ติดตั้งด้วย pip: `pip install alist-mikananirss`
3. สร้างไฟล์ `config.yaml` ในโฟลเดอร์และกรอกการตั้งค่าตามนี้ (ดูตัวอย่างเต็มและรายละเอียดที่ [คำอธิบายการตั้งค่า](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
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
4. รันโค้ด: `python -m alist_mikananirss --config /path/to/config.yaml`  
5. สนุกกับการใช้งาน


## ตัวอย่างผลลัพธ์การเปลี่ยนชื่อ
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---