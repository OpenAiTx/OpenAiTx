# jerry-list

A curated wordlist built and refined through real-world bug bounty hunting. This is my personal collection that I have been using privately for a long time and is now being released publicly to help the security community.

---

## What is this

jerry-list is the main wordlist in this repository, covering a wide range of paths, parameters, endpoints, and patterns that have proven effective in active bug bounty hunting. Every entry in this list has been shaped by real engagement experience, not just automated generation or recycled public sources. This is the list that helped me land multiple P1 and P2 findings across various programs.

A private DNS wordlist is also on the way. That list is something I have relied on heavily to discover unique subdomains that most conventional tools and public wordlists completely miss. It will be published here once cleaned up and ready for release.

---

## Contents

| File | Description |
|---|---|
| jerry-list.txt | Main wordlist for directory, path, and endpoint fuzzing |
| jerry-dns.txt | DNS subdomain wordlist — coming soon |

---

## Usage

Works with any standard fuzzing tool. A few quick examples:

**ffuf**
```bash
ffuf -u https://target.com/FUZZ -w jerry-list.txt -mc 200,301,302,403,500
```

**gobuster**
```bash
gobuster dir -u https://target.com -w jerry-list.txt
```

**subfinder / DNS brute (once dns list drops)**
```bash
puredns brute target.com -w jerry-dns.txt
```

---

## Results

These wordlists have directly contributed to finding multiple P1 and P2 vulnerabilities throughout my bug bounty journey. The DNS list in particular has been one of my most consistent tools for surfacing unique subdomains that lead to high impact findings.

---

## Upcoming

- jerry-dns.txt — private DNS wordlist release
- Possible parameter fuzzing list based on real observed parameters

---

## Contributing

This is a personal list so I am not accepting pull requests at this time. If you find something useful or land a bug using this list, feel free to drop a star or reach out.

---

## Disclaimer

These wordlists are intended for authorized security testing and bug bounty programs only. Only use them against targets you have explicit permission to test. The author is not responsible for any misuse.

---

## Author

--**Jerry1319**
