# expr_codegen Penerjemah Ekspresi

## Latar Belakang Proyek

Setelah saya merilis [polars_ta](https://github.com/wukan1986/polars_ta), saya kembali merefleksikan apa itu `expr_codegen`.

> `expr_codegen` pada dasarnya adalah `DSL`, Bahasa Spesifik Domain (Domain Specific Language). Namun, ia tidak mendefinisikan sintaks baru.

Ia menyelesaikan dua masalah:

1. `polars_ta` sudah sangat memudahkan penulisan ekspresi perhitungan fitur, namun ketika menemui ekspresi yang `mencampur time-series dan cross-section`, penggunaan `expr_codegen` dapat secara otomatis mengelompokkan sehingga sangat menghemat pekerjaan.
2. `expr_codegen` memanfaatkan `Common Subexpression Elimination` (penghilangan sub-ekspresi umum), secara signifikan mengurangi perhitungan berulang dan meningkatkan efisiensi.

Bahkan di bidang kuantitatif, peneliti pemula yang terbatas pada indikator time-series hanya menggunakan `polars_ta` saja sudah cukup, sedangkan peneliti menengah dan mahir yang menggunakan indikator cross-section direkomendasikan untuk memakai `expr_codegen`.

Walaupun saat ini proyek ini sangat erat kaitannya dengan `polars_ta`, namun juga mendukung translasi ke library lain seperti `pandas / cudf.pandas`, hanya saja saat ini belum ada library sederhana yang memadai.

## Demo Online

https://exprcodegen.streamlit.app

Pengguna pemula bisa langsung mengunjungi tautan ini untuk penerjemahan ekspresi tanpa perlu menginstal perangkat lunak tambahan. (Alat ini dihosting gratis di luar negeri, mungkin agak lambat saat dibuka)

Contoh lebih lengkap dapat diakses di [alpha_examples](https://github.com/wukan1986/alpha_examples)

## Contoh Penggunaan

```python
import sys
from io import StringIO

import polars as pl

from expr_codegen import codegen_exec


def _code_block_1():
    # Area edit faktor, dapat menggunakan fitur auto-complete IDE untuk mengedit faktor di sini
    LOG_MC_ZS = cs_mad_zscore(log1p(market_cap))


def _code_block_2():
    # Dalam template sudah secara default mengimpor banyak operator dari from polars_ta.prefix, namun
    # talib tidak diimpor secara default di template. Cara ini dapat mengimpor di kode hasil generate
    from polars_ta.prefix.talib import ts_LINEARREG_SLOPE  # noqa

    # Juga mendukung impor def dan class secara original
    def cs_rank_if(condition, factor):
        return cs_rank(if_else(condition, factor, None))

    class Clazz:
        pass

    # 1. Variabel yang diawali garis bawah hanyalah variabel antara, akan otomatis diganti nama, dan dihapus saat output akhir
    # 2. Variabel dengan awalan garis bawah dapat digunakan berulang. Jika ada beberapa faktor kompleks yang ditulis multi-baris dan ada variabel antara yang sama, tidak akan terjadi konflik
    _avg = ts_mean(corr, 20)
    _std = ts_std_dev(corr, 20)
    _beta = ts_LINEARREG_SLOPE(corr, 20)

    # 3. Variabel awalan garis bawah dapat digunakan berulang dalam siklus. Saat debugging, dapat dengan cepat beralih dengan komentar
    _avg = cs_mad_zscore_resid(_avg, LOG_MC_ZS, ONE)
    _std = cs_mad_zscore_resid(_std, LOG_MC_ZS, ONE)
    # _beta = cs_mad_zscore_resid(_beta, LOG_MC_ZS, ONE)

    _corr = cs_zscore(_avg) + cs_zscore(_std)
    CPV = cs_zscore(_corr) + cs_zscore(_beta)


code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=sys.stdout)  # Cetak kode
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file="output.py")  # Simpan ke file
code = codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by')  # Jalankan saja, tidak menyimpan kode

code = StringIO()
codegen_exec(None, _code_block_1, _code_block_2, over_null='partition_by', output_file=code)  # Simpan ke string
code.seek(0)
code.read()  # Baca kode

# TODO Ganti dengan data yang sesuai
df = pl.DataFrame()
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect()  # Lazy CPU
df = codegen_exec(df.lazy(), _code_block_1, _code_block_2, over_null='partition_by').collect(engine="gpu")  # Lazy GPU

```

## Struktur Direktori

```commandline
│  requirements.txt # Instalasi dependensi dengan `pip install -r requirements.txt`
├─data
│      prepare_date.py # Persiapan data
├─examples
│      demo_express.py # Contoh kilat. Menunjukkan cara mengonversi ekspresi ke kode
│      demo_exec_pl.py # Menunjukkan cara memanggil kode hasil konversi dan membuat plot
│      demo_transformer.py # Menunjukkan konversi ekspresi pihak ketiga ke ekspresi internal
│      output.py # Output hasil. Tidak perlu mengubah kode, dapat langsung diimpor ke proyek lain
│      show_tree.py # Gambar diagram pohon ekspresi. Dapat digunakan untuk analisis dan perbandingan hasil optimasi
│      sympy_define.py # Definisi simbol, karena sering dipakai di banyak tempat maka diekstrak di sini
├─expr_codegen
│   │  expr.py # Fungsi dasar pemrosesan ekspresi
│   │  tool.py # Kode alat inti
│   ├─polars
│   │  │  code.py # Fungsi generate kode khusus untuk sintaks polars
│   │  │  template.py.j2 # Template `Jinja2`. Untuk generate file py terkait, umumnya tidak perlu diubah
│   │  │  printer.py # Turunan dari `StrPrinter` di `Sympy`, jika menambah fungsi baru mungkin perlu mengubah file ini
```

## Prinsip Kerja

Proyek ini bergantung pada proyek `sympy`. Fungsi utama yang digunakan adalah sebagai berikut:

1. `simplify`: Menyederhanakan ekspresi yang kompleks
2. `cse`: `Common Subexpression Elimination` (penghilangan sub-ekspresi umum)
3. `StrPrinter`: Mengoutput string berbeda sesuai fungsi berbeda. Kustomisasi kode ini dapat mendukung bahasa atau library lain

Karena `groupby`, `sort` cukup memakan waktu. Jika rumus diklasifikasikan sebelumnya, dan kategori berbeda menggunakan `groupby` yang berbeda, waktu komputasi dapat dikurangi.

1. `ts_xxx(ts_xxx)`: Dapat dihitung dalam satu `groupby`
2. `cs_xxx(cs_xxx)`: Dapat dihitung dalam satu `groupby`
3. `ts_xxx(cs_xxx)`: Perlu dihitung dalam `groupby` yang berbeda
4. `cs_xxx(ts_xxx(cs_xxx))`: Perlu dihitung dalam tiga `groupby` yang berbeda
5. `gp_xxx(aa, )+gp_xxx(bb, )`: Karena `aa` dan `bb` berbeda, perlu dihitung dalam dua `groupby` yang berbeda

Jadi

1. Perlu ada fungsi untuk mendapatkan kategori ekspresi saat ini (`get_current`) dan kategori sub-ekspresi (`get_children`)
2. Jika kategori saat ini berbeda dengan subkategori, maka rumus pendek dapat diekstrak (`extract`). Ekspresi kategori yang sama di tingkat berbeda punya urutan, tidak dapat ditempatkan dalam satu `groupby`
3. Memanfaatkan fitur `cse`, ekspresi panjang diganti dengan ekspresi pendek yang diekstrak di awal. Lalu dimasukkan ke dalam directed acyclic graph (`DAG`)
4. Memanfaatkan aliran DAG untuk pelapisan. Pada satu lapisan, `ts`, `cs`, `gp` tidak membedakan urutan
5. Pada satu lapisan, kelompokkan `ts`, `cs`, `gp`, lalu generate kode (`codegen`)

Informasi tersembunyi

1. `ts`: sort(by=[ASSET, DATE]).groupby(by=[ASSET], maintain_order=True)
2. `cs`: sort(by=[DATE]).groupby(by=[DATE], maintain_order=False)
3. `gp`: sort(by=[DATE, GROUP]).groupby(by=[DATE, GROUP], maintain_order=False)

Yaitu

1. Fungsi time-series menyembunyikan dua field `ASSET, DATE`, fungsi cross-section menyembunyikan satu field `DATE`
2. Fungsi grup menambah satu field `GROUP`, dan menyembunyikan satu field `DATE`

Dua metode klasifikasi

1. Berdasarkan prefix operator (`get_current_by_prefix`), membatasi operator harus diawali `ts_`, `cs_`, `gp_`
2. Berdasarkan nama lengkap operator (`get_current_by_name`), tidak lagi membatasi nama operator. Misal `cs_rank` bisa dinamai `rank`

## Penanganan Null

Bagaimana `null` dihasilkan?

1. Suspensi perdagangan. Sudah difilter sebelum perhitungan, tidak mempengaruhi perhitungan selanjutnya.
2. Jam perdagangan berbeda pada berbagai instrumen
3. Hasil perhitungan. `null` di ujung deret tidak mempengaruhi hasil fungsi time-series berikutnya, namun jika `null` muncul di tengah dapat mempengaruhi hasil. Contoh: `if_else(close<2, None, close)`

https://github.com/pola-rs/polars/issues/12925#issuecomment-2552764629

Ide yang sangat bagus, dirangkum ada dua cara implementasi:

1. Pisahkan `null` ke satu grup, `not_null` ke grup lain. Perlu pemanggilan dua kali
2. Satu grup saja, tapi urutan komposit, letakkan `null` di depan, `not_null` di belakang. Hanya dipanggil sekali, sedikit lebih cepat

```python
X1 = (ts_returns(CLOSE, 3)).over(CLOSE.is_not_null(), _ASSET_, order_by=_DATE_),
X2 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=[CLOSE.is_not_null(), _DATE_]),
X3 = (ts_returns(CLOSE, 3)).over(_ASSET_, order_by=_DATE_),
```

Pada area `null` di depan pada cara ke-2, apakah mempengaruhi hasil ditentukan oleh operator, terutama jika ada multi kolom input, area `null` bisa saja berisi data.

1. `over_null='partition_by'`. Dipisah menjadi dua area
2. `over_null='order_by'`. Dipisah menjadi satu area, `null` di depan
3. `over_null=None`. Tidak diproses, langsung dipanggil, lebih cepat. Jika yakin tidak akan muncul `null` di tengah, disarankan menggunakan parameter ini

`codegen_exec(over_null='partition_by')` untuk global menggunakan `partition_by`. Namun jika menemui fungsi `null` seperti `ts_count_nulls`, maka harus menggunakan `over_null=None`, sehingga alat ini juga menambahkan fitur komentar untuk menentukan parameter ekspresi per baris

1. `# --over_null partition_by`. Per baris `over_null='partition_by'`
2. `# --over_null=order_by`. Per baris `over_null='order_by'`
3. `# --over_null`. Per baris `over_null=None`
4. `# `. Mengambil nilai `over_null` dari parameter yang diberikan ke `codegen_exec`

Catatan:

1. Komentar parameter `# --over_null` hanya dapat ditulis di akhir ekspresi satu baris, tidak boleh berdiri sendiri di satu baris, jika tidak akan diabaikan
2. Jika ada banyak `# --over_null # --over_null=order_by`, hanya yang pertama yang berlaku
3. Hanya berlaku untuk fungsi `ts` di lapisan terluar. Jika fungsi `ts` tidak ada di luar, harus diekstrak manual. Contoh:
   ```python
   X1 = cs_rank(ts_mean(CLOSE, 3)) # --over_null=order_by # Berlaku untuk cs_rank, tidak ada artinya
   X2 = ts_rank(ts_mean(CLOSE, 3), 5) # --over_null=order_by # Dikira berlaku pada ts_rank(ts_mean), tapi karena ada ts_mean sebagai sub-ekspresi umum, sebenarnya berlaku pada ts_rank(_x_0)
   ```

   Harus ditulis sebagai

   ```python
   _x_0 = ts_mean(CLOSE, 3)  # --over_null=order_by 
   X1 = cs_rank(_x_0)
   X2 = ts_rank(_x_0, 5)
   ```
4. Karena mudah salah, sangat disarankan untuk menghasilkan `output_file` dan memeriksa apakah kode hasil sudah benar.

## Keterbatasan `expr_codegen`

1. `DAG` hanya dapat menambah kolom, tidak bisa menghapus. Saat menambah kolom, jika nama kolom sama akan menimpa
2. Tidak mendukung `menghapus baris`, namun dapat menambah kolom tanda hapus, lalu hapus baris di luar. Menghapus baris mempengaruhi semua kolom, tidak memenuhi `DAG`
3. Tidak mendukung `resampling`, alasannya sama dengan tidak mendukung hapus baris. Harus dilakukan di luar
4. Menghapus baris dan resampling dapat dijadikan garis pemisah, sehingga kode besar dibagi menjadi beberapa `DAG` yang terhubung. Rumit dan sulit dipahami, sehingga akhirnya tidak diimplementasikan

## Sintaks Khusus

1. Mendukung ekspresi tiga nilai `C?T:F` (hanya dalam string), di tingkat bawah akan diubah dulu menjadi `C or True if( T )else F`, lalu diperbaiki jadi `T if C else F`, dan akhirnya diubah ke `if_else(C,T,F)`. Dapat dicampur dengan `if else`
2. `(A<B)*-1`, di tingkat bawah akan diubah ke `int_(A<B)*-1`
3. Untuk mencegah `A==B` diubah oleh `sympy` menjadi `False`, di tingkat bawah akan diganti dengan `Eq(A,B)`
4. Arti `A^B` tergantung parameter `convert_xor`, jika `convert_xor=True` maka akan diubah ke `Pow(A,B)`, sebaliknya jadi `Xor(A,B)`. Defaultnya `False`, gunakan `**` untuk pangkat
5. Mendukung `A&B&C`, namun tidak mendukung `A==B==C`. Jika C adalah boolean dan AB numerik, dapat diganti manual ke `(A==B)==C`. Jika ABC numerik, ganti manual ke `(A==B)&(B==C)`
6. Tidak mendukung `A<=B<=C`, ganti manual ke `(A<=B)&(B<=C)`
7. Mendukung `A[0]+B[1]+C[2]`, di bawah akan diubah ke `A+ts_delay(B,1)+ts_delay(C,2)`
8. Mendukung `~A`, di bawah akan diubah ke `Not(A)`
9. Fungsi yang diawali `gp_` akan mengembalikan fungsi `cs_` terkait. Misal `gp_func(A,B,C)` akan diganti dengan `cs_func(B,C)`, di mana `A` dipakai pada `groupby([date, A])`
10. Mendukung unpack tuple `A,B,C=MACD()`, di bawah akan diubah menjadi
   ```python
   _x_0 = MACD()
   A = unpack(_x_0, 0)
   B = unpack(_x_0, 1)
   C = unpack(_x_0, 2)
   ```
11. Komentar satu baris mendukung input parameter seperti: `# --over_null`, `# --over_null=order_by`, `# --over_null=partition_by`
12. Dalam code block, tiga sintaks `import`, `def`, `class` otomatis dimasukkan secara original ke kode hasil generate

## Variabel dengan Awalan Garis Bawah

1. Data output, semua kolom yang diawali `_` akan otomatis dihapus pada akhirnya. Jadi variabel yang ingin disimpan jangan pakai awalan `_`
2. Untuk mengurangi perhitungan berulang, otomatis ditambahkan variabel antara yang diawali `_x_`, misal `_x_0`, `_x_1`, dan seterusnya. Juga akan otomatis dihapus pada akhir
3. Ekspresi satu baris yang terlalu panjang, atau ada perhitungan berulang, dapat dipecah menjadi multi baris dengan variabel antara. Jika variabel antara diawali `_`, akan otomatis ditambahkan sufiks angka, membentuk variabel berbeda, misal `_A` jadi `_A_0_`, `_A_1_`, dst. Contoh penggunaan:
    1. Nama variabel yang sama, dipakai berulang. Sebenarnya adalah variabel berbeda
    2. Assignment berulang, namun `DAG` tidak mendukung siklus. Variabel dengan nama sama di kiri-kanan `=` sebenarnya adalah variabel berbeda

## Contoh Hasil Translasi

Cuplikan kode hasil translasi, kode lengkap silakan lihat [versi Polars](examples/output_polars.py)

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

Cuplikan kode hasil translasi, kode lengkap silakan lihat [versi Pandas](examples/output_pandas.py)

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

## Web Interaktif Deployment Lokal

Cukup jalankan `streamlit run streamlit_app.py`


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---