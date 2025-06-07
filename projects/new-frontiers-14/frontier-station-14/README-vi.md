<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station là một nhánh (fork) của [Space Station 14](https://github.com/space-wizards/space-station-14) chạy trên engine [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) được viết bằng C#.

Đây là kho lưu trữ chính của Frontier Station.

Nếu bạn muốn tự host hoặc tạo nội dung cho Frontier Station, đây là kho lưu trữ bạn cần. Nó chứa cả RobustToolbox và gói nội dung để phát triển các gói nội dung mới.

## Liên kết

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## Tài liệu/Hướng dẫn

[Wiki](https://frontierstation.wiki.gg/) của chúng tôi có tài liệu về nội dung của Frontier Station.

## Đóng góp

Chúng tôi rất vui được nhận đóng góp từ bất kỳ ai. Tham gia Discord nếu bạn muốn giúp đỡ. Chúng tôi có một [danh sách ý tưởng](https://discord.com/channels/1123826877245694004/1127017858833068114) mà bất kỳ ai cũng có thể thực hiện. Đừng ngại hỏi khi cần hỗ trợ!

Hiện tại chúng tôi không chấp nhận bản dịch game trên kho lưu trữ chính. Nếu bạn muốn dịch game sang ngôn ngữ khác, hãy cân nhắc tạo một nhánh (fork) riêng hoặc đóng góp cho một nhánh đã có.

Nếu bạn đóng góp bất kỳ nội dung nào, vui lòng đọc mục đánh dấu trong [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md)
Mọi thay đổi đối với các tệp thuộc upstream của chúng tôi cần được đánh dấu đúng theo quy định tại đó.

## Xây dựng

1. Sao chép kho lưu trữ này:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. Vào thư mục dự án và chạy `RUN_THIS.py` để khởi tạo các submodule và tải engine:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. Biên dịch giải pháp:  

Xây dựng máy chủ bằng `dotnet build`.

[Hướng dẫn chi tiết hơn về quá trình xây dựng dự án.](https://docs.spacestation14.com/en/general-development/setup.html)

## Giấy phép

Nội dung được đóng góp vào kho lưu trữ này sau commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 được cấp phép theo GNU Affero General Public License phiên bản 3.0, trừ khi có ghi chú khác (xem mục Ghi nhận bên dưới). Xem `LICENSE-AGPLv3.txt`.
Nội dung được đóng góp vào kho lưu trữ này trước commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 được cấp phép theo giấy phép MIT, trừ khi có ghi chú khác. Xem `LICENSE-MIT.txt`.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) được đẩy lên vào ngày 1 tháng 7 năm 2024 lúc 16:04 UTC

Hầu hết các tài sản (assets) được cấp phép theo [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) trừ khi có ghi chú khác. Các tài sản có giấy phép và bản quyền được chỉ định trong tệp metadata. Ví dụ, xem [metadata cho crowbar](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).  

Lưu ý rằng một số tài sản được cấp phép theo giấy phép phi thương mại [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) hoặc các giấy phép phi thương mại tương tự và sẽ cần phải được loại bỏ nếu bạn muốn sử dụng dự án này cho mục đích thương mại.

## Ghi nhận

Khi chúng tôi lấy nội dung từ các nhánh khác, chúng tôi tổ chức nội dung đó vào các thư mục con riêng biệt để dễ dàng theo dõi ghi nhận và giảm xung đột khi hợp nhất.

Nội dung trong các thư mục con này có nguồn gốc từ các nhánh tương ứng và có thể đã được chỉnh sửa. Các chỉnh sửa này được đánh dấu bằng các chú thích quanh những dòng đã chỉnh sửa.

| Thư mục con | Tên Fork | Kho Fork | Giấy phép |
|--------------|-----------|-----------------|---------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

Các kho bổ sung mà chúng tôi đã chuyển tính năng nhưng không có thư mục con được liệt kê bên dưới.

| Tên Fork | Kho Fork | Giấy phép |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---