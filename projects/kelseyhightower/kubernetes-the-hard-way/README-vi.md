# Kubernetes Theo Cách Khó Nhất

Hướng dẫn này sẽ hướng dẫn bạn thiết lập Kubernetes theo cách thủ công. Tài liệu này không dành cho những ai đang tìm kiếm một công cụ tự động hoàn toàn để khởi tạo một cụm Kubernetes. Kubernetes Theo Cách Khó Nhất được tối ưu cho việc học, nghĩa là bạn sẽ đi theo con đường dài hơn để đảm bảo bạn hiểu từng tác vụ cần thiết để khởi tạo một cụm Kubernetes.

> Kết quả của hướng dẫn này không nên được xem là sẵn sàng cho môi trường sản xuất, và có thể chỉ nhận được sự hỗ trợ hạn chế từ cộng đồng, nhưng đừng để điều đó ngăn cản bạn học hỏi!

## Bản quyền

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />Tác phẩm này được cấp phép theo <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a>.


## Đối Tượng Hướng Đến

Đối tượng hướng đến của hướng dẫn này là những người muốn hiểu các nguyên lý cơ bản của Kubernetes và cách các thành phần cốt lõi kết hợp với nhau.

## Thông Tin Cụm

Kubernetes Theo Cách Khó Nhất sẽ hướng dẫn bạn khởi tạo một cụm Kubernetes cơ bản với tất cả các thành phần control plane chạy trên một node duy nhất, và hai node worker, đủ để bạn học các khái niệm cốt lõi.

Phiên bản các thành phần:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Các Phòng Thí Nghiệm

Hướng dẫn này yêu cầu bốn (4) máy ảo hoặc máy vật lý dựa trên ARM64 hoặc AMD64 được kết nối cùng một mạng.

* [Yêu cầu trước](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Thiết lập Jumpbox](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Cấp phát tài nguyên tính toán](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [Cấp phát CA và Tạo chứng chỉ TLS](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Tạo các tệp cấu hình Kubernetes cho xác thực](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Tạo cấu hình và khóa mã hóa dữ liệu](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [Khởi tạo cụm etcd](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Khởi tạo control plane của Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Khởi tạo các node worker của Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [Cấu hình kubectl để truy cập từ xa](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Cấp phát các tuyến mạng Pod](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Kiểm tra hoạt động cơ bản (Smoke Test)](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Dọn dẹp](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---