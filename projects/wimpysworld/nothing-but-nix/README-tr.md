
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Sadece Nix

**GitHub Actions runner'ınızı [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ gücüne dönüştürün, önceden kurulu gereksiz dosyaları acımasızca temizleyin.**

GitHub Actions runner'ları Nix için çok az disk alanıyla gelir - yalnızca ~20GB.
*Sadece Nix* **gereksiz yazılımları acımasızca temizler** ve Nix store için size **65GB ila 130GB** alan kazandırır! 💪

## Kullanım 🔧

Bu işlemi iş akışınızda Nix'i kurmadan **önce** ekleyin:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### Gereksinimler ️✔️

- Yalnızca resmi **Ubuntu** GitHub Actions runner'larını destekler
- Nix kurulmadan **önce** çalıştırılmalıdır
- **macOS/Darwin runner'ları**: Bu işlem macOS üzerinde çalıştırılırsa uyarı ile zarifçe atlanır. macOS runner'ları Nix için yeterli alan sağlar ve bu işleme ihtiyaç duymaz
- **Windows runner'ları**: Bu işlem Windows üzerinde çalıştırılırsa uyarı ile zarifçe atlanır. Windows runner'larında farklı dosya sistemi düzenleri ve kısıtlamalar vardır

## Sorun: Nix'in Gelişmesi İçin Yer Açmak 🌱

Standart GitHub Actions runner'ları, Nix iş akışında asla kullanmayacağınız *"gereksiz yazılımlar"* ile doludur:

- 🌍 Web tarayıcıları. Bir sürü! Hepsini toplamak lazım!
- 🐳 Docker imajları, değerli disk alanını gigabaytlarca tüketiyor
- 💻 Gereksiz dil çalışma ortamları (.NET, Ruby, PHP, Java...)
- 📦 Dijital toz biriktiren paket yöneticileri
- 📚 Kimsenin okumayacağı dokümantasyonlar

Bu şişkinlik, Nix deposu için yalnızca ~20GB bırakır - ciddi Nix derlemeleri için zar zor yeter! 😞

## Çözüm: Sadece Nix ️❄️

**Sadece Nix**, GitHub Actions runner'larına kökten bir yaklaşım getirir ve disk alanını acımasızca geri kazanmak için iki aşamalı bir saldırı kullanır:

1. **İlk Hamle:** Hemen `/mnt` dizininden boş alanı kullanarak büyük bir `/nix` bölümü (~65GB) oluşturur
2. **Arka Plan Tahribatı:** İş akışınız devam ederken, gereksiz yazılımlar acımasızca silinir ve `/nix` bölümü ~130GB'a kadar genişletilir
   - Web tarayıcıları? Hayır ⛔
   - Docker imajları? Gitti 🗑️
   - Dil çalışma ortamları? Yok edildi 💥
   - Paket yöneticileri? Yok edildi 💣
   - Dokümantasyon? Buharlaştırıldı ️👻

Dosya sistemi temizliği `rmz` tarafından gerçekleştirilmektedir ([Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) projesinden) - alanı ışık hızında geri kazandıran, `rm`'ye yüksek performanslı bir alternatif! ⚡
   - Standart `rm`'ye göre kat kat daha hızlı çalışır
   - Silme işlemlerini maksimum verimlilik için paralel olarak yürütür
   - **Disk alanını dakikalar yerine saniyeler içinde geri kazanır!** ️⏱️

Sonuç? **65GB ile 130GB** arasında Nix'e hazır bir GitHub Actions runner! 😁

### Dinamik Bölüm Büyümesi
Diğer çözümlerden farklı olarak, **Nothing but Nix** `/nix` biriminizi dinamik olarak büyütür:

1. **Başlangıç Birim Oluşturma (1-10 saniye):** (*Hatchet Protokolüne bağlı olarak*)
   - `/mnt` üzerindeki boş alandan bir döngü aygıtı oluşturur
   - RAID0 yapılandırmasında bir BTRFS dosya sistemi kurar
   - Sıkıştırma ve performans ayarıyla bağlar
   - Temizlik başlamadan önce bile anında 65GB'lık bir `/nix` sunar

2. **Arka Planda Genişletme (30-180 saniye):** (*Hatchet Protokolüne bağlı olarak*)
   - Temizlik işlemlerini yürütür
   - Şişkinlik giderildikçe yeni boşalan alanı izler
   - `/nix` birimine dinamik olarak bir genişletme diski ekler
   - Dosya sistemini yeni alanı dahil edecek şekilde yeniden dengeler

`/nix` birimi, iş akışı yürütülürken otomatik olarak **büyür** 🎩🪄

### Silahını Seç: Hatchet Protokolü 🪓

`hatchet-protocol` girdisiyle yok etme seviyesini kontrol edin 💥:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### Protokol Karşılaştırması ⚖️

| Protokol | `/nix` | Açıklama                                         | Apt temizle | Docker temizle | Snap temizle | Temizlenen dosya sistemleri     |
|----------|--------|--------------------------------------------------|-------------|----------------|--------------|-------------------------------|
| Holster  | ~65GB  | Baltayı kılıfında tut, alanı `/mnt`'den kullan   | Hayır       | Hayır          | Hayır        | Yok                          |
| Carve    | ~85GB  | Boş alanı `/` ve `/mnt`'den birleştir ve oluştur| Hayır       | Hayır          | Hayır        | Yok                          |
| Cleave   | ~115GB | Büyük paketlere güçlü, kararlı kesikler at       | Minimal     | Evet           | Evet         | `/opt` ve `/usr/local`        |
| Rampage  | ~130GB | Tüm şişkinliği acımasızca, vahşice yok et        | Agresif     | Evet           | Evet         | Muahahaha! 🔥🌎               |

Aklı başında seçim yap:
- **Holster** koşucu araçlarının tamamen çalışır kalmasını istiyorsan
- **Carve** işlevsel koşucu araçlarını korurken tüm boş alanı Nix'e ayırmak için
- **Cleave** (*varsayılan*) alan ve işlevsellik arasında iyi bir denge için
- **Rampage** en fazla Nix alanı gerektiğinde ve neyin bozulduğuna aldırmıyorsan `#nix-is-life`

### Katliama Tanık Olun 🩸

Varsayılan olarak, temizleme işlemi iş akışınız devam ederken arka planda sessizce yürütülür. Ama katliamı gerçek zamanlı izlemek isterseniz:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Güvenli Bölgeleri Özelleştirin 🛡️

Nix deposunun alan kaplamasından ne kadar yer ayıracağınızı özel güvenli bölge boyutlarıyla kontrol edin:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

Bu güvenli alanlar, alan geri kazanımı sırasında acımasızca ne kadar alanın (MB cinsinden) korunacağını tanımlar:
- Varsayılan `root-safe-haven` 2048MB (2GB)'dır
- Varsayılan `mnt-safe-haven` 1024MB (1GB)'dır

Dosya sistemlerinizde daha fazla nefes alma alanına ihtiyacınız varsa bu değerleri artırın veya hiç merhamet göstermemek için azaltın! 😈

### /nix Dizininin Kullanıcıya Sahipliğini Verin (Nix İzin Fermanı) 🧑‍⚖️

Bazı Nix yükleyicileri veya yapılandırmaları, `/nix` dizininin mevcut kullanıcı tarafından yazılabilir olmasını bekler. Varsayılan olarak, `/nix` root'a aittir. Kullanıcı sahipliğine ihtiyacınız varsa (örneğin, tüm işlemler için `/nix` içinde `sudo` kullanmayan bazı Nix yükleyici betikleri için), `nix-permission-edict`i etkinleştirebilirsiniz:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

`nix-permission-edict` değeri `true` olarak ayarlandığında, işlem `/nix`i bağladıktan sonra `sudo chown -R "$(id --user)":"$(id --group)" /nix` komutunu çalıştırır.

### Nix'i /nix/build kullanacak şekilde yapılandırın

Bu işlem, geri kazanılan alanı kullanmak için Nix türetme yapılarının kullanması amacıyla `/nix/build` dizinini oluşturur. Nix yapılandırmanıza `build-dir` ekleyin:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

Ya da DeterminateSystems ile:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```
Bu, Nix'i büyük BTRFS hacminde derlemeler yapmaya yönlendirir; böylece sistemin varsayılan geçici dizini yerine kullanılır.

## Sorun Giderme 🔍

### Büyük derlemelerde "Aygıtta yer kalmadı" hatası

Derlemeniz yalnızca Nix'i kullandığınız halde yer bitiyorsa, muhtemelen arka planda yapılan temizleme işlemi tamamlanmadan derlemeniz mevcut alanı tüketmiştir. Bu genellikle şu durumları etkiler:

- Büyük disk imajları oluşturan NixOS VM testleri
- Önbelleğe alınmamış çok sayıda bağımlılığa sahip derlemeler
- Rust araç zinciri ve diğer büyük derlemeler

**Çözüm:** Eşzamanlı temizlemeyi zorlamak için `witness-carnage: true` kullanın. Bu, tüm alanın derlemeniz başlamadan *önce* geri kazanılmasını sağlar:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

Bu, iş akışı kurulumunuza 30-180 saniye ekler, ancak derlemeniz başladığında maksimum alanın kullanılabilir olmasını garanti eder.

Şimdi o muhteşem Nix store alanıyla harika bir şey inşa etmeye gidin! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---