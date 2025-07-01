![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

คุณสามารถอ่าน [เปเปอร์ของฉัน](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) และอ้างอิงได้ดังนี้ 
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

เนื่องจาก GitHub อาจบล็อกที่อยู่ IP ของจีน ฉันจึงต้องคัดลอกที่เก็บนี้ไปไว้ที่ [ที่นี่](https://codeberg.org/ufo5260987423/scheme-langserver) และ [ที่นี่](https://gitee.com/ufo5260987423/scheme-langserver) ฉันจะอัปเดตที่เก็บทั้งหมดอย่างต่อเนื่องแต่ไม่สามารถรับประกันได้ ขณะนี้ฉันยังร่วมมือกับ [XmacsLabs](https://github.com/XmacsLabs) คุณอาจพบ fork ได้ [ที่นี่](https://github.com/XmacsLabs/scheme-langserver)

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**ขณะนี้ VSCode สามารถใช้ scheme-langserver ได้แล้ว!** โปรดดู [ที่นี่](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

>หมายเหตุ: มีบั๊กจำนวนมากใน scheme-langserver ฉันกำลังแก้ไขและขอความช่วยเหลือจากชุมชน โปรดอดทน

>หมายเหตุ: คุณสามารถดูข้อมูลประเภทที่สร้างอัตโนมัติ [ที่นี่](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result) ตอนนี้ใช้หลักสำหรับการพัฒนาขั้นถัดไป (อาจรวมถึง AKKU) และการดีบัก

การพัฒนาฟีเจอร์ต่าง ๆ เช่น autocomplete, goto definition หรือแสดงเอกสารขณะวางเมาส์ถือเป็นงานใหญ่สำหรับการเขียนโปรแกรม อย่างไรก็ตาม เมื่อเทียบกับภาษาอื่น ๆ เช่น java, python, javascript และ c การพัฒนา language server protocol สำหรับภาษา lisp นั้นเหมือนทำอยู่ในสุญญากาศ [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) และ [swish-lint](https://github.com/becls/swish-lint) ฯลฯ งานของพวกเขาทั้งหมดอาศัย `repl`(Read-Eval-Print Loop) หรือ keyword tokenizer แทนที่จะเป็นการเขียนโปรแกรมจริง เช่น ถ้านักพัฒนากำลังเขียนโค้ดในโปรเจกต์ที่ยังไม่เสร็จสมบูรณ์ ซึ่งโค้ดยังไม่สามารถรันได้ทั้งหมด [Geiser](https://gitlab.com/emacs-geiser) หรือเครื่องมืออื่น ๆ จะทำได้แค่เติม identifier ที่ binding ไว้ในระดับบนสุดซึ่งแสดงโดย procedure `environment-symbols` (สำหรับ [Chez](https://cisco.github.io/ChezScheme/)) หรือเติม symbol แทน identifier ซึ่งหมายความว่า สำหรับ local binding และโค้ดที่ยังไม่สมบูรณ์ แม้ว่าการสนับสนุนด้าน programming จะมีความสำคัญมากที่สุด [Geiser](https://gitlab.com/emacs-geiser) และเครื่องมืออื่น ๆ ก็ไม่ช่วยอะไรในการระบุขอบเขตที่ถูกต้องของ identifier กรณีเดียวกันนี้เกิดขึ้นกับ goto definition และฟีเจอร์อื่น ๆ อีกมากมาย

สาเหตุหลักคือ สำหรับ scheme และ lisp dialects อื่น ๆ ชุดข้อมูลที่หลากหลายและโครงสร้างควบคุมที่ยืดหยุ่นทำให้การวิเคราะห์โปรแกรมเป็นความท้าทายครั้งใหญ่ โดยเฉพาะ macro ดูเหมือนว่า scheme จะใช้หลัก ๆ เพื่อ meta/macro programming สำหรับคนเก่งเท่านั้น แต่ฉันไม่เห็นด้วย Scheme สามารถสร้างสิ่งที่น่าสนใจมากมายหากมีสภาพแวดล้อมการเขียนโปรแกรมที่ดี และตอนนี้คุณสามารถ [**เริ่มต้นได้ที่นี่**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

แพ็กเกจนี้เป็นการพัฒนา language server protocol ที่ช่วยในการเขียนโปรแกรม scheme โดยให้ฟีเจอร์ completion, definition และ type inference ฟีเจอร์เหล่านี้สร้างขึ้นบนการวิเคราะห์โค้ดแบบ static ตาม [r6rs standard](http://www.r6rs.org/) และกฎที่ชัดเจนสำหรับโค้ดที่ยังไม่สมบูรณ์ แพ็กเกจนี้และไลบรารีที่เกี่ยวข้องจะถูกเผยแพร่หรือกำลังจะเผยแพร่ใน [Akku](https://akkuscm.org/) ซึ่งเป็น package manager สำหรับ Scheme

แพ็กเกจนี้ยังผ่านการทดสอบกับ [Chez Scheme](https://cisco.github.io/ChezScheme/) เวอร์ชัน 9.4 และ 9.5 โดยจะทดสอบอย่างละเอียดกับเวอร์ชัน 10.0.0 หลังจากอัปเกรด OS ของแล็ปท็อปเป็นเวอร์ชันใหม่

ฉันทำ open source นี้ในเวลาว่างเท่านั้น และฉันสามารถนำไอเดียดี ๆ มาสู่ชุมชนได้มากมาย เช่น การฝัง data flow analysis ลงใน scheme-langserver หรือสิ่งอื่น ๆ อีกมากมาย และฉันกำลังขอรับบริจาคหรือทุนสนับสนุนอย่างต่อเนื่อง คุณสามารถบริจาคผ่าน [patreon หน้านี้](https://www.patreon.com/PoorProgrammer/membership) หรือ [爱发电](https://afdian.com/a/ufo5260987423)


## การคอมไพล์ ติดตั้ง & ตั้งค่า [ที่นี่](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## สถานะล่าสุด
ฉันจะยังคงแก้บั๊ก, โปรไฟล์โค้ด, และรวบรวมข้อมูลสำหรับหนังสือยักษ์เกี่ยวกับระบบ type inference แบบโฮมเมดของฉัน ซึ่งจะใช้เวลาประมาณ 1 ปี การพัฒนาต่อไปจะรวมถึง [ปลั๊กอิน VScode](https://code.visualstudio.com/) และ data flow analysis แต่จริง ๆ แล้ว ตอนนี้ฉันถือว่าการทำ open source นี้เป็นงาน part-time และไม่สามารถรับประกันกำหนดการได้

## การปล่อยเวอร์ชัน
1.2.9 ขณะนี้สนุกกับ type inference ได้เลย!

สำหรับเวอร์ชันก่อนหน้าโปรดดูที่ [ไฟล์นี้](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md)

### ฟีเจอร์
1. การเติม binding identifier ทั้งในระดับบนสุดและภายในฟังก์ชัน
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Goto definition.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. รองรับการใช้งานร่วมกับ package manager: Akku
4. การซิงโครไนซ์ไฟล์ที่เปลี่ยนแปลงและเปลี่ยนแปลง index ที่เกี่ยวข้อง
5. Hover
6. References และ document highlight (อ้างอิงในขอบเขตเอกสาร)
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Document symbol
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. จับ *-syntax (define-syntax, let-syntax ฯลฯ) สำหรับ binding identifier แบบ local 
9. การทำ parallel indexing ข้ามแพลตฟอร์ม
10. ตัว annotator โค้ดต้นฉบับที่เขียนเองเพื่อรองรับไฟล์ .sps
11. Peephole optimization สำหรับ API requests พร้อมงานที่ suspend ได้
12. Type inference ด้วย homemade DSL interpreter (ฉันภูมิใจมาก!) และตอนนี้ฝังเข้าไปในระบบ auto-completion แล้ว ดังรูปด้านล่าง "length-b" และ "length-a" ที่มี type "integer?" จะอยู่ด้านหน้าของตัวเลือกที่แนะนำเพราะสามารถตรงกับ type ของพารามิเตอร์ที่ฟังก์ชัน "<=" ต้องการ
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
สามารถทดสอบผลลัพธ์นี้ได้ โดยรัน `scheme --script tests/protocol/apis/test-completion.sps` และไฟล์ log `scheme-langserver.log` จะมีผลลัพธ์เช่นนี้:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Abstract interpreter สำหรับการจับ identifier ข้ามไฟล์นามสกุลต่าง ๆ เช่น scm, ss, sps, sls และ sld

### สิ่งที่ต้องทำต่อไป
14. การเปลี่ยนชื่อ (Renaming)
15. รองรับ [r6rs standard](http://www.r6rs.org/) อย่างสมบูรณ์
16. Macro expander แบบ step-by-step: จริง ๆ ฉันได้ทำมาแล้วและตั้งใจใช้สำหรับจับ binding identifier ใน macro ที่นิยามเอง แต่ตอนนี้พบว่าการจับนี้ยากกว่าที่คิด และ macro expander นี้ไม่แน่ใจว่าจะใช้ที่ไหนได้
17. Code eval
18. Code diagnostic
19. เพิ่มการรองรับ semantic ข้ามภาษา อาจจะรองรับ java, c, python และภาษาอื่น ๆ ผ่าน AST transformer?
20. แยก expression/statements ออกเป็น procedure

## สิ่งที่ต้องทำ: การร่วมพัฒนา

## การดีบัก

### วิธีดีบัก
https://www.scheme.com/debug/debug.html#g1

### Output Log
ตามคำแนะนำจาก [Building](#building), [Installation for Lunar Vim](#installation-for-lunarvim) และ [Installation for VScode](#todo-installation-for-vscode) หากใครต้องการพัฒนาและ log ข้อมูล จะสะดวกถ้าเพิ่ม `path-to-log-file` และเขียนทับไฟล์ `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` ดังนี้:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, a language server protocol implementation for scheme
]]   ,
  },
}
```
### การแก้ไขซ้ำด้วย Log 
ด้วย [output log](#output-log) ข้างต้น คุณสามารถใช้ `tests/log-debug.sps` เพื่อตรวจสอบบั๊กที่เกิดซ้ำ:
1. เปลี่ยนชื่อ `{path-to-log}` (โดยปกติคือ `~/scheme-langserver.log`) เป็น `~/ready-for-analyse.log`;
2. รัน `scheme --script tests/log-debug.sps` หากคุณต้องการจำลองสภาพแวดล้อมแบบมัลติเธรด ก็สามารถรัน `scheme --script tests/log-debug.sps` ได้เช่นกัน

## การทดสอบ
เกือบทุกฟังก์ชันหลักและ API ได้รับการทดสอบแล้ว งานของผมอาจจะหยาบไปบ้างแต่ก็มีประโยชน์ คุณอาจต้องการดูสิ่งที่ผมทำในไดเรกทอรี `tests` หรือเพียงแค่รันคำสั่งต่อไปนี้ใน `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>หมายเหตุ
การทดสอบในสภาพแวดล้อมแบบมัลติเธรดนั้นทำได้ยาก ดังนั้น การทดสอบปัจจุบันจึงเน้นที่ซิงเกิลเธรด

## ใช้ Scheme-langserver เพื่อวัตถุประสงค์อื่น
### Script-Fu ใน GIMP
Script-Fu มีพื้นฐานมาจากภาษา Scheme ที่เป็นแบบอินเทอร์พรีต และใช้งานโดยเรียกใช้ฟังก์ชันที่โต้ตอบกับฟังก์ชันภายในของ GIMP ยกตัวอย่างสคริปต์จาก [หน้านี้](https://dalelane.co.uk/blog/?p=628) คุณสามารถใช้ scheme-langserver กับไฟล์สคริปต์ที่มีนามสกุล "SCM" ได้

### อื่น ๆ

ผมก็สนใจ [OMN (Opusmodus Notation)](https://opusmodus.com/) และ AutoLisp ด้วยเช่นกัน แต่ตอนนี้ยังมีอีกหลายอย่างที่ต้องทำ

## นับจำนวนโค้ด
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## เอกสารรายละเอียด
1. [Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)
2. [การจับ binding ของ identifier](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronizing](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~ (Deprecated, และผมกำลังเขียนหนังสือภาษาจีนเกี่ยวกับเรื่องนี้)
5. [API Analysis](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## ประวัติการให้ดาว

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## ผู้มีส่วนร่วม

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---