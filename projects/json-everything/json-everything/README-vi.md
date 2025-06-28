[![Build & Test](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml/badge.svg?branch=master&event=push)](https://github.com/json-everything/json-everything/actions/workflows/dotnet-core.yml)
[![Test results](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/gregsdennis/28607f2d276032f4d9a7f2c807e44df7/raw/test-results-badge.json)](https://github.com/json-everything/json-everything/actions?query=workflow%3A%22Build+%26+Test%22)
[![Percentage of issues still open](http://isitmaintained.com/badge/open/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Percentage of issues still open")
[![Average time to resolve an issue](http://isitmaintained.com/badge/resolution/json-everything/json-everything.svg)](https://github.com/json-everything/json-everything/issues "Average time to resolve an issue")
[![License](https://img.shields.io/github/license/json-everything/json-everything)](https://github.com/json-everything/json-everything/blob/master/LICENSE)

## `json-everything` là gì?

Triết lý chính đằng sau `json-everything` là đảm bảo rằng các chức năng phổ biến của JSON có sự hỗ trợ tốt trong không gian _System.Text.Json_.

Bước đầu tiên là kiểm tra xem có tồn tại dự án khác hỗ trợ chức năng đã cho hay không.

Nếu có, nỗ lực đó có thể sẽ không được lặp lại ở đây. Ở phía dưới một chút bạn sẽ thấy danh sách các dự án khác đang làm những điều tuyệt vời với JSON.

Ngược lại, nó sẽ được xem xét để đưa vào dự án này.

<table>
<thead>
<tr>
<th width="207">Playground</th>
<th width="207">Tài liệu</th>
<th width="207">Blog</th>
<th width="207">Học tương tác</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://json-everything.net"><img src="Resources/json-animated.webp" alt="Thử trực tuyến" title="Thử trực tuyến" height="50"><br>json-everything.net</a></td>
<td align="center"><a href="https://docs.json-everything.net"><img src="Resources/docs-icon.png" alt="Tài liệu" title="Tài liệu" height="50"><br>docs.json-everything.net</a></td>
<td align="center"><a href="https://blog.json-everything.net"><img src="Resources/blog-icon.png" alt="Blog" title="Blog" height="50"><br>blog.json-everything.net</a></td>
<td align="center"><a href="https://learn.json-everything.net"><img src="Resources/learn-icon.png" alt="Học" title="Học" height="50"><br>learn.json-everything.net</a></td>
</tr>
</tbody>
</table>

<table>
<thead>
<tr>
<th width="276">Thảo luận</th>
<th width="276">Hỏi đáp</th>
<th width="276">Xây dựng với</th>
</tr>
</thead>
<tbody>
<tr>
<td align="center"><a href="https://join.slack.com/t/json-everything/shared_invite/zt-4klcm69x-_MA8Z2ZSZ4JNu_d3lQOVPg"><img src="Resources/Slack.png" alt="Slack" title="Slack" height="50"></a></td>
<td align="center"><a href="https://stackoverflow.com/questions/tagged/json-everything"><img src="Resources/stackoverflow.png" alt="StackOverflow" title="StackOverflow" height="50"></a></td>
<td align="center"><a href="http://www.jetbrains.com/resharper"><img src="Resources/Resharper.svg" alt="Made with Jetbrains Resharper" title="Made with Jetbrains Resharper" height="50"></a></td>
</tr>
</tbody>
</table>

## Có gì trong "hộp"?

Thực tế là có nhiều "hộp". Mỗi chức năng đã được tách thành thư viện riêng, vì vậy bạn có thể chọn và sử dụng cái (những cái) mà bạn cần.

Tất cả các thư viện đều được xây dựng trên .Net Standard 2.0 và .Net 8.

<table>
<tbody>
<tr>
<td>JsonSchema.Net<br><a href="https://www.nuget.org/packages/JsonSchema.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.svg?svg=true"></img></a></td>
<td><a href="https://json-schema.org">JSON Schema</a>, từ draft 6 trở lên</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.svg?svg=true"></img></a></td>
<td>Tạo schema từ các kiểu .Net</td>
</tr>
<tr>
<td>JsonSchema.Net.Generation.DataAnnotations<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Generation.DataAnnotations/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Generation.DataAnnotations.svg?svg=true"></img></a></td>
<td>Hỗ trợ tạo schema cho <em>System.ComponentModel.DataAnnotations</em>.</td>
</tr>
<tr>
<td>JsonSchema.Net.DataGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.DataGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.DataGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.DataGeneration.svg?svg=true"></img></a></td>
<td>Tạo dữ liệu instance ngẫu nhiên (dựa trên <a href="https://github.com/bchavez/Bogus">Bogus</a>)</td>
</tr>
<tr>
<td>JsonSchema.Net.Data<br><a href="https://www.nuget.org/packages/JsonSchema.Net.Data/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.Data.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.Data.svg?svg=true"></img></a></td>
<td>Từ vựng để truy cập dữ liệu instance và dữ liệu ngoài</td>
</tr>
<tr>
<td>JsonSchema.Net.ArrayExt<br><a href="https://www.nuget.org/packages/JsonSchema.Net.ArrayExt/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.ArrayExt.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.ArrayExt.svg?svg=true"></img></a></td>
<td>Từ vựng để mở rộng xác thực mảng</td>
</tr>
<tr>
<td>JsonSchema.Net.OpenApi<br><a href="https://www.nuget.org/packages/JsonSchema.Net.OpenApi/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.OpenApi.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.OpenApi.svg?svg=true"></img></a></td>
<td>Mở rộng từ vựng <a href="https://www.openapis.org/">OpenApi 3.1</a> (được sử dụng bởi <a href="https://github.com/gregsdennis/Graeae">Graeae</a>)</td>
</tr>
<tr>
<td>JsonPath.Net<br><a href="https://www.nuget.org/packages/JsonPath.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPath.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPath.Net.svg?svg=true"></img></a></td>
<td>JSON Path (<a href="https://tools.ietf.org/html/rfc9535">RFC 9535</a>)</td>
</tr>
<tr>
<td>JsonPatch.Net<br><a href="https://www.nuget.org/packages/JsonPatch.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPatch.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPatch.Net.svg?svg=true"></img></a></td>
<td>JSON Patch (<a href="https://tools.ietf.org/html/rfc6902">RFC 6902</a>)</td>
</tr>
<tr>
<td>JsonPointer.Net<br><a href="https://www.nuget.org/packages/JsonPointer.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonPointer.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonPointer.Net.svg?svg=true"></img></a></td>
<td>JSON Pointer (<a href="https://tools.ietf.org/html/rfc6901">RFC 6901</a>) và Relative JSON Pointer (<a href="https://tools.ietf.org/id/draft-handrews-relative-json-pointer-00.html">Đặc tả</a>)</td>
</tr>
<tr>
<td>JsonLogic<br><a href="https://www.nuget.org/packages/JsonLogic/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonLogic.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonLogic.svg?svg=true"></img></a></td>
<td>JsonLogic (<a href="https://jsonlogic.com">Trang chủ</a>)</td>
</tr>
<tr>
<td>JsonE.Net<br><a href="https://www.nuget.org/packages/JsonE.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonE.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonE.Net.svg?svg=true"></img></a></td>
<td>JSON-e (<a href="https://json-e.js.org/">Trang chủ</a>)</td>
</tr>
<tr>
<td>Json.More.Net<br><a href="https://www.nuget.org/packages/Json.More.Net/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Json.More.Net.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Json.More.Net.svg?svg=true"></img></a></td>
<td>Các phần mở rộng sử dụng chung lẽ ra nên có trong <em>System.Text.Json[.Nodes]</em> nhưng lại không có</td>
</tr>
<tr>
<td>Yaml2JsonNode<br><a href="https://www.nuget.org/packages/Yaml2JsonNode/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/Yaml2JsonNode.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/Yaml2JsonNode.svg?svg=true"></img></a></td>
<td>Chuyển đổi giữa mô hình tài liệu YAML trong <a href="https://github.com/aaubry/YamlDotNet">YamlDotNet</a> và <code>JsonNode</code> (cả hai chiều).</td>
</tr>
</tbody>
</table>

Tất cả các thư viện trên đều hỗ trợ đầy đủ các đặc tả liên quan của mình.

Bản dịch thông báo lỗi cho _JsonSchema.Net_ có sẵn bằng các ngôn ngữ:

- Tiếng Ý `it`
- Tiếng Na Uy `nb-NO`
- Tiếng Ba Lan `pl-PL`
- Tiếng Nga `ru`
- Tiếng Tây Ban Nha `es`
- Tiếng Thụy Điển `sv-SE`
- Tiếng Thổ Nhĩ Kỳ `tr-TR`

***LƯU Ý** Mỗi gói ngôn ngữ được cung cấp dưới dạng một gói Nuget riêng.*

Bạn cũng có thể xem kết quả bộ kiểm thử JSON Schema trên [Bowtie](https://bowtie-json-schema.github.io/bowtie), nơi chạy bộ kiểm thử trên nhiều triển khai ở các nền tảng khác nhau.

***LƯU Ý** Thư viện của tôi, _JsonSchema.Net_, không liên quan hoặc liên kết với trang web https://jsonschema.net, ngoại trừ việc cả hai đều là công cụ JSON Schema xuất sắc.*

### Các gói đã ngừng phát triển

Các gói này cũng từng là một phần của bộ thư viện này nhưng hiện không còn được hỗ trợ.

<table>
<tbody>
<tr>
<td>JsonSchema.Net.CodeGeneration<br><a href="https://www.nuget.org/packages/JsonSchema.Net.CodeGeneration/"><img alt="NuGet version" src="https://img.shields.io/nuget/vpre/JsonSchema.Net.CodeGeneration.svg?svg=true"></img><img alt="NuGet version" src="https://img.shields.io/nuget/dt/JsonSchema.Net.CodeGeneration.svg?svg=true"></img></a></td>
<td>Phát sinh mã C# từ schema</td>
<td>Đã ngừng phát triển, thay thế bởi <a href="https://github.com/corvus-dotnet/Corvus.JsonSchema">Corvus.JsonSchema</a></td>
</tr>
</tbody>
</table>


## Hỗ trợ _System.Text.Json_ bởi các dự án khác

Nếu bạn không tìm thấy điều mình cần ở đây, hãy thử một trong những dự án xuất sắc sau:

- [JsonCons.Net](https://github.com/danielaparker/JsonCons.Net) của [@danielaparker](https://github.com/danielaparker)
  - JSON Pointer
  - JSON Patch
  - JSON Merge Patch
  - JSON Path
  - JMES Path
- [Corvus.JsonSchema](https://github.com/corvus-dotnet/Corvus.JsonSchema) của [@mwadams](https://github.com/mwadams)
  - Xác thực JSON Schema, tập trung vào sinh mã C#
- (sẽ còn cập nhật)

Nếu bạn dùng JSON cho việc gì đó mà chưa được hỗ trợ bởi bất kỳ thư viện nào trong bộ này hoặc các dự án trên, hãy thoải mái [tạo một yêu cầu tính năng](https://github.com/json-everything/json-everything/issues/new?assignees=&labels=feature&projects=&template=New_function.yml).

Nếu bạn duy trì hoặc biết dự án khác mở rộng _System.Text.Json_ để làm những điều hay ho, tôi muốn liệt kê nó ở đây, nên hãy [tạo một vấn đề chung](https://github.com/json-everything/json-everything/issues/new) để thông báo cho tôi.

## Đóng góp

Vui lòng xem [Quy tắc ứng xử](https://raw.githubusercontent.com/json-everything/json-everything/master/CODE_OF_CONDUCT.md) và tệp [CONTRIBUTING](https://raw.githubusercontent.com/json-everything/json-everything/master/CONTRIBUTING.md) để biết thêm thông tin.

## Tài trợ

Nếu bạn thấy các thư viện này hữu ích và muốn hỗ trợ phát triển tiếp tục, hãy cân nhắc [tài trợ cho các tác giả](https://github.com/sponsors/gregsdennis).

## .NET Foundation

Dự án này được hỗ trợ bởi [.NET Foundation](https://dotnetfoundation.org).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---