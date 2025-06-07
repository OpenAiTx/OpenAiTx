# GroceryApp Starter

Basit ve kolay bir alışveriş deneyimi için optimize edilmiş market uygulaması şablonu. 🛒✨

Eğer bu depoyu değerli buluyorsanız, ⭐ ile işaretlemeyi unutmayın.

## Tasarım

**Figma tasarımını görüntülemek için aşağıdaki görsele tıklayın:**

[![Tasarım Önizlemesi](https://raw.githubusercontent.com/ramiomarouayache/Flutter-GroceryApp/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨Gereksinimler

1. **Geliştirme Ortamı:**
   - Flutter SDK kurulu herhangi bir IDE (ör. VSCode, Android Studio, IntelliJ...vb)

2. **Bilgi Düzeyi:**
   - Dart ve Flutter hakkında temel veya orta seviye bilgi
   - MVVM mimarisi hakkında bilgi sahibi olmak
   - API kullanımı konusunda deneyim
   - GetX ile durum yönetimi temelleri
  
## Test
* Android cihazlar için ön sürümü buradan indirebilirsiniz: [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## Kurulum
* `lib\constants\AppConstants` dosyasında ürün uç noktanızı, kimlik bilgilerinizi ve parametrelerinizi yapılandırarak başlayın.
* **Alternatif olarak**, başarılı testler için aşağıda verilen (paylaşım tarihi itibarıyla) ücretsiz uç noktayı kullanabilirsiniz.
```dart
class AppConstants {
  // "YOUR_API_PREFIX" ifadesini kendi API taban URL’niz ile değiştirin.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //VARSA

  // Test için, yayınlanan sürümdeki ücretsiz API taban URL’sini kullanın
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Proje sahibi tam adı.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Dikkat
* Kendi API uç noktalarınızı kullanmak için, mantıksal katmanları API dokümantasyonunuza ve MVVM mimarisi yönergelerine göre özelleştirin.
* Ön sürümdeki bazı görseller, telif hakkı nedeniyle kaldırılmıştır.

## Katkıda Bulunun

Lütfen bu depoyu çatallayın (fork) ve
[pull request](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls) kullanarak katkıda bulunun.

Büyük ya da küçük tüm katkılar, büyük özellikler veya hata düzeltmeleri memnuniyetle karşılanır ve dikkatlice incelenir.


## Başlarken
Bu proje, bir Flutter uygulaması için başlangıç noktasıdır.

İlk Flutter projeniz ise sizi başlatacak bazı kaynaklar:

- [Lab: İlk Flutter uygulamanızı yazın](https://flutter.io/docs/get-started/codelab)
- [Cookbook: Faydalı Flutter örnekleri](https://flutter.io/docs/cookbook)

## Ziyaretçi Sayısı

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Yükleniyor">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---