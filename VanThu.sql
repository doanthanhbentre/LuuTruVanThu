--====================================================================
-- DBMS name:      IBM DB2 Version 10.x for Linux, UNIX, and Windows 
-- Created on:     05/13/2020 07:35:47 AM
--====================================================================


alter table VTLT.CBCCVC
   drop foreign key F_CBCCVC_COQUANBP;

alter table VTLT.DENGHI
   drop foreign key F_DENGHI_CBCCVC;

alter table VTLT.DENGHI
   drop foreign key F_DENGHI_COQUANBP;

alter table VTLT.TAPTIN
   drop foreign key F_TAPTIN_VANBAN;

alter table VTLT.VANBAN
   drop foreign key F_VANBAN_LINHVUC;

alter table VTLT.VANBAN
   drop foreign key F_VANBAN_LOAIVANBA;

alter table VTLT.VANBAN
   drop foreign key F_VANBAN_NGUOIDUYE;

alter table VTLT.VANBAN
   drop foreign key F_VANBAN_NGUOIKY;

alter table VTLT.VANBAN
   drop foreign key F_VANBAN_NGUOILUU;

alter table VTLT.VANBAN
   drop foreign key F_VANBAN_NGUOINHAN;

alter table VTLT.VANBAN
   drop foreign key F_VANBAN_NGUOISOAN;

alter table VTLT.VANBAN
   drop foreign key F_VANBAN_NOINHAN;

alter table VTLT.VANBAN
   drop foreign key F_VANBAN_SOLUU;

drop table VTLT.CBCCVC;

drop table VTLT.COQUANBP;

drop table VTLT.DENGHI;

drop table VTLT.LINHVUC;

drop table VTLT.LOAIVANBAN;

drop table VTLT.NGUOIDUNG;

drop table VTLT.SOLUU;

drop table VTLT.TAPTIN;

drop table VTLT.VANBAN;

drop tablespace TS_VANTHU;

create tablespace TS_VANTHU;

--==============================================================
-- User: VTLT
--==============================================================
--==============================================================
-- Table: CBCCVC
--==============================================================
create table VTLT.CBCCVC
(
   CBCCVCID             CHAR(5)                not null,
   MACQBP               CHAR(5),
   HOTEN                VARCHAR(100),
   constraint P_KEY_1 primary key (CBCCVCID)
)
in TS_VANTHU;

--==============================================================
-- Table: COQUANBP
--==============================================================
create table VTLT.COQUANBP
(
   MACQBP               CHAR(5)                not null,
   TENCQBP              VARCHAR(100),
   constraint P_KEY_1 primary key (MACQBP)
)
in TS_VANTHU;

--==============================================================
-- Table: DENGHI
--==============================================================
create table VTLT.DENGHI
(
   DENGHIID             CHAR(10)               not null,
   CBCCVCID             CHAR(5),
   MACQBP               CHAR(5),
   NGAY                 DATE,
   NOIDUNG              VARCHAR(500),
   YKIENGQ              VARCHAR(500),
   NGUOIGQ              CHAR(5),
   DONE                 SMALLINT,
   constraint P_KEY_1 primary key (DENGHIID)
)
in TS_VANTHU;

--==============================================================
-- Table: LINHVUC
--==============================================================
create table VTLT.LINHVUC
(
   LINHVUCID            CHAR(3)                not null,
   TENLINHVUC           VARCHAR(100),
   constraint P_KEY_1 primary key (LINHVUCID)
)
in TS_VANTHU;

--==============================================================
-- Table: LOAIVANBAN
--==============================================================
create table VTLT.LOAIVANBAN
(
   LOAIVBID             CHAR(2)                not null,
   TENLOAIVB            VARCHAR(100),
   constraint P_KEY_1 primary key (LOAIVBID)
)
in TS_VANTHU;

--==============================================================
-- Table: NGUOIDUNG
--==============================================================
create table VTLT.NGUOIDUNG
(
   TENDANGNHAP          CHAR(50)               not null,
   MATKHAU              VARCHAR(50),
   HOTEN                VARCHAR(100),
   constraint P_KEY_1 primary key (TENDANGNHAP)
)
in TS_VANTHU;

--==============================================================
-- Table: SOLUU
--==============================================================
create table VTLT.SOLUU
(
   SOLUUID              CHAR(6)                not null,
   TEN                  VARCHAR(100),
   constraint P_KEY_1 primary key (SOLUUID)
)
in TS_VANTHU;

--==============================================================
-- Table: TAPTIN
--==============================================================
create table VTLT.TAPTIN
(
   TAPTINID             CHAR(10)               not null,
   VANBANID             CHAR(10),
   DUONGDAN             VARCHAR(500),
   constraint P_KEY_1 primary key (TAPTINID)
)
in TS_VANTHU;

--==============================================================
-- Table: VANBAN
--==============================================================
create table VTLT.VANBAN
(
   VANBANID             CHAR(10)               not null,
   SOLUUID              CHAR(6),
   LINHVUCID            CHAR(3),
   LOAIVBID             CHAR(2),
   KYHIEU               VARCHAR(20),
   NGAY                 DATE,
   NOIDUNG              VARCHAR(500),
   NGUOISOAN            CHAR(5),
   NGUOIKY              CHAR(5),
   NGUOIDUYET           CHAR(5),
   NOINHAN              CHAR(5),
   NGUOINHAN            CHAR(5),
   NGUOILUU             CHAR(5),
   GHICHU               VARCHAR(500),
   DIDENNOIBO           SMALLINT,
   constraint P_KEY_1 primary key (VANBANID)
)
in TS_VANTHU;

alter table VTLT.CBCCVC
   add constraint F_CBCCVC_COQUANBP foreign key (MACQBP)
      references VTLT.COQUANBP (MACQBP)
      on delete restrict on update restrict;

alter table VTLT.DENGHI
   add constraint F_DENGHI_CBCCVC foreign key (CBCCVCID)
      references VTLT.CBCCVC (CBCCVCID)
      on delete restrict on update restrict;

alter table VTLT.DENGHI
   add constraint F_DENGHI_COQUANBP foreign key (MACQBP)
      references VTLT.COQUANBP (MACQBP)
      on delete restrict on update restrict;

alter table VTLT.TAPTIN
   add constraint F_TAPTIN_VANBAN foreign key (VANBANID)
      references VTLT.VANBAN (VANBANID)
      on delete restrict on update restrict;

alter table VTLT.VANBAN
   add constraint F_VANBAN_LINHVUC foreign key (LINHVUCID)
      references VTLT.LINHVUC (LINHVUCID)
      on delete restrict on update restrict;

alter table VTLT.VANBAN
   add constraint F_VANBAN_LOAIVANBA foreign key (LOAIVBID)
      references VTLT.LOAIVANBAN (LOAIVBID)
      on delete restrict on update restrict;

alter table VTLT.VANBAN
   add constraint F_VANBAN_NGUOIDUYE foreign key (NGUOIDUYET)
      references VTLT.CBCCVC (CBCCVCID)
      on delete restrict on update restrict;

alter table VTLT.VANBAN
   add constraint F_VANBAN_NGUOIKY foreign key (NGUOIKY)
      references VTLT.CBCCVC (CBCCVCID)
      on delete restrict on update restrict;

alter table VTLT.VANBAN
   add constraint F_VANBAN_NGUOILUU foreign key (NGUOILUU)
      references VTLT.CBCCVC (CBCCVCID)
      on delete restrict on update restrict;

alter table VTLT.VANBAN
   add constraint F_VANBAN_NGUOINHAN foreign key (NGUOINHAN)
      references VTLT.CBCCVC (CBCCVCID)
      on delete restrict on update restrict;

alter table VTLT.VANBAN
   add constraint F_VANBAN_NGUOISOAN foreign key (NGUOISOAN)
      references VTLT.CBCCVC (CBCCVCID)
      on delete restrict on update restrict;

alter table VTLT.VANBAN
   add constraint F_VANBAN_NOINHAN foreign key (NOINHAN)
      references VTLT.COQUANBP (MACQBP)
      on delete restrict on update restrict;

alter table VTLT.VANBAN
   add constraint F_VANBAN_SOLUU foreign key (SOLUUID)
      references VTLT.SOLUU (SOLUUID)
      on delete restrict on update restrict;

