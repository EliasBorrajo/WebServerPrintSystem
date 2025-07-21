# WebServerPrintSystem 🖨️🗂️

> **Student‑card printing micro‑service built with ASP.NET Core 6, EF Core & SQL Server**

---

## 1 · Purpose

This project exposes a **REST API** that partner apps (e.g. university intranet or self‑service kiosks) can call to:

1. **Register students** (name, photo, study path).
2. **Generate & queue** printable ID‑card.
3. **Track** the print status (waiting → printed → collected).
4. **Retrieve statistics** (cards/day, failed jobs, ink usage).

The solution follows a classic multi‑tier layout:

| Layer  | Folder            | Responsibilities                          |
| ------ | ----------------- | ----------------------------------------- |
| API    | `StudentCardAPI/` | Controllers, DI, Swagger, DTO mappers     |
| BLL    | `BLL/`            | Domain logic, validation, queues, pricing |
| DAL    | `DAL/`            | EF Core DbContext & repositories          |
| Models | `DTO/`            | Data‑transfer objects (clean JSON)        |
| SQL    | `Annexes/`        | Seed scripts & diagrams                   |

> ---

## 2 · Features (MVP)

* 🆔 **Student CRUD** (GET · POST · PUT · DELETE / students).
* 🖨️ **Print queue** – background hosted service polls pending jobs & writes PDFs to a hot‑folder.
* 📊 **Admin stats endpoint** / metrics (total, per day, avg time).
* 📝 **Swagger UI** auto‑generated. 

---

## 3 · Sample requests

```http
GET /api/students                                       -- list all students
POST /api/students                                      -- add student
GET /api/students/{id}/card                             -- get card preview (PNG)
POST /api/print-jobs                                    -- enqueue print
GET /api/print-jobs/pending                             -- queue status
GET /api/metrics                                        -- global stats
```

All endpoints return **JSON** (except `/card` which streams an image).

## 4 · Authors

* **Elias Borrajo**
* **Milena Lonfat**
* **Jonathan Bourquin**
