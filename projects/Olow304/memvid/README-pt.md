# Memvid - Memória de IA Baseada em Vídeo 🧠📹

**A solução leve e revolucionária para memória de IA em escala**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

O Memvid revoluciona o gerenciamento de memória de IA ao codificar dados de texto em vídeos, permitindo **busca semântica ultrarrápida** em milhões de trechos de texto com **tempos de recuperação inferiores a um segundo**. Diferente dos bancos de dados vetoriais tradicionais que consomem grandes quantidades de RAM e armazenamento, o Memvid comprime sua base de conhecimento em arquivos de vídeo compactos enquanto mantém acesso instantâneo a qualquer informação.

## 🎥 Demonstração

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ Principais Funcionalidades

- 🎥 **Vídeo como Banco de Dados**: Armazene milhões de trechos de texto em um único arquivo MP4
- 🔍 **Busca Semântica**: Encontre conteúdos relevantes usando consultas em linguagem natural
- 💬 **Chat Integrado**: Interface conversacional com respostas contextuais
- 📚 **Suporte a PDF**: Importação e indexação direta de documentos PDF
- 🚀 **Recuperação Rápida**: Busca em menos de um segundo em grandes conjuntos de dados
- 💾 **Armazenamento Eficiente**: Compressão 10x maior que bancos de dados tradicionais
- 🔌 **LLMs Plugáveis**: Funciona com OpenAI, Anthropic ou modelos locais
- 🌐 **Offline-First**: Não requer internet após a geração do vídeo
- 🔧 **API Simples**: Comece com apenas 3 linhas de código

## 🎯 Casos de Uso

- **📖 Bibliotecas Digitais**: Indexe milhares de livros em um único arquivo de vídeo
- **🎓 Conteúdo Educacional**: Crie memórias de vídeo pesquisáveis de materiais de curso
- **📰 Arquivos de Notícias**: Comprima anos de artigos em bancos de dados de vídeo gerenciáveis
- **💼 Conhecimento Corporativo**: Construa bases de conhecimento pesquisáveis em toda a empresa
- **🔬 Artigos Científicos**: Busca semântica rápida em literatura científica
- **📝 Notas Pessoais**: Transforme suas anotações em um assistente de IA pesquisável

## 🚀 Por que Memvid?

### Inovação Revolucionária
- **Vídeo como Banco de Dados**: Armazene milhões de trechos de texto em um único arquivo MP4
- **Recuperação Instantânea**: Busca semântica em menos de um segundo em grandes conjuntos de dados
- **Eficiência de Armazenamento 10x**: Compressão de vídeo reduz drasticamente o uso de memória
- **Zero Infraestrutura**: Sem servidores de banco de dados, apenas arquivos que você pode copiar para qualquer lugar
- **Offline-First**: Funciona totalmente offline após a geração dos vídeos

### Arquitetura Leve
- **Dependências Mínimas**: Funcionalidade central em ~1000 linhas de Python
- **Amigável ao CPU**: Roda eficientemente sem necessidade de GPU
- **Portátil**: Um único arquivo de vídeo contém toda sua base de conhecimento
- **Streamable**: Os vídeos podem ser transmitidos a partir de armazenamento em nuvem

## 📦 Instalação

### Instalação Rápida
```bash
pip install memvid
```

### Para Suporte a PDF
```bash
pip install memvid PyPDF2
```

### Configuração Recomendada (Ambiente Virtual)
```bash
# Crie um novo diretório para o projeto
mkdir my-memvid-project
cd my-memvid-project

# Crie o ambiente virtual
python -m venv venv

# Ative o ambiente
# No macOS/Linux:
source venv/bin/activate
# No Windows:
venv\Scripts\activate

# Instale o memvid
pip install memvid

# Para suporte a PDF:
pip install PyPDF2
```

## 🎯 Início Rápido

### Uso Básico
```python
from memvid import MemvidEncoder, MemvidChat

# Crie a memória de vídeo a partir de trechos de texto
chunks = ["Fato importante 1", "Fato importante 2", "Detalhes de evento histórico"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Converse com sua memória
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("O que você sabe sobre eventos históricos?")
print(response)
```

### Criando Memória a partir de Documentos
```python
from memvid import MemvidEncoder
import os

# Carregue os documentos
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Adicione arquivos de texto
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Construa o vídeo otimizado
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # Maior FPS = mais trechos por segundo
    frame_size=512  # Quadros maiores = mais dados por quadro
)
```

### Busca & Recuperação Avançada
```python
from memvid import MemvidRetriever

# Inicialize o recuperador
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Busca semântica
results = retriever.search("algoritmos de aprendizado de máquina", top_k=5)
for chunk, score in results:
    print(f"Score: {score:.3f} | {chunk[:100]}...")

# Obtenha janela de contexto
context = retriever.get_context("explique redes neurais", max_tokens=2000)
print(context)
```

### Interface de Chat Interativo
```python
from memvid import MemvidInteractive

# Inicie a interface de chat interativa
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Abre a interface web em http://localhost:7860
```

### Testando com file_chat.py
O script `examples/file_chat.py` fornece uma maneira abrangente de testar o Memvid com seus próprios documentos:

```bash
# Processe um diretório de documentos
python examples/file_chat.py --input-dir /path/to/documents --provider google

# Processe arquivos específicos
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# Use compressão H.265 (requer Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Chunking personalizado para documentos grandes
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Carregar memória existente
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Exemplo Completo: Chat com um Livro PDF
```bash
# 1. Crie um novo diretório e configure o ambiente
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # No Windows: venv\Scripts\activate

# 2. Instale as dependências
pip install memvid PyPDF2

# 3. Crie o book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# Seu arquivo PDF
book_pdf = "book.pdf"  # Substitua pelo caminho do seu PDF

# Construa a memória de vídeo
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Converse com o livro
api_key = os.getenv("OPENAI_API_KEY")  # Opcional: para respostas de IA
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Execute
export OPENAI_API_KEY="sua-api-key"  # Opcional
python book_chat.py
```

## 🛠️ Configuração Avançada

### Embeddings Personalizados
```python
from sentence_transformers import SentenceTransformer

# Usar modelo de embedding personalizado
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Otimização de Vídeo
```python
# Para máxima compressão
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Mais quadros por segundo
    frame_size=256,  # Quadros menores
    video_codec='h265',  # Melhor compressão
    crf=28  # Qualidade da compressão (quanto menor = melhor qualidade)
)
```

### Processamento Distribuído
```python
# Processar grandes conjuntos de dados em paralelo
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Solução de Problemas

### Problemas Comuns

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Certifique-se de que está usando o Python correto
which python  # Deve mostrar o caminho do seu ambiente virtual
# Se não, ative seu ambiente virtual:
source venv/bin/activate  # No Windows: venv\Scripts\activate
```

**ImportError: PyPDF2 é necessário para suporte a PDF**
```bash
pip install PyPDF2
```

**Problemas com a Chave de API LLM**
```bash
# Defina sua chave de API (obtenha uma em https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Ou no Windows:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Processamento de PDF Grande**
```python
# Para PDFs muito grandes, use tamanhos de fragmento menores
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Contribuindo

Contribuições são bem-vindas! Por favor, veja nosso [Guia de Contribuição](CONTRIBUTING.md) para detalhes.

```bash
# Rodar testes
pytest tests/

# Rodar com cobertura
pytest --cov=memvid tests/

# Formatar código
black memvid/
```

## 🆚 Comparação com Soluções Tradicionais

| Recurso | Memvid | Vector DBs | DBs Tradicionais |
|---------|--------|------------|------------------|
| Eficiência de Armazenamento | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| Complexidade de Configuração | Simples | Complexo | Complexo |
| Busca Semântica | ✅ | ✅ | ❌ |
| Uso Offline | ✅ | ❌ | ✅ |
| Portabilidade | Baseado em arquivo | Baseado em servidor | Baseado em servidor |
| Escalabilidade | Milhões | Milhões | Bilhões |
| Custo | Grátis | $$$$ | $$$ |


## 📚 Exemplos

Confira o diretório [examples/](examples/) para:
- Construção de memória a partir de dumps da Wikipedia
- Criação de uma base de conhecimento pessoal
- Suporte multilíngue
- Atualizações de memória em tempo real
- Integração com LLMs populares

## 🆘 Obtendo Ajuda

- 📖 [Documentação](https://github.com/olow304/memvid/wiki) - Guias completos
- 💬 [Discussões](https://github.com/olow304/memvid/discussions) - Tire dúvidas
- 🐛 [Rastreador de Issues](https://github.com/olow304/memvid/issues) - Relate bugs
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - Compartilhe seus projetos

## 🔗 Links

- [Repositório GitHub](https://github.com/olow304/memvid)
- [Pacote PyPI](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)


## 📄 Licença

Licença MIT - veja o arquivo [LICENSE](LICENSE) para detalhes.

## 🙏 Agradecimentos

Criado por [Olow304](https://github.com/olow304) e a comunidade Memvid.

Construído com ❤️ usando:
- [sentence-transformers](https://www.sbert.net/) - Embeddings de ponta para busca semântica
- [OpenCV](https://opencv.org/) - Visão computacional e processamento de vídeo
- [qrcode](https://github.com/lincolnloop/python-qrcode) - Geração de códigos QR
- [FAISS](https://github.com/facebookresearch/faiss) - Busca eficiente por similaridade
- [PyPDF2](https://github.com/py-pdf/pypdf) - Extração de texto de PDF

Agradecimentos especiais a todos os colaboradores que ajudam a tornar o Memvid melhor!

---

**Pronto para revolucionar o gerenciamento de memória da sua IA? Instale o Memvid e comece a construir!** 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---