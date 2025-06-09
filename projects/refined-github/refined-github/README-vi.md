# <img src="https://raw.githubusercontent.com/refined-github/refined-github/main/source/icon.png" width="45" align="left"> Refined GitHub

> Tiện ích mở rộng trình duyệt giúp đơn giản hóa giao diện GitHub và bổ sung các tính năng hữu ích

Chúng tôi sử dụng GitHub rất nhiều và nhận thấy nhiều điều phiền toái mà chúng tôi muốn khắc phục. Vậy nên ở đây có nhiều “rồng” (vấn đề cần giải quyết).

Chúng tôi hy vọng GitHub sẽ chú ý và triển khai một số cải tiến rất cần thiết này. Vì vậy, nếu bạn thích bất kỳ cải tiến nào, hãy mở một thảo luận trên [GitHub feedback](https://github.com/github-community/community/discussions) hoặc liên hệ với [GitHub support](https://support.github.com/request) để đề xuất thực hiện.

GitHub Enterprise cũng được hỗ trợ: [Cách bật tính năng này](https://fregante.github.io/webext-permission-toggle/?name=Refined%20GitHub&icon=https%3A%2F%2Fraw.githubusercontent.com%2Frefined-github%2Frefined-github%2Fmain%2Fsource%2Ficon.png). <!-- icon.png renders best -->

*Các nhãn hiệu GITHUB và REFINED GITHUB thuộc sở hữu của GitHub, Inc. và được sử dụng theo giấy phép.*

## Cài đặt

[link-chrome]: https://chrome.google.com/webstore/detail/refined-github/hlepfoohegkhhmjieoechaddaejaokhf 'Phiên bản phát hành trên Chrome Web Store'
[link-firefox]: https://addons.mozilla.org/firefox/addon/refined-github-/ 'Phiên bản phát hành trên Mozilla Add-ons'
[link-safari]: https://apps.apple.com/app/id1519867270 'Phiên bản phát hành trên Mac App Store'

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/chrome/chrome.svg" width="48" alt="Chrome" valign="middle">][link-chrome] [<img valign="middle" src="https://img.shields.io/chrome-web-store/v/hlepfoohegkhhmjieoechaddaejaokhf.svg?label=%20">][link-chrome] và các trình duyệt Chromium khác

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/firefox/firefox.svg" width="48" alt="Firefox" valign="middle">][link-firefox] [<img valign="middle" src="https://img.shields.io/amo/v/refined-github-.svg?label=%20">][link-firefox] bao gồm Firefox Android

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/safari/safari_128x128.png" width="48" alt="Safari" valign="middle">][link-safari] [<img valign="middle" src="https://img.shields.io/itunes/v/1519867270.svg?label=%20">][link-safari] trên Mac, iOS và iPadOS

[<img src="https://raw.githubusercontent.com/iamcal/emoji-data/08ec822c38e0b7a6fea0b92a9c42e02b6ba24a84/img-apple-160/1f99a.png" width="48" valign="middle">](https://github.com/sponsors/fregante) _Nếu bạn yêu thích Refined GitHub, hãy cân nhắc [tài trợ hoặc tuyển dụng](https://github.com/sponsors/fregante) người duy trì [@fregante](https://twitter.com/fregante)_


<div align="center">

<table><tr><td width="550"><div align="center">
	<p><sup>Công việc mã nguồn mở của <a href="https://github.com/sponsors/fregante">@fregante</a> được cộng đồng hỗ trợ.<br>Đặc biệt cảm ơn:</sup></p>
	<p><a href="https://www.prisma.io/">
		<picture>
			<source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/f781e9a3-2c03-4334-b234-8f20600ca45f">
			<img width="250" alt="Prisma.io" src=https://user-images.githubusercontent.com/1402241/205429539-4549ea71-f26c-432a-aaef-db430c435718.svg">
		</picture>
		<br><sup>ORM Node.js và TypeScript thế hệ tiếp theo với mô hình dữ liệu trực quan, di chuyển tự động, an toàn kiểu dữ liệu & tự động hoàn thành.</sup>
	</a></p>
	<p><a href="https://frappe.io/">
		<picture>
			<source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/534638ee-7849-4e42-a847-b50be5d1e2f0">
			<img width="190" alt="Frappe" src="https://github.com/user-attachments/assets/1f853047-b30c-41de-acf9-4daefb6a6fc3">
		</picture>
		<br><sup>Framework web low-code đầy đủ tính năng và nhiều phần mềm miễn phí, mã nguồn mở đẳng cấp thế giới khác.</sup>
	</a></p>
</table>

</div>

---

## Điểm nổi bật 🔥

<table>
	<tr>
		<th width="50%">
			<p><a title="show-whitespace"></a> Làm hiển thị các ký tự khoảng trắng
			<p><img src="https://user-images.githubusercontent.com/1402241/61187598-f9118380-a6a5-11e9-985a-990a7f798805.png">
		<th width="50%">
			<p><a title="resolve-conflicts"></a> Thêm bộ sửa xung đột merge chỉ với một cú nhấp
			<p><img src="https://user-images.githubusercontent.com/1402241/54978791-45906080-4fdc-11e9-8fe1-45374f8ff636.png">
	<tr>
		<th width="50%">
			<p><a title="pr-base-commit"></a> Hiển thị chi nhánh đầu PR tụt lại bao xa + chỉ ra commit gốc
			<p><img src="https://user-images.githubusercontent.com/1402241/234492651-b54bf9ba-c218-4a30-bed4-f85a7f037297.png">
		<th width="50%">
			<p><a title="conversation-activity-filter"></a> Cho phép ẩn tất cả sự kiện ngoại trừ bình luận hoặc bình luận chưa giải quyết trong issues và PRs
			<p><img src="https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252116522-053bce84-5c55-477b-8cc2-42a48104fb02.png">
	<tr>
		<th width="50%">
			<p><a title="status-subscription"></a> Cho phép đăng ký sự kiện mở/đóng issue chỉ với một cú nhấp
			<p><img src="https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/238186901-cbc98b51-d173-40c6-b21e-5f0bae3d800c.png">
		<th width="50%">
			<p><a title="default-branch-button"></a> Thêm liên kết đến nhánh mặc định trong danh sách thư mục và tập tin
			<p><img src="https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252176294-9130783c-51aa-4df9-9c35-9b87c179199a.png">
	<tr>
		<th width="50%">
			<p><a title="restore-file"></a> Thêm nút loại bỏ tất cả thay đổi đối với tập tin trong PR
			<p><img src="https://user-images.githubusercontent.com/1402241/236630610-e11a64f6-5e70-4353-89b8-39aae830dd16.gif">
		<th width="50%">
			<p><a title="select-notifications"></a> Chọn thông báo theo loại và trạng thái
			<p><img src="https://user-images.githubusercontent.com/83146190/252175851-e0826d3b-1990-4bff-ba09-71892463818e.gif">
</table>

### Kho lưu trữ

<!--
Tham khảo hướng dẫn định dạng trong wiki. Giữ nguyên thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

- [](# "ci-link") 🔥 [Thêm biểu tượng trạng thái build/CI bên cạnh tên kho.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/237923995-5e14a272-0bf2-4fe4-b409-8c05378aa4fd.png)
- [](# "more-dropdown-links") [Thêm các liên kết hữu ích vào menu thả xuống điều hướng kho lưu trữ](https://user-images.githubusercontent.com/16872793/124681432-856e6f80-de96-11eb-89c9-6d78e8ae4329.png)
- [](# "swap-branches-on-compare") [Thêm liên kết để hoán đổi nhánh trong chế độ so sánh nhánh.](https://user-images.githubusercontent.com/44045911/230370539-ebc94246-864f-48f2-85fa-7318fc1f6d71.png)
- [](# "repo-age") [Hiển thị tuổi của kho lưu trữ ở thanh bên.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252176778-f8260312-d0dc-41b5-a4d1-ca680208d347.png)
- [](# "show-open-prs-of-forks") [Trong các kho fork, hiển thị số lượng PR mở của bạn đến kho gốc.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252177140-94165582-628b-45b6-9a62-faf0c7fc2335.png)
- [](# "clean-repo-filelist-actions") [Làm gọn một số nút trên danh sách kho để tạo không gian cho các tính năng khác.](https://user-images.githubusercontent.com/1402241/108955170-52d48080-7633-11eb-8979-67e0d3a53f16.png)
- [](# "new-repo-disable-projects-and-wikis") [Tự động tắt projects và wikis khi tạo kho lưu trữ mới.](https://user-images.githubusercontent.com/1402241/177040449-73fde2a5-98e2-4583-8f32-905d1c4bfd20.png)
- [](# "sticky-sidebar") [Giữ thanh bên cố định trong kho, issues, và PRs nếu vừa với cửa sổ xem.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252179311-ea6d42dc-1525-401a-bc4d-404cf8fa1785.gif)
- [](# "link-to-github-io") [Thêm liên kết để truy cập trang github.io của người dùng từ kho lưu trữ.](https://user-images.githubusercontent.com/34235681/152473104-c4723999-9239-48fd-baee-273b01c4eb87.png)
- [](# "github-actions-indicators") [Trong thanh bên workflows, hiển thị chỉ báo workflow có thể kích hoạt thủ công, và thời gian lên lịch tiếp theo nếu có.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252181237-a1d809b1-e5d4-4747-9654-7dde5ab5c61a.png)
- [](# "quick-repo-deletion") [Đơn giản hóa việc xóa kho lưu trữ. Thêm nút "Delete fork" trên kho 0 sao. Cho phép <kbd>shift</kbd> <kbd>alt</kbd> click để xóa kho chỉ với 2 thao tác.](https://github.com/user-attachments/assets/9e05ec18-680d-4fbd-acbd-2b5b3505c5b5)
- [](# "archive-forks-link") [Giúp bạn tìm fork trên các kho đã lưu trữ.](https://user-images.githubusercontent.com/1402241/230362566-12493c80-bffe-4c7a-b9ba-4a11b1358ab0.png)
- [](# "clean-repo-tabs") [Chuyển tab "Security" và "Insights" sang menu thả xuống điều hướng kho. Đồng thời chuyển các tab "Projects", "Actions" và "Wiki" nếu chúng trống/chưa dùng.](https://user-images.githubusercontent.com/16872793/124681343-4a6c3c00-de96-11eb-9055-a8fc551e6eb8.png)
- [](# "repo-avatars") [Thêm hình đại diện vào tiêu đề kho công khai.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/255323568-aee4d90e-844e-41e8-880a-ce466826516c.png)
- [](# "quick-new-issue") [Thêm liên kết để tạo issue từ bất cứ đâu trong kho lưu trữ.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/274816033-820ec518-049d-4248-9f8a-27b9423e350b.png)
- [](# "small-user-avatars") [Hiển thị hình đại diện nhỏ cạnh tên người dùng trong danh sách issue/PR và nhắc đến.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/271184107-24ec471e-54d1-434a-a5f2-615902d2cad9.png)
- [](# "unreleased-commits") 🔥 [Thông báo bạn đang xem phiên bản mới nhất của kho lưu trữ hay còn commit chưa phát hành.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/267236196-8564c193-a3c7-4248-9735-54749c1990c7.png)
- [](# "action-pr-link") 🔥 [Thêm liên kết trở lại PR đã chạy workflow.](https://github-production-user-asset-6210df.s3.amazonaws.com/50487467/241645264-076a0137-36a2-4fd0-a66e-735ef3b3a563.png)
- [](# "mobile-tabs") [Làm các tab gọn hơn trên di động để xem được nhiều tab hơn.](https://user-images.githubusercontent.com/1402241/245446231-28f44b59-0151-4986-8cb9-05b5645592d8.png)
- [](# "repo-header-info") [Hiển thị kho có phải là fork và thêm số lượng sao vào tiêu đề.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/267216946-404d79ab-46d7-4bc8-ba88-ae8f8029150d.png)
- [](# "visit-tag") [Khi xem file theo tag cụ thể, thêm liên kết để xem release/tag đó.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/285123739-e5f4fa0a-3f48-49ef-9b87-2fd6f183c923.png)

<!--
Tham khảo hướng dẫn định dạng trong wiki. Giữ nguyên thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Quản lý tập tin

- [](# "download-folder-button") [Thêm nút tải về toàn bộ thư mục](https://user-images.githubusercontent.com/46634000/158347358-49234bb8-b9e6-41be-92ed-c0c0233cbad2.png), qua https://download-directory.github.io.
- [](# "quick-file-edit") [Thêm nút chỉnh sửa tập tin ngay từ danh sách tập tin của kho.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252182890-081975f4-f041-4ba5-ae48-d52cb0796543.png)
- [](# "repo-wide-file-finder") Bật phím tắt File Finder (<kbd>t</kbd>) cho toàn bộ kho lưu trữ.
- [](# "show-associated-branch-prs-on-fork") [Hiển thị các PR liên quan trên nhánh cho kho fork.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/260873542-2a7fc7a2-231f-4f2e-9c7e-272d894de4c6.png)
- [](# "html-preview-link") [Thêm liên kết xem trước tập tin HTML.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/260874191-69d386a0-7c1f-42ae-84fd-4f67f90982da.png)
- [](# "file-age-color") [Làm nổi bật các mục được chỉnh sửa gần đây nhất trong danh sách tập tin.](https://user-images.githubusercontent.com/1402241/218314631-1442cc89-3616-40fc-abe2-9ba3d3697b6a.png)
- [](# "previous-version") [Xem phiên bản trước của tập tin chỉ với một cú nhấp.](https://github.com/refined-github/refined-github/assets/1402241/bc82cc77-bde2-4683-98a6-012c87b4a319)

<!--
Tham khảo hướng dẫn định dạng trong wiki. Giữ nguyên thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Mã nguồn

- [](# "linkify-code") [Tự động tạo liên kết cho tham chiếu issue/PR và URL trong mã nguồn và tiêu đề issue/PR.](https://cloud.githubusercontent.com/assets/170270/25370217/61718820-29b3-11e7-89c5-2959eaf8cac8.png)
- [](# "copy-on-y") Nâng cấp [phím tắt <kbd>y</kbd>](https://help.github.com/articles/getting-permanent-links-to-files/) để tự động sao chép permalink.
- [](# "linkify-symbolic-links") [Tự động liên kết các tập tin symbolic links.](https://user-images.githubusercontent.com/1402241/62036664-6d0e6880-b21c-11e9-9270-4ae30cc10de2.png)
- [](# "list-prs-for-file") [Cảnh báo nếu tập tin hiện tại bị thay đổi bởi một PR đang mở.](https://user-images.githubusercontent.com/1402241/234559302-b9911ac2-a1bb-4f8a-8e88-078d631cde18.png)
- [](# "refined-github.css") [Giảm kích thước tab còn 4 khoảng trắng thay vì 8](https://cloud.githubusercontent.com/assets/170270/14170088/d3be931e-f755-11e5-8edf-c5f864336382.png) ở nơi GitHub không theo [tùy chọn của người dùng.](https://github.com/settings/appearance)
- [](# "esc-to-deselect-line") [Thêm phím tắt để bỏ chọn dòng hiện tại: <kbd>esc</kbd>.](https://github.com/refined-github/refined-github/issues/1590)
- [](# "vertical-front-matter") [Hiển thị front matter Markdown dưới dạng bảng dọc.](https://user-images.githubusercontent.com/44045911/87251695-26069b00-c4a0-11ea-9077-53ce366490ed.png)
- [](# "list-prs-for-branch") [Trong danh sách commit nhánh, hiển thị PR tác động đến nhánh hiện tại.](https://user-images.githubusercontent.com/16872793/119760295-b8751a80-be77-11eb-87da-91d0c403bb49.png)

<!--
Tham khảo hướng dẫn định dạng trong wiki. Giữ nguyên thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Viết bình luận

- [](# "tab-to-indent") 🔥 [Cho phép <kbd>tab</kbd> và <kbd>shift</kbd> <kbd>tab</kbd> để thụt lề trong trường bình luận.](https://user-images.githubusercontent.com/1402241/33802977-beb8497c-ddbf-11e7-899c-698d89298de4.gif)
- [](# "collapsible-content-button") [Thêm nút trong trình soạn thảo văn bản để chèn nội dung có thể thu gọn (qua `<details>`).](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/260875648-bd495d27-4cd1-4190-bcc5-b8b476f07d39.png)
- [](# "fit-textareas") 🔥 [Tự động thay đổi kích thước trường bình luận phù hợp với nội dung, không còn thanh cuộn.](https://user-images.githubusercontent.com/1402241/54336211-66fd5e00-4666-11e9-9c5e-111fccab004d.gif)
- [](# "quick-comment-edit") [Cho phép chỉnh sửa bất kỳ bình luận nào chỉ với một cú nhấp, không cần mở menu thả xuống.](https://user-images.githubusercontent.com/46634000/162252055-54750c89-0ddc-487a-b4ad-cec6009d9870.png)
- [](# "one-key-formatting") [Bọc văn bản được chọn khi nhấn một trong các ký hiệu Markdown thay vì thay thế:](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261155564-e7aabd0e-b14b-4fe6-b379-62e7419c43f8.gif) `[` `` ` `` `'` `"` `*` `~` `_`
- [](# "clean-rich-text-editor") [Ẩn các tooltip và mục thanh công cụ không cần thiết trong trường bình luận](https://user-images.githubusercontent.com/46634000/158201651-7364aba7-f9d0-4a51-89c4-2ced0cc34e48.png) (mỗi mục đều có phím tắt riêng.)
- [](# "quick-mention") [Thêm nút `@mention` người dùng trong issues và PRs.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261158402-5a79cc3e-4331-475f-8063-5ed81fefcf10.gif)
- [](# "table-input") [Thêm nút trong trình soạn thảo văn bản để nhanh chóng chèn bảng HTML đơn giản.](https://user-images.githubusercontent.com/46634000/94559114-09892c00-0261-11eb-8fb0-c5a85ea76b6f.gif)
- [](# "unfinished-comments") [Thông báo cho người dùng về các bình luận chưa hoàn thành trong tab ẩn.](https://user-images.githubusercontent.com/1402241/97792086-423d5d80-1b9f-11eb-9a3a-daf716d10b0e.gif)
- [](# "quick-review-comment-deletion") [Thêm nút xóa bình luận review chỉ với một cú nhấp khi chỉnh sửa.](https://user-images.githubusercontent.com/46634000/115445792-9fdd6900-a216-11eb-9ba3-6dab4d2f9d32.png)
- [](# "avoid-accidental-submissions") [Vô hiệu hóa phím tắt <kbd>enter</kbd> để gửi ở một số trường tiêu đề commit/PR/issue nhằm tránh gửi nhầm. Sử dụng <kbd>ctrl</kbd> <kbd>enter</kbd> thay thế.](https://user-images.githubusercontent.com/723651/125863341-6cf0bce0-f120-4cec-ac1f-1ce35920e7a7.gif)

<!--
Tham khảo hướng dẫn định dạng trong wiki. Giữ nguyên thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Đọc bình luận

- [](# "reactions-avatars") 🔥 [Thêm hình đại diện phản hồi hiển thị _ai_ đã phản hồi bình luận.](https://user-images.githubusercontent.com/1402241/236628453-8b646178-b838-44a3-9541-0a9b5f54a84a.png)
- [](# "embed-gist-inline") [Nhúng gist ngắn khi được liên kết trong bình luận ở dòng riêng.](https://user-images.githubusercontent.com/1402241/152117903-80d784d5-4f43-4786-bc4c-d4993aec5c79.png)
- [](# "comments-time-machine-links") Thêm liên kết để [duyệt kho lưu trữ](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252749373-9313f1d9-3d92-44a2-a1d1-2b49a29e6a5c.png) và [các tập tin liên kết](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252749616-085103bf-17be-4a7d-b63c-aa5003de6dff.png) tại thời điểm từng bình luận.
- [](# "show-names") [Thêm tên thật của người dùng bên cạnh username.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252756294-94785dc2-423e-498c-939a-359a012036e0.png)
- [](# "shorten-links") [Rút ngắn các URL và repo URL thành dạng tham chiếu dễ đọc như "_user/repo/.file@`d71718d`".](https://user-images.githubusercontent.com/1402241/27252232-8fdf8ed0-538b-11e7-8f19-12d317c9cd32.png)
- [](# "preview-hidden-comments") 🔥 [Xem trước các bình luận bị ẩn ngay trên giao diện.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/262556553-ca04b870-9adb-4a8c-a6d0-6238863948be.png)
- [](# "highest-rated-comment") 🔥 [Làm nổi bật bình luận hữu ích nhất trong issues.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252763905-a0c3b074-b032-4d97-946e-328e8a6fb2da.png)
- [](# "hide-low-quality-comments") [Ẩn các bình luận phản hồi dạng "+1", "👍", …](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258220965-4743b9b9-2aef-41b3-a905-ccf8d7beb74e.png) (trừ của người duy trì) [nhưng vẫn có thể hiển thị lại.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258221444-e43f2486-5ba1-40b5-aa1d-d9d5768e8c0a.png)
- [](# "scrollable-areas") [Giới hạn chiều cao khối mã và trích dẫn dài.](https://github.com/refined-github/refined-github/issues/1123)
- [](# "quick-comment-hiding") [Đơn giản hóa giao diện ẩn bình luận.](https://user-images.githubusercontent.com/1402241/43039221-1ddc91f6-8d29-11e8-9ed4-93459191a510.gif)
- [](# "open-issue-to-latest-comment") [Làm cho biểu tượng "bình luận" trong danh sách issue liên kết đến bình luận mới nhất.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261159396-0610574b-ab1f-42fb-813f-ee7310a1e5b6.png)
- [](# "expand-all-hidden-comments") [Trong các cuộc thảo luận dài nơi GitHub ẩn bình luận dưới "N hidden items. Load more...", alt-click sẽ tải tối đa 200 bình luận cùng lúc thay vì 60.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261160123-9c4f894b-38c0-446f-af50-9beca7ff1f74.png)
- [](# "keyboard-navigation") [Thêm phím tắt cho issues, hội thoại PR và danh sách file PR: <kbd>j</kbd> chuyển đến bình luận/tập tin bên dưới; <kbd>k</kbd> chuyển lên trên.](https://user-images.githubusercontent.com/1402241/86573176-48665900-bf74-11ea-8996-a5c46cb7bdfd.gif)
- [](# "comment-excess") [Thông báo có bình luận bị ẩn ở phần đầu issues dài. Tự động cuộn tới bình luận ẩn khi nhấn Cmd+F hoặc Ctrl+F.](https://github.com/refined-github/refined-github/assets/1402241/4e4660f9-c987-4b0d-82ca-56ef29952c31)

<!--
Tham khảo hướng dẫn định dạng trong wiki. Giữ nguyên thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Hội thoại

- [](# "open-all-conversations") [Cho phép mở tất cả issues/PRs hiển thị cùng lúc.](https://user-images.githubusercontent.com/46634000/110980658-5face000-8366-11eb-88f9-0cc94f75ce57.gif)
- [](# "sticky-conversation-list-toolbar") [Giữ thanh công cụ lọc danh sách issue/PR cố định.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261164103-875b70f7-5adc-4bb2-b158-8d5231d47da2.gif)
- [](# "conversation-authors") [Làm nổi bật issues/PRs do bạn hoặc cộng tác viên kho hiện tại mở.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252804821-a412e05c-fb76-400b-85b5-5acbda538ab2.png)
- [](# "align-issue-labels") [Căn trái nhãn trong danh sách issue/PR, đặt dưới tiêu đề.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261160640-28ae4f12-0e95-4db5-a79c-e89ae523a4d0.png)
- [](# "sort-conversations-by-update-time") 🔥 Thay đổi thứ tự sắp xếp mặc định của issues/PRs thành `Recently updated`.
- [](# "more-conversation-filters") [Thêm bộ lọc `Everything you’re involved in` và `Everything you subscribed to` trong menu tìm kiếm.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253043952-cfb99cea-1c7b-43ad-9144-9d84bda8206f.png)
- [](# "global-conversation-list-filters") [Thêm bộ lọc cho issues/PRs _trong kho của bạn_ và _bạn đã bình luận_ trong tìm kiếm toàn cục.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253048449-2f7cc331-c379-4ec0-a542-441e8b4f8d79.png)
- [](# "clean-conversation-sidebar") 🔥 [Ẩn các mục trống (hoặc chỉ nhãn "trống") trong thanh bên issue/PR.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253054419-48c38c01-b1dc-42ca-9ff6-fd63392b5921.png)
- [](# "clean-conversation-filters") [Ẩn bộ lọc `Projects` và `Milestones` trong danh sách issue/PR nếu chúng trống.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/262557246-4ef1c702-eece-4701-9000-0aad21c54c1b.png)
- [](# "toggle-everything-with-alt") [Thêm phím tắt để chuyển đổi tất cả các mục tương tự (bình luận thu nhỏ, diff bị hoãn, v.v.) cùng lúc: <kbd>alt</kbd> <kbd>click</kbd> vào từng nút hoặc checkbox.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253063446-6f556e7d-2ac5-439d-92f0-0c6d719fc86f.gif)
- [](# "extend-conversation-status-filters") [Cho phép chuyển đổi giữa các bộ lọc is:open/is:closed/is:merged trong tìm kiếm.](https://user-images.githubusercontent.com/1402241/73605061-2125ed00-45cc-11ea-8cbd-41a53ae00cd3.gif)
- [](# "bugs-tab") [Thêm tab "Bugs" vào repo nếu có issue mở với nhãn "bug".](https://user-images.githubusercontent.com/46634000/156766081-f2ea100b-a9f3-472b-bddc-a984a88ddcd3.png)
- [](# "pinned-issues-update-time") [Thay thế thời gian "opened" bằng thời gian "updated" trên các issue được ghim.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/240707405-e416be14-5ab5-4869-b33c-f43aab7afcb6.png)
- [](# "clean-pinned-issues") [Chuyển bố cục các issue được ghim từ cạnh nhau sang dạng danh sách tiêu chuẩn.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258224321-e8ee8c70-6952-4a42-8626-6b5f31d167a3.png)
- [](# "quick-label-removal") [Thêm nút một chạm để xóa nhãn trong issues/PRs.](https://user-images.githubusercontent.com/36174850/89980178-0bc80480-dc7a-11ea-8ded-9e25f5f13d1a.gif)
- [](# "clean-conversation-headers") [Xóa thông tin trùng lặp ở phần đầu của issues và PRs ("User wants to merge X commits from Y into Z")](https://user-images.githubusercontent.com/44045911/112314137-a34b0680-8ce3-11eb-9e0e-8afd6c8235c2.png)
- [](# "dim-bots") [Làm mờ các commit và PR do bot thực hiện để giảm nhiễu.](https://user-images.githubusercontent.com/1402241/220607557-f8ea0863-f05b-48c8-a447-1fec42af0afd.gif)
- [](# "esc-to-cancel") [Thêm phím tắt để hủy chỉnh sửa tiêu đề issue/PR: <kbd>esc</kbd>.](https://user-images.githubusercontent.com/35100156/98303086-d81d2200-1fbd-11eb-8529-70d48d889bcf.gif)
- [](# "no-duplicate-list-update-time") [Ẩn thời gian cập nhật của issue/PR trong danh sách khi trùng với thời gian mở/đóng/hợp nhất.](https://user-images.githubusercontent.com/1402241/111357166-ac3a3900-864e-11eb-884a-d6d6da88f7e2.png)
- [](# "linkify-user-labels") [Liên kết nhãn "Contributor" và "Member" trên bình luận đến các commit của tác giả trên repo.](https://user-images.githubusercontent.com/1402241/177033344-4d4eea63-e075-4096-b2d4-f4b879f1df31.png)
- [](# "jump-to-conversation-close-event") [Thêm liên kết để nhảy đến sự kiện đóng mới nhất của issue/PR.](https://user-images.githubusercontent.com/16872793/177792713-64219754-f8df-4629-a9ec-33259307cfe7.gif)
- [](# "close-as-unplanned") [Cho phép "đóng issue là unplanned" chỉ với một cú nhấp thay vì ba.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/279745773-709cde60-c26a-4a0e-89e1-56444d25ebdf.png)
- [](# "locked-issue") [Hiển thị nhãn trên các issue và PR đã bị khóa.](https://user-images.githubusercontent.com/1402241/283015579-0a04becc-9bff-4aef-8770-272d6804970b.png)

<!--
Tham khảo hướng dẫn về phong cách trong wiki. Giữ thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Xem pull request

- [](# "linkify-commit-sha") [Thêm liên kết tới commit không phải PR khi truy cập commit của PR.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261164635-b3caa3fa-3bb6-41a5-90d3-4aba84517da6.png)
- [](# "pr-filters") [Thêm bộ lọc Checks và Draft PR dạng dropdown trong danh sách PR.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253068868-6afb4656-4ef5-4846-89c5-24dc6ee7f839.png)
- [](# "pr-approvals-count") [Hiển thị số lượng review được mã hóa màu trong danh sách PR.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253125143-d10d95df-4a89-4692-b218-5eba5cd79906.png)
- [](# "highlight-non-default-base-branch") [Hiển thị nhánh gốc trong danh sách PR nếu nó không phải nhánh mặc định.](https://user-images.githubusercontent.com/1402241/88480306-39f4d700-cf4d-11ea-9e40-2b36d92d41aa.png)
- [](# "hide-inactive-deployments") [Ẩn các deployment không hoạt động trong PR.](https://github.com/refined-github/refined-github/issues/1144)
- [](# "previous-next-commit-buttons") [Thêm các nút chuyển commit lặp lại ở cuối trang tab `Commits`.](https://user-images.githubusercontent.com/24777/41755271-741773de-75a4-11e8-9181-fcc1c73df633.png)
- [](# "hidden-review-comments-indicator") [Thêm chỉ báo bình luận khi các bình luận bị ẩn trong review PR.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253128043-a10eaf9e-ff81-48db-b67c-ee823804c859.gif)
- [](# "conflict-marker") [Hiển thị PR nào có xung đột trong danh sách PR.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253128438-d67c8f49-44f1-4e15-9363-a717109fef39.png)
- [](# "pr-commit-lines-changed") [Thêm thống kê diff trên các commit của PR.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253130044-494cd822-c460-42dc-8f65-44454a9d18e3.png)
- [](# "cross-deleted-pr-branches") [Gạch ngang các nhánh đã bị xóa trong PR.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/256963526-646ac7d0-3e7f-40c6-ba39-014b49bc0063.png)
- [](# "batch-mark-files-as-viewed") [Đánh dấu/bỏ đánh dấu nhiều file là “Đã xem” trong tab Files của PR. Nhấn vào ô checkbox đầu tiên bạn muốn đánh dấu/bỏ đánh dấu, sau đó nhấn `shift`-click ô khác; tất cả các file giữa hai ô sẽ được đánh dấu/bỏ đánh dấu là “Đã xem”.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257009611-17249bee-d2e2-42ac-bdf0-ebc90029544e.gif)
- [](# "closing-remarks") 🔥 [Hiển thị thẻ Git đầu tiên mà PR đã hợp nhất được đưa vào hoặc đề xuất tạo bản phát hành nếu chưa phát hành.](https://user-images.githubusercontent.com/1402241/169497171-85d4a97f-413a-41b4-84ba-885dca2b51cf.png)
- [](# "pr-jump-to-first-non-viewed-file") [Nhảy đến file đầu tiên chưa xem trong PR khi nhấn vào thanh tiến trình.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257011208-764f509d-fed9-424b-84e9-c01cf2fd428b.gif)
- [](# "jump-to-change-requested-comment") [Thêm liên kết để nhảy đến bình luận yêu cầu thay đổi mới nhất.](https://user-images.githubusercontent.com/19198931/98718312-418b9f00-23c9-11eb-8da2-dfb616e95eb6.gif)
- [](# "view-last-pr-deployment") [Thêm liên kết mở deployment mới nhất từ tiêu đề PR.](https://user-images.githubusercontent.com/44045911/232313171-b54ac9cc-ebb1-43ef-bd41-5d81ec9f9588.png)
- [](# "no-unnecessary-split-diff-view") [Luôn sử dụng diff hợp nhất trên các file mà diff tách không hữu ích.](https://user-images.githubusercontent.com/46634000/121495005-89af8600-c9d9-11eb-822d-77e0b987e3b1.png)
- [](# "emphasize-draft-pr-label") [Giúp dễ dàng phân biệt PR nháp trong danh sách.](https://user-images.githubusercontent.com/1402241/218252438-062a1ab3-4437-436d-9140-87bee23aaefb.png)

<!--
Tham khảo hướng dẫn về phong cách trong wiki. Giữ thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Chỉnh sửa pull request

- [](# "sync-pr-commit-title") 🔥 [Sử dụng tiêu đề PR làm tiêu đề commit squash mặc định](https://github.com/refined-github/refined-github/issues/276) và [cập nhật tiêu đề PR cho khớp với tiêu đề commit nếu có thay đổi.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257011579-25332762-b25f-407b-b6d2-bbfc13de2be7.png)
- [](# "update-pr-from-base-branch") [Thêm nút "Update branch" cho mọi PR.](https://user-images.githubusercontent.com/1402241/234483592-4867cb2e-21cb-436d-9ea0-aedadf834f19.png) GitHub cũng có tính năng này, nhưng phải cấu hình thủ công với các nhánh được bảo vệ.
- [](# "one-click-review-submission") [Đơn giản hóa form review PR: Duyệt hoặc từ chối review nhanh hơn với các nút chọn loại review một chạm.](https://user-images.githubusercontent.com/1402241/236627732-df341ff7-cd98-4cd0-a579-722d1fffa5cf.png)
- [](# "pull-request-hotkeys") [Thêm phím tắt để chuyển tab PR: <kbd>g</kbd> <kbd>←</kbd> và <kbd>g</kbd> <kbd>→</kbd>, hoặc <kbd>g</kbd> <kbd>1</kbd>, <kbd>g</kbd> <kbd>2</kbd>, <kbd>g</kbd> <kbd>3</kbd>, và <kbd>g</kbd> <kbd>4</kbd>](https://user-images.githubusercontent.com/16872793/94634958-7e7b5680-029f-11eb-82ea-1f96cd11e4cd.png).
- [](# "pr-branch-auto-delete") [Tự động xóa nhánh ngay sau khi hợp nhất PR, nếu có thể.](https://user-images.githubusercontent.com/1402241/177067141-eabc7494-38a2-45b5-aef9-ac33cc0da370.png) Các tên nhánh phổ biến được biết là dài hạn sẽ được loại trừ (`develop`, `release/*`, v.v.)
- [](# "one-click-pr-or-gist") [Cho phép tạo PR nháp và gist công khai chỉ với một cú nhấp.](https://user-images.githubusercontent.com/34235681/152473201-868ad7c1-e06f-4826-b808-d90bca7f08b3.png)
- [](# "clear-pr-merge-commit-message") [Xóa bớt nội dung thừa trong message commit merge PR, chỉ để lại các đồng tác giả không trùng lặp.](https://user-images.githubusercontent.com/1402241/79257078-62b6fc00-7e89-11ea-8798-c06f33baa94b.png)
- [](# "quick-review") [Thêm các nút quick-review vào sidebar PR, tự động focus vào ô nhập review, và thêm phím tắt mở popup review: <kbd>v</kbd>.](https://github.com/refined-github/refined-github/assets/1402241/f11039c4-c9d1-4adc-9a65-cfe1f2027ec3)
- [](# "pr-first-commit-title") [Sử dụng commit đầu tiên làm tiêu đề và mô tả cho PR mới.](https://user-images.githubusercontent.com/16872793/87246205-ccf42400-c419-11ea-86d5-0e6570d99e6e.gif)

<!--
Tham khảo hướng dẫn về phong cách trong wiki. Giữ thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Commit

- [](# "patch-diff-links") [Thêm liên kết tới file `.patch` và `.diff` trong commit.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257011950-51712338-ffba-4b71-ad8f-9a0f142afb85.png)
- [](# "more-file-links") [Thêm liên kết để xem bản raw, blame, và lịch sử của file trong PR và commit.](https://user-images.githubusercontent.com/46634000/145016304-aec5a8b8-4cdb-48e6-936f-b214a3fb4b49.png)
- [](# "one-click-diff-options") [Thêm nút một chạm để thay đổi kiểu diff và bỏ qua khoảng trắng, cùng với phím tắt bỏ qua khoảng trắng: <kbd>d</kbd> <kbd>w</kbd>.](https://user-images.githubusercontent.com/46634000/156766044-18c9ff50-aead-4c40-ba16-7428b3742b6c.png)
- [](# "extend-diff-expander") [Mở rộng nút `Expand diff` để có thể click trên toàn màn hình.](https://user-images.githubusercontent.com/1402241/152118201-f25034c7-6fae-4be0-bb3f-c217647e32b7.gif)
- [](# "hide-diff-signs") [Ẩn ký hiệu diff vì diff đã được mã hóa màu.](https://user-images.githubusercontent.com/1402241/54807718-149cec80-4cb9-11e9-869c-e265863211e3.png)
- [](# "suggest-commit-title-limit") [Gợi ý giới hạn tiêu đề commit và PR ở 72 ký tự.](https://github.com/user-attachments/assets/e0392989-9c60-4f5c-9052-27a3bb51d4e4)
- [](# "tags-on-commits-list") [Hiển thị các thẻ tương ứng bên cạnh commit.](https://user-images.githubusercontent.com/1402241/285106537-3c882cb2-6847-4098-9e51-cf2951dee818.png)
- [](# "mark-merge-commits-in-list") [Đánh dấu các commit hợp nhất trong danh sách commit.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/285106996-9bdbc938-69c4-4692-8d47-11e30676de62.png)
- [](# "deep-reblame") [Khi khám phá blame, `Alt`-click vào nút “Reblame” sẽ trích xuất các commit của PR liên quan trước, thay vì xem commit như một thay đổi đơn lẻ.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257035884-732ee7ff-22c5-4049-af7d-f11117d2bbe4.png)
- [](# "new-or-deleted-file") [Hiển thị biểu tượng cho biết file trong commit và PR là được thêm mới hay bị xóa.](https://user-images.githubusercontent.com/1402241/90332474-23262b00-dfb5-11ea-9a03-8fd676ea0fdd.png)
- [](# "easy-toggle-files") [Bật khả năng chuyển đổi diff file bằng cách click vào thanh tiêu đề của chúng.](https://user-images.githubusercontent.com/47531779/99855419-be173e00-2b7e-11eb-9a55-0f6251aeb0ef.gif)
- [](# "same-branch-author-commits") [Giữ nguyên nhánh và đường dẫn hiện tại khi xem tất cả commit của một tác giả.](https://user-images.githubusercontent.com/44045911/148764372-ee443213-e61a-4227-9219-0ee54ed832e8.png)
- [](# "easy-toggle-commit-messages") [Bật khả năng chuyển đổi thông điệp commit bằng cách click vào hộp commit.](https://user-images.githubusercontent.com/1402241/152121837-ca13bf8a-9b7f-4517-8e8d-b58bb135523b.gif)
- [](# "link-to-compare-diff") [Tạo liên kết cho dòng "X files changed" trên trang so sánh để chuyển đến diff.](https://user-images.githubusercontent.com/46634000/157072587-0335357a-18c7-44c4-ae6e-237080fb36b4.png)
- [](# "conventional-commits") [Hiển thị loại conventional commit dưới dạng nhãn trước thông điệp commit.](https://github.com/user-attachments/assets/980a2d5e-13c2-4b1b-bb80-81dc94723000)

<!--
Tham khảo hướng dẫn về phong cách trong wiki. Giữ thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Thẻ và phát hành

- [](# "release-download-count") [Thêm số lượt tải xuống bên cạnh tài nguyên phát hành.](https://user-images.githubusercontent.com/1402241/197958719-1577bc1b-1f4d-44a8-98c2-2645b7b14d31.png)
- [](# "releases-tab") [Thêm tab `Releases` và phím tắt: <kbd>g</kbd> <kbd>r</kbd>.](https://cloud.githubusercontent.com/assets/170270/13136797/16d3f0ea-d64f-11e5-8a45-d771c903038f.png)
- [](# "releases-dropdown") [Thêm dropdown/tìm kiếm thẻ trên trang tag/phát hành.](https://user-images.githubusercontent.com/1402241/231678527-f0a96112-9c30-4b49-8205-efa472bd880e.png)
- [](# "create-release-shortcut") Thêm phím tắt để tạo phát hành mới khi ở trang Releases: <kbd>c</kbd>.
- [](# "tag-changes-link") 🔥 [Thêm liên kết đến thay đổi kể từ thẻ/phát hành gần nhất cho mỗi thẻ/phát hành.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257036739-bebafb94-cb94-4053-9768-ff97306ab862.png)
- [](# "convert-release-to-draft") [Thêm nút chuyển phát hành thành bản nháp.](https://user-images.githubusercontent.com/46634000/139236979-44533bfd-5c17-457d-bdc1-f9ec395f6a3a.png)
- [](# "link-to-changelog-file") [Thêm nút xem file changelog từ trang phát hành.](https://user-images.githubusercontent.com/46634000/139236982-a1bce2a2-f3aa-40a9-bca4-8756bc941210.png)

<!--
Tham khảo hướng dẫn về phong cách trong wiki. Giữ thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Hồ sơ

- [](# "user-profile-follower-badge") [Trên hồ sơ, hiển thị liệu người dùng có theo dõi bạn không.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/263206287-c8e1b94c-ec80-4394-bbb3-1cf6fb08b807.png)
- [](# "profile-gists-link") [Thêm liên kết tới gist công khai của người dùng trên trang hồ sơ.](https://user-images.githubusercontent.com/44045911/87950518-f7a94100-cad9-11ea-8393-609fad70635c.png)
- [](# "mark-private-orgs") [Đánh dấu tổ chức riêng tư trên hồ sơ của bạn.](https://github.com/user-attachments/assets/145a7a97-7b8c-4ac4-8288-f72dcb4613ea)
- [](# "profile-hotkey") Thêm phím tắt để truy cập hồ sơ của bạn: <kbd>g</kbd> <kbd>m</kbd>.
- [](# "show-user-top-repositories") [Thêm liên kết tới repo được gắn sao nhiều nhất của người dùng.](https://user-images.githubusercontent.com/1402241/48474026-43e3ae80-e82c-11e8-93de-159ad4c6f283.png)
- [](# "hide-user-forks") [Mặc định lọc bỏ fork và repo đã lưu trữ khỏi hồ sơ, chỉ để lại repo gốc.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/263195425-85cf0951-c6ed-45fe-8cfc-e447e3ed2a25.png) [(nhưng vẫn có thể hiển thị lại.)](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/262547829-2da96718-fb18-4f2e-b637-8157f552e278.png)
- [](# "linkify-user-location") [Tạo liên kết cho vị trí người dùng trong hovercard và trang hồ sơ.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/262554067-43bea584-cdb4-41c7-b0fa-f487e7ef8807.png)
- [](# "user-local-time") [Hiển thị giờ địa phương của người dùng trong hovercard (dựa trên commit cuối cùng của họ).](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257039621-132bd789-e213-4a89-83ff-e1266215c60d.png)
- [](# "conversation-links-on-repo-lists") [Thêm liên kết tới issues và pulls trong tab repository hồ sơ người dùng và tìm kiếm toàn cục.](https://user-images.githubusercontent.com/16872793/78712349-82c54900-78e6-11ea-8328-3c2d39a78862.png)

<!--
Tham khảo hướng dẫn về phong cách trong wiki. Giữ thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Thông báo

- [](# "open-all-notifications") [Thêm nút mở tất cả thông báo chưa đọc cùng lúc.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257085496-17e5c6fa-6bad-443d-96d2-d97e73cd1a5e.png)
- [](# "unread-anywhere") 🔥 [Thêm phím tắt toàn cục để mở tất cả thông báo chưa đọc cùng lúc: <kbd>g</kbd> <kbd>u</kbd>](https://github.com/user-attachments/assets/3afb7e86-66e8-4b26-a5c0-9c93fb5d8141)
- [](# "select-all-notifications-shortcut") Thêm phím tắt để chọn tất cả thông báo đang hiển thị: <kbd>a</kbd>.
- [](# "stop-redirecting-in-notification-bar") [Dừng chuyển hướng tới hộp thư thông báo từ thanh thông báo khi giữ <kbd>Alt</kbd>.](https://user-images.githubusercontent.com/202916/80318782-c38cef80-880c-11ea-9226-72c585f42a51.png)
- [](# "last-notification-page-button") [Thêm liên kết tới trang cuối cùng của thông báo.](https://user-images.githubusercontent.com/16872793/199828181-3ff2cef3-8740-4efa-8122-8f2f222bd657.png)
- [](# "pr-notification-link") [Chuyển thông báo PR sang tab Conversation thay vì trang commit, vốn có thể dẫn đến 404.](https://github.com/refined-github/refined-github/assets/1402241/621f6512-655e-4565-a37b-2b159ea0ffce)
- [](# "sticky-notifications-actions") [Giữ thanh hành động thông báo luôn cố định.](https://github.com/refined-github/refined-github/assets/1402241/5b370430-2319-4c78-88e7-c2c06cd1c30f)

<!--
Tham khảo hướng dẫn về phong cách trong wiki. Giữ thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Toàn cục

- [](# "useful-not-found-page") 🔥 [Thêm trang liên quan và lựa chọn thay thế trên trang 404.](https://user-images.githubusercontent.com/1402241/46402857-7bdada80-c733-11e8-91a1-856573078ff5.png)
- [](# "selection-in-new-tab") [Thêm phím tắt mở lựa chọn trong tab mới khi điều hướng bằng <kbd>j</kbd> và <kbd>k</kbd>: <kbd>shift</kbd> <kbd>o</kbd>.](https://github.com/refined-github/refined-github/issues/1110)
- [](# "close-out-of-view-modals") [Tự động đóng menu dropdown khi chúng không còn hiển thị.](https://user-images.githubusercontent.com/1402241/37022353-531c676e-2155-11e8-96cc-80d934bb22e0.gif)
- [](# "parse-backticks") [GitHub hiển thị `` `chữ trong backticks` `` ở một số nơi nhưng không ở nơi khác; tính năng này bổ sung vào chỗ bị quên.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/262555091-df31aa17-e7a2-4c16-91ca-fb077ba6134a.png)
- [](# "pagination-hotkey") Thêm phím tắt để chuyển trang với phân trang: <kbd>←</kbd> và <kbd>→</kbd>.
- [](# "action-used-by-link") [Cho phép bạn xem người khác đang sử dụng Action hiện tại trên Marketplace như thế nào.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258552390-7d2cd013-c167-4fe5-9731-33622b8607e9.png)
- [](# "improve-shortcut-help") [Hiển thị tất cả phím tắt mới của Refined GitHub trong cửa sổ trợ giúp (<kbd>?</kbd>).](https://user-images.githubusercontent.com/29176678/36999174-9f07d33e-20bf-11e8-83e3-b3a9908a4b5f.png)

<!--
Tham khảo hướng dẫn về phong cách trong wiki. Giữ thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Quy tắc ứng xử

- [](# "netiquette") [Thêm nhắc nhở quy tắc ứng xử tinh tế (issue cũ đã đóng, issue hoạt động mạnh, PR nháp, …).](https://github.com/user-attachments/assets/8646d663-7458-4e6d-888a-68d38110fcda)
- [](# "warn-pr-from-master") [Cảnh báo khi tạo PR từ nhánh mặc định, vì đây là một anti-pattern.](https://user-images.githubusercontent.com/1402241/52543516-3ca94e00-2de5-11e9-9f80-ff8f9fe8bdc4.png)
- [](# "warning-for-disallow-edits") [Cảnh báo khi bỏ chọn `Allow edits from maintainers`, vì sẽ gây khó cho người bảo trì.](https://user-images.githubusercontent.com/1402241/53151888-24101380-35ef-11e9-8d30-d6315ad97325.gif)

<!--
Tham khảo hướng dẫn về phong cách trong wiki. Giữ thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Sửa chữa các thiếu sót của GitHub

- [](# "hide-navigation-hover-highlight") Loại bỏ hiệu ứng hover file trong trình duyệt file của repo.
- [](# "clean-repo-sidebar") [Loại bỏ thông tin không cần thiết hoặc dư thừa khỏi thanh bên của repository.](https://user-images.githubusercontent.com/46634000/107955448-18694480-6f9e-11eb-8bc6-80cc90d910bc.png)
- [](# "linkify-branch-references") [Tạo liên kết cho tham chiếu nhánh trên các trang "Quick PR".](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258553554-e1711be0-d5ce-4edc-aaf8-72d659c881bc.png)
- [](# "hide-issue-list-autocomplete") [Xóa tính năng tự động hoàn thành trên trường tìm kiếm.](https://user-images.githubusercontent.com/1402241/42991841-1f057e4e-8c07-11e8-909c-b051db7a2a03.png)
- [](# "actionable-pr-view-file") [Chuyển hướng "View file" trên PR đến nhánh thay vì commit, để nút Edit/Delete sẽ được bật trên trang "View file".](https://user-images.githubusercontent.com/1402241/69044026-c5b17d80-0a26-11ea-86ae-c95f89d3669a.png)
- [](# "reload-failed-proxied-images") [Thử tải lại hình ảnh bị lỗi tải do proxy hạn chế của GitHub.](https://user-images.githubusercontent.com/14858959/64068746-21991100-cc45-11e9-844e-827f5ac9b51e.png)
- [](# "unwrap-unnecessary-dropdowns") [Biến một số dropdown thành chỉ 1 lần click thay vì phải 2 lần click không cần thiết.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258554504-97d4079a-2aae-4aea-a870-653a267494a8.png)
- [](# "prevent-link-loss") [Gợi ý sửa các liên kết bị rút ngắn sai bởi GitHub.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/260087535-a0f19995-5f4a-44e9-87d8-cf742b9bfeed.gif)
- [](# "linkify-user-edit-history-popup") [Tạo liên kết cho tên người dùng trong popup lịch sử chỉnh sửa.](https://user-images.githubusercontent.com/1402241/88917988-9ebb7480-d260-11ea-8690-0a3440f1ebbc.png)
- [](# "prevent-duplicate-pr-submission") [Tránh tạo PR trùng khi lỡ nhấn "Create pull request" nhiều lần.](https://user-images.githubusercontent.com/16872793/89589967-e029c200-d814-11ea-962b-3ff1f6236781.gif)
- [](# "convert-pr-to-draft-improvements") [Di chuyển nút "Convert PR to Draft" vào hộp mergeability và thêm phản hồi trực quan cho nút xác nhận.](https://user-images.githubusercontent.com/1402241/95644892-885f3f80-0a7f-11eb-8428-8e0fb0c8dfa5.gif)
- [](# "prevent-pr-merge-panel-opening") Ngăn panel merge tự động mở mỗi lần tải trang sau khi đã mở một lần.
- [](# "command-palette-navigation-shortcuts") Thêm phím tắt để chọn mục trong command palette bằng <kbd>ctrl</kbd> <kbd>n</kbd> và <kbd>ctrl</kbd> <kbd>p</kbd> (chỉ macOS).
- [](# "prevent-comment-loss") [Khi viết/chỉnh sửa bình luận, mở liên kết xem trước trong tab mới thay vì rời khỏi trang.](https://user-images.githubusercontent.com/17681399/282616531-2befcabe-5c80-4b9a-bfb5-7b9917847bb5.gif)
- [](# "fix-no-pr-search") [Chuyển hướng về danh sách issue của repo khi tìm kiếm không bao gồm `is:pr`.](https://user-images.githubusercontent.com/46634000/286579939-50122f02-dcfd-4510-b9e1-03d9985da2cd.gif)
- [](# "clean-readme-url") [Loại bỏ tham số "readme-ov-file" dư thừa khỏi URL repo.](https://github.com/refined-github/refined-github/assets/1402241/73e96411-3314-4501-a9b6-d006af6fcc47)
- [](# "click-outside-modal") [Đóng danh sách kiểm tra khi click ngoài modal.](https://github.com/refined-github/refined-github/issues/7157)
- [](# "linkify-line-numbers") [Tạo liên kết cho số dòng nơi GitHub đã quên thêm liên kết.](https://github.com/refined-github/refined-github/assets/1402241/d5b67f4e-35c3-45d8-b72c-937b855168c3)
- [](# "sidebar-focus-file") [Cuộn cây file tới file hiện tại.](https://github.com/user-attachments/assets/25e1e19e-799b-4dab-ae81-59ba17ad1194)
- [](# "no-modals") [Vô hiệu hóa các modal làm giảm trải nghiệm người dùng thay vì cải thiện nó.](https://github.com/user-attachments/assets/7b63c7db-ae31-4ee8-8510-3b9db0c11f3e)
- [](# "same-page-links") Giữ liên kết không mở ở tab mới khi không cần thiết. "Mở ở tab mới" phải do người dùng chọn, không phải mặc định.

<!--
Tham khảo hướng dẫn về phong cách trong wiki. Giữ thông báo này giữa các phần.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Trước đây là một phần của Refined GitHub

[GitHub đã lấy cảm hứng từ Refined GitHub](https://github.blog/2018-08-28-announcing-paper-cuts/) và triển khai gốc hàng chục tính năng của nó, 🎉 vì vậy chúng đã được [gỡ khỏi tiện ích mở rộng này.](https://github.com/refined-github/refined-github/pulls?q=is%3Apr+is%3Amerged+label%3A%22implemented+by+github%22) Bạn cũng có thể xem [tất cả tính năng trước đây](https://github.com/refined-github/refined-github/pulls?q=is%3Apr+is%3Amerged+-label%3Ameta+in%3Atitle+drop+feature) của Refined GitHub trong một danh sách.

## Tùy chỉnh

Hầu hết các tính năng đều có thể tắt nếu chúng dựa trên JavaScript và bạn có thể ghi đè CSS của chúng tôi bằng CSS của riêng bạn trong tùy chọn tiện ích mở rộng.

Chúng tôi rất hoan nghênh các ý tưởng và đóng góp, nhưng lưu ý đây là một dự án có quan điểm rõ ràng. [Có tiêu chuẩn cao khi thêm tính năng mới.](https://github.com/refined-github/refined-github/wiki/%22Can-you-add-this-feature%3F%22) Người dùng sẽ luôn bất đồng về điều gì đó. Tuy nhiên, chúng tôi luôn sẵn sàng thảo luận.

## Liên kết
- [Thêm các tiện ích mở rộng](https://github.com/refined-github/refined-github/wiki/Other-extensions)
- [Hướng dẫn đóng góp](https://github.com/refined-github/refined-github/wiki/Contributing)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---