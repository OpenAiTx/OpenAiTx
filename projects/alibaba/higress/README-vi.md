<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  Cổng AI
</h1>
<h4 align="center"> Cổng API gốc AI </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**Trang chính thức**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCP Server QuickStart**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasm Plugin Hub**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Higress là gì?

Higress là một cổng API cloud-native dựa trên Istio và Envoy, có thể mở rộng với các plugin Wasm viết bằng Go/Rust/JS. Nó cung cấp hàng chục plugin phổ biến sẵn sàng sử dụng và một giao diện quản lý console ngay khi cài đặt (thử [demo tại đây](http://demo.higress.io/)).

### Tình huống sử dụng cốt lõi

Khả năng gateway AI của Higress hỗ trợ tất cả [nhà cung cấp mô hình chính thống](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider) trong và ngoài nước. Higress cũng hỗ trợ host các MCP Server (Model Context Protocol) thông qua cơ chế plugin, giúp AI Agent dễ dàng gọi các công cụ và dịch vụ khác nhau. Với công cụ [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), bạn có thể nhanh chóng chuyển đổi OpenAPI specification thành máy chủ MCP từ xa để host. Higress cung cấp quản lý hợp nhất cả API LLM và API MCP.

**🌟 Trải nghiệm ngay tại [https://mcp.higress.ai/](https://mcp.higress.ai/)** để thử nghiệm trực tiếp các máy chủ MCP Remote do Higress host:

![Higress MCP Server Platform](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### Ứng dụng doanh nghiệp

Higress được sinh ra trong nội bộ Alibaba để giải quyết các vấn đề reload của Tengine ảnh hưởng tới dịch vụ kết nối dài và khả năng cân bằng tải còn hạn chế đối với gRPC/Dubbo. Trong Alibaba Cloud, khả năng gateway AI của Higress hỗ trợ các ứng dụng AI cốt lõi như xưởng mô hình Tongyi Bailian, nền tảng máy học PAI và các dịch vụ AI quan trọng khác. Alibaba Cloud đã xây dựng sản phẩm API Gateway cloud-native dựa trên Higress, cung cấp dịch vụ đảm bảo khả năng sẵn sàng cao 99.99% cho rất nhiều khách hàng doanh nghiệp.

## Tóm tắt

- [**Bắt đầu nhanh**](#quick-start)    
- [**Trình diễn tính năng**](#feature-showcase)
- [**Tình huống sử dụng**](#use-cases)
- [**Ưu điểm cốt lõi**](#core-advantages)
- [**Cộng đồng**](#community)

## Bắt đầu nhanh

Higress có thể được khởi động chỉ với Docker, rất thuận tiện cho các lập trình viên cá nhân thiết lập local để học tập hoặc xây dựng trang web đơn giản:

```bash
# Tạo thư mục làm việc
mkdir higress; cd higress
# Khởi động higress, file cấu hình sẽ được ghi vào thư mục làm việc
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

Mô tả các cổng:

- Cổng 8001: Truy cập giao diện quản lý Higress UI
- Cổng 8080: Đầu vào giao thức HTTP Gateway
- Cổng 8443: Đầu vào giao thức HTTPS Gateway

> Tất cả các image Docker của Higress đều sử dụng kho image riêng, không chịu ảnh hưởng bởi giới hạn tốc độ của Docker Hub.
> Ngoài ra, việc đẩy và cập nhật image được bảo vệ bởi cơ chế quét bảo mật (powered by Alibaba Cloud ACR), đảm bảo an toàn khi sử dụng trong môi trường production.
> 
> Nếu gặp lỗi timeout khi kéo image từ `higress-registry.cn-hangzhou.cr.aliyuncs.com`, bạn có thể thử thay bằng nguồn mirror docker registry sau:
> 
> **Đông Nam Á**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

Đối với các phương pháp cài đặt khác như triển khai Helm trên K8s, vui lòng tham khảo tài liệu [Bắt đầu nhanh chính thức](https://higress.io/en-us/docs/user/quickstart).

## Tình huống sử dụng

- **Host MCP Server**:

  Higress host các MCP Server thông qua cơ chế plugin, giúp AI Agent dễ dàng gọi các công cụ và dịch vụ khác nhau. Với công cụ [openapi-to-mcp](https://github.com/higress-group/openapi-to-mcpserver), bạn có thể nhanh chóng chuyển đổi OpenAPI specification thành máy chủ MCP từ xa.

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  Lợi ích chính khi host MCP Server với Higress:
  - Cơ chế xác thực và phân quyền hợp nhất
  - Giới hạn tốc độ chi tiết để ngăn lạm dụng
  - Log kiểm tra đầy đủ cho mọi lần gọi công cụ
  - Khả năng quan sát phong phú để giám sát hiệu suất
  - Triển khai đơn giản qua cơ chế plugin của Higress
  - Cập nhật động không gián đoạn hoặc mất kết nối

     [Tìm hiểu thêm...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AI Gateway**:

  Higress kết nối tới tất cả nhà cung cấp mô hình LLM bằng một giao thức hợp nhất, với khả năng quan sát AI, cân bằng tải đa mô hình, giới hạn tốc độ theo token và caching:

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetes ingress controller**:

  Higress có thể hoạt động như một ingress controller nhiều tính năng, tương thích với nhiều annotation của ingress controller nginx trên K8s.
  
  Hỗ trợ [Gateway API](https://gateway-api.sigs.k8s.io/) sẽ sớm ra mắt và hỗ trợ chuyển đổi mượt mà từ Ingress API sang Gateway API.
  
- **Cổng microservice**:

  Higress có thể hoạt động như một cổng microservice, có thể phát hiện microservice từ nhiều registry khác nhau như Nacos, ZooKeeper, Consul, Eureka, v.v.
  
  Tích hợp sâu với [Dubbo](https://github.com/apache/dubbo), [Nacos](https://github.com/alibaba/nacos), [Sentinel](https://github.com/alibaba/Sentinel) và các stack công nghệ microservice khác.
  
- **Cổng bảo mật**:

  Higress có thể được sử dụng như một cổng bảo mật, hỗ trợ WAF và nhiều chiến lược xác thực, như key-auth, hmac-auth, jwt-auth, basic-auth, oidc, v.v.

## Ưu điểm cốt lõi

- **Sẵn sàng cho sản xuất**

  Phát triển từ sản phẩm nội bộ của Alibaba với hơn 2 năm kiểm chứng thực tế, hỗ trợ quy mô lớn với hàng trăm ngàn request mỗi giây.

  Loại bỏ hoàn toàn hiện tượng giật traffic do reload Nginx, thay đổi cấu hình có hiệu lực trong mili giây và hoàn toàn minh bạch với dịch vụ. Đặc biệt thân thiện với các dịch vụ kết nối dài như AI.

- **Xử lý streaming**

  Hỗ trợ xử lý streaming thực sự cho toàn bộ body của request/response, các plugin Wasm có thể dễ dàng tùy chỉnh xử lý các giao thức streaming như SSE (Server-Sent Events).

  Trong các tình huống băng thông cao như AI, giúp giảm đáng kể overhead bộ nhớ.
    
- **Mở rộng dễ dàng**
  
  Cung cấp thư viện plugin chính thức phong phú, bao gồm AI, quản lý traffic, bảo vệ an ninh và các chức năng phổ biến khác, đáp ứng hơn 90% nhu cầu thực tế.

  Tập trung vào mở rộng plugin Wasm, đảm bảo an toàn bộ nhớ qua isolation sandbox, hỗ trợ đa ngôn ngữ lập trình, cho phép nâng cấp độc lập phiên bản plugin và hot update logic gateway không mất traffic.

- **An toàn và dễ sử dụng**
  
  Dựa trên chuẩn Ingress API và Gateway API, cung cấp UI console sẵn sàng sử dụng, plugin bảo vệ WAF, plugin chống CC bằng IP/Cookie.

  Hỗ trợ kết nối Let's Encrypt để cấp và gia hạn chứng chỉ miễn phí tự động, có thể triển khai ngoài K8s, khởi động chỉ với một lệnh Docker, thuận tiện cho lập trình viên cá nhân.

## Cộng đồng

Tham gia cộng đồng Discord của chúng tôi! Đây là nơi bạn có thể kết nối với các lập trình viên và người dùng Higress đam mê khác.

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### Gửi lời cảm ơn

Higress sẽ không thể phát triển nếu thiếu các dự án mã nguồn mở giá trị của cộng đồng. Chúng tôi xin gửi lời cảm ơn đặc biệt tới Envoy và Istio.

### Kho liên quan

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### Đóng góp

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### Lịch sử gắn sao

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ Quay lại đầu trang ↑
    </a>
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---