![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Chào mừng đến với kho Windows Terminal, Console và Command-Line

<details>
  <summary><strong>Mục Lục</strong></summary>

- [Cài đặt và chạy Windows Terminal](#cài-đặt-và-chạy-windows-terminal)
  - [Microsoft Store \[Khuyến nghị\]](#microsoft-store-khuyến-nghị)
  - [Các phương pháp cài đặt khác](#các-phương-pháp-cài-đặt-khác)
    - [Qua GitHub](#qua-github)
    - [Qua Windows Package Manager CLI (còn gọi là winget)](#qua-windows-package-manager-cli-còn-gọi-là-winget)
    - [Qua Chocolatey (không chính thức)](#qua-chocolatey-không-chính-thức)
    - [Qua Scoop (không chính thức)](#qua-scoop-không-chính-thức)
- [Cài đặt Windows Terminal Canary](#cài-đặt-windows-terminal-canary)
- [Lộ trình phát triển Windows Terminal](#lộ-trình-phát-triển-windows-terminal)
- [Tổng quan về Terminal & Console](#tổng-quan-về-terminal--console)
  - [Windows Terminal](#windows-terminal)
  - [Windows Console Host](#windows-console-host)
  - [Các thành phần dùng chung](#các-thành-phần-dùng-chung)
  - [Tạo Windows Terminal mới](#tạo-windows-terminal-mới)
- [Tài nguyên](#tài-nguyên)
- [Câu hỏi thường gặp](#câu-hỏi-thường-gặp)
  - [Tôi đã build và chạy Terminal mới, nhưng nó trông giống hệt console cũ](#tôi-đã-build-và-chạy-terminal-mới-nhưng-nó-trông-giống-hệt-console-cũ)
- [Tài liệu](#tài-liệu)
- [Đóng góp](#đóng-góp)
- [Liên hệ với nhóm phát triển](#liên-hệ-với-nhóm-phát-triển)
- [Hướng dẫn cho nhà phát triển](#hướng-dẫn-cho-nhà-phát-triển)
- [Yêu cầu trước](#yêu-cầu-trước)
- [Build mã nguồn](#build-mã-nguồn)
  - [Build bằng PowerShell](#build-bằng-powershell)
  - [Build bằng Cmd](#build-bằng-cmd)
- [Chạy & Gỡ lỗi](#chạy--gỡ-lỗi)
  - [Hướng dẫn lập trình](#hướng-dẫn-lập-trình)
- [Quy tắc ứng xử](#quy-tắc-ứng-xử)

</details>

<br />

Kho này chứa mã nguồn cho:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Windows console host (`conhost.exe`)
* Các thành phần dùng chung giữa hai dự án
* [ColorTool](./src/tools/ColorTool)
* [Dự án mẫu](./samples)
  minh họa cách sử dụng các API của Windows Console

Các kho liên quan bao gồm:

* [Tài liệu Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([Kho: Đóng góp cho tài liệu](https://github.com/MicrosoftDocs/terminal))
* [Tài liệu Console API](https://github.com/MicrosoftDocs/Console-Docs)
* [Phông chữ Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## Cài đặt và chạy Windows Terminal

> [!NOTE]
> Windows Terminal yêu cầu Windows 10 2004 (build 19041) trở lên

### Microsoft Store [Khuyến nghị]

Cài đặt [Windows Terminal từ Microsoft Store][store-install-link].
Điều này cho phép bạn luôn sử dụng phiên bản mới nhất khi chúng tôi phát hành các bản build mới
với cập nhật tự động.

Đây là phương pháp chúng tôi ưu tiên.

### Các phương pháp cài đặt khác

#### Qua GitHub

Đối với người dùng không thể cài đặt Windows Terminal từ Microsoft Store,
các bản phát hành có thể được tải xuống thủ công từ [trang Releases
của kho này](https://github.com/microsoft/terminal/releases).

Tải xuống tệp `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` từ
phần **Assets**. Để cài đặt ứng dụng, bạn chỉ cần nhấp đúp vào tệp
`.msixbundle`, và trình cài đặt ứng dụng sẽ tự động chạy. Nếu vì lý do nào đó không thành công, bạn có thể thử lệnh sau tại PowerShell:

```powershell
# LƯU Ý: Nếu bạn dùng PowerShell 7+, vui lòng chạy
# Import-Module Appx -UseWindowsPowerShell
# trước khi sử dụng Add-AppxPackage.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> Nếu bạn cài đặt Terminal thủ công:
>
> * Bạn có thể cần cài đặt [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages).
>   Điều này chỉ cần thiết trên các bản Windows 10 cũ và chỉ nếu bạn gặp lỗi thiếu gói framework.
> * Terminal sẽ không tự động cập nhật khi có bản phát hành mới, vì vậy bạn sẽ cần
>   thường xuyên cài đặt bản phát hành Terminal mới nhất để nhận tất cả các bản sửa lỗi và cải tiến mới!

#### Qua Windows Package Manager CLI (còn gọi là winget)

Người dùng [winget](https://github.com/microsoft/winget-cli) có thể tải xuống và cài đặt
bản phát hành Terminal mới nhất bằng cách cài đặt gói `Microsoft.WindowsTerminal`:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> Hỗ trợ phụ thuộc khả dụng từ WinGet phiên bản [1.6.2631 trở lên](https://github.com/microsoft/winget-cli/releases). Để cài đặt bản phát hành Terminal ổn định 1.18 trở lên, vui lòng đảm bảo bạn đã cập nhật WinGet client.

#### Qua Chocolatey (không chính thức)

Người dùng [Chocolatey](https://chocolatey.org) có thể tải xuống và cài đặt bản phát hành Terminal mới nhất bằng cách cài đặt gói `microsoft-windows-terminal`:

```powershell
choco install microsoft-windows-terminal
```

Để nâng cấp Windows Terminal bằng Chocolatey, hãy chạy:

```powershell
choco upgrade microsoft-windows-terminal
```

Nếu bạn gặp bất kỳ vấn đề nào khi cài đặt/nâng cấp gói, vui lòng truy cập
[trang gói Windows Terminal
](https://chocolatey.org/packages/microsoft-windows-terminal) và làm theo
[quy trình xử lý của Chocolatey](https://chocolatey.org/docs/package-triage-process)

#### Qua Scoop (không chính thức)

Người dùng [Scoop](https://scoop.sh) có thể tải xuống và cài đặt bản phát hành Terminal mới nhất bằng cách cài đặt gói `windows-terminal`:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Để cập nhật Windows Terminal bằng Scoop, hãy chạy:

```powershell
scoop update windows-terminal
```

Nếu bạn gặp bất kỳ vấn đề nào khi cài đặt/cập nhật gói, vui lòng tìm kiếm hoặc báo cáo trên [trang issues
](https://github.com/lukesampson/scoop-extras/issues) của kho Scoop Extras bucket.

---

## Cài đặt Windows Terminal Canary
Windows Terminal Canary là bản build hàng đêm của Windows Terminal. Bản build này có mã nguồn mới nhất từ nhánh `main` của chúng tôi, giúp bạn có cơ hội thử các tính năng trước khi chúng xuất hiện trong Windows Terminal Preview.

Windows Terminal Canary là phiên bản kém ổn định nhất của chúng tôi, vì vậy bạn có thể gặp lỗi trước khi chúng tôi kịp phát hiện.

Windows Terminal Canary có sẵn dưới dạng bản phân phối App Installer và bản phân phối Portable ZIP.

Bản phân phối App Installer hỗ trợ cập nhật tự động. Do giới hạn nền tảng, trình cài đặt này chỉ hoạt động trên Windows 11.

Bản phân phối Portable ZIP là ứng dụng di động. Nó sẽ không tự động cập nhật và không tự động kiểm tra bản cập nhật. Bản phân phối Portable ZIP này hoạt động trên Windows 10 (19041+) và Windows 11.

| Phân phối       | Kiến trúc         | Liên kết                                                |
|-----------------|:-----------------:|---------------------------------------------------------|
| App Installer   | x64, arm64, x86   | [download](https://aka.ms/terminal-canary-installer)    |
| Portable ZIP    | x64               | [download](https://aka.ms/terminal-canary-zip-x64)      |
| Portable ZIP    | ARM64             | [download](https://aka.ms/terminal-canary-zip-arm64)    |
| Portable ZIP    | x86               | [download](https://aka.ms/terminal-canary-zip-x86)      |

_Tìm hiểu thêm về [các loại phân phối Windows Terminal](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Lộ trình phát triển Windows Terminal

Kế hoạch cho Windows Terminal [được mô tả tại đây](/doc/roadmap-2023.md) và
sẽ được cập nhật khi dự án tiến triển.

## Tổng quan về Terminal & Console

Vui lòng dành vài phút để xem tổng quan dưới đây trước khi đi sâu vào
mã nguồn:

### Windows Terminal

Windows Terminal là ứng dụng terminal mới, hiện đại, giàu tính năng, năng suất
cao dành cho người dùng dòng lệnh. Nó bao gồm nhiều tính năng được cộng đồng
dòng lệnh Windows yêu cầu nhiều nhất như hỗ trợ tab, văn bản phong phú, toàn
cầu hóa, cấu hình, giao diện & chủ đề, và nhiều hơn nữa.

Terminal cũng cần đáp ứng các mục tiêu và tiêu chí để đảm bảo luôn nhanh và hiệu quả, không tiêu thụ nhiều bộ nhớ hoặc điện năng.

### Windows Console Host

Windows Console host, `conhost.exe`, là trải nghiệm dòng lệnh gốc của Windows. Nó cũng lưu trữ hạ tầng dòng lệnh của Windows và máy chủ Windows Console API, engine nhập liệu, engine kết xuất, tuỳ chọn người dùng, v.v. Mã nguồn console host trong kho này là mã thực tế mà từ đó
`conhost.exe` trong Windows được build.

Kể từ khi tiếp quản dòng lệnh Windows năm 2014, nhóm đã bổ sung nhiều tính năng mới cho Console, bao gồm độ trong suốt nền, chọn theo dòng, hỗ trợ [ANSI / Virtual Terminal
sequences](https://en.wikipedia.org/wiki/ANSI_escape_code), [màu 24-bit](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/),
[Pseudoconsole
("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/),
và nhiều hơn nữa.

Tuy nhiên, vì mục tiêu chính của Windows Console là duy trì tương thích ngược, chúng tôi không thể bổ sung nhiều tính năng mà cộng đồng (và nhóm phát triển) mong muốn trong nhiều năm, bao gồm tab, văn bản unicode, và emoji.

Những giới hạn này đã dẫn đến việc chúng tôi tạo ra Windows Terminal mới.

> Bạn có thể đọc thêm về sự phát triển của dòng lệnh nói chung, và dòng lệnh Windows nói riêng trong [chuỗi bài blog đi kèm này](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
> trên blog của nhóm Command-Line.

### Các thành phần dùng chung

Khi cải tiến Windows Console, chúng tôi đã hiện đại hóa mã nguồn đáng kể,
tách rõ ràng các thực thể logic thành module và class, bổ sung các điểm mở rộng quan trọng, thay thế nhiều bộ sưu tập và container tự phát triển cũ bằng các [container STL](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) an toàn và hiệu quả hơn,
và làm cho mã đơn giản và an toàn hơn bằng cách sử dụng [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil).

Việc cải tiến này giúp một số thành phần chính của Console có thể tái sử dụng trong bất kỳ triển khai terminal nào trên Windows. Các thành phần này bao gồm engine bố trí và kết xuất văn bản dựa trên DirectWrite mới, bộ đệm văn bản có thể lưu cả UTF-16 và UTF-8, trình phân tích/phát VT, và nhiều hơn nữa.

### Tạo Windows Terminal mới

Khi chúng tôi bắt đầu lập kế hoạch cho ứng dụng Windows Terminal mới, chúng tôi đã khảo sát và đánh giá nhiều cách tiếp cận và công nghệ khác nhau. Cuối cùng, chúng tôi quyết định rằng mục tiêu sẽ được đáp ứng tốt nhất bằng cách tiếp tục đầu tư vào mã nguồn C++ của mình, cho phép tái sử dụng nhiều thành phần hiện đại đã đề cập ở trên cho cả Console hiện có và Terminal mới. Ngoài ra, chúng tôi nhận ra điều này cho phép xây dựng phần lõi Terminal như một control giao diện người dùng có thể tái sử dụng mà các ứng dụng khác cũng có thể tích hợp.

Kết quả của công việc này nằm trong kho này và được phát hành dưới dạng ứng dụng Windows Terminal mà bạn có thể tải từ Microsoft Store hoặc [trực tiếp từ các bản phát hành của kho](https://github.com/microsoft/terminal/releases).

---

## Tài nguyên

Để biết thêm thông tin về Windows Terminal, bạn có thể thấy một số tài nguyên sau hữu ích và thú vị:

* [Command-Line Blog](https://devblogs.microsoft.com/commandline)
* [Chuỗi blog Command-Line Backgrounder](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Phát hành Windows Terminal: [Video "Sizzle Terminal"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Phát hành Windows Terminal: [Phiên Build 2019](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Số 645 - Windows Terminal với Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [Tập 54 - Kayla Cinnamon và Rich Turner về DevOps trên đội ngũ Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019: [Dòng lệnh Windows hiện đại: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## Câu hỏi thường gặp

### Tôi đã build và chạy Terminal mới, nhưng nó trông giống hệt console cũ

Nguyên nhân: Bạn đang chạy sai solution trong Visual Studio.

Cách khắc phục: Đảm bảo bạn build & triển khai dự án `CascadiaPackage` trong Visual Studio.

> [!NOTE]
> `OpenConsole.exe` chỉ là một bản build cục bộ của `conhost.exe`, Console cổ điển của Windows chứa hạ tầng dòng lệnh Windows. OpenConsole được Windows Terminal sử dụng để kết nối và giao tiếp với các ứng dụng dòng lệnh (thông qua [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Tài liệu

Tất cả tài liệu dự án nằm tại [aka.ms/terminal-docs](https://aka.ms/terminal-docs). Nếu bạn muốn đóng góp cho tài liệu, vui lòng gửi pull request tại [kho tài liệu Windows Terminal](https://github.com/MicrosoftDocs/terminal).

---

## Đóng góp

Chúng tôi rất vui khi được hợp tác cùng bạn, cộng đồng tuyệt vời, để xây dựng và nâng cấp Windows Terminal\!

***TRƯỚC KHI bạn bắt đầu làm việc trên một tính năng/sửa lỗi***, vui lòng đọc & làm theo [Hướng dẫn đóng góp](./CONTRIBUTING.md) để
giúp tránh những nỗ lực trùng lặp hoặc lãng phí.

## Liên hệ với nhóm phát triển

Cách dễ nhất để liên hệ với nhóm là qua các issue trên GitHub.

Vui lòng gửi issue mới, yêu cầu tính năng và đề xuất, nhưng **NHỚ tìm kiếm các issue tương tự đã mở/đã đóng trước khi tạo issue mới.**

Nếu bạn muốn hỏi điều gì đó mà bạn cảm thấy chưa cần thiết thành issue
(hiện tại), vui lòng liên hệ qua Twitter:

* Christopher Nguyen, Quản lý sản phẩm:
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Trưởng nhóm kỹ thuật: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Lập trình viên cao cấp: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Lập trình viên: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Lập trình viên
* Leonard Hecker, Lập trình viên: [@LeonardHecker](https://twitter.com/LeonardHecker)

## Hướng dẫn cho nhà phát triển

## Yêu cầu trước

Bạn có thể cấu hình môi trường để build Terminal theo một trong hai cách:

### Sử dụng file cấu hình WinGet

Sau khi clone kho, bạn có thể sử dụng [file cấu hình WinGet](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)
để thiết lập môi trường. [File cấu hình mặc định](.config/configuration.winget) cài đặt Visual Studio 2022 Community & các công cụ cần thiết khác. Có hai biến thể khác của file cấu hình có sẵn trong thư mục [.config](.config) dành cho bản Enterprise & Professional của Visual Studio 2022. Để chạy file cấu hình mặc định, bạn có thể nhấp đúp file trong explorer hoặc chạy lệnh sau:

```powershell
winget configure .config\configuration.winget
```

### Cấu hình thủ công

* Bạn phải đang chạy Windows 10 2004 (build >= 10.0.19041.0) hoặc mới hơn để chạy Windows Terminal
* Bạn phải [bật Chế độ Nhà phát triển trong ứng dụng Cài đặt Windows
  ](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)
  để cài đặt và chạy Windows Terminal cục bộ
* Bạn phải cài đặt [PowerShell 7 trở lên](https://github.com/PowerShell/PowerShell/releases/latest)
* Bạn phải cài đặt [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
* Bạn phải cài đặt ít nhất [VS 2022](https://visualstudio.microsoft.com/downloads/)
* Bạn phải cài đặt các Workloads sau qua trình cài đặt VS. Lưu ý: Mở solution trong VS 2022 sẽ [nhắc bạn cài đặt các thành phần còn thiếu tự động](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * Desktop Development with C++
  * Universal Windows Platform Development
  * **Các thành phần riêng lẻ sau**
    * C++ (v143) Universal Windows Platform Tools
* Bạn phải cài đặt [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) để build các dự án test

## Build mã nguồn

OpenConsole.sln có thể được build trong Visual Studio hoặc từ dòng lệnh
sử dụng các script & công cụ tiện lợi trong thư mục **/tools**:

### Build bằng PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Build bằng Cmd

```shell
.\tools\razzle.cmd
bcz
```

## Chạy & Gỡ lỗi

Để gỡ lỗi Windows Terminal trong VS, nhấp chuột phải vào `CascadiaPackage` (trong Solution Explorer) và vào properties. Trong menu Debug, thay đổi "Application process" và "Background task process" thành "Native Only".

Sau đó bạn có thể build & debug dự án Terminal bằng cách nhấn <kbd>F5</kbd>. Đảm bảo chọn nền tảng "x64" hoặc "x86" - Terminal không build cho "Any Cpu" (vì Terminal là ứng dụng C++, không phải C#).

> 👉 Bạn _không_ thể khởi chạy Terminal trực tiếp bằng cách chạy WindowsTerminal.exe. Để biết lý do, xem
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### Hướng dẫn lập trình

Vui lòng xem các tài liệu ngắn gọn bên dưới về quy tắc lập trình của chúng tôi.

> 👉 Nếu bạn thấy thiếu tài liệu nào, hãy đóng góp vào bất kỳ file tài liệu nào trong kho (hoặc viết tài liệu mới!)

Đây là tài liệu đang hoàn thiện khi chúng tôi xác định những gì cần cung cấp cho các cộng tác viên hiệu quả hơn.

* [Quy tắc lập trình](./doc/STYLE.md)
* [Tổ chức mã nguồn](./doc/ORGANIZATION.md)
* [Xử lý ngoại lệ trong mã nguồn cũ](./doc/EXCEPTIONS.md)
* [Smart pointer và macro hữu ích để giao tiếp với Windows trong WIL](./doc/WIL.md)

---

## Quy tắc ứng xử

Dự án này đã áp dụng [Quy tắc ứng xử mã nguồn mở của Microsoft][conduct-code]. Để biết thêm thông tin, xem [Câu hỏi thường gặp về Quy tắc ứng xử][conduct-FAQ] hoặc liên hệ [opencode@microsoft.com][conduct-email] nếu có câu hỏi hoặc ý kiến bổ sung.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---