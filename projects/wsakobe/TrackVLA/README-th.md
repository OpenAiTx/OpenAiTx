<p align="center">
<h1 align="center"><strong>TrackVLA: การติดตามภาพเชิงร่างกายแบบอิงสิ่งแวดล้อมในสภาพแวดล้อมจริง</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>Shaoan Wang</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>Jiazhao Zhang</a>&emsp;
    Minghan Li&emsp;
    Jiahang Liu&emsp;
    Anqi Li&emsp; <br>
    Kui Wu&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>Fangwei Zhong</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>Junzhi Yu</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>Zhizheng Zhang</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>He Wang</a>&emsp;
    <br>
    มหาวิทยาลัยปักกิ่ง&emsp; 
    Galbot&emsp; <br>
    มหาวิทยาลัย Beihang&emsp;
    มหาวิทยาลัยครูปักกิ่ง&emsp;
    สถาบันปัญญาประดิษฐ์ปักกิ่ง&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Project](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Video](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 เกี่ยวกับ
<strong><em>TrackVLA</em></strong> คือโมเดลวิสัยทัศน์-ภาษา-การกระทำที่สามารถจดจำวัตถุและติดตามภาพได้พร้อมกัน โดยผ่านการฝึกบนชุดข้อมูลจำนวน 1.7 ล้านตัวอย่าง โมเดลนี้แสดงศักยภาพในการติดตามที่แข็งแกร่ง การติดตามระยะยาว และการทั่วไปข้ามโดเมนในสภาพแวดล้อมที่ท้าทายหลากหลายรูปแบบ
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 ข่าวสาร

* [25/07/02]: ขณะนี้ EVT-Bench พร้อมให้ใช้งานแล้ว

## 💡 การติดตั้ง
1. **เตรียมสภาพแวดล้อม conda**

   ก่อนอื่น คุณต้องติดตั้ง [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/) เมื่อทำการติดตั้ง conda แล้ว ให้สร้างสภาพแวดล้อมใหม่:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **ติดตั้ง habitat-sim ด้วย conda**
   
   คุณต้องติดตั้ง habitat-sim เวอร์ชัน 0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **ติดตั้ง habitat-lab จากซอร์ส**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **เตรียมชุดข้อมูล**

    ดาวน์โหลดชุดข้อมูล Habitat Matterport 3D (HM3D) จาก [ที่นี่](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) และ Matterport3D (MP3D) จาก [ที่นี่](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset)

    จากนั้นให้ย้ายชุดข้อมูลไปไว้ที่ `data/scene_datasets` โครงสร้างของชุดข้อมูลมีดังนี้:
    ```
    data/
     └── scene_datasets/
        ├── hm3d/
        │ ├── train/
        │ │   └── ...
        │ ├── val/
        │ │   └── ...
        │ └── minival
        │     └── ...
        └── mp3d/
          ├── 1LXtFkjw3qL
          │   └── ...
          └── ...
    ```

    ต่อไป ให้รันโค้ดดังต่อไปนี้เพื่อรับข้อมูลสำหรับอวาตาร์มนุษย์:
      ```
      python download_humanoid_data.py
      ```


## 🧪 การประเมินผล
  รันสคริปต์ด้วยคำสั่ง:

    bash eval.sh

  ผลลัพธ์จะถูกบันทึกไว้ใน SAVE_PATH ที่กำหนด ซึ่งจะมีโฟลเดอร์ log และโฟลเดอร์วิดีโอ หากต้องการติดตามผลลัพธ์ระหว่างกระบวนการประเมินผล ให้รัน:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  หากต้องการหยุดการประเมินผล ให้ใช้:

    bash kill_eval.sh


## 📝 รายการที่ต้องทำ (TODO List)
- [x] เผยแพร่บทความ arXiv ในเดือนพฤษภาคม 2025
- [x] เผยแพร่ EVT-Bench (Embodied Visual Tracking Benchmark)
- [ ] เผยแพร่ชุดข้อมูล embodied visual tracking ขนาดใหญ่
- [ ] เผยแพร่ checkpoint และโค้ดของ TrackVLA

## ✉️ ติดต่อ
หากมีคำถามใด ๆ กรุณาส่งอีเมลมาที่ wangshaoan@stu.pku.edu.cn เราจะตอบกลับโดยเร็วที่สุด


## 🔗 การอ้างอิง
หากผลงานของเรามีประโยชน์ กรุณาอ้างอิงดังนี้:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 ใบอนุญาต (License)
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
ผลงานนี้อยู่ภายใต้ <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">สัญญาอนุญาต Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a>.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---