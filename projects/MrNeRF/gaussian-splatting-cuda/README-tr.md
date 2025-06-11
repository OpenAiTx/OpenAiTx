# Gerçek Zamanlı Radyans Alanı Renderlama için 3B Gauss Splatting - C++ ve CUDA Uygulaması

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

[gsplat](https://github.com/nerfstudio-project/gsplat) rasterizasyon altyapısı üzerine kurulu yüksek performanslı C++ ve CUDA 3B Gauss Splatting uygulaması.

## Haberler
- **[2025-06-10]**: Bazı sorunlar giderildi. gsplat metriklerine yaklaşmaktayız. Ancak hala küçük bir uyumsuzluk var.
- **[2025-06-04]**: Maksimum Gauss sayısını kontrol etmek için `--max-cap` komut satırı seçeneği ile MCMC stratejisi eklendi.
- **[2025-06-03]**: Gsplat altyapısına geçildi ve lisans güncellendi.
- **[2024-05-27]**: Daha iyi uyumluluk ve performans için LibTorch 2.7.0’a güncellendi. Optimizatör durum yönetimindeki büyük değişiklikler ele alındı.
- **[2024-05-26]**: Bu repo’nun mevcut hedefi izin verici bir lisansa geçiş yapmak. Rasterizer, gsplat implementasyonu ile değiştirildi.

## Metrikler
Mevcut uygulama gsplat-mcmc ile aynı düzeyde sonuç vermiyor ancak çalışma devam ediyor.  
Hatanın düzeltilmesi sadece zaman meselesi. Yardımınıza açığız :) MCMC stratejisi için metrikler:

| Sahne     | İterasyon | PSNR          | SSIM         | LPIPS        | Görüntü Başına Süre | Gauss Sayısı |
| --------- | --------- | ------------- | ------------ | ------------ | ------------------- | ------------ |
| garden    | 30000     | 27.112114     | 0.854833     | 0.157624     | 0.304765            | 1000000      |
| bicycle   | 30000     | 25.047745     | 0.767729     | 0.254825     | 0.293618            | 1000000      |
| stump     | 30000     | 26.554749     | 0.784203     | 0.263013     | 0.296536            | 1000000      |
| bonsai    | 30000     | 32.534199     | 0.948675     | 0.246924     | 0.436188            | 1000000      |
| counter   | 30000     | 29.187017     | 0.915823     | 0.242159     | 0.441259            | 1000000      |
| kitchen   | 30000     | 31.680832     | 0.933897     | 0.154965     | 0.449078            | 1000000      |
| room      | 30000     | 32.211632     | 0.930754     | 0.273719     | 0.413519            | 1000000      |
| **ortalama** | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**        | **1000000**  |

## Topluluk & Destek

Tartışmalar, destek ve güncellemeler için büyüyen topluluğumuza katılın:  
- 💬 **[Discord Topluluğu](https://discord.gg/TbxJST2BbC)** - Yardım alın, sonuçlar paylaşın, geliştirmeleri tartışın  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - Daha fazla kaynak için web sitemizi ziyaret edin  
- 📚 **[Harika 3B Gauss Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - Kapsamlı makale listesi ve kaynaklar  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - En son güncellemeler için takip edin

## Derleme ve Çalıştırma Talimatları

### Yazılım Gereksinimleri
1. **Linux** (Ubuntu 22.04 ile test edildi) - Windows şu anda desteklenmiyor  
2. **CMake** 3.24 veya üzeri  
3. **CUDA** 11.8 veya üzeri (daha düşük versiyonlarda elle yapılandırma gerekebilir)  
4. **Python** geliştirme başlıkları ile  
5. **LibTorch 2.7.0** - Kurulum talimatları aşağıda  
6. Diğer bağımlılıklar CMake tarafından otomatik olarak yönetilir

### Donanım Gereksinimleri
1. **CUDA destekli NVIDIA GPU**  
    - Başarıyla test edilenler: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - RTX 3080Ti ile büyük veri setlerinde bilinen sorunlar (#21 bakınız)  
2. Minimum hesaplama yeteneği: 8.0

> Başka donanımlarda başarıyla çalıştırdıysanız, deneyiminizi Tartışmalar bölümünde paylaşın!

### Derleme Talimatları

```bash
# Alt modüllerle birlikte repoyu klonlayın
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# LibTorch indirin ve kurun
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# Projeyi derleyin
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

Bu proje optimal performans ve uyumluluk için **LibTorch 2.7.0** kullanır:

- **Geliştirilmiş Performans**: İyileştirilmiş optimizasyon ve bellek yönetimi  
- **API Kararlılığı**: En son kararlı PyTorch C++ API  
- **CUDA Uyumluluğu**: CUDA 11.8+ ile daha iyi entegrasyon  
- **Hata Düzeltmeleri**: Optimizatör durum yönetimi sorunları giderildi

### Önceki Sürümlerden Yükseltme
1. Derleme talimatları ile yeni LibTorch sürümünü indirin  
2. Derleme dizininizi temizleyin: `rm -rf build/`  
3. Projeyi yeniden derleyin

## Veri Seti

Orijinal repodan veri setini indirin:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

Proje kökündeki `data` klasörüne çıkarın.

## Komut Satırı Seçenekleri

### Temel Seçenekler

- **`-h, --help`**  
  Yardım menüsünü gösterir

- **`-d, --data-path [YOL]`**  
  Eğitim verisinin yolu (zorunlu)

- **`-o, --output-path [YOL]`**  
  Eğitilmiş modelin kaydedileceği yol (varsayılan: `./output`)

- **`-i, --iter [SAYI]`**  
  Eğitim iterasyon sayısı (varsayılan: 30000)  
    - Makale 30k öneriyor, ancak 6k-7k genellikle iyi ön sonuçlar verir  
    - Çıktılar her 7k iterasyonda ve tamamlandığında kaydedilir

- **`-f, --force`**  
  Var olan çıktı klasörünün üzerine yazmayı zorlar

- **`-r, --resolution [SAYI]`**  
  Eğitim görüntüleri için çözünürlük ayarlar

### MCMC’ye Özel Seçenekler

- **`--max-cap [SAYI]`**  
  MCMC stratejisi için maksimum Gauss sayısı (varsayılan: 1000000)  
    - Eğitim sırasında Gauss splatların üst sınırını kontrol eder  
    - Bellek kısıtlaması olan ortamlar için faydalıdır

### Örnek Kullanım

Temel eğitim:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

MCMC ile sınırlı Gauss sayısı kullanarak eğitim:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## Katkı Rehberi

Katkılarınıza açığız! İşte başlamanız için bazı adımlar:

1. **Başlarken**:  
    - Yeni başlayanlar için uygun olan **good first issues** etiketli sorunlara bakın  
    - Yeni fikirler için tartışma açın veya [Discord](https://discord.gg/TbxJST2BbC) topluluğumuza katılın

2. **PR Göndermeden Önce**:  
    - Tutarlı kod stili için `clang-format` uygulayın  
    - Ön-commit kancasını kullanın: `cp tools/pre-commit .git/hooks/`  
    - Yeni bağımlılıkları önce bir issue’da tartışın - bağımlılıkları minimumda tutmaya çalışıyoruz

## Teşekkürler

Bu uygulama aşağıdaki önemli projeler üzerine inşa edilmiştir:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: Performans ve bellek verimliliğinde büyük iyileştirme sağlayan, yüksek optimize edilmiş CUDA rasterizasyon altyapısı.

- **Orijinal 3B Gauss Splatting**: Kerbl ve arkadaşlarının öncü çalışması temel alınmıştır.

## Atıf

Bu yazılımı araştırmalarınızda kullanıyorsanız, lütfen orijinal çalışmayı şu şekilde atıf yapınız:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## Lisans

Detaylar için LICENSE dosyasına bakınız.

---

**Bizimle bağlantıda kalın:**  
- 🌐 Web Sitesi: [mrnerf.com](https://mrnerf.com)  
- 📚 Makaleler: [Harika 3B Gauss Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [Topluluğumuza Katılın](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter: Geliştirme güncellemeleri için [@janusch_patas](https://twitter.com/janusch_patas) takip edin

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---