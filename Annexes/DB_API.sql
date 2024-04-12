/*==============================================================*/
/* Nom de SGBD :  Microsoft SQL Server 2017                     */
/* Date de création :  08.04.2022 17:13:05                      */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"TRANSACTION"') and o.name = 'FK_TRANSACT_REFERENCE_ACCOUNT')
alter table "TRANSACTION"
   drop constraint FK_TRANSACT_REFERENCE_ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"TRANSACTION"')
            and   type = 'U')
   drop table "TRANSACTION"
go

/*==============================================================*/
/* Table : ACCOUNT                                              */
/*==============================================================*/
create table ACCOUNT (
   ACCID                int                  not null,
   UID                  varchar(Max)         not null,
   USERNAME             varchar(Max)         not null,
   ACCAMOUNT            float                not null,
   constraint PK_ACCOUNT primary key (ACCID)
)
go

/*==============================================================*/
/* Table : "TRANSACTION"                                        */
/*==============================================================*/
create table "TRANSACTION" (
   TRANID               int                  not null,
   ACCID                int                  null,
   TRANDATEHOUR         date                 not null,
   TRANAMOUNT           float                not null,
   constraint PK_TRANSACTION primary key (TRANID)
)
go

alter table "TRANSACTION"
   add constraint FK_TRANSACT_REFERENCE_ACCOUNT foreign key (ACCID)
      references ACCOUNT (ACCID)
go

