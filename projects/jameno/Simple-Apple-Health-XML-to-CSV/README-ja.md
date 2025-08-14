# シンプルなApple Health XMLからCSVへの変換

Apple Healthのexport.xmlファイルを使いやすいcsvに変換する簡単なスクリプトです。



## 実行方法

### 1. マシンまたは環境にPython 3とPandasがインストールされていることを確認

`python --version` は _Python 3.x.x_ を返すはずです。xは任意の数字です。

もしPython 2.x.xの場合は、こちらからPython 3にアップグレードしてください：https://www.python.org/downloads/ （または環境のPythonバージョンを指定）

`python3 -c "import pandas"` はコマンドラインで何も返さないはずです。

もし _**ModuleNotFoundError: No module named 'pandas'**_ エラーが出る場合は、pandasをインストールして再試行してください：

`pip3 install pandas`


### 2. Apple Healthデータをエクスポートする

| Health Home | ➡️ | Export Data |
|--|--|--|
|<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/health_home.jpg" width=300>||<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/export_data_button.jpg" width = 300 >|

データが準備され、その後export.zipファイルをマシンに転送できます。

### 3. ファイルを解凍すると、以下が含まれているはずです：

   * apple_health_export
     * export.xml（変換したいデータが入ったファイルです）
     
     * export_cda.xml
     
       

### 4. このリポジトリの"apple_health_xml_convert.py"ファイルをこれらのファイルと同じフォルダに置き、スクリプトを実行してください

`python3 apple_health_xml_convert.py`



エクスポートは次の形式で書き込まれます：

* **apple_health_export_YYYY-MM-DD.csv**

  

Excelでは、出力は次のように表示されます：

<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/example_output.jpg">

注意：このスクリプトはApple Healthデータのプレフィックスである `HKQuantityTypeIdentifier`、`HKCategoryTypeIdentifier`、および `HKCharacteristicTypeIdentifier` を可読性向上のために削除します。CSV出力にそれらを残したい場合は、コード内の該当行を `#` でコメントアウトしてください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-14

---