# Conversor Simple de Apple Health XML a CSV

Un script simple para convertir el archivo export.xml de Apple Health en un csv fácil de usar.



## Cómo Ejecutar 

### 1. Verifique que tenga Python 3 y Pandas instalados en su máquina o entorno

`python --version` debería devolver _Python 3.x.x_ donde x es cualquier número. 

Si tiene Python 2.x.x, por favor actualice a Python 3 aquí: https://www.python.org/downloads/ (o especifique la versión de Python de su entorno)

`python3 -c "import pandas"` debería no mostrar nada en la línea de comandos

Si obtiene un error _**ModuleNotFoundError: No module named 'pandas'**_, instale pandas y pruebe de nuevo:

`pip3 install pandas`


### 2. Exporte sus datos de Apple Health

| Inicio de Salud | ➡️ | Exportar Datos |
|--|--|--|
|<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/health_home.jpg" width=300>||<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/export_data_button.jpg" width = 300 >|

Sus datos serán preparados, y luego podrá transferir el archivo export.zip a su máquina.

### 3. Descomprima el archivo, que debería contener:

   * apple_health_export
     * export.xml (Este es el archivo con sus datos que desea convertir)
     
     * export_cda.xml
     
       

### 4. Coloque el archivo "apple_health_xml_convert.py" de este repositorio en la carpeta junto a los archivos y ejecute el script

`python3 apple_health_xml_convert.py`



La exportación se escribirá con el formato:

* **apple_health_export_YYYY-MM-DD.csv**

  

En Excel, la salida debería verse algo así:

<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/example_output.jpg">

Nota: Este script elimina los prefijos de datos de Apple Health: `HKQuantityTypeIdentifier`, `HKCategoryTypeIdentifier` y `HKCharacteristicTypeIdentifier` para mejorar la legibilidad. Si lo deseas, puedes comentar esas líneas en el código con un `#` para mantenerlos en la salida CSV.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-14

---