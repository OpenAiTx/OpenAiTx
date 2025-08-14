# 简易苹果健康 XML 转 CSV

一个简单的脚本，用于将苹果健康的 export.xml 文件转换为易用的 CSV。



## 如何运行

### 1. 确认你的机器或环境中已安装 Python 3 和 Pandas

`python --version` 应返回 _Python 3.x.x_，其中 x 是任意数字。

如果你使用的是 Python 2.x.x，请升级到 Python 3：https://www.python.org/downloads/ （或指定你环境的 Python 版本）

`python3 -c "import pandas"` 在命令行应无输出

如果出现 _**ModuleNotFoundError: No module named 'pandas'**_ 错误，请安装 pandas 并重试：

`pip3 install pandas`


### 2. 导出你的苹果健康数据

| 健康主页 | ➡️ | 导出数据 |
|--|--|--|
|<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/health_home.jpg" width=300>||<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/export_data_button.jpg" width = 300 >|

你的数据将被准备好，之后你可以将 export.zip 文件传输到你的机器上。

### 3. 解压该文件，应该包含：

   * apple_health_export
     * export.xml（这是包含你想转换数据的文件）
     
     * export_cda.xml
     
       

### 4. 将本仓库中的 "apple_health_xml_convert.py" 文件放入该文件夹，并运行脚本

`python3 apple_health_xml_convert.py`



导出的文件格式为：

* **apple_health_export_YYYY-MM-DD.csv**

  

在 Excel 中，输出应类似于下图：

<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/example_output.jpg">

注意：此脚本会移除 Apple Health 数据前缀：`HKQuantityTypeIdentifier`、`HKCategoryTypeIdentifier` 和 `HKCharacteristicTypeIdentifier`，以提高可读性。如果您希望在 CSV 输出中保留这些前缀，可以在代码中用 `#` 注释掉相关行。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-14

---