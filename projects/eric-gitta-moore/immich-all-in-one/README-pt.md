# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Planejo migrar futuramente para ente-io/ente, pois preciso de s3 para armazenar fotos~~
>
> O ente ainda tem poucas funcionalidades
>
> Alterado para utilizar juicedata/juicefs para montar s3

## Introdução ao Projeto

Este projeto é uma solução de aprimoramento de IA para o sistema de gerenciamento de fotos [Immich](https://github.com/immich-app/immich). Ele expande as funcionalidades nativas do Immich principalmente através dos seguintes componentes:

- **inference-gateway**: Serviço gateway escrito em Go, responsável pelo roteamento inteligente das requisições de machine learning do Immich
- **mt-photos-ai**: Serviço de IA baseado em Python e FastAPI, integrado com os modelos RapidOCR e cn-clip
- Extensão das funções do Immich, incluindo pesquisa OCR por reconhecimento de texto e reprocesamento de dados de IA para mídia individual, ranqueamento híbrido por pontuação de vetores OCR e CLIP
- Adiciona segmentação de palavras em chinês ao PostgreSQL usando o zhparser

## Funcionalidades Principais

### 1. Reconhecimento e Pesquisa de Texto (OCR)

- Utiliza RapidOCR para reconhecer textos em imagens
- Suporta reconhecimento de texto misto em chinês e inglês
- Implementa busca baseada no conteúdo textual das imagens

### 2. Processamento de Vetores de Imagem CLIP

- Utiliza o modelo cn-clip para correspondência imagem-texto em chinês mais precisa
- Suporta busca semântica, aumentando a precisão das pesquisas

### 3. Reprocessamento de Dados de IA para Mídia Individual

- Permite regenerar dados OCR para uma imagem/vídeo individualmente
- Permite regenerar vetores CLIP para uma imagem/vídeo individualmente
- Oferece capacidade de atualização manual para resultados de reconhecimento imprecisos

## Arquitetura do Sistema

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```

## Detalhamento dos Componentes

### inference-gateway

Serviço gateway escrito em Go, principais responsabilidades:
- Receber as requisições de machine learning do Immich
- Roteia as requisições OCR e CLIP para o serviço mt-photos-ai conforme o tipo
- Encaminha outras requisições de machine learning (como reconhecimento facial) para o serviço nativo de ML do Immich
- Processa autenticação e conversão de formatos de dados

### mt-photos-ai

Serviço de IA em Python e FastAPI, oferece:
- API de reconhecimento de texto (OCR) baseada no RapidOCR
- API de processamento de vetores CLIP baseada em cn-clip
- Suporte a aceleração por GPU

## Instruções de Deploy

### Requisitos do Ambiente

- Docker e Docker Compose
- GPU NVIDIA (opcional, mas recomendado para aceleração)
- Espaço de armazenamento suficiente

### Instruções de Configuração

1. **Configuração do inference-gateway**

Principais variáveis de ambiente:
```
IMMICH_API=http://localhost:3003  # Endereço da API do Immich
MT_PHOTOS_API=http://localhost:8060  # Endereço do serviço mt-photos-ai
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # Chave de API
PORT=8080  # Porta de escuta do gateway
```

2. **Configuração do mt-photos-ai**

Principais variáveis de ambiente:
```
CLIP_MODEL=ViT-B-16  # Nome do modelo CLIP
CLIP_DOWNLOAD_ROOT=./models/clip  # Caminho para download do modelo
DEVICE=cuda  # ou cpu, dispositivo de inferência
HTTP_PORT=8060  # Porta de escuta do serviço
```

### Passos para Deploy

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/immich-all-in-one.git
cd immich-all-in-one
```

2. Inicie os serviços:
```bash
docker-compose up -d
```

## Instruções de Uso

1. **Configurar o Immich para usar o serviço ML personalizado**

No arquivo de configuração do Immich, aponte o endereço do serviço de machine learning para o inference-gateway:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **Uso da pesquisa OCR**

- Use o prefixo `ocr:` na barra de pesquisa do Immich para busca OCR
- Por exemplo: `ocr:nota fiscal` irá buscar fotos que contenham o texto "nota fiscal" na imagem

3. **Reprocessamento de dados de IA para mídia individual**

- Na página de detalhes da foto, clique nas opções do menu
- Escolha "Regenerar dados OCR" ou "Regenerar vetores CLIP"
- O sistema irá reprocessar os dados de IA dessa foto

## Guia de Desenvolvimento

### inference-gateway (Go)

Compilar e rodar:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

Configuração do ambiente de desenvolvimento:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## Licença

Este projeto é open source sob a licença MIT.

## Agradecimentos

- [Immich](https://github.com/immich-app/immich) - Solução open source de backup e gerenciamento de fotos e vídeos auto-hospedada
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Biblioteca OCR multiplataforma baseada em PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Modelo pré-treinado de aprendizado contrastivo multimodal para chinês

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---