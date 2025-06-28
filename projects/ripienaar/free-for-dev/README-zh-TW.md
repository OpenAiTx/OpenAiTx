# free-for.dev

開發者與開源作者現在有許多服務提供免費層級，但要找到所有這些服務，並做出明智的決策，仍需花費時間。

這是一份包含軟體（SaaS、PaaS、IaaS 等）及其他免費開發者層級服務的清單。

本清單的範圍僅限於基礎設施開發人員（系統管理員、DevOps 實踐者等）可能會覺得有用的項目。我們喜歡所有免費服務，但希望主題能夠聚焦。有時這是一條灰色地帶，所以這份清單帶有主觀性；如果我沒有接受您的貢獻，請不要感到被冒犯。

這份清單來自於 1600 多人提交的 Pull Request、審查、點子與努力。你也可以協助，透過提交 [Pull Requests](https://github.com/ripienaar/free-for-dev) 新增更多服務，或移除那些已改變或下架的服務。

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**注意**：本清單僅收錄 as-a-Service 服務，不包含自架軟體。服務必須提供免費層級（非僅限於免費試用），若有時間限制，至少需提供一年。我們也會從安全角度考慮免費層級，所以 SSO 沒問題，但限制 TLS 只能付費使用的服務不會被接受。

# 目錄

  * [主要雲端供應商的永久免費額度](#major-cloud-providers)
  * [雲端管理解決方案](#cloud-management-solutions)
  * [分析、事件與統計](#analytics-events-and-statistics)
  * [API、資料與機器學習](#apis-data-and-ml)
  * [制品倉庫](#artifact-repos)
  * [BaaS](#baas)
  * [低程式碼平台](#low-code-platform)
  * [CDN 與防護](#cdn-and-protection)
  * [CI 與 CD](#ci-and-cd)
  * [CMS](#cms)
  * [程式碼生成](#code-generation)
  * [程式碼品質](#code-quality)
  * [程式碼搜尋與瀏覽](#code-search-and-browsing)
  * [崩潰與例外處理](#crash-and-exception-handling)
  * [地圖數據視覺化](#data-visualization-on-maps)
  * [託管資料服務](#managed-data-services)
  * [設計與 UI](#design-and-ui)
  * [設計靈感](#design-inspiration)
  * [開發者部落格平台](#dev-blogging-sites)
  * [DNS](#dns)
  * [Docker 相關](#docker-related)
  * [網域](#domain)
  * [教育與職涯發展](#education-and-career-development)
  * [電子郵件](#email)
  * [功能切換管理平台](#feature-toggles-management-platforms)
  * [字型](#font)
  * [表單](#forms)
  * [生成式 AI](#generative-ai)
  * [IaaS](#iaas)
  * [IDE 與程式碼編輯](#ide-and-code-editing)
  * [國際手機號碼驗證 API 與 SDK](#international-mobile-number-verification-api-and-sdk)
  * [議題追蹤與專案管理](#issue-tracking-and-project-management)
  * [日誌管理](#log-management)
  * [行動應用分發與回饋](#mobile-app-distribution-and-feedback)
  * [管理系統](#management-system)
  * [訊息與串流](#messaging-and-streaming)
  * [雜項](#miscellaneous)
  * [監控](#monitoring)
  * [PaaS](#paas)
  * [套件建置系統](#package-build-system)
  * [支付與帳單整合](#payment-and-billing-integration)
  * [隱私管理](#privacy-management)
  * [截圖 API](#screenshot-apis)
  * [Flutter 相關與免 Mac 打包 IOS 應用](#flutter-related-and-building-ios-apps-without-mac)
  * [搜尋](#search)
  * [安全與 PKI](#security-and-pki)
  * [認證、授權與用戶管理](#authentication-authorization-and-user-management)
  * [原始碼倉庫](#source-code-repos)
  * [儲存與媒體處理](#storage-and-media-processing)
  * [通道、WebRTC、Web Socket 伺服器及其他路由](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [測試](#testing)
  * [團隊協作工具](#tools-for-teams-and-collaboration)
  * [翻譯管理](#translation-management)
  * [Vagrant 相關](#vagrant-related)
  * [訪客會話錄製](#visitor-session-recording)
  * [網站託管](#web-hosting)
  * [評論平台](#commenting-platforms)
  * [瀏覽器硬體模擬](#browser-based-hardware-emulation-written-in-javascript)
  * [遠端桌面工具](#remote-desktop-tools)
  * [遊戲開發](#game-development)
  * [其他免費資源](#other-free-resources)

## 主要雲端供應商

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 每日 28 小時前端執行個體時數，9 小時後端執行個體時數
    * Cloud Firestore - 1GB 儲存空間，每日 50,000 次讀取、20,000 次寫入、20,000 次刪除
    * Compute Engine - 1 個非可搶占型 e2-micro，30GB HDD，5GB 快照儲存（僅限特定區域），每月 1GB 網路出口（北美到所有區域，除中國與澳洲）
    * Cloud Storage - 5GB 儲存空間，1GB 網路出口
    * Cloud Shell - 網頁版 Linux shell/主要 IDE，5GB 持久儲存。每週限 60 小時
    * Cloud Pub/Sub - 每月 10GB 訊息
    * Cloud Functions - 每月 200 萬次調用（包含背景與 HTTP 調用）
    * Cloud Run - 每月 200 萬請求、360,000 GB-秒記憶體、180,000 vCPU-秒運算時間、每月 1GB 北美網路出口
    * Google Kubernetes Engine - 一個區域性叢集免收管理費。每個用戶節點按標準 Compute Engine 價格收費
    * BigQuery - 每月 1TB 查詢、10GB 儲存
    * Cloud Build - 每日 120 分鐘建置時間
    * Cloud Source Repositories - 最多 5 位用戶、50GB 儲存、50GB 出口
    * [Google Colab](https://colab.research.google.com/) - 免費 Jupyter Notebooks 開發環境
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio（前身為 Project IDX）。線上 VSCode 運行於 Google Cloud。
    * 完整詳細清單 - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 每月 1TB 出口流量與 200 萬次函數調用
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 個自訂指標與 10 個警報
* [CodeBuild](https://aws.amazon.com/codebuild/) - 每月 100 分鐘建置時間
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 名活躍使用者、50GB 儲存空間，以及每月 10,000 次請求
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 每月 1 條活躍管線
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GB NoSQL 資料庫
* [EC2](https://aws.amazon.com/ec2/) - 每月 750 小時 t2.micro 或 t3.micro（12 個月）。每月 100GB 外送流量
* [EBS](https://aws.amazon.com/ebs/) - 每月 30GB 通用型 (SSD) 或磁碟型（12 個月）
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 每月 750 小時（12 個月）
* [RDS](https://aws.amazon.com/rds/) - 每月 750 小時 db.t2.micro、db.t3.micro 或 db.t4g.micro，20GB 通用型 (SSD) 儲存空間，20GB 備份儲存空間（12 個月）
* [S3](https://aws.amazon.com/s3/) - 5GB 標準物件儲存，20,000 次 Get 請求及 2,000 次 Put 請求（12 個月）
* [Glacier](https://aws.amazon.com/glacier/) - 10GB 長期物件儲存
* [Lambda](https://aws.amazon.com/lambda/) - 每月 1 百萬次請求
* [SNS](https://aws.amazon.com/sns/) - 每月 1 百萬次發佈
* [SES](https://aws.amazon.com/ses/) - 每月 3,000 封郵件（12 個月）
* [SQS](https://aws.amazon.com/sqs/) - 每月 1 百萬次訊息佇列請求
* 完整詳細列表 - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 台 B1S Linux VM，1 台 B1S Windows VM（12 個月）
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 個網站、行動或 API 應用程式（每日 60 CPU 分鐘）
  * [Functions](https://azure.microsoft.com/services/functions/) - 每月 1 百萬次請求
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - 快速、簡易且精簡的開發測試環境
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500,000 個物件
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 每月 50,000 名儲存使用者
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 名活躍使用者，無限私有 Git 儲存庫
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — Linux、macOS 和 Windows 開源專案免費 10 個平行工作、無限時數
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 每日 8,000 則訊息
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 個免費的公開負載平衡 IP (VIP)
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 1 百萬則推播通知
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15GB 入口（12 個月）及每月 5GB 外送流量
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GB 儲存空間及 1000 RUs 配置吞吐量
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — 免費 SSL、驗證授權及自訂網域，建置、部署並託管靜態應用和無伺服器函數
  * [Storage](https://azure.microsoft.com/services/storage/) - 5GB LRS 檔案或 Blob 儲存空間（12 個月）
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - AI/ML API（電腦視覺、翻譯、臉部辨識、機器人等）免費層包含有限次數
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - AI 搜尋與索引服務，免費 10,000 份文件
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - 託管式 Kubernetes 服務，免費叢集管理
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 每月 100,000 次操作
  * 完整詳細列表 - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * 計算
     - 2 台基於 AMD 的 Compute VM，各配 1/8 OCPU 及 1GB 記憶體
     - 4 核心 Arm 架構 Ampere A1 及 24GB 記憶體，可作為單一 VM 或最多 4 台 VM
     - [閒置時將會收回](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)
  * 區塊儲存 - 2 卷，共 200GB（用於計算）
  * 物件儲存 - 10GB
  * 負載平衡器 - 1 實例，10 Mbps
  * 資料庫 - 2 個資料庫，各 20GB
  * 監控 - 5 億筆攝取資料點，10 億筆檢索資料點
  * 頻寬 - 每月 10TB 外送流量，x64 VM 最高 50 Mbps，ARM VM 最高 500 Mbps * 核心數
  * 公開 IP - VM 可用 2 個 IPv4，負載平衡器 1 個 IPv4
  * 通知 - 每月 100 萬次遞送選項，每月 1,000 封郵件發送
  * 完整詳細列表 - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Cloudant 資料庫 - 1GB 儲存空間
  * Db2 資料庫 - 100MB 儲存空間
  * API Connect - 每月 50,000 次 API 呼叫
  * 可用性監控 - 每月 300 萬筆資料點
  * 日誌分析 - 每日 500MB 日誌
  * 完整詳細列表 - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [應用服務](https://www.cloudflare.com/plans/) - 無限域名免費 DNS、DDoS 防護、CDN 及免費 SSL、防火牆規則與頁面規則、WAF、機器人防護、免費不限次速率限制（每域 1 條）、分析、郵件轉發
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - 最多 50 名使用者、24 小時活動日誌、3 個網路位置
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - 可將本機 HTTP 埠透過 tunnel 曝露於 trycloudflare.com 隨機子網域（使用 [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/)，無需帳號）。更多功能（TCP tunnel、負載平衡、VPN）見 [Zero Trust](https://www.cloudflare.com/products/zero-trust/) 免費方案。
  * [Workers](https://developers.cloudflare.com/workers/) - 在 Cloudflare 全球網路免費部署無伺服器程式碼，每日 10 萬次請求
  * [Workers KV](https://developers.cloudflare.com/kv) - 每日 10 萬次讀取、1,000 次寫入、1,000 次刪除、1,000 次列表操作，1GB 儲存
  * [R2](https://developers.cloudflare.com/r2/) - 每月 10GB，100 萬次 Class A 操作，1,000 萬次 Class B 操作
  * [D1](https://developers.cloudflare.com/d1/) - 每日 500 萬行讀取、10 萬行寫入，1GB 儲存
  * [Pages](https://developers.cloudflare.com/pages/) - 在 Cloudflare 快速安全的全球網路開發和部署網站。每月 500 次建置、100 個自訂網域、整合 SSL、無限席位、無限預覽部署，並可經由 Workers 整合實現全端能力。
  * [Queues](https://developers.cloudflare.com/queues/) - 每月 100 萬次操作
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 每月 1TB 免費（外送）流量

**[⬆️ 回到頂端](#table-of-contents)**

## 雲端管理解決方案

* [Brainboard](https://www.brainboard.co) - 協作式解決方案，從端到端視覺化建構和管理雲端基礎架構。
* [Cloud 66](https://www.cloud66.com/) - 個人專案免費（含一台部署伺服器、一個靜態網站），Cloud 66 提供建置、部署及擴展應用於任何雲端所需一切，無需擔心伺服器管理。
* [Pulumi](https://www.pulumi.com/) — 現代化基礎架構即程式碼平台，允許使用熟悉的程式語言和工具建構、部署及管理雲端基礎架構。
* [terraform.io](https://www.terraform.io/) — Terraform Cloud。免費遠端狀態管理和團隊協作，最多 500 項資源。
* [scalr.com](https://scalr.com/) - Scalr 是一款 Terraform 自動化與協作（TACO）產品，可提升 Terraform 管理下基礎架構與組態的協作和自動化。完整支援 Terraform CLI、OPA 整合與分層組態模型。無 SSO 額外費用。所有功能全包含。每月可免費使用 50 次運行。
* [deployment.io](https://deployment.io) - Deployment.io 協助開發者自動化 AWS 部署。免費方案下，開發者（單一用戶）可部署無限靜態網站、網路服務與環境。每月免費 20 次作業執行，包含預覽與自動部署。

**[⬆️ 回到頂端](#table-of-contents)**

## 原始碼儲存庫

* [Bitbucket](https://bitbucket.org/) — 最多 5 名使用者不限量公有及私有 Git 儲存庫，含 Pipelines CI/CD
* [chiselapp.com](https://chiselapp.com/) — 不限量公有及私有 Fossil 儲存庫
* [codebasehq.com](https://www.codebasehq.com/) — 免費 1 個專案，100MB 空間，2 位使用者
* [Codeberg](https://codeberg.org/) — 免費及開源專案不限量公有及私有 Git 儲存庫（無限協作者）。由 [Forgejo](https://forgejo.org/) 驅動。提供 [Codeberg Pages](https://codeberg.page/) 靜態網站託管、[Codeberg's CI](https://docs.codeberg.org/ci/) CI/CD 託管、[Codeberg Translate](https://translate.codeberg.org/) 翻譯託管。包含套件與容器託管、專案管理及議題追蹤
* [GitGud](https://gitgud.io) — 不限量公有及私有儲存庫，永久免費。由 GitLab & Sapphire 支援。不含 CI/CD。
* [GitHub](https://github.com/) — 不限量公有儲存庫及不限量私有儲存庫（無限協作者）。包含 CI/CD、開發環境、靜態託管、套件與容器託管、專案管理及 AI Copilot
* [gitlab.com](https://about.gitlab.com/) — 最多 5 名協作者不限量公有及私有 Git 儲存庫。包含 CI/CD、靜態託管、容器登錄、專案管理及議題追蹤
* [framagit.org](https://framagit.org/) — Framagit 是由 Framasoft 經營、基於 GitLab 軟體的軟體開發平台，包含 CI、靜態頁面、專案頁及議題追蹤。
* [heptapod.net](https://foss.heptapod.net/) — Heptapod 是 GitLab 社群版的友好分支，支援 Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) - 用於開發 Ionic 應用的儲存庫與工具；同時提供 ionic repo
* [NotABug](https://notabug.org) — NotABug.org 是自由軟體協作平台，專為自由授權專案，基於 Git
* [OSDN](https://osdn.net/) - OSDN.net 為開源軟體開發者提供免費服務，支援 SVN/Git/Mercurial/Bazaar/CVS 儲存庫。
  * [Pagure.io](https://pagure.io) — Pagure.io 是一個免費且開源的軟體代碼協作平台，適用於 FOSS 授權專案，基於 Git
  * [perforce.com](https://www.perforce.com/products/helix-teamhub) — 免費 1GB 雲端空間，支援 Git、Mercurial 或 SVN 儲存庫。
  * [pijul.com](https://pijul.com/) - 無限免費且開源的分散式版本控制系統。其獨特功能基於嚴謹的補丁理論，使其易於學習、使用與分發，解決了 git/hg/svn/darcs 的諸多問題。
  * [plasticscm.com](https://plasticscm.com/) — 對個人、開源專案及非營利組織免費
  * [projectlocker.com](https://projectlocker.com) — 提供一個免費私人專案（Git 與 Subversion），空間 50 MB
  * [RocketGit](https://rocketgit.com) — 基於 Git 的儲存庫託管。無限公開與私人儲存庫。
  * [savannah.gnu.org](https://savannah.gnu.org/) - 作為自由軟體專案（GNU 專案）協作開發管理系統
  * [savannah.nongnu.org](https://savannah.nongnu.org/) - 作為自由軟體專案（非 GNU 專案）協作開發管理系統

**[⬆️ 回到頂部](#table-of-contents)**

## APIs、資料與機器學習

  * [JSONGrid](https://jsongrid.com) - 免費工具，將複雜的 JSON 資料視覺化、編輯與過濾為美觀的表格網格。可儲存並透過連結分享 JSON 資料。
  * [Zerosheets](https://zerosheets.com) - 將您的 Google Sheets 試算表轉為強大的 API，以便快速開發原型、網站、應用程式等。免費每月 500 次請求。
  * [IP.City](https://ip.city) — 每天 100 次免費 IP 地理定位查詢
  * [Abstract API](https://www.abstractapi.com) — 提供多種用途的 API 套件，包括 IP 地理定位、性別偵測或電子郵件驗證等。
  * [Apify](https://www.apify.com/) — 網頁爬取與自動化平台，可為任何網站建立 API 並擷取資料。提供現成爬蟲、整合代理伺服器與客製化解決方案。免費方案每月含 $5 平台點數。
  * [APITemplate.io](https://apitemplate.io) - 透過簡單的 API 或 Zapier、Airtable 等自動化工具自動產生圖片與 PDF 文件，無需 CSS/HTML。免費方案每月 50 張圖片與三個範本。
  * [APIToolkit.io](https://apitoolkit.io) - 提供所有您理解 API 與後端所需的工具。包含自動 API 契約驗證與監控。免費方案支援單一伺服器每日最多 10,000 請求。
  * [APIVerve](https://apiverve.com) - 免費即時存取 120+ 個高品質、一致且可靠的 API。免費方案每月 50 個 API Token。（2025-06-25 可能已下線）
  * [Arize AI](https://arize.com/) - 機器學習監控平台，用於模型監控及追蹤資料品質與效能漂移等問題。免費支援最多兩個模型。
  * [Maxim AI](https://getmaxim.ai/) - 模擬、評估與觀察您的 AI 代理人。Maxim 是端到端評估與監控平台，協助團隊可靠且提升 5 倍速度部署 AI 代理。個人與小型團隊（3 位）永久免費。
  * [Beeceptor](https://beeceptor.com) - 秒建 REST API 模擬器，假 API 回應等功能。免費每日 50 次請求，公開儀表板、開放端點（持有儀表板連結者可檢視提交與回覆）。
  * [BigDataCloud](https://www.bigdatacloud.com/) - 提供快速、精確且免費（不限量或每月 10K-50K 次）API，包括 IP 地理定位、反向地理編碼、網路資訊、電子郵件與電話驗證、客戶端資訊等。
  * [Browse AI](https://www.browse.ai) — 網頁資料擷取與監控。每月免費 1,000 點數，相當於 1,000 次並發請求。
  * [BrowserCat](https://www.browsercat.com) - Headless browser API，適用於自動化、爬蟲、AI Agent 網頁存取、圖片/PDF 產生等。免費方案每月 1,000 次請求。
  * [Calendarific](https://calendarific.com) - 企業級全球 200+ 國家公共假日 API。免費方案每月 500 次請求。
  * [Canopy](https://www.canopyapi.co/) - Amazon.com 商品、搜尋與分類資料的 GraphQL API。免費方案每月 100 次請求。
  * [Clarifai](https://www.clarifai.com) — 影像 API，支援自訂臉部辨識與偵測，能訓練 AI 模型。免費方案每月 1,000 次呼叫。
  * [Cloudmersive](https://cloudmersive.com/) — 實用型 API 平台，完整存取龐大 API 資料庫，包括文件轉檔、病毒掃描等，每月 600 次呼叫，僅限北美 AZ，單檔最大 2.5MB。
  * [Colaboratory](https://colab.research.google.com) — 免費的網頁版 Python 筆記本環境，配備 Nvidia Tesla K80 GPU。
  * [CometML](https://www.comet.com/site/) - MLOps 平台，支援實驗追蹤、模型生產管理、模型註冊與完整資料來源管理，涵蓋從訓練到生產的工作流。對個人與學術用戶免費。
  * [Commerce Layer](https://commercelayer.io) - 可組合的電商 API，能從任何前端建立、下訂與管理訂單。開發者方案每月免費 100 筆訂單與最多 1,000 個 SKU。
  * [Composio](https://composio.dev/) - AI Agents 與 LLMs 的整合平台。整合 200+ 工具，橫跨代理網際網路。
  * [Conversion Tools](https://conversiontools.io/) - 線上文件、圖片、影片、音訊、電子書轉檔工具。提供 REST API，支援 Node.js、PHP、Python 函式庫。付費方案支援檔案最大 50 GB。免費層受限於單檔 20MB、每日 30 次/月 300 次轉檔。
  * [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - 提供國家、地區、省份、城市、郵遞區號等豐富資訊的 API 與微服務。免費層每日 100 次請求。
  * [Coupler](https://www.coupler.io/) - 資料整合工具，能同步多種應用程式之間的資料，可建立即時儀表板和報表、轉換與操作數值、收集與備份洞察。免費方案限單一使用者、資料連線、來源與目的地，需手動刷新資料。
  * [CraftMyPDF](https://craftmypdf.com) - 以拖放編輯器與簡單 API 從可重用範本自動產生 PDF 文件。免費方案每月 100 份 PDF 與三個範本。
  * [Crawlbase](https://crawlbase.com/) — 無須代理、基礎設施或瀏覽器即可爬取與擷取網站內容。我們為您解決驗證碼並防止被封鎖。前 1000 次呼叫免費。
  * [CurlHub](https://curlhub.io) — API 呼叫代理服務，方便檢查與除錯。免費方案每月 10,000 次請求。
  * [CurrencyScoop](https://currencyscoop.com) - 金融科技應用的即時匯率資料 API。免費方案每月 5,000 次呼叫。
  * [Cube](https://cube.dev/) - 協助資料工程師與應用程式開發者存取現代資料庫、組織一致定義並分發至各應用程式。Cube Cloud 免費層每日限 1,000 次查詢。
  * [Data Dead Drop](https://datadeaddrop.com) - 簡易免費檔案分享。資料存取後自動銷毀。可用瀏覽器或命令列工具上傳與下載。
  * [Data Fetcher](https://datafetcher.com) - 無需程式碼將 Airtable 連接至任何應用程式或 API。類似 Postman 介面可在 Airtable 執行 API 請求。內建多個應用整合。免費方案每月 100 次執行。
  * [Dataimporter.io](https://www.dataimporter.io) - 用於連接、清理並匯入資料至 Salesforce 的工具。免費方案每月最多 20,000 筆紀錄。
  * [Datalore](https://datalore.jetbrains.com) - Jetbrains 推出的 Python 筆記本。每月 10 GB 儲存空間、120 小時運算時間。
  * [Data Miner](https://dataminer.io/) - 瀏覽器擴充套件（Google Chrome、MS Edge），可從網頁擷取資料至 CSV 或 Excel。免費方案每月 500 頁。
  * [Datapane](https://datapane.com) - 用於 Python 建立互動式報表的 API，能將 Python 腳本與 Jupyter Notebook 部署為自助工具。
  * [DB-IP](https://db-ip.com/api/free) - 免費 IP 地理定位 API，每個 IP 每日 1,000 次查詢。lite 資料庫依 CC-BY 4.0 授權亦可免費下載。
  * [DB Designer](https://www.dbdesigner.net/) — 雲端資料庫結構設計與建模工具，免費入門方案可建立 2 個資料庫模型、每模型 10 張資料表。
  * [DeepAR](https://developer.deepar.ai) — 任一平台皆可用的擴增實境臉部濾鏡單一 SDK。免費方案支援每月最多 10 個活躍用戶（MAU），可追蹤最多 4 張臉。
  * [Deepnote](https://deepnote.com) - 新一代資料科學筆記本。相容 Jupyter，支援即時協作與雲端運行。免費層可建立不限個人專案、不限基本機器（5GB RAM、2vCPU），團隊最多 3 位編輯者。
  * [Disease.sh](https://disease.sh/) — 免費 API，提供準確新冠疫情相關數據，協助開發實用應用。
  * [Doczilla](https://www.doczilla.app/) — SaaS API，能直接從 HTML/CSS/JS 生成截圖或 PDF。免費方案每月 250 份文件。
  * [Doppio](https://doppio.sh/) — 受管 API，使用高階渲染技術產生並私密儲存 PDF 與截圖。免費方案每月 400 份 PDF 與截圖。
  * [drawDB](https://drawdb.app/) — 免費開源線上資料庫圖表編輯器，無需註冊。
  * [dreamfactory.com](https://dreamfactory.com/) — 開源 REST API 後端，適用於行動、網頁及 IoT 應用。可連接任一 SQL/NoSQL 資料庫、檔案儲存系統或外部服務，立即建立完整 REST API 平台，含即時文件與用戶管理。
  * [Duply.co](https://duply.co) — 透過 API 與 URL 動態產生圖片，一次設計範本可重複使用。免費層提供 20 點數。
  * [DynamicDocs](https://advicement.io) - 透過 JSON to PDF API 及 LaTeX 範本產生 PDF 文件。免費方案每月 50 次 API 呼叫，並可存取範本庫。
  * [Efemarai](https://efemarai.com) - 機器學習模型與資料測試及除錯平台。可視覺化任意運算圖。免費本地使用。
  * [ERD Lab](https://www.erdlab.io) —  免費雲端 ERD（實體關聯圖）工具，專為開發者設計。免費試用包含 2 個專案、每個 10 張資料表。
  * [ExtendsClass](https://extendsclass.com/rest-client-online.html) - 免費網頁版 HTTP 客戶端，可發送 HTTP 請求。
  * [Export SDK](https://exportsdk.com) - PDF 產生 API，支援拖放範本編輯器，提供 SDK 與無程式碼整合。免費方案每月 250 頁，無限用戶，三個範本。
  * [file.coffee](https://file.coffee/) - 可儲存每檔最多 15MB（註冊帳號後單檔 30MB）的檔案平台。
  * [Financial Data](https://financialdata.net/) - 股市與金融資料 API。免費方案每天 300 次請求。
  * [FormatJSONOnline.com](https://formatjsononline.com) - 免費瀏覽器工具，能即時格式化、驗證、比較及壓縮 JSON 資料。
  * [FraudLabs Pro](https://www.fraudlabspro.com) — 訂單交易信用卡詐騙檢測 REST API，根據訂單輸入參數偵測各種詐騙行為。免費 Micro 方案每月 500 筆交易。
  * [GeoDataSource](https://www.geodatasource.com) — 依緯經度查找城市名稱的定位搜尋服務。免費 API 每月 500 次查詢。
  * [Geolocated.io](https://geolocated.io) — 多洲伺服器的 IP 地理定位 API，免費方案每日 2,000 次請求。
  * [Glitterly](https://glitterly.app/) - 透過 API 程式自動生成動態圖片，自帶模板，支援 nocode 整合。免費層每月 50 張圖片、五個範本。
  * [Hex](https://hex.tech/) - 筆記本、資料應用與知識庫協作資料平台。免費社群層最多 5 個專案。
  * [Hook0](https://www.hook0.com/) - Hook0 是開源 Webhooks-as-a-service（WaaS），使線上產品輕鬆提供 webhook。免費每天可傳送 100 事件、7 天歷史保留。
  * [Hoppscotch](https://hoppscotch.io) - 免費、快速且美觀的 API 請求建構器。
  * [huggingface.co](https://huggingface.co) - 建立、訓練並部署 NLP 模型，支援 Pytorch、TensorFlow、JAX。免費方案每月 30k 輸入字元。
  * [Hybiscus](https://hybiscus.dev/) - 以簡單宣告式 API 建立 PDF 報告。14 天免費層可產生 50 份單頁報告，並可自訂配色與字型。
  * [Invantive Cloud](https://cloud.invantive.com/) — 透過 Invantive SQL 或 OData4（常用於 Power BI 或 Power Query）存取 70+ 個（雲端）平台，如 Exact Online、Twinfield、ActiveCampaign 或 Visma。包含資料複製與交換。開發者與導入顧問免費。特定平台可免費但資料量有限。
  * [ipaddress.sh](https://ipaddress.sh) — 以不同[格式](https://about.ipaddress.sh/)取得公共 IP 的簡單服務。
  * [ip-api](https://ip-api.com) — IP 地理定位 API，非商業用途免費，無需 API 金鑰，免費層每個 IP 每分鐘限 45 次。
  * [ipbase.com](https://ipbase.com) - IP 地理定位 API - 永久免費方案，每月 150 次請求。
  * [IP Geolocation](https://ipgeolocation.io/) — IP 地理定位 API - 開發者永久免費，每天 1,000 次請求上限。
  * [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — Abstract 的 IP 地理定位 API - 提供 1,000 次免費查詢。
  * [IPLocate](https://www.iplocate.io) — IP 地理定位 API，每日免費 1,000 次。含代理/VPN/託管偵測、ASN 資料、IP 對公司等。另提供 IP 對國家、IP 對 ASN 資料庫（CSV 或 GeoIP 相容 MMDB）免費下載。
  * [IP2Location](https://www.ip2location.com) — Freemium IP 地理定位服務。LITE 資料庫可免費下載，伺服器本地導入查詢城市、座標與 ISP 資訊。
  * [IP2Location.io](https://www.ip2location.io/) — Freemium 版，快速可靠的 IP 地理定位 API。查詢城市、座標、ISP 等資料。免費方案每月 50k 點數。另有每月 500 次免費 WHOIS 及託管網域查詢。可查網域註冊資訊及特定 IP 上託管的網域。付費可升級更多功能。
  * [ipapi](https://ipapi.co/) - Kloudend, Inc 提供的 IP 地址定位 API - 建立於 AWS 並受 Fortune 500 信賴的可靠地理定位 API。免費層每月 30k 查詢（每日 1k），無需註冊。
  * [ipapi.is](https://ipapi.is/) - 為開發者打造的可靠 IP 地址 API，擁有同類最佳主機偵測能力。免費方案無需註冊，提供 1000 次查詢。
  * [IPinfo](https://ipinfo.io/) — 快速、精確且免費（每月最多 50k）IP 地址資料 API。提供地理定位、公司、電信商、IP 區段、網域、濫用聯絡資訊等 API。所有付費 API 均可免費試用。
  * [IPQuery](https://ipquery.io) — 開發者專用不限流量 IP API，無速率限制或收費。
  * [IPTrace](https://iptrace.io) — 極為簡單的 API，為企業提供可靠實用的 IP 地理定位資料，每月免費 50,000 次查詢。
  * [JSON2Video](https://json2video.com) - 影片編輯 API，程式化自動化行銷或社群影片，支援程式與無程式碼操作。
  * [JSON IP](https://getjsonip.com) — 回傳用戶端公共 IP 地址的服務。免費層無需註冊。支援 CORS，可用瀏覽器端 JS 直接取得，適合監控用戶端與伺服器 IP 變化。無限請求次數。
  * [JSON Serve](https://jsonserve.com/) — 免費服務，協助開發者儲存 JSON 物件並將其作為 REST API 使用於應用程式。
  * [JSONing](https://jsoning.com/api/) — 從 JSON 物件建立假 REST API，並可自訂 HTTP 狀態碼、標頭與回應主體。
  * [konghq.com](https://konghq.com/) — API 市集及強大的公私有 API 工具。免費層部分功能如監控、警示及支援有限制。
  * [Kreya](https://kreya.app) — 免費 gRPC GUI 客戶端，用於呼叫與測試 gRPC API。可透過伺服器反射導入 API。
  * [Lightly](https://www.lightly.ai/) — 透過正確資料提升機器學習模型。免費使用最多 1000 筆資料集。
  * [LoginLlama](https://loginllama.app) - 登入安全 API，偵測可疑及詐騙登入並通知客戶。每月 1,000 次登入免費。
  * [MailboxValidator](https://www.mailboxvalidator.com) — 透過真實郵件伺服器連線驗證電子郵件有效性的服務。免費 API 方案每月 100 次驗證。
  * [Market Data API](https://www.marketdata.app) - 提供股票、選擇權、共同基金等即時與歷史金融資料。Forever Free API 層每天 100 次 API 請求。
  * [Meteosource Weather API](https://www.meteosource.com/) — 全球天氣 API，提供即時與預報天氣數據。預報資料基於多重天氣模型的機器學習組合，以達到更高精確度。免費方案每日有 400 次呼叫額度。
  * [microlink.io](https://microlink.io/) – 將任意網站轉換為數據，支援 metatags 標準化、美觀連結預覽、抓取功能或螢幕截圖服務。每天 50 次免費請求。
  * [Mindee](https://developers.mindee.com) – Mindee 是強大的 OCR 軟體與 API First 平台，協助開發者透過電腦視覺與機器學習自動化應用工作流，標準化文件處理層，擷取關鍵資訊。免費方案每月提供 500 頁處理量。
  * [Mintlify](https://mintlify.com) — API 文件現代標準。美觀且易於維護的 UI 元件、應用內搜尋及互動式 playground。免費支援 1 位編輯者。
  * [MockAPI](https://www.mockapi.io/) — 簡單易用的工具，可快速建立 API 模擬、生成自訂資料，並透過 RESTful 介面操作。適用於原型設計/測試/學習。免費提供 1 個專案／每專案 2 個資源。
  * [Mockfly](https://www.mockfly.dev/) — 可信賴的 API 模擬與功能旗標管理開發工具。直觀介面可快速產生並管理模擬 API。免費層級每日 500 次請求。
  * [Mocki](https://mocki.io) - 可建立與 GitHub 儲存庫同步的 GraphQL 及 REST API 模擬工具。簡單 REST API 開發與使用皆免費，無需註冊。
  * [Mocko.dev](https://mocko.dev/) — 為 API 提供代理功能，可選擇雲端模擬端點並檢查流量，完全免費。加速開發與整合測試。
  * [Mocky](https://designer.mocky.io/) - 簡單的網頁應用，生成自訂 HTTP 回應以模擬 HTTP 請求。亦提供[開源版本](https://github.com/julien-lafont/Mocky)。
  * [Mock N Roll](https://mpcknroll.me/) - 免費 API 模擬服務——強大工具，用於模擬真實 API 回應，無後端延遲。適合前端開發、QA 測試與 DevOps 團隊。[原始碼](https://github.com/haerulmuttaqin/mocknroll-web)。
  * [microenv.com](https://microenv.com) — 為開發者建立假 REST API，並可生成程式碼與 Docker 容器應用。
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) — 免費且簡單的工具，可跨多個節點檢查出口 IP 地址，了解你的 IP 如何呈現於全球不同地區與服務。適合測試如 Control D 這類基於規則的 DNS 分流工具。
  * [Namekit](https://namekit.app/) - AI 驅動網域名稱搜尋——即時發現可用且標準價格的名稱。每日免費查詢。
  * [News API](https://newsapi.org) — 以程式搜尋網路新聞，獲取 JSON 結果。開發者每日可免費查詢 100 次。文章有 24 小時延遲。
  * [numlookupapi.com](https://numlookupapi.com) - 免費電話號碼驗證 API－每月 100 次免費請求。
  * [OCR.Space](https://ocr.space/) — OCR API，解析圖片及 PDF 檔案，回傳 JSON 格式文字結果。每月 25,000 次免費請求，單檔 1MB 上限。
  * [OpenAPI3 Designer](https://openapidesigner.com/) — 免費視覺化建立 Open API 3 定義工具。
  * [parsehub.com](https://parsehub.com/) — 從動態網站擷取資料，將動態網站轉為 API，免費支援五個專案。
  * [Parseur](https://parseur.com) — 每月 20 頁免費：從 PDF、郵件中擷取資料。AI 驅動。完整 API 存取。
  * [PDFBolt](https://pdfbolt.com) - 以開發者為主的 PDF 生成 API，重視隱私。提供 Stripe 風格文件，每月 500 次免費 PDF 轉換。
  * [pdfEndpoint.com](https://pdfendpoint.com) - 輕鬆透過 API 將 HTML 或網址轉為 PDF。每月 100 次免費轉換。
  * [PDF-API.io](https://pdf-api.io) - PDF 自動化 API，視覺化模板編輯器，HTML 轉 PDF、動態資料整合、PDF 渲染。免費方案含一個模板，每月 100 份 PDF。
  * [Pixela](https://pixe.la/) - 免費日誌資料庫服務。所有操作均透過 API 執行。亦可視覺化成熱力圖或折線圖。
  * [Postman](https://postman.com) — API 開發協作平台，簡化流程、加速打造更佳 API。Postman App 永久免費。Postman 雲端功能亦可免費使用（有部分限制）。
  * [Insomnia](https://insomnia.rest) - 開源 API 客戶端，用於 API 設計及測試，支援 REST 與 GraphQL。
  * [PrefectCloud](https://www.prefect.io/cloud/) — 完整的資料流自動化平台。免費方案含 5 條已部署工作流與每月 500 分鐘無伺服器運算額度。
  * [Preset Cloud](https://preset.io/) - 託管的 Apache Superset 服務。最多 5 人團隊永久免費，含無限儀表板與圖表、零程式碼圖表建構器、協作 SQL 編輯器。
  * [PromptLoop](https://www.promptloop.com/) - PromptLoop 提供 10 倍更簡易的 AI 網頁抓取，幾乎零學習成本，節省 85%+ 現有工作流程時間，運作速度比人工研究快 4 倍，並為所有研究任務提供 REST API 端點。每月前 1,000 點數免費。
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — 免費公共 API 清單。
  * [Rapidapi](https://rapidapi.com/) - 全球最大 API 中心，數百萬開發者尋找並串接數千個 API，提供 API 開發趣味挑戰（含解答）及互動範例。
  * [RequestBin.com](https://requestbin.com) — 建立免費端點接收 HTTP 請求。所有送至該端點的 HTTP 請求會連同 payload 與標頭被記錄，方便觀察 webhook 及其他服務的回應。
  * [reqres.in](https://reqres.in) - 免費託管 REST-API，隨時回應你的 AJAX 請求。
  * [Roboflow](https://roboflow.com) - 無需機器學習經驗，自行建立與部署客製化電腦視覺模型。免費層級含 30 點數／月。
  * [ROBOHASH](https://robohash.org/) - 網頁服務，根據任意文字生成獨特且酷炫的圖片。
  * [Scraper's Proxy](https://scrapersproxy.com) — 簡易 HTTP 代理 API 用於抓取。可匿名抓取，不用擔心限制、封鎖或驗證碼。每月前 100 次成功抓取免費，含 JavaScript 渲染（如需更多可聯繫客服）。
  * [ScrapingAnt](https://scrapingant.com/) — Headless Chrome 抓取 API 及免費代理檢查服務。支援 JavaScript 渲染、輪換代理、避免 CAPTCHA。免費 10,000 API 點數。
  * [Simplescraper](https://simplescraper.io) — 每次操作後觸發 webhook。免費方案含 100 次雲端抓取點數。
  * [Select Star](https://www.selectstar.com/) - 智慧型資料發現平台，能自動分析與紀錄你的資料。免費輕量版支援 2 個資料來源，最多 1,000 資料表及 25 用戶。
  * [Sheetson](https://sheetson.com) - 即時將任意 Google Sheets 轉為 RESTful API。免費方案含每張表格 1,000 列。
  * [Shipyard](https://www.shipyardapp.com) — 雲端低程式碼資料協作平台。結合低程式碼模板與自訂程式碼（Python、Node.js、Bash、SQL）開發。免費開發者方案每月提供 10 小時運行時，僅限 1 人——足以自動化多個工作流程。
  * [Siterelic](https://siterelic.com/) - Siterelic API 可用於網站截圖、稽核、TLS 掃描、DNS 查詢、TTFB 測試等。免費方案每月 100 次 API 請求。
  * [SerpApi](https://serpapi.com/) - 即時搜尋引擎抓取 API。回傳 Google、YouTube、Bing、百度、Walmart 及多個平台的結構化 JSON 結果。免費方案每月 100 次成功 API 呼叫。
  * [SmartParse](https://smartparse.io) - SmartParse 是數據遷移和 CSV 轉 API 平台，提供節省時間與成本的開發工具。免費層級每月 300 個處理單元、瀏覽器上傳、數據隔離、熔斷器與工作提示。
  * [Sofodata](https://www.sofodata.com/) - 由 CSV 檔案建立安全 RESTful API。上傳 CSV 後即可透過 API 存取資料，加速應用開發。免費方案支援 2 個 API、每月 2,500 次呼叫。無須信用卡。
  * [Sqlable](https://sqlable.com/) - 免費線上 SQL 工具組，包括 SQL 格式化、驗證、正則測試器、假資料產生器及互動資料庫 playground。
  * [Stoplight](https://stoplight.io/) - API 協作設計與文件 SaaS。免費方案提供設計、模擬與文件工具。
  * [Supportivekoala](https://supportivekoala.com/) — 依據模板與輸入自動生成圖片。免費方案每月可創建最多 50 張圖片。
  * [Svix](https://www.svix.com/) - Webhook 即服務。每月可免費傳送 50,000 則訊息。
  * [Tavily AI](https://tavily.com/) - 線上搜尋與快速洞察及全面研究 API，具研究結果組織能力。免費層級每月 1,000 次請求，無需信用卡。
  * [The IP API](https://theipapi.com/) - IP 定位 API，每日 1,000 次免費請求。提供 IP 地址的國家、城市、地區等資訊。
  * [TinyMCE](https://www.tiny.cloud) - 富文本編輯 API。核心功能不限次免費使用。
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - 提供免費天氣 API 方案。準確且即時的全球天氣預報，含歷史資料與天氣監控解決方案。
  * [Treblle](https://www.treblle.com) - Treblle 幫助團隊建構、部署與管理 API。進階 API 日誌整合、可觀測性、文件與除錯。全部功能皆免費，但免費層級每月限 25 萬次請求。
  * [UniRateAPI](https://unirateapi.com) – 590+ 種貨幣與加密貨幣即時匯率。免費方案不限 API 呼叫，適合開發者與金融應用。
  * [vatcheckapi.com](https://vatcheckapi.com) - 簡單免費的增值稅號驗證 API。每月 150 次免費驗證。
  * [WeatherXu](https://weatherxu.com/) — 全球天氣數據，含即時狀況、逐小時與每日預報、天氣警報，均可透過 API 存取。整合 AI 與機器學習分析多模型，提升預報精確度。免費層級每月 10,000 次 API 呼叫。
  * [Webhook Store](https://www.openwebhook.io) - 用於存儲第三方 webhook 並在本地（類 ngrok）除錯的工具。開源且可自架設。免費個人網域 *username*.github.webhook.store，免費公共網域 *anything*.webhook.store。
  * [WebScraping.AI](https://webscraping.ai) - 簡單的 Web 抓取 API，內建解析、Chrome 渲染與代理伺服器。每月 2,000 次免費 API 呼叫。
  * [Weights & Biases](https://wandb.ai) — 以開發者為本的 MLOps 平台。實驗追蹤、數據集版本管理、模型管理，協助更快打造更佳模型。個人專案免費層級含 100GB 儲存空間。
  * [What The Diff](https://whatthediff.ai) - AI 驅動的程式碼審查助手。免費方案限每月 25,000 代幣（約 10 個 PR）。
  * [wolfram.com](https://wolfram.com/language/) — 內建於雲端的知識型演算法。
  * [wrapapi.com](https://wrapapi.com/) — 將任何網站轉為可參數化的 API。每月 3 萬次 API 呼叫。
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — 支援 headless 瀏覽器、住宅 IP 的網站抓取 API，價格簡單明瞭。每月 1,000 次免費 API 呼叫，學生及非營利可額外獲得點數。
  * [Zipcodebase](https://zipcodebase.com) - 免費郵遞區號 API，存取全球郵遞區號資料。每月 5,000 次免費請求。
  * [Zipcodestack](https://zipcodestack.com) - 免費郵遞區號 API 及郵遞區號驗證。每月 10,000 次免費請求。
  * [Zuplo](https://zuplo.com/) - 免費 API 管理平台，可設計、建構並部署 API 至 Edge。數分鐘內即可為任意 API 加入金鑰認證、速率限制、開發者文件與營利功能。原生支援 OpenAPI 且完全可程式化（Web 標準 API 與 Typescript）。免費方案支援最多 10 個專案、無限生產環境、每月 100 萬次請求、10GB 流量。

**[⬆️ 返回目錄](#table-of-contents)**

## Artifact Repos

  * [Artifactory](https://jfrog.com/start-free/) - 支援多種套件格式（Maven、Docker、Cargo、Helm、PyPI、CocoaPods、GitLFS）的 artifact 儲存庫。含套件掃描工具 XRay 與 CI/CD 工具 Pipelines（原 Shippable），每月有 2,000 分鐘 CI/CD 免費額度。
  * [central.sonatype.org](https://central.sonatype.org) — Apache Maven、SBT 及其他建構系統的預設 artifact 儲存庫。
  * [cloudrepo.io](https://cloudrepo.io) - 雲端私有／公開 Maven 與 PyPi 儲存庫。開源專案免費。
  * [cloudsmith.io](https://cloudsmith.io) — 簡單、安全、集中式儲存庫服務，支援 Java/Maven、RedHat、Debian、Python、Ruby、Vagrant 等。免費層級＋開源專案免費。
  * [jitpack.io](https://jitpack.io/) — GitHub 上 JVM 及 Android 專案的 Maven 儲存庫，公開專案免費。
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — 易用的 Maven、RPM、DEB、PyPi、NPM、RubyGem 套件儲存服務（有免費層級）。
  * [repsy.io](https://repsy.io) — 1GB 免費私有／公開 Maven 儲存庫。
  * [Gemfury](https://gemfury.com) — Maven、PyPi、NPM、Go Module、Nuget、APT、RPM 私有及公開 artifact 儲存庫。公開專案免費。
  * [paperspace](https://www.paperspace.com/) — AI 模型開發與擴展平台，開發、訓練與部署 AI 應用。免費方案：公共專案、5GB 儲存、基本執行環境。
  * [RepoForge](https://repoforge.io) - 私有雲端託管的 Python、Debian、NPM 套件及 Docker Registry 儲存庫。開源／公開專案免費方案。
  * [RepoFlow](https://repoflow.io) - RepoFlow 支援 npm、PyPI、Docker、Go、Helm 等套件管理，一站式簡化包管理。雲端免費試用含 10GB 儲存、10GB 流量、100 個套件、無限用戶，或個人自架版。

**[⬆️ 返回目錄](#table-of-contents)**

## 團隊協作與協同工具
  * [3Cols](https://3cols.com/) - 免費雲端程式碼片段管理器，支援個人及協同合作。
  * [Bitwarden](https://bitwarden.com) — 最簡單且最安全的個人、團隊及企業敏感資料儲存、分享及同步方案。
  * [Braid](https://www.braidchat.com/) — 為團隊設計的聊天應用。公開群組、無限用戶、訊息歷史與整合皆免費。另有自架開源版本。
  * [cally.com](https://cally.com/) — 輕鬆找到適合所有人會議的時間與日期。簡單易用，適合大小群組。
  * [Calendly](https://calendly.com) — 會議排程協作工具。免費方案每人可連結 1 個行事曆，無限會議。桌面與行動應用皆有。
  * [Discord](https://discord.com/) — 支援公私群組聊天。支援 Markdown 文字、語音、視訊及螢幕分享。用戶數無限制免費。
  * [Fibo](https://fibo.dev) - 免費線上即時 Scrum Poker 工具，適合敏捷團隊，無限人數共同評估故事點數，加速規劃。
  * [Telegram](https://telegram.org/) — 追求快速可靠訊息與通話的用戶皆適用。商務及小團隊可享大型群組、用戶名、桌面應用與強大檔案分享功能。
  * [DevToolLab](https://devtoollab.com) — 提供所有基礎開發工具的線上工具，免費存取，每工具自動保存一筆資料，標準處理速度，社群支援。
  * [Dubble](https://dubble.so/) — 免費的逐步指南建立工具。可截圖、記錄流程並與團隊協作，亦支援非同步螢幕錄影。
  * [Duckly](https://duckly.com/) — 與團隊即時語音、協作。支援 IDE、終端機分享、語音、視訊與畫面分享。小型團隊免費。
  * [Dyte](https://dyte.io) - 最適合開發者的即時影音 SDK，具協作插件提升生產力與參與感。免費層級含每月 10,000 分鐘影音用量。
  * [evernote.com](https://evernote.com/) — 資訊整理工具。分享筆記，與他人協作。
  * [Fibery](https://fibery.io/) — 連結式工作空間平台。單人用戶免費，最多 2GB 空間。
* [flock.com](https://flock.com) — 讓團隊更快溝通的工具。免費提供無限訊息、頻道、用戶、應用程式與整合。
* [Gather](https://www.gather.town/) - 更好的線上會議方式。以完全可自訂空間為核心，Gather 讓你與社群的相處就像現實生活一樣輕鬆。最多可同時 10 人免費使用。
* [gokanban.io](https://gokanban.io) - 基於語法、無需註冊的 Kanban 看板，快速上手。免費且無任何限制。
* [flat.social](https://flat.social) - 為團隊會議和社交時光打造的互動式可自訂空間。無限會議，最多同時 8 人免費。
* [GitDailies](https://gitdailies.com) - 每日提供團隊在 GitHub 上的 Commit 及 Pull Request 活動報告。包含推送視覺化、同儕認可系統、自訂警報建構器。免費方案擁有無限用戶、三個倉庫、三組警報設定。
* [gitter.im](https://gitter.im/) — 專為 GitHub 打造的聊天室。無限公共及私人聊天室，最多 25 人的團隊免費使用。
* [Hackmd.io](https://hackmd.io/) - 實時協作與撰寫 Markdown 格式文件/檔案的工具。類似 Google Docs，但專為 Markdown 文件。免費不限「筆記」數量，但私人筆記及模板的協作者（邀請人數）[會有限制](https://hackmd.io/pricing)。
* [hangouts.google.com](https://hangouts.google.com/) — 所有對話集中於一處，免費但需 Google 帳戶。
* [HeySpace](https://hey.space) - 結合聊天、行事曆、時間軸與視訊通話的任務管理工具。最多 5 名用戶免費。
* [helplightning.com](https://www.helplightning.com/) — 利用擴增實境進行視訊協助。免費版無分析、加密及支援功能。
* [ideascale.com](https://ideascale.com/) — 允許客戶提交與投票點子，1 個社群內最多 25 名成員免費。
* [Igloo](https://www.igloosoftware.com/) — 用於分享文件、部落格、行事曆等的內部入口網站。最多 10 位用戶免費。
* [Keybase](https://keybase.io/) — Keybase 是 FOSS 的 Slack 替代方案，從家庭、社群到企業，讓大家的聊天與檔案安全無虞。
* [Google Meet](https://meet.google.com/) — 滿足企業線上會議需求的 Google Meet。提供安全、易參與的線上會議。
* [/meet for Slack](https://meetslack.com) - 在 Slack 的任何頻道、群組或 DM 中使用 /meet 直接啟動 Google Meetings。免費且無限制。
* [Livecycle](https://www.livecycle.io/) — Livecycle 是一個包容性的協作平台，讓跨部門產品團隊和開源專案的工作流程更順暢。
* [Lockitbot](https://www.lockitbot.com/) — 在 Slack 內預約與鎖定共用資源如會議室、開發環境、伺服器等。最多 2 項資源免費。
* [MarkUp](https://www.markup.io/) — MarkUp 讓你直接在網站、PDF 及圖片上收集回饋意見。
* [Proton Pass](https://proton.me/pass) — 具備內建郵件別名、2FA 驗證、共用與通行密鑰的密碼管理器。提供網頁、瀏覽器擴充、行動應用與桌面版。
* [Visual Debug](https://visualdebug.com) - 提升客戶與開發溝通的視覺化回饋工具。
* [meet.jit.si](https://meet.jit.si/) — 一鍵視訊會議與螢幕分享，完全免費。
* [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams 是以聊天為基礎的數位中樞，將對話、內容與應用集中於單一體驗。最多 50 萬用戶免費。
* [Miro](https://miro.com/) - 可擴展、安全、跨裝置並支援企業的團隊協作白板。提供 Freemium 計畫。
* [nootiz](https://www.nootiz.com/) - 網站視覺回饋與管理的首選工具。
* [Notion](https://www.notion.so/) - Notion 是支援 Markdown 的筆記與協作應用，整合任務、Wiki 與資料庫。官方定位為全能工作空間，支援跨平台應用與網頁存取。
* [Nuclino](https://www.nuclino.com) - 輕量且協作的 Wiki，集中團隊知識、文件與筆記。免費方案含所有基本功能，最多 50 項內容與 5GB 儲存空間。
* [OnlineInterview.io](https://onlineinterview.io/) - 免費的線上程式面試平台，內建視訊、白板及可編譯執行的線上編輯器。一鍵創建遠端面試房間。
* [Quidlo Timesheets](https://www.quidlo.com/timesheets) - 團隊用的簡單工時與時間追蹤應用。免費方案支援最多 10 位用戶，具時間追蹤和報表功能。
* [PageShare.dev](https://www.pageshare.dev) - 讓 GitHub Pull Requests 支援視覺審查，無需部署網站。每月最多 10 頁、共 100MB 儲存免費。
* [Pendulums](https://pendulums.io/) - 免費時間追蹤工具，介面易用並提供有價值的統計數據，幫助更好管理時間。
* [Pumble](https://pumble.com) - 免費團隊聊天應用。無限用戶與訊息歷史，永久免費。
* [Raindrop.io](https://raindrop.io) - 私密安全的書籤管理器，支援 macOS、Windows、Android、iOS 與網頁。免費無限書籤與協作。
* [element.io](https://element.io/) — 基於 Matrix 的去中心化開源通訊工具。群組聊、私聊、加密檔案傳輸、語音與視訊通話，易與其他服務整合。
* [Rocket.Chat](https://rocket.chat/) - 開源通訊平台，擁有全通道功能、Matrix 聯邦、外部應用橋接、無限訊息與完整訊息歷史。
* [seafile.com](https://www.seafile.com/) — 私有或雲端儲存、檔案分享、同步及討論。雲端版僅有 1GB。
* [Sema](https://www.semasoftware.com/) - 免費開發者作品集工具，能將多個倉庫的貢獻整合並快照成單一報告。
* [Screen Sharing via Browser](https://screensharing.net) - 免費螢幕分享工具，直接在瀏覽器與協作者分享，無需下載或註冊。
* [Slab](https://slab.com/) — 現代化團隊知識管理服務。最多 10 位用戶免費。
* [slack.com](https://slack.com/) — 無限用戶免費，部分功能有限制。
* [Spectrum](https://spectrum.chat/) - 免費建立公共或私人社群。
* [StatusPile](https://www.statuspile.com/) - 狀態頁集合站。可追蹤上游供應商的狀態頁。
* [Stickies](https://stickies.app/) - 用於腦力激盪、內容策展與筆記的視覺協作應用。最多 3 面牆免費，無限用戶，1GB 儲存。
* [Stacks](https://betterstacks.com/) - 整合筆記、連結、檔案儲存的內容工作空間，助你應對資訊過載。個人計畫永久免費。
* [talky.io](https://talky.io/) — 免費群組視訊聊天。匿名、點對點、無需外掛、註冊或付費。
* [Teamhood](https://teamhood.com/) - 免費專案、任務與議題追蹤軟體。支援帶泳道的 Kanban 與完整 Scrum，有內建時間追蹤。最多 5 用戶、3 個專案組合免費。
* [Teamplify](https://teamplify.com) - 用 Team Analytics 與 Smart Daily Standup 改善團隊開發流程。適合遠距團隊的完整請假管理。最多 5 人小組免費。
* [Tefter](https://tefter.io) - 強大 Slack 整合的書籤應用。開源團隊免費。
* [TeleType](https://teletype.oorja.io/) — 分享終端機、語音、程式碼、白板等。開發者端對端加密協作，無需登入。
* [TimeCamp](https://www.timecamp.com/) - 免費時間追蹤軟體，無限用戶。可輕鬆整合 Jira、Trello、Asana 等專案管理工具。
* [Huly](https://huly.io/) - 一站式專案管理平台（Linear、Jira、Slack、Notion、Motion 替代品）— 無限用戶，每工作區 10GB 儲存、10GB 視訊（音訊）流量。
* [Teamcamp](https://www.teamcamp.app) - 軟體開發公司的一站式專案管理應用。
* [twist.com](https://twist.com) — 非同步友好的團隊通訊應用，對話組織有序。提供免費與無限方案，合格團隊可享折扣。
* [tldraw.com](https://tldraw.com) — 免費開源白板與圖示工具，具智慧箭頭、吸附、便利貼、SVG 匯出功能。支援多人協作編輯，並有官方 VS Code 擴充。
* [BookmarkOS.com](https://bookmarkos.com) - 免費全合一書籤管理、分頁管理與任務管理，具可自訂線上桌面與資料夾協作。
* [typetalk.com](https://www.typetalk.com/) — 透過網頁或行動裝置即時訊息與團隊分享、討論想法。
* [Tugboat](https://tugboat.qa) - 每個 Pull Request 都有預覽，自動或隨選。全部免費，非營利組織享有 Nano 方案。
* [whereby.com](https://whereby.com/) — 一鍵視訊會議，免費（前稱 appear.in）。
* [windmill.dev](https://windmill.dev/) - Windmill 是開源開發者平台，可用最少 Python/Typescript 腳本，快速打造生產級自動化與內部應用。免費用戶最多可建立與加入三個非高級工作區。
* [vadoo.tv](https://vadoo.tv/) — 簡單易用的影片寄存與行銷平台。單鍵上傳、錄製、管理、分享影片。免費方案每月 10 支影片、1GB 儲存、10GB 流量。
* [userforge.com](https://userforge.com/) - 連結式線上用戶角色、用戶故事及情境圖，幫助設計與開發同步。最多 3 角色與 2 合作者免費。
* [wistia.com](https://wistia.com/) — 影片寄存，具觀眾分析、HD 傳輸與行銷工具，支援 25 支影片與 Wistia 品牌播放器。
* [wormhol.org](https://www.wormhol.org/) — 簡單明瞭的檔案分享服務。無限檔案，每檔最大 5GB，無限分享對象。
* [Wormhole](https://wormhole.app/) - 檔案最大 5GB、端對端加密，存放 24 小時。超過 5GB 檔案則改用點對點傳輸。
* [zoom.us](https://zoom.us/) — 安全的視訊與網路會議，附加元件可用。免費方案每次會議限 40 分鐘。
* [Zulip](https://zulip.com/) — 實時聊天，獨特的郵件式串接模式。免費方案含 1 萬條訊息搜尋歷史、5GB 檔案儲存，也有可自架的開源版本。
* [robocorp.com](https://robocorp.com) - 開源自動化運營堆疊。可免費體驗雲端功能並簡單實作自動化。每月 240 分鐘機器人作業、10 次助理運行、100MB 儲存。
* [Fleep.io](https://fleep.io/) — Fleep 是 Slack 替代方案。小團隊免費方案含完整訊息歷史、無限 1:1 對話、1 個群組對話與 1GB 檔案儲存。
* [Chanty.com](https://chanty.com/) — 另一個 Slack 替代方案。最多 10 人小團隊永久免費，含無限公開/私人對話、可搜尋歷史、無限 1:1 音訊通話、無限語音留言、10 項整合、每團隊 20GB 儲存。
* [ruttl.com](https://ruttl.com/) — 全方位數位反饋工具，蒐集網站、PDF 與圖片的回饋與審查。
* [Mattermost](https://mattermost.com/) — 技術團隊的安全協作平台。免費方案含無限頻道、劇本、看板、用戶、10GB 儲存等。
* [Webvizio](https://webvizio.com) — 網站回饋、審查與錯誤回報工具，直接於網站、應用、圖片、PDF、設計檔協作。
* [Pullflow](https://pullflow.com) — Pullflow 提供 AI 強化的跨 GitHub、Slack、VS Code 程式碼審查協作平台。
* [Webex](https://www.webex.com/) — 免費方案每次會議 40 分鐘，最多 100 人。
* [RingCentral](https://www.ringcentral.com/) — 免費方案每次會議 50 分鐘，最多 100 名參與者。
* [GitBook](https://www.gitbook.com/) — 技術知識捕捉與文件平台，從產品文件到內部知識庫與 API。個人開發者免費方案。
* [transfernow](https://www.transfernow.net/) — 最簡單、最快速、最安全的檔案傳輸分享介面。發送照片、影片等大型檔案，無需訂閱。
* [paste.sh](https://paste.sh/) — 基於 JavaScript 與加密的簡易 Paste 站。
* [Revolt.chat](https://revolt.chat/) — 開源 [Discord](https://discord.com/) 替代方案，尊重隱私，免費擁有大多數 Discord 專有功能。Revolt 是安全快速的全合一應用，全部功能免費，並支援（官方與非官方）外掛，主流聊天應用難得一見。
* [Tencent RTC](https://trtc.io/) — 騰訊實時通訊（TRTC）提供群組音視頻通話解決方案。首年每月 10,000 分鐘免費。
* [Pastefy](https://pastefy.app/) - 美觀簡單的 Pastebin，支援用戶端加密、多分頁黏貼、API、高亮編輯器等。
* [SiteDots](https://sitedots.com/) - 直接在網站上分享專案回饋，無需模擬、畫布或變通。完全免費方案。

**[⬆️ 回到頂部](#table-of-contents)**

## CMS

* [acquia.com](https://www.acquia.com/) — Drupal 網站主機。開發者免費方案。也提供免費開發工具（如 Acquia Dev Desktop）。
* [Contentful](https://www.contentful.com/) — Headless CMS。雲端內容管理與傳遞 API。免費 Community 空間含 5 位用戶、25K 筆記錄、48 種內容型別、2 地區語系。
* [Cosmic](https://www.cosmicjs.com/) — Headless CMS 與 API 工具包。開發者個人方案免費。
* [Crystallize](https://crystallize.com) — 支援電商的 Headless PIM，內建 GraphQL API。免費版含無限用戶、1,000 筆目錄、每月 5GB 流量及每月 25,000 次 API 呼叫。
* [DatoCMS](https://www.datocms.com/) - 小型專案免費方案。基於 GraphQL 的 CMS。基礎方案每月 100,000 次呼叫。
* [Directus](https://directus.io) — Headless CMS。完全免費開源，支援本地或雲端管理資產與資料庫內容。無任何限制或付費牆。
* [FrontAid](https://frontaid.io/) — Headless CMS，JSON 內容直接儲存於你的 Git 倉庫。無任何限制。
* [kontent.ai](https://www.kontent.ai) - Content-as-a-Service 平台，結合 Headless CMS 優點與行銷功能。開發者方案可用 2 位用戶、無限專案、每專案 2 個環境、500 筆內容、2 種語言、Delivery 與 Management API、支援自訂元素。可選更詳細方案以滿足需求。
* [Prismic](https://www.prismic.io/) — Headless CMS。內容管理介面，提供完整託管與可擴展 API。Community Plan 提供單用戶無限 API 呼叫、文件、自訂型別、資產與語系。完全滿足下個專案所需。更大免費方案供開放內容/開源專案使用。
* [Sanity.io](https://www.sanity.io/) - 結構化內容平台，開源編輯環境與即時託管資料庫。無限專案與管理員，3 位非管理員、2 套資料集、每專案 50 萬次 API CDN 請求、10GB 流量及 5GB 資產免費。
* [sensenet](https://sensenet.com) - API 優先的 Headless CMS，為各規模企業提供企業級解決方案。Developer 方案含 3 位用戶、500 筆內容、3 種內建角色、25+5 種內容型別、完整 REST API、文件預覽產生與 Office Online 編輯。
* [TinaCMS](https://tina.io/) — 取代 Forestry.io。開源、基於 Git 的 Headless CMS，支援 Markdown、MDX 與 JSON。基礎免費方案可用 2 位用戶。
* [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby 是快速且靈活的框架，讓你用任何 CMS、API 或資料庫開發網站變得有趣。可建立與部署 Headless 網站，提升流量、轉換率與收益！
* [Hygraph](https://hygraph.com/) - 小型專案免費方案。GraphQL 優先 API。擺脫傳統方案，轉向 GraphQL 原生 Headless CMS，實現全通路內容 API 優先。
  * [Squidex](https://squidex.io/) - 提供小型專案的免費方案。API / GraphQL 為主。開源並基於事件溯源（自動為每個變更建立版本）。
  * [InstaWP](https://instawp.com/) - 幾秒內啟動一個 WordPress 網站。免費方案包含 5 個啟用網站、500 MB 空間、48 小時網站到期。
  * [Storyblok](https://www.storyblok.com) - 一個為開發者與行銷人員設計的 Headless CMS，適用於所有現代框架。Community（免費）方案提供 Management API、視覺編輯器、10 個來源、自訂欄位型別、國際化（不限語言/地區）、資產管理器（最多 2500 筆資產）、圖片優化服務、搜尋查詢、Webhook + 每月 250GB 流量。
  * [WPJack](https://wpjack.com) - 5 分鐘內於任何雲端設置 WordPress！免費方案包含 1 台伺服器、2 個網站、免費 SSL 憑證，以及無限次排程任務。無時間限制或到期——您的網站，您作主。

**[⬆️ 回到頂部](#table-of-contents)**

## 程式碼產生

  * [Appinvento](https://appinvento.io/) — AppInvento 是一款免費無程式碼應用程式建構器。在自動產生的後端程式碼中，使用者可完全存取原始碼及無限 API 與路由，便於廣泛整合。免費方案包含三個專案、五個資料表及一個 Google 外掛。
  * [Cody AI](https://sourcegraph.com/cody) - Cody 是一個程式輔助 AI，利用 AI 與對您程式碼庫的深入理解，協助您更快撰寫與理解程式碼。Cody 提供多種 LLM（含本地推理）選擇，支援各大 IDE，支援所有主流程式語言，並有免費方案。免費方案每月提供 20 則聊天訊息（使用 Claude 3 Sonnet 作為 LLM）及 500 次自動補全（使用 Starcoder 16b）。
  * [DhiWise](https://www.dhiwise.com/) — 使用 DhiWise 創新的程式碼產生技術，無縫將 Figma 設計轉換為動態 Flutter 與 React 應用程式，優化您的工作流程，加快打造卓越行動與網頁體驗。
  * [Codeium](https://www.codeium.com/) — Codeium 是一款免費 AI 驅動程式碼自動補全工具。支援 20 多種程式語言（Python、JavaScript、Java、TypeScript、PHP、C/C++、Go 等），並可整合所有主要獨立與網頁 IDE。
  * [Fern](https://buildwithfern.com) - 撰寫 API 定義並用於產生 TypeScript、Python、Java、Go 等主流語言的 SDK/用戶端函式庫。完全支援 OpenAPI。免費方案可為最多 20 個端點產生程式碼。
  * [Metalama](https://www.postsharp.net/metalama) - 僅支援 C#。Metalama 於編譯時即時產生程式樣板，讓您的原始碼保持乾淨。對於開源專案免費，且商用友善免費方案包含三個面向。
  * [Supermaven](https://www.supermaven.com/) — Supermaven 是一款高速 AI 程式碼補全外掛，支援 VSCode、JetBrains 與 Neovim。免費方案提供無限次行內補全。
  * [tabnine.com](https://www.tabnine.com/) — Tabnine 透過從全世界程式碼中學習所得的見解，協助開發者更快創造更佳軟體。提供外掛。
  * [v0.dev](https://v0.dev/) — v0 利用 AI 模型根據簡單文字提示產生程式碼。會根據 shadcn/ui 與 Tailwind CSS 產生可複製貼上的 React 程式碼，方便用於您的專案。每次產生至少需 30 點數。起始點數 1200，每月再贈 200 免費點數。

**[⬆️ 回到頂部](#table-of-contents)**

## 程式碼品質

  * [beanstalkapp.com](https://beanstalkapp.com/) — 提供完整的程式撰寫、審查與部署流程，免費帳號限 1 名使用者、1 個儲存庫與 100 MB 儲存空間。
  * [browserling.com](https://www.browserling.com/) — 即時互動式跨瀏覽器測試，免費僅 3 分鐘會話，限 MS IE 9、Vista、1024 x 768 解析度。
  * [codacy.com](https://www.codacy.com/) — PHP、Python、Ruby、Java、JavaScript、Scala、CSS、CoffeeScript 自動程式碼審查，免費提供無限公開與私人儲存庫。
  * [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - DevOps 基礎架構即程式碼自動審查工具，整合 GitHub、Bitbucket、GitLab（含自架）。除標準語言外，也分析 Ansible、Terraform、CloudFormation、Kubernetes 等。（開源免費）
  * [CodeBeat](https://codebeat.co) — 多語言自動程式碼審查平台。公開儲存庫永久免費，並支援 Slack 與電子郵件整合。
  * [codeclimate.com](https://codeclimate.com/) — 自動程式碼審查，開源與組織擁有私人儲存庫（最多 4 合作者）不限數量免費。學生與機構亦免費。
  * [codecov.io](https://codecov.io/) — 程式碼覆蓋率工具（SaaS），開源與 1 個私人儲存庫免費
  * [CodeFactor](https://www.codefactor.io) — Git 自動程式碼審查。免費版包含無限使用者、公開儲存庫與 1 個私人儲存庫。
  * [coderabbit.ai](https://coderabbit.ai) — AI 驅動的程式碼審查工具，整合 GitHub/GitLab。免費方案包含每小時 200 個檔案、3 次審查、50 次對話。開源專案永久免費。
  * [codescene.io](https://codescene.io/) - 根據開發者的程式操作優先處理技術債，並可視化團隊耦合與系統掌握等組織因素。開源免費。
  * [CodSpeed](https://codspeed.io) - 在 CI 流程中自動追蹤效能。在部署前捕捉效能倒退，依賴精確且一致的指標。開源專案永久免費。
  * [coveralls.io](https://coveralls.io/) — 顯示測試覆蓋率報告，開源免費
  * [dareboost](https://dareboost.com) - 每月 5 次免費網站效能、無障礙與安全性分析報告
  * [deepcode.ai](https://www.deepcode.ai) — DeepCode 基於 AI 發現漏洞、安全弱點、效能與 API 問題。分析速度極快，可於 IDE 儲存時即時分析。支援 Java、C/C++、JavaScript、Python、TypeScript。整合 GitHub、BitBucket、GitLab。開源與私人儲存庫及最多 30 位開發者免費。
  * [deepscan.io](https://deepscan.io/) — 進階靜態分析，自動檢測 JavaScript 執行時錯誤，開源免費
  * [DeepSource](https://deepsource.io/) - DeepSource 持續分析原始碼變更，自動發現並修正安全、效能、反模式、錯誤風險、文件、風格等問題。原生整合 GitHub、GitLab、Bitbucket。
  * [DiffText](https://difftext.com) - 即時比較兩段程式碼差異。完全免費。
  * [eversql.com](https://www.eversql.com/) — EverSQL - 資料庫優化平台。自動獲得資料庫與 SQL 查詢的重要見解。
  * [gerrithub.io](https://review.gerrithub.io/) — 為 GitHub 儲存庫提供免費 Gerrit 程式碼審查
  * [gocover.io](https://gocover.io/) — 任何 [Go](https://golang.org/) 套件的程式碼覆蓋率
  * [goreportcard.com](https://goreportcard.com/) — Go 專案程式碼品質，開源免費
  * [gtmetrix.com](https://gtmetrix.com/) — 報告與詳盡建議，協助網站優化
  * [holistic.dev](https://holistic.dev/) - 針對 Postgresql 優化的靜態程式碼分析器。自動偵測效能、安全與資料庫架構問題
  * [houndci.com](https://houndci.com/) — 於 GitHub 提交留言提示程式碼品質，開源免費
  * [Moderne.io](https://app.moderne.io) — 自動原始碼重構。Moderne 提供框架遷移、程式碼分析與修復，以及大規模無與倫比的程式碼轉換，讓開發者專注創新而非維護舊系統。開源免費。
  * [reviewable.io](https://reviewable.io/) — GitHub 儲存庫程式碼審查，公開或個人儲存庫免費。
  * [parsers.dev](https://parsers.dev/) - 提供抽象語法樹剖析器與中間表示編譯器即服務
  * [scan.coverity.com](https://scan.coverity.com/) — Java、C/C++、C# 與 JavaScript 靜態程式碼分析，開源免費
  * [scrutinizer-ci.com](https://scrutinizer-ci.com/) — 持續檢查平台，開源免費
  * [semanticdiff.com](https://app.semanticdiff.com/) — 支援多語言的 GitHub Pull Request 與提交差異比對，公開儲存庫免費
  * [shields.io](https://shields.io) — 開源專案品質中繼資料徽章
  * [sonarcloud.io](https://sonarcloud.io) — Java、JavaScript、C/C++、C#、VB.NET、PHP、Objective-C、Swift、Python、Groovy 等自動原始碼分析，開源免費
  * [SourceLevel](https://sourcelevel.io/) — 自動程式碼審查與團隊分析。開源專案與最多 5 位合作者組織免費。
  * [webceo.com](https://www.webceo.com/) — SEO 工具，亦提供程式碼驗證與多裝置支援
  * [zoompf.com](https://zoompf.com/) — 網站效能優化，詳盡分析

**[⬆️ 回到頂部](#table-of-contents)**

## 程式碼搜尋與瀏覽

  * [libraries.io](https://libraries.io/) — 32 種套件管理器搜尋與相依更新通知，開源免費
  * [Namae](https://namae.dev/) - 搜尋 GitHub、Gitlab、Heroku、Netlify 等多個網站，檢查專案名稱可用性。
  * [searchcode.com](https://searchcode.com/) — 全面文字型程式碼搜尋，開源免費
  * [tickgit.com](https://www.tickgit.com/) — 顯示 `TODO` 註解（及其他標記），辨識值得回頭改善的程式區塊。
  * [CodeKeep](https://codekeep.io) - 程式碼片段的 Google Keep。組織、發現並分享程式碼片段，具備強大的程式碼截圖工具（內建範本）與連結功能。

**[⬆️ 回到頂部](#table-of-contents)**

## CI 與 CD

  * [AccessLint](https://github.com/marketplace/accesslint) — AccessLint 將自動化網頁無障礙測試帶入開發流程。開源與教育用途免費。
  * [appcircle.io](https://appcircle.io) — 企業級行動 DevOps 平台，自動化建置、測試與發布行動應用，提升發佈效率。免費可用於每次最多 30 分鐘建置、每月 20 次建置及 1 個同時建置。
  * [appveyor.com](https://www.appveyor.com/) — Windows CD 服務，開源免費
  * [LocalOps](https://localops.co/) - 30 分鐘內於 AWS/GCP/Azure 部署應用。於任一雲端建立標準化應用環境，內建持續部署自動化與進階可觀測性。免費方案允許 1 名使用者與 1 個應用環境。
  * [Argonaut](https://argonaut.dev/) - 幾分鐘內於您的雲端部署應用與基礎架構。支援 Kubernetes 與 Lambda 環境的自定義與第三方應用部署。免費方案允許 5 個網域、2 位使用者不限應用與部署次數。
  * [bitrise.io](https://www.bitrise.io/) — 行動應用 CI/CD，原生或混合式皆可。每月 200 次免費建置、每次 10 分鐘，2 位團隊成員。OSS 專案享 45 分鐘建置、+1 並行與無限團隊人數。
  * [buddy.works](https://buddy.works/) — CI/CD，免費 5 個專案、1 個併發（每月 120 次執行）
  * [Buildkite](https://buildkite.com) CI 流程免費 3 位用戶、每月 5000 工作分鐘。測試分析免費開發者方案每月 10 萬次測試執行，開源專案有額外免費資源。
  * [bytebase.com](https://www.bytebase.com/) — 資料庫 CI/CD 與 DevOps。20 位以下用戶與 10 個資料庫實例免費
  * [CircleCI](https://circleci.com/) — 全功能免費方案，支援 GitHub、GitLab、BitBucket 倉儲的託管 CI/CD 服務。多種資源等級、Docker、Windows、Mac OS、ARM 執行器、本地執行、測試分割、Docker 層快取及進階 CI/CD 功能。私人專案每月 6000 分鐘執行、無限合作者、30 個並行任務，開源專案最多 80,000 分鐘建置。
  * [cirrus-ci.org](https://cirrus-ci.org) - 公開 GitHub 倉儲免費
  * [cirun.io](https://cirun.io) - 公開 GitHub 倉儲免費
  * [codefresh.io](https://codefresh.io) — Free-for-Life 方案：1 次建置、1 個環境、共用伺服器、無限公開儲存庫
  * [codemagic.io](https://codemagic.io/) - 每月免費 500 分鐘建置
  * [codeship.com](https://codeship.com/) — 每月 100 次私人建置、5 個私人專案，開源無限次
  * [deploybot.com](https://www.deploybot.com/) — 1 個儲存庫，10 次部署，開源免費
  * [deployhq.com](https://www.deployhq.com/) — 1 個專案，每日 10 次部署（每月 30 分鐘建置時間）
  * [drone](https://cloud.drone.io/) - Drone Cloud 讓開發者在同一平台執行多架構（x86 與 Arm，含 32/64 位元）持續交付流程
  * [LayerCI](https://layerci.com) — 全端專案 CI。1 個全端預覽環境，5GB 記憶體 & 3 顆 CPU。
  * [semaphoreci.com](https://semaphoreci.com/) — 開源免費，私人專案每月 100 次建置
  * [Squash Labs](https://www.squash.io/) — 每個分支建立一台 VM，讓您的應用可由專屬 URL 存取，無限公開/私人儲存庫，VM 最多 2GB。
  * [styleci.io](https://styleci.io/) — 僅限公開 GitHub 儲存庫
  * [Mergify](https://mergify.io) — GitHub 工作流程自動化與合併佇列，公開 GitHub 倉儲免費
  * [Make](https://www.make.com/en) — 工作流程自動化工具，允許連接應用與自動化流程，支援多款應用及主流 API。公開 GitHub 倉儲免費，且免費方案含 100Mb、1000 次操作、最小 15 分鐘間隔。
  * [Spacelift](https://spacelift.io/) - 基礎架構即程式碼管理平台。免費方案功能：IaC 協作、Terraform 模組註冊庫、ChatOps 整合、與 Open Policy Agent 持續資源合規、SAML 2.0 SSO、存取公開工作池：每月最多 200 分鐘。
  * [microtica.com](https://microtica.com/) - Startup 環境與現成基礎架構元件，免費在 AWS 部署應用並支援生產工作負載。免費方案含 1 個環境（使用您 AWS 帳號）、2 個 Kubernetes 服務、每月 100 分鐘建置、20 次部署。
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud 透過遠端快取、任務分佈至多台機器，甚至自動分割 E2E 測試執行等功能，加速 CI 上的單一倉儲專案。免費方案支援最多 30 位貢獻者，並包含 150,000 點數。
* [blacksmith](https://www.blacksmith.sh/) - 為 GitHub Actions 提供託管效能執行器，每月提供 3,000 分鐘免費配額，無需信用卡。
* [Terramate](https://terramate.io/) - Terramate 是一個基礎設施即程式碼（IaC）工具（如 Terraform、OpenTofu、Terragrunt）的協作與管理平台。免費支援最多 2 位使用者，並包含所有功能。
* [Terrateam](https://terrateam.io) - GitOps 優先的 Terraform 自動化，具備拉取請求驅動工作流程、專案隔離（自架執行器）及分層執行等功能。最多 3 位用戶免費。

**[⬆️ 回到頂部](#table-of-contents)**

## 測試

* [Applitools.com](https://applitools.com/) — 智能視覺驗證，支援網頁、原生行動及桌面應用。可與大多數自動化方案（如 Selenium、Karma）及遠端執行器（Sauce Labs、Browser Stack）整合。對開源專案免費。單一用戶有每週檢查點數限制的免費層級。
* [Appetize](https://appetize.io) — 在雲端 Android 手機/平板模擬器與 iPhone/iPad 模擬器上直接於瀏覽器測試你的 Android & iOS 應用。免費層級包含兩個並行會話及每月 30 分鐘使用時間。無應用大小限制。
* [Apptim](https://apptim.com) — 行動測試工具，讓無效能工程背景者也能評估應用效能與用戶體驗。桌面版本完全免費，可在 iOS 與 Android 上不限次數測試。
* [Argos](https://argos-ci.com) - 開源視覺化測試工具。專案數不限，每月 5,000 張截圖。開源專案免費。
* [Bencher](https://bencher.dev/) - 連續效能基準測試工具組，用於捕捉 CI 上的效能倒退。所有公開專案免費。
* [browserstack.com](https://www.browserstack.com/) — 手動與自動化瀏覽器測試，[開源專案免費](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - 輕量級網頁應用測試自動化工具，易學且無需程式編碼。可於本機不限次數免費執行測試。雲端監控及 CI/CD 整合需額外付費。
* [Checkly](https://checklyhq.com) - 代碼優先的合成監控服務，現代 DevOps 適用。以 Monitoring as Code 與 Playwright 為基礎，監控 API 與應用，價格遠低於傳統供應商。開發者享有慷慨的免費層級。
* [checkbot.io](https://www.checkbot.io/) — 瀏覽器擴充套件，可測試網站是否符合 50+ 項 SEO、速度與安全性最佳實踐。小型網站享有免費層級。
* [CORS-Tester](https://cors-error.dev/cors-tester/) - 免費工具，協助開發者及 API 測試人員檢查 API 是否針對指定網域啟用 CORS，並找出缺口。提供可行性建議。
* [cypress.io](https://www.cypress.io/) - 快速、簡單且可靠的瀏覽器端測試。Cypress Test Runner 永久免費開源，無任何限制。Cypress Dashboard 開放給最多 5 位用戶的開源專案免費使用。
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - 在瀏覽器上建立 AI 驅動的 Cypress 測試/POM 模型。除 AI 部分外為開源。每月可免費建立五筆測試，支援自動修復腳本、Email、視覺測試。
* [everystep-automation.com](https://www.everystep-automation.com/) — 錄製並重播瀏覽器所有操作步驟並產生腳本，免費版功能有限。
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Gremlin 的混沌工程工具可安全地對系統注入故障，找出弱點。Gremlin Free 方案可針對最多 5 台主機或容器執行關機與 CPU 攻擊。
* [gridlastic.com](https://www.gridlastic.com/) — Selenium Grid 測試，免費方案支援最多 4 個並行節點/每月 10 次 Grid 啟動/4,000 測試分鐘。
* [katalon.com](https://katalon.com) - 測試平台支援各種團隊及測試成熟度層級，包含 Katalon Studio、TestOps（含免費視覺測試）、TestCloud 與 Katalon Recorder。
* [Keploy](https://keploy.io/) - Keploy 是一套功能測試工具組。錄製 API 呼叫自動產生 API 端到端測試 (KTests) 及模擬/存根(KMocks)。開源專案免費。
* [knapsackpro.com](https://knapsackpro.com) - 透過最佳化測試集並行化，加速各 CI 平台上的測試。可將 Ruby、JavaScript 測試分配到多個並行 CI 節點。免費方案支援最多 10 分鐘測試檔案，開源專案享有不限額度免費方案。
* [lambdatest.com](https://www.lambdatest.com/) — Selenium 與 Cypress 的手動、視覺、截圖及自動化瀏覽器測試，[開源專案免費](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - 透過分析網路流量自動建立 API 與負載測試。每月可免費模擬最多 50 個並發用戶，累計 60 分鐘。
* [lost-pixel.com](https://lost-pixel.com) - 全方位視覺回歸測試，支援 Storybook、Ladle、Histoire 及 Web Apps。團隊成員不限，開源專案完全免費，每月 7,000 張快照。
* [octomind.dev](https://www.octomind.dev/) - 透過 AI 輔助自動產生、執行與維護 Playwright UI 測試案例。
* [percy.io](https://percy.io) - 為任何網頁應用、靜態網站、樣式指南或元件庫新增視覺測試。團隊成員不限、Demo app、不限專案數，每月 5,000 張快照。
* [preflight.com](https://preflight.com) - 無程式碼自動化網站測試。可錄製對 UI 變更具有韌性的測試並於 Windows 執行。支援與 CI/CD 整合。免費方案每月含 50 次測試執行、影片、HTML 工作階段等功能。
* [qase.io](https://qase.io) - 專為開發與 QA 團隊打造的測試管理系統。管理測試案例、組合測試執行、執行測試、追蹤缺陷與衡量影響。免費層級包含所有核心功能，附件空間 500MB，最多 3 位使用者。
* [Repeato](https://repeato.app/) 無程式碼行動應用測試自動化工具，基於電腦視覺與 AI。支援原生、flutter、react-native、web、ionic 等多種框架。免費方案限 iOS 及 Android 各 10 筆測試，包含大多數付費方案功能，測試次數不限。
* [Requestly](https://requestly.com/) 開源 Chrome 擴充工具，支援攔截、重導、模擬 HTTP 請求。功能包含 [Debugger](https://requestly.com/products/web-debugger/)、[Mock Server](https://requestly.com/products/mock-server/)、[API Client](https://requestly.com/products/api-client/)、[Session Recording](https://requestly.com/products/session-book/)。可重導 URL、修改 HTTP 標頭、模擬 API、插入自訂 JS、修改 GraphQL 請求、產生模擬 API 端點、錄製 session 與網路/主控台日誌。免費層級可建立最多 10 條規則。開源專案免費。
* [seotest.me](https://seotest.me/) — 免費網站內頁 SEO 測試工具。每日 10 次免費爬蟲。提供豐富 SEO 學習資源及提升 SEO 成效建議，適用於任何技術架構網站。
* [snippets.uilicious.com](https://snippets.uilicious.com) - 類似 CodePen，但專為跨瀏覽器測試而設。UI-licious 讓你像寫用戶故事一樣撰寫測試，免費平台 UI-licious Snippets 可不限次數於 Chrome 執行測試，每次最多 3 分鐘且無需註冊。發現 bug？可複製專屬測試 URL，方便開發者重現問題。
* [TestCollab](https://testcollab.com) - 使用者友好的測試管理軟體，免費方案支援 Jira 整合、不限專案數、CSV/XLSx 匯入測試案例、時間追蹤、1 GB 儲存空間。
* [testingbot.com](https://testingbot.com/) — Selenium 瀏覽器與裝置測試，[開源專案免費](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - 發佈自動化測試結果的儀表板，並可使用 GitHub 實作手動測試即程式碼。此服務[開源專案免費](https://github.com/marketplace/testspace-com)，每月 450 筆結果。
* [tesults.com](https://www.tesults.com) — 測試結果報告及測試案例管理。可與多種測試框架整合。開源軟體開發者、個人、教育者及新創小團隊可申請超出基本免費專案的優惠或免費方案。
* [UseWebhook.com](https://usewebhook.com) - 從瀏覽器擷取與檢查 webhook。可轉發至本地端，或從歷史紀錄重播。免費使用。
* [Vaadin](https://vaadin.com) — 用 Java 或 TypeScript 建立可擴展 UI，並利用整合工具、元件與設計系統，加速迭代、提升設計品質、簡化開發流程。不限專案數，免費維護五年。
* [websitepulse.com](https://www.websitepulse.com/tools/) — 多種免費網路及伺服器工具。
* [webhook-test.com](https://webhook-test.com) - 整合時以專屬 URL 偵錯及檢查 webhook 與 HTTP 請求。完全免費，可建立不限數量 URL，並提供建議。
* [webhook.site](https://webhook.site) - 透過自訂 URL 驗證 webhook、外發 HTTP 請求或 email。臨時 URL 與 email 地址永遠免費。
* [webhookbeam.com](https://webhookbeam.com) - 建立 webhook 並透過推播通知與 email 監控。

**[⬆️ 回到頂部](#table-of-contents)**

## 安全與 PKI

* [aikido.dev](https://www.aikido.dev) — 一站式應用安全平台，涵蓋 SCA、SAST、CSPM、DAST、Secrets、IaC、惡意程式、容器掃描、EOL 等。免費方案含 2 位用戶、10 個倉儲、1 個雲、2 個容器及 1 個網域。
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — 發現網路中已被入侵的系統
* [Altcha.org](https://altcha.org/anti-spam) - 基於自然語言處理與機器學習的網站與 API 垃圾郵件過濾器。免費方案每日每網域 200 次請求。
* [atomist.com](https://atomist.com/) — 更快捷方便的開發任務自動化方式。目前為 beta 版。
* [cloudsploit.com](https://cloudsploit.com/) — AWS 雲端安全及合規稽核與監控
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — 針對公有雲基礎設施的高信任度 IOC 指標，部分內容於 github (https://github.com/unknownhad/AWSAttacks) 提供。完整列表可透過 API 取得。
* [CodeNotary.io](https://www.codenotary.io/) — 開源平台，提供不可否認的證據對程式碼、檔案、目錄或容器進行公證
* [crypteron.com](https://www.crypteron.com/) — 雲端優先、開發者友善的安全平台，防止 .NET 與 Java 應用資料外洩
* [CyberChef](https://gchq.github.io/CyberChef/) — 簡單直觀的網頁應用，分析與編解碼資料，免除複雜工具或程式語言。堪稱密碼學瑞士刀。所有功能免費，無限額。開源可自架。
* [DAS](https://signup.styra.com/) — Styra DAS Free，完整 OPA 授權政策生命週期管理
* [Datree](https://www.datree.io/) — 開源 CLI 工具，防止 Kubernetes 配置錯誤，確保 manifests 與 Helm chart 符合最佳實踐及組織政策
* [Dependabot](https://dependabot.com/) 自動更新 Ruby、JavaScript、Python、PHP、Elixir、Rust、Java（Maven 和 Gradle）、.NET、Go、Elm、Docker、Terraform、Git 子模組、GitHub Actions 等依賴套件。
* [DJ Checkup](https://djcheckup.com) — 自動掃描 Django 網站安全漏洞的免費工具，源自 Pony Checkup。
* [Doppler](https://doppler.com/) — 通用 Secrets 管理平台，可與多家雲服務供應商同步。免費支援 5 位用戶及基本權限控管。
* [Dotenv](https://dotenv.org/) — 快速安全同步 .env 檔。避免透過 Slack、Email 等不安全管道分享 .env 檔，並防止遺失。最多 3 位團隊成員免費。
* [GitGuardian](https://www.gitguardian.com) — 以自動秘密檢測與修復，避免機密洩漏於源碼。掃描 350+ 類型秘密與敏感檔案 - 個人與 25 人以下團隊免費。
* [Have I been pwned?](https://haveibeenpwned.com) — 透過 REST API 查詢資料外洩紀錄。
* [hostedscan.com](https://hostedscan.com) — 網頁應用、伺服器、網路線上弱點掃描。每月免費 10 次掃描。
* [Infisical](https://infisical.com/) — 開源平台，協助團隊於本地、測試、正式等環境管理開發機密資訊。最多 5 位開發者免費。
* [Internet.nl](https://internet.nl) — 檢查 IPv6、DNSSEC、HTTPS、DMARC、STARTTLS、DANE 等現代網路標準
* [keychest.net](https://keychest.net) - SSL 憑證到期管理與購買，整合 CT 資料庫
* [letsencrypt.org](https://letsencrypt.org/) — 免費 SSL 憑證機構，受所有主流瀏覽器信任
* [meterian.io](https://www.meterian.io/) - 監控 Java、Javascript、.NET、Scala、Ruby、NodeJS 專案依賴安全漏洞。1 個私人專案免費，開源專案不限數量。
* [Mozilla Observatory](https://observatory.mozilla.org/) — 檢查並修復網站安全漏洞。
* [opswat.com](https://www.opswat.com/) — 電腦、裝置、應用、配置安全監控，免費支援 25 位用戶與 30 天歷史。
* [openapi.security](https://openapi.security/) - 快速檢查任何 OpenAPI / Swagger API 的安全性，免註冊免費使用。
* [pixee.ai](https://pixee.ai) - 自動產品安全工程師，作為免費 GitHub bot 為 Java 程式庫自動提交修復漏洞 PR。其他語言即將支援！
* [pyup.io](https://pyup.io) — 監控 Python 依賴安全漏洞並自動更新。1 個私人專案免費，開源專案不限數量。
* [qualys.com](https://www.qualys.com/community-edition) — 網頁應用漏洞檢測，查核 OWASP 風險
* [report-uri.io](https://report-uri.io/) — CSP 與 HPKP 違規回報
* [ringcaptcha.com](https://ringcaptcha.com/) — 以電話號碼作為身分識別工具，免費提供
* [seclookup.com](https://www.seclookup.com/) - Seclookup API 可於 SIEM 中豐富網域威脅指標、提供網域完整資訊、提升威脅偵測與回應。於[此處](https://account.seclookup.com/)免費獲取 50K 次查詢。
* [snyk.io](https://snyk.io) — 可發現並修復開源依賴套件已知安全漏洞。開源專案不限次數免費測試與修復，私人專案每月限 200 次測試。
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — 深度分析任何 SSL 網頁伺服器的配置
* [SOOS](https://soos.io) - 開源專案免費不限次數 SCA 掃描。於發布前偵測並修復安全威脅，簡單有效地保護你的專案。
* [StackHawk](https://www.stackhawk.com/) 於開發流程中自動掃描應用，於進入正式環境前發現並修復安全漏洞。單一應用不限環境與掃描次數免費。
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - 免費網站安全檢查與惡意程式掃描
* [Protectumus](https://protectumus.com) - 免費網站安全檢查、網站防毒與 PHP 伺服器防火牆（WAF）。免費層級用戶可接收 Email 通知。
* [TestTLS.com](https://testtls.com) - 檢查 SSL/TLS 服務的安全配置、憑證、鏈等。不限於 HTTPS。
* [threatconnect.com](https://threatconnect.com) — 威脅情報：適合個人研究員、分析師及初學者。最多 3 位用戶免費。
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — 自動化弱點掃描。免費方案每週支援一次 XSS 掃描。
* [Ubiq Security](https://ubiqsecurity.com/) — 只需三行程式碼即可進行資料加解密並自動管理金鑰。免費支援一個應用、每月 1,000,000 次加密。
* [Virgil Security](https://virgilsecurity.com/) — 提供端到端加密、資料庫保護、IoT 安全等工具與服務。支援最多 250 位用戶的應用免費。
* [Vulert](https://vulert.com) - Vulert 持續監控你的開源依賴套件新漏洞，推薦修復方案，無需安裝或存取你的代碼庫。開源專案免費。
* [Escape GraphQL Quickscan](https://escape.tech/) - 一鍵掃描你的 GraphQL 端點安全性。免費，無需登入。
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - 免費搜尋 2,000 萬個公開 GitHub 倉儲、gists、issue、留言中的外洩秘密
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - 全方位 SSL 工具組，提供私鑰 & CSR 產生器、憑證解碼、憑證比對、憑證訂購等功能。可透過 CNAME 紀錄（而非 TXT）免費產生 Let's Encrypt、Google Trust、BuyPass 憑證。
**[⬆️ 返回頂部](#table-of-contents)**

## 認證、授權與用戶管理

  * [Aserto](https://www.aserto.com) - 針對應用程式和 API 提供細緻化授權服務。免費方案包含 1000 個 MAUs 和 100 個授權器實例。
  * [asgardeo.io](https://wso2.com/asgardeo) - 無縫整合 SSO、MFA、無密碼驗證等。包含前端與後端應用 SDK。免費最多 1000 MAUs 和五個身分提供者。
  * [Auth0](https://auth0.com/) — 託管式 SSO。免費方案包含 25,000 MAUs、無限社交連接、自訂網域等。
  * [Authgear](https://www.authgear.com) - 讓您的應用於數分鐘內實現無密碼、OTP、2FA、SSO。全前端包含。免費最多 5000 MAUs。
  * [Authress](https://authress.io/) — 驗證登入與存取控制，任意專案不限身分提供者。支援 Facebook、Google、Twitter 等。首 1000 次 API 呼叫免費。
  * [Authy](https://authy.com) - 多裝置雙因素認證（2FA），並支援備份。可作為 Google Authenticator 的替代品。最多 100 次成功驗證免費。
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - 完整的授權管理系統，支援撰寫、測試和部署存取政策。細緻化授權和存取控制，每月最多 100 個活躍主體免費。
  * [Clerk](https://clerk.com) — 用戶管理、認證、2FA/MFA、預建登入/註冊/用戶資料 UI 組件等。免費最多 10,000 個月活躍用戶。
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak 身分與存取管理即服務。最多 100 用戶和 1 個領域免費。
  * [Corbado](https://www.corbado.com/) — 為新或現有應用新增 Passkey 優先的認證。免費不限 MAUs。
  * [Descope](https://www.descope.com/) — 高度可自訂的 AuthN 流程，支援無程式碼與 API/SDK 方式。每月 7,500 位活躍用戶、50 個租戶（最多 5 個 SAML/SSO 租戶）免費。
  * [duo.com](https://duo.com/) — 網站或應用的雙因素認證（2FA）。10 位用戶免費，支援所有認證方式、無限整合、硬體金鑰。
  * [Kinde](https://kinde.com/) - 易於整合且強大的認證，數分鐘即可與您的產品結合。免費提供所有入門功能，含 7,500 MAU。
  * [logintc.com](https://www.logintc.com/) — 推播通知的雙因素認證（2FA），網站、VPN、SSH 各 10 位用戶免費。
  * [MojoAuth](https://mojoauth.com/) - 讓您的 Web、行動或任意應用在數分鐘內輕鬆實作無密碼認證。
  * [Okta](https://developer.okta.com/signup/) — 用戶管理、認證與授權。免費最多 100 位月活躍用戶。
  * [onelogin.com](https://www.onelogin.com/) — 身分即服務（IDaaS）、SSO 身分提供者、雲端 SSO IdP、支援三個公司 App 和五個個人 App、用戶不限。
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/Zero Trust 託管安全平台。開發者帳戶永遠免費，含所有安全功能、無限團隊成員、200 日活用戶和每月 25,000 次權限檢查。
  * [Permit.io](https://permit.io) - 授權即服務平台，支援 RBAC、ABAC 和 ReBAC，適用於可擴展微服務，具即時更新與無程式碼政策 UI。每月 1000 MAU 免費方案。
  * [Phase Two](https://phasetwo.io) - Keycloak 開源身分與存取管理。免費領域最多 1000 用戶、10 個 SSO 連接，採用 Phase Two 的 Keycloak 增強型容器，包含 [Organization](https://phasetwo.io/product/organizations/) 擴充。
  * [SSOJet](https://ssojet.com/) - 免重構認證即可新增企業級 SSO。免費方案包含無限 MAU、無限組織、2 個 SSO 與 2 個 SCIM 連接。
  * [Stytch](https://www.stytch.com/) - 全方位平台，提供認證與防詐 API/SDK。免費方案含 10,000 MAU、無限組織、5 個 SSO 或 SCIM 連接、1,000 個 M2M 金鑰。
  * [Stack Auth](https://stack-auth.com) — 開源認證，五分鐘即可上手，最適合開發者。可自架免費，或使用託管 SaaS 版本（含 10k 免費 MAU）。
  * [SuperTokens](https://supertokens.com/) - 開源用戶認證，與應用原生整合，讓您快速啟動並掌控用戶與開發者體驗。免費最多 5000 MAUs。
  * [Warrant](https://warrant.dev/) — 託管企業級授權與存取控制服務。免費層包含每月 1 百萬次 API 請求與 1,000 條授權規則。
  * [ZITADEL Cloud](https://zitadel.com) — 一站式用戶與存取管理，支援多租戶（B2B）場景。免費最多 25,000 次認證請求，含所有安全功能（OTP、無密碼、政策等無需付費）。
  * [PropelAuth](https://propelauth.com) — 即刻以幾行程式碼銷售給各規模企業，免費最多 200 用戶與 10,000 封交易郵件（含水印標示：「Powered by PropelAuth」）。
  * [Logto](https://logto.io/) - 開發、保護與管理產品用戶身分，支援認證與授權。免費最多 5,000 MAUs，另有開源自架選項。
  * [WorkOS](https://workos.com/) - 免費用戶管理與認證，支持最多 100 萬 MAUs。支援郵箱密碼、社交認證、Magic Auth、MFA 等。

**[⬆️ 返回頂部](#table-of-contents)**

## 行動應用發佈與回饋

  * [TestApp.io](https://testapp.io) - 行動應用測試與驗證平台。免費方案：一個 App、分析、無限版本與安裝、可收集反饋。
  * [Loadly](https://loadly.io) - iOS 與 Android Beta 應用發佈服務，完全免費，無限下載、高速下載、無限上傳。
  * [Diawi](https://www.diawi.com) - 直接部署 iOS 與 Android 應用至裝置。免費方案：App 上傳、密碼保護連結、1 天失效、10 次安裝。
  * [InstallOnAir](https://www.installonair.com) - 無線分發 iOS 與 Android 應用。免費方案：無限上傳、私人連結、訪客 2 天有效，註冊用戶 60 天有效。
  * [GetUpdraft](https://www.getupdraft.com) - 用於測試的行動應用分發。免費方案含 1 個應用專案、3 個版本、500 MB 儲存、每月 100 次安裝。
  * [Appho.st](https://appho.st) - 行動應用託管平台。免費方案含 5 個 App、每月 50 次下載、單檔最大 100 MB。

**[⬆️ 返回頂部](#table-of-contents)**

## 管理系統

  * [bitnami.com](https://bitnami.com/) — 在 IaaS 上部署預製應用。可免費管理 1 個 AWS micro instance
  * [Esper](https://esper.io) — Android 裝置的 MDM 與 MAM，支援 DevOps。免費支援 100 台裝置、1 位用戶授權與 25 MB 應用儲存。
  * [jamf.com](https://www.jamf.com/) — iPad、iPhone 與 Mac 的裝置管理，免費支援 3 台裝置
  * [Miradore](https://miradore.com) — 裝置管理服務。免費不限裝置數，提供基本功能，保障裝置安全與即時狀態。
  * [moss.sh](https://moss.sh) - 幫助開發者部署與管理 Web 應用及伺服器。每月最多 25 次 git 部署免費
  * [runcloud.io](https://runcloud.io/) - 伺服器管理，專注於 PHP 專案。最多支援 1 台伺服器免費。
  * [ploi.io](https://ploi.io/) - 伺服器管理工具，輕鬆管理與部署伺服器與網站。免費支援 1 台伺服器。
  * [xcloud.host](https://xcloud.host) — 友善介面的伺服器管理與部署平台。免費層可管理 1 台伺服器。
  * [serveravatar.com](https://serveravatar.com) — 管理與監控 PHP 網頁伺服器，支援自動化設定。免費支援 1 台伺服器。

**[⬆️ 返回頂部](#table-of-contents)**

## 訊息與串流

  * [Ably](https://www.ably.com/) - 即時訊息服務，支援存在、持久性和保證傳遞。免費方案每月 300 萬訊息、100 個高峰連線、100 個高峰頻道。
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ 即服務。Little Lemur 方案：每月最多 100 萬訊息、20 個併發連線、100 個佇列、10,000 個佇列訊息、支援多 AZ 節點
  * [courier.com](https://www.courier.com/) — 單一 API 整合推播、應用內、郵件、聊天、SMS 等訊息通道，並具備範本管理。免費方案每月 10,000 則訊息。
  * [engagespot.co](https://engagespot.co/) — 多通道通知基礎設施，具備內建應用內收件匣與無程式碼範本編輯器。免費方案每月 10,000 則訊息。
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - 將 MQTT 裝置連接至雲端原生 IoT 訊息代理。永久免費最多連接 100 台裝置（不需信用卡）。
  * [knock.app](https://knock.app) – 開發者通知基礎設施。單一 API 支援多通道（應用內、郵件、SMS、Slack、推播）。免費方案每月 10,000 則訊息。
  * [NotificationAPI.com](https://www.notificationapi.com/) — 5 分鐘內為軟體新增用戶通知。免費方案每月 10,000 則通知 + 100 則 SMS 與自動來電。
  * [Novu.co](https://novu.co) — 開源通知基礎設施，簡單元件與 API 一站管理 Email、SMS、應用內、推播等通道。免費方案每月 30,000 則通知，保存 90 天。
  * [pusher.com](https://pusher.com/) — 即時訊息服務。最多 100 個同時連線與每日 200,000 則訊息免費
  * [scaledrone.com](https://www.scaledrone.com/) — 即時訊息服務。最多 20 個同時連線與每日 100,000 個事件免費
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) 即服務。全球 AWS、GCP、Azure。永久免費 4k 訊息大小、50 個活躍連線、每月 5GB 資料。
  * [pubnub.com](https://www.pubnub.com/) - Swift、Kotlin、React 訊息服務，每月 100 萬次交易。每筆交易可包含多條訊息。
  * [eyeson API](https://developers.eyeson.team/) - 基於 WebRTC (SFU, MCU) 的視訊通訊 API，可自訂資料注入、佈局、錄影，支援完整託管 Web UI 或自訂 UI 套件。開發者免費層 [詳見](https://apiservice.eyeson.com/api-pricing)，每月 1000 會議分鐘。
  * [webpushr](https://www.webpushr.com/) - Web 推播通知，免費最多 10,000 訂閱者，推播無限，支援瀏覽器內訊息。
  * [httpSMS](https://httpsms.com) - 使用 Android 手機作為 SMS Gateway 發送與接收簡訊。每月最多免費 200 則。
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - 可擴展且安全的無伺服器 MQTT broker，幾秒即用。每月 100 萬會話分鐘永久免費（不需信用卡）。
  * [Pocket Alert](https://pocketalert.app) - 向您的 iOS/Android 裝置推播通知。透過 API 或 Webhooks 輕鬆整合與管理。免費方案：每日 50 則訊息，限 1 台裝置、1 個應用。
  * [SuprSend](https://www.suprsend.com/) - API 優先的通知基礎設施，簡化產品通知。單一 API 支援多通道交易、排程、互動等通知。免費方案每月 10,000 則通知，含摘要、分批、多通道、偏好、租戶、廣播等節點。

**[⬆️ 返回頂部](#table-of-contents)**

## 日誌管理

  * [bugfender.com](https://bugfender.com/) — 每日 100,000 行日誌，保存 24 小時免費
  * [logentries.com](https://logentries.com/) — 每月 5 GB 免費，保存 7 天
  * [loggly.com](https://www.loggly.com/) — 單一用戶免費，每日 200MB，保存 7 天
  * [logz.io](https://logz.io/) — 每日 1 GB 免費，保存 1 天
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Manage Engine 驅動的日誌管理服務。免費方案含 50 GB 儲存、15 天保留、7 天搜尋。
  * [papertrailapp.com](https://papertrailapp.com/) — 48 小時搜尋、7 天存檔、每月 50 MB
  * [sematext.com](https://sematext.com/logsene) — 每日 500 MB 免費，保存 7 天
  * [sumologic.com](https://www.sumologic.com/) — 每日 500 MB 免費，保存 7 天
  * [logflare.app](https://logflare.app/) — 每月每應用最多 12,960,000 筆紀錄，保存 3 天免費
  * [logtail.com](https://logtail.com/) — 基於 ClickHouse 的 SQL 相容日誌管理。每月 1 GB 免費，保存 3 天。
  * [logzab.com](https://logzab.com/) — 稽核追蹤管理系統。每月免費 1,000 筆用戶活動日誌，保存 1 個月，最多 5 個專案。
  * [openobserve.ai](https://openobserve.ai/) - 每月 200 GB 日誌接收免費，保存 15 天


**[⬆️ 返回頂部](#table-of-contents)**

## 翻譯管理

  * [crowdin.com](https://crowdin.com/) — 開源專案享有不限專案數、不限字串、不限協作者
  * [gitlocalize.com](https://gitlocalize.com) - 私人和公開倉庫皆可免費且無限制
  * [Lecto](https://lecto.ai/) - 機器翻譯 API，提供免費方案（每月30次請求，每次可翻譯1000字元）。已整合至 Loco Translate Wordpress 外掛。
  * [lingohub.com](https://lingohub.com/) — 最多 3 位使用者免費，開源專案永遠免費
  * [localazy.com](https://localazy.com) - 免費提供1000個原文語言字串，不限語言、不限貢獻者，並有新創與開源優惠
  * [Localeum](https://localeum.com) - 最多1000字串、1位使用者、無限語言、無限專案免費
  * [localizely.com](https://localizely.com/) — 開源專案免費
  * [Loco](https://localise.biz/) — 最多2000筆翻譯免費，不限譯者，每專案最多10種語言、1000可翻譯資產
  * [oneskyapp.com](https://www.oneskyapp.com/) — 最多5位使用者享有限制的免費版本，開源專案免費
  * [POEditor](https://poeditor.com/) — 最多1000字串免費
  * [SimpleLocalize](https://simplelocalize.io/) - 最多100個翻譯鍵免費，不限字串、不限語言，提供新創優惠
  * [Texterify](https://texterify.com/) - 免費提供單一使用者版
  * [Tolgee](https://tolgee.io) - SaaS 版提供有限翻譯免費，永久免費自架版本
  * [transifex.com](https://www.transifex.com/) — 開源專案免費
  * [Translation.io](https://translation.io) - 開源專案免費
  * [Translized](https://translized.com) - 最多1000字串、1位使用者、無限語言、無限專案免費
  * [webtranslateit.com](https://webtranslateit.com/) — 最多500字串免費
  * [weblate.org](https://weblate.org/) — 對自由軟體專案免費，免費方案最多10,000個字串來源，無限自架本地部署
  * [Free PO editor](https://pofile.net/free-po-editor) — 完全免費
  * [Lingo.dev](https://lingo.dev) – 開源 AI 驅動的 CLI 工具，適用於網頁與行動端在地化。可自帶 LLM，或每月使用 Lingo.dev 管理的在地化引擎免費翻譯 10,000 字。

**[⬆️ 返回頂部](#table-of-contents)**

## 監控

  * [UptimeObserver.com](https://uptimeobserver.com) - 提供 20 個 5 分鐘間隔的運作監控與可自訂的狀態頁，商業用途亦可。支援 Email 與 Telegram 即時通知，無需信用卡即可開始使用。
  * [Pingmeter.com](https://pingmeter.com/) - 5 個運作監控，10 分鐘間隔。可監控 SSH、HTTP、HTTPS 及任何自訂 TCP 端口。
  * [alerty.ai](https://www.alerty.ai) - 免費 APM 與前後端、資料庫等監控，並有免費代理執行。
  * [appdynamics.com](https://www.appdynamics.com/) — 24 小時指標免費，應用效能管理代理限於一個 Java、一個 .NET、一個 PHP 和一個 Node.js
  * [appneta.com](https://www.appneta.com/) — 免費保存 1 小時數據
  * [appspector.com](https://appspector.com/) - 遠端 iOS/Android/Flutter 除錯任務控制。小流量（64MB 日誌）免費。
  * [assertible.com](https://assertible.com) — API 自動化測試與監控。團隊和個人皆有免費方案。
  * [bleemeo.com](https://bleemeo.com) - 免費監控 3 台伺服器、5 個運作監控，不限用戶、不限儀表板、不限警報規則。
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - 查詢網址或網站的 Core Web Vitals 歷史數據。
  * [checklyhq.com](https://checklyhq.com) - 開源 E2E/合成監控與 API 深度監控。免費方案含一位用戶、每月 10,000 次 API/網路檢查與 1,500 次瀏覽器檢查。
  * [cloudsploit.com](https://cloudsploit.com) — AWS 安全與組態監控。免費：不限次隨選掃描、不限使用者、不限帳戶儲存。付費：自動掃描、API 存取等。
  * [cronitor.io](https://cronitor.io/) - cron 任務、網站、API 等效能與運作監控。免費提供 5 個監控。
  * [datadoghq.com](https://www.datadoghq.com/) — 最多 5 個節點免費
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — cron 任務監控。1 個免費 snitch（監控），推薦他人註冊可增加
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 個運作監控，5 分鐘間隔。Email、Slack 警報。
  * [economize.cloud](https://economize.cloud) — 以組織化雲資源來優化並報告雲架構成本。每月 Google Cloud Platform 消費 5,000 美元以下免費。
  * [elastic.co](https://www.elastic.co/solutions/apm) — JS 開發者即時效能分析。免費 24 小時資料保留
  * [fivenines.io](https://fivenines.io/) — Linux 伺服器即時監控與警報，最多 5 台伺服器、60 秒間隔，永久免費，無需信用卡。
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud 為可組合的可觀測性平台，整合指標與日誌。免費方案：3 位用戶、10 個儀表板、100 筆警報、Prometheus/Graphite 指標儲存（10,000 系列，保留 14 天），Loki 日誌儲存（50GB，保留 14 天）
  * [healthchecks.io](https://healthchecks.io) — 監控 cron 任務與背景工作。最多 20 個檢查免費。
  * [Hydrozen.io](https://hydrozen.io) — 運作監控與狀態頁，免費方案：10 個運作監控、5 個心跳監控、1 個網域監控、1 個狀態頁。
  * [incidenthub.cloud](https://incidenthub.cloud/) — 雲端及 SaaS 狀態頁聚合器 - 20 個監控與 2 種通知渠道（Slack、Discord）永久免費。
  * [inspector.dev](https://www.inspector.dev) - 1 分鐘內即可建立完整即時監控儀表板，永久免費方案。
  * [instrumentalapp.com](https://instrumentalapp.com) - 美觀且易用的應用與伺服器監控，最多 500 個指標、3 小時數據可視化免費。
  * [keychest.net/speedtest](https://keychest.net/speedtest) - 獨立的速度測試與 TLS 握手延遲測試，對比 Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - SSL 監控，最多 5 個監控免費
  * [linkok.com](https://linkok.com) - 網站壞鏈檢查，小型網站（最多 100 頁）免費，開源專案完全免費。
  * [loader.io](https://loader.io/) — 免費負載測試工具，有使用限制
  * [MonitorMonk](https://monitormonk.com) - 極簡運作監控與美觀狀態頁。永久免費方案提供 10 個網站或 API HTTPS、關鍵字、SSL、回應時間監控，含 2 個儀表板／狀態頁。
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata 是開源即時監控工具，也可在 GitHub 找到！
  * [newrelic.com](https://www.newrelic.com) — New Relic 可觀測性平台，助工程師打造更完美軟體。從單體到無伺服器，皆可監控、分析、疑難排解與最佳化整個軟體堆疊。免費方案每月 100GB 資料傳入、一位全權用戶、無限主要用戶。
  * [Middleware.io](https://middleware.io/) - Middleware 可觀測性平台，提供應用與堆疊完整可視化，可大規模監控與診斷。開發社群永久免費方案：最多 100 萬筆日誌監控、2 台主機基礎架構監控與 APM。
  * [nixstats.com](https://nixstats.com) - 一台伺服器免費。Email 通知、公開狀態頁、60 秒間隔等功能。
  * [OnlineOrNot.com](https://onlineornot.com/) - 網站與 API 運作監控，cron 任務與排程監控，並提供狀態頁。前五個檢查（3 分鐘間隔）免費。可透過 Slack、Discord、Email 發送警報。
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — 測試網站是否被中國防火牆封鎖。比較中國與美國伺服器偵測的 DNS 結果與 ASN 資訊來識別 DNS 污染。
  * [opsgenie.com](https://www.opsgenie.com/) — 強大的警報與待命管理，維運 24 小時服務。最多 5 位用戶免費。
  * [paessler.com](https://www.paessler.com/) — 強大的基礎設施與網路監控解決方案，含警報、可視化及基礎報告功能。最多 100 個感測器免費。
  * [pagecrawl.io](https://pagecrawl.io/) - 網站變更監控，最多 6 個監控每日檢查免費。
  * [syagent.com](https://syagent.com/) — 非商業用途免費伺服器監控服務，含警報與指標。
  * [pagerly.io](https://pagerly.io/) - 於 Slack 上管理待命（可整合 Pagerduty、OpsGenie）。最多 1 組團隊免費（一組團隊對應一個待命）。
  * [pagertree.com](https://pagertree.com/) - 簡易的警報與待命管理介面。最多 5 位用戶免費。
  * [phare.io](https://phare.io/) - 運作監控，免費支援最多 100,000 個事件，不限專案與狀態頁。
  * [pingbreak.com](https://pingbreak.com/) — 現代化運作監控服務。不限網址檢查，透過 Discord、Slack 或 Email 提供停機通知。
  * [pingpong.one](https://pingpong.one/) — 進階狀態頁平台含監控。免費版含一個公開可自訂狀態頁與 SSL 子網域。專業版對開源專案及非營利組織免費。
  * [robusta.dev](https://home.robusta.dev/) — 基於 Prometheus 的強大 Kubernetes 監控。可自帶 Prometheus 或安裝一體機。免費方案支援最多 20 個 K8s 節點。支援 Slack、Teams、Discord 等警報，整合 PagerDuty、OpsGenie、VictorOps、DataDog 等工具。
  * [sematext.com](https://sematext.com/) — 24 小時指標免費，不限伺服器，10 個自訂指標，500,000 筆自訂指標數據，不限儀表板、用戶等。
  * [sitemonki.com](https://sitemonki.com/) — 網站、網域、Cron 與 SSL 監控，每類最多 5 個監控免費
  * [sitesure.net](https://sitesure.net) - 網站與 cron 監控，2 個監控免費
  * [skylight.io](https://www.skylight.io/) — 前 100,000 筆請求免費（僅限 Rails）
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — 效能監控 API，檢查 Ping、DNS 等
  * [stathat.com](https://www.stathat.com/) — 免費建立 10 個統計指標，無到期日
  * [statuscake.com](https://www.statuscake.com/) — 網站監控，不限測試數但有功能限制
  * [statusgator.com](https://statusgator.com/) — 狀態頁監控，3 個監控免費
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — 伺服器、運作、DNS 與網域監控。免費監控 10 台伺服器、10 個運作、10 個網域。
  * [thousandeyes.com](https://www.thousandeyes.com/) — 網路與用戶體驗監控。3 個地點、20 筆主要網路服務數據免費
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — 免費監控 5 個網站，60 秒間隔，公開狀態頁。
  * [zenduty.com](https://www.zenduty.com/) — 端到端事故管理、警報、待命管理及回應協作平台，適合網路運維、SRE、DevOps 團隊。最多 5 位用戶免費。
  * [instatus.com](https://instatus.com) - 10 秒鐘內建立美觀狀態頁。永久免費，無限訂閱者、無限團隊。
  * [Squadcast.com](https://squadcast.com) - Squadcast 是端到端事故管理軟體，協助推廣 SRE 最佳實踐。永久免費方案支援最多 10 位用戶。
  * [RoboMiri.com](https://robomiri.com/) - 穩定的運作監控，支援多種監控：cronjob、關鍵字、網站、端口、ping。25 個運作監控，3 分鐘間隔免費。警報支援電話、簡訊、Email 與 Webhook。
  * [Better Stack](https://betterstack.com/better-uptime) - 運作監控、事故管理、待命排班/警報與狀態頁整合於單一產品。免費方案含 10 個監控，每 3 分鐘檢查一次，含狀態頁。
  * [Pulsetic](https://pulsetic.com) - 10 個監控、6 個月運作／日誌歷史、不限狀態頁與自訂網域！永久免費、不限 Email 警報，無需信用卡。
  * [Wachete](https://www.wachete.com) - 監控 5 個頁面，每 24 小時檢查一次。
  * [Xitoring.com](https://xitoring.com/) — 運作監控：20 個免費，Linux/Windows 伺服器監控：5 個免費，狀態頁：1 個免費。含行動 App、多通知管道等。
  * [Servervana](https://servervana.com) - 進階運作監控，支援大型專案與團隊。提供 HTTP、瀏覽器、DNS、網域監控、狀態頁等。免費方案含 10 個 HTTP 監控、1 個 DNS 監控、1 個狀態頁。

**[⬆️ 返回頂部](#table-of-contents)**

## 異常與崩潰處理

  * [CatchJS.com](https://catchjs.com/) - JavaScript 錯誤追蹤，附帶螢幕截圖與點擊軌跡。對開源專案免費。
  * [bugsnag.com](https://www.bugsnag.com/) — 試用期後每月可免費處理 2,000 個錯誤
  * [elmah.io](https://elmah.io/) — 網頁開發人員的錯誤日誌與運行監控。開源專案可免費獲得 Small Business 訂閱。
  * [Embrace](https://embrace.io/) — 行動應用程式監控。每年最多 100 萬用戶會話的小團隊可免費使用。
  * [exceptionless](https://exceptionless.com) — 即時錯誤、功能、日誌回報等。每月 3,000 事件/1 位用戶免費。開源且可自架設，無使用限制。
  * [GlitchTip](https://glitchtip.com/) — 簡單、開源的錯誤追蹤服務。相容於開源 Sentry SDK。每月 1,000 事件免費，或可自行架設無限制。
  * [honeybadger.io](https://www.honeybadger.io) - 例外、運作狀態與排程監控。小團隊與開源專案免費（每月 12,000 錯誤）。
  * [memfault.com](https://memfault.com) — 雲端設備可觀測性與除錯平台。100 台 [Nordic](https://app.memfault.com/register-nordic)、[NXP](https://app.memfault.com/register-nxp)、[Laird](https://app.memfault.com/register-laird) 設備免費。
  * [rollbar.com](https://rollbar.com/) — 例外與錯誤監控，免費方案每月 5,000 個錯誤、無限用戶、30 天保留期
  * [sentry.io](https://sentry.io/) — Sentry 即時追蹤應用程式例外，提供小型免費方案。每月 5,000 錯誤/1 用戶免費，自架設無限制
  * [Axiom](https://axiom.co/) — 最多可儲存 0.5 TB 日誌，保留 30 天。包含與 Vercel 等平台整合、進階資料查詢、Email/Discord 通知等功能。
  * [Semaphr](https://semaphr.com) — 行動應用程式專用免費一站式 kill switch 服務。
  * [Jam](https://jam.dev) - 一鍵產生開發者友善的錯誤回報。免費方案不限 Jam 數量。
  * [Whitespace](https://whitespace.dev) – 一鍵在瀏覽器中回報錯誤。個人用途免費方案不限錄影次數。

**[⬆️ 回到頂部](#table-of-contents)**

## 搜尋

  * [algolia.com](https://www.algolia.com/) — 託管型搜尋解決方案，具備錯字容錯、相關性、UI 函式庫，輕鬆打造搜尋體驗。免費「Build」方案包含 100 萬文件與每月 1 萬次搜尋。另提供 [開發者文件搜尋](https://docsearch.algolia.com/) 免費服務。
  * [bonsai.io](https://bonsai.io/) — 免費 1 GB 記憶體與 1 GB 儲存空間
  * [CommandBar](https://www.commandbar.com/) - 統一搜尋列即服務，網頁 UI 小工具/插件，幫助用戶在產品內搜尋內容、導航、功能等，提升發現性。每月 1,000 活躍用戶免費，指令不限。
  * [Orama Cloud](https://orama.com/pricing) — 免費 3 個索引，每個索引 10 萬文件，全文/向量/混合搜尋不限次數，60 天分析數據
  * [searchly.com](http://www.searchly.com/) — 免費 2 個索引，20 MB 儲存空間
  * [easysitesearch.com](https://easysitesearch.com/) — 搜尋小工具與 API，基於自動網路爬蟲索引。最多 50 個子頁面不限搜尋次數，完全免費。

**[⬆️ 回到頂部](#table-of-contents)**

## 教育與職涯發展

  * [FreeCodeCamp](https://www.freecodecamp.org/) - 開源平台，提供資料分析、資訊安全、網頁開發等多種免費課程與證書。
  * [The Odin Project](https://www.theodinproject.com/) - 免費開源平台，課程內容專注於 JavaScript 與 Ruby 網頁開發。
  * [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - 免費平台，提供大量專業人士履歷模板，可完整複製、編輯與下載，並通過 ATS 優化。
  * [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - 免費短期課程，由業界領先專家授課，一小時內即可實作最新生成式 AI 工具與技術。
  * [LabEx](https://labex.io) - 透過互動式實驗與真實專案，培養 Linux、DevOps、資安、程式設計、資料科學等技能。
  * [Roadmap.sh](https://roadmap.sh) - 免費學習地圖，涵蓋從區塊鏈到 UX 設計等開發各面向。
  * [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - 提供網路安全、網路技術、Python 等主題的免費認證課程。
  * [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT 開放式課程網，線上免費發布 2,500 多門課程教材，與全球學習者與教育者分享知識。YouTube 頻道：[ @mitocw ](https://www.youtube.com/@mitocw/featured)
  * [W3Schools](https://www.w3schools.com/) - 提供 HTML、CSS、JavaScript 等網頁開發技術的免費教學。
  * [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - 免費線上課程，學習基礎與進階 HTML/CSS、JavaScript 及 SQL。
  * [Full Stack Open](https://fullstackopen.com/en/) – 免費大學等級現代網頁開發課程，涵蓋 React、Node.js、GraphQL、TypeScript 等。全線上自學進度。
  * [edX](https://www.edx.org/) - 提供來自 250 所頂尖機構（含哈佛、MIT）超過 4,000 門免費線上課程，專攻資工、工程與資料科學。
  * [Django-tutorial.dev](https://django-tutorial.dev) - 免費線上教學，適合以 Django 作為第一個框架學習，並為用戶投稿文章提供免費 dofollow 反向連結。

**[⬆️ 回到頂部](#table-of-contents)**

## 電子郵件

  * [10minutemail](https://10minutemail.com) - 免費臨時信箱，適合測試用途。
  * [AhaSend](https://ahasend.com) - 交易型郵件服務，每月 1,000 封郵件免費，支援不限網域、不限團隊成員、webhook 及郵件路由。
  * [AnonAddy](https://anonaddy.com) - 開源匿名郵件轉發，免費建立無限郵件別名
  * [Antideo](https://www.antideo.com/) — 免費方案每小時 10 次 API 驗證電子郵件、IP 與電話號碼。無需信用卡。
  * [Brevo](https://www.brevo.com/) — 每月 9,000 封郵件，每天 300 封免費
  * [OneSignal](https://onesignal.com/) — 每月 10,000 封郵件，無需信用卡。
  * [Bump](https://bump.email/) - 免費 10 個 Bump 郵件地址，1 個自訂網域
  * [Burnermail](https://burnermail.io/) – 免費 5 個臨時郵件地址、1 個信箱、7 天信箱歷史
  * [Buttondown](https://buttondown.email/) — 電子報服務。最多 100 訂閱者免費
  * [CloudMailin](https://www.cloudmailin.com/) - 支援 HTTP POST 進件與交易型外寄，每月 10,000 封郵件免費
  * [Contact.do](https://contact.do/) — 以連結方式提供聯絡表單（表單界的 bitly）
  * [debugmail.io](https://debugmail.io/) — 易於使用的郵件測試伺服器，適合開發者
  * [DNSExit](https://dnsexit.com/) - 每個網域可免費 2 個郵件地址，100MB 儲存空間。支援 IMAP、POP3、SMTP、SPF/DKIM。
  * [EmailLabs.io](https://emaillabs.io/en) — 每月最多 9,000 封郵件免費，每天最多 300 封。
  * [EmailOctopus](https://emailoctopus.com) - 最多 2,500 訂閱者與每月 10,000 封郵件免費
  * [EmailJS](https://www.emailjs.com/) – 僅提供郵件客戶端，讓你可從前端發信而不暴露憑證，免費方案每月 200 次、2 種郵件模板、單次最大 50Kb、聯絡人歷史有限。
  * [EtherealMail](https://ethereal.email) - Ethereal 是一個虛擬 SMTP 服務，主要供 Nodemailer 與 EmailEngine 用戶（不限於此）使用。完全免費且郵件永不會真正投遞。
  * [Temp-Mail.org](https://temp-mail.org/en/) - 臨時/拋棄式信箱，支援多種網域。每次重新整理頁面，地址即自動更新。完全免費，無任何收費項目。
  * [TempMailDetector.com](https://tempmaildetector.com/) - 每月可免費驗證 200 封郵件，檢查郵箱是否臨時信箱。
  * [Emailvalidation.io](https://emailvalidation.io) - 每月免費驗證 100 封郵件
  * [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - 德國臨時/拋棄式信箱產生器。支援 10 個網域，地址數不限。（含廣告）無其他費用，完全免費。
  * [forwardemail.net](https://forwardemail.net) — 免費自訂網域郵件轉發。可用自有網域建立及轉發無限郵件地址（**注意**：若使用 .casa、.cf、.click、.email、.fit、.ga、.gdn、.gq、.lat、.loan、.london、.men、.ml、.pl、.rest、.ru、.tk、.top、.work 等 TLD 則需付費，因濫發垃圾信）
  * [Imitate Email](https://imitate.email) - 郵件沙盒伺服器，方便在建置/QA/CI/CD 階段測試郵件功能。免費帳號每天可收 15 封信，永久有效。
  * [ImprovMX](https://improvmx.com) – 免費郵件轉發。
  * [EForw](https://www.eforw.com) – 免費單一網域郵件轉發。支援收發郵件。
  * [Inboxes App](https://inboxesapp.com) — 每天可建立最多 3 個臨時郵箱，用完可直接在 Chrome 擴充中刪除。適合測試註冊流程。
  * [inboxkitten.com](https://inboxkitten.com/) - 免費臨時/拋棄式信箱，郵件自動保存 3 天後自動刪除。開源且可自架設。
  * [mail-tester.com](https://www.mail-tester.com) — 測試郵件 DNS/SPF/DKIM/DMARC 設定是否正確，每月 20 次免費。
  * [dkimvalidator.com](https://dkimvalidator.com/) - 檢查郵件 DNS/SPF/DKIM/DMARC 設定是否正確，由 roundsphere.com 免費提供
  * [mailcatcher.me](https://mailcatcher.me/) — 截取郵件並透過網頁介面檢視。
  * [mailchannels.com](https://www.mailchannels.com) - Email API，REST API 與 SMTP 整合，每月最多 3,000 封郵件免費。
  * [Mailcheck.ai](https://www.mailcheck.ai/) - 防止用戶用臨時信箱註冊，每小時 120 次（約每月 86,400 次）
  * [Mailchimp](https://mailchimp.com/) — 最多 500 訂閱者與每月 1,000 封郵件免費。
  * [Maildroppa](https://maildroppa.com) - 最多 100 訂閱者及無限郵件與自動化流程免費。
  * [MailerLite.com](https://www.mailerlite.com) — 每月 1,000 訂閱者、12,000 封郵件免費
  * [MailerSend.com](https://www.mailersend.com) — Email API、SMTP，交易型郵件每月 3,000 封免費
  * [mailinator.com](https://www.mailinator.com/) — 免費公開郵箱系統，可隨意使用任意信箱
  * [Mailjet](https://www.mailjet.com/) — 每月 6,000 封郵件免費（每天最多 200 封）
  * [Mailnesia](https://mailnesia.com) - 免費臨時/拋棄式信箱，自動點擊註冊連結。
  * [mailsac.com](https://mailsac.com) - 免費臨時郵件 API，公開信箱、外寄捕獲、郵件轉發到 Slack/websocket/webhook（每月 1,500 API 限額）
  * [Mailtrap.io](https://mailtrap.io/) — 開發用虛擬 SMTP 伺服器，免費方案含單一信箱、100 封郵件、無團隊成員、每秒最多 2 封、無轉發規則。
  * [Mail7.io](https://www.mail7.io/) — 為 QA 開發者提供免費臨時信箱。可用網頁或 API 立即建立信箱。
  * [Momentary Email](https://www.momentaryemail.com/) — 免費臨時郵箱。可在網站或用 RSS 閱讀郵件。
  * [Mutant Mail](https://www.mutantmail.com/) – 免費 10 個郵件 ID、1 個網域、1 個信箱。所有信箱歸一信箱管理。
  * [Outlook.com](https://outlook.live.com/owa/) - 免費個人郵件與行事曆。
  * [Parsio.io](https://parsio.io) — 免費郵件解析器（郵件轉寄、數據提取、發送到伺服器）
  * [pepipost.com](https://pepipost.com) — 首月 3 萬封免費，之後每日前 100 封免費。
  * [Plunk](https://useplunk.com) - 每月 3,000 封郵件免費
  * [Postmark](https://postmarkapp.com/) - 每月 100 封郵件免費，DMARC 每週摘要無限。
  * [Proton Mail](https://proton.me/mail) - 免費安全郵件服務，內建端對端加密。1GB 免費儲存空間。
  * [Queuemail.dev](https://queuemail.dev) — 穩定郵件投遞 API。免費層每月 10,000 封。非同步發送，多 SMTP 支援。黑名單、日誌、追蹤、Webhook 等功能。
  * [QuickEmailVerification](https://quickemailverification.com) — 免費層每天可驗證 100 封郵件，另有 DEA 檢測、DNS 查詢、SPF 檢測等免費 API。
  * [Resend](https://resend.com) - 提供給開發者的交易型電子郵件 API。每月 3,000 封郵件、每天 100 封郵件免費，支援一個自訂網域。
  * [Sender](https://www.sender.net) 每月最多 15,000 封郵件，最多 2,500 訂閱者
  * [Sendpulse](https://sendpulse.com) — 每月 500 位訂閱者，每月 15,000 封郵件免費
  * [SimpleLogin](https://simplelogin.io/) – 開源、可自我託管的電子郵件別名/轉寄解決方案。免費提供 5 個別名，無限流量，無限回覆/發送。教育工作者（學生、研究人員等）免費。
  * [Substack](https://substack.com) — 無限免費電子報服務。當你開始收費時才需付費。
  * [Sweego](https://www.sweego.io/) - 歐洲開發者用交易型郵件 API。每天 500 封郵件免費。
  * [Takeout](https://takeout.bysourfruit.com) - 一個持續更新的電子郵件服務，讓發送郵件變得簡單。每月 500 封交易型郵件免費。
  * [temp-mail.io](https://temp-mail.io) — 支援多組郵箱及轉寄的免費一次性臨時郵箱服務
  * [tinyletter.com](https://tinyletter.com/) — 每月 5,000 位訂閱者免費
  * [Touchlead](https://touchlead.app) - 多功能行銷自動化工具，含潛在客戶管理、表單建構器與自動化。有限潛在客戶及自動化數量免費。
  * [trashmail.com](https://www.trashmail.com) - 提供可轉寄且自動失效的一次性電子郵件地址
  * [Tuta](https://tuta.com/) - 免費安全電子郵件帳號服務供應商，內建端對端加密，無廣告、無追蹤。免費 1GB 儲存空間，一個行事曆（Tuta 也有[付費方案](https://tuta.com/pricing)。）。Tuta 部分[開源](https://github.com/tutao/tutanota)，可自我託管。
  * [Verifalia](https://verifalia.com/email-verification-api) — 即時電子郵件驗證 API，支援信箱確認與一次性郵箱偵測；每天 25 次免費驗證。
  * [verimail.io](https://verimail.io/) — 批次及 API 電子郵件驗證服務。每月 100 次免費驗證
  * [Zoho](https://www.zoho.com) — 原為電子郵件服務提供者，現提供多項服務，其中部分有免費方案。提供免費方案的服務清單：
     - [Email](https://zoho.com/mail) 每 5 位使用者免費。5GB/使用者及 25MB 附件上限，支援一個網域。
     - [Zoho Assist](https://www.zoho.com/assist) — Zoho Assist 永久免費方案包含一個同時遠端支援授權及 5 個無人值守電腦授權，適用於專業及個人用途，無時間限制。
     - [Sprints](https://zoho.com/sprints) 5 位使用者、5 專案及 500MB 儲存免費。
     - [Docs](https://zoho.com/docs) — 5 位使用者免費，1GB 上傳限制及 5GB 儲存空間。Zoho Office 套件（Writer、Sheets & Show）隨附。
     - [Projects](https://zoho.com/projects) — 3 位使用者、2 個專案及 10MB 附件上限免費。相同方案適用於 [Bugtracker](https://zoho.com/bugtracker)。
     - [Connect](https://zoho.com/connect) — 團隊協作，25 位使用者免費，含三個群組、三個自訂應用、三個看板、三本手冊及 10 組整合，並支援頻道、活動及論壇。
     - [Meeting](https://zoho.com/meeting) — 支援最多 3 位會議參與者及 10 位網路研討會出席者的會議功能。
     - [Vault](https://zoho.com/vault) — 個人可免費使用的密碼管理服務。
     - [Showtime](https://zoho.com/showtime) — 另一款線上訓練會議軟體，最多 5 位遠端參與者免費。
     - [Notebook](https://zoho.com/notebook) — 免費的 Evernote 替代品。
     - [Wiki](https://zoho.com/wiki) — 3 位使用者免費，50MB 儲存空間，無限頁面、zip 備份、RSS & Atom feed、存取控制及可自訂 CSS。
     - [Subscriptions](https://zoho.com/subscriptions) — 循環收費管理，20 位客戶/訂閱 & 1 位使用者免費，所有支付託管由 Zoho 處理，最後 40 項訂閱統計數據會被儲存
     - [Checkout](https://zoho.com/checkout) — 產品收費管理，3 頁及最多 50 次支付免費。
     - [Desk](https://zoho.com/desk) — 客戶支援管理，3 位客服、私人知識庫及電子郵件工單免費。可與 [Assist](https://zoho.com/assist) 整合，一位遠端技術員及 5 台無人電腦。
     - [Cliq](https://zoho.com/cliq) — 團隊聊天軟體，100GB 儲存，無限用戶，每頻道 100 位用戶及 SSO。
     - [Campaigns](https://zoho.com/campaigns) - 電子郵件行銷
     - [Forms](https://zoho.com/forms) - 表單建立工具
     - [Sign](https://zoho.com/sign) - 無紙化簽名
     - [Surveys](https://zoho.com/surveys) - 線上調查
     - [Bookings](https://zoho.com/bookings) - 預約排程
  * [Maileroo](https://maileroo.com) - 開發者用 SMTP relay 與電子郵件 API。每月 5,000 封郵件，無限網域，免費郵件驗證、黑名單監控、郵件測試等功能。

**[⬆️ 回到頂部](#table-of-contents)**

## 功能切換管理平台

  * [ConfigCat](https://configcat.com) - 以開發者為中心的功能旗標服務，團隊人數無上限，支援卓越，價格合理。免費方案支援最多 10 個旗標、2 個環境、1 個產品及每月 500 萬次請求。
  * [Flagsmith](https://flagsmith.com) - 自信發布新功能；管理網頁、行動及伺服器端應用的功能旗標。可使用我們的託管 API、部署至私有雲，或自建部署。
  * [GrowthBook](https://growthbook.io) - 開源功能旗標與 A/B 測試平台，內建貝葉斯統計分析引擎。免費方案支援最多 3 位使用者，無限功能旗標與實驗。
  * [Hypertune](https://www.hypertune.com) - 型別安全的功能旗標、A/B 測試、分析與應用程式設定，具備 Git 風格版本控制及同步、記憶體內、在地旗標評估。免費方案支援最多 5 位團隊成員，無限功能旗標與 A/B 測試。
  * [Molasses](https://www.molasses.app) - 強大的功能旗標與 A/B 測試。免費提供最多 3 個環境，每個環境 5 個功能旗標。
  * [Toggled.dev](https://www.toggled.dev) - 企業級、可擴展的多區功能切換管理平台。免費方案支援最多 10 個旗標、2 個環境、無限請求。SDK、分析儀表板、發布日曆、Slack 通知等功能皆包含在無限免費方案內。
  * [Statsig](https://www.statsig.com) - 強大的功能管理、A/B 測試、分析等平台。免費方案提供無限席位、旗標、實驗與動態設定，支援每月最多 100 萬事件。
  * [Abby](https://www.tryabby.com) - 開源功能旗標與 A/B 測試。配置即程式碼，完全型別化 Typescript SDK。與 Next.js、React 等框架強力整合。免費方案大方，擴充價格低廉。


**[⬆️ 回到頂部](#table-of-contents)**

## 字型

  * [dafont](https://www.dafont.com/) - 本網站所展示之字型為原作者所有，型態包含免費軟體、共享軟體、試用版或公有領域。
  * [Everything Fonts](https://everythingfonts.com/) - 提供多種工具：@font-face、單位轉換器、字型微調器及字型提交工具。
  * [Font Squirrel](https://www.fontsquirrel.com/) - 可用於商業用途的免費字型。精選多款字體，並以易用格式呈現。
  * [Google Fonts](https://fonts.google.com/) - 多款免費字型，可快速安裝於網站，下載或透過 Google CDN 連結。
  * [FontGet](https://www.fontget.com/) - 提供各種可下載字型，並以標籤分門別類。
  * [Fontshare](https://www.fontshare.com/) - 免費字型服務，持續成長的專業等級字型收藏，100% 可供個人及商業用途。
  * [Befonts](https://befonts.com/) - 提供多款獨特字型，供個人或商業用途。
  * [Font of web](https://fontofweb.com/) - 辨識網站上所有已用字型及其使用情境。
  * [Bunny](https://fonts.bunny.net) 重視隱私的 Google Fonts 替代
  * [FontsKey](https://www.fontskey.com/) - 提供免費及付費商用字型，可輸入文字快速篩選。
  * [fonts.xz.style](https://fonts.xz.style/) 免費開源網站字型服務，透過 CSS 傳遞字型家族。
  * [Fontsensei](https://fontsensei.com/) 開源 Google Fonts，標籤由用戶提供。支援 CJK（中、日、韓）字型標籤。

**[⬆️ 回到頂部](#table-of-contents)**

## 表單

  * [Feathery](https://feathery.io) - 強大、對開發者友善的表單建構器。可建立註冊 & 登入、用戶導覽、付款流程、複雜金融應用等。免費方案每月最多 250 答覆、5 個啟用表單。
  * [Form-Data](https://form-data.com) - 無需程式設計的表單後端。垃圾郵件過濾、郵件通知及自動回覆、webhooks、zapier、轉址、AJAX 或 POST 等。免費方案可建立無限表單，每月 20 答覆，帶 Form-Data 徽章再送 2000 答覆。
  * [FabForm](https://fabform.io/) - 智慧型開發者專用表單後端平台。免費方案每月可提交 250 份表單。現代化友善介面。支援 Google Sheets、Airtable、Slack、Email 等整合。
  * [Form.taxi](https://form.taxi/) — HTML 表單提交終端點。含通知、垃圾郵件攔截、GDPR 合規資料處理。基本用途免費方案。
  * [Formcarry.com](https://formcarry.com) - HTTP POST 表單終端點，免費方案每月允許 100 答覆。
  * [formingo.co](https://www.formingo.co/)- 靜態網站專用簡易 HTML 表單。無需註冊帳號即可免費開始。免費方案每月 500 答覆，支援自訂回覆郵箱。
  * [FormKeep.com](https://www.formkeep.com/) - 無限表單，每月 50 答覆，垃圾郵件防護、郵件通知、可輸出 HTML 的拖曳設計器。進階功能有自訂欄位規則、團隊、與 Google Sheets、Slack、ActiveCampaign、Zapier 整合。
  * [formlets.com](https://formlets.com/) — 線上表單，無限單頁表單/月，每月 100 答覆，含郵件通知。
  * [formspark.io](https://formspark.io/) -  表單轉郵件服務，免費方案允許無限表單，每月 250 答覆，客戶支援團隊協助。
  * [Formspree.io](https://formspree.io/) — 使用 HTTP POST 請求發送郵件。免費方案每表單每月限 50 答覆。
  * [Formsubmit.co](https://formsubmit.co/) — 簡易 HTML 表單端點。永久免費，無需註冊。
  * [Formlick.com](https://formlick.com) - Typeform 替代方案，終身優惠。用戶可建立 1 份免費表單並接收無限提交。付費可建立無限表單及接收無限提交。
  * [getform.io](https://getform.io/) - 設計師及開發者用表單後端平台，1 份表單、50 答覆、單檔上傳、100MB 檔案儲存。
  * [HeroTofu.com](https://herotofu.com/) - 表單後端，含機器人檢測與加密封存。可經 UI 轉寄答覆到 Email、Slack 或 Zapier。自備前端，無需伺服器程式碼。免費方案無限表單、每月 100 答覆。
  * [HeyForm.net](https://heyform.net/) - 拖曳式線上表單建構器。免費層可建立無限表單並收集無限答覆，附預設範本、防垃圾郵件及 100MB 檔案儲存空間。
  * [Tally.so](https://tally.so/) - 99% 功能皆免費。免費層支援：無限表單、無限答覆、郵件通知、表單邏輯、收款、檔案上傳、自訂感謝頁等。
  * [Hyperforms.app](https://hyperforms.app/) — 秒建表單轉郵件等服務，無需後端程式碼。個人帳戶每月最多 50 份表單提交免費。
  * [Kwes.io](https://kwes.io/) - 功能豐富的表單端點，靜態網站適用。免費方案 1 個網站、每月最多 50 答覆。
  * [Pageclip](https://pageclip.co/) - 免費方案支援 1 個網站、1 份表單及每月 1,000 答覆。
  * [Qualtrics Survey](https://qualtrics.com/free-account) — 專業級表單及調查工具，50+ 專家設計範本。免費帳號限 1 份啟用調查、每份 100 答覆、8 種答覆類型。
  * [Screeb](https://screeb.app/) - 應用內調查與產品分析，解讀用戶行為。永久免費方案支援 500 位月活用戶、無限答覆及事件、多項整合、匯出及定期報告。
  * [smartforms.dev](https://smartforms.dev/) - 強大易用的網站表單後端，永久免費方案每月 50 答覆，250MB 檔案儲存，支援 Zapier、CSV/JSON 匯出、自訂轉址、自訂回應頁、Telegram & Slack 機器人、單一郵件通知。
  * [Survicate](https://survicate.com/) — 一站式回饋收集與後續調查工具。AI 自動分析與洞察。支援免費電子郵件、網站、產品內與行動調查，AI 調查產生器及每月 25 答覆。
  * [staticforms.xyz](https://www.staticforms.xyz/) - 無需伺服器端程式碼即可輕鬆整合 HTML 表單。用戶送出後，內容將郵寄至你註冊的郵箱。
  * [stepFORM.io](https://stepform.io) - 測驗與表單建構器。免費方案提供 5 份表單、每表單最多 3 步驟、每月 50 答覆。
  * [Typeform.com](https://www.typeform.com/) — 網站上可嵌入美觀表單。免費方案每份表單僅 10 欄位，每月 100 答覆。
  * [WaiverStevie.com](https://waiverstevie.com) - 電子簽名平台，提供 REST API。可用 webhooks 接收通知。免費方案會添加浮水印於簽署文件，但不限信封與簽名數量。
  * [Web3Forms](https://web3forms.com) - 靜態及 JAMStack 網站聯絡表單，無需後端程式碼。免費方案支援無限表單、無限網域及每月 250 答覆。
* [WebAsk](https://webask.io) - 調查與表單建置工具。免費方案每個帳號可建立三個調查，每月可獲得 100 則回應，每個調查可有十個元素。
* [Wufoo](https://www.wufoo.com/) - 可快速在網站上使用的表單。免費方案每月限收 100 份提交。
* [formpost.app](https://formpost.app) - 免費、無限次數的表單轉電子郵件服務。可免費設置自訂重定向、自動回應、Webhooks 等等。
* [Formester.com](https://formester.com) - 可在你網站上分享及嵌入獨特風格的表單—建立的表單數量與功能皆無限制。每月可免費獲得最多 100 份提交。
* [SimplePDF.eu](https://simplepdf.eu/embed) - 在你網站上嵌入 PDF 編輯器，將任何 PDF 轉成可填寫的表單。免費方案允許無限 PDF，每份 PDF 可提交三次。
* [forms.app](https://forms.app/) — 線上表單建立工具，具備條件邏輯、自動計分器及 AI 等強大功能。免費方案可收集最多 100 份回應，可將表單嵌入網站或透過連結使用。
* [Qualli](https://usequalli.com) - 針對行動裝置設計的應用內調查。利用 Qualli AI 撰寫最佳問題。免費方案可試用，支援最多 500 MAU，建立無限表單與觸發事件。
* [Sprig](https://sprig.com/) - 每月 1 份產品內調查或帶重播的調查，配備 GPT 驅動的 AI 分析。
* [feedback.fish](https://feedback.fish/) - 免費方案可收集 25 份回饋。易於整合，並提供 React 與 Vue 元件。
* [Vidhook](https://vidhook.io/) - 使用高回應率的愉悅調查收集回饋。免費方案包含 1 份啟用中的調查，每份調查 25 份回應及可自訂範本。

**[⬆️ 返回頂部](#table-of-contents)**

## 生成式 AI

* [Zenable](https://zenable.io) - 透過以「政策即程式碼」打造的防護欄，立即自動修正 Cursor、Windsurf、Copilot 等工具的輸出，符合企業品質與合規標準。免費層每日包含 100 次 MCP 伺服器工具呼叫與 25 次自動化拉取請求審查（透過 GitHub App）。
* [Keywords AI](https://keywordsai.co) - 最佳 LLM 監控平台。以單一格式、2 行程式碼調用 200+ LLM。每月 10,000 次免費請求，平台功能全免費！
* [Portkey](https://portkey.ai/) - 生成式 AI 應用控制面板，具備可觀察性套件及 AI 閘道。每月可免費傳送及紀錄最多 10,000 筆請求。
* [Braintrust](https://www.braintrustdata.com/) - Gen AI 的評測、提示測試區、資料管理。免費方案每週提供最多 1,000 行私人評測資料。
* [Findr](https://www.usefindr.com/) - 通用搜尋，可一次搜尋所有應用。搜尋助理可運用你的資訊回答問題。免費方案提供無限整合搜尋及每日 5 次協同助理查詢。
* [ReportGPT](https://ReportGPT.app) - AI 驅動的寫作助理。只要自備 API 金鑰，整個平台即可免費使用。
* [Clair](https://askclair.ai/) - 臨床 AI 參考工具。學生可免費存取專業工具組，包括開放搜尋、臨床摘要、用藥審查、藥物交互、ICD-10 編碼及管理。此外也提供專業工具組免費試用。
* [Langtrace](https://langtrace.ai) - 讓開發者能追蹤、評估、管理提示與資料集，並偵錯 LLM 應用效能問題。為任何 LLM 建立開放遙測標準追蹤，方便觀察並支援任意觀察客戶端。免費方案每月 5 萬筆追蹤。
* [LangWatch](https://langwatch.ai) - LLMOps 平台，協助 AI 團隊衡量、監控並最佳化 LLM 應用的可靠性、成本效益與效能。強大的 DSPy 組件使工程師與非技術團隊能無縫協作，微調並產品化 GenAI 產品。免費方案含所有平台功能、每月 1,000 筆追蹤及 1 個 DSPy 工作流程最佳化器。 [#opensource](https://github.com/langwatch/langwatch)
* [Comet Opik](https://www.comet.com/site/products/opik/) - 在開發與生產生命週期中評估、測試、發布 LLM 應用。 [#opensource](https://github.com/comet-ml/opik/)
* [Langfuse](https://langfuse.com/) - 開源 LLM 工程平台，協助團隊協作除錯、分析並迭代 LLM 應用。永久免費方案每月包含 5 萬筆觀察紀錄及所有平台功能。 [#opensource](https://github.com/langfuse/langfuse)
* [Pollinations.AI](https://pollinations.ai/) - 易用、免費的圖像生成 AI，提供免費 API。無須註冊或 API 金鑰，並有多種網站或工作流程整合選項。 [#opensource](https://github.com/pollinations/pollinations)
* [Othor AI](https://othor.ai/) - 原生 AI、快速、簡單且安全的 Tableau、Power BI、Looker 等熱門商業智慧解決方案替代品。Othor 運用大型語言模型（LLM），數分鐘內交付自訂商業智慧解決方案。免費永久方案提供一個工作區、一位用戶、五個資料源連線，分析不限次數。 [#opensource](https://github.com/othorai/othor.ai)
* [OpenRouter](https://openrouter.ai/models?q=free) - 提供多種免費 AI 模型，包括 DeepSeek R1、V3、Llama 及 Moonshot AI。這些模型擅長自然語言處理，適用於多元開發需求。注意這些模型雖然免費，但有速率限制。此外，OpenRouter 也提供付費模型以因應更高階需求，如 Claude、OpenAI、Grok、Gemini 和 Nova。

**[⬆️ 返回頂部](#table-of-contents)**

## CDN 與防護

* [bootstrapcdn.com](https://www.bootstrapcdn.com/) — 提供 bootstrap、bootswatch 及 fontawesome.io 的 CDN
* [cdnjs.com](https://cdnjs.com/) — 簡單、快速、可靠。極致內容傳遞服務。cdnjs 是免費、開源的 CDN 服務，由 Cloudflare 支援，全球 11% 以上網站信賴。
* [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries 為最受歡迎的開源 JavaScript 函式庫提供內容分發網路
* [Stellate](https://stellate.co/) - Stellate 是你的 GraphQL API 的極速、可靠 CDN，免費提供兩個服務。
* [jsdelivr.com](https://www.jsdelivr.com/) — 免費、快速且可靠的開源 CDN。支援 npm、GitHub、WordPress、Deno 等。
* [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Microsoft Ajax CDN 提供熱門第三方 JavaScript 函式庫（如 jQuery），讓你輕鬆加入 Web 應用
* [ovh.ie](https://www.ovh.ie/ssl-gateway/) — 免費 DDoS 防護與 SSL 憑證
* [Skypack](https://www.skypack.dev/) — 100% 原生 ES Module JavaScript CDN。每個網域每月免費 100 萬請求。
* [raw.githack.com](https://raw.githack.com/) — 現代化的 **rawgit.com** 替代品，透過 Cloudflare 主機檔案
* [section.io](https://www.section.io/) — 輕鬆啟動並管理完整 Varnish Cache 解決方案。據稱一個網站可永久免費
* [statically.io](https://statically.io/) — 支援 Git 倉庫（GitHub、GitLab、Bitbucket）、WordPress 相關資產及圖片的 CDN
* [toranproxy.com](https://toranproxy.com/) — Packagist 與 GitHub 的代理。保證 CD 不失敗。個人用途免費，一名開發者，無支援
* [UNPKG](https://unpkg.com/) — npm 上所有內容的 CDN
* [weserv](https://images.weserv.nl/) — 圖片快取與即時縮放服務。全球快取，動態處理圖片。
* [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — 免費 DDoS 防護
* [Gcore](https://gcorelabs.com/) 全球內容傳遞網路，每月免費 1 TB 流量與 100 萬請求，並提供免費 DNS 主機
* [CacheFly](https://portal.cachefly.com/signup/free2023) - 每月最多 5 TB 免費 CDN 流量、19 個核心 PoP、1 個網域及通用 SSL。

**[⬆️ 返回頂部](#table-of-contents)**

## PaaS

* [anvil.works](https://anvil.works) - 只需 Python 即可開發 Web 應用。免費層不限應用數，每個請求 30 秒逾時。
* [appwrite](https://appwrite.io) - 無限專案、不會自動暫停專案（支援 websockets）與認證服務。免費層每個專案有 1 個資料庫、3 個儲存桶、5 個函式。
* [configure.it](https://www.configure.it/) — 行動應用開發平台，兩個專案免費，功能有限但無資源限制
* [codenameone.com](https://www.codenameone.com/) — 為 Java/Kotlin 開發者設計的開源跨平台行動應用開發工具鏈。可商用，專案數不限
* [deco.cx](https://www.deco.cx/en/dev) - 原生 Edge 前端平台，從 TypeScript 程式碼自動生成視覺化 CMS。內建 A/B 測試、內容分眾、即時分析。適合內容量大及企業級電商網站。免費提供每月 5 千瀏覽量或開源/個人專案。
* [Deno Deploy](https://deno.com/deploy) - 在全球邊緣運行 JavaScript、TypeScript 及 WebAssembly 的分散式系統。免費層每日 100,000 次請求、每月 100 GiB 資料傳輸。
* [domcloud.co](https://domcloud.co) – Linux 主機服務，支援與 GitHub、SSH、MariaDB/Postgres 資料庫的 CI/CD。免費版有 1GB 儲存與 1GB 網路/月限制，僅限免費網域。
* [encore.dev](https://encore.dev/) — 後端框架，利用靜態分析自動提供基礎設施、無樣板程式碼等。包含免費雲端託管，適合玩票專案。
* [flightcontrol.dev](https://flightcontrol.dev/) - 以 Git push 流程部署網頁服務、資料庫等至你自己的 AWS 帳號。個人 GitHub 倉庫 1 名開發者可用免費層。AWS 費用由 AWS 直接計費，可用 AWS 點數與免費層。
* [gigalixir.com](https://gigalixir.com/) - Gigalixir 提供一個永不休眠的免費實例，並有免費層 PostgreSQL 資料庫（限 2 連線、10,000 行、無備份），適用於 Elixir/Phoenix 應用。
* [Glitch](https://glitch.com/) — 提供免費公開託管、程式碼分享與即時協作功能。免費方案每月限 1000 小時。
* [leapcell](https://leapcell.io/) - Leapcell 為分散式應用平台，提供所有支持快速成長所需功能。免費方案包含 10 萬次服務調用、1 萬次非同步任務及 10 萬次 Redis 指令。
* [pipedream.com](https://pipedream.com) - 為開發者打造的整合平台。根據任意觸發器開發任何工作流。工作流皆為可執行程式碼，[免費](https://docs.pipedream.com/pricing/)。無需管理伺服器或雲端資源。
* [pythonanywhere.com](https://www.pythonanywhere.com/) — 雲端 Python 應用託管。初學者帳號免費，1 個 Python 網頁應用，網址為 your-username.pythonanywhere.com，512MB 私人檔案儲存，一個 MySQL 資料庫
* [ampt.dev](https://getampt.com/) - Ampt 讓團隊能在 AWS 上建置、部署並擴展 JavaScript 應用，無需複雜設定或基礎設施管理。免費預覽方案每小時 500 次、每日 2,500 次、每月 50,000 次調用。自訂網域僅限付費方案。
* [Koyeb](https://www.koyeb.com) - Koyeb 是開發者友善的無伺服器平台，全球部署應用。無縫運行 Docker 容器、Web 應用和 API，支援 Git 部署、原生自動擴展、全球邊緣網路、內建服務網格與發現。免費實例可部署於德國法蘭克福或美國華盛頓特區。免費託管 Postgres 資料庫（僅在法蘭克福、華盛頓與新加坡）。512MB 記憶體、2GB 儲存、0.1 CPU。
* [Napkin](https://www.napkin.io/) - FaaS 平台，500Mb 記憶體，預設逾時 15 秒，每月 5,000 次免費 API 呼叫，每秒限 5 次。
* [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy 託管。Meteor 專屬的 PaaS，包含免費 MongoDB 共用託管與自動 SSL。
* [Northflank](https://northflank.com) — 以強大 UI、API 及 CLI 建置並部署微服務、工作與託管資料庫。可從版本控制或外部 Docker Registry 無縫擴展容器。免費層含兩個服務、兩個排程任務及一個資料庫。
* [YepCode](https://yepcode.io) - 全方位平台，在無伺服器環境連接 API 與服務。兼具 NoCode 敏捷性與程式語言強大能力。免費層包含 [1,000 yeps](https://yepcode.io/pricing/)。
* [WunderGraph](https://cloud.wundergraph.com) - 開源平台，快速構建、部署、管理現代 API。內建 CI/CD、GitHub 整合、自動 HTTPS。免費方案含 3 個專案、每月 1GB 外送流量、300 分鐘建置時間。[free plan](https://wundergraph.com/pricing)
* [Zeabur](https://zeabur.com) - 一鍵部署服務。免費提供三個服務及每月 5 美元免費點數。
* [mogenius](https://mogenius.com) - 容易在 Kubernetes 上建置、部署、運行服務。免費層支援將本地 Kubernetes 與 mogenius 連接，讓個人開發者在本機建立類生產測試環境。
* [genezio](https://genezio.com/) - 無伺服器函式提供商，免費每月 100 萬次函式調用、100GB 頻寬、10 個排程任務，僅限非商業或學術用途。

**[⬆️ 返回頂部](#table-of-contents)**

## BaaS

* [Activepieces](https://www.activepieces.com) - 構建自動化流程，連接多個應用於你的後端。例如，當你的應用觸發事件時自動發送 Slack 訊息或新增 Google 試算表列。每月免費 5,000 項任務。
* [back4app.com](https://www.back4app.com) - Back4App 基於 Parse 平台，易用、彈性且可擴展的後端。
* [backendless.com](https://backendless.com/) — 行動與網頁 BaaS，免費含 1GB 檔案儲存、每月 5 萬次推播、表格內 1,000 筆資料。
* [bismuth.cloud](https://www.bismuth.cloud/) — 我們的 AI 將在雲端函式運行時與託管儲存自動產生你的 Python API，支援線上編輯器或本地工具免費構建與託管。
* [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — BMC 開發者計畫提供文件與資源，助你為企業建構與部署數位創新。可存取完整個人沙盒，包括平台、SDK 及元件庫，用於建構與調整應用。
* [connectycube.com](https://connectycube.com) - 無限聊天訊息、P2P 語音與視訊通話、檔案附件與推播通知。應用最多 1,000 名用戶免費。
* [convex.dev](https://convex.dev/) - 反應式 BaaS，托管你的資料（含關聯文件和可序列化 ACID 交易）、無伺服器函式、WebSockets 實時同步。小型專案免費：最多 100 萬筆資料、每月 500 萬次函式調用。
* [darklang.com](https://darklang.com/) - 託管語言、編輯器與基礎設施合一。Beta 期間可用，Beta 結束後將有大方免費層。
* [Firebase](https://firebase.com) — Firebase 協助你建構並運行成功應用。免費 Spark 方案提供認證、託管、Firebase ML、即時資料庫、雲端儲存、測試實驗室。A/B 測試、分析、應用分發、應用索引、雲端訊息（FCM）、Crashlytics、動態連結、應用內訊息、效能監控、預測與遠端設定永遠免費。
* [Flutter Flow](https://flutterflow.io) — 無需寫一行程式碼，即可建構 Flutter 應用 UI。也支援 Firebase 整合。免費方案可完整使用 UI Builder 及免費範本。
* [getstream.io](https://getstream.io/) — 幾小時內建構可擴展的應用內聊天、訊息、影音、訊息流，免去數週開發。
* [hasura.io](https://hasura.io/) — Hasura 可延伸你現有資料庫並提供即時 GraphQL API，適用於 Web、行動與資料整合工作負載。每月 1GB 資料流量免費。
* [nhost.io](https://nhost.io) - Web 與行動應用的無伺服器後端。免費方案包含 PostgreSQL、GraphQL（Hasura）、認證、儲存與無伺服器函式。
* [onesignal.com](https://onesignal.com/) — 無限免費推播通知。每月 10,000 封電子郵件發送，無限聯絡人與自動暖機。
* [paraio.com](https://paraio.com) — 彈性認證、全文搜尋與快取的後端服務 API。免費 1 個應用、1GB 應用資料。
  * [pubnub.com](https://www.pubnub.com/) — 免費推播通知服務，每月最多 1,000,000 則訊息及 100 個每日活躍裝置
  * [pushbots.com](https://pushbots.com/) — 推播通知服務。每月最多 150 萬次推播免費
  * [pushcrew.com](https://pushcrew.com/) — 推播通知服務。最多 2,000 位訂閱者可享無限次推播
  * [pusher.com](https://pusher.com/beams) — 免費，無限推播通知，限每月 2,000 名活躍用戶。單一 API 支援 iOS 與 Android 裝置。
  * [quickblox.com](https://quickblox.com/) — 提供即時通訊、視訊、語音通話及推播通知的通訊後端
  * [restspace.io](https://restspace.io/) - 配置伺服器以提供身份驗證、數據、檔案、電子郵件 API、模板等服務，然後組合成流程管線並轉換數據。
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — 使用拖放工具快速構建應用程式。通過點擊自訂您的數據模型。進一步使用 Apex 程式碼。利用強大 API 整合任何服務。具備企業級安全保障。可用點擊或主流前端框架自訂 UI。免費開發者計劃可存取完整 Lightning 平台。
  * [simperium.com](https://simperium.com/) — 多平台資料即時自動同步，結構化資料無限傳送與儲存，最多 2,500 名用戶/月
  * [Supabase](https://supabase.com) — 開源 Firebase 替代方案建構後端。免費方案包含認證、即時資料庫及物件儲存。
  * [tyk.io](https://tyk.io/) — 提供 API 管理、身份驗證、配額、監控及分析。免費雲端服務
  * [zapier.com](https://zapier.com/) — 連接常用應用程式以自動化任務。每 15 分鐘五條 zap，每月 100 個任務
  * [IFTTT](https://ifttt.com) — 自動化常用應用及裝置。免費可用 2 個 Applet
  * [Integrately](https://integrately.com) — 一鍵自動化繁瑣任務。免費 100 個任務，15 分鐘更新頻率，5 個啟用自動化，支援 webhook。
  * [LeanCloud](https://leancloud.app/) — 行動後端。1GB 資料儲存、256MB 實例、每日 3,000 次 API 請求及每日 10,000 次推播免費。（API 與 Parse Platform 類似）
  * [Claw.cloud](https://run.claw.cloud) - PaaS 平台，提供每月 $5 免費額度，適用於註冊超過 180 天的 GitHub 用戶。適合託管應用程式、資料庫等。（[免費額度註冊連結](https://ap-southeast-1.run.claw.cloud/signin)）


**[⬆️ 返回頂部](#table-of-contents)**

## 低程式碼平台

  * [appsmith](https://www.appsmith.com/) — 低程式碼專案，可用於構建管理後台、內部工具與儀表板。整合超過 15 種資料庫及任何 API。
  * [Basedash](https://www.basedash.com) — 低程式碼平台，可用於構建內部管理後台及儀表板。支援 SQL 資料庫和 REST API。
  * [BudiBase](https://budibase.com/) — Budibase 為開源低程式碼平台，幾分鐘即可建立內部應用。支援 PostgreSQL、MySQL、MSSQL、MongoDB、Rest API、Docker、K8s
  * [Clappia](https://www.clappia.com) — 低程式碼平台，專為建立企業流程應用設計，支援自訂行動及網頁應用。具備拖放介面、離線支援、即時位置追蹤及第三方服務整合等功能
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ 為低程式碼平台，協助工程團隊與產品經理快速建立內部工具、自訂使用者流程、數位體驗、自動化、自訂管理後台與營運應用，速度提升 10 倍。
  * [lil'bots](https://www.lilbots.io/) - 在線撰寫與執行腳本，利用內建免費 API（如 OpenAI、Anthropic、Firecrawl 等）。適合建立 AI agent／內部工具並與團隊分享。免費方案包含完整 API 使用權、AI 程式助手及每月 10,000 次執行額度。
  * [Mendix](https://www.mendix.com/) — 企業快速應用開發，提供無限可存取沙盒環境、總用戶不限，每個應用 0.5GB 儲存空間與 1GB RAM。免費方案亦可使用 Studio 與 Studio Pro IDE。
  * [outsystems.com](https://www.outsystems.com/) — 企業級網站開發 PaaS，支援自建或雲端，免費「個人環境」可無限程式碼及 1GB 資料庫
  * [ReTool](https://retool.com/) — 低程式碼內部應用開發平台。Retool 高度可自訂。只要用 JavaScript 與 API 能實現的功能，都能在 Retool 製作。免費方案每月最多 5 名用戶，無限應用與 API 連線。
  * [Superblocks](https://superblocks.com/) — 面向開發者和半技術團隊的開放企業應用平台。可用 AI 生成、視覺化編輯並擴充程式。集中治理，支援整合、認證、權限與稽核日誌。
  * [ToolJet](https://www.tooljet.com/) — 可擴充的低程式碼框架，用於構建企業應用。可連接資料庫、雲端儲存、GraphQL、API 端點、Airtable 等，並用拖放建構器製作應用。
  * [UI Bakery](https://uibakery.io) — 低程式碼平台，能快速建立自訂網頁應用。支援拖放 UI 建構，並能高度自訂（支援 JavaScript、Python、SQL）。提供雲端及自架版。免費版最多 5 名用戶。
  * [manubes](https://www.manubes.com) - 專注於工業生產管理的強大無程式碼雲端平台。免費提供 1 位用戶，每月 100 萬次工作流程活動（[也有德文版](https://www.manubes.de)）。

**[⬆️ 返回頂部](#table-of-contents)**

## 網頁託管

  * [Alwaysdata](https://www.alwaysdata.com/) — 100 MB 免費網頁空間，支援 MySQL、PostgreSQL、CouchDB、MongoDB、PHP、Python、Ruby、Node.js、Elixir、Java、Deno、自訂網頁伺服器，支援 FTP、WebDAV 與 SSH；含信箱、郵件清單及應用安裝器。
  * [Awardspace.com](https://www.awardspace.com) — 免費網頁空間 + 免費短網址，支援 PHP、MySQL、應用安裝器、郵件發送且無廣告。
  * [Bohr](https://bohr.io) — 非商業專案免費 + 開發者優先的部署與開發平台，簡化基礎設施並加速設置。
  * [Bubble](https://bubble.io/) — 視覺化程式設計，無需程式碼即可建立網頁與行動應用，免費方案附帶 Bubble 品牌。
  * [dAppling Network](https://www.dappling.network/) - 為 Web3 前端提供去中心化網頁託管平台，著重於提高運行時間與安全性，並為用戶提供額外存取點。
  * [DigitalOcean](https://www.digitalocean.com/pricing) - App Platform Starter 方案可免費建立並部署 3 個靜態網站。
  * [Drive To Web](https://drv.tw) — 直接從 Google Drive & OneDrive 託管網站。僅支援靜態站點。永久免費。每個 Google/Microsoft 帳戶限一站。
  * [Fenix Web Server](https://preview.fenixwebserver.com) - 開發者桌面應用，可在本地託管並即時對外分享網站。可透過美觀 UI、API 或 CLI 自由操作。
  * [Fern](https://buildwithfern.com) - 免費方案可建立並託管以 Markdown 為基礎的文件網站。可自動從 API 定義檔案生成 API 參考。網站託管於 _yoursite_.docs.buildwithfern.com。
  * [Free Hosting](https://freehostingnoads.net/) — 免費託管，支援 PHP 5、Perl、CGI、MySQL、FTP、檔案管理、POP 電子郵件、免費子網域、免費域名託管、DNS 區域編輯器、網站統計、免費線上支援及多項其他功能。
  * [Freehostia](https://www.freehostia.com) — FreeHostia 提供免費託管服務，包含業界最佳控制面板及 50 多個免費應用一鍵安裝。即時設置，無強制廣告。
  * [HelioHost](https://heliohost.org) — 非營利免費網頁空間，含 Plesk 控制面板、PHP、Node.js、Python、Django、Flask、.NET、Perl、CGI、MySQL、PostgreSQL、SQLite、IMAP/POP3/SMTP 電郵、無限頻寬、免費子網域、1000 MB 儲存空間，可升級。
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — 免費部署最多 100 個靜態網站，支援自訂網域、SSL、每月 100 GB 頻寬、超過 260 個 Cloudflare CDN 節點。
  * [Lecturify](https://www.lecturify.net/index.en.html) - 網頁託管，提供 SFTP 上傳下載，支援 PHP。
  * [Neocities](https://neocities.org) — 靜態網站，1 GB 免費儲存，200 GB 頻寬。
  * [Netlify](https://www.netlify.com/) — 構建、部署並託管靜態網站/應用，免費支援 100 GB 資料與每月 100 GB 頻寬。
  * [pantheon.io](https://pantheon.io/) — Drupal 與 WordPress 託管，支援自動化 DevOps 及可擴展架構。開發者與代理商免費。無自訂網域。
  * [readthedocs.org](https://readthedocs.org/) — 免費文件託管，支援版本管理、PDF 產生等功能
  * [render.com](https://render.com) — 統一雲平台，可建置與運行應用及網站，支援免費 SSL、全球 CDN、私有網路、Git 自動部署，網站、資料庫及靜態網頁皆有免費方案。
  * [SourceForge](https://sourceforge.net/) — 免費尋找、建立、發布開源軟體
  * [surge.sh](https://surge.sh/) — 前端開發者靜態網頁發佈平台。不限站點數，支援自訂網域
  * [telegra.ph](https://telegra.ph/) 使用 Quill 輕鬆建立網頁
  * [tilda.cc](https://tilda.cc/) — 一個網站，50 頁，50 MB 儲存，僅含 170+ 預設區塊中的主要區塊，不支援字型、favicon 及自訂網域
  * [Vercel](https://vercel.com/) — 建置、部署與託管網頁應用，免費 SSL、全球 CDN，每次 `git push` 都有專屬預覽網址。適合 Next.js 及其他靜態網站生成器。
  * [Versoly](https://versoly.com/) — 以 SaaS 為主的網站建置器 — 不限網站數，70+ 模組，5 套範本，自訂 CSS、favicon、SEO 及表單。不支援自訂網域。
  * [Qoddi](https://qoddi.com) - 類似 Heroku 的 PaaS 服務，注重開發者體驗與全方位功能。免費方案支援靜態資產、測試及開發應用。
  * [FreeFlarum](https://freeflarum.com/) - 社群驅動的免費 Flarum 託管，最多支援 250 位用戶（捐款可移除頁尾浮水印）。
  * [MDB GO](https://mdbgo.com/) - 免費託管一個專案，容器保留兩週，專案每個 500 MB RAM，SFTP - 1GB 磁碟空間。
  * [Patr Cloud](https://patr.cloud/) — 易用雲端平台，於付費服務外提供三個靜態網站免費託管。
  * [Serv00.com](https://serv00.com/) — 3GB 免費網頁空間，每日備份（7 天）。支援 Crontab、SSH、版本庫（GIT、SVN、Mercurial）、MySQL、PostgreSQL、MongoDB、PHP、Node.js、Python、Ruby、Java、Perl、TCL/TK、Lua、Erlang、Rust、Pascal、C、C++、D、R 等多種語言。
  - [Sevalla](https://sevalla.com/) - 專為簡化應用、資料庫與靜態網站部署管理而設計的託管平台 — 1GB 網站上限，100GB 免費頻寬，600 免費構建分鐘，每帳號 100 個站點。

**[⬆️ 返回頂部](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - 免費公用 DNS 解析器，由 Cloudflare 提供，快速且安全（加密 DNS 查詢）。可用於繞過 ISP DNS 封鎖、防止 DNS 查詢監控、[封鎖成人及惡意內容](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families)。也可[透過 API 使用](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests)。注意：僅為 DNS 解析器，非 DNS 託管。
  * [1984.is](https://www.1984.is/product/freedns/) — 免費 DNS 服務，支援 API 及多項其他功能。
  * [cloudns.net](https://www.cloudns.net/) — 免費 DNS 託管，支援 1 個網域及 50 筆紀錄
  * [deSEC](https://desec.io) - 免費 DNS 託管，支援 API，著重安全。採用開源軟體，由 [SSE](https://www.securesystems.de/) 支持。
  * [dns.he.net](https://dns.he.net/) — 免費 DNS 託管，支援動態 DNS
  * [Zonomi](https://zonomi.com/) — 免費 DNS 託管，立即生效。免費方案：1 個 DNS 區（網域），最多 10 筆紀錄。
  * [dnspod.com](https://www.dnspod.com/) — 免費 DNS 託管。
  * [duckdns.org](https://www.duckdns.org/) — 免費動態 DNS，免費方案最多 5 個網域。提供各種設置教學。
  * [Dynv6.com](https://dynv6.com/) — 免費動態 DNS，支援 [API](https://dynv6.com/docs/apis) 及多種紀錄類型（如 CNAME、MX、SPF、SRV、TXT 等）。
  * [freedns.afraid.org](https://freedns.afraid.org/) — 免費 DNS 託管。亦提供大量公用 [用戶貢獻網域](https://freedns.afraid.org/domain/registry/) 的免費子網域。註冊後可於「Subdomains」選單取得免費子網域。
  * [luadns.com](https://www.luadns.com/) — 免費 DNS 託管，最多三個網域，所有功能皆可用，僅有限制
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — 免費 DNS，無網域數量限制
  * [nextdns.io](https://nextdns.io) - 基於 DNS 的防火牆，每月 30 萬次免費查詢
  * [noip.at](https://noip.at/) — 免費動態 DNS，無需註冊、不追蹤、不記錄、不廣告。無域名數量限制。
  * [noip](https://www.noip.com/) — 動態 DNS 服務，最多可免費建立 3 個主機名稱，每 30 天需確認一次
  * [sslip.io](https://sslip.io/) — 免費 DNS 服務，查詢嵌入 IP 位址的主機名稱時，直接返回該 IP。
  * [zilore.com](https://zilore.com/en/dns) — 免費 DNS 託管，最多 5 個網域。
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — 免費 DNS 託管，支援動態 DNS。
  * [zonewatcher.com](https://zonewatcher.com) — 自動備份及 DNS 變更監控。一個網域免費
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – 華為提供免費 DNS 託管
  * [Hetzner](https://www.hetzner.com/dns-console) – Hetzner 免費 DNS 託管，支援 API。
  * [Glauca](https://docs.glauca.digital/hexdns/) – 免費 DNS 託管，最多三個網域，支援 DNSSEC
  * [VolaryDDNS](https://volaryddns.net) - 免費高效能動態 DNS，無訂閱與廣告
**[⬆️ 回到頂部](#table-of-contents)**

## 網域

  * [pp.ua](https://nic.ua/) — 免費 pp.ua 子域名。
  * [us.kg](https://nic.us.kg/) - 免費 us.kg 子域名。

**[⬆️ 回到頂部](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — 相容於 AWS S3 - API、介面操作、CLI 及其他上傳方式，能夠從 IPFS 和 Arweave 網路安全、方便、高效地上傳與儲存檔案。註冊用戶可免費獲得 6 GB IPFS 儲存空間與 300MB Arweave 儲存空間。任何小於 150 KB 的 Arweave 檔案上傳皆免費。
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 雲端儲存。提供免費 10 GB（類似 Amazon S3 的物件儲存）無時間限制
  * [filebase.com](https://filebase.com/) - 以區塊鏈為基礎的 S3 相容物件儲存。免費提供 5 GB 儲存空間，無時間限制。
  * [Tebi](https://tebi.io/) - S3 相容物件儲存。免費 25 GB 儲存空間和 250GB 出站流量。
  * [Idrive e2](https://www.idrive.com/e2/) - S3 相容物件儲存。每月免費 10 GB 儲存空間和 10 GB 下載頻寬。
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - S3 相容物件儲存。每月免費 15 GB 儲存空間和 15 GB 下載流量。

**[⬆️ 回到頂部](#table-of-contents)**

## 託管資料服務

  * [Aiven](https://aiven.io/) - Aiven 在其開源數據平台上提供免費的 PostgreSQL、MySQL 和 Redis 方案。單節點、1 CPU、1GB RAM，PostgreSQL 與 MySQL 提供 5GB 儲存。可輕鬆遷移到更大的方案或跨雲平台。
  * [airtable.com](https://airtable.com/) — 外觀看起來像試算表，但實際上是關聯式資料庫，無限基礎，1,200 行/每基礎，1,000 次 API 請求/月
  * [Astra](https://www.datastax.com/products/datastax-astra/) — 雲原生 Cassandra 服務，提供 [80GB 免費方案](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — 易於使用的 JavaScript 無伺服器 API/後端與 NoSQL 資料庫服務，含函數、類 MongoDB 查詢、鍵/值查找、作業系統、即時消息、工作佇列、強大 CLI 和網頁式資料管理器。免費方案含 5GB 儲存和每分鐘 60 次 API 呼叫。含 2 位開發者。不需信用卡。
  * [CrateDB](https://crate.io/) - 分散式開源 SQL 資料庫，適合即時分析。[免費方案 CRFREE](https://crate.io/lp-crfree)：單一節點，2 CPU、2 GiB 記憶體、8 GiB 儲存。每個組織一個集群，無需付款方式。
  * [Upstash](https://upstash.com/) — 無伺服器 Redis，免費方案每日最高 10,000 次請求，256MB 資料庫上限，20 個同時連線
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - 提供永久免費層的全託管資料庫叢集，讓開發人員打造從 IoT 到 AI 的新世代應用
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — 免費層提供 512 MB
  * [redsmin.com](https://www.redsmin.com/) — Redis 線上即時監控與管理服務，免費監控 1 個 Redis 實例
  * [redislabs](https://redislabs.com/try-free/) - 免費 30MB Redis 實例
  * [MemCachier](https://www.memcachier.com/) — 託管型 Memcache 服務。最多 25MB、1 個 Proxy Server 及基本分析功能免費
  * [scalingo.com](https://scalingo.com/) — 主要為 PaaS，同時提供 128MB 至 192MB 的 MySQL、PostgreSQL 或 MongoDB 免費層
  * [SeaTable](https://seatable.io/) — 由 Seafile 團隊打造的彈性試算表型資料庫。無限表格，2,000 行，1 個月版本管理，最多 25 位團隊成員。
  * [skyvia.com](https://skyvia.com/) — 雲端數據平台，提供免費層，測試期間所有方案皆免費
  * [StackBy](https://stackby.com/) — 結合試算表彈性、資料庫效能與內建常用商業應用整合的工具。免費方案含無限用戶、10 個 stack、每 stack 2GB 附件。
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB 是開源、MySQL 相容、分散式 HTAP 關聯式資料庫。TiDB Serverless 每月免費 5GB row 儲存、5GB column 儲存、5,000 萬 Request Unit (RU)。
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso 提供 Edge Database 的 SQLite 開發體驗。永久免費入門方案，9 GB 總儲存，最多 500 個資料庫，最多 3 個地區，每月 10 億行讀取，本地支援 SQLite 開發。
  * [InfluxDB](https://www.influxdata.com/) — 時序型資料庫，免費提供每 5 分鐘 3MB 寫入、30MB 讀取、10,000 種序列
  * [restdb.io](https://restdb.io/) - 速度快且簡單的 NoSQL 雲端資料庫服務。內建 schema、關聯、自動 REST API（支持類 MongoDB 查詢）和多用戶管理介面。免費方案含 3 位用戶、2500 筆紀錄，每秒 1 次 API 請求。
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — 免費層每月提供 5,000 萬 RU 及 10 GiB 儲存空間（相當於價值 15 美元）。([什麼是 Request Units](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — 託管型原生圖形資料庫 / 分析平台，支援 Cypher 查詢語言和 REST API。圖形大小有限制（5 萬節點、17.5 萬關聯）。
  * [Neon](https://neon.tech/) — 託管型 PostgreSQL，總共 0.5 GB 儲存空間，1 專案，10 分支，無限資料庫，主分支永遠可用（5 分鐘後自動暫停），非主分支每月 20 小時活動時間（總計）。
  * [Prisma Postgres](https://prisma.io/postgres) - 超高速託管 Postgres，基於 unikernel 並運行於裸機，1GB 儲存空間、10 個資料庫，與 Prisma ORM 整合。
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — 託管型原生圖形資料庫，提供 GraphQL API。每日限 1 MB 資料傳輸。
  * [Tinybird](https://tinybird.co) - 託管型 ClickHouse，支援無連線 HTTP 資料導入，並可將 SQL 查詢發佈為 HTTP API。免費層無時間限制，含 10GB 儲存 + 每日 1000 次 API 請求。
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — 託管型原生圖形資料庫 / 分析平台，支援類 SQL 圖查詢語言和 REST API。免費方案含 2 vCPU、8GB 記憶體、50GB 儲存，閒置 1 小時後自動休眠。
  * [TerminusCMS](https://terminusdb.com/pricing) — TerminusDB 的託管免費服務，該資料庫以 Prolog 與 Rust 開發，支援文件及圖形資料。開發免費，企業部署與支援需付費。
  * [filess.io](https://filess.io) - filess.io 平台可免費建立兩個資料庫，每個資料庫上限 10 MB，支援 MySQL、MariaDB、MongoDB 和 PostgreSQL。
  * [xata.io](https://xata.io) - Xata 是一款無伺服器資料庫，內建強大搜尋與分析。單一 API，支援多種型別安全用戶端函式庫，優化開發流程。永久免費層適合興趣開發者，包含三個 Xata 單位，詳細單位定義請參見官網。
  * [8base.com](https://www.8base.com/) - 8base 是專為 JavaScript 開發者打造的全端低代碼平台，基於 MySQL 和 GraphQL 及無伺服器後端服務。可快速用 UI 應用程式建構器建立 Web 應用並輕鬆擴展。免費層含 2,500 行、500 儲存、1Gb/h 無伺服器運算、5 位客戶端應用用戶。
  * [Nile](https://www.thenile.dev/) — 為 B2B 應用打造的 Postgres 平台。無限資料庫，永不關機，1GB 總儲存空間，5,000 萬查詢權杖，自動擴展，無限向量嵌入



**[⬆️ 回到頂部](#table-of-contents)**

## 穿透、WebRTC、Web Socket 伺服器與其他路由服務

  * [Pinggy](https://pinggy.io) — 一行指令即可為本地端開啟公開網址，無需下載。HTTPS / TCP / TLS 隧道。免費方案隧道壽命 60 分鐘。
  * [conveyor.cloud](https://conveyor.cloud/) — Visual Studio 擴充套件，讓 IIS Express 可公開於區域網路或透過隧道取得公開網址。
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi 是託管型 VPN 服務，可安全擴展類 LAN 網路給分散團隊，免費方案允許無限網路，每網路最多 5 人
  * [Mirna Sockets](https://mirna.cloud/) - 免費 Socket as a Service 平台，部署 Web Socket 伺服器後會提供 wss:// URL，且可監控效能。
  * [localhost.run](https://localhost.run/) — 透過隧道將本地端伺服器公開為公開網址。
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — 透過隧道將本地端伺服器公開為公開網址。提供免費託管版本，並為 [開源專案](https://github.com/localtunnel/localtunnel)。
  * [ngrok.com](https://ngrok.com/) — 透過隧道將本地端伺服器公開為公開網址。
  * [cname.dev](https://cname.dev/) — 免費且安全的動態反向代理服務。
  * [serveo](https://serveo.net/) — 將本地端伺服器暴露到網際網路。無需安裝，無需註冊。免費子域名，無限制。
  * [Radmin VPN](https://www.radmin-vpn.com/) — 讓多台電腦透過 VPN 連接組成類 LAN 網路。不限連線數。（Hamachi 替代方案）
  * [segment.com](https://segment.com/) — 將事件轉換與路由至第三方服務的中樞。每月 100,000 次事件免費
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — 零配置 VPN，採用開源 WireGuard 協議。支援 MacOS、iOS、Windows、Linux、Android。個人用途免費方案支援 100 台裝置、3 位用戶。
  * [webhookrelay.com](https://webhookrelay.com) — 管理、除錯、分發及代理所有 webhook，支援公開或內部（如 localhost）目的地。亦可將私有網路內伺服器公開為 HTTP 端點（`https://yoursubdomain.webrelay.io <----> http://localhost:8080`）。
  * [Hookdeck](https://hookdeck.com/pricing) — 隨時隨地開發、測試、監控 webhook。每月 10 萬次請求及 10 萬次嘗試，保留三天。
  * [Xirsys](https://www.xirsys.com/pricing/) — 無限制 STUN 用量 + 每月 500 MB TURN 頻寬，頻寬有限制，單一地理區域。
  * [ZeroTier](https://www.zerotier.com) — FOSS 託管虛擬乙太網服務。免費方案支援 25 台客戶端的無限端對端加密網路。支援桌面/行動端，網頁介面可自訂路由規則和管理新節點。
  * [LocalXpose](https://localxpose.io) — 反向代理，讓本地伺服器公開於網際網路。免費方案隧道壽命 15 分鐘。
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - 透過隧道將本地服務公開到自訂公開網址並加強存取控制。每個叢集免費 5 個服務。
  * [Expose](https://expose.dev/) - 透過安全隧道公開本地網站。免費方案提供 EU 伺服器、隨機子域名、單用戶。
  * [btunnel](https://www.btunnel.in/) — 將 localhost 及本地 tcp 伺服器公開至網際網路。免費方案包含檔案伺服器、自訂 http 請求與回應標頭、基本驗證保護與 1 小時隧道超時。

**[⬆️ 回到頂部](#table-of-contents)**

## 問題追蹤與專案管理

  * [acunote.com](https://www.acunote.com/) — 免費專案管理與 SCRUM 軟體，最多 5 位團隊成員
  * [asana.com](https://asana.com/) — 私人專案免費，支援協作者
  * [Backlog](https://backlog.com) — 團隊專案所需一應俱全的單一平台。免費方案提供 1 個專案、10 位用戶、100MB 儲存空間。
  * [Basecamp](https://basecamp.com/personal) - 待辦清單、里程碑管理、論壇式訊息、檔案分享與時間追蹤。最多 3 個專案、20 位用戶、1GB 儲存空間。
  * [bitrix24.com](https://www.bitrix24.com/) — 企業內部網與專案管理工具。免費方案含 5GB 空間，無限用戶。
  * [cacoo.com](https://cacoo.com/) — 線上即時圖表：流程圖、UML、網路圖。免費最多 15 位用戶/圖、25 張圖紙
  * [Chpokify](https://chpokify.com/) — 基於團隊的 Planning Poker，節省衝刺估算時間。免費最多 5 位用戶、免費 Jira 整合、無限視訊通話、團隊與會議。
  * [clickup.com](https://clickup.com/) — 專案管理。免費，付費版有雲端儲存。提供行動 App 與 Git 整合。
  * [Clockify](https://clockify.me) - 工時追蹤與工時表應用，讓你跨專案追蹤工作時數。無限用戶，永久免費。
  * [Cloudcraft](https://cloudcraft.co/) — 透過 Cloudcraft 視覺設計器，幾分鐘內設計專業架構圖，針對 AWS 最佳化，元件可顯示即時數據。免費方案單人無限私人圖表。
  * [Codegiant](https://codegiant.io) — 專案管理含倉庫託管與 CI/CD。免費方案含無限倉庫、專案與文件，最多 5 位團隊成員。每月 500 CI/CD 分鐘。每月 30000 分鐘 Serverless Code Run，1GB 倉庫儲存。
  * [Confluence](https://www.atlassian.com/software/confluence) - Atlassian 的內容協作工具，幫助團隊高效協作與知識分享。最多 10 位用戶免費方案。
  * [contriber.com](https://www.contriber.com/) — 可自訂專案管理平台，免費入門方案，含五個工作區
* [Crosswork](https://crosswork.app/) - 多功能專案管理平台。免費方案可用於最多 3 個專案、無限用戶、1 GB 儲存空間。
  * [diagrams.net](https://app.diagrams.net/) — 在線圖表工具，圖表可本地儲存在 Google Drive、OneDrive 或 Dropbox。所有功能和儲存層級皆免費。
  * [freedcamp.com](https://freedcamp.com/) - 任務、討論、里程碑、時間追蹤、日曆、檔案與密碼管理器。免費方案支援無限專案、用戶及檔案儲存。
  * [easyretro.io](https://www.easyretro.io/) — 簡單直觀的衝刺回顧工具。免費方案包含三個公開看板，每個看板每月可有一份調查。
  * [GForge](https://gforge.com) — 適合複雜專案的專案管理與問題追蹤工具，支援本地部署與 SaaS。SaaS 免費方案前五名用戶免費，開源專案免費。
  * [gleek.io](https://www.gleek.io) — 免費的描述轉圖表工具，開發者可使用關鍵字快速建立非正式 UML 類別、物件或實體關聯圖。
  * [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - 比較兩個 GraphQL schema 差異，精確標註為破壞性、非破壞性或危險性。
  * [huboard.com](https://huboard.com/) — 即時專案管理，專為 GitHub 問題設計，開源專案免費。
  * [Hygger](https://hygger.io) — 專案管理平台。免費方案提供無限用戶、專案與看板，並有 100 MB 儲存空間。
  * [Instabug](https://instabug.com) — 行動應用程式的全面錯誤回報與應用內反饋 SDK。免費方案支援 1 個應用及 1 名成員。
  * [WishKit](https://wishkit.io) — 收集 iOS/macOS 應用內用戶回饋，並根據投票優先排序功能。免費方案支援 1 個應用。
  * [Ilograph](https://www.ilograph.com/) — 互動式圖表，讓使用者以多種視角與細節層次檢視基礎架構。圖表可用程式碼描述。免費方案支援無限私人圖表（最多 3 位觀看者）。
  * [Jira](https://www.atlassian.com/software/jira) — 進階軟體開發專案管理工具，廣泛應用於企業環境。免費方案最多支援 10 名用戶。
  * [kanbanflow.com](https://kanbanflow.com/) — 看板式專案管理，免費版及進階版（更多功能）。
  * [kanbantool.com](https://kanbantool.com/) — 看板式專案管理。免費方案有兩個看板、兩位用戶，不支援附件與檔案。
  * [kan.bn](https://kan.bn/) - 強大且靈活的看板應用，協助組織工作、追蹤進度並交付成果。免費方案支援 1 位用戶，無限看板、清單、卡片。
  * [Kitemaker.co](https://kitemaker.co) - 產品開發流程全階段協作，與 Slack、Discord、Figma、Github 整合。無限用戶、空間。免費方案最多 250 個工作項目。
  * [Kiter.app](https://www.kiter.app/) - 幫助任何人組織求職、追蹤面試、機會與人脈。強大網頁應用與 Chrome 擴展。完全免費。
  * [Kumu.io](https://kumu.io/) — 關係圖，支援動畫、裝飾、篩選、群集、試算表匯入等。免費層級允許無限公開專案，圖表大小無限制。學生可免費建立私人專案。如不想公開檔案，可用沙盒模式（上傳、編輯、下載、丟棄）。
  * [Linear](https://linear.app/) — 簡潔介面的問題追蹤工具。免費支援無限成員，單檔案上傳上限 10MB，最多 250 個問題（不含歸檔）。
  * [leiga.com](https://www.leiga.com/) — Leiga 是一款 SaaS 產品，利用 AI 自動管理專案，協助團隊專注並釋放潛力，確保專案按計劃推進。免費方案最多 10 位用戶、20 個自訂欄位、2GB 儲存空間、AI 錄影限制為 5 分鐘/影片，自動化執行 20 次/用戶/月。
  * [Lucidchart](https://www.lucidchart.com/) - 線上圖表工具，支援協作。免費方案可編輯 3 份文件、100 種專業模板與基本協作功能。
  * [MeisterTask](https://www.meistertask.com/) — 團隊線上任務管理。免費支援 3 個專案與無限專案成員。
  * [MeuScrum](https://www.meuscrum.com/en) - 免費線上 Scrum 工具，附看板功能
  * [nTask](https://www.ntaskmanager.com/) — 專案管理軟體，讓團隊協作、規劃、分析與日常任務管理。基本方案永遠免費，100 MB 儲存，最多五人/團隊。無限工作區、會議、指派、工時表、問題追蹤。
  * [Ora](https://ora.pm/) - 敏捷任務管理與團隊協作。免費支援 3 名用戶，單檔案上限 10 MB。
  * [pivotaltracker.com](https://www.pivotaltracker.com/) — 無限公開專案免費，私人專案兩個，最多三位活躍用戶（讀寫），無限被動用戶（唯讀）。
  * [plan.io](https://plan.io/) — 專案管理與版本庫託管等功能。免費支援 2 位用戶、10 位客戶、500MB 儲存。
  * [Plane](https://plane.so/) - 簡單、可擴充、開源的專案與產品管理工具。免費支援無限成員、單檔案上傳 5MB、1000 個問題。
  * [planitpoker.com](https://www.planitpoker.com/) — 免費線上規劃撲克（估算工具）
  * [point.poker](https://www.point.poker/) - 線上規劃撲克（共識式估算工具）。免費支援無限用戶、團隊、會議、回合與投票，無需註冊。
  * [ScrumFast](https://www.scrumfast.com) - 簡潔直觀的 Scrum 看板，最多五位用戶免費。
  * [Shake](https://www.shakebugs.com/) - 行動應用內錯誤回報與反饋工具。免費方案每個應用每月 10 則錯誤報告。
  * [Shortcut](https://shortcut.com/) - 專案管理平台。免費支援最多 10 位用戶。
  * [Tadum](https://tadum.app) - 專為定期會議設計的議程與會議記錄應用，免費支援 10 人團隊。
  * [taiga.io](https://taiga.io/) — 新創與敏捷開發者專案管理平台，開源專案免費。
  * [Tara AI](https://tara.ai/) — 簡單的衝刺管理服務。免費方案無限任務、衝刺與工作區，無用戶數限制。
  * [targetprocess.com](https://www.targetprocess.com/) — 可視化專案管理，涵蓋看板、Scrum 或其他流程。免費無限用戶、最多 1,000 筆資料實體 {[更多細節](https://www.targetprocess.com/pricing/)}
  * [taskade.com](https://www.taskade.com/) — 即時協作任務清單與團隊大綱。免費方案包含一個工作區、無限任務與專案、1GB 檔案儲存、1 週專案歷史、每次視訊會議最多 5 人。
  * [taskulu.com](https://taskulu.com/) — 角色型專案管理。免費支援 5 位用戶。可與 GitHub/Trello/Dropbox/Google Drive 整合。
  * [Teaminal](https://www.teaminal.com) - 遠端團隊的 Standup、回顧與衝刺規劃工具。免費支援 15 位用戶。
  * [teamwork.com](https://teamwork.com/) — 專案管理與團隊聊天。免費支援五位用戶、兩個專案。另有進階付費方案。
  * [teleretro.com](https://www.teleretro.com/) — 簡單有趣的回顧工具，內建破冰遊戲、GIF 與表情符號。免費方案包含三次回顧與無限成員。
  * [testlio.com](https://testlio.com/) — 問題追蹤、測試管理與測試平台。私人用途免費。
  * [terrastruct.com](https://terrastruct.com/) — 專為軟體架構設計的線上圖表工具。免費層級每張圖最多四層。
  * [todoist.com](https://todoist.com/) — 協作與個人任務管理。免費方案：5 個活躍專案、每專案 5 人、檔案上傳上限 5MB、3 個篩選器、1 週活動紀錄。
  * [trello.com](https://trello.com/) — 看板式專案管理。無限個人看板，10 個團隊看板。
  * [Tweek](https://tweek.so/) — 簡單的每週待辦行事曆與任務管理工具。
  * [ubertesters.com](https://ubertesters.com/) — 測試平台、整合與群眾測試人員，2 個專案，5 位成員。
  * [Wikifactory](https://wikifactory.com/) — 產品設計服務，支援專案、VCS、問題追蹤。免費方案支援無限專案與協作者，3GB 儲存空間。
  * [Yodiz](https://www.yodiz.com/) — 敏捷開發與問題追蹤，最多 3 位用戶免費，專案無上限。
  * [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — 免費託管的 YouTrack（InCloud），適用於 FOSS 與私人專案（三位用戶免費）。包含時間追蹤與敏捷看板。
  * [zenhub.com](https://www.zenhub.com) — 唯一內嵌於 GitHub 的專案管理解決方案。公共倉庫、開源與非營利組織免費。
  * [zenkit.com](https://zenkit.com) — 專案管理與協作工具。免費支援最多 5 位成員，5 GB 附件空間。
  * [Zube](https://zube.io) — 專案管理，免費方案支援 4 個專案、4 位用戶。可與 GitHub 整合。
  * [Toggl](https://toggl.com/) — 提供兩款免費生產力工具。[Toggl Track](https://toggl.com/track/)：時間管理與追蹤，免費方案適合自由工作者，支援無限追蹤記錄、專案、客戶、標籤、報表等。[Toggl Plan](https://toggl.com/plan/)：任務規劃，個人開發者免費，無限任務、里程碑與時間軸。
  * [Sflow](https://sflow.io) — sflow.io 是針對敏捷開發、行銷、銷售、客服等設計的專案管理工具，特別適合外包與跨組織協作。免費支援 3 個專案、5 位成員。
  * [Pulse.red](https://pulse.red) — 免費極簡時間追蹤與工時表應用。

**[⬆️ 回到頂部](#table-of-contents)**

## 儲存與媒體處理

  * [AndroidFileHost](https://androidfilehost.com/) - 免費檔案分享平台，無限速度、頻寬、檔案數、下載數等。主要面向 Android 開發相關檔案如 APK、ROM、修改檔等，但似乎也接受其他類型檔案。
  * [borgbase.com](https://www.borgbase.com/) — 簡單且安全的 Borg Backup 異地備份託管。免費 10 GB 備份空間及兩個儲存庫。
  * [icedrive.net](https://www.icedrive.net/) - 簡易雲端儲存服務。免費 10 GB 儲存空間。
  * [sync.com](https://www.sync.com/) - 端對端雲端儲存服務。免費 5 GB 儲存空間。
  * [pcloud.com](https://www.pcloud.com/) - 雲端儲存服務。免費最高 10 GB 儲存空間。
  * [sirv.com](https://sirv.com/) — 智慧型圖片 CDN，支援即時優化與調整圖片大小。免費層級含 500 MB 儲存空間、2 GB 頻寬。
  * [cloudimage.io](https://www.cloudimage.io/en/home) — 全方位圖片優化與 CDN 服務，全球 1500+ 節點。支援圖片縮放、壓縮、浮水印等功能，並有開源外掛。免費方案每月 25GB CDN 流量、25GB 快取儲存與無限轉換。
  * [cloudinary.com](https://cloudinary.com/) — 圖片上傳、強大處理、儲存與傳遞服務，支援多語言 SDK。免費層級含每月 25 點數（1 點等於 1000 次圖片轉換、1 GB 儲存或 1 GB CDN 流量）。
  * [embed.ly](https://embed.ly/) — 提供 API，可將媒體嵌入網頁、響應式圖片縮放、網頁元素擷取。免費用於每月 5,000 個 URL，15 請求/秒。
  * [filestack.com](https://www.filestack.com/) — 檔案選取、轉換與傳遞，免費支援 250 個檔案、500 次轉換、3 GB 頻寬。
  * [file.io](https://www.file.io) - 2 GB 檔案儲存。檔案下載一次後自動刪除。可用 REST API 操作，頻率限制為每分鐘 1 次請求。
  * [freetools.site](https://freetools.site/) — 免費線上工具，支援文件、圖片、音訊、影片等格式轉換與編輯。
  * [GoFile.io](https://gofile.io/) - 免費檔案分享與儲存平台，可透過網頁或 API 使用。無限檔案大小、頻寬、下載次數等。但檔案若 10 天無人下載即會自動刪除。
  * [gumlet.com](https://www.gumlet.com/) — 圖片與影片託管、處理與串流 CDN。免費方案每月支援影片 250 GB、圖片 30 GB。
  * [image-charts.com](https://www.image-charts.com/) — 無限圖片圖表產生（有浮水印）。
  * [Imgbot](https://github.com/marketplace/imgbot) — Imgbot 會自動優化圖片大小與品質，幫助減少檔案體積。開源專案免費。
  * [ImgBB](https://imgbb.com/) — ImgBB 是無限圖片託管服務。拖曳圖片即可上傳，單圖上限 32 MB。提供直接連結、BBCode、HTML 縮圖，上傳後可登入查看歷史紀錄。
  * [imgen](https://www.jitbit.com/imgen/) - 免費無限社群封面圖片產生 API，無浮水印。
  * [imgix](https://www.imgix.com/) - 圖片快取、管理與 CDN。免費方案包括 1000 張來源圖片、無限轉換、100 GB 頻寬。
  * [kraken.io](https://kraken.io/) — 網站圖片優化服務，免費方案單檔案上限 1 MB。
  * [kvstore.io](https://www.kvstore.io/) — 鍵值儲存服務。免費層級 100 個鍵、每鍵 1KB、每小時 100 次調用。
  * [npoint.io](https://www.npoint.io/) — JSON 儲存服務，支援協作式 Schema 編輯。
  * [nitropack.io](https://nitropack.io/) - 自動加速網站前端（快取、圖片及程式碼優化、CDN）。免費方案每月 5,000 次瀏覽。
  * [otixo.com](https://www.otixo.com/) — 加密、分享、複製、移動所有雲端儲存檔案於同一處。基本方案提供無限檔案傳輸，單檔上限 250 MB，最多 5 個加密檔案。
  * [packagecloud.io](https://packagecloud.io/) — 託管 YUM、APT、RubyGem 及 PyPI 套件庫。有限免費方案，開源專案可申請。
  * [getpantry.cloud](https://getpantry.cloud/) — 簡單 JSON 資料儲存 API，非常適合個人專案、黑客松、行動應用！
  * [Pinata IPFS](https://pinata.cloud) — 最簡易的 IPFS 檔案上傳與管理服務，介面友善並有 API。免費 1 GB 儲存空間。
  * [placekitten.com](https://placekitten.com/) — 快速取得貓咪圖片作為佔位圖。
  * [plot.ly](https://plot.ly/) — 資料繪圖與分享。免費層級支援無限公開檔案及十份私人檔案。
  * [podio.com](https://podio.com/) — 可與最多五人團隊共同使用，體驗基本方案（不含用戶管理）。
  * [QRME.SH](https://qrme.sh) - 快速、美觀的批量 QR Code 產生器—無需登入、無浮水印、無廣告。每次最多 100 個網址。
  * [QuickChart](https://quickchart.io) — 產生可嵌入的圖片圖表、圖形與 QR Code。
  * [redbooth.com](https://redbooth.com) — P2P 檔案同步，最多兩位用戶免費。
  * [resmush.it](https://resmush.it) — reSmush.it 免費 API，提供圖片優化。支援 WordPress、Drupal、Magento 等主流 CMS，全球已優化超過 70 億張圖片，仍完全免費。
  * [Shotstack](https://shotstack.io) - 規模化影片產生與編輯 API。免費方案每月可渲染 20 分鐘影片。
  * [tinypng.com](https://tinypng.com/) — PNG、JPEG 圖片壓縮與調整大小 API，每月免費 500 次壓縮。
  * [transloadit.com](https://transloadit.com/) — 處理檔案上傳、影片/音訊/圖片/文件編碼。開源、慈善與學生（透過 GitHub Student Developer Pack）免費。商業用途試用 2 GB 免費。
  * [twicpics.com](https://www.twicpics.com) - 響應式圖片即服務（Responsive images as a service）。提供圖片 CDN、媒體處理 API 以及前端函式庫，自動化圖片優化。每月流量最高 3GB 免費。
  * [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare 提供基於尖端演算法的終極媒體處理工具組。所有功能完全免費提供給開發者：檔案上傳 API 與 UI、圖片 CDN 與原始服務、自適應傳遞與智慧壓縮。免費方案包含 3000 次上傳、3GB 流量、3GB 儲存空間。
  * [imagekit.io](https://imagekit.io) – 圖片 CDN，具備自動優化、即時轉換與儲存，可於數分鐘內整合進現有架構。免費方案每月最高 20GB 流量。
  * [internxt.com](https://internxt.com) – Internxt Drive 是一個基於絕對隱私與不妥協安全性的零知識檔案儲存服務。註冊即可獲得 10GB 永久免費空間！
  * [degoo.com](https://degoo.com/) – 基於 AI 的雲端儲存，免費最高 20GB、支援三台裝置、推薦獎勵 5GB（帳號 90 天未使用會失效）。
  * [MConverter.eu](https://mconverter.eu/) – 批量檔案轉換。支援多種檔案格式，包括新格式如 [AVIF](https://mconverter.eu/convert/to/avif/)。可從影片中擷取所有影格。每天最多可免費處理十個 100MB 檔案，每次批次處理兩個。
  * [ImageEngine](https://imageengine.io/) – ImageEngine 是易於使用的全球圖片 CDN。60 秒內完成設定。支援 AVIF 和 JPEGXL，並有 WordPress、Magento、React、Vue 等外掛。免費開發者帳號[點此申請](https://imageengine.io/developer-program/)。
  * [DocsParse](https://docsparse.com/) – 以 GPT 為基礎的 AI，可將 PDF、圖片等文件處理為結構化資料（JSON、CSV、EXCEL 格式）。每月提供 30 次免費點數。
  * [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – 輕鬆為禮品卡、禮券及促銷活動建立自訂 QR 碼。支援自訂樣式、色彩、Logo 等。
  * [LibreQR](https://libreqr.com) — 專注隱私、無追蹤的免費 QR 碼產生器。無資料收集，完全免費。

**[⬆️ 回到頂部](#table-of-contents)**

## 設計與 UI

  * [AllTheFreeStock](https://allthefreestock.com) - 精選免費圖庫、音訊及影片資源清單。
  * [Float UI](https://floatui.com/) - 免費網頁開發工具，即使非設計師也能快速建立現代響應式網站。
  * [Ant Design Landing Page](https://landing.ant.design/) - 由 Ant Motion 動畫元件打造的 Ant Design 登陸頁範本，擁有豐富首頁範本，可下載範本程式碼並快速使用，也能用編輯器快速自訂專屬頁面。
  * [Backlight](https://backlight.dev/) — 以開發者與設計師協作為核心，Backlight 是完整的設計系統程式設計平台。免費方案允許最多 3 位編輯者於 1 個設計系統協作，觀察者不限人數。
  * [BoxySVG](https://boxy-svg.com/app) — 免費安裝式網頁應用程式，繪製 SVG 並可匯出 SVG、PNG、JPEG 及其他格式。
  * [Carousel Hero](https://carouselhero.com/) - 免費線上社群媒體輪播圖製作工具。
  * [Circum Icons](https://circumicons.com) - 一致性的開源圖示，支援 React、Vue、Svelte 的 SVG 格式。
  * [clevebrush.com](https://www.cleverbrush.com/) — 免費圖形設計／照片拼貼應用程式，亦提供付費組件整合服務。
  * [cloudconvert.com](https://cloudconvert.com/) — 支援 208 種格式（含影片與 GIF）的萬用檔案轉換工具。
  * [CodeMyUI](https://codemyui.com) - 精選網頁設計與 UI 靈感及程式碼片段。
  * [ColorKit](https://colorkit.co/) - 在線建立色彩調色盤或從頂尖色盤獲得靈感。
  * [coolors](https://coolors.co/) - 免費色彩調色盤產生器。
  * [CMYK Pantone](https://www.cmyktopantone.com/) - 免費快速將 CMYK 色值轉換為最接近的 Pantone 色號及其他色彩模式。
  * [Branition](https://branition.com/colors) - 為品牌精選最佳色彩組合。
  * [css-gradient.com](https://www.css-gradient.com/) - 免費快速產生自訂跨瀏覽器 CSS 漸層工具，支援 RGB 與 HEX 格式。
  * [easyvectors.com](https://easyvectors.com/) — 免費 SVG 向量藝術圖庫，下載優質向量圖完全免費。
  * [figma.com](https://www.figma.com) — 在線協作設計工具，免費方案不限檔案與觀察者，最多 2 位編輯者及 3 個專案。
  * [Flyon UI](https://flyonui.com/)- Tailwind CSS 最簡易的元件庫。
  * [framer.com](https://www.framer.com/) - Framer 協助你為應用、網站或產品快速迭代與動畫設計。專業原型工具驗證不限觀察者，最多 2 位編輯者與 3 個專案。
  * [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU 無憂商業用途模特／財產釋放授權圖庫。
  * [Gradientos](https://www.gradientos.app) - 讓選擇漸層顏色快速又簡單。
  * [Icon Horse](https://icon.horse) – 透過簡易 API 取得任何網站最高解析度的 favicon。
  * [Iconoir](https://iconoir.com) – 開源圖示庫，數千個圖示，支援 React、React Native、Flutter、Vue、Figma、Framer。
  * [Icons8](https://icons8.com) — 圖示、插圖、照片、音樂及設計工具。免費方案提供低解析度及有限格式，使用時需註明來源。
  * [landen.co](https://www.landen.co) — 產生、編輯並發佈美觀網站與登陸頁，無需寫程式。免費方案可擁有 1 個網站，完全可自訂並可發布。
  * [Quant Ux](https://quant-ux.com/) - 原型設計與設計工具。完全免費且開源。
  * [lensdump.com](https://lensdump.com/) - 免費雲端圖片託管。
  * [Lorem Picsum](https://picsum.photos/) - 免費、簡單又時尚的佔位圖片工具。於網址尾端加上所需尺寸（寬 x 高）即可獲得隨機圖片。
  * [LottieFiles](https://lottiefiles.com/) - 全球最大 Lottie 動畫（最小動畫格式）平台，支援設計師、開發者等。提供 Android、iOS、Web 插件與動畫工具。
  * [MagicPattern](https://www.magicpattern.design/tools) — 一系列 CSS 與 SVG 背景產生器及工具，支援漸層、圖樣、Blob 等。
  * [marvelapp.com](https://marvelapp.com/) — 設計、原型製作與協作平台，免費方案限一名使用者與一個專案。
  * [Mindmup.com](https://www.mindmup.com/) — 無限心智圖免費儲存於雲端，跨裝置隨時可用。
  * [Mockplus iDoc](https://www.mockplus.com/idoc) - 強大的設計協作與交接工具。免費方案支援三人與五個專案，全部功能皆可用。
  * [mockupmark.com](https://mockupmark.com/create/free) — 創建寫實 T 恤與服裝樣機，適用於社群及電商，提供 40 款免費樣機。
  * [Mossaik](https://mossaik.app) - 免費 SVG 圖片產生器，內建波浪、Blob、圖樣等工具。
  * [movingpencils.com](https://movingpencils.com) — 快速、瀏覽器端向量繪圖編輯器，完全免費。
  * [Octopus.do](https://octopus.do) — 視覺化網站地圖構建工具，支援即時構建、團隊協作。
  * [Pencil](https://github.com/evolus/pencil) - 基於 Electron 的開源設計工具。
  * [Penpot](https://penpot.app) - 網頁版、開源設計與原型工具，支援 SVG。完全免費。
  * [pexels.com](https://www.pexels.com/) - 免費商用圖庫，提供 API 可依關鍵字搜尋照片。
  * [photopea.com](https://www.photopea.com) — 免費進階線上設計編輯器，UI 類似 Adobe Photoshop，支援 PSD、XCF、Sketch 格式（Photoshop、Gimp、Sketch App）。
  * [pixlr.com](https://pixlr.com/) — 免費線上瀏覽器編輯器，媲美商業級軟體。
  * [Plasmic](https://www.plasmic.app/) - 快速、易用、強大的網頁設計與頁面生成工具，可整合進代碼庫。可建立響應式頁面或複雜元件，選擇性擴展程式碼並發布至正式網站與應用。
  * [Pravatar](https://pravatar.cc/) - 產生隨機／佔位假頭像，可直接在網頁／應用中熱鏈接圖片網址。
  * [Proto.io](https://www.proto.io) - 無需程式碼即可建立完整互動式 UI 原型。免費方案於試用期結束後啟用，包含 1 位用戶、1 個專案、5 個原型、100MB 雲端儲存及原型預覽功能。
  * [resizeappicon.com](https://resizeappicon.com/) — 簡單服務，協助調整與管理 App 圖示大小。
  * [Rive](https://rive.app) — 建立並發布美觀動畫至任意平台。個人用戶永久免費。提供編輯器並主機托管所有圖像，也有多平台運行時支援 Rive 動畫。
  * [storyset.com](https://storyset.com/) — 利用此工具為專案創建精彩免費的自訂插圖。
  * [smartmockups.com](https://smartmockups.com/) — 產品樣機製作，提供 200 款免費樣機。
  * [Shadcn Studio](https://shadcnstudio.com/theme-editor) — 預覽主題在不同元件與版型上的變化。
  * [Tailark](https://tailark.com/) - 專為行銷網站設計的現代響應式預建 UI 模組集合。
  * [tabler-icons.io](https://tabler-icons.io/) — 超過 1500 個可複製編輯的 SVG 圖示。
  * [tweakcn](https://tweakcn.com/) — 為 shadcn/ui 量身打造的美麗主題。即時自訂色彩、字體等。
  * [UI Avatars](https://ui-avatars.com/) - 根據姓名產生帶縮寫的頭像，網址可直接熱鏈。支援透過網址設定參數。
  * [unDraw](https://undraw.co/) - 不斷更新的美麗 SVG 插圖集，可完全免費且無需署名使用。
  * [unsplash.com](https://unsplash.com/) - 免費商用及非商用圖庫（極寬鬆授權）。
  * [vectr.com](https://vectr.com/) — 免費網頁 + 桌面設計應用程式。
  * [walkme.com](https://www.walkme.com/) — 企業級用戶引導與互動平台，免費方案可製作三個最多 5 步驟的指引。
  * [Webflow](https://webflow.com) - 具動畫及網站代管的所見即所得網站建構器。免費支援兩個專案。
  * [Updrafts.app](https://updrafts.app) - 基於 tailwindcss 設計的所見即所得網站建構器。非商業用途免費。
  * [whimsical.com](https://whimsical.com/) - 協作流程圖、線框、便利貼與心智圖。可建立最多 4 個免費看板。
  * [Zeplin](https://zeplin.io/) — 設計師與開發者協作平台，展示設計、素材與樣式指南。免費支援一個專案。
  * [Pixelixe](https://pixelixe.com/) — 在線創建與編輯吸引人的獨特圖像與圖形。
  * [Responsively App](https://responsively.app) - 免費開發工具，加速並精確地開發響應式網頁應用。
  * [SceneLab](https://scenelab.io) - 在線樣機圖編輯器，擁有不斷擴充的免費設計模板集。
  * [xLayers](https://xlayers.dev) - 預覽並轉換 Sketch 設計稿為 Angular、React、Vue、LitElement、Stencil、Xamarin 等格式（免費且開源：[GitHub](https://github.com/xlayers/xlayers)）。
  * [Grapedrop](https://grapedrop.com/) — 基於 GrapesJS 框架的響應式、強大、SEO 最佳化網頁建構器。前 5 頁免費、可自訂網域、所有功能皆可用、操作簡單。
  * [Mastershot](https://mastershot.app) - 完全免費的瀏覽器端影片編輯器，無浮水印，最高支援 1080p 輸出。
  * [Unicorn Platform](https://unicornplatform.com/) - 極簡著陸頁建構與代管，一個網站免費。
  * [SVGmix.com](https://www.svgmix.com/) - 超過 30 萬個免費 SVG 圖示、圖集與品牌 Logo 的大型資源庫，並內建簡單向量編輯器可直接線上編輯檔案。
  * [svgrepo.com](https://www.svgrepo.com/) - 使用多種向量圖庫搜尋、探索、尋找最適合專案的圖示或向量，支援商用免費下載 SVG 向量圖。
  * [haikei.app](https://www.haikei.app/) - Haikei 是一款網頁應用，能產生獨特的 SVG 形狀、背景與圖樣，隨時可於設計工具與工作流程中使用。
  * [Canva](https://canva.com) - 免費線上設計工具，製作各式視覺內容。
  * [Superdesigner](https://superdesigner.co) - 免費設計工具集，僅需點擊即可創建獨特背景、圖樣、形狀、圖像等。
  * [TeleportHQ](https://teleporthq.io/) - 低程式碼前端設計與開發平台。協作式平台，能即時建立與發布 headless 靜態網站。三個專案免費，無限協作者，免費代碼匯出。
  * [vector.express](https://vector.express) — 快速簡單地轉換 AI、CDR、DWG、DXF、EPS、HPGL、PDF、PLT、PS 與 SVG 向量檔。
  * [Vertopal](https://www.vertopal.com) - 免費線上檔案轉換平台，支援多種格式，包含開發者常用如 JPG 轉 SVG、GIF 轉 APNG、PNG 轉 WEBP、JSON 轉 XML 等。
  * [okso.app](https://okso.app) - 極簡線上繪圖應用，快速繪製草圖與視覺筆記。可匯出 PNG、JPG、SVG、WEBP，也可安裝為 PWA。完全免費，無需註冊。
  * [Wdrfree SVG](https://wdrfree.com/free-svg) - 黑白免費 SVG 切割檔資源。
  * [Lucide](https://lucide.dev) - 免費可自訂且一致性的 SVG 圖示工具包。
  * [Logo.dev](https://www.logo.dev) - 擁有 4400 萬品牌的公司 Logo API，只需呼叫網址即可取得。首 10,000 次 API 呼叫免費。
  * [MDBootstrap](https://mdbootstrap.com/) - 免費個人與商業用途的 Bootstrap、Angular、React、Vue UI 套件，超過 700 個元件、精美模板、1 分鐘安裝、豐富教學與龐大社群。
  * [TW Elements](https://tw-elements.com/) - 免費 Bootstrap 元件，使用 Tailwind CSS 重製，設計更佳、功能更多。
  * [DaisyUI](https://daisyui.com/) -- 免費。「用 Tailwind CSS 但減少 class 名」並提供按鈕等元件。
  * [Scrollbar.app](https://scrollbar.app) -- 簡單且免費的網頁應用程式，用於設計自訂網頁捲軸。
  * [css.glass](https://css.glass/) -- 免費的網頁應用程式，使用 CSS 創建玻璃質感設計。
  * [hypercolor.dev](https://hypercolor.dev/) -- 精選的 Tailwind CSS 漸層色彩集合，並提供多種產生器讓你自訂漸層。
  * [iconify.design](https://icon-sets.iconify.design/) -- 超過 100 種圖示包的整合集合。可跨包搜尋圖示並將個別圖示匯出為 SVG 或流行的網頁框架格式。
  * [NextUI](https://nextui.org/) -- 免費。美觀、快速且現代化的 React 和 Next.js UI 函式庫。
  * [Glyphs](https://glyphs.fyi/) -- 免費，網路上最強大的圖示，完全可編輯且真正開源的設計系統。
  * [ShadcnUI](https://ui.shadcn.com/) -- 精美設計的元件，可直接複製貼上到你的應用程式。無障礙。可自訂。開源。
  * [HyperUI](https://www.hyperui.dev/) -- 免費開源的 Tailwind CSS 元件。
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- 一鍵生成整年度的獨特日曆圖示，完全免費
  * [Image BG Blurer](https://imagebgblurer.com/) -- 為圖片生成模糊背景框架，使用圖片來源作為背景模糊，適用於 Notion、Trello、Jira 等工具
  * [Webstudio](https://webstudio.is/) -- 開源的 Webflow 替代方案。免費方案可在其網域上建立無限網站。可綁定五個自訂網域。每月一萬次瀏覽量。2 GB 資產儲存空間。
  * [Nappy](https://nappy.co/) -- 免費提供黑人及棕色人種的美麗照片，適用於商業與個人用途。
  * [Tailkits](https://tailkits.com/) -- 精選的 Tailwind 模板、元件和工具集合，並提供實用的程式碼、格線、陰影等產生器。
  * [Tailcolors](https://tailcolors.com/) -- 美麗的 Tailwind CSS v4 色彩調色盤。即時預覽並複製完美的 Tailwind CSS 色彩類別。
  * [Excalidraw](https://excalidraw.com/) -- 免費的線上繪圖文件網頁，支援本地儲存及匯出。
  * [Lunacy](https://icons8.com/lunacy) -- 免費的圖形設計工具，支援離線使用，內建資產（圖示、照片、插圖）與即時協作。免費層級包含 10 份雲端文件、30 天歷史、低解析資產及基本設計工具。

**[⬆️ 返回頂部](#table-of-contents)**

## 設計靈感

  * [awwwards.](https://www.awwwards.com/) - [頂級網站] 展示所有最佳設計網站（由設計師投票）。
  * [Behance](https://www.behance.net/) - [設計作品集] 設計師展示作品的平台。可依類別篩選 UI/UX 專案。
  * [dribbble](https://dribbble.com/) - [設計作品集] 獨特的設計靈感來源，通常非真實應用程式。
  * [Landings](https://landings.dev/) - [網頁截圖] 根據你的偏好尋找最佳登陸頁設計靈感。
  * [Lapa Ninja](https://www.lapa.ninja/) - [登陸頁 / UI 套件 / 網頁截圖] Lapa Ninja 為畫廊網站，精選 6025 個最佳登陸頁範例、免費設計書與來自全球的免費 UI 套件。
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [登陸頁設計] 經常更新的登陸頁截圖。包含桌面、平板與手機截圖。
  * [Mobbin](https://mobbin.design/) - [手機截圖] 50,000+ 可搜尋的手機應用 UI & UX 截圖資料庫，節省研究時間。
  * [Uiland Design](https://uiland.design/) - [手機截圖] 探索來自非洲及全球領導企業的手機與網頁 UI 設計。
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [手機截圖] 為設計師、開發者及產品製作者提供 iOS 與 Android 最佳 UI UX 範例的設計靈感資料庫。
  * [Page Flows](https://pageflows.com/) - [手機/網頁影片與截圖] 提供多款手機與網頁應用完整流程的影片與截圖。高度可搜尋且有索引。
  * [Screenlane](https://screenlane.com/) - [手機截圖] 獲取最新網頁與手機應用 UI 設計趨勢靈感。可依模式與應用程式篩選。
  * [scrnshts](https://scrnshts.club/) - [手機截圖] 精選 App Store 設計截圖收藏。
  * [Refero](https://refero.design/) - [網頁截圖] 來自優秀網頁應用的設計參考，有標籤與可搜尋。

**[⬆️ 返回頂部](#table-of-contents)**

## 地圖上的資料視覺化

  * [IP Geolocation](https://ipgeolocation.io/) — 提供免費開發者方案，每月 30,000 次請求。
  * [carto.com](https://carto.com/) — 根據你的資料及公開資料建立地圖及地理空間 API。
  * [Clockwork Micro](https://clockworkmicro.com/) — 如鐘錶般精準的地圖工具。每月五萬次免費查詢（地圖磚、db2vector、高程）。
  * [developers.arcgis.com](https://developers.arcgis.com) — 提供地圖、地理資料儲存、分析、地理編碼、路徑規劃等 API 和 SDK，支援網頁、桌面及行動端。每月 200 萬個基礎地圖磚、20,000 個非儲存地理編碼、20,000 條簡單路徑、5,000 次行車時間計算與 5GB 磚+資料儲存免費額度。
  * [Foursquare](https://developer.foursquare.com/) - Places API 與 Pilgrim SDK 提供位置發現、場所搜尋及情境感知內容。
  * [geoapify.com](https://www.geoapify.com/) - 向量與光柵地圖磚、地理編碼、場所、路徑、等值線 API。每天三千次免費請求。
  * [geocod.io](https://www.geocod.io/) — 透過 API 或 CSV 上傳進行地理編碼。每天 2,500 次免費查詢。
  * [geocodify.com](https://geocodify.com/) — 透過 API 或 CSV 上傳進行地理編碼與地理解析。每月一萬次免費查詢。
  * [geojs.io](https://www.geojs.io/) - 高可用的 REST/JSON/JSONP IP 地理定位查詢 API。
  * [giscloud.com](https://www.giscloud.com/) — 在線視覺化、分析與分享地理資料。
  * [graphhopper.com](https://www.graphhopper.com/) 提供免費開發者套件，用於路徑規劃、路徑最佳化、距離矩陣、地理編碼與地圖配對。
  * [here](https://developer.here.com/) — 提供地圖與位置感知應用的 API 與 SDK。每月 250,000 次免費交易。
  * [locationiq.com](https://locationiq.com/) — 地理編碼、地圖與路徑 API。每天 5,000 次免費請求。
  * [mapbox.com](https://www.mapbox.com/) — 地圖、地理空間服務及 SDK，支援地圖資料顯示。
  * [maptiler.com](https://www.maptiler.com/cloud/) — 向量地圖、地圖服務和 SDK 用於地圖視覺化。免費向量地圖磚每週更新，並有四種地圖風格。
  * [nominatim.org](https://nominatim.org/) — OpenStreetMap 的免費地理編碼服務，提供全球地址搜尋及反向地理編碼功能。
  * [nextbillion.ai](https://nextbillion.ai/) - 提供地圖相關服務：地理編碼、導航（路線、路徑規劃、路線最佳化、距離矩陣）、地圖 SDK（向量、靜態、行動端 SDK）。[每項服務均有免費額度](https://nextbillion.ai/pricing)。
  * [opencagedata.com](https://opencagedata.com) — 聚合 OpenStreetMap 及其他開源地理資料的地理編碼 API。每天 2,500 次免費查詢。
  * [osmnames](https://osmnames.org/) — 地理編碼，搜尋結果依相關 Wikipedia 頁面人氣排序。
  * [positionstack](https://positionstack.com/) - 提供全球地點與座標的免費地理編碼。個人用途每月 25,000 次請求。
  * [stadiamaps.com](https://stadiamaps.com/) — 地圖磚、路徑、導航及其他地理空間 API。非商業用途與測試每天 2,500 次免費地圖瀏覽及 API 請求。
  * [maps.stamen.com](http://maps.stamen.com/) - 免費地圖磚及磚圖託管服務。
  * [ipstack](https://ipstack.com/) - 依據 IP 位址定位並識別網站訪客
  * [Geokeo api](https://geokeo.com) - 具備語言修正等功能的地理編碼 API，涵蓋全球。每日 2,500 次免費查詢

**[⬆️ 返回頂部](#table-of-contents)**

## 套件建置系統

  * [build.opensuse.org](https://build.opensuse.org/) — 支援多個發行版（SUSE、EL、Fedora、Debian 等）的套件建置服務。
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — 基於 Mock 的 RPM 套件建置服務，適用於 Fedora 及 EL。
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — Ubuntu 與 Debian 套件建置服務。

**[⬆️ 返回頂部](#table-of-contents)**

## IDE 與程式碼編輯

  * [3v4l](https://3v4l.org/) - 免費線上 PHP shell 與程式片段分享站點，可在 300+ PHP 版本中執行你的程式碼
  * [Android Studio](https://developer.android.com/studio) — Android Studio 提供最快速的工具，能在各種 Android 裝置上開發應用。開源 IDE，完全免費，是最佳的 Android 應用開發工具。支援 Windows、Mac、Linux，甚至 ChromeOS！
  * [AndroidIDE](https://m.androidide.com/) — 一款開源 IDE，可在 Android 裝置上開發真正基於 Gradle 的 Android 應用程式。
  * [Apache Netbeans](https://netbeans.apache.org/) — 開發環境、工具平台與應用框架。
  * [apiary.io](https://apiary.io/) — 協作式設計 API 平台，具備即時 API 模擬與產生文件功能（免費不限 API blueprints 與使用者數量，僅一個管理帳號與託管文件）。
  * [BBEdit](https://www.barebones.com/) - BBEdit 是 macOS 上流行且可擴充的編輯器。免費模式提供[強大的核心功能](https://www.barebones.com/products/bbedit/comparison.html)並可升級至進階功能。
  * [Binder](https://mybinder.org/) - 將 Git 倉庫變成一系列互動式筆記本。這是一項免費公開服務。
  * [BlueJ](https://bluej.org) — 專為初學者設計的免費 Java 開發環境，全球數百萬人使用，由 Oracle 技術驅動，簡易 GUI 幫助新手學習。
  * [Bootify.io](https://bootify.io/) - Spring Boot 應用產生器，支援自訂資料庫與 REST API。
  * [Brackets](http://brackets.io/) - Brackets 是專為網頁開發設計的開源文字編輯器。輕量、易用且高度可自訂。
  * [cacher.io](https://www.cacher.io) — 程式碼片段管理工具，支援標籤與超過 100 種程式語言。
  * [Code::Blocks](https://codeblocks.org) — 免費 Fortran 及 C/C++ IDE。開源，支援 Windows、macOS 及 Linux。
  * [Cody](https://sourcegraph.com/cody) - 免費 AI 程式輔助，可撰寫（程式區塊、自動補全、單元測試）、理解（掌握整個程式碼庫）、修正與搜尋程式碼。支援 VS Code、JetBrains 及線上使用。
  * [codiga.io](https://codiga.io/) — 程式輔助工具，可讓你在 IDE 內直接搜尋、定義及重用程式碼片段。個人與小型組織免費。
  * [codesnip.com.br](https://codesnip.com.br) — 簡單的程式碼片段管理工具，支援分類、搜尋與標籤。免費且無限量。
  * [cocalc.com](https://cocalc.com/) —（前身為 SageMathCloud，cloud.sagemath.com）— 雲端協作計算。瀏覽器即時存取完整 Ubuntu 環境，內建協作功能，提供大量數學、科學、資料科學免費軟體，預先安裝：Python、LaTeX、Jupyter Notebooks、SageMath、scikitlearn 等。
  * [code.cs50.io](https://code.cs50.io/) - Visual Studio Code for CS50，是專為學生與教師調整的 GitHub Codespaces 網頁應用。
  * [codepen.io](https://codepen.io/) — CodePen 是前端網頁開發的實驗場。
  * [codesandbox.io](https://codesandbox.io/) — React、Vue、Angular、Preact 等線上程式碼實驗場。
  * [Components.studio](https://webcomponents.dev/) - 隔離編寫元件、以故事視覺化、測試並發佈到 npm。
  * [Eclipse Che](https://www.eclipse.org/che/) - 針對開發團隊設計的網頁版與 Kubernetes 原生 IDE，支援多語言。開源並由社群驅動。Red Hat 提供線上實例於 [workspaces.openshift.com](https://workspaces.openshift.com/)。
  * [fakejson.com](https://fakejson.com/) — FakeJSON 幫助你透過 API 快速產生假資料。只需描述你想要的內容與格式，API 即會回傳全部 JSON 結果。加快想法上市流程，假資料先行。
  * [GetVM](https://getvm.io) — 即時免費 Linux 與 IDE Chrome 側邊欄。免費層級每天可用 5 台虛擬機。
  * [GitPod](https://www.gitpod.io) — 為 GitHub 專案提供即時、隨時可編寫程式的開發環境。免費方案包含每月 50 小時。
  * [ide.goorm.io](https://ide.goorm.io) goormIDE 是雲端上的完整 IDE。支援多語言、基於 Linux 的容器，提供功能豐富的網頁終端機、埠轉發、自訂 URL、即時協作與聊天、分享連結、Git/Subversion 支援，還有許多其他功能（免費方案每個容器包含 1GB RAM 和 10GB 儲存空間，5 個容器插槽）。
  * [JDoodle](https://www.jdoodle.com) — 支援 60 多種程式語言的線上編譯器與編輯器，免費方案每天可用於 REST API 程式碼編譯達 200 點數。
  * [jetbrains.com](https://jetbrains.com/products.html) — 生產力工具、IDE 及部署工具（如 [IntelliJ IDEA](https://www.jetbrains.com/idea/)、[PyCharm](https://www.jetbrains.com/pycharm/) 等）。學生、教師、開源及用戶團體可獲免費授權。
  * [jsbin.com](https://jsbin.com) — JS Bin 是前端網頁（HTML、CSS、JavaScript）程式碼測試與分享平台，亦支援 Markdown、Jade、Sass。
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle 是前端網頁程式碼測試與分享平台，支援協作功能。
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) 提供一些以 JSON 格式回傳假資料的 REST API 端點。也可取得原始碼自行架設伺服器。
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus 是 Delphi 相容的跨平台 IDE，用於快速應用程式開發。
  * [MarsCode](https://www.marscode.com/) - 免費的 AI 雲端 IDE。
  * [micro-jaymock](https://micro-jaymock.now.sh/) - 輕量級 API 模擬微服務，用於生成假 JSON 資料。
  * [mockable.io](https://www.mockable.io/) — Mockable 是一個簡單可配置的服務，可用於模擬 RESTful API 或 SOAP 網路服務。此線上服務讓你快速定義 REST API 或 SOAP 端點，並回傳 JSON 或 XML 資料。
  * [mockaroo](https://mockaroo.com/) — Mockaroo 可生成真實感測試資料，支援 CSV、JSON、SQL、Excel 格式。亦可建立後端 API 模擬。
  * [Mocklets](https://mocklets.com) - 基於 HTTP 的模擬 API 模擬器，有助於更快的平行開發和更完整的測試，終身免費層。
  * [Paiza](https://paiza.cloud/en/) — 直接在瀏覽器中開發 Web 應用，無需安裝。免費方案提供一台伺服器，24 小時存活期，每天可執行 4 小時，配備 2 CPU 核心、2 GB RAM、1 GB 儲存空間。
  * [Prepros](https://prepros.io/) - Prepros 可自動編譯 Sass、Less、Stylus、Pug/Jade、Haml、Slim、CoffeeScript、TypeScript，並支援瀏覽器自動重載，使網站開發與測試更容易。亦可輕鬆加入自訂工具。
  * [Replit](https://replit.com/) — 多語言雲端編程環境。
  * [SoloLearn](https://code.sololearn.com) — 雲端程式設計測試平台，適合執行程式片段。支援多種程式語言。執行程式不需註冊，儲存程式需註冊。另有免費新手及中階課程。
  * [stackblitz.com](https://stackblitz.com/) — 線上/雲端程式 IDE，可建立、編輯、部署全端應用。支援各種 NodeJs 前後端框架。建立新專案短連結：[https://node.new](https://node.new)。
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text 是受歡迎、多功能且高度可自訂的文字編輯器，用於編碼與編輯文字。
  * [Visual Studio Code](https://code.visualstudio.com/) - 重新定義、優化的程式編輯器，適用於建構與除錯現代網頁及雲端應用。由 Microsoft 開發。
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — 完整功能的 IDE，數千種擴充套件，支援跨平台應用開發（可下載 Microsoft 擴充套件以支援 iOS、Android）、桌面、網頁及雲端開發，多語言支援（C#、C++、JavaScript、Python、PHP 等）。
  * [VSCodium](https://vscodium.com/) - 由社群驅動，無遙測/追蹤，且完全開源授權的 VSCode 二進位發行版。
  * [wakatime.com](https://wakatime.com/) — 透過文字編輯器外掛量化程式編寫活動，有限免費方案。
  * [Wave Terminal](https://waveterm.dev/) - Wave 是開源、跨平台的終端機，支援無縫工作流程。可內嵌渲染各種內容、儲存工作階段與歷史記錄，基於開放網路標準。支援 MacOS 與 Linux。
  * [WebComponents.dev](https://webcomponents.dev/) — 瀏覽器內的 Web Component 編碼 IDE，內建 58 種範本，支援 stories 及測試。
  * [PHPSandbox](https://phpsandbox.io/) — PHP 線上開發環境
  * [WebDB](https://webdb.app) - 免費高效能資料庫 IDE。具備伺服器探索、ERD、資料生成器、AI、NoSQL 結構管理、資料庫版本控管等功能。
  * [Zed](https://zed.dev/) - Zed 是來自 Atom 及 Tree-sitter 創作者的高效能多用戶程式碼編輯器。
  * [OneCompiler](https://onecompiler.com/) - 免費線上編譯器，支援 70+ 種語言，包括 Java、Python、C++、JavaScript。

**[⬆️ 回到頂部](#table-of-contents)**

## 分析、事件與統計

  * [Dwh.dev](https://dwh.dev) - 資料雲觀測解決方案（Snowflake）。個人用途免費。
  * [Hightouch](https://hightouch.com/) - Hightouch 是反向 ETL 平台，可將資料倉儲中的客戶資料同步到 CRM、行銷、支援工具。免費方案可選擇一個目的地同步資料。
  * [Avo](https://avo.app/) — 簡化的分析發布工作流程。單一來源追蹤計畫、型別安全的分析追蹤庫、應用內除錯器及資料可觀測性，在發布前捕捉所有資料問題。免費方案支援 2 位工作區成員及 1 小時資料回溯。
  * [Branch](https://www.branch.io) — 行動分析平台。免費層支援最多 1 萬名行動應用用戶，含深度連結及其他服務。
  * [Census](https://www.getcensus.com/) — 反向 ETL 與營運分析平台。可將資料倉儲中的 10 個欄位同步至 60+ SaaS（如 Salesforce、Zendesk、Amplitude）。
  * [Clicky](https://clicky.com) — 網站分析平台。免費方案支援 1 個網站、3000 次瀏覽資料分析。
  * [Databox](https://databox.com) — 結合其他分析與 BI 平台的商業洞察與分析。免費方案支援 3 位用戶、儀表板及資料來源，提供 1100 萬筆歷史資料。
  * [Hitsteps.com](https://hitsteps.com/) — 每月 2,000 頁面瀏覽，限 1 個網站
  * [amplitude.com](https://amplitude.com/) — 每月 100 萬事件，最多 2 個應用
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter 是開源網站分析平台，可選託管服務（非商業用途免費）或自架。致力於提供易用且重視隱私的網站分析，作為 Google Analytics、Matomo 替代方案。免費層限非商業用途，支援不限站點、6 個月資料保存、每月 10 萬頁面瀏覽。
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — 針對開發者的隱私友善 Google Analytics 替代方案。免費方案每月 2 萬頁面瀏覽，無需信用卡。
  * [Expensify](https://www.expensify.com/) — 費用報告，免費個人審核工作流程
  * [getinsights.io](https://getinsights.io) - 注重隱私、無 cookie 的分析服務，免費方案支援每月 3,000 事件。
  * [heap.io](https://heap.io) — 自動記錄 iOS 或網頁應用的每個使用者操作。免費支援每月 10,000 次工作階段。
  * [Hotjar](https://hotjar.com) — 網站分析與報告。免費方案每日 2,000 頁面瀏覽。每日 100 張快照（最大容量 300）。3 張快照熱點圖可保存 365 天。團隊成員不限。亦有應用內與獨立調查、回饋小工具含截圖。免費層可建立 3 份調查與 3 個回饋小工具，每月收集 20 份回覆。
  * [Keen](https://keen.io/) — 自訂分析資料收集、分析及視覺化。每月 1,000 事件免費。
  * [Yandex.Datalens](https://datalens.yandex.com/) — Yandex 雲端資料視覺化與分析服務。免費提供，無用戶與請求數限制。
  * [Yandex.Metrica](https://metrica.yandex.com/) — 無限免費分析
  * [Mixpanel](https://mixpanel.com/) — 每月 10 萬名追蹤用戶，數據歷史與席次不限，美國或歐盟資料存放區
  * [Moesif](https://www.moesif.com) — REST 與 GraphQL 的 API 分析。（每月 500,000 次 API 呼叫免費）
  * [optimizely.com](https://www.optimizely.com) — A/B 測試解決方案，免費入門方案，支援 1 個網站、1 個 iOS 與 1 個 Android 應用
  * [Microsoft PowerBI](https://powerbi.com) — Microsoft 商業洞察與分析。免費方案提供有限功能及 1 百萬用戶授權。
  * [Row Zero](https://rowzero.io) - 超快連線式試算表。可直接連接資料庫、S3 與 API。即時匯入、分析、繪圖及分享數百萬筆資料。免費三本（永久）工作簿。
  * [sematext.com](https://sematext.com/cloud/) — 每月最多 5 萬次動作免費，1 天資料保存，儀表板、用戶等不限。
  * [Similar Web](https://similarweb.com) — 網頁與行動應用分析。免費方案每項指標 5 個結果，行動應用資料 1 個月、網站資料 3 個月。
  * [StatCounter](https://statcounter.com/) — 網站瀏覽者分析。免費方案可分析最近 500 名訪客。
  * [Statsig](https://statsig.com) - 整合分析、功能旗標及 A/B 測試的一站式平台。每月最多 100 萬計量事件免費。
  * [Tableau Developer Program](https://www.tableau.com/developer) — 推動創新，讓 Tableau 完美契合你的組織。免費開發者方案提供 Tableau Online 個人開發沙盒授權。版本為最新預發布，方便資料開發者測試所有功能。
  * [usabilityhub.com](https://usabilityhub.com/) — 讓真實用戶測試設計與模型並追蹤訪客。免費方案 1 位用戶，測試次數不限
  * [woopra.com](https://www.woopra.com/) — 免費用戶分析平台，支援 50 萬次動作、90 天資料保存、30+ 一鍵整合。
  * [counter.dev](https://counter.dev) — 簡單且隱私友善的網站分析。免費或隨喜捐款。
  * [PostHog](https://posthog.com) - 完整產品分析套件，每月最多 100 萬追蹤事件免費。亦提供不限量應用內調查，每月 250 份回覆。
  * [Uptrace](https://uptrace.dev) - 分散式追蹤工具，協助開發者定位故障與效能瓶頸。免費方案，開源專案可免費升級個人版，也有開源版本。
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity 是免費、易用的網站使用行為分析工具。
  * [Beampipe.io](https://beampipe.io) - 簡單、注重隱私的網站分析。免費支援最多 5 個網域及每月 1 萬頁面瀏覽。
  * [Aptabase](https://aptabase.com) — 開源、注重隱私、簡單的行動與桌面應用分析。支援 Swift、Kotlin、React Native、Flutter、Electron 等多種 SDK。每月最多 2 萬事件免費。
  * [Trackingplan](https://www.trackingplan.com/) - 自動偵測數位分析、行銷資料與像素問題，維護追蹤計畫，促進協作。可在正式環境以真實流量部署，或無需寫程式將分析涵蓋於回歸測試。
  * [LogSpot](https://logspot.io) - 完整統一的網站與產品分析平台，含可嵌入分析小工具及自動機器人（支援 Slack、Telegram、Webhook）。免費方案每月含 1 萬事件。
  * [Umami](https://umami.is/) - 簡單、快速、重視隱私的開源 Google Analytics 替代方案。
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - 免費輕量、重視隱私的 Google Analytics 替代方案。不限頁面瀏覽、不限訪客、不限頁面熱點圖及目標追蹤。免費支援 3 個網域，每個網域每月 600 次回放。
  * [AppFit](https://appfit.io) - AppFit 是一站式分析與產品管理工具，支援跨平台分析與產品更新管理。免費方案每月含 1 萬事件、產品日誌與每週洞見。
  * [Seline](https://seline.so) - Seline 是簡單且隱私的網站與產品分析。無 Cookie、輕量、獨立。免費方案每月 3,000 事件，開放所有功能如儀表板、用戶旅程、漏斗等。
  * [Peasy](https://peasy.so) - Peasy 是輕量、注重隱私的網站與產品分析工具。免費方案每月 3,000 事件。
  * [Rybbit](https://rybbit.io) - 開源且無 Cookie 的 Google Analytics 替代方案，操作直觀。免費方案每月 3,000 事件。

**[⬆️ 回到頂部](#table-of-contents)**

## 訪客會話錄影

  * [Reactflow.com](https://www.reactflow.com/) — 每站每日 1,000 頁面瀏覽、三張熱點圖、三個小工具、免費錯誤追蹤
  * [OpenReplay.com](https://www.openreplay.com) - 開源會話回放，內建開發工具支援錯誤重現、即時支援及產品分析套件。每月 1,000 次會話，含所有功能，資料保存 7 天。
  * [LogRocket.com](https://www.logrocket.com) - 每月 1,000 次會話，資料保存 30 天，含錯誤追蹤與即時模式
  * [FullStory.com](https://www.fullstory.com) — 每月 1,000 次會話，資料保存 1 個月，三席位。詳情見[這裡](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition)。
  * [hotjar.com](https://www.hotjar.com/) — 每站每月 1,050 頁面瀏覽，熱點圖無限，資料保存三個月
  * [inspectlet.com](https://www.inspectlet.com/) — 每月 2,500 次會話，限 1 個網站
  * [Microsoft Clarity](https://clarity.microsoft.com/) - 會話錄影完全免費，"無流量限制"，不限專案，不限抽樣
  * [mouseflow.com](https://mouseflow.com/) — 每月 500 次會話，限 1 個網站
  * [mousestats.com](https://www.mousestats.com/) — 每月 100 次會話，限 1 個網站
  * [smartlook.com](https://www.smartlook.com/) — 網頁與行動應用免費方案（每月 1,500 次會話）、三張熱點圖、一條漏斗、資料保存一個月
  * [howuku.com](https://howuku.com) — 追蹤用戶互動、參與與事件。每月 5,000 次訪問免費
  * [UXtweak.com](https://www.uxtweak.com/) — 錄製並觀看訪客如何使用你的網站或應用。小型專案不限時免費

**[⬆️ 回到頂部](#table-of-contents)**
## 國際手機號碼驗證 API 與 SDK

  * [numverify](https://numverify.com/) — 全球手機號碼驗證與查詢 JSON API。每月 100 次 API 請求
  * [veriphone](https://veriphone.io/) — 全球手機號碼驗證，快速、可靠的免費 JSON API。每月 1000 次請求

**[⬆️ 返回頂部](#table-of-contents)**

## 支付與帳單整合

  * [Qonversion](http://qonversion.io/) - 一站式跨平台訂閱管理平台，提供分析、A/B 測試、Apple Search Ads、遠端配置和成長工具，優化應用內購買與變現。兼容 iOS、Android、React Native、Flutter、Unity、Cordova、Stripe 與 Web。每月最高 $10k 追蹤營收免費。
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – 根據訪客位置自動調整定價，協助企業全球擴展並進入新市場（購買力平價）。免費方案包含每月 7,500 次 API 請求。
  * [Glassfy](https://glassfy.io/) – 應用內訂閱基礎建設、即時訂閱事件與現成變現工具，適用於 iOS、Android、Stripe 及 Paddle。每月營收 $10k 內免費。
  * [Adapty.io](https://adapty.io/) – 提供開源 SDK 的一站式移動應用內訂閱整合解決方案，適用於 iOS、Android、React Native、Flutter、Unity 或 Web 應用。每月營收 $10k 內免費。
  * [CoinMarketCap](https://coinmarketcap.com/api/) — 提供加密貨幣市場數據，包括最新的加密及法幣匯率。免費方案每月 10,000 次 API 請求。
  * [CurrencyFreaks](https://currencyfreaks.com/) — 提供即時與歷史匯率資料。免費 DEVELOPER 方案每月 1000 次請求。
  * [CoinGecko](https://www.coingecko.com/en/api) — 提供加密貨幣市場數據，包括最新匯率及歷史數據。演示 API 每分鐘最多 30 次，每月上限 10,000 次。
  * [CurrencyApi](https://currencyapi.net/) — 提供實體及加密貨幣的即時匯率，支援 JSON 與 XML。免費方案每月 1,250 次 API 請求。
  * [currencylayer](https://currencylayer.com/) — 可靠的匯率與貨幣轉換 API，免費 100 次 API 請求/月。
  * [exchangerate-api.com](https://www.exchangerate-api.com) - 易於使用的匯率轉換 JSON API。免費方案每日更新一次，每月上限 1,500 次請求。
  * [FraudLabsPRO](https://www.fraudlabspro.com) — 協助商家預防支付詐欺與拒付。免費 Micro 方案每月 500 次查詢。
  * [FxRatesAPI](https://fxratesapi.com) — 提供即時與歷史匯率。免費方案需標註來源。
  * [Moesif API Monetization](https://www.moesif.com/) - 透過用量計費實現 API 變現。可串接 Stripe、Chargebee 等。免費方案每月 30,000 筆事件。
  * [Nami ML](https://www.namiml.com/) - 完整的 iOS 與 Android 應用內購買與訂閱平台，包含免程式碼付費牆、CRM 與分析。所有 IAP 事業基本功能免費。
  * [RevenueCat](https://www.revenuecat.com/) — 託管 iOS 與 Android 應用內購買與訂閱後端服務。每月追蹤營收 $2,500 內免費。
  * [vatlayer](https://vatlayer.com/) — 即時 VAT 號碼驗證與歐盟增值稅率 API，免費 100 次 API 請求/月
  * [Currencyapi](https://currencyapi.com) — 免費匯率轉換與匯率數據 API。每月 300 次請求，每分鐘 10 次，僅限私人用途。

**[⬆️ 返回頂部](#table-of-contents)**

## Docker 相關

  * [canister.io](https://canister.io/) — 開發者可擁有 20 個免費私有倉庫，團隊可擁有 30 個免費私有倉庫，用於建構及儲存 Docker 映像檔
  * [Container Registry Service](https://container-registry.com/) - 基於 Harbor 的容器管理解決方案。免費方案提供 1GB 私有倉庫空間。
  * [Docker Hub](https://hub.docker.com) — 提供一個免費私有倉庫與無限公共倉庫，用於建構及儲存 Docker 映像檔
  * [Play with Docker](https://labs.play-with-docker.com/) — 簡單、互動、有趣的 Docker 學習平台。
  * [quay.io](https://quay.io/) — 提供無限免費公共倉庫以建構與儲存容器映像檔
  * [ttl.sh](https://ttl.sh/) - 匿名且短暫的 Docker 映像檔註冊中心

**[⬆️ 返回頂部](#table-of-contents)**

## Vagrant 相關

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud。Vagrant box 託管平台。
  * [Vagrantbox.es](https://www.vagrantbox.es/) — 另類公開 box 索引

**[⬆️ 返回頂部](#table-of-contents)**

## 開發者部落格平台

  * [BearBlog](https://bearblog.dev/) - 極簡主義、支援 Markdown 的部落格與網站建置工具。
  * [Dev.to](https://dev.to/) - 程式設計師交流與成長的社群。
  * [Hashnode](https://hashnode.com/) — 開發者專用，無負擔的部落格平台。
  * [Medium](https://medium.com/) — 用更有想法的方式關注對你重要的事物。
  * [AyeDot](https://ayedot.com/) — 以現代多媒體短格式 Miniblogs 免費分享你的想法、知識與故事給全世界。

**[⬆️ 返回頂部](#table-of-contents)**

## 評論平台
  * [GraphComment](https://graphcomment.com/) - GraphComment 是一個評論平台，協助你從網站讀者打造活躍社群。
  * [Utterances](https://utteranc.es/) - 基於 GitHub Issues 的輕量級評論元件。可用於部落格評論、wiki 頁面等！
  * [Disqus](https://disqus.com/) - Disqus 是全球數十萬網站使用的網路社群評論平台。
  * [Remarkbox](https://www.remarkbox.com/) - 開源託管評論平台，「一位管理者可在數個網域完全控制行為與外觀」，採用隨喜付費。
  * [IntenseDebate](https://intensedebate.com/) - 提供豐富功能的評論系統，適用於 WordPress、Tumblr、Blogger 及其他多種網站平台。

**[⬆️ 返回頂部](#table-of-contents)**

## 截圖 API

  * [ApiFlash](https://apiflash.com) — 基於 AWS Lambda 與 Chrome 的截圖 API。支援整頁、捕捉時機與畫面尺寸自訂。
  * [microlink.io](https://microlink.io/) – 將任何網站轉換為資料，如 metatags 標準化、美化連結預覽、網頁擷取或截圖服務。每天免費 250 次請求。
  * [ScreenshotAPI.net](https://screenshotapi.net/) - 透過簡單 API 呼叫生成任何網站截圖。架構可擴展，託管於 Google Cloud。每月提供 100 張免費截圖。
  * [screenshotlayer.com](https://screenshotlayer.com/) — 捕捉高度可自訂的網站快照。每月免費 100 張快照
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — 每月可捕捉 100 張快照，支援 png、gif 和 jpg 格式，包括全頁截圖，非僅首頁
  * [PhantomJsCloud](https://PhantomJsCloud.com) — 瀏覽器自動化與網頁渲染。免費方案每日最多 500 頁，自 2017 年起免費。
  * [Webshrinker.com](https://webshrinker.com) — 提供網站截圖與網域情報 API 服務。每月免費 100 次請求。
  * [Screenshots](https://screenshotson.click) — 專為截圖設計的 API，支援高度自訂化。每月免費 100 張截圖。

**[⬆️ 返回頂部](#table-of-contents)**

## Flutter 相關及無 Mac 建置 IOS 應用

  * [FlutLab](https://flutlab.io/) - FlutLab 是現代化的 Flutter 線上 IDE，也是建立、除錯、建構跨平台專案的最佳場所。可用 Flutter 建置 iOS（無需 Mac）與 Android 應用。
  * [CodeMagic](https://codemagic.io/) - Codemagic 是全託管的移動應用 CI/CD 工具。可透過圖形介面建構、測試、部署。免費方案每月 500 分鐘，並提供 2.3GHz、8GB RAM 的 Mac Mini 實例。
  * [FlutterFlow](https://flutterflow.io/) - FlutterFlow 是基於瀏覽器的拖曳介面，利用 Flutter 建立行動應用程式。

**[⬆️ 返回頂部](#table-of-contents)**

## 基於瀏覽器、以 Javascript 實作的硬體模擬器

  * [JsLinux](https://bellard.org/jslinux) — 一個非常快速的 x86 虛擬機，可運行 Linux 和 Windows 2k。
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — 一個 OpenRISC 虛擬機，可運行支援網路的 Linux。
  * [v86](https://copy.sh/v86) — 一個 x86 虛擬機，可直接在瀏覽器運行 Linux 及其他作業系統。

**[⬆️ 返回頂部](#table-of-contents)**

## 隱私管理
  * [Bearer](https://www.bearer.sh/) - 透過稽核與持續工作流程，協助組織落實隱私設計，符合 GDPR 及其他法規。免費方案僅限小型團隊與 SaaS 版本。
  * [Osano](https://www.osano.com/) - 從 GDPR 代表到 Cookie 橫幅，一應俱全的同意管理與合規平台。免費方案提供基本功能。
  * [Iubenda](https://www.iubenda.com/) - 隱私與 Cookie 政策以及同意管理。免費方案提供有限的隱私與 Cookie 政策以及 Cookie 橫幅。
  * [Cookiefirst](https://cookiefirst.com/) - Cookie 橫幅、稽核與多語系同意管理方案。免費方案含一次掃描與單一橫幅。
  * [Ketch](https://www.ketch.com/) - 同意管理與隱私框架工具。免費方案提供大多數功能，但有訪客人數限制。
  * [Concord](https://www.concord.tech/) - 完整的資料隱私平台，包含同意管理、隱私請求處理（DSARs）、資料對應。免費方案包含核心同意管理功能，並對已驗證的開源專案提供更高級的免費方案。

**[⬆️ 回到頂部](#table-of-contents)**

## 其他雜項

  * [BackgroundStyler.com](https://backgroundstyler.com) - 創建你的程式碼、文字或圖片美學截圖，方便分享到社交媒體。
  * [BinShare.net](https://binshare.net) - 創建與分享程式碼或二進位檔。可作為精美圖片（如用於 Twitter / Facebook 貼文）或連結（如聊天或論壇）分享。
  * [Blynk](https://blynk.io) — 具 API 的 SaaS 平台，可控制、建構及評估 IoT 裝置。免費開發者方案可連接 5 個裝置，免費雲端與資料儲存。亦提供行動應用程式。
  * [Bricks Note Calculator](https://free.getbricks.app/) - 一款內建強大多行計算器的筆記應用程式（PWA）。
  * [Carbon.now.sh](https://carbon.now.sh) - 創建並分享程式碼片段為美觀的截圖型圖片格式。常用於在 Twitter 或部落格上美觀地分享/展示程式碼片段。
  * [Code Time](https://www.software.com/code-time) - VS Code、Atom、IntelliJ、Sublime Text 等編輯器的時間追蹤與程式碼度量擴充功能。
  * [Codepng](https://www.codepng.app) - 從原始碼創建優美快照，方便分享到社交媒體。
  * [CodeToImage](https://codetoimage.com/) - 創建程式碼或文字截圖，方便分享到社交媒體。
  * [Cronhooks](https://cronhooks.io/) - 定時或循環執行 webhook。免費方案允許 5 個臨時排程。
  * [cron-job.org](https://cron-job.org) - 線上 cron 任務服務。不限數量任務免費使用。
  * [datelist.io](https://datelist.io) - 線上預約／預訂系統。每月最多 5 筆預訂免費，包含 1 個行事曆。
  * [Domain Forward](https://domain-forward.com/) - 簡單易用的 URL 或網域轉址工具。免費可用於 5 個網域及每月 20 萬次請求。
  * [Elementor](https://elementor.com) — WordPress 網站建構器。免費方案提供 40+ 基本元件。
  * [Exif Editor](https://exifeditor.io/) — 瀏覽、編輯、刪除、分析圖片/相片的即時元資料（包含 GPS 位置與 meta 資訊）。
  * [Format Express](https://www.format-express.dev) - 即時線上格式化 JSON / XML / SQL。
  * [FOSSA](https://fossa.com/) - 可擴展的第三方程式碼、授權合規與漏洞的端到端管理。
  * [Hook Relay](https://www.hookrelay.dev/) - 無痛為應用程式新增 webhook 支援：自動排隊、重試退避、日誌記錄。免費方案每日 100 次傳送、資料保留 14 天、3 個 webhook 端點。
  * [Hosting Checker](https://hostingchecker.co) - 查詢任何網域、網站或 IP 的主機資訊，如 ASN、ISP、地點等，並包含多項主機與 DNS 工具。
  * [http2.pro](https://http2.pro) — HTTP/2 協定就緒度測試及用戶端 HTTP/2 支援偵測 API。
  * [kandi](https://kandi.openweaver.com/) — 加速應用程式開發：透過程式碼片段與開源庫重用，快速構建自訂功能、用例及完整應用。
  * [Base64 decoder/encoder](https://devpal.co/base64-decode/) — 免費線上 Base64 編碼/解碼工具。
  * [newreleases.io](https://newreleases.io/) - 於 GitHub、GitLab、Bitbucket、Python PyPI、Java Maven、Node.js NPM、Node.js Yarn、Ruby Gems、PHP Packagist、.NET NuGet、Rust Cargo 與 Docker Hub 發布新版本時，透過 email、Slack、Telegram、Discord 或自訂 webhook 通知。
  * [OnlineExifViewer](https://onlineexifviewer.com/) — 線上即時查看圖片的 EXIF 資料，包括 GPS 位置及 meta 資訊。
  * [PDFMonkey](https://www.pdfmonkey.io/) — 在儀表板中管理 PDF 範本，以動態資料呼叫 API 並下載 PDF。每月提供 300 份免費文件。
  * [Pika Code Screenshots](https://pika.style/templates/code-image) — 透過擴充套件，從程式碼片段與 VSCode 創建美觀且可自訂的截圖。
  * [QuickType.io](https://quicktype.io/) - 從 JSON、schema 與 GraphQL 快速自動生成模型/類型/介面與序列化器，在各種程式語言中安全快速處理資料。將 JSON 轉換為美觀且型別安全的程式碼。
  * [RandomKeygen](https://randomkeygen.com/) - 免費且適用於行動裝置的隨機金鑰與密碼產生器，可用於保護各種應用、服務或裝置。
  * [ray.so](https://ray.so/) - 創建美觀的程式碼片段圖片。
  * [readme.com](https://readme.com/) — 輕鬆製作美觀文件，開源專案免費。
  * [redirection.io](https://redirection.io/) — 為企業、行銷與 SEO 管理 HTTP 轉址的 SaaS 工具。
  * [redirect.ing](https://redirect.ing/) - 快速安全的網域轉址，無需管理伺服器或 SSL 憑證。免費方案包含 10 個主機名稱與每月 10 萬次請求。
  * [redirect.pizza](https://redirect.pizza/) - 輕鬆管理轉址並支援 HTTPS。免費方案包含 10 個來源與每月 10 萬次訪問。
  * [ReqBin](https://reqbin.com/) — 線上發送 HTTP 請求。支援 GET、POST、PUT、DELETE、HEAD 等常見方法，亦支援標頭與 Token 認證。提供基本登入系統以儲存請求。
  * [Smartcar API](https://smartcar.com) - 車輛用 API，可查詢位置、油箱或電池電量、里程、解鎖/鎖門等功能。
  * [snappify](https://snappify.com) - 協助開發者創建令人驚豔的視覺效果。從美觀的程式碼片段到完整的技術簡報。免費方案可同時有最多 3 個快照，下載不限次數，每月 5 次 AI 程式碼解說。
  * [Sunrise and Sunset](https://sunrisesunset.io/api/) - 取得指定經緯度的日出日落時間。
  * [superfeedr.com](https://superfeedr.com/) — 即時 PubSubHubbub 相容的 feed、匯出與分析。免費方案功能較少。
  * [SurveyMonkey.com](https://www.surveymonkey.com) — 建立線上問卷並線上分析結果。免費方案每份問卷限 10 題、100 份回覆。
  * [Tiledesk](https://tiledesk.com) - 創建聊天機器人與對話應用，支援多渠道：從網站（即時聊天小工具）到 WhatsApp。免費方案不限聊天機器人數量。
  * [Versionfeeds](https://versionfeeds.com) — 為你喜愛的軟體建立自訂 RSS 發佈訂閱，將常用程式語言、函式庫或工具的最新版本集中於一個 feed。（前三個 feed 免費）
  * [videoinu](https://videoinu.com) — 線上製作與編輯螢幕錄影及其他影片。
  * [Webacus](https://webacus.dev) — 提供多種免費開發工具，如編碼、解碼與資料處理。

**[⬆️ 回到頂部](#table-of-contents)**

## 遠端桌面工具

  * [Getscreen.me](https://getscreen.me) — 免費支援 2 台裝置，連線次數與時長不限
  * [Apache Guacamole™](https://guacamole.apache.org/) — 開源無客戶端遠端桌面閘道器
  * [RemSupp](https://remsupp.com) — 隨選支援與永久連接裝置（每天 2 次免費連線）
  * [RustDesk](https://rustdesk.com/) - 開源虛擬／遠端桌面基礎架構，適用於所有人！
  * [AnyDesk](https://anydesk.com) — 免費支援 3 台裝置，連線次數與時長不限

**[⬆️ 回到頂部](#table-of-contents)**

## 遊戲開發

  * [itch.io](https://itch.io/game-assets) — 免費／付費資產，如精靈圖、圖塊集、角色包。
  * [Gamefresco.com](https://gamefresco.com/) — 發掘、收集與分享來自全球遊戲美術的免費遊戲資產。
  * [GameDevMarket](https://gamedevmarket.net) — 免費／付費資產，如 2D、3D、音效、GUI。
  * [OpenGameArt](https://opengameart.org) — 開源遊戲資產，如音樂、音效、精靈圖、GIF。
  * [CraftPix](https://craftpix.net) — 免費／付費資產，如 2D、3D、音效、GUI、背景、圖示、圖塊集、遊戲套件。
  * [Game Icons](https://game-icons.net/) - 提供 CC-BY 授權的免費可自訂 SVG/PNG 圖示。
  * [LoSpec](https://lospec.com/) — 線上像素美術與數位限量藝術工具，並有豐富教學與調色盤可供遊戲選用。
  * [ArtStation](https://www.artstation.com/) - 免費／付費 2D、3D 資產、市集與音效、圖示、圖塊集、遊戲套件，亦可展示你的美術作品集。
  * [Rive](https://rive.app/community/) - 社群資產與自行創建遊戲資產，免費方案可用。
  * [Poly Pizza](https://poly.pizza/) - 免費低面數 3D 資產。
  * [3Dassets.one](https://3dassets.one/) - 超過 8,000 個免費／付費 3D 模型與 PBR 材質可用於貼圖。
  * [Kenney](https://www.kenney.nl/assets/) - 免費（CC0 1.0 Universal 授權）2D、3D、音效與 UI 遊戲資產。
  * [Poliigon](https://www.poliigon.com/) - 免費與付費材質（解析度可選）、模型、HDRI 與筆刷，提供 Blender 等軟體外掛。
  * [Freesound](https://freesound.org/) - 提供各種 CC 授權的免費協作音效庫。

**[⬆️ 回到頂部](#table-of-contents)**

## 其他免費資源

  * [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - 永久免費的網頁開發工具，包括 CSS 壓縮／還原、圖片優化、圖片縮放、大小寫轉換、CSS 驗證、JavaScript 編譯、HTML 編輯器等。
  * [ElevateAI](https://www.elevateai.com) - 每月可免費取得最多 200 小時音訊轉錄額度。
  * [get.localhost.direct](https://get.localhost.direct) — 更好的 `*.localhost.direct` 萬用公用 CA 簽發 SSL 憑證，支援本地開發與子網域。
  * [Framacloud](https://degooglisons-internet.org/en/) — 法國非營利組織 [Framasoft](https://framasoft.org/en/) 提供的自由／開源軟體與 SaaS 清單。
  * [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — 開發者專用的免費與開源軟體集散地。
  * [GitHub Education](https://education.github.com/pack) — 學生專屬免費服務組合，需註冊。
  * [Markdown Tools](https://markdowntools.com) - 將 HTML、CSV、PDF、JSON 與 Excel 檔案互轉 Markdown 的工具
  * [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — 提供免費沙箱、開發工具及建構 Microsoft 365 平台解決方案的資源。訂閱為 90 天 [Microsoft 365 E5 訂閱](https://www.microsoft.com/microsoft-365/enterprise/e5)（不含 Windows），可續期。只要活躍開發（依據遙測與演算法判斷）即可自動續期。
  * [Pyrexp](https://pythonium.net/regex) — 免費線上正則表達式測試與視覺化工具，方便除錯。
  * [RedHat for Developers](https://developers.redhat.com) — 專為開發者提供的 Red Hat 產品免費存取，包括 RHEL、OpenShift、CodeReady 等。僅限個人方案。亦提供免費電子書參考。
  * [smsreceivefree.com](https://smsreceivefree.com/) — 提供免費臨時與一次性電話號碼。
  * [sandbox.httpsms.com](https://sandbox.httpsms.com) — 免費發送與接收測試 SMS 簡訊。
  * [SimpleBackups.com](https://simplebackups.com/) — 自動備份伺服器與資料庫（MySQL、PostgreSQL、MongoDB），直接儲存至雲端（AWS、DigitalOcean、Backblaze）。免費方案可備份 1 個資源。
  * [SnapShooter](https://snapshooter.com/) — DigitalOcean、AWS、LightSail、Hetzner、Exoscale 備份解決方案，支援直接備份資料庫、檔案系統與應用至 s3 儲存。免費方案可為一個資源每日備份。
  * [Themeselection](https://themeselection.com/) — 精選高品質、現代設計、專業且易用的免費管理後台模板、HTML 主題與 UI 套件，加速應用開發！
  * [Web.Dev](https://web.dev/measure/) — 免費檢測網站效能並優化 SEO，助你在搜尋引擎獲得更高排名。
  * [SmallDev.tools](https://smalldev.tools/) — 一個免費的開發者工具，允許你編碼/解碼各種格式、壓縮 HTML/CSS/Javascript、美化、生成假的/測試用資料集（JSON/CSV 及多種格式）等多項功能。介面精美。
  * [UseCSV by Layercode](https://layercode.com/usecsv) — 在幾分鐘內為你的網頁應用新增 CSV 和 Excel 匯入功能。為用戶提供愉快且穩定的資料匯入體驗。無需信用卡即可免費開始，立即集成 UseCSV。可創建無限匯入器，單檔案最大上傳 100Mb。
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — 100+ 個可用於專案的按鈕。
  * [WrapPixel](https://www.wrappixel.com/) — 下載由 Angular、React、VueJs、NextJS、NuxtJS 創建的高品質免費與付費管理後台模板！
  * [Utils.fun](https://utils.fun/en) — 全部工具基於瀏覽器運算能力，離線運作，包括浮水印生成、螢幕錄製、編碼與解碼、加解密、程式碼格式化等，完全免費且不會將資料上傳雲端處理。
  * [It tools](it-tools.tech) - 專為開發者和 IT 人員設計的實用工具。
  * [Free Code Tools](https://freecodetools.org/) — 100% 免費且實用的程式碼工具。Markdown 編輯器、程式碼壓縮/美化、QR 碼生成器、Open Graph 生成器、Twitter 卡片生成器等。
  * [regex101](https://regex101.com/) — 免費網站，可測試和除錯正則表達式（regex）。提供 regex 編輯器、測試器，以及學習資源和說明文件。
  * [Kody Tools](https://www.kodytools.com/dev-tools) — 100+ 開發工具，包含格式化、壓縮、轉換器等。
  * [AdminMart](https://adminmart.com/) — 由 Angular、Bootstrap、React、VueJs、NextJS、NuxtJS 創建的高品質免費與付費管理後台和網站模板！
  * [Glob tester](https://globster.xyz/) — 一個可以設計和測試 glob 模式的網站，同時提供學習 glob 模式的資源。
  * [SimpleRestore](https://simplerestore.io) - 無需程式碼或伺服器，輕鬆將 MySQL 備份恢復到任何遠端資料庫。
  * [360Converter](https://www.360converter.com/) - 免費層級網站，支援：影片轉文字、音訊轉文字、語音轉文字、即時音訊轉文字、YouTube 影片轉文字及影片加字幕。對於短影片或短教學影片轉換很有幫助。
  * [QRCodeBest](https://qrcode.best/) - 自訂 QR 碼生成，13 種模板、完整隱私與個人品牌功能。支援追蹤像素、專案分類及 QRCode.Best 上無限團隊席次。
  * [PostPulse](https://PostPulseAI.com) - 提升線上曝光度，利用 AI 每月生成貼文至 SEO 優化網域，增強 SEO 與網站排名。免費方案允許每月手動發佈一篇貼文。
  * [PageTools](https://pagetools.co/) - 提供一套永久免費的 AI 工具，協助生成網站政策、建立社群媒體簡介、貼文與網頁，只需一鍵完成。
  * [MySQL Visual Explain](https://mysqlexplain.com) - 易於理解且免費的 MySQL EXPLAIN 輸出視覺化工具，協助優化慢查詢。
  * [Killer Coda](https://killercoda.com/)  - 在瀏覽器中互動學習 Linux、Kubernetes、容器、程式設計、DevOps、網路等。
  * [Axonomy App](https://axonomy-app.com/) - 免費開立、管理與分享發票給客戶，每月 10 份免費發票。
  * [Table Format Converter](https://www.tableformatconverter.com) - 免費表格資料轉換工具，支援 CSV、HTML、JSON、Markdown 等多種格式轉換。


**[⬆️ 回到頂部](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---