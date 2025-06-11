# Django Ninja Shortener - Serviço de Encurtador de URL tipo Bitly

Um serviço moderno de encurtamento de URLs construído com Django, Django Ninja e Tailwind CSS, inspirado no design do Bitly.

Os usuários podem se registrar e fazer login, encurtar URLs e rastrear o número de cliques em cada URL curta.

Este projeto utiliza o [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) para auxiliar no desenvolvimento. Consulte [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Capturas de Tela

Página do encurtador de URL (pode ser usada sem registro)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Com registro é possível rastrear os cliques

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Destaques de Funcionalidades

* **Autenticação de Usuário**: Suporta registro, login e logout de usuários.
* **Criação de URLs Curtas**: Usuários autenticados podem gerar uma URL curta única para um endereço longo.
* **Redirecionamento de URL Curta**: Ao clicar na URL curta, o usuário é redirecionado para o endereço original.
* **Rastreamento de Cliques**: O sistema conta automaticamente o número de cliques de cada URL curta.
* **Painel Pessoal**: Usuários podem visualizar todas as URLs criadas e suas estatísticas de cliques.
* **API RESTful**: Oferece endpoints para criar URLs curtas programaticamente.
* **Suporte a Docker**: Fornece Dockerfile e configuração Docker Compose para facilitar o desenvolvimento e a implantação.

## 🛠️ Stack Tecnológica

* **Backend**: [Django](https://github.com/twtrubiks/django-tutorial)
* **Framework de API**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Estilo Frontend**: [Tailwind CSS](https://tailwindcss.com/) (integrado via `django-tailwind`)
* **Banco de Dados**:
  * Ambiente de desenvolvimento: SQLite (padrão)
  * Produção: Pode ser facilmente alterado para PostgreSQL (configuração já prevista em `settings.py`)
* **Código da URL Curta**: Gerado com `shortuuid`
* **Testes**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Containerização**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Início Rápido (Usando Docker - Recomendado)

Este é o método mais recomendado, garantindo a consistência do ambiente de desenvolvimento.

**Passos para iniciar:**

1. **Suba os serviços:**

    Use Docker Compose para subir todos os serviços de uma vez.

    ```bash
    docker compose up --build
    ```

    Este comando irá construir as imagens Docker, instalar as dependências, aplicar as migrações do banco de dados e iniciar o servidor de desenvolvimento.

2. **Crie um superusuário (opcional):**

    Para acessar o Django Admin, execute em outro terminal:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Acesse a aplicação:**

    * **Home do site**: [http://localhost:8000](http://localhost:8000)

    * **Documentação da API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Desenvolvimento Local (Sem Docker)

Caso prefira configurar o ambiente localmente.

**Pré-requisitos:**

* Python 3.12
* Node.js e npm (para Tailwind CSS)

**Passos de configuração:**

1. **Crie e ative um ambiente virtual:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # No Windows, use `venv\Scripts\activate`
    ```

2. **Instale as dependências do Python:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Instale e configure o Tailwind CSS:**

    O `django-tailwind` cuidará da maioria das configurações.

    ```bash
    python manage.py tailwind install
    ```

    Consulte [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Aplique as migrações do banco de dados:**

    ```bash
    python manage.py migrate
    ```

5. **Crie um superusuário (opcional):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Inicie o servidor de desenvolvimento:**

    É necessário iniciar tanto o servidor Django quanto o processo de compilação do Tailwind CSS.

    ```bash
    python manage.py runserver
    ```

    Em outro terminal:

    ```bash
    python manage.py tailwind start
    ```

7. **Acesse a aplicação:**

    * **Home do site**: [http://localhost:8000](http://localhost:8000)

    * **Documentação da API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Executando Testes

Este projeto utiliza `pytest` para testes e cálculo da cobertura.

O plano de testes pode ser consultado em [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Executar testes com Docker:**

    ```bash
    docker compose --profile test up
    ```

    O relatório de testes será gerado em `htmlcov/index.html`.

* **Executar testes localmente:**

    ```bash
    # Certifique-se de que as dependências de desenvolvimento estão instaladas
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 Endpoints da API

A API fornece uma maneira programática de interagir com o serviço de encurtamento de URLs. Todos os endpoints estão sob o caminho `/api/`.

Recomenda-se acessar diretamente a **Documentação da API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Utilizando [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), primeiro chame `/api/token/pair` e, conforme usuário e senha, obtenha seu token

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Depois cole o token no canto superior direito para chamar as APIs

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Estrutura do Projeto

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Configurações do projeto Django
│   ├── settings.py
│   └── urls.py
├── shortener/            # Aplicação principal de encurtamento
│   ├── models.py         # Modelos do banco de dados (Link)
│   ├── api.py            # Endpoints da API Django Ninja
│   ├── views.py          # Lógicas de views e redirecionamento
│   └── utils.py          # Utilitários de geração de código curto
└── theme/                # Temas e templates Django
    ├── templates/        # Templates HTML
    └── static_src/       # Fontes do Tailwind CSS
```

## 💡 Futuras Melhorias

* **Migrar para PostgreSQL**: Banco de dados mais robusto para produção. (Já implementado)
* **Painel analítico detalhado**: Fornecer mais dados de cliques, como tempo, origem, localização geográfica etc.
* **URL curta personalizada**: Permite que o usuário personalize o código do URL curto.
* **Geração de QR Code**: Gera um QR Code correspondente para cada URL curta.
* **Tarefas assíncronas**: Usa o Celery para processar tarefas demoradas, como análise de dados.

## Doação

Todos os artigos são originais, resultado da minha própria pesquisa e compreensão. Se foram úteis para você e deseja me incentivar, sinta-se à vontade para me oferecer um café :laughing:

ECPAY (não é necessário cadastro)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Pagamento do patrocinador](http://bit.ly/2F7Jrha)

O'Pay (necessita cadastro)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Pagamento do patrocinador](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Lista de patrocinadores

[Lista de patrocinadores](https://github.com/twtrubiks/Thank-you-for-donate)

## Licença

Licença MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---