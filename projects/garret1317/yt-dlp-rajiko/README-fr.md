# yt-dlp-rajiko

plugin extracteur amélioré pour [radiko.jp](https://radiko.jp) destiné à yt-dlp (rapide et sans restriction géographique)

<p>yt-dlp-rajiko vous permet de télécharger des émissions de radio japonaises depuis <a href="https://radiko.jp">radiko.jp</a> sans VPN, en utilisant <a href="https://github.com/yt-dlp/yt-dlp">yt-dlp</a>.
Le téléchargement est rapide, et fonctionne pour n’importe quelle station participante*, depuis n’importe où dans le monde.<br>
<small>*sauf NHK, mais ils ont <a href="https://www.nhk.or.jp/radio/">leur propre site</a> qui est supporté
dans yt-dlp officiel</small></p>


<p>Destiné à l’archivage personnel, pas à un usage commercial. Veuillez vous abonner à radiko Premium si vous le pouvez.<br>
<small>(C’est un logiciel libre, donc c’est juste une demande polie de ma part, pas une obligation. mais vous devriez le faire pour que radiko puisse continuer d’exister)<br>
(aussi, si vous prenez le plan timefree30 vous pouvez l’utiliser avec yt-dlp :P)
</small></p>

### [日本語  🇯🇵](https://427738.xyz/yt-dlp-rajiko/index.ja.html)

## Installation

[Téléchargez le bundle du plugin](https://427738.xyz/yt-dlp-rajiko/dl/yt_dlp_rajiko-latest.bundle.zip) ou `pip install yt-dlp-rajiko`

<p>Requiert yt-dlp 2025.02.19 ou une version plus récente.</p>

<p>Si vous avez installé yt-dlp avec pip, utilisez la commande pip ci-dessus.
Si vous avez installé yt-dlp avec <code>pipx</code>,
utilisez <code>pipx inject yt-dlp yt-dlp-rajiko</code> pour installer le plugin dans l’environnement de yt-dlp.</p>

<p>Si vous avez installé avec le .exe/binaire ou par toute autre méthode,
téléchargez le bundle et placez-le dans l’un de ces emplacements : </p>

<ul>
	<li><code>%appdata%\yt-dlp\plugins\</code> (sur Windows)</li>
	<li><code>~/.config/yt-dlp/plugins/</code> (sur Linux et Mac)</li>
	<li>un dossier <code>yt-dlp-plugins</code> à côté de votre <code>yt-dlp.exe</code> <a href="https://427738.xyz/yt-dlp-rajiko/i/installation-pluginsfolder2.png">(comme ceci)</a><br>
	<li>n’importe où ailleurs listé dans <a href="https://github.com/yt-dlp/yt-dlp#installing-plugins">la documentation yt-dlp</a>.</li>
</ul>

<p>Vous devrez créer ces dossiers s’ils n’existent pas déjà.<br>
<b>Il n’est pas nécessaire d’extraire le fichier zip.</b></p>

<p>Vous pouvez vérifier que l'installation a réussi en exécutant <code>yt-dlp -v</code> et en recherchant les lignes <code>[debug] Extractor Plugins :</code> ou <code>[debug] Plugin directories :</code>. <a href="https://427738.xyz/yt-dlp-rajiko/i/plugincheck.png">(comme ceci)</a>
</p>

Plus d'informations sur les plugins yt-dlp sont disponibles dans la [documentation de yt-dlp](https://github.com/yt-dlp/yt-dlp#plugins).

## Plus d'infos

[Veuillez consulter le site web pour plus d'informations](https://427738.xyz/yt-dlp-rajiko/) (utilisation, méthodes de contact, etc)

[Traduction en japonais également disponible](https://427738.xyz/yt-dlp-rajiko/index.ja.html)

## à propos de ce dépôt

c'est simplement l'endroit où le code source et le suivi des bugs sont hébergés. la plupart des informations se trouvent sur le site web.

Généralement, vous devriez utiliser les versions stables.
La branche `master` fonctionne habituellement, mais doit être considérée comme expérimentale et peut contenir des bugs.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---