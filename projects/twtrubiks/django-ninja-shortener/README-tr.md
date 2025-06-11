# Django Ninja Shortener - Bitly Benzeri Kısa URL Servisi

Django, Django Ninja ve Tailwind CSS ile geliştirilen modern kısa URL servisi, tasarımı Bitly'den ilham almıştır.

Kullanıcılar kayıt olup giriş yaptıktan sonra URL'leri kısaltabilir ve her kısa URL'nin tıklanma sayısını takip edebilir.

Bu proje [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) yardımıyla tamamlanmıştır, bkz. [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Ekran Görüntüleri

Kısa URL sayfası (Kayıt olmadan da kullanılabilir)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Kayıt olursanız tıklamaları takip edebilirsiniz

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Öne Çıkan Özellikler

* **Kullanıcı Doğrulama**: Kullanıcı kayıt, giriş ve çıkış desteklenir.
* **Kısa URL Oluşturma**: Giriş yapan kullanıcılar uzun URL için benzersiz bir kısa URL oluşturabilir.
* **Kısa URL Yönlendirmesi**: Kısa URL'ye tıklandığında kullanıcı orijinal uzun URL'ye yönlendirilir.
* **Tıklama Sayısı Takibi**: Sistem her kısa URL'nin tıklanma sayısını otomatik olarak sayar.
* **Kullanıcı Paneli**: Kullanıcılar oluşturdukları tüm kısa URL'leri ve tıklama istatistiklerini görebilir.
* **RESTful API**: Programatik olarak kısa URL oluşturmak için API uç noktaları sunar.
* **Docker Desteği**: Geliştirme ve dağıtımı kolaylaştıran Dockerfile ve Docker Compose ayarları sağlar.

## 🛠️ Teknoloji Yığını

* **Backend Çatısı**: [Django](https://github.com/twtrubiks/django-tutorial)
* **API Çatısı**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Frontend Stili**: [Tailwind CSS](https://tailwindcss.com/) (`django-tailwind` ile entegre)
* **Veritabanı**:
  * Geliştirme ortamı: SQLite (varsayılan)
  * Üretim ortamı: Kolayca PostgreSQL'e geçilebilir (`settings.py`'de yapılandırma hazır)
* **Kısa URL kodu**: `shortuuid` ile üretilir
* **Test**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Konteynerleştirme**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Hızlı Başlangıç (Docker ile, önerilen yöntem)

Bu en çok önerilen başlatma yöntemidir ve geliştirme ortamının tutarlılığını garanti eder.

**Başlatma Adımları:**

1. **Servisi Başlatın:**

    Docker Compose ile tüm servisleri tek komutla başlatın.

    ```bash
    docker compose up --build
    ```

    Bu komut Docker imajını oluşturur, bağımlılıkları kurar, veritabanı migrasyonlarını çalıştırır ve geliştirme sunucusunu başlatır.

2. **Süper Kullanıcı Oluşturun (isteğe bağlı):**

    Django Admin'e erişmek istiyorsanız başka bir terminalde:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Uygulamaya Erişim:**

    * **Web Sitesi Ana Sayfası**: [http://localhost:8000](http://localhost:8000)

    * **API Dokümantasyonu (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Lokal Geliştirme (Docker olmadan)

Eğer doğrudan yerel ortamınızı kurmak isterseniz.

**Gereksinimler:**

* Python 3.12
* Node.js ve npm (Tailwind CSS için)

**Kurulum Adımları:**

1. **Sanal Ortam Oluştur ve Aktifleştir:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Windows için `venv\Scripts\activate` kullanın
    ```

2. **Python Bağımlılıklarını Kur:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Tailwind CSS'i Kur ve Ayarla:**

    `django-tailwind` çoğu ayarı halledecektir.

    ```bash
    python manage.py tailwind install
    ```

    Ayrıntılar için bkz. [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Veritabanı Migrasyonlarını Çalıştır:**

    ```bash
    python manage.py migrate
    ```

5. **Süper Kullanıcı Oluştur (isteğe bağlı):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Geliştirme Sunucusunu Başlat:**

    Hem Django sunucusunu hem de Tailwind CSS derleyicisini başlatmalısınız.

    ```bash
    python manage.py runserver
    ```

    Başka bir terminalde:

    ```bash
    python manage.py tailwind start
    ```

7. **Uygulamaya Erişim:**

    * **Web Sitesi Ana Sayfası**: [http://localhost:8000](http://localhost:8000)

    * **API Dokümantasyonu (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Testleri Çalıştırma

Bu proje testler için `pytest` kullanır ve test kapsamını ölçer.

Test planı için bkz. [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Docker ile Testleri Çalıştırmak:**

    ```bash
    docker compose --profile test up
    ```

    Test raporu `htmlcov/index.html` içinde oluşturulur.

* **Yerelde Testleri Çalıştırmak:**

    ```bash
    # Geliştirme bağımlılıklarının kurulu olduğundan emin olun
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 API Uç Noktaları

API, kısa URL servisi ile programatik olarak etkileşim kurmayı sağlar. Tüm API uç noktaları `/api/` altında bulunur.

Doğrudan **API Dokümantasyonu (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs) adresini ziyaret edebilirsiniz.

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

[Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt) kullanılır, önce `/api/token/pair` ile kullanıcı adı ve şifrenizle token alın.

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Sonra token'ı sağ üst köşeye yapıştırın ve API'yi çağırabilirsiniz.

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Proje Yapısı

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Django proje ayarları
│   ├── settings.py
│   └── urls.py
├── shortener/            # Kısa URL çekirdek uygulaması
│   ├── models.py         # Veritabanı modeli (Link)
│   ├── api.py            # Django Ninja API uç noktaları
│   ├── views.py          # Sayfa görünümleri ve yönlendirme mantığı
│   └── utils.py          # Kısa kod üretim aracı
└── theme/                # Django tema ve şablonları
    ├── templates/        # HTML şablonları
    └── static_src/       # Tailwind CSS kaynak dosyası
```

## 💡 Gelecek Planları

* **PostgreSQL'e Geçiş**: Üretim ortamı için daha sağlam bir veritabanı. (Tamamlandı)
* **Detaylı Analiz Paneli**: Tıklama zamanı, kaynağı, coğrafi konum gibi daha fazla veri sunmak.
* **Özel Kısa URL**: Kullanıcıların kısa URL kodunu özelleştirmesine izin verir.
* **QR Kod Oluşturma**: Her kısa URL için karşılık gelen bir QR Kod oluşturur.
* **Asenkron Görevler**: Zaman alan görevleri, örneğin veri analizi gibi işlemleri Celery ile yönetir.

## Bağış

Tüm makaleler kendi araştırmalarım ve içselleştirerek orijinal olarak oluşturulmuştur. Eğer size yardımcı olduysa ve beni teşvik etmek isterseniz, bana bir kahve ısmarlayabilirsiniz :laughing:

ECPAY (Üyelik kaydı gerekmez)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Bağış Yap](http://bit.ly/2F7Jrha)

O'Pay (Üyelik kaydı gereklidir)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Bağış Yap](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Bağışçı Listesi

[Bağışçı Listesi](https://github.com/twtrubiks/Thank-you-for-donate)

## Lisans

MIT lisansı

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---