<div align="right">
  <details>
<summary>🌐 Dil</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Yalnızca belirli yerlerden ve zaman dilimlerinden alınan veriler üzerinde **sıfırdan** eğitilmiş bir dil modeli; modern önyargıları azaltmak ve dönemin sesini, kelime dağarcığını ve dünya görüşünü taklit etmek için.*

Bir AI modelinin tarihiymiş gibi davranmakla kalmayıp gerçekten tarihi olmasını hayal edin.

v0 ve v0.5 [Andrej Karpathy'nin nanoGPT'si](https://github.com/karpathy/nanoGPT) üzerine inşa edildi. Temel eğitim scriptleri ve model mimarisi ona aittir.

v1 [Microsoft'un Phi 1.5'i](https://huggingface.co/microsoft/phi-1_5) üzerine inşa edildi.

v2 llamaforcausallm üzerine inşa edildi.

[Hugging Face Bağlantısı](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Araştırma Durumu
Bu proje bağımsız olarak başlatıldı ve geliştirildi.

Şu anda akademik denetim altında yürütülmekte olup, Muhlenberg College'da bağlı bir araştırma işbirliği ile sürdürülmektedir.

## Atıf

Bu veri setini veya modeli akademik çalışmalarda kullanırsanız, lütfen aşağıdaki şekilde atıf yapınız:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## Vintage LLM Discord'a Katılın

Eğer **tarihi dil modelleri**, **zamana özgü veri setleri** veya **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox** gibi projelerin geleceğiyle ilgileniyorsanız, topluluğa katılın.

Sunucuyu fikirleri tartışmak, ilerlemeyi paylaşmak ve bu alanda çalışanlarla bağlantı kurmak için kullanıyoruz.

[Discord'a Katıl](https://discord.gg/JeWkk4z5)

##  Model Davranışı & Sınırlamaları

### **v0**  

Erken istemler modelin 1800'ler dili ve davranışıyla yanıt verdiğini gösteriyor.
Örnek: İstem: "Who art Henry?" ve yanıtı "I know that man, I have did not a black, the storm."

![TimeCapsuleLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Modern kavramlara değinilmiyor  
- Çoğunlukla döneme uygun kelime kullanımı  
- Cümleler genellikle tutarsız (yaklaşık 187MB eğitim verisi için beklenen durum)

### **v0.5-london** 

v0'a göre önemli bir iyileşme.
- Viktorya dönemi yazı tarzı, doğru noktalama, çoğunlukla gramatik cümleler  
- Hâlâ yüksek oranda gerçek dışı bilgi üretimi  
- OCR gürültüsü (“Digitized by Google”) çıktılarda hâlâ mevcut

![TimeCapsuleLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Gerçek tarihsel bir olayı veri setindeki gerçek bir figürle ilişkilendiren ilk model.

Örnek: İstem: "It was the year of our Lord 1834"

Çıktı: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

Başta bir protestonun aynı yıl tesadüfen gerçekleşmiş olabileceğini düşündüm fakat buna bir göz atın: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

v2'nin 90GB veri setinden 15GB'lık bir örnek kullanılarak eğitildi.
Model sadece 10K adım eğitildi.

Tokenizasyonla ilgili bir sorun çıktı ve çıktı şöyle görünüyor:

GİRDİ:
Charles Dickens kimdir?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Düzeltilmiş:

"Charles Dickens kimdir? Bu onun mükemmel heyecan verici eserlerinden daha fazlası mı, oyunlarında, Büyük Şirket'in çiftliğinde mi? Jack Pickett'ten henüz alıntı yapmadıklarım var mı? Onların bir çeşit dörtnala koşmak veya göğüslerini testereyle kesmek olduklarını bilmiyor musunuz, yoksa Jackson pencereye bakarken ne yapılacaktı? Bir İngilizin başarısı nedir ve oğlunun henüz bana keşfetmediği, böyle bir yükü başarmak için ne gibi yolları var? Hiç eski yol üzerinde bir geçit yaptınız mı, ya da teknenin ayağında bir demir meltemine, ki bizi terk etmeniz gerekecek? Gerçek şu ki, cumartesi gecesi ya da öğle vakti, ya da kuzeye kadar, ya da aksi halde, rüzgâr ovanın üzerinden yükselecek mi, yükselemeyecek mi, mevcutla aynı etkilerle karşılaşmak zorunda kalacağız. En azından bu durumda, o odadan ayrıldığımızı söylemek çok fazla değildir. 'Beş Yüz Kat' içinde başvurulacak üç nüsha olduğunu sanıyorum, okuyucularımızdan ilk sayıya başvurmak isteyenler için..."

### **v2mini-eval2-london**

Aynı 15GB örnek ile eğitildi, eval1 için kullanılan.
Model yine yalnızca 10K adımda eğitildi.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Efendim, — Aşağıdaki vaka ilgimi çekiyor: — Londra’da iki hafta kaldım ve romatizma atağı ile çok etkilendim. Romatizmanın ilk atağı, sizi görmeden bir hafta önceydi, ikincisi sizi gördüğümde, üçüncüsü ise yine sizi gördüğümde ve üçüncüsü aynı zamanda gerçekleşti. Ancak gutun ikinci atağı herhangi bir ateşli semptomla birlikte değildi, fakat idrar akışında artış ve daha bol idrar çıkışı ile birlikteydi. Üçüncü atak sizi gördükten bir saat sonra oldu ve bir gut nöbetinin tekrarıyla ve gutun daha hızlı bir şekilde geri dönüşüyle sonuçlandı. Dördüncü atak da bir ateşle birlikteydi, fakat her zaman ateşli semptomlara eşlik etmedi. Üçüncü gut atağı, hastalandıktan iki hafta sonra, dördüncüsü ise bir gut nöbetinin ardından oldu. Dördüncü atak, saldırıdan iki hafta sonra oldu ve bir hisle birlikteydi

### **v2-london**

90GB (112GB tokenize edilmiş) bir veri kümesiyle eğitildi
182K adıma kadar eğitildi

![TimeCapsuleLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **Sırada ne var?**

- TimeCapsuleLLM v3 üzerinde geliştirme başladı
- Veri kümesi boyutunu ve coğrafi kapsama alanını artırma
- Londra'nın ötesine diğer şehirlere genişleme

Çalışma, University College London (UCL) araştırmacılarıyla iş birliği içinde yürütülüyor ve ek kurumsal iş birliği tartışılıyor.


##  Veri Kümeleri

### **v2**

- 1800-1875 Londra metinlerinden 90GB (ham)
- 136.344 belge
- Tüm tokenize edilmiş veri kümesi artık burada mevcut: https://huggingface.co/datasets/postgrammar/london-llm-1800

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
  -  1930'dan önceki 260 milyar metin üzerinde Soru&Cevap ile eğitilmiş 13B parametreli LLM. Ayrıca bir [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base) sürümü de vardır.
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  1800-1899 metinleriyle Soru&Cevap ile eğitilmiş 1.4B parametreli LLM. Ayrıca bir [160M](https://huggingface.co/zakarth/violet-160m-chat) sürümü de vardır.
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  1837-1899 yılları arasında 28.000'den fazla metinle Soru&Cevap eğitilmiş 340M parametreli LLM.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - Qwen3 mimarisi üzerine inşa edilmiş, 1913,1929,1933,1939,1946 bilgi-kesimi yıllarına kadar 80B tarihi veriyle sıfırdan eğitilmiş 4B parametreli LLM ailesi.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT, çoğunluğu EEBO ve Gallica'dan gelen İngilizce, Fransızca ve Latince 11.000 erken modern metin üzerinde Mistral-Hermes 2'nin ince ayarlamasıdır.

## Teşekkürler

Akademik danışmanlığı, araştırmanın çerçevesinin belirlenmesi ve değerlendirilmesindeki rehberliği, v2 sürümünde tokenizer eğitimi ve veri seti hazırlığına yardımları için [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com)'a teşekkür ederim. Geri bildirimi ve tecrübesi, bu çalışmanın sunumunun geliştirilmesinde çok değerli olmuştur.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---