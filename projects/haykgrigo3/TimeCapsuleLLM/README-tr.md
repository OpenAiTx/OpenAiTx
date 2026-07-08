<div align="right">
  <details>
<summary>🌐 Dil</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Bir dil modeli, modern önyargıyı azaltmak ve dönemin sesi, kelime dağarcığı ve dünya görüşünü taklit etmek için belirli yerlerden ve zaman dilimlerinden alınan verilerle **sıfırdan** eğitildi.*

Bir AI modelinin tarihiymiş gibi yapmadığını, aslında öyle olduğunu hayal edin.

v0 ve v0.5 [Andrej Karpathy'nin nanoGPT'si](https://github.com/karpathy/nanoGPT) üzerine kurulmuştur. Temel eğitim betikleri ve model mimarisi ona aittir.

v1 [Microsoft'un Phi 1.5'i](https://huggingface.co/microsoft/phi-1_5) üzerine kurulmuştur.

v2 llamaforcausallm üzerine kurulmuştur.

[Hugging Face Linki](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Araştırma Durumu
Bu proje bağımsız olarak başlatıldı ve geliştirildi.

Şu anda akademik gözetim altında yürütülmektedir ve Muhlenberg College & Georgia State University ile bağlantılı bir araştırma iş birliği bulunmaktadır.

## Atıf

Bu veri setini veya modeli akademik çalışmada kullanırsanız lütfen aşağıdaki şekilde atıf yapınız:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## Vintage LLM Discord Sunucusuna Katılın

**Tarihi dil modelleri**, **zamana özgü veri kümeleri** veya **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox** gibi projelerin geleceğiyle ilgileniyorsanız topluluğa katılın.

Sunucuyu fikirleri tartışmak, ilerlemeleri paylaşmak ve bu alanda çalışan diğer insanlarla bağlantı kurmak için kullanıyoruz.

[Discord'a Katılın](https://discord.gg/JeWkk4z5)

## Sponsorlar

<div align="center">
  <a href="https://doloffer.com">
    <img src="https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/logo.png" width="500">
  </a>
</div>

Bu projeye desteklerinden dolayı DolOffer'a teşekkürler!

DolOffer, dijital ürün önerileri ve indirim paylaşımı üzerine odaklanan bir platformdur; kullanıcılara hızlıca değerli araçları, hizmetleri ve sınırlı süreli fırsatları keşfetme olanağı sağlar. Platformda YouTube Premium, Claude, ChatGPT Plus, Spotify ve Apple Music gibi popüler abonelik hizmetleri, resmi fiyatın %30'u veya daha da altında fiyatlarla sunulmaktadır.

Bu özel bağlantı üzerinden şimdi kayıt olun [doloffer](https://doloffer.com/en/) ve bakiye yüklerken promosyon kodu AI8888 girerek ek %10 indirim kazanın.

##  Model Davranışı & Sınırlamalar

### **v0**  

Erken istemlerde modelin 1800'ler dili ve davranışıyla yanıt verdiği görülüyor. 
Örnek: İstem: "Who art Henry?" ve yanıtı: "I know that man, I have did not a black, the storm." 

![TimeCapsuleLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Modern kavramlara hiç değinilmez  
- Çoğunlukla döneme uygun kelime dağarcığı  
- Cümleler çoğunlukla anlamsız (yaklaşık 187MB eğitim verisi için beklenen bir durum)

### **v0.5-london** 

v0'a göre önemli bir gelişme.  
- Viktorya dönemi yazı stili, doğru noktalama, çoğunlukla dilbilgisel olarak doğru cümleler  
- Hala yüksek düzeyde gerçeklikten sapma oranı  
- OCR gürültüsü (“Google tarafından dijitalleştirildi”) çıktılarda hâlâ mevcut

![TimeCapsuleLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Gerçek bir tarihi olayı veri setindeki gerçek bir figürle hatırlayan ve bağlayan ilk model.

Örnek: İstek: "İsa'nın yılı 1834'tü" 

Çıktı: "İsa'nın yılı 1834'tü ve Londra'nın sokakları protesto ve dilekçelerle doluydu. Nedeni, birçok kişinin tekrar ettiği gibi, özel bir şekilde bağlı değildi, fakat Lord Palmerston'un gününde aynı gün ele alındı, kamuoyu kanun gününün bize ulaştığı zorluklarla ilgili kısa bir açıklama alacak. Derin bir üzüntü duyuluyor ki, dünyanın tarihindeki mevcut olaylar açıktır ve dolayısıyla bilinecektir. Gerçek değildir ki, ilk olarak Kudüs'teki İncil'de yerleşen adamlar bu kadar geniş ve ilginç bir refah ve refah kaydına sahip olmalıdır" 

Başta, protestonun tesadüfen aynı yıl gerçekleşmiş olabileceğini varsaydım ama şuna bir bakın: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

v2'nin 90GB veri setinden 15GB örnekle eğitildi.
Model yalnızca 10K adımda eğitildi.

Çıktının şöyle görünmesine neden olan bir tokenizasyon sorunu vardı:

İSTEK:
Charles Dickens kimdir?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Düzeltilmiş:

"Charles Dickens kimdir? Onun mükemmel heyecan verici eserlerinden, oyunlarından, Büyük Şirket’in çiftliğindeki çalışmalarından daha fazlası mı var? Jack Pickett’ten henüz alıntı yapmadım mı? Onların bir tür koşuşturma ya da göğüslerini testereyle kesme türünden insanlar olduklarını bilmiyor musun, yoksa Jackson pencereye bakarken yapılacaklar hakkında mıydı? Bir İngiliz’in başarısı nedir ve oğlunun bana henüz keşfetmediği, böyle bir ağırlığı başarmak için ne gibi yolları vardır? Hiç eski yoldan geçiş yaptın mı, yoksa tekneyle ayrılmak zorunda olduğun demirli bir esintiyle, botumuzun ayağında mıydı? Gerçek şu ki, rüzgarın cumartesi gecesi ya da öğle vakti ovadan mı yükseleceği, kuzeye mi eseceği ya da başka türlü mü olacağı fark etmeksizin, mevcut durumla aynı etkilere sahip, zorlu bir engel tanımlamak zorunda kalacağız. En azından bu durumda, o odadan ayrıldığımızı söylemek çok fazla değildir. ‘Beş Yüz Kat’ta üç kopya olduğuna inanıyorum, başvurulacak, okurlarımızdan ilk numaraya sahip olanlar için [olacak]...”

### **v2mini-eval2-london**

Eval1’in eğitiminde kullanılan aynı 15GB’lık örnekle eğitildi.
Model yine sadece 10K adımda eğitildi.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Efendim, — Aşağıdaki vaka benim için ilginçtir: — Londra’da iki hafta kaldım ve romatizma atağı ile oldukça etkilendim. İlk romatizma atağı, sizi görmemden bir hafta önceydi; ikincisi sizi gördüğümde, üçüncüsü de sizi gördüğümde ve üçüncüsü de aynı zamanda oldu. Ancak ikinci gut atağı herhangi bir ateşli belirtiyle birlikte değildi, fakat idrar akışında artış ve daha bol idrar çıkışıyla birlikteydi. Üçüncü atak, sizi gördükten bir saat sonra oldu ve bir gut nöbetinin geri dönmesiyle ve gutun daha hızlı geri dönmesiyle devam etti. Dördüncü atak da bir ateşle birlikteydi, fakat her zaman ateşli belirtiyle birlikte değildi. Üçüncü gut atağı, hastalandıktan iki hafta sonra oldu ve dördüncüsü bir gut nöbetiyle devam etti. Dördüncü atak, saldırıdan iki hafta sonra oldu ve bir hisle birlikteydi.

### **v2-london**

90GB (112GB tokenleştirilmiş) bir veri kümesi ile eğitildi
182K adıma kadar eğitildi 

![TimeCapsuleLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **Sırada ne var?**

- TimeCapsuleLLM v3 üzerinde geliştirme başladı
- Veri seti boyutu ve coğrafi kapsam genişletiliyor
- Londra’nın ötesinde ek şehirlere açılım

Çalışmalar Muhlenberg College ve Georgia State University’den araştırmacılarla işbirliği içinde yürütülmektedir. 


##  Veri Kümeleri

### **v2**

- 1800-1875 Londra metinlerinden 90GB (ham)
- 136.344 belge
- Tam tokenleştirilmiş veri seti artık burada mevcut: https://huggingface.co/datasets/postgrammar/london-llm-1800


### Sapma İstatistikleri 
  ![Zamir sapması](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Coğrafi sapma](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Zamansal sapma](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Daha fazla bilgi için [v2 sapma raporu](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) adresine bakınız.


- 


## Nasıl Kullanılır

Bu proje çoğunlukla tarihsel verilerin derlenmesi, eğitime hazırlanması ve bir belirteçleyici (tokenizer) oluşturulmasına odaklanmaktadır. Tam LLM eğitim sürecini burada anlatmayacağım, bunun için Andrej Karpathy'nin nanoGPT'sine bakınız.

### Adım 1: Tarihsel Metinleri Toplayın ve Hazırlayın 

- Seçtiğiniz zaman diliminden (örn. Londra 1800-1875) kamuya açık kitapların, belgelerin vs. .txt dosyalarını toplayın 
- Dosyaların seçtiğiniz zaman/mekan aralığında kalmasına dikkat edin  
- Metin dosyalarını bir betik yardımıyla veya elle Project Gutenberg başlık/dipnotlarını, modern açıklamaları ya da OCR hatası gibi şeyleri temizleyin.

### Adım 2: Özel Bir Tokenizer Oluşturun

- Temizlenmiş veriler üzerinde train_tokenizer.py veya train_tokenizer_hf.py dosyasını çalıştırın.
- Bu işlem size vocab.json ve merges.txt dosyalarını verecektir.
- Bu dosyalar modeliniz için kelime dağarcığını ve birleştirme kurallarını tanımlar

### Adım 3: Modelinizi Eğitin 

- Eğitim süreci için [Andrej Karpathy'nin nanoGPT](https://github.com/karpathy/nanoGPT) projesine ya da seçtiğiniz mimarinin belgelerine bakınız.

# SSS

## Seçici Zamansal Eğitim (STT) nedir?

Seçici Zamansal Eğitim (STT), tüm eğitim verisinin belirli bir tarihsel zaman dilimine özel olarak özenle seçildiği bir makine öğrenimi metodolojisidir. Bu yöntem, dönemin dilini ve bilgisini modern kavramlardan etkilenmeden modellemek için yapılır. Örneğin, mevcut modelim (v0.5) yalnızca 1800-1875 arası verilerle sıfırdan eğitilmiştir, ince ayar yapılmamış olup çıktıları, o dönemin dilsel üslubunu ve tarihsel bağlamını yansıtır.

## Neden sadece ince ayar (fine-tuning) veya LoRA kullanılmıyor?

Bu proje için, modern önyargıdan arındırılmış bir dil modeli oluşturmayı deniyorum. Eğer GPT-2 gibi bir şeyi ince ayar yaparsam, zaten önceden eğitilmiş olur ve o bilgi ortadan kalkmaz. Sıfırdan eğitirsem, dil modeli eskiymiş gibi yapmayacak, gerçekten öyle olacak. Bu proje için şu anki hedefim, sadece 1800 ile 1875 yılları arasında Londra'da yayımlanmış kitaplardan elde edilen bilgilerle muhakeme yapabilen bir şey oluşturmak.

## Eğitim için ne tür veriler kullandınız?

1800–1875 Londra'sından kitaplar, yasal belgeler, gazeteler ve diğer yazılı eserleri kullanıyorum. Bağlantısını verdiğim (v0 için) listede yaklaşık 200 dosya var ama ilk eğitim için sadece 50 dosya ve yaklaşık ~187 MB kullandım. Belgelerin bir listesini görüntüleyebilirsiniz:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Veri seti boyutları:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB (v2'nin 90GB'sından örnek)
- v2: 90GB

## Modeller ne kadar büyük?

v0: 16M Parametre

v0.5: 123M Parametre

v1: 700M Parametre

v2mini-eval1: 300M Parametre

v2mini-eval2: 200M Parametre

v2: 1.2B Parametre

## Eğitim Özellikleri?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM kiralık

### v2mini-eval1/eval2
GPU: A100 SXM kiralandı

### v2
GPU: H100 SXM kiralandı

## İlgili Çalışmalar

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  13B parametreli LLM, 1930'dan önceki 260B metin üzerinde S&Y ile eğitildi. Bir de [temel](https://huggingface.co/talkie-lm/talkie-1930-13b-base) versiyonu vardır.
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  1.4B parametreli LLM, 1800-1899 metinleri üzerinde S&Y ile eğitildi. Bir de [160M](https://huggingface.co/zakarth/violet-160m-chat) versiyonu vardır.
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  340M parametreli LLM, 1837-1899 arasında 28.000'den fazla metin üzerinde S&Y ile eğitildi.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - Qwen3 mimarisi üzerine sıfırdan, bilgi-kesim yılları 1913,1929,1933,1939,1946'ya kadar 80B tarihsel veriyle eğitilmiş 4B parametreli LLM ailesi.
 
- **[TypewriterLM](https://huggingface.co/typewriter-ai/typewriter-1913-7B-base)**
  - Sadece 1913 öncesi İngilizce metinlerde önceden eğitilmiş 7.24B parametreli bir Tarih dil modeli (LM). University of Waterloo, Adelaide University, University of Oxford ve University College London araştırmacıları tarafından oluşturulmuştur. [Makale linki](https://arxiv.org/abs/2606.02991)

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT, Mistral-Hermes 2'nin, çoğunlukla EEBO ve Gallica'dan gelen İngilizce, Fransızca ve Latince 11.000 erken modern metinle ince ayar yapılmış halidir.

## Teşekkürler

Akademik denetim, araştırmanın çerçevelenmesi ve değerlendirilmesi konularında rehberliği, v2 sürümü için tokenizer eğitimi ve veri seti hazırlığında yardımları için [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com)'a teşekkür etmek isterim. Geri bildirimi ve deneyimi bu çalışmanın sunumunun iyileştirilmesinde çok önemli oldu.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---