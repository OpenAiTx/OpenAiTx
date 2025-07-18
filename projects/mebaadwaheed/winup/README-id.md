<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## Contoh Gambar

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## Pastikan Anda mengunduh Rilis Stabil Terbaru (LSR) dan bukan versi terbaru/LFR! LSR Saat Ini: 2.4.9

`pip install winup==2.4.9`

**Sebuah framework Pythonic yang sangat kuat untuk membangun aplikasi desktop yang indah.**

WinUp adalah framework UI modern untuk Python yang membungkus kekuatan PySide6 (Qt) dalam API yang sederhana, deklaratif, dan ramah pengembang. Dirancang untuk membangun aplikasi lebih cepat, menulis kode yang lebih bersih, dan menikmati proses pengembangan.

### ✨ Sekarang dengan Dukungan Web!
WinUp kini juga mendukung pembuatan aplikasi web yang interaktif dan stateful sepenuhnya menggunakan pendekatan berbasis komponen yang berpusat pada Python. Modul web menggunakan FastAPI dan WebSockets di balik layar untuk menghadirkan kesederhanaan WinUp ke browser.

[Dokumentasi Web](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Disclaimer:** Dukungan web adalah fitur opsional. Untuk menggunakannya, Anda harus menginstal dependensi web:
> ```bash
> pip install "winup[web]"
> ```

[Kontribusi](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Catatan Perubahan](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Lisensi](LICENSE)

---

## Mengapa WinUp? (Bukan PySide6 mentah atau Tkinter)

Pengembangan desktop di Python bisa terasa rumit. WinUp dibuat untuk memperbaikinya.

| Fitur                  | Cara WinUp ✨                                                                   | Cara PySide6 / Tkinter Mentah 😟                                                                |
| ---------------------- | ------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------- |
| **Layouts**            | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                     |
| **Styling**            | `props={"background-color": "blue", "font-size": "16px"}`                      | Manual QSS strings, `widget.setStyleSheet(...)`, objek style yang kompleks.                    |
| **Manajemen State**    | `state.bind(widget, "prop", "key")`                                            | Fungsi callback manual, getter/setter, `StringVar()`, boilerplate di mana-mana.                |
| **Two-Way Binding**    | `state.bind_two_way(input_widget, "key")`                                      | Tidak ada. Membutuhkan handler `on_change` manual untuk memperbarui state dan UI.              |
| **Developer Tools**    | **Hot Reloading Bawaan**, code profiler, dan alat window siap pakai.           | Tidak ada. Harus me-restart aplikasi untuk setiap perubahan UI.                                |
| **Struktur Kode**      | Komponen yang dapat digunakan kembali, mandiri dengan `@component`.            | Seringkali menjadi kelas besar, monolitik, atau skrip prosedural.                              |

**Singkatnya, WinUp menyediakan fitur andalan framework web modern (seperti React atau Vue) untuk desktop, menghemat waktu Anda dan membiarkan Anda fokus pada hal yang penting: logika aplikasi Anda.**

# 🧊 WinUp vs 🧱 PyEdifice (Permintaan Pengguna Reddit)

| Fitur                           | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Arsitektur                   | Gaya React + state       | Gaya React + state              |
| 🌐 Routing Bawaan               | ✅ Ya (`Router(routes={...})`)      | ❌ Tidak ada routing bawaan            |
| ♻️ Lifecycle Hooks              | ✅ `on_mount`, `on_unmount`, dll.   | ⚠️ Terbatas (`did_mount`, dll.)       |
| 🎨 Sistem Tema / Styling        | ✅ Tema Global & Scoped              | ❌ Injeksi CSS manual                 |
| 🔲 Opsi Layout                  | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ Sebagian besar Box & HBox/VBox     |
| 🎞️ Animasi                     | ✅ Bawaan (fade, scale, dll.)        | ❌ Tidak ada bawaan                   |
| 🔁 Hot Reloading (LHR)          | ✅ Stabil + cepat (`loadup dev`)     | ⚠️ Eksperimental, dukungan terbatas   |
| 📦 Packaging                    | ✅ Dengan LoadUp (berbasis PyInstaller) | ❌ Harus integrasi PyInstaller manual |
| 🧩 Reusabilitas Komponen        | ✅ Tinggi, deklaratif                | ✅ Tinggi                             |

| 🛠 Alat Pengembang              | ✅ DevTools direncanakan, Inspector segera hadir  | ❌ Belum ada                       |
| 📱 Dukungan Mobile              | ❌ Belum tersedia                                 | ❌ Tidak didukung                  |
| 🧠 Kurva Pembelajaran           | ✅ Mudah untuk pengguna Python+React              | ✅ Mudah tapi tooling terbatas     |

> ✅ = Bawaan atau kuat  
> ⚠️ = Parsial atau terbatas  
> ❌ = Tidak tersedia sama sekali
---

## Fitur Inti

*   **UI Deklaratif & Pythonic:** Bangun layout kompleks dengan objek `Row` dan `Column` sederhana daripada layout box yang rumit.
*   **Arsitektur Berbasis Komponen:** Gunakan dekorator `@component` untuk membuat widget UI modular dan dapat digunakan ulang dari fungsi sederhana.
*   **Sistem Styling Kuat:** Atur gaya widget Anda dengan dictionary Python sederhana menggunakan `props`. Buat kelas global seperti "CSS" dengan `style.add_style_dict`.
*   **Shell Aplikasi Lengkap:** Bangun aplikasi profesional dengan API deklaratif untuk `MenuBar`, `ToolBar`, `StatusBar`, dan `SystemTrayIcon`.
*   **Task Runner Asinkron:** Jalankan operasi jangka panjang di latar belakang tanpa membekukan UI Anda dengan dekorator `@tasks.run` yang mudah.
*   **Performa Default:** Termasuk dekorator opsional `@memo` untuk cache render komponen dan mencegah komputasi ulang yang tidak perlu.
*   **Ekstensibilitas Lanjutan:**
    *   **Widget Factory:** Gantikan widget default dengan implementasi kustom Anda (misal, berbasis C++) menggunakan `ui.register_widget()`.
    *   **Multi Jendela:** Buat dan kelola beberapa jendela independen untuk aplikasi kompleks seperti palet alat atau pemutar musik.
*   **Manajemen State Reaktif:**
    *   **One-Way Binding:** Perbarui UI Anda otomatis ketika data berubah dengan `state.bind()`.
    *   **Two-Way Binding:** Sinkronkan widget input dengan state Anda secara mudah menggunakan `state.bind_two_way()`.
    *   **Subscriptions:** Jalankan fungsi apapun saat state berubah dengan `state.subscribe()`.
*   **Alat Pengembang Ramah:**
    *   **Hot Reloading:** Lihat perubahan UI Anda seketika tanpa me-restart aplikasi.
    *   **Profiler:** Ukur performa fungsi apapun dengan dekorator `@profiler.measure()`.
    *   **Alat Jendela:** Atur posisi tengah, flash, atau kelola jendela aplikasi dengan mudah.
*   **Routing Bawaan:** Buat aplikasi multi-halaman dengan router intuitif yang digerakkan oleh state.
*   **Data Layer Fleksibel:** Tersedia konektor sederhana dan konsisten untuk SQLite, PostgreSQL, MySQL, MongoDB, dan Firebase.

---

# Dokumentasi

Pelajari lebih dalam fitur WinUp:

## Konsep Inti
- [**Model Komponen & Styling**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**Manajemen State**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Lifecycle Hooks**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Routing**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Absolute Positioning (Advanced)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Alat Pengembang
- [**Live Hot Reload (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Performance Profiler**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Memoization**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Async Task Runner**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## Komponen UI
- [**Full Component Library**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Kontribusi

WinUp adalah proyek open-source. Kontribusi sangat diterima!

## Lisensi

Proyek ini dilisensikan di bawah MIT License. Lihat **LICENSE** untuk informasi lebih lanjut.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---