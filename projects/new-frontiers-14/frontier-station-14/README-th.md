<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station เป็นฟอร์กของ [Space Station 14](https://github.com/space-wizards/space-station-14) ที่ทำงานบนเอนจิน [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) ซึ่งเขียนด้วยภาษา C#.

นี่คือรีโพหลักสำหรับ Frontier Station

หากคุณต้องการโฮสต์หรือสร้างเนื้อหาสำหรับ Frontier Station นี่คือรีโพที่คุณต้องใช้ โดยจะประกอบด้วยทั้ง RobustToolbox และคอนเทนต์แพ็กสำหรับการพัฒนาเนื้อหาใหม่

## ลิงก์

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## เอกสาร/วิกิ

[วิกิของเรา](https://frontierstation.wiki.gg/) มีเอกสารเกี่ยวกับเนื้อหาของ Frontier Station

## การร่วมพัฒนา

เรายินดีรับการมีส่วนร่วมจากทุกคน หากต้องการช่วยเหลือเข้ามาที่ Discord ของเราได้เลย เรามี [รายการไอเดีย](https://discord.com/channels/1123826877245694004/1127017858833068114) ที่สามารถทำได้และทุกคนสามารถเลือกไปทำได้ อย่ากลัวที่จะขอความช่วยเหลือด้วย!

ขณะนี้เราไม่รับการแปลเกมในรีโพหลักของเรา หากคุณต้องการแปลเกมเป็นภาษาอื่น แนะนำให้สร้างฟอร์กหรือร่วมพัฒนากับฟอร์กนั้น

หากคุณมีการร่วมพัฒนา กรุณาอ่านส่วน markers ใน [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md)  
การเปลี่ยนแปลงใดๆ ที่ทำกับไฟล์ที่มาจาก upstream ของเราควรมีการมาร์กตามที่ระบุไว้ในนั้น

## การคอมไพล์

1. โคลนรีโพนี้:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. ไปที่โฟลเดอร์โปรเจ็กต์และรัน `RUN_THIS.py` เพื่อ initialize ซับโมดูลและโหลดเอนจิน:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. คอมไพล์ซอลูชัน:

Build server ด้วย `dotnet build`.

[คำแนะนำโดยละเอียดเกี่ยวกับการคอมไพล์โปรเจ็กต์](https://docs.spacestation14.com/en/general-development/setup.html)

## ใบอนุญาต

เนื้อหาที่ถูกเพิ่มเข้ามาหลัง commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 จะอยู่ภายใต้สัญญาอนุญาต GNU Affero General Public License version 3.0 เว้นแต่จะระบุไว้เป็นอย่างอื่น (ดู Attributions ด้านล่าง) ดูได้ที่ `LICENSE-AGPLv3.txt`  
เนื้อหาที่ถูกเพิ่มเข้ามาก่อน commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 จะอยู่ภายใต้สัญญาอนุญาต MIT เว้นแต่จะระบุไว้เป็นอย่างอื่น ดูได้ที่ `LICENSE-MIT.txt`

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) ถูก push เมื่อวันที่ 1 กรกฎาคม 2024 เวลา 16:04 UTC

ไฟล์แอสเซ็ตส่วนใหญ่จะใช้สัญญาอนุญาต [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) เว้นแต่จะระบุไว้เป็นอย่างอื่น โดยแต่ละไฟล์จะระบุใบอนุญาตและลิขสิทธิ์ไว้ในไฟล์ metadata ตัวอย่างเช่น [metadata สำหรับ crowbar](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json)

โปรดทราบว่าแอสเซ็ตบางส่วนอาจใช้สัญญาอนุญาตแบบไม่เชิงพาณิชย์ [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) หรือสัญญาอนุญาตที่คล้ายกัน และจะต้องถูกลบออกหากคุณต้องการนำโปรเจกต์นี้ไปใช้เชิงพาณิชย์

## การให้เครดิต (Attributions)

เมื่อเราดึงเนื้อหาจากฟอร์กอื่น เราจะจัดเก็บเนื้อหานั้นไว้ใน subfolder เฉพาะของแต่ละ repo เพื่อให้ง่ายต่อการติดตามเครดิตและลดปัญหา merge conflict

เนื้อหาภายใต้ subdirectory เหล่านี้มีต้นกำเนิดจากแต่ละฟอร์กและอาจมีการแก้ไข โดยการแก้ไขจะแสดงด้วยคอมเมนต์รอบบรรทัดที่ถูกแก้ไข

| Subdirectory | ชื่อฟอร์ก | ที่อยู่รีโพ | ใบอนุญาต |
|--------------|-----------|-----------------|---------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

รีโพเพิ่มเติมที่เราได้นำฟีเจอร์มาใช้งานโดยไม่มี subdirectory แสดงด้านล่าง

| ชื่อฟอร์ก | ที่อยู่รีโพ | ใบอนุญาต |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---