# Awesome Vulnerable
[![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)
![](https://visitor-badge.laobi.icu/badge?page_id=kaiiyer.awesome-vulnerable)
![Git Actions](https://github.com/kaiiyer/awesome-vulnerable/workflows/CI/badge.svg)
 <a href='https://ind.ie/ethical-design'><img style='margin-left: auto; margin-right: auto;' alt='We practice Ethical Design' src='https://img.shields.io/badge/Ethical_Design-_▲_❤_-blue.svg'></a>
[![GitHub stars](https://img.shields.io/github/stars/kaiiyer/awesome-vulnerable)](https://github.com/kaiiyer/awesome-vulnerable/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/kaiiyer/awesome-vulnerable.svg)](https://GitHub.com/kaiiyer/awesome-vulnerable/issues/)
[![GitHub pull-requests](https://img.shields.io/github/issues-pr/kaiiyer/awesome-vulnerable.svg)](https://GitHub.com/kaiiyer/awesome-vulnerable/pull/)
[![GitHub contributors](https://img.shields.io/github/contributors/kaiiyer/awesome-vulnerable.svg)](https://GitHub.com/kaiiyer/awesome-vulnerable/graphs/contributors/)
![Last Commit on GitHub](https://img.shields.io/github/last-commit/kaiiyer/awesome-vulnerable.svg)

<img src="https://octodex.github.com/images/grim-repo.jpg" alt="Octocat" width="210" height="225">

*รายการที่ได้รับการคัดสรรของแอปพลิเคชันและระบบที่มีช่องโหว่ ซึ่งสามารถใช้เป็นห้องปฏิบัติการฝึกทดสอบการเจาะระบบ (PENETRATION TESTING PRACTICE LAB) รายการนี้มีเป้าหมายเพื่อช่วยทั้งผู้เริ่มต้นและมืออาชีพในการทดสอบและเพิ่มพูนทักษะด้านการเจาะระบบของตนเอง*

# สารบัญ

- [เว็บแอปพลิเคชันที่มีช่องโหว่](#Vulnerable-Web-Applications)
- [เว็บไซต์จากผู้จำหน่ายซอฟต์แวร์สำหรับทดสอบความปลอดภัย](#Sites-by-Vendors-of-Security-Testing-Software)
- [เว็บไซต์สำหรับดาวน์โหลดซอฟต์แวร์เวอร์ชันเก่า](#Sites-for-Downloading-Older-Versions-of-Various-Software)
- [เว็บไซต์สำหรับพัฒนาทักษะการแฮ็กของคุณ](#Sites-for-Improving-Your-Hacking-Skills)
- [แลบ](#Labs)
- [แอปมือถือ](#Mobile-Apps)

## เว็บแอปพลิเคชันที่มีช่องโหว่

- [BadStore](https://www.vulnhub.com/entry/badstore-123,41/) - Badstore.net อุทิศเพื่อช่วยให้คุณเข้าใจว่าผู้ไม่หวังดีใช้ประโยชน์จากช่องโหว่ของเว็บแอปพลิเคชันอย่างไร และแสดงให้คุณเห็นวิธีลดความเสี่ยง ซอฟต์แวร์สาธิต Badstore ของเราออกแบบมาเพื่อแสดงเทคนิคการแฮ็กที่พบบ่อย
- [BodgeIt Store](http://code.google.com/p/bodgeit/) - BodgeIt Store เป็นเว็บแอปพลิเคชันที่มีช่องโหว่ เหมาะสำหรับผู้เริ่มต้นทดสอบการเจาะระบบ
- [Bug Bounty Hunter](https://bugbountyhunter.com/) - BugBountyHunter เป็นแพลตฟอร์มฝึกอบรมที่สร้างโดย zseano นักล่า Bug Bounty เพื่อช่วยให้คุณเรียนรู้เกี่ยวกับช่องโหว่ของเว็บแอปพลิเคชันและวิธีเริ่มต้น
- [Butterfly Security Project](http://thebutterflytmp.sourceforge.net/) - โครงการ ButterFly เป็นสภาพแวดล้อมเพื่อการศึกษา ให้ความเข้าใจเกี่ยวกับช่องโหว่ของเว็บแอปพลิเคชันและ PHP ที่พบบ่อย พร้อมตัวอย่างวิธีการป้องกันช่องโหว่เหล่านั้น
- [bWAPP](http://sourceforge.net/projects/bwapp/files/bee-box/) - bee-box เป็น Linux VM ที่ติดตั้ง bWAPP ไว้ล่วงหน้า
- [Vulert](https://raw.githubusercontent.com/kaiiyer/awesome-vulnerable/master/Vulert.com) - Vulert ช่วยรักษาความปลอดภัยซอฟต์แวร์โดยตรวจจับช่องโหว่ใน dependencies แบบ open-source โดยไม่ต้องเข้าถึงโค้ดของคุณ รองรับ Js, PHP, Java, Python และอื่น ๆ
- [CloudGoat](https://github.com/RhinoSecurityLabs/cloudgoat.git) - CloudGoat เป็นเครื่องมือสำหรับติดตั้ง AWS ที่มีช่องโหว่โดยออกแบบจาก Rhino Security Labs
- [Commix](https://github.com/stasinopoulos/commix-testbed) - รวบรวมหน้าเว็บที่มีช่องโหว่ด้าน command injection
- [CryptOMG](https://github.com/SpiderLabs/CryptOMG) - CryptOMG เป็น test bed แบบ CTF ที่ปรับแต่งได้ สำหรับเน้นข้อบกพร่องทั่วไปในการใช้งานการเข้ารหัส
- [CTFchallenge](https://ctfchallenge.com/) - CTFchallenge คือชุดของเว็บแอปพลิเคชันที่มีช่องโหว่ 12 ตัว แต่ละตัวมีโครงสร้างพื้นฐานเสมือนจริงที่สร้างขึ้นบนหลาย ๆ ซับโดเมน พร้อมช่องโหว่จาก bug report, ประสบการณ์จริง หรือ OWASP Top 10
- [Damn Vulnerable Cloud Application](https://github.com/m6a-UdS/dvca.git) - Damn Vulnerable Cloud Application
- [Damn Vulnerable Node Application(DVNA)](https://github.com/appsecco/dvna) - Damn Vulnerable NodeJS Application
- [Damn Vulnerable Web App (DVWA)](http://www.dvwa.co.uk/) - เว็บแอปพลิเคชันที่มีช่องโหว่อย่างร้ายแรง
- [Damn Vulnerable Web Services (DVWS)](https://github.com/snoopysecurity/dvws) -
Damn Vulnerable Web Services เป็นเว็บแอปพลิเคชันที่ไม่ปลอดภัย ซึ่งมีส่วนประกอบ web service ที่มีช่องโหว่หลากหลาย ใช้เรียนรู้ช่องโหว่ของ web service ในโลกจริง
- [Firing Range](https://public-firing-range.appspot.com/) - test bed ที่สร้างโดย Google สำหรับเครื่องมือสแกนความปลอดภัยเว็บแอปพลิเคชันอัตโนมัติ
- [Foundstone Hackme Bank](https://www.mcafee.com/us/downloads/free-tools/hacme-bank.aspx) - เครื่องมือฟรีของ McAfee เพื่อช่วยในด้านความปลอดภัย
- [Foundstone Hackme Books](https://www.mcafee.com/us/downloads/free-tools/hacmebooks.aspx) - เครื่องมือฟรีของ McAfee เพื่อช่วยในด้านความปลอดภัย
- [Foundstone Hackme Casino](https://raw.githubusercontent.com/kaiiyer/awesome-vulnerable/master/httsp://www.mcafee.com/us/downloads/free-tools/hacme-casino.aspx)- เครื่องมือฟรีของ McAfee เพื่อช่วยในด้านความปลอดภัย
- [Foundstone Hackme Shipping](https://www.mcafee.com/us/downloads/free-tools/hacmeshipping.aspx) - เครื่องมือฟรีของ McAfee เพื่อช่วยในด้านความปลอดภัย
- [Foundstone Hackme Travel](https://www.mcafee.com/us/downloads/free-tools/hacmetravel.aspx) - เครื่องมือฟรีของ McAfee เพื่อช่วยในด้านความปลอดภัย
- [GameOver](https://sourceforge.net/projects/null-gameover/) - โครงการ GameOver ก่อตั้งขึ้นเพื่อฝึกอบรมและให้ความรู้เบื้องต้นเกี่ยวกับความปลอดภัยเว็บ พร้อมอธิบายการโจมตีเว็บที่พบบ่อยและอธิบายการทำงานของมัน
- [hackxor](https://hackxor.sourceforge.net/cgi-bin/index.pl) - Hackxor เป็นเกมแฮ็กเว็บแอปพลิเคชันที่สมจริง ออกแบบมาเพื่อช่วยให้ผู้เล่นทุกระดับพัฒนาทักษะ ภารกิจทั้งหมดอิงจากช่องโหว่จริงที่พบขณะทดสอบเจาะระบบ, bug bounty, และงานวิจัย
- [Hackazon](https://github.com/rapid7/hackazon) - เว็บแอปพลิเคชันที่มีช่องโหว่สมัยใหม่
- [LAMPSecurity](http://sourceforge.net/projects/lampsecurity/) - การฝึกอบรม LAMPSecurity คือชุดของ VM ที่มีช่องโหว่ พร้อมคู่มือประกอบ สำหรับสอนความปลอดภัย linux, apache, php, mysql
- [OWASP Mantra](https://sourceforge.net/projects/getmantra/) - Security Framework บนเบราว์เซอร์ที่ฟรีและโอเพ่นซอร์ส รวมเครื่องมือฟรีและโอเพ่นซอร์สเพื่อเจาะระบบ นักพัฒนาเว็บ หรือผู้เชี่ยวชาญความปลอดภัย
- [NOWASP / Mutillidae 2](https://github.com/webpwnized/mutillidae) - OWASP Mutillidae II เป็นเว็บแอปพลิเคชันโอเพ่นซอร์สที่มีช่องโหว่โดยเจตนา สำหรับผู้ที่สนใจด้านความปลอดภัยเว็บ
- [OWASP BWA](http://code.google.com/p/owaspbwa/) - รวบรวมเว็บแอปพลิเคชันที่มีช่องโหว่ แจกจ่ายในรูปแบบ Virtual Machine ที่ใช้งานกับ VMware Player และ VMware vSphere Hypervisor (ESXi) ได้ฟรี
- [OWASP Hackademic](https://github.com/Hackademic/hackademic/) - โครงการนี้ช่วยทดสอบความรู้เกี่ยวกับความปลอดภัยเว็บแอปพลิเคชัน ใช้ฝึกโจมตีเว็บแอปพลิเคชันในสภาพแวดล้อมจริงที่ควบคุมและปลอดภัย
- [OWASP SiteGenerator](https://www.owasp.org/index.php/Owasp_SiteGenerator) - OWASP SiteGenerator ช่วยสร้างเว็บไซต์แบบไดนามิกด้วยไฟล์ XML และช่องโหว่ที่กำหนดไว้ล่วงหน้าหลากหลายรูปแบบ ครอบคลุมภาษา .Net และโครงสร้างเว็บต่าง ๆ เช่น Html, Javascript, Flash, Java
- [OWASP Bricks](https://sourceforge.net/projects/owaspbricks/) - แพลตฟอร์มการเรียนรู้ความปลอดภัยเว็บแอปพลิเคชันที่สร้างบน PHP และ MySQL
- [OWASP Security Shepherd](https://www.owasp.org/index.php/OWASP_Security_Shepherd) - OWASP Security Shepherd คือแพลตฟอร์มฝึกอบรมด้านความปลอดภัยเว็บและแอปพลิเคชันบนมือถือ ออกแบบเพื่อสร้างความตระหนักรู้ด้านความปลอดภัยในกลุ่มผู้ใช้หลายระดับ
- [PentesterLab](https://pentesterlab.com/) - ทำให้การเรียนรู้การแฮ็กเว็บเป็นเรื่องง่าย!
- [SecuriBench](https://suif.stanford.edu/~livshits/securibench/) - Stanford SecuriBench คือชุดโปรแกรมโอเพ่นซอร์สในชีวิตจริง สำหรับใช้ทดสอบเครื่องมือความปลอดภัยทั้ง static และ dynamic Release .91a เน้นไปที่เว็บแอปพลิเคชันภาษา Java
- [SentinelTestbed](https://github.com/dobin/SentinelTestbed) - เว็บไซต์ที่มีช่องโหว่ ใช้ทดสอบฟีเจอร์ของ sentinel
- [SocketToMe](http://digi.ninja/projects/sockettome.php) - ผสมผสานแชท เกมทายตัวเลข และฟีเจอร์ซ่อนอื่น ๆ
- [sqli-labs](https://github.com/Audi-1/sqli-labs) - SQLI labs สำหรับทดสอบ error based, Blind boolean based, Time based SQL Injection
- [MCIR (Magical Code Injection Rainbow)](https://github.com/SpiderLabs/MCIR) - Magical Code Injection Rainbow! MCIR คือเฟรมเวิร์กสำหรับสร้าง testbed ช่องโหว่ที่ปรับแต่งได้ MCIR ยังเป็นชุดของ testbed ช่องโหว่แบบปรับแต่งได้
- [Sqlilabs](https://github.com/himadriganguly/sqlilabs) - ห้องทดลองสำหรับเรียนรู้เทคนิค SQL Injection
- [VulnApp](https://www.nth-dimension.org.uk/blog.php?id=88) - แอปพลิเคชัน ASP.net ที่รวมแอปพลิเคชันที่พบบ่อยในการทดสอบเจาะระบบ
- [VulnLab](https://github.com/Yavuzlar/VulnLab) - ห้องทดลองเว็บแอปพลิเคชันที่มีช่องโหว่โดยใช้ Docker
- [PuzzleMall](https://code.google.com/p/puzzlemall/) - เว็บแอปพลิเคชันที่มีช่องโหว่สำหรับฝึก session puzzling
- [WackoPicko](https://github.com/adamdoupe/WackoPicko) - WackoPicko คือเว็บแอปพลิเคชันที่มีช่องโหว่สำหรับทดสอบเครื่องมือสแกนช่องโหว่เว็บแอปพลิเคชัน
- [WebGoat.NET](https://github.com/jerryhoff/WebGoat.NET/) - เว็บแอปพลิเคชันนี้เป็นแพลตฟอร์มการเรียนรู้ที่พยายามสอนข้อบกพร่องความปลอดภัยเว็บที่พบได้บ่อย โดยมีข้อบกพร่องทั่วไปซึ่งใช้ได้กับเว็บแอปพลิเคชันส่วนใหญ่
- [OWASP WebGoat8](https://github.com/webgoat/webgoat) - OWASP Webgoat 8 เป็นแพลตฟอร์มการเรียนรู้สำหรับข้อบกพร่องความปลอดภัยเว็บที่พบได้บ่อย มีข้อบกพร่องทั่วไปที่ใช้ได้กับเว็บแอปพลิเคชันส่วนใหญ่ พัฒนาใน Java และมีการดูแลอย่างต่อเนื่อง
- [OWASP WrongSecrets](https://github.com/commjoen/wrongsecrets) - OWASP WrongSecrets เป็นแอปที่มีช่องโหว่ซึ่งแสดงวิธีไม่ควรเก็บความลับ และช่วยเพิ่มทักษะการตามหาความลับ
- [WebSecurity Dojo](https://www.mavensecurity.com/web_security_dojo/) - สภาพแวดล้อมฝึกอบรมแบบ self-contained สำหรับการทดสอบเจาะระบบเว็บแอปพลิเคชันที่ฟรีและโอเพ่นซอร์ส เครื่องมือ + เป้าหมาย = Dojo
- [XVWA](https://github.com/s4n7h0/xvwa) - XVWA คือเว็บแอปพลิเคชันที่เขียนโค้ดแย่ใน PHP/MySQL สำหรับผู้สนใจด้านความปลอดภัยแอปพลิเคชัน
- [Zap WAVE](https://code.google.com/p/zaproxy/downloads/detail?name=zap-wave-0.1.zip) - เครื่องมือทดสอบเจาะระบบแบบบูรณาการที่ใช้งานง่าย สำหรับค้นหาช่องโหว่ในเว็บแอปพลิเคชัน
- [Web-Security Academy](https://portswigger.net/web-security) - แพลตฟอร์มฟรีสำหรับเรียนรู้และทดสอบทักษะความปลอดภัยเว็บแอปพลิเคชัน พร้อมห้องทดลองและเนื้อหาการเรียนรู้โดย Portswigger
- [OWASP Juice Shop](https://github.com/juice-shop/juice-shop) - แพลตฟอร์มโอเพ่นซอร์สสำหรับทดสอบทักษะความปลอดภัยเว็บแอปพลิเคชัน มีความท้าทายการแฮ็กหลากหลายระดับความยาก
- [tegal1337/0l4bs](https://github.com/tegal1337/0l4bs) - ห้องทดลอง Cross-site scripting (XSS) สำหรับผู้สนใจความปลอดภัยเว็บแอปพลิเคชัน
- [tegal1337/br0w](https://github.com/tegal1337/br0w) - Hack The Br0w เล่นเบราว์เซอร์ของคุณและเรียนรู้เพิ่มเติม สนุกกับการแฮ็ก!
- [Pentest-Ground](https://pentest-ground.com/) - สนามฝึกเจาะระบบที่มีเว็บแอปพลิเคชันที่มีช่องโหว่หลายตัว
- [Unguard](https://github.com/dynatrace-oss/unguard) - ตัวอย่างแอปพลิเคชัน microservices บนคลาวด์ที่ไม่ปลอดภัยสำหรับ Kubernetes มีบริการ Java, .NET, Node.js, Go, PHP, ฐานข้อมูล MariaDB และ Redis, Envoy proxy และตัวสร้างโหลดที่มีช่องโหว่
## เว็บไซต์สำหรับดาวน์โหลดเวอร์ชันเก่าของซอฟต์แวร์ต่างๆ

- [Exploit-DB](http://www.exploit-db.com/) - ฐานข้อมูล Exploit ที่ดูแลโดย Offensive Security บริษัทฝึกอบรมด้านความปลอดภัยข้อมูลที่ให้บริการใบรับรองความปลอดภัยข้อมูลหลากหลายประเภท รวมทั้งบริการทดสอบเจาะระบบขั้นสูง
- [Old Apps](http://www.oldapps.com/) - ให้ผู้ใช้สามารถเข้าถึงซอฟต์แวร์ที่คุ้นเคยในหลากหลายเวอร์ชันปัจจุบันและเวอร์ชันก่อนหน้าได้ฟรี
- [Old Version](http://www.oldversion.com/) - เลือกชื่อซอฟต์แวร์... เพื่อย้อนกลับไปใช้เวอร์ชันที่คุณชื่นชอบ!
- [VirtualHacking Repo ](https://sourceforge.net/projects/virtualhacking/files/apps@realworld/) - ห้องปฏิบัติการ Virtual Hacking
- [All Version](http://www.PortableApps.com/) - PortableApps เป็นโซลูชันซอฟต์แวร์แบบพกพาที่ได้รับความนิยมสูงสุดของโลก ให้คุณพกพาซอฟต์แวร์ที่คุณชื่นชอบไปได้ทุกที่

## เว็บไซต์จากผู้ผลิตซอฟต์แวร์ทดสอบความปลอดภัย

- [Acunetix acuforum](https://testasp.vulnweb.com/) - ฟอรัมที่ตั้งใจให้มีช่องโหว่ต่อ SQL Injection, directory traversal และการโจมตีผ่านเว็บอื่นๆ
- [Acunetix acublog](https://testaspnet.vulnweb.com/) - เว็บไซต์ทดสอบสำหรับ Acunetix มีช่องโหว่ต่อ SQL Injection, Cross-site Scripting (XSS) และอื่นๆ
- [Acunetix acuart](https://testphp.vulnweb.com/) - ตัวอย่างแอปพลิเคชัน PHP ที่ตั้งใจให้มีช่องโหว่ต่อการโจมตีเว็บ ใช้สำหรับทดสอบ Acunetix
- [Acunetix SecurityTweets](http://testhtml5.vulnweb.com) - เว็บไซต์ทดสอบ HTML5 ที่มีช่องโหว่ สำหรับ Acunetix Web Vulnerability Scanner
- [Cenzic crackmebank](http://crackme.cenzic.com) -  เว็บไซต์สำหรับการทดสอบและสาธิต
- [Fortify Zero Bank](http://zero.webappsecurity.com) - เว็บไซต์ธนาคารออนไลน์ฟรีนี้จัดทำโดย Micro Focus Fortify เพื่อสาธิตประสิทธิภาพของผลิตภัณฑ์ WebInspect ในการตรวจจับและรายงานช่องโหว่ของเว็บแอปพลิเคชัน
- [Fortify IWA.NET (Insecure Web Application) Pharmacy Direct](https://github.com/fortify/IWA-DotNet) - ตัวอย่าง Microsoft.NET Core Web Application สำหรับใช้ในสถานการณ์ DevSecOps และการสาธิต ประกอบด้วยตัวอย่างโค้ดที่ไม่ปลอดภัย ซึ่งสามารถตรวจพบได้ด้วยเครื่องมือทดสอบความปลอดภัยแอปพลิเคชันทั้งแบบ static และ dynamic เช่นที่จัดหาโดย [OpenText](https://www.opentext.com)
- [Fortify IWA.JAVA (Insecure Web Application) Pharmacy Direct](https://github.com/fortify/IWA-Java) - ตัวอย่าง Java/Spring Web Application สำหรับใช้ในสถานการณ์ DevSecOps และการสาธิต ประกอบด้วยตัวอย่างโค้ดที่ไม่ปลอดภัย ซึ่งสามารถตรวจพบได้ด้วยเครื่องมือทดสอบความปลอดภัยแอปพลิเคชันทั้งแบบ static และ dynamic เช่นที่จัดหาโดย [OpenText](https://www.opentext.com)
- [IBM altoromutual](http://demo.testfire.net/) - เว็บไซต์ AltoroJ จัดทำโดย IBM Corporation เพื่อแสดงประสิทธิภาพของผลิตภัณฑ์ IBM ในการตรวจจับช่องโหว่เว็บแอปพลิเคชันและข้อบกพร่องของเว็บไซต์
- [Mavituna testsparker](http://aspnet.testsparker.com) -  เว็บไซต์ทดสอบและสาธิตสำหรับ Netsparker
- [Mavituna testsparker](http://php.testsparker.com) - เว็บไซต์ทดสอบและสาธิตสำหรับ Netsparker, Next Generation Web Application Security Scanner เริ่มต้น Netsparker เพื่อสแกนเว็บไซต์นี้และตรวจหาช่องโหว่
- [Mavituna testsparker](http://angular.testsparker.com) -  เว็บไซต์ทดสอบและสาธิตสำหรับ Netsparker
- [NTOSpider Test Site](http://www.webscantest.com/) - เว็บไซต์นี้ถูกตั้งขึ้นเพื่อทดสอบเครื่องมือสแกนเว็บแอปพลิเคชันอัตโนมัติเช่น AppSpider
## เว็บไซต์สำหรับพัฒนาทักษะการแฮ็กของคุณ

- [Blue Team Labs Online - Cyber Range](https://blueteamlabs.online/) - แพลตฟอร์มในรูปแบบเกมสำหรับฝ่ายป้องกันเพื่อฝึกฝนทักษะในการสืบสวนความปลอดภัยและโจทย์ท้าทายต่าง ๆ ครอบคลุม; การตอบสนองต่อเหตุการณ์, นิติวิทยาศาสตร์ดิจิทัล, การปฏิบัติการด้านความปลอดภัย, วิศวกรรมย้อนกลับ และการล่าภัยคุกคาม
- [Embedded Security CTF](https://microcorruption.com) - กระเป๋าเอกสารที่เต็มไปด้วยพันธบัตร Cy Yombinator ที่มีมูลค่าหลายพันล้านดอลลาร์ถูกซ่อนไว้ในโกดังทั่วโลก คุณจะต้องช่วยขโมยกระเป๋าเหล่านี้
- [EnigmaGroup](http://www.enigmagroup.org/) - Enigma Group มอบแหล่งข้อมูลด้านความปลอดภัยที่ถูกกฎหมายและปลอดภัยให้สมาชิกเพื่อพัฒนาทักษะการเจาะระบบผ่านโจทย์ท้าทายหลากหลายที่จัดเตรียมโดยเว็บไซต์นี้
- [Escape](http://escape.alf.nu/) - โค้ดนี้สร้าง HTML ในลักษณะที่ไม่ปลอดภัย พิสูจน์โดยการเรียก alert(1)
- [Google Gruyere](http://google-gruyere.appspot.com/) - ห้องปฏิบัติการนี้แสดงให้เห็นถึงวิธีที่ช่องโหว่ของเว็บแอปพลิเคชันสามารถถูกโจมตีและวิธีป้องกันการโจมตีเหล่านี้
- [Forensic Practical](http://www.forensickb.com/2008/01/forensic-practical.html) - ฝึกฝนทักษะนิติวิทยาศาสตร์และรันมัลแวร์ที่พบในฮันนี่พอตโดยติดตั้งลงในระบบคอมพิวเตอร์ที่สะอาดและสังเกตพฤติกรรมของมัน
- [Gh0st Lab](http://www.gh0st.net/) - แนวคิดดั้งเดิมของเครือข่ายนี้คือการสร้างเครือข่ายวิจัยด้านความปลอดภัยที่ผู้มีความสนใจเหมือนกันสามารถทำงานร่วมกันเพื่อเป้าหมายร่วมคือความรู้
- <b>[Hack The Box](https://www.hackthebox.eu)</b> - แพลตฟอร์มออนไลน์ที่ให้คุณทดสอบทักษะการเจาะระบบและแลกเปลี่ยนแนวคิดและวิธีการกับผู้คนหลายพันคนในแวดวงความปลอดภัย
- <b>[TryHackMe](https://tryhackme.com/)</b> - การฝึกอบรมความปลอดภัยไซเบอร์ที่ง่ายขึ้น ประสบการณ์การเรียนรู้ที่สะดวกด้วยคอร์สสำเร็จรูปที่มีเครื่องเสมือน (VM) อยู่บนคลาวด์พร้อมใช้งาน
- [Hack This Site](http://www.hackthissite.org/) - Hack This Site เป็นสนามฝึกซ้อมสำหรับแฮ็กเกอร์ที่ฟรี ปลอดภัย และถูกกฎหมาย เพื่อทดสอบและขยายทักษะการแฮ็กของคุณ
- [HackThis](http://www.hackthis.co.uk/) - Defend the Web เป็นแพลตฟอร์ม Cyber Security แบบอินเทอร์แอคทีฟ
- [HackQuest](http://www.hackquest.com/) - โฮสติ้งเว็บแบบไม่ระบุตัวตน, เซิร์ฟเวอร์เสมือน, อีเมลที่ปลอดภัย
- [Hack.me](https://hack.me) - Hacking-Lab เป็นบริการโดย Security Competence GmbH บริษัทในเครือของ Compass Security AG ในสวิตเซอร์แลนด์
Compass Security เป็นบริษัทที่มีชื่อเสียงในยุโรปเชี่ยวชาญด้านการทดสอบเจาะระบบ, การตอบสนองต่อเหตุการณ์, นิติวิทยาศาสตร์ดิจิทัล และการฝึกอบรมความปลอดภัย
- [Hacking-Lab](https://www.hacking-lab.com) - Hack.me เป็นโครงการแบบชุมชนที่ให้บริการฟรี ขับเคลื่อนโดย eLearnSecurity ชุมชนสามารถสร้าง โฮสต์ และแบ่งปันโค้ดเว็บแอปพลิเคชันที่มีช่องโหว่เพื่อการศึกษาและวิจัย
- [Hacker Test](http://www.hackertest.net/) - HackerTest.net คือการจำลองสถานการณ์แฮ็กเกอร์ออนไลน์ รูปแบบใหม่ที่จำลองสถานการณ์จริงนี้จะช่วยให้คุณพัฒนาความรู้ด้านความปลอดภัยใน JavaScript, PHP, HTML และการคิดเชิงกราฟิก
- [Halls Of Valhalla](http://halls-of-valhalla.org/beta/challenges) - Valhalla เป็นสถานที่สำหรับแบ่งปันความรู้และแนวคิด ผู้ใช้สามารถส่งโค้ด รวมถึงข่าวสารและบทความด้านวิทยาศาสตร์ เทคโนโลยี และวิศวกรรม
- [Hax.Tor](http://hax.tor.hu/) - HaX.ToR.Hu เป็นเว็บไซต์โจทย์ท้าทายที่เน้นการสอนประเด็นพื้นฐานด้านความปลอดภัยในรูปแบบที่สนุกสนาน
- [Metasploit Unleashed    ](https://www.offensive-security.com/metasploit-unleashed/) - คอร์ส Metasploit Unleashed (MSFU) จัดให้โดย Offensive Security ฟรี เพื่อสร้างความตระหนักรู้ให้กับเด็กด้อยโอกาสในแอฟริกาตะวันออก
- [OverTheWire](http://www.overthewire.org/wargames/) - เกมวอร์เกมของชุมชน OverTheWire ช่วยให้คุณเรียนรู้และฝึกฝนแนวคิดด้านความปลอดภัยในรูปแบบเกมที่สนุกสนาน
- [PentestIT](https://lab.pentestit.ru/) - ห้องปฏิบัติการทดสอบเจาะระบบ "Test lab" จำลองโครงสร้างพื้นฐานของบริษัทจริง สร้างขึ้นเพื่อการทดสอบเจาะระบบอย่างถูกกฎหมายและพัฒนาทักษะเจาะระบบ
- [CSC Play on Demand](https://pod.cybersecuritychallenge.org.uk/) - เป้าหมายของโจทย์นี้คือระบุวิธีที่บุคคลภายในอาจรั่วไหลข้อมูลลับขององค์กรโดยตั้งใจหรือไม่ตั้งใจผ่านไฟล์ที่ดูเหมือนไม่เป็นอันตราย
- [Root Me](http://www.root-me.org/?lang=en) - วิธีที่รวดเร็ว ง่าย และประหยัดในการฝึกฝนทักษะแฮ็กของคุณ
- [Security Treasure Hunt](http://www.securitytreasurehunt.com/) - โจทย์ใหม่สำหรับการวิเคราะห์ช่องโหว่เว็บโดยอิงจาก Packet Capture เปิดให้เล่นถึง 30 เมษายน 2013 สนับสนุนโดย Cyber Aces
- [Smash The Stack](http://www.smashthestack.org/) - เครือข่ายวอร์เกม
- [SQLZoo](http://sqlzoo.net/hack/) - การโจมตีแบบ SQL Inject ต้องแก้ปริศนาที่ผสมผสานระหว่างเกม Hangman และ 20 Questions ซึ่งต้องเข้าใจ SQL พอสมควรและใช้ไหวพริบอย่างมาก
- [TheBlackSheep and Erik](http://www.bright-shadows.net/) - นำเสนอโจทย์นับร้อยด้านการเขียนโปรแกรม, JavaScript, PHP, Java, สเตกาโนกราฟี, การเข้ารหัส และอื่น ๆ
- [ThisIsLegal](http://thisislegal.com/) - เว็บไซต์วอร์เกมสำหรับแฮ็กเกอร์ที่มีฟอรัมและบทเรียนอีกมากมาย
- [Try2Hack](http://www.try2hack.nl/) - เว็บไซต์นี้มีโจทย์ท้าทายด้านความปลอดภัยหลายรายการเพื่อความบันเทิงของคุณ นับเป็นหนึ่งในเว็บไซต์โจทย์ท้าทายที่เก่าแก่ที่สุดที่ยังเปิดอยู่
- [VulnHub](https://vulnhub.com/) - รวมโฮสต์ที่มีช่องโหว่และโจทย์ที่เกี่ยวข้องเพื่อให้คุณได้ฝึกประสบการณ์จริงด้านความปลอดภัยไซเบอร์
- [XSS: Can You XSS This?](http://canyouxssthis.com/HTMLSanitizer/) - ใช้ HTMLSanitizer เพื่อปกป้องเว็บแอปของคุณ
- [XSS Game](https://xss-game.appspot.com/) - เรียนรู้การค้นหาและโจมตีช่องโหว่ XSS
- [XSS: ProgPHP](http://xss.progphp.com/) - การจดทะเบียนโดเมนรุ่นใหม่ Progphp.com กำลังจะมาเร็ว ๆ นี้!
- [Pwnable.tw](http://pwnable.tw/) - ชุดโจทย์ pwnable คุณภาพสูงใหม่ล่าสุด
- [Pwnable.kr](http://pwnable.kr/) - หนึ่งในชุดโจทย์วอร์เกมที่ได้รับความนิยมมากที่สุดในช่วงหลัง
- [PicoCTF](https://picoctf.com/) - ออกแบบมาสำหรับนักเรียนมัธยมปลาย โดยแม้กิจกรรมจะเปลี่ยนใหม่ทุกปี แต่ก็เปิดให้ใช้งานออนไลน์และมีความยากที่ไล่ระดับได้ดี
- [CTF Learn](http://ctflearn.com/) - แพลตฟอร์มการเรียนรู้แบบ CTF รูปแบบใหม่ที่มีโจทย์ท้าทายจากผู้ใช้
- [Reversing.kr](http://reversing.kr/) - เว็บไซต์นี้ทดสอบความสามารถของคุณด้านการแครกและวิศวกรรมย้อนกลับโค้ด
- [w3challs](https://w3challs.com/) - โจทย์ของเราครอบคลุมหลายแขนงของการแฮ็ก ส่วนใหญ่เน้นเชิงรุก มีเทคโนโลยีและสถาปัตยกรรมหลากหลายรอให้คุณพิสูจน์ฝีมือ!
- [RingZer0 Team](https://ringzer0team.com/) - CTF ออนไลน์ของ RingZer0 Team มีโจทย์มากมายออกแบบมาเพื่อทดสอบและพัฒนาทักษะแฮ็กของคุณผ่านโจทย์ท้าทายการแฮ็ก
- [HellBound Hackers](http://www.hellboundhackers.org/) - แนวทางการเรียนรู้เชิงปฏิบัติสำหรับความปลอดภัยคอมพิวเตอร์และโจทย์ท้าทายความปลอดภัยเสมือนจริง
- [Komodo Consulting](http://ctf.komodosec.com) - Application Security Challenge ที่ออกแบบมาเพื่อทดสอบทักษะการแฮ็กแอปพลิเคชันของคุณ
- [Maxkersten Binary Analysis](https://maxkersten.nl/binary-analysis-course/) - คอร์สวิเคราะห์ไบนารีเชิงปฏิบัติ
- [PwnAdventure](https://pwnadventure.com) - Pwnie Island คือ MMORPG โลกเปิดที่จำกัดการเปิดตัว มุมมองบุคคลที่หนึ่ง ตั้งอยู่บนเกาะสวยงามที่อะไรก็เกิดขึ้นได้ เพราะเกมนี้ถูกออกแบบมาให้มีช่องโหว่สำหรับการแฮ็กแบบขำ ๆ เช่น บินได้ เงินไม่จำกัด และอื่น ๆ แค่เปลี่ยนไคลเอนต์หรือพร็อกซีเครือข่าย
- [INE](https://ine.com/) - การฝึกอบรมและการรับรองด้าน IT ออนไลน์แบบลงมือปฏิบัติจริง
## ห้องทดลอง

- [CTFd](https://github.com/isislab/CTFd) - CTFs ตามที่คุณต้องการ
- [Mellivora](https://github.com/Nakiami/mellivora) - Mellivora เป็นเอนจิน CTF ที่เขียนด้วยภาษา PHP
- [Metasploitable2 ](https://sourceforge.net/projects/metasploitable/files/Metasploitable2/) - Metasploitable เป็นเครื่องเสมือน Linux ที่ตั้งใจให้มีช่องโหว่
- [NightShade](https://github.com/UnrealAkama/NightShade) - เฟรมเวิร์ก capture the flag ที่เรียบง่าย
- [MCIR](https://github.com/SpiderLabs/MCIR) - The Magical Code Injection Rainbow! MCIR เป็นเฟรมเวิร์กสำหรับสร้าง testbed ช่องโหว่ที่ปรับแต่งได้ MCIR ยังเป็นชุดของ testbed ช่องโหว่ที่ปรับแต่งได้ด้วย
- [Vagrant](https://www.vagrantup.com/) - สร้างสภาพแวดล้อมสำหรับการพัฒนาได้อย่างง่ายดาย
- [NETinVM](https://informatica.uv.es/~carlos/docencia/netinvm/) - เครื่องมือสำหรับการสอนและเรียนรู้เกี่ยวกับระบบ เครือข่าย และความปลอดภัย
- [SmartOS](https://smartos.org/) - SmartOS เป็นไฮเปอร์ไวเซอร์ SVR4 แบบโอเพ่นซอร์สฟรี ที่พัฒนาบนระบบปฏิบัติการ UNIX โดยผสานเทคโนโลยี OpenSolaris เข้ากับ KVM virtualization ของ Linux
- [SmartDataCenter](https://github.com/joyent/sdc) - Joyent Triton DataCenter: แพลตฟอร์มบริหารจัดการคลาวด์ที่รองรับคอนเทนเนอร์อย่างเต็มรูปแบบ
- [vSphere Hypervisor](https://www.vmware.com/products/vsphere-hypervisor/) - vSphere Hypervisor เป็นไฮเปอร์ไวเซอร์แบบ bare-metal ที่ใช้สำหรับจำลองเซิร์ฟเวอร์ ช่วยให้คุณรวมแอปพลิเคชันในเครื่องเดียว และประหยัดเวลาและค่าใช้จ่ายในการบริหารจัดการโครงสร้างพื้นฐาน IT ของคุณ
- [GNS3](http://sourceforge.net/projects/gns-3/) - สร้าง ออกแบบ และทดสอบเครือข่ายของคุณในสภาพแวดล้อมเสมือนที่ปลอดภัย พร้อมเข้าถึงชุมชนเครือข่ายที่ใหญ่ที่สุดเพื่อขอความช่วยเหลือ
- [OCCP](https://opencyberchallenge.net/) - แพลตฟอร์ม virtualization แบบโอเพ่นซอร์สที่สามารถปรับแต่งได้ฟรี สำหรับผู้สอนความปลอดภัยไซเบอร์และผู้ประสานงานกิจกรรมการแข่งขัน
- [XAMPP](https://www.apachefriends.org/index.html) - XAMPP คือชุด Apache ที่ติดตั้งง่ายและฟรี ประกอบด้วย MariaDB, PHP และ Perl แพ็กเกจโอเพ่นซอร์ส XAMPP ถูกออกแบบให้ติดตั้งและใช้งานได้ง่ายมาก
- [Kubernetes Goat](https://github.com/madhuakula/kubernetes-goat) - Kubernetes Goat ถูกออกแบบมาให้เป็นคลัสเตอร์ที่มีช่องโหว่โดยตั้งใจ เพื่อใช้เรียนรู้และฝึกฝนการรักษาความปลอดภัย Kubernetes
- [Offensive Security](https://www.offensive-security.com/labs/individual/) - ฝึกทักษะ pentesting ของคุณในห้องแล็บแบบแยกส่วนและส่วนตัว พร้อมด้วย PG Play และ PG Practice ในห้องแล็บฝึกอบรม Proving Grounds ของ Offensive Security
- [Game of Hacks](http://www.gameofhacks.com/) - อันนี้ไม่ใช่เว็บแอปที่มีช่องโหว่โดยตรง แต่เป็นอีกหนึ่งวิธีที่น่าสนใจในการฝึกฝนการหาช่องโหว่ด้านความปลอดภัยของแอปพลิเคชัน เราจึงขอแนะนำไว้ด้วย
- [Google Gruyere](https://google-gruyere.appspot.com/) - เว็บที่มีช่องโหว่ "แบบเนยแข็ง" นี้ เต็มไปด้วยช่องโหว่และเหมาะสำหรับผู้ที่เริ่มต้นเรียนรู้ความปลอดภัยของแอปพลิเคชัน
- [Hellbound Hackers](https://www.hellboundhackers.org/) - Hellbound Hackers คือแนวทางปฏิบัติจริงเกี่ยวกับความปลอดภัยคอมพิวเตอร์ ที่มีความท้าทายหลากหลายเพื่อสอนการระบุและแก้ไขช่องโหว่
- [Peruggia](https://sourceforge.net/projects/peruggia/) - Peruggia คือสภาพแวดล้อมที่ปลอดภัยสำหรับผู้เชี่ยวชาญและนักพัฒนาเพื่อเรียนรู้และทดสอบการโจมตีที่พบบ่อยในเว็บแอปพลิเคชัน
- [oliverwiegers/pentest_lab](https://github.com/oliverwiegers/pentest_lab) - ห้องแล็บ pentest แบบ local ที่ใช้ Docker Compose
- [Hacksplaining](https://www.hacksplaining.com/) - บทเรียนเชิงโต้ตอบสำหรับช่องโหว่เว็บที่รู้จักกันดีหลายประเภท
- [LabEx](https://labex.io/skilltrees/cybersecurity) - แพลตฟอร์มออนไลน์เพื่อเสริมทักษะ Linux, DevOps และ Cybersecurity ของคุณผ่านห้องแล็บแบบลงมือปฏิบัติ
## แอปมือถือ
- [Allsafe](https://github.com/t0thkr1s/allsafe) - Allsafe เป็นแอปพลิเคชันที่เจตนาให้มีช่องโหว่ต่างๆ มากมาย
- [Damn Vulnerable Android App (DVAA)](https://code.google.com/p/dvaa/) - Damn Vulnerable Android App (DVAA) เป็นแอปพลิเคชัน Android ที่มีช่องโหว่โดยเจตนา
- [Damn Vulnerable FirefoxOS Application (DVFA)](https://github.com/arroway/dvfa) - Damn Vulnerable FirefoxOS Application - แอปที่มีช่องโหว่สำหรับการสาธิตโดยเฉพาะ
- [Damn Vulnerable iOS App (DVIA)](damnvulnerableiosapp.com/) - Damn Vulnerable iOS App (DVIA) เป็นแอป iOS ที่มีช่องโหว่จำนวนมาก
- [ExploitMe Mobile Android Labs](https://securitycompass.github.io/AndroidLabs/) - แอป Android ที่ไม่ปลอดภัยสำหรับการทดลองเจาะระบบ
- [ExploitMe Mobile iPhone Labs](https://securitycompass.github.io/iPhoneLabs/) - แอป iPhone ที่มีข้อบกพร่องสำหรับการทดลองเจาะระบบ
- [Hacme Bank Android](https://www.mcafee.com/us/downloads/free-tools/hacme-bank-android.aspx) - เครื่องมือฟรีจาก McAfee เพื่อช่วยป้องกันความปลอดภัยของคุณ
- [InsecureBank](https://www.paladion.net/downloadapp.html) - Cyber Tales โดย Paladion
- [NcN Wargame](https://github.com/NocONName/Wargame_NcN2012) - No cON Name 2012 Challenges
- [OWASP iGoat](https://code.google.com/p/owasp-igoat/) - โครงการ OWASP iGoat เป็นเครื่องมือการเรียนรู้ด้านความปลอดภัยสำหรับนักพัฒนา iOS เพื่อเรียนรู้จุดอ่อนด้านความปลอดภัยใน iOS -- โดยการทดลองเจาะและแก้ไขจุดอ่อนเหล่านั้น
- [OWASP Goatdroid](https://github.com/jackMannino/OWASP-GoatDroid-Project) - OWASP GoatDroid เป็นสภาพแวดล้อมฝึกอบรมที่สมบูรณ์แบบและทำงานได้ด้วยตัวเอง สำหรับการศึกษานักพัฒนาและผู้ทดสอบเกี่ยวกับความปลอดภัยบน Android
- [OWASP MSTG Hacking Playground](https://github.com/OWASP/MSTG-Hacking-Playground) - ชุดแอปมือถือที่มีช่องโหว่สำหรับให้คุณทดลองเจาะช่องโหว่โดยใช้เทคนิคของ OWASP MSTG
- [OWASP MSTG Crackmes](https://github.com/OWASP/owasp-mstg/tree/master/Crackmes) - ชุดแอปมือถือที่ช่วยพัฒนาทักษะด้าน reverse engineering ตามแนวทาง [OWASP MSTG](https://github.com/OWASP/owasp-mstg)

## API
- [OWASP crAPI](https://github.com/OWASP/crAPI) - crAPI ย่อมาจาก “Completely Ridiculous API” เป็นการจำลองเว็บแอปพลิเคชันที่ขับเคลื่อนด้วย API และ microservice สำหรับเจ้าของรถ crAPI เน้นช่องโหว่ทั่วไปที่เกิดขึ้นในแอปพลิเคชัน API สมัยใหม่ รวมถึงช่องโหว่ใน OWASP Top 10 สำหรับ API ทั้งหมด
- [VAmPI](https://github.com/erev0s/VAmPI) - VAmPI เป็น API ที่มีช่องโหว่ สร้างด้วย Flask และรวมช่องโหว่จาก OWASP Top 10 สำหรับ API
- [capital](https://github.com/Checkmarx/capital) - แอปพลิเคชัน API ที่สร้างมาให้มีช่องโหว่โดยเฉพาะ อ้างอิงตาม OWASP Top 10 API ใช้ c{api}tal เพื่อเรียนรู้ ฝึกฝน และทดลองเจาะช่องโหว่ด้านความปลอดภัยของ API ใน CTF ส่วนตัวของคุณ
- [dvws-node](https://github.com/snoopysecurity/dvws-node) - Damn Vulnerable Web Services เป็นแอปพลิเคชันที่มีช่องโหว่ พร้อมบริการเว็บและ API สำหรับศึกษาช่องโหว่ที่เกี่ยวข้องกับ webservices/API
- [VulnerableLightApp](https://github.com/Aif4thah/VulnerableLightApp) - API ที่มีช่องโหว่สำหรับวัตถุประสงค์ทางการศึกษา

ยินดีรับทุกการมีส่วนร่วม

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---