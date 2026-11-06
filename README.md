# Лабораторная работа №4 — CI/CD и автоматизация тестирования

Модуль Calculator (C#, .NET 8) в трёх версиях, сгенерированных разными ИИ, и общий набор NUnit-тестов (29 тестов).

## Структура

    src/Module.Core/       библиотека с реализацией Calculator
    tests/Module.Tests/    NUnit-тесты
    .github/workflows/
      ci.yml               сборка и тесты при push и по кнопке Run workflow
      compare.yml          параллельный прогон трёх версий + единый отчёт

## Ветки

| Ветка | Содержимое |
|---|---|
| main | базовая версия и workflow-файлы |
| ai-version-1 | реализация AI-v1 |
| ai-version-2 | реализация AI-v2 |
| ai-version-3 | реализация AI-v3 |

## Локальный запуск

    dotnet restore
    dotnet build
    dotnet test --logger "console;verbosity=detailed"
