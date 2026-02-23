
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Trình quản lý gói Chocolatey tự động cài đặt trong wine, tiện lợi để cài đặt nhanh các chương trình trong wine (và sau đó dễ dàng phát hiện lỗi trong wine ;) )  
Đã thêm một số giải pháp khắc phục lỗi cho một số chương trình như Visual Studio Community 2022 và nodejs, xem chi tiết bên dưới.  

Khi tôi cảm thấy nhàm chán trong thời gian giãn cách, tôi đã viết một winetricks(.ps1) tùy chỉnh với các verbs mà tôi thấy tiện dụng. Chỉ cần chạy 'winetricks' để xem các verbs đó.
Với một số verbs, cần phải khởi động lại wine hoàn toàn (do các thay đổi gần đây của wine). Bạn sẽ thấy một hộp thoại thông báo và phiên làm việc sẽ bị kết thúc. Chỉ cần khởi động lại powershell và thử lại verb đó. Nếu đã thực hiện một lần, sẽ không cần làm lại cho bất kỳ verb nào nữa.  

Ví dụ:

'winetricks vs22_interactiveinstaller'  ( --> phiên làm việc sẽ kết thúc)

thực hiện 'wine powershell'

thực hiện 'winetricks vs22_interactiveinstaller'


(BTW qua 'winetricks vs22_interactive_installer' bạn có thể chọn những gì để cài đặt thông qua trình cài đặt Visual Studio 2022; 'winetricks vs22_interactive_installer' hiện đã giúp tôi trong mười phút vào chương trình chính (đã chọn phát triển Desktop với C++)).

Cài đặt :
- Tải về và giải nén file zip phát hành và thực hiện 'wine ChoCinstaller_0.5c.751.exe' (mất khoảng một phút để hoàn thành)

Tùy chọn:
- Chạy trình cài đặt như 'wine ChoCinstaller_0.5a.751.exe /s' , sau đó các file cài đặt (như Powershell*.msi và dotnet48) sẽ được lưu trong
  MyDocuments và bạn không cần tải lại nếu tạo một prefix mới)
Tùy chọn:
- Chạy trình cài đặt như 'wine ChoCinstaller_0.5a.751.exe /q' để ngăn cửa sổ powershell tự động mở (chỉ cài đặt). 

Tùy chọn:
- Kiểm tra xem mọi thứ đã ổn chưa: "choco install chromium" và  "start chrome.exe (--no-sandbox không còn cần thiết kể từ wine-8,4)"

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
Về PowerShell:

Mẹo: Chocolatey thường cài đặt phiên bản mới nhất của một chương trình, điều này có thể làm lộ lỗi mới của wine. Bạn có thể gặp may hơn với phiên bản cũ hơn của phần mềm.
Ví dụ:

choco search --exact microsoft-edge --all (--> liệt kê tất cả các phiên bản)

choco install microsoft-edge --version --version='135.0.3179.98'

Thông tin chung:

- 'wine powershell.exe' khởi động bảng điều khiển PowerShell-Core.


Về ConEmu:

Bảng điều khiển ConEmu gặp phải một số lỗi wine:
  - Ctrl^C để thoát một chương trình không trả về bảng điều khiển không hoạt động. Hãy dùng Shift^Ctrl^C thay thế.
  - Việc chọn văn bản trong cửa sổ ConEmu (để sao chép/dán) không làm nổi bật phần lựa chọn. Đã bao gồm một bản vá rất buồn cho các phiên bản wine gần đây để khắc phục điều này, nên việc làm nổi bật giờ nên hoạt động bình thường.
   
Về winetricks(.ps1):

- Nếu bạn không gọi nó ('winetricks' trong powershell-console), thì sẽ không tải xuống gì và không có độ trễ ở đó.
- Nhiều động từ (như powershell 5.1) cần một số tệp thiết yếu để trích xuất từ các gói msu. Việc cài đặt các tệp thiết yếu này yêu cầu tải về rất nhiều dữ liệu và mất nhiều thời gian khi sử dụng lần đầu. Nhưng sau khi đã lưu vào bộ nhớ đệm thì sẽ nhanh hơn nhiều. Ví dụ nếu bạn thử 'winetricks ps51' lần đầu, sẽ mất khoảng 15 phút. Một số động từ khác có thể mất 5 phút trong lần đầu sử dụng. Nhưng sau khi đã gọi một động từ, sự phiền toái này sẽ biến mất.
- Các tệp được lưu trong thư mục MyDocuments. Nếu bạn gọi tất cả động từ sẽ tốn khoảng 800 MB ở đó.
- Hy vọng sẽ có hỗ trợ 64-bit tốt hơn cho nhiều động từ khác nhau.
- Có khả năng trích xuất tệp và (cố gắng) cài đặt từ tệp msu. Hãy chạy 'winetricks install_dll_from_msu' để xem cách thực hiện.
- Powershell 5.1 cơ bản.
- Cài đặt thử nghiệm dotnet481, và dotnet35 (có thể cần thiết cho các ứng dụng không hài lòng với dotnet48 hiện tại).
- Tự động hoàn thành tab. Lưu ý: khi sử dụng nhiều động từ từ dòng lệnh, phải phân tách bằng dấu phẩy kể từ bây giờ (đây là cách powershell xử lý nhiều đối số)
  Vì vậy 'winetricks riched20 gdiplus' sẽ không còn hoạt động, hãy dùng 'winetricks riched20,gdiplus' thay thế
- Một số chương trình không thể cài đặt/chạy khi thử qua Chocolatey do các lỗi wine. Tôi đã thêm một số giải pháp tạm thời trong winetricks cho chúng, xem bên dưới.
- Các động từ đặc biệt (winetricks vs19, vs22 và vs22_interactive_installer) để cài đặt Visual Studio Community 2019 và 2022 hoạt động (xem ảnh chụp màn hình, >10 phút cài đặt và cần khoảng 10GB!, sau khi cài đặt chạy devenv.exe từ thư mục c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Động từ đặc biệt để truy cập các lệnh unix như grep, sed, file, less, curl, v.v... (winetricks git.portable, Lưu ý: một số lệnh chưa hoạt động do lỗi wine)
- Cũng bao gồm một số script powershell được chỉnh sửa từ các đoạn mã trên internet:
    - Cách nhúng một tệp exe vào script powershell thông qua Invoke-ReflectivePEInjection (tệp exe sẽ không xuất hiện trong tasklist).
    - Cách tạo các hộp thoại thông báo đẹp mắt
    - Chuyển đổi script powershell (ps1) thành tệp exe.
    - Và một vài cái khác
 
     
Về các chương trình hệ thống:

Đã thêm tính năng thay thế các chương trình hệ thống đơn giản như setx.exe bằng một hàm trong
c:\\Program Files\Powershell\7\profile.ps1. Hoặc thêm các chương trình hệ thống còn thiếu như getmac.exe.
Nếu chương trình bị lỗi do chương trình hệ thống chưa đủ hoàn thiện hoặc bị thiếu, có thể viết một 
hàm trả về đúng những gì chương trình mong đợi.
Như trong profile.ps1 tôi đã thêm (ngoài những thứ khác) một wmic.exe hỗ trợ nhiều tuỳ chọn hơn,
và một setx.exe cơ bản.
Hoặc bạn cũng có thể điều chỉnh các đối số truyền vào chương trình hệ thống. Xem profile.ps1 và choc_install.ps1.
Không đảm bảo sẽ hoạt động cho các chương trình phức tạp hơn...
 
Ghi chú:


  - KHÔNG sử dụng trên wineprefix hiện có, chỉ sử dụng trên prefix mới được tạo hoàn toàn mới! Trình cài đặt chỉ đơn giản cài đặt dotnet48 và can thiệp vào các khóa registry.
    Nếu bạn đã cài đặt bất kỳ phiên bản dotnet nào bằng winetricks.sh thông thường, quá trình sẽ có khả năng thất bại, và ngay cả khi thành công, bạn có thể gặp phải prefix bị lỗi.
    Nếu bạn cần cài đặt phần mềm bằng winetricks.sh thông thường cho các chương trình, KHÔNG sử dụng bất kỳ verb dotnet* nào.
    Nhân tiện, các verb 'Arial' và 'd3dcompiler_47' đã được cài đặt mặc định.
  - WINEARCH=win32 _không_ được hỗ trợ!
  - Việc cập nhật từ phiên bản trước hiện tại chưa (chưa) được hỗ trợ, có thể sẽ hỗ trợ sau

Biên dịch:
  - Nếu bạn muốn tự biên dịch thay vì tải về file nhị phân: xem hướng dẫn biên dịch trong mainv1.c và installer.c
  - Sau đó sao chép choc_install.ps1 vào cùng thư mục
  - Sau đó thực hiện 'wine ChoCinstaller_0.5a.735.exe'
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---