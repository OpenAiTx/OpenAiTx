# RSS-Master

Personalização de filtragem e triagem para fontes RSS, utilizando IA para resumir, sintetizar e pontuar. Versão otimizada para desempenho, suportando processamento assíncrono e resumos paralelos por IA.

### Prefácio

No início de setembro, comecei a usar Inoreader + RSSHub para agregar e assinar RSSs do meu interesse, junto com o Reeder para leitura, tentando controlar totalmente a fonte das informações que recebo diariamente. Após um mês, o número crescente de fontes RSS e o aumento das mensagens não lidas me causaram ansiedade para leitura, então pensei se haveria uma maneira de personalizar algumas regras de filtragem, preferencialmente com IA para ajudar na leitura e reduzir meu esforço.

O Inoreader tem filtros embutidos, mas pagar só por essa função não parecia valer a pena; o NewsBlur tem um "Intelligence Trainer" para classificação inteligente, mas testei rapidamente e não senti um feedback claro, não demonstrando inteligência no curto prazo; o Feedly tem filtragem e função de IA, parecia atender minhas necessidades, e enquanto eu hesitava entre continuar no Inoreader ou migrar para o Feedly pago, encontrei esses dois projetos

- [Deixe o ChatGPT nos ajudar a resumir o Hacker News](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [Guia de uso do RSS-GPT](http://yinan.me/rss-gpt-manual-zh.html)

A ideia geral desses projetos é executar um script via GitAction, obter informações e usar a API do Open AI para traduzir, resumir, depois renderizar em um template e publicar no GitHub Pages. O método do RSS-GPT atende melhor minhas necessidades, executando periodicamente o script para obter o arquivo XML do RSS, processá-lo e publicar no GitHub Pages para obter o link de acesso, que pode ser diretamente assinado pelo leitor.

Tenho grande necessidade de sincronização multi-dispositivo do Inoreader. Para novos RSS adicionados no arquivo de configuração, preciso notificar o Inoreader para sincronizar rapidamente. Então, estendi a ideia do [RSS-GPT](https://github.com/yinan-c/) e criei o RSS-Master.

### Características

- **Suporte a processamento paralelo**: utiliza assíncrono e thread pool para processar fontes RSS e resumos IA em paralelo, aumentando significativamente a velocidade
- **Mecanismo de cache aprimorado**: sistema de cache mais estável, prevenindo perda de dados e melhorando o desempenho em acessos repetidos
- **Melhor tratamento de erros**: todas as operações possuem tratamento completo de erros e registro de logs, aumentando a estabilidade
- **Extração otimizada de conteúdo HTML**: extrai inteligentemente o conteúdo dos artigos, ignorando informações irrelevantes, melhorando a qualidade dos resumos IA
- **Suporte à API OpenAI mais recente**: compatibilidade total com a versão mais recente da API OpenAI
- **Estatísticas detalhadas**: fornece tempo de execução, taxa de sucesso e estatísticas de custo após processamento
- **Geração de arquivos opml**: além de conversão mútua com config.yml: `script/convert_opml_to_yaml.sh` `script/convert_yaml_to_opml.sh`
- **Suporte a regras de filtragem personalizadas**: suporta tipos include e exclude, com escopos title e article
- **Modelo IA personalizável**: permite configurar diferentes modelos OpenAI por variável de ambiente
- **URL base personalizável**: configura URL base para arquivos RSS, facilitando implantação em ambientes distintos
- **Notebook interativo para testes**: disponibiliza notebook Jupyter para testar funcionalidades

### Configuração de variáveis de ambiente

O projeto suporta configuração via arquivo `.env` com os seguintes parâmetros:

```
# Parâmetros obrigatórios
OPENAI_API_KEY=sua_chave_openai_aqui

# Parâmetros opcionais
RSS_BASE_URL=https://example.com/rss-feeds/  # URL base do RSS
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # Modelo OpenAI
LOG_LEVEL=INFO                               # Nível de log
PARALLEL_WORKERS=5                           # Quantidade de processos paralelos
```

Copie o arquivo `.env.example`, renomeie para `.env` e modifique os valores conforme necessário.

### Melhorias de desempenho

Esta versão traz as seguintes melhorias em relação à original:

1. **Processamento paralelo das fontes RSS**: usa `asyncio` para processar múltiplas fontes simultaneamente
2. **Paralelismo nos resumos IA**: utiliza thread pool para processar múltiplos artigos simultaneamente
3. **Otimização do tratamento de texto**: algoritmo aprimorado para extração de conteúdo HTML, extraindo inteligentemente o conteúdo principal
4. **Manipulação segura de arquivos**: método seguro de escrita para evitar perda de dados em falhas do programa
5. **Otimização no uso de memória**: estrutura de dados e fluxo de processamento otimizados para reduzir consumo de memória

### Instruções de uso

1. Clone o projeto localmente  
2. Instale as dependências: `pip install -r requirements.txt`  
3. Crie o arquivo `.env` e configure sua chave OpenAI: `OPENAI_API_KEY=sua_chave`  
4. Edite `resource/config.yml` para configurar suas fontes RSS  
5. Execute `python main.py` para iniciar o processamento  

### Testes e depuração

O projeto oferece um notebook interativo `test.ipynb` para testar funcionalidades como:

1. Obtenção e análise de fontes RSS  
2. Funcionalidade dos filtros  
3. Resumos por IA  
4. Mecanismo de cache  
5. URL base personalizada  
6. Testes de desempenho  

Como usar:

```bash
# Instale o Jupyter
pip install jupyter

# Inicie o notebook
jupyter notebook test.ipynb
```

### Exemplo de regras de filtragem personalizadas

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '可乐',
          '雪碧',
          '芬达',
          '柠檬',
          '茶叶',
          '纸巾',
          '酒精',
          '湿纸巾',
          '餐巾纸',
        ]
```

### Capturas de tela do uso

- Função de resumo e síntese por IA

<div style="display: flex;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Filtragem personalizada: filtra o canal de boas ofertas do "什么值得买", recomendando apenas itens recentes que quero estocar, como refrigerantes

<img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---