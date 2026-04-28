<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - Motor de Consulta SQL de Alto Desempenho para Arquivos CSV

 [![Compilar e Testar em Múltiplas Plataformas (com sistema de build zig)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Um processador de consultas SQL leve e rápido escrito em C que permite executar consultas SQL diretamente em arquivos CSV sem a necessidade de um banco de dados. Para documentação completa, consulte o diretório /doc.

 ![cq em ação](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)


## Documentação

- Guia de Introdução: `doc/GettingStarted.md`
- Instalação: `doc/Installation.md`
- Interface de Linha de Comando: `doc/CLI.md`
- **TUI (Interface de Usuário do Terminal)**: `doc/TUI.md`
- Arquitetura: `doc/Architecture.md`
- Testes: `doc/Testing.md`
- Roteiro: `doc/Roadmap.md`
- Contribuindo: `doc/Contributing.md`

## Início Rápido

Compilar: `make`

### Linha de Comando

Execute uma consulta de exemplo:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### UI do Terminal

Inicie a TUI interativa:
`./build/cqtui data/`

Funcionalidades:
- Navegue e abra arquivos CSV como tabelas
- Execute consultas SQL interativamente
- Interface multi-abas para várias tabelas
- Navegação baseada no teclado
- Sem dependências externas

## Arquivos SQL de Exemplo

O repositório inclui exemplos de SQL em assets/ (example_between.sql, example_aggregation.sql, etc.). Veja assets/ para detalhes.

## Visão Geral de Dados & Funcionalidades

- Veja a pasta /doc para seções detalhadas sobre tipos de dados, formatos de data, formato CSV e mais.

## Licença

Licença MIT. Veja o arquivo LICENSE para detalhes.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---