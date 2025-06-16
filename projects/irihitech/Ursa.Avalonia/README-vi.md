# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa là một thư viện UI cấp doanh nghiệp để xây dựng các ứng dụng đa nền tảng với Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Dự án này được hỗ trợ bởi [.NET Foundation](https://dotnetfoundation.org).

## Bắt Đầu

1. Ursa

Thêm gói nuget:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Để các điều khiển Ursa hiển thị trong ứng dụng của bạn, bạn cần tham chiếu đến một gói chủ đề được thiết kế cho Ursa.
Ursa.Themes.Semi là một gói chủ đề cho Ursa được lấy cảm hứng từ Semi Design. Bạn có thể thêm nó vào dự án của mình theo các bước sau.

Thêm gói nuget:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Bao gồm Styles trong ứng dụng:
```xaml
<Application...
    xmlns:semi="https://irihi.tech/semi"
    xmlns:u-semi="https://irihi.tech/ursa/themes/semi"
    ....>

    <Application.Styles>
        <semi:SemiTheme Locale="zh-CN" />
        <u-semi:SemiTheme Locale="zh-CN"/>
    </Application.Styles>
```


Bây giờ bạn có thể sử dụng các điều khiển Ursa trong Ứng dụng Avalonia của mình.
```xaml
<Window
    ...
    xmlns:u="https://irihi.tech/ursa"
    ...>
    <StackPanel Margin="20">
        <u:TagInput />
    </StackPanel>
</Window>
```



## Quy tắc Ứng xử

Dự án này đã áp dụng quy tắc ứng xử được xác định bởi Contributor Covenant để làm rõ hành vi mong đợi trong cộng đồng của chúng tôi.
Để biết thêm thông tin, xem [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

## Thông báo Tương thích
Ursa hiện tương thích với cả Avalonia 11.1.x và 11.2.x, nhưng cụ thể không hỗ trợ Avalonia 11.2.0.

## Phần mở rộng

### Prism Extension
Nếu bạn cần tích hợp Ursa với Prism.Avalonia, bạn có thể sử dụng gói Irihi.Ursa.PrismExtension. Gói này cung cấp các dịch vụ liên quan đến Dialog để sử dụng Ursa Dialogs với phong cách Prism.

### ReactiveUI Extension
Nếu cần tích hợp Ursa với Avalonia.ReactiveUI, bạn có thể sử dụng gói Irihi.Ursa.ReactiveUIExtension. Gói này triển khai các phiên bản ReactiveUI của UrsaWindow và UrsaView. Vui lòng tham khảo [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) để biết chi tiết.

## Hỗ trợ

Chúng tôi cung cấp hỗ trợ cộng đồng miễn phí giới hạn cho Semi Avalonia và Ursa. Vui lòng tham gia nhóm của chúng tôi qua FeiShu (Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---