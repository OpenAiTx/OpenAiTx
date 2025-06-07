![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Windows Terminal, Konsol ve Komut Satırı deposuna Hoş Geldiniz

<details>
  <summary><strong>İçindekiler</strong></summary>

- [Windows Terminal'ın kurulumu ve çalıştırılması](#installing-and-running-windows-terminal)
  - [Microsoft Store \[Tavsiye Edilen\]](#microsoft-store-recommended)
  - [Diğer kurulum yöntemleri](#other-install-methods)
    - [GitHub üzerinden](#via-github)
    - [Windows Paket Yöneticisi CLI (winget) ile](#via-windows-package-manager-cli-aka-winget)
    - [Chocolatey ile (resmi olmayan)](#via-chocolatey-unofficial)
    - [Scoop ile (resmi olmayan)](#via-scoop-unofficial)
- [Windows Terminal Canary'nin kurulumu](#installing-windows-terminal-canary)
- [Windows Terminal Yol Haritası](#windows-terminal-roadmap)
- [Terminal & Konsol Genel Bakış](#terminal--console-overview)
  - [Windows Terminal](#windows-terminal)
  - [Windows Konsol Host](#the-windows-console-host)
  - [Paylaşılan Bileşenler](#shared-components)
  - [Yeni Windows Terminal'in Oluşturulması](#creating-the-new-windows-terminal)
- [Kaynaklar](#resources)
- [SSS](#faq)
  - [Yeni Terminal'i derledim ve çalıştırdım, ama eskisi gibi görünüyor](#i-built-and-ran-the-new-terminal-but-it-looks-just-like-the-old-console)
- [Dokümantasyon](#documentation)
- [Katkıda Bulunma](#contributing)
- [Ekip ile İletişim](#communicating-with-the-team)
- [Geliştirici Rehberi](#developer-guidance)
- [Ön Koşullar](#prerequisites)
- [Kodun Derlenmesi](#building-the-code)
  - [PowerShell ile derleme](#building-in-powershell)
  - [Cmd ile derleme](#building-in-cmd)
- [Çalıştırma & Hata Ayıklama](#running--debugging)
  - [Kodlama Rehberi](#coding-guidance)
- [Davranış Kuralları](#code-of-conduct)

</details>

<br />

Bu depo şunların kaynak kodunu içerir:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Windows konsol host'u (`conhost.exe`)
* İki proje arasında paylaşılan bileşenler
* [ColorTool](./src/tools/ColorTool)
* [Örnek projeler](./samples)
  Windows Konsol API'larının nasıl kullanılacağını gösteren

İlgili depolar şunlardır:

* [Windows Terminal Dokümantasyonu](https://docs.microsoft.com/windows/terminal)
  ([Repo: Dokümanlara katkı yap](https://github.com/MicrosoftDocs/terminal))
* [Konsol API Dokümantasyonu](https://github.com/MicrosoftDocs/Console-Docs)
* [Cascadia Code Font](https://github.com/Microsoft/Cascadia-Code)

## Windows Terminal'ın kurulumu ve çalıştırılması

> [!NOTE]
> Windows Terminal, Windows 10 2004 (build 19041) veya daha yeni bir sürüm gerektirir

### Microsoft Store [Tavsiye Edilen]

[Windows Terminal'ı Microsoft Store'dan yükleyin][store-install-link].
Bu sayede yeni sürümler yayınlandığında otomatik güncellemelerle daima en güncel sürümü kullanırsınız.

Bu, tercih ettiğimiz yöntemdir.

### Diğer kurulum yöntemleri

#### GitHub üzerinden

Microsoft Store'dan Windows Terminal yükleyemeyen kullanıcılar için,
yayınlanan derlemeler bu deponun [Releases
sayfasından](https://github.com/microsoft/terminal/releases) manuel olarak indirilebilir.

**Assets** bölümünden `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` dosyasını indirin.
Uygulamayı yüklemek için `.msixbundle` dosyasına çift tıklayarak yükleyiciyi başlatabilirsiniz.
Herhangi bir nedenle bu çalışmazsa, PowerShell komut isteminde aşağıdaki komutu deneyebilirsiniz:

```powershell
# NOT: PowerShell 7+ kullanıyorsanız,
# Add-AppxPackage kullanmadan önce
# Import-Module Appx -UseWindowsPowerShell
# komutunu çalıştırın.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> Terminal'i manuel yüklerseniz:
>
> * [VC++ v14 Masaüstü Framework Paketi'ni](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages) yüklemeniz gerekebilir.
>   Bu sadece eski Windows 10 sürümlerinde ve eksik çerçeve paketleriyle ilgili bir hata alırsanız gereklidir.
> * Terminal yeni sürümler yayınlandığında otomatik güncellenmez, bu yüzden en son düzeltmeleri ve iyileştirmeleri almak için Terminal'in en güncel sürümünü düzenli olarak manuel yüklemeniz gerekir!

#### Windows Paket Yöneticisi CLI (winget) ile

[winget](https://github.com/microsoft/winget-cli) kullanıcıları,
`Microsoft.WindowsTerminal` paketini yükleyerek en güncel Terminal sürümünü indirebilir ve yükleyebilir:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> Bağımlılık desteği WinGet'in [1.6.2631 veya daha yeni](https://github.com/microsoft/winget-cli/releases) sürümünde mevcuttur. Terminal'in kararlı 1.18 veya daha yeni sürümünü yüklemek için, WinGet istemcisinin güncellenmiş sürümüne sahip olduğunuzdan emin olun.

#### Chocolatey ile (resmi olmayan)

[Chocolatey](https://chocolatey.org) kullanıcıları,
`microsoft-windows-terminal` paketini yükleyerek en güncel Terminal sürümünü indirebilir ve yükleyebilir:

```powershell
choco install microsoft-windows-terminal
```

Windows Terminal'i Chocolatey ile güncellemek için şu komutu çalıştırın:

```powershell
choco upgrade microsoft-windows-terminal
```

Paketin kurulumu/güncellenmesi sırasında herhangi bir sorun yaşarsanız,
[Windows Terminal paket
sayfasına](https://chocolatey.org/packages/microsoft-windows-terminal) gidin ve
[Chocolatey triyaj sürecini](https://chocolatey.org/docs/package-triage-process) izleyin.

#### Scoop ile (resmi olmayan)

[Scoop](https://scoop.sh) kullanıcıları,
`windows-terminal` paketini yükleyerek en güncel Terminal sürümünü indirebilir ve yükleyebilir:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Windows Terminal'i Scoop ile güncellemek için şu komutu çalıştırın:

```powershell
scoop update windows-terminal
```

Paketin kurulumu/güncellenmesi sırasında herhangi bir sorun yaşarsanız,
lütfen Scoop Extras bucket deposunun [sorunlar
sayfasında](https://github.com/lukesampson/scoop-extras/issues) arama yapın veya aynı sorunu bildirin.

---

## Windows Terminal Canary'nin kurulumu
Windows Terminal Canary, Windows Terminal'ın gece derlemesidir. Bu derleme, `main` dalımızdan en güncel kodu içerir ve özellikler Windows Terminal Preview'a gelmeden önce denemenize olanak tanır.

Windows Terminal Canary, en az kararlı sürümümüzdür, bu nedenle biz henüz bulamadan hatalarla karşılaşabilirsiniz.

Windows Terminal Canary, App Installer dağıtımı ve Taşınabilir ZIP dağıtımı olarak mevcuttur.

App Installer dağıtımı otomatik güncellemeleri destekler. Platform kısıtlamaları nedeniyle, bu yükleyici yalnızca Windows 11'de çalışır.

Taşınabilir ZIP dağıtımı taşınabilir bir uygulamadır. Otomatik olarak güncellenmez ve güncellemeleri otomatik olarak kontrol etmez. Bu taşınabilir ZIP dağıtımı Windows 10 (19041+) ve Windows 11'de çalışır.

| Dağıtım        | Mimari         | Bağlantı                                               |
|---------------|:---------------:|------------------------------------------------------|
| App Installer | x64, arm64, x86 | [indir](https://aka.ms/terminal-canary-installer)    |
| Taşınabilir ZIP| x64             | [indir](https://aka.ms/terminal-canary-zip-x64)      |
| Taşınabilir ZIP| ARM64           | [indir](https://aka.ms/terminal-canary-zip-arm64)    |
| Taşınabilir ZIP| x86             | [indir](https://aka.ms/terminal-canary-zip-x86)      |

_Windows Terminal dağıtım türleri hakkında daha fazla bilgi için [buraya bakın](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Windows Terminal Yol Haritası

Windows Terminal için plan [burada açıklanmıştır](/doc/roadmap-2023.md) ve proje ilerledikçe güncellenecektir.

## Terminal & Konsol Genel Bakış

Koda dalmadan önce aşağıdaki genel bakışı gözden geçirmeniz faydalı olacaktır:

### Windows Terminal

Windows Terminal, komut satırı kullanıcıları için yeni, modern, zengin özellikli, üretken bir terminal uygulamasıdır. Sekmeler desteği, zengin metin, küreselleştirme, yapılandırılabilirlik, tema ve stillendirme gibi Windows komut satırı topluluğunun en çok talep ettiği birçok özelliği içerir.

Terminal'in ayrıca hızlı ve verimli kalması, aşırı miktarda bellek veya güç tüketmemesi için hedeflerimize ve ölçütlerimize uyması gerekmektedir.

### Windows Konsol Host

Windows Konsol host'u, `conhost.exe`, Windows'un orijinal komut satırı kullanıcı deneyimidir. Ayrıca Windows'un komut satırı altyapısını ve Windows Konsol API sunucusunu, giriş motorunu, render motorunu, kullanıcı tercihlerini vb. barındırır. Bu depodaki konsol host kodu, Windows'taki `conhost.exe`nin oluşturulduğu gerçek kaynaktır.

2014'te Windows komut satırının sahipliğini devraldıktan sonra, ekip Konsol'a arka plan şeffaflığı, satır tabanlı seçim, [ANSI / Sanal Terminal dizileri](https://en.wikipedia.org/wiki/ANSI_escape_code) desteği, [24-bit renk](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/), [Pseudoconsole ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) ve daha fazlası gibi birçok yeni özellik ekledi.

Ancak, Windows Konsol'un birincil hedefi geriye dönük uyumluluğu korumak olduğundan, topluluğun (ve ekibin) son yıllarda istediği sekmeler, Unicode metin ve emoji gibi birçok özelliği ekleyemedik.

Bu kısıtlamalar, yeni Windows Terminal'i oluşturmamıza neden oldu.

> Komut satırının genel evrimi ve özel olarak Windows komut satırı hakkında daha fazla bilgi için Komut Satırı ekibinin [bu blog yazısı serisini](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/) okuyabilirsiniz.

### Paylaşılan Bileşenler

Windows Konsol'u elden geçirirken, kod tabanını önemli ölçüde modernleştirdik, mantıksal varlıkları modüller ve sınıflar halinde temizce ayırdık, bazı önemli genişletilebilirlik noktaları ekledik, eski, ev yapımı koleksiyon ve konteynerlerin çoğunu daha güvenli ve verimli [STL konteynerleriyle](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) değiştirdik ve kodu Microsoft'un [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) kullanarak daha basit ve güvenli hale getirdik.

Bu revizyon, Konsol'un bazı önemli bileşenlerinin Windows'ta herhangi bir terminal uygulamasında yeniden kullanılabilir olmasını sağladı. Bu bileşenler arasında yeni DirectWrite tabanlı metin yerleşim ve render motoru, hem UTF-16 hem de UTF-8 depolayabilen bir metin tamponu, bir VT ayrıştırıcı/emitter ve daha fazlası bulunur.

### Yeni Windows Terminal'in Oluşturulması

Yeni Windows Terminal uygulamasını planlamaya başladığımızda, çeşitli yaklaşımları ve teknoloji yığınlarını inceledik ve değerlendirdik. Sonunda, hedeflerimize en iyi şekilde, C++ kod tabanımıza yatırım yapmaya devam ederek ulaşacağımıza karar verdik. Bu, yukarıda bahsedilen modernize edilmiş bileşenlerin hem mevcut Konsol'da hem de yeni Terminal'de yeniden kullanılmasına olanak sağlayacaktı. Ayrıca, bu sayede Terminal'in çekirdek kısmını başkalarının kendi uygulamalarına dahil edebileceği yeniden kullanılabilir bir UI kontrolü olarak inşa edebileceğimizi fark ettik.

Bu çalışmanın sonucu bu depoda bulunmakta olup, Microsoft Store'dan veya [bu deponun
yayınlarından](https://github.com/microsoft/terminal/releases) indirebileceğiniz Windows Terminal uygulaması olarak sunulmaktadır.

---

## Kaynaklar

Windows Terminal hakkında daha fazla bilgi için aşağıdaki kaynaklar yararlı ve ilginç olabilir:

* [Komut Satırı Blogu](https://devblogs.microsoft.com/commandline)
* [Komut Satırı Arka Plan Blogu
  Serisi](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Windows Terminal Lansmanı: [Terminal "Sizzle
  Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Windows Terminal Lansmanı: [Build 2019
  Oturumu](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Bölüm 645 - Windows Terminal ile Richard
  Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [Bölüm 54 - Kayla Cinnamon ve Rich Turner ile Windows
  Terminal Ekibinde DevOps
  Üzerine](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Oturumu: [Modern Windows Komut Satırı: Windows
  Terminal -
  BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## SSS

### Yeni Terminal'i derledim ve çalıştırdım, ama eskisi gibi görünüyor

Sebep: Visual Studio'da yanlış çözümü başlatıyorsunuz.

Çözüm: Visual Studio'da `CascadiaPackage` projesini derleyip dağıttığınızdan emin olun.

> [!NOTE]
> `OpenConsole.exe` sadece yerel olarak derlenmiş bir `conhost.exe`, yani klasik
> Windows Konsolu'dur ve Windows'un komut satırı altyapısını barındırır. OpenConsole,
> Windows Terminal'in komut satırı uygulamalarıyla bağlantı kurması ve iletişim kurması için kullanılır (bkz.
> [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Dokümantasyon

Tüm proje dokümantasyonu [aka.ms/terminal-docs](https://aka.ms/terminal-docs) adresindedir. Eğer dokümantasyona katkıda bulunmak isterseniz, [Windows
Terminal Documentation repo](https://github.com/MicrosoftDocs/terminal) üzerinden bir pull request gönderebilirsiniz.

---

## Katkıda Bulunma

Siz değerli topluluğumuzla birlikte çalışmak ve Windows Terminal'i geliştirmek için heyecanlıyız!

***Bir özellik/düzeltme üzerinde çalışmaya BAŞLAMADAN ÖNCE***, lütfen [Katkıda Bulunma
Rehberimizi](./CONTRIBUTING.md)
okuyun ve izleyin, böylece gereksiz veya yinelenen çabadan kaçınmış olursunuz.

## Ekip ile İletişim

Ekip ile iletişime geçmenin en kolay yolu GitHub issues üzerinden olmaktır.

Lütfen yeni sorunlar, özellik istekleri ve öneriler gönderin, ancak **yeni bir sorun oluşturmadan önce benzer açık/kapalı mevcut sorunları mutlaka arayın.**

Henüz bir sorun açmayı gerektirmeyen bir sorunuz varsa, Twitter üzerinden bize ulaşabilirsiniz:

* Christopher Nguyen, Ürün Yöneticisi:
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Mühendislik Lideri: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Kıdemli Geliştirici: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Geliştirici: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Geliştirici
* Leonard Hecker, Geliştirici: [@LeonardHecker](https://twitter.com/LeonardHecker)

## Geliştirici Rehberi

## Ön Koşullar

Ortamınızı Terminal'i derlemek için iki şekilde yapılandırabilirsiniz:

### WinGet yapılandırma dosyası kullanarak

Depoyu klonladıktan sonra, ortamınızı ayarlamak için bir [WinGet yapılandırma dosyası](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine) kullanabilirsiniz. [Varsayılan yapılandırma dosyası](.config/configuration.winget) Visual Studio 2022 Community ve gereken diğer araçları yükler. [.config](.config) klasöründe Visual Studio 2022'nin Enterprise ve Professional sürümleri için iki farklı yapılandırma dosyası daha mevcuttur. Varsayılan yapılandırma dosyasını çalıştırmak için dosyaya gezginden çift tıklayabilir veya şu komutu çalıştırabilirsiniz:

```powershell
winget configure .config\configuration.winget
```

### Manuel yapılandırma

* Windows Terminal'i çalıştırmak için Windows 10 2004 (build >= 10.0.19041.0) veya daha yeni bir sürüm kullanıyor olmalısınız
* [Windows Ayarları uygulamasında Geliştirici Modunu etkinleştirmelisiniz](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)
  ve yerel olarak Windows Terminal'i yükleyip çalıştırmalısınız
* [PowerShell 7 veya daha yeni](https://github.com/PowerShell/PowerShell/releases/latest) bir sürüme sahip olmalısınız
* [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/) yüklü olmalıdır
* En az [VS
  2022](https://visualstudio.microsoft.com/downloads/) yüklü olmalı
* VS Installer üzerinden aşağıdaki iş yüklerini yüklemelisiniz. Not: VS 2022'de çözümü açmak, [eksik bileşenlerin otomatik olarak yüklenmesini](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/) isteyecektir:
  * Masaüstü Geliştirme (C++ ile)
  * Evrensel Windows Platformu Geliştirme
  * **Aşağıdaki Bireysel Bileşenler**
    * C++ (v143) Universal Windows Platform Araçları
* Test projelerini derlemek için [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) yüklemelisiniz

## Kodun Derlenmesi

OpenConsole.sln, Visual Studio içerisinden veya **/tools** dizinindeki yardımcı scriptler ve araçlarla komut satırından derlenebilir:

### PowerShell ile derleme

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Cmd ile derleme

```shell
.\tools\razzle.cmd
bcz
```

## Çalıştırma & Hata Ayıklama

Windows Terminal'de hata ayıklamak için, VS'de `CascadiaPackage`'a (Çözüm Gezgini'nde) sağ tıklayın ve özelliklere gidin. Hata Ayıklama menüsünde, "Application process" ve "Background task process" seçeneklerini "Native Only" olarak değiştirin.

Bundan sonra, <kbd>F5</kbd> tuşuna basarak Terminal projesini derleyip hata ayıklayabilirsiniz. "x64" veya "x86" platformunu seçtiğinizden emin olun – Terminal "Any Cpu" olarak derlenmez (çünkü Terminal bir C++ uygulamasıdır, C# değil).

> 👉 WindowsTerminal.exe dosyasını doğrudan çalıştırarak Terminal'i başlatamazsınız. Bunun nedenleri için bkz.
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### Kodlama Rehberi

Lütfen kodlama uygulamalarımızla ilgili aşağıdaki kısa dokümanları inceleyin.

> 👉 Bu dokümanlarda eksik bir şey bulursanız, depo içerisindeki herhangi bir dokümantasyon dosyasına katkıda bulunmaktan veya yeni dokümanlar yazmaktan çekinmeyin!

Bu, projemize etkin katkı sağlamak için insanlara neler sunmamız gerektiğini öğrenirken süregelen bir çalışmadır.

* [Kodlama Stili](./doc/STYLE.md)
* [Kod Organizasyonu](./doc/ORGANIZATION.md)
* [Eski kod tabanımızda istisnalar](./doc/EXCEPTIONS.md)
* [WIL ile Windows ile arayüz oluşturan faydalı akıllı işaretçiler ve makrolar](./doc/WIL.md)

---

## Davranış Kuralları

Bu proje [Microsoft Açık Kaynak Davranış Kuralları'nı][conduct-code] benimsemiştir. Daha fazla bilgi için [Davranış Kuralları SSS][conduct-FAQ]'ye bakın veya ek sorularınız ya da yorumlarınız için [opencode@microsoft.com][conduct-email] adresine e-posta gönderin.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---