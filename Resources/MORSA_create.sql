create schema MORSA
-- Tabela para registo das companhia existentes
create table MORSA.companhia(
	nome	VARCHAR(35)		NOT NULL,
	nif		CHAR(9)			NOT NULL,
	telef	CHAR(9)			NOT NULL,
	ender	VARCHAR(40)		NOT NULL,
	codPos	CHAR(8)			NOT NULL,
	sede	VARCHAR(20)		NOT NULL, --pais Sede
	CONSTRAINT companhiaPK PRIMARY KEY(nif),
	UNIQUE (telef)
);

-- Tabela para registo dos astros descobertos
create table MORSA.astro(
	id		VARCHAR(11) NOT NULL,
	tipo	VARCHAR(20)	NOT NULL,
	sistema	VARCHAR(20)	NOT NULL,
	galaxia	VARCHAR(20)	NOT NULL,
	CONSTRAINT astroPK PRIMARY KEY(id)
);

-- tabela para registo das orbitas e IDs do objecto ao qual estao associadas
create table MORSA.orbita(
	id			VARCHAR(11)	NOT NULL,
	apoastro	VARCHAR(10)	NOT NULL,
	periastro	VARCHAR(10)	NOT NULL,
	inclin		VARCHAR(7)	NOT NULL,
	periodo		VARCHAR(15)	NOT NULL,
	astro		VARCHAR(11),
	CONSTRAINT orbitaPK PRIMARY KEY(id),
	CONSTRAINT orbitaFK_astro FOREIGN KEY(astro) REFERENCES MORSA.astro(id)
);

-- Tabela para documentacao das companhiasLogistica
create table MORSA.companhiaLogistica(
	nif				CHAR(9)			NOT NULL,
	CONSTRAINT companhiaLogisticaPK PRIMARY KEY(nif),
	CONSTRAINT companhiaLogisticaFK_nif FOREIGN KEY(nif) REFERENCES MORSA.companhia(nif),
);

-- Tabela para criacao das estacoes espaciais
create table MORSA.estacaoEspacial(
	id			VARCHAR(11) NOT NULL,
	nome		VARCHAR(35),
	paisOrgan	VARCHAR(30),
	compLog		CHAR(9)		NOT NULL,
	CONSTRAINT estacaoEspacialPK PRIMARY KEY(id),
	CONSTRAINT estacaoEspacialFK_PK FOREIGN KEY(id) REFERENCES MORSA.orbita(id),
	CONSTRAINT estacaoEspacialFK_compLog FOREIGN KEY(compLog) REFERENCES MORSA.companhiaLogistica(nif)
);

-- Tabela para documentacao das companhiasMae
create table MORSA.companhiaMae(
	nif				CHAR(9)			NOT NULL,
	estacaoEspac	VARCHAR(11),
	CONSTRAINT companhiaMaePK PRIMARY KEY(nif),
	CONSTRAINT companhiaMaeFK_nif FOREIGN KEY(nif) references MORSA.companhia(nif),
	CONSTRAINT companhiaMaeFK_estacaoEspac FOREIGN KEY(estacaoEspac) references MORSA.estacaoEspacial(id)
);

-- Tabela multi valor para status da estacao espacial
create table MORSA.estacaoEspacial_status(
	id		VARCHAR(11)	NOT NULL,
	status	VARCHAR(9)	NOT NULL, --PROJETADO, ATIVO, DESATIVO
	CONSTRAINT estacaoEspacial_statusPK PRIMARY KEY(id, status),
	CONSTRAINT estacaoEspacial_statusFK FOREIGN KEY(id) REFERENCES MORSA.estacaoEspacial(id),
);

-- Tabela para registo dos lancamentos
create table MORSA.lancamento(
	id			VARCHAR(11)	NOT NULL,
	coord		VARCHAR(25)	NOT NULL, -- W 74.123456 N 56.654321
	pais		VARCHAR(20),
	dataTempo	DATETIME	NOT NULL,
	CONSTRAINT lancamentoPK PRIMARY KEY(id)
);

-- Tabela para registo dos veiculos de lançamento
create table MORSA.veiculoLancamento(
	id		VARCHAR(11)			NOT NULL,
	nome	VARCHAR(35),
	compLog CHAR(9)				NOT NULL,
	CONSTRAINT veiculoLancamentoPK PRIMARY KEY(id),
	constraint veiculoLancamentoFK_PK foreign key(id) references MORSA.lancamento(id),
	CONSTRAINT veiculoLancamentoFK FOREIGN KEY(compLog) REFERENCES MORSA.companhiaLogistica(nif)
);

-- Tabela para registo dos modulos de cada estacao espacial
create table MORSA.moduloEstacaoEspacial(
	id			VARCHAR(11)		NOT NULL,
	nome		VARCHAR(35),
	tipo		VARCHAR(20),
	compLog		CHAR(9)			NOT NULL,
	lancam		VARCHAR(11),
	estacaoEspac VARCHAR(11)	NOT NULL,
	CONSTRAINT moduloEstacaoEspacialPK PRIMARY KEY(id),
	CONSTRAINT moduloEstacaoEspacialFK_compLog	FOREIGN KEY(compLog) REFERENCES MORSA.companhiaLogistica(nif),
	CONSTRAINT moduloEstacaoEspacialFK_lancam FOREIGN KEY(lancam) REFERENCES MORSA.lancamento(id),
	CONSTRAINT moduloEstacaoEspacialFK_estacaoEspac FOREIGN KEY(estacaoEspac) REFERENCES MORSA.estacaoEspacial(id)
);

-- Tabela para registo dos satelites e suas companhiasLogistica e lancamentos
create table MORSA.satelite(
	id			VARCHAR(11) NOT NULL,
	nome		VARCHAR(35),
	servico		VARCHAR(20),
	paisOrgan	VARCHAR(20),
	compLog		CHAR(9)		NOT NULL,
	lancam		VARCHAR(11),
	CONSTRAINT satelitePK PRIMARY KEY(id),
	CONSTRAINT sateliteFK_compLog	FOREIGN KEY(compLog) REFERENCES MORSA.companhiaLogistica(nif),
	CONSTRAINT sateliteFK_PK FOREIGN KEY(id) REFERENCES MORSA.orbita(id),
	CONSTRAINT sateliteFK_lancam	FOREIGN KEY(lancam)	REFERENCES MORSA.lancamento(id)
);

-- Tabela para registo do status de um satelite
create table MORSA.satelite_status(
	id		VARCHAR(11)	NOT NULL,
	status	VARCHAR(9)	NOT NULL, --PROJETADO, ATIVO, DESATIVO
	CONSTRAINT satelite_statusPK PRIMARY KEY(id, status),
	CONSTRAINT satelite_statusFK FOREIGN KEY(id) REFERENCES MORSA.satelite(id)
);

-- Tabela para registo das companhias Mae de cada satelite
create table MORSA.satelite_companhiasMae(
	satelite		VARCHAR(11)	NOT NULL,
	companhia		CHAR(9)		NOT NULL,
	CONSTRAINT satelite_companhiasMaePK PRIMARY KEY(satelite,companhia),
	CONSTRAINT satelite_companhiasMaeFK_satelite	FOREIGN KEY(satelite) REFERENCES MORSA.satelite(id),
	CONSTRAINT satelite_companhiasMaeFK_companhia	FOREIGN KEY(companhia) REFERENCES MORSA.companhiaMae(nif)	
);

-- ALTER TABLE LANCAMENTO
--alter table veiculoLancamento add constraint veiculoLancamentoFK_PK foreign key(id) references lancamento(id);


-- DROP DAS TABELAS PELA ORDEM QUE RESPEITA CONSTRAINTS
--alter table veiculoLancamento drop constraint veiculoLancamentoFK_PK
drop table MORSA.satelite_companhiasMae;
drop table MORSA.satelite_status;
drop table MORSA.satelite;
drop table MORSA.moduloEstacaoEspacial;
drop table MORSA.veiculoLancamento;
drop table MORSA.lancamento;
drop table MORSA.companhiaMae;
drop table MORSA.estacaoEspacial_status;
drop table MORSA.estacaoEspacial;
drop table MORSA.companhiaLogistica;
drop table MORSA.companhia;
drop table MORSA.orbita;
drop table MORSA.astro;