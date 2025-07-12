# Ansible 角色: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

一个 Ansible 角色，用于在基于 Debian 的 Linux 主机上安装 [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) 服务器和/或客户端及所有 [扩展](https://github.com/Adaptix-Framework/Extension-Kit)。

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## 用法

默认情况下，服务器监听端口为 `4321`，端点为 `/endpoint`，密码为 `pass`。接受任意用户名。你可以通过角色变量更改这些设置，见下文。

在客户端机器上，运行命令 `adaptixclient` 启动 GUI，然后使用上述设置（如果没有通过变量更改）登录服务器。

## 要求

无。

## 角色变量

可用变量如下所示，以及默认值（见 `defaults/main.yml`）：

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # 若不将此项或下方一项设为 true，角色不会执行任何操作！
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # 可在此处使用 -debug
    ludus_adaptix_c2_go_version: 1.24.3
    # 下方所有选项均用于 Adaptix GUI 客户端连接服务器，而非 c2 agent
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## 依赖项

无。

## 示例 Playbook

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
## 示例 Ludus Range 配置

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
## 许可证

GPLv3

## 作者信息

此角色由 [Bad Sector Labs](https://github.com/badsectorlabs) 创建，服务于 [Ludus](https://ludus.cloud/)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---