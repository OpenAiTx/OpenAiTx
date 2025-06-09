# Atualizar o DB do Browserslist

<img width="120" height="120" alt="Logo do Browserslist por Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

Ferramenta de linha de comando (CLI) para atualizar o `caniuse-lite` com o banco de dados de navegadores
a partir da configuração do [Browserslist](https://github.com/browserslist/browserslist/).

Algumas consultas como `last 2 versions` ou `>1%` dependem de dados reais
do `caniuse-lite`.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Patrocinado por Evil Martians" width="236" height="54">
</a>

## Por que você precisa executar regularmente

O comando `npx update-browserslist-db@latest` atualiza a versão do `caniuse-lite`
no seu arquivo de lock do npm, yarn ou pnpm.

Essa atualização trará dados sobre novos navegadores para ferramentas de polyfill
como Autoprefixer ou Babel e irá reduzir polyfills já desnecessários.

Você precisa fazer isso regularmente por três motivos:

1. Para usar as versões mais recentes dos navegadores e estatísticas em consultas como
   `last 2 versions` ou `>1%`. Por exemplo, se você criou seu projeto
   há 2 anos e não atualizou suas dependências, `last 1 version`
   irá retornar navegadores de 2 anos atrás.
2. Dados reais dos navegadores levam ao uso de menos polyfills. Isso irá reduzir
   o tamanho dos arquivos JS e CSS e melhorar a performance do site.
3. Deduplicação do `caniuse-lite`: para sincronizar versões em diferentes ferramentas.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---