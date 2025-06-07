[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: ตัวทำนายการเข้าถึงการสังเคราะห์สารประกอบด้วยเทคโนโลยี Deep-learning

ด้วยการพัฒนาอย่างต่อเนื่องของเทคโนโลยีปัญญาประดิษฐ์ โมเดลสร้างโมเลกุลแบบ deep-generation ถูกนำมาใช้มากขึ้นเรื่อย ๆ อย่างไรก็ตาม โมเลกุลใหม่ส่วนใหญ่ที่สร้างขึ้นโดยโมเดลเหล่านี้มักเผชิญกับความท้าทายอย่างมากในเรื่องของการเข้าถึงการสังเคราะห์

DeepSA ถูกพัฒนาเพื่อตรวจสอบการเข้าถึงการสังเคราะห์ของสารประกอบ และมีอัตราการคัดกรองล่วงหน้าที่สูงกว่ามากในการจำแนกโมเลกุลที่สังเคราะห์ได้ยาก ซึ่งช่วยให้ผู้ใช้งานสามารถเลือกโมเลกุลที่มีต้นทุนต่ำกว่าสำหรับการสังเคราะห์ ส่งผลให้ลดระยะเวลาในการค้นคว้าและพัฒนายา คุณสามารถใช้งาน DeepSA ผ่านเว็บเซิร์ฟเวอร์ที่ https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## ข้อกำหนดเบื้องต้น
สามารถติดตั้ง dependencies ได้โดยใช้คำสั่งต่อไปนี้:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# สำหรับเวอร์ชัน gpu
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### ข่าวสาร 🔔 

* 2024-12, เนื่องจาก [AutoGluon หยุดสนับสนุน python version 3.8](https://github.com/autogluon/autogluon/pull/4512) ตั้งแต่เดือนตุลาคม 2024 ดังนั้น เราจึงได้ปรับปรุง DeepSA ให้ใช้ Python version 3.12 และได้อัปเดตสคริปต์สำหรับการฝึกและการทำนายเพื่อรองรับ AutoGluon เวอร์ชันล่าสุด ขอบคุณสำหรับความสนใจใน DeepSA!

* 2023-7, DeepSA_v1.0 ได้เปิดตัวแล้ว ยินดีรับฟังข้อเสนอแนะผ่าน issue!

## ข้อมูล 
ชุดข้อมูลสำหรับฝึกและทดสอบสามารถดาวน์โหลดได้ที่ https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing
## วิธีใช้งานสำหรับนักวิจัย
หากคุณต้องการฝึกโมเดลของคุณเอง สามารถรันจาก command line ได้โดย

รันคำสั่ง:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
หากคุณต้องการใช้โมเดลที่เราเสนอไว้

รันคำสั่ง:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## เซิร์ฟเวอร์ออนไลน์

เราได้ติดตั้งโมเดลที่ผ่านการฝึกไว้แล้วบนเซิร์ฟเวอร์เฉพาะ ซึ่งเปิดให้ใช้งานที่ https://bailab.siais.shanghaitech.edu.cn/deepsa เพื่อให้นักวิจัยทางชีวเวชสามารถใช้งาน DeepSA ในกิจกรรมวิจัยได้อย่างสะดวก

ผู้ใช้สามารถอัปโหลดไฟล์ SMILES หรือ csv ไปยังเซิร์ฟเวอร์ และจะได้รับผลการทำนายได้อย่างรวดเร็ว

## <span id="citelink">การอ้างอิง</span>
หากคลังนี้มีประโยชน์ต่อการวิจัยของคุณ กรุณาอ้างอิงบทความของเรา:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## ติดต่อ
หากคุณมีคำถามใด ๆ กรุณาติดต่อ Shihang Wang (Email: wangshh12022@shanghaitech.edu.cn) หรือ Lin Wang (Email: wanglin3@shanghaitech.edu.cn)

ยินดีรับ pull requests!

## คำขอบคุณ
ขอขอบคุณการสนับสนุนจาก HPC Platform มหาวิทยาลัย ShanghaiTech<br/>
ขอบคุณทุกท่านที่ให้ความสนใจในผลงานนี้

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---