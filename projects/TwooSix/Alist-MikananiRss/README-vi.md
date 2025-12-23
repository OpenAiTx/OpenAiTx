
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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
  Tự động lấy cập nhật anime từ <a href="https://mikanani.me/">Mikanani</a> hoặc các nguồn RSS liên quan anime khác và tải về ngoại tuyến qua Alist vào ổ đĩa mạng tương ứng
</p>  
<p align="center">
  Kết hợp sử dụng ChatGPT để phân tích tên tài nguyên, đổi tên tài nguyên sang định dạng mà Emby có thể nhận diện.
</p>
</p>  

--- 

[Hướng dẫn sử dụng](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## Chức năng
- Tự động lấy cập nhật anime và tải xuống ổ đĩa mạng tương ứng
- Gửi thông báo cập nhật qua các kênh như PushPlus, Telegram
- Tự động đổi tên sang định dạng mà emby nhận diện được, đồng thời hỗ trợ tùy chỉnh lại kết quả phân tích tự động để kết quả đổi tên chính xác hơn

## Chuẩn bị 
1. Vui lòng tự tham khảo tài liệu dự án [Alist](https://github.com/alist-org/alist) để triển khai Alist (phiên bản >=3.42.0), và thiết lập tải xuống offline Aria2/qBittorrent
2. Tự đăng ký tài khoản Mikan Project, đăng ký anime, lấy liên kết đăng ký

Phụ lục: Các nguồn RSS khác cũng đã được điều chỉnh nhất định, về lý thuyết hỗ trợ đa số nguồn đăng ký (liên quan anime), với các RSS chưa được hỗ trợ cũng hoan nghênh gửi issue

## Cách sử dụng
Các phương pháp chạy khác như Docker, chạy bằng mã nguồn xem chi tiết tại [Hướng dẫn sử dụng](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) 

Cài đặt và chạy bằng pip
1. Đảm bảo phiên bản python của bạn từ 3.11 trở lên
2. Cài đặt bằng pip: `pip install alist-mikananirss`
3. Tạo một file cấu hình `config.yaml` mới trong thư mục và điền thông tin cấu hình như sau (ví dụ đầy đủ và giải thích chi tiết xem tại [Hướng dẫn cấu hình](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
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
4. Chạy mã: `python -m alist_mikananirss --config /path/to/config.yaml`  
5. Thưởng thức


## Hiển thị hiệu quả đổi tên
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---