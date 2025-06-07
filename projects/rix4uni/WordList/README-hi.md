# WordList

कस्टम फज़िंग वर्डलिस्ट `fuzzing_list.txt`
```
cat urls.txt | sed 's|\(.*\)/[^/]*$|\1|' | cut -d"/" -f4,5,6,7,8,9,10,11 | tr "/" "\n" | sed '/^$/d' | anew fuzzing_list.txt
```

कस्टम DNS वर्डलिस्ट `dns-wordlist.txt`
```
cat alltargets.txt | sed 's/\.[^.]*$//' | tr "." "\n" | egrep -v '^[0-9]*$' | anew dns-wordlist.txt
```

इन URLs को nuclei मिसकन्फ़िगरेशन के लिए स्कैन करें `urls-for-nuclei.txt`
```
cat urls.txt | grep -E "^https?://[^/]+/.+" | cut -d"/" -f1-4 | anew -q urls-for-nuclei.txt ;cat urls.txt | grep -E "^https?://[^/]+/.+" | cut -d"/" -f1-5 | anew -q urls-for-nuclei.txt ;cat urls.txt | grep -E "^https?://[^/]+/.+" | cut -d"/" -f1-6 | anew -q urls-for-nuclei.txt
```

`default-username-password.txt`
```
curl -s "https://raw.githubusercontent.com/rix4uni/WordList/main/default-username-password.txt"|cut -d":" -f1 | tee -a username.txt && curl -s "https://raw.githubusercontent.com/rix4uni/WordList/main/default-username-password.txt"|cut -d":" -f2 | tee -a password.txt
```

कस्टम पैरामीटर्स वर्डलिस्ट `params.txt`
```
cat urls.txt | grep "\.php?" | uro | grep "?" | cut -f2 -d"?" | cut -f1 -d"=" | sed '/^\s*$/d'| anew params.txt
```

कस्टम फज़िंग वर्डलिस्ट `onelistforall.txt`
```
curl -s "https://raw.githubusercontent.com/maurosoria/dirsearch/master/db/dicc.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/six2dez/OneListForAll/main/onelistforallmicro.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/six2dez/OneListForAll/main/onelistforallshort.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/ayoubfathi/leaky-paths/main/leaky-paths.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/Bo0oM/fuzz.txt/master/fuzz.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/abdallaabdalrhman/Wordlist-for-Bug-Bounty/main/great_wordlist_for_bug_bounty.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/danielmiessler/SecLists/master/Discovery/Web-Content/raft-large-directories.txt" | anew -q onelistforall.txt && curl -s "https://wordlists-cdn.assetnote.io/data/automated/httparchive_php_2020_11_18.txt" | anew -q onelistforall.txt && curl -s "https://wordlists-cdn.assetnote.io/data/automated/httparchive_aspx_asp_cfm_svc_ashx_asmx_2020_11_18.txt" | anew -q onelistforall.txt && curl -s "https://wordlists-cdn.assetnote.io/data/automated/httparchive_jsp_jspa_do_action_2022_08_28.txt" | anew -q onelistforall.txt
```

## पेलोड्स
- शीर्ष 50 तक => `*-small.txt`
- शीर्ष 500 तक => `*-medium.txt`
- बिना किसी सीमा के सभी पेलोड्स => `*-large.txt` , यदि 50MB से अधिक हो तो `*-large-1.txt`, `*-large-2.txt`

## टेक्नोलॉजीज
- बिना किसी सीमा के सभी टेक्नोलॉजीज => `techname/techname.txt` , यदि 50MB से अधिक हो तो `techname/techname-1.txt`, `techname/techname-2.txt`

## nuclei-technologies
प्रयोग करें: [nuclei-wordlist-generator.go](https://github.com/rix4uni/WordList/blob/main/wordlist-generator-tools/nuclei-wordlist-generator.go)

- `techname/techname-unknown.txt`
- `techname/techname-info.txt`
- `techname/techname-low.txt`
- `techname/techname-medium.txt`
- `techname/techname-high.txt`
- `techname/techname-critical.txt`
- `techname/techname-all.txt`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---