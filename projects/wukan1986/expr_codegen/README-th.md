# expr_codegen ตัวแปลงนิพจน์

## ภูมิหลังของโครงการ

หลังจากที่ผมได้เปิดตัวไลบรารี [polars_ta](https://github.com/wukan1986/polars_ta) ใหม่ ก็กลับมาทบทวนว่า `expr_codegen` คืออะไร

> `expr_codegen` โดยแท้จริงคือ `DSL` หรือภาษาเฉพาะทาง (Domain Specific Language) แต่ไม่ได้กำหนดไวยากรณ์ใหม่

มันแก้ปัญหา 2 ข้อดังนี้:

1. `polars_ta` สามารถเขียนนิพจน์คำนวณฟีเจอร์ได้อย่างสะดวก แต่เมื่อเจอนิพจน์ที่ "ผสมผสาน Time Series กับ Cross Section" ด้วยการใช้ `expr_codegen` จะสามารถจัดกลุ่มอัตโนมัติช่วยประหยัดงานได้มาก
2. `expr_codegen` ใช้เทคนิค `Common Subexpression Elimination` เพื่อลดการคำนวณซ้ำซ้อนอย่างมากและเพิ่มประสิทธิภาพ

แม้แต่ในวงการ Quant นักวิจัยระดับต้นที่จำกัดแค่ตัวชี้วัด Time Series ใช้แค่ `polars_ta` ก็เพียงพอ ส่วนระดับกลางและสูงที่ใช้ตัวชี้วัด Cross Section แนะนำให้ใช้ `expr_codegen`

แม้โครงการนี้จะพึ่งพา `polars_ta` อย่างมากในตอนนี้ แต่ก็รองรับการแปลไปยังไลบรารีอื่น เช่น `pandas / cudf.pandas` เพียงแต่ตอนนี้ยังขาดไลบรารีที่ง่าย

## สาธิตออนไลน์

https://exprcodegen.streamlit.app

ผู้ใช้ระดับเริ่มต้นสามารถเข้าลิงก์นี้เพื่อแปลงนิพจน์ได้โดยตรง ไม่ต้องติดตั้งซอฟต์แวร์เพิ่มเติม (เครื่องมือนี้ถูกโฮสต์ฟรีในต่างประเทศ อาจช้าเล็กน้อย)

ตัวอย่างที่สมบูรณ์เพิ่มเติมดูที่ [alpha_examples](https://github.com/wukan1986/alpha_examples)

## ตัวอย่างการใช้งาน

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # พื้นที่แก้ไขฟีเจอร์ สามารถใช้ IDE ช่วยแนะนำแก้ไขฟีเจอร์ได้ที่นี่
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # แม่แบบนี้นำเข้าฟังก์ชันจาก polars_ta.prefix เป็นจำนวนมากแล้ว
    # แต่ talib ไม่ได้ถูกนำเข้าโดยอัตโนมัติ สามารถเขียนแบบนี้ให้ถูกนำเข้าในโค้ดที่สร้าง
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # ยังรองรับการนำเข้า def และ class แบบเดิมด้วย
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. ตัวแปรที่ขึ้นต้นด้วยขีดล่างเป็นเพียงตัวแปรกลาง จะถูกเปลี่ยนชื่ออัตโนมัติและถูกลบออกในการแสดงผลสุดท้าย
    # 2. ตัวแปรขึ้นต้นด้วยขีดล่างสามารถใช้ซ้ำได้ หลายฟีเจอร์ที่ซับซ้อนเขียนหลายบรรทัดจะไม่ชนกัน
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. ตัวแปรขึ้นต้นด้วยขีดล่างมีการกำหนดค่าแบบวนรอบ ในการ debug สามารถสลับโดยใช้คอมเมนต์
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # พิมพ์โค้ด
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # บันทึกลงไฟล์
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # แค่รัน ไม่บันทึกโค้ด

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # บันทึกลงสตริง
code.seek(0)
code.read()  # อ่านโค้ด

# TODO แทนที่ด้วยข้อมูลที่เหมาะสม
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## โครงสร้างไดเรกทอรี

```commandline
│  requirements.txt # ติดตั้ง dependencies ด้วย `pip install -r requirements.txt`
├─data
│      prepare_date.py # เตรียมข้อมูล
├─examples
│      demo_express.py # ตัวอย่างเร่งรัด แสดงวิธีแปลงนิพจน์เป็นโค้ด
│      demo_exec_pl.py # ตัวอย่างเรียกใช้งานโค้ดที่แปลงแล้วและวาดกราฟ
│      demo_transformer.py # ตัวอย่างแปลงนิพจน์จากภายนอกเป็นนิพจน์ภายใน
│      output.py # ผลลัพธ์ที่ได้ สามารถนำเข้าโดยตรงจากโปรเจกต์อื่นโดยไม่ต้องแก้ไข
│      show_tree.py # วาดโครงสร้างต้นไม้ของนิพจน์ ใช้เปรียบเทียบผลการปรับปรุง
│      sympy_define.py # นิยาม symbol เนื่องจากใช้ซ้ำหลายที่จึงแยกไว้ที่นี่
├─expr_codegen
│   │  expr.py # ฟังก์ชันพื้นฐานจัดการนิพจน์
│   │  tool.py # โค้ดเครื่องมือหลัก
│   ├─polars
│   │  │  code.py # ฟีเจอร์สร้างโค้ดสำหรับไวยากรณ์ polars
│   │  │  template.py.j2 # แม่แบบ `Jinja2` สำหรับสร้างไฟล์ py ที่เกี่ยวข้อง ปกติไม่ต้องแก้ไข
│   │  │  printer.py # สืบทอดจาก `Sympy` ใน `StrPrinter` เพิ่มฟังก์ชันใหม่อาจต้องแก้ไฟล์นี้
```

## หลักการทำงาน

โปรเจกต์นี้ใช้ไลบรารี `sympy` เป็นหลัก โดยใช้ฟังก์ชันสำคัญดังนี้:

1. `simplify`: ลดรูปนิพจน์ที่ซับซ้อน
2. `cse`: `Common Subexpression Elimination` กำจัดนิพจน์ย่อยที่ซ้ำกัน
3. `StrPrinter`: แสดงสตริงที่ต่างกันตามแต่ละฟังก์ชัน ปรับแต่งโค้ดนี้เพื่อรองรับภาษา/ไลบรารีอื่น

เนื่องจาก `groupby`, `sort` ใช้เวลามาก หากจัดกลุ่มสูตรล่วงหน้า แต่ละกลุ่มใช้ `groupby` ต่างกัน จะช่วยลดเวลาได้

1. `ts_xxx(ts_xxx)`: คำนวณใน `groupby` เดียวกันได้
2. `cs_xxx(cs_xxx)`: คำนวณใน `groupby` เดียวกันได้
3. `ts_xxx(cs_xxx)`: ต้องคำนวณใน `groupby` ต่างกัน
4. `cs_xxx(ts_xxx(cs_xxx))`: ต้องคำนวณใน `groupby` สามกลุ่มต่างกัน
5. `gp_xxx(aa, )+gp_xxx(bb, )`: เพราะ `aa`,`bb` ต่างกัน ต้อง `groupby` สองกลุ่ม

ดังนั้น

1. ต้องมีฟังก์ชันที่ดึงประเภทนิพจน์ปัจจุบัน (`get_current`) และประเภทนิพจน์ย่อย (`get_children`)
2. หากประเภทปัจจุบันกับประเภทย่อยต่างกัน สามารถแยกสูตรสั้นออกมา (`extract`) นิพจน์ประเภทเดียวกันแต่คนละชั้นมีลำดับ ต้องไม่อยู่ใน `groupby` เดียวกัน
3. ใช้คุณสมบัติของ `cse` แทนที่นิพจน์ยาวด้วยนิพจน์สั้นที่แยกออกมา แล้วนำเข้าสู่กราฟเวียนทิศทาง (`DAG`)
4. ใช้การไหลของ DAG เพื่อแบ่งชั้น ชั้นเดียวกันของ `ts`, `cs`, `gp` ไม่ต้องแยกลำดับ
5. แต่ละชั้นจัดกลุ่ม `ts`, `cs`, `gp` แล้วสร้างโค้ด (`codegen`)

ข้อมูลแฝง

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

กล่าวคือ

1. ฟังก์ชัน Time Series ซ่อนฟิลด์ `ASSET, DATE` ฟังก์ชัน Cross Section ซ่อนฟิลด์ `DATE`
2. ฟังก์ชันกลุ่มจะเพิ่มฟิลด์ `GROUP` พร้อมซ่อนฟิลด์ `DATE`

วิธีจำแนกสองแบบ

1. จำแนกตามคำนำหน้าฟังก์ชัน (`get_current_by_prefix`) ต้องขึ้นต้นด้วย `ts_`, `cs_`, `gp_`
2. จำแนกตามชื่อเต็มของฟังก์ชัน (`get_current_by_name`) ไม่ต้องจำกัดชื่อ เช่น `cs_rank` อาจใช้ชื่อ `rank`

## การจัดการ Null

`null` เกิดจากอะไร?

1. การหยุดซื้อขาย ถูกกรองออกก่อนคำนวณ ไม่กระทบการคำนวณถัดไป
2. เวลาซื้อขายแต่ละสินค้าต่างกัน
3. เกิดจากการคำนวณ `null` ที่ปลายชุดข้อมูลไม่กระทบผลลัพธ์ของฟังก์ชัน Time Series แต่ถ้า `null` อยู่กลางชุดข้อมูลจะมีผล เช่น `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

ไอเดียดีมาก สรุปได้ 2 วิธี:

1. แยก `null` เป็นกลุ่มหนึ่ง `not_null` อีกกลุ่ม ต้องเรียกสองรอบ
2. กลุ่มเดียว แต่เรียงลำดับซ้อนกัน `null` อยู่ข้างหน้า `not_null` อยู่ข้างหลัง เรียกครั้งเดียว เร็วกว่านิดหน่อย

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

แบบที่ 2 พื้นที่ `null` ต้นชุดข้อมูลจะมีผลหรือไม่ขึ้นอยู่กับฟังก์ชัน โดยเฉพาะกับ input หลายคอลัมน์

1. `over_null='partition_by'` แยกเป็น 2 โซน
2. `over_null='order_by'` อยู่ในโซนเดียว `null` อยู่ข้างหน้า
3. `over_null=None` ไม่จัดการ `null` เลย เร็วกว่า ถ้ามั่นใจว่าไม่มี `null` กลางชุดข้อมูล แนะนำใช้พารามิเตอร์นี้

`codegen_exec(over_null='partition_by')` จะใช้ `partition_by` ทั่วไป แต่ถ้าเจอฟังก์ชันแบบ `ts_count_nulls` ต้องใช้ `over_null=None` ดังนั้นเครื่องมือนี้จึงเพิ่มคอมเมนต์เพื่อระบุพารามิเตอร์ในแต่ละบรรทัด

1. `# --over_null partition_by` ใช้ `over_null='partition_by'` แค่บรรทัดเดียว
2. `# --over_null=order_by` ใช้ `over_null='order_by'` แค่บรรทัดเดียว
3. `# --over_null` ใช้ `over_null=None` แค่บรรทัดเดียว
4. `#` ใช้ค่าจากพารามิเตอร์ `over_null` ที่ส่งเข้า `codegen_exec`

หมายเหตุ:

1. `# --over_null` ต้องเขียนต่อท้ายบรรทัดนิพจน์เท่านั้น เขียนแยกบรรทัดจะถูกละเลย
2. `# --over_null # --over_null=order_by` ถ้ามีหลาย `#` จะใช้แค่ตัวแรก
3. มีผลแค่กับฟังก์ชัน `ts` ที่อยู่นอกสุด ถ้า `ts` ไม่อยู่นอกสุดต้องแยกเอง เช่น
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # จะไปใช้กับ cs_rank ซึ่งไม่ถูกต้อง
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # คิดว่าจะใช้กับ ts_rank(ts_mean) แต่ถ้ามี ts_mean ซ้ำจริงๆ จะใช้กับ ts_rank(_x_0)
   ```

   ควรเขียนใหม่เป็น

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. เนื่องจากผิดพลาดได้ง่าย ขอแนะนำให้สร้าง `output_file` เพื่อตรวจสอบความถูกต้องของโค้ดที่สร้าง

## ข้อจำกัดของ `expr_codegen`

1. `DAG` เพิ่มคอลัมน์ได้อย่างเดียว ลบไม่ได้ ถ้าเพิ่มแล้วชื่อซ้ำจะทับของเดิม
2. ไม่รองรับการ "ลบแถว" แต่เพิ่มคอลัมน์ระบุแถวที่ต้องลบ แล้วลบข้างนอกแทน การลบแถวกระทบทุกคอลัมน์ ไม่สอดคล้องกับ `DAG`
3. ไม่รองรับ "resample" ด้วยเหตุผลเดียวกับไม่รองรับลบแถว ต้องทำข้างนอก
4. สามารถใช้การลบแถวและ resample เป็นเส้นแบ่ง แบ่งโค้ดออกเป็นหลาย `DAG` เชื่อมกัน แต่จะซับซ้อนและเข้าใจยาก จึงไม่ได้ทำ

## ไวยากรณ์พิเศษ

1. รองรับนิพจน์สามทาง `C?T:F` (ใช้ได้ในสตริงเท่านั้น) ด้านล่างจะถูกแปลงเป็น `C or True if( T )else F` แล้วแก้เป็น `T if C else F` สุดท้ายเป็น `if_else(C,T,F)` รองรับใช้ร่วมกับ if else
2. `(A<B)*-1` จะถูกแปลงเป็น `int_(A<B)*-1`
3. ป้องกัน `A==B` ถูก `sympy` แปลงเป็น `False` จะใช้ `Eq(A,B)`
4. ความหมายของ `A^B` ขึ้นอยู่กับพารามิเตอร์ `convert_xor` ถ้า `convert_xor=True` จะเป็น `Pow(A,B)` ถ้า `False` จะเป็น `Xor(A,B)` ค่า default คือ `False` ใช้ `**` สำหรับยกกำลัง
5. รองรับ `A&B&C` แต่ไม่รองรับ `A==B==C` ถ้า C เป็น boolean, AB เป็นตัวเลข แทนด้วย `(A==B)==C` ถ้า ABC เป็นตัวเลขแทนด้วย `(A==B)&(B==C)`
6. ไม่รองรับ `A<=B<=C` ให้แทนด้วย `(A<=B)&(B<=C)`
7. รองรับ `A[0]+B[1]+C[2]` จะถูกแปลงเป็น `A+ts_delay(B,1)+ts_delay(C,2)`
8. รองรับ `~A` จะถูกแปลงเป็น `Not(A)`
9. ฟังก์ชันที่ขึ้นต้นด้วย `gp_` จะคืนค่าฟังก์ชัน `cs_` ที่ตรงกัน เช่น `gp_func(A,B,C)` จะถูกแทนที่ด้วย `cs_func(B,C)` โดยใช้ `A` ใน `groupby([date, A])`
10. รองรับ tuple unpacking เช่น `A,B,C=MACD()` ด้านล่างจะแปลงเป็น
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. คอมเมนต์แต่ละบรรทัดรองรับการส่งพารามิเตอร์ เช่น `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. ในบล็อกโค้ด คำสั่ง `import`, `def`, `class` จะถูกเพิ่มเข้าโค้ดที่สร้างแบบเดิม

## ตัวแปรที่ขึ้นต้นด้วยขีดล่าง

1. ข้อมูล output ทุกคอลัมน์ที่ขึ้นต้นด้วย `_` จะถูกลบอัตโนมัติ ดังนั้นตัวแปรที่ต้องการเก็บไว้ห้ามขึ้นต้นด้วย `_`
2. เพื่อลดการคำนวณซ้ำ จะเพิ่มตัวแปรกลางอัตโนมัติขึ้นต้นด้วย `_x_` เช่น `_x_0`, `_x_1` เป็นต้น จะถูกลบอัตโนมัติ
3. ถ้านิพจน์ยาวหรือมีการคำนวณซ้ำ สามารถใช้ตัวแปรกลางแยกเป็นหลายบรรทัด ถ้าใช้ `_` ขึ้นต้นจะเติมตัวเลขเป็น `_A_0_`, `_A_1_` ฯลฯ ใช้ในกรณี
    1. ตัวแปรชื่อเดียวกันแต่ใช้ซ้ำ จริงๆ คือคนละตัวแปร
    2. กำหนดค่าแบบวนรอบ แต่ `DAG` ไม่รองรับลูป ตัวแปรชื่อเดียวกันสองฝั่งของ `=` จริงๆ คือคนละตัวแปร

## ตัวอย่างโค้ดที่แปลงแล้ว

ตัวอย่างโค้ดที่แปลงแล้ว ดูโค้ดเต็มที่ [Polars](examples/output_polars.py)

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

ตัวอย่างโค้ดที่แปลงแล้ว ดูโค้ดเต็มที่ [Pandas](examples/output_pandas.py)

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

## เว็บอินเตอร์แอคทีฟแบบติดตั้งเอง

เพียงรัน `streamlit run streamlit_app.py`

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---