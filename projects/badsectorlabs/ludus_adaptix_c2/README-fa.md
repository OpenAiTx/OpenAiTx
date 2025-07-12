# نقش Ansible: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

یک نقش Ansible که سرور و/یا کلاینت [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) و تمام [افزونه‌ها](https://github.com/Adaptix-Framework/Extension-Kit) را بر روی یک میزبان لینوکس مبتنی بر دبیان نصب می‌کند.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## استفاده

به طور پیش‌فرض، سرور بر روی پورت `4321` و اندپوینت `/endpoint` با رمز عبور `pass` گوش می‌دهد. هر نام کاربری پذیرفته می‌شود. شما می‌توانید این موارد را با متغیرهای نقش تغییر دهید، توضیحات زیر را ببینید.

در دستگاه کلاینت، فرمان `adaptixclient` را اجرا کنید تا رابط گرافیکی (GUI) راه‌اندازی شود و سپس با استفاده از تنظیمات فوق (مگر اینکه با متغیرها تغییر داده باشید) به سرور وارد شوید.

## پیش‌نیازها

هیچکدام.

## متغیرهای نقش

متغیرهای قابل استفاده در زیر به همراه مقادیر پیش‌فرض آمده‌اند (به `defaults/main.yml` مراجعه کنید):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # یکی از این یا مورد زیر را روی true قرار دهید وگرنه نقش هیچ کاری انجام نمی‌دهد!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug می‌تواند اینجا استفاده شود
    ludus_adaptix_c2_go_version: 1.24.3
    # تمام گزینه‌های زیر برای اتصال کلاینت‌های GUI Adaptix به سرور است، نه یک عامل c2
    ludus_adaptix_c2_port: ۴۳۲۱
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## وابستگی‌ها

ندارد.

## نمونه Playbook

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
## نمونه پیکربندی Ludus Range

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
## مجوز

GPLv3

## اطلاعات نویسنده

این نقش توسط [Bad Sector Labs](https://github.com/badsectorlabs)، برای [Ludus](https://ludus.cloud/) ایجاد شده است.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---