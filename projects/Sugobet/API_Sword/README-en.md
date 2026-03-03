[\[EN-ReadMe\]](https://github.com/Sugobet/API_Sword/blob/main/%5BEN%5D-README.md) <------ please read this
# WeChat Official Account: APT250

## Adhering to the principles of open source supremacy and communication learning, API Sword will be open-sourced and simultaneously launched on the official Burp plugin store BApp Store two weeks later (after September 7), facilitating everyone's future updates and usage. It is currently under official code review, and we believe it will be available on the BApp Store soon.

# [New Classic Burp Plugin] API Sword - Fully Automatic Deep Collection of APIs in Various Responses

The jar package is in the release; after being listed on the official Burp plugin store, it can also be downloaded from the store.

## Preface

This plugin combines my recent work content and some experience from the $40,000 bounty Microsoft account vulnerability API.

Developers using API Sword have repeatedly achieved results and general 0days in projects. With this tool, I no longer painfully search for any interfaces, paths, or parameters manually from any JS.

![Insert image description here](https://i-blog.csdnimg.cn/direct/388ed286aff845ce8863640b37d4636e.png)

Similar to many popular JS Finder, URLFinder, and other related JS and API mining tools, they are excellent tools, **and API Sword gains capability and advantage thanks to Burp's features.**

Screenshot of the plugin main page:

<img width="3020" height="1582" alt="image" src="https://github.com/user-attachments/assets/e1677009-917b-4e90-a5e8-ccd067263d6e" />

## Main Features of API Sword

API Sword is fully automatic with loop prevention, extracting APIs and JS files within the specified range from various responses, then recursively deeply extracting APIs, actively requesting APIs, JS, and other valuable files.

The API results are WYSIWYG; the right window shows the source JS of the API, allowing you to immediately get API parameter information from the JS, then Burp can jump over with ctrl + r for testing.

It is not as complicated as imagined; what API Sword does more is **reducing a large amount of repetitive, time-consuming, and tedious JS, API, and API parameter searching work for us.**

1. API Sword captures traffic within the scope passing through Burp and extracts the vast majority of links from **HTTP responses**.
2. API Sword cleans any links and paths extracted in the previous step, then **judges and actively initiates GET and POST requests to APIs, JS, etc.**
3. API Sword further processes the responses of the active requests from the previous step, continues extracting information from the responses, and repeats the previous step's actions. **API Sword has a loop prevention feature, so no need to worry about infinite request loops.**
4. API Sword pushes all qualified API requests, responses, and the JS file responses that source the API interfaces to the API Sword Burp GUI.
5. API Sword automatically adds all related requests to Burp's target sitemap. **You can fully enjoy the fruits brought by API Sword in the target sitemap's analysis and other functions.**

Users only need to enable API Sword and set a "reasonable scope," then continue clicking various functions of the web system in the browser, letting all traffic pass through Burp, and finally handing it over to API Sword for analysis and processing. API Sword will return the devil fruits you want.

**Considering opsec and other operational security risks, API Sword currently does not actively fuzz parameters. If there is demand later, this will be added as an optional feature.**

## How to Use?

`Note: The plugin requires Burp Suite version 2024.7 or above; (for versions below 2024.7, you need to manually turn off the "Use Original Headers" feature on the plugin's settings page)`

Using the API Sword is very simple,

1. Install the plugin into Burp version 2024 or later, ensure the plugin has no errors
2. Set the Scope for the plugin
3. Open the browser and ensure the browser traffic goes through Burp
4. Visit the target website, click and test anything you see on the site
5. After a while, check the fruits from the API Sword's Sitemap

## API Sword Settings

In the Scope tab, we can set the range, which can be URL, domain name, or IP

<img width="1946" height="1068" alt="image" src="https://github.com/user-attachments/assets/945d1e66-9d1a-4c59-920c-3fadacbeeb4f" />

This scope is especially important, it is recommended to consider carefully, otherwise you might easily scan outer space.

After setting the scope, let's look at the Setting tab

<img width="3018" height="1338" alt="image" src="https://github.com/user-attachments/assets/4e67c07f-0e37-470c-881e-fa234632d30b" />

1. Allow active API requests

This option is enabled by default, it is not recommended to turn it off, otherwise API Sword cannot extract data more deeply

2. Use original headers

Enabled by default, if you want to specifically test unauthorized API interfaces, you can turn this option off, which will not carry any cookies or session information

3. Immediately stop sending all requests

Disabled by default, used to pause in case of emergencies, recommended to use together with the first option as a brake

4. Clear all data in the current SiteMap

This button is used to clear all site data in API Sword's Site Map

![Insert image description here](https://i-blog.csdnimg.cn/direct/d7e8eca0e2994a65b9bae2abb8554e69.png)

5. Enable active HTTP request rate

Limit the interval time between each request

6. Whether to additionally add a custom path request during active requests

After enabling this option, API Sword will add the specified custom path to the main URL before concatenation

7. Filter out custom response codes that are not 200

8. Allow API Sword to actively search for baseURL from the response and actively concatenate paths to the baseURL

9. Add custom header fields: (automatically overwrite existing header fields)

10. Enable bypass of dangerous interface access (skip if the interface contains certain strings)

11. Save scope and all settings

12. Whether to add an extra custom path after the API interface and before the parameters

13. Thread count control

Other settings are under development and improvement. If you have any ideas, suggestions, or issues, you can provide feedback by opening an issue on GitHub.

## Acknowledgments

Thanks to `Microsoft`

Thanks to my `NSFOCUS mentor`

Thanks to `mil1ln`

Thanks to `Tanjie`

Thanks to everyone who provided valuable opinions and feedback for API Sword during the testing phase

Thanks to all the above for all the support provided to API Sword!
## TODO

1. Collect a plum blossom K polo shirt ⬛️
2. Add optional base URL path fuzzing ✅
3. Add custom response code filtering ✅
4. Add option for custom base path when API Sword actively requests ✅
5. Optimized matching strategy, unlocking 80% of API Sword performance ✅
6. API Sword active request optimization to avoid accessing dangerous APIs ✅
7. Fixed the issue where Burp's default header does not carry the CT field ✅
8. Optimized tags width in the response table ✅
9. Fixed UI flickering issue of sitemap ✅
10. Added optional custom request headers feature ✅
11. Added automatic sorting of tags in the response list ✅
12. Optimized matching strategy ✅
13. Optimized code blocks ⬛️
14. Registered Burp uninstall handling ✅
15. Added bilingual (Chinese-English) readable code comments throughout the code ⬛️
16. Added bilingual (Chinese-English) toggle feature in GUI ✅
17. Optimized UI to fix Burp lag and rendering issues ✅
18. Added save scope and configuration feature ✅
19. Added active HTTP request rate control feature ✅
20. Added multithreading feature ✅
21. Added custom path feature between interface suffix and parameter prefix ✅
22. Emergency fix for loop prevention logic failure caused by multithreading ✅
23. Fixed display error in auto sorting ✅
24. Optimized API list UI; arrow keys no longer interrupt input when inserting data ✅
25. Thoroughly fixed the bug where loop prevention logic still failed due to multithreading ✅
26. Added filter feature ✅
27. Added expand nodes and collapse all nodes feature ✅
28. Optimized clear site map feature ✅
29. Optimized js concatenation logic in CDN | cross-site to use referer as baseUrl ✅
30. Added manual scanning feature; manual scanning will auto add host to scope list: right-click on a request body in Burp -> Extensions -> API Sword -> API Scan ✅



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---