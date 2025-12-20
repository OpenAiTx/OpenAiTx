
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![Pre-Release](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![Giấy phép: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Trình biên dịch được hỗ trợ](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)
[![Hỏi DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/till213/SkyDolly)
![Kiểm thử đơn vị](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - "Con Cừu Đen" cho các bản ghi chuyến bay của bạn.

## Giới thiệu
Sky Dolly kết nối với một phiên bản Flight Simulator 2020 đang chạy và ghi lại các biến mô phỏng khác nhau, để phát lại.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

Kết nối được thực hiện qua SimConnect, một API tiêu chuẩn được giới thiệu cùng với Flight Simulator X để kết nối với trình mô phỏng bay.

Vui lòng tham khảo thêm tại [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md).

## Tính năng
- Ghi / Tạm dừng / Phát lại
- Bay đội hình (nhiều máy bay, phát lại khi ghi, "bay cùng đội hình", bù trừ thời gian)
- Tốc độ mẫu ghi có thể thiết lập: cố định hoặc biến đổi ("tự động")
- Điều chỉnh tốc độ phát lại ("chuyển động chậm", "tua nhanh"), lặp lại phát lại
- Vị trí, vận tốc và các biến điều khiển bay cơ bản (cánh lái, bánh lái, cánh tà, bánh xe, ...) được ghi lại
- Kiến trúc plugin với nhiều plugin nhập/xuất (CSV, GPX, IGC, KML)
- Mô-đun địa điểm với hơn 100 địa điểm mặc định và chức năng nhập/xuất
- Lưu trữ dựa trên cơ sở dữ liệu (SQLite) ("sổ nhật ký")

Xem trailer phát hành (xem trước) trên [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I):

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Để xem thêm video được tạo bằng Sky Dolly, vui lòng tham khảo [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Các tính năng mới và sắp tới được tìm thấy tại [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Hướng dẫn cơ bản

- Bắt đầu một chuyến bay
- Nhấn "Ghi" (phím R)
- Bạn có thể tạm dừng ghi (phím P)
- Dừng ghi (phím R) và nhấn "Phát lại" (phím cách)
- Điều chỉnh tốc độ phát lại và tua vị trí phát, kể cả trong lúc phát lại
- Các chuyến bay đã ghi sẽ tự động được lưu vào "sổ nhật ký"
- Chọn một chuyến bay trong sổ nhật ký và nhấn "Tải" (hoặc nhấp đúp vào dòng) để tải chuyến bay đã lưu

### Ghi & Phát lại bay đội hình

#### Ghi hình

- Chuyển sang mô-đun "Formation" (phím F2)
- Nhấp vào "Ghi" (phím R)
- Mỗi máy bay được ghi lại sẽ được thêm vào chuyến bay hiện tại
- Trong khi các máy bay hiện có được phát lại trong quá trình ghi với tốc độ lấy mẫu "auto", bạn vẫn có thể thay đổi tốc độ lấy mẫu ghi hình

#### Vị trí

- Máy bay được ghi cuối cùng trở thành "máy bay người dùng" (được camera theo dõi trong trình mô phỏng bay)
- Chọn vị trí tương đối so với "máy bay người dùng" hiện tại trước khi ghi hình

#### Phát lại

- Chỉ cần nhấp vào "Phát", "Tạm dừng" và tìm kiếm trên dòng thời gian, giống như với chuyến bay một máy bay
- Thay đổi "máy bay người dùng" (cũng trong khi phát lại) để "nhảy từ buồng lái này sang buồng lái khác"
- Giành quyền kiểm soát "máy bay người dùng" bằng cách chọn "Giành quyền kiểm soát" hoặc tùy chọn "Bay cùng Formation"

#### Quản lý đội hình

- Bạn có thể xóa từng máy bay khỏi chuyến bay ("formation")
- Phải có ít nhất một máy bay cho mỗi chuyến bay, vì vậy máy bay cuối cùng không thể bị xóa
- Thêm độ trễ thời gian cho máy bay đã chọn ("đồng bộ hóa chuyến bay đội hình nhiều người chơi")
- Để bắt đầu một chuyến bay mới với một máy bay, hãy quay lại mô-đun "Logbook" (phím F1) và nhấp vào "Ghi" (phím R)

Sao bạn không thử với một trong các ["Tell Tours"](https://github.com/till213/Tell-Tours) hướng dẫn? :)

## Tải xuống

Truy cập [Phát hành](https://github.com/till213/SkyDolly/releases) và tải về bản phát hành mới nhất.

Bản phát hành (tiền phát hành) mới nhất: **Sky Dolly 0.19.2**

Tính toán và so sánh mã kiểm tra với [các mã kiểm tra SHA-256 đã công bố](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md), để xác minh tính toàn vẹn của bản sao đã tải xuống.

## Xây dựng

Tham khảo tài liệu [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md).

## Dự án liên quan

- https://github.com/nguyenquyhy/Flight-Recorder - Ứng dụng ghi lại và phát lại chuyến bay dựa trên .Net
- https://github.com/saltysimulations/saltyreplay/ - Ứng dụng ghi lại & phát lại với giao diện người dùng web
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Ghi lại chuyến bay và tạo ra "phát lại" Google Earth (định dạng KML)
- https://github.com/Elephant42/FS_Tool - Công cụ đơn giản cho phép thiết lập vị trí máy bay và tốc độ mô phỏng
- https://github.com/pyviator/msfs-geoshot - Chụp ảnh màn hình và tự động gắn "geotag"
- https://github.com/ijl20/msfs_logger_replay - IGC logger và phát lại (cho FSX)
- https://joinfs.net/ - Cho phép đồng bộ chuyến bay đa người chơi giữa các trình mô phỏng bay khác nhau (MSFS, Prepar3D/FSX, XPlane). Cũng cung cấp trình ghi chuyến bay với ghi đội hình bay ("overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote cho FlyByWire's A32NX: điều khiển chức năng buồng lái của FBW A320, sử dụng FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyer phân tích sổ nhật ký MSFS và xuất CSV có thể đọc được bởi Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave tự động (hoặc theo yêu cầu) lưu trữ kế hoạch bay
- https://github.com/mracko/MSFS-Landing-Inspector - Phân tích hiệu suất hạ cánh của bạn
- [Điểm quan tâm (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Các điểm quan tâm, sân bay và thành phố 3D trong Microsoft Flight Simulator.

## Các nguồn tài nguyên hữu ích khác

- https://obsproject.com/ - Ứng dụng quay màn hình / phát sóng
- https://sqlitebrowser.org/ - Duyệt tập tin cơ sở dữ liệu nhật ký Sky Dolly (*.sdlog), thực thi các truy vấn SQL của riêng bạn


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---