# Microsoft PowerToys

![Microsoft PowerToys için Kahraman görseli](doc/images/overview/PT_hero_image.png)

[PowerToys nasıl kullanılır][usingPowerToys-docs-link] | [İndirmeler & Sürüm notları][github-release-link] | [PowerToys’a Katkıda Bulunma](#contributing) | [Neler Oluyor?](#whats-happening) | [Yol Haritası](#powertoys-roadmap)

## Hakkında

Microsoft PowerToys, ileri düzey kullanıcıların Windows deneyimlerini verimlilik için ayarlamalarını ve optimize etmelerini sağlayan bir yardımcı programlar setidir. [PowerToys genel bakışları ve yardımcı programların nasıl kullanılacağı][usingPowerToys-docs-link] hakkında daha fazla bilgi almak veya [Windows geliştirme ortamları](https://learn.microsoft.com/windows/dev-environment/overview) için diğer araç ve kaynaklara ulaşmak için [learn.microsoft.com][usingPowerToys-docs-link] adresine göz atabilirsiniz!

|              | Mevcut yardımcı programlar: |              |
|--------------|----------------------------|--------------|
| [Gelişmiş Yapıştırma](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Her Zaman Üstte](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Uyanık](https://aka.ms/PowerToysOverview_Awake) |
| [Renk Seçici](https://aka.ms/PowerToysOverview_ColorPicker) | [Komut Bulunamadı](https://aka.ms/PowerToysOverview_CmdNotFound) | [Komut Paleti](https://aka.ms/PowerToysOverview_CmdPal) |
| [Kırp ve Kilitle](https://aka.ms/PowerToysOverview_CropAndLock) | [Ortam Değişkenleri](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [Dosya Gezgini Eklentileri](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [Dosya Kilitleyici](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts Dosyası Düzenleyici](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Resim Boyutlandırıcı](https://aka.ms/PowerToysOverview_ImageResizer) | [Klavye Yöneticisi](https://aka.ms/PowerToysOverview_KeyboardManager) | [Fare yardımcıları](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Sınırlar Olmadan Fare](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [Yeni+](https://aka.ms/PowerToysOverview_NewPlus) | [Düz Metin Olarak Yapıştır](https://aka.ms/PowerToysOverview_PastePlain) |
| [Önizleme](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Hızlı Aksan](https://aka.ms/PowerToysOverview_QuickAccent) | [Kayıt Defteri Önizlemesi](https://aka.ms/PowerToysOverview_RegistryPreview) | [Ekran Cetveli](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Kısayol Rehberi](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Metin Ayıklayıcı](https://aka.ms/PowerToysOverview_TextExtractor) | [Çalışma Alanları](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Microsoft PowerToys Kurulumu ve Çalıştırılması

### Gereksinimler

- Windows 11 veya Windows 10 sürüm 2004 (kod adı 20H1 / derleme numarası 19041) veya daha yenisi.
- x64 veya ARM64 işlemci
- Yükleyicimiz aşağıdaki öğeleri kuracaktır:
   - [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703) yükleyicisi. En son sürüm yüklenecektir.

### GitHub üzerinden EXE ile [Önerilen]

[Microsoft PowerToys GitHub sürümleri sayfasına][github-release-link] gidin ve sürümdeki kullanılabilir dosyaları görmek için en alttaki `Assets`'e tıklayın. Lütfen makinenizin mimarisi ve kurulum kapsamına uygun PowerToys yükleyicisini kullanın. Çoğu kullanıcı için `x64` ve kullanıcı başına kurulum yeterlidir.

<!-- sürüme özel güncellenmesi gereken öğeler -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  Açıklama     | Dosya Adı | sha256 hash |
|---------------|-----------|-------------|
| Kullanıcı başına - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Kullanıcı başına - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Tüm makine için - x64   | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Tüm makine için - ARM64 | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

Bu bizim tercih ettiğimiz yöntemdir.

### Microsoft Store Üzerinden

[Microsoft Store'un PowerToys sayfasından][microsoft-store-link] yükleyin. [Yeni Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) kullanıyor olmalısınız; bu hem Windows 11 hem de Windows 10 için mevcuttur.

### WinGet ile
PowerToys’u [WinGet][winget-link] ile indirin. Winget üzerinden PowerToys’u güncellemek, mevcut PowerToys kurulum kapsamına sadık kalacaktır. PowerToys’u yüklemek için komut satırı / PowerShell’den aşağıdaki komutu çalıştırın:

#### Kullanıcı kapsamlı yükleyici [varsayılan]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Makine genelinde yükleyici

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Diğer yükleme yöntemleri

[Topluluk tarafından desteklenen yükleme yöntemleri](./doc/unofficialInstallMethods.md) de mevcuttur (örn. Chocolatey ve Scoop). Tercihiniz bu tür kurulumlardan yanaysa, kurulum talimatlarını ilgili bağlantılarda bulabilirsiniz.

## Üçüncü Taraf Run Eklentileri

Topluluk tarafından oluşturulan ve PowerToys ile dağıtılmayan [üçüncü taraf eklentiler](./doc/thirdPartyRunPlugins.md) koleksiyonu bulunmaktadır.

## Katkıda Bulunma

Bu proje her türlü katkıya açıktır. Kodlama (özellikler / hata düzeltmeleri) dışında, spesifikasyon yazımı, tasarım, dokümantasyon ve hata bulma gibi birçok konuda da yardımcı olabilirsiniz. Güçlü kullanıcı topluluğuyla birlikte çalışarak Windows’tan en iyi şekilde yararlanmanızı sağlayacak bir araç seti geliştirmekten heyecan duyuyoruz.

**Katkıda bulunmak istediğiniz bir özelliği geliştirmeye başlamadan önce**, lütfen [Katılımcı Rehberimizi](CONTRIBUTING.md) okuyun. En iyi yaklaşımı belirlemede, geliştirme boyunca rehberlik ve mentorluk sağlamada ve gereksiz veya yinelenen çalışmaları önlemede size yardımcı olmaktan memnuniyet duyarız.

Çoğu katkı, bize katkınızı kullanma haklarını verdiğinizi ve bunu yapmak için izniniz olduğunu beyan eden bir [Katılımcı Lisans Sözleşmesi’ni (CLA)][oss-CLA] kabul etmenizi gerektirir.

PowerToys için geliştirme rehberliği için, [geliştirici dokümanlarını](/doc/devdocs) ayrıntılı bir şekilde inceleyebilirsiniz. Bilgisayarınızı derleme için nasıl hazırlayacağınız da burada açıklanmıştır.

## Neler Oluyor?

### PowerToys Yol Haritası

Çekirdek ekibin odaklandığı öncelikli [yol haritası][roadmap] ve özellikler/yardımcı programlar listemiz.

### 0.91 - Mayıs 2025 Güncellemesi

Bu sürümde, yeni özellikler, kararlılık ve otomasyona odaklandık.

**✨Öne Çıkanlar**

 - Komut Paleti’nin performansında büyük iyileştirmeler yaptık ve birçok hatayı düzelttik. Eklediğimiz bazı yeni özellikler:
 - Komut Paleti’nin herhangi bir dosyayı bir yedek komutla arayabilme yeteneği eklendi.
 - Komut Paleti’nin genel kısayol tuşunu düşük seviyeli klavye kancası olarak ayarlama yeteneği eklendi.
 - WebSearch uzantısı için açık URL yedek komutu eklendi, böylece kullanıcılar Komut Paleti’nden doğrudan tarayıcıda URL açabiliyor.
 - PT Run ve Komut Paleti’nin Tarih ve Saat eklentilerinde özel biçimler tanımlayabilirsiniz. Teşekkürler [@htcfreek](https://github.com/htcfreek)!

### Gelişmiş Yapıştırma

 - Gelişmiş Yapıştırma, belirli İngilizce dil etiketleri (örn. en-CA) için OCR motoru oluşturamadığında, kullanıcı profil diliyle başlatarak bu sorun düzeltildi. Teşekkürler [@cryolithic](https://github.com/cryolithic)!

### Renk Seçici

 - Grafik nesnesinin düzgün şekilde atılmaması nedeniyle oluşan kaynak sızıntısı sorununu düzelterek donma veya çökme durumları giderildi. Teşekkürler [@dcog989](https://github.com/dcog989)!
 - Renk Seçici’nin Geri Al tuşuna basıldığında kapanmasına neden olan sorun, yalnızca odaklanıldığında kapanacak şekilde ve Escape/Backspace davranışı hizalanarak düzeltildi. Teşekkürler [@PesBandi](https://github.com/PesBandi)!
 - Renk Seçici’ye Oklab ve Oklch renk formatları desteği eklendi. Teşekkürler [@lemonyte](https://github.com/lemonyte)!

### Komut Bulunamadı

 - WinGet Komut Bulunamadı betiği, yalnızca gerçekten mevcutsa deneysel özellikleri etkinleştirecek şekilde güncellendi.

### Komut Paleti

 - Hata şablonu Komut Paleti modülünü kapsayacak şekilde güncellendi.
 - Bildirim penceresinin DPI için ölçeklenmemesi nedeniyle oluşan yerleşim sorunları düzeltildi.
 - Yukarı/Aşağı klavye navigasyonunun, imleç konumu 0'dayken seçimi hareket ettirmemesi ve PT Run v1'deki gibi sürekli navigasyonun eklenmesi düzeltildi. Teşekkürler [@davidegiacometti](https://github.com/davidegiacometti)!
 - Zaman ve Tarih uzantısı kodu basitleştirildi ve açıklık artırıldı.
 - Komutta büyük harf kullanımı nedeniyle fare imlecine gitme işleminin başarısız olması sorunu, komutun küçük harfe çevrilmesiyle giderildi.
 - WebSearch uzantısı için açık URL yedek komutu eklendi, böylece kullanıcılar Komut Paleti’nden doğrudan tarayıcıda URL açabiliyor. Teşekkürler [@htcfreek](https://github.com/htcfreek)!
 - CmdPal’de sistem tepsi simgesini etkinleştirme/devre dışı bırakma ayarı ve terimlerin Windows 11 ile uyumlu olacak şekilde güncellenmesi eklendi. Teşekkürler [@davidegiacometti](https://github.com/davidegiacometti)!
 - Eski takma ad kaldırılarak yeni takma ad ayarlandığında oluşan takma ad güncelleme sorunu giderildi.
 - GitHub büyük-küçük harf çakışmaları, Exts ve exts’in yeni ext dizinine taşınmasıyla çözüldü; platformlar arası tutarlılık sağlandı ve yol parçalanması engellendi.
 - 'Yeni Uzantı Oluştur' komutu boş dosya adları oluşturduğunda ortaya çıkan sorun düzeltildi.
 - Genel kısayol tuşunu düşük seviyeli klavye kancası olarak ayarlama yeteneği eklendi.
 - JUMBO küçük resim desteği eklendi, yüksek çözünürlüklü simgelere erişim sağlandı.
 - CmdPal kendini otomatik gizlerken MSAL diyaloğu açıkken oluşan çökme önlendi; CmdPal devre dışıyken gizlenmesi engellendi.
 - Sayfa yüklendiğinde arama metninin hemen seçilmesi desteği eklendi.
 - Uzantı ayarları sayfalarının yeniden açıldığında yenilenmemesi sorunu, ayar formunun güncellenmesiyle giderildi.
 - Komut Paleti'nin koşucudan başlatılamaması sorunu düzeltildi.
 - PowerToys Run v1 hesap makinesi mantığı Komut Paleti'ne aktarıldı, ayar desteği eklendi ve yedek davranışı iyileştirildi.
 - Liste öğesi klavye kısayolları desteği yeniden eklendi.
 - Komut Paleti'nde erişilebilirlik geliştirildi: uygun etiketler, animasyonlar, yerelleştirme ve a11y ile ilgili sorunlar düzeltildi.
 - Özel biçim desteği Time and Date eklentisine aktarıldı, ayarlar yeniden düzenlendi ve hata mesajları iyileştirildi, uç durum çökme sorunları düzeltildi. Teşekkürler [@htcfreek](https://github.com/htcfreek)!
 - Sistem komutu için yedek öğe eklendi.
 - Windows Sistem Komutu'nda "Geri Dönüşüm Kutusunu Aç" eylemi için anahtar isteminin yanlış şekilde "Boş" olarak görünmesine neden olan hata düzeltildi. Teşekkürler [@jironemo](https://github.com/jironemo)!
 - 'Daha fazla komut' listesinde görünmemesi gereken komutların görünmesine neden olan hata düzeltildi. Teşekkürler [@davidegiacometti](https://github.com/davidegiacometti)!
 - Komut Paleti detaylar görünümünde simgenin çok büyük ve metnin hizasız görünmesine neden olan hata düzeltildi, Windows Search davranışı ile hizalandı.
 - Uzun etiketler kullanıldığında boş ekran içeriğinin ve komut çubuğu komutlarının kesilmesine neden olan hata düzeltildi, uygun yerleşim ve görünürlük sağlandı.
 - CmdPal’in WinGet entegrasyonu iyileştirildi: kurulu paketler için sürüm gösterimi düzeltildi, simgelerle güncellemeler etkinleştirildi, önizleme winget API kararlı sürüme geçirildi.
 - ContentPage komutlarının çıkıştan sonra güncellenmemesi sorunu, bağlam menülerinin değiştiğinde tam olarak başlatılmasıyla giderildi.
 - TimeDate uzantısına yedek komut desteği eklendi, doğrudan tarih/saat sorguları yapılabiliyor.
 - CmdPal proje dosyalarında Common.Dotnet.AotCompatibility.props içe aktarıldı, AOT derleme desteği artırıldı.
 - CmdPal ayarlarında, ayar.json eksikse veya tanımlı bir kısayol yoksa oluşan HotKey null hatası düzeltildi. Teşekkürler [@davidegiacometti](https://github.com/davidegiacometti)!
 - CmdPal’de filtrelenebilir, iç içe bağlam menüleri ve odak davranışını koruyan arama kutusu desteği eklendi.
 - CmdPal sınıfları yeniden düzenlendi, JSON serileştirme iyileştirildi ve yeni serileştirme bağlamları eklendi.
 - Önceden derlenmiş (AoT) derleme desteği eklendi.
 - CmdPal başlatma için tekrar deneme mekanizması eklendi.
 - Kod tabanını basitleştirmek ve AoT uyumluluğu için CmdPal.Common’dan bazı kullanılmayan dosyalar kaldırıldı.
 - SearchText güncellemesindeki yarış durumu nedeniyle giriş kutusunda imlecin satır sonuna atlamasına neden olan hata düzeltildi; SearchText yalnızca gerçekten değiştiğinde güncelleniyor.
 - Yedek komutta herhangi bir dosyanın aranması desteği eklendi.
 - AoT ile ilgili kodlar temizlendi, test sırasında yinelenen işlemler önlendi.
 - CmdPal yükleme süresi, uzantı başlatmalarının paralel yapılması ve yanlış çalışan uzantıların diğerlerini engellemesini önlemek için zaman aşımı eklenerek azaltıldı.
 - Liste boşaldığında detay panelinin kapatılmasıyla UI davranışı iyileştirildi, tutarsız görsel durumlar önlendi.
 - Eşleşen komut bulunmadığında CmdPal’de yedek komutun kaldırılması desteği eklendi, daha temiz yüklenme davranışı sağlandı.
 - CmdPal uzantı şablonundaki sızıntı, yanlış ComServer kullanımı düzeltilerek giderildi.
 - CmdPal penceresinin başlık çubuğuna çift tıklandığında maksimize olmasının önüne geçildi. Teşekkürler [@davidegiacometti](https://github.com/davidegiacometti)!
 - Ayarlar UI’nın çok küçük başlatılması sorunu, pencere boyutlarının DPI’ya duyarlı yapılması ve minimum genişlik/yükseklik zorunluluğu ile düzeltildi.
 - CmdPal’deki beyaz flaş ve tek seferlik animasyon sorunları, pencerenin gizlenmesi yerine örtülmesiyle giderildi.
 - Tüm uzantı ayarlarının başlangıçta alınması sorunu, uzantı ayarlarının tembel yüklenmesiyle giderildi, başlatma yükü azaltıldı.
 - CmdPal’de Adaptive Card ayrıştırma hatasında çökmeden koruma desteği eklendi.
 - CmdPal’de shell:AppsFolder yerine URI etkinleştirme kullanıldı, güvenilirlik artırıldı.
 - CmdPal ayarlarının PowerToys Ayarları’ndan açılması desteği eklendi.
 - CmdPal’in uzantı detaylarını izleyip dinamik olarak güncellemesi sağlandı.
 - CmdPal uzantı şablonunda toolkit sürümü 0.2.0’a yükseltildi.

### Resim Boyutlandırıcı

 - Bir Resim Boyutlandırıcı ön ayarı silindiğinde yanlış ön ayarın silinmesi sorunu düzeltildi.

### Klavye Yöneticisi

 - Sol veya sağ olarak belirtilmeden ayarlanan bir değiştirici tuşun, yanlış tuş işlemesi nedeniyle takılı kalması sorunu; basılan tuşları izleyip doğru tuşu göndererek giderildi. Teşekkürler [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - PowerRename’ın saat biçimlendirme yetenekleri geliştirilerek AM/PM destekli 12 saatlik zaman biçimi desenleri eklendi. Teşekkürler [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - "Saat ve Tarih" eklentisine özel biçim desteği eklendi ve geçersiz giriş biçimleri için hata mesajları iyileştirildi. Teşekkürler [@htcfreek](https://github.com/htcfreek)!
 - WFT'nin çok erken tarihlerde çökmesine ve ayın haftasının çok geç tarihlerde (örn. 31.12.9999) hesaplanmasında oluşan iki çökme düzeltildi, UI ayarları yeniden düzenlendi. Teşekkürler [@htcfreek](https://github.com/htcfreek)!
 - Komutta büyük harf kullanımı nedeniyle fare imlecine gitme işleminin başarısız olması sorunu, komutun küçük harfe çevrilmesiyle giderildi.
 - 'Yükleme hatası' ve 'Başlatma hatası' için eklenti hata mesajlarına sürüm detayları eklendi. Teşekkürler [@htcfreek](https://github.com/htcfreek)!
 - Sonuç modeli geliştirilerek kullanım tabanlı sıralamanın engellenmesi desteği eklendi, eklenti geliştiricilerine sıralama davranışı üzerinde daha fazla kontrol sağlandı. Teşekkürler [@CoreyHayward](https://github.com/CoreyHayward) ve [@htcfreek](https://github.com/htcfreek)!

### Hızlı Aksan

 - GetDefaultLetterKeyEPO'daki harf eşlemesi güncellendi, VK_U tuşu için "ǔ" yerine Esperanto fonetiğine uygun "ŭ" getirildi. Teşekkürler [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - Hızlı Aksan'ın ekran klavyesi kullanılırken düzgün çalışmaması sorunu düzeltildi. Teşekkürler [@davidegiacometti](https://github.com/davidegiacometti)!

### Kayıt Defteri Önizlemesi

 - Kayıt Defteri Önizlemesi, dosya başlığı elle yazılmadan kayıt anahtarı ve değerlerinin yapıştırılmasını destekleyecek şekilde geliştirildi ve uygulamayı sıfırlamak için yeni bir düğme eklendi. Teşekkürler [@htcfreek](https://github.com/htcfreek)!

### Ayarlar

 - Ayarlar uygulamasının görev çubuğunda rastgele boş simge göstermesine neden olan sorun, simge ataması pencere etkinleştirilene kadar ertelenerek düzeltildi.
 - "Yenilikler" penceresinin daha rahat okunabilmesi için pencereyi büyütme (maksimize) özelliği eklendi.

### Çalışma Alanları

 - Steam oyunlarının doğru şekilde yakalanmaması veya başlatılamaması sorunları, pencere filtrelemesi güncellenerek ve Steam URL protokol entegrasyonu ile giderildi.

### Dokümantasyon

 - PowerToys Run için üçüncü taraf eklenti dokümantasyonuna QuickNotes eklendi. Teşekkürler [@ruslanlap](https://github.com/ruslanlap)!
 - PowerToys Run üçüncü taraf eklenti dokümantasyonuna Hava Durumu ve Pomodoro eklentileri eklendi. Teşekkürler [@ruslanlap](https://github.com/ruslanlap)!
 - PowerToys Run üçüncü taraf eklenti dokümantasyonuna Linear eklentisi eklendi. Teşekkürler [@vednig](https://github.com/vednig)!
 - Dokümantasyon dosyalarındaki biçimlendirme sorunları düzeltildi ve katkıda bulunanlar ile ekip üyeleri bilgileri güncellendi. Teşekkürler [@DanielEScherzer](https://github.com/DanielEScherzer) ve [@RokyZevon](https://github.com/RokyZevon)!

### Geliştirme

 - GitHub Action, MSStore sürüm desteği için .NET 9 kuracak şekilde güncellendi.
 - bug_report.yml dosyasında sürüm yer tutucu güncellendi, yanlış v0.70.0 sürüm bildirimlerinin önüne geçildi.
 - GitHub Action, MSStore sürümü için actions/setup-dotnet sürüm 3’ten 4’e yükseltildi.
 - WinGet yapılandırma dosyalarına securityContext eklendi, kullanıcı bağlamından çağrıya ve ayrı bir süreçte yükseltilmiş kaynaklar için tek bir UAC istemine izin verildi. Teşekkürler [@mdanish-kh](https://github.com/mdanish-kh)!
 - Günlük dosyası uzantıları .txt’den .log’a değiştirildi, uygun dosya ilişkilendirmesi ve araç uyumluluğu sağlandı, Workspace için günlükler eklendi. Teşekkürler [@benwa](https://github.com/benwa)!
 - Test çerçevesi bağımlılıkları yükseltildi ve bileşenler arasında paket sürümleri hizalandı.
 - Bağımlılıklar yükseltildi, güvenlik açıkları giderildi.
 - Depo güvenliği, GitHub Actions ve Docker etiketlerinin tam uzunlukta değiştirilemez commit’lere sabitlenmesi ve Dependency Review Workflow ile otomatik bağımlılık güvenlik taramasının entegre edilmesiyle geliştirildi. Teşekkürler [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Boost bağımlılıkları daha yeni bir sürüme yükseltildi.
 - Araç seti en son sürüme yükseltildi, AoT ile ilgili uyarılar bastırıldı.
 - Yeni eklenen dosyaların imzası eksik olduğunda oluşan derleme hataları giderildi.
 - 100 yıl boyunca özel sembollerin yayımlanmasını önlemek için sürüm yayın hattı güncellendi.
 - PowerRename için fuzzing tanıtıldı, güvenilirlik artırıldı ve diğer C++ modüllerine genişletmek için kurulum rehberi eklendi.
 - Tüm .csproj projeleri için oluşturulan klasörlerin merkezi ön oluşturulması eklendi, derleme hatalarının önüne geçildi.
 - WinAppSDK en yeni 1.7 sürümüne güncellendi.
 - PowerRename Fuzzing projesi için Boost bağımlılıkları en güncel sürüme yükseltildi.
 - tsa.json dosyasında ADO alan yolu güncellendi, eski yolun neden olduğu TSA boru hattı hataları giderildi.
 - CmdPal için AoT desteği başlatıldı, temel çalışmalar devam ediyor.
  
### Araç/Genel

 - Sistem ve tanı bilgileriyle önceden doldurulmuş GitHub issue URL'si oluşturarak hata raporu oluşturmayı otomatikleştirme desteği eklendi. Teşekkürler [@donlaci](https://github.com/donlaci)!
 - Yükleyiciyi yerel olarak derlemek için betikler eklendi, CmdPal’in yerel ortamda da başlatılmasını sağladı.
 - Sabitlenmiş parola kullanımını ortadan kaldırmak ve PSScriptAnalyzer güvenlik uyarısını çözmek için export PFX mantığı kaldırıldı.
 - src klasörü altındaki tüm C# projelerinde Common.Dotnet.CsWinRT.props’ın tutarlı kullanımını zorunlu kılan PowerShell betiği ve CI entegrasyonu eklendi.
   
### 0.92 sürümünde neler planlanıyor

[v0.92][github-next-release-work] için aşağıdaki işlere odaklanacağız:

 - Komut Paleti cilalamaya devam
 - Yeni UI Otomasyon testleri
 - Yükleyici yükseltmeleri üzerinde çalışma
 - Klavye Yöneticisi editör UI'sinin yükseltilmesi
 - Kararlılık / hata düzeltmeleri

## PowerToys Topluluğu

PowerToys ekibi, [harika ve aktif bir topluluğun desteğine][community-link] sahip olduğu için son derece minnettardır. Yaptığınız çalışmalar çok önemli. PowerToys, hata bildirimleriniz, dokümantasyon güncellemeleriniz, tasarım rehberliğiniz veya özellik yazımlarınız olmasaydı bugünkü haline gelemezdi. Teşekkür etmek ve katkılarınızı takdir etmek istiyoruz. Her ay, PowerToys’u daha iyi bir yazılım haline getiriyorsunuz.

## Davranış Kuralları

Bu proje [Microsoft Açık Kaynak Davranış Kuralları’nı][oss-conduct-code] benimsemiştir.

## Gizlilik Bildirimi

Uygulama, temel tanı verilerini (telemetri) kaydeder. Gizlilik ve hangi verileri topladığımız hakkında daha fazla bilgi için [PowerToys Veri ve Gizlilik dokümanımıza](https://aka.ms/powertoys-data-and-privacy-documentation) bakabilirsiniz.

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