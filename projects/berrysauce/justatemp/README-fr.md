<h1 align="center">📮 Just a Temp</h1>
<p align="center">Le service gratuit d'email temporaire propulsé par Cloudflare
  <br>
  </br>
  <img alt="CodeQL" src="https://github.com/berrysauce/justatemp/actions/workflows/github-code-scanning/codeql/badge.svg">
  <img alt="GitHub release (latest by date including pre-releases)" src="https://img.shields.io/github/v/release/berrysauce/junk.boats?color=blue&include_prereleases&label=latest%20release">
</p>

> ℹ️ Ce service est 100% propulsé par [Cloudflare](https://www.cloudflare.com/)

> [!IMPORTANT]
> Ce projet était auparavant disponible sous le domaine "junk.boats".

### Qu'est-ce que justatemp.com ?
justatemp.com est un générateur d'emails temporaires, gratuit, open source et bien sûr respectueux de la vie privée. Vous pouvez utiliser justatemp.com pour recevoir des emails de sites auxquels vous ne souhaitez pas vraiment donner votre adresse email. Tous les emails reçus sont stockés publiquement pendant 2 heures puis supprimés définitivement.

<img alt="Just A Temp Screenshot" src="https://public-cdn.berrysauce.me/shared/justatemp-screenshot-yWtqO.png">

### Qu'en est-il de la vie privée ?
justatemp.com ne stocke que les emails reçus. Aucune autre donnée utilisateur n’est conservée. Les emails sont automatiquement supprimés après 2 heures. Jusqu’à ce moment, toute personne possédant l’adresse de réception peut consulter les emails reçus par cette adresse. Pour l’analytique, justatemp.com utilise l’outil d’analytique web anonyme de Cloudflare.

### Que sont collector, postmaster et postoffice ?
- 📮 `mailbox` est un worker email Cloudflare qui reçoit et stocke tous les mails entrants
- 🚚 `postservice` est le distributeur d’emails sous forme d’API propulsé par un worker Cloudflare HonoJS
- 🏤 `frontend` est le frontend SvelteKit qui affiche les emails reçus à l’utilisateur

### Comment fonctionne justatemp.com ?
Les mails entrants arrivent au worker email `mailbox`. Il sauvegarde l’email dans une base de données KV de Cloudflare. Le frontend Svelte génère une adresse email aléatoire et demande tous les emails pour cette adresse au `postservice`. Si des emails sont disponibles, il les affiche, triés par le timestamp UNIX inclus dans l’entrée KV.

### Développement
Plus d’informations bientôt


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---