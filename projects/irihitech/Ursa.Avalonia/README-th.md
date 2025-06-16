# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa เป็นไลบรารี UI ระดับองค์กรสำหรับสร้างแอปพลิเคชันข้ามแพลตฟอร์มด้วย Avalonia UI

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

โปรเจกต์นี้ได้รับการสนับสนุนโดย [.NET Foundation](https://dotnetfoundation.org)

## เริ่มต้นใช้งาน

1. Ursa

เพิ่ม nuget package:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

เพื่อให้คอนโทรลของ Ursa ปรากฏในแอปพลิเคชันของคุณ คุณต้องอ้างอิงแพ็กเกจธีมที่ออกแบบมาสำหรับ Ursa
Ursa.Themes.Semi เป็นแพ็กเกจธีมสำหรับ Ursa ที่ได้รับแรงบันดาลใจจาก Semi Design คุณสามารถเพิ่มมันในโปรเจกต์ของคุณตามขั้นตอนต่อไปนี้

เพิ่ม nuget package:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

เพิ่ม Styles ในแอปพลิเคชัน:
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


ขณะนี้คุณสามารถใช้คอนโทรลของ Ursa ในแอปพลิเคชัน Avalonia ของคุณได้แล้ว
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



## จรรยาบรรณ

โปรเจกต์นี้ได้นำจรรยาบรรณที่กำหนดโดย Contributor Covenant มาใช้ เพื่อชี้แจงพฤติกรรมที่คาดหวังในชุมชนของเรา
ดูข้อมูลเพิ่มเติมได้ที่ [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct)

## ประกาศความเข้ากันได้
ขณะนี้ Ursa สามารถใช้งานร่วมกับ Avalonia 11.1.x และ 11.2.x ได้ แต่ไม่รองรับ Avalonia 11.2.0 โดยเฉพาะ

## ส่วนขยาย

### Prism Extension
หากคุณต้องการผสานรวม Ursa เข้ากับ Prism.Avalonia คุณสามารถใช้แพ็กเกจ Irihi.Ursa.PrismExtension แพ็กเกจนี้ให้บริการเกี่ยวกับ Dialog เพื่อใช้งาน Ursa Dialogs ร่วมกับ Prism

### ReactiveUI Extension
หากต้องการผสานรวม Ursa กับ Avalonia.ReactiveUI คุณสามารถใช้แพ็กเกจ Irihi.Ursa.ReactiveUIExtension แพ็กเกจนี้มีการใช้งาน UrsaWindow และ UrsaView เวอร์ชัน ReactiveUI กรุณาดูรายละเอียดที่ [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension)

## การสนับสนุน

เรามีการสนับสนุนจากชุมชนแบบจำกัดสำหรับ Semi Avalonia และ Ursa กรุณาเข้าร่วมกลุ่มของเราผ่าน FeiShu(Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---