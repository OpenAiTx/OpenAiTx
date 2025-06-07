# expr_codegen Trình biên dịch biểu thức

## Bối cảnh dự án

Sau khi tôi ra mắt thư viện [polars_ta](https://github.com/wukan1986/polars_ta) mới, tôi đã quay lại suy ngẫm về `expr_codegen` là gì.

> `expr_codegen` về bản chất là một `DSL` (Ngôn ngữ Đặc thù Lĩnh vực - Domain Specific Language). Nhưng nó không định nghĩa cú pháp mới

Nó giải quyết hai vấn đề:

1. `polars_ta` đã có thể dễ dàng viết các biểu thức tính đặc trưng, nhưng khi gặp các biểu thức `kết hợp thời gian và mặt cắt`, sử dụng `expr_codegen` có thể tự động nhóm, tiết kiệm rất nhiều công sức.
2. `expr_codegen` sử dụng phương pháp `Common Subexpression Elimination` (loại bỏ các biểu thức con chung), giảm thiểu tính toán lặp lại, nâng cao hiệu suất.

Ngay cả trong lĩnh vực định lượng, các nghiên cứu viên sơ cấp chỉ giới hạn ở chỉ báo chuỗi thời gian thì chỉ cần dùng `polars_ta`, còn nghiên cứu viên trung/cao cấp sử dụng chỉ báo mặt cắt thì nên dùng `expr_codegen`.

Mặc dù hiện tại dự án này phụ thuộc rất chặt vào `polars_ta`, nhưng cũng có thể dịch sang các thư viện khác như `pandas / cudf.pandas`, chỉ là hiện tại thiếu một thư viện đơn giản hơn.

## Demo trực tuyến

https://exprcodegen.streamlit.app

Người dùng sơ cấp có thể truy cập trực tiếp liên kết này để chuyển đổi biểu thức mà không cần cài đặt phần mềm bổ sung. (Công cụ này được triển khai miễn phí ở nước ngoài nên có thể mở hơi chậm)

Xem ví dụ đầy đủ hơn tại [alpha_examples](https://github.com/wukan1986/alpha_examples)

## Ví dụ sử dụng

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Khu vực chỉnh sửa nhân tố, có thể sử dụng gợi ý thông minh của IDE để chỉnh sửa nhân tố tại đây
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # Trong mẫu đã mặc định import nhiều toán tử từ from polars_ta.prefix, nhưng
    # talib không được import mặc định trong mẫu. Cách viết này có thể import vào mã sinh ra
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # Cũng hỗ trợ import nguyên bản def và class
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Biến bắt đầu bằng dấu gạch dưới chỉ là biến trung gian, sẽ tự động đổi tên, khi xuất cuối cùng sẽ bị loại bỏ
    # 2. Biến bắt đầu bằng dấu gạch dưới có thể sử dụng lặp lại. Khi nhiều nhân tố phức tạp được viết nhiều dòng mà có biến trung gian trùng thì không còn xung đột
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Biến bắt đầu bằng dấu gạch dưới có phép gán vòng lặp. Khi debug có thể nhanh chóng chuyển đổi bằng chú thích
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # In ra mã
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Lưu vào file
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Chỉ thực thi, không lưu mã

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # Lưu vào chuỗi
code.seek(0)
code.read()  # Đọc mã

# TODO Thay bằng dữ liệu phù hợp
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Cấu trúc thư mục

```commandline
│  requirements.txt # Cài đặt phụ thuộc bằng `pip install -r requirements.txt`
├─data
│      prepare_date.py # Chuẩn bị dữ liệu
├─examples
│      demo_express.py # Ví dụ nhanh. Trình diễn cách chuyển biểu thức thành mã
│      demo_exec_pl.py # Trình diễn gọi mã đã chuyển đổi và vẽ đồ thị
│      demo_transformer.py # Trình diễn chuyển đổi biểu thức bên thứ ba thành biểu thức nội bộ
│      output.py # Đầu ra kết quả. Có thể nhập trực tiếp vào dự án khác mà không cần sửa mã
│      show_tree.py # Vẽ biểu đồ cây biểu thức. Dùng để phân tích, so sánh kết quả tối ưu hóa
│      sympy_define.py # Định nghĩa ký hiệu, do quá nhiều nơi dùng lặp lại nên được tách riêng ở đây
├─expr_codegen
│   │  expr.py # Hàm xử lý biểu thức cơ bản
│   │  tool.py # Mã công cụ lõi
│   ├─polars
│   │  │  code.py # Chức năng sinh mã theo cú pháp polars
│   │  │  template.py.j2 # Mẫu `Jinja2`. Dùng để sinh file py tương ứng, thường không cần chỉnh sửa
│   │  │  printer.py # Kế thừa từ `StrPrinter` của `Sympy`, khi thêm hàm mới có thể cần chỉnh file này
```

## Nguyên lý hoạt động

Dự án này phụ thuộc vào dự án `sympy`. Các hàm chính sử dụng như sau:

1. `simplify`: Rút gọn biểu thức phức tạp
2. `cse`: `Common Subexpression Elimination` (loại bỏ các biểu thức con chung)
3. `StrPrinter`: Xuất chuỗi khác nhau tùy theo hàm. Tùy biến mã này có thể hỗ trợ ngôn ngữ hoặc thư viện khác

Do `groupby`, `sort` tốn nhiều thời gian. Nếu phân loại công thức trước, các loại khác nhau dùng `groupby` khác nhau, có thể giảm thời gian tính toán.

1. `ts_xxx(ts_xxx)`: Có thể tính trong cùng một `groupby`
2. `cs_xxx(cs_xxx)`: Có thể tính trong cùng một `groupby`
3. `ts_xxx(cs_xxx)`: Cần tính trong các `groupby` khác nhau
4. `cs_xxx(ts_xxx(cs_xxx))`: Cần tính trong ba `groupby` khác nhau
5. `gp_xxx(aa, )+gp_xxx(bb, )`: Do `aa`, `bb` khác nhau, cần tính trong hai `groupby` khác nhau

Do đó

1. Cần có hàm lấy loại biểu thức hiện tại (`get_current`) và loại của biểu thức con (`get_children`)
2. Nếu loại hiện tại và loại con khác nhau thì có thể tách ra công thức ngắn (`extract`). Biểu thức cùng loại ở các lớp khác nhau có quan hệ trước sau, không thể đặt trong cùng một `groupby`
3. Sử dụng đặc điểm của `cse`, thay thế biểu thức dài bằng biểu thức ngắn đã tách ra trước đó. Sau đó nhập vào đồ thị có hướng không chu trình (`DAG`)
4. Sử dụng luồng của đồ thị có hướng không chu trình để phân lớp. Trong cùng một lớp, `ts`, `cs`, `gp` không phân biệt thứ tự
5. Trong cùng một lớp, nhóm theo `ts`, `cs`, `gp`, sau đó sinh mã (`codegen`)

Thông tin ẩn

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

Tức là

1. Hàm chuỗi thời gian ẩn hai trường `ASSET, DATE`, hàm mặt cắt ẩn một trường `DATE`
2. Hàm nhóm chuyển vào một trường `GROUP`, đồng thời ẩn một trường `DATE`

Hai phương pháp phân loại

1. Phân loại theo tiền tố toán tử (`get_current_by_prefix`), bắt buộc toán tử phải bắt đầu bằng `ts_`, `cs_`, `gp_`
2. Phân loại theo tên đầy đủ toán tử (`get_current_by_name`), không còn giới hạn tên toán tử. Ví dụ `cs_rank` có thể đặt tên là `rank`

## Xử lý Null

`null` sinh ra như thế nào?

1. Do tạm ngừng giao dịch. Đã được lọc bỏ trước khi tính toán, không ảnh hưởng đến các bước sau.
2. Các loại tài sản có phiên giao dịch khác nhau
3. Do tính toán sinh ra. `null` ở hai đầu chuỗi không ảnh hưởng tới kết quả hàm chuỗi thời gian, nhưng nếu xuất hiện ở giữa sẽ ảnh hưởng. Ví dụ: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Ý tưởng rất hay, tổng kết có hai cách thực hiện:

1. Chia `null` thành một nhóm, `not_null` thành nhóm khác. Phải gọi hai lần
2. Chỉ một nhóm, nhưng sắp xếp phức hợp, `null` xếp đầu, `not_null` xếp sau. Chỉ gọi một lần, nhanh hơn một chút

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

Vùng `null` ở đầu theo cách 2 có ảnh hưởng đến kết quả hay không là do toán tử quyết định, đặc biệt khi có nhiều cột đầu vào, vùng `null` có thể có dữ liệu.

1. `over_null='partition_by'`: Chia thành hai vùng
2. `over_null='order_by'`: Chia thành một vùng, `null` xếp đầu
3. `over_null=None`: Không xử lý, gọi trực tiếp, nhanh hơn. Nếu chắc chắn không phát sinh `null` giữa chừng thì nên dùng tham số này

`codegen_exec(over_null='partition_by')` là sử dụng `partition_by` toàn cục. Nhưng khi gặp hàm `null` như `ts_count_nulls` thì phải dùng `over_null=None`, do đó công cụ này còn thêm chức năng chú thích để chỉ định tham số biểu thức từng dòng

1. `# --over_null partition_by`: Dòng đơn `over_null='partition_by'`
2. `# --over_null=order_by`: Dòng đơn `over_null='order_by'`
3. `# --over_null`: Dòng đơn `over_null=None`
4. `# `: Lấy giá trị `over_null` từ tham số truyền vào `codegen_exec`

Lưu ý:

1. Chú thích truyền tham số `# --over_null` chỉ được viết ở cuối dòng biểu thức, không được viết riêng một dòng, nếu không sẽ bị bỏ qua
2. Khi có nhiều `# --over_null # --over_null=order_by`, chỉ lấy cái hợp lệ đầu tiên
3. Chỉ có hiệu lực với hàm `ts` lớp ngoài cùng. Nếu hàm `ts` không ở ngoài cùng, cần tách ra thủ công. Ví dụ:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # Ứng dụng trên cs_rank, không có ý nghĩa
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # Nghĩ là ứng dụng lên ts_rank(ts_mean), nhưng do xuất hiện ts_mean chung nên thực tế là ứng dụng trên ts_rank(_x_0)
   ```

   Cần viết thành

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Do rất dễ nhầm lẫn, cực kỳ khuyến nghị sinh ra `output_file`, kiểm tra mã sinh ra có đúng không.

## Hạn chế của `expr_codegen`

1. `DAG` chỉ có thể thêm cột, không thể xóa cột. Khi thêm cột mà gặp cột cùng tên thì sẽ bị ghi đè
2. Không hỗ trợ `xóa dòng`, nhưng có thể thêm cột đánh dấu xóa, sau đó xóa dòng ở ngoài. Xóa dòng ảnh hưởng đến tất cả cột, không phù hợp với `DAG`
3. Không hỗ trợ `lấy mẫu lại` (resample), lý do tương tự như không hỗ trợ xóa dòng. Cần thực hiện bên ngoài
4. Có thể coi `xóa dòng` và `lấy mẫu lại` là ranh giới, chia thành nhiều `DAG` nối tiếp nhau. Quá phức tạp, khó hiểu nên cuối cùng không thực hiện

## Cú pháp đặc biệt

1. Hỗ trợ biểu thức ba ngôi `C?T:F` (chỉ dùng trong chuỗi), bên dưới sẽ chuyển thành `C or True if( T )else F`, rồi sửa thành `T if C else F`, cuối cùng chuyển thành `if_else(C,T,F)`. Hỗ trợ dùng chung với `if else`
2. `(A<B)*-1`, bên dưới sẽ chuyển thành `int_(A<B)*-1`
3. Để tránh `A==B` bị `sympy` thay bằng `False`, bên dưới sẽ đổi thành `Eq(A,B)`
4. Ý nghĩa của `A^B` phụ thuộc tham số `convert_xor`, `convert_xor=True` thì chuyển thành `Pow(A,B)`, ngược lại là `Xor(A,B)`. Mặc định là `False`, dùng `**` cho lũy thừa
5. Hỗ trợ `A&B&C`, nhưng không hỗ trợ `A==B==C`. Nếu C là boolean, AB là số, có thể thay thủ công thành `(A==B)==C`. Nếu ABC là số, cần thay thành `(A==B)&(B==C)`
6. Không hỗ trợ `A<=B<=C`, cần thay thủ công thành `(A<=B)&(B<=C)`
7. Hỗ trợ `A[0]+B[1]+C[2]`, bên dưới sẽ chuyển thành `A+ts_delay(B,1)+ts_delay(C,2)`
8. Hỗ trợ `~A`, bên dưới sẽ chuyển thành `Not(A)`
9. Các hàm bắt đầu bằng `gp_` sẽ trả về hàm `cs_` tương ứng. Như `gp_func(A,B,C)` sẽ thay thành `cs_func(B,C)`, trong đó `A` dùng trong `groupby([date, A])`
10. Hỗ trợ giải nén tuple `A,B,C=MACD()`, bên dưới sẽ thay thành
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. Hỗ trợ truyền tham số bằng chú thích dòng đơn, như: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. Trong khối mã, các câu lệnh `import`, `def`, `class` sẽ được tự động chèn nguyên bản vào mã sinh ra

## Biến bắt đầu bằng dấu gạch dưới

1. Dữ liệu xuất ra, tất cả các cột bắt đầu bằng `_` sẽ tự động bị xóa cuối cùng. Do đó, các biến cần giữ lại tuyệt đối không được bắt đầu bằng `_`
2. Để giảm tính toán lặp lại, tự động thêm biến trung gian bắt đầu bằng `_x_`, như `_x_0`, `_x_1`... Cuối cùng cũng tự động bị xóa
3. Biểu thức một dòng quá dài, hoặc có tính toán lặp lại, có thể dùng biến trung gian để tách thành nhiều dòng. Nếu biến trung gian bắt đầu bằng `_`, sẽ tự động thêm hậu tố số, tạo thành các biến khác nhau, như `_A` sẽ thay thành `_A_0_`, `_A_1_`... Các trường hợp sử dụng:
    1. Cùng một tên biến, dùng lặp lại. Bản chất là các biến khác nhau
    2. Phép gán vòng lặp, nhưng `DAG` không hỗ trợ chu trình. Biến cùng tên hai bên dấu `=` thực chất là biến khác nhau

## Ví dụ kết quả chuyển đổi

Đoạn mã sau khi chuyển đổi, xem mã chi tiết ở [Polars](examples/output_polars.py)

```python
def func_0_ts__asset(df: pl.DataFrame) -> pl.DataFrame:
    df = df.sort(by=[_DATE_])
    # ========================================
    df = df.with_columns(
        _x_0=1 / ts_delay(OPEN, -1),
        LABEL_CC_1=(-CLOSE + ts_delay(CLOSE, -1)) / CLOSE,
    )
    # ========================================
    df = df.with_columns(
        LABEL_OO_1=_x_0 * ts_delay(OPEN, -2) - 1,
        LABEL_OO_2=_x_0 * ts_delay(OPEN, -3) - 1,
    )
    return df
```

Đoạn mã sau khi chuyển đổi, xem mã chi tiết ở [Pandas](examples/output_pandas.py)

```python
def func_2_cs__date(df: pd.DataFrame) -> pd.DataFrame:
    # expr_4 = cs_rank(x_7)
    df["expr_4"] = (df["x_7"]).rank(pct=True)
    return df


def func_3_ts__asset__date(df: pd.DataFrame) -> pd.DataFrame:
    # expr_5 = -ts_corr(OPEN, CLOSE, 10)
    df["expr_5"] = -(df["OPEN"]).rolling(10).corr(df["CLOSE"])
    # expr_6 = ts_delta(OPEN, 10)
    df["expr_6"] = df["OPEN"].diff(10)
    return df

```

## Trang web tương tác triển khai cục bộ

Chỉ cần chạy `streamlit run streamlit_app.py`

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---