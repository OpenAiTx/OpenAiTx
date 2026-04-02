
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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![Dokümantasyon](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![Lisans](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![İndirmeler](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (mock for future test.yaml)
[//]: # ([![Test Durumu]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Konteyner imajlarını (Docker, vb.) Git depolarına dönüştüren ve YAML formatında dosya sistemi malzeme listesi (fsbom) oluşturan bir Rust uygulamasıdır. Her konteyner katmanı, orijinal imajın geçmişini ve yapısını koruyarak bir Git commit'i olarak temsil edilir.

![OCI2Git'in nginx imajını dönüştürme demosu](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Özellikler

- Docker imajlarını analiz etme ve katman bilgisi çıkarımı
- Her imaj katmanının bir commit olarak temsil edildiği bir Git deposu oluşturma
- Katmanlara göre dosya listeleriyle YAML biçiminde dosya sistemi malzeme listesi (fsbom) üretme
- Boş katmanlar (ENV, WORKDIR, vb.) için boş commit desteği
- Markdown formatına tam metadata çıkarımı
- Farklı konteyner motorlarını desteklemek için genişletilebilir mimari

## Kullanım Senaryoları

### Katman Karşılaştırması (Layer Diffing)
Konteyner sorunlarını giderirken, Git'in güçlü karşılaştırma (diff) yetenekleriyle herhangi iki katman arasındaki değişiklikleri tam olarak belirleyebilirsiniz. Commit'ler arasında `git diff` çalıştırarak mühendisler hangi dosyaların eklendiğini, değiştirildiğini veya silindiğini kesin olarak görebilir, böylece her Dockerfile talimatının etkisini anlamak ve sorunlu değişiklikleri tespit etmek çok daha kolay olur.
![Katman diff örneği](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Kaynak Takibi (Origin Tracking)
`git blame` kullanarak geliştiriciler, belirli bir dosya veya kod satırının hangi katmanda eklendiğini hızlıca tespit edebilir. Bu, özellikle yapılandırma dosyaları veya bağımlılıklarla ilgili sorunları çözerken çok değerlidir. Her katmanı manuel olarak incelemek yerine, herhangi bir dosyanın kaynağını ve ilgili Dockerfile talimatını anında takip edebilirsiniz.

### Dosya Yaşam Döngüsü Takibi (File Lifecycle Tracking)
OCI2Git, belirli bir dosyanın konteyner imajının geçmişindeki yolculuğunu izlemenizi sağlar. Bir dosyanın ilk ne zaman oluşturulduğunu, katmanlar boyunca nasıl değiştirildiğini ve ne zaman/varsa silindiğini görebilirsiniz. Bu kapsamlı görünüm, potansiyel olarak onlarca katman arasında değişiklikleri manuel olarak takip etmek zorunda kalmadan dosya evrimini anlamanıza yardımcı olur.

Konteyner imajınızdaki bir dosyanın geçmişini — ilk ne zaman göründüğü, değiştirildiği veya silindiği dahil — takip etmek için, dönüşümden sonra şu Git komutlarını kullanabilirsiniz:

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

OCI2Git, görüntüler arasındaki paylaşılan katmanları otomatik olarak algılar ve ortak tabanlarını yansıtan bir dallanma yapısı oluşturur. Git geçmişi şunları gösterir:
- Tüm paylaşılan katmanları içeren ortak bir ana gövde
- Görüntüler gerçekten farklılaştığında ayrılan ayrı dallar
- Görüntülerin nerede ortak bir kökene sahip olduğunu ve nerede benzersiz hale geldiğini açıkça görselleştirme
- Akıllı çoğaltma yönetimi: Aynı görüntü iki kez işlenirse, algoritma son meta veri işlemesinden önce bunu algılar ve yinelenen bir dal oluşturmayı atlar

Bu yaklaşım özellikle şu durumlarda değerlidir:
- **Görüntü Ailesi Analizi**: Bir görüntünün farklı varyantlarının (farklı sürümler, mimariler veya yapılandırmalar) birbiriyle nasıl ilişkili olduğunu anlamak
- **Taban Görüntü Etkisi**: Bir taban görüntüde yapılan değişikliklerin türetilmiş birden fazla görüntüyü nasıl etkilediğini doğrudan görmek
- **Optimizasyon Fırsatları**: Görüntü varyantları arasında daha iyi değerlendirilebilecek paylaşılan bileşenleri belirlemek

![Paylaşılan taban ve ayrılan dalları gösteren çoklu-görüntü depo yapısı](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Ek Kullanım Durumları

- **Güvenlik Denetimi**: Savunmasız paket veya yapılandırmaların tam olarak ne zaman eklendiğini tespit edin ve bunları belirli derleme talimatlarına kadar takip edin.
- **Görüntü Optimizasyonu**: Katman yapılarını analiz ederek gereksiz işlemleri veya birleştirilebilecek büyük dosyaları tespit edin, böylece görüntü boyutunu azaltın.
- **Bağımlılık Yönetimi**: Görüntü geçmişi boyunca bağımlılıkların ne zaman eklendiğini, yükseltildiğini veya kaldırıldığını izleyin.
- **Derleme Süreci İyileştirmesi**: Daha iyi önbellekleme ve daha küçük görüntü boyutu için Dockerfile talimatlarını optimize etmek üzere katman bileşimini inceleyin.
- **Çapraz Görüntü Karşılaştırması**: Birbiriyle ilişkili birden fazla görüntüyü Git depolarına dönüştürün ve farklarını ve ortak yönlerini analiz etmek için Git'in karşılaştırma araçlarını kullanın.

## Kurulum

### Paket Yöneticileri

#### macOS / Linux (Homebrew)

```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

[En son sürümden](https://github.com/virviil/oci2git/releases/latest) .deb paketini indirip kurun:

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### Arch Linux (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### Önceden Derlenmiş İkili Dosyalar

Platformunuza uygun ikili dosyayı [en son sürümden](https://github.com/virviil/oci2git/releases/latest) indirin:

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### Crates.io'dan

```bash
cargo install oci2git
```

### Kaynak

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## Kullanım

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — OCI imajı → Git deposu

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```

Seçenekler:
  `-o, --output <OUTPUT>`  Git deposu için çıktı dizini [varsayılan: ./container_repo]
  `-e, --engine <ENGINE>`  Kullanılacak konteyner motoru (docker, nerdctl, tar) [varsayılan: docker]
  `-v, --verbose`          Ayrıntılı mod (-v bilgi için, -vv hata ayıklama için, -vvv izleme için)

### `fsbom` — Dosya sistemi bileşen listesi

```bash
oci2git fsbom [OPTIONS] <IMAGE>
```

Seçenekler:
  `-o, --output <OUTPUT>`  YAML BOM dosyası için çıktı yolu [varsayılan: ./fsbom.yml]
  `-e, --engine <ENGINE>`  Kullanılacak konteyner motoru (docker, nerdctl, tar) [varsayılan: docker]
  `-v, --verbose`          Ayrıntılı mod (-v bilgi için, -vv hata ayıklama için, -vvv izleme için)

Ortam Değişkenleri:
  `TMPDIR`  Varsayılan olarak ara veri işlemesi için kullanılan konumu değiştirmek için bu ortam değişkenini ayarlayın. Bu platforma bağlıdır (örneğin, Unix/macOS için `TMPDIR`, Windows için `TEMP` veya `TMP`).

## Örnekler

### Dönüştür

Docker motoru kullanılarak (varsayılan):
```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```

Zaten indirilmiş bir imaj tarball'ını kullanmak:
```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Tar motoru, genellikle `docker save` ile oluşturulan geçerli bir OCI formatında tarball bekler:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Bu, `./ubuntu-repo` dizininde aşağıdakileri içeren bir Git deposu oluşturacaktır:
- `Image.md` - Görüntü hakkında Markdown formatında tam meta veriler
- `rootfs/` - Kaptan alınan dosya sistemi içeriği

Git geçmişi, konteynerin katman geçmişini yansıtır:
- İlk commit yalnızca tam meta verilerle `Image.md` dosyasını içerir
- Her sonraki commit, orijinal görüntüden bir katmanı temsil eder
- Commit mesajı olarak Dockerfile komutu eklenir

### Dosya Sistemi Malzeme Faturası (fsbom)

Her katmanda eklenen veya değiştirilen tüm dosyaların YAML listesi oluşturulur:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```

Bir tarball kullanarak:
```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```

Çıktı YAML, her katmanı girdileri türüne göre etiketlenmiş olarak (`file`, `hardlink`, `symlink`, `directory`) ve durumu ile birlikte (`n:uid:gid` yeni için, `m:uid:gid` değiştirilmiş için) listeler. Silinen dosyalar (OCI whiteout'ları) hariç tutulmuştur.

```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

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

[dokümantasyon]: https://docs.rs/oci2git/



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---