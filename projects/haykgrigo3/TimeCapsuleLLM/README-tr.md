
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Yakında">繁體中文 (yakında)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Yakında">हिन्दी (yakında)</a> |
        | <a href="#" title="Yakında">ไทย (yakında)</a> |
        | <a href="#" title="Yakında">Français (yakında)</a>
        | <a href="#" title="Yakında">Deutsch (yakında)</a>
        | <a href="#" title="Yakında">Español (yakında)</a>
        | <a href="#" title="Yakında">Italiano (yakında)</a>
        | <a href="#" title="Yakında">Русский (yakında)</a>
        | <a href="#" title="Yakında">Português (yakında)</a>
        | <a href="#" title="Yakında">Nederlands (yakında)</a>
        | <a href="#" title="Yakında">Polski (yakında)</a>
        | <a href="#" title="Yakında">العربية (yakında)</a>
        | <a href="#" title="Yakında">فارسی (yakında)</a>
        | <a href="#" title="Yakında">Türkçe (yakında)</a>
        | <a href="#" title="Yakında">Tiếng Việt (yakında)</a>
        | <a href="#" title="Yakında">Bahasa Indonesia (yakında)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM

*Bazı yerlerden ve zaman dönemlerinden alınan verilerle **sıfırdan** eğitilmiş bir dil modeli; modern yanlılığı azaltmak ve dönemin sesi, kelime dağarcığı ve dünya görüşünü taklit etmek için tasarlanmıştır.*

Bir yapay zekâ modelinin tarihiymiş gibi davranmakla kalmayıp gerçekten tarihi olduğunu hayal edin.

v0 ve v0.5 [Andrej Karpathy'nin nanoGPT'si](https://github.com/karpathy/nanoGPT) üzerine inşa edilmiştir. Temel eğitim betikleri ve model mimarisi ona aittir.

v1 [Microsoft tarafından geliştirilen Phi 1.5 üzerinde oluşturuldu](https://huggingface.co/microsoft/phi-1_5)


##  Model Davranışı & Sınırlamalar

### **v0**  

İlk girdilerde modelin 1800'lerin dili ve davranışıyla cevap verdiği görülüyor. 
Örnek: Girdi: "Who art Henry?" ve cevap olarak "I know that man, I have did not a black, the storm." dedi.

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Modern kavramlara hiç değinilmiyor  
- Çoğunlukla döneme uygun kelime dağarcığı  
- Cümleler çoğunlukla tutarsız (yaklaşık ~187MB eğitim verisi için beklenen)

### **v0.5** 

v0'a göre önemli bir gelişme.  
- Viktorya dönemi yazı tarzı, düzgün noktalama, çoğunlukla gramer kurallarına uygun cümleler  
- Hâlâ yüksek oranda gerçeklikten sapma (halüsinasyon)  
- OCR gürültüsü (“Digitized by Google”) çıktılarda hâlâ mevcut

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Modelin ilk kez gerçek bir tarihi olayı, veri setindeki gerçek bir figürle ilişkilendirdiği sürüm.

Örnek: Girdi: "It was the year of our Lord 1834" 

Çıktı: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Başta bir protestonun aynı yıl tesadüfen gerçekleşmiş olabileceğini düşündüm fakat şuna göz atın: ![1834protesto](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Neden önemli:

Bu, modellerimden birinin bir yılı hem gerçek bir tarihi olaya hem de o olayla bağlantılı gerçek bir kişiye (Lord Palmerston) bağlamasının ilk örneği. Daha önceki modeller (v0 ve v0.5) 19. yüzyılın yazı tarzını taklit edebiliyordu ancak her zaman olaylar, kişiler ve gerçekler hakkında halüsinasyon görüyordu. Bu, modelin veri setinden bir şeyleri hatırlamaya başladığını gösteriyor.

## Yaklaşan Planlar 

- 1800-1875 yılları arasında Londra'da yayımlanmış yaklaşık 175.000 metin Internet Archive üzerinde bulunmaktadır
- Korpusu genişletmeyi ve daha iyi akıl yürütme yetenekleri için daha fazla temizlemeyi planlıyorum
- Daha fazla tarihsel model için farklı bölgelere ve zaman dilimlerine genişletme


## Nasıl Kullanılır

Bu proje çoğunlukla tarihsel verileri derlemeye, eğitime hazırlamaya ve bir belirteçleyici (tokenizer) oluşturmaya odaklanıyor. Tam LLM eğitim sürecini kapsamayacağım, bunun için Andrej Karpathy'nin nanoGPT'sine bakabilirsiniz.

### Adım 1: Tarihsel Metinleri Toplayın ve Hazırlayın 

- Seçtiğiniz zaman diliminden kamu malı kitapların, belgelerin vs. .txt dosyalarını toplayın (örneğin, Londra 1800-1850)
- Dosyaları seçtiğiniz zaman/mekan aralığında tutun  
- Metin dosyalarını bir betik ile veya elle Project Gutenberg başlıklarını/altbilgilerini, modern açıklamaları veya OCR hataları gibi şeyleri çıkararak temizleyin.

### Adım 2: Özel Bir Tokenizer Oluşturun

- train_tokenizer.py veya train_tokenizer_hf.py'yi temizlenmiş veri üzerinde çalıştırın.
- Bu işlem size vocab.json ve merges.txt dosyalarını verecektir
- Bu dosyalar modeliniz için kelime dağarcığını ve birleştirme kurallarını tanımlar

### Adım 3: Modelinizi Eğitin 

- Eğitim süreci için [Andrej Karpathy'nin nanoGPT](https://github.com/karpathy/nanoGPT) projesine veya seçtiğiniz mimarinin belgelerine bakın.

# SSS

## Seçici Zamansal Eğitim (Selective Temporal Training) Nedir?

Seçici Zamansal Eğitim (STT), tüm eğitim verisinin özel olarak belirli bir tarihsel zaman aralığına uygun şekilde seçildiği bir makine öğrenimi metodolojisidir. Bu, çağdaş kavramların etkisi olmadan o dönemin dilini ve bilgisini modellemek için yapılır. Örneğin, şu anda elimde olan mevcut model (v0.5) tamamen 1800-1875 döneminden alınan verilerle eğitildi, ince ayar yapılmadı, sıfırdan eğitildi ve çıktıları o zaman diliminin dilsel tarzını ve tarihsel bağlamını yansıtıyor.

## Neden sadece ince ayar (fine-tuning) veya LoRA kullanmıyorsunuz?

Bu proje için amacım modern yanlılıktan uzak bir dil modeli oluşturmak. Bir şeyin (ör. GPT-2) ince ayarını yaparsam, zaten önceden eğitilmiş olur ve o bilgi ortadan kalkmaz. Sıfırdan eğitirsem dil modeli eskiyi taklit etmez, doğrudan öyle olur. Şu anki hedefim, yalnızca 1800 ile 1875 arasında Londra'da yayımlanmış kitaplardan alınan bilgilerle akıl yürütebilen bir şey yaratmak.

## Eğitim için ne tür veriler kullandınız?

Kitaplar, yasal belgeler, gazeteler ve 1800–1875 Londra'sından diğer yazılı eserleri kullanıyorum. Bağlantısını verdiğim listede (v0) yaklaşık 200 dosya var ama ilk eğitimde sadece 50 dosya ve yaklaşık ~187 MB kullandım. Belgelerin listesini buradan görebilirsiniz:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Veri seti boyutları:
v0: ~187MB
v0.5: ~435MB 
v1: ~6.25GB 

## Modeller ne kadar büyük?

V0: 16M Parametre

V0.5: 123M Parametre

V1: 700M Parametre

# Eğitim Özellikleri?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: Kiralık A100

















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---