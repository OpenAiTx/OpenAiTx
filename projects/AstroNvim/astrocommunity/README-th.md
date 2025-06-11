<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">คลังเก็บชุมชน AstroNvim</h1>

คลังเก็บชุมชนของ AstroNvim ประกอบด้วยสเปคการกำหนดค่า plugin — ชุดของปลั๊กอินที่ชุมชนมีส่วนร่วมสำหรับ AstroNvim ซึ่งเป็นการกำหนดค่า NeoVim สเปคเหล่านี้ช่วยจัดการปลั๊กอินหลากหลายที่ใช้ใน AstroNvim

## 📦 การตั้งค่า

เพื่อรวมปลั๊กอินชุมชน ให้เพิ่มการกำหนดค่าที่จัดเตรียมไว้ใน `plugins` ของคุณ โดยควรทำก่อนนำเข้าปลั๊กอินของคุณเอง เพื่อให้แน่ใจว่าการเปลี่ยนแปลงทั้งหมดของ AstroCommunity ถูกโหลดก่อนการเขียนทับของคุณเอง หากคุณใช้ [AstroNvim Template](https://github.com/AstroNvim/template) คุณสามารถทำได้ในไฟล์ `lua/community.lua` ของคุณ หากคุณไม่คุ้นเคยกับการกำหนดค่าปลั๊กอิน เราแนะนำให้อ้างอิง [เอกสารของ AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/)

### การนำเข้าปลั๊กอิน AstroCommunity

ผสานเนื้อหาต่อไปนี้ภายในไฟล์ `lua/community.lua` ของคุณ:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "astrocommunity.colorscheme.catppuccin" },
  -- ... นำเข้าปลั๊กอินที่ชุมชนมีส่วนร่วมอื่นๆ ที่นี่
}
```

### การปรับแต่งการติดตั้ง AstroCommunity

เมื่อคุณกำหนดการนำเข้า AstroCommunity ใน `lua/community.lua` แล้ว คุณสามารถปรับแต่งการติดตั้งเพิ่มเติมในนิยามปลั๊กอินของคุณเอง (โดยปกติจะทำในไดเรกทอรี `lua/plugins/`) ตัวอย่างนี้สมมติว่าคุณติดตั้ง Catppuccin ดังที่แสดงด้านบน

```lua
return {
  { -- ปรับแต่งตัวเลือกที่ตั้งไว้โดยชุมชนเพิ่มเติม
    "catppuccin",
    opts = {
      integrations = {
        sandwich = false,
        noice = true,
        mini = true,
        leap = true,
        markdown = true,
        neotest = true,
        cmp = true,
        overseer = true,
        lsp_trouble = true,
        rainbow_delimiters = true,
      },
    },
  },
}
```

**หมายเหตุ:**

- หากต้องการปิดการนำเข้า ให้ตั้งค่า `enabled` เป็น `false` คุณมีสองวิธีในการแก้ไขปลั๊กอินที่มีอยู่: ใช้ชื่อที่เต็มของรีโพสิทอรี (เช่น "m4xshen/smartcolumn.nvim") หรือชื่อโมดูล (เช่น "catppuccin") โปรดจำไว้ว่าชื่อโมดูลอาจแตกต่างจากชื่อโฟลเดอร์
- แนะนำให้ใช้เส้นทางนำเข้าที่เต็มเมื่อต้องการปรับแต่งปลั๊กอิน และไม่ใช่การย่อชื่อเพียงชื่อรีโพสิทอรี
- คุณสามารถเขียนทับหลายๆ ด้านของปลั๊กอินชุมชน รวมถึงการตั้งค่า, การพึ่งพา และเวอร์ชัน สำหรับรายละเอียดเพิ่มเติมเกี่ยวกับตัวเลือกที่มี โปรดดู [เอกสาร lazy.nvim](https://lazy.folke.io/)

## การมีส่วนร่วม

หากคุณเขียนการกำหนดค่าปลั๊กอินและต้องการเพิ่มลงในคลังเก็บ AstroCommunity โปรดปฏิบัติตาม [แนวทางการมีส่วนร่วม](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) และส่ง pull request โปรดตรวจสอบให้แน่ใจว่าคุณทดสอบการเปลี่ยนแปลงของคุณอย่างละเอียดก่อนส่ง นี่ไม่ใช่รีโพสิทอรีอย่างเป็นทางการ ดังนั้นความเสถียรขึ้นอยู่กับการมีส่วนร่วมของชุมชน เราตื่นเต้นที่จะได้เห็นโครงการนี้เติบโตและพัฒนา!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---