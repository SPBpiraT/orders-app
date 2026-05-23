# orders-app

Пример реализации функциональности для работы с онлайн заказами.

## Стэк технологий
- .NET 9
- MVC
- EF Core
- PostgreSQL
- Bootstrap

## Запуск проекта

### Настройка и запуск БД

```sh
# Загрузить докер образ PostgreSQL
docker pull postgres

# Запуск контейнера с базой данных
docker run -itd -e POSTGRES_USER=admin -e POSTGRES_PASSWORD=admin -p 5432:5432 --name pgcontainer postgres
```

### Старт приложения
```sh
# Запустить проект в режиме разработки
dotnet run --launch-profile https
```

Доступ к приложению: https://localhost:7071
