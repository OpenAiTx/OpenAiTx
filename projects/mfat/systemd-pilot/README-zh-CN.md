# systemd Pilot

systemd Pilot 是一个用于管理 GNU/Linux 系统上 systemd 服务的桌面应用程序。它可以被描述为 systemctl 的图形界面。

![image](https://github.com/user-attachments/assets/85ee68be-aa3e-4291-8435-ef9ee7b8b72f)


![Screenshot From 2024-12-31 11-26-27](https://github.com/user-attachments/assets/09a58f8c-7d2b-4bc3-87db-561221295b18)


![Screenshot From 2024-12-31 11-28-58](https://github.com/user-attachments/assets/1c5653ab-31bc-4fd1-b607-1240dd85f831)


![Screenshot From 2024-12-31 11-29-24](https://github.com/user-attachments/assets/b9eb7194-b3dc-4c17-8ecc-8946374a2ca1)

![Screenshot From 2024-12-31 11-29-41](https://github.com/user-attachments/assets/2715e99c-2a96-406b-9d55-4f3512bbc345)


## 功能
- 列出本地或远程主机上的系统服务
- 使用模板快速部署新服务
- 启动、停止、重启服务，显示状态
- 便捷搜索。只需开始输入，应用即可找到相关服务
- 轻量且节省系统资源（仅一个 Python 脚本）
  
## 下载
- 从[发布](https://github.com/mfat/systemd-pilot/releases)页面下载适合您发行版的安装包。
  
## 依赖要求
如果您更喜欢直接运行 python 脚本，以下是依赖要求：

Python 模块：
- PyGObject>=3.42.0
- paramiko>=3.0.0
- keyring>=24.0.0
- rich>=13.0.0
- PyYAML

Debian 依赖：
- `sudo apt install 
    python3-gi 
    python3-gi-cairo 
    gir1.2-gtk-3.0 
    gir1.2-gtksource-4 
    python3-paramiko 
    python3-yaml 
    python3-keyring`
  
Fedora/RHEL 依赖项:
- `sudo dnf install python3
      python3-gobject
      python3-paramiko
      python3-keyring
      python3-rich
      python3-cairo
      python3-gobject
      python3-dbus
      python3-secretstorage
      gtk4
      libadwaita
      gtksourceview4
      systemd`
  


## 支持开发
比特币:`bc1qqtsyf0ft85zshsnw25jgsxnqy45rfa867zqk4t`

狗狗币:`DRzNb8DycFD65H6oHNLuzyTzY1S5avPHHx`

  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-09

---