# Microsoft PowerToys

![Hình ảnh chính của Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[Cách sử dụng PowerToys][usingPowerToys-docs-link] | [Tải xuống & Ghi chú phát hành][github-release-link] | [Đóng góp cho PowerToys](#contributing) | [Có gì mới](#whats-happening) | [Lộ trình phát triển](#powertoys-roadmap)

## Giới thiệu

Microsoft PowerToys là bộ tiện ích dành cho người dùng nâng cao để tùy chỉnh và tối ưu hóa trải nghiệm Windows, giúp tăng năng suất làm việc. Để biết thêm thông tin về [tổng quan PowerToys và cách sử dụng các tiện ích][usingPowerToys-docs-link], hoặc các công cụ và tài nguyên khác cho [môi trường phát triển Windows](https://learn.microsoft.com/windows/dev-environment/overview), hãy truy cập [learn.microsoft.com][usingPowerToys-docs-link]!

|              | Tiện ích hiện tại: |              |
|--------------|-------------------|--------------|
| [Advanced Paste](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Always on Top](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Color Picker](https://aka.ms/PowerToysOverview_ColorPicker) | [Command Not Found](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [Crop And Lock](https://aka.ms/PowerToysOverview_CropAndLock) | [Environment Variables](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [File Explorer Add-ons](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts File Editor](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Image Resizer](https://aka.ms/PowerToysOverview_ImageResizer) | [Keyboard Manager](https://aka.ms/PowerToysOverview_KeyboardManager) | [Mouse utilities](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Mouse Without Borders](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [Paste as Plain Text](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [Registry Preview](https://aka.ms/PowerToysOverview_RegistryPreview) | [Screen Ruler](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Shortcut Guide](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Text Extractor](https://aka.ms/PowerToysOverview_TextExtractor) | [Workspaces](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Cài đặt và chạy Microsoft PowerToys

### Yêu cầu

- Windows 11 hoặc Windows 10 phiên bản 2004 (tên mã 20H1 / số bản dựng 19041) trở lên.
- Bộ xử lý x64 hoặc ARM64
- Bộ cài đặt sẽ cài các thành phần sau:
   - Bộ cài [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703). Điều này sẽ cài đặt phiên bản mới nhất.

### Qua GitHub với EXE [Khuyến nghị]

Truy cập [trang phát hành Microsoft PowerToys trên GitHub][github-release-link] và nhấp vào `Assets` ở cuối trang để xem các tệp trong bản phát hành. Vui lòng sử dụng bộ cài PowerToys phù hợp với kiến trúc máy và phạm vi cài đặt của bạn. Đối với hầu hết người dùng, chọn `x64` và cài đặt cho từng người dùng.

<!-- các mục cần cập nhật qua từng bản phát hành -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe 
 
|  Mô tả          | Tên tệp | sha256 hash |
|-----------------|---------|-------------|
| Cài cho người dùng - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Cài cho người dùng - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Cài toàn máy - x64             | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Cài toàn máy - ARM64           | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

Đây là phương pháp được khuyến nghị.

### Qua Microsoft Store

Cài đặt từ [trang PowerToys trên Microsoft Store][microsoft-store-link]. Bạn cần sử dụng [Microsoft Store mới](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) dành cho cả Windows 11 và Windows 10.

### Qua WinGet
Tải PowerToys từ [WinGet][winget-link]. Việc cập nhật PowerToys qua winget sẽ giữ nguyên phạm vi cài đặt hiện tại. Để cài đặt PowerToys, chạy lệnh sau từ dòng lệnh/PowerShell:

#### Bộ cài cho người dùng [mặc định]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Bộ cài toàn máy

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Các phương pháp cài đặt khác

Có [các phương pháp cài đặt do cộng đồng phát triển](./doc/unofficialInstallMethods.md) như Chocolatey và Scoop. Nếu đây là phương án bạn ưa thích, hướng dẫn cài đặt có thể được tìm thấy tại đó.

## Plugin Run của bên thứ ba

Có một bộ sưu tập [plugin của bên thứ ba](./doc/thirdPartyRunPlugins.md) được cộng đồng phát triển nhưng không được phân phối cùng PowerToys.

## Đóng góp

Dự án này hoan nghênh mọi hình thức đóng góp. Ngoài việc bổ sung tính năng / sửa lỗi, bạn có thể hỗ trợ viết tài liệu, thiết kế, viết đặc tả và tìm lỗi. Chúng tôi rất mong được hợp tác với cộng đồng người dùng nâng cao để xây dựng bộ công cụ giúp bạn khai thác tối đa Windows.

**Trước khi bạn bắt đầu làm một tính năng muốn đóng góp**, vui lòng đọc [Hướng dẫn đóng góp](CONTRIBUTING.md) của chúng tôi. Chúng tôi sẵn sàng phối hợp để tìm ra phương án tốt nhất, hướng dẫn và hỗ trợ trong quá trình phát triển, giúp tránh trùng lặp hoặc lãng phí công sức.

Hầu hết các đóng góp yêu cầu bạn đồng ý với [Thỏa thuận cấp phép đóng góp (CLA)][oss-CLA] xác nhận bạn cho phép chúng tôi sử dụng đóng góp của bạn và bạn có quyền làm điều đó.

Để biết hướng dẫn phát triển PowerToys, vui lòng đọc [tài liệu dành cho nhà phát triển](/doc/devdocs) để biết chi tiết cách thiết lập máy tính để biên dịch.

## Có gì mới

### Lộ trình phát triển PowerToys

[Lộ trình ưu tiên][roadmap] các tính năng và tiện ích mà nhóm phát triển cốt lõi đang tập trung.

### 0.91 - Cập nhật tháng 5/2025

Trong bản phát hành này, chúng tôi tập trung vào các tính năng mới, sự ổn định và tự động hóa.

**✨Điểm nổi bật**

 - Tập trung cải thiện hiệu năng Command Palette và sửa nhiều lỗi. Một số tính năng mới đã bổ sung:
 - Thêm khả năng để Command Palette tìm kiếm bất kỳ tệp nào thông qua lệnh dự phòng.
 - Thêm khả năng đặt phím tắt toàn cục của Command Palette là low-level keyboard hook.
 - Thêm lệnh dự phòng mở URL cho tiện ích mở rộng WebSearch, cho phép người dùng mở trực tiếp URL từ Command Palette trên trình duyệt.
 - Giờ đây bạn có thể định nghĩa định dạng tùy chỉnh trong plugin Ngày và Giờ của PT Run và Command Palette. Cảm ơn [@htcfreek](https://github.com/htcfreek)!

### Advanced Paste

 - Sửa lỗi Advanced Paste không tạo được engine OCR cho một số thẻ ngôn ngữ tiếng Anh (vd: en-CA) bằng cách khởi tạo engine OCR với ngôn ngữ hồ sơ người dùng. Cảm ơn [@cryolithic](https://github.com/cryolithic)!

### Color Picker

 - Sửa lỗi rò rỉ tài nguyên gây treo hoặc sập ứng dụng bằng cách giải phóng đúng đối tượng Graphics. Cảm ơn [@dcog989](https://github.com/dcog989)!
 - Sửa lỗi Color Picker thoát khi nhấn phím Backspace bằng cách đảm bảo chỉ đóng khi có tiêu điểm và đồng bộ hóa hành vi Escape/Backspace. Cảm ơn [@PesBandi](https://github.com/PesBandi)!
 - Thêm hỗ trợ định dạng màu Oklab và Oklch. Cảm ơn [@lemonyte](https://github.com/lemonyte)!

### Command Not Found

 - Cập nhật script WinGet Command Not Found chỉ bật các tính năng thử nghiệm nếu thực sự tồn tại.

### Command Palette

 - Cập nhật mẫu báo lỗi để bao gồm module Command Palette.
 - Sửa lỗi cửa sổ thông báo không co giãn theo DPI, gây lỗi giao diện khi dùng thu phóng màn hình.
 - Sửa lỗi điều hướng bằng phím lên/xuống không di chuyển lựa chọn khi caret ở vị trí 0, và bổ sung điều hướng liên tục như PT Run v1. Cảm ơn [@davidegiacometti](https://github.com/davidegiacometti)!
 - Cập nhật mã mở rộng Thời gian và Ngày để đơn giản hóa và tăng tính rõ ràng.
 - Sửa lỗi viết hoa trong lệnh gây lỗi khi di chuyển đến con trỏ chuột, đã chỉnh về chữ thường.
 - Thêm lệnh dự phòng mở URL cho tiện ích mở rộng WebSearch, cho phép mở URL trực tiếp trên trình duyệt từ Command Palette. Cảm ơn [@htcfreek](https://github.com/htcfreek)!
 - Thêm tùy chọn bật/tắt biểu tượng khay hệ thống trong CmdPal và đồng bộ thuật ngữ với Windows 11. Cảm ơn [@davidegiacometti](https://github.com/davidegiacometti)!
 - Sửa lỗi cập nhật alias bằng cách loại bỏ alias cũ khi đặt alias mới.
 - Giải quyết xung đột viết hoa/thường trên GitHub bằng cách chuyển Exts và exts vào thư mục ext mới, đảm bảo cấu trúc đồng nhất trên các nền tảng và tránh phân mảnh đường dẫn.
 - Sửa lỗi lệnh 'Create New Extension' sinh tên tệp rỗng.
 - Thêm khả năng đặt phím tắt toàn cục là low-level keyboard hook.
 - Thêm hỗ trợ thumbnail JUMBO, cho phép sử dụng icon độ phân giải cao.
 - Sửa lỗi sập khi CmdPal tự động ẩn trong khi hộp thoại MSAL đang mở bằng cách ngăn CmdPal ẩn nếu nó bị vô hiệu hóa.
 - Thêm hỗ trợ chọn ngay văn bản tìm kiếm khi trang được tải.
 - Sửa lỗi trang cài đặt tiện ích mở rộng không tải lại khi mở lại bằng cách cập nhật form khi lưu cài đặt.
 - Sửa lỗi Command Palette không khởi chạy từ runner.
 - Tái cấu trúc và chuyển logic máy tính PowerToys Run v1 vào Command Palette, thêm hỗ trợ cài đặt và cải thiện hành vi dự phòng.
 - Thêm lại hỗ trợ phím tắt bàn phím cho mục danh sách.
 - Nâng cao khả năng truy cập trong Command Palette bằng cách thêm nhãn phù hợp, hoàn thiện hiệu ứng, cải thiện bản địa hóa và sửa lỗi liên quan đến a11y.
 - Chuyển hỗ trợ định dạng tùy chỉnh cho plugin Ngày và Giờ, sắp xếp lại và làm sạch cài đặt, cải thiện thông báo lỗi và sửa lỗi sập trong trường hợp đặc biệt giúp hoạt động ổn định, thân thiện hơn. Cảm ơn [@htcfreek](https://github.com/htcfreek)!
 - Thêm mục dự phòng cho lệnh hệ thống.
 - Sửa lỗi Windows System Command hiển thị prompt phím là "Empty" cho hành động "Open Recycle Bin". Cảm ơn [@jironemo](https://github.com/jironemo)!
 - Sửa lỗi danh sách 'more commands' hiển thị lệnh không nên xuất hiện. Cảm ơn [@davidegiacometti](https://github.com/davidegiacometti)!
 - Sửa lỗi chế độ xem chi tiết hiển thị icon quá lớn và chữ không thẳng hàng, đồng bộ với Windows Search.
 - Sửa lỗi nội dung màn hình trống và thanh lệnh bị cắt khi dùng nhãn dài, đảm bảo bố cục và hiển thị hợp lý.
 - Cải thiện tích hợp WinGet cho CmdPal bằng cách sửa hiển thị phiên bản cho gói đã cài, cho phép cập nhật với icon, và chuyển API winget bản preview sang bản ổn định.
 - Sửa lỗi lệnh cho ContentPage không cập nhật cho đến khi thoát, bằng cách đảm bảo menu ngữ cảnh được khởi tạo đầy đủ khi thay đổi.
 - Thêm hỗ trợ dự phòng cho tiện ích mở rộng TimeDate, cho phép truy vấn ngày/giờ trực tiếp mà không cần chọn lệnh trước.
 - Thêm import Common.Dotnet.AotCompatibility.props trên nhiều tệp dự án CmdPal để tăng hỗ trợ biên dịch AOT.
 - Sửa lỗi sập CmdPal settings do HotKey bị null khi settings.json thiếu hoặc không định nghĩa hotkey. Cảm ơn [@davidegiacometti](https://github.com/davidegiacometti)!
 - Thêm hỗ trợ menu ngữ cảnh lồng nhau, có thể lọc trong CmdPal, bao gồm hộp tìm kiếm giữ hành vi focus.
 - Tái cấu trúc lớp CmdPal để cải thiện JSON serialization và giới thiệu context serialization mới cho hiệu suất, bảo trì tốt hơn.
 - Thêm hỗ trợ biên dịch ahead-of-time (AoT).
 - Thêm cơ chế thử lại khi khởi chạy CmdPal.
 - Loại bỏ một số tệp không dùng trong CmdPal.Common để đơn giản hóa mã nguồn và chuẩn bị đánh dấu tương thích AoT.
 - Sửa lỗi race condition khi cập nhật SearchText khiến con trỏ nhảy về cuối dòng, đảm bảo SearchText chỉ cập nhật sau khi thực sự thay đổi.
 - Thêm hỗ trợ tìm kiếm bất kỳ tệp nào trong lệnh dự phòng.
 - Dọn dẹp mã liên quan đến AoT để tránh thao tác trùng khi kiểm thử.
 - Giảm thời gian tải CmdPal bằng cách khởi động tiện ích mở rộng song song và thêm timeout tránh tiện ích lỗi làm ảnh hưởng tiện ích khác.
 - Cải thiện hành vi UI bằng cách ẩn khung chi tiết khi danh sách bị làm trống, tránh trạng thái hiển thị bất nhất.
 - Thêm hỗ trợ bỏ thiết lập lệnh dự phòng trong CmdPal khi không tìm thấy lệnh nào khớp, đảm bảo hành vi tải lại sạch sẽ.
 - Sửa rò rỉ trong template tiện ích mở rộng CmdPal do sử dụng ComServer không đúng cách.
 - Ngăn cửa sổ CmdPal phóng to khi nhấp đúp thanh tiêu đề để giữ hành vi cửa sổ như mong muốn. Cảm ơn [@davidegiacometti](https://github.com/davidegiacometti)!
 - Sửa lỗi UI Settings mở quá nhỏ bằng cách nhận biết DPI và áp dụng chiều rộng, chiều cao tối thiểu qua WinUIEx.
 - Sửa lỗi nháy trắng và hiệu ứng một lần trong CmdPal bằng cách che cửa sổ thay vì ẩn.
 - Sửa lỗi tất cả cài đặt tiện ích mở rộng bị truy xuất khi khởi động bằng cách tải lười cài đặt tiện ích mở rộng, giảm tải khởi tạo.
 - Thêm bảo vệ CmdPal khỏi bị sập khi phân tích Adaptive Card thất bại.
 - Thay thế shell:AppsFolder bằng URI activation trong CmdPal để tăng độ tin cậy.
 - Thêm khả năng mở cài đặt CmdPal từ Cài đặt PowerToys.
 - Thêm khả năng CmdPal theo dõi và cập nhật chi tiết tiện ích mở rộng động khi thuộc tính mục được thay đổi.
 - Nâng bản toolkit dùng trong template tiện ích mở rộng CmdPal lên 0.2.0.

### Image Resizer

 - Sửa lỗi xóa preset Image Resizer bị xóa nhầm preset khác.

### Keyboard Manager

 - Sửa lỗi phím modifier khi đặt không chỉ định trái/phải sẽ bị kẹt do xử lý phím sai, bằng cách theo dõi phím nhấn và gửi đúng phím. Cảm ơn [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - Nâng cao khả năng định dạng thời gian của PowerRename bằng cách bổ sung mẫu định dạng 12 giờ với hỗ trợ AM/PM. Cảm ơn [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - Thêm hỗ trợ định dạng tùy chỉnh trong plugin "Thời gian và Ngày" và cải thiện thông báo lỗi khi nhập sai định dạng. Cảm ơn [@htcfreek](https://github.com/htcfreek)!
 - Sửa hai lỗi sập: một do WFT với ngày quá sớm và một do tính tuần trong tháng với ngày quá muộn (vd: 31.12.9999), và sắp xếp lại UI. Cảm ơn [@htcfreek](https://github.com/htcfreek)!
 - Sửa lỗi viết hoa trong lệnh gây lỗi khi di chuyển đến con trỏ chuột, đã chuyển lệnh về chữ thường.
 - Thêm chi tiết phiên bản vào thông báo lỗi plugin cho 'Loading error' và 'Init error'. Cảm ơn [@htcfreek](https://github.com/htcfreek)!
 - Nâng cao mô hình kết quả bằng cách bổ sung hỗ trợ ngăn xếp sắp xếp theo tần suất sử dụng, giúp lập trình viên plugin kiểm soát việc sắp xếp tốt hơn. Cảm ơn [@CoreyHayward](https://github.com/CoreyHayward) và [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - Cập nhật ánh xạ ký tự trong GetDefaultLetterKeyEPO, thay "ǔ" bằng "ŭ" cho phím VK_U để phản ánh đúng ngữ âm Esperanto. Cảm ơn [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - Sửa lỗi Quick Accent không hoạt động đúng khi dùng bàn phím ảo. Cảm ơn [@davidegiacometti](https://github.com/davidegiacometti)!

### Registry Preview

 - Nâng cấp Registry Preview cho phép dán khóa và giá trị registry mà không cần ghi header file thủ công, và thêm nút đặt lại ứng dụng mới. Cảm ơn [@htcfreek](https://github.com/htcfreek)!

### Settings

 - Sửa lỗi ứng dụng Settings đôi khi hiển thị biểu tượng trống trên thanh tác vụ bằng cách trì hoãn gán icon cho đến khi cửa sổ được kích hoạt.
 - Thêm khả năng phóng to cửa sổ "Có gì mới" để đọc thoải mái hơn.

### Workspaces

 - Sửa lỗi game Steam không được nhận diện hoặc khởi chạy đúng bằng cách cập nhật bộ lọc cửa sổ và tích hợp xử lý giao thức URL Steam.

### Tài liệu

 - Thêm QuickNotes vào tài liệu plugin bên thứ ba cho PowerToys Run. Cảm ơn [@ruslanlap](https://github.com/ruslanlap)!
 - Thêm plugin Weather và Pomodoro vào tài liệu plugin bên thứ ba PowerToys Run. Cảm ơn [@ruslanlap](https://github.com/ruslanlap)!
 - Thêm plugin Linear vào tài liệu plugin bên thứ ba PowerToys Run. Cảm ơn [@vednig](https://github.com/vednig)!
 - Sửa lỗi định dạng trong các tệp tài liệu và cập nhật thông tin cộng tác viên, thành viên nhóm. Cảm ơn [@DanielEScherzer](https://github.com/DanielEScherzer) và [@RokyZevon](https://github.com/RokyZevon)!

### Phát triển

 - Cập nhật GitHub Action để cài đặt .NET 9 hỗ trợ phát hành MSStore.
 - Cập nhật placeholder phiên bản trong bug_report.yml để tránh báo lỗi phiên bản v0.70.0 sai.
 - Cập nhật GitHub Action nâng cấp actions/setup-dotnet từ bản 3 lên bản 4 cho phát hành MSStore.
 - Thêm securityContext vào tệp cấu hình WinGet, cho phép gọi từ context người dùng và nhắc một lần UAC cho tài nguyên nâng cao trong tiến trình riêng. Cảm ơn [@mdanish-kh](https://github.com/mdanish-kh)!
 - Thay đổi phần mở rộng tệp log từ .txt sang .log để hỗ trợ liên kết tệp và công cụ phù hợp, đồng thời thêm log cho Workspace. Cảm ơn [@benwa](https://github.com/benwa)!
 - Nâng cấp phụ thuộc cho framework kiểm thử và đồng bộ phiên bản gói giữa các thành phần.
 - Nâng cấp phụ thuộc để vá lỗ hổng bảo mật.
 - Tăng cường bảo mật repo bằng cách ghim GitHub Actions và Docker tags về commit bất biến, tích hợp quét lỗ hổng phụ thuộc tự động qua Dependency Review Workflow. Cảm ơn [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Nâng cấp Boost lên phiên bản mới hơn.
 - Nâng cấp toolkit lên phiên bản mới nhất, tắt cảnh báo liên quan đến AoT.
 - Sửa lỗi thiếu ký tệp khi thêm tệp mới gây lỗi build.
 - Cập nhật pipeline phát hành để tránh công bố biểu tượng riêng tư trong 100 năm.
 - Thêm fuzzing cho PowerRename để tăng độ tin cậy và bổ sung hướng dẫn thiết lập mở rộng fuzzing cho module C++ khác.
 - Thêm khởi tạo trước thư mục sinh ra cho tất cả dự án .csproj giúp tránh lỗi build.
 - Cập nhật WinAppSDK lên phiên bản 1.7 mới nhất.
 - Nâng cấp Boost lên phiên bản mới nhất cho dự án PowerRename Fuzzing.
 - Cập nhật đường dẫn khu vực ADO trong tsa.json để khắc phục lỗi pipeline TSA do đường dẫn cũ bị loại bỏ.
 - Triển khai hỗ trợ AoT cho CmdPal với công việc nền tảng đang tiến hành.
  
### Công cụ/Tổng hợp

 - Thêm hỗ trợ tự động tạo báo cáo lỗi bằng cách sinh URL issue GitHub điền sẵn thông tin hệ thống và chẩn đoán. Cảm ơn [@donlaci](https://github.com/donlaci)!
 - Thêm script build bộ cài cục bộ, đảm bảo CmdPal có thể khởi động ở môi trường local.
 - Loại bỏ logic xuất PFX nhằm loại bỏ mật khẩu hardcode và khắc phục cảnh báo bảo mật PSScriptAnalyzer.
 - Thêm script PowerShell và tích hợp CI để đảm bảo sử dụng nhất quán Common.Dotnet.CsWinRT.props trên tất cả dự án C# dưới thư mục src.
   
### Kế hoạch cho phiên bản 0.92

Với [v0.92][github-next-release-work], chúng tôi sẽ tập trung vào các mục sau:

 - Tiếp tục hoàn thiện Command Palette
 - Bài kiểm thử UI Automation mới
 - Nâng cấp trình cài đặt
 - Nâng cấp UI trình chỉnh sửa Keyboard Manager
 - Ổn định/cải thiện lỗi

## Cộng đồng PowerToys

Nhóm PowerToys vô cùng biết ơn vì nhận được [sự hỗ trợ tuyệt vời của cộng đồng][community-link]. Công việc của các bạn vô cùng quan trọng. PowerToys sẽ không thể phát triển như hiện tại nếu thiếu các bạn báo lỗi, cập nhật tài liệu, góp ý thiết kế hoặc viết tính năng mới. Chúng tôi muốn gửi lời cảm ơn và vinh danh đóng góp của bạn. Tháng này qua tháng khác, bạn đã trực tiếp giúp PowerToys trở thành phần mềm tuyệt vời hơn.

## Quy tắc ứng xử

Dự án này tuân theo [Quy tắc Ứng xử Nguồn Mở của Microsoft][oss-conduct-code].

## Tuyên bố về quyền riêng tư

Ứng dụng ghi lại dữ liệu chẩn đoán cơ bản (telemetry). Để biết thêm thông tin về quyền riêng tư và dữ liệu chúng tôi thu thập, xem [Tài liệu về Dữ liệu và Quyền riêng tư của PowerToys](https://aka.ms/powertoys-data-and-privacy-documentation).

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---