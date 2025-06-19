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


Flink CDC é uma ferramenta distribuída de integração de dados para dados em tempo real e dados em lote. O Flink CDC traz a simplicidade
e elegância da integração de dados via YAML para descrever o movimento e a transformação de dados em um
[Pipeline de Dados](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md).


O Flink CDC prioriza uma integração de dados ponta a ponta eficiente e oferece funcionalidades aprimoradas, como
sincronização completa de banco de dados, sincronização de tabelas particionadas, evolução de esquema e transformação de dados.

![Projeto do framework Flink CDC](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Guia de Início Rápido

O Flink CDC fornece uma utilidade CLI chamada CdcUp para iniciar um ambiente de playground e executar jobs do Flink CDC.
Você precisará ter um ambiente funcional com Docker e Docker Compose para utilizá-lo.

1. Execute `git clone https://github.com/apache/flink-cdc.git --depth=1` para obter uma cópia do código-fonte do Flink CDC.
2. Execute `cd tools/cdcup/ && ./cdcup.sh init` para usar a ferramenta CdcUp e iniciar um ambiente de playground.
3. Execute `./cdcup.sh up` para subir os containers Docker e aguarde até que estejam prontos.
4. Execute `./cdcup.sh mysql` para abrir uma sessão MySQL e criar pelo menos uma tabela.

```sql
-- inicializar banco de dados e tabela
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- inserir dados de teste
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- verificar se os dados foram inseridos com sucesso
SELECT * FROM test_table;
```

5. Execute `./cdcup.sh pipeline pipeline-definition.yaml` para submeter o job do pipeline. Você também pode editar o arquivo de definição do pipeline para outras configurações.
6. Execute `./cdcup.sh flink` para acessar a interface web do Flink.

### Primeiros Passos

1. Prepare um cluster [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) e configure a variável de ambiente `FLINK_HOME`.
2. [Baixe](https://github.com/apache/flink-cdc/releases) o tar do Flink CDC, descompacte e coloque os jars do conector do pipeline no diretório `lib` do Flink.

> Se você estiver usando macOS ou Linux, pode usar `brew install apache-flink-cdc` para instalar rapidamente o Flink CDC e conectores compatíveis.

3. Crie um arquivo **YAML** para descrever a fonte e o destino dos dados. O exemplo a seguir sincroniza todas as tabelas do banco de dados MySQL app_db para Doris:
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
       description: projetar campos e filtrar
     - source-table: adb.web_order02
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 20 AND order_id > 200
       description: projetar campos e filtrar

   route:
     - source-table: app_db.orders
       sink-table: ods_db.ods_orders
     - source-table: app_db.shipments
       sink-table: ods_db.ods_shipments
     - source-table: app_db.products
       sink-table: ods_db.ods_products

   pipeline:
     name: Sincronizar banco de dados MySQL para Doris
     parallelism: 2
     user-defined-function:
       - name: addone
         classpath: com.example.functions.AddOneFunctionClass
       - name: format
         classpath: com.example.functions.FormatFunctionClass
  ```
4. Submeta o job do pipeline usando o script `flink-cdc.sh`.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Visualize o status de execução do job pela WebUI do Flink ou pelo banco de dados de destino.

Experimente você mesmo com nosso [tutorial](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) mais detalhado.
Você também pode ver a [visão geral dos conectores](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) para visualizar um catálogo abrangente dos
conectores atualmente fornecidos e entender configurações mais detalhadas.

### Participe da Comunidade

Existem várias formas de participar da comunidade do Apache Flink CDC. As
[listas de e-mails](https://flink.apache.org/what-is-flink/community/#mailing-lists) são o principal local onde todos os committers do Flink estão presentes. Para suporte ao usuário e dúvidas, utilize a lista de e-mails de usuários. Se você encontrou um problema no Flink CDC,
por favor, crie uma [issue no Flink Jira](https://issues.apache.org/jira/projects/FLINK/summary) e marque com a tag `Flink CDC`.   
Bugs e solicitações de funcionalidades podem ser discutidos tanto na lista de e-mails de desenvolvedores como no Jira.

### Contribuindo

Seja bem-vindo(a) para contribuir com o Flink CDC. Veja nosso [Guia do Desenvolvedor](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
e [Guia das APIs](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).

### Licença

[Licença Apache 2.0](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).

### Agradecimentos Especiais

A comunidade Flink CDC dá boas-vindas a todos que desejam contribuir, seja enviando relatórios de bugs,
melhorando a documentação ou submetendo contribuições de código para correções de bugs, adição de testes ou desenvolvimento de novas funcionalidades.     
Obrigado a todos os colaboradores por suas contribuições entusiásticas.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---