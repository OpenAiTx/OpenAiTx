# Ansible Rolü: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

[Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) sunucusunu ve/veya istemcisini ve tüm [Eklentileri](https://github.com/Adaptix-Framework/Extension-Kit) Debian tabanlı bir Linux ana bilgisayarına kuran bir Ansible Rolüdür.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Kullanım

Varsayılan olarak sunucu `4321` portunda ve `/endpoint` uç noktasında `pass` parolasıyla dinler. Herhangi bir kullanıcı adı kabul edilir. Bunları rol değişkenleriyle değiştirebilirsiniz, aşağıya bakınız.

İstemci makinede, GUI'yi başlatmak için `adaptixclient` komutunu çalıştırın ve ardından yukarıdaki ayarlarla (değişkenler aracılığıyla değiştirilmediği sürece) sunucuya giriş yapın.

## Gereksinimler

Yok.

## Rol Değişkenleri

Mevcut değişkenler, varsayılan değerleriyle birlikte aşağıda listelenmiştir (`defaults/main.yml` dosyasına bakınız):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # Bunu veya aşağıdakini true yapmazsanız rol hiçbir şey yapmaz!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # Burada -debug kullanılabilir
    ludus_adaptix_c2_go_version: 1.24.3
    # Aşağıdaki tüm seçenekler Adaptix GUI istemcilerinin sunucuya bağlanması içindir, bir c2 ajanı için değildir
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Bağımlılıklar

Yok.

## Örnek Playbook

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
## Örnek Ludus Aralık Yapılandırması

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
## Lisans

GPLv3

## Yazar Bilgisi

Bu rol [Bad Sector Labs](https://github.com/badsectorlabs) tarafından [Ludus](https://ludus.cloud/) için oluşturulmuştur.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---