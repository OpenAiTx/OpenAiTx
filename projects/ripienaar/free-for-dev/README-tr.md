# free-for.dev

Geliştiriciler ve Açık Kaynak yazarları artık ücretsiz katmanlar sunan birçok hizmete sahip, ancak bunların hepsini bulmak zaman alıyor ve bilinçli kararlar vermek için çaba gerekiyor.

Bu, ücretsiz geliştirici katmanlarına sahip yazılımların (SaaS, PaaS, IaaS, vb.) ve diğer tekliflerin bir listesidir.

Bu listenin kapsamı, altyapı geliştiricilerinin (Sistem Yöneticisi, DevOps Uygulayıcıları, vb.) faydalı bulabileceği şeylerle sınırlıdır. Tüm ücretsiz hizmetleri seviyoruz, ancak konudan sapmamak iyi olur. Bazen gri bir çizgi olsa da, bu liste subjektiftir; katkınızı kabul etmezsem lütfen alınmayın.

Bu liste, 1600'den fazla kişinin Pull Request'leri, incelemeleri, fikirleri ve çalışmaları sonucu oluşmuştur. Siz de daha fazla hizmet eklemek veya teklifleri değişmiş ya da kaldırılmış olanları çıkarmak için [Pull Request](https://github.com/ripienaar/free-for-dev) göndererek yardımcı olabilirsiniz.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**NOT**: Bu liste yalnızca Hizmet Olarak Sunulan (as-a-Service) teklifleri içindir, kendi kendine barındırılan yazılımlar için değildir. Uygun olabilmesi için bir hizmetin ücretsiz bir katman sunması gerekir, sadece ücretsiz deneme değil. Ücretsiz katman, zaman sınırlıysa en az bir yıl olmalıdır. Ücretsiz katmanı güvenlik açısından da değerlendiriyoruz, bu yüzden SSO kabul edilebilir, ancak yalnızca ücretli katmanlarda TLS sunan hizmetleri kabul etmeyeceğim.

# İçindekiler

  * [Büyük Bulut Sağlayıcılarının Her Zaman Ücretsiz Limitleri](#major-cloud-providers)
  * [Bulut Yönetim Çözümleri](#cloud-management-solutions)
  * [Analitik, Olaylar ve İstatistikler](#analytics-events-and-statistics)
  * [API'ler, Veri ve ML](#apis-data-and-ml)
  * [Artifact Depoları](#artifact-repos)
  * [BaaS](#baas)
  * [Düşük Kodlu Platform](#low-code-platform)
  * [CDN ve Koruma](#cdn-and-protection)
  * [CI ve CD](#ci-and-cd)
  * [CMS](#cms)
  * [Kod Üretimi](#code-generation)
  * [Kod Kalitesi](#code-quality)
  * [Kod Arama ve Göz Atma](#code-search-and-browsing)
  * [Çökme ve İstisna Yönetimi](#crash-and-exception-handling)
  * [Haritalarda Veri Görselleştirme](#data-visualization-on-maps)
  * [Yönetilen Veri Hizmetleri](#managed-data-services)
  * [Tasarım ve UI](#design-and-ui)
  * [Tasarım İlhamı](#design-inspiration)
  * [Geliştirici Blog Siteleri](#dev-blogging-sites)
  * [DNS](#dns)
  * [Docker İlgili](#docker-related)
  * [Alan Adı](#domain)
  * [Eğitim ve Kariyer Gelişimi](#education-and-career-development)
  * [E-posta](#email)
  * [Özellik Anahtarı Yönetim Platformları](#feature-toggles-management-platforms)
  * [Yazı Tipi](#font)
  * [Formlar](#forms)
  * [Üretken Yapay Zeka](#generative-ai)
  * [IaaS](#iaas)
  * [IDE ve Kod Düzenleme](#ide-and-code-editing)
  * [Uluslararası Mobil Numara Doğrulama API ve SDK](#international-mobile-number-verification-api-and-sdk)
  * [Sorun Takibi ve Proje Yönetimi](#issue-tracking-and-project-management)
  * [Log Yönetimi](#log-management)
  * [Mobil Uygulama Dağıtımı ve Geri Bildirimi](#mobile-app-distribution-and-feedback)
  * [Yönetim Sistemleri](#management-system)
  * [Mesajlaşma ve Akış](#messaging-and-streaming)
  * [Çeşitli](#miscellaneous)
  * [İzleme](#monitoring)
  * [PaaS](#paas)
  * [Paket Derleme Sistemi](#package-build-system)
  * [Ödeme ve Faturalama Entegrasyonu](#payment-and-billing-integration)
  * [Gizlilik Yönetimi](#privacy-management)
  * [Ekran Görüntüsü API'leri](#screenshot-apis)
  * [Flutter İlgili ve Mac Olmadan IOS Uygulaması Geliştirme](#flutter-related-and-building-ios-apps-without-mac)
  * [Arama](#search)
  * [Güvenlik ve PKI](#security-and-pki)
  * [Kimlik Doğrulama, Yetkilendirme ve Kullanıcı Yönetimi](#authentication-authorization-and-user-management)
  * [Kaynak Kod Depoları](#source-code-repos)
  * [Depolama ve Medya İşleme](#storage-and-media-processing)
  * [Tünelleme, WebRTC, Web Socket Sunucuları ve Diğer Yönlendiriciler](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [Test](#testing)
  * [Ekipler ve İşbirliği için Araçlar](#tools-for-teams-and-collaboration)
  * [Çeviri Yönetimi](#translation-management)
  * [Vagrant İlgili](#vagrant-related)
  * [Ziyaretçi Oturum Kaydı](#visitor-session-recording)
  * [Web Hosting](#web-hosting)
  * [Yorum Platformları](#commenting-platforms)
  * [Tarayıcı Tabanlı Donanım Emülasyonu](#browser-based-hardware-emulation-written-in-javascript)
  * [Uzak Masaüstü Araçları](#remote-desktop-tools)
  * [Oyun Geliştirme](#game-development)
  * [Diğer Ücretsiz Kaynaklar](#other-free-resources)

## Büyük Bulut Sağlayıcılar

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - Günde 28 frontend örneği saati, günde 9 backend örneği saati
    * Cloud Firestore - 1GB depolama, günde 50.000 okuma, 20.000 yazma, 20.000 silme
    * Compute Engine - 1 önceliksiz e2-micro, 30GB HDD, 5GB anlık görüntü depolama (belirli bölgelerle sınırlı), Kuzey Amerika'dan tüm bölge hedeflerine (Çin ve Avustralya hariç) aylık 1 GB ağ çıkışı
    * Cloud Storage - 5GB, 1GB ağ çıkışı
    * Cloud Shell - Web tabanlı Linux kabuğu/ana IDE, 5GB kalıcı depolama. Haftalık 60 saat sınırı
    * Cloud Pub/Sub - Aylık 10GB mesaj
    * Cloud Functions - Aylık 2 milyon tetikleme (hem arka plan hem HTTP tetiklemeleri dahil)
    * Cloud Run - Aylık 2 milyon istek, 360.000 GB-saniye bellek, 180.000 vCPU-saniye işlem süresi, Kuzey Amerika'dan aylık 1 GB ağ çıkışı
    * Google Kubernetes Engine - Bir zonal küme için yönetim ücreti yok. Her kullanıcı düğümü standart Compute Engine fiyatlandırmasıyla ücretlendirilir
    * BigQuery - Aylık 1 TB sorgu, her ay 10 GB depolama
    * Cloud Build - Günde 120 derleme-dakikası
    * Cloud Source Repositories - En fazla 5 kullanıcı, 50 GB depolama, 50 GB çıkış
    * [Google Colab](https://colab.research.google.com/) - Ücretsiz Jupyter Notebooks geliştirme ortamı.
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (eski adıyla Project IDX). Google Cloud üzerinde çalışan çevrimiçi VSCode.
    * Tam, ayrıntılı liste - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - Aylık 1TB çıkış ve 2M Fonksiyon tetikleme
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 özel metrik ve on alarm
* [CodeBuild](https://aws.amazon.com/codebuild/) - Ayda 100 dakika derleme süresi
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 aktif kullanıcı, 50GB depolama ve ayda 10.000 istek
* [CodePipeline](https://aws.amazon.com/codepipeline/) - Ayda 1 aktif pipeline
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GB NoSQL veritabanı
* [EC2](https://aws.amazon.com/ec2/) - t2.micro veya t3.micro için ayda 750 saat (12 ay). Ayda 100GB çıkış
* [EBS](https://aws.amazon.com/ebs/) - Ayda 30GB Genel Amaçlı (SSD) veya Manyetik (12 ay)
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - Ayda 750 saat (12 ay)
* [RDS](https://aws.amazon.com/rds/) - db.t2.micro, db.t3.micro veya db.t4g.micro için ayda 750 saat, 20GB Genel Amaçlı (SSD) depolama, 20GB yedekleme (12 ay)
* [S3](https://aws.amazon.com/s3/) - 5GB Standart nesne depolama, 20K Get isteği ve 2K Put isteği (12 ay)
* [Glacier](https://aws.amazon.com/glacier/) - 10GB uzun süreli nesne depolama
* [Lambda](https://aws.amazon.com/lambda/) - Ayda 1 milyon istek
* [SNS](https://aws.amazon.com/sns/) - Ayda 1 milyon yayınlama
* [SES](https://aws.amazon.com/ses/) - Ayda 3.000 mesaj (12 ay)
* [SQS](https://aws.amazon.com/sqs/) - Ayda 1 milyon mesaj kuyruğu isteği
* Tam ve detaylı liste - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 B1S Linux VM, 1 B1S Windows VM (12 ay)
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 web, mobil veya API uygulaması (günlük 60 CPU dakikası)
  * [Functions](https://azure.microsoft.com/services/functions/) - Ayda 1 milyon istek
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - Hızlı, kolay ve yalın geliştirme-test ortamları sağlar
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500.000 nesne
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - Ayda 50.000 saklanan kullanıcı
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 aktif kullanıcı, sınırsız özel Git deposu
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — Linux, macOS ve Windows için açık kaynak projelerinde sınırsız dakika ile 10 ücretsiz paralel iş
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - Günlük 8.000 mesaj
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 ücretsiz genel yük dengeleyici IP (VIP)
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 1 milyon anlık bildirim
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15GB Gelen (12 ay) & Ayda 5GB çıkış
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GB depolama ve 1000 RU sağlanmış bant genişliği
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — Ücretsiz SSL, Kimlik Doğrulama/Yetkilendirme ve özel alan adları ile statik uygulamalar ve sunucusuz fonksiyonlar oluşturun, dağıtın ve barındırın
  * [Storage](https://azure.microsoft.com/services/storage/) - 5GB LRS Dosya veya Blob depolama (12 ay)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - Sınırlı işlem sayısına sahip ücretsiz katman ile AI/ML API'leri (Bilgisayarla Görü, Çevirmen, Yüz tespiti, Botlar, vb)
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - AI tabanlı arama ve indeksleme servisi, 10.000 döküman için ücretsiz
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - Yönetilen Kubernetes servisi, ücretsiz küme yönetimi
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - Ayda 100K işlem
  * Tam ve detaylı liste - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * Compute
     - Her biri 1/8 OCPU ve 1 GB belleğe sahip 2 AMD tabanlı Compute VM
     - 4 Arm tabanlı Ampere A1 çekirdeği ve 24 GB bellek; tek bir VM veya 4 adede kadar VM olarak kullanılabilir
     - [Boşta kabul edildiğinde](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances) örnekler geri alınacaktır
  * Block Volume - 2 adet, toplam 200 GB (compute için kullanılır)
  * Object Storage - 10 GB
  * Load balancer - 10 Mbps ile 1 örnek
  * Veritabanları - 2 adet veritabanı, her biri 20 GB
  * İzleme - 500 milyon veri noktası alımı, 1 milyar veri noktası sorgulama
  * Bant genişliği - Ayda 10 TB çıkış, x64 tabanlı VM'de hız 50 Mbps ile sınırlı, ARM tabanlı VM'de çekirdek başına 500 Mbps
  * Genel IP - VM'ler için 2 IPv4, yük dengeleyici için 1 IPv4
  * Bildirimler - Ayda 1 milyon teslimat seçeneği, ayda 1000 e-posta gönderimi
  * Tam ve detaylı liste - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Cloudant veritabanı - 1 GB veri depolama
  * Db2 veritabanı - 100MB veri depolama
  * API Connect - Ayda 50.000 API çağrısı
  * Kullanılabilirlik İzleme - Ayda 3 milyon veri noktası
  * Log Analizi - Günlük 500MB log
  * Tam ve detaylı liste - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - Sınırsız alan adı için ücretsiz DNS, DDoS Koruması, CDN ile birlikte ücretsiz SSL, Güvenlik Duvarı kuralları ve sayfa kuralları, WAF, Bot Azaltma, Ücretsiz Ölçümsüz Hız Sınırlandırma - alan adı başına 1 kural, Analitik, E-posta yönlendirme
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - 50 kullanıcıya kadar, 24 saatlik etkinlik kaydı, üç ağ lokasyonu
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - Yerelde çalışan bir HTTP portunu tünel üzerinden trycloudflare.com'da rastgele bir alt alana açabilirsiniz. [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/) kullanın, hesap gerekmez. Daha fazla özellik (TCP tüneli, Yük dengeleme, VPN) [Zero Trust](https://www.cloudflare.com/products/zero-trust/) Ücretsiz Plan'da.
  * [Workers](https://developers.cloudflare.com/workers/) - Cloudflare'ın küresel ağında sunucusuz kodu ücretsiz olarak dağıtın—günlük 100k istek.
  * [Workers KV](https://developers.cloudflare.com/kv) - Günlük 100k okuma isteği, günlük 1000 yazma isteği, günlük 1000 silme isteği, günlük 1000 liste isteği, 1 GB depolama
  * [R2](https://developers.cloudflare.com/r2/) - Ayda 10 GB, ayda 1 milyon Sınıf A işlem, ayda 10 milyon Sınıf B işlem
  * [D1](https://developers.cloudflare.com/d1/) - Günlük 5 milyon satır okuma, günlük 100k satır yazma, 1 GB depolama
  * [Pages](https://developers.cloudflare.com/pages/) - Cloudflare'ın hızlı, güvenli küresel ağında web uygulamalarınızı geliştirin ve dağıtın. Aylık beş yüz derleme, 100 özel alan adı, Entegre SSL, sınırsız erişilebilir koltuk, sınırsız önizleme dağıtımı ve Cloudflare Workers entegrasyonu ile tam yığın yeteneği.
  * [Queues](https://developers.cloudflare.com/queues/) - Ayda 1 milyon işlem
  * [TURN](https://developers.cloudflare.com/calls/turn/) – Ayda 1TB ücretsiz (giden) trafik.

**[⬆️ Başa Dön](#table-of-contents)**

## Bulut yönetim çözümleri

* [Brainboard](https://www.brainboard.co) - Bulut altyapılarını uçtan uca görsel olarak oluşturmak ve yönetmek için işbirlikçi çözüm.
* [Cloud 66](https://www.cloud66.com/) - Kişisel projeler için ücretsizdir (bir dağıtım sunucusu, bir statik site dahil), Cloud 66 uygulamalarınızı herhangi bir bulutta oluşturmak, dağıtmak ve büyütmek için ihtiyacınız olan her şeyi sunar, “sunucu işleri” ile uğraşmadan.
* [Pulumi](https://www.pulumi.com/) — Tanıdık programlama dilleri ve araçlarını kullanarak bulut altyapısı oluşturmanıza, dağıtmanıza ve yönetmenize olanak tanıyan modern bir altyapı kod platformu.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. 500 kaynağa kadar ücretsiz uzaktan durum yönetimi ve ekip işbirliği.
* [scalr.com](https://scalr.com/) - Scalr, Terraform ile yönetilen altyapı ve yapılandırmalarda daha iyi işbirliği ve otomasyon için kullanılan bir Terraform Otomasyon ve İşbirliği (TACO) ürünüdür. Tam Terraform CLI desteği, OPA entegrasyonu ve hiyerarşik yapılandırma modeli. SSO ücreti yok. Tüm özellikler dahildir. Ayda 50 çalıştırmaya kadar ücretsiz kullanın.
* [deployment.io](https://deployment.io) - Deployment.io geliştiricilerin AWS üzerinde dağıtımları otomatikleştirmesine yardımcı olur. Ücretsiz katmanımızda, bir geliştirici (tek kullanıcı) sınırsız statik site, web servisi ve ortam dağıtabilir. Önizlemeler ve otomatik dağıtımlar dahil olmak üzere ayda 20 iş yürütmesi ücretsizdir.

**[⬆️ Başa Dön](#table-of-contents)**

## Kaynak Kod Depoları

* [Bitbucket](https://bitbucket.org/) — CI/CD için Pipelines ile 5 kullanıcıya kadar sınırsız herkese açık ve özel Git deposu
* [chiselapp.com](https://chiselapp.com/) — Sınırsız herkese açık ve özel Fossil depoları
* [codebasehq.com](https://www.codebasehq.com/) — 100 MB alan ve iki kullanıcı ile bir ücretsiz proje
* [Codeberg](https://codeberg.org/) — Ücretsiz ve açık kaynak projeleri için sınırsız herkese açık ve özel Git depoları (sınırsız işbirlikçi ile). [Forgejo](https://forgejo.org/) tarafından desteklenmektedir. [Codeberg Pages](https://codeberg.page/) ile statik web sitesi barındırma. [Codeberg's CI](https://docs.codeberg.org/ci/) ile CI/CD barındırma. [Codeberg Translate](https://translate.codeberg.org/) ile çeviri barındırma. Paket ve Konteyner barındırma, Proje yönetimi ve Sorun Takibi dahildir.
* [GitGud](https://gitgud.io) — Sınırsız özel ve herkese açık depo. Sonsuza kadar ücretsiz. GitLab & Sapphire tarafından desteklenmektedir. CI/CD sunulmaz.
* [GitHub](https://github.com/) — Sınırsız herkese açık ve sınırsız özel depo (sınırsız işbirlikçi ile). CI/CD, Geliştirme Ortamı, Statik Barındırma, Paket ve Konteyner barındırma, Proje yönetimi ve AI Copilot dahildir.
* [gitlab.com](https://about.gitlab.com/) — 5 işbirlikçiye kadar sınırsız herkese açık ve özel Git depoları. CI/CD, Statik Barındırma, Konteyner Kaydı, Proje Yönetimi ve Sorun Takibi dahildir.
* [framagit.org](https://framagit.org/) — Framagit, Framasoft'un Gitlab yazılımı tabanlı yazılım dökümhanesidir; CI, Statik Sayfalar, Proje sayfaları ve Sorun takibi içerir.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod, Mercurial desteği sunan GitLab Community Edition'ın dostça bir çatalıdır
* [ionicframework.com](https://ionicframework.com/appflow) - Ionic ile uygulama geliştirmek için depo ve araçlar; ayrıca bir ionic deponuz olur
* [NotABug](https://notabug.org) — NotABug.org, özgürce lisanslanmış projeler için özgür yazılım kod işbirliği platformudur, Git tabanlıdır
* [OSDN](https://osdn.net/) - OSDN.net, açık kaynak yazılım geliştiricileri için ücretsiz bir servistir, SVN/Git/Mercurial/Bazaar/CVS depoları sunar.
  * [Pagure.io](https://pagure.io) — Pagure.io, FOSS lisanslı projeler için ücretsiz ve açık kaynaklı bir yazılım kod işbirliği platformudur, Git tabanlıdır.
  * [perforce.com](https://www.perforce.com/products/helix-teamhub) — Ücretsiz 1GB Bulut ve Git, Mercurial veya SVN depoları.
  * [pijul.com](https://pijul.com/) - Sınırsız ücretsiz ve açık kaynaklı dağıtık sürüm kontrol sistemi. Ayırt edici özelliği, yamaların sağlam bir teorisine dayanmasıdır, bu da öğrenmeyi, kullanmayı ve dağıtmayı kolaylaştırır. git/hg/svn/darcs'ın birçok sorununu çözer.
  * [plasticscm.com](https://plasticscm.com/) — Bireyler, OSS ve kar amacı gütmeyen kuruluşlar için ücretsiz
  * [projectlocker.com](https://projectlocker.com) — 50 MB alan ile bir ücretsiz özel proje (Git ve Subversion)
  * [RocketGit](https://rocketgit.com) — Git tabanlı Depo Barındırma. Sınırsız herkese açık ve özel depo.
  * [savannah.gnu.org](https://savannah.gnu.org/) - Ücretsiz Yazılım projeleri (GNU Projeleri için) için işbirlikçi yazılım geliştirme yönetim sistemi olarak hizmet verir.
  * [savannah.nongnu.org](https://savannah.nongnu.org/) - Ücretsiz Yazılım projeleri (GNU dışı projeler için) için işbirlikçi yazılım geliştirme yönetim sistemi olarak hizmet verir.

**[⬆️ Başa Dön](#table-of-contents)**

## API'ler, Veri ve ML

  * [JSONGrid](https://jsongrid.com) - Karmaşık JSON verilerini güzel sekmeli Grid'e Görselleştir, Düzenle, Filtrele. JSON verilerini bağlantı üzerinden kaydet ve paylaş.
  * [Zerosheets](https://zerosheets.com) - Google Sheets tablolarınızı güçlü API'lere dönüştürerek hızlıca prototipler, web siteleri, uygulamalar ve daha fazlasını geliştirin. Ayda 500 istek ücretsiz olarak sunulur.
  * [IP.City](https://ip.city) — Günlük 100 ücretsiz IP coğrafi konum sorgusu
  * [Abstract API](https://www.abstractapi.com) — IP coğrafi konumu, cinsiyet tespiti veya e-posta doğrulama gibi çeşitli kullanım durumları için API paketi.
  * [Apify](https://www.apify.com/) — Herhangi bir web sitesi için API oluşturmak ve veri çıkarmak için web kazıma ve otomasyon platformu. Hazır kazıyıcılar, entegre proxy'ler ve özel çözümler. Her ay 5$ platform kredisi içeren ücretsiz plan.
  * [APITemplate.io](https://apitemplate.io) - Basit bir API veya Zapier & Airtable gibi otomasyon araçlarıyla otomatik olarak görsel ve PDF dökümanlar oluşturun. CSS/HTML gerekmez. Ücretsiz plan, ayda 50 görsel ve üç şablon içerir.
  * [APIToolkit.io](https://apitoolkit.io) - API'lerinizde ve Backend'lerinizde neler olduğunu tamamen anlamanız için gereken tüm araçlar. Otomatik API sözleşme doğrulama ve izleme ile. Ücretsiz plan, günde 10.000 isteğe kadar sunucuları kapsar.
  * [APIVerve](https://apiverve.com) - 120'den fazla API'ye ücretsiz anında erişin; kalite, tutarlılık ve güvenilirlik ön planda. Ücretsiz plan ayda 50 API Token'ı kapsar. (Muhtemelen kaldırıldı, 2025-06-25)
  * [Arize AI](https://arize.com/) - Makine öğrenimi gözlemlenebilirliği için model izleme ve veri kalitesi ile performans sapması gibi sorunların kök neden analizi. İki modele kadar ücretsiz.
  * [Maxim AI](https://getmaxim.ai/) - AI ajanlarını simüle edin, değerlendirin ve izleyin. Maxim, ekiplerin AI ajanlarını güvenle ve 5 kat daha hızlı göndermelerine yardımcı olan uçtan uca değerlendirme ve gözlemlenebilirlik platformudur. Bireysel geliştiriciler ve küçük ekipler (3 koltuk) için sonsuza kadar ücretsiz.
  * [Beeceptor](https://beeceptor.com) - Saniyeler içinde bir REST API taklit edin, sahte API yanıtı oluşturun ve daha fazlası. Günde 50 ücretsiz istek, herkese açık pano, açık uç noktalar (pano bağlantısı olan herkes gönderileri ve yanıtları görebilir).
  * [BigDataCloud](https://www.bigdatacloud.com/) - Modern web için IP Coğrafi Konum, Tersine Coğrafi Kodlama, Ağ İçgörüleri, E-posta ve Telefon Doğrulama, İstemci Bilgisi ve daha fazlası gibi hızlı, doğru ve ücretsiz (Sınırsız veya ayda 10K-50K'ya kadar) API'ler sağlar.
  * [Browse AI](https://www.browse.ai) — Web üzerindeki verileri çıkarma ve izleme. Ayda 1.000 kredi ücretsiz, bu da 1.000 eşzamanlı isteğe eşittir.
  * [BrowserCat](https://www.browsercat.com) - Otomasyon, kazıma, AI ajan web erişimi, görsel/pdf oluşturma ve daha fazlası için headless browser API'si. Aylık 1.000 istek ile ücretsiz plan.
  * [Calendarific](https://calendarific.com) - 200'den fazla ülke için kurumsal düzeyde Resmi Tatil API hizmeti. Ücretsiz plan ayda 500 çağrı içerir.
  * [Canopy](https://www.canopyapi.co/) - Amazon.com ürün, arama ve kategori verileri için GraphQL API. Ücretsiz plan, ayda 100 çağrı içerir.
  * [Clarifai](https://www.clarifai.com) — Özel yüz tanıma ve algılama için Görsel API. AI modelleri eğitilebilir. Ücretsiz plan ayda 1.000 çağrı içerir.
  * [Cloudmersive](https://cloudmersive.com/) — Belge Dönüştürme, Virüs Taraması ve daha fazlası dahil geniş bir API Kütüphanesine tam erişim sunan yardımcı program API platformu. 600 çağrı/ay, yalnızca Kuzey Amerika AZ, 2.5MB maksimum dosya boyutu.
  * [Colaboratory](https://colab.research.google.com) — Nvidia Tesla K80 GPU ile ücretsiz web tabanlı Python notebook ortamı.
  * [CometML](https://www.comet.com/site/) - Deney takibi, model üretim yönetimi, model kayıt sistemi ve eksiksiz veri soy ağacı ile MLOps platformu; eğitimden üretime kadar tüm iş akışınızı kapsar. Bireyler ve akademisyenler için ücretsiz.
  * [Commerce Layer](https://commercelayer.io) - Herhangi bir ön uçtan sipariş oluşturabilen, verebilen ve yönetebilen bir yapılandırılabilir ticaret API'si. Geliştirici planı, ayda 100 sipariş ve 1.000 SKU'ya kadar ücretsizdir.
  * [Composio](https://composio.dev/) - AI Ajanları ve LLM'ler için entegrasyon platformu. Ajanik internet genelinde 200'den fazla aracı entegre edin.
  * [Conversion Tools](https://conversiontools.io/) - Belgeler, görseller, video, ses ve e-Kitaplar için Çevrimiçi Dosya Dönüştürücü. REST API mevcut. Node.js, PHP, Python için kütüphaneler. 50 GB'a kadar dosya desteği (ücretli planlarda). Ücretsiz katman dosya boyutu (20MB) ve dönüşüm sayısı (Günlük 30, Aylık 300) ile sınırlıdır.
  * [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - Ülkeler, bölgeler, iller, şehirler, posta kodları ve çok daha fazlası dahil olmak üzere geniş bilgi sunan API ve Mikroservis. Ücretsiz katman, günde 100 isteğe kadar içerir.
  * [Coupler](https://www.coupler.io/) - Uygulamalar arasında senkronize eden veri entegrasyon aracı. Canlı panolar ve raporlar oluşturabilir, değerleri dönüştürebilir ve analizleri yedekleyebilir. Ücretsiz plan bir kullanıcı, veri bağlantısı, veri kaynağı ve veri hedefi ile sınırlıdır. Ayrıca manuel veri yenilemesi gerektirir.
  * [CraftMyPDF](https://craftmypdf.com) - Sürükle-bırak editörü ve basit API ile yeniden kullanılabilir şablonlardan otomatik PDF belge oluşturun. Ücretsiz plan, ayda 100 PDF ve üç şablon içerir.
  * [Crawlbase](https://crawlbase.com/) — Proxy, altyapı veya tarayıcı olmadan web sitelerini kazıyın ve veri çıkarın. Captcha'ları sizin için çözüyoruz ve engellenmenizi önlüyoruz. İlk 1.000 çağrı ücretsizdir.
  * [CurlHub](https://curlhub.io) — API çağrılarını incelemek ve hata ayıklamak için proxy hizmeti. Ücretsiz plan ayda 10.000 istek içerir.
  * [CurrencyScoop](https://currencyscoop.com) - Fintech uygulamaları için gerçek zamanlı döviz verisi API'si. Ücretsiz plan ayda 5.000 çağrı içerir.
  * [Cube](https://cube.dev/) - Cube, veri mühendisleri ve uygulama geliştiricilerin modern veri depolarından veri erişmesini, tutarlı tanımlara organize etmesini ve her uygulamaya iletmesini sağlar. Cube Cloud ile en hızlı şekilde kullanılır, ücretsiz katman günlük 1.000 sorgu ile sınırlıdır.
  * [Data Dead Drop](https://datadeaddrop.com) - Basit, ücretsiz dosya paylaşımı. Veri erişimden sonra kendi kendini yok eder. Tarayıcı veya favori komut satırı istemcinizle veri yükleyin ve indirin.
  * [Data Fetcher](https://datafetcher.com) - Airtable'ı herhangi bir uygulamaya veya API'ye kodsuz bağlayın. Airtable'da API isteklerini çalıştırmak için Postman benzeri arayüz. Düzinelerce uygulama ile hazır entegrasyonlar. Ücretsiz plan ayda 100 çalıştırma içerir.
  * [Dataimporter.io](https://www.dataimporter.io) - Salesforce'a veri bağlamak, temizlemek ve aktarmak için araç. Ücretsiz Plan ayda 20.000 kayda kadar izin verir.
  * [Datalore](https://datalore.jetbrains.com) - Jetbrains tarafından Python notebook'ları. Her ay 10 GB depolama ve 120 saat çalışma süresi içerir.
  * [Data Miner](https://dataminer.io/) - Web sayfalarından CSV veya Excel veri çıkarmak için tarayıcı eklentisi (Google Chrome, MS Edge). Ücretsiz plan ayda 500 sayfa sunar.
  * [Datapane](https://datapane.com) - Python'da etkileşimli raporlar oluşturmak ve Python scriptleri ile Jupyter Notebook'ları self-servis araçlar olarak dağıtmak için API.
  * [DB-IP](https://db-ip.com/api/free) - Günlük IP başına 1.000 sorgu ile ücretsiz IP coğrafi konum API'si. CC-BY 4.0 Lisansı altında lite veritabanı da ücretsizdir.
  * [DB Designer](https://www.dbdesigner.net/) — Bulut tabanlı Veritabanı şeması tasarım ve modelleme aracı; ücretsiz başlangıç planı 2 veritabanı modeli ve model başına on tablo içerir.
  * [DeepAR](https://developer.deepar.ai) — Her platformda kullanılabilen artırılmış gerçeklik yüz filtreleri için tek SDK. Ücretsiz plan, ayda 10 aktif kullanıcı (MAU) ve 4 yüze kadar izleme sağlar.
  * [Deepnote](https://deepnote.com) - Yeni bir veri bilimi not defteri. Jupyter uyumlu, gerçek zamanlı işbirliği ve bulutta çalışır. Ücretsiz katman sınırsız kişisel proje, 5GB RAM ve 2vCPU'lu sınırsız temel makine ve 3 editöre kadar ekipler içerir.
  * [Disease.sh](https://disease.sh/) — Covid-19 ile ilgili faydalı Uygulamalar oluşturmak için doğru veri sağlayan ücretsiz API.
  * [Doczilla](https://www.doczilla.app/) — HTML/CSS/JS kodundan doğrudan ekran görüntüleri veya PDF'ler oluşturmayı sağlayan SaaS API. Ücretsiz plan ayda 250 döküman sağlar.
  * [Doppio](https://doppio.sh/) — Üst düzey render teknolojisiyle PDF ve Ekran Görüntüleri oluşturmak ve gizli olarak saklamak için yönetilen API. Ücretsiz plan, ayda 400 PDF ve Ekran Görüntüsü içerir.
  * [drawDB](https://drawdb.app/) — Ücretsiz ve açık kaynaklı, çevrimiçi veritabanı diyagram editörü, kayıt olmadan kullanılabilir.
  * [dreamfactory.com](https://dreamfactory.com/) — Mobil, web ve IoT uygulamaları için açık kaynak REST API arka ucu. Herhangi bir SQL/NoSQL veritabanı, dosya depolama sistemi veya harici hizmet bağlayın ve anında kapsamlı bir REST API platformu oluşturun; canlı dokümantasyon ve kullanıcı yönetimi ile.
  * [Duply.co](https://duply.co) — API & URL ile dinamik görseller oluşturun, bir kez şablon tasarlayın ve tekrar kullanın. Ücretsiz katman 20 ücretsiz kredi sunar.
  * [DynamicDocs](https://advicement.io) - LaTeX şablonlarına dayalı JSON'dan PDF API ile PDF dökümanları oluşturun. Ücretsiz plan, ayda 50 API çağrısı ve şablon kitaplığına erişim sunar.
  * [Efemarai](https://efemarai.com) - ML modelleri ve verileri için test ve hata ayıklama platformu. Her türlü hesaplama grafiğini görselleştirin. Yerel kullanımda ücretsiz.
  * [ERD Lab](https://www.erdlab.io) —  Geliştiriciler için yapılmış ücretsiz bulut tabanlı varlık ilişki diyagramı (ERD) aracı. Ücretsiz deneme, her biri 10 tabloya sahip 2 proje içerir.
  * [ExtendsClass](https://extendsclass.com/rest-client-online.html) - HTTP istekleri göndermek için ücretsiz web tabanlı HTTP istemcisi.
  * [Export SDK](https://exportsdk.com) - Sürükle-bırak şablon editörü ile PDF oluşturucu API, SDK ve kodsuz entegrasyonlar sağlar. Ücretsiz plan aylık 250 sayfa, sınırsız kullanıcı ve üç şablon içerir.
  * [file.coffee](https://file.coffee/) - Dosya başına 15MB'a (hesap ile 30MB) kadar depolama sunan bir platform.
  * [Financial Data](https://financialdata.net/) - Borsa ve finansal veri API'si. Ücretsiz plan günlük 300 sorgu sağlar.
  * [FormatJSONOnline.com](https://formatjsononline.com) - JSON verilerini anında biçimlendirmek, doğrulamak, karşılaştırmak ve küçültmek için ücretsiz tarayıcı tabanlı araç.
  * [FraudLabs Pro](https://www.fraudlabspro.com) — Kredi kartı ödeme dolandırıcılığını tespit etmek için bir sipariş işlemini tarayın. Bu REST API, bir siparişin giriş parametrelerine dayalı olarak tüm olası sahtecilik özelliklerini tespit edecektir. Ücretsiz Micro planı ayda 500 işlem içerir.
  * [GeoDataSource](https://www.geodatasource.com) — Konum arama hizmeti, enlem ve boylam koordinatları kullanarak şehir adlarını arar. Ücretsiz API, ayda 500 sorguya kadar destekler.
  * [Geolocated.io](https://geolocated.io) — Çok kıtalı sunucularla IP Coğrafi Konum API'si, günde 2.000 sorgu içeren ücretsiz plan sunar.
  * [Glitterly](https://glitterly.app/) - Temel şablonlardan programatik olarak dinamik görseller oluşturun. Restful API ve kodsuz entegrasyonlar. Ücretsiz katman, ayda 50 görsel ve beş şablon içerir.
  * [Hex](https://hex.tech/) - Not defterleri, veri uygulamaları ve bilgi kütüphaneleri için işbirlikçi veri platformu. Beş projeye kadar ücretsiz topluluk katmanı.
  * [Hook0](https://www.hook0.com/) - Hook0, web ürünlerinin kolayca webhook sunmasını sağlayan açık kaynaklı Webhooks-as-a-service (WaaS) hizmetidir. Ücretsiz olarak, günlük 100 olaya kadar gönderebilir, yedi gün boyunca geçmişini saklayabilirsiniz.
  * [Hoppscotch](https://hoppscotch.io) - Ücretsiz, hızlı ve güzel bir API istek oluşturucu.
  * [huggingface.co](https://huggingface.co) - Pytorch, TensorFlow ve JAX için NLP modelleri oluşturun, eğitin ve dağıtın. Ayda 30.000 giriş karakterine kadar ücretsiz.
  * [Hybiscus](https://hybiscus.dev/) - Basit bir deklaratif API ile PDF raporları oluşturun. 14 günlük ücretsiz katmanda 50 tek sayfalık rapor ve renk paleti ile fontları özelleştirme imkanı sunar.
  * [Invantive Cloud](https://cloud.invantive.com/) — Invantive SQL veya OData4 (genellikle Power BI veya Power Query) kullanarak Exact Online, Twinfield, ActiveCampaign veya Visma gibi 70'ten fazla (bulut) platforma erişin. Veri çoğaltma ve değişim içerir. Geliştiriciler ve uygulama danışmanları için ücretsiz plan. Belirli platformlar için veri hacminde sınırlamalar ile ücretsiz.
  * [ipaddress.sh](https://ipaddress.sh) — Farklı [formatlarda](https://about.ipaddress.sh/) herkese açık IP adresi alabileceğiniz basit hizmet.
  * [ip-api](https://ip-api.com) — IP Coğrafi Konum API'si, ticari olmayan kullanım için ücretsiz, API anahtarı gerekmez, ücretsiz planda aynı IP'den dakikada 45 sorgu ile sınırlıdır.
  * [ipbase.com](https://ipbase.com) - IP Coğrafi Konum API'si - Aylık 150 sorguluk sonsuza kadar ücretsiz plan.
  * [IP Geolocation](https://ipgeolocation.io/) — IP Coğrafi Konum API'si - Geliştiriciler için sonsuza kadar ücretsiz plan, günlük 1.000 sorgu sınırı.
  * [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — Abstract'tan IP Coğrafi Konum API'si - 1.000 ücretsiz sorguya izin verir.
  * [IPLocate](https://www.iplocate.io) — IP Coğrafi Konum API'si, günlük 1.000 sorguya kadar ücretsiz. Proxy/VPN/barındırma tespiti, ASN verisi, IP'den Şirkete ve daha fazlası dahil. IPLocate ayrıca CSV veya GeoIP uyumlu MMDB formatında ücretsiz indirilebilir IP'den Ülkeye ve IP'den ASN'ye veritabanları sunar.
  * [IP2Location](https://www.ip2location.com) — Freemium IP coğrafi konum hizmeti. LITE veritabanı ücretsiz indirilebilir. Veritabanını sunucuya aktarın ve yerel sorgu ile şehir, koordinat ve ISS bilgilerini belirleyin.
  * [IP2Location.io](https://www.ip2location.io/) — Freemium, hızlı ve güvenilir IP coğrafi konum API'si. Şehir, koordinat, ISS ve daha fazlası gibi veriler alın. Ücretsiz plan ayda 50.000 kredi içerir. IP2Location.io ayrıca ayda 500 ücretsiz WHOIS ve barındırılan alan sorgusu sunar. Alan adı kayıt ayrıntılarını görüntüleyin ve belirli bir IP'de barındırılan alan adlarını bulun. Daha fazla özellik için ücretli plana yükseltin.
  * [ipapi](https://ipapi.co/) - Kloudend, Inc tarafından IP Adres Konum API'si - AWS üzerinde kurulu, Fortune 500 tarafından güvenilen güvenilir bir coğrafi konum API'si. Ücretsiz katman, kayıt olmadan aylık 30.000 sorgu (günlük 1.000) sunar.
  * [ipapi.is](https://ipapi.is/) - Geliştiricilerden Geliştiricilere en iyi Barındırma Tespit yeteneklerine sahip güvenilir bir IP Adres API'si. Ücretsiz plan, kayıt olmadan 1.000 sorgu sunar.
  * [IPinfo](https://ipinfo.io/) — Hızlı, doğru ve ücretsiz (ayda 50.000'e kadar) IP adresi veri API'si. Coğrafi konum, şirketler, operatörler, IP aralıkları, alan adları, suistimal iletişimleri ve daha fazlası hakkında detaylar sunan API'ler. Tüm ücretli API'ler ücretsiz denenebilir.
  * [IPQuery](https://ipquery.io) — Geliştiriciler için sınırsız IP API, oran limiti veya fiyatlandırma yok.
  * [IPTrace](https://iptrace.io) — İşletmeniz için güvenilir ve faydalı IP coğrafi konum verisi sağlayan son derece basit bir API, ayda 50.000 ücretsiz sorgu.
  * [JSON2Video](https://json2video.com) - Video pazarlama ve sosyal medya videolarını programatik veya kodsuz olarak otomatikleştirmek için video düzenleme API'si.
  * [JSON IP](https://getjsonip.com) — İstekte bulunan istemcinin Genel IP adresini döndürür. Ücretsiz katman için kayıt gerekmez. CORS kullanarak, veriler doğrudan tarayıcıdan istemci tarafı JS ile istenebilir. İstemci ve sunucu IP değişikliklerini izleyen servisler için faydalıdır. Sınırsız istek.
  * [JSON Serve](https://jsonserve.com/) — Geliştiricilerin JSON nesnelerini depolamasına ve bu JSON'u uygulamalarında bir REST API olarak kullanmasına yardımcı olan ücretsiz bir hizmet.
  * [JSONing](https://jsoning.com/api/) — Bir JSON nesnesinden sahte bir REST API oluşturun, HTTP durum kodlarını, başlıkları ve yanıt gövdelerini özelleştirin.
  * [konghq.com](https://konghq.com/) — API Pazaryeri ve güçlü özel ve herkese açık API araçları. Ücretsiz katmanda bazı özellikler (izleme, uyarı ve destek gibi) sınırlıdır.
  * [Kreya](https://kreya.app) — gRPC API'lerini çağırmak ve test etmek için ücretsiz gRPC GUI istemcisi. Sunucu yansıtması ile gRPC API'lerini içe aktarabilir.
  * [Lightly](https://www.lightly.ai/) — Makine öğrenimi modellerinizi doğru verilerle geliştirin. 1.000 örneğe kadar veri kümeleri ücretsizdir.
  * [LoginLlama](https://loginllama.app) - Sahte ve şüpheli girişleri tespit edip müşterilerinizi bilgilendiren bir giriş güvenlik API'si. Ayda 1.000 giriş için ücretsiz.
  * [MailboxValidator](https://www.mailboxvalidator.com) — Gerçek posta sunucusu bağlantısı ile e-posta doğrulama hizmeti. Ücretsiz API planı ayda 100 doğrulama içerir.
  * [Market Data API](https://www.marketdata.app) - Hisse senetleri, opsiyonlar, yatırım fonları ve daha fazlası için gerçek zamanlı ve geçmiş finansal veri sunar. Sonsuza kadar ücretsiz API katmanı, günlük 100 API isteğine izin verir.
  * [Meteosource Weather API](https://www.meteosource.com/) — Mevcut ve tahmin edilen hava durumu verileri için küresel hava durumu API'si. Tahminler, daha iyi doğruluk sağlamak için birden fazla hava durumu modelinin makine öğrenimiyle birleştirilmesine dayanır. Ücretsiz plan ile günde 400 çağrı hakkı sunulur.
  * [microlink.io](https://microlink.io/) – Herhangi bir web sitesini metatag normalizasyonu, güzel bağlantı önizlemeleri, kazıma yetenekleri veya ekran görüntüleri gibi verilere dönüştürür. Günde 50 istek, her gün ücretsiz.
  * [Mindee](https://developers.mindee.com) – Mindee, geliştiricilerin uygulama iş akışlarını otomatikleştirmesine yardımcı olan güçlü bir OCR yazılımı ve API-öncelikli bir platformdur. Bilgisayarla görme ve makine öğrenimi kullanarak anahtar bilgilerin veri tanıması ile belge işleme katmanını standartlaştırır. Ücretsiz katman ayda 500 sayfa sunar.
  * [Mintlify](https://mintlify.com) — API dokümantasyonu için modern standart. Güzel ve kolay bakım yapılabilir kullanıcı arayüzü bileşenleri, uygulama içi arama ve etkileşimli oyun alanı. 1 editör için ücretsizdir.
  * [MockAPI](https://www.mockapi.io/) — MockAPI, API'ları hızlıca taklit etmenizi, özel veri üretmenizi ve RESTful bir arayüz kullanarak işlemler yapmanızı sağlayan basit bir araçtır. MockAPI prototipleme/test/öğrenme aracı olarak tasarlanmıştır. Ücretsiz olarak bir proje/ proje başına 2 kaynak hakkı sunar.
  * [Mockfly](https://www.mockfly.dev/) — Mockfly, API taklit etme ve özellik bayrağı yönetimi için güvenilir bir geliştirme aracıdır. Sezgisel arayüzüyle hızlıca sahte API’lar oluşturun ve yönetin. Ücretsiz katman günde 500 istek sunar.
  * [Mocki](https://mocki.io) - GitHub deposuna senkronize edilmiş sahte GraphQL ve REST API'lar oluşturmanıza olanak tanır. Basit REST API'ları kaydolmadan ücretsiz olarak geliştirin ve kullanın.
  * [Mocko.dev](https://mocko.dev/) — API’nizi proxy’leyin, bulutta hangi uç noktaların taklit edileceğini seçin ve trafiği inceleyin, ücretsizdir. Geliştirme ve entegrasyon testlerinizi hızlandırın.
  * [Mocky](https://designer.mocky.io/) - HTTP isteklerini taklit etmek için özel HTTP yanıtları oluşturan basit bir web uygulaması. Ayrıca [açık kaynak](https://github.com/julien-lafont/Mocky) olarak da mevcuttur.
  * [Mock N Roll](https://mpcknroll.me/) - Ücretsiz Mocks API Hizmeti—arka uç gecikmeleri olmadan gerçek API yanıtlarını simüle etmek için güçlü bir araç. Ön uç geliştiricileri, QA testçileri ve DevOps ekipleri için mükemmel. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
  * [microenv.com](https://microenv.com) — Geliştiriciler için sahte REST API oluşturun ve kod ve uygulamayı bir docker konteynerinde oluşturma imkanı sağlayın.
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) — Birden fazla düğümde çıkış IP adresinizi kontrol etmek ve IP'nizin farklı küresel bölgelerde ve hizmetlerde nasıl göründüğünü anlamak için ücretsiz ve basit bir araç. Control D gibi kurala dayalı DNS ayırıcı araçları test etmek için faydalıdır.
  * [Namekit](https://namekit.app/) - Yapay zeka destekli alan adı keşfi – anında uygun ve standart fiyatlı isimler bulun. Ücretsiz günlük sorgular.
  * [News API](https://newsapi.org) — Web üzerinde haber arayın ve JSON sonuçları alın. Geliştiricilere her gün 100 ücretsiz sorgu hakkı verilir. Makalelerde 24 saatlik gecikme vardır.
  * [numlookupapi.com](https://numlookupapi.com) - Ücretsiz telefon numarası doğrulama API'si - ayda 100 ücretsiz istek.
  * [OCR.Space](https://ocr.space/) — Görüntü ve pdf dosyalarını metin sonuçlarını JSON formatında döndüren bir OCR API'si. Ayda 25.000 ücretsiz istek ve 1MB dosya boyutu limiti.
  * [OpenAPI3 Designer](https://openapidesigner.com/) — Açık API 3 tanımlarını görsel olarak ücretsiz oluşturun.
  * [parsehub.com](https://parsehub.com/) — Dinamik sitelerden veri çıkarın, dinamik web sitelerini API'ya dönüştürün, beş proje ücretsiz.
  * [Parseur](https://parseur.com) — Ayda 20 ücretsiz sayfa: PDF ve e-postalardan veri çıkarın. Yapay zeka destekli. Tam API erişimi.
  * [PDFBolt](https://pdfbolt.com) - Gizliliğe önem veren geliştirici odaklı PDF oluşturma API'si. Stripe esintili dokümantasyon sunar ve ayda 500 ücretsiz PDF dönüştürmesi içerir.
  * [pdfEndpoint.com](https://pdfendpoint.com) - Basit bir API ile HTML veya URL'leri zahmetsizce PDF'ye dönüştürün. Ayda 100 dönüşüm ücretsiz.
  * [PDF-API.io](https://pdf-api.io) - PDF Otomasyon API'si, görsel şablon düzenleyici veya HTML'den PDF'ye, dinamik veri entegrasyonu ve API ile PDF oluşturma. Ücretsiz plan bir şablon ve ayda 100 PDF içerir.
  * [Pixela](https://pixe.la/) - Ücretsiz daystream veritabanı hizmeti. Tüm işlemler API ile gerçekleştirilir. Isı haritaları ve çizgi grafiklerle görselleştirme de mümkündür.
  * [Postman](https://postman.com) — İş akışlarını basitleştirin ve daha iyi API'lar oluşturun – daha hızlı – API geliştirme için işbirliği platformu olan Postman ile. Postman Uygulamasını sonsuza kadar ücretsiz kullanın. Postman bulut özellikleri de belirli sınırlar dahilinde ücretsizdir.
  * [Insomnia](https://insomnia.rest) - API tasarlama ve test etme için açık kaynak kodlu API istemcisi, REST ve GraphQL destekler.
  * [PrefectCloud](https://www.prefect.io/cloud/) — Veri akışı otomasyonu için eksiksiz bir platform. Ücretsiz plan 5 dağıtılmış iş akışı ve ayda 500 dakika sunucusuz işlem kredisi içerir.
  * [Preset Cloud](https://preset.io/) - Barındırılan Apache Superset hizmeti. 5 kullanıcıya kadar ekipler için sonsuza kadar ücretsiz, sınırsız pano ve grafik, kodsuz grafik oluşturucu ve işbirlikçi SQL editörü içerir.
  * [PromptLoop](https://www.promptloop.com/) - PromptLoop, neredeyse sıfır öğrenme süresiyle 10 kat daha kolay yapay zeka tabanlı web kazıma, mevcut iş akışlarında %85+ zaman tasarrufu ve manuel araştırmaya göre 4 kat daha hızlı çalışma sunar. Tüm araştırma görevleri için REST API uç noktası içerir. Her ay ilk 1.000 kredi ücretsizdir.
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — Ücretsiz kamuya açık API'ların listesi.
  * [Rapidapi](https://rapidapi.com/) - Dünya'nın En Büyük API Merkezi. Milyonlarca geliştirici binlerce API bulur ve bağlanır, eğlenceli meydan okumalar (çözümleriyle!) ve etkileşimli örneklerle API Geliştirme.
  * [RequestBin.com](https://requestbin.com) — HTTP isteklerinizi gönderebileceğiniz ücretsiz bir uç nokta oluşturun. Bu uç noktaya gönderilen tüm HTTP istekleri, ilgili yük ve başlıklarla kaydedilir; böylece web kancalarından ve diğer hizmetlerden gelen önerileri gözlemleyebilirsiniz.
  * [reqres.in](https://reqres.in) - AJAX isteklerinize yanıt vermeye hazır, ücretsiz barındırılan REST-API.
  * [Roboflow](https://roboflow.com) - Önceden makine öğrenimi deneyimi olmadan özel bilgisayarla görme modeli oluşturun ve dağıtın. Ücretsiz katman ayda 30 kredi içerir.
  * [ROBOHASH](https://robohash.org/) - Herhangi bir metinden benzersiz ve havalı görseller oluşturan web hizmeti.
  * [Scraper's Proxy](https://scrapersproxy.com) — Kazıma için basit HTTP proxy API'si. Kısıtlamalar, engellemeler veya captcha'larla uğraşmadan anonim olarak kazıyın. Her ay ilk 100 başarılı kazıma ücretsizdir (JavaScript işleme dahil, daha fazlası için destekle iletişime geçin).
  * [ScrapingAnt](https://scrapingant.com/) — Headless Chrome kazıma API'si ve ücretsiz kontrol edilmiş proxy hizmeti. Javascript işleme, premium dönen proxy'ler, CAPTCHA atlatma. 10.000 ücretsiz API kredisi.
  * [Simplescraper](https://simplescraper.io) — Her işlemden sonra webhook'unuzu tetikleyin. Ücretsiz plan 100 bulut kazıma kredisi içerir.
  * [Select Star](https://www.selectstar.com/) - Akıllı veri keşif platformu, verilerinizi otomatik olarak analiz eder ve belgelendirir. Ücretsiz hafif katman ile 2 Veri Kaynağı, 1.000'e kadar Tablo ve 25 Kullanıcıya kadar destek.
  * [Sheetson](https://sheetson.com) - Herhangi bir Google Sheet'i anında RESTful API'ya dönüştürün. Ücretsiz plan mevcuttur ve sayfa başına 1.000 ücretsiz satır içerir.
  * [Shipyard](https://www.shipyardapp.com) — Bulut için düşük kodlu veri orkestrasyon platformu. Düşük kodlu şablonlar ve kendi kodunuzla (Python, Node.js, Bash, SQL) oluşturun. Ücretsiz geliştirici planımız, bir kullanıcı için her ay 10 saat çalışma süresi sunar – birden fazla iş akışını otomatikleştirmek için fazlasıyla yeterli.
  * [Siterelic](https://siterelic.com/) - Siterelic API ile ekran görüntüsü alabilir, web sitelerini denetleyebilir, TLS taraması yapabilir, DNS sorgulayabilir, TTFB test edebilir ve daha fazlasını yapabilirsiniz. Ücretsiz plan ayda 100 API isteği sunar.
  * [SerpApi](https://serpapi.com/) - Gerçek zamanlı arama motoru kazıma API'si. Google, YouTube, Bing, Baidu, Walmart ve diğer makineler için yapılandırılmış JSON sonuçları döndürür. Ücretsiz plan ayda 100 başarılı API çağrısı içerir.
  * [SmartParse](https://smartparse.io) - SmartParse, zaman ve maliyet tasarrufu sağlayan geliştirici araçları sunan bir veri taşıma ve CSV'den API'ya platformudur. Ücretsiz katman ayda 300 İşlem Birimi, tarayıcı yüklemeleri, veri karantinası, devre kesici ve iş uyarıları içerir.
  * [Sofodata](https://www.sofodata.com/) - CSV dosyalarından güvenli RESTful API'lar oluşturun. Bir CSV dosyası yükleyin ve veriye API aracılığıyla anında erişin, böylece uygulama geliştirme hızlanır. Ücretsiz plan 2 API ve ayda 2.500 API çağrısı içerir. Kredi kartı gerekmez.
  * [Sqlable](https://sqlable.com/) - Ücretsiz çevrimiçi SQL araçları koleksiyonu: SQL biçimlendirici ve doğrulayıcı, SQL regex test aracı, sahte veri üretici ve etkileşimli veritabanı oyun alanları içerir.
  * [Stoplight](https://stoplight.io/) - API'lar için işbirlikçi tasarım ve dokümantasyon için SaaS. Ücretsiz plan tasarım, taklit ve dokümantasyon araçlarını ücretsiz sunar.
  * [Supportivekoala](https://supportivekoala.com/) — Girdiğiniz bilgilerle şablonlar üzerinden otomatik görseller oluşturmanızı sağlar. Ücretsiz plan ile ayda 50 görsel oluşturabilirsiniz.
  * [Svix](https://www.svix.com/) - Hizmet olarak Webhook. Ayda 50.000 mesaja kadar ücretsiz gönderim.
  * [Tavily AI](https://tavily.com/) - Çevrimiçi arama ve hızlı içgörüler ile kapsamlı araştırma için API; araştırma sonuçlarını organize etme yeteneği ile. Ücretsiz katmanda kredi kartı gerekmeden ayda 1000 istek.
  * [The IP API](https://theipapi.com/) - IP Coğrafi Konum API'si, günde 1000 ücretsiz istek. Bir IP adresinin ülke, şehir, bölge ve daha fazlası hakkında bilgi sunar.
  * [TinyMCE](https://www.tiny.cloud) - zengin metin düzenleyici API'si. Temel özellikler sınırsız kullanım için ücretsizdir.
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - Hava durumu API'sinin ücretsiz planını sunar. Doğru ve güncel hava durumu tahmini, küresel kapsama, geçmiş veriler ve hava durumu izleme çözümleri sağlar.
  * [Treblle](https://www.treblle.com) - Treblle, ekiplerin API oluşturmasına, göndermesine ve yönetmesine yardımcı olur. Gelişmiş API günlük toplama, gözlemlenebilirlik, dokümantasyon ve hata ayıklama. Tüm özellikler ücretsiz, ancak ücretsiz katmanda ayda en fazla 250 bin istek hakkı vardır.
  * [UniRateAPI](https://unirateapi.com) – 590+ para birimi ve kripto için gerçek zamanlı döviz kurları. Ücretsiz planda sınırsız API çağrısı, geliştiriciler ve finans uygulamaları için idealdir.
  * [vatcheckapi.com](https://vatcheckapi.com) - Basit ve ücretsiz KDV numarası doğrulama API'si. Ayda 150 ücretsiz doğrulama.
  * [WeatherXu](https://weatherxu.com/) — API ile güncel koşullar, saatlik ve günlük tahminler ve hava durumu uyarıları dahil küresel hava durumu verisi. Birden fazla hava durumu modelini analiz edip birleştirmek için yapay zeka ve makine öğrenimi entegrasyonu. Ücretsiz katman ayda 10.000 API çağrısı içerir.
  * [Webhook Store](https://www.openwebhook.io) - Üçüncü taraf web kancalarını saklamak ve localhost'ta hata ayıklamak için araç (ngrok tarzı). Açık kaynak ve kendi barındırmalı. Ücretsiz kişisel alan adı *kullanıcıadı*.github.webhook.store, ücretsiz genel alan adları *herşey*.webhook.store.
  * [WebScraping.AI](https://webscraping.ai) - Yerleşik ayrıştırıcı, Chrome işleme ve proxy'lerle basit Web Kazıma API'si. Ayda iki bin ücretsiz API çağrısı.
  * [Weights & Biases](https://wandb.ai) — Geliştirici odaklı MLOps platformu. Deney takibi, veri kümesi sürümleme ve model yönetimiyle daha iyi modelleri daha hızlı oluşturun. Yalnızca kişisel projeler için ücretsiz katman, 100 GB depolama dahil.
  * [What The Diff](https://whatthediff.ai) - Yapay zeka destekli kod inceleme asistanı. Ücretsiz plan, aylık 25.000 token (~10 PR) ile sınırlıdır.
  * [wolfram.com](https://wolfram.com/language/) — Bulutta yerleşik bilgi tabanlı algoritmalar.
  * [wrapapi.com](https://wrapapi.com/) — Herhangi bir web sitesini parametreli bir API'ya dönüştürün. Ayda 30 bin API çağrısı.
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — Headless tarayıcılar, yerleşik IP’ler ve basit fiyatlandırma ile web kazıma API’si. Ayda bin ücretsiz API çağrısı ve öğrenciler ile sivil toplum kuruluşları için ekstra kredi.
  * [Zipcodebase](https://zipcodebase.com) - Ücretsiz Posta Kodu API'si, Dünya Çapında Posta Kodu Verisi. Ayda 5.000 ücretsiz istek.
  * [Zipcodestack](https://zipcodestack.com) - Ücretsiz Posta Kodu API'si ve Posta Kodu Doğrulama. Ayda on bin ücretsiz istek.
  * [Zuplo](https://zuplo.com/) - API anahtarı doğrulaması, oran sınırlama, geliştirici dokümantasyonu ve para kazanma gibi özellikleri dakikalar içinde ekleyerek uçta API'lar tasarlayın, oluşturun ve dağıtın. AçıkAPI-uyumlu ve tamamen programlanabilir, web standardı API’ler ve Typescript ile. Ücretsiz plan ile 10 projeye, sınırsız üretim uç ortamına, ayda 1M istek ve 10GB çıkış hakkına sahip olun.

**[⬆️ Başa Dön](#table-of-contents)**

## Artifact Repos

  * [Artifactory](https://jfrog.com/start-free/) - Maven, Docker, Cargo, Helm, PyPI, CocoaPods ve GitLFS gibi birçok paket formatını destekleyen bir artifact deposu. Paket tarama aracı XRay ve CI/CD aracı Pipelines (eski adıyla Shippable) ile birlikte gelir; ücretsiz katmanda ayda 2.000 CI/CD dakikası içerir.
  * [central.sonatype.org](https://central.sonatype.org) — Apache Maven, SBT ve diğer yapı sistemleri için varsayılan artifact deposu.
  * [cloudrepo.io](https://cloudrepo.io) - Bulut tabanlı, özel ve herkese açık, Maven ve PyPi depoları. Açık kaynak projeler için ücretsizdir.
  * [cloudsmith.io](https://cloudsmith.io) — Java/Maven, RedHat, Debian, Python, Ruby, Vagrant ve daha fazlası için basit, güvenli ve merkezi depo hizmeti. Ücretsiz katman + açık kaynak için ücretsiz.
  * [jitpack.io](https://jitpack.io/) — JVM ve Android projeleri için GitHub üzerinde Maven deposu, herkese açık projeler için ücretsiz.
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Maven, RPM, DEB, PyPi, NPM ve RubyGem paketleri için kullanımı kolay depo barındırma (ücretsiz katmanı mevcut).
  * [repsy.io](https://repsy.io) — 1 GB ücretsiz özel/herkese açık Maven Deposu.
  * [Gemfury](https://gemfury.com) — Maven, PyPi, NPM, Go Module, Nuget, APT ve RPM depoları için özel ve herkese açık artifact depoları. Herkese açık projeler için ücretsizdir.
  * [paperspace](https://www.paperspace.com/) — AI modelleri oluşturun ve ölçeklendirin, AI uygulamaları geliştirin, eğitin ve dağıtın, ücretsiz plan: herkese açık projeler, 5Gb depolama, temel örnekler.
  * [RepoForge](https://repoforge.io) - Python, Debian, NPM paketleri ve Docker registry'leri için özel bulut barındırmalı depo. Açık kaynak/herkese açık projeler için ücretsiz plan.
  * [RepoFlow](https://repoflow.io) - RepoFlow, npm, PyPI, Docker, Go, Helm ve daha fazlası için paket yönetimini basitleştirir. Bulutta 10 GB depolama, 10 GB bant genişliği, 100 paket ve sınırsız kullanıcı ile ücretsiz deneyin veya yalnızca kişisel kullanım için kendi sunucunuzda barındırın.

**[⬆️ Başa Dön](#table-of-contents)**

## Takımlar ve İşbirliği için Araçlar
  * [3Cols](https://3cols.com/) - Kişisel ve ortak kullanım için ücretsiz bulut tabanlı kod parçacığı yöneticisi.
  * [Bitwarden](https://bitwarden.com) — Bireyler, ekipler ve iş organizasyonları için hassas verileri saklamanın, paylaşmanın ve senkronize etmenin en kolay ve güvenli yolu.
  * [Braid](https://www.braidchat.com/) — Ekipler için tasarlanmış sohbet uygulaması. Genel erişim grubu, sınırsız kullanıcı, geçmiş ve entegrasyonlar için ücretsizdir. Ayrıca kendi barındırılabilen açık kaynak kodlu sürümü de vardır.
  * [cally.com](https://cally.com/) — Bir toplantı için en uygun zaman ve tarihi bulun. Kullanımı basit, küçük ve büyük gruplar için harika çalışır.
  * [Calendly](https://calendly.com) — Toplantı ayarlamak ve bağlantı kurmak için araç. Ücretsiz plan kullanıcı başına 1 Takvim bağlantısı ve Sınırsız oturum sunar. Masaüstü ve Mobil uygulamalar da sunulmaktadır.
  * [Discord](https://discord.com/) — Genel/özel odalarda sohbet. Markdown metni, ses, video ve ekran paylaşımı özellikleri. Sınırsız kullanıcı için ücretsizdir.
  * [Fibo](https://fibo.dev) - Sınırsız üyenin hikaye puanları tahmini yapabildiği, çevrimiçi ücretsiz ve gerçek zamanlı scrum poker aracı. Çevik ekipler için hızlı planlama sağlar.
  * [Telegram](https://telegram.org/) — Hızlı ve güvenilir mesajlaşma ve arama isteyen herkes için Telegram. İş kullanıcıları ve küçük ekipler, büyük gruplar, kullanıcı adları, masaüstü uygulamaları ve güçlü dosya paylaşım seçeneklerinden hoşlanabilir.
  * [DevToolLab](https://devtoollab.com) — Tüm temel araçlara ücretsiz erişim sunan çevrimiçi geliştirici araçları, her araç için otomatik olarak bir giriş kaydedebilme, standart işlem hızı ve topluluk desteği.
  * [Dubble](https://dubble.so/) — Ücretsiz Adım Adım Rehber oluşturucu. Ekran görüntüleri alın, süreçleri belgeleyin ve ekibinizle işbirliği yapın. Ayrıca asenkron ekran kaydı desteği de sunar.
  * [Duckly](https://duckly.com/) — Ekibinizle gerçek zamanlı konuşun ve işbirliği yapın. IDE, terminal paylaşımı, ses, video ve ekran paylaşımı ile eşli programlama. Küçük ekipler için ücretsizdir.
  * [Dyte](https://dyte.io) - Üretkenliği ve etkileşimi artırmak için işbirlikçi eklentilerle en geliştirici dostu canlı video & ses SDK'sı. Ücretsiz katman, aylık 10.000 dakika canlı video/ses kullanımı içerir.
  * [evernote.com](https://evernote.com/) — Bilgi düzenleme aracı. Notlarınızı paylaşın ve başkalarıyla birlikte çalışın.
  * [Fibery](https://fibery.io/) — Bağlantılı çalışma alanı platformu. Tekil kullanıcılar için ücretsiz, 2 GB disk alanı sınırıyla.
  * [flock.com](https://flock.com) — Ekibinizin daha hızlı iletişim kurması için bir yol. Ücretsiz Sınırsız Mesaj, Kanal, Kullanıcı, Uygulama & Entegrasyon
  * [Gather](https://www.gather.town/) - Çevrimiçi buluşmanın daha iyi bir yolu. Tamamen özelleştirilebilir alanlara odaklanan Gather, topluluklarınızla zaman geçirmenizi gerçek hayattaki kadar kolay hale getirir. Aynı anda 10 kullanıcıya kadar ücretsizdir.
  * [gokanban.io](https://gokanban.io) - Hızlı kullanım için kayıt gerektirmeyen, sözdizimine dayalı Kanban Panosu. Sınırsız ve ücretsiz.
  * [flat.social](https://flat.social) - Ekip toplantıları ve sosyal saatler için etkileşimli, özelleştirilebilir alanlar. Sınırsız toplantı, aynı anda 8 kullanıcıya kadar ücretsiz.
  * [GitDailies](https://gitdailies.com) - Ekibinizin GitHub’daki Commit ve Pull Request aktivitelerinin günlük raporları. Push görselleştirici, akran tanıma sistemi ve özel uyarı oluşturucu içerir. Ücretsiz katman sınırsız kullanıcı, üç repo ve 3 uyarı yapılandırması içerir.
  * [gitter.im](https://gitter.im/) — GitHub için sohbet. Sınırsız herkese açık ve özel oda, 25 kişilik ekipler için ücretsiz
  * [Hackmd.io](https://hackmd.io/) - Markdown formatındaki belgeler/dosyalar için gerçek zamanlı işbirliği ve yazım aracı. Google Docs gibi ama markdown dosyaları için. Ücretsiz olarak sınırsız "not" oluşturabilirsiniz, ancak özel notlar & şablonlar için davetli sayısı [sınırlı olacaktır](https://hackmd.io/pricing).
  * [hangouts.google.com](https://hangouts.google.com/) — Tüm konuşmalarınız için tek bir yer, ücretsiz, bir Google hesabı gerektirir
  * [HeySpace](https://hey.space) - Sohbet, takvim, zaman çizelgesi ve video aramaları ile görev yönetim aracı. 5 kullanıcıya kadar ücretsizdir.
  * [helplightning.com](https://www.helplightning.com/) — Artırılmış gerçeklikle video üzerinden yardım. Analitik, şifreleme ve destek olmadan ücretsiz
  * [ideascale.com](https://ideascale.com/) — Müşterilerin fikir göndermesine ve oy vermesine izin verin, 1 toplulukta 25 üye için ücretsiz
  * [Igloo](https://www.igloosoftware.com/) — Belgelerin, blogların, takvimlerin vb. paylaşımı için dahili portal. 10 kullanıcıya kadar ücretsizdir.
  * [Keybase](https://keybase.io/) — Keybase, Slack’e FOSS bir alternatiftir; sohbetlerinizi ve dosyalarınızı ailelerden topluluklara, şirketlere kadar güvenli tutar.
  * [Google Meet](https://meet.google.com/) — İşletmeniz için çevrimiçi video toplantılarını Google Meet ile yapın. Meet, güvenli ve kolay katılım sağlayan çevrimiçi toplantılar sunar.
  * [/meet for Slack](https://meetslack.com) - Google Meetings'i doğrudan Slack'ten herhangi bir kanal, grup veya DM üzerinden /meet komutuyla başlatın. Herhangi bir kısıtlama olmadan ücretsizdir.
  * [Livecycle](https://www.livecycle.io/) — Livecycle, işlevler arası ürün ekipleri ve açık kaynak projeleri için iş akışlarını sorunsuz hale getiren kapsayıcı bir işbirliği platformudur.
  * [Lockitbot](https://www.lockitbot.com/) — Slack içerisinde oda, geliştirme ortamı, sunucu gibi paylaşılan kaynakları ayırtın ve kilitleyin. 2 kaynağa kadar ücretsiz.
  * [MarkUp](https://www.markup.io/) — MarkUp, web siteleriniz, PDF’leriniz ve görselleriniz üzerinde doğrudan geri bildirim toplamanıza olanak tanır.
  * [Proton Pass](https://proton.me/pass) — Dahili e-posta takma adları, 2FA doğrulayıcı, paylaşım ve passkey özellikli şifre yöneticisi. Web, tarayıcı eklentisi, mobil uygulama ve masaüstünde kullanılabilir.
  * [Visual Debug](https://visualdebug.com) - Daha iyi müşteri-geliştirici iletişimi için görsel geri bildirim aracı
  * [meet.jit.si](https://meet.jit.si/) — Tek tıkla video görüşmeleri ve ekran paylaşımı, ücretsiz
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams, sohbet tabanlı dijital bir merkezdir; konuşmaları, içerikleri ve uygulamaları tek bir deneyimde bir araya getirir. 500.000 kullanıcıya kadar ücretsizdir.
  * [Miro](https://miro.com/) - Dağıtık ekipler için ölçeklenebilir, güvenli, cihazlar arası, kurumsal düzeyde işbirliği beyaz tahtası. Freemium planı ile.
  * [nootiz](https://www.nootiz.com/) - Herhangi bir web sitesinde görsel geri bildirim toplamak ve yönetmek için başvurulan araç
  * [Notion](https://www.notion.so/) - Not alma ve işbirliği uygulaması olup, markdown desteğiyle görevleri, vikileri ve veritabanlarını entegre eder. Şirket, uygulamayı not alma, proje yönetimi ve görev yönetimi için hepsi bir arada çalışma alanı olarak tanımlar. Platformlar arası uygulamaların yanı sıra çoğu web tarayıcısından da erişilebilir.
  * [Nuclino](https://www.nuclino.com) - Ekibinizin tüm bilgi, belge ve notları için hafif ve işbirliğine dayalı bir wiki. Temel özelliklerin tamamını içeren ücretsiz plan, 50 öğe ve 5GB depolama sunar.
  * [OnlineInterview.io](https://onlineinterview.io/) - Gömülü video sohbet, çizim tahtası ve çevrimiçi kod düzenleyicisine sahip ücretsiz kod mülakat platformu; kodunuzu tarayıcıda derleyip çalıştırabilirsiniz. Tek tıkla uzaktan mülakat odası oluşturabilirsiniz.
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - Takımlar için basit bir zaman çizelgesi ve zaman takip uygulaması. Ücretsiz plan, 10 kullanıcıya kadar zaman takibi ve rapor oluşturma özellikleri sunar.
  * [PageShare.dev](https://www.pageshare.dev) - Web sitelerini dağıtmaya gerek kalmadan GitHub Pull Request’lerine görsel inceleme yetenekleri ekler. Ayda 10 sayfaya kadar ve toplamda 100MB depolama ile ücretsizdir.
  * [Pendulums](https://pendulums.io/) - Kullanımı kolay arayüzü ve değerli istatistikleriyle zamanınızı daha iyi yönetmenizi sağlayan ücretsiz zaman takip aracı.
  * [Pumble](https://pumble.com) - Ücretsiz ekip sohbet uygulaması. Sınırsız kullanıcı ve mesaj geçmişi, sonsuza kadar ücretsiz.
  * [Raindrop.io](https://raindrop.io) - macOS, Windows, Android, iOS ve Web için özel ve güvenli yer imi uygulaması. Sınırsız yer imi ve işbirliği ücretsiz.
  * [element.io](https://element.io/) — Matrix üzerine kurulu, merkeziyetsiz ve açık kaynak iletişim aracı. Grup sohbetleri, doğrudan mesajlaşma, şifreli dosya transferleri, sesli ve görüntülü sohbetler ve diğer servislerle kolay entegrasyon.
  * [Rocket.Chat](https://rocket.chat/) - Omnichannel özellikli, Matrix Federasyonu, diğer uygulamalarla köprü, sınırsız mesajlaşma ve tam mesaj geçmişi ile açık kaynak iletişim platformu.
  * [seafile.com](https://www.seafile.com/) — Özel ya da bulut depolama, dosya paylaşımı, senkronizasyon, tartışmalar. Bulut versiyonu yalnızca 1 GB sunar
  * [Sema](https://www.semasoftware.com/) - Birden fazla depodaki katkıları tek bir raporda birleştirip anlık görüntüsünü alabilen ücretsiz geliştirici portföy aracı.
  * [Screen Sharing via Browser](https://screensharing.net) - Tarayıcıdan ekranınızı iş arkadaşlarınızla paylaşabileceğiniz ücretsiz ekran paylaşım aracı, indirme ya da kayıt gerekmez. Ücretsizdir.
  * [Slab](https://slab.com/) — Ekipler için modern bilgi yönetim servisi. 10 kullanıcıya kadar ücretsiz.
  * [slack.com](https://slack.com/) — Bazı özellik sınırlamalarıyla sınırsız kullanıcı için ücretsiz
  * [Spectrum](https://spectrum.chat/) - Ücretsiz olarak herkese açık veya özel topluluklar oluşturun.
  * [StatusPile](https://www.statuspile.com/) - Durum sayfalarının bir durumu. Üst sağlayıcılarınızın durum sayfalarını takip edebilir misiniz?
  * [Stickies](https://stickies.app/) - Beyin fırtınası, içerik kürasyonu ve notlar için kullanılan görsel işbirliği uygulaması. 3 duvara kadar, sınırsız kullanıcı ve 1 GB depolama ile ücretsiz.
  * [Stacks](https://betterstacks.com/) - Entegre notlar, bağlantılar ve dosya depolama ile içerik çalışma alanı; bilgi karmaşasında yolunuzu bulun. Sonsuza kadar ücretsiz kişisel plan.
  * [talky.io](https://talky.io/) — Ücretsiz grup video sohbeti. Anonim. Eşler arası. Eklenti, kayıt ya da ödeme gerekmez
  * [Teamhood](https://teamhood.com/) - Ücretsiz Proje, Görev ve Sorun takip yazılımı. Swimlane’li Kanban ve tam Scrum uygulamasını destekler. Entegre zaman takibi bulunur. Beş kullanıcı ve üç proje portföyüne kadar ücretsiz.
  * [Teamplify](https://teamplify.com) - Ekip geliştirme süreçlerini Ekip Analitiği ve Akıllı Günlük Toplantı ile iyileştirin. Uzaktan çalışan ekipler için tam özellikli İzin Yönetimi içerir. 5 kullanıcıya kadar küçük gruplar için ücretsizdir.
  * [Tefter](https://tefter.io) - Güçlü Slack entegrasyonuna sahip yer imi uygulaması. Açık kaynak ekipler için ücretsizdir.
  * [TeleType](https://teletype.oorja.io/) — Terminal, ses, kod, beyaz tahta ve daha fazlasını paylaşın. Geliştiriciler için uçtan uca şifreli işbirliği, oturum açma gerekmez.
  * [TimeCamp](https://www.timecamp.com/) - Sınırsız kullanıcı için ücretsiz zaman takip yazılımı. Jira, Trello, Asana vb. PM araçlarıyla kolayca entegre olur.
  * [Huly](https://huly.io/) - Hepsi Bir Arada Proje Yönetimi Platformu (Linear, Jira, Slack, Notion, Motion alternatifi) - sınırsız kullanıcı, çalışma alanı başına 10GB depolama, 10GB video(ses) trafiği.
  * [Teamcamp](https://www.teamcamp.app) - Yazılım geliştirme şirketleri için hepsi bir arada proje yönetimi uygulaması.
  * [twist.com](https://twist.com) — Konuşmaların düzenli ve konu odaklı kaldığı, eşzamansız ekip iletişim uygulaması. Ücretsiz ve Sınırsız planlar mevcut. Uygun ekipler için indirimler sağlanır.
  * [tldraw.com](https://tldraw.com) —  Ücretsiz açık kaynaklı beyaz tahta ve diyagram aracı; akıllı oklar, yapışkan notlar ve SVG dışa aktarma özellikleriyle. Çok oyunculu modda işbirlikçi düzenleme. Ücretsiz resmi VS Code eklentisi de mevcut.
  * [BookmarkOS.com](https://bookmarkos.com) - Klasör işbirliğiyle özelleştirilebilir çevrimiçi masaüstünde ücretsiz hepsi bir arada yer imi yöneticisi, sekme yöneticisi ve görev yöneticisi.
  * [typetalk.com](https://www.typetalk.com/) — Ekibinizle anında mesajlaşma yoluyla fikirleri paylaşın ve tartışın, web veya mobilde
  * [Tugboat](https://tugboat.qa) - Her çekme isteği için otomatik ve isteğe bağlı önizleme. Herkes için ücretsiz, kar amacı gütmeyenler için ücretsiz Nano katman.
  * [whereby.com](https://whereby.com/) — Tek tıkla video görüşmeleri, ücretsiz (eski adıyla appear.in)
  * [windmill.dev](https://windmill.dev/) - Windmill, minimal Python ve Typescript betiklerinden üretim düzeyinde çok adımlı otomasyon ve dahili uygulamalar oluşturmak için açık kaynak geliştirici platformudur. Ücretsiz kullanıcı olarak en fazla üç adet premium olmayan çalışma alanı oluşturabilir veya üye olabilirsiniz.
  * [vadoo.tv](https://vadoo.tv/) — Video barındırma ve pazarlama kolaylaştı. Videoları tek tıkla yükleyin. Kaydedin, yönetin, paylaşın & daha fazlası. Ücretsiz katman 10 video, 1 GB depolama ve 10 GB bant genişliği/ay sunar.
  * [userforge.com](https://userforge.com/) - Birbirine bağlı çevrimiçi persona, kullanıcı hikayeleri ve bağlam haritalama. Tasarım ve geliştirmeyi senkronize tutmaya yardımcı olur; 3 persona ve iki işbirlikçiye kadar ücretsiz.
  * [wistia.com](https://wistia.com/) — Ziyaretçi analizli video barındırma, HD video teslimi ve pazarlama araçları; 25 video ve Wistia markalı oynatıcı
  * [wormhol.org](https://www.wormhol.org/) — Basit dosya paylaşım servisi. Sınırsız dosyayı 5GB'a kadar istediğiniz kadar kişiyle paylaşın.
  * [Wormhole](https://wormhole.app/) - 5GB'a kadar dosyaları uçtan uca şifreleme ile 24 saate kadar paylaşın. 5 GB'dan büyük dosyalarda, dosyalarınızı doğrudan eşler arası transfer ile gönderir.
  * [zoom.us](https://zoom.us/) — Güvenli Video ve Web konferansı, eklentiler mevcut. Ücretsiz plan 40 dakika ile sınırlıdır.
  * [Zulip](https://zulip.com/) — Eşzamanlı sohbet ve benzersiz e-posta benzeri konu akışı modeli. Ücretsiz plan 10.000 mesaj arama geçmişi ve 5 GB dosya depolama içerir. Ayrıca kendi kendine barındırılabilen açık kaynak sürümü de vardır.
  * [robocorp.com](https://robocorp.com) - Automation Ops için açık kaynak yığını. Bulut özelliklerini deneyin ve basit otomasyonları ücretsiz uygulayın. 240 dk/ay robot çalışması, 10 Asistan çalıştırması, 100 MB depolama.
  * [Fleep.io](https://fleep.io/) — Fleep, Slack’e alternatif. Küçük ekipler için ücretsiz planı var; tam mesaj geçmişi, sınırsız 1:1 sohbet, 1 grup sohbeti ve 1 GB dosya depolama.
  * [Chanty.com](https://chanty.com/) — Chanty, Slack’e başka bir alternatif. Küçük ekipler (10’a kadar) için sonsuza kadar ücretsiz plan; sınırsız herkese açık ve özel sohbet, aranabilir geçmiş, sınırsız 1:1 sesli arama, sınırsız sesli mesaj, on entegrasyon ve ekip başına 20 GB depolama.
  * [ruttl.com](https://ruttl.com/) — Dijital geri bildirim toplamak ve web sitelerini, PDF'leri ve görselleri incelemek için en iyi hepsi bir arada geri bildirim aracı.
  * [Mattermost](https://mattermost.com/) — Teknik ekipler için güvenli işbirliği. Sınırsız kanal, playbook, pano, kullanıcı, 10GB depolama ve daha fazlası ile ücretsiz plan.
  * [Webvizio](https://webvizio.com) — Web sitesi geri bildirim aracı, web sitesi inceleme yazılımı ve canlı web siteleri/web uygulamaları, görseller, PDF’ler ve tasarım dosyaları üzerinde doğrudan görev işbirliği için hata bildirim aracı.
  * [Pullflow](https://pullflow.com) — Pullflow, GitHub, Slack ve VS Code üzerinde kod inceleme işbirliği için AI destekli bir platform sunar.
  * [Webex](https://www.webex.com/) — 100 katılımcı ile toplantı başına 40 dakika sunan ücretsiz plan ile video toplantılar.
  * [RingCentral](https://www.ringcentral.com/) — 100 katılımcı ile toplantı başına 50 dakika sunan ücretsiz plan ile video toplantılar.
  * [GitBook](https://www.gitbook.com/) — Teknik bilgiyi yakalama ve dokümantasyon platformu — ürün belgelerinden dahili bilgi tabanlarına ve API’lere kadar. Bireysel geliştiriciler için ücretsiz plan.
  * [transfernow](https://www.transfernow.net/) — dosya paylaşmak için en basit, hızlı ve güvenli arayüz. Fotoğraf, video ve diğer büyük dosyaları zorunlu abonelik olmadan gönderin.
  * [paste.sh](https://paste.sh/) — Bu, JavaScript ve Kripto tabanlı basit bir paste sitesidir.
  * [Revolt.chat](https://revolt.chat/) — [Discord](https://discord.com/) için Açık Kaynak bir alternatif; gizliliğinize saygı duyar. Discord’daki çoğu özel özelliği ücretsiz sunar. Revolt, güvenli ve hızlı, tamamen ücretsiz, hepsi bir arada bir uygulamadır. Tüm özellikleri ücretsizdir. Çoğu ana akım sohbet uygulamasının aksine (resmi ve gayri resmi) eklenti desteği de vardır.
  * [Tencent RTC](https://trtc.io/) — Tencent Gerçek Zamanlı İletişim (TRTC), grup sesli/görüntülü arama çözümleri sunar. İlk yıl için ayda 10.000 ücretsiz dakika.
  * [Pastefy](https://pastefy.app/) - İsteğe bağlı istemci şifrelemesi, çok sekmeli paste’ler, API, vurgulu editör ve daha fazlasına sahip güzel ve basit bir Pastebin.
  * [SiteDots](https://sitedots.com/) - Web sitesi projeleri için doğrudan web siteniz üzerinde geri bildirim paylaşın, taklit, tuval veya geçici çözümler gerekmez. Tamamen fonksiyonel ücretsiz katman.

**[⬆️ Başa Dön](#table-of-contents)**

## CMS

  * [acquia.com](https://www.acquia.com/) — Drupal siteleri için barındırma. Geliştiriciler için ücretsiz katman. Ücretsiz geliştirme araçları (örneğin Acquia Dev Desktop) da mevcuttur.
  * [Contentful](https://www.contentful.com/) — Headless CMS. Bulutta içerik yönetimi ve teslim API’leri. Beş kullanıcı, 25K kayıt, 48 İçerik Tipi, 2 dil içeren bir ücretsiz Community alanı ile gelir.
  * [Cosmic](https://www.cosmicjs.com/) — Headless CMS ve API araç seti. Geliştiriciler için ücretsiz kişisel planlar.
  * [Crystallize](https://crystallize.com) — E-ticaret desteğiyle Headless PIM. Yerleşik GraphQL API. Ücretsiz sürümde sınırsız kullanıcı, 1000 katalog öğesi, 5 GB/ay bant genişliği ve 25k/ay API çağrısı dahildir.
  * [DatoCMS](https://www.datocms.com/) - Küçük projeler için ücretsiz katman sunar. DatoCMS, GraphQL tabanlı bir CMS’dir. Alt katmanda ayda 100k çağrınız olur.
  * [Directus](https://directus.io) — Headless CMS. Varlıklarınızı ve veritabanı içeriğinizi yerinde veya bulutta yönetmek için tamamen ücretsiz ve açık kaynaklı platform. Sınır veya ödeme duvarı yok.
  * [FrontAid](https://frontaid.io/) — JSON içeriğini doğrudan Git deposunda saklayan Headless CMS. Kısıtlama yok.
  * [kontent.ai](https://www.kontent.ai) - İçerik hizmeti olarak platform; tüm headless CMS avantajlarını sunarken pazarlamacılara da güç verir. Geliştirici planı, iki kullanıcıya her biri iki ortamlı sınırsız proje, 500 içerik öğesi, iki dil, Teslim ve Yönetim API’si ve Özel öğe desteği sunar. İhtiyaçlarınıza uygun daha ayrıntılı planlar kullanabilirsiniz.
  * [Prismic](https://www.prismic.io/) — Headless CMS. Tamamen barındırılan ve ölçeklenebilir API ile içerik yönetim arayüzü. Community Planı, bir kullanıcıya sınırsız API çağrısı, belge, özel tür, varlık ve dil sunar. Bir sonraki projeniz için ihtiyacınız olan her şey. Açık İçerik/Açık Kaynak projeler için daha büyük ücretsiz planlar mevcuttur.
  * [Sanity.io](https://www.sanity.io/) - Yapılandırılmış içerik için platform; açık kaynak düzenleme ortamı ve gerçek zamanlı barındırılan veri deposu ile. Sınırsız proje. Sınırsız admin kullanıcı, üç admin olmayan kullanıcı, iki veri seti, 500K API CDN isteği, 10GB bant genişliği ve 5GB varlık proje başına ücretsizdir.
  * [sensenet](https://sensenet.com) - API-öncelikli headless CMS; her ölçekte işletme için kurumsal düzeyde çözümler sunar. Geliştirici planı üç kullanıcı, 500 içerik öğesi, üç yerleşik rol, 25+5 içerik türü, tamamen erişilebilir REST API, belge önizleme üretimi ve Office Online düzenleme sunar.
  * [TinaCMS](https://tina.io/) — Forestry.io’nun yerine geçti. Markdown, MDX ve JSON desteğiyle Git tabanlı açık kaynak headless CMS. Temel teklif iki kullanıcı ile ücretsizdir.
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby, herhangi bir CMS, API veya veritabanı ile web sitesi oluşturmayı yeniden eğlenceli hale getiren hızlı ve esnek çerçevedir. Daha fazla trafik çeken, daha iyi dönüşüm sağlayan ve daha çok kazandıran başsız web siteleri oluşturup dağıtın!
  * [Hygraph](https://hygraph.com/) - Küçük projeler için ücretsiz katman sunar. GraphQL öncelikli API. Geleneksel çözümlerden GraphQL yerel Headless CMS’e geçin ve içerik API’sini çok kanallı sunun.
* [Squidex](https://squidex.io/) - Küçük projeler için ücretsiz katman sunar. API / GraphQL öncelikli. Açık kaynaklıdır ve event sourcing tabanlıdır (her değişikliği otomatik olarak versiyonlar).
* [InstaWP](https://instawp.com/) - Birkaç saniye içinde bir WordPress sitesi başlatın. 5 Aktif Site, 500 MB Alan, 48 saat Site Süresi ile ücretsiz katman.
* [Storyblok](https://www.storyblok.com) - Tüm modern frameworklerle çalışan geliştiriciler ve pazarlamacılar için Headless CMS. Community (ücretsiz) katmanı; Yönetim API’si, Görsel Editör, on kaynak, Özel Alan Tipleri, Uluslararasılaştırma (sınırsız dil/bölge), Varlık Yöneticisi (2500 varlığa kadar), Görüntü Optimize Servisi, Arama Sorgusu, Webhook + ayda 250GB trafik içerir.
* [WPJack](https://wpjack.com) - WordPress’i herhangi bir bulut ortamında 5 dakikadan kısa sürede kurun! Ücretsiz katman; 1 sunucu, 2 site, ücretsiz SSL sertifikaları ve sınırsız cron job içerir. Zaman sınırı veya sona erme yok — siteniz, sizin yolunuz.

**[⬆️ Başa Dön](#table-of-contents)**

## Kod Üretimi

* [Appinvento](https://appinvento.io/) — AppInvento, ücretsiz bir No code uygulama oluşturucusudur. Otomatik olarak oluşturulan arka uç kodunda, kullanıcılar kaynak koda ve sınırsız API ve rotalara tam erişime sahip olup kapsamlı entegrasyon sağlar. Ücretsiz plan; üç proje, beş tablo ve bir Google eklentisi içerir.
* [Cody AI](https://sourcegraph.com/cody) - Cody, kod tabanınızı derinlemesine anlayan ve kod yazmanızı ve anlamanızı hızlandırmak için yapay zeka kullanan bir kodlama asistanıdır. Cody, geliştiricilere LLM seçeneği (yerel çıkarım dahil) sunar, çeşitli IDE’ler için desteklidir, tüm popüler programlama dillerini destekler ve ücretsiz planı vardır. Ücretsiz planla geliştiricilere ayda 20 sohbet mesajı (Claude 3 Sonnet ile) ve 500 otomatik tamamlama (Starcoder 16b ile) hakkı verilir.
* [DhiWise](https://www.dhiwise.com/) — DhiWise’in yenilikçi kod üretim teknolojisiyle Figma tasarımlarını sorunsuzca dinamik Flutter & React uygulamalarına dönüştürün; iş akışınızı optimize edin ve olağanüstü mobil ve web deneyimleri daha hızlı oluşturun.
* [Codeium](https://www.codeium.com/) — Codeium, ücretsiz bir yapay zeka destekli kod tamamlama aracıdır. 20’den fazla programlama dilini (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, vb.) destekler ve tüm önemli bağımsız ve web IDE’leriyle entegre olur.
* [Fern](https://buildwithfern.com) - API tanımları yazın ve bunları TypeScript, Python, Java, Go ve daha fazlası gibi popüler dillerde SDK’lara/istemci kütüphanelerine dönüştürün. OpenAPI tamamen desteklenir. Ücretsiz katmanda en fazla 20 endpoint için kod üretilir.
* [Metalama](https://www.postsharp.net/metalama) - Sadece C# için. Metalama, kodun tekrar eden kısımlarını derleme sırasında anında üretir, böylece kaynak kodunuz temiz kalır. Açık kaynak projeler için ücretsizdir ve ticari dostu ücretsiz katmanı üç aspect içerir.
* [Supermaven](https://www.supermaven.com/) — Supermaven, VSCode, JetBrains ve Neovim için hızlı bir yapay zeka kod tamamlama eklentisidir. Ücretsiz katman sınırsız satır içi tamamlama sunar.
* [tabnine.com](https://www.tabnine.com/) — Tabnine, geliştiricilerin daha iyi yazılımı daha hızlı üretmesine yardımcı olur; dünyanın tüm kodlarından öğrenilen içgörüleri sunar. Eklenti mevcuttur.
* [v0.dev](https://v0.dev/) — v0, basit metin istemlerine dayalı olarak kod üretmek için yapay zeka modelleri kullanır. Kopyala-yapıştır dostu, shadcn/ui ve Tailwind CSS’e dayalı React kodu üretir, projelerinizde kullanılabilir. Her üretim en az 30 krediye mal olur. 1200 krediyle başlarsınız ve her ay 200 ücretsiz kredi alırsınız.

**[⬆️ Başa Dön](#table-of-contents)**

## Kod Kalitesi

* [beanstalkapp.com](https://beanstalkapp.com/) — Kod yazmak, gözden geçirmek ve dağıtmak için eksiksiz bir iş akışı, bir kullanıcı ve 100 MB depolamalı bir depo için ücretsiz hesap
* [browserling.com](https://www.browserling.com/) — Canlı etkileşimli tarayıcılar arası test, ücretsizde yalnızca 3 dakikalık oturumlar, MS IE 9, Vista altında, 1024 x 768 çözünürlükte
* [codacy.com](https://www.codacy.com/) — PHP, Python, Ruby, Java, JavaScript, Scala, CSS ve CoffeeScript için otomatik kod incelemesi, sınırsız açık ve özel depo için ücretsiz
* [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - DevOps için Otomatik Infrastructure as Code inceleme aracı, GitHub, Bitbucket ve GitLab (kendinden barındırılan dahil) ile entegre olur. Standart dillere ek olarak Ansible, Terraform, CloudFormation, Kubernetes ve daha fazlasını analiz eder. (açık kaynak ücretsiz)
* [CodeBeat](https://codebeat.co) — Birçok dil için Otomatik Kod İnceleme Platformu. Slack ve e-posta entegrasyonu ile herkese açık depolar için sonsuza kadar ücretsiz.
* [codeclimate.com](https://codeclimate.com/) — Otomatik kod incelemesi, Açık Kaynak ve sınırsız organizasyona ait özel depolar (en fazla 4 işbirlikçi) için ücretsiz. Ayrıca öğrenciler ve kurumlar için de ücretsiz.
* [codecov.io](https://codecov.io/) — Kod kapsamı aracı (SaaS), Açık Kaynak ve bir ücretsiz özel depo için ücretsiz
* [CodeFactor](https://www.codefactor.io) — Git için Otomatik Kod İnceleme. Ücretsiz sürümde sınırsız kullanıcı, herkese açık depolar ve bir özel depo bulunur.
* [coderabbit.ai](https://coderabbit.ai) — GitHub/GitLab ile entegre olan yapay zeka destekli kod inceleme aracı. Ücretsiz katman; saatte 200 dosya, 3 inceleme ve 50 sohbet içerir. Açık kaynak projeler için sonsuza kadar ücretsizdir.
* [codescene.io](https://codescene.io/) - CodeScene, teknik borcu geliştiricilerin kod ile nasıl çalıştığına göre önceliklendirir ve organizasyonel faktörleri (ekip etkileşimi, sistem ustalığı gibi) görselleştirir. Açık Kaynak için ücretsizdir.
* [CodSpeed](https://codspeed.io) - CI boru hatlarınızda performans izleme otomasyonu. Dağıtımdan önce performans gerilemelerini yakalayın; hassas ve tutarlı metrikler sunar. Açık Kaynak projeler için sonsuza kadar ücretsizdir.
* [coveralls.io](https://coveralls.io/) — Test kapsam raporlarını gösterir, Açık Kaynak için ücretsiz
* [dareboost](https://dareboost.com) - Web performansı, erişilebilirlik ve güvenlik için her ay 5 ücretsiz analiz raporu
* [deepcode.ai](https://www.deepcode.ai) — DeepCode, hataları, güvenlik açıklarını, performans ve API sorunlarını yapay zeka ile bulur. DeepCode’un analiz hızı, kodunuzu gerçek zamanlı analiz etmesine ve IDE’de kaydet tuşuna bastığınızda sonuçları sunmasına olanak tanır. Desteklenen diller: Java, C/C++, JavaScript, Python ve TypeScript. GitHub, BitBucket ve GitLab entegrasyonu. Açık kaynak ve özel depolar ile 30 geliştiriciye kadar ücretsizdir.
* [deepscan.io](https://deepscan.io) — JavaScript kodunda çalışma zamanlı hataları otomatik olarak bulan gelişmiş statik analiz, Açık Kaynak için ücretsiz
* [DeepSource](https://deepsource.io/) - DeepSource, kaynak kod değişikliklerini sürekli analiz eder, güvenlik, performans, anti-pattern, hata riski, dokümantasyon ve stil başlıklarında sorunları bulur ve düzeltir. GitHub, GitLab ve Bitbucket ile yerel entegrasyon.
* [DiffText](https://difftext.com) - İki kod bloğu arasındaki farkları anında bulun. Tamamen ücretsizdir.
* [eversql.com](https://www.eversql.com/) — EverSQL - Veritabanı optimizasyonu için 1 numaralı platform. Veritabanınız ve SQL sorgularınız hakkında kritik içgörüler otomatik olarak elde edilir.
* [gerrithub.io](https://review.gerrithub.io/) — GitHub depoları için ücretsiz Gerrit kod incelemesi
* [gocover.io](https://gocover.io/) — Herhangi bir [Go](https://golang.org/) paketi için kod kapsamı
* [goreportcard.com](https://goreportcard.com/) — Go projeleri için Kod Kalitesi, Açık Kaynak için ücretsiz
* [gtmetrix.com](https://gtmetrix.com/) — Web sitelerini optimize etmek için raporlar ve kapsamlı öneriler
* [holistic.dev](https://holistic.dev/) - PostgreSQL optimizasyonu için 1 numaralı statik kod analizörü. Performans, güvenlik ve mimari veritabanı sorunlarının otomatik tespiti hizmeti
* [houndci.com](https://houndci.com/) — Kod kalitesi hakkında GitHub commit’lerine yorum yapar, Açık Kaynak için ücretsiz
* [Moderne.io](https://app.moderne.io) — Otomatik kaynak kodu yeniden düzenleme. Moderne; framework geçişleri, iyileştirme ile kod analizi ve rakipsiz ölçekte kod dönüştürme sunar, böylece geliştiriciler zamanlarını eskiyi korumak yerine yeni şeyler inşa etmeye harcayabilir. Açık Kaynak için ücretsiz.
* [reviewable.io](https://reviewable.io/) — GitHub depoları için kod incelemesi, herkese açık veya kişisel depolar için ücretsiz.
* [parsers.dev](https://parsers.dev/) - Soyut sözdizimi ağacı ayrıştırıcıları ve ara temsil derleyicileri hizmet olarak
* [scan.coverity.com](https://scan.coverity.com/) — Java, C/C++, C# ve JavaScript için statik kod analizi, Açık Kaynak için ücretsiz
* [scrutinizer-ci.com](https://scrutinizer-ci.com/) — Sürekli inceleme platformu, Açık Kaynak için ücretsiz
* [semanticdiff.com](https://app.semanticdiff.com/) — Programlama dili farkında diff, GitHub pull request ve commit’leri için, herkese açık depolar için ücretsiz
* [shields.io](https://shields.io) — Açık kaynak projeleri için kalite meta veri rozetleri
* [sonarcloud.io](https://sonarcloud.io) — Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy ve daha birçok dil için otomatik kaynak kod analizi, Açık Kaynak için ücretsiz
* [SourceLevel](https://sourcelevel.io/) — Otomatik Kod İncelemesi ve Takım Analitiği. Açık Kaynak ve 5 işbirlikçiye kadar olan organizasyonlar için ücretsiz.
* [webceo.com](https://www.webceo.com/) — SEO araçları, ayrıca kod doğrulama ve farklı cihaz türleriyle test içerir
* [zoompf.com](https://zoompf.com/) — Web sitelerinizin performansını artırın, detaylı analiz

**[⬆️ Başa Dön](#table-of-contents)**

## Kod Arama ve Göz Atma

* [libraries.io](https://libraries.io/) — 32 farklı paket yöneticisi için arama ve bağımlılık güncelleme bildirimleri, açık kaynak için ücretsiz
* [Namae](https://namae.dev/) - Proje adınızın uygunluğunu GitHub, Gitlab, Heroku, Netlify ve daha birçok sitede arayın.
* [searchcode.com](https://searchcode.com/) — Metin tabanlı kapsamlı kod arama, Açık Kaynak için ücretsiz
* [tickgit.com](https://www.tickgit.com/) — `TODO` yorumlarını (ve diğer işaretçileri) öne çıkarır, geliştirme için geri dönülmesi gereken kod bölümlerini belirler.
* [CodeKeep](https://codekeep.io) - Kod Snippet’leri için Google Keep. Kod snippet’lerinizi düzenleyin, keşfedin ve paylaşın; önceden ayarlı şablonlarla güçlü bir kod ekran görüntüsü aracı ve bağlantı özelliği içerir.

**[⬆️ Başa Dön](#table-of-contents)**

## CI ve CD

* [AccessLint](https://github.com/marketplace/accesslint) — AccessLint, otomatik web erişilebilirlik testlerini geliştirme akışınıza getirir. Açık kaynak ve eğitim amaçlı ücretsizdir.
* [appcircle.io](https://appcircle.io) — Mobil uygulamalar için kurumsal seviye DevOps platformu; uygulama oluşturma, test ve mağaza yayını otomasyonunu hızlandırır. Her bir derleme için en fazla 30 dakika, ayda 20 derleme ve 1 eşzamanlı derleme ile ücretsizdir.
* [appveyor.com](https://www.appveyor.com/) — Windows için CD servisi, Açık Kaynak için ücretsiz
* [LocalOps](https://localops.co/) - Uygulamanızı AWS/GCP/Azure’da 30 dakikadan kısa sürede dağıtın. Her bulutta standart uygulama ortamları oluşturun, sürekli dağıtım otomasyonu ve gelişmiş gözlemlenebilirlik ile gelir. Ücretsiz plan 1 kullanıcı ve 1 uygulama ortamı içerir.
* [Argonaut](https://argonaut.dev/) - Uygulamaları ve altyapıyı bulutunuzda dakikalar içinde dağıtın. Kubernetes ve Lambda ortamlarında özel ve üçüncü taraf uygulama dağıtımlarını destekler. Ücretsiz katmanda 5 alan adı ve 2 kullanıcı için sınırsız uygulama ve dağıtım hakkı.
* [bitrise.io](https://www.bitrise.io/) — Yerel veya hibrit mobil uygulamalar için CI/CD. 200 ücretsiz derleme/ay, 10 dakika derleme süresi ve iki takım üyesi. OSS projeleri için 45 dakika derleme süresi, +1 eşzamanlılık ve sınırsız takım büyüklüğü.
* [buddy.works](https://buddy.works/) — 5 ücretsiz proje ve bir eşzamanlı çalıştırma (ayda 120 işlem)
* [Buildkite](https://buildkite.com) CI Pipelines, 3 kullanıcı ve ayda 5k iş dakikası için ücretsizdir. Test Analytics ücretsiz geliştirici katmanında ayda 100k test çalıştırması, açık kaynak projeleri için ek ücretsiz haklar.
* [bytebase.com](https://www.bytebase.com/) — Veritabanı CI/CD ve DevOps. 20 kullanıcı ve on veritabanı örneğine kadar ücretsiz
* [CircleCI](https://circleci.com/) — GitHub, GitLab ve BitBucket depoları için tüm özelliklerin dahil olduğu kapsamlı ücretsiz katmanlı barındırılan CI/CD servisi. Birden fazla kaynak sınıfı, Docker, Windows, Mac OS, ARM yürütücüleri, yerel çalıştırıcılar, test bölme, Docker Katman Önbellekleme ve diğer gelişmiş CI/CD özellikleri. Ayda 6000 dakika yürütme süresi, sınırsız işbirlikçi, özel projelerde 30 paralel iş ve Açık Kaynak projelerde 80.000 ücretsiz derleme dakikası.
* [cirrus-ci.org](https://cirrus-ci.org) - Herkese açık GitHub depoları için ücretsiz
* [cirun.io](https://cirun.io) - Herkese açık GitHub depoları için ücretsiz
* [codefresh.io](https://codefresh.io) — Ömür Boyu Ücretsiz plan: 1 derleme, bir ortam, paylaşımlı sunucular, sınırsız herkese açık depo
* [codemagic.io](https://codemagic.io/) - Ayda 500 ücretsiz derleme dakikası
* [codeship.com](https://codeship.com/) — Aylık 100 özel derleme, beş özel proje, Açık Kaynak için sınırsız
* [deploybot.com](https://www.deploybot.com/) — 1 depo ve on dağıtım ile Açık Kaynak için ücretsiz
* [deployhq.com](https://www.deployhq.com/) — 1 proje ve günde on dağıtım (ayda 30 derleme dakikası)
* [drone](https://cloud.drone.io/) - Drone Cloud, geliştiricilerin x86 ve Arm (hem 32 hem 64 bit) dahil birden fazla mimaride Sürekli Dağıtım boru hatları çalıştırmasına olanak tanır
* [LayerCI](https://layerci.com) — Tam yığın projeler için CI. 5GB bellek ve 3 CPU ile bir tam yığın önizleme ortamı.
* [semaphoreci.com](https://semaphoreci.com/) — Açık Kaynak için ücretsiz, ayda 100 özel derleme
* [Squash Labs](https://www.squash.io/) — Her dal için bir VM oluşturur ve uygulamanızı benzersiz bir URL’den erişilebilir kılar. Sınırsız herkese açık & özel depo, 2 GB’a kadar VM Boyutu.
* [styleci.io](https://styleci.io/) — Sadece herkese açık GitHub depoları
* [Mergify](https://mergify.io) — GitHub için iş akışı otomasyonu ve birleştirme kuyruğu — Herkese açık GitHub depoları için ücretsiz
* [Make](https://www.make.com/en) — Uygulamaları bağlayıp UI ile iş akışlarını otomatikleştiren iş akışı otomasyon aracı. Birçok uygulama ve popüler API’yi destekler. Herkese açık GitHub depoları için ve 100 Mb, 1000 Operasyon, 15 dakika minimum aralık içeren ücretsiz katmanı vardır.
* [Spacelift](https://spacelift.io/) - Infrastructure as Code için yönetim platformu. Ücretsiz plan özellikleri: IaC işbirliği, Terraform modül kaydı, ChatOps entegrasyonu, Open Policy Agent ile sürekli kaynak uyumluluğu, SAML 2.0 ile SSO ve herkese açık çalışan havuzlarına erişim: ayda 200 dakikaya kadar
* [microtica.com](https://microtica.com/) - Hazır altyapı bileşenleriyle başlangıç ortamları, AWS’de uygulama dağıtımı ve üretim iş yüklerinizi destekleyin. Ücretsiz katman; 1 Ortam (kendi AWS hesabınızda), 2 Kubernetes Servisi, ayda 100 derleme dakikası ve 20 aylık dağıtım içerir.
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud, uzak önbellekleme, görevlerin makineler arasında dağıtılması ve hatta e2e test çalıştırmalarınızın otomatik olarak bölünmesi gibi özelliklerle CI üzerindeki monorepolarınızı hızlandırır. 30 katkı sağlayıcıya kadar ücretsiz bir plan sunar ve cömertçe 150.000 kredi içerir.
* [blacksmith](https://www.blacksmith.sh/) - GitHub Actions için yönetilen performans koşucuları, aylık 3.000 ücretsiz dakika sağlar, kredi kartı gerekmez.
* [Terramate](https://terramate.io/) - Terramate, Terraform, OpenTofu ve Terragrunt gibi Kod Olarak Altyapı (IaC) araçları için bir orkestrasyon ve yönetim platformudur. Tüm özellikler dahil olmak üzere 2 kullanıcıya kadar ücretsizdir.
* [Terrateam](https://terrateam.io) - GitOps-öncelikli Terraform otomasyonu, pull request odaklı iş akışları, kendi barındırılan koşucular ile proje izolasyonu ve sıralı işlemler için katmanlı çalıştırmalar. 3 kullanıcıya kadar ücretsizdir.

**[⬆️ Başa Dön](#table-of-contents)**

## Test

* [Applitools.com](https://applitools.com/) — Web, yerel mobil ve masaüstü uygulamalar için akıllı görsel doğrulama. Neredeyse tüm otomasyon çözümleri (Selenium ve Karma gibi) ve uzaktan koşucular (Sauce Labs, Browser Stack) ile entegre olur. Açık kaynak için ücretsizdir. Haftalık sınırlı checkpoint ile tek kullanıcı için ücretsiz katman.
* [Appetize](https://appetize.io) — Android ve iOS uygulamalarınızı bulut tabanlı Android telefon/tablet emülatöründe ve iPhone/iPad simülatörlerinde doğrudan tarayıcınızda test edin. Ücretsiz katman, aylık 30 dakika kullanım ile iki eşzamanlı oturum içerir. Uygulama boyutunda sınır yoktur.
* [Apptim](https://apptim.com) — Performans mühendisliği bilgisi olmayan kişilerin bir uygulamanın performansını ve kullanıcı deneyimini (UX) değerlendirmesini sağlayan bir mobil test aracı. Kendi cihazınızı kullanan masaüstü sürümü %100 ÜCRETSİZDİR, hem iOS hem de Android’de sınırsız test sağlar.
* [Argos](https://argos-ci.com) - Geliştiriciler için Açık Kaynak görsel test platformu. Sınırsız proje, ayda 5.000 ekran görüntüsü. Açık kaynak projeler için ücretsizdir.
* [Bencher](https://bencher.dev/) - CI performans gerilemelerini yakalamak için sürekli kıyaslama araç takımı. Tüm herkese açık projeler için ücretsizdir.
* [browserstack.com](https://www.browserstack.com/) — Manuel ve otomatik tarayıcı testi, [Açık Kaynak için ücretsiz](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - Web uygulamaları için hafif test otomasyon aracı. Öğrenmesi kolaydır ve kodlama gerektirmez. Kendi bilgisayarınızda sınırsız test çalıştırabilirsiniz. Ayrıca bulut izleme ve CI/CD entegrasyonu ek aylık ücretle sunulur.
* [Checkly](https://checklyhq.com) - Modern DevOps için kod-öncelikli sentetik izleme. API ve uygulamalarınızı eski sağlayıcılara göre çok daha uygun fiyata izleyin. Monitoring as Code iş akışı ve Playwright ile desteklenir. Geliştiriciler için cömert ücretsiz katman.
* [checkbot.io](https://www.checkbot.io/) — Web sitenizin 50+ SEO, hız ve güvenlik en iyi uygulamalarına uyup uymadığını test eden tarayıcı eklentisi. Küçük siteler için ücretsiz katman.
* [CORS-Tester](https://cors-error.dev/cors-tester/) - Geliştiriciler ve API testçileri için, belirli bir alan adı için bir API'nin CORS etkin olup olmadığını kontrol etmek ve eksiklikleri belirlemek için ücretsiz bir araç. Eyleme dönüştürülebilir analizler alın.
* [cypress.io](https://www.cypress.io/) - Tarayıcıda çalışan her şey için hızlı, kolay ve güvenilir test. Cypress Test Runner her zaman ücretsiz ve açık kaynaktır, kısıtlama ve sınırlama yoktur. Cypress Dashboard açık kaynak projeleri için 5 kullanıcıya kadar ücretsizdir.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - Tarayıcınızda yapay zeka destekli Cypress Testleri/POM modelleri oluşturun. AI kısmı hariç açık kaynak. Kendi kendini iyileştiren betikler, E-posta ve Görsel test ile ayda beş test oluşturma ücretsizdir.
* [everystep-automation.com](https://www.everystep-automation.com/) — Web tarayıcısında yapılan tüm adımları kaydeder, tekrar oynatır ve betikler oluşturur, ücretsiz olarak daha az seçenekle birlikte gelir.
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Gremlin’in Kaos Mühendisliği araçları, sistemlerinize güvenli ve emniyetli bir şekilde hata enjekte etmenize ve müşteri odaklı sorunlar oluşmadan önce zayıf noktaları bulmanıza olanak tanır. Gremlin Free, 5 ana bilgisayar veya konteynerde Kapatma ve CPU saldırılarına erişim sağlar.
* [gridlastic.com](https://www.gridlastic.com/) — Selenium Grid testi için ücretsiz plan: 4 eşzamanlı selenium düğümü/10 grid başlatma/ayda 4.000 test dakikası.
* [katalon.com](https://katalon.com) - Her büyüklükteki ve farklı test olgunluğundaki ekipler için yardımcı olabilecek test platformu; Katalon Studio, TestOps (+ Görsel Test ücretsiz), TestCloud ve Katalon Recorder içerir.
* [Keploy](https://keploy.io/) - Keploy, geliştiriciler için fonksiyonel test araç setidir. API çağrılarını kaydederek API'ler (KTests) için Uçtan Uca testler ve mock veya stublar (KMocks) oluşturur. Açık Kaynak projeleri için ücretsizdir.
* [knapsackpro.com](https://knapsackpro.com) - Testlerinizi, herhangi bir CI sağlayıcıda optimum test paketi paralelleştirmesi ile hızlandırın. Ruby, JavaScript testlerini paralel CI düğümlerinde bölerek zamandan tasarruf edin. 10 dakikaya kadar test dosyası için ücretsiz plan, Açık Kaynak projeler için sınırsız ücretsiz plan.
* [lambdatest.com](https://www.lambdatest.com/) — Manuel, görsel, ekran görüntüsü ve otomatik tarayıcı testi, selenium ve cypress üzerinde, [Açık Kaynak için ücretsiz](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - Ağ trafiğini analiz ederek otomatik olarak API ve yük testleri oluşturur. Aylık 50 eşzamanlı kullanıcıya kadar 60 dakikaya kadar ücretsiz simülasyon.
* [lost-pixel.com](https://lost-pixel.com) - Storybook, Ladle, Histoire hikayeleri ve Web Uygulamaları için bütünsel görsel regresyon testi. Sınırsız ekip üyesi, açık kaynak için tamamen ücretsiz, ayda 7.000 snapshot.
* [octomind.dev](https://www.octomind.dev/) - AI destekli test vaka üretimiyle otomatik oluşturulan, çalıştırılan ve bakımı yapılan Playwright UI testleri.
* [percy.io](https://percy.io) - Herhangi bir web uygulamasına, statik siteye, stil rehberine veya bileşen kütüphanesine görsel test ekleyin. Sınırsız ekip üyesi, Demo uygulama ve sınırsız proje, ayda 5.000 snapshot.
* [preflight.com](https://preflight.com) - Kod gerektirmeyen otomatik web testi. Tarayıcınızda UI değişikliklerine dayanıklı testler kaydedin ve bunları Windows makinelerinde çalıştırın. CI/CD ile entegre edilebilir. Ücretsiz plan, 50 aylık test çalıştırması, video, HTML oturumları ve daha fazlasını içerir.
* [qase.io](https://qase.io) - Geliştirici ve QA ekipleri için test yönetim sistemi. Test vakalarını yönetin, test çalıştırmaları oluşturun, testleri gerçekleştirin, hataları izleyin ve etkiyi ölçün. Ücretsiz katman, tüm temel özellikleri, ekler için 500MB ve 3 kullanıcıya kadar destekler.
* [Repeato](https://repeato.app/) Kod gerektirmeyen, bilgisayarla görme ve yapay zeka tabanlı mobil uygulama test otomasyon aracı. Native uygulamalar, flutter, react-native, web, ionic ve çok daha fazla framework ile çalışır. Ücretsiz plan, iOS için 10 ve Android için 10 test ile sınırlıdır ancak ücretli planların çoğu özelliğini, sınırsız test çalıştırma dahil, içerir.
* [Requestly](https://requestly.com/) Açık kaynak Chrome Eklentisi ile HTTP İsteklerini Yakalayın, Yönlendirin ve Mock edin. [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) ve [Session Recording](https://requestly.com/products/session-book/) özellikleriyle birlikte gelir. URL’leri yönlendirin, HTTP Başlıklarını değiştirin, API’leri Mock edin, özel JS enjekte edin, GraphQL İsteklerini değiştirin, Mock API uç noktaları oluşturun, Network & Console Logları ile oturum kaydedin. Ücretsiz katmanda 10 kurala kadar oluşturabilirsiniz. Açık kaynak için ücretsizdir.
* [seotest.me](https://seotest.me/) — Ücretsiz sayfa içi SEO web sitesi test aracı. Günde 10 ücretsiz site taraması. Teknolojiden bağımsız olarak herhangi bir web sitesi için faydalı SEO öğrenme kaynakları ve iyileştirme önerileri sunar.
* [snippets.uilicious.com](https://snippets.uilicious.com) - CodePen gibi ama çapraz tarayıcı testi için. UI-licious, kullanıcı hikayeleri gibi testler yazmanıza olanak tanır ve UI-licious Snippets adında ücretsiz bir platform sunar – Chrome’da sınırsız test çalıştırma, oturum başına 3 dakikaya kadar ve kayıt gerektirmez. Bir hata mı buldunuz? Testinizin benzersiz URL’sini kopyalayıp geliştiricilerinize sorunu birebir gösterebilirsiniz.
* [TestCollab](https://testcollab.com) - Kullanıcı dostu test yönetim yazılımı, ücretsiz planında Jira entegrasyonu, sınırsız proje, CSV/XLSx ile test vakası içe aktarma, zaman takibi ve 1 GB dosya depolama vardır.
* [testingbot.com](https://testingbot.com/) — Selenium Tarayıcı ve Cihaz Testi, [Açık Kaynak için ücretsiz](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - Otomatik test sonuçlarını yayınlamak için bir panel ve GitHub kullanarak kod olarak manuel testleri uygulamak için bir çerçeve. Hizmet, [Açık Kaynak için ücretsizdir](https://github.com/marketplace/testspace-com) ve ayda 450 sonuç içerir.
* [tesults.com](https://www.tesults.com) — Test sonuç raporlama ve test vakası yönetimi. Popüler test çerçeveleri ile entegre olur. Açık kaynak yazılım geliştiriciler, bireysel kullanıcılar, eğitimciler ve yeni başlayan küçük ekipler temel ücretsiz projelerin ötesinde indirimli ve ücretsiz imkanlar talep edebilirler.
* [UseWebhook.com](https://usewebhook.com) - Webhook’ları tarayıcınızdan yakalayın ve inceleyin. Localhost’a iletin veya geçmişten tekrar oynatın. Kullanımı ücretsizdir.
* [Vaadin](https://vaadin.com) — Java veya TypeScript ile ölçeklenebilir UI’lar inşa edin, entegre araçlar, bileşenler ve tasarım sistemi ile daha hızlı yineleyin, daha iyi tasarlayın ve geliştirme sürecini basitleştirin. Sınırsız Proje ve beş yıl ücretsiz bakım.
* [websitepulse.com](https://www.websitepulse.com/tools/) — Çeşitli ücretsiz ağ ve sunucu araçları.
* [webhook-test.com](https://webhook-test.com) - Entegrasyon sırasında benzersiz bir URL ile webhook ve HTTP isteklerini hata ayıklayın ve inceleyin. Tamamen ücretsizdir, sınırsız URL oluşturabilir ve öneriler alabilirsiniz.
* [webhook.site](https://webhook.site) - Webhook’ları, giden HTTP isteklerini veya e-postaları özel bir URL ile doğrulayın. Geçici URL ve e-posta adresi her zaman ücretsizdir.
* [webhookbeam.com](https://webhookbeam.com) - Webhook’lar kurun ve bunları push bildirimleri ve e-posta ile izleyin.

**[⬆️ Başa Dön](#table-of-contents)**

## Güvenlik ve PKI

* [aikido.dev](https://www.aikido.dev) — SCA, SAST, CSPM, DAST, Secrets, IaC, Malware, Container tarama, EOL gibi tümleşik appsec platformu. Ücretsiz plan iki kullanıcı, 10 depo, 1 bulut, 2 konteyner ve 1 alan adı taramasını içerir.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — Ağınızda ele geçirilmiş sistemleri ortaya çıkarır.
* [Altcha.org](https://altcha.org/anti-spam) - Doğal dil işleme ve makine öğrenimiyle desteklenen web siteleri ve API’ler için Spam Filtresi. Ücretsiz plan, alan adı başına günde 200 istek içerir.
* [atomist.com](https://atomist.com/) — Çeşitli geliştirme görevlerini otomatikleştirmenin daha hızlı ve pratik bir yolu. Şu anda beta sürümünde.
* [cloudsploit.com](https://cloudsploit.com/) — Amazon Web Services (AWS) için güvenlik ve uyumluluk denetimi ve izleme.
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — Kamu bulut altyapılarını hedef alan yüksek güvenilirlikli Tehdit Göstergeleri (IOC), bir bölümü github’da mevcut (https://github.com/unknownhad/AWSAttacks). Tüm liste API üzerinden sunulmaktadır.
* [CodeNotary.io](https://www.codenotary.io/) — Kod, dosya, klasör veya konteynerleri noterize etmek için silinemez kanıt sunan Açık Kaynak platform.
* [crypteron.com](https://www.crypteron.com/) — .NET ve Java uygulamalarında veri ihlallerini önleyen bulut-öncelikli, geliştirici dostu güvenlik platformu.
* [CyberChef](https://gchq.github.io/CyberChef/) — Karmaşık araçlar veya programlama dilleriyle uğraşmadan veri analizi ve kodlama/şifreleme için sezgisel bir web uygulaması. Kriptografi & şifrelemenin İsviçre çakısı gibi. Tüm özellikler sınırsız ve ücretsizdir. İsterseniz açık kaynak kodlu, kendi sunucunuzda barındırabilirsiniz.
* [DAS](https://signup.styra.com/) — Styra DAS Free, Open Policy Agent (OPA) yetkilendirmesi için tam yaşam döngüsü politika yönetimi.
* [Datree](https://www.datree.io/) — Kubernetes yanlış yapılandırmalarını önlemek için Açık Kaynak CLI aracı, manifestlerin ve Helm chart’larının en iyi uygulamalara ve şirket politikalarınıza uygunluğunu kontrol eder.
* [Dependabot](https://dependabot.com/) Ruby, JavaScript, Python, PHP, Elixir, Rust, Java (Maven ve Gradle), .NET, Go, Elm, Docker, Terraform, Git Submodules ve GitHub Actions için otomatik bağımlılık güncellemeleri.
* [DJ Checkup](https://djcheckup.com) — Django sitenizi güvenlik açıklarına karşı tarayan ücretsiz otomatik kontrol aracı. Pony Checkup sitesinden çatallanmıştır.
* [Doppler](https://doppler.com/) — Uygulama sırları ve konfigürasyonları için Evrensel Secret Yöneticisi, çeşitli bulut sağlayıcılarına senkronizasyon desteği ile. Temel erişim kontrolleriyle beş kullanıcıya kadar ücretsizdir.
* [Dotenv](https://dotenv.org/) — .env dosyalarınızı hızlı ve güvenli bir şekilde senkronize edin. .env dosyalarınızı Slack veya e-posta gibi güvensiz kanallarda paylaşmayı bırakın ve önemli bir .env dosyasını asla kaybetmeyin. 3 ekip üyesine kadar ücretsizdir.
* [GitGuardian](https://www.gitguardian.com) — Otomatik secret tespiti ve iyileştirme ile secret’larınızı kaynak kodunuzdan uzak tutun. Git depolarınızı 350’den fazla secret ve hassas dosya türüne karşı tarayın – Bireyler ve 25 geliştiriciye kadar ekipler için ücretsizdir.
* [Have I been pwned?](https://haveibeenpwned.com) — İhlaller hakkında bilgi almak için REST API.
* [hostedscan.com](https://hostedscan.com) — Web uygulamaları, sunucular ve ağlar için çevrimiçi zafiyet tarayıcısı. Aylık 10 ücretsiz tarama.
* [Infisical](https://infisical.com/) — Tüm ekibiniz ve altyapınızda geliştirici sırlarını yönetmenizi sağlayan açık kaynak platform: yerelden üretime ve 3. parti servislerine kadar. 5 geliştiriciye kadar ücretsizdir.
* [Internet.nl](https://internet.nl) — IPv6, DNSSEC, HTTPS, DMARC, STARTTLS ve DANE gibi modern İnternet Standartları için test.
* [keychest.net](https://keychest.net) - Entegre CT veritabanı ile SSL süresi yönetimi ve sertifika satın alma.
* [letsencrypt.org](https://letsencrypt.org/) — Tüm büyük tarayıcılar tarafından güvenilen ücretsiz SSL Sertifika Otoritesi.
* [meterian.io](https://www.meterian.io/) - Java, Javascript, .NET, Scala, Ruby ve NodeJS projelerindeki bağımlılık güvenlik açıklarını izleyin. Bir özel proje için ücretsiz, açık kaynak projelerde sınırsız.
* [Mozilla Observatory](https://observatory.mozilla.org/) — Sitenizdeki güvenlik açıklarını bulun ve düzeltin.
* [opswat.com](https://www.opswat.com/) — Bilgisayar, cihaz, uygulama, yapılandırma Güvenlik İzleme, 25 kullanıcı ve 30 gün geçmiş ile ücretsiz.
* [openapi.security](https://openapi.security/) - Herhangi bir OpenAPI / Swagger tabanlı API’nin güvenliğini hızlıca kontrol etmek için ücretsiz araç. Kayıt olmanıza gerek yok.
* [pixee.ai](https://pixee.ai) - Java kod tabanınıza otomatik olarak güvenlik açıklarını çözmek için ücretsiz GitHub botu olarak Otomatik Ürün Güvenlik Mühendisi. Yakında diğer diller de eklenecek!
* [pyup.io](https://pyup.io) — Python bağımlılıklarını güvenlik açıklarına karşı izler ve otomatik olarak günceller. Bir özel proje için ücretsiz, açık kaynakta sınırsız.
* [qualys.com](https://www.qualys.com/community-edition) — Web uygulaması zafiyetlerini bulun, OWASP Riskleri için denetim yapın.
* [report-uri.io](https://report-uri.io/) — CSP ve HPKP ihlal raporlama.
* [ringcaptcha.com](https://ringcaptcha.com/) — Kimlik olarak telefon numarasını kullanmak için araçlar, ücretsiz olarak mevcuttur.
* [seclookup.com](https://www.seclookup.com/) - Seclookup API’leri, SIEM’de domain tehdit göstergelerini zenginleştirebilir, alan adları hakkında kapsamlı bilgi sağlayabilir ve tehdit tespiti & müdahaleyi geliştirebilir. [Buradan](https://account.seclookup.com/) 50K ücretsiz sorgu alın.
* [snyk.io](https://snyk.io) — Açık kaynak bağımlılıklarınızda bilinen güvenlik açıklarını bulur ve düzeltir. Açık kaynak projelerde sınırsız test ve iyileştirme. Özel projelerinizde aylık 200 test ile sınırlı.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — Herhangi bir SSL web sunucusunun yapılandırmasının kapsamlı analizi.
* [SOOS](https://soos.io) - Açık kaynak projeleri için ücretsiz, sınırsız SCA taraması. Yayın öncesi güvenlik tehditlerini tespit edin ve düzeltin. Basit ve etkili çözüm ile projelerinizi koruyun.
* [StackHawk](https://www.stackhawk.com/) Uygulama taramasını tüm pipeline boyunca otomatikleştirerek üretime çıkmadan önce güvenlik hatalarını bulun ve düzeltin. Tek uygulama için sınırsız tarama ve ortam.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - Ücretsiz web sitesi güvenlik kontrolü ve kötü amaçlı yazılım tarayıcı.
* [Protectumus](https://protectumus.com) - Ücretsiz web sitesi güvenlik kontrolü, site antivirüsü ve PHP için sunucu güvenlik duvarı (WAF). Ücretsiz katmanda kayıtlı kullanıcılar için e-posta bildirimleri.
* [TestTLS.com](https://testtls.com) - Bir SSL/TLS servisini güvenli sunucu yapılandırması, sertifikalar, zincirler vb. açısından test edin. Sadece HTTPS ile sınırlı değildir.
* [threatconnect.com](https://threatconnect.com) — Tehdit istihbaratı: Bireysel araştırmacılar, analistler ve siber tehdit istihbaratını öğrenmeye başlayan kuruluşlar için tasarlanmıştır. 3 kullanıcıya kadar ücretsiz.
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — Otomatik zafiyet taraması. Ücretsiz plan haftalık XSS taraması sağlar.
* [Ubiq Security](https://ubiqsecurity.com/) — Otomatik anahtar yönetimiyle üç satır kod ile veriyi şifreleyin ve çözün. Bir uygulama ve ayda 1.000.000 şifreleme için ücretsizdir.
* [Virgil Security](https://virgilsecurity.com/) — Uçtan uca şifreleme, veritabanı koruması, IoT güvenliği ve daha fazlası için araç ve servisler. 250 kullanıcıya kadar uygulamalar için ücretsizdir.
* [Vulert](https://vulert.com) - Vulert, açık kaynak bağımlılıklarınızı sürekli olarak yeni güvenlik açıkları için izler, düzeltme önerir, kurulum veya kod tabanınıza erişim gerektirmez. Açık kaynak projeler için ücretsizdir.
* [Escape GraphQL Quickscan](https://escape.tech/) - GraphQL uç noktalarınızı tek tıkla güvenlik taraması. Ücretsiz, giriş yapmanıza gerek yok.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - Açık GitHub depoları, gists, issues ve yorumlarda 20 milyon sızdırılmış secret arasında ücretsiz arama yapın.
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - Private Key & CSR Üreticisi, SSL Sertifika Çözücü, Sertifika Eşleştirici ve SSL Sertifika Siparişi gibi çeşitli özellikler sunan Tümleşik SSL Araç Takımı. Kullanıcıların Let's Encrypt, Google Trust ve BuyPass'tan TXT yerine CNAME Kaydı ile ücretsiz SSL sertifikası üretmelerini sağlar.
**[⬆️ Başa Dön](#table-of-contents)**

## Kimlik Doğrulama, Yetkilendirme ve Kullanıcı Yönetimi

  * [Aserto](https://www.aserto.com) - Uygulamalar ve API'ler için ayrıntılı yetkilendirme hizmeti. 1000 MAU ve 100 yetkilendirici instance'a kadar ücretsiz.
  * [asgardeo.io](https://wso2.com/asgardeo) - SSO, MFA, şifresiz kimlik doğrulama ve daha fazlasının sorunsuz entegrasyonu. Ön ve arka uç uygulamaları için SDK'lar içerir. 1000 MAU ve beş kimlik sağlayıcıya kadar ücretsiz.
  * [Auth0](https://auth0.com/) — Barındırılan SSO. Ücretsiz planda 25.000 MAU, sınırsız Sosyal Bağlantı, özel alan adı ve daha fazlası bulunur.
  * [Authgear](https://www.authgear.com) - Şifresiz, OTP, 2FA, SSO'yu dakikalar içinde uygulamalarınıza entegre edin. Tüm ön uç dahil. 5000 MAU'ya kadar ücretsiz.
  * [Authress](https://authress.io/) — Kimlik doğrulama girişi ve erişim kontrolü, herhangi bir proje için sınırsız kimlik sağlayıcı. Facebook, Google, Twitter ve daha fazlası. İlk 1000 API çağrısı ücretsiz.
  * [Authy](https://authy.com) - Birden fazla cihazda yedeklemeli iki faktörlü kimlik doğrulama (2FA). Google Authenticator için kolay bir alternatif. 100 başarılı kimlik doğrulamaya kadar ücretsiz.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - Erişim politikalarını hazırlama, test etme ve dağıtma için eksiksiz bir yetkilendirme yönetim sistemi. Ayrıntılı yetkilendirme ve erişim kontrolü, aylık 100 aktif ilkeye kadar ücretsiz.
  * [Clerk](https://clerk.com) — Kullanıcı yönetimi, kimlik doğrulama, 2FA/MFA, oturum açma, kayıt olma, kullanıcı profilleri için önceden hazırlanmış UI bileşenleri ve daha fazlası. 10.000 aylık aktif kullanıcıya kadar ücretsiz.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Hizmet olarak Keycloak Kimlik ve Erişim Yönetimi. 100 kullanıcı ve bir realm'e kadar ücretsiz.
  * [Corbado](https://www.corbado.com/) — Yeni veya mevcut uygulamalara passkey-first kimlik doğrulama ekleyin. Sınırsız MAU için ücretsiz.
  * [Descope](https://www.descope.com/) — Oldukça özelleştirilebilir AuthN akışları, hem kodsuz hem de API/SDK yaklaşımı. Ayda 7.500 aktif kullanıcı, 50 tenant (5'e kadar SAML/SSO tenant) ücretsiz.
  * [duo.com](https://duo.com/) — Web sitesi veya uygulama için iki faktörlü kimlik doğrulama (2FA). On kullanıcıya, tüm kimlik doğrulama yöntemlerine, sınırsız entegrasyona ve donanım anahtarlarına kadar ücretsiz.
  * [Kinde](https://kinde.com/) - Ürününüzle dakikalar içinde entegre edebileceğiniz basit ve sağlam kimlik doğrulama. 7.500 ücretsiz MAU ile başlamak için ihtiyacınız olan her şey.
  * [logintc.com](https://www.logintc.com/) — Push bildirimleriyle iki faktörlü kimlik doğrulama (2FA), on kullanıcıya, VPN, web siteleri ve SSH için ücretsiz
  * [MojoAuth](https://mojoauth.com/) - MojoAuth, şifresiz kimlik doğrulamayı web, mobil veya herhangi bir uygulamanıza dakikalar içinde entegre etmeyi kolaylaştırır.
  * [Okta](https://developer.okta.com/signup/) — Kullanıcı yönetimi, kimlik doğrulama ve yetkilendirme. 100 aylık aktif kullanıcıya kadar ücretsiz.
  * [onelogin.com](https://www.onelogin.com/) — Hizmet olarak Kimlik (IDaaS), Tek Oturum Açma Kimlik Sağlayıcı, Bulut SSO IdP, üç şirket uygulaması ve beş kişisel uygulama, sınırsız kullanıcı
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/Zero Trust yönetimli güvenlik platformu. Tüm güvenlik özellikleriyle, sınırsız ekip üyesiyle, 200 günlük aktif kullanıcı ve ayda 25k izin kontrolü ile sonsuza kadar ücretsiz geliştirici hesabı.
  * [Permit.io](https://permit.io) - Gerçek zamanlı güncellemeler ve kodsuz politika UI'siyle RBAC, ABAC ve ReBAC etkinleştiren yetkilendirme-hizmet-olarak platformu. 1000 aylık aktif kullanıcıya kadar ücretsiz katman.
  * [Phase Two](https://phasetwo.io) - Keycloak Açık Kaynak Kimlik ve Erişim Yönetimi. 1000 kullanıcıya kadar ücretsiz realm, 10'a kadar SSO bağlantısı, Phase Two'nun geliştirilmiş Keycloak konteynerini ve [Organization](https://phasetwo.io/product/organizations/) eklentisini içerir.
  * [SSOJet](https://ssojet.com/) - Kimlik doğrulamanızı yeniden inşa etmeden Kurumsal SSO ekleyin. Ücretsiz planda sınırsız aylık aktif kullanıcı, sınırsız organizasyon, 2 SSO ve 2 SCIM bağlantısı bulunur.
  * [Stytch](https://www.stytch.com/) - Kimlik doğrulama ve dolandırıcılık önleme için API ve SDK sağlayan hepsi bir arada platform. Ücretsiz planda 10.000 aylık aktif kullanıcı, sınırsız organizasyon, 5 SSO veya SCIM bağlantısı ve 1.000 M2M token bulunur.
  * [Stack Auth](https://stack-auth.com) — Sorunsuz çalışan açık kaynak kimlik doğrulama. En geliştirici dostu çözüm, sadece beş dakikada başlatabilirsiniz. Ücretsiz self-host edilebilir veya 10k ücretsiz Aylık Aktif Kullanıcı ile yönetilen SaaS sürümü sunar.
  * [SuperTokens](https://supertokens.com/) - Uygulamanıza yerel olarak entegre edilen açık kaynak kullanıcı kimlik doğrulaması – hızlı başlamanızı sağlarken kullanıcı ve geliştirici deneyimini kontrol etmenizi sağlar. 5000 MAU'ya kadar ücretsiz.
  * [Warrant](https://warrant.dev/) — Uygulamalarınız için barındırılan kurumsal düzeyde yetkilendirme ve erişim kontrol servisi. Ücretsiz katmanda 1 milyon aylık API isteği ve 1.000 yetkilendirme kuralı bulunur.
  * [ZITADEL Cloud](https://zitadel.com) — Çalışmaya hazır kullanıcı ve erişim yönetimi, çoklu tenant (B2B) kullanım senaryolarını destekler. 25.000 kimlik doğrulamalı isteğe kadar tüm güvenlik özellikleriyle (OTP, Şifresiz, Politikalar vb. için ödeme duvarı yok) ücretsiz.
  * [PropelAuth](https://propelauth.com) — Sadece birkaç satır kodla her ölçekte şirkete hemen satış yapın, 200 kullanıcıya ve 10k İşlemsel E-posta'ya kadar ücretsiz (su damgalı marka: "Powered by PropelAuth").
  * [Logto](https://logto.io/) - Ürününüzün kullanıcı kimliklerini geliştirin, güvenliğini sağlayın ve yönetin – hem kimlik doğrulama hem de yetkilendirme için. 5.000 MAU'ya kadar ücretsiz ve açık kaynak self-host seçeneği mevcut.
  * [WorkOS](https://workos.com/) - 1 Milyon MAU'ya kadar ücretsiz kullanıcı yönetimi ve kimlik doğrulama. E-posta + şifre, sosyal kimlik doğrulama, Magic Auth, MFA ve daha fazlasını destekler.

**[⬆️ Başa Dön](#table-of-contents)**

## Mobil Uygulama Dağıtımı ve Geri Bildirim

  * [TestApp.io](https://testapp.io) - Mobil uygulamalarınızın düzgün çalışmasını sağlayan başvuru platformunuz. Ücretsiz plan: bir uygulama, analiz, sınırsız sürüm & kurulum ve geri bildirim toplama.
  * [Loadly](https://loadly.io) - iOS & Android beta uygulama dağıtım servisi tamamen ücretsiz, sınırsız indirme, yüksek hızlı indirme ve sınırsız yükleme sunar.
  * [Diawi](https://www.diawi.com) - iOS & Android uygulamalarını doğrudan cihazlara dağıtın. Ücretsiz plan: uygulama yükleme, şifre korumalı bağlantılar, 1 gün süre, on kurulum.
  * [InstallOnAir](https://www.installonair.com) - iOS & Android uygulamalarını havadan dağıtın. Ücretsiz plan: sınırsız yükleme, özel bağlantılar, misafirler için 2 gün, kayıtlı kullanıcılar için 60 gün süre.
  * [GetUpdraft](https://www.getupdraft.com) - Test için mobil uygulama dağıtımı. Ücretsiz planda bir uygulama projesi, üç uygulama sürümü, 500 MB depolama ve ayda 100 uygulama kurulumu bulunur.
  * [Appho.st](https://appho.st) - Mobil uygulama barındırma platformu. Ücretsiz planda beş uygulama, aylık 50 indirme ve maksimum 100 MB dosya boyutu bulunur.

**[⬆️ Başa Dön](#table-of-contents)**

## Yönetim Sistemi

  * [bitnami.com](https://bitnami.com/) — IaaS üzerinde hazır uygulama dağıtımı. 1 AWS micro instance yönetimi ücretsiz
  * [Esper](https://esper.io) — Android Cihazlar için MDM ve MAM ile DevOps. Bir kullanıcı lisansı ve 25 MB uygulama depolaması ile yüz cihaza kadar ücretsiz.
  * [jamf.com](https://www.jamf.com/) —  iPad, iPhone ve Mac'ler için cihaz yönetimi, üç cihaza kadar ücretsiz
  * [Miradore](https://miradore.com) — Cihaz Yönetim servisi. Cihaz filonuzu güncel tutun ve sınırsız cihazı ücretsiz olarak güvenceye alın. Ücretsiz planda temel özellikler bulunur.
  * [moss.sh](https://moss.sh) - Geliştiricilerin web uygulamalarını ve sunucularını dağıtmasına ve yönetmesine yardımcı olur. Ayda 25 git dağıtıma kadar ücretsiz
  * [runcloud.io](https://runcloud.io/) - Özellikle PHP projelerine odaklanan sunucu yönetimi. 1 sunucuya kadar ücretsiz.
  * [ploi.io](https://ploi.io/) - Sunucularınızı ve sitelerinizi kolayca yönetmek ve dağıtmak için sunucu yönetim aracı. Bir sunucuya kadar ücretsiz.
  * [xcloud.host](https://xcloud.host) — Kullanıcı dostu arayüze sahip sunucu yönetim ve dağıtım platformu. Bir sunucu için ücretsiz katman mevcut.
  * [serveravatar.com](https://serveravatar.com) — Otomatik yapılandırmalar ile PHP tabanlı web sunucularını yönetin ve izleyin. Bir sunucuya kadar ücretsiz.

**[⬆️ Başa Dön](#table-of-contents)**

## Mesajlaşma ve Streaming

  * [Ably](https://www.ably.com/) - Varlık, kalıcılık ve garantili teslimat ile gerçek zamanlı mesajlaşma servisi. Ücretsiz plan: ayda 3 milyon mesaj, 100 tepe bağlantı, 100 tepe kanal.
  * [cloudamqp.com](https://www.cloudamqp.com/) — Hizmet olarak RabbitMQ. Little Lemur planı: ayda 1 milyon mesaj, 20 eşzamanlı bağlantı, 100 kuyruk, 10.000 kuyrukta bekleyen mesaj, farklı AZ'lerde birden fazla node.
  * [courier.com](https://www.courier.com/) — Push, uygulama içi, e-posta, sohbet, SMS ve diğer mesajlaşma kanalları için tek API, şablon yönetimi ve diğer özellikler. Ücretsiz planda ayda 10.000 mesaj.
  * [engagespot.co](https://engagespot.co/) — Geliştiriciler için çok kanallı bildirim altyapısı, önceden hazırlanmış uygulama içi gelen kutusu ve kodsuz şablon editörü. Ücretsiz planda ayda 10.000 mesaj.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - MQTT cihazlarınızı Bulut Yerel IoT Mesajlaşma Broker'ına bağlayın. 100 cihaza kadar sonsuza kadar ücretsiz (kredi kartı gerekmez).
  * [knock.app](https://knock.app) – Geliştiriciler için bildirim altyapısı. Uygulama içi, e-posta, SMS, Slack ve push gibi birden fazla kanala tek API çağrısıyla gönderin. Ücretsiz planda ayda 10.000 mesaj.
  * [NotificationAPI.com](https://www.notificationapi.com/) — Herhangi bir yazılıma 5 dakikada kullanıcı bildirimi ekleyin. Ücretsiz planda ayda 10.000 bildirim + 100 SMS ve Otomatik Arama.
  * [Novu.co](https://novu.co) — Geliştiriciler için açık kaynak bildirim altyapısı. Tüm iletişim kanallarını bir arada yönetmek için basit bileşenler ve API'ler: E-posta, SMS, Doğrudan, Uygulama içi ve Push. Ücretsiz planda ayda 30.000 bildirim ve 90 gün saklama.
  * [pusher.com](https://pusher.com/) — Gerçek zamanlı mesajlaşma servisi. 100 eşzamanlı bağlantı ve günlük 200.000 mesaja kadar ücretsiz
  * [scaledrone.com](https://www.scaledrone.com/) — Gerçek zamanlı mesajlaşma servisi. 20 eşzamanlı bağlantı ve günlük 100.000 etkinliğe kadar ücretsiz
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) hizmet olarak. Global, AWS, GCP ve Azure. Sonsuza kadar ücretsiz: 4k mesaj boyutu, 50 aktif bağlantı ve ayda 5GB veri.
  * [pubnub.com](https://www.pubnub.com/) - Swift, Kotlin ve React mesajlaşması, her ay 1 milyon işlem. İşlemler birden fazla mesaj içerebilir.
  * [eyeson API](https://developers.eyeson.team/) - WebRTC (SFU, MCU) tabanlı video iletişim API servisiyle video platformları oluşturun. Gerçek zamanlı veri enjeksiyonu, video düzenleri, kayıtlar, tamamen özellikli barındırılan web UI (hızlı başlangıç) veya özel UI'lar için paketler içerir. [Geliştiriciler için ücretsiz katman](https://apiservice.eyeson.com/api-pricing), ayda 1000 toplantı dakikasıyla.
  * [webpushr](https://www.webpushr.com/) - Web Push Bildirimleri - 10k aboneye kadar ücretsiz, sınırsız push bildirimi, tarayıcı içi mesajlaşma
  * [httpSMS](https://httpsms.com) - Android telefonunuzu SMS Gateway olarak kullanarak metin mesajı gönderin ve alın. Aylık 200 mesaja kadar gönderme ve alma ücretsizdir.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - Saniyeler içinde elde edebileceğiniz ölçeklenebilir ve güvenli sunucusuz MQTT broker. Ayda 1M oturum dakikası sonsuza kadar ücretsiz (kredi kartı gerekmez).
  * [Pocket Alert](https://pocketalert.app) - iOS ve Android cihazlarınıza push bildirimi gönderin. API veya Webhooklar aracılığıyla kolayca entegre edin ve uyarılarınız üzerinde tam kontrol sağlayın. Ücretsiz plan: günde 50 mesaj, 1 cihaz ve 1 uygulama.
  * [SuprSend](https://www.suprsend.com/) - SuprSend, ürün bildirimlerinizi API-öncelikli bir yaklaşımla kolaylaştıran bir bildirim altyapısıdır. Tek bir bildirim API'siyle çoklu kanallarda işlemsel, zamanlanmış ve etkileşim bildirimleri oluşturun ve teslim edin. Ücretsiz planda, farklı iş akışı düğümleri (özetler, partiler, çoklu kanallar, tercihler, tenant'lar, yayınlar ve daha fazlası) dahil olmak üzere ayda 10.000 bildirim alırsınız.

**[⬆️ Başa Dön](#table-of-contents)**

## Log Yönetimi

  * [bugfender.com](https://bugfender.com/) — Günde 100k log satırına kadar 24 saat saklama ile ücretsiz
  * [logentries.com](https://logentries.com/) — Ayda 5 GB'a kadar ve yedi gün saklama ile ücretsiz
  * [loggly.com](https://www.loggly.com/) — Tek kullanıcı için ücretsiz, günde 200MB ve yedi gün saklama
  * [logz.io](https://logz.io/) — Günde 1 GB'a kadar, bir gün saklama ile ücretsiz
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Manage Engine destekli Log Yönetim servisi. Ücretsiz Plan, 15 gün saklama ve 7 gün arama ile 50 GB depolama sunar.
  * [papertrailapp.com](https://papertrailapp.com/) — 48 saat arama, yedi gün arşiv, ayda 50 MB
  * [sematext.com](https://sematext.com/logsene) — Günde 500 MB'a kadar, yedi gün saklama ile ücretsiz
  * [sumologic.com](https://www.sumologic.com/) — Günde 500 MB'a kadar, yedi gün saklama ile ücretsiz
  * [logflare.app](https://logflare.app/) — Uygulama başına ayda 12.960.000 girişe kadar, 3 gün saklama ile ücretsiz
  * [logtail.com](https://logtail.com/) — ClickHouse tabanlı SQL uyumlu log yönetimi. Ayda 1 GB'a kadar, üç gün saklama ile ücretsiz.
  * [logzab.com](https://logzab.com/) — Denetim izi yönetim sistemi. Ayda 1.000 kullanıcı etkinlik kaydı, 1 ay saklama, 5 projeye kadar ücretsiz.
  * [openobserve.ai](https://openobserve.ai/) - Aylık 200 GB veri alımı ücretsiz, 15 gün saklama
**[⬆️ Başa Dön](#table-of-contents)**

## Çeviri Yönetimi

  * [crowdin.com](https://crowdin.com/) — Açık Kaynak için sınırsız proje, sınırsız dize ve işbirlikçi
  * [gitlocalize.com](https://gitlocalize.com) - Hem özel hem de genel depolar için ücretsiz ve sınırsız
  * [Lecto](https://lecto.ai/) - Ücretsiz katmanlı Makine Çeviri API'si (30 ücretsiz istek, istek başına 1000 çevrilmiş karakter). Loco Translate Wordpress eklentisi ile entegre.
  * [lingohub.com](https://lingohub.com/) — 3 kullanıcıya kadar ücretsiz, Açık Kaynak için her zaman ücretsiz
  * [localazy.com](https://localazy.com) - 1000 kaynak dil dizesine kadar ücretsiz, sınırsız dil, sınırsız katkıda bulunan, girişim ve açık kaynak fırsatları
  * [Localeum](https://localeum.com) - 1000 dizeye kadar ücretsiz, bir kullanıcı, sınırsız dil, sınırsız proje
  * [localizely.com](https://localizely.com/) — Açık Kaynak için ücretsiz
  * [Loco](https://localise.biz/) — 2000 çeviriye kadar ücretsiz, Sınırsız çevirmen, proje başına on dil, proje başına 1000 çevrilebilir varlık
  * [oneskyapp.com](https://www.oneskyapp.com/) — 5 kullanıcıya kadar sınırlı ücretsiz sürüm, Açık Kaynak için ücretsiz
  * [POEditor](https://poeditor.com/) — 1000 dizeye kadar ücretsiz
  * [SimpleLocalize](https://simplelocalize.io/) - 100 çeviri anahtarına kadar ücretsiz, sınırsız dize, sınırsız dil, girişim fırsatları
  * [Texterify](https://texterify.com/) - Tek kullanıcı için ücretsiz
  * [Tolgee](https://tolgee.io) - Sınırlı çeviriyle ücretsiz SaaS teklifi, sonsuza kadar ücretsiz self-hosted sürüm
  * [transifex.com](https://www.transifex.com/) — Açık Kaynak için ücretsiz
  * [Translation.io](https://translation.io) - Açık Kaynak için ücretsiz
  * [Translized](https://translized.com) - 1000 dizeye kadar ücretsiz, bir kullanıcı, sınırsız dil, sınırsız proje
  * [webtranslateit.com](https://webtranslateit.com/) — 500 dizeye kadar ücretsiz
  * [weblate.org](https://weblate.org/) — Özgür projeler için ücretsizdir, ücretsiz katmanda 10.000 dize kaynağına kadar, ve Sınırsız Self-hosted şirket içi.
  * [Free PO editor](https://pofile.net/free-po-editor) — Herkes için ücretsiz
  * [Lingo.dev](https://lingo.dev) – Web & mobil yerelleştirme için açık kaynaklı, yapay zeka destekli CLI. Kendi LLM’inizi kullanın veya Lingo.dev yönetimli yerelleştirme motoru ile her ay 10.000 ücretsiz kelime kullanın.

**[⬆️ Başa Dön](#table-of-contents)**

## İzleme

  * [UptimeObserver.com](https://uptimeobserver.com) - 5 dakikalık aralıklarla 20 uptime izleyici ve özelleştirilebilir durum sayfası edinin—ticari kullanım için bile. E-posta ve Telegram ile sınırsız, gerçek zamanlı bildirimler. Başlamak için kredi kartı gerekmez.
  * [Pingmeter.com](https://pingmeter.com/) - 10 dakikalık aralıkla 5 uptime izleyici. SSH, HTTP, HTTPS ve herhangi bir özel TCP portunu izleyin.
  * [alerty.ai](https://www.alerty.ai) - FE, BE, DB ve daha fazlası için ücretsiz APM ve izleme + ücretsiz ajan çalıştırmaları.
  * [appdynamics.com](https://www.appdynamics.com/) — 24 saatlik metrikler için ücretsiz, uygulama performans yönetimi ajanları bir Java, bir .NET, bir PHP ve bir Node.js ile sınırlı
  * [appneta.com](https://www.appneta.com/) — 1 saatlik veri saklama ile ücretsiz
  * [appspector.com](https://appspector.com/) - Uzaktan iOS/Android/Flutter hata ayıklama için görev kontrolü. Küçük trafik kullanımı için ücretsiz (64MB günlük).
  * [assertible.com](https://assertible.com) — Otomatik API testi ve izleme. Takımlar ve bireyler için ücretsiz planlar.
  * [bleemeo.com](https://bleemeo.com) - 3 sunucu, 5 uptime izleyici, sınırsız kullanıcı, sınırsız pano, sınırsız uyarı kuralı için ücretsiz.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - Bir URL veya web sitesi için Core Web Vitals geçmişini bulun.
  * [checklyhq.com](https://checklyhq.com) - Geliştiriciler için açık kaynak E2E / Sentetik izleme ve derin API izleme. Bir kullanıcı ve 10k API & ağ / 1.5k tarayıcı kontrol çalıştırması ile ücretsiz plan.
  * [cloudsploit.com](https://cloudsploit.com) — AWS güvenlik ve yapılandırma izleme. Ücretsiz: sınırsız isteğe bağlı tarama, sınırsız kullanıcı, sınırsız kayıtlı hesap. Abonelik: otomatik tarama, API erişimi, vb.
  * [cronitor.io](https://cronitor.io/) - Cron işleri, web siteleri, API'lar ve daha fazlası için performans analizleri ve uptime izleme. Beş izleyiciyle ücretsiz katman.
  * [datadoghq.com](https://www.datadoghq.com/) — 5 node'a kadar ücretsiz
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — Cron işleri için izleme. Bir ücretsiz snitch (izleyici), daha fazlası için başkalarını kaydolmaya yönlendirin
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 uptime izleyici, 5 dakikalık aralık. E-posta, Slack uyarıları.
  * [economize.cloud](https://economize.cloud) — Economize, bulut altyapı maliyetlerini anlamayı kolaylaştırır, kaynakları organize ederek optimize eder ve raporlar. Google Cloud Platform'da ayda 5.000$ harcamaya kadar ücretsiz.
  * [elastic.co](https://www.elastic.co/solutions/apm) — JS geliştiricileri için anında performans içgörüleri. 24 saatlik veri saklama ile ücretsiz
  * [fivenines.io](https://fivenines.io/) — Gerçek zamanlı panolar ve uyarılarla Linux sunucu izleme — her zaman ücretsiz, 5 sunucuya kadar, 60 saniyelik aralıkla. Kredi kartı gerekmez.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud, metrikleri ve günlükleri Grafana ile entegre eden bir gözlemlenebilirlik platformudur. Ücretsiz: 3 kullanıcı, on pano, 100 uyarı, Prometheus ve Graphite'de metrik depolama (10.000 seri, 14 gün saklama), Loki'de günlük depolama (50 GB günlük, 14 gün saklama)
  * [healthchecks.io](https://healthchecks.io) — Cron işleri ve arka plan görevlerinizi izleyin. 20 kontrole kadar ücretsiz.
  * [Hydrozen.io](https://hydrozen.io) — Uptime izleme & Durum sayfaları, Ücretsiz plan: 10 Uptime izleyici, 5 heartbeat izleyici, 1 Alan adı izleyici ve 1 Durum sayfası ücretsiz.
  * [incidenthub.cloud](https://incidenthub.cloud/) — Bulut ve SaaS durum sayfası toplayıcı - 20 izleyici ve 2 bildirim kanalı (Slack ve Discord) sonsuza kadar ücretsiz.
  * [inspector.dev](https://www.inspector.dev) - Bir dakikadan kısa sürede eksiksiz Gerçek Zamanlı izleme panosu, sonsuza kadar ücretsiz katman.
  * [instrumentalapp.com](https://instrumentalapp.com) - Güzel ve kullanımı kolay uygulama ve sunucu izleme, 500 metrik ve 3 saatlik veri görünürlüğü ile ücretsiz
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Digital Ocean'a karşı bağımsız hız testi ve TLS el sıkışma gecikme testi
  * [letsmonitor.org](https://letsmonitor.org) - SSL izleme, 5 izleyiciye kadar ücretsiz
  * [linkok.com](https://linkok.com) - Çevrimiçi bozuk link denetleyici, küçük web siteleri için 100 sayfaya kadar ücretsiz, açık kaynak projeler için tamamen ücretsiz.
  * [loader.io](https://loader.io/) — Sınırlamalarla ücretsiz yük testi araçları
  * [MonitorMonk](https://monitormonk.com) - Minimalist uptime izleme ve güzel durum sayfaları. Forever Free planı, 10 web sitesi veya api uç noktası için HTTPS, Anahtar Kelime, SSL ve Yanıt süresi izleme ve 2 pano/durum sayfası sağlar.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata, gerçek zamanlı metrik toplamak için açık kaynaklı bir araçtır. Gelişen bir üründür ve GitHub’da da bulunabilir!
  * [newrelic.com](https://www.newrelic.com) — New Relic gözlemlenebilirlik platformu, mühendislerin daha kusursuz yazılım oluşturmasına yardımcı olmak için tasarlanmıştır. Monolitlerden sunucusuz yapılara kadar her şeyi izleyebilir, analiz edebilir, sorun giderebilir ve tüm yazılım yığınızı optimize edebilirsiniz. Ücretsiz katman, ayda 100GB ücretsiz veri alımı, bir ücretsiz tam erişimli kullanıcı ve sınırsız ücretsiz birincil kullanıcı sunar.
  * [Middleware.io](https://middleware.io/) - Middleware gözlemlenebilirlik platformu, uygulamalarınızı ve yığını tam olarak görmenizi sağlar, böylece sorunları ölçekli olarak izleyebilir ve teşhis edebilirsiniz. Geliştirici topluluğu kullanımı için sonsuza kadar ücretsiz bir plan sunar: 1M günlük olayı için Log izleme, 2 ana makineye kadar Altyapı izleme & APM.
  * [nixstats.com](https://nixstats.com) - Bir sunucu için ücretsiz. E-posta Bildirimleri, herkese açık durum sayfası, 60 saniyelik aralık ve daha fazlası.
  * [OnlineOrNot.com](https://onlineornot.com/) - OnlineOrNot, web siteleri ve API'ler için uptime izleme, cron işleri ve planlanmış görevler için izleme sağlar. Ayrıca durum sayfaları sunar. İlk beş kontrol, 3 dakikalık aralıkla ücretsizdir. Ücretsiz katman, Slack, Discord ve E-posta ile uyarı gönderir.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — Bir web sitesinin Çin'de Büyük Güvenlik Duvarı tarafından engellenip engellenmediğini kontrol edin. Çin'deki sunucular ile Amerika Birleşik Devletleri'ndeki sunucular tarafından tespit edilen DNS sonuçları ve ASN bilgilerini karşılaştırarak DNS kirliliğini belirler.
  * [opsgenie.com](https://www.opsgenie.com/) — Sürekli çalışan hizmetler için güçlü uyarı ve çağrı yönetimi. 5 kullanıcıya kadar ücretsiz.
  * [paessler.com](https://www.paessler.com/) — Güçlü altyapı ve ağ izleme çözümü, uyarı, güçlü görselleştirme yetenekleri ve temel raporlama dahil. 100 sensöre kadar ücretsiz.
  * [pagecrawl.io](https://pagecrawl.io/) -  Web sitesi değişikliklerini izleyin, günlük kontrollerle 6 monitöre kadar ücretsiz.
  * [syagent.com](https://syagent.com/) — Ticari olmayan ücretsiz sunucu izleme hizmeti, uyarılar ve metrikler.
  * [pagerly.io](https://pagerly.io/) -  Slack'te çağrı yönetimi  (Pagerduty, OpsGenie ile entegre olur). 1 takıma kadar ücretsiz (bir takım bir çağrıya karşılık gelir)
  * [pagertree.com](https://pagertree.com/) - Uyarı ve çağrı yönetimi için basit arayüz. 5 kullanıcıya kadar ücretsiz.
  * [phare.io](https://phare.io/) - Sınırsız proje ve sınırsız durum sayfası için 100.000 olaya kadar ücretsiz Uptime İzleme.
  * [pingbreak.com](https://pingbreak.com/) — Modern uptime izleme hizmeti. Sınırsız URL kontrol edin ve Discord, Slack veya e-posta ile kesinti bildirimleri alın.
  * [pingpong.one](https://pingpong.one/) — İzleme ile gelişmiş durum sayfası platformu. Ücretsiz katman, SSL alt alan adı ile bir herkese açık özelleştirilebilir durum sayfası içerir. Pro planı, açık kaynak projeleri ve kar amacı gütmeyenler için ücretsiz sunulmaktadır.
  * [robusta.dev](https://home.robusta.dev/) — Prometheus tabanlı güçlü Kubernetes izleme. Kendi Prometheus’unuzu getirin veya hepsi bir arada paketi kurun. Ücretsiz katman, 20 Kubernetes düğümüne kadar içerir. Slack, Microsoft Teams, Discord ve daha fazlası ile uyarılar. PagerDuty, OpsGenie, VictorOps, DataDog ve birçok başka araç ile entegrasyon.
  * [sematext.com](https://sematext.com/) — 24 saatlik metrikler için ücretsiz, sınırsız sunucu, on özel metrik, 500.000 özel metrik veri noktası, sınırsız pano, kullanıcı, vb.
  * [sitemonki.com](https://sitemonki.com/) — Web sitesi, alan adı, Cron & SSL izleme, her kategoride 5 izleyici ücretsiz
  * [sitesure.net](https://sitesure.net) - Web sitesi ve cron izleme - 2 izleyici ücretsiz
  * [skylight.io](https://www.skylight.io/) — İlk 100.000 istek için ücretsiz (sadece Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — Performans İzleme API’si, Ping, DNS, vb. kontrol eder.
  * [stathat.com](https://www.stathat.com/) — On istatistikle ücretsiz başlayın, süresiz
  * [statuscake.com](https://www.statuscake.com/) — Web sitesi izleme, sınırlamalarla sınırsız test ücretsiz
  * [statusgator.com](https://statusgator.com/) — Durum sayfası izleme, 3 izleyici ücretsiz
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — Sunucu izleme, uptime izleme, DNS & alan adı izleme. 10 sunucu, 10 uptime ve 10 alan adı ücretsiz izleyin.
  * [thousandeyes.com](https://www.thousandeyes.com/) — Ağ ve kullanıcı deneyimi izleme. 3 konum ve 20 büyük web hizmeti veri beslemesi ücretsiz
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — Beş web sitesi için ücretsiz izleme, 60 saniyelik aralıklar, herkese açık durum sayfası.
  * [zenduty.com](https://www.zenduty.com/) — Uçtan uca olay yönetimi, uyarı, çağrı yönetimi ve yanıt düzenleme platformu. Ağ operasyonları, site güvenilirlik mühendisliği ve DevOps ekipleri için. 5 kullanıcıya kadar ücretsiz.
  * [instatus.com](https://instatus.com) - 10 saniyede güzel bir durum sayfası alın. Sınırsız abone ve sınırsız ekip ile sonsuza kadar ücretsiz.
  * [Squadcast.com](https://squadcast.com) - Squadcast, SRE en iyi uygulamalarını teşvik etmeye yardımcı olmak için tasarlanmış uçtan uca bir olay yönetim yazılımıdır. 10 kullanıcıya kadar sonsuza kadar ücretsiz plan mevcuttur.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri, geniş bir izleyici yelpazesi sunan kararlı bir uptime monitörüdür: cronjob, anahtar kelime, web sitesi, port, ping. 25 uptime kontrolü, 3 dakikalık aralıklarla ücretsizdir. Uyarılar Telefon Araması, SMS, E-posta ve Webhook ile iletilir.
  * [Better Stack](https://betterstack.com/better-uptime) - Uptime izleme, olay yönetimi, çağrı programlama/uyarma ve durum sayfaları tek bir üründe. Ücretsiz plan, 3 dakikalık kontrol sıklığı ile on izleyici ve durum sayfalarını içerir.
  * [Pulsetic](https://pulsetic.com) - 10 izleyici, 6 Ay geçmiş Uptime/Günlük, sınırsız durum sayfası ve özel alan adları dahil! Sonsuza kadar ücretsiz ve sınırsız e-posta uyarısı. Kredi kartı gerekmez.
  * [Wachete](https://www.wachete.com) - Beş sayfayı izleyin, her 24 saatte bir kontrol edilir.
  * [Xitoring.com](https://xitoring.com/) — Uptime izleme: 20 ücretsiz, Linux ve Windows Sunucu izleme: 5 ücretsiz, Durum sayfası: 1 ücretsiz - Mobil uygulama, birden fazla bildirim kanalı ve daha fazlası!
  * [Servervana](https://servervana.com) - Büyük projeler ve ekipler için gelişmiş uptime izleme. HTTP izleme, Tarayıcı tabanlı izleme, DNS izleme, alan adı izleme, durum sayfaları ve daha fazlasını sağlar. Ücretsiz katman, 10 HTTP izleyici, 1 DNS izleyici ve bir durum sayfası içerir.

**[⬆️ Başa Dön](#table-of-contents)**

## Çökme ve İstisna Yönetimi
  * [CatchJS.com](https://catchjs.com/) - Ekran görüntüleri ve tıklama izleri ile JavaScript hata takibi. Açık kaynak projeler için ücretsiz.
  * [bugsnag.com](https://www.bugsnag.com/) — İlk deneme süresinden sonra ayda 2.000 hataya kadar ücretsiz
  * [elmah.io](https://elmah.io/) — Web geliştiricileri için hata kaydı ve çalışma süresi izleme. Açık kaynak projeler için ücretsiz Küçük İşletme aboneliği.
  * [Embrace](https://embrace.io/) — Mobil uygulama izleme. Yılda 1 milyon kullanıcı oturumuna kadar küçük ekipler için ücretsiz.
  * [exceptionless](https://exceptionless.com) — Gerçek zamanlı hata, özellik, günlük raporlama ve daha fazlası. Ayda 3 bin etkinlik/1 kullanıcı için ücretsiz. Açık kaynak ve sınırsız kullanım için kolayca kendi sunucunuzda barındırabilirsiniz.
  * [GlitchTip](https://glitchtip.com/) — Basit, açık kaynak hata takibi. Açık kaynak Sentry SDK'ları ile uyumlu. Ayda 1000 etkinlik ücretsiz veya sınırsız kullanım için kendi sunucunuzda barındırabilirsiniz
  * [honeybadger.io](https://www.honeybadger.io) - İstisna, çalışma süresi ve cron izleme. Küçük ekipler ve açık kaynak projeler için ücretsiz (ayda 12.000 hata).
  * [memfault.com](https://memfault.com) — Bulut cihaz gözlemlenebilirliği ve hata ayıklama platformu. [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp) ve [Laird](https://app.memfault.com/register-laird) cihazları için 100 cihaz ücretsiz.
  * [rollbar.com](https://rollbar.com/) — İstisna ve hata izleme, ayda 5.000 hata, sınırsız kullanıcı, 30 gün saklama ile ücretsiz plan
  * [sentry.io](https://sentry.io/) — Sentry, uygulama istisnalarını gerçek zamanlı olarak izler ve küçük bir ücretsiz plana sahiptir. Ayda 5 bin hata/1 kullanıcı ücretsiz, kendi sunucunuzda barındırırsanız sınırsız kullanım
  * [Axiom](https://axiom.co/) — 30 gün saklama ile 0,5 TB'a kadar günlük depolayın. Vercel gibi platformlarla entegrasyonlar ve e-posta/Discord bildirimiyle gelişmiş veri sorgulama içerir.
  * [Semaphr](https://semaphr.com) — Mobil uygulamalarınız için ücretsiz hepsi bir arada kill switch.
  * [Jam](https://jam.dev) - Tek tıkla geliştirici dostu hata raporları. Sınırsız jam ile ücretsiz plan.
  * [Whitespace](https://whitespace.dev) – Tarayıcınızda tek tıkla hata raporları. Kişisel kullanım için sınırsız kayıt ile ücretsiz plan.

**[⬆️ Başa Dön](#table-of-contents)**

## Arama

  * [algolia.com](https://www.algolia.com/) — Yazım hatası toleransı, alaka düzeyi ve UI kütüphaneleriyle barındırılan arama çözümü. Ücretsiz "Build" planında 1M doküman ve 10K arama/ay dahildir. Ayrıca [geliştirici dokümantasyonu araması](https://docsearch.algolia.com/) da ücretsiz sunulur.
  * [bonsai.io](https://bonsai.io/) — Ücretsiz 1 GB bellek ve 1 GB depolama
  * [CommandBar](https://www.commandbar.com/) - Web tabanlı arama çubuğu/eklentisi olarak hizmet veren birleşik arama çubuğu. Kullanıcılarınızın ürününüzdeki içerikleri, navigasyonları, özellikleri vb. aramasını sağlar, bulunabilirliği artırır. Aylık 1.000 Aktif Kullanıcıya kadar ücretsiz, sınırsız komut.
  * [Orama Cloud](https://orama.com/pricing) — Ücretsiz 3 indeks, indeks başına 100K doküman, sınırsız tam metin/vektör/hibrid arama, 60 gün analiz
  * [searchly.com](http://www.searchly.com/) — Ücretsiz 2 indeks ve 20 MB depolama
  * [easysitesearch.com](https://easysitesearch.com/) — Arama widget'ı ve API'si, otomatik web-crawler tabanlı indeksleme ile. 50 alt sayfaya kadar sınırsız arama ücretsiz.

**[⬆️ Başa Dön](#table-of-contents)**

## Eğitim ve Kariyer Gelişimi

  * [FreeCodeCamp](https://www.freecodecamp.org/) - Veri Analizi, Bilgi Güvenliği, Web Geliştirme ve daha fazlasında ücretsiz kurslar ve sertifikalar sunan açık kaynak platform.
  * [The Odin Project](https://www.theodinproject.com/) - Web geliştirme için JavaScript ve Ruby odaklı müfredatıyla ücretsiz, açık kaynak platform.
  * [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - Çok sayıda Deneyimli Profesyonel Özgeçmiş şablonuna sahip, tamamen kopyalanabilir, düzenlenebilir ve indirilebilir, ATS uyumlu ücretsiz platform.
  * [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - Sektör lideri uzmanlardan, en yeni üretken yapay zeka araç ve teknikleriyle bir saatten kısa sürede uygulamalı deneyim kazanmak için ücretsiz kısa kurslar.
  * [LabEx](https://labex.io) - Linux, DevOps, Siber Güvenlik, Programlama, Veri Bilimi ve daha fazlasında interaktif laboratuvarlar ve gerçek dünya projeleriyle becerilerinizi geliştirin.
  * [Roadmap.sh](https://roadmap.sh) - Blokzincir'den UX Tasarım'a kadar tüm geliştirme alanlarını kapsayan ücretsiz öğrenme yol haritaları.
  * [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - Siber güvenlik, ağ yönetimi ve Python gibi konularda ücretsiz sertifika uyumlu kurslar sunar.
  * [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare, 2.500'den fazla MIT dersinin materyallerinin çevrim içi yayınıdır ve dünya çapında öğrenenler ve eğitimcilerle bilgiyi ücretsiz paylaşır. Youtube kanalı: [@mitocw](https://www.youtube.com/@mitocw/featured)
  * [W3Schools](https://www.w3schools.com/) - HTML, CSS, JavaScript gibi web geliştirme teknolojileri üzerine ücretsiz eğitimler sunar.
  * [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - Temel ve ileri düzey HTML/CSS, JavaScript ve SQL öğrenmek için ücretsiz çevrim içi rehberler.
  * [Full Stack Open](https://fullstackopen.com/en/) – React, Node.js, GraphQL, TypeScript ve daha fazlası ile modern web geliştirme üzerine ücretsiz üniversite seviyesi kurs. Tamamen çevrim içi ve kendi hızınızda ilerleyebilirsiniz.
  * [edX](https://www.edx.org/) - Harvard ve MIT dahil 250 önde gelen kurumdan 4.000'den fazla ücretsiz çevrim içi kursa erişim sunar, bilgisayar bilimi, mühendislik ve veri bilimi alanlarında uzmanlaşmıştır.
  * [Django-tutorial.dev](https://django-tutorial.dev) - Kullanıcılarına ilk framework olarak Django'yu öğrenmeleri için ücretsiz çevrim içi rehberler ve kullanıcıların yazdığı makalelere ücretsiz dofollow backlink verir.

**[⬆️ Başa Dön](#table-of-contents)**

## E-posta

  * [10minutemail](https://10minutemail.com) - Test için ücretsiz, geçici e-posta.
  * [AhaSend](https://ahasend.com) - İşlemsel e-posta servisi, ücretsiz planda aylık 1000 e-posta, sınırsız alan adı, ekip üyesi, webhook ve mesaj yönlendirme.
  * [AnonAddy](https://anonaddy.com) - Açık kaynak anonim e-posta yönlendirme, sınırsız e-posta takma adı oluşturma, ücretsiz
  * [Antideo](https://www.antideo.com/) — E-posta doğrulama, IP ve telefon numarası doğrulama için ücretsiz katmanda saatte 10 API isteği. Kredi kartı gerekmez.
  * [Brevo](https://www.brevo.com/) — 9.000 e-posta/ay, 300 e-posta/gün ücretsiz
  * [OneSignal](https://onesignal.com/) — 10.000 e-posta/ay, Kredi Kartı gerekmez.
  * [Bump](https://bump.email/) - Ücretsiz 10 Bump e-posta adresi, bir özel alan adı
  * [Burnermail](https://burnermail.io/) – Ücretsiz 5 Burner E-posta Adresi, 1 Posta Kutusu, 7 gün Posta Kutusu Geçmişi
  * [Buttondown](https://buttondown.email/) — Bülten servisi. 100 aboneye kadar ücretsiz
  * [CloudMailin](https://www.cloudmailin.com/) - HTTP POST ile gelen e-posta ve işlemsel giden e-posta - 10.000 ücretsiz e-posta/ay
  * [Contact.do](https://contact.do/) — Bir bağlantı ile iletişim formu (iletişim formları için bitly)
  * [debugmail.io](https://debugmail.io/) — Geliştiriciler için kullanımı kolay test e-posta sunucusu
  * [DNSExit](https://dnsexit.com/) - Alan adınız altında 2 adede kadar e-posta adresi, 100MB depolama alanı ile ücretsiz. IMAP, POP3, SMTP, SPF/DKIM desteği.
  * [EmailLabs.io](https://emaillabs.io/en) — Her ay 9.000'e kadar e-posta ücretsiz gönderin, günlük 300 e-posta sınırı.
  * [EmailOctopus](https://emailoctopus.com) - 2.500 aboneye ve ayda 10.000 e-postaya kadar ücretsiz
  * [EmailJS](https://www.emailjs.com/) – Bu başlı başına bir e-posta sunucusu değildir; doğrudan istemciden kimlik bilgilerinizi ifşa etmeden e-posta gönderebileceğiniz bir e-posta istemcisidir, ücretsiz katmanda ayda 200 istek, 2 e-posta şablonu, 50Kb'a kadar istek, sınırlı iletişim geçmişi vardır.
  * [EtherealMail](https://ethereal.email) - Ethereal, esas olarak Nodemailer ve EmailEngine kullanıcılarını hedef alan (ancak onlarla sınırlı olmayan) sahte bir SMTP servisidir. Tamamen ücretsiz, anti-işlemsel bir e-posta hizmetidir ve mesajlar asla teslim edilmez.
  * [Temp-Mail.org](https://temp-mail.org/en/) - Geniş alan adı yelpazesiyle geçici/tek kullanımlık posta üreticisi. Sayfa her yenilendiğinde e-posta adresi değişir. Tamamen ücretsizdir ve hizmet için herhangi bir fiyatlandırma yoktur.
  * [TempMailDetector.com](https://tempmaildetector.com/) - Aylık 200 e-postaya kadar ücretsiz doğrulama ve bir e-postanın geçici olup olmadığını görebilme.
  * [Emailvalidation.io](https://emailvalidation.io) - Ayda 100 ücretsiz e-posta doğrulama
  * [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - Alman geçici/tek kullanımlık posta üreticisi. 10 alan adı destekler ve sınırsız adres oluşturma özgürlüğü sağlar. (reklam içerir) ama onun dışında tamamen ücretsizdir.
  * [forwardemail.net](https://forwardemail.net) — Özel alan adları için ücretsiz e-posta yönlendirme. Alan adınızla sınırsız sayıda e-posta adresi oluşturun ve yönlendirin (**not**: .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work TLD'leri için spam nedeniyle ödeme yapmanız gerekir)
  * [Imitate Email](https://imitate.email) - E-posta işlevselliğini build/qa ve ci/cd boyunca test etmek için Sandbox E-posta Sunucusu. Ücretsiz hesaplar günde 15 e-posta alır.
  * [ImprovMX](https://improvmx.com) – Ücretsiz e-posta yönlendirme.
  * [EForw](https://www.eforw.com) – Bir alan adı için ücretsiz e-posta yönlendirme. Alan adınızdan e-posta alıp gönderebilirsiniz.
  * [Inboxes App](https://inboxesapp.com) — Günde 3 geçici e-posta oluşturun ve işiniz bittiğinde Chrome eklentisi üzerinden silin. Kayıt akışlarını test etmek için idealdir.
  * [inboxkitten.com](https://inboxkitten.com/) - Ücretsiz geçici/tek kullanımlık e-posta kutusu, 3 güne kadar otomatik e-posta silme. Açık kaynak ve kendi sunucunuzda barındırabilirsiniz.
  * [mail-tester.com](https://www.mail-tester.com) — E-postanın DNS/SPF/DKIM/DMARC ayarlarının doğru olup olmadığını test edin, ayda 20 ücretsiz.
  * [dkimvalidator.com](https://dkimvalidator.com/) - E-postanın DNS/SPF/DKIM/DMARC ayarlarının doğru olup olmadığını test edin, roundsphere.com tarafından ücretsiz hizmet
  * [mailcatcher.me](https://mailcatcher.me/) — Mailleri yakalar ve bir web arayüzü üzerinden sunar.
  * [mailchannels.com](https://www.mailchannels.com) - REST API ve SMTP entegrasyonlu E-posta API'si, ayda 3.000 e-postaya kadar ücretsiz.
  * [Mailcheck.ai](https://www.mailcheck.ai/) - Kullanıcıların geçici e-posta adresiyle kayıt olmasını engelleyin, saatte 120 istek (~86.400/ay)
  * [Mailchimp](https://mailchimp.com/) — 500 abone ve ayda 1.000 e-posta ücretsiz.
  * [Maildroppa](https://maildroppa.com) - 100 aboneye ve sınırsız e-postaya ve ayrıca otomasyona kadar ücretsiz.
  * [MailerLite.com](https://www.mailerlite.com) — Ayda 1.000 abone, 12.000 e-posta ücretsiz
  * [MailerSend.com](https://www.mailersend.com) — E-posta API, SMTP, işlemsel e-posta için ayda 3.000 e-posta ücretsiz
  * [mailinator.com](https://www.mailinator.com/) — İstediğiniz herhangi bir posta kutusunu kullanabileceğiniz ücretsiz, halka açık e-posta sistemi
  * [Mailjet](https://www.mailjet.com/) — Ayda 6.000 e-posta ücretsiz (günlük 200 e-posta gönderim limiti)
  * [Mailnesia](https://mailnesia.com) - Kayıt bağlantısını otomatik ziyaret eden ücretsiz geçici/tek kullanımlık e-posta.
  * [mailsac.com](https://mailsac.com) - Geçici e-posta testi için ücretsiz API, ücretsiz halka açık e-posta barındırma, giden yakalama, e-posta-slack/websocket/webhook (aylık 1.500 API limiti)
  * [Mailtrap.io](https://mailtrap.io/) — Geliştirme için sahte SMTP sunucusu, bir gelen kutusu, 100 mesaj, takım üyesi yok, saniyede iki e-posta, yönlendirme kuralı yok ile ücretsiz plan.
  * [Mail7.io](https://www.mail7.io/) — QA geliştiricileri için ücretsiz geçici e-posta adresleri. Web arayüzü veya API kullanarak anında e-posta adresleri oluşturun.
  * [Momentary Email](https://www.momentaryemail.com/) — Ücretsiz Geçici E-posta Adresleri. Gelen e-postaları web sitesinden veya RSS akışıyla okuyun.
  * [Mutant Mail](https://www.mutantmail.com/) – Ücretsiz 10 E-posta Kimliği, 1 Alan Adı, 1 Posta Kutusu. Tüm e-posta kimlikleri için tek posta kutusu.
  * [Outlook.com](https://outlook.live.com/owa/) - Ücretsiz kişisel e-posta ve takvim.
  * [Parsio.io](https://parsio.io) — Ücretsiz e-posta ayrıştırıcı (E-postayı iletin, verileri çıkarın, sunucunuza gönderin)
  * [pepipost.com](https://pepipost.com) — İlk ay için 30 bin e-posta ücretsiz, ardından ilk 100 e-posta/gün ücretsiz.
  * [Plunk](https://useplunk.com) - Ayda 3.000 e-posta ücretsiz
  * [Postmark](https://postmarkapp.com/) - Ayda 100 e-posta ücretsiz, sınırsız DMARC haftalık özetleri.
  * [Proton Mail](https://proton.me/mail) -  Dahili uçtan uca şifrelemeye sahip ücretsiz güvenli e-posta servisi sağlayıcısı. 1GB ücretsiz depolama.
  * [Queuemail.dev](https://queuemail.dev) — Güvenilir e-posta teslimat API'si. Ücretsiz katman (ayda 10.000 e-posta). Asenkron gönderim. Birden fazla SMTP sunucusu kullanın. Engelleme listeleri, Kayıt, Takip, Webhook ve daha fazlası.
  * [QuickEmailVerification](https://quickemailverification.com) — Ücretsiz katmanda günlük 100 e-posta doğrulama ve DEA Tespit Edici, DNS Sorgulama, SPF Tespit Edici ve daha fazlası gibi diğer ücretsiz API'ler.
  * [Resend](https://resend.com) - Geliştiriciler için işlem e-postaları API'si. Aylık 3.000 e-posta, günlük 100 e-posta ücretsiz, bir özel alan adı.
  * [Sender](https://www.sender.net) Aylık 15.000 e-postaya kadar, 2.500 aboneye kadar ücretsiz
  * [Sendpulse](https://sendpulse.com) — Aylık 500 abone, aylık 15.000 e-posta ücretsiz
  * [SimpleLogin](https://simplelogin.io/) – Açık kaynak kodlu, kendinize barındırabileceğiniz e-posta takma adı/ileti yönlendirme çözümü. 5 Takma Ad, sınırsız bant genişliği, sınırsız yanıt/gönderme ücretsiz. Eğitim personeli (öğrenci, araştırmacı vb.) için ücretsiz.
  * [Substack](https://substack.com) — Sınırsız ücretsiz bülten servisi. Ücret talep etmeye başladığınızda ödeme yaparsınız.
  * [Sweego](https://www.sweego.io/) - Geliştiriciler için Avrupalı işlem e-postaları API'si. Günlük 500 e-posta ücretsiz.
  * [Takeout](https://takeout.bysourfruit.com) - E-posta göndermeyi kolaylaştıran sürekli güncellenen bir e-posta servisi. Aylık beş yüz işlem e-postası ücretsiz.
  * [temp-mail.io](https://temp-mail.io) — Aynı anda birden fazla e-posta ve yönlendirme ile ücretsiz, geçici tek kullanımlık e-posta servisi
  * [tinyletter.com](https://tinyletter.com/) — Aylık 5.000 abone ücretsiz
  * [Touchlead](https://touchlead.app) - Potansiyel müşteri yönetimi, form oluşturucu ve otomasyon ile çok amaçlı bir pazarlama otomasyon aracı. Sınırlı sayıda potansiyel müşteri ve otomasyon için ücretsiz
  * [trashmail.com](https://www.trashmail.com) - Yönlendirme ve otomatik adres süresi dolumu ile ücretsiz tek kullanımlık e-posta adresleri
  * [Tuta](https://tuta.com/) - Yerleşik uçtan uca şifreleme, reklam yok, takip yok ile ücretsiz güvenli e-posta hizmeti sağlayıcı. Ücretsiz 1GB depolama, bir takvim (Tuta ayrıca [ücretli bir plana](https://tuta.com/pricing) da sahiptir.). Tuta ayrıca kısmen [açık kaynaklıdır](https://github.com/tutao/tutanota), böylece kendiniz de barındırabilirsiniz.
  * [Verifalia](https://verifalia.com/email-verification-api) — Gerçek zamanlı e-posta doğrulama API'si, posta kutusu onayı ve tek kullanımlık e-posta adresi dedektörü; günlük 25 ücretsiz e-posta doğrulama.
  * [verimail.io](https://verimail.io/) — Toplu ve API e-posta doğrulama hizmeti. Aylık 100 ücretsiz doğrulama
  * [Zoho](https://www.zoho.com) — Başlangıçta bir e-posta sağlayıcısı olarak başladı, ancak şimdi bazıları ücretsiz planlara sahip bir dizi hizmet sunuyor. Ücretsiz planlara sahip hizmetlerin listesi :
     - [Email](https://zoho.com/mail) 5 kullanıcıya kadar ücretsiz. 5GB/kullanıcı & 25 MB ek dosya limiti, bir alan adı.
     - [Zoho Assist](https://www.zoho.com/assist) — Zoho Assist'in sonsuza kadar ücretsiz planı, bir eşzamanlı uzaktan destek lisansı ve hem profesyonel hem de kişisel kullanım için sınırsız süreyle 5 müdahalesiz bilgisayara erişim içerir.
     - [Sprints](https://zoho.com/sprints) 5 kullanıcı, 5 Proje & 500MB depolama alanı ücretsiz.
     - [Docs](https://zoho.com/docs) — 5 kullanıcıya kadar ücretsiz, 1 GB yükleme limiti & 5GB depolama. Zoho Office Suite (Writer, Sheets & Show) pakete dahildir.
     - [Projects](https://zoho.com/projects) — 3 kullanıcı, 2 proje & 10 MB ek dosya limiti ücretsiz. Aynı plan [Bugtracker](https://zoho.com/bugtracker) için de geçerlidir.
     - [Connect](https://zoho.com/connect) — Takım işbirliği, 25 kullanıcıya kadar ücretsiz, üç grup, üç özel uygulama, 3 Tahta, 3 Kılavuz ve 10 Entegrasyon ile birlikte kanallar, etkinlikler & forumlar.
     - [Meeting](https://zoho.com/meeting) — 3 toplantı katılımcısı ve 10 Webinar katılımcısına kadar toplantılar.
     - [Vault](https://zoho.com/vault) — Bireyler için erişilebilir Parola Yönetimi.
     - [Showtime](https://zoho.com/showtime) — Uzaktan oturumlar için 5 katılımcıya kadar eğitim amaçlı bir başka toplantı yazılımı.
     - [Notebook](https://zoho.com/notebook) — Evernote için ücretsiz bir alternatif.
     - [Wiki](https://zoho.com/wiki) — Üç kullanıcı için ücretsiz, 50 MB depolama, sınırsız sayfa, zip yedekleri, RSS & Atom beslemesi, erişim kontrolleri & özelleştirilebilir CSS.
     - [Subscriptions](https://zoho.com/subscriptions) — 20 müşteri/abonelik ve 1 kullanıcıya kadar yinelemeli Faturalama yönetimi ücretsiz, tüm ödeme barındırması Zoho tarafından yapılır. Son 40 abonelik metriği saklanır.
     - [Checkout](https://zoho.com/checkout) — 3 sayfa & 50 ödemeye kadar Ürün Faturalama yönetimi.
     - [Desk](https://zoho.com/desk) — Üç temsilci, özel bilgi tabanı ve e-posta biletleri ile Müşteri Destek yönetimi. Bir uzak teknisyen & 5 müdahalesiz bilgisayar için [Assist](https://zoho.com/assist) ile entegre olur.
     - [Cliq](https://zoho.com/cliq) — 100 GB depolama, sınırsız kullanıcı, kanal başına 100 kullanıcı & SSO ile takım sohbet yazılımı.
     - [Campaigns](https://zoho.com/campaigns) - E-posta Pazarlama
     - [Forms](https://zoho.com/forms) - Form Oluşturucu
     - [Sign](https://zoho.com/sign) - Kağıtsız İmzalar
     - [Surveys](https://zoho.com/surveys) - Online Anketler
     - [Bookings](https://zoho.com/bookings) - Randevu Planlama
  * [Maileroo](https://maileroo.com) - Geliştiriciler için SMTP aktarımı ve e-posta API'si. Aylık 5.000 e-posta, sınırsız alan adı, ücretsiz e-posta doğrulama, kara liste izleme, posta test cihazı ve daha fazlası.

**[⬆️ Başa Dön](#table-of-contents)**

## Özellik Anahtarı Yönetim Platformları

  * [ConfigCat](https://configcat.com) - ConfigCat, sınırsız ekip boyutu, mükemmel destek ve makul fiyat etiketi ile geliştirici odaklı bir özellik anahtarı servisidir. Ücretsiz plan 10 anahtara, iki ortama, 1 ürüne ve aylık 5 Milyon isteğe kadar izin verir.
  * [Flagsmith](https://flagsmith.com) - Özellikleri güvenle yayınlayın; web, mobil ve sunucu tarafı uygulamalarda özellik anahtarlarını yönetin. Barındırılan API'mizi kullanın, kendi özel bulutunuza dağıtın veya şirket içi çalıştırın.
  * [GrowthBook](https://growthbook.io) - Yerleşik Bayesyen istatistik motoru ile açık kaynak özellik anahtarı ve A/B test sağlayıcısı. 3 kullanıcıya kadar ücretsiz, sınırsız özellik anahtarı ve deney.
  * [Hypertune](https://www.hypertune.com) - Tip güvenli özellik anahtarları, A/B testleri, analizler ve uygulama yapılandırması, Git tarzı sürüm kontrolü ve senkron, bellekte, yerel anahtar değerlendirmesi ile. 5 ekip üyesine kadar ücretsiz, sınırsız özellik anahtarı ve A/B testi.
  * [Molasses](https://www.molasses.app) - Güçlü özellik anahtarları ve A/B testleri. Her biri beş özellik anahtarı olan 3 ortama kadar ücretsiz.
  * [Toggled.dev](https://www.toggled.dev) - Kurumsal düzeyde, ölçeklenebilir, çok bölgeli özellik anahtarı yönetim platformu. Ücretsiz plan 10 anahtara, iki ortama, sınırsız isteğe kadar izin verir. SDK, analiz paneli, sürüm takvimi, Slack bildirimleri ve diğer tüm özellikler sonsuz ücretsiz planda dahildir.
  * [Statsig](https://www.statsig.com) - Özellik yönetimi, A/B testleri, analizler ve daha fazlası için güçlü bir platform. Cömert ücretsiz planı, aylık 1 milyon olaya kadar sınırsız koltuk, anahtar, deney ve dinamik yapılandırma sunar.
  * [Abby](https://www.tryabby.com) - Açık Kaynak özellik anahtarları & A/B testleri. Kod Olarak Yapılandırma & Tam Tipli Typescript SDK'ları. Next.js & React gibi Frameworklerle güçlü entegrasyon. Cömert ücretsiz katman ve uygun fiyatlı ölçeklendirme seçenekleri.


**[⬆️ Başa Dön](#table-of-contents)**

## Yazı Tipi

  * [dafont](https://www.dafont.com/) - Bu web sitesinde sunulan yazı tipleri, yazarlarının mülkiyetindedir ve freeware, shareware, demo sürümleri veya kamu malı olabilir.
  * [Everything Fonts](https://everythingfonts.com/) - Birden fazla araç sunar; @font-face, Birim Dönüştürücü, Yazı Tipi İnce Ayar ve Yazı Tipi Yükleyici.
  * [Font Squirrel](https://www.fontsquirrel.com/) - Ticari işler için lisanslanmış ücretsiz yazı tipleri. Bu yazı tipleri özenle seçilmiş ve kullanımı kolay bir formatta sunulmuştur.
  * [Google Fonts](https://fonts.google.com/) - Birçok ücretsiz yazı tipi, Google'ın CDN'ine bağlantı veya indirme yoluyla web sitesine kolayca ve hızlıca kurulabilir.
  * [FontGet](https://www.fontget.com/) - Çeşitli yazı tipleri indirilebilir ve etiketlerle düzenli bir şekilde sıralanmıştır.
  * [Fontshare](https://www.fontshare.com/) - ücretsiz bir yazı tipi servisidir. Kişisel ve ticari kullanım için %100 ücretsiz, profesyonel düzeyde yazı tiplerinden oluşan büyüyen bir koleksiyona sahiptir.
  * [Befonts](https://befonts.com/) - Kişisel veya ticari kullanım için çeşitli benzersiz yazı tipleri sunar.
  * [Font of web](https://fontofweb.com/) - Bir web sitesinde kullanılan tüm yazı tiplerini ve nasıl kullanıldıklarını belirler.
  * [Bunny](https://fonts.bunny.net) Gizlilik odaklı Google Fonts
  * [FontsKey](https://www.fontskey.com/) - Kişisel kullanım için ücretsiz ve ticari ücretli yazı tipleri sunar ve hızlı filtreleme için metin girişi yapılabilir.
  * [fonts.xz.style](https://fonts.xz.style/) CSS kullanarak web sitelerine yazı tipi ailelerini sunmak için ücretsiz ve açık kaynaklı bir hizmet.
  * [Fontsensei](https://fontsensei.com/) Kullanıcılar tarafından etiketlenmiş açık kaynak Google yazı tipleri. CJK (Çince, Japonca, Korece) yazı tipi etiketleri ile.

**[⬆️ Başa Dön](#table-of-contents)**

## Formlar

  * [Feathery](https://feathery.io) - Güçlü, geliştirici dostu form oluşturucu. Kayıt & giriş, kullanıcı yönlendirme, ödeme akışları, karmaşık finansal uygulamalar ve daha fazlasını oluşturun. Ücretsiz plan, aylık 250 gönderim ve beş aktif form sağlar.
  * [Form-Data](https://form-data.com) - Kodsuz formlar backend'i. Spam filtresi, e-posta bildirimi ve otomatik yanıt, webhooks, zapier, yönlendirme, AJAX veya POST ve daha fazlası. Ücretsiz planda sınırsız form, aylık 20 gönderim ve Form-Data rozeti ile ek 2000 gönderim sunulmaktadır.
  * [FabForm](https://fabform.io/) - Akıllı geliştiriciler için form backend platformu. Ücretsiz plan, aylık 250 form gönderimine izin verir. Kullanıcı dostu modern arayüz. Google Sheets, Airtable, Slack, E-posta ve diğerleri ile entegre olur.
  * [Form.taxi](https://form.taxi/) — HTML formları için gönderim uç noktası. Bildirimler, spam engelleyiciler ve GDPR uyumlu veri işleme ile. Temel kullanım için ücretsiz plan.
  * [Formcarry.com](https://formcarry.com) - HTTP POST Form uç noktası, Ücretsiz plan aylık 100 gönderime izin verir.
  * [formingo.co](https://www.formingo.co/)- Statik web siteleri için kolay HTML formlar. Hesap kaydı olmadan ücretsiz başlayabilirsiniz. Ücretsiz plan aylık 500 gönderim ve özelleştirilebilir yanıt e-posta adresi sağlar.
  * [FormKeep.com](https://www.formkeep.com/) - Sınırsız form, aylık 50 gönderim, spam koruması, e-posta bildirimi ve HTML dışa aktarabilen sürükle-bırak tasarımcı. Ekstra özellikler arasında özel alan kuralları, ekipler ve Google Sheets, Slack, ActiveCampaign ve Zapier entegrasyonları bulunur.
  * [formlets.com](https://formlets.com/) — Çevrimiçi formlar, sınırsız tek sayfa form/ay, aylık 100 gönderim, e-posta bildirimi.
  * [formspark.io](https://formspark.io/) -  E-posta servisine form, ücretsiz planda sınırsız form, aylık 250 gönderim, Müşteri destek ekibi ile destek.
  * [Formspree.io](https://formspree.io/) — HTTP POST isteğiyle e-posta gönderin. Ücretsiz katmanda form başına aylık 50 gönderim sınırı.
  * [Formsubmit.co](https://formsubmit.co/) — HTML formlarınız için kolay uç noktalar. Sonsuza kadar ücretsiz. Kayıt gerekmez.
  * [Formlick.com](https://formlick.com) - Ömür boyu anlaşmalı Typeform alternatifi. Kullanıcılar 1 ücretsiz form oluşturabilir ve sınırsız gönderim alabilir. Premiumda, kullanıcılar sınırsız form ve sınırsız gönderim oluşturabilir.
  * [getform.io](https://getform.io/) - Tasarımcılar ve geliştiriciler için form backend platformu, 1 form, 50 gönderim, Tek dosya yükleme, 100MB dosya depolama.
  * [HeroTofu.com](https://herotofu.com/) - Bot tespiti ve şifreli arşiv ile formlar için backend. Gönderimleri UI üzerinden e-posta, Slack veya Zapier'e iletin. Kendi ön yüzünüzü kullanın. Sunucu kodu gerekmez. Ücretsiz plan sınırsız form ve aylık 100 gönderim sağlar.
  * [HeyForm.net](https://heyform.net/) - Sürükle bırak online form oluşturucu. Ücretsiz katman, sınırsız form oluşturmanıza ve sınırsız gönderim toplamanıza olanak tanır. Hazır şablonlar, anti-spam ve 100MB dosya depolama ile birlikte gelir.
  * [Tally.so](https://tally.so/) - Özelliklerin %99'u ücretsiz. Ücretsiz katmanda: sınırsız form, sınırsız gönderim, e-posta bildirimi, form mantığı, ödeme alma, dosya yükleme, özel teşekkür sayfası ve daha fazlası var.
  * [Hyperforms.app](https://hyperforms.app/) — Saniyeler içinde ve backend kodu olmadan e-posta ve daha fazlası için form oluşturun. Kişisel hesap, aylık 50 form gönderimine kadar ücretsizdir.
  * [Kwes.io](https://kwes.io/) - Özellik açısından zengin form uç noktası. Statik sitelerle harika çalışır. Ücretsiz plan, 1 web sitesi ve aylık 50 gönderime kadar izin verir.
  * [Pageclip](https://pageclip.co/) - Ücretsiz planda bir site, bir form ve aylık 1.000 gönderim izinli.
  * [Qualtrics Survey](https://qualtrics.com/free-account) — Bu birinci sınıf araçla profesyonel formlar & anketler oluşturun. 50+ uzman tasarımlı anket şablonu. Ücretsiz hesapta 1 aktif anket, anket başına 100 yanıt ve 8 yanıt türü sınırı vardır.
  * [Screeb](https://screeb.app/) - Kullanıcı davranışını çözümlemek için uygulama içi anketler ve ürün analitiği. Sonsuza dek ücretsiz planda aylık 500 aktif kullanıcı, sınırsız yanıt ve etkinlik, birçok entegrasyon, dışa aktarım ve periyodik raporlar var.
  * [smartforms.dev](https://smartforms.dev/) - Web siteniz için güçlü ve kolay form backend, sonsuza dek ücretsiz plan aylık 50 gönderim, 250MB dosya depolama, Zapier entegrasyonu, CSV/JSON dışa aktarım, özel yönlendirme, özel yanıt sayfası, Telegram & Slack botu, tekli e-posta bildirimi sağlar.
  * [Survicate](https://survicate.com/) — Tüm kaynaklardan geri bildirim alın ve tek bir araçla takip anketleri gönderin. Geri bildirimi otomatik olarak analiz edin ve AI ile içgörü elde edin. Ücretsiz e-posta, web sitesi, ürün içi veya mobil anketler, AI anket oluşturucu ve aylık 25 yanıt.
  * [staticforms.xyz](https://www.staticforms.xyz/) - HTML formlarını herhangi bir sunucu tarafı kodu olmadan kolayca entegre edin. Kullanıcı formu gönderdikten sonra, form içeriği kayıtlı adresinize e-posta olarak iletilir.
  * [stepFORM.io](https://stepform.io) - Quiz ve Form Oluşturucu. Ücretsiz planda beş form, form başına 3 adım ve aylık 50 yanıt hakkı vardır.
  * [Typeform.com](https://www.typeform.com/) — Web sitelerine güzel tasarımlı formlar ekleyin. Ücretsiz plan form başına yalnızca on alan ve aylık 100 yanıt izinli.
  * [WaiverStevie.com](https://waiverstevie.com) - REST API ile Elektronik İmza platformu. Webhook ile bildirim alabilirsiniz. Ücretsiz plan, imzalı belgelerde filigran uygular, ancak sınırsız zarf + imza sağlar.
  * [Web3Forms](https://web3forms.com) - Backend kodu yazmadan Statik & JAMStack Web Siteleri için iletişim formları. Ücretsiz plan Sınırsız Form, Sınırsız Alan Adı & aylık 250 Gönderime izin verir.
  * [WebAsk](https://webask.io) - Anket ve Form Oluşturucu. Ücretsiz plan, her hesap için üç anket, aylık 100 yanıt ve anket başına on öğe içerir.
  * [Wufoo](https://www.wufoo.com/) - Web sitelerinde kullanılmak üzere hızlı formlar. Ücretsiz plan, her ay 100 gönderimle sınırlıdır.
  * [formpost.app](https://formpost.app) - Ücretsiz, sınırsız Formdan E-posta’ya hizmeti. Özel yönlendirmeler, otomatik yanıt, webhook vb. ücretsiz olarak ayarlayın.
  * [Formester.com](https://formester.com) - Web sitenizde benzersiz görünümlü formlar paylaşın ve yerleştirin—oluşturulan form sayısında veya özelliklerde plan kısıtlaması yoktur. Her ay 100 gönderime kadar ücretsiz alın.
  * [SimplePDF.eu](https://simplepdf.eu/embed) - Web sitenize bir PDF düzenleyici yerleştirin ve herhangi bir PDF’yi doldurulabilir bir forma dönüştürün. Ücretsiz plan, sınırsız PDF ve PDF başına üç gönderime izin verir.
  * [forms.app](https://forms.app/) — Koşullu mantık, otomatik puan hesaplayıcı ve yapay zeka gibi güçlü özelliklerle çevrimiçi formlar oluşturun. Ücretsiz plan ile 100 yanıt toplayın, formlarınızı bir web sitesine yerleştirin veya bir bağlantı ile kullanın.
  * [Qualli](https://usequalli.com) - Uygulama İçi Anketler, mobil için tasarlanmıştır. Mükemmel soruları oluşturmak için Qualli AI kullanın. Ücretsiz planımızda 500 MAU’ya kadar deneyebilirsiniz, sınırsız form ve tetikleyici oluşturabilirsiniz.
  * [Sprig](https://sprig.com/) - Ayda 1 Ürün İçi Anket veya Tekrar Oynatmalı Anket, GPT destekli Yapay Zeka Analizi ile birlikte.
  * [feedback.fish](https://feedback.fish/) - Ücretsiz plan toplamda 25 geribildirim gönderimi toplamanıza izin verir. Sağlanan React ve Vue bileşenleriyle kolay entegrasyon.
  * [Vidhook](https://vidhook.io/) - Yüksek yanıt oranlı keyifli anketlerle geribildirim toplayın. Ücretsiz plan, 1 aktif anket, anket başına 25 yanıt ve özelleştirilebilir şablonlar içerir.

**[⬆️ Başa Dön](#table-of-contents)**

## Generative AI

  * [Zenable](https://zenable.io) - Cursor, Windsurf ve Copilot gibi araçlardan çıkan çıktıları anında otomatik olarak düzeltin; şirketinizin kalite ve uyumluluk standartlarını karşılayın, Policy as Code ile oluşturulmuş koruma rayları kullanın. Ücretsiz katman, MCP sunucusuna günde 100 araç çağrısı ve GitHub Uygulaması üzerinden günde 25 ücretsiz otomatik pull request incelemesi içerir.
  * [Keywords AI](https://keywordsai.co) - En iyi LLM izleme platformu. 200’den fazla LLM’i çağırmak için tek bir format, 2 satır kod. Her ay 10.000 ücretsiz istek ve platform özellikleri için $0!
  * [Portkey](https://portkey.ai/) - Gözlemlenebilirlik paketi ve bir yapay zeka geçidi sunan Gen AI uygulamaları için kontrol paneli. Her ay 10.000 isteğe kadar ücretsiz gönderin ve kaydedin.
  * [Braintrust](https://www.braintrustdata.com/) - Gen AI için değerlendirme, prompt oyun alanı ve veri yönetimi. Ücretsiz plan haftada 1.000 özel değerlendirme satırı sunar.
  * [Findr](https://www.usefindr.com/) - Tüm uygulamalarınızda aynı anda arama yapmanızı sağlayan evrensel arama. Bilgilerinizi kullanarak soruları yanıtlamanızı sağlayan arama asistanı. Ücretsiz plan, sınırsız birleşik arama ve günlük 5 yardımcı pilot sorgusu sunar.
  * [ReportGPT](https://ReportGPT.app) - Yapay Zeka Destekli Yazım Asistanı. Kendi API anahtarınızı getirdiğiniz sürece platform tamamen ücretsizdir.
  * [Clair](https://askclair.ai/) - Klinik Yapay Zeka Referansı. Öğrenciler, Açık Arama, Klinik Özet, İlaç İnceleme, İlaç Etkileşimleri, ICD-10 Kodları ve Stewardship dahil olmak üzere profesyonel araç setine ücretsiz erişim elde eder. Ayrıca profesyonel set için ücretsiz deneme sunulmaktadır.
  * [Langtrace](https://langtrace.ai) - Geliştiricilerin bir LLM uygulamasının performansı ile ilgili prompt ve veri kümelerini izlemelerini, değerlendirmelerini, yönetmelerini ve hata ayıklamalarını sağlar. Herhangi bir LLM için açık telemetri standart izleri oluşturur, gözlemlenebilirliği artırır ve herhangi bir gözlemlenebilirlik istemcisiyle çalışır. Ücretsiz plan ayda 50.000 iz sunar.
  * [LangWatch](https://langwatch.ai) - LLMOps platformu, yapay zeka ekiplerinin LLM uygulamalarını güvenilirlik, maliyet etkinliği ve performans açısından ölçmesine, izlemesine ve optimize etmesine yardımcı olur. Güçlü DSPy bileşeniyle mühendisler ve teknik olmayan ekipler arasında işbirliğini kolaylaştırarak GenAI ürünlerinin ince ayarını ve üretimini sağlıyoruz. Ücretsiz plan, tüm platform özelliklerini, ayda 1.000 iz ve 1 iş akışı DSPy optimize edici içerir. [#opensource](https://github.com/langwatch/langwatch)
  * [Comet Opik](https://www.comet.com/site/products/opik/) - Geliştirme ve üretim yaşam döngüleriniz boyunca LLM uygulamalarını değerlendirin, test edin ve dağıtın. [#opensource](https://github.com/comet-ml/opik/)
  * [Langfuse](https://langfuse.com/) - Takımların LLM uygulamaları üzerinde işbirliği içinde hata ayıklamasına, analiz etmesine ve yineleme yapmasına yardımcı olan açık kaynaklı LLM mühendislik platformu. Sonsuza kadar ücretsiz plan, ayda 50.000 gözlem ve tüm platform özelliklerini içerir. [#opensource](https://github.com/langfuse/langfuse)
  * [Pollinations.AI](https://pollinations.ai/) - Kullanımı kolay, ücretsiz görsel üreten yapay zeka, ücretsiz API ile birlikte. Kayıt ya da API anahtarı gerekmez ve web sitesine ya da iş akışına entegre etmek için çeşitli seçenekler mevcut. [#opensource](https://github.com/pollinations/pollinations)
  * [Othor AI](https://othor.ai/) - Tableau, Power BI ve Looker gibi popüler iş zekası çözümlerine yapay zeka odaklı, hızlı, basit ve güvenli bir alternatif. Othor, büyük dil modellerini (LLM) kullanarak dakikalar içinde özel iş zekası çözümleri sunar. Free Forever planı, 1 kullanıcı için 5 veri kaynağı bağlantısı olan bir çalışma alanı sağlar ve analizlerde sınır yoktur. [#opensource](https://github.com/othorai/othor.ai)
  * [OpenRouter](https://openrouter.ai/models?q=free) - DeepSeek R1, V3, Llama ve Moonshot AI dahil çeşitli ücretsiz yapay zeka modelleri sunar. Bu modeller doğal dil işleme konusunda üstündür ve çeşitli geliştirme ihtiyaçlarına uygundur. Modellerin kullanımı ücretsiz olsa da, hız sınırlarına tabidir. Ayrıca, OpenRouter daha gelişmiş gereksinimler için Claude, OpenAI, Grok, Gemini ve Nova gibi ücretli modeller de sunar.

**[⬆️ Başa Dön](#table-of-contents)**

## CDN ve Koruma

  * [bootstrapcdn.com](https://www.bootstrapcdn.com/) — bootstrap, bootswatch ve fontawesome.io için CDN
  * [cdnjs.com](https://cdnjs.com/) — Basit. Hızlı. Güvenilir. En iyi içerik dağıtımı. cdnjs, Cloudflare tarafından desteklenen, tüm web sitelerinin %11’inden fazlası tarafından güvenilen ücretsiz ve açık kaynaklı bir CDN hizmetidir.
  * [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries, en popüler Açık Kaynak JavaScript kütüphaneleri için bir içerik dağıtım ağıdır
  * [Stellate](https://stellate.co/) - Stellate, GraphQL API’niz için son derece hızlı, güvenilir bir CDN’dir ve iki hizmet için ücretsizdir.
  * [jsdelivr.com](https://www.jsdelivr.com/) — Ücretsiz, hızlı ve güvenilir açık kaynak CDN. npm, GitHub, WordPress, Deno ve daha fazlasını destekler.
  * [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Microsoft Ajax CDN, jQuery gibi popüler üçüncü taraf JavaScript kütüphanelerini barındırır ve bunları Web uygulamanıza kolayca eklemenizi sağlar
  * [ovh.ie](https://www.ovh.ie/ssl-gateway/) — Ücretsiz DDoS koruması ve SSL sertifikası
  * [Skypack](https://www.skypack.dev/) — %100 Yerel ES Module JavaScript CDN. Alan adı başına ayda 1 milyon istek için ücretsizdir.
  * [raw.githack.com](https://raw.githack.com/) — Cloudflare kullanarak dosya barındıran **rawgit.com**’un modern bir alternatifi
  * [section.io](https://www.section.io/) — Tam bir Varnish Cache çözümünü kurmanın ve yönetmenin basit bir yolu. Bir site için sonsuza kadar ücretsiz olduğu iddia ediliyor
  * [statically.io](https://statically.io/) — Git depoları (GitHub, GitLab, Bitbucket), WordPress ile ilgili varlıklar ve görseller için CDN
  * [toranproxy.com](https://toranproxy.com/) — Packagist ve GitHub için proxy. CD’niz asla başarısız olmasın. Kişisel kullanım için ücretsiz, bir geliştirici, destek yok
  * [UNPKG](https://unpkg.com/) — npm’deki her şey için CDN
  * [weserv](https://images.weserv.nl/) — Bir görsel önbellek ve yeniden boyutlandırma hizmeti. Görselleri anında değiştirin, dünya genelinde önbellekle.
  * [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — Ücretsiz DDoS koruması
  * [Gcore](https://gcorelabs.com/) Küresel içerik dağıtım ağı, ayda 1 TB ve 1 milyon istek ücretsiz ve ücretsiz DNS barındırma
  * [CacheFly](https://portal.cachefly.com/signup/free2023) - Ayda 5 TB’a kadar ücretsiz CDN trafiği, 19 Çekirdek PoP, 1 Alan Adı ve Evrensel SSL.

**[⬆️ Başa Dön](#table-of-contents)**

## PaaS

  * [anvil.works](https://anvil.works) - Sadece Python ile web uygulaması geliştirme. Ücretsiz katmanda sınırsız uygulama ve 30 saniyelik zaman aşımı.
  * [appwrite](https://appwrite.io) - Sınırsız proje, proje duraklatma yok (websockets destekler) ve kimlik doğrulama hizmeti. Ücretsiz katmanda proje başına 1 Veritabanı, 3 Kova, 5 Fonksiyon.
  * [configure.it](https://www.configure.it/) — Mobil uygulama geliştirme platformu, iki proje için ücretsiz, özellikler sınırlı ancak kaynak sınırı yok
  * [codenameone.com](https://www.codenameone.com/) — Java/Kotlin geliştiricileri için açık kaynak, çapraz platform, mobil uygulama geliştirme zinciri. Sınırsız proje ile ticari kullanım için ücretsiz
  * [deco.cx](https://www.deco.cx/en/dev) - TypeScript kodundan otomatik oluşturulan görsel CMS ile uçta çalışan frontend platformu. Dahili A/B testi, içerik segmentasyonu ve gerçek zamanlı analizler. İçerik ağırlıklı ve kurumsal e-ticaret siteleri için idealdir. Ayda 5 bin sayfa görüntülemeye kadar veya açık kaynak/kişisel projeler için ücretsiz.
  * [Deno Deploy](https://deno.com/deploy) - JavaScript, TypeScript ve WebAssembly’yi dünya genelinde uçta çalıştıran dağıtık sistem. Ücretsiz katman, günlük 100.000 istek ve ayda 100 GiB veri aktarımı içerir.
  * [domcloud.co](https://domcloud.co) – GitHub ile CI/CD, SSH ve MariaDB/Postgres veritabanı sağlayan Linux barındırma hizmeti. Ücretsiz sürüm, 1 GB depolama ve 1 GB ağ/ay sınırı ve yalnızca bir ücretsiz alan adı ile sınırlıdır.
  * [encore.dev](https://encore.dev/) — Otomatik altyapı, şablonsuz kod ve daha fazlasını sağlamak için statik analiz kullanan arka uç çerçevesi. Hobi projeleri için ücretsiz bulut barındırma içerir.
  * [flightcontrol.dev](https://flightcontrol.dev/) - Web servislerini, veritabanlarını ve daha fazlasını kendi AWS hesabınızda Git push tarzı iş akışıyla dağıtın. Kişisel GitHub depolarında 1 geliştirici için ücretsiz katman. AWS maliyetleri AWS üzerinden faturalandırılır ancak krediler ve AWS ücretsiz katmanı kullanılabilir.
  * [gigalixir.com](https://gigalixir.com/) - Gigalixir, asla uyumayan bir ücretsiz örnek ve Elixir/Phoenix uygulamaları için 2 bağlantı, 10.000 satır ve yedekleme olmayan ücretsiz katman PostgreSQL veritabanı sunar.
  * [Glitch](https://glitch.com/) — Kod paylaşımı ve gerçek zamanlı işbirliği özellikleriyle ücretsiz genel barındırma. Ücretsiz planın aylık 1000 saatlik bir sınırı vardır.
  * [leapcell](https://leapcell.io/) - Leapcell, hızlı büyümenizi sorunsuzca desteklemek için ihtiyacınız olan her şeyi sağlayan güvenilir bir dağıtık uygulama platformudur. Ücretsiz plan, 100 bin hizmet çağrısı, 10 bin asenkron görev ve 100 bin Redis komutu içerir.
  * [pipedream.com](https://pipedream.com) - Geliştiriciler için oluşturulmuş bir entegrasyon platformu. Herhangi bir tetikleyiciye dayalı herhangi bir iş akışını geliştirin. İş akışları, [ücretsiz olarak](https://docs.pipedream.com/pricing/) çalıştırabileceğiniz kodlardır. Sunucu veya bulut kaynağı yönetimi yok.
  * [pythonanywhere.com](https://www.pythonanywhere.com/) — Bulut Python uygulama barındırma. Başlangıç hesabı ücretsizdir, your-username.pythonanywhere.com alan adında 1 Python web uygulaması, 512 MB özel dosya depolama, bir MySQL veritabanı
  * [ampt.dev](https://getampt.com/) - Ampt, ekiplerin JavaScript uygulamalarını karmaşık yapılandırmalar veya altyapı yönetimi olmadan AWS üzerinde oluşturmasını, dağıtmasını ve ölçeklendirmesini sağlar. Ücretsiz Önizleme planı, saatte 500 çağrı, günde 2.500 çağrı ve ayda 50.000 çağrı içerir. Özel alan adları yalnızca ücretli planlarda izinlidir.
  * [Koyeb](https://www.koyeb.com) - Koyeb, geliştirici dostu sunucusuz bir platformdur, uygulamaları küresel olarak dağıtmanıza olanak tanır. Docker konteynerlerini, web uygulamalarını ve API’leri git tabanlı dağıtım, yerel otomatik ölçeklendirme, küresel uç ağı ve yerleşik servis ağı ve keşfiyle sorunsuzca çalıştırın. Ücretsiz örnek, Frankfurt, Almanya veya Washington, D.C., ABD’de bir web hizmeti dağıtmanıza izin verir. Ücretsiz Yönetilen Postgres veritabanı Frankfurt (Almanya), Washington, D.C. (ABD) ve Singapur’da mevcuttur. 512MB bellek, 2GB depolama ve 0,1 CPU.
  * [Napkin](https://www.napkin.io/) - FaaS, 500Mb bellek, varsayılan 15 saniye zaman aşımı ve ayda 5.000 ücretsiz API çağrısı, saniyede 5 çağrı ile sınırlandırılmıştır.
  * [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy barındırma. Meteor uygulamaları için platform hizmeti, ücretsiz MongoDB Paylaşımlı Barındırma ve otomatik SSL içerir.
  * [Northflank](https://northflank.com) — Güçlü bir UI, API & CLI ile mikroservisler, işler ve yönetilen veritabanları oluşturun ve dağıtın. Sürüm kontrolünden ve harici Docker kayıtlarından konteynerleri sorunsuzca ölçeklendirin. Ücretsiz katman, iki hizmet, iki zamanlanmış iş ve 1 veritabanı içerir.
  * [YepCode](https://yepcode.io) - API’leri ve hizmetleri sunucusuz bir ortamda bağlamak için hepsi bir arada platform. NoCode araçlarının tüm çevikliğini ve avantajlarını programlama dilleriyle birleştirir. Ücretsiz katman [1.000 yep](https://yepcode.io/pricing/) içerir.
  * [WunderGraph](https://cloud.wundergraph.com) - Modern API’leri hızlıca oluşturmanızı, göndermenizi ve yönetmenizi sağlayan açık kaynaklı bir platform. Yerleşik CI/CD, GitHub entegrasyonu ve otomatik HTTPS. [Ücretsiz planda](https://wundergraph.com/pricing) 3 projeye, 1GB çıkışa, ayda 300 dakika derleme süresine kadar.
  * [Zeabur](https://zeabur.com) - Hizmetlerinizi tek tıklamayla dağıtın. Üç hizmet için ücretsiz, ayda 5 ABD Doları değerinde ücretsiz kredi.
  * [mogenius](https://mogenius.com) - Kubernetes üzerinde kolayca hizmet oluşturun, dağıtın ve çalıştırın. Ücretsiz katman, yerel Kubernetes’inizi mogenius ile bağlamayı destekler, bireysel geliştiricilerin makinelerinde üretime benzer test ortamı oluşturmalarını sağlar.
  * [genezio](https://genezio.com/) - Sunucusuz fonksiyon sağlayıcısı, ticari olmayan veya akademik kullanım için ayda 1 milyon fonksiyon çağrısı, 100GB bant genişliği ve 10 zamanlanmış iş ücretsiz sunar.

**[⬆️ Başa Dön](#table-of-contents)**

## BaaS

  * [Activepieces](https://www.activepieces.com) - Uygulamanızın arka ucunda çeşitli uygulamaları birbirine bağlamak için otomasyon akışları oluşturun. Örneğin, uygulamanızda bir olay tetiklendiğinde bir Slack mesajı gönderin veya bir Google Sheet satırı ekleyin. Ayda 5.000 göreve kadar ücretsizdir.
  * [back4app.com](https://www.back4app.com) - Back4App, Parse Platform’a dayalı, kullanımı kolay, esnek ve ölçeklenebilir bir arka uçtur.
  * [backendless.com](https://backendless.com/) — Mobil ve Web Baas, 1 GB ücretsiz dosya depolama, 50.000/ay push bildirimi ve tabloda 1000 veri nesnesi ile birlikte.
  * [bismuth.cloud](https://www.bismuth.cloud/) — Yapay zekamız, Python API’nizi fonksiyon çalıştırma ortamımızda ve barındırılan depolamamızda başlatacak, ücretsiz olarak çevrimiçi editörümüzde veya favori araçlarınızla yerel olarak oluşturun ve barındırın.
  * [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — BMC Developer Program, işletmeniz için dijital yenilikler oluşturmak ve dağıtmak için dokümantasyon ve kaynaklar sağlar. Platformu, SDK’yı ve uygulama oluşturmak ve uyarlamak için kullanılabilecek bileşen kütüphanesini içeren kapsamlı, kişisel bir sanal alan erişimi.
  * [connectycube.com](https://connectycube.com) - Sınırsız sohbet mesajı, p2p ses & video aramaları, dosya ekleri ve push bildirimi. Uygulama başına 1000 kullanıcıya kadar ücretsiz.
  * [convex.dev](https://convex.dev/) - Veri (ilişkili belgeler & seri hale getirilebilir ACID işlemler), sunucusuz fonksiyonlar ve çeşitli istemcilere anlık güncellemeler için WebSocket barındıran reaktif arka uç hizmeti. Küçük projeler için ücretsiz - 1M kayıt, aylık 5M fonksiyon çağrısı.
  * [darklang.com](https://darklang.com/) - Barındırılan dil, editör ve altyapı bir arada. Beta süresince erişilebilir, betadan sonra cömert bir ücretsiz katman planlanıyor.
  * [Firebase](https://firebase.com) — Firebase, başarılı uygulamalar oluşturmanıza ve çalıştırmanıza yardımcı olur. Ücretsiz Spark Planı, Kimlik Doğrulama, Barındırma, Firebase ML, Gerçek Zamanlı Veritabanı, Bulut Depolama, Testlab sunar. A/B Testi, Analitik, Uygulama Dağıtımı, Uygulama Dizinleme, Bulut Mesajlaşma (FCM), Crashlytics, Dinamik Bağlantılar, Uygulama İçi Mesajlaşma, Performans İzleme, Tahminler ve Uzaktan Yapılandırma her zaman ücretsizdir.
  * [Flutter Flow](https://flutterflow.io) — Tek satır kod yazmadan Flutter Uygulama Arayüzünüzü oluşturun. Ayrıca Firebase entegrasyonu da vardır. Ücretsiz planda UI Builder’a tam erişim ve ücretsiz şablonlar bulunur.
  * [getstream.io](https://getstream.io/) — Haftalar yerine birkaç saat içinde ölçeklenebilir Uygulama İçi Sohbet, Mesajlaşma, Video ve ses ile Akışlar oluşturun
  * [hasura.io](https://hasura.io/) — Hasura, mevcut veritabanlarınızı nerede barındırılırsa barındırılsın genişletir ve web, mobil ve veri entegrasyon iş yükleri için güvenli bir şekilde erişilebilen anında bir GraphQL API sağlar. Ayda 1GB veri geçişi ücretsizdir.
  * [nhost.io](https://nhost.io) - Web ve mobil uygulamalar için sunucusuz arka uç. Ücretsiz plan, PostgreSQL, GraphQL (Hasura), Kimlik Doğrulama, Depolama ve Sunucusuz Fonksiyonlar içerir.
  * [onesignal.com](https://onesignal.com/) — Sınırsız ücretsiz push bildirimi. Ayda 10.000 e-posta gönderimi, sınırsız kişi ve Otomatik Isıtma erişimi.
  * [paraio.com](https://paraio.com) — Esnek kimlik doğrulama, tam metin arama ve önbellekleme özellikli arka uç hizmet API’si. Bir uygulama, 1GB uygulama verisi için ücretsizdir.
  * [pubnub.com](https://www.pubnub.com/) — Aylık 1 milyon mesaja ve günlük 100 aktif cihaza kadar ücretsiz push bildirimleri
  * [pushbots.com](https://pushbots.com/) — Push bildirim servisi. Aylık 1,5 milyon push'a kadar ücretsiz
  * [pushcrew.com](https://pushcrew.com/) — Push bildirim servisi. 2.000 aboneye kadar sınırsız bildirim
  * [pusher.com](https://pusher.com/beams) — Aylık 2000 aktif kullanıcı için ücretsiz, sınırsız push bildirimi. iOS ve Android cihazlar için tek bir API.
  * [quickblox.com](https://quickblox.com/) — Anlık mesajlaşma, video ve sesli arama, push bildirimleri için iletişim altyapısı
  * [restspace.io](https://restspace.io/) - Kimlik doğrulama, veri, dosya, e-posta API'si, şablonlar ve daha fazlası için hizmetlerle bir sunucu yapılandırın, ardından ardışık düzenlere birleştirin ve verileri dönüştürün.
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — Sürükle-bırak araçlarla hızlı uygulama geliştirin. Veri modelinizi tıklamalarla özelleştirin. Apex koduyla daha ileri gidin. Güçlü API’lerle her şeyle entegre olun. Kurumsal düzeyde güvenlikle korunun. UI’ı tıklamalarla veya lider web framework’leriyle özelleştirin. Ücretsiz Geliştirici Programı, tüm Lightning Platform'a erişim sağlar.
  * [simperium.com](https://simperium.com/) — Verileri anında ve otomatik olarak her yere taşıyın, çoklu platform, yapılandırılmış verilerin sınırsız gönderimi ve depolaması, aylık maksimum 2.500 kullanıcı
  * [Supabase](https://supabase.com) — Backend oluşturmak için Açık Kaynak Firebase Alternatifi. Ücretsiz Plan Kimlik Doğrulama, Gerçek Zamanlı Veritabanı ve Nesne Depolama sunar.
  * [tyk.io](https://tyk.io/) — Kimlik doğrulama, kota, izleme ve analiz ile API yönetimi. Ücretsiz bulut seçeneği
  * [zapier.com](https://zapier.com/) — Kullandığınız uygulamaları birbirine bağlayarak görevleri otomatikleştirin. Her 15 dakikada bir beş zap ve aylık 100 görev
  * [IFTTT](https://ifttt.com) — Favori uygulama ve cihazlarınızı otomatikleştirin. Ücretsiz 2 Applet
  * [Integrately](https://integrately.com) — Sıkıcı görevleri tek tıkla otomatikleştirin. Ücretsiz 100 Görev, 15 Dakika Güncelleme Süresi, beş aktif otomasyon, webhooklar.
  * [LeanCloud](https://leancloud.app/) — Mobil backend. 1GB veri depolama, 256MB instance, günlük 3K API isteği ve 10K push ücretsiz. (API, Parse Platform’a çok benzer)
  * [Claw.cloud](https://run.claw.cloud) - 180 günden eski GitHub hesabı olan kullanıcılar için aylık 5$ ücretsiz kredi sunan bir PaaS platformu. Uygulamalar, veritabanları ve daha fazlasını barındırmak için idealdir. ([Ücretsiz krediyle kayıt linki](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ Başa Dön](#table-of-contents)**

## Düşük Kodlu Platform

  * [appsmith](https://www.appsmith.com/) — Yönetim panelleri, dahili araçlar ve gösterge tabloları oluşturmak için düşük kodlu proje. 15'ten fazla veritabanı ve herhangi bir API ile entegre olur.
  * [Basedash](https://www.basedash.com) — Dahili yönetim panelleri ve gösterge tabloları oluşturmak için düşük kodlu platform. SQL veritabanları ve REST API'leri destekler.
  * [BudiBase](https://budibase.com/) — Budibase, dakikalar içinde dahili uygulamalar oluşturmak için açık kaynaklı düşük kodlu bir platformdur. PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s destekler
  * [Clappia](https://www.clappia.com) — Sürükle-bırak arayüzüyle özelleştirilebilir mobil ve web uygulamaları ile iş süreçleri uygulamaları oluşturmak için tasarlanmış düşük kodlu platform. Offline Desteği, gerçek zamanlı konum takibi ve çeşitli üçüncü parti hizmetlerle entegrasyon gibi özellikler sunar.
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ, mühendislik ekiplerinin ve ürün yöneticilerinin dahili araçlar, özel kullanıcı yolculukları, dijital deneyimler, otomasyon, özel yönetim panelleri, operasyonel uygulamalarını 10 kat daha hızlı geliştirmelerine yardımcı olan düşük kodlu platform.
  * [lil'bots](https://www.lilbots.io/) - OpenAI, Anthropic, Firecrawl ve diğerleri gibi yerleşik ücretsiz API'leri kullanarak çevrimiçi betikler yazın ve çalıştırın. AI ajanları/dahili araçlar oluşturmak ve takımla paylaşmak için harikadır. Ücretsiz katman, API'lere tam erişim, AI kodlama asistanı ve aylık 10.000 yürütme kredisi içerir.
  * [Mendix](https://www.mendix.com/) — Kurumsal Hızlı Uygulama Geliştirme, sınırsız erişilebilir sandbox ortamları, toplam kullanıcı desteği, uygulama başına 0,5 GB depolama ve 1 GB RAM. Ücretsiz katmanda Studio ve Studio Pro IDE'leri de kullanılabilir.
  * [outsystems.com](https://www.outsystems.com/) — Kurumsal web geliştirme PaaS, yerinde veya bulutta, ücretsiz "kişisel ortam" seçeneği ile sınırsız kod ve 1 GB veritabanına kadar izin verir
  * [ReTool](https://retool.com/) — Dahili uygulamalar oluşturmak için düşük kodlu platform. Retool son derece özelleştirilebilirdir. JavaScript ve bir API ile yazabiliyorsanız, Retool’da yapabilirsiniz. Ücretsiz katman, aylık beş kullanıcıya, sınırsız uygulama ve API bağlantısına izin verir.
  * [Superblocks](https://superblocks.com/) — Geliştiriciler ve yarı-teknik ekipler için tasarlanmış açık kurumsal uygulama platformu. AI ile oluşturun, görsel olarak düzenleyin ve kodla genişletin. Merkezileştirilmiş entegrasyonlar, kimlik doğrulama, izinler ve denetim günlükleriyle yönetin.
  * [ToolJet](https://www.tooljet.com/) — İş uygulamaları oluşturmak için genişletilebilir düşük kodlu framework. Veritabanlarına, bulut depolamalara, GraphQL, API uç noktalarına, Airtable vb. bağlanın ve sürükle-bırak uygulama oluşturucu ile uygulamalar oluşturun.
  * [UI Bakery](https://uibakery.io) — Özel web uygulamalarını daha hızlı oluşturmayı sağlayan düşük kodlu platform. JavaScript, Python ve SQL ile üst düzey özelleştirme yaparak sürükle-bırak ile arayüz oluşturmayı destekler. Hem bulut hem de kendi sunucunda kullanılabilir. 5 kullanıcıya kadar ücretsizdir.
  * [manubes](https://www.manubes.com) - Endüstriyel üretim yönetimine odaklanan güçlü kodsuz bulut platformu. Bir kullanıcı için ayda 1 milyon iş akışı aktivitesi ücretsizdir ([almanca da mevcut](https://www.manubes.de)).

**[⬆️ Başa Dön](#table-of-contents)**

## Web Hosting

  * [Alwaysdata](https://www.alwaysdata.com/) — MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, özel web sunucuları desteğiyle 100 MB ücretsiz web barındırma; FTP, WebDAV ve SSH ile erişim; posta kutusu, e-posta listesi ve uygulama yükleyici dahildir.
  * [Awardspace.com](https://www.awardspace.com) — Ücretsiz web hosting + ücretsiz kısa alan adı, PHP, MySQL, Uygulama Yükleyici, E-posta Gönderimi & Reklamsız.
  * [Bohr](https://bohr.io) — Ticari olmayan projeler için ücretsiz + Geliştirici Öncelikli Dağıtım ve Geliştirme Platformu, altyapı zahmetini en aza indirir ve kurulumu hızlandırır.
  * [Bubble](https://bubble.io/) — Web ve mobil uygulamaları kod yazmadan geliştirmek için görsel programlama, Bubble markasıyla ücretsiz.
  * [dAppling Network](https://www.dappling.network/) - Web3 ön uçları için merkeziyetsiz web hosting platformu, çalışma süresi ve güvenliği artırmaya ve kullanıcılar için ek erişim noktası sağlamaya odaklanır.
  * [DigitalOcean](https://www.digitalocean.com/pricing) - App Platform Starter katmanında üç statik siteyi ücretsiz oluşturun ve dağıtın.
  * [Drive To Web](https://drv.tw) — Google Drive & OneDrive’dan doğrudan web'e barındırma. Sadece statik siteler. Sonsuza kadar ücretsiz. Google/Microsoft hesabı başına bir site.
  * [Fenix Web Server](https://preview.fenixwebserver.com) - Siteleri yerelde barındırmak ve gerçek zamanlı olarak herkese açık şekilde paylaşmak için geliştirici masaüstü uygulaması. Güzel kullanıcı arayüzü, API ve/veya CLI ile dilediğiniz gibi çalışın.
  * [Fern](https://buildwithfern.com) - Fern’in ücretsiz planında Markdown tabanlı bir dokümantasyon sitesi oluşturun ve barındırın. API tanım dosyalarından siteniz için otomatik olarak bir API referansı da oluşturabilirsiniz. Site _yoursite_.docs.buildwithfern.com adresinde barındırılır.
  * [Free Hosting](https://freehostingnoads.net/) — PHP 5, Perl, CGI, MySQL, FTP, Dosya Yöneticisi, POP E-Posta, ücretsiz alt alanlar, ücretsiz alan adı barındırma, DNS Alan Editörü, Web Site İstatistikleri, ÜCRETSİZ Çevrimiçi Destek ve diğer ücretsiz hostların sunmadığı birçok özellikle ücretsiz barındırma.
  * [Freehostia](https://www.freehostia.com) — FreeHostia, sektörün en iyi Kontrol Paneli ve 50+ ücretsiz uygulamanın 1 tıkla kurulumu dahil olmak üzere ücretsiz barındırma hizmetleri sunar. Anında kurulum. Zorunlu reklam yok.
  * [HelioHost](https://heliohost.org) — Plesk kontrol paneli, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, IMAP/POP3/SMTP e-posta, sınırsız bant genişliği, ücretsiz alt alanlar, ücretsiz yükseltme seçeneğiyle 1000 MB depolama ile kar amacı gütmeyen ücretsiz web hosting.
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — Ücretsiz 100 statik site dağıtımı, SSL’li özel alan adları, aylık 100 GB bant genişliği, 260+ Cloudflare CDN lokasyonu.
  * [Lecturify](https://www.lecturify.net/index.en.html) - Dosya yükleme ve indirme için SFPT erişimli web hosting, php mevcut.
  * [Neocities](https://neocities.org) — Statik, 1 GB ücretsiz depolama ve 200 GB bant genişliği.
  * [Netlify](https://www.netlify.com/) — Statik site/uygulama oluşturur, dağıtır ve barındırır; 100 GB veri ve aylık 100 GB bant genişliği ücretsiz.
  * [pantheon.io](https://pantheon.io/) — Drupal ve WordPress barındırma, otomatik DevOps ve ölçeklenebilir altyapı. Geliştiriciler ve ajanslar için ücretsiz. Özel alan adı yok.
  * [readthedocs.org](https://readthedocs.org/) — Sürüm kontrolü, PDF oluşturma ve daha fazlasıyla ücretsiz dokümantasyon barındırma
  * [render.com](https://render.com) — Web servisleri, veritabanları ve statik web sayfaları için tamamen ücretsiz planlar, ücretsiz SSL, global CDN, özel ağlar, Git'ten otomatik dağıtım ile birleşik bulut.
  * [SourceForge](https://sourceforge.net/) — Açık Kaynak yazılımı ücretsiz bul, oluştur ve yayımla
  * [surge.sh](https://surge.sh/) — Front-End geliştiricileri için statik web yayını. Özel alan adı desteğiyle sınırsız site
  * [telegra.ph](https://telegra.ph/) Quill kullanarak kolayca web sayfası oluşturun
  * [tilda.cc](https://tilda.cc/) — Bir site, 50 sayfa, 50 MB depolama, 170+ ön tanımlı bloktan yalnızca ana bloklar, font yok, favicon yok, özel alan adı yok
  * [Vercel](https://vercel.com/) — Ücretsiz SSL, global CDN ve her `git push` ile benzersiz Önizleme URL'leriyle web uygulamaları oluşturun, dağıtın ve barındırın. Next.js ve diğer Statik Site Üreteçleri için idealdir.
  * [Versoly](https://versoly.com/) — SaaS odaklı site oluşturucu - sınırsız web sitesi, 70+ blok, beş şablon, özel CSS, favicon, SEO ve formlar. Özel alan adı yok.
  * [Qoddi](https://qoddi.com) - Heroku'ya benzer, geliştirici odaklı ve her şey dahil özelliklere sahip bir PaaS hizmeti. Statik varlıklar, hazırlık ve geliştirici uygulamaları için ücretsiz katman.
  * [FreeFlarum](https://freeflarum.com/) - 250 kullanıcıya kadar topluluk destekli ücretsiz Flarum barındırma (altbilgideki filigranı kaldırmak için bağış yapabilirsiniz).
  * [MDB GO](https://mdbgo.com/) - İki hafta Konteyner TTL'si, proje başına 500 MB RAM, SFTP - 1G disk alanı ile bir proje için ücretsiz barındırma.
  * [Patr Cloud](https://patr.cloud/) — Kullanımı kolay bulut platformu, ücretli hizmetlerinin yanı sıra üç statik siteyi ücretsiz barındırma imkânı sunar.
  * [Serv00.com](https://serv00.com/) — Günlük yedeklemeli (7 gün) 3 GB ücretsiz web hosting. Destek: Crontab işleri, SSH erişimi, depolar (GIT, SVN ve Mercurial), destek: MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R ve daha fazlası.
  - [Sevalla](https://sevalla.com/) - Uygulama, veritabanı ve statik web sitesi dağıtım ve yönetimini kolaylaştırmak için tasarlanmış hosting platformu - 1GB site limiti, 100GB ücretsiz bant genişliği, 600 ücretsiz derleme dakikası, hesap başına 100 site.

**[⬆️ Başa Dön](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Cloudflare tarafından sunulan hızlı ve güvenli (DNS sorgunuzu şifreler) ücretsiz genel DNS Çözücüsü. İnternet sağlayıcınızın DNS engellemesini aşmak, DNS sorgu casusluğunu önlemek ve [yetişkin & zararlı içerikleri engellemek](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families) için kullanışlıdır. [API ile de kullanılabilir](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests). Not: Sadece DNS çözücüsüdür, DNS barındırıcısı değildir.
  * [1984.is](https://www.1984.is/product/freedns/) — API ve birçok başka ücretsiz DNS özelliği içeren ücretsiz DNS servisi.
  * [cloudns.net](https://www.cloudns.net/) — 1 alan adına kadar 50 kayıtla ücretsiz DNS barındırma
  * [deSEC](https://desec.io) - API desteği ile ücretsiz DNS barındırma, güvenlik ön planda tutularak tasarlanmıştır. Açık kaynak yazılım üzerinde çalışır ve [SSE](https://www.securesystems.de/) tarafından desteklenir.
  * [dns.he.net](https://dns.he.net/) — Dinamik DNS Desteği ile ücretsiz DNS barındırma hizmeti
  * [Zonomi](https://zonomi.com/) — Anında DNS yayılımı ile ücretsiz DNS barındırma servisi. Ücretsiz plan: 1 DNS bölgesi (alan adı) ve 10 DNS kaydına kadar.
  * [dnspod.com](https://www.dnspod.com/) — Ücretsiz DNS barındırma.
  * [duckdns.org](https://www.duckdns.org/) — Ücretsiz DDNS, ücretsiz katmanda 5 alan adına kadar. Çeşitli kurulumlar için yapılandırma rehberleri ile.
  * [Dynv6.com](https://dynv6.com/) — [API desteği](https://dynv6.com/docs/apis) ve birçok dns kayıt türünü (CNAME, MX, SPF, SRV, TXT ve diğerleri gibi) yönetme imkanı ile ücretsiz DDNS hizmeti.
  * [freedns.afraid.org](https://freedns.afraid.org/) — Ücretsiz DNS barındırma. Ayrıca, çok sayıda genel kullanıcı [katkılı alan adına](https://freedns.afraid.org/domain/registry/) dayalı ücretsiz alt alanlar sağlar. Kayıt olduktan sonra "Subdomains" menüsünden ücretsiz alt alanlar alınabilir.
  * [luadns.com](https://www.luadns.com/) — Ücretsiz DNS barındırma, üç alan adı, tüm özellikler makul sınırlarla
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — Ücretsiz DNS. Alan adı sayısında sınır yok
  * [nextdns.io](https://nextdns.io) - DNS tabanlı güvenlik duvarı, aylık 300K ücretsiz sorgu
  * [noip.at](https://noip.at/) — Kayıt, takip, günlük tutma veya reklam olmadan ücretsiz DDNS servisi. Alan adı sınırı yok.
  * [noip](https://www.noip.com/) — Dinamik DNS servisi, her 30 günde bir onayla 3 ana bilgisayar adına kadar ücretsiz
  * [sslip.io](https://sslip.io/) — Sorgulandığında, içine gömülü IP adresi olan bir ana bilgisayar adıyla o IP adresini döndüren ücretsiz DNS servisi.
  * [zilore.com](https://zilore.com/en/dns) — 5 alan adı için ücretsiz DNS barındırma.
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — Dinamik DNS Desteği ile ücretsiz DNS barındırma.
  * [zonewatcher.com](https://zonewatcher.com) — Otomatik yedekleme ve DNS değişiklik izleme. Bir alan adı ücretsiz
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Huawei tarafından ücretsiz DNS barındırma
  * [Hetzner](https://www.hetzner.com/dns-console) – Hetzner’den API destekli ücretsiz DNS barındırma.
  * [Glauca](https://docs.glauca.digital/hexdns/) – 3 alan adına kadar ücretsiz DNS barındırma ve DNSSEC desteği
  * [VolaryDDNS](https://volaryddns.net) - Abonelik veya reklam olmadan ücretsiz yüksek performanslı DDNS
**[⬆️ Başa Dön](#table-of-contents)**

## Alan Adı

  * [pp.ua](https://nic.ua/) — Ücretsiz pp.ua alt alan adları.
  * [us.kg](https://nic.us.kg/) - Ücretsiz us.kg alt alan adları.

**[⬆️ Başa Dön](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — AWS S3 ile uyumlu - API'ler, arayüz işlemleri, CLI ve diğer yükleme yöntemleriyle IPFS ve Arweave ağlarından dosya yükleyip saklamayı güvenli, pratik ve verimli şekilde sağlar. Kayıtlı kullanıcılar 6 GB IPFS depolama ve 300MB Arweave depolamayı ücretsiz alır. 150 KB'tan küçük Arweave dosya yüklemeleri ücretsizdir.
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 bulut depolama. Sınırsız süreyle ücretsiz 10 GB (Amazon S3 benzeri) nesne depolama
  * [filebase.com](https://filebase.com/) - Blokzincir destekli, S3 uyumlu nesne depolama. Sınırsız süreyle ücretsiz 5 GB depolama.
  * [Tebi](https://tebi.io/) - S3 uyumlu nesne depolama. Ücretsiz 25 GB depolama ve 250GB çıkış transferi.
  * [Idrive e2](https://www.idrive.com/e2/) - S3 uyumlu nesne depolama. Aylık 10 GB ücretsiz depolama ve 10 GB indirme bant genişliği.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - S3 uyumlu nesne depolama. Aylık 15 GB ücretsiz depolama ve 15 GB indirme.

**[⬆️ Başa Dön](#table-of-contents)**

## Yönetilen Veri Servisleri

  * [Aiven](https://aiven.io/) - Aiven, açık kaynak veri platformunda ücretsiz PostgreSQL, MySQL ve Redis planları sunar. Tek düğüm, 1 CPU, 1GB RAM ve PostgreSQL ve MySQL için 5GB depolama. Daha kapsamlı planlara veya bulutlar arası kolay geçiş.
  * [airtable.com](https://airtable.com/) — Elektronik tabloya benzer, ilişkisel veritabanı. Sınırsız temel, 1.200 satır/taban ve aylık 1.000 API isteği.
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Bulut tabanlı Cassandra Hizmeti, [80GB ücretsiz katman](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — Kullanımı kolay JavaScript sunucusuz API/backend ve NoSQL veritabanı servisi; fonksiyonlar, Mongdb benzeri sorgular, anahtar/değer aramaları, iş sistemi, gerçek zamanlı mesajlar, işçi kuyrukları, güçlü bir CLI ve web tabanlı veri yöneticisiyle birlikte gelir. Ücretsiz planda 5GB depolama ve dakikada 60 API çağrısı. 2 geliştirici dahildir. Kredi kartı gerekmez.
  * [CrateDB](https://crate.io/) - Gerçek zamanlı analizler için dağıtık Açık Kaynak SQL veritabanı. [Ücretsiz Katman CRFREE](https://crate.io/lp-crfree): 2 CPU, 2 GiB bellek, 8 GiB depolama ile tek düğüm. Kuruluş başına bir küme, ödeme yöntemi gerekmez.
  * [Upstash](https://upstash.com/) — Sunucusuz Redis, günlük 10.000 isteğe, 256MB maksimum veritabanı boyutuna ve 20 eşzamanlı bağlantıya kadar ücretsiz katman
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - IoT'den AI'a yeni nesil uygulamalar oluşturmak için geliştiricilere yönelik, sürekli ücretsiz katmanla tam yönetilen veritabanı kümesi.
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — ücretsiz katman 512 MB sunar
  * [redsmin.com](https://www.redsmin.com/) — Redis için çevrimiçi gerçek zamanlı izleme ve yönetim servisi, 1 Redis örneği için ücretsiz izleme
  * [redislabs](https://redislabs.com/try-free/) - Ücretsiz 30MB redis örneği
  * [MemCachier](https://www.memcachier.com/) — Yönetilen Memcache servisi. 25MB'a, 1 Proxy Sunucuya ve temel analizlere kadar ücretsiz
  * [scalingo.com](https://scalingo.com/) — Aslen bir PaaS ama MySQL, PostgreSQL veya MongoDB için 128MB ila 192MB ücretsiz katman sunar
  * [SeaTable](https://seatable.io/) — Seafile ekibi tarafından geliştirilen, esnek, elektronik tablo benzeri veritabanı. Sınırsız tablo, 2.000 satır, 1 aylık versiyonlama, 25'e kadar ekip üyesi.
  * [skyvia.com](https://skyvia.com/) — Bulut Veri Platformu ücretsiz katman sunar ve tüm planlar beta süresince tamamen ücretsizdir
  * [StackBy](https://stackby.com/) — Elektronik tabloların esnekliğini, veritabanlarının gücünü ve favori iş uygulamalarınızla entegrasyonları birleştiren tek araç. Ücretsiz planda sınırsız kullanıcı, on yığın ve yığın başına 2GB ek dosya.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB, açık kaynaklı MySQL uyumlu dağıtık HTAP RDBMS'dir. TiDB Serverless, her ay 5GB satır depolama, 5GB sütun depolama ve 50 milyon İstek Birimi (RU) ücretsiz sağlar.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso, Edge Veritabanında SQLite Geliştirici Deneyimi sunar. Turso, Sürekli Ücretsiz başlangıç planı, toplamda 9 GB depolama, 500'e kadar veritabanı, 3 lokasyona kadar, aylık 1 milyar satır okuma ve SQLite ile yerel geliştirme desteği sağlar.
  * [InfluxDB](https://www.influxdata.com/) — Zaman serisi veritabanı, 3MB/5 dakika yazma, 30MB/5 dakika okuma ve 10.000 kardinalite serisine kadar ücretsiz
  * [restdb.io](https://restdb.io/) - hızlı ve kolay bir NoSQL bulut veritabanı servisi. restdb.io ile şema, ilişkiler, otomatik REST API (MongoDB benzeri sorgularla) ve verilerle çalışmak için verimli çok kullanıcılı yönetim arayüzü elde edersiniz. Ücretsiz plan 3 kullanıcı, 2500 kayıt ve saniyede 1 API isteği sağlar.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — Ücretsiz katman, ayda 50 milyon RU ve 10 GiB depolama (15$ değerinde) sunar. ([İstek Birimi nedir?](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — Cypher sorgu dili ve REST API'ye sahip, yönetilen yerel Grafik DBMS/analitik platformu. Grafik boyutu sınırlamaları (50k düğüm, 175k ilişki).
  * [Neon](https://neon.tech/) — Yönetilen PostgreSQL, toplam 0.5 GB depolama, 1 Proje, 10 dal, Sınırsız Veritabanı, her zaman erişilebilir birincil dal (5 dakika sonra otomatik askıya alınır), birincil olmayan dallar için toplamda aylık 20 saat Aktif süre.
  * [Prisma Postgres](https://prisma.io/postgres) - Unikernel üzerinde çalışan, bare metalde barındırılan, Prisma ORM ile entegre edilmiş, süper hızlı barındırılan Postgres, 1GB depolama, 10 veritabanı.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — GraphQL API'ye sahip yönetilen yerel Grafik DBMS. Günlük 1 MB veri transferi ile sınırlıdır.
  * [Tinybird](https://tinybird.co) - HTTP üzerinden bağlantısız veri alımı ve SQL sorgularını yönetilen HTTP API'ları olarak yayınlamanıza olanak tanıyan sunucusuz yönetilen ClickHouse. Ücretsiz katmanda zaman sınırı yoktur, 10GB depolama + günlük 1000 API isteği.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — SQL benzeri grafik sorgu dili ve REST API'ye sahip, yönetilen yerel Grafik DBMS/analitik platformu. 1 saatlik hareketsizlikten sonra uyuyan, iki vCPU, 8GB Bellek ve 50GB depolama ile bir ücretsiz örnek.
  * [TerminusCMS](https://terminusdb.com/pricing) — Prolog ve Rust ile yazılmış belge ve grafik veritabanı için yönetilen ücretsiz TerminusDB servisi. Geliştiriciler için ücretsiz, kurumsal dağıtımlar ve destek için ücretli servis.
  * [filess.io](https://filess.io) - filess.io, MySQL, MariaDB, MongoDB ve PostgreSQL'den istediğiniz DBMS için ücretsiz olarak veritabanı başına 10 MB'a kadar iki veritabanı oluşturabileceğiniz bir platformdur.
  * [xata.io](https://xata.io) - Xata, yerleşik güçlü arama ve analiz yeteneğine sahip sunucusuz bir veritabanıdır. Tek bir API, çoklu tip güvenli istemci kütüphaneleri ve geliştirme akışınız için optimize edilmiştir. Sürekli ücretsiz katman, hobi geliştiriciler için yeterlidir ve üç Xata birimi ile gelir, birim tanımı için lütfen siteye bakınız.
  * [8base.com](https://www.8base.com/) - 8base, MySQL ve GraphQL üzerinde geliştirilmiş, JavaScript geliştiricileri için oluşturulmuş tam yığın düşük kodlu bir geliştirme platformudur ve sunucusuz arka uç hizmeti sunar. UI uygulama oluşturucu ile hızlıca web uygulamaları geliştirmeye ve hızlıca ölçeklenmeye olanak tanır. Ücretsiz katmanda satır: 2.500, Depolama: 500, Sunucusuz hesaplama: 1Gb/saat, istemci uygulama kullanıcıları: 5.
  * [Nile](https://www.thenile.dev/) — B2B uygulamaları için bir Postgres platformu. Sınırsız veritabanı, her zaman açık, kapatılmayan, toplam 1GB depolama, 50 milyon sorgu tokenı, otomatik ölçeklenme, sınırsız vektör gömme

**[⬆️ Başa Dön](#table-of-contents)**

## Tünelleme, WebRTC, Web Socket Sunucuları ve Diğer Yönlendiriciler

  * [Pinggy](https://pinggy.io) — Tek komutla localhost için herkese açık URL, indirme gerektirmez. HTTPS / TCP / TLS tünelleri. Ücretsiz planda tünel ömrü 60 dakikadır.
  * [conveyor.cloud](https://conveyor.cloud/) — IIS Express'i yerel ağa veya tünel üzerinden herkese açık bir URL'ye açmak için Visual Studio eklentisi.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi, LAN benzeri ağları dağıtık ekiplere güvenli bir şekilde genişletmenizi sağlayan barındırılan bir VPN servisidir. Ücretsiz plan, sınırsız ağda 5 kişiye kadar izin verir.
  * [Mirna Sockets](https://mirna.cloud/) - Web Socket Sunucu kodunuzu dağıttığınızda size bir wss:// URL'si veren ve performansını izlemenize olanak tanıyan Ücretsiz Socket as a Service Platformu.
  * [localhost.run](https://localhost.run/) — Yerel olarak çalışan sunucuları tünel üzerinden herkese açık bir URL'ye açın.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — Yerel sunucuları tünel üzerinden herkese açık bir URL'ye açın. Ücretsiz barındırılan sürüm ve [açık kaynak](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — Yerel olarak çalışan sunucuları tünel üzerinden herkese açık bir URL'ye açın.
  * [cname.dev](https://cname.dev/) — Ücretsiz ve güvenli dinamik ters proxy servisi.
  * [serveo](https://serveo.net/) — Yerel sunucuları internete açın. Kurulum yok, kayıt gerekmez. Ücretsiz alt alan adı, sınırsız.
  * [Radmin VPN](https://www.radmin-vpn.com/) — VPN ile birden fazla bilgisayarı LAN benzeri ağda birleştirin. Sınırsız eş. (Hamachi alternatifi)
  * [segment.com](https://segment.com/) — Olayları diğer üçüncü parti servislere çevirmek ve yönlendirmek için merkez. Ayda 100.000 olaya kadar ücretsiz
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — Açık kaynak WireGuard protokolünü kullanan sıfır yapılandırmalı VPN. MacOS, iOS, Windows, Linux ve Android cihazlara kurulur. Kişisel kullanım için ücretsiz plan; 100 cihaz ve üç kullanıcıya kadar.
  * [webhookrelay.com](https://webhookrelay.com) — Tüm webhooklarınızı yönetme, hata ayıklama, çoğaltma ve proxy'leme; ayrıca özel (ör. localhost) hedeflere veya sunucuları genel HTTP uç noktasına (örn. `https://yoursubdomain.webrelay.io <----> http://localhost:8080`) tünel üzerinden açma.
  * [Hookdeck](https://hookdeck.com/pricing) — Webhooklarınızı her yerden geliştirin, test edin ve izleyin. Aylık 100K istek ve 100K deneme, üç günlük saklama ile ücretsiz.
  * [Xirsys](https://www.xirsys.com/pricing/) — Sınırsız STUN kullanımı + aylık 500 MB TURN bant genişliği, sınırlandırılmış bant genişliği, tek coğrafi bölge.
  * [ZeroTier](https://www.zerotier.com) — FOSS yönetilen sanal Ethernet hizmeti. Ücretsiz planda 25 istemcili sınırsız uçtan uca şifreli ağlar. Masaüstü/mobil istemciler/NA; özel ağlarda yeni istemci düğümlerinin onayı ve özel yönlendirme kuralları için web arayüzü
  * [LocalXpose](https://localxpose.io) — Localhost sunucularınızı internete açan ters proxy. Ücretsiz planda tünel ömrü 15 dakikadır.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - Yerel çalışan servisleri tünel üzerinden herkese açık özel bir URL'ye yayınlayın ve erişim kontrolü ile güvenli hale getirin. Bir kümede 5 servise kadar ücretsiz.
  * [Expose](https://expose.dev/) - Yerel siteleri güvenli tüneller üzerinden açın. Ücretsiz planda AB sunucusu, rastgele alt alanlar ve tek kullanıcı dahildir.
  * [btunnel](https://www.btunnel.in/) — Localhost ve yerel tcp sunucusunu internete açın. Ücretsiz planda dosya sunucusu, özel http istek ve yanıt başlıkları, temel kimlik doğrulama ve 1 saat tünel zaman aşımı bulunur.

**[⬆️ Başa Dön](#table-of-contents)**

## Hata Takibi ve Proje Yönetimi

  * [acunote.com](https://www.acunote.com/) — 5 ekip üyesine kadar ücretsiz proje yönetimi ve SCRUM yazılımı
  * [asana.com](https://asana.com/) — İşbirlikçili özel projeler için ücretsiz
  * [Backlog](https://backlog.com) — Ekibinizin harika projeler üretmesi için ihtiyacı olan her şey tek platformda. Ücretsiz plan, 1 Proje, on kullanıcı ve 100MB depolama sunar.
  * [Basecamp](https://basecamp.com/personal) - Yapılacaklar listeleri, kilometre taşı yönetimi, forum benzeri mesajlaşma, dosya paylaşımı ve zaman takibi. 3 projeye, 20 kullanıcıya ve 1GB depolama alanına kadar.
  * [bitrix24.com](https://www.bitrix24.com/) — Intranet ve proje yönetim aracı. Ücretsiz planda sınırsız kullanıcı için 5GB.
  * [cacoo.com](https://cacoo.com/) — Çevrimiçi gerçek zamanlı diyagramlar: akış diyagramı, UML, ağ. Diyagram başına maksimum 15 kullanıcı, 25 sayfa ücretsiz
  * [Chpokify](https://chpokify.com/) — Sprint tahmininde zaman kazandıran, ekip tabanlı Planning Poker. 5 kullanıcıya kadar ücretsiz, ücretsiz Jira entegrasyonu, sınırsız video arama, sınırsız ekip, sınırsız oturum.
  * [clickup.com](https://clickup.com/) — Proje yönetimi. Ücretsiz, bulut depolama ile premium sürüm. Mobil uygulamalar ve Git entegrasyonları mevcut.
  * [Clockify](https://clockify.me) - Çalışma saatlerinizi projelere göre takip etmenizi sağlayan zaman takip ve çizelgeleme uygulaması. Sınırsız kullanıcı, sonsuza kadar ücretsiz.
  * [Cloudcraft](https://cloudcraft.co/) — Cloudcraft görsel tasarımcı ile dakikalar içinde profesyonel mimari diyagramı oluşturun, AWS için optimize edilmiş, akıllı bileşenler canlı veri de gösterir. Ücretsiz planda tek kullanıcı için sınırsız özel diyagram.
  * [Codegiant](https://codegiant.io) — Depo barındırma & CI/CD ile Proje Yönetimi. Ücretsiz Plan, 5 Ekip Üyesiyle Sınırsız Depo, Proje & Doküman sunar. Aylık 500 CI/CD dakikası. Aylık 30000 Sunucusuz Kod Çalıştırma dakikası ve 1GB depo depolama.
  * [Confluence](https://www.atlassian.com/software/confluence) - Atlassian'ın içerik işbirliği aracı, ekiplerin verimli bir şekilde işbirliği yapmasına ve bilgi paylaşmasına yardımcı olur. 10 kullanıcıya kadar ücretsiz plan.
  * [contriber.com](https://www.contriber.com/) — Özelleştirilebilir proje yönetim platformu, ücretsiz başlangıç planı, beş çalışma alanı
  * [Crosswork](https://crosswork.app/) - Çok yönlü proje yönetim platformu. 3 projeye kadar ücretsiz, sınırsız kullanıcı, 1 GB depolama.
  * [diagrams.net](https://app.diagrams.net/) — Diyagramlar Google Drive, OneDrive veya Dropbox'ta yerel olarak saklanır. Tüm özellikler ve depolama seviyeleri için ücretsiz.
  * [freedcamp.com](https://freedcamp.com/) - Görevler, tartışmalar, kilometre taşları, zaman takibi, takvim, dosyalar ve şifre yöneticisi. Sınırsız proje, kullanıcı ve dosya depolama ile ücretsiz plan.
  * [easyretro.io](https://www.easyretro.io/) — Basit ve sezgisel sprint retrospektif aracı. Ücretsiz plan, üç açık pano ve pano başına ayda bir anket içerir.
  * [GForge](https://gforge.com) — Kapsamlı projeler için Proje Yönetimi ve Sorun Takip seti; kendi sunucunuzda veya SaaS seçenekleriyle. SaaS ücretsiz planı ilk beş kullanıcı için ücretsizdir ve Açık Kaynak Projeler için ücretsizdir.
  * [gleek.io](https://www.gleek.io) — Geliştiriciler için ücretsiz açıklamadan diyagrama aracı. Anahtar kelimenizi kullanarak gayri resmi UML sınıf, nesne veya varlık-ilişki diyagramları oluşturun.
  * [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector, iki GraphQL şeması arasındaki değişikliklerin listesini çıkarır. Her fark, tam olarak açıklanır ve kırıcı, kırıcı olmayan veya tehlikeli olarak işaretlenir.
  * [huboard.com](https://huboard.com/) — GitHub sorunlarınız için anında proje yönetimi, Açık Kaynak için ücretsiz
  * [Hygger](https://hygger.io) — Proje yönetim platformu. Ücretsiz plan, sınırsız kullanıcı, proje & pano ve 100 MB Depolama sunar.
  * [Instabug](https://instabug.com) — Mobil uygulamalar için kapsamlı hata raporlama ve uygulama içi geri bildirim SDK'sı. 1 uygulama ve bir üye için ücretsiz plan.
  * [WishKit](https://wishkit.io) — iOS/macOS uygulamanız için uygulama içi kullanıcı geri bildirimlerini toplayın ve özellikleri kullanıcı oylarına göre önceliklendirin. 1 uygulamaya kadar ücretsiz plan.
  * [Ilograph](https://www.ilograph.com/)  — Kullanıcıların altyapılarını birden fazla perspektiften ve ayrıntı seviyesinden görmelerini sağlayan interaktif diyagramlar. Diyagramlar kod ile ifade edilebilir. Ücretsiz katman, 3 izleyiciye kadar sınırsız özel diyagram içerir.
  * [Jira](https://www.atlassian.com/software/jira) — Birçok kurumsal ortamda kullanılan gelişmiş yazılım geliştirme proje yönetim aracı. 10 kullanıcıya kadar ücretsiz plan.
  * [kanbanflow.com](https://kanbanflow.com/) — Pano tabanlı proje yönetimi. Ücretsiz, daha fazla seçenek için premium sürüm
  * [kanbantool.com](https://kanbantool.com/) — Kanban panosu tabanlı proje yönetimi. Ücretsiz plan, ek ve dosya olmadan iki pano ve iki kullanıcı içerir.
  * [kan.bn](https://kan.bn/) - Çalışmalarınızı organize etmenize, ilerlemeyi takip etmenize ve sonuçlar elde etmenize yardımcı olan güçlü ve esnek bir kanban uygulaması. Sınırsız pano, sınırsız liste, sınırsız kart için 1 kullanıcıya kadar ücretsiz plan.
  * [Kitemaker.co](https://kitemaker.co) - Ürün geliştirme sürecinin tüm aşamalarında iş birliği yapın ve işleri Slack, Discord, Figma ve Github üzerinden takip edin. Sınırsız kullanıcı, sınırsız alan. 250 iş maddesine kadar ücretsiz plan.
  * [Kiter.app](https://www.kiter.app/) - Herkesin iş aramasını organize etmesine, görüşmeleri, fırsatları ve bağlantıları takip etmesine olanak tanır. Güçlü web uygulaması ve Chrome uzantısı. Tamamen ücretsiz.
  * [Kumu.io](https://kumu.io/)  — Animasyon, süsleme, filtreler, kümelenme, elektronik tablo içe aktarma gibi özelliklerle ilişki haritaları. Ücretsiz katman sınırsız açık projeye izin verir. Grafik boyutu sınırsız. Öğrenciler için ücretsiz özel projeler. Dosyanızı çevrimiçi olarak açık bırakmak istemiyorsanız Sandbox modu kullanılabilir (yükle, düzenle, indir, sil).
  * [Linear](https://linear.app/) — Akıcı arayüze sahip hata takip aracı. Sınırsız üye için ücretsiz, 10MB dosya yükleme limiti, 250 sorun (Arşiv hariç)
  * [leiga.com](https://www.leiga.com/) — Leiga, projelerinizi otomatik olarak yönetmek için yapay zeka kullanan bir SaaS ürünüdür; ekibinizin odaklanmasını sağlar ve projelerinizin planlandığı gibi ilerlemesini garantiler. 10 kullanıcıya, 20 özel alana, 2GB depolama alanına kadar ücretsiz; Yapay Zekalı Video Kaydı 5 dk/video ile sınırlı, Otomasyon Koşuları kullanıcı başına ayda 20 kez.
  * [Lucidchart](https://www.lucidchart.com/) - İş birliği özellikli çevrimiçi diyagram aracı. Üç düzenlenebilir belge, 100 profesyonel şablon ve temel iş birliği özelliklerine sahip ücretsiz plan.
  * [MeisterTask](https://www.meistertask.com/) — Takımlar için çevrimiçi görev yönetimi. 3 projeye ve sınırsız proje üyesine kadar ücretsiz.
  * [MeuScrum](https://www.meuscrum.com/en) - Ücretsiz çevrimiçi scrum aracı, kanban panosu ile birlikte
  * [nTask](https://www.ntaskmanager.com/) — Takımlarınızın iş birliği yapmasını, planlamasını, analiz etmesini ve günlük görevleri yönetmesini sağlayan proje yönetim yazılımı. Temel plan sonsuza dek ücretsizdir, 100 MB depolama ve beş kullanıcı/takım içerir. Sınırsız çalışma alanı, toplantı, atama, zaman çizelgesi ve sorun takibi.
  * [Ora](https://ora.pm/) - Çevik görev yönetimi & ekip iş birliği. 3 kullanıcıya kadar ücretsiz, dosyalar 10 MB ile sınırlı.
  * [pivotaltracker.com](https://www.pivotaltracker.com/) — Sınırsız açık proje ve üç toplam aktif kullanıcı (okuma-yazma) ile iki özel proje ve sınırsız pasif kullanıcı (okuma) için ücretsiz.
  * [plan.io](https://plan.io/) — Depo barındırma ve daha fazla seçeneğiyle Proje Yönetimi. 2 kullanıcı, 10 müşteri ve 500MB Depolama için ücretsiz
  * [Plane](https://plane.so/) - Plane, basit, genişletilebilir, açık kaynak proje ve ürün yönetim aracıdır. Sınırsız üye için ücretsiz, 5MB dosya yükleme limiti, 1000 sorun.
  * [planitpoker.com](https://www.planitpoker.com/) — Ücretsiz çevrimiçi planlama pokeri (tahmin aracı)
  * [point.poker](https://www.point.poker/) - Çevrimiçi Planlama Pokeri (konsensüs tabanlı tahmin aracı). Sınırsız kullanıcı, takım, oturum, tur ve oy için ücretsiz. Kayıt olmanıza gerek yok.
  * [ScrumFast](https://www.scrumfast.com) - Çok sezgisel arayüze sahip scrum panosu, 5 kullanıcıya kadar ücretsiz.
  * [Shake](https://www.shakebugs.com/) - Mobil uygulamalar için uygulama içi hata raporlama ve geri bildirim aracı. Ücretsiz plan, uygulama başına ayda on hata raporu.
  * [Shortcut](https://shortcut.com/) - Proje yönetim platformu. 10 kullanıcıya kadar sonsuza dek ücretsiz.
  * [Tadum](https://tadum.app) - Tekrarlayan toplantılar için tasarlanmış toplantı gündemi ve tutanak uygulaması, 10 kişiye kadar ekipler için ücretsiz
  * [taiga.io](https://taiga.io/) — Startup'lar ve çevik geliştiriciler için proje yönetim platformu, Açık Kaynak için ücretsiz
  * [Tara AI](https://tara.ai/) — Basit sprint yönetim servisi. Ücretsiz plan, kullanıcı sınırı olmadan sınırsız görev, sprint ve çalışma alanı içerir.
  * [targetprocess.com](https://www.targetprocess.com/) — Kanban ve Scrum'dan neredeyse her türlü operasyonel sürece kadar görsel proje yönetimi. Sınırsız kullanıcıya kadar ücretsiz, 1.000 veri varlığına kadar {[daha fazla detay](https://www.targetprocess.com/pricing/)}
  * [taskade.com](https://www.taskade.com/) — Gerçek zamanlı iş birliğiyle görev listeleri ve ekip ana hatları. Ücretsiz plan, sınırsız görev ve projeye sahip bir çalışma alanı; 1GB dosya depolama; 1 haftalık proje geçmişi; ve video toplantı başına beş katılımcı içerir.
  * [taskulu.com](https://taskulu.com/) — Rol tabanlı proje yönetimi. 5 kullanıcıya kadar ücretsiz. GitHub/Trello/Dropbox/Google Drive entegrasyonu
  * [Teaminal](https://www.teaminal.com) - Uzaktan çalışan ekipler için standup, retro ve sprint planlama aracı. 15 kullanıcıya kadar ücretsiz.
  * [teamwork.com](https://teamwork.com/) — Proje yönetimi & Ekip Sohbeti. Beş kullanıcı ve iki proje için ücretsiz. Premium planlar mevcuttur.
  * [teleretro.com](https://www.teleretro.com/) — Buz kırıcılar, gifler ve emojilerle basit ve eğlenceli retrospektif aracı. Ücretsiz plan üç retro ve sınırsız üye içerir.
  * [testlio.com](https://testlio.com/) — Sorun takibi, test yönetimi ve beta test platformu. Özel kullanım için ücretsiz
  * [terrastruct.com](https://terrastruct.com/) — Özellikle yazılım mimarisi için çevrimiçi diyagram oluşturucu. Diyagram başına 4 kata kadar ücretsiz katman.
  * [todoist.com](https://todoist.com/) — İş birliği ve bireysel görev yönetimi. Ücretsiz planda: 5 aktif proje, projede beş kullanıcı, 5MB'a kadar dosya yükleme, üç filtre ve bir hafta etkinlik geçmişi.
  * [trello.com](https://trello.com/) — Pano tabanlı proje yönetimi. Sınırsız Kişisel Pano, 10 Takım Panosu.
  * [Tweek](https://tweek.so/) — Basit Haftalık Yapılacaklar Takvimi & Görev Yönetimi.
  * [ubertesters.com](https://ubertesters.com/) — Test platformu, entegrasyon ve kalabalık testçiler, 2 proje, beş üye
  * [Wikifactory](https://wikifactory.com/) — Proje, VCS & Sorunlar ile Ürün Tasarım Hizmeti. Ücretsiz plan, sınırsız proje & işbirlikçi ve 3GB depolama sunar.
  * [Yodiz](https://www.yodiz.com/) — Çevik geliştirme ve sorun takibi. 3 kullanıcıya kadar ücretsiz, sınırsız proje.
  * [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — FOSS projeleri ve özel projeler için ücretsiz barındırılan YouTrack (InCloud) (üç kullanıcıya kadar ücretsiz). Zaman takibi ve çevik panolar içerir.
  * [zenhub.com](https://www.zenhub.com) — GitHub içinde tek proje yönetim çözümü. Açık depo, OSS ve kar amacı gütmeyen kuruluşlar için ücretsiz
  * [zenkit.com](https://zenkit.com) — Proje yönetimi ve iş birliği aracı. 5 üyeye kadar ücretsiz, 5 GB ek dosya.
  * [Zube](https://zube.io) — 4 Proje & 4 kullanıcı için ücretsiz planlı proje yönetimi. GitHub entegrasyonu mevcut.
  * [Toggl](https://toggl.com/) — İki ücretsiz verimlilik aracı sağlar. [Toggl Track](https://toggl.com/track/) zaman yönetimi ve takip uygulaması için ücretsiz plan, serbest çalışanlar için tasarlanmış sorunsuz zaman takibi ve raporlama sunar. Sınırsız takip kaydı, proje, müşteri, etiket, raporlama ve daha fazlası. Ve [Toggl Plan](https://toggl.com/plan/) görev planlaması için, tek geliştiriciler için ücretsiz plan; sınırsız görev, kilometre taşı ve zaman çizelgesi içerir.
  * [Sflow](https://sflow.io) — sflow.io, özellikle dış kaynak ve kurumlar arası iş birliği projeleri için çevik yazılım geliştirme, pazarlama, satış ve müşteri desteği için oluşturulmuş bir proje yönetim aracıdır. 3 projeye ve beş üyeye kadar ücretsiz plan.
  * [Pulse.red](https://pulse.red) — Projeler için ücretsiz Minimalist Zaman Takipçisi ve Zaman Çizelgesi uygulaması.

**[⬆️ Başa Dön](#table-of-contents)**

## Depolama ve Medya İşleme

  * [AndroidFileHost](https://androidfilehost.com/) - Sınırsız hız, bant genişliği, dosya sayısı, indirme sayısı vb. ile ücretsiz dosya paylaşım platformu. Genellikle Android geliştiriciyle ilgili dosyalar (APK, özel ROM ve modifikasyonlar vb.) için hedeflenmiştir, ancak diğer dosyaları da kabul ediyor gibi görünüyor.
  * [borgbase.com](https://www.borgbase.com/) — Borg Backup için basit ve güvenli uzaktan yedekleme barındırma. 10 GB ücretsiz yedekleme alanı ve iki depo.
  * [icedrive.net](https://www.icedrive.net/) - Basit bulut depolama servisi. 10 GB ücretsiz depolama
  * [sync.com](https://www.sync.com/) - Uçtan uca bulut depolama servisi. 5 GB ücretsiz depolama
  * [pcloud.com](https://www.pcloud.com/) - Bulut depolama servisi. 10 GB'a kadar ücretsiz depolama
  * [sirv.com](https://sirv.com/) — Anında görüntü optimizasyonu ve boyutlandırmasıyla akıllı Görsel CDN. Ücretsiz katman 500 MB depolama ve 2 GB bant genişliği içerir.
  * [cloudimage.io](https://www.cloudimage.io/en/home) — Dünya genelinde 1500+ Erişim Noktasıyla tam görüntü optimizasyonu ve CDN servisi. Çeşitli görüntü boyutlandırma, sıkıştırma ve filigranlama işlevleri. Duyarlı görseller, 360 görüntü oluşturma ve görüntü düzenleme için açık kaynak eklentiler. Ücretsiz aylık plan: 25GB CDN trafiği, 25GB önbellek depolama ve sınırsız dönüşüm.
  * [cloudinary.com](https://cloudinary.com/) — Siteler ve uygulamalar için görsel yükleme, güçlü manipülasyon, depolama ve sunum; Ruby, Python, Java, PHP, Objective-C ve daha fazlası için kütüphane desteğiyle. Ücretsiz katman 25 aylık kredi içerir. Bir kredi, 1.000 görsel dönüşümü, 1 GB depolama veya 1 GB CDN kullanımı anlamına gelir.
  * [embed.ly](https://embed.ly/) — Bir web sayfasına medya yerleştirmek, duyarlı görsel ölçeklendirme yapmak ve bir web sayfasından ögeler çıkarmak için API'ler sağlar. 5.000 URL/ay ve saniyede 15 istek ile ücretsiz
  * [filestack.com](https://www.filestack.com/) — Dosya seçici, dönüştürme ve sunum, 250 dosya, 500 dönüşüm ve 3 GB bant genişliği için ücretsiz
  * [file.io](https://www.file.io) - 2 GB dosya depolama. Bir dosya bir kez indirildikten sonra otomatik olarak silinir. Depolama ile etkileşim için REST API. Oran limiti: dakikada bir istek.
  * [freetools.site](https://freetools.site/) — Ücretsiz çevrimiçi araçlar. Belge, görsel, ses, video ve daha fazlasını dönüştürün veya düzenleyin.
  * [GoFile.io](https://gofile.io/) - Web tabanlı arayüz ve API ile kullanılabilen ücretsiz dosya paylaşım ve depolama platformu. Sınırsız dosya boyutu, bant genişliği, indirme sayısı vb. Ancak bir dosya etkin olmadığında (on günden fazla indirilmeyince) silinir.
  * [gumlet.com](https://www.gumlet.com/) — Görüntü ve video barındırma, işleme ve CDN üzerinden yayınlama. Videolar için aylık 250 GB, görseller için aylık 30 GB ücretsiz geniş cömert katman sunar.
  * [image-charts.com](https://www.image-charts.com/) — Filigranlı sınırsız görsel grafik oluşturma
  * [Imgbot](https://github.com/marketplace/imgbot) — Imgbot, görsellerinizi optimize eden ve size zaman kazandıran dost canlısı bir bottur. Optimize edilmiş görseller, kalite kaybı olmadan daha küçük dosya boyutları demektir. Açık kaynak için ücretsizdir.
  * [ImgBB](https://imgbb.com/) — ImgBB, sınırsız görsel barındırma servisidir. Görselinizi ekranın herhangi bir yerine sürükleyip bırakın. 32 MB / görsel limiti. Yükledikten sonra doğrudan görsel linkleri, BBCode ve HTML küçük resimleri alın. Yükleme geçmişini görmek için giriş yapın.
  * [imgen](https://www.jitbit.com/imgen/) - Ücretsiz, sınırsız sosyal kapak görseli oluşturma API'si, filigran yok
  * [imgix](https://www.imgix.com/) - Görsel Önbellekleme, yönetim ve CDN. Ücretsiz plan 1000 orijin görsel, sonsuz dönüşüm ve 100 GB bant genişliği içerir
  * [kraken.io](https://kraken.io/) — Web sitesi performansı için görsel optimizasyonu servisi, dosya başına 1 MB'a kadar ücretsiz plan
  * [kvstore.io](https://www.kvstore.io/) — Anahtar-değer depolama servisi. Ücretsiz katman 100 anahtar, anahtar başına 1KB, saatte 100 çağrı izni verir
  * [npoint.io](https://www.npoint.io/) — İşbirlikli şema düzenleme ile JSON deposu
  * [nitropack.io](https://nitropack.io/) - Otomatik olarak site hızınızı artırın (önbellekleme, görsel ve kod optimizasyonu, CDN). Aylık 5.000 sayfa görüntülemeye kadar ücretsiz
  * [otixo.com](https://www.otixo.com/) — Tüm bulut depolama dosyalarınızı tek yerden şifreleyin, paylaşın, kopyalayın ve taşıyın. Temel plan, 250 MB maksimum dosya boyutuyla sınırsız dosya transferi ve beş şifreli dosya sunar
  * [packagecloud.io](https://packagecloud.io/) — YUM, APT, RubyGem ve PyPI için Barındırılmış Paket Depoları. Sınırlı ücretsiz planlar ve istek üzerine açık kaynak planları mevcuttur
  * [getpantry.cloud](https://getpantry.cloud/) — Kişisel projeler, hackathonlar ve mobil uygulamalar için mükemmel, basit bir JSON veri depolama API'si!
  * [Pinata IPFS](https://pinata.cloud) — Pinata, IPFS üzerinde dosya yüklemenin ve yönetmenin en basit yoludur. Kullanıcı dostu arayüzü ve IPFS API'si ile Pinata, platformlar, yaratıcılar ve koleksiyoncular için en kolay IPFS pinleme hizmetidir. API erişimiyle birlikte 1 GB ücretsiz depolama.
  * [placekitten.com](https://placekitten.com/) — Yer tutucu olarak kullanılmak üzere hızlı ve basit kedi resimleri servisi
  * [plot.ly](https://plot.ly/) — Verilerinizi grafiğe dökün ve paylaşın. Ücretsiz katman sınırsız açık dosya ve on özel dosya içerir
  * [podio.com](https://podio.com/) — Podio'yu beş kişiye kadar bir ekip ile kullanabilir ve Temel Plan'ın kullanıcı yönetimi hariç tüm özelliklerini deneyebilirsiniz
  * [QRME.SH](https://qrme.sh) - Hızlı, güzel toplu QR kod üreticisi – giriş yok, filigran yok, reklam yok. Toplu dışa aktarma başına 100 URL'ye kadar.
  * [QuickChart](https://quickchart.io) — Gömülebilir görsel grafikler, diyagramlar ve QR kodlar üretin
  * [redbooth.com](https://redbooth.com) — P2P dosya eşitleme, 2 kullanıcıya kadar ücretsiz
  * [resmush.it](https://resmush.it) — reSmush.it, görsel optimizasyonu sağlayan ÜCRETSİZ bir API'dir. WordPress, Drupal veya Magento gibi en yaygın CMS'lerde uygulanmıştır. reSmush.it, yedi milyardan fazla görseli optimize etmiş en çok kullanılan görsel optimizasyon API'sidir ve hala ücretsizdir.
  * [Shotstack](https://shotstack.io) - Ölçekli video oluşturma ve düzenleme API'si. Aylık 20 dakikaya kadar işlenmiş video ücretsiz
  * [tinypng.com](https://tinypng.com/) — PNG ve JPEG görselleri sıkıştırmak ve yeniden boyutlandırmak için API, her ay 500 sıkıştırma ücretsiz sunar
  * [transloadit.com](https://transloadit.com/) — Dosya yüklemeleri ve video, ses, görsel, belge kodlamalarını yönetir. GitHub Student Developer Pack ile açık kaynak, hayır kurumları ve öğrencilere ücretsiz. Ticari uygulamalar için test sürüşü için 2 GB ücretsiz
* [twicpics.com](https://www.twicpics.com) - Hizmet olarak duyarlı görseller. Görsel CDN, medya işleme API'si ve görsel optimizasyonunu otomatikleştiren bir ön uç kütüphanesi sunar. Hizmet, ayda 3GB trafik/ay'a kadar ücretsizdir.
* [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare, en son algoritmalara dayalı nihai araç setiyle medya hattı sağlar. Tüm özellikler geliştiriciler için tamamen ücretsizdir: Dosya Yükleme API'si ve UI, Görsel CDN ve Orijin Hizmetleri, Uyarlanabilir Teslimat ve Akıllı Sıkıştırma. Ücretsiz katmanda 3000 yükleme, 3 GB trafik ve 3 GB depolama bulunur.
* [imagekit.io](https://imagekit.io) – Otomatik optimizasyon, gerçek zamanlı dönüştürme ve depolama ile görsel CDN'si, mevcut kurulumunuza dakikalar içinde entegre edilebilir. Ücretsiz plan, ayda 20GB'a kadar bant genişliği içerir.
* [internxt.com](https://internxt.com) – Internxt Drive, mutlak gizlilik ve tavizsiz güvenlik üzerine kurulu sıfır bilgi dosya depolama hizmetidir. Kaydolun ve sonsuza kadar 10 GB ücretsiz alın!
* [degoo.com](https://degoo.com/) – AI tabanlı bulut depolama, 20 GB'a kadar ücretsiz, üç cihaz, 5 GB referans bonusu (90 gün hesap etkinliği yoksa).
* [MConverter.eu](https://mconverter.eu/) – Dosyaları toplu şekilde dönüştürün. [AVIF](https://mconverter.eu/convert/to/avif/) gibi yeni olanlar dahil birçok dosya formatını destekler. Videolardan tüm görsel karelerini çıkarır. Günde on adet 100MB dosyaya kadar, iki dosyalık partiler halinde ücretsizdir.
* [ImageEngine](https://imageengine.io/) – ImageEngine kullanımı kolay global bir görsel CDN'dir. 60 saniyeden kısa sürede kurulum. AVIF ve JPEGXL desteği, WordPress-, Magento-, React-, Vue- eklentileri ve daha fazlası. Ücretsiz geliştirici hesabınızı [buradan](https://imageengine.io/developer-program/) talep edin.
* [DocsParse](https://docsparse.com/) – PDF'leri, Görselleri GPT destekli AI ile JSON, CSV, EXCEL formatlarında yapısal veriye dönüştürme. Her ay 30 kredi ücretsiz.
* [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – Hediye kartları, hediye çekleri ve promosyonlar için kolayca özel QR kodları oluşturun. Özel stil, renk, logo desteği...
* [LibreQR](https://libreqr.com) — Gizlilik odaklı ve izleme yapmayan ücretsiz QR kod oluşturucu. Veri toplama olmadan ücretsiz kullanılır.

**[⬆️ Başa Dön](#table-of-contents)**

## Tasarım ve Kullanıcı Arayüzü

* [AllTheFreeStock](https://allthefreestock.com) - Ücretsiz stok görseller, sesler ve videolardan oluşan seçilmiş bir liste.
* [Float UI](https://floatui.com/) - Tasarım bilmeyenler için bile modern, duyarlı ve şık web sitelerini hızlıca oluşturabileceğiniz ücretsiz web geliştirme aracı.
* [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page, Ant Motion'ın hareket bileşenleriyle oluşturulmuş bir şablon sunar. Zengin ana sayfa şablonu içerir, şablon kod paketini indirir ve hızlıca kullanılabilir. Ayrıca editörü kullanarak kendi özel sayfanızı hızlıca oluşturabilirsiniz.
* [Backlight](https://backlight.dev/) — Geliştiriciler ve tasarımcılar arasında işbirliği odağında, Backlight ekiplerin Tasarım Sistemleri'ni oluşturduğu, belgelediği, yayımladığı, ölçeklendirdiği ve sürdürdüğü tam bir kodlama platformudur. Ücretsiz plan, bir tasarım sistemi üzerinde 3 editöre kadar sınırsız izleyiciyle çalışma imkanı sunar.
* [BoxySVG](https://boxy-svg.com/app) — SVG'ler çizmek ve SVG, PNG, jpeg ve diğer formatlarda dışa aktarmak için ücretsiz kurulum yapılabilir Web uygulaması.
* [Carousel Hero](https://carouselhero.com/) - Sosyal medya carouselleri oluşturmak için ücretsiz çevrimiçi araç.
* [Circum Icons](https://circumicons.com) - React, Vue ve Svelte için SVG gibi tutarlı açık kaynak ikonlar.
* [clevebrush.com](https://www.cleverbrush.com/) — Ücretsiz Grafik Tasarım / Fotoğraf Kolajı Uygulaması. Ayrıca, bileşen olarak entegre edilmesi için ücretli seçenekleri vardır.
* [cloudconvert.com](https://cloudconvert.com/) — Her şeyi her şeye dönüştürün. Videolar ve gifler dahil 208 desteklenen format.
* [CodeMyUI](https://codemyui.com) - Kod snippet'ları ile seçilmiş Web Tasarım & UI İlham koleksiyonu.
* [ColorKit](https://colorkit.co/) - Çevrimiçi renk paletleri oluşturun veya en iyi paletlerden ilham alın.
* [coolors](https://coolors.co/) - Renk paleti oluşturucu. Ücretsizdir.
* [CMYK Pantone](https://www.cmyktopantone.com/) - CMYK değerlerini en yakın Pantone renklerine ve diğer renk modellerine saniyeler içinde ücretsiz dönüştürün.
* [Branition](https://branition.com/colors) - Markalar için en uygun, elle seçilmiş renk paletleri.
* [css-gradient.com](https://www.css-gradient.com/) - Hızlıca özel, tarayıcılar arası CSS gradyanları oluşturmak için ücretsiz araç. RGB ve HEX formatında.
* [easyvectors.com](https://easyvectors.com/) — EasyVectors.com ücretsiz bir SVG vektör sanat stokudur. En iyi vektör grafiklerini tamamen ücretsiz indirin.
* [figma.com](https://www.figma.com) — Takımlar için çevrimiçi, işbirliğine dayalı tasarım aracı; ücretsiz katmanda sınırsız dosya ve izleyici, maksimum 2 editör ve üç proje.
* [Flyon UI](https://flyonui.com/)- Tailwind CSS için en kolay bileşen kütüphanesi.
* [framer.com](https://www.framer.com/) - Framer, bir sonraki uygulamanız, web siteniz veya ürününüz için arayüz fikirlerinizi yinelemenizi ve animasyon eklemenizi sağlar—güçlü yerleşimlerle başlar. Profesyonel prototipleme aracı olarak Framer'ı değerlendirenler için: sınırsız izleyici, 2 editöre kadar, 3 projeye kadar.
* [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU Endişesiz model/mülk izni olan stok fotoğraflar
* [Gradientos](https://www.gradientos.app) - Gradyan seçmeyi hızlı ve kolay hale getirir.
* [Icon Horse](https://icon.horse) – Basit API'mizden herhangi bir web sitesi için en yüksek çözünürlüklü favicon'u alın.
* [Iconoir](https://iconoir.com) – Binlerce ikon içeren açık kaynak ikon kütüphanesi, React, React Native, Flutter, Vue, Figma ve Framer desteğiyle.
* [Icons8](https://icons8.com) — İkonlar, illüstrasyonlar, fotoğraflar, müzik ve tasarım araçları. Ücretsiz Planda düşük çözünürlükte sınırlı formatlar sunar. Varlıklarımızı kullandığınızda Icons8'e bağlantı verin.
* [landen.co](https://www.landen.co) — Girişiminiz için güzel web siteleri ve açılış sayfaları oluşturun, düzenleyin ve yayınlayın. Hepsi kod olmadan. Ücretsiz katman ile bir web sitesine sahip olabilir, tamamen özelleştirilebilir ve yayında tutabilirsiniz.
* [Quant Ux](https://quant-ux.com/) - Quant Ux bir prototipleme ve tasarım aracıdır. - Tamamen ücretsiz ve açık kaynaklıdır.
* [lensdump.com](https://lensdump.com/) - Ücretsiz bulut görsel barındırma.
* [Lorem Picsum](https://picsum.photos/) - Ücretsiz, kullanımı kolay, şık yer tutucu görsel aracı. URL'nin sonuna istediğiniz görsel boyutunu (genişlik & yükseklik) ekleyin, rastgele bir görsel alın.
* [LottieFiles](https://lottiefiles.com/) - Dünya'nın en küçük animasyon formatı için en büyük çevrimiçi platformu; tasarımcılar, geliştiriciler ve daha fazlası için. Android, iOS ve Web için Lottie animasyon araçları ve eklentilerine erişin.
* [MagicPattern](https://www.magicpattern.design/tools) — Gradyanlar, desenler ve bloblar için CSS & SVG arka plan oluşturucular ve araçlar koleksiyonu.
* [marvelapp.com](https://marvelapp.com/) — Tasarım, prototipleme ve işbirliği, ücretsiz planda bir kullanıcı ve bir projeyle sınırlı.
* [Mindmup.com](https://www.mindmup.com/) — Ücretsiz sınırsız zihin haritası oluşturun ve bulutta saklayın. Zihin haritalarınız her yerde, her cihazdan anında erişilebilir.
* [Mockplus iDoc](https://www.mockplus.com/idoc) - Mockplus iDoc güçlü bir tasarım işbirliği & teslim aracı. Ücretsiz planda üç kullanıcı ve beş proje tüm özelliklerle birlikte sunulur.
* [mockupmark.com](https://mockupmark.com/create/free) — Sosyal medya ve E-ticaret için gerçekçi tişört ve kıyafet mockup'ları oluşturun, 40 ücretsiz mockup.
* [Mossaik](https://mossaik.app) - Dalgalar, bloblar ve desenler gibi farklı araçlarla ücretsiz SVG görsel oluşturucu.
* [movingpencils.com](https://movingpencils.com) — Hızlı, tarayıcı tabanlı vektör editörü. Tamamen ücretsiz.
* [Octopus.do](https://octopus.do) — Görsel site haritası oluşturucu. Web sitesi yapınızı gerçek zamanlı oluşturun ve ekibiniz veya müşterilerinizle hızla paylaşın.
* [Pencil](https://github.com/evolus/pencil) - Electron kullanan açık kaynak tasarım aracı.
* [Penpot](https://penpot.app) - Web tabanlı, açık kaynak kodlu tasarım ve prototipleme aracı. SVG desteği vardır. Tamamen ücretsiz.
* [pexels.com](https://www.pexels.com/) - Ticari kullanım için ücretsiz stok fotoğraflar. Anahtar kelimeye göre fotoğraf arayabileceğiniz ücretsiz API sunar.
* [photopea.com](https://www.photopea.com) — PSD, XCF & Sketch formatlarını (Adobe Photoshop, Gimp ve Sketch App) destekleyen, Adobe Photoshop arayüzüne sahip ücretsiz gelişmiş çevrimiçi tasarım editörü.
* [pixlr.com](https://pixlr.com/) — Ticari olanlar seviyesinde ücretsiz çevrimiçi tarayıcı editörü.
* [Plasmic](https://www.plasmic.app/) - Kod tabanınıza entegre edilen hızlı, kullanımı kolay, güçlü bir web tasarım aracı ve sayfa oluşturucu. Duyarlı sayfalar veya karmaşık bileşenler oluşturun; isteğe bağlı olarak kod ile genişletin; canlı sitelere ve uygulamalara yayınlayın.
* [Pravatar](https://pravatar.cc/) - Web veya uygulamanızda doğrudan bağlantı verebileceğiniz rastgele/yer tutucu sahte avatar üretin.
* [Proto.io](https://www.proto.io) - Kod yazmadan tamamen etkileşimli UI prototipleri oluşturun. Ücretsiz katman, ücretsiz deneme süresi bitince açılır. Ücretsiz katmanda bir kullanıcı, bir proje, beş prototip, 100MB çevrimiçi depolama ve proto.io uygulamasının önizlemesi bulunur.
* [resizeappicon.com](https://resizeappicon.com/) — Uygulama ikonlarınızı yeniden boyutlandırmak ve yönetmek için basit bir hizmet.
* [Rive](https://rive.app) — Her platforma güzel animasyonlar oluşturun ve gönderin. Bireyler için sonsuza kadar ücretsiz. Hizmet bir editör sunar ve tüm grafikleri kendi sunucularında barındırır. Ayrıca Rive ile yapılan temsilleri çalıştırmak için birçok platforma çalışma zamanı sağlarlar.
* [storyset.com](https://storyset.com/) — Projeniz için inanılmaz ücretsiz, özelleştirilmiş illüstrasyonlar oluşturun.
* [smartmockups.com](https://smartmockups.com/) — Ürün mockup'ları oluşturun, 200 ücretsiz mockup.
* [Shadcn Studio](https://shadcnstudio.com/theme-editor) — Tema değişikliklerinizi farklı bileşenler ve düzenler üzerinde önizleyin.
* [Tailark](https://tailark.com/) - Pazarlama web siteleri için tasarlanmış modern, duyarlı ve önceden hazırlanmış UI blokları koleksiyonu.
* [tabler-icons.io](https://tabler-icons.io/) — 1500'den fazla ücretsiz kopyala-yapıştır SVG düzenlenebilir ikon.
* [tweakcn](https://tweakcn.com/) — shadcn/ui için güzel temalar. Gerçek zamanlı olarak renkleri, tipografiyi ve daha fazlasını özelleştirin.
* [UI Avatars](https://ui-avatars.com/) - İsimlerden baş harflerle avatar oluşturun. URL'ler doğrudan web/app'inizde bağlantı verilebilir. URL ile yapılandırma parametrelerini destekler.
* [unDraw](https://undraw.co/) - Tamamen ücretsiz ve atıf gerektirmeyen, sürekli güncellenen güzel SVG görseller koleksiyonu.
* [unsplash.com](https://unsplash.com/) - Ticari ve ticari olmayan amaçlar için ücretsiz stok fotoğraflar (istediğin gibi kullan lisansı).
* [vectr.com](https://vectr.com/) — Web + Masaüstü için Ücretsiz Tasarım Uygulaması.
* [walkme.com](https://www.walkme.com/) — Kurumsal Sınıf Kılavuzluk ve Katılım Platformu, ücretsiz planda üç adede kadar 5 adımlık kılavuz.
* [Webflow](https://webflow.com) - Animasyonlu ve barındırmalı WYSIWYG web sitesi oluşturucu. İki proje için ücretsiz.
* [Updrafts.app](https://updrafts.app) - tailwindcss tabanlı tasarımlar için WYSIWYG web sitesi oluşturucu. Ticari olmayan kullanım için ücretsiz.
* [whimsical.com](https://whimsical.com/) - İşbirliğine dayalı akış şemaları, wireframe'ler, yapışkan notlar ve zihin haritaları. 4 adede kadar ücretsiz pano oluşturun.
* [Zeplin](https://zeplin.io/) — Tasarımcı ve geliştirici işbirliği platformu. Tasarımları, varlıkları ve stil rehberlerini gösterir. Bir proje için ücretsiz.
* [Pixelixe](https://pixelixe.com/) — Çevrimiçi olarak ilgi çekici, benzersiz grafikler ve görseller oluşturun ve düzenleyin.
* [Responsively App](https://responsively.app) - Daha hızlı ve daha hassas duyarlı web uygulama geliştirme için ücretsiz geliştirici aracı.
* [SceneLab](https://scenelab.io) - Sürekli genişleyen ücretsiz tasarım şablonları koleksiyonuna sahip çevrimiçi mockup grafik editörü.
* [xLayers](https://xlayers.dev) - Sketch tasarım dosyalarını Angular, React, Vue, LitElement, Stencil, Xamarin ve daha fazlasına önizle ve dönüştür (ücretsiz ve açık kaynak: https://github.com/xlayers/xlayers)
* [Grapedrop](https://grapedrop.com/) — GrapesJS Framework tabanlı, duyarlı, güçlü, SEO-optimize web sayfası oluşturucu. İlk beş sayfa için ücretsiz, sınırsız özel alan adı, tüm özellikler ve kolay kullanım.
* [Mastershot](https://mastershot.app) - Tamamen ücretsiz tarayıcı tabanlı video editörü. Filigran yok, 1080p'ye kadar dışa aktarma seçeneği.
* [Unicorn Platform](https://unicornplatform.com/) - Barındırmalı zahmetsiz açılış sayfası oluşturucu. Bir web sitesi ücretsiz.
* [SVGmix.com](https://www.svgmix.com/) - 300.000+ ücretsiz SVG ikon, koleksiyon ve marka logosu devasa deposu. Hızlı dosya düzenleme için tarayıcıda basit bir vektör düzenleyici içerir.
* [svgrepo.com](https://www.svgrepo.com/) - Çeşitli vektör kütüphanelerini kullanarak projeleriniz için en uygun ikonları veya vektörleri keşfedin, arayın ve bulun. Ticari kullanım için ücretsiz SVG vektörleri indirin.
* [haikei.app](https://www.haikei.app/) - Haikei, tasarım araçlarınız ve iş akışınızla kullanıma hazır benzersiz SVG şekiller, arka planlar ve desenler oluşturmak için bir web uygulamasıdır.
* [Canva](https://canva.com) - Görsel içerikler oluşturmak için ücretsiz çevrimiçi tasarım aracı.
* [Superdesigner](https://superdesigner.co) - Sadece birkaç tıklamayla benzersiz arka planlar, desenler, şekiller, görseller ve daha fazlasını oluşturmak için ücretsiz tasarım araçları koleksiyonu.
* [TeleportHQ](https://teleporthq.io/) - Düşük kodlu Ön Uç Tasarım ve Geliştirme Platformu. TeleportHQ, başsız statik web sitelerini anında oluşturup yayınlamak için işbirliğine dayalı ön uç platformudur. Üç ücretsiz proje, sınırsız işbirlikçi ve ücretsiz kod dışa aktarma.
* [vector.express](https://vector.express) — AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS ve SVG vektörlerinizi hızlı ve kolayca dönüştürün.
* [Vertopal](https://www.vertopal.com) - Vertopal, dosyaları çeşitli formatlara dönüştürmek için ücretsiz çevrimiçi platformdur. JPG'den SVG'ye, GIF'ten APNG'ye, PNG'den WEBP'ye, JSON'dan XML'e gibi geliştiriciler için dönüştürücüler dahil.
* [okso.app](https://okso.app) - Minimalist çevrimiçi çizim uygulaması. Hızlı eskizler ve görsel notlar oluşturmanıza olanak tanır. PNG, JPG, SVG ve WEBP'ye dışa aktarır. Ayrıca PWA olarak kurulabilir. Herkes için ücretsizdir (kayıt gerekmez).
* [Wdrfree SVG](https://wdrfree.com/free-svg) - Siyah beyaz ücretsiz SVG kesim dosyaları.
* [Lucide](https://lucide.dev) - Ücretsiz, özelleştirilebilir ve tutarlı SVG ikon araç seti.
* [Logo.dev](https://www.logo.dev) - 44M+ markaya sahip şirket logosu API'sı, sadece bir URL çağrısı kadar kolay. İlk 10.000 API çağrısı ücretsiz.
* [MDBootstrap](https://mdbootstrap.com/) - Kişisel ve ticari kullanım için ücretsiz, 700'den fazla bileşen, etkileyici şablonlar, 1 dakikalık kurulum, kapsamlı eğitimler ve devasa topluluk ile Bootstrap, Angular, React ve Vue UI Kitleri.
* [TW Elements](https://tw-elements.com/) - Ücretsiz Bootstrap bileşenleri, Tailwind CSS ile yeniden oluşturuldu, ancak daha iyi tasarım ve daha fazla işlevsellik ile.
* [DaisyUI](https://daisyui.com/) -- Ücretsiz. "Tailwind CSS kullanın ama daha az sınıf adı yazın" düsturuyla, buton gibi bileşenler sunar.
  * [Scrollbar.app](https://scrollbar.app) -- Web için özel kaydırma çubukları tasarlamak için basit ve ücretsiz bir web uygulaması.
  * [css.glass](https://css.glass/) -- CSS kullanarak cam benzeri (glassmorphic) tasarımlar oluşturmak için ücretsiz bir web uygulaması.
  * [hypercolor.dev](https://hypercolor.dev/) -- Tailwind CSS renk gradyanlarının özenle seçilmiş bir koleksiyonu, ayrıca kendi gradyanlarınızı oluşturmak için çeşitli jeneratörler sunar.
  * [iconify.design](https://icon-sets.iconify.design/) -- Birleşik bir arayüze sahip 100'den fazla simge paketinden oluşan bir koleksiyon. Paketler arasında simge araması yapabilir ve tekil simgeleri SVG olarak ya da popüler web framework'leri için dışa aktarabilirsiniz.
  * [NextUI](https://nextui.org/) -- Ücretsiz. Güzel, hızlı ve modern React & Next.js UI kütüphanesi.
  * [Glyphs](https://glyphs.fyi/) -- Ücretsiz, Web'in En Güçlü Simgeleri, Tamamen düzenlenebilir ve gerçekten açık kaynaklı tasarım sistemi.
  * [ShadcnUI](https://ui.shadcn.com/) -- Uygulamalarınıza kopyalayıp yapıştırabileceğiniz güzel tasarlanmış bileşenler. Erişilebilir. Özelleştirilebilir. Açık Kaynak.
  * [HyperUI](https://www.hyperui.dev/) -- Ücretsiz Açık Kaynak Tailwind CSS Bileşenleri.
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- Tek tıkla bir yılın tamamı için benzersiz ikonlar oluşturun, tamamen ÜCRETSİZ
  * [Image BG Blurer](https://imagebgblurer.com/) -- Notion, Trello, Jira ve daha birçok araç için, bir görselin kaynağını arka plan bulanıklığı olarak kullanarak bulanık bir arka plan çerçevesi oluşturun
  * [Webstudio](https://webstudio.is/) -- Webflow'a açık kaynaklı alternatif. Ücretsiz plan, kendi alan adlarında beş web sitesi, kendi alan adlarında beş web sitesi, ayda on bin sayfa görüntüleme ve 2 GB varlık depolama ile sınırsız web sitesi sunar.
  * [Nappy](https://nappy.co/) -- Siyahi ve Kahverengi insanlara ait güzel fotoğraflar, ücretsiz. Ticari ve kişisel kullanım için.
  * [Tailkits](https://tailkits.com/) -- Tailwind şablonları, bileşenleri ve araçlarından oluşan seçilmiş bir koleksiyon; ayrıca kod, ızgara, kutu gölgeleri ve daha fazlası için kullanışlı jeneratörler.
  * [Tailcolors](https://tailcolors.com/) -- Güzel bir Tailwind CSS v4 renk paleti. Mükemmel Tailwind CSS renk sınıfını anında önizleyin ve kopyalayın.
  * [Excalidraw](https://excalidraw.com/) -- Ücretsiz, çevrimiçi çizim doküman web sitesi, yerel kaydetme ve dışa aktarma desteğiyle.
  * [Lunacy](https://icons8.com/lunacy) -- Çevrimdışı desteği, yerleşik varlıkları (ikonlar, fotoğraflar, illüstrasyonlar) ve gerçek zamanlı iş birliği ile ücretsiz grafik tasarım aracı. Ücretsiz katman 10 bulut dokümanı, 30 günlük geçmiş, düşük çözünürlüklü varlıklar ve temel tasarım araçları içerir.

**[⬆️ Başa Dön](#table-of-contents)**

## Tasarım İlhamı

  * [awwwards.](https://www.awwwards.com/) - [En iyi web siteleri] Tasarımcılar tarafından oylanan, en iyi tasarıma sahip web sitelerinin vitrinidir.
  * [Behance](https://www.behance.net/) - [Tasarım vitrin] Tasarımcıların çalışmalarını sergilediği bir platform. UI/UX projeleri için filtrelenebilir kategoriler mevcut.
  * [dribbble](https://dribbble.com/) - [Tasarım vitrin] Genellikle gerçek uygulamalardan olmayan benzersiz tasarım ilhamı.
  * [Landings](https://landings.dev/) - [Web ekran görüntüleri] Tasarım ilhamınız için tercihinize göre en iyi landing page’leri bulun.
  * [Lapa Ninja](https://www.lapa.ninja/) - [Landing page / UI Kitleri / Web ekran görüntüleri] Lapa Ninja, en iyi 6025 landing page örneğini, tasarımcılar için ücretsiz kitapları ve web genelindeki ücretsiz UI kitlerini sunan bir galeri.
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [Landing Page Tasarımları] Sık sık güncellenen landing page ekran görüntüleri. Masaüstü, Tablet ve Mobil ekran görüntüleri içerir.
  * [Mobbin](https://mobbin.design/) - [Mobil ekran görüntüleri] 50.000+ tamamen aranabilir mobil uygulama ekran görüntüsü kütüphanemizle UI & UX araştırmalarında saatler kazanın.
  * [Uiland Design](https://uiland.design/) - [Mobil ekran görüntüleri] Afrika ve dünyadaki lider şirketlerden Mobil ve Web UI Tasarımlarını keşfedin.
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [Mobil ekran görüntüleri] Tasarımcılar, geliştiriciler ve ürün üreticileri için en iyi UI UX Pattern’larını (iOS ve Android) sunan ilham kaynağı bir kütüphane.
  * [Page Flows](https://pageflows.com/) - [Mobil / web videoları ve ekran görüntüleri] Birçok mobil ve web uygulamasında tam akışların videoları. Ayrıca ekran görüntüleri de var. Yüksek oranda aranabilir ve indekslenmiş.
  * [Screenlane](https://screenlane.com/) - [Mobil ekran görüntüleri] En son web & mobil uygulama UI tasarım trendlerini keşfedin ve ilham alın. Pattern ve uygulamaya göre filtrelenebilir.
  * [scrnshts](https://scrnshts.club/) - [Mobil ekran görüntüleri] En iyi uygulama mağazası tasarım ekran görüntülerinden elenmiş bir koleksiyon.
  * [Refero](https://refero.design/) - [Web ekran görüntüleri] Harika web uygulamalarından etiketlenmiş ve aranabilir tasarım referansları koleksiyonu.


**[⬆️ Başa Dön](#table-of-contents)**

## Haritalarda Veri Görselleştirme

  * [IP Geolocation](https://ipgeolocation.io/) — Ücretsiz GELİŞTİRİCİ planı, ayda 30.000 istek ile kullanılabilir.
  * [carto.com](https://carto.com/) — Kendi ve herkese açık verilerinizden haritalar ve coğrafi uzamsal API’ler oluşturun.
  * [Clockwork Micro](https://clockworkmicro.com/) — Saat gibi çalışan harita araçları. Aylık elli bin ücretsiz sorgu (harita döşemeleri, db2vector, yükseklik).
  * [developers.arcgis.com](https://developers.arcgis.com) — Haritalar, coğrafi veri depolama, analiz, coğrafi kodlama, yönlendirme ve daha fazlası için API ve SDK’lar; web, masaüstü ve mobilde. Aylık iki milyon ücretsiz temel harita döşemesi, 20.000 depolanmamış coğrafi kod, 20.000 basit rota, 5.000 sürüş süresi hesaplaması ve 5GB ücretsiz döşeme+veri depolama.
  * [Foursquare](https://developer.foursquare.com/) - Konum keşfi, mekan arama ve Places API ile Pilgrim SDK’dan bağlama duyarlı içerik.
  * [geoapify.com](https://www.geoapify.com/) - Vektör ve raster harita döşemeleri, coğrafi kodlama, mekanlar, yönlendirme, izolin API’leri. Günde üç bin ücretsiz istek.
  * [geocod.io](https://www.geocod.io/) — API veya CSV Yüklemesi ile coğrafi kodlama. Günde iki bin beş yüz ücretsiz sorgu.
  * [geocodify.com](https://geocodify.com/) — API veya CSV Yüklemesi ile coğrafi kodlama ve coğrafi ayrıştırma. Aylık 10 bin ücretsiz sorgu.
  * [geojs.io](https://www.geojs.io/) - Yüksek erişilebilirliğe sahip REST/JSON/JSONP IP Konum Tespit API’si.
  * [giscloud.com](https://www.giscloud.com/) — Coğrafi verileri çevrimiçi olarak görselleştirin, analiz edin ve paylaşın.
  * [graphhopper.com](https://www.graphhopper.com/) Yönlendirme, Rota Optimizasyonu, Mesafe Matrisi, Coğrafi Kodlama ve Harita Eşleme için ücretsiz geliştirici paketi sunar.
  * [here](https://developer.here.com/) — Haritalar ve konum tabanlı uygulamalar için API ve SDK’lar. Aylık 250 bin ücretsiz işlem.
  * [locationiq.com](https://locationiq.com/) — Coğrafi kodlama, haritalar ve yönlendirme API’leri. Günde beş bin ücretsiz istek.
  * [mapbox.com](https://www.mapbox.com/) — Harita verilerini görüntülemek için haritalar, coğrafi hizmetler ve SDK’lar.
  * [maptiler.com](https://www.maptiler.com/cloud/) — Harita görselleştirme için vektör haritalar, harita servisleri ve SDK’lar. Haftalık güncellemeli ücretsiz vektör döşemeleri ve dört harita stili.
  * [nominatim.org](https://nominatim.org/) — OpenStreetMap’in ücretsiz coğrafi kodlama hizmeti; küresel adres arama ve ters coğrafi kodlama imkânı sunar.
  * [nextbillion.ai](https://nextbillion.ai/) - Harita ile ilgili hizmetler: Coğrafi Kodlama, Navigasyon (Yön, Rota, Rota Optimizasyonu, Mesafe Matrisi), Harita SDK’sı (Vektör, Statik, Mobil SDK). Her hizmet için [belirtilen kota ile ücretsiz](https://nextbillion.ai/pricing).
  * [opencagedata.com](https://opencagedata.com) — OpenStreetMap ve diğer açık coğrafi kaynakları birleştiren Coğrafi Kodlama API’si. Günde iki bin beş yüz ücretsiz sorgu.
  * [osmnames](https://osmnames.org/) — Coğrafi kodlama, sonuçlar ilgili Wikipedia sayfasının popülerliğine göre sıralanır.
  * [positionstack](https://positionstack.com/) - Küresel yerler ve koordinatlar için ücretsiz coğrafi kodlama. Kişisel kullanım için ayda 25.000 istek.
  * [stadiamaps.com](https://stadiamaps.com/) — Harita döşemeleri, yönlendirme, navigasyon ve diğer coğrafi API’ler. Ticari olmayan kullanım ve test için günde iki bin beş yüz ücretsiz harita görüntüleme ve API isteği.
  * [maps.stamen.com](http://maps.stamen.com/) - Ücretsiz harita döşemeleri ve döşeme barındırma.
  * [ipstack](https://ipstack.com/) - Web sitesi ziyaretçilerini IP Adresinden bulun ve tanımlayın.
  * [Geokeo api](https://geokeo.com) - Dil düzeltme ve daha fazlasıyla birlikte Coğrafi Kodlama API’si. Dünya çapında kapsam. Günde 2.500 ücretsiz sorgu

**[⬆️ Başa Dön](#table-of-contents)**

## Paket Yapı Sistemi

  * [build.opensuse.org](https://build.opensuse.org/) — Birden fazla dağıtım için (SUSE, EL, Fedora, Debian, vb.) paket yapı servisi.
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Fedora ve EL için Mock tabanlı RPM yapı servisi.
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — Ubuntu ve Debian yapı servisi.

**[⬆️ Başa Dön](#table-of-contents)**

## IDE ve Kod Düzenleme

  * [3v4l](https://3v4l.org/) - 300+ PHP sürümünde kodunuzu çalıştıran, ücretsiz çevrimiçi PHP shell ve snippet paylaşım sitesi
  * [Android Studio](https://developer.android.com/studio) — Android Studio, her tür Android cihazında uygulama geliştirmek için en hızlı araçları sunar. Açık Kaynak IDE, herkes için ücretsizdir ve en iyi Android uygulama geliştirme ortamıdır. Windows, Mac, Linux ve hatta ChromeOS için mevcuttur!
  * [AndroidIDE](https://m.androidide.com/) — Android cihazlarda gerçek, Gradle tabanlı Android uygulamaları geliştirmek için Açık Kaynak IDE.
  * [Apache Netbeans](https://netbeans.apache.org/) — Geliştirme Ortamı, Araç Platformu ve Uygulama Çatısı.
  * [apiary.io](https://apiary.io/) — Anında API taklidi ve üretilmiş dokümantasyon ile işbirlikçi API tasarımı (Sınırsız API şablonu ve kullanıcı için ücretsiz, bir yönetici hesabı ve barındırılan dokümantasyon ile).
  * [BBEdit](https://www.barebones.com/) - BBEdit, macOS için popüler ve genişletilebilir bir editördür. Ücretsiz Mod, [güçlü temel özellik seti](https://www.barebones.com/products/bbedit/comparison.html) ve gelişmiş özelliklere geçiş yolu sunar.
  * [Binder](https://mybinder.org/) - Bir Git deposunu interaktif not defterleri koleksiyonuna dönüştürün. Ücretsiz bir herkese açık servistir.
  * [BlueJ](https://bluej.org) — Yeni başlayanlar için tasarlanmış ücretsiz bir Java Geliştirme Ortamı, dünya çapında milyonlarca kişi tarafından kullanılır. Oracle desteklidir ve yeni başlayanlara yardımcı olacak basit bir arayüze sahiptir.
  * [Bootify.io](https://bootify.io/) - Özel veritabanı ve REST API ile Spring Boot uygulama jeneratörü.
  * [Brackets](http://brackets.io/) - Brackets, özellikle web geliştirme için tasarlanmış açık kaynaklı bir metin editörüdür. Hafif, kullanımı kolay ve yüksek oranda özelleştirilebilir.
  * [cacher.io](https://www.cacher.io) — Etiketler ve 100+ programlama dili desteği ile kod snippet düzenleyicisi.
  * [Code::Blocks](https://codeblocks.org) — Ücretsiz Fortran & C/C++ IDE. Açık Kaynak ve Windows, macOS & Linux’ta çalışır.
  * [Cody](https://sourcegraph.com/cody) - Kod yazabilen (Kod blokları, otomatik tamamlama, birim testleri), anlayabilen (tüm kod tabanınız bilgisiyle), düzeltebilen ve bulabilen ücretsiz AI kod asistanı. VS Code, JetBrains ve Çevrimiçi için mevcut.
  * [codiga.io](https://codiga.io/) — Kod snippet’lerini doğrudan IDE’nizde aramanıza, tanımlamanıza ve yeniden kullanmanıza olanak tanıyan Kod Asistanı. Bireysel ve küçük kuruluşlar için ücretsizdir.
  * [codesnip.com.br](https://codesnip.com.br) — Kategoriler, arama ve etiketlerle basit kod snippet yöneticisi. Ücretsiz ve sınırsız.
  * [cocalc.com](https://cocalc.com/) — (eski adıyla SageMathCloud, cloud.sagemath.com) — Bulutta işbirlikçi hesaplama. Tam Ubuntu’ya tarayıcı erişimi, yerleşik işbirliği ve matematik, bilim, veri bilimi için çok sayıda ücretsiz yazılımla (önceden kurulu: Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn, vb.).
  * [code.cs50.io](https://code.cs50.io/) - code.cs50.io'da bulunan Visual Studio Code for CS50, öğrenciler ve öğretmenler için GitHub Codespaces’i adapte eden bir web uygulamasıdır.
  * [codepen.io](https://codepen.io/) — CodePen, web’in ön yüzü için bir oyun alanıdır.
  * [codesandbox.io](https://codesandbox.io/) — React, Vue, Angular, Preact ve daha fazlası için çevrimiçi Oyun Alanı.
  * [Components.studio](https://webcomponents.dev/) - Bileşenleri izole şekilde kodlayın, hikayelerde görselleştirin, test edin ve npm’de yayımlayın.
  * [Eclipse Che](https://www.eclipse.org/che/) - Geliştirici Takımları için web tabanlı ve Kubernetes-Doğal IDE, çoklu dil desteğiyle. Açık Kaynak ve topluluk odaklı. Red Hat tarafından barındırılan bir çevrimiçi örneği [workspaces.openshift.com](https://workspaces.openshift.com/) adresinde mevcuttur.
  * [fakejson.com](https://fakejson.com/) — FakeJSON, API’siyle hızlıca sahte veri oluşturmanıza yardımcı olur. Ne istediğinizi ve nasıl istediğinizi açıklayan bir API isteği yapın, API tümünü JSON olarak döndürür. Fikirlerin pazara çıkışını hızlandırın ve başarana kadar taklit edin.
  * [GetVM](https://getvm.io) — Anında ücretsiz Linux ve IDE’ler Chrome kenar çubuğu. Ücretsiz katman, günde 5 VM içerir.
  * [GitPod](https://www.gitpod.io) — GitHub projeleri için anında, kodlamaya hazır geliştirme ortamları. Ücretsiz katman ayda 50 saat içerir.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE, bulut üzerinde tam özellikli bir IDE'dir. Çoklu dil desteği, tam özellikli web tabanlı terminal üzerinden Linux tabanlı konteyner, port yönlendirme, özel URL, gerçek zamanlı işbirliği ve sohbet, bağlantı paylaşımı, Git/Subversion desteği gibi birçok özelliği vardır. (Ücretsiz katman her konteyner için 1GB RAM ve 10GB Depolama, 5 Konteyner slotu içerir).
  * [JDoodle](https://www.jdoodle.com) — 60'tan fazla programlama dili için çevrimiçi derleyici ve editör, REST API kod derleme için günlük 200 krediye kadar ücretsiz plan.
  * [jetbrains.com](https://jetbrains.com/products.html) — Verimlilik araçları, IDE'ler ve dağıtım araçları (örn. [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/), vb.). Öğrenciler, öğretmenler, Açık Kaynak ve kullanıcı grupları için ücretsiz lisans.
  * [jsbin.com](https://jsbin.com) — JS Bin, ön yüz web (HTML, CSS ve JavaScript) için bir başka oyun alanı ve kod paylaşım sitesidir. Ayrıca Markdown, Jade ve Sass destekler.
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle, ön yüz web için bir oyun alanı ve kod paylaşım sitesidir, işbirliğini destekler.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) JSON formatında sahte veri döndüren bazı REST API uç noktaları. Sunucuyu yerel olarak çalıştırmak isterseniz kaynak kodu da mevcuttur.
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus, Hızlı Uygulama Geliştirme için Delphi uyumlu, platformlar arası bir IDE'dir.
  * [MarsCode](https://www.marscode.com/) - Ücretsiz, yapay zekâ destekli bulut tabanlı IDE.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - Sahte JSON verisi oluşturmak için küçük API sahteleme mikroservisi.
  * [mockable.io](https://www.mockable.io/) — Mockable, RESTful API veya SOAP web servislerini sahtelemek için basit yapılandırılabilir bir servistir. Bu çevrimiçi hizmet, REST API veya SOAP uç noktalarını hızlıca tanımlamanıza ve bunların JSON veya XML veri döndürmesini sağlar.
  * [mockaroo](https://mockaroo.com/) — Mockaroo ile CSV, JSON, SQL ve Excel formatlarında gerçekçi test verileri oluşturabilirsiniz. Ayrıca arka uç API'leri için sahte veri de oluşturabilirsiniz.
  * [Mocklets](https://mocklets.com) - API'leri daha hızlı paralel geliştirme ve daha kapsamlı test için simüle etmeye yardımcı olan HTTP tabanlı bir sahte API simülatörü; ömür boyu ücretsiz katman.
  * [Paiza](https://paiza.cloud/en/) — Web uygulamalarını tarayıcıda, herhangi bir kurulum yapmadan geliştirin. Ücretsiz Plan bir sunucu sunar: 24 saatlik ömre sahip ve günde 4 saat çalıştırma süresi, 2 CPU çekirdeği, 2 GB RAM ve 1 GB depolama alanı ile.
  * [Prepros](https://prepros.io/) - Prepros, kutudan çıktığı gibi Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript ve TypeScript derleyebilir, tarayıcılarınızı otomatik olarak yeniler ve web sitelerinizi geliştirmeyi & test etmeyi kolaylaştırır. Kendi araçlarınızı da birkaç tıklamayla ekleyebilirsiniz.
  * [Replit](https://replit.com/) — Çeşitli programlama dilleri için bulut kodlama ortamı.
  * [SoloLearn](https://code.sololearn.com) — Kod parçacıklarını çalıştırmaya uygun bir bulut programlama oyun alanı. Çeşitli programlama dillerini destekler. Kod çalıştırmak için kayıt gerekmez, ancak kodun kendi platformlarında kaydedilmesi için kayıt zorunludur. Ayrıca yeni başlayanlar ve orta seviye kodlayıcılar için ücretsiz kurslar sunar.
  * [stackblitz.com](https://stackblitz.com/) — Çevrimiçi/Bulut Kod IDE'si ile tam yığın uygulamalar oluşturun, düzenleyin ve dağıtın. Popüler tüm NodeJs tabanlı ön yüz ve arka uç framework'lerini destekler. Yeni proje başlatmak için kısa bağlantı: [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - Kodlama ve metin düzenleme görevleri için popüler, çok yönlü ve oldukça özelleştirilebilir bir metin editörü.
  * [Visual Studio Code](https://code.visualstudio.com/) - Modern web ve bulut uygulamaları oluşturmak ve hata ayıklamak için yeniden tanımlanmış ve optimize edilmiş kod editörü. Microsoft tarafından geliştirilmiştir.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — Binlerce eklentiye sahip tam özellikli IDE, platformlar arası uygulama geliştirme (iOS ve Android için Microsoft eklentileri indirilebilir), masaüstü, web ve bulut geliştirme, çoklu dil desteği (C#, C++, JavaScript, Python, PHP ve daha fazlası).
  * [VSCodium](https://vscodium.com/) - Topluluk tarafından yönetilen, telemetri/izleme olmadan ve özgürce lisanslanmış Microsoft'un VSCode editörünün dağıtımı
  * [wakatime.com](https://wakatime.com/) — Kodlama etkinliğinizle ilgili öz ölçütler, metin editörü eklentileri ile, sınırlı plan ücretsizdir.
  * [Wave Terminal](https://waveterm.dev/) - Wave, sorunsuz iş akışları için açık kaynaklı, platformlar arası bir terminaldir. Satır içi her şeyi görüntüleyin. Oturumları ve geçmişi kaydedin. Açık web standartları ile desteklenir. MacOS ve Linux.
  * [WebComponents.dev](https://webcomponents.dev/) — İzole olarak web bileşenleri kodlamak için tarayıcıda IDE; 58 şablon, hikaye ve test desteğiyle.
  * [PHPSandbox](https://phpsandbox.io/) — PHP için çevrimiçi geliştirme ortamı
  * [WebDB](https://webdb.app) - Ücretsiz Verimli Veritabanı IDE'si. Sunucu Keşfi, ERD, Veri Üretici, Yapay Zekâ, NoSQL Yapı Yöneticisi, Veritabanı Sürümleme ve çok daha fazlası.
  * [Zed](https://zed.dev/) - Atom ve Tree-sitter'ın yaratıcılarından yüksek performanslı, çok oyunculu kod editörü.
  * [OneCompiler](https://onecompiler.com/) - Java, Python, C++, JavaScript dahil 70+ dili destekleyen ücretsiz çevrimiçi derleyici.


**[⬆️ Başa Dön](#table-of-contents)**

## Analitik, Olaylar ve İstatistikler

  * [Dwh.dev](https://dwh.dev) - Veri Bulutu Gözlemlenebilirlik Çözümü (Snowflake). Kişisel kullanım için ücretsizdir.
  * [Hightouch](https://hightouch.com/) - Hightouch, müşteri verilerinizi veri ambarınızdan CRM, pazarlama ve destek araçlarınıza senkronize etmenize yardımcı olan bir Reverse ETL platformudur. Ücretsiz katman, verileri senkronize etmek için bir hedef sunar.
  * [Avo](https://avo.app/) — Basitleştirilmiş analitik yayın iş akışı. Tek kaynaklı izleme planı, tür güvenli analitik izleme kütüphanesi, uygulama içi hata ayıklayıcılar ve tüm veri sorunlarını yayınlamadan önce yakalamak için veri gözlemlenebilirliği. İki çalışma alanı üyesi ve 1 saat veri gözlemlenebilirliği geri bakış süresi için ücretsizdir.
  * [Branch](https://www.branch.io) — Mobil Analitik Platformu. Ücretsiz Katman 10K Mobil Uygulama Kullanıcısı için derin bağlantı ve diğer hizmetleri sunar.
  * [Census](https://www.getcensus.com/) — Reverse ETL ve Operasyonel Analitik Platformu. Veri ambarınızdan 60+ SaaS'a (Salesforce, Zendesk, Amplitude vb.) 10 alanı senkronize edin.
  * [Clicky](https://clicky.com) — Web Sitesi Analitik Platformu. Ücretsiz Plan bir web sitesi için 3000 görüntüleme analitiği sunar.
  * [Databox](https://databox.com) — Diğer analitik & BI platformları ile birleşik İş Zekâsı & Analitik. Ücretsiz Plan 3 kullanıcı, gösterge paneli ve veri kaynağı sunar. 11 milyon geçmiş veri kaydı.
  * [Hitsteps.com](https://hitsteps.com/) — 1 web sitesi için ayda 2.000 sayfa görüntüleme
  * [amplitude.com](https://amplitude.com/) — 1 milyon aylık olay, 2 uygulamaya kadar
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter, barındırılan hizmet (ticari olmayan kullanım için ücretsiz) veya kendin barındırabileceğin açık kaynaklı bir web analitik platformudur. Kolay kullanımlı ve anlamlı, gizliliğe duyarlı web analitiği sunmayı amaçlar ve Google Analytics veya Matomo'ya alternatif olarak sunulur. Ücretsiz katman, ticari olmayan kullanım içindir ve sınırsız site, altı ay veri saklama ve ayda 100k sayfa görüntüleme içerir.
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — Geliştiriciler için gizlilik dostu Google Analytics alternatifi. Ücretsiz plan kredi kartı gerekmeden ayda 20k sayfa görüntüleme sunar.
  * [Expensify](https://www.expensify.com/) — Harcama raporlama, ücretsiz kişisel rapor onay iş akışı
  * [getinsights.io](https://getinsights.io) - Gizlilik odaklı, çerezsiz analitik, ayda 3k olaya kadar ücretsiz.
  * [heap.io](https://heap.io) — iOS veya web uygulamalarında her kullanıcı eylemini otomatik olarak yakalar. Ayda 10K oturuma kadar ücretsiz.
  * [Hotjar](https://hotjar.com) — Web Sitesi Analitik ve Raporları. Ücretsiz Plan günlük 2000 sayfa görüntüleme sağlar. Yüz anlık görüntü/gün (maksimum kapasite: 300). Üç anlık görüntü ısı haritası 365 gün saklanabilir. Sınırsız Takım Üyesi. Ayrıca uygulama içi ve bağımsız anketler, ekran görüntülü geri bildirim widget'ları da vardır. Ücretsiz katman 3 anket & 3 geri bildirim widget'ı oluşturmayı ve ayda 20 yanıt toplamayı sağlar.
  * [Keen](https://keen.io/) — Veri toplama, analiz ve görselleştirme için özelleştirilebilir analitik. Ayda 1.000 olay ücretsiz
  * [Yandex.Datalens](https://datalens.yandex.com/) — Yandex Cloud veri görselleştirme ve analiz servisi. Hizmet ücretsiz sağlanır. Kullanıcı ve istek sayısında kısıtlama yoktur.
  * [Yandex.Metrica](https://metrica.yandex.com/) — Sınırsız ücretsiz analitik
  * [Mixpanel](https://mixpanel.com/) — 100.000 aylık takip edilen kullanıcı, sınırsız veri geçmişi ve koltuk, ABD veya AB veri yerleşimi
  * [Moesif](https://www.moesif.com) — REST ve GraphQL için API analitiği. (Ayda 500.000 API çağrısına kadar ücretsiz)
  * [optimizely.com](https://www.optimizely.com) — A/B Test çözümü, ücretsiz başlangıç planı, bir web sitesi, 1 iOS ve 1 Android uygulama
  * [Microsoft PowerBI](https://powerbi.com) — Microsoft tarafından İş Zekâsı & Analitik. Ücretsiz Plan sınırlı kullanım ve 1 Milyon Kullanıcı lisansı sunar.
  * [Row Zero](https://rowzero.io) - Son derece hızlı, bağlı elektronik tablo. Doğrudan veri tabanlarına, S3'e ve API'lere bağlanın. Milyonlarca satırı anında içe aktarın, analiz edin, grafikleştirin ve paylaşın. Üç ücretsiz (daima) çalışma kitabı.
  * [sematext.com](https://sematext.com/cloud/) — Ayda 50 K eyleme kadar, 1 gün veri saklama, sınırsız gösterge paneli, kullanıcı, vb. ücretsizdir.
  * [Similar Web](https://similarweb.com) — Web & Mobil Uygulamalar için Analitik. Ücretsiz Plan her metrik için beş sonuç, bir ay mobil uygulama verisi ve 3 ay web sitesi verisi sunar.
  * [StatCounter](https://statcounter.com/) — Web Sitesi Ziyaretçi Analitiği. 500 en son ziyaretçi için ücretsiz plan.
  * [Statsig](https://statsig.com) - Analitik, özellik bayraklama ve A/B testi kapsayan hepsi bir arada platform. Ayda 1m ölçülen olaya kadar ücretsiz.
  * [Tableau Developer Program](https://www.tableau.com/developer) — Kurumunuz için Tableau'yu mükemmel şekilde çalıştırın, yenilik yapın, oluşturun. Ücretsiz geliştirici programı, Tableau Online için kişisel geliştirme sandbox lisansı verir. Sürüm, en son ön sürümdür, böylece Veri Geliştiricileri bu harika platformun tüm özelliklerini test edebilir.
  * [usabilityhub.com](https://usabilityhub.com/) — Tasarımları ve maketleri gerçek kişilerde test edin ve ziyaretçileri takip edin. Bir kullanıcı için ücretsiz, sınırsız test
  * [woopra.com](https://www.woopra.com/) — 500K eylem, 90 gün veri saklama, 30+ tek tık entegrasyon için ücretsiz kullanıcı analitiği platformu.
  * [counter.dev](https://counter.dev) — Web analitiğini basit ve gizlilik dostu hale getirir. Ücretsiz veya bağış ile istediğinizi ödeyin.
  * [PostHog](https://posthog.com) - Ayda 1m izlenen olaya kadar ücretsiz tam Ürün Analitiği paketi. Ayrıca 250/ay yanıt ile sınırsız uygulama içi anket sağlar.
  * [Uptrace](https://uptrace.dev) - Geliştiricilerin hataları bulmasına ve performans darboğazlarını tespit etmesine yardımcı olan Dağıtık İzleme Aracı. Ücretsiz planı vardır, açık kaynak projeleri için ücretsiz Kişisel abonelik ve açık kaynak sürümü sunar.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity, gerçek insanların sitenizi nasıl kullandığını yakalayan ücretsiz ve kullanımı kolay bir araçtır.
  * [Beampipe.io](https://beampipe.io) - Beampipe, basit ve gizlilik odaklı web analitiğidir. 5 alan adına ve aylık 10k sayfa görüntülemeye kadar ücretsiz.
  * [Aptabase](https://aptabase.com) — Mobil ve Masaüstü Uygulamaları için Açık Kaynak, Gizlilik Dostu ve Basit Analitik. Swift, Kotlin, React Native, Flutter, Electron ve diğerleri için SDK'lar. Ayda 20.000 olaya kadar ücretsiz.
  * [Trackingplan](https://www.trackingplan.com/) - Dijital analitik, pazarlama verisi ve piksel sorunlarını otomatik olarak tespit edin, güncel izleme planlarını yönetin ve sorunsuz işbirliğini teşvik edin. Gerçek trafikle üretim ortamınıza dağıtın veya kod yazmadan regresyon testlerinize analitik kapsamı ekleyin.
  * [LogSpot](https://logspot.io) - Gömülebilir analitik widget'ları ve otomatik robotlar (slack, telegram ve webhooks) dahil olmak üzere tam birleşik web ve ürün analitiği platformu. Ücretsiz plan ayda 10.000 olayı kapsar.
  * [Umami](https://umami.is/) - Google Analytics'e basit, hızlı, gizlilik odaklı, açık kaynaklı alternatif.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - Google Analytics'e ücretsiz hafif, gizlilik odaklı alternatif. Sınırsız sayfa görüntüleme, sınırsız ziyaretçi, sınırsız sayfa ısı haritası ve hedef takibi. 3 alan adına ve alan başına 600 oturum tekrarına kadar ücretsiz.
  * [AppFit](https://appfit.io) - AppFit, analiz ve ürün güncellemelerinin sorunsuz, platformlar arası yönetimini kolaylaştırmak için tasarlanmış kapsamlı bir analiz ve ürün yönetim aracıdır. Ücretsiz plan ayda 10.000 olay, ürün günlüğü ve haftalık analizler içerir.
  * [Seline](https://seline.so) - Seline basit ve özel bir web sitesi ve ürün analitiğidir. Çerezsiz, hafif, bağımsız. Ücretsiz plan ayda 3.000 olaya kadar ve gösterge paneli, kullanıcı yolculukları, huniler ve daha fazlası gibi tüm özelliklere erişim sağlar.
  * [Peasy](https://peasy.so) - Peasy, web siteleri ve ürünler için hafif, gizlilik odaklı bir analitik aracıdır. Ücretsiz plan ayda 3.000 olaya kadar içerir.
  * [Rybbit](https://rybbit.io) - Google Analytics'e açık kaynaklı ve çerezsiz, 10 kat daha sezgisel alternatif. Ücretsiz plan ayda 3.000 olaya sahiptir. 

**[⬆️ Başa Dön](#table-of-contents)**

## Ziyaretçi Oturum Kaydı

  * [Reactflow.com](https://www.reactflow.com/) — Site başına: günde 1.000 sayfa görüntüleme, üç ısı haritası, üç widget, ücretsiz hata takibi
  * [OpenReplay.com](https://www.openreplay.com) - Hata tekrar üretimi için geliştirici araçları ile açık kaynaklı oturum tekrarı, gerçek zamanlı destek için canlı oturum ve ürün analitiği paketi. Tüm özelliklere erişim ve 7 gün saklama ile ayda 1.000 oturum.
  * [LogRocket.com](https://www.logrocket.com) - Ayda 1.000 oturum, 30 gün saklama, hata takibi, canlı mod
  * [FullStory.com](https://www.fullstory.com) — Ayda 1.000 oturum, bir ay veri saklama ve üç kullanıcı koltuğu. Daha fazla bilgi [burada](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — Site başına: ayda 1.050 sayfa görüntüleme, sınırsız ısı haritası, veriler üç ay saklanır
  * [inspectlet.com](https://www.inspectlet.com/) — Bir web sitesi için ayda 2.500 oturum ücretsiz
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Oturum kaydı tamamen ücretsizdir, "trafik limiti yoktur", proje limiti yoktur ve örnekleme yapılmaz
  * [mouseflow.com](https://mouseflow.com/) — Bir web sitesi için ayda 500 oturum ücretsiz
  * [mousestats.com](https://www.mousestats.com/) — Bir web sitesi için ayda 100 oturum ücretsiz
  * [smartlook.com](https://www.smartlook.com/) — Web ve mobil uygulamalar için ücretsiz paketler (ayda 1500 oturum), üç ısı haritası, bir huni, 1 ay veri geçmişi
  * [howuku.com](https://howuku.com) — Kullanıcı etkileşimi, katılımı ve olayları izleyin. Ayda 5.000 ziyarete kadar ücretsiz
  * [UXtweak.com](https://www.uxtweak.com/) — Ziyaretçilerin web sitenizi veya uygulamanızı nasıl kullandığını kaydedin ve izleyin. Küçük projeler için süresiz ücretsiz

**[⬆️ Başa Dön](#table-of-contents)**
## Uluslararası Mobil Numara Doğrulama API ve SDK'ları

  * [numverify](https://numverify.com/) — Küresel telefon numarası doğrulama ve sorgulama JSON API'si. 100 API isteği/ay
  * [veriphone](https://veriphone.io/) — Küresel telefon numarası doğrulama için ücretsiz, hızlı ve güvenilir bir JSON API. 1000 istek/ay

**[⬆️ Başa Dön](#table-of-contents)**

## Ödeme ve Faturalandırma Entegrasyonu

  * [Qonversion](http://qonversion.io/) - Tümleşik çapraz platform abonelik yönetimi platformu; analizler, A/B testleri, Apple Search Ads, uzaktan yapılandırmalar ve uygulama içi satın alımlar ile gelir artırımı için büyüme araçları sunar. iOS, Android, React Native, Flutter, Unity, Cordova, Stripe ve web ile uyumlu. Aylık izlenen 10.000$ gelire kadar ücretsiz.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – Ziyaretçinin konumuna göre fiyatlandırmayı otomatik ayarlayarak işinizi küresel olarak genişletin ve yeni pazarlara ulaşın (satın alma gücü paritesi). Ücretsiz plan 7.500 API isteği/ay içerir.
  * [Glassfy](https://glassfy.io/) – iOS, Android, Stripe ve Paddle üzerinde uygulama içi abonelik altyapısı, gerçek zamanlı abonelik olayları ve kutudan çıkan gelir araçları. Aylık 10.000$ gelire kadar ücretsiz.
  * [Adapty.io](https://adapty.io/) – Açık kaynak SDK ile mobil uygulama içi abonelik entegrasyonu için tek durak çözüm; iOS, Android, React Native, Flutter, Unity veya web uygulaması için. Aylık 10.000$ gelire kadar ücretsiz.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — Kripto para piyasası verileri ve güncel kripto ve fiat para döviz kurları sağlar. Ücretsiz katman 10K çağrı kredisi/ay sunar.
  * [CurrencyFreaks](https://currencyfreaks.com/) — Güncel ve geçmiş döviz kurlarını sağlar. 1000 istek/ay ile ücretsiz GELİŞTİRİCİ planı mevcuttur.
  * [CoinGecko](https://www.coingecko.com/en/api) — Kripto para piyasası verileri, güncel kripto döviz kurları ve geçmiş veriler sunar. Demo API, dakikada 30 çağrı ve ayda 10.000 çağrı sınırı ile gelir.
  * [CurrencyApi](https://currencyapi.net/) — Fiziksel ve Kripto Para Birimleri için Canlı Kur Oranları, JSON ve XML olarak sunulur. Ücretsiz katman 1.250 API isteği/ay sunar.
  * [currencylayer](https://currencylayer.com/) — İşletmeniz için güvenilir döviz kurları ve para birimi dönüşümü, 100 API isteği/ay ücretsiz.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - Kullanımı kolay para birimi dönüşüm JSON API'si. Ücretsiz katman günde bir kez güncellenir ve 1.500 istek/ay sınırı vardır.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — Satıcıların ödeme sahtekarlığını ve ters ibrazı önlemesine yardımcı olur. 500 sorgu/ay ile ücretsiz Micro Plan mevcut.
  * [FxRatesAPI](https://fxratesapi.com) — Gerçek zamanlı ve geçmiş döviz kurları sağlar. Ücretsiz katman atıf gerektirir.
  * [Moesif API Monetization](https://www.moesif.com/) - Kullanıma dayalı faturalandırma ile API'lardan gelir elde edin. Stripe, Chargebee vb. ile entegre olur. Ücretsiz katman 30.000 etkinlik/ay sunar.
  * [Nami ML](https://www.namiml.com/) - iOS ve Android için uygulama içi satın alma ve abonelikler için eksiksiz platform; kodsuz ödeme duvarları, CRM ve analizler içerir. IAP işi yürütmek için tüm temel özellikler ücretsizdir.
  * [RevenueCat](https://www.revenuecat.com/) — Uygulama içi satın alma ve abonelikler için barındırılan arka uç (iOS ve Android). Aylık 2.500$'a kadar izlenen gelirde ücretsiz.
  * [vatlayer](https://vatlayer.com/) — Anında KDV numarası doğrulama ve AB KDV oranları API'si, aylık 100 API isteği ücretsiz
  * [Currencyapi](https://currencyapi.com) — Ücretsiz para birimi dönüşümü ve döviz kuru veri API'si. Özel kullanım için aylık 300 istek, dakikada 10 istek ücretsizdir.

**[⬆️ Başa Dön](#table-of-contents)**

## Docker İle İlgili

  * [canister.io](https://canister.io/) — Geliştiriciler için 20, takımlar için Docker imajlarını oluşturup saklamak için 30 ücretsiz özel depo
  * [Container Registry Service](https://container-registry.com/) - Harbor tabanlı Konteyner Yönetim Çözümü. Ücretsiz katman özel depolar için 1 GB depolama sunar.
  * [Docker Hub](https://hub.docker.com) — Bir adet ücretsiz özel depo ve Docker imajları oluşturup saklamak için sınırsız herkese açık depo
  * [Play with Docker](https://labs.play-with-docker.com/) — Docker öğrenmek için basit, etkileşimli ve eğlenceli bir ortam.
  * [quay.io](https://quay.io/) — Sınırsız ücretsiz herkese açık depo ile konteyner imajları oluşturup saklayın
  * [ttl.sh](https://ttl.sh/) - Anonim & geçici Docker imajı kayıt servisi

**[⬆️ Başa Dön](#table-of-contents)**

## Vagrant İle İlgili

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud. Vagrant kutusu barındırma.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — Alternatif herkese açık kutu dizini

**[⬆️ Başa Dön](#table-of-contents)**

## Geliştirici Blog Siteleri

  * [BearBlog](https://bearblog.dev/) - Minimalist, Markdown tabanlı blog ve web sitesi oluşturucu.
  * [Dev.to](https://dev.to/) - Programcıların fikir paylaştığı ve birbirine yardımcı olduğu platform.
  * [Hashnode](https://hashnode.com/) — Geliştiriciler için zahmetsiz blog yazılımı!
  * [Medium](https://medium.com/) — Sizin için önemli olanlar hakkında daha derin düşünün.
  * [AyeDot](https://ayedot.com/) — Fikirlerinizi, bilginizi ve hikayelerinizi Modern multimedya kısa biçimli Minibloglar şeklinde dünyayla ücretsiz paylaşın.

**[⬆️ Başa Dön](#table-of-contents)**

## Yorum Platformları
  * [GraphComment](https://graphcomment.com/) - GraphComment, web sitenizin kitlesinden aktif bir topluluk oluşturmanıza yardımcı olan bir yorum platformudur.
  * [Utterances](https://utteranc.es/) - GitHub Issues üzerinde çalışan hafif bir yorum widget'ı. Blog yorumları, wiki sayfaları ve daha fazlası için GitHub Issues kullanın!
  * [Disqus](https://disqus.com/) - Disqus, web genelinde yüz binlerce site tarafından kullanılan ağ tabanlı bir topluluk platformudur.
  * [Remarkbox](https://www.remarkbox.com/) - Açık kaynaklı barındırılan yorum platformu, "Bir moderatör, birkaç alan adı üzerinde davranış ve görünüm üzerinde tam kontrol" için ödeyebileceğiniz kadar ödeyin modeliyle.
  * [IntenseDebate](https://intensedebate.com/) - WordPress, Tumblr, Blogger ve birçok diğer web sitesi platformu için özellik açısından zengin bir yorum sistemi.

**[⬆️ Başa Dön](#table-of-contents)**

## Ekran Görüntüsü API'leri

  * [ApiFlash](https://apiflash.com) — Aws Lambda ve Chrome tabanlı bir ekran görüntüsü API'si. Tam sayfa, zamanlama ve görüntüleme alanı boyutlarını yönetir.
  * [microlink.io](https://microlink.io/) – Herhangi bir web sitesini veri haline getirir; metatag normalizasyonu, şık bağlantı önizlemeleri, scraping özellikleri veya servis olarak ekran görüntüleri. Her gün 250 istek ücretsiz.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - Basit bir API çağrısı ile herhangi bir web sitesinin ekran görüntüsünü oluşturur. Google Cloud üzerinde ölçeklenebilir ve barındırılır. Aylık 100 ücretsiz ekran görüntüsü sunar.
  * [screenshotlayer.com](https://screenshotlayer.com/) — Herhangi bir web sitesinin son derece özelleştirilebilir anlık görüntülerini alın. Aylık 100 anlık görüntü ücretsiz.
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — Aylık 100 anlık görüntü, png, gif ve jpg formatlarında; yalnızca ana sayfa değil, tam uzunluklu yakalamalar dahil
  * [PhantomJsCloud](https://PhantomJsCloud.com) — Tarayıcı otomasyonu ve sayfa işleme. Ücretsiz Katman günde 500 sayfaya kadar sunar. 2017'den beri Ücretsiz Katman.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker, web sitesi ekran görüntüleri ve alan adı istihbarat API hizmetleri sunar. Aylık 100 istek ücretsiz.
  * [Screenshots](https://screenshotson.click) — Ekran görüntüleri için API'niz. Yakalama için son derece özelleştirilebilir seçenekler sunar. Aylık 100 ekran görüntüsü ücretsiz.

**[⬆️ Başa Dön](#table-of-contents)**

## Flutter İle İlgili ve Mac Olmadan IOS Uygulaması Oluşturma

  * [FlutLab](https://flutlab.io/) - FlutLab, modern bir Flutter çevrimiçi IDE'si ve çapraz platform projeleri oluşturmak, debug etmek ve derlemek için en iyi yerdir. Flutter ile Mac olmadan iOS ve Android uygulamaları oluşturun.
  * [CodeMagic](https://codemagic.io/) - Codemagic, mobil uygulamalar için tamamen barındırılan ve yönetilen bir CI/CD'dir. GUI tabanlı bir CI/CD aracı ile oluşturabilir, test edebilir ve dağıtabilirsiniz. Ücretsiz katman, ayda 500 ücretsiz dakika ve 2.3 GHz 8 GB RAM'li bir Mac Mini örneği sunar.
  * [FlutterFlow](https://flutterflow.io/) -  FlutterFlow, tarayıcı tabanlı sürükle-bırak arayüz ile flutter kullanarak mobil uygulama oluşturmanızı sağlar.

**[⬆️ Başa Dön](#table-of-contents)**

## Javascript ile Yazılmış Tarayıcı Tabanlı Donanım Emülasyonu

  * [JsLinux](https://bellard.org/jslinux) — Linux ve Windows 2k çalıştırabilen gerçekten hızlı bir x86 sanal makinesi.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) —  Ağ desteği ile Linux çalıştırabilen bir OpenRISC sanal makinesi.
  * [v86](https://copy.sh/v86) — Linux ve diğer işletim sistemlerini doğrudan tarayıcıda çalıştırabilen bir x86 sanal makinesi.

**[⬆️ Başa Dön](#table-of-contents)**

## Gizlilik Yönetimi
  * [Bearer](https://www.bearer.sh/) - Tasarımda gizliliği denetimler ve sürekli iş akışları ile uygulamanıza yardımcı olur, böylece kuruluşların GDPR ve diğer düzenlemelere uyumu sağlanır. Ücretsiz katman, yalnızca daha küçük ekiplerle ve SaaS sürümüyle sınırlıdır.
  * [Osano](https://www.osano.com/) - GDPR temsiliyetinden çerez banner'larına kadar her şeyi içeren onay yönetimi ve uyumluluk platformu. Ücretsiz katman temel özellikler sunar.
  * [Iubenda](https://www.iubenda.com/) - Gizlilik ve çerez politikaları ve onay yönetimi. Ücretsiz katman, sınırlı gizlilik ve çerez politikası ile çerez banner'ı sunar.
  * [Cookiefirst](https://cookiefirst.com/) - Çerez banner'ları, denetim ve çok dilli onay yönetim çözümü. Ücretsiz katman bir kerelik tarama ve tek bir banner sunar.
  * [Ketch](https://www.ketch.com/) - Onay yönetimi ve gizlilik çerçevesi aracı. Ücretsiz katman çoğu özelliği, sınırlı ziyaretçi sayısı ile sunar.
  * [Concord](https://www.concord.tech/) - Onay yönetimi, gizlilik talebi işleme (DSAR'lar) ve veri haritalama dahil olmak üzere tam veri gizliliği platformu. Ücretsiz katman temel onay yönetimi özelliklerini içerir ve doğrulanmış açık kaynak projeleri için daha gelişmiş bir planı da ücretsiz sunarlar.

**[⬆️ Başa Dön](#table-of-contents)**

## Diğer

  * [BackgroundStyler.com](https://backgroundstyler.com) - Sosyal medyada paylaşmak için kod, metin veya görsellerinizin estetik ekran görüntülerini oluşturun.
  * [BinShare.net](https://binshare.net) - Kod veya ikili dosya oluşturun ve paylaşın. Twitter / Facebook gönderisi için güzel bir resim veya sohbetler / forumlar için bir bağlantı olarak paylaşılabilir.
  * [Blynk](https://blynk.io) — IoT cihazlarını kontrol etmek, oluşturmak ve değerlendirmek için API'lı bir SaaS. Ücretsiz Geliştirici Planı ile 5 cihaz, Ücretsiz Bulut ve veri depolama. Mobil uygulamalar da mevcuttur.
  * [Bricks Note Calculator](https://free.getbricks.app/) - Güçlü dahili çok satırlı hesap makinesine sahip bir not alma uygulaması (PWA).
  * [Carbon.now.sh](https://carbon.now.sh) - Kod parçacıklarını estetik ekran görüntüsü benzeri bir resim formatında oluşturun ve paylaşın. Genellikle kod parçacıklarını estetik bir şekilde Twitter'da veya blog yazılarında paylaşmak/göstermek için kullanılır.
  * [Code Time](https://www.software.com/code-time) - VS Code, Atom, IntelliJ, Sublime Text ve daha fazlası için zaman takibi ve kodlama metrikleri eklentisi.
  * [Codepng](https://www.codepng.app) - Kaynak kodunuzdan sosyal medyada paylaşmak için mükemmel anlık görüntüler oluşturun.
  * [CodeToImage](https://codetoimage.com/) - Kod veya metnin ekran görüntülerini oluşturup sosyal medyada paylaşın.
  * [Cronhooks](https://cronhooks.io/) - Zamanında veya yinelenen webhooks planlayın. Ücretsiz plan 5 ad-hoc zamanlama imkanı sunar.
  * [cron-job.org](https://cron-job.org) - Çevrimiçi cronjob servisi. Sınırsız iş ücretsizdir.
  * [datelist.io](https://datelist.io) - Çevrimiçi rezervasyon / randevu planlama sistemi. Ayda 5 rezervasyona kadar ücretsiz, 1 takvim içerir.
  * [Domain Forward](https://domain-forward.com/) - Herhangi bir URL veya alan adını yönlendirmek için basit bir araç. 5 alan adına ve ayda 200 bin isteğe kadar ücretsizdir.
  * [Elementor](https://elementor.com) — WordPress web sitesi oluşturucu. 40'tan fazla Temel Widget ile ücretsiz plan mevcuttur.
  * [Exif Editor](https://exifeditor.io/) — Görüntü/fotoğraf meta verilerini tarayıcıda anında görüntüleyin, düzenleyin, temizleyin ve analiz edin - GPS konumu ve meta veriler dahil.
  * [Format Express](https://www.format-express.dev) - JSON / XML / SQL için anında çevrimiçi formatlama.
  * [FOSSA](https://fossa.com/) - Üçüncü parti kod, lisans uyumluluğu ve güvenlik açıkları için ölçeklenebilir, uçtan uca yönetim.
  * [Hook Relay](https://www.hookrelay.dev/) - Uygulamanıza webhook desteği ekleyin: sizin yerinize kuyruklama, geri alma, günlükleme. Ücretsiz planda günlük 100 teslimat, 14 gün saklama, 3 hook uç noktası vardır.
  * [Hosting Checker](https://hostingchecker.co) - Herhangi bir alan adı, web sitesi veya IP adresi için ASN, ISP, konum gibi barındırma bilgilerini kontrol edin. Ayrıca birden fazla barındırma ve DNS ile ilgili araç içerir.
  * [http2.pro](https://http2.pro) — HTTP/2 protokol hazırlık testi ve istemci HTTP/2 desteği tespit API'si.
  * [kandi](https://kandi.openweaver.com/) — Uygulama Geliştirmeye Hızlı Başlangıç: kod parçacıkları ve açık kaynaklı kütüphane yeniden kullanımıyla özel fonksiyonlar, kullanım senaryoları ve komple uygulamalar daha hızlı oluşturun.
  * [Base64 decoder/encoder](https://devpal.co/base64-decode/) — Verileri kodlamak ve kodunu çözmek için ücretsiz çevrimiçi araç.
  * [newreleases.io](https://newreleases.io/) - GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo ve Docker Hub'dan yeni sürümler için e-posta, Slack, Telegram, Discord ve özel webhooklar ile bildirim alın.
  * [OnlineExifViewer](https://onlineexifviewer.com/) — Fotoğraf için GPS konumu ve meta veriler dahil EXIF verilerini anında çevrimiçi görüntüleyin.
  * [PDFMonkey](https://www.pdfmonkey.io/) — PDF şablonlarını bir panelde yönetin, dinamik verilerle API'yi çağırın ve PDF'inizi indirin. Ayda 300 ücretsiz belge sunar.
  * [Pika Code Screenshots](https://pika.style/templates/code-image) — Kod parçacıklarından ve VSCode'dan güzel, özelleştirilebilir ekran görüntüleri oluşturun (eklenti ile).
  * [QuickType.io](https://quicktype.io/) - JSON, şema ve GraphQL'den modeller/sınıf/tip/aralık ve serileştiriciler oluşturun. JSON'u herhangi bir dilde harika, tip güvenli koda dönüştürün.
  * [RandomKeygen](https://randomkeygen.com/) - Herhangi bir uygulama, servis veya cihazı güvenceye almak için kullanabileceğiniz çeşitli rastgele anahtar ve şifreler sunan ücretsiz, mobil uyumlu bir araç.
  * [ray.so](https://ray.so/) - Kod parçacıklarınızın güzel görsellerini oluşturun.
  * [readme.com](https://readme.com/) — Kolayca güzel dokümantasyon oluşturun, Açık Kaynak için ücretsizdir.
  * [redirection.io](https://redirection.io/) — İşletmeler, pazarlama ve SEO için HTTP yönlendirmelerini yönetmeye yönelik SaaS aracı.
  * [redirect.ing](https://redirect.ing/) - Sunucu veya SSL sertifikası yönetmeden hızlı ve güvenli alan adı yönlendirme. Ücretsiz planda 10 ana bilgisayar ve ayda 100.000 istek.
  * [redirect.pizza](https://redirect.pizza/) - HTTPS desteğiyle kolayca yönlendirme yönetin. Ücretsiz planda 10 kaynak ve ayda 100.000 isabet.
  * [ReqBin](https://reqbin.com/) — Çevrimiçi HTTP İstekleri Gönderin. Popüler İstek Yöntemleri: GET, POST, PUT, DELETE ve HEAD. Başlık ve Token Kimlik Doğrulaması destekler. İsteklerinizi kaydetmek için temel bir giriş sistemi içerir.
  * [Smartcar API](https://smartcar.com) - Arabalar için konum bulma, yakıt deposu, pil seviyesi, kilometre sayacı, kapı kilitleme/açma vb. API.
  * [snappify](https://snappify.com) - Geliştiricilerin muhteşem görseller oluşturmasına olanak tanır. Güzel kod parçacıklarından tam teknik sunumlara kadar. Ücretsiz planda aynı anda 3 snap, sınırsız indirme ve ayda 5 yapay zekâ destekli kod açıklaması.
  * [Sunrise and Sunset](https://sunrisesunset.io/api/) - Belirli bir boylam ve enlem için gün doğumu ve gün batımı saatlerini alın.
  * [superfeedr.com](https://superfeedr.com/) — Gerçek zamanlı PubSubHubbub uyumlu beslemeler, dışa aktarma, analiz. Daha az özelleştirme ile ücretsizdir.
  * [SurveyMonkey.com](https://www.surveymonkey.com) — Çevrimiçi anketler oluşturun. Sonuçları çevrimiçi analiz edin. Ücretsiz planda anket başına sadece 10 soru ve 100 yanıt.
  * [Tiledesk](https://tiledesk.com) - Sohbet botları ve konuşmaya dayalı uygulamalar oluşturun. Bunları web sitenizden (canlı sohbet widget'ı) WhatsApp'a kadar çoklu kanala getirin. Sınırsız sohbet botu ile ücretsiz plan.
  * [Versionfeeds](https://versionfeeds.com) — Favori yazılımlarınızın sürümleri için özel RSS beslemeleri. Programlama dillerinizin, kütüphanelerinizin veya sevdiğiniz araçların en son sürümlerini tek bir beslemede tutun. (İlk 3 besleme ücretsiz)
  * [videoinu](https://videoinu.com) — Ekran kayıtları ve diğer videoları çevrimiçi oluşturun ve düzenleyin.
  * [Webacus](https://webacus.dev) — Kodlama, kod çözme ve veri manipülasyonu için geniş kapsamlı ücretsiz geliştirici araçlarına erişin.

**[⬆️ Başa Dön](#table-of-contents)**

## Uzak Masaüstü Araçları

  * [Getscreen.me](https://getscreen.me) —  2 cihaza kadar ücretsiz, oturum sayısı ve süresi sınırsız
  * [Apache Guacamole™](https://guacamole.apache.org/) — Açık kaynaklı istemcisiz uzak masaüstü geçidi
  * [RemSupp](https://remsupp.com) — İsteğe bağlı destek ve cihazlara kalıcı erişim (Günde 2 oturum ücretsiz)
  * [RustDesk](https://rustdesk.com/) - Herkes için açık kaynaklı sanal/uzak masaüstü altyapısı!
  * [AnyDesk](https://anydesk.com) —  3 cihaza kadar ücretsiz, oturum sayısı ve süresi sınırsız

**[⬆️ Başa Dön](#table-of-contents)**

## Oyun Geliştirme

  * [itch.io](https://itch.io/game-assets) — Sprite, döşeme setleri ve karakter paketleri gibi ücretsiz/ücretli varlıklar.
  * [Gamefresco.com](https://gamefresco.com/) — Her yerden oyun sanatçılarından ücretsiz oyun varlıklarını keşfedin, toplayın ve paylaşın.
  * [GameDevMarket](https://gamedevmarket.net) — 2D, 3D, Ses, GUI gibi ücretsiz/ücretli varlıklar.
  * [OpenGameArt](https://opengameart.org) — Müzik, ses, sprite ve gif gibi Açık Kaynak Oyun Varlıkları.
  * [CraftPix](https://craftpix.net) — 2D, 3D, Ses, GUI, arka plan, ikon, döşeme setleri, oyun kitleri gibi ücretsiz/ücretli varlıklar.
  * [Game Icons](https://game-icons.net/) - CC-BY lisanslı ücretsiz biçimlendirilebilir SVG/PNG ikonlar.
  * [LoSpec](https://lospec.com/) — Piksel sanat ve diğer kısıtlayıcı dijital sanatlar oluşturmak için çevrimiçi araçlar, oyunlarınız için seçebileceğiniz çok sayıda eğitim/palet listesi mevcuttur.
  * [ArtStation](https://www.artstation.com/) - Ücretsiz/ücretli 2D, 3D varlıklar & sesler, ikonlar, döşeme setleri, oyun kitleri için MarketPlace. Ayrıca sanat portföyünüzü sergilemek için de kullanılabilir.
  * [Rive](https://rive.app/community/) - Topluluk varlıkları ve ücretsiz planla kendi oyun varlıklarınızı oluşturma imkanı.
  * [Poly Pizza](https://poly.pizza/) - Ücretsiz düşük poli 3D varlıklar
  * [3Dassets.one](https://3dassets.one/) - Doku oluşturmak için 8.000'den fazla ücretsiz/ücretli 3D model ve PBR malzeme.
  * [Kenney](https://www.kenney.nl/assets/) - Ücretsiz (CC0 1.0 Universal lisanslı) 2D, 3D, Ses ve UI oyun varlıkları.
  * [Poliigon](https://www.poliigon.com/) - Ücretsiz ve ücretli dokular (değişken çözünürlükte), modeller, HDRI'ler ve fırçalar. Blender gibi yazılımlara aktarmak için ücretsiz eklentiler sunar.
  * [Freesound](https://freesound.org/) - Farklı CC lisanslarına sahip ücretsiz ortak çalışma ses kütüphanesi.

**[⬆️ Başa Dön](#table-of-contents)**

## Diğer Ücretsiz Kaynaklar

  * [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - Web geliştiriciler için her zaman ücretsiz araçlar: CSS küçültme/açma, görüntü optimize etme, görüntü yeniden boyutlandırma, büyük-küçük harf dönüştürücü, CSS doğrulayıcı, JavaScript derleyici, HTML editörü ve daha fazlası.
  * [ElevateAI](https://www.elevateai.com) - Her ay 200 saate kadar ücretsiz ses transkripsiyonu alın.
  * [get.localhost.direct](https://get.localhost.direct) — Alt alan adı desteğiyle localhost geliştirme için daha iyi bir `*.localhost.direct` Genel CA imzalı SSL sertifikası
  * [Framacloud](https://degooglisons-internet.org/en/) — Fransız kar amacı gütmeyen [Framasoft](https://framasoft.org/en/) tarafından sunulan Ücretsiz/Libre Açık Kaynak Yazılım ve SaaS listesi.
  * [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — Geliştiriciler için ücretsiz ve Açık Kaynak yazılım merkezi.
  * [GitHub Education](https://education.github.com/pack) — Öğrenciler için ücretsiz hizmetler koleksiyonu. Kayıt gereklidir.
  * [Markdown Tools](https://markdowntools.com) - HTML, CSV, PDF, JSON ve Excel dosyalarını Markdown'a ve tersi yönde dönüştürmek için araçlar
  * [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Microsoft 365 platformu için çözümler oluşturmanız için ücretsiz bir sandbox, araçlar ve diğer kaynaklar. Abonelik 90 günlük [Microsoft 365 E5 Aboneliği](https://www.microsoft.com/microsoft-365/enterprise/e5) (Windows hariç) olup yenilenebilir. Geliştirmede aktif olursanız (telemetri verileri ve algoritmalarla ölçülür) yenilenir.
  * [Pyrexp](https://pythonium.net/regex) — Düzenli ifadeleri hata ayıklamak için ücretsiz web tabanlı regex test ve görselleştirici.
  * [RedHat for Developers](https://developers.redhat.com) — Sadece geliştiriciler için RHEL, OpenShift, CodeReady ve daha fazlası dahil Red Hat ürünlerine ücretsiz erişim. Sadece bireysel plan. Referans için ücretsiz e-kitaplar da sunulmaktadır.
  * [smsreceivefree.com](https://smsreceivefree.com/) — Ücretsiz geçici ve tek kullanımlık telefon numaraları sağlar.
  * [sandbox.httpsms.com](https://sandbox.httpsms.com) — Test amaçlı SMS gönderip almak için ücretsiz.
  * [SimpleBackups.com](https://simplebackups.com/) — Sunucular ve veritabanları (MySQL, PostgreSQL, MongoDB) için otomatik yedekleme servisi, yedekler doğrudan bulut depolama sağlayıcılarında (AWS, DigitalOcean, Backblaze) saklanır. 1 yedek için ücretsiz plan sunar.
  * [SnapShooter](https://snapshooter.com/) — DigitalOcean, AWS, LightSail, Hetzner ve Exoscale için yedekleme çözümü, doğrudan veritabanı, dosya sistemi ve uygulama yedekleri için s3 tabanlı depolama desteğiyle. Bir kaynak için günlük yedeklemeli ücretsiz plan sunar.
  * [Themeselection](https://themeselection.com/) — Seçili yüksek kaliteli, modern tasarımlı, profesyonel ve kullanımı kolay Ücretsiz Yönetici Paneli Şablonu,
HTML Temaları ve UI Kitleri ile uygulamalarınızı daha hızlı oluşturun!
  * [Web.Dev](https://web.dev/measure/) — Web sitenizin performansını görmenizi ve SEO'yu iyileştirerek arama motorlarındaki sıralamanızı artırmanızı sağlayan ücretsiz bir araçtır.
  * [SmallDev.tools](https://smalldev.tools/) — Geliştiriciler için çeşitli formatlarda Kodlama/Çözme, HTML/CSS/Javascript Sıkıştırma, Güzelleştirme, Sahte/Test veri setleri oluşturma (JSON/CSV & birden fazla formatta) ve birçok başka özelliği sunan ücretsiz bir araç. Keyifli bir arayüz ile.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — Web uygulamanıza dakikalar içinde CSV ve Excel içe aktarma ekleyin. Kullanıcılarınıza keyifli ve sağlam bir veri içe aktarma deneyimi sunun. Hiçbir kredi kartı bilgisi gerektirmeden ücretsiz başlayın ve bugün UseCSV’yi entegre etmeye başlayın. Sınırsız İçe Aktarıcı oluşturabilir ve 100Mb’a kadar dosya yükleyebilirsiniz.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — Projenizde kullanabileceğiniz 100’den fazla buton.
  * [WrapPixel](https://www.wrappixel.com/) — Angular, React, VueJs, NextJS ve NuxtJS ile oluşturulmuş Yüksek Kaliteli Ücretsiz ve Premium Admin paneli şablonlarını indirin!
  * [Utils.fun](https://utils.fun/en) — Tarayıcı hesaplama gücüne dayalı tüm çevrimdışı günlük ve geliştirme araçları; filigran oluşturma, ekran kaydı, kodlama ve çözme, şifreleme ve şifre çözme, kod biçimlendirme dâhil olmak üzere tamamen ücretsizdir ve hiçbir veriyi buluta yüklemeden işler.
  * [It tools](it-tools.tech) - Geliştiriciler ve BT sektöründe çalışanlar için kullanışlı araçlar.
  * [Free Code Tools](https://freecodetools.org/) — %100 ücretsiz etkili kod araçları. Markdown editörü, Kod sıkıştırıcı/güzelleştirici, QR kodu oluşturucu, Open Graph Oluşturucu, Twitter kartı Oluşturucu ve daha fazlası.
  * [regex101](https://regex101.com/) — Ücretsiz bu web sitesi, düzenli ifadeleri (regex) test etmenize ve hata ayıklamanıza olanak tanır. Bir regex editörü ve test aracı ile regex öğrenmek için faydalı dokümantasyon ve kaynaklar sağlar.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — Biçimlendirici, sıkıştırıcı ve dönüştürücü dâhil 100+ geliştirici aracı.
  * [AdminMart](https://adminmart.com/) — Angular, Bootstrap, React, VueJs, NextJS ve NuxtJS ile oluşturulmuş Yüksek Kaliteli Ücretsiz ve Premium Admin Paneli ve Web Sitesi Şablonları!
  * [Glob tester](https://globster.xyz/) — Glob desenleri tasarlayabileceğiniz ve test edebileceğiniz bir web sitesi. Ayrıca glob desenlerini öğrenmek için kaynaklar da sunar.
  * [SimpleRestore](https://simplerestore.io) - Sorunsuz MySQL yedek geri yükleme. MySQL yedeklerinizi herhangi bir uzak veritabanına kod veya sunucu olmadan geri yükleyin.
  * [360Converter](https://www.360converter.com/) - Video’dan Metin’e && Ses’ten Metin’e && Konuşma’dan Metin’e && Gerçek Zamanlı Ses’ten Metin’e && YouTube Video’dan Metin’e && Video Altyazısı ekleme gibi dönüşümler için kullanışlı ücretsiz bir web sitesi. Kısa video veya YouTube eğitimlerinde faydalı olabilir:)
  * [QRCodeBest](https://qrcode.best/) - 13 şablon ile özel QR kodları oluşturun, tam gizlilik ve kişisel marka imkânı. QRCode.Best’te takip pikselleri, proje kategorilendirme ve sınırsız takım üyesi özellikleri.
  * [PostPulse](https://PostPulseAI.com) - Aylık olarak SEO’ya uygun alanlara yapay zekâ ile hazırlanmış gönderilerle çevrimiçi varlığınızı artırın, SEO ve site sıralamanızı yükseltin. Ücretsiz Plan ile her ay sitemizde manuel olarak bir gönderi paylaşabilirsiniz.
  * [PageTools](https://pagetools.co/) - Tek tıkla web sitesi politikaları oluşturma, sosyal medya biyografileri, gönderiler ve web sayfaları oluşturma gibi temel ihtiyaçlarınız için sonsuza kadar ücretsiz yapay zekâ destekli araçlar sunar.
  * [MySQL Visual Explain](https://mysqlexplain.com) - Yavaş sorguları optimize etmek için kullanımı kolay ve ücretsiz MySQL EXPLAIN çıktısı görselleştirici.
  * [Killer Coda](https://killercoda.com/)  - Tarayıcınızda Linux, Kubernetes, Konteynerler, Programlama, DevOps, Ağ konularını çalışabileceğiniz interaktif alan.
  * [Axonomy App](https://axonomy-app.com/) - Faturalarınızı oluşturmak, yönetmek ve müşterilerinizle paylaşmak için ücretsiz bir araç. Aylık 10 ücretsiz fatura.
  * [Table Format Converter](https://www.tableformatconverter.com) - Tablo verilerini CSV, HTML, JSON, Markdown ve daha fazla formata dönüştürmek için ücretsiz bir araç.


**[⬆️ Başa Dön](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---