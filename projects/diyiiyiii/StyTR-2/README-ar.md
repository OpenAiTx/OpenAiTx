# StyTr^2 : نقل نمط الصورة باستخدام المحولات (CVPR2022)
*المؤلفون: [Yingying Deng](https://diyiiyiii.github.io/)، Fan Tang، XingjiaPan، Weiming Dong، Chongyang Ma، Changsheng Xu*

تم اقتراح هذه الورقة لتحقيق نقل نمط الصورة بدون تحيز بالاعتماد على نموذج المحول. يمكننا تعزيز تأثير التأنق مقارنةً بأحدث الطرق.
هذا المستودع هو التنفيذ الرسمي لـ [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## عرض النتائج
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
مقارنةً ببعض الخوارزميات المتقدمة، يتمتع أسلوبنا بقدرة قوية على تجنب تسرب المحتوى ويمتلك قدرة تمثيل ميزات أفضل.  <br>


## الإطار العام
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
المسار العام لإطار عمل StyTr^2 الخاص بنا. نقوم بتقسيم صور المحتوى والنمط إلى قطع، ونستخدم إسقاطًا خطيًا للحصول على تسلسلات الصور. ثم تُغذى تسلسلات المحتوى المضافة إليها CAPE إلى مشفر محول المحتوى، بينما تُغذى تسلسلات النمط إلى مشفر محول النمط. بعد مشفري المحول، يُعتمد مفكك ترميز متعدد الطبقات لتغيير نمط تسلسلات المحتوى وفقًا لتسلسلات النمط. أخيرًا، نستخدم مفكك ترميز تصعيدي تدريجي للحصول على الصور ذات النمط بدقة عالية.



## التجربة
### المتطلبات
* python 3.6
* pytorch 1.4.0
* PIL، numpy، scipy
* tqdm  <br> 

### الاختبار
نماذج مدربة مسبقًا: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing)،  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing)، [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing)، [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
يرجى تنزيلها ووضعها في المجلد ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### التدريب  
مجموعة بيانات الأنماط هي WikiArt تم جمعها من [WIKIART](https://www.wikiart.org/)  <br>  
مجموعة بيانات المحتوى هي COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### المرجع
إذا وجدت أن عملنا مفيد في بحثك، يرجى الاستشهاد بورقتنا باستخدام إدخال BibTeX التالي ~ شكرًا لك ^ . ^. رابط الورقة [pdf](https://arxiv.org/abs/2105.14576)<br> 
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