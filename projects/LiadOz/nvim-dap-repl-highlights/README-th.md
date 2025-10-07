<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# nvim-dap-repl-highlights
เพิ่มการไฮไลต์ไวยากรณ์ให้กับบัฟเฟอร์ REPL ของ [nvim-dap](https://github.com/mfussenegger/nvim-dap) โดยใช้ treesitter
| ก่อน                                                                                                            | หลัง                                                                                                           |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## ข้อกำหนดเบื้องต้น
* Neovim 0.9 หรือใหม่กว่า

* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## การตั้งค่า
ติดตั้งปลั๊กอินและข้อกำหนดโดยใช้วิธีที่คุณชื่นชอบ เมื่อทำการติดตั้งแล้ว โปรดตรวจสอบว่าคุณได้ตั้งค่า treesitter [highlighting](https://github.com/nvim-treesitter/nvim-treesitter#modules) แล้ว จากนั้นเพิ่มโค้ดต่อไปนี้ใน config lua ของคุณ
```lua
require('nvim-dap-repl-highlights').setup()
```
หลังจากตั้งค่า plugin เบื้องต้นแล้ว จำเป็นต้องติดตั้งตัวแปล dap_repl โดยสามารถทำได้ด้วยตนเองโดยรันคำสั่ง `:TSInstall dap_repl`

หรือทำแบบอัตโนมัติผ่านการกำหนดค่า Treesitter:

**โดยใช้ `ensure_installed` (nvim-treesitter สาขา master)**
> ⚠️ **หมายเหตุ:** คุณต้องเรียกใช้ nvim-dap-repl-highlights.setup() ก่อน Treesitter ไม่เช่นนั้นจะไม่พบตัวแปล dap_repl
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter.configs').setup {
  highlight = {
    enable = true,
  },
  ensure_installed = { 'dap_repl', ... },
  ...
}
```
**การใช้ `nvim-treesitter.install` (สาขาหลักของ nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ หากสิ่งนี้หยุดทำงานหรือ API มีการเปลี่ยนแปลง โปรดตรวจสอบเอกสาร Treesitter อย่างเป็นทางการสำหรับวิธีการติดตั้งล่าสุด:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## การใช้งาน
โดยค่าเริ่มต้น ปลั๊กอินจะตรวจสอบภาษาเพื่อใช้ใน REPL โดยดูจาก **filetype** ที่ใช้ในการเปิด dap แน่นอนว่าในการใช้ไฮไลต์ไวยากรณ์สำหรับบางภาษา คุณจะต้องมี treesitter parser สำหรับภาษานั้น พร้อมกับ `dap_repl` parser
ซึ่งอาจไม่เหมาะกับทุกกรณีการใช้งาน

คุณสามารถใช้คำสั่ง `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` ซึ่งจะตั้งค่าไฮไลต์ของภาษา python ในรีพลปัจจุบัน 
หรือจะเรียกใช้ฟังก์ชันโดยไม่ระบุภาษา ซึ่งจะมีการถามผู้ใช้สำหรับภาษา

นอกจากนี้คุณยังสามารถระบุใน **dap** configuration ว่าจะใช้ภาษารีพลใด เช่น หากคุณต้องการให้รีพล python ของคุณมีไฮไลต์ภาษา javascript:
```lua
local dap = require('dap')
dap.configurations.python = {
  {
    name = "Python with javascript repl because I like to watch the world burn 🔥🔥🔥",
    type = "python",
    request = "launch",
    program = "${file}",
    repl_lang = "javascript"
  },
}
```
ตัวเลือก repl_lang จะมีความสำคัญเหนือกว่า filetype


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---