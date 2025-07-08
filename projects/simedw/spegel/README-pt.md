# Spegel – Reflita a web através da IA

Reescreve automaticamente sites em markdown otimizado para visualização no terminal.
Leia o post introdutório no blog [aqui](https://simedw.com/2025/06/23/introducing-spegel/)

Este é um protótipo, bugs são esperados, mas fique à vontade para abrir um issue ou pull request.

##  Captura de Tela
Às vezes você não quer ler a história de vida de alguém só para chegar a uma receita
![Exemplo de Receita](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## Instalação

Requer Python 3.11+

```
pip install spegel
```
ou clone o repositório e instale em modo editável

```bash
# Clone e entre no diretório
$ git clone <repo-url>
$ cd spegel

# Instale as dependências e o CLI
$ pip install -e .
```

## Chaves de API
Atualmente o Spegel suporta apenas o Gemini 2.5 Flash; para usá-lo você precisa fornecer sua chave de API na variável de ambiente

```
GEMINI_API_KEY=...
```


## Uso

### Inicie o navegador

```bash
spegel                # Inicia com a tela de boas-vindas
spegel bbc.com        # Abre uma URL imediatamente
```

Ou, de forma equivalente:

```bash
python -m spegel      # Inicia com a tela de boas-vindas
python -m spegel bbc.com
```

### Controles básicos
- `/`         – Abrir entrada de URL
- `Tab`/`Shift+Tab` – Percorrer links
- `Enter`     – Abrir link selecionado
- `e`         – Editar prompt LLM para a visualização atual
- `b`         – Voltar
- `q`         – Sair

## Editando configurações

O Spegel carrega configurações de um arquivo TOML. Você pode personalizar visualizações, prompts e opções de interface.

**Ordem de busca do arquivo de configuração:**
1. `./.spegel.toml` (diretório atual)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Para editar as configurações:
1. Copie a configuração de exemplo:
   ```bash
   cp example_config.toml .spegel.toml
   # ou crie ~/.spegel.toml
   ```
2. Edite o `.spegel.toml` no seu editor favorito.

Exemplo de trecho:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Visualização Bruta"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transforme esta página em uma experiência de navegação perfeita no terminal! ..."
```

---

Para mais informações, veja o código ou abra um issue!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---