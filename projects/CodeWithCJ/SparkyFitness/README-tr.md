# SparkyFitness - MyFitnessPal’a Kendin Barındırabileceğiniz Alternatif

SparkyFitness, kullanıcıların beslenme, egzersiz ve vücut ölçümlerini takip etmelerine yardımcı olmak için tasarlanmış kapsamlı bir fitness izleme ve yönetim uygulamasıdır. Günlük ilerleme takibi, hedef belirleme ve sağlıklı yaşam tarzını destekleyen anlamlı raporlar için araçlar sunar.


## ✨ Özellikler

### 🍎 Beslenme Takibi

* **Günlük öğünlerinizi kaydedin**
* **Özel yiyecekler ve kategoriler oluşturun ve yönetin**
* **Etkileşimli grafiklerle özetleri görüntüleyin ve eğilimleri analiz edin**

### 💪 Egzersiz Kaydı

* **Antrenmanlarınızı kaydedin**
* **Kapsamlı egzersiz veritabanında gezin ve arama yapın**
* **Zaman içindeki fitness ilerlemenizi takip edin**

### 💧 Su Tüketimi İzleme

* **Günlük su tüketim hedeflerinizi takip edin**
* **Basit ve hızlı su kaydı**

### 📏 Vücut Ölçümleri

* **Vücut metriklerini kaydedin** (örn. kilo, bel, kollar)
* **Özel ölçüm türleri ekleyin**
* **Grafikler aracılığıyla ilerlemeyi görselleştirin**

### 🎯 Hedef Belirleme

* **Fitness ve beslenme hedefleri belirleyin ve yönetin**
* **Zaman içindeki ilerlemeyi takip edin**

### 🗓️ Günlük Kontroller

* **Günlük aktiviteleri izleyin**
* **Alışkanlık takibi ile tutarlı kalın**

### 🤖 AI Beslenme Koçu (SparkyAI)

* **Sohbet üzerinden yemek, egzersiz, vücut istatistikleri ve adım kaydı yapın**
* **Yemek fotoğraflarını yükleyerek otomatik olarak öğün kaydedin**
* **Sohbet geçmişi ve kişiselleştirilmiş rehberlik içerir**

### 🔒 Kullanıcı Kimlik Doğrulama & Profiller

* **Güvenli giriş sistemi**
* **Kullanıcı profilleri arasında geçiş yapın**
* **Aile erişimi ve yönetimi desteği**

### 📊 Kapsamlı Raporlar

* **Beslenme ve vücut metrikleri için özetler oluşturun**
* **Haftalar veya aylar boyunca uzun vadeli eğilimleri takip edin**

### 🎨 Özelleştirilebilir Temalar

* **Aydınlık ve karanlık mod arasında geçiş yapın**
* **Minimum ve dikkat dağıtıcı olmayan arayüz tasarımı**

### Yardıma mı ihtiyacınız var?
* **Discord’a katılın**
  https://discord.gg/vcnMT5cPEA
* **Tartışmalara mesaj atın**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 Başlarken

SparkyFitness uygulamasını kendi bilgisayarınızda çalıştırmak için şu adımları izleyin:

### Ön Koşullar

*   **Supabase Projesi**: Kurulu bir Supabase projesine ihtiyacınız olacak.
    *   **Supabase’de yeni bir proje oluşturun**: [Supabase](https://app.supabase.com/) adresine gidin ve yeni bir proje oluşturun. (İsterseniz yerel bir Supabase projesi kurmayı da deneyebilirsiniz.)
    *   Supabase Proje URL’inizi ve Anon Anahtarınızı proje ayarlarınızın (API bölümü) içinden alın.
    *   **Supabase Kimlik Doğrulama ile İlgili Önemli Not:** Supabase Kimlik Doğrulama ayarlarından URL Yapılandırmanızı kendi alan adınıza uygun olacak şekilde güncelleyin. Bu, alan adınızın çalışması ve kayıt için e-posta daveti alabilmeniz için gereklidir. Supabase, kapsamlı güvenlik özellikleri ve üçüncü taraf SSO seçenekleri sunar; projenizin gereksinimlerine göre yapılandırın.
    *   Ücretsiz Supabase sürümünde, otomatik veritabanı dağıtımı IPV4 ile çalışmaz. Bu yüzden Ağınızı IPV6 bağlantısı kullanacak şekilde yapılandırmanız gerekir. Aksi halde veritabanı geçişi başarısız olur ve manuel olarak dağıtmanız gerekir.       


    

### Kurulum

1.  **Ortam Değişkenlerini Yapılandırın:**
    `private` klasörü altında bir `.env` dosyası oluşturun. Eğer Portainer kullanıyorsanız, doğrudan orada da oluşturabilirsiniz. 
    Supabase kimlik bilgilerinizi ekleyin:
    ```
    VITE_SUPABASE_URL="YOUR_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="YOUR_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="YOUR_SUPABASE_PROJECT_REF"    
    ```

2.  **Docker Compose ile Çalıştırın:**
    Docker imajlarını çekin ve servisleri başlatın:
    ```sh
    docker compose pull
    docker compose up -d
    ```

3.  **Uygulamaya Erişim:**
    Servisler başlatıldıktan sonra, SparkyFitness uygulamasına web tarayıcınızdan şu adresten erişebilirsiniz:
    ```
    http://localhost:3000
    ```

4.  **Yapay Zeka Sohbet Botu - Opsiyonel Yapılandırma:**
    Yapay Zeka Sohbet Botu'nun tam işlevselliğini etkinleştirmek, güvenli API anahtarı depolama ve veritabanı erişimi dahil olmak üzere, aşağıdaki adımları izleyin:

    *   **`AI_API_ENCRYPTION_KEY` Yapılandırması:** "Supabase -> Edge Functions" -> "Environment Variables" kısmında bir gizli anahtar oluşturun. Bu anahtar, yapay zeka anahtarlarınızı Supabase içinde saklanırken şifrelemek için kullanılır.

    *   **`SUPABASE_ACCESS_TOKEN` Oluşturma:**
        1.  Docker konsolunuza erişin.
        2.  `supabase login` komutunu çalıştırın ve verilen URL ile kimlik doğrulaması yapın.
        3.  `cat ~/.supabase/access-token` komutunu çalıştırarak erişim anahtarını alın.
        4.  Bu anahtarı `docker-compose.yml` veya Portainer yapılandırmanıza ekleyin ve yeniden dağıtım yapın.
        5.  Yeniden dağıtımdan sonra, SparkyFitness'a giriş yapın ve tercih ettiğiniz sağlayıcı ile AI servisini yapılandırın.
     

### Supabase'e DB & Fonksiyonların Manuel Dağıtımı
**Yöntem 1:  
**Eğer IPV6 ağ bağlantınız etkin değilse, veritabanı geçişi başarısız olur çünkü Supabase'in ücretsiz sürümü IPV4 doğrudan bağlantıyı desteklemez.

   1. Son sürümü indirin ve bilgisayarınıza çıkarın.
   2. Proje klasörüne gidin. Docker'ın çalışıyor olması gerekir.
   3. Aşağıdaki komutları çalıştırın. (functions deploy sadece AI yapılandırması için gereklidir. ChatBOT'a ihtiyacınız yoksa atlayabilirsiniz)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Docker compose'u tekrar çalıştırın. Ön uç uygulama çalışmaya başlayacaktır.

**Yöntem 2:  
   1. Son sürümü indirin ve bilgisayarınıza çıkarın.  
   2. Proje klasörüne gidin.  
   3. supabase/migrations dizinine gidin. SQL ifadelerini kopyalayıp Supabase-->Proje-->SQL Editör kısmında sırayla (ASC olarak) çalıştırın.  
   4. [Opsiyonel] AI ChatBOT'a ihtiyacınız varsa, aynı işlemi supabase/functions/chat için de yapın. index.js dosyasını kopyalayıp Supabase-->Proje-->Edge Function-->Yeni fonksiyon dağıt kısmında çalıştırın.  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---