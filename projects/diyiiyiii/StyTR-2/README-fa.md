# StyTr^2 : انتقال سبک تصویر با ترنسفورمرها (CVPR2022)
*نویسندگان: [Yingying Deng](https://diyiiyiii.github.io/)، Fan Tang، XingjiaPan، Weiming Dong، Chongyang Ma، Changsheng Xu*

این مقاله به منظور دستیابی به انتقال سبک تصویر بدون سوگیری بر اساس مدل ترنسفورمر ارائه شده است. ما می‌توانیم اثر استیلیزاسیون را نسبت به روش‌های پیشرفته موجود بهبود بخشیم.
این مخزن پیاده‌سازی رسمی [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576) است.

## ارائه نتایج 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
در مقایسه با برخی الگوریتم‌های پیشرفته، روش ما توانایی قوی در جلوگیری از نشت محتوا داشته و قابلیت نمایش ویژگی بهتری دارد.  <br>

## چارچوب
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
خط لوله کلی چارچوب StyTr^2 ما. ما تصاویر محتوا و سبک را به پچ‌هایی تقسیم می‌کنیم و از پروجکشن خطی برای به‌دست‌آوردن توالی‌های تصویری استفاده می‌کنیم. سپس توالی‌های محتوا به همراه CAPE به انکودر ترنسفورمر محتوا داده می‌شوند، در حالی که توالی‌های سبک به انکودر ترنسفورمر سبک داده می‌شوند. پس از دو انکودر ترنسفورمر، یک دیکودر ترنسفورمر چندلایه برای استیلیزاسیون توالی‌های محتوا طبق توالی‌های سبک به کار می‌رود. در نهایت، از یک دیکودر آپ‌سمپلینگ تدریجی برای به‌دست‌آوردن تصاویر استیلیزه‌شده با وضوح بالا استفاده می‌کنیم.

## آزمایش
### پیش‌نیازها
* python 3.6
* pytorch 1.4.0
* PIL، numpy، scipy
* tqdm  <br> 

### تست  
مدل‌های از پیش آموزش‌دیده: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing)،  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing)، [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing)، [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
لطفاً آن‌ها را دانلود کرده و در پوشه  ./experiments/  قرار دهید.  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### آموزش  
دیتاست سبک WikiArt است که از [WIKIART](https://www.wikiart.org/) جمع‌آوری شده است.  <br>  
دیتاست محتوا COCO2014 است.  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### رفرنس
اگر کار ما برای تحقیقات شما مفید بود، لطفاً مقاله ما را با ورودی BibTeX زیر ارجاع دهید ~ متشکرم ^ . ^. لینک مقاله [pdf](https://arxiv.org/abs/2105.14576)<br> 
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