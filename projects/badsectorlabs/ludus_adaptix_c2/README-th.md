# Ansible Role: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

An Ansible Role ที่ติดตั้ง [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) ทั้งในส่วนของ server และ/หรือ client และ [Extensions](https://github.com/Adaptix-Framework/Extension-Kit) ทั้งหมดบนโฮสต์ Linux ที่ใช้ Debian

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## การใช้งาน

โดยค่าปกติ server จะรันที่พอร์ต `4321` และ endpoint `/endpoint` พร้อมรหัสผ่าน `pass` สามารถใช้ชื่อผู้ใช้ใดก็ได้ คุณสามารถเปลี่ยนค่าเหล่านี้ได้ด้วยตัวแปร role ดูรายละเอียดด้านล่าง

บนเครื่อง client ให้รันคำสั่ง `adaptixclient` เพื่อเปิด GUI แล้วเข้าสู่ระบบ server ด้วยค่าการตั้งค่าดังกล่าว (ยกเว้นคุณได้เปลี่ยนแปลงผ่านตัวแปร)

## ข้อกำหนด

ไม่มี

## ตัวแปรของ Role

ตัวแปรที่มีให้ใช้งานแสดงไว้ด้านล่าง พร้อมค่าปริยาย (ดูที่ `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # กำหนดค่านี้หรือด้านล่างให้เป็น true ไม่เช่นนั้น role จะไม่ทำอะไร!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug สามารถใช้ได้ที่นี่
    ludus_adaptix_c2_go_version: 1.24.3
    # ตัวเลือกทั้งหมดด้านล่างนี้สำหรับ Adaptix GUI clients ที่จะเชื่อมต่อกับ server ไม่ใช่ c2 agent
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## ข้อกำหนดที่ต้องมี

ไม่มี

## ตัวอย่าง Playbook

```yaml
- hosts: adaptix_server_host
  roles:
    - badsectorlabs.ludus_adaptix_c2
  vars:
    ludus_adaptix_c2_install_server: true

- hosts: adaptix_client_host
  roles:
    - badsectorlabs.ludus_adaptix_c2
  vars:
    ludus_adaptix_c2_install_client: true    
```
## ตัวอย่างการตั้งค่า Ludus Range

```yaml
ludus:
  - vm_name: "{{ range_id }}-adaptix-server"
    hostname: "{{ range_id }}-adaptix"
    template: debian-12-x64-server-template
    vlan: 99
    ip_last_octet: 1
    ram_gb: 4
    cpus: 2
    linux: true
    roles:
      - badsectorlabs.ludus_adaptix_c2
    role_vars:
      ludus_adaptix_c2_install_server: true

  - vm_name: "{{ range_id }}-kali-1"
    hostname: "{{ range_id }}-kali-1"
    template: kali-x64-desktop-template
    vlan: 99
    ip_last_octet: 2
    ram_gb: 4
    cpus: 2
    linux: true
    roles:
      - badsectorlabs.ludus_adaptix_c2
    role_vars:
      ludus_adaptix_c2_install_client: true
```
## สัญญาอนุญาต

GPLv3

## ข้อมูลผู้เขียน

บทบาทนี้สร้างโดย [Bad Sector Labs](https://github.com/badsectorlabs) สำหรับ [Ludus](https://ludus.cloud/)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---