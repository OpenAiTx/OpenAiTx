# free-for.dev

Các nhà phát triển và tác giả mã nguồn mở hiện nay có rất nhiều dịch vụ cung cấp các gói miễn phí, nhưng việc tìm kiếm tất cả chúng để đưa ra quyết định sáng suốt lại mất nhiều thời gian.

Đây là danh sách các phần mềm (SaaS, PaaS, IaaS, v.v.) và các dịch vụ khác có gói miễn phí dành cho lập trình viên.

Phạm vi của danh sách này giới hạn ở những thứ mà các nhà phát triển hạ tầng (Quản trị hệ thống, Chuyên viên DevOps, v.v.) có thể thấy hữu ích. Chúng tôi yêu thích tất cả các dịch vụ miễn phí ngoài kia, nhưng nên giữ đúng chủ đề. Đôi khi ranh giới này khá mơ hồ, nên sẽ có phần mang tính cá nhân; xin đừng cảm thấy bị xúc phạm nếu đóng góp của bạn không được chấp nhận.

Danh sách này là kết quả từ các Pull Request, đánh giá, ý tưởng và công sức của hơn 1600 người. Bạn cũng có thể đóng góp bằng cách gửi [Pull Requests](https://github.com/ripienaar/free-for-dev) để bổ sung thêm dịch vụ hoặc loại bỏ những dịch vụ đã thay đổi hoặc ngừng cung cấp miễn phí.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**LƯU Ý**: Danh sách này chỉ dành cho các dịch vụ cung cấp dạng as-a-Service, không dành cho phần mềm tự triển khai. Để đủ điều kiện, dịch vụ phải cung cấp gói miễn phí, không chỉ là dùng thử miễn phí. Gói miễn phí nếu giới hạn thời gian thì phải tối thiểu một năm. Chúng tôi cũng xét đến yếu tố bảo mật của gói miễn phí, ví dụ SSO là ổn, nhưng tôi sẽ không chấp nhận các dịch vụ chỉ hỗ trợ TLS cho gói trả phí.

# Mục lục

  * [Giới hạn miễn phí vĩnh viễn của các nhà cung cấp Cloud lớn](#major-cloud-providers)
  * [Giải pháp quản lý Cloud](#cloud-management-solutions)
  * [Phân tích, Sự kiện và Thống kê](#analytics-events-and-statistics)
  * [API, Dữ liệu và ML](#apis-data-and-ml)
  * [Kho lưu trữ Artifact](#artifact-repos)
  * [BaaS](#baas)
  * [Nền tảng Low-code](#low-code-platform)
  * [CDN và Bảo vệ](#cdn-and-protection)
  * [CI và CD](#ci-and-cd)
  * [CMS](#cms)
  * [Sinh mã nguồn](#code-generation)
  * [Chất lượng mã nguồn](#code-quality)
  * [Tìm kiếm và duyệt mã nguồn](#code-search-and-browsing)
  * [Xử lý sự cố và ngoại lệ](#crash-and-exception-handling)
  * [Trực quan hóa dữ liệu trên bản đồ](#data-visualization-on-maps)
  * [Dịch vụ dữ liệu quản lý](#managed-data-services)
  * [Thiết kế và UI](#design-and-ui)
  * [Nguồn cảm hứng thiết kế](#design-inspiration)
  * [Trang blog cho dev](#dev-blogging-sites)
  * [DNS](#dns)
  * [Liên quan đến Docker](#docker-related)
  * [Tên miền](#domain)
  * [Giáo dục và phát triển nghề nghiệp](#education-and-career-development)
  * [Email](#email)
  * [Nền tảng quản lý Feature Toggles](#feature-toggles-management-platforms)
  * [Font](#font)
  * [Biểu mẫu](#forms)
  * [AI sinh nội dung](#generative-ai)
  * [IaaS](#iaas)
  * [IDE và biên tập mã nguồn](#ide-and-code-editing)
  * [API và SDK xác minh số điện thoại quốc tế](#international-mobile-number-verification-api-and-sdk)
  * [Theo dõi sự cố và quản lý dự án](#issue-tracking-and-project-management)
  * [Quản lý log](#log-management)
  * [Phân phối và phản hồi ứng dụng di động](#mobile-app-distribution-and-feedback)
  * [Hệ thống quản lý](#management-system)
  * [Nhắn tin và Streaming](#messaging-and-streaming)
  * [Khác](#miscellaneous)
  * [Giám sát](#monitoring)
  * [PaaS](#paas)
  * [Hệ thống dựng gói](#package-build-system)
  * [Tích hợp thanh toán và hóa đơn](#payment-and-billing-integration)
  * [Quản lý quyền riêng tư](#privacy-management)
  * [API chụp ảnh màn hình](#screenshot-apis)
  * [Liên quan Flutter và build iOS không cần Mac](#flutter-related-and-building-ios-apps-without-mac)
  * [Tìm kiếm](#search)
  * [Bảo mật và PKI](#security-and-pki)
  * [Xác thực, phân quyền và quản lý người dùng](#authentication-authorization-and-user-management)
  * [Kho lưu trữ mã nguồn](#source-code-repos)
  * [Lưu trữ và xử lý media](#storage-and-media-processing)
  * [Tunneling, WebRTC, Máy chủ Web Socket và Router khác](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [Kiểm thử](#testing)
  * [Công cụ làm việc nhóm và hợp tác](#tools-for-teams-and-collaboration)
  * [Quản lý dịch thuật](#translation-management)
  * [Liên quan đến Vagrant](#vagrant-related)
  * [Ghi lại phiên truy cập của khách](#visitor-session-recording)
  * [Lưu trữ web](#web-hosting)
  * [Nền tảng bình luận](#commenting-platforms)
  * [Mô phỏng phần cứng trên trình duyệt](#browser-based-hardware-emulation-written-in-javascript)
  * [Công cụ điều khiển máy tính từ xa](#remote-desktop-tools)
  * [Phát triển trò chơi](#game-development)
  * [Tài nguyên miễn phí khác](#other-free-resources)

## Các nhà cung cấp Cloud lớn

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 28 giờ hoạt động của instance frontend mỗi ngày, 9 giờ hoạt động của instance backend mỗi ngày
    * Cloud Firestore - 1GB lưu trữ, 50.000 lượt đọc, 20.000 lượt ghi, 20.000 lượt xóa mỗi ngày
    * Compute Engine - 1 e2-micro không tiền xử lý, 30GB HDD, 5GB lưu trữ snapshot (giới hạn ở một số khu vực), 1GB băng thông mạng đi từ Bắc Mỹ tới tất cả các vùng (trừ Trung Quốc và Úc) mỗi tháng
    * Cloud Storage - 5GB, 1GB băng thông mạng đi
    * Cloud Shell - Linux shell/web IDE trên nền web với 5GB lưu trữ lâu dài. Giới hạn 60 giờ mỗi tuần
    * Cloud Pub/Sub - 10GB tin nhắn mỗi tháng
    * Cloud Functions - 2 triệu lần gọi mỗi tháng (bao gồm cả background và HTTP)
    * Cloud Run - 2 triệu request mỗi tháng, 360.000 GB-giây RAM, 180.000 vCPU-giây xử lý, 1GB băng thông mạng đi từ Bắc Mỹ mỗi tháng
    * Google Kubernetes Engine - Không thu phí quản lý cluster cho một cluster vùng. Mỗi node người dùng tính phí theo giá tiêu chuẩn của Compute Engine
    * BigQuery - 1TB truy vấn mỗi tháng, 10GB lưu trữ mỗi tháng
    * Cloud Build - 120 phút build mỗi ngày
    * Cloud Source Repositories - Tối đa 5 người dùng, 50GB lưu trữ, 50GB băng thông đi
    * [Google Colab](https://colab.research.google.com/) - Môi trường phát triển Jupyter Notebooks miễn phí.
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (trước đây là Project IDX). VSCode online chạy trên Google Cloud.
    * Danh sách chi tiết đầy đủ - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 1TB băng thông đi mỗi tháng và 2 triệu lần gọi Function mỗi tháng
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 chỉ số tùy chỉnh và 10 cảnh báo
* [CodeBuild](https://aws.amazon.com/codebuild/) - 100 phút xây dựng mỗi tháng
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 người dùng hoạt động, 50GB lưu trữ và 10.000 yêu cầu mỗi tháng
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 1 pipeline hoạt động mỗi tháng
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GB cơ sở dữ liệu NoSQL
* [EC2](https://aws.amazon.com/ec2/) - 750 giờ mỗi tháng cho t2.micro hoặc t3.micro (12 tháng). 100GB băng thông ra mỗi tháng
* [EBS](https://aws.amazon.com/ebs/) - 30GB mỗi tháng cho loại General Purpose (SSD) hoặc Magnetic (12 tháng)
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 750 giờ mỗi tháng (12 tháng)
* [RDS](https://aws.amazon.com/rds/) - 750 giờ mỗi tháng cho db.t2.micro, db.t3.micro hoặc db.t4g.micro, 20GB lưu trữ General Purpose (SSD), 20GB lưu trữ sao lưu (12 tháng)
* [S3](https://aws.amazon.com/s3/) - 5GB lưu trữ đối tượng chuẩn, 20.000 yêu cầu Get và 2.000 yêu cầu Put (12 tháng)
* [Glacier](https://aws.amazon.com/glacier/) - 10GB lưu trữ đối tượng dài hạn
* [Lambda](https://aws.amazon.com/lambda/) - 1 triệu yêu cầu mỗi tháng
* [SNS](https://aws.amazon.com/sns/) - 1 triệu lượt xuất bản mỗi tháng
* [SES](https://aws.amazon.com/ses/) - 3.000 tin nhắn mỗi tháng (12 tháng)
* [SQS](https://aws.amazon.com/sqs/) - 1 triệu yêu cầu hàng đợi tin nhắn
* Danh sách đầy đủ, chi tiết - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 máy ảo B1S Linux, 1 máy ảo B1S Windows (12 tháng)
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 ứng dụng web, di động hoặc API (60 phút CPU/ngày)
  * [Functions](https://azure.microsoft.com/services/functions/) - 1 triệu yêu cầu mỗi tháng
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - Kích hoạt môi trường dev-test nhanh, dễ dàng, tiết kiệm
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500.000 đối tượng
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 50.000 người dùng lưu trữ hàng tháng
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 người dùng hoạt động, kho Git riêng tư không giới hạn
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 job song song miễn phí với thời gian không giới hạn cho mã nguồn mở trên Linux, macOS và Windows
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 8.000 tin nhắn mỗi ngày
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 IP cân bằng tải công cộng miễn phí (VIP)
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 1 triệu thông báo đẩy
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15GB băng thông vào (12 tháng) & 5GB băng thông ra mỗi tháng
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GB lưu trữ và 1000 RU thông lượng dự phòng
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — Xây dựng, triển khai và lưu trữ ứng dụng tĩnh và hàm serverless với SSL miễn phí, xác thực/ủy quyền và tên miền tùy chỉnh
  * [Storage](https://azure.microsoft.com/services/storage/) - 5GB lưu trữ File hoặc Blob LRS (12 tháng)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - API AI/ML (Computer Vision, Translator, nhận diện khuôn mặt, Bot, v.v.) với gói miễn phí gồm số giao dịch giới hạn
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - Dịch vụ tìm kiếm và lập chỉ mục dựa trên AI, miễn phí cho 10.000 tài liệu
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - Dịch vụ Kubernetes được quản lý, quản lý cụm miễn phí
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 100.000 thao tác mỗi tháng
  * Danh sách đầy đủ, chi tiết - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * Compute
     - 2 VM Compute dựa trên AMD với 1/8 OCPU và 1GB RAM mỗi máy
     - 4 lõi Arm Ampere A1 và 24GB RAM có thể sử dụng như 1 VM hoặc tối đa 4 VM
     - Instance sẽ bị thu hồi khi [được cho là không hoạt động](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)
  * Block Volume - 2 volume, tổng cộng 200GB (dùng cho compute)
  * Object Storage - 10GB
  * Load balancer - 1 instance với 10 Mbps
  * Databases - 2 DB, mỗi DB 20GB
  * Monitoring - 500 triệu điểm dữ liệu nhập, 1 tỷ điểm dữ liệu truy xuất
  * Bandwidth - 10TB băng thông ra mỗi tháng, tốc độ giới hạn 50 Mbps trên VM x64, 500 Mbps * số lõi trên VM ARM
  * Public IP - 2 IPv4 cho VM, 1 IPv4 cho load balancer
  * Notifications - 1 triệu tùy chọn gửi mỗi tháng, 1.000 email gửi mỗi tháng
  * Danh sách đầy đủ, chi tiết - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Cơ sở dữ liệu Cloudant - 1GB lưu trữ dữ liệu
  * Cơ sở dữ liệu Db2 - 100MB lưu trữ dữ liệu
  * API Connect - 50.000 lần gọi API mỗi tháng
  * Availability Monitoring - 3 triệu điểm dữ liệu mỗi tháng
  * Log Analysis - 500MB log mỗi ngày
  * Danh sách đầy đủ, chi tiết - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - DNS miễn phí cho số lượng miền không giới hạn, bảo vệ DDoS, CDN cùng với SSL miễn phí, quy tắc tường lửa và quy tắc trang, WAF, giảm nhẹ bot, Free Unmetered Rate Limiting - 1 quy tắc/mỗi miền, phân tích, chuyển tiếp email
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - Tối đa 50 người dùng, ghi nhật ký hoạt động 24 giờ, ba vị trí mạng
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - Có thể mở cổng HTTP cục bộ qua tunnel đến một subdomain ngẫu nhiên trên trycloudflare.com sử dụng [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/), không cần tài khoản. Thêm tính năng (TCP tunnel, cân bằng tải, VPN) trong [Zero Trust](https://www.cloudflare.com/products/zero-trust/) gói miễn phí.
  * [Workers](https://developers.cloudflare.com/workers/) - Triển khai mã serverless miễn phí trên mạng lưới toàn cầu của Cloudflare—100.000 yêu cầu mỗi ngày.
  * [Workers KV](https://developers.cloudflare.com/kv) - 100.000 yêu cầu đọc mỗi ngày, 1.000 yêu cầu ghi mỗi ngày, 1.000 yêu cầu xóa mỗi ngày, 1.000 yêu cầu liệt kê mỗi ngày, 1GB dữ liệu lưu trữ
  * [R2](https://developers.cloudflare.com/r2/) - 10GB mỗi tháng, 1 triệu thao tác Class A mỗi tháng, 10 triệu thao tác Class B mỗi tháng
  * [D1](https://developers.cloudflare.com/d1/) - 5 triệu dòng đọc mỗi ngày, 100.000 dòng ghi mỗi ngày, 1GB lưu trữ
  * [Pages](https://developers.cloudflare.com/pages/) - Phát triển và triển khai ứng dụng web trên mạng Cloudflare nhanh và an toàn. 500 lần build mỗi tháng, 100 tên miền tùy chỉnh, tích hợp SSL, không giới hạn thành viên truy cập, không giới hạn triển khai thử, hỗ trợ full-stack qua tích hợp Cloudflare Workers.
  * [Queues](https://developers.cloudflare.com/queues/) - 1 triệu thao tác mỗi tháng
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 1TB băng thông (ra ngoài) miễn phí mỗi tháng.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Giải pháp quản lý đám mây

* [Brainboard](https://www.brainboard.co) - Giải pháp hợp tác xây dựng và quản lý hạ tầng đám mây trực quan từ đầu đến cuối.
* [Cloud 66](https://www.cloud66.com/) - Miễn phí cho dự án cá nhân (bao gồm một server triển khai, một trang tĩnh), Cloud 66 cung cấp mọi thứ bạn cần để xây dựng, triển khai và phát triển ứng dụng trên bất kỳ đám mây nào mà không phải lo về “vấn đề server”.
* [Pulumi](https://www.pulumi.com/) — Nền tảng hạ tầng như mã hiện đại cho phép bạn dùng các ngôn ngữ và công cụ lập trình quen thuộc để xây dựng, triển khai và quản lý hạ tầng đám mây.
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. Quản lý state từ xa miễn phí và cộng tác nhóm cho tối đa 500 tài nguyên.
* [scalr.com](https://scalr.com/) - Scalr là sản phẩm Tự động hóa và Hợp tác Terraform (TACO) dùng để cộng tác và tự động hóa tốt hơn cho hạ tầng và cấu hình quản lý qua Terraform. Hỗ trợ đầy đủ CLI Terraform, tích hợp OPA và mô hình cấu hình phân cấp. Không tính phí SSO. Bao gồm mọi tính năng. Miễn phí tối đa 50 lần chạy/tháng.
* [deployment.io](https://deployment.io) - Deployment.io giúp lập trình viên tự động hóa triển khai trên AWS. Với gói miễn phí, lập trình viên (một người dùng) có thể triển khai không giới hạn trang tĩnh, dịch vụ web và môi trường. Chúng tôi cung cấp 20 lần thực thi job miễn phí mỗi tháng, kèm bản xem trước và tự động triển khai trong gói miễn phí.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Kho mã nguồn

* [Bitbucket](https://bitbucket.org/) — Kho Git công khai và riêng tư không giới hạn cho tối đa 5 người dùng, có Pipelines cho CI/CD
* [chiselapp.com](https://chiselapp.com/) — Kho Fossil công khai và riêng tư không giới hạn
* [codebasehq.com](https://www.codebasehq.com/) — Một dự án miễn phí với 100MB dung lượng và hai người dùng
* [Codeberg](https://codeberg.org/) — Kho Git công khai và riêng tư không giới hạn cho các dự án mã nguồn mở và miễn phí (với số cộng tác viên không giới hạn). Vận hành bởi [Forgejo](https://forgejo.org/). Lưu trữ trang web tĩnh với [Codeberg Pages](https://codeberg.page/). Lưu trữ CI/CD với [Codeberg's CI](https://docs.codeberg.org/ci/). Lưu trữ dịch thuật với [Codeberg Translate](https://translate.codeberg.org/). Bao gồm lưu trữ Package và Container, quản lý dự án, theo dõi vấn đề
* [GitGud](https://gitgud.io) — Kho công khai và riêng tư không giới hạn. Miễn phí mãi mãi. Vận hành bởi GitLab & Sapphire. Không cung cấp CI/CD.
* [GitHub](https://github.com/) — Kho công khai và riêng tư không giới hạn (với cộng tác viên không giới hạn). Bao gồm CI/CD, môi trường phát triển, lưu trữ tĩnh, lưu trữ Package và Container, quản lý dự án và AI Copilot
* [gitlab.com](https://about.gitlab.com/) — Kho Git công khai và riêng tư không giới hạn với tối đa 5 cộng tác viên. Bao gồm CI/CD, lưu trữ tĩnh, Container Registry, quản lý dự án và theo dõi vấn đề
* [framagit.org](https://framagit.org/) — Framagit là forge phần mềm của Framasoft dựa trên phần mềm Gitlab, bao gồm CI, trang tĩnh, trang dự án và theo dõi vấn đề.
* [heptapod.net](https://foss.heptapod.net/) — Heptapod là một fork thân thiện của GitLab Community Edition hỗ trợ Mercurial
* [ionicframework.com](https://ionicframework.com/appflow) - Kho mã và công cụ phát triển ứng dụng với Ionic; bạn cũng có kho Ionic riêng
* [NotABug](https://notabug.org) — NotABug.org là nền tảng hợp tác mã nguồn miễn phí cho các dự án giấy phép tự do, dựa trên Git
* [OSDN](https://osdn.net/) - OSDN.net là dịch vụ miễn phí cho lập trình viên phần mềm mã nguồn mở, cung cấp kho SVN/Git/Mercurial/Bazaar/CVS.
  * [Pagure.io](https://pagure.io) — Pagure.io là một nền tảng cộng tác mã nguồn miễn phí và mã nguồn mở dành cho các dự án cấp phép FOSS, dựa trên Git
  * [perforce.com](https://www.perforce.com/products/helix-teamhub) — Miễn phí 1GB Cloud và kho lưu trữ Git, Mercurial hoặc SVN.
  * [pijul.com](https://pijul.com/) - Hệ thống kiểm soát phiên bản phân tán miễn phí và mã nguồn mở không giới hạn. Tính năng đặc biệt dựa trên lý thuyết vá lỗi vững chắc, giúp dễ học, sử dụng và phân phối. Giải quyết nhiều vấn đề của git/hg/svn/darcs.
  * [plasticscm.com](https://plasticscm.com/) — Miễn phí cho cá nhân, mã nguồn mở và tổ chức phi lợi nhuận
  * [projectlocker.com](https://projectlocker.com) — Một dự án riêng tư miễn phí (Git và Subversion) với 50 MB dung lượng
  * [RocketGit](https://rocketgit.com) — Lưu trữ kho dựa trên Git. Không giới hạn kho công khai và riêng tư.
  * [savannah.gnu.org](https://savannah.gnu.org/) - Hệ thống quản lý phát triển phần mềm hợp tác cho các dự án phần mềm tự do (cho Dự án GNU)
  * [savannah.nongnu.org](https://savannah.nongnu.org/) - Hệ thống quản lý phát triển phần mềm hợp tác cho các dự án phần mềm tự do (cho các dự án không thuộc GNU)

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## APIs, Dữ liệu và ML

  * [JSONGrid](https://jsongrid.com) - Công cụ miễn phí để trực quan hóa, chỉnh sửa, lọc dữ liệu JSON phức tạp thành bảng lưới đẹp mắt. Lưu và chia sẻ dữ liệu JSON qua liên kết.
  * [Zerosheets](https://zerosheets.com) - Biến bảng tính Google Sheets của bạn thành API mạnh mẽ để phát triển nhanh nguyên mẫu, website, ứng dụng và hơn thế nữa. 500 yêu cầu mỗi tháng miễn phí.
  * [IP.City](https://ip.city) — 100 yêu cầu định vị địa lý IP miễn phí mỗi ngày
  * [Abstract API](https://www.abstractapi.com) — Bộ API cho nhiều mục đích, bao gồm định vị địa lý IP, phát hiện giới tính, hoặc xác thực email.
  * [Apify](https://www.apify.com/) — Nền tảng tự động hóa và thu thập dữ liệu web để tạo API cho bất kỳ website nào và trích xuất dữ liệu. Có scraper sẵn, proxy tích hợp và giải pháp tùy chỉnh. Gói miễn phí bao gồm $5 tín dụng nền tảng mỗi tháng.
  * [APITemplate.io](https://apitemplate.io) - Tự động tạo hình ảnh và tài liệu PDF với API đơn giản hoặc công cụ tự động hóa như Zapier & Airtable. Không yêu cầu CSS/HTML. Gói miễn phí gồm 50 hình ảnh/tháng và ba mẫu.
  * [APIToolkit.io](https://apitoolkit.io) - Tất cả công cụ bạn cần để hiểu đầy đủ về API và Backend của mình. Có xác thực hợp đồng API và giám sát tự động. Gói miễn phí hỗ trợ máy chủ tối đa 10.000 yêu cầu/ngày.
  * [APIVerve](https://apiverve.com) - Truy cập ngay hơn 120+ API miễn phí, xây dựng với chất lượng, nhất quán và độ tin cậy cao. Gói miễn phí gồm tối đa 50 mã thông báo API mỗi tháng. (Có thể đã ngừng hoạt động, 2025-06-25)
  * [Arize AI](https://arize.com/) - Giám sát học máy cho việc theo dõi mô hình và xác định nguyên nhân gốc của các vấn đề như chất lượng dữ liệu và sai lệch hiệu suất. Miễn phí cho tối đa hai mô hình.
  * [Maxim AI](https://getmaxim.ai/) - Mô phỏng, đánh giá và quan sát các tác nhân AI của bạn. Maxim là nền tảng đánh giá và giám sát end-to-end, giúp nhóm triển khai tác nhân AI nhanh hơn >5 lần. Miễn phí vĩnh viễn cho lập trình viên độc lập và nhóm nhỏ (3 chỗ).
  * [Beeceptor](https://beeceptor.com) - Giả lập API REST trong vài giây, trả về phản hồi API giả và nhiều hơn nữa. Miễn phí 50 yêu cầu/ngày, bảng điều khiển công khai, endpoint mở (bất cứ ai có liên kết dashboard đều có thể xem gửi và trả lời).
  * [BigDataCloud](https://www.bigdatacloud.com/) - Cung cấp API nhanh, chính xác, miễn phí (không giới hạn hoặc lên tới 10K-50K/tháng) cho web hiện đại như định vị IP, chuyển ngược mã địa lý, phân tích mạng, xác thực email và điện thoại, thông tin khách hàng và hơn thế nữa.
  * [Browse AI](https://www.browse.ai) — Trích xuất và giám sát dữ liệu trên web. 1.000 tín dụng/tháng miễn phí, tương đương 1.000 yêu cầu đồng thời.
  * [BrowserCat](https://www.browsercat.com) - API trình duyệt headless cho tự động hóa, scraping, truy cập web cho AI agent, tạo hình ảnh/pdf, và nhiều hơn nữa. Gói miễn phí với 1.000 yêu cầu/tháng.
  * [Calendarific](https://calendarific.com) - API ngày nghỉ lễ công cấp doanh nghiệp cho hơn 200 quốc gia. Gói miễn phí gồm 500 lần gọi mỗi tháng.
  * [Canopy](https://www.canopyapi.co/) - API GraphQL cho dữ liệu sản phẩm, tìm kiếm và danh mục của Amazon.com. Gói miễn phí gồm 100 lần gọi mỗi tháng.
  * [Clarifai](https://www.clarifai.com) — API hình ảnh cho nhận diện và phát hiện khuôn mặt tùy chỉnh. Có thể huấn luyện mô hình AI. Gói miễn phí có 1.000 lần gọi/tháng.
  * [Cloudmersive](https://cloudmersive.com/) — Nền tảng API tiện ích với quyền truy cập đầy đủ thư viện API mở rộng gồm chuyển đổi tài liệu, quét virus,... với 600 lần gọi/tháng, chỉ khu vực Bắc Mỹ AZ, kích thước tệp tối đa 2,5MB.
  * [Colaboratory](https://colab.research.google.com) — Môi trường notebook Python trên web miễn phí với GPU Nvidia Tesla K80.
  * [CometML](https://www.comet.com/site/) - Nền tảng MLOps cho theo dõi thử nghiệm, quản lý sản xuất mô hình, registry mô hình và truy vết dữ liệu đầy đủ, bao phủ quy trình từ huấn luyện đến sản xuất. Miễn phí cho cá nhân và học thuật.
  * [Commerce Layer](https://commercelayer.io) - API thương mại mô-đun có thể xây dựng, đặt và quản lý đơn hàng từ bất kỳ frontend nào. Gói developer cho phép 100 đơn hàng/tháng và tối đa 1.000 SKU miễn phí.
  * [Composio](https://composio.dev/) - Nền tảng tích hợp cho AI Agent và LLM. Tích hợp hơn 200+ công cụ trên Internet tác nhân.
  * [Conversion Tools](https://conversiontools.io/) - Bộ chuyển đổi tệp trực tuyến cho tài liệu, hình ảnh, video, âm thanh, eBook. Có REST API. Thư viện cho Node.js, PHP, Python. Hỗ trợ tệp đến 50 GB (cho gói trả phí). Gói miễn phí giới hạn kích thước tệp (20MB) và số lần chuyển đổi (30/ngày, 300/tháng).
  * [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API và microservice cung cấp nhiều thông tin gồm quốc gia, vùng, tỉnh, thành phố, mã bưu chính và nhiều hơn nữa. Gói miễn phí gồm tối đa 100 yêu cầu/ngày.
  * [Coupler](https://www.coupler.io/) - Công cụ tích hợp dữ liệu đồng bộ giữa các ứng dụng. Có thể tạo dashboard và báo cáo trực tiếp, chuyển đổi và thao tác giá trị, thu thập và sao lưu insight. Gói miễn phí giới hạn một người dùng, một kết nối, nguồn và đích dữ liệu. Cần làm mới dữ liệu thủ công.
  * [CraftMyPDF](https://craftmypdf.com) - Tự động tạo tài liệu PDF từ mẫu reusable với trình chỉnh sửa kéo-thả và API đơn giản. Gói miễn phí gồm 100 PDF/tháng và ba mẫu.
  * [Crawlbase](https://crawlbase.com/) — Thu thập và quét website không cần proxy, hạ tầng hay trình duyệt. Chúng tôi giải captcha và tránh bị chặn. 1.000 lần gọi đầu tiên miễn phí.
  * [CurlHub](https://curlhub.io) — Dịch vụ proxy để kiểm tra và gỡ lỗi các cuộc gọi API. Gói miễn phí gồm 10.000 yêu cầu/tháng.
  * [CurrencyScoop](https://currencyscoop.com) - API dữ liệu tiền tệ thời gian thực cho ứng dụng fintech. Gói miễn phí gồm 5.000 lần gọi/tháng.
  * [Cube](https://cube.dev/) - Cube giúp kỹ sư dữ liệu và lập trình viên truy cập dữ liệu từ kho hiện đại, tổ chức định nghĩa nhất quán và cung cấp cho mọi ứng dụng. Nhanh nhất là sử dụng Cube Cloud với gói miễn phí giới hạn 1.000 truy vấn/ngày.
  * [Data Dead Drop](https://datadeaddrop.com) - Chia sẻ tệp đơn giản, miễn phí. Dữ liệu tự hủy sau khi truy cập. Tải lên và tải xuống qua trình duyệt hoặc dòng lệnh.
  * [Data Fetcher](https://datafetcher.com) - Kết nối Airtable với bất kỳ ứng dụng hoặc API nào không cần code. Giao diện kiểu Postman để chạy yêu cầu API trong Airtable. Có tích hợp sẵn với hàng chục ứng dụng. Gói miễn phí gồm 100 lần chạy/tháng.
  * [Dataimporter.io](https://www.dataimporter.io) - Công cụ kết nối, làm sạch và nhập dữ liệu vào Salesforce. Gói miễn phí cho tối đa 20.000 bản ghi/tháng.
  * [Datalore](https://datalore.jetbrains.com) - Notebook Python của Jetbrains. Bao gồm 10 GB lưu trữ và 120 giờ runtime mỗi tháng.
  * [Data Miner](https://dataminer.io/) - Tiện ích trình duyệt (Google Chrome, MS Edge) để trích xuất dữ liệu từ web sang CSV hoặc Excel. Gói miễn phí cho 500 trang/tháng.
  * [Datapane](https://datapane.com) - API xây dựng báo cáo tương tác trong Python và triển khai script Python, Jupyter Notebook thành công cụ self-service.
  * [DB-IP](https://db-ip.com/api/free) - API định vị IP miễn phí với 1.000 yêu cầu mỗi IP mỗi ngày. Cơ sở dữ liệu lite theo giấy phép CC-BY 4.0 cũng miễn phí.
  * [DB Designer](https://www.dbdesigner.net/) — Công cụ thiết kế và mô hình hóa sơ đồ cơ sở dữ liệu trên đám mây với gói miễn phí khởi đầu gồm 2 mô hình và 10 bảng/mô hình.
  * [DeepAR](https://developer.deepar.ai) — Bộ lọc khuôn mặt thực tế tăng cường cho mọi nền tảng với một SDK. Gói miễn phí hỗ trợ tối đa 10 người dùng hoạt động hàng tháng (MAU) và theo dõi tối đa 4 khuôn mặt.
  * [Deepnote](https://deepnote.com) - Notebook khoa học dữ liệu mới. Tương thích Jupyter với cộng tác thời gian thực và chạy trên đám mây. Gói miễn phí gồm dự án cá nhân không giới hạn, máy cơ bản không giới hạn với 5GB RAM, 2vCPU và nhóm tối đa 3 editor.
  * [Disease.sh](https://disease.sh/) — API miễn phí cung cấp dữ liệu chính xác để xây dựng ứng dụng liên quan Covid-19 hữu ích.
  * [Doczilla](https://www.doczilla.app/) — SaaS API tạo ảnh chụp màn hình hoặc PDF trực tiếp từ mã HTML/CSS/JS. Gói miễn phí cho phép 250 tài liệu/tháng.
  * [Doppio](https://doppio.sh/) — API quản lý tạo và lưu trữ riêng tư PDF và ảnh chụp màn hình sử dụng công nghệ render hàng đầu. Gói miễn phí cho phép 400 PDF và ảnh chụp màn hình/tháng.
  * [drawDB](https://drawdb.app/) — Trình chỉnh sửa sơ đồ cơ sở dữ liệu trực tuyến miễn phí và mã nguồn mở, không cần đăng ký.
  * [dreamfactory.com](https://dreamfactory.com/) — Backend API REST mã nguồn mở cho ứng dụng di động, web và IoT. Kết nối bất kỳ cơ sở dữ liệu SQL/NoSQL, hệ thống lưu trữ tệp hoặc dịch vụ bên ngoài nào, và nó sẽ tự động tạo nền tảng REST API toàn diện với tài liệu sống và quản lý người dùng.
  * [Duply.co](https://duply.co) — Tạo hình ảnh động từ API & URL, thiết kế mẫu một lần và tái sử dụng. Gói miễn phí cung cấp 20 credit miễn phí.
  * [DynamicDocs](https://advicement.io) - Tạo tài liệu PDF với API JSON to PDF dựa trên mẫu LaTeX. Gói miễn phí cho 50 lần gọi API/tháng và truy cập thư viện mẫu.
  * [Efemarai](https://efemarai.com) - Nền tảng kiểm thử và gỡ lỗi mô hình ML và dữ liệu. Trực quan hóa mọi đồ thị tính toán. Miễn phí sử dụng cục bộ.
  * [ERD Lab](https://www.erdlab.io) —  Công cụ vẽ sơ đồ thực thể ERD trên đám mây miễn phí cho lập trình viên. Dùng thử miễn phí gồm 2 dự án với 10 bảng/dự án.
  * [ExtendsClass](https://extendsclass.com/rest-client-online.html) - HTTP client web miễn phí gửi yêu cầu HTTP.
  * [Export SDK](https://exportsdk.com) - API tạo PDF với trình chỉnh mẫu kéo-thả, cung cấp SDK và tích hợp không code. Gói miễn phí gồm 250 trang/tháng, không giới hạn người dùng, ba mẫu.
  * [file.coffee](https://file.coffee/) - Nền tảng lưu trữ tối đa 15MB/tệp (30MB/tệp với tài khoản).
  * [Financial Data](https://financialdata.net/) - API dữ liệu tài chính và thị trường chứng khoán. Gói miễn phí cho phép 300 yêu cầu/ngày.
  * [FormatJSONOnline.com](https://formatjsononline.com) - Công cụ miễn phí dựa trên trình duyệt để định dạng, xác thực, so sánh và nén dữ liệu JSON tức thì.
  * [FraudLabs Pro](https://www.fraudlabspro.com) — Sàng lọc giao dịch đặt hàng để phát hiện gian lận thanh toán thẻ tín dụng. REST API này sẽ phát hiện mọi hành vi gian lận có thể dựa trên tham số đầu vào của đơn hàng. Gói miễn phí Micro có 500 giao dịch/tháng.
  * [GeoDataSource](https://www.geodatasource.com) — Dịch vụ tìm kiếm vị trí tra cứu tên thành phố theo tọa độ vĩ độ, kinh độ. API miễn phí tối đa 500 truy vấn/tháng.
  * [Geolocated.io](https://geolocated.io) — API định vị IP với máy chủ đa lục địa, gói miễn phí 2.000 yêu cầu/ngày.
  * [Glitterly](https://glitterly.app/) - Tạo hình ảnh động từ mẫu cơ bản thông qua API REST và tích hợp không code. Gói miễn phí gồm 50 hình ảnh/tháng, 5 mẫu.
  * [Hex](https://hex.tech/) - Nền tảng cộng tác dữ liệu cho notebook, ứng dụng dữ liệu và thư viện kiến thức. Gói community miễn phí với tối đa 5 dự án.
  * [Hook0](https://www.hook0.com/) - Hook0 là dịch vụ Webhook-as-a-service mã nguồn mở giúp sản phẩm trực tuyến dễ dàng cung cấp webhook. Gửi tối đa 100 sự kiện/ngày, lưu lịch sử 7 ngày miễn phí.
  * [Hoppscotch](https://hoppscotch.io) - Công cụ tạo yêu cầu API miễn phí, nhanh và đẹp.
  * [huggingface.co](https://huggingface.co) - Xây dựng, huấn luyện và triển khai mô hình NLP cho Pytorch, TensorFlow, JAX. Miễn phí đến 30.000 ký tự nhập/tháng.
  * [Hybiscus](https://hybiscus.dev/) - Tạo báo cáo PDF bằng API khai báo đơn giản. Gói miễn phí 14 ngày gồm 50 báo cáo 1 trang, tùy chỉnh bảng màu và font.
  * [Invantive Cloud](https://cloud.invantive.com/) — Truy cập hơn 70 nền tảng (cloud) như Exact Online, Twinfield, ActiveCampaign hoặc Visma qua Invantive SQL hoặc OData4 (Power BI/Power Query). Bao gồm đồng bộ và trao đổi dữ liệu. Miễn phí cho lập trình viên, tư vấn triển khai. Miễn phí cho nền tảng cụ thể với giới hạn dung lượng.
  * [ipaddress.sh](https://ipaddress.sh) — Dịch vụ đơn giản lấy địa chỉ IP công cộng ở nhiều [định dạng](https://about.ipaddress.sh/).
  * [ip-api](https://ip-api.com) — API định vị địa lý IP, miễn phí cho mục đích phi thương mại, không cần API key, giới hạn 45 yêu cầu/phút từ cùng IP cho gói miễn phí.
  * [ipbase.com](https://ipbase.com) - API định vị địa lý IP - Gói miễn phí vĩnh viễn với 150 yêu cầu/tháng.
  * [IP Geolocation](https://ipgeolocation.io/) — API định vị IP - Gói miễn phí vĩnh viễn cho lập trình viên với giới hạn 1.000 yêu cầu/ngày.
  * [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — API định vị IP từ Abstract - Miễn phí 1.000 yêu cầu.
  * [IPLocate](https://www.iplocate.io) — API định vị IP, miễn phí tới 1.000 yêu cầu/ngày. Bao gồm phát hiện proxy/VPN/hosting, dữ liệu ASN, chuyển đổi IP thành Công ty, và nhiều hơn nữa. IPLocate còn cung cấp cơ sở dữ liệu IP-to-Country và IP-to-ASN miễn phí tải về ở định dạng CSV hoặc GeoIP MMDB.
  * [IP2Location](https://www.ip2location.com) — Dịch vụ định vị IP dạng freemium. Cơ sở dữ liệu LITE miễn phí tải về. Nhập cơ sở dữ liệu vào máy chủ và truy vấn nội bộ để xác định thành phố, tọa độ và thông tin ISP.
  * [IP2Location.io](https://www.ip2location.io/) — API định vị IP freemium, nhanh và đáng tin cậy. Lấy dữ liệu như thành phố, tọa độ, ISP,... Gói miễn phí gồm 50.000 credit/tháng. IP2Location.io còn cho phép 500 tra cứu WHOIS và domain lưu trữ mỗi tháng miễn phí. Xem thông tin đăng ký và domain trên IP cụ thể. Nâng cấp gói trả phí để có thêm tính năng.
  * [ipapi](https://ipapi.co/) - API định vị IP của Kloudend, Inc - API định vị đáng tin cậy trên AWS, được tin cậy bởi Fortune 500. Gói miễn phí gồm 30.000 tra cứu/tháng (1.000/ngày) không cần đăng ký.
  * [ipapi.is](https://ipapi.is/) - API địa chỉ IP đáng tin cậy từ lập trình viên cho lập trình viên với khả năng phát hiện hosting tốt nhất. Gói miễn phí gồm 1.000 tra cứu không cần đăng ký.
  * [IPinfo](https://ipinfo.io/) — API dữ liệu địa chỉ IP nhanh, chính xác, miễn phí (tối đa 50.000/tháng). Cung cấp API chi tiết về vị trí, công ty, nhà mạng, dải IP, domain, liên hệ abuse,... Tất cả API trả phí đều có thể thử miễn phí.
  * [IPQuery](https://ipquery.io) — API IP không giới hạn cho lập trình viên, không giới hạn tốc độ hay giá.
  * [IPTrace](https://iptrace.io) — API đơn giản cung cấp dữ liệu định vị IP đáng tin cậy và hữu ích cho doanh nghiệp với 50.000 tra cứu miễn phí/tháng.
  * [JSON2Video](https://json2video.com) - API chỉnh sửa video để tự động hóa video marketing và mạng xã hội, lập trình hoặc không code.
  * [JSON IP](https://getjsonip.com) — Trả về địa chỉ IP công khai của máy khách gửi yêu cầu. Không cần đăng ký cho gói miễn phí. Hỗ trợ CORS, có thể lấy dữ liệu bằng JS phía client trực tiếp trên trình duyệt. Hữu ích cho dịch vụ giám sát thay đổi IP client/server. Không giới hạn yêu cầu.
  * [JSON Serve](https://jsonserve.com/) — Dịch vụ miễn phí giúp lập trình viên lưu trữ đối tượng JSON và sử dụng như REST API trong ứng dụng.
  * [JSONing](https://jsoning.com/api/) — Tạo API REST giả từ đối tượng JSON, tùy chỉnh mã trạng thái HTTP, header và body phản hồi.
  * [konghq.com](https://konghq.com/) — Marketplace API và công cụ API công cộng/riêng mạnh mẽ. Gói miễn phí có giới hạn một số tính năng như giám sát, cảnh báo và hỗ trợ.
  * [Kreya](https://kreya.app) — Ứng dụng GUI miễn phí gọi và kiểm thử API gRPC. Có thể nhập API qua server reflection.
  * [Lightly](https://www.lightly.ai/) — Cải thiện mô hình học máy với dữ liệu đúng. Sử dụng bộ dữ liệu tối đa 1.000 mẫu miễn phí.
  * [LoginLlama](https://loginllama.app) - API bảo mật đăng nhập phát hiện gian lận và đăng nhập đáng ngờ, thông báo khách hàng. Miễn phí 1.000 lần đăng nhập/tháng.
  * [MailboxValidator](https://www.mailboxvalidator.com) — Dịch vụ xác minh email bằng kết nối máy chủ mail thực để xác nhận email hợp lệ. Gói API miễn phí gồm 100 kiểm tra/tháng.
  * [Market Data API](https://www.marketdata.app) - Cung cấp dữ liệu tài chính thời gian thực và lịch sử cho cổ phiếu, quyền chọn, quỹ mở,... API miễn phí vĩnh viễn cho 100 yêu cầu/ngày.
  * [Meteosource Weather API](https://www.meteosource.com/) — API thời tiết toàn cầu cho dữ liệu thời tiết hiện tại và dự báo. Dự báo dựa trên sự kết hợp học máy từ nhiều mô hình thời tiết để đạt độ chính xác cao hơn. Gói miễn phí có 400 lần gọi mỗi ngày.
  * [microlink.io](https://microlink.io/) – Biến bất kỳ website nào thành dữ liệu như chuẩn hóa metatag, xem trước liên kết đẹp, khả năng thu thập dữ liệu, hoặc chụp ảnh màn hình dưới dạng dịch vụ. 50 yêu cầu mỗi ngày, miễn phí mỗi ngày.
  * [Mindee](https://developers.mindee.com) – Mindee là phần mềm OCR mạnh mẽ và nền tảng API-first giúp các nhà phát triển tự động hóa luồng công việc ứng dụng bằng cách chuẩn hóa lớp xử lý tài liệu thông qua nhận dạng dữ liệu cho thông tin then chốt bằng thị giác máy tính và học máy. Gói miễn phí cho phép xử lý 500 trang mỗi tháng.
  * [Mintlify](https://mintlify.com) — Tiêu chuẩn hiện đại cho tài liệu API. Thành phần UI đẹp và dễ bảo trì, tìm kiếm trong ứng dụng và playground tương tác. Miễn phí cho 1 biên tập viên.
  * [MockAPI](https://www.mockapi.io/) — MockAPI là công cụ đơn giản cho phép bạn nhanh chóng tạo API giả lập, tạo dữ liệu tùy chỉnh và thao tác thông qua giao diện RESTful. MockAPI dành cho mục đích tạo mẫu/thử nghiệm/học tập. Một dự án/2 tài nguyên mỗi dự án miễn phí.
  * [Mockfly](https://www.mockfly.dev/) — Mockfly là công cụ phát triển đáng tin cậy cho API mocking và quản lý feature flag. Nhanh chóng tạo và kiểm soát API giả lập với giao diện trực quan. Gói miễn phí cung cấp 500 yêu cầu mỗi ngày.
  * [Mocki](https://mocki.io) - Công cụ cho phép bạn tạo API giả lập GraphQL và REST đồng bộ với kho GitHub. API REST đơn giản miễn phí phát triển và sử dụng không cần đăng ký.
  * [Mocko.dev](https://mocko.dev/) — Proxy API của bạn, chọn endpoint nào để giả lập trên cloud và kiểm tra lưu lượng, miễn phí. Giúp tăng tốc phát triển và kiểm thử tích hợp.
  * [Mocky](https://designer.mocky.io/) - Ứng dụng web đơn giản để tạo phản hồi HTTP tùy chỉnh cho việc giả lập yêu cầu HTTP. Cũng có sẵn dưới dạng [mã nguồn mở](https://github.com/julien-lafont/Mocky).
  * [Mock N Roll](https://mpcknroll.me/) - Dịch vụ API Mocks miễn phí—công cụ mạnh mẽ để mô phỏng phản hồi API thực mà không bị chậm trễ backend. Lý tưởng cho dev frontend, tester QA, và nhóm DevOps. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
  * [microenv.com](https://microenv.com) — Tạo REST API giả cho developer với khả năng sinh code và app trong container docker.
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) — Công cụ miễn phí và đơn giản để kiểm tra địa chỉ IP đầu ra qua nhiều node và hiểu cách IP của bạn xuất hiện ở các khu vực và dịch vụ toàn cầu khác nhau. Hữu ích để kiểm thử các công cụ chia DNS theo quy tắc như Control D.
  * [Namekit](https://namekit.app/) - Khám phá tên miền bằng AI – tìm kiếm tên sẵn sàng, giá chuẩn ngay lập tức. Truy vấn miễn phí hàng ngày.
  * [News API](https://newsapi.org) — Tìm kiếm tin tức trên web bằng code, nhận kết quả JSON. Developer được miễn phí 100 truy vấn mỗi ngày. Bài viết có độ trễ 24 giờ.
  * [numlookupapi.com](https://numlookupapi.com) - API xác thực số điện thoại miễn phí - 100 yêu cầu miễn phí/tháng.
  * [OCR.Space](https://ocr.space/) — API OCR phân tích file ảnh và pdf, trả về kết quả văn bản ở định dạng JSON. 25.000 yêu cầu miễn phí mỗi tháng và giới hạn kích thước file 1MB.
  * [OpenAPI3 Designer](https://openapidesigner.com/) — Tạo định nghĩa Open API 3 trực quan miễn phí.
  * [parsehub.com](https://parsehub.com/) — Trích xuất dữ liệu từ các site động, biến website động thành API, miễn phí 5 dự án.
  * [Parseur](https://parseur.com) — 20 trang miễn phí/tháng: Trích xuất dữ liệu từ PDF, email. Có AI. Toàn quyền API.
  * [PDFBolt](https://pdfbolt.com) - API tạo PDF tập trung cho developer, chú trọng bảo mật. Có tài liệu kiểu Stripe và 500 chuyển đổi PDF miễn phí mỗi tháng.
  * [pdfEndpoint.com](https://pdfendpoint.com) - Chuyển đổi HTML hoặc URL sang PDF dễ dàng với API đơn giản. 100 lượt chuyển đổi miễn phí mỗi tháng.
  * [PDF-API.io](https://pdf-api.io) - API tự động hóa PDF, trình chỉnh sửa template trực quan hoặc HTML sang PDF, tích hợp dữ liệu động và kết xuất PDF qua API. Gói miễn phí gồm 1 template, 100 PDF/tháng.
  * [Pixela](https://pixe.la/) - Dịch vụ cơ sở dữ liệu daystream miễn phí. Tất cả thao tác thực hiện qua API. Có thể trực quan hóa bằng heatmap và biểu đồ đường.
  * [Postman](https://postman.com) — Đơn giản hóa quy trình và tạo API tốt hơn – nhanh hơn – với Postman, nền tảng cộng tác phát triển API. Dùng ứng dụng Postman miễn phí trọn đời. Các tính năng cloud của Postman cũng miễn phí trọn đời với giới hạn nhất định.
  * [Insomnia](https://insomnia.rest) - Ứng dụng khách API mã nguồn mở để thiết kế và kiểm thử API, hỗ trợ REST và GraphQL.
  * [PrefectCloud](https://www.prefect.io/cloud/) — Nền tảng tự động hóa luồng dữ liệu hoàn chỉnh. Gói miễn phí gồm 5 workflow triển khai và 500 phút tính toán serverless mỗi tháng.
  * [Preset Cloud](https://preset.io/) - Dịch vụ Apache Superset được host. Miễn phí mãi mãi cho nhóm tối đa 5 người dùng, có dashboard và biểu đồ không giới hạn, trình dựng biểu đồ không cần code, và trình soạn SQL cộng tác.
  * [PromptLoop](https://www.promptloop.com/) - PromptLoop giúp quét web bằng AI dễ dàng gấp 10 lần, tiết kiệm trên 85% thời gian so với quy trình hiện tại, chạy nhanh hơn thủ công 4 lần mà không ảnh hưởng chất lượng, kèm endpoint REST API cho mọi tác vụ nghiên cứu. 1.000 credit đầu tiên miễn phí mỗi tháng.
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — Danh sách API công khai miễn phí.
  * [Rapidapi](https://rapidapi.com/) - Trung tâm API lớn nhất thế giới, hàng triệu developer tìm và kết nối với hàng ngàn API, phát triển API với thử thách vui (kèm lời giải!) và ví dụ tương tác.
  * [RequestBin.com](https://requestbin.com) — Tạo endpoint miễn phí để bạn gửi HTTP request. Mọi HTTP request gửi vào endpoint đó sẽ được ghi nhận payload và header để bạn quan sát từ webhook và dịch vụ khác.
  * [reqres.in](https://reqres.in) - REST-API được host miễn phí, sẵn sàng trả lời các request AJAX.
  * [Roboflow](https://roboflow.com) - Tạo và triển khai mô hình thị giác máy tính tùy chỉnh mà không cần kinh nghiệm học máy. Gói miễn phí gồm 30 credit mỗi tháng.
  * [ROBOHASH](https://robohash.org/) - Dịch vụ tạo ảnh độc đáo và thú vị từ bất kỳ văn bản nào.
  * [Scraper's Proxy](https://scrapersproxy.com) — API proxy HTTP đơn giản để thu thập dữ liệu. Thu thập ẩn danh không lo hạn chế, chặn hoặc captcha. 100 lần scrape thành công đầu tiên mỗi tháng miễn phí, có render javascript (liên hệ support để có thêm).
  * [ScrapingAnt](https://scrapingant.com/) — API scraping dùng Chrome headless và proxy miễn phí được kiểm tra. Render Javascript, proxy xoay cao cấp, tránh CAPTCHAs. Miễn phí 10.000 credit API.
  * [Simplescraper](https://simplescraper.io) — Gửi webhook sau mỗi thao tác. Gói miễn phí gồm 100 credit scraping cloud.
  * [Select Star](https://www.selectstar.com/) - Nền tảng khám phá dữ liệu thông minh tự động phân tích và ghi chú dữ liệu của bạn. Gói light miễn phí với 2 nguồn dữ liệu, tối đa 1.000 bảng và 25 người dùng.
  * [Sheetson](https://sheetson.com) - Biến Google Sheets thành RESTful API ngay lập tức. Gói miễn phí gồm 1.000 dòng miễn phí mỗi sheet.
  * [Shipyard](https://www.shipyardapp.com) — Nền tảng điều phối dữ liệu low-code trên cloud. Xây dựng với template low-code và code của bạn (Python, Node.js, Bash, SQL). Gói developer miễn phí cho 1 người dùng gồm 10 giờ runtime mỗi tháng – đủ để tự động nhiều workflow.
  * [Siterelic](https://siterelic.com/) - API Siterelic giúp chụp ảnh trang, kiểm tra website, quét TLS, tra cứu DNS, kiểm tra TTFB và nhiều hơn nữa. Gói miễn phí gồm 100 yêu cầu API mỗi tháng.
  * [SerpApi](https://serpapi.com/) - API thu thập kết quả công cụ tìm kiếm thời gian thực. Trả về JSON cấu trúc cho Google, YouTube, Bing, Baidu, Walmart, và nhiều máy khác. Gói miễn phí gồm 100 API call thành công mỗi tháng.
  * [SmartParse](https://smartparse.io) - SmartParse là nền tảng di chuyển dữ liệu và CSV sang API, cung cấp công cụ tiết kiệm thời gian và chi phí cho developer. Gói miễn phí gồm 300 đơn vị xử lý mỗi tháng, tải lên qua trình duyệt, kiểm soát dữ liệu, circuit breaker và cảnh báo công việc.
  * [Sofodata](https://www.sofodata.com/) - Tạo API RESTful an toàn từ file CSV. Upload CSV và truy cập dữ liệu tức thì qua API, giúp phát triển ứng dụng nhanh hơn. Gói miễn phí gồm 2 API và 2.500 lượt gọi API mỗi tháng. Không cần thẻ tín dụng.
  * [Sqlable](https://sqlable.com/) - Bộ công cụ SQL online miễn phí, gồm định dạng/kiểm tra SQL, kiểm tra regex SQL, tạo dữ liệu giả và playground cơ sở dữ liệu tương tác.
  * [Stoplight](https://stoplight.io/) - SaaS cho thiết kế và ghi chú API hợp tác. Gói miễn phí cung cấp công cụ thiết kế, giả lập và tài liệu miễn phí.
  * [Supportivekoala](https://supportivekoala.com/) — Tự động tạo ảnh theo đầu vào của bạn qua template. Gói miễn phí cho phép tạo tối đa 50 ảnh mỗi tháng.
  * [Svix](https://www.svix.com/) - Webhook dạng dịch vụ. Gửi tới 50.000 tin nhắn/tháng miễn phí.
  * [Tavily AI](https://tavily.com/) - API cho tìm kiếm online, insight nhanh và nghiên cứu tổng hợp, với khả năng tổ chức kết quả nghiên cứu. 1.000 yêu cầu/tháng cho gói Free, không cần thẻ tín dụng.
  * [The IP API](https://theipapi.com/) - API định vị địa lý IP với 1.000 yêu cầu miễn phí/ngày. Cung cấp thông tin về vị trí IP bao gồm quốc gia, thành phố, vùng, v.v.
  * [TinyMCE](https://www.tiny.cloud) - API soạn thảo văn bản giàu định dạng. Tính năng cốt lõi miễn phí cho sử dụng không giới hạn.
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - Cung cấp gói miễn phí API thời tiết. Dự báo chính xác, cập nhật, phủ sóng toàn cầu, dữ liệu lịch sử và giải pháp giám sát thời tiết.
  * [Treblle](https://www.treblle.com) - Treblle giúp nhóm xây dựng, vận chuyển, và quản lý API. Tích hợp log API nâng cao, quan sát, tài liệu và debug. Miễn phí tất cả tính năng với giới hạn 250.000 yêu cầu mỗi tháng trên gói free.
  * [UniRateAPI](https://unirateapi.com) – Tỷ giá thời gian thực cho hơn 590 loại tiền và crypto. Gọi API không giới hạn ở gói miễn phí, phù hợp cho developer và ứng dụng tài chính.
  * [vatcheckapi.com](https://vatcheckapi.com) - API kiểm tra số VAT đơn giản và miễn phí. 150 lần xác thực miễn phí mỗi tháng.
  * [WeatherXu](https://weatherxu.com/) — Dữ liệu thời tiết toàn cầu gồm điều kiện hiện tại, dự báo theo giờ, ngày và cảnh báo qua API. Tích hợp mô hình AI, hệ thống ML để phân tích, kết hợp nhiều mô hình thời tiết, tăng chính xác dự báo. Gói miễn phí gồm 10.000 API call/tháng.
  * [Webhook Store](https://www.openwebhook.io) - Công cụ lưu trữ webhook bên thứ ba và debug trên localhost (kiểu ngrok). Mã nguồn mở, có thể tự host. Miễn phí tên miền cá nhân *username*.github.webhook.store, miền công cộng *anything*.webhook.store.
  * [WebScraping.AI](https://webscraping.ai) - API thu thập dữ liệu web đơn giản với parser tích hợp, Chrome render, và proxy. 2.000 lượt gọi API miễn phí/tháng.
  * [Weights & Biases](https://wandb.ai) — Nền tảng MLOps hướng developer. Xây dựng mô hình tốt hơn nhanh hơn với quản lý thực nghiệm, versioning dataset, và quản lý mô hình. Gói miễn phí chỉ cho dự án cá nhân, gồm 100GB lưu trữ.
  * [What The Diff](https://whatthediff.ai) - Trợ lý review code bằng AI. Gói miễn phí giới hạn 25.000 token/tháng (~10 PR).
  * [wolfram.com](https://wolfram.com/language/) — Thuật toán dựa trên tri thức tích hợp sẵn trên cloud.
  * [wrapapi.com](https://wrapapi.com/) — Biến bất kỳ website nào thành API có tham số hóa. 30.000 lượt gọi API mỗi tháng.
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — API thu thập dữ liệu web với trình duyệt headless, IP dân cư và giá minh bạch. 1.000 lượt gọi API miễn phí/tháng, tặng thêm credit cho sinh viên và tổ chức phi lợi nhuận.
  * [Zipcodebase](https://zipcodebase.com) - API mã bưu điện miễn phí, truy cập dữ liệu mã bưu chính toàn cầu. 5.000 yêu cầu miễn phí/tháng.
  * [Zipcodestack](https://zipcodestack.com) - API mã bưu điện và xác thực mã bưu chính miễn phí. 10.000 yêu cầu miễn phí/tháng.
  * [Zuplo](https://zuplo.com/) - Nền tảng quản lý API miễn phí để thiết kế, xây dựng, triển khai API ra Edge. Thêm xác thực API Key, giới hạn tốc độ, tài liệu developer và thương mại hóa cho bất kỳ API nào chỉ trong vài phút. Native OpenAPI, hoàn toàn có thể lập trình với API chuẩn web & Typescript. Gói miễn phí cho phép tối đa 10 dự án, môi trường Edge production không giới hạn, 1 triệu request/tháng, và 10GB egress.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Kho lưu trữ Artifact

  * [Artifactory](https://jfrog.com/start-free/) - Kho lưu trữ artifact hỗ trợ nhiều định dạng gói như Maven, Docker, Cargo, Helm, PyPI, CocoaPods, và GitLFS. Bao gồm công cụ quét gói XRay và công cụ CI/CD Pipelines (trước đây là Shippable) với gói miễn phí 2.000 phút CI/CD mỗi tháng.
  * [central.sonatype.org](https://central.sonatype.org) — Kho lưu trữ artifact mặc định cho Apache Maven, SBT và các hệ thống build khác.
  * [cloudrepo.io](https://cloudrepo.io) - Kho Maven và PyPi private và public trên cloud. Miễn phí cho dự án mã nguồn mở.
  * [cloudsmith.io](https://cloudsmith.io) — Dịch vụ kho lưu trữ tập trung, bảo mật, đơn giản cho Java/Maven, RedHat, Debian, Python, Ruby, Vagrant và nhiều hơn nữa. Có gói miễn phí + miễn phí cho mã nguồn mở.
  * [jitpack.io](https://jitpack.io/) — Kho Maven cho dự án JVM và Android trên GitHub, miễn phí cho dự án công khai.
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Dịch vụ lưu trữ repository dễ sử dụng cho gói Maven, RPM, DEB, PyPi, NPM, và RubyGem (có gói miễn phí).
  * [repsy.io](https://repsy.io) — 1GB miễn phí kho Maven riêng/tự công khai.
  * [Gemfury](https://gemfury.com) — Kho artifact private và public cho Maven, PyPi, NPM, Go Module, Nuget, APT, và RPM. Miễn phí cho dự án công khai.
  * [paperspace](https://www.paperspace.com/) — Xây dựng & mở rộng mô hình AI, phát triển, huấn luyện, triển khai ứng dụng AI, gói miễn phí: dự án công khai, 5GB lưu trữ, instance cơ bản.
  * [RepoForge](https://repoforge.io) - Kho repository private trên cloud cho gói Python, Debian, NPM và Docker registry. Gói miễn phí cho dự án mã nguồn mở/công khai.
  * [RepoFlow](https://repoflow.io) - RepoFlow đơn giản hóa quản lý package với hỗ trợ npm, PyPI, Docker, Go, Helm, v.v. Dùng thử miễn phí với 10GB lưu trữ, 10GB băng thông, 100 package và không giới hạn người dùng trên cloud hoặc tự host dùng cá nhân.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Công cụ cho Nhóm & Hợp tác
  * [3Cols](https://3cols.com/) - Trình quản lý đoạn mã code trên cloud miễn phí cho cá nhân và nhóm cùng làm việc.
  * [Bitwarden](https://bitwarden.com) — Cách dễ nhất và an toàn nhất để cá nhân, nhóm, tổ chức doanh nghiệp lưu trữ, chia sẻ và đồng bộ dữ liệu nhạy cảm.
  * [Braid](https://www.braidchat.com/) — Ứng dụng chat thiết kế cho nhóm. Miễn phí cho nhóm public, không giới hạn người dùng, lịch sử, tích hợp. Có bản mã nguồn mở tự host.
  * [cally.com](https://cally.com/) — Tìm thời gian và ngày họp lý tưởng. Dễ dùng, phù hợp nhóm nhỏ hoặc lớn.
  * [Calendly](https://calendly.com) — Công cụ kết nối và lên lịch họp. Gói miễn phí cho 1 kết nối lịch/người dùng và không giới hạn phiên họp. Có ứng dụng desktop và mobile.
  * [Discord](https://discord.com/) — Chat phòng public/private. Hỗ trợ Markdown, thoại, video, chia sẻ màn hình. Miễn phí cho số lượng người dùng không giới hạn.
  * [Fibo](https://fibo.dev) - Công cụ scrum poker realtime online miễn phí cho nhóm agile, cho phép không giới hạn thành viên ước lượng điểm story giúp lên kế hoạch nhanh hơn.
  * [Telegram](https://telegram.org/) — Telegram dành cho bất kỳ ai muốn nhắn tin và gọi nhanh, tin cậy. Người dùng doanh nghiệp và nhóm nhỏ sẽ thích nhóm lớn, username, ứng dụng desktop và khả năng chia sẻ file mạnh mẽ.
  * [DevToolLab](https://devtoollab.com) — Bộ công cụ developer online, truy cập miễn phí tất cả công cụ cơ bản, có khả năng tự lưu 1 mục mỗi công cụ, tốc độ xử lý tiêu chuẩn, và hỗ trợ cộng đồng.
  * [Dubble](https://dubble.so/) — Công cụ tạo hướng dẫn từng bước miễn phí. Chụp ảnh màn hình, ghi tài liệu quy trình và hợp tác cùng nhóm. Hỗ trợ quay màn hình không đồng bộ.
  * [Duckly](https://duckly.com/) — Trò chuyện và hợp tác realtime với nhóm. Pair programming với IDE, chia sẻ terminal, voice, video, màn hình. Miễn phí cho nhóm nhỏ.
  * [Dyte](https://dyte.io) - SDK video & audio live thân thiện với developer nhất, có plugin hợp tác tăng năng suất và gắn kết. Gói miễn phí gồm 10.000 phút video/audio trực tuyến mỗi tháng.
  * [evernote.com](https://evernote.com/) — Công cụ tổ chức thông tin. Chia sẻ ghi chú và làm việc cùng người khác.
  * [Fibery](https://fibery.io/) — Nền tảng workspace kết nối. Miễn phí cho người dùng đơn lẻ, tối đa 2GB dung lượng.
* [flock.com](https://flock.com) — Một cách nhanh hơn để nhóm của bạn giao tiếp. Miễn phí Tin nhắn không giới hạn, Kênh, Người dùng, Ứng dụng & Tích hợp
* [Gather](https://www.gather.town/) - Cách tốt hơn để họp trực tuyến. Tập trung vào không gian tùy biến hoàn toàn, Gather giúp việc dành thời gian với cộng đồng của bạn dễ dàng như ngoài đời thực. Miễn phí cho tối đa 10 người dùng đồng thời.
* [gokanban.io](https://gokanban.io) - Bảng Kanban dựa trên cú pháp, không cần đăng ký để sử dụng nhanh. Miễn phí không giới hạn.
* [flat.social](https://flat.social) - Không gian tương tác tùy biến cho họp nhóm & giao lưu xã hội. Họp không giới hạn, miễn phí cho tối đa 8 người dùng đồng thời.
* [GitDailies](https://gitdailies.com) - Báo cáo hàng ngày về hoạt động Commit và Pull Request của nhóm bạn trên GitHub. Bao gồm công cụ trực quan hóa Push, hệ thống ghi nhận đồng nghiệp, và xây dựng cảnh báo tùy chỉnh. Gói miễn phí có số lượng người dùng không giới hạn, ba repo và 3 cấu hình cảnh báo.
* [gitter.im](https://gitter.im/) — Chat dành cho GitHub. Không giới hạn phòng công khai và riêng tư, miễn phí cho nhóm tối đa 25 người
* [Hackmd.io](https://hackmd.io/) - Công cụ cộng tác & viết tài liệu theo thời gian thực định dạng markdown. Tương tự Google Docs nhưng cho file markdown. Miễn phí số lượng "ghi chú" không giới hạn, nhưng số lượng cộng tác viên (người được mời) cho ghi chú riêng & mẫu [sẽ bị giới hạn](https://hackmd.io/pricing).
* [hangouts.google.com](https://hangouts.google.com/) — Một nơi cho tất cả các cuộc trò chuyện của bạn, miễn phí, cần tài khoản Google
* [HeySpace](https://hey.space) - Công cụ quản lý công việc với chat, lịch, dòng thời gian và gọi video. Miễn phí cho tối đa 5 người dùng.
* [helplightning.com](https://www.helplightning.com/) — Hỗ trợ qua video với thực tế tăng cường. Miễn phí nhưng không có phân tích, mã hóa và hỗ trợ
* [ideascale.com](https://ideascale.com/) — Cho phép khách hàng gửi ý tưởng và bình chọn, miễn phí cho 25 thành viên trong 1 cộng đồng
* [Igloo](https://www.igloosoftware.com/) — Cổng nội bộ để chia sẻ tài liệu, blog, lịch, v.v. Miễn phí cho tối đa 10 người dùng.
* [Keybase](https://keybase.io/) — Keybase là giải pháp FOSS thay thế cho Slack; bảo vệ an toàn các cuộc trò chuyện và file của mọi người, từ gia đình đến cộng đồng đến doanh nghiệp.
* [Google Meet](https://meet.google.com/) — Sử dụng Google Meet cho nhu cầu họp video trực tuyến của doanh nghiệp bạn. Meet cung cấp các cuộc họp trực tuyến an toàn, dễ tham gia.
* [/meet for Slack](https://meetslack.com) - Bắt đầu Google Meetings trực tiếp từ Slack bằng cách sử dụng /meet trong bất kỳ kênh, nhóm hoặc DM nào. Miễn phí không giới hạn.
* [Livecycle](https://www.livecycle.io/) — Livecycle là nền tảng cộng tác toàn diện giúp quy trình làm việc trở nên liền mạch cho nhóm sản phẩm đa chức năng và dự án mã nguồn mở.
* [Lockitbot](https://www.lockitbot.com/) — Đặt và khóa tài nguyên dùng chung trong Slack như Phòng, môi trường Dev, máy chủ, v.v. Miễn phí cho tối đa 2 tài nguyên
* [MarkUp](https://www.markup.io/) — MarkUp cho phép bạn thu thập phản hồi trực tiếp trên website, PDF và hình ảnh của mình.
* [Proton Pass](https://proton.me/pass) — Trình quản lý mật khẩu tích hợp sẵn bí danh email, xác thực 2 lớp, chia sẻ và passkeys. Có sẵn trên web, tiện ích trình duyệt, ứng dụng di động và máy tính.
* [Visual Debug](https://visualdebug.com) - Công cụ phản hồi trực quan giúp giao tiếp giữa khách hàng và nhà phát triển tốt hơn
* [meet.jit.si](https://meet.jit.si/) — Hội thoại video và chia sẻ màn hình chỉ với một cú nhấp chuột, miễn phí
* [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams là trung tâm số dựa trên chat, kết hợp trò chuyện, nội dung và ứng dụng ở một nơi, trải nghiệm liền mạch. Miễn phí cho tối đa 500.000 người dùng.
* [Miro](https://miro.com/) - Bảng trắng cộng tác bảo mật, mở rộng, đa thiết bị và sẵn sàng cho doanh nghiệp. Có gói freemium.
* [nootiz](https://www.nootiz.com/) - Công cụ thu thập và quản lý phản hồi trực quan trên mọi website
* [Notion](https://www.notion.so/) - Notion là ứng dụng ghi chú và cộng tác hỗ trợ markdown, tích hợp công việc, wiki và cơ sở dữ liệu. Công ty mô tả ứng dụng là không gian làm việc tất cả trong một cho ghi chú, quản lý dự án và công việc. Ngoài các ứng dụng đa nền tảng, có thể truy cập qua hầu hết trình duyệt web.
* [Nuclino](https://www.nuclino.com) - Wiki nhẹ và cộng tác cho mọi kiến thức, tài liệu và ghi chú của nhóm bạn. Gói miễn phí với đầy đủ tính năng cần thiết, tối đa 50 mục, 5GB lưu trữ.
* [OnlineInterview.io](https://onlineinterview.io/) - Nền tảng phỏng vấn code miễn phí với video chat tích hợp, bảng vẽ và trình soạn mã trực tuyến có thể biên dịch và chạy mã trên trình duyệt. Bạn có thể tạo phòng phỏng vấn từ xa chỉ với một cú nhấp chuột.
* [Quidlo Timesheets](https://www.quidlo.com/timesheets) - Ứng dụng chấm công và theo dõi thời gian đơn giản cho nhóm. Gói miễn phí có tính năng theo dõi thời gian và tạo báo cáo cho tối đa 10 người dùng.
* [PageShare.dev](https://www.pageshare.dev) - Thêm chức năng đánh giá trực quan vào Pull Request trên GitHub mà không cần triển khai website. Miễn phí cho tối đa 10 trang mỗi tháng và tổng cộng 100MB lưu trữ.
* [Pendulums](https://pendulums.io/) - Pendulums là công cụ theo dõi thời gian miễn phí giúp bạn quản lý thời gian tốt hơn với giao diện dễ sử dụng và thống kê hữu ích.
* [Pumble](https://pumble.com) - Ứng dụng chat nhóm miễn phí. Không giới hạn người dùng và lịch sử tin nhắn, miễn phí mãi mãi.
* [Raindrop.io](https://raindrop.io) - Ứng dụng lưu dấu trang riêng tư và bảo mật cho macOS, Windows, Android, iOS và Web. Miễn phí không giới hạn dấu trang và cộng tác.
* [element.io](https://element.io/) — Công cụ giao tiếp phân tán và mã nguồn mở dựa trên Matrix. Chat nhóm, nhắn tin trực tiếp, truyền file mã hóa, chat thoại và video, tích hợp dễ dàng với các dịch vụ khác.
* [Rocket.Chat](https://rocket.chat/) - Nền tảng giao tiếp mã nguồn mở với tính năng Omnichannel, liên kết Matrix, cầu nối với ứng dụng khác, nhắn tin không giới hạn, lịch sử đầy đủ.
* [seafile.com](https://www.seafile.com/) — Lưu trữ riêng tư hoặc trên mây, chia sẻ file, đồng bộ, thảo luận. Phiên bản cloud chỉ có 1 GB
* [Sema](https://www.semasoftware.com/) - Công cụ portfolio miễn phí cho lập trình viên, tổng hợp đóng góp trên nhiều repo vào một báo cáo duy nhất.
* [Screen Sharing via Browser](https://screensharing.net) - Công cụ chia sẻ màn hình miễn phí, chia sẻ với đồng nghiệp ngay từ trình duyệt, không cần tải về hay đăng ký. Miễn phí.
* [Slab](https://slab.com/) — Dịch vụ quản lý tri thức hiện đại cho nhóm. Miễn phí cho tối đa 10 người dùng.
* [slack.com](https://slack.com/) — Miễn phí cho số lượng người dùng không giới hạn với một số hạn chế tính năng
* [Spectrum](https://spectrum.chat/) - Tạo cộng đồng công khai hoặc riêng tư miễn phí.
* [StatusPile](https://www.statuspile.com/) - Trang tổng hợp trạng thái các trang trạng thái. Bạn có thể theo dõi trạng thái của các nhà cung cấp upstream?
* [Stickies](https://stickies.app/) - Ứng dụng cộng tác trực quan dùng để động não, tổng hợp nội dung và ghi chú. Miễn phí cho tối đa 3 Walls, không giới hạn người dùng, 1 GB lưu trữ.
* [Stacks](https://betterstacks.com/) - Không gian quản lý nội dung tích hợp ghi chú, liên kết và lưu trữ file để điều hướng thông tin quá tải. Gói cá nhân miễn phí mãi mãi.
* [talky.io](https://talky.io/) — Nhóm chat video miễn phí. Ẩn danh. Peer‑to‑peer. Không cần plugin, đăng ký hay thanh toán
* [Teamhood](https://teamhood.com/) - Phần mềm quản lý dự án, công việc, và vấn đề miễn phí. Hỗ trợ Kanban với Swimlanes và triển khai Scrum đầy đủ. Có tích hợp theo dõi thời gian. Miễn phí cho năm người dùng và ba danh mục dự án.
* [Teamplify](https://teamplify.com) - cải thiện quy trình phát triển nhóm với Team Analytics và Smart Daily Standup. Bao gồm quản lý Nghỉ phép đầy đủ cho nhóm làm việc từ xa. Miễn phí cho nhóm nhỏ tối đa 5 người dùng.
* [Tefter](https://tefter.io) - Ứng dụng lưu dấu trang với tích hợp mạnh mẽ cho Slack. Miễn phí cho nhóm mã nguồn mở.
* [TeleType](https://teletype.oorja.io/) — chia sẻ terminal, thoại, mã, bảng trắng và nhiều hơn nữa. Không cần đăng nhập để cộng tác mã hóa đầu cuối cho lập trình viên.
* [TimeCamp](https://www.timecamp.com/) - Phần mềm theo dõi thời gian miễn phí cho số lượng người dùng không giới hạn. Dễ dàng tích hợp với các công cụ quản lý dự án như Jira, Trello, Asana, v.v.
* [Huly](https://huly.io/) - Nền tảng quản lý dự án tất cả trong một (thay thế Linear, Jira, Slack, Notion, Motion) - không giới hạn người dùng, 10GB lưu trữ cho mỗi workspace, 10GB lưu lượng video(audio).
* [Teamcamp](https://www.teamcamp.app) - Ứng dụng quản lý dự án tất cả trong một cho công ty phát triển phần mềm.
* [twist.com](https://twist.com) — Ứng dụng giao tiếp nhóm thân thiện với làm việc không đồng bộ, nơi các cuộc thảo luận luôn được sắp xếp và đúng chủ đề. Có gói Miễn phí và Không giới hạn. Có ưu đãi giảm giá cho nhóm đủ điều kiện.
* [tldraw.com](https://tldraw.com) — Công cụ bảng trắng và vẽ sơ đồ mã nguồn mở miễn phí với tính năng mũi tên thông minh, hút dính, ghi chú dán và xuất SVG. Chế độ nhiều người dùng cho chỉnh sửa cộng tác. Có extension chính thức miễn phí cho VS Code.
* [BookmarkOS.com](https://bookmarkos.com) - Trình quản lý dấu trang, quản lý tab và quản lý công việc tất cả trong một miễn phí, trên desktop trực tuyến tùy biến với chia sẻ thư mục.
* [typetalk.com](https://www.typetalk.com/) — Chia sẻ và thảo luận ý tưởng với nhóm thông qua chat tức thì trên web hoặc di động
* [Tugboat](https://tugboat.qa) - Xem trước mọi pull request, tự động và theo yêu cầu. Miễn phí cho tất cả, gói Nano miễn phí cho tổ chức phi lợi nhuận.
* [whereby.com](https://whereby.com/) — Hội thoại video chỉ với một cú nhấp chuột, miễn phí (trước đây là appear.in)
* [windmill.dev](https://windmill.dev/) - Nền tảng mã nguồn mở cho nhà phát triển xây dựng tự động hóa và ứng dụng nội bộ sản xuất từ script Python/Typescript tối giản. Người dùng miễn phí được tạo và tham gia tối đa ba workspace không cao cấp.
* [vadoo.tv](https://vadoo.tv/) — Lưu trữ và tiếp thị video đơn giản. Tải lên video chỉ với một cú nhấp chuột. Ghi hình, quản lý, chia sẻ & nhiều hơn nữa. Gói miễn phí cho tối đa 10 video, 1 GB lưu trữ và 10 GB băng thông/tháng
* [userforge.com](https://userforge.com/) - Hồ sơ nhân vật, user story và bản đồ ngữ cảnh trực tuyến liên kết. Hỗ trợ đồng bộ thiết kế & phát triển, miễn phí cho tối đa 3 nhân vật và hai cộng tác viên.
* [wistia.com](https://wistia.com/) — Lưu trữ video với phân tích người xem, truyền video HD và công cụ tiếp thị giúp hiểu khách truy cập, 25 video và trình phát mang thương hiệu Wistia
* [wormhol.org](https://www.wormhol.org/) — Dịch vụ chia sẻ file đơn giản. Chia sẻ không giới hạn file lên tới 5GB với bao nhiêu người tùy ý.
* [Wormhole](https://wormhole.app/) - Chia sẻ file tối đa 5GB với mã hóa đầu cuối trong 24h. Với file lớn hơn 5 GB, dùng truyền trực tiếp peer-to-peer.
* [zoom.us](https://zoom.us/) — Hội họp Video & Web bảo mật, có các tiện ích mở rộng. Gói miễn phí bị giới hạn 40 phút.
* [Zulip](https://zulip.com/) — Chat thời gian thực với mô hình chuỗi thư giống email độc đáo. Gói miễn phí bao gồm 10.000 tin nhắn lịch sử tìm kiếm và 5 GB lưu trữ file. Có phiên bản mã nguồn mở tự lưu trữ.
* [robocorp.com](https://robocorp.com) - Stack mã nguồn mở cho tự động hóa. Dùng thử tính năng Cloud và triển khai tự động hóa đơn giản miễn phí. Robot làm việc 240 phút/tháng, 10 lần chạy Assistant, 100 MB lưu trữ.
* [Fleep.io](https://fleep.io/) — Fleep là giải pháp thay thế cho Slack. Có gói miễn phí cho nhóm nhỏ với lịch sử tin nhắn đầy đủ, chat 1:1 không giới hạn, 1 nhóm trò chuyện và 1 GB lưu trữ file.
* [Chanty.com](https://chanty.com/) — Chanty là một lựa chọn thay thế khác cho Slack. Có gói miễn phí mãi mãi cho nhóm nhỏ (tối đa 10 người) với chat công khai & riêng tư không giới hạn, lịch sử tìm kiếm, gọi âm thanh 1:1 không giới hạn, tin nhắn thoại không giới hạn, 10 tích hợp và 20 GB lưu trữ mỗi nhóm.
* [ruttl.com](https://ruttl.com/) — Công cụ phản hồi tất cả trong một tốt nhất để thu thập phản hồi số và duyệt website, PDF, hình ảnh.
* [Mattermost](https://mattermost.com/) — Cộng tác bảo mật cho nhóm kỹ thuật. Gói miễn phí với kênh không giới hạn, playbook, bảng, người dùng, 10GB lưu trữ, v.v.
* [Webvizio](https://webvizio.com) — Công cụ phản hồi website, phần mềm review website và báo lỗi giúp cộng tác phát triển web trực tiếp trên website, web app, hình ảnh, PDF và file thiết kế.
* [Pullflow](https://pullflow.com) — Pullflow cung cấp nền tảng đánh giá code cộng tác tăng cường AI trên GitHub, Slack và VS Code.
* [Webex](https://www.webex.com/) — Họp video với gói miễn phí 40 phút/cuộc họp cho 100 người tham dự.
* [RingCentral](https://www.ringcentral.com/) — Họp video với gói miễn phí 50 phút/cuộc họp cho 100 người tham gia.
* [GitBook](https://www.gitbook.com/) — Nền tảng ghi chép và tài liệu hóa kiến thức kỹ thuật — từ tài liệu sản phẩm đến cơ sở tri thức nội bộ và API. Gói miễn phí cho nhà phát triển cá nhân.
* [transfernow](https://www.transfernow.net/) — giao diện đơn giản, nhanh và an toàn để chuyển và chia sẻ file. Gửi ảnh, video và file lớn khác mà không cần đăng ký bắt buộc.
* [paste.sh](https://paste.sh/) — Trang paste đơn giản dựa trên JavaScript và Crypto.
* [Revolt.chat](https://revolt.chat/) — Một lựa chọn mã nguồn mở thay thế cho [Discord](https://discord.com/), tôn trọng quyền riêng tư. Có hầu hết các tính năng độc quyền từ Discord miễn phí. Revolt là ứng dụng tất cả trong một bảo mật, nhanh, hoàn toàn miễn phí. Tất cả tính năng đều miễn phí. Có hỗ trợ plugin (chính thức & không chính thức) không như các ứng dụng chat phổ biến.
* [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) cung cấp giải pháp gọi nhóm audio/video. 10.000 phút miễn phí/tháng trong năm đầu tiên.
* [Pastefy](https://pastefy.app/) - Pastebin đẹp và đơn giản với mã hóa phía khách tùy chọn, Paste đa tab, API, trình soạn thảo nổi bật và nhiều hơn nữa.
* [SiteDots](https://sitedots.com/) - Chia sẻ phản hồi cho dự án website trực tiếp trên website, không cần mô phỏng, canvas hay giải pháp thay thế. Miễn phí hoàn toàn chức năng.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## CMS

* [acquia.com](https://www.acquia.com/) — Hosting cho website Drupal. Gói miễn phí cho lập trình viên. Cũng có các công cụ phát triển miễn phí (ví dụ Acquia Dev Desktop).
* [Contentful](https://www.contentful.com/) — Headless CMS. Quản lý nội dung và API phân phối trên cloud. Có một không gian Community miễn phí gồm 5 người dùng, 25K bản ghi, 48 Loại nội dung, 2 ngôn ngữ.
* [Cosmic](https://www.cosmicjs.com/) — Headless CMS và bộ công cụ API. Gói cá nhân miễn phí cho lập trình viên.
* [Crystallize](https://crystallize.com) — Headless PIM hỗ trợ thương mại điện tử. Tích hợp sẵn GraphQL API. Phiên bản miễn phí bao gồm người dùng không giới hạn, 1000 mục danh mục, 5 GB/tháng băng thông và 25k/lượt gọi API mỗi tháng.
* [DatoCMS](https://www.datocms.com/) - Có gói miễn phí cho dự án nhỏ. DatoCMS là CMS dựa trên GraphQL. Gói thấp nhất có 100k lượt gọi/tháng.
* [Directus](https://directus.io) — Headless CMS. Nền tảng hoàn toàn miễn phí và mã nguồn mở để quản lý tài sản và nội dung cơ sở dữ liệu tại chỗ hoặc trên Cloud. Không có giới hạn hay trả phí.
* [FrontAid](https://frontaid.io/) — Headless CMS lưu trữ nội dung JSON trực tiếp trong Git repository của bạn. Không giới hạn.
* [kontent.ai](https://www.kontent.ai) - Nền tảng Content-as-a-Service cung cấp mọi lợi ích của headless CMS và đồng thời hỗ trợ cho marketer. Gói Developer cung cấp hai người dùng với số lượng dự án không giới hạn, mỗi dự án có hai môi trường, 500 mục nội dung, hai ngôn ngữ với Delivery & Management API, và hỗ trợ phần tử tùy chỉnh. Có thể sử dụng các gói chi tiết hơn theo nhu cầu.
* [Prismic](https://www.prismic.io/) — Headless CMS. Giao diện quản lý nội dung với API lưu trữ và mở rộng. Gói Community cung cấp số lượt gọi API, tài liệu, loại tùy chỉnh, tài sản và ngôn ngữ không giới hạn cho một người dùng. Đủ mọi thứ cần thiết cho dự án tiếp theo. Có gói miễn phí lớn hơn cho dự án Open Content/Open Source.
* [Sanity.io](https://www.sanity.io/) - Nền tảng nội dung có cấu trúc với môi trường chỉnh sửa mã nguồn mở và kho dữ liệu thời gian thực. Không giới hạn dự án. Không giới hạn admin, ba người dùng không phải admin, hai dataset, 500K lượt request CDN API, 10GB băng thông, 5GB tài sản miễn phí mỗi dự án.
* [sensenet](https://sensenet.com) - API-first headless CMS cung cấp giải pháp cấp doanh nghiệp cho mọi quy mô. Gói Developer cung cấp ba người dùng, 500 nội dung, ba vai trò tích hợp, 25+5 loại nội dung, REST API đầy đủ, tạo xem trước tài liệu và chỉnh sửa Office Online.
* [TinaCMS](https://tina.io/) — Thay thế Forestry.io. Headless CMS mã nguồn mở dựa trên Git hỗ trợ Markdown, MDX và JSON. Gói cơ bản miễn phí với hai người dùng.
* [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby là framework nhanh và linh hoạt giúp xây dựng website với bất kỳ CMS, API hoặc cơ sở dữ liệu nào. Xây dựng và triển khai website headless tăng lưu lượng, chuyển đổi tốt hơn và tăng doanh thu!
* [Hygraph](https://hygraph.com/) - Có gói miễn phí cho dự án nhỏ. API ưu tiên GraphQL. Chuyển từ giải pháp cũ sang Headless CMS gốc GraphQL và cung cấp API nội dung đa kênh.
  * [Squidex](https://squidex.io/) - Cung cấp gói miễn phí cho các dự án nhỏ. API / GraphQL ưu tiên. Mã nguồn mở và dựa trên event sourcing (tự động phiên bản hóa mọi thay đổi).
  * [InstaWP](https://instawp.com/) - Khởi tạo trang WordPress chỉ trong vài giây. Có gói miễn phí với 5 Site Hoạt Động, 500 MB Dung Lượng, hết hạn site sau 48 giờ.
  * [Storyblok](https://www.storyblok.com) - Headless CMS dành cho nhà phát triển và marketer, tương thích với mọi framework hiện đại. Gói Community (miễn phí) cung cấp Management API, Visual Editor, mười nguồn, Custom Field Types, Đa ngôn ngữ (không giới hạn ngôn ngữ/vùng), Asset Manager (tối đa 2500 asset), Dịch vụ tối ưu hóa hình ảnh, Search Query, Webhook + 250GB Traffic/tháng.
  * [WPJack](https://wpjack.com) - Thiết lập WordPress trên bất kỳ đám mây nào dưới 5 phút! Gói miễn phí bao gồm 1 máy chủ, 2 site, chứng chỉ SSL miễn phí và cron job không giới hạn. Không giới hạn thời gian hay hết hạn—website của bạn, theo cách của bạn.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Sinh mã (Code Generation)

  * [Appinvento](https://appinvento.io/) — AppInvento là một nền tảng xây dựng ứng dụng không cần code miễn phí. Trong mã backend được sinh tự động, người dùng có quyền truy cập hoàn toàn vào mã nguồn, API và route không giới hạn, cho phép tích hợp sâu rộng. Gói miễn phí bao gồm ba dự án, năm bảng và một tiện ích Google add-on.
  * [Cody AI](https://sourcegraph.com/cody) - Cody là trợ lý AI lập trình sử dụng AI và hiểu sâu mã nguồn của bạn để giúp bạn viết và hiểu code nhanh hơn. Cody cho phép chọn LLM (kể cả inference local), hỗ trợ nhiều IDE, tất cả ngôn ngữ lập trình phổ biến, và có gói miễn phí. Gói miễn phí cho phép 20 tin nhắn chat (dùng Claude 3 Sonnet làm LLM) và 500 tự động hoàn thành (dùng Starcoder 16b) mỗi tháng.
  * [DhiWise](https://www.dhiwise.com/) — Chuyển đổi thiết kế Figma thành ứng dụng Flutter & React động với công nghệ sinh mã sáng tạo của DhiWise, tối ưu hóa quy trình và giúp bạn xây dựng trải nghiệm web & di động xuất sắc nhanh hơn bao giờ hết.
  * [Codeium](https://www.codeium.com/) — Codeium là công cụ AI hoàn thành mã miễn phí. Hỗ trợ hơn 20+ ngôn ngữ lập trình (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, v.v.) và tích hợp với tất cả IDE lớn độc lập và web.
  * [Fern](https://buildwithfern.com) - Viết định nghĩa API và dùng chúng để sinh SDK/thư viện client cho các ngôn ngữ phổ biến như TypeScript, Python, Java, Go, v.v. Hỗ trợ đầy đủ OpenAPI. Gói miễn phí sinh mã tối đa cho 20 endpoint.
  * [Metalama](https://www.postsharp.net/metalama) - Chỉ dành cho C#. Metalama sinh mã boilerplate tự động khi biên dịch để mã nguồn của bạn luôn sạch. Miễn phí cho dự án mã nguồn mở, gói miễn phí thân thiện thương mại bao gồm ba aspect.
  * [Supermaven](https://www.supermaven.com/) — Supermaven là plugin AI hoàn thành mã nhanh cho VSCode, JetBrains và Neovim. Gói miễn phí cung cấp hoàn thành nội tuyến không giới hạn.
  * [tabnine.com](https://www.tabnine.com/) — Tabnine giúp lập trình viên tạo phần mềm tốt hơn, nhanh hơn nhờ các insight từ toàn bộ mã nguồn trên thế giới. Có plugin.
  * [v0.dev](https://v0.dev/) — v0 sử dụng mô hình AI để sinh mã từ prompt văn bản đơn giản. Sinh mã React copy-paste thân thiện dựa trên shadcn/ui và Tailwind CSS cho dự án của bạn. Mỗi lần sinh tốn tối thiểu 30 credit. Bắt đầu với 1200 credit, mỗi tháng được tặng 200 credit miễn phí.


**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Chất lượng mã (Code Quality)

  * [beanstalkapp.com](https://beanstalkapp.com/) — Quy trình hoàn chỉnh để viết, review và deploy mã; tài khoản miễn phí cho 1 người dùng, 1 repo với 100 MB dung lượng lưu trữ
  * [browserling.com](https://www.browserling.com/) — Test trình duyệt chéo trực tiếp, miễn phí các phiên 3 phút với MS IE 9 trên Vista ở độ phân giải 1024 x 768
  * [codacy.com](https://www.codacy.com/) — Review mã tự động cho PHP, Python, Ruby, Java, JavaScript, Scala, CSS, CoffeeScript, miễn phí cho repo công khai và riêng tư không giới hạn
  * [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - Công cụ review Infrastructure as Code tự động cho DevOps, tích hợp với GitHub, Bitbucket, GitLab (cả bản tự host). Ngoài các ngôn ngữ tiêu chuẩn, còn phân tích Ansible, Terraform, CloudFormation, Kubernetes, v.v. (mã nguồn mở miễn phí)
  * [CodeBeat](https://codebeat.co) — Nền tảng review mã tự động cho nhiều ngôn ngữ. Miễn phí vĩnh viễn cho repo công khai, tích hợp Slack & email.
  * [codeclimate.com](https://codeclimate.com/) — Review mã tự động, miễn phí cho mã nguồn mở và repo riêng tư thuộc tổ chức (tối đa 4 cộng tác viên). Cũng miễn phí cho sinh viên và tổ chức giáo dục.
  * [codecov.io](https://codecov.io/) — Công cụ đo độ phủ mã (SaaS), miễn phí cho mã nguồn mở và 1 repo riêng tư miễn phí
  * [CodeFactor](https://www.codefactor.io) — Review mã tự động cho Git. Bản miễn phí gồm người dùng không giới hạn, repo công khai không giới hạn và 1 repo riêng tư.
  * [coderabbit.ai](https://coderabbit.ai) — Công cụ review mã dùng AI, tích hợp với GitHub/GitLab. Gói miễn phí gồm 200 file/giờ, 3 review/giờ, 50 cuộc hội thoại/giờ. Miễn phí vĩnh viễn cho dự án mã nguồn mở.
  * [codescene.io](https://codescene.io/) - CodeScene ưu tiên nợ kỹ thuật dựa trên cách các developer làm việc với mã, trực quan hóa các yếu tố tổ chức như liên kết nhóm và mức độ thành thạo hệ thống. Miễn phí cho mã nguồn mở.
  * [CodSpeed](https://codspeed.io) - Tự động theo dõi hiệu năng trong pipeline CI. Phát hiện sớm các vấn đề hiệu suất trước khi triển khai nhờ số liệu chính xác & nhất quán. Miễn phí vĩnh viễn cho mã nguồn mở.
  * [coveralls.io](https://coveralls.io/) — Hiển thị báo cáo độ phủ test, miễn phí cho mã nguồn mở
  * [dareboost](https://dareboost.com) - 5 báo cáo phân tích miễn phí mỗi tháng về hiệu năng web, truy cập, bảo mật
  * [deepcode.ai](https://www.deepcode.ai) — DeepCode tìm bug, lỗ hổng bảo mật, vấn đề hiệu năng và API dựa trên AI. Tốc độ phân tích cho phép kiểm tra code thời gian thực và trả kết quả ngay khi bạn nhấn lưu trên IDE. Hỗ trợ Java, C/C++, JavaScript, Python, TypeScript. Tích hợp với GitHub, BitBucket, GitLab. Miễn phí cho repo mã nguồn mở & riêng tư, tối đa 30 developer.
  * [deepscan.io](https://deepscan.io) — Phân tích tĩnh nâng cao tự động tìm lỗi runtime trong mã JavaScript, miễn phí cho mã nguồn mở
  * [DeepSource](https://deepsource.io/) - DeepSource liên tục phân tích thay đổi mã nguồn, tìm và sửa lỗi về bảo mật, hiệu năng, anti-pattern, rủi ro bug, tài liệu, style. Tích hợp gốc với GitHub, GitLab, Bitbucket.
  * [DiffText](https://difftext.com) - So sánh sự khác biệt giữa hai khối mã lập tức. Hoàn toàn miễn phí.
  * [eversql.com](https://www.eversql.com/) — EverSQL - Nền tảng tối ưu hóa cơ sở dữ liệu số 1. Tự động cung cấp insight quan trọng về database và truy vấn SQL.
  * [gerrithub.io](https://review.gerrithub.io/) — Review mã Gerrit cho repo GitHub miễn phí
  * [gocover.io](https://gocover.io/) — Đo độ phủ mã cho bất kỳ package [Go](https://golang.org/)
  * [goreportcard.com](https://goreportcard.com/) — Chất lượng mã cho dự án Go, miễn phí cho mã nguồn mở
  * [gtmetrix.com](https://gtmetrix.com/) — Báo cáo và khuyến nghị chi tiết tối ưu hóa website
  * [holistic.dev](https://holistic.dev/) - Trình phân tích mã tĩnh số 1 cho tối ưu hóa Postgresql. Dịch vụ tự động phát hiện vấn đề hiệu năng, bảo mật, kiến trúc database
  * [houndci.com](https://houndci.com/) — Bình luận về chất lượng mã trên các commit GitHub, miễn phí cho mã nguồn mở
  * [Moderne.io](https://app.moderne.io) — Tự động refactor mã nguồn. Moderne cung cấp di chuyển framework, phân tích mã kèm đề xuất sửa lỗi, chuyển đổi mã quy mô lớn, giúp developer tập trung xây mới thay vì bảo trì mã cũ. Miễn phí cho mã nguồn mở.
  * [reviewable.io](https://reviewable.io/) — Review mã cho repo GitHub, miễn phí cho repo công khai hoặc cá nhân.
  * [parsers.dev](https://parsers.dev/) - Dịch vụ parser cây cú pháp trừu tượng (AST) và biên dịch trung gian
  * [scan.coverity.com](https://scan.coverity.com/) — Phân tích mã tĩnh cho Java, C/C++, C#, JavaScript, miễn phí cho mã nguồn mở
  * [scrutinizer-ci.com](https://scrutinizer-ci.com/) — Nền tảng kiểm tra liên tục, miễn phí cho mã nguồn mở
  * [semanticdiff.com](https://app.semanticdiff.com/) — Diff thông minh cho pull request và commit GitHub, miễn phí cho repo công khai
  * [shields.io](https://shields.io) — Badge metadata chất lượng cho dự án mã nguồn mở
  * [sonarcloud.io](https://sonarcloud.io) — Phân tích mã tự động cho Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy và nhiều ngôn ngữ khác, miễn phí cho mã nguồn mở
  * [SourceLevel](https://sourcelevel.io/) — Review mã tự động và phân tích nhóm. Miễn phí cho mã nguồn mở và tổ chức tối đa 5 cộng tác viên.
  * [webceo.com](https://www.webceo.com/) — Công cụ SEO, kèm kiểm tra mã và nhiều loại thiết bị khác nhau
  * [zoompf.com](https://zoompf.com/) — Sửa lỗi hiệu suất website, phân tích chi tiết

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Tìm kiếm và duyệt mã (Code Search and Browsing)

  * [libraries.io](https://libraries.io/) — Tìm kiếm và nhận thông báo cập nhật phụ thuộc cho 32 trình quản lý package khác nhau, miễn phí cho mã nguồn mở
  * [Namae](https://namae.dev/) - Tìm kiếm tên dự án của bạn trên các trang như GitHub, Gitlab, Heroku, Netlify, và nhiều hơn nữa.
  * [searchcode.com](https://searchcode.com/) — Tìm kiếm mã dựa trên văn bản toàn diện, miễn phí cho mã nguồn mở
  * [tickgit.com](https://www.tickgit.com/) — Hiển thị các comment `TODO` (và marker khác) để xác định vùng mã nên cải thiện.
  * [CodeKeep](https://codekeep.io) - Google Keep cho đoạn mã. Tổ chức, khám phá, chia sẻ snippet mã, kèm công cụ chụp màn hình mã mạnh mẽ với template sẵn và tính năng liên kết.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## CI và CD

  * [AccessLint](https://github.com/marketplace/accesslint) — AccessLint mang kiểm tra truy cập web tự động vào quy trình phát triển của bạn. Miễn phí cho mã nguồn mở và mục đích giáo dục.
  * [appcircle.io](https://appcircle.io) — Nền tảng DevOps di động chuẩn doanh nghiệp, tự động hóa build, test, phát hành app mobile để rút ngắn chu kỳ release. Miễn phí tối đa 30 phút build/build, 20 build/tháng, 1 build đồng thời.
  * [appveyor.com](https://www.appveyor.com/) — Dịch vụ CD cho Windows, miễn phí cho mã nguồn mở
  * [LocalOps](https://localops.co/) - Triển khai ứng dụng lên AWS/GCP/Azure dưới 30 phút. Thiết lập môi trường ứng dụng chuẩn hóa trên bất kỳ đám mây nào, kèm tự động hóa CI/CD và giám sát nâng cao. Gói miễn phí cho 1 user, 1 môi trường ứng dụng.
  * [Argonaut](https://argonaut.dev/) - Triển khai ứng dụng và hạ tầng lên đám mây trong vài phút. Hỗ trợ triển khai ứng dụng tuỳ chỉnh và bên thứ ba trên môi trường Kubernetes và Lambda. Gói miễn phí không giới hạn số app & lần deploy cho 5 domain và 2 user.
  * [bitrise.io](https://www.bitrise.io/) — CI/CD cho ứng dụng di động, native hoặc hybrid. 200 build miễn phí/tháng, 10 phút/build, 2 thành viên nhóm. Dự án OSS được 45 phút/build, +1 đồng thời và không giới hạn thành viên.
  * [buddy.works](https://buddy.works/) — CI/CD với 5 dự án miễn phí và 1 tác vụ đồng thời (120 lần chạy/tháng)
  * [Buildkite](https://buildkite.com) CI Pipelines miễn phí cho 3 user và 5k phút job/tháng. Test Analytics miễn phí cho developer gồm 100k test/tháng, thêm ưu đãi miễn phí cho mã nguồn mở.
  * [bytebase.com](https://www.bytebase.com/) — Database CI/CD & DevOps. Miễn phí dưới 20 user và 10 database instance
  * [CircleCI](https://circleci.com/) — Gói miễn phí toàn diện, đầy đủ tính năng trên dịch vụ CI/CD hosted cho repo GitHub, GitLab, BitBucket. Nhiều loại tài nguyên, Docker, Windows, Mac OS, ARM, local runner, test splitting, Docker Layer Caching và nhiều tính năng CI/CD nâng cao khác. Miễn phí tối đa 6000 phút/tháng, không giới hạn cộng tác viên, 30 job song song dự án riêng tư, tối đa 80.000 phút build miễn phí cho dự án mã nguồn mở.
  * [cirrus-ci.org](https://cirrus-ci.org) - Miễn phí cho repo GitHub công khai
  * [cirun.io](https://cirun.io) - Miễn phí cho repo GitHub công khai
  * [codefresh.io](https://codefresh.io) — Gói Free-for-Life: 1 build, 1 môi trường, server chia sẻ, repo công khai không giới hạn
  * [codemagic.io](https://codemagic.io/) - Miễn phí 500 phút build/tháng
  * [codeship.com](https://codeship.com/) — 100 build riêng tư/tháng, 5 dự án riêng tư, không giới hạn cho mã nguồn mở
  * [deploybot.com](https://www.deploybot.com/) — 1 repo với 10 lần deploy, miễn phí cho mã nguồn mở
  * [deployhq.com](https://www.deployhq.com/) — 1 dự án với 10 lần deploy/ngày (30 phút build/tháng)
  * [drone](https://cloud.drone.io/) - Drone Cloud cho phép developer chạy pipeline CI/CD trên nhiều kiến trúc (x86, Arm 32-bit, 64-bit) trong một nơi duy nhất
  * [LayerCI](https://layerci.com) — CI cho dự án full stack. 1 môi trường preview full stack với 5GB RAM & 3 CPU.
  * [semaphoreci.com](https://semaphoreci.com/) — Miễn phí cho mã nguồn mở, 100 build riêng tư/tháng
  * [Squash Labs](https://www.squash.io/) — tạo VM cho mỗi nhánh và cung cấp app qua URL riêng biệt, repo công khai & riêng tư không giới hạn, VM tối đa 2 GB.
  * [styleci.io](https://styleci.io/) — Chỉ cho repo GitHub công khai
  * [Mergify](https://mergify.io) — tự động workflow và merge queue cho GitHub — Miễn phí cho repo GitHub công khai
  * [Make](https://www.make.com/en) — Công cụ tự động hóa workflow, kết nối app và tự động hóa qua giao diện trực quan. Hỗ trợ nhiều app & API phổ biến. Miễn phí cho repo GitHub công khai, và gói miễn phí với 100 Mb, 1000 thao tác, 15 phút/lần chạy tối thiểu.
  * [Spacelift](https://spacelift.io/) - Nền tảng quản lý Infrastructure as Code. Gói miễn phí: cộng tác IaC, registry module Terraform, tích hợp ChatOps, kiểm tra tuân thủ tài nguyên liên tục với Open Policy Agent, SSO với SAML 2.0, truy cập public worker pool: tối đa 200 phút/tháng
  * [microtica.com](https://microtica.com/) - Môi trường startup với các thành phần hạ tầng sẵn sàng, triển khai app lên AWS miễn phí, hỗ trợ cả production workload. Gói miễn phí gồm 1 môi trường (trên AWS của bạn), 2 dịch vụ Kubernetes, 100 phút build/tháng, 20 lần deploy/tháng.
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud tăng tốc cho các monorepo của bạn trên CI với các tính năng như lưu cache từ xa, phân phối tác vụ trên nhiều máy và thậm chí tự động chia nhỏ các lần chạy kiểm thử e2e. Có gói miễn phí cho tối đa 30 thành viên với 150.000 credits hào phóng.
* [blacksmith](https://www.blacksmith.sh/) - Runner hiệu năng được quản lý cho GitHub Actions, cung cấp 3.000 phút miễn phí mỗi tháng, không cần thẻ tín dụng.
* [Terramate](https://terramate.io/) - Nền tảng điều phối và quản lý cho các công cụ Infrastructure as Code (IaC) như Terraform, OpenTofu, và Terragrunt. Miễn phí cho tối đa 2 người dùng với đầy đủ tính năng.
* [Terrateam](https://terrateam.io) - Tự động hóa Terraform theo hướng GitOps với quy trình làm việc dựa trên pull request, cách ly dự án qua self-hosted runner và chạy phân lớp cho các thao tác có thứ tự. Miễn phí cho tối đa 3 người dùng.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Testing

* [Applitools.com](https://applitools.com/) — Xác thực thị giác thông minh cho web, ứng dụng di động native và desktop. Tích hợp với hầu hết các giải pháp tự động hóa (như Selenium và Karma) và các runner từ xa (Sauce Labs, Browser Stack). Miễn phí cho mã nguồn mở. Có gói miễn phí cho một người dùng với số lượng checkpoint giới hạn mỗi tuần.
* [Appetize](https://appetize.io) — Kiểm thử ứng dụng Android & iOS trên trình giả lập điện thoại/ máy tính bảng Android và trình mô phỏng iPhone/iPad dựa trên đám mây, trực tiếp trong trình duyệt. Gói miễn phí bao gồm hai phiên đồng thời với 30 phút sử dụng mỗi tháng. Không giới hạn kích thước ứng dụng.
* [Apptim](https://apptim.com) — Công cụ kiểm thử di động giúp những người không có kỹ năng kỹ thuật hiệu năng đánh giá hiệu suất và trải nghiệm người dùng (UX) của ứng dụng. Phiên bản desktop dùng thiết bị cá nhân hoàn toàn MIỄN PHÍ, kiểm thử không giới hạn trên cả iOS lẫn Android.
* [Argos](https://argos-ci.com) - Kiểm thử thị giác mã nguồn mở cho lập trình viên. Dự án không giới hạn, với 5.000 ảnh chụp màn hình mỗi tháng. Miễn phí cho dự án mã nguồn mở.
* [Bencher](https://bencher.dev/) - Bộ công cụ benchmark liên tục để phát hiện suy giảm hiệu suất CI. Miễn phí cho tất cả dự án công khai.
* [browserstack.com](https://www.browserstack.com/) — Kiểm thử trình duyệt thủ công và tự động, [miễn phí cho mã nguồn mở](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - Công cụ tự động hóa kiểm thử nhẹ cho ứng dụng web. Dễ học và không cần code. Có thể chạy không giới hạn bài test trên máy tính cá nhân miễn phí. Giám sát đám mây và tích hợp CI/CD có tính phí.
* [Checkly](https://checklyhq.com) - Giám sát tổng hợp theo hướng mã cho DevOps hiện đại. Giám sát API và ứng dụng với chi phí thấp hơn các nhà cung cấp truyền thống. Dựa trên quy trình Monitoring as Code và Playwright. Có gói miễn phí hào phóng cho dev.
* [checkbot.io](https://www.checkbot.io/) — Extension trình duyệt kiểm tra website của bạn theo hơn 50 tiêu chí tối ưu SEO, tốc độ và bảo mật. Gói miễn phí cho website nhỏ.
* [CORS-Tester](https://cors-error.dev/cors-tester/) - Công cụ miễn phí cho lập trình viên và tester API kiểm tra API đã bật CORS cho tên miền chưa và xác định thiếu sót. Đưa ra thông tin hành động cụ thể.
* [cypress.io](https://www.cypress.io/) - Kiểm thử nhanh, dễ dàng và tin cậy cho mọi thứ chạy trong trình duyệt. Cypress Test Runner luôn miễn phí và mã nguồn mở, không giới hạn. Cypress Dashboard miễn phí cho dự án mã nguồn mở, tối đa 5 người dùng.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - Tạo bài test Cypress/POM dựa trên AI ngay trên trình duyệt. Mã nguồn mở, trừ phần AI. Miễn phí 5 bài test tạo mới mỗi tháng với script tự phục hồi, email và kiểm thử thị giác.
* [everystep-automation.com](https://www.everystep-automation.com/) — Ghi và phát lại các bước trên trình duyệt web, tạo script, miễn phí với tùy chọn hạn chế.
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Công cụ Chaos Engineering của Gremlin cho phép bạn kiểm thử lỗi hệ thống một cách an toàn, phát hiện điểm yếu trước khi ảnh hưởng tới khách hàng. Gremlin Free cho phép tấn công Shutdown và CPU trên tối đa 5 máy chủ/container.
* [gridlastic.com](https://www.gridlastic.com/) — Kiểm thử Selenium Grid với gói miễn phí tối đa 4 node selenium đồng thời/10 lần khởi động grid/4.000 phút kiểm thử mỗi tháng.
* [katalon.com](https://katalon.com) - Nền tảng kiểm thử hỗ trợ nhóm ở mọi quy mô và cấp độ trưởng thành kiểm thử, gồm Katalon Studio, TestOps (+ Visual Testing miễn phí), TestCloud, và Katalon Recorder.
* [Keploy](https://keploy.io/) - Bộ công cụ kiểm thử chức năng cho lập trình viên. Ghi lại API call để tạo bài kiểm thử E2E cho API (KTests) và mock/stub (KMocks). Miễn phí cho dự án mã nguồn mở.
* [knapsackpro.com](https://knapsackpro.com) - Tăng tốc kiểm thử bằng cách chia nhỏ test suite tối ưu trên mọi nhà cung cấp CI. Chia nhỏ test Ruby, JavaScript trên các node CI song song để tiết kiệm thời gian. Gói miễn phí cho tối đa 10 phút file test và miễn phí không giới hạn cho dự án mã nguồn mở.
* [lambdatest.com](https://www.lambdatest.com/) — Kiểm thử trình duyệt thủ công, thị giác, chụp màn hình và tự động trên selenium, cypress, [miễn phí cho mã nguồn mở](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - Tự động tạo kiểm thử API và tải bằng cách phân tích lưu lượng mạng. Giả lập tối đa 50 người dùng đồng thời trong 60 phút miễn phí mỗi tháng.
* [lost-pixel.com](https://lost-pixel.com) - Kiểm thử hồi quy thị giác toàn diện cho Storybook, Ladle, Histoire story và Web App của bạn. Không giới hạn thành viên nhóm, hoàn toàn miễn phí cho mã nguồn mở, 7.000 ảnh mỗi tháng.
* [octomind.dev](https://www.octomind.dev/) - Tự động tạo, chạy và duy trì kiểm thử giao diện Playwright với AI hỗ trợ tạo case test.
* [percy.io](https://percy.io) - Thêm kiểm thử thị giác cho mọi web app, site tĩnh, style guide hoặc thư viện component. Không giới hạn thành viên nhóm, ứng dụng demo, dự án không giới hạn, 5.000 ảnh/tháng.
* [preflight.com](https://preflight.com) - Kiểm thử web tự động không cần code. Ghi lại bài kiểm thử trên trình duyệt, chống chịu thay đổi UI và chạy trên máy Windows. Có thể tích hợp CI/CD. Gói miễn phí gồm 50 lần chạy kiểm thử/tháng với video, HTML session và nhiều hơn nữa.
* [qase.io](https://qase.io) - Hệ thống quản lý kiểm thử cho nhóm Dev và QA. Quản lý test case, tạo test run, thực hiện kiểm thử, theo dõi lỗi và đo lường tác động. Gói miễn phí gồm đầy đủ tính năng cốt lõi, 500MB tệp đính kèm và tối đa 3 người dùng.
* [Repeato](https://repeato.app/) Công cụ tự động kiểm thử ứng dụng di động không cần code dựa trên computer vision và AI. Hỗ trợ app native, flutter, react-native, web, ionic và nhiều framework khác. Gói miễn phí giới hạn 10 bài test cho iOS, 10 cho Android, nhưng bao gồm hầu hết tính năng của gói trả phí, gồm chạy test không giới hạn.
* [Requestly](https://requestly.com/) Extension Chrome mã nguồn mở để Chặn, Chuyển hướng và Giả lập HTTP Request. Có [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) và [Session Recording](https://requestly.com/products/session-book/). Chuyển hướng URL, chỉnh sửa HTTP Header, giả lập API, inject JS tùy chỉnh, chỉnh sửa GraphQL Request, tạo Mock API Endpoint, ghi lại session với Network & Console Log. Tạo tối đa 10 rule ở gói miễn phí. Miễn phí cho mã nguồn mở.
* [seotest.me](https://seotest.me/) — Công cụ kiểm tra SEO on-page miễn phí. 10 lần crawl website miễn phí mỗi ngày. Nhiều tài nguyên học SEO hữu ích và đề xuất cải thiện SEO on-page cho mọi website bất kể công nghệ.
* [snippets.uilicious.com](https://snippets.uilicious.com) - Tương tự CodePen nhưng cho kiểm thử cross-browser. UI-licious cho phép bạn viết test như user story và cung cấp nền tảng miễn phí - UI-licious Snippets - cho phép chạy không giới hạn test trên Chrome không cần đăng ký, tối đa 3 phút mỗi lần chạy. Phát hiện bug? Bạn có thể copy URL duy nhất của bài test để chỉ cho dev cách tái hiện lỗi.
* [TestCollab](https://testcollab.com) - Phần mềm quản lý kiểm thử thân thiện với người dùng, gói miễn phí gồm tích hợp Jira, dự án không giới hạn, nhập test case bằng CSV/XLSx, theo dõi thời gian và 1GB lưu trữ tệp.
* [testingbot.com](https://testingbot.com/) — Kiểm thử Selenium Browser và Thiết bị, [miễn phí cho mã nguồn mở](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - Dashboard công bố kết quả kiểm thử tự động và Framework hiện thực kiểm thử thủ công dạng code với GitHub. Dịch vụ [miễn phí cho mã nguồn mở](https://github.com/marketplace/testspace-com), 450 kết quả hàng tháng.
* [tesults.com](https://www.tesults.com) — Báo cáo kết quả kiểm thử và quản lý test case. Tích hợp với các framework kiểm thử phổ biến. Lập trình viên mã nguồn mở, cá nhân, giáo viên, nhóm nhỏ mới bắt đầu có thể yêu cầu gói miễn phí hoặc ưu đãi ngoài dự án miễn phí cơ bản.
* [UseWebhook.com](https://usewebhook.com) - Bắt và kiểm tra webhook từ trình duyệt. Forward về localhost, hoặc phát lại từ lịch sử. Miễn phí sử dụng.
* [Vaadin](https://vaadin.com) — Xây dựng UI mở rộng bằng Java hoặc TypeScript, sử dụng bộ công cụ, component và hệ thống thiết kế tích hợp để lặp nhanh, thiết kế tốt và đơn giản hóa phát triển. Dự án không giới hạn, bảo trì miễn phí 5 năm.
* [websitepulse.com](https://www.websitepulse.com/tools/) — Nhiều công cụ mạng và máy chủ miễn phí.
* [webhook-test.com](https://webhook-test.com) - Gỡ lỗi và kiểm tra webhook, HTTP request với URL duy nhất trong quá trình tích hợp. Hoàn toàn miễn phí, tạo URL không giới hạn và nhận đề xuất cải thiện.
* [webhook.site](https://webhook.site) - Xác minh webhook, HTTP request outbound hoặc email với URL tùy chỉnh. URL và email tạm thời luôn miễn phí.
* [webhookbeam.com](https://webhookbeam.com) - Thiết lập webhook và giám sát qua thông báo đẩy và email.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Security and PKI

* [aikido.dev](https://www.aikido.dev) — Nền tảng appsec all-in-one bao gồm SCA, SAST, CSPM, DAST, Secrets, IaC, Malware, Container scanning, EOL,... Gói miễn phí cho 2 người, quét 10 repo, 1 cloud, 2 container & 1 domain.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — Phát hiện hệ thống bị xâm nhập trong mạng của bạn.
* [Altcha.org](https://altcha.org/anti-spam) - Bộ lọc spam cho website và API sử dụng xử lý ngôn ngữ tự nhiên và học máy. Gói miễn phí gồm 200 request/ngày mỗi domain.
* [atomist.com](https://atomist.com/) — Cách nhanh hơn, thuận tiện hơn để tự động hóa nhiều tác vụ phát triển. Hiện đang beta.
* [cloudsploit.com](https://cloudsploit.com/) — Kiểm tra bảo mật và tuân thủ cho AWS.
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — IOC (Indicator of Compromise) độ tin cậy cao nhắm vào hạ tầng cloud công cộng, một phần có trên github (https://github.com/unknownhad/AWSAttacks). Danh sách đầy đủ cung cấp qua API.
* [CodeNotary.io](https://www.codenotary.io/) — Nền tảng mã nguồn mở cung cấp bằng chứng bất biến để công chứng mã, file, thư mục hoặc container.
* [crypteron.com](https://www.crypteron.com/) — Nền tảng bảo mật hướng cloud, thân thiện lập trình viên, ngăn chặn rò rỉ dữ liệu trong ứng dụng .NET và Java.
* [CyberChef](https://gchq.github.io/CyberChef/) — Ứng dụng web đơn giản, trực quan để phân tích và mã hóa/giải mã dữ liệu mà không cần công cụ phức tạp hoặc ngôn ngữ lập trình. Như "dao đa năng" cho mã hóa & mật mã học. Tất cả tính năng đều miễn phí, không giới hạn. Mã nguồn mở nếu bạn muốn tự host.
* [DAS](https://signup.styra.com/) — Styra DAS Free, quản lý policy toàn vòng đời để tạo, triển khai và quản lý OPA (Open Policy Agent) authorization.
* [Datree](https://www.datree.io/) — Công cụ CLI mã nguồn mở ngăn cấu hình sai Kubernetes bằng cách đảm bảo manifest và Helm chart tuân thủ best practice cũng như chính sách tổ chức.
* [Dependabot](https://dependabot.com/) Tự động cập nhật dependency cho Ruby, JavaScript, Python, PHP, Elixir, Rust, Java (Maven và Gradle), .NET, Go, Elm, Docker, Terraform, Git Submodules, và GitHub Actions.
* [DJ Checkup](https://djcheckup.com) — Quét bảo mật tự động miễn phí cho site Django của bạn. Fork từ Pony Checkup.
* [Doppler](https://doppler.com/) — Universal Secrets Manager cho bí mật ứng dụng và cấu hình, hỗ trợ đồng bộ với nhiều cloud. Miễn phí cho 5 người dùng với quyền kiểm soát cơ bản.
* [Dotenv](https://dotenv.org/) — Đồng bộ file .env nhanh & bảo mật. Không còn phải chia sẻ file .env qua Slack, email không an toàn, và không bao giờ mất file .env quan trọng nữa. Miễn phí cho tối đa 3 thành viên.
* [GitGuardian](https://www.gitguardian.com) — Ngăn lộ bí mật trong mã nguồn với tự động phát hiện và khắc phục. Quét repo git cho hơn 350 loại bí mật và file nhạy cảm – Miễn phí cho cá nhân và nhóm tối đa 25 dev.
* [Have I been pwned?](https://haveibeenpwned.com) — REST API lấy thông tin vi phạm dữ liệu.
* [hostedscan.com](https://hostedscan.com) — Scanner lỗ hổng online cho ứng dụng web, server, mạng. 10 lần quét miễn phí mỗi tháng.
* [Infisical](https://infisical.com/) — Nền tảng mã nguồn mở quản lý bí mật developer trên toàn nhóm và hạ tầng: từ local dev đến staging/production/3rd-party service. Miễn phí cho tối đa 5 dev.
* [Internet.nl](https://internet.nl) — Kiểm tra tiêu chuẩn Internet hiện đại như IPv6, DNSSEC, HTTPS, DMARC, STARTTLS và DANE.
* [keychest.net](https://keychest.net) - Quản lý hết hạn SSL và mua chứng chỉ với database CT tích hợp.
* [letsencrypt.org](https://letsencrypt.org/) — CA SSL miễn phí với chứng chỉ được tin tưởng bởi tất cả trình duyệt lớn.
* [meterian.io](https://www.meterian.io/) - Giám sát lỗ hổng bảo mật dependency cho Java, Javascript, .NET, Scala, Ruby, NodeJS. Miễn phí cho 1 dự án private, dự án mã nguồn mở không giới hạn.
* [Mozilla Observatory](https://observatory.mozilla.org/) — Tìm và sửa lỗ hổng bảo mật trên site của bạn.
* [opswat.com](https://www.opswat.com/) — Giám sát bảo mật máy tính, thiết bị, ứng dụng, cấu hình, miễn phí 25 người dùng và lưu lịch sử 30 ngày.
* [openapi.security](https://openapi.security/) - Công cụ miễn phí kiểm tra nhanh bảo mật cho bất kỳ API OpenAPI / Swagger nào. Không cần đăng ký.
* [pixee.ai](https://pixee.ai) - Kỹ sư bảo mật sản phẩm tự động dưới dạng GitHub bot miễn phí, tạo PR cho code Java của bạn để tự động vá lỗ hổng. Các ngôn ngữ khác sắp có!
* [pyup.io](https://pyup.io) — Giám sát dependency Python về lỗ hổng bảo mật và tự động cập nhật. Miễn phí cho 1 dự án private, không giới hạn với dự án mã nguồn mở.
* [qualys.com](https://www.qualys.com/community-edition) — Tìm lỗ hổng web app, kiểm toán rủi ro OWASP.
* [report-uri.io](https://report-uri.io/) — Báo cáo vi phạm CSP và HPKP.
* [ringcaptcha.com](https://ringcaptcha.com/) — Công cụ dùng số điện thoại làm id, miễn phí.
* [seclookup.com](https://www.seclookup.com/) - API Seclookup giúp tăng thông tin đe dọa domain cho SIEM, cung cấp thông tin chi tiết về domain, cải thiện phát hiện & phản hồi mối đe dọa. 50K lookup miễn phí [tại đây](https://account.seclookup.com/).
* [snyk.io](https://snyk.io) — Tìm và sửa lỗ hổng bảo mật đã biết trong dependency mã nguồn mở. Kiểm thử và khắc phục không giới hạn cho dự án open source. Giới hạn 200 lần test/tháng cho dự án private.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — Phân tích chuyên sâu cấu hình SSL của bất kỳ web server nào.
* [SOOS](https://soos.io) - Quét SCA miễn phí, không giới hạn cho dự án mã nguồn mở. Phát hiện và sửa mối đe dọa bảo mật trước khi release. Bảo vệ dự án của bạn với giải pháp đơn giản, hiệu quả.
* [StackHawk](https://www.stackhawk.com/) Tự động quét ứng dụng xuyên suốt pipeline để tìm và sửa lỗi bảo mật trước khi lên production. Quét và môi trường không giới hạn cho 1 app.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - Kiểm tra bảo mật website và quét malware miễn phí.
* [Protectumus](https://protectumus.com) - Kiểm tra bảo mật website miễn phí, antivirus site và tường lửa máy chủ (WAF) cho PHP. Thông báo email cho user đăng ký ở tầng miễn phí.
* [TestTLS.com](https://testtls.com) - Kiểm tra dịch vụ SSL/TLS về cấu hình server bảo mật, chứng chỉ, chuỗi, v.v. Không chỉ HTTPS.
* [threatconnect.com](https://threatconnect.com) — Threat intelligence: Dành cho nhà nghiên cứu, phân tích cá nhân và tổ chức mới tìm hiểu về intelligence an ninh mạng. Miễn phí cho tối đa 3 người dùng.
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — Quét lỗ hổng tự động. Gói miễn phí cho phép quét XSS hàng tuần.
* [Ubiq Security](https://ubiqsecurity.com/) — Mã hóa/giải mã dữ liệu chỉ với 3 dòng code, quản lý key tự động. Miễn phí cho 1 ứng dụng, tối đa 1.000.000 lần mã hóa/tháng.
* [Virgil Security](https://virgilsecurity.com/) — Công cụ và dịch vụ triển khai mã hóa đầu-cuối, bảo vệ database, bảo mật IoT,... cho giải pháp số của bạn. Miễn phí cho ứng dụng tối đa 250 người dùng.
* [Vulert](https://vulert.com) - Vulert liên tục theo dõi dependency mã nguồn mở của bạn để phát hiện lỗ hổng mới, khuyến nghị sửa, không cần cài đặt hay truy cập codebase. Miễn phí cho dự án mã nguồn mở.
* [Escape GraphQL Quickscan](https://escape.tech/) - Quét bảo mật endpoint GraphQL chỉ với một cú nhấp. Miễn phí, không cần đăng nhập.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - Tìm kiếm trong 20 triệu bí mật bị lộ trên repo, gist, issue, comment công khai GitHub miễn phí.
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - Bộ công cụ SSL all-in-one: tạo Private Key & CSR, giải mã SSL Certificate, so khớp chứng chỉ, đặt mua SSL Certificate. Hỗ trợ tạo SSL miễn phí từ Let's Encrypt, Google Trust, BuyPass qua CNAME thay vì TXT record.
**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Xác thực, Ủy quyền và Quản lý Người dùng

  * [Aserto](https://www.aserto.com) - Dịch vụ ủy quyền chi tiết cho ứng dụng và API. Miễn phí tới 1000 MAU và 100 phiên bản authorizer.
  * [asgardeo.io](https://wso2.com/asgardeo) - Tích hợp liền mạch SSO, MFA, xác thực không mật khẩu và nhiều hơn nữa. Bao gồm SDK cho ứng dụng frontend và backend. Miễn phí tới 1000 MAU và năm nhà cung cấp định danh.
  * [Auth0](https://auth0.com/) — Dịch vụ SSO lưu trữ. Gói miễn phí bao gồm 25.000 MAU, kết nối mạng xã hội không giới hạn, tên miền tuỳ chỉnh và nhiều hơn nữa.
  * [Authgear](https://www.authgear.com) - Mang xác thực không mật khẩu, OTP, 2FA, SSO tới ứng dụng của bạn chỉ trong vài phút. Đã bao gồm toàn bộ Front-end. Miễn phí tới 5000 MAU.
  * [Authress](https://authress.io/) — Đăng nhập xác thực và kiểm soát truy cập, không giới hạn nhà cung cấp định danh cho mọi dự án. Facebook, Google, Twitter và nhiều hơn nữa. 1000 API call đầu tiên miễn phí.
  * [Authy](https://authy.com) - Xác thực hai yếu tố (2FA) trên nhiều thiết bị, có sao lưu. Thay thế nhanh cho Google Authenticator. Miễn phí tới 100 lần xác thực thành công.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - Hệ thống quản lý ủy quyền đầy đủ cho việc xây dựng, kiểm thử và triển khai chính sách truy cập. Ủy quyền và kiểm soát truy cập chi tiết, miễn phí tới 100 principals hoạt động mỗi tháng.
  * [Clerk](https://clerk.com) — Quản lý người dùng, xác thực, 2FA/MFA, các thành phần UI dựng sẵn cho đăng nhập, đăng ký, hồ sơ người dùng và nhiều hơn nữa. Miễn phí tới 10.000 người dùng hoạt động hàng tháng.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak Identity and Access Management dưới dạng dịch vụ. Miễn phí tới 100 người dùng và một realm.
  * [Corbado](https://www.corbado.com/) — Thêm xác thực ưu tiên passkey cho ứng dụng mới hoặc hiện có. Miễn phí cho số lượng MAU không giới hạn.
  * [Descope](https://www.descope.com/) — Quy trình xác thực tuỳ biến cao, hỗ trợ cả phương pháp không-code và API/SDK. Miễn phí 7.500 người dùng hoạt động/tháng, 50 tenants (tối đa 5 tenant SAML/SSO).
  * [duo.com](https://duo.com/) — Xác thực hai yếu tố (2FA) cho trang web hoặc ứng dụng. Miễn phí cho mười người dùng, tất cả phương thức xác thực, không giới hạn tích hợp, token phần cứng.
  * [Kinde](https://kinde.com/) - Xác thực đơn giản, mạnh mẽ bạn có thể tích hợp vào sản phẩm chỉ trong vài phút. Đầy đủ tính năng khởi đầu với 7.500 MAU miễn phí.
  * [logintc.com](https://www.logintc.com/) — Xác thực hai yếu tố (2FA) qua push notification, miễn phí cho mười người dùng, VPN, Website và SSH.
  * [MojoAuth](https://mojoauth.com/) - MojoAuth giúp dễ dàng triển khai xác thực không mật khẩu cho web, mobile hoặc bất kỳ ứng dụng nào chỉ trong vài phút.
  * [Okta](https://developer.okta.com/signup/) — Quản lý người dùng, xác thực và ủy quyền. Miễn phí cho tối đa 100 người dùng hoạt động hàng tháng.
  * [onelogin.com](https://www.onelogin.com/) — Dịch vụ định danh (IDaaS), Single Sign-On Identity Provider, Cloud SSO IdP, ba ứng dụng công ty và năm ứng dụng cá nhân, không giới hạn người dùng.
  * [Ory](https://ory.sh/) - Nền tảng bảo mật quản lý AuthN/AuthZ/OAuth2.0/Zero Trust. Tài khoản developer miễn phí vĩnh viễn với mọi tính năng bảo mật, không giới hạn thành viên, 200 người dùng hoạt động mỗi ngày và 25k lần kiểm tra phân quyền mỗi tháng.
  * [Permit.io](https://permit.io) - Nền tảng Authorization-as-a-service cho phép RBAC, ABAC và ReBAC cho microservices quy mô lớn với cập nhật thời gian thực và UI chính sách không-code. Gói miễn phí cho 1000 người dùng hoạt động hàng tháng.
  * [Phase Two](https://phasetwo.io) - Keycloak Open Source Identity and Access Management. Miễn phí một realm tới 1000 người dùng, tối đa 10 kết nối SSO, sử dụng container Keycloak nâng cao của Phase Two bao gồm tiện ích mở rộng [Organization](https://phasetwo.io/product/organizations/).
  * [SSOJet](https://ssojet.com/) - Thêm Enterprise SSO mà không cần xây lại hệ thống xác thực. Gói miễn phí gồm người dùng hoạt động không giới hạn hàng tháng, số lượng tổ chức không giới hạn, 2 kết nối SSO & 2 kết nối SCIM.
  * [Stytch](https://www.stytch.com/) - Nền tảng tổng hợp cung cấp API và SDK cho xác thực và phòng chống gian lận. Gói miễn phí gồm 10.000 MAU, tổ chức không giới hạn, 5 kết nối SSO hoặc SCIM, và 1.000 token M2M.
  * [Stack Auth](https://stack-auth.com) — Xác thực mã nguồn mở, thân thiện với developer, bắt đầu chỉ trong 5 phút. Có thể tự host miễn phí hoặc dùng SaaS quản lý với 10k MAU miễn phí.
  * [SuperTokens](https://supertokens.com/) - Xác thực người dùng mã nguồn mở tích hợp trực tiếp vào ứng dụng - giúp bạn khởi đầu nhanh chóng, kiểm soát trải nghiệm người dùng và developer. Miễn phí tới 5000 MAU.
  * [Warrant](https://warrant.dev/) — Dịch vụ ủy quyền và kiểm soát truy cập cấp doanh nghiệp cho ứng dụng của bạn. Gói miễn phí gồm 1 triệu request API hàng tháng và 1.000 quy tắc authz.
  * [ZITADEL Cloud](https://zitadel.com) — Quản lý người dùng và truy cập turnkey hỗ trợ đa tenant (B2B). Miễn phí tới 25.000 request xác thực, với mọi tính năng bảo mật (không chặn OTP, Passwordless, Policy, v.v.).
  * [PropelAuth](https://propelauth.com) — Bán cho các công ty mọi quy mô chỉ với vài dòng code, miễn phí tới 200 người dùng và 10k email giao dịch (có watermark "Powered by PropelAuth").
  * [Logto](https://logto.io/) - Phát triển, bảo mật và quản lý định danh người dùng sản phẩm - cả xác thực và ủy quyền. Miễn phí tới 5.000 MAU với tùy chọn mã nguồn mở tự host.
  * [WorkOS](https://workos.com/) - Quản lý người dùng và xác thực miễn phí tới 1 triệu MAU. Hỗ trợ email + mật khẩu, xác thực mạng xã hội, Magic Auth, MFA, v.v.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Phân phối và Phản hồi Ứng dụng Di động

  * [TestApp.io](https://testapp.io) - Nền tảng đảm bảo ứng dụng di động của bạn hoạt động đúng như mong muốn. Gói miễn phí: một ứng dụng, analytics, không giới hạn phiên bản & lượt cài, thu thập phản hồi.
  * [Loadly](https://loadly.io) - Dịch vụ phân phối ứng dụng beta cho iOS & Android hoàn toàn miễn phí với tải xuống không giới hạn, tốc độ cao, tải lên không giới hạn.
  * [Diawi](https://www.diawi.com) - Triển khai ứng dụng iOS & Android trực tiếp lên thiết bị. Gói miễn phí: upload ứng dụng, liên kết có mật khẩu, hết hạn sau 1 ngày, tối đa 10 lượt cài đặt.
  * [InstallOnAir](https://www.installonair.com) - Phân phối ứng dụng iOS & Android qua mạng. Gói miễn phí: upload không giới hạn, liên kết riêng tư, khách hết hạn liên kết sau 2 ngày, người dùng đăng ký 60 ngày.
  * [GetUpdraft](https://www.getupdraft.com) - Phân phối ứng dụng di động để thử nghiệm. Gói miễn phí gồm 1 dự án ứng dụng, 3 phiên bản ứng dụng, 500 MB lưu trữ, 100 lượt cài đặt/tháng.
  * [Appho.st](https://appho.st) - Nền tảng lưu trữ ứng dụng di động. Gói miễn phí gồm 5 ứng dụng, 50 lượt tải/tháng, kích thước tệp tối đa 100 MB.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Hệ Thống Quản Lý

  * [bitnami.com](https://bitnami.com/) — Triển khai ứng dụng chuẩn bị sẵn trên IaaS. Quản lý 1 AWS micro instance miễn phí
  * [Esper](https://esper.io) — MDM và MAM cho thiết bị Android với DevOps. Một trăm thiết bị miễn phí với một giấy phép người dùng và 25 MB lưu trữ ứng dụng.
  * [jamf.com](https://www.jamf.com/) — Quản lý thiết bị cho iPad, iPhone và Mac, miễn phí ba thiết bị
  * [Miradore](https://miradore.com) — Dịch vụ quản lý thiết bị. Theo dõi đội thiết bị và bảo mật thiết bị không giới hạn miễn phí. Gói miễn phí cung cấp các tính năng cơ bản.
  * [moss.sh](https://moss.sh) - Giúp developer triển khai và quản lý web app và server. Miễn phí tới 25 lần triển khai git mỗi tháng.
  * [runcloud.io](https://runcloud.io/) - Quản lý server tập trung vào dự án PHP. Miễn phí cho tối đa 1 server.
  * [ploi.io](https://ploi.io/) - Công cụ quản lý server để dễ dàng quản lý và triển khai server & site. Miễn phí cho một server.
  * [xcloud.host](https://xcloud.host) — Nền tảng quản lý và triển khai server với giao diện thân thiện. Có gói miễn phí cho một server.
  * [serveravatar.com](https://serveravatar.com) — Quản lý và giám sát web server PHP với cấu hình tự động. Miễn phí cho một server.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Nhắn tin và Streaming

  * [Ably](https://www.ably.com/) - Dịch vụ nhắn tin thời gian thực với presence, persistence và đảm bảo giao nhận. Gói miễn phí gồm 3 triệu tin nhắn/tháng, 100 kết nối đồng thời, 100 kênh đồng thời.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ dưới dạng dịch vụ. Gói Little Lemur: tối đa 1 triệu tin nhắn/tháng, tối đa 20 kết nối đồng thời, tối đa 100 hàng đợi, tối đa 10.000 tin nhắn chờ, nhiều node ở các AZ khác nhau.
  * [courier.com](https://www.courier.com/) — API duy nhất cho push, in-app, email, chat, SMS và các kênh nhắn tin khác với quản lý template. Gói miễn phí gồm 10.000 tin nhắn/tháng.
  * [engagespot.co](https://engagespot.co/) — Hạ tầng thông báo đa kênh với inbox in-app dựng sẵn và trình chỉnh sửa template không-code. Gói miễn phí gồm 10.000 tin nhắn/tháng.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - Kết nối thiết bị MQTT với Cloud Native IoT Messaging Broker. Miễn phí kết nối tới 100 thiết bị (không cần thẻ tín dụng) vĩnh viễn.
  * [knock.app](https://knock.app) – Hạ tầng thông báo cho developer. Gửi tới nhiều kênh như in-app, email, SMS, Slack, push chỉ với một API call. Gói miễn phí gồm 10.000 tin nhắn/tháng.
  * [NotificationAPI.com](https://www.notificationapi.com/) — Thêm thông báo người dùng vào phần mềm chỉ trong 5 phút. Gói miễn phí gồm 10.000 thông báo/tháng + 100 SMS và cuộc gọi tự động.
  * [Novu.co](https://novu.co) — Hạ tầng thông báo mã nguồn mở cho developer. Thành phần và API đơn giản để quản lý mọi kênh giao tiếp: Email, SMS, Direct, In-App, Push. Gói miễn phí gồm 30.000 thông báo/tháng, lưu trữ 90 ngày.
  * [pusher.com](https://pusher.com/) — Dịch vụ nhắn tin thời gian thực. Miễn phí tới 100 kết nối đồng thời và 200.000 tin nhắn/ngày.
  * [scaledrone.com](https://www.scaledrone.com/) — Dịch vụ nhắn tin thời gian thực. Miễn phí tới 20 kết nối đồng thời và 100.000 sự kiện/ngày.
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) dưới dạng dịch vụ. Toàn cầu, AWS, GCP, Azure. Miễn phí vĩnh viễn với kích thước 4k msg, 50 kết nối hoạt động, 5GB dữ liệu/tháng.
  * [pubnub.com](https://www.pubnub.com/) - Swift, Kotlin, React messaging với 1 triệu giao dịch mỗi tháng. Giao dịch có thể chứa nhiều tin nhắn.
  * [eyeson API](https://developers.eyeson.team/) - API giao tiếp video dựa trên WebRTC (SFU, MCU) để xây dựng nền tảng video. Hỗ trợ tiêm dữ liệu thời gian thực, bố cục video, ghi lại, UI web đầy đủ tính năng (quickstart) hoặc package cho UI tùy chỉnh. [Gói miễn phí cho developer](https://apiservice.eyeson.com/api-pricing) với 1000 phút họp/tháng.
  * [webpushr](https://www.webpushr.com/) - Thông báo Web Push - Miễn phí tới 10k subscribers, không giới hạn thông báo, nhắn tin trong trình duyệt.
  * [httpSMS](https://httpsms.com) - Gửi và nhận tin nhắn SMS dùng điện thoại Android làm SMS Gateway. Miễn phí gửi/nhận tối đa 200 tin nhắn/tháng.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - MQTT broker serverless mở rộng và bảo mật, khởi tạo trong vài giây. 1 triệu phút session/tháng miễn phí vĩnh viễn (không cần thẻ tín dụng).
  * [Pocket Alert](https://pocketalert.app) - Gửi thông báo push tới thiết bị iOS và Android. Tích hợp dễ dàng qua API hoặc Webhook và kiểm soát toàn bộ cảnh báo. Gói miễn phí: 50 tin nhắn/ngày tới 1 thiết bị và 1 ứng dụng.
  * [SuprSend](https://www.suprsend.com/) - Hạ tầng thông báo streamline notification sản phẩm với API đầu tiên. Tạo và gửi thông báo giao dịch, cron, engagement đa kênh chỉ với một API. Gói miễn phí gồm 10.000 thông báo/tháng, gồm các workflow node như digest, batch, đa kênh, sở thích, tenant, broadcast, v.v.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Quản lý Log

  * [bugfender.com](https://bugfender.com/) — Miễn phí tới 100k dòng log/ngày với thời gian lưu 24 giờ
  * [logentries.com](https://logentries.com/) — Miễn phí tới 5 GB/tháng với thời gian lưu 7 ngày
  * [loggly.com](https://www.loggly.com/) — Miễn phí cho một người dùng, 200MB/ngày với thời gian lưu 7 ngày
  * [logz.io](https://logz.io/) — Miễn phí tới 1 GB/ngày, lưu trong 1 ngày
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Dịch vụ quản lý log bởi Manage Engine. Gói miễn phí gồm 50 GB lưu trữ với 15 ngày lưu trữ và tìm kiếm 7 ngày.
  * [papertrailapp.com](https://papertrailapp.com/) — Tìm kiếm 48 giờ, lưu trữ 7 ngày, 50 MB/tháng
  * [sematext.com](https://sematext.com/logsene) — Miễn phí tới 500 MB/ngày, lưu trữ 7 ngày
  * [sumologic.com](https://www.sumologic.com/) — Miễn phí tới 500 MB/ngày, lưu trữ 7 ngày
  * [logflare.app](https://logflare.app/) — Miễn phí tới 12.960.000 bản ghi mỗi ứng dụng mỗi tháng, lưu trữ 3 ngày
  * [logtail.com](https://logtail.com/) — Quản lý log dựa trên ClickHouse, tương thích SQL. Miễn phí tới 1 GB/tháng, lưu trữ ba ngày.
  * [logzab.com](https://logzab.com/) — Hệ thống quản lý audit trail. Miễn phí 1.000 log hoạt động người dùng/tháng, lưu trữ 1 tháng, tối đa 5 dự án.
  * [openobserve.ai](https://openobserve.ai/) - 200 GB ingestion/tháng miễn phí, lưu trữ 15 ngày
**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Quản lý Dịch thuật

  * [crowdin.com](https://crowdin.com/) — Không giới hạn dự án, không giới hạn chuỗi và cộng tác viên cho mã nguồn mở
  * [gitlocalize.com](https://gitlocalize.com) - Miễn phí và không giới hạn cho cả kho riêng tư và công khai
  * [Lecto](https://lecto.ai/) - API Dịch máy với gói Miễn phí (30 yêu cầu miễn phí, 1000 ký tự dịch mỗi yêu cầu). Tích hợp với plugin Loco Translate Wordpress.
  * [lingohub.com](https://lingohub.com/) — Miễn phí cho tối đa 3 người dùng, luôn miễn phí cho mã nguồn mở
  * [localazy.com](https://localazy.com) - Miễn phí cho 1000 chuỗi ngôn ngữ gốc, không giới hạn ngôn ngữ, không giới hạn cộng tác viên, ưu đãi cho startup và mã nguồn mở
  * [Localeum](https://localeum.com) - Miễn phí cho tối đa 1000 chuỗi, một người dùng, không giới hạn ngôn ngữ, không giới hạn dự án
  * [localizely.com](https://localizely.com/) — Miễn phí cho mã nguồn mở
  * [Loco](https://localise.biz/) — Miễn phí cho tối đa 2000 bản dịch, Không giới hạn dịch giả, mười ngôn ngữ/dự án, 1000 tài sản có thể dịch/dự án
  * [oneskyapp.com](https://www.oneskyapp.com/) — Phiên bản miễn phí giới hạn cho tối đa 5 người dùng, miễn phí cho mã nguồn mở
  * [POEditor](https://poeditor.com/) — Miễn phí cho tối đa 1000 chuỗi
  * [SimpleLocalize](https://simplelocalize.io/) - Miễn phí cho tối đa 100 khóa dịch, không giới hạn chuỗi, không giới hạn ngôn ngữ, ưu đãi cho startup
  * [Texterify](https://texterify.com/) - Miễn phí cho một người dùng
  * [Tolgee](https://tolgee.io) - Cung cấp SaaS miễn phí với giới hạn bản dịch, phiên bản self-hosted miễn phí vĩnh viễn
  * [transifex.com](https://www.transifex.com/) — Miễn phí cho mã nguồn mở
  * [Translation.io](https://translation.io) - Miễn phí cho mã nguồn mở
  * [Translized](https://translized.com) - Miễn phí cho tối đa 1000 chuỗi, một người dùng, không giới hạn ngôn ngữ, không giới hạn dự án
  * [webtranslateit.com](https://webtranslateit.com/) — Miễn phí cho tối đa 500 chuỗi
  * [weblate.org](https://weblate.org/) — Miễn phí cho dự án tự do với tối đa 10.000 chuỗi nguồn cho gói miễn phí và không giới hạn cho phiên bản tự triển khai tại chỗ.
  * [Free PO editor](https://pofile.net/free-po-editor) — Miễn phí cho mọi người
  * [Lingo.dev](https://lingo.dev) – Công cụ CLI mã nguồn mở sử dụng AI cho bản địa hóa web & di động. Có thể dùng LLM của bạn hoặc sử dụng 10.000 từ miễn phí mỗi tháng qua engine bản địa hóa do Lingo.dev quản lý.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Giám sát (Monitoring)

  * [UptimeObserver.com](https://uptimeobserver.com) - Nhận 20 bộ giám sát uptime với khoảng thời gian kiểm tra 5 phút và trang trạng thái có thể tùy chỉnh — kể cả cho mục đích thương mại. Nhận thông báo thời gian thực, không giới hạn qua email và Telegram. Không cần thẻ tín dụng để bắt đầu.
  * [Pingmeter.com](https://pingmeter.com/) - 5 bộ giám sát uptime với khoảng thời gian kiểm tra 10 phút. Giám sát SSH, HTTP, HTTPS và bất kỳ cổng TCP tùy chỉnh nào.
  * [alerty.ai](https://www.alerty.ai) - APM miễn phí và giám sát cho FE, BE, DB và nhiều hơn nữa + agent miễn phí.
  * [appdynamics.com](https://www.appdynamics.com/) — Miễn phí cho dữ liệu trong 24 giờ, agent quản lý hiệu suất ứng dụng giới hạn một Java, một .NET, một PHP, và một Node.js
  * [appneta.com](https://www.appneta.com/) — Miễn phí với dữ liệu lưu trữ 1 giờ
  * [appspector.com](https://appspector.com/) - Trung tâm điều khiển cho debug iOS/Android/Flutter từ xa. Miễn phí cho lưu lượng nhỏ (64MB log).
  * [assertible.com](https://assertible.com) — Kiểm thử và giám sát API tự động. Gói miễn phí cho nhóm và cá nhân.
  * [bleemeo.com](https://bleemeo.com) - Miễn phí cho 3 máy chủ, 5 bộ giám sát uptime, không giới hạn người dùng, không giới hạn dashboard, không giới hạn quy tắc cảnh báo.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - Xem lịch sử Core Web Vitals cho một url hoặc website.
  * [checklyhq.com](https://checklyhq.com) - Nguồn mở giám sát E2E/Synthetic và giám sát API chuyên sâu cho lập trình viên. Gói miễn phí với một người dùng và 10k lần kiểm tra API & mạng / 1.5k lần kiểm tra trình duyệt.
  * [cloudsploit.com](https://cloudsploit.com) — Giám sát cấu hình và bảo mật AWS. Miễn phí: quét theo yêu cầu không giới hạn, người dùng không giới hạn, tài khoản lưu trữ không giới hạn. Gói trả phí: quét tự động, truy cập API, v.v.
  * [cronitor.io](https://cronitor.io/) - Phân tích hiệu suất và giám sát uptime cho cron job, website, API và hơn thế nữa. Gói miễn phí với 5 bộ giám sát.
  * [datadoghq.com](https://www.datadoghq.com/) — Miễn phí cho tối đa 5 node
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — Giám sát cron job. Một snitch (bộ giám sát) miễn phí, thêm nếu giới thiệu người đăng ký mới
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 bộ giám sát uptime, khoảng thời gian 5 phút. Cảnh báo qua Email, Slack.
  * [economize.cloud](https://economize.cloud) — Economize giúp làm rõ chi phí hạ tầng đám mây bằng cách tổ chức tài nguyên đám mây để tối ưu hóa và báo cáo. Miễn phí cho chi tiêu lên đến $5.000 trên Google Cloud Platform mỗi tháng.
  * [elastic.co](https://www.elastic.co/solutions/apm) — Phân tích hiệu suất tức thì cho lập trình viên JS. Miễn phí với dữ liệu lưu trữ 24 giờ
  * [fivenines.io](https://fivenines.io/) — Giám sát máy chủ Linux với dashboard thời gian thực và cảnh báo — miễn phí vĩnh viễn cho tối đa 5 máy chủ giám sát ở khoảng thời gian 60 giây. Không cần thẻ tín dụng.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud là nền tảng tổng hợp cho giám sát, tích hợp chỉ số và log với Grafana. Miễn phí: 3 người dùng, mười dashboard, 100 cảnh báo, lưu trữ chỉ số trong Prometheus và Graphite (10.000 series, lưu trữ 14 ngày), lưu trữ log trong Loki (50 GB log, lưu trữ 14 ngày)
  * [healthchecks.io](https://healthchecks.io) — Giám sát cron job và các tác vụ nền. Miễn phí cho tối đa 20 kiểm tra.
  * [Hydrozen.io](https://hydrozen.io) — Giám sát uptime & trang trạng thái, Gói miễn phí: 10 bộ giám sát uptime, 5 bộ giám sát heartbeat, 1 bộ giám sát tên miền và 1 statuspage miễn phí.
  * [incidenthub.cloud](https://incidenthub.cloud/) — Tổng hợp trang trạng thái đám mây và SaaS - 20 bộ giám sát và 2 kênh thông báo (Slack và Discord) miễn phí vĩnh viễn.
  * [inspector.dev](https://www.inspector.dev) - Dashboard giám sát thời gian thực đầy đủ trong chưa đến một phút với gói miễn phí vĩnh viễn.
  * [instrumentalapp.com](https://instrumentalapp.com) - Giám sát ứng dụng và máy chủ đẹp, dễ dùng với tối đa 500 chỉ số và hiển thị dữ liệu 3 giờ miễn phí
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Kiểm tra tốc độ độc lập và độ trễ bắt tay TLS với Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - Giám sát SSL, miễn phí cho tối đa 5 bộ giám sát
  * [linkok.com](https://linkok.com) - Kiểm tra liên kết hỏng trực tuyến, miễn phí cho website nhỏ tới 100 trang, hoàn toàn miễn phí cho dự án mã nguồn mở.
  * [loader.io](https://loader.io/) — Công cụ kiểm tra tải miễn phí có giới hạn
  * [MonitorMonk](https://monitormonk.com) - Giám sát uptime tối giản với trang trạng thái đẹp. Gói Free Forever cung cấp giám sát HTTPS, từ khóa, SSL và thời gian phản hồi cho 10 website hoặc endpoint API, kèm 2 dashboard/trang trạng thái.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata là công cụ nguồn mở để thu thập chỉ số thời gian thực. Sản phẩm đang phát triển và cũng có thể tìm thấy trên GitHub!
  * [newrelic.com](https://www.newrelic.com) — Nền tảng giám sát New Relic giúp kỹ sư tạo phần mềm hoàn hảo hơn. Từ monolith tới serverless, bạn có thể giám sát mọi thứ và phân tích, khắc phục, tối ưu hóa toàn bộ stack phần mềm. Gói miễn phí cung cấp 100GB dữ liệu/tháng, một người dùng toàn quyền miễn phí và không giới hạn người dùng chính miễn phí.
  * [Middleware.io](https://middleware.io/) - Nền tảng giám sát Middleware cung cấp khả năng quan sát toàn diện ứng dụng & stack, cho phép bạn giám sát & chẩn đoán sự cố ở quy mô lớn. Có gói miễn phí vĩnh viễn cho cộng đồng Dev cho phép giám sát Log tới 1 triệu sự kiện, giám sát hạ tầng & APM cho tối đa 2 máy chủ.
  * [nixstats.com](https://nixstats.com) - Miễn phí cho một máy chủ. Thông báo qua Email, trang trạng thái công khai, khoảng thời gian 60 giây, v.v.
  * [OnlineOrNot.com](https://onlineornot.com/) - OnlineOrNot cung cấp giám sát uptime cho website và API, giám sát cron job và tác vụ định kỳ. Có cả trang trạng thái. 5 kiểm tra đầu tiên với khoảng cách 3 phút được miễn phí. Gói miễn phí gửi cảnh báo qua Slack, Discord và Email.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — Kiểm tra website có bị chặn ở Trung Quốc bởi Tường lửa lớn hay không. Xác định ô nhiễm DNS bằng cách so sánh kết quả DNS và ASN từ máy chủ ở Trung Quốc so với Mỹ.
  * [opsgenie.com](https://www.opsgenie.com/) — Cảnh báo mạnh mẽ và quản lý trực ca cho dịch vụ luôn hoạt động. Miễn phí cho tối đa 5 người dùng.
  * [paessler.com](https://www.paessler.com/) — Giải pháp giám sát hạ tầng và mạng mạnh mẽ, gồm cảnh báo, trực quan hóa và báo cáo cơ bản. Miễn phí cho tối đa 100 cảm biến.
  * [pagecrawl.io](https://pagecrawl.io/) -  Giám sát thay đổi website, miễn phí cho tối đa 6 bộ giám sát kiểm tra hàng ngày.
  * [syagent.com](https://syagent.com/) — Dịch vụ giám sát máy chủ miễn phí phi thương mại, cảnh báo và chỉ số.
  * [pagerly.io](https://pagerly.io/) -  Quản lý trực ca trên Slack (tích hợp với Pagerduty, OpsGenie). Miễn phí cho tối đa 1 nhóm (mỗi nhóm tương ứng một ca trực)
  * [pagertree.com](https://pagertree.com/) - Giao diện đơn giản cho cảnh báo và quản lý trực ca. Miễn phí cho tối đa 5 người dùng.
  * [phare.io](https://phare.io/) - Giám sát Uptime miễn phí cho tối đa 100.000 sự kiện cho không giới hạn dự án và không giới hạn trang trạng thái.
  * [pingbreak.com](https://pingbreak.com/) — Dịch vụ giám sát uptime hiện đại. Kiểm tra URL không giới hạn và nhận thông báo downtime qua Discord, Slack, hoặc email.
  * [pingpong.one](https://pingpong.one/) — Nền tảng trang trạng thái nâng cao kèm giám sát. Gói miễn phí gồm một trang trạng thái công khai có thể tùy chỉnh với tên miền phụ SSL. Kế hoạch Pro miễn phí cho dự án mã nguồn mở và tổ chức phi lợi nhuận.
  * [robusta.dev](https://home.robusta.dev/) — Giám sát Kubernetes mạnh mẽ dựa trên Prometheus. Có thể sử dụng Prometheus của bạn hoặc cài đặt gói all-in-one. Gói miễn phí cho tối đa 20 node Kubernetes. Cảnh báo qua Slack, Microsoft Teams, Discord, v.v. Tích hợp với PagerDuty, OpsGenie, VictorOps, DataDog và nhiều công cụ khác.
  * [sematext.com](https://sematext.com/) — Miễn phí cho dữ liệu 24h, không giới hạn máy chủ, mười chỉ số tùy chỉnh, 500.000 điểm dữ liệu chỉ số tùy chỉnh, không giới hạn dashboard, người dùng, v.v.
  * [sitemonki.com](https://sitemonki.com/) — Giám sát website, tên miền, Cron & SSL, 5 bộ giám sát ở mỗi loại miễn phí
  * [sitesure.net](https://sitesure.net) - Giám sát website và cron - 2 bộ giám sát miễn phí
  * [skylight.io](https://www.skylight.io/) — Miễn phí cho 100.000 request đầu tiên (chỉ Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — API giám sát hiệu suất, kiểm tra Ping, DNS, v.v.
  * [stathat.com](https://www.stathat.com/) — Bắt đầu với mười chỉ số miễn phí, không giới hạn thời gian
  * [statuscake.com](https://www.statuscake.com/) — Giám sát website, test không giới hạn miễn phí có giới hạn
  * [statusgator.com](https://statusgator.com/) — Giám sát trang trạng thái, 3 bộ giám sát miễn phí
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — Giám sát máy chủ, giám sát uptime, giám sát DNS & tên miền. Giám sát 10 máy chủ, 10 uptime và 10 tên miền miễn phí.
  * [thousandeyes.com](https://www.thousandeyes.com/) — Giám sát mạng và trải nghiệm người dùng. 3 vị trí và 20 nguồn cấp dữ liệu dịch vụ web lớn miễn phí
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — Giám sát miễn phí cho 5 website, khoảng thời gian 60 giây, trang trạng thái công khai.
  * [zenduty.com](https://www.zenduty.com/) — Nền tảng quản lý sự cố đầu-cuối, cảnh báo, trực ca và điều phối phản hồi cho đội ngũ vận hành mạng, SRE và DevOps. Miễn phí cho tối đa 5 người dùng.
  * [instatus.com](https://instatus.com) - Tạo trang trạng thái đẹp trong 10 giây. Miễn phí vĩnh viễn với không giới hạn người đăng ký và không giới hạn nhóm.
  * [Squadcast.com](https://squadcast.com) - Squadcast là phần mềm quản lý sự cố đầu-cuối giúp bạn thúc đẩy thực hành SRE tốt nhất. Gói miễn phí vĩnh viễn cho tối đa 10 người dùng.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri là công cụ giám sát uptime ổn định với nhiều loại bộ giám sát: cronjob, từ khóa, website, cổng, ping. 25 kiểm tra uptime với khoảng cách 3 phút miễn phí. Cảnh báo qua cuộc gọi, SMS, Email, và Webhooks.
  * [Better Stack](https://betterstack.com/better-uptime) - Giám sát uptime, quản lý sự cố, lên lịch/cảnh báo trực ca, và trang trạng thái trong một sản phẩm. Gói miễn phí gồm 10 bộ giám sát với tần suất kiểm tra 3 phút và trang trạng thái.
  * [Pulsetic](https://pulsetic.com) - 10 bộ giám sát, 6 tháng lịch sử uptime/log, không giới hạn trang trạng thái, kèm tên miền tùy chỉnh! Miễn phí mãi mãi và cảnh báo email không giới hạn. Không cần thẻ tín dụng.
  * [Wachete](https://www.wachete.com) - giám sát 5 trang, kiểm tra mỗi 24 giờ.
  * [Xitoring.com](https://xitoring.com/) — Giám sát uptime: 20 miễn phí, giám sát máy chủ Linux & Windows: 5 miễn phí, trang trạng thái: 1 miễn phí - Ứng dụng di động, nhiều kênh thông báo, và nhiều hơn nữa!
  * [Servervana](https://servervana.com) - Giám sát uptime nâng cao hỗ trợ dự án và nhóm lớn. Hỗ trợ HTTP, giám sát trình duyệt, DNS, tên miền, trang trạng thái, v.v. Gói miễn phí gồm 10 HTTP monitor, 1 DNS monitor và 1 status page.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Xử lý Crash và Ngoại lệ

* [CatchJS.com](https://catchjs.com/) - Theo dõi lỗi JavaScript với ảnh chụp màn hình và dấu vết nhấp chuột. Miễn phí cho các dự án mã nguồn mở.
* [bugsnag.com](https://www.bugsnag.com/) — Miễn phí cho tối đa 2.000 lỗi/tháng sau khi hết thời gian dùng thử ban đầu
* [elmah.io](https://elmah.io/) — Ghi log lỗi và giám sát thời gian hoạt động cho lập trình viên web. Gói Small Business miễn phí cho dự án mã nguồn mở.
* [Embrace](https://embrace.io/) — Giám sát ứng dụng di động. Miễn phí cho nhóm nhỏ với tối đa 1 triệu phiên người dùng mỗi năm.
* [exceptionless](https://exceptionless.com) — Báo cáo lỗi, tính năng, log thời gian thực và nhiều hơn nữa. Miễn phí cho 3.000 sự kiện mỗi tháng/1 người dùng. Mã nguồn mở và dễ tự host để sử dụng không giới hạn.
* [GlitchTip](https://glitchtip.com/) — Theo dõi lỗi đơn giản, mã nguồn mở. Tương thích với SDK Sentry mã nguồn mở. 1.000 sự kiện/tháng miễn phí, hoặc có thể tự host không giới hạn
* [honeybadger.io](https://www.honeybadger.io) - Theo dõi ngoại lệ, thời gian hoạt động và cron. Miễn phí cho nhóm nhỏ và dự án mã nguồn mở (12.000 lỗi/tháng).
* [memfault.com](https://memfault.com) — Nền tảng quan sát thiết bị và gỡ lỗi trên đám mây. 100 thiết bị miễn phí cho thiết bị [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp), và [Laird](https://app.memfault.com/register-laird).
* [rollbar.com](https://rollbar.com/) — Theo dõi ngoại lệ và lỗi, gói miễn phí với 5.000 lỗi/tháng, không giới hạn người dùng, lưu trữ 30 ngày
* [sentry.io](https://sentry.io/) — Sentry theo dõi ngoại lệ ứng dụng theo thời gian thực và có gói miễn phí nhỏ. Miễn phí cho 5.000 lỗi/tháng/1 người dùng, sử dụng không giới hạn nếu tự host
* [Axiom](https://axiom.co/) — Lưu trữ tối đa 0,5 TB log với thời gian lưu trữ 30 ngày. Bao gồm tích hợp với các nền tảng như Vercel và truy vấn dữ liệu nâng cao với thông báo qua email/Discord.
* [Semaphr](https://semaphr.com) — Kill switch miễn phí tất cả trong một cho các ứng dụng di động của bạn.
* [Jam](https://jam.dev) - Báo cáo lỗi thân thiện với lập trình viên chỉ với một cú nhấp chuột. Gói miễn phí với số lượng jam không giới hạn.
* [Whitespace](https://whitespace.dev) – Báo cáo lỗi chỉ với một cú nhấp chuột ngay trong trình duyệt. Gói miễn phí với số lần ghi không giới hạn cho mục đích cá nhân.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Tìm kiếm

* [algolia.com](https://www.algolia.com/) — Giải pháp tìm kiếm được lưu trữ với khả năng chịu lỗi chính tả, mức độ liên quan và thư viện UI để dễ dàng tạo trải nghiệm tìm kiếm. Gói miễn phí "Build" bao gồm 1 triệu tài liệu và 10.000 tìm kiếm/tháng. Cũng cung cấp [tìm kiếm tài liệu cho lập trình viên](https://docsearch.algolia.com/) miễn phí.
* [bonsai.io](https://bonsai.io/) — Miễn phí 1 GB bộ nhớ và 1 GB lưu trữ
* [CommandBar](https://www.commandbar.com/) - Thanh tìm kiếm hợp nhất dưới dạng dịch vụ, widget/plugin giao diện web giúp người dùng tìm kiếm nội dung, điều hướng, tính năng... trong sản phẩm của bạn, giúp tăng khả năng khám phá. Miễn phí cho tối đa 1.000 người dùng hoạt động hàng tháng, không giới hạn lệnh.
* [Orama Cloud](https://orama.com/pricing) — Miễn phí 3 chỉ mục, 100.000 tài liệu/chỉ mục, tìm kiếm toàn văn/vector/hybrid không giới hạn, phân tích 60 ngày
* [searchly.com](http://www.searchly.com/) — Miễn phí 2 chỉ mục và 20 MB lưu trữ
* [easysitesearch.com](https://easysitesearch.com/) — Widget và API tìm kiếm, tự động lập chỉ mục dựa trên web-crawler. Tìm kiếm không giới hạn miễn phí, tối đa 50 trang con.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Giáo dục và Phát triển Nghề nghiệp

* [FreeCodeCamp](https://www.freecodecamp.org/) - Nền tảng mã nguồn mở cung cấp các khóa học và chứng chỉ miễn phí về Phân tích Dữ liệu, An ninh Thông tin, Phát triển Web, và nhiều lĩnh vực khác.
* [The Odin Project](https://www.theodinproject.com/) - Nền tảng mã nguồn mở miễn phí với chương trình học tập trung vào JavaScript và Ruby cho phát triển web.
* [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - Nền tảng miễn phí với nhiều mẫu CV chuyên nghiệp, có thể sao chép, chỉnh sửa hoàn toàn và tải về, tối ưu cho ATS.
* [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - Các khóa học ngắn miễn phí từ chuyên gia đầu ngành, thực hành với công cụ và kỹ thuật AI thế hệ mới chỉ trong dưới một giờ.
* [LabEx](https://labex.io) - Phát triển kỹ năng về Linux, DevOps, An ninh mạng, Lập trình, Khoa học Dữ liệu và nhiều hơn nữa qua các phòng lab tương tác và dự án thực tế.
* [Roadmap.sh](https://roadmap.sh) - Các lộ trình học miễn phí bao quát mọi khía cạnh của phát triển phần mềm, từ Blockchain đến Thiết kế UX.
* [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - Cung cấp các khóa học miễn phí theo chuẩn chứng chỉ về các chủ đề như an ninh mạng, mạng máy tính và Python.
* [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare là kho tài liệu trực tuyến từ hơn 2.500 khóa học của MIT, chia sẻ kiến thức miễn phí cho người học và giáo viên toàn cầu. Kênh Youtube: [@mitocw](https://www.youtube.com/@mitocw/featured)
* [W3Schools](https://www.w3schools.com/) - Cung cấp các hướng dẫn miễn phí về công nghệ phát triển web như HTML, CSS, JavaScript, v.v.
* [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - Hướng dẫn trực tuyến miễn phí để học HTML/CSS, JavaScript và SQL từ cơ bản đến nâng cao.
* [Full Stack Open](https://fullstackopen.com/en/) – Khóa học trình độ đại học miễn phí về phát triển web hiện đại với React, Node.js, GraphQL, TypeScript và nhiều hơn nữa. Hoàn toàn trực tuyến và tự học.
* [edX](https://www.edx.org/) - Truy cập hơn 4.000 khóa học trực tuyến miễn phí từ 250 trường đại học hàng đầu, bao gồm Harvard và MIT, chuyên về khoa học máy tính, kỹ thuật và khoa học dữ liệu.
* [Django-tutorial.dev](https://django-tutorial.dev) - Hướng dẫn miễn phí trực tuyến để học Django như framework đầu tiên và tặng backlink dofollow miễn phí cho bài viết của người dùng.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Email

* [10minutemail](https://10minutemail.com) - Email tạm thời miễn phí để kiểm thử.
* [AhaSend](https://ahasend.com) - Dịch vụ email giao dịch, miễn phí 1.000 email mỗi tháng, không giới hạn tên miền, thành viên nhóm, webhook và route tin nhắn trong gói miễn phí.
* [AnonAddy](https://anonaddy.com) - Chuyển tiếp email ẩn danh mã nguồn mở, tạo không giới hạn bí danh email miễn phí
* [Antideo](https://www.antideo.com/) — 10 yêu cầu API mỗi giờ để xác thực email, IP và số điện thoại trong gói miễn phí. Không yêu cầu thẻ tín dụng.
* [Brevo](https://www.brevo.com/) — 9.000 email/tháng, 300 email/ngày miễn phí
* [OneSignal](https://onesignal.com/) — 10.000 email/tháng, không yêu cầu thẻ tín dụng.
* [Bump](https://bump.email/) - Miễn phí 10 địa chỉ email Bump, một tên miền tùy chỉnh
* [Burnermail](https://burnermail.io/) – Miễn phí 5 địa chỉ email Burner, 1 hộp thư, lịch sử hộp thư 7 ngày
* [Buttondown](https://buttondown.email/) — Dịch vụ bản tin. Tối đa 100 người đăng ký miễn phí
* [CloudMailin](https://www.cloudmailin.com/) - Nhận email qua HTTP POST và gửi email giao dịch - 10.000 email miễn phí/tháng
* [Contact.do](https://contact.do/) — Mẫu liên hệ trong một liên kết (bitly cho mẫu liên hệ)
* [debugmail.io](https://debugmail.io/) — Máy chủ mail kiểm thử dễ dùng cho lập trình viên
* [DNSExit](https://dnsexit.com/) - Tối đa 2 địa chỉ email dưới tên miền riêng miễn phí với 100MB lưu trữ. Hỗ trợ IMAP, POP3, SMTP, SPF/DKIM.
* [EmailLabs.io](https://emaillabs.io/en) — Gửi tới 9.000 email miễn phí mỗi tháng, tối đa 300 email mỗi ngày.
* [EmailOctopus](https://emailoctopus.com) - Tối đa 2.500 người đăng ký và 10.000 email mỗi tháng miễn phí
* [EmailJS](https://www.emailjs.com/) – Không phải máy chủ email hoàn chỉnh; chỉ là client gửi email trực tiếp từ client mà không lộ thông tin đăng nhập, gói miễn phí có 200 yêu cầu/tháng, 2 mẫu email, dung lượng yêu cầu tối đa 50Kb, lịch sử liên hệ giới hạn.
* [EtherealMail](https://ethereal.email) - Ethereal là dịch vụ SMTP giả, chủ yếu dành cho người dùng Nodemailer và EmailEngine (nhưng không giới hạn). Đây là dịch vụ email chống giao dịch hoàn toàn miễn phí, thư sẽ không được gửi đi.
* [Temp-Mail.org](https://temp-mail.org/en/) - Tạo mail tạm thời/giả danh sử dụng nhiều tên miền khác nhau. Địa chỉ email tự động làm mới mỗi lần tải lại trang. Dịch vụ hoàn toàn miễn phí.
* [TempMailDetector.com](https://tempmaildetector.com/) - Xác minh tối đa 200 email mỗi tháng miễn phí để kiểm tra email tạm thời hay không.
* [Emailvalidation.io](https://emailvalidation.io) - 100 xác thực email miễn phí mỗi tháng
* [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - Dịch vụ tạo mail tạm thời/giả danh của Đức. Hỗ trợ 10 tên miền, tạo số lượng địa chỉ không giới hạn. (có quảng cáo) nhưng ngoài ra hoàn toàn miễn phí.
* [forwardemail.net](https://forwardemail.net) — Chuyển tiếp email miễn phí cho tên miền tùy chỉnh. Tạo và chuyển tiếp không giới hạn địa chỉ email với tên miền của bạn (**lưu ý**: Phải trả phí nếu dùng TLD .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work do spam)
* [Imitate Email](https://imitate.email) - Máy chủ email sandbox để kiểm thử chức năng email trong build/qa và ci/cd. Tài khoản miễn phí nhận 15 email mỗi ngày mãi mãi.
* [ImprovMX](https://improvmx.com) – Chuyển tiếp email miễn phí.
* [EForw](https://www.eforw.com) – Chuyển tiếp email miễn phí cho một tên miền. Nhận và gửi email từ tên miền của bạn.
* [Inboxes App](https://inboxesapp.com) — Tạo tối đa 3 email tạm thời mỗi ngày, sau đó xóa chúng khi xong qua tiện ích mở rộng Chrome tiện lợi. Hoàn hảo cho kiểm thử quy trình đăng ký.
* [inboxkitten.com](https://inboxkitten.com/) - Hộp thư email tạm thời/giả danh miễn phí, tự động xóa email sau tối đa 3 ngày. Mã nguồn mở và có thể tự host.
* [mail-tester.com](https://www.mail-tester.com/) — Kiểm tra cấu hình DNS/SPF/DKIM/DMARC của email đúng hay không, miễn phí 20 lần/tháng.
* [dkimvalidator.com](https://dkimvalidator.com/) - Kiểm tra cấu hình DNS/SPF/DKIM/DMARC của email, dịch vụ miễn phí bởi roundsphere.com
* [mailcatcher.me](https://mailcatcher.me/) — Thu nhận thư và cung cấp qua giao diện web.
* [mailchannels.com](https://www.mailchannels.com) - Email API với REST API và tích hợp SMTP, miễn phí tối đa 3.000 email/tháng.
* [Mailcheck.ai](https://www.mailcheck.ai/) - Ngăn người dùng đăng ký bằng email tạm thời, 120 yêu cầu/giờ (~86.400/tháng)
* [Mailchimp](https://mailchimp.com/) — 500 người đăng ký và 1.000 email/tháng miễn phí.
* [Maildroppa](https://maildroppa.com) - Tối đa 100 người đăng ký và số lượng email không giới hạn cũng như tự động hóa miễn phí.
* [MailerLite.com](https://www.mailerlite.com) — 1.000 người đăng ký/tháng, 12.000 email/tháng miễn phí
* [MailerSend.com](https://www.mailersend.com) — Email API, SMTP, 3.000 email/tháng miễn phí cho email giao dịch
* [mailinator.com](https://www.mailinator.com/) — Hệ thống email công cộng miễn phí, có thể dùng bất kỳ hộp thư nào bạn muốn
* [Mailjet](https://www.mailjet.com/) — 6.000 email/tháng miễn phí (giới hạn gửi 200 email/ngày)
* [Mailnesia](https://mailnesia.com) - Email tạm thời/giả danh miễn phí, tự động truy cập link xác nhận đăng ký.
* [mailsac.com](https://mailsac.com) - API miễn phí kiểm thử email tạm thời, lưu trữ email công cộng miễn phí, bắt email gửi đi, email-to-slack/websocket/webhook (giới hạn 1.500 API/tháng)
* [Mailtrap.io](https://mailtrap.io/) — Máy chủ SMTP giả cho phát triển, gói miễn phí với một hộp thư, 100 tin nhắn, không thành viên nhóm, hai email/giây, không có quy tắc chuyển tiếp.
* [Mail7.io](https://www.mail7.io/) — Địa chỉ email tạm thời miễn phí cho lập trình viên QA. Tạo email tức thì qua giao diện web hoặc API.
* [Momentary Email](https://www.momentaryemail.com/) — Địa chỉ email tạm thời miễn phí. Đọc thư trực tiếp trên web hoặc bằng RSS feed.
* [Mutant Mail](https://www.mutantmail.com/) – Miễn phí 10 ID email, 1 tên miền, 1 hộp thư. Một hộp thư cho tất cả ID email.
* [Outlook.com](https://outlook.live.com/owa/) - Dịch vụ email cá nhân và lịch miễn phí.
* [Parsio.io](https://parsio.io) — Trình phân tích email miễn phí (chuyển tiếp email, trích xuất dữ liệu, gửi đến máy chủ của bạn)
* [pepipost.com](https://pepipost.com) — 30.000 email miễn phí tháng đầu, sau đó miễn phí 100 email/ngày.
* [Plunk](https://useplunk.com) - 3.000 email/tháng miễn phí
* [Postmark](https://postmarkapp.com/) - 100 email/tháng miễn phí, thống kê DMARC hàng tuần không giới hạn.
* [Proton Mail](https://proton.me/mail) -  Dịch vụ email bảo mật miễn phí với mã hóa end-to-end tích hợp. Miễn phí 1GB lưu trữ.
* [Queuemail.dev](https://queuemail.dev) — API gửi email đáng tin cậy. Gói miễn phí (10.000 email/tháng). Gửi không đồng bộ. Sử dụng nhiều máy chủ SMTP. Danh sách chặn, ghi log, theo dõi, webhook, v.v.
* [QuickEmailVerification](https://quickemailverification.com) — Xác thực miễn phí 100 email mỗi ngày trên gói miễn phí cùng các API miễn phí khác như DEA Detector, DNS Lookup, SPF Detector, v.v.
  * [Resend](https://resend.com) - API gửi email giao dịch cho nhà phát triển. Miễn phí 3.000 email/tháng, 100 email/ngày, một tên miền tùy chỉnh.
  * [Sender](https://www.sender.net) Lên đến 15.000 email/tháng, tối đa 2.500 người đăng ký.
  * [Sendpulse](https://sendpulse.com) — 500 người đăng ký/tháng, 15.000 email/tháng miễn phí.
  * [SimpleLogin](https://simplelogin.io/) – Giải pháp mã nguồn mở, tự lưu trữ tạo bí danh/chuyển tiếp email. Miễn phí 5 bí danh, băng thông không giới hạn, trả lời/gửi không giới hạn. Miễn phí cho nhân viên giáo dục (sinh viên, nhà nghiên cứu, v.v.).
  * [Substack](https://substack.com) — Dịch vụ bản tin không giới hạn miễn phí. Bắt đầu tính phí khi bạn thu phí người đọc.
  * [Sweego](https://www.sweego.io/) - API email giao dịch của Châu Âu cho lập trình viên. Miễn phí 500 email/ngày.
  * [Takeout](https://takeout.bysourfruit.com) - Dịch vụ email cập nhật liên tục giúp gửi email dễ dàng. Năm trăm email giao dịch/tháng miễn phí.
  * [temp-mail.io](https://temp-mail.io) — Dịch vụ email tạm thời dùng một lần miễn phí, cho phép tạo nhiều email cùng lúc và chuyển tiếp.
  * [tinyletter.com](https://tinyletter.com/) — 5.000 người đăng ký/tháng miễn phí.
  * [Touchlead](https://touchlead.app) - Công cụ tự động hóa marketing đa năng, quản lý khách hàng tiềm năng, tạo biểu mẫu và tự động hóa. Miễn phí với số lượng khách hàng tiềm năng và quy trình tự động hóa giới hạn.
  * [trashmail.com](https://www.trashmail.com) - Địa chỉ email dùng một lần miễn phí với chức năng chuyển tiếp và tự động hết hạn địa chỉ.
  * [Tuta](https://tuta.com/) - Dịch vụ email bảo mật miễn phí với mã hóa đầu-cuối, không quảng cáo, không theo dõi. Miễn phí 1GB lưu trữ, một lịch (Tuta cũng có [gói trả phí](https://tuta.com/pricing)). Tuta cũng [mã nguồn mở một phần](https://github.com/tutao/tutanota), bạn có thể tự lưu trữ.
  * [Verifalia](https://verifalia.com/email-verification-api) — API kiểm tra email thời gian thực với xác nhận hộp thư và phát hiện email tạm thời; 25 lần kiểm tra miễn phí/ngày.
  * [verimail.io](https://verimail.io/) — Dịch vụ kiểm tra email hàng loạt và qua API. 100 lần kiểm tra miễn phí/tháng.
  * [Zoho](https://www.zoho.com) — Bắt đầu là nhà cung cấp email, nay cung cấp bộ dịch vụ, một số có gói miễn phí. Danh sách dịch vụ có gói miễn phí:
     - [Email](https://zoho.com/mail) Miễn phí cho 5 người dùng. 5GB/người dùng & giới hạn tệp đính kèm 25MB, một tên miền.
     - [Zoho Assist](https://www.zoho.com/assist) — Gói miễn phí vĩnh viễn bao gồm một giấy phép hỗ trợ từ xa đồng thời và truy cập 5 máy tính không giám sát không giới hạn thời gian, áp dụng cho cả cá nhân và chuyên nghiệp.
     - [Sprints](https://zoho.com/sprints) Miễn phí cho 5 người dùng, 5 dự án & 500MB lưu trữ.
     - [Docs](https://zoho.com/docs) — Miễn phí cho 5 người dùng, giới hạn tải lên 1GB & 5GB lưu trữ. Bộ Zoho Office Suite (Writer, Sheets & Show) đi kèm.
     - [Projects](https://zoho.com/projects) — Miễn phí cho 3 người dùng, 2 dự án & giới hạn tệp đính kèm 10MB. Áp dụng tương tự cho [Bugtracker](https://zoho.com/bugtracker).
     - [Connect](https://zoho.com/connect) — Hợp tác nhóm miễn phí cho 25 người dùng với 3 nhóm, 3 ứng dụng tùy chỉnh, 3 bảng, 3 tài liệu hướng dẫn và 10 tích hợp cùng kênh, sự kiện & diễn đàn.
     - [Meeting](https://zoho.com/meeting) — Họp với tối đa 3 người tham gia & 10 người dự hội thảo trực tuyến.
     - [Vault](https://zoho.com/vault) — Quản lý mật khẩu cho cá nhân.
     - [Showtime](https://zoho.com/showtime) — Phần mềm họp trực tuyến cho đào tạo, tối đa 5 người tham dự.
     - [Notebook](https://zoho.com/notebook) — Giải pháp thay thế miễn phí cho Evernote.
     - [Wiki](https://zoho.com/wiki) — Miễn phí cho 3 người dùng với 50MB lưu trữ, số trang không giới hạn, sao lưu zip, RSS & Atom, kiểm soát truy cập & CSS tùy chỉnh.
     - [Subscriptions](https://zoho.com/subscriptions) — Quản lý thu phí định kỳ miễn phí cho 20 khách hàng/đăng ký & 1 người dùng, tất cả thanh toán được Zoho lưu trữ. 40 chỉ số đăng ký gần nhất được lưu.
     - [Checkout](https://zoho.com/checkout) — Quản lý thanh toán sản phẩm với 3 trang & tối đa 50 thanh toán.
     - [Desk](https://zoho.com/desk) — Quản lý hỗ trợ khách hàng với 3 nhân viên, kho tri thức riêng, ticket qua email. Tích hợp với [Assist](https://zoho.com/assist) cho 1 kỹ thuật viên từ xa & 5 máy tính không giám sát.
     - [Cliq](https://zoho.com/cliq) — Phần mềm chat nhóm với 100GB lưu trữ, người dùng không giới hạn, 100 người/kênh & SSO.
     - [Campaigns](https://zoho.com/campaigns) - Email Marketing
     - [Forms](https://zoho.com/forms) - Tạo biểu mẫu
     - [Sign](https://zoho.com/sign) - Chữ ký số
     - [Surveys](https://zoho.com/surveys) - Khảo sát trực tuyến
     - [Bookings](https://zoho.com/bookings) - Đặt lịch hẹn
  * [Maileroo](https://maileroo.com) - SMTP relay và API email cho lập trình viên. 5.000 email mỗi tháng, không giới hạn tên miền, kiểm tra email miễn phí, giám sát blacklist, kiểm tra mail và nhiều tính năng khác.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Nền tảng Quản lý Feature Toggles

  * [ConfigCat](https://configcat.com) - ConfigCat là dịch vụ feature flag dành cho lập trình viên với số lượng thành viên nhóm không giới hạn, hỗ trợ xuất sắc và giá hợp lý. Gói miễn phí cho phép tối đa 10 cờ, 2 môi trường, 1 sản phẩm và 5 triệu yêu cầu/tháng.
  * [Flagsmith](https://flagsmith.com) - Phát hành tính năng tự tin; quản lý feature flag trên web, di động và ứng dụng máy chủ. Có thể dùng API của chúng tôi, triển khai lên cloud riêng hoặc chạy on-premise.
  * [GrowthBook](https://growthbook.io) - Nhà cung cấp feature flag và A/B testing mã nguồn mở với engine phân tích thống kê Bayesian tích hợp. Miễn phí cho tối đa 3 người dùng, số lượng feature flag và thí nghiệm không giới hạn.
  * [Hypertune](https://www.hypertune.com) - Feature flag type-safe, A/B testing, phân tích và cấu hình ứng dụng, với kiểm soát phiên bản kiểu Git và đánh giá cờ cục bộ, đồng bộ, trong bộ nhớ. Miễn phí cho tối đa 5 thành viên nhóm, không giới hạn feature flag và test A/B.
  * [Molasses](https://www.molasses.app) - Feature flag mạnh mẽ và A/B testing. Miễn phí tối đa 3 môi trường với 5 feature flag mỗi môi trường.
  * [Toggled.dev](https://www.toggled.dev) - Nền tảng quản lý feature toggles sẵn sàng cho doanh nghiệp, mở rộng đa vùng. Gói miễn phí cho tối đa 10 cờ, 2 môi trường, số lượng yêu cầu không giới hạn. SDK, dashboard phân tích, lịch phát hành, thông báo Slack và tất cả tính năng khác đều có trong gói miễn phí không giới hạn.
  * [Statsig](https://www.statsig.com) - Nền tảng mạnh mẽ cho quản lý feature, A/B testing, phân tích và nhiều hơn nữa. Gói miễn phí hào phóng với số lượng chỗ ngồi, cờ, thử nghiệm và cấu hình động không giới hạn, hỗ trợ đến 1 triệu sự kiện/tháng.
  * [Abby](https://www.tryabby.com) - Feature flag & A/B testing mã nguồn mở. Cấu hình dạng mã & SDK Typescript đầy đủ kiểu. Tích hợp mạnh với các Framework như Next.js & React. Gói miễn phí hào phóng và các lựa chọn mở rộng giá rẻ.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Font

  * [dafont](https://www.dafont.com/) - Các font trên trang này thuộc sở hữu của tác giả và có thể là phần mềm miễn phí, shareware, bản demo hoặc thuộc phạm vi công cộng.
  * [Everything Fonts](https://everythingfonts.com/) - Cung cấp nhiều công cụ: @font-face, Bộ chuyển đổi đơn vị, Font Hinter và Font Submitter.
  * [Font Squirrel](https://www.fontsquirrel.com/) - Font miễn phí được cấp phép cho mục đích thương mại. Được chọn lọc và trình bày dễ sử dụng.
  * [Google Fonts](https://fonts.google.com/) - Nhiều font miễn phí, dễ dàng và nhanh chóng cài đặt lên website qua tải xuống hoặc liên kết đến CDN của Google.
  * [FontGet](https://www.fontget.com/) - Có nhiều loại font để tải về, được phân loại gọn gàng theo tag.
  * [Fontshare](https://www.fontshare.com/) - Dịch vụ font miễn phí. Bộ sưu tập font chuyên nghiệp ngày càng phát triển, 100% miễn phí cho cá nhân và thương mại.
  * [Befonts](https://befonts.com/) - Cung cấp nhiều font độc đáo cho mục đích cá nhân hoặc thương mại.
  * [Font of web](https://fontofweb.com/) - Nhận diện tất cả các font được sử dụng trên một website và cách chúng được sử dụng.
  * [Bunny](https://fonts.bunny.net) Google Fonts hướng đến quyền riêng tư.
  * [FontsKey](https://www.fontskey.com/) - Cung cấp font miễn phí và font trả phí thương mại cho mục đích cá nhân, có thể nhập văn bản để lọc nhanh.
  * [fonts.xz.style](https://fonts.xz.style/) dịch vụ miễn phí và mã nguồn mở để phân phối bộ font cho website bằng CSS.
  * [Fontsensei](https://fontsensei.com/) Google fonts mã nguồn mở được gắn tag bởi người dùng. Có tag font CJK (Trung, Nhật, Hàn).

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Biểu mẫu

  * [Feathery](https://feathery.io) - Trình tạo form mạnh mẽ, thân thiện với lập trình viên. Tạo đăng ký & đăng nhập, onboarding người dùng, thanh toán, ứng dụng tài chính phức tạp, v.v. Gói miễn phí cho tối đa 250 lượt gửi/tháng và 5 form hoạt động.
  * [Form-Data](https://form-data.com) - Backend form không cần code. Lọc spam, thông báo email & trả lời tự động, webhook, zapier, chuyển hướng, AJAX hoặc POST, v.v. Gói miễn phí cho số form không giới hạn, 20 lượt gửi/tháng và thêm 2000 lượt gửi với badge Form-Data.
  * [FabForm](https://fabform.io/) - Nền tảng backend cho form dành cho lập trình viên thông minh. Gói miễn phí cho 250 lượt gửi mỗi tháng. Giao diện hiện đại thân thiện. Tích hợp Google Sheets, Airtable, Slack, Email và nhiều hơn nữa.
  * [Form.taxi](https://form.taxi/) — Endpoint cho gửi form HTML. Có thông báo, chống spam và xử lý dữ liệu tuân thủ GDPR. Gói miễn phí cho nhu cầu cơ bản.
  * [Formcarry.com](https://formcarry.com) - Endpoint HTTP POST cho Form, gói miễn phí cho 100 lượt gửi mỗi tháng.
  * [formingo.co](https://www.formingo.co/) - Biểu mẫu HTML dễ dàng cho website tĩnh. Có thể bắt đầu miễn phí mà không cần đăng ký tài khoản. Gói miễn phí cho 500 lượt gửi mỗi tháng và email trả lời tùy chỉnh.
  * [FormKeep.com](https://www.formkeep.com/) - Form không giới hạn với 50 lượt gửi/tháng, bảo vệ spam, thông báo email, trình thiết kế kéo-thả có thể xuất HTML. Tính năng bổ sung: quy tắc trường tùy chỉnh, nhóm, tích hợp Google Sheets, Slack, ActiveCampaign và Zapier.
  * [formlets.com](https://formlets.com/) — Biểu mẫu trực tuyến, số biểu mẫu một trang không giới hạn/tháng, 100 lượt gửi/tháng, thông báo email.
  * [formspark.io](https://formspark.io/) - Dịch vụ gửi form đến email, gói miễn phí cho số form không giới hạn, 250 lượt gửi/tháng, hỗ trợ bởi đội ngũ chăm sóc khách hàng.
  * [Formspree.io](https://formspree.io/) — Gửi email bằng HTTP POST request. Gói miễn phí giới hạn 50 lượt gửi mỗi form/tháng.
  * [Formsubmit.co](https://formsubmit.co/) — Endpoint form dễ dàng cho HTML forms. Miễn phí vĩnh viễn. Không cần đăng ký.
  * [Formlick.com](https://formlick.com) - Thay thế Typeform với deal trọn đời. Người dùng có thể tạo 1 form miễn phí và nhận lượt gửi không giới hạn. Gói premium: form không giới hạn, lượt gửi không giới hạn.
  * [getform.io](https://getform.io/) - Nền tảng backend cho form dành cho designer và developer, 1 form, 50 lượt gửi, tải lên một tệp, 100MB lưu trữ.
  * [HeroTofu.com](https://herotofu.com/) - Backend form với phát hiện bot và lưu trữ mã hóa. Chuyển tiếp gửi qua UI đến email, Slack hoặc Zapier. Dùng front-end riêng. Không cần code phía server. Gói miễn phí cho số form không giới hạn, 100 lượt gửi/tháng.
  * [HeyForm.net](https://heyform.net/) - Trình tạo form kéo thả trực tuyến. Gói miễn phí cho phép tạo số form và nhận lượt gửi không giới hạn. Có template dựng sẵn, chống spam, 100MB lưu trữ.
  * [Tally.so](https://tally.so/) - 99% tính năng đều miễn phí. Gói miễn phí: form không giới hạn, lượt gửi không giới hạn, thông báo email, logic form, thu tiền, tải file, trang cảm ơn tùy chỉnh và nhiều hơn nữa.
  * [Hyperforms.app](https://hyperforms.app/) — Tạo form gửi email và nhiều hơn nữa chỉ trong vài giây, không cần code backend. Tài khoản cá nhân được miễn phí 50 lượt gửi mỗi tháng.
  * [Kwes.io](https://kwes.io/) - Endpoint form nhiều tính năng. Hoạt động tốt với website tĩnh. Gói miễn phí cho tối đa 1 website và 50 lượt gửi/tháng.
  * [Pageclip](https://pageclip.co/) - Gói miễn phí cho phép 1 website, 1 form, 1.000 lượt gửi/tháng.
  * [Qualtrics Survey](https://qualtrics.com/free-account) — Tạo form & khảo sát chuyên nghiệp với công cụ đẳng cấp. 50+ mẫu khảo sát thiết kế bởi chuyên gia. Miễn phí 1 khảo sát hoạt động, 100 phản hồi/khảo sát & 8 loại phản hồi.
  * [Screeb](https://screeb.app/) - Khảo sát trong ứng dụng và phân tích sản phẩm để giải mã hành vi người dùng. Gói miễn phí vĩnh viễn cho 500 người dùng hoạt động/tháng, số phản hồi & sự kiện không giới hạn, nhiều tích hợp, xuất dữ liệu và báo cáo định kỳ.
  * [smartforms.dev](https://smartforms.dev/) - Backend form mạnh mẽ và dễ sử dụng cho website, gói miễn phí vĩnh viễn cho 50 lượt gửi/tháng, 250MB lưu trữ, tích hợp Zapier, xuất CSV/JSON, chuyển hướng tùy chỉnh, trang phản hồi tùy chỉnh, bot Telegram & Slack, thông báo email đơn.
  * [Survicate](https://survicate.com/) — Thu thập phản hồi từ mọi nguồn và gửi khảo sát tiếp theo chỉ với một công cụ. Phân tích phản hồi tự động và trích xuất insight bằng AI. Khảo sát miễn phí qua email, website, trong sản phẩm hoặc app di động, tạo khảo sát AI, 25 phản hồi/tháng.
  * [staticforms.xyz](https://www.staticforms.xyz/) - Tích hợp HTML form dễ dàng mà không cần code phía server. Sau khi gửi form, một email chứa nội dung form sẽ được gửi đến địa chỉ đã đăng ký.
  * [stepFORM.io](https://stepform.io) - Trình tạo Quiz và Form. Gói miễn phí có 5 form, tối đa 3 bước mỗi form và 50 phản hồi/tháng.
  * [Typeform.com](https://www.typeform.com/) — Thêm form thiết kế đẹp lên website. Gói miễn phí chỉ cho 10 trường mỗi form và 100 phản hồi/tháng.
  * [WaiverStevie.com](https://waiverstevie.com) - Nền tảng chữ ký điện tử với REST API. Nhận thông báo qua webhook. Gói miễn phí đóng dấu tài liệu đã ký nhưng cho phép số lượng phong bì + chữ ký không giới hạn.
  * [Web3Forms](https://web3forms.com) - Biểu mẫu liên hệ cho website tĩnh & JAMStack không cần code backend. Gói miễn phí: Số form không giới hạn, số miền không giới hạn & 250 lượt gửi/tháng.
* [WebAsk](https://webask.io) - Công cụ tạo khảo sát và biểu mẫu. Gói miễn phí cho phép tạo ba khảo sát trên mỗi tài khoản, 100 phản hồi hàng tháng và mười thành phần trên mỗi khảo sát.
* [Wufoo](https://www.wufoo.com/) - Biểu mẫu nhanh để sử dụng trên các trang web. Gói miễn phí giới hạn 100 lần gửi mỗi tháng.
* [formpost.app](https://formpost.app) - Dịch vụ Form to Email miễn phí, không giới hạn. Thiết lập chuyển hướng tùy chỉnh, tự động trả lời, webhook, v.v. hoàn toàn miễn phí.
* [Formester.com](https://formester.com) - Chia sẻ và nhúng các biểu mẫu với giao diện độc đáo lên trang web của bạn—không giới hạn số lượng biểu mẫu tạo ra hoặc tính năng bị giới hạn bởi gói. Nhận tối đa 100 lượt gửi mỗi tháng miễn phí.
* [SimplePDF.eu](https://simplepdf.eu/embed) - Nhúng trình chỉnh sửa PDF vào trang web của bạn và biến bất kỳ tệp PDF nào thành biểu mẫu có thể điền. Gói miễn phí cho phép tạo PDF không giới hạn với ba lượt gửi trên mỗi PDF.
* [forms.app](https://forms.app/) — Tạo biểu mẫu trực tuyến với các tính năng mạnh mẽ như logic điều kiện, tính điểm tự động và AI. Thu thập tối đa 100 phản hồi với gói miễn phí, nhúng biểu mẫu vào trang web hoặc sử dụng qua liên kết.
* [Qualli](https://usequalli.com) - Khảo sát trong ứng dụng, thiết kế dành cho thiết bị di động. Sử dụng Qualli AI để soạn thảo câu hỏi hoàn hảo. Bạn có thể trải nghiệm miễn phí với tối đa 500 MAU, tạo không giới hạn biểu mẫu và trình kích hoạt.
* [Sprig](https://sprig.com/) - 1 khảo sát trong sản phẩm hoặc khảo sát với tính năng phát lại mỗi tháng, với phân tích AI sử dụng GPT.
* [feedback.fish](https://feedback.fish/) - Gói miễn phí cho phép thu thập 25 phản hồi. Dễ dàng tích hợp với React và Vue thông qua các thành phần được cung cấp.
* [Vidhook](https://vidhook.io/) - Thu thập phản hồi thông qua khảo sát thú vị với tỷ lệ phản hồi cao. Gói miễn phí bao gồm 1 khảo sát đang hoạt động, 25 phản hồi trên mỗi khảo sát và mẫu tùy chỉnh.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Generative AI

* [Zenable](https://zenable.io) - Tự động sửa đầu ra từ các công cụ như Cursor, Windsurf, và Copilot để đáp ứng các tiêu chuẩn chất lượng và tuân thủ của công ty bạn bằng guardrails được xây dựng với Policy as Code. Gói miễn phí bao gồm 100 lượt gọi công cụ mỗi ngày tới máy chủ MCP và 25 lượt review pull request tự động miễn phí mỗi ngày qua GitHub App.
* [Keywords AI](https://keywordsai.co) - Nền tảng giám sát LLM tốt nhất. Một định dạng để gọi hơn 200+ LLM chỉ với 2 dòng mã. 10.000 lượt yêu cầu miễn phí mỗi tháng và $0 cho các tính năng nền tảng!
* [Portkey](https://portkey.ai/) - Bảng điều khiển cho các ứng dụng Gen AI với bộ công cụ quan sát & cổng AI. Gửi & ghi lại tới 10.000 yêu cầu miễn phí mỗi tháng.
* [Braintrust](https://www.braintrustdata.com/) - Đánh giá, playground cho prompt, và quản lý dữ liệu cho Gen AI. Gói miễn phí cung cấp tối đa 1.000 dòng đánh giá riêng tư/tuần.
* [Findr](https://www.usefindr.com/) - Tìm kiếm hợp nhất cho phép bạn tìm kiếm tất cả ứng dụng cùng lúc. Trợ lý tìm kiếm giúp bạn trả lời câu hỏi sử dụng thông tin của mình. Gói miễn phí cung cấp tìm kiếm hợp nhất không giới hạn và 5 truy vấn co pilot mỗi ngày.
* [ReportGPT](https://ReportGPT.app) - Trợ lý viết bài sử dụng AI. Toàn bộ nền tảng miễn phí nếu bạn sử dụng khóa API của riêng mình.
* [Clair](https://askclair.ai/) - Tham khảo AI Lâm sàng. Sinh viên được truy cập miễn phí bộ công cụ chuyên nghiệp, bao gồm Open Search, Clinical Summary, Med Review, Drug Interactions, ICD-10 Codes, và Stewardship. Ngoài ra còn có bản dùng thử miễn phí cho bộ công cụ chuyên nghiệp.
* [Langtrace](https://langtrace.ai) - Cho phép lập trình viên truy vết, đánh giá, quản lý prompt và tập dữ liệu, và debug các vấn đề liên quan đến hiệu suất ứng dụng LLM. Tạo các truy vết tiêu chuẩn open telemetry cho mọi LLM, hỗ trợ quan sát và hoạt động với mọi client observability. Gói miễn phí cung cấp 50.000 truy vết/tháng.
* [LangWatch](https://langwatch.ai) - Nền tảng LLMOps giúp các nhóm AI đo lường, giám sát và tối ưu hóa ứng dụng LLM về độ tin cậy, tiết kiệm chi phí và hiệu suất. Thành phần DSPy mạnh mẽ giúp các kỹ sư và nhóm phi kỹ thuật cộng tác tối ưu hóa và sản xuất hóa sản phẩm GenAI. Gói miễn phí bao gồm tất cả tính năng, 1.000 truy vết/tháng và 1 workflow DSPy optimizers. [#opensource](https://github.com/langwatch/langwatch)
* [Comet Opik](https://www.comet.com/site/products/opik/) - Đánh giá, kiểm tra và triển khai ứng dụng LLM xuyên suốt vòng đời phát triển và vận hành. [#opensource](https://github.com/comet-ml/opik/)
* [Langfuse](https://langfuse.com/) - Nền tảng kỹ thuật LLM mã nguồn mở hỗ trợ các nhóm cộng tác debug, phân tích và lặp lại ứng dụng LLM. Gói miễn phí vĩnh viễn bao gồm 50.000 quan sát mỗi tháng và tất cả tính năng. [#opensource](https://github.com/langfuse/langfuse)
* [Pollinations.AI](https://pollinations.ai/) - AI tạo ảnh dễ sử dụng, miễn phí với API miễn phí. Không cần đăng ký hay khóa API, có nhiều tùy chọn tích hợp vào website hoặc quy trình làm việc. [#opensource](https://github.com/pollinations/pollinations)
* [Othor AI](https://othor.ai/) - Giải pháp thông minh kinh doanh AI-native nhanh, đơn giản, và an toàn thay thế Tableau, Power BI, Looker. Sử dụng LLM để cung cấp giải pháp phân tích kinh doanh tùy chỉnh chỉ trong vài phút. Gói Free Forever cung cấp 1 workspace với 5 kết nối datasource cho 1 người dùng, không giới hạn phân tích. [#opensource](https://github.com/othorai/othor.ai)
* [OpenRouter](https://openrouter.ai/models?q=free) - Cung cấp nhiều mô hình AI miễn phí như DeepSeek R1, V3, Llama, và Moonshot AI. Các mô hình này xuất sắc trong xử lý ngôn ngữ tự nhiên và phù hợp với nhiều nhu cầu phát triển khác nhau. Lưu ý, mặc dù miễn phí nhưng các mô hình này bị giới hạn tốc độ truy cập. Ngoài ra, OpenRouter còn có các mô hình trả phí cho nhu cầu nâng cao như Claude, OpenAI, Grok, Gemini, và Nova.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## CDN và Bảo vệ

* [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN cho bootstrap, bootswatch và fontawesome.io
* [cdnjs.com](https://cdnjs.com/) — Đơn giản. Nhanh. Đáng tin cậy. Phân phối nội dung ở mức tốt nhất. cdnjs là dịch vụ CDN miễn phí và mã nguồn mở, được hơn 11% website tin dùng, vận hành bởi Cloudflare.
* [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries là mạng phân phối nội dung cho các thư viện JavaScript mã nguồn mở phổ biến nhất
* [Stellate](https://stellate.co/) - Stellate là CDN cực nhanh, đáng tin cậy cho API GraphQL của bạn và miễn phí cho hai dịch vụ.
* [jsdelivr.com](https://www.jsdelivr.com/) — CDN miễn phí, nhanh và đáng tin cậy, mã nguồn mở. Hỗ trợ npm, GitHub, WordPress, Deno, và nhiều hơn nữa.
* [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Microsoft Ajax CDN lưu trữ các thư viện JavaScript phổ biến như jQuery, giúp bạn dễ dàng thêm vào ứng dụng web của mình
* [ovh.ie](https://www.ovh.ie/ssl-gateway/) — Bảo vệ DDoS và chứng chỉ SSL miễn phí
* [Skypack](https://www.skypack.dev/) — 100% CDN JavaScript Native ES Module. Miễn phí cho 1 triệu yêu cầu trên mỗi tên miền mỗi tháng.
* [raw.githack.com](https://raw.githack.com/) — Thay thế hiện đại cho **rawgit.com**, chỉ đơn giản lưu trữ file sử dụng Cloudflare
* [section.io](https://www.section.io/) — Cách đơn giản để triển khai và quản lý giải pháp Varnish Cache hoàn chỉnh. Được cho là miễn phí vĩnh viễn cho một trang web
* [statically.io](https://statically.io/) — CDN cho repo Git (GitHub, GitLab, Bitbucket), tài nguyên liên quan đến WordPress và hình ảnh
* [toranproxy.com](https://toranproxy.com/) — Proxy cho Packagist và GitHub. Không bao giờ thất bại CD. Miễn phí cho cá nhân, một lập trình viên, không hỗ trợ
* [UNPKG](https://unpkg.com/) — CDN cho mọi thứ trên npm
* [weserv](https://images.weserv.nl/) — Dịch vụ cache & resize hình ảnh. Thao tác hình ảnh trực tiếp với cache toàn cầu.
* [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — Bảo vệ DDoS miễn phí
* [Gcore](https://gcorelabs.com/) Mạng phân phối nội dung toàn cầu, 1 TB và 1 triệu yêu cầu mỗi tháng miễn phí cùng với hosting DNS miễn phí
* [CacheFly](https://portal.cachefly.com/signup/free2023) - Tối đa 5 TB lưu lượng CDN miễn phí/tháng, 19 Core PoPs, 1 Domain và Universal SSL.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## PaaS

* [anvil.works](https://anvil.works) - Phát triển ứng dụng web chỉ với Python. Gói miễn phí với số lượng ứng dụng không giới hạn và timeout 30 giây.
* [appwrite](https://appwrite.io) - Số lượng dự án không giới hạn, không bị tạm dừng dự án (hỗ trợ websockets) và dịch vụ xác thực. 1 Database, 3 Bucket, 5 Function trên mỗi dự án trong gói miễn phí.
* [configure.it](https://www.configure.it/) — Nền tảng phát triển ứng dụng di động, miễn phí cho hai dự án, tính năng hạn chế nhưng không giới hạn tài nguyên
* [codenameone.com](https://www.codenameone.com/) — Bộ công cụ phát triển ứng dụng di động đa nền tảng mã nguồn mở cho Java/Kotlin. Miễn phí sử dụng thương mại với số lượng dự án không giới hạn
* [deco.cx](https://www.deco.cx/en/dev) - Nền tảng frontend native edge với CMS trực quan tự động sinh từ mã TypeScript. Tích hợp sẵn A/B testing, phân khúc nội dung và phân tích thời gian thực. Phù hợp cho các website thương mại điện tử nội dung lớn và doanh nghiệp. Miễn phí tới 5.000 pageview/tháng hoặc dự án mã nguồn mở/cá nhân.
* [Deno Deploy](https://deno.com/deploy) - Hệ thống phân tán chạy JavaScript, TypeScript và WebAssembly tại edge toàn cầu. Gói miễn phí gồm 100.000 yêu cầu/ngày và 100 GiB truyền dữ liệu/tháng.
* [domcloud.co](https://domcloud.co) – Dịch vụ hosting Linux cung cấp CI/CD với GitHub, SSH và database MariaDB/Postgres. Bản miễn phí có 1 GB lưu trữ, 1 GB băng thông/tháng và chỉ dùng được với domain miễn phí.
* [encore.dev](https://encore.dev/) — Framework backend sử dụng static analysis để cung cấp hạ tầng tự động, code không boilerplate và nhiều hơn nữa. Bao gồm cloud hosting miễn phí cho dự án cá nhân.
* [flightcontrol.dev](https://flightcontrol.dev/) - Triển khai dịch vụ web, cơ sở dữ liệu và nhiều hơn nữa lên tài khoản AWS của bạn với workflow kiểu Git push. Gói miễn phí cho người dùng có 1 developer trên repo GitHub cá nhân. Chi phí AWS được tính qua AWS, bạn có thể dùng credits và gói free tier của AWS.
* [gigalixir.com](https://gigalixir.com/) - Gigalixir cung cấp một instance miễn phí không bị sleep và cơ sở dữ liệu PostgreSQL free-tier giới hạn 2 kết nối, 10.000 dòng và không backup cho app Elixir/Phoenix.
* [Glitch](https://glitch.com/) — Hosting công khai miễn phí với chia sẻ mã và cộng tác thời gian thực. Gói miễn phí có giới hạn 1000 giờ/tháng.
* [leapcell](https://leapcell.io/) - Leapcell là nền tảng ứng dụng phân tán đáng tin cậy, cung cấp mọi thứ bạn cần để hỗ trợ tăng trưởng nhanh chóng. Gói miễn phí bao gồm 100k lượt gọi dịch vụ, 10k tác vụ async và 100k lệnh Redis.
* [pipedream.com](https://pipedream.com) - Nền tảng tích hợp dành cho lập trình viên. Phát triển bất kỳ workflow nào dựa trên bất kỳ trigger nào. Workflow là code bạn có thể chạy [miễn phí](https://docs.pipedream.com/pricing/). Không cần quản lý server hoặc tài nguyên cloud.
* [pythonanywhere.com](https://www.pythonanywhere.com/) — Hosting ứng dụng Python trên cloud. Tài khoản Beginner miễn phí, 1 ứng dụng Python tại tên miền your-username.pythonanywhere.com, 512 MB lưu trữ riêng tư, một cơ sở dữ liệu MySQL
* [ampt.dev](https://getampt.com/) - Ampt giúp đội nhóm xây dựng, triển khai và mở rộng ứng dụng JavaScript trên AWS mà không cần cấu hình phức tạp hoặc quản lý hạ tầng. Gói Preview miễn phí gồm 500 lần gọi mỗi giờ, 2.500 lần gọi mỗi ngày và 50.000 lần gọi mỗi tháng. Chỉ có thể dùng custom domain ở gói trả phí.
* [Koyeb](https://www.koyeb.com) - Nền tảng serverless thân thiện với lập trình viên, triển khai ứng dụng toàn cầu. Chạy container Docker, ứng dụng web, API với triển khai qua git, autoscaling, mạng edge toàn cầu, service mesh và discovery tích hợp. Free Instance cho phép triển khai web service tại Frankfurt (Đức) hoặc Washington, D.C. (Mỹ). Database Postgres quản lý miễn phí tại Frankfurt (Đức), Washington, D.C. (Mỹ), và Singapore. 512MB RAM, 2GB lưu trữ, và 0.1 CPU.
* [Napkin](https://www.napkin.io/) - FaaS với 500Mb bộ nhớ, timeout mặc định 15 giây và 5.000 lượt gọi API miễn phí/tháng, giới hạn 5 gọi/giây.
* [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy hosting. Nền tảng PaaS của Meteor cho ứng dụng Meteor bao gồm hosting MongoDB Shared miễn phí và SSL tự động.
* [Northflank](https://northflank.com) — Xây dựng và triển khai microservices, job, và database quản lý với UI, API & CLI mạnh mẽ. Tự động scale container từ version control hoặc Docker registry ngoài. Gói miễn phí gồm hai dịch vụ, hai cron job và 1 database.
* [YepCode](https://yepcode.io) - Nền tảng all-in-one để kết nối API và dịch vụ trong môi trường serverless. Mang lại sự linh hoạt của NoCode nhưng đầy đủ sức mạnh của ngôn ngữ lập trình. Gói miễn phí gồm [1.000 yeps](https://yepcode.io/pricing/).
* [WunderGraph](https://cloud.wundergraph.com) - Nền tảng mã nguồn mở cho phép xây dựng, triển khai và quản lý API hiện đại nhanh chóng. Có sẵn CI/CD, tích hợp GitHub, và HTTPS tự động. Tối đa 3 dự án, 1GB egress, 300 phút build mỗi tháng trên [gói miễn phí](https://wundergraph.com/pricing)
* [Zeabur](https://zeabur.com) - Triển khai dịch vụ chỉ với một lần nhấp. Miễn phí cho ba dịch vụ, kèm $5 tín dụng miễn phí mỗi tháng.
* [mogenius](https://mogenius.com) - Dễ dàng xây dựng, triển khai, và chạy dịch vụ trên Kubernetes. Gói miễn phí hỗ trợ kết nối Kubernetes cục bộ với mogenius, cho phép lập trình viên cá nhân tạo môi trường test giống production trên máy mình.
* [genezio](https://genezio.com/) - Nhà cung cấp function serverless, tặng 1 triệu lượt gọi function, 100GB băng thông, và 10 cron job mỗi tháng miễn phí, chỉ dành cho mục đích phi thương mại hoặc học thuật.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## BaaS

* [Activepieces](https://www.activepieces.com) - Xây dựng luồng tự động hóa để kết nối các ứng dụng lại với nhau trong backend của ứng dụng bạn. Ví dụ, gửi tin nhắn Slack hoặc thêm một dòng vào Google Sheet khi sự kiện xảy ra. Miễn phí tới 5.000 tác vụ mỗi tháng.
* [back4app.com](https://www.back4app.com) - Back4App là backend dễ dùng, linh hoạt và mở rộng dựa trên Parse Platform.
* [backendless.com](https://backendless.com/) — Mobile và Web Baas, miễn phí 1 GB lưu trữ file, 50.000 push notification/tháng, và 1.000 đối tượng dữ liệu trên mỗi bảng.
* [bismuth.cloud](https://www.bismuth.cloud/) — AI của chúng tôi sẽ khởi tạo API Python của bạn trên function runtime và lưu trữ được host, xây dựng và host miễn phí trong trình chỉnh sửa online hoặc local với công cụ yêu thích của bạn.
* [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — Chương trình BMC Developer cung cấp tài liệu và nguồn lực để xây dựng và triển khai đổi mới kỹ thuật số cho doanh nghiệp của bạn. Truy cập sandbox cá nhân toàn diện bao gồm nền tảng, SDK, và thư viện thành phần để xây dựng và tùy chỉnh ứng dụng.
* [connectycube.com](https://connectycube.com) - Nhắn tin chat không giới hạn, cuộc gọi thoại & video p2p, đính kèm file và push notification. Miễn phí cho ứng dụng tối đa 1000 người dùng.
* [convex.dev](https://convex.dev/) - Backend reactive như một dịch vụ, lưu trữ dữ liệu (tài liệu với quan hệ & giao dịch ACID có thể tuần tự hóa), function serverless, và WebSocket stream cập nhật tới nhiều client. Miễn phí cho dự án nhỏ - tối đa 1 triệu bản ghi, 5 triệu lượt gọi function hàng tháng.
* [darklang.com](https://darklang.com/) - Ngôn ngữ hosted kết hợp với trình chỉnh sửa và hạ tầng. Truy cập trong giai đoạn beta, dự kiến có gói miễn phí hào phóng sau beta.
* [Firebase](https://firebase.com) — Firebase giúp bạn xây dựng và vận hành ứng dụng thành công. Gói Spark miễn phí bao gồm Authentication, Hosting, Firebase ML, Realtime Database, Cloud Storage, Testlab. A/B Testing, Analytics, App Distribution, App Indexing, Cloud Messaging (FCM), Crashlytics, Dynamic Links, In-App Messaging, Performance Monitoring, Predictions, và Remote Config luôn miễn phí.
* [Flutter Flow](https://flutterflow.io) — Xây dựng giao diện ứng dụng Flutter mà không cần viết một dòng code nào. Tích hợp Firebase. Gói miễn phí cho phép sử dụng đầy đủ UI Builder và các template miễn phí.
* [getstream.io](https://getstream.io/) — Xây dựng Chat, Messaging, Video và Audio trong ứng dụng có khả năng mở rộng chỉ trong vài giờ thay vì vài tuần
* [hasura.io](https://hasura.io/) — Hasura mở rộng database hiện có của bạn ở bất kỳ đâu và cung cấp API GraphQL ngay lập tức, có thể truy cập an toàn cho web, di động, và tích hợp dữ liệu. Miễn phí cho 1GB/tháng dữ liệu truyền qua.
* [nhost.io](https://nhost.io) - Backend serverless cho web và mobile app. Gói miễn phí bao gồm PostgreSQL, GraphQL (Hasura), Authentication, Storage và Serverless Functions.
* [onesignal.com](https://onesignal.com/) — Gửi push notification miễn phí không giới hạn. 10.000 email gửi mỗi tháng, không giới hạn số liên hệ và truy cập Auto Warm Up.
* [paraio.com](https://paraio.com) — API dịch vụ backend với xác thực linh hoạt, tìm kiếm toàn văn bản và cache. Miễn phí cho một ứng dụng, 1GB dữ liệu ứng dụng.
  * [pubnub.com](https://www.pubnub.com/) — Miễn phí thông báo đẩy cho tối đa 1 triệu tin nhắn/tháng và 100 thiết bị hoạt động hàng ngày
  * [pushbots.com](https://pushbots.com/) — Dịch vụ thông báo đẩy. Miễn phí cho tối đa 1,5 triệu lượt đẩy/tháng
  * [pushcrew.com](https://pushcrew.com/) — Dịch vụ thông báo đẩy. Không giới hạn số lượng thông báo cho tối đa 2.000 người đăng ký
  * [pusher.com](https://pusher.com/beams) — Miễn phí, không giới hạn thông báo đẩy cho 2000 người dùng hoạt động hàng tháng. Một API duy nhất cho thiết bị iOS và Android.
  * [quickblox.com](https://quickblox.com/) — Backend giao tiếp cho nhắn tin tức thời, gọi video và thoại, và thông báo đẩy
  * [restspace.io](https://restspace.io/) - Cấu hình máy chủ với các dịch vụ cho xác thực, dữ liệu, tệp tin, API email, mẫu, và nhiều hơn nữa, sau đó kết hợp vào pipeline và biến đổi dữ liệu.
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — Xây dựng ứng dụng nhanh như chớp với công cụ kéo-thả. Tùy chỉnh mô hình dữ liệu chỉ với cú click. Phát triển sâu hơn với mã Apex. Tích hợp với mọi thứ bằng các API mạnh mẽ. Bảo mật cấp doanh nghiệp. Tùy chỉnh giao diện bằng click hoặc bất kỳ framework web tiên tiến nào. Chương trình Nhà phát triển miễn phí cho phép truy cập đầy đủ nền tảng Lightning.
  * [simperium.com](https://simperium.com/) — Di chuyển dữ liệu tức thì và tự động, đa nền tảng, gửi và lưu trữ dữ liệu có cấu trúc không giới hạn, tối đa 2.500 người dùng/tháng
  * [Supabase](https://supabase.com) — Giải pháp mã nguồn mở thay thế Firebase để xây dựng backend. Gói miễn phí cung cấp Xác thực, Cơ sở dữ liệu thời gian thực & Lưu trữ đối tượng.
  * [tyk.io](https://tyk.io/) — Quản lý API với xác thực, giới hạn, giám sát và phân tích. Cung cấp cloud miễn phí
  * [zapier.com](https://zapier.com/) — Kết nối các ứng dụng bạn dùng để tự động hóa công việc. Năm zaps mỗi 15 phút và 100 tác vụ/tháng
  * [IFTTT](https://ifttt.com) — Tự động hóa các ứng dụng và thiết bị yêu thích của bạn. Miễn phí 2 Applet
  * [Integrately](https://integrately.com) — Tự động hóa các tác vụ nhàm chán chỉ với một cú nhấp. Miễn phí 100 tác vụ, thời gian cập nhật 15 phút, năm tự động hóa đang hoạt động, webhook.
  * [LeanCloud](https://leancloud.app/) — Backend cho di động. Miễn phí 1GB lưu trữ dữ liệu, 256MB instance, 3K yêu cầu API/ngày, và 10K lượt đẩy/ngày. (API rất giống Parse Platform)
  * [Claw.cloud](https://run.claw.cloud) - Nền tảng PaaS cung cấp $5/tháng tín dụng miễn phí cho người dùng có tài khoản GitHub trên 180 ngày. Lý tưởng để lưu trữ ứng dụng, cơ sở dữ liệu, và nhiều hơn nữa. ([Liên kết đăng ký với tín dụng miễn phí](https://ap-southeast-1.run.claw.cloud/signin)).


**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Nền tảng Low-code

  * [appsmith](https://www.appsmith.com/) — Dự án low-code để xây dựng bảng điều khiển quản trị, công cụ nội bộ, và dashboard. Tích hợp với hơn 15 cơ sở dữ liệu và bất kỳ API nào.
  * [Basedash](https://www.basedash.com) — Nền tảng low-code để xây dựng bảng điều khiển quản trị nội bộ và dashboard. Hỗ trợ cơ sở dữ liệu SQL và REST API.
  * [BudiBase](https://budibase.com/) — Budibase là nền tảng low-code mã nguồn mở để tạo ứng dụng nội bộ chỉ trong vài phút. Hỗ trợ PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s
  * [Clappia](https://www.clappia.com) — Nền tảng low-code dành cho xây dựng ứng dụng quy trình doanh nghiệp với app web và di động tùy chỉnh. Giao diện kéo-thả, hỗ trợ offline, theo dõi vị trí thời gian thực và tích hợp nhiều dịch vụ bên thứ ba
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ - nền tảng low-code giúp đội ngũ kỹ thuật và quản lý sản phẩm xây dựng công cụ nội bộ, hành trình người dùng tùy chỉnh, trải nghiệm số, tự động hóa, bảng quản trị tùy chỉnh, ứng dụng vận hành nhanh hơn gấp 10 lần.
  * [lil'bots](https://www.lilbots.io/) - viết và chạy script trực tuyến sử dụng miễn phí các API tích hợp như OpenAI, Anthropic, Firecrawl và các API khác. Tuyệt vời để xây dựng AI agent / công cụ nội bộ và chia sẻ với nhóm. Gói miễn phí bao gồm quyền truy cập đầy đủ API, trợ lý lập trình AI và 10.000 tín dụng thực thi/tháng.
  * [Mendix](https://www.mendix.com/) — Phát triển ứng dụng nhanh cho doanh nghiệp, không giới hạn môi trường sandbox với tổng số người dùng, 0.5 GB lưu trữ và 1 GB RAM mỗi ứng dụng. IDE Studio và Studio Pro cũng được phép ở gói miễn phí.
  * [outsystems.com](https://www.outsystems.com/) — Nền tảng phát triển web cho doanh nghiệp tại chỗ hoặc cloud, gói "môi trường cá nhân" miễn phí cho phép code không giới hạn và cơ sở dữ liệu lên tới 1 GB
  * [ReTool](https://retool.com/) — Nền tảng low-code để xây dựng ứng dụng nội bộ. Retool rất linh hoạt. Nếu bạn có thể viết bằng JavaScript và API, bạn có thể tạo nó trên Retool. Gói miễn phí cho phép tối đa năm người dùng/tháng, không giới hạn ứng dụng và kết nối API.
  * [Superblocks](https://superblocks.com/) — Nền tảng ứng dụng doanh nghiệp mở dành cho lập trình viên và nhóm bán kỹ thuật. Sử dụng AI để tạo, chỉnh sửa trực quan và mở rộng bằng code. Quản lý tập trung với tích hợp, xác thực, phân quyền & nhật ký kiểm tra.
  * [ToolJet](https://www.tooljet.com/) — Framework low-code có thể mở rộng để xây dựng ứng dụng doanh nghiệp. Kết nối đến cơ sở dữ liệu, lưu trữ đám mây, điểm cuối GraphQL, API, Airtable, v.v. và xây dựng ứng dụng bằng công cụ kéo-thả.
  * [UI Bakery](https://uibakery.io) — Nền tảng low-code giúp xây dựng ứng dụng web tùy chỉnh nhanh hơn. Hỗ trợ xây dựng UI bằng kéo-thả với mức độ tùy chỉnh cao thông qua JavaScript, Python, và SQL. Có cả phiên bản cloud và tự lưu trữ. Miễn phí cho tối đa 5 người dùng.
  * [manubes](https://www.manubes.com) - Nền tảng cloud no-code mạnh mẽ tập trung vào quản lý sản xuất công nghiệp. Miễn phí cho một người dùng với 1 triệu hoạt động workflow mỗi tháng ([cũng có tiếng Đức](https://www.manubes.de)).

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Lưu trữ web

  * [Alwaysdata](https://www.alwaysdata.com/) — 100 MB lưu trữ web miễn phí hỗ trợ MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, máy chủ web tùy chỉnh, truy cập qua FTP, WebDAV và SSH; hộp thư, danh sách gửi thư và trình cài đặt ứng dụng được bao gồm.
  * [Awardspace.com](https://www.awardspace.com) — Lưu trữ web miễn phí + miền ngắn miễn phí, PHP, MySQL, trình cài đặt ứng dụng, gửi email & không quảng cáo.
  * [Bohr](https://bohr.io) — Miễn phí cho dự án phi thương mại + Nền tảng triển khai và phát triển ưu tiên lập trình viên, giảm bớt rắc rối hạ tầng và tăng tốc cài đặt.
  * [Bubble](https://bubble.io/) — Lập trình trực quan để xây dựng ứng dụng web và di động không cần code, miễn phí với thương hiệu Bubble.
  * [dAppling Network](https://www.dappling.network/) - Nền tảng lưu trữ web phi tập trung cho frontend Web3, tập trung tăng uptime và bảo mật, cung cấp điểm truy cập bổ sung cho người dùng.
  * [DigitalOcean](https://www.digitalocean.com/pricing) - Xây dựng và triển khai ba trang web tĩnh miễn phí trên App Platform Starter.
  * [Drive To Web](https://drv.tw) — Lưu trữ trực tiếp lên web từ Google Drive & OneDrive. Chỉ hỗ trợ site tĩnh. Miễn phí vĩnh viễn. Một trang web mỗi tài khoản Google/Microsoft.
  * [Fenix Web Server](https://preview.fenixwebserver.com) - Ứng dụng desktop cho lập trình viên lưu trữ site cục bộ và chia sẻ công khai (thời gian thực). Làm việc linh hoạt với giao diện người dùng đẹp, API và/hoặc CLI.
  * [Fern](https://buildwithfern.com) - Xây dựng và lưu trữ site tài liệu dựa trên Markdown trên gói miễn phí của Fern. Có thể tự động tạo tài liệu tham khảo API từ file định nghĩa API. Site được lưu trữ tại _yoursite_.docs.buildwithfern.com.
  * [Free Hosting](https://freehostingnoads.net/) — Lưu trữ miễn phí với PHP 5, Perl, CGI, MySQL, FTP, trình quản lý tệp, email POP, tên miền phụ miễn phí, lưu trữ tên miền miễn phí, biên tập vùng DNS, thống kê website, hỗ trợ trực tuyến miễn phí và nhiều tính năng khác không có ở host miễn phí khác.
  * [Freehostia](https://www.freehostia.com) — FreeHostia cung cấp dịch vụ lưu trữ miễn phí bao gồm Control Panel tốt nhất ngành & cài đặt 1-click cho 50+ ứng dụng miễn phí. Cài đặt tức thì. Không quảng cáo ép buộc.
  * [HelioHost](https://heliohost.org) — Lưu trữ web miễn phí phi lợi nhuận với bảng điều khiển Plesk, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, email IMAP/POP3/SMTP, băng thông không giới hạn, tên miền phụ miễn phí, 1000 MB lưu trữ miễn phí với tùy chọn nâng cấp.
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — Triển khai tối đa 100 site tĩnh miễn phí, tên miền tùy chỉnh có SSL, 100 GB băng thông/tháng, hơn 260 vị trí CDN Cloudflare.
  * [Lecturify](https://www.lecturify.net/index.en.html) - Lưu trữ web với truy cập SFPT để tải lên và tải xuống tệp, hỗ trợ php.
  * [Neocities](https://neocities.org) — Lưu trữ tĩnh, 1 GB lưu trữ miễn phí với 200 GB băng thông.
  * [Netlify](https://www.netlify.com/) — Xây dựng, triển khai và lưu trữ site/app tĩnh miễn phí cho 100 GB dữ liệu và 100 GB/tháng băng thông.
  * [pantheon.io](https://pantheon.io/) — Lưu trữ Drupal và WordPress, DevOps tự động, hạ tầng mở rộng. Miễn phí cho lập trình viên và agency. Không hỗ trợ tên miền tùy chỉnh.
  * [readthedocs.org](https://readthedocs.org/) — Lưu trữ tài liệu miễn phí với versioning, tạo PDF, và nhiều hơn nữa
  * [render.com](https://render.com) — Đám mây hợp nhất để xây dựng và chạy ứng dụng và trang web với SSL miễn phí, CDN toàn cầu, mạng riêng, tự động triển khai từ Git, và hoàn toàn miễn phí cho dịch vụ web, cơ sở dữ liệu và trang web tĩnh.
  * [SourceForge](https://sourceforge.net/) — Tìm, tạo và xuất bản phần mềm mã nguồn mở miễn phí
  * [surge.sh](https://surge.sh/) — Xuất bản web tĩnh cho lập trình viên Front-End. Không giới hạn site, hỗ trợ tên miền tùy chỉnh
  * [telegra.ph](https://telegra.ph/) Dễ dàng tạo trang web bằng Quill
  * [tilda.cc](https://tilda.cc/) — Một site, 50 trang, 50 MB lưu trữ, chỉ có các block chính định sẵn trong 170+ block, không font, không favicon, không tên miền tùy chỉnh
  * [Vercel](https://vercel.com/) — Xây dựng, triển khai và lưu trữ ứng dụng web với SSL miễn phí, CDN toàn cầu và URL Preview độc đáo mỗi lần `git push`. Hoàn hảo cho Next.js và các Static Site Generator khác.
  * [Versoly](https://versoly.com/) — Trình tạo website tập trung SaaS - không giới hạn website, hơn 70 block, năm template, CSS tùy chỉnh, favicon, SEO và form. Không hỗ trợ tên miền tùy chỉnh.
  * [Qoddi](https://qoddi.com) - Dịch vụ PaaS tương tự Heroku với cách tiếp cận tập trung vào lập trình viên và đầy đủ tính năng. Gói miễn phí cho tài sản tĩnh, staging và ứng dụng dev.
  * [FreeFlarum](https://freeflarum.com/) - Lưu trữ Flarum miễn phí do cộng đồng hỗ trợ cho tối đa 250 người dùng (quyên góp để xóa watermark ở chân trang).
  * [MDB GO](https://mdbgo.com/) - Lưu trữ miễn phí cho một dự án với TTL container hai tuần, 500 MB RAM mỗi dự án, SFTP - 1G dung lượng đĩa.
  * [Patr Cloud](https://patr.cloud/) — Nền tảng đám mây dễ sử dụng, trong số các dịch vụ trả phí có cung cấp lưu trữ miễn phí ba site tĩnh.
  * [Serv00.com](https://serv00.com/) — 3 GB lưu trữ web miễn phí với sao lưu hàng ngày (7 ngày). Hỗ trợ: Crontab, truy cập SSH, kho mã (GIT, SVN, Mercurial), hỗ trợ: MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R, và nhiều ngôn ngữ khác.
  - [Sevalla](https://sevalla.com/) - Nền tảng lưu trữ giúp đơn giản hóa việc triển khai và quản lý ứng dụng, cơ sở dữ liệu, và website tĩnh - giới hạn 1GB/site, 100GB băng thông miễn phí, 600 phút build miễn phí, 100 site/tài khoản.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Bộ phân giải DNS công cộng miễn phí, nhanh và an toàn (mã hóa truy vấn DNS), do Cloudflare cung cấp. Hữu ích để vượt qua chặn DNS của nhà mạng, ngăn chặn theo dõi truy vấn DNS và [chặn nội dung độc hại & người lớn](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). Có thể dùng [qua API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests). Lưu ý: Chỉ là bộ phân giải DNS, không phải host DNS.
  * [1984.is](https://www.1984.is/product/freedns/) — Dịch vụ DNS miễn phí với API và nhiều tính năng DNS miễn phí khác.
  * [cloudns.net](https://www.cloudns.net/) — Lưu trữ DNS miễn phí cho tối đa 1 tên miền với 50 bản ghi
  * [deSEC](https://desec.io) - Lưu trữ DNS miễn phí với hỗ trợ API, thiết kế ưu tiên bảo mật. Chạy trên phần mềm mã nguồn mở và được hỗ trợ bởi [SSE](https://www.securesystems.de/).
  * [dns.he.net](https://dns.he.net/) — Lưu trữ DNS miễn phí với hỗ trợ Dynamic DNS
  * [Zonomi](https://zonomi.com/) — Lưu trữ DNS miễn phí với khả năng cập nhật DNS tức thì. Gói miễn phí: 1 vùng DNS (tên miền) với tối đa 10 bản ghi DNS.
  * [dnspod.com](https://www.dnspod.com/) — Lưu trữ DNS miễn phí.
  * [duckdns.org](https://www.duckdns.org/) — DDNS miễn phí với tối đa 5 tên miền trên gói miễn phí. Có hướng dẫn cấu hình cho nhiều hệ thống.
  * [Dynv6.com](https://dynv6.com/) — Dịch vụ DDNS miễn phí với [hỗ trợ API](https://dynv6.com/docs/apis) và quản lý nhiều loại bản ghi dns (như CNAME, MX, SPF, SRV, TXT và các loại khác).
  * [freedns.afraid.org](https://freedns.afraid.org/) — Lưu trữ DNS miễn phí. Cũng cung cấp tên miền phụ miễn phí dựa trên nhiều tên miền do người dùng [đóng góp](https://freedns.afraid.org/domain/registry/). Nhận tên miền phụ miễn phí từ menu "Subdomains" sau khi đăng ký.
  * [luadns.com](https://www.luadns.com/) — Lưu trữ DNS miễn phí, ba tên miền, đầy đủ tính năng với giới hạn hợp lý
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — DNS miễn phí. Không giới hạn số lượng tên miền
  * [nextdns.io](https://nextdns.io) - Tường lửa dựa trên DNS, 300K truy vấn miễn phí mỗi tháng
  * [noip.at](https://noip.at/) — Dịch vụ DDNS miễn phí không cần đăng ký, không theo dõi, không lưu log hay quảng cáo. Không giới hạn tên miền.
  * [noip](https://www.noip.com/) — Dịch vụ DNS động cho phép tối đa 3 hostname miễn phí, xác nhận mỗi 30 ngày
  * [sslip.io](https://sslip.io/) — Dịch vụ DNS miễn phí, khi truy vấn tên máy chủ chứa IP sẽ trả về chính IP đó.
  * [zilore.com](https://zilore.com/en/dns) — Lưu trữ DNS miễn phí cho 5 tên miền.
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — Lưu trữ DNS miễn phí với hỗ trợ Dynamic DNS.
  * [zonewatcher.com](https://zonewatcher.com) — Sao lưu tự động và giám sát thay đổi DNS. Một tên miền miễn phí
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Lưu trữ DNS miễn phí bởi Huawei
  * [Hetzner](https://www.hetzner.com/dns-console) – Lưu trữ DNS miễn phí từ Hetzner với hỗ trợ API.
  * [Glauca](https://docs.glauca.digital/hexdns/) – Lưu trữ DNS miễn phí cho tối đa 3 tên miền và hỗ trợ DNSSEC
  * [VolaryDDNS](https://volaryddns.net) - DDNS miễn phí hiệu năng cao, không đăng ký hoặc quảng cáo
**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Tên miền

  * [pp.ua](https://nic.ua/) — Miễn phí tên miền phụ pp.ua.
  * [us.kg](https://nic.us.kg/) - Miễn phí tên miền phụ us.kg.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — Tương thích với AWS S3 - APIs, thao tác giao diện, CLI và các phương thức tải lên khác, tải lên và lưu trữ tệp từ mạng IPFS và Arweave một cách an toàn, tiện lợi và hiệu quả. Người dùng đăng ký có thể nhận 6 GB lưu trữ IPFS và 300MB lưu trữ Arweave miễn phí. Bất kỳ tệp tải lên Arweave nào nhỏ hơn 150 KB đều miễn phí.
  * [backblaze.com](https://www.backblaze.com/b2/) — Lưu trữ đám mây Backblaze B2. Miễn phí 10 GB lưu trữ đối tượng (giống Amazon S3) không giới hạn thời gian
  * [filebase.com](https://filebase.com/) - Lưu trữ Đối tượng Tương thích S3 Được Hỗ Trợ bởi Blockchain. Miễn phí 5 GB lưu trữ không giới hạn thời gian.
  * [Tebi](https://tebi.io/) - Lưu trữ đối tượng tương thích S3. Miễn phí 25 GB lưu trữ và 250GB truyền tải ra ngoài.
  * [Idrive e2](https://www.idrive.com/e2/) - Lưu trữ đối tượng tương thích S3. Miễn phí 10 GB lưu trữ và 10 GB băng thông tải xuống mỗi tháng.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - Lưu trữ đối tượng tương thích S3. Miễn phí 15 GB lưu trữ và 15 GB tải xuống mỗi tháng.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Dịch vụ Dữ liệu Quản lý

  * [Aiven](https://aiven.io/) - Aiven cung cấp các gói miễn phí PostgreSQL, MySQL và Redis trên nền tảng dữ liệu mã nguồn mở của mình. Một node đơn, 1 CPU, 1GB RAM, và đối với PostgreSQL và MySQL, 5GB lưu trữ. Dễ dàng nâng cấp lên các gói lớn hơn hoặc chuyển đổi giữa các đám mây.
  * [airtable.com](https://airtable.com/) — Trông giống như bảng tính, nhưng là cơ sở dữ liệu quan hệ, không giới hạn số lượng cơ sở, 1.200 dòng/cơ sở, và 1.000 yêu cầu API/tháng
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Cassandra gốc đám mây dưới dạng dịch vụ với [80GB miễn phí](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — API/backend serverless JavaScript dễ sử dụng và dịch vụ cơ sở dữ liệu NoSQL với functions, truy vấn kiểu MongoDB, tra cứu key/value, hệ thống công việc, tin nhắn realtime, hàng đợi worker, CLI mạnh mẽ và trình quản lý dữ liệu web. Gói miễn phí có 5GB lưu trữ và 60 cuộc gọi API/phút. Bao gồm 2 nhà phát triển. Không cần thẻ tín dụng.
  * [CrateDB](https://crate.io/) - Cơ sở dữ liệu SQL phân tán mã nguồn mở cho phân tích thời gian thực. [Miễn phí tầng CRFREE](https://crate.io/lp-crfree): Một node với 2 CPU, 2 GiB bộ nhớ, 8 GiB lưu trữ. Một cụm cho mỗi tổ chức, không cần phương thức thanh toán.
  * [Upstash](https://upstash.com/) — Redis serverless với gói miễn phí lên đến 10.000 yêu cầu mỗi ngày, tối đa 256MB dung lượng DB, và 20 kết nối đồng thời
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - triển khai một cụm cơ sở dữ liệu quản lý hoàn toàn miễn phí cho nhà phát triển để tạo thế hệ ứng dụng tiếp theo từ IoT đến AI
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — tầng miễn phí cung cấp 512 MB
  * [redsmin.com](https://www.redsmin.com/) — Dịch vụ giám sát và quản trị Redis trực tuyến theo thời gian thực, Giám sát 1 instance Redis miễn phí
  * [redislabs](https://redislabs.com/try-free/) - Miễn phí 30MB instance redis
  * [MemCachier](https://www.memcachier.com/) — Dịch vụ Memcache được quản lý. Miễn phí lên đến 25MB, 1 Proxy Server, và phân tích cơ bản
  * [scalingo.com](https://scalingo.com/) — Chủ yếu là PaaS nhưng cung cấp tầng miễn phí 128MB đến 192MB cho MySQL, PostgreSQL, hoặc MongoDB
  * [SeaTable](https://seatable.io/) — Cơ sở dữ liệu linh hoạt, giống bảng tính được phát triển bởi đội ngũ Seafile. không giới hạn bảng, 2.000 dòng, phiên bản 1 tháng, tối đa 25 thành viên nhóm.
  * [skyvia.com](https://skyvia.com/) — Nền tảng dữ liệu đám mây cung cấp tầng miễn phí và tất cả các gói đều hoàn toàn miễn phí khi ở chế độ beta
  * [StackBy](https://stackby.com/) — Một công cụ kết hợp sự linh hoạt của bảng tính, sức mạnh của cơ sở dữ liệu, và tích hợp sẵn với các ứng dụng doanh nghiệp yêu thích của bạn. Gói miễn phí bao gồm không giới hạn người dùng, mười stack, và tệp đính kèm 2GB mỗi stack.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB là hệ quản trị cơ sở dữ liệu phân tán HTAP tương thích MySQL mã nguồn mở. TiDB Serverless cung cấp 5GB lưu trữ dòng, 5GB lưu trữ cột, và 50 triệu Đơn vị Yêu cầu (RUs) miễn phí mỗi tháng.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso là trải nghiệm nhà phát triển SQLite trên Cơ sở dữ liệu Edge. Turso cung cấp gói Free Forever khởi đầu, 9 GB tổng lưu trữ, tối đa 500 cơ sở dữ liệu, tối đa 3 địa điểm, 1 tỷ lượt đọc dòng mỗi tháng, và hỗ trợ phát triển cục bộ với SQLite.
  * [InfluxDB](https://www.influxdata.com/) — Cơ sở dữ liệu chuỗi thời gian, miễn phí tối đa 3MB/5 phút ghi, 30MB/5 phút đọc và 10.000 chuỗi độc lập
  * [restdb.io](https://restdb.io/) - dịch vụ cơ sở dữ liệu NoSQL đám mây nhanh và đơn giản. Với restdb.io bạn nhận được schema, quan hệ, REST API tự động (với truy vấn giống MongoDB), và giao diện quản trị nhiều người dùng hiệu quả để làm việc với dữ liệu. Gói miễn phí cho phép 3 người dùng, 2500 bản ghi, và 1 yêu cầu API mỗi giây.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — Tầng miễn phí cung cấp 50 triệu RUs và 10 GiB lưu trữ (bằng giá trị 15$) miễn phí mỗi tháng. ([Request Units là gì](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — Cơ sở dữ liệu đồ thị gốc quản lý / nền tảng phân tích với ngôn ngữ truy vấn Cypher và REST API. Giới hạn kích thước đồ thị (50k node, 175k mối quan hệ).
  * [Neon](https://neon.tech/) — Quản lý PostgreSQL, 0.5 GB lưu trữ (tổng), 1 Dự án, 10 nhánh, Không giới hạn cơ sở dữ liệu, nhánh chính luôn sẵn sàng (Tự động tạm dừng sau 5 phút), 20 giờ hoạt động mỗi tháng (tổng) cho compute nhánh không chính.
  * [Prisma Postgres](https://prisma.io/postgres) - Postgres được host siêu nhanh dựa trên unikernel và chạy trên bare metal, 1GB lưu trữ, 10 cơ sở dữ liệu, tích hợp với Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — Quản lý cơ sở dữ liệu đồ thị gốc với GraphQL API. Giới hạn 1 MB dữ liệu truyền mỗi ngày.
  * [Tinybird](https://tinybird.co) - ClickHouse serverless được quản lý với ingest dữ liệu không kết nối qua HTTP và cho phép bạn công bố truy vấn SQL dưới dạng HTTP API được quản lý. Không giới hạn thời gian cho tầng miễn phí, 10GB lưu trữ + 1000 yêu cầu API mỗi ngày.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — Cơ sở dữ liệu đồ thị gốc quản lý / nền tảng phân tích với ngôn ngữ truy vấn đồ thị giống SQL và REST API. Một instance miễn phí với hai vCPU, 8GB RAM, và 50GB lưu trữ, tự động ngủ sau 1 giờ không hoạt động.
  * [TerminusCMS](https://terminusdb.com/pricing) — Dịch vụ miễn phí quản lý cho TerminusDB, cơ sở dữ liệu tài liệu và đồ thị viết bằng Prolog và Rust. Miễn phí cho phát triển, dịch vụ trả phí cho triển khai doanh nghiệp và hỗ trợ.
  * [filess.io](https://filess.io) - filess.io là nền tảng nơi bạn có thể tạo hai cơ sở dữ liệu với tối đa 10 MB mỗi cơ sở cho các DBMS sau miễn phí: MySQL, MariaDB, MongoDB, và PostgreSQL.
  * [xata.io](https://xata.io) - Xata là cơ sở dữ liệu serverless với tìm kiếm và phân tích mạnh mẽ tích hợp sẵn. Một API, nhiều thư viện client type-safe, tối ưu hóa cho quy trình phát triển. Tầng miễn phí mãi mãi đủ cho nhà phát triển hobby với ba đơn vị Xata, xem trang web để biết định nghĩa đơn vị.
  * [8base.com](https://www.8base.com/) - 8base là nền tảng phát triển low-code toàn diện dành cho lập trình viên JavaScript xây dựng trên MySQL và GraphQL, backend serverless. Cho phép bạn bắt đầu xây dựng ứng dụng web nhanh chóng bằng trình tạo ứng dụng UI và mở rộng nhanh chóng, Tầng Miễn phí gồm: 2.500 dòng, 500 lưu trữ, 1Gb/h tính toán serverless, và 5 người dùng ứng dụng client.
  * [Nile](https://www.thenile.dev/) — Nền tảng Postgres cho ứng dụng B2B. Không giới hạn cơ sở dữ liệu, Luôn sẵn sàng không tắt, 1GB lưu trữ (tổng), 50 triệu token truy vấn, tự động mở rộng, không giới hạn vector embedding



**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Tunneling, WebRTC, Web Socket Servers và các Router khác

  * [Pinggy](https://pinggy.io) — Public URLs cho localhost chỉ với một lệnh, không cần tải xuống. Tunnel HTTPS / TCP / TLS. Gói miễn phí có thời gian sống tunnel 60 phút.
  * [conveyor.cloud](https://conveyor.cloud/) — Tiện ích mở rộng Visual Studio để expose IIS Express cho mạng cục bộ hoặc qua tunnel ra URL công khai.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi là dịch vụ VPN hosted cho phép bạn mở rộng mạng như LAN cho các nhóm phân tán với gói miễn phí cho phép không giới hạn mạng với tối đa 5 người
  * [Mirna Sockets](https://mirna.cloud/) - Nền tảng Socket as a Service miễn phí cung cấp cho bạn một URL wss:// khi triển khai mã máy chủ Web Socket của bạn và cho phép bạn giám sát hiệu suất của nó.
  * [localhost.run](https://localhost.run/) — Expose máy chủ chạy cục bộ qua tunnel ra URL công khai.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — Expose máy chủ chạy cục bộ qua tunnel ra URL công khai. Phiên bản host miễn phí, và [mã nguồn mở](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — Expose máy chủ chạy cục bộ qua tunnel ra URL công khai.
  * [cname.dev](https://cname.dev/) — Dịch vụ reverse proxy động miễn phí và an toàn.
  * [serveo](https://serveo.net/) — Expose máy chủ cục bộ ra internet. Không cần cài đặt, không cần đăng ký. Tên miền phụ miễn phí, không giới hạn.
  * [Radmin VPN](https://www.radmin-vpn.com/) — Kết nối nhiều máy tính lại với nhau qua VPN tạo mạng LAN-like. Không giới hạn peer. (Thay thế Hamachi)
  * [segment.com](https://segment.com/) — Trung tâm chuyển đổi và định tuyến sự kiện sang các dịch vụ bên thứ ba khác. 100.000 sự kiện/tháng miễn phí
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — VPN không cần cấu hình, sử dụng giao thức WireGuard mã nguồn mở. Cài đặt trên MacOS, iOS, Windows, Linux, và Android. Gói miễn phí cho sử dụng cá nhân với 100 thiết bị và ba người dùng.
  * [webhookrelay.com](https://webhookrelay.com) — Quản lý, debug, fan-out, và proxy tất cả webhook của bạn đến các đích công khai hoặc nội bộ (ví dụ: localhost). Ngoài ra, expose máy chủ chạy trong mạng riêng qua tunnel bằng cách nhận endpoint HTTP công khai (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — Phát triển, kiểm thử và giám sát webhook từ bất cứ đâu. 100K yêu cầu và 100K lần thử mỗi tháng với ba ngày lưu trữ.
  * [Xirsys](https://www.xirsys.com/pricing/) — Sử dụng STUN không giới hạn + 500 MB băng thông TURN hàng tháng, giới hạn băng thông, một khu vực địa lý.
  * [ZeroTier](https://www.zerotier.com) — Ethernet ảo FOSS được quản lý dưới dạng dịch vụ. Không giới hạn mạng được mã hóa end-to-end với 25 client trong gói miễn phí. Client cho desktop/mobile/NA; giao diện web để cấu hình quy tắc định tuyến tùy chỉnh và phê duyệt node client mới trên mạng riêng
  * [LocalXpose](https://localxpose.io) — Reverse proxy cho phép bạn expose máy chủ localhost ra internet. Gói miễn phí có thời gian sống tunnel 15 phút.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - Công khai dịch vụ chạy cục bộ qua tunnel ra URL tùy chỉnh công khai và bảo vệ chúng bằng kiểm soát truy cập. Miễn phí cho 5 dịch vụ trong một cluster.
  * [Expose](https://expose.dev/) - Expose site cục bộ qua tunnel an toàn. Gói miễn phí bao gồm máy chủ EU, tên miền phụ ngẫu nhiên, và một người dùng.
  * [btunnel](https://www.btunnel.in/) — Expose localhost và máy chủ tcp cục bộ ra internet. Gói miễn phí bao gồm file server, header http request và response tùy chỉnh, bảo vệ basic auth và timeout tunnel 1 giờ.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Theo dõi Vấn đề và Quản lý Dự án

  * [acunote.com](https://www.acunote.com/) — Phần mềm quản lý dự án và SCRUM miễn phí cho tối đa 5 thành viên nhóm
  * [asana.com](https://asana.com/) — Miễn phí cho dự án riêng với cộng tác viên
  * [Backlog](https://backlog.com) — Mọi thứ nhóm bạn cần để phát hành dự án tuyệt vời trên một nền tảng. Gói miễn phí cung cấp 1 Dự án với mười người dùng & 100MB lưu trữ.
  * [Basecamp](https://basecamp.com/personal) - Danh sách việc cần làm, quản lý mốc, nhắn tin kiểu diễn đàn, chia sẻ tệp, và theo dõi thời gian. Tối đa 3 dự án, 20 người dùng và 1GB dung lượng lưu trữ.
  * [bitrix24.com](https://www.bitrix24.com/) — Công cụ mạng nội bộ và quản lý dự án. Gói miễn phí có 5GB cho số lượng người dùng không giới hạn.
  * [cacoo.com](https://cacoo.com/) — Sơ đồ trực tuyến thời gian thực: luồng, UML, mạng. Miễn phí tối đa 15 người dùng/sơ đồ, 25 sheet
  * [Chpokify](https://chpokify.com/) — Planning Poker dựa trên nhóm giúp tiết kiệm thời gian ước lượng sprint. Miễn phí lên đến 5 người dùng, tích hợp Jira miễn phí, không giới hạn cuộc gọi video, không giới hạn nhóm, không giới hạn phiên.
  * [clickup.com](https://clickup.com/) — Quản lý dự án. Miễn phí, phiên bản premium có lưu trữ đám mây. Ứng dụng di động và tích hợp Git có sẵn.
  * [Clockify](https://clockify.me) - Ứng dụng theo dõi thời gian và bảng chấm công cho phép bạn theo dõi giờ làm việc trên nhiều dự án. Không giới hạn người dùng, miễn phí mãi mãi.
  * [Cloudcraft](https://cloudcraft.co/) — Thiết kế sơ đồ kiến trúc chuyên nghiệp trong vài phút với trình thiết kế trực quan Cloudcraft, tối ưu cho AWS với các thành phần thông minh hiển thị dữ liệu trực tiếp. Gói miễn phí có sơ đồ riêng tư không giới hạn cho một người dùng.
  * [Codegiant](https://codegiant.io) — Quản lý dự án với hosting repository & CI/CD. Gói miễn phí cung cấp Không giới hạn repository, dự án & tài liệu với 5 thành viên nhóm. 500 phút CI/CD mỗi tháng. 30000 phút chạy code serverless mỗi tháng, 1GB lưu trữ repository.
  * [Confluence](https://www.atlassian.com/software/confluence) - Công cụ hợp tác nội dung của Atlassian giúp nhóm làm việc và chia sẻ kiến thức hiệu quả. Gói miễn phí cho tối đa 10 người dùng.
  * [contriber.com](https://www.contriber.com/) — Nền tảng quản lý dự án tùy chỉnh, gói khởi đầu miễn phí, năm workspace
  * [Crosswork](https://crosswork.app/) - Nền tảng quản lý dự án đa năng. Miễn phí cho tối đa 3 dự án, không giới hạn người dùng, 1 GB lưu trữ.
  * [diagrams.net](https://app.diagrams.net/) — Vẽ sơ đồ trực tuyến lưu trữ cục bộ trên Google Drive, OneDrive hoặc Dropbox. Miễn phí với mọi tính năng và mức lưu trữ.
  * [freedcamp.com](https://freedcamp.com/) - Quản lý nhiệm vụ, thảo luận, cột mốc, theo dõi thời gian, lịch, tệp và trình quản lý mật khẩu. Gói miễn phí không giới hạn dự án, người dùng và lưu trữ tệp.
  * [easyretro.io](https://www.easyretro.io/) — Công cụ hồi tưởng sprint đơn giản và trực quan. Gói miễn phí có ba bảng công khai và một khảo sát mỗi bảng mỗi tháng.
  * [GForge](https://gforge.com) — Bộ công cụ Quản lý dự án và Theo dõi sự cố cho các dự án phức tạp với tùy chọn triển khai tại chỗ và SaaS. Gói SaaS miễn phí cho năm người dùng đầu tiên & miễn phí cho các dự án mã nguồn mở.
  * [gleek.io](https://www.gleek.io) — Công cụ mô tả thành sơ đồ miễn phí cho lập trình viên. Tạo sơ đồ UML lớp, đối tượng hoặc thực thể-quan hệ không chính thức chỉ bằng từ khóa của bạn.
  * [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector xuất ra danh sách các thay đổi giữa hai lược đồ GraphQL. Mỗi khác biệt được giải thích chi tiết và đánh dấu là phá vỡ, không phá vỡ hoặc nguy hiểm.
  * [huboard.com](https://huboard.com/) — Quản lý dự án tức thì cho các vấn đề GitHub của bạn, miễn phí cho mã nguồn mở.
  * [Hygger](https://hygger.io) — Nền tảng quản lý dự án. Gói miễn phí cung cấp không giới hạn người dùng, dự án & bảng với 100 MB lưu trữ.
  * [Instabug](https://instabug.com) — SDK báo cáo lỗi toàn diện và phản hồi trong ứng dụng cho ứng dụng di động. Miễn phí cho tối đa 1 ứng dụng và 1 thành viên.
  * [WishKit](https://wishkit.io) — Thu thập phản hồi người dùng trong ứng dụng cho ứng dụng iOS/macOS và ưu tiên tính năng dựa trên lượt bình chọn của người dùng. Miễn phí cho 1 ứng dụng.
  * [Ilograph](https://www.ilograph.com/)  — Sơ đồ tương tác cho phép người dùng xem hạ tầng từ nhiều góc nhìn và mức chi tiết khác nhau. Biểu đồ có thể được diễn đạt bằng mã. Gói miễn phí có sơ đồ riêng tư không giới hạn với tối đa 3 người xem.
  * [Jira](https://www.atlassian.com/software/jira) — Công cụ quản lý dự án phát triển phần mềm tiên tiến được sử dụng rộng rãi trong các doanh nghiệp. Gói miễn phí cho tối đa 10 người dùng.
  * [kanbanflow.com](https://kanbanflow.com/) — Quản lý dự án dựa trên bảng. Miễn phí, có phiên bản cao cấp với nhiều tùy chọn hơn.
  * [kanbantool.com](https://kanbantool.com/) — Quản lý dự án dựa trên bảng Kanban. Gói miễn phí có hai bảng và hai người dùng, không đính kèm hoặc tệp.
  * [kan.bn](https://kan.bn/) - Ứng dụng kanban mạnh mẽ, linh hoạt giúp bạn tổ chức công việc, theo dõi tiến độ và hoàn thành mục tiêu—tất cả trong một nơi. Gói miễn phí cho 1 người dùng với số bảng, danh sách, thẻ không giới hạn.
  * [Kitemaker.co](https://kitemaker.co) - Hợp tác xuyên suốt quá trình phát triển sản phẩm và theo dõi công việc trên Slack, Discord, Figma, và Github. Không giới hạn người dùng, không gian làm việc. Gói miễn phí cho tối đa 250 hạng mục công việc.
  * [Kiter.app](https://www.kiter.app/) - Giúp mọi người tổ chức quá trình tìm việc và theo dõi phỏng vấn, cơ hội, và mối quan hệ. Ứng dụng web mạnh mẽ và tiện ích Chrome. Hoàn toàn miễn phí.
  * [Kumu.io](https://kumu.io/)  — Bản đồ quan hệ với hoạt ảnh, trang trí, bộ lọc, phân cụm, nhập từ bảng tính, v.v. Gói miễn phí cho phép dự án công khai không giới hạn. Kích thước biểu đồ không giới hạn. Dự án riêng miễn phí cho sinh viên. Có chế độ Sandbox nếu bạn không muốn công khai tệp (tải lên, chỉnh sửa, tải về, hủy).
  * [Linear](https://linear.app/) — Trình theo dõi sự cố với giao diện tối giản. Miễn phí cho số thành viên không giới hạn, tải tệp tối đa 10MB, 250 sự cố (không tính Archive)
  * [leiga.com](https://www.leiga.com/) — Leiga là sản phẩm SaaS sử dụng AI tự động quản lý dự án, giúp nhóm tập trung và phát huy tối đa tiềm năng, đảm bảo tiến độ dự án như kế hoạch. Miễn phí cho tối đa 10 người dùng, 20 trường tùy chỉnh, 2GB lưu trữ, Ghi hình Video với AI tối đa 5 phút/video, Tự động hóa 20 lần/người dùng/tháng.
  * [Lucidchart](https://www.lucidchart.com/) - Công cụ vẽ sơ đồ trực tuyến với tính năng cộng tác. Gói miễn phí với ba tài liệu chỉnh sửa được, 100 mẫu chuyên nghiệp và tính năng cộng tác cơ bản.
  * [MeisterTask](https://www.meistertask.com/) — Quản lý nhiệm vụ trực tuyến cho nhóm. Miễn phí cho tối đa 3 dự án và thành viên dự án không giới hạn.
  * [MeuScrum](https://www.meuscrum.com/en) - Công cụ scrum trực tuyến miễn phí với bảng kanban
  * [nTask](https://www.ntaskmanager.com/) — Phần mềm quản lý dự án cho phép nhóm cộng tác, lập kế hoạch, phân tích và quản lý công việc hằng ngày. Gói cơ bản miễn phí vĩnh viễn với 100 MB lưu trữ và năm người dùng/nhóm. Không giới hạn không gian làm việc, cuộc họp, nhiệm vụ, bảng chấm công và theo dõi sự cố.
  * [Ora](https://ora.pm/) - Quản lý nhiệm vụ linh hoạt & cộng tác nhóm. Miễn phí cho tối đa 3 người dùng và tệp giới hạn 10 MB.
  * [pivotaltracker.com](https://www.pivotaltracker.com/) — Miễn phí cho dự án công khai không giới hạn và hai dự án riêng với tổng cộng ba người dùng hoạt động (đọc-ghi) và người dùng bị động không giới hạn (chỉ đọc).
  * [plan.io](https://plan.io/) — Quản lý dự án với lưu trữ kho mã và nhiều tùy chọn. Miễn phí cho hai người dùng với mười khách hàng và 500MB lưu trữ.
  * [Plane](https://plane.so/) - Plane là công cụ quản lý dự án và sản phẩm đơn giản, mở rộng, mã nguồn mở. Miễn phí cho số thành viên không giới hạn, tải tệp tối đa 5MB, 1000 sự cố.
  * [planitpoker.com](https://www.planitpoker.com/) — Công cụ estimation poker trực tuyến miễn phí.
  * [point.poker](https://www.point.poker/) - Planning Poker trực tuyến (công cụ estimation dựa trên đồng thuận). Miễn phí cho người dùng, nhóm, phiên, vòng và lượt bình chọn không giới hạn. Không cần đăng ký.
  * [ScrumFast](https://www.scrumfast.com) - Bảng scrum với giao diện trực quan, miễn phí cho tối đa 5 người dùng.
  * [Shake](https://www.shakebugs.com/) - Công cụ báo lỗi và phản hồi trong ứng dụng di động. Gói miễn phí, mười báo lỗi mỗi ứng dụng/tháng.
  * [Shortcut](https://shortcut.com/) - Nền tảng quản lý dự án. Miễn phí cho tối đa 10 người dùng vĩnh viễn.
  * [Tadum](https://tadum.app) - Ứng dụng quản lý nội dung cuộc họp định kỳ, miễn phí cho nhóm tối đa 10 người.
  * [taiga.io](https://taiga.io/) — Nền tảng quản lý dự án cho startup và lập trình viên agile, miễn phí cho mã nguồn mở.
  * [Tara AI](https://tara.ai/) — Dịch vụ quản lý sprint đơn giản. Gói miễn phí có nhiệm vụ, sprint, không gian làm việc không giới hạn, không giới hạn người dùng.
  * [targetprocess.com](https://www.targetprocess.com/) — Quản lý dự án trực quan, từ Kanban và Scrum đến mọi quy trình hoạt động. Miễn phí cho số người dùng không giới hạn, tối đa 1.000 thực thể dữ liệu {[chi tiết thêm](https://www.targetprocess.com/pricing/)}
  * [taskade.com](https://www.taskade.com/) — Danh sách nhiệm vụ cộng tác thời gian thực và phác thảo nhóm. Gói miễn phí có một không gian làm việc với nhiệm vụ và dự án không giới hạn; 1GB lưu trữ tệp; lịch sử dự án 1 tuần; năm người tham gia mỗi cuộc họp video.
  * [taskulu.com](https://taskulu.com/) — Quản lý dự án dựa trên vai trò. Miễn phí cho tối đa 5 người dùng. Tích hợp GitHub/Trello/Dropbox/Google Drive.
  * [Teaminal](https://www.teaminal.com) - Công cụ standup, hồi tưởng và lập kế hoạch sprint cho nhóm làm việc từ xa. Miễn phí cho tối đa 15 người dùng.
  * [teamwork.com](https://teamwork.com/) — Quản lý dự án & trò chuyện nhóm. Miễn phí cho năm người dùng và hai dự án. Có gói trả phí.
  * [teleretro.com](https://www.teleretro.com/) — Công cụ hồi tưởng đơn giản và vui nhộn với trò chơi mở đầu, gif và emoji. Gói miễn phí gồm ba buổi hồi tưởng và thành viên không giới hạn.
  * [testlio.com](https://testlio.com/) — Nền tảng theo dõi sự cố, quản lý kiểm thử và thử nghiệm beta. Miễn phí cho sử dụng cá nhân.
  * [terrastruct.com](https://terrastruct.com/) — Công cụ vẽ sơ đồ trực tuyến chuyên cho kiến trúc phần mềm. Gói miễn phí tối đa 4 lớp mỗi sơ đồ.
  * [todoist.com](https://todoist.com/) — Quản lý nhiệm vụ cá nhân và nhóm. Gói miễn phí có: 5 dự án hoạt động, năm người dùng mỗi dự án, tải tệp tối đa 5MB, ba bộ lọc, lịch sử hoạt động một tuần.
  * [trello.com](https://trello.com/) — Quản lý dự án dựa trên bảng. Không giới hạn Bảng Cá nhân, 10 Bảng Nhóm.
  * [Tweek](https://tweek.so/) — Lịch việc & quản lý nhiệm vụ hàng tuần đơn giản.
  * [ubertesters.com](https://ubertesters.com/) — Nền tảng kiểm thử, tích hợp và tester cộng đồng, 2 dự án, năm thành viên.
  * [Wikifactory](https://wikifactory.com/) — Dịch vụ thiết kế sản phẩm với Dự án, VCS & Sự cố. Gói miễn phí cung cấp dự án & cộng tác viên không giới hạn và 3GB lưu trữ.
  * [Yodiz](https://www.yodiz.com/) — Phát triển Agile và theo dõi sự cố. Miễn phí cho tối đa 3 người dùng, dự án không giới hạn.
  * [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — Miễn phí YouTrack (InCloud) được lưu trữ cho dự án FOSS và dự án riêng tư (miễn phí cho ba người dùng). Bao gồm theo dõi thời gian và bảng agile.
  * [zenhub.com](https://www.zenhub.com) — Giải pháp quản lý dự án duy nhất tích hợp trong GitHub. Miễn phí cho repo công khai, OSS và tổ chức phi lợi nhuận.
  * [zenkit.com](https://zenkit.com) — Công cụ quản lý dự án và cộng tác. Miễn phí cho tối đa 5 thành viên, 5 GB tệp đính kèm.
  * [Zube](https://zube.io) — Quản lý dự án với gói miễn phí cho 4 Dự án & 4 người dùng. Hỗ trợ tích hợp GitHub.
  * [Toggl](https://toggl.com/) — Cung cấp hai công cụ tăng năng suất miễn phí. [Toggl Track](https://toggl.com/track/) để quản lý và theo dõi thời gian với gói miễn phí hỗ trợ theo dõi và báo cáo thời gian liền mạch, thiết kế cho freelancer. Không giới hạn bản ghi thời gian, dự án, khách hàng, thẻ, báo cáo, v.v. Và [Toggl Plan](https://toggl.com/plan/) để lập kế hoạch nhiệm vụ, miễn phí cho nhà phát triển cá nhân với nhiệm vụ, mốc, tiến trình không giới hạn.
  * [Sflow](https://sflow.io) — sflow.io là công cụ quản lý dự án được xây dựng cho phát triển phần mềm agile, marketing, bán hàng và hỗ trợ khách hàng, đặc biệt cho dự án outsourcing và cộng tác liên tổ chức. Miễn phí cho tối đa 3 dự án và năm thành viên.
  * [Pulse.red](https://pulse.red) — Ứng dụng chấm công và theo dõi thời gian dự án tối giản, miễn phí.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Lưu trữ và Xử lý Media

  * [AndroidFileHost](https://androidfilehost.com/) - Nền tảng chia sẻ tệp miễn phí với tốc độ, băng thông, số lượng tệp, số lượt tải về không giới hạn, v.v. Chủ yếu dành cho tệp liên quan phát triển Android như APK, ROM tùy chỉnh & chỉnh sửa, v.v. Nhưng dường như cũng chấp nhận tệp khác.
  * [borgbase.com](https://www.borgbase.com/) — Lưu trữ backup ngoài site đơn giản và bảo mật cho Borg Backup. 10 GB không gian backup miễn phí và hai kho lưu trữ.
  * [icedrive.net](https://www.icedrive.net/) - Dịch vụ lưu trữ đám mây đơn giản. 10 GB lưu trữ miễn phí.
  * [sync.com](https://www.sync.com/) - Dịch vụ lưu trữ đám mây mã hóa đầu-cuối. 5 GB lưu trữ miễn phí.
  * [pcloud.com](https://www.pcloud.com/) - Dịch vụ lưu trữ đám mây. Tối đa 10 GB lưu trữ miễn phí.
  * [sirv.com](https://sirv.com/) — CDN hình ảnh thông minh với tối ưu hóa và thay đổi kích thước hình ảnh theo thời gian thực. Gói miễn phí gồm 500 MB lưu trữ và 2 GB băng thông.
  * [cloudimage.io](https://www.cloudimage.io/en/home) — Dịch vụ tối ưu hóa hình ảnh và CDN đầy đủ với hơn 1500 điểm hiện diện toàn cầu. Đa dạng chức năng thay đổi kích thước, nén, đóng dấu hình ảnh. Plugin mã nguồn mở cho ảnh responsive, làm ảnh 360 và chỉnh sửa ảnh. Gói miễn phí hàng tháng gồm 25GB lưu lượng CDN, 25GB bộ nhớ đệm và biến đổi không giới hạn.
  * [cloudinary.com](https://cloudinary.com/) — Tải lên, chỉnh sửa mạnh mẽ, lưu trữ và phân phối hình ảnh cho website & ứng dụng, hỗ trợ Ruby, Python, Java, PHP, Objective-C, v.v. Gói miễn phí gồm 25 credit hàng tháng. Một credit tương ứng 1.000 biến đổi ảnh, 1 GB lưu trữ hoặc 1 GB CDN.
  * [embed.ly](https://embed.ly/) — Cung cấp API nhúng media vào trang web, thay đổi kích thước hình ảnh responsive, trích xuất thành phần web. Miễn phí cho tối đa 5.000 URL/tháng, 15 yêu cầu/giây.
  * [filestack.com](https://www.filestack.com/) — Chọn, chuyển đổi và phân phối tệp, miễn phí cho 250 tệp, 500 lần chuyển đổi, 3 GB băng thông.
  * [file.io](https://www.file.io) - 2 GB lưu trữ tệp. Tệp sẽ tự động xóa sau một lượt tải. Có REST API để tương tác. Giới hạn một yêu cầu/phút.
  * [freetools.site](https://freetools.site/) — Bộ công cụ trực tuyến miễn phí. Chuyển đổi hoặc chỉnh sửa tài liệu, hình ảnh, audio, video, v.v.
  * [GoFile.io](https://gofile.io/) - Nền tảng chia sẻ và lưu trữ tệp miễn phí, dùng qua giao diện web & API. Không giới hạn dung lượng tệp, băng thông, lượt tải, v.v. Nhưng tệp sẽ bị xóa nếu không có lượt tải trong hơn mười ngày.
  * [gumlet.com](https://www.gumlet.com/) — Lưu trữ, xử lý và phát hình ảnh, video qua CDN. Gói miễn phí hào phóng: 250 GB/tháng cho video và 30 GB/tháng cho hình ảnh.
  * [image-charts.com](https://www.image-charts.com/) — Tạo biểu đồ ảnh không giới hạn với watermark.
  * [Imgbot](https://github.com/marketplace/imgbot) — Imgbot là robot tối ưu hóa hình ảnh thân thiện, giúp giảm kích thước tệp mà không giảm chất lượng. Miễn phí cho mã nguồn mở.
  * [ImgBB](https://imgbb.com/) — ImgBB là dịch vụ lưu trữ ảnh không giới hạn. Kéo thả ảnh vào bất cứ đâu trên màn hình. Giới hạn 32 MB/ảnh. Nhận liên kết ảnh trực tiếp, BBCode và thumbnail HTML sau khi tải lên. Đăng nhập để xem lịch sử upload.
  * [imgen](https://www.jitbit.com/imgen/) - API tạo ảnh cover mạng xã hội không giới hạn, không watermark.
  * [imgix](https://www.imgix.com/) - Lưu trữ, quản lý và CDN hình ảnh. Gói miễn phí gồm 1000 ảnh nguồn, biến đổi không giới hạn và 100 GB băng thông.
  * [kraken.io](https://kraken.io/) — Tối ưu hóa hình ảnh cho hiệu năng website dạng dịch vụ, miễn phí cho tệp tối đa 1 MB.
  * [kvstore.io](https://www.kvstore.io/) — Dịch vụ lưu trữ key-value. Gói miễn phí cho 100 key, 1KB/key, 100 lượt gọi/giờ.
  * [npoint.io](https://www.npoint.io/) — Lưu trữ JSON với chức năng chỉnh sửa schema cộng tác.
  * [nitropack.io](https://nitropack.io/) - Tăng tốc website hoàn toàn tự động với tối ưu hóa frontend (cache, hình ảnh, mã, CDN). Miễn phí cho tối đa 5.000 lượt xem trang/tháng.
  * [otixo.com](https://www.otixo.com/) — Mã hóa, chia sẻ, sao chép, di chuyển tất cả tệp cloud tại một nơi. Gói cơ bản cho phép chuyển tệp không giới hạn, kích thước tệp tối đa 250 MB và 5 tệp mã hóa.
  * [packagecloud.io](https://packagecloud.io/) — Lưu trữ gói YUM, APT, RubyGem và PyPI. Có gói miễn phí giới hạn và gói cho mã nguồn mở qua yêu cầu.
  * [getpantry.cloud](https://getpantry.cloud/) — API lưu trữ dữ liệu JSON đơn giản, phù hợp cho dự án cá nhân, hackathon và ứng dụng di động!
  * [Pinata IPFS](https://pinata.cloud) — Pinata là cách đơn giản nhất để tải lên và quản lý tệp trên IPFS. Giao diện thân thiện và API IPFS giúp Pinata là dịch vụ pinning IPFS dễ dùng nhất cho nền tảng, nhà sáng tạo, nhà sưu tập. 1 GB lưu trữ miễn phí, kèm truy cập API.
  * [placekitten.com](https://placekitten.com/) — Dịch vụ nhanh chóng và đơn giản để lấy ảnh mèo dùng làm hình giữ chỗ.
  * [plot.ly](https://plot.ly/) — Vẽ và chia sẻ dữ liệu. Gói miễn phí gồm tệp công khai không giới hạn và 10 tệp riêng tư.
  * [podio.com](https://podio.com/) — Có thể dùng Podio với nhóm tối đa năm người và thử nghiệm các tính năng của Gói Cơ Bản, trừ quản lý người dùng.
  * [QRME.SH](https://qrme.sh) - Tạo mã QR hàng loạt nhanh, đẹp – không cần đăng nhập, không watermark, không quảng cáo. Tối đa 100 URL mỗi lần xuất hàng loạt.
  * [QuickChart](https://quickchart.io) — Tạo biểu đồ ảnh, đồ thị và mã QR nhúng.
  * [redbooth.com](https://redbooth.com) — Đồng bộ hóa tệp P2P, miễn phí cho tối đa 2 người dùng.
  * [resmush.it](https://resmush.it) — reSmush.it là API miễn phí cung cấp tối ưu hóa hình ảnh. Được tích hợp trên các CMS phổ biến như WordPress, Drupal, Magento. API tối ưu hóa hình ảnh được sử dụng nhiều nhất với hơn bảy tỷ ảnh đã xử lý, vẫn miễn phí hoàn toàn.
  * [Shotstack](https://shotstack.io) - API tạo và chỉnh sửa video quy mô lớn. Miễn phí tối đa 20 phút video render mỗi tháng.
  * [tinypng.com](https://tinypng.com/) — API nén và thay đổi kích thước ảnh PNG, JPEG, miễn phí 500 lần nén mỗi tháng.
  * [transloadit.com](https://transloadit.com/) — Xử lý tải lên và mã hóa video, audio, ảnh, tài liệu. Miễn phí cho mã nguồn mở, tổ chức từ thiện, sinh viên qua GitHub Student Developer Pack. Ứng dụng thương mại được dùng thử 2 GB miễn phí.
* [twicpics.com](https://www.twicpics.com) - Dịch vụ hình ảnh đáp ứng. Cung cấp CDN hình ảnh, API xử lý media và thư viện frontend để tự động tối ưu hóa hình ảnh. Miễn phí đến 3GB lưu lượng/tháng.
* [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare cung cấp chuỗi xử lý media với bộ công cụ tối ưu dựa trên các thuật toán tiên tiến. Tất cả tính năng đều miễn phí cho lập trình viên: API và UI tải lên file, CDN hình ảnh và dịch vụ nguồn, phân phối thích ứng và nén thông minh. Gói miễn phí có 3000 lượt tải lên, 3 GB lưu lượng và 3 GB lưu trữ.
* [imagekit.io](https://imagekit.io) – CDN hình ảnh với tối ưu tự động, chuyển đổi thời gian thực và lưu trữ, có thể tích hợp với hệ thống hiện tại chỉ trong vài phút. Gói miễn phí bao gồm tối đa 20GB băng thông mỗi tháng.
* [internxt.com](https://internxt.com) – Internxt Drive là dịch vụ lưu trữ file bảo mật tuyệt đối với chính sách không biết dữ liệu người dùng. Đăng ký và nhận 10 GB miễn phí, vĩnh viễn!
* [degoo.com](https://degoo.com/) – Lưu trữ đám mây dựa trên AI, miễn phí đến 20 GB, ba thiết bị, thưởng 5 GB cho giới thiệu (tài khoản không hoạt động 90 ngày sẽ bị hạn chế).
* [MConverter.eu](https://mconverter.eu/) – Chuyển đổi file hàng loạt. Hỗ trợ nhiều định dạng file, kể cả các định dạng mới như [AVIF](https://mconverter.eu/convert/to/avif/). Trích xuất tất cả khung hình ảnh từ video. Miễn phí cho tối đa mười file 100MB/ngày, xử lý theo từng lô hai file.
* [ImageEngine](https://imageengine.io/) – ImageEngine là CDN hình ảnh toàn cầu dễ dùng. Thiết lập dưới 60 giây. Hỗ trợ AVIF và JPEGXL, plugin cho WordPress, Magento, React, Vue và nhiều hơn nữa. Đăng ký tài khoản lập trình viên miễn phí [tại đây](https://imageengine.io/developer-program/).
* [DocsParse](https://docsparse.com/) – Xử lý AI dựa trên GPT cho PDF, hình ảnh thành dữ liệu có cấu trúc ở định dạng JSON, CSV, EXCEL. Miễn phí 30 credits mỗi tháng.
* [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – Tạo mã QR tùy chỉnh dễ dàng cho thẻ quà tặng, phiếu giảm giá, khuyến mại. Hỗ trợ tùy chỉnh kiểu dáng, màu sắc, logo...
* [LibreQR](https://libreqr.com) — Trình tạo mã QR miễn phí tập trung vào quyền riêng tư và không theo dõi người dùng. Miễn phí hoàn toàn, không thu thập dữ liệu.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Thiết kế và Giao diện người dùng

* [AllTheFreeStock](https://allthefreestock.com) - Danh sách tổng hợp ảnh, âm thanh và video miễn phí.
* [Float UI](https://floatui.com/) - Công cụ phát triển web miễn phí để tạo nhanh website hiện đại, đáp ứng với thiết kế đẹp mắt, ngay cả cho người không chuyên thiết kế.
* [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page cung cấp mẫu template xây dựng bằng các thành phần chuyển động của Ant Motion. Có nhiều mẫu trang chủ phong phú, tải mã template về và sử dụng nhanh chóng. Có thể dùng trình chỉnh sửa để tự xây trang riêng.
* [Backlight](https://backlight.dev/) — Nền tảng lập trình hoàn chỉnh với sự hợp tác giữa lập trình viên và nhà thiết kế, xây dựng, tài liệu hóa, xuất bản, mở rộng, và duy trì Design Systems. Gói miễn phí cho phép tối đa 3 biên tập viên làm việc trên 1 hệ thống thiết kế với số lượng người xem không giới hạn.
* [BoxySVG](https://boxy-svg.com/app) — Ứng dụng web cài đặt miễn phí để vẽ SVG và xuất ra các định dạng SVG, PNG, jpeg và nhiều định dạng khác.
* [Carousel Hero](https://carouselhero.com/) - Công cụ trực tuyến miễn phí để tạo carousel cho mạng xã hội.
* [Circum Icons](https://circumicons.com) - Bộ icon nhất quán mã nguồn mở dạng SVG cho React, Vue và Svelte.
* [clevebrush.com](https://www.cleverbrush.com/) — Ứng dụng thiết kế đồ họa / ghép ảnh miễn phí. Ngoài ra, họ cung cấp tích hợp trả phí như một thành phần.
* [cloudconvert.com](https://cloudconvert.com/) — Chuyển đổi bất kỳ định dạng nào sang định dạng khác. Hỗ trợ 208 định dạng bao gồm video và gif.
* [CodeMyUI](https://codemyui.com) - Bộ sưu tập các thiết kế web & cảm hứng UI được chọn lọc cùng code snippet.
* [ColorKit](https://colorkit.co/) - Tạo bảng màu trực tuyến hoặc lấy cảm hứng từ các bảng màu hàng đầu.
* [coolors](https://coolors.co/) - Công cụ tạo bảng màu. Miễn phí.
* [CMYK Pantone](https://www.cmyktopantone.com/) - Chuyển đổi giá trị CMYK sang màu Pantone gần nhất và các mô hình màu khác miễn phí chỉ trong vài giây.
* [Branition](https://branition.com/colors) - Bảng màu được tuyển chọn phù hợp nhất cho thương hiệu.
* [css-gradient.com](https://www.css-gradient.com/) - Công cụ miễn phí tạo gradient CSS tùy chỉnh nhanh chóng, hỗ trợ cross-browser. Định dạng RGB và HEX.
* [easyvectors.com](https://easyvectors.com/) — Kho vector SVG miễn phí. Tải về đồ họa vector chất lượng cao hoàn toàn miễn phí.
* [figma.com](https://www.figma.com) — Công cụ thiết kế cộng tác trực tuyến cho nhóm; gói miễn phí gồm file và người xem không giới hạn, tối đa 2 biên tập viên và 3 dự án.
* [Flyon UI](https://flyonui.com/)- Thư viện thành phần Tailwind CSS dễ sử dụng nhất.
* [framer.com](https://www.framer.com/) - Framer giúp bạn lặp lại ý tưởng giao diện và tạo chuyển động cho app, website hoặc sản phẩm tiếp theo với bố cục mạnh mẽ. Cho ai xác thực Framer là công cụ prototyping chuyên nghiệp: không giới hạn người xem, tối đa 2 biên tập viên, 3 dự án.
* [freeforcommercialuse.net](https://freeforcommercialuse.net/) — Ảnh stock mẫu/model, tài sản đã được phát hành miễn phí sử dụng thương mại.
* [Gradientos](https://www.gradientos.app) - Giúp chọn gradient nhanh và dễ dàng.
* [Icon Horse](https://icon.horse) – Lấy favicon độ phân giải cao nhất cho bất kỳ website nào qua API đơn giản.
* [Iconoir](https://iconoir.com) – Thư viện icon mã nguồn mở với hàng nghìn icon, hỗ trợ React, React Native, Flutter, Vue, Figma, Framer.
* [Icons8](https://icons8.com) — Icon, minh họa, ảnh, nhạc và công cụ thiết kế. Gói miễn phí cung cấp định dạng giới hạn ở độ phân giải thấp. Yêu cầu dẫn link đến Icons8 khi sử dụng tài nguyên.
* [landen.co](https://www.landen.co) — Tạo, chỉnh sửa và xuất bản website và landing page đẹp cho startup mà không cần code. Gói miễn phí cho phép 1 website, tuỳ chỉnh đầy đủ và xuất bản lên web.
* [Quant Ux](https://quant-ux.com/) - Công cụ thiết kế và prototyping. Hoàn toàn miễn phí và mã nguồn mở.
* [lensdump.com](https://lensdump.com/) - Lưu trữ hình ảnh đám mây miễn phí.
* [Lorem Picsum](https://picsum.photos/) - Công cụ miễn phí, dễ dùng, tạo hình ảnh placeholder đẹp mắt. Chỉ cần thêm kích thước ảnh vào URL để nhận ảnh ngẫu nhiên.
* [LottieFiles](https://lottiefiles.com/) - Nền tảng trực tuyến lớn nhất cho định dạng animation nhỏ nhất thế giới dành cho designer, developer... Truy cập công cụ và plugin Lottie cho Android, iOS, Web.
* [MagicPattern](https://www.magicpattern.design/tools) — Bộ công cụ tạo CSS & SVG background cho gradient, pattern, blob...
* [marvelapp.com](https://marvelapp.com/) — Thiết kế, tạo prototype và cộng tác, gói miễn phí giới hạn một người dùng và một dự án.
* [Mindmup.com](https://www.mindmup.com/) — Vẽ mind map không giới hạn miễn phí và lưu trữ trên cloud. Mindmap có mặt ở mọi nơi, tức thì, trên mọi thiết bị.
* [Mockplus iDoc](https://www.mockplus.com/idoc) - Công cụ cộng tác thiết kế & chuyển giao mạnh mẽ. Gói miễn phí gồm 3 người dùng và 5 dự án, đầy đủ tính năng.
* [mockupmark.com](https://mockupmark.com/create/free) — Tạo mockup áo thun và quần áo thực tế cho mạng xã hội và thương mại điện tử, 40 mockup miễn phí.
* [Mossaik](https://mossaik.app) - Trình tạo ảnh SVG miễn phí với nhiều công cụ như waves, blog và pattern.
* [movingpencils.com](https://movingpencils.com) — Trình biên tập vector trên trình duyệt cực nhanh. Hoàn toàn miễn phí.
* [Octopus.do](https://octopus.do) — Công cụ vẽ sơ đồ trang web trực quan. Xây dựng cấu trúc website theo thời gian thực và chia sẻ nhanh với nhóm hoặc khách hàng.
* [Pencil](https://github.com/evolus/pencil) - Công cụ thiết kế mã nguồn mở dùng Electron.
* [Penpot](https://penpot.app) - Công cụ thiết kế và prototyping web-based, mã nguồn mở. Hỗ trợ SVG. Hoàn toàn miễn phí.
* [pexels.com](https://www.pexels.com/) - Ảnh stock miễn phí cho mục đích thương mại. Có API miễn phí tìm kiếm ảnh theo từ khóa.
* [photopea.com](https://www.photopea.com) — Trình chỉnh sửa thiết kế trực tuyến miễn phí, giao diện giống Adobe Photoshop, hỗ trợ PSD, XCF & Sketch (Adobe Photoshop, Gimp, Sketch App).
* [pixlr.com](https://pixlr.com/) — Trình chỉnh sửa ảnh trực tuyến miễn phí, mạnh mẽ ngang các phần mềm thương mại.
* [Plasmic](https://www.plasmic.app/) - Công cụ thiết kế web và trình tạo trang mạnh mẽ, dễ dùng, tích hợp vào codebase. Tạo trang đáp ứng hoặc thành phần phức tạp, mở rộng với code nếu cần và xuất bản lên site/app.
* [Pravatar](https://pravatar.cc/) - Tạo avatar ngẫu nhiên/placeholder dạng fake có thể lấy link trực tiếp trong web/app.
* [Proto.io](https://www.proto.io) - Tạo prototype UI hoàn toàn tương tác mà không cần code. Gói miễn phí khi hết thử nghiệm, gồm 1 người dùng, 1 dự án, 5 prototype, 100MB lưu trữ, xem trước app proto.io.
* [resizeappicon.com](https://resizeappicon.com/) — Dịch vụ đơn giản để thay đổi kích thước và quản lý icon app.
* [Rive](https://rive.app) — Tạo và xuất bản animation đẹp cho mọi nền tảng. Miễn phí vĩnh viễn cho cá nhân. Dịch vụ là trình biên tập đồng thời lưu trữ đồ họa trên server của họ. Cung cấp runtime cho nhiều nền tảng để chạy animation tạo bằng Rive.
* [storyset.com](https://storyset.com/) — Tạo minh hoạ tùy chỉnh miễn phí tuyệt vời cho dự án của bạn bằng công cụ này.
* [smartmockups.com](https://smartmockups.com/) — Tạo mockup sản phẩm, 200 mockup miễn phí.
* [Shadcn Studio](https://shadcnstudio.com/theme-editor) — Xem trước thay đổi theme của bạn trên các thành phần và bố cục khác nhau.
* [Tailark](https://tailark.com/) - Bộ sưu tập các block UI hiện đại, đáp ứng, dựng sẵn cho website marketing.
* [tabler-icons.io](https://tabler-icons.io/) — Hơn 1500 icon SVG miễn phí, có thể copy-paste và chỉnh sửa.
* [tweakcn](https://tweakcn.com/) — Bộ theme đẹp cho shadcn/ui. Tùy chỉnh màu sắc, font chữ, ... theo thời gian thực.
* [UI Avatars](https://ui-avatars.com/) - Tạo avatar từ chữ cái đầu tên, có thể lấy link trực tiếp trên web/app. Hỗ trợ tham số cấu hình qua URL.
* [unDraw](https://undraw.co/) - Bộ sưu tập SVG đẹp liên tục cập nhật, dùng miễn phí hoàn toàn không cần ghi nguồn.
* [unsplash.com](https://unsplash.com/) - Ảnh stock miễn phí cho mục đích thương mại và phi thương mại (giấy phép do-whatever-you-want).
* [vectr.com](https://vectr.com/) — Ứng dụng thiết kế miễn phí cho Web + Desktop.
* [walkme.com](https://www.walkme.com/) — Nền tảng hướng dẫn và tương tác doanh nghiệp, miễn phí 3 walkthrough tối đa 5 bước/walk.
* [Webflow](https://webflow.com) - Trình tạo website WYSIWYG với animation và hosting. Miễn phí cho 2 dự án.
* [Updrafts.app](https://updrafts.app) - Trình tạo website WYSIWYG cho thiết kế dựa trên tailwindcss. Miễn phí cho mục đích phi thương mại.
* [whimsical.com](https://whimsical.com/) - Vẽ lưu đồ, wireframe, sticky note và mindmap cộng tác. Tạo tối đa 4 bảng miễn phí.
* [Zeplin](https://zeplin.io/) — Nền tảng cộng tác giữa designer và developer. Hiển thị thiết kế, tài sản, style guide. Miễn phí cho một dự án.
* [Pixelixe](https://pixelixe.com/) — Tạo và chỉnh sửa đồ họa, hình ảnh online độc đáo, hấp dẫn.
* [Responsively App](https://responsively.app) - Công cụ dev miễn phí để phát triển web đáp ứng nhanh và chính xác hơn.
* [SceneLab](https://scenelab.io) - Trình biên tập mockup online với bộ template thiết kế miễn phí liên tục mở rộng.
* [xLayers](https://xlayers.dev) - Xem trước và chuyển đổi file thiết kế Sketch sang Angular, React, Vue, LitElement, Stencil, Xamarin và nhiều hơn nữa (miễn phí, mã nguồn mở tại https://github.com/xlayers/xlayers)
* [Grapedrop](https://grapedrop.com/) — Trình tạo trang web mạnh mẽ, đáp ứng, tối ưu SEO dựa trên GrapesJS Framework. Miễn phí 5 trang đầu tiên, không giới hạn domain tùy chỉnh, đầy đủ tính năng, dễ sử dụng.
* [Mastershot](https://mastershot.app) - Trình biên tập video trên trình duyệt miễn phí hoàn toàn. Không watermark, xuất video tối đa 1080p.
* [Unicorn Platform](https://unicornplatform.com/) - Trình tạo landing page đơn giản kèm hosting. Một website miễn phí.
* [SVGmix.com](https://www.svgmix.com/) - Kho 300.000+ icon SVG, bộ sưu tập và logo thương hiệu miễn phí. Có chương trình biên tập vector trực tiếp trên trình duyệt để chỉnh sửa file nhanh.
* [svgrepo.com](https://www.svgrepo.com/) - Tìm kiếm, khám phá icon hoặc vector phù hợp cho dự án với nhiều thư viện vector. Tải SVG miễn phí cho mục đích thương mại.
* [haikei.app](https://www.haikei.app/) - Ứng dụng web tạo hình SVG, background, pattern độc đáo sẵn sàng dùng cho công cụ thiết kế và quy trình làm việc của bạn.
* [Canva](https://canva.com) - Công cụ thiết kế trực tuyến miễn phí để tạo nội dung hình ảnh.
* [Superdesigner](https://superdesigner.co) - Bộ công cụ thiết kế miễn phí tạo background, pattern, shape, ảnh độc đáo chỉ với vài cú click.
* [TeleportHQ](https://teleporthq.io/) - Nền tảng thiết kế & phát triển front-end low-code. Tạo và xuất bản website static headless tức thì, 3 dự án miễn phí, không giới hạn cộng tác viên, xuất mã nguồn miễn phí.
* [vector.express](https://vector.express) — Chuyển đổi nhanh chóng và dễ dàng vector AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS và SVG.
* [Vertopal](https://www.vertopal.com) - Nền tảng chuyển đổi định dạng file trực tuyến miễn phí. Bao gồm các trình chuyển đổi cho lập trình viên như JPG sang SVG, GIF sang APNG, PNG sang WEBP, JSON sang XML,...
* [okso.app](https://okso.app) - Ứng dụng vẽ online tối giản. Tạo phác thảo nhanh và ghi chú trực quan. Xuất PNG, JPG, SVG, WEBP. Có thể cài đặt dạng PWA. Miễn phí cho tất cả (không cần đăng ký).
* [Wdrfree SVG](https://wdrfree.com/free-svg) - File SVG cắt trắng đen miễn phí.
* [Lucide](https://lucide.dev) - Bộ công cụ icon SVG tùy chỉnh và nhất quán miễn phí.
* [Logo.dev](https://www.logo.dev) - API logo công ty với hơn 44 triệu thương hiệu, dễ dàng gọi qua URL. 10.000 lượt gọi API miễn phí đầu tiên.
* [MDBootstrap](https://mdbootstrap.com/) - Bộ UI Kit miễn phí cho cá nhân & thương mại cho Bootstrap, Angular, React, Vue với hơn 700 thành phần, template đẹp, cài đặt 1 phút, hướng dẫn đầy đủ, cộng đồng lớn.
* [TW Elements](https://tw-elements.com/) - Thành phần Bootstrap miễn phí tái tạo với Tailwind CSS, thiết kế đẹp hơn và nhiều tính năng hơn.
* [DaisyUI](https://daisyui.com/) -- Miễn phí. "Dùng Tailwind CSS nhưng ít class hơn", cung cấp các thành phần như button.
  * [Scrollbar.app](https://scrollbar.app) -- Ứng dụng web miễn phí đơn giản để thiết kế thanh cuộn tùy chỉnh cho web.
  * [css.glass](https://css.glass/) -- Ứng dụng web miễn phí để tạo các thiết kế hiệu ứng kính mờ bằng CSS.
  * [hypercolor.dev](https://hypercolor.dev/) -- Bộ sưu tập các dải màu gradient Tailwind CSS được tuyển chọn, đồng thời cung cấp nhiều công cụ tạo gradient để bạn tự tạo.
  * [iconify.design](https://icon-sets.iconify.design/) -- Bộ sưu tập hơn 100 bộ biểu tượng với giao diện thống nhất. Cho phép tìm kiếm biểu tượng trên nhiều bộ và xuất từng biểu tượng dưới dạng SVG hoặc cho các framework web phổ biến.
  * [NextUI](https://nextui.org/) -- Miễn phí. Thư viện giao diện React & Next.js đẹp, nhanh và hiện đại.
  * [Glyphs](https://glyphs.fyi/) -- Miễn phí, Bộ biểu tượng mạnh mẽ nhất trên web, hệ thống thiết kế hoàn toàn có thể chỉnh sửa & mã nguồn mở thực sự.
  * [ShadcnUI](https://ui.shadcn.com/) -- Các thành phần giao diện được thiết kế đẹp mắt, bạn có thể sao chép và dán vào ứng dụng của mình. Hỗ trợ truy cập. Dễ tùy chỉnh. Mã nguồn mở.
  * [HyperUI](https://www.hyperui.dev/) -- Thành phần Tailwind CSS mã nguồn mở miễn phí.
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- Tạo bộ biểu tượng lịch cho cả năm chỉ với một cú nhấp chuột, hoàn toàn MIỄN PHÍ
  * [Image BG Blurer](https://imagebgblurer.com/) -- Tạo khung nền mờ cho hình ảnh, sử dụng chính hình ảnh đó làm nền mờ, dùng cho Notion, Trello, Jira và nhiều công cụ khác
  * [Webstudio](https://webstudio.is/) -- Giải pháp mã nguồn mở thay thế Webflow. Gói miễn phí cho phép tạo website không giới hạn trên tên miền của họ. Năm website với tên miền riêng. 10.000 lượt xem trang/tháng. 2 GB lưu trữ tài nguyên.
  * [Nappy](https://nappy.co/) -- Ảnh đẹp của người da Đen và da Nâu, miễn phí. Cho sử dụng thương mại và cá nhân.
  * [Tailkits](https://tailkits.com/) -- Bộ sưu tập mẫu, thành phần, công cụ Tailwind được tuyển chọn, kèm theo nhiều công cụ hữu ích để sinh code, lưới, bóng hộp và nhiều hơn nữa.
  * [Tailcolors](https://tailcolors.com/) -- Bảng màu đẹp cho Tailwind CSS v4. Xem trước & sao chép nhanh lớp màu Tailwind CSS phù hợp.
  * [Excalidraw](https://excalidraw.com/) -- Ứng dụng vẽ trực tuyến miễn phí, cho phép lưu vào máy và xuất file miễn phí.
  * [Lunacy](https://icons8.com/lunacy) -- Công cụ thiết kế đồ họa miễn phí, hỗ trợ offline, tích hợp sẵn tài nguyên (icon, ảnh, minh họa) và cộng tác thời gian thực. Gói miễn phí gồm 10 tài liệu cloud, lịch sử 30 ngày, tài nguyên độ phân giải thấp và công cụ thiết kế cơ bản.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Cảm Hứng Thiết Kế

  * [awwwards.](https://www.awwwards.com/) - [Website hàng đầu] Bộ sưu tập các website được thiết kế đẹp nhất (được bình chọn bởi các nhà thiết kế).
  * [Behance](https://www.behance.net/) - [Showcase thiết kế] Nơi các nhà thiết kế trưng bày tác phẩm của mình. Có thể lọc theo nhiều danh mục dự án UI/UX.
  * [dribbble](https://dribbble.com/) - [Showcase thiết kế] Nguồn cảm hứng thiết kế độc đáo, thường không đến từ ứng dụng thực tế.
  * [Landings](https://landings.dev/) - [Ảnh chụp website] Tìm các trang landing page tốt nhất làm cảm hứng thiết kế dựa trên sở thích của bạn.
  * [Lapa Ninja](https://www.lapa.ninja/) - [Landing page / UI Kits / Ảnh chụp website] Bộ sưu tập với 6025 ví dụ landing page xuất sắc, sách miễn phí và UI kits miễn phí từ khắp nơi trên web.
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [Thiết kế Landing Page] Ảnh chụp landing page được cập nhật thường xuyên. Bao gồm ảnh Desktop, Tablet và Mobile.
  * [Mobbin](https://mobbin.design/) - [Ảnh chụp màn hình di động] Tiết kiệm hàng giờ nghiên cứu UI & UX với thư viện hơn 50.000 ảnh chụp màn hình ứng dụng di động, có thể tìm kiếm đầy đủ.
  * [Uiland Design](https://uiland.design/) - [Ảnh chụp màn hình di động] Khám phá các thiết kế UI Mobile và Web từ các công ty hàng đầu tại Châu Phi và thế giới.
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [Ảnh chụp màn hình di động] Thư viện cảm hứng thiết kế với những mẫu UI UX đẹp nhất (iOS và Android) dành cho nhà thiết kế, lập trình viên và nhà phát triển sản phẩm tham khảo.
  * [Page Flows](https://pageflows.com/) - [Video và ảnh chụp mobile/web] Video luồng thao tác đầy đủ trên nhiều ứng dụng di động và web. Cũng có ảnh chụp màn hình. Tìm kiếm và phân loại dễ dàng.
  * [Screenlane](https://screenlane.com/) - [Ảnh chụp màn hình di động] Lấy cảm hứng và cập nhật xu hướng thiết kế UI web & mobile mới nhất. Có thể lọc theo mẫu và ứng dụng.
  * [scrnshts](https://scrnshts.club/) - [Ảnh chụp màn hình di động] Bộ sưu tập thủ công các ảnh chụp màn hình thiết kế ứng dụng đẹp nhất trên App Store.
  * [Refero](https://refero.design/) - [Ảnh chụp website] Bộ sưu tập tài liệu tham khảo thiết kế từ các ứng dụng web xuất sắc, có gắn thẻ và tìm kiếm.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Trực Quan Dữ Liệu Trên Bản Đồ

  * [IP Geolocation](https://ipgeolocation.io/) — Có gói DEVELOPER miễn phí với 30.000 yêu cầu/tháng.
  * [carto.com](https://carto.com/) — Tạo bản đồ và API địa lý từ dữ liệu của bạn và dữ liệu công khai.
  * [Clockwork Micro](https://clockworkmicro.com/) — Công cụ bản đồ hoạt động hiệu quả. 50.000 truy vấn miễn phí mỗi tháng (bản đồ lát, db2vector, độ cao).
  * [developers.arcgis.com](https://developers.arcgis.com) — API và SDK cho bản đồ, lưu trữ dữ liệu địa lý, phân tích, định vị, định tuyến, v.v. trên web, máy tính để bàn, di động. Hai triệu ô bản đồ cơ sở miễn phí, 20.000 địa chỉ không lưu trữ, 20.000 tuyến đường đơn giản, 5.000 phép tính thời gian di chuyển và 5GB lưu trữ ô+data miễn phí mỗi tháng.
  * [Foursquare](https://developer.foursquare.com/) - Khám phá vị trí, tìm kiếm địa điểm và nội dung theo ngữ cảnh từ Places API và Pilgrim SDK.
  * [geoapify.com](https://www.geoapify.com/) - Bản đồ vector, raster, geocoding, places, routing, isolines API. 3.000 yêu cầu miễn phí/ngày.
  * [geocod.io](https://www.geocod.io/) — Geocoding qua API hoặc tải lên CSV. 2.500 truy vấn miễn phí/ngày.
  * [geocodify.com](https://geocodify.com/) — Geocoding và Geoparsing qua API hoặc tải lên CSV. 10.000 truy vấn miễn phí/tháng.
  * [geojs.io](https://www.geojs.io/) - API tra cứu vị trí IP REST/JSON/JSONP có tính sẵn sàng cao.
  * [giscloud.com](https://www.giscloud.com/) — Trực quan hóa, phân tích và chia sẻ dữ liệu địa lý trực tuyến.
  * [graphhopper.com](https://www.graphhopper.com/) Cung cấp gói lập trình miễn phí cho Định tuyến, Tối ưu hóa tuyến đường, Ma trận khoảng cách, Geocoding, Map Matching.
  * [here](https://developer.here.com/) — API và SDK cho bản đồ và ứng dụng theo vị trí. 250.000 giao dịch/tháng miễn phí.
  * [locationiq.com](https://locationiq.com/) — API Geocoding, Maps và Routing. 5.000 yêu cầu/ngày miễn phí.
  * [mapbox.com](https://www.mapbox.com/) — Bản đồ, dịch vụ địa lý và SDK để hiển thị dữ liệu bản đồ.
  * [maptiler.com](https://www.maptiler.com/cloud/) — Bản đồ vector, dịch vụ bản đồ và SDK cho trực quan hóa bản đồ. Miễn phí bản đồ vector cập nhật hàng tuần và bốn kiểu bản đồ.
  * [nominatim.org](https://nominatim.org/) — Dịch vụ geocoding miễn phí của OpenStreetMap, cung cấp tìm kiếm địa chỉ toàn cầu và khả năng geocoding ngược.
  * [nextbillion.ai](https://nextbillion.ai/) - Dịch vụ liên quan đến bản đồ: Geocoding, Điều hướng (Chỉ đường, Định tuyến, Tối ưu hóa tuyến đường, Ma trận khoảng cách), Maps SDK (Vector, Static, Mobile SDK). [Miễn phí với hạn mức quy định](https://nextbillion.ai/pricing) cho từng dịch vụ.
  * [opencagedata.com](https://opencagedata.com) — API geocoding tổng hợp OpenStreetMap và các nguồn địa lý mở khác. 2.500 truy vấn miễn phí/ngày.
  * [osmnames](https://osmnames.org/) — Geocoding, kết quả tìm kiếm được xếp hạng theo độ phổ biến của trang Wikipedia liên quan.
  * [positionstack](https://positionstack.com/) - Geocoding miễn phí cho địa điểm và tọa độ toàn cầu. 25.000 yêu cầu mỗi tháng cho mục đích cá nhân.
  * [stadiamaps.com](https://stadiamaps.com/) — Bản đồ lát, định tuyến, điều hướng và các API địa lý khác. 2.500 lượt xem bản đồ và yêu cầu API miễn phí/ngày cho mục đích phi thương mại và thử nghiệm.
  * [maps.stamen.com](http://maps.stamen.com/) - Miễn phí bản đồ lát và dịch vụ lưu trữ bản đồ lát.
  * [ipstack](https://ipstack.com/) - Xác định vị trí và nhận diện khách truy cập website qua địa chỉ IP.
  * [Geokeo api](https://geokeo.com) - API geocoding hỗ trợ chỉnh sửa ngôn ngữ và nhiều tính năng khác. Bao phủ toàn cầu. 2.500 truy vấn miễn phí mỗi ngày.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Hệ Thống Xây Dựng Gói Phần Mềm

  * [build.opensuse.org](https://build.opensuse.org/) — Dịch vụ xây dựng gói phần mềm cho nhiều bản phân phối (SUSE, EL, Fedora, Debian, v.v.).
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Dịch vụ xây dựng RPM dựa trên Mock cho Fedora và EL.
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — Dịch vụ xây dựng gói cho Ubuntu và Debian.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## IDE và Trình Soạn Thảo Mã

  * [3v4l](https://3v4l.org/) - Shell PHP trực tuyến miễn phí và trang chia sẻ đoạn mã, cho phép chạy mã trên hơn 300 phiên bản PHP
  * [Android Studio](https://developer.android.com/studio) — Android Studio cung cấp công cụ nhanh nhất để xây dựng ứng dụng trên mọi thiết bị Android. IDE mã nguồn mở miễn phí cho tất cả mọi người, phù hợp nhất cho phát triển ứng dụng Android. Hỗ trợ Windows, Mac, Linux và cả ChromeOS!
  * [AndroidIDE](https://m.androidide.com/) — IDE mã nguồn mở để phát triển ứng dụng Android thực sự (dựa trên Gradle) ngay trên thiết bị Android.
  * [Apache Netbeans](https://netbeans.apache.org/) — Môi trường phát triển, nền tảng công cụ và framework ứng dụng.
  * [apiary.io](https://apiary.io/) — Thiết kế API cộng tác với mô phỏng API tức thì và tạo tài liệu (Miễn phí cho blueprint API không giới hạn và người dùng không giới hạn với một tài khoản quản trị và tài liệu được lưu trữ).
  * [BBEdit](https://www.barebones.com/) - BBEdit là trình soạn thảo phổ biến và mở rộng trên macOS. Chế độ miễn phí cung cấp [bộ tính năng lõi mạnh mẽ](https://www.barebones.com/products/bbedit/comparison.html) và có thể nâng cấp lên các tính năng nâng cao.
  * [Binder](https://mybinder.org/) - Chuyển đổi repo Git thành bộ sổ tay tương tác. Là dịch vụ công cộng miễn phí.
  * [BlueJ](https://bluej.org) — Môi trường phát triển Java miễn phí dành cho người mới, được hàng triệu người sử dụng toàn cầu. Được hỗ trợ bởi Oracle & giao diện đơn giản cho người mới học.
  * [Bootify.io](https://bootify.io/) - Trình sinh ứng dụng Spring Boot với cơ sở dữ liệu và REST API tùy chỉnh.
  * [Brackets](http://brackets.io/) - Trình soạn thảo mã nguồn mở chuyên biệt cho phát triển web. Nhẹ, dễ sử dụng và tùy chỉnh cao.
  * [cacher.io](https://www.cacher.io) — Trình quản lý đoạn mã với nhãn và hỗ trợ hơn 100 ngôn ngữ lập trình.
  * [Code::Blocks](https://codeblocks.org) — IDE miễn phí cho Fortran & C/C++. Mã nguồn mở, hỗ trợ Windows, macOS & Linux.
  * [Cody](https://sourcegraph.com/cody) - Trợ lý lập trình AI miễn phí có thể viết (khối mã, tự động hoàn thiện, unit test), hiểu (kiến thức toàn bộ mã nguồn), sửa lỗi và tìm kiếm mã. Hỗ trợ VS Code, JetBrains và Online.
  * [codiga.io](https://codiga.io/) — Trợ lý lập trình cho phép tìm kiếm, định nghĩa và tái sử dụng đoạn mã trực tiếp trong IDE. Miễn phí cho cá nhân và tổ chức nhỏ.
  * [codesnip.com.br](https://codesnip.com.br) — Trình quản lý đoạn mã đơn giản với danh mục, tìm kiếm và thẻ. Miễn phí và không giới hạn.
  * [cocalc.com](https://cocalc.com/) — (trước đây là SageMathCloud tại cloud.sagemath.com) — Tính toán cộng tác trên đám mây. Truy cập trình duyệt vào Ubuntu đầy đủ với hỗ trợ cộng tác và nhiều phần mềm miễn phí cho toán học, khoa học, khoa học dữ liệu, cài sẵn: Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn, v.v.
  * [code.cs50.io](https://code.cs50.io/) - Visual Studio Code cho CS50 là ứng dụng web tại code.cs50.io, điều chỉnh từ GitHub Codespaces cho sinh viên và giáo viên.
  * [codepen.io](https://codepen.io/) — CodePen là sân chơi cho front-end web.
  * [codesandbox.io](https://codesandbox.io/) — Sân chơi trực tuyến cho React, Vue, Angular, Preact, và nhiều hơn nữa.
  * [Components.studio](https://webcomponents.dev/) - Lập trình component trong môi trường biệt lập, trực quan hóa qua stories, kiểm thử và xuất bản lên npm.
  * [Eclipse Che](https://www.eclipse.org/che/) - IDE dựa trên web và Kubernetes-native cho đội ngũ phát triển, hỗ trợ đa ngôn ngữ. Mã nguồn mở và phát triển cộng đồng. Có phiên bản online do Red Hat host tại [workspaces.openshift.com](https://workspaces.openshift.com/).
  * [fakejson.com](https://fakejson.com/) — FakeJSON giúp bạn nhanh chóng tạo dữ liệu giả qua API. Gửi yêu cầu API mô tả bạn muốn gì, API sẽ trả về dữ liệu JSON tương ứng. Tăng tốc quá trình thử nghiệm ý tưởng và “giả lập” cho đến khi thực hiện được thật.
  * [GetVM](https://getvm.io) — Linux và IDE chrome sidebar miễn phí ngay lập tức. Gói miễn phí gồm 5 máy ảo mỗi ngày.
  * [GitPod](https://www.gitpod.io) — Môi trường phát triển sẵn sàng để lập trình tức thì cho các dự án GitHub. Gói miễn phí bao gồm 50 giờ/tháng.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE là một IDE đầy đủ trên đám mây. Hỗ trợ đa ngôn ngữ, container dựa trên Linux thông qua terminal dựa trên web đầy đủ tính năng, chuyển tiếp cổng, URL tùy chỉnh, cộng tác và trò chuyện thời gian thực, chia sẻ liên kết, hỗ trợ Git/Subversion. Có rất nhiều tính năng khác (Gói miễn phí bao gồm 1GB RAM và 10GB lưu trữ cho mỗi container, 5 slot Container).
  * [JDoodle](https://www.jdoodle.com) — Trình biên dịch và chỉnh sửa trực tuyến cho hơn 60 ngôn ngữ lập trình với gói miễn phí cho REST API biên dịch mã lên đến 200 credit mỗi ngày.
  * [jetbrains.com](https://jetbrains.com/products.html) — Công cụ năng suất, IDE và công cụ triển khai (như [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/), v.v.). Miễn phí bản quyền cho sinh viên, giáo viên, nguồn mở và các nhóm người dùng.
  * [jsbin.com](https://jsbin.com) — JS Bin là một playground và trang chia sẻ mã cho web front-end (HTML, CSS và JavaScript. Cũng hỗ trợ Markdown, Jade và Sass).
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle là một playground và trang chia sẻ mã cho web front-end, hỗ trợ cộng tác.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) Một số endpoint REST API trả về dữ liệu giả ở định dạng JSON. Mã nguồn cũng có sẵn nếu bạn muốn chạy máy chủ cục bộ.
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus là một IDE đa nền tảng tương thích với Delphi để phát triển ứng dụng nhanh.
  * [MarsCode](https://www.marscode.com/) - IDE dựa trên đám mây miễn phí, sử dụng trí tuệ nhân tạo.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - Dịch vụ vi mô API giả nhỏ gọn để tạo dữ liệu JSON giả.
  * [mockable.io](https://www.mockable.io/) — Mockable là một dịch vụ cấu hình đơn giản để mô phỏng RESTful API hoặc dịch vụ web SOAP. Dịch vụ trực tuyến này cho phép bạn nhanh chóng xác định endpoint REST API hoặc SOAP và trả về dữ liệu JSON hoặc XML.
  * [mockaroo](https://mockaroo.com/) — Mockaroo cho phép bạn tạo dữ liệu kiểm thử thực tế ở các định dạng CSV, JSON, SQL và Excel. Bạn cũng có thể tạo mô phỏng cho API back-end.
  * [Mocklets](https://mocklets.com) - Trình giả lập mock API dựa trên HTTP giúp mô phỏng API để phát triển song song nhanh hơn và kiểm thử toàn diện hơn, có gói miễn phí trọn đời.
  * [Paiza](https://paiza.cloud/en/) — Phát triển ứng dụng Web trong trình duyệt mà không cần thiết lập bất cứ thứ gì. Gói miễn phí cung cấp một máy chủ với thời gian tồn tại 24 giờ và 4 giờ chạy mỗi ngày với 2 lõi CPU, 2 GB RAM và 1 GB lưu trữ.
  * [Prepros](https://prepros.io/) - Prepros có thể biên dịch Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript và TypeScript ngay lập tức, tự động tải lại trình duyệt và giúp bạn dễ dàng phát triển & kiểm thử website để bạn có thể tập trung hoàn thiện chúng. Bạn cũng có thể thêm công cụ của riêng mình chỉ với vài cú nhấp chuột.
  * [Replit](https://replit.com/) — Môi trường lập trình đám mây cho nhiều ngôn ngữ lập trình khác nhau.
  * [SoloLearn](https://code.sololearn.com) — Playground lập trình đám mây phù hợp để chạy các đoạn mã. Hỗ trợ nhiều ngôn ngữ lập trình. Không cần đăng ký để chạy mã, nhưng cần đăng ký khi lưu mã lên nền tảng của họ. Cũng cung cấp các khóa học miễn phí cho người mới bắt đầu và lập trình viên trung cấp.
  * [stackblitz.com](https://stackblitz.com/) — IDE mã nguồn trực tuyến/đám mây để tạo, chỉnh sửa và triển khai ứng dụng full-stack. Hỗ trợ mọi framework frontend & backend dựa trên NodeJs phổ biến. Liên kết nhanh để tạo dự án mới: [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text là trình soạn thảo văn bản nổi tiếng, đa năng và có khả năng tùy biến cao được sử dụng cho lập trình và chỉnh sửa văn bản.
  * [Visual Studio Code](https://code.visualstudio.com/) - Trình soạn thảo mã được định nghĩa lại và tối ưu hóa cho việc xây dựng và gỡ lỗi các ứng dụng web và đám mây hiện đại. Được phát triển bởi Microsoft.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — IDE đầy đủ tính năng với hàng nghìn extension, phát triển ứng dụng đa nền tảng (có thể tải extension Microsoft cho iOS và Android), phát triển desktop, web và đám mây, hỗ trợ đa ngôn ngữ (C#, C++, JavaScript, Python, PHP và nhiều hơn nữa).
  * [VSCodium](https://vscodium.com/) - Phân phối nhị phân cộng đồng, không có telemetry/theo dõi, và được cấp phép tự do của trình soạn thảo Microsoft VSCode
  * [wakatime.com](https://wakatime.com/) — Đo lường hoạt động lập trình của bạn bằng plugin cho trình soạn thảo văn bản, gói giới hạn miễn phí.
  * [Wave Terminal](https://waveterm.dev/) - Wave là terminal mã nguồn mở, đa nền tảng cho quy trình làm việc liền mạch. Hiển thị bất cứ thứ gì trực tiếp. Lưu phiên và lịch sử. Dựa trên chuẩn web mở. Hỗ trợ MacOS và Linux.
  * [WebComponents.dev](https://webcomponents.dev/) — IDE trong trình duyệt để lập trình web component một cách biệt lập với 58 mẫu có sẵn, hỗ trợ stories và kiểm thử.
  * [PHPSandbox](https://phpsandbox.io/) — Môi trường phát triển trực tuyến cho PHP
  * [WebDB](https://webdb.app) - IDE cơ sở dữ liệu miễn phí hiệu quả. Có tính năng phát hiện máy chủ, ERD, tạo dữ liệu, AI, quản lý cấu trúc NoSQL, kiểm soát phiên bản cơ sở dữ liệu và nhiều hơn nữa.
  * [Zed](https://zed.dev/) - Zed là trình soạn thảo mã hiệu suất cao, hỗ trợ nhiều người cùng một lúc, từ những người tạo ra Atom và Tree-sitter.
  * [OneCompiler](https://onecompiler.com/) - Trình biên dịch trực tuyến miễn phí hỗ trợ hơn 70 ngôn ngữ như Java, Python, C++, JavaScript.


**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Phân tích, Sự kiện và Thống kê

  * [Dwh.dev](https://dwh.dev) - Giải pháp quan sát dữ liệu đám mây (Snowflake). Miễn phí cho sử dụng cá nhân.
  * [Hightouch](https://hightouch.com/) - Hightouch là nền tảng Reverse ETL giúp đồng bộ dữ liệu khách hàng từ kho dữ liệu của bạn đến CRM, công cụ tiếp thị và hỗ trợ. Gói miễn phí cho phép đồng bộ dữ liệu tới một điểm đích.
  * [Avo](https://avo.app/) — Quy trình phát hành phân tích đơn giản hóa. Kế hoạch theo dõi là nguồn dữ liệu duy nhất, thư viện theo dõi phân tích an toàn kiểu dữ liệu, trình gỡ lỗi trong ứng dụng và quan sát dữ liệu để bắt các vấn đề dữ liệu trước khi phát hành. Miễn phí cho hai thành viên workspace và 1 giờ truy xuất quan sát dữ liệu.
  * [Branch](https://www.branch.io) — Nền tảng phân tích di động. Gói miễn phí hỗ trợ lên tới 10K người dùng ứng dụng di động với deep-linking và các dịch vụ khác.
  * [Census](https://www.getcensus.com/) — Nền tảng Reverse ETL & Phân tích vận hành. Đồng bộ 10 trường từ kho dữ liệu của bạn đến hơn 60 SaaS như Salesforce, Zendesk hoặc Amplitude.
  * [Clicky](https://clicky.com) — Nền tảng phân tích website. Gói miễn phí cho một website với phân tích 3000 lượt xem.
  * [Databox](https://databox.com) — Phân tích & Thông tin doanh nghiệp bằng cách kết hợp các nền tảng phân tích & BI khác. Gói miễn phí cho 3 người dùng, dashboard & nguồn dữ liệu. 11 triệu bản ghi dữ liệu lịch sử.
  * [Hitsteps.com](https://hitsteps.com/) — 2.000 lượt xem trang mỗi tháng cho 1 website
  * [amplitude.com](https://amplitude.com/) — 1 triệu sự kiện mỗi tháng, tối đa 2 ứng dụng
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter là nền tảng phân tích web mã nguồn mở, cung cấp dịch vụ lưu trữ (miễn phí cho mục đích phi thương mại) hoặc ứng dụng tự lưu trữ. Nhằm cung cấp phân tích web dễ dùng, thân thiện với quyền riêng tư thay thế cho Google Analytics hoặc Matomo. Gói miễn phí dành cho mục đích phi thương mại và bao gồm số lượng site không giới hạn, lưu trữ dữ liệu 6 tháng, và 100k lượt xem trang/tháng.
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — Giải pháp phân tích thân thiện quyền riêng tư thay thế Google Analytics cho lập trình viên. Gói miễn phí cho phép 20k lượt xem trang mỗi tháng, không cần thẻ tín dụng.
  * [Expensify](https://www.expensify.com/) — Báo cáo chi phí, quy trình phê duyệt báo cáo cá nhân miễn phí
  * [getinsights.io](https://getinsights.io) - Phân tích tập trung vào quyền riêng tư, không dùng cookie, miễn phí lên đến 3k sự kiện/tháng.
  * [heap.io](https://heap.io) — Tự động ghi nhận mọi hành động người dùng trên ứng dụng iOS hoặc web. Miễn phí cho tối đa 10K phiên mỗi tháng.
  * [Hotjar](https://hotjar.com) — Phân tích và báo cáo website. Gói miễn phí cho phép 2000 lượt xem trang/ngày. 100 snapshot/ngày (tối đa: 300). 3 bản đồ nhiệt snapshot có thể lưu giữ 365 ngày. Số lượng thành viên nhóm không giới hạn. Cũng có khảo sát trong ứng dụng và độc lập, widget phản hồi kèm ảnh chụp màn hình. Gói miễn phí cho phép tạo 3 khảo sát & 3 widget phản hồi và thu thập 20 phản hồi mỗi tháng.
  * [Keen](https://keen.io/) — Phân tích tuỳ chỉnh cho thu thập, phân tích và trực quan hóa dữ liệu. 1.000 sự kiện/tháng miễn phí
  * [Yandex.Datalens](https://datalens.yandex.com/) — Dịch vụ trực quan hóa và phân tích dữ liệu trên Yandex Cloud. Dịch vụ được cung cấp miễn phí. Không giới hạn số người dùng và yêu cầu.
  * [Yandex.Metrica](https://metrica.yandex.com/) — Phân tích miễn phí không giới hạn
  * [Mixpanel](https://mixpanel.com/) — 100.000 người dùng được theo dõi hàng tháng, dữ liệu và chỗ ngồi không giới hạn, lưu trữ dữ liệu tại Mỹ hoặc EU
  * [Moesif](https://www.moesif.com) — Phân tích API cho REST và GraphQL. (Miễn phí tới 500.000 cuộc gọi API/tháng)
  * [optimizely.com](https://www.optimizely.com) — Giải pháp kiểm thử A/B, gói khởi đầu miễn phí, một website, 1 ứng dụng iOS và 1 ứng dụng Android
  * [Microsoft PowerBI](https://powerbi.com) — Phân tích & Thông tin doanh nghiệp của Microsoft. Gói miễn phí cho phép sử dụng giới hạn với 1 triệu giấy phép người dùng.
  * [Row Zero](https://rowzero.io) - Bảng tính kết nối cực nhanh. Kết nối trực tiếp đến cơ sở dữ liệu, S3 và API. Nhập, phân tích, biểu đồ và chia sẻ hàng triệu dòng ngay lập tức. Ba workbook miễn phí (vĩnh viễn).
  * [sematext.com](https://sematext.com/cloud/) — Miễn phí tới 50.000 hành động/tháng, lưu trữ dữ liệu 1 ngày, dashboard và người dùng không giới hạn, v.v.
  * [Similar Web](https://similarweb.com) — Phân tích cho Web & Ứng dụng di động. Gói miễn phí cung cấp 5 kết quả cho mỗi chỉ số, 1 tháng dữ liệu ứng dụng di động & 3 tháng dữ liệu website.
  * [StatCounter](https://statcounter.com/) — Phân tích người xem website. Gói miễn phí cho 500 khách truy cập gần nhất.
  * [Statsig](https://statsig.com) - Nền tảng tất cả trong một gồm phân tích, cờ tính năng và kiểm thử A/B. Miễn phí tới 1 triệu sự kiện đo lường mỗi tháng.
  * [Tableau Developer Program](https://www.tableau.com/developer) — Sáng tạo, phát triển và làm cho Tableau hoạt động hoàn hảo cho tổ chức của bạn. Chương trình nhà phát triển miễn phí cung cấp giấy phép sandbox phát triển cá nhân cho Tableau Online. Phiên bản là phiên bản mới nhất tiền phát hành để Data Devs có thể kiểm thử mọi tính năng của nền tảng tuyệt vời này.
  * [usabilityhub.com](https://usabilityhub.com/) — Kiểm thử thiết kế và mockup trên người dùng thực và theo dõi khách truy cập. Miễn phí cho một người dùng, không giới hạn số lần kiểm thử
  * [woopra.com](https://www.woopra.com/) — Nền tảng phân tích người dùng miễn phí cho 500K hành động, lưu trữ dữ liệu 90 ngày, hơn 30 tích hợp một chạm.
  * [counter.dev](https://counter.dev) — Phân tích web đơn giản và do đó thân thiện với quyền riêng tư. Miễn phí hoặc trả tùy tâm qua quyên góp.
  * [PostHog](https://posthog.com) - Bộ phân tích sản phẩm đầy đủ miễn phí cho tới 1 triệu sự kiện theo dõi mỗi tháng. Cũng cung cấp khảo sát trong ứng dụng không giới hạn với 250 phản hồi/tháng.
  * [Uptrace](https://uptrace.dev) - Công cụ truy vết phân tán giúp lập trình viên xác định lỗi và tìm nút thắt hiệu suất. Có gói miễn phí, tặng kèm gói Personal miễn phí cho dự án mã nguồn mở, và có phiên bản mã nguồn mở.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity là công cụ miễn phí, dễ sử dụng ghi lại cách người dùng thực sự sử dụng website của bạn.
  * [Beampipe.io](https://beampipe.io) - Beampipe là phân tích web đơn giản, tập trung quyền riêng tư. Miễn phí cho tối đa 5 tên miền & 10k lượt xem trang mỗi tháng.
  * [Aptabase](https://aptabase.com) — Mã nguồn mở, thân thiện quyền riêng tư, phân tích đơn giản cho ứng dụng di động và desktop. SDK cho Swift, Kotlin, React Native, Flutter, Electron và nhiều nền tảng khác. Miễn phí tới 20.000 sự kiện mỗi tháng.
  * [Trackingplan](https://www.trackingplan.com/) - Tự động phát hiện các vấn đề về phân tích số liệu số, dữ liệu tiếp thị và pixel, duy trì kế hoạch tracking luôn cập nhật và thúc đẩy cộng tác liền mạch. Triển khai lên môi trường production với lưu lượng thực hoặc bổ sung phạm vi phân tích cho kiểm thử hồi quy mà không cần viết mã.
  * [LogSpot](https://logspot.io) - Nền tảng phân tích web và sản phẩm hợp nhất hoàn chỉnh, bao gồm widget phân tích nhúng và robot tự động (slack, telegram và webhook). Gói miễn phí gồm 10.000 sự kiện mỗi tháng.
  * [Umami](https://umami.is/) - Giải pháp thay thế Google Analytics đơn giản, nhanh, tập trung quyền riêng tư, mã nguồn mở.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - Phân tích thay thế Google Analytics nhẹ, tập trung quyền riêng tư. Lượt xem trang không giới hạn, khách truy cập không giới hạn, bản đồ nhiệt và theo dõi mục tiêu không giới hạn. Miễn phí cho tối đa 3 tên miền và 600 lần phát lại phiên mỗi tên miền.
  * [AppFit](https://appfit.io) - AppFit là công cụ quản lý phân tích và sản phẩm toàn diện, hỗ trợ quản lý xuyên nền tảng phân tích và cập nhật sản phẩm dễ dàng. Gói miễn phí gồm 10.000 sự kiện mỗi tháng, nhật ký sản phẩm và thông tin hàng tuần.
  * [Seline](https://seline.so) - Seline là phân tích website và sản phẩm đơn giản & riêng tư. Không cookie, nhẹ, độc lập. Gói miễn phí gồm 3.000 sự kiện mỗi tháng và truy cập tất cả các tính năng, như dashboard, hành trình người dùng, funnel, v.v.
  * [Peasy](https://peasy.so) - Peasy là công cụ phân tích nhẹ, tập trung quyền riêng tư cho website và sản phẩm. Gói miễn phí gồm 3.000 sự kiện mỗi tháng.
  * [Rybbit](https://rybbit.io) - Giải pháp mã nguồn mở, không dùng cookie thay thế Google Analytics, trực quan hơn gấp 10 lần. Gói miễn phí có 3.000 sự kiện mỗi tháng. 

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Ghi lại phiên truy cập của khách

  * [Reactflow.com](https://www.reactflow.com/) — Mỗi site: 1.000 lượt xem trang/ngày, ba bản đồ nhiệt, ba widget, theo dõi lỗi miễn phí
  * [OpenReplay.com](https://www.openreplay.com) - Phát lại phiên mã nguồn mở với công cụ dev để tái hiện lỗi, phiên trực tiếp cho hỗ trợ thời gian thực, và bộ phân tích sản phẩm. Một nghìn phiên/tháng với truy cập tất cả tính năng và lưu trữ 7 ngày.
  * [LogRocket.com](https://www.logrocket.com) - 1.000 phiên/tháng với lưu trữ 30 ngày, theo dõi lỗi, chế độ trực tiếp
  * [FullStory.com](https://www.fullstory.com) — 1.000 phiên/tháng với lưu trữ dữ liệu một tháng và ba ghế người dùng. Thông tin thêm [tại đây](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — Mỗi site: 1.050 lượt xem trang/tháng, bản đồ nhiệt không giới hạn, lưu trữ dữ liệu ba tháng
  * [inspectlet.com](https://www.inspectlet.com/) — 2.500 phiên/tháng miễn phí cho một website
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Ghi lại phiên hoàn toàn miễn phí với "không giới hạn lưu lượng", không giới hạn dự án, và không lấy mẫu
  * [mouseflow.com](https://mouseflow.com/) — 500 phiên/tháng miễn phí cho một website
  * [mousestats.com](https://www.mousestats.com/) — 100 phiên/tháng miễn phí cho một website
  * [smartlook.com](https://www.smartlook.com/) — gói miễn phí cho web và ứng dụng di động (1.500 phiên/tháng), ba bản đồ nhiệt, một funnel, lưu dữ liệu 1 tháng
  * [howuku.com](https://howuku.com) — Theo dõi tương tác, mức độ tương tác và sự kiện người dùng. Miễn phí cho tối đa 5.000 lượt truy cập/tháng
  * [UXtweak.com](https://www.uxtweak.com/) — Ghi và xem lại cách khách truy cập sử dụng website hoặc ứng dụng của bạn. Miễn phí không giới hạn thời gian cho dự án nhỏ

**[⬆️ Quay lại đầu trang](#table-of-contents)**
## API và SDK Xác Minh Số Điện Thoại Quốc Tế

  * [numverify](https://numverify.com/) — API xác thực và tra cứu số điện thoại toàn cầu dạng JSON. 100 yêu cầu API/tháng
  * [veriphone](https://veriphone.io/) — Xác minh số điện thoại toàn cầu qua API JSON miễn phí, nhanh chóng, đáng tin cậy. 1000 yêu cầu/tháng

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Tích Hợp Thanh Toán và Lập Hóa Đơn

  * [Qonversion](http://qonversion.io/) - Nền tảng quản lý đăng ký đa nền tảng tất cả trong một, cung cấp phân tích, A/B testing, Apple Search Ads, cấu hình từ xa, và các công cụ tăng trưởng để tối ưu hóa mua hàng trong ứng dụng và kiếm tiền. Tương thích với iOS, Android, React Native, Flutter, Unity, Cordova, Stripe, và web. Miễn phí cho đến $10k doanh thu theo dõi hàng tháng.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – Tự động điều chỉnh giá dựa trên vị trí khách truy cập để mở rộng kinh doanh toàn cầu và tiếp cận thị trường mới (theo sức mua tương đương). Gói miễn phí bao gồm 7.500 yêu cầu API/tháng.
  * [Glassfy](https://glassfy.io/) – Hạ tầng đăng ký trong ứng dụng, sự kiện đăng ký theo thời gian thực và công cụ kiếm tiền sẵn có trên iOS, Android, Stripe và Paddle. Miễn phí lên đến $10k doanh thu hàng tháng.
  * [Adapty.io](https://adapty.io/) – Giải pháp một cửa với SDK mã nguồn mở để tích hợp đăng ký trong ứng dụng di động cho iOS, Android, React Native, Flutter, Unity hoặc ứng dụng web. Miễn phí lên đến $10k doanh thu hàng tháng.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — Cung cấp dữ liệu thị trường tiền điện tử bao gồm tỷ giá hối đoái tiền điện tử và tiền pháp định mới nhất. Gói miễn phí cung cấp 10K lượt gọi API/tháng.
  * [CurrencyFreaks](https://currencyfreaks.com/) — Cung cấp tỷ giá hối đoái hiện tại và lịch sử. Có gói DEVELOPER miễn phí với 1000 yêu cầu/tháng.
  * [CoinGecko](https://www.coingecko.com/en/api) — Cung cấp dữ liệu thị trường tiền điện tử bao gồm tỷ giá hối đoái mới nhất và dữ liệu lịch sử. API demo có giới hạn ổn định 30 lượt gọi/phút và tối đa 10.000 lượt gọi/tháng.
  * [CurrencyApi](https://currencyapi.net/) — Tỷ giá tiền tệ trực tiếp cho tiền pháp định và tiền điện tử, trả về dạng JSON và XML. Gói miễn phí cung cấp 1.250 yêu cầu API/tháng.
  * [currencylayer](https://currencylayer.com/) — Tỷ giá hối đoái đáng tin cậy và chuyển đổi tiền tệ cho doanh nghiệp, miễn phí 100 yêu cầu API/tháng.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - API chuyển đổi tiền tệ dạng JSON dễ sử dụng. Gói miễn phí cập nhật mỗi ngày một lần với giới hạn 1.500 yêu cầu/tháng.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — Hỗ trợ thương nhân phòng chống gian lận thanh toán và bồi hoàn. Có gói Micro miễn phí với 500 truy vấn/tháng.
  * [FxRatesAPI](https://fxratesapi.com) — Cung cấp tỷ giá hối đoái theo thời gian thực và lịch sử. Gói miễn phí yêu cầu ghi nguồn (attribution).
  * [Moesif API Monetization](https://www.moesif.com/) - Tạo doanh thu từ API qua thanh toán dựa trên mức sử dụng. Kết nối với Stripe, Chargebee, v.v. Gói miễn phí cung cấp 30.000 sự kiện/tháng.
  * [Nami ML](https://www.namiml.com/) - Nền tảng toàn diện cho mua hàng và đăng ký trong ứng dụng trên iOS và Android, bao gồm paywall không cần code, CRM, và phân tích. Miễn phí cho tất cả các tính năng cơ bản để vận hành kinh doanh IAP.
  * [RevenueCat](https://www.revenuecat.com/) — Backend lưu trữ cho mua hàng trong ứng dụng và đăng ký (iOS và Android). Miễn phí cho đến $2.5k/tháng doanh thu theo dõi.
  * [vatlayer](https://vatlayer.com/) — API xác thực số VAT và tỷ lệ VAT EU tức thì, miễn phí 100 yêu cầu API/tháng
  * [Currencyapi](https://currencyapi.com) — API chuyển đổi tiền tệ và tỷ giá hối đoái miễn phí. Miễn phí 300 yêu cầu mỗi tháng, 10 yêu cầu mỗi phút cho sử dụng cá nhân.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Liên Quan Đến Docker

  * [canister.io](https://canister.io/) — 20 kho lưu trữ riêng tư miễn phí cho lập trình viên, 30 kho lưu trữ riêng tư miễn phí cho nhóm để build và lưu trữ Docker image
  * [Container Registry Service](https://container-registry.com/) - Giải pháp quản lý container dựa trên Harbor. Gói miễn phí cung cấp 1 GB lưu trữ cho kho riêng tư.
  * [Docker Hub](https://hub.docker.com) — Một kho lưu trữ riêng tư miễn phí và kho công khai không giới hạn để build và lưu trữ Docker image
  * [Play with Docker](https://labs.play-with-docker.com/) — Sân chơi tương tác, đơn giản, thú vị để học Docker.
  * [quay.io](https://quay.io/) — Build và lưu trữ container image với kho công khai miễn phí không giới hạn
  * [ttl.sh](https://ttl.sh/) - Registry Docker ẩn danh & tạm thời

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Liên Quan Đến Vagrant

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud. Lưu trữ Vagrant box.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — Chỉ mục box công khai thay thế

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Trang Blog Lập Trình Viên

  * [BearBlog](https://bearblog.dev/) - Nền tảng blog và tạo website tối giản, hỗ trợ Markdown.
  * [Dev.to](https://dev.to/) - Nơi lập trình viên chia sẻ ý tưởng và cùng nhau phát triển.
  * [Hashnode](https://hashnode.com/) — Phần mềm blog dễ dàng dành cho lập trình viên!
  * [Medium](https://medium.com/) — Đọc và chia sẻ những điều quan trọng với bạn.
  * [AyeDot](https://ayedot.com/) — Chia sẻ ý tưởng, kiến thức và câu chuyện của bạn với thế giới miễn phí qua Miniblog đa phương tiện hiện đại.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Nền Tảng Bình Luận
  * [GraphComment](https://graphcomment.com/) - Nền tảng bình luận giúp xây dựng cộng đồng tích cực từ lượng truy cập website.
  * [Utterances](https://utteranc.es/) - Widget bình luận nhẹ, xây dựng trên GitHub issues. Sử dụng GitHub issues cho bình luận blog, trang wiki, v.v!
  * [Disqus](https://disqus.com/) - Disqus là nền tảng cộng đồng mạng được sử dụng bởi hàng trăm nghìn trang web trên toàn cầu.
  * [Remarkbox](https://www.remarkbox.com/) - Nền tảng bình luận mã nguồn mở được lưu trữ, thanh toán tùy khả năng cho "Một người kiểm duyệt trên vài tên miền với toàn quyền kiểm soát hành vi & giao diện"
  * [IntenseDebate](https://intensedebate.com/) - Hệ thống bình luận nhiều tính năng cho WordPress, Tumblr, Blogger và nhiều nền tảng website khác.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## API Chụp Ảnh Màn Hình

  * [ApiFlash](https://apiflash.com) — API chụp ảnh màn hình dựa trên AWS Lambda và Chrome. Xử lý toàn bộ trang, thời gian chụp và kích thước khung nhìn.
  * [microlink.io](https://microlink.io/) – Chuyển đổi bất kỳ website nào thành dữ liệu như chuẩn hóa metatag, xem trước link đẹp, khả năng scraping hoặc chụp ảnh màn hình như dịch vụ. 250 yêu cầu/ngày miễn phí.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - API chụp ảnh màn hình sử dụng một lệnh API đơn giản để tạo ảnh chụp bất kỳ website nào. Xây dựng để mở rộng và lưu trữ trên Google Cloud. Cung cấp 100 ảnh chụp miễn phí mỗi tháng.
  * [screenshotlayer.com](https://screenshotlayer.com/) — Chụp ảnh chụp màn hình tùy chỉnh cao cho bất kỳ website nào. Miễn phí 100 ảnh chụp/tháng
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — Chụp 100 ảnh/tháng, định dạng png, gif và jpg, bao gồm cả ảnh toàn trang, không chỉ trang chủ
  * [PhantomJsCloud](https://PhantomJsCloud.com) — Tự động hóa trình duyệt và dựng trang. Gói miễn phí cung cấp tối đa 500 trang/ngày. Miễn phí từ năm 2017.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker cung cấp dịch vụ API ảnh chụp website và thông tin tên miền. Miễn phí 100 yêu cầu/tháng.
  * [Screenshots](https://screenshotson.click) — API chụp ảnh màn hình với nhiều tùy chọn tùy chỉnh cao. Miễn phí 100 ảnh chụp/tháng.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Liên Quan Đến Flutter và Xây Dựng Ứng Dụng IOS Không Cần Mac

  * [FlutLab](https://flutlab.io/) - FlutLab là IDE Flutter trực tuyến hiện đại, là nơi tốt nhất để tạo, debug và build dự án đa nền tảng. Xây dựng ứng dụng iOS (không cần Mac) và Android với Flutter.
  * [CodeMagic](https://codemagic.io/) - Codemagic là CI/CD hoàn toàn được lưu trữ và quản lý cho ứng dụng di động. Có thể build, test và deploy với công cụ CI/CD giao diện đồ họa. Gói miễn phí cung cấp 500 phút miễn phí/tháng và máy Mac Mini với 2.3 GHz và 8 GB RAM.
  * [FlutterFlow](https://flutterflow.io/) -  FlutterFlow là giao diện kéo thả trên trình duyệt để xây dựng ứng dụng di động bằng flutter.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Mô Phỏng Phần Cứng Trên Trình Duyệt Viết Bằng Javascript

  * [JsLinux](https://bellard.org/jslinux) — máy ảo x86 rất nhanh, có thể chạy Linux và Windows 2k.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — máy ảo OpenRISC có thể chạy Linux với hỗ trợ mạng.
  * [v86](https://copy.sh/v86) — máy ảo x86 có thể chạy Linux và các hệ điều hành khác trực tiếp trên trình duyệt.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Quản Lý Quyền Riêng Tư
  * [Bearer](https://www.bearer.sh/) - Hỗ trợ triển khai bảo mật riêng tư theo thiết kế qua kiểm toán và quy trình liên tục để đảm bảo tổ chức tuân thủ GDPR và các quy định khác. Gói miễn phí giới hạn cho nhóm nhỏ và chỉ bản SaaS.
  * [Osano](https://www.osano.com/) - Nền tảng quản lý đồng ý và tuân thủ với đầy đủ tính năng từ đại diện GDPR đến banner cookie. Gói miễn phí cung cấp các tính năng cơ bản.
  * [Iubenda](https://www.iubenda.com/) - Chính sách quyền riêng tư, cookie và quản lý đồng ý. Gói miễn phí cung cấp chính sách quyền riêng tư, cookie và banner cookie giới hạn.
  * [Cookiefirst](https://cookiefirst.com/) - Banner cookie, kiểm toán và giải pháp quản lý đồng ý đa ngôn ngữ. Gói miễn phí cung cấp một lần quét và một banner duy nhất.
  * [Ketch](https://www.ketch.com/) - Công cụ quản lý sự đồng ý và khung bảo mật quyền riêng tư. Gói miễn phí cung cấp hầu hết các tính năng với số lượng khách truy cập giới hạn.
  * [Concord](https://www.concord.tech/) - Nền tảng bảo mật dữ liệu đầy đủ, bao gồm quản lý sự đồng ý, xử lý yêu cầu quyền riêng tư (DSARs), và lập bản đồ dữ liệu. Gói miễn phí bao gồm các tính năng quản lý sự đồng ý cốt lõi và họ cũng cung cấp gói nâng cao hơn miễn phí cho các dự án mã nguồn mở đã xác minh.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Khác

  * [BackgroundStyler.com](https://backgroundstyler.com) - Tạo ảnh chụp màn hình thẩm mỹ cho mã nguồn, văn bản hoặc hình ảnh để chia sẻ trên mạng xã hội.
  * [BinShare.net](https://binshare.net) - Tạo & chia sẻ mã hoặc tập tin nhị phân. Có thể chia sẻ dưới dạng hình ảnh đẹp mắt, ví dụ đăng lên Twitter / Facebook hoặc dưới dạng liên kết cho chat hoặc diễn đàn.
  * [Blynk](https://blynk.io) — Một dịch vụ SaaS với API để điều khiển, xây dựng & đánh giá thiết bị IoT. Gói Developer miễn phí với 5 thiết bị, miễn phí Cloud & lưu trữ dữ liệu. Có ứng dụng di động.
  * [Bricks Note Calculator](https://free.getbricks.app/) - Ứng dụng ghi chú (PWA) với máy tính dòng đa năng tích hợp mạnh mẽ.
  * [Carbon.now.sh](https://carbon.now.sh) - tạo và chia sẻ đoạn mã dưới dạng hình ảnh chụp màn hình thẩm mỹ. Thường dùng để chia sẻ/khoe đoạn mã trên Twitter hoặc bài viết blog.
  * [Code Time](https://www.software.com/code-time) - tiện ích mở rộng theo dõi thời gian và thống kê lập trình trên VS Code, Atom, IntelliJ, Sublime Text, và nhiều hơn nữa.
  * [Codepng](https://www.codepng.app) - Tạo ảnh chụp màn hình tuyệt vời từ mã nguồn để chia sẻ trên mạng xã hội.
  * [CodeToImage](https://codetoimage.com/) - Tạo ảnh chụp màn hình của mã hoặc văn bản để chia sẻ trên mạng xã hội.
  * [Cronhooks](https://cronhooks.io/) - Lên lịch webhook một lần hoặc định kỳ. Gói miễn phí cho phép 5 lịch ad-hoc.
  * [cron-job.org](https://cron-job.org) - Dịch vụ cronjobs trực tuyến. Không giới hạn số lượng công việc, hoàn toàn miễn phí.
  * [datelist.io](https://datelist.io) - Hệ thống đặt lịch hẹn/đặt chỗ trực tuyến. Miễn phí tới 5 lần đặt lịch mỗi tháng, bao gồm 1 lịch.
  * [Domain Forward](https://domain-forward.com/) - Công cụ chuyển tiếp URL hoặc tên miền đơn giản. Miễn phí tới 5 tên miền và 200.000 yêu cầu mỗi tháng.
  * [Elementor](https://elementor.com) — Trình xây dựng website WordPress. Gói miễn phí với hơn 40 Widget cơ bản.
  * [Exif Editor](https://exifeditor.io/) — Xem, chỉnh sửa, xóa, phân tích metadata hình ảnh/ảnh trực tiếp trên trình duyệt - bao gồm vị trí GPS và metadata.
  * [Format Express](https://www.format-express.dev) - Định dạng tức thì trực tuyến cho JSON / XML / SQL.
  * [FOSSA](https://fossa.com/) - Quản lý quy mô lớn, đầu-cuối cho mã của bên thứ ba, tuân thủ giấy phép và lỗ hổng bảo mật.
  * [Hook Relay](https://www.hookrelay.dev/) - Thêm hỗ trợ webhook cho ứng dụng của bạn mà không lo rắc rối: hàng đợi, thử lại với backoff, ghi log sẵn sàng. Gói miễn phí có 100 lần gửi mỗi ngày, lưu trữ 14 ngày và 3 endpoint webhook.
  * [Hosting Checker](https://hostingchecker.co) - Kiểm tra thông tin hosting như ASN, ISP, vị trí và nhiều hơn cho bất kỳ tên miền, website hoặc địa chỉ IP nào. Bao gồm nhiều công cụ liên quan đến hosting và DNS.
  * [http2.pro](https://http2.pro) — Kiểm tra mức độ sẵn sàng của giao thức HTTP/2 và API kiểm tra hỗ trợ HTTP/2 của client.
  * [kandi](https://kandi.openweaver.com/) — Khởi động phát triển ứng dụng: xây dựng chức năng tùy chỉnh, tình huống sử dụng, và ứng dụng hoàn chỉnh nhanh hơn thông qua đoạn mã và tái sử dụng thư viện mã nguồn mở.
  * [Base64 decoder/encoder](https://devpal.co/base64-decode/) — Công cụ trực tuyến miễn phí để giải mã & mã hóa dữ liệu.
  * [newreleases.io](https://newreleases.io/) - Nhận thông báo qua email, Slack, Telegram, Discord, và webhook tùy chỉnh về các bản phát hành mới từ GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo và Docker Hub.
  * [OnlineExifViewer](https://onlineexifviewer.com/) — Xem dữ liệu EXIF trực tuyến tức thì cho ảnh bao gồm vị trí GPS và metadata.
  * [PDFMonkey](https://www.pdfmonkey.io/) — Quản lý mẫu PDF trên dashboard, gọi API với dữ liệu động và tải PDF về. Cung cấp 300 tài liệu miễn phí mỗi tháng.
  * [Pika Code Screenshots](https://pika.style/templates/code-image) — Tạo ảnh chụp màn hình mã nguồn đẹp mắt, tùy chỉnh từ đoạn mã hoặc bằng extension của VSCode.
  * [QuickType.io](https://quicktype.io/) - Tự động tạo nhanh model/lớp/kiểu/interface và serializer từ JSON, schema, và GraphQL để làm việc với dữ liệu nhanh & an toàn trên mọi ngôn ngữ lập trình. Chuyển JSON thành mã typesafe đẹp mắt ở bất kỳ ngôn ngữ nào.
  * [RandomKeygen](https://randomkeygen.com/) - Công cụ miễn phí thân thiện trên di động, cung cấp nhiều loại khóa và mật khẩu ngẫu nhiên để bảo vệ ứng dụng, dịch vụ hoặc thiết bị.
  * [ray.so](https://ray.so/) - Tạo hình ảnh đẹp cho đoạn mã của bạn.
  * [readme.com](https://readme.com/) — Tài liệu đẹp dễ tạo, miễn phí cho mã nguồn mở.
  * [redirection.io](https://redirection.io/) — Công cụ SaaS quản lý chuyển hướng HTTP cho doanh nghiệp, marketing và SEO.
  * [redirect.ing](https://redirect.ing/) - Chuyển tiếp tên miền nhanh & an toàn mà không cần quản lý máy chủ hoặc SSL. Gói miễn phí bao gồm 10 hostname và 100.000 yêu cầu mỗi tháng.
  * [redirect.pizza](https://redirect.pizza/) - Dễ dàng quản lý chuyển hướng với hỗ trợ HTTPS. Gói miễn phí gồm 10 nguồn và 100.000 lượt truy cập mỗi tháng.
  * [ReqBin](https://reqbin.com/) — Gửi HTTP Request trực tuyến. Các phương thức phổ biến gồm GET, POST, PUT, DELETE và HEAD. Hỗ trợ Header và xác thực Token. Có hệ thống đăng nhập cơ bản để lưu lại các yêu cầu.
  * [Smartcar API](https://smartcar.com) - API cho xe hơi để xác định vị trí, kiểm tra mức nhiên liệu, pin, quãng đường, mở/khóa cửa, v.v.
  * [snappify](https://snappify.com) - Cho phép lập trình viên tạo hình ảnh tuyệt đẹp. Từ đoạn mã đẹp đến các bài thuyết trình kỹ thuật hoàn chỉnh. Gói miễn phí gồm tối đa 3 snaps cùng lúc, tải về không giới hạn và 5 lần giải thích mã bằng AI mỗi tháng.
  * [Sunrise and Sunset](https://sunrisesunset.io/api/) - Lấy giờ mặt trời mọc và lặn theo vĩ độ và kinh độ.
  * [superfeedr.com](https://superfeedr.com/) — Nguồn feeds thời gian thực tuân thủ PubSubHubbub, xuất, phân tích. Miễn phí với tùy biến hạn chế.
  * [SurveyMonkey.com](https://www.surveymonkey.com) — Tạo khảo sát trực tuyến. Phân tích kết quả trực tuyến. Gói miễn phí chỉ cho 10 câu hỏi và 100 phản hồi mỗi khảo sát.
  * [Tiledesk](https://tiledesk.com) - Tạo chatbot và ứng dụng hội thoại. Đưa chúng lên đa kênh: từ website (widget chat trực tiếp) đến WhatsApp. Gói miễn phí với số lượng chatbot không giới hạn.
  * [Versionfeeds](https://versionfeeds.com) — RSS tùy chỉnh cho các bản phát hành phần mềm yêu thích. Tổng hợp các bản mới nhất của ngôn ngữ lập trình, thư viện, công cụ vào một feed. (3 feed đầu tiên miễn phí)
  * [videoinu](https://videoinu.com) — Tạo và chỉnh sửa ghi màn hình và video trực tuyến.
  * [Webacus](https://webacus.dev) — Truy cập nhiều công cụ miễn phí dành cho lập trình viên về mã hóa, giải mã và xử lý dữ liệu.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Công cụ Remote Desktop

  * [Getscreen.me](https://getscreen.me) —  Miễn phí cho 2 thiết bị, không giới hạn số phiên và thời lượng phiên
  * [Apache Guacamole™](https://guacamole.apache.org/) — Cổng remote desktop không client mã nguồn mở
  * [RemSupp](https://remsupp.com) — Hỗ trợ theo yêu cầu và truy cập thiết bị vĩnh viễn (2 phiên/ngày miễn phí)
  * [RustDesk](https://rustdesk.com/) - Hạ tầng desktop ảo/remote mã nguồn mở cho mọi người!
  * [AnyDesk](https://anydesk.com) —  Miễn phí cho 3 thiết bị, không giới hạn số phiên và thời lượng phiên

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Phát triển Game

  * [itch.io](https://itch.io/game-assets) — Asset miễn phí/có phí như sprite, tile set, và gói nhân vật.
  * [Gamefresco.com](https://gamefresco.com/) — Khám phá, sưu tầm và chia sẻ asset game miễn phí từ nghệ sĩ game khắp nơi.
  * [GameDevMarket](https://gamedevmarket.net) — Asset miễn phí/có phí như 2D, 3D, Audio, GUI.
  * [OpenGameArt](https://opengameart.org) — Asset Game mã nguồn mở như nhạc, âm thanh, sprite, gif.
  * [CraftPix](https://craftpix.net) — Asset miễn phí/có phí như 2D, 3D, Audio, GUI, background, icon, tile set, game kit.
  * [Game Icons](https://game-icons.net/) - Bộ icon SVG/PNG miễn phí tùy chỉnh theo giấy phép CC-BY.
  * [LoSpec](https://lospec.com/) — Công cụ trực tuyến tạo pixel art và nghệ thuật số giới hạn, có nhiều hướng dẫn/danh sách palette để chọn cho game của bạn.
  * [ArtStation](https://www.artstation.com/) - Marketplace asset 2D, 3D, audio, icon, tile set, game kit miễn phí/có phí. Cũng có thể dùng để trưng bày portfolio nghệ thuật của bạn.
  * [Rive](https://rive.app/community/) - Asset cộng đồng và cho phép bạn tự tạo asset game với gói miễn phí.
  * [Poly Pizza](https://poly.pizza/) - Asset 3D low poly miễn phí
  * [3Dassets.one](https://3dassets.one/) - Hơn 8.000 model 3D miễn phí/có phí, vật liệu PBR để làm texture.
  * [Kenney](https://www.kenney.nl/assets/) - Asset game 2D, 3D, Audio, UI miễn phí (giấy phép CC0 1.0 Universal).
  * [Poliigon](https://www.poliigon.com/) - Texture miễn phí & trả phí (độ phân giải tùy chọn), model, HDRI, brush. Có plugin miễn phí xuất ra các phần mềm như Blender.
  * [Freesound](https://freesound.org/) - Thư viện âm thanh cộng tác miễn phí với nhiều giấy phép CC khác nhau.

**[⬆️ Quay lại đầu trang](#table-of-contents)**

## Tài nguyên miễn phí khác

  * [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - Công cụ luôn miễn phí cho lập trình viên web như nén/giải nén CSS, tối ưu hình ảnh, thay đổi kích thước ảnh, chuyển đổi chữ hoa/thường, kiểm tra CSS, biên dịch JavaScript, trình soạn thảo HTML, v.v.
  * [ElevateAI](https://www.elevateai.com) - Miễn phí tới 200 giờ chuyển đổi âm thanh thành văn bản mỗi tháng.
  * [get.localhost.direct](https://get.localhost.direct) — Chứng chỉ SSL Wildcard `*.localhost.direct` CA công cộng ký miễn phí dành cho phát triển localhost, hỗ trợ sub-domain
  * [Framacloud](https://degooglisons-internet.org/en/) — Danh sách phần mềm và SaaS miễn phí/mã nguồn mở do tổ chức phi lợi nhuận Pháp [Framasoft](https://framasoft.org/en/) tổng hợp.
  * [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — Nơi tập hợp phần mềm miễn phí và mã nguồn mở cho lập trình viên.
  * [GitHub Education](https://education.github.com/pack) — Bộ dịch vụ miễn phí cho sinh viên. Cần đăng ký.
  * [Markdown Tools](https://markdowntools.com) - Công cụ chuyển đổi HTML, CSV, PDF, JSON, Excel sang và từ Markdown
  * [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Nhận sandbox miễn phí, công cụ và tài nguyên cần thiết để xây dựng giải pháp cho nền tảng Microsoft 365. Đăng ký là [Microsoft 365 E5 Subscription](https://www.microsoft.com/microsoft-365/enterprise/e5) 90 ngày (không bao gồm Windows) có thể gia hạn. Được gia hạn nếu bạn hoạt động phát triển (được đo bằng dữ liệu telemetry & thuật toán).
  * [Pyrexp](https://pythonium.net/regex) — Công cụ kiểm thử và trực quan hóa regex miễn phí trên web để debug biểu thức chính quy.
  * [RedHat for Developers](https://developers.redhat.com) — Miễn phí truy cập sản phẩm Red Hat gồm RHEL, OpenShift, CodeReady, v.v. chỉ dành cho lập trình viên. Chỉ cho cá nhân. Cũng cung cấp sách điện tử miễn phí để tham khảo.
  * [smsreceivefree.com](https://smsreceivefree.com/) — Cung cấp số điện thoại tạm thời và dùng một lần miễn phí.
  * [sandbox.httpsms.com](https://sandbox.httpsms.com) — Gửi và nhận tin nhắn SMS test miễn phí.
  * [SimpleBackups.com](https://simplebackups.com/) — Dịch vụ tự động sao lưu cho server và cơ sở dữ liệu (MySQL, PostgreSQL, MongoDB) lưu trực tiếp lên các nhà cung cấp lưu trữ đám mây (AWS, DigitalOcean, Backblaze). Gói miễn phí cho 1 bản sao lưu.
  * [SnapShooter](https://snapshooter.com/) — Giải pháp sao lưu cho DigitalOcean, AWS, LightSail, Hetzner, Exoscale, hỗ trợ sao lưu trực tiếp database, file system và ứng dụng lên lưu trữ s3. Có gói miễn phí với sao lưu hàng ngày cho một tài nguyên.
  * [Themeselection](https://themeselection.com/) — Chọn lọc các mẫu Dashboard Admin, giao diện HTML và UI Kit miễn phí chất lượng cao, hiện đại, chuyên nghiệp và dễ sử dụng giúp bạn tạo ứng dụng nhanh hơn!
  * [Web.Dev](https://web.dev/measure/) — Công cụ miễn phí cho phép bạn xem hiệu suất website và cải thiện SEO để tăng thứ hạng trên công cụ tìm kiếm.
  * [SmallDev.tools](https://smalldev.tools/) — Một công cụ miễn phí dành cho lập trình viên cho phép bạn Mã hóa/Giải mã nhiều định dạng, Nén HTML/CSS/Javascript, Làm đẹp mã, Tạo dữ liệu giả/phục vụ kiểm thử ở định dạng JSON/CSV & nhiều định dạng khác cùng nhiều tính năng khác nữa. Giao diện tuyệt vời.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — Thêm chức năng nhập CSV và Excel vào ứng dụng web của bạn chỉ trong vài phút. Mang đến trải nghiệm nhập dữ liệu mạnh mẽ và thân thiện cho người dùng. Bắt đầu miễn phí mà không cần thông tin thẻ tín dụng, tích hợp UseCSV ngay hôm nay. Bạn có thể tạo không giới hạn Importer và tải lên các tệp tối đa 100Mb.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — Hơn 100 nút bấm bạn có thể sử dụng trong dự án của mình.
  * [WrapPixel](https://www.wrappixel.com/) — Tải về miễn phí và bản trả phí các mẫu giao diện Admin dashboard chất lượng cao được tạo bằng Angular, React, VueJs, NextJS và NuxtJS!
  * [Utils.fun](https://utils.fun/en) — Tập hợp các công cụ phát triển và hàng ngày hoàn toàn offline dựa trên năng lực tính toán của trình duyệt, bao gồm tạo watermark, quay màn hình, mã hóa/giải mã, mã hóa/gải mã, và định dạng mã, hoàn toàn miễn phí, không tải dữ liệu lên đám mây để xử lý.
  * [It tools](it-tools.tech) - Các công cụ hữu ích cho lập trình viên và người làm IT.
  * [Free Code Tools](https://freecodetools.org/) — Các công cụ lập trình hiệu quả 100% miễn phí. Trình soạn thảo Markdown, nén/làm đẹp mã, tạo mã QR, Tạo Open Graph, Tạo thẻ Twitter và nhiều hơn nữa.
  * [regex101](https://regex101.com/) — Miễn phí, website này cho phép bạn kiểm thử và debug các biểu thức chính quy (regex). Cung cấp trình chỉnh sửa và kiểm thử regex, cùng với tài liệu và tài nguyên hỗ trợ học regex.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — 100+ công cụ cho lập trình viên bao gồm định dạng, nén và chuyển đổi mã.
  * [AdminMart](https://adminmart.com/) — Mẫu giao diện Admin Dashboard và Website chất lượng cao miễn phí và trả phí được tạo với Angular, Bootstrap, React, VueJs, NextJS và NuxtJS!
  * [Glob tester](https://globster.xyz/) — Trang web cho phép bạn thiết kế và kiểm thử các mẫu glob. Cũng cung cấp tài nguyên để học về glob patterns.
  * [SimpleRestore](https://simplerestore.io) - Khôi phục bản sao lưu MySQL dễ dàng. Khôi phục backup MySQL lên bất kỳ cơ sở dữ liệu từ xa nào mà không cần mã nguồn hoặc máy chủ.
  * [360Converter](https://www.360converter.com/) - Trang web hữu ích miễn phí để chuyển đổi: Video sang Văn bản && Âm thanh sang Văn bản && Lời nói sang Văn bản && Âm thanh thời gian thực sang Văn bản && Video YouTube sang Văn bản && thêm phụ đề Video. Có thể hữu ích trong chuyển đổi video ngắn hoặc hướng dẫn ngắn trên youtube :)
  * [QRCodeBest](https://qrcode.best/) - Tạo mã QR tùy chỉnh với 13 mẫu, bảo mật riêng tư và thương hiệu cá nhân. Có tính năng theo dõi pixel, phân loại dự án và không giới hạn thành viên nhóm trên QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) - Thúc đẩy sự hiện diện trực tuyến, nâng cao SEO và thứ hạng trang web với các bài viết được AI tạo hàng tháng lên các miền tối ưu hóa SEO. Gói miễn phí cho phép bạn đăng một bài viết thủ công trên trang mỗi tháng.
  * [PageTools](https://pagetools.co/) - Cung cấp bộ công cụ AI miễn phí vĩnh viễn giúp bạn tạo các chính sách website, tạo tiểu sử mạng xã hội, bài đăng và trang web chỉ với một cú nhấp chuột.
  * [MySQL Visual Explain](https://mysqlexplain.com) - Trình trực quan hóa đầu ra MySQL EXPLAIN miễn phí, dễ hiểu để tối ưu các truy vấn chậm.
  * [Killer Coda](https://killercoda.com/)  - Sân chơi tương tác ngay trên trình duyệt để học Linux, Kubernetes, Containers, Lập trình, DevOps, Mạng máy tính.
  * [Axonomy App](https://axonomy-app.com/) - Công cụ miễn phí để tạo, quản lý và chia sẻ hóa đơn với khách hàng. Miễn phí 10 hóa đơn mỗi tháng.
  * [Table Format Converter](https://www.tableformatconverter.com) - Công cụ miễn phí để chuyển đổi dữ liệu bảng sang các định dạng khác nhau, như CSV, HTML, JSON, Markdown và nhiều hơn nữa.


**[⬆️ Quay lại đầu trang](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---