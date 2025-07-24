
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

**GitHub Actions runner'ınızı önceden yüklü gereksiz yazılımları acımasızca kaldırarak bir [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ gücüne dönüştürün.**

GitHub Actions runner'ları Nix için çok az disk alanı ile gelir - sadece ~20GB civarı.
*Sadece Nix* **gereksiz yazılımları acımasızca temizler**, Nix deposu için size **65GB ila 130GB** alan kazandırır! 💪

## Kullanım 🔧

Bu işlemi iş akışınızda Nix'i yüklemeden **önce** ekleyin:

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

## Sorun: Nix'in Gelişmesi İçin Yer Açmak 🌱

Standart GitHub Actions runner'ları, bir Nix iş akışında asla kullanmayacağınız *"gereksiz yazılımlarla"* doludur:

- 🌍 Web tarayıcıları. Hem de bir sürü. Hepsi olmalı!
- 🐳 Disk alanının gigabaytlarını tüketen Docker imajları
- 💻 Gereksiz dil çalışma zamanları (.NET, Ruby, PHP, Java...)
- 📦 Dijital toz toplayan paket yöneticileri
- 📚 Kimsenin asla okumayacağı belgeler

Bu şişkinlik, Nix store'unuz için yalnızca ~20GB bırakır - ciddi Nix derlemeleri için zar zor yeterli! 😞

## Çözüm: Sadece Nix ️❄️

**Sadece Nix**, GitHub Actions runner'larına karşı yakıp yıkma yaklaşımı benimser ve disk alanını acımasızca geri kazanmak için iki aşamalı bir saldırı uygular:

1. **İlk Kesim:** Boş alanı `/mnt`'den alarak anında büyük bir `/nix` bölümü (~65GB) oluşturur
2. **Arka Plan Yıkımı:** İş akışınız devam ederken, gereksiz yazılımları acımasızca silerek `/nix` hacminizi ~130GB'a kadar genişletir
   - Web tarayıcıları? Hayır ⛔
   - Docker imajları? Gitti 🗑️
   - Dil çalışma zamanları? Yok edildi 💥
   - Paket yöneticileri? İmha edildi 💣
   - Belgeler? Buharlaştı ️👻

Dosya sistemi temizliği, [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) projesinden `rmz` tarafından sağlanır - alan geri kazanımını yıldırım hızında yapan yüksek performanslı bir `rm` alternatifidir! ⚡
   - Standart `rm`'den katbekat daha hızlıdır
   - Maksimum verimlilik için silme işlemlerini paralel olarak yürütür
   - **Disk alanını dakikalar yerine saniyeler içinde geri kazanır!** ️⏱️

Sonuç? **65GB ila 130GB** Nix'e hazır alanı olan bir GitHub Actions runner'ı! 😁

### Dinamik Hacim Büyümesi

Diğer çözümlerden farklı olarak, **Sadece Nix** `/nix` hacminizi dinamik olarak büyütür:

1. **İlk Hacim Oluşturma (1-10 saniye):** (*Hatchet Protocol'e bağlı olarak*)
   - `/mnt` üzerindeki boş alandan bir loop aygıtı oluşturur
   - RAID0 yapılandırmasında bir BTRFS dosya sistemi kurar
   - Sıkıştırma ve performans ayarlarıyla mount eder
   - Temizlik başlamadan hemen önce 65GB'lık bir `/nix` sunar

2. **Arka Plan Genişlemesi (30-180 saniye):** (*Hatchet Protocol'e bağlı olarak*)
   - Temizleme işlemlerini gerçekleştirir
   - Şişkinlik temizlendikçe yeni açılan alanı izler
   - `/nix` hacmine dinamik olarak bir genişletme diski ekler
   - Dosya sistemini yeni alanı dahil edecek şekilde yeniden dengeler

`/nix` hacmi **iş akışı çalışırken otomatik olarak büyür** 🎩🪄

### Silahını Seç: Hatchet Protocol 🪓

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

`nix-permission-edict` değeri `true` olarak ayarlandığında, işlem `/nix` bağlandıktan sonra `sudo chown -R "$(id --user)":"$(id --group)" /nix` komutunu çalıştıracaktır.

Şimdi bu muhteşem Nix deposu alanıyla harika bir şeyler inşa et! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---