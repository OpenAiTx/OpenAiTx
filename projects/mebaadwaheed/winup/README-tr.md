<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">İngilizce</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">Japonca</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">Korece</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">Hintçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">Tayca</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Fransızca</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Almanca</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">İspanyolca</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">İtalyanca</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Rusça</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Portekizce</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Felemenkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Lehçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">Arapça</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">Farsça</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Vietnamca</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Endonezce</a>
      </div>
    </div>
  </details>
</div>

![PR'ler Hoş Geldiniz](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Bileşen Odaklı](https://img.shields.io/badge/architecture-component--driven-orange)
![Masaüstü Uygulaması](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Desteği](https://img.shields.io/badge/CLI-supported-critical)
![Canlı Yenileme](https://img.shields.io/badge/live--reload-enabled-blue)

## Görsel Örnekler

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## En Son Kararlı Sürüm'ü (LSR) indirdiğinizden emin olun, en son/LFR'yi değil! Mevcut LSR: 2.4.9

`pip install winup==2.4.9`

**Gülünç derecede Pythonik ve güçlü, güzel masaüstü uygulamaları geliştirmek için bir çerçeve.**

WinUp, PySide6 (Qt) gücünü basit, deklaratif ve geliştirici dostu bir API ile saran modern bir Python UI çerçevesidir. Uygulamaları daha hızlı geliştirmeniz, daha temiz kod yazmanız ve geliştirme sürecinden keyif almanız için tasarlanmıştır.

### ✨ Artık Web Desteği ile!
WinUp artık aynı Python merkezli, bileşen tabanlı yaklaşımı kullanarak tamamen etkileşimli, durumlu web uygulamaları oluşturmayı da destekliyor. Web modülü, WinUp'ın sadeliğini tarayıcıya taşımak için arka planda FastAPI ve WebSockets kullanır.

[Web Dokümantasyonu](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Feragatname:** Web desteği isteğe bağlı bir özelliktir. Kullanmak için web bağımlılıklarını yüklemelisiniz:
> ```bash
> pip install "winup[web]"
> ```

[Katkıda Bulunma](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Günlükler](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Lisans](LICENSE)

---

## Neden WinUp? (Doğrudan PySide6 veya Tkinter yerine)

Python ile masaüstü geliştirme hantal hissettirebilir. WinUp bunu düzeltmek için geliştirildi.

| Özellik                  | WinUp Yolu ✨                                                                   | Ham PySide6 / Tkinter Yolu 😟                                                                 |
| ----------------------- | ------------------------------------------------------------------------------ | --------------------------------------------------------------------------------------------- |
| **Yerleşimler**          | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                    |
| **Stil Verme**           | `props={"background-color": "blue", "font-size": "16px"}`                      | Elle QSS dizeleri, `widget.setStyleSheet(...)`, karmaşık stil nesneleri.                      |
| **Durum Yönetimi**       | `state.bind(widget, "prop", "key")`                                            | Elle geri çağırma fonksiyonları, getter/setter, `StringVar()`, her yerde boilerplate kod.      |
| **Çift Yönlü Bağlama**   | `state.bind_two_way(input_widget, "key")`                                      | Yok. Durumu ve UI'yı güncellemek için manuel `on_change` işleyicileri gerekir.                |
| **Geliştirici Araçları** | **Dahili Canlı Yenileme**, kod profil aracı ve pencere araçları kutudan çıkar. | Yok. Her UI değişikliği için tüm uygulamayı yeniden başlatın.                                 |
| **Kod Yapısı**           | `@component` ile tekrar kullanılabilir, kendine yeten bileşenler.              | Genellikle büyük, tek parça sınıflar veya prosedürel betiklere yol açar.                      |

**Kısacası, WinUp masaüstü için modern web çerçevelerinin (React veya Vue gibi) "öldürücü özelliklerini" sağlar, size zaman kazandırır ve uygulamanızın mantığına odaklanmanıza olanak tanır.**

# 🧊 WinUp vs 🧱 PyEdifice (Reddit Kullanıcı İsteği)

| Özellik                          | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Mimari                        | React tarzı + durum       | React tarzı + durum              |
| 🌐 Dahili Yönlendirme            | ✅ Evet (`Router(routes={...})`)      | ❌ Dahili yönlendirme yok         |
| ♻️ Yaşam Döngüsü Kancaları      | ✅ `on_mount`, `on_unmount`, vb.      | ⚠️ Sınırlı (`did_mount`, vb.)     |
| 🎨 Tema / Stil Sistemi          | ✅ Global & Kapsamlı temalar           | ❌ Elle CSS ekleme                |
| 🔲 Yerleşim Seçenekleri          | ✅ Satır, Sütun, Izgara, Yığın, Flexbox| ⚠️ Çoğunlukla Box & HBox/VBox     |
| 🎞️ Animasyonlar                 | ✅ Dahili (fade, scale, vb.)           | ❌ Dahili yok                     |
| 🔁 Canlı Yenileme (LHR)          | ✅ Kararlı + hızlı (`loadup dev`)      | ⚠️ Deneysel, sınırlı destek       |
| 📦 Paketleme                     | ✅ LoadUp ile (PyInstaller tabanlı)    | ❌ PyInstaller'ı manuel entegre etmelisiniz |
| 🧩 Bileşen Tekrar Kullanımı      | ✅ Yüksek, deklaratif                  | ✅ Yüksek                         |

| 🛠 Geliştirici Araçları         | ✅ DevTools planlandı, Inspector yakında  | ❌ Henüz yok                         |
| 📱 Mobil Desteği                | ❌ Henüz değil                          | ❌ Desteklenmiyor                    |
| 🧠 Öğrenme Eğrisi               | ✅ Python+React kullanıcıları için kolay | ✅ Kolay ama daha az araç            |

> ✅ = Dahili veya güçlü  
> ⚠️ = Kısmi veya sınırlı  
> ❌ = Tamamen eksik
---

## Temel Özellikler

*   **Deklaratif ve Pythonik Arayüz:** Karmaşık düzenleri hantal kutu yerleşimleri yerine basit `Row` ve `Column` nesneleriyle oluşturun.
*   **Bileşen Tabanlı Mimari:** Basit fonksiyonlardan modüler ve tekrar kullanılabilir arayüz bileşenleri oluşturmak için `@component` dekoratörünü kullanın.
*   **Güçlü Stil Sistemi:** Bileşenlerinizi `props` ile basit Python sözlükleriyle stillendirin. `style.add_style_dict` ile global "CSS benzeri" sınıflar oluşturun.
*   **Tam Uygulama Kabukları:** `MenuBar`, `ToolBar`, `StatusBar` ve `SystemTrayIcon` için deklaratif API ile profesyonel uygulamalar geliştirin.
*   **Asenkron Görev Çalıştırıcı:** Basit `@tasks.run` dekoratörüyle uzun süren işlemleri arka planda çalıştırın, arayüzünüz donmasın.
*   **Varsayılan Olarak Performans:** Bileşen render’larını önbelleğe almak ve gereksiz hesaplamaları önlemek için isteğe bağlı `@memo` dekoratörü içerir.
*   **Gelişmiş Genişletilebilirlik:**
    *   **Bileşen Fabrikası:** Varsayılan herhangi bir bileşeni (ör. C++ tabanlı) kendi özel uygulamanızla `ui.register_widget()` kullanarak değiştirin.
    *   **Çoklu Pencereler:** Karmaşık uygulamalar için bağımsız birden fazla pencere oluşturun ve yönetin (ör. araç paletleri, müzik çalarlar).
*   **Reaktif Durum Yönetimi:**
    *   **Tek Yönlü Bağlama:** `state.bind()` ile veriniz değiştiğinde arayüzünüz otomatik güncellensin.
    *   **Çift Yönlü Bağlama:** `state.bind_two_way()` ile giriş bileşenlerini durumunuzla zahmetsizce senkronize edin.
    *   **Abonelikler:** `state.subscribe()` ile durum değişikliklerine tepki olarak herhangi bir fonksiyonu tetikleyin.
*   **Geliştirici Dostu Araçlar:**
    *   **Sıcak Yeniden Yükleme:** Arayüz değişikliklerinizi uygulamanızı yeniden başlatmadan anında görün.
    *   **Profil Aracı:** Herhangi bir fonksiyonun performansını `@profiler.measure()` dekoratörüyle kolayca ölçün.
    *   **Pencere Araçları:** Uygulamanızın penceresini kolayca ortalayın, yanıp sönmesini sağlayın veya yönetin.
*   **Dahili Yönlendirme:** Sezgisel, duruma dayalı router ile çok sayfalı uygulamaları kolayca oluşturun.
*   **Esnek Veri Katmanı:** SQLite, PostgreSQL, MySQL, MongoDB ve Firebase için basit, tutarlı bağlayıcılar içerir.

---

# Dokümantasyon

WinUp’ın özelliklerini daha derinlemesine keşfedin:

## Temel Kavramlar
- [**Bileşen Modeli & Stil**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**Durum Yönetimi**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Yaşam Döngüsü Kancaları**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Yönlendirme**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Mutlak Konumlandırma (Gelişmiş)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Geliştirici Araçları
- [**Canlı Sıcak Yeniden Yükleme (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Performans Profil Aracı**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Önbellekleme**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Asenkron Görev Çalıştırıcı**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## Arayüz Bileşenleri
- [**Tüm Bileşen Kütüphanesi**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Katkıda Bulunma

WinUp açık kaynaklı bir projedir. Katkılarınızı bekliyoruz!

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için **LICENSE** dosyasına bakınız.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---