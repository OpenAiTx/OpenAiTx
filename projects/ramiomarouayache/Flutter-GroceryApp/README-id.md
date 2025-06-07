# GroceryApp Starter

Template aplikasi belanja kebutuhan pokok yang efisien untuk pengalaman belanja yang sederhana. 🛒✨

Jangan ragu untuk memberi bintang ⭐ pada repositori ini jika Anda merasa itu bermanfaat.

## Desain

**Klik gambar di bawah ini untuk melihat desain Figma:**

[![Design Preview](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)

## ✨Persyaratan

1. **Lingkungan Pengembangan:**
   - IDE apa pun dengan Flutter SDK terinstal (misal: VSCode, Android Studio, IntelliJ, dll)

2. **Dasar Pengetahuan:**
   - Pengetahuan dasar hingga menengah tentang Dart dan Flutter
   - Memahami arsitektur MVVM
   - Familiar dengan penanganan API
   - Dasar-dasar manajemen state menggunakan GetX

## Uji Coba
* Anda dapat mengunduh versi pra-rilis untuk perangkat android di sini [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

## Setup
* Mulailah dengan mengonfigurasi endpoint produk Anda, kredensial, dan parameter pada `lib\constants\AppConstants`.
* **Atau**, gunakan endpoint gratis yang disediakan di bawah ini (per tanggal berbagi) untuk pengujian yang berhasil.
```dart
class AppConstants {
  // Ganti "YOUR_API_PREFIX" dengan URL dasar API Anda sendiri.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //JIKA_ADA

  // Untuk pengujian, gunakan URL dasar API gratis dari versi rilis
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Nama lengkap pemilik proyek.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Catatan
* Untuk menggunakan endpoint API Anda sendiri, sesuaikan lapisan logika mengikuti pedoman arsitektur MVVM berdasarkan dokumentasi API Anda.
* Beberapa gambar di versi pra-rilis telah dihapus karena pembatasan hak cipta.

## Berkontribusi

Silakan fork repositori ini dan kontribusikan kembali menggunakan
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls).

Setiap kontribusi, besar atau kecil, fitur utama, perbaikan bug, sangat diterima dan dihargai,
tetapi akan ditinjau dengan cermat.

## Memulai
Proyek ini merupakan titik awal untuk aplikasi Flutter.

Beberapa sumber daya untuk membantu Anda memulai jika ini adalah proyek Flutter pertama Anda:

- [Lab: Tulis aplikasi Flutter pertama Anda](https://flutter.io/docs/get-started/codelab)
- [Cookbook: Contoh Flutter yang Berguna](https://flutter.io/docs/cookbook)

## Jumlah Pengunjung

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---