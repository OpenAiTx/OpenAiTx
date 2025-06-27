# गिटलिक्स

```
┌─○───┐
│ │╲  │
│ │ ○ │
│ ○ ░ │
└─░───┘
```

[license]: ./LICENSE
[badge-license]: https://img.shields.io/github/license/gitleaks/gitleaks.svg
[go-docs-badge]: https://pkg.go.dev/badge/github.com/gitleaks/gitleaks/v8?status
[go-docs]: https://pkg.go.dev/github.com/zricethezav/gitleaks/v8
[badge-build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml/badge.svg
[build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml
[go-report-card-badge]: https://goreportcard.com/badge/github.com/gitleaks/gitleaks/v8
[go-report-card]: https://goreportcard.com/report/github.com/gitleaks/gitleaks/v8
[dockerhub]: https://hub.docker.com/r/zricethezav/gitleaks
[dockerhub-badge]: https://img.shields.io/docker/pulls/zricethezav/gitleaks.svg
[gitleaks-action]: https://github.com/gitleaks/gitleaks-action
[gitleaks-badge]: https://img.shields.io/badge/protected%20by-gitleaks-blue
[gitleaks-playground-badge]: https://img.shields.io/badge/gitleaks%20-playground-blue
[gitleaks-playground]: https://gitleaks.io/playground


[![GitHub Action Test][badge-build]][build]
[![Docker Hub][dockerhub-badge]][dockerhub]
[![Gitleaks Playground][gitleaks-playground-badge]][gitleaks-playground]
[![Gitleaks Action][gitleaks-badge]][gitleaks-action]
[![GoDoc][go-docs-badge]][go-docs]
[![GoReportCard][go-report-card-badge]][go-report-card]
[![License][badge-license]][license]


### हमारे डिस्कॉर्ड से जुड़ें! [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

गिटलिक्स एक टूल है जो **पासवर्ड, API कीज, और टोकन** जैसे सीक्रेट्स को git रिपॉजिटरी, फाइल्स, और अन्य इनपुट (जैसे `stdin`) में **डिटेक्ट** करने के लिए उपयोग होता है। अगर आप जानना चाहते हैं कि डिटेक्शन इंजन कैसे काम करता है तो यह ब्लॉग देखें: [Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need)।

```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


Finding:     "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
Secret:      cafebabe:deadbeef
RuleID:      sidekiq-secret
Entropy:     2.609850
File:        cmd/generate/config/rules/sidekiq.go
Line:        23
Commit:      cd5226711335c68be1e720b318b7bc3135a30eb2
Author:      John
Email:       john@users.noreply.github.com
Date:        2022-08-03T12:31:40Z
Fingerprint: cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## शुरू करें

गिटलिक्स को Homebrew, Docker, या Go के माध्यम से इंस्टॉल किया जा सकता है। गिटलिक्स कई लोकप्रिय प्लेटफार्म और ऑपरेटिंग सिस्टम्स के लिए [रिलीज़ पेज](https://github.com/gitleaks/gitleaks/releases) पर बाइनरी रूप में भी उपलब्ध है। इसके अलावा, गिटलिक्स को सीधे अपने रिपॉ में प्री-कमिट हुक के रूप में या [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action) का उपयोग करके GitHub एक्शन के रूप में भी लागू किया जा सकता है।

### इंस्टॉल करना

```bash
# मैकओएस
brew install gitleaks

# डॉकर (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# डॉकर (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# स्रोत से (सुनिश्चित करें कि `go` इंस्टॉल है)
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### GitHub एक्शन

आधिकारिक [Gitleaks GitHub एक्शन](https://github.com/gitleaks/gitleaks-action) देखें

```
name: gitleaks
on: [pull_request, push, workflow_dispatch]
jobs:
  scan:
    name: gitleaks
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v3
        with:
          fetch-depth: 0
      - uses: gitleaks/gitleaks-action@v2
        env:
          GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # केवल Organizations के लिए आवश्यक, व्यक्तिगत खातों के लिए नहीं।
```

### प्री-कमिट

1. https://pre-commit.com/#install से pre-commit इंस्टॉल करें
2. अपनी रिपॉजिटरी की रूट पर नीचे दिए गए कंटेंट के साथ `.pre-commit-config.yaml` फाइल बनाएं:

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   [गिटलिक्स का नेटिव एक्जीक्यूशन](https://github.com/gitleaks/gitleaks/releases) के लिए या [आधिकारिक डॉकर इमेजेस](#docker) का उपयोग करके गिटलिक्स को एक्जीक्यूट करने के लिए [`gitleaks-docker` प्री-कमिट ID](https://github.com/gitleaks/gitleaks/blob/master/.pre-commit-hooks.yaml) का उपयोग करें

3. `pre-commit autoupdate` चलाकर कॉन्फ़िग को लेटेस्ट रिपोज़ वर्शन में ऑटो-अपडेट करें
4. `pre-commit install` से इंस्टॉल करें
5. अब सब सेट है!

```
➜ git commit -m "इस कमिट में एक सीक्रेट है"
Detect hardcoded secrets.................................................Failed
```

नोट: गिटलिक्स प्री-कमिट हुक को निष्क्रिय करने के लिए आप कमिट कमांड से पहले `SKIP=gitleaks` जोड़ सकते हैं,
और इससे गिटलिक्स रन नहीं होगा

```
➜ SKIP=gitleaks git commit -m "gitleaks चेक स्किप करें"
Detect hardcoded secrets................................................Skipped
```

## उपयोग

```
Usage:
  gitleaks [command]

Available Commands:
  dir         डायरेक्टरी या फाइल्स में सीक्रेट्स स्कैन करें
  git         git रिपॉजिटरी में सीक्रेट्स स्कैन करें
  help        किसी भी कमांड के बारे में सहायता
  stdin       stdin से सीक्रेट्स डिटेक्ट करें
  version     गिटलिक्स का वर्शन दिखाएँ

Flags:
  -b, --baseline-path string          ऐसे बेसलाइन की पाथ जिसमें इग्नोर किए जाने वाले इश्यू हों
  -c, --config string                 कॉन्फ़िग फाइल पाथ
                                      प्रायोरिटी का क्रम:
                                      1. --config/-c
                                      2. env var GITLEAKS_CONFIG
                                      3. env var GITLEAKS_CONFIG_TOML (फाइल कंटेंट के साथ)
                                      4. (target path)/.gitleaks.toml
                                      अगर इनमें से कोई विकल्प नहीं है, तो डिफ़ॉल्ट कॉन्फ़िग का उपयोग होगा
      --diagnostics string            डायग्नोस्टिक्स सक्षम करें (कॉमा-सेपरेटेड: cpu,mem,trace). cpu=CPU प्रोफाइलिंग, mem=मेमोरी प्रोफाइलिंग, trace=एक्जीक्यूशन ट्रेसिंग
      --diagnostics-dir string        डायग्नोस्टिक्स आउटपुट फाइल्स को स्टोर करने की डायरेक्टरी (डिफ़ॉल्ट: वर्तमान डायरेक्टरी)
      --enable-rule strings           केवल दिए गए आईडी वाले रूल्स को सक्षम करें
      --exit-code int                 लीक मिलने पर एक्जिट कोड (डिफ़ॉल्ट 1)
  -i, --gitleaks-ignore-path string   .gitleaksignore फाइल या फोल्डर का पाथ जिसमें वह हो (डिफ़ॉल्ट ".")
  -h, --help                          गिटलिक्स के लिए सहायता
      --ignore-gitleaks-allow         gitleaks:allow कमेंट्स को इग्नोर करें
  -l, --log-level string              लॉग लेवल (trace, debug, info, warn, error, fatal) (डिफ़ॉल्ट "info")
      --max-decode-depth int          अधिकतम डीकोडिंग गहराई (डिफ़ॉल्ट "0", कोई डीकोडिंग नहीं)
      --max-archive-depth int         नेस्टेड आर्काइव्स को स्कैन करने की अधिकतम गहराई (डिफ़ॉल्ट "0", कोई आर्काइव ट्रैवर्सल नहीं)
      --max-target-megabytes int      इससे बड़े फाइल्स को स्किप किया जाएगा
      --no-banner                     बैनर नहीं दिखाएँ
      --no-color                      वर्बोज आउटपुट के लिए रंग बंद करें
      --redact uint[=100]             लॉग्स और stdout से सीक्रेट्स हटा दें। केवल भाग हटाने के लिए प्रतिशत मान दें, जैसे --redact=20 (डिफ़ॉल्ट 100%)
  -f, --report-format string          आउटपुट फॉर्मेट (json, csv, junit, sarif, template)
  -r, --report-path string            रिपोर्ट फाइल
      --report-template string        रिपोर्ट जनरेट करने के लिए टेम्पलेट फाइल (इससे --report-format=template लागू होगा)
  -v, --verbose                       स्कैन से विस्तृत आउटपुट दिखाएँ
      --version                       गिटलिक्स का वर्शन

अधिक जानकारी के लिए "gitleaks [command] --help" का उपयोग करें।
```

### कमांड्स

⚠️ v8.19.0 में एक बदलाव आया जिसमें `detect` और `protect` को डिप्रिकेट कर दिया गया। ये कमांड्स अभी भी उपलब्ध हैं लेकिन
`--help` मेनू में छुपे हुए हैं। आसान कमांड ट्रांसलेशन के लिए यह [gist](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) देखें।
अगर आपको लगे कि v8.19.0 से कोई मौजूदा कमांड (`detect`/`protect`) काम नहीं कर रही है, तो कृपया एक इश्यू खोलें।

तीन स्कैनिंग मोड हैं: `git`, `dir`, और `stdin`।

#### Git

`git` कमांड से आप लोकल git रिपॉजिटरी को स्कैन कर सकते हैं। आंतरिक रूप से, गिटलिक्स `git log -p` कमांड का उपयोग करके पैचेस स्कैन करता है।
आप `log-opts` विकल्प से `git log -p` के व्यवहार को कॉन्फ़िगर कर सकते हैं।
उदाहरण के लिए, अगर आप गिटलिक्स को किसी कमिट रेंज पर चलाना चाहते हैं तो यह कमांड चलाएँ: `gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`। अधिक जानकारी के लिए [git log](https://git-scm.com/docs/git-log) डाक्यूमेंटेशन देखें।
अगर कोई टार्गेट पॉज़िशनल आर्गुमेंट के रूप में नहीं दिया गया है, तो गिटलिक्स वर्तमान वर्किंग डायरेक्टरी को git रिपॉ मानकर स्कैन करेगा।
#### Dir

`dir` (उपनामों में `files`, `directory` शामिल हैं) कमांड आपको डायरेक्टरीज़ और फ़ाइलों को स्कैन करने की सुविधा देता है। उदाहरण: `gitleaks dir -v path_to_directory_or_file`।
यदि कोई लक्ष्य पोजिशनल आर्ग्युमेंट के रूप में निर्दिष्ट नहीं किया गया है, तो gitleaks वर्तमान कार्यशील डायरेक्टरी को स्कैन करेगा।

#### Stdin

आप `stdin` कमांड के साथ gitleaks में डेटा भी स्ट्रीम कर सकते हैं। उदाहरण: `cat some_file | gitleaks -v stdin`

### बेसलाइन बनाना

जब बड़े रिपॉजिटरीज़ या लंबा इतिहास वाले रिपॉजिटरीज़ को स्कैन किया जा रहा हो, तो बेसलाइन का उपयोग करना सुविधाजनक हो सकता है। बेसलाइन का उपयोग करते समय, gitleaks उन पुराने निष्कर्षों को अनदेखा कर देगा जो बेसलाइन में मौजूद हैं। बेसलाइन कोई भी gitleaks रिपोर्ट हो सकती है। gitleaks रिपोर्ट बनाने के लिए, `--report-path` पैरामीटर के साथ gitleaks चलाएँ।

```
gitleaks git --report-path gitleaks-report.json # यह रिपोर्ट को gitleaks-report.json नामक फ़ाइल में सहेज देगा
```

एक बार बेसलाइन बन जाने के बाद इसे फिर से detect कमांड चलाते समय लागू किया जा सकता है:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

--baseline-path पैरामीटर के साथ detect कमांड चलाने के बाद, रिपोर्ट आउटपुट (findings.json) में केवल नए मुद्दे शामिल होंगे।

## Pre-Commit hook

आप Gitleaks को pre-commit hook के रूप में चला सकते हैं, इसके लिए example `pre-commit.py` स्क्रिप्ट को अपनी `.git/hooks/` डायरेक्टरी में कॉपी करें।

## कॉन्फ़िगरेशन लोड करें

प्राथमिकता का क्रम है:

1. `--config/-c` विकल्प:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. फ़ाइल पथ के साथ एनवायरनमेंट वेरिएबल `GITLEAKS_CONFIG`:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. फ़ाइल कंटेंट के साथ एनवायरनमेंट वेरिएबल `GITLEAKS_CONFIG_TOML`:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. टारगेट पथ के भीतर एक `.gitleaks.toml` फ़ाइल:
      ```bash
      gitleaks git .
      ```

यदि इन चार विकल्पों में से कोई भी उपयोग नहीं किया गया है, तो gitleaks डिफ़ॉल्ट कॉन्फ़िगरेशन का उपयोग करेगा।

## कॉन्फ़िगरेशन

Gitleaks एक कॉन्फ़िगरेशन प्रारूप प्रदान करता है जिसका पालन करके आप अपने स्वयं के सीक्रेट डिटेक्शन रूल्स बना सकते हैं:

```toml
# gitleaks कॉन्फ़िगरेशन फ़ाइल के लिए शीर्षक।
title = "Custom Gitleaks configuration"

# मूल रूप से आपके पास अपनी कस्टम कॉन्फ़िगरेशन के लिए दो विकल्प हैं:
#
# 1. अपनी स्वयं की कॉन्फ़िगरेशन परिभाषित करें, डिफ़ॉल्ट नियम लागू नहीं होंगे
#
#    उदाहरण के लिए, डिफ़ॉल्ट कॉन्फ़िगरेशन को प्रारंभिक बिंदु के रूप में उपयोग करें:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. किसी कॉन्फ़िगरेशन का विस्तार करें, नियम ओवरराइट या विस्तारित किए जाते हैं
#
#    जब आप किसी कॉन्फ़िगरेशन का विस्तार करते हैं तो विस्तारित नियम डिफ़ॉल्ट नियमों पर प्राथमिकता लेते हैं।
#    अर्थात, यदि डिफ़ॉल्ट कॉन्फ़िगरेशन और विस्तारित कॉन्फ़िगरेशन दोनों में डुप्लिकेट नियम हैं,
#    तो विस्तारित नियम या उनके गुण डिफ़ॉल्ट नियमों को ओवरराइड कर देंगे।
#    कॉन्फ़िगरेशन विस्तार के साथ एक और बात यह है कि आप एक साथ कई कॉन्फ़िगरेशन फ़ाइलों को अधिकतम 2 स्तर तक चेन कर सकते हैं।
#    Allowlist arrays को जोड़ा जाता है और इनमें डुप्लिकेट हो सकते हैं।

# useDefault और path को एक साथ उपयोग नहीं किया जा सकता। एक चुनें।
[extend]
# useDefault डिफ़ॉल्ट gitleaks कॉन्फ़िग को बाइनरी में निर्मित रूप में विस्तारित करेगा
# नवीनतम संस्करण यहाँ स्थित है:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# या आप विस्तार के लिए एक कॉन्फ़िगरेशन का पथ प्रदान कर सकते हैं।
# पथ वह है जहाँ से gitleaks को इनवोक किया गया था, बेस कॉन्फ़िग की लोकेशन नहीं।
# path = "common_config.toml"
# यदि कोई नियम हैं जिन्हें आप इनहेरिट नहीं करना चाहते, उन्हें यहाँ निर्दिष्ट करें।
disabledRules = [ "generic-api-key"]

# उन तालिकाओं की एक array जो यह परिभाषित करती हैं कि सीक्रेट्स को कैसे डिटेक्ट किया जाए
[[rules]]
# इस नियम के लिए यूनिक आइडेंटिफ़ायर
id = "awesome-rule-1"

# नियम का संक्षिप्त मानव-पठनीय विवरण।
description = "awesome rule 1"

# सीक्रेट्स का पता लगाने के लिए उपयोग किया गया Golang रेगुलर एक्सप्रेशन। ध्यान दें: Golang का regex इंजन lookaheads को सपोर्ट नहीं करता।
regex = '''one-go-style-regex-for-this-rule'''

# regex मैच से सीक्रेट निकालने के लिए उपयोग किया गया int, और अगर `entropy` सेट है तो उसी group की entropy चेक की जाएगी।
secretGroup = 3

# regex group को सीक्रेट माने जाने के लिए न्यूनतम shannon entropy को दर्शाने वाला float।
entropy = 3.5

# फ़ाइल पथ मैच करने के लिए उपयोग किया गया Golang रेगुलर एक्सप्रेशन। इसे अकेले नियम के रूप में या वैध `regex` एंट्री के साथ उपयोग किया जा सकता है।
path = '''a-file-path-regex'''

# कीवर्ड्स प्री-रेगेक्स चेक फिल्टरिंग के लिए उपयोग किए जाते हैं। जिन नियमों में कीवर्ड्स होते हैं वे एक त्वरित स्ट्रिंग तुलना जांच करेंगे
# ताकि यह सुनिश्चित किया जा सके कि कीवर्ड(s) स्कैन की जा रही सामग्री में हैं।
# आदर्श रूप से ये मान या तो पहचानकर्ता का हिस्सा होने चाहिए या नियम के regex के लिए विशिष्ट यूनिक स्ट्रिंग्स होने चाहिए
# (v8.6.0 में पेश किया गया)
keywords = [
  "auth",
  "password",
  "token",
]

# मेटाडेटा और रिपोर्टिंग प्रयोजनों के लिए उपयोग किए गए स्ट्रिंग्स की array।
tags = ["tag","another tag"]

    # ⚠️ v8.21.0 में `[rules.allowlist]` को `[[rules.allowlists]]` से बदल दिया गया।
    # यह परिवर्तन बैकवर्ड-कम्पेटिबल था: `[rules.allowlist]` के इंस्टेंसेस अभी भी काम करते हैं।
    #
    # आप false positives को कम करने के लिए एक नियम के लिए कई allowlists परिभाषित कर सकते हैं।
    # अगर _कोई भी_ `[[rules.allowlists]]` मेल खाता है तो निष्कर्ष को अनदेखा किया जाएगा।
    [[rules.allowlists]]
    description = "commit A को अनदेखा करें"
    # जब कई मानदंड परिभाषित किए जाते हैं तो डिफ़ॉल्ट स्थिति "OR" होती है।
    # जैसे, यह |commits| या |paths| या |stopwords| पर मेल कर सकता है।
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # नोट: stopwords निकाले गए सीक्रेट को लक्षित करता है, पूरे regex मैच को नहीं
    # जैसा कि 'regexes' करता है। (stopwords v8.8.0 में पेश किया गया)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # "AND" स्थिति यह सुनिश्चित करने के लिए उपयोग की जा सकती है कि सभी मानदंड मेल खाते हैं।
    # जैसे, यह मेल खाता है अगर |regexes| और |paths| दोनों संतुष्ट हैं।
    condition = "AND"
    # नोट: |regexes| डिफ़ॉल्ट रूप से निष्कर्ष में _Secret_ की जांच करता है।
    # |regexTarget| के स्वीकार्य मान हैं "secret" (डिफ़ॉल्ट), "match", और "line"।
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# आप डिफ़ॉल्ट कॉन्फ़िगरेशन से किसी विशेष नियम का विस्तार कर सकते हैं, जैसे gitlab-pat
# यदि आपने अपने GitLab इंस्टेंस पर कस्टम टोकन प्रिफिक्स परिभाषित किया है
[[rules]]
id = "gitlab-pat"
# डिफ़ॉल्ट नियम से अन्य सभी गुण इनहेरिट किए जाते हैं

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ v8.25.0 में `[allowlist]` को `[[allowlists]]` से बदल दिया गया।
#
# ग्लोबल allowlists की प्राथमिकता नियम-विशिष्ट allowlists से अधिक होती है।
# यदि नीचे दिए गए `commits` फ़ील्ड में सूचीबद्ध किसी कमिट का सामना किया जाता है, तो उस कमिट को छोड़ दिया जाएगा और उसके लिए कोई सीक्रेट डिटेक्ट नहीं किया जाएगा।
# वही तर्क regexes और paths के लिए लागू होता है।
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# नोट: (ग्लोबल) regexTarget डिफ़ॉल्ट रूप से निष्कर्ष में _Secret_ की जांच करता है।
# regexTarget के स्वीकार्य मान हैं "match" और "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# नोट: stopwords निकाले गए सीक्रेट को लक्षित करता है, पूरे regex मैच को नहीं
# जैसा कि 'regexes' करता है। (stopwords v8.8.0 में पेश किया गया)
stopwords = [
  '''client''',
```markdown
  '''endpoint''',
]

# ⚠️ v8.25.0 में, `[[allowlists]]` में एक नया फ़ील्ड जोड़ा गया है |targetRules|।
#
# सामान्य अलाउलिस्ट्स को एक बार परिभाषित किया जा सकता है और कई नियमों में |targetRules| का उपयोग करके असाइन किया जा सकता है।
# यह केवल निर्दिष्ट नियमों पर चलेगा, वैश्विक रूप से नहीं।
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "हमारी टेस्ट एसेट्स कुछ नियमों में फॉल्स-पॉजिटिव ट्रिगर करती हैं।"
paths = ['''tests/expected/._\.json$''']
```

उदाहरणों के लिए डिफ़ॉल्ट [gitleaks config](https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml) देखें या यदि आप डिफ़ॉल्ट कॉन्फ़िगरेशन में योगदान करना चाहते हैं तो [contributing guidelines](https://github.com/gitleaks/gitleaks/blob/master/CONTRIBUTING.md) का पालन करें। इसके अलावा, आप [यह gitleaks ब्लॉग पोस्ट](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) भी देख सकते हैं जिसमें एडवांस्ड कॉन्फ़िगरेशन सेटअप कवर किए गए हैं।

### अतिरिक्त कॉन्फ़िगरेशन

#### gitleaks:allow

यदि आप जानबूझकर कोई टेस्ट सीक्रेट कमिट कर रहे हैं जिसे gitleaks पकड़ लेगा, तो आप उस लाइन में `gitleaks:allow` कमेंट जोड़ सकते हैं, जिससे gitleaks उस सीक्रेट को अनदेखा कर देगा। उदाहरण:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

आप अपनी रिपॉजिटरी के रूट में `.gitleaksignore` फ़ाइल बनाकर विशिष्ट फाइंडिंग्स को अनदेखा कर सकते हैं। v8.10.0 रिलीज़ में Gitleaks ने Gitleaks रिपोर्ट में `Fingerprint` मान जोड़ा। प्रत्येक लीक या फाइंडिंग के पास एक Fingerprint होता है जो एक सीक्रेट की यूनिक पहचान करता है। इस फिंगरप्रिंट को `.gitleaksignore` फ़ाइल में जोड़ें ताकि उस विशिष्ट सीक्रेट को अनदेखा किया जा सके। उदाहरण के लिए Gitleaks की [.gitleaksignore](https://github.com/gitleaks/gitleaks/blob/master/.gitleaksignore) देखें। नोट: यह फीचर एक्सपेरिमेंटल है और भविष्य में बदल सकता है।

#### डिकोडिंग

कभी-कभी सीक्रेट्स को इस तरह से एन्कोड किया जाता है कि केवल regex से उन्हें ढूंढना कठिन हो जाता है।
अब आप gitleaks को अपने आप एन्कोडेड टेक्स्ट खोजने और डिकोड करने के लिए कह सकते हैं।
फ्लैग `--max-decode-depth` इस फीचर को सक्षम करता है (डिफ़ॉल्ट मान "0" है, यानी यह फीचर डिफ़ॉल्ट रूप से डिसेबल्ड है)।

रिकर्सिव डिकोडिंग समर्थित है क्योंकि डिकोडेड टेक्स्ट में भी एन्कोडेड टेक्स्ट हो सकता है।
फ्लैग `--max-decode-depth` रिकर्सन लिमिट सेट करता है। रिकर्सन तब रुकता है जब डिकोड करने के लिए कोई नया एन्कोडेड टेक्स्ट नहीं बचता, इसलिए ज्यादा मैक्स डेप्थ सेट करने का मतलब यह नहीं कि उतनी ही बार पास होगा। उतनी ही बार पास होगा जितना जरूरी है। कुल मिलाकर, डिकोडिंग स्कैन टाइम को बहुत कम बढ़ाता है।

एन्कोडेड टेक्स्ट के लिए फाइंडिंग्स सामान्य फाइंडिंग्स से इन तरीकों में भिन्न होती हैं:

- लोकेशन एन्कोडेड टेक्स्ट की सीमा को पॉइंट करता है
  - अगर नियम एन्कोडेड टेक्स्ट के बाहर मैच करता है, तो सीमा को भी शामिल करने के लिए समायोजित किया जाता है
- मैच और सीक्रेट में डिकोडेड वैल्यू होती है
- दो टैग जोड़े जाते हैं `decoded:<encoding>` और `decode-depth:<depth>`

वर्तमान में समर्थित एन्कोडिंग्स:

- **percent** - कोई भी प्रिंटेबल ASCII पर्सेंट एन्कोडेड वैल्यू
- **hex** - कोई भी प्रिंटेबल ASCII हेक्स एन्कोडेड वैल्यू >= 32 कैरेक्टर
- **base64** - कोई भी प्रिंटेबल ASCII बेस64 एन्कोडेड वैल्यू >= 16 कैरेक्टर

#### आर्काइव स्कैनिंग

कभी-कभी सीक्रेट्स आर्काइव फाइल्स जैसे zip फाइल्स या टारबॉल्स में पैक हो जाती हैं,
जिससे उन्हें ढूंढना कठिन हो जाता है। अब आप gitleaks को अपने आप आर्काइव्स को एक्सट्रैक्ट और उनकी सामग्री स्कैन करने के लिए कह सकते हैं। फ्लैग `--max-archive-depth` इस फीचर को दोनों `dir` और `git` स्कैन टाइप्स के लिए सक्षम करता है। डिफ़ॉल्ट मान "0" है, यानी यह फीचर डिफ़ॉल्ट रूप से डिसेबल्ड है।

रिकर्सिव स्कैनिंग समर्थित है क्योंकि आर्काइव्स में भी अन्य आर्काइव्स हो सकते हैं।
`--max-archive-depth` फ्लैग रिकर्सन लिमिट सेट करता है। रिकर्सन तब रुकता है जब निकालने के लिए कोई नया आर्काइव नहीं बचता, इसलिए बहुत ज्यादा मैक्स डेप्थ सेट करने से बस गहराई की संभावना बढ़ती है। उतना ही गहरा जाएगा जितना जरूरी है।

आर्काइव के भीतर पाए गए सीक्रेट्स के लिए फाइंडिंग्स में आर्काइव के अंदर फाइल का पाथ शामिल होगा। आंतरिक पाथ्स को `!` से अलग किया जाता है।

फाइंडिंग का उदाहरण (संक्षिप्त):

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

इसका मतलब है कि `files/.env.prod.` की लाइन 4 पर एक सीक्रेट डिटेक्ट हुआ,
जो कि `archives/files.tar` में है, जो कि `testdata/archives/nested.tar.gz` में है।

वर्तमान में समर्थित फॉर्मेट्स:

mholt के [archives package](https://github.com/mholt/archives)
द्वारा समर्थित [compression](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
और [archive](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
फॉर्मेट्स समर्थित हैं।

#### रिपोर्टिंग

Gitleaks में कई रिपोर्ट फॉर्मेट्स के लिए बिल्ट-इन सपोर्ट है: [`json`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/json_simple.json), [`csv`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/junit_simple.xml), और [`sarif`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/sarif_simple.sarif)।

यदि इनमें से कोई भी फॉर्मेट आपकी जरूरत के अनुरूप नहीं है, तो आप [Go `text/template` .tmpl फाइल](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) और `--report-template` फ्लैग का उपयोग कर अपना खुद का रिपोर्ट फॉर्मेट बना सकते हैं। टेम्पलेट [Masterminds/sprig टेम्पलेट लाइब्रेरी](https://masterminds.github.io/sprig/) की विस्तारित फंक्शनैलिटी का भी उपयोग कर सकता है।

उदाहरण के लिए, निम्न टेम्पलेट कस्टम JSON आउटपुट प्रदान करता है:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

उपयोग:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## प्रायोजन

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## एक्ज़िट कोड्स

जब भी लीक मिलें तो आप --exit-code फ्लैग के साथ एक्ज़िट कोड सेट कर सकते हैं। डिफ़ॉल्ट एक्ज़िट कोड्स नीचे दिए गए हैं:

```
0 - कोई लीक नहीं मिला
1 - लीक या त्रुटि मिली
126 - अज्ञात फ्लैग
```
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---