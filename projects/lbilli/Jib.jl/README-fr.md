# Jib

*Une implémentation Julia de l'API Interactive Brokers*

`Jib` est un client natif [Julia](https://julialang.org/) qui implémente
l'API [Interactive Brokers](https://www.interactivebrokers.com/) pour communiquer
avec TWS ou IBGateway.

Il vise à être complet en fonctionnalités, cependant il ne supporte pas les versions héritées.

Il est important de noter que l'API IB officielle a récemment adopté
Protocol Buffers comme format de transmission sous-jacent, remplaçant le protocole personnalisé hérité.
Ce paquet a suivi cette évolution et le support de ce dernier a été abandonné.

Actuellement, seules les versions d'API `v213+` sont supportées, ce qui correspond à
la version TWS `10.40` ou ultérieure.

La conception du paquet suit l'API officielle C++/Java
[IB API](https://interactivebrokers.github.io/tws-api/),
qui est basée sur un modèle de communication asynchrone via TCP.

## Installation
Pour installer depuis GitHub :
```julia
] add https://github.com/lbilli/Jib.jl
```
## Utilisation
L'utilisateur interagit principalement avec ces deux objets :
- `Connection` : un gestionnaire tenant une connexion avec le serveur
- `Wrapper` : un conteneur pour les callbacks qui sont invoqués
   lorsque les réponses du serveur sont traitées.

D'autres structures de données, telles que `Contract` et `Order`, sont implémentées comme des `struct` Julia
et reflètent les classes respectives dans l'API officielle IB.

Un exemple minimal complet fonctionnel est présenté.
Pour que ce code fonctionne, une instance de IB TWS ou IBGateway doit être en cours d'exécution
sur la machine locale et écouter sur le port `4002`.
**Note :** compte _demo_ ou _paper_ recommandé !! :smirk:

```julia
using Jib

wrap = Jib.Wrapper(
         # Customized methods go here
         error= (id, errorTime, errorCode, errorString, advancedOrderRejectJson) ->
                  println("Error: $(something(id, "NA")) $errorTime $errorCode $errorString $advancedOrderRejectJson"),

         nextValidId= (orderId) -> println("Next OrderId: $orderId"),

         managedAccounts= (accountsList) -> println("Managed Accounts: $accountsList")

         # more method overrides can go here...
       );

# Connect to the server with clientId = 1
ib = Jib.connect(4002, 1);

# Start a background Task to process the server responses
Jib.start_reader(ib, wrap);

# Define contract
contract = Jib.Contract(symbol="GOOG",
                        secType="STK",
                        exchange="SMART",
                        currency="USD");

# Define order
order = Jib.Order();
order.action        = "BUY"
order.totalQuantity = 10
order.orderType     = "LMT"
order.lmtPrice      = 100

orderId = 1    # Should match whatever is returned by the server

# Send order
Jib.placeOrder(ib, orderId, contract, order)

# Disconnect
Jib.disconnect(ib)
```
#### Traitement au premier plan vs. en arrière-plan  
Il est possible de traiter les réponses du serveur soit dans le processus principal  
soit dans une `Task` séparée en arrière-plan :  
- **le traitement au premier plan** est déclenché en invoquant `Jib.check_all(ib, wrap)`.  
  Il incombe à l'utilisateur de l'appeler **régulièrement**,  
  notamment lorsque les données arrivent en continu.  
- **le traitement en arrière-plan** est lancé par `Jib.start_reader(ib, wrap)`.  
  Une `Task` distincte est démarrée en arrière-plan, qui surveille la connexion et traite  
  les réponses à mesure qu'elles arrivent.  
  
Pour éviter des effets indésirables, les deux approches ne doivent pas être mélangées  
sur la même connexion.  
  
## Détails de l’implémentation  
Le paquet n’exporte aucun nom, donc toutes les fonctions  
ou types décrits ici doivent être préfixés par `Jib.*`.  
  
Comme Julia n’est pas un langage orienté objet, la fonctionnalité de la classe IB  
`EClient` est fournie ici par des fonctions régulières. En particulier :  
- `connect(port, clientId, connectOptions)`: établir une connexion et retourner  
  un objet `Connection`.  
- `disconnect(::Connection)`: terminer la connexion.  
- `check_all(::Connection, ::Wrapper)`: traiter les réponses disponibles, **sans blocage**.  
  Retourne le nombre de messages traités. **Doit être appelé régulièrement !**  
- `start_reader(::Connection, ::Wrapper)`: démarrer une `Task` pour le traitement en arrière-plan.  
- méthodes qui envoient des requêtes spécifiques au serveur.  
  Se référer à la documentation officielle de la classe IB `EClient` pour plus de détails et signatures.  
  La seule précaution est de passer un `Connection` comme premier argument : _ex._  
  `reqContractDetails(ib::Connection, reqId:Int, contract::Contract)`  
  
#### [`Wrapper`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl)  
Comme la classe officielle IB `EWrapper`, cette `struct` contient les callbacks  
qui sont dispatchés lors du traitement des réponses.  
L’utilisateur fournit les définitions des callbacks en arguments nommés  
dans le constructeur, comme montré [ci-dessus](#usage), et/ou en modifiant  
la propriété d’une instance existante.  
  
Un exemple plus complet est fourni par [`simple_wrap()`](https://raw.githubusercontent.com/lbilli/Jib.jl/master/src/wrapper.jl#L130),  
qui s’utilise ainsi :

```julia
using Jib: Jib, Contract, reqContractDetails, simple_wrap, start_reader

data, wrap = simple_wrap();

ib = Jib.connect(4002, 1);
start_reader(ib, wrap);

reqContractDetails(ib, 99, Contract(conId=208813720, exchange="SMART"))

# Wait for the response and then access the "ContractDetails" result:
data[:cd]
```
Grâce aux closures, `data` (un `Dict` dans ce cas) est accessible par toutes
les méthodes `wrap` ainsi que par le programme principal. C’est une manière de
propager les données entrantes vers différentes parties du programme.

Pour plus de détails sur les définitions et signatures des callbacks,
référez-vous à la documentation officielle de la classe IB `EWrapper`.
À titre de référence, les signatures exactes utilisées dans ce package
se trouvent [ici](https://raw.githubusercontent.com/lbilli/Jib.jl/master/data/wrapper_signatures.jl).

## Notes
Les callbacks sont généralement invoqués avec des arguments et types correspondant aux signatures
telles que décrites dans la documentation officielle.
Cependant, il existe quelques exceptions :
- `tickPrice()` a un argument supplémentaire `size::Float64`,
  qui n’a de sens que lorsque `TickType ∈ {BID, ASK, LAST}`.
  Dans ces cas, l’API officielle IB déclenche plutôt un événement `tickSize()` supplémentaire.
- `historicalData()` est invoqué une seule fois par requête,
  présentant toutes les données historiques sous la forme d’un seul `Vector{Bar}`,
  alors que l’API officielle IB l’invoque ligne par ligne.
- `scannerData()` est de même invoqué une fois par requête avec un `Vector{ScannerDataElement}`
  comme argument. Par conséquent, `scannerDataEnd()` est redondant et
  il **n’est pas** utilisé dans ce package.

Ces modifications permettent d’établir la règle :
_un callback par réponse serveur_.

#### Valeurs manquantes
Parfois, pour les types numériques, il est nécessaire de représenter
l’absence de valeur.

L’API IB n’a pas de solution uniforme à ce sujet, mais adopte plutôt
une variété de valeurs sentinelles.
Elles peuvent être soit le simple `0` soit la plus grande valeur représentable
d’un type donné comme `2147483647` et `9223372036854775807`
pour les entiers 32 et 64 bits respectivement ou `1.7976931348623157E308`
pour les flottants 64 bits.

Ce package fait un effort pour utiliser le `Nothing` intégré de Julia
dans toutes les circonstances.

#### Structures de données  
D’autres classes qui contiennent principalement des données sont également reproduites.  
Elles sont implémentées en Julia sous forme de `struct` ou `mutable struct` avec des noms,  
types et valeurs par défaut correspondant à leurs homologues dans l’API IB : _par exemple_  
`Contract`, `Order`, `ComboLeg`, `ExecutionFilter`, `ScannerSubscription`  
et `Condition*`.  

Les `TagValueList` sont implémentées en Julia sous forme de `NamedTuple`.  
Chaque fois qu’un TagValue est nécessaire, quelque chose comme ceci peut être utilisé :
```julia
tagvaluelist = (tag1="value1", tag2="value2")
# or, in case of an empty list:
emptylist = (;)
```
Les valeurs n'ont pas besoin d'être de type `String`. `Int` et `Float64` sont également autorisés.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-06

---