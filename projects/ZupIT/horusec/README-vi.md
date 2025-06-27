<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="version">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="activity">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="contributors">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="security">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="coverage">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="build">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="license">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **Mục lục**
### 1. [**Giới thiệu**](#about)
### 2. [**Bắt đầu**](#getting-started)
>#### 2.1.   [**Yêu cầu**](#requirements)
>#### 2.2.  [**Cài đặt**](#installing-horusec)
### 3. [**Sử dụng**](#usage)
>#### 3.1. [**Sử dụng CLI**](#cli-usage)
>#### 3.2. [**Sử dụng Docker**](#using-docker)
>#### 3.3. [**Phiên bản cũ**](#older-versions)
>#### 3.4. [**Sử dụng ứng dụng Horusec-Web**](#using-horusec-web-application)
>#### 3.5.  [**Sử dụng Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**Sử dụng Pipeline**](#using-the-pipeline)
### 4. [**Tài liệu**](#documentation)       
### 5. [**Lộ trình phát triển**](#roadmap)
### 6. [**Đóng góp**](#contributing)
### 7. [**Quy tắc ứng xử**](#code-of-conduct)
### 8. [**Giấy phép**](#license)
### 9. [**Cộng đồng**](#community)



<br>
<br>
<br>

# **Giới thiệu**
Horusec là một công cụ mã nguồn mở thực hiện phân tích mã tĩnh để xác định các lỗ hổng bảo mật trong quá trình phát triển. Hiện tại, các ngôn ngữ được hỗ trợ phân tích gồm có C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx. 
Công cụ này có các tùy chọn để tìm kiếm rò rỉ khóa và lỗ hổng bảo mật trong tất cả các tệp của dự án, cũng như trong lịch sử Git. Horusec có thể được sử dụng bởi lập trình viên thông qua CLI hoặc bởi nhóm DevSecOps trên các hệ thống CI/CD.

Tham khảo [**Tài liệu**](https://docs.horusec.io/docs/overview/) để xem đầy đủ danh sách công cụ và ngôn ngữ mà Horusec hỗ trợ phân tích.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Xem ví dụ về kết quả xuất ra:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Bắt đầu**

## **Yêu cầu**

- Docker

Bạn cần cài đặt Docker trên máy để chạy Horusec với đầy đủ các công cụ mà chúng tôi sử dụng.
Nếu bạn chưa có Docker, chúng tôi có [**flag**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` để vô hiệu hóa phụ thuộc này, nhưng việc này cũng làm giảm đáng kể khả năng phân tích. 
Chúng tôi khuyến nghị sử dụng Horusec cùng với Docker.

Nếu bạn bật tính năng hiển thị tác giả commit `-G true`, cũng cần cài đặt `git`.

## **Cài đặt Horusec**
### **Mac hoặc Linux**
```
make install
```

hoặc

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **Kiểm tra cài đặt**
```bash
horusec version
```

### **Windows**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **Kiểm tra cài đặt**
```bash
./horusec.exe version
```

### **Và hơn thế nữa**

- Bạn có thể tìm thấy tất cả các bản nhị phân với các phiên bản tại [**trang phát hành**](https://github.com/ZupIT/horusec/releases).

- Để biết thêm chi tiết về cách cài đặt, hãy xem [**tài liệu**](https://docs.horusec.io/docs/cli/installation) 


## **Sử dụng**
### **Sử dụng CLI**
Để sử dụng horusec-cli và kiểm tra các lỗ hổng bảo mật của ứng dụng, sử dụng lệnh sau:
```bash
horusec start -p .
```
> Khi horusec bắt đầu phân tích, nó sẽ tạo một thư mục tên là **`.horusec`**. Thư mục này được tạo ra để không làm thay đổi mã nguồn của bạn. Chúng tôi khuyến nghị thêm dòng **`.horusec`** vào tệp **`.gitignore`** để thư mục này không bị đẩy lên git server của bạn.

### **Sử dụng Docker**
Bạn có thể sử dụng Horusec thông qua image docker **`horuszup/horusec-cli:latest`**.

Chạy lệnh sau để thực hiện:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- Chúng tôi tạo một volume chứa dự án `-v $(pwd):/src`.

Với image docker, chúng ta sẽ có hai đường dẫn nơi có thể tìm thấy dự án.

Flag `-p` sẽ đại diện cho đường dẫn dự án bên trong container, ví dụ `/src`.
Flag `-P` sẽ đại diện cho đường dẫn dự án bên ngoài container, trong ví dụ là `$(pwd)`, 
và cần truyền đường dẫn này khi mount volume `-v $(pwd):/src`.

### **Phiên bản cũ**

Horusec v1 vẫn còn khả dụng.

**CẢNH BÁO:** Endpoint của v1 sẽ bị ngưng hỗ trợ, vui lòng nâng cấp CLI lên v2. Xem chi tiết trong [**tài liệu**](https://docs.horusec.io/docs/migrate-v1-to-v2/). 

### **Mac hoặc Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- Các bản nhị phân cũ có thể tìm thấy tại endpoint này, bao gồm cả phiên bản v1 mới nhất **`v1.10.3`**. 
- Từ v2, các bản nhị phân sẽ không còn được phân phối tại endpoint này nữa, bạn có thể tìm tại [**trang phát hành**](https://github.com/ZupIT/horusec/releases).

### **Sử dụng ứng dụng Horusec-Web**
Quản lý các lỗ hổng của bạn qua giao diện web của chúng tôi. Bạn sẽ có dashboard về các chỉ số lỗ hổng, kiểm soát false positive, token xác thực, cập nhật lỗ hổng và nhiều hơn nữa.
Tham khảo mục [**web application**](https://github.com/ZupIT/horusec-platform) để biết thêm chi tiết.

Xem ví dụ dưới đây, gửi phân tích lên dịch vụ web của Horusec:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

Xem [**hướng dẫn tạo token xác thực thông qua Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**CẢNH BÁO:** Dịch vụ web đã được chuyển sang [**repository mới**](https://github.com/ZupIT/horusec-platform). Bạn cần nâng cấp lên v2, xem [**hướng dẫn chuyển đổi từ v1 sang v2**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **Sử dụng Visual Studio Code**
Bạn có thể phân tích dự án của mình bằng extension Horusec cho Visual Studio Code.
Để biết thêm thông tin, [**xem tài liệu**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Sử dụng Pipeline**
Bạn có thể thực hiện phân tích dự án trước khi triển khai để đảm bảo an toàn tối đa cho tổ chức.
Để biết thêm thông tin, [**xem tài liệu**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Tính năng**
Xem bên dưới: 
- Phân tích đồng thời 18 ngôn ngữ với 20 công cụ bảo mật khác nhau để tăng độ chính xác;
- Tìm kiếm lịch sử git của dự án để phát hiện lộ lọt secrets và các nội dung nhạy cảm khác;
- Phân tích có thể cấu hình hoàn toàn, [**xem tất cả tài nguyên CLI có sẵn**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Tài liệu**
Bạn có thể tìm tài liệu của Horusec tại [**website**](https://docs.horusec.io/docs/overview/).

## **Lộ trình phát triển**
Chúng tôi có [**lộ trình phát triển**](https://raw.githubusercontent.com/ZupIT/horusec/main/ROADMAP.md), bạn có thể đóng góp cùng chúng tôi!

Horusec còn có nhiều repository khác, hãy khám phá:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)
## **Đóng góp**

Hãy thoải mái sử dụng, đề xuất cải tiến hoặc đóng góp các tính năng mới.

Xem [**hướng dẫn đóng góp**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) để tìm hiểu về quy trình phát triển của chúng tôi, cách đề xuất sửa lỗi và cải tiến.

### **Chứng nhận Nhà phát triển - DCO**

Đây là một lớp bảo mật cho dự án và các nhà phát triển. Việc này là bắt buộc.

Thực hiện theo một trong hai phương pháp sau để thêm DCO vào các commit của bạn:

**1. Dòng lệnh**
Làm theo các bước:
**Bước 1:** Cấu hình môi trường git cục bộ của bạn bằng cách thêm tên và email giống như đã cấu hình trên tài khoản GitHub. Điều này giúp ký các commit một cách thủ công trong quá trình xem xét và đề xuất.

```
git config --global user.name “Tên”
git config --global user.email “email@domain.com.br”
```
**Bước 2:** Thêm dòng Signed-off-by với cờ `'-s'` trong lệnh git commit:

```
$ git commit -s -m "Đây là thông điệp commit của tôi"
```
**2. Trang web GitHub**

Bạn cũng có thể ký commit một cách thủ công trong quá trình xem xét và đề xuất trên GitHub, làm theo các bước sau:

**Bước 1:** Khi hộp thay đổi commit mở ra, hãy nhập hoặc dán chữ ký của bạn vào ô bình luận, ví dụ:

```
Signed-off-by: Tên < địa chỉ e-mail >
```

Với phương pháp này, tên và email của bạn phải trùng với thông tin đã đăng ký trên tài khoản GitHub.

## **Quy tắc Ứng xử**
Vui lòng tuân thủ [**Quy tắc Ứng xử**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) trong tất cả các tương tác của bạn với dự án của chúng tôi.

## **Giấy phép**
[**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Cộng đồng**

Hãy thoải mái liên hệ với chúng tôi tại:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Nếu bạn có bất kỳ câu hỏi hoặc ý tưởng nào, hãy thảo luận tại [**Diễn đàn Mã nguồn mở Zup**](https://forum.zup.com.br).


Dự án này tồn tại nhờ tất cả các nhà đóng góp. Các bạn thật tuyệt vời! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---