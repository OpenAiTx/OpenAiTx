# Cheating Daddy

> [!NOTE]  
> Gunakan versi terbaru MacOS dan Windows, versi lama memiliki dukungan terbatas

> [!NOTE]  
> Selama pengujian, aplikasi tidak akan menjawab jika Anda bertanya sesuatu, Anda perlu mensimulasikan pewawancara yang mengajukan pertanyaan, yang akan dijawab oleh aplikasi

Asisten AI real-time yang memberikan bantuan kontekstual selama panggilan video, wawancara, presentasi, dan rapat dengan menggunakan tangkapan layar dan analisis audio.

## Fitur

- **Bantuan AI Langsung**: Bantuan real-time didukung oleh Google Gemini 2.0 Flash Live
- **Tangkapan Layar & Audio**: Menganalisis apa yang Anda lihat dan dengar untuk respons yang kontekstual
- **Banyak Profil**: Wawancara, Panggilan Penjualan, Rapat Bisnis, Presentasi, Negosiasi
- **Overlay Transparan**: Jendela selalu di atas yang dapat diposisikan di mana saja
- **Mode Click-through**: Membuat jendela transparan terhadap klik saat dibutuhkan
- **Lintas Platform**: Berjalan di macOS, Windows, dan Linux (sementara ini hanya untuk pengujian, jangan digunakan)

## Pengaturan

1. **Dapatkan Gemini API Key**: Kunjungi [Google AI Studio](https://aistudio.google.com/apikey)
2. **Instal Dependensi**: `npm install`
3. **Jalankan Aplikasi**: `npm start`

## Cara Penggunaan

1. Masukkan kunci API Gemini Anda di jendela utama
2. Pilih profil dan bahasa di pengaturan
3. Klik "Mulai Sesi" untuk memulai
4. Posisikan jendela menggunakan pintasan keyboard
5. AI akan memberikan bantuan real-time berdasarkan layar Anda dan pertanyaan dari pewawancara

## Pintasan Keyboard

- **Pergerakan Jendela**: `Ctrl/Cmd + Panah` - Memindahkan jendela
- **Click-through**: `Ctrl/Cmd + M` - Mengaktifkan/mematikan event mouse
- **Tutup/Kembali**: `Ctrl/Cmd + \` - Menutup jendela atau kembali
- **Kirim Pesan**: `Enter` - Mengirim teks ke AI

## Tangkapan Audio

- **macOS**: [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) untuk audio sistem 
- **Windows**: Tangkapan audio loopback
- **Linux**: Input mikrofon

## Persyaratan

- OS yang kompatibel dengan Electron (macOS, Windows, Linux)
- Kunci API Gemini
- Izin perekaman layar
- Izin mikrofon/audio

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---