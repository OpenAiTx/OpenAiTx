# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Planos futuros de migração para ente-io/ente, pois preciso do S3 para armazenar fotos~~
> 
> O ente ainda tem poucos recursos
> 
> Alterado para usar juicedata/juicefs para montar S3

## Introdução ao Projeto

Este projeto é uma solução de aprimoramento de IA para o sistema de gerenciamento de fotos [Immich](https://github.com/immich-app/immich). Ele expande as funcionalidades nativas do Immich principalmente através dos seguintes componentes:

- **inference-gateway**: serviço gateway escrito em Go, responsável pelo roteamento inteligente das solicitações de machine learning do Immich
- **mt-photos-ai**: serviço de IA baseado em Python e FastAPI, integrando RapidOCR e o modelo cn-clip
- Expansão de funcionalidades do Immich, incluindo busca por OCR, reprocessamento de dados de IA por mídia individual, ranqueamento híbrido por vetores de texto integral do OCR e CLIP
- Adição do zhparser ao PostgreSQL para segmentação de palavras em chinês

## Funcionalidades Principais

### 1. Reconhecimento e busca de texto via OCR

- Uso do RapidOCR para reconhecer textos em imagens
- Suporte ao reconhecimento de textos em chinês e inglês misturados
- Implementação de busca baseada no conteúdo textual das imagens

### 2. Processamento de vetores de imagem CLIP

- Correspondência imagem-texto em chinês aprimorada com o modelo cn-clip
- Suporte a busca semântica, aumentando a precisão das buscas

### 3. Reprocessamento de dados de IA para mídia individual

- Suporte à regeneração de dados OCR para uma única imagem/vídeo
- Suporte à regeneração de dados vetoriais CLIP para uma única imagem/vídeo
- Capacidade de atualizar manualmente em caso de resultados de reconhecimento imprecisos

## Arquitetura do sistema

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
## Detalhes dos Componentes

### inference-gateway

Serviço gateway escrito em Go, principais responsabilidades:
- Receber solicitações de machine learning do Immich
- Redirecionar solicitações OCR e CLIP para o serviço mt-photos-ai de acordo com o tipo de solicitação
- Redirecionar outras solicitações de machine learning (como reconhecimento facial) para o serviço nativo de machine learning do Immich
- Lidar com autenticação e conversão de formato de dados

### mt-photos-ai

Serviço de IA escrito em Python e FastAPI, fornece:
- API de reconhecimento de texto OCR (baseada em RapidOCR)
- API de processamento de vetores CLIP (baseada em cn-clip)
- Suporte para aceleração por GPU

## Instruções de Deploy

### Requisitos de Ambiente

- Docker e Docker Compose
- GPU NVIDIA (opcional, mas recomendado para acelerar o processamento)
- Espaço de armazenamento suficiente

### Instruções de Configuração

1. **Configuração do inference-gateway**

Principais variáveis de ambiente:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **Configuração do mt-photos-ai**

Principais variáveis de ambiente:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Etapas de implantação

1. Clone o repositório:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Inicie o serviço:

```bash
docker-compose up -d
```
## Instruções de uso

1. **Configurar o Immich para usar um serviço ML personalizado**

No arquivo de configuração do Immich, aponte o endereço do serviço de machine learning para o inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **Uso de Pesquisa OCR**

- Use o prefixo `ocr:` na barra de pesquisa do Immich para realizar pesquisas por OCR
- Por exemplo: `ocr:nota fiscal` irá buscar fotos que contenham o texto "nota fiscal" na imagem

3. **Reprocessamento de Dados de IA de Mídia Única**

- Na página de detalhes da foto, clique na opção de menu
- Selecione "Regenerar dados OCR" ou "Regenerar vetor CLIP"
- O sistema irá reprocessar os dados de IA dessa foto

## Guia de Desenvolvimento

### inference-gateway (Go)

Para compilar e rodar:

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

Este projeto é de código aberto sob a licença MIT.

## Agradecimentos

- [Immich](https://github.com/immich-app/immich) - Solução de backup de fotos e vídeos auto-hospedada e de código aberto
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Biblioteca OCR multiplataforma baseada em PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Modelo pré-treinado de aprendizado contrastivo multimodal em chinês



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---