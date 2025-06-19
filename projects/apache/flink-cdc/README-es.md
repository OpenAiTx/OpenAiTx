<p align="center">
  <a href="https://nightlies.apache.org/flink/flink-cdc-docs-stable/"><img src="https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/flinkcdc-logo.png" alt="Flink CDC" style="width: 375px;"></a>
</p>
<p align="center">
<a href="https://github.com/apache/flink-cdc/" target="_blank">
    <img src="https://img.shields.io/github/stars/apache/flink-cdc?style=social&label=Star&maxAge=2592000" alt="Test">
</a>
<a href="https://github.com/apache/flink-cdc/releases" target="_blank">
    <img src="https://img.shields.io/github/v/release/apache/flink-cdc?color=yellow" alt="Release">
</a>
<a href="https://github.com/apache/flink-cdc/actions/workflows/flink_cdc_ci.yml" target="_blank">
    <img src="https://img.shields.io/github/actions/workflow/status/apache/flink-cdc/flink_cdc_ci.yml?branch=master" alt="Build">
</a>
<a href="https://github.com/apache/flink-cdc/actions/workflows/flink_cdc_ci_nightly.yml" target="_blank">
    <img src="https://img.shields.io/github/actions/workflow/status/apache/flink-cdc/flink_cdc_ci_nightly.yml?branch=master&label=nightly" alt="Nightly Build">
</a>
<a href="https://github.com/apache/flink-cdc/tree/master/LICENSE" target="_blank">
    <img src="https://img.shields.io/static/v1?label=license&message=Apache License 2.0&color=white" alt="License">
</a>
</p>


Flink CDC es una herramienta distribuida de integración de datos para datos en tiempo real y datos por lotes. Flink CDC aporta la simplicidad 
y elegancia de la integración de datos mediante YAML para describir el movimiento y transformación de datos en una 
[Canalización de Datos](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md).


Flink CDC prioriza la integración eficiente de datos de extremo a extremo y ofrece funcionalidades mejoradas como 
sincronización completa de bases de datos, sincronización de tablas particionadas (sharding), evolución de esquemas y transformación de datos.

![Diseño del framework Flink CDC](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Guía de Inicio Rápido

Flink CDC proporciona una utilidad CLI llamada CdcUp para iniciar un entorno de pruebas y ejecutar trabajos de Flink CDC.
Necesitará tener un entorno funcional de Docker y Docker compose para utilizarla.

1. Ejecute `git clone https://github.com/apache/flink-cdc.git --depth=1` para obtener una copia del código fuente de Flink CDC.
2. Ejecute `cd tools/cdcup/ && ./cdcup.sh init` para utilizar la herramienta CdcUp y arrancar un entorno de pruebas.
3. Ejecute `./cdcup.sh up` para iniciar los contenedores docker y espere a que estén listos.
4. Ejecute `./cdcup.sh mysql` para abrir una sesión de MySQL y cree al menos una tabla.

```sql
-- inicializar base de datos y tabla
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- insertar datos de prueba
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- verificar si se ha insertado correctamente
SELECT * FROM test_table;
```

5. Ejecute `./cdcup.sh pipeline pipeline-definition.yaml` para enviar el trabajo de pipeline. También puede editar el archivo de definición de pipeline para configuraciones adicionales.
6. Ejecute `./cdcup.sh flink` para acceder a la interfaz web de Flink.

### Primeros Pasos

1. Prepare un clúster de [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) y configure la variable de entorno `FLINK_HOME`.
2. [Descargue](https://github.com/apache/flink-cdc/releases) el tar de Flink CDC, descomprímalo y coloque los jars del conector de pipeline en el directorio `lib` de Flink.

> Si utiliza macOS o Linux, puede usar `brew install apache-flink-cdc` para instalar Flink CDC y conectores compatibles rápidamente.

3. Cree un archivo **YAML** para describir la fuente de datos y el destino de datos. El siguiente ejemplo sincroniza todas las tablas de la base de datos app_db de MySQL a Doris:
  ```yaml
   source:
     type: mysql
     hostname: localhost
     port: 3306
     username: root
     password: 123456
     tables: app_db.\.*

   sink:
     type: doris
     fenodes: 127.0.0.1:8030
     username: root
     password: ""

   transform:
     - source-table: adb.web_order01
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 10 AND order_id > 100
       description: proyectar campos y filtrar
     - source-table: adb.web_order02
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 20 AND order_id > 200
       description: proyectar campos y filtrar

   route:
     - source-table: app_db.orders
       sink-table: ods_db.ods_orders
     - source-table: app_db.shipments
       sink-table: ods_db.ods_shipments
     - source-table: app_db.products
       sink-table: ods_db.ods_products

   pipeline:
     name: Sincronizar Base de Datos MySQL a Doris
     parallelism: 2
     user-defined-function:
       - name: addone
         classpath: com.example.functions.AddOneFunctionClass
       - name: format
         classpath: com.example.functions.FormatFunctionClass
  ```
4. Envíe el trabajo de pipeline utilizando el script `flink-cdc.sh`.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Vea el estado de ejecución del trabajo a través de la WebUI de Flink o la base de datos de destino.

Pruébelo usted mismo con nuestro [tutorial](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) más detallado. 
También puede consultar la [visión general de conectores](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) para ver un catálogo completo de los
conectores actualmente disponibles y entender configuraciones más detalladas.

### Únete a la Comunidad

Hay muchas formas de participar en la comunidad de Apache Flink CDC. Las
[listas de correo](https://flink.apache.org/what-is-flink/community/#mailing-lists) son el lugar principal donde están presentes todos los committer de Flink.
Para soporte al usuario y preguntas, utilice la lista de correo de usuarios. Si ha encontrado un problema en Flink CDC,
por favor cree un [jira de Flink](https://issues.apache.org/jira/projects/FLINK/summary) y etiquétele con la etiqueta `Flink CDC`.   
Los errores y solicitudes de funciones pueden discutirse en la lista de correo de desarrollo o en Jira.



### Contribuir

Bienvenido a contribuir a Flink CDC, por favor consulte nuestra [Guía del Desarrollador](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
y la [Guía de APIs](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).



### Licencia

[Licencia Apache 2.0](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).



### Agradecimientos Especiales

La comunidad de Flink CDC da la bienvenida a todos los que estén dispuestos a contribuir, ya sea presentando informes de errores,
mejorando la documentación o enviando contribuciones de código para correcciones de errores, adición de pruebas o desarrollo de nuevas funcionalidades.     
Gracias a todos los colaboradores por sus entusiastas aportes.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---