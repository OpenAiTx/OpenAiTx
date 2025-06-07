# Pilote de File d’Attente RabbitMQ pour Laravel

[![Dernière version stable](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Nombre total de téléchargements](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Licence](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Style de code](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Une implémentation robuste du pilote de file d’attente RabbitMQ pour Laravel, offrant des capacités avancées de gestion des messages avec haute performance et fiabilité.

## Fonctionnalités

- Intégration native avec l’API de queue de Laravel
- Prise en charge des tâches différées/programmées
- Files d’attente à priorité
- Gestion des erreurs et tentatives automatiques
- Connexions sécurisées SSL/TLS
- Traitement parallèle avec plusieurs consommateurs
- Création et liaison automatique de files d’attente
- Options de configuration complètes des files d’attente
- Prise en charge des attributs de message RabbitMQ
- Dead letter exchanges (DLX)
- Paramètres de Qualité de Service (QoS)
- Prise en charge des files d’attente quorum

## Politique de Support

Seule la dernière version bénéficiera de nouvelles fonctionnalités. Les corrections de bugs seront fournies selon le schéma suivant :

| Version du package | Version Laravel | Version PHP | Corrections de bugs jusqu’au |                                                                                     |
|--------------------|-----------------|-------------|-----------------------------|-------------------------------------------------------------------------------------|
| 0.1                | 10, 11, 12      | ^8.2        | 26 août 2025                | [Documentation](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md) |

## Prérequis

- PHP 8.2+
- Laravel 10.x, 11.x, ou 12.x
- Serveur RabbitMQ 3.8+
- ext-pcntl (pour le traitement parallèle)

## Installation

Installez le package via Composer :

```bash
composer require iamfarhad/laravel-rabbitmq
```

Le package s’enregistrera automatiquement grâce à la découverte de package de Laravel.

Pour Lumen, enregistrez manuellement le fournisseur de service dans `bootstrap/app.php` :

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## Configuration

Ajoutez la connexion RabbitMQ à votre fichier `config/queue.php` :

```php
'connections' => [
    // ... autres connexions
    
    'rabbitmq' => [
        'driver' => 'rabbitmq',
        'queue'  => env('RABBITMQ_QUEUE', 'default'),

        'hosts' => [
            'host'      => env('RABBITMQ_HOST', '127.0.0.1'),
            'port'      => env('RABBITMQ_PORT', 5672),
            'user'      => env('RABBITMQ_USER', 'guest'),
            'password'  => env('RABBITMQ_PASSWORD', 'guest'),
            'vhost'     => env('RABBITMQ_VHOST', '/'),
            'lazy'      => env('RABBITMQ_LAZY_CONNECTION', true),
            'keepalive' => env('RABBITMQ_KEEPALIVE_CONNECTION', false),
            'heartbeat' => env('RABBITMQ_HEARTBEAT_CONNECTION', 0),
            'secure'    => env('RABBITMQ_SECURE', false),
        ],

        'options' => [
            'ssl_options' => [
                'cafile'      => env('RABBITMQ_SSL_CAFILE', null),
                'local_cert'  => env('RABBITMQ_SSL_LOCALCERT', null),
                'local_key'   => env('RABBITMQ_SSL_LOCALKEY', null),
                'verify_peer' => env('RABBITMQ_SSL_VERIFY_PEER', true),
                'passphrase'  => env('RABBITMQ_SSL_PASSPHRASE', null),
            ],
            'queue' => [
                'job' => \iamfarhad\LaravelRabbitMQ\Jobs\RabbitMQJob::class,
                'qos' => [
                    'prefetch_size'  => 0,
                    'prefetch_count' => 10,
                    'global'         => false
                ]
            ],
        ],
    ],
]
```

Ajoutez ces variables d’environnement à votre fichier `.env` :

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## Utilisation de Base

Une fois configuré, vous pouvez utiliser l’API Queue de Laravel normalement. Si vous connaissez déjà les files d’attente Laravel, vous n’avez rien à changer dans votre code.

### Dispatch de Tâches

```php
// Lancer une tâche dans la file d’attente par défaut
dispatch(new ProcessPodcast($podcast));

// Lancer une tâche dans une file d’attente spécifique
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// Lancer une tâche avec un délai
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### Création de Tâches

```php
namespace App\Jobs;

use Illuminate\Bus\Queueable;
use Illuminate\Contracts\Queue\ShouldQueue;
use Illuminate\Foundation\Bus\Dispatchable;
use Illuminate\Queue\InteractsWithQueue;
use Illuminate\Queue\SerializesModels;

class ProcessPodcast implements ShouldQueue
{
    use Dispatchable, InteractsWithQueue, Queueable, SerializesModels;

    public function __construct(private $podcast)
    {
        // Spécifier une file d’attente personnalisée
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // Traiter le podcast...
    }
}
```

## Consommation des Messages

Deux méthodes sont disponibles pour consommer les messages de RabbitMQ :

### 1. Ouvrier de file d’attente Laravel standard

L’ouvrier de queue intégré de Laravel qui utilise `basic_get` :

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. Consommateur RabbitMQ dédié

Ce package propose un consommateur spécialisé RabbitMQ qui utilise `basic_consume` et offre de meilleures performances :

```bash
php artisan rabbitmq:consume --queue=default
```

#### Options du Consommateur

```bash
php artisan rabbitmq:consume [options]
```

Options :

- `--connection=` : Nom de la connexion (par défaut, connexion par défaut)
- `--queue=` : Nom de la file d’attente à consommer
- `--name=default` : Nom du consommateur
- `--once` : Traite une seule tâche et quitte
- `--stop-when-empty` : Arrête lorsque la file d’attente est vide
- `--delay=0` : Délai pour les tâches échouées (secondes)
- `--max-jobs=0` : Nombre maximal de tâches à traiter avant arrêt
- `--max-time=0` : Durée maximale d’exécution en secondes
- `--memory=128` : Limite de mémoire en mégaoctets
- `--timeout=60` : Durée maximale d’exécution d’une tâche (secondes)
- `--tries=1` : Nombre de tentatives avant qu’une tâche soit considérée comme échouée
- `--max-priority=null` : Niveau de priorité maximal à consommer
- `--num-processes=2` : Nombre de processus parallèles à lancer

## Fonctionnalités Avancées

### Files d’Attente à Priorité

Pour utiliser les files à priorité :

1. Définissez la priorité maximale dans la configuration de votre file (1-255, où un nombre plus élevé indique une priorité supérieure)
2. Lancez des tâches avec priorité :

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### Traitement Parallèle

Lancez plusieurs processus consommateurs en parallèle :

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Qualité de Service (QoS)

Configurez les paramètres de préchargement dans la configuration de votre file d’attente :

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // Pas de limite de taille spécifique
        'prefetch_count' => 10,   // Traiter 10 messages à la fois
        'global'         => false // Appliquer par consommateur, pas par canal
    ]
]
```

### Connexions SSL/TLS

Pour activer les connexions sécurisées :

1. Mettez `secure` à `true` dans votre configuration
2. Configurez les options SSL avec les certificats appropriés

```php
'secure' => true,
'ssl_options' => [
    'cafile'      => '/chemin/vers/ca.pem',
    'local_cert'  => '/chemin/vers/cert.pem',
    'local_key'   => '/chemin/vers/key.pem',
    'verify_peer' => true,
    'passphrase'  => 'mot-de-passe-certificat',
],
```

## Gestion des Erreurs et Retentatives

Les tâches échouées sont automatiquement retentées selon l’option `--tries`. Les tâches dépassant le nombre maximal de tentatives sont déplacées dans la table des tâches échouées.

Vous pouvez personnaliser le comportement de retentative :

```php
// Dans votre classe de tâche
public function failed(Throwable $exception)
{
    // Gérer la tâche échouée
}

// Délai de retentative personnalisé
public function retryAfter()
{
    return 30; // secondes
}
```

## Contribution

Les contributions sont les bienvenues ! N’hésitez pas à soumettre une Pull Request.

1. Forkez le dépôt
2. Créez votre branche de fonctionnalité (`git checkout -b feature/fonctionnalite-incroyable`)
3. Commitez vos modifications (`git commit -m 'Ajout d’une fonctionnalité incroyable'`)
4. Poussez sur la branche (`git push origin feature/fonctionnalite-incroyable`)
5. Ouvrez une Pull Request

## Licence

Ce package est un logiciel open-source sous licence [MIT](https://raw.githubusercontent.com/iamfarhad/LaravelRabbitMQ/master/LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---