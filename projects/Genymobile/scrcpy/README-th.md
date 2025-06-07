**ที่เก็บ GitHub นี้ (<https://github.com/Genymobile/scrcpy>) เป็นแหล่งทางการเดียวของโครงการนี้ กรุณาอย่าดาวน์โหลดไฟล์เผยแพร่จากเว็บไซต์สุ่ม แม้ว่าในชื่อนั้นจะมีคำว่า `scrcpy` ก็ตาม**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_อ่านออกเสียงว่า "**scr**een **c**o**py**"_

แอปพลิเคชันนี้ใช้สำหรับมิเรอร์อุปกรณ์ Android (วิดีโอและเสียง) ที่เชื่อมต่อผ่าน USB หรือ [TCP/IP](doc/connection.md#tcpip-wireless) และสามารถควบคุมได้ด้วยคีย์บอร์ดและเมาส์ของคอมพิวเตอร์ โดยไม่ต้องใช้สิทธิ์ _root_ หรือแอปพลิเคชันติดตั้งไว้ในอุปกรณ์ สามารถใช้งานได้บน _Linux_, _Windows_, และ _macOS_

![screenshot](assets/screenshot-debian-600.jpg)

จุดเด่นหลัก:

 - **เบา:** ทำงานแบบ native แสดงเฉพาะหน้าจออุปกรณ์
 - **ประสิทธิภาพ:** 30~120fps ขึ้นอยู่กับอุปกรณ์
 - **คุณภาพ:** 1920×1080 หรือสูงกว่า
 - **ความหน่วงต่ำ:** [35~70ms][lowlatency]
 - **เริ่มต้นเร็ว:** ~1 วินาทีเพื่อแสดงภาพแรก
 - **ไม่ทิ้งร่องรอย:** ไม่มีอะไรติดตั้งทิ้งไว้ในอุปกรณ์ Android
 - **เป็นมิตรกับผู้ใช้:** ไม่ต้องสมัคร ไม่มีโฆษณา ไม่ต้องใช้อินเทอร์เน็ต
 - **เสรีภาพ:** ฟรีและโอเพ่นซอร์ส

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

คุณสมบัติที่มี ได้แก่:
 - [ส่งต่อเสียง](doc/audio.md) (Android 11+)
 - [บันทึกวิดีโอ](doc/recording.md)
 - [หน้าจอเสมือน (Virtual display)](doc/virtual_display.md)
 - มิเรอร์โดย [ปิดหน้าจออุปกรณ์ Android](doc/device.md#turn-screen-off)
 - [คัดลอก-วาง](doc/control.md#copy-paste) ได้ทั้งสองทาง
 - [คุณภาพกำหนดเองได้](doc/video.md)
 - [มิเรอร์กล้อง](doc/camera.md) (Android 12+)
 - [มิเรอร์เป็นเว็บแคม (V4L2)](doc/v4l2.md) (เฉพาะ Linux)
 - จำลอง [คีย์บอร์ด][hid-keyboard] และ [เมาส์][hid-mouse] จริง (HID)
 - รองรับ [เกมแพด](doc/gamepad.md)
 - [โหมด OTG](doc/otg.md)
 - และอื่นๆ อีกมากมาย…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## ข้อกำหนดเบื้องต้น

อุปกรณ์ Android ต้องมี API อย่างน้อย 21 (Android 5.0)

[การส่งต่อเสียง](doc/audio.md) รองรับสำหรับ API >= 30 (Android 11+)

ตรวจสอบให้แน่ใจว่าคุณได้ [เปิดใช้งาน USB debugging][enable-adb] บนอุปกรณ์ของคุณ

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

ในบางอุปกรณ์ (โดยเฉพาะ Xiaomi) คุณอาจพบข้อผิดพลาดดังนี้:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

ในกรณีนี้ คุณต้องเปิด [ตัวเลือกเพิ่มเติม][control] `USB debugging (Security Settings)` (เป็นรายการที่ต่างจาก `USB debugging`) เพื่อควบคุมด้วยคีย์บอร์ดและเมาส์ หลังตั้งค่านี้แล้วต้องรีบูตอุปกรณ์หนึ่งครั้ง

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

โปรดทราบว่าไม่ต้องใช้ USB debugging หากใช้งาน scrcpy ใน [โหมด OTG](doc/otg.md)

## ดาวน์โหลดแอป

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (อ่าน [วิธีรัน](doc/windows.md#run))
 - [macOS](doc/macos.md)

## เคล็ดลับที่ควรรู้

 - [ลดความละเอียด](doc/video.md#size) อาจช่วยเพิ่มประสิทธิภาพได้มาก (`scrcpy -m1024`)
 - [_คลิกขวา_](doc/mouse.md#mouse-bindings) คือคำสั่ง `BACK`
 - [_คลิกกลาง_](doc/mouse.md#mouse-bindings) คือคำสั่ง `HOME`
 - <kbd>Alt</kbd>+<kbd>f</kbd> สลับ [โหมดเต็มจอ](doc/window.md#fullscreen)
 - มี [ปุ่มลัด](doc/shortcuts.md) อื่นๆ อีกมากมาย

## ตัวอย่างการใช้งาน

มีตัวเลือกมากมายซึ่ง [อธิบายไว้](#user-documentation) ในหน้าต่างๆ ต่อไปนี้คือตัวอย่างที่พบบ่อย

 - บันทึกหน้าจอเป็น H.265 (คุณภาพดีกว่า), จำกัดขนาด 1920, จำกัด frame rate ที่ 60fps, ปิดเสียง และควบคุมอุปกรณ์ด้วยการจำลองคีย์บอร์ดจริง:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # เวอร์ชันสั้น
    ```

 - เปิด VLC ในหน้าจอเสมือนใหม่ (แยกจากหน้าจออุปกรณ์):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - บันทึกวิดีโอกล้องอุปกรณ์เป็น H.265 ที่ 1920x1080 (รวมเสียงไมโครโฟน) เป็นไฟล์ MP4:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - จับภาพกล้องหน้าและเผยแพร่เป็นเว็บแคมบนคอมพิวเตอร์ (บน Linux):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - ควบคุมอุปกรณ์โดยไม่ต้องมิเรอร์ด้วยการจำลองคีย์บอร์ดและเมาส์จริง (ไม่ต้องใช้ USB debugging):

    ```bash
    scrcpy --otg
    ```

 - ควบคุมอุปกรณ์ด้วยจอยเกมที่เสียบกับคอมพิวเตอร์:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # เวอร์ชันสั้น
    ```

## เอกสารสำหรับผู้ใช้

แอปพลิเคชันนี้มีฟีเจอร์และตัวเลือกการตั้งค่ามากมาย ซึ่งอธิบายไว้ในหน้านี้:

 - [การเชื่อมต่อ](doc/connection.md)
 - [วิดีโอ](doc/video.md)
 - [เสียง](doc/audio.md)
 - [การควบคุม](doc/control.md)
 - [คีย์บอร์ด](doc/keyboard.md)
 - [เมาส์](doc/mouse.md)
 - [เกมแพด](doc/gamepad.md)
 - [อุปกรณ์](doc/device.md)
 - [หน้าต่าง](doc/window.md)
 - [การบันทึก](doc/recording.md)
 - [หน้าจอเสมือน](doc/virtual_display.md)
 - [Tunnels](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [กล้อง](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [ปุ่มลัด](doc/shortcuts.md)

## แหล่งข้อมูล

 - [FAQ](FAQ.md)
 - [การแปลภาษา][wiki] (อาจไม่อัปเดตเสมอไป)
 - [คำแนะนำการคอมไพล์](doc/build.md)
 - [สำหรับนักพัฒนา](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki

## บทความ

- [แนะนำ scrcpy][article-intro]
- [Scrcpy ใช้งานแบบไร้สายได้แล้ว][article-tcpip]
- [Scrcpy 2.0, พร้อมเสียง][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## ติดต่อ

คุณสามารถเปิด [issue] เพื่อรายงานบั๊ก ขอฟีเจอร์ หรือสอบถามทั่วไป

สำหรับรายงานบั๊ก โปรดอ่าน [FAQ](FAQ.md) ก่อน อาจเจอวิธีแก้ไขทันที

[issue]: https://github.com/Genymobile/scrcpy/issues

ช่องทางอื่นๆ:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)

## บริจาค

ฉันคือ [@rom1v](https://github.com/rom1v) ผู้พัฒนาและดูแล _scrcpy_

หากคุณชื่นชอบแอปนี้ คุณสามารถ [สนับสนุนงานโอเพ่นซอร์สของฉัน][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## สัญญาอนุญาต

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    อนุญาตภายใต้ Apache License, Version 2.0 ("สัญญาอนุญาต")
    คุณไม่สามารถใช้ไฟล์นี้นอกจากจะปฏิบัติตามเงื่อนไขของสัญญาอนุญาต
    คุณสามารถดูสำเนาของสัญญาอนุญาตได้ที่

        http://www.apache.org/licenses/LICENSE-2.0

    เว้นแต่กฎหมายจะกำหนดไว้ หรือมีข้อตกลงเป็นลายลักษณ์อักษร ซอฟต์แวร์นี้ถูกแจกจ่าย "ตามสภาพ" 
    โดยไม่มีการรับประกันใดๆ ไม่ว่าทางตรงหรือทางอ้อม
    โปรดดูรายละเอียดในสัญญาอนุญาตสำหรับข้อจำกัดและเงื่อนไขการใช้งาน

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---