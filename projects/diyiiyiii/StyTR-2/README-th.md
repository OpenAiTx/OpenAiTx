# StyTr^2 : การถ่ายโอนสไตล์ภาพด้วยทรานส์ฟอร์เมอร์ (CVPR2022)
*ผู้เขียน: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

งานวิจัยนี้ถูกนำเสนอเพื่อให้ได้การถ่ายโอนสไตล์ภาพที่เป็นกลางโดยอาศัยโมเดลทรานส์ฟอร์เมอร์ ซึ่งสามารถส่งเสริมผลลัพธ์การสไตล์ให้ดียิ่งขึ้นเมื่อเทียบกับวิธีการล้ำสมัยอื่น ๆ
ที่เก็บรหัสดังกล่าวนี้เป็นการนำเสนออย่างเป็นทางการของ [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576)

## การนำเสนอผลลัพธ์ 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
เมื่อเปรียบเทียบกับอัลกอริทึมล้ำสมัยหลายตัว วิธีของเรามีความสามารถสูงในการหลีกเลี่ยงการรั่วไหลของเนื้อหาและมีความสามารถในการแสดงคุณลักษณะที่ดีกว่า  <br>

## สถาปัตยกรรม
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
ขั้นตอนโดยรวมของเฟรมเวิร์ก StyTr^2 ของเรา เราจะแบ่งภาพเนื้อหาและภาพสไตล์ออกเป็นแพตช์ และใช้การฉายเชิงเส้นเพื่อให้ได้ลำดับของภาพ จากนั้นลำดับเนื้อหาที่เติมด้วย CAPE จะถูกป้อนเข้าสู่คอนเทนต์ทรานส์ฟอร์เมอร์เอนโคเดอร์ ขณะที่ลำดับของสไตล์จะถูกป้อนเข้าสู่สไตล์ทรานส์ฟอร์เมอร์เอนโคเดอร์ หลังจากทรานส์ฟอร์เมอร์เอนโคเดอร์ทั้งสอง จะใช้ดีโคเดอร์ทรานส์ฟอร์เมอร์หลายชั้นเพื่อทำการสไตล์ลำดับเนื้อหาตามลำดับของสไตล์ สุดท้ายเราจะใช้ดีโคเดอร์อัปแซมปลิ้งแบบค่อยเป็นค่อยไปเพื่อให้ได้ภาพที่สไตล์แล้วในความละเอียดสูง

## การทดลอง
### ข้อกำหนด
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### การทดสอบ 
โมเดลที่ฝึกไว้ล่วงหน้า: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
โปรดดาวน์โหลดไฟล์เหล่านี้และวางไว้ในโฟลเดอร์ ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### การฝึกสอน  
ชุดข้อมูลสไตล์คือ WikiArt ที่เก็บจาก [WIKIART](https://www.wikiart.org/)  <br>  
ชุดข้อมูลเนื้อหาคือ COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### การอ้างอิง
หากคุณพบว่างานของเรามีประโยชน์ต่อการวิจัยของคุณ กรุณาอ้างอิงบทความของเราตาม BibTeX ด้านล่างนี้ ~ ขอบคุณค่ะ ^ . ^. ลิงก์บทความ [pdf](https://arxiv.org/abs/2105.14576)<br> 
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