# Stable Diffusion web UI
Stable Diffusion için Gradio kütüphanesi kullanılarak uygulanmış bir web arayüzü.

![](screenshot.png)

## Özellikler
[Görsellerle detaylı özellik tanıtımı](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Orijinal txt2img ve img2img modları
- Tek tıkla kurulum ve çalıştırma scripti (ancak yine de python ve git yüklemeniz gerekir)
- Dış boyama (Outpainting)
- İç boyama (Inpainting)
- Renkli Taslak (Color Sketch)
- Komut Matrisi (Prompt Matrix)
- Stable Diffusion Üst Ölçekleme (Upscale)
- Dikkat, modelin daha fazla odaklanması gereken metin bölümlerini belirtin
    - bir adam `((smokin))` içinde - smokine daha fazla dikkat edilecek
    - bir adam `(smokin:1.21)` içinde - alternatif sözdizimi
    - metni seçin ve `Ctrl+Up` veya `Ctrl+Down` (veya MacOS'ta `Command+Up` veya `Command+Down`) tuşlarına basarak seçilen metne otomatik olarak dikkat ayarı yapın (anonim bir kullanıcı tarafından katkı sağlandı)
- Geri döngü (Loopback), img2img işlemini birden fazla kez çalıştırın
- X/Y/Z grafiği, farklı parametrelerle görsellerin 3 boyutlu grafiğini çizin
- Metinsel Tersine Çevirme (Textual Inversion)
    - istediğiniz kadar embedding kullanın ve istediğiniz isimleri verin
    - token başına farklı vektör sayısına sahip birden fazla embedding kullanın
    - yarı hassas kayan noktalı sayılarla çalışır
    - 8GB bellekte embedding eğitin (6GB çalışanlar da bildirilmiştir)
- Ekstralar sekmesi ile:
    - GFPGAN, yüzleri düzelten sinir ağı
    - CodeFormer, GFPGAN'a alternatif yüz restorasyon aracı
    - RealESRGAN, sinir ağı üst ölçekleyici
    - ESRGAN, birçok üçüncü parti modele sahip sinir ağı üst ölçekleyici
    - SwinIR ve Swin2SR ([buraya bakın](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), sinir ağı üst ölçekleyiciler
    - LDSR, Latent diffusion süper çözünürlük üst ölçekleme
- Yeniden boyutlandırma en-boy oranı seçenekleri
- Örnekleme yöntemi seçimi
    - Örnekleyici eta değerlerini (gürültü çarpanı) ayarlayın
    - Daha gelişmiş gürültü ayarı seçenekleri
- İstediğiniz anda işlemi durdurun
- 4GB ekran kartı desteği (2GB çalışanlar da bildirilmiştir)
- Gruplar için doğru tohumlar (seed)
- Canlı komut token uzunluğu doğrulaması
- Üretim parametreleri
     - görsel üretirken kullandığınız parametreler o görselle birlikte kaydedilir
     - PNG için PNG chunk'larında, JPEG için EXIF'te
     - görseli PNG info sekmesine sürükleyerek üretim parametrelerini geri yükleyebilir ve otomatik olarak arayüze kopyalayabilirsiniz
     - ayarlardan devre dışı bırakılabilir
     - bir görseli/metin-parametresini prompt kutusuna sürükleyip bırakın
- Üretim Parametrelerini Oku Butonu, prompt kutusundaki parametreleri arayüze yükler
- Ayarlar sayfası
- Arayüzden keyfi python kodu çalıştırma (etkinleştirmek için `--allow-code` ile çalıştırılmalı)
- Çoğu arayüz öğesi için mouse-over ipuçları
- Arayüz öğeleri için varsayılan/min/maks/adım değerlerini metin konfigürasyonu ile değiştirme imkanı
- Döşeme (tiling) desteği, dokular gibi döşenebilir görseller oluşturmak için bir onay kutusu
- İlerleme çubuğu ve canlı görsel üretim önizlemesi
    - Neredeyse hiç VRAM veya hesaplama gerektirmeyen ayrı bir sinir ağı ile önizleme üretilebilir
- Negatif komut, üretilen görselde görmek istemediklerinizi listelemenizi sağlayan ekstra bir metin alanı
- Stiller, komutun bir kısmını kaydedip daha sonra açılır menü ile kolayca uygulama yöntemi
- Varyasyonlar, aynı görseli küçük farklılıklarla üretme yöntemi
- Seed yeniden boyutlandırma, aynı görseli biraz farklı çözünürlükte üretme yöntemi
- CLIP sorgulayıcı, bir görselden komutu tahmin etmeye çalışan bir buton
- Komut Düzenleme, üretim sırasında komutu değiştirme yöntemi, örneğin karpuzla başlayıp yarıda anime kıza geçmek gibi
- Toplu İşleme, img2img ile bir dosya grubunu işleme
- Img2img Alternatifi, çapraz dikkat kontrolünün ters Euler yöntemi
- Yüksek Çözünürlük Düzeltmesi, tek tıkla yüksek çözünürlüklü resimler üretmek için kolaylık seçeneği (normalde oluşan bozulmalar olmadan)
- Anında kontrol noktalarını (checkpoint) yeniden yükleme
- Kontrol Noktası Birleştirici, en fazla 3 kontrol noktasını birleştiren sekme
- [Özel scriptler](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) ve topluluktan birçok eklenti
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), aynı anda birden fazla komut kullanma yöntemi
     - komutları büyük harf `AND` ile ayırın
     - komutlar için ağırlık da destekler: `a cat :1.2 AND a dog AND a penguin :2.2`
- Komutlar için token sınırı yok (orijinal stable diffusion'da en fazla 75 token kullanılabiliyor)
- DeepDanbooru entegrasyonu, anime komutları için danbooru stili etiketler oluşturur
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), seçili kartlar için büyük hız artışı: (komut satırı argümanlarına `--xformers` ekleyin)
- eklentiyle: [Geçmiş sekmesi](https://github.com/yfszzx/stable-diffusion-webui-images-browser): görselleri arayüzden kolayca görüntüleyin, doğrudan ve silin
- Sonsuza kadar üret seçeneği
- Eğitim sekmesi
     - hiper ağlar ve embedding seçenekleri
     - Görselleri ön işleme: kırpma, ayna, BLIP veya deepdanbooru ile otomatik etiketleme (anime için)
- Clip skip
- Hiper ağlar (Hypernetworks)
- Lora'lar (Hypernetworks ile aynı ama daha güzel)
- Hangi embedding, hiper ağ veya Lora'yı komutunuza ekleyeceğinizi önizlemeli ayrı bir arayüz
- Ayarlar ekranından farklı bir VAE yükleme seçeneği
- İlerleme çubuğunda tahmini bitiş süresi
- API
- RunwayML tarafından sağlanan özel [inpainting model](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) desteği
- eklentiyle: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), clip görsel embedding kullanarak belirli bir estetikte görsel üretme yöntemi ([https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients) uygulaması)
- [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) desteği - talimatlar için [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20)
- [Alt-Diffusion](https://arxiv.org/abs/2211.06679) desteği - talimatlar için [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion)
- Artık kötü harfler olmadan!
- Safetensors formatında kontrol noktası (checkpoint) yükleme
- Kolaylaştırılmış çözünürlük kısıtı: üretilen görselin boyutları artık 64 yerine 8'in katı olmalı
- Artık lisanslı!
- Ayarlar ekranından arayüz öğelerini yeniden sıralama
- [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B) desteği

## Kurulum ve Çalıştırma
Gerekli [bağımlılıkların](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) karşılandığından emin olun ve aşağıdaki talimatları izleyin:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (önerilir)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPU'lar.
- [Intel CPU, Intel GPU (hem entegre hem ayrık)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (harici wiki sayfası)
- [Ascend NPU'lar](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (harici wiki sayfası)

Alternatif olarak, çevrimiçi hizmetleri (Google Colab gibi) kullanabilirsiniz:

- [Çevrimiçi Hizmetler Listesi](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### NVidia-GPU'lu Windows 10/11'de sürüm paketiyle kurulum
1. [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) adresinden `sd.webui.zip` dosyasını indirip içeriğini çıkarın.
2. `update.bat` dosyasını çalıştırın.
3. `run.bat` dosyasını çalıştırın.
> Daha fazla ayrıntı için bkz. [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Windows'ta Otomatik Kurulum
1. [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) yükleyin (Daha yeni Python sürümleri torch'u desteklemez), "Add Python to PATH" kutucuğunu işaretleyin.
2. [git](https://git-scm.com/download/win) yükleyin.
3. stable-diffusion-webui deposunu indirin, örneğin `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git` komutunu çalıştırarak.
4. `webui-user.bat` dosyasını Windows Gezgini'nden normal (yönetici olmayan) kullanıcı olarak çalıştırın.

### Linux'ta Otomatik Kurulum
1. Bağımlılıkları yükleyin:
```bash
# Debian tabanlı:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat tabanlı:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE tabanlı:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch tabanlı:
sudo pacman -S wget git python3
```
Sisteminiz çok yeniyse python3.11 veya python3.10 yüklemeniz gerekir:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # python3.11 paketiyle karıştırmayın

# Sadece 3.11 için
# Sonra launch scriptinde env değişkenini ayarlayın
export python_cmd="python3.11"
# veya webui-user.sh içinde
python_cmd="python3.11"
```
2. Webui'nin kurulmasını istediğiniz dizine gidin ve şu komutu çalıştırın:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
Veya sadece depoyu istediğiniz yere klonlayın:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. `webui.sh` çalıştırın.
4. Seçenekler için `webui-user.sh` dosyasını kontrol edin.
### Apple Silicon'da Kurulum

Talimatları [burada](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon) bulabilirsiniz.

## Katkıda Bulunma
Bu depoya nasıl kod ekleyeceğinizi buradan öğrenebilirsiniz: [Katkıda Bulunma](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Dokümantasyon

Dokümantasyon bu README dosyasından projenin [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki) sayfasına taşınmıştır.

Google ve diğer arama motorlarının wiki'yi tarayabilmesi için, (insanlar için değil) [tarayabilir wiki](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki) bağlantısı burada.

## Katkılar
Ödünç alınan kodların lisanslarını `Ayarlar -> Lisanslar` ekranında ve ayrıca `html/licenses.html` dosyasında bulabilirsiniz.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel uygulamaları
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- Optimizasyon fikirleri - https://github.com/basujindal/stable-diffusion
- Cross Attention katmanı optimizasyonu - Doggettx - https://github.com/Doggettx/stable-diffusion, komut düzenleme için orijinal fikir.
- Cross Attention katmanı optimizasyonu - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (orijinali http://github.com/lstein/stable-diffusion)
- Alt-kare Cross Attention katmanı optimizasyonu - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Metinsel Tersine Çevirme - Rinon Gal - https://github.com/rinongal/textual_inversion (kodunu kullanmıyoruz, ama fikirlerinden faydalanıyoruz).
- SD üst ölçekleme fikri - https://github.com/jquesnelle/txt2imghd
- Outpainting mk2 için gürültü üretimi - https://github.com/parlance-zz/g-diffuser-bot
- CLIP sorgulayıcı fikri ve bazı kodlar - https://github.com/pharmapsychotic/clip-interrogator
- Composable Diffusion fikri - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - anime diffusers için sorgulayıcı https://github.com/KichangKim/DeepDanbooru
- float16 UNet'ten float32 hassasiyetle örnekleme - fikir için marunine, Diffusers uygulama örneği için Birch-san (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- Güvenlik tavsiyesi - RyotaK
- UniPC örnekleyici - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Yeniden başlatma örnekleme - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- İlk Gradio scripti - 4chan'de anonim bir kullanıcı tarafından paylaşıldı. Teşekkürler anonim kullanıcı.
- (Sen)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---