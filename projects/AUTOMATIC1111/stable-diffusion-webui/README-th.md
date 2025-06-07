# Stable Diffusion web UI
อินเทอร์เฟซเว็บสำหรับ Stable Diffusion ที่พัฒนาด้วยไลบรารี Gradio

![](screenshot.png)

## ฟีเจอร์
[แสดงฟีเจอร์โดยละเอียดพร้อมภาพประกอบ](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- โหมดดั้งเดิม txt2img และ img2img
- ติดตั้งและรันด้วยคลิกเดียว (แต่ยังต้องติดตั้ง python และ git เอง)
- Outpainting
- Inpainting
- Color Sketch
- Prompt Matrix
- Stable Diffusion Upscale
- Attention กำหนดข้อความที่ต้องการให้โมเดลสนใจเป็นพิเศษ
    - a man in a `((tuxedo))` - จะเน้น tuxedo
    - a man in a `(tuxedo:1.21)` - ไวยากรณ์ทางเลือก
    - เลือกข้อความแล้วกด `Ctrl+Up` หรือ `Ctrl+Down` (หรือ `Command+Up` หรือ `Command+Down` หากใช้ MacOS) เพื่อปรับ attention อัตโนมัติ (โค้ดโดยผู้ใช้ไม่เปิดเผยตัว)
- Loopback รันกระบวนการ img2img หลายครั้ง
- X/Y/Z plot วาดกราฟ 3 มิติของภาพที่มีพารามิเตอร์ต่างกัน
- Textual Inversion
    - มี embedding เท่าไรก็ได้และใช้ชื่ออะไรก็ได้
    - ใช้ embedding หลายตัวที่มีจำนวนเวกเตอร์ต่อ token ต่างกัน
    - ทำงานกับเลขทศนิยมแบบ half precision
    - เทรน embedding บนการ์ดจอ 8GB (มีรายงานว่า 6GB ก็ใช้ได้)
- แท็บ Extras ประกอบด้วย:
    - GFPGAN โครงข่ายประสาทสำหรับแก้ไขใบหน้า
    - CodeFormer เครื่องมือกู้คืนใบหน้า ทางเลือก GFPGAN
    - RealESRGAN โครงข่ายประสาทสำหรับขยายภาพ
    - ESRGAN โครงข่ายประสาทสำหรับขยายภาพ พร้อมโมเดลของบุคคลที่สามมากมาย
    - SwinIR และ Swin2SR ([ดูที่นี่](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)) โครงข่ายขยายภาพ
    - LDSR การขยายภาพแบบ latent diffusion super resolution
- ตัวเลือกปรับอัตราส่วนภาพ (Aspect Ratio)
- เลือกวิธี Sampling
    - ปรับค่า eta ของ sampler (ค่าคูณ noise)
    - ตัวเลือกการตั้งค่า noise ขั้นสูง
- หยุดประมวลผลได้ทุกเวลา
- รองรับการ์ดจอ 4GB (มีรายงานว่า 2GB ก็ใช้ได้)
- Seed ที่ถูกต้องสำหรับ batch
- ตรวจสอบความยาว prompt token แบบเรียลไทม์
- พารามิเตอร์การสร้างภาพ
     - บันทึกพารามิเตอร์ที่ใช้สร้างภาพพร้อมกับไฟล์ภาพ
     - ใน PNG chunk สำหรับ PNG, ใน EXIF สำหรับ JPEG
     - ลากภาพไปที่แท็บ PNG info เพื่อกู้คืนและคัดลอกพารามิเตอร์กลับเข้า UI อัตโนมัติ
     - ปิดได้ในตั้งค่า
     - ลากและวางภาพ/ข้อความพารามิเตอร์ลงใน promptbox
- ปุ่ม Read Generation Parameters โหลดพารามิเตอร์จาก promptbox ไปยัง UI
- หน้า Settings
- รันโค้ด python อะไรก็ได้จาก UI (ต้องรันด้วย `--allow-code`)
- มี hint เมื่อเอาเมาส์วางบนส่วนต่างๆ ของ UI
- กำหนดค่า default/min/max/step สำหรับ UI element ได้ผ่าน text config
- รองรับ Tiling สร้างภาพแบบ tile ได้
- แถบแสดงความคืบหน้าและดูพรีวิวภาพที่กำลังสร้างแบบสด
    - ใช้โครงข่ายประสาทแยกเพื่อพรีวิว โดยใช้ VRAM และการประมวลผลน้อยมาก
- Negative prompt ช่องข้อความเสริมสำหรับระบุสิ่งที่ไม่ต้องการในภาพที่สร้าง
- Styles บันทึก prompt บางส่วนและเลือกใช้ในภายหลังผ่าน dropdown
- Variations สร้างภาพเดียวกันแต่แตกต่างเล็กน้อย
- Seed resizing สร้างภาพเดียวกันแต่ขนาดต่างกันเล็กน้อย
- CLIP interrogator ปุ่มเดาคำ prompt จากภาพ
- Prompt Editing แก้ไข prompt ระหว่างการสร้าง เช่น เริ่มจากแตงโมแล้วเปลี่ยนเป็นสาวอนิเมะระหว่างทาง
- Batch Processing ประมวลผลไฟล์กลุ่มด้วย img2img
- Img2img Alternative วิธี reverse Euler ควบคุม cross attention
- Highres Fix ตัวเลือกสร้างภาพความละเอียดสูงคลิกเดียวโดยไม่ผิดรูป
- โหลด checkpoint ใหม่ได้ทันที
- Checkpoint Merger รวม checkpoint ได้สูงสุด 3 อันในแท็บเดียว
- [Custom scripts](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) พร้อมส่วนขยายจากคอมมูนิตี้มากมาย
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/) ใช้หลาย prompt พร้อมกัน
     - แยกแต่ละ prompt ด้วย `AND` ตัวใหญ่
     - รองรับน้ำหนัก prompt ด้วยเช่น `a cat :1.2 AND a dog AND a penguin :2.2`
- ไม่มีขีดจำกัด token ของ prompt (ของ stable diffusion เดิมจำกัด 75 token)
- ผสาน DeepDanbooru สร้างแท็กสไตล์ danbooru สำหรับ prompt อนิเมะ
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers) เพิ่มความเร็วสำหรับการ์ดบางรุ่น (เพิ่ม `--xformers` ใน args)
- ผ่านส่วนขยาย: [History tab](https://github.com/yfszzx/stable-diffusion-webui-images-browser): ดู, จัดการ, ลบภาพใน UI ได้สะดวก
- สร้างภาพต่อเนื่อง (Generate forever)
- แท็บ Training
     - ตัวเลือก hypernetworks และ embeddings
     - เตรียมภาพ: crop, mirror, autotag ด้วย BLIP หรือ deepdanbooru (สำหรับอนิเมะ)
- Clip skip
- Hypernetworks
- Loras (เหมือน Hypernetworks แต่สวยกว่า)
- UI แยกสำหรับเลือก embedding, hypernetwork หรือ Lora ที่จะใส่ใน prompt พร้อมพรีวิว
- เลือกโหลด VAE ต่างๆ จากหน้าตั้งค่าได้
- แสดงเวลาคาดการณ์เสร็จในแถบสถานะ
- API
- รองรับ [inpainting model](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) โดย RunwayML
- ผ่านส่วนขยาย: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients) สร้างภาพสไตล์เฉพาะโดยใช้ clip image embed ([implementation](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- รองรับ [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - ดู [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20)
- รองรับ [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - ดู [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion)
- ไม่มีตัวอักษรต้องห้ามอีกต่อไป!
- โหลด checkpoint แบบ safetensors ได้
- ผ่อนคลายข้อจำกัดความละเอียด: ขนาดภาพที่สร้างต้องหารด้วย 8 ลงตัว (จากเดิม 64)
- มีไลเซนส์แล้ว!
- เรียงลำดับ element ใน UI ได้จากหน้าตั้งค่า
- รองรับ [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## การติดตั้งและการใช้งาน
ตรวจสอบให้แน่ใจว่าติดตั้ง [dependencies](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) ที่จำเป็นแล้ว และทำตามคำแนะนำสำหรับ:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (แนะนำ)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPUs
- [Intel CPUs, Intel GPUs (รวมทั้ง integrated และ discrete)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (wiki ภายนอก)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (wiki ภายนอก)

หรือใช้บริการออนไลน์ (เช่น Google Colab):

- [รายชื่อบริการออนไลน์](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### ติดตั้งบน Windows 10/11 กับ NVidia-GPUs ด้วย release package
1. ดาวน์โหลด `sd.webui.zip` จาก [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) แล้วแตกไฟล์
2. รัน `update.bat`
3. รัน `run.bat`
> ดูรายละเอียดเพิ่มเติมที่ [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### ติดตั้งอัตโนมัติบน Windows
1. ติดตั้ง [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (Python เวอร์ชันใหม่กว่าไม่รองรับ torch) และเลือก "Add Python to PATH"
2. ติดตั้ง [git](https://git-scm.com/download/win)
3. ดาวน์โหลด repository stable-diffusion-webui เช่นรัน `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`
4. รัน `webui-user.bat` จาก Windows Explorer เป็นผู้ใช้ปกติ (ไม่ใช่ administrator)

### ติดตั้งอัตโนมัติบน Linux
1. ติดตั้ง dependencies:
```bash
# สำหรับ Debian-based:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# สำหรับ Red Hat-based:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# สำหรับ openSUSE-based:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# สำหรับ Arch-based:
sudo pacman -S wget git python3
```
หากระบบคุณใหม่มาก อาจต้องติดตั้ง python3.11 หรือ python3.10:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # อย่าสับสนกับ python3.11 package

# สำหรับ 3.11 เท่านั้น
# ตั้ง env variable ใน launch script
export python_cmd="python3.11"
# หรือใน webui-user.sh
python_cmd="python3.11"
```
2. ไปยังโฟลเดอร์ที่ต้องการติดตั้ง webui แล้วรันคำสั่ง:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
หรือ clone repo ไปยังที่ที่ต้องการ:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. รัน `webui.sh`
4. ตรวจสอบ `webui-user.sh` สำหรับตัวเลือกเพิ่มเติม
### ติดตั้งบน Apple Silicon

ดูคำแนะนำ [ที่นี่](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon)

## การมีส่วนร่วม
วิธีเพิ่มโค้ดใน repo นี้: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## เอกสารประกอบ

เอกสารถูกย้ายจาก README นี้ไปที่ [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki) ของโปรเจกต์

เพื่อให้ Google และ search engine อื่น ๆ ดึงข้อมูลจาก wiki ได้ นี่คือ (ไม่ใช่สำหรับมนุษย์) [crawlable wiki](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki)

## เครดิต
ไลเซนส์ของโค้ดที่นำมาใช้สามารถดูได้ที่ `Settings -> Licenses` และในไฟล์ `html/licenses.html`

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel implementing
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- ไอเดียสำหรับการปรับปรุง - https://github.com/basujindal/stable-diffusion
- การปรับปรุง Cross Attention layer - Doggettx - https://github.com/Doggettx/stable-diffusion, ไอเดียต้นฉบับสำหรับ prompt editing
- การปรับปรุง Cross Attention layer - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (ต้นฉบับ http://github.com/lstein/stable-diffusion)
- Sub-quadratic Cross Attention layer optimization - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (ไม่ได้ใช้โค้ด แต่ใช้ไอเดีย)
- ไอเดียสำหรับ SD upscale - https://github.com/jquesnelle/txt2imghd
- การสร้าง noise สำหรับ outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- ไอเดียและโค้ดบางส่วนสำหรับ CLIP interrogator - https://github.com/pharmapsychotic/clip-interrogator
- ไอเดียสำหรับ Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogator สำหรับ anime diffusers https://github.com/KichangKim/DeepDanbooru
- Sampling แบบ float32 จาก float16 UNet - marunine สำหรับไอเดีย, Birch-san สำหรับตัวอย่าง Diffusers implementation (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- คำแนะนำด้านความปลอดภัย - RyotaK
- UniPC sampler - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Restart sampling - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- Gradio script แรก - โพสต์ใน 4chan โดย Anonymous user ขอบคุณผู้ใช้ท่านนี้
- (คุณ)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---