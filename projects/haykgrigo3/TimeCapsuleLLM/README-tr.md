
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

v1 [Microsoft tarafından geliştirilen Phi 1.5 üzerine kurulu](https://huggingface.co/microsoft/phi-1_5)

[Hugging Face Bağlantısı](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)


##  Model Davranışı & Sınırlamalar

### **v0**  

İlk istemler, modelin 1800'lerin dili ve davranışıyla yanıt verdiğini gösteriyor. 
Örnek: İstem: "Who art Henry?" ve yanıtı "I know that man, I have did not a black, the storm." 

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Modern kavramlardan hiç bahsedilmiyor  
- Çoğunlukla döneme uygun kelime dağarcığı  
- Cümleler çoğunlukla tutarsız (yaklaşık ~187MB eğitim verisi için beklenen durum)

### **v0.5** 

v0'a göre önemli bir gelişme.  
- Viktorya dönemi yazı stili, düzgün noktalama, çoğunlukla gramatik cümleler  
- Hâlâ yüksek oranda gerçek dışı bilgi üretimi  
- OCR gürültüsü (“Digitized by Google”) hâlâ çıktıların içinde mevcut

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

İlk kez model, veri kümesinden gerçek bir tarihi olay ile o olaya bağlı gerçek bir kişiyi birleştirebildi.

Örnek: İstem: "It was the year of our Lord 1834" 

Çıktı: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

İlk başta aynı yıl tesadüfen bir protesto olmuş olabileceğini düşündüm fakat şuna bakın: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Neden önemli:

Bu, modellerimden birinin bir yılı hem gerçek bir tarihi olayla hem de o olaya bağlı gerçek bir kişiyle (Lord Palmerston) ilişkilendirmesinin ilk örneği. Daha önceki modeller (v0 ve v0.5) 19. yüzyılın yazı tarzını taklit edebiliyordu fakat olayları, kişileri ve bilgileri daima hayal ürünü olarak oluşturuyordu. Bu, modelin veri kümesinden bir şeyleri hatırlamaya başladığını gösteriyor.

## Yaklaşan Planlar 

- 1800-1875 yılları arasında Londra'da yayımlanan yaklaşık 175.000 metin Internet Archive'da mevcut 
- Korpusu genişletmeyi ve daha iyi akıl yürütme yetenekleri için daha fazla temizlemeyi planlıyorum
- Daha fazla tarihsel model için farklı bölgelere ve zaman dilimlerine yayılma


## Nasıl Kullanılır

Bu proje ağırlıklı olarak tarihsel verileri derlemeye, eğitime hazırlamaya ve bir ayrıştırıcı oluşturmaya odaklanmaktadır. Tam LLM eğitim sürecini burada anlatmayacağım, bunun için Andrej Karpathy'nin nanoGPT'sine bakabilirsiniz.

### Adım 1: Tarihsel Metinleri Toplayın ve Hazırlayın 

- Seçtiğiniz zaman diliminden (örn. Londra 1800-1850) kamuya açık kitapların, belgelerin vb. .txt dosyalarını toplayın 
- Bunları seçtiğiniz zaman/mekan aralığında tutun  
- Metin dosyalarını bir betik kullanarak veya elle Project Gutenberg başlık/dipnotlarını, modern açıklamaları ya da OCR hatası gibi şeyleri kaldırarak temizleyin.

### Adım 2: Özel Bir Ayrıştırıcı Oluşturun

- Temizlenmiş veriler üzerinde train_tokenizer.py veya train_tokenizer_hf.py dosyasını çalıştırın.
- Bu işlem size vocab.json ve merges.txt dosyalarını verecektir
- Bu dosyalar modeliniz için kelime dağarcığını ve birleştirme kurallarını tanımlar

### Adım 3: Modelinizi Eğitin 

- Eğitim süreci için [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) veya seçtiğiniz mimarinin dokümantasyonuna bakın.

# SSS

## Seçici Zamansal Eğitim Nedir?

Seçici Zamansal Eğitim (STT), tüm eğitim verisinin özellikle belirli bir tarihsel zaman dilimi içinde toplanıp düzenlendiği bir makine öğrenimi metodolojisidir. Bu, dönemin dilini ve bilgisini modern kavramlardan etkilenmeden modellemek için yapılır. Örneğin, şu anki modelim (v0.5) yalnızca 1800-1875 dönemine ait verilerle sıfırdan eğitilmiştir, ince ayar yapılmamıştır ve çıktısı o zaman diliminin dilsel üslubunu ve tarihsel bağlamını yansıtır.

## Neden sadece ince ayar veya LoRA kullanmıyorsun?

Bu projede, modern önyargılardan uzak bir dil modeli oluşturmayı amaçlıyorum. GPT-2 gibi bir şeyi ince ayarlarsam, zaten önceden eğitilmiş olur ve bu bilgi kaybolmaz. Sıfırdan eğitirsem dil modeli eskiymiş gibi davranmaz, gerçekten eski olur. Projenin şu anki amacı, yalnızca 1800-1875 yılları arasında Londra'da yayımlanan kitaplardan elde edilen bilgiyle akıl yürütebilen bir şey üretmektir.

## Eğitime hangi tür verileri kullandınız?

1800–1875 Londra'sından kitaplar, hukuki belgeler, gazeteler ve diğer yazılı eserleri kullanıyorum. Bağlantısını verdiğim listede (v0 için) yaklaşık 200 dosya var ama ilk eğitimde sadece 50 dosya, yaklaşık ~187 MB kullandım. Belgelerin listesini buradan görebilirsiniz:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Veri seti boyutları:
v0: ~187MB
v0.5: ~435MB 
v1: ~6.25GB 

## Modeller ne kadar büyük?

V0: 16M Parametre

V0.5 123M Parametre

V1: 700M Parametre

# Eğitim Özellikleri ? 

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: Kiralık A100















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---