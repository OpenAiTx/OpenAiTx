![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Bạn có thể đọc [bài báo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) của tôi và trích dẫn như sau 
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Do GitHub có thể chặn các địa chỉ IP Trung Quốc, tôi phải sao chép kho lưu trữ này sang [đây](https://codeberg.org/ufo5260987423/scheme-langserver) và [đây](https://gitee.com/ufo5260987423/scheme-langserver). Tôi sẽ liên tục cập nhật tất cả các kho lưu trữ nhưng tôi không thể đảm bảo. Hiện tôi cũng đang hợp tác với [XmacsLabs](https://github.com/XmacsLabs), bạn cũng có thể tìm thấy một nhánh tại [đây](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Hiện tại, VSCode đã có thể sử dụng scheme-langserver!** Vui lòng tham khảo [TẠI ĐÂY](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

> LƯU Ý: Có rất nhiều lỗi trong scheme-langserver. Tôi đang sửa chữa và kêu gọi sự giúp đỡ từ cộng đồng. Xin hãy kiên nhẫn.

> LƯU Ý: bạn có thể tìm thông tin kiểu tự động sinh tại [đây](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Hiện nó chủ yếu được sử dụng cho phát triển giai đoạn tiếp theo (có thể bao gồm cả AKKU) và gỡ lỗi.

Việc triển khai các hỗ trợ như tự động hoàn thành, đi đến định nghĩa, hoặc hiển thị tài liệu khi di chuột là một nỗ lực lớn trong lập trình. Tuy nhiên, so với các ngôn ngữ khác như java, python, javascript và c, các triển khai language server protocol cho ngôn ngữ lisp chỉ mới được thực hiện trong môi trường chân không. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) và [swish-lint](https://github.com/becls/swish-lint) v.v., các công cụ này đều dựa trên `repl`(Read-Eval-Print Loop) hoặc bộ tách từ khóa thay vì lập trình thực thụ. Ví dụ, nếu một lập trình viên đang viết mã cho một dự án chưa hoàn thiện, trong đó mã chưa thể thực thi hoàn toàn, [Geiser](https://gitlab.com/emacs-geiser) hoặc bất kỳ công cụ nào khác chỉ hoàn thành các định danh được liên kết ở cấp cao nhất được liệt kê bởi thủ tục `environment-symbols` (cho [Chez](https://cisco.github.io/ChezScheme/)), hoặc hoàn thành các ký hiệu thay vì định danh. Điều này có nghĩa là đối với các liên kết cục bộ và mã chưa hoàn thiện, mặc dù nỗ lực lập trình được cho là rất quan trọng, [Geiser](https://gitlab.com/emacs-geiser) và các công cụ tương tự không giúp ích gì trong việc nhận diện phạm vi hợp lệ của định danh. Các trường hợp tương tự xảy ra với chức năng đi đến định nghĩa và nhiều chức năng khác.

Nguyên nhân chính là, đối với scheme và các biến thể lisp khác, tập dữ liệu phong phú và cấu trúc điều khiển linh hoạt khiến việc phân tích chương trình trở nên rất thách thức. Đặc biệt là macro, dường như scheme chủ yếu được sử dụng cho lập trình thiên tài và meta/macro. Nhưng tôi không nghĩ vậy. Scheme có thể làm được nhiều điều thú vị nếu có một môi trường lập trình tốt hơn. Và bây giờ bạn có thể [**BẮT ĐẦU Ở ĐÂY**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Gói này là một triển khai language server protocol giúp lập trình scheme. Nó cung cấp tính năng hoàn thành, xác định và suy luận kiểu. Các chức năng này được xây dựng dựa trên phân tích mã tĩnh với [tiêu chuẩn r6rs](http://www.r6rs.org/) và một số quy tắc rõ ràng cho mã chưa hoàn thiện. Gói này và các thư viện liên quan được phát hành hoặc sẽ được phát hành với [Akku](https://akkuscm.org/), là trình quản lý gói cho Scheme.

Gói này cũng đã được kiểm thử với [Chez Scheme](https://cisco.github.io/ChezScheme/) phiên bản 9.4 và 9.5. Kiểm thử chi tiết trên phiên bản 10.0.0 sẽ được thực hiện sau khi tôi nâng cấp hệ điều hành laptop lên phiên bản mới hơn.

Tôi làm công việc mã nguồn mở này chỉ trong thời gian rảnh và tôi có thể đóng góp nhiều ý tưởng tuyệt vời cho cộng đồng như tích hợp phân tích luồng dữ liệu vào scheme-langserver hoặc nhiều thứ khác. Và tôi liên tục kêu gọi nhiều hơn sự quyên góp hoặc tài trợ. Bạn có thể quyên góp qua [trang patreon này](https://www.patreon.com/PoorProgrammer/membership) hoặc [爱发电](https://afdian.com/a/ufo5260987423).


## Biên dịch, Cài đặt & Cấu hình ở [ĐÂY](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Trạng Thái Gần Đây
Tôi sẽ tiếp tục sửa lỗi, tối ưu mã, và thu thập thông tin cho cuốn sách lớn về hệ thống suy luận kiểu tự chế của mình. Việc này sẽ mất khoảng 1 năm. Các phát triển tiếp theo bao gồm một plugin [VScode](https://code.visualstudio.com/) và phân tích luồng dữ liệu. Nhưng thực tế, hiện tôi đang xem công việc mã nguồn mở này như một công việc bán thời gian, và tôi không thể đảm bảo lịch trình.

## Phát Hành
1.2.9 Hiện tại, hãy tận hưởng tính năng suy luận kiểu!

Các bản phát hành trước vui lòng tham khảo [tệp này](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Tính Năng
1. Hoàn thành liên kết định danh ở cấp cao nhất và cục bộ.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Đi đến định nghĩa.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Tương thích với trình quản lý gói: Akku.
4. Đồng bộ hóa thay đổi tệp và thay đổi chỉ mục tương ứng.
5. Hover.
6. Tham chiếu và làm nổi bật tài liệu (tham chiếu trong phạm vi tài liệu).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Ký hiệu tài liệu.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Bắt các liên kết định danh cục bộ dựa trên *-syntax (define-syntax, let-syntax, v.v.).
9. Lập chỉ mục song song đa nền tảng.
10. Chú thích mã nguồn tự chế để tương thích với tệp .sps.
11. Tối ưu hóa peephole cho các yêu cầu API với tác vụ có thể tạm dừng.
12. Suy luận kiểu với trình thông dịch DSL tự chế (tôi rất tự hào về nó!). Và hiện đã được tích hợp vào tính năng tự động hoàn thành. Như hình dưới đây, "length-b" và "length-a" có kiểu "integer?" được ưu tiên trong các lựa chọn đề xuất vì chúng có thể khớp với kiểu tham số yêu cầu từ "<=".
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Một kiểm thử có thể chứng minh kết quả này, chỉ cần chạy `scheme --script tests/protocol/apis/test-completion.sps` và tệp nhật ký `scheme-langserver.log` sẽ chứa các kết quả như sau:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Trình thông dịch trừu tượng để bắt định danh giữa các phần mở rộng tệp khác nhau như scm, ss, sps, sls và sld.

### CẦN LÀM
14. Đổi tên. 
15. Hoàn toàn tương thích với [tiêu chuẩn r6rs](http://www.r6rs.org/).
16. Trình mở rộng macro từng bước: thực ra tôi đã triển khai một cái và tôi muốn biến nó thành một bước chủ chốt để bắt liên kết định danh trong macro tự định nghĩa. Bây giờ, tôi nhận ra việc này khó hơn tôi nghĩ, và tôi cũng không biết trình mở rộng này có thể làm việc ở đâu.
17. Đánh giá mã.
18. Chẩn đoán mã.
19. Thêm hỗ trợ ngữ nghĩa liên ngôn ngữ. Liệu java, c, python và nhiều ngôn ngữ khác có thể được hỗ trợ với bộ chuyển đổi AST không?
20. Trích xuất biểu thức/câu lệnh thành một thủ tục.

## CẦN LÀM: Đóng Góp 

## Gỡ Lỗi

### Cách Gỡ Lỗi
https://www.scheme.com/debug/debug.html#g1

### Xuất Nhật Ký
Làm theo các hướng dẫn từ [Xây dựng](#building), [Cài đặt cho Lunar Vim](#installation-for-lunarvim) và [Cài đặt cho VScode](#todo-installation-for-vscode), nếu ai đó muốn phát triển và ghi nhật ký, sẽ thuận tiện hơn khi thêm `path-to-log-file` và chỉnh lại tệp `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` như sau:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, một triển khai language server protocol cho scheme
]]   ,
  },
}
```
### Lặp lại với Log
Với [output log](#output-log) ở trên, bạn có thể sử dụng `tests/log-debug.sps` để tái hiện lỗi:
1. Đổi tên `{path-to-log}` (thường là `~/scheme-langserver.log`) thành `~/ready-for-analyse.log`;
2. Chạy `scheme --script tests/log-debug.sps`. Nếu bạn muốn tái tạo môi trường đa luồng, cũng có thể chạy `scheme --script tests/log-debug.sps`.

## Kiểm thử
Hầu như tất cả các thủ tục và API chính đều đã được kiểm thử. Công việc của tôi chỉ là sơ khai nhưng hữu ích, có thể bạn sẽ muốn xem những gì tôi đã làm trong thư mục `tests` hoặc chỉ cần chạy lệnh sau trong `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>LƯU Ý
Rất khó để kiểm thử với môi trường đa luồng. Vì vậy, các kiểm thử hiện tại tập trung vào đơn luồng.

## Sử dụng Scheme-langserver cho Mục đích Khác
### Script-Fu trong GIMP
Script-Fu dựa trên một ngôn ngữ thông dịch gọi là Scheme, và hoạt động bằng cách sử dụng các hàm tương tác với các hàm nội bộ của GIMP. Lấy ví dụ từ [trang này](https://dalelane.co.uk/blog/?p=628), bạn có thể áp dụng scheme-langserver với file script có phần mở rộng "SCM".

### Khác

Tôi cũng quan tâm đến [OMN (Opusmodus Notation)](https://opusmodus.com/) và AutoLisp. Nhưng tôi vẫn còn nhiều việc phải làm.

## Thống kê Số dòng Code
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Tài liệu Chi tiết
1. [Scheme-langserver: Xem Việc Soạn thảo Mã Scheme là Mối quan Tâm Hàng Đầu](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Bắt các ràng buộc định danh](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Đồng bộ hóa](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Suy luận kiểu](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Đã ngừng sử dụng, và tôi đang viết một cuốn sách tiếng Trung về nó)
5. [Phân tích API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Lịch sử Star

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Những người đóng góp

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---