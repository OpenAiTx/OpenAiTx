
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# PPTAgent: การสร้างและประเมินงานนำเสนอที่เหนือกว่าการแปลงข้อความเป็นสไลด์
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">เอกสารวิชาการ</a> &nbsp; | &nbsp;
  🤗 <a href="https://huggingface.co/datasets/Forceless/Zenodo10K" target="_blank">ชุดข้อมูล</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">คู่มือการใช้งาน</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">การอ้างอิง</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="Ask DeepWiki"> DeepWiki</a>
</p>

เราขอนำเสนอ PPTAgent ระบบนวัตกรรมที่สร้างงานนำเสนอจากเอกสารโดยอัตโนมัติ โดยได้รับแรงบันดาลใจจากวิธีการสร้างงานนำเสนอของมนุษย์ ระบบของเราใช้กระบวนการสองขั้นเพื่อรับประกันคุณภาพโดยรวมที่ยอดเยี่ยม นอกจากนี้ เรายังนำเสนอ **PPTEval** กรอบการประเมินที่ครอบคลุมซึ่งประเมินงานนำเสนอในหลายมิติ

> [!TIP]
> 🚀 เริ่มต้นได้อย่างรวดเร็วด้วยอิมเมจ Docker ที่เตรียมไว้ล่วงหน้าของเรา - [ดูคำแนะนำ Docker](DOC.md/#docker-)

## วิดีโอสาธิต 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## คุณสมบัติเด่น ✨

- **สร้างเนื้อหาแบบไดนามิก**: สร้างสไลด์ที่ผสมผสานข้อความและรูปภาพอย่างไร้รอยต่อ
- **การเรียนรู้จากงานนำเสนออ้างอิง**: ใช้งานนำเสนอที่มีอยู่โดยไม่ต้องมีการใส่คำอธิบายประกอบด้วยตนเอง
- **การประเมินคุณภาพที่ครอบคลุม**: ประเมินงานนำเสนอผ่านตัวชี้วัดคุณภาพหลากหลายมิติ

## กรณีศึกษา 💡

- #### [Iphone 16 Pro](https://www.apple.com/iphone-16-pro/)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0006.jpg" alt="图片6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0007.jpg" alt="图片7" width="200"/>

</div>

- #### [สร้างเอเจนต์ที่มีประสิทธิภาพ](https://www.anthropic.com/research/building-effective-agents)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0006.jpg" alt="图片6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0007.jpg" alt="图片7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0008.jpg" alt="图片8" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0009.jpg" alt="图片9" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0010.jpg" alt="图片10" width="200"/>

</div>

## PPTAgent 🤖

PPTAgent ใช้วิธีการแบบสองเฟส:
1. **เฟสวิเคราะห์**: ดึงและเรียนรู้รูปแบบจากงานนำเสนอที่เป็นตัวอย่าง
2. **เฟสสร้าง**: พัฒนาโครงร่างที่มีโครงสร้างและสร้างสไลด์ที่ดูสอดคล้องกัน

ขั้นตอนการทำงานของระบบของเราแสดงอยู่ด้านล่าง:


![PPTAgent Workflow](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig2.jpg)

## PPTEval ⚖️

PPTEval ประเมินงานนำเสนอในสามมิติ:
- **เนื้อหา**: ตรวจสอบความถูกต้องและความเกี่ยวข้องของสไลด์
- **การออกแบบ**: ประเมินความน่าสนใจและความสม่ำเสมอด้านภาพ
- **ความสอดคล้อง**: ตรวจสอบความต่อเนื่องทางตรรกะของแนวคิด

ขั้นตอนการทำงานของ PPTEval แสดงอยู่ด้านล่าง:
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="PPTEval Workflow" style="width:70%;"/>
</p>


## การอ้างอิง 🙏

หากคุณพบว่าโปรเจกต์นี้มีประโยชน์ กรุณาใช้อ้างอิงดังต่อไปนี้:
```bibtex
@article{zheng2025pptagent,
  title={PPTAgent: Generating and Evaluating Presentations Beyond Text-to-Slides},
  author={Zheng, Hao and Guan, Xinyan and Kong, Hao and Zheng, Jia and Zhou, Weixiang and Lin, Hongyu and Lu, Yaojie and He, Ben and Han, Xianpei and Sun, Le},
  journal={arXiv preprint arXiv:2501.03936},
  year={2025}
}
```

[![Star History Chart](https://api.star-history.com/svg?repos=icip-cas/PPTAgent&type=Date)](https://star-history.com/#icip-cas/PPTAgent&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---