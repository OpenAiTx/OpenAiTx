# with-react

![GitHub Repo stars](https://img.shields.io/github/stars/jacobparis/with-react?style=social)
![npm](https://img.shields.io/npm/v/with-react?style=plastic)
![GitHub](https://img.shields.io/github/license/jacobparis/with-react?style=plastic)
![npm](https://img.shields.io/npm/dy/with-react?style=plastic)
![npm](https://img.shields.io/npm/dw/with-react?style=plastic)
![GitHub top language](https://img.shields.io/github/languages/top/jacobparis/with-react?style=plastic)

A collection of React components that wrap React hooks to provide a more composable API. Each component accepts a render prop that receives the hook's return value.

This enables a lot of features that previously violate the Rules of Hooks

## Conditional Hooks

```tsx
function UserProfile({ user, showDetails }) {
  return (
    <div>
      <h1>{user.name}</h1>

      <p>
        This is a really long description and there could be more markup
        or other components between here and the top of the component.
        Since hooks need to be declared at the top of the component function,
        instead of in the JSX, you may want to use WithState instead of useState
        just for colocation reasons.
      </p>

      {showDetails && (
        <WithState initialState={user.lastLogin}>
          {(lastLogin, setLastLogin) => (
            <div>
              Last login: {lastLogin}
              <button onClick={() => setLastLogin(new Date())}>
                Update
              </button>
            </div>
          )}
        </WithState>
      )}
    </div>
  )
}
```
<translate-content>

## 루프 내 훅

이것은 조건부 훅의 특별한 경우이지만, 때때로 루프에서 많은 항목을 렌더링하는데 부모 범위에서 너무 많은 데이터를 요구하기 때문에 사용자 정의 컴포넌트를 만드는 것이 가치가 없을 때가 있습니다.

하지만 각 항목에 상태를 추가해야 할 때, React는 이를 컴포넌트로 감싸도록 강제합니다. WithState를 사용하면 해당 컴포넌트가 제공되어 부모가 소유하는 리스트 항목을 유지할 수 있습니다.
</translate-content>
```tsx
const items = ['apple', 'banana', 'orange']

function FruitList() {
  return (
    <ul>
      {items.map((item) => (
        <WithState key={item} initialState={0}>
          {(count, setCount) => (
            <li>
              {item}: {count}
              <button onClick={() => setCount(count + 1)}>+</button>
            </li>
          )}
        </WithState>
      ))}
    </ul>
  )
}
```
## 폼 상태

react-dom의 `useFormStatus()` 훅은 모든 상위 `<form>`을 컨텍스트 제공자처럼 취급하므로, 반드시 폼의 자식 컴포넌트에서 사용해야 합니다.

`WithFormStatus`를 사용하여 컴포넌트 경계를 생성하는 것을 피하고 값을 인라인으로 가져오세요.


```tsx
function SearchForm() {
  return (
    <form action="/search">
      <input name="q" />
      <WithFormStatus>
        {(status) => (
          <button disabled={status.pending}>
            {status.pending ? 'Submitting...' : 'Submit'}
          </button>
        )}
      </WithFormStatus>
    </form>
  )
}
```
## 프로미스 해결

`use()` 훅은 프로미스를 해제할 수 있지만, 반드시 트리거하려는 서스펜스 경계의 자식에서 사용해야 합니다. 데이터는 경로 수준에서 가져오는 것이 가장 좋기 때문에, 이러한 프로미스들은 서스펜스 경계가 필요로 하는 UI보다 거의 항상 자연스럽게 상위에 위치합니다.

WithUse 컴포넌트는 프로미스를 전달하고 그 해결된 값을 컴포넌트 내에서 직접 받을 수 있게 해줍니다.

이 사용 사례는 [React Router의 Await 컴포넌트](https://reactrouter.com/api/components/Await)와 유사하며, 그쪽 이름이 더 좋지만 여기서는 테마에 맞춰야 했습니다.


```tsx
function UserDetails() {
  return (
    <div>
      <h1>User Details</h1>
      <Suspense fallback={<Spinner />}>
        <WithUse value={getUserPromise}>
          {(user) => (
            <div>
              <p>Name: {user.name}</p>
              <p>Email: {user.email}</p>
            </div>
          )}
        </WithUse>
      </Suspense>
    </div>
  )
}
```
## 사용 가능한 컴포넌트

WithState와 WithFormStatus가 가장 유용합니다
| Hook | 컴포넌트 |
|------|-----------|
| `useActionState` | `WithActionState` |
| `useCallback` | `WithCallback` |
| `useContext` | X |
| `useDeferredValue` | `WithDeferredValue` |
| `useEffect` | X |
| `useFormStatus` | `WithFormStatus` |
| `useId` | `WithId` |
| `useImperativeHandle` | X |
| `useInsertionEffect` | X |
| `useLayoutEffect` | X |
| `useMemo` | `WithMemo` |
| `useReducer` | `WithReducer` |
| `useRef` | X |
| `useState` | `WithState` |
| `useSyncExternalStore` | `WithSyncExternalStore` |
| `useTransition` | `WithTransition` |
| `use` | `WithUse` |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---