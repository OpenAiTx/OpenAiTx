# Enthium - การพบกันของ Engrammer และ Hands Down Promethium

![ภาพถ่าย Enthium v7 บนคีย์บอร์ด Glove80 ของฉัน](https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-photograph-Enthium.jpg)

การดัดแปลงรูปแบบคีย์บอร์ด [Engrammer] และ [Hands Down Promethium] นี้
ปรับปรุงประสิทธิภาพจาก Promethium (ดูข้อมูลด้านล่าง)
โดยการสะท้อนแนวนอนเพื่อคืนความคุ้นเคยกับเลย์เอาต์ [Engram 2.0 ของ Arno]
(CIEA อยู่ที่แถวบ้านของมือซ้าย; PF สลับกับ WV ให้เหมือน Engram)
และเลย์เอาต์ [Dvorak] (HTNS อยู่ที่แถวบ้านของมือขวา) และยังปรับปรุง
ตำแหน่งเครื่องหมายวรรคตอนเพื่อการเขียนโปรแกรมในจิตวิญญาณแบบ Engrammer

ที่สำคัญ ความแตกต่างระหว่าง Engram/mer กับ Enthium มีน้อยมากจนสามารถเปลี่ยนมาใช้ได้เต็มตัวด้วยการฝึกฝนราว 6 ชั่วโมง กระจายตลอด 2-3 วัน (เริ่มวันศุกร์แล้วใช้ช่วงสุดสัปดาห์) เพื่อปลดล็อกตัวอักษรทั้งหมดใน [KeyBr] ขณะฝึก

ดูเพิ่มเติม: [บล็อกของฉัน](https://sunaku.github.io/enthium-keyboard-layout.html)
เกี่ยวกับการเดินทางที่ไม่คาดคิด "down the rabbit hole" ที่นำไปสู่การพัฒนาเลย์เอาต์นี้

[Hands Down Promethium]: https://reddit.com/r/KeyboardLayouts/comments/1g66ivi
[Arno's Engram 2.0]:     https://engram.dev
[Engrammer]:             https://github.com/sunaku/engrammer
[Dvorak]:                https://www.dvzine.org
[KeyBr]:                 https://github.com/aradzie/keybr.com#readme

## เลย์เอาต์

      q y o u - x l d w z
    b c i e a , k h t n s v
      ' / = . ; j m g p f
                r

>![แสดงผล Enthium v7 บนคีย์บอร์ดโน้ตบุ๊ก](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)
>![แสดงผล Enthium v7 บนคีย์บอร์ด Glove80 ของฉัน](https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-diagram-Enthium.png)

<!-- vim-markdown-toc GFM -->

* [เหตุผล](#rationale)
  * [ข้อเบี่ยงเบน: PF และ WV](#deviation-pf-and-wv)
  * [ข้อเบี่ยงเบน: B และ V](#deviation-b-and-v)
* [ประสิทธิภาพ](#performance)
  * [Cyanophage analyzer](#cyanophage-analyzer)
  * [KeySolve analyzer](#keysolve-analyzer)
  * [Oxey's analyzer](#oxeys-analyzer)
  * [การเปรียบเทียบ](#comparison)
* [การติดตั้ง](#installation)
  * [ตั้งค่าบน Linux](#linux-setup)
  * [ตั้งค่าบน MacOS](#macos-setup)
    * [การติดตั้ง](#installation-1)
    * [การปรับแต่งแบบซับซ้อน](#complex-modification)
    * [การถอนการติดตั้ง](#uninstallation)
* [สัญญาอนุญาต](#license)

<!-- vim-markdown-toc -->

## เหตุผล

* Q และ Z แยกอยู่คนละมือเพื่อความสมดุลและสมมาตร

* B และ V อยู่ที่ปุ่มนิ้วก้อยแถวบ้านด้านข้าง (CapsLock, Apostrophe)
  เพื่อหลีกเลี่ยงการเอื้อมขึ้นสำหรับผู้ที่มีนิ้วก้อยสั้นหรือ [นิ้วก้อยอ่อนแรง]

* Apostrophe อยู่ห่าง (ใช้นิ้วคนละนิ้ว) จาก YOU และ I
  เพื่อให้พิมพ์ได้โดยไม่มี bigram นิ้วเดียวกัน เช่น `you'd` และ `I'd`

* Comma และ semicolon จัดกลุ่มกันเพื่อการวนหา f/F/t/T ใน Vim ได้สะดวก
  และเพื่อสะท้อนตำแหน่งสัมพัทธ์ของ K และ J ในมือขวา

* แม้ period กับ comma จะสลับกันในแง่ของสัญลักษณ์ shift
  `>` และ `<` การจัดวางนี้ช่วยลด bigram ที่ต้องเหยียดนิ้วข้าง ๆ
  และยังเรียงซ้อนกันในแนวตั้งบนคีย์บอร์ดแถวเหลื่อมแบบดั้งเดิม

* เครื่องหมายลบอยู่ที่นิ้วชี้ (เหมือนกับ comma, period, และ semicolon)
  เพื่อให้รับผิดชอบเครื่องหมายแบ่งคำ/ประโยคอย่างสม่ำเสมอ
  และเพื่อการเข้าถึง `_` underscore ที่ใช้บ่อยในโปรแกรมมิ่งได้ง่าย
  โดยเฉพาะบนคีย์บอร์ดแถวเหลื่อมที่ตำแหน่งนี้เหมาะกับการเหยียดนิ้วชี้ซ้าย

* Slash และ period ทำให้ roll พิมพ์ `/.`, `./`, และ `../` ได้สะดวก

[นิ้วก้อยอ่อนแรง]: https://reddit.com/r/KeyboardLayouts/comments/1fy8nve/_/lqulnww/

### ข้อเบี่ยงเบน: PF และ WV

มีการสลับ PF กับ WV เพื่อแก้ไขความไม่สะดวกดังนี้:

* WN เป็น bigram นิ้วเดียวกันที่ต้องขยับขึ้น ซึ่งอยากให้ลากลงแทน
* DW (ข้าม 2 ตำแหน่ง) ไม่สะดวกสำหรับ Vim เท่า Engram (ที่วางไว้ติดกัน)
* FG (ข้าม 2 ตำแหน่ง) ไม่สะดวกเท่าเดิมสำหรับการสลับงานพื้นหลังใน shell (`bg`, `fg`)
* SW (กึ่ง scissor) รู้สึกอ่อนแรงกว่าการเอื้อมขึ้น (เหมือนใน Engram)
* FF (เช่น "stu*ff*") ลำบากนิ้วก้อยเมื่อต้องกดซ้ำสองครั้งบนแถวบน

แม้ไม่อยากเบี่ยงเบนจากเลย์เอาต์ Hands Down Promethium ดั้งเดิม
(Enthium นี้ตั้งใจจะเป็นแค่การสะท้อนแนวนอนและจัดเครื่องหมายวรรคตอนใหม่)
แต่จึงต้องไปทดสอบใน playground ของ keyboard layout analyzer ว่าการสลับ PF กับ WV นี้ส่งผลแย่แค่ไหน... และน่าแปลกใจมากที่ประสิทธิภาพแทบไม่เปลี่ยน:

* Oxey's analyzer ไม่เปลี่ยนแปลงสถิติเลย!
* KeySolve analyzer ค่า FSB เพิ่มจาก 0.14% เป็น 0.37% แต่สถิติอื่นดีขึ้น: FSS ลดจาก 0.82% เหลือ 0.48%, HSB ลดจาก 6.05% เหลือ 5.64%, และ HSS ลดจาก 5.97% เหลือ 5.50%; ที่เหลือเหมือนเดิม
* Cyanophage analyzer ค่า Total Word Effort เพิ่มจาก 730.9 เป็น 735.9 แต่สถิติอื่นเหมือนเดิม

ดีใจมากที่ทดลองแล้วได้ผล เพราะทำให้เลย์เอาต์นี้ใช้งานได้สะดวกขึ้น และลดอุปสรรคสำหรับผู้ที่ต้องการเปลี่ยนจาก Engrammer มาใช้ Enthium :)

### ข้อเบี่ยงเบน: B และ V

B และ V หมุนจากแถวบนมาอยู่แถวบ้านด้านข้างเพื่อเลี่ยงการเอื้อมขึ้นสำหรับผู้ที่มีนิ้วก้อยสั้นหรือ [นิ้วก้อยอ่อนแรง] ปุ่มเดิมจึงมอบให้กับตัวอักษรที่พบน้อยที่สุดในภาษาอังกฤษคือ Q และ Z

ใน Cyanophage analyzer การเปลี่ยนนี้ช่วยลด Pinky/Ring Scissors จาก 0.49% เหลือ 0.35% (ลดลงมาก!) และ Skip Bigrams (2u) จาก 0.30% เหลือ 0.29%
Analyzer อื่นยังไม่รองรับปุ่ม lateral pinky อย่างเต็มที่ (มีคำอธิบายที่หัวข้อย่อยของแต่ละ analyzer) แต่ Oxey's analyzer รายงานว่า SFB ลดลงอย่างเห็นได้ชัดจาก 0.829% เหลือ 0.818%

## ประสิทธิภาพ

### [Cyanophage analyzer][cNT]

> **หมายเหตุ:** Analyzer นี้ขณะนี้รองรับเฉพาะการวางตัวอักษรที่นิ้วโป้งซ้าย ไม่รองรับนิ้วโป้งขวา ดังนั้นเลย์เอาต์จึงสะท้อนแนวนอนเพื่อวิเคราะห์ ซึ่งการสะท้อนไม่กระทบผลลัพธ์

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/cyanophage.png)

สถิติโดยรวม:
* Total Word Effort: 748.5
* Effort:            432.54

การใช้นิ้ว:
* Same Finger Bigrams: 0.55%
* Skip Bigrams (2u):   0.29%
* Lat Stretch Bigrams: 0.23%
* Pinky/Ring Scissors: 0.34%

สถิติ Trigram:
* alt:             37.45%
* bigram roll in:  29.02%
* bigram roll out: 14.67%
* other:           8.28%
* alt sfs:         5.10%
* redirect:        2.14%
* roll in:         1.71%
* weak redirect:   1.32%
* roll out:        0.31%

### [KeySolve analyzer](https://grassfedreeve.github.io/keysolve-web/)

> **หมายเหตุ:** Analyzer นี้ยังไม่รองรับการวางตัวอักษรบนปุ่มนิ้วก้อย lateral ของแถวบ้าน เช่น CapsLock และ apostrophe ดังนั้นผลลัพธ์อาจไม่แม่นยำ เช่น SFB ที่นี่ถือว่า R B V ถูกพิมพ์ด้วยนิ้วโป้งทั้งหมด ทั้งที่จริง R อยู่ที่นิ้วโป้งขวา B ที่นิ้วก้อยซ้าย และ V ที่นิ้วก้อยขวา

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve1.png)
![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve2.png)
![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve3.png)

สถิติโดยรวม:

    BIGRAMS     SFB: 0.97%      LSB: 0.44%      HSB: 4.79%      FSB: 0.35%
    SKIPGRAMS   SFS: 6.99%      LSS: 0.92%      HSS: 4.66%      FSS: 0.38%
    TRIGRAMS    ALT: 41.24%     ROL: 40.71%     ONE: 2.47%      RED: 1.66%

การใช้นิ้ว:

    LEFT        LI: 13.91%      LM: 20.17%      LR: 8.70%       LP: 3.05%
    RIGHT       RI: 13.12%      RM: 14.59%      RR: 10.60%      RP: 7.94%
    TOTAL               LH: 45.83%                      RH: 54.17%

ต้นฉบับสำหรับ copy/paste:

    q y o u - x l d w z
    c i e a , k h t n s
    ' / = . ; j m g p f
    r b v

### [Oxey's analyzer](https://oxey.dev/playground/index.html)

> **หมายเหตุ:** Analyzer นี้ยังไม่รองรับการวางตัวอักษรบนปุ่มนิ้วก้อย lateral ของแถวบ้าน เช่น CapsLock และ apostrophe ดังนั้นผลลัพธ์อาจไม่แม่นยำ เช่น SFB ที่นี่ถือว่า B และ V ถูกพิมพ์ด้วยนิ้วโป้งซ้าย ทั้งที่จริง B อยู่ที่นิ้วก้อยซ้าย และ V ที่นิ้วก้อยขวา

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/oxey.png)

สถิติโดยรวม:
* Sfb:              0.811%
* Dsfb:             6.286%
* Lsb:              0.372%
* Inrolls:          29.442%
* Outrolls:         15.841%
* Total Rolls:      45.283%
* Onehands:         2.348%
* Alternates:       31.877%
* Alternates (sfs): 7.284%
* Total Alternates: 39.161%
* Redirects:        3.864%
* BadRedirects:     1.002%
* Total Redirects:  4.866%
* Other:            8.341%
* Invalid:          0.001%

การใช้นิ้ว:

    finger 0:   3.63%   finger 9:       8.60%
    finger 1:   9.08%   finger 8:       10.65%
    finger 2:   19.30%  finger 7:       14.56%
    finger 3:   13.28%  finger 6:       12.33%

    มือซ้าย:   45.29%  มือขวา:        46.14%
    กลางซ้าย:  1.384%  กลางขวา:       1.189%

    ใช้ปุ่มแถวบ้าน: 56.37%

Sfb% ต่อแต่ละนิ้ว:

    finger 0:   0.011%  finger 9:       0.024%
    finger 1:   0.047%  finger 8:       0.100%
    finger 2:   0.122%  finger 7:       0.051%
    finger 3:   0.339%  finger 6:       0.114%

### การเปรียบเทียบ

> **หมายเหตุ:** Oxey's analyzer ยังไม่รองรับการวางตัวอักษรบนปุ่มนิ้วก้อย lateral ของแถวบ้าน เช่น CapsLock และ apostrophe ดังนั้นผลลัพธ์อาจไม่แม่นยำ เช่น SFB ที่นี่ถือว่า B และ V ถูกพิมพ์ด้วยนิ้วโป้งซ้าย ทั้งที่จริง B อยู่ที่นิ้วก้อยซ้าย และ V ที่นิ้วก้อยขวา
> ควรพิจารณา [ผลลัพธ์ของ Cyanophage analyzer](#cyanophage-analyzer) เพราะคำนึงถึงปุ่มนิ้วก้อย lateral และปุ่มตัวอักษรนิ้วโป้ง

[ชุมชน keyboard layout][rKL] มักแนะนำ [คู่มือและตารางเปรียบเทียบของ Pascal Getreuer][PGt] เป็นจุดเริ่มต้นสำหรับสำรวจเลย์เอาต์
และจะพบว่า Enthium อยู่ในกลุ่มที่ดีที่สุด (ทางสถิติ) ที่นั่น:

* 0.811% SFBs -- ได้ที่ 🥈 สอง รองจาก Focal
* 0.372% LSBs -- ได้ที่ 🥇 หนึ่ง ชนะทั้งตาราง!
* 45.283% rolls -- ชนะ Nerps, Gallium, MTGAP, Graphite, Dvorak, Halmak ฯลฯ
* 4.866% redirects -- ชนะ MTGAP, Sturdy, Recurva, APTv3, Canary, Colemak ฯลฯ
* 2.80% pinky off _ไม่รวม_ lateral -- ชนะ Graphite, Canary, Gallium, MTGAP ฯลฯ
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%)
* 5.35% pinky off _รวม_ lateral -- ชนะ Engram, Halmak; รองจากที่เหลือ
  * `Q` (0.10%) + `'` (0.48%) + `Z` (0.10%) + `F` (2.12%) + `B` (1.49%) + `V` (1.06%)

[rKL]: https://www.reddit.com/r/KeyboardLayouts/
[PGt]: https://getreuer.info/posts/keyboards/alt-layouts/index.html#which-alt-keyboard-layout-should-i-learn

เพื่อความสมบูรณ์ ฉันได้จัดตาราง [สถิติของเลย์เอาต์นี้และที่เกี่ยวข้อง](https://raw.githubusercontent.com/sunaku/enthium/main/stats/):

[cNT]: https://cyanophage.github.io/playground.html?layout=zwdlx-uoyq%5Csnthk%2Caeicbfpgmj%3B.%3D%2F%27vr&mode=ergo&lan=english
[cPM]: https://cyanophage.github.io/playground.html?layout=fpdlx%3Buoybzsnthk%2Caeicqvwgmj-.%27%3D%2F%5Cr&mode=ergo&lan=english
[cNG]: https://cyanophage.github.io/playground.html?layout=byou%27%3Bldwvzciea%2C.htsnqgxjk-%2Frmfp%5C%5E&mode=ergo&lan=english
[cDV]: https://cyanophage.github.io/playground.html?layout=%27%2C.pyfgcrl%2Faoeuidhtns-%3Bqjkxbmwvz%5C%5E&mode=ergo&lan=english
[cCD]: https://cyanophage.github.io/playground.html?layout=qwfpbjluy%3B-arstgmneio%27zxcdvkh%2C.%2F%5C%5E&mode=ergo&lan=english

| Analyzer   | ประเภท    | สถิติ               | [Enthium][cNT] | [Promethium][cPM] | [Engrammer][cNG] | [Dvorak][cDV] | [Colemak-DH][cCD] |
| ---------- | --------- | ------------------- | -------------- | ----------------- | ---------------- | ------------- | ----------------- |
| Oxey's     | Bigrams   | SFB                 | 0.811%         | 0.868%            | 1.511%           | 2.779%        | 1.367%            |
| Oxey's     | Bigrams   | DSFB                | 6.286%         | 6.761%            | 7.620%           | 6.979%        | 8.767%            |
| Oxey's     | Bigrams   | LSB                 | 0.372%         | 0.404%            | 0.671%           | 1.255%        | 1.975%            |
| Oxey's     | Trigrams  | Inrolls             | 29.442%        | 29.333%           | 28.273%          | 23.820%       | 25.173%           |
| Oxey's     | Trigrams  | Outrolls            | 15.841%        | 14.526%           | 14.050%          | 15.104%       | 20.940%           |
| Oxey's     | Trigrams  | Total Rolls         | 45.283%        | 43.858%           | 42.323%          | 38.924%       | 46.113%           |
| Oxey's     | Trigrams  | Onehands            | 2.348%         | 2.189%            | 2.146%           | 0.624%        | 2.484%            |
| Oxey's     | Trigrams  | Alternates          | 31.877%        | 33.770%           | 32.483%          | 35.769%       | 22.913%           |
| Oxey's     | Trigrams  | Alternates (SFS)    | 7.284%         | 8.205%            | 8.752%           | 8.787%        | 7.461%            |
| Oxey's     | Trigrams  | Total Alternates    | 39.161%        | 41.974%           | 41.235%          | 44.556%       | 30.375%           |
| Oxey's     | Trigrams  | Redirects           | 3.864%         | 2.273%            | 3.103%           | 2.639%        | 9.081%            |
| Oxey's     | Trigrams  | BadRedirects        | 1.002%         | 1.236%            | 1.386%           | 0.818%        | 1.498%            |
| Oxey's     | Trigrams  | Total Redirects     | 4.866%         | 3.509%            | 4.489%           | 3.458%        | 10.579%           |
| Oxey's     | Trigrams  | Other               | 8.341%         | 8.468%            | 9.806%           | 12.437%       | 9.202%            |
| Oxey's     | Trigrams  | Invalid             | 0.001%         | 0.001%            | 0.001%           | 0.001%        | 1.248%            |
| Oxey's     | Usage     | Finger 0            | 3.63%          | 9.56%             | 6.58%            | 8.50%         | 8.12%             |
| Oxey's     | Usage     | Finger 1            | 9.08%          | 10.65%            | 9.21%            | 8.72%         | 8.04%             |
| Oxey's     | Usage     | Finger 2            | 19.30%         | 14.56%            | 19.47%           | 12.99%        | 11.55%            |
| Oxey's     | Usage     | Finger 3            | 13.28%         | 12.33%            | 13.35%           | 14.95%        | 19.19%            |
| Oxey's     | Usage     | Finger 6            | 12.33%         | 13.28%            | 16.04%           | 16.33%        | 18.88%            |
| Oxey's     | Usage     | Finger 7            | 14.56%         | 19.77%            | 14.93%           | 13.73%        | 15.60%            |
| Oxey's     | Usage     | Finger 8            | 10.65%         | 9.01%             | 10.31%           | 13.84%        | 10.11%            |
| Oxey's     | Usage     | Finger 9            | 8.60%          | 4.62%             | 9.90%            | 10.59%        | 7.77%             |
| Oxey's     | Usage     | มือซ้าย            | 45.29%         | 47.10%            | 48.61%           | 45.16%        | 46.89%            |
| Oxey's     | Usage     | มือขวา             | 46.14%         | 46.68%            | 51.18%           | 54.49%        | 52.36%            |
| Oxey's     | Usage     | กลางซ้าย           | 1.384%         | 1.189%            | 1.765%           | 9.208%        | 4.592%            |
| Oxey's     | Usage     | กลางขวา            | 1.189%         | 1.384%            | 1.294%           | 7.257%        | 3.393%            |
| Oxey's     | Usage     | ใช้ปุ่มแถวบ้าน     | 56.37%         | 56.37%            | 56.37%           | 56.70%        | 62.31%            |
| Oxey's     | SFB%      | Finger 0            | 0.011%         | 0.028%            | 0.012%           | 0.020%        | 0.041%            |
| Oxey's     | SFB%      | Finger 1            | 0.047%         | 0.100%            | 0.089%           | 0.028%        | 0.047%            |
| Oxey's     | SFB%      | Finger 2            | 0.122%         | 0.051%            | 0.230%           | 0.253%        | 0.186%            |
| Oxey's     | SFB%      | Finger 3            | 0.339%         | 0.114%            | 0.591%           | 1.075%        | 0.219%            |
| Oxey's     | SFB%      | Finger 6            | 0.114%         | 0.339%            | 0.380%           | 0.433%        | 0.388%            |
| Oxey's     | SFB%      | Finger 7            | 0.051%         | 0.185%            | 0.053%           | 0.494%        | 0.341%            |
| Oxey's     | SFB%      | Finger 8            | 0.100%         | 0.040%            | 0.098%           | 0.256%        | 0.137%            |
| Oxey's     | SFB%      | Finger 9            | 0.024%         | 0.011%            | 0.058%           | 0.220%        | 0.007%            |
| KeySolve   | Bigrams   | SFB                 | 0.97%          | 0.94%             | 1.56%            | 2.62%         | 1.49%             |
| KeySolve   | Bigrams   | LSB                 | 0.44%          | 0.45%             | 0.98%            | 1.17%         | 2.21%             |
| KeySolve   | Bigrams   | HSB                 | 4.79%          | 6.04%             | 3.02%            | 6.11%         | 5.93%             |
| KeySolve   | Bigrams   | FSB                 | 0.35%          | 0.26%             | 0.30%            | 0.14%         | 0.37%             |
| KeySolve   | Skipgrams | SFS                 | 6.99%          | 7.02%             | 7.50%            | 7.00%         | 7.95%             |
| KeySolve   | Skipgrams | LSS                 | 0.92%          | 0.93%             | 1.34%            | 4.48%         | 1.75%             |
| KeySolve   | Skipgrams | HSS                 | 4.66%          | 6.11%             | 6.91%            | 8.56%         | 6.49%             |
| KeySolve   | Skipgrams | FSS                 | 0.38%          | 0.78%             | 0.81%            | 1.22%         | 0.78%             |
| KeySolve   | Trigrams  | ALT                 | 41.24%         | 40.37%            | 39.59%           | 41.70%        | 27.58%            |
| KeySolve   | Trigrams  | ROL                 | 40.71%         | 40.84%            | 39.35%           | 37.19%        | 42.78%            |
| KeySolve   | Trigrams  | ONE                 | 2.47%          | 2.66%             | 2.65%            | 0.43%         | 2.45%             |
| KeySolve   | Trigrams  | RED                 | 1.66%          | 1.78%             | 2.65%            | 2.25%         | 6.74%             |
| KeySolve   | Usage     | LI                  | 13.91%         | 13.91%            | 13.91%           | 14.56%        | 18.82%            |
| KeySolve   | Usage     | LM                  | 20.17%         | 20.92%            | 20.30%           | 13.96%        | 10.18%            |
| KeySolve   | Usage     | LR                  | 8.70%          | 8.70%             | 8.83%            | 9.55%         | 7.83%             |
| KeySolve   | Usage     | LP                  | 3.05%          | 3.64%             | 5.72%            | 8.24%         | 7.63%             |
| KeySolve   | Usage     | RI                  | 13.12%         | 13.12%            | 16.52%           | 16.90%        | 20.00%            |
| KeySolve   | Usage     | RM                  | 14.59%         | 14.59%            | 15.03%           | 13.35%        | 16.91%            |
| KeySolve   | Usage     | RR                  | 10.60%         | 10.60%            | 10.08%           | 13.36%        | 10.46%            |
| KeySolve   | Usage     | RP                  | 7.94%          | 8.95%             | 9.47%            | 10.08%        | 8.16%             |
| KeySolve   | Total     | LH                  | 45.83%         | 47.18%            | 48.75%           | 46.31%        | 44.46%            |
| KeySolve   | Total     | RH                  | 54.17%         | 52.82%            | 51.25%           | 53.69%        | 55.54%            |
| Cyanophage | Summary   | Total Word Effort   | 748.5          | 732.3             | 899.8            | 1185.5        | 1048.2            |
| Cyanophage | Summary   | Effort              | 432.54         | 398.07            | 457.44           | 769.78        | 535.05            |
| Cyanophage | Bigrams   | Same Finger Bigrams | 0.55%          | 0.58%             | 0.99%            | 1.87%         | 0.91%             |
| Cyanophage | Bigrams   | Skip Bigrams (2u)   | 0.29%          | 0.36%             | 0.39%            | 0.45%         | 0.41%             |
| Cyanophage | Bigrams   | Lat Stretch Bigrams | 0.23%          | 0.24%             | 0.41%            | 0.80%         | 1.27%             |
| Cyanophage | Bigrams   | Pinky/Ring Scissors | 0.34%          | 0.42%             | 0.71%            | 0.40%         | 0.65%             |
| Cyanophage | Trigrams  | Alt                 | 37.45%         | 36.98%            | 35.62%           | 39.08%        | 25.43%            |
| Cyanophage | Trigrams  | Alt SFS             | 5.10%          | 5.27%             | 5.93%            | 5.85%         | 5.47%             |
| Cyanophage | Trigrams  | Roll in             | 1.71%          | 1.37%             | 1.82%            | 0.86%         | 1.50%             |
| Cyanophage | Trigrams  | Roll out            | 0.31%          | 0.11%             | 0.29%            | 0.27%         | 0.98%             |
| Cyanophage | Trigrams  | Bigram roll in      | 29.02%         | 29.18%            | 28.14%           | 23.51%        | 25.18%            |
| Cyanophage | Trigrams  | Bigram roll out     | 14.67%         | 14.56%            | 14.03%           | 15.14%        | 21.55%            |
| Cyanophage | Trigrams  | Redirect            | 2.14%          | 2.03%             | 3.05%            | 2.57%         | 9.22%             |
| Cyanophage | Trigrams  | Weak redirect       | 1.32%          | 1.30%             | 1.40%            | 0.28%         | 1.52%             |
| Cyanophage | Trigrams  | Other               | 8.28%          | 9.20%             | 9.72%            | 12.44%        | 9.17%             |

## การติดตั้ง

### ตั้งค่าบน Linux

>*ตำนานสี:* QWERTY=ขาว; Engram=ทอง; Enthium=ฟ้า/เขียว; Quirks=ชมพู  
>![แสดงเลย์เอาต์นี้บนคีย์บอร์ดแถวเหลื่อม](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)

ติดตั้ง:

    cd linux/
    sudo make install
    echo Now restart your graphical session.

เปิดใช้งาน:

    setxkbmap -layout us    -variant enthium         # ใช้เลย์เอาต์เดียว ไม่สลับ
    setxkbmap -layout us,us -variant enthium,basic   # สลับเลย์เอาต์ได้

ซ่อมแซม (เช่น หากอัปเกรด XKB system-wide แล้วติดตั้งถูกรีเซ็ต):

    cd linux/
    sudo make reinstall
    echo Now restart your graphical session.

ถอนการติดตั้ง:

    cd linux/
    sudo make uninstall
    echo Now restart your graphical session.

### ตั้งค่าบน MacOS

#### การติดตั้ง

เพื่อใช้เลย์เอาต์บน MacOS ต้องติดตั้ง [Karabiner-Elements](https://karabiner-elements.pqrs.org/)

สามารถติดตั้งผ่าน [Homebrew](https://brew.sh/):

    brew install --cask karabiner-elements

หรือดาวน์โหลดจาก [เว็บไซต์ Karabiner-Elements](https://karabiner-elements.pqrs.org/)

เมื่อดาวน์โหลดแล้ว ให้ทำตามคำแนะนำใน [คู่มือการติดตั้ง](https://karabiner-elements.pqrs.org/docs/getting-started/installation/)

#### การปรับแต่งแบบซับซ้อน

เมื่อติดตั้งเสร็จแล้ว สามารถใช้ [ฟีเจอร์ complex modification](https://karabiner-elements.pqrs.org/docs/manual/configuration/configure-complex-modifications/) เพื่อ remap คีย์

enthium complex modification มีให้ที่ [นี่](https://ke-complex-modifications.pqrs.org/?q=enthium)

หากต้องการกลับไปใช้เลย์เอาต์พื้นฐาน ให้ลบ enthium complex modification ออก

#### การถอนการติดตั้ง

* Brew : `brew uninstall --cask karabiner-elements`
* Manual : ลบ `Karabiner-Elements.app` ออกจากโฟลเดอร์ Applications

## สัญญาอนุญาต

เผยแพร่ภายใต้เงื่อนไขเดียวกับซอร์สโค้ดของเลย์เอาต์ [Engram 2.0 ของ Arno]:

> MIT License
>
> Copyright 2022 Ricard Figueroa <https://github.com/rfiga>  
> Copyright 2021 Suraj Kurapati <https://github.com/sunaku>  
> Copyright 2021 Arno Klein <https://github.com/binarybottle>  
>
> Permission is hereby granted, free of charge, to any person obtaining a copy
> of this software and associated documentation files (the "Software"), to deal
> in the Software without restriction, including without limitation the rights
> to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
> copies of the Software, and to permit persons to whom the Software is
> furnished to do so, subject to the following conditions:
>
> The above copyright notice and this permission notice shall be included in
> all copies or substantial portions of the Software.
>
> THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
> IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
> FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
> AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
> LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
> OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
> SOFTWARE.

---------------------------------------------------------------------------
[Spare A Life]: https://sunaku.github.io/vegan-for-life.html
> ชอบงานของฉันไหม? 👍 กรุณา [ช่วยชีวิตสัตว์สักตัว] เป็นการขอบคุณ! 🐄🐖🐑🐔🐣🐟✨🙊✌  
> ทำไม? เพราะ 💕 จริยธรรม, สิ่งแวดล้อม 🌎, และสุขภาพ 💪; ดูรายละเอียดที่ลิงก์ข้างบน 🙇

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---