<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">OpenAI'nin Whisper Modeli ile güçlendirilmiş kesintisiz dikte</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## Hakkında

Whispering, küresel konuşmadan metne işlevselliği sağlayan, klavye kısayolları ve otomatik kopyala-yapıştır gibi seçeneklerle dikteyi mümkün olduğunca sorunsuz hale getiren açık kaynaklı bir transkripsiyon uygulamasıdır.

Altyapısında OpenAI'nin Whisper modeli kullanılır ve bu sayede yerleşik dikteye göre çok daha yüksek doğruluk sunar.

> **Önemli Not**: Whispering öncelikli olarak bir transkripsiyon aracı olarak tasarlanmıştır, kayıt aracı olarak değil. Güvenilirliğin kritik olduğu uzun kayıtlar için, cihazınızda yerel kayıt API’larını kullanan özel bir kayıt uygulaması kullanmanızı tavsiye ederim. Bu, en iyi ses kalitesini ve kayıt stabilitesini sağlar.

## Demolar

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Temel Özellikler

1. **Küresel Transkripsiyon**: Küresel bir klavye kısayolu veya iki tıklama ile Whisper’ın konuşmadan metne işlevine her yerde erişin.
2. **Çapraz Platform Deneyimi**:
   - Masaüstü Uygulama: Tüm uygulamalarda küresel transkripsiyon imkânı sunar.
   - Tarayıcı Eklentisi: Web uygulaması ile iletişim kurarak tarayıcıda küresel transkripsiyon sağlar.
3. **Sohbet Entegrasyonu**: Tarayıcı eklentisi, ChatGPT ve Claude web sitelerine bir kayıt düğmesi ekler, böylece sohbet arayüzünde doğrudan sesli giriş ve transkripsiyon yapılabilir.
4. **Transkripsiyon Yönetimi**: Whispering uygulamasında transkripsiyonları gözden geçirin ve düzenleyin, böylece doğruluk ve netlik sağlayın.
5. **Otomatik Pano Entegrasyonu**: Transkripsiyon tamamlandığında metin otomatik olarak panonuza kopyalanır. Otomatik yapıştırma seçeneği de mevcuttur.

## Verilerim nasıl saklanıyor?

Whispering, kayıtlar ve metin transkripsiyonları dahil olmak üzere mümkün olan tüm verileri yerel olarak cihazınızda saklar. Bu yaklaşım maksimum gizlilik ve veri güvenliği sağlar. Verilerin nasıl işlendiğine dair genel bakış:

1. **Yerel Depolama**: Ses kayıtları ve transkripsiyonlar, blob depolama ve tüm verilerinizin (metin ve transkripsiyonlar gibi) tutulduğu yer olarak kullanılan IndexedDB’de saklanır.

2. **Transkripsiyon Servisi**: Yalnızca seçerseniz, kaydınız harici bir transkripsiyon servisine gönderilir. Seçenekleriniz:
   - OpenAI veya Groq gibi harici servisler
   - Her şeyin cihazda kalmasını sağlayan `faster-whisper-server` gibi yerel bir transkripsiyon servisi

3. **Yapılandırılabilir Ayarlar**: Maksimum yerel işlevsellik için ayarlardan transkripsiyon servisinizin tercihini değiştirebilirsiniz.


## Kurulum

### Web Uygulaması

[whispering.bradenwong.com](https://whispering.bradenwong.com/) adresini ziyaret edin; burada Vercel üzerinde barındırılan `apps/app` klasörünün en son sürümü bulunur.

### Chrome Eklentisi

Chrome Web Mağazası’ndan Chrome Eklentisini [buradan](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo) yükleyin.

### Masaüstü Uygulaması

Whispering masaüstü uygulamasını indirmek ve kurmak için işletim sisteminize uygun adımları izleyin:

#### Windows

1. [En son sürümler sayfasından](https://github.com/braden-w/whispering/releases) `.msi` ile biten kurulum paketini indirin.
2. İndirilen `.msi` dosyasını açarak yükleyiciyi başlatın.
3. Güvenli değil uyarısı çıkarsa, `Daha Fazla Bilgi` -> `Yine de Çalıştır` seçeneğine tıklayın.
4. Kurulumu tamamlamak için ekrandaki talimatları izleyin.

#### macOS

macOS için Whispering kurulumu adımları:

1. **Kurulum paketini indirin**:
   - [En son sürümler sayfasını](https://github.com/braden-w/whispering/releases) ziyaret edin.
   - Uygun paketi seçin:
     - Apple Silicon için: `Whispering_x.x.x_aarch64.dmg`
     - Intel için: `Whispering_x.x.x_x64.dmg`

2. **Uygulamayı kurun**:
   - İndirilen `.dmg` dosyasını açın.
   - Whispering uygulamasını Applications klasörüne sürükleyin.

3. **Whispering’i başlatın**:
   - Uygulamalar klasöründen Whispering’i açın.
   - Doğrulanmamış geliştirici uyarısı görürseniz:
     - `İptal`e tıklayın
     - Finder’da uygulamaya sağ tıklayın ve `Aç`ı seçin

4. **Sorun Giderme** (yalnızca Apple Silicon):
   `"Whispering" hasarlı ve açılamıyor` hatası alırsanız:
   - Terminal’i açın
   - Şu komutu çalıştırın:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Uygulamayı tekrar açmayı deneyin

Bu adımların ardından Whispering macOS sisteminizde kullanıma hazır olacaktır.

#### Linux

Linux için birden fazla kurulum seçeneği mevcuttur. Ortamınıza uygun olanı seçin:

1. **AppImage**:

   - [En son sürümler sayfasından](https://github.com/braden-w/whispering/releases) `.AppImage` dosyasını indirin.
   - Dosyayı çalıştırılabilir yapın:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - AppImage’ı çalıştırın:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **DEB Paketi (Debian/Ubuntu)**:
   - [En son sürümler sayfasından](https://github.com/braden-w/whispering/releases) `.deb` dosyasını indirin.
   - `dpkg` ile paketi kurun:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Bağımlılık sorunlarını çözün:
     ```bash
     sudo apt-get install -f
     ```

Kurulumdan sonra uygulama kullanıma hazır olacaktır.

## Kullanım

### Chrome Eklentisi

Chrome Eklentisini yükledikten sonra, Chrome uzantıları çubuğunda bir Whispering simgesi bulacaksınız. Bu simgeye tıklayarak eklentiyi açın. Mikrofon düğmesine tıklayarak sesinizi kaydedin, ardından bitirdiğinizde kare düğmesine tıklayın. Transkripsiyonunuz alttaki metin kutusunda görünecektir.

ChatGPT veya Claude özelliğine erişmek için, ChatGPT veya Claude web sayfasına gidin. Sohbet arayüzünde yeni bir kayıt düğmesi göreceksiniz. Bu düğmeye tıklayarak kaydı başlatıp durdurun, transkripte edilen metin otomatik olarak sohbet giriş alanına eklenecektir.

Kısayol özelliğine erişmek için <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> veya <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> tuşlarına basın (daha sonra Chrome eklentisi kısayollarından ayarlanabilir) ve herhangi bir web sitesinden kaydı başlatın. Transkripsiyon otomatik olarak panonuza kopyalanacak ve mevcut giriş alanına yapıştırılacaktır.

Chrome Eklentisi [whispering.bradenwong.com](https://whispering.bradenwong.com) ile iletişim kurar ve bir sekme bulamazsa otomatik olarak arka planda bir sekme oluşturmayı dener. Çoğu hata, bu iletişimin başarısız olmasından kaynaklanır; örneğin, nadiren sekmenin uykuya geçmesi gibi.

### Web Uygulaması

Web uygulamasına [whispering.bradenwong.com](https://whispering.bradenwong.com) üzerinden erişebilirsiniz. Mikrofon düğmesine tıklayarak sesinizi kaydedin, ardından bitirdiğinizde kare düğmesine tıklayın. Transkripsiyonunuz metin kutusunda görünecektir.

### Masaüstü Uygulaması

Whispering masaüstü uygulamasını yükledikten sonra, herhangi bir yerde <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> tuşlarına basarak kaydı başlatın (ayarlar bölümünden değiştirilebilir). Transkripsiyon otomatik olarak panonuza kopyalanacak ve yapıştırılacaktır; her iki özellik de ayarlardan açılıp kapatılabilir.

## Kullanılan Teknolojiler

#### Web ve Masaüstü

Whispering uygulaması aşağıdaki teknoloji ve kütüphanelerle geliştirilmiştir:

- [Svelte 5](https://svelte.dev): Tercih edilen UI reaktivite kütüphanesi.
- [SvelteKit](https://kit.svelte.dev/docs): Yönlendirme ve statik site üretimi için; hem web sitesi hem de Tauri uygulamasının statik arayüzü için kullanılır.
- [Tauri](https://tauri.studio/en/docs/intro/): Masaüstü uygulama çatısı.
- [Effect-TS](https://github.com/Effect-TS/effect): Biraz fonksiyonel programlama serpiştirmek ve hataların fonksiyon imza dönüş tipine dahil edildiği son derece tip güvenli fonksiyonlar yazmak için.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Svelte uygulamaları için basit, özelleştirilebilir bir toast kütüphanesi. Effect-TS ile yükseltilen hataları `renderAsToast` fonksiyonu ile göstermek için kullanılır.
- [TanStack Table](https://tanstack.com/table): Tüm veri tablolarını destekler.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): Tarayıcıda büyük miktarda yapılandırılmış veri depolamak için düşük seviyeli bir API. Tanstack Table ile senkronize edilir.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): Tercih edilen UI bileşen kütüphanesi.
- [TailwindCSS](https://tailwindcss.com/docs): Hızlı özel kullanıcı arayüzleri oluşturmak için yardımcı sınıf tabanlı CSS çatısı.
- [Turborepo](https://turborepo.org/): Monorepo yönetimi için; böylece `apps/app` ve `apps/extension` aynı kod tabanını paylaşabilir, kod tekrarını büyük ölçüde azaltır ve daha da önemlisi tek bir doğruluk kaynağı sağlar.
- [Rust](https://www.rust-lang.org): Masaüstü uygulama özelliklerini genişletmek için; örneğin otomatik yapıştırmayı yönetmek için `enigo` crate'i kullanılır.
- [Vercel](https://vercel.com/): Hobi projesi için uygun hosting ve güzel Turborepo entegrasyonları.
- [Zapsplat.com](https://www.zapsplat.com/): Telifsiz ses efektleri kütüphanesi.

#### Eklenti

Whispering Chrome eklentisi şu teknolojilerle geliştirilmiştir:

- [Plasmo](https://docs.plasmo.com/): Chrome eklentileri geliştirme çatısı. Whispering web sitesine iletişim için [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) kullanılır.
- [Effect-TS](https://github.com/Effect-TS/effect): Biraz fonksiyonel programlama serpiştirmek ve hataların fonksiyon imza dönüş tipine dahil edildiği son derece tip güvenli fonksiyonlar yazmak için.
- [React](https://reactjs.org): Chrome eklentisi için UI reaktivite kütüphanesi; çünkü Plasmo ne yazık ki Svelte 5’i desteklemiyor.
- [ShadCN](https://github.com/shadcn): Chrome eklentisi için UI bileşen kütüphanesi.
- [TailwindCSS](https://tailwindcss.com/docs): Özel kullanıcı arayüzlerini hızlıca oluşturmak için yardımcı sınıf tabanlı bir CSS framework’üdür.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): Chrome uzantı API’si.
- [Zapsplat.com](https://www.zapsplat.com/): Telifsiz ses efektleri kütüphanesi.

## Whispering’i Yerel Geliştirme Modunda Çalıştırma

Projeyi kendi bilgisayarınızda kurmak için şu adımları izleyin:

1. Depoyu klonlayın: `git clone https://github.com/braden-w/whispering.git`
2. Proje dizinine geçin: `cd whispering`
3. Gerekli bağımlılıkları yükleyin: `pnpm i`

Whispering masaüstü uygulamasını ve web sitesini geliştirme modunda çalıştırmak için:

4. Uygulama dizinine geçin: `cd apps/app`
5. Geliştirme sunucusunu başlatın: `pnpm tauri dev`

Masaüstü uygulaması yerel geliştirme için otomatik olarak açılacaktır. Web uygulamasını geliştirmek için tarayıcınızda `http://localhost:5173` adresine gidin.

Whispering Chrome uzantısını geliştirme modunda çalıştırmak için:

4. Uzantı dizinine geçin: `cd apps/extension`
5. Geliştirme sunucusunu başlatın: `pnpm dev --target=chrome-mv3`

Chrome uzantısını geliştirmek için, Chrome’da `chrome://extensions` adresine gidin, geliştirici modunu etkinleştirin ve `apps/extension/build/{platform}-{manifest-version}-dev` klasörünü paketlenmemiş bir uzantı olarak yükleyin.

## Yürütülebilir Dosyayı Kendiniz Derleyin

Eğer yükleyicilerin güvenilirliği konusunda endişeleriniz varsa ya da daha fazla kontrol sahibi olmak istiyorsanız, yürütülebilir dosyayı her zaman kendiniz derleyebilirsiniz. Bu daha fazla kurulum gerektirir, fakat beklediğiniz kodu çalıştırdığınızdan emin olmanızı sağlar. Açık kaynak yazılımın güzelliği de budur!

### Chrome

1. Uzantı dizinine geçin: `cd apps/extension`
2. Gerekli bağımlılıkları yükleyin: `pnpm i`
3. Plasmo derlemesini çalıştırın: `pnpm plasmo build --target=chrome-mv3`
4. Çıktı `apps/extension/build/chrome-mv3-prod` klasöründe bulunacaktır; bu klasör Chrome’a paketlenmemiş bir uzantı olarak yüklenebilir.
5. Alternatif olarak, uzantıyı Chrome Web Mağazası için de derleyebilirsiniz: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Uzantı dizinine geçin: `cd apps/extension`
2. Gerekli bağımlılıkları yükleyin: `pnpm i`
3. Plasmo derlemesini çalıştırın: `pnpm plasmo build --target=firefox-mv3`
4. Çıktı `apps/extension/build/firefox-mv3-prod` klasöründe bulunacaktır; bu klasör Chrome’a paketlenmemiş bir uzantı olarak yüklenebilir.
5. Alternatif olarak, uzantıyı Chrome Web Mağazası için de derleyebilirsiniz: `pnpm plasmo build --target=firefox-mv3 --release`

### Masaüstü

1. Uygulama dizinine geçin: `cd apps/app`
2. Gerekli bağımlılıkları yükleyin: `pnpm i`
3. Tauri Derlemesini çalıştırın: `pnpm tauri build`
4. Yürütülebilir dosyayı `apps/app/target/release` dizininde bulabilirsiniz.

## Katkıda Bulunma

Topluluktan katkıları memnuniyetle karşılıyoruz! Whispering’e katkıda bulunmak isterseniz lütfen şu adımları izleyin:

1. Depoyu çatallayın (fork).
2. Özelliğiniz veya hata düzeltmeniz için yeni bir dal oluşturun: `git checkout -b feature/your-feature-name` veya `git checkout -b fix/your-bugfix-name`
3. Değişikliklerinizi yapın ve açıklayıcı bir mesajla commitleyin.
4. Dalınızı kendi çatallanmış deponuza gönderin: `git push origin your-branch-name`
5. Kendi çatallanmış deponuzdan orijinal depoya bir çekme isteği (pull request) oluşturun.

Lütfen kodunuzun belirlenmiş kurallara uygun ve iyi belgelenmiş olduğundan emin olun.

## Lisans

Whispering [MIT Lisansı](https://opensource.org/licenses/MIT) ile yayınlanmıştır.

## Sponsorlar

Bu proje aşağıdaki harika kişiler ve kuruluşlar tarafından desteklenmektedir:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Destek ve Geri Bildirim

Herhangi bir sorunla karşılaşırsanız veya iyileştirme önerileriniz olursa, lütfen [GitHub issues sekmesi](https://github.com/braden-w/whispering/issues) üzerinden bir sorun açın veya bana [whispering@bradenwong.com](mailto:whispering@bradenwong.com) adresinden ulaşın. Geri bildiriminizi gerçekten çok önemsiyorum!

Whispering’i kullandığınız için teşekkürler ve keyifli yazmalar!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---