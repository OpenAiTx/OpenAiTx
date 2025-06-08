![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/title.png)

## ชุดข้อมูล
> 📦 **[👉 เข้าถึงชุดข้อมูล ChartGalaxy ฉบับเต็มบน Hugging Face! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

เนื่องจากข้อจำกัดด้านพื้นที่จัดเก็บ เรารวมเฉพาะตัวอย่างที่เป็นตัวแทนไว้เท่านั้น  
ที่เก็บนี้มีโค้ดที่เกี่ยวข้องกับบทความ "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation"

## 🔥 ข่าวสาร
**2025.5**:  🎉🎉 เราได้ปล่อยชุดข้อมูลเวอร์ชันแรก ซึ่งประกอบด้วยอินโฟกราฟิกชาร์ตสังเคราะห์ 1,151,087 รายการ และชาร์ตจริง 104,519 รายการ ครอบคลุม 75 ประเภทชาร์ตและ 330 รูปแบบย่อย

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/main/examples.png)

<!-- ## 🔔 News -->

## บทนำ

### เกี่ยวกับ

ChartGalaxy คือชุดข้อมูลอินโฟกราฟิกชาร์ตขนาดหลักล้านทั้งแบบสังเคราะห์และของจริงพร้อมตารางข้อมูล รองรับแอปพลิเคชันด้านความเข้าใจอินโฟกราฟิกชาร์ต การสร้างโค้ด และการสร้างชาร์ต ชุดข้อมูลนี้แก้ไขปัญหาที่ชุดข้อมูลเดิมส่วนใหญ่จำกัดอยู่แค่ชาร์ตธรรมดา ไม่สามารถสะท้อนรูปแบบการออกแบบและเลย์เอาต์ที่หลากหลายซึ่งเป็นลักษณะสำคัญของอินโฟกราฟิกชาร์ตได้

### สถิติ

- **ขนาด**: อินโฟกราฟิกชาร์ต 1,255,606 รายการ (สังเคราะห์ 1,151,087 + จริง 104,519)
- **เนื้อหา**: อินโฟกราฟิกชาร์ตแต่ละรายการจับคู่กับตารางข้อมูลที่ใช้สร้างชาร์ต
- **ประเภทชาร์ต**: 75 ประเภทชาร์ต พร้อม 330 รูปแบบย่อย
- **เทมเพลตเลย์เอาต์**: 68 เทมเพลตเลย์เอาต์

### การเก็บรวมรวมและสร้างข้อมูล

ChartGalaxy ถูกสร้างขึ้นผ่าน:

1. **การเก็บรวมรวมอินโฟกราฟิกชาร์ตจริง**: รวบรวมชาร์ตจาก 19 เว็บไซต์ชั้นนำที่มีชาร์ตจำนวนมาก เช่น Pinterest, Visual Capitalist, Statista และ Information is Beautiful

2. **การสร้างอินโฟกราฟิกชาร์ตสังเคราะห์**: โดยกระบวนการโครงสร้างแบบอุปนัยซึ่ง  
   - ระบุ 75 ประเภทชาร์ต (เช่น Bar Chart) และ 330 รูปแบบย่อยที่สะท้อนสไตล์ขององค์ประกอบภาพที่แตกต่างกัน
   - สกัด 68 เทมเพลตเลย์เอาต์ที่กำหนดความสัมพันธ์เชิงพื้นที่ระหว่างองค์ประกอบ
   - สร้างชาร์ตสังเคราะห์แบบโปรแกรมตามรูปแบบเหล่านี้

## 🎯 การใช้งาน

ประโยชน์ของ ChartGalaxy แสดงผ่านการใช้งานตัวอย่าง 3 ประเภท:

### 1. 🧠 ความเข้าใจอินโฟกราฟิกชาร์ต

การปรับจูนโมเดลพื้นฐานด้วย ChartGalaxy ช่วยเพิ่มประสิทธิภาพในการเข้าใจอินโฟกราฟิกชาร์ต

### 2. 💻 การสร้างโค้ดอินโฟกราฟิกชาร์ต

เป็น Benchmark สำหรับประเมินความสามารถของ LVLMs ในการสร้างโค้ดสำหรับอินโฟกราฟิกชาร์ต โดยประเมินความคล้ายคลึงระหว่างชาร์ตที่เรนเดอร์ด้วยโค้ด D3.js ที่สร้างขึ้นกับชาร์ตจริงใน 2 ระดับ ได้แก่ ระดับสูง (ความคล้ายคลึงภาพรวม) และระดับต่ำ (ความคล้ายคลึงโดยเฉลี่ยขององค์ประกอบ SVG ย่อย)

#### ภาพรวม

Benchmark นี้ประเมินการสร้างโค้ดชาร์ตใน 2 ระดับ:
- **ระดับต่ำ**: ความคล้ายคลึงขององค์ประกอบระหว่าง SVG ที่สร้างขึ้นและ SVG อ้างอิง
- **ระดับสูง**: การประเมินความสมจริงและการทำงานโดยรวม

#### การติดตั้ง

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### การใช้งาน

1. ตั้งค่าคอนฟิกใน `code_generation_benchmark/configs/default_config.yaml`:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # Uncomment the models you want to evaluate
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. รัน benchmark:
   ```bash
   python main.py
   ```

#### โครงสร้างข้อมูล

แต่ละโฟลเดอร์ชาร์ตใน `data_root_dir` ควรมี:
- `chart.svg`: ชาร์ตต้นฉบับในรูปแบบ SVG

ระบบจะสร้างไฟล์ดังนี้:
- `convert_chart.html`: การแสดงผลชาร์ตอ้างอิงแบบ HTML
- `convert_chart.png`: ภาพหน้าจอของชาร์ตอ้างอิงแบบ PNG
- `convert_chart.json`: โครงสร้างองค์ประกอบของชาร์ตอ้างอิง
- ผลลัพธ์เฉพาะโมเดลในโฟลเดอร์ย่อย

#### ผลลัพธ์

ผลลัพธ์จะถูกจัดเก็บในโฟลเดอร์ย่อยของแต่ละโมเดล ประกอบด้วย:
- ไฟล์ HTML/PNG ที่สร้างขึ้น
- ค่าประเมินผลในรูปแบบ JSON
- รายละเอียด log ใน `log_dir`
  

### 3. 🖼️ การสร้างอินโฟกราฟิกชาร์ตจากตัวอย่าง

เป็นวิธีสร้างชาร์ตตามตัวอย่าง โดยแปลงตารางข้อมูลที่ผู้ใช้ให้มาให้เป็นอินโฟกราฟิกชาร์ตที่มีเลย์เอาต์และสไตล์ภาพสอดคล้องกับชาร์ตตัวอย่าง งานศึกษาผู้ใช้พบว่าวิธีนี้มีประสิทธิภาพดีกว่า GPT-Image-1 ในด้านความตรง, ความสวยงาม และความคิดสร้างสรรค์


## ติดต่อ
- chartgalaxy@163.com

## ลิงก์บทความ

### 📌 บทความหลัก (ที่เก็บนี้)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### บทความที่เกี่ยวข้อง

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 การอ้างอิง
หากคุณใช้ ChartGalaxy ในการวิจัย กรุณาอ้างอิงดังนี้:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---