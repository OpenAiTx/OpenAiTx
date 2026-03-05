CC++からPythonへの自動バインド
===================

> C/C++コードからPythonコードへ自動的にバインドし、whlパッケージを生成するための十分にシンプルで使いやすく設定可能なプロジェクト

> 本プロジェクトは以下からクローンしています:
https://github.com/Neutree/c_cpp_project_framework
また、コンパイルコード部分は元リポジトリと一致しています

> pybind11自動バインド部分の参考コード:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## クイックスタート

* 1.本リポジトリをクローンし、/examples/demoディレクトリに移動
python project.py menuconfigを使用してグラフィカルインターフェースを開き、コンパイルツールチェーンやwhlファイルのパッケージ化を設定
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> ここでx86はローカルマシンでのコンパイルを指し、arm64はMaixCam2向けのコンパイル、RISCV64はMaiCam/Pro向けのコンパイルを指します
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2.C/C++関数とhppヘッダーファイルを書く。whlパッケージ名と同じ名前にすることで自動認識を容易にする:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
対応する関数に@modul注釈を付け、その後に関数パスを記載してください:
```C++
namespace add::test
{
    /**
     * My function, add two integer.
     * @param a arg a, int type
     * @param b arg b, int type
     * @return int type, will a + b
     * @module add.test.add
     */
    int add(int a, int b);
}
```
最初の行は関数の説明、@paramはパラメータの説明、@returnは戻り値の説明（省略可能）です  
whlファイルとしてコンパイルおよびパッケージングするだけの場合は、main.cppを変更する必要はありません  
python project buildを使用すると、コンパイルおよびwhlファイルのパッケージングを開始できます  
コンパイル後にwhlをインストールすると、直接呼び出して使用できます:
```Python
import add
add.test.add(1,1)
```
注意:  
-   1つのヘッダーファイルは1つのモジュール名を表し、インポートするモジュールを示します。例えばadd.hppはimport addに対応し、そのモジュール名はaddで始まる必要があります。  
-   cpp_bind_python.pyを直接実行すると、バインドされたcppファイルのみが生成されます。--doc DOCパラメータを追加すると、コメントから自動的にドキュメントが生成されます。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-05

---