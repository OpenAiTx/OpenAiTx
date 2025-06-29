<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 Uma plataforma robusta, implantada localmente, projetada para detecção perfeita de SQL e auditoria de consultas, adaptada especificamente para DBAs e desenvolvedores. Focada em privacidade e eficiência, oferece um ambiente intuitivo e seguro para auditoria MYSQL.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Funcionalidades

- **Assistente de IA**: Nosso assistente de IA oferece sugestões de otimização de SQL em tempo real, melhorando o desempenho das consultas. Também suporta conversão de texto para SQL, permitindo que os usuários insiram linguagem natural e recebam instruções SQL otimizadas.
  
- **Auditoria de SQL**: Crie tickets de auditoria de SQL com fluxos de aprovação e verificações automáticas de sintaxe. Valide instruções SQL quanto à correção, segurança e conformidade. Instruções de rollback são geradas automaticamente para operações DDL/DML, com um histórico abrangente para rastreabilidade.

- **Auditoria de Consultas**: Audite consultas de usuários, restrinja fontes de dados e bancos de dados, e anonimize campos sensíveis. Os registros de consulta são salvos para referência futura.

- **Regras de Verificação**: Nosso verificador automático de sintaxe suporta uma ampla gama de regras de verificação, adequadas para a maioria dos cenários de checagem automática.

- **Foco em Privacidade**: O Yearning é uma solução de código aberto, implantável localmente, que garante a segurança do seu banco de dados e instruções SQL. Inclui mecanismos de criptografia para proteger dados sensíveis, garantindo segurança mesmo em caso de acesso não autorizado.

- **RBAC (Controle de Acesso Baseado em Funções)**: Crie e gerencie funções com permissões específicas, restringindo o acesso a ordens de consulta, funções de auditoria e outras operações sensíveis com base nos papéis dos usuários.

> \[!TIP]
> Para informações mais detalhadas, visite nosso [Guia Yearning](https://next.yearning.io)

## ⚙️ Instalação

Baixe a [última versão](https://github.com/cookieY/Yearning/releases/latest) e extraia o arquivo. Certifique-se de que você configurou `./config.toml` antes de prosseguir.

### Instalação Manual

```bash
## Inicialize o banco de dados
./Yearning install

## Inicie o Yearning
./Yearning run

## Ajuda
./Yearning --help
```

### 🚀 Implantação com Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Inicialize o banco de dados
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Inicie o Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 Assistência de IA

Nosso Assistente de IA utiliza um grande modelo de linguagem para fornecer sugestões de otimização de SQL e conversão de texto para SQL. Seja usando prompts padrão ou personalizados, o Assistente de IA melhora o desempenho do SQL ao otimizar instruções e converter entradas em linguagem natural em consultas SQL.

![Texto para SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Verificador Automático de SQL

O verificador automático de SQL avalia instruções SQL com base em regras e sintaxes predefinidas. Ele garante que as instruções estejam em conformidade com padrões de codificação específicos, boas práticas e requisitos de segurança, proporcionando uma camada robusta de validação.

![Auditoria SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 Realce de Sintaxe SQL e Autocompletar

Aumente a eficiência na escrita de consultas com realce de sintaxe SQL e autocompletar. Esses recursos ajudam os usuários a distinguir visualmente diferentes componentes de uma consulta SQL, como palavras-chave, nomes de tabelas, nomes de colunas e operadores, facilitando a leitura e compreensão da estrutura da consulta.

![Consulta SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Registro de Ordem/Consulta

Nossa plataforma suporta a auditoria de ordens e consultas dos usuários. Esse recurso permite rastrear e registrar todas as operações de consulta, incluindo fontes de dados, bancos de dados e o tratamento de campos sensíveis, garantindo conformidade com regulamentações e proporcionando rastreabilidade do histórico de consultas.

![Registro de Ordem/Consulta](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Ao focar nessas funcionalidades-chave, o Yearning melhora a experiência do usuário, otimiza o desempenho de SQL e garante conformidade e rastreabilidade robustas nas operações de banco de dados.

## 🛠️ Ferramentas Recomendadas

- [Spug - Plataforma Aberta de Operações Automatizadas e Leve](https://github.com/openspug/spug)

## ☎️ Contato

Para dúvidas, envie um e-mail para: henry@yearning.io
## 📋 Licença

O Yearning está licenciado sob a licença AGPL. Veja [LICENSE](LICENSE) para mais detalhes.

2024 © Henry Yee

---

Com o Yearning, experimente uma abordagem simplificada, segura e eficiente para auditoria e otimização de SQL.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---