# Dana wallet

Dana คือแอป flutter ที่ใช้สำหรับรับบริจาคบิตคอยน์ โดยใช้ silent payments โปรโตคอลการชำระเงินแบบสถิตใหม่ เพื่อรับบริจาคพร้อมกับรักษาความเป็นส่วนตัวบนบล็อกเชน

## ทดลองใช้ Dana wallet

**Dana wallet ยังอยู่ในช่วงทดลองใช้งาน เราแนะนำให้ใช้บน testnet/signet เท่านั้น หากคุณต้องการทดสอบบน mainnet จริงๆ ให้ใช้เงินที่คุณพร้อมจะเสียเท่านั้น เราไม่รับผิดชอบกรณีเงินสูญหาย**

เรากำลังพิจารณาที่จะปล่อย Dana wallet บนแอปสโตร์ยอดนิยมเมื่อแอปมีความเสถียรมากขึ้น

ในระหว่างนี้ มีสองวิธีในการทดลองใช้ Dana wallet:

- ดาวน์โหลดไฟล์ APK ล่าสุดของ Dana wallet จาก [หน้าปล่อยเวอร์ชัน](https://github.com/cygnet3/danawallet/releases)
- ดาวน์โหลด Dana wallet โดยใช้ [ที่เก็บซอฟต์แวร์ F-Droid ของเรา](https://fdroid.silentpayments.dev/fdroid/repo)

### ดาวน์โหลดโดยใช้ F-Droid

เราแนะนำตัวเลือก F-Droid เนื่องจากรองรับการอัปเดตอัตโนมัติ และต้องตั้งค่าเพียงครั้งเดียว

- เปิด F-Droid บนโทรศัพท์ Android ของคุณ
- ไปที่ 'Settings'
- ในส่วน 'My Apps' คลิกที่ 'Repositories'
- เพิ่มที่เก็บใหม่โดยคลิกที่ไอคอน '+'
- สแกน QR โค้ดบนหน้านี้: https://fdroid.silentpayments.dev/fdroid/repo

ตอนนี้คุณได้เพิ่มที่เก็บซอฟต์แวร์ของเราแล้ว เพื่อดาวน์โหลดแอป ให้ค้นหา 'Dana Wallet' ในส่วนร้านค้าแอปของ F-Droid (คุณอาจต้องรีเฟรชรายการแอปก่อน โดยการปัดหน้าจอลงบนหน้าร้านค้า F-Droid)

## การสร้าง Dana wallet จากซอร์สโค้ด

ด้านล่างเป็นคำแนะนำสำหรับการสร้าง Dana wallet จากซอร์สโค้ด ซึ่งแนะนำสำหรับผู้ที่ต้องการช่วยพัฒนา Dana wallet

### สร้างสำหรับ linux (เดสก์ท็อป)

การสร้างสำหรับ linux ไม่ต้องใช้ความพยายามเพิ่มเติม เพียงแค่รันคำสั่ง

```
flutter run
```

วิธีนี้อาจใช้ได้กับแพลตฟอร์มอื่นๆ (macOS, Windows) แต่ยังไม่ได้ทดสอบ

### สร้างสำหรับ android

การสร้างสำหรับอุปกรณ์ android ต้องเตรียมการล่วงหน้าเพื่อสร้างไบนารีสำหรับสถาปัตยกรรมนี้

อันดับแรก คุณต้องติดตั้ง `cargo-ndk` และอาจต้องเพิ่ม toolchains ที่ต้องการ:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

หลังจากติดตั้งแล้ว ให้เข้าไปที่โฟลเดอร์ rust และรันคำสั่ง `just build-android`

```
cd rust
just build-android
```

ถ้าคุณยังไม่มี `just` ติดตั้ง คุณสามารถคัดลอกคำสั่งจากไฟล์ `justfile` มาใช้ได้
คำสั่งนี้จะสร้างไฟล์ไบนารี

ถัดไป เชื่อมต่อโทรศัพท์และเปิดโหมดดีบัก
ตรวจสอบว่าโทรศัพท์เชื่อมต่ออยู่โดยรัน

```
flutter devices
```

สุดท้าย เพื่อสร้างและติดตั้งแอปบนอุปกรณ์ android ของคุณ:

```
flutter run
```

## บริจาคให้ Dana

คุณสามารถบริจาคให้ Dana wallet โดยใช้ที่อยู่ของเรา:

> ₿donate@danawallet.app

หรือใช้ที่อยู่ silent payment ต่อไปนี้:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---