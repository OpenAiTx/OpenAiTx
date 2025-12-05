<img src="https://raw.githubusercontent.com/franbarbalopez/mirror/master/art/logo.png" alt="Mirror 로고">

<div align="center">
    <img alt="Packagist 최신 버전" src="https://img.shields.io/packagist/v/franbarbalopez/mirror.svg">
    <img alt="GitHub 테스트 액션 상태" src="https://img.shields.io/github/actions/workflow/status/franbarbalopez/mirror/tests.yml?label=tests">
    <img alt="총 다운로드 수" src="https://img.shields.io/packagist/dt/franbarbalopez/mirror.svg">
    <img alt="라이선스" src="https://img.shields.io/packagist/l/franbarbalopez/mirror.svg">
</div>

# Mirror

Mirror는 Laravel용 우아한 사용자 가장 패키지입니다. 관리자가 문제 해결, 지원 제공 또는 사용자 경험 테스트를 위해 다른 사용자로 원활하게 로그인할 수 있도록 합니다. Mirror는 암호화 검증, 자동 만료, 다중 가드 지원, 유연한 미들웨어, 감사 로그를 위한 라이프사이클 이벤트로 세션 무결성을 처리합니다. 신뢰할 수 있고 안전한 사용자 가장이 필요한 프로덕션 애플리케이션에 완벽합니다.

## 기능

- 변조 방지를 위한 HMAC-SHA256 세션 무결성
- 구성 가능한 TTL 만료
- 접근 제어 및 TTL 시행을 위한 미들웨어
- 다중 가드 지원
- 유연한 URL 리디렉션
- 감사 로그를 위한 라이프사이클 이벤트

## 요구 사항

- PHP 8.2+
- Laravel 11+

## 설치

```bash
composer require franbarbalopez/mirror
```

선택 사항 - 구성 파일을 게시하십시오:

```bash
php artisan vendor:publish --tag=mirror
```

## 빠른 시작

### 1. 사용자 모델에 트레이트 추가하기

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

**중요:** `canImpersonate()`를 구현하지 않으면 모든 사용자가 모든 사용자를 가장할 수 있습니다. 이 트레이트는 기본적으로 `true`를 반환합니다.

### 2. 가장 시작하기

```php
use Mirror\Facades\Mirror;

public function impersonate(User $user)
{
    Mirror::start($user);

    return redirect()->route('dashboard');
}
```

### 3. 사칭 중지하기

```php
public function leave()
{
    Mirror::stop();

    return redirect()->route('admin.users.index');
}
```
## 보안

가장자 세션은 앱 키를 사용한 HMAC-SHA256 해시로 보호됩니다. 해시는 가장자 ID, 가드 이름, 시작 시간, 리디렉션 URL을 포함합니다. 매 `stop()` 호출 시 Mirror는 이 해시를 검증합니다 - 누군가 세션을 변조하면 예외를 발생시키고 모든 것을 삭제합니다.

`config/mirror.php`에서 TTL을 설정하여 세션이 일정 시간이 지나면 자동으로 만료되도록 구성하세요.

## API 참조

### 가장자 시작

사용자 인스턴스로:


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

기본 키로 (int, UUID, ULID 등과 함께 작동):

```php
Mirror::startByKey(123);

Mirror::startByKey('550e8400-e29b-41d4-a716-446655440000');
```
이메일로:


```php
Mirror::startByEmail('user@example.com');
```

### 사칭 방지

```php
Mirror::stop();

// Force stop - bypasses TTL check but still verifies integrity
Mirror::forceStop();
```

`forceStop()`는 관리자 작업이나 정리 스크립트에서 가장 impersonation을 종료해야 할 때 사용합니다 - TTL 검사를 건너뛰지만 세션이 변조된 경우 여전히 예외를 발생시킵니다.

### 상태 확인

```php
Mirror::isImpersonating(): bool
Mirror::getImpersonator(): ?Authenticatable
Mirror::impersonatorId(): int|string|null
Mirror::getLeaveRedirectUrl(): ?string
```

### 별칭

```php
Mirror::as($user);           // same as start()
Mirror::leave();             // same as stop()
Mirror::impersonating();     // same as isImpersonating()
Mirror::impersonator();      // same as getImpersonator()
```
## 미들웨어

### `mirror.ttl`

대리 세션이 만료되었는지 확인하고 필요 시 자동으로 `stop()`을 호출합니다:


```php
Route::middleware('mirror.ttl')->group(function () {
    Route::get('/admin/users', [UserController::class, 'index']);
    Route::get('/admin/users/{user}', [UserController::class, 'show']);
});
```

민감한 관리자 영역 보호에 적합하며 만료된 세션이 원활하게 종료되도록 합니다. TTL이 만료되면 이 미들웨어가 가장을 종료하고 리디렉션하므로 세션 정리가 제대로 설정되어 있는지 확인하세요.

### `mirror.require`

활성 가장 중일 때만 접근을 허용합니다:

```php
Route::middleware('mirror.require')->group(function () {
    Route::get('/impersonation/banner', function () {
        return view('impersonation.banner');
    });
});
```
특정 UI 구성 요소에 유용하며, 대리 실행 중에만 의미가 있는 구성 요소에 적합합니다 - 예를 들어, 대리 중인 사용자를 표시하는 배너와 같습니다.

### `mirror.prevent`

대리 실행 중 접근을 차단합니다:


```php
Route::middleware('mirror.prevent')->group(function () {
    Route::post('/admin/users/{user}/delete', [UserController::class, 'destroy']);
    Route::get('/admin/settings', [SettingsController::class, 'edit']);
});
```
파괴적인 작업 또는 원래 사용자로서만 액세스해야 하는 민감한 설정을 보호하며, 다른 사람을 가장하는 동안에는 접근할 수 없습니다.

## 권한 부여

`Impersonatable` 트레이트는 기본적으로 모두 `true`를 반환하는 두 가지 메서드를 제공합니다. 자체 로직을 추가하려면 이 메서드들을 재정의하세요:


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

트레이트가 필요 없습니다 - Mirror는 사용자 모델에서 이러한 메서드를 자동으로 찾습니다:

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

## URL 리디렉션

사용자가 가장하고자 할 때 시작 및 종료 시 이동할 위치를 제어할 수 있습니다:

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
`leaveRedirectUrl`을 지정하지 않으면 `start()`가 호출된 현재 URL이 기본값으로 사용됩니다.

## 이벤트

Mirror는 다음 두 가지 이벤트를 디스패치합니다:

- `Mirror\Events\ImpersonationStarted`
- `Mirror\Events\ImpersonationStopped`

두 이벤트 모두 가장자, 대상 사용자 및 가드 이름을 포함합니다. 감사 로그나 워크플로우 트리거에 유용합니다.

이벤트는 응답이 클라이언트에 전송된 **후에** 디스패치되어, 중요한 가장자 작업이 지연 없이 완료되도록 보장합니다. 이는 매 요청마다 실행될 수 있는 `mirror.ttl` 같은 미들웨어에 특히 중요합니다.


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

## 성능 및 최적화

Mirror는 고성능 애플리케이션을 위해 최적화되어 있습니다:

### 요청 범위 캐싱

대리자 모델은 중복된 데이터베이스 쿼리를 방지하기 위해 단일 요청 내에서 캐시됩니다:

```php
// This first call will query the database
$impersonator = Mirror::getImpersonator();

// Subsequent calls in the same request use the cached instance, therefore this one will not:
$impersonator = Mirror::getImpersonator();
```

이는 모든 요청에서 실행되는 `mirror.ttl`과 같은 미들웨어에 특히 유용합니다.

### 지연된 이벤트 디스패치

대리 이벤트는 클라이언트에 응답이 전송된 후에 디스패치되어, 이벤트 리스너가 응답 시간에 영향을 주지 않도록 합니다. 이는 요청 주기를 빠르게 유지하면서도 감사 로깅 및 기타 백그라운드 작업을 가능하게 합니다.

## 다중 가드 지원

Mirror는 사용 중인 가드를 자동으로 감지합니다:

```php
Auth::guard('admin')->login($admin);

Mirror::start($user); // uses 'admin' guard

Mirror::stop(); // restores to 'admin' guard
```

수동으로 가드를 지정할 필요가 없습니다 - 현재 인증 컨텍스트에서 자동으로 판단합니다.

## 블레이드 디렉티브

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

## 라이선스

MIT. 자세한 내용은 [LICENSE.md](https://raw.githubusercontent.com/franbarbalopez/mirror/master/LICENSE.md)를 참조하세요.

## 크레딧

[franbarbalopez](https://github.com/franbarbalopez)가 개발했습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-05

---