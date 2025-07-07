<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>Açık kaynaklı özgeçmiş oluşturucu; bağlantılarınızı yapıştırın, manuel olarak düzenleyin ve AI'ın özgeçmişinizi parlatma, güncelleme ve özelleştirme konularında size yardımcı olmasına izin verin.</b>
</p>

---

### Bunu nasıl kullanırım?

[Medium Blog Linki](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

Blog, Kullanıcı Arayüzü ve kullanılan Şablon açısından güncel değildir.

## Özellikler

- <b>Kolay Bağlantı İçe Aktarma:</b> Web sitelerinden bağlantılar yapıştırın ve hızlıca PDF özgeçmişinizi oluşturun.
- <b>Manuel Editör Dahil:</b> Gömülü kod editörü ile özgeçmişinizi sıfırdan oluşturun veya ince ayar yapın.
- <b>Akıllı Öneriler:</b> Geri bildirim veya yeni bağlantılar paylaşın, smartedits ile özgeçmişiniz geliştirilsin ve güncellensin.
- <b>İşlere Özel:</b> Bir iş ilanı yapıştırın, özgeçmişinizi uyumlu hale getirmek için öneriler alın.
- <b>LaTeX Kalitesi:</b> Tüm özgeçmişler temiz ve profesyonel bir düzen için LaTeX kullanılarak oluşturulur.
- <b>Anında Önizleme:</b> Özgeçmişinizi gerçek zamanlı olarak PDF şeklinde görün.
- <b>Kolay Sıfırlama:</b> Özgeçmişinizi bir tıkla temizleyin ve yeniden başlayın.
- <b>Lokal:</b> Tamamen kendi makinenizde Docker ile çalışır.

---

## Başlarken

### Gereksinimler
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### Kurulum

1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. Uygulamayı oluşturun ve başlatın:
   ```bash
   docker compose up --build
   ```
3. Uygulamalara erişin:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## Kullanım

1. autoResume'u tarayıcınızda açın.
2. :gear: simgesine tıklayın, [GOOGLE API KEY](https://aistudio.google.com/) anahtarınızı ve E‑posta adresinizi yapıştırın.
3. Profesyonel bilgilerinize ait bağlantıları yapıştırın (ör. Github, Kişisel Web Sitesi vb.).
4. İsteğe bağlı olarak, daha fazla özelleştirme için geri bildirim veya iş ilanı bağlantısı ekleyin.
5. <b>Özgeçmiş Oluştur</b> butonuna tıklayın ve gerisini AI'a bırakın!

---

## Lisans

Bu proje Apache 2.0 Lisansı ile lisanslanmıştır.

## Katkı Rehberi

### Ön Yüz (Frontend)
- React bileşenlerini `frontend/src/components/` klasöründe uygulayın
- Bileşenleri uygulamak için Chakra UI kullanıyoruz.
- Bileşenlerinizi `frontend/src/App.jsx` dosyasında içe aktarın ve kullanın

### Arka Yüz (Backend)
- API rotalarını `backend/src/routes/` dizininde uygulayın
- AI işlevselliğini `backend/src/ai/` dizininde ekleyin
- Python kodu için `black` kod biçimlendiricisini kullanıyoruz
- Rota işleyicilerini temiz tutun ve mantığı ayırın

### Genel Yönergeler
- Özelliğiniz/düzeltmeniz için yeni bir dal oluşturun: `git checkout -b dal-adınız`
- Açık ve anlaşılır commit mesajları yazın
- PR göndermeden önce değişikliklerinizi test edin

### Değişiklik Gönderme
1. Bir Pull Request oluşturun
2. PR açıklamanızda şunları ekleyin:
   - Yaptığınız değişiklikler
   - Neden bu değişiklikleri yaptığınız
   - İlgili ekran görüntüleri veya test sonuçları
   - Herhangi bir yıkıcı değişiklik veya geçiş adımı gerekip gerekmediği

Katkılarınızı takdir ediyoruz ve PR'nizi mümkün olan en kısa sürede inceleyeceğiz!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---