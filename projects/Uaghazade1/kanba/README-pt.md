<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Alternativa open-source e leve ao Trello, projetada para makers e indie hackers.

Foco em simplicidade, velocidade e escalabilidade.
Construído com stack moderna: Tailwind CSS, shadcn/ui, Supabase, integração com Stripe.
Suporta projetos ilimitados, colaboração em equipe, modo escuro/claro e experiência de usuário fluida.
Perfeito para desenvolvedores solo e pequenas equipes que querem controle total sem complexidade desnecessária.

## 🌟 Se você acha este projeto útil, considere dar uma estrela! Isso ajuda outros a descobri-lo também.

# Guia de Deploy

## Visão Geral
Esta aplicação agora utiliza rotas locais da API Next.js em vez de Supabase Edge Functions para integração com Stripe. Isso torna a implantação mais simples e permite usar arquivos .env padrão para configuração.

## Configuração das Variáveis de Ambiente

### 1. Crie o arquivo .env.local
Copie `.env.example` para `.env.local` e preencha com seus valores reais:


```bash
cp .env.example .env.local
```
### 2. Variáveis de Ambiente Necessárias

#### Configuração do Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - URL do seu projeto Supabase
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Sua chave anônima do Supabase
- `SUPABASE_SERVICE_ROLE_KEY` - Sua chave de função de serviço do Supabase (apenas no lado do servidor)

#### Configuração do Stripe (opcional)
- `STRIPE_SECRET_KEY` - Sua chave secreta do Stripe (apenas no lado do servidor)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Sua chave publicável do Stripe
- `STRIPE_WEBHOOK_SECRET` - Seu segredo de webhook do Stripe

#### Configuração do Site
- `NEXT_PUBLIC_SITE_URL` - URL do seu site (para produção)
- `NEXTAUTH_URL` - URL do seu site (igual ao acima)
- `NEXTAUTH_SECRET` - Um segredo aleatório para o NextAuth

## Desenvolvimento Local

1. Instale as dependências:

```bash
npm install
```
2. Configure suas variáveis de ambiente em `.env.local`

3. Execute o servidor de desenvolvimento:

```bash
npm run dev
```
4. Teste os webhooks do Stripe localmente usando o Stripe CLI:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## Implantação em Produção


### Implantação no Vercel

1. **Implantar no Vercel:**

```bash
npx vercel
```
2. **Variáveis de Ambiente:**
   Adicione todas as variáveis de ambiente através do painel do Vercel ou CLI

3. **Configuração do Webhook Stripe:**
   - Aponte o webhook para: `https://your-domain.vercel.app/api/stripe/webhook`

## Endpoints da API

O aplicativo agora utiliza estas rotas locais de API:

- `POST /api/stripe/checkout` - Cria sessões de checkout do Stripe
- `POST /api/stripe/webhook` - Lida com eventos de webhook do Stripe

## Benefícios das Rotas Locais de API

1. **Implantação Mais Simples** - Não é necessário implantar funções edge separadas
2. **Variáveis de Ambiente** - Suporte padrão para arquivos .env
3. **Melhor Depuração** - Mais fácil de depurar localmente
4. **Integração com Framework** - Melhor integração com Next.js
5. **Sem Dependência de Fornecedor** - Pode implantar em qualquer plataforma que suporte Next.js

## Solução de Problemas

1. **Problemas com Webhook:**
   - Certifique-se de que `STRIPE_WEBHOOK_SECRET` corresponde ao endpoint de webhook do Stripe
   - Verifique os logs do webhook no painel do Stripe
   - Confirme se a URL do webhook está correta

2. **Variáveis de Ambiente:**
   - Certifique-se de que todas as variáveis necessárias estão definidas
   - Verifique se há erros de digitação nos nomes das variáveis
   - Confirme se a chave de role do serviço Supabase tem permissões adequadas

3. **Problemas de CORS:**
   - As rotas da API incluem os cabeçalhos CORS apropriados
   - Certifique-se de que seu domínio está na lista permitida, se necessário

## Notas de Segurança

- Nunca exponha `STRIPE_SECRET_KEY` ou `SUPABASE_SERVICE_ROLE_KEY` para o cliente
- Use o prefixo `NEXT_PUBLIC_` apenas para variáveis do lado do cliente
- Gire seus segredos de webhook regularmente
- Monitore a entrega de webhooks no painel do Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---