Simple Config GeoIP for Quantumult X (QuantumultX), Loon, Stash pre-configuration file includes Apple News unlock rules, ad-blocking routing rules, TikTok unlock Rewrite, Divine Machine routing rules, and VIP video parsing rewrite, and provides corresponding shortcuts

## Introduction
> + Integrate multiple rewrite configurations using Quantumult X and GeoIP features, remove most rules to save overhead, streamline rules and configuration files through Vercel redirection
- [Usage](https://github.com/smxl/500#使用方法)
- [Routing Rules and Rewrite](https://github.com/smxl/500#分流规则和重写)
- [Tools](https://github.com/smxl/500#小工具)
- [Configuration File Updates](https://github.com/smxl/500#配置文件更新)
- [Recommendations](https://github.com/smxl/500#推荐)

## Disclaimer

Disclaimer: Some scripts and content are written by ChatGPT

This project has been optimized on multiple [Quantumult X](https://apps.apple.com/us/app/quantumult-x/id1443988620) configuration files

All content is for reference only, no responsibility is assumed for any third-party content on this project, these links and contents are for reference and convenience only, and do not represent endorsement or approval by this project

Github address: [https://github.com/smxl/500](https://github.com/smxl/500)

## Usage

1. Download or copy the configuration file

[https://github.com/smxl/500/raw/main/500.conf](https://github.com/smxl/500/raw/main/500.conf)

[https://cnn.vercel.app/500.conf](https://cnn.vercel.app/500.conf)

2. Quantumult X - Gear - Configuration - Download - Paste - Confirm

3. Mitm - Generate Certificate - Configure Certificate - Install Certificate

4. System - Settings - General - About - Trust Certificate

5. Quantumult X - Gear - Nodes - Reference (Subscription) - Add at top right - Fill in label and resource path (your own subscription link)

6. Quantumult X - Gear - Other Settings - GeoLite2 Source Add GeoIP

7. Choose one GeoIP2-CN (copy link or download and import)
> - [Loyalsoldier](https://github.com/Loyalsoldier/geoip/raw/release/Country-only-cn-private.mmdb)
> - [Hackl0us](https://github.com/Hackl0us/GeoIP2-CN/raw/release/Country.mmdb)
> - [soffchen](https://github.com/soffchen/GeoIP2-CN/raw/release/Country.mmdb)

8. If you do not have your own subscription link, you can use it directly. If you need to use your own subscription, you can change the https://cnn.vercel.app/xv-sub under [server_remote] in the configuration file to your subscription link.

9. Startup: Since Quantumult X does not support url schema / url-schema startup, it is recommended to open Other Settings - VPN - Always On, and choose the remaining switches as needed.

Note 1: The default subscription link of this configuration file is publicly available information on the internet, and users with high privacy requirements are not recommended to use it for a long time. ~~Also, this configuration uses a public MITM certificate, it is recommended to generate and replace it yourself (when generating the certificate, you can skip the passphrase by not entering a password when exporting).~~

Note 2: Because QX does not provide support for NaïveProxy (naiveproxy), the current version is recommended to run on OpenWRT within the local network, linked through the local service ```socks5=192.168.124.124:1080, tag=LAN```, and add the startup script ```naive /[PATH]/config.json``` on the router side.

## Routing Rules and Rewrite

tag name|Type|Short link|Description - Strikethrough indicates disabled
-|-|-|-
ads|Rule|https://cnn.vercel.app/xf-ads|Ad blocking
cn|Rule|https://cnn.vercel.app/xf-cn|Direct connection to Mainland China services
global|Rule|https://cnn.vercel.app/xf-global|International services
hijacking|Rule|https://cnn.vercel.app/xf-hijacking|Anti-hijacking
privacy|Rule|https://cnn.vercel.app/xf-privacy|Privacy
tg|Rule|https://cnn.vercel.app/xf-tg|Telegram
unbreak|Rule|https://cnn.vercel.app/xf-unbreak|Rule fixes
-|-|-|-
adlite|Rewrite|https://cnn.vercel.app/xr-adlite|Rewrite for ad blocking
ads|Rewrite|https://cnn.vercel.app/xr-ads|Rewrite for ad blocking
adscript|Rewrite|https://cnn.vercel.app/xr-adscript|Script ad blocking
apple|Rewrite|https://cnn.vercel.app/xr-apple|Unlock restricted Apple services, remove weather compatibility for iOS16, please use Scriptable/IQair/Air Quality widgets to display US AQI
bing|Rewrite|https://cnn.vercel.app/xr-bing|New Bing with Safari w\ Edge
bili|Rewrite|https://cnn.vercel.app/xr-bili|Bilibili interface optimization
box|Rewrite|https://cnn.vercel.app/xr-box|BoxJS
-|-|-|Manual addition
covidsc|Rewrite|https://cnn.vercel.app/xr-covidsc|24h nucleic acid test report for Sichuan Tianfu Health Code full features - Alipay + WeChat, default off
covidsc|Rewrite|https://cnn.vercel.app/xr-covidhn|24h nucleic acid test report for Henan Yukan Code, default off
emby|Rewrite|https://cnn.vercel.app/xr-emby|Emby unlock, no notifications
fake|Rewrite|https://cnn.vercel.app/xr-fake|Fake Pro unlock, streamlined based on lk, and added Spotify Pro
jsc|Rewrite|https://cnn.vercel.app/xr-jsc|Script to obtain Cookies
lk|Rewrite|https://cnn.vercel.app/xr-lk|Fake VIP for foreign services
upgrade|Rewrite|https://cnn.vercel.app/xr-upgrade|Block app update checks
res|Rewrite|https://cnn.vercel.app/xr-res|Mainland software optimization
search|Rewrite|https://cnn.vercel.app/xr-search|DuckDuckGo search engine rewrite
v|Rewrite|https://cnn.vercel.app/xr-v|Video Parsing Rewrite

You can adjust the above rules and whether rewriting needs to be enabled according to your situation. For example: If you rarely use overseas software, then ```lk Rewrite https://cnn.vercel.app/xr-lk Foreign Services Fake VIP``` The VIP/Pro unlocks provided for multiple software are useless to you [some of these rewrites have expired]

Similarly, ```fake https://cnn.vercel.app/xr-fake Fake Pro Unlock``` is a simplified version of this rule

In 2024, due to changes in the iOS API, the new version of TikTok only needs to modify the system country and one routing rule to use ```host-wildcard, *tiktok*, proxy```

## Utilities

Tool|Function|Link/Supplement
-|-|-
Quick Search|Set Safari default search engine to DuckDuckGo|Default is Google, prefix two letters to specify other search engines Baidu:bd/Magi:mm/Twitter:tt/YouTube:yt/WolframAlpha:wa + space + keyword

After enabling fake rewrite, these software have enhanced effects: Adguard, Day One, Draft, Documents, Lightroom, PS Express, Memrise, Spotify pro*... Asterisk* indicates uncertainty whether in-app purchase or VIP simulation is unlocked

After enabling res rewrite, these software have enhancements: Bilibili, Caiyun Weather, WeChat, Baidu Netdisk...

## Configuration File Update

500.conf

[https://github.com/smxl/500/raw/main/500.conf](https://github.com/smxl/500/raw/main/500.conf)

[https://cnn.vercel.app/q](https://cnn.vercel.app/q)

## Recommendation

This configuration file references some projects or services, you can find them in vercel.json

To facilitate access to the original projects, the references in the configuration file use the format `https://github.com/user/project/raw/branch/directory/file`

Please copy `https://github.com/user/project/` to the address bar to access the referenced project

--

Minimalist template https://cnn.vercel.app removes most useless configurations, keeping only the basic framework

Thanks to ilovexjp ILoveNucleicAcidTest etc.

Thanks to AI, Web3, and whitepapers

Thanks to entertainment and yourself


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---