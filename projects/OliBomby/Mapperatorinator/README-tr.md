
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Mapperatorinator

Jeneratif modeli [burada](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb) veya MaiMod'u [burada](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb) deneyin. Video tanıtımını [buradan](https://youtu.be/FEr7t1L2EoA) izleyebilirsiniz.

Mapperatorinator, spektrogram girişlerini kullanarak tüm oyun modları için tam özellikli osu! beatmap'leri üreten ve [beatmap modlamada yardımcı olan](#maimod-the-ai-driven-modding-tool) çok modelli bir çerçevedir.
Bu projenin amacı, herhangi bir şarkıdan yüksek derecede özelleştirilebilir, sıralanabilir kalitede osu! beatmap'leri otomatik olarak üretmektir.

Bu proje [osuT5](https://github.com/gyataro/osuT5) ve [osu-diffusion](https://github.com/OliBomby/osu-diffusion) üzerine inşa edilmiştir. Bunu geliştirirken, 4060 Ti ve vast.ai'de kiralanan 4090 örneklerinde 142 çalışmada yaklaşık 2500 saat GPU hesaplama süresi harcadım.

#### Bu aracı sorumlu bir şekilde kullanın. Beatmap'lerinizde yapay zeka kullanımını her zaman belirtin.

## Kurulum

Aşağıdaki talimatlar, beatmap'leri yerel makinenizde oluşturmanıza olanak tanır; alternatif olarak [colab notebook](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb) ile bulutta çalıştırabilirsiniz.

### 1. Depoyu klonlayın

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. (Opsiyonel) Sanal ortam oluşturun

Python 3.10 kullanın, sonraki sürümler bağımlılıklarla uyumlu olmayabilir.

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. Bağımlılıkları yükleyin

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone) (NVIDIA GPU'lar için) veya [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (Linux'ta AMD GPU'lar için)
- [PyTorch](https://pytorch.org/get-started/locally/): `torch` ve `torchaudio`'yu GPU desteğiyle kurduğunuzdan emin olmak için Başlarken kılavuzunu takip edin. Önceki adımda kurduğunuz doğru Compute Platform sürümünü seçin.

- ve kalan Python bağımlılıkları:

```sh
pip install -r requirements.txt
```

## Web GUI (Önerilen)

Daha kullanıcı dostu bir deneyim için Web UI'yi kullanmayı düşünün. Grafiksel bir arayüz sunarak üretim parametrelerini yapılandırmanıza, işlemi başlatmanıza ve çıktıyı izlemenize olanak tanır.

### GUI'yi Başlatma

Terminalinizde klonlanmış `Mapperatorinator` dizinine gidin ve şunu çalıştırın:

```sh
python web-ui.py
```
Bu, yerel bir web sunucusunu başlatacak ve arayüzü otomatik olarak yeni bir pencerede açacaktır.

### GUI Kullanımı

- **Yapılandır:** Form alanlarını ve "Gözat" düğmelerini kullanarak giriş/çıkış yollarını ayarlayın. Komut satırı seçeneklerini yansıtarak oyun modu, zorluk, stil (yıl, haritacı kimliği, açıklayıcılar), zamanlama, belirli özellikler (vuruş sesleri, süper zamanlama) ve daha fazlası gibi üretim parametrelerini ayarlayın. (Not: Bir `beatmap_path` sağlarsanız, arayüz otomatik olarak `audio_path` ve `output_path` değerlerini bundan belirler, bu nedenle bu alanları boş bırakabilirsiniz)
- **Başlat:** Beatmap üretimini başlatmak için "Çıkarımı Başlat" düğmesine tıklayın.
- **İptal:** Devam eden işlemi "Çıkarımı İptal Et" düğmesiyle durdurabilirsiniz.
- **Çıktıyı Aç:** İşlem tamamlandığında, üretilen dosyalara hızlı erişim için "Çıktı Klasörünü Aç" düğmesini kullanın.

Web Arayüzü, `inference.py` betiğinin pratik bir sarmalayıcısı olarak görev yapar. Gelişmiş seçenekler veya sorun giderme için komut satırı talimatlarına bakın.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## Komut Satırı ile Çıkarım

Komut satırını tercih eden veya gelişmiş yapılandırmalara ihtiyaç duyan kullanıcılar aşağıdaki adımları izleyebilir. **Not:** Daha basit bir grafik arayüz için lütfen yukarıdaki [Web Arayüzü (Önerilen)](#web-ui-recommended) bölümüne bakın.

Beatmap üretmek için `inference.py` dosyasını çalıştırın ve bazı argümanlar iletin. Bunun için [Hydra geçersiz kılma söz dizimini](https://hydra.cc/docs/advanced/override_grammar/basic/) kullanın. Tüm mevcut parametreler için `configs/inference_v29.yaml` dosyasına bakın.

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```

Örnek:
```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## Etkileşimli CLI
Terminal tabanlı bir çalışma akışını tercih edenler için, etkileşimli CLI betiği Web UI'ya mükemmel bir alternatiftir.

### CLI'yi Başlatın
Klonlanan dizine gidin. Öncelikle betiği çalıştırılabilir hale getirmeniz gerekebilir.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### CLI Kullanımı
Script, Web UI'da olduğu gibi tüm üretim parametrelerini yapılandırmak için sizi bir dizi istemle yönlendirecektir.

Daha net olması için renk kodlu bir arayüz kullanır.
Stil tanımlayıcılarını seçmek için gelişmiş çoklu seçim menüsü sağlar; ok tuşlarınız ve boşluk tuşunu kullanabilirsiniz.
Tüm soruları yanıtladıktan sonra, son komutu incelemeniz için gösterecektir.
Sonrasında komutu doğrudan çalıştırmak için onaylayabilir veya iptal edip komutu manuel kullanım için kopyalayabilirsiniz.

## Üretim İpuçları

- Her seferinde terminalde yazmak yerine `configs/inference_v29.yaml` dosyasını düzenleyip argümanlarınızı oraya ekleyebilirsiniz.
- Tüm mevcut tanımlayıcılar [burada](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags) bulunabilir.
- Her zaman 2007 ile 2023 arasında bir yıl argümanı belirtin. Bilinmez bırakırsanız, model tutarsız bir tarzda üretebilir.
- Her zaman bir zorluk argümanı belirtin. Bilinmez bırakırsanız, model tutarsız bir zorlukta üretebilir.
- `cfg_scale` parametresini artırarak `mapper_id` ve `descriptors` argümanlarının etkinliğini artırabilirsiniz.
- Modeli bazı tarzlardan uzaklaştırmak için `negative_descriptors` argümanını kullanabilirsiniz. Bu yalnızca `cfg_scale > 1` olduğunda çalışır. Negatif tanımlayıcı sayısının tanımlayıcı sayısıyla eşit olduğundan emin olun.
- Şarkı tarzınız ve istediğiniz beatmap tarzı iyi eşleşmiyorsa, model yönergelerinizi takip etmeyebilir. Örneğin, sakin bir şarkı için yüksek SR, yüksek SV bir beatmap üretmek zordur.
- Bir şarkı için zamanlama ve kiai süreleri zaten hazırsa, bunları modele vererek çıkarım hızını ve doğruluğunu büyük ölçüde artırabilirsiniz: `beatmap_path` ve `in_context=[TIMING,KIAI]` argümanlarını kullanın.
- Beatmap'inizin sadece bir bölümünü yeniden eşlemek için `beatmap_path`, `start_time`, `end_time` ve `add_to_beatmap=true` argümanlarını kullanın.
- Bir beatmap için konuk zorluk üretmek için `beatmap_path` ve `in_context=[GD,TIMING,KIAI]` argümanlarını kullanın.
- Bir beatmap için hitsound üretmek için `beatmap_path` ve `in_context=[NO_HS,TIMING,KIAI]` argümanlarını kullanın.
- Bir şarkı için yalnızca zamanlama üretmek için `super_timing=true` ve `output_type=[TIMING]` argümanlarını kullanın.

## MaiMod: Yapay Zeka Destekli Modlama Aracı

MaiMod, Mapperatorinator tahminlerini kullanarak diğer otomatik modlama araçlarının (örn. [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier)) tespit edemediği olası hataları ve tutarsızlıkları bulabilen osu! beatmap'leri için bir modlama aracıdır.
Şu sorunları tespit edebilir:
- Yanlış snapping veya ritmik desenler
- Hatalı zamanlama noktaları
- Tutarsız hit nesnesi konumları veya yeni kombo yerleşimleri
- Garip slider şekilleri
- Tutarsız hitsound'lar veya ses seviyeleri

MaiMod'u [buradan](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb) deneyebilir veya yerelde çalıştırabilirsiniz:
MaiMod'u yerelde çalıştırmak için önce Mapperatorinator'u yüklemeniz gerekir. Ardından, `beatmap_path` argümanıyla beatmap'inizin yolunu belirterek `mai_mod.py` scriptini çalıştırın.
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
Bu, modlama önerilerini konsola yazdıracak, ardından bu önerileri beatmap'inize manuel olarak uygulayabilirsiniz.
Öneriler kronolojik olarak sıralanır ve kategorilere ayrılır.
Daire içindeki ilk değer 'sürprizal'dır; bu, modelin sorunu ne kadar beklenmedik bulduğunun bir ölçüsüdür, böylece en önemli sorunlara öncelik verebilirsiniz.

Model hata yapabilir, özellikle düşük sürprizal değerine sahip sorunlarda, bu yüzden önerileri beatmap'inize uygulamadan önce her zaman iki kez kontrol edin.
Ana amaç, potansiyel sorunlar için arama alanını daraltmanıza yardımcı olmaktır, böylece beatmap'inizdeki her bir vuruş nesnesini manuel olarak kontrol etmek zorunda kalmazsınız.

### MaiMod GUI
MaiMod Web UI'yı çalıştırmak için Mapperatorinator'ı yüklemeniz gerekecek.
Daha sonra `mai_mod_ui.py` betiğini çalıştırın. Bu, yerel bir web sunucusu başlatacak ve UI'yı otomatik olarak yeni bir pencerede açacaktır:

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## Genel Bakış

### Tokenleştirme

Mapperatorinator, osu! beatmap'lerini doğrudan tokenlara dönüştürülüp geri alınabilen bir ara olay temsiline dönüştürür.
Bu temsil, vurma nesneleri, vuruş sesleri, slider hızları, yeni kombinasyonlar, zamanlama noktaları, kiai zamanları ve taiko/mania kaydırma hızlarını içerir.

Tokenleştirme sürecine küçük bir örnek aşağıda gösterilmiştir:

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

Kelime dağarcığı boyutundan tasarruf etmek için, zaman olayları 10ms aralıklarla ve pozisyon koordinatları 32 piksel grid noktalarına kuantize edilir.

### Model mimarisi
Model, temelde [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration) modelinin etrafında bir sarmalayıcıdır, özel giriş gömme katmanları ve kayıp fonksiyonu içerir.
Model boyutu 219M parametreden oluşur.
Bu modelin, bu görev için T5'ten daha hızlı ve daha doğru olduğu bulunmuştur.

Modelin giriş-çıkışının üst düzey genel görünümü aşağıda gösterilmiştir:

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

Model, kodlayıcı girişi olarak Mel spektrogram çerçeveleri kullanır ve her giriş pozisyonu için bir çerçeve vardır. Modelin kod çözücü çıktısı, her adımda ayrık ve önceden tanımlanmış bir olay kelime dağarcığı üzerinde bir softmax dağılımıdır. Çıktılar seyrektir; olaylar yalnızca bir vurma nesnesi oluştuğunda gereklidir, tüm ses çerçevelerini etiketlemek gerekmez.

### Çoklu görevli eğitim formatı

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

SOS tokenından önce, koşullu üretimi kolaylaştıran ek tokenlar bulunur. Bu tokenlar oyun modu, zorluk, mapper ID, yıl ve diğer meta verileri içerir.
Eğitim sırasında, bu tokenların eşlik eden etiketleri yoktur, bu nedenle model tarafından asla çıktı olarak verilmezler.
Ayrıca eğitim sırasında, meta veri tokenının rastgele bir şekilde 'bilinmeyen' bir token ile değişme ihtimali vardır, böylece çıkarım sırasında bu 'bilinmeyen' tokenları kullanarak modele vermemiz gereken meta veri miktarını azaltabiliriz.

### Kesintisiz uzun üretim

Modelin bağlam uzunluğu 8.192 saniyedir. Bu, tam bir beatmap oluşturmak için yeterli değildir, bu yüzden şarkıyı birden fazla pencereye bölüp beatmap'i küçük parçalarda üretmemiz gerekir.
Oluşturulan beatmap'te pencereler arasında belirgin dikişler olmamasını sağlamak için %90 örtüşme kullanılır ve pencereler ardışık olarak üretilir.
İlk pencere dışında her üretim penceresi, kod çözücü önceki pencerelerden gelen tokenlar ile üretim penceresinin %50'sine kadar önceden doldurularak başlatılır.
Modelin, üretim penceresinin ilk %50'sinde zaman belirteçleri üretememesini sağlamak için bir logit işlemcisi kullanıyoruz.
Ayrıca, üretim penceresinin son %40'ı bir sonraki pencereye ayrılmıştır. Bu aralıktaki üretilen zaman belirteçleri EOS belirteçleri olarak kabul edilir.
Bu, her üretilen belirtecin en az 4 saniyelik önceki belirteçler ve öngörülebilecek 3.3 saniyelik gelecek ses ile koşullandırılmasını sağlar.

Uzun üretim sırasında kayma sapmalarını önlemek için, eğitim sırasında kod çözücüdeki zaman olaylarına rastgele sapmalar eklenmiştir.
Bu, zamanlama hatalarını düzeltmeye zorlar ve bunun yerine seste başlangıçlara kulak vererek sürekli doğru bir sapma elde edilmesini sağlar.

### Difüzyon ile iyileştirilmiş koordinatlar

Kod çözücü tarafından üretilen pozisyon koordinatları 32 piksellik bir ızgara noktasına kuantize edilir, bu yüzden ardından koordinatları nihai pozisyonlara denoise etmek için difüzyon kullanıyoruz.
Bunun için Mapperatorinator'un koşullu üretim için kullandığı daha gelişmiş meta veri belirteçlerini kabul eden ve sadece gürültü planının son %10'una özel bir [osu-diffusion](https://github.com/OliBomby/osu-diffusion) sürümü eğittik.

Mapperatorinator modeli slider’ların SV’sini çıktıladığından, slider’ın gerekli uzunluğu kontrol noktası yolunun şeklinden bağımsız olarak sabittir.
Bu nedenle, difüzyon işlemini gerekli slider uzunluklarına uyan koordinatlar oluşturmaya yönlendirmeye çalışıyoruz.
Bunu, difüzyon işleminin her adımından sonra gerekli uzunluğa ve mevcut kontrol noktası yoluna göre slider bitiş pozisyonlarını yeniden hesaplayarak yapıyoruz.
Bu, difüzyon işleminin slider bitiş pozisyonları üzerinde doğrudan bir kontrolü olmadığı anlamına gelir, ancak kontrol noktası yolunu değiştirerek yine de onları etkileyebilir.

### Son işlem

Mapperatorinator, üretilen beatmap’in kalitesini artırmak için bazı ek son işlemler yapar:

- Pozisyon koordinatlarını difüzyon ile iyileştirin.
- Zaman olaylarını model tarafından üretilen snap bölenlerini kullanarak en yakın tick’e yeniden snap’leyin.
- Neredeyse kusursuz konumsal üst üste binmeleri snap’leyin.
- Mania sütun olaylarını X koordinatlarına dönüştürün.
- Taiko drumroll’lar için slider yolları oluşturun.
- Gerekli slider uzunluğu ile kontrol noktası yolu uzunluğu arasındaki büyük tutarsızlıkları düzeltin.

### Süper zamanlama üreticisi

Süper zamanlama üreticisi, tüm şarkı için zamanlamayı 20 kez çıkarıp sonuçları ortalayarak üretilen zamanlamanın hassasiyetini ve doğruluğunu artıran bir algoritmadır.
Değişken BPM’ye sahip veya BPM değişiklikleri olan şarkılar için kullanışlıdır. Sonuç neredeyse mükemmeldir ve bazen sadece bir bölüm manuel ayar gerektirir.

## Eğitim

Aşağıdaki talimatlar, yerel makinenizde bir eğitim ortamı oluşturur.

### 1. Depoyu klonlayın

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. Veri kümesi oluşturun

Kendi veri kümenizi [Mapperator konsol uygulaması](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset) ile oluşturun. Beatmap'leri doğrulamak ve ek meta veriler almak için bir [osu! OAuth istemci anahtarı](https://osu.ppy.sh/home/account/edit) gerektirir. Veri kümesini, `Mapperatorinator` dizininin yanında bir `datasets` dizinine yerleştirin.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (Opsiyonel) Weight & Biases için kayıt ayarlayın
[Weight & Biases](https://wandb.ai/site) üzerinde bir hesap oluşturun ve hesap ayarlarından API anahtarınızı alın.
Ardından, eğitim sürecinin bu anahtara kayıt yapabilmesi için `WANDB_API_KEY` ortam değişkenini ayarlayın.

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. Docker konteyneri oluşturun
Eğitimi kendi venv'inizde yapmak da mümkündür, ancak daha iyi performans için WSL üzerinde Docker kullanmanızı öneririz.
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. Parametreleri yapılandırın ve eğitime başlayın

Tüm yapılandırmalar `./configs/train/default.yaml` dosyasında bulunmaktadır.
Doğru `train_dataset_path` ve `test_dataset_path` değerlerini kendi veri setinize göre ayarlayın, ayrıca eğitim/test bölmesi için başlangıç ve bitiş mapset indekslerini belirleyin.
Yol, docker konteynerine göre yereldir, bu yüzden veri setinizi `datasets` dizinine `cool_dataset` adıyla koyduysanız, yol `/workspace/datasets/cool_dataset` olmalıdır.

Varsayılan yapılandırmayı geçersiz kılan özel bir yapılandırma dosyası oluşturmanızı tavsiye ederim, böylece eğitim yapılandırmanızın kaydına sahip olursunuz ve tekrar üretilebilirlik sağlanır.

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. LoRA ince ayarı

Önceden eğitilmiş bir modeli belirli bir stile veya oyun moduna uyarlamak için [LoRA](https://arxiv.org/abs/2106.09685) ile de ince ayar yapabilirsiniz.
Bunu yapmak için, `configs/train/lora.yaml` dosyasını ihtiyaçlarınıza göre uyarlayın ve `lora` eğitim yapılandırmasını çalıştırın:

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

Dikkate alınması gereken önemli LoRA parametreleri:
- `pretrained_path`: İncelenecek temel modelin yolu veya HF deposu.
- `r`: LoRA matrislerinin derecesi. Yüksek değerler model kapasitesini artırır, fakat bellek kullanımını da yükseltir.
- `lora_alpha`: LoRA güncellemeleri için ölçekleme faktörü.
- `total_steps`: Toplam eğitim adımı sayısı. Bunu veri setinizin boyutuna göre dengeleyin.
- `enable_lora`: LoRA mı yoksa tam model ince ayarı mı kullanılacak.

Çıkarım sırasında, kullanılacak LoRA ağırlıklarını `lora_path` argümanı ile belirtebilirsiniz.
Bu, yerel bir yol veya Hugging Face deposu olabilir.

## Ayrıca bakınız
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## Katkıda Bulunanlar

Özel teşekkürler:
1. Eğitim kodları için [osuT5](https://github.com/gyataro/osuT5) yazarlarına.
2. [Araçları](https://huggingface.co/docs/transformers/index) için Hugging Face ekibine.
3. Fikir alışverişi için [Jason Won](https://github.com/jaswon) ve [Richard Nagyfi](https://github.com/sedthh)'ye.
4. Eğitim kredilerini bağışladığı için [Marvin](https://github.com/minetoblend)'e.
5. Beatmapler için osu! topluluğuna.

## İlgili çalışmalar

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) yazarı Syps (Nick Sypteras)
2. [osumapper](https://github.com/kotritrona/osumapper) yazarı kotritrona, jyvden, Yoyolick (Ryan Zmuda)
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) yazarı OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)
4. [osuT5](https://github.com/gyataro/osuT5) yazarı gyataro (Xiwen Teoh)
5. [Beat Learning](https://github.com/sedthh/BeatLearning) yazarı sedthh (Richard Nagyfi)
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) yazarı jaswon (Jason Won)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---