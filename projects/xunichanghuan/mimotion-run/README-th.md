# mimotion
![ 刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# ระบบเพิ่มจำนวนก้าวอัตโนมัติสำหรับ Mi Fit

> ระบบเพิ่มจำนวนก้าวอัตโนมัติสำหรับ Mi Fit

## คู่มือการติดตั้งผ่าน Github Actions

### 1. Fork โครงการนี้

### 2. ตั้งค่าบัญชีและรหัสผ่าน
# อัปเดตเมื่อ 20230224
เพิ่มตัวแปรชื่อ **CONFIG**: Settings-->Secrets-->New secret กำหนดค่าหลายบัญชีด้วยแม่แบบ json ด้านล่างนี้ รองรับอีเมลและเบอร์โทรศัพท์
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN ถ้าไม่มี ให้เว้นว่างไว้",
  "TG_USER_ID": "telegram TG_USER_ID ถ้าไม่มี ให้เว้นว่างไว้",
  "SKEY": "Coolpush skey ถ้าไม่มี ให้เว้นว่างไว้",
  "SCKEY": "server酱 sckey ถ้าไม่มี ให้เว้นว่างไว้",
  "POSITION": "เปิดใช้งานการแจ้งเตือนผ่าน WeCom หรือไม่ ถ้าไม่มี ให้เว้นว่างไว้",
  "CORPID": "ID องค์กร ดูได้ที่ WeCom ในข้อมูลบริษัท ถ้าไม่มี ให้เว้นว่างไว้",
  "CORPSECRET": "secret ของแอปที่สร้างเองใน WeCom แต่ละแอปจะมี secret เฉพาะ ถ้าไม่มี ให้เว้นว่างไว้",
  "AGENTID": "กรอก ID แอปที่สร้างเองใน WeCom เป็นตัวเลข ไม่ต้องใส่เครื่องหมายคำพูด ถ้าไม่มี ให้เว้นว่างไว้",
  "TOUSER": "ID สมาชิกที่รับข้อความ หลายคนใช้”&#166;”คั่น สูงสุด 1000 คน หรือใช้”@all”เพื่อส่งถึงทุกคน ถ้าไม่มี ให้เว้นว่างไว้",
  "TOPARTY": "ID แผนกที่รับข้อความ หลายแผนกใช้”&#166;”คั่น สูงสุด 100 แผนก หรือใช้”@all”เมื่อ touser เป็น”@all” ถ้าไม่มี ให้เว้นว่างไว้",
  "TOTAG": "ID แท็กที่รับข้อความ หลายแท็กใช้”&#166;”คั่น สูงสุด 100 แท็ก หรือใช้”@all”เมื่อ touser เป็น”@all” ถ้าไม่มี ให้เว้นว่างไว้",
  "OPEN_GET_WEATHER": "เปิดลดจำนวนก้าวตามสภาพอากาศหรือไม่ ถ้าไม่มี ให้เว้นว่างไว้",
  "AREA": "ตั้งค่าพื้นที่เพื่อดึงข้อมูลอากาศ (ต้องกรอกถ้าเปิดด้านบน) เช่น 北京 ถ้าไม่มี ให้เว้นว่างไว้",
  "QWEATHER": "ใส่ QWeather Private KEY ที่นี่ สมัครได้ที่ https://console.qweather.com/#/apps ถ้าไม่มี ให้เว้นว่างไว้",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "กรอกจำนวนก้าวสูงสุดของแต่ละบัญชี ดูตัวอย่างข้างบน",
      "min_step": "กรอกจำนวนก้าวขั้นต่ำของแต่ละบัญชี ดูตัวอย่างข้างบน",
      "password": "กรอกรหัสผ่านแต่ละบัญชี ดูตัวอย่างข้างบน",
      "user": "กรอกเบอร์โทรศัพท์แต่ละบัญชี ดูตัวอย่างข้างบน"
    }
  ]
}
```
> เพิ่มตัวแปรชื่อ **PAT**: Settings-->Secrets-->New secret

| Secrets |  รูปแบบ  |
| -------- | ----- |
| PAT |   **PAT** ที่นี่ต้องสมัครใหม่ เป็น github token ดูคู่มือได้ที่: https://www.jianshu.com/p/bb82b3ad1d11 , ต้องมีสิทธิ์ repo และ workflow จำเป็นต้องกรอกเพื่อป้องกันข้อผิดพลาดในการ git push |

**ตัวอย่าง CONFIG**
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "กรอกจำนวนก้าวสูงสุดของแต่ละบัญชี ดูตัวอย่างข้างบน",
      "min_step": "กรอกจำนวนก้าวขั้นต่ำของแต่ละบัญชี ดูตัวอย่างข้างบน",
      "password": "กรอกรหัสผ่านแต่ละบัญชี ดูตัวอย่างข้างบน",
      "user": "กรอกเบอร์โทรศัพท์แต่ละบัญชี ดูตัวอย่างข้างบน"
    }
  ]
}
```

### 3. กำหนดเวลาการทำงานเอง

แก้ไข **random_cron.sh**
เปลี่ยนเวลาที่ตรวจสอบในคำสั่ง **if** ให้เป็นเวลา UTC (เวลาปักกิ่ง -8 ชั่วโมง) เช่น เวลาปักกิ่ง 8 โมงเช้า คือ UTC 0 นาฬิกา เวลาที่ต้องการ -8 คือเวลา UTC



## หมายเหตุ

1. ทำงานวันละ 7 ครั้ง ควบคุมโดย random_cron.sh นาทีเป็นค่าสุ่ม

2. จำนวนบัญชีและรหัสผ่านต้องตรงกัน มิฉะนั้นจะใช้ไม่ได้!!!

3. เวลาที่ตั้งต้องเป็นเวลา UTC!

4. สมัคร server酱 ได้ที่ [คลิกที่นี่](https://sct.ftqq.com/)

5. หาก Alipay ไม่อัปเดตก้าว ให้ไปที่ Mi Fit->การตั้งค่า->บัญชี->ออกจากระบบ->ล้างข้อมูล แล้วเข้าสู่ระบบใหม่และเชื่อมโยงกับบุคคลที่สามใหม่

6. Mi Fit จะไม่อัปเดตก้าว มีเฉพาะบัญชีที่เชื่อมโยงเท่านั้นที่จะซิงค์!!!!!!

7. โปรด Fork [branch หลัก](https://github.com/xunichanghuan/mimotion-run/) เพื่อป้องกัน bug ที่ไม่จำเป็น

8. หมายเหตุ บัญชีที่ใช้ไม่ใช่ [Mi Account] แต่เป็นบัญชี [Mi Fit]

## จำนวน Star ในอดีต

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---