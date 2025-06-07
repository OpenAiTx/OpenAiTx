**Bu GitHub deposu (<https://github.com/Genymobile/scrcpy>) projenin tek resmi
kaynağıdır. Adında `scrcpy` geçse bile, rastgele web sitelerinden sürümler
indirmeyin.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_"**scr**een **c**o**py**" olarak telaffuz edilir_

Bu uygulama, USB veya [TCP/IP](doc/connection.md#tcpip-wireless) ile bağlı olan Android cihazları (video ve ses) bilgisayar ekranına yansıtır ve klavye ve fare ile kontrol etmeye olanak tanır. Cihazda _root_ erişimi veya bir uygulama kurulumu gerektirmez. _Linux_, _Windows_ ve _macOS_ üzerinde çalışır.

![ekran görüntüsü](assets/screenshot-debian-600.jpg)

Odak noktaları:

 - **hafiflik**: yerel, yalnızca cihaz ekranını gösterir
 - **performans**: cihaza bağlı olarak 30~120fps
 - **kalite**: 1920×1080 veya üstü
 - **düşük gecikme**: [35~70ms][lowlatency]
 - **düşük başlatma süresi**: ilk görüntüyü göstermek için ~1 saniye
 - **girişimsizlik**: Android cihazda hiçbir şey kalmaz
 - **kullanıcı avantajları**: hesap yok, reklam yok, internet gerekmez
 - **özgürlük**: ücretsiz ve açık kaynak kodlu yazılım

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

Özellikleri şunları içerir:
 - [ses yönlendirme](doc/audio.md) (Android 11+)
 - [kayıt](doc/recording.md)
 - [sanal ekran](doc/virtual_display.md)
 - [Android cihaz ekranı kapalıyken](doc/device.md#turn-screen-off) yansıtma
 - Her iki yönde de [kopyala-yapıştır](doc/control.md#copy-paste)
 - [Yapılandırılabilir kalite](doc/video.md)
 - [Kamera yansıtma](doc/camera.md) (Android 12+)
 - [Webcam olarak yansıtma (V4L2)](doc/v4l2.md) (sadece Linux)
 - Fiziksel [klavye][hid-keyboard] ve [fare][hid-mouse] simülasyonu (HID)
 - [Gamepad](doc/gamepad.md) desteği
 - [OTG modu](doc/otg.md)
 - ve daha fazlası…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Önkoşullar

Android cihazınızda en az API 21 (Android 5.0) gereklidir.

[Ses yönlendirme](doc/audio.md) API >= 30 (Android 11+) için desteklenmektedir.

Cihazınızda [USB hata ayıklamayı etkinleştirdiğinizden][enable-adb] emin olun.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

Bazı cihazlarda (özellikle Xiaomi), aşağıdaki hatayı alabilirsiniz:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

Bu durumda, cihazı klavye ve fare ile kontrol edebilmek için [ek bir seçeneği][control] `USB hata ayıklama (Güvenlik Ayarları)` (bu, `USB hata ayıklama`dan farklı bir öğedir) etkinleştirmeniz gerekir. Bu seçeneği ayarladıktan sonra cihazı yeniden başlatmak gereklidir.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

scrcpy'yi [OTG modunda](doc/otg.md) çalıştırmak için USB hata ayıklama gerekmediğini unutmayın.

## Uygulamayı edinin

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) ([nasıl çalıştırılır](doc/windows.md#run) bölümünü okuyun)
 - [macOS](doc/macos.md)

## Bilinmesi Gereken İpuçları

 - [Çözünürlüğü düşürmek](doc/video.md#size) performansı büyük ölçüde artırabilir
   (`scrcpy -m1024`)
 - [_Sağ tıklama_](doc/mouse.md#mouse-bindings) `GERİ` komutunu tetikler
 - [_Orta tıklama_](doc/mouse.md#mouse-bindings) `ANA EKRAN` komutunu tetikler
 - <kbd>Alt</kbd>+<kbd>f</kbd> [tam ekranı](doc/window.md#fullscreen) açıp kapatır
 - Birçok [kısayol](doc/shortcuts.md) daha vardır

## Kullanım örnekleri

Çok sayıda seçenek vardır, bunlar [belgelenmiştir](#user-documentation). Aşağıda yaygın bazı örnekler verilmiştir.

 - Ekranı H.265 ile (daha iyi kalite), boyutu 1920 ile sınırlayarak, kare hızını 60fps ile sınırlayarak, sesi devre dışı bırakarak ve fiziksel klavye simülasyonu ile kontrol ederek yakalayın:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # kısa sürüm
    ```

 - VLC'yi yeni bir sanal ekranda (cihaz ekranından ayrı) başlatın:

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Cihaz kamerasını H.265 ile 1920x1080 (ve mikrofon ile) bir MP4 dosyasına kaydedin:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Cihazın ön kamerasını yakalayın ve bilgisayarda webcam olarak kullanın (Linux'ta):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Yansıtma yapmadan, fiziksel klavye ve fare simülasyonu ile cihazı kontrol edin (USB hata ayıklama gerekmez):

    ```bash
    scrcpy --otg
    ```

 - Bilgisayara takılan gamepad kontrolcüleriyle cihazı kontrol edin:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # kısa sürüm
    ```

## Kullanıcı dokümantasyonu

Uygulama çok sayıda özellik ve yapılandırma seçeneği sunar. Bunlar aşağıdaki sayfalarda belgelenmiştir:

 - [Bağlantı](doc/connection.md)
 - [Video](doc/video.md)
 - [Ses](doc/audio.md)
 - [Kontrol](doc/control.md)
 - [Klavye](doc/keyboard.md)
 - [Fare](doc/mouse.md)
 - [Gamepad](doc/gamepad.md)
 - [Cihaz](doc/device.md)
 - [Pencere](doc/window.md)
 - [Kayıt](doc/recording.md)
 - [Sanal ekran](doc/virtual_display.md)
 - [Tüneller](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Kamera](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Kısayollar](doc/shortcuts.md)

## Kaynaklar

 - [SSS](FAQ.md)
 - [Çeviriler][wiki] (güncel olmayabilir)
 - [Derleme talimatları](doc/build.md)
 - [Geliştiriciler](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki

## Makaleler

- [scrcpy tanıtımı][article-intro]
- [Scrcpy artık kablosuz çalışıyor][article-tcpip]
- [Scrcpy 2.0, ses ile][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## İletişim

Hata raporları, özellik talepleri veya genel sorular için bir [issue] açabilirsiniz.

Hata raporları için lütfen önce [SSS](FAQ.md) bölümünü okuyun, sorununuzun çözümünü hemen bulabilirsiniz.

[issue]: https://github.com/Genymobile/scrcpy/issues

Şunları da kullanabilirsiniz:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)

## Bağış Yapın

Ben [@rom1v](https://github.com/rom1v), _scrcpy_'nin yazarı ve bakımcısıyım.

Bu uygulamayı beğendiyseniz, [açık kaynak çalışmamı][donate] destekleyebilirsiniz:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Lisans

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Bu dosya yalnızca Apache Lisansı, Sürüm 2.0 ("Lisans") kapsamında
    kullanılabilir; Lisans dışında kullanılamaz.
    Lisansı şu adresten edinebilirsiniz:

        http://www.apache.org/licenses/LICENSE-2.0

    Yürürlükteki yasalar gerektirmedikçe veya yazılı olarak belirtilmedikçe,
    bu yazılım "OLDUĞU GİBİ" dağıtılır, açık veya örtük hiçbir garanti verilmez.
    Lisans kapsamındaki izinler ve sınırlamalar için Lisansa bakınız.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---