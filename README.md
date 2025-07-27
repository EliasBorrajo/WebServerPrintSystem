# StudentCard SOAP Microservice for PrintSystem 🖨️🗂️

> *SOAP service for student card printing, exposed via WCF on .NET Framework 4.7.2, consumable by a Windows Forms application.*

---

## 📚 Project Description

This project provides a SOAP service implemented with WCF (.NET Framework 4.7.2) that allows:

* Registering students
* Managing print quotas
* Submitting and tracking student card print jobs

The service exposes WSDL operations accessible via an endpoint. A sample Windows Forms client illustrates consuming the service.

## 🧪 Technologies Used

| Type        | Name                                   | Version              |
| ----------- | -------------------------------------- | -------------------- |
| Language    | C#                                     |                      |
| Build Tool  | MSBuild (Visual Studio)                |                      |
| Framework   | WCF (Windows Communication Foundation) | .NET Framework 4.7.2 |
| Database    | SQL Server                             | 2017                 |
| Data Access | ADO.NET                                | built-in             |
|             |                                        |                      |

## 🎯 Learning Objectives

* Expose and consume SOAP services with WCF
* Design and use Data Transfer Objects (DTOs) in XML
* Implement database operations via ADO.NET
* Develop a Windows Forms application to consume the service
* Monitor and report service metrics

## 🏗 Project Structure

* `/API_StudentCard` — WCF implementation (`.svc` files, operation contracts)
* `/DAL` — data access layer (ADO.NET repositories)
* `/DTO` — XML-serializable request/response objects
* `/StudentCardAPI` — Windows Forms application consuming the service
* `/Annexes` — SQL scripts for database setup

## 📘 Documentation & Diagrams

* **WSDL endpoint**: `/API_StudentCard/ServiceAccount.svc?wsdl`
* **SQL scripts**: `/Annexes/DB_API.sql`
* **UML diagrams**: see `EliasBorrajo_MilenaLonfat_JonathanBourquin_604_3.docx` (pages TBD)
* **Sequence diagrams**: see `624-2ITMan_EliasBorrajo_MilenaLonfat_JonathanBourquin_604_3.pptx`

## 📌 Success Criteria Table

| Criterion                  | Status | Notes                                     |
| -------------------------- | ------ | ----------------------------------------- |
| SOAP endpoints exposed     | ✅ Done | `ServiceAccount.svc` endpoint functioning |
| Windows Forms client       | ✅ Done | `/StudentCardAPI` included                |
| Quota management endpoints | ✅ Done | `AddAmountByUsername`, `AddAmountByUID`   |
|                            |        |                                           |

## 👤 Authors

* **Elias Borrajo**&#x20;
* **Milena Lonfat**&#x20;
* **Jonathan Bourquin**&#x20;

---

**Project completed for the course**
**Information Technologies Infrastructure Library (ITIL) – Service Management**
**Instructors: David Wannier & Alain Duc, HES-SO Valais-Wallis**

