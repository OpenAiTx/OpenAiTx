# Ansible Role: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Một Ansible Role để cài đặt [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) server và/hoặc client cùng với tất cả [Extensions](https://github.com/Adaptix-Framework/Extension-Kit) trên máy chủ Linux dựa trên Debian.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Cách sử dụng

Theo mặc định, server sẽ lắng nghe trên cổng `4321` và endpoint `/endpoint` với mật khẩu `pass`. Bất kỳ tên người dùng nào cũng được chấp nhận. Bạn có thể thay đổi các thông số này bằng biến role, xem bên dưới.

Trên máy client, chạy lệnh `adaptixclient` để khởi động giao diện GUI, sau đó đăng nhập vào server sử dụng các thiết lập ở trên (trừ khi đã thay đổi qua các biến).

## Yêu cầu

Không có.

## Biến Role

Các biến có sẵn được liệt kê bên dưới, kèm giá trị mặc định (xem `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # Đặt biến này hoặc biến bên dưới thành true, nếu không role sẽ không thực hiện gì cả!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug có thể được sử dụng ở đây
    ludus_adaptix_c2_go_version: 1.24.3
    # Tất cả các tùy chọn bên dưới dành cho các client GUI của Adaptix kết nối đến server, không phải agent c2
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Phụ thuộc

Không có.

## Ví dụ Playbook

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
## Ví dụ cấu hình Ludus Range

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
## Giấy phép

GPLv3

## Thông tin tác giả

Vai trò này được tạo bởi [Bad Sector Labs](https://github.com/badsectorlabs), dành cho [Ludus](https://ludus.cloud/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---