<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

Uma alternativa auto-hospedada e com foco em privacidade ao MyFitnessPal. Monitore nutrição, exercícios, métricas corporais e dados de saúde mantendo total controle sobre seus dados.

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness é uma plataforma de acompanhamento fitness auto-hospedada composta por:

- Um servidor backend (API + armazenamento de dados)
- Um frontend baseado na web
- Aplicativos móveis nativos para iOS e Android

Armazena e gerencia dados de saúde em infraestrutura que você controla, sem depender de serviços de terceiros.

## Recursos Principais

- Rastreamento de nutrição, exercício, hidratação, sono, jejum, humor e medidas corporais
- Definição de metas e check-ins diários
- Gráficos interativos e relatórios de longo prazo
- Perfis de múltiplos usuários e acesso familiar
- Temas claro e escuro
- OIDC, TOTP, Passkey, MFA etc.

## Integrações de Saúde & Dispositivos

O SparkyFitness pode sincronizar dados de múltiplas plataformas de saúde e fitness:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (testado parcialmente)
- **Hevy** (não testado)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (testado parcialmente)

As integrações sincronizam automaticamente dados de atividades como passos, exercícios e sono, além de métricas de saúde como peso e medidas corporais, para seu servidor SparkyFitness.

## Recursos de IA Opcionais (Beta)

O SparkyAI fornece uma interface conversacional para registrar dados e revisar progresso.

- Registrar alimentos, exercícios, estatísticas corporais e passos via chat
- Enviar imagens de alimentos para registro automático de refeições
- Retém o histórico de conversas para acompanhamentos

Nota: Os recursos de IA estão atualmente em beta.

## Início Rápido (Servidor)

Coloque um servidor SparkyFitness em funcionamento em minutos usando Docker Compose.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```
## 🎥 Tutorial em Vídeo

[![Assista ao vídeo](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

Tutorial rápido de 2 minutos mostrando como instalar o SparkyFitness (rastreador fitness auto-hospedado).


## Documentação

Para guias completos de instalação, opções de configuração e documentação de desenvolvimento, visite nosso [Site de Documentação](https://codewithcj.github.io/SparkyFitness/).

### Links Rápidos

- **[Guia de Instalação](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - Implantação e configurações
- **[Visão Geral de Funcionalidades](https://codewithcj.github.io/SparkyFitness/features)** - Documentação completa de recursos
- **[Fluxo de Trabalho de Desenvolvimento](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Guia do desenvolvedor e processo de contribuição
- **[Informações do App iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** e **[Informações do App Android](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### Precisa de Ajuda?

- Publique em issues/discussão no Github.
- Para resposta mais rápida e obter ajuda de outros membros da comunidade **[Junte-se ao nosso Discord](https://discord.gg/vcnMT5cPEA)**

## Histórico de Estrelas

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Gráfico do Histórico de Estrelas" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Traduções

**[Traduções Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">


<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Estado da tradução" />
</a>

## Atividade do repositório

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Imagem de análise do Repobeats")

## Contribuidores

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Problemas conhecidos / Funcionalidades Beta ⚠️

O SparkyFitness está em desenvolvimento ativo.
Mudanças incompatíveis podem ocorrer entre as versões.

- Não é recomendado atualizar contêineres automaticamente
- Sempre revise as notas de versão antes de atualizar

As seguintes funcionalidades estão atualmente em beta e podem não ter sido totalmente testadas. Espere possíveis bugs ou funcionalidades incompletas:

- Chatbot de IA
- Acesso Família & Amigos
- Documentação da API


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---