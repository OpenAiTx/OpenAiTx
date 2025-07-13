# Tombol 3D yang Dapat Ditekan

Komponen tombol 3D realistis yang dibuat dengan HTML, CSS, dan SVG yang mensimulasikan rasa menekan tombol fisik. Tombol ini memiliki animasi yang halus, warna yang dapat dikustomisasi, dan interaksi yang responsif.

Dibuat oleh [@BalintFerenczy](https://x.com/BalintFerenczy)

Terinspirasi oleh karya luar biasa di [Resend](https://resend.com/)

## Fitur

- **Tampilan 3D realistis** menggunakan grafik SVG berlapis
- **Animasi halus** dengan fungsi easing khusus
- **Status interaktif** - efek hover dan tekan
- **Warna yang dapat dikustomisasi** melalui variabel CSS
- **Desain responsif** yang menyesuaikan dengan ukuran kontainer

## Demo
Tombol merespons interaksi pengguna dengan tiga status yang berbeda:
- **Normal**: Tombol dalam posisi diam
- **Hover**: Gerakan turun halus saat mouse diarahkan ke atas
- **Aktif**: Gerakan turun signifikan saat ditekan/diklik

## Penggunaan

### Kustomisasi

Tombol dapat dengan mudah dikustomisasi menggunakan properti kustom CSS:

```css
.frame {
    /* Dimensi tombol */
    width: 400px; 
    height: 400px; 

    /* Jarak pergerakan */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* Kustomisasi warna */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* Pengaturan transisi */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### Mengubah Teks Tombol

Cukup ubah konten teksnya:

```html
<p class="text">Klik Saya!</p>
```

#### Mengubah Ukuran Tombol

Sesuaikan dimensi frame:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## Lisensi

Proyek ini bersifat open source dan tersedia di bawah Lisensi MIT.

## Kontribusi

Silakan fork proyek ini dan kirimkan pull request untuk perbaikan atau fitur baru!

## Penulis

Dibuat oleh [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---