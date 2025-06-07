<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>Implementasi jaringan lightning yang cepat dan modular untuk segala penggunaan, ditulis dalam Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Beranda Proyek</a>
  </h4>
</div>

## Crates

Berikut adalah daftar lengkap crates yang didukung saat ini:

| Crate       | Deskripsi                                   | Versi     |
|:------------|:-------------------------------------------:|----------:|
| lampod-cli  | Antarmuka baris perintah Lampo Daemon untuk menjalankan daemon | _unrelated_ |
| lampo-cli   | Antarmuka baris perintah Lampo sederhana untuk berinteraksi dengan daemon | _unrelated_ |

## Cara Instalasi

Untuk menginstal semua persyaratan dan binary Lampo, Anda perlu
memiliki rust yang telah terpasang, kemudian jalankan perintah berikut:

```
make install
```

Setelah Anda memiliki `lampod-cli` dan `lampo-cli`, Anda dapat
menjalankan perintah berikut untuk meluncurkan Lampo dalam mode signet:

```
➜  ~ lampod-cli --network signet
✓ Dompet Dihasilkan, harap simpan kata-kata ini dengan aman
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Simpan kata-kata dompet Anda, kemudian gunakan kembali untuk memulihkan dompet dengan `--restore-wallet`.
Jika Anda tidak menyimpan kata-kata tersebut di mana pun, dana Anda akan hilang saat Lampo dijalankan berikutnya!

Harap dicatat bahwa Anda harus memiliki file `lampo.conf` di path `~/.lampo/signet`. Jalankan
perintah berikut untuk menggunakan file konfigurasi contoh:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Lalu Anda dapat melakukan query node dengan perintah berikut:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Untuk menjalankan pengujian integrasi dengan core lightning:

Pastikan Anda telah mengkompilasi core-lightning dalam mode pengembang. Panduan instalasi dapat ditemukan [di sini](https://docs.corelightning.org/docs/installation).

Pengujian integrasi dapat dijalankan menggunakan perintah berikut:

```
make integration
```

## Panduan Berkontribusi

Silakan baca [Panduan Kontribusi](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md) kami.

## Komunitas

Demi menjaga kejelasan, kami memilih saluran komunikasi tertentu:
- Pengembang, bergabunglah dengan kami di [Zulip](https://lampo-dev.zulipchat.com/).
- Anggota komunitas, [Komunitas Twitter](https://twitter.com/i/communities/1736414802849706087) kami menantikan wawasan Anda.
- Untuk pertanyaan teknis dan permintaan fitur, silakan berdiskusi di GitHub kami.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---