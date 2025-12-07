<img src="https://raw.githubusercontent.com/franbarbalopez/mirror/master/art/logo.png" alt="Mirror Logo">

<div align="center">
    <img alt="Latest Version on Packagist" src="https://img.shields.io/packagist/v/franbarbalopez/mirror.svg">
    <img alt="GitHub Tests Action Status" src="https://img.shields.io/github/actions/workflow/status/franbarbalopez/mirror/tests.yml?label=tests">
    <img alt="Total Downloads" src="https://img.shields.io/packagist/dt/franbarbalopez/mirror.svg">
    <img alt="License" src="https://img.shields.io/packagist/l/franbarbalopez/mirror.svg">
</div>

# Mirror

Mirror is an elegant user impersonation package for Laravel. It allows administrators to seamlessly log in as other users to troubleshoot issues, provide support, or test user experiences. Mirror handles session integrity with cryptographic verification, automatic expiration, multi-guard support, flexible middleware, and lifecycle events for audit logging. Perfect for production applications that need reliable and secure user impersonation.

## Features

- HMAC-SHA256 session integrity to prevent tampering
- Configurable TTL expiration
- Middleware for access control and TTL enforcement
- Multi-guard support
- Flexible URL redirection
- Lifecycle events for audit logging

## Requirements

- PHP 8.2+
- Laravel 11+

## Installation

```bash
composer require franbarbalopez/mirror
```
Optional - publish the config file:


```bash
php artisan vendor:publish --tag=mirror
```

## Quick Start

### 1. Add Trait to User Model

```php
use Illuminate\Foundation\Auth\User as Authenticatable;
use Mirror\Concerns\Impersonatable;

class User extends Authenticatable
{
    use Impersonatable;

    public function canImpersonate(): bool
    {
        return $this->hasRole('admin');
    }

    public function canBeImpersonated(): bool
    {
        return ! $this->hasRole('super-admin');
    }
}
```

**Important:** If you don't implement `canImpersonate()`, everyone can impersonate everyone. The trait returns `true` by default.

### 2. Start Impersonating

```php
use Mirror\Facades\Mirror;

public function impersonate(User $user)
{
    Mirror::start($user);

    return redirect()->route('dashboard');
}
```

### 3. Stop Impersonating

```php
public function leave()
{
    Mirror::stop();

    return redirect()->route('admin.users.index');
}
```

## Security

Impersonation sessions are protected with HMAC-SHA256 hashes using your app key. The hash covers the impersonator ID, guard name, start time, and redirect URL. On every `stop()` call, Mirror verifies this hash - if someone's tampered with the session, it throws an exception and clears everything.

Configure TTL in `config/mirror.php` to automatically expire sessions after a set time.

## API Reference

### Starting Impersonation

By user instance:

```php
Mirror::start($user);

// With redirect URLs
$redirectUrl = Mirror::start(
    user: $targetUser,
    leaveRedirectUrl: route('admin.users.index'),
    startRedirectUrl: route('dashboard')
);

return redirect($redirectUrl);
```

By primary key (works with int, UUID, ULID, etc.):

```php
Mirror::startByKey(123);

Mirror::startByKey('550e8400-e29b-41d4-a716-446655440000');
```
By email:


```php
Mirror::startByEmail('user@example.com');
```

### Stopping Impersonation

```php
Mirror::stop();

// Force stop - bypasses TTL check but still verifies integrity
Mirror::forceStop();
```

Use `forceStop()` when you need to end impersonation from admin actions or cleanup scripts - it skips the TTL check but still throws if the session's been tampered with.

### Checking State

```php
Mirror::isImpersonating(): bool
Mirror::getImpersonator(): ?Authenticatable
Mirror::impersonatorId(): int|string|null
Mirror::getLeaveRedirectUrl(): ?string
```

### Aliases

```php
Mirror::as($user);           // same as start()
Mirror::leave();             // same as stop()
Mirror::impersonating();     // same as isImpersonating()
Mirror::impersonator();      // same as getImpersonator()
```

## Middleware

### `mirror.ttl`

Checks if the impersonation session has expired and automatically calls `stop()` if needed:

```php
Route::middleware('mirror.ttl')->group(function () {
    Route::get('/admin/users', [UserController::class, 'index']);
    Route::get('/admin/users/{user}', [UserController::class, 'show']);
});
```

Good for protecting sensitive admin areas where you want expired sessions to exit gracefully. Note that when TTL expires, this middleware will end the impersonation and redirect, so make sure your session cleanup is set up properly.

### `mirror.require`

Only allows access if actively impersonating:

```php
Route::middleware('mirror.require')->group(function () {
    Route::get('/impersonation/banner', function () {
        return view('impersonation.banner');
    });
});
```

Useful for special UI components that only make sense during impersonation - like a banner showing who you're impersonating.

### `mirror.prevent`

Blocks access while impersonating:

```php
Route::middleware('mirror.prevent')->group(function () {
    Route::post('/admin/users/{user}/delete', [UserController::class, 'destroy']);
    Route::get('/admin/settings', [SettingsController::class, 'edit']);
});
```

Protects destructive actions or sensitive settings that should only be accessed as the original user, not while impersonating someone else.

## Authorization

The `Impersonatable` trait provides two methods that both return `true` by default. Override them to add your own logic:

```php
use Mirror\Concerns\Impersonatable;

class User extends Authenticatable
{
    use Impersonatable;

    public function canImpersonate(): bool
    {
        return $this->hasRole('admin');
    }

    public function canBeImpersonated(): bool
    {
        return ! $this->hasRole('super-admin');
    }
}
```

You don't need the trait - Mirror will look for these methods on your user model regardless:

```php
class User extends Authenticatable
{
    public function canImpersonate(): bool
    {
        return $this->hasPermission('impersonate-users');
    }

    public function canBeImpersonated(): bool
    {
        return ! $this->is_system_account;
    }
}
```

## URL Redirection

You can control where users go when starting and stopping impersonation:

```php
public function impersonate(User $user)
{
    $redirectUrl = Mirror::start(
        user: $user,
        leaveRedirectUrl: route('admin.users.index'),  // where to go when they stop
        startRedirectUrl: route('dashboard')            // where to go right now
    );

    return redirect($redirectUrl);
}

public function leave()
{
    Mirror::stop();

    return redirect(Mirror::getLeaveRedirectUrl());
}
```
If you don't specify `leaveRedirectUrl`, it defaults to the current URL where `start()` was called.

## Events

Mirror dispatches two events you can listen to:

- `Mirror\Events\ImpersonationStarted`
- `Mirror\Events\ImpersonationStopped`

Both events contain the impersonator, the target user, and the guard name. Good for audit logs or triggering workflows.

Events are dispatched **after the response** is sent to the client, ensuring that critical impersonation operations complete without delay. This is especially important for middleware like `mirror.ttl` that may run on every request.


```php
use Mirror\Events\ImpersonationStarted;

Event::listen(ImpersonationStarted::class, function (ImpersonationStarted $event) {
    // Log the activity to your audit system of choice
    Log::info('User impersonation started', [
        'impersonator_id' => $event->impersonator->id,
        'impersonated_id' => $event->impersonated->id,
        'guard' => $event->guardName,
    ]);
});
```

## Performance & Optimization

Mirror is optimized for high-performance applications:

### Request-Scoped Caching

The impersonator model is cached within a single request to avoid redundant database queries:

```php
// This first call will query the database
$impersonator = Mirror::getImpersonator();

// Subsequent calls in the same request use the cached instance, therefore this one will not:
$impersonator = Mirror::getImpersonator();
```

This is particularly beneficial for middleware like `mirror.ttl` that run on every request.

### Deferred Event Dispatching

Impersonation events are dispatched after the response is sent to the client, ensuring that event listeners don't impact response time. This keeps your request cycle fast while still allowing audit logging and other background tasks.

## Multi-Guard Support

Mirror automatically detects which guard you're using:

```php
Auth::guard('admin')->login($admin);

Mirror::start($user); // uses 'admin' guard

Mirror::stop(); // restores to 'admin' guard
```
You don't need to specify the guard manually - it figures it out from the current auth context.

## Blade Directives

**@impersonating**


```blade
@impersonating
    <div class="alert">
        You're impersonating {{ auth()->user()->name }}.
        <a href="{{ route('impersonation.leave') }}">Exit</a>
    </div>
@endimpersonating

{{-- Check specific guard --}}
@impersonating('admin')
    <div>Impersonating via admin guard</div>
@endimpersonating
```

**@canImpersonate**

```blade
@canImpersonate
    <a href="{{ route('admin.users.index') }}">Manage Users</a>
@endcanImpersonate

{{-- With guard --}}
@canImpersonate('admin')
    <div>Admin tools</div>
@endcanImpersonate
```

**@canBeImpersonated**

```blade
{{-- Check current user --}}
@canBeImpersonated
    <span>Available for support</span>
@endcanBeImpersonated

{{-- Check specific user --}}
@canBeImpersonated($user)
    <form method="POST" action="{{ route('impersonation.start', $user) }}">
        @csrf
        <button>Impersonate</button>
    </form>
@endcanBeImpersonated

{{-- With guard --}}
@canBeImpersonated($user, 'admin')
    <button>Login as this user</button>
@endcanBeImpersonated
```

## License

MIT. See [LICENSE.md](https://raw.githubusercontent.com/franbarbalopez/mirror/master/LICENSE.md).

## Credits

Developed by [franbarbalopez](https://github.com/franbarbalopez).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---