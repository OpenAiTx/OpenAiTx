<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

คุณสามารถอ่าน [เอกสาร](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) ของฉันและอ้างอิงตามนี้ 
> WANG, Z. (2025, 12 พฤษภาคม). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

เนื่องจาก GitHub อาจบล็อกที่อยู่ IP จากจีน ฉันจึงต้องคัดลอก repository นี้ไปไว้ที่ [ที่นี่](https://codeberg.org/ufo5260987423/scheme-langserver) และ [ที่นี่](https://gitee.com/ufo5260987423/scheme-langserver) ฉันจะอัปเดต repository ทั้งหมดอย่างต่อเนื่องแต่ไม่สามารถรับประกันได้ ขณะนี้ฉันยังได้ร่วมมือกับ [XmacsLabs](https://github.com/XmacsLabs) คุณสามารถพบ fork ได้ที่ [ที่นี่](https://github.com/XmacsLabs/scheme-langserver) เช่นกัน

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**ขณะนี้ VSCode สามารถใช้ scheme-langserver ได้แล้ว!** โปรดดูรายละเอียดที่ [ที่นี่](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

>หมายเหตุ: มีบั๊กจำนวนมากใน scheme-langserver ฉันกำลังแก้ไขและขอความช่วยเหลือจากชุมชน กรุณาอดทนรอ

>หมายเหตุ: คุณสามารถดูข้อมูลชนิดที่สร้างอัตโนมัติได้ที่ [ที่นี่](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result) ซึ่งปัจจุบันใช้สำหรับการพัฒนาในขั้นถัดไป (อาจรวมถึง AKKU) และการดีบัก

การเพิ่มฟีเจอร์อย่าง autocomplete, ไปยังนิยาม หรือเอกสารขณะ hover เป็นงานที่ต้องใช้ความพยายามมากสำหรับการเขียนโปรแกรม อย่างไรก็ตาม เมื่อเทียบกับภาษาอื่นเช่น java, python, javascript และ c การพัฒนา language server protocol สำหรับภาษา lisp นั้นเหมือนทำในสุญญากาศ [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) และ [swish-lint](https://github.com/becls/swish-lint) เป็นต้น งานของพวกเขาทั้งหมดอิงกับ `repl` (Read-Eval-Print Loop) หรือ keyword tokenizer แทนที่จะเป็นการเขียนโปรแกรมจริง ตัวอย่างเช่น หากโปรแกรมเมอร์กำลังเขียนโค้ดในโปรเจกต์ที่ยังไม่สมบูรณ์ ซึ่งโค้ดยังไม่สามารถรันได้ทั้งหมด [Geiser](https://gitlab.com/emacs-geiser) หรือเครื่องมืออื่น ๆ จะเติมเฉพาะ binding identifiers ในระดับ top-level ที่แสดงโดย procedure `environment-symbols` (สำหรับ [Chez](https://cisco.github.io/ChezScheme/)) หรือเติม symbol แทน identifier ซึ่งหมายความว่า สำหรับ local binding และโค้ดที่ยังไม่สมบูรณ์ แม้ว่าการวิเคราะห์โค้ดจะมีความสำคัญเป็นอย่างมาก [Geiser](https://gitlab.com/emacs-geiser) และเครื่องมืออื่น ๆ กลับไม่ช่วยอะไรในเรื่องการระบุขอบเขตของ identifier ที่ถูกต้อง กรณีเช่นเดียวกันนี้ก็เกิดกับฟีเจอร์ goto definition และฟีเจอร์อื่น ๆ อีกมาก

สาเหตุหลักคือ สำหรับ scheme และ lisp dialects อื่น ๆ ชุดข้อมูลที่หลากหลายและโครงสร้างควบคุมที่ยืดหยุ่น ทำให้การวิเคราะห์โปรแกรมเป็นความท้าทายใหญ่ โดยเฉพาะ macro ดูเหมือนว่า scheme จะถูกใช้สำหรับงานโปรแกรมขั้นสูงและ meta/macro programming เป็นหลัก แต่ฉันขอแย้งว่าไม่ใช่ Scheme สามารถสร้างสิ่งที่น่าสนใจได้มากมายหากมีสภาพแวดล้อมการเขียนโปรแกรมที่ดี และตอนนี้คุณสามารถ [**เริ่มต้นที่นี่**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

แพ็กเกจนี้เป็นการติดตั้ง language server protocol ที่ช่วยในการพัฒนาโปรแกรมด้วย scheme โดยให้ฟีเจอร์ completion, definition และ type inference ฟีเจอร์เหล่านี้สร้างจากการวิเคราะห์โค้ดแบบ static โดยอิงตาม [มาตรฐาน r6rs](http://www.r6rs.org/) และกฎพื้นฐานบางอย่างสำหรับโค้ดที่ยังไม่สมบูรณ์ แพ็กเกจนี้และไลบรารีที่เกี่ยวข้องได้รับการเผยแพร่หรือกำลังจะเผยแพร่ด้วย [Akku](https://akkuscm.org/) ซึ่งเป็น package manager สำหรับ Scheme

แพ็กเกจนี้ได้ผ่านการทดสอบกับ [Chez Scheme](https://cisco.github.io/ChezScheme/) เวอร์ชัน 9.4 และ 9.5 และจะมีการทดสอบโดยละเอียดในเวอร์ชัน 10.0.0 หลังจากอัปเกรดระบบปฏิบัติการแล็ปท็อปของฉัน

ฉันทำงานโอเพ่นซอร์สนี้ในเวลาว่าง และฉันสามารถนำเสนอไอเดียดี ๆ ให้กับชุมชนมากมาย เช่น ฝัง data flow analysis ลงใน scheme-langserver หรืออย่างอื่นอีกมากมาย และฉันกำลังขอรับการบริจาคหรือเงินทุนสนับสนุนเพิ่มเติมอย่างต่อเนื่อง คุณสามารถบริจาคผ่าน [patreon นี้](https://www.patreon.com/PoorProgrammer/membership) หรือ [爱发电](https://afdian.com/a/ufo5260987423)

## การคอมไพล์ ติดตั้ง & ตั้งค่า ดูได้ที่ [ที่นี่](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## สถานะล่าสุด
ฉันจะยังคงแก้ไขบั๊ก, โปรไฟล์โค้ด, และรวบรวมข้อมูลสำหรับหนังสือเล่มใหญ่ของฉันเกี่ยวกับระบบ type inference ที่ทำเอง ซึ่งจะใช้เวลาประมาณ 1 ปี การพัฒนาต่อไปจะรวมถึงปลั๊กอิน [VScode](https://code.visualstudio.com/) และการวิเคราะห์ data flow แต่จริง ๆ แล้ว ตอนนี้ฉันถือว่างานโอเพ่นซอร์สนี้เป็นงานพาร์ทไทม์ และไม่สามารถรับประกันตารางเวลาได้

## การปล่อยเวอร์ชัน 
1.2.9 ตอนนี้ สนุกกับ type inference ได้เลย!

สำหรับเวอร์ชันก่อนหน้า กรุณาดูที่ [ไฟล์นี้](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md)

### ฟีเจอร์
1. เติมคำสั่ง binding ของ identifier ทั้งในระดับ top-level และ local
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. ไปยังนิยาม (Goto definition)
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. ใช้งานร่วมกับ package manager: Akku ได้
4. ซิงโครไนซ์การเปลี่ยนแปลงไฟล์และอัปเดตดัชนีที่เกี่ยวข้อง
5. Hover
6. อ้างอิงและไฮไลท์ในเอกสาร (Document-scoped references)
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Document symbol
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. จับ binding ของ local identifier ที่ใช้ *-syntax (define-syntax, let-syntax ฯลฯ)
9. ดัชนีแบบขนานข้ามแพลตฟอร์ม
10. ตัวใส่คำอธิบายซอร์สโค้ดที่สร้างเอง เพื่อให้รองรับไฟล์ .sps
11. Peephole optimization สำหรับคำขอ API ด้วยงานที่สามารถพักได้ (suspendable task)
12. Type inference ด้วย DSL interpreter ที่ทำเอง (ฉันภูมิใจมาก!) และตอนนี้ได้ฝังเข้าไปในระบบ auto-completion แล้ว ดังภาพตัวอย่างด้านล่าง "length-b" และ "length-a" ที่มีชนิด "integer?" จะอยู่หน้าสุดของตัวเลือกที่แนะนำ เพราะตรงกับชนิดพารามิเตอร์ที่ต้องการจาก "<=" 
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
สามารถทดสอบผลลัพธ์นี้ได้โดยรัน `scheme --script tests/protocol/apis/test-completion.sps` และไฟล์ log `scheme-langserver.log` จะมีผลลัพธ์แบบนี้:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. abstract interpreter สำหรับจับ identifier ข้ามนามสกุลไฟล์ต่าง ๆ เช่น scm, ss, sps, sls และ sld

### TODOs
14. การเปลี่ยนชื่อ (Renaming)
15. รองรับ [มาตรฐาน r6rs](http://www.r6rs.org/) อย่างเต็มรูปแบบ
16. macro expander แบบ step-by-step: จริง ๆ ฉันได้ทำไว้แล้ว และตั้งใจจะใช้เป็นขั้นตอนสำคัญในการจับ binding ของ identifier ใน macro ที่นิยามเอง ตอนนี้พบว่าสิ่งนี้ทำได้ยากกว่าที่คิด และ macro expander ที่มีอยู่ก็ไม่แน่ใจว่าจะใช้ตรงไหนได้
17. การ eval โค้ด
18. การวินิจฉัยโค้ด
19. เพิ่มการรองรับความหมายข้ามภาษา แล้ว java, c, python และภาษาอื่นๆ อีกมากมายสามารถรองรับได้ด้วย AST transformer หรือไม่?
20. แยกนิพจน์/คำสั่งออกเป็น procedure

## TODO:Contributing 

## Debug

### วิธีการดีบัก
https://www.scheme.com/debug/debug.html#g1

### บันทึกผลลัพธ์ (Output Log)
ตามคำแนะนำจาก [Building](#building), [Installation for Lunar Vim](#installation-for-lunarvim) และ [Installation for VScode](#todo-installation-for-vscode) หากใครต้องการพัฒนาและบันทึก log จะสะดวกโดยเพิ่ม `path-to-log-file` และเขียนทับไฟล์ `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` ดังนี้:
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
`scheme-langserver` เป็นการนำ Language Server Protocol มาปรับใช้กับภาษา scheme
]]   ,
  },
}
```
### การเรียกซ้ำด้วย Log 
ด้วย [output log](#output-log) ข้างต้น คุณสามารถใช้ `tests/log-debug.sps` เพื่อตรวจสอบบั๊กซ้ำได้ดังนี้:
1. เปลี่ยนชื่อ `{path-to-log}` (โดยปกติคือ `~/scheme-langserver.log`) เป็น `~/ready-for-analyse.log`;
2. รัน `scheme --script tests/log-debug.sps` หากต้องการสร้างสภาพแวดล้อมแบบมัลติเธรดใหม่อีกครั้ง ก็สามารถรัน `scheme --script tests/log-debug.sps` ได้เช่นกัน

## Test
เกือบทุก procedure หลักและ API ได้รับการทดสอบแล้ว งานของผมอาจจะหยาบแต่ก็มีประโยชน์ คุณอาจจะอยากดูสิ่งที่ผมทำไว้ในไดเรกทอรี `tests` หรือเพียงแค่รันคำสั่งนี้ใน `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
> หมายเหตุ
การทดสอบกับสภาพแวดล้อมมัลติเธรดนั้นยาก ดังนั้นการทดสอบปัจจุบันจึงเน้นที่ single thread

## ใช้ Scheme-langserver เพื่อวัตถุประสงค์อื่น
### Script-Fu ใน GIMP
Script-Fu มีพื้นฐานจากภาษา Scheme แบบ interpreted และทำงานผ่านฟังก์ชันที่โต้ตอบกับฟังก์ชันภายในของ GIMP โดยยกตัวอย่าง [สคริปต์หน้านี้](https://dalelane.co.uk/blog/?p=628) คุณสามารถใช้ scheme-langserver กับไฟล์ script ที่มีนามสกุล "SCM"

### อื่นๆ

ผมก็สนใจ [OMN (Opusmodus Notation)](https://opusmodus.com/) และ AutoLisp ด้วยเช่นกัน แต่ยังมีหลายอย่างที่ต้องทำ

## นับจำนวนโค้ด
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## เอกสารรายละเอียด
1. [Scheme-langserver: ให้ความสำคัญกับการแก้ไขโค้ด Scheme เป็นอันดับแรก](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)
2. [การดักจับ identifier bindings](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [การซิงโครไนซ์](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [การอนุมานชนิดข้อมูล](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(เลิกใช้แล้ว และผมกำลังเขียนหนังสือภาษาจีนสำหรับหัวข้อนี้)
5. [API Analysis](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## ประวัติการเพิ่มดาว (Star History)

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## ผู้ร่วมพัฒนา (Contributors)

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---