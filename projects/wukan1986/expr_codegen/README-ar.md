# expr_codegen محول التعابير

## خلفية المشروع

بعد إصداري لمكتبة [polars_ta](https://github.com/wukan1986/polars_ta)، عدت للتفكير مجددًا في ماهية `expr_codegen`.

> `expr_codegen` هو في جوهره عبارة عن لغة مجال محددة (DSL)، لكنه لم يعرّف تركيبة نحوية جديدة.

يحل مشكلتين رئيسيتين:

1. مكتبة `polars_ta` تتيح كتابة تعابير لحساب الخصائص بسهولة، لكن عند مواجهة تعابير تخلط بين المؤشرات الزمنية والمقطعية، يمكن لـ `expr_codegen` أن يوفر جهدًا كبيرًا من خلال التجميع التلقائي.
2. يستخدم `expr_codegen` تقنية إزالة التعابير الفرعية المشتركة (Common Subexpression Elimination)، ما يقلل بشكل كبير التكرار في الحساب ويرفع الكفاءة.

حتى في مجال الكَمّ، الباحث المبتدئ الذي يقتصر عمله على مؤشرات زمنية يمكنه الاكتفاء بـ `polars_ta`، أما الباحث المتوسط أو المتقدم الذي يستخدم مؤشرات مقطعية، فيُنصح باستخدام `expr_codegen`.

بالرغم من أن المشروع مرتبط ارتباطًا وثيقًا بمكتبة `polars_ta` حاليًا، إلا أنه قابل للترجمة إلى مكتبات أخرى مثل `pandas / cudf.pandas`، غير أن المكتبة البسيطة المناسبة غير متوفرة حاليًا.

## العرض التوضيحي على الإنترنت

https://exprcodegen.streamlit.app

يمكن للمستخدمين المبتدئين زيارة هذا الرابط مباشرة لتحويل التعابير، دون الحاجة لتثبيت برامج إضافية. (هذه الأداة مُستضافة مجانًا في الخارج، لذلك قد يكون التحميل بطيئًا بعض الشيء)

لمزيد من الأمثلة الكاملة يرجى زيارة [alpha_examples](https://github.com/wukan1986/alpha_examples)

## مثال على الاستخدام

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # منطقة تحرير العوامل، يمكنك استخدام ميزة الإكمال الذكي في بيئة التطوير لتحرير العوامل هنا
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # تم استيراد العديد من العمليات من polars_ta.prefix في القالب بشكل افتراضي،
    # لكن talib لم يُستورد افتراضيًا. يمكن بهذه الطريقة استيراده في الكود المُولد.
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # يدعم أيضًا الاستيراد الأصلي لـ def و class
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. المتغيرات التي تبدأ بشرطة سفلية هي متغيرات وسيطة فقط، سيتم إعادة تسميتها تلقائيًا وحذفها عند الإخراج النهائي
    # 2. يمكن تكرار استخدام المتغيرات التي تبدأ بشرطة سفلية، وعند كتابة عوامل معقدة متعددة الأسطر لن يحدث تعارض في المتغيرات الوسيطة المكررة
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. المتغيرات التي تبدأ بشرطة سفلية لها إعادة إسناد دورية. أثناء التصحيح يمكن التبديل بسرعة عبر التعليقات
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # طباعة الكود
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # حفظ إلى ملف
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # تنفيذ فقط بدون حفظ الكود

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # حفظ إلى نص
code.seek(0)
code.read()  # قراءة الكود

# TODO استبدل ببيانات مناسبة
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # CPU كسول
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # GPU كسول

```

## هيكلية الدليل

```commandline
│  requirements.txt # تثبيت المتطلبات عبر `pip install -r requirements.txt`
├─data
│      prepare_date.py # تجهيز البيانات
├─examples
│      demo_express.py # مثال سريع. يوضح كيفية تحويل التعابير إلى كود
│      demo_exec_pl.py # يوضح استدعاء الكود المحول ورسم النتائج
│      demo_transformer.py # يوضح تحويل تعابير أطراف ثالثة إلى تعابير داخلية
│      output.py # إخراج النتائج. يمكن استيراده مباشرة من مشاريع أخرى دون تعديل الكود
│      show_tree.py # رسم شجرة التعبير. يمكن استخدامه لتحليل نتائج التحسين والمقارنة
│      sympy_define.py # تعريف الرموز، لكثرة تكرار استخدامها تم استخراجها هنا
├─expr_codegen
│   │  expr.py # دوال معالجة التعابير الأساسية
│   │  tool.py # كود الأدوات الأساسية
│   ├─polars
│   │  │  code.py # توليد الكود بناءً على قواعد polars
│   │  │  template.py.j2 # قالب Jinja2. يُستخدم لتوليد ملفات py ولا يحتاج عادة للتعديل
│   │  │  printer.py # يرث من StrPrinter في Sympy، وقد يحتاج للتعديل عند إضافة دوال جديدة
```

## آلية العمل

يعتمد هذا المشروع على مكتبة `sympy`. الدوال الأساسية المستخدمة كالتالي:

1. `simplify`: تبسيط التعبيرات المعقدة
2. `cse`: إزالة التعابير الفرعية المشتركة (Common Subexpression Elimination)
3. `StrPrinter`: طباعة دوال مختلفة كسلاسل نصية. يمكن تخصيص هذا الكود لدعم لغات أو مكتبات أخرى

نظرًا لأن `groupby` و `sort` يستهلكان وقتًا، فإن تصنيف المعادلات مسبقًا واستخدام `groupby` مختلف لكل فئة يقلل من وقت التنفيذ.

1. `ts_xxx(ts_xxx)`: يمكن حسابها ضمن نفس `groupby`
2. `cs_xxx(cs_xxx)`: يمكن حسابها ضمن نفس `groupby`
3. `ts_xxx(cs_xxx)`: يجب حسابها في `groupby` مختلف
4. `cs_xxx(ts_xxx(cs_xxx))`: يجب حسابها في ثلاثة `groupby` مختلفة
5. `gp_xxx(aa, )+gp_xxx(bb, )`: بسبب اختلاف `aa` و `bb`، يجب حسابها في `groupby` مختلفين

وبالتالي:

1. يجب أن تكون هناك دالة للحصول على فئة التعبير الحالي (`get_current`) وفئة التعابير الفرعية (`get_children`)
2. إذا اختلفت الفئة الحالية عن الفئة الفرعية يمكن استخراج معادلة قصيرة (`extract`). تعابير نفس الفئة في طبقات مختلفة لا يمكن وضعها في نفس `groupby`
3. باستخدام تقنية `cse`، تُستبدل التعابير الطويلة بالتعابير القصيرة المستخرجة سابقًا، ثم تُدخل إلى رسم بياني موجه بلا دورات (`DAG`)
4. باستخدام تدفق الرسم البياني الموجه، يتم التقسيم إلى طبقات. نفس الطبقة من `ts` و `cs` و `gp` لا يوجد بينها ترتيب
5. في نفس الطبقة يتم تجميع `ts` و `cs` و `gp` ثم يتم توليد الكود (`codegen`)

معلومات ضمنية:

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

أي:

1. دوال الزمن تخفي الحقلين `ASSET, DATE`، ودوال المقطع تخفي الحقل `DATE`
2. دالة التجميع تُدخل حقل `GROUP` وتخفي حقل `DATE`

طريقتان للتصنيف:

1. التصنيف حسب بادئة الدالة (`get_current_by_prefix`)، أي يجب أن تبدأ الدالة بـ `ts_` أو `cs_` أو `gp_`
2. التصنيف حسب الاسم الكامل للدالة (`get_current_by_name`)، فلا يشترط الاسم. مثلًا، يمكن تسمية `cs_rank` باسم `rank`

## معالجة Null

كيف ينشأ الـ `null`؟

1. التوقف عن التداول. تتم التصفية قبل الحساب فلا يؤثر على العمليات التالية.
2. اختلاف أوقات التداول بين الأدوات المالية المختلفة
3. ينتج عن العمليات الحسابية. إذا ظهر `null` في طرفي السلسلة العددية لا يؤثر على النتائج، لكن إذا ظهر في المنتصف فقد يؤثر، مثل: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

فكرة رائعة، وهناك طريقتان للتنفيذ:

1. تقسيم `null` في مجموعة و`not_null` في مجموعة أخرى. يتطلب تنفيذ دالتين
2. مجموعة واحدة فقط، لكن يتم ترتيب العناصر بحيث تكون `null` في المقدمة و`not_null` في المؤخرة. أسرع قليلًا ويتطلب تنفيذ دالة واحدة

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

في الطريقة الثانية، تأثير منطقة `null` في البداية يتوقف على نوع الدالة، خاصة عند وجود أكثر من عمود للإدخال فقد يكون هناك بيانات في منطقة `null`.

1. `over_null='partition_by'`، التقسيم إلى منطقتين
2. `over_null='order_by'`، التقسيم إلى منطقة واحدة مع ترتيب `null` في المقدمة
3. `over_null=None`، لا معالجة، التنفيذ مباشرة، أسرع. إذا تأكدت من عدم وجود `null` في المنتصف يفضل استخدام هذا الخيار

`codegen_exec(over_null='partition_by')` يستخدم `partition_by` عالميًا. لكن عند دوال مثل `ts_count_nulls` يجب استخدام `over_null=None`، لذلك أضيفت ميزة التعليق لتعيين متغير السطر المفرد.

1. `# --over_null partition_by`، سطر واحد بـ `over_null='partition_by'`
2. `# --over_null=order_by`، سطر واحد بـ `over_null='order_by'`
3. `# --over_null`، سطر واحد بـ `over_null=None`
4. `# `، يأخذ قيمة `over_null` من باراميتر `codegen_exec`

ملاحظات:

1. تعليق تمرير `# --over_null` يجب أن يكون في نهاية السطر فقط، إذا كان في سطر مستقل سيتم تجاهله
2. عند وجود أكثر من `#` مثل `# --over_null # --over_null=order_by` يؤخذ أول تعليق فقط
3. ينطبق فقط على دالة `ts` الخارجية. إذا لم تكن دالة `ts` في الخارج يجب استخراجها يدويًا، مثل:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # تم تطبيقها على cs_rank ولا معنى لذلك
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # يُعتقد أنها تطبق على ts_rank(ts_mean)، لكن مع وجود ts_mean مشترك، تطبق فعليًا على ts_rank(_x_0)
   ```

   يجب كتابتها كالتالي:

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. لتجنب الأخطاء، يُنصح بشدة بتوليد ملف `output_file` للتحقق من صحة الكود المُولد.

## قيود `expr_codegen`

1. الرسم البياني الموجه (DAG) يمكنه فقط إضافة أعمدة ولا يمكنه حذفها. عند إضافة عمود باسم موجود يتم الاستبدال.
2. لا يدعم حذف الصفوف، لكن يمكن إضافة عمود علامة للحذف ومن ثم حذف الصفوف خارجيًا. حذف الصف يؤثر على جميع الأعمدة ولا يتوافق مع DAG
3. لا يدعم إعادة التعيين الزمني (Resampling)، لنفس سبب عدم دعم حذف الصفوف. يجب التنفيذ خارجيًا
4. يمكن اعتبار حذف الصفوف وإعادة التعيين الزمني كفاصل، وتقسيم الكود إلى عدة رسوم بيانية DAG متسلسلة. لكن ذلك معقد وغير سهل الفهم، لذا لم يتم تنفيذه في النهاية

## قواعد نحوية خاصة

1. دعم التعبير الثلاثي `C?T:F` (فقط داخل النصوص)، حيث يتم تحويله إلى `C or True if( T )else F` ثم تصحيحه إلى `T if C else F` وأخيرًا إلى `if_else(C,T,F)`، ويدعم المزج مع `if else`
2. `(A<B)*-1`، يتم تحويله داخليًا إلى `int_(A<B)*-1`
3. لمنع استبدال `A==B` بـ `False` من قبل sympy، يتم تحويله إلى `Eq(A,B)`
4. معنى `A^B` يتوقف على باراميتر `convert_xor`، عند `convert_xor=True` يتم تحويله إلى `Pow(A,B)`، وإلا إلى `Xor(A,B)`. الافتراضي `False`، استخدم `**` للأسس
5. دعم `A&B&C`، ولا يدعم `A==B==C`. إذا كان C منطقيًا وAB عدديًا يمكن استبداله يدويًا بـ `(A==B)==C`، وإذا كانت ABC عددية يجب استبدالها يدويًا بـ `(A==B)&(B==C)`
6. لا يدعم `A<=B<=C`، يجب استبدالها يدويًا بـ `(A<=B)&(B<=C)`
7. دعم `A[0]+B[1]+C[2]`، يتم تحويلها إلى `A+ts_delay(B,1)+ts_delay(C,2)`
8. دعم `~A`، يتم تحويلها داخليًا إلى `Not(A)`
9. جميع الدوال التي تبدأ بـ `gp_` ترجع دوال `cs_` المناظرة. مثل `gp_func(A,B,C)` تُستبدل بـ `cs_func(B,C)` حيث يُستخدم `A` في `groupby([date, A])`
10. دعم تفكيك القيم كما في `A,B,C=MACD()` حيث يتم تحويلها إلى:
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. دعم تمرير المعاملات عبر تعليق السطر الواحد مثل: `# --over_null`، `# --over_null=order_by`، `# --over_null=partition_by`
12. في الكتلة البرمجية، يتم إدراج أوامر `import` و `def` و `class` كما هي في الكود المُولد تلقائيًا

## المتغيرات التي تبدأ بشرطة سفلية

1. جميع الأعمدة التي تبدأ بـ `_` في البيانات الناتجة يتم حذفها تلقائيًا في النهاية، لذا يجب عدم استخدام الشرط السفلية لمتغيرات ترغب بالاحتفاظ بها
2. لتقليل التكرار في الحساب، يتم إضافة متغيرات وسيطة تلقائيًا تبدأ بـ `_x_` مثل `_x_0`، `_x_1` وهكذا. يتم حذفها تلقائيًا في النهاية
3. إذا كان التعبير في سطر واحد طويل جدًا أو هناك تكرار في العمليات، يمكن الاستعانة بمتغيرات وسيطة وتقسيمه لعدة أسطر. إذا بدأت المتغيرات الوسيطة بـ `_` فسيتم إضافة لاحقة رقمية تلقائيًا لتكوين متغيرات مختلفة مثل `_A_0_`, `_A_1_` إلخ. الاستخدام في الحالات التالية:
    1. تكرار اسم المتغير، لكنها في الحقيقة متغيرات مختلفة
    2. الإسناد الدوري، لكن DAG لا يدعم الحلقات. المتغير ذو الاسم نفسه على يمين ويسار علامة `=` هو في الحقيقة متغيران مختلفان

## مثال على نتيجة الترجمة

مقتطف من الكود المُحول، يرجى مراجعة [نسخة Polars](examples/output_polars.py) للحصول على الكود الكامل

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

مقتطف من الكود المُحول، يرجى مراجعة [نسخة Pandas](examples/output_pandas.py) للحصول على الكود الكامل

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

## واجهة ويب تفاعلية للنشر المحلي

يكفي تشغيل `streamlit run streamlit_app.py`


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---