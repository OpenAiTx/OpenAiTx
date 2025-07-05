# lsfg-vk
โปรเจกต์นี้นำ [Lossless Scaling's Frame Generation](https://store.steampowered.com/app/993090/Lossless_Scaling/) มาสู่ Linux!
>[!NOTE]
> นี่คือโปรเจกต์ที่ยังอยู่ระหว่างการพัฒนา แม้ว่าฟีเจอร์ frame generation จะทำงานได้ในบางเกม แต่ก็ยังมีทางอีกยาวไกล กรุณาตรวจสอบ wiki สำหรับการสนับสนุน (ยังไม่ได้เขียน wiki)

## การคอมไพล์ ติดตั้ง และรัน

>[!CAUTION]
> คำแนะนำในการ build ได้มีการเปลี่ยนแปลงเมื่อไม่นานนี้ กรุณาตรวจสอบอีกครั้ง

เพื่อคอมไพล์ LSFG ให้แน่ใจว่าคุณได้ติดตั้งคอมโพเนนต์เหล่านี้ในระบบของคุณแล้ว:
- เครื่องมือ build แบบดั้งเดิม (+ sed, git)
- คอมไพเลอร์ Clang (โปรเจกต์นี้ไม่สามารถคอมไพล์ด้วย GCC ได้ง่ายๆ)
- ไฟล์ header ของ Vulkan
- ระบบ build CMake
- ระบบ build Meson (สำหรับ DXVK)
- ระบบ build Ninja (backend สำหรับ CMake)

การคอมไพล์ lsfg-vk ค่อนข้างตรงไปตรงมา เนื่องจากทุกอย่างถูกรวมไว้ใน CMake อย่างเป็นระเบียบ:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
คำสั่งเหล่านี้จะติดตั้ง lsfg-vk ไปที่ ~/.local/lib และ ~/.local/share/vulkan

ถัดไป คุณจะต้องดาวน์โหลด Lossless Scaling จาก Steam เปลี่ยนไปที่ branch `legacy_2.13` หรือดาวน์โหลด depot ที่เกี่ยวข้อง
คัดลอกหรือจดเส้นทางของ "Lossless.dll" จากไฟล์เกมไว้

สุดท้าย มาลองเริ่มโปรแกรมโดยเปิดใช้ frame generation ตัวอย่างนี้ใช้ `vkcube`:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
ตรวจสอบให้แน่ใจว่าคุณแก้ไข path ให้ตรงกับของคุณ มาดูแต่ละตัวแปรกัน:
- `VK_INSTANCE_LAYERS`: ระบุ `VK_LAYER_LS_frame_generation` ที่นี่ จะบังคับให้แอป Vulkan ใดๆ โหลดเลเยอร์ lsfg-vk
- `LSFG_DLL_PATH`: ตรงนี้ให้ระบุไฟล์ Lossless.dll ที่คุณดาวน์โหลดจาก Steam lsfg-vk จะดึงและแปลง shader จากที่นี่
- `LSFG_MULTIPLIER`: ตัวคูณที่คุณควรคุ้นเคย ระบุ `2` เพื่อเพิ่มเฟรมเรตเป็นสองเท่า เป็นต้น
- `VK_LAYER_PATH`: ถ้าคุณไม่ได้ติดตั้งที่ `~/.local` หรือ `/usr` ต้องระบุโฟลเดอร์ `explicit_layer.d` ตรงนี้

>[!WARNING]
> ไม่เหมือนบน Windows, LSFG_MULTIPLIER จะถูกจำกัดอย่างมากที่นี่ (ในขณะนี้!) หากฮาร์ดแวร์ของคุณสามารถสร้าง swapchain images ได้ 8 อัน การตั้งค่า LSFG_MULTIPLIER เป็น 4 จะใช้ไป 4 ช่อง เหลือให้เกมแค่ 4 ถ้าเกมต้องการมากกว่า 5 ขึ้นไป เกมจะ crash

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---