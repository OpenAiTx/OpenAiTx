
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ethan-carter-g&project=uni-page&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Uni-Page Framework de Paginação

Uni-Page é um framework de paginação universal baseado em Java, que fornece uma interface unificada para consultas paginadas em diferentes fontes de dados por meio de um design abstrato. O framework adota uma arquitetura modular, atualmente integrando várias fontes de dados como JDBC, Mybatis, MongoDB, Elasticsearch, e oferece um mecanismo flexível de extensão.

## Design Central

O design central do framework é estruturado em torno de quatro componentes-chave:

1. **Instrução de Paginação (PaginationStatement)**
    - Suporta definição de instruções de consulta paginada em qualquer linguagem
    - Fornece interface unificada de parâmetros de paginação
    - Permite lógica de paginação personalizada

2. **Executor de Instrução de Paginação (PaginationStatementExecutor)**
    - Responsável por executar instruções de consulta paginada
    - Fornece funcionalidade de consulta de informações de paginação
    - Mecanismo de executor extensível

3. **Conjunto de Resultados de Paginação (PaginationResultSet)**
    - Interface unificada de conjunto de resultados
    - Suporta acesso aos dados por nome de coluna e índice
    - Oferece funcionalidade de conversão de tipos
    - Design semelhante ao JDBC ResultSet

4. **Manipulador de Conjunto de Resultados (PaginationResultSetHandler)**
    - Suporta conversão personalizada de conjunto de resultados
    - Fornece funcionalidade de mapeamento de objetos


## Objetivos de Design

1. **Unificação**
    - Oferece interface unificada para consultas paginadas
    - Abstrai diferenças de implementação entre diferentes fontes de dados
    - Simplifica o uso das consultas paginadas

2. **Flexibilidade**
    - Suporta instruções de paginação personalizadas
    - Permite extensão de executores
    - Disponibiliza formas variadas de manipulação de conjuntos de resultados

3. **Escalabilidade**
    - Design modular
    - Suporta integração rápida de novas fontes de dados
    - Oferece mecanismo de pontos de extensão

4. **Facilidade de uso**
    - API simples e intuitiva
    - Conversão de tipos aprimorada
    - Suporte abrangente de classes utilitárias
## Cenários de Aplicação

- Projetos que precisam gerenciar consultas paginadas de múltiplas fontes de dados de forma unificada
- Aplicações corporativas que requerem suporte à paginação de diversos tipos de fontes de dados

## Módulos Principais

### [uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page)
Biblioteca central de paginação, fornece interfaces básicas de paginação e implementações abstratas.

### [uni-page-jdbc](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc)
Módulo de suporte a fonte de dados JDBC, fornece implementação de paginação baseada em JDBC.

### [uni-page-jdbc-mybatis](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-jdbc-mybatis)
Módulo de integração com MyBatis, oferece suporte à integração com o framework MyBatis.
    
### [uni-page-mongodb](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-mongodb)
Módulo de suporte a fonte de dados MongoDB, fornece implementação de paginação baseada em MongoDB.

### [uni-page-elasticsearch](https://github.com/ethan-carter-g/uni-page/tree/main/uni-page-elasticsearch)
Módulo de suporte a fonte de dados Elasticsearch, oferece implementação de paginação baseada em ES.

### [spring-boot-starter-web-uni-page](https://github.com/ethan-carter-g/uni-page/tree/main/spring-boot-starter-web-uni-page)
Módulo de suporte à paginação em ambiente Spring MVC, fornece integração com Spring MVC, tornando tão simples quanto escrever um controlador comum.
- Vinculação automática de parâmetros de paginação
- Conversão automática de resultados de paginação

### [web-uni-page-test](https://github.com/ethan-carter-g/uni-page/tree/main/web-uni-page-test)
Módulo de testes de paginação em ambiente Spring Boot Web, fornece testes integrados de funcionalidade de paginação.


## Início Rápido, usando uni-page-jdbc como exemplo

### Dependência Maven

```xml
<dependency>
    <groupId>com.github.ethancarter</groupId>
    <artifactId>uni-page-jdbc</artifactId>
    <version>1.9</version>
</dependency>
```

### Exemplo simples

```java
public class PaginationTest {
   
    public void page() {
        PaginationStatementTemplate operations = new PaginationStatementTemplate();
        operations.addStatementExecutor(new Sql2oPaginationNamedParameterStatementExecutor(dataSource));
        
        // 1. 创建分页语句
        PaginationStatement statement = of(b -> b
                .sql("SELECT * FROM user WHERE username LIKE :username")
                .paramMap("username", "%admin%")
                .pageable(0, 10)
                .sort("id", Sort.Direction.DESC));
        
        // 2. 执行查询
        PageInformation information = operations.queryForInformation(statement);
        Page<User> page = operations.queryForResultSet(statement, new JdbcBeanPropertyPaginationRowMapper<>(User.class));
    }

    // User实体类
    class User {
        private Long id;
        private String username;
        // getters and setters
    }
}
```


## Agradecimentos

Durante o desenvolvimento deste framework, fui profundamente influenciado e inspirado pela comunidade de código aberto. Agradeço aos especialistas que compartilharam generosamente suas experiências técnicas; é a sabedoria e a contribuição de vocês que permitiram o nascimento deste framework. Agradeço especialmente aos excelentes projetos open source pelas inspirações de design e ideias de implementação, pois essas experiências valiosas me permitiram continuar avançando sobre os ombros de gigantes.

Obrigado a todos os especialistas técnicos que contribuíram para a comunidade open source!

## 🌟 Apoie o projeto
Se você acha que este projeto foi útil para você, fique à vontade para clicar na ⭐Star no canto superior direito para me apoiar!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---