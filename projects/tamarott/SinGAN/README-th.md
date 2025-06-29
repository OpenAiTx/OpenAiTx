# SinGAN

[โครงการ](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [เอกสารเสริม](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Talk (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### โค้ดอย่างเป็นทางการของ pytorch สำหรับบทความ: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### รางวัลบทความยอดเยี่ยม ICCV 2019 (Marr prize)


## ตัวอย่างสุ่มจาก *ภาพเดียว*
ด้วย SinGAN คุณสามารถฝึกโมเดลสร้างภาพจากภาพธรรมชาติภาพเดียว และสามารถสร้างตัวอย่างสุ่มจากภาพนั้น เช่น:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## การประยุกต์ใช้งานของ SinGAN
SinGAN ยังสามารถนำไปใช้กับงานปรับแต่งภาพหลายประเภท เช่น:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
โดยการแทรกภาพเข้าไปในโมเดลที่ผ่านการฝึกแล้ว ดูรายละเอียดเพิ่มเติมในหัวข้อที่ 4 ของ [บทความของเรา](https://arxiv.org/pdf/1905.01164.pdf)


### การอ้างอิง
หากคุณใช้โค้ดนี้ในงานวิจัย กรุณาอ้างอิงบทความของเรา:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## โค้ด

### ติดตั้ง dependencies

```
python -m pip install -r requirements.txt
```

โค้ดนี้ผ่านการทดสอบกับ python 3.6, torch 1.4

โปรดทราบ: โค้ดนี้รองรับเฉพาะ torch 1.4 หรือเก่ากว่า เนื่องจากวิธีการปรับแต่งประสิทธิภาพ

สำหรับ torch เวอร์ชันใหม่กว่า คุณสามารถลองใช้ repository นี้: https://github.com/kligvasser/SinGAN (ผลลัพธ์อาจไม่เหมือนกับ implementation อย่างเป็นทางการ)


###  ฝึกโมเดล
หากต้องการฝึกโมเดล SinGAN กับภาพของคุณเอง ให้วางภาพสำหรับฝึกไว้ในโฟลเดอร์ Input/Images แล้วรัน

```
python main_train.py --input_name <input_file_name>
```

การดำเนินการนี้จะใช้โมเดลที่ฝึกเสร็จแล้วเพื่อสร้างตัวอย่างสุ่มโดยเริ่มจากสเกลที่หยาบที่สุด (n=0)

หากต้องการรันโค้ดนี้บนเครื่อง cpu ให้ระบุ `--not_cuda` ขณะเรียกใช้ `main_train.py`

###  ตัวอย่างสุ่ม
หากต้องการสร้างตัวอย่างสุ่มจากสเกลของการสร้างใดๆ กรุณาฝึกโมเดล SinGAN กับภาพที่ต้องการ (ตามที่อธิบายข้างต้น) แล้วรัน

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

โปรดสังเกต: หากต้องการใช้โมเดลเต็ม ให้ตั้งค่าสเกลเริ่มต้นเป็น 0 หากต้องการเริ่มสร้างจากสเกลที่สอง ให้ตั้งเป็น 1 และอื่นๆ 

###  ตัวอย่างสุ่มขนาดใดก็ได้
หากต้องการสร้างตัวอย่างสุ่มที่มีขนาดตามต้องการ กรุณาฝึกโมเดล SinGAN กับภาพที่ต้องการ (ตามที่อธิบายข้างต้น) แล้วรัน

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

###  สร้างแอนิเมชันจากภาพเดียว

หากต้องการสร้างแอนิเมชันสั้นจากภาพเดียว ให้รัน

```
python animation.py --input_name <input_file_name> 
```

ระบบจะเริ่มการฝึกใหม่โดยใช้โหมด noise padding โดยอัตโนมัติ

###  การปรับกลมกลืน (Harmonization)

หากต้องการปรับกลมกลืนวัตถุที่วางแทรกลงในภาพ (ดูตัวอย่างในรูปที่ 13 ใน [บทความของเรา](https://arxiv.org/pdf/1905.01164.pdf)) กรุณาฝึกโมเดล SinGAN กับภาพพื้นหลังที่ต้องการ (ตามที่อธิบายข้างต้น) จากนั้นบันทึกภาพอ้างอิงที่วางวัตถุอย่างง่ายและ binary mask ไว้ใน "Input/Harmonization" (ดูตัวอย่างจากไฟล์ที่บันทึกไว้) รันคำสั่ง

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

โปรดทราบว่าสเกลการแทรกที่แตกต่างจะให้ผลลัพธ์การปรับกลมกลืนที่แตกต่างกัน สเกลการแทรกที่หยาบที่สุดคือ 1

###  การแก้ไข (Editing)

หากต้องการแก้ไขภาพ (ดูตัวอย่างในรูปที่ 12 ใน [บทความของเรา](https://arxiv.org/pdf/1905.01164.pdf)) กรุณาฝึกโมเดล SinGAN กับภาพที่ยังไม่ได้แก้ไข (ตามที่อธิบายข้างต้น) จากนั้นบันทึกภาพที่แก้ไขแบบง่ายเป็น reference ไว้ใน "Input/Editing" พร้อม binary map ที่เกี่ยวข้อง (ดูตัวอย่างจากไฟล์ที่บันทึกไว้) รันคำสั่ง

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
ทั้งผลลัพธ์แบบมีการปิดบังและไม่มีการปิดบังจะถูกบันทึกไว้
ในที่นี้เช่นกัน การเลือก scale ของการฉีดที่ต่างกันจะทำให้เกิดผลการแก้ไขที่แตกต่างกัน โดย scale ของการฉีดที่หยาบที่สุดมีค่าเท่ากับ 1

###  Paint to Image

เพื่อแปลงภาพวาดให้เป็นภาพสมจริง (ดูตัวอย่างในรูปที่ 11 ใน [บทความของเรา](https://arxiv.org/pdf/1905.01164.pdf)) กรุณาฝึก SinGAN model กับภาพที่ต้องการ (ตามที่อธิบายไว้ข้างต้น) จากนั้นบันทึกภาพวาดของคุณไว้ที่ "Input/Paint" และรันคำสั่ง

```
python paint2image.py --input_name <training_image_file_name> --ref_name <paint_image_file_name> --paint_start_scale <scale to inject>

```
ในที่นี้เช่นกัน การเลือก scale ของการฉีดที่ต่างกันจะทำให้เกิดผลการแก้ไขที่แตกต่างกัน โดย scale ของการฉีดที่หยาบที่สุดมีค่าเท่ากับ 1

ตัวเลือกขั้นสูง: ระบุ quantization_flag ให้เป็น True เพื่อฝึก *เฉพาะ* ระดับการฉีดของโมเดลใหม่ เพื่อให้ได้ภาพที่สร้างแบบ upsampled จาก scale ก่อนหน้าในเวอร์ชันที่ถูก quantize สี สำหรับบางภาพ อาจให้ผลลัพธ์ที่สมจริงมากขึ้น

### Super Resolution
เพื่อขยายความละเอียดภาพ กรุณารัน:
```
python SR.py --input_name <LR_image_file_name>
```
ระบบจะฝึก SinGAN model สำหรับ factor การ upsampling 4x โดยอัตโนมัติ (หากยังไม่มีอยู่แล้ว)
สำหรับ factor SR ที่ต่างกัน กรุณาระบุโดยใช้พารามิเตอร์ `--sr_factor` เมื่อเรียกฟังก์ชัน
ผลลัพธ์ของ SinGAN บนชุดข้อมูล BSD100 สามารถดาวน์โหลดได้จากโฟลเดอร์ 'Downloads'

## ข้อมูลและฟังก์ชันเพิ่มเติม

### Single Image Fréchet Inception Distance (SIFID score)
เพื่อคำนวณ SIFID ระหว่างภาพจริงและตัวอย่างปลอมที่เกี่ยวข้อง กรุณารัน:
```
python SIFID/sifid_score.py --path2real <real images path> --path2fake <fake images path> 
```  
โปรดตรวจสอบให้แน่ใจว่าชื่อไฟล์ของภาพปลอมแต่ละไฟล์เหมือนกับชื่อไฟล์ของภาพจริงที่เกี่ยวข้อง ภาพควรบันทึกในรูปแบบ `.jpg`

### ผลลัพธ์ Super Resolution
ผลลัพธ์ SR ของ SinGAN บนชุดข้อมูล BSD100 สามารถดาวน์โหลดได้จากโฟลเดอร์ 'Downloads'

### การศึกษาผู้ใช้ (User Study)
ข้อมูลที่ใช้ในการศึกษาผู้ใช้สามารถพบได้ในโฟลเดอร์ Downloads

real folder: ภาพจริง 50 ภาพ เลือกแบบสุ่มจาก [places database](http://places.csail.mit.edu/)

fake_high_variance folder: ตัวอย่างสุ่มที่เริ่มต้นจาก n=N สำหรับแต่ละภาพจริง

fake_mid_variance folder: ตัวอย่างสุ่มที่เริ่มต้นจาก n=N-1 สำหรับแต่ละภาพจริง

สำหรับรายละเอียดเพิ่มเติมโปรดดูที่หัวข้อ 3.1 ใน [บทความของเรา](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---