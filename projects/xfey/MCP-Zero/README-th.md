## MCP-Zero: การค้นหาเครื่องมืออย่างแอคทีฟสำหรับตัวแทน LLM อัตโนมัติ

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


ขอบคุณสำหรับความสนใจใน MCP-Zero! 🤗

ขณะนี้เราได้เปิดซอร์สโค้ดที่ใช้ในงานวิจัยนี้แล้ว เราจะดำเนินการอัปเดตผลงานของเราต่อไป สำรวจการนำไปใช้ในอุตสาหกรรม และขยายโปรเจคนี้อย่างต่อเนื่อง


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p> การใช้ MCP-Zero เพื่อสร้างชุดเครื่องมือสำหรับ "การทำอาหารมื้อเยี่ยม" อย่างเชิงรุก</p>
</div>


### วิธีการ: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # การทดลอง: APIBank
├── experiment_mcptools.py      # การทดลอง: mcp_tools (needle test)
├── matcher.py                  # โค้ดสำหรับการจับคู่ความคล้ายคลึง
├── prompt_guide/               # พรอมต์สำหรับวิธีการของเรา
├── reformatter.py              # ตัวจัดรูปแบบ json สำหรับคำอธิบายเครื่องมือ
├── sampler.py                  # ตัวสุ่มเลือกเครื่องมือเป้าหมาย
├── test_cases.jsonl            # เคสทดสอบสำหรับ matcher
├── test_matcher.py             # unit test สำหรับ matcher
└── utils.py                    # utils: grid_search
```

ขณะนี้เราได้ปล่อยซอร์สโค้ดสำหรับงานวิจัยนี้แล้ว โค้ดในบทความนี้ได้ติดตั้งความสามารถในการค้นคืนข้อมูลและสามารถสร้างผลลัพธ์ที่เป็นรูปธรรมจากการทดลอง

ในงานต่อไปของเรา เราตั้งใจจะนำ MCP-zero ไปประยุกต์ใช้ในอุตสาหกรรม ดังนั้นโมดูลอื่น ๆ ยังจำเป็นต้องถูกรวมเข้ามา เช่น การดีพลอยเซิร์ฟเวอร์ MCP แบบไดนามิก การติดตั้งสภาพแวดล้อมสำหรับ GAIA test ฯลฯ เราจะปรับปรุงผลงานของเราต่อไป และขอขอบคุณทุกท่านที่ติดตามผลงานนี้ กดดาว🌟 เพื่อให้เรารู้ว่าคุณกำลังติดตามข่าวสาร :D



### ชุดข้อมูล: MCP-tools

- **Google Drive**: [ลิงก์ดาวน์โหลด](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **Huggingface Link**: เร็ว ๆ นี้
- **ให้นำไฟล์ไปไว้ที่**: `./MCP-tools/mcp_tools_with_embedding.json`


**บทนำ**: ชุดข้อมูลที่ประกอบด้วยเครื่องมือที่ผ่านการคัดกรองทั้งหมด (308 เซิร์ฟเวอร์ และ 2,797 เครื่องมือ) จาก MCP official repo

**โครงสร้างข้อมูล**:
```
{
  "server_name": string, // ชื่อของเซิร์ฟเวอร์ MCP ที่ดึงมาหรืออนุมานจาก README
  "server_summary": string, // สรุปวัตถุประสงค์และความสามารถของเซิร์ฟเวอร์ อ้างอิงจากทุกส่วนที่เกี่ยวข้องใน README
  "server_description": string, // คำอธิบายจาก metadata 
  "description_embedding": float[3072], // embedding ของคำอธิบายเซิร์ฟเวอร์จาก text-embedding-3-large
  "summary_embedding": float[3072], // embedding ของสรุปเซิร์ฟเวอร์จาก text-embedding-3-large
  "tools": [
    {
      "name": string, // ชื่อฟังก์ชัน/เครื่องมือ
      "description": string, // คำอธิบายสั้น ๆ เกี่ยวกับสิ่งที่เครื่องมือทำ
      "description_embedding": float[3072], // embedding ของคำอธิบายเครื่องมือจาก text-embedding-3-large
      "parameter": { // ดิกชันนารีของพารามิเตอร์ขาเข้า รวมเฉพาะที่ระบุไว้อย่างชัดเจน
        "param1": "(type) description1",
        "param2": "(Optional, type) description2"
      }
    }
  ]
}
```

**สร้างชุดข้อมูลด้วยตนเอง**: หากคุณต้องการสร้างชุดข้อมูลแบบ custom สำหรับ MCP servers คุณสามารถทำตามโค้ดในโฟลเดอร์ `MCP-tools/build_data`

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # โค้ดสำหรับดึงข้อมูลโครงสร้างจากไฟล์ ReadMe ของ MCP server
│   ├── run_vllm.sh                 # ดีพลอยโมเดล Qwen2.5-72B-Instruct ด้วย VLLM
│   └── server_summary.prompt       # พรอมต์สำหรับการดึงชุดข้อมูล
└── download_data.md
```


### การอ้างอิง

> การอ้างอิงทำให้ฉันมีความสุข
> 
>   --Shakespeare
>   ~~(แค่ขำ ๆ :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---