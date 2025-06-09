Đây là Python phiên bản 3.15.0 alpha 0
=======================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: Trạng thái build CPython trên GitHub Actions
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: Trạng thái build CPython trên Azure DevOps
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Trò chuyện trên Python Discourse
   :target: https://discuss.python.org/


Bản quyền © 2001 Python Software Foundation.  Đã đăng ký bản quyền.

Xem cuối tệp này để biết thêm thông tin về bản quyền và giấy phép.

.. contents::

Thông tin chung
---------------

- Website: https://www.python.org
- Mã nguồn: https://github.com/python/cpython
- Trình theo dõi vấn đề: https://github.com/python/cpython/issues
- Tài liệu: https://docs.python.org
- Hướng dẫn dành cho nhà phát triển: https://devguide.python.org/

Đóng góp cho CPython
--------------------

Để biết hướng dẫn đầy đủ hơn về việc đóng góp vào phát triển CPython,
xem `Developer Guide`_.

.. _Developer Guide: https://devguide.python.org/

Sử dụng Python
--------------

Các bộ cài đặt Python, cùng thông tin về việc sử dụng Python, có sẵn tại
`python.org`_.

.. _python.org: https://www.python.org/

Hướng dẫn biên dịch
-------------------

Trên Unix, Linux, BSD, macOS, và Cygwin::

    ./configure
    make
    make test
    sudo make install

Lệnh này sẽ cài đặt Python dưới tên ``python3``.

Bạn có thể truyền nhiều tùy chọn cho script configure; chạy ``./configure --help``
để biết thêm chi tiết. Trên hệ thống file không phân biệt hoa thường của macOS và trên Cygwin,
tệp thực thi được gọi là ``python.exe``; ở nơi khác chỉ là ``python``.

Việc xây dựng một cài đặt Python hoàn chỉnh yêu cầu sử dụng nhiều thư viện
bên thứ ba bổ sung, tùy thuộc vào nền tảng build và các tùy chọn configure của bạn.
Không phải tất cả các module thư viện chuẩn đều có thể build hoặc sử dụng trên mọi nền tảng.
Tham khảo mục
`Install dependencies <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
trong `Developer Guide`_ để biết thông tin chi tiết mới nhất về
các phụ thuộc cho nhiều bản phân phối Linux và macOS.

Trên macOS, có các tùy chọn configure và build bổ sung liên quan
đến framework macOS và build universal. Tham khảo `Mac/README.rst
<https://github.com/python/cpython/blob/main/Mac/README.rst>`_.

Trên Windows, xem `PCbuild/readme.txt
<https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_.

Để build bộ cài đặt Windows, xem `Tools/msi/README.txt
<https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_.

Nếu bạn muốn, bạn có thể tạo một thư mục con và chạy configure từ đó.
Ví dụ::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(Điều này sẽ thất bại nếu bạn *cũng* đã build ở thư mục cấp cao nhất. Bạn nên thực hiện
``make clean`` ở cấp cao nhất trước.)

Để có một bản build tối ưu hóa của Python, chạy ``configure --enable-optimizations``
trước khi chạy ``make``. Lệnh này sẽ thiết lập các mục tiêu mặc định của make để bật
Profile Guided Optimization (PGO) và có thể dùng để tự động bật Link Time
Optimization (LTO) trên một số nền tảng. Xem thêm chi tiết ở các mục bên dưới.

Tối ưu hóa dựa trên hồ sơ chạy (Profile Guided Optimization)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO tận dụng lợi thế của các phiên bản GCC hoặc Clang mới. Nếu sử dụng,
hoặc qua ``configure --enable-optimizations`` hoặc bằng cách tự chạy
``make profile-opt`` bất kể các cờ configure, quá trình build tối ưu hóa
sẽ thực hiện các bước sau:

Toàn bộ thư mục Python sẽ được dọn sạch các tệp tạm thời có thể đã
tạo ra từ lần biên dịch trước.

Một phiên bản trình thông dịch có nhúng mã đo đạc sẽ được build, sử dụng các cờ biên dịch
phù hợp cho từng kiểu. Lưu ý rằng đây chỉ là bước trung gian. Tệp nhị phân tạo ra ở bước này
không thích hợp cho các khối lượng công việc thực tế vì nó chứa các chỉ thị đo đạc hồ sơ.

Sau khi trình thông dịch có nhúng đo đạc được build, Makefile sẽ chạy một tập hợp
công việc đào tạo. Điều này cần thiết để đo đạc quá trình thực thi của trình thông dịch.
Lưu ý rằng mọi đầu ra, cả stdout và stderr, xuất hiện ở bước này đều bị ẩn đi.

Bước cuối cùng là build trình thông dịch thực tế, sử dụng thông tin thu thập
từ bản có nhúng đo đạc. Kết quả cuối cùng sẽ là một tệp nhị phân Python
đã được tối ưu hóa; phù hợp để phân phối hoặc cài đặt cho sản xuất.


Tối ưu hóa tại thời gian liên kết (Link Time Optimization)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Bật qua cờ ``--with-lto`` của configure. LTO tận dụng khả năng
của các bộ công cụ biên dịch hiện đại để tối ưu hóa vượt qua ranh giới tệp ``.o``
khi build tệp thực thi cuối cùng hoặc thư viện chia sẻ, nhằm tăng hiệu suất.


Có gì mới
---------

Chúng tôi có một cái nhìn tổng quan về những thay đổi trong tài liệu `Có gì mới trong Python
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_. Để xem nhật ký thay đổi chi tiết hơn,
hãy đọc `Misc/NEWS
<https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_, nhưng để biết đầy đủ tất cả thay đổi
chỉ có thể xem từ `lịch sử commit
<https://github.com/python/cpython/commits/main>`_.

Nếu bạn muốn cài đặt nhiều phiên bản Python, xem mục dưới đây
có tiêu đề "Cài đặt nhiều phiên bản".


Tài liệu
--------

`Tài liệu cho Python 3.15 <https://docs.python.org/3.15/>`_ có sẵn trực tuyến,
được cập nhật hàng ngày.

Bạn cũng có thể tải về ở nhiều định dạng để truy cập nhanh hơn. Tài liệu
có thể tải về dưới định dạng HTML, PDF, và reStructuredText; định dạng cuối này
chủ yếu dành cho tác giả tài liệu, dịch giả, và những người có yêu cầu định dạng đặc biệt.

Để biết thông tin về việc xây dựng tài liệu của Python, tham khảo `Doc/README.rst
<https://github.com/python/cpython/blob/main/Doc/README.rst>`_.


Kiểm thử
--------

Để kiểm thử trình thông dịch, gõ ``make test`` ở thư mục cấp cao nhất. Bộ kiểm thử
sẽ cho ra một số kết quả. Bạn thường có thể bỏ qua các thông báo về kiểm thử bị bỏ qua
do các tính năng tùy chọn không thể import. Nếu xuất hiện thông báo về kiểm thử thất bại
hoặc xuất hiện traceback hay core dump, có điều gì đó sai.

Theo mặc định, các kiểm thử sẽ được ngăn không cho sử dụng quá nhiều tài nguyên như dung lượng đĩa hoặc bộ nhớ.
Để bật các kiểm thử này, chạy ``make buildbottest``.

Nếu có kiểm thử nào thất bại, bạn có thể chạy lại kiểm thử đó ở chế độ verbose. Ví dụ,
nếu ``test_os`` và ``test_gdb`` bị lỗi, bạn có thể chạy::

    make test TESTOPTS="-v test_os test_gdb"

Nếu lỗi vẫn còn và có vẻ là vấn đề của Python chứ không phải môi trường của bạn, bạn có thể `báo cáo lỗi
<https://github.com/python/cpython/issues>`_ và đính kèm đầu ra liên quan từ lệnh đó để minh họa vấn đề.

Xem `Chạy & Viết kiểm thử <https://devguide.python.org/testing/run-write-tests.html>`_
để biết thêm về cách chạy kiểm thử.

Cài đặt nhiều phiên bản
----------------------

Trên hệ thống Unix và Mac nếu bạn định cài đặt nhiều phiên bản Python
sử dụng cùng một tiền tố cài đặt (đối số ``--prefix`` cho script configure)
bạn phải cẩn thận để trình thực thi python chính của bạn không bị
ghi đè bởi việc cài đặt một phiên bản khác. Tất cả các tệp và
thư mục được cài đặt bằng ``make altinstall`` đều chứa số hiệu phiên bản chính và phụ
và do đó có thể cùng tồn tại. ``make install`` cũng tạo ra
``${prefix}/bin/python3`` trỏ đến ``${prefix}/bin/python3.X``. Nếu bạn
định cài đặt nhiều phiên bản dùng cùng một tiền tố, bạn phải quyết định phiên bản nào
(nếu có) là phiên bản "chính" của bạn. Hãy cài đặt phiên bản đó bằng
``make install``.  Cài đặt tất cả các phiên bản khác bằng cách sử dụng ``make altinstall``.

Ví dụ, nếu bạn muốn cài đặt Python 2.7, 3.6 và 3.15 với 3.15 là phiên bản chính,
bạn sẽ thực hiện ``make install`` trong thư mục build của 3.15
và ``make altinstall`` trong các thư mục còn lại.


Lịch Phát Hành
--------------

Xem `PEP 790 <https://peps.python.org/pep-0790/>`__ để biết chi tiết phát hành Python 3.15.


Thông Tin Bản Quyền và Giấy Phép
---------------------------------


Bản quyền © 2001 Python Software Foundation.  Đã đăng ký bản quyền.

Bản quyền © 2000 BeOpen.com.  Đã đăng ký bản quyền.

Bản quyền © 1995-2001 Corporation for National Research Initiatives.  Đã đăng ký bản quyền.

Bản quyền © 1991-1995 Stichting Mathematisch Centrum.  Đã đăng ký bản quyền.

Xem `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ để biết
thông tin về lịch sử phần mềm này, các điều khoản & điều kiện sử dụng, và
TUYÊN BỐ MIỄN TRỪ MỌI BẢO ĐẢM.

Bản phân phối Python này *không* chứa mã nguồn thuộc Giấy phép Công cộng GNU (GPL),
vì vậy nó có thể được sử dụng trong các dự án độc quyền.  Có các giao diện với một số mã nguồn GNU
nhưng hoàn toàn là tùy chọn.

Tất cả các nhãn hiệu được tham chiếu ở đây đều là tài sản của các chủ sở hữu tương ứng.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---