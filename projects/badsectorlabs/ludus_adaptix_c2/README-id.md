# Ansible Role: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Sebuah Peran Ansible yang menginstal [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) server dan/atau client serta semua [Extensions](https://github.com/Adaptix-Framework/Extension-Kit) pada host Linux berbasis Debian.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Penggunaan

Secara default, server akan mendengarkan pada port `4321` dan endpoint `/endpoint` dengan password `pass`. Username apa pun diterima. Anda dapat mengubah ini dengan variabel peran, lihat di bawah.

Di mesin klien, jalankan perintah `adaptixclient` untuk memulai GUI, kemudian masuk ke server menggunakan pengaturan di atas (kecuali diubah melalui variabel).

## Persyaratan

Tidak ada.

## Variabel Peran

Variabel yang tersedia tercantum di bawah ini, beserta nilai default (lihat `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # Setel ini atau yang di bawah ke true atau peran tidak akan melakukan apa pun!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug dapat digunakan di sini
    ludus_adaptix_c2_go_version: 1.24.3
    # Semua opsi di bawah ini untuk klien GUI Adaptix agar dapat terhubung ke server, bukan untuk agen c2
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Dependensi

Tidak ada.

## Contoh Playbook

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
## Contoh Konfigurasi Ludus Range

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
## Lisensi

GPLv3

## Informasi Penulis

Peran ini dibuat oleh [Bad Sector Labs](https://github.com/badsectorlabs), untuk [Ludus](https://ludus.cloud/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---