
#### Dir

คำสั่ง `dir` (มีชื่อเรียกอื่นว่า `files`, `directory`) ช่วยให้คุณสามารถสแกนไดเรกทอรีและไฟล์ต่างๆ ได้ ตัวอย่าง: `gitleaks dir -v path_to_directory_or_file`
หากไม่มีการระบุเป้าหมายเป็นอาร์กิวเมนต์แบบตำแหน่ง gitleaks จะทำการสแกนไดเรกทอรีที่ทำงานปัจจุบัน

#### Stdin

คุณยังสามารถส่งข้อมูลสตรีมไปยัง gitleaks ได้ด้วยคำสั่ง `stdin` ตัวอย่าง: `cat some_file | gitleaks -v stdin`

### การสร้าง baseline

เมื่อสแกนรีโพสิทอรีขนาดใหญ่หรือรีโพสิทอรีที่มีประวัติยาวนาน การใช้ baseline อาจสะดวก เมื่อใช้ baseline,
gitleaks จะไม่สนใจผลการค้นหาที่เก่ากว่าใดๆ ที่ปรากฏอยู่ใน baseline baseline สามารถเป็นรายงาน gitleaks ใดๆ ก็ได้ ในการสร้างรายงาน gitleaks ให้รัน gitleaks ด้วยพารามิเตอร์ `--report-path`

```
gitleaks git --report-path gitleaks-report.json # รายงานจะถูกบันทึกไว้ในไฟล์ชื่อ gitleaks-report.json
```

เมื่อสร้าง baseline แล้ว baseline นี้สามารถนำไปใช้เมื่อรันคำสั่ง detect อีกครั้ง:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

หลังจากรันคำสั่ง detect พร้อมกับพารามิเตอร์ --baseline-path เอาท์พุตรายงาน (findings.json) จะมีเฉพาะปัญหาใหม่เท่านั้น

## Pre-Commit hook

คุณสามารถรัน Gitleaks เป็น pre-commit hook ได้โดยคัดลอกสคริปต์ตัวอย่าง `pre-commit.py` ไปยัง
ไดเรกทอรี `.git/hooks/` ของคุณ

## โหลดคอนฟิกูเรชัน

ลำดับความสำคัญคือ:

1. ตัวเลือก `--config/-c`:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. ตัวแปรสภาพแวดล้อม `GITLEAKS_CONFIG` พร้อม path ของไฟล์:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. ตัวแปรสภาพแวดล้อม `GITLEAKS_CONFIG_TOML` พร้อมเนื้อหาไฟล์:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. ไฟล์ `.gitleaks.toml` ภายใน path เป้าหมาย:
      ```bash
      gitleaks git .
      ```

ถ้าไม่มีการใช้ตัวเลือกทั้งสี่ข้อ gitleaks จะใช้คอนฟิกเริ่มต้น

## การตั้งค่า

Gitleaks มีรูปแบบคอนฟิกูเรชันที่คุณสามารถใช้เขียนกฎการตรวจจับความลับของคุณเองได้:

```toml
# ชื่อเรื่องสำหรับไฟล์คอนฟิกูเรชัน gitleaks
title = "Custom Gitleaks configuration"

# โดยพื้นฐานแล้วคุณมีสองทางเลือกสำหรับคอนฟิกูเรชันของคุณเอง:
#
# 1. กำหนดคอนฟิกูเรชันของคุณเอง โดยไม่ใช้กฎเริ่มต้น
#
#    ใช้เช่น คอนฟิกูเรชันเริ่มต้นเป็นจุดเริ่มต้น:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. ขยายคอนฟิกูเรชัน โดยกฎจะถูกเขียนทับหรือขยายเพิ่ม
#
#    เมื่อคุณขยายคอนฟิกูเรชัน กฎที่ขยายจะมีลำดับความสำคัญเหนือกฎเริ่มต้น กล่าวคือ หากมีกฎซ้ำกันในทั้งคอนฟิกูเรชันที่ขยายและคอนฟิกเริ่มต้น กฎหรือแอตทริบิวต์ที่ขยายจะเขียนทับกฎเริ่มต้น
#    อีกเรื่องที่ต้องรู้เกี่ยวกับการขยายคอนฟิกูเรชันคือคุณสามารถเชื่อมโยงไฟล์คอนฟิกูเรชันหลายไฟล์เข้าด้วยกันได้ลึกสูงสุด 2 ระดับ อาร์เรย์ allowlist จะถูกผนวกและอาจมีรายการซ้ำ

# useDefault และ path ไม่สามารถใช้ร่วมกันได้ ต้องเลือกอย่างใดอย่างหนึ่ง
[extend]
# useDefault จะขยายคอนฟิก gitleaks เริ่มต้นที่ฝังในไบนารี
# เวอร์ชันล่าสุดอยู่ที่:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# หรือคุณสามารถระบุ path ไปยังคอนฟิกูเรชันที่ต้องการขยาย
# path จะสัมพันธ์กับที่ที่ gitleaks ถูกเรียกใช้
# ไม่ใช่ตำแหน่งของ base config
# path = "common_config.toml"
# หากมีกฎที่คุณไม่ต้องการสืบทอด ให้ระบุที่นี่
disabledRules = [ "generic-api-key"]

# อาร์เรย์ของตารางที่มีข้อมูลในการกำหนดวิธีการตรวจจับความลับ
[[rules]]
# ตัวระบุที่ไม่ซ้ำกันสำหรับกฎนี้
id = "awesome-rule-1"

# คำอธิบายสั้นๆ สำหรับกฎนี้
description = "awesome rule 1"

# Regular expression ของ Golang ที่ใช้ตรวจจับความลับ หมายเหตุ Regex engine ของ Golang
# ไม่รองรับ lookaheads
regex = '''one-go-style-regex-for-this-rule'''

# Int ที่ใช้ในการดึงความลับจากการจับคู่ regex และใช้เป็นกลุ่มที่จะถูกตรวจสอบ entropy หากตั้งค่า `entropy`
secretGroup = 3

# Float ที่ระบุ entropy ขั้นต่ำแบบ shannon ที่กลุ่ม regex ต้องมีเพื่อจะถือว่าเป็นความลับ
entropy = 3.5

# Regular expression ของ Golang ที่ใช้จับคู่ path สามารถใช้เป็นกฎเดี่ยว หรือใช้
# ร่วมกับ `regex` ที่ถูกต้อง
path = '''a-file-path-regex'''

# Keywords ใช้สำหรับการกรองเบื้องต้นก่อน regex กฎที่มี
# keyword จะทำการเปรียบเทียบ string อย่างรวดเร็วเพื่อให้แน่ใจว่า
# มี keyword(s) อยู่ในเนื้อหาที่ถูกสแกน ค่านี้ควรเป็น
# ส่วนหนึ่งของ identifier หรือ string เฉพาะที่เป็นเอกลักษณ์ของ regex ในกฎ
# (เริ่มใช้ใน v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# อาร์เรย์ของ string ที่ใช้เพื่อวัตถุประสงค์ในการ metadata และรายงาน
tags = ["tag","another tag"]

    # ⚠️ ใน v8.21.0 `[rules.allowlist]` ถูกแทนที่ด้วย `[[rules.allowlists]]`
    # การเปลี่ยนแปลงนี้สามารถใช้ร่วมกับของเดิมได้: `[rules.allowlist]` ยังสามารถใช้งานได้
    #
    # คุณสามารถกำหนด allowlists หลายรายการสำหรับกฎเพื่อลด false positive
    # ผลลัพธ์จะถูกละเว้นหาก _ANY_ `[[rules.allowlists]]` ตรงตามเงื่อนไข
    [[rules.allowlists]]
    description = "ignore commit A"
    # หากกำหนดหลายเงื่อนไข ค่าเริ่มต้นคือ "OR"
    # เช่นนี้จะจับคู่ |commits| OR |paths| OR |stopwords|
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # หมายเหตุ: stopwords จะตรวจสอบ secret ที่ถูกดึงออกมา ไม่ใช่ regex match ทั้งหมด
    # แบบที่ 'regexes' ทำ (stopwords เริ่มใช้ใน 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # เงื่อนไข "AND" ใช้เพื่อให้แน่ใจว่าทุกเงื่อนไขตรงกัน
    # เช่นนี้จะตรงหาก |regexes| AND |paths| ถูกต้องทั้งสอง
    condition = "AND"
    # หมายเหตุ: |regexes| จะตรวจสอบ _Secret_ ใน finding เป็นค่าเริ่มต้น
    # ค่าที่ยอมรับสำหรับ |regexTarget| ได้แก่ "secret" (ค่าเริ่มต้น), "match", และ "line"
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# คุณสามารถขยายกฎเฉพาะจาก config เริ่มต้น เช่น gitlab-pat
# หากคุณกำหนด prefix ของ token เองใน GitLab instance ของคุณ
[[rules]]
id = "gitlab-pat"
# แอตทริบิวต์อื่นๆ ทั้งหมดจะสืบทอดจากกฎเริ่มต้น

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ ใน v8.25.0 `[allowlist]` ถูกแทนที่ด้วย `[[allowlists]]`
#
# global allowlists มีลำดับความสำคัญสูงกว่า allowlists เฉพาะกฎ
# ถ้า commit ที่ระบุใน `commits` พบในระหว่างสแกน commit นั้นจะถูกข้ามและจะไม่ตรวจจับ secret ใดๆ ใน commit นั้น เช่นเดียวกับ regexes และ paths
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# หมายเหตุ: (global) regexTarget จะตรวจสอบ _Secret_ ใน finding เป็นค่าเริ่มต้น
# ค่าที่รับได้สำหรับ regexTarget คือ "match" และ "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# หมายเหตุ: stopwords จะตรวจสอบ secret ที่ถูกดึงออกมา ไม่ใช่ regex match ทั้งหมด
# แบบที่ 'regexes' ทำ (stopwords เริ่มใช้ใน 8.8.0)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ ในเวอร์ชัน v8.25.0, `[[allowlists]]` มีฟิลด์ใหม่ชื่อ |targetRules|.
#
# สามารถกำหนด allowlists ทั่วไปเพียงครั้งเดียวและนำไปใช้กับกฎหลายข้อโดยใช้ |targetRules|.
# สิ่งนี้จะทำงานเฉพาะกับกฎที่ระบุเท่านั้น ไม่ใช่ทั่วโลก
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "ทรัพยากรทดสอบของเราทำให้เกิดผลบวกเทียมในกฎบางข้อ"
paths = ['''tests/expected/._\.json$''']
```

ดูตัวอย่างเพิ่มเติมได้ที่ [gitleaks config เริ่มต้น](https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml) หรือดู [แนวทางการมีส่วนร่วม](https://github.com/gitleaks/gitleaks/blob/master/CONTRIBUTING.md) หากคุณต้องการมีส่วนร่วมกับการตั้งค่าเริ่มต้น นอกจากนี้คุณสามารถอ่าน [บล็อกโพสต์ gitleaks นี้](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) ที่ครอบคลุมตัวอย่างการตั้งค่าขั้นสูง

### การตั้งค่าเพิ่มเติม

#### gitleaks:allow

หากคุณจงใจ commit รหัสลับสำหรับทดสอบที่ gitleaks จะตรวจจับได้ คุณสามารถเพิ่มคอมเมนต์ `gitleaks:allow` ในบรรทัดนั้นเพื่อสั่งให้ gitleaks
ละเว้นรหัสลับนั้น เช่น:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

คุณสามารถละเว้นผลการตรวจจับบางรายการโดยสร้างไฟล์ `.gitleaksignore` ที่ root ของ repo ในเวอร์ชัน v8.10.0 Gitleaks เพิ่มค่า `Fingerprint` ในรายงานของ Gitleaks แต่ละการรั่วไหลหรือการตรวจจับจะมี Fingerprint ที่ระบุรหัสลับนั้นอย่างเฉพาะเจาะจง ให้นำ fingerprint นี้ไปใส่ในไฟล์ `.gitleaksignore` เพื่อข้ามการตรวจจับรหัสลับนั้นโดยเฉพาะ ดูตัวอย่างที่ [.gitleaksignore ของ Gitleaks](https://github.com/gitleaks/gitleaks/blob/master/.gitleaksignore) หมายเหตุ: ฟีเจอร์นี้ยังเป็น experimental และอาจมีการเปลี่ยนแปลงในอนาคต

#### การถอดรหัส (Decoding)

บางครั้งรหัสลับจะถูกเข้ารหัสในรูปแบบที่ทำให้ค้นหาด้วย regex ได้ยาก
ตอนนี้คุณสามารถสั่งให้ gitleaks ค้นหาและถอดรหัสข้อความที่ถูกเข้ารหัสโดยอัตโนมัติได้ โดยใช้ flag `--max-decode-depth` เพื่อเปิดใช้งานฟีเจอร์นี้ (ค่าดีฟอลต์ "0" หมายถึงฟีเจอร์นี้ถูกปิดไว้โดยค่าเริ่มต้น)

รองรับการถอดรหัสแบบ recursive เนื่องจากข้อความที่ถอดรหัสแล้ว อาจมีข้อความเข้ารหัสซ้อนอยู่ Flag `--max-decode-depth` จะกำหนดขีดจำกัดของการวนซ้ำ การวนซ้ำจะหยุดเมื่อไม่มีข้อความเข้ารหัสใหม่ให้ถอดรหัสอีก ดังนั้นการตั้งค่าขีดจำกัดสูงมากก็ไม่ได้หมายความว่าจะวนซ้ำถึงขนาดนั้น จะวนซ้ำเท่าที่จำเป็นต่อการถอดรหัสเท่านั้น โดยรวมแล้ว การถอดรหัสจะเพิ่มเวลาในการสแกนเพียงเล็กน้อย

ผลการตรวจจับสำหรับข้อความที่ถูกเข้ารหัสจะแตกต่างจากผลการตรวจจับปกติในลักษณะดังนี้:

- ตำแหน่งจะชี้ขอบเขตของข้อความที่ถูกเข้ารหัส
  - หากกฎตรวจจับได้ด้านนอกข้อความเข้ารหัส ขอบเขตจะถูกปรับเพื่อรวมส่วนนั้นด้วย
- Match และ Secret จะมีค่าเป็นข้อความที่ถอดรหัสแล้ว
- จะมี tag เพิ่มเติม 2 อันคือ `decoded:<encoding>` และ `decode-depth:<depth>`

รูปแบบการเข้ารหัสที่รองรับในปัจจุบัน:

- **percent** - ค่าที่เข้ารหัสแบบ percent ของ ASCII ที่พิมพ์ได้ทั้งหมด
- **hex** - ค่าที่เข้ารหัสแบบ hex ของ ASCII ที่พิมพ์ได้ทั้งหมด ความยาว ≥ 32 ตัวอักษร
- **base64** - ค่าที่เข้ารหัสแบบ base64 ของ ASCII ที่พิมพ์ได้ทั้งหมด ความยาว ≥ 16 ตัวอักษร

#### การสแกนไฟล์บีบอัด (Archive Scanning)

บางครั้งรหัสลับจะถูกบรรจุอยู่ในไฟล์บีบอัด เช่น zip หรือ tarball
ซึ่งทำให้ตรวจจับได้ยาก ตอนนี้คุณสามารถสั่งให้ gitleaks แตกไฟล์และสแกนเนื้อหาของไฟล์บีบอัดโดยอัตโนมัติได้ โดยใช้ flag `--max-archive-depth`
เพื่อเปิดฟีเจอร์นี้ ทั้งสำหรับประเภทการสแกน `dir` และ `git` ค่าเริ่มต้น "0" หมายถึงฟีเจอร์นี้ถูกปิดอยู่

รองรับการสแกนแบบ recursive เนื่องจากไฟล์บีบอัดอาจมีไฟล์บีบอัดซ้อนอยู่ Flag `--max-archive-depth` จะกำหนดขีดจำกัดของการวนซ้ำ การวนซ้ำจะหยุดเมื่อไม่มีไฟล์บีบอัดใหม่ให้แตกไฟล์อีก ดังนั้นการตั้งค่าขีดจำกัดสูงมากก็แค่เพิ่มความลึกสูงสุดที่เป็นไปได้ จะวนซ้ำเท่าที่จำเป็นเท่านั้น

ผลการตรวจจับรหัสลับที่อยู่ในไฟล์บีบอัดจะรวม path ไปยังไฟล์ภายในด้วย โดย path ชั้นในจะแยกด้วย `!`

ตัวอย่างผลการตรวจจับ (ย่อเพื่อความกระชับ):

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

หมายความว่าตรวจพบรหัสลับในบรรทัดที่ 4 ของ `files/.env.prod` ซึ่งอยู่ใน
`archives/files.tar` ซึ่งอยู่ใน `testdata/archives/nested.tar.gz`

รูปแบบที่รองรับในปัจจุบัน:

[รูปแบบการบีบอัด](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
และ [รูปแบบไฟล์บีบอัด](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
ที่รองรับโดย [archives package ของ mholt](https://github.com/mholt/archives)
ได้รับการสนับสนุน

#### การออกรายงาน (Reporting)

Gitleaks มีระบบรองรับรูปแบบรายงานในตัวหลายแบบ: [`json`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/json_simple.json), [`csv`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/junit_simple.xml), และ [`sarif`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/sarif_simple.sarif)

หากไม่มีรูปแบบใดตรงกับความต้องการ คุณสามารถสร้างรูปแบบรายงานเองได้ด้วย [ไฟล์ Go `text/template` .tmpl](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) และใช้ flag `--report-template` โดย template สามารถใช้ [ฟีเจอร์เพิ่มเติมจากไลบรารี `Masterminds/sprig`](https://masterminds.github.io/sprig/)

ตัวอย่างเช่น template ต่อไปนี้ให้ออกผลลัพธ์ JSON แบบกำหนดเอง:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

วิธีใช้งาน:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## ผู้สนับสนุน (Sponsorships)

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## รหัสออก (Exit Codes)

คุณสามารถตั้งค่ารหัสออกเองเมื่อพบการรั่วไหลได้ด้วย flag --exit-code โดยค่าดีฟอลต์ของรหัสออกมีดังนี้:

```
0 - ไม่พบการรั่วไหล
1 - พบการรั่วไหลหรือข้อผิดพลาด
126 - flag ไม่รู้จัก
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---