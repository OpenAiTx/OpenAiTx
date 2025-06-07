# WordList

커스텀 퍼징 워드리스트 `fuzzing_list.txt`
```
cat urls.txt | sed 's|\(.*\)/[^/]*$|\1|' | cut -d"/" -f4,5,6,7,8,9,10,11 | tr "/" "\n" | sed '/^$/d' | anew fuzzing_list.txt
```

커스텀 DNS 워드리스트 `dns-wordlist.txt`
```
cat alltargets.txt | sed 's/\.[^.]*$//' | tr "." "\n" | egrep -v '^[0-9]*$' | anew dns-wordlist.txt
```

nuclei 오구성(misconfiguration) 스캔용 URL 리스트 `urls-for-nuclei.txt`
```
cat urls.txt | grep -E "^https?://[^/]+/.+" | cut -d"/" -f1-4 | anew -q urls-for-nuclei.txt ;cat urls.txt | grep -E "^https?://[^/]+/.+" | cut -d"/" -f1-5 | anew -q urls-for-nuclei.txt ;cat urls.txt | grep -E "^https?://[^/]+/.+" | cut -d"/" -f1-6 | anew -q urls-for-nuclei.txt
```

`default-username-password.txt`
```
curl -s "https://raw.githubusercontent.com/rix4uni/WordList/main/default-username-password.txt"|cut -d":" -f1 | tee -a username.txt && curl -s "https://raw.githubusercontent.com/rix4uni/WordList/main/default-username-password.txt"|cut -d":" -f2 | tee -a password.txt
```

커스텀 파라미터 워드리스트 `params.txt`
```
cat urls.txt | grep "\.php?" | uro | grep "?" | cut -f2 -d"?" | cut -f1 -d"=" | sed '/^\s*$/d'| anew params.txt
```

커스텀 퍼징 워드리스트 `onelistforall.txt`
```
curl -s "https://raw.githubusercontent.com/maurosoria/dirsearch/master/db/dicc.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/six2dez/OneListForAll/main/onelistforallmicro.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/six2dez/OneListForAll/main/onelistforallshort.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/ayoubfathi/leaky-paths/main/leaky-paths.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/Bo0oM/fuzz.txt/master/fuzz.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/abdallaabdalrhman/Wordlist-for-Bug-Bounty/main/great_wordlist_for_bug_bounty.txt" | anew -q onelistforall.txt && curl -s "https://raw.githubusercontent.com/danielmiessler/SecLists/master/Discovery/Web-Content/raft-large-directories.txt" | anew -q onelistforall.txt && curl -s "https://wordlists-cdn.assetnote.io/data/automated/httparchive_php_2020_11_18.txt" | anew -q onelistforall.txt && curl -s "https://wordlists-cdn.assetnote.io/data/automated/httparchive_aspx_asp_cfm_svc_ashx_asmx_2020_11_18.txt" | anew -q onelistforall.txt && curl -s "https://wordlists-cdn.assetnote.io/data/automated/httparchive_jsp_jspa_do_action_2022_08_28.txt" | anew -q onelistforall.txt
```

## 페이로드
- 상위 50개까지 => `*-small.txt`
- 상위 500개까지 => `*-medium.txt`
- 모든 페이로드 제한 없음 => `*-large.txt` , 50MB 초과 시 `*-large-1.txt`, `*-large-2.txt`

## 기술(technologies)
- 모든 기술 제한 없음 => `techname/techname.txt` , 50MB 초과 시 `techname/techname-1.txt`, `techname/techname-2.txt`

## nuclei-technologies
사용 도구: [nuclei-wordlist-generator.go](https://github.com/rix4uni/WordList/blob/main/wordlist-generator-tools/nuclei-wordlist-generator.go)

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