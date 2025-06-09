<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">Chuyển giọng nói thành văn bản liền mạch, được hỗ trợ bởi Mô hình Whisper của OpenAI</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## Giới thiệu

Whispering là một ứng dụng chuyển giọng nói thành văn bản mã nguồn mở, cung cấp chức năng chuyển đổi giọng nói thành văn bản toàn cục, với các tùy chọn như phím tắt và tự động sao chép/dán để việc nhập liệu bằng giọng nói trở nên liền mạch nhất có thể.

Bên trong, ứng dụng được vận hành bởi mô hình Whisper của OpenAI, mang lại độ chính xác vượt trội so với các tính năng nhập liệu bằng giọng nói có sẵn.

> **Lưu ý quan trọng**: Whispering chủ yếu được thiết kế như một công cụ chuyển giọng nói thành văn bản, không phải công cụ ghi âm. Đối với các bản ghi dài mà độ tin cậy là then chốt, tôi khuyên bạn nên sử dụng ứng dụng ghi âm chuyên dụng trên điện thoại hoặc thiết bị của mình, sử dụng các API ghi âm gốc. Điều này đảm bảo chất lượng âm thanh tối ưu và độ ổn định khi ghi âm.

## Demo

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Tính năng chính

1. **Chuyển giọng nói thành văn bản toàn cục**: Truy cập chức năng chuyển giọng nói thành văn bản của Whisper ở bất cứ đâu với phím tắt toàn cục hoặc chỉ trong hai lần nhấp chuột.
2. **Trải nghiệm đa nền tảng**:
   - Ứng dụng máy tính: Cho phép chuyển giọng nói thành văn bản trên tất cả các ứng dụng.
   - Tiện ích mở rộng trình duyệt: Cung cấp chức năng chuyển giọng nói thành văn bản trên trình duyệt thông qua kết nối với web app.
3. **Tích hợp với Chat**: Tiện ích mở rộng trình duyệt bổ sung nút ghi âm vào giao diện ChatGPT và Claude, cho phép nhập giọng nói trực tiếp và chuyển thành văn bản trong khung chat.
4. **Quản lý bản chuyển đổi**: Xem lại và chỉnh sửa các bản chuyển đổi trong ứng dụng Whispering để đảm bảo độ chính xác và rõ ràng.
5. **Tự động tích hợp clipboard**: Khi hoàn thành chuyển đổi, văn bản sẽ tự động được sao chép vào clipboard. Ngoài ra còn có tùy chọn tự động dán văn bản.

## Dữ liệu của tôi được lưu trữ như thế nào?

Whispering lưu trữ tối đa dữ liệu trên thiết bị của bạn, bao gồm cả bản ghi âm và văn bản đã chuyển đổi. Cách tiếp cận này đảm bảo quyền riêng tư và bảo mật dữ liệu tối đa. Dưới đây là tổng quan về cách dữ liệu được xử lý:

1. **Lưu trữ cục bộ**: Các bản ghi âm và văn bản đã chuyển đổi được lưu trong IndexedDB, dùng để lưu trữ dữ liệu dạng blob cũng như tất cả dữ liệu văn bản và các bản chuyển đổi của bạn.

2. **Dịch vụ chuyển đổi**: Dữ liệu duy nhất được gửi ra ngoài là bản ghi âm của bạn đến dịch vụ chuyển đổi bên ngoài — nếu bạn chọn sử dụng. Bạn có các lựa chọn sau:
   - Các dịch vụ bên ngoài như OpenAI hoặc Groq
   - Dịch vụ chuyển đổi cục bộ như `faster-whisper-server`, giữ mọi thứ trên thiết bị

3. **Cài đặt cấu hình**: Bạn có thể thay đổi dịch vụ chuyển đổi trong phần cài đặt để đảm bảo chức năng tối đa trên thiết bị.

## Cài đặt

### Ứng dụng Web

Truy cập [whispering.bradenwong.com](https://whispering.bradenwong.com/), nơi luôn có phiên bản mới nhất của thư mục `apps/app` được host trên Vercel.

### Tiện ích mở rộng Chrome

Cài đặt tiện ích mở rộng Chrome từ Chrome Web Store [tại đây](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### Ứng dụng Máy tính

Để tải về và cài đặt ứng dụng Whispering trên máy tính, làm theo các bước phù hợp với hệ điều hành của bạn:

#### Windows

1. Tải gói cài đặt có đuôi `.msi` từ [trang phát hành mới nhất](https://github.com/braden-w/whispering/releases).
2. Mở tệp `.msi` đã tải về để chạy trình cài đặt.
3. Nếu có cảnh báo không an toàn, hãy nhấp vào `More Info` -> `Run Anyway` để tiếp tục cài đặt.
4. Làm theo hướng dẫn trên màn hình để hoàn tất cài đặt.

#### macOS

Đối với macOS, hãy làm theo các bước sau để cài đặt Whispering:

1. **Tải gói cài đặt**:
   - Truy cập [trang phát hành mới nhất](https://github.com/braden-w/whispering/releases).
   - Chọn gói phù hợp:
     - Dành cho Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Dành cho Intel: `Whispering_x.x.x_x64.dmg`

2. **Cài đặt ứng dụng**:
   - Mở tệp `.dmg` đã tải về.
   - Kéo ứng dụng Whispering vào thư mục Applications.

3. **Khởi động Whispering**:
   - Mở Whispering từ thư mục Applications.
   - Nếu thấy cảnh báo về nhà phát triển chưa xác minh:
     - Nhấp `Cancel`
     - Nhấp chuột phải vào ứng dụng trong Finder và chọn `Open`

4. **Khắc phục sự cố** (chỉ Apple Silicon):
   Nếu gặp lỗi `"Whispering" is damaged and can't be opened`:
   - Mở Terminal
   - Chạy lệnh sau:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Thử mở lại ứng dụng

Sau khi hoàn thành các bước trên, Whispering sẽ sẵn sàng để sử dụng trên hệ thống macOS của bạn.

#### Linux

Đối với Linux, có nhiều lựa chọn cài đặt khác nhau. Hãy chọn phương án phù hợp với môi trường của bạn:

1. **AppImage**:

   - Tải tệp `.AppImage` từ [trang phát hành mới nhất](https://github.com/braden-w/whispering/releases).
   - Cấp quyền thực thi cho tệp:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - Chạy tệp AppImage:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **Gói DEB (Debian/Ubuntu)**:
   - Tải tệp `.deb` từ [trang phát hành mới nhất](https://github.com/braden-w/whispering/releases).
   - Cài đặt gói bằng `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Khắc phục các phụ thuộc còn thiếu:
     ```bash
     sudo apt-get install -f
     ```

Sau khi cài đặt, ứng dụng đã sẵn sàng để sử dụng.

## Sử dụng

### Tiện ích mở rộng Chrome

Sau khi cài đặt tiện ích mở rộng Chrome, bạn sẽ thấy biểu tượng Whispering trên thanh tiện ích mở rộng của Chrome. Nhấp vào biểu tượng này để mở tiện ích. Nhấn nút micro để bắt đầu ghi âm giọng nói và nhấn nút hình vuông khi hoàn tất. Bản chuyển đổi sẽ xuất hiện trong ô văn bản bên dưới.

Để sử dụng tính năng ChatGPT hoặc Claude, truy cập trang web ChatGPT hoặc Claude. Bạn sẽ thấy một nút ghi âm mới trong giao diện chat. Nhấn nút này để bắt đầu và dừng ghi âm, văn bản chuyển đổi sẽ tự động được chèn vào trường nhập liệu chat.

Để sử dụng phím tắt, nhấn <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> hoặc <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (có thể cấu hình lại sau trong phần phím tắt của tiện ích mở rộng Chrome) để bắt đầu ghi âm từ bất kỳ trang web nào. Văn bản chuyển đổi sẽ tự động được sao chép vào clipboard và dán vào trường nhập liệu hiện tại.

Tiện ích mở rộng Chrome giao tiếp với [whispering.bradenwong.com](https://whispering.bradenwong.com) và sẽ tự động cố gắng tạo một tab nền nếu không tìm thấy. Đa số lỗi phát sinh đều do việc liên lạc này thất bại, ví dụ như trường hợp hiếm hoi tab nền bị chuyển sang trạng thái ngủ.

### Ứng dụng Web

Ứng dụng web có thể truy cập tại [whispering.bradenwong.com](https://whispering.bradenwong.com). Nhấn nút micro để ghi âm giọng nói, sau đó nhấn nút hình vuông khi hoàn tất. Bản chuyển đổi sẽ xuất hiện trong ô văn bản.

### Ứng dụng Máy tính

Sau khi cài đặt ứng dụng Whispering trên máy tính, nhấn <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (có thể cấu hình trong phần cài đặt) để bắt đầu ghi âm từ bất kỳ đâu trên màn hình. Văn bản chuyển đổi sẽ tự động được sao chép vào clipboard và dán, cả hai tính năng này đều có thể bật/tắt trong phần cài đặt.

## Được xây dựng với

#### Web và Máy tính

Ứng dụng Whispering được xây dựng bằng các công nghệ và thư viện sau:

- [Svelte 5](https://svelte.dev): Thư viện giao diện người dùng phản ứng được lựa chọn.
- [SvelteKit](https://kit.svelte.dev/docs): Dùng để định tuyến và tạo trang tĩnh, phục vụ cả website và frontend tĩnh cho ứng dụng Tauri.
- [Tauri](https://tauri.studio/en/docs/intro/): Framework ứng dụng máy tính.
- [Effect-TS](https://github.com/Effect-TS/effect): Để bổ sung một chút lập trình hàm và viết các hàm cực kỳ an toàn về kiểu, với lỗi được bao gồm trong kiểu trả về của hàm.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Thư viện toast đơn giản, tùy biến cho ứng dụng Svelte. Dùng để bắt và hiển thị lỗi được chuyển lên thông qua Effect-TS bằng hàm `renderAsToast`.
- [TanStack Table](https://tanstack.com/table): Sức mạnh cho tất cả bảng dữ liệu.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): API cấp thấp để lưu trữ lượng lớn dữ liệu có cấu trúc trong trình duyệt. Đồng bộ hóa với Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): Thư viện thành phần giao diện được lựa chọn.
- [TailwindCSS](https://tailwindcss.com/docs): Framework CSS utility-first để xây dựng giao diện người dùng tùy chỉnh nhanh chóng.
- [Turborepo](https://turborepo.org/): Quản lý monorepo, cho phép `apps/app` và `apps/extension` dùng chung mã nguồn, giảm đáng kể trùng lặp mã và quan trọng hơn là giữ một nguồn mã duy nhất.
- [Rust](https://www.rust-lang.org): Mở rộng các tính năng của ứng dụng máy tính, như sử dụng crate `enigo` để xử lý tự động dán văn bản.
- [Vercel](https://vercel.com/): Hosting phù hợp cho dự án cá nhân và tích hợp tốt với Turborepo.
- [Zapsplat.com](https://www.zapsplat.com/): Thư viện hiệu ứng âm thanh miễn phí bản quyền.

#### Tiện ích mở rộng

Tiện ích mở rộng Chrome Whispering được xây dựng bằng:

- [Plasmo](https://docs.plasmo.com/): Framework xây dựng tiện ích mở rộng Chrome. Sử dụng [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) để liên lạc với website Whispering.
- [Effect-TS](https://github.com/Effect-TS/effect): Để bổ sung một chút lập trình hàm và viết các hàm cực kỳ an toàn về kiểu, với lỗi được bao gồm trong kiểu trả về của hàm.
- [React](https://reactjs.org): Thư viện giao diện người dùng phản ứng cho tiện ích mở rộng Chrome, do Plasmo hiện chưa hỗ trợ Svelte 5.
- [ShadCN](https://github.com/shadcn): Thư viện thành phần giao diện cho tiện ích mở rộng Chrome.
- [TailwindCSS](https://tailwindcss.com/docs): Một framework CSS ưu tiên tiện ích để xây dựng giao diện người dùng tùy chỉnh một cách nhanh chóng.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): API cho tiện ích mở rộng Chrome.
- [Zapsplat.com](https://www.zapsplat.com/): Thư viện hiệu ứng âm thanh miễn phí bản quyền.

## Chạy Whispering ở Chế Độ Phát Triển Cục Bộ

Để thiết lập dự án trên máy tính của bạn, hãy thực hiện các bước sau:

1. Sao chép kho lưu trữ: `git clone https://github.com/braden-w/whispering.git`
2. Chuyển vào thư mục dự án: `cd whispering`
3. Cài đặt các phụ thuộc cần thiết: `pnpm i`

Để chạy ứng dụng desktop và website Whispering ở chế độ phát triển:

4. Chuyển vào thư mục app: `cd apps/app`
5. Chạy server phát triển: `pnpm tauri dev`

Ứng dụng desktop sẽ tự động mở để phát triển cục bộ. Để phát triển web app, hãy mở trình duyệt và truy cập `http://localhost:5173`.

Để chạy tiện ích mở rộng Chrome của Whispering ở chế độ phát triển:

4. Chuyển vào thư mục extension: `cd apps/extension`
5. Chạy server phát triển: `pnpm dev --target=chrome-mv3`

Để phát triển tiện ích mở rộng chrome, hãy tải nó vào Chrome bằng cách truy cập `chrome://extensions`, bật chế độ nhà phát triển và tải thư mục `apps/extension/build/{platform}-{manifest-version}-dev` dưới dạng tiện ích chưa đóng gói.

## Tự Xây Dựng File Thực Thi

Nếu bạn có bất kỳ lo ngại nào về độ tin cậy của các trình cài đặt hoặc muốn kiểm soát nhiều hơn, bạn luôn có thể tự xây dựng file thực thi. Điều này yêu cầu thiết lập nhiều hơn, nhưng đảm bảo rằng bạn đang chạy đúng mã nguồn mong muốn. Đó chính là vẻ đẹp của phần mềm mã nguồn mở!

### Chrome

1. Chuyển vào thư mục extension: `cd apps/extension`
2. Cài đặt các phụ thuộc cần thiết: `pnpm i`
3. Chạy Plasmo build: `pnpm plasmo build --target=chrome-mv3`
4. Kết quả sẽ nằm trong `apps/extension/build/chrome-mv3-prod`, có thể tải lên Chrome như một tiện ích chưa đóng gói.
5. Ngoài ra, bạn có thể xây dựng tiện ích cho Chrome Web Store: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Chuyển vào thư mục extension: `cd apps/extension`
2. Cài đặt các phụ thuộc cần thiết: `pnpm i`
3. Chạy Plasmo build: `pnpm plasmo build --target=firefox-mv3`
4. Kết quả sẽ nằm trong `apps/extension/build/firefox-mv3-prod`, có thể tải lên Chrome như một tiện ích chưa đóng gói.
5. Ngoài ra, bạn có thể xây dựng tiện ích cho Chrome Web Store: `pnpm plasmo build --target=firefox-mv3 --release`

### Desktop

1. Chuyển vào thư mục app: `cd apps/app`
2. Cài đặt các phụ thuộc cần thiết: `pnpm i`
3. Chạy Tauri Build: `pnpm tauri build`
4. Bạn có thể tìm file thực thi trong thư mục `apps/app/target/release`.

## Đóng Góp

Chúng tôi hoan nghênh sự đóng góp từ cộng đồng! Nếu bạn muốn đóng góp cho Whispering, vui lòng làm theo các bước sau:

1. Fork kho lưu trữ.
2. Tạo một nhánh mới cho tính năng hoặc bản sửa lỗi của bạn: `git checkout -b feature/your-feature-name` hoặc `git checkout -b fix/your-bugfix-name`
3. Thực hiện các thay đổi và commit với một thông điệp mô tả rõ ràng.
4. Đẩy nhánh của bạn lên kho lưu trữ đã fork: `git push origin your-branch-name`
5. Tạo pull request từ kho fork của bạn tới kho gốc.

Vui lòng đảm bảo mã của bạn tuân thủ các quy ước đã được thiết lập và được ghi chú rõ ràng.

## Giấy Phép

Whispering được phát hành theo [MIT License](https://opensource.org/licenses/MIT).

## Nhà Tài Trợ

Dự án này nhận được sự hỗ trợ từ các cá nhân và tổ chức tuyệt vời sau:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Hỗ Trợ và Góp Ý

Nếu bạn gặp bất kỳ vấn đề nào hoặc có đề xuất cải tiến, vui lòng mở issue trên [thẻ issues của GitHub](https://github.com/braden-w/whispering/issues) hoặc liên hệ với tôi qua [whispering@bradenwong.com](mailto:whispering@bradenwong.com). Tôi thực sự đánh giá cao phản hồi của bạn!

Cảm ơn bạn đã sử dụng Whispering và chúc bạn sáng tác vui vẻ!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---