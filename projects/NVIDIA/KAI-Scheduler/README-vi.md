[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler là một [trình lập lịch Kubernetes](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) mạnh mẽ, hiệu quả và có khả năng mở rộng, tối ưu hóa phân bổ tài nguyên GPU cho các khối lượng công việc AI và học máy.

Được thiết kế để quản lý các cụm GPU quy mô lớn, bao gồm hàng nghìn nút và lưu lượng công việc cao, KAI Scheduler lý tưởng cho các môi trường lớn và đòi hỏi khắt khe.
KAI Scheduler cho phép quản trị viên của các cụm Kubernetes phân bổ động tài nguyên GPU cho các khối lượng công việc.

KAI Scheduler hỗ trợ toàn bộ vòng đời AI, từ các tác vụ nhỏ, tương tác đòi hỏi ít tài nguyên đến các tác vụ huấn luyện và suy luận lớn, tất cả đều trong cùng một cụm.
Nó đảm bảo phân bổ tài nguyên tối ưu đồng thời duy trì sự công bằng tài nguyên giữa các người dùng khác nhau.
Nó có thể chạy song song với các trình lập lịch khác được cài đặt trên cụm.

## Tính năng chính
* [Lập lịch theo lô (Batch Scheduling)](docs/batch/README.md): Đảm bảo tất cả các pod trong một nhóm được lập lịch đồng thời hoặc không pod nào được lập lịch.
* Đóng gói và phân tán (Bin Packing & Spread Scheduling): Tối ưu hóa việc sử dụng nút bằng cách giảm phân mảnh (bin-packing) hoặc tăng khả năng phục hồi và cân bằng tải (spread scheduling).
* [Ưu tiên khối lượng công việc](docs/priority/README.md): Ưu tiên hiệu quả các khối lượng công việc trong hàng đợi.
* [Hàng đợi phân cấp](docs/queues/README.md): Quản lý khối lượng công việc với cấu trúc hàng đợi hai cấp, mang lại khả năng kiểm soát tổ chức linh hoạt.
* [Phân phối tài nguyên](docs/fairness/README.md#resource-division-algorithm): Tùy chỉnh hạn ngạch, hệ số vượt hạn ngạch, giới hạn, và mức độ ưu tiên cho từng hàng đợi.
* [Chính sách công bằng](docs/fairness/README.md#reclaim-strategies): Đảm bảo phân phối tài nguyên công bằng bằng Dominant Resource Fairness (DRF) và thu hồi tài nguyên giữa các hàng đợi.
* Hợp nhất khối lượng công việc: Phân bổ lại thông minh các khối lượng công việc đang chạy để giảm phân mảnh và tăng hiệu quả sử dụng cụm.
* [Khối lượng công việc co giãn](docs/elastic/README.md): Tự động mở rộng hoặc thu hẹp khối lượng công việc trong phạm vi số lượng pod tối thiểu và tối đa xác định.
* Phân bổ tài nguyên động (DRA): Hỗ trợ tài nguyên phần cứng theo nhà cung cấp thông qua Kubernetes ResourceClaims (ví dụ: GPU của NVIDIA hoặc AMD).
* [Chia sẻ GPU](docs/gpu-sharing/README.md): Cho phép nhiều khối lượng công việc chia sẻ hiệu quả một hoặc nhiều GPU, tối đa hóa hiệu suất sử dụng tài nguyên.
* Hỗ trợ đám mây & tại chỗ: Tương thích hoàn toàn với hạ tầng đám mây động (bao gồm auto-scalers như Karpenter) cũng như các triển khai cố định tại chỗ.

## Điều kiện tiên quyết
Trước khi cài đặt KAI Scheduler, hãy đảm bảo bạn đã có:

- Một cụm Kubernetes đang hoạt động
- Đã cài đặt CLI [Helm](https://helm.sh/docs/intro/install)
- Đã cài đặt [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) để có thể lập lịch cho các khối lượng công việc yêu cầu tài nguyên GPU

## Cài đặt
KAI Scheduler sẽ được cài đặt vào namespace `kai-scheduler`. Khi gửi khối lượng công việc, hãy đảm bảo sử dụng một namespace riêng biệt.

### Các phương pháp cài đặt
KAI Scheduler có thể được cài đặt:

- **Từ bản phát hành chính thức (Khuyến nghị)**
- **Từ mã nguồn (Tự biên dịch)**

#### Cài đặt từ bản phát hành chính thức
Tìm phiên bản phát hành mới nhất tại trang [releases](https://github.com/NVIDIA/KAI-Scheduler/releases).
Chạy lệnh sau sau khi thay thế `<VERSION>` bằng phiên bản phát hành mong muốn:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Biên dịch từ mã nguồn
Làm theo hướng dẫn [tại đây](docs/developer/building-from-source.md)

## Bắt đầu nhanh
Để bắt đầu lập lịch khối lượng công việc với KAI Scheduler, vui lòng tiếp tục đến [ví dụ bắt đầu nhanh](docs/quickstart/README.md)

## Lộ trình phát triển

### Tổng quan các ưu tiên chính cho năm 2025
* Tái cấu trúc mã nguồn để tăng tính trung lập với nhà cung cấp
* Hỗ trợ Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Nghiên cứu khả năng tích hợp với Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Thêm hỗ trợ lập lịch nhận biết cấu trúc topo cho pod-group https://github.com/NVIDIA/KAI-Scheduler/issues/66
* Hỗ trợ thời gian chạy tối thiểu cho mỗi khối lượng công việc
* Hỗ trợ thời gian chạy tối đa cho mỗi khối lượng công việc (có xếp hàng lại trễ)
* Thêm nhiều PriorityClasses trong bản cài đặt mặc định của KAI
* Hỗ trợ JobSet
* Hỗ trợ LWS (LeaderWorkerSet)
* Thêm số liệu cho việc thu hồi pod và pod-group
* Tách biệt Priority và Preemption

### Mục tiêu dài hạn
* Hỗ trợ giảm dần thời gian theo hàng đợi
* Cải thiện khả năng mở rộng siêu lớn
* Hỗ trợ hợp nhất các khối lượng công việc suy luận để giảm phân mảnh cụm
* Hỗ trợ n cấp hàng đợi phân cấp
* Triển khai trơn tru các khối lượng công việc suy luận (cập nhật phiên bản mới bằng cách sử dụng hàng đợi vượt hạn ngạch tạm thời)

## Cộng đồng, thảo luận và hỗ trợ

Chúng tôi rất mong nhận được phản hồi từ bạn! Dưới đây là những cách kết nối tốt nhất:

### Slack
Tham gia [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf) trước và truy cập kênh [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler).

### Cuộc gọi cộng đồng hai tuần một lần  
**Khi nào:** Thứ Hai cách tuần lúc 17:00 CEST  
[Chuyển đổi sang múi giờ của bạn](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Thêm vào lịch](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Ghi chú & chương trình họp](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Danh sách thư  
Tham gia [danh sách thư kai-scheduler](https://groups.google.com/g/kai-scheduler) để nhận cập nhật về các cuộc họp hai tuần một lần.

### Vấn đề kỹ thuật & yêu cầu tính năng  
Vui lòng mở một [vấn đề trên GitHub](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) cho các lỗi, đề xuất tính năng hoặc cần hỗ trợ kỹ thuật. Điều này giúp chúng tôi theo dõi các yêu cầu và phản hồi hiệu quả.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---