<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <p>As traduções a seguir foram geradas automaticamente usando IA. Por favor, note que podem conter imprecisões ou referenciar versões anteriores deste readme.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

In Player Episode Preview
====================
## 📄 Sobre
Este plugin adiciona uma lista de episódios ao player de vídeo, permitindo que você visualize cada episódio da série sem precisar sair do player.

Esta modificação é compatível com os seguintes clientes:
* [Cliente Web Jellyfin](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) Cliente Desktop

## ✨ Funcionalidades
* Listar todos os episódios de uma temporada
* Alternar entre temporadas
* Exibir título do episódio, descrição, miniatura e progresso de reprodução
* Exibir detalhes do episódio como ranking da comunidade
* Marcar episódios como reproduzidos ou favoritos
* Iniciar um novo episódio
* Deve funcionar com temas personalizados

## 📸 Prévia
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Tema utilizado: (SkinManager) Kaleidochromic
<br>
Esta prévia não mostra os novos botões para marcar um episódio como concluído ou favorito.

## 🔧 Instalação

### Cliente Web Jellyfin (Servidor)

> [!NOTA]
> É altamente recomendado ter [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) pelo menos na versão v2.2.1.0 instalada. Isso ajuda a evitar problemas de permissão ao modificar o index.html em qualquer tipo de instalação!
<details open>
<summary> Ver instruções... </summary>

1. Adicione o manifesto `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` como um repositório de plugins Jellyfin ao seu servidor.
2. Instale o plugin `InPlayerEpisodePreview` a partir do repositório.
3. Reinicie o servidor Jellyfin.
</details>

### Cliente Desktop Jellyfin Media Player (JMP) (Descontinuado)
<details>
<summary> Ver instruções... </summary>

**Descontinuado com a versão JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

Como o novo cliente JMP está usando o player web atual do próprio servidor, não é mais necessário fazer alterações diretamente no código do cliente.

Esta é a forma recomendada de instalar o script no cliente desktop.
Se você não se sentir confortável editando o arquivo nativeshell.js por conta própria (passos 3 a 6), pode baixar o release completo, que já inclui o script adicionado ao arquivo nativeshell.js.
Ainda não está claro se pode haver problemas potenciais ao substituir o arquivo nativeshell.js pelo da versão release, portanto, é recomendado seguir todos os passos abaixo.

1. Baixe a versão mais recente [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) ou [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (inclui o script já adicionado ao arquivo nativeshell.js)
2. Extraia o arquivo zip no diretório do Jellyfin (ex.: C:\Program Files\Jellyfin\Jellyfin Media Player)
3. Dentro do diretório do Jellyfin, siga o caminho de pastas "web-client\extension"
4. Abra o arquivo "nativeshell.js" em um editor de texto.
5. Dentro do arquivo, encontre a seção `const plugins = [];`. Adicione uma nova linha no início da lista e cole `'inPlayerEpisodePreviewPlugin',`. A seção deverá ficar semelhante a isto:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Salve o arquivo e reinicie o cliente JMP.
</details>

## 💡 Solução de Problemas

### 1. O botão de pré-visualização não está visível
Isso provavelmente está relacionado a permissões incorretas para o arquivo `index.html`.

<details>
<summary> Veja uma lista de possíveis soluções... </summary>

#### 1.1 Evite esse problema usando o plugin [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation).

#### 1.2 Altere a propriedade dentro de um contêiner docker
Se você estiver executando o jellyfin em um contêiner docker, pode alterar a propriedade com o seguinte comando
(substitua jellyfin pelo nome do seu contêiner, usuário e grupo pelo usuário e grupo do seu contêiner):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Você pode executar isso como um trabalho cron na inicialização do sistema.
(Obrigado ao [muisje](https://github.com/muisje) por ajudar com [esta](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) solução)

#### 1.3 Alterar Propriedade em uma instalação Windows
1. Navegue até: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Clique com o botão direito em `index.html` → `Propriedades` → `Aba Segurança` → Clique em `Editar`
3. Selecione seu usuário na lista e marque a caixa de permissão de Escrita.
4. Reinicie tanto o servidor quanto o cliente.
   (Obrigado ao [xeuc](https://github.com/xeuc) por [esta](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) solução)

Se nenhuma das soluções acima funcionar, por favor veja os problemas antigos. Por exemplo [aqui](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) ou [aqui](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Se você encontrar qualquer erro que não consiga resolver sozinho, sinta-se à vontade para abrir um chamado.
<br/>Por favor, lembre-se que cada sistema é diferente, o que pode levar a comportamentos inesperados, então adicione o máximo de informações possível.
<br/>Logs do Jellyfin e logs de console do navegador (prefixados como [InPlayerEpisodePreview]) são sempre úteis.

## Créditos
A estrutura do plugin é baseada e inspirada no plugin [Jellyscrub](https://github.com/nicknsy/jellyscrub) de [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---