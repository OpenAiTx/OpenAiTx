
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Calendário Familiar Inteligente DIY para Casa (Clone do Skylight)

![Calendário Sklylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Introdução

Minha esposa tem sido recentemente bombardeada nas redes sociais com anúncios de calendários inteligentes para casa (Skylight, Cozyla, Hearth) e estava pronta para gastar mais de US$ 300 em um. Antes de dar o sinal verde, pedi uma chance para pesquisar sobre eles.
Percebi que a maioria oferecia funcionalidades semelhantes, mas diferiam significativamente no preço. Mais importante ainda, não vi nenhum recurso excepcional que eu não pudesse implementar no **Home Assistant**.

**O Objetivo:** Um calendário touchscreen aprovado pelo WAF (Fator de Aceitação da Esposa), amigável para bancada, que se integra profundamente à nossa casa inteligente sem taxas mensais.

## 💡 Por que fazer você mesmo?

Optar pela rota DIY com Home Assistant trouxe vários benefícios em relação à compra de um display Skylight/Hearth:

* **Sem taxas mensais:** Evita assinaturas para recursos "premium".
* **Integração perfeita:** Interage com nossas luzes, tarefas (Grocy) e sensores de presença.
* **Hardware antigo:** Reaproveitei um Mini PC e um monitor padrão.
* **Privacidade:** Sem dependência de fornecedor ou risco da empresa encerrar operações.

## 🛠 Seleção de Hardware

Atualmente, este projeto foi feito para exibir o painel em qualquer tela HD (1920x1080).

No meu caso, a exigência era que ele "parecesse" com um Skylight, fosse touchscreen, ficasse na bancada e pudesse ser movido para diferentes locais. Por isso, escolhi o hardware descrito abaixo.
No entanto, seu caso pode ser diferente e você precisará ajustá-lo conforme necessário, por exemplo, se quiser exibir em um tablet ou outro dispositivo.

O hardware que usei originalmente foi escolhido com base no que mencionei acima, além da esperança de poder estender funcionalidades usando a webcam, alto-falante e microfone. Atualmente, provavelmente montaria diferente, já que ainda não tive tempo de implementar essas ideias adicionais de hardware.

* **Monitor:** [HP Engage Touchscreen de 15 polegadas](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Escolhi este ao invés de monitores portáteis genéricos porque inclui **alto-falante, webcam e microfone** integrados, permitindo controle por voz ou chamadas de vídeo no futuro.
* **Computador:** Um Mini PC antigo (NUC/Tiny PC) rodando Windows/Linux em modo Kiosk, ou um Raspberry Pi 4.~~

## ✨ Funcionalidades

* **Visões de família e individuais:** Ative ou desative os calendários de membros específicos da família.
* **Sincronização bidirecional:** Edite eventos na tela ou em nossos celulares (Google Calendar).
* **Popup "Adicionar Evento":** Uma interface personalizada para adicionar eventos a calendários específicos diretamente da tela.
* **Clima e Data:** Cabeçalho bonito e de fácil visualização.
* **Responsivo:** Ajusta automaticamente a quantidade de dias exibidos conforme a largura da tela (Mobile vs Desktop).

---

## ⚙️ Guia de Instalação

*Nota: Esta configuração utiliza um **Pacote YAML** para criar automaticamente todos os auxiliares, scripts e variáveis necessários para você. Não é necessário criá-los manualmente.*



### 1. Pré-requisitos (HACS)

Você deve ter o [HACS](https://hacs.xyz/) instalado. Por favor, instale as seguintes integrações de **Frontend**:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Necessário para os popups funcionarem)
* `layout-card` (Necessário para a visualização de Seções)
* `button-card` (Necessário para o popup de adicionar evento)

### 2. O Backend (O Cérebro)

1. Abra seu arquivo `configuration.yaml` no Home Assistant.
2. Certifique-se de que você adicionou esta linha em `homeassistant:` para habilitar pacotes:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Crie uma pasta chamada `packages` no seu diretório de configuração do HA (se ainda não tiver uma).
4. Baixe [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) deste repositório.
5. Coloque o arquivo dentro da sua pasta `packages/`.
6. **Reinicie o Home Assistant**.

### 3. Os Calendários

Você pode usar **Google Calendars** ou **Calendários Locais**.

#### Opção A: Calendário Local (Mais Fácil)

Observe que isso não foi testado, pois uso exclusivamente Google Calendars

1. Vá em **Configurações > Dispositivos e Serviços**.
2. Adicione a integração **Calendário Local**.
3. Crie calendários com os nomes exatos: `Alice`, `Bob`, `Charlie`, `Daisy`, `Family`.
    * *Se usar esses nomes, o código funcionará direto!*

#### Opção B: Google Calendar

1. Abra o arquivo `packages/family_calendar.yaml`.
2. Role até o script `add_google_calendar_event`.
3. Atualize o `calendar_map` para apontar para suas entidades reais do Google:


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### Configurando Feriados

Desde as atualizações do Home Assistant, os feriados agora são adicionados via interface gráfica:

1. Vá em **Configurações > Dispositivos e Serviços > Adicionar Integração > Feriado**.
2. Selecione seu país.
3. Verifique o ID da entidade (ex.: `calendar.holidays`). Se for diferente do padrão, atualize no YAML do painel.

### 4. O Painel (A Aparência)

1. Crie uma nova Visualização de Painel (Defina o Tipo de Visualização como **Seções**).
2. Copie o código de [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).
3. **Personalize:**
   * **Buscar & Substituir:** Substitua `person.alice` pelas entidades reais dos membros da sua família.
   * **Clima:** Substitua `weather.home` pelo seu provedor de clima.
   * **Fundo:** Atualize o URL da imagem no final do yaml.

### Passo 5: O Tema (Opcional)

Para obter a aparência específica da fonte (Ovo):

1. Certifique-se de que seu `configuration.yaml` tenha esta linha sob `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Crie uma pasta chamada `themes` no seu diretório de configuração.
3. Baixe [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) e coloque-o nessa pasta.
4. Reinicie o Home Assistant.
5. Vá até o seu Perfil (ícone do usuário no canto inferior esquerdo) e altere o **Tema** para `Skylight`.
NOTA: O tema não é abrangente, portanto, tenha isso em mente

---

## 📐 Como Funciona (Por Trás dos Bastidores)

### Lógica de Filtro

O `week-planner-card` não suporta nativamente ocultar calendários específicos dinamicamente. Para resolver isso, usei **Input Texts** atuando como filtros Regex.

* Quando você clica no botão de uma pessoa, ele alterna o filtro entre `.*` (Mostrar tudo) e `^$` (Não mostrar nada).
* O `config-template-card` injeta essas variáveis dinamicamente no cartão de calendário.

### Script de Criação de Evento

O popup "Adicionar Evento" usa um único script que lida com a lógica para múltiplas pessoas e tipos de evento (Dia Inteiro vs Com Horário).


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## NOTAS

Minha postagem original foi apenas para dar uma visão geral de alto nível de como fazer isso e permitir que as pessoas ajustem o código para funcionar em seus cenários específicos.

Em particular, fiz isso porque cada display e necessidade são diferentes. Não posso desenvolver para todos os tamanhos potenciais de displays, dashboards, etc. Então, foi feito para funcionar no display que mencionei ou em qualquer outro (1920x1080), mas deve ser editável para outros.

Falando sobre display, originalmente sugeri aquele porque estava em promoção no Woot e era uma forma muito econômica de obter um display touchscreen na época. Isso pode não ser o caso agora, então use qualquer display que funcione para você. Tablet, touchscreen, celular, o que preferir. O principal que você precisará editar é o dashboard.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---