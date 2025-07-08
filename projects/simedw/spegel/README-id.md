# Spegel – Mencerminkan web melalui AI

Secara otomatis menulis ulang situs web ke dalam markdown yang dioptimalkan untuk tampilan di terminal.
Baca postingan blog pengantar [di sini](https://simedw.com/2025/06/23/introducing-spegel/)

Ini adalah proof-of-concept, bug mungkin ditemukan namun silakan ajukan issue atau pull request.

##  Screenshot
Terkadang Anda tidak ingin membaca kisah hidup seseorang hanya untuk mendapatkan sebuah resep
![Contoh Resep](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## Instalasi

Membutuhkan Python 3.11+

```
pip install spegel
```
atau clone repo dan install dalam mode editable

```bash
# Clone dan masuk ke direktori
$ git clone <repo-url>
$ cd spegel

# Install dependensi dan CLI
$ pip install -e .
```

## API Keys
Spegel saat ini hanya mendukung Gemini 2.5 Flash, untuk menggunakannya Anda perlu menyediakan API key di env

```
GEMINI_API_KEY=...
```


## Penggunaan

### Jalankan browser

```bash
spegel                # Mulai dengan layar sambutan
spegel bbc.com        # Buka URL secara langsung
```

Atau, secara setara:

```bash
python -m spegel      # Mulai dengan layar sambutan
python -m spegel bbc.com
```

### Kontrol dasar
- `/`         – Buka input URL
- `Tab`/`Shift+Tab` – Berpindah antar tautan
- `Enter`     – Buka tautan yang dipilih
- `e`         – Edit prompt LLM untuk tampilan saat ini
- `b`         – Kembali
- `q`         – Keluar

## Mengedit pengaturan

Spegel memuat pengaturan dari file konfigurasi TOML. Anda dapat menyesuaikan tampilan, prompt, dan opsi UI.

**Urutan pencarian file konfigurasi:**
1. `./.spegel.toml` (direktori saat ini)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Untuk mengedit pengaturan:
1. Salin contoh konfigurasi:
   ```bash
   cp example_config.toml .spegel.toml
   # atau buat ~/.spegel.toml
   ```
2. Edit `.spegel.toml` di editor favorit Anda.

Contoh potongan:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Ubah halaman web ini menjadi pengalaman browsing terminal yang sempurna! ..."
```

---

Untuk informasi lebih lanjut, lihat kode atau buka issue!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---