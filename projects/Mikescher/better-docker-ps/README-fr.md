# ./dops - meilleur `docker ps`  
Un remplacement pour le docker-ps par défaut qui essaie vraiment de s’adapter à la largeur de votre terminal.

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/main.png)

## Justification

Par défaut, ma sortie `docker ps` est vraiment large et chaque ligne se replie en trois.  
Cela casse (évidemment) l’affichage tabulaire et rend tout chaotique.  
*(Cela devient particulièrement mauvais si un conteneur a plusieurs mappages de ports, tous affichés dans une seule ligne)*  
Il ne semble pas que nous aurons une sortie améliorée dans un avenir proche (voir [moby#7477](https://github.com/moby/moby/issues/7477)), donc j’ai décidé de faire mon propre remplacement prêt à l’emploi.

## Fonctionnalités

 - Toutes les options/flags en ligne de commande habituels de docker-ps fonctionnent *(presque)* de la même façon.  
 - Écrire les données multi-valeurs (comme plusieurs mappages de ports, plusieurs réseaux, etc.) sur plusieurs lignes au lieu de les concaténer.  
 - Ajouter de la couleur aux colonnes STATE et STATUS (vert / jaune / rouge).  
 - Supprimer automatiquement des colonnes dans la sortie jusqu’à ce qu’elle rentre dans la largeur actuelle du terminal.  
 - Trier la sortie avec l’argument `--sort`  
 - Entrer en mode surveillance avec l’argument `--watch`

Autres modifications par rapport au docker-ps par défaut :  
 - Afficher (par défaut) la commande du conteneur sans arguments.  
 - Afficher le nom de l’image (par défaut) sans le préfixe du registre, et séparer ImageName et ImageTag en deux colonnes.  
 - Ajout des colonnes IP et NETWORK dans l’ensemble de colonnes par défaut (si elles rentrent)  
 - Ajout du support pour quelques nouvelles colonnes (via --format) :  
   `{{.ImageName}`, `{{.ImageTag}`, `{{.Tag}`, `{{.ImageRegistry}`, `{{.Registry}`, `{{.ShortCommand}`, `{{.LabelKeys}`, `{{.IP}`                         
 - Ajout d’options pour contrôler la sortie colorée, la socket utilisée, le fuseau horaire et le format de l’heure, etc. (voir `./dops --help`)

## Pour commencer

### Linux générique (ex. Debian/Fedora/...)  
 - Téléchargez le dernier binaire depuis la [page des releases](https://github.com/Mikescher/better-docker-ps/releases) et placez-le dans votre PATH (ex. /usr/local/bin)  
 - Vous pouvez aussi utiliser la commande one-liner suivante (ensuite vous pourrez utiliser la commande `dops` partout) :
```
$> sudo wget "https://github.com/Mikescher/better-docker-ps/releases/latest/download/dops_linux-amd64-static" -O "/usr/local/bin/dops" && sudo chmod +x "/usr/local/bin/dops"
```

### ArchLinux
 - Alternativement, vous pouvez utiliser l'un des paquets AUR (sous Arch Linux) :
    * https://aur.archlinux.org/packages/dops-bin (installe `dops` dans votre PATH)
    * https://aur.archlinux.org/packages/dops-git (installe `dops` dans votre PATH)
 - ou le paquet homebrew : 
    * `brew tap mikescher/tap && brew install dops`

### Étapes optionnelles
 - Alias la commande docker ps en `dops` (voir [section ci-dessous](#usage-as-drop-in-replacement))

## Captures d'écran

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/fullsize.png)  
Toutes les colonnes (par défaut) visibles

&nbsp;

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/default.png)  
Sortie sur un terminal de taille moyenne

&nbsp;

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/small.png)  
Sortie sur un petit terminal

&nbsp;

## Utilisation en remplacement direct

Vous pouvez remplacer complètement docker ps en créant une fonction shell dans votre `.bashrc` / `.zshrc`...

~~~sh
docker() {
  case $1 in
    ps)
      shift
      command dops "$@"
      ;;
    *)
      command docker "$@";;
  esac
}
~~~

Cela va aliaser chaque appel à `docker ps ...` avec `dops ...` (assurez-vous que le binaire dops est dans votre PATH).

Si vous utilisez le shell fish, vous devez créer une fonction (similaire) :

~~~fish
function docker
    if test -n "$argv[1]"
        switch $argv[1]
            case ps
                dops $argv[2..-1]
            case '*'
                command docker $argv[1..-1]
        end
    end
end
~~~

## Changer le format de sortie

Par défaut, dops essaie d’être « intelligent » et de trouver le meilleur format de sortie pour la largeur de votre terminal.  
Les formats de sortie actuels (= colonnes du tableau) sont définis dans le fichier [options.go](https://github.com/Mikescher/better-docker-ps/blob/master/cli/options.go).  
Le premier format qui tient dans la largeur de votre terminal est utilisé.

Mais vous pouvez aussi le remplacer en fournissant un paramètre `--format`. Si vous fournissez plus d’un paramètre `--format`, le premier qui tient dans votre terminal est utilisé (même logique que pour les formats par défaut…).

Normalement, seules les colonnes simples alias `{{.Status}}` sont prises en charge.  
Mais vous pouvez aussi utiliser la syntaxe complète des templates golang (ex. `{{ printf "%.15s" .Command }}`).  
Dans ce cas, il peut être utile de spécifier l’en-tête de colonne en le préfixant d’un deux-points (`SHORTENED NAME:{{ printf "%.10s" (join .Names ";") }}`).

Les fonctions suivantes sont définies dans ces templates (plus les [fonctions go par défaut](https://pkg.go.dev/text/template)) :  
 - `join` : strings.Join  
 - `array_last` : v\[-1\]  
 - `array_slice` : v\[a..b\]  
 - `in_array` : v1.contains(v2)  
 - `json` : json.Marshal(v)
 - `json_indent` : json.MarshalIndent(v, "", "  ")
 - `json_pretty` : json.Indent(v, "", "  ")
 - `coalesce` : v1 ?? v2
 - `to_string` : fmt.Sprintf("%v", v)
 - `deref` : *v
 - `now` : time.Now()
 - `uniqid` : UUID

Exemples :
~~~~
$ ./dops --format "table {{.ID}}"
$ ./dops --format "table {{.ID}}\\t{{.Names}}\\t{{.State}}"

$ ./dops --format "idlist"

$ ./dops --format "table {{.ID}}\\t{{.Names}}\\t{{.State}}"  --format "table {{.ID}}\\t{{.Names}}" --format "table {{.ID}}"

$ ./dops --format "ID: {{.ID}}; Name: {{.Names}}"

$ ./dops -aq

$ ./dops --sort "IP" --sort-direction "ASC"

$ ./dops --format "table {{.ID}}\\tCMD:{{ printf \"%.15s\" .Command }}"
$ ./dops --format "table {{.ID}}\\tNAME:{{ printf \"%.10s\" (join .Names \";\") }}"

~~~~

## Configuration persistante

Vous pouvez également configurer certaines/la plupart des options via un fichier de configuration.  
Placez un fichier au format TOML dans `$HOME/.config/dops.conf` / `$XDG_CONFIG_HOME/dops.conf`.

Les clés suivantes sont supportées :
 - verbose
 - silent
 - timezone
 - timeformat
 - timeformat-header
 - color
 - socket  
 - tous  
 - taille  
 - filtre (= tableau de chaînes)  
 - format (= tableau de chaînes)  
 - dernier  
 - le plus récent  
 - tronquer  
 - en-tête (= vrai / faux / simple)  
 - tri (= tableau de chaînes)  
 - direction-du-tri (= tableau de chaînes)  

Exemple :
```toml
verbose = 0

timezone = "Europe/Berlin"

format = [
   "table {{.ID}}\t{{.Names}}\t{{.State}}\t{{.Status}}",
   "table {{.ID}}\t{{.Names}}\t{{.State}}",
   "table {{.ID}}\t{{.Names}}",
   "table {{.ID}}",
]

header = "simple"
```

## Manuel

Sortie de `./dops --help` :

~~~~~~
better-docker-ps

Utilisation :
  dops [OPTIONS]                     Lister les conteneurs Docker

Options (par défaut) :
  -h, --help                         Afficher cet écran.
  --version                          Afficher la version.
  --all , -a                         Afficher tous les conteneurs (par défaut, seuls les conteneurs en cours d'exécution sont affichés)
  --filter <ftr>, -f <ftr>           Filtrer la sortie selon les conditions fournies
  --format <fmt>                     Afficher joliment les conteneurs en utilisant un template Go
  --last , -n                        Afficher les n derniers conteneurs créés (inclut tous les états)
  --latest , -l                      Afficher le dernier conteneur créé (inclut tous les états)
  --no-trunc                         Ne pas tronquer la sortie (ex : IDs des conteneurs, références Sha256 des images, ligne de commande)
  --quiet , -q                       Afficher uniquement les IDs des conteneurs
  --size , -s                        Afficher la taille totale des fichiers

Options (supplémentaires | n'existent pas dans `docker ps`) :
  --silent                           Ne pas afficher de sortie
  --timezone                         Spécifier le fuseau horaire pour les sorties de date
  --color <true|false>               Activer/Désactiver la couleur dans le terminal
  --no-color                         Désactiver la couleur dans le terminal
  --socket <chemin_fichier>          Spécifier l'emplacement du socket Docker (Par défaut : `auto` - appelle le cli Docker pour déterminer le socket)
  --timeformat <go-time-fmt>         Spécifier le format de date et heure en sortie (syntaxe golang)
  --no-header                        Ne pas afficher l'en-tête du tableau
  --simple-header                    Ne pas afficher les lignes sous l'en-tête
  --format <fmt>                     Vous pouvez spécifier plusieurs formats et le premier qui convient à la largeur de votre terminal sera utilisé
  --sort <col>                       Trier la sortie par une colonne spécifique, utilisez le même identifiant que dans --format, utile uniquement avec les formats table 
  --sort-direction <ASC|DESC>        Direction du tri, utile uniquement en combinaison avec --sort
  --watch <interval>, -w <interval>  Actualiser automatiquement la sortie périodiquement (intervalle optionnel, défaut : 2s) 

Clés disponibles pour --format (par défaut) :
  {{.ID}}                            ID du conteneur
  {{.Image}}                         ID de l'image
  {{.Command}}                       Commande citée
  {{.CreatedAt}}                     Heure de création du conteneur.
  {{.RunningFor}}                    Durée écoulée depuis le démarrage du conteneur.
  {{.Ports}}                         Ports publiés. ([!] diffère de docker CLI, ce sont uniquement les ports publiés)
  {{.State}}                         État du conteneur
  {{.Status}}                        État du conteneur avec détails
  {{.Size}}                          Taille disque du conteneur.
  {{.Names}}                         Noms des conteneurs.
  {{.Labels}}                        Toutes les étiquettes assignées au conteneur.
  {{.Label}}                         [!] Non supporté
  {{.Mounts}}                        Noms des volumes montés dans ce conteneur.
  {{.Networks}}                      Noms des réseaux attachés à ce conteneur.

Clés --format disponibles (extra | n’existent pas dans `docker ps`) :
  {{.ImageName}}                     ID de l’image (sans tag ni registre)
  {{.ImageTag}}, {{.Tag}}            Tag de l’image
  {{.ImageRegistry}}, {{.Registry}}  Registre de l’image
  {{.ShortCommand}}                  Commande sans arguments
  {{.LabelKeys}}                     Toutes les étiquettes assignées au conteneur (clés uniquement)
  {{.ShortPublishedPorts}}           Ports publiés, sortie plus courte que {{.Ports}}
  {{.LongPublishedPorts}}            Ports publiés, sortie complète avec IP
  {{.ExposedPorts}}                  Ports exposés
  {{.PublishedPorts}}                Ports publiés
  {{.NotPublishedPorts}}             Ports exposés mais non publiés
  {{.PublicPorts}}                   Seulement la partie publique des ports publiés
  {{.IP}}                            Adresse IP interne
~~~~~~


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-16

---