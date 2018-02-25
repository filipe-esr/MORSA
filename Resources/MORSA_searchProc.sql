-- Procedimento de pesquisa dos astros
create proc MORSA.pr_searchAstro(@astroID varchar(11))
as
begin tran
	select * from MORSA.astro where id like '%'+@astroID+'%'
commit tran
go

-- Procedimento de pesquisa das companhias
-- Nota: GARANTIR que um dos parametros de entrada é NULL
-- Perguntar: a pesquisa com varchar(9) resulta todos os que tiverem aquela sequencia. char(9) so retorna se escrever os 9 digitos. Qual?
create proc MORSA.pr_searchCompanhia(@compNome varchar(35), @compNif varchar(9))
as
begin tran
	if(@compNif is null)
	begin
		select * from MORSA.companhia where nome like '%'+@compNome+'%'
	end
	else if(@compNome is null)
	begin
		select * from MORSA.companhia where nif like '%'+@compNif+'%'
	end
commit tran

-- Procedimento de pesquisa dos satelites
-- NOTA: GARANTIR que um dos parametros de entrada é NULL
-- Perguntar: Pesquisar por serviço? Pais?
create proc MORSA.pr_searchSatelite(@satNome varchar(35), @satID varchar(11))
as
begin tran
	if(@satID is null)
	begin
		select * from MORSA.satelite join MORSA.satelite_status on MORSA.satelite.id=MORSA.satelite_status.id 
		where nome like '%'+@satNome+'%'
	end
	else if(@satNome is null)
	begin
		select * from MORSA.satelite join MORSA.satelite_status on MORSA.satelite.id=MORSA.satelite_status.id 
		where MORSA.satelite.id like '%'+@satID+'%'
	end
commit tran

-- Procedimento de pesquisa das estações espaciais
-- NOTA: GARANTIR que um dos parametros de entrada é NULL
create proc MORSA.pr_searchEstacaoEspac(@eeNome varchar(35), @eeID varchar(11))
as
begin tran
	if(@eeID is null)
	begin
		select * from MORSA.estacaoEspacial join MORSA.estacaoEspacial_status on MORSA.estacaoEspacial.id=MORSA.estacaoEspacial_status.id 
		where nome like '%'+@eeNome+'%'
	end
	else if(@eeNome is null)
	begin
		select * from MORSA.estacaoEspacial join MORSA.estacaoEspacial_status on MORSA.estacaoEspacial.id=MORSA.estacaoEspacial_status.id
		where MORSA.estacaoEspacial.id like '%'+@eeID+'%'
	end
commit tran

-- Procedimento de pesquisa dos modulos de estacoes espaciais
-- NOTA: GARANTIR que um dos parametros de entrada é NULL
-- Perguntar: Pesquisar por estação? tipo?
create proc MORSA.pr_searchModuloEE(@mEENome varchar(35), @mEEID varchar(11))
as
begin tran
	if(@mEEID is null)
	begin
		select * from MORSA.moduloEstacaoEspacial where nome like '%'+@mEENome+'%'
	end
	else if(@mEENome is null)
	begin
		select * from MORSA.moduloEstacaoEspacial where id like '%'+@mEEID+'%'
	end
commit tran

-- Procedimento de pesquisa das orbitas
create proc MORSA.pr_searchOrbita(@orbID varchar(11))
as
begin tran
	select * from MORSA.orbita where id like '%'+@orbID+'%'
commit tran

-- Procedimento de pesquisa dos lancamentos
create proc MORSA.pr_searchLancamento(@lancID varchar(11))
as
begin tran
	select * from MORSA.lancamento join MORSA.veiculoLancamento on MORSA.lancamento.id=MORSA.veiculoLancamento.id
	where MORSA.lancamento.id like '%'+@lancID+'%'
commit tran





