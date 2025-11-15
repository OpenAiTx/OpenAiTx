<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <p>Các bản dịch sau đây được tạo tự động bằng AI. Xin lưu ý rằng chúng có thể chứa sai sót hoặc tham chiếu đến các phiên bản cũ hơn của tài liệu này.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Xem Trước Tập Phim Trong Trình Phát
====================
## 📄 Giới thiệu
Plugin này thêm danh sách các tập phim vào trình phát video, cho phép bạn xem trước từng tập của chương trình truyền hình mà không cần rời khỏi trình phát.

Bản sửa đổi này hỗ trợ các khách hàng sau:
* [Jellyfin Web Client](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) Khách hàng Desktop

## ✨ Tính năng
* Liệt kê tất cả các tập của một mùa
* Chuyển đổi giữa các mùa
* Hiển thị tiêu đề tập, mô tả, hình thu nhỏ và tiến trình phát lại
* Hiển thị chi tiết tập như xếp hạng cộng đồng
* Đánh dấu tập đã xem hoặc yêu thích
* Bắt đầu một tập mới
* Hoạt động với các chủ đề tùy chỉnh

## 📸 Xem trước
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Chủ đề sử dụng: (SkinManager) Kaleidochromic
<br>
Bản xem trước này chưa có các nút mới để đánh dấu một tập là đã hoàn thành hoặc yêu thích.

## 🔧 Cài đặt

### Jellyfin Web Client (Máy chủ)

> [!LƯU Ý]
> Rất khuyến khích cài đặt [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) ít nhất v2.2.1.0. Nó giúp tránh các vấn đề về quyền khi chỉnh sửa index.html trên bất kỳ kiểu cài đặt nào!
<details open>
<summary> Xem hướng dẫn... </summary>

1. Thêm manifest `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` làm kho plugin Jellyfin vào máy chủ của bạn.
2. Cài đặt plugin `InPlayerEpisodePreview` từ kho lưu trữ.
3. Khởi động lại máy chủ Jellyfin.
</details>

### Jellyfin Media Player (JMP) Desktop Client (Đã ngừng phát triển)
<details>
<summary> Xem hướng dẫn... </summary>

**Đã ngừng phát triển từ phiên bản JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

Vì ứng dụng JMP mới sử dụng trình phát web hiện tại từ máy chủ, nên không còn cần thiết phải chỉnh sửa trực tiếp mã nguồn của ứng dụng khách.

Đây là cách cài đặt script được khuyến nghị cho ứng dụng desktop.
Nếu bạn không cảm thấy thoải mái khi tự chỉnh sửa file nativeshell.js (bước 3 đến 6), bạn có thể tải về bản phát hành đầy đủ, trong đó script đã được thêm sẵn vào file nativeshell.js.
Hiện vẫn chưa rõ liệu việc thay thế file nativeshell.js bằng file từ bản phát hành có thể gây ra vấn đề tiềm ẩn hay không, vì vậy khuyến nghị bạn nên làm theo tất cả các bước dưới đây.

1. Tải về bản phát hành mới nhất [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) hoặc [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (đã bao gồm script được thêm vào file nativeshell.js)
2. Giải nén file zip vào thư mục Jellyfin của bạn (ví dụ: C:\Program Files\Jellyfin\Jellyfin Media Player)
3. Trong thư mục Jellyfin của bạn, hãy theo đường dẫn thư mục "web-client\extension"
4. Mở file "nativeshell.js" bằng phần mềm chỉnh sửa văn bản.
5. Trong file, tìm phần `const plugins = [];`. Thêm một dòng mới vào đầu danh sách và dán vào `'inPlayerEpisodePreviewPlugin',`. Phần này giờ sẽ trông giống như sau:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Lưu tệp và khởi động lại JMP client.
</details>

## 💡 Khắc phục sự cố

### 1. Nút xem trước không hiển thị
Điều này rất có thể liên quan đến quyền sai cho tệp `index.html`.

<details>
<summary> Xem danh sách các giải pháp khả thi... </summary>

#### 1.1 Tránh vấn đề này bằng cách sử dụng plugin [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation).

#### 1.2 Thay đổi quyền sở hữu bên trong container docker
Nếu bạn đang chạy jellyfin trong một container docker, bạn có thể thay đổi quyền sở hữu bằng lệnh sau
(thay thế jellyfin bằng tên container của bạn, user và group bằng người dùng và nhóm của container):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Bạn có thể chạy điều này như một tác vụ cron khi hệ thống khởi động.
(Cảm ơn [muisje](https://github.com/muisje) đã hỗ trợ giải pháp [này](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530))

#### 1.3 Thay đổi quyền sở hữu khi chạy trên cài đặt Windows
1. Điều hướng đến: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Nhấp chuột phải vào `index.html` → `Properties` → thẻ `Security` → Nhấp vào `Edit`
3. Chọn người dùng của bạn từ danh sách và đánh dấu vào ô quyền `Write`.
4. Khởi động lại cả máy chủ và máy khách.
   (Cảm ơn [xeuc](https://github.com/xeuc) cho giải pháp [này](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069))

Nếu không có giải pháp nào ở trên hiệu quả, vui lòng xem lại các vấn đề cũ. Ví dụ [tại đây](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) hoặc [tại đây](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Nếu bạn gặp bất kỳ lỗi nào mà không thể tự giải quyết, hãy thoải mái mở một issue mới.
<br/>Xin lưu ý rằng mỗi hệ thống đều khác nhau và có thể dẫn đến hành vi không mong đợi, vì vậy hãy cung cấp càng nhiều thông tin càng tốt.
<br/>Nhật ký Jellyfin và nhật ký console từ trình duyệt (có tiền tố [InPlayerEpisodePreview]) luôn hữu ích.

## Ghi nhận
Cấu trúc plugin dựa trên và lấy cảm hứng từ plugin [Jellyscrub](https://github.com/nicknsy/jellyscrub) của [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---