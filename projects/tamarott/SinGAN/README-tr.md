# SinGAN

[Proje](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [Ek materyaller](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Konuşma (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### Makalenin resmi pytorch uygulaması: "SinGAN: Tek Bir Doğal Görüntüden Üretken Model Öğrenimi"
#### ICCV 2019 En İyi Makale Ödülü (Marr ödülü)


## *Tek bir* görüntüden rastgele örnekler
SinGAN ile, tek bir doğal görüntüden üretken bir model eğitebilir ve ardından verilen görüntüden rastgele örnekler oluşturabilirsiniz, örneğin:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## SinGAN'ın uygulamaları
SinGAN ayrıca bir dizi görüntü manipülasyon görevi için de kullanılabilir, örneğin:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
Bu, görüntünün önceden eğitilmiş modele enjekte edilmesiyle yapılır. Daha fazla ayrıntı için makalemizin [bölüm 4](https://arxiv.org/pdf/1905.01164.pdf)'üne bakınız.


### Atıf
Bu kodu araştırmanızda kullanırsanız, lütfen makalemize atıfta bulunun:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## Kod

### Bağımlılıkları yükleyin

```
python -m pip install -r requirements.txt
```

Bu kod python 3.6, torch 1.4 ile test edilmiştir.

Lütfen dikkat: Kod şu anda yalnızca torch 1.4 veya daha önceki sürümleri desteklemektedir, bunun nedeni optimizasyon şemasıdır.

Daha yeni torch sürümleri için şu depoyu deneyebilirsiniz: https://github.com/kligvasser/SinGAN (sonuçlar resmi uygulamayla birebir aynı olmayabilir).


###  Eğitim
SinGAN modelini kendi görüntünüzde eğitmek için, istediğiniz eğitim görüntüsünü Input/Images klasörüne koyun ve şunu çalıştırın:

```
python main_train.py --input_name <input_file_name>
```

Bu, ayrıca en kaba ölçekten (n=0) başlayarak rastgele örnekler üretmek için eğitilen modeli kullanacaktır.

Bu kodu bir cpu makinede çalıştırmak için, `main_train.py` çağrılırken `--not_cuda` belirtin.

###  Rastgele örnekler
Herhangi bir başlangıç üretim ölçeğinden rastgele örnekler oluşturmak için, lütfen önce SinGAN modelini istenen görüntüde eğitin (yukarıda açıklandığı gibi), ardından şunu çalıştırın:

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

dikkat: tam modeli kullanmak için, üretim başlangıç ölçeğini 0 olarak belirtin, üretime ikinci ölçekten başlamak için 1 olarak belirtin, vb.

###  İsteğe bağlı boyutlarda rastgele örnekler
İsteğe bağlı boyutlarda rastgele örnekler oluşturmak için, lütfen önce SinGAN modelini istenen görüntüde eğitin (yukarıda açıklandığı gibi), ardından şunu çalıştırın:

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <yatay ölçekleme faktörü> --scale_v <dikey ölçekleme faktörü>
```

###  Tek bir görüntüden animasyon

Tek bir görüntüden kısa bir animasyon oluşturmak için şunu çalıştırın:

```
python animation.py --input_name <input_file_name> 
```

Bu, otomatik olarak gürültü dolgulu yeni bir eğitim aşaması başlatacaktır.

###  Harmanlama

Bir görsele yapıştırılmış bir nesneyi görüntüye uyumlu hale getirmek için (örnek için bkz. Şekil 13 [makalemizde](https://arxiv.org/pdf/1905.01164.pdf)), lütfen önce SinGAN modelini istenen arka plan görüntüsünde eğitin (yukarıda açıklandığı gibi), ardından referans olarak kaba şekilde yapıştırılmış görüntüyü ve onun ikili maskesini "Input/Harmonization" altına kaydedin (örnek için kaydedilmiş görüntülere bakınız). Komutu çalıştırın:

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <ölçek enjekte edilecek>

```

Farklı enjeksiyon ölçeklerinin farklı harmanlama etkileri oluşturacağını lütfen unutmayın. En kaba enjeksiyon ölçeği 1'e eşittir.

###  Düzenleme

Bir görüntüyü düzenlemek için (örnek için bkz. Şekil 12 [makalemizde](https://arxiv.org/pdf/1905.01164.pdf)), lütfen önce SinGAN modelini istenen düzenlenmemiş görüntüde eğitin (yukarıda açıklandığı gibi), ardından kaba düzenlemeyi referans görüntü olarak "Input/Editing" altına ilgili bir ikili harita ile kaydedin (örnek için kaydedilmiş görüntülere bakınız). Komutu çalıştırın:

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <ölçek enjekte edilecek>
```
hem maskelenmiş hem de maskelenmemiş çıktı kaydedilecektir.
Burada da, farklı enjeksiyon ölçekleri farklı düzenleme efektleri üretecektir. En kaba enjeksiyon ölçeği 1'e eşittir.

###  Resme Boyama

Bir boyamayı gerçekçi bir görüntüye aktarmak için (Bkz. Şekil 11, [makalemizde](https://arxiv.org/pdf/1905.01164.pdf)), lütfen önce istenen görüntü üzerinde SinGAN modelini eğitin (yukarıda açıklandığı gibi), ardından boyamanızı "Input/Paint" altında kaydedin ve şu komutu çalıştırın:

```
python paint2image.py --input_name <training_image_file_name> --ref_name <paint_image_file_name> --paint_start_scale <scale to inject>
```
Burada da, farklı enjeksiyon ölçekleri farklı düzenleme efektleri üretecektir. En kaba enjeksiyon ölçeği 1'e eşittir.

Gelişmiş seçenek: quantization_flag parametresini True olarak belirtin, böylece modelin *yalnızca* enjeksiyon seviyesini, bir önceki ölçekten yukarı örneklenen oluşturulmuş görüntülerin renk-kuantalize edilmiş bir versiyonu üzerinde yeniden eğitebilirsiniz. Bazı görüntüler için, bu daha gerçekçi sonuçlara yol açabilir.

### Süper Çözünürlük
Bir görüntüyü süper çözünürlüklü yapmak için, lütfen şu komutu çalıştırın:
```
python SR.py --input_name <LR_image_file_name>
```
Bu, otomatik olarak 4x yükseltme faktörüne karşılık gelen bir SinGAN modeli eğitecektir (eğer zaten mevcut değilse).
Farklı SR faktörleri için, fonksiyonu çağırırken `--sr_factor` parametresini kullanarak belirtebilirsiniz.
SinGAN'ın BSD100 veri seti üzerindeki sonuçları 'Downloads' klasöründen indirilebilir.

## Ek Veri ve Fonksiyonlar

### Tek Görüntü Fréchet Inception Distance (SIFID skoru)
Gerçek görüntüler ile karşılık gelen sahte örnekleri arasındaki SIFID'i hesaplamak için, lütfen şu komutu çalıştırın:
```
python SIFID/sifid_score.py --path2real <real images path> --path2fake <fake images path> 
```  
Her sahte görüntü dosya adının, karşılık gelen gerçek görüntü dosya adı ile aynı olduğundan emin olun. Görüntüler `.jpg` formatında kaydedilmelidir.

### Süper Çözünürlük Sonuçları
SinGAN'ın BSD100 veri seti üzerindeki SR sonuçları 'Downloads' klasöründen indirilebilir.

### Kullanıcı Çalışması
Kullanıcı çalışması için kullanılan veriler Downloads klasöründe bulunabilir.

real klasörü: [places veritabanından](http://places.csail.mit.edu/) rastgele seçilmiş 50 gerçek görüntü

fake_high_variance klasörü: her gerçek görüntü için n=N'den başlayarak üretilmiş rastgele örnekler

fake_mid_variance klasörü: her gerçek görüntü için n=N-1'den başlayarak üretilmiş rastgele örnekler

Ek ayrıntılar için lütfen [makalemizin](https://arxiv.org/pdf/1905.01164.pdf) 3.1 bölümüne bakınız.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---