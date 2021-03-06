# 07 ORM

## общее

Для выполнения данного задания используется база _Northwind_
и одна из Micro-ORM (_Dapper_, _linq2db_, ... &mdash;
я рекомендую остановиться на _linq2db_).

## 01

Создать объектную модель и описать маппинг для таблиц базы _Northwind_.

Особое внимание обратить на:
*   Задание первичных ключей
*   Описание связей между сущностями
    и реализации отношений _1-М_, _М-М_

## 02

Продемонстрировать следующие запросы:
*   Список продуктов с категорией и поставщиком
*   Список сотрудников с указанием региона, за который они отвечают
*   Статистики по регионам: количества сотрудников по регионам
*   Списка «сотрудник &mdash; с какими грузоперевозчиками работал»
    (на основе заказов)

## 03

Продемонстрировать внесение изменений:
*   Добавить нового сотрудника и указать ему список территорий,
    за которые он несёт ответственность
*   Перенести продукты из одной категории в другую
*   Добавить список продуктов со своими поставщиками и категориями
    (массовое занесение),
    при этом если поставщик или категория с таким названием есть,
    то использовать их, иначе создать новые
*   Заменить продукта на аналогичный:
    во всех ещё не исполненных заказах
    (считать таковыми заказы, у которых `ShippedDate == NULL`)
    заменить один продукт на другой