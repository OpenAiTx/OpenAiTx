# Gitleaks

```
┌─○───┐
│ │╲  │
│ │ ○ │
│ ○ ░ │
└─░───┘
```

[license]: https://raw.githubusercontent.com/gitleaks/gitleaks/master/LICENSE
[badge-license]: https://img.shields.io/github/license/gitleaks/gitleaks.svg
[go-docs-badge]: https://pkg.go.dev/badge/github.com/gitleaks/gitleaks/v8?status
[go-docs]: https://pkg.go.dev/github.com/zricethezav/gitleaks/v8
[badge-build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml/badge.svg
[build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml
[go-report-card-badge]: https://goreportcard.com/badge/github.com/gitleaks/gitleaks/v8
[go-report-card]: https://goreportcard.com/report/github.com/gitleaks/gitleaks/v8
[dockerhub]: https://hub.docker.com/r/zricethezav/gitleaks
[dockerhub-badge]: https://img.shields.io/docker/pulls/zricethezav/gitleaks.svg
[gitleaks-action]: https://github.com/gitleaks/gitleaks-action
[gitleaks-badge]: https://img.shields.io/badge/protected%20by-gitleaks-blue
[gitleaks-playground-badge]: https://img.shields.io/badge/gitleaks%20-playground-blue
[gitleaks-playground]: https://gitleaks.io/playground


[![GitHub Action Test][badge-build]][build]
[![Docker Hub][dockerhub-badge]][dockerhub]
[![Gitleaks Playground][gitleaks-playground-badge]][gitleaks-playground]
[![Gitleaks Action][gitleaks-badge]][gitleaks-action]
[![GoDoc][go-docs-badge]][go-docs]
[![GoReportCard][go-report-card-badge]][go-report-card]
[![License][badge-license]][license]


### Tham gia Discord của chúng tôi! [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

Gitleaks là một công cụ dùng để **phát hiện** các bí mật như mật khẩu, khóa API và token trong các repo git, file, và bất kỳ thứ gì khác mà bạn muốn kiểm tra qua `stdin`. Nếu bạn muốn tìm hiểu thêm về cách hoạt động của engine phát hiện, hãy xem bài blog này: [Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need).

```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


Finding:     "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
Secret:      cafebabe:deadbeef
RuleID:      sidekiq-secret
Entropy:     2.609850
File:        cmd/generate/config/rules/sidekiq.go
Line:        23
Commit:      cd5226711335c68be1e720b318b7bc3135a30eb2
Author:      John
Email:       john@users.noreply.github.com
Date:        2022-08-03T12:31:40Z
Fingerprint: cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## Bắt đầu

Gitleaks có thể được cài đặt bằng Homebrew, Docker, hoặc Go. Gitleaks cũng có sẵn dưới dạng file nhị phân cho nhiều nền tảng và hệ điều hành phổ biến trên [trang phát hành](https://github.com/gitleaks/gitleaks/releases). Ngoài ra, Gitleaks có thể được triển khai như một pre-commit hook trực tiếp trong repo của bạn hoặc như một GitHub action sử dụng [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action).

### Cài đặt

```bash
# MacOS
brew install gitleaks

# Docker (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Docker (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Cài đặt từ mã nguồn (đảm bảo đã cài đặt `go`)
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### GitHub Action

Xem [Gitleaks GitHub Action](https://github.com/gitleaks/gitleaks-action) chính thức

```
name: gitleaks
on: [pull_request, push, workflow_dispatch]
jobs:
  scan:
    name: gitleaks
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v3
        with:
          fetch-depth: 0
      - uses: gitleaks/gitleaks-action@v2
        env:
          GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # Chỉ cần cho Organizations, không cần cho tài khoản cá nhân.
```

### Pre-Commit

1. Cài đặt pre-commit từ https://pre-commit.com/#install
2. Tạo file `.pre-commit-config.yaml` ở thư mục gốc của repo của bạn với nội dung sau:

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   cho [cách chạy gitleaks native](https://github.com/gitleaks/gitleaks/releases) hoặc sử dụng [`gitleaks-docker` pre-commit ID](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.pre-commit-hooks.yaml) để chạy gitleaks sử dụng [Docker images chính thức](#docker)

3. Tự động cập nhật config đến phiên bản mới nhất của repo bằng cách chạy `pre-commit autoupdate`
4. Cài đặt với `pre-commit install`
5. Bây giờ bạn đã sẵn sàng!

```
➜ git commit -m "this commit contains a secret"
Detect hardcoded secrets.................................................Failed
```

Lưu ý: để vô hiệu hóa gitleaks pre-commit hook bạn có thể thêm tiền tố `SKIP=gitleaks` vào lệnh commit
và nó sẽ bỏ qua việc chạy gitleaks

```
➜ SKIP=gitleaks git commit -m "skip gitleaks check"
Detect hardcoded secrets................................................Skipped
```

## Cách sử dụng

```
Usage:
  gitleaks [command]

Available Commands:
  dir         quét thư mục hoặc file để tìm bí mật
  git         quét các repo git để tìm bí mật
  help        Trợ giúp về lệnh bất kỳ
  stdin       phát hiện bí mật từ stdin
  version     hiển thị phiên bản gitleaks

Flags:
  -b, --baseline-path string          đường dẫn đến baseline với các vấn đề có thể bỏ qua
  -c, --config string                 đường dẫn file cấu hình
                                      thứ tự ưu tiên:
                                      1. --config/-c
                                      2. biến môi trường GITLEAKS_CONFIG
                                      3. biến môi trường GITLEAKS_CONFIG_TOML với nội dung file
                                      4. (đường dẫn mục tiêu)/.gitleaks.toml
                                      Nếu không dùng một trong bốn tùy chọn trên, gitleaks sẽ dùng cấu hình mặc định
      --diagnostics string            bật chẩn đoán (danh sách phân tách bằng dấu phẩy: cpu,mem,trace). cpu=profile CPU, mem=profile bộ nhớ, trace=theo dõi thực thi
      --diagnostics-dir string        thư mục lưu file xuất chẩn đoán (mặc định là thư mục hiện tại)
      --enable-rule strings           chỉ bật các rule nhất định theo id
      --exit-code int                 mã thoát khi phát hiện rò rỉ (mặc định 1)
  -i, --gitleaks-ignore-path string   đường dẫn tới file .gitleaksignore hoặc thư mục chứa nó (mặc định ".")
  -h, --help                          trợ giúp cho gitleaks
      --ignore-gitleaks-allow         bỏ qua các comment gitleaks:allow
  -l, --log-level string              mức log (trace, debug, info, warn, error, fatal) (mặc định "info")
      --max-decode-depth int          cho phép giải mã lồng nhau đến mức này (mặc định "0", không giải mã)
      --max-archive-depth int         cho phép quét archive lồng nhau đến mức này (mặc định "0", không quét archive)
      --max-target-megabytes int      file lớn hơn giá trị này sẽ bị bỏ qua
      --no-banner                     ẩn banner
      --no-color                      tắt màu cho output chi tiết
      --redact uint[=100]             che giấu bí mật trong log và stdout. Để che một phần bí mật hãy dùng giá trị phần trăm từ 0..100. Ví dụ --redact=20 (mặc định 100%)
  -f, --report-format string          định dạng xuất ra (json, csv, junit, sarif, template)
  -r, --report-path string            file báo cáo
      --report-template string        file template dùng để tạo báo cáo (bao hàm --report-format=template)
  -v, --verbose                       hiển thị kết quả quét chi tiết
      --version                       phiên bản của gitleaks

Dùng "gitleaks [command] --help" để biết thêm thông tin về một lệnh.
```

### Các lệnh

⚠️ v8.19.0 đã thay đổi và loại bỏ `detect` và `protect`. Các lệnh này vẫn còn nhưng
đã bị ẩn trong menu `--help`. Xem [gist này](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) để chuyển đổi lệnh một cách dễ dàng.
Nếu bạn thấy v8.19.0 làm hỏng lệnh hiện có (`detect`/`protect`), vui lòng mở issue.

Có ba chế độ quét: `git`, `dir`, và `stdin`.

#### Git

Lệnh `git` cho phép bạn quét các repo git cục bộ. Bên trong, gitleaks sử dụng lệnh `git log -p` để quét các bản vá.
Bạn có thể cấu hình hành vi của `git log -p` với tùy chọn `log-opts`.
Ví dụ, nếu bạn muốn chạy gitleaks trên một dải commit bạn có thể dùng lệnh sau: 
`gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`. Xem tài liệu [git log](https://git-scm.com/docs/git-log) để biết thêm chi tiết.
Nếu không có mục tiêu nào được chỉ định như một đối số vị trí, thì gitleaks sẽ cố gắng quét thư mục làm việc hiện tại như một repo git.
#### Dir

Lệnh `dir` (các bí danh bao gồm `files`, `directory`) cho phép bạn quét các thư mục và tệp tin. Ví dụ: `gitleaks dir -v đường_dẫn_đến_thư_mục_hoặc_tệp_tin`.
Nếu không có mục tiêu nào được chỉ định làm đối số vị trí, thì gitleaks sẽ quét thư mục làm việc hiện tại.

#### Stdin

Bạn cũng có thể truyền dữ liệu vào gitleaks bằng lệnh `stdin`. Ví dụ: `cat một_tệp_tin | gitleaks -v stdin`

### Tạo một baseline

Khi quét các kho lưu trữ lớn hoặc kho lưu trữ có lịch sử dài, việc sử dụng một baseline có thể tiện lợi. Khi sử dụng baseline,
gitleaks sẽ bỏ qua bất kỳ phát hiện cũ nào đã có trong baseline. Một baseline có thể là bất kỳ báo cáo gitleaks nào. Để tạo một báo cáo gitleaks, chạy gitleaks với tham số `--report-path`.

```
gitleaks git --report-path gitleaks-report.json # Lệnh này sẽ lưu báo cáo vào tệp có tên gitleaks-report.json
```

Sau khi baseline được tạo, nó có thể được áp dụng khi chạy lại lệnh detect:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

Sau khi chạy lệnh detect với tham số --baseline-path, đầu ra báo cáo (findings.json) sẽ chỉ chứa các vấn đề mới.

## Pre-Commit hook

Bạn có thể chạy Gitleaks như một pre-commit hook bằng cách sao chép script ví dụ `pre-commit.py` vào
thư mục `.git/hooks/` của bạn.

## Nạp cấu hình

Thứ tự ưu tiên là:

1. Tùy chọn `--config/-c`:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Biến môi trường `GITLEAKS_CONFIG` với đường dẫn tệp:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Biến môi trường `GITLEAKS_CONFIG_TOML` với nội dung tệp:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. Một tệp `.gitleaks.toml` trong đường dẫn mục tiêu:
      ```bash
      gitleaks git .
      ```

Nếu không sử dụng bất kỳ bốn tùy chọn nào ở trên, gitleaks sẽ sử dụng cấu hình mặc định.

## Cấu hình

Gitleaks cung cấp một định dạng cấu hình để bạn viết các quy tắc phát hiện bí mật của riêng mình:

```toml
# Tiêu đề cho tệp cấu hình gitleaks.
title = "Custom Gitleaks configuration"

# Bạn có về cơ bản hai lựa chọn cho cấu hình tùy chỉnh:
#
# 1. tự định nghĩa cấu hình của bạn, các quy tắc mặc định sẽ không áp dụng
#
#    ví dụ, sử dụng cấu hình mặc định làm điểm khởi đầu:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. mở rộng một cấu hình, các quy tắc sẽ bị ghi đè hoặc được mở rộng
#
#    Khi bạn mở rộng một cấu hình, các quy tắc mở rộng sẽ được ưu tiên hơn
#    các quy tắc mặc định. Tức là, nếu có các quy tắc trùng lặp trong cả cấu hình mở rộng
#    và cấu hình mặc định thì các quy tắc hoặc thuộc tính mở rộng sẽ ghi đè các quy tắc mặc định.
#    Một điều nữa cần biết khi mở rộng cấu hình là bạn có thể xâu chuỗi
#    nhiều tệp cấu hình với độ sâu 2. Các mảng Allowlist sẽ được nối vào và có thể chứa trùng lặp.

# useDefault và path KHÔNG thể được sử dụng cùng lúc. Chọn một trong hai.
[extend]
# useDefault sẽ mở rộng cấu hình gitleaks mặc định được tích hợp trong binary
# phiên bản mới nhất nằm tại:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# hoặc bạn có thể cung cấp đường dẫn đến một cấu hình để mở rộng từ đó.
# Đường dẫn là tương đối với nơi gitleaks được gọi,
# không phải vị trí của cấu hình gốc.
# path = "common_config.toml"
# Nếu có bất kỳ quy tắc nào bạn không muốn kế thừa, hãy chỉ định tại đây.
disabledRules = [ "generic-api-key"]

# Một mảng các bảng chứa thông tin xác định hướng dẫn
# về cách phát hiện bí mật
[[rules]]
# Định danh duy nhất cho quy tắc này
id = "awesome-rule-1"

# Mô tả ngắn dễ hiểu cho quy tắc.
description = "awesome rule 1"

# Biểu thức chính quy Golang dùng để phát hiện bí mật. Lưu ý engine regex của Golang
# không hỗ trợ lookaheads.
regex = '''one-go-style-regex-for-this-rule'''

# Số nguyên dùng để trích xuất bí mật từ kết quả regex và dùng làm nhóm sẽ được kiểm tra
# entropy nếu `entropy` được đặt.
secretGroup = 3

# Số thực biểu diễn entropy shannon tối thiểu mà một nhóm regex phải có để được coi là bí mật.
entropy = 3.5

# Biểu thức chính quy Golang dùng để khớp đường dẫn. Có thể sử dụng như một quy tắc độc lập hoặc
# kết hợp với một mục `regex` hợp lệ.
path = '''a-file-path-regex'''

# Keywords được dùng để lọc trước khi kiểm tra regex. Các quy tắc chứa
# từ khóa sẽ thực hiện kiểm tra so sánh chuỗi nhanh để đảm bảo
# từ khóa xuất hiện trong nội dung được quét. Lý tưởng là các giá trị này nên
# là một phần của định danh hoặc chuỗi đặc biệt riêng cho regex của quy tắc
# (giới thiệu từ v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# Mảng chuỗi dùng cho mục đích metadata và báo cáo.
tags = ["tag","another tag"]

    # ⚠️ Trong v8.21.0 `[rules.allowlist]` được thay bằng `[[rules.allowlists]]`.
    # Thay đổi này tương thích ngược: các trường hợp `[rules.allowlist]` vẫn hoạt động.
    #
    # Bạn có thể định nghĩa nhiều allowlists cho một quy tắc để giảm false positive.
    # Một phát hiện sẽ bị bỏ qua nếu _BẤT KỲ_ `[[rules.allowlists]]` nào khớp.
    [[rules.allowlists]]
    description = "bỏ qua commit A"
    # Khi có nhiều tiêu chí được định nghĩa, điều kiện mặc định là "OR".
    # ví dụ, có thể khớp với |commits| HOẶC |paths| HOẶC |stopwords|.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # lưu ý: stopwords nhắm vào bí mật được trích xuất, không phải toàn bộ kết quả regex
    # như 'regexes' làm. (stopwords giới thiệu từ 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # Điều kiện "AND" có thể được sử dụng để đảm bảo tất cả tiêu chí đều khớp.
    # ví dụ, khớp nếu |regexes| VÀ |paths| đều thỏa mãn.
    condition = "AND"
    # lưu ý: |regexes| mặc định kiểm tra _Secret_ trong phát hiện.
    # Giá trị hợp lệ cho |regexTarget| là "secret" (mặc định), "match", và "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Bạn có thể mở rộng một quy tắc cụ thể từ cấu hình mặc định. ví dụ, gitlab-pat
# nếu bạn đã định nghĩa prefix token tùy chỉnh trên GitLab của mình
[[rules]]
id = "gitlab-pat"
# các thuộc tính khác từ quy tắc mặc định sẽ được kế thừa

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ Trong v8.25.0 `[allowlist]` được thay bằng `[[allowlists]]`.
#
# Global allowlists có mức ưu tiên cao hơn allowlists theo quy tắc.
# Nếu một commit liệt kê trong trường `commits` bên dưới được phát hiện thì commit đó sẽ bị bỏ qua và
# sẽ không phát hiện bí mật nào trong commit đó. Logic tương tự áp dụng cho regexes và paths.
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# lưu ý: (global) regexTarget mặc định kiểm tra _Secret_ trong phát hiện.
# Giá trị hợp lệ cho regexTarget là "match" và "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# lưu ý: stopwords nhắm vào bí mật được trích xuất, không phải toàn bộ kết quả regex
# như 'regexes' làm. (stopwords giới thiệu từ 8.8.0)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ Trong phiên bản v8.25.0, `[[allowlists]]` có trường mới gọi là |targetRules|.
#
# Danh sách cho phép dùng chung có thể được định nghĩa một lần và gán cho nhiều rule bằng |targetRules|.
# Điều này chỉ chạy trên các rule được chỉ định, không áp dụng toàn cục.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "Các tài sản kiểm thử của chúng tôi gây ra cảnh báo dương tính giả ở một vài rule."
paths = ['''tests/expected/._\.json$''']
```

Tham khảo [cấu hình mặc định của gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) để xem ví dụ hoặc làm theo [hướng dẫn đóng góp](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md) nếu bạn muốn đóng góp vào cấu hình mặc định. Ngoài ra, bạn cũng có thể xem [bài viết blog về gitleaks này](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) để biết thêm về các thiết lập cấu hình nâng cao.

### Cấu Hình Bổ Sung

#### gitleaks:allow

Nếu bạn cố tình commit một secret kiểm thử mà gitleaks sẽ phát hiện, bạn có thể thêm comment `gitleaks:allow` vào dòng đó để gitleaks
bỏ qua secret này. Ví dụ:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Bạn có thể bỏ qua các phát hiện cụ thể bằng cách tạo một file `.gitleaksignore` ở thư mục gốc của repo. Trong phiên bản v8.10.0, Gitleaks đã thêm giá trị `Fingerprint` vào báo cáo Gitleaks. Mỗi lỗ hổng, hoặc phát hiện, có một Fingerprint giúp nhận diện secret một cách duy nhất. Thêm fingerprint này vào file `.gitleaksignore` để bỏ qua secret cụ thể đó. Xem ví dụ tại [.gitleaksignore của Gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore). Lưu ý: tính năng này đang ở trạng thái thử nghiệm và có thể thay đổi trong tương lai.

#### Giải Mã (Decoding)

Đôi khi các secret được mã hóa khiến cho việc tìm kiếm bằng regex trở nên khó khăn.
Giờ đây, bạn có thể yêu cầu gitleaks tự động tìm và giải mã các đoạn mã hóa.
Tham số `--max-decode-depth` sẽ kích hoạt tính năng này (giá trị mặc định "0" nghĩa là tính năng này bị tắt mặc định).

Hỗ trợ giải mã đệ quy vì văn bản giải mã có thể tiếp tục chứa đoạn mã hóa.
Tham số `--max-decode-depth` đặt giới hạn đệ quy. Đệ quy dừng lại khi không còn đoạn mã hóa nào mới để giải mã, do đó đặt giá trị max depth cao không có nghĩa là sẽ chạy nhiều lần như vậy. Nó chỉ chạy đúng số lần cần thiết để giải mã xong. Nhìn chung, giải mã chỉ làm tăng thời gian quét một cách tối thiểu.

Các phát hiện cho văn bản đã mã hóa sẽ khác với phát hiện bình thường ở các điểm sau:

- Vị trí chỉ ra phạm vi của đoạn mã hóa
  - Nếu rule khớp bên ngoài đoạn mã hóa, phạm vi sẽ được điều chỉnh để bao gồm cả phần đó
- Match và secret chứa giá trị đã giải mã
- Hai tag được thêm vào: `decoded:<encoding>` và `decode-depth:<depth>`

Hiện tại hỗ trợ các kiểu mã hóa:

- **percent** - Bất kỳ giá trị mã hóa phần trăm ASCII in được nào
- **hex** - Bất kỳ giá trị mã hóa hex ASCII in được nào có độ dài >= 32 ký tự
- **base64** - Bất kỳ giá trị mã hóa base64 ASCII in được nào có độ dài >= 16 ký tự

#### Quét Tập Tin Nén (Archive Scanning)

Đôi khi các secret được đóng gói trong các tập tin nén như zip hoặc tarball,
khiến chúng khó bị phát hiện. Giờ đây, bạn có thể yêu cầu gitleaks tự động
giải nén và quét nội dung của các tập tin nén. Tham số `--max-archive-depth`
kích hoạt tính năng này cho cả hai loại quét `dir` và `git`. Giá trị mặc định
"0" nghĩa là tính năng này bị tắt mặc định.

Hỗ trợ quét đệ quy vì bên trong tập tin nén có thể chứa tập tin nén khác.
Tham số `--max-archive-depth` đặt giới hạn đệ quy. Đệ quy dừng khi không còn tập tin nén nào mới để giải nén, do đó đặt giá trị max depth cao chỉ tăng tiềm năng quét sâu hơn. Quét sẽ chỉ đi sâu đến mức cần thiết.

Các phát hiện secret nằm trong archive sẽ bao gồm đường dẫn đến file bên trong archive. Các đường dẫn lồng nhau được phân tách bằng ký tự `!`.

Ví dụ phát hiện (đã rút gọn):

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

Điều này có nghĩa là một secret đã được phát hiện tại dòng 4 của `files/.env.prod.`, nằm trong
`archives/files.tar` và tập tin này lại nằm trong `testdata/archives/nested.tar.gz`.

Các định dạng hiện được hỗ trợ:

Các định dạng [nén](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
và [archive](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
do gói [archives của mholt](https://github.com/mholt/archives) hỗ trợ đều được chấp nhận.

#### Báo Cáo (Reporting)

Gitleaks tích hợp sẵn hỗ trợ nhiều định dạng báo cáo: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml), và [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Nếu các định dạng này không đáp ứng nhu cầu của bạn, bạn có thể tự tạo định dạng báo cáo với [file Go `text/template` .tmpl](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) và tham số `--report-template`. Template có thể sử dụng [chức năng mở rộng từ thư viện template `Masterminds/sprig`](https://masterminds.github.io/sprig/).

Ví dụ, template sau cung cấp đầu ra JSON tùy chỉnh:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

Cách sử dụng:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## Nhà Tài Trợ

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## Mã Thoát (Exit Codes)

Bạn luôn có thể đặt mã thoát khi phát hiện lỗ hổng bằng tham số --exit-code. Mặc định các mã thoát như sau:

```
0 - không có lỗ hổng
1 - phát hiện lỗ hổng hoặc lỗi
126 - cờ không xác định
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---