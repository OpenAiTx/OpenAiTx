# StyTr^2 : Image Style Transfer with Transformers（CVPR2022）
*Penulis: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

Makalah ini diusulkan untuk mencapai transfer gaya gambar yang tidak bias berdasarkan model transformer. Kami dapat meningkatkan efek stilisasi dibandingkan dengan metode state-of-the-art.
Repositori ini adalah implementasi resmi dari [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## Presentasi Hasil 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
Dibandingkan dengan beberapa algoritma state-of-the-art, metode kami memiliki kemampuan yang kuat untuk menghindari kebocoran konten dan memiliki kemampuan representasi fitur yang lebih baik.  <br>


## Kerangka Kerja
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
Alur kerja keseluruhan dari kerangka StyTr^2 kami. Kami membagi gambar konten dan gaya menjadi patch, dan menggunakan proyeksi linier untuk memperoleh urutan gambar. Kemudian urutan konten yang telah ditambahkan CAPE dimasukkan ke dalam encoder transformer konten, sementara urutan gaya dimasukkan ke dalam encoder transformer gaya. Setelah kedua encoder transformer, digunakan decoder transformer multi-layer untuk menstilasi urutan konten sesuai dengan urutan gaya. Akhirnya, kami menggunakan decoder upsampling progresif untuk memperoleh gambar yang telah distilisasi dengan resolusi tinggi.



## Eksperimen
### Persyaratan
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Pengujian 
Model pra-latih: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Silakan unduh dan letakkan ke dalam folder ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Pelatihan  
Dataset gaya adalah WikiArt yang diambil dari [WIKIART](https://www.wikiart.org/)  <br>  
Dataset konten adalah COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Referensi
Jika Anda merasa pekerjaan kami bermanfaat untuk penelitian Anda, silakan sitasi makalah kami menggunakan entri BibTeX berikut ~ Terima kasih ^ . ^. Tautan Paper [pdf](https://arxiv.org/abs/2105.14576)<br> 
```
@inproceedings{deng2021stytr2,
      title={StyTr^2: Image Style Transfer with Transformers}, 
      author={Yingying Deng and Fan Tang and Weiming Dong and Chongyang Ma and Xingjia Pan and Lei Wang and Changsheng Xu},
      booktitle={IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
      year={2022},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---