# SinGAN

[Proyek](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [Materi tambahan](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Talk (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### Implementasi pytorch resmi dari makalah: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### ICCV 2019 Best paper award (Marr prize)


## Sampel acak dari *satu* gambar
Dengan SinGAN, Anda dapat melatih model generatif dari satu gambar alami, dan kemudian menghasilkan sampel acak dari gambar yang diberikan, contohnya:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## Aplikasi SinGAN
SinGAN juga dapat digunakan untuk berbagai tugas manipulasi gambar, misalnya:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
Ini dilakukan dengan menyuntikkan sebuah gambar ke model yang sudah dilatih. Lihat bagian 4 di [makalah kami](https://arxiv.org/pdf/1905.01164.pdf) untuk detail lebih lanjut.


### Sitasi
Jika Anda menggunakan kode ini untuk penelitian Anda, mohon sitasi makalah kami:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar dan Dekel, Tali dan Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## Kode

### Instalasi dependensi

```
python -m pip install -r requirements.txt
```

Kode ini diuji dengan python 3.6, torch 1.4

Catatan: kode saat ini hanya mendukung torch 1.4 atau sebelumnya karena skema optimisasi.

Untuk versi torch yang lebih baru, Anda bisa mencoba repositori ini: https://github.com/kligvasser/SinGAN (hasilnya tidak selalu identik dengan implementasi resmi).


###  Pelatihan
Untuk melatih model SinGAN pada gambar Anda sendiri, letakkan gambar pelatihan yang diinginkan di bawah Input/Images, dan jalankan

```
python main_train.py --input_name <input_file_name>
```

Ini juga akan menggunakan model hasil pelatihan untuk menghasilkan sampel acak dimulai dari skala paling kasar (n=0).

Untuk menjalankan kode ini pada mesin cpu, tentukan `--not_cuda` saat memanggil `main_train.py`

###  Sampel acak
Untuk menghasilkan sampel acak dari skala generasi awal manapun, silakan latih dulu model SinGAN pada gambar yang diinginkan (seperti dijelaskan di atas), lalu jalankan 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

perhatikan: untuk menggunakan model penuh, tentukan skala mulai generasi menjadi 0, untuk memulai dari skala kedua, tentukan menjadi 1, dan seterusnya. 

###  Sampel acak dengan ukuran sembarang
Untuk menghasilkan sampel acak dengan ukuran sembarang, silakan latih dulu model SinGAN pada gambar yang diinginkan (seperti dijelaskan di atas), lalu jalankan

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

###  Animasi dari satu gambar

Untuk menghasilkan animasi pendek dari satu gambar, jalankan

```
python animation.py --input_name <input_file_name> 
```

Ini akan otomatis memulai fase pelatihan baru dengan mode noise padding.

###  Harmonisasi

Untuk mengharmonisasi objek yang ditempel ke dalam sebuah gambar (Lihat contoh pada Gbr. 13 di [makalah kami](https://arxiv.org/pdf/1905.01164.pdf)), silakan latih terlebih dahulu model SinGAN pada gambar latar belakang yang diinginkan (seperti dijelaskan di atas), kemudian simpan gambar referensi yang ditempel secara naif dan mask biner-nya di bawah "Input/Harmonization" (lihat gambar tersimpan untuk contoh). Jalankan perintah

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

Perlu dicatat bahwa skala injeksi yang berbeda akan menghasilkan efek harmonisasi yang berbeda. Skala injeksi paling kasar sama dengan 1. 

###  Editing

Untuk mengedit sebuah gambar, (Lihat contoh pada Gbr. 12 di [makalah kami](https://arxiv.org/pdf/1905.01164.pdf)), silakan latih terlebih dahulu model SinGAN pada gambar yang belum diedit (seperti dijelaskan di atas), lalu simpan hasil edit naif sebagai gambar referensi di bawah "Input/Editing" dengan peta biner yang sesuai (lihat gambar tersimpan untuk contoh). Jalankan perintah

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
```
baik output yang bertopeng maupun yang tidak bertopeng akan disimpan.
Di sini juga, skala injeksi yang berbeda akan menghasilkan efek editing yang berbeda. Skala injeksi paling kasar adalah 1.

### Paint to Image

Untuk mentransfer sebuah lukisan menjadi gambar realistis (Lihat contoh pada Gambar 11 di [makalah kami](https://arxiv.org/pdf/1905.01164.pdf)), silakan latih terlebih dahulu model SinGAN pada gambar yang diinginkan (seperti dijelaskan di atas), kemudian simpan lukisan Anda di "Input/Paint", dan jalankan perintah

```
python paint2image.py --input_name <nama_file_gambar_latih> --ref_name <nama_file_gambar_lukisan> --paint_start_scale <skala injeksi>
```
Di sini juga, skala injeksi yang berbeda akan menghasilkan efek editing yang berbeda. Skala injeksi paling kasar adalah 1.

Opsi lanjutan: Tentukan quantization_flag menjadi True, untuk melatih ulang *hanya* pada tingkat injeksi model, untuk mendapatkan versi kuantisasi warna dari gambar hasil upsampling pada skala sebelumnya. Untuk beberapa gambar, ini bisa menghasilkan hasil yang lebih realistis.

### Super Resolution
Untuk melakukan super resolusi pada sebuah gambar, silakan jalankan:
```
python SR.py --input_name <nama_file_gambar_LR>
```
Ini akan secara otomatis melatih model SinGAN yang sesuai dengan faktor upsampling 4x (jika belum ada).
Untuk faktor SR yang berbeda, silakan tentukan menggunakan parameter `--sr_factor` saat memanggil fungsi.
Hasil SinGAN pada dataset BSD100 dapat diunduh dari folder 'Downloads'.

## Data dan Fungsi Tambahan

### Single Image Fréchet Inception Distance (Skor SIFID)
Untuk menghitung SIFID antara gambar asli dan sampel palsu yang sesuai, silakan jalankan:
```
python SIFID/sifid_score.py --path2real <path gambar asli> --path2fake <path gambar palsu>
```
Pastikan setiap nama file gambar palsu identik dengan nama file gambar aslinya yang sesuai. Gambar harus disimpan dalam format `.jpg`.

### Hasil Super Resolution
Hasil SR SinGAN pada dataset BSD100 dapat diunduh dari folder 'Downloads'.

### Studi Pengguna
Data yang digunakan untuk studi pengguna dapat ditemukan di folder Downloads.

folder real: 50 gambar asli, dipilih secara acak dari [places database](http://places.csail.mit.edu/)

folder fake_high_variance: sampel acak mulai dari n=N untuk setiap gambar asli

folder fake_mid_variance: sampel acak mulai dari n=N-1 untuk setiap gambar asli

Untuk detail tambahan silakan lihat bagian 3.1 pada [makalah kami](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---