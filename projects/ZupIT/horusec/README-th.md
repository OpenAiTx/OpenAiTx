<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="version">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="activity">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="contributors">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="security">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="coverage">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="build">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="license">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **สารบัญ**
### 1. [**เกี่ยวกับ**](#about)
### 2. [**เริ่มต้นใช้งาน**](#getting-started)
>#### 2.1.   [**ข้อกำหนด**](#requirements)
>#### 2.2.  [**การติดตั้ง**](#installing-horusec)
### 3. [**วิธีใช้งาน**](#usage)
>#### 3.1. [**การใช้งาน CLI**](#cli-usage)
>#### 3.2. [**การใช้งาน Docker**](#using-docker)
>#### 3.3. [**เวอร์ชันเก่า**](#older-versions)
>#### 3.4. [**การใช้ Horusec-Web application**](#using-horusec-web-application)
>#### 3.5.  [**การใช้ Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**การใช้ Pipeline**](#using-the-pipeline)
### 4. [**เอกสาร**](#documentation)       
### 5. [**แผนงาน**](#roadmap)
### 6. [**ร่วมพัฒนา**](#contributing)
### 7. [**จรรยาบรรณโค้ด**](#code-of-conduct)
### 8. [**ไลเซนส์**](#license)
### 9. [**ชุมชน**](#community)



<br>
<br>
<br>

# **เกี่ยวกับ**
Horusec เป็นเครื่องมือโอเพ่นซอร์สที่ใช้วิเคราะห์โค้ดแบบสถิติเพื่อค้นหาช่องโหว่ด้านความปลอดภัยระหว่างกระบวนการพัฒนา ปัจจุบันรองรับภาษาสำหรับการวิเคราะห์ ได้แก่ C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx 
เครื่องมือนี้มีตัวเลือกในการค้นหาการรั่วไหลของคีย์และช่องโหว่ในไฟล์โปรเจกต์ทั้งหมดของคุณ รวมถึงในประวัติ Git ด้วย Horusec สามารถใช้ได้ทั้งโดยนักพัฒนาผ่าน CLI และโดยทีม DevSecOps บนแพลตฟอร์ม CI /CD 

ดูรายละเอียดเครื่องมือและภาษาทั้งหมดที่ Horusec รองรับได้ที่ [**เอกสาร**](https://docs.horusec.io/docs/overview/)

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **ดูตัวอย่าง Output:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **เริ่มต้นใช้งาน**

## **ข้อกำหนด**

- Docker

คุณจำเป็นต้องติดตั้ง Docker ในเครื่องของคุณเพื่อใช้งาน Horusec พร้อมกับเครื่องมือทั้งหมดที่เราใช้
หากคุณไม่มี Docker เรามี [**flag**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` เพื่อปิดการใช้งาน dependency นี้ แต่จะทำให้พลังการวิเคราะห์ลดลงมาก 
เราขอแนะนำให้ใช้งานร่วมกับ Docker

หากคุณเปิดใช้งาน commit authors `-G true` ก็ต้องมี dependency ของ `git` ด้วยเช่นกัน

## **การติดตั้ง Horusec**
### **Mac หรือ Linux**
```
make install
```

หรือ

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **ตรวจสอบการติดตั้ง**
```bash
horusec version
```

### **Windows**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **ตรวจสอบการติดตั้ง**
```bash
./horusec.exe version
```

### **และอื่นๆ**

- คุณสามารถดู binary ทั้งหมดพร้อมเวอร์ชันได้ที่ [**releases page**](https://github.com/ZupIT/horusec/releases)

- ดูรายละเอียดเพิ่มเติมเกี่ยวกับวิธีการติดตั้งได้ที่ [**เอกสาร**](https://docs.horusec.io/docs/cli/installation) 


## **วิธีใช้งาน**
### **การใช้งาน CLI**
ในการใช้ horusec-cli เพื่อตรวจสอบช่องโหว่ของแอปพลิเคชัน ให้ใช้คำสั่งนี้:
```bash
horusec start -p .
```
> เมื่อ horusec เริ่มการวิเคราะห์ จะสร้างโฟลเดอร์ชื่อ **`.horusec`** โฟลเดอร์นี้จะไม่เปลี่ยนแปลงโค้ดของคุณ เราแนะนำให้เพิ่มบรรทัด **`.horusec`** ในไฟล์ **`.gitignore`** เพื่อไม่ให้โฟลเดอร์นี้ถูกส่งขึ้น git server

### **การใช้งาน Docker**
สามารถใช้ Horusec ผ่าน docker image **`horuszup/horusec-cli:latest`** ได้เช่นกัน

เรียกใช้งานด้วยคำสั่งนี้:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- เราสร้าง volume ที่มีโปรเจกต์ `-v $(pwd):/src`

เมื่อใช้ docker image จะมี 2 path ที่โปรเจกต์สามารถเข้าถึงได้

flag `-p` คือ path โปรเจกต์ภายใน container ในตัวอย่างนี้คือ `/src`
flag `-P` คือ path โปรเจกต์ภายนอก container ในตัวอย่างคือ `$(pwd)`
และต้องใช้ path นี้สำหรับการ mount volume `-v $(pwd):/src` ด้วย

### **เวอร์ชันเก่า**

Horusec v1 ยังสามารถใช้งานได้

**คำเตือน:** endpoint ของ v1 จะถูกยกเลิก กรุณาอัปเกรด CLI ของคุณเป็น v2 ดูรายละเอียดเพิ่มเติมได้ที่ [**เอกสาร**](https://docs.horusec.io/docs/migrate-v1-to-v2/) 

### **Mac หรือ Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- binary เวอร์ชันเก่าสามารถหาได้ที่ endpoint นี้ รวมถึงเวอร์ชันล่าสุดของ v1 คือ **`v1.10.3`** 
- ตั้งแต่ v2 เป็นต้นไป binary จะไม่ถูกแจกจ่ายผ่าน endpoint นี้อีกต่อไป ให้ดูที่ [**releases page**](https://github.com/ZupIT/horusec/releases)

### **การใช้ Horusec-Web application**
จัดการช่องโหว่ของคุณผ่านเว็บอินเทอร์เฟซของเรา คุณจะมี dashboard สำหรับดู metric ช่องโหว่ การควบคุม false positive, token อนุญาต, อัปเดตช่องโหว่ และอื่นๆ อีกมากมาย
อ่านรายละเอียดเพิ่มเติมในหัวข้อ [**web application**](https://github.com/ZupIT/horusec-platform)

ดูตัวอย่างการส่งผลวิเคราะห์ไปยัง Horusec web services:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

ดู [**คู่มือการสร้าง authorization token ผ่าน Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token)

**คำเตือน:** web services ของเราย้ายไปที่ [**repository ใหม่**](https://github.com/ZupIT/horusec-platform) คุณต้องอัปเกรดเป็น v2 ดู [**วิธี migrate จาก v1 ไป v2**](https://docs.horusec.io/docs/migrate-v1-to-v2)

### **การใช้ Visual Studio Code**
คุณสามารถวิเคราะห์โปรเจกต์ของคุณโดยใช้ส่วนเสริม Visual Studio Code ของ Horusec
ดูข้อมูลเพิ่มเติมที่ [**เอกสาร**](https://docs.horusec.io/docs/extensions/visual-studio-code/)

### **การใช้ Pipeline**
คุณสามารถวิเคราะห์โปรเจกต์ก่อนที่จะ deploy ใน environment ของคุณ เพื่อความปลอดภัยสูงสุดในองค์กร
ดูข้อมูลเพิ่มเติม [**ได้ที่เอกสาร**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **คุณสมบัติ**
ดูรายละเอียดด้านล่าง: 
- วิเคราะห์ได้พร้อมกัน 18 ภาษา ด้วยเครื่องมือความปลอดภัย 20 ตัว เพื่อความแม่นยำสูงสุด
- ค้นหา secrets และเนื้อหาอื่นๆ ที่อาจถูกเปิดเผยในประวัติ git
- การวิเคราะห์สามารถตั้งค่าได้อย่างยืดหยุ่น [**ดู CLI options ทั้งหมด**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags)

## **เอกสาร**
คุณสามารถดูเอกสารของ Horusec ได้ที่ [**เว็บไซต์**](https://docs.horusec.io/docs/overview/)

## **แผนงาน**
เรามี [**roadmap**](ROADMAP.md) ของโปรเจกต์ คุณสามารถร่วมพัฒนาได้!

Horusec ยังมี repository อื่นๆ อีก ดูได้ที่:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **การมีส่วนร่วม**

คุณสามารถใช้งาน แนะนำการปรับปรุง หรือมีส่วนร่วมในการพัฒนาและการนำไปใช้ใหม่ได้อย่างอิสระ

ดู [**คู่มือการมีส่วนร่วม**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) เพื่อเรียนรู้เกี่ยวกับกระบวนการพัฒนาของเรา วิธีเสนอข้อแก้ไขบั๊กและการปรับปรุงต่างๆ

### **ใบรับรองนักพัฒนา - DCO**

นี่คือชั้นความปลอดภัยสำหรับโปรเจกต์และนักพัฒนา และจำเป็นต้องปฏิบัติตาม

ปฏิบัติตามวิธีใดวิธีหนึ่งต่อไปนี้เพื่อเพิ่ม DCO ให้กับ commit ของคุณ:

**1. บรรทัดคำสั่ง**
ทำตามขั้นตอนดังนี้:
**ขั้นตอนที่ 1:** ตั้งค่าชื่อและอีเมลของคุณใน git ให้ตรงกับที่คุณตั้งค่าไว้ในบัญชี GitHub เพื่อช่วยในการเซ็นชื่อ commit ด้วยตนเองระหว่างการรีวิวและแนะนำ

```
git config --global user.name “Name”
git config --global user.email “email@domain.com.br”
```
**ขั้นตอนที่ 2:** เพิ่มบรรทัด Signed-off-by โดยใช้ flag `'-s'` ในคำสั่ง git commit:

```
$ git commit -s -m "This is my commit message"
```
**2. เว็บไซต์ GitHub**

คุณยังสามารถเซ็นชื่อ commit ด้วยตนเองระหว่างการรีวิวและแนะนำบน GitHub โดยทำตามขั้นตอนนี้:

**ขั้นตอนที่ 1:** เมื่อกล่อง commit changes เปิดขึ้น ให้พิมพ์หรือวางลายเซ็นของคุณลงในกล่องแสดงความคิดเห็น ดังตัวอย่าง:

```
Signed-off-by: Name < e-mail address >
```

สำหรับวิธีนี้ ชื่อและอีเมลของคุณจะต้องตรงกับที่ลงทะเบียนไว้ในบัญชี GitHub ของคุณ

## **จรรยาบรรณ**
โปรดปฏิบัติตาม [**จรรยาบรรณ**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) ในทุกการมีส่วนร่วมกับโปรเจกต์ของเรา

## **สัญญาอนุญาต**
[**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **ชุมชน**

สามารถติดต่อเราได้ที่:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- หากคุณมีคำถามหรือไอเดีย มาพูดคุยกันได้ที่ [**Zup Open Source Forum**](https://forum.zup.com.br)

โปรเจกต์นี้ดำรงอยู่ได้ด้วยการสนับสนุนจากผู้มีส่วนร่วมทุกคน ขอบคุณมาก! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---