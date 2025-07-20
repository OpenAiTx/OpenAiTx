<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - Sistema Inteligente de Atendimento Automático para Xianyu

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

Uma solução de IA projetada especialmente para a plataforma Xianyu, proporcionando atendimento automatizado 24/7, com suporte para decisão colaborativa entre múltiplos especialistas, negociação inteligente e conversas sensíveis ao contexto.

## 🎮 Playground - Experimente Rápido (Versão sem Configuração)

Sem necessidade de ambiente local ou configuração de Secrets! **Basta passar os parâmetros pela interface do GitHub Actions** para iniciar o robô da Xianyu com um clique.

### Como usar
1. **Fork este repositório** → Clique no botão `Fork` no canto superior direito
2. **Dispare a Action**:
   - Acesse a aba `Actions` do seu repositório
   - Selecione o workflow **`🚀 Run Service`**
   - Clique no botão **`Run workflow`** e preencha os parâmetros:
      - `API Key`: Cole sua chave de API do modelo (por exemplo, Alibaba Cloud DashScope)
      - `Cookies`: Cole a string completa de Cookie da interface web da Xianyu
3. **Veja os logs de execução**:
   - O robô irá monitorar as mensagens da Xianyu automaticamente após iniciar
   - Procure por `🤖 Reply:` nos logs da Action para ver os registros de conversas

### Observações
⚠️ Atenção às limitações de execução temporária:
- Tempo padrão de execução **30 minutos** (limite de conta gratuita GitHub)
- Informações sensíveis (como Cookies) **não serão armazenadas**, válidas apenas para a sessão atual

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Funcionalidades Principais

### Motor de Conversa Inteligente
| Módulo       | Implementação Técnica     | Características-Chave                                       |
| ------------ | ------------------------ | ----------------------------------------------------------- |
| Consciência de Contexto | Armazenamento do histórico de conversas | Gerenciamento leve de memória de conversas, histórico completo como entrada de contexto para LLM |
| Roteamento de Especialistas | Prompt LLM+roteamento por regras | Reconhecimento de intenção baseado em engenharia de prompts → distribuição dinâmica para agentes especialistas, suportando negociação/técnico/suporte ao cliente em múltiplos cenários |

### Matriz de Funcionalidades de Negócio
| Módulo      | Implementado                     | Em Planejamento                 |
| ----------- | ------------------------------- | ------------------------------- |
| Motor Principal | ✅ Resposta automática via LLM<br>✅ Gestão de contexto | 🔄 Aprimoramento com análise de sentimentos |
| Sistema de Negociação | ✅ Estratégia de desconto escalonado          | 🔄 Comparação de preços no mercado         |
| Suporte Técnico | ✅ Integração com busca na web                | 🔄 Aprimoramento de base de conhecimento RAG |

## 🚴 Início Rápido

### Requisitos de Ambiente
- JDK 21+
- Maven 3.9.10+

### Passos de Instalação

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 Participação e Contribuição

Seja bem-vindo a enviar sugestões através de Issues ou contribuir com código via PR. Por favor, siga o [Guia de Contribuição](https://contributing.md/)



## 🛡 Avisos

⚠️ Atenção: **Este projeto é apenas para fins de aprendizado e troca de informações. Caso haja violação de direitos autorais, entre em contato com o autor para remoção.**

Devido à natureza especial do projeto, a equipe de desenvolvimento pode, a qualquer momento, **parar as atualizações** ou **remover o projeto**.


## 🧸 Agradecimentos Especiais

Este projeto foi reestruturado com base nos seguintes projetos de código aberto:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - Sistema inteligente de atendimento ao cliente para Xianyu, desenvolvido por [@shaxiu](https://github.com/shaxiu) e [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---