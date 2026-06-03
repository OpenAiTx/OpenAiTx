<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

Một plugin Prettier giúp ngắt dòng tên class dài dựa trên tùy chọn `printWidth`.

![Một ví dụ sử dụng plugin này.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Cài đặt[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Nếu phiên bản `prettier-plugin-classnames` của bạn nhỏ hơn `0.4.0`, bạn cũng cần cài đặt `@prettier/sync`.

## Cấu hình

Ví dụ JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

Ví dụ JS (Module CommonJS):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

Ví dụ JS (ES module):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Ghi đè Markdown/MDX

Plugin này không hỗ trợ Markdown và MDX, nhưng nếu plugin này hỗ trợ một ngôn ngữ bên trong các khối mã (ví dụ: Vue), định dạng không mong muốn có thể xảy ra bên trong các khối mã.

Để ngăn chặn định dạng không mong muốn, bạn có thể sử dụng các cấu hình ghi đè cho Markdown và MDX.

Ví dụ JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"],
  "customFunctions": ["clsx"],
  "overrides": [
    {
      "files": ["*.md", "*.mdx"],
      "options": {
        "plugins": []
      }
    }
  ]
}
```

## Tùy chọn

### Thuộc tính Tùy chỉnh

Danh sách các thuộc tính của tên lớp bao quanh.<br>
Các thuộc tính `class` và `className` luôn được hỗ trợ, ngay cả khi không có tùy chọn nào được chỉ định.

<!-- prettier-ignore -->
Mặc định | Ghi đè CLI&nbsp; | Ghi đè API&nbsp;
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Hàm Tùy chỉnh

Danh sách các hàm của tên lớp bao quanh.<br>
Hàm `classNames` luôn được hỗ trợ, ngay cả khi không có tùy chọn nào được chỉ định.

<!-- prettier-ignore -->
Mặc định | Ghi đè CLI&nbsp; | Ghi đè API&nbsp;
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Vị trí Kết thúc

Lần đầu xuất hiện ở v0.5.0.<br>
`absolute-with-indent` được thêm vào trong v0.6.0.<br>
`absolute-with-indent` đã bị loại bỏ ở v0.8.0, nhưng bạn có thể nhận được đầu ra tương tự với `absolute`.<br>
Giá trị mặc định đã thay đổi từ `relative` sang `absolute` trong v0.8.0.

Đây là tiêu chí để kết thúc tên lớp trên mỗi dòng khi thay thế tên lớp gốc bằng tên lớp nhiều dòng.

- ví dụ về `absolute`:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 dark:bg-neutral-900/50
          border border-zinc-400/30 dark:border-neutral-500/30
          rounded-xl px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

- ví dụ về `relative`:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
       |------------------------------------------------------------|
        className="bg-gray-100/50 dark:bg-neutral-900/50 border
         |------------------------------------------------------------|
          border-zinc-400/30 dark:border-neutral-500/30 rounded-xl
          px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
Mặc định | Ghi đè CLI&nbsp; | Ghi đè API&nbsp;
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Biến đổi cú pháp

Có mặt lần đầu trong v0.7.7.

Nếu có hiện tượng ngắt dòng trong tên lớp viết theo cú pháp không phải biểu thức, nó sẽ được chuyển đổi sang cú pháp biểu thức. Việc chuyển đổi này không hỗ trợ định dạng đảo ngược.

<!-- prettier-ignore -->
Mặc định | Ghi đè CLI&nbsp; | Ghi đè API&nbsp;
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### Độ rộng in tên lớp

Có mặt lần đầu trong v0.10.0.

Chỉ định độ rộng in của tên lớp. Nếu không cung cấp giá trị, giá trị `printWidth` sẽ được sử dụng làm mặc định.

<!-- prettier-ignore -->
Mặc định | Ghi đè CLI&nbsp; | Ghi đè API&nbsp;
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## Liên hệ phiên bản với các plugin cùng loại

Bắt đầu từ `0.6.0`, khi có một bản phát hành nhỏ ở một bên, tôi dự định sẽ phản ánh sự thay đổi đó ở bên còn lại nếu có thể.

![Mối liên hệ phiên bản.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Tương thích với các plugin Prettier khác

Nếu có nhiều hơn một plugin Prettier có thể xử lý đoạn văn bản bạn muốn định dạng, Prettier chỉ sử dụng plugin cuối cùng trong số đó.

Trong trường hợp này, bạn có thể cấu hình như sau bằng cách thêm [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) để áp dụng các plugin đó lần lượt.

Ví dụ JSON:

<!-- prettier-ignore -->
```json
{
  "plugins": [
    "prettier-plugin-tailwindcss",
    "prettier-plugin-classnames",
    "prettier-plugin-merge"
  ]
}
```

## Stargazers over time

[![Stargazers over time](https://starchart.cc/ony3000/prettier-plugin-classnames.svg?variant=adaptive)](https://starchart.cc/ony3000/prettier-plugin-classnames)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---