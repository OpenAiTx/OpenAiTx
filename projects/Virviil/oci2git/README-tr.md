
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

Konteyner imajlarını (Docker, vb.) Git depolarına dönüştüren bir Rust uygulaması. Her konteyner katmanı bir Git commit'i olarak temsil edilir ve orijinal imajın geçmişi ile yapısı korunur.

![OCI2Git'in nginx imajını dönüştürdüğünü gösteren demo](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Özellikler

- Docker imajlarını analiz edin ve katman bilgilerini çıkarın
- Her imaj katmanının bir commit olarak temsil edildiği bir Git deposu oluşturun
- Boş katmanlar için destek (ENV, WORKDIR, vb.) boş commitler olarak
- Markdown formatında tam meta veri çıkarımı
- Farklı konteyner motorlarını desteklemek için genişletilebilir mimari

## Kullanım Senaryoları

### Katman Karşılaştırma
Konteyner sorunlarını giderirken, Git'in güçlü karşılaştırma (diff) özelliklerini kullanarak herhangi iki katman arasında tam olarak neyin değiştiğini belirleyebilirsiniz. Commitler arasında `git diff` komutunu çalıştırarak mühendisler, hangi dosyaların eklendiğini, değiştirildiğini veya silindiğini tam olarak görebilir; böylece her Dockerfile talimatının etkisini anlamak ve sorunlu değişiklikleri bulmak çok daha kolay hale gelir.
![Katman karşılaştırma örneği](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Kaynak Takibi
`git blame` kullanarak geliştiriciler, belirli bir dosya veya kod satırının hangi katmanda oluşturulduğunu hızla belirleyebilir. Bu özellikle yapılandırma dosyaları veya bağımlılıklarla ilgili sorunları teşhis ederken çok değerlidir. Her katmanı elle incelemek yerine, herhangi bir dosyanın kaynağını ve ilgili Dockerfile talimatını anında takip edebilirsiniz.

### Dosya Yaşam Döngüsü Takibi
OCI2Git, bir dosyanın konteyner imajı boyunca yolculuğunu takip etmenizi sağlar. Bir dosyanın ne zaman oluşturulduğunu, katmanlar boyunca nasıl değiştirildiğini ve eğer varsa ne zaman silindiğini gözlemleyebilirsiniz. Bu kapsamlı görünüm, potansiyel olarak onlarca katmandaki değişiklikleri elle takip etmeden dosyanın evrimini anlamanıza yardımcı olur.

Konteyner imajınızdaki bir dosyanın geçmişini izlemek için — ilk ne zaman göründüğünü, değiştirildiğini veya silindiğini görmek dahil — dönüşümden sonra şu Git komutlarını kullanabilirsiniz:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```

Bu komutlar, katman arşivlerini manuel olarak çıkartıp karşılaştırmanın karmaşıklığı olmadan, herhangi bir dosyanın konteyner katmanları arasındaki tam geçmişini izlemeyi kolaylaştırır.

### Çok Katmanlı Analiz
Bazen en anlamlı karşılaştırmalar, ardışık olmayan birden fazla katmandaki değişiklikleri inceleyerek elde edilir. OCI2Git ile, bileşenlerin birden fazla derleme aşamasında nasıl evrildiğini analiz etmek için Git’in karşılaştırma araçlarını kullanabilir, yalnızca bitişik katmanlara bakıldığında fark edilmeyen desenleri tespit edebilirsiniz.

### Katman Keşfi
Herhangi bir belirli commite geçmek için `git checkout` komutunu kullanarak, konteyner dosya sistemini o katmanda olduğu gibi inceleyebilirsiniz. Bu, geliştiricilere, imajın oluşturulma sürecinin herhangi bir noktasında dosyaların ve dizinlerin kesin durumunu inceleme olanağı sağlar, hata ayıklarken veya konteyner davranışını incelerken paha biçilmez bir bağlam sunar.
![Önceki commite geçiş](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Çoklu İmaj Analizi

Ortak bir soya sahip birden fazla konteyner imajı ile çalışırken, OCI2Git yalnızca imajlar gerçekten ayrıştığında akıllıca dallar oluşturur. Böylece, ortak geçmişlerini korurken, tek bir depoda birden fazla ilgili imajı analiz edebilirsiniz.

```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```

OCI2Git, görüntüler arasında paylaşılan katmanları otomatik olarak algılar ve ortak tabanlarını yansıtan dallanma yapısı oluşturur. Git geçmişi şunları gösterecektir:
- Tüm paylaşılan katmanları içeren ortak bir gövde
- Görüntüler gerçekten farklılaştığında ayrılan ayrı dallar
- Görüntülerin nerede ortak soya sahip olduğunu ve nerede benzersiz hale geldiğini net görselleştirme
- Akıllı çoğaltma yönetimi: Aynı görüntü iki kez işlenirse, algoritma son meta veri işlemi öncesinde bunu algılar ve kopya dal oluşturmadan atlar

Bu yaklaşım özellikle şu durumlar için değerlidir:
- **Görüntü Ailesi Analizi**: Bir görüntünün farklı varyantlarının (farklı sürümler, mimariler veya yapılandırmalar) birbirleriyle ilişkisini anlamak
- **Taban Görüntü Etkisi**: Taban bir görüntüde yapılan değişikliklerin birden fazla türetilmiş görüntüyü nasıl etkilediğini görmek
- **Optimizasyon Fırsatları**: Görüntü varyantları arasında daha iyi kullanılabilecek ortak bileşenleri belirlemek

![Paylaşılan taban ve ayrışan dalları gösteren çoklu görüntü depo yapısı](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Ek Kullanım Senaryoları

- **Güvenlik Denetimi**: Savunmasız paket veya yapılandırmaların tam olarak ne zaman eklendiğini belirleyin ve bunları belirli yapı talimatlarına kadar izleyin.
- **Görüntü Optimizasyonu**: Katman yapılarını analiz ederek gereksiz işlemleri veya büyük dosyaları belirleyin, böylece görüntü boyutunu küçültün.
- **Bağımlılık Yönetimi**: Görüntü geçmişi boyunca bağımlılıkların ne zaman eklendiğini, yükseltildiğini veya kaldırıldığını takip edin.
- **Yapı Süreci İyileştirme**: Katman bileşimini inceleyerek Dockerfile talimatlarını daha iyi önbellekleme ve daha küçük görüntü boyutu için optimize edin.
- **Görüntüler Arası Karşılaştırma**: Birden fazla ilişkili görüntüyü Git depolarına dönüştürün ve Git’in karşılaştırma araçlarını kullanarak farklılıklarını ve benzerliklerini analiz edin.

## Kurulum

### Kaynaktan

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Crates.io'dan

```bash
cargo install oci2git
```

## Kullanım

```bash
oci2git [OPTIONS] <IMAGE>
```

Argümanlar:
  `<IMAGE>`  Dönüştürülecek imaj adı (örn., 'ubuntu:latest') veya tar motoru kullanılırken tarball yolu

Seçenekler:
  `-o, --output <o>`  Git deposu için çıktı dizini [varsayılan: ./container_repo]
  `-e, --engine <ENGINE>`  Kullanılacak konteyner motoru (docker, nerdctl, tar) [varsayılan: docker]
  `-h, --help`            Yardım bilgisini yazdır
  `-V, --version`         Sürüm bilgisini yazdır

Ortam Değişkenleri:
  `TMPDIR`  Varsayılan olarak ara veri işlemede kullanılan konumu değiştirmek için bu ortam değişkenini ayarlayın. Bu, platforma bağlıdır (örn., Unix/macOS'ta `TMPDIR`, Windows'ta `TEMP` veya `TMP`).

## Örnekler

Docker motorunu kullanmak (varsayılan):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

Zaten indirilmiş bir imaj tarball'ını kullanmak:
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Tar motoru, genellikle `docker save` ile oluşturulan geçerli bir OCI formatında tarball bekler:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Bu, `./ubuntu-repo` dizininde bir Git deposu oluşturacak ve şunları içerecek:
- `Image.md` - Görüntüyle ilgili tüm meta veriler Markdown formatında
- `rootfs/` - Kaptan alınan dosya sistemi içeriği

Git geçmişi, konteynerin katman geçmişini yansıtır:
- İlk commit yalnızca tam meta veriye sahip `Image.md` dosyasını içerir
- Sonraki her commit, orijinal görüntüden bir katmanı temsil eder
- Commit mesajı olarak Dockerfile komutunu içerir

## Depo Yapısı

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
  
## Gereksinimler

- Rust 2021 sürümü
- Docker CLI (Docker motoru desteği için)
- Git

## Lisans

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---