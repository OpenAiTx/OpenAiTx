# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, còn được gọi là K8s, là một hệ thống mã nguồn mở để quản lý [ứng dụng đóng gói dạng container] trên nhiều máy chủ khác nhau. Nó cung cấp các cơ chế cơ bản cho việc triển khai, bảo trì và mở rộng quy mô ứng dụng.

Kubernetes được phát triển dựa trên hơn mười lăm năm kinh nghiệm của Google trong việc vận hành khối lượng công việc sản xuất ở quy mô lớn bằng hệ thống gọi là [Borg], kết hợp với những ý tưởng và thực tiễn tốt nhất từ cộng đồng.

Kubernetes được lưu trữ bởi Quỹ Điện toán Gốc đám mây ([CNCF]).
Nếu công ty của bạn muốn góp phần định hình sự phát triển của các công nghệ đóng gói container, lên lịch động và định hướng vi dịch vụ, hãy cân nhắc tham gia CNCF.
Để biết chi tiết về các bên tham gia và vai trò của Kubernetes, hãy đọc [thông báo] của CNCF.

----

## Bắt đầu sử dụng K8s

Xem tài liệu của chúng tôi tại [kubernetes.io].

Tham gia khoá học miễn phí về [Vi dịch vụ mở rộng với Kubernetes].

Để sử dụng mã nguồn Kubernetes như một thư viện trong các ứng dụng khác, hãy xem [danh sách các thành phần đã phát hành](https://git.k8s.io/kubernetes/staging/README.md).
Việc sử dụng module `k8s.io/kubernetes` hoặc các gói `k8s.io/kubernetes/...` như thư viện không được hỗ trợ.

## Bắt đầu phát triển K8s

[Kho lưu trữ cộng đồng] chứa tất cả thông tin về việc xây dựng Kubernetes từ mã nguồn, cách đóng góp mã nguồn và tài liệu, liên hệ với ai về vấn đề gì, v.v.

Nếu bạn muốn xây dựng Kubernetes ngay lập tức, có hai lựa chọn:

##### Bạn đã có [môi trường Go] sẵn sàng.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### Bạn đã có [môi trường Docker] sẵn sàng.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Để biết toàn bộ quy trình, hãy truy cập [tài liệu dành cho nhà phát triển].

## Hỗ trợ

Nếu bạn cần hỗ trợ, hãy bắt đầu với [hướng dẫn khắc phục sự cố], và thực hiện theo các bước chúng tôi đã đề xuất.

Tuy nhiên, nếu bạn có câu hỏi, hãy liên hệ với chúng tôi [theo một cách nào đó][liên lạc].

[announcement]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[liên lạc]: https://git.k8s.io/community/communication
[kho lưu trữ cộng đồng]: https://git.k8s.io/community
[ứng dụng đóng gói dạng container]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[tài liệu dành cho nhà phát triển]: https://git.k8s.io/community/contributors/devel#readme
[môi trường Docker]: https://docs.docker.com/engine
[môi trường Go]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Vi dịch vụ mở rộng với Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[hướng dẫn khắc phục sự cố]: https://kubernetes.io/docs/tasks/debug/

## Các cuộc họp cộng đồng

[Calendar](https://www.kubernetes.dev/resources/calendar/) có danh sách tất cả các cuộc họp trong cộng đồng Kubernetes tại một địa điểm duy nhất.

## Đơn vị sử dụng

Trang web [Các nghiên cứu trường hợp người dùng](https://kubernetes.io/case-studies/) có các trường hợp sử dụng thực tế của các tổ chức trên nhiều ngành đang triển khai/di chuyển sang Kubernetes.

## Quản trị

Dự án Kubernetes được quản trị bởi một khung nguyên tắc, giá trị, chính sách và quy trình nhằm hỗ trợ cộng đồng và các thành viên hướng tới các mục tiêu chung.

[Cộng đồng Kubernetes](https://github.com/kubernetes/community/blob/master/governance.md) là điểm khởi đầu để tìm hiểu về cách chúng tôi tổ chức.

[Kho lưu trữ Steering community của Kubernetes](https://github.com/kubernetes/steering) được sử dụng bởi Ủy ban Steering của Kubernetes, giám sát việc quản trị dự án Kubernetes.

## Lộ trình phát triển

[Kho lưu trữ Kubernetes Enhancements](https://github.com/kubernetes/enhancements) cung cấp thông tin về các bản phát hành Kubernetes, cũng như theo dõi tính năng và danh sách công việc tồn đọng.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---