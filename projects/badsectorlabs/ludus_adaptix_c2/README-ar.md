# دور Ansible: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

دور Ansible يقوم بتثبيت [إطار عمل Adaptix](https://adaptix-framework.gitbook.io/adaptix-framework) كخادم و/أو عميل وجميع [الامتدادات](https://github.com/Adaptix-Framework/Extension-Kit) على نظام تشغيل لينكس مبني على Debian.

![إطار عمل Adaptix](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## الاستخدام

بشكل افتراضي، يستمع الخادم على المنفذ `4321` ونقطة النهاية `/endpoint` مع كلمة المرور `pass`. يتم قبول أي اسم مستخدم. يمكنك تغيير هذه الإعدادات من خلال متغيرات الدور، انظر أدناه.

على جهاز العميل، شغل الأمر `adaptixclient` لبدء واجهة المستخدم الرسومية، ثم سجل الدخول إلى الخادم باستخدام الإعدادات أعلاه (ما لم يتم تغييرها عبر المتغيرات).

## المتطلبات

لا يوجد.

## متغيرات الدور

المتغيرات المتاحة مذكورة أدناه مع القيم الافتراضية (انظر `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # قم بتعيين هذا أو الذي أدناه إلى true وإلا لن يقوم الدور بأي شيء!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug يمكن استخدامه هنا
    ludus_adaptix_c2_go_version: 1.24.3
    # جميع الخيارات أدناه مخصصة لعملاء واجهة المستخدم الرسومية لـ Adaptix للاتصال بالخادم، وليست لعامل c2
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## المتطلبات

لا يوجد.

## مثال على Playbook

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
## مثال على إعداد نطاق Ludus

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
## الرخصة

GPLv3

## معلومات المؤلف

تم إنشاء هذا الدور بواسطة [Bad Sector Labs](https://github.com/badsectorlabs)، لصالح [Ludus](https://ludus.cloud/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---