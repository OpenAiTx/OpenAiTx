# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React là một thư viện JavaScript dùng để xây dựng giao diện người dùng.

* **Khai báo:** React giúp việc tạo giao diện người dùng tương tác trở nên dễ dàng. Thiết kế các giao diện đơn giản cho từng trạng thái trong ứng dụng của bạn, và React sẽ cập nhật cũng như hiển thị đúng các thành phần cần thiết khi dữ liệu của bạn thay đổi. Các giao diện khai báo giúp mã nguồn dễ dự đoán hơn, dễ hiểu hơn và dễ gỡ lỗi hơn.
* **Dựa trên thành phần:** Xây dựng các thành phần độc lập, quản lý trạng thái riêng của chúng, sau đó kết hợp chúng để tạo nên các giao diện phức tạp. Vì logic của thành phần được viết bằng JavaScript thay vì template, bạn có thể dễ dàng truyền dữ liệu phong phú qua ứng dụng và giữ trạng thái ngoài DOM.
* **Học một lần, viết ở mọi nơi:** Chúng tôi không giả định gì về các công nghệ khác trong hệ thống của bạn, vì vậy bạn có thể phát triển các tính năng mới trong React mà không cần viết lại mã cũ. React cũng có thể render trên máy chủ bằng [Node](https://nodejs.org/en) và hỗ trợ ứng dụng di động qua [React Native](https://reactnative.dev/).

[Tìm hiểu cách sử dụng React trong dự án của bạn](https://react.dev/learn).

## Cài đặt

React được thiết kế để có thể áp dụng dần dần từ đầu, và **bạn có thể sử dụng React ít hay nhiều tùy ý**:

* Sử dụng [Bắt đầu nhanh](https://react.dev/learn) để trải nghiệm React.
* [Thêm React vào Dự án Hiện tại](https://react.dev/learn/add-react-to-an-existing-project) để sử dụng React theo mức bạn cần.
* [Tạo một Ứng dụng React Mới](https://react.dev/learn/start-a-new-react-project) nếu bạn cần một bộ công cụ JavaScript mạnh mẽ.

## Tài liệu

Bạn có thể tìm tài liệu của React [trên trang web](https://react.dev/).

Xem trang [Bắt đầu](https://react.dev/learn) để có cái nhìn tổng quan nhanh.

Tài liệu được chia thành nhiều phần:

* [Bắt đầu nhanh](https://react.dev/learn)
* [Hướng dẫn](https://react.dev/learn/tutorial-tic-tac-toe)
* [Tư duy theo React](https://react.dev/learn/thinking-in-react)
* [Cài đặt](https://react.dev/learn/installation)
* [Mô tả giao diện UI](https://react.dev/learn/describing-the-ui)
* [Thêm tính tương tác](https://react.dev/learn/adding-interactivity)
* [Quản lý trạng thái](https://react.dev/learn/managing-state)
* [Hướng dẫn nâng cao](https://react.dev/learn/escape-hatches)
* [Tham khảo API](https://react.dev/reference/react)
* [Nơi nhận hỗ trợ](https://react.dev/community)
* [Hướng dẫn đóng góp](https://legacy.reactjs.org/docs/how-to-contribute.html)

Bạn có thể cải thiện tài liệu bằng cách gửi pull request tới [repository này](https://github.com/reactjs/react.dev).

## Ví dụ

Chúng tôi có nhiều ví dụ [trên trang web](https://react.dev/). Dưới đây là ví dụ đầu tiên để bạn bắt đầu:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Ví dụ này sẽ hiển thị "Hello Taylor" vào một vùng chứa trên trang.

Bạn sẽ nhận thấy chúng tôi sử dụng cú pháp giống HTML; [chúng tôi gọi đó là JSX](https://react.dev/learn#writing-markup-with-jsx). JSX không bắt buộc để sử dụng React, nhưng nó giúp mã nguồn dễ đọc hơn, và việc viết nó giống như viết HTML.

## Đóng góp

Mục đích chính của repository này là tiếp tục phát triển lõi React, giúp nó nhanh hơn và dễ sử dụng hơn. Việc phát triển React diễn ra công khai trên GitHub, và chúng tôi cảm ơn cộng đồng đã đóng góp sửa lỗi và cải tiến. Đọc phần dưới đây để biết bạn có thể tham gia cải thiện React như thế nào.

### [Quy tắc Ứng xử](https://code.fb.com/codeofconduct)

Facebook đã áp dụng một Quy tắc Ứng xử mà chúng tôi mong muốn các thành viên dự án tuân theo. Vui lòng đọc [toàn văn quy tắc](https://code.fb.com/codeofconduct) để hiểu những hành động nào sẽ và không được chấp nhận.

### [Hướng dẫn Đóng góp](https://legacy.reactjs.org/docs/how-to-contribute.html)

Đọc [hướng dẫn đóng góp](https://legacy.reactjs.org/docs/how-to-contribute.html) của chúng tôi để tìm hiểu về quy trình phát triển, cách đề xuất sửa lỗi và cải tiến, cũng như cách build và kiểm thử các thay đổi của bạn với React.

### [Vấn đề Dễ cho Người Mới](https://github.com/facebook/react/labels/good%20first%20issue)

Để giúp bạn làm quen và hiểu quy trình đóng góp, chúng tôi có một danh sách [vấn đề dễ cho người mới](https://github.com/facebook/react/labels/good%20first%20issue) chứa các lỗi có phạm vi tương đối nhỏ. Đây là nơi tuyệt vời để bắt đầu.

### Giấy phép

React được [cấp phép theo MIT](./LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---