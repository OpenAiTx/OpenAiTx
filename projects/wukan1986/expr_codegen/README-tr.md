# expr_codegen İfade Derleyicisi

## Proje Arka Planı

Kendi geliştirdiğim [polars_ta](https://github.com/wukan1986/polars_ta) kütüphanesini yayınladıktan sonra, tekrar dönüp `expr_codegen`’in ne olduğunu düşündüm.

> `expr_codegen` özünde bir `DSL`’dir (Domain Specific Language - Alan Özel Dili). Ancak yeni bir sözdizimi tanımlamaz.

İki sorunu çözer:

1. `polars_ta` ile özellik hesaplama ifadeleri kolayca yazılabiliyor, fakat zaman serisi ile kesitsel ifadelerin karışık kullanıldığı durumlarda, `expr_codegen` ile otomatik gruplama büyük ölçüde iş yükünü azaltıyor.
2. `expr_codegen`, `Common Subexpression Elimination` (Ortak Alt İfade Eleme) yöntemini kullanarak tekrarlı hesaplamaları büyük oranda azaltır ve verimliliği artırır.

Kuant alanında, başlangıç seviyesindeki araştırmacılar zaman serisi göstergelerine odaklanırsa sadece `polars_ta` yeterlidir; orta ve ileri düzeydeki araştırmacılar ise kesitsel göstergeler kullanır, onlara `expr_codegen` önerilir.

Şu anda proje `polars_ta` ile çok sıkı bağlı olsa da, başka kütüphanelere de çevrilebilir (ör. `pandas / cudf.pandas`), fakat şimdilik kolay bir kütüphane eksikliği var.

## Online Demo

https://exprcodegen.streamlit.app

Başlangıç düzeyindeki kullanıcılar bu bağlantıya doğrudan gidip ifade derlemesi yapabilir, ek yazılım yüklemeye gerek yoktur. (Bu araç yurtdışında ücretsiz sunulmakta, açılması biraz yavaş olabilir.)

Daha kapsamlı örnekler için [alpha_examples](https://github.com/wukan1986/alpha_examples) adresine bakabilirsiniz.

## Kullanım Örneği

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Faktör düzenleme alanı, burada IDE'nin otomatik tamamlama özellikleriyle faktörleri düzenleyebilirsiniz
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # Şablonda, from polars_ta.prefix altında birçok operatör varsayılan olarak import edilmiştir,
    # ancak talib şablonda varsayılan olarak import edilmemiştir. Bu şekilde, oluşturulan kodda import işlemi yapılabilir
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # Ayrıca def ve class ifadeleri de aynen içe aktarılır
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Alt çizgiyle başlayan değişkenler sadece ara değişkendir, otomatik olarak yeniden adlandırılır ve çıktıda çıkarılır
    # 2. Alt çizgiyle başlayan değişkenler tekrar tekrar kullanılabilir. Birden çok karmaşık faktörde, satır satır yazarken ara değişken çakışmaz
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Alt çizgiyle başlayan değişkenlerde döngüsel atama vardır. Hata ayıklamada hızlıca yorum satırıyla değiştirilebilir
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Kodu yazdır
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Dosyaya kaydet
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Sadece çalıştır, kodu kaydetme

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # String’e kaydet
code.seek(0)
code.read()  # Kodu oku

# TODO Uygun veriyle değiştirin
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Dizin Yapısı

```commandline
│  requirements.txt # `pip install -r requirements.txt` ile bağımlılıkları yükler
├─data
│      prepare_date.py # Veri hazırlama
├─examples
│      demo_express.py # Hızlı örnek. İfadeyi koda nasıl dönüştüreceğinizi gösterir
│      demo_exec_pl.py # Dönüştürülen kodun çağrılması ve çizim örneği
│      demo_transformer.py # Üçüncü parti ifadeleri iç formata çevirme örneği
│      output.py # Sonuç çıktısı. Kodu değiştirmeden diğer projelere doğrudan import edilebilir
│      show_tree.py # İfade ağaç şeması çizer. Optimizasyon sonuçlarını analiz/karşılaştırma için kullanılabilir
│      sympy_define.py # Sembol tanımları, çok fazla yerde tekrarlandığı için buraya çıkarılmıştır
├─expr_codegen
│   │  expr.py # İfade işleme temel fonksiyonları
│   │  tool.py # Çekirdek araç kodları
│   ├─polars
│   │  │  code.py # polars sözdizimine yönelik kod üretimi
│   │  │  template.py.j2 # `Jinja2` şablonu. İlgili py dosyasını üretmek için kullanılır, genelde değiştirilmez
│   │  │  printer.py # `Sympy`’deki `StrPrinter`’dan türetilmiştir, yeni fonksiyon eklerken bu dosyada değişiklik yapılabilir
```

## Çalışma Prensibi

Bu proje `sympy` projesine dayanmaktadır. Kullanılan başlıca fonksiyonlar:

1. `simplify`: Karmaşık ifadeleri sadeleştirir
2. `cse`: `Common Subexpression Elimination` (Ortak Alt İfade Eleme)
3. `StrPrinter`: Farklı fonksiyonlara göre farklı çıktılar üretir. Özelleştirerek farklı dilleri veya kütüphaneleri destekleyebilirsiniz

Çünkü `groupby` ve `sort` işlemleri zaman alır. Eğer formülleri önceden sınıflandırır, her sınıfa farklı `groupby` uygularsanız, hesaplama süresini azaltabilirsiniz.

1. `ts_xxx(ts_xxx)`: Aynı `groupby` içinde hesaplanabilir
2. `cs_xxx(cs_xxx)`: Aynı `groupby` içinde hesaplanabilir
3. `ts_xxx(cs_xxx)`: Farklı `groupby`’larda hesaplanmalı
4. `cs_xxx(ts_xxx(cs_xxx))`: Üç farklı `groupby`’da hesaplanmalı
5. `gp_xxx(aa, )+gp_xxx(bb, )`: `aa` ve `bb` farklı olduğundan iki farklı `groupby`’da hesaplanmalı

Bunun için:

1. İfadelerin mevcut kategorisini (`get_current`) ve alt ifadelerin kategorisini (`get_children`) alabilen bir fonksiyona ihtiyaç var
2. Mevcut kategori ile alt kategori farklıysa kısa formül çıkarılabilir (`extract`). Farklı katmanlardaki aynı kategori ifadeler arasında sıra vardır, aynı `groupby`’da olamazlar
3. `cse` özelliğini kullanarak, uzun ifadeleri önceden çıkarılan kısa ifadelerle değiştirin. Sonra bu, yönsüz çevrimsiz grafa (`DAG`) girer
4. Yönsüz çevrimsiz graf üzerinden katmanlama yapılır. Aynı katmandaki `ts`, `cs`, `gp` sırası önemli değildir
5. Aynı katmanda `ts`, `cs`, `gp` gruplandırılır ve kod üretimi (`codegen`) yapılır

Gizli bilgiler:

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

Yani

1. Zaman serisi fonksiyonları gizlice iki alan (`ASSET`, `DATE`) saklar; kesitsel fonksiyonlar bir alan (`DATE`) saklar
2. Grup fonksiyonları bir alan (`GROUP`) ekler, aynı zamanda bir alan (`DATE`) gizler

İki sınıflandırma yöntemi:

1. Operatör önekiyle sınıflandırma (`get_current_by_prefix`), operatör ismi `ts_`, `cs_`, `gp_` ile başlamalı
2. Operatör tam adıyla sınıflandırma (`get_current_by_name`), isimde kısıtlama yok. Örneğin, `cs_rank` yerine `rank` denebilir

## Null İşleme

`null` nasıl oluşur?

1. İşlem durdurma nedeniyle. Hesaplama öncesinde filtrelenir, sonrasını etkilemez.
2. Farklı enstrümanların farklı işlem saatleri
3. Hesaplamada oluşur. `null` dizinin başında veya sonunda ise zaman serisi operatörlerini etkilemez, ortada oluşursa etkiler. Örneğin: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Harika bir fikir, özetle iki uygulama yöntemi var:

1. `null` bir grup, `not_null` başka bir grup olur. İki kez çağrılır
2. Tek grup olur, karma sıralamada `null` öne, `not_null` sona gelir. Tek çağrı, biraz daha hızlı

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

2. yöntemde baştaki `null` bölgesi, sonucu operatöre göre etkiler, özellikle çoklu sütun girişinde `null` bölgesinde veri olabilir

1. `over_null='partition_by'`: İki bölgeye ayrılır
2. `over_null='order_by'`: Tek bölge, `null` önde
3. `over_null=None`: Hiç işlem yapılmaz, doğrudan çağrılır, daha hızlı. Ortada `null` oluşmayacağından eminseniz bu parametreyi kullanın

`codegen_exec(over_null='partition_by')` ile küresel olarak `partition_by` kullanılır. Ancak `ts_count_nulls` gibi `null` fonksiyonlarda `over_null=None` gerekir, bu nedenle araçta satır düzeyinde parametre belirten yorum satırı özelliği eklenmiştir.

1. `# --over_null partition_by`: Satırda `over_null='partition_by'`
2. `# --over_null=order_by`: Satırda `over_null='order_by'`
3. `# --over_null`: Satırda `over_null=None`
4. `# `: `codegen_exec`’ten gelen `over_null` parametresini alır

Notlar:

1. `# --over_null` parametre yorumları sadece satır sonuna yazılır, tek satır olarak yazılırsa dikkate alınmaz
2. `# --over_null # --over_null=order_by` gibi çoklu `#` olursa, ilk geçerli olan alınır
3. Sadece en dıştaki `ts` fonksiyonunda geçerlidir. Eğer `ts` fonksiyonu dışta değilse elle çıkarmak gerekir. Örneğin:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # cs_rank’ta uygulanır, anlamı yok
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # ts_rank(ts_mean)’de uygulanacağı sanılır, fakat ortak ts_mean oluşunca aslında ts_rank(_x_0)’da uygulanır
   ```

   Şöyle yazılmalı:

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Hata yapma riski yüksek olduğundan, mutlaka `output_file` oluşturup üretilen kodun doğruluğunu kontrol etmeniz önerilir.

## `expr_codegen` Sınırlamaları

1. `DAG` sadece sütun ekleyebilir, silemez. Aynı isimli sütun eklenirse üzerine yazar
2. Satır silme desteklenmez, ancak silme işaretli sütun eklenip dışarıda satır silme yapılabilir. Satır silme tüm sütunları etkiler, `DAG` ilkesini bozuyor
3. Yeniden örnekleme desteklenmez, sebep satır silmeyle aynıdır. Dışarıda yapılmalıdır
4. Satır silme ve yeniden örnekleme birer ayraç olarak düşünülebilir, büyük kod blokları birden fazla `DAG`a bölünebilir. Karmaşık ve anlaşılması zor olduğundan uygulanmadı

## Özel Sözdizimi

1. `C?T:F` üçlü ifadesi desteklenir (sadece string içinde), altyapıda önce `C or True if( T )else F` olarak çevrilir, sonra `T if C else F` ve son olarak `if_else(C,T,F)` olur. `if else` ile birlikte kullanılabilir
2. `(A<B)*-1`, altyapıda `int_(A<B)*-1`’e dönüştürülür
3. `A==B` ifadesinin `sympy` tarafından `False`'a çevrilmesini önlemek için altyapıda `Eq(A,B)`’ye dönüştürülür
4. `A^B` anlamı `convert_xor` parametresine bağlıdır, `convert_xor=True` ise `Pow(A,B)`’ye, değilse `Xor(A,B)`’ye çevrilir. Varsayılan `False`, üs alma için `**` kullanılır
5. `A&B&C` desteklenir, ancak `A==B==C` desteklenmez. C boolean, A ve B sayısal ise elle `(A==B)==C` ile değiştirilebilir. Üçü de sayısal ise `(A==B)&(B==C)` olarak değiştirilmeli
6. `A<=B<=C` desteklenmez, elle `(A<=B)&(B<=C)` ile değiştirilmeli
7. `A[0]+B[1]+C[2]` desteklenir, altyapıda `A+ts_delay(B,1)+ts_delay(C,2)`’ye çevrilir
8. `~A`, altyapıda `Not(A)`’ya çevrilir
9. `gp_` ile başlayan fonksiyonlar ilgili `cs_` fonksiyonunu döndürür. Örn: `gp_func(A,B,C)` → `cs_func(B,C)`, burada `A`, `groupby([date, A])`'de kullanılır
10. `A,B,C=MACD()` tuple açma desteklenir, altyapıda şöyle çevrilir:
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. Tek satırlık yorumlarda parametre girişi desteklenir: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. Kod bloklarında `import`, `def`, `class` gibi yapılar otomatik olarak üretilen koda aynen eklenir

## Alt Çizgiyle Başlayan Değişkenler

1. Çıktı verisinde, `_` ile başlayan tüm sütunlar otomatik olarak silinir. Kalıcı olması gereken değişkenler `_` ile başlamamalı
2. Tekrarlı hesaplamaları azaltmak için `_x_` ile başlayan ara değişkenler otomatik eklenir: `_x_0`, `_x_1` gibi. Sonunda otomatik silinirler
3. Satırda ifade çok uzunsa veya tekrarlı hesaplama varsa, ara değişkenlerle satır çoklanabilir. Ara değişken adı `_` ile başlarsa, sonuna otomatik rakam eklenir: `_A` → `_A_0_`, `_A_1_` vb. Kullanım durumu:
    1. Aynı değişken adı tekrar kullanılır, aslında farklı değişkenlerdir
    2. Döngüsel atama yapılır, fakat `DAG` döngüye izin vermez. Eşitliğin iki yanında aynı isim olsa da aslında farklı değişkenlerdir

## Derleme Sonucu Örneği

Derlenen kod örneği, ayrıntılar için [Polars versiyonu](examples/output_polars.py) bakınız

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

Derlenen kod örneği, ayrıntılar için [Pandas versiyonu](examples/output_pandas.py) bakınız

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

## Yerel Dağıtımda Etkileşimli Web

Sadece `streamlit run streamlit_app.py` komutunu çalıştırmanız yeterlidir.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---