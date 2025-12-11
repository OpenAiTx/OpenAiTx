
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Trình Biên Dịch GCC Tương Tác

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!CHÚ Ý]
> Kho lưu trữ gốc từ Andy Balaam ở đây: https://codeberg.org/andybalaam/igcc.
> Trong nhánh này, tôi đã thực hiện một số tái cấu trúc và cố gắng làm cho nó dễ sử dụng hơn.

> [!CẢNH BÁO]
> Dự án này là một thử nghiệm "hacky" nhằm rút ngắn chu trình phản hồi khi làm việc với C/C++ trong một số trường hợp và rõ ràng không được thiết kế cho bất kỳ mục đích nghiêm túc nào.

Interactive GCC (`igcc`) là một vòng lặp đọc-đánh giá-in (REPL) cho C/C++. Nó hoạt động bằng cách thao tác trên một tệp nguồn cơ sở với các lệnh của người dùng, biên dịch nguồn sau mỗi lần sửa đổi, sau đó thực thi tệp nhị phân kết quả và thu thập stdout & stderr của nó.
Hỗ trợ nhập nhiều dòng (khối), vì vậy bạn có thể thêm nhiều dòng một lúc và chỉ gọi trình biên dịch một lần (xem ví dụ bên dưới).

Bạn có thể bao gồm nhiều tệp header khác nhau. Để thuận tiện, một header mặc định được bao gồm: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). Ngoài ra, `using namespace std;` không được bao gồm mặc định, nhưng bạn có thể thêm thủ công (xem ví dụ bên dưới).

Nhiều khía cạnh của `igcc` có thể được cấu hình, xem [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## Bắt đầu sử dụng
Cách dễ nhất để bắt đầu là sử dụng [pipx](https://pipx.pypa.io/stable/):
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
Ngoài ra, bạn cũng có thể sử dụng `uv`:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
Và dành cho nhà phát triển:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```
Các đối số khả dụng:
<!-- MDUP:BEG uv run igcc --help -->

```
usage: igcc [-h] [-I INCLUDE [INCLUDE ...]] [-L LIBDIR [LIBDIR ...]]
            [-l LIB [LIB ...]]

options:
  -h, --help            show this help message and exit
  -I INCLUDE [INCLUDE ...]
                        Add INCLUDE to the list of directories to be searched
                        for header files.
  -L LIBDIR [LIBDIR ...]
                        Add LIBDIR to the list of directories to be searched
                        for library files.
  -l LIB [LIB ...]      Search the library LIB when linking.
```
<!-- MDUP:END -->

Mã sẽ được biên dịch bằng GCC (`g++`) và kết quả (nếu có) sẽ được hiển thị.
Gõ `.h` để được trợ giúp:
```
$ igcc
[1]> .h
.h  Show this help message
.e  Show the last compile errors/warnings
.l  List the code you have entered
.L  List the whole program as given to the compiler
.r  Redo undone command
.u  Undo previous command
.q  Quit
```

## Ví dụ
```
$ igcc
[1]> int a = 5;
[2]> a += 2;
[3]> using namespace std;
[4]> cout << a << endl;
7

[5]> int b = 17;
[6]> a *= b;
[7]> cout << a << ", " << b << endl;
119, 17

[8]> .L
#include "boilerplate.h"
using namespace std;

int main(void) {
    int a = 5;
    a += 2;
    cout << a << endl;
    int b = 17;
    a *= b;
    cout << a << ", " << b << endl;

    return 0;
}
```

**Nhập nhiều dòng** được hỗ trợ (kiểm tra `multiline_marker` trong cấu hình). Lợi ích là tránh việc gọi trình biên dịch nhiều lần.
```
$ igcc
[1]> .m
... for (int i = 0; i < 10; i++) {
...   std::cout << i << " ";
... }
... std::cout << "\n";
... .m
0 1 2 3 4 5 6 7 8 9
```

Bạn có thể bao gồm các tiêu đề:
```
$ igcc
[1]> #include <vector>
[2]> std::vector<int> xs{1,2,3};
[3]> xs.push_back(17);
[4]> .m
... for (auto x : xs) {
...   std::cout << x << " ";
... }
... .m
1 2 3 17
```
Có thể liên kết các thư viện:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
Bạn cũng có thể **hoàn tác** các lệnh:

```
$ igcc
[1]> int x = 2
 Compile error - type .e to see it

[2]> .e
<stdin>: In function ‘int main()’:
<stdin>:7:5: error: expected ‘,’ or ‘;’ before ‘return’
<stdin>:5:9: warning: unused variable ‘x’ [-Wunused-variable]

[2]> .u
Undone `int x = 2`
[1]> int x = 2;
[2]> .L
#include "boilerplate.h"


int main(void) {
    int x = 2;

    return 0;
}
```

... hoặc **làm lại** các lệnh đã hoàn tác trước đó:
```
$ igcc
[1]> int x = 2;
[2]> std::cout << x;
2
[3]> .u
Undone `std::cout << x;`
[2]> .L
#include "boilerplate.h"


int main(void) {
    int x = 2;

    return 0;
}
[2]> .r
Redone `std::cout << x;`
2
[3]> .L
#include "boilerplate.h"


int main(void) {
    int x = 2;
    std::cout << x;

    return 0;
}
```

## Công việc tương lai
Xem https://github.com/alexandru-dinu/igcc/issues

## Các dự án tương tự
- https://github.com/BenBrock/reple: REPL dựa trên “Replay” cho các ngôn ngữ biên dịch
- https://github.com/root-project/cling: Trình thông dịch C++ cling


## Ghi nhận
- [Trang chủ IGCC](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [Trang IGCC trên Sourceforge](http://sourceforge.net/projects/igcc/)
- [Trang chủ của Andy Balaam](http://www.artificialworlds.net)
- [Blog của Andy Balaam](http://www.artificialworlds.net/blog)
- Có thể liên hệ với Andy Balaam qua axis3x3 tại users chấm sourceforge chấm net
- IGCC Bản quyền (C) 2009 Andy Balaam
- IGCC là Phần mềm Tự do phát hành theo các điều khoản của Giấy phép Công cộng GNU phiên bản 3
- IGCC được cung cấp KHÔNG CÓ BẢO HÀNH


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---