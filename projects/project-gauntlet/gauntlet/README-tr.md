# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="assets/linux/icon_256.png">

Web-öncelikli, React tabanlı eklentilere sahip çapraz platform uygulama başlatıcı

> [!WARNING]
> Launcher, tek bir geliştirici tarafından boş zamanlarında geliştirilmektedir.
> Değişiklikler yavaş ama istikrarlı olabilir
>
> Muhtemelen bazı büyük değişiklikler olacak, bunlar [değişiklik günlüğünde](CHANGELOG.md) belgelenmektedir.

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Demo

Biraz eski bir demo

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Özellikler

- Eklenti-öncelikli
  - Eklentiler TypeScript ile yazılır
  - Geniş kapsamlı eklenti API'si
      - UI görünümleri oluştur
      - Tek seferlik komutlar
      - Tek seferlik komutların listesini dinamik olarak sağla
      - Ana arama çubuğundaki değere göre doğrudan altında hızlı "satır içi" içerik göster
      - Panodan içerik al ve ekle
  - Eklentiler, Git deposunda ayrı bir dal olarak dağıtılır, yani eklenti dağıtımı için merkezi bir sunucu gerekmez
  - Eklenti kimlikleri sadece Git Depo URL'leridir
  - [React](https://github.com/facebook/react) tabanlı eklentiler için arayüz
    - Özel React Reconciler ile uygulanmıştır (Electron kullanılmaz)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno, JavaScript eklenti kodunu daha güvenli bir şekilde sandbox'lamaya olanak tanır
    - Eklentilerin çalışması için ihtiyaç duydukları izinleri açıkça belirtmeleri gerekir
    - Node.js, eklenti araçlarını çalıştırmak için kullanılır, ancak bir eklenti geliştiricisi olarak her zaman Deno'da çalışan kod yazarsınız
- Başından itibaren çapraz platform düşünülerek tasarlanmıştır
- Komutlar ve Görünümler özel global kısayollarla çalıştırılabilir/açılabilir
- Komutlara veya Görünümlere özel arama takma adı atanabilir
- Özel tema desteği
- Yerleşik işlevsellik, paketli eklentiler tarafından sağlanır
  - Uygulamalar: Sistemde yüklü olan uygulamaları arama sonuçlarında gösterir
    - Eklenti ayrıca pencereleri ve hangi uygulamaya ait olduklarını izler, böylece zaten açık olan bir uygulama açıldığında varsayılan olarak önceden oluşturulan pencere getirilir
      - Şu anda tüm sistemler desteklenmemektedir. [özellik desteğine](https://gauntlet.sh/docs/feature-support) bakınız
  - Hesap makinesi: Matematiksel işlemlerin sonucunu doğrudan ana arama çubuğunun altında gösterir
    - Döviz kurları kullanarak para birimi dönüştürme dahil
    - [Numbat](https://github.com/sharkdp/numbat) tarafından desteklenmektedir
- Frecency tabanlı arama sonucu sıralaması
   - Frecency, sıklık ve yakınlığın birleşimidir
   - Bir öğe ne kadar sık kullanılırsa sonuçlar listesinde o kadar üstte olur, ancak geçmişte çok kullanılan öğeler, son zamanlarda aynı sayıda kullanılanlardan daha düşük sıralanır
   - Sonuçlar, kelime bazında alt dize ile eşleştirilir

##### İşletim Sistemi Desteği

##### Resmi
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### En İyi Çaba
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland henüz desteklenmiyor, bkz. [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Başlarken

### Gauntlet'i Kurun

[Kurulum](https://gauntlet.sh/docs/installation) bölümüne bakınız

### Global Kısayol

Ana pencere global kısayol veya CLI komutu ile açılabilir:
- Global Kısayol (Ayarlar'dan değiştirilebilir)
  - Windows: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - Global kısayol desteklenmeyebilir, bkz. [özellik desteği](https://gauntlet.sh/docs/feature-support)
    - Lütfen bunun yerine CLI komutunu kullanın ve pencere yöneticisine özgü bir yöntemle çağırın
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- CLI komutu
  - `gauntlet open`

### Eklenti Kurulumu

Eklentiler Ayarlar arayüzünden kurulur. Eklentiyi kurmak için eklentinin Git depo url'sini kullanın, örn. `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](docs/settings_ui.png)

### Kendi eklentinizi oluşturun

[Eklenti geliştirmeye başlama](https://gauntlet.sh/docs/plugin-development/getting-started) bölümüne bakınız

## Tema Desteği

[Tema Desteği](https://gauntlet.sh/docs/theming) bölümüne bakınız

## Gauntlet'i Derlemek

Gerekenler:
- NodeJS
- Rust
- Protobuf Derleyici
- CMake (projenin kendisi tarafından kullanılmaz, ancak bir bağımlılık tarafından gereklidir)
- Linux'ta: `libxkbcommon-dev` (not: kullanılan dağıtıma bağlı olarak adı değişebilir)

### Geliştirici Modu

Geliştirici modunda derlemek için:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
Geliştirici modunda ("release" özelliği olmadan) uygulama, durum veya önbellek saklamak için YALNIZCA proje dizini içindeki dizinleri kullanır, böylece global kurulumu bozmaz

### Henüz Paketlenmemiş

Henüz paketlenmemiş sürüm ikili dosyasını oluşturmak için:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Paketli
İşletim sistemine özel paketi derlemek için aşağıdakilerden birini çalıştırın:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Ancak yeni sürüm yayınlama işlemi GitHub Actions üzerinden yapılmalıdır

## Katkıda Bulunma

Gauntlet'in geliştirilmesine sadece kod katkısı yapmadan da yardımcı olabilirsiniz:
- Bir hata veya UI/UX problemi bildirmek
- Bir eklenti oluşturmak

Basit sorunlar için bir issue veya PR açıp kendiniz çözebilirsiniz.
Daha önemli değişiklikler için lütfen yaratıcılarla Discord üzerinden (README'nin başındaki davet linki) iletişime geçin ve önce tartışın.

Her türlü katkı memnuniyetle karşılanır.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---