# free-for.dev

开发者和开源作者现在有许多提供免费层级的服务，但要找到所有这些服务，并做出明智决策需要花费时间。

这是一个包含软件（SaaS、PaaS、IaaS 等）和其他提供免费开发者层级的服务列表。

本列表的范围专注于基础设施开发者（系统管理员、DevOps 实践者等）可能会觉得有用的内容。我们喜欢所有免费的服务，但希望能保持主题相关。有时界限并不明显，因此这里会带有一些主观性；如果您的贡献未被接受，请不要介意。

本列表由 1600 多位参与者通过 Pull Requests、评审、创意和努力协作完成。您也可以通过提交 [Pull Requests](https://github.com/ripienaar/free-for-dev) 来帮助添加更多服务，或移除那些服务内容已更改或已下线的条目。

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**注意**：本列表仅包含即服务（as-a-Service）类型的产品，不包括自托管软件。要符合条件，服务必须提供免费层级，而不仅仅是免费试用。如果免费层级有时间限制，则至少需一年。我们也会从安全角度考虑免费层级，SSO 没问题，但不会接受只在付费层级开放 TLS 的服务。

# 目录

  * [主流云服务商永久免费额度](#major-cloud-providers)
  * [云管理解决方案](#cloud-management-solutions)
  * [分析、事件与统计](#analytics-events-and-statistics)
  * [API、数据和机器学习](#apis-data-and-ml)
  * [制品仓库](#artifact-repos)
  * [后端即服务（BaaS）](#baas)
  * [低代码平台](#low-code-platform)
  * [CDN 与防护](#cdn-and-protection)
  * [CI/CD](#ci-and-cd)
  * [内容管理系统（CMS）](#cms)
  * [代码生成](#code-generation)
  * [代码质量](#code-quality)
  * [代码搜索与浏览](#code-search-and-browsing)
  * [崩溃与异常处理](#crash-and-exception-handling)
  * [地图数据可视化](#data-visualization-on-maps)
  * [托管数据服务](#managed-data-services)
  * [设计与 UI](#design-and-ui)
  * [设计灵感](#design-inspiration)
  * [开发者博客平台](#dev-blogging-sites)
  * [DNS](#dns)
  * [Docker 相关](#docker-related)
  * [域名](#domain)
  * [教育与职业发展](#education-and-career-development)
  * [电子邮件](#email)
  * [功能开关管理平台](#feature-toggles-management-platforms)
  * [字体](#font)
  * [表单](#forms)
  * [生成式 AI](#generative-ai)
  * [IaaS](#iaas)
  * [IDE 与代码编辑](#ide-and-code-editing)
  * [国际手机号验证 API 和 SDK](#international-mobile-number-verification-api-and-sdk)
  * [问题追踪与项目管理](#issue-tracking-and-project-management)
  * [日志管理](#log-management)
  * [移动应用分发与反馈](#mobile-app-distribution-and-feedback)
  * [管理系统](#management-system)
  * [消息与流处理](#messaging-and-streaming)
  * [其他杂项](#miscellaneous)
  * [监控](#monitoring)
  * [PaaS](#paas)
  * [软件包构建系统](#package-build-system)
  * [支付与账单集成](#payment-and-billing-integration)
  * [隐私管理](#privacy-management)
  * [截图 API](#screenshot-apis)
  * [Flutter 相关与无 Mac 构建 IOS 应用](#flutter-related-and-building-ios-apps-without-mac)
  * [搜索](#search)
  * [安全与 PKI](#security-and-pki)
  * [认证、授权与用户管理](#authentication-authorization-and-user-management)
  * [源代码仓库](#source-code-repos)
  * [存储与媒体处理](#storage-and-media-processing)
  * [隧道、WebRTC、WebSocket 服务器及其他路由](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [测试](#testing)
  * [团队协作工具](#tools-for-teams-and-collaboration)
  * [翻译管理](#translation-management)
  * [Vagrant 相关](#vagrant-related)
  * [访客会话录制](#visitor-session-recording)
  * [网站托管](#web-hosting)
  * [评论平台](#commenting-platforms)
  * [基于浏览器的硬件仿真](#browser-based-hardware-emulation-written-in-javascript)
  * [远程桌面工具](#remote-desktop-tools)
  * [游戏开发](#game-development)
  * [其他免费资源](#other-free-resources)

## 主流云服务商

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 每天 28 小时前端实例，9 小时后端实例
    * Cloud Firestore - 1GB 存储、每天 50,000 次读取、20,000 次写入、20,000 次删除
    * Compute Engine - 1 个非可抢占 e2-micro 实例，30GB HDD，5GB 快照存储（限部分区域），每月从北美到所有区域目的地（不包括中国和澳大利亚）1GB 网络出口流量
    * Cloud Storage - 5GB 存储，1GB 网络出口流量
    * Cloud Shell - 基于 Web 的 Linux shell/主 IDE，带 5GB 永久存储。每周限用 60 小时
    * Cloud Pub/Sub - 每月 10GB 消息
    * Cloud Functions - 每月 200 万次调用（包括后台和 HTTP 调用）
    * Cloud Run - 每月 200 万次请求，360,000 GB-秒内存，180,000 vCPU-秒计算时间，每月从北美 1GB 网络出口流量
    * Google Kubernetes Engine - 一个区域集群免收集群管理费。每个用户节点按标准 Compute Engine 价格收费
    * BigQuery - 每月 1TB 查询，10GB 存储
    * Cloud Build - 每天 120 分钟构建时间
    * Cloud Source Repositories - 最多 5 名用户，50GB 存储，50GB 出口流量
    * [Google Colab](https://colab.research.google.com/) - 免费 Jupyter Notebooks 开发环境。
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio（前身为 Project IDX）。运行在 Google Cloud 上的在线 VSCode。
    * 全部详细列表 - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 每月 1TB 出口流量，每月 200 万次函数调用
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 个自定义指标和 10 个警报
* [CodeBuild](https://aws.amazon.com/codebuild/) - 每月100分钟构建时间  
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5个活跃用户，50GB存储，每月10000次请求  
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 每月1个活跃流水线  
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GB NoSQL数据库  
* [EC2](https://aws.amazon.com/ec2/) - 每月750小时t2.micro或t3.micro（12个月）。每月100GB外部流量  
* [EBS](https://aws.amazon.com/ebs/) - 每月30GB通用型（SSD）或磁性（12个月）  
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 每月750小时（12个月）  
* [RDS](https://aws.amazon.com/rds/) - 每月750小时db.t2.micro、db.t3.micro或db.t4g.micro，20GB通用型（SSD）存储，20GB备份存储（12个月）  
* [S3](https://aws.amazon.com/s3/) - 5GB标准对象存储，2万次Get请求和2千次Put请求（12个月）  
* [Glacier](https://aws.amazon.com/glacier/) - 10GB长期对象存储  
* [Lambda](https://aws.amazon.com/lambda/) - 每月100万次请求  
* [SNS](https://aws.amazon.com/sns/) - 每月100万次发布  
* [SES](https://aws.amazon.com/ses/) - 每月3,000封邮件（12个月）  
* [SQS](https://aws.amazon.com/sqs/) - 每月100万次消息队列请求  
* 完整详细列表 - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)  
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1台B1S Linux虚拟机，1台B1S Windows虚拟机（12个月）  
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10个Web、移动或API应用（每日60分钟CPU）  
  * [Functions](https://azure.microsoft.com/services/functions/) - 每月100万次请求  
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - 提供快速、简便、轻量的开发测试环境  
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500,000个对象  
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 每月5万存储用户  
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5个活跃用户，无限私有Git仓库  
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 针对Linux、macOS和Windows的开源项目，提供10个免费并行作业和无限分钟数  
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 每天8,000条消息  
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1个免费公网负载均衡IP（VIP）  
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 100万次推送通知  
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15GB入站流量（12个月）及每月5GB出站流量  
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GB存储和1000 RUs预配置吞吐量  
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — 构建、部署并托管静态应用和无服务器函数，免费SSL，认证/授权及自定义域名  
  * [Storage](https://azure.microsoft.com/services/storage/) - 5GB LRS文件或Blob存储（12个月）  
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - AI/ML API（计算机视觉、翻译、面部识别、Bot等），免费层包含有限交易量  
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - 基于AI的搜索和索引服务，免费支持10,000份文档  
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - 托管型Kubernetes服务，免费集群管理  
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 每月100,000次操作  
  * 完整详细列表 - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)  
  * 计算  
     - 2台基于AMD的计算虚拟机，每台配1/8 OCPU和1GB内存  
     - 4核基于Arm的Ampere A1，24GB内存，可作为1台虚拟机或最多4台虚拟机使用  
     - 实例在[被认定为空闲](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)时将被回收  
  * 块存储 - 2个卷，共200GB（用于计算）  
  * 对象存储 - 10GB  
  * 负载均衡 - 1实例，10Mbps  
  * 数据库 - 2个数据库，每个20GB  
  * 监控 - 5亿条数据采集点，10亿条数据检索点  
  * 带宽 - 每月10TB出站流量，x64虚拟机限速50Mbps，ARM虚拟机带宽500Mbps*核数  
  * 公网IP - 虚拟机2个IPv4，负载均衡1个IPv4  
  * 通知 - 每月100万次投递选项，每月1000封邮件  
  * 完整详细列表 - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)  
  * Cloudant数据库 - 1GB数据存储  
  * Db2数据库 - 100MB数据存储  
  * API Connect - 每月50,000次API调用  
  * 可用性监控 - 每月300万数据点  
  * 日志分析 - 每天500MB日志  
  * 完整详细列表 - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)  
  * [应用服务](https://www.cloudflare.com/plans/) - 为无限数量域名提供免费DNS、DDoS防护、CDN及免费SSL、防火墙规则和页面规则，WAF，Bot防护，免费不限量速率限制（每域名1条规则），分析，邮件转发  
  * [零信任与SASE](https://www.cloudflare.com/plans/zero-trust-services/) - 最多50用户，24小时活动日志，3个网络位置  
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - 可通过隧道将本地运行的HTTP端口暴露到trycloudflare.com随机子域名，[Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/)无需账号即可使用。更多功能（TCP隧道、负载均衡、VPN）请参见[Zero Trust](https://www.cloudflare.com/products/zero-trust/)免费计划。  
  * [Workers](https://developers.cloudflare.com/workers/) - 在Cloudflare全球网络免费部署无服务器代码——每天10万次请求。  
  * [Workers KV](https://developers.cloudflare.com/kv) - 每天10万次读请求，1000次写请求，1000次删除请求，1000次列表请求，1GB存储数据  
  * [R2](https://developers.cloudflare.com/r2/) - 每月10GB，A类操作每月100万次，B类操作每月1000万次  
  * [D1](https://developers.cloudflare.com/d1/) - 每天读取500万行，写入10万行，1GB存储  
  * [Pages](https://developers.cloudflare.com/pages/) - 在Cloudflare快速安全的全球网络上开发并部署Web应用。每月500次构建，100个自定义域名，集成SSL，无限协作成员，无限预览部署，通过Cloudflare Workers集成实现全栈能力。  
  * [Queues](https://developers.cloudflare.com/queues/) - 每月100万次操作  
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 每月1TB免费（出站）流量。

**[⬆️ 返回顶部](#table-of-contents)**

## 云管理解决方案

* [Brainboard](https://www.brainboard.co) - 协作式解决方案，可端到端可视化构建和管理云基础设施。  
* [Cloud 66](https://www.cloud66.com/) - 个人项目免费（包含一个部署服务器和一个静态站点），Cloud 66 为你提供在任意云构建、部署和扩展应用所需的一切，无需处理“服务器相关”难题。  
* [Pulumi](https://www.pulumi.com/) — 现代基础设施即代码平台，允许你使用熟悉的编程语言和工具构建、部署和管理云基础设施。  
* [terraform.io](https://www.terraform.io/) — Terraform Cloud。免费支持最多500资源的远程状态管理和团队协作。  
* [scalr.com](https://scalr.com/) - Scalr 是一款Terraform自动化与协作（TACO）产品，用于提升Terraform管理的基础设施与配置的协作和自动化。支持完整Terraform CLI、OPA集成和分层配置模型。无SSO费用，全部功能包含。每月可免费使用50次运行。  
* [deployment.io](https://deployment.io) - Deployment.io 帮助开发者在AWS上自动化部署。在我们的免费套餐下，开发者（单用户）可无限部署静态站点、Web服务和环境。每月免费提供20次任务执行，包含预览和自动部署。

**[⬆️ 返回顶部](#table-of-contents)**

## 源代码仓库

* [Bitbucket](https://bitbucket.org/) — 最多5用户无限公共和私有Git仓库，支持Pipelines进行CI/CD  
* [chiselapp.com](https://chiselapp.com/) — 无限公共和私有Fossil仓库  
* [codebasehq.com](https://www.codebasehq.com/) — 1个免费项目，100MB空间，2个用户  
* [Codeberg](https://codeberg.org/) — 免费和开源项目无限公共和私有Git仓库（无限协作者）。由[Forgejo](https://forgejo.org/)驱动。支持[Codeberg Pages](https://codeberg.page/)静态网站托管，[Codeberg's CI](https://docs.codeberg.org/ci/)进行CI/CD，[Codeberg Translate](https://translate.codeberg.org/)翻译托管。包含包和容器托管、项目管理和问题追踪  
* [GitGud](https://gitgud.io) — 无限私有和公共仓库，永久免费。由GitLab & Sapphire驱动。不提供CI/CD。  
* [GitHub](https://github.com/) — 无限公共仓库和无限私有仓库（无限协作者）。包含CI/CD、开发环境、静态托管、包和容器托管、项目管理和AI Copilot  
* [gitlab.com](https://about.gitlab.com/) — 无限公共和私有Git仓库，最多5个协作者。包含CI/CD、静态托管、容器注册、项目管理和问题追踪  
* [framagit.org](https://framagit.org/) — Framagit是基于Gitlab软件的Framasoft代码托管平台，包含CI、静态页面、项目页面和问题追踪。  
* [heptapod.net](https://foss.heptapod.net/) — Heptapod是GitLab社区版的友好分支，支持Mercurial  
* [ionicframework.com](https://ionicframework.com/appflow) - 用于Ionic应用开发的仓库和工具，也可提供ionic仓库  
* [NotABug](https://notabug.org) — NotABug.org是自由软件项目的免费代码协作平台，基于Git  
* [OSDN](https://osdn.net/) - OSDN.net是为开源软件开发者提供的免费服务，支持SVN/Git/Mercurial/Bazaar/CVS仓库。
  * [Pagure.io](https://pagure.io) — Pagure.io 是一个免费且开源的软件代码协作平台，适用于 FOSS 许可项目，基于 Git。
  * [perforce.com](https://www.perforce.com/products/helix-teamhub) — 免费 1GB 云端空间，支持 Git、Mercurial 或 SVN 仓库。
  * [pijul.com](https://pijul.com/) - 无限免费且开源的分布式版本控制系统。其独特功能基于完善的补丁理论，使其易于学习、使用和分发。解决了 git/hg/svn/darcs 的许多问题。
  * [plasticscm.com](https://plasticscm.com/) — 对个人、开源软件和非营利组织免费
  * [projectlocker.com](https://projectlocker.com) — 免费提供一个私有项目（Git 和 Subversion），空间为 50 MB
  * [RocketGit](https://rocketgit.com) — 基于 Git 的仓库托管。无限制的公开和私有仓库。
  * [savannah.gnu.org](https://savannah.gnu.org/) - 为自由软件项目（GNU 项目）提供协作式软件开发管理系统
  * [savannah.nongnu.org](https://savannah.nongnu.org/) - 为自由软件项目（非 GNU 项目）提供协作式软件开发管理系统

**[⬆️ 返回顶部](#table-of-contents)**

## APIs、数据与机器学习

  * [JSONGrid](https://jsongrid.com) - 免费工具，可将复杂 JSON 数据可视化、编辑、筛选为美观的表格网格。可通过链接保存和分享 JSON 数据。
  * [Zerosheets](https://zerosheets.com) - 将您的 Google Sheets 电子表格转化为强大的 API，以便快速开发原型、网站、应用等。每月免费 500 次请求。
  * [IP.City](https://ip.city) — 每天免费 100 次 IP 地理定位请求
  * [Abstract API](https://www.abstractapi.com) — 用于多种用例的 API 套件，包括 IP 地理定位、性别检测或邮箱验证。
  * [Apify](https://www.apify.com/) — 网站爬取与自动化平台，可为任意网站创建 API 并提取数据。提供现成爬虫、集成代理和定制方案。免费计划每月包含 $5 平台额度。
  * [APITemplate.io](https://apitemplate.io) - 通过简单 API 或自动化工具（如 Zapier & Airtable）自动生成图片和 PDF 文档，无需 CSS/HTML。免费计划每月 50 张图片和三个模板。
  * [APIToolkit.io](https://apitoolkit.io) - 提供全面了解 API 和后端运行状况所需的所有工具，自动 API 合同验证与监控。免费计划支持最多每天 10,000 次请求的服务器。
  * [APIVerve](https://apiverve.com) - 免费即时访问 120+ 个高质量、稳定、可靠的 API。免费计划每月最多 50 个 API 令牌。（可能已下线，2025-06-25）
  * [Arize AI](https://arize.com/) - 机器学习可观测平台，用于模型监控及定位数据质量和性能漂移等问题。免费支持最多两个模型。
  * [Maxim AI](https://getmaxim.ai/) - 模拟、评估并观测您的 AI agent。Maxim 是端到端的评估与可观测平台，帮助团队更可靠且快五倍以上地部署 AI agent。个人开发者及小团队（3 个席位）永久免费。
  * [Beeceptor](https://beeceptor.com) - 秒级创建 REST API，模拟 API 响应等。免费 50 次每日请求，公开仪表板，开放端点（任何拥有仪表板链接的人都可查看提交和答案）。
  * [BigDataCloud](https://www.bigdatacloud.com/) - 提供针对现代 Web 的快速、精准且免费的（不限量或每月 1 万-5 万次）API，如 IP 地理定位、反向地理编码、网络分析、邮箱和电话验证、客户端信息等。
  * [Browse AI](https://www.browse.ai) — 网页数据抓取与监控。每月免费 1,000 积分，相当于 1,000 并发请求。
  * [BrowserCat](https://www.browsercat.com) - 无头浏览器 API，用于自动化、爬取、AI agent 网页访问、生成图片/PDF 等。免费计划每月 1,000 次请求。
  * [Calendarific](https://calendarific.com) - 企业级公共假期 API，覆盖 200 多个国家。免费计划每月 500 次调用。
  * [Canopy](https://www.canopyapi.co/) - 针对 Amazon.com 产品、搜索和分类数据的 GraphQL API。免费计划每月 100 次调用。
  * [Clarifai](https://www.clarifai.com) — 图像 API，支持自定义人脸识别与检测。可训练 AI 模型。免费计划每月 1,000 次调用。
  * [Cloudmersive](https://cloudmersive.com/) — 实用 API 平台，全面访问丰富的 API 库，包括文档转换、病毒扫描等，每月 600 次调用，仅限北美 AZ，最大文件 2.5MB。
  * [Colaboratory](https://colab.research.google.com) — 免费的基于 Web 的 Python 笔记本环境，配备 Nvidia Tesla K80 GPU。
  * [CometML](https://www.comet.com/site/) - MLOps 平台，支持实验追踪、模型生产管理、模型注册和完整数据溯源，覆盖从训练到生产的工作流。个人和学术用户免费。
  * [Commerce Layer](https://commercelayer.io) - 可组合的电商 API，支持从任意前端构建、下单和管理订单。开发者计划每月可下 100 单，最多 1,000 个 SKU，免费。
  * [Composio](https://composio.dev/) - 用于 AI Agent 和 LLM 的集成平台。支持集成 200+ 工具，贯通智能互联网。
  * [Conversion Tools](https://conversiontools.io/) - 在线文件转换工具，支持文档、图片、视频、音频和电子书。提供 REST API。支持 Node.js、PHP、Python 库。付费计划支持最大 50 GB 文件。免费层文件大小限制为 20MB，转换次数限制为每日 30 次、每月 300 次。
  * [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API 与微服务，提供国家、地区、省份、城市、邮编等多种信息。免费层每日最多 100 次请求。
  * [Coupler](https://www.coupler.io/) - 数据集成工具，可实现应用间同步。可创建实时仪表板与报表，转化和处理数据，收集和备份洞察。免费计划限制为 1 个用户、数据连接、数据源和数据目的地，且需手动刷新数据。
  * [CraftMyPDF](https://craftmypdf.com) - 通过可拖拽编辑器和简单 API，从可复用模板自动生成 PDF 文档。免费计划每月 100 份 PDF 和三个模板。
  * [Crawlbase](https://crawlbase.com/) — 无需代理、基础设施或浏览器即可爬取和抓取网站。自动解决验证码，避免被封锁。首 1,000 次调用免费。
  * [CurlHub](https://curlhub.io) — 用于 API 调用检查和调试的代理服务。免费计划每月 10,000 次请求。
  * [CurrencyScoop](https://currencyscoop.com) - 面向金融科技应用的实时货币数据 API。免费计划每月 5,000 次调用。
  * [Cube](https://cube.dev/) - Cube 帮助数据工程师和应用开发者访问现代数据存储，将数据组织为一致定义，并分发到每个应用。Cube Cloud 免费层每日限 1,000 次查询。
  * [Data Dead Drop](https://datadeaddrop.com) - 简单、免费的文件分享。数据访问后自动销毁。支持通过浏览器或任意命令行客户端上传和下载。
  * [Data Fetcher](https://datafetcher.com) - 无需代码即可将 Airtable 连接至任意应用或 API。在 Airtable 内以 Postman 类界面运行 API 请求。提供数十种预构建集成。免费计划每月 100 次运行。
  * [Dataimporter.io](https://www.dataimporter.io) - 连接、清洗并导入数据到 Salesforce 的工具。免费计划每月最多 2 万条记录。
  * [Datalore](https://datalore.jetbrains.com) - Jetbrains 推出的 Python 笔记本。每月包含 10 GB 存储和 120 小时运行时。
  * [Data Miner](https://dataminer.io/) - 浏览器插件（Google Chrome、MS Edge），支持从网页提取数据为 CSV 或 Excel。免费计划每月 500 页。
  * [Datapane](https://datapane.com) - 用于 Python 构建交互式报表的 API，并将 Python 脚本和 Jupyter Notebook 部署为自助工具。
  * [DB-IP](https://db-ip.com/api/free) - 免费 IP 地理定位 API，每个 IP 每天 1,000 次请求。lite 数据库（CC-BY 4.0 协议）也免费。
  * [DB Designer](https://www.dbdesigner.net/) — 基于云的数据库模式设计与建模工具，免费入门计划可创建 2 个数据库模型，每个模型 10 张表。
  * [DeepAR](https://developer.deepar.ai) — 任意平台的增强现实人脸滤镜 SDK。免费计划每月最多 10 个活跃用户（MAU），最多跟踪 4 张人脸。
  * [Deepnote](https://deepnote.com) - 新一代数据科学笔记本。兼容 Jupyter，支持实时协作与云端运行。免费层支持无限个人项目、无限基础机器（5GB RAM、2vCPU），团队最多 3 名编辑。
  * [Disease.sh](https://disease.sh/) — 免费 API，提供准确数据用于开发新冠相关实用应用。
  * [Doczilla](https://www.doczilla.app/) — SaaS API，支持从 HTML/CSS/JS 代码直接生成截图或 PDF。免费计划每月 250 份文档。
  * [Doppio](https://doppio.sh/) — 托管 API，使用顶级渲染技术生成并私有存储 PDF 和截图。免费计划每月 400 份 PDF 和截图。
  * [drawDB](https://drawdb.app/) — 免费开源的在线数据库关系图编辑器，无需注册。
  * [dreamfactory.com](https://dreamfactory.com/) — 开源 REST API 后端，适用于移动、Web 和 IoT 应用。可连接任意 SQL/NoSQL 数据库、文件存储系统或外部服务，自动生成完整 REST API 平台，带实时文档和用户管理功能。
  * [Duply.co](https://duply.co) — 通过 API 和 URL 创建动态图片，一次设计模板多次复用。免费层提供 20 个免费积分。
  * [DynamicDocs](https://advicement.io) - 通过 JSON 转 PDF API 基于 LaTeX 模板生成 PDF 文档。免费计划每月 50 次 API 调用，并可访问模板库。
  * [Efemarai](https://efemarai.com) - 机器学习模型与数据的测试和调试平台。可可视化任意计算图。本地使用免费。
  * [ERD Lab](https://www.erdlab.io) — 免费云端实体关系图（ERD）工具，面向开发者。免费试用包含 2 个项目，每个项目 10 张表。
  * [ExtendsClass](https://extendsclass.com/rest-client-online.html) - 免费基于 Web 的 HTTP 客户端，可发送 HTTP 请求。
  * [Export SDK](https://exportsdk.com) - PDF 生成器 API，带拖拽模板编辑器，提供 SDK 和零代码集成。免费计划每月 250 页，无限用户，三个模板。
  * [file.coffee](https://file.coffee/) - 文件存储平台，单文件最大 15MB（注册账户最大 30MB）。
  * [Financial Data](https://financialdata.net/) - 股票市场与金融数据 API。免费计划每日 300 次请求。
  * [FormatJSONOnline.com](https://formatjsononline.com) - 免费在线工具，即时格式化、校验、比较和压缩 JSON 数据。
  * [FraudLabs Pro](https://www.fraudlabspro.com) — 检查订单交易的信用卡支付欺诈。该 REST API 可根据订单输入参数检测所有可能的欺诈特征。免费 Micro 计划每月 500 笔交易。
  * [GeoDataSource](https://www.geodatasource.com) — 通过经纬度坐标查询城市名称的定位服务。免费 API 每月最多 500 次查询。
  * [Geolocated.io](https://geolocated.io) — IP 地理定位 API，拥有多大陆服务器，免费计划每日 2,000 次请求。
  * [Glitterly](https://glitterly.app/) - 通过模板以编程方式生成动态图像。Restful API 和零代码集成。免费层每月 50 张图片和 5 个模板。
  * [Hex](https://hex.tech/) - 协作式数据平台，支持笔记本、数据应用和知识库。社区免费层最多 5 个项目。
  * [Hook0](https://www.hook0.com/) - Hook0 是开源的 Webhooks 即服务（WaaS），让在线产品轻松提供 webhook。每天可免费分发 100 个事件，历史保留 7 天。
  * [Hoppscotch](https://hoppscotch.io) - 免费、快速、美观的 API 请求构建器。
  * [huggingface.co](https://huggingface.co) - 构建、训练和部署 Pytorch、TensorFlow 和 JAX 的 NLP 模型。免费支持每月 3 万输入字符。
  * [Hybiscus](https://hybiscus.dev/) - 通过简单声明式 API 构建 PDF 报告。14 天免费层支持 50 份单页报告，并可自定义配色方案和字体。
  * [Invantive Cloud](https://cloud.invantive.com/) — 通过 Invantive SQL 或 OData4（通常用于 Power BI 或 Power Query）访问 70 多个平台，如 Exact Online、Twinfield、ActiveCampaign 或 Visma。包括数据复制与交换。面向开发者和实施顾问的免费计划。部分平台可免费使用，数据量有限制。
  * [ipaddress.sh](https://ipaddress.sh) — 简单服务，可用不同[格式](https://about.ipaddress.sh/)获取公网 IP 地址。
  * [ip-api](https://ip-api.com) — IP 地理定位 API，免费用于非商业用途，无需 API 密钥，免费计划每个 IP 地址每分钟限 45 次请求。
  * [ipbase.com](https://ipbase.com) - IP 地理定位 API - 永久免费计划每月 150 次请求。
  * [IP Geolocation](https://ipgeolocation.io/) — IP 地理定位 API - 面向开发者的永久免费计划，每天限 1,000 次请求。
  * [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — Abstract 提供的 IP 地理定位 API - 免费 1,000 次请求。
  * [IPLocate](https://www.iplocate.io) — IP 地理定位 API，每天免费 1,000 次请求。包括代理/VPN/主机检测、ASN 数据、IP 到公司等。IPLocate 还提供免费的 IP 到国家和 IP 到 ASN 的 CSV 或 GeoIP 兼容 MMDB 格式数据库下载。
  * [IP2Location](https://www.ip2location.com) — 免费增值型 IP 地理定位服务。LITE 数据库可免费下载。导入数据库到服务器后可本地查询城市、坐标和 ISP 信息。
  * [IP2Location.io](https://www.ip2location.io/) — 免费增值型、快速、可靠的 IP 地理定位 API。可获取城市、坐标、ISP 等数据。免费计划每月 5 万积分。IP2Location.io 还每月提供 500 次免费 WHOIS 和托管域名查询。可查域名注册信息及某 IP 下托管域名。升级付费计划可获得更多功能。
  * [ipapi](https://ipapi.co/) - Kloudend, Inc 提供的 IP 地址定位 API - 基于 AWS 的可靠地理定位 API，受财富 500 强信赖。免费层每月 3 万次查询（每日 1,000 次），无需注册。
  * [ipapi.is](https://ipapi.is/) - 开发者为开发者打造的可靠 IP 地址 API，拥有最佳主机检测能力。免费计划无需注册，支持 1,000 次查询。
  * [IPinfo](https://ipinfo.io/) — 快速、精准且免费（每月 5 万次）IP 地址数据 API。提供地理定位、公司、运营商、IP 段、域名、滥用联系人等详细 API。所有付费 API 均可免费试用。
  * [IPQuery](https://ipquery.io) — 面向开发者的无限制 IP API，无速率限制，无定价。
  * [IPTrace](https://iptrace.io) — 极简 API，为您的业务提供可靠有用的 IP 地理定位数据，每月 5 万次免费查询。
  * [JSON2Video](https://json2video.com) - 用于自动化视频营销和社交媒体视频的视频编辑 API，可编程或零代码使用。
  * [JSON IP](https://getjsonip.com) — 返回发起请求的客户端公网 IP 地址。免费层无需注册。支持 CORS，可直接通过客户端 JS 从浏览器请求数据。适用于监控客户端与服务器 IP 变化的服务。无限请求。
  * [JSON Serve](https://jsonserve.com/) — 免费服务，帮助开发者存储 JSON 对象，并将其作为 REST API 在应用中使用。
  * [JSONing](https://jsoning.com/api/) — 从 JSON 对象创建虚拟 REST API，并自定义 HTTP 状态码、头部和响应体。
  * [konghq.com](https://konghq.com/) — API 市场及强大的私有和公开 API 工具。免费层部分功能如监控、告警和支持有限。
  * [Kreya](https://kreya.app) — 免费的 gRPC 图形界面客户端，用于调用和测试 gRPC API。可通过服务反射导入 gRPC API。
  * [Lightly](https://www.lightly.ai/) — 通过正确的数据提升您的机器学习模型表现。免费数据集上限 1,000 条样本。
  * [LoginLlama](https://loginllama.app) - 登录安全 API，检测欺诈和可疑登录，并通知客户。每月 1,000 次登录免费。
  * [MailboxValidator](https://www.mailboxvalidator.com) — 通过真实邮件服务器连接验证邮箱有效性。免费 API 计划每月 100 次验证。
  * [Market Data API](https://www.marketdata.app) - 提供股票、期权、共同基金等实时与历史金融数据。永久免费 API 层每天 100 次 API 请求。
  * [Meteosource Weather API](https://www.meteosource.com/) — 全球天气API，提供当前和预测的天气数据。预报基于多种天气模型的机器学习组合，以实现更高的准确性。免费套餐每天可调用400次。
  * [microlink.io](https://microlink.io/) – 将任意网站转化为数据，如元标签标准化、美观的链接预览、抓取功能或截图即服务。每天免费50次请求。
  * [Mindee](https://developers.mindee.com) – Mindee 是一款强大的OCR软件和以API为核心的平台，帮助开发者通过计算机视觉和机器学习对关键信息进行数据识别，从而标准化文档处理层并自动化应用程序工作流。免费套餐每月提供500页处理量。
  * [Mintlify](https://mintlify.com) — API文档的现代标准。美观且易于维护的UI组件，内嵌搜索和交互式演示区。1名编辑可免费使用。
  * [MockAPI](https://www.mockapi.io/) — MockAPI 是一个简单的工具，让你快速模拟API，生成自定义数据，并通过RESTful接口进行操作。MockAPI主要用于原型设计、测试和学习。每个项目可免费创建1个项目/2个资源。
  * [Mockfly](https://www.mockfly.dev/) — Mockfly 是一款值得信赖的API模拟和功能开关管理开发工具。通过直观界面快速生成和控制模拟API。免费层每天提供500次请求。
  * [Mocki](https://mocki.io) - 可创建与GitHub仓库同步的模拟GraphQL和REST API工具。无需注册即可免费开发和使用简单REST API。
  * [Mocko.dev](https://mocko.dev/) — 将你的API代理到云端，自由选择哪些端点进行模拟并监控流量，完全免费。加速开发和集成测试。
  * [Mocky](https://designer.mocky.io/) - 一个简单的网页应用，可生成自定义HTTP响应以模拟HTTP请求。也可作为[开源项目](https://github.com/julien-lafont/Mocky)使用。
  * [Mock N Roll](https://mpcknroll.me/) - 免费模拟API服务——强大的工具，可在无后端延迟情况下模拟真实API响应。非常适合前端开发、QA测试和DevOps团队。[源码](https://github.com/haerulmuttaqin/mocknroll-web)。
  * [microenv.com](https://microenv.com) —  为开发者创建虚拟REST API，可生成代码并在docker容器中运行应用。
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) —  一款免费简洁的工具，可在多个节点检查你的出口IP地址，并了解你的IP在不同全球区域和服务中的表现。适用于测试基于规则的DNS分流工具如Control D。
  * [Namekit](https://namekit.app/) - AI驱动的域名发现工具——即时查找可用、标准价域名。每日免费查询。
  * [News API](https://newsapi.org) — 通过代码搜索网络新闻，获取JSON结果。开发者每天可免费查询100次。新闻内容有24小时延迟。
  * [numlookupapi.com](https://numlookupapi.com) - 免费手机号码验证API——每月100次免费请求。
  * [OCR.Space](https://ocr.space/) — 一款OCR API，可解析图片和PDF文件并返回JSON格式文本结果。每月可免费请求25,000次，单文件大小限制1MB。
  * [OpenAPI3 Designer](https://openapidesigner.com/) — 免费可视化创建Open API 3定义。
  * [parsehub.com](https://parsehub.com/) — 从动态网站提取数据，将动态网站转为API，免费提供五个项目。
  * [Parseur](https://parseur.com) — 每月20页免费：从PDF、邮件中提取数据。AI驱动。完整API访问。
  * [PDFBolt](https://pdfbolt.com) - 专为开发者设计的PDF生成API，注重隐私保护。文档风格参考Stripe，每月包含500次免费PDF转换。
  * [pdfEndpoint.com](https://pdfendpoint.com) - 通过简单API轻松将HTML或URL转换为PDF。每月100次免费转换。
  * [PDF-API.io](https://pdf-api.io) - PDF自动化API，支持可视化模板编辑器、HTML转PDF、动态数据集成和API渲染。免费套餐含1个模板、每月100个PDF。
  * [Pixela](https://pixe.la/) - 免费的日流数据库服务。所有操作均通过API完成。支持热力图和折线图可视化。
  * [Postman](https://postman.com) — 简化工作流，更快创建更优API——Postman是API开发协作平台。Postman App永久免费使用。Postman云端功能也永久免费但有一定限制。
  * [Insomnia](https://insomnia.rest) - 开源API客户端，用于设计和测试API，支持REST和GraphQL。
  * [PrefectCloud](https://www.prefect.io/cloud/) — 完整的数据流自动化平台。免费套餐包括5个已部署工作流和每月500分钟无服务器计算额度。
  * [Preset Cloud](https://preset.io/) - 托管版Apache Superset服务。最多5人团队永久免费，支持无限仪表盘和图表、无代码图表构建器和协作SQL编辑器。
  * [PromptLoop](https://www.promptloop.com/) - PromptLoop带来10倍更便捷的AI网页抓取，几乎无需上手时间，现有工作流节省85%以上时间，比人工研究快4倍且无妥协，并为所有研究任务提供REST API端点。每月前1,000积分免费。
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — 免费公共API列表。
  * [Rapidapi](https://rapidapi.com/) - 全球最大API中心，数百万开发者发现并连接数千API，通过趣味挑战和交互示例进行API开发。
  * [RequestBin.com](https://requestbin.com) — 创建一个可接收HTTP请求的免费端点。所有发送至该端点的HTTP请求会被记录，包括有效载荷和头信息，方便你观察webhook和其他服务的推荐。
  * [reqres.in](https://reqres.in) - 免费托管REST API，随时响应你的AJAX请求。
  * [Roboflow](https://roboflow.com) - 无需机器学习经验即可创建和部署自定义计算机视觉模型。免费层每月包含30积分。
  * [ROBOHASH](https://robohash.org/) - Web服务，可根据任意文本生成独特且酷炫的图片。
  * [Scraper's Proxy](https://scrapersproxy.com) — 简单的HTTP代理API用于抓取。匿名抓取，无需担心限制、封锁或验证码。每月前100次成功抓取免费，包括javascript渲染（如需更多可联系客服）。
  * [ScrapingAnt](https://scrapingant.com/) — 无头Chrome抓取API及免费代理服务。支持javascript渲染、高级轮换代理和验证码规避。免费提供10,000 API积分。
  * [Simplescraper](https://simplescraper.io) — 每次操作后触发webhook。免费套餐含100次云端抓取积分。
  * [Select Star](https://www.selectstar.com/) - 智能数据发现平台，自动分析和文档化你的数据。轻量免费套餐支持2个数据源、最多1,000个表和25个用户。
  * [Sheetson](https://sheetson.com) - 立即将任意Google Sheets转为RESTful API。免费套餐包含每个表1,000行免费额度。
  * [Shipyard](https://www.shipyardapp.com) — 云端低代码数据编排平台。可混合使用低代码模板和自有代码（Python、Node.js、Bash、SQL）。我们的免费开发者计划每月为单用户提供10小时运行时间，足以自动化多个工作流。
  * [Siterelic](https://siterelic.com/) - Siterelic API可截图、审查网站、TLS扫描、DNS查询、TTFB测试等。免费套餐每月提供100次API请求。
  * [SerpApi](https://serpapi.com/) - 实时搜索引擎抓取API。为Google、YouTube、Bing、百度、沃尔玛等返回结构化JSON结果。免费套餐每月含100次成功API调用。
  * [SmartParse](https://smartparse.io) - SmartParse是一款数据迁移和CSV转API平台，提供节省时间和成本的开发者工具。免费层每月包含300处理单元、浏览器上传、数据隔离、熔断器和作业提醒。
  * [Sofodata](https://www.sofodata.com/) - 从CSV文件创建安全RESTful API。上传CSV后即可通过API即时访问数据，加速应用开发。免费套餐含2个API和每月2,500次API调用。无需信用卡。
  * [Sqlable](https://sqlable.com/) - 提供多种免费在线SQL工具，包括SQL格式化和验证、SQL正则测试、虚拟数据生成器和交互式数据库沙盒。
  * [Stoplight](https://stoplight.io/) - SaaS协作设计和文档API工具。免费套餐提供免费的设计、模拟和文档工具。
  * [Supportivekoala](https://supportivekoala.com/) — 允许你通过模板根据输入自动生成图片。免费套餐每月最多生成50张图片。
  * [Svix](https://www.svix.com/) - Webhooks即服务。每月最多发送50,000条消息，永久免费。
  * [Tavily AI](https://tavily.com/) - 在线搜索、快速洞察和综合研究API，支持研究结果的组织。免费层每月1,000次请求，无需信用卡。
  * [The IP API](https://theipapi.com/) - IP地理定位API，每天1,000次免费请求。可提供IP地址的国家、城市、地区等信息。
  * [TinyMCE](https://www.tiny.cloud) - 富文本编辑API。核心功能永久免费无限制使用。
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - 提供天气API免费套餐，具备全球覆盖、历史数据和天气监控解决方案，预报准确且实时。
  * [Treblle](https://www.treblle.com) - Treblle帮助团队构建、发布和管理API，具备高级API日志聚合、可观测性、文档和调试功能。所有功能免费，但免费层每月请求上限为25万次。
  * [UniRateAPI](https://unirateapi.com) – 实时汇率API，支持590+种货币及加密货币。免费套餐无限API调用，适合开发者及金融应用。
  * [vatcheckapi.com](https://vatcheckapi.com) - 简单免费的VAT号码验证API。每月150次免费验证。
  * [WeatherXu](https://weatherxu.com/) — 全球天气数据，包括当前状况、每小时及每日预报、天气预警API。集成AI与机器学习系统分析和融合多种天气模型，提升预测准确性。免费层每月含10,000次API调用。
  * [Webhook Store](https://www.openwebhook.io) - 用于存储第三方webhook并在本地调试（ngrok风格）的工具。开源且可自托管。免费个人域名 *username*.github.webhook.store，免费公共域名 *anything*.webhook.store。
  * [WebScraping.AI](https://webscraping.ai) - 简单的网页抓取API，内置解析、Chrome渲染及代理。每月2,000次免费API调用。
  * [Weights & Biases](https://wandb.ai) — 面向开发者的MLOps平台。通过实验跟踪、数据集版本管理和模型管理，加速更优模型开发。个人项目免费层，含100GB存储。
  * [What The Diff](https://whatthediff.ai) - AI驱动的代码审查助手。免费套餐每月上限25,000个令牌（约10个PR）。
  * [wolfram.com](https://wolfram.com/language/) — 云端内置基于知识的算法。
  * [wrapapi.com](https://wrapapi.com/) — 将任意网站转为参数化API。每月3万次API调用。
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — 拥有无头浏览器、住宅IP和简明定价的网页抓取API。每月1,000次免费API调用，学生和非营利组织可额外获得积分。
  * [Zipcodebase](https://zipcodebase.com) - 免费邮政编码API，访问全球邮政编码数据。每月5,000次免费请求。
  * [Zipcodestack](https://zipcodestack.com) - 免费邮编API及邮编验证。每月1万次免费请求。
  * [Zuplo](https://zuplo.com/) - 免费API管理平台，支持API设计、构建与部署到边缘节点。可为任意API添加API密钥认证、限流、开发者文档和货币化。原生支持OpenAPI，完全可编程，支持Web标准API和Typescript。免费套餐最多10个项目，无限生产环境，月请求量达100万次，外部流量10GB。

**[⬆️ 回到顶部](#table-of-contents)**

## 制品仓库

  * [Artifactory](https://jfrog.com/start-free/) - 支持多种包格式（如Maven、Docker、Cargo、Helm、PyPI、CocoaPods和GitLFS）的制品仓库。包含包扫描工具XRay和CI/CD工具Pipelines（原Shippable），免费层每月2,000分钟CI/CD时长。
  * [central.sonatype.org](https://central.sonatype.org) — Apache Maven、SBT及其他构建系统的默认制品仓库。
  * [cloudrepo.io](https://cloudrepo.io) - 基于云的私有和公共Maven及PyPi仓库。开源项目免费。
  * [cloudsmith.io](https://cloudsmith.io) — 简单、安全、集中的仓库服务，支持Java/Maven、RedHat、Debian、Python、Ruby、Vagrant等。免费层+开源项目免费。
  * [jitpack.io](https://jitpack.io/) — GitHub上的JVM和Android项目Maven仓库，公开项目免费。
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — 易用的Maven、RPM、DEB、PyPi、NPM和RubyGem包仓库托管（含免费层）。
  * [repsy.io](https://repsy.io) — 1GB免费私有/公共Maven仓库。
  * [Gemfury](https://gemfury.com) — Maven、PyPi、NPM、Go Module、Nuget、APT和RPM的私有及公共制品仓库。公共项目免费。
  * [paperspace](https://www.paperspace.com/) — 构建和扩展AI模型，开发、训练和部署AI应用，免费计划：公开项目、5Gb存储、基础实例。
  * [RepoForge](https://repoforge.io) - 私有云托管的Python、Debian、NPM包及Docker仓库。开源/公共项目免费计划。
  * [RepoFlow](https://repoflow.io) - RepoFlow 简化了npm、PyPI、Docker、Go、Helm等包管理。免费试用含10GB存储、10GB带宽、100个包和无限用户，可部署在云端或个人自托管（仅限个人用途）。

**[⬆️ 回到顶部](#table-of-contents)**

## 团队与协作工具
  * [3Cols](https://3cols.com/) - 一款免费的云端代码片段管理器，支持个人和协作代码管理。
  * [Bitwarden](https://bitwarden.com) — 个人、团队和企业组织存储、共享和同步敏感数据的最简单和最安全方式。
  * [Braid](https://www.braidchat.com/) — 面向团队的聊天应用。公共访问组、无限用户、聊天记录及集成永久免费。还提供可自托管的开源版本。
  * [cally.com](https://cally.com/) — 轻松找到会议的最佳时间和日期。操作简单，适合小型和大型团队。
  * [Calendly](https://calendly.com) — 会议连接与调度工具。免费计划每位用户支持1个日历连接和无限次会议。桌面和移动应用也可用。
  * [Discord](https://discord.com/) — 支持公/私房间聊天。支持Markdown文本、语音、视频及屏幕共享。无限用户永久免费。
  * [Fibo](https://fibo.dev) - 一款免费的在线实时敏捷团队Scrum Poker工具，支持无限成员进行故事点估算，加快规划。
  * [Telegram](https://telegram.org/) — Telegram适合所有需要快速、可靠消息与通话的用户。企业与小团队喜欢其大型群组、用户名、桌面应用和强大的文件分享功能。
  * [DevToolLab](https://devtoollab.com) — 在线开发者工具，所有基础工具免费访问，支持每种工具自动保存一条记录、标准处理速度和社区支持。
  * [Dubble](https://dubble.so/) — 免费的分步指南创建器。可截图、记录流程并与团队协作。支持异步屏幕录制。
  * [Duckly](https://duckly.com/) — 实时语音、视频、屏幕、IDE及终端共享，助团队协作编程。小团队免费。
  * [Dyte](https://dyte.io) - 最适合开发者的实时音视频SDK，配合协作插件提升生产力和参与度。免费套餐每月含10,000分钟音视频使用。
  * [evernote.com](https://evernote.com/) — 信息整理工具。支持笔记分享和协作。
  * [Fibery](https://fibery.io/) — 连接型工作空间平台。单用户免费，含2GB磁盘空间。
  * [flock.com](https://flock.com) — 让你的团队更快沟通的方式。免费提供无限消息、频道、用户、应用和集成。
  * [Gather](https://www.gather.town/) - 更好的在线见面方式。以完全可自定义空间为核心，Gather 让你与社群的互动就像现实生活一样轻松。免费支持最多 10 个同时在线用户。
  * [gokanban.io](https://gokanban.io) - 基于语法、无需注册的看板工具，快速上手。免费且无任何限制。
  * [flat.social](https://flat.social) - 为团队会议和社交活动提供互动式可自定义空间。会议次数无限，免费支持最多 8 个同时在线用户。
  * [GitDailies](https://gitdailies.com) - 提供团队 GitHub 提交和 Pull Request 活动的日报。包括 Push 可视化、同行认可系统和自定义警报生成器。免费层支持无限用户，三个仓库和三个警报配置。
  * [gitter.im](https://gitter.im/) — 专为 GitHub 设计的聊天工具。无限公共和私人聊天室，团队免费人数上限为 25 人。
  * [Hackmd.io](https://hackmd.io/) - 实时协作与写作工具，支持 markdown 格式文档/文件。类似 Google Docs，但针对 markdown 文件。免费可创建无限数量的“笔记”，但私有笔记和模板的协作者（受邀者）数量[将有限制](https://hackmd.io/pricing)。
  * [hangouts.google.com](https://hangouts.google.com/) — 一站式免费会话平台，需要 Google 账号。
  * [HeySpace](https://hey.space) - 具备聊天、日历、时间线和视频通话的任务管理工具。免费支持最多 5 个用户。
  * [helplightning.com](https://www.helplightning.com/) — 增强现实视频辅助。免费版不含分析、加密和支持服务。
  * [ideascale.com](https://ideascale.com/) — 允许客户提交创意并投票，免费支持 1 个社区、25 个成员。
  * [Igloo](https://www.igloosoftware.com/) — 内部门户，用于分享文档、博客、日历等。免费支持最多 10 个用户。
  * [Keybase](https://keybase.io/) — Keybase 是 Slack 的开源替代方案；可保护所有人的聊天和文件安全，适用于家庭、社区和公司。
  * [Google Meet](https://meet.google.com/) — 用于企业在线视频会议的 Google Meet，提供安全、易加入的在线会议。
  * [/meet for Slack](https://meetslack.com) - 通过在任何 Slack 频道、群组或私聊中使用 /meet，直接发起 Google 会议。免费且无任何限制。
  * [Livecycle](https://www.livecycle.io/) — Livecycle 是一款包容性的协作平台，让跨职能产品团队和开源项目的工作流更无摩擦。
  * [Lockitbot](https://www.lockitbot.com/) — 在 Slack 内预定和锁定共享资源，如会议室、开发环境、服务器等。免费支持最多 2 个资源。
  * [MarkUp](https://www.markup.io/) — MarkUp 让你能在网站、PDF 和图片上直接收集反馈。
  * [Proton Pass](https://proton.me/pass) — 带内置邮箱别名、2FA 验证器、分享和 Passkey 的密码管理器。支持 Web、浏览器扩展、移动和桌面应用。
  * [Visual Debug](https://visualdebug.com) - 一款用于改善客户与开发者沟通的可视化反馈工具。
  * [meet.jit.si](https://meet.jit.si/) — 一键发起免费视频会话和屏幕共享。
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — 基于聊天的数字中心，将对话、内容和应用整合在一个体验中。免费支持多达 50 万用户。
  * [Miro](https://miro.com/) - 可扩展、安全、跨设备、企业级协作白板，适用于分布式团队。提供免费计划。
  * [nootiz](https://www.nootiz.com/) - 网站视觉反馈采集和管理工具。
  * [Notion](https://www.notion.so/) - Notion 是一款支持 markdown 的笔记与协作应用，集任务、Wiki 和数据库于一体。公司将其描述为集笔记、项目管理和任务管理于一身的工作区。除跨平台应用外，也可通过主流浏览器访问。
  * [Nuclino](https://www.nuclino.com) - 轻量级团队协作 Wiki，用于团队知识、文档和笔记。免费计划包含全部核心功能，最多 50 个条目和 5GB 存储。
  * [OnlineInterview.io](https://onlineinterview.io/) - 免费代码面试平台，内嵌视频聊天、画板和在线代码编辑器，可在浏览器中编译运行代码。一键创建远程面试房间。
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - 简单的团队工时和时间追踪应用。免费计划支持最多 10 个用户进行时间追踪和报告生成。
  * [PageShare.dev](https://www.pageshare.dev) - 为 GitHub Pull Request 添加可视化审查，无需部署网站。每月免费支持最多 10 个页面，总共 100MB 存储。
  * [Pendulums](https://pendulums.io/) - 免费的时间追踪工具，界面简洁，统计有价值，帮助你更好地管理时间。
  * [Pumble](https://pumble.com) - 免费团队聊天应用。用户数和消息历史无限，永久免费。
  * [Raindrop.io](https://raindrop.io) - 私密且安全的书签应用，支持 macOS、Windows、Android、iOS 和 Web。免费提供无限书签与协作。
  * [element.io](https://element.io/) — 构建在 Matrix 上的去中心化开源通信工具。支持群聊、私聊、加密文件传输、语音和视频聊天，并可轻松集成其他服务。
  * [Rocket.Chat](https://rocket.chat/) - 开源通信平台，具备全渠道功能、Matrix 联邦互通、与其他应用的桥接、无限消息和完整消息历史。
  * [seafile.com](https://www.seafile.com/) — 私有或云端存储、文件共享、同步与讨论。云版本仅有 1 GB 容量。
  * [Sema](https://www.semasoftware.com/) - 免费开发者作品集工具，可将多个仓库的贡献整合并快照到一份报告中。
  * [Screen Sharing via Browser](https://screensharing.net) - 免费屏幕共享工具，直接通过浏览器与协作者共享屏幕，无需下载或注册。
  * [Slab](https://slab.com/) — 现代团队知识管理服务。免费支持最多 10 个用户。
  * [slack.com](https://slack.com/) — 支持无限用户，部分功能有限制，免费使用。
  * [Spectrum](https://spectrum.chat/) - 免费创建公共或私有社群。
  * [StatusPile](https://www.statuspile.com/) - 状态页面集合。可追踪上游服务商的状态页面。
  * [Stickies](https://stickies.app/) - 用于头脑风暴、内容策展和笔记的可视化协作应用。免费支持最多 3 块墙板、无限用户和 1GB 存储。
  * [Stacks](https://betterstacks.com/) - 集成笔记、链接和文件存储的内容工作区，帮助应对信息过载。永久免费个人计划。
  * [talky.io](https://talky.io/) — 免费群组视频聊天。匿名。点对点。无需插件、注册或付款。
  * [Teamhood](https://teamhood.com/) - 免费项目、任务和问题跟踪软件。支持带泳道的看板和完整 Scrum 实现，内置时间追踪。免费支持 5 个用户和 3 个项目组合。
  * [Teamplify](https://teamplify.com) - 通过团队分析和智能每日站会提升团队开发流程。包含完善的远程优先团队请假管理。免费支持最多 5 人小组。
  * [Tefter](https://tefter.io) - 具备强大 Slack 集成的书签应用。对开源团队免费。
  * [TeleType](https://teletype.oorja.io/) — 共享终端、语音、代码、白板等。无需登录，端到端加密协作，适合开发者。
  * [TimeCamp](https://www.timecamp.com/) - 免费时间追踪软件，支持无限用户。可轻松集成 Jira、Trello、Asana 等项目管理工具。
  * [Huly](https://huly.io/) - 一体化项目管理平台（可替代 Linear、Jira、Slack、Notion、Motion），不限用户，每个工作区 10GB 存储，10GB 视频（音频）流量。
  * [Teamcamp](https://www.teamcamp.app) - 面向软件开发公司的全能项目管理应用。
  * [twist.com](https://twist.com) — 支持异步沟通的团队通信应用，对话有序且聚焦主题。提供免费和无限计划，并为符合条件的团队提供折扣。
  * [tldraw.com](https://tldraw.com) — 免费开源白板和图表工具，具备智能箭头、吸附、便签和 SVG 导出等功能。多人协作编辑模式。还提供官方 VS Code 免费扩展。
  * [BookmarkOS.com](https://bookmarkos.com) - 免费一体化书签管理、标签管理和任务管理工具，支持自定义在线桌面和文件夹协作。
  * [typetalk.com](https://www.typetalk.com/) — 通过网页或移动端即时消息与团队分享和讨论想法。
  * [Tugboat](https://tugboat.qa) - 实现每个 Pull Request 的自动和按需预览。全部免费，非盈利组织有免费 Nano 层。
  * [whereby.com](https://whereby.com/) — 一键视频通话，永久免费（前身为 appear.in）。
  * [windmill.dev](https://windmill.dev/) - Windmill 是开源开发者平台，可用极少的 Python 和 Typescript 脚本快速构建生产级多步骤自动化和内部应用。免费用户最多可创建和加入 3 个非高级工作区。
  * [vadoo.tv](https://vadoo.tv/) — 简单的视频托管和营销服务，一键上传、录制、管理、分享等。免费层支持最多 10 个视频、1GB 存储和每月 10GB 带宽。
  * [userforge.com](https://userforge.com/) - 在线角色、用户故事和情境映射工具，帮助设计与开发协同。免费支持最多 3 个角色和 2 位协作者。
  * [wistia.com](https://wistia.com/) — 视频托管，带观看分析、高清视频分发和营销工具，支持 25 个视频，Wistia 品牌播放器。
  * [wormhol.org](https://www.wormhol.org/) — 简单直观的文件分享服务。无限制分享单个最大 5GB 文件，人数不限。
  * [Wormhole](https://wormhole.app/) - 端到端加密分享最大 5GB 文件，有效期 24 小时。超过 5GB 的文件通过点对点方式直接发送。
  * [zoom.us](https://zoom.us/) — 安全的视频及 Web 会议，支持多种插件。免费计划会议时长限制为 40 分钟。
  * [Zulip](https://zulip.com/) — 实时聊天，采用独特的类邮件线程模型。免费计划支持 1 万条消息搜索历史和 5GB 文件存储，并提供可自托管的开源版本。
  * [robocorp.com](https://robocorp.com) - 开源自动化运维技术栈。可免费试用云功能并实现简单自动化。机器人工作 240 分钟/月，10 次助手运行，100MB 存储。
  * [Fleep.io](https://fleep.io/) — Fleep 是 Slack 的替代方案。为小团队提供免费计划，支持完整消息历史、无限 1:1 对话、1 个群组会话和 1GB 文件存储。
  * [Chanty.com](https://chanty.com/) — Chanty 是另一款 Slack 替代品。为小团队（最多 10 人）提供永久免费计划，支持无限公私对话、可搜索历史、无限 1:1 音频通话、无限语音消息、10 个集成和每团队 20GB 存储。
  * [ruttl.com](https://ruttl.com/) — 最佳一体化反馈工具，收集数字反馈并审查网站、PDF、图片。
  * [Mattermost](https://mattermost.com/) — 技术团队的安全协作平台。免费计划支持无限频道、剧本、看板、用户，10GB 存储等。
  * [Webvizio](https://webvizio.com) — 网站反馈工具、网站审查软件和 bug 报告工具，直接在真实网站、Web 应用、图片、PDF 和设计文件上协作处理任务。
  * [Pullflow](https://pullflow.com) — Pullflow 提供 AI 增强的代码审查协作平台，覆盖 GitHub、Slack 和 VS Code。
  * [Webex](https://www.webex.com/) — 视频会议，免费计划每次会议 40 分钟，最多 100 位参会者。
  * [RingCentral](https://www.ringcentral.com/) — 视频会议，免费计划每次会议 50 分钟，最多 100 位参与者。
  * [GitBook](https://www.gitbook.com/) — 用于捕捉和记录技术知识的平台——从产品文档到内部知识库和 API。为个人开发者提供免费计划。
  * [transfernow](https://www.transfernow.net/) — 最简单、最快速且最安全的文件传输和分享界面。无需订阅即可发送照片、视频和其他大文件。
  * [paste.sh](https://paste.sh/) — 基于 JavaScript 和加密的简单粘贴站点。
  * [Revolt.chat](https://revolt.chat/) — [Discord](https://discord.com/) 的开源替代品，注重隐私。大部分 Discord 专属功能也免费提供。Revolt 是一款安全、快速的全能应用，100% 免费。所有功能均免费。与主流聊天应用不同，还支持官方与非官方插件。
  * [Tencent RTC](https://trtc.io/) — 腾讯实时音视频（TRTC）提供群组音视频通话方案。首年每月赠送 1 万分钟免费时长。
  * [Pastefy](https://pastefy.app/) - 美观简洁的 Pastebin，支持可选客户端加密、多标签粘贴、API、高亮编辑器等。
  * [SiteDots](https://sitedots.com/) - 直接在你的网站上分享网站项目反馈，无需仿真、画布或其他变通方案。免费层功能完整。

**[⬆️ 返回顶部](#table-of-contents)**

## CMS

  * [acquia.com](https://www.acquia.com/) — Drupal 站点托管。为开发者提供免费层。也提供免费的开发工具（如 Acquia Dev Desktop）。
  * [Contentful](https://www.contentful.com/) — 无头 CMS。云端内容管理与分发 API。提供一个免费社区空间，包含 5 个用户、2.5 万条记录、48 种内容类型、2 个区域。
  * [Cosmic](https://www.cosmicjs.com/) — 无头 CMS 与 API 工具包。为开发者提供免费个人计划。
  * [Crystallize](https://crystallize.com) — 支持电商的无头 PIM，内置 GraphQL API。免费版包含无限用户、1000 个目录项、每月 5GB 带宽和 2.5 万次 API 调用。
  * [DatoCMS](https://www.datocms.com/) - 为小型项目提供免费层。DatoCMS 是基于 GraphQL 的 CMS。低配层每月有 10 万次调用。
  * [Directus](https://directus.io) — 无头 CMS。完全免费开源平台，用于管理本地或云端的资产和数据库内容。无任何限制或付费墙。
  * [FrontAid](https://frontaid.io/) — 将 JSON 内容直接存储于 Git 仓库的无头 CMS。无限制。
  * [kontent.ai](https://www.kontent.ai) - 内容即服务平台，兼具无头 CMS 优势和营销赋能。开发者计划支持 2 个用户、无限项目、每个项目 2 个环境、500 个内容项、2 种语言，并支持交付和管理 API 及自定义元素。可根据需求使用更详细的方案。
  * [Prismic](https://www.prismic.io/) — 无头 CMS。内容管理界面，带全托管、可扩展 API。社区计划支持 1 个用户下无限 API 调用、文档、自定义类型、资产和区域。适合下一个项目所需。对于开放内容/开源项目有更大的免费计划。
  * [Sanity.io](https://www.sanity.io/) - 结构化内容平台，带开源编辑环境和实时托管数据存储。无限项目。每个项目免费包含无限管理员用户、3 个非管理员用户、2 个数据集、50 万次 API CDN 请求、10GB 带宽和 5GB 资产。
  * [sensenet](https://sensenet.com) - API 优先的无头 CMS，提供企业级方案，适用于各种规模企业。开发者计划支持 3 个用户、500 个内容项、3 个内置角色、25+5 种内容类型、完全开放的 REST API、文档预览生成和 Office Online 编辑。
  * [TinaCMS](https://tina.io/) — 替代 Forestry.io。开源 Git 驱动的无头 CMS，支持 Markdown、MDX 和 JSON。基础版免费，支持 2 个用户。
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby 是快速灵活的框架，可让你用任意 CMS、API 或数据库愉快地构建网站。构建和部署无头网站，提升流量、转化与收入！
  * [Hygraph](https://hygraph.com/) - 为小型项目提供免费层。GraphQL 优先 API。从传统方案迁移到原生 GraphQL 无头 CMS，实现全渠道内容 API 优先交付。
  * [Squidex](https://squidex.io/) - 为小型项目提供免费套餐。API / GraphQL 优先。开源并基于事件溯源（自动版本化每次更改）。
  * [InstaWP](https://instawp.com/) - 几秒钟内启动一个 WordPress 站点。免费套餐包含 5 个活跃站点、500 MB 空间、站点 48 小时过期。
  * [Storyblok](https://www.storyblok.com) - 面向开发者和市场营销人员的无头 CMS，兼容所有现代框架。社区（免费）套餐提供管理 API、可视化编辑器、10 个资源、定制字段类型、国际化（无限语言/地区）、资产管理器（最多 2500 个资源）、图片优化服务、搜索查询、Webhook + 每月 250GB 流量。
  * [WPJack](https://wpjack.com) - 5 分钟内在任意云上搭建 WordPress！免费套餐包含 1 台服务器、2 个站点、免费 SSL 证书和无限定时任务。无时间限制或过期—您的网站，您做主。

**[⬆️ 返回顶部](#table-of-contents)**

## 代码生成

  * [Appinvento](https://appinvento.io/) — AppInvento 是一款免费的无代码应用构建器。在自动生成的后端代码中，用户可以完全访问源代码以及无限制的 API 和路由，实现广泛集成。免费计划包含三个项目、五张数据表和一个 Google 插件。
  * [Cody AI](https://sourcegraph.com/cody) - Cody 是一款编码 AI 助手，利用 AI 和对代码库的深入理解帮助你更快编写和理解代码。Cody 支持多种 LLM（包括本地推理）、多种 IDE、所有流行编程语言，并有免费计划。免费计划每月提供 20 次聊天消息（LLM 为 Claude 3 Sonnet）和 500 次自动补全（使用 Starcoder 16b）。
  * [DhiWise](https://www.dhiwise.com/) — 利用 DhiWise 创新的代码生成技术，将 Figma 设计无缝转换为动态 Flutter 和 React 应用程序，优化你的工作流程，助你更快打造卓越的移动和 Web 体验。
  * [Codeium](https://www.codeium.com/) — Codeium 是一款免费的 AI 代码补全工具。支持 20 多种编程语言（Python、JavaScript、Java、TypeScript、PHP、C/C++、Go 等），可集成所有主流独立和 Web IDE。
  * [Fern](https://buildwithfern.com) - 编写 API 定义并用于生成各主流语言（如 TypeScript、Python、Java、Go 等）的 SDK/客户端库。完全支持 OpenAPI。免费套餐最多可为 20 个端点生成代码。
  * [Metalama](https://www.postsharp.net/metalama) - 仅支持 C#。Metalama 在编译时动态生成样板代码，保持源代码简洁。对开源项目免费，商业友好免费套餐包含 3 个切面。
  * [Supermaven](https://www.supermaven.com/) — Supermaven 是一款适用于 VSCode、JetBrains 和 Neovim 的高速 AI 代码补全插件。免费套餐提供无限量内联补全。
  * [tabnine.com](https://www.tabnine.com/) — Tabnine 通过汇集全球代码经验帮助开发者更快地编写更优质的软件。插件可用。
  * [v0.dev](https://v0.dev/) — v0 利用 AI 模型根据简单文本提示生成代码。可生成基于 shadcn/ui 和 Tailwind CSS 的 React 代码，复制粘贴即可用于项目。每次生成至少消耗 30 积分。初始赠送 1200 积分，每月赠送 200 积分。

**[⬆️ 返回顶部](#table-of-contents)**

## 代码质量

  * [beanstalkapp.com](https://beanstalkapp.com/) — 完整的代码编写、评审与部署工作流，免费账户支持 1 位用户和 1 个仓库，100 MB 存储空间
  * [browserling.com](https://www.browserling.com/) — 实时交互式跨浏览器测试，免费版仅支持 3 分钟会话，环境为 Vista 上的 MS IE 9，分辨率 1024 x 768
  * [codacy.com](https://www.codacy.com/) — 支持 PHP、Python、Ruby、Java、JavaScript、Scala、CSS 和 CoffeeScript 的自动化代码审查，公有和私有仓库不限数量免费
  * [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - DevOps 基础设施即代码自动审查工具，集成 GitHub、Bitbucket 和 GitLab（支持自托管）。除标准语言外，还能分析 Ansible、Terraform、CloudFormation、Kubernetes 等。（开源免费）
  * [CodeBeat](https://codebeat.co) — 多语言自动化代码审查平台。公有仓库永久免费，支持 Slack 和邮件集成。
  * [codeclimate.com](https://codeclimate.com/) — 自动化代码审查，开源和组织自有私有仓库（最多 4 名协作者）不限数量免费。学生和机构也免费。
  * [codecov.io](https://codecov.io/) — 代码覆盖率工具（SaaS），开源和 1 个私有仓库免费
  * [CodeFactor](https://www.codefactor.io) — 针对 Git 的自动化代码审查。免费版支持无限用户、公有仓库和 1 个私有仓库。
  * [coderabbit.ai](https://coderabbit.ai) — AI 驱动的代码审查工具，可集成 GitHub/GitLab。免费套餐包括每小时 200 个文件、3 次审查和 50 次对话。开源项目永久免费。
  * [codescene.io](https://codescene.io/) - CodeScene 基于开发者与代码的交互优先级分配技术债，并可视化团队耦合和系统掌控等组织因素。开源免费。
  * [CodSpeed](https://codspeed.io) - 在 CI 流水线自动跟踪性能。通过精准一致的指标，在部署前发现性能回退。开源项目永久免费。
  * [coveralls.io](https://coveralls.io/) — 显示测试覆盖率报告，开源免费
  * [dareboost](https://dareboost.com) - 每月 5 次免费网站性能、可访问性和安全性分析报告
  * [deepcode.ai](https://www.deepcode.ai) — 基于 AI 检查 Bug、安全漏洞、性能和 API 问题。分析速度快，支持 Java、C/C++、JavaScript、Python、TypeScript。集成 GitHub、BitBucket、GitLab。支持开源和私有仓库，最多 30 名开发者免费。
  * [deepscan.io](https://deepscan.io) — JavaScript 代码高级静态分析，自动发现运行时错误，开源免费
  * [DeepSource](https://deepsource.io/) - DeepSource 持续分析源码变更，发现并修复安全、性能、反模式、Bug 风险、文档和样式问题。原生集成 GitHub、GitLab、Bitbucket。
  * [DiffText](https://difftext.com) - 即时比较两段代码的不同。完全免费。
  * [eversql.com](https://www.eversql.com/) — EverSQL - 数据库优化第一平台。自动获取数据库和 SQL 查询的关键洞察。
  * [gerrithub.io](https://review.gerrithub.io/) — 针对 GitHub 仓库的 Gerrit 代码审查，免费
  * [gocover.io](https://gocover.io/) — 针对任意 [Go](https://golang.org/) 包的代码覆盖率
  * [goreportcard.com](https://goreportcard.com/) — Go 项目代码质量，开源免费
  * [gtmetrix.com](https://gtmetrix.com/) — 网站优化报告及详尽优化建议
  * [holistic.dev](https://holistic.dev/) - PostgreSQL 优化静态代码分析服务，自动检测性能、安全和架构问题
  * [houndci.com](https://houndci.com/) — 针对 GitHub 提交的代码质量评论，开源免费
  * [Moderne.io](https://app.moderne.io) — 自动化源码重构。Moderne 提供框架迁移、代码分析与修复、大规模代码转换，助力开发者将更多时间用于创新而非维护。开源免费。
  * [reviewable.io](https://reviewable.io/) — 针对 GitHub 仓库的代码审查，公有或个人仓库免费。
  * [parsers.dev](https://parsers.dev/) - 抽象语法树解析器与中间表示编译器即服务
  * [scan.coverity.com](https://scan.coverity.com/) — 针对 Java、C/C++、C# 和 JavaScript 的静态代码分析，开源免费
  * [scrutinizer-ci.com](https://scrutinizer-ci.com/) — 持续检查平台，开源免费
  * [semanticdiff.com](https://app.semanticdiff.com/) — 针对 GitHub PR 和提交的编程语言感知差异分析，公有仓库免费
  * [shields.io](https://shields.io) — 开源项目质量元数据徽章
  * [sonarcloud.io](https://sonarcloud.io) — Java、JavaScript、C/C++、C#、VB.NET、PHP、Objective-C、Swift、Python、Groovy 等多语言自动化源码分析，开源免费
  * [SourceLevel](https://sourcelevel.io/) — 自动化代码审查与团队分析。开源和最多 5 人组织免费。
  * [webceo.com](https://www.webceo.com/) — SEO 工具，且支持代码验证和多设备测试
  * [zoompf.com](https://zoompf.com/) — 网站性能优化，详细分析报告

**[⬆️ 返回顶部](#table-of-contents)**

## 代码搜索与浏览

  * [libraries.io](https://libraries.io/) — 支持 32 种包管理器的搜索与依赖更新通知，开源免费
  * [Namae](https://namae.dev/) - 可在 GitHub、Gitlab、Heroku、Netlify 等多个平台检索项目名称可用性。
  * [searchcode.com](https://searchcode.com/) — 全面基于文本的代码搜索，开源免费
  * [tickgit.com](https://www.tickgit.com/) — 提取 `TODO` 注释及其他标记，帮助识别代码待优化区域。
  * [CodeKeep](https://codekeep.io) - 类似 Google Keep 的代码片段管理工具。可整理、发现并分享代码片段，具备强大的代码截图工具和模板预设及链接功能。

**[⬆️ 返回顶部](#table-of-contents)**

## CI 和 CD

  * [AccessLint](https://github.com/marketplace/accesslint) — AccessLint 将自动化 Web 无障碍测试集成到开发流程。对开源和教育用途免费。
  * [appcircle.io](https://appcircle.io) — 企业级移动 DevOps 平台，自动化移动应用的构建、测试和发布，加快高效发布周期。免费版单次最大构建 30 分钟、每月 20 次构建、1 个并发构建。
  * [appveyor.com](https://www.appveyor.com/) — Windows CD 服务，开源免费
  * [LocalOps](https://localops.co/) - 30 分钟内在 AWS/GCP/Azure 部署你的应用。可在任意云上搭建标准化应用环境，内置持续部署自动化与高级可观测性。免费计划允许 1 个用户、1 个应用环境。
  * [Argonaut](https://argonaut.dev/) - 数分钟内在你的云环境部署应用和基础设施。支持 Kubernetes 和 Lambda 环境的自定义及第三方应用部署。免费套餐支持 5 个域名、2 个用户的无限应用和部署。
  * [bitrise.io](https://www.bitrise.io/) — 移动应用的 CI/CD，原生或混合应用。免费 200 次构建/月，10 分钟构建时长，两名团队成员。开源项目享受 45 分钟构建时长、+1 并发数和无限团队规模。
  * [buddy.works](https://buddy.works/) — CI/CD 服务，免费支持 5 个项目、1 个并发执行（每月 120 次）
  * [Buildkite](https://buildkite.com) CI 流水线免费支持 3 名用户和每月 5000 分钟作业。测试分析的开发者免费套餐包含每月 10 万次测试，开源项目有更多免费额度。
  * [bytebase.com](https://www.bytebase.com/) — 数据库 CI/CD 与 DevOps。20 用户和 10 个数据库实例内免费
  * [CircleCI](https://circleci.com/) — 面向 GitHub、GitLab、BitBucket 的托管 CI/CD 服务，免费计划支持全部特性。多种资源类型、支持 Docker、Windows、Mac OS、ARM 执行器、本地运行器、测试分割、Docker 层缓存等高级功能。私有项目每月 6000 分钟执行时长、无限协作者、30 并发作业，开源项目每月最高 8 万分钟免费构建时长。
  * [cirrus-ci.org](https://cirrus-ci.org) - 公共 GitHub 仓库免费
  * [cirun.io](https://cirun.io) - 公共 GitHub 仓库免费
  * [codefresh.io](https://codefresh.io) — 永久免费计划：1 个构建、1 个环境、共享服务器、无限公有仓库
  * [codemagic.io](https://codemagic.io/) - 每月免费 500 分钟构建
  * [codeship.com](https://codeship.com/) — 每月 100 次私有构建，5 个私有项目，开源项目不限
  * [deploybot.com](https://www.deploybot.com/) — 1 个仓库 10 次部署，开源免费
  * [deployhq.com](https://www.deployhq.com/) — 1 个项目每天 10 次部署（每月 30 分钟构建时长）
  * [drone](https://cloud.drone.io/) - Drone Cloud 支持多架构（x86、Arm 32/64 位）持续交付流水线
  * [LayerCI](https://layerci.com) — 全栈项目的 CI。1 个全栈预览环境，5GB 内存 & 3 个 CPU。
  * [semaphoreci.com](https://semaphoreci.com/) — 开源免费，每月 100 次私有构建
  * [Squash Labs](https://www.squash.io/) — 为每个分支创建虚拟机，并通过唯一 URL 访问你的应用，支持无限公有/私有仓库，虚拟机最高 2 GB
  * [styleci.io](https://styleci.io/) — 仅支持公有 GitHub 仓库
  * [Mergify](https://mergify.io) — GitHub 的工作流自动化与合并队列 — 公有 GitHub 仓库免费
  * [Make](https://www.make.com/en) — 工作流自动化工具，通过 UI 连接应用并自动化流程。支持多种应用和主流 API。公有 GitHub 仓库免费，免费套餐含 100 Mb、1000 次操作、最小间隔 15 分钟。
  * [Spacelift](https://spacelift.io/) - 基础设施即代码管理平台。免费套餐功能：IaC 协作、Terraform 模块仓库、ChatOps 集成、基于 Open Policy Agent 的持续资源合规、SAML 2.0 SSO、公有工作池访问：每月最多 200 分钟
  * [microtica.com](https://microtica.com/) - 启动环境含现成基础设施组件，免费在 AWS 部署应用，支持生产负载。免费套餐包含 1 个环境（你的 AWS 账号）、2 个 Kubernetes 服务、每月 100 分钟构建和 20 次部署。
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud 通过远程缓存、任务分发到多台机器以及端到端测试自动拆分等功能，加速你的单体仓库在 CI 上的运行。免费计划支持最多 30 名贡献者，包含 15 万积分。
* [blacksmith](https://www.blacksmith.sh/) - 为 GitHub Actions 提供托管的高性能运行环境，每月赠送 3,000 分钟，无需信用卡。
* [Terramate](https://terramate.io/) - Terramate 是一个基础设施即代码（IaC）工具（如 Terraform、OpenTofu 和 Terragrunt）的编排和管理平台。最多 2 名用户免费，包含全部功能。
* [Terrateam](https://terrateam.io) - 以 GitOps 为先的 Terraform 自动化工具，支持拉取请求驱动的工作流、通过自托管 runner 实现项目隔离，并支持分层运行以保证操作顺序。最多 3 名用户免费。

**[⬆️ 返回顶部](#table-of-contents)**

## 测试

* [Applitools.com](https://applitools.com/) — 针对 Web、原生移动和桌面应用的智能视觉验证。可与几乎所有自动化解决方案（如 Selenium 和 Karma）及远程运行器（Sauce Labs、Browser Stack）集成。对开源项目免费。单用户免费层，每周检查点有限。
* [Appetize](https://appetize.io) — 在基于云的 Android 手机/平板模拟器和 iPhone/iPad 模拟器中直接在浏览器测试你的 Android 和 iOS 应用。免费层包含两个并发会话，每月 30 分钟使用时间。应用大小无限制。
* [Apptim](https://apptim.com) — 一款移动测试工具，使没有性能工程技能的人也能评估应用的性能和用户体验（UX）。桌面版使用你自己的设备，100% 免费，iOS 和 Android 测试无限制。
* [Argos](https://argos-ci.com) - 面向开发者的开源视觉测试。项目数量不限，每月 5,000 张截图。对开源项目免费。
* [Bencher](https://bencher.dev/) - 持续基准测试工具套件，可捕捉 CI 性能回退。所有公开项目免费。
* [browserstack.com](https://www.browserstack.com/) — 手动及自动浏览器测试，[对开源项目免费](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - 轻量级 Web 应用测试自动化工具，易于学习，无需编写代码。你可以在自己的电脑上无限次运行测试免费。还可通过额外月费获得云监控和 CI/CD 集成。
* [Checkly](https://checklyhq.com) - 面向现代 DevOps 的代码优先合成监控。以更低价格监控 API 和应用。基于“监控即代码”工作流和 Playwright。开发者免费层额度充足。
* [checkbot.io](https://www.checkbot.io/) — 浏览器扩展，测试你的网站是否遵循 50 多项 SEO、速度和安全最佳实践。小型网站免费层。
* [CORS-Tester](https://cors-error.dev/cors-tester/) - 为开发者和 API 测试者提供的免费工具，可检查指定域名的 API 是否启用 CORS 并识别问题，提供可操作建议。
* [cypress.io](https://www.cypress.io/) - 针对任何在浏览器中运行的内容的快速、简单、可靠测试。Cypress Test Runner 始终免费开源，无任何限制。Cypress Dashboard 对开源项目免费，最多 5 用户。
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - 在浏览器中创建 AI 驱动的 Cypress 测试/POM 模型。除 AI 部分外，均为开源。免费计划每月可创建 5 个测试，支持自愈脚本、邮件与视觉测试。
* [everystep-automation.com](https://www.everystep-automation.com/) — 记录并重放网页浏览器的所有操作并生成脚本，免费版本功能有限。
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Gremlin 的混沌工程工具可安全地向系统注入故障，帮助在客户遇到问题前发现系统薄弱环节。Gremlin Free 支持在最多 5 个主机或容器上进行关机和 CPU 攻击。
* [gridlastic.com](https://www.gridlastic.com/) — Selenium Grid 测试，免费计划支持最多 4 个同时 selenium 节点/10 次 grid 启动/每月 4,000 分钟测试。
* [katalon.com](https://katalon.com) - 提供一站式测试平台，适用于各类团队和测试成熟度，包括 Katalon Studio、TestOps（+ 免费视觉测试）、TestCloud 和 Katalon Recorder。
* [Keploy](https://keploy.io/) - Keploy 是开发者的功能测试工具包。通过记录 API 调用生成 API 的端到端测试（KTests）及 mock/stub（KMocks）。对开源项目免费。
* [knapsackpro.com](https://knapsackpro.com) - 通过在任意 CI 提供商上优化测试套件并行化，加速测试。支持 Ruby、JavaScript 测试在并行 CI 节点拆分，节省时间。免费计划支持最多 10 分钟测试文件，开源项目无限制。
* [lambdatest.com](https://www.lambdatest.com/) — 基于 selenium 和 cypress 的手动、可视化、截图及自动浏览器测试，[对开源项目免费](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - 通过分析网络流量自动创建 API 和负载测试。每月可免费模拟最多 50 个并发用户，最多 60 分钟。
* [lost-pixel.com](https://lost-pixel.com) - 针对 Storybook、Ladle、Histoire 故事和 Web 应用的全面视觉回归测试。团队成员无限制，完全免费用于开源项目，每月 7,000 个快照。
* [octomind.dev](https://www.octomind.dev/) - 利用 AI 辅助生成测试用例，自动生成、运行与维护 Playwright UI 测试。
* [percy.io](https://percy.io) - 为任意 Web 应用、静态站点、样式指南或组件库添加视觉测试。团队成员无限制，Demo 应用和项目数不限，每月 5,000 个快照。
* [preflight.com](https://preflight.com) - 无代码自动化 Web 测试。在浏览器中录制对 UI 变更有弹性的测试，并在 Windows 机器上运行。可集成 CI/CD。免费计划包含每月 50 次测试运行，含视频、HTML 会话等。
* [qase.io](https://qase.io) - 面向开发和 QA 团队的测试管理系统。管理测试用例、组合测试运行、执行测试、追踪缺陷及测量影响。免费层包含所有核心功能，附件 500MB，最多 3 用户。
* [Repeato](https://repeato.app/) 基于计算机视觉和 AI 的无代码移动应用测试自动化工具。支持原生应用、flutter、react-native、web、ionic 及多种框架。免费计划对 iOS 和 Android 各限 10 个测试，但包含付费方案的大部分功能，包括不限测试运行次数。
* [Requestly](https://requestly.com/) 开源 Chrome 扩展，可拦截、重定向和 Mock HTTP 请求。包含 [Debugger](https://requestly.com/products/web-debugger/)、[Mock Server](https://requestly.com/products/mock-server/)、[API Client](https://requestly.com/products/api-client/) 及 [Session Recording](https://requestly.com/products/session-book/)。支持重定向 URL、修改 HTTP Header、Mock API、注入自定义 JS、修改 GraphQL 请求、生成 Mock API 端点、记录会话及网络/控制台日志。免费层最多可创建 10 条规则。对开源免费。
* [seotest.me](https://seotest.me/) — 免费站内 SEO 网站测试。每天免费抓取 10 个网站。提供有用的 SEO 学习资源及提升建议，适用于任何网站技术。
* [snippets.uilicious.com](https://snippets.uilicious.com) - 类似 CodePen，但用于跨浏览器测试。UI-licious 允许你编写类似用户故事的测试，并提供免费平台 UI-licious Snippets，可在 Chrome 上不限次数运行测试，每次运行最长 3 分钟，无需注册。发现 bug 可复制测试的唯一 URL 供开发复现。
* [TestCollab](https://testcollab.com) - 用户友好的测试管理软件，免费计划包含 Jira 集成、项目数不限、支持 CSV/XLSx 导入测试用例、时间跟踪及 1GB 文件存储。
* [testingbot.com](https://testingbot.com/) — Selenium 浏览器与设备测试，[对开源项目免费](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - 用于发布自动化测试结果的仪表板，并通过 GitHub 实现手动测试代码化的框架。[对开源项目免费](https://github.com/marketplace/testspace-com)，每月可发布 450 条结果。
* [tesults.com](https://www.tesults.com) — 测试结果报告与测试用例管理。集成主流测试框架。面向开源开发者、个人、教育者及入门小团队，可申请超出基础免费项目的折扣与免费服务。
* [UseWebhook.com](https://usewebhook.com) - 从浏览器捕获和检查 webhook。支持转发到本地或从历史记录重放。免费使用。
* [Vaadin](https://vaadin.com) — 用 Java 或 TypeScript 构建可扩展 UI，集成工具链、组件与设计系统，加快迭代、优化设计、简化开发流程。项目数量无限，免费维护五年。
* [websitepulse.com](https://www.websitepulse.com/tools/) — 各类免费的网络与服务器工具。
* [webhook-test.com](https://webhook-test.com) - 在集成时使用唯一 URL 调试并检查 webhook 和 HTTP 请求。完全免费，可创建无限 URL 并获得建议。
* [webhook.site](https://webhook.site) - 使用自定义 URL 验证 webhook、外部 HTTP 请求或邮件。临时 URL 和邮箱地址永久免费。
* [webhookbeam.com](https://webhookbeam.com) - 设置 webhook 并通过推送通知和邮件进行监控。

**[⬆️ 返回顶部](#table-of-contents)**

## 安全与 PKI

* [aikido.dev](https://www.aikido.dev) — 一体化应用安全平台，涵盖 SCA、SAST、CSPM、DAST、Secrets、IaC、恶意软件、容器扫描、EOL 等。免费计划包含 2 用户、扫描 10 个仓库、1 个云、2 个容器和 1 个域名。
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — 揭示你网络中已被攻陷的系统
* [Altcha.org](https://altcha.org/anti-spam) - 基于自然语言处理与机器学习的网站和 API 垃圾过滤器。免费计划每域每天 200 次请求。
* [atomist.com](https://atomist.com/) — 更快更便捷地自动化各种开发任务。目前为 Beta 版本。
* [cloudsploit.com](https://cloudsploit.com/) — AWS 安全与合规审计监控
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — 针对公有云基础设施的高置信度威胁指示（IOC），部分数据在 github (https://github.com/unknownhad/AWSAttacks) 提供。完整列表可通过 API 获得
* [CodeNotary.io](https://www.codenotary.io/) — 开源平台，提供不可篡改的证明，可对代码、文件、目录或容器进行公证
* [crypteron.com](https://www.crypteron.com/) — 面向 .NET 和 Java 应用的云优先、开发者友好型安全平台，防止数据泄露
* [CyberChef](https://gchq.github.io/CyberChef/) — 简单直观的 Web 应用，可分析和解码/编码数据，无需复杂工具或编程语言。堪比加密瑞士军刀。所有功能免费，无限制。支持自托管开源。
* [DAS](https://signup.styra.com/) — Styra DAS Free，完整生命周期策略管理，用于创建、部署和管理 Open Policy Agent (OPA) 授权
* [Datree](https://www.datree.io/) — 开源 CLI 工具，通过确保清单和 Helm Chart 遵循最佳实践及组织策略，防止 Kubernetes 配置错误
* [Dependabot](https://dependabot.com/) 支持 Ruby、JavaScript、Python、PHP、Elixir、Rust、Java（Maven 和 Gradle）、.NET、Go、Elm、Docker、Terraform、Git 子模块及 GitHub Actions 的自动依赖更新。
* [DJ Checkup](https://djcheckup.com) — 免费自动化检查你的 Django 站点的安全漏洞。由 Pony Checkup 站点分支而来。
* [Doppler](https://doppler.com/) — 通用 Secrets 管理器，支持同步到多种云服务。最多 5 用户免费，具备基本访问控制。
* [Dotenv](https://dotenv.org/) — 快速安全同步 .env 文件。无需通过 Slack 或邮件等不安全渠道分享 .env 文件，也不再丢失重要的 .env 文件。最多支持 3 位团队成员免费。
* [GitGuardian](https://www.gitguardian.com) — 通过自动化检测与修复，防止敏感信息泄露到源码中。扫描你的 git 仓库，检测 350+ 种类型的密钥和敏感文件——个人和团队（≤25 人）免费。
* [Have I been pwned?](https://haveibeenpwned.com) — 提供泄露信息查询的 REST API。
* [hostedscan.com](https://hostedscan.com) — 在线漏洞扫描工具，适用于 Web 应用、服务器和网络。每月免费 10 次扫描。
* [Infisical](https://infisical.com/) — 开源平台，支持管理团队和基础设施中的开发者密钥，适用于本地开发、预发布/生产及第三方服务。最多 5 名开发者免费。
* [Internet.nl](https://internet.nl) — 测试 IPv6、DNSSEC、HTTPS、DMARC、STARTTLS、DANE 等现代互联网标准
* [keychest.net](https://keychest.net) - SSL 到期管理与证书购买，集成 CT 数据库
* [letsencrypt.org](https://letsencrypt.org/) — 免费 SSL 证书颁发机构，证书被所有主流浏览器信任
* [meterian.io](https://www.meterian.io/) - 监控 Java、Javascript、.NET、Scala、Ruby 和 NodeJS 项目的依赖安全漏洞。免费支持 1 个私有项目，开源项目不限数量。
* [Mozilla Observatory](https://observatory.mozilla.org/) — 发现并修复你网站的安全漏洞。
* [opswat.com](https://www.opswat.com/) — 计算机、设备、应用、配置的安全监控，免费支持 25 用户及 30 天历史。
* [openapi.security](https://openapi.security/) - 免费工具，快速检查任意 OpenAPI / Swagger API 的安全性。无需注册。
* [pixee.ai](https://pixee.ai) - 自动化产品安全工程师，以免费 GitHub 机器人形式自动为你的 Java 代码库提交 PR 修复漏洞。后续将支持更多语言！
* [pyup.io](https://pyup.io) — 监控 Python 依赖安全漏洞并自动更新。免费支持 1 个私有项目，开源项目不限数量。
* [qualys.com](https://www.qualys.com/community-edition) — 检查 Web 应用漏洞，审计 OWASP 风险
* [report-uri.io](https://report-uri.io/) — CSP 和 HPKP 违规报告
* [ringcaptcha.com](https://ringcaptcha.com/) — 利用手机号作为身份工具，提供免费服务
* [seclookup.com](https://www.seclookup.com/) - Seclookup API 可丰富 SIEM 中的域名威胁指标，提供全面域名信息，提升威胁检测与响应。免费 5 万次查询 [点此领取](https://account.seclookup.com/)。
* [snyk.io](https://snyk.io) — 可发现并修复开源依赖的已知安全漏洞。对开源项目测试与修复不限。私有项目每月限 200 次测试。
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — 对任意 SSL Web 服务器配置进行深入分析
* [SOOS](https://soos.io) - 免费、无限 SCA 扫描，适用于开源项目。在发布前检测和修复安全威胁，为你的项目提供简单高效的保护方案。
* [StackHawk](https://www.stackhawk.com/) 在你的流水线中自动扫描应用，提前发现并修复安全漏洞。单应用不限扫描与环境。
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - 免费网站安全检查和恶意软件扫描
* [Protectumus](https://protectumus.com) - 免费网站安全检查，站点杀毒及 PHP 服务器防火墙（WAF）。免费层注册用户支持邮件通知。
* [TestTLS.com](https://testtls.com) - 针对安全服务器配置、证书、链等测试 SSL/TLS 服务。不仅限于 HTTPS。
* [threatconnect.com](https://threatconnect.com) — 威胁情报：适用于个人研究员、分析师及初学网络威胁情报的组织。最多 3 用户免费
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — 自动漏洞扫描。免费计划支持每周一次 XSS 扫描
* [Ubiq Security](https://ubiqsecurity.com/) — 用三行代码实现数据加解密，自动密钥管理。支持 1 个应用，每月最多 1,000,000 次加密操作免费。
* [Virgil Security](https://virgilsecurity.com/) — 提供端到端加密、数据库保护、IoT 安全等工具和服务。支持最多 250 用户的应用免费。
* [Vulert](https://vulert.com) - Vulert 持续监控你的开源依赖新漏洞，推荐修复方案，无需安装或访问你的代码库。对开源项目免费。
* [Escape GraphQL Quickscan](https://escape.tech/) - 一键扫描你的 GraphQL 端点安全性。免费，无需注册。
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - 免费在公开 GitHub 仓库、gists、issue 和评论中检索 2,000 万条泄露的密钥信息
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - 一体化 SSL 工具包，提供私钥 & CSR 生成、SSL 证书解码、证书匹配及证书订购等功能。支持通过 CNAME 记录（而非 TXT 记录）为用户免费生成 Let's Encrypt、Google Trust 和 BuyPass 的 SSL 证书。
**[⬆️ 返回顶部](#table-of-contents)**

## 认证、授权与用户管理

  * [Aserto](https://www.aserto.com) - 为应用和 API 提供细粒度授权即服务。免费额度为 1000 MAUs 和 100 个授权器实例。
  * [asgardeo.io](https://wso2.com/asgardeo) - 无缝集成 SSO、MFA、无密码认证等。包含前端与后端应用的 SDK。免费额度为 1000 MAUs 和 5 个身份提供商。
  * [Auth0](https://auth0.com/) — 托管式 SSO。免费方案包含 25,000 MAUs、无限社交连接、自定义域名等。
  * [Authgear](https://www.authgear.com) - 快速为你的应用实现无密码、OTP、2FA、SSO。前端全部内置。免费额度为 5000 MAUs。
  * [Authress](https://authress.io/) — 登录认证和访问控制，支持任意项目的无限身份提供商。Facebook、Google、Twitter 等。前 1000 次 API 调用免费。
  * [Authy](https://authy.com) - 多设备的双因素认证（2FA），支持备份。可替代 Google Authenticator。前 100 次成功认证免费。
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - 完整的授权管理系统，支持访问策略的编写、测试和部署。细粒度授权与访问控制，每月最多 100 个活跃主体免费。
  * [Clerk](https://clerk.com) — 用户管理、认证、2FA/MFA、预构建 UI 组件（登录、注册、用户资料等）。免费额度为每月 10,000 活跃用户。
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak 身份与访问管理即服务。免费额度为 100 用户和 1 个领域（realm）。
  * [Corbado](https://www.corbado.com/) — 为新应用或现有应用添加以 Passkey 为主的认证。免费无限 MAUs。
  * [Descope](https://www.descope.com/) — 高度可定制的 AuthN 流程，支持无代码和 API/SDK 方式。免费额度为每月 7,500 活跃用户，50 个租户（最多 5 个 SAML/SSO 租户）。
  * [duo.com](https://duo.com/) — 网站或应用的双因素认证（2FA）。免费支持 10 个用户，所有认证方式、无限集成、硬件令牌。
  * [Kinde](https://kinde.com/) - 简单强大的认证方案，几分钟内可集成到你的产品。免费额度为 7,500 MAU。
  * [logintc.com](https://www.logintc.com/) — 通过推送通知实现双因素认证（2FA），免费支持 10 个用户，适用于 VPN、网站和 SSH。
  * [MojoAuth](https://mojoauth.com/) - MojoAuth 让你几分钟内实现 Web、移动或任何应用的无密码认证。
  * [Okta](https://developer.okta.com/signup/) — 用户管理、认证与授权。免费额度为每月 100 活跃用户。
  * [onelogin.com](https://www.onelogin.com/) — 身份即服务（IDaaS）、单点登录（SSO）身份提供商，支持 3 个公司应用和 5 个个人应用、无限用户。
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/Zero Trust 管理安全平台。开发者账户永久免费，支持全部安全功能、无限团队成员、200 日活用户和 25,000 次/月权限检查。
  * [Permit.io](https://permit.io) - 授权即服务平台，支持 RBAC、ABAC 和 ReBAC，适用于可扩展的微服务，支持实时更新和无代码策略 UI。免费额度为每月 1000 活跃用户。
  * [Phase Two](https://phasetwo.io) - Keycloak 开源身份与访问管理。免费领域最多 1000 用户，最多 10 个 SSO 连接，基于 Phase Two 增强容器，包含 [Organization](https://phasetwo.io/product/organizations/) 扩展。
  * [SSOJet](https://ssojet.com/) - 企业级 SSO 集成，无需重构你的认证系统。免费方案包含无限月活用户、无限组织、2 个 SSO 和 2 个 SCIM 连接。
  * [Stytch](https://www.stytch.com/) - 提供认证与防欺诈的 API 和 SDK 的一体化平台。免费方案包含每月 10,000 活跃用户、无限组织、5 个 SSO 或 SCIM 连接，以及 1,000 个 M2M 令牌。
  * [Stack Auth](https://stack-auth.com) — 开源认证方案，极致开发者友好，5 分钟即可上手。可免费自托管，或使用托管 SaaS 版（含 10k 免费 MAU）。
  * [SuperTokens](https://supertokens.com/) - 开源用户认证，原生集成到你的应用，让你快速上手同时掌控用户和开发体验。免费支持最多 5000 MAUs。
  * [Warrant](https://warrant.dev/) — 企业级托管授权与访问控制服务。免费方案包含每月 100 万次 API 请求和 1,000 条授权规则。
  * [ZITADEL Cloud](https://zitadel.com) — 一站式用户与访问管理，支持多租户（B2B）场景。免费额度为 25,000 次认证请求，所有安全特性全开（OTP、无密码、策略等无额外收费）。
  * [PropelAuth](https://propelauth.com) — 只需几行代码即可立刻面向任意规模公司销售。免费额度为 200 用户和 10k 事务邮件（带有 "Powered by PropelAuth" 水印品牌）。
  * [Logto](https://logto.io/) - 开发、保护并管理你的产品的用户身份，支持认证和授权。免费额度为 5,000 MAUs，支持开源自托管选项。
  * [WorkOS](https://workos.com/) - 免费用户管理和认证，最多支持 100 万 MAUs。支持邮箱密码、社交认证、Magic Auth、MFA 等。

**[⬆️ 返回顶部](#table-of-contents)**

## 移动应用分发与反馈

  * [TestApp.io](https://testapp.io) - 检查你的移动应用是否正常工作的首选平台。免费方案：1 个应用、分析、无限版本与安装、反馈收集。
  * [Loadly](https://loadly.io) - iOS & Android 测试版应用分发服务，完全免费，无限下载、高速下载、无限上传。
  * [Diawi](https://www.diawi.com) - 直接将 iOS 和 Android 应用部署到设备。免费方案：应用上传、密码保护链接、1 天过期、10 次安装。
  * [InstallOnAir](https://www.installonair.com) - OTA 分发 iOS & Android 应用。免费方案：无限上传、私有链接、游客 2 天过期、注册用户 60 天过期。
  * [GetUpdraft](https://www.getupdraft.com) - 用于测试的移动应用分发。免费方案包含 1 个应用项目、3 个应用版本、500 MB 存储和每月 100 次应用安装。
  * [Appho.st](https://appho.st) - 移动应用托管平台。免费方案包含 5 个应用、每月 50 次下载，最大文件 100 MB。

**[⬆️ 返回顶部](#table-of-contents)**

## 管理系统

  * [bitnami.com](https://bitnami.com/) — 在 IaaS 上部署预配置应用。免费管理 1 个 AWS 微型实例
  * [Esper](https://esper.io) — 针对 Android 设备的 MDM 和 MAM，支持 DevOps。免费支持 100 台设备，1 个用户许可证，25 MB 应用存储。
  * [jamf.com](https://www.jamf.com/) — iPad、iPhone 和 Mac 设备管理，免费支持 3 台设备
  * [Miradore](https://miradore.com) — 设备管理服务。免费方案可管理无限设备并保障安全，提供基础功能。
  * [moss.sh](https://moss.sh) - 帮助开发者部署和管理 Web 应用及服务器。每月免费 25 次 git 部署。
  * [runcloud.io](https://runcloud.io/) - 主要面向 PHP 项目的服务器管理。免费支持 1 台服务器。
  * [ploi.io](https://ploi.io/) - 服务器管理工具，轻松管理部署服务器和站点。免费支持 1 台服务器。
  * [xcloud.host](https://xcloud.host) — 具有友好界面的服务器管理和部署平台。免费版支持 1 台服务器。
  * [serveravatar.com](https://serveravatar.com) — 自动化配置的 PHP Web 服务器管理与监控。免费支持 1 台服务器。

**[⬆️ 返回顶部](#table-of-contents)**

## 消息与流服务

  * [Ably](https://www.ably.com/) - 实时消息服务，支持在线状态、持久化与可靠投递。免费方案每月 300 万条消息、100 个峰值连接、100 个峰值频道。
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ 即服务。Little Lemur 方案：每月最多 100 万消息、20 个并发连接、100 个队列、10,000 个队列消息、可多可用区节点。
  * [courier.com](https://www.courier.com/) — 单一 API 支持推送、应用内、邮件、聊天、短信等消息渠道，含模板管理等功能。免费方案每月 10,000 条消息。
  * [engagespot.co](https://engagespot.co/) — 多渠道通知基础设施，内置应用内收件箱和无代码模板编辑器。免费方案每月 10,000 条消息。
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - 连接你的 MQTT 设备至云原生物联网消息代理。永久免费支持最多 100 台设备（无需信用卡）。
  * [knock.app](https://knock.app) – 开发者通知基础设施。单一 API 支持应用内、邮件、短信、Slack、推送等多渠道。免费方案每月 10,000 条消息。
  * [NotificationAPI.com](https://www.notificationapi.com/) — 5 分钟将用户通知集成到任何软件。免费方案每月 10,000 条通知 + 100 条短信和自动电话。
  * [Novu.co](https://novu.co) — 面向开发者的开源通知基础设施。简单组件和 API 一站管理所有沟通渠道：邮件、短信、直达、应用内、推送。免费方案每月 30,000 条通知，保留 90 天。
  * [pusher.com](https://pusher.com/) — 实时消息服务。免费支持最多 100 个同时连接和每日 200,000 条消息。
  * [scaledrone.com](https://www.scaledrone.com/) — 实时消息服务。免费支持最多 20 个同时连接和每日 100,000 个事件。
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) 即服务。全球 AWS、GCP、Azure。永久免费，支持 4k 消息大小、50 个活跃连接和每月 5GB 数据。
  * [pubnub.com](https://www.pubnub.com/) - Swift、Kotlin、React 消息服务，每月 100 万事务。每个事务可包含多条消息。
  * [eyeson API](https://developers.eyeson.team/) - 基于 WebRTC（SFU、MCU）的音视频通信 API，支持实时数据注入、视频布局、录制、托管 Web UI（快速启动）或定制包。开发者 [免费额度](https://apiservice.eyeson.com/api-pricing)每月 1000 分钟会议。
  * [webpushr](https://www.webpushr.com/) - Web 推送通知，最多 1 万订阅者免费、无限推送、浏览器内消息。
  * [httpSMS](https://httpsms.com) - 使用 Android 手机作为短信网关发送和接收短信。每月免费收发 200 条短信。
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - 可扩展安全的无服务器 MQTT Broker，秒速开通。每月 100 万会话分钟永久免费（无需信用卡）。
  * [Pocket Alert](https://pocketalert.app) - 向你的 iOS 和 Android 设备发送推送通知。通过 API 或 Webhook 简单集成，完整控制通知。免费方案：每天 50 条消息，支持 1 个设备、1 个应用。
  * [SuprSend](https://www.suprsend.com/) - API 优先的通知基础设施，简化产品通知。单一 API 支持事务、定时、互动等多渠道通知。免费方案每月 10,000 条通知，包含摘要、批量、多渠道、偏好、租户、广播等节点。

**[⬆️ 返回顶部](#table-of-contents)**

## 日志管理

  * [bugfender.com](https://bugfender.com/) — 每天最多 10 万日志行，24 小时保留，免费
  * [logentries.com](https://logentries.com/) — 每月最多 5 GB，7 天保留，免费
  * [loggly.com](https://www.loggly.com/) — 单用户免费，每天 200MB，7 天保留
  * [logz.io](https://logz.io/) — 每天最多 1 GB，1 天保留，免费
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Manage Engine 提供的日志管理服务。免费方案 50 GB 存储，15 天存储保留，7 天搜索。
  * [papertrailapp.com](https://papertrailapp.com/) — 48 小时搜索，7 天归档，每月 50 MB
  * [sematext.com](https://sematext.com/logsene) — 每天最多 500 MB，7 天保留，免费
  * [sumologic.com](https://www.sumologic.com/) — 每天最多 500 MB，7 天保留，免费
  * [logflare.app](https://logflare.app/) — 每应用每月最多 12,960,000 条日志，3 天保留，免费
  * [logtail.com](https://logtail.com/) — 基于 ClickHouse 的 SQL 兼容日志管理。每月 1 GB，3 天保留，免费。
  * [logzab.com](https://logzab.com/) — 审计追踪管理系统。每月免费 1,000 条用户活动日志，1 个月保留，最多 5 个项目。
  * [openobserve.ai](https://openobserve.ai/) - 每月 200 GB 日志接入免费，15 天保留
**[⬆️ 返回顶部](#table-of-contents)**

## 翻译管理

  * [crowdin.com](https://crowdin.com/) — 对于开源项目，支持无限项目、无限字符串和协作者
  * [gitlocalize.com](https://gitlocalize.com) - 私有和公共仓库均可永久免费，无限制
  * [Lecto](https://lecto.ai/) - 机器翻译API，提供免费套餐（每月30次免费请求，每次最多翻译1000字符）。集成了Loco Translate Wordpress 插件。
  * [lingohub.com](https://lingohub.com/) — 最多3名用户免费，开源项目永久免费
  * [localazy.com](https://localazy.com) - 免费支持1000条源语言字符串，无限语言，无限协作者，适合初创企业及开源项目
  * [Localeum](https://localeum.com) - 免费支持最多1000条字符串，单用户，无限语言，无限项目
  * [localizely.com](https://localizely.com/) — 开源项目永久免费
  * [Loco](https://localise.biz/) — 免费支持最多2000条翻译，无限译者，每个项目支持10种语言，每个项目1000个可翻译资产
  * [oneskyapp.com](https://www.oneskyapp.com/) — 最多5用户有限免费版，开源项目免费
  * [POEditor](https://poeditor.com/) — 免费最多支持1000条字符串
  * [SimpleLocalize](https://simplelocalize.io/) - 免费支持最多100个翻译键，无限字符串，无限语言，初创企业套餐
  * [Texterify](https://texterify.com/) - 单用户免费
  * [Tolgee](https://tolgee.io) - 提供有限翻译的免费SaaS服务，永远免费的自托管版本
  * [transifex.com](https://www.transifex.com/) — 开源项目免费
  * [Translation.io](https://translation.io) - 开源项目免费
  * [Translized](https://translized.com) - 免费支持最多1000条字符串，单用户，无限语言，无限项目
  * [webtranslateit.com](https://webtranslateit.com/) — 免费最多支持500条字符串
  * [weblate.org](https://weblate.org/) — 自由项目（libre projects）可免费使用，最多支持10,000条字符串源，免费套餐支持无限自托管部署。
  * [Free PO editor](https://pofile.net/free-po-editor) — 完全免费
  * [Lingo.dev](https://lingo.dev) – 开源AI驱动的CLI工具，用于Web和移动端本地化。可自带LLM，或通过Lingo.dev托管本地化引擎每月免费使用10,000词。

**[⬆️ 返回顶部](#table-of-contents)**

## 监控

  * [UptimeObserver.com](https://uptimeobserver.com) - 提供20个5分钟间隔的可用性监控和可自定义状态页，即使是商业用途也支持。支持通过电子邮件和Telegram实时无限通知，无需信用卡即可开始使用。
  * [Pingmeter.com](https://pingmeter.com/) - 提供5个10分钟间隔的可用性监控。支持监控SSH、HTTP、HTTPS及自定义TCP端口。
  * [alerty.ai](https://www.alerty.ai) - 免费APM和前后端、数据库等监控，包含免费代理运行。
  * [appdynamics.com](https://www.appdynamics.com/) — 免费提供24小时指标，应用性能管理代理限1个Java、1个.NET、1个PHP、1个Node.js
  * [appneta.com](https://www.appneta.com/) — 免费提供1小时数据保存
  * [appspector.com](https://appspector.com/) - 远程iOS/Android/Flutter调试的任务控制中心。小流量（64MB日志）免费。
  * [assertible.com](https://assertible.com) — 自动化API测试与监控。团队及个人免费方案。
  * [bleemeo.com](https://bleemeo.com) - 免费支持3台服务器、5个可用性监控，无限用户、无限仪表盘、无限告警规则。
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - 查询网址或网站的Core Web Vitals历史数据。
  * [checklyhq.com](https://checklyhq.com) - 开源E2E/合成监控及深度API监控，免费方案支持1用户、1万次API及网络/1500次浏览器检测。
  * [cloudsploit.com](https://cloudsploit.com) — AWS安全及配置监控。免费版：无限按需扫描，无限用户，无限账户存储。订阅版：自动扫描、API访问等。
  * [cronitor.io](https://cronitor.io/) - 针对cron任务、网站、API等的性能洞察与可用性监控。免费套餐含5个监控。
  * [datadoghq.com](https://www.datadoghq.com/) — 免费支持最多5个节点
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — 针对cron任务的监控。免费1个监控，推荐他人注册可增加名额
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60个可用性监控，5分钟间隔，支持Email、Slack通知。
  * [economize.cloud](https://economize.cloud) — 通过整理云资源优化并报告云基础设施成本。每月在Google Cloud Platform支出5,000美元以内免费。
  * [elastic.co](https://www.elastic.co/solutions/apm) — JS开发者即时性能洞察。免费24小时数据保存
  * [fivenines.io](https://fivenines.io/) — Linux服务器监控，实时仪表盘与告警，最多5台服务器，60秒间隔，永久免费，无需信用卡。
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud是可组合的可观测性平台，整合Grafana的指标与日志。免费支持3用户、10个仪表盘、100个告警，Prometheus/Graphite指标存储（10,000系列，保留14天），Loki日志存储（50GB日志，保留14天）。
  * [healthchecks.io](https://healthchecks.io) — 监控cron任务和后台任务，免费支持最多20个检查项。
  * [Hydrozen.io](https://hydrozen.io) — 可用性监控与状态页，免费套餐含10个可用性监控、5个心跳监控、1个域名监控和1个状态页。
  * [incidenthub.cloud](https://incidenthub.cloud/) — 云与SaaS状态页聚合，永久免费支持20个监控、2个通知渠道（Slack和Discord）。
  * [inspector.dev](https://www.inspector.dev) - 一分钟内搭建实时监控仪表盘，永久免费层。
  * [instrumentalapp.com](https://instrumentalapp.com) - 美观易用的应用与服务器监控，免费支持500个指标、3小时数据可视。
  * [keychest.net/speedtest](https://keychest.net/speedtest) - 针对Digital Ocean的独立速度测试与TLS握手延迟测试
  * [letsmonitor.org](https://letsmonitor.org) - SSL监控，免费最多支持5个监控
  * [linkok.com](https://linkok.com) - 在线死链检查，小型网站（100页内）免费，开源项目完全免费。
  * [loader.io](https://loader.io/) — 免费负载测试工具，有限制
  * [MonitorMonk](https://monitormonk.com) - 极简可用性监控，支持精美状态页。永久免费计划支持HTTPS、关键词、SSL及响应时间监控，最多监控10个网站或API端点，含2个仪表盘/状态页。
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata是开源的实时指标收集工具，产品持续更新，也可在GitHub获取！
  * [newrelic.com](https://www.newrelic.com) — New Relic可观测性平台，助力工程师打造更完美软件。从单体到无服务器，全面监控、分析、排查和优化。免费层每月100GB数据，1个完全访问用户和无限主用户。
  * [Middleware.io](https://middleware.io/) -  Middleware可观测性平台，为应用和技术栈提供完整可视化，支持大规模监控和诊断。开发者社区永久免费，日志监控最高100万条，基础设施和APM最多2主机。
  * [nixstats.com](https://nixstats.com) - 单台服务器免费。邮件通知、公共状态页、60秒间隔等。
  * [OnlineOrNot.com](https://onlineornot.com/) - 提供网站和API可用性监控，支持cron任务和定时任务监控，含状态页。前5个检查项，3分钟间隔免费。免费层通过Slack、Discord、Email报警。
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — 检查网站是否被中国防火长城屏蔽，通过对比中国和美国服务器的DNS结果及ASN信息识别DNS污染。
  * [opsgenie.com](https://www.opsgenie.com/) — 强大的告警和值班管理，保障服务持续在线。免费最多5用户。
  * [paessler.com](https://www.paessler.com/) — 强大的基础设施与网络监控，含告警、可视化和基础报告。免费支持100个传感器。
  * [pagecrawl.io](https://pagecrawl.io/) -  网站变更监控，免费支持6个监控，每日检查。
  * [syagent.com](https://syagent.com/) — 非商业免费服务器监控服务，含告警与指标。
  * [pagerly.io](https://pagerly.io/) -  在Slack管理值班（集成Pagerduty、OpsGenie）。免费支持1个团队（一个团队指一组值班）。
  * [pagertree.com](https://pagertree.com/) - 简洁的告警与值班管理界面，免费支持5用户。
  * [phare.io](https://phare.io/) - 可用性监控，最多10万个事件免费，支持无限项目及状态页。
  * [pingbreak.com](https://pingbreak.com/) — 现代化可用性监控服务。无限URL监控，支持通过Discord、Slack或邮件通知宕机。
  * [pingpong.one](https://pingpong.one/) — 高级状态页平台，含监控功能。免费层含1个可公开自定义SSL子域状态页。专业版对开源及非营利免费。
  * [robusta.dev](https://home.robusta.dev/) — 基于Prometheus的强大Kubernetes监控。可自带Prometheus或使用一体化包。免费层支持20个Kubernetes节点。支持Slack、Teams、Discord等告警，集成PagerDuty、OpsGenie、VictorOps、DataDog等。
  * [sematext.com](https://sematext.com/) — 免费24小时指标，无限服务器，10个自定义指标，50万自定义指标点，无限仪表盘、用户等。
  * [sitemonki.com](https://sitemonki.com/) — 网站、域名、Cron和SSL监控，每类免费5个监控
  * [sitesure.net](https://sitesure.net) - 网站和cron监控，免费支持2个监控
  * [skylight.io](https://www.skylight.io/) — 首10万次请求免费（仅限Rails）
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — 性能监控API，支持Ping、DNS等检查
  * [stathat.com](https://www.stathat.com/) — 免费开始10个统计项，无期限
  * [statuscake.com](https://www.statuscake.com/) — 网站监控，免费无限测试但有部分限制
  * [statusgator.com](https://statusgator.com/) — 状态页监控，免费3个监控
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — 服务器、可用性、DNS及域名监控。最多监控10台服务器、10个可用性、10个域名免费。
  * [thousandeyes.com](https://www.thousandeyes.com/) — 网络与用户体验监控，免费支持3个位置和20个主要Web服务数据源
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — 免费监控5个网站，60秒间隔，含公共状态页。
  * [zenduty.com](https://www.zenduty.com/) — 端到端事件管理、告警、值班管理与响应编排平台，适用于网络运维、SRE和DevOps团队。免费支持5名用户。
  * [instatus.com](https://instatus.com) - 10秒内创建精美状态页。永久免费，无限订阅与团队成员。
  * [Squadcast.com](https://squadcast.com) - Squadcast是端到端事件管理软件，助力SRE最佳实践。永久免费计划支持10用户。
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri是一款稳定的可用性监控器，支持cronjob、关键词、网站、端口、ping等类型。免费支持25次3分钟间隔的可用性检查。支持电话、短信、邮件、Webhook通知。
  * [Better Stack](https://betterstack.com/better-uptime) - 可用性监控、事件管理、值班调度/告警、状态页于一体。免费套餐支持10个监控，3分钟检查频率和状态页。
  * [Pulsetic](https://pulsetic.com) - 10个监控，6个月可用性/日志历史，无限状态页和自定义域名！永久免费，无需信用卡，无限邮件提醒。
  * [Wachete](https://www.wachete.com) - 监控5个页面，每24小时检查一次。
  * [Xitoring.com](https://xitoring.com/) — 可用性监控：20个免费，Linux/Windows服务器监控：5个免费，状态页：1个免费，支持手机App、多渠道通知等。
  * [Servervana](https://servervana.com) - 高级可用性监控，支持大型项目与团队。HTTP监控、浏览器监控、DNS监控、域名监控、状态页等。免费层包含10个HTTP监控、1个DNS监控、1个状态页。

**[⬆️ 返回顶部](#table-of-contents)**

## 崩溃与异常处理
* [CatchJS.com](https://catchjs.com/) - JavaScript 错误跟踪，支持截图和点击轨迹。对开源项目免费。
* [bugsnag.com](https://www.bugsnag.com/) — 初始试用期后每月最多 2,000 个错误免费。
* [elmah.io](https://elmah.io/) — 针对 Web 开发者的错误日志与在线监控。为开源项目提供 Small Business 免费订阅。
* [Embrace](https://embrace.io/) — 移动应用监控。每年最多 100 万用户会话的团队免费使用。
* [exceptionless](https://exceptionless.com) — 实时错误、功能、日志报告等。每月 3,000 个事件/1 用户免费。开源并可自建，使用无限制。
* [GlitchTip](https://glitchtip.com/) — 简单、开源的错误跟踪。兼容开源 Sentry SDK。每月 1,000 个事件免费，或自建部署无限制。
* [honeybadger.io](https://www.honeybadger.io) - 异常、在线状态和定时任务监控。小型团队和开源项目每月 12,000 个错误免费。
* [memfault.com](https://memfault.com) — 云端设备可观测性和调试平台。针对 [Nordic](https://app.memfault.com/register-nordic)、[NXP](https://app.memfault.com/register-nxp)、[Laird](https://app.memfault.com/register-laird) 设备，100 台设备免费。
* [rollbar.com](https://rollbar.com/) — 异常与错误监控，免费方案每月 5,000 个错误、无限用户、30 天数据保留。
* [sentry.io](https://sentry.io/) — Sentry 实时跟踪应用异常，提供小型免费方案。每月 5,000 个错误/1 用户免费，自建部署无限制使用。
* [Axiom](https://axiom.co/) — 支持存储最多 0.5 TB 日志，保留 30 天。支持 Vercel 等平台集成、高级数据查询，并支持邮件/Discord 通知。
* [Semaphr](https://semaphr.com) — 为移动应用提供免费的一体化熔断器。
* [Jam](https://jam.dev) - 一键开发者友好型 bug 报告。免费计划支持无限次 jam。
* [Whitespace](https://whitespace.dev) – 一键 bug 报告，直接在浏览器内。个人使用免费计划支持无限录制。

**[⬆️ 返回顶部](#table-of-contents)**

## 搜索

* [algolia.com](https://www.algolia.com/) — 托管搜索解决方案，支持容错、相关性和 UI 库，助力轻松创建搜索体验。免费“Build”计划包含 100 万文档、每月 1 万次搜索。还提供[开发者文档搜索](https://docsearch.algolia.com/)，免费使用。
* [bonsai.io](https://bonsai.io/) — 免费 1 GB 内存和 1 GB 存储。
* [CommandBar](https://www.commandbar.com/) - 统一搜索栏 SaaS，网页 UI 组件/插件，允许用户在产品内搜索内容、导航、功能等，提升可发现性。每月活跃用户 1,000 以内免费，无限指令。
* [Orama Cloud](https://orama.com/pricing) — 免费 3 个索引，每个索引 10 万文档，无限全量/向量/混合搜索，60 天分析。
* [searchly.com](http://www.searchly.com/) — 免费 2 个索引和 20 MB 存储。
* [easysitesearch.com](https://easysitesearch.com/) — 搜索小部件和 API，自动网络爬虫索引。每个网站最多 50 个子页面，搜索无限免费。

**[⬆️ 返回顶部](#table-of-contents)**

## 教育与职业发展

* [FreeCodeCamp](https://www.freecodecamp.org/) - 开源平台，免费课程和认证，涵盖数据分析、信息安全、Web 开发等。
* [The Odin Project](https://www.theodinproject.com/) - 免费开源平台，面向 Web 开发的 JavaScript 与 Ruby 课程体系。
* [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - 免费简历平台，提供丰富的专业简历模板，支持完整克隆、编辑、下载，ATS 优化。
* [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - 行业专家带来免费短课程，1 小时内动手体验最新生成式 AI 工具与技术。
* [LabEx](https://labex.io) - 通过交互实验和真实项目提升 Linux、DevOps、网络安全、编程、数据科学等技能。
* [Roadmap.sh](https://roadmap.sh) - 免费学习路线图，涵盖区块链到 UX 设计的各方面开发内容。
* [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - 提供与认证对应的免费课程，涵盖网络安全、网络、Python 等主题。
* [MIT OpenCourseWare](https://ocw.mit.edu/) - 麻省理工开放课程，超过 2,500 门课程资料，面向全球免费分享。YouTube 频道见 [@mitocw](https://www.youtube.com/@mitocw/featured)。
* [W3Schools](https://www.w3schools.com/) - 提供 HTML、CSS、JavaScript 等 Web 开发技术的免费教程。
* [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - 免费在线指南，学习基础和高级 HTML/CSS、JavaScript 和 SQL。
* [Full Stack Open](https://fullstackopen.com/en/) – 免费大学级现代 Web 开发课程，涵盖 React、Node.js、GraphQL、TypeScript 等。完全在线自学。
* [edX](https://www.edx.org/) - 提供来自 250 所领先机构、超 4,000 门免费在线课程，包括哈佛和 MIT，专注于计算机科学、工程和数据科学。
* [Django-tutorial.dev](https://django-tutorial.dev) - 免费 Django 入门教程，适合首次学习该框架的用户，并为用户撰写的文章提供免费 dofollow 外链。

**[⬆️ 返回顶部](#table-of-contents)**

## 邮件

* [10minutemail](https://10minutemail.com) - 免费临时邮箱，用于测试。
* [AhaSend](https://ahasend.com) - 事务型邮件服务，每月免费 1000 封邮件，免费计划支持无限域名、团队成员、webhook 和消息路由。
* [AnonAddy](https://anonaddy.com) - 开源匿名邮件转发，免费创建无限邮箱别名。
* [Antideo](https://www.antideo.com/) — 免费层每小时 10 次 API 请求，用于邮箱验证、IP 和电话验证。无需信用卡。
* [Brevo](https://www.brevo.com/) — 每月 9,000 封邮件，每日 300 封免费。
* [OneSignal](https://onesignal.com/) — 每月 10,000 封邮件，无需信用卡。
* [Bump](https://bump.email/) - 免费 10 个 Bump 邮箱地址，支持 1 个自定义域名。
* [Burnermail](https://burnermail.io/) – 免费 5 个一次性邮箱地址，1 个邮箱，7 天历史记录。
* [Buttondown](https://buttondown.email/) — 新闻通讯服务，最多 100 订阅者免费。
* [CloudMailin](https://www.cloudmailin.com/) - 通过 HTTP POST 接收邮件和事务型邮件发送，每月 10,000 封邮件免费。
* [Contact.do](https://contact.do/) — 联系表单短链服务（表单版 bitly）。
* [debugmail.io](https://debugmail.io/) — 简单易用的开发者邮件测试服务器。
* [DNSExit](https://dnsexit.com/) - 免费 2 个自有域邮箱，100MB 存储。支持 IMAP、POP3、SMTP、SPF/DKIM。
* [EmailLabs.io](https://emaillabs.io/en) — 每月免费发送最多 9,000 封邮件，每日最多 300 封。
* [EmailOctopus](https://emailoctopus.com) - 最多 2,500 订阅者、每月 10,000 封邮件免费。
* [EmailJS](https://www.emailjs.com/) – 不是完整邮件服务器，而是客户端邮件发送工具，无需暴露凭据。免费层每月 200 次请求、2 个邮件模板、请求大小 50Kb、有限联系人历史。
* [EtherealMail](https://ethereal.email) - 虚拟 SMTP 服务，主要面向 Nodemailer 和 EmailEngine 用户（不限于）。完全免费、反事务型邮件服务，消息不会真正投递。
* [Temp-Mail.org](https://temp-mail.org/en/) - 临时/一次性邮箱，支持多种域名。邮箱地址每次刷新页面都会变。完全免费，无任何价格策略。
* [TempMailDetector.com](https://tempmaildetector.com/) - 每月免费验证 200 个邮箱，判断邮箱是否临时。
* [Emailvalidation.io](https://emailvalidation.io) - 每月 100 次免费邮箱验证。
* [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - 德国临时/一次性邮箱生成器。支持 10 个域名，无限地址生成。（有广告）完全免费，无定价。
* [forwardemail.net](https://forwardemail.net) — 免费自定义域名邮件转发。创建并转发无限邮箱地址（**注意**：使用 .casa、.cf、.click、.email、.fit、.ga、.gdn、.gq、.lat、.loan、.london、.men、.ml、.pl、.rest、.ru、.tk、.top、.work TLD 需付费）。
* [Imitate Email](https://imitate.email) - 沙盒邮件服务器，测试构建/QA 和 CI/CD 邮件功能。免费账户每天 15 封邮件，无限期。
* [ImprovMX](https://improvmx.com) – 免费邮件转发。
* [EForw](https://www.eforw.com) – 一域免费邮件转发，支持接收和发送。
* [Inboxes App](https://inboxesapp.com) — 每天创建最多 3 个临时邮箱，使用 Chrome 插件可随时删除。适合测试注册流程。
* [inboxkitten.com](https://inboxkitten.com/) - 免费临时/一次性邮箱，邮件保存最多 3 天自动删除。开源，可自建。
* [mail-tester.com](https://www.mail-tester.com) — 检查邮件 DNS/SPF/DKIM/DMARC 配置，每月 20 次免费。
* [dkimvalidator.com](https://dkimvalidator.com/) - 检查邮件 DNS/SPF/DKIM/DMARC 配置，roundsphere.com 提供的免费服务。
* [mailcatcher.me](https://mailcatcher.me/) — 拦截邮件并通过 Web 界面展示。
* [mailchannels.com](https://www.mailchannels.com) - 邮件 API，支持 REST API 与 SMTP 集成，每月最多 3,000 封邮件免费。
* [Mailcheck.ai](https://www.mailcheck.ai/) - 防止用户注册临时邮箱，每小时 120 次请求（约每月 86,400 次）。
* [Mailchimp](https://mailchimp.com/) — 500 订阅者，每月 1,000 封邮件免费。
* [Maildroppa](https://maildroppa.com) - 最多 100 订阅者、无限邮件和自动化免费。
* [MailerLite.com](https://www.mailerlite.com) — 每月 1,000 订阅者、12,000 封邮件免费。
* [MailerSend.com](https://www.mailersend.com) — 邮件 API、SMTP，每月 3,000 封事务型邮件免费。
* [mailinator.com](https://www.mailinator.com/) — 免费公共邮箱系统，可自定义收件箱。
* [Mailjet](https://www.mailjet.com/) — 每月 6,000 封邮件（每日发送上限 200 封）免费。
* [Mailnesia](https://mailnesia.com) - 免费临时/一次性邮箱，自动访问注册链接。
* [mailsac.com](https://mailsac.com) - 免费 API 用于临时邮箱测试，公共邮箱托管、出站捕获、邮件推送至 Slack/websocket/webhook（每月 API 上限 1,500 次）。
* [Mailtrap.io](https://mailtrap.io/) — 开发用虚拟 SMTP 服务器，免费计划含一个收件箱、100 条消息、无团队成员、每秒 2 封、无转发规则。
* [Mail7.io](https://www.mail7.io/) — 面向 QA 开发者的免费临时邮箱，支持 Web 界面和 API 创建邮箱。
* [Momentary Email](https://www.momentaryemail.com/) — 免费临时邮箱，可通过网站或 RSS 阅读邮件。
* [Mutant Mail](https://www.mutantmail.com/) – 免费 10 个邮箱 ID、1 个域名、1 个邮箱。所有邮箱 ID 共用一个邮箱。
* [Outlook.com](https://outlook.live.com/owa/) - 免费个人邮箱与日历。
* [Parsio.io](https://parsio.io) — 免费邮件解析（转发邮件、提取数据、发送至服务器）。
* [pepipost.com](https://pepipost.com) — 首月 3 万封邮件免费，之后每日免费 100 封。
* [Plunk](https://useplunk.com) - 每月 3,000 封邮件免费。
* [Postmark](https://postmarkapp.com/) - 每月 100 封邮件免费，DMARC 周报无限制。
* [Proton Mail](https://proton.me/mail) - 免费安全邮箱服务，内置端到端加密。1GB 免费存储。
* [Queuemail.dev](https://queuemail.dev) — 稳定邮件发送 API。免费层每月 10,000 封邮件。异步发送，支持多 SMTP 服务器，黑名单、日志、跟踪、webhook 等。
* [QuickEmailVerification](https://quickemailverification.com) — 免费层每天验证 100 个邮箱，并提供 DEA 检测、DNS 查询、SPF 检测等免费 API。
* [Resend](https://resend.com) - 面向开发者的事务型邮件 API。每月免费 3,000 封邮件，每天 100 封邮件，支持一个自定义域名。
* [Sender](https://www.sender.net) 每月最多 15,000 封邮件，最多 2,500 订阅者
* [Sendpulse](https://sendpulse.com) — 每月 500 个订阅者，每月 15,000 封邮件免费
* [SimpleLogin](https://simplelogin.io/) – 开源、可自托管的邮箱别名/转发解决方案。免费提供 5 个别名，无限带宽，无限回复/发送。对教育人员（学生、研究人员等）免费。
* [Substack](https://substack.com) — 无限免费通讯服务。开始收费后才需付费。
* [Sweego](https://www.sweego.io/) - 面向开发者的欧洲事务型邮件 API。每天免费 500 封邮件。
* [Takeout](https://takeout.bysourfruit.com) - 持续更新的邮件服务，让发送邮件变得简单。每月免费 500 封事务型邮件。
* [temp-mail.io](https://temp-mail.io) — 免费的一次性临时邮箱服务，可同时拥有多个邮箱并支持转发
* [tinyletter.com](https://tinyletter.com/) — 每月 5,000 个订阅者免费
* [Touchlead](https://touchlead.app) - 多功能营销自动化工具，具备线索管理、表单生成器和自动化。有限线索和自动化数量免费。
* [trashmail.com](https://www.trashmail.com) - 免费一次性邮箱地址，支持邮件转发和自动地址失效
* [Tuta](https://tuta.com/) - 免费安全邮箱服务，内置端到端加密，无广告，无跟踪。免费 1GB 存储，一个日历（Tuta 也有[付费计划](https://tuta.com/pricing)。）。Tuta 也部分[开源](https://github.com/tutao/tutanota)，可自托管。
* [Verifalia](https://verifalia.com/email-verification-api) — 实时邮件验证 API，具备邮箱确认和一次性邮箱检测；每天免费验证 25 个邮箱。
* [verimail.io](https://verimail.io/) — 批量和 API 邮箱验证服务。每月免费验证 100 个邮箱
* [Zoho](https://www.zoho.com) — 起初为邮件服务商，现在提供一整套服务，其中部分有免费方案。含免费方案的服务列表：
   - [Email](https://zoho.com/mail) 免费支持 5 个用户。每用户 5GB 存储 & 25MB 附件限制，支持一个域名。
   - [Zoho Assist](https://www.zoho.com/assist) — Zoho Assist 的永久免费计划包含一个并发远程支持许可和 5 台无人值守电脑的访问许可，适用于专业和个人用途，无时长限制。
   - [Sprints](https://zoho.com/sprints) 免费支持 5 个用户，5 个项目 & 500MB 存储。
   - [Docs](https://zoho.com/docs) — 5 个用户免费，1GB 上传限制 & 5GB 存储。Zoho 办公套件（Writer, Sheets & Show）捆绑提供。
   - [Projects](https://zoho.com/projects) — 免费支持 3 个用户，2 个项目 & 10MB 附件限制。[Bugtracker](https://zoho.com/bugtracker) 同等方案。
   - [Connect](https://zoho.com/connect) — 团队协作免费支持 25 个用户，含三个群组、三款自定义应用、3 个看板、3 本手册和 10 个集成，同时支持频道、事件和论坛。
   - [Meeting](https://zoho.com/meeting) — 会议最多支持 3 名参会者 & 10 名网络研讨会参与者。
   - [Vault](https://zoho.com/vault) — 密码管理对个人免费开放。
   - [Showtime](https://zoho.com/showtime) — 另一款会议培训软件，远程会议最多支持 5 名参与者。
   - [Notebook](https://zoho.com/notebook) — 免费的 Evernote 替代品。
   - [Wiki](https://zoho.com/wiki) — 免费支持 3 名用户，50MB 存储，无限页面，支持 zip 备份、RSS & Atom 订阅、访问控制和可自定义 CSS。
   - [Subscriptions](https://zoho.com/subscriptions) — 循环计费管理，免费支持 20 个客户/订阅 & 1 名用户，所有支付托管均由 Zoho 完成。最近 40 条订阅指标被保留。
   - [Checkout](https://zoho.com/checkout) — 产品计费管理，最多 3 个页面 & 50 笔支付。
   - [Desk](https://zoho.com/desk) — 客户支持管理，支持三名坐席、私人知识库和邮件工单。与 [Assist](https://zoho.com/assist) 集成，支持一名远程技术员 & 5 台无人值守电脑。
   - [Cliq](https://zoho.com/cliq) — 团队聊天软件，100GB 存储，无限用户，每频道 100 用户 & SSO。
   - [Campaigns](https://zoho.com/campaigns) - 邮件营销
   - [Forms](https://zoho.com/forms) - 表单生成器
   - [Sign](https://zoho.com/sign) - 无纸化签名
   - [Surveys](https://zoho.com/surveys) - 在线调查
   - [Bookings](https://zoho.com/bookings) - 预约调度
* [Maileroo](https://maileroo.com) - 面向开发者的 SMTP 中继和邮件 API。每月 5,000 封邮件，支持无限域名、免费邮箱验证、黑名单监控、邮件测试等。

**[⬆️ 返回顶部](#table-of-contents)**

## 功能开关管理平台

* [ConfigCat](https://configcat.com) - 面向开发者的功能开关服务，支持不限团队规模，优秀的支持服务，价格合理。免费方案可用 10 个功能开关、2 个环境、1 个产品，每月 500 万次请求。
* [Flagsmith](https://flagsmith.com) - 自信发布新功能，管理 Web、移动和服务端应用的功能开关。可使用托管 API、私有云部署或本地部署。
* [GrowthBook](https://growthbook.io) - 开源功能开关与 A/B 测试平台，内置贝叶斯统计分析引擎。免费支持最多 3 名用户，无限功能开关和实验。
* [Hypertune](https://www.hypertune.com) - 类型安全的功能开关、A/B 测试、分析和应用配置，支持 Git 风格版本控制和同步、内存、本地的开关评估。免费方案支持最多 5 名团队成员、无限功能开关和 A/B 测试。
* [Molasses](https://www.molasses.app) - 强大的功能开关与 A/B 测试。免费支持 3 个环境，每个环境 5 个功能开关。
* [Toggled.dev](https://www.toggled.dev) - 企业级可扩展、多区域功能开关管理平台。免费方案支持 10 个功能开关，2 个环境，无限请求。SDK、分析仪表盘、发布日历、Slack 通知及所有其他功能均包含在永久免费计划中。
* [Statsig](https://www.statsig.com) - 强大的功能管理、A/B 测试、分析等平台。免费方案慷慨，支持无限席位、功能开关、实验和动态配置，每月最多 100 万事件。
* [Abby](https://www.tryabby.com) - 开源功能开关 & A/B 测试。代码化配置 & 全类型化 Typescript SDKs。与 Next.js、React 等框架深度集成。免费额度大，扩展便宜。

**[⬆️ 返回顶部](#table-of-contents)**

## 字体

* [dafont](https://www.dafont.com/) - 本站展示的字体均为作者所有，类型包括免费软件、共享软件、演示版或公有领域。
* [Everything Fonts](https://everythingfonts.com/) - 提供多种工具；@font-face、单位转换器、字体优化器和字体提交工具。
* [Font Squirrel](https://www.fontsquirrel.com/) - 商业可用的免费字体。人工精选字体，易于使用的格式展示。
* [Google Fonts](https://fonts.google.com/) - 许多免费字体，可以通过下载或谷歌 CDN 链接快速安装到网站上。
* [FontGet](https://www.fontget.com/) - 提供多种字体下载，并通过标签有序分类。
* [Fontshare](https://www.fontshare.com/) - 免费字体服务。专业级字体不断增长，100% 免费用于个人和商业用途。
* [Befonts](https://befonts.com/) - 提供多款独特字体，可用于个人或商业用途。
* [Font of web](https://fontofweb.com/) - 识别网站上使用的所有字体及其用法。
* [Bunny](https://fonts.bunny.net) 注重隐私的 Google Fonts 替代
* [FontsKey](https://www.fontskey.com/) - 提供免费和商用付费字体，可输入文本快速筛选。
* [fonts.xz.style](https://fonts.xz.style/) 免费开源字体分发服务，通过 CSS 向网站提供字体家族。
* [Fontsensei](https://fontsensei.com/) 开源 Google 字体，用户打标签。支持 CJK（中日韩）字体标签。

**[⬆️ 返回顶部](#table-of-contents)**

## 表单

* [Feathery](https://feathery.io) - 强大且面向开发者的表单构建器。可用于注册、登录、用户引导、支付流程、复杂金融应用等。免费方案支持每月最多 250 次提交和 5 个活跃表单。
* [Form-Data](https://form-data.com) - 无代码表单后端。垃圾邮件过滤、邮件通知与自动回复、webhook、zapier、重定向、AJAX 或 POST 等。免费方案支持无限表单、每月 20 次提交，带 Form-Data 徽章可额外获得 2000 次提交。
* [FabForm](https://fabform.io/) - 面向智能开发者的表单后端平台。免费方案每月可提交 250 次。现代友好的界面。可集成 Google Sheets、Airtable、Slack、Email 等。
* [Form.taxi](https://form.taxi/) — HTML 表单提交端点，支持通知、垃圾邮件阻挡、GDPR 合规数据处理。基础用法免费。
* [Formcarry.com](https://formcarry.com) - HTTP POST 表单端点，免费方案每月支持 100 次提交。
* [formingo.co](https://www.formingo.co/)- 静态网站易用 HTML 表单。无需注册即可免费使用。免费方案每月支持 500 次提交和可自定义的回复邮箱地址。
* [FormKeep.com](https://www.formkeep.com/) - 无限表单，每月 50 次提交，垃圾邮件防护、邮件通知、拖拽式设计器可导出 HTML。还支持自定义字段规则、团队与集成 Google Sheets、Slack、ActiveCampaign、Zapier。
* [formlets.com](https://formlets.com/) — 在线表单，无限单页表单/月，每月 100 次提交，邮件通知。
* [formspark.io](https://formspark.io/) - 表单转邮件服务，免费方案支持无限表单、每月 250 次提交，客户服务团队支持。
* [Formspree.io](https://formspree.io/) — 通过 HTTP POST 请求发送邮件。免费层每个表单每月限 50 次提交。
* [Formsubmit.co](https://formsubmit.co/) — HTML 表单的便捷端点。永久免费。无需注册。
* [Formlick.com](https://formlick.com) - Typeform 替代品，提供终身优惠。用户可创建 1 个免费表单并接收无限提交。付费后可创建无限表单和提交。
* [getform.io](https://getform.io/) - 面向设计师和开发者的表单后端平台，1 个表单，50 次提交，单文件上传，100MB 文件存储。
* [HeroTofu.com](https://herotofu.com/) - 支持机器人检测和加密归档的表单后端。可通过 UI 转发提交到邮件、Slack 或 Zapier。可自定义前端，无需服务器端代码。免费方案支持无限表单和每月 100 次提交。
* [HeyForm.net](https://heyform.net/) - 拖拽式在线表单构建器。免费层允许创建无限表单和收集无限提交，内含模板、防垃圾、100MB 文件存储。
* [Tally.so](https://tally.so/) - 99% 功能永久免费。免费层支持：无限表单、无限提交、邮件通知、表单逻辑、收款、文件上传、自定义感谢页等功能。
* [Hyperforms.app](https://hyperforms.app/) — 秒级创建表单转邮件等，无需后端代码。个人账号每月可免费提交 50 次。
* [Kwes.io](https://kwes.io/) - 功能丰富的表单端点，非常适合静态网站。免费方案支持最多 1 个网站，每月 50 次提交。
* [Pageclip](https://pageclip.co/) - 免费方案支持 1 个站点、1 个表单、每月 1,000 次提交。
* [Qualtrics Survey](https://qualtrics.com/free-account) — 用一流工具创建专业表单和调查，提供 50+ 专家设计的模板。免费账户限 1 个活跃调查、每个调查 100 个响应、8 种响应类型。
* [Screeb](https://screeb.app/) - 应用内调查与产品分析，解读用户行为。永久免费计划支持每月 500 活跃用户、无限响应与事件、丰富集成、导出与定期报告。
* [smartforms.dev](https://smartforms.dev/) - 强大易用的网站表单后端，永久免费方案支持每月 50 次提交、250MB 文件存储、Zapier 集成、CSV/JSON 导出、自定义重定向、响应页、Telegram & Slack bot、单邮件通知。
* [Survicate](https://survicate.com/) — 从所有渠道收集反馈，一站式发送后续调查。自动分析反馈并用 AI 提取洞察。支持免费邮件、网站、产品内或移动端调查、AI 问卷生成器和每月 25 个响应。
* [staticforms.xyz](https://www.staticforms.xyz/) - 无需任何服务端代码，轻松集成 HTML 表单。用户提交后，表单内容将发送到你的注册邮箱。
* [stepFORM.io](https://stepform.io) - 问卷与表单生成器。免费方案支持 5 个表单，每个表单最多 3 步，每月 50 次响应。
* [Typeform.com](https://www.typeform.com/) — 在网站上嵌入精美表单。免费方案每个表单仅限 10 个字段，每月 100 次响应。
* [WaiverStevie.com](https://waiverstevie.com) - 带有 REST API 的电子签名平台。可通过 webhook 接收通知。免费方案会水印签署文件，但支持无限信封+签名。
* [Web3Forms](https://web3forms.com) - 适用于静态及 JAMStack 网站的联系表单，无需编写后端代码。免费方案支持无限表单、无限域名和每月 250 次提交。
  * [WebAsk](https://webask.io) - 调查问卷与表单构建器。免费套餐每个账户可创建三个问卷，每月可接收100个回复，每个问卷最多10个元素。
  * [Wufoo](https://www.wufoo.com/) - 快速生成可嵌入网站的表单。免费套餐每月提交数限制为100。
  * [formpost.app](https://formpost.app) - 免费且无限制的表单转邮件服务。可免费设置自定义重定向、自动回复、Webhook 等功能。
  * [Formester.com](https://formester.com) - 在你的网站上分享和嵌入独特风格的表单——创建表单数量和功能无限制。每月可免费获取最多100条提交。
  * [SimplePDF.eu](https://simplepdf.eu/embed) - 在你的网站上嵌入 PDF 编辑器，将任何 PDF 变为可填写表单。免费套餐可无限嵌入 PDF，每个 PDF 可接收三次提交。
  * [forms.app](https://forms.app/) — 创建具备强大功能（如条件逻辑、自动评分计算器和 AI）的在线表单。免费套餐可收集多达100条回复，可将表单嵌入网站或通过链接使用。
  * [Qualli](https://usequalli.com) - 应用于移动端的应用内调查。使用 Qualli AI 设计理想问题。免费计划可试用，支持最多500月活跃用户，创建无限表单和触发器。
  * [Sprig](https://sprig.com/) - 每月1次产品内调查或带回放的调查，支持 GPT 驱动的 AI 分析。
  * [feedback.fish](https://feedback.fish/) - 免费计划允许收集总计25条反馈。提供易于集成的 React 和 Vue 组件。
  * [Vidhook](https://vidhook.io/) - 通过高响应率的愉快调查收集反馈。免费计划包括1个活跃调查、每个调查25条回复以及可自定义模板。

**[⬆️ 返回顶部](#table-of-contents)**

## 生成式 AI

  * [Zenable](https://zenable.io) - 即时自动修复 Cursor、Windsurf 和 Copilot 等工具输出，以符合公司质量与合规标准，基于代码即策略（Policy as Code）构建的护栏。免费层每天包含100次 MCP 服务器工具调用以及每天25次通过 GitHub 应用自动拉取请求审查。
  * [Keywords AI](https://keywordsai.co) - 顶级 LLM 监控平台。使用2行代码即可调用200+ LLM。每月免费请求10,000次，平台功能永久免费！
  * [Portkey](https://portkey.ai/) - 面向生成式 AI 应用的控制面板，包含可观测性套件和 AI 网关。每月免费发送和记录最多10,000次请求。
  * [Braintrust](https://www.braintrustdata.com/) - 生成式 AI 的评估、提示操场和数据管理。免费计划每周最多1,000行私有评估数据。
  * [Findr](https://www.usefindr.com/) - 通用搜索工具，一次性搜索所有应用。可使用你的信息回答问题的搜索助手。免费计划提供无限统一搜索及每日5次 copilots 查询。
  * [ReportGPT](https://ReportGPT.app) - AI 驱动的写作助手。只要自带 API Key，整个平台永久免费。
  * [Clair](https://askclair.ai/) - 临床 AI 参考工具。学生可免费访问专业工具套件，包括开放搜索、临床摘要、药品审查、药物相互作用、ICD-10 编码和管理工具。此外，专业套件也提供免费试用。
  * [Langtrace](https://langtrace.ai) - 让开发者跟踪、评估、管理提示和数据集，并调试 LLM 应用的性能相关问题。为任何 LLM 创建开放遥测标准追踪，便于可观测性，并兼容任意可观测客户端。免费计划每月提供5万条追踪。
  * [LangWatch](https://langwatch.ai) - LLMOps 平台，帮助 AI 团队衡量、监控和优化 LLM 应用的可靠性、成本效率和性能。强大的 DSPy 组件，支持工程师与非技术团队无缝协作，微调并生产化 GenAI 产品。免费计划包含全部平台功能、每月1,000条追踪和1个 DSPy 工作流优化器。[#opensource](https://github.com/langwatch/langwatch)
  * [Comet Opik](https://www.comet.com/site/products/opik/) - 在开发和生产周期评估、测试和交付 LLM 应用。[#opensource](https://github.com/comet-ml/opik/)
  * [Langfuse](https://langfuse.com/) - 开源 LLM 工程平台，助力团队协作调试、分析和迭代 LLM 应用。永久免费计划每月包含5万条观测及全部平台功能。[#opensource](https://github.com/langfuse/langfuse)
  * [Pollinations.AI](https://pollinations.ai/) - 易用的免费图像生成 AI，提供免费 API。无需注册或 API Key，支持多种嵌入网站或工作流的方式。[#opensource](https://github.com/pollinations/pollinations)
  * [Othor AI](https://othor.ai/) - 一款 AI 原生的快速、简单且安全的商业智能解决方案，可替代 Tableau、Power BI 和 Looker 等主流产品。Othor 利用大语言模型（LLM）在数分钟内交付定制化商业智能方案。永久免费计划为1个工作区、1位用户、5个数据源连接，分析不限。[#opensource](https://github.com/othorai/othor.ai)
  * [OpenRouter](https://openrouter.ai/models?q=free) - 提供多种免费 AI 模型，包括 DeepSeek R1、V3、Llama 和 Moonshot AI。这些模型擅长自然语言处理，适合多样开发需求。注意这些模型可免费使用，但有速率限制。OpenRouter 还提供高级需求的付费模型，例如 Claude、OpenAI、Grok、Gemini 和 Nova。

**[⬆️ 返回顶部](#table-of-contents)**

## CDN 与防护

  * [bootstrapcdn.com](https://www.bootstrapcdn.com/) — 为 bootstrap、bootswatch 和 fontawesome.io 提供 CDN 服务
  * [cdnjs.com](https://cdnjs.com/) — 简单、快速、可靠的内容分发。cdnjs 是一个免费且开源的 CDN 服务，被超过11%的网站信赖，基于 Cloudflare 提供动力。
  * [developers.google.com](https://developers.google.com/speed/libraries/) — Google 托管的内容分发网络，支持最流行的开源 JavaScript 库
  * [Stellate](https://stellate.co/) - Stellate 是你的 GraphQL API 的极速、高可靠 CDN，前两项服务免费。
  * [jsdelivr.com](https://www.jsdelivr.com/) — 免费、快速且可靠的开源 CDN，支持 npm、GitHub、WordPress、Deno 等。
  * [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Microsoft Ajax CDN 托管流行的第三方 JavaScript 库（如 jQuery），方便你轻松集成到 Web 应用
  * [ovh.ie](https://www.ovh.ie/ssl-gateway/) — 免费 DDoS 防护和 SSL 证书
  * [Skypack](https://www.skypack.dev/) — 100% 原生 ES Module 的 JavaScript CDN。每个域名每月免费请求100万次。
  * [raw.githack.com](https://raw.githack.com/) — 现代化的 **rawgit.com** 替代品，简单地通过 Cloudflare 托管文件
  * [section.io](https://www.section.io/) — 简单易用的 Varnish 缓存解决方案管理。承诺永久免费支持一个站点
  * [statically.io](https://statically.io/) — 针对 Git 仓库（GitHub、GitLab、Bitbucket）、WordPress 相关资源和图片的 CDN
  * [toranproxy.com](https://toranproxy.com/) — Packagist 与 GitHub 代理。永不失败的持续交付。个人使用免费，限1名开发者，不含技术支持
  * [UNPKG](https://unpkg.com/) — npm 全部内容的 CDN
  * [weserv](https://images.weserv.nl/) — 图片缓存与实时缩放服务，全球缓存，随时处理图片。
  * [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — 免费 DDoS 防护
  * [Gcore](https://gcorelabs.com/) 全球内容分发网络，每月免费1 TB 流量和100万次请求，并免费提供 DNS 托管
  * [CacheFly](https://portal.cachefly.com/signup/free2023) - 每月最多5 TB 免费 CDN 流量，19 个核心节点，1 个域名和通用 SSL。

**[⬆️ 返回顶部](#table-of-contents)**

## PaaS

  * [anvil.works](https://anvil.works) - 仅需 Python 即可进行 Web 应用开发。免费层支持无限应用和30秒超时。
  * [appwrite](https://appwrite.io) - 支持无限项目无项目暂停（支持 websockets）和认证服务。免费层每个项目包含1个数据库、3个存储桶、5个函数。
  * [configure.it](https://www.configure.it/) — 移动应用开发平台，免费支持两个项目，功能有限但无资源上限
  * [codenameone.com](https://www.codenameone.com/) — 开源、跨平台的移动应用开发工具链，适用于 Java/Kotlin 开发者。免费商用，项目数量无限
  * [deco.cx](https://www.deco.cx/en/dev) - 边缘原生前端平台，自动生成 TypeScript 代码的可视化 CMS。内置 A/B 测试、内容分割和实时分析。适用于内容密集型和企业级电商网站。免费支持每月5,000次页面浏览或开源/个人项目。
  * [Deno Deploy](https://deno.com/deploy) - 在全球边缘节点运行 JavaScript、TypeScript 和 WebAssembly 的分布式系统。免费层每天10万次请求，每月100 GiB 数据传输。
  * [domcloud.co](https://domcloud.co) – Linux 托管服务，支持 GitHub CI/CD、SSH 和 MariaDB/Postgres 数据库。免费版含1GB存储、每月1GB网络流量，并仅限免费域名。
  * [encore.dev](https://encore.dev/) — 基于静态分析的后端框架，自动提供基础设施，免样板代码等。包含面向爱好者项目的免费云托管。
  * [flightcontrol.dev](https://flightcontrol.dev/) - 以 Git 推送方式在你的 AWS 账户上部署 Web 服务、数据库等。个人 GitHub 仓库用户有免费层。AWS 资源费用由 AWS 结算，可使用 AWS 免费额度或信用。
  * [gigalixir.com](https://gigalixir.com/) - Gigalixir 为 Elixir/Phoenix 应用提供一个永不休眠的免费实例，以及一个免费层 PostgreSQL 数据库（限2个连接、1万行、无备份）。
  * [Glitch](https://glitch.com/) — 免费公共托管，支持代码共享与实时协作。免费计划每月限用1000小时。
  * [leapcell](https://leapcell.io/) - Leapcell 是可靠的分布式应用平台，支持快速增长。免费计划包含10万次服务调用、1万次异步任务、10万次 Redis 命令。
  * [pipedream.com](https://pipedream.com) - 面向开发者的集成平台。基于任意触发器开发任意工作流。工作流即代码，[永久免费](https://docs.pipedream.com/pricing/)。无需管理服务器或云资源。
  * [pythonanywhere.com](https://www.pythonanywhere.com/) — 云端 Python 应用托管。初学者账号免费，1 个 Python Web 应用，域名为 your-username.pythonanywhere.com，512MB 私有文件存储，1 个 MySQL 数据库
  * [ampt.dev](https://getampt.com/) - Ampt 让团队在 AWS 上构建、部署、扩展 JavaScript 应用，无需复杂配置或基础设施管理。免费预览计划每小时500次、每天2,500次、每月50,000次调用。自定义域名仅限付费计划。
  * [Koyeb](https://www.koyeb.com) - Koyeb 是开发者友好的无服务器平台，支持全球部署应用。可无缝运行 Docker 容器、Web 应用和 API，支持基于 git 部署、原生自动扩展、全球边缘网络和内置服务网格与发现。免费实例可在德国法兰克福或美国华盛顿部署 Web 服务。免费管理型 Postgres 数据库可用地区：德国法兰克福、美国华盛顿、新加坡。512MB 内存、2GB 存储、0.1 CPU。
  * [Napkin](https://www.napkin.io/) - FaaS，500Mb 内存，默认超时15秒，每月5,000次免费 API 调用，速率限制为每秒5次。
  * [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy 托管。Meteor 专属 PaaS，包含免费 MongoDB 共享托管和自动 SSL。
  * [Northflank](https://northflank.com) — 通过强大的 UI、API 和 CLI 构建与部署微服务、任务和托管数据库。支持从版本控制或外部 Docker 仓库无缝扩展容器。免费层含2个服务、2个定时任务和1个数据库。
  * [YepCode](https://yepcode.io) - 一体化平台，在无服务器环境中连接 API 和服务。兼具 NoCode 工具的敏捷性与编程语言的强大能力。免费层包含 [1,000 个 yep](https://yepcode.io/pricing/)。
  * [WunderGraph](https://cloud.wundergraph.com) - 开源平台，助你快速构建、发布和管理现代 API。内置 CI/CD、GitHub 集成和自动 HTTPS。免费计划支持3个项目、1GB 出站流量、每月300分钟构建时间。[价格详情](https://wundergraph.com/pricing)
  * [Zeabur](https://zeabur.com) - 一键部署服务。免费支持3个服务，每月赠送5美元额度。
  * [mogenius](https://mogenius.com) - 轻松在 Kubernetes 上构建、部署和运行服务。免费层支持将本地 Kubernetes 与 mogenius 连接，让开发者在本机创建类生产环境测试。
  * [genezio](https://genezio.com/) - 无服务器函数提供商，每月免费支持100万次函数调用、100GB 带宽和10个定时任务，仅限非商业或学术用途。

**[⬆️ 返回顶部](#table-of-contents)**

## BaaS

  * [Activepieces](https://www.activepieces.com) - 构建自动化流程，将多个应用连接到你的后端。例如，当应用中事件触发时发送 Slack 消息或添加 Google Sheet 行。每月最多5,000个任务免费。
  * [back4app.com](https://www.back4app.com) - 基于 Parse 平台的易用、灵活、可扩展后端服务。
  * [backendless.com](https://backendless.com/) — 移动与 Web BaaS，免费1GB 文件存储、每月5万次推送通知、表内1000个数据对象。
  * [bismuth.cloud](https://www.bismuth.cloud/) — AI 自动为你在函数运行时和托管存储上引导 Python API，可在我们的在线编辑器或本地用你喜欢的工具免费构建和托管。
  * [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — BMC 开发者计划提供文档和资源，助力企业构建和部署数字创新。可访问包含平台、SDK 及组件库的综合性个人沙盒，用于构建和定制应用。
  * [connectycube.com](https://connectycube.com) - 无限聊天消息、P2P 语音和视频通话、文件附件及推送通知。免费支持最多1000用户的应用。
  * [convex.dev](https://convex.dev/) - 响应式后端即服务，托管你的数据（带关系的文档和可序列化 ACID 事务）、无服务器函数，以及通过 WebSocket 向多端推送更新。小型项目免费——最多100万条记录、每月500万次函数调用。
  * [darklang.com](https://darklang.com/) - 托管语言，集成编辑器与基础设施。Beta 期间可访问，计划在 Beta 后提供慷慨的免费层。
  * [Firebase](https://firebase.com) — Firebase 助你成功构建和运行应用。免费 Spark 计划包含认证、托管、Firebase ML、实时数据库、云存储、Testlab。A/B 测试、分析、应用分发、应用索引、云消息（FCM）、崩溃分析、动态链接、应用内消息、性能监控、预测和远程配置始终免费。
  * [Flutter Flow](https://flutterflow.io) — 无需写代码即可构建 Flutter 应用 UI。也支持 Firebase 集成。免费计划可完全访问 UI 构建器和免费模板。
  * [getstream.io](https://getstream.io/) — 构建可扩展的应用内聊天、消息、视频、音频和信息流，只需几小时而非数周
  * [hasura.io](https://hasura.io/) — 无论数据库托管于何处，Hasura 都可为其提供即时安全的 GraphQL API，适用于 Web、移动及数据集成工作负载。每月1GB数据透传免费。
  * [nhost.io](https://nhost.io) - Web 和移动应用的无服务器后端。免费计划包含 PostgreSQL、GraphQL（Hasura）、认证、存储和无服务器函数。
  * [onesignal.com](https://onesignal.com/) — 无限免费推送通知。每月1万封邮件免费，无限联系人并支持自动预热。
  * [paraio.com](https://paraio.com) — 后端服务 API，支持灵活认证、全文搜索和缓存。免费支持1个应用，1GB 应用数据。
  * [pubnub.com](https://www.pubnub.com/) — 免费推送通知，最高支持每月 100 万条消息和 100 个日活设备
  * [pushbots.com](https://pushbots.com/) — 推送通知服务。每月最高可免费推送 150 万次
  * [pushcrew.com](https://pushcrew.com/) — 推送通知服务。最多支持 2,000 名订阅者，无限通知次数
  * [pusher.com](https://pusher.com/beams) — 免费、无限推送通知，支持 2000 名月活用户。为 iOS 和 Android 设备提供统一 API。
  * [quickblox.com](https://quickblox.com/) — 即时通讯、视频、语音通话和推送通知的通信后端
  * [restspace.io](https://restspace.io/) - 配置服务器，提供认证、数据、文件、邮件 API、模板等服务，可组装为数据管道并转换数据。
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — 使用拖放工具快速构建应用。通过点击自定义数据模型。使用 Apex 代码实现更高级功能。通过强大的 API 与任何系统集成。企业级安全保障。通过点击或任何前沿 Web 框架自定义 UI。免费开发者计划可访问完整的 Lightning 平台。
  * [simperium.com](https://simperium.com/) — 实时自动传输数据，多平台支持，结构化数据无限发送和存储，最多 2,500 用户/月
  * [Supabase](https://supabase.com) — 构建后端的开源 Firebase 替代方案。免费计划提供认证、实时数据库和对象存储。
  * [tyk.io](https://tyk.io/) — 提供认证、配额、监控和分析的 API 管理。提供免费云服务
  * [zapier.com](https://zapier.com/) — 连接你常用的应用，实现任务自动化。每 15 分钟可运行五个 zap，每月 100 个任务
  * [IFTTT](https://ifttt.com) — 自动化你喜欢的应用和设备。免费提供 2 个 Applet
  * [Integrately](https://integrately.com) — 一键自动化繁琐任务。免费 100 个任务，15 分钟更新一次，最多 5 个活动自动化，支持 webhook。
  * [LeanCloud](https://leancloud.app/) — 移动后端。免费提供 1GB 数据存储、256MB 实例、每天 3K API 请求和 1 万次推送。（API 与 Parse Platform 非常相似）
  * [Claw.cloud](https://run.claw.cloud) - PaaS 平台，为 GitHub 账号注册超过 180 天的用户提供每月 $5 免费额度。适合托管应用、数据库等。（[注册领取免费额度](https://ap-southeast-1.run.claw.cloud/signin)）


**[⬆️ 返回顶部](#table-of-contents)**

## 低代码平台

  * [appsmith](https://www.appsmith.com/) — 低代码项目，用于构建管理后台、内部工具和仪表盘。支持集成 15+ 数据库及任意 API。
  * [Basedash](https://www.basedash.com) — 用于构建内部管理后台和仪表盘的低代码平台。支持 SQL 数据库和 REST API。
  * [BudiBase](https://budibase.com/) — Budibase 是一个开源低代码平台，可在几分钟内创建内部应用。支持 PostgreSQL、MySQL、MSSQL、MongoDB、Rest API、Docker、K8s。
  * [Clappia](https://www.clappia.com) — 针对业务流程应用开发的低代码平台，支持自定义移动和 Web 应用。提供拖放界面、离线支持、实时位置跟踪及多种第三方服务集成。
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ 是一个低代码平台，帮助工程团队和产品经理以 10 倍速度构建内部工具、自定义用户流程、数字体验、自动化、管理后台、运营应用。
  * [lil'bots](https://www.lilbots.io/) - 在线编写和运行脚本，内置免费 API（如 OpenAI、Anthropic、Firecrawl 等）。适合构建 AI 代理/内部工具并与团队共享。免费套餐包括全部 API、AI 编码助手和每月 10,000 次执行额度。
  * [Mendix](https://www.mendix.com/) — 企业级快速应用开发，提供无限制沙盒环境，支持总用户数、每应用 0.5 GB 存储和 1 GB 内存。免费版还允许使用 Studio 和 Studio Pro IDE。
  * [outsystems.com](https://www.outsystems.com/) — 企业级 Web 开发 PaaS，支持本地或云端部署，免费“个人环境”不限代码量，数据库最高 1 GB。
  * [ReTool](https://retool.com/) — 构建内部应用的低代码平台。Retool 可高度自定义。如果你会用 JavaScript 和 API，就能用 Retool 构建应用。免费版每月最多五名用户，应用和 API 连接不限。
  * [Superblocks](https://superblocks.com/) — 面向开发者和半技术团队的开放企业应用平台。可用 AI 生成、可视化编辑并扩展代码。统一管理集成、认证、权限与审计日志。
  * [ToolJet](https://www.tooljet.com/) — 可扩展的低代码框架，用于构建业务应用。连接数据库、云存储、GraphQL、API 端点、Airtable 等，通过拖放构建器开发应用。
  * [UI Bakery](https://uibakery.io) — 低代码平台，加速自定义 Web 应用开发。支持拖放构建 UI，并可通过 JavaScript、Python、SQL 高度自定义。可云端或自托管。免费版支持最多 5 名用户。
  * [manubes](https://www.manubes.com) - 专注于工业生产管理的强大无代码云平台。免费版支持单用户，每月 100 万次流程活动（[也有德语版](https://www.manubes.de)）。

**[⬆️ 返回顶部](#table-of-contents)**

## 网站托管

  * [Alwaysdata](https://www.alwaysdata.com/) — 100 MB 免费网站托管，支持 MySQL、PostgreSQL、CouchDB、MongoDB、PHP、Python、Ruby、Node.js、Elixir、Java、Deno、自定义 Web 服务器，可通过 FTP、WebDAV 和 SSH 访问；包含邮箱、邮件列表和应用安装器。
  * [Awardspace.com](https://www.awardspace.com) — 免费网站托管 + 免费短域名，支持 PHP、MySQL、应用安装器、邮件发送，无广告。
  * [Bohr](https://bohr.io) — 非商业项目免费 + 开发者优先的部署和开发平台，极大减少基础设施麻烦，加快上线速度。
  * [Bubble](https://bubble.io/) — 可视化编程，无需代码构建 Web 和移动应用，免费版带有 Bubble 品牌标识。
  * [dAppling Network](https://www.dappling.network/) - 去中心化 Web3 前端托管平台，专注于提升在线率和安全性，并为用户提供额外访问入口。
  * [DigitalOcean](https://www.digitalocean.com/pricing) - App Platform Starter 层可免费构建和部署 3 个静态站点。
  * [Drive To Web](https://drv.tw) — 直接从 Google Drive & OneDrive 托管到网站。仅限静态站点。永久免费。每个 Google/Microsoft 账号只能建一个站点。
  * [Fenix Web Server](https://preview.fenixwebserver.com) - 开发者桌面应用，本地托管站点并实时公开分享。支持图形界面、API 和命令行任意操作。
  * [Fern](https://buildwithfern.com) - 免费计划可构建并托管基于 Markdown 的文档站点，可根据 API 定义文件自动生成 API 参考。站点托管于 _yoursite_.docs.buildwithfern.com。
  * [Free Hosting](https://freehostingnoads.net/) — 免费主机，支持 PHP 5、Perl、CGI、MySQL、FTP、文件管理器、POP 邮箱、免费子域、免费域名托管、DNS 编辑器、网站统计、免费在线支持等众多功能。
  * [Freehostia](https://www.freehostia.com) — FreeHostia 提供免费托管服务，包括业界领先的控制面板和 50+ 免费应用一键安装。即时开通，无强制广告。
  * [HelioHost](https://heliohost.org) — 非盈利免费网站托管，含 Plesk 控制面板，PHP、Node.js、Python、Django、Flask、.NET、Perl、CGI、MySQL、PostgreSQL、SQLite、IMAP/POP3/SMTP 邮箱，无限流量，免费子域，1000 MB 存储，可升级。
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — 免费部署最多 100 个静态站点，支持自定义域名及 SSL，每月 100 GB 流量，260+ Cloudflare CDN 节点。
  * [Lecturify](https://www.lecturify.net/index.en.html) - 支持 SFPT 文件上传下载，提供 PHP 的网站托管。
  * [Neocities](https://neocities.org) — 静态站点，1GB 免费存储，200GB 流量。
  * [Netlify](https://www.netlify.com/) — 构建、部署和托管静态站点/应用，免费 100GB 数据和 100GB/月流量。
  * [pantheon.io](https://pantheon.io/) — Drupal 和 WordPress 托管，自动化 DevOps，可扩展基础设施。面向开发者和代理商免费，无自定义域名。
  * [readthedocs.org](https://readthedocs.org/) — 免费文档托管，支持版本管理、PDF 生成等
  * [render.com](https://render.com) — 统一云平台，构建和运行应用及网站，免费 SSL、全球 CDN、私有网络、Git 自动部署，网站、数据库和静态网页均有完全免费计划。
  * [SourceForge](https://sourceforge.net/) — 免费查找、创建和发布开源软件
  * [surge.sh](https://surge.sh/) — 面向前端开发者的静态网站发布。支持自定义域名，无限站点
  * [telegra.ph](https://telegra.ph/) 轻松使用 Quill 创建网页
  * [tilda.cc](https://tilda.cc/) — 免费支持 1 个站点、50 页、50MB 存储，仅可用 170+ 预置模块中的主模块，不支持字体、favicon 和自定义域名
  * [Vercel](https://vercel.com/) — 构建、部署和托管 Web 应用，免费 SSL、全球 CDN，每次 `git push` 生成唯一预览地址。非常适合 Next.js 及其他静态站点生成器。
  * [Versoly](https://versoly.com/) — 面向 SaaS 的网站构建器，支持无限网站、70+ 模块、五套模板、自定义 CSS、favicon、SEO 和表单。不支持自定义域名。
  * [Qoddi](https://qoddi.com) - 类似 Heroku 的 PaaS 服务，开发者导向，功能全包。免费层支持静态资源、测试和开发者应用。
  * [FreeFlarum](https://freeflarum.com/) - 社区驱动的免费 Flarum 论坛托管，最多支持 250 用户（捐赠可移除页脚水印）。
  * [MDB GO](https://mdbgo.com/) - 免费托管一个项目，容器 TTL 两周，每项目 500MB 内存，SFTP，1GB 磁盘空间。
  * [Patr Cloud](https://patr.cloud/) — 易用的云平台，部分付费服务中可免费托管 3 个静态站点。
  * [Serv00.com](https://serv00.com/) — 3GB 免费网站托管，每日备份（保留 7 天）。支持 Crontab、SSH、代码仓库（GIT、SVN、Mercurial），支持 MySQL、PostgreSQL、MongoDB、PHP、Node.js、Python、Ruby、Java、Perl、TCL/TK、Lua、Erlang、Rust、Pascal、C、C++、D、R 等众多语言。
  - [Sevalla](https://sevalla.com/) - 简化应用、数据库和静态网站部署与管理的平台，站点限 1GB，100GB 免费流量，600 分钟免费构建时间，单账号最多 100 个站点。

**[⬆️ 返回顶部](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Cloudflare 提供的免费公共 DNS 解析器，速度快且安全（加密 DNS 查询）。可绕过运营商 DNS 封锁，防止 DNS 查询被窃听，并可[屏蔽成人及恶意内容](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families)。还可[通过 API 使用](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests)。注意：仅为 DNS 解析器，不是 DNS 托管商。
  * [1984.is](https://www.1984.is/product/freedns/) — 免费 DNS 服务，含 API 及多种其他免费 DNS 功能。
  * [cloudns.net](https://www.cloudns.net/) — 免费 DNS 托管，最多 1 个域名 50 条记录
  * [deSEC](https://desec.io) - 免费 DNS 托管，支持 API，注重安全。基于开源软件，由 [SSE](https://www.securesystems.de/) 支持。
  * [dns.he.net](https://dns.he.net/) — 免费 DNS 托管，支持动态 DNS
  * [Zonomi](https://zonomi.com/) — 免费 DNS 托管，实时生效。免费计划：1 个 DNS 区（域名），最多 10 条记录。
  * [dnspod.com](https://www.dnspod.com/) — 免费 DNS 托管。
  * [duckdns.org](https://www.duckdns.org/) — 免费 DDNS，免费层最多 5 个域名，提供多种配置教程。
  * [Dynv6.com](https://dynv6.com/) — 免费 DDNS 服务，支持 [API](https://dynv6.com/docs/apis)，支持多种 DNS 记录类型（如 CNAME、MX、SPF、SRV、TXT 等）。
  * [freedns.afraid.org](https://freedns.afraid.org/) — 免费 DNS 托管，并提供多种[用户贡献的公共域名](https://freedns.afraid.org/domain/registry/)的免费子域名。注册后在“Subdomains”菜单获取免费子域名。
  * [luadns.com](https://www.luadns.com/) — 免费 DNS 托管，支持 3 个域名，全部功能限度合理
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — 免费 DNS，不限域名数量
  * [nextdns.io](https://nextdns.io) - 基于 DNS 的防火墙，每月 30 万次免费查询
  * [noip.at](https://noip.at/) — 免费 DDNS，无需注册，无跟踪、日志或广告。域名无限制。
  * [noip](https://www.noip.com/) — 动态 DNS 服务，免费版支持最多 3 个主机名，每 30 天需确认一次
  * [sslip.io](https://sslip.io/) — 免费 DNS 服务，主机名中嵌入 IP 时可解析出对应 IP。
  * [zilore.com](https://zilore.com/en/dns) — 免费 DNS 托管，最多支持 5 个域名。
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — 免费 DNS 托管，支持动态 DNS
  * [zonewatcher.com](https://zonewatcher.com) — 自动备份和 DNS 变更监控。免费支持一个域名
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – 华为云免费 DNS 托管
  * [Hetzner](https://www.hetzner.com/dns-console) – Hetzner 提供的免费 DNS 托管，支持 API。
  * [Glauca](https://docs.glauca.digital/hexdns/) – 免费 DNS 托管，最多 3 个域名，支持 DNSSEC
  * [VolaryDDNS](https://volaryddns.net) - 免费高性能 DDNS，无需订阅或广告
**[⬆️ 返回顶部](#table-of-contents)**

## 域名

  * [pp.ua](https://nic.ua/) — 免费的 pp.ua 子域名。
  * [us.kg](https://nic.us.kg/) - 免费的 us.kg 子域名。

**[⬆️ 返回顶部](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — 兼容 AWS S3 - API、界面操作、CLI 及其他上传方式，可从 IPFS 和 Arweave 网络安全、方便、高效地上传和存储文件。注册用户可获得 6GB IPFS 存储和 300MB Arweave 存储免费额度。小于 150KB 的 Arweave 文件上传永久免费。
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 云存储。永久免费 10GB（类似 Amazon S3）的对象存储
  * [filebase.com](https://filebase.com/) - 基于区块链的 S3 兼容对象存储。5GB 免费存储，无时间限制。
  * [Tebi](https://tebi.io/) - S3 兼容对象存储。免费 25GB 存储及 250GB 出站流量。
  * [Idrive e2](https://www.idrive.com/e2/) - S3 兼容对象存储。每月 10GB 免费存储和 10GB 下载带宽。
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - S3 兼容对象存储。每月 15GB 免费存储和 15GB 下载。

**[⬆️ 返回顶部](#table-of-contents)**

## 托管数据服务

  * [Aiven](https://aiven.io/) - Aiven 在其开源数据平台上提供免费的 PostgreSQL、MySQL 和 Redis 计划。单节点，1 CPU，1GB RAM，PostgreSQL 和 MySQL 提供 5GB 存储。易于迁移至更高级别计划或跨云迁移。
  * [airtable.com](https://airtable.com/) — 看起来像电子表格，但本质是关系型数据库。无限制的基础，1200 行/基础，1000 次 API 请求/月。
  * [Astra](https://www.datastax.com/products/datastax-astra/) — 云原生 Cassandra 服务，提供 [80GB 免费层](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — 易用的 JavaScript 无服务器 API/后端和 NoSQL 数据库服务，支持函数、类似 MongoDB 的查询、键/值查找、作业系统、实时消息、工作队列、强大的 CLI 和网页数据管理器。免费计划有 5GB 存储和每分钟 60 次 API 调用。包含 2 位开发者。无需信用卡。
  * [CrateDB](https://crate.io/) - 分布式开源 SQL 数据库，适合实时分析。[免费层 CRFREE](https://crate.io/lp-crfree)：单节点 2CPU、2GiB 内存、8GiB 存储。每组织 1 集群，无需支付方式。
  * [Upstash](https://upstash.com/) — 无服务器 Redis，免费层每日最多 10,000 次请求，最大数据库 256MB，最多 20 个并发连接。
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - 永久免费层全托管数据库集群，适用于从 IoT 到 AI 的下一代应用开发。
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — 免费层提供 512MB
  * [redsmin.com](https://www.redsmin.com/) — Redis 在线实时监控和管理服务，1 个 Redis 实例免费监控
  * [redislabs](https://redislabs.com/try-free/) - 免费 30MB Redis 实例
  * [MemCachier](https://www.memcachier.com/) — 托管 Memcache 服务。最多 25MB、1 个代理服务器及基础分析免费
  * [scalingo.com](https://scalingo.com/) — 主要为 PaaS，但为 MySQL、PostgreSQL 或 MongoDB 提供 128MB 至 192MB 免费层
  * [SeaTable](https://seatable.io/) — 由 Seafile 团队打造的灵活电子表格型数据库。无限表格，2000 行，1 个月版本管理，支持最多 25 名团队成员。
  * [skyvia.com](https://skyvia.com/) — 云数据平台，提供免费层，且所有计划在测试期间完全免费
  * [StackBy](https://stackby.com/) — 集电子表格灵活性、数据库强大功能及与主流商务应用集成于一体的工具。免费计划包含不限用户、10 个堆栈，每堆栈 2GB 附件。
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB 是一款开源、兼容 MySQL 的分布式 HTAP RDBMS。TiDB Serverless 每月免费提供 5GB 行存、5GB 列存及 5000 万请求单位（RU）。
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso 赋予 SQLite 边缘数据库开发体验。Turso 提供永久免费的入门计划，包含 9GB 总存储，最多 500 个数据库，最多 3 个节点位置，每月 10 亿行读取，支持 SQLite 本地开发。
  * [InfluxDB](https://www.influxdata.com/) — 时序数据库，免费支持每 5 分钟 3MB 写入、每 5 分钟 30MB 读取以及 10,000 个基数系列
  * [restdb.io](https://restdb.io/) - 快速简洁的 NoSQL 云数据库服务，具备 schema、关系、自动 REST API（支持类似 MongoDB 查询）和高效多用户管理 UI。免费计划允许 3 用户、2500 条记录、1 秒 1 次 API 请求。
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — 免费层每月提供 5000 万 RUs 和 10GiB 存储（相当于 15 美元额度）。([什么是请求单位](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — 托管原生图数据库/分析平台，支持 Cypher 查询语言和 REST API。图大小限制：5 万节点，17.5 万关系。
  * [Neon](https://neon.tech/) — 托管 PostgreSQL，0.5GB 存储（总计），1 个项目，10 个分支，无限数据库，主分支始终可用（自动休眠 5 分钟），非主分支每月合计 20 小时活跃时间。
  * [Prisma Postgres](https://prisma.io/postgres) - 超快托管 Postgres，基于 unikernel，运行于裸金属，1GB 存储，10 个数据库，集成 Prisma ORM。
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — 托管原生图数据库，支持 GraphQL API。每日数据传输限 1MB。
  * [Tinybird](https://tinybird.co) - 托管 ClickHouse，无连接数据摄入（HTTP），支持将 SQL 查询发布为托管 HTTP API。免费层无时限，10GB 存储 + 每日 1000 次 API 请求。
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — 托管原生图数据库/分析平台，支持类 SQL 的图查询语言和 REST API。免费实例：2 vCPU，8GB 内存，50GB 存储，1 小时无活动后休眠。
  * [TerminusCMS](https://terminusdb.com/pricing) — TerminusDB（用 Prolog 和 Rust 编写的文档及图数据库）托管免费服务。开发免费，企业级部署和支持需付费。
  * [filess.io](https://filess.io) - filess.io 平台可免费创建两套数据库，每个数据库上限 10MB，支持 MySQL、MariaDB、MongoDB、PostgreSQL。
  * [xata.io](https://xata.io) - Xata 是一款内置强大搜索和分析的无服务器数据库。一个 API，多种类型安全客户端库，优化开发流程。永久免费层适合爱好者开发，包含三单元 Xata，单位定义请见官网。
  * [8base.com](https://www.8base.com/) - 8base 是为 JavaScript 开发者而建的全栈低代码开发平台，基于 MySQL、GraphQL 和无服务器后端。支持 UI 应用构建器，快速开发和扩展。免费层包含 2500 行、500 存储、1Gb/h 无服务器计算，5 客户端应用用户。
  * [Nile](https://www.thenile.dev/) — 面向 B2B 应用的 Postgres 平台。无限数据库，始终可用不休眠，1GB 总存储，5000 万查询令牌，自动扩缩容，无限向量嵌入。

**[⬆️ 返回顶部](#table-of-contents)**

## 隧道、WebRTC、Web Socket 服务器及其它路由

  * [Pinggy](https://pinggy.io) — 一条命令即可为本地服务生成公网 URL，无需下载。支持 HTTPS / TCP / TLS 隧道。免费计划隧道存活 60 分钟。
  * [conveyor.cloud](https://conveyor.cloud/) — Visual Studio 扩展，可将 IIS Express 暴露给本地网络或通过隧道映射到公网 URL。
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi 是托管 VPN 服务，可安全扩展类局域网网络至分布式团队，免费计划支持无限网络、最多 5 人。
  * [Mirna Sockets](https://mirna.cloud/) - 免费的 Socket 即服务平台，部署 Web Socket 服务器代码后可获得 wss:// URL，并可监控其性能。
  * [localhost.run](https://localhost.run/) — 将本地运行服务器通过隧道暴露为公网 URL。
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — 将本地运行服务器通过隧道暴露为公网 URL。免费托管版，[开源](https://github.com/localtunnel/localtunnel)。
  * [ngrok.com](https://ngrok.com/) — 将本地运行服务器通过隧道暴露为公网 URL。
  * [cname.dev](https://cname.dev/) — 免费安全的动态反向代理服务。
  * [serveo](https://serveo.net/) — 将本地服务器暴露到互联网。无需安装，无需注册。免费子域名，无限制。
  * [Radmin VPN](https://www.radmin-vpn.com/) — 通过 VPN 让多台电脑组建类似局域网网络。节点数无限。（Hamachi 替代品）
  * [segment.com](https://segment.com/) — 事件转发和路由至其他第三方服务的中枢。每月 100,000 事件免费
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — 零配置 VPN，采用开源 WireGuard 协议。支持 MacOS、iOS、Windows、Linux、Android。个人免费计划支持 100 台设备、3 个用户。
  * [webhookrelay.com](https://webhookrelay.com) — 管理、调试、分发和代理全部 webhook，可转发到公网或内网（如 localhost）目标。还可为内网服务器提供公网 HTTP 端点（`https://yoursubdomain.webrelay.io <----> http://localhost:8080`）。
  * [Hookdeck](https://hookdeck.com/pricing) — 随时随地开发、测试和监控 webhook。每月 10 万请求与 10 万尝试，数据保留三天。
  * [Xirsys](https://www.xirsys.com/pricing/) — 无限 STUN 使用 + 每月 500MB TURN 带宽，带宽上限，单地理区域。
  * [ZeroTier](https://www.zerotier.com) — FOSS 管理的虚拟以太网服务。免费计划可创建最多 25 客户端的无限端到端加密网络。支持桌面、移动客户端，Web 界面可配置自定义路由和私有网络新节点审批。
  * [LocalXpose](https://localxpose.io) — 反向代理，支持将本地服务器暴露到互联网。免费计划隧道存活 15 分钟。
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - 可将本地运行服务通过隧道映射到公网自定义 URL，并提供安全访问控制。免费支持一个集群下最多 5 个服务。
  * [Expose](https://expose.dev/) - 通过安全隧道暴露本地站点。免费计划包含 EU 服务器、随机子域名、单用户。
  * [btunnel](https://www.btunnel.in/) — 将 localhost 及本地 tcp 服务器暴露到互联网。免费计划包含文件服务器、自定义 http 请求与响应头、基础认证保护及 1 小时隧道超时。

**[⬆️ 返回顶部](#table-of-contents)**

## 问题跟踪与项目管理

  * [acunote.com](https://www.acunote.com/) — 免费项目管理和 SCRUM 软件，支持最多 5 位团队成员
  * [asana.com](https://asana.com/) — 私人项目协作免费
  * [Backlog](https://backlog.com) — 团队项目一站式平台。免费计划支持 1 项目、10 用户、100MB 存储。
  * [Basecamp](https://basecamp.com/personal) - 待办清单、里程碑管理、论坛式消息、文件共享与工时跟踪。最多 3 个项目、20 用户、1GB 存储空间。
  * [bitrix24.com](https://www.bitrix24.com/) — 内联网及项目管理工具。免费计划 5GB 存储，不限用户数。
  * [cacoo.com](https://cacoo.com/) — 在线实时图表：流程图、UML、网络图。免费最高支持 15 用户/图、25 张图纸
  * [Chpokify](https://chpokify.com/) — 基于团队的敏捷估算 Poker 工具，节省冲刺评估时间。免费支持 5 用户，免费 Jira 集成、无限制视频通话、团队与会议。
  * [clickup.com](https://clickup.com/) — 项目管理。免费，付费版含云存储。支持移动端与 Git 集成。
  * [Clockify](https://clockify.me) - 工时跟踪与报表应用，跨项目计工时。不限用户，永久免费。
  * [Cloudcraft](https://cloudcraft.co/) — 用 Cloudcraft 可视化设计师数分钟绘制专业架构图，专为 AWS 优化并可显示实时数据。免费计划支持单用户无限私有图表。
  * [Codegiant](https://codegiant.io) — 项目管理，含代码托管及 CI/CD。免费计划提供不限代码库、项目、文档，5 位团队成员。每月 500 CI/CD 分钟，30000 无服务器代码运行分钟，1GB 代码库空间。
  * [Confluence](https://www.atlassian.com/software/confluence) - Atlassian 的内容协作工具，助力团队高效协作与知识共享。免费计划支持最多 10 用户。
  * [contriber.com](https://www.contriber.com/) — 可定制项目管理平台，免费入门计划，5 个工作区
  * [Crosswork](https://crosswork.app/) - 多功能项目管理平台。免费支持最多 3 个项目、无限用户、1GB 存储空间。
  * [diagrams.net](https://app.diagrams.net/) — 在线流程图工具，文件本地存储于 Google Drive、OneDrive 或 Dropbox。所有功能与存储级别均免费。
  * [freedcamp.com](https://freedcamp.com/) - 任务、讨论、里程碑、时间追踪、日历、文件及密码管理器。免费计划支持无限项目、用户和文件存储。
  * [easyretro.io](https://www.easyretro.io/) — 简单直观的冲刺回顾工具。免费方案支持 3 个公开看板，每个看板每月 1 次调查。
  * [GForge](https://gforge.com) — 适用于复杂项目的项目管理和问题追踪工具，支持本地部署和 SaaS。SaaS 免费方案首 5 位用户免费，开源项目永久免费。
  * [gleek.io](https://www.gleek.io) — 面向开发者的描述转图表工具。可使用关键字快速创建非正式 UML 类、对象或实体关系图。永久免费。
  * [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector 输出两个 GraphQL schema 之间的变更列表。每个差异都被精确解释并标注为破坏性、非破坏性或危险性更改。
  * [huboard.com](https://huboard.com/) — GitHub Issues 的即时项目管理，开源项目免费。
  * [Hygger](https://hygger.io) — 项目管理平台。免费方案支持无限用户、项目及看板，100MB 存储空间。
  * [Instabug](https://instabug.com) — 移动应用全面的 bug 报告和应用内反馈 SDK。免费方案支持 1 个应用和 1 位成员。
  * [WishKit](https://wishkit.io) — 为 iOS/macOS 应用收集应用内用户反馈，并根据用户投票优先排序功能。免费方案支持 1 个应用。
  * [Ilograph](https://www.ilograph.com/)  — 交互式图表，支持多视角、多层次细节查看基础设施。图表可用代码表达。免费层支持无限私有图表，最多 3 位查看者。
  * [Jira](https://www.atlassian.com/software/jira) — 企业常用的高级软件开发项目管理工具。免费方案支持最多 10 位用户。
  * [kanbanflow.com](https://kanbanflow.com/) — 看板式项目管理。免费，付费版有更多功能。
  * [kanbantool.com](https://kanbantool.com/) — 基于看板的项目管理。免费方案支持 2 个看板和 2 位用户，不支持附件或文件。
  * [kan.bn](https://kan.bn/) - 强大灵活的看板应用，助您组织工作、跟踪进度、交付成果，全部集于一体。免费方案支持 1 位用户，拥有无限看板、列表和卡片。
  * [Kitemaker.co](https://kitemaker.co) - 协作产品开发全流程，跨 Slack、Discord、Figma、Github 跟踪工作。免费方案支持无限用户、空间，最多 250 个工作项。
  * [Kiter.app](https://www.kiter.app/) - 让任何人都能组织求职、跟踪面试、机会和人脉。强大的 Web 应用及 Chrome 扩展，完全免费。
  * [Kumu.io](https://kumu.io/)  — 支持动画、装饰、过滤、聚类、表格导入等关系图。免费层支持无限公开项目，图表大小无限制。学生可免费创建私有项目。沙盒模式支持本地编辑（上传、编辑、下载、丢弃）。
  * [Linear](https://linear.app/) — 界面流畅的问题追踪工具。免费支持无限成员，最多 10MB 文件上传，250 个问题（不含归档）。
  * [leiga.com](https://www.leiga.com/) — Leiga 是一款利用 AI 自动管理项目的 SaaS 产品，助力团队专注释放潜能，确保项目按计划推进。免费支持 10 位用户、20 个自定义字段、2GB 存储空间、AI 视频录制每个视频限 5 分钟、自动化运行每用户每月 20 次。
  * [Lucidchart](https://www.lucidchart.com/) - 在线协作流程图工具。免费方案支持 3 份可编辑文档、100 个专业模板、基础协作功能。
  * [MeisterTask](https://www.meistertask.com/) — 团队在线任务管理。免费支持最多 3 个项目和无限项目成员。
  * [MeuScrum](https://www.meuscrum.com/en) - 免费在线 Scrum 工具，带看板功能。
  * [nTask](https://www.ntaskmanager.com/) — 项目管理软件，支持团队协作、计划、分析和日常任务管理。基础方案永久免费，含 100MB 存储、5 位用户/团队。支持无限工作区、会议、分配、工时表和问题跟踪。
  * [Ora](https://ora.pm/) - 敏捷任务管理和团队协作。免费支持最多 3 位用户，单文件最大 10MB。
  * [pivotaltracker.com](https://www.pivotaltracker.com/) — 支持无限公开项目和 2 个私有项目，最多 3 位活跃用户（读写），无限被动用户（只读）。
  * [plan.io](https://plan.io/) — 支持代码托管等功能的项目管理。免费方案支持 2 位用户、10 位客户、500MB 存储。
  * [Plane](https://plane.so/) - 简单、可扩展的开源项目及产品管理工具。免费支持无限成员，单文件上传最大 5MB，最多 1000 个问题。
  * [planitpoker.com](https://www.planitpoker.com/) — 免费在线计划扑克（估算工具）。
  * [point.poker](https://www.point.poker/) - 在线计划扑克（基于共识的估算工具）。免费支持无限用户、团队、会话、轮次和投票。无需注册。
  * [ScrumFast](https://www.scrumfast.com) - 界面直观的 Scrum 看板，免费支持最多 5 位用户。
  * [Shake](https://www.shakebugs.com/) - 移动应用内 bug 报告和反馈工具。免费方案每个应用每月 10 条 bug 报告。
  * [Shortcut](https://shortcut.com/) - 项目管理平台。永久免费支持最多 10 位用户。
  * [Tadum](https://tadum.app) - 针对周期性会议设计的会议议程和纪要应用，免费支持最多 10 人团队。
  * [taiga.io](https://taiga.io/) — 面向初创和敏捷开发者的项目管理平台，开源项目免费。
  * [Tara AI](https://tara.ai/) — 简单的冲刺管理服务。免费方案支持无限任务、冲刺和工作区，无用户数量限制。
  * [targetprocess.com](https://www.targetprocess.com/) — 可视化项目管理，支持看板、Scrum 及各种运营流程。免费支持无限用户、最多 1000 个数据实体 {[更多详情](https://www.targetprocess.com/pricing/)}
  * [taskade.com](https://www.taskade.com/) — 实时协作任务列表和团队大纲。免费方案支持 1 个工作区、无限任务和项目，1GB 文件存储，1 周项目历史，视频会议最多 5 人。
  * [taskulu.com](https://taskulu.com/) — 基于角色的项目管理。免费支持最多 5 位用户。支持与 GitHub、Trello、Dropbox、Google Drive 集成。
  * [Teaminal](https://www.teaminal.com) - 远程团队站会、回顾和冲刺规划工具。免费支持最多 15 位用户。
  * [teamwork.com](https://teamwork.com/) — 项目管理与团队聊天。免费支持 5 位用户、2 个项目。提供高级版。
  * [teleretro.com](https://www.teleretro.com/) — 简单有趣的回顾工具，内置破冰、GIF 和表情。免费方案含 3 次回顾、无限成员。
  * [testlio.com](https://testlio.com/) — 问题跟踪、测试管理和 Beta 测试平台。私人使用免费。
  * [terrastruct.com](https://terrastruct.com/) — 专为软件架构设计的在线流程图工具。免费层每个图表最多 4 层。
  * [todoist.com](https://todoist.com/) — 协作及个人任务管理。免费方案支持：5 个活跃项目、每项目 5 位成员、单文件上传最大 5MB、3 个筛选器、1 周活动历史。
  * [trello.com](https://trello.com/) — 看板式项目管理。无限个人看板，团队看板最多 10 个。
  * [Tweek](https://tweek.so/) — 简单的每周待办日历与任务管理。
  * [ubertesters.com](https://ubertesters.com/) — 测试平台，集成与众测，支持 2 个项目、5 位成员。
  * [Wikifactory](https://wikifactory.com/) — 产品设计服务，集项目、版本控制和问题管理于一体。免费方案支持无限项目与协作者，3GB 存储。
  * [Yodiz](https://www.yodiz.com/) — 敏捷开发与问题跟踪。免费支持 3 位用户、无限项目。
  * [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — 免费托管 YouTrack（InCloud），适用于 FOSS 项目和私人项目（3 位用户免费）。含时间追踪和敏捷看板。
  * [zenhub.com](https://www.zenhub.com) — 唯一集成于 GitHub 的项目管理解决方案。公共仓库、开源和非营利组织免费。
  * [zenkit.com](https://zenkit.com) — 项目管理与协作工具。免费支持最多 5 位成员、5GB 附件空间。
  * [Zube](https://zube.io) — 项目管理，免费方案支持 4 个项目、4 位用户。支持 GitHub 集成。
  * [Toggl](https://toggl.com/) — 提供两款免费效率工具。[Toggl Track](https://toggl.com/track/) 为时间管理和跟踪应用，免费方案支持无限跟踪记录、项目、客户、标签、报表等，适合自由职业者。[Toggl Plan](https://toggl.com/plan/) 为任务计划工具，免费方案面向个人开发者，支持无限任务、里程碑和时间线。
  * [Sflow](https://sflow.io) — sflow.io 是为敏捷开发、市场、销售、客服等场景设计的项目管理工具，特别适合外包及跨组织协作项目。免费支持最多 3 个项目和 5 位成员。
  * [Pulse.red](https://pulse.red) — 免费极简时间追踪与工时表应用。

**[⬆️ 返回顶部](#table-of-contents)**

## 存储与媒体处理

  * [AndroidFileHost](https://androidfilehost.com/) - 免费文件分享平台，支持不限速、不限带宽、不限文件数量、不限下载次数等。主要面向 Android 开发相关文件，如 APK 构建、第三方 ROM、修改包等，但似乎也接受其他类型文件。
  * [borgbase.com](https://www.borgbase.com/) — 简单安全的 Borg Backup 异地备份托管。免费提供 10GB 备份空间和 2 个仓库。
  * [icedrive.net](https://www.icedrive.net/) - 简单云存储服务。免费 10GB 存储空间。
  * [sync.com](https://www.sync.com/) - 端到端加密云存储服务。免费 5GB 存储空间。
  * [pcloud.com](https://www.pcloud.com/) - 云存储服务。免费最多 10GB 存储空间。
  * [sirv.com](https://sirv.com/) — 智能图片 CDN，支持即时图片优化与缩放。免费层含 500MB 存储和 2GB 带宽。
  * [cloudimage.io](https://www.cloudimage.io/en/home) — 全功能图片优化与 CDN 服务，全球 1500+ 节点。提供多种图片缩放、压缩及水印功能。开源插件支持响应式图片、360° 图片制作及图片编辑。每月免费 25GB CDN 流量、25GB 缓存存储和无限转换。
  * [cloudinary.com](https://cloudinary.com/) — 图片上传、强大处理、存储及分发，支持 Ruby、Python、Java、PHP、Objective-C 等语言库。免费层每月含 25 积分。1 积分=1000 次图片处理、1GB 存储或 1GB CDN 流量。
  * [embed.ly](https://embed.ly/) — 嵌入网页媒体的 API，支持响应式图片缩放及网页元素提取。免费支持每月 5,000 个 URL，15 次请求/秒。
  * [filestack.com](https://www.filestack.com/) — 文件选择、转换与分发服务，免费支持 250 个文件、500 次转换、3GB 带宽。
  * [file.io](https://www.file.io) - 2GB 文件存储。文件下载一次后自动删除。支持 REST API 交互。速率限制为每分钟 1 次请求。
  * [freetools.site](https://freetools.site/) — 免费在线工具。支持文档、图片、音频、视频等格式的转换或编辑。
  * [GoFile.io](https://gofile.io/) - 免费文件分享与存储平台，支持网页 UI 和 API。不限文件大小、带宽、下载次数等，但文件 10 天未下载即自动删除。
  * [gumlet.com](https://www.gumlet.com/) — 图片和视频托管、处理与 CDN 流媒体。免费层每月提供 250GB 视频流量和 30GB 图片流量。
  * [image-charts.com](https://www.image-charts.com/) — 无限量图片图表生成，带水印。
  * [Imgbot](https://github.com/marketplace/imgbot) — Imgbot 是一款友好的图片优化机器人，自动优化图片节省空间，保证质量不变。开源项目免费使用。
  * [ImgBB](https://imgbb.com/) — ImgBB 是无限图片托管服务。支持拖拽上传，单张图片最大 32MB。上传后可获取图片直链、BBCode、HTML 缩略图。登录可查看上传历史。
  * [imgen](https://www.jitbit.com/imgen/) - 免费无限社交封面图生成 API，无水印。
  * [imgix](https://www.imgix.com/) - 图片缓存、管理与 CDN。免费方案支持 1000 张源图、无限转换、100GB 带宽。
  * [kraken.io](https://kraken.io/) — 网站性能图片优化服务，免费方案单文件最大 1MB。
  * [kvstore.io](https://www.kvstore.io/) — 键值存储服务。免费层支持 100 个键、每键 1KB、每小时 100 次调用。
  * [npoint.io](https://www.npoint.io/) — 支持协作 schema 编辑的 JSON 存储服务。
  * [nitropack.io](https://nitropack.io/) - 一站式前端优化（缓存、图片与代码优化、CDN），提升网站速度。免费支持每月 5,000 次页面浏览。
  * [otixo.com](https://www.otixo.com/) — 加密、分享、复制和移动所有云存储文件于一处。基础方案支持无限文件传输，单文件最大 250MB，最多 5 个加密文件。
  * [packagecloud.io](https://packagecloud.io/) — YUM、APT、RubyGem、PyPI 托管包仓库。有限免费方案和开源计划可申请。
  * [getpantry.cloud](https://getpantry.cloud/) — 简单的 JSON 数据存储 API，适合个人项目、黑客松和移动应用！
  * [Pinata IPFS](https://pinata.cloud) — Pinata 是最简单的 IPFS 文件上传与管理服务。提供友好的 UI 和 IPFS API，方便平台、创作者和收藏者。免费 1GB 存储和 API 访问。
  * [placekitten.com](https://placekitten.com/) — 快速获取猫咪图片作为占位图的简单服务。
  * [plot.ly](https://plot.ly/) — 数据可视化与分享。免费层支持无限公开文件和 10 个私有文件。
  * [podio.com](https://podio.com/) — 支持最多 5 人团队体验基础版功能（不含用户管理）。
  * [QRME.SH](https://qrme.sh) - 快速美观的批量二维码生成器，无需登录、无水印、无广告。每批次最多导出 100 个 URL。
  * [QuickChart](https://quickchart.io) — 生成可嵌入的图片图表、图形和二维码。
  * [redbooth.com](https://redbooth.com) — P2P 文件同步，免费支持最多 2 位用户。
  * [resmush.it](https://resmush.it) — reSmush.it 免费图片优化 API，已集成于 WordPress、Drupal、Magento 等常见 CMS。已优化超 70 亿张图片，永久免费。
  * [Shotstack](https://shotstack.io) - 视频批量生成与编辑 API。免费支持每月 20 分钟渲染视频。
  * [tinypng.com](https://tinypng.com/) — PNG 和 JPEG 图片压缩及缩放 API，每月免费 500 次压缩。
  * [transloadit.com](https://transloadit.com/) — 文件上传、视频音频图片文档编码。开源、慈善及学生（通过 GitHub 学生包）免费。商业应用试用 2GB 免费。
  * [twicpics.com](https://www.twicpics.com) - 响应式图片即服务。提供图片 CDN、媒体处理 API 以及前端库，实现图片优化自动化。每月最高 3GB 流量免费。
  * [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare 提供基于先进算法的媒体处理全套工具包。所有功能对开发者完全免费：文件上传 API 和 UI、图片 CDN 及源服务、自适应分发与智能压缩。免费套餐包含 3000 次上传、3GB 流量和 3GB 存储。
  * [imagekit.io](https://imagekit.io) – 图片 CDN，具有自动优化、实时转换和存储，可在几分钟内集成到现有系统中。免费套餐每月最多 20GB 流量。
  * [internxt.com](https://internxt.com) – Internxt Drive 是基于绝对隐私和极致安全的零知识文件存储服务。注册即可永久免费获得 10GB 存储空间！
  * [degoo.com](https://degoo.com/) – 基于 AI 的云存储，免费容量最高 20GB，支持三台设备，邀请好友可额外获 5GB（账户 90 天无活动将停用）。
  * [MConverter.eu](https://mconverter.eu/) – 批量转换文件。支持多种文件格式，包括如 [AVIF](https://mconverter.eu/convert/to/avif/) 等新格式。可从视频中提取所有图片帧。每天免费处理最多十个 100MB 文件，每次处理两批。
  * [ImageEngine](https://imageengine.io/) – 易用的全球图片 CDN，60 秒内即可设置。支持 AVIF 和 JPEGXL，提供 WordPress、Magento、React、Vue 等插件。开发者免费账号请[点此申请](https://imageengine.io/developer-program/)。
  * [DocsParse](https://docsparse.com/) – 基于 GPT 的 AI 处理 PDF、图片等文档，输出结构化数据（JSON、CSV、EXCEL）。每月赠送 30 次免费额度。
  * [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – 轻松为礼品卡、代金券和促销活动创建自定义二维码。支持自定义样式、颜色、Logo 等。
  * [LibreQR](https://libreqr.com) — 专注隐私且无追踪的免费二维码生成器。免费使用，无数据收集。

**[⬆️ 返回顶部](#table-of-contents)**

## 设计与 UI

  * [AllTheFreeStock](https://allthefreestock.com) - 精选免费图库、音频和视频资源列表。
  * [Float UI](https://floatui.com/) - 免费 Web 开发工具，即使非设计师也能快速创建现代响应式网站，拥有时尚设计。
  * [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page 提供由 Ant Motion 动画组件构建的模板，拥有丰富的首页模板，可下载模板代码包快速使用，也可用编辑器快速搭建专属页面。
  * [Backlight](https://backlight.dev/) — 聚焦开发者与设计师协作的完整编码平台，团队可在此构建、文档化、发布、扩展和维护设计系统。免费方案允许最多 3 名编辑协作一个设计系统，观众数量不限。
  * [BoxySVG](https://boxy-svg.com/app) — 免费可安装的 Web 应用，用于绘制 SVG 并导出为 SVG、PNG、JPEG 等格式。
  * [Carousel Hero](https://carouselhero.com/) - 免费在线工具，创建社交媒体轮播图。
  * [Circum Icons](https://circumicons.com) - 一致性的开源图标，提供 React、Vue、Svelte 等格式的 SVG。
  * [clevebrush.com](https://www.cleverbrush.com/) — 免费平面设计/照片拼贴应用，也可作为组件付费集成。
  * [cloudconvert.com](https://cloudconvert.com/) — 万能文件格式转换，支持 208 种格式，包括视频和 GIF。
  * [CodeMyUI](https://codemyui.com) - 精选 Web 设计与 UI 灵感及代码片段。
  * [ColorKit](https://colorkit.co/) - 在线创建配色方案或从顶级配色中获取灵感。
  * [coolors](https://coolors.co/) - 颜色搭配生成器。免费。
  * [CMYK Pantone](https://www.cmyktopantone.com/) - 免费秒转 CMYK 数值到最近 Pantone 色号及其他色彩模型。
  * [Branition](https://branition.com/colors) - 精选最适合品牌的手工配色方案。
  * [css-gradient.com](https://www.css-gradient.com/) - 免费工具，快速生成自定义跨浏览器 CSS 渐变，支持 RGB 和 HEX。
  * [easyvectors.com](https://easyvectors.com/) — 免费 SVG 矢量图库，免费下载优质矢量图。
  * [figma.com](https://www.figma.com) — 在线协作设计工具，免费套餐不限文件数与查看者，最多 2 名编辑、3 个项目。
  * [Flyon UI](https://flyonui.com/)- 最易用的 Tailwind CSS 组件库。
  * [framer.com](https://www.framer.com/) - Framer 助你快速迭代和动画界面创意，适用于下一个应用、网站或产品，拥有强大布局。专业验证免费套餐：不限查看者，最多 2 名编辑、3 个项目。
  * [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU 无忧模型/财产授权的商用图库
  * [Gradientos](https://www.gradientos.app) - 让渐变色选择变得简单快捷。
  * [Icon Horse](https://icon.horse) – 用简单的 API 获取任意网站的最高分辨率 favicon。
  * [Iconoir](https://iconoir.com) – 开源图标库，数千图标，支持 React、React Native、Flutter、Vue、Figma、Framer。
  * [Icons8](https://icons8.com) — 图标、插画、照片、音乐和设计工具。免费方案提供低分辨率、有限格式。使用素材需链接回 Icons8。
  * [landen.co](https://www.landen.co) — 生成、编辑并发布美观的网站和落地页，无需编码。免费套餐可拥有一个完全可自定义并在线发布的网站。
  * [Quant Ux](https://quant-ux.com/) - 原型与设计工具。完全免费且开源。
  * [lensdump.com](https://lensdump.com/) - 免费云端图片托管。
  * [Lorem Picsum](https://picsum.photos/) - 免费简易风格占位图片工具。URL 后加尺寸（宽x高）即可随机返回图片。
  * [LottieFiles](https://lottiefiles.com/) - 全球最大在线微型动画平台，服务设计师、开发者等。支持 Android、iOS、Web 的 Lottie 动画工具和插件。
  * [MagicPattern](https://www.magicpattern.design/tools) — CSS & SVG 背景渐变、图案、波形生成器及相关工具集合。
  * [marvelapp.com](https://marvelapp.com/) — 设计、原型与协作，免费套餐限 1 用户 1 项目。
  * [Mindmup.com](https://www.mindmup.com/) — 无限思维导图免费创建并云端存储，随时随地多设备访问。
  * [Mockplus iDoc](https://www.mockplus.com/idoc) - 强大的设计协作和交付工具。免费套餐含 3 用户和 5 项目，全部功能可用。
  * [mockupmark.com](https://mockupmark.com/create/free) — 免费制作 40 款真实感 T 恤及服饰产品样机，适合社交媒体和电商。
  * [Mossaik](https://mossaik.app) - 免费 SVG 图片生成器，内含波浪、图案等工具。
  * [movingpencils.com](https://movingpencils.com) — 极速浏览器矢量编辑器，完全免费。
  * [Octopus.do](https://octopus.do) — 可视化网站地图构建工具，实时构建网站结构并快速与团队或客户协作分享。
  * [Pencil](https://github.com/evolus/pencil) - 基于 Electron 的开源设计工具。
  * [Penpot](https://penpot.app) - 基于 Web 的开源设计与原型工具，支持 SVG，完全免费。
  * [pexels.com](https://www.pexels.com/) - 免费商用图库，提供 API 可按关键词搜索图片。
  * [photopea.com](https://www.photopea.com) — 免费高级在线设计编辑器，界面类似 Photoshop，支持 PSD、XCF、Sketch 等格式（兼容 Photoshop、Gimp、Sketch App）。
  * [pixlr.com](https://pixlr.com/) — 免费在线图片编辑器，功能媲美商业软件。
  * [Plasmic](https://www.plasmic.app/) - 快速、易用、强大的网页设计与页面搭建工具，可集成到代码库。支持响应式页面和复杂组件构建，可选扩展代码并发布到生产环境。
  * [Pravatar](https://pravatar.cc/) - 生成可直接热链到网页/应用的随机/占位头像。
  * [Proto.io](https://www.proto.io) - 无需编码创建完整交互式 UI 原型。免费套餐试用期结束后可保留：1 用户、1 项目、5 个原型、100MB 存储、原型预览。
  * [resizeappicon.com](https://resizeappicon.com/) — 简单的应用图标尺寸调整与管理服务。
  * [Rive](https://rive.app) — 创建并发布美观动画到任意平台。个人用户永久免费。编辑器托管所有图像，并提供多平台运行时。
  * [storyset.com](https://storyset.com/) — 免费自定义插画生成工具。
  * [smartmockups.com](https://smartmockups.com/) — 创建产品样机，提供 200 款免费样机。
  * [Shadcn Studio](https://shadcnstudio.com/theme-editor) — 实时预览主题在不同组件和布局下的效果。
  * [Tailark](https://tailark.com/) - 现代响应式 UI 区块集合，专为营销型网站设计。
  * [tabler-icons.io](https://tabler-icons.io/) — 超过 1500 个可编辑 SVG 图标，复制即用。
  * [tweakcn](https://tweakcn.com/) — 为 shadcn/ui 提供精美主题，实时自定义颜色、字体等。
  * [UI Avatars](https://ui-avatars.com/) - 根据姓名首字母生成头像，URL 可直接热链到网页/应用，支持通过 URL 配置参数。
  * [unDraw](https://undraw.co/) - 持续更新的美观 SVG 图片集合，完全免费且无需署名。
  * [unsplash.com](https://unsplash.com/) - 免费商用及非商用图库（“随心用”许可）。
  * [vectr.com](https://vectr.com/) — 免费 Web 与桌面设计应用。
  * [walkme.com](https://www.walkme.com/) — 企业级引导与交互平台，免费套餐可创建 3 个最多 5 步的引导流程。
  * [Webflow](https://webflow.com) - 可视化网站搭建与动画、托管平台。免费支持 2 个项目。
  * [Updrafts.app](https://updrafts.app) - 基于 tailwindcss 的 WYSIWYG 网站构建器。非商业用途免费。
  * [whimsical.com](https://whimsical.com/) - 协作式流程图、线框图、便利贴、思维导图。最多可创建 4 个免费看板。
  * [Zeplin](https://zeplin.io/) — 设计师与开发者协作平台。展示设计、资产和样式指南。免费支持 1 个项目。
  * [Pixelixe](https://pixelixe.com/) — 在线创建和编辑独特的高互动性图形和图片。
  * [Responsively App](https://responsively.app) - 免费开发工具，助力更快更精确地开发响应式 Web 应用。
  * [SceneLab](https://scenelab.io) - 在线样机图形编辑器，拥有不断扩充的免费设计模板库。
  * [xLayers](https://xlayers.dev) - 预览并转换 Sketch 设计文件为 Angular、React、Vue、LitElement、Stencil、Xamarin 等（开源免费：https://github.com/xlayers/xlayers）。
  * [Grapedrop](https://grapedrop.com/) — 基于 GrapesJS 框架的响应式、强大、SEO 优化网页搭建器。前 5 页免费，支持自定义域名、不限功能，易于使用。
  * [Mastershot](https://mastershot.app) - 完全免费的浏览器视频编辑器。无水印，支持最高 1080p 导出。
  * [Unicorn Platform](https://unicornplatform.com/) - 简单易用的落地页搭建与托管平台。免费可建 1 个网站。
  * [SVGmix.com](https://www.svgmix.com/) - 拥有 30 万+ 免费 SVG 图标、合集与品牌 LOGO 的海量仓库，内置简单矢量编辑器，便于快速编辑文件。
  * [svgrepo.com](https://www.svgrepo.com/) - 通过多种矢量库浏览、搜索并寻找最合适的图标或矢量素材。免费下载商用 SVG 矢量图。
  * [haikei.app](https://www.haikei.app/) - 在线生成独特 SVG 形状、背景和图案，支持与设计工具和工作流无缝集成。
  * [Canva](https://canva.com) - 免费在线设计工具，轻松创作视觉内容。
  * [Superdesigner](https://superdesigner.co) - 免费设计工具集合，只需几次点击即可生成独特背景、图案、形状和图片等。
  * [TeleportHQ](https://teleporthq.io/) - 低代码前端设计与开发平台，支持协作，极速创建并发布无头静态网站。免费 3 个项目，协作者不限，代码导出免费。
  * [vector.express](https://vector.express) — 快速便捷地转换 AI、CDR、DWG、DXF、EPS、HPGL、PDF、PLT、PS、SVG 等矢量文件。
  * [Vertopal](https://www.vertopal.com) - 免费在线文件格式转换平台。包括开发者常用的 JPG 转 SVG、GIF 转 APNG、PNG 转 WEBP、JSON 转 XML 等。
  * [okso.app](https://okso.app) - 极简在线绘图应用，快速创作草图与可视化笔记。可导出 PNG、JPG、SVG、WEBP，也可作为 PWA 安装。免费，无需注册。
  * [Wdrfree SVG](https://wdrfree.com/free-svg) - 黑白免费 SVG 剪纸文件。
  * [Lucide](https://lucide.dev) - 免费可定制且风格统一的 SVG 图标工具包。
  * [Logo.dev](https://www.logo.dev) - 公司 LOGO API，涵盖 4400 万+ 品牌，URL 调用即用。前 10,000 次 API 调用免费。
  * [MDBootstrap](https://mdbootstrap.com/) - 免费用于个人和商业用途的 Bootstrap/Angular/React/Vue UI 套件，含 700+ 组件、精美模板、1 分钟安装、丰富教程和庞大社区。
  * [TW Elements](https://tw-elements.com/) - 用 Tailwind CSS 重新实现的免费 Bootstrap 组件，设计更优，功能更强。
  * [DaisyUI](https://daisyui.com/) -- 免费。“用 Tailwind CSS，但写更少的 class 名”，提供按钮等丰富组件。
  * [Scrollbar.app](https://scrollbar.app) —— 一个简单免费的网页应用，用于为网页设计自定义滚动条。
  * [css.glass](https://css.glass/) —— 免费网页应用，使用 CSS 创建玻璃拟态设计。
  * [hypercolor.dev](https://hypercolor.dev/) —— 精选的 Tailwind CSS 渐变色集合，同时提供多种生成器，帮助你自定义渐变色。
  * [iconify.design](https://icon-sets.iconify.design/) —— 超过 100 套图标包的集合，统一界面，支持跨包搜索图标，并可将单个图标导出为 SVG 或主流 Web 框架所用格式。
  * [NextUI](https://nextui.org/) —— 免费。美观、快速且现代的 React & Next.js UI 库。
  * [Glyphs](https://glyphs.fyi/) —— 免费，网络上最强大的图标，完全可编辑且真正开源的设计系统。
  * [ShadcnUI](https://ui.shadcn.com/) —— 设计精美的组件，可直接复制粘贴到你的应用中。无障碍。可定制。开源。
  * [HyperUI](https://www.hyperui.dev/) —— 免费开源的 Tailwind CSS 组件。
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) —— 一键生成全年独特日历图标，完全免费。
  * [Image BG Blurer](https://imagebgblurer.com/) —— 生成图片的模糊背景框架，使用图片本身作为背景模糊，适用于 Notion、Trello、Jira 等工具。
  * [Webstudio](https://webstudio.is/) —— 开源的 Webflow 替代方案。免费计划支持在其域名下不限数量的网站。最多 5 个自定义域名网站。每月 1 万页面浏览量。2GB 资源存储。
  * [Nappy](https://nappy.co/) —— 免费提供黑人和棕色人种的精美照片。可用于商业和个人用途。
  * [Tailkits](https://tailkits.com/) —— 精选的 Tailwind 模板、组件和工具集合，并包含代码、网格、阴影等实用生成器。
  * [Tailcolors](https://tailcolors.com/) —— 美观的 Tailwind CSS v4 配色方案。可即时预览并复制完美的 Tailwind CSS 颜色类。
  * [Excalidraw](https://excalidraw.com/) —— 免费的在线绘图文档网页，支持本地保存和导出。
  * [Lunacy](https://icons8.com/lunacy) —— 免费的图形设计工具，支持离线使用，内置图标、照片、插画等素材，并支持实时协作。免费版包含 10 个云文档、30 天历史、低分辨率素材和基础设计工具。

**[⬆️ 返回顶部](#table-of-contents)**

## 设计灵感

  * [awwwards.](https://www.awwwards.com/) - [顶级网站] 汇集所有最佳设计网站，由设计师投票评选。
  * [Behance](https://www.behance.net/) - [设计展示] 设计师展示作品的平台。可按 UI/UX 项目等类别筛选。
  * [dribbble](https://dribbble.com/) - [设计展示] 独特的设计灵感来源，通常非真实应用。
  * [Landings](https://landings.dev/) - [网页截图] 按偏好查找最佳落地页，为你的设计提供灵感。
  * [Lapa Ninja](https://www.lapa.ninja/) - [落地页/UI 套件/网页截图] Lapa Ninja 展示了 6025 个最佳落地页案例、免费设计书籍和免费 UI 套件。
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [落地页设计] 经常更新的落地页截图，包含桌面、平板和移动端截图。
  * [Mobbin](https://mobbin.design/) - [移动端截图] 提供 50,000+ 移动应用 UI & UX 截图，完全可搜索，节省研究时间。
  * [Uiland Design](https://uiland.design/) - [移动端截图] 探索非洲及全球领先公司的移动和网页 UI 设计。
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [移动端截图] 为设计师、开发者和产品经理提供优质 UI/UX 模式（iOS 和 Android）的灵感库。
  * [Page Flows](https://pageflows.com/) - [移动/网页视频与截图] 展示众多移动和网页应用的完整流程视频及截图。高度可搜索和索引。
  * [Screenlane](https://screenlane.com/) - [移动端截图] 获取最新网页和移动应用 UI 设计趋势灵感。可按模式和应用筛选。
  * [scrnshts](https://scrnshts.club/) - [移动端截图] 精选高质量应用商店设计截图。
  * [Refero](https://refero.design/) - [网页截图] 标记和可搜索的优秀网页应用设计参考集合。

**[⬆️ 返回顶部](#table-of-contents)**

## 地图数据可视化

  * [IP Geolocation](https://ipgeolocation.io/) — 提供免费开发者计划，每月 3 万次请求。
  * [carto.com](https://carto.com/) — 基于你的数据及公共数据创建地图和地理空间 API。
  * [Clockwork Micro](https://clockworkmicro.com/) — 高效的地图工具。每月 5 万次免费查询（地图瓦片、db2vector、高程）。
  * [developers.arcgis.com](https://developers.arcgis.com) — 提供网页、桌面和移动端的地图、地理空间数据存储、分析、地理编码、路径规划等 API 和 SDK。每月 200 万张底图瓦片、2 万次非存储地理编码、2 万次简单路径、5 千次行车时间计算，以及 5GB 免费瓦片+数据存储。
  * [Foursquare](https://developer.foursquare.com/) - 通过 Places API 和 Pilgrim SDK 提供位置发现、场所搜索和内容关联服务。
  * [geoapify.com](https://www.geoapify.com/) - 提供矢量/栅格地图瓦片、地理编码、地点、路径规划、等值线 API。每天 3000 次免费请求。
  * [geocod.io](https://www.geocod.io/) — 通过 API 或 CSV 上传实现地理编码。每天 2500 次免费查询。
  * [geocodify.com](https://geocodify.com/) — 通过 API 或 CSV 上传实现地理编码和地理解析。每月 1 万次免费查询。
  * [geojs.io](https://www.geojs.io/) - 高可用的 REST/JSON/JSONP IP 地理定位查询 API。
  * [giscloud.com](https://www.giscloud.com/) — 在线可视化、分析和分享地理数据。
  * [graphhopper.com](https://www.graphhopper.com/) 免费开发者套餐，支持路径规划、路径优化、距离矩阵、地理编码和地图匹配。
  * [here](https://developer.here.com/) — 提供地图和位置感知应用的 API 和 SDK。每月 25 万次免费交易。
  * [locationiq.com](https://locationiq.com/) — 地理编码、地图与路径规划 API。每天 5000 次免费请求。
  * [mapbox.com](https://www.mapbox.com/) — 地图、地理空间服务和用于显示地图数据的 SDK。
  * [maptiler.com](https://www.maptiler.com/cloud/) — 矢量地图、地图服务及可视化 SDK。每周更新免费矢量瓦片及四种地图样式。
  * [nominatim.org](https://nominatim.org/) — OpenStreetMap 的免费地理编码服务，提供全球地址搜索和反向地理编码功能。
  * [nextbillion.ai](https://nextbillion.ai/) - 地图相关服务：地理编码、导航（路径规划、路径优化、距离矩阵）、地图 SDK（矢量、静态、移动端）。[每项服务均有免费配额](https://nextbillion.ai/pricing)。
  * [opencagedata.com](https://opencagedata.com) — 汇聚 OpenStreetMap 及其他开放地理源的地理编码 API。每天 2500 次免费查询。
  * [osmnames](https://osmnames.org/) — 地理编码，搜索结果按相关维基百科页面热度排序。
  * [positionstack](https://positionstack.com/) - 免费的全球地名与坐标地理编码。个人用户每月 25,000 次请求。
  * [stadiamaps.com](https://stadiamaps.com/) — 地图瓦片、路径规划、导航及其他地理空间 API。非商业用途和测试每天 2500 次免费地图查看与 API 请求。
  * [maps.stamen.com](http://maps.stamen.com/) - 免费地图瓦片及托管服务。
  * [ipstack](https://ipstack.com/) - 通过 IP 地址定位和识别网站访客。
  * [Geokeo api](https://geokeo.com) - 带有语言校正等功能的地理编码 API，全球覆盖。每天 2,500 次免费查询。

**[⬆️ 返回顶部](#table-of-contents)**

## 包构建系统

  * [build.opensuse.org](https://build.opensuse.org/) — 多发行版（SUSE、EL、Fedora、Debian 等）包构建服务。
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — 基于 Mock 的 Fedora 和 EL RPM 构建服务。
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — Ubuntu 与 Debian 包构建服务。

**[⬆️ 返回顶部](#table-of-contents)**

## IDE 和代码编辑

  * [3v4l](https://3v4l.org/) - 免费在线 PHP shell 和代码片段分享网站，支持 300+ PHP 版本运行你的代码。
  * [Android Studio](https://developer.android.com/studio) —— Android Studio 提供最快速的工具，用于构建各类型 Android 设备应用。开源 IDE，永久免费，最佳的 Android 应用开发工具。支持 Windows、Mac、Linux 甚至 ChromeOS。
  * [AndroidIDE](https://m.androidide.com/) —— 一个开源 IDE，可在 Android 设备上开发真实的基于 Gradle 的 Android 应用。
  * [Apache Netbeans](https://netbeans.apache.org/) —— 开发环境、工具平台和应用框架。
  * [apiary.io](https://apiary.io/) —— 协作设计 API，支持即时 API 模拟和文档生成（免费支持无限 API 蓝图和用户，但仅限一个管理员账号和托管文档）。
  * [BBEdit](https://www.barebones.com/) - BBEdit 是一款流行且可扩展的 macOS 编辑器。免费模式提供[强大的核心功能集](https://www.barebones.com/products/bbedit/comparison.html)并可升级至高级功能。
  * [Binder](https://mybinder.org/) - 将 Git 仓库变为交互式笔记本合集。免费公共服务。
  * [BlueJ](https://bluej.org) —— 免费的 Java 开发环境，专为初学者设计，全球数百万用户。由 Oracle 支持，简单的 GUI 帮助初学者入门。
  * [Bootify.io](https://bootify.io/) - Spring Boot 应用生成器，支持自定义数据库和 REST API。
  * [Brackets](http://brackets.io/) - Brackets 是一款专为网页开发设计的开源文本编辑器。轻量易用，高度可定制。
  * [cacher.io](https://www.cacher.io) —— 代码片段管理器，支持标签和 100+ 种编程语言。
  * [Code::Blocks](https://codeblocks.org) —— 免费 Fortran & C/C++ IDE。开源，支持 Windows、macOS 和 Linux。
  * [Cody](https://sourcegraph.com/cody) - 免费 AI 编程助手，支持代码编写（代码块、自动补全、单元测试）、理解（全局代码库知识）、修复和查找。适用于 VS Code、JetBrains 和在线平台。
  * [codiga.io](https://codiga.io/) —— 编程助手，可在 IDE 中直接搜索、定义和复用代码片段。个人和小型组织免费。
  * [codesnip.com.br](https://codesnip.com.br) —— 简单的代码片段管理器，支持分类、搜索和标签。免费且无限制。
  * [cocalc.com](https://cocalc.com/) ——（前身为 SageMathCloud at cloud.sagemath.com）—— 云端协作计算。通过浏览器访问完整 Ubuntu，内置协作工具和丰富的数学、科学、数据科学免费软件，预装：Python、LaTeX、Jupyter 笔记本、SageMath、scikitlearn 等。
  * [code.cs50.io](https://code.cs50.io/) - CS50 的 Visual Studio Code 网页应用，专为学生和教师适配 GitHub Codespaces。
  * [codepen.io](https://codepen.io/) —— CodePen 是前端开发的实验场。
  * [codesandbox.io](https://codesandbox.io/) —— React、Vue、Angular、Preact 等框架的在线实验平台。
  * [Components.studio](https://webcomponents.dev/) - 独立编写代码组件，支持故事化可视化、测试，并发布到 npm。
  * [Eclipse Che](https://www.eclipse.org/che/) - 面向开发团队的 Web 和 Kubernetes 原生 IDE，支持多语言。开源、社区驱动。Red Hat 提供在线实例：[workspaces.openshift.com](https://workspaces.openshift.com/)。
  * [fakejson.com](https://fakejson.com/) —— FakeJSON 通过 API 快速生成假数据。只需发起 API 请求，描述你想要的数据，API 会以 JSON 返回所有内容，加速创意的落地和测试。
  * [GetVM](https://getvm.io) —— 即时免费 Linux 与 IDE Chrome 侧边栏。免费套餐每天可用 5 个虚拟机。
  * [GitPod](https://www.gitpod.io) — 为 GitHub 项目提供即时、可随时编码的开发环境。免费套餐包含每月 50 小时。
  * [ide.goorm.io](https://ide.goorm.io) goormIDE 是云上的全功能 IDE。支持多语言，通过功能齐全的基于 Web 的终端提供基于 Linux 的容器，端口转发，自定义 URL，实时协作和聊天，分享链接，Git/Subversion 支持，还有更多功能（免费套餐包含每个容器 1GB 内存和 10GB 存储，5 个容器插槽）。
  * [JDoodle](https://www.jdoodle.com) — 支持 60 多种编程语言的在线编译器和编辑器，免费计划每天可通过 REST API 编译代码上限为 200 次。
  * [jetbrains.com](https://jetbrains.com/products.html) — 生产力工具、IDE 和部署工具（如 [IntelliJ IDEA](https://www.jetbrains.com/idea/)、[PyCharm](https://www.jetbrains.com/pycharm/) 等）。为学生、教师、开源项目和用户组提供免费许可。
  * [jsbin.com](https://jsbin.com) — JS Bin 是一个前端 Web（HTML、CSS 和 JavaScript）代码演示和分享平台。还支持 Markdown、Jade 和 Sass。
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle 是一个前端 Web 代码演示和分享网站，支持协作。
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) 提供一些以 JSON 格式返回虚假数据的 REST API 端点。如果你想在本地运行服务器，源码也可用。
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus 是一个兼容 Delphi 的跨平台快速应用开发 IDE。
  * [MarsCode](https://www.marscode.com/) - 免费的 AI 驱动云端 IDE。
  * [micro-jaymock](https://micro-jaymock.now.sh/) - 用于生成虚假 JSON 数据的微型 API 模拟微服务。
  * [mockable.io](https://www.mockable.io/) — Mockable 是一个简单可配置的服务，用于模拟 RESTful API 或 SOAP Web 服务。该在线服务允许你快速定义 REST API 或 SOAP 端点，并返回 JSON 或 XML 数据。
  * [mockaroo](https://mockaroo.com/) — Mockaroo 可生成现实的测试数据，支持 CSV、JSON、SQL 和 Excel 格式。你还可以为后端 API 创建 Mock。
  * [Mocklets](https://mocklets.com) - 基于 HTTP 的模拟 API 仿真器，帮助模拟 API 以实现更快的并行开发和更全面的测试，提供永久免费套餐。
  * [Paiza](https://paiza.cloud/en/) — 在浏览器中开发 Web 应用，无需任何设置。免费计划提供一台服务器，24 小时生命周期，每天 4 小时运行时间，2 核 CPU，2GB 内存，1GB 存储。
  * [Prepros](https://prepros.io/) - Prepros 可直接编译 Sass、Less、Stylus、Pug/Jade、Haml、Slim、CoffeeScript 和 TypeScript，自动刷新浏览器，轻松开发和测试网站，让你专注于打造完美产品。你也可以通过几次点击添加自己的工具。
  * [Replit](https://replit.com/) — 支持多种编程语言的云端编程环境。
  * [SoloLearn](https://code.sololearn.com) — 一个适合运行代码片段的云端编程演练场。支持多种编程语言。运行代码无需注册，但在平台上保存代码需注册。还为初学者和中级开发者提供免费课程。
  * [stackblitz.com](https://stackblitz.com/) — 在线/云端代码 IDE，可创建、编辑、部署全栈应用。支持任何主流基于 NodeJs 的前后端框架。新建项目快捷链接：[https://node.new](https://node.new)。
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text 是一款流行、多功能且高度可定制的文本编辑器，用于编码和文本编辑任务。
  * [Visual Studio Code](https://code.visualstudio.com/) - 重新定义并优化的代码编辑器，适合构建和调试现代 Web 和云应用。由微软开发。
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — 完整功能的 IDE，拥有数千个扩展，支持跨平台应用开发（微软扩展可供 iOS 和 Android 下载），支持桌面、Web 和云开发，多语言支持（C#、C++、JavaScript、Python、PHP 等）。
  * [VSCodium](https://vscodium.com/) - 社区驱动、无遥测/跟踪、自由许可的微软 VSCode 编辑器二进制发布版。
  * [wakatime.com](https://wakatime.com/) — 通过文本编辑器插件量化编程活动，自带有限免费套餐。
  * [Wave Terminal](https://waveterm.dev/) - Wave 是一个开源、跨平台的终端，实现无缝工作流。可内联渲染任何内容，保存会话和历史。基于开放 Web 标准。支持 MacOS 和 Linux。
  * [WebComponents.dev](https://webcomponents.dev/) — 浏览器内 IDE，用于独立编码 Web 组件，提供 58 个模板，支持 stories 和测试。
  * [PHPSandbox](https://phpsandbox.io/) — PHP 在线开发环境。
  * [WebDB](https://webdb.app) - 免费高效的数据库 IDE。具备服务器发现、ERD、数据生成器、AI、NoSQL 结构管理、数据库版本管理等众多功能。
  * [Zed](https://zed.dev/) - Zed 是来自 Atom 和 Tree-sitter 创始团队的高性能多人协作代码编辑器。
  * [OneCompiler](https://onecompiler.com/) - 免费在线编译器，支持 70+ 种语言，包括 Java、Python、C++、JavaScript。


**[⬆️ 返回顶部](#table-of-contents)**

## 分析、事件和统计

  * [Dwh.dev](https://dwh.dev) - 数据云可观测性解决方案（Snowflake）。个人使用免费。
  * [Hightouch](https://hightouch.com/) - Hightouch 是一个反向 ETL 平台，帮助你将客户数据从数据仓库同步到 CRM、营销和支持工具。免费套餐可同步到一个目标。
  * [Avo](https://avo.app/) — 简化的数据分析发布工作流。单一真源追踪计划，类型安全的分析追踪库，应用内调试器和数据可观测性，帮助你在发布前捕获所有数据问题。免费支持 2 位工作区成员和 1 小时数据可观测性回溯。
  * [Branch](https://www.branch.io) — 移动分析平台。免费套餐支持最多 1 万移动应用用户，提供深度链接及其他服务。
  * [Census](https://www.getcensus.com/) — 反向 ETL 和运营分析平台。可将 10 个字段从数据仓库同步至 60+ 种 SaaS，如 Salesforce、Zendesk 或 Amplitude。
  * [Clicky](https://clicky.com) — 网站分析平台。免费方案支持 1 个网站，3000 次浏览数据分析。
  * [Databox](https://databox.com) — 通过整合其他分析和 BI 平台提供商业洞察与分析。免费方案支持 3 个用户、仪表盘和数据源，1100 万条历史数据记录。
  * [Hitsteps.com](https://hitsteps.com/) — 每月 2000 次页面浏览，支持 1 个网站
  * [amplitude.com](https://amplitude.com/) — 每月 100 万事件，最多 2 个应用
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter 是一个开源 Web 分析平台，既可托管（非商业用途免费）也可自托管。旨在为用户提供易用且注重隐私的 Web 分析，是 Google Analytics 或 Matomo 的替代品。免费套餐限非商业用途，支持无限站点，数据保留六个月，每月 10 万页面浏览。
  * [Google Analytics](https://analytics.google.com/) — Google Analytics 谷歌分析
  * [MetricsWave](https://metricswave.com) — 面向开发者的隐私友好型 Google Analytics 替代品。免费方案每月支持 2 万次页面浏览，无需信用卡。
  * [Expensify](https://www.expensify.com/) — 报销管理，免费个人报销审批流程
  * [getinsights.io](https://getinsights.io) - 注重隐私、无 Cookie 分析，每月免费最多 3000 事件。
  * [heap.io](https://heap.io) — 自动捕捉 iOS 或 Web 应用的每个用户操作。免费支持每月 1 万会话。
  * [Hotjar](https://hotjar.com) — 网站分析及报告。免费方案每日 2000 页面浏览，100 个快照/天（最大容量 300），3 个快照热力图可存储 365 天。团队成员无限。还支持应用内和独立问卷、反馈小部件与截图。免费套餐可建 3 个问卷和 3 个反馈小部件、每月收集 20 条回复。
  * [Keen](https://keen.io/) — 自定义分析服务，支持数据采集、分析与可视化。每月 1000 事件免费。
  * [Yandex.Datalens](https://datalens.yandex.com/) — Yandex Cloud 数据可视化与分析服务。免费，无用户和请求数限制。
  * [Yandex.Metrica](https://metrica.yandex.com/) — 无限免费分析
  * [Mixpanel](https://mixpanel.com/) — 每月 10 万活跃用户，数据历史和席位无限，美国或欧盟数据驻留
  * [Moesif](https://www.moesif.com) — REST 和 GraphQL 的 API 分析。（每月 50 万次 API 调用免费）
  * [optimizely.com](https://www.optimizely.com) — A/B 测试解决方案，免费入门版支持一个网站、一个 iOS 和一个 Android 应用
  * [Microsoft PowerBI](https://powerbi.com) — 微软商业智能与分析平台。免费方案有限制，支持 100 万用户许可。
  * [Row Zero](https://rowzero.io) - 超快的连接型电子表格。可直接连接数据数据库、S3 和 API。可导入、分析、绘图和即时分享数百万行数据。永久免费 3 个工作簿。
  * [sematext.com](https://sematext.com/cloud/) — 每月最多 5 万次操作免费，1 天数据保留，仪表盘和用户无限等。
  * [Similar Web](https://similarweb.com) — 网站和移动应用分析。免费方案每项指标可查看 5 个结果，1 个月移动应用数据和 3 个月网站数据。
  * [StatCounter](https://statcounter.com/) — 网站访问者分析。免费方案分析最近 500 位访客数据。
  * [Statsig](https://statsig.com) - 一站式平台，涵盖分析、功能开关、A/B 测试。每月 100 万事件免费。
  * [Tableau Developer Program](https://www.tableau.com/developer) — 创新、创建，让 Tableau 完美契合你的组织。免费开发者计划提供个人开发沙盒版 Tableau Online，版本为最新预发布版，供数据开发者测试所有功能。
  * [usabilityhub.com](https://usabilityhub.com/) — 在真实用户身上测试设计和原型并跟踪访客。免费支持 1 个用户，无限测试
  * [woopra.com](https://www.woopra.com/) — 免费用户分析平台，每月 50 万次操作，数据保留 90 天，30 多种一键集成。
  * [counter.dev](https://counter.dev) — 简单且注重隐私的网页分析。免费或捐赠自定金额。
  * [PostHog](https://posthog.com) - 完整产品分析套件，每月最多 100 万事件免费。同时提供不限量应用内问卷（每月 250 条回复）。
  * [Uptrace](https://uptrace.dev) - 分布式追踪工具，帮助开发者定位故障和性能瓶颈。提供免费方案、开源项目免费个人订阅及开源版本。
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity 是一款免费且易用的工具，捕捉真实用户如何使用你的网站。
  * [Beampipe.io](https://beampipe.io) - 简单、注重隐私的 Web 分析工具。免费支持最多 5 个域名和每月 1 万次页面浏览。
  * [Aptabase](https://aptabase.com) — 开源、注重隐私且简单的移动和桌面应用分析。支持 Swift、Kotlin、React Native、Flutter、Electron 等多种 SDK。每月 2 万事件免费。
  * [Trackingplan](https://www.trackingplan.com/) - 自动检测数字分析、营销数据和像素问题，保持追踪计划最新，并促进协作。可部署于生产环境使用真实流量，或无须写代码为回归测试添加分析覆盖。
  * [LogSpot](https://logspot.io) - 完整统一的 Web 和产品分析平台，包含可嵌入分析小部件和自动机器人（slack、telegram 和 webhook）。免费套餐每月包含 1 万事件。
  * [Umami](https://umami.is/) - 简单、快速、注重隐私的开源 Google Analytics 替代品。
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - 免费轻量级注重隐私的 Google Analytics 替代品。页面浏览、访客、页面热力图和目标追踪均无限。免费支持最多 3 个域名，每个域名 600 次会话回放。
  * [AppFit](https://appfit.io) - AppFit 是一款全面的分析与产品管理工具，便于跨平台无缝管理分析和产品更新。免费方案每月含 1 万事件、产品日志和每周洞察。
  * [Seline](https://seline.so) - Seline 是一款简单且私密的网站和产品分析工具。无 Cookie，轻量级，独立。免费方案每月 3000 事件，并可访问所有功能，如仪表盘、用户路径、漏斗等。
  * [Peasy](https://peasy.so) - Peasy 是一款轻量级、注重隐私的网站和产品分析工具。免费方案每月 3000 事件。
  * [Rybbit](https://rybbit.io) - 开源且无 Cookie 的 Google Analytics 替代品，界面直观度提升 10 倍。免费方案每月 3000 事件。

**[⬆️ 返回顶部](#table-of-contents)**

## 访客会话录制

  * [Reactflow.com](https://www.reactflow.com/) — 每站点每日 1000 页面浏览，3 个热力图，3 个小部件，免费 Bug 跟踪
  * [OpenReplay.com](https://www.openreplay.com) - 开源会话重放，带开发工具用于 Bug 复现、实时支持的现场会话及产品分析套件。每月 1000 会话，所有功能可用，数据保留 7 天。
  * [LogRocket.com](https://www.logrocket.com) - 每月 1000 会话，数据保留 30 天，错误跟踪，实时模式
  * [FullStory.com](https://www.fullstory.com) — 每月 1000 会话，数据保留 1 个月，3 个用户席位。详细信息见 [这里](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition)。
  * [hotjar.com](https://www.hotjar.com/) — 每站点每月 1050 页面浏览，热力图不限，数据保留 3 个月
  * [inspectlet.com](https://www.inspectlet.com/) — 每月 2500 会话，免费支持 1 个网站
  * [Microsoft Clarity](https://clarity.microsoft.com/) - 会话录制完全免费，“无流量限制”，无项目限制，无采样
  * [mouseflow.com](https://mouseflow.com/) — 每月 500 会话，免费支持 1 个网站
  * [mousestats.com](https://www.mousestats.com/) — 每月 100 会话，免费支持 1 个网站
  * [smartlook.com](https://www.smartlook.com/) — 免费套餐适用于 Web 和移动应用（每月 1500 会话），3 个热力图，1 个漏斗，1 个月数据历史
  * [howuku.com](https://howuku.com) — 跟踪用户交互、参与度和事件。每月最多 5000 访问免费
  * [UXtweak.com](https://www.uxtweak.com/) — 录制并观看访客如何使用你的网站或应用。小型项目免费不限时

**[⬆️ 返回顶部](#table-of-contents)**

## 国际手机号码验证 API 和 SDK

  * [numverify](https://numverify.com/) — 全球手机号验证与查询 JSON API。每月 100 次 API 请求
  * [veriphone](https://veriphone.io/) — 全球手机号验证，免费、快速、可靠的 JSON API。每月 1000 次请求

**[⬆️ 返回顶部](#table-of-contents)**

## 支付与账单集成

  * [Qonversion](http://qonversion.io/) - 一体化跨平台订阅管理平台，提供分析、A/B 测试、Apple Search Ads、远程配置和增长工具，优化应用内购买与变现。兼容 iOS、Android、React Native、Flutter、Unity、Cordova、Stripe 和 Web。每月跟踪营收 $10k 以内免费。
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – 根据访问者位置自动调整价格，助力业务全球扩展和新市场开拓（购买力平价）。免费套餐包含每月 7,500 次 API 请求。
  * [Glassfy](https://glassfy.io/) – 应用内订阅基础设施，支持 iOS、Android、Stripe 和 Paddle 的实时订阅事件及即用型变现工具。每月营收 $10k 以内免费。
  * [Adapty.io](https://adapty.io/) – 一站式解决方案，开源 SDK，支持 iOS、Android、React Native、Flutter、Unity 或 Web 应用的移动应用内订阅集成。每月营收 $10k 以内免费。
  * [CoinMarketCap](https://coinmarketcap.com/api/) — 提供加密货币市场数据，包括最新加密货币与法币汇率。免费层每月 10,000 次调用额度。
  * [CurrencyFreaks](https://currencyfreaks.com/) — 提供当前及历史货币汇率。免费开发者计划每月 1000 次请求。
  * [CoinGecko](https://www.coingecko.com/en/api) — 提供加密货币市场数据，包括最新汇率及历史数据。演示 API 稳定速率限制为每分钟 30 次调用，月限 10,000 次调用。
  * [CurrencyApi](https://currencyapi.net/) — 实时货币与加密货币汇率，支持 JSON 和 XML。免费层每月 1,250 次 API 请求。
  * [currencylayer](https://currencylayer.com/) — 可靠的汇率及货币兑换 API，每月 100 次 API 请求免费。
  * [exchangerate-api.com](https://www.exchangerate-api.com) - 易用的货币转换 JSON API。免费层每日更新一次，每月限 1,500 次请求。
  * [FraudLabsPRO](https://www.fraudlabspro.com) — 协助商家防止支付欺诈和拒付。免费微型计划每月 500 次查询。
  * [FxRatesAPI](https://fxratesapi.com) — 提供实时和历史汇率。免费层需署名。
  * [Moesif API Monetization](https://www.moesif.com/) - 通过用量计费为 API 创收。可连接 Stripe、Chargebee 等。免费层每月 30,000 个事件。
  * [Nami ML](https://www.namiml.com/) - iOS 和 Android 应用内购买与订阅完整平台，包含免代码付费墙、CRM 和分析。所有基础功能免费，支持 IAP 业务。
  * [RevenueCat](https://www.revenuecat.com/) — 托管的应用内购买和订阅后端（iOS 和 Android）。每月跟踪营收 $2.5k 以内免费。
  * [vatlayer](https://vatlayer.com/) — 即时 VAT 号码验证及欧盟增值税率 API，每月 100 次 API 请求免费
  * [Currencyapi](https://currencyapi.com) — 免费货币转换及汇率数据 API。每月 300 次请求，私人使用每分钟 10 次请求。

**[⬆️ 返回顶部](#table-of-contents)**

## Docker 相关

  * [canister.io](https://canister.io/) — 开发者可免费使用 20 个私有仓库，团队免费 30 个私有仓库存储 Docker 镜像
  * [Container Registry Service](https://container-registry.com/) - 基于 Harbor 的容器管理解决方案。免费层为私有仓库提供 1GB 存储空间。
  * [Docker Hub](https://hub.docker.com) — 免费 1 个私有仓库和无限公开仓库存储 Docker 镜像
  * [Play with Docker](https://labs.play-with-docker.com/) — 简单、互动、趣味的 Docker 学习游乐场。
  * [quay.io](https://quay.io/) — 构建与存储容器镜像，公共仓库免费无限制
  * [ttl.sh](https://ttl.sh/) - 匿名和临时性的 Docker 镜像注册表

**[⬆️ 返回顶部](#table-of-contents)**

## Vagrant 相关

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud。Vagrant box 托管。
  * [Vagrantbox.es](https://www.vagrantbox.es/) — 另一个公共 box 索引

**[⬆️ 返回顶部](#table-of-contents)**

## 开发者博客平台

  * [BearBlog](https://bearblog.dev/) - 极简、支持 Markdown 的博客及网站构建器。
  * [Dev.to](https://dev.to/) - 程序员交流想法、互相成长的社区。
  * [Hashnode](https://hashnode.com/) — 开发者专属的无忧博客软件。
  * [Medium](https://medium.com/) — 更深思熟虑地关注你关心的内容。
  * [AyeDot](https://ayedot.com/) — 以现代多媒体短格式迷你博客的形式，免费分享你的想法、知识与故事。

**[⬆️ 返回顶部](#table-of-contents)**

## 评论平台
  * [GraphComment](https://graphcomment.com/) - GraphComment 是一款评论平台，帮助你从网站受众中建立活跃社区。
  * [Utterances](https://utteranc.es/) - 基于 GitHub Issues 的轻量级评论小部件。可用于博客评论、Wiki 页面等！
  * [Disqus](https://disqus.com/) - Disqus 是全球数十万网站使用的社区评论平台。
  * [Remarkbox](https://www.remarkbox.com/) - 开源托管评论平台，按能力付费，"一名版主可管理多个域名，拥有完整行为与外观控制权"
  * [IntenseDebate](https://intensedebate.com/) - 为 WordPress、Tumblr、Blogger 及多种网站平台提供丰富功能的评论系统。

**[⬆️ 返回顶部](#table-of-contents)**

## 截图 API

  * [ApiFlash](https://apiflash.com) — 基于 AWS Lambda 和 Chrome 的截图 API。支持全页、捕捉时机和视口尺寸设置。
  * [microlink.io](https://microlink.io/) – 将任意网站转化为数据，支持元标签标准化、美观链接预览、爬取能力或截图服务。每天免费 250 次请求。
  * [ScreenshotAPI.net](https://screenshotapi.net/) - 通过简单的 API 调用生成任意网站截图。基于 Google Cloud 托管，可扩展。每月免费 100 张截图。
  * [screenshotlayer.com](https://screenshotlayer.com/) — 捕获高度可定制的网站截图。每月免费 100 张截图
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — 每月免费 100 张截图，支持 png、gif、jpg 格式，包含全页截图，不仅限首页
  * [PhantomJsCloud](https://PhantomJsCloud.com) — 浏览器自动化与页面渲染。免费层每日最多 500 页，自 2017 年起提供免费层。
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker 提供网站截图及域名智能 API 服务。每月免费 100 次请求。
  * [Screenshots](https://screenshotson.click) — 提供截图的 API，支持高度自定义捕获。每月免费 100 张截图。

**[⬆️ 返回顶部](#table-of-contents)**

## Flutter 相关及无 Mac 构建 IOS 应用

  * [FlutLab](https://flutlab.io/) - FlutLab 是现代 Flutter 在线 IDE，是创建、调试和构建跨平台项目的最佳场所。可用 Flutter 构建 iOS（无需 Mac）与 Android 应用。
  * [CodeMagic](https://codemagic.io/) - Codemagic 是完全托管的移动应用 CI/CD 平台。支持使用图形界面构建、测试和部署。免费层每月提供 500 分钟和一台 2.3 GHz/8GB RAM 的 Mac Mini 实例。
  * [FlutterFlow](https://flutterflow.io/) -  FlutterFlow 是基于浏览器的拖拽式 Flutter 移动应用构建工具。

**[⬆️ 返回顶部](#table-of-contents)**

## 基于 Javascript 的浏览器硬件模拟

  * [JsLinux](https://bellard.org/jslinux) — 非常快速的 x86 虚拟机，可运行 Linux 和 Windows 2k。
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) —  一款支持网络的 OpenRISC 虚拟机，可运行 Linux。
  * [v86](https://copy.sh/v86) — x86 虚拟机，可直接在浏览器中运行 Linux 及其他操作系统。

**[⬆️ 返回顶部](#table-of-contents)**

## 隐私管理
  * [Bearer](https://www.bearer.sh/) - 通过审核与持续工作流帮助实现隐私设计，以符合 GDPR 及其他法规。免费层仅限小型团队及 SaaS 版本。
  * [Osano](https://www.osano.com/) - 同意管理与合规平台，涵盖 GDPR 代表至 Cookie 横幅。免费层提供基础功能。
  * [Iubenda](https://www.iubenda.com/) - 隐私与 Cookie 政策及同意管理。免费层提供有限的隐私与 Cookie 政策及 Cookie 横幅。
  * [Cookiefirst](https://cookiefirst.com/) - Cookie 横幅、审计及多语言同意管理解决方案。免费层支持一次性扫描及单一横幅。
  * [Ketch](https://www.ketch.com/) - 同意管理和隐私框架工具。免费套餐提供大多数功能，但访问者数量有限。
  * [Concord](https://www.concord.tech/) - 全面数据隐私平台，包括同意管理、隐私请求处理（DSARs）和数据映射。免费套餐包含核心同意管理功能，且对经验证的开源项目还提供更高级的免费计划。

**[⬆️ 返回顶部](#table-of-contents)**

## 杂项

  * [BackgroundStyler.com](https://backgroundstyler.com) - 创建美观的代码、文本或图片截图，方便分享到社交媒体。
  * [BinShare.net](https://binshare.net) - 创建并分享代码或二进制文件。可生成美观图片（如用于Twitter/Facebook），或生成链接（如用于聊天或论坛）。
  * [Blynk](https://blynk.io) — 提供API的SaaS平台，用于控制、构建和评估物联网设备。开发者免费计划可支持5台设备，免费云和数据存储。也有移动应用。
  * [Bricks Note Calculator](https://free.getbricks.app/) - 一款内置强大多行计算器的笔记应用（PWA）。
  * [Carbon.now.sh](https://carbon.now.sh) - 创建并分享代码片段的美观截图图像。常用于在Twitter或博客美观展示代码片段。
  * [Code Time](https://www.software.com/code-time) - 用于VS Code、Atom、IntelliJ、Sublime Text等编辑器的时间追踪和编码指标扩展。
  * [Codepng](https://www.codepng.app) - 从源码生成优质快照，方便分享到社交媒体。
  * [CodeToImage](https://codetoimage.com/) - 创建代码或文本截图，方便分享到社交媒体。
  * [Cronhooks](https://cronhooks.io/) - 定时或周期性调度webhook。免费计划允许5个临时调度。
  * [cron-job.org](https://cron-job.org) - 在线定时任务服务。无限数量任务免费。
  * [datelist.io](https://datelist.io) - 在线预订/预约系统。每月最多5次预约免费，包含1个日历。
  * [Domain Forward](https://domain-forward.com/) - 简单易用的URL或域名转发工具。免费支持最多5个域名和每月20万次请求。
  * [Elementor](https://elementor.com) — WordPress网站构建器。免费计划提供40+基础小部件。
  * [Exif Editor](https://exifeditor.io/) — 浏览、编辑、清除、分析图片/照片元数据，包括GPS定位和元数据信息，均可在浏览器中即时操作。
  * [Format Express](https://www.format-express.dev) - 在线快速格式化JSON/XML/SQL。
  * [FOSSA](https://fossa.com/) - 可扩展的第三方代码、许可证合规及漏洞管理平台。
  * [Hook Relay](https://www.hookrelay.dev/) - 为应用添加webhook支持，无需自行处理队列、重试和日志。免费计划每天100次投递，保留14天，支持3个hook端点。
  * [Hosting Checker](https://hostingchecker.co) - 查询任意域名、网站或IP的托管信息，如ASN、ISP、地理位置等，并包含多项托管与DNS相关工具。
  * [http2.pro](https://http2.pro) — HTTP/2协议兼容性测试及客户端HTTP/2支持检测API。
  * [kandi](https://kandi.openweaver.com/) — 快速启动应用开发：通过代码片段和开源库复用，快速构建自定义功能、用例和完整应用。
  * [Base64 decoder/encoder](https://devpal.co/base64-decode/) — 免费在线Base64编码/解码工具。
  * [newreleases.io](https://newreleases.io/) - 针对GitHub、GitLab、Bitbucket、Python PyPI、Java Maven、Node.js NPM、Node.js Yarn、Ruby Gems、PHP Packagist、.NET NuGet、Rust Cargo和Docker Hub的新版本，通过邮件、Slack、Telegram、Discord和自定义webhook接收通知。
  * [OnlineExifViewer](https://onlineexifviewer.com/) — 在线即时查看照片EXIF数据，包括GPS定位和元数据。
  * [PDFMonkey](https://www.pdfmonkey.io/) — 在仪表盘管理PDF模板，支持API调用动态数据生成PDF。每月免费生成300份文档。
  * [Pika Code Screenshots](https://pika.style/templates/code-image) — 从代码片段和VSCode生成美观、可定制的截图（通过扩展实现）。
  * [QuickType.io](https://quicktype.io/) - 从JSON、schema和GraphQL快速自动生成模型/类/类型/接口及序列化代码，支持多种编程语言。可将JSON转换为优美且类型安全的代码。
  * [RandomKeygen](https://randomkeygen.com/) - 免费移动端友好的随机密钥和密码生成工具，可用于保护任何应用、服务或设备。
  * [ray.so](https://ray.so/) - 创建美观的代码片段图片。
  * [readme.com](https://readme.com/) — 轻松制作美观文档，对开源项目免费。
  * [redirection.io](https://redirection.io/) — 用于企业、市场营销和SEO的HTTP重定向管理SaaS工具。
  * [redirect.ing](https://redirect.ing/) - 快速安全的域名转发，无需管理服务器或SSL证书。免费计划支持10个主机名和每月10万次请求。
  * [redirect.pizza](https://redirect.pizza/) - 轻松管理带HTTPS支持的重定向。免费计划包含10个源和每月10万次访问。
  * [ReqBin](https://reqbin.com/) — 在线发送HTTP请求。支持GET、POST、PUT、DELETE和HEAD等常用方法，支持Header和Token认证。含基本登录系统可保存请求记录。
  * [Smartcar API](https://smartcar.com) - 车辆API，可查询定位、油箱/电池电量、里程表、开锁/锁门等。
  * [snappify](https://snappify.com) - 帮助开发者创建精美视觉内容。从美观的代码片段到完善的技术演示文档。免费计划可同时拥有3个snap，下载不限，每月5次AI驱动代码解释。
  * [Sunrise and Sunset](https://sunrisesunset.io/api/) - 获取指定经纬度的日出和日落时间。
  * [superfeedr.com](https://superfeedr.com/) — 实时PubSubHubbub合规Feed，支持导出与分析。免费版自定义程度较低。
  * [SurveyMonkey.com](https://www.surveymonkey.com) — 创建在线调查并在线分析结果。免费计划每个问卷最多10个问题、100个答卷。
  * [Tiledesk](https://tiledesk.com) - 创建聊天机器人和对话应用。支持全渠道：从网站（实时聊天小部件）到WhatsApp。免费套餐支持无限聊天机器人。
  * [Versionfeeds](https://versionfeeds.com) — 为你喜欢的软件发布生成自定义RSS订阅。可将编程语言、库或常用工具的最新版本集中在一个Feed中。（前3个Feed免费）
  * [videoinu](https://videoinu.com) — 在线创建和编辑屏幕录制及其他视频。
  * [Webacus](https://webacus.dev) — 提供丰富免费开发者工具，包括编码、解码和数据处理工具。

**[⬆️ 返回顶部](#table-of-contents)**

## 远程桌面工具

  * [Getscreen.me](https://getscreen.me) — 免费支持2台设备，连接数量和时长不限
  * [Apache Guacamole™](https://guacamole.apache.org/) — 开源无客户端远程桌面网关
  * [RemSupp](https://remsupp.com) — 按需支持和永久访问设备（每天2次免费会话）
  * [RustDesk](https://rustdesk.com/) - 人人可用的开源虚拟/远程桌面基础设施！
  * [AnyDesk](https://anydesk.com) — 免费支持3台设备，连接数量和时长不限

**[⬆️ 返回顶部](#table-of-contents)**

## 游戏开发

  * [itch.io](https://itch.io/game-assets) — 免费/付费素材，如精灵、图块集、角色包等。
  * [Gamefresco.com](https://gamefresco.com/) — 发现、收集并分享来自全球游戏美术师的免费游戏素材。
  * [GameDevMarket](https://gamedevmarket.net) — 免费/付费素材，如2D、3D、音频、GUI等。
  * [OpenGameArt](https://opengameart.org) — 开源游戏素材，如音乐、音效、精灵、GIF等。
  * [CraftPix](https://craftpix.net) — 免费/付费素材，如2D、3D、音频、GUI、背景、图标、图块集、游戏套件。
  * [Game Icons](https://game-icons.net/) - 免费可自定义的SVG/PNG图标，采用CC-BY授权。
  * [LoSpec](https://lospec.com/) — 创建像素艺术及其他受限数字艺术的在线工具，提供丰富教程和调色板列表，适合游戏开发。
  * [ArtStation](https://www.artstation.com/) - 免费/付费2D、3D素材、音频、图标、图块集、游戏套件市场。也可用来展示美术作品集。
  * [Rive](https://rive.app/community/) - 社区免费素材，也可用其免费计划自制游戏素材。
  * [Poly Pizza](https://poly.pizza/) - 免费低多边形3D素材。
  * [3Dassets.one](https://3dassets.one/) - 超过8000个免费/付费3D模型及PBR材质，支持纹理制作。
  * [Kenney](https://www.kenney.nl/assets/) - 免费（CC0 1.0通用许可）2D、3D、音频、UI游戏素材。
  * [Poliigon](https://www.poliigon.com/) - 免费及付费材质（分辨率可选）、模型、HDRI和笔刷。还提供Blender等软件的免费导出插件。
  * [Freesound](https://freesound.org/) - 免费协作音效库，提供多种CC授权音效。

**[⬆️ 返回顶部](#table-of-contents)**

## 其他免费资源

  * [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - 永久免费的前端开发工具，包括CSS压缩/还原、图片优化/缩放、大小写转换、CSS验证、JavaScript编译、HTML编辑器等。
  * [ElevateAI](https://www.elevateai.com) - 每月可免费获得200小时音频转录服务。
  * [get.localhost.direct](https://get.localhost.direct) — 更好的 `*.localhost.direct` 通配符公认CA签名SSL证书，支持localhost开发和子域。
  * [Framacloud](https://degooglisons-internet.org/en/) — 法国非营利组织[Framasoft](https://framasoft.org/en/)发布的免费/自由开源软件及SaaS列表。
  * [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — 开发者免费开源软件集中地。
  * [GitHub Education](https://education.github.com/pack) — 针对学生的免费服务集合。需注册。
  * [Markdown Tools](https://markdowntools.com) - 支持HTML、CSV、PDF、JSON、Excel与Markdown互转的工具。
  * [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — 免费获取开发Microsoft 365所需的沙箱、工具和资源。订阅为90天[Microsoft 365 E5订阅](https://www.microsoft.com/microsoft-365/enterprise/e5)（不含Windows），可续期。如持续开发（基于遥测数据与算法）将自动续期。
  * [Pyrexp](https://pythonium.net/regex) — 免费在线正则表达式测试和可视化工具，便于调试正则。
  * [RedHat for Developers](https://developers.redhat.com) — 免费获得Red Hat产品（如RHEL、OpenShift、CodeReady等）开发者专用版。仅限个人计划。另提供免费参考电子书。
  * [smsreceivefree.com](https://smsreceivefree.com/) — 免费提供临时和一次性手机号。
  * [sandbox.httpsms.com](https://sandbox.httpsms.com) — 免费发送和接收测试短信。
  * [SimpleBackups.com](https://simplebackups.com/) — 支持服务器和数据库（MySQL、PostgreSQL、MongoDB）自动备份到云存储（AWS、DigitalOcean、Backblaze）。免费计划支持1个备份。
  * [SnapShooter](https://snapshooter.com/) — 支持DigitalOcean、AWS、LightSail、Hetzner和Exoscale的备份解决方案，支持直接备份数据库、文件系统和应用到s3存储。免费计划支持单资源每日备份。
  * [Themeselection](https://themeselection.com/) — 精选高质量、现代设计、专业且易用的免费管理后台模板、HTML主题和UI套件，助你更快创建应用！
  * [Web.Dev](https://web.dev/measure/) — 免费检测网站性能的工具，帮助提升SEO搜索排名。
  * [SmallDev.tools](https://smalldev.tools/) — 一个为开发者提供的免费工具，可以对多种格式进行编码/解码，压缩 HTML/CSS/Javascript，美化，生成 JSON/CSV 及多种格式的虚假/测试数据集，并包含许多其他功能。拥有令人愉悦的界面。
  * [UseCSV by Layercode](https://layercode.com/usecsv) — 只需几分钟即可为您的 Web 应用添加 CSV 和 Excel 导入功能，为用户带来愉快且稳定的数据导入体验。无需信用卡即可免费开始，立即集成 UseCSV。可创建不限数量的导入器，单文件最大支持 100Mb。
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — 100+ 个可用于项目的按钮。
  * [WrapPixel](https://www.wrappixel.com/) — 下载由 Angular、React、VueJs、NextJS 和 NuxtJS 创建的高质量免费和高级管理后台模板！
  * [Utils.fun](https://utils.fun/en) — 所有基于浏览器算力的离线日常与开发工具，包括水印生成、屏幕录制、编码解码、加解密、代码格式化等，完全免费且不会上传任何数据到云端处理。
  * [It tools](it-tools.tech) - 为开发者和 IT 从业人员提供实用工具。
  * [Free Code Tools](https://freecodetools.org/) — 高效的代码工具，100% 免费。包括 Markdown 编辑器、代码压缩/美化器、二维码生成器、Open Graph 生成器、Twitter 卡片生成器等。
  * [regex101](https://regex101.com/) — 免费的网站，可以测试和调试正则表达式（regex）。提供正则编辑器和测试器，以及学习正则的相关文档和资源。
  * [Kody Tools](https://www.kodytools.com/dev-tools) — 100 多种开发工具，包括格式化、压缩和转换工具。
  * [AdminMart](https://adminmart.com/) — 由 Angular、Bootstrap、React、VueJs、NextJS 和 NuxtJS 创建的高质量免费和高级管理后台和网站模板！
  * [Glob tester](https://globster.xyz/) — 一个允许您设计和测试 glob 模式的网站，并提供学习 glob 模式的资源。
  * [SimpleRestore](https://simplerestore.io) - 无忧的 MySQL 备份还原。无需代码或服务器即可将 MySQL 备份还原到任何远程数据库。
  * [360Converter](https://www.360converter.com/) - 免费实用网站，支持：视频转文字、音频转文字、语音转文字、实时音频转文字、YouTube 视频转文字及添加视频字幕。也许在短视频或 YouTube 教程转文字时会有帮助:)
  * [QRCodeBest](https://qrcode.best/) - 通过 13 种模板创建自定义二维码，完全隐私，支持个人品牌。拥有跟踪像素、项目分类和 QRCode.Best 上无限团队成员。
  * [PostPulse](https://PostPulseAI.com) - 通过每月 AI 生成的帖子提升您的网络影响力，增强 SEO 和网站排名，免费计划允许您每月在我们的网站手动发布一篇帖子。
  * [PageTools](https://pagetools.co/) - 提供一套永久免费 AI 工具，帮助您一键生成网站政策、社交媒体简介、帖子和网页。
  * [MySQL Visual Explain](https://mysqlexplain.com) - 免费易懂的 MySQL EXPLAIN 输出可视化工具，优化慢查询。
  * [Killer Coda](https://killercoda.com/)  - 在浏览器中交互式学习 Linux、Kubernetes、容器、编程、DevOps、网络等内容的在线 playground。
  * [Axonomy App](https://axonomy-app.com/) - 免费工具，用于创建、管理和与客户共享发票。每月可开具 10 张免费发票。
  * [Table Format Converter](https://www.tableformatconverter.com) - 免费工具，可将表格数据转换为不同格式，如 CSV、HTML、JSON、Markdown 等。

**[⬆️ 返回顶部](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---